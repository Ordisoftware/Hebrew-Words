using System;
using System.Windows.Forms;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide input box.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  partial class SelectVerseForm : Form
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectVerseForm));
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.LabelVerse = new System.Windows.Forms.Label();
      this.EditVerseNumber = new System.Windows.Forms.NumericUpDown();
      this.PanelOptionsDirection = new System.Windows.Forms.Panel();
      this.SelectVerseFromFirstToLast = new System.Windows.Forms.RadioButton();
      this.SelectVerseFromCurrentToLast = new System.Windows.Forms.RadioButton();
      this.SelectVerseTakeFirstElseLast = new System.Windows.Forms.CheckBox();
      this.SelectVerseTranslated = new System.Windows.Forms.CheckBox();
      this.SelectVerseWithoutComment = new System.Windows.Forms.CheckBox();
      this.SelectVerseFullyTranslated = new System.Windows.Forms.CheckBox();
      this.SelectVerseFromLastToFirst = new System.Windows.Forms.RadioButton();
      this.SelectVerseFromCurrentToFirst = new System.Windows.Forms.RadioButton();
      this.LabelSearchText = new System.Windows.Forms.Label();
      this.EditSearchText = new Ordisoftware.Core.TextBoxEx();
      this.PanelOptionsProcess = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditVerseNumber)).BeginInit();
      this.PanelOptionsDirection.SuspendLayout();
      this.PanelOptionsProcess.SuspendLayout();
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
      this.panel1.Controls.Add(this.ActionCancel);
      this.panel1.Controls.Add(this.ActionOK);
      resources.ApplyResources(this.panel1, "panel1");
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
      this.EditVerseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.EditVerseNumber.Name = "EditVerseNumber";
      this.EditVerseNumber.ValueChanged += new System.EventHandler(this.Edit_Changed);
      this.EditVerseNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditVerseNumber_KeyUp);
      // 
      // PanelOptionsDirection
      // 
      resources.ApplyResources(this.PanelOptionsDirection, "PanelOptionsDirection");
      this.PanelOptionsDirection.Controls.Add(this.SelectVerseFromFirstToLast);
      this.PanelOptionsDirection.Controls.Add(this.SelectVerseFromCurrentToLast);
      this.PanelOptionsDirection.Controls.Add(this.SelectVerseFromLastToFirst);
      this.PanelOptionsDirection.Controls.Add(this.SelectVerseFromCurrentToFirst);
      this.PanelOptionsDirection.Name = "PanelOptionsDirection";
      // 
      // SelectVerseFromFirstToLast
      // 
      resources.ApplyResources(this.SelectVerseFromFirstToLast, "SelectVerseFromFirstToLast");
      this.SelectVerseFromFirstToLast.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVerseFromFirstToLast;
      this.SelectVerseFromFirstToLast.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVerseFromFirstToLast", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectVerseFromFirstToLast.Name = "SelectVerseFromFirstToLast";
      this.SelectVerseFromFirstToLast.TabStop = true;
      this.SelectVerseFromFirstToLast.UseVisualStyleBackColor = true;
      this.SelectVerseFromFirstToLast.Click += new System.EventHandler(this.SelectVerseFromFirstToLast_Click);
      // 
      // SelectVerseFromCurrentToLast
      // 
      resources.ApplyResources(this.SelectVerseFromCurrentToLast, "SelectVerseFromCurrentToLast");
      this.SelectVerseFromCurrentToLast.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVerseFromCurrentToLast;
      this.SelectVerseFromCurrentToLast.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVerseFromCurrentToLast", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectVerseFromCurrentToLast.Name = "SelectVerseFromCurrentToLast";
      this.SelectVerseFromCurrentToLast.TabStop = true;
      this.SelectVerseFromCurrentToLast.UseVisualStyleBackColor = true;
      this.SelectVerseFromCurrentToLast.Click += new System.EventHandler(this.SelectVerseFromFirstToLast_Click);
      // 
      // SelectVerseTakeFirstElseLast
      // 
      resources.ApplyResources(this.SelectVerseTakeFirstElseLast, "SelectVerseTakeFirstElseLast");
      this.SelectVerseTakeFirstElseLast.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVerseTakeFirstElseLast;
      this.SelectVerseTakeFirstElseLast.CheckState = System.Windows.Forms.CheckState.Checked;
      this.SelectVerseTakeFirstElseLast.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVerseTakeFirstElseLast", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectVerseTakeFirstElseLast.Name = "SelectVerseTakeFirstElseLast";
      this.SelectVerseTakeFirstElseLast.UseVisualStyleBackColor = true;
      // 
      // SelectVerseTranslated
      // 
      resources.ApplyResources(this.SelectVerseTranslated, "SelectVerseTranslated");
      this.SelectVerseTranslated.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVerseTranslated;
      this.SelectVerseTranslated.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVerseTranslated", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectVerseTranslated.Name = "SelectVerseTranslated";
      this.SelectVerseTranslated.UseVisualStyleBackColor = true;
      // 
      // SelectVerseWithoutComment
      // 
      resources.ApplyResources(this.SelectVerseWithoutComment, "SelectVerseWithoutComment");
      this.SelectVerseWithoutComment.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVerseWithoutComment;
      this.SelectVerseWithoutComment.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVerseWithoutComment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectVerseWithoutComment.Name = "SelectVerseWithoutComment";
      this.SelectVerseWithoutComment.UseVisualStyleBackColor = true;
      this.SelectVerseWithoutComment.CheckedChanged += new System.EventHandler(this.SelectVerseWithoutComment_CheckedChanged);
      this.SelectVerseWithoutComment.Click += new System.EventHandler(this.SelectVerseWithoutComment_Click);
      // 
      // SelectVerseFullyTranslated
      // 
      resources.ApplyResources(this.SelectVerseFullyTranslated, "SelectVerseFullyTranslated");
      this.SelectVerseFullyTranslated.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVerseFullyTranslated;
      this.SelectVerseFullyTranslated.CheckState = System.Windows.Forms.CheckState.Checked;
      this.SelectVerseFullyTranslated.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVerseFullyTranslated", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectVerseFullyTranslated.Name = "SelectVerseFullyTranslated";
      this.SelectVerseFullyTranslated.UseVisualStyleBackColor = true;
      // 
      // SelectVerseFromLastToFirst
      // 
      resources.ApplyResources(this.SelectVerseFromLastToFirst, "SelectVerseFromLastToFirst");
      this.SelectVerseFromLastToFirst.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVerseFromLastToFirst;
      this.SelectVerseFromLastToFirst.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVerseFromLastToFirst", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectVerseFromLastToFirst.Name = "SelectVerseFromLastToFirst";
      this.SelectVerseFromLastToFirst.TabStop = true;
      this.SelectVerseFromLastToFirst.UseVisualStyleBackColor = true;
      this.SelectVerseFromLastToFirst.Click += new System.EventHandler(this.SelectVerseFromFirstToLast_Click);
      // 
      // SelectVerseFromCurrentToFirst
      // 
      resources.ApplyResources(this.SelectVerseFromCurrentToFirst, "SelectVerseFromCurrentToFirst");
      this.SelectVerseFromCurrentToFirst.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVerseFromCurrentToFirst;
      this.SelectVerseFromCurrentToFirst.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVerseFromCurrentToFirst", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectVerseFromCurrentToFirst.Name = "SelectVerseFromCurrentToFirst";
      this.SelectVerseFromCurrentToFirst.TabStop = true;
      this.SelectVerseFromCurrentToFirst.UseVisualStyleBackColor = true;
      this.SelectVerseFromCurrentToFirst.Click += new System.EventHandler(this.SelectVerseFromFirstToLast_Click);
      // 
      // LabelSearchText
      // 
      resources.ApplyResources(this.LabelSearchText, "LabelSearchText");
      this.LabelSearchText.Name = "LabelSearchText";
      // 
      // EditSearchText
      // 
      this.EditSearchText.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      resources.ApplyResources(this.EditSearchText, "EditSearchText");
      this.EditSearchText.Name = "EditSearchText";
      this.EditSearchText.SpellCheckAllowed = false;
      this.EditSearchText.TextChanged += new System.EventHandler(this.Edit_Changed);
      // 
      // PanelOptionsProcess
      // 
      this.PanelOptionsProcess.Controls.Add(this.SelectVerseTakeFirstElseLast);
      this.PanelOptionsProcess.Controls.Add(this.SelectVerseFullyTranslated);
      this.PanelOptionsProcess.Controls.Add(this.SelectVerseWithoutComment);
      this.PanelOptionsProcess.Controls.Add(this.SelectVerseTranslated);
      resources.ApplyResources(this.PanelOptionsProcess, "PanelOptionsProcess");
      this.PanelOptionsProcess.Name = "PanelOptionsProcess";
      // 
      // SelectVerseForm
      // 
      this.AcceptButton = this.ActionOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.PanelOptionsProcess);
      this.Controls.Add(this.LabelSearchText);
      this.Controls.Add(this.PanelOptionsDirection);
      this.Controls.Add(this.EditSearchText);
      this.Controls.Add(this.EditVerseNumber);
      this.Controls.Add(this.LabelVerse);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SelectVerseForm";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.SelectVerseForm_Load);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.EditVerseNumber)).EndInit();
      this.PanelOptionsDirection.ResumeLayout(false);
      this.PanelOptionsDirection.PerformLayout();
      this.PanelOptionsProcess.ResumeLayout(false);
      this.PanelOptionsProcess.PerformLayout();
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
    public NumericUpDown EditVerseNumber;
    private RadioButton SelectVerseFromFirstToLast;
    private RadioButton SelectVerseFromLastToFirst;
    private RadioButton SelectVerseFromCurrentToFirst;
    private RadioButton SelectVerseFromCurrentToLast;
    private CheckBox SelectVerseTranslated;
    private CheckBox SelectVerseFullyTranslated;
    private Panel PanelOptionsDirection;
    private CheckBox SelectVerseTakeFirstElseLast;
    private CheckBox SelectVerseWithoutComment;
    private TextBoxEx EditSearchText;
    private Label LabelSearchText;
    private Panel PanelOptionsProcess;
  }

}