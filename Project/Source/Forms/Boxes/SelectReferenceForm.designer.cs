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
    /// Variable n�cessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilis�es.
    /// </summary>
    /// <seealso cref="M:System.Windows.Forms.Form.Dispose(bool)"/>
    /// ### <param name="disposing">true si les ressources manag�es doivent �tre supprim�es�; sinon,
    /// false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code g�n�r� par le Concepteur Windows Form

    /// <summary>
    /// M�thode requise pour la prise en charge du concepteur - ne modifiez pas le contenu de cette
    /// m�thode avec list'�diteur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectReferenceForm));
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.PanelBottom = new System.Windows.Forms.Panel();
      this.LabelVerse = new System.Windows.Forms.Label();
      this.LabelChapter = new System.Windows.Forms.Label();
      this.SelectBook = new System.Windows.Forms.ComboBox();
      this.LabelBook = new System.Windows.Forms.Label();
      this.SelectChapter = new System.Windows.Forms.ComboBox();
      this.SelectVerse = new System.Windows.Forms.ComboBox();
      this.EditFilterChaptersWithTitle = new System.Windows.Forms.CheckBox();
      this.EditFilterVersesTranslated = new System.Windows.Forms.CheckBox();
      this.PanelBottom.SuspendLayout();
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
      this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectBook.DropDownWidth = 450;
      this.SelectBook.FormattingEnabled = true;
      resources.ApplyResources(this.SelectBook, "SelectBook");
      this.SelectBook.Name = "SelectBook";
      this.SelectBook.SelectedIndexChanged += new System.EventHandler(this.SelectBook_SelectedIndexChanged);
      // 
      // LabelBook
      // 
      resources.ApplyResources(this.LabelBook, "LabelBook");
      this.LabelBook.Name = "LabelBook";
      // 
      // SelectChapter
      // 
      this.SelectChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectChapter.DropDownWidth = 450;
      this.SelectChapter.FormattingEnabled = true;
      resources.ApplyResources(this.SelectChapter, "SelectChapter");
      this.SelectChapter.Name = "SelectChapter";
      this.SelectChapter.SelectedIndexChanged += new System.EventHandler(this.SelectChapter_SelectedIndexChanged);
      // 
      // SelectVerse
      // 
      this.SelectVerse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectVerse.DropDownWidth = 450;
      this.SelectVerse.FormattingEnabled = true;
      resources.ApplyResources(this.SelectVerse, "SelectVerse");
      this.SelectVerse.Name = "SelectVerse";
      // 
      // EditFilterChaptersWithTitle
      // 
      resources.ApplyResources(this.EditFilterChaptersWithTitle, "EditFilterChaptersWithTitle");
      this.EditFilterChaptersWithTitle.Name = "EditFilterChaptersWithTitle";
      this.EditFilterChaptersWithTitle.UseVisualStyleBackColor = true;
      this.EditFilterChaptersWithTitle.CheckedChanged += new System.EventHandler(this.EditFilter_SelectedIndexChanged);
      // 
      // EditFilterVersesTranslated
      // 
      resources.ApplyResources(this.EditFilterVersesTranslated, "EditFilterVersesTranslated");
      this.EditFilterVersesTranslated.Name = "EditFilterVersesTranslated";
      this.EditFilterVersesTranslated.UseVisualStyleBackColor = true;
      this.EditFilterVersesTranslated.CheckedChanged += new System.EventHandler(this.EditFilter_SelectedIndexChanged);
      // 
      // SelectReferenceForm
      // 
      this.AcceptButton = this.ActionOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
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
  }

}