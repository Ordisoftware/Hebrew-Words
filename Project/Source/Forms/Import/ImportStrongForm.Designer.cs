namespace Ordisoftware.Hebrew.Words
{
  partial class ImportStrongForm
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
      this.ActionLoadStrong = new System.Windows.Forms.Button();
      this.RichTextBox = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // ActionLoadStrong
      // 
      this.ActionLoadStrong.Location = new System.Drawing.Point(12, 12);
      this.ActionLoadStrong.Name = "ActionLoadStrong";
      this.ActionLoadStrong.Size = new System.Drawing.Size(75, 23);
      this.ActionLoadStrong.TabIndex = 0;
      this.ActionLoadStrong.Text = "Load Strong";
      this.ActionLoadStrong.UseVisualStyleBackColor = true;
      // 
      // RichTextBox
      // 
      this.RichTextBox.Location = new System.Drawing.Point(12, 41);
      this.RichTextBox.Name = "RichTextBox";
      this.RichTextBox.Size = new System.Drawing.Size(1022, 739);
      this.RichTextBox.TabIndex = 1;
      this.RichTextBox.Text = "";
      // 
      // ImportStrongForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1046, 792);
      this.Controls.Add(this.RichTextBox);
      this.Controls.Add(this.ActionLoadStrong);
      this.Name = "ImportStrongForm";
      this.Text = "ImportStrongForm";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button ActionLoadStrong;
    public System.Windows.Forms.RichTextBox RichTextBox;
  }
}