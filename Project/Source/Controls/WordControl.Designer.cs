﻿namespace Ordisoftware.HebrewWords
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
      this.LabelHebrew = new System.Windows.Forms.Label();
      this.ContextMenuStripWord = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionOnlineSearch = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionOpenHebrewLetters = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSearchTranslated = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSearch = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.EditTranslation = new System.Windows.Forms.TextBox();
      this.ContextMenuStripWord.SuspendLayout();
      this.SuspendLayout();
      // 
      // LabelHebrew
      // 
      resources.ApplyResources(this.LabelHebrew, "LabelHebrew");
      this.LabelHebrew.ContextMenuStrip = this.ContextMenuStripWord;
      this.LabelHebrew.Name = "LabelHebrew";
      this.LabelHebrew.TabStop = true;
      this.LabelHebrew.Click += new System.EventHandler(this.LabelHebrew_Click);
      this.LabelHebrew.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelHebrew_MouseDown);
      this.LabelHebrew.MouseEnter += new System.EventHandler(this.LabelHebrew_MouseEnter);
      this.LabelHebrew.MouseLeave += new System.EventHandler(this.LabelHebrew_MouseLeave);
      // 
      // ContextMenuStripWord
      // 
      this.ContextMenuStripWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionOnlineSearch,
            this.ActionOpenHebrewLetters,
            this.MenuSeparator1,
            this.ActionSearchTranslated,
            this.ActionSearch,
            this.MenuSeparator2,
            this.ActionCopy});
      this.ContextMenuStripWord.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStripWord, "ContextMenuStripWord");
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
      // MenuSeparator1
      // 
      this.MenuSeparator1.Name = "MenuSeparator1";
      resources.ApplyResources(this.MenuSeparator1, "MenuSeparator1");
      // 
      // ActionSearchTranslated
      // 
      resources.ApplyResources(this.ActionSearchTranslated, "ActionSearchTranslated");
      this.ActionSearchTranslated.Name = "ActionSearchTranslated";
      this.ActionSearchTranslated.Click += new System.EventHandler(this.ActionSearchTranslated_Click);
      // 
      // ActionSearch
      // 
      resources.ApplyResources(this.ActionSearch, "ActionSearch");
      this.ActionSearch.Name = "ActionSearch";
      this.ActionSearch.Click += new System.EventHandler(this.ActionSearch_Click);
      // 
      // MenuSeparator2
      // 
      this.MenuSeparator2.Name = "MenuSeparator2";
      resources.ApplyResources(this.MenuSeparator2, "MenuSeparator2");
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
      this.EditTranslation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTranslation_KeyDown);
      this.EditTranslation.Leave += new System.EventHandler(this.EditTranslation_Leave);
      // 
      // WordControl
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.LabelHebrew);
      this.Controls.Add(this.EditTranslation);
      this.Name = "WordControl";
      this.Click += new System.EventHandler(this.WordControl_Click);
      this.ContextMenuStripWord.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ContextMenuStrip ContextMenuStripWord;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenHebrewLetters;
    private System.Windows.Forms.ToolStripMenuItem ActionOnlineSearch;
    private System.Windows.Forms.ToolStripSeparator MenuSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ActionCopy;
    private System.Windows.Forms.ToolStripMenuItem ActionSearch;
    private System.Windows.Forms.ToolStripSeparator MenuSeparator2;
    private System.Windows.Forms.ToolStripMenuItem ActionSearchTranslated;
    internal System.Windows.Forms.TextBox EditTranslation;
    internal System.Windows.Forms.Label LabelHebrew;
  }
}
