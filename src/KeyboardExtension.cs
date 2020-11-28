using Markdig.Helpers;
using Markdig.Parsers;
using Markdig.Renderers;

// Markdig.Keyboard
// https://github.com/cyotek/Markdig.Keyboard

// Copyright © 2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Markdig.Extensions.Keyboard
{
  public class KeyboardExtension : IMarkdownExtension
  {
    #region Private Fields

    private readonly KeyboardOptions _options;

    #endregion Private Fields

    #region Public Constructors

    public KeyboardExtension()
      : this(KeyboardOptions.Default)
    {
    }

    public KeyboardExtension(KeyboardOptions options)
    {
      _options = options;
    }

    #endregion Public Constructors

    #region Public Methods

    public void Setup(MarkdownPipelineBuilder pipeline)
    {
      OrderedList<InlineParser> parsers;

      parsers = pipeline.InlineParsers;

      if (!parsers.Contains<KeyboardInlineParser>())
      {
        parsers.Add(new KeyboardInlineParser());
      }
    }

    public void Setup(MarkdownPipeline pipeline, IMarkdownRenderer renderer)
    {
      if (renderer is HtmlRenderer htmlRenderer)
      {
        ObjectRendererCollection renderers;

        renderers = htmlRenderer.ObjectRenderers;

        if (!renderers.Contains<KeyboardHtmlRenderer>())
        {
          renderers.Add(new KeyboardHtmlRenderer(_options));
        }
      }
    }

    #endregion Public Methods
  }
}