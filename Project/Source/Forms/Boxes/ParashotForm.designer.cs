﻿namespace Ordisoftware.Hebrew
{
  partial class ParashotForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParashotForm));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
      this.PanelBottom = new System.Windows.Forms.Panel();
      this.EditFontSize = new System.Windows.Forms.NumericUpDown();
      this.ActionCheckLockers = new System.Windows.Forms.LinkLabel();
      this.ActionViewLockers = new System.Windows.Forms.LinkLabel();
      this.LabelTableLocked = new System.Windows.Forms.Label();
      this.ActionSaveAsDefaults = new System.Windows.Forms.Button();
      this.ActionExport = new System.Windows.Forms.Button();
      this.ActionReset = new System.Windows.Forms.Button();
      this.ActionUndo = new System.Windows.Forms.Button();
      this.ActionErase = new System.Windows.Forms.Button();
      this.ActionSave = new System.Windows.Forms.Button();
      this.ActionClose = new System.Windows.Forms.Button();
      this.PanelMain = new System.Windows.Forms.Panel();
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.ColumnBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnLettriq = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnLinked = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnUnicode = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnMemo = new System.Windows.Forms.DataGridViewButtonColumn();
      this.ContextMenuParashah = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionOpenVerseOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSearchOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionShowGrammarGuide = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenHebrewLetters = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenHebrewWordsVerse = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionOpenHebrewWordsFind = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopyName = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyHebrewChars = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyUnicodeChars = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopyLineHebrew = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyLineUnicode = new System.Windows.Forms.ToolStripMenuItem();
      this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.bookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.unicodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.verseBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.verseEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isLinkedToNextDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.Timer = new System.Windows.Forms.Timer(this.components);
      this.PanelBottom.SuspendLayout();
      ( (System.ComponentModel.ISupportInitialize)( this.EditFontSize ) ).BeginInit();
      this.PanelMain.SuspendLayout();
      ( (System.ComponentModel.ISupportInitialize)( this.DataGridView ) ).BeginInit();
      this.ContextMenuParashah.SuspendLayout();
      ( (System.ComponentModel.ISupportInitialize)( this.BindingSource ) ).BeginInit();
      this.SuspendLayout();
      // 
      // PanelBottom
      // 
      resources.ApplyResources(this.PanelBottom, "PanelBottom");
      this.PanelBottom.Controls.Add(this.EditFontSize);
      this.PanelBottom.Controls.Add(this.ActionCheckLockers);
      this.PanelBottom.Controls.Add(this.ActionViewLockers);
      this.PanelBottom.Controls.Add(this.LabelTableLocked);
      this.PanelBottom.Controls.Add(this.ActionSaveAsDefaults);
      this.PanelBottom.Controls.Add(this.ActionExport);
      this.PanelBottom.Controls.Add(this.ActionReset);
      this.PanelBottom.Controls.Add(this.ActionUndo);
      this.PanelBottom.Controls.Add(this.ActionErase);
      this.PanelBottom.Controls.Add(this.ActionSave);
      this.PanelBottom.Controls.Add(this.ActionClose);
      this.PanelBottom.Name = "PanelBottom";
      // 
      // EditFontSize
      // 
      resources.ApplyResources(this.EditFontSize, "EditFontSize");
      this.EditFontSize.BackColor = System.Drawing.SystemColors.Window;
      this.EditFontSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.EditFontSize.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.EditFontSize.Name = "EditFontSize";
      this.EditFontSize.ReadOnly = true;
      this.EditFontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.EditFontSize.ValueChanged += new System.EventHandler(this.EditFontSize_ValueChanged);
      // 
      // ActionCheckLockers
      // 
      resources.ApplyResources(this.ActionCheckLockers, "ActionCheckLockers");
      this.ActionCheckLockers.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      this.ActionCheckLockers.LinkColor = System.Drawing.Color.Navy;
      this.ActionCheckLockers.Name = "ActionCheckLockers";
      this.ActionCheckLockers.TabStop = true;
      this.ActionCheckLockers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ActionCheckLockers_LinkClicked);
      // 
      // ActionViewLockers
      // 
      resources.ApplyResources(this.ActionViewLockers, "ActionViewLockers");
      this.ActionViewLockers.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      this.ActionViewLockers.LinkColor = System.Drawing.Color.Navy;
      this.ActionViewLockers.Name = "ActionViewLockers";
      this.ActionViewLockers.TabStop = true;
      this.ActionViewLockers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ActionViewLockers_LinkClicked);
      // 
      // LabelTableLocked
      // 
      resources.ApplyResources(this.LabelTableLocked, "LabelTableLocked");
      this.LabelTableLocked.ForeColor = System.Drawing.Color.Maroon;
      this.LabelTableLocked.Name = "LabelTableLocked";
      // 
      // ActionSaveAsDefaults
      // 
      resources.ApplyResources(this.ActionSaveAsDefaults, "ActionSaveAsDefaults");
      this.ActionSaveAsDefaults.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionSaveAsDefaults.Name = "ActionSaveAsDefaults";
      this.ActionSaveAsDefaults.Click += new System.EventHandler(this.ActionSaveAsDefaults_Click);
      // 
      // ActionExport
      // 
      resources.ApplyResources(this.ActionExport, "ActionExport");
      this.ActionExport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionExport.Name = "ActionExport";
      this.ActionExport.Click += new System.EventHandler(this.ActionExport_Click);
      // 
      // ActionReset
      // 
      resources.ApplyResources(this.ActionReset, "ActionReset");
      this.ActionReset.AllowDrop = true;
      this.ActionReset.FlatAppearance.BorderSize = 0;
      this.ActionReset.Name = "ActionReset";
      this.ActionReset.UseVisualStyleBackColor = true;
      this.ActionReset.Click += new System.EventHandler(this.ActionReset_Click);
      // 
      // ActionUndo
      // 
      resources.ApplyResources(this.ActionUndo, "ActionUndo");
      this.ActionUndo.AllowDrop = true;
      this.ActionUndo.FlatAppearance.BorderSize = 0;
      this.ActionUndo.Name = "ActionUndo";
      this.ActionUndo.UseVisualStyleBackColor = true;
      this.ActionUndo.Click += new System.EventHandler(this.ActionUndo_Click);
      // 
      // ActionErase
      // 
      resources.ApplyResources(this.ActionErase, "ActionErase");
      this.ActionErase.AllowDrop = true;
      this.ActionErase.FlatAppearance.BorderSize = 0;
      this.ActionErase.Name = "ActionErase";
      this.ActionErase.UseVisualStyleBackColor = true;
      this.ActionErase.Click += new System.EventHandler(this.ActionEmpty_Click);
      // 
      // ActionSave
      // 
      resources.ApplyResources(this.ActionSave, "ActionSave");
      this.ActionSave.AllowDrop = true;
      this.ActionSave.FlatAppearance.BorderSize = 0;
      this.ActionSave.Name = "ActionSave";
      this.ActionSave.UseVisualStyleBackColor = true;
      this.ActionSave.Click += new System.EventHandler(this.ActionSave_Click);
      // 
      // ActionClose
      // 
      resources.ApplyResources(this.ActionClose, "ActionClose");
      this.ActionClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionClose.Name = "ActionClose";
      this.ActionClose.Click += new System.EventHandler(this.ActionClose_Click);
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
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
      dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBook,
            this.ColumnNumber,
            this.ColumnName,
            this.ColumnTranslation,
            this.ColumnLettriq,
            this.ColumnBegin,
            this.ColumnEnd,
            this.ColumnLinked,
            this.ColumnUnicode,
            this.ColumnMemo});
      this.DataGridView.ContextMenuStrip = this.ContextMenuParashah;
      this.DataGridView.DataSource = this.BindingSource;
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
      this.DataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);
      this.DataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
      // 
      // ColumnBook
      // 
      this.ColumnBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnBook.DataPropertyName = "Book";
      resources.ApplyResources(this.ColumnBook, "ColumnBook");
      this.ColumnBook.Name = "ColumnBook";
      this.ColumnBook.ReadOnly = true;
      // 
      // ColumnNumber
      // 
      this.ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnNumber.DataPropertyName = "Number";
      dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.ColumnNumber.DefaultCellStyle = dataGridViewCellStyle11;
      resources.ApplyResources(this.ColumnNumber, "ColumnNumber");
      this.ColumnNumber.Name = "ColumnNumber";
      this.ColumnNumber.ReadOnly = true;
      // 
      // ColumnName
      // 
      this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnName.DataPropertyName = "Name";
      resources.ApplyResources(this.ColumnName, "ColumnName");
      this.ColumnName.Name = "ColumnName";
      this.ColumnName.ReadOnly = true;
      // 
      // ColumnTranslation
      // 
      this.ColumnTranslation.DataPropertyName = "Translation";
      dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.ColumnTranslation.DefaultCellStyle = dataGridViewCellStyle12;
      resources.ApplyResources(this.ColumnTranslation, "ColumnTranslation");
      this.ColumnTranslation.Name = "ColumnTranslation";
      // 
      // ColumnLettriq
      // 
      this.ColumnLettriq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnLettriq.DataPropertyName = "Lettriq";
      dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.ColumnLettriq.DefaultCellStyle = dataGridViewCellStyle13;
      resources.ApplyResources(this.ColumnLettriq, "ColumnLettriq");
      this.ColumnLettriq.Name = "ColumnLettriq";
      // 
      // ColumnBegin
      // 
      this.ColumnBegin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnBegin.DataPropertyName = "VerseBegin";
      dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.ColumnBegin.DefaultCellStyle = dataGridViewCellStyle14;
      resources.ApplyResources(this.ColumnBegin, "ColumnBegin");
      this.ColumnBegin.Name = "ColumnBegin";
      this.ColumnBegin.ReadOnly = true;
      // 
      // ColumnEnd
      // 
      this.ColumnEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnEnd.DataPropertyName = "VerseEnd";
      dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.ColumnEnd.DefaultCellStyle = dataGridViewCellStyle15;
      resources.ApplyResources(this.ColumnEnd, "ColumnEnd");
      this.ColumnEnd.Name = "ColumnEnd";
      this.ColumnEnd.ReadOnly = true;
      // 
      // ColumnLinked
      // 
      this.ColumnLinked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnLinked.DataPropertyName = "IsLinkedToNext";
      dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
      this.ColumnLinked.DefaultCellStyle = dataGridViewCellStyle16;
      resources.ApplyResources(this.ColumnLinked, "ColumnLinked");
      this.ColumnLinked.Name = "ColumnLinked";
      this.ColumnLinked.ReadOnly = true;
      // 
      // ColumnUnicode
      // 
      this.ColumnUnicode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnUnicode.DataPropertyName = "Unicode";
      dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle17.Font = new System.Drawing.Font("Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
      this.ColumnUnicode.DefaultCellStyle = dataGridViewCellStyle17;
      resources.ApplyResources(this.ColumnUnicode, "ColumnUnicode");
      this.ColumnUnicode.Name = "ColumnUnicode";
      this.ColumnUnicode.ReadOnly = true;
      // 
      // ColumnMemo
      // 
      this.ColumnMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnMemo.DataPropertyName = "Memo";
      dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Transparent;
      dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Transparent;
      this.ColumnMemo.DefaultCellStyle = dataGridViewCellStyle18;
      resources.ApplyResources(this.ColumnMemo, "ColumnMemo");
      this.ColumnMemo.Name = "ColumnMemo";
      this.ColumnMemo.ReadOnly = true;
      this.ColumnMemo.Text = "...";
      this.ColumnMemo.UseColumnTextForButtonValue = true;
      // 
      // ContextMenuParashah
      // 
      resources.ApplyResources(this.ContextMenuParashah, "ContextMenuParashah");
      this.ContextMenuParashah.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionOpenVerseOnline,
            this.ActionSearchOnline,
            this.MenuSeparator1,
            this.ActionShowGrammarGuide,
            this.toolStripSeparator1,
            this.ActionOpenHebrewLetters,
            this.toolStripSeparator2,
            this.ActionOpenHebrewWordsVerse,
            this.ActionOpenHebrewWordsFind,
            this.MenuSeparator2,
            this.ActionCopyName,
            this.ActionCopyHebrewChars,
            this.ActionCopyUnicodeChars,
            this.MenuSeparator3,
            this.ActionCopyLineHebrew,
            this.ActionCopyLineUnicode});
      this.ContextMenuParashah.Name = "ContextMenuStrip";
      // 
      // ActionOpenVerseOnline
      // 
      resources.ApplyResources(this.ActionOpenVerseOnline, "ActionOpenVerseOnline");
      this.ActionOpenVerseOnline.Name = "ActionOpenVerseOnline";
      // 
      // ActionSearchOnline
      // 
      resources.ApplyResources(this.ActionSearchOnline, "ActionSearchOnline");
      this.ActionSearchOnline.Name = "ActionSearchOnline";
      // 
      // MenuSeparator1
      // 
      resources.ApplyResources(this.MenuSeparator1, "MenuSeparator1");
      this.MenuSeparator1.Name = "MenuSeparator1";
      // 
      // ActionShowGrammarGuide
      // 
      resources.ApplyResources(this.ActionShowGrammarGuide, "ActionShowGrammarGuide");
      this.ActionShowGrammarGuide.Name = "ActionShowGrammarGuide";
      this.ActionShowGrammarGuide.Click += new System.EventHandler(this.ActionShowGrammarGuide_Click);
      // 
      // toolStripSeparator1
      // 
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      // 
      // ActionOpenHebrewLetters
      // 
      resources.ApplyResources(this.ActionOpenHebrewLetters, "ActionOpenHebrewLetters");
      this.ActionOpenHebrewLetters.Name = "ActionOpenHebrewLetters";
      this.ActionOpenHebrewLetters.Click += new System.EventHandler(this.ActionOpenHebrewLetters_Click);
      // 
      // toolStripSeparator2
      // 
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      // 
      // ActionOpenHebrewWordsVerse
      // 
      resources.ApplyResources(this.ActionOpenHebrewWordsVerse, "ActionOpenHebrewWordsVerse");
      this.ActionOpenHebrewWordsVerse.Name = "ActionOpenHebrewWordsVerse";
      this.ActionOpenHebrewWordsVerse.Click += new System.EventHandler(this.ActionOpenHebrewWordsVerse_Click);
      // 
      // ActionOpenHebrewWordsFind
      // 
      resources.ApplyResources(this.ActionOpenHebrewWordsFind, "ActionOpenHebrewWordsFind");
      this.ActionOpenHebrewWordsFind.Name = "ActionOpenHebrewWordsFind";
      this.ActionOpenHebrewWordsFind.Click += new System.EventHandler(this.ActionOpenHebrewWordsFind_Click);
      // 
      // MenuSeparator2
      // 
      resources.ApplyResources(this.MenuSeparator2, "MenuSeparator2");
      this.MenuSeparator2.Name = "MenuSeparator2";
      // 
      // ActionCopyName
      // 
      resources.ApplyResources(this.ActionCopyName, "ActionCopyName");
      this.ActionCopyName.Name = "ActionCopyName";
      this.ActionCopyName.Click += new System.EventHandler(this.ActionCopyName_Click);
      // 
      // ActionCopyHebrewChars
      // 
      resources.ApplyResources(this.ActionCopyHebrewChars, "ActionCopyHebrewChars");
      this.ActionCopyHebrewChars.Name = "ActionCopyHebrewChars";
      this.ActionCopyHebrewChars.Click += new System.EventHandler(this.ActionCopyHebrewChars_Click);
      // 
      // ActionCopyUnicodeChars
      // 
      resources.ApplyResources(this.ActionCopyUnicodeChars, "ActionCopyUnicodeChars");
      this.ActionCopyUnicodeChars.Name = "ActionCopyUnicodeChars";
      this.ActionCopyUnicodeChars.Click += new System.EventHandler(this.ActionCopyUnicodeChars_Click);
      // 
      // MenuSeparator3
      // 
      resources.ApplyResources(this.MenuSeparator3, "MenuSeparator3");
      this.MenuSeparator3.Name = "MenuSeparator3";
      // 
      // ActionCopyLineHebrew
      // 
      resources.ApplyResources(this.ActionCopyLineHebrew, "ActionCopyLineHebrew");
      this.ActionCopyLineHebrew.Name = "ActionCopyLineHebrew";
      this.ActionCopyLineHebrew.Click += new System.EventHandler(this.ActionCopyLineHebrew_Click);
      // 
      // ActionCopyLineUnicode
      // 
      resources.ApplyResources(this.ActionCopyLineUnicode, "ActionCopyLineUnicode");
      this.ActionCopyLineUnicode.Name = "ActionCopyLineUnicode";
      this.ActionCopyLineUnicode.Click += new System.EventHandler(this.ActionCopyLineUnicode_Click);
      // 
      // BindingSource
      // 
      this.BindingSource.DataSource = typeof(Ordisoftware.Hebrew.Parashah);
      this.BindingSource.DataSourceChanged += new System.EventHandler(this.BindingSource_DataSourceChanged);
      // 
      // bookDataGridViewTextBoxColumn
      // 
      this.bookDataGridViewTextBoxColumn.DataPropertyName = "Book";
      resources.ApplyResources(this.bookDataGridViewTextBoxColumn, "bookDataGridViewTextBoxColumn");
      this.bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
      this.bookDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // numberDataGridViewTextBoxColumn
      // 
      this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
      resources.ApplyResources(this.numberDataGridViewTextBoxColumn, "numberDataGridViewTextBoxColumn");
      this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
      this.numberDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      this.nameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // unicodeDataGridViewTextBoxColumn
      // 
      this.unicodeDataGridViewTextBoxColumn.DataPropertyName = "Unicode";
      resources.ApplyResources(this.unicodeDataGridViewTextBoxColumn, "unicodeDataGridViewTextBoxColumn");
      this.unicodeDataGridViewTextBoxColumn.Name = "unicodeDataGridViewTextBoxColumn";
      this.unicodeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // verseBeginDataGridViewTextBoxColumn
      // 
      this.verseBeginDataGridViewTextBoxColumn.DataPropertyName = "VerseBegin";
      resources.ApplyResources(this.verseBeginDataGridViewTextBoxColumn, "verseBeginDataGridViewTextBoxColumn");
      this.verseBeginDataGridViewTextBoxColumn.Name = "verseBeginDataGridViewTextBoxColumn";
      this.verseBeginDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // verseEndDataGridViewTextBoxColumn
      // 
      this.verseEndDataGridViewTextBoxColumn.DataPropertyName = "VerseEnd";
      resources.ApplyResources(this.verseEndDataGridViewTextBoxColumn, "verseEndDataGridViewTextBoxColumn");
      this.verseEndDataGridViewTextBoxColumn.Name = "verseEndDataGridViewTextBoxColumn";
      this.verseEndDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // isLinkedToNextDataGridViewCheckBoxColumn
      // 
      this.isLinkedToNextDataGridViewCheckBoxColumn.DataPropertyName = "IsLinkedToNext";
      resources.ApplyResources(this.isLinkedToNextDataGridViewCheckBoxColumn, "isLinkedToNextDataGridViewCheckBoxColumn");
      this.isLinkedToNextDataGridViewCheckBoxColumn.Name = "isLinkedToNextDataGridViewCheckBoxColumn";
      this.isLinkedToNextDataGridViewCheckBoxColumn.ReadOnly = true;
      // 
      // Timer
      // 
      this.Timer.Interval = 5000;
      this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
      // 
      // ParashotForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.PanelBottom);
      this.Name = "ParashotForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParashotForm_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParashotForm_FormClosed);
      this.Load += new System.EventHandler(this.ParashotForm_Load);
      this.Shown += new System.EventHandler(this.ParashotForm_Shown);
      this.PanelBottom.ResumeLayout(false);
      this.PanelBottom.PerformLayout();
      ( (System.ComponentModel.ISupportInitialize)( this.EditFontSize ) ).EndInit();
      this.PanelMain.ResumeLayout(false);
      ( (System.ComponentModel.ISupportInitialize)( this.DataGridView ) ).EndInit();
      this.ContextMenuParashah.ResumeLayout(false);
      ( (System.ComponentModel.ISupportInitialize)( this.BindingSource ) ).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel PanelBottom;
    private System.Windows.Forms.Button ActionClose;
    private System.Windows.Forms.Panel PanelMain;
    private System.Windows.Forms.ContextMenuStrip ContextMenuParashah;
    private System.Windows.Forms.ToolStripMenuItem ActionSearchOnline;
    private System.Windows.Forms.ToolStripSeparator MenuSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenHebrewLetters;
    private System.Windows.Forms.ToolStripSeparator MenuSeparator2;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyHebrewChars;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyUnicodeChars;
    private System.Windows.Forms.ToolStripSeparator MenuSeparator3;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyLineHebrew;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyLineUnicode;
    private System.Windows.Forms.DataGridView DataGridView;
    private System.Windows.Forms.BindingSource BindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn unicodeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn verseBeginDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn verseEndDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isLinkedToNextDataGridViewCheckBoxColumn;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenVerseOnline;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenHebrewWordsVerse;
    private System.Windows.Forms.Button ActionSave;
    private System.Windows.Forms.ToolStripMenuItem ActionShowGrammarGuide;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyName;
    private System.Windows.Forms.Button ActionUndo;
    private System.Windows.Forms.Button ActionExport;
    private System.Windows.Forms.Button ActionReset;
    private System.Windows.Forms.Button ActionSaveAsDefaults;
    private System.Windows.Forms.Timer Timer;
    private System.Windows.Forms.Label LabelTableLocked;
    private System.Windows.Forms.LinkLabel ActionCheckLockers;
    private System.Windows.Forms.LinkLabel ActionViewLockers;
    private System.Windows.Forms.NumericUpDown EditFontSize;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBook;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTranslation;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLettriq;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBegin;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnd;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLinked;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnicode;
    private System.Windows.Forms.DataGridViewButtonColumn ColumnMemo;
    private System.Windows.Forms.Button ActionErase;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenHebrewWordsFind;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  }
}