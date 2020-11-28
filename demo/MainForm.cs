using Cyotek.Windows.Forms;
using Markdig;
using Markdig.Extensions.Keyboard;
using System;
using System.Drawing;

// Markdig.Keyboard
// https://github.com/cyotek/Markdig.Keyboard

// Copyright © 2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Cyotek.Demo.Windows.Forms
{
  internal partial class MainForm : BaseForm
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
      Font font;

      base.OnLoad(e);

      font = this.GetFixedFont();
      inputTextBox.Font = font;
      outputTextBox.Font = font;
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

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

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void ClassNameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string value;

      value = InputDialog.ShowInputDialog("Enter CSS class &name:", this.Text, _options.ClassName);

      if (value != null)
      {
        _options.ClassName = value;

        this.UpdatePreview();
      }
    }

    private void CyotekLinkToolStripStatusLabel_Click(object sender, EventArgs e)
    {
      AboutDialog.OpenCyotekHomePage();

      cyotekLinkToolStripStatusLabel.LinkVisited = true;
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormatAsHTMLToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      this.UpdatePreview();
    }

    private Font GetFixedFont()
    {
      Font font;

      font = null;

      foreach (string fontName in new[]
                                  {
                                    "Fira Code",
                                    "Hack",
                                    "Source Code Pro",
                                    "Consolas",
                                    "Courier New"
                                  })
      {
        font = this.GetFont(fontName);

        if (font != null)
        {
          break;
        }
      }

      return font ?? SystemFonts.MessageBoxFont;
    }

    private Font GetFont(string fontFamilyName)
    {
      Font result;

      try
      {
        using (FontFamily family = new FontFamily(fontFamilyName))
        {
          result = family.IsStyleAvailable(FontStyle.Regular) ? new Font(family, 10, FontStyle.Regular) : null;
        }
      }
      catch (ArgumentException)
      {
        result = null;
      }

      return result;
    }

    private void InputTextBox_TextChanged(object sender, EventArgs e)
    {
      this.UpdatePreview();
    }

    private void TagNameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string value;

      value = InputDialog.ShowInputDialog("Enter HTML tag &name:", this.Text, _options.TagName);

      if (value != null)
      {
        _options.TagName = value;

        this.UpdatePreview();
      }
    }

    private void UpdatePreview()
    {
      string text;

      text = (formatAsHTMLToolStripMenuItem.Checked
        ? Markdown.ToHtml(inputTextBox.Text, _markdownPipeline)
        : Markdown.ToPlainText(inputTextBox.Text, _markdownPipeline))
        .Replace("\n", Environment.NewLine);

      outputTextBox.Text = text;

      webBrowser.DocumentText = text;
    }

    #endregion Private Methods
  }
}