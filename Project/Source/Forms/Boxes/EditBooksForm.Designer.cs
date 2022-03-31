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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.ContextMenuStripResults = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSearchOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSearchWord = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenHebrewLetters = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionShowGrammarGuide = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopyName = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyFontChars = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyUnicodeChars = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionEditMemo = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ActionClose = new System.Windows.Forms.Button();
      this.ActionRestoreCommonNames = new System.Windows.Forms.LinkLabel();
      this.PanelMain = new System.Windows.Forms.Panel();
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.Transcription = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnLettriq = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnHasMemo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.ColumnMemo = new System.Windows.Forms.DataGridViewButtonColumn();
      this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnHebrew = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BookRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.ContextMenuStripResults.SuspendLayout();
      this.panel1.SuspendLayout();
      this.PanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BookRowBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // ContextMenuStripResults
      // 
      this.ContextMenuStripResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionOpen,
            this.toolStripSeparator2,
            this.ActionSearchOnline,
            this.ActionSearchWord,
            this.toolStripSeparator4,
            this.ActionOpenHebrewLetters,
            this.ActionShowGrammarGuide,
            this.toolStripSeparator1,
            this.ActionCopyName,
            this.ActionCopyFontChars,
            this.ActionCopyUnicodeChars,
            this.toolStripSeparator3,
            this.ActionEditMemo});
      this.ContextMenuStripResults.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStripResults, "ContextMenuStripResults");
      // 
      // ActionOpen
      // 
      resources.ApplyResources(this.ActionOpen, "ActionOpen");
      this.ActionOpen.Name = "ActionOpen";
      this.ActionOpen.Click += new System.EventHandler(this.ActionOpen_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      // 
      // ActionSearchOnline
      // 
      resources.ApplyResources(this.ActionSearchOnline, "ActionSearchOnline");
      this.ActionSearchOnline.Name = "ActionSearchOnline";
      // 
      // ActionSearchWord
      // 
      resources.ApplyResources(this.ActionSearchWord, "ActionSearchWord");
      this.ActionSearchWord.Name = "ActionSearchWord";
      this.ActionSearchWord.Click += new System.EventHandler(this.ActionSearchWord_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
      // 
      // ActionOpenHebrewLetters
      // 
      resources.ApplyResources(this.ActionOpenHebrewLetters, "ActionOpenHebrewLetters");
      this.ActionOpenHebrewLetters.Name = "ActionOpenHebrewLetters";
      this.ActionOpenHebrewLetters.Click += new System.EventHandler(this.ActionOpenHebrewLetters_Click);
      // 
      // ActionShowGrammarGuide
      // 
      resources.ApplyResources(this.ActionShowGrammarGuide, "ActionShowGrammarGuide");
      this.ActionShowGrammarGuide.Name = "ActionShowGrammarGuide";
      this.ActionShowGrammarGuide.Click += new System.EventHandler(this.ActionShowGrammarGuide_Click);
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
      // panel1
      // 
      this.panel1.Controls.Add(this.ActionClose);
      this.panel1.Controls.Add(this.ActionRestoreCommonNames);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // ActionClose
      // 
      resources.ApplyResources(this.ActionClose, "ActionClose");
      this.ActionClose.DialogResult = System.Windows.Forms.DialogResult.OK;
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
      this.PanelMain.Controls.Add(this.DataGridView);
      resources.ApplyResources(this.PanelMain, "PanelMain");
      this.PanelMain.Name = "PanelMain";
      // 
      // DataGridView
      // 
      this.DataGridView.AllowUserToAddRows = false;
      this.DataGridView.AllowUserToDeleteRows = false;
      this.DataGridView.AllowUserToResizeRows = false;
      this.DataGridView.AutoGenerateColumns = false;
      this.DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      resources.ApplyResources(this.DataGridView, "DataGridView");
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnHebrew,
            this.Transcription,
            this.ColumnTranslation,
            this.ColumnLettriq,
            this.ColumnHasMemo,
            this.ColumnMemo});
      this.DataGridView.ContextMenuStrip = this.ContextMenuStripResults;
      this.DataGridView.DataSource = this.BookRowBindingSource;
      this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.DataGridView.EnableHeadersVisualStyles = false;
      this.DataGridView.MultiSelect = false;
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.RowHeadersVisible = false;
      this.DataGridView.RowTemplate.Height = 28;
      this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DataGridView.ShowCellToolTips = false;
      this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
      this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
      this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
      this.DataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
      this.DataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_CellMouseDown);
      this.DataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
      // 
      // Transcription
      // 
      this.Transcription.DataPropertyName = "Transcription";
      resources.ApplyResources(this.Transcription, "Transcription");
      this.Transcription.Name = "Transcription";
      this.Transcription.ReadOnly = true;
      // 
      // ColumnLettriq
      // 
      this.ColumnLettriq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnLettriq.DataPropertyName = "Lettriq";
      resources.ApplyResources(this.ColumnLettriq, "ColumnLettriq");
      this.ColumnLettriq.Name = "ColumnLettriq";
      // 
      // ColumnHasMemo
      // 
      this.ColumnHasMemo.DataPropertyName = "HasMemo";
      resources.ApplyResources(this.ColumnHasMemo, "ColumnHasMemo");
      this.ColumnHasMemo.Name = "ColumnHasMemo";
      this.ColumnHasMemo.ReadOnly = true;
      this.ColumnHasMemo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // ColumnMemo
      // 
      this.ColumnMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnMemo.DataPropertyName = "Memo";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
      this.ColumnMemo.DefaultCellStyle = dataGridViewCellStyle3;
      resources.ApplyResources(this.ColumnMemo, "ColumnMemo");
      this.ColumnMemo.Name = "ColumnMemo";
      this.ColumnMemo.ReadOnly = true;
      this.ColumnMemo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.ColumnMemo.Text = "...";
      this.ColumnMemo.UseColumnTextForButtonValue = true;
      // 
      // ColumnNumber
      // 
      this.ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnNumber.DataPropertyName = "Number";
      this.ColumnNumber.Frozen = true;
      resources.ApplyResources(this.ColumnNumber, "ColumnNumber");
      this.ColumnNumber.Name = "ColumnNumber";
      this.ColumnNumber.ReadOnly = true;
      this.ColumnNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // ColumnHebrew
      // 
      this.ColumnHebrew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnHebrew.DataPropertyName = "Hebrew";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ColumnHebrew.DefaultCellStyle = dataGridViewCellStyle2;
      resources.ApplyResources(this.ColumnHebrew, "ColumnHebrew");
      this.ColumnHebrew.Name = "ColumnHebrew";
      this.ColumnHebrew.ReadOnly = true;
      this.ColumnHebrew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // ColumnTranslation
      // 
      this.ColumnTranslation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnTranslation.DataPropertyName = "Translation";
      resources.ApplyResources(this.ColumnTranslation, "ColumnTranslation");
      this.ColumnTranslation.Name = "ColumnTranslation";
      this.ColumnTranslation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // BookRowBindingSource
      // 
      this.BookRowBindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.BookRow);
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
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
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
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.Panel PanelMain;
    private System.Windows.Forms.LinkLabel ActionRestoreCommonNames;
    private BindingSource BookRowBindingSource;
    private DataGridView DataGridView;
    private Button ActionClose;
    private ToolStripMenuItem ActionShowGrammarGuide;
    private ToolStripMenuItem ActionOpen;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripSeparator4;
    private DataGridViewTextBoxColumn ColumnName;
    private DataGridViewTextBoxColumn ColumnNumber;
    private DataGridViewTextBoxColumn ColumnHebrew;
    private DataGridViewTextBoxColumn Transcription;
    private DataGridViewTextBoxColumn ColumnTranslation;
    private DataGridViewTextBoxColumn ColumnLettriq;
    private DataGridViewCheckBoxColumn ColumnHasMemo;
    private DataGridViewButtonColumn ColumnMemo;
  }
}