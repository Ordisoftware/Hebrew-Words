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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      this.ContextMenuResults = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSearchOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSearchWord = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionShowGrammarGuide = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionOpenHebrewLetters = new System.Windows.Forms.ToolStripMenuItem();
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
      this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnHebrew = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Transcription = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnCommonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnLettriq = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnHasMemo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.ColumnMemo = new System.Windows.Forms.DataGridViewButtonColumn();
      this.ContextMenuResults.SuspendLayout();
      this.panel1.SuspendLayout();
      this.PanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // ContextMenuResults
      // 
      resources.ApplyResources(this.ContextMenuResults, "ContextMenuResults");
      this.ContextMenuResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionOpen,
            this.toolStripSeparator2,
            this.ActionSearchOnline,
            this.ActionSearchWord,
            this.toolStripSeparator4,
            this.ActionShowGrammarGuide,
            this.ActionOpenHebrewLetters,
            this.toolStripSeparator1,
            this.ActionCopyName,
            this.ActionCopyFontChars,
            this.ActionCopyUnicodeChars,
            this.toolStripSeparator3,
            this.ActionEditMemo});
      this.ContextMenuResults.Name = "ContextMenuStrip";
      // 
      // ActionOpen
      // 
      resources.ApplyResources(this.ActionOpen, "ActionOpen");
      this.ActionOpen.Name = "ActionOpen";
      this.ActionOpen.Click += new System.EventHandler(this.ActionOpen_Click);
      // 
      // toolStripSeparator2
      // 
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      this.toolStripSeparator2.Name = "toolStripSeparator2";
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
      resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      // 
      // ActionShowGrammarGuide
      // 
      resources.ApplyResources(this.ActionShowGrammarGuide, "ActionShowGrammarGuide");
      this.ActionShowGrammarGuide.Name = "ActionShowGrammarGuide";
      this.ActionShowGrammarGuide.Click += new System.EventHandler(this.ActionShowGrammarGuide_Click);
      // 
      // ActionOpenHebrewLetters
      // 
      resources.ApplyResources(this.ActionOpenHebrewLetters, "ActionOpenHebrewLetters");
      this.ActionOpenHebrewLetters.Name = "ActionOpenHebrewLetters";
      this.ActionOpenHebrewLetters.Click += new System.EventHandler(this.ActionOpenHebrewLetters_Click);
      // 
      // toolStripSeparator1
      // 
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      this.toolStripSeparator1.Name = "toolStripSeparator1";
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
      resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      // 
      // ActionEditMemo
      // 
      resources.ApplyResources(this.ActionEditMemo, "ActionEditMemo");
      this.ActionEditMemo.Name = "ActionEditMemo";
      this.ActionEditMemo.Click += new System.EventHandler(this.ActionEditMemo_Click);
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.ActionClose);
      this.panel1.Controls.Add(this.ActionRestoreCommonNames);
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
      resources.ApplyResources(this.ActionRestoreCommonNames, "ActionRestoreCommonNames");
      this.ActionRestoreCommonNames.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      this.ActionRestoreCommonNames.LinkColor = System.Drawing.Color.Navy;
      this.ActionRestoreCommonNames.Name = "ActionRestoreCommonNames";
      this.ActionRestoreCommonNames.TabStop = true;
      // 
      // PanelMain
      // 
      resources.ApplyResources(this.PanelMain, "PanelMain");
      this.PanelMain.Controls.Add(this.DataGridView);
      this.PanelMain.Name = "PanelMain";
      // 
      // DataGridView
      // 
      resources.ApplyResources(this.DataGridView, "DataGridView");
      this.DataGridView.AllowUserToAddRows = false;
      this.DataGridView.AllowUserToDeleteRows = false;
      this.DataGridView.AllowUserToResizeRows = false;
      this.DataGridView.AutoGenerateColumns = false;
      this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.DataGridView.BackgroundColor = System.Drawing.Color.White;
      this.DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnHebrew,
            this.Transcription,
            this.ColumnCommonName,
            this.ColumnTranslation,
            this.ColumnLettriq,
            this.ColumnHasMemo,
            this.ColumnMemo});
      this.DataGridView.ContextMenuStrip = this.ContextMenuResults;
      this.DataGridView.DataSource = this.BindingSource;
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle8.NullValue = "string.Empty";
      dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.DataGridView.DefaultCellStyle = dataGridViewCellStyle8;
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
      // BindingSource
      // 
      this.BindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.BookRow);
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
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ColumnHebrew.DefaultCellStyle = dataGridViewCellStyle6;
      resources.ApplyResources(this.ColumnHebrew, "ColumnHebrew");
      this.ColumnHebrew.Name = "ColumnHebrew";
      this.ColumnHebrew.ReadOnly = true;
      this.ColumnHebrew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // Transcription
      // 
      this.Transcription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Transcription.DataPropertyName = "Transcription";
      resources.ApplyResources(this.Transcription, "Transcription");
      this.Transcription.Name = "Transcription";
      this.Transcription.ReadOnly = true;
      this.Transcription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // ColumnCommonName
      // 
      this.ColumnCommonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnCommonName.DataPropertyName = "CommonName";
      resources.ApplyResources(this.ColumnCommonName, "ColumnCommonName");
      this.ColumnCommonName.Name = "ColumnCommonName";
      this.ColumnCommonName.ReadOnly = true;
      this.ColumnCommonName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // ColumnTranslation
      // 
      this.ColumnTranslation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnTranslation.DataPropertyName = "Translation";
      resources.ApplyResources(this.ColumnTranslation, "ColumnTranslation");
      this.ColumnTranslation.Name = "ColumnTranslation";
      this.ColumnTranslation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // ColumnLettriq
      // 
      this.ColumnLettriq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnLettriq.DataPropertyName = "Lettriq";
      resources.ApplyResources(this.ColumnLettriq, "ColumnLettriq");
      this.ColumnLettriq.Name = "ColumnLettriq";
      this.ColumnLettriq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent;
      this.ColumnMemo.DefaultCellStyle = dataGridViewCellStyle7;
      resources.ApplyResources(this.ColumnMemo, "ColumnMemo");
      this.ColumnMemo.Name = "ColumnMemo";
      this.ColumnMemo.ReadOnly = true;
      this.ColumnMemo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.ColumnMemo.Text = "...";
      this.ColumnMemo.UseColumnTextForButtonValue = true;
      // 
      // EditBooksForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.EditBooksFormClientSize;
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.panel1);
      this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "EditBooksFormClientSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.MinimizeBox = false;
      this.Name = "EditBooksForm";
      this.Load += new System.EventHandler(this.EditBooksForm_Load);
      this.ContextMenuResults.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.PanelMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ContextMenuStrip ContextMenuResults;
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
    private BindingSource BindingSource;
    private DataGridView DataGridView;
    private Button ActionClose;
    private ToolStripMenuItem ActionShowGrammarGuide;
    private ToolStripMenuItem ActionOpen;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripSeparator4;
    private DataGridViewTextBoxColumn ColumnTranscription;
    private DataGridViewTextBoxColumn ColumnNumber;
    private DataGridViewTextBoxColumn ColumnHebrew;
    private DataGridViewTextBoxColumn Transcription;
    private DataGridViewTextBoxColumn ColumnCommonName;
    private DataGridViewTextBoxColumn ColumnTranslation;
    private DataGridViewTextBoxColumn ColumnLettriq;
    private DataGridViewCheckBoxColumn ColumnHasMemo;
    private DataGridViewButtonColumn ColumnMemo;
  }
}