namespace Ordisoftware.Hebrew.Words
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
      this.components = new System.ComponentModel.Container();
      this.LabelHebrew = new System.Windows.Forms.Label();
      this.EditTranslation = new Ordisoftware.Core.TextBoxEx();
      this.SuspendLayout();
      // 
      // LabelHebrew
      // 
      this.LabelHebrew.AutoSize = true;
      this.LabelHebrew.Dock = System.Windows.Forms.DockStyle.Right;
      this.LabelHebrew.Font = new System.Drawing.Font("Hebrew", 16F);
      this.LabelHebrew.Location = new System.Drawing.Point(150, 5);
      this.LabelHebrew.Name = "LabelHebrew";
      this.LabelHebrew.Size = new System.Drawing.Size(0, 31);
      this.LabelHebrew.TabIndex = 0;
      this.LabelHebrew.TabStop = true;
      this.LabelHebrew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.LabelHebrew.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelHebrew_MouseClick);
      this.LabelHebrew.MouseEnter += new System.EventHandler(this.LabelHebrew_MouseEnter);
      this.LabelHebrew.MouseLeave += new System.EventHandler(this.LabelHebrew_MouseLeave);
      // 
      // EditTranslation
      // 
      this.EditTranslation.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditTranslation.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.EditTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.EditTranslation.Location = new System.Drawing.Point(10, 37);
      this.EditTranslation.Margin = new System.Windows.Forms.Padding(0);
      this.EditTranslation.Name = "EditTranslation";
      this.EditTranslation.Size = new System.Drawing.Size(140, 23);
      this.EditTranslation.TabIndex = 1;
      this.EditTranslation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // WordControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.LabelHebrew);
      this.Controls.Add(this.EditTranslation);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "WordControl";
      this.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
      this.Size = new System.Drawing.Size(150, 65);
      this.Click += new System.EventHandler(this.WordControl_Click);
      this.Enter += new System.EventHandler(this.EditTranslation_Enter);
      this.Leave += new System.EventHandler(this.EditTranslation_Leave);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    public Ordisoftware.Core.TextBoxEx EditTranslation;
    public System.Windows.Forms.Label LabelHebrew;
  }
}
