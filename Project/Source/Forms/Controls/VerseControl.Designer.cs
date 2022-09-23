namespace Ordisoftware.Hebrew.Words
{
  partial class VerseControl
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
      this.PanelWords = new System.Windows.Forms.FlowLayoutPanel();
      this.PanelComment = new System.Windows.Forms.Panel();
      this.EditCommentary = new Ordisoftware.Core.TextBoxEx();
      this.PanelCommentLeft = new System.Windows.Forms.Panel();
      this.LabelVerseNumber = new System.Windows.Forms.Label();
      this.PanelSeparator = new System.Windows.Forms.Panel();
      this.PanelComment.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelWords
      // 
      this.PanelWords.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelWords.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.PanelWords.Location = new System.Drawing.Point(5, 20);
      this.PanelWords.Margin = new System.Windows.Forms.Padding(0);
      this.PanelWords.Name = "PanelWords";
      this.PanelWords.Size = new System.Drawing.Size(340, 59);
      this.PanelWords.TabIndex = 1;
      // 
      // PanelComment
      // 
      this.PanelComment.Controls.Add(this.EditCommentary);
      this.PanelComment.Controls.Add(this.PanelCommentLeft);
      this.PanelComment.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.PanelComment.Location = new System.Drawing.Point(5, 79);
      this.PanelComment.Margin = new System.Windows.Forms.Padding(0);
      this.PanelComment.Name = "PanelComment";
      this.PanelComment.Size = new System.Drawing.Size(340, 21);
      this.PanelComment.TabIndex = 2;
      // 
      // EditCommentary
      // 
      this.EditCommentary.BackColor = System.Drawing.Color.Honeydew;
      this.EditCommentary.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditCommentary.Dock = System.Windows.Forms.DockStyle.Top;
      this.EditCommentary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
      this.EditCommentary.Location = new System.Drawing.Point(10, 0);
      this.EditCommentary.Margin = new System.Windows.Forms.Padding(0);
      this.EditCommentary.Name = "EditCommentary";
      this.EditCommentary.Size = new System.Drawing.Size(330, 20);
      this.EditCommentary.SpellCheckAllowed = true;
      this.EditCommentary.TabIndex = 0;
      this.EditCommentary.Enter += new System.EventHandler(this.EditComment_Enter);
      this.EditCommentary.Leave += new System.EventHandler(this.EditComment_Leave);
      // 
      // PanelCommentLeft
      // 
      this.PanelCommentLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.PanelCommentLeft.Location = new System.Drawing.Point(0, 0);
      this.PanelCommentLeft.Name = "PanelCommentLeft";
      this.PanelCommentLeft.Size = new System.Drawing.Size(10, 21);
      this.PanelCommentLeft.TabIndex = 1;
      // 
      // LabelVerseNumber
      // 
      this.LabelVerseNumber.Dock = System.Windows.Forms.DockStyle.Right;
      this.LabelVerseNumber.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
      this.LabelVerseNumber.ForeColor = System.Drawing.Color.DarkBlue;
      this.LabelVerseNumber.Location = new System.Drawing.Point(345, 20);
      this.LabelVerseNumber.Margin = new System.Windows.Forms.Padding(0);
      this.LabelVerseNumber.Name = "LabelVerseNumber";
      this.LabelVerseNumber.Padding = new System.Windows.Forms.Padding(10, 7, 0, 0);
      this.LabelVerseNumber.Size = new System.Drawing.Size(50, 80);
      this.LabelVerseNumber.TabIndex = 0;
      this.LabelVerseNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelVerseNumber_MouseClick);
      this.LabelVerseNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelVerseNumber_MouseDown);
      this.LabelVerseNumber.MouseEnter += new System.EventHandler(this.LabelVerseNumber_MouseEnter);
      this.LabelVerseNumber.MouseLeave += new System.EventHandler(this.LabelVerseNumber_MouseLeave);
      // 
      // PanelSeparator
      // 
      this.PanelSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.PanelSeparator.Location = new System.Drawing.Point(5, 69);
      this.PanelSeparator.Name = "PanelSeparator";
      this.PanelSeparator.Size = new System.Drawing.Size(340, 10);
      this.PanelSeparator.TabIndex = 3;
      // 
      // VerseControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.PanelSeparator);
      this.Controls.Add(this.PanelWords);
      this.Controls.Add(this.PanelComment);
      this.Controls.Add(this.LabelVerseNumber);
      this.Name = "VerseControl";
      this.Padding = new System.Windows.Forms.Padding(5, 20, 5, 20);
      this.Size = new System.Drawing.Size(400, 120);
      this.PanelComment.ResumeLayout(false);
      this.PanelComment.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    public TextBoxEx EditCommentary;
    private Panel PanelComment;
    internal Panel PanelCommentLeft;
    public Label LabelVerseNumber;
    private Panel PanelSeparator;
    internal FlowLayoutPanel PanelWords;
  }
}
