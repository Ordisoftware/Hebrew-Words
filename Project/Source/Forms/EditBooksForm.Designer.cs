namespace Ordisoftware.HebrewWords
{
  partial class EditBooksForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBooksForm));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.BooksDataGridView = new System.Windows.Forms.DataGridView();
      this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionCopyHebrewName = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.buttonClose = new System.Windows.Forms.Button();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataSet = new Ordisoftware.HebrewWords.Data.DataSet();
      this.BooksTableAdapter = new Ordisoftware.HebrewWords.Data.DataSetTableAdapters.BooksTableAdapter();
      this.TableAdapterManager = new Ordisoftware.HebrewWords.Data.DataSetTableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
      this.ContextMenuStrip.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // BooksDataGridView
      // 
      this.BooksDataGridView.AllowUserToAddRows = false;
      this.BooksDataGridView.AllowUserToDeleteRows = false;
      this.BooksDataGridView.AllowUserToResizeRows = false;
      resources.ApplyResources(this.BooksDataGridView, "BooksDataGridView");
      this.BooksDataGridView.AutoGenerateColumns = false;
      this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.BooksDataGridView.ContextMenuStrip = this.ContextMenuStrip;
      this.BooksDataGridView.DataSource = this.BooksBindingSource;
      this.BooksDataGridView.MultiSelect = false;
      this.BooksDataGridView.Name = "BooksDataGridView";
      this.BooksDataGridView.RowHeadersVisible = false;
      this.BooksDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BooksDataGridView_CellFormatting);
      // 
      // ContextMenuStrip
      // 
      this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionCopyHebrewName});
      this.ContextMenuStrip.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStrip, "ContextMenuStrip");
      // 
      // ActionCopyHebrewName
      // 
      this.ActionCopyHebrewName.Name = "ActionCopyHebrewName";
      resources.ApplyResources(this.ActionCopyHebrewName, "ActionCopyHebrewName");
      this.ActionCopyHebrewName.Click += new System.EventHandler(this.ActionCopyHebrewName_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.buttonClose);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // buttonClose
      // 
      resources.ApplyResources(this.buttonClose, "buttonClose");
      this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Number";
      resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Hebrew";
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Hebrew", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
      resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
      resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Translation";
      resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // BooksBindingSource
      // 
      this.BooksBindingSource.DataMember = "Books";
      this.BooksBindingSource.DataSource = this.dataSet;
      // 
      // dataSet
      // 
      this.dataSet.DataSetName = "DataSet";
      this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // BooksTableAdapter
      // 
      this.BooksTableAdapter.ClearBeforeFill = true;
      // 
      // TableAdapterManager
      // 
      this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.TableAdapterManager.BooksTableAdapter = this.BooksTableAdapter;
      this.TableAdapterManager.ChaptersTableAdapter = null;
      this.TableAdapterManager.UpdateOrder = Ordisoftware.HebrewWords.Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      this.TableAdapterManager.VersesTableAdapter = null;
      this.TableAdapterManager.WordsTableAdapter = null;
      // 
      // EditBooksForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.BooksDataGridView);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditBooksForm";
      this.ShowInTaskbar = false;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditBooksForm_FormClosing);
      this.Load += new System.EventHandler(this.EditBooksForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
      this.ContextMenuStrip.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Data.DataSet dataSet;
    private System.Windows.Forms.BindingSource BooksBindingSource;
    private Data.DataSetTableAdapters.BooksTableAdapter BooksTableAdapter;
    private Data.DataSetTableAdapters.TableAdapterManager TableAdapterManager;
    private System.Windows.Forms.DataGridView BooksDataGridView;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyHebrewName;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
  }
}