namespace Ordisoftware.HebrewWords
{
  partial class EditMemoForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMemoForm));
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.ActionOk = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.TextBox = new System.Windows.Forms.TextBox();
      this.PanelSep = new System.Windows.Forms.Panel();
      this.PanelButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelButtons
      // 
      this.PanelButtons.Controls.Add(this.ActionOk);
      this.PanelButtons.Controls.Add(this.ActionCancel);
      resources.ApplyResources(this.PanelButtons, "PanelButtons");
      this.PanelButtons.Name = "PanelButtons";
      // 
      // ActionOk
      // 
      resources.ApplyResources(this.ActionOk, "ActionOk");
      this.ActionOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionOk.Name = "ActionOk";
      this.ActionOk.UseVisualStyleBackColor = true;
      this.ActionOk.Click += new System.EventHandler(this.ActionOk_Click);
      // 
      // ActionCancel
      // 
      resources.ApplyResources(this.ActionCancel, "ActionCancel");
      this.ActionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionCancel.Name = "ActionCancel";
      this.ActionCancel.UseVisualStyleBackColor = true;
      // 
      // TextBox
      // 
      resources.ApplyResources(this.TextBox, "TextBox");
      this.TextBox.Name = "TextBox";
      // 
      // PanelSep
      // 
      resources.ApplyResources(this.PanelSep, "PanelSep");
      this.PanelSep.Name = "PanelSep";
      // 
      // EditMemoForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = global::Ordisoftware.HebrewWords.Properties.Settings.Default.EditMemoFormClientSize;
      this.Controls.Add(this.TextBox);
      this.Controls.Add(this.PanelSep);
      this.Controls.Add(this.PanelButtons);
      this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "EditMemoFormClientSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditMemoForm";
      this.ShowInTaskbar = false;
      this.PanelButtons.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.Button ActionOk;
    private System.Windows.Forms.Button ActionCancel;
    internal System.Windows.Forms.TextBox TextBox;
    private System.Windows.Forms.Panel PanelSep;
  }
}