namespace Ordisoftware.HebrewWords
{
  partial class StatControl
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatControl));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.LabelChapters = new System.Windows.Forms.Label();
      this.LabelVerses = new System.Windows.Forms.Label();
      this.LabelWords = new System.Windows.Forms.Label();
      this.LabelLetters = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // LabelChapters
      // 
      resources.ApplyResources(this.LabelChapters, "LabelChapters");
      this.LabelChapters.Name = "LabelChapters";
      // 
      // LabelVerses
      // 
      resources.ApplyResources(this.LabelVerses, "LabelVerses");
      this.LabelVerses.Name = "LabelVerses";
      // 
      // LabelWords
      // 
      resources.ApplyResources(this.LabelWords, "LabelWords");
      this.LabelWords.Name = "LabelWords";
      // 
      // LabelLetters
      // 
      resources.ApplyResources(this.LabelLetters, "LabelLetters");
      this.LabelLetters.Name = "LabelLetters";
      // 
      // StatControl
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.LabelLetters);
      this.Controls.Add(this.LabelWords);
      this.Controls.Add(this.LabelVerses);
      this.Controls.Add(this.LabelChapters);
      this.Controls.Add(this.label1);
      this.Name = "StatControl";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    internal System.Windows.Forms.Label LabelChapters;
    internal System.Windows.Forms.Label LabelVerses;
    internal System.Windows.Forms.Label LabelWords;
    internal System.Windows.Forms.Label LabelLetters;
  }
}
