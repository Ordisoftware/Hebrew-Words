using System;
using System.Windows.Forms;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide input box.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  partial class SelectReferenceForm : Form
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectReferenceForm));
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.PanelBottom = new System.Windows.Forms.Panel();
      this.LabelVerse = new System.Windows.Forms.Label();
      this.LabelChapter = new System.Windows.Forms.Label();
      this.SelectBook = new System.Windows.Forms.ComboBox();
      this.FilterBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.LabelBook = new System.Windows.Forms.Label();
      this.SelectChapter = new System.Windows.Forms.ComboBox();
      this.FilterChaptersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.SelectVerse = new System.Windows.Forms.ComboBox();
      this.FilterVersesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.EditReference = new System.Windows.Forms.TextBox();
      this.LabelReference = new System.Windows.Forms.Label();
      this.LabelReferenceInfo = new System.Windows.Forms.Label();
      this.PanelBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FilterBooksBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.FilterChaptersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.FilterVersesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // ActionOK
      // 
      this.ActionOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      resources.ApplyResources(this.ActionOK, "ActionOK");
      this.ActionOK.Name = "ActionOK";
      this.ActionOK.UseVisualStyleBackColor = true;
      // 
      // ActionCancel
      // 
      this.ActionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.ActionCancel, "ActionCancel");
      this.ActionCancel.Name = "ActionCancel";
      this.ActionCancel.UseVisualStyleBackColor = true;
      // 
      // PanelBottom
      // 
      this.PanelBottom.Controls.Add(this.ActionCancel);
      this.PanelBottom.Controls.Add(this.ActionOK);
      resources.ApplyResources(this.PanelBottom, "PanelBottom");
      this.PanelBottom.Name = "PanelBottom";
      // 
      // LabelVerse
      // 
      resources.ApplyResources(this.LabelVerse, "LabelVerse");
      this.LabelVerse.Name = "LabelVerse";
      // 
      // LabelChapter
      // 
      resources.ApplyResources(this.LabelChapter, "LabelChapter");
      this.LabelChapter.Name = "LabelChapter";
      // 
      // SelectBook
      // 
      resources.ApplyResources(this.SelectBook, "SelectBook");
      this.SelectBook.DataSource = this.FilterBooksBindingSource;
      this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectBook.DropDownWidth = 500;
      this.SelectBook.FormattingEnabled = true;
      this.SelectBook.Name = "SelectBook";
      // 
      // FilterBooksBindingSource
      // 
      this.FilterBooksBindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.BookRow);
      // 
      // LabelBook
      // 
      resources.ApplyResources(this.LabelBook, "LabelBook");
      this.LabelBook.Name = "LabelBook";
      // 
      // SelectChapter
      // 
      resources.ApplyResources(this.SelectChapter, "SelectChapter");
      this.SelectChapter.DataSource = this.FilterChaptersBindingSource;
      this.SelectChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectChapter.DropDownWidth = 500;
      this.SelectChapter.FormattingEnabled = true;
      this.SelectChapter.Name = "SelectChapter";
      // 
      // FilterChaptersBindingSource
      // 
      this.FilterChaptersBindingSource.DataMember = "Chapters";
      this.FilterChaptersBindingSource.DataSource = this.FilterBooksBindingSource;
      // 
      // SelectVerse
      // 
      resources.ApplyResources(this.SelectVerse, "SelectVerse");
      this.SelectVerse.DataSource = this.FilterVersesBindingSource;
      this.SelectVerse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectVerse.DropDownWidth = 500;
      this.SelectVerse.FormattingEnabled = true;
      this.SelectVerse.Name = "SelectVerse";
      // 
      // FilterVersesBindingSource
      // 
      this.FilterVersesBindingSource.DataMember = "Verses";
      this.FilterVersesBindingSource.DataSource = this.FilterChaptersBindingSource;
      // 
      // EditReference
      // 
      resources.ApplyResources(this.EditReference, "EditReference");
      this.EditReference.Name = "EditReference";
      // 
      // LabelReference
      // 
      resources.ApplyResources(this.LabelReference, "LabelReference");
      this.LabelReference.Name = "LabelReference";
      // 
      // LabelReferenceInfo
      // 
      resources.ApplyResources(this.LabelReferenceInfo, "LabelReferenceInfo");
      this.LabelReferenceInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelReferenceInfo.Name = "LabelReferenceInfo";
      // 
      // SelectReferenceForm
      // 
      this.AcceptButton = this.ActionOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.LabelReferenceInfo);
      this.Controls.Add(this.EditReference);
      this.Controls.Add(this.SelectVerse);
      this.Controls.Add(this.SelectChapter);
      this.Controls.Add(this.SelectBook);
      this.Controls.Add(this.LabelBook);
      this.Controls.Add(this.LabelChapter);
      this.Controls.Add(this.LabelReference);
      this.Controls.Add(this.LabelVerse);
      this.Controls.Add(this.PanelBottom);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SelectReferenceForm";
      this.ShowInTaskbar = false;
      this.PanelBottom.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.FilterBooksBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.FilterChaptersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.FilterVersesBindingSource)).EndInit();
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
    private System.Windows.Forms.Panel PanelBottom;

    /// <summary>
    /// The label.
    /// </summary>
    private System.Windows.Forms.Label LabelVerse;
    private Label LabelChapter;
    private ComboBox SelectBook;
    private Label LabelBook;
    private ComboBox SelectChapter;
    private ComboBox SelectVerse;
    private BindingSource FilterBooksBindingSource;
    private BindingSource FilterChaptersBindingSource;
    private BindingSource FilterVersesBindingSource;
    private TextBox EditReference;
    private Label LabelReference;
    private Label LabelReferenceInfo;
  }

}