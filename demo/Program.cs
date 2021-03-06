using Cyotek.Demo.Windows.Forms;
using System;
using System.Windows.Forms;

// Markdig.Keyboard
// https://github.com/cyotek/Markdig.Keyboard

// Copyright � 2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Markdig.Keyboard.Demo
{
  internal static class Program
  {
    #region Private Methods

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }

    #endregion Private Methods
  }
}