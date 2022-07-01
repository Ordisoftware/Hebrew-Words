﻿namespace Ordisoftware.Hebrew
{
  partial class LettersControl
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LettersControl));
      this.PanelLetters = new System.Windows.Forms.Panel();
      this.ContextMenuLetter = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionLetterAddAtCaret = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionLetterAddAtEnd = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionLetterAddAtStart = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.ActionLetterViewDetails = new System.Windows.Forms.ToolStripMenuItem();
      this.PanelSeparator = new System.Windows.Forms.Panel();
      this.EditCopyWithFinalLetter = new System.Windows.Forms.CheckBox();
      this.ActionDelFirst = new System.Windows.Forms.Button();
      this.ActionDelLast = new System.Windows.Forms.Button();
      this.ActionReset = new System.Windows.Forms.Button();
      this.TextBox = new Ordisoftware.Core.TextBoxEx();
      this.ContextMenuLetter.SuspendLayout();
      this.PanelSeparator.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelLetters
      // 
      this.PanelLetters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.PanelLetters, "PanelLetters");
      this.PanelLetters.Name = "PanelLetters";
      // 
      // ContextMenuLetter
      // 
      this.ContextMenuLetter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionLetterAddAtCaret,
            this.ActionLetterAddAtEnd,
            this.ActionLetterAddAtStart,
            this.MenuItemSeparator,
            this.ActionLetterViewDetails});
      this.ContextMenuLetter.Name = "ContextMenuLetter";
      resources.ApplyResources(this.ContextMenuLetter, "ContextMenuLetter");
      this.ContextMenuLetter.Opened += new System.EventHandler(this.ContextMenuLetter_Opened);
      // 
      // ActionLetterAddAtCaret
      // 
      resources.ApplyResources(this.ActionLetterAddAtCaret, "ActionLetterAddAtCaret");
      this.ActionLetterAddAtCaret.Name = "ActionLetterAddAtCaret";
      this.ActionLetterAddAtCaret.Click += new System.EventHandler(this.ActionLetterAddAtCaret_Click);
      // 
      // ActionLetterAddAtEnd
      // 
      resources.ApplyResources(this.ActionLetterAddAtEnd, "ActionLetterAddAtEnd");
      this.ActionLetterAddAtEnd.Name = "ActionLetterAddAtEnd";
      this.ActionLetterAddAtEnd.Click += new System.EventHandler(this.ActionLetterAddAtEnd_Click);
      // 
      // ActionLetterAddAtStart
      // 
      resources.ApplyResources(this.ActionLetterAddAtStart, "ActionLetterAddAtStart");
      this.ActionLetterAddAtStart.Name = "ActionLetterAddAtStart";
      this.ActionLetterAddAtStart.Click += new System.EventHandler(this.ActionLetterAddAtBegin_Click);
      // 
      // MenuItemSeparator
      // 
      this.MenuItemSeparator.Name = "MenuItemSeparator";
      resources.ApplyResources(this.MenuItemSeparator, "MenuItemSeparator");
      // 
      // ActionLetterViewDetails
      // 
      resources.ApplyResources(this.ActionLetterViewDetails, "ActionLetterViewDetails");
      this.ActionLetterViewDetails.Name = "ActionLetterViewDetails";
      this.ActionLetterViewDetails.Click += new System.EventHandler(this.ActionLetterViewDetails_Click);
      this.ActionLetterViewDetails.VisibleChanged += new System.EventHandler(this.ActionLetterViewDetails_VisibleChanged);
      // 
      // PanelSeparator
      // 
      this.PanelSeparator.Controls.Add(this.EditCopyWithFinalLetter);
      this.PanelSeparator.Controls.Add(this.ActionDelFirst);
      this.PanelSeparator.Controls.Add(this.ActionDelLast);
      this.PanelSeparator.Controls.Add(this.ActionReset);
      resources.ApplyResources(this.PanelSeparator, "PanelSeparator");
      this.PanelSeparator.Name = "PanelSeparator";
      // 
      // EditCopyWithFinalLetter
      // 
      resources.ApplyResources(this.EditCopyWithFinalLetter, "EditCopyWithFinalLetter");
      this.EditCopyWithFinalLetter.Checked = true;
      this.EditCopyWithFinalLetter.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditCopyWithFinalLetter.Name = "EditCopyWithFinalLetter";
      // 
      // ActionDelFirst
      // 
      resources.ApplyResources(this.ActionDelFirst, "ActionDelFirst");
      this.ActionDelFirst.FlatAppearance.BorderSize = 0;
      this.ActionDelFirst.Name = "ActionDelFirst";
      this.ActionDelFirst.UseVisualStyleBackColor = true;
      this.ActionDelFirst.Click += new System.EventHandler(this.ActionDelFirst_Click);
      // 
      // ActionDelLast
      // 
      resources.ApplyResources(this.ActionDelLast, "ActionDelLast");
      this.ActionDelLast.FlatAppearance.BorderSize = 0;
      this.ActionDelLast.Name = "ActionDelLast";
      this.ActionDelLast.UseVisualStyleBackColor = true;
      this.ActionDelLast.Click += new System.EventHandler(this.ActionDelLast_Click);
      // 
      // ActionReset
      // 
      this.ActionReset.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionReset, "ActionReset");
      this.ActionReset.Name = "ActionReset";
      this.ActionReset.UseVisualStyleBackColor = true;
      this.ActionReset.Click += new System.EventHandler(this.ActionReset_Click);
      // 
      // TextBox
      // 
      this.TextBox.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Beginning;
      resources.ApplyResources(this.TextBox, "TextBox");
      this.TextBox.Name = "TextBox";
      this.TextBox.SpellCheckAllowed = false;
      this.TextBox.InsertingText += new Ordisoftware.Core.InsertingTextEventHandler(this.Input_TextChanging);
      this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
      this.TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_KeyUp);
      // 
      // LettersControl
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.Controls.Add(this.PanelLetters);
      this.Controls.Add(this.PanelSeparator);
      this.Controls.Add(this.TextBox);
      this.Name = "LettersControl";
      this.Load += new System.EventHandler(this.LettersControl_Load);
      this.SizeChanged += new System.EventHandler(this.LettersControl_SizeChanged);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.LettersControl_Paint);
      this.ContextMenuLetter.ResumeLayout(false);
      this.PanelSeparator.ResumeLayout(false);
      this.PanelSeparator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel PanelLetters;
    public Ordisoftware.Core.TextBoxEx TextBox;
    private System.Windows.Forms.ToolStripMenuItem ActionLetterAddAtStart;
    private System.Windows.Forms.ToolStripMenuItem ActionLetterAddAtEnd;
    private System.Windows.Forms.ToolStripMenuItem ActionLetterAddAtCaret;
    private System.Windows.Forms.ToolStripSeparator MenuItemSeparator;
    private System.Windows.Forms.ToolStripMenuItem ActionLetterViewDetails;
    private ContextMenuStrip ContextMenuLetter;
    private Panel PanelSeparator;
    public CheckBox EditCopyWithFinalLetter;
    public Button ActionDelFirst;
    public Button ActionDelLast;
    public Button ActionReset;
  }
}
