using System;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide input box.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  public partial class SelectVerseForm : Form
  {

    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <seealso cref="M:System.Windows.Forms.Form.Dispose(bool)"/>
    /// ### <param name="disposing">true si les ressources managées doivent être supprimées ; sinon,
    /// false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas le contenu de cette
    /// méthode avec list'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectVerseForm));
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.LabelVerse = new System.Windows.Forms.Label();
      this.EditVerseNumber = new System.Windows.Forms.NumericUpDown();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditVerseNumber)).BeginInit();
      this.SuspendLayout();
      // 
      // ActionOK
      // 
      resources.ApplyResources(this.ActionOK, "ActionOK");
      this.ActionOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionOK.Name = "ActionOK";
      this.ActionOK.UseVisualStyleBackColor = true;
      // 
      // ActionCancel
      // 
      resources.ApplyResources(this.ActionCancel, "ActionCancel");
      this.ActionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionCancel.Name = "ActionCancel";
      this.ActionCancel.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.ActionCancel);
      this.panel1.Controls.Add(this.ActionOK);
      this.panel1.Name = "panel1";
      // 
      // LabelVerse
      // 
      resources.ApplyResources(this.LabelVerse, "LabelVerse");
      this.LabelVerse.Name = "LabelVerse";
      // 
      // EditVerseNumber
      // 
      resources.ApplyResources(this.EditVerseNumber, "EditVerseNumber");
      this.EditVerseNumber.Name = "EditVerseNumber";
      // 
      // SelectVerseForm
      // 
      this.AcceptButton = this.ActionOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.EditVerseNumber);
      this.Controls.Add(this.LabelVerse);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SelectVerseForm";
      this.ShowInTaskbar = false;
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.EditVerseNumber)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    /// <summary>
    /// The button ok control.
    /// </summary>
    private System.Windows.Forms.Button ActionOK;

    /// <summary>
    /// The button cancel control.
    /// </summary>
    private System.Windows.Forms.Button ActionCancel;

    /// <summary>
    /// The first panel.
    /// </summary>
    private System.Windows.Forms.Panel panel1;

    /// <summary>
    /// The label.
    /// </summary>
    private System.Windows.Forms.Label LabelVerse;
    internal NumericUpDown EditVerseNumber;
  }

}