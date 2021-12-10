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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.ContextMenuStripResults = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionSearchOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSearchWord = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
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
      this.ActionClose = new System.Windows.Forms.Button();
      this.ActionRestoreCommonNames = new System.Windows.Forms.LinkLabel();
      this.PanelMain = new System.Windows.Forms.Panel();
      this.EditBooks = new System.Windows.Forms.DataGridView();
      this.BookRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnHebrew = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ContextMenuStripResults.SuspendLayout();
      this.panel1.SuspendLayout();
      this.PanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditBooks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BookRowBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // ContextMenuStripResults
      // 
      this.ContextMenuStripResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionSearchOnline,
            this.toolStripSeparator2,
            this.ActionSearchWord,
            this.toolStripSeparator5,
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
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      // 
      // ActionSearchWord
      // 
      resources.ApplyResources(this.ActionSearchWord, "ActionSearchWord");
      this.ActionSearchWord.Name = "ActionSearchWord";
      this.ActionSearchWord.Click += new System.EventHandler(this.ActionSearchWord_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
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
      this.panel1.Controls.Add(this.ActionClose);
      this.panel1.Controls.Add(this.ActionRestoreCommonNames);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // ActionClose
      // 
      this.ActionClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      resources.ApplyResources(this.ActionClose, "ActionClose");
      this.ActionClose.Name = "ActionClose";
      this.ActionClose.UseVisualStyleBackColor = true;
      this.ActionClose.Click += new System.EventHandler(this.ActionClose_Click);
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
      // PanelMain
      // 
      this.PanelMain.Controls.Add(this.EditBooks);
      resources.ApplyResources(this.PanelMain, "PanelMain");
      this.PanelMain.Name = "PanelMain";
      // 
      // EditBooks
      // 
      this.EditBooks.AllowUserToAddRows = false;
      this.EditBooks.AllowUserToDeleteRows = false;
      this.EditBooks.AllowUserToResizeRows = false;
      this.EditBooks.AutoGenerateColumns = false;
      resources.ApplyResources(this.EditBooks, "EditBooks");
      this.EditBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnHebrew,
            this.ColumnName,
            this.ColumnTranslation});
      this.EditBooks.ContextMenuStrip = this.ContextMenuStripResults;
      this.EditBooks.DataSource = this.BookRowBindingSource;
      this.EditBooks.MultiSelect = false;
      this.EditBooks.Name = "EditBooks";
      this.EditBooks.RowHeadersVisible = false;
      this.EditBooks.RowTemplate.Height = 28;
      this.EditBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.EditBooks.ShowCellToolTips = false;
      this.EditBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BooksDataGridView_CellFormatting);
      this.EditBooks.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EditBooks_CellMouseDown);
      // 
      // BookRowBindingSource
      // 
      this.BookRowBindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.BookRow);
      // 
      // ColumnNumber
      // 
      this.ColumnNumber.DataPropertyName = "Number";
      resources.ApplyResources(this.ColumnNumber, "ColumnNumber");
      this.ColumnNumber.Name = "ColumnNumber";
      this.ColumnNumber.ReadOnly = true;
      this.ColumnNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // ColumnHebrew
      // 
      this.ColumnHebrew.DataPropertyName = "Hebrew";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ColumnHebrew.DefaultCellStyle = dataGridViewCellStyle1;
      resources.ApplyResources(this.ColumnHebrew, "ColumnHebrew");
      this.ColumnHebrew.Name = "ColumnHebrew";
      this.ColumnHebrew.ReadOnly = true;
      this.ColumnHebrew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // ColumnName
      // 
      this.ColumnName.DataPropertyName = "Name";
      resources.ApplyResources(this.ColumnName, "ColumnName");
      this.ColumnName.Name = "ColumnName";
      this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // ColumnTranslation
      // 
      this.ColumnTranslation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnTranslation.DataPropertyName = "Translation";
      resources.ApplyResources(this.ColumnTranslation, "ColumnTranslation");
      this.ColumnTranslation.Name = "ColumnTranslation";
      this.ColumnTranslation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // EditBooksForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.EditBooksFormClientSize;
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.panel1);
      this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "EditBooksFormClientSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditBooksForm";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.EditBooksForm_Load);
      this.ContextMenuStripResults.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.PanelMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.EditBooks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BookRowBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
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
    private BindingSource BookRowBindingSource;
    private DataGridView EditBooks;
    private ToolStripSeparator toolStripSeparator5;
    private Button ActionClose;
    private DataGridViewTextBoxColumn ColumnNumber;
    private DataGridViewTextBoxColumn ColumnHebrew;
    private DataGridViewTextBoxColumn ColumnName;
    private DataGridViewTextBoxColumn ColumnTranslation;
  }
}