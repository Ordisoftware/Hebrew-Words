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
      this.LabelFilterVerse = new System.Windows.Forms.Label();
      this.LabelFilterChapter = new System.Windows.Forms.Label();
      this.SelectFilterBook = new System.Windows.Forms.ComboBox();
      this.FilterBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.LabelFilterBook = new System.Windows.Forms.Label();
      this.SelectFilterChapter = new System.Windows.Forms.ComboBox();
      this.FilterChaptersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.SelectFilterVerse = new System.Windows.Forms.ComboBox();
      this.FilterVersesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.EditFilterChaptersWithTitle = new System.Windows.Forms.CheckBox();
      this.EditFilterVersesTranslated = new System.Windows.Forms.CheckBox();
      this.EditFilterBook = new System.Windows.Forms.TextBox();
      this.EditFilterChapter = new System.Windows.Forms.TextBox();
      this.EditFilterVerse = new System.Windows.Forms.TextBox();
      this.ActionClearFilterBook = new System.Windows.Forms.Button();
      this.ActionClearFilterChapter = new System.Windows.Forms.Button();
      this.ActionClearFilterVerse = new System.Windows.Forms.Button();
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
      // LabelFilterVerse
      // 
      resources.ApplyResources(this.LabelFilterVerse, "LabelFilterVerse");
      this.LabelFilterVerse.Name = "LabelFilterVerse";
      // 
      // LabelFilterChapter
      // 
      resources.ApplyResources(this.LabelFilterChapter, "LabelFilterChapter");
      this.LabelFilterChapter.Name = "LabelFilterChapter";
      // 
      // SelectFilterBook
      // 
      this.SelectFilterBook.DataSource = this.FilterBooksBindingSource;
      this.SelectFilterBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectFilterBook.DropDownWidth = 500;
      this.SelectFilterBook.FormattingEnabled = true;
      resources.ApplyResources(this.SelectFilterBook, "SelectFilterBook");
      this.SelectFilterBook.Name = "SelectFilterBook";
      this.SelectFilterBook.SelectedIndexChanged += new System.EventHandler(this.SelectFilterBook_SelectedIndexChanged);
      // 
      // FilterBooksBindingSource
      // 
      this.FilterBooksBindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.BookRow);
      // 
      // LabelFilterBook
      // 
      resources.ApplyResources(this.LabelFilterBook, "LabelFilterBook");
      this.LabelFilterBook.Name = "LabelFilterBook";
      // 
      // SelectFilterChapter
      // 
      this.SelectFilterChapter.DataSource = this.FilterChaptersBindingSource;
      this.SelectFilterChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectFilterChapter.DropDownWidth = 500;
      this.SelectFilterChapter.FormattingEnabled = true;
      resources.ApplyResources(this.SelectFilterChapter, "SelectFilterChapter");
      this.SelectFilterChapter.Name = "SelectFilterChapter";
      this.SelectFilterChapter.SelectedIndexChanged += new System.EventHandler(this.SelectFilterChapter_SelectedIndexChanged);
      // 
      // FilterChaptersBindingSource
      // 
      this.FilterChaptersBindingSource.DataMember = "Chapters";
      this.FilterChaptersBindingSource.DataSource = this.FilterBooksBindingSource;
      // 
      // SelectFilterVerse
      // 
      this.SelectFilterVerse.DataSource = this.FilterVersesBindingSource;
      this.SelectFilterVerse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectFilterVerse.DropDownWidth = 500;
      this.SelectFilterVerse.FormattingEnabled = true;
      resources.ApplyResources(this.SelectFilterVerse, "SelectFilterVerse");
      this.SelectFilterVerse.Name = "SelectFilterVerse";
      // 
      // FilterVersesBindingSource
      // 
      this.FilterVersesBindingSource.DataMember = "Verses";
      this.FilterVersesBindingSource.DataSource = this.FilterChaptersBindingSource;
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
      this.EditFilterBook.TextChanged += new System.EventHandler(this.EditFilter_TextChanged);
      this.EditFilterBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditFilterBook_KeyUp);
      this.EditFilterBook.Leave += new System.EventHandler(this.EditFilter_Leave);
      // 
      // EditFilterChapter
      // 
      resources.ApplyResources(this.EditFilterChapter, "EditFilterChapter");
      this.EditFilterChapter.Name = "EditFilterChapter";
      this.EditFilterChapter.TextChanged += new System.EventHandler(this.EditFilter_TextChanged);
      this.EditFilterChapter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditFilterBook_KeyUp);
      this.EditFilterChapter.Leave += new System.EventHandler(this.EditFilter_Leave);
      // 
      // EditFilterVerse
      // 
      resources.ApplyResources(this.EditFilterVerse, "EditFilterVerse");
      this.EditFilterVerse.Name = "EditFilterVerse";
      this.EditFilterVerse.TextChanged += new System.EventHandler(this.EditFilter_TextChanged);
      this.EditFilterVerse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditFilterBook_KeyUp);
      this.EditFilterVerse.Leave += new System.EventHandler(this.EditFilter_Leave);
      // 
      // ActionClearFilterBook
      // 
      resources.ApplyResources(this.ActionClearFilterBook, "ActionClearFilterBook");
      this.ActionClearFilterBook.FlatAppearance.BorderSize = 0;
      this.ActionClearFilterBook.Name = "ActionClearFilterBook";
      this.ActionClearFilterBook.UseVisualStyleBackColor = true;
      this.ActionClearFilterBook.Click += new System.EventHandler(this.ActionClearFilterBook_Click);
      // 
      // ActionClearFilterChapter
      // 
      resources.ApplyResources(this.ActionClearFilterChapter, "ActionClearFilterChapter");
      this.ActionClearFilterChapter.FlatAppearance.BorderSize = 0;
      this.ActionClearFilterChapter.Name = "ActionClearFilterChapter";
      this.ActionClearFilterChapter.UseVisualStyleBackColor = true;
      this.ActionClearFilterChapter.Click += new System.EventHandler(this.ActionClearFilterChapter_Click);
      // 
      // ActionClearFilterVerse
      // 
      resources.ApplyResources(this.ActionClearFilterVerse, "ActionClearFilterVerse");
      this.ActionClearFilterVerse.FlatAppearance.BorderSize = 0;
      this.ActionClearFilterVerse.Name = "ActionClearFilterVerse";
      this.ActionClearFilterVerse.UseVisualStyleBackColor = true;
      this.ActionClearFilterVerse.Click += new System.EventHandler(this.ActionClearFilterVerse_Click);
      // 
      // SelectReferenceForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.ActionClearFilterVerse);
      this.Controls.Add(this.ActionClearFilterChapter);
      this.Controls.Add(this.ActionClearFilterBook);
      this.Controls.Add(this.EditFilterVerse);
      this.Controls.Add(this.EditFilterChapter);
      this.Controls.Add(this.EditFilterBook);
      this.Controls.Add(this.EditFilterVersesTranslated);
      this.Controls.Add(this.EditFilterChaptersWithTitle);
      this.Controls.Add(this.SelectFilterVerse);
      this.Controls.Add(this.SelectFilterChapter);
      this.Controls.Add(this.SelectFilterBook);
      this.Controls.Add(this.LabelFilterBook);
      this.Controls.Add(this.LabelFilterChapter);
      this.Controls.Add(this.LabelFilterVerse);
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
    private System.Windows.Forms.Label LabelFilterVerse;
    private Label LabelFilterChapter;
    private ComboBox SelectFilterBook;
    private Label LabelFilterBook;
    private ComboBox SelectFilterChapter;
    private ComboBox SelectFilterVerse;
    private CheckBox EditFilterChaptersWithTitle;
    private CheckBox EditFilterVersesTranslated;
    private TextBox EditFilterBook;
    private TextBox EditFilterChapter;
    private TextBox EditFilterVerse;
    private BindingSource FilterBooksBindingSource;
    private BindingSource FilterChaptersBindingSource;
    private BindingSource FilterVersesBindingSource;
    public Button ActionClearFilterBook;
    public Button ActionClearFilterChapter;
    public Button ActionClearFilterVerse;
  }

}