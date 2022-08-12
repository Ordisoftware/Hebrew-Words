using System;
using System.Windows.Forms;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide input box.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  partial class SelectVersesByDateUpdatedForm : Form
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectVersesByDateUpdatedForm));
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.PanelBottom = new System.Windows.Forms.Panel();
      this.PanelSeparator = new System.Windows.Forms.Panel();
      this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnChapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnDateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.LabelDisplayCount = new System.Windows.Forms.Label();
      this.EditDisplayCount = new System.Windows.Forms.NumericUpDown();
      this.PanelBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDisplayCount)).BeginInit();
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
      // PanelBottom
      // 
      this.PanelBottom.Controls.Add(this.EditDisplayCount);
      this.PanelBottom.Controls.Add(this.LabelDisplayCount);
      this.PanelBottom.Controls.Add(this.ActionCancel);
      this.PanelBottom.Controls.Add(this.ActionOK);
      resources.ApplyResources(this.PanelBottom, "PanelBottom");
      this.PanelBottom.Name = "PanelBottom";
      // 
      // PanelSeparator
      // 
      resources.ApplyResources(this.PanelSeparator, "PanelSeparator");
      this.PanelSeparator.Name = "PanelSeparator";
      // 
      // BindingSource
      // 
      this.BindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.VerseRow);
      // 
      // DataGridView
      // 
      this.DataGridView.AutoGenerateColumns = false;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnBook,
            this.ColumnChapter,
            this.ColumnNumber,
            this.dataGridViewTextBoxColumn2,
            this.ColumnDateModified});
      this.DataGridView.DataSource = this.BindingSource;
      resources.ApplyResources(this.DataGridView, "DataGridView");
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.RowHeadersVisible = false;
      this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      // 
      // ColumnId
      // 
      this.ColumnId.DataPropertyName = "ID";
      resources.ApplyResources(this.ColumnId, "ColumnId");
      this.ColumnId.Name = "ColumnId";
      this.ColumnId.ReadOnly = true;
      // 
      // ColumnBook
      // 
      this.ColumnBook.DataPropertyName = "BookTranscription";
      resources.ApplyResources(this.ColumnBook, "ColumnBook");
      this.ColumnBook.Name = "ColumnBook";
      this.ColumnBook.ReadOnly = true;
      // 
      // ColumnChapter
      // 
      this.ColumnChapter.DataPropertyName = "ChapterNumber";
      resources.ApplyResources(this.ColumnChapter, "ColumnChapter");
      this.ColumnChapter.Name = "ColumnChapter";
      this.ColumnChapter.ReadOnly = true;
      // 
      // ColumnNumber
      // 
      this.ColumnNumber.DataPropertyName = "Number";
      resources.ApplyResources(this.ColumnNumber, "ColumnNumber");
      this.ColumnNumber.Name = "ColumnNumber";
      this.ColumnNumber.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Translation";
      resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // ColumnDateModified
      // 
      this.ColumnDateModified.DataPropertyName = "DateModified";
      resources.ApplyResources(this.ColumnDateModified, "ColumnDateModified");
      this.ColumnDateModified.Name = "ColumnDateModified";
      this.ColumnDateModified.ReadOnly = true;
      // 
      // LabelDisplayCount
      // 
      resources.ApplyResources(this.LabelDisplayCount, "LabelDisplayCount");
      this.LabelDisplayCount.Name = "LabelDisplayCount";
      // 
      // EditDisplayCount
      // 
      this.EditDisplayCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVersesByDateUpdatedFormDisplayCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditDisplayCount.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
      resources.ApplyResources(this.EditDisplayCount, "EditDisplayCount");
      this.EditDisplayCount.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
      this.EditDisplayCount.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.EditDisplayCount.Name = "EditDisplayCount";
      this.EditDisplayCount.Value = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVersesByDateUpdatedFormDisplayCount;
      // 
      // SelectVersesByDateUpdatedForm
      // 
      this.AcceptButton = this.ActionOK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.DataGridView);
      this.Controls.Add(this.PanelSeparator);
      this.Controls.Add(this.PanelBottom);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SelectVersesByDateUpdatedForm";
      this.ShowInTaskbar = false;
      this.PanelBottom.ResumeLayout(false);
      this.PanelBottom.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDisplayCount)).EndInit();
      this.ResumeLayout(false);

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
    private Panel PanelSeparator;
    private BindingSource BindingSource;
    private DataGridView DataGridView;
    private DataGridViewTextBoxColumn ColumnId;
    private DataGridViewTextBoxColumn ColumnBook;
    private DataGridViewTextBoxColumn ColumnChapter;
    private DataGridViewTextBoxColumn ColumnNumber;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn ColumnDateModified;
    private Label LabelDisplayCount;
    private NumericUpDown EditDisplayCount;
  }

}