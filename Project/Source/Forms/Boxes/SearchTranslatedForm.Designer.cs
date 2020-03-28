namespace Ordisoftware.HebrewWords
{
  partial class SearchTranslatedForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTranslatedForm));
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.EditReturn = new System.Windows.Forms.CheckBox();
      this.LabelReference = new System.Windows.Forms.LinkLabel();
      this.ActionClose = new System.Windows.Forms.Button();
      this.PanelMain = new System.Windows.Forms.Panel();
      this.ListView = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ContextMenuStripResults = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionUseTranslation = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyTranslation = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionReachReference = new System.Windows.Forms.ToolStripMenuItem();
      this.PanelTop = new System.Windows.Forms.Panel();
      this.EditDistinct = new System.Windows.Forms.CheckBox();
      this.ActionReset = new System.Windows.Forms.Button();
      this.ActionDelLast = new System.Windows.Forms.Button();
      this.ActionDelFirst = new System.Windows.Forms.Button();
      this.EditWholeWord = new System.Windows.Forms.CheckBox();
      this.EditHebrew = new System.Windows.Forms.TextBox();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionAddTranslation = new System.Windows.Forms.ToolStripMenuItem();
      this.PanelButtons.SuspendLayout();
      this.PanelMain.SuspendLayout();
      this.ContextMenuStripResults.SuspendLayout();
      this.PanelTop.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelButtons
      // 
      this.PanelButtons.Controls.Add(this.EditReturn);
      this.PanelButtons.Controls.Add(this.LabelReference);
      this.PanelButtons.Controls.Add(this.ActionClose);
      resources.ApplyResources(this.PanelButtons, "PanelButtons");
      this.PanelButtons.Name = "PanelButtons";
      // 
      // EditReturn
      // 
      resources.ApplyResources(this.EditReturn, "EditReturn");
      this.EditReturn.Checked = global::Ordisoftware.HebrewWords.Properties.Settings.Default.CloseSearchTranslatedFormReturnToReference;
      this.EditReturn.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditReturn.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "CloseSearchTranslatedFormReturnToReference", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditReturn.Name = "EditReturn";
      this.EditReturn.UseVisualStyleBackColor = true;
      // 
      // LabelReference
      // 
      resources.ApplyResources(this.LabelReference, "LabelReference");
      this.LabelReference.Name = "LabelReference";
      this.LabelReference.TabStop = true;
      this.LabelReference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelReference_LinkClicked);
      // 
      // ActionClose
      // 
      resources.ApplyResources(this.ActionClose, "ActionClose");
      this.ActionClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionClose.Name = "ActionClose";
      this.ActionClose.UseVisualStyleBackColor = true;
      this.ActionClose.Click += new System.EventHandler(this.ButtonClose_Click);
      // 
      // PanelMain
      // 
      this.PanelMain.Controls.Add(this.ListView);
      resources.ApplyResources(this.PanelMain, "PanelMain");
      this.PanelMain.Name = "PanelMain";
      // 
      // ListView
      // 
      this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.ListView.ContextMenuStrip = this.ContextMenuStripResults;
      resources.ApplyResources(this.ListView, "ListView");
      this.ListView.FullRowSelect = true;
      this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.ListView.HideSelection = false;
      this.ListView.MultiSelect = false;
      this.ListView.Name = "ListView";
      this.ListView.ShowItemToolTips = true;
      this.ListView.UseCompatibleStateImageBehavior = false;
      this.ListView.View = System.Windows.Forms.View.Details;
      this.ListView.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.ListView_ColumnWidthChanged);
      this.ListView.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
      this.ListView.Resize += new System.EventHandler(this.ListView_Resize);
      // 
      // columnHeader1
      // 
      resources.ApplyResources(this.columnHeader1, "columnHeader1");
      this.columnHeader1.Width = global::Ordisoftware.HebrewWords.Properties.Settings.Default.FoundReferencesColumnRefWidth;
      // 
      // columnHeader2
      // 
      resources.ApplyResources(this.columnHeader2, "columnHeader2");
      // 
      // ContextMenuStripResults
      // 
      this.ContextMenuStripResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionUseTranslation,
            this.ActionAddTranslation,
            this.toolStripSeparator2,
            this.ActionCopyTranslation,
            this.toolStripSeparator1,
            this.ActionReachReference});
      this.ContextMenuStripResults.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStripResults, "ContextMenuStripResults");
      // 
      // ActionUseTranslation
      // 
      resources.ApplyResources(this.ActionUseTranslation, "ActionUseTranslation");
      this.ActionUseTranslation.Name = "ActionUseTranslation";
      this.ActionUseTranslation.Click += new System.EventHandler(this.ActionUseTranslation_Click);
      // 
      // ActionCopyTranslation
      // 
      resources.ApplyResources(this.ActionCopyTranslation, "ActionCopyTranslation");
      this.ActionCopyTranslation.Name = "ActionCopyTranslation";
      this.ActionCopyTranslation.Click += new System.EventHandler(this.ActionCopyTranslation_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      // 
      // ActionReachReference
      // 
      resources.ApplyResources(this.ActionReachReference, "ActionReachReference");
      this.ActionReachReference.Name = "ActionReachReference";
      this.ActionReachReference.Click += new System.EventHandler(this.ActionReachReference_Click);
      // 
      // PanelTop
      // 
      this.PanelTop.Controls.Add(this.EditDistinct);
      this.PanelTop.Controls.Add(this.ActionReset);
      this.PanelTop.Controls.Add(this.ActionDelLast);
      this.PanelTop.Controls.Add(this.ActionDelFirst);
      this.PanelTop.Controls.Add(this.EditWholeWord);
      this.PanelTop.Controls.Add(this.EditHebrew);
      resources.ApplyResources(this.PanelTop, "PanelTop");
      this.PanelTop.Name = "PanelTop";
      // 
      // EditDistinct
      // 
      resources.ApplyResources(this.EditDistinct, "EditDistinct");
      this.EditDistinct.Checked = true;
      this.EditDistinct.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditDistinct.Name = "EditDistinct";
      this.EditDistinct.UseVisualStyleBackColor = true;
      this.EditDistinct.CheckedChanged += new System.EventHandler(this.EditFilter_CheckedChanged);
      // 
      // ActionReset
      // 
      resources.ApplyResources(this.ActionReset, "ActionReset");
      this.ActionReset.FlatAppearance.BorderSize = 0;
      this.ActionReset.Name = "ActionReset";
      this.ActionReset.UseVisualStyleBackColor = true;
      this.ActionReset.Click += new System.EventHandler(this.ActionReset_Click);
      // 
      // ActionDelLast
      // 
      resources.ApplyResources(this.ActionDelLast, "ActionDelLast");
      this.ActionDelLast.FlatAppearance.BorderSize = 0;
      this.ActionDelLast.Name = "ActionDelLast";
      this.ActionDelLast.UseVisualStyleBackColor = true;
      this.ActionDelLast.Click += new System.EventHandler(this.ActionDelLast_Click);
      // 
      // ActionDelFirst
      // 
      resources.ApplyResources(this.ActionDelFirst, "ActionDelFirst");
      this.ActionDelFirst.FlatAppearance.BorderSize = 0;
      this.ActionDelFirst.Name = "ActionDelFirst";
      this.ActionDelFirst.UseVisualStyleBackColor = true;
      this.ActionDelFirst.Click += new System.EventHandler(this.ActionDelFirst_Click);
      // 
      // EditWholeWord
      // 
      resources.ApplyResources(this.EditWholeWord, "EditWholeWord");
      this.EditWholeWord.Checked = true;
      this.EditWholeWord.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditWholeWord.Name = "EditWholeWord";
      this.EditWholeWord.UseVisualStyleBackColor = true;
      this.EditWholeWord.CheckedChanged += new System.EventHandler(this.EditFilter_CheckedChanged);
      // 
      // EditHebrew
      // 
      resources.ApplyResources(this.EditHebrew, "EditHebrew");
      this.EditHebrew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditHebrew.Name = "EditHebrew";
      this.EditHebrew.TextChanged += new System.EventHandler(this.EditHebrew_TextChanged);
      this.EditHebrew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditHebrew_KeyPress);
      this.EditHebrew.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditHebrew_KeyUp);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      // 
      // ActionAddTranslation
      // 
      resources.ApplyResources(this.ActionAddTranslation, "ActionAddTranslation");
      this.ActionAddTranslation.Name = "ActionAddTranslation";
      this.ActionAddTranslation.Click += new System.EventHandler(this.ActionAddTranslation_Click);
      // 
      // SearchTranslatedForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionClose;
      this.ClientSize = global::Ordisoftware.HebrewWords.Properties.Settings.Default.SearchTranslatedFormSize;
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.PanelTop);
      this.Controls.Add(this.PanelButtons);
      this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "SearchTranslatedFormSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.MaximizeBox = false;
      this.Name = "SearchTranslatedForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchTranslatedForm_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchTranslatedForm_FormClosed);
      this.PanelButtons.ResumeLayout(false);
      this.PanelButtons.PerformLayout();
      this.PanelMain.ResumeLayout(false);
      this.ContextMenuStripResults.ResumeLayout(false);
      this.PanelTop.ResumeLayout(false);
      this.PanelTop.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.Button ActionClose;
    private System.Windows.Forms.Panel PanelMain;
    private System.Windows.Forms.ListView ListView;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ContextMenuStrip ContextMenuStripResults;
    private System.Windows.Forms.ToolStripMenuItem ActionReachReference;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyTranslation;
    private System.Windows.Forms.ToolStripMenuItem ActionUseTranslation;
    private System.Windows.Forms.LinkLabel LabelReference;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.Panel PanelTop;
    private System.Windows.Forms.TextBox EditHebrew;
    private System.Windows.Forms.CheckBox EditWholeWord;
    private System.Windows.Forms.Button ActionDelLast;
    private System.Windows.Forms.Button ActionDelFirst;
    private System.Windows.Forms.Button ActionReset;
    private System.Windows.Forms.CheckBox EditDistinct;
    private System.Windows.Forms.CheckBox EditReturn;
    private System.Windows.Forms.ToolStripMenuItem ActionAddTranslation;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  }
}