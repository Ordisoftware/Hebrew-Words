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
      this.ButtonOK = new System.Windows.Forms.Button();
      this.ButtonCancel = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label = new System.Windows.Forms.Label();
      this.EditVerseNumber = new System.Windows.Forms.NumericUpDown();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditVerseNumber)).BeginInit();
      this.SuspendLayout();
      // 
      // ButtonOK
      // 
      resources.ApplyResources(this.ButtonOK, "ButtonOK");
      this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ButtonOK.Name = "ButtonOK";
      this.ButtonOK.UseVisualStyleBackColor = true;
      // 
      // ButtonCancel
      // 
      resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
      this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ButtonCancel.Name = "ButtonCancel";
      this.ButtonCancel.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ButtonCancel);
      this.panel1.Controls.Add(this.ButtonOK);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // label
      // 
      resources.ApplyResources(this.label, "label");
      this.label.Name = "label";
      // 
      // EditVerseNumber
      // 
      resources.ApplyResources(this.EditVerseNumber, "EditVerseNumber");
      this.EditVerseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.EditVerseNumber.Name = "EditVerseNumber";
      this.EditVerseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // SelectVerseForm
      // 
      this.AcceptButton = this.ButtonOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ButtonCancel;
      this.Controls.Add(this.EditVerseNumber);
      this.Controls.Add(this.label);
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
    private System.Windows.Forms.Button ButtonOK;

    /// <summary>
    /// The button cancel control.
    /// </summary>
    private System.Windows.Forms.Button ButtonCancel;

    /// <summary>
    /// The first panel.
    /// </summary>
    private System.Windows.Forms.Panel panel1;

    /// <summary>
    /// The label.
    /// </summary>
    private System.Windows.Forms.Label label;
    internal NumericUpDown EditVerseNumber;
  }

}