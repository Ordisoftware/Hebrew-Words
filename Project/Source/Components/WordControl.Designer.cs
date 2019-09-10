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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordControl));
      this.FlowLayoutPanel = new System.Windows.Forms.Panel();
      this.LabelHebrew = new System.Windows.Forms.Label();
      this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionOnlineSearch = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionOpenHebrewLetters = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSearch = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSearchTranslated = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.EditTranslation = new System.Windows.Forms.TextBox();
      this.FlowLayoutPanel.SuspendLayout();
      this.ContextMenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // FlowLayoutPanel
      // 
      this.FlowLayoutPanel.Controls.Add(this.LabelHebrew);
      this.FlowLayoutPanel.Controls.Add(this.EditTranslation);
      resources.ApplyResources(this.FlowLayoutPanel, "FlowLayoutPanel");
      this.FlowLayoutPanel.Name = "FlowLayoutPanel";
      // 
      // LabelHebrew
      // 
      resources.ApplyResources(this.LabelHebrew, "LabelHebrew");
      this.LabelHebrew.ContextMenuStrip = this.ContextMenuStrip;
      this.LabelHebrew.Name = "LabelHebrew";
      this.LabelHebrew.TabStop = true;
      this.LabelHebrew.Click += new System.EventHandler(this.LabelHebrew_Click);
      this.LabelHebrew.MouseEnter += new System.EventHandler(this.LabelHebrew_MouseEnter);
      this.LabelHebrew.MouseLeave += new System.EventHandler(this.LabelHebrew_MouseLeave);
      // 
      // ContextMenuStrip
      // 
      this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionOnlineSearch,
            this.ActionOpenHebrewLetters,
            this.toolStripMenuItem1,
            this.ActionSearch,
            this.ActionSearchTranslated,
            this.toolStripMenuItem2,
            this.ActionCopy});
      this.ContextMenuStrip.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStrip, "ContextMenuStrip");
      // 
      // ActionOnlineSearch
      // 
      resources.ApplyResources(this.ActionOnlineSearch, "ActionOnlineSearch");
      this.ActionOnlineSearch.Name = "ActionOnlineSearch";
      this.ActionOnlineSearch.Click += new System.EventHandler(this.ActionOnlineSearch_Click);
      // 
      // ActionOpenHebrewLetters
      // 
      resources.ApplyResources(this.ActionOpenHebrewLetters, "ActionOpenHebrewLetters");
      this.ActionOpenHebrewLetters.Name = "ActionOpenHebrewLetters";
      this.ActionOpenHebrewLetters.Click += new System.EventHandler(this.ActionOpenHebrewLetters_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
      // 
      // ActionSearch
      // 
      resources.ApplyResources(this.ActionSearch, "ActionSearch");
      this.ActionSearch.Name = "ActionSearch";
      this.ActionSearch.Click += new System.EventHandler(this.ActionSearch_Click);
      // 
      // ActionSearchTranslated
      // 
      resources.ApplyResources(this.ActionSearchTranslated, "ActionSearchTranslated");
      this.ActionSearchTranslated.Name = "ActionSearchTranslated";
      this.ActionSearchTranslated.Click += new System.EventHandler(this.ActionSearchTranslated_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
      // 
      // ActionCopy
      // 
      resources.ApplyResources(this.ActionCopy, "ActionCopy");
      this.ActionCopy.Name = "ActionCopy";
      this.ActionCopy.Click += new System.EventHandler(this.ActionCopy_Click);
      // 
      // EditTranslation
      // 
      resources.ApplyResources(this.EditTranslation, "EditTranslation");
      this.EditTranslation.Name = "EditTranslation";
      this.EditTranslation.TextChanged += new System.EventHandler(this.EditTranslation_TextChanged);
      this.EditTranslation.Enter += new System.EventHandler(this.EditTranslation_Enter);
      // 
      // WordControl
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.FlowLayoutPanel);
      this.Name = "WordControl";
      this.FlowLayoutPanel.ResumeLayout(false);
      this.FlowLayoutPanel.PerformLayout();
      this.ContextMenuStrip.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel FlowLayoutPanel;
    private System.Windows.Forms.Label LabelHebrew;
    private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenHebrewLetters;
    private System.Windows.Forms.ToolStripMenuItem ActionOnlineSearch;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem ActionCopy;
    private System.Windows.Forms.ToolStripMenuItem ActionSearch;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem ActionSearchTranslated;
    internal System.Windows.Forms.TextBox EditTranslation;
  }
}
