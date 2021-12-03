namespace Ordisoftware.Hebrew.Words
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
      this.LabelChapters = new System.Windows.Forms.Label();
      this.LabelVerses = new System.Windows.Forms.Label();
      this.LabelWords = new System.Windows.Forms.Label();
      this.LabelLetters = new System.Windows.Forms.Label();
      this.LabelChaptersValue = new System.Windows.Forms.Label();
      this.LabelVersesValue = new System.Windows.Forms.Label();
      this.LabelWordsValue = new System.Windows.Forms.Label();
      this.LabelLettersValue = new System.Windows.Forms.Label();
      this.SuspendLayout();
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
      // LabelChaptersValue
      // 
      resources.ApplyResources(this.LabelChaptersValue, "LabelChaptersValue");
      this.LabelChaptersValue.Name = "LabelChaptersValue";
      // 
      // LabelVersesValue
      // 
      resources.ApplyResources(this.LabelVersesValue, "LabelVersesValue");
      this.LabelVersesValue.Name = "LabelVersesValue";
      // 
      // LabelWordsValue
      // 
      resources.ApplyResources(this.LabelWordsValue, "LabelWordsValue");
      this.LabelWordsValue.Name = "LabelWordsValue";
      // 
      // LabelLettersValue
      // 
      resources.ApplyResources(this.LabelLettersValue, "LabelLettersValue");
      this.LabelLettersValue.Name = "LabelLettersValue";
      // 
      // StatControl
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.LabelLetters);
      this.Controls.Add(this.LabelWords);
      this.Controls.Add(this.LabelVerses);
      this.Controls.Add(this.LabelLettersValue);
      this.Controls.Add(this.LabelWordsValue);
      this.Controls.Add(this.LabelVersesValue);
      this.Controls.Add(this.LabelChaptersValue);
      this.Controls.Add(this.LabelChapters);
      this.Name = "StatControl";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LabelChapters;
    private System.Windows.Forms.Label LabelVerses;
    private System.Windows.Forms.Label LabelWords;
    private System.Windows.Forms.Label LabelLetters;
    public System.Windows.Forms.Label LabelChaptersValue;
    public System.Windows.Forms.Label LabelVersesValue;
    public System.Windows.Forms.Label LabelWordsValue;
    public System.Windows.Forms.Label LabelLettersValue;
  }
}
