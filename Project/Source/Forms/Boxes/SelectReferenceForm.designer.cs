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
      this.BooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.LabelBook = new System.Windows.Forms.Label();
      this.SelectChapter = new System.Windows.Forms.ComboBox();
      this.ChaptersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.SelectVerse = new System.Windows.Forms.ComboBox();
      this.VersesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.EditFilterChaptersWithTitle = new System.Windows.Forms.CheckBox();
      this.EditFilterVersesTranslated = new System.Windows.Forms.CheckBox();
      this.EditFilterBook = new System.Windows.Forms.TextBox();
      this.EditFilterChapter = new System.Windows.Forms.TextBox();
      this.EditFilterVerse = new System.Windows.Forms.TextBox();
      this.PanelBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChaptersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.VersesBindingSource)).BeginInit();
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
      this.SelectBook.DataSource = this.BooksBindingSource;
      this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectBook.DropDownWidth = 450;
      this.SelectBook.FormattingEnabled = true;
      resources.ApplyResources(this.SelectBook, "SelectBook");
      this.SelectBook.Name = "SelectBook";
      this.SelectBook.SelectedIndexChanged += new System.EventHandler(this.SelectBook_SelectedIndexChanged);
      // 
      // BooksBindingSource
      // 
      this.BooksBindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.BookRow);
      // 
      // LabelBook
      // 
      resources.ApplyResources(this.LabelBook, "LabelBook");
      this.LabelBook.Name = "LabelBook";
      // 
      // SelectChapter
      // 
      this.SelectChapter.DataSource = this.ChaptersBindingSource;
      this.SelectChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectChapter.DropDownWidth = 450;
      this.SelectChapter.FormattingEnabled = true;
      resources.ApplyResources(this.SelectChapter, "SelectChapter");
      this.SelectChapter.Name = "SelectChapter";
      this.SelectChapter.SelectedIndexChanged += new System.EventHandler(this.SelectChapter_SelectedIndexChanged);
      // 
      // ChaptersBindingSource
      // 
      this.ChaptersBindingSource.DataMember = "Chapters";
      this.ChaptersBindingSource.DataSource = this.BooksBindingSource;
      // 
      // SelectVerse
      // 
      this.SelectVerse.DataSource = this.VersesBindingSource;
      this.SelectVerse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectVerse.DropDownWidth = 450;
      this.SelectVerse.FormattingEnabled = true;
      resources.ApplyResources(this.SelectVerse, "SelectVerse");
      this.SelectVerse.Name = "SelectVerse";
      // 
      // VersesBindingSource
      // 
      this.VersesBindingSource.DataMember = "Verses";
      this.VersesBindingSource.DataSource = this.ChaptersBindingSource;
      // 
      // EditFilterChaptersWithTitle
      // 
      resources.ApplyResources(this.EditFilterChaptersWithTitle, "EditFilterChaptersWithTitle");
      this.EditFilterChaptersWithTitle.Name = "EditFilterChaptersWithTitle";
      this.EditFilterChaptersWithTitle.UseVisualStyleBackColor = true;
      this.EditFilterChaptersWithTitle.CheckedChanged += new System.EventHandler(this.UpdateFilters);
      // 
      // EditFilterVersesTranslated
      // 
      resources.ApplyResources(this.EditFilterVersesTranslated, "EditFilterVersesTranslated");
      this.EditFilterVersesTranslated.Name = "EditFilterVersesTranslated";
      this.EditFilterVersesTranslated.UseVisualStyleBackColor = true;
      this.EditFilterVersesTranslated.CheckedChanged += new System.EventHandler(this.UpdateFilters);
      // 
      // EditFilterBook
      // 
      resources.ApplyResources(this.EditFilterBook, "EditFilterBook");
      this.EditFilterBook.Name = "EditFilterBook";
      this.EditFilterBook.TextChanged += new System.EventHandler(this.UpdateFilters);
      // 
      // EditFilterChapter
      // 
      resources.ApplyResources(this.EditFilterChapter, "EditFilterChapter");
      this.EditFilterChapter.Name = "EditFilterChapter";
      this.EditFilterChapter.TextChanged += new System.EventHandler(this.UpdateFilters);
      // 
      // EditFilterVerse
      // 
      resources.ApplyResources(this.EditFilterVerse, "EditFilterVerse");
      this.EditFilterVerse.Name = "EditFilterVerse";
      this.EditFilterVerse.TextChanged += new System.EventHandler(this.UpdateFilters);
      // 
      // SelectReferenceForm
      // 
      this.AcceptButton = this.ActionOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.EditFilterVerse);
      this.Controls.Add(this.EditFilterChapter);
      this.Controls.Add(this.EditFilterBook);
      this.Controls.Add(this.EditFilterVersesTranslated);
      this.Controls.Add(this.EditFilterChaptersWithTitle);
      this.Controls.Add(this.SelectVerse);
      this.Controls.Add(this.SelectChapter);
      this.Controls.Add(this.SelectBook);
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
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChaptersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.VersesBindingSource)).EndInit();
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
    private CheckBox EditFilterChaptersWithTitle;
    private CheckBox EditFilterVersesTranslated;
    private TextBox EditFilterBook;
    private TextBox EditFilterChapter;
    private TextBox EditFilterVerse;
    private BindingSource BooksBindingSource;
    private BindingSource ChaptersBindingSource;
    private BindingSource VersesBindingSource;
  }

}