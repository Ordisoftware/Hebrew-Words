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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.PanelMain = new System.Windows.Forms.SplitContainer();
      this.EditSource = new System.Windows.Forms.TextBox();
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.ColumnHebrew = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnCurrentTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnImportedTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.importResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.ActionHelp = new System.Windows.Forms.Button();
      this.ActionAnalyse = new System.Windows.Forms.Button();
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
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
      this.PanelMain.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "ImportVerseFormSplitterDistance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      resources.ApplyResources(this.PanelMain, "PanelMain");
      this.PanelMain.Name = "PanelMain";
      // 
      // PanelMain.Panel1
      // 
      this.PanelMain.Panel1.Controls.Add(this.EditSource);
      resources.ApplyResources(this.PanelMain.Panel1, "PanelMain.Panel1");
      // 
      // PanelMain.Panel2
      // 
      this.PanelMain.Panel2.Controls.Add(this.DataGridView);
      resources.ApplyResources(this.PanelMain.Panel2, "PanelMain.Panel2");
      this.PanelMain.SplitterDistance = global::Ordisoftware.HebrewWords.Properties.Settings.Default.ImportVerseFormSplitterDistance;
      // 
      // EditSource
      // 
      resources.ApplyResources(this.EditSource, "EditSource");
      this.EditSource.Name = "EditSource";
      this.EditSource.TextChanged += new System.EventHandler(this.EditSource_TextChanged);
      // 
      // DataGridView
      // 
      this.DataGridView.AutoGenerateColumns = false;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHebrew,
            this.ColumnCurrentTranslation,
            this.ColumnImportedTranslation});
      this.DataGridView.DataSource = this.importResultsBindingSource;
      resources.ApplyResources(this.DataGridView, "DataGridView");
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.RowHeadersVisible = false;
      // 
      // ColumnHebrew
      // 
      this.ColumnHebrew.DataPropertyName = "Hebrew";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ColumnHebrew.DefaultCellStyle = dataGridViewCellStyle1;
      resources.ApplyResources(this.ColumnHebrew, "ColumnHebrew");
      this.ColumnHebrew.Name = "ColumnHebrew";
      this.ColumnHebrew.ReadOnly = true;
      // 
      // ColumnCurrentTranslation
      // 
      this.ColumnCurrentTranslation.DataPropertyName = "CurrentTranslation";
      resources.ApplyResources(this.ColumnCurrentTranslation, "ColumnCurrentTranslation");
      this.ColumnCurrentTranslation.Name = "ColumnCurrentTranslation";
      this.ColumnCurrentTranslation.ReadOnly = true;
      // 
      // ColumnImportedTranslation
      // 
      this.ColumnImportedTranslation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnImportedTranslation.DataPropertyName = "ImportedTranslation";
      resources.ApplyResources(this.ColumnImportedTranslation, "ColumnImportedTranslation");
      this.ColumnImportedTranslation.Name = "ColumnImportedTranslation";
      // 
      // importResultsBindingSource
      // 
      this.importResultsBindingSource.DataSource = typeof(Ordisoftware.HebrewWords.ImportResults);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ActionHelp);
      this.panel1.Controls.Add(this.ActionAnalyse);
      this.panel1.Controls.Add(this.ActionOK);
      this.panel1.Controls.Add(this.ActionCancel);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // ActionHelp
      // 
      resources.ApplyResources(this.ActionHelp, "ActionHelp");
      this.ActionHelp.FlatAppearance.BorderSize = 0;
      this.ActionHelp.Name = "ActionHelp";
      this.ActionHelp.Click += new System.EventHandler(this.ActionHelp_Click);
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
    private System.Windows.Forms.Button ActionHelp;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHebrew;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCurrentTranslation;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImportedTranslation;
  }
}