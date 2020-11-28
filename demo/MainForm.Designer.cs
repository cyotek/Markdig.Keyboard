namespace Cyotek.Demo.Windows.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.classNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tagNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.formatAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.cyotekLinkToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.inputTextBox = new System.Windows.Forms.TextBox();
      this.previewSplitContainer = new System.Windows.Forms.SplitContainer();
      this.outputTextBox = new System.Windows.Forms.TextBox();
      this.webBrowser = new System.Windows.Forms.WebBrowser();
      this.menuStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.previewSplitContainer)).BeginInit();
      this.previewSplitContainer.Panel1.SuspendLayout();
      this.previewSplitContainer.Panel2.SuspendLayout();
      this.previewSplitContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.menuStrip.Size = new System.Drawing.Size(784, 24);
      this.menuStrip.TabIndex = 0;
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classNameToolStripMenuItem,
            this.tagNameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.formatAsHTMLToolStripMenuItem});
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // classNameToolStripMenuItem
      // 
      this.classNameToolStripMenuItem.Name = "classNameToolStripMenuItem";
      this.classNameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.classNameToolStripMenuItem.Text = "&Class Name...";
      this.classNameToolStripMenuItem.Click += new System.EventHandler(this.ClassNameToolStripMenuItem_Click);
      // 
      // tagNameToolStripMenuItem
      // 
      this.tagNameToolStripMenuItem.Name = "tagNameToolStripMenuItem";
      this.tagNameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.tagNameToolStripMenuItem.Text = "&Tag Name...";
      this.tagNameToolStripMenuItem.Click += new System.EventHandler(this.TagNameToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
      // 
      // formatAsHTMLToolStripMenuItem
      // 
      this.formatAsHTMLToolStripMenuItem.Checked = true;
      this.formatAsHTMLToolStripMenuItem.CheckOnClick = true;
      this.formatAsHTMLToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.formatAsHTMLToolStripMenuItem.Name = "formatAsHTMLToolStripMenuItem";
      this.formatAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.formatAsHTMLToolStripMenuItem.Text = "Format as &HTML";
      this.formatAsHTMLToolStripMenuItem.CheckedChanged += new System.EventHandler(this.FormatAsHTMLToolStripMenuItem_CheckedChanged);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripStatusLabel,
            this.cyotekLinkToolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 539);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
      this.statusStrip.Size = new System.Drawing.Size(784, 22);
      this.statusStrip.TabIndex = 2;
      // 
      // statusToolStripStatusLabel
      // 
      this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
      this.statusToolStripStatusLabel.Size = new System.Drawing.Size(672, 17);
      this.statusToolStripStatusLabel.Spring = true;
      this.statusToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cyotekLinkToolStripStatusLabel
      // 
      this.cyotekLinkToolStripStatusLabel.IsLink = true;
      this.cyotekLinkToolStripStatusLabel.Name = "cyotekLinkToolStripStatusLabel";
      this.cyotekLinkToolStripStatusLabel.Size = new System.Drawing.Size(99, 17);
      this.cyotekLinkToolStripStatusLabel.Text = "www.cyotek.com";
      this.cyotekLinkToolStripStatusLabel.Click += new System.EventHandler(this.CyotekLinkToolStripStatusLabel_Click);
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.Location = new System.Drawing.Point(0, 24);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.inputTextBox);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.previewSplitContainer);
      this.splitContainer.Size = new System.Drawing.Size(784, 515);
      this.splitContainer.SplitterDistance = 389;
      this.splitContainer.SplitterWidth = 3;
      this.splitContainer.TabIndex = 3;
      // 
      // inputTextBox
      // 
      this.inputTextBox.AcceptsReturn = true;
      this.inputTextBox.AcceptsTab = true;
      this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.inputTextBox.HideSelection = false;
      this.inputTextBox.Location = new System.Drawing.Point(0, 0);
      this.inputTextBox.Multiline = true;
      this.inputTextBox.Name = "inputTextBox";
      this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.inputTextBox.Size = new System.Drawing.Size(389, 515);
      this.inputTextBox.TabIndex = 0;
      this.inputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
      // 
      // previewSplitContainer
      // 
      this.previewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.previewSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.previewSplitContainer.Name = "previewSplitContainer";
      this.previewSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // previewSplitContainer.Panel1
      // 
      this.previewSplitContainer.Panel1.Controls.Add(this.outputTextBox);
      // 
      // previewSplitContainer.Panel2
      // 
      this.previewSplitContainer.Panel2.Controls.Add(this.webBrowser);
      this.previewSplitContainer.Size = new System.Drawing.Size(392, 515);
      this.previewSplitContainer.SplitterDistance = 252;
      this.previewSplitContainer.TabIndex = 5;
      // 
      // outputTextBox
      // 
      this.outputTextBox.AcceptsReturn = true;
      this.outputTextBox.AcceptsTab = true;
      this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.outputTextBox.HideSelection = false;
      this.outputTextBox.Location = new System.Drawing.Point(0, 0);
      this.outputTextBox.Multiline = true;
      this.outputTextBox.Name = "outputTextBox";
      this.outputTextBox.ReadOnly = true;
      this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.outputTextBox.Size = new System.Drawing.Size(392, 252);
      this.outputTextBox.TabIndex = 4;
      // 
      // webBrowser
      // 
      this.webBrowser.AllowWebBrowserDrop = false;
      this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webBrowser.IsWebBrowserContextMenuEnabled = false;
      this.webBrowser.Location = new System.Drawing.Point(0, 0);
      this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser.Name = "webBrowser";
      this.webBrowser.ScriptErrorsSuppressed = true;
      this.webBrowser.Size = new System.Drawing.Size(392, 259);
      this.webBrowser.TabIndex = 0;
      this.webBrowser.WebBrowserShortcutsEnabled = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.menuStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip;
      this.MaximizeBox = true;
      this.MinimizeBox = true;
      this.Name = "MainForm";
      this.ShowIcon = true;
      this.ShowInTaskbar = true;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Markdig Keyboard Demo";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel1.PerformLayout();
      this.splitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
      this.splitContainer.ResumeLayout(false);
      this.previewSplitContainer.Panel1.ResumeLayout(false);
      this.previewSplitContainer.Panel1.PerformLayout();
      this.previewSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.previewSplitContainer)).EndInit();
      this.previewSplitContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.TextBox inputTextBox;
    private System.Windows.Forms.TextBox outputTextBox;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel cyotekLinkToolStripStatusLabel;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem classNameToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tagNameToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem formatAsHTMLToolStripMenuItem;
    private System.Windows.Forms.SplitContainer previewSplitContainer;
    private System.Windows.Forms.WebBrowser webBrowser;
  }
}

