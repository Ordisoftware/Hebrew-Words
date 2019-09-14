namespace Ordisoftware.HebrewWords
{
  partial class SelectSearchResultsForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSearchResultsForm));
      this.LabelFound = new System.Windows.Forms.Label();
      this.LabelFirst = new System.Windows.Forms.Label();
      this.LabelEscape = new System.Windows.Forms.Label();
      this.LabelSelect = new System.Windows.Forms.Label();
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.ActionSelect = new System.Windows.Forms.Button();
      this.ActionAll = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.LabelCount = new System.Windows.Forms.Label();
      this.SelectBooks = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.EditOnlyWithTranslation = new System.Windows.Forms.CheckBox();
      this.EditOnlyWithoutTranslation = new System.Windows.Forms.CheckBox();
      this.ActionAddAll = new System.Windows.Forms.Button();
      this.ActionRemoveAll = new System.Windows.Forms.Button();
      this.PanelButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // LabelFound
      // 
      resources.ApplyResources(this.LabelFound, "LabelFound");
      this.LabelFound.Name = "LabelFound";
      // 
      // LabelFirst
      // 
      resources.ApplyResources(this.LabelFirst, "LabelFirst");
      this.LabelFirst.Name = "LabelFirst";
      // 
      // LabelEscape
      // 
      resources.ApplyResources(this.LabelEscape, "LabelEscape");
      this.LabelEscape.Name = "LabelEscape";
      // 
      // LabelSelect
      // 
      resources.ApplyResources(this.LabelSelect, "LabelSelect");
      this.LabelSelect.Name = "LabelSelect";
      // 
      // PanelButtons
      // 
      this.PanelButtons.Controls.Add(this.ActionSelect);
      this.PanelButtons.Controls.Add(this.ActionAll);
      this.PanelButtons.Controls.Add(this.ActionCancel);
      resources.ApplyResources(this.PanelButtons, "PanelButtons");
      this.PanelButtons.Name = "PanelButtons";
      // 
      // ActionSelect
      // 
      resources.ApplyResources(this.ActionSelect, "ActionSelect");
      this.ActionSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionSelect.Name = "ActionSelect";
      this.ActionSelect.UseVisualStyleBackColor = true;
      this.ActionSelect.Click += new System.EventHandler(this.ActionSelect_Click);
      // 
      // ActionAll
      // 
      resources.ApplyResources(this.ActionAll, "ActionAll");
      this.ActionAll.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionAll.Name = "ActionAll";
      this.ActionAll.UseVisualStyleBackColor = true;
      this.ActionAll.Click += new System.EventHandler(this.ActionAll_Click);
      // 
      // ActionCancel
      // 
      resources.ApplyResources(this.ActionCancel, "ActionCancel");
      this.ActionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionCancel.Name = "ActionCancel";
      this.ActionCancel.UseVisualStyleBackColor = true;
      // 
      // LabelCount
      // 
      resources.ApplyResources(this.LabelCount, "LabelCount");
      this.LabelCount.ForeColor = System.Drawing.Color.DarkRed;
      this.LabelCount.Name = "LabelCount";
      this.LabelCount.TextChanged += new System.EventHandler(this.LabelCount_TextChanged);
      // 
      // SelectBooks
      // 
      resources.ApplyResources(this.SelectBooks, "SelectBooks");
      this.SelectBooks.CheckBoxes = true;
      this.SelectBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.SelectBooks.FullRowSelect = true;
      this.SelectBooks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.SelectBooks.HideSelection = false;
      this.SelectBooks.MultiSelect = false;
      this.SelectBooks.Name = "SelectBooks";
      this.SelectBooks.UseCompatibleStateImageBehavior = false;
      this.SelectBooks.View = System.Windows.Forms.View.Details;
      this.SelectBooks.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.SelectBooks_ItemChecked);
      // 
      // columnHeader1
      // 
      resources.ApplyResources(this.columnHeader1, "columnHeader1");
      // 
      // columnHeader2
      // 
      resources.ApplyResources(this.columnHeader2, "columnHeader2");
      // 
      // EditOnlyWithTranslation
      // 
      resources.ApplyResources(this.EditOnlyWithTranslation, "EditOnlyWithTranslation");
      this.EditOnlyWithTranslation.Name = "EditOnlyWithTranslation";
      this.EditOnlyWithTranslation.UseVisualStyleBackColor = true;
      this.EditOnlyWithTranslation.CheckedChanged += new System.EventHandler(this.EditOnlyWithTranslation_CheckedChanged);
      // 
      // EditOnlyWithoutTranslation
      // 
      resources.ApplyResources(this.EditOnlyWithoutTranslation, "EditOnlyWithoutTranslation");
      this.EditOnlyWithoutTranslation.Name = "EditOnlyWithoutTranslation";
      this.EditOnlyWithoutTranslation.UseVisualStyleBackColor = true;
      this.EditOnlyWithoutTranslation.CheckedChanged += new System.EventHandler(this.EditOnlyWithoutTranslation_CheckedChanged);
      // 
      // ActionAddAll
      // 
      this.ActionAddAll.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionAddAll, "ActionAddAll");
      this.ActionAddAll.Name = "ActionAddAll";
      this.ActionAddAll.UseVisualStyleBackColor = true;
      this.ActionAddAll.Click += new System.EventHandler(this.ActionAddAll_Click);
      // 
      // ActionRemoveAll
      // 
      this.ActionRemoveAll.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionRemoveAll, "ActionRemoveAll");
      this.ActionRemoveAll.Name = "ActionRemoveAll";
      this.ActionRemoveAll.UseVisualStyleBackColor = true;
      this.ActionRemoveAll.Click += new System.EventHandler(this.ActionRemoveAll_Click);
      // 
      // SelectSearchResultsForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.ActionRemoveAll);
      this.Controls.Add(this.ActionAddAll);
      this.Controls.Add(this.EditOnlyWithoutTranslation);
      this.Controls.Add(this.EditOnlyWithTranslation);
      this.Controls.Add(this.SelectBooks);
      this.Controls.Add(this.LabelCount);
      this.Controls.Add(this.PanelButtons);
      this.Controls.Add(this.LabelSelect);
      this.Controls.Add(this.LabelEscape);
      this.Controls.Add(this.LabelFirst);
      this.Controls.Add(this.LabelFound);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "SelectSearchResultsForm";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.SelectSearchResultsForm_Load);
      this.PanelButtons.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LabelFound;
    private System.Windows.Forms.Label LabelFirst;
    private System.Windows.Forms.Label LabelEscape;
    private System.Windows.Forms.Label LabelSelect;
    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.Button ActionCancel;
    private System.Windows.Forms.Button ActionAll;
    private System.Windows.Forms.Label LabelCount;
    private System.Windows.Forms.ListView SelectBooks;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.Button ActionSelect;
    private System.Windows.Forms.CheckBox EditOnlyWithTranslation;
    private System.Windows.Forms.CheckBox EditOnlyWithoutTranslation;
    private System.Windows.Forms.Button ActionAddAll;
    private System.Windows.Forms.Button ActionRemoveAll;
  }
}