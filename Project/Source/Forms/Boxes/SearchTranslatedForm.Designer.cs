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
      this.ButtonClose = new System.Windows.Forms.Button();
      this.PanelMain = new System.Windows.Forms.Panel();
      this.ListView = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
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
      this.PanelButtons.SuspendLayout();
      this.PanelMain.SuspendLayout();
      this.ContextMenuStrip.SuspendLayout();
      this.PanelTop.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelButtons
      // 
      this.PanelButtons.Controls.Add(this.EditReturn);
      this.PanelButtons.Controls.Add(this.LabelReference);
      this.PanelButtons.Controls.Add(this.ButtonClose);
      resources.ApplyResources(this.PanelButtons, "PanelButtons");
      this.PanelButtons.Name = "PanelButtons";
      // 
      // EditReturn
      // 
      resources.ApplyResources(this.EditReturn, "EditReturn");
      this.EditReturn.Checked = global::Ordisoftware.HebrewWords.Properties.Settings.Default.SearchTranslatedFormReturnToReference;
      this.EditReturn.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditReturn.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "SearchTranslatedFormReturnToReference", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
      // ButtonClose
      // 
      resources.ApplyResources(this.ButtonClose, "ButtonClose");
      this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ButtonClose.Name = "ButtonClose";
      this.ButtonClose.UseVisualStyleBackColor = true;
      this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
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
      this.ListView.ContextMenuStrip = this.ContextMenuStrip;
      resources.ApplyResources(this.ListView, "ListView");
      this.ListView.FullRowSelect = true;
      this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.ListView.HideSelection = false;
      this.ListView.MultiSelect = false;
      this.ListView.Name = "ListView";
      this.ListView.ShowItemToolTips = true;
      this.ListView.UseCompatibleStateImageBehavior = false;
      this.ListView.View = System.Windows.Forms.View.Details;
      this.ListView.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
      this.ListView.Resize += new System.EventHandler(this.ListView_Resize);
      // 
      // columnHeader1
      // 
      resources.ApplyResources(this.columnHeader1, "columnHeader1");
      // 
      // columnHeader2
      // 
      resources.ApplyResources(this.columnHeader2, "columnHeader2");
      // 
      // ContextMenuStrip
      // 
      this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionUseTranslation,
            this.ActionCopyTranslation,
            this.toolStripSeparator1,
            this.ActionReachReference});
      this.ContextMenuStrip.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStrip, "ContextMenuStrip");
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
      this.EditDistinct.Checked = global::Ordisoftware.HebrewWords.Properties.Settings.Default.SearchTranslatedFilterDistinct;
      this.EditDistinct.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditDistinct.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "SearchTranslatedFilterDistinct", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditDistinct.Name = "EditDistinct";
      this.EditDistinct.UseVisualStyleBackColor = true;
      this.EditDistinct.CheckedChanged += new System.EventHandler(this.EditFilter_CheckedChanged);
      // 
      // ActionReset
      // 
      this.ActionReset.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionReset, "ActionReset");
      this.ActionReset.Name = "ActionReset";
      this.ActionReset.UseVisualStyleBackColor = true;
      this.ActionReset.Click += new System.EventHandler(this.ActionReset_Click);
      // 
      // ActionDelLast
      // 
      this.ActionDelLast.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionDelLast, "ActionDelLast");
      this.ActionDelLast.Name = "ActionDelLast";
      this.ActionDelLast.UseVisualStyleBackColor = true;
      this.ActionDelLast.Click += new System.EventHandler(this.ActionDelLast_Click);
      // 
      // ActionDelFirst
      // 
      this.ActionDelFirst.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionDelFirst, "ActionDelFirst");
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
      // SearchTranslatedForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ButtonClose;
      this.ClientSize = global::Ordisoftware.HebrewWords.Properties.Settings.Default.SearchTranslatedSize;
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.PanelTop);
      this.Controls.Add(this.PanelButtons);
      this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "SearchTranslatedSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "SearchTranslatedLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.Location = global::Ordisoftware.HebrewWords.Properties.Settings.Default.SearchTranslatedLocation;
      this.MaximizeBox = false;
      this.Name = "SearchTranslatedForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordTranslationsForm_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchTranslatedForm_FormClosed);
      this.Load += new System.EventHandler(this.SearchTranslatedForm_Load);
      this.Shown += new System.EventHandler(this.WordTranslationsForm_Shown);
      this.PanelButtons.ResumeLayout(false);
      this.PanelButtons.PerformLayout();
      this.PanelMain.ResumeLayout(false);
      this.ContextMenuStrip.ResumeLayout(false);
      this.PanelTop.ResumeLayout(false);
      this.PanelTop.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.Button ButtonClose;
    private System.Windows.Forms.Panel PanelMain;
    private System.Windows.Forms.ListView ListView;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
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
  }
}