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
      this.EditFullTranslated = new System.Windows.Forms.CheckBox();
      this.EditFromStartOrEndElseVerse = new System.Windows.Forms.CheckBox();
      this.SelectFirstTranslated = new System.Windows.Forms.RadioButton();
      this.SelectFirstNotTranslated = new System.Windows.Forms.RadioButton();
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
      // 
      // PanelOptions
      // 
      resources.ApplyResources(this.PanelOptions, "PanelOptions");
      this.PanelOptions.Controls.Add(this.EditFullTranslated);
      this.PanelOptions.Controls.Add(this.EditFromStartOrEndElseVerse);
      this.PanelOptions.Controls.Add(this.SelectFirstTranslated);
      this.PanelOptions.Controls.Add(this.SelectFirstNotTranslated);
      this.PanelOptions.Name = "PanelOptions";
      // 
      // EditFullTranslated
      // 
      resources.ApplyResources(this.EditFullTranslated, "EditFullTranslated");
      this.EditFullTranslated.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVerseFullTranslated;
      this.EditFullTranslated.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVerseFullTranslated", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditFullTranslated.Name = "EditFullTranslated";
      this.EditFullTranslated.UseVisualStyleBackColor = true;
      // 
      // EditFromStartOrEndElseVerse
      // 
      resources.ApplyResources(this.EditFromStartOrEndElseVerse, "EditFromStartOrEndElseVerse");
      this.EditFromStartOrEndElseVerse.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVerseFromStartOrEndElseVerse;
      this.EditFromStartOrEndElseVerse.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditFromStartOrEndElseVerse.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVerseFromStartOrEndElseVerse", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditFromStartOrEndElseVerse.Name = "EditFromStartOrEndElseVerse";
      this.EditFromStartOrEndElseVerse.UseVisualStyleBackColor = true;
      // 
      // SelectFirstTranslated
      // 
      resources.ApplyResources(this.SelectFirstTranslated, "SelectFirstTranslated");
      this.SelectFirstTranslated.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectFirstTranslated;
      this.SelectFirstTranslated.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectFirstTranslated", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectFirstTranslated.Name = "SelectFirstTranslated";
      this.SelectFirstTranslated.UseVisualStyleBackColor = true;
      this.SelectFirstTranslated.Click += new System.EventHandler(this.SelectFirstTranslatedOrNot_CheckedChanged);
      // 
      // SelectFirstNotTranslated
      // 
      resources.ApplyResources(this.SelectFirstNotTranslated, "SelectFirstNotTranslated");
      this.SelectFirstNotTranslated.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectFirstNotTranslated;
      this.SelectFirstNotTranslated.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectFirstNotTranslated", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectFirstNotTranslated.Name = "SelectFirstNotTranslated";
      this.SelectFirstNotTranslated.TabStop = true;
      this.SelectFirstNotTranslated.UseVisualStyleBackColor = true;
      this.SelectFirstNotTranslated.Click += new System.EventHandler(this.SelectFirstTranslatedOrNot_CheckedChanged);
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
      this.Controls.Add(this.PanelOptions);
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
    private CheckBox EditFromStartOrEndElseVerse;
    private RadioButton SelectFirstNotTranslated;
    private RadioButton SelectFirstTranslated;
    private CheckBox EditFullTranslated;
    private Panel PanelOptions;
  }

}