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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.PanelBottom = new System.Windows.Forms.Panel();
      this.EditDateEnd = new System.Windows.Forms.DateTimePicker();
      this.EditDateStart = new System.Windows.Forms.DateTimePicker();
      this.SelectDateEnd = new System.Windows.Forms.CheckBox();
      this.SelectDateStart = new System.Windows.Forms.CheckBox();
      this.EditFontSize = new System.Windows.Forms.NumericUpDown();
      this.EditOnlyPartiallyTranslated = new System.Windows.Forms.CheckBox();
      this.EditOnlyFullyTranslated = new System.Windows.Forms.CheckBox();
      this.EditDisplayCount = new System.Windows.Forms.NumericUpDown();
      this.LabelFontSize = new System.Windows.Forms.Label();
      this.LabelDisplayCount = new System.Windows.Forms.Label();
      this.PanelSeparator = new System.Windows.Forms.Panel();
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnBookTranscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnBookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnChapterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnVerseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnVerseTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnDateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PanelBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDisplayCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // ActionOK
      // 
      resources.ApplyResources(this.ActionOK, "ActionOK");
      this.ActionOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionOK.Name = "ActionOK";
      this.ActionOK.UseVisualStyleBackColor = true;
      this.ActionOK.Click += new System.EventHandler(this.ActionOK_Click);
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
      this.PanelBottom.Controls.Add(this.EditDateEnd);
      this.PanelBottom.Controls.Add(this.EditDateStart);
      this.PanelBottom.Controls.Add(this.SelectDateEnd);
      this.PanelBottom.Controls.Add(this.SelectDateStart);
      this.PanelBottom.Controls.Add(this.EditFontSize);
      this.PanelBottom.Controls.Add(this.EditOnlyPartiallyTranslated);
      this.PanelBottom.Controls.Add(this.EditOnlyFullyTranslated);
      this.PanelBottom.Controls.Add(this.EditDisplayCount);
      this.PanelBottom.Controls.Add(this.LabelFontSize);
      this.PanelBottom.Controls.Add(this.LabelDisplayCount);
      this.PanelBottom.Controls.Add(this.ActionCancel);
      this.PanelBottom.Controls.Add(this.ActionOK);
      resources.ApplyResources(this.PanelBottom, "PanelBottom");
      this.PanelBottom.Name = "PanelBottom";
      // 
      // EditDateEnd
      // 
      this.EditDateEnd.Checked = false;
      this.EditDateEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVersesByDateUpdatedFormDateEnd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      resources.ApplyResources(this.EditDateEnd, "EditDateEnd");
      this.EditDateEnd.Name = "EditDateEnd";
      this.EditDateEnd.Value = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVersesByDateUpdatedFormDateEnd;
      this.EditDateEnd.ValueChanged += new System.EventHandler(this.EditDate_ValueChanged);
      // 
      // EditDateStart
      // 
      this.EditDateStart.Checked = false;
      this.EditDateStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVersesByDateUpdatedFormDateStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      resources.ApplyResources(this.EditDateStart, "EditDateStart");
      this.EditDateStart.Name = "EditDateStart";
      this.EditDateStart.Value = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVersesByDateUpdatedFormDateStart;
      this.EditDateStart.ValueChanged += new System.EventHandler(this.EditDate_ValueChanged);
      // 
      // SelectDateEnd
      // 
      resources.ApplyResources(this.SelectDateEnd, "SelectDateEnd");
      this.SelectDateEnd.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVersesByDateUpdatedFormDateEndEnabled;
      this.SelectDateEnd.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVersesByDateUpdatedFormDateEndEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectDateEnd.Name = "SelectDateEnd";
      this.SelectDateEnd.UseVisualStyleBackColor = true;
      this.SelectDateEnd.CheckedChanged += new System.EventHandler(this.SelectDateEnd_CheckedChanged);
      // 
      // SelectDateStart
      // 
      resources.ApplyResources(this.SelectDateStart, "SelectDateStart");
      this.SelectDateStart.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVersesByDateUpdatedFormDateStartEnabled;
      this.SelectDateStart.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVersesByDateUpdatedFormDateStartEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectDateStart.Name = "SelectDateStart";
      this.SelectDateStart.UseVisualStyleBackColor = true;
      this.SelectDateStart.CheckedChanged += new System.EventHandler(this.SelectDateStart_CheckedChanged);
      // 
      // EditFontSize
      // 
      resources.ApplyResources(this.EditFontSize, "EditFontSize");
      this.EditFontSize.BackColor = System.Drawing.SystemColors.Window;
      this.EditFontSize.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVersesByDateUpdatedFormFontSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditFontSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.EditFontSize.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.EditFontSize.Name = "EditFontSize";
      this.EditFontSize.ReadOnly = true;
      this.EditFontSize.Value = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SelectVersesByDateUpdatedFormFontSize;
      this.EditFontSize.ValueChanged += new System.EventHandler(this.EditFontSize_ValueChanged);
      // 
      // EditOnlyPartiallyTranslated
      // 
      resources.ApplyResources(this.EditOnlyPartiallyTranslated, "EditOnlyPartiallyTranslated");
      this.EditOnlyPartiallyTranslated.Name = "EditOnlyPartiallyTranslated";
      this.EditOnlyPartiallyTranslated.UseVisualStyleBackColor = true;
      this.EditOnlyPartiallyTranslated.CheckedChanged += new System.EventHandler(this.EditOnlyPartiallyTranslated_CheckedChanged);
      // 
      // EditOnlyFullyTranslated
      // 
      resources.ApplyResources(this.EditOnlyFullyTranslated, "EditOnlyFullyTranslated");
      this.EditOnlyFullyTranslated.Name = "EditOnlyFullyTranslated";
      this.EditOnlyFullyTranslated.UseVisualStyleBackColor = true;
      this.EditOnlyFullyTranslated.CheckedChanged += new System.EventHandler(this.EditOnlyFullyTranslated_CheckedChanged);
      // 
      // EditDisplayCount
      // 
      resources.ApplyResources(this.EditDisplayCount, "EditDisplayCount");
      this.EditDisplayCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SelectVersesByDateUpdatedFormDisplayCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditDisplayCount.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.EditDisplayCount.Maximum = new decimal(new int[] {
            1000,
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
      this.EditDisplayCount.ValueChanged += new System.EventHandler(this.EditDisplayCount_ValueChanged);
      // 
      // LabelFontSize
      // 
      resources.ApplyResources(this.LabelFontSize, "LabelFontSize");
      this.LabelFontSize.Name = "LabelFontSize";
      // 
      // LabelDisplayCount
      // 
      resources.ApplyResources(this.LabelDisplayCount, "LabelDisplayCount");
      this.LabelDisplayCount.Name = "LabelDisplayCount";
      // 
      // PanelSeparator
      // 
      resources.ApplyResources(this.PanelSeparator, "PanelSeparator");
      this.PanelSeparator.Name = "PanelSeparator";
      // 
      // DataGridView
      // 
      this.DataGridView.AllowUserToAddRows = false;
      this.DataGridView.AllowUserToDeleteRows = false;
      this.DataGridView.AllowUserToResizeRows = false;
      this.DataGridView.AutoGenerateColumns = false;
      this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.DataGridView.BackgroundColor = System.Drawing.Color.White;
      this.DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      resources.ApplyResources(this.DataGridView, "DataGridView");
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnBookTranscription,
            this.ColumnBookNumber,
            this.ColumnChapterNumber,
            this.ColumnVerseNumber,
            this.ColumnVerseTranslation,
            this.ColumnDateModified});
      this.DataGridView.DataSource = this.BindingSource;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.NullValue = "String.Empty";
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
      this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.DataGridView.EnableHeadersVisualStyles = false;
      this.DataGridView.MultiSelect = false;
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.RowHeadersVisible = false;
      this.DataGridView.RowTemplate.Height = 28;
      this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DataGridView.ShowCellToolTips = false;
      this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
      this.DataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
      // 
      // BindingSource
      // 
      this.BindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.VerseRow);
      // 
      // ColumnId
      // 
      this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnId.DataPropertyName = "ID";
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      this.ColumnId.DefaultCellStyle = dataGridViewCellStyle2;
      resources.ApplyResources(this.ColumnId, "ColumnId");
      this.ColumnId.Name = "ColumnId";
      this.ColumnId.ReadOnly = true;
      // 
      // ColumnBookTranscription
      // 
      this.ColumnBookTranscription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnBookTranscription.DataPropertyName = "BookTranscription";
      resources.ApplyResources(this.ColumnBookTranscription, "ColumnBookTranscription");
      this.ColumnBookTranscription.Name = "ColumnBookTranscription";
      this.ColumnBookTranscription.ReadOnly = true;
      // 
      // ColumnBookNumber
      // 
      this.ColumnBookNumber.DataPropertyName = "BookNumber";
      resources.ApplyResources(this.ColumnBookNumber, "ColumnBookNumber");
      this.ColumnBookNumber.Name = "ColumnBookNumber";
      this.ColumnBookNumber.ReadOnly = true;
      // 
      // ColumnChapterNumber
      // 
      this.ColumnChapterNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnChapterNumber.DataPropertyName = "ChapterNumber";
      resources.ApplyResources(this.ColumnChapterNumber, "ColumnChapterNumber");
      this.ColumnChapterNumber.Name = "ColumnChapterNumber";
      this.ColumnChapterNumber.ReadOnly = true;
      // 
      // ColumnVerseNumber
      // 
      this.ColumnVerseNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnVerseNumber.DataPropertyName = "Number";
      resources.ApplyResources(this.ColumnVerseNumber, "ColumnVerseNumber");
      this.ColumnVerseNumber.Name = "ColumnVerseNumber";
      this.ColumnVerseNumber.ReadOnly = true;
      // 
      // ColumnVerseTranslation
      // 
      this.ColumnVerseTranslation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnVerseTranslation.DataPropertyName = "Translation";
      resources.ApplyResources(this.ColumnVerseTranslation, "ColumnVerseTranslation");
      this.ColumnVerseTranslation.Name = "ColumnVerseTranslation";
      this.ColumnVerseTranslation.ReadOnly = true;
      // 
      // ColumnDateModified
      // 
      this.ColumnDateModified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ColumnDateModified.DataPropertyName = "DateModified";
      resources.ApplyResources(this.ColumnDateModified, "ColumnDateModified");
      this.ColumnDateModified.Name = "ColumnDateModified";
      this.ColumnDateModified.ReadOnly = true;
      // 
      // SelectVersesByDateUpdatedForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.Controls.Add(this.DataGridView);
      this.Controls.Add(this.PanelSeparator);
      this.Controls.Add(this.PanelBottom);
      this.Name = "SelectVersesByDateUpdatedForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectVersesByDateUpdatedForm_FormClosed);
      this.Load += new System.EventHandler(this.SelectVersesByDateUpdatedForm_Load);
      this.Shown += new System.EventHandler(this.SelectVersesByDateUpdatedForm_Shown);
      this.PanelBottom.ResumeLayout(false);
      this.PanelBottom.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDisplayCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
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
    private Label LabelDisplayCount;
    private NumericUpDown EditDisplayCount;
    private CheckBox EditOnlyFullyTranslated;
    private DataGridView DataGridView;
        private CheckBox EditOnlyPartiallyTranslated;
        private NumericUpDown EditFontSize;
        private Label LabelFontSize;
        private CheckBox SelectDateStart;
        private CheckBox SelectDateEnd;
        private DateTimePicker EditDateStart;
        private DateTimePicker EditDateEnd;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnBookTranscription;
        private DataGridViewTextBoxColumn ColumnBookNumber;
        private DataGridViewTextBoxColumn ColumnChapterNumber;
        private DataGridViewTextBoxColumn ColumnVerseNumber;
        private DataGridViewTextBoxColumn ColumnVerseTranslation;
        private DataGridViewTextBoxColumn ColumnDateModified;
    }

}