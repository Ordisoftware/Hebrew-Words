namespace Ordisoftware.Hebrew.Words
{
  partial class EditBooksForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBooksForm));
      this.EditBooks = new System.Windows.Forms.DataGridView();
      this.ContextMenuStripResults = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionSearchOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSearchWord = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenHebrewLetters = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopyName = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyFontChars = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyUnicodeChars = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionEditMemo = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ActionRestoreCommonNames = new System.Windows.Forms.LinkLabel();
      this.ActionClose = new System.Windows.Forms.Button();
      this.PanelMain = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.EditBooks)).BeginInit();
      this.ContextMenuStripResults.SuspendLayout();
      this.panel1.SuspendLayout();
      this.PanelMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // EditBooks
      // 
      this.EditBooks.AllowUserToAddRows = false;
      this.EditBooks.AllowUserToDeleteRows = false;
      this.EditBooks.AllowUserToResizeRows = false;
      resources.ApplyResources(this.EditBooks, "EditBooks");
      this.EditBooks.ContextMenuStrip = this.ContextMenuStripResults;
      this.EditBooks.MultiSelect = false;
      this.EditBooks.Name = "EditBooks";
      this.EditBooks.RowHeadersVisible = false;
      this.EditBooks.RowTemplate.Height = 28;
      this.EditBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.EditBooks.ShowCellToolTips = false;
      this.EditBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BooksDataGridView_CellFormatting);
      this.EditBooks.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EditBooks_CellMouseDown);
      // 
      // ContextMenuStripResults
      // 
      this.ContextMenuStripResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionSearchOnline,
            this.ActionSearchWord,
            this.toolStripSeparator2,
            this.ActionOpenHebrewLetters,
            this.toolStripSeparator1,
            this.ActionCopyName,
            this.ActionCopyFontChars,
            this.ActionCopyUnicodeChars,
            this.toolStripSeparator3,
            this.ActionEditMemo,
            this.toolStripSeparator4,
            this.ActionOpen});
      this.ContextMenuStripResults.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStripResults, "ContextMenuStripResults");
      // 
      // ActionSearchOnline
      // 
      resources.ApplyResources(this.ActionSearchOnline, "ActionSearchOnline");
      this.ActionSearchOnline.Name = "ActionSearchOnline";
      this.ActionSearchOnline.Click += new System.EventHandler(this.ActionSearchOnline_Click);
      // 
      // ActionSearchWord
      // 
      resources.ApplyResources(this.ActionSearchWord, "ActionSearchWord");
      this.ActionSearchWord.Name = "ActionSearchWord";
      this.ActionSearchWord.Click += new System.EventHandler(this.ActionSearchWord_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      // 
      // ActionOpenHebrewLetters
      // 
      resources.ApplyResources(this.ActionOpenHebrewLetters, "ActionOpenHebrewLetters");
      this.ActionOpenHebrewLetters.Name = "ActionOpenHebrewLetters";
      this.ActionOpenHebrewLetters.Click += new System.EventHandler(this.ActionOpenHebrewLetters_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      // 
      // ActionCopyName
      // 
      resources.ApplyResources(this.ActionCopyName, "ActionCopyName");
      this.ActionCopyName.Name = "ActionCopyName";
      this.ActionCopyName.Click += new System.EventHandler(this.ActionCopyName_Click);
      // 
      // ActionCopyFontChars
      // 
      resources.ApplyResources(this.ActionCopyFontChars, "ActionCopyFontChars");
      this.ActionCopyFontChars.Name = "ActionCopyFontChars";
      this.ActionCopyFontChars.Click += new System.EventHandler(this.ActionCopyFontChars_Click);
      // 
      // ActionCopyUnicodeChars
      // 
      resources.ApplyResources(this.ActionCopyUnicodeChars, "ActionCopyUnicodeChars");
      this.ActionCopyUnicodeChars.Name = "ActionCopyUnicodeChars";
      this.ActionCopyUnicodeChars.Click += new System.EventHandler(this.ActionCopyUnicodeChars_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
      // 
      // ActionEditMemo
      // 
      resources.ApplyResources(this.ActionEditMemo, "ActionEditMemo");
      this.ActionEditMemo.Name = "ActionEditMemo";
      this.ActionEditMemo.Click += new System.EventHandler(this.ActionEditMemo_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
      // 
      // ActionOpen
      // 
      resources.ApplyResources(this.ActionOpen, "ActionOpen");
      this.ActionOpen.Name = "ActionOpen";
      this.ActionOpen.Click += new System.EventHandler(this.ActionOpen_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ActionRestoreCommonNames);
      this.panel1.Controls.Add(this.ActionClose);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // ActionRestoreCommonNames
      // 
      this.ActionRestoreCommonNames.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      resources.ApplyResources(this.ActionRestoreCommonNames, "ActionRestoreCommonNames");
      this.ActionRestoreCommonNames.LinkColor = System.Drawing.Color.Navy;
      this.ActionRestoreCommonNames.Name = "ActionRestoreCommonNames";
      this.ActionRestoreCommonNames.TabStop = true;
      this.ActionRestoreCommonNames.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ActionRestoreCommonNames_LinkClicked);
      // 
      // ActionClose
      // 
      resources.ApplyResources(this.ActionClose, "ActionClose");
      this.ActionClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionClose.Name = "ActionClose";
      // 
      // PanelMain
      // 
      this.PanelMain.Controls.Add(this.EditBooks);
      resources.ApplyResources(this.PanelMain, "PanelMain");
      this.PanelMain.Name = "PanelMain";
      // 
      // EditBooksForm
      // 
      this.AcceptButton = this.ActionClose;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionClose;
      this.ClientSize = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.EditBooksFormClientSize;
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.panel1);
      this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "EditBooksFormClientSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditBooksForm";
      this.ShowInTaskbar = false;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditBooksForm_FormClosing);
      this.Load += new System.EventHandler(this.EditBooksForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.EditBooks)).EndInit();
      this.ContextMenuStripResults.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.PanelMain.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView EditBooks;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button ActionClose;
    private System.Windows.Forms.ContextMenuStrip ContextMenuStripResults;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenHebrewLetters;
    private System.Windows.Forms.ToolStripMenuItem ActionSearchOnline;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyName;
    private System.Windows.Forms.ToolStripMenuItem ActionEditMemo;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyFontChars;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyUnicodeChars;
    private System.Windows.Forms.ToolStripMenuItem ActionSearchWord;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.Panel PanelMain;
    private System.Windows.Forms.LinkLabel ActionRestoreCommonNames;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem ActionOpen;
  }
}