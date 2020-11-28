using Markdig.Renderers;
using Markdig.Renderers.Html;

// Markdig.Keyboard
// https://github.com/cyotek/Markdig.Keyboard

// Copyright © 2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Markdig.Extensions.Keyboard
{
  public class KeyboardHtmlRenderer : HtmlObjectRenderer<KeyboardInline>
  {
    #region Private Fields

    private readonly KeyboardOptions _options;

    #endregion Private Fields

    #region Public Constructors

    public KeyboardHtmlRenderer(KeyboardOptions options)
    {
      _options = options;
    }

    #endregion Public Constructors

    #region Protected Methods

    protected override void Write(HtmlRenderer renderer, KeyboardInline obj)
    {
      renderer.Write('<')
        .Write(_options.TagName);
      if (!string.IsNullOrEmpty(_options.ClassName))
      {
        renderer.Write(' ')
          .Write("class=\"")
          .Write(_options.ClassName)
          .Write('"');
      }
      renderer.Write('>')
        .Write(obj.Text)
        .Write('<')
        .Write('/')
        .Write(_options.TagName)
        .Write('>');
    }

    #endregion Protected Methods
  }
}