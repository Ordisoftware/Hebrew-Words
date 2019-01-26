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
      System.Windows.Forms.Label Label;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
      System.Windows.Forms.Label LabelSearch;
      this.ButtonClose = new System.Windows.Forms.Button();
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.EditPath = new System.Windows.Forms.TextBox();
      this.ActionSelect = new System.Windows.Forms.Button();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.EditSearch = new System.Windows.Forms.TextBox();
      Label = new System.Windows.Forms.Label();
      LabelSearch = new System.Windows.Forms.Label();
      this.PanelButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // Label
      // 
      resources.ApplyResources(Label, "Label");
      Label.Name = "Label";
      // 
      // LabelSearch
      // 
      resources.ApplyResources(LabelSearch, "LabelSearch");
      LabelSearch.Name = "LabelSearch";
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
      this.PanelButtons.Controls.Add(this.ButtonClose);
      resources.ApplyResources(this.PanelButtons, "PanelButtons");
      this.PanelButtons.Name = "PanelButtons";
      // 
      // EditPath
      // 
      resources.ApplyResources(this.EditPath, "EditPath");
      this.EditPath.Name = "EditPath";
      // 
      // ActionSelect
      // 
      this.ActionSelect.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionSelect, "ActionSelect");
      this.ActionSelect.Name = "ActionSelect";
      this.ActionSelect.UseVisualStyleBackColor = true;
      this.ActionSelect.Click += new System.EventHandler(this.ActionSelect_Click);
      // 
      // OpenFileDialog
      // 
      resources.ApplyResources(this.OpenFileDialog, "OpenFileDialog");
      // 
      // EditSearch
      // 
      resources.ApplyResources(this.EditSearch, "EditSearch");
      this.EditSearch.Name = "EditSearch";
      // 
      // PreferencesForm
      // 
      this.AcceptButton = this.ButtonClose;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ButtonClose;
      this.Controls.Add(this.ActionSelect);
      this.Controls.Add(LabelSearch);
      this.Controls.Add(Label);
      this.Controls.Add(this.EditSearch);
      this.Controls.Add(this.EditPath);
      this.Controls.Add(this.PanelButtons);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PreferencesForm";
      this.ShowInTaskbar = false;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesForm_FormClosing);
      this.Shown += new System.EventHandler(this.PreferencesForm_Shown);
      this.PanelButtons.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button ButtonClose;
    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.TextBox EditPath;
    private System.Windows.Forms.Button ActionSelect;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    private System.Windows.Forms.TextBox EditSearch;
  }
}