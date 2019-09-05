namespace Ordisoftware.HebrewWords
{
  partial class WordTranslationsForm
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
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.ButtonClose = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ListView = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.PanelButtons.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelButtons
      // 
      this.PanelButtons.Controls.Add(this.ButtonClose);
      this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.PanelButtons.Location = new System.Drawing.Point(10, 328);
      this.PanelButtons.Name = "PanelButtons";
      this.PanelButtons.Size = new System.Drawing.Size(372, 28);
      this.PanelButtons.TabIndex = 58;
      // 
      // ButtonClose
      // 
      this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ButtonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ButtonClose.Location = new System.Drawing.Point(294, 3);
      this.ButtonClose.Name = "ButtonClose";
      this.ButtonClose.Size = new System.Drawing.Size(75, 23);
      this.ButtonClose.TabIndex = 0;
      this.ButtonClose.Text = "Close";
      this.ButtonClose.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ListView);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(10, 10);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
      this.panel1.Size = new System.Drawing.Size(372, 318);
      this.panel1.TabIndex = 59;
      // 
      // ListView
      // 
      this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListView.HideSelection = false;
      this.ListView.Location = new System.Drawing.Point(0, 0);
      this.ListView.Name = "ListView";
      this.ListView.Size = new System.Drawing.Size(372, 308);
      this.ListView.TabIndex = 0;
      this.ListView.UseCompatibleStateImageBehavior = false;
      this.ListView.View = System.Windows.Forms.View.Details;
      this.ListView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.ListView_ItemMouseHover);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Reference";
      this.columnHeader1.Width = 125;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Translation";
      this.columnHeader2.Width = 220;
      // 
      // WordTranslationsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(392, 366);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.PanelButtons);
      this.Name = "WordTranslationsForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "WordTranslationsForm";
      this.PanelButtons.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.Button ButtonClose;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ListView ListView;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
  }
}