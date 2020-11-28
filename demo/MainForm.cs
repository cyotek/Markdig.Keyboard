using Markdig.Extensions.Keyboard;
using System;
using System.Windows.Forms;

// Markdig.Keyboard
// https://github.com/cyotek/Markdig.Keyboard

// Copyright © 2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Markdig.Keyboard.Demo
{
  public partial class MainForm : Form
  {
    #region Private Fields

    private MarkdownPipeline _markdownPipeline;

    private KeyboardOptions _options;

    #endregion Private Fields

    #region Public Constructors

    public MainForm()
    {
      this.InitializeComponent();
    }

    #endregion Public Constructors

    #region Protected Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      _options = new KeyboardOptions();

      _markdownPipeline = new MarkdownPipelineBuilder()
        .UseAdvancedExtensions()
        .UseKeyboard(_options)
        .Build();

      inputTextBox.Text = @"### File Menu

| Description | Shortcut Keys |
| ----------- | ------------- |
| New         | <<Ctrl+N>>    |
| Open        | <<Ctrl+O>>    |
| Save        | <<Ctrl+S>>    |
| Save As     |               |
| Export      |               |
| Exit        | <<Alt+F4>>    |
";
    }

    #endregion Protected Methods

    #region Private Methods

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void InputTextBox_TextChanged(object sender, EventArgs e)
    {
      outputTextBox.Text = Markdown.ToHtml(inputTextBox.Text, _markdownPipeline); ;
    }

    #endregion Private Methods
  }
}