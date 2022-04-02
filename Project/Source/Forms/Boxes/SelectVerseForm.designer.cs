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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectVerseForm));
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.LabelVerse = new System.Windows.Forms.Label();
      this.EditVerseNumber = new System.Windows.Forms.NumericUpDown();
      this.PanelOptions = new System.Windows.Forms.Panel();
      this.SelectVerseFromFirstToLast = new System.Windows.Forms.RadioButton();
      this.SelectVerseFromCurrentToLast = new System.Windows.Forms.RadioButton();
      this.SelectVerseTakeFirstElseLast = new System.Windows.Forms.CheckBox();
      this.SelectVerseTranslated = new System.Windows.Forms.CheckBox();
      this.SelectVerseFullyTranslated = new System.Windows.Forms.CheckBox();
      this.SelectVerseFromLastToFirst = new System.Windows.Forms.RadioButton();
      this.SelectVerseFromCurrentToFirst = new System.Windows.Forms.RadioButton();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditVerseNumber)).BeginInit();
      this.PanelOptions.SuspendLayout();
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
      this.EditVerseNumber.ValueChanged += new System.EventHandler(this.EditVerseNumber_ValueChanged);
      this.EditVerseNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditVerseNumber_KeyUp);
      // 
      // PanelOptions
      // 
      resources.ApplyResources(this.PanelOptions, "PanelOptions");
      this.PanelOptions.Controls.Add(this.SelectVerseFromFirstToLast);
      this.PanelOptions.Controls.Add(this.SelectVerseFromCurrentToLast);
      this.PanelOptions.Controls.Add(this.SelectVerseTakeFirstElseLast);
      this.PanelOptions.Controls.Add(this.SelectVerseTranslated);
      this.PanelOptions.Controls.Add(this.SelectVerseFullyTranslated);
      this.PanelOptions.Controls.Add(this.SelectVerseFromLastToFirst);
      this.PanelOptions.Controls.Add(this.SelectVerseFromCurrentToFirst);
      this.PanelOptions.Name = "PanelOptions";
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
      // SelectVerseForm
      // 
      this.AcceptButton = this.ActionOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.PanelOptions);
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
      this.PanelOptions.ResumeLayout(false);
      this.PanelOptions.PerformLayout();
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
    private Panel PanelOptions;
    private CheckBox SelectVerseTakeFirstElseLast;
  }

}