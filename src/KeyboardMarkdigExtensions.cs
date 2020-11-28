using Markdig.Extensions.Keyboard;
using Markdig.Helpers;

// Markdig.Keyboard
// https://github.com/cyotek/Markdig.Keyboard

// Copyright © 2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Markdig
{
  public static class KeyboardMarkdigExtensions
  {
    #region Public Methods

    public static MarkdownPipelineBuilder UseKeyboard(this MarkdownPipelineBuilder pipeline, KeyboardOptions options)
    {
      OrderedList<IMarkdownExtension> extensions = pipeline.Extensions;

      if (!extensions.Contains<KeyboardExtension>())
      {
        extensions.Add(new KeyboardExtension(options));
      }

      return pipeline;
    }

    public static MarkdownPipelineBuilder UseKeyboard(this MarkdownPipelineBuilder pipeline)
    {
      return pipeline.UseKeyboard(KeyboardOptions.Default);
    }

    #endregion Public Methods
  }
}