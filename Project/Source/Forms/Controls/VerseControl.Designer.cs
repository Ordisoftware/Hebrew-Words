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
      this.PanelVerseNumber = new System.Windows.Forms.Panel();
      this.LabelVerseNumber = new System.Windows.Forms.Label();
      this.PanelWords = new System.Windows.Forms.FlowLayoutPanel();
      this.EditComment = new Ordisoftware.Core.TextBoxEx();
      this.PanelComment = new System.Windows.Forms.Panel();
      this.PanelCommentLeft = new System.Windows.Forms.Panel();
      this.PanelVerseNumber.SuspendLayout();
      this.PanelComment.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelVerseNumber
      // 
      this.PanelVerseNumber.Controls.Add(this.LabelVerseNumber);
      this.PanelVerseNumber.Dock = System.Windows.Forms.DockStyle.Right;
      this.PanelVerseNumber.Location = new System.Drawing.Point(440, 10);
      this.PanelVerseNumber.Name = "PanelVerseNumber";
      this.PanelVerseNumber.Padding = new System.Windows.Forms.Padding(10);
      this.PanelVerseNumber.Size = new System.Drawing.Size(50, 95);
      this.PanelVerseNumber.TabIndex = 0;
      // 
      // LabelVerseNumber
      // 
      this.LabelVerseNumber.AutoSize = true;
      this.LabelVerseNumber.Dock = System.Windows.Forms.DockStyle.Top;
      this.LabelVerseNumber.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelVerseNumber.ForeColor = System.Drawing.Color.DarkBlue;
      this.LabelVerseNumber.Location = new System.Drawing.Point(10, 10);
      this.LabelVerseNumber.Name = "LabelVerseNumber";
      this.LabelVerseNumber.Size = new System.Drawing.Size(37, 21);
      this.LabelVerseNumber.TabIndex = 0;
      this.LabelVerseNumber.Text = "000";
      this.LabelVerseNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelVerseNumber_MouseClick);
      this.LabelVerseNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelVerseNumber_MouseDown);
      this.LabelVerseNumber.MouseEnter += new System.EventHandler(this.LabelVerseNumber_MouseEnter);
      this.LabelVerseNumber.MouseLeave += new System.EventHandler(this.LabelVerseNumber_MouseLeave);
      // 
      // PanelWords
      // 
      this.PanelWords.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelWords.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.PanelWords.Location = new System.Drawing.Point(10, 10);
      this.PanelWords.Margin = new System.Windows.Forms.Padding(0);
      this.PanelWords.Name = "PanelWords";
      this.PanelWords.Size = new System.Drawing.Size(430, 75);
      this.PanelWords.TabIndex = 1;
      // 
      // EditComment
      // 
      this.EditComment.BackColor = System.Drawing.Color.Honeydew;
      this.EditComment.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditComment.Dock = System.Windows.Forms.DockStyle.Fill;
      this.EditComment.Location = new System.Drawing.Point(10, 0);
      this.EditComment.Margin = new System.Windows.Forms.Padding(0);
      this.EditComment.Name = "EditComment";
      this.EditComment.Size = new System.Drawing.Size(420, 20);
      this.EditComment.TabIndex = 2;
      this.EditComment.Enter += new System.EventHandler(this.EditComment_Enter);
      this.EditComment.Leave += new System.EventHandler(this.EditComment_Leave);
      // 
      // PanelComment
      // 
      this.PanelComment.Controls.Add(this.EditComment);
      this.PanelComment.Controls.Add(this.PanelCommentLeft);
      this.PanelComment.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.PanelComment.Location = new System.Drawing.Point(10, 85);
      this.PanelComment.Margin = new System.Windows.Forms.Padding(0);
      this.PanelComment.Name = "PanelComment";
      this.PanelComment.Size = new System.Drawing.Size(430, 20);
      this.PanelComment.TabIndex = 0;
      // 
      // PanelCommentLeft
      // 
      this.PanelCommentLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.PanelCommentLeft.Location = new System.Drawing.Point(0, 0);
      this.PanelCommentLeft.Name = "PanelCommentLeft";
      this.PanelCommentLeft.Size = new System.Drawing.Size(10, 20);
      this.PanelCommentLeft.TabIndex = 3;
      // 
      // VerseControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.PanelWords);
      this.Controls.Add(this.PanelComment);
      this.Controls.Add(this.PanelVerseNumber);
      this.Name = "VerseControl";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Size = new System.Drawing.Size(500, 115);
      this.PanelVerseNumber.ResumeLayout(false);
      this.PanelVerseNumber.PerformLayout();
      this.PanelComment.ResumeLayout(false);
      this.PanelComment.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Panel PanelVerseNumber;
    private FlowLayoutPanel PanelWords;
    public TextBoxEx EditComment;
    public Label LabelVerseNumber;
    private Panel PanelComment;
    internal Panel PanelCommentLeft;
  }
}
