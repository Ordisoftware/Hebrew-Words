namespace Ordisoftware.Hebrew.Words
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
      this.EditSource = new Ordisoftware.Core.TextBoxEx();
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.ColumnHebrew = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnCurrentTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnImportedTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.WordMatchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.PanelBottom = new System.Windows.Forms.Panel();
      this.ActionHelp = new System.Windows.Forms.Button();
      this.ActionAnalyse = new System.Windows.Forms.Button();
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).BeginInit();
      this.PanelMain.Panel1.SuspendLayout();
      this.PanelMain.Panel2.SuspendLayout();
      this.PanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.WordMatchesBindingSource)).BeginInit();
      this.PanelBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelMain
      // 
      this.PanelMain.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "ImportVerseFormSplitterDistance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
      this.PanelMain.SplitterDistance = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.ImportVerseFormSplitterDistance;
      this.PanelMain.TabStop = false;
      this.PanelMain.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.PanelMain_SplitterMoving);
      // 
      // EditSource
      // 
      this.EditSource.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      resources.ApplyResources(this.EditSource, "EditSource");
      this.EditSource.Name = "EditSource";
      this.EditSource.TextChanged += new System.EventHandler(this.EditSource_TextChanged);
      // 
      // DataGridView
      // 
      this.DataGridView.AllowUserToAddRows = false;
      this.DataGridView.AllowUserToDeleteRows = false;
      this.DataGridView.AllowUserToResizeRows = false;
      this.DataGridView.AutoGenerateColumns = false;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHebrew,
            this.ColumnCurrentTranslation,
            this.ColumnImportedTranslation});
      this.DataGridView.DataSource = this.WordMatchesBindingSource;
      resources.ApplyResources(this.DataGridView, "DataGridView");
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.RowHeadersVisible = false;
      this.DataGridView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DataGridView_ColumnWidthChanged);
      // 
      // ColumnHebrew
      // 
      this.ColumnHebrew.DataPropertyName = "Hebrew";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ColumnHebrew.DefaultCellStyle = dataGridViewCellStyle2;
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
      // WordMatchesBindingSource
      // 
      this.WordMatchesBindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.ImportWordMatch);
      // 
      // PanelBottom
      // 
      this.PanelBottom.Controls.Add(this.ActionHelp);
      this.PanelBottom.Controls.Add(this.ActionAnalyse);
      this.PanelBottom.Controls.Add(this.ActionOK);
      this.PanelBottom.Controls.Add(this.ActionCancel);
      resources.ApplyResources(this.PanelBottom, "PanelBottom");
      this.PanelBottom.Name = "PanelBottom";
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
      this.ClientSize = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.ImportVerseFormSize;
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.PanelBottom);
      this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "ImportVerseFormSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.MaximizeBox = false;
      this.Name = "ImportVerseForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImportVerseForm_FormClosed);
      this.Load += new System.EventHandler(this.ImportVerseForm_Load);
      this.Shown += new System.EventHandler(this.ImportVerseForm_Shown);
      this.PanelMain.Panel1.ResumeLayout(false);
      this.PanelMain.Panel1.PerformLayout();
      this.PanelMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).EndInit();
      this.PanelMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.WordMatchesBindingSource)).EndInit();
      this.PanelBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel PanelBottom;
    private System.Windows.Forms.SplitContainer PanelMain;
    private System.Windows.Forms.Button ActionOK;
    private System.Windows.Forms.Button ActionCancel;
    private Ordisoftware.Core.TextBoxEx EditSource;
    private System.Windows.Forms.Button ActionAnalyse;
    private System.Windows.Forms.DataGridView DataGridView;
    private System.Windows.Forms.BindingSource WordMatchesBindingSource;
    private System.Windows.Forms.Button ActionHelp;
    private DataGridViewTextBoxColumn ColumnHebrew;
    private DataGridViewTextBoxColumn ColumnCurrentTranslation;
    private DataGridViewTextBoxColumn ColumnImportedTranslation;
  }
}