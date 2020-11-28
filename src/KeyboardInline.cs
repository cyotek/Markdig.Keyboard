using Markdig.Helpers;
using Markdig.Syntax.Inlines;

// Markdig.Keyboard
// https://github.com/cyotek/Markdig.Keyboard

// Copyright © 2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Markdig.Extensions.Keyboard
{
  public class KeyboardInline : LeafInline
  {
    #region Private Fields

    private StringSlice _text;

    #endregion Private Fields

    #region Public Properties

    public StringSlice Text
    {
      get { return _text; }
      set { _text = value; }
    }

    #endregion Public Properties
  }
}