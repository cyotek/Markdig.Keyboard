// Markdig.Keyboard
// https://github.com/cyotek/Markdig.Keyboard

// Copyright © 2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Markdig.Extensions.Keyboard
{
  public class KeyboardOptions
  {
    #region Public Fields

    public static readonly KeyboardOptions Default = new KeyboardOptions();

    #endregion Public Fields

    #region Private Fields

    private string _className;

    private string _tagName;

    #endregion Private Fields

    #region Public Constructors

    public KeyboardOptions()
    {
      _tagName = "kbd";
    }

    #endregion Public Constructors

    #region Public Properties

    public string ClassName
    {
      get { return _className; }
      set { _className = value; }
    }

    public string TagName
    {
      get { return _tagName; }
      set { _tagName = value; }
    }

    #endregion Public Properties
  }
}