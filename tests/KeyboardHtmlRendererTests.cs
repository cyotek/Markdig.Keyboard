using NUnit.Framework;
using System.Collections.Generic;

// Markdig.Keyboard
// https://github.com/cyotek/Markdig.Keyboard

// Copyright © 2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Markdig.Extensions.Keyboard.Tests
{
  [TestFixture]
  public class KeyboardRendererTests
  {
    #region Public Properties

    public static IEnumerable<TestCaseData> KeyboardTestCaseSource
    {
      get
      {
        yield return new TestCaseData("Press <<?>> to continue", new KeyboardOptions(), "Press <kbd>?</kbd> to continue").SetName(nameof(KeyboardTestCases) + "Default");
        yield return new TestCaseData("<<>>", new KeyboardOptions(), "&lt;&lt;&gt;&gt;").SetName(nameof(KeyboardTestCases) + "Empty");
        yield return new TestCaseData("<<?>>", new KeyboardOptions
        {
          ClassName = "keyboard"
        }, "<kbd class=\"keyboard\">?</kbd>").SetName(nameof(KeyboardTestCases) + "WithClass");
        yield return new TestCaseData("<<?>>", new KeyboardOptions
        {
          TagName = "code"
        }, "<code>?</code>").SetName(nameof(KeyboardTestCases) + "WithTag");
        yield return new TestCaseData("<<?>>", new KeyboardOptions
        {
          ClassName = "keyboard",
          TagName = "code"
        }, "<code class=\"keyboard\">?</code>").SetName(nameof(KeyboardTestCases) + "WithClassAndTag");
      }
    }

    public static IEnumerable<TestCaseData> NonHtmlKeyboardTestCaseSource
    {
      get
      {
        yield return new TestCaseData("Press <<?>> to continue", new KeyboardOptions(), "Press ? to continue").SetName(nameof(NonHtmlKeyboardTestCases) + "Default");
        yield return new TestCaseData("<<>>", new KeyboardOptions(), "<<>>").SetName(nameof(NonHtmlKeyboardTestCases) + "Empty");
        yield return new TestCaseData("<<?>>", new KeyboardOptions
        {
          ClassName = "keyboard"
        }, "?").SetName(nameof(NonHtmlKeyboardTestCases) + "WithClass");
        yield return new TestCaseData("<<?>>", new KeyboardOptions
        {
          TagName = "code"
        }, "?").SetName(nameof(NonHtmlKeyboardTestCases) + "WithTag");
        yield return new TestCaseData("<<?>>", new KeyboardOptions
        {
          ClassName = "keyboard",
          TagName = "code"
        }, "?").SetName(nameof(NonHtmlKeyboardTestCases) + "WithClassAndTag");
      }
    }

    #endregion Public Properties

    #region Public Methods

    [Test]
    public void KeyboardExtension_WithAutoLinks_Parses()
    {
      // arrange
      MarkdownPipeline target;
      string expected;
      string actual;
      string input;

      target = new MarkdownPipelineBuilder()
        .UseAutoLinks()
        .UseKeyboard().Build();

      input = "Press <<Ctrl+O>> to open <http://www.example.com>";

      expected = "<p>Press <kbd>Ctrl+O</kbd> to open <a href=\"http://www.example.com\">http://www.example.com</a></p>\n";

      // act
      actual = Markdown.ToHtml(input, target);

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCaseSource(nameof(KeyboardTestCaseSource))]
    public void KeyboardTestCases(string input, KeyboardOptions options, string expected)
    {
      // arrange
      MarkdownPipeline target;
      string actual;

      target = new MarkdownPipelineBuilder()
        .UseKeyboard(options).Build();

      expected = "<p>" + expected + "</p>\n";

      // act
      actual = Markdown.ToHtml(input, target);

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCaseSource(nameof(NonHtmlKeyboardTestCaseSource))]
    public void NonHtmlKeyboardTestCases(string input, KeyboardOptions options, string expected)
    {
      // arrange
      MarkdownPipeline target;
      string actual;

      target = new MarkdownPipelineBuilder()
        .UseKeyboard(options).Build();

      expected += "\n";

      // act
      actual = Markdown.ToPlainText(input, target);

      // assert
      Assert.AreEqual(expected, actual);
    }

    #endregion Public Methods
  }
}