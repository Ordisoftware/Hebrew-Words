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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ActionAnalyse = new System.Windows.Forms.Button();
      this.ActionOK = new System.Windows.Forms.Button();
      this.ActionCancel = new System.Windows.Forms.Button();
      this.PanelMain = new System.Windows.Forms.SplitContainer();
      this.EditSource = new System.Windows.Forms.TextBox();
      this.DataGridView = new System.Windows.Forms.DataGridView();
      this.importResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.hebrewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.originalTranslationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.newTranslationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).BeginInit();
      this.PanelMain.Panel1.SuspendLayout();
      this.PanelMain.Panel2.SuspendLayout();
      this.PanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.importResultsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ActionAnalyse);
      this.panel1.Controls.Add(this.ActionOK);
      this.panel1.Controls.Add(this.ActionCancel);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(10, 628);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(772, 28);
      this.panel1.TabIndex = 37;
      // 
      // ActionAnalyse
      // 
      this.ActionAnalyse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.ActionAnalyse.Enabled = false;
      this.ActionAnalyse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ActionAnalyse.Location = new System.Drawing.Point(3, 2);
      this.ActionAnalyse.Name = "ActionAnalyse";
      this.ActionAnalyse.Size = new System.Drawing.Size(75, 24);
      this.ActionAnalyse.TabIndex = 0;
      this.ActionAnalyse.Text = "Analyse";
      this.ActionAnalyse.Click += new System.EventHandler(this.ActionAnalyse_Click);
      // 
      // ActionOK
      // 
      this.ActionOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionOK.Enabled = false;
      this.ActionOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ActionOK.Location = new System.Drawing.Point(613, 2);
      this.ActionOK.Name = "ActionOK";
      this.ActionOK.Size = new System.Drawing.Size(75, 24);
      this.ActionOK.TabIndex = 0;
      this.ActionOK.Text = "OK";
      this.ActionOK.Click += new System.EventHandler(this.ActionOK_Click);
      // 
      // ActionCancel
      // 
      this.ActionCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.ActionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ActionCancel.Location = new System.Drawing.Point(694, 2);
      this.ActionCancel.Name = "ActionCancel";
      this.ActionCancel.Size = new System.Drawing.Size(75, 24);
      this.ActionCancel.TabIndex = 0;
      this.ActionCancel.Text = "Cancel";
      // 
      // PanelMain
      // 
      this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelMain.Location = new System.Drawing.Point(10, 10);
      this.PanelMain.Name = "PanelMain";
      this.PanelMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // PanelMain.Panel1
      // 
      this.PanelMain.Panel1.Controls.Add(this.EditSource);
      this.PanelMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
      // 
      // PanelMain.Panel2
      // 
      this.PanelMain.Panel2.Controls.Add(this.DataGridView);
      this.PanelMain.Panel2.Padding = new System.Windows.Forms.Padding(10);
      this.PanelMain.Size = new System.Drawing.Size(772, 618);
      this.PanelMain.SplitterDistance = 300;
      this.PanelMain.TabIndex = 38;
      // 
      // EditSource
      // 
      this.EditSource.Dock = System.Windows.Forms.DockStyle.Fill;
      this.EditSource.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditSource.Location = new System.Drawing.Point(10, 10);
      this.EditSource.Multiline = true;
      this.EditSource.Name = "EditSource";
      this.EditSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.EditSource.Size = new System.Drawing.Size(752, 280);
      this.EditSource.TabIndex = 0;
      this.EditSource.WordWrap = false;
      this.EditSource.TextChanged += new System.EventHandler(this.EditSource_TextChanged);
      // 
      // DataGridView
      // 
      this.DataGridView.AutoGenerateColumns = false;
      this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hebrewDataGridViewTextBoxColumn,
            this.originalTranslationDataGridViewTextBoxColumn,
            this.newTranslationDataGridViewTextBoxColumn});
      this.DataGridView.DataSource = this.importResultsBindingSource;
      this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DataGridView.Location = new System.Drawing.Point(10, 10);
      this.DataGridView.Name = "DataGridView";
      this.DataGridView.Size = new System.Drawing.Size(752, 294);
      this.DataGridView.TabIndex = 0;
      // 
      // importResultsBindingSource
      // 
      this.importResultsBindingSource.DataSource = typeof(Ordisoftware.HebrewWords.ImportResults);
      // 
      // hebrewDataGridViewTextBoxColumn
      // 
      this.hebrewDataGridViewTextBoxColumn.DataPropertyName = "Hebrew";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.hebrewDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
      this.hebrewDataGridViewTextBoxColumn.HeaderText = "Hebrew";
      this.hebrewDataGridViewTextBoxColumn.Name = "hebrewDataGridViewTextBoxColumn";
      this.hebrewDataGridViewTextBoxColumn.Width = 150;
      // 
      // originalTranslationDataGridViewTextBoxColumn
      // 
      this.originalTranslationDataGridViewTextBoxColumn.DataPropertyName = "OriginalTranslation";
      this.originalTranslationDataGridViewTextBoxColumn.HeaderText = "OriginalTranslation";
      this.originalTranslationDataGridViewTextBoxColumn.Name = "originalTranslationDataGridViewTextBoxColumn";
      this.originalTranslationDataGridViewTextBoxColumn.Width = 250;
      // 
      // newTranslationDataGridViewTextBoxColumn
      // 
      this.newTranslationDataGridViewTextBoxColumn.DataPropertyName = "NewTranslation";
      this.newTranslationDataGridViewTextBoxColumn.HeaderText = "NewTranslation";
      this.newTranslationDataGridViewTextBoxColumn.Name = "newTranslationDataGridViewTextBoxColumn";
      this.newTranslationDataGridViewTextBoxColumn.Width = 250;
      // 
      // ImportVerseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionCancel;
      this.ClientSize = new System.Drawing.Size(792, 666);
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.panel1);
      this.MinimumSize = new System.Drawing.Size(800, 600);
      this.Name = "ImportVerseForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Text = "Import console";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImportVerseForm_FormClosed);
      this.panel1.ResumeLayout(false);
      this.PanelMain.Panel1.ResumeLayout(false);
      this.PanelMain.Panel1.PerformLayout();
      this.PanelMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).EndInit();
      this.PanelMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.importResultsBindingSource)).EndInit();
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
    private System.Windows.Forms.DataGridViewTextBoxColumn hebrewDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn originalTranslationDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn newTranslationDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource importResultsBindingSource;
  }
}