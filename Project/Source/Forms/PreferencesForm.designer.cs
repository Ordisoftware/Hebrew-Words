namespace Ordisoftware.HebrewWords
{
  partial class PreferencesForm
  {
    /// <summary>
    /// Required designer variable
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && (components != null) )
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
      System.Windows.Forms.Label LabelHebrewLettersPath;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
      System.Windows.Forms.Label LabelOnlineSearch;
      System.Windows.Forms.Label LabelBackupPath;
      System.Windows.Forms.Label backupCountLabel;
      System.Windows.Forms.Label LabelAutoSaveDelay;
      this.ButtonClose = new System.Windows.Forms.Button();
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.EditHebrewLettersPath = new System.Windows.Forms.TextBox();
      this.ActionSelect = new System.Windows.Forms.Button();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.EditOnlineSearch = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.EditBackupPath = new System.Windows.Forms.TextBox();
      this.EditBackupCount = new System.Windows.Forms.NumericUpDown();
      this.EditAutoSaveDelay = new System.Windows.Forms.NumericUpDown();
      LabelHebrewLettersPath = new System.Windows.Forms.Label();
      LabelOnlineSearch = new System.Windows.Forms.Label();
      LabelBackupPath = new System.Windows.Forms.Label();
      backupCountLabel = new System.Windows.Forms.Label();
      LabelAutoSaveDelay = new System.Windows.Forms.Label();
      this.PanelButtons.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditBackupCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoSaveDelay)).BeginInit();
      this.SuspendLayout();
      // 
      // LabelHebrewLettersPath
      // 
      resources.ApplyResources(LabelHebrewLettersPath, "LabelHebrewLettersPath");
      LabelHebrewLettersPath.Name = "LabelHebrewLettersPath";
      // 
      // LabelOnlineSearch
      // 
      resources.ApplyResources(LabelOnlineSearch, "LabelOnlineSearch");
      LabelOnlineSearch.Name = "LabelOnlineSearch";
      // 
      // LabelBackupPath
      // 
      resources.ApplyResources(LabelBackupPath, "LabelBackupPath");
      LabelBackupPath.Name = "LabelBackupPath";
      // 
      // backupCountLabel
      // 
      resources.ApplyResources(backupCountLabel, "backupCountLabel");
      backupCountLabel.Name = "backupCountLabel";
      // 
      // LabelAutoSaveDelay
      // 
      resources.ApplyResources(LabelAutoSaveDelay, "LabelAutoSaveDelay");
      LabelAutoSaveDelay.Name = "LabelAutoSaveDelay";
      // 
      // ButtonClose
      // 
      resources.ApplyResources(this.ButtonClose, "ButtonClose");
      this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ButtonClose.Name = "ButtonClose";
      this.ButtonClose.UseVisualStyleBackColor = true;
      // 
      // PanelButtons
      // 
      resources.ApplyResources(this.PanelButtons, "PanelButtons");
      this.PanelButtons.Controls.Add(this.ButtonClose);
      this.PanelButtons.Name = "PanelButtons";
      // 
      // EditHebrewLettersPath
      // 
      resources.ApplyResources(this.EditHebrewLettersPath, "EditHebrewLettersPath");
      this.EditHebrewLettersPath.Name = "EditHebrewLettersPath";
      // 
      // ActionSelect
      // 
      resources.ApplyResources(this.ActionSelect, "ActionSelect");
      this.ActionSelect.FlatAppearance.BorderSize = 0;
      this.ActionSelect.Name = "ActionSelect";
      this.ActionSelect.UseVisualStyleBackColor = true;
      this.ActionSelect.Click += new System.EventHandler(this.ActionSelect_Click);
      // 
      // OpenFileDialog
      // 
      resources.ApplyResources(this.OpenFileDialog, "OpenFileDialog");
      // 
      // EditOnlineSearch
      // 
      resources.ApplyResources(this.EditOnlineSearch, "EditOnlineSearch");
      this.EditOnlineSearch.Name = "EditOnlineSearch";
      // 
      // button1
      // 
      resources.ApplyResources(this.button1, "button1");
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.Name = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // EditBackupPath
      // 
      resources.ApplyResources(this.EditBackupPath, "EditBackupPath");
      this.EditBackupPath.Name = "EditBackupPath";
      // 
      // EditBackupCount
      // 
      resources.ApplyResources(this.EditBackupCount, "EditBackupCount");
      this.EditBackupCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.EditBackupCount.Name = "EditBackupCount";
      // 
      // EditAutoSaveDelay
      // 
      resources.ApplyResources(this.EditAutoSaveDelay, "EditAutoSaveDelay");
      this.EditAutoSaveDelay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
      this.EditAutoSaveDelay.Name = "EditAutoSaveDelay";
      // 
      // PreferencesForm
      // 
      this.AcceptButton = this.ButtonClose;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ButtonClose;
      this.Controls.Add(this.EditAutoSaveDelay);
      this.Controls.Add(LabelAutoSaveDelay);
      this.Controls.Add(this.EditBackupCount);
      this.Controls.Add(backupCountLabel);
      this.Controls.Add(this.button1);
      this.Controls.Add(LabelBackupPath);
      this.Controls.Add(this.EditBackupPath);
      this.Controls.Add(this.ActionSelect);
      this.Controls.Add(LabelOnlineSearch);
      this.Controls.Add(LabelHebrewLettersPath);
      this.Controls.Add(this.EditOnlineSearch);
      this.Controls.Add(this.EditHebrewLettersPath);
      this.Controls.Add(this.PanelButtons);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PreferencesForm";
      this.ShowInTaskbar = false;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesForm_FormClosing);
      this.Shown += new System.EventHandler(this.PreferencesForm_Shown);
      this.PanelButtons.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.EditBackupCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoSaveDelay)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button ButtonClose;
    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.TextBox EditHebrewLettersPath;
    private System.Windows.Forms.Button ActionSelect;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    private System.Windows.Forms.TextBox EditOnlineSearch;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox EditBackupPath;
    private System.Windows.Forms.NumericUpDown EditBackupCount;
    private System.Windows.Forms.NumericUpDown EditAutoSaveDelay;
  }
}