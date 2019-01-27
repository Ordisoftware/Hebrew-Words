namespace Ordisoftware.HebrewWords
{
  partial class WordControl
  {
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.LabelHebrew = new System.Windows.Forms.Label();
      this.EditTranslation = new System.Windows.Forms.TextBox();
      this.FlowLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // FlowLayoutPanel
      // 
      this.FlowLayoutPanel.Controls.Add(this.LabelHebrew);
      this.FlowLayoutPanel.Controls.Add(this.EditTranslation);
      this.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.FlowLayoutPanel.Name = "FlowLayoutPanel";
      this.FlowLayoutPanel.Size = new System.Drawing.Size(200, 60);
      this.FlowLayoutPanel.TabIndex = 0;
      // 
      // LabelHebrew
      // 
      this.LabelHebrew.AutoSize = true;
      this.LabelHebrew.Font = new System.Drawing.Font("Hebrew", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelHebrew.Location = new System.Drawing.Point(102, 0);
      this.LabelHebrew.Name = "LabelHebrew";
      this.LabelHebrew.Size = new System.Drawing.Size(95, 30);
      this.LabelHebrew.TabIndex = 0;
      this.LabelHebrew.TabStop = true;
      this.LabelHebrew.Text = "ty>arb";
      this.LabelHebrew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.LabelHebrew.MouseEnter += new System.EventHandler(this.LabelHebrew_MouseEnter);
      this.LabelHebrew.MouseLeave += new System.EventHandler(this.LabelHebrew_MouseLeave);
      // 
      // EditTranslation
      // 
      this.EditTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.EditTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditTranslation.Location = new System.Drawing.Point(3, 33);
      this.EditTranslation.Name = "EditTranslation";
      this.EditTranslation.Size = new System.Drawing.Size(194, 22);
      this.EditTranslation.TabIndex = 1;
      this.EditTranslation.Text = "Pour commencer";
      this.EditTranslation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.EditTranslation.TextChanged += new System.EventHandler(this.EditTranslation_TextChanged);
      // 
      // WordControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.FlowLayoutPanel);
      this.Name = "WordControl";
      this.Size = new System.Drawing.Size(200, 60);
      this.FlowLayoutPanel.ResumeLayout(false);
      this.FlowLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
    private System.Windows.Forms.Label LabelHebrew;
    private System.Windows.Forms.TextBox EditTranslation;

  }
}
