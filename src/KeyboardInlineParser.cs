using Markdig.Helpers;
using Markdig.Parsers;

// Markdig.Keyboard
// https://github.com/cyotek/Markdig.Keyboard

// Copyright © 2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Markdig.Extensions.Keyboard
{
  public class KeyboardInlineParser : InlineParser
  {
    #region Private Fields

    private static readonly char[] _openingCharacters =
    {
      '<'
    };

    #endregion Private Fields

    #region Public Constructors

    public KeyboardInlineParser()
    {
      this.OpeningCharacters = _openingCharacters;
    }

    #endregion Public Constructors

    #region Public Methods

    public override bool Match(InlineProcessor processor, ref StringSlice slice)
    {
      bool matchFound;
      char next;

      matchFound = false;

      next = slice.PeekCharExtra(1);

      if (next == '<')
      {
        char current;
        int start;
        int end;

        slice.NextChar();
        slice.NextChar(); // skip the opening pair

        current = slice.CurrentChar;
        start = slice.Start;
        end = start;

        while (current != '\0' && current != '>')
        {
          end++;
          current = slice.NextChar();
        }

        if (end > start && current == '>' && slice.PeekCharExtra(1) == '>')
        {
          int inlineStart;

          end--;
          inlineStart = processor.GetSourcePosition(slice.Start, out int line, out int column);

          processor.Inline = new KeyboardInline
          {
            Span =
            {
              Start = inlineStart,
              End = inlineStart + (end - start)
            },
            Line = line,
            Column = column,
            Text = new StringSlice(slice.Text, start, end)
          };

          slice.NextChar();
          slice.NextChar(); // skip the closing characters

          matchFound = true;
        }
      }

      return matchFound;
    }

    #endregion Public Methods
  }
}