using System;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide input box.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  public partial class SelectReferenceForm : Form
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectReferenceForm));
      this.ButtonOK = new System.Windows.Forms.Button();
      this.ButtonCancel = new System.Windows.Forms.Button();
      this.PanelBottom = new System.Windows.Forms.Panel();
      this.LabelVerse = new System.Windows.Forms.Label();
      this.SelectVerse = new System.Windows.Forms.NumericUpDown();
      this.LabelChapter = new System.Windows.Forms.Label();
      this.SelectChapter = new System.Windows.Forms.NumericUpDown();
      this.SelectBook = new System.Windows.Forms.ComboBox();
      this.LabelBook = new System.Windows.Forms.Label();
      this.PanelBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SelectVerse)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SelectChapter)).BeginInit();
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
      // PanelBottom
      // 
      this.PanelBottom.Controls.Add(this.ButtonCancel);
      this.PanelBottom.Controls.Add(this.ButtonOK);
      resources.ApplyResources(this.PanelBottom, "PanelBottom");
      this.PanelBottom.Name = "PanelBottom";
      // 
      // LabelVerse
      // 
      resources.ApplyResources(this.LabelVerse, "LabelVerse");
      this.LabelVerse.Name = "LabelVerse";
      // 
      // SelectVerse
      // 
      resources.ApplyResources(this.SelectVerse, "SelectVerse");
      this.SelectVerse.Name = "SelectVerse";
      this.SelectVerse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.SelectVerse.ValueChanged += new System.EventHandler(this.SelectVerse_ValueChanged);
      this.SelectVerse.Enter += new System.EventHandler(this.SelectValue_Enter);
      // 
      // LabelChapter
      // 
      resources.ApplyResources(this.LabelChapter, "LabelChapter");
      this.LabelChapter.Name = "LabelChapter";
      // 
      // SelectChapter
      // 
      resources.ApplyResources(this.SelectChapter, "SelectChapter");
      this.SelectChapter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.SelectChapter.Name = "SelectChapter";
      this.SelectChapter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.SelectChapter.ValueChanged += new System.EventHandler(this.SelectChapter_ValueChanged);
      this.SelectChapter.Enter += new System.EventHandler(this.SelectValue_Enter);
      // 
      // SelectBook
      // 
      resources.ApplyResources(this.SelectBook, "SelectBook");
      this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectBook.FormattingEnabled = true;
      this.SelectBook.Name = "SelectBook";
      this.SelectBook.SelectedIndexChanged += new System.EventHandler(this.SelectBook_SelectedIndexChanged);
      // 
      // LabelBook
      // 
      resources.ApplyResources(this.LabelBook, "LabelBook");
      this.LabelBook.Name = "LabelBook";
      // 
      // SelectReferenceForm
      // 
      this.AcceptButton = this.ButtonOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ButtonCancel;
      this.Controls.Add(this.SelectBook);
      this.Controls.Add(this.SelectChapter);
      this.Controls.Add(this.SelectVerse);
      this.Controls.Add(this.LabelBook);
      this.Controls.Add(this.LabelChapter);
      this.Controls.Add(this.LabelVerse);
      this.Controls.Add(this.PanelBottom);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SelectReferenceForm";
      this.ShowInTaskbar = false;
      this.PanelBottom.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.SelectVerse)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SelectChapter)).EndInit();
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
    private System.Windows.Forms.Panel PanelBottom;

    /// <summary>
    /// The label.
    /// </summary>
    private System.Windows.Forms.Label LabelVerse;
    internal NumericUpDown SelectVerse;
    private Label LabelChapter;
    internal NumericUpDown SelectChapter;
    private ComboBox SelectBook;
    private Label LabelBook;
  }

}