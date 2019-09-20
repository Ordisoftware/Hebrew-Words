namespace Ordisoftware.HebrewWords
{
  partial class ImportVerseForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportVerseForm));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.PanelMain = new System.Windows.Forms.SplitContainer();
      this.EditSource = new System.Windows.Forms.TextBox();
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.importResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.ActionAnalyse = new System.Windows.Forms.Button();
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.hebrewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CurrentTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ImportedTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).BeginInit();
      this.PanelMain.Panel1.SuspendLayout();
      this.PanelMain.Panel2.SuspendLayout();
      this.PanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.importResultsBindingSource)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelMain
      // 
      resources.ApplyResources(this.PanelMain, "PanelMain");
      this.PanelMain.Name = "PanelMain";
      // 
      // PanelMain.Panel1
      // 
      resources.ApplyResources(this.PanelMain.Panel1, "PanelMain.Panel1");
      this.PanelMain.Panel1.Controls.Add(this.EditSource);
      // 
      // PanelMain.Panel2
      // 
      resources.ApplyResources(this.PanelMain.Panel2, "PanelMain.Panel2");
      this.PanelMain.Panel2.Controls.Add(this.DataGridView);
      // 
      // EditSource
      // 
      resources.ApplyResources(this.EditSource, "EditSource");
      this.EditSource.Name = "EditSource";
      this.EditSource.TextChanged += new System.EventHandler(this.EditSource_TextChanged);
      // 
      // DataGridView
      // 
      resources.ApplyResources(this.DataGridView, "DataGridView");
      this.DataGridView.AutoGenerateColumns = false;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hebrewDataGridViewTextBoxColumn,
            this.CurrentTranslation,
            this.ImportedTranslation});
      this.DataGridView.DataSource = this.importResultsBindingSource;
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.RowHeadersVisible = false;
      // 
      // importResultsBindingSource
      // 
      this.importResultsBindingSource.DataSource = typeof(Ordisoftware.HebrewWords.ImportResults);
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.ActionAnalyse);
      this.panel1.Controls.Add(this.ActionOK);
      this.panel1.Controls.Add(this.ActionCancel);
      this.panel1.Name = "panel1";
      // 
      // ActionAnalyse
      // 
      resources.ApplyResources(this.ActionAnalyse, "ActionAnalyse");
      this.ActionAnalyse.Name = "ActionAnalyse";
      this.ActionAnalyse.Click += new System.EventHandler(this.ActionAnalyse_Click);
      // 
      // ActionOK
      // 
      resources.ApplyResources(this.ActionOK, "ActionOK");
      this.ActionOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionOK.Name = "ActionOK";
      this.ActionOK.Click += new System.EventHandler(this.ActionOK_Click);
      // 
      // ActionCancel
      // 
      resources.ApplyResources(this.ActionCancel, "ActionCancel");
      this.ActionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionCancel.Name = "ActionCancel";
      // 
      // hebrewDataGridViewTextBoxColumn
      // 
      this.hebrewDataGridViewTextBoxColumn.DataPropertyName = "Hebrew";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.hebrewDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
      resources.ApplyResources(this.hebrewDataGridViewTextBoxColumn, "hebrewDataGridViewTextBoxColumn");
      this.hebrewDataGridViewTextBoxColumn.Name = "hebrewDataGridViewTextBoxColumn";
      this.hebrewDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // CurrentTranslation
      // 
      this.CurrentTranslation.DataPropertyName = "CurrentTranslation";
      resources.ApplyResources(this.CurrentTranslation, "CurrentTranslation");
      this.CurrentTranslation.Name = "CurrentTranslation";
      this.CurrentTranslation.ReadOnly = true;
      // 
      // ImportedTranslation
      // 
      this.ImportedTranslation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ImportedTranslation.DataPropertyName = "ImportedTranslation";
      resources.ApplyResources(this.ImportedTranslation, "ImportedTranslation");
      this.ImportedTranslation.Name = "ImportedTranslation";
      // 
      // ImportVerseForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.ClientSize = global::Ordisoftware.HebrewWords.Properties.Settings.Default.ImportVerseFormSize;
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.panel1);
      this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "ImportVerseFormSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.Name = "ImportVerseForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImportVerseForm_FormClosed);
      this.PanelMain.Panel1.ResumeLayout(false);
      this.PanelMain.Panel1.PerformLayout();
      this.PanelMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).EndInit();
      this.PanelMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.importResultsBindingSource)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.SplitContainer PanelMain;
    private System.Windows.Forms.Button ActionOK;
    private System.Windows.Forms.Button ActionCancel;
    private System.Windows.Forms.TextBox EditSource;
    private System.Windows.Forms.Button ActionAnalyse;
    private System.Windows.Forms.DataGridView DataGridView;
    private System.Windows.Forms.BindingSource importResultsBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn newTranslationDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn hebrewDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn CurrentTranslation;
    private System.Windows.Forms.DataGridViewTextBoxColumn ImportedTranslation;
  }
}