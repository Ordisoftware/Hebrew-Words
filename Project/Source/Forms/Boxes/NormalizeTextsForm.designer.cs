using System;
using System.Windows.Forms;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide input box.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  partial class NormalizeTextsForm : Form
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NormalizeTextsForm));
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ActionOpenPreferences = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.EditApplyToComments = new System.Windows.Forms.CheckBox();
      this.EditApplyToTranslations = new System.Windows.Forms.CheckBox();
      this.EditAddPeriodAtTheEnd = new System.Windows.Forms.CheckBox();
      this.EditTitleizeSentences = new System.Windows.Forms.CheckBox();
      this.EditNormalizePrefix = new System.Windows.Forms.CheckBox();
      this.EditRemoveMultipleEmptyLines = new System.Windows.Forms.CheckBox();
      this.EditRemoveMultipleSpaces = new System.Windows.Forms.CheckBox();
      this.EditReplaceNewlinesBySpaceInTranslation = new System.Windows.Forms.CheckBox();
      this.EditRemoveEmptyLines = new System.Windows.Forms.CheckBox();
      this.EditTrimSpacesAndEmptyLines = new System.Windows.Forms.CheckBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
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
      this.panel1.Controls.Add(this.ActionOpenPreferences);
      this.panel1.Controls.Add(this.ActionCancel);
      this.panel1.Controls.Add(this.ActionOK);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // ActionOpenPreferences
      // 
      this.ActionOpenPreferences.AllowDrop = true;
      this.ActionOpenPreferences.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionOpenPreferences, "ActionOpenPreferences");
      this.ActionOpenPreferences.Name = "ActionOpenPreferences";
      this.ActionOpenPreferences.UseVisualStyleBackColor = true;
      this.ActionOpenPreferences.Click += new System.EventHandler(this.ActionOpenPreferences_Click);
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // EditApplyToComments
      // 
      resources.ApplyResources(this.EditApplyToComments, "EditApplyToComments");
      this.EditApplyToComments.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.NormalizeApplyToComments;
      this.EditApplyToComments.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditApplyToComments.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "NormalizeApplyToComments", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditApplyToComments.Name = "EditApplyToComments";
      this.EditApplyToComments.UseVisualStyleBackColor = true;
      // 
      // EditApplyToTranslations
      // 
      resources.ApplyResources(this.EditApplyToTranslations, "EditApplyToTranslations");
      this.EditApplyToTranslations.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.NormalizeApplyToTranslations;
      this.EditApplyToTranslations.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditApplyToTranslations.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "NormalizeApplyToTranslations", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditApplyToTranslations.Name = "EditApplyToTranslations";
      this.EditApplyToTranslations.UseVisualStyleBackColor = true;
      // 
      // EditAddPeriodAtTheEnd
      // 
      resources.ApplyResources(this.EditAddPeriodAtTheEnd, "EditAddPeriodAtTheEnd");
      this.EditAddPeriodAtTheEnd.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.NormalizeAddPeriodAtTheEnd;
      this.EditAddPeriodAtTheEnd.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditAddPeriodAtTheEnd.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "NormalizeAddPeriodAtTheEnd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditAddPeriodAtTheEnd.Name = "EditAddPeriodAtTheEnd";
      this.EditAddPeriodAtTheEnd.UseVisualStyleBackColor = true;
      // 
      // EditTitleizeSentences
      // 
      resources.ApplyResources(this.EditTitleizeSentences, "EditTitleizeSentences");
      this.EditTitleizeSentences.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.NormalizeTitleizeSentences;
      this.EditTitleizeSentences.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditTitleizeSentences.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "NormalizeTitleizeSentences", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditTitleizeSentences.Name = "EditTitleizeSentences";
      this.EditTitleizeSentences.UseVisualStyleBackColor = true;
      // 
      // EditNormalizePrefix
      // 
      resources.ApplyResources(this.EditNormalizePrefix, "EditNormalizePrefix");
      this.EditNormalizePrefix.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.NormalizePrefix;
      this.EditNormalizePrefix.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditNormalizePrefix.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "NormalizePrefix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditNormalizePrefix.Name = "EditNormalizePrefix";
      this.EditNormalizePrefix.UseVisualStyleBackColor = true;
      // 
      // EditRemoveMultipleEmptyLines
      // 
      resources.ApplyResources(this.EditRemoveMultipleEmptyLines, "EditRemoveMultipleEmptyLines");
      this.EditRemoveMultipleEmptyLines.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.NormalizeRemoveMultipleEmptyLines;
      this.EditRemoveMultipleEmptyLines.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditRemoveMultipleEmptyLines.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "NormalizeRemoveMultipleEmptyLines", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditRemoveMultipleEmptyLines.Name = "EditRemoveMultipleEmptyLines";
      this.EditRemoveMultipleEmptyLines.UseVisualStyleBackColor = true;
      // 
      // EditRemoveMultipleSpaces
      // 
      resources.ApplyResources(this.EditRemoveMultipleSpaces, "EditRemoveMultipleSpaces");
      this.EditRemoveMultipleSpaces.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.NormalizeRemoveMultipleSpaces;
      this.EditRemoveMultipleSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditRemoveMultipleSpaces.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "NormalizeRemoveMultipleSpaces", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditRemoveMultipleSpaces.Name = "EditRemoveMultipleSpaces";
      this.EditRemoveMultipleSpaces.UseVisualStyleBackColor = true;
      // 
      // EditReplaceNewlinesBySpaceInTranslation
      // 
      resources.ApplyResources(this.EditReplaceNewlinesBySpaceInTranslation, "EditReplaceNewlinesBySpaceInTranslation");
      this.EditReplaceNewlinesBySpaceInTranslation.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.NormalizeReplaceNewlinesBySpaceInTranslation;
      this.EditReplaceNewlinesBySpaceInTranslation.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "NormalizeReplaceNewlinesBySpaceInTranslation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditReplaceNewlinesBySpaceInTranslation.Name = "EditReplaceNewlinesBySpaceInTranslation";
      this.EditReplaceNewlinesBySpaceInTranslation.UseVisualStyleBackColor = true;
      // 
      // EditRemoveEmptyLines
      // 
      resources.ApplyResources(this.EditRemoveEmptyLines, "EditRemoveEmptyLines");
      this.EditRemoveEmptyLines.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.NormalizeRemoveEmptyLines;
      this.EditRemoveEmptyLines.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditRemoveEmptyLines.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "NormalizeRemoveEmptyLines", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditRemoveEmptyLines.Name = "EditRemoveEmptyLines";
      this.EditRemoveEmptyLines.UseVisualStyleBackColor = true;
      // 
      // EditTrimSpacesAndEmptyLines
      // 
      resources.ApplyResources(this.EditTrimSpacesAndEmptyLines, "EditTrimSpacesAndEmptyLines");
      this.EditTrimSpacesAndEmptyLines.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.NormalizeTrimSpacesAndEmptyLines;
      this.EditTrimSpacesAndEmptyLines.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditTrimSpacesAndEmptyLines.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "NormalizeTrimSpacesAndEmptyLines", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditTrimSpacesAndEmptyLines.Name = "EditTrimSpacesAndEmptyLines";
      this.EditTrimSpacesAndEmptyLines.UseVisualStyleBackColor = true;
      // 
      // checkBox1
      // 
      resources.ApplyResources(this.checkBox1, "checkBox1");
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      resources.ApplyResources(this.checkBox2, "checkBox2");
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // NormalizeTextsForm
      // 
      this.AcceptButton = this.ActionOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.label1);
      this.Controls.Add(this.EditApplyToComments);
      this.Controls.Add(this.EditApplyToTranslations);
      this.Controls.Add(this.EditAddPeriodAtTheEnd);
      this.Controls.Add(this.EditTitleizeSentences);
      this.Controls.Add(this.EditNormalizePrefix);
      this.Controls.Add(this.EditRemoveMultipleEmptyLines);
      this.Controls.Add(this.EditRemoveMultipleSpaces);
      this.Controls.Add(this.checkBox2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.EditReplaceNewlinesBySpaceInTranslation);
      this.Controls.Add(this.EditRemoveEmptyLines);
      this.Controls.Add(this.EditTrimSpacesAndEmptyLines);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NormalizeTextsForm";
      this.ShowInTaskbar = false;
      this.panel1.ResumeLayout(false);
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
    private CheckBox EditTrimSpacesAndEmptyLines;
    private CheckBox EditRemoveEmptyLines;
    private CheckBox EditReplaceNewlinesBySpaceInTranslation;
    private CheckBox EditRemoveMultipleSpaces;
    private CheckBox EditTitleizeSentences;
    private CheckBox EditNormalizePrefix;
    private CheckBox EditRemoveMultipleEmptyLines;
    private CheckBox EditAddPeriodAtTheEnd;
    private Button ActionOpenPreferences;
    private CheckBox EditApplyToTranslations;
    private CheckBox EditApplyToComments;
    private Label label1;
    private CheckBox checkBox1;
    private CheckBox checkBox2;
  }

}