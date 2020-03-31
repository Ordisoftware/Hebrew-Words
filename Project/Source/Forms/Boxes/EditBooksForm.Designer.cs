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
      this.EditBooks = new System.Windows.Forms.DataGridView();
      this.ContextMenuStripResults = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionOnlineSearch = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionOpenHebrewLetters = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ActionClose = new System.Windows.Forms.Button();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DataSet = new Ordisoftware.HebrewWords.Data.DataSet();
      this.BooksTableAdapter = new Ordisoftware.HebrewWords.Data.DataSetTableAdapters.BooksTableAdapter();
      this.TableAdapterManager = new Ordisoftware.HebrewWords.Data.DataSetTableAdapters.TableAdapterManager();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyFontChars = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyUnicodeChars = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSearchTranslated = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSearchWord = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      ((System.ComponentModel.ISupportInitialize)(this.EditBooks)).BeginInit();
      this.ContextMenuStripResults.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // EditBooks
      // 
      this.EditBooks.AllowUserToAddRows = false;
      this.EditBooks.AllowUserToDeleteRows = false;
      this.EditBooks.AllowUserToResizeRows = false;
      resources.ApplyResources(this.EditBooks, "EditBooks");
      this.EditBooks.AutoGenerateColumns = false;
      this.EditBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.EditBooks.ContextMenuStrip = this.ContextMenuStripResults;
      this.EditBooks.DataSource = this.BooksBindingSource;
      this.EditBooks.MultiSelect = false;
      this.EditBooks.Name = "EditBooks";
      this.EditBooks.RowHeadersVisible = false;
      this.EditBooks.RowTemplate.Height = 28;
      this.EditBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.EditBooks.ShowCellToolTips = false;
      this.EditBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BooksDataGridView_CellFormatting);
      this.EditBooks.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EditBooks_CellMouseDown);
      // 
      // ContextMenuStripResults
      // 
      this.ContextMenuStripResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionOnlineSearch,
            this.ActionSearchTranslated,
            this.ActionSearchWord,
            this.toolStripSeparator2,
            this.ActionOpenHebrewLetters,
            this.toolStripSeparator1,
            this.toolStripMenuItem3,
            this.ActionCopyFontChars,
            this.ActionCopyUnicodeChars,
            this.toolStripSeparator3,
            this.toolStripMenuItem1});
      this.ContextMenuStripResults.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStripResults, "ContextMenuStripResults");
      // 
      // ActionOnlineSearch
      // 
      resources.ApplyResources(this.ActionOnlineSearch, "ActionOnlineSearch");
      this.ActionOnlineSearch.Name = "ActionOnlineSearch";
      this.ActionOnlineSearch.Click += new System.EventHandler(this.ActionOnlineSearch_Click);
      // 
      // ActionOpenHebrewLetters
      // 
      resources.ApplyResources(this.ActionOpenHebrewLetters, "ActionOpenHebrewLetters");
      this.ActionOpenHebrewLetters.Name = "ActionOpenHebrewLetters";
      this.ActionOpenHebrewLetters.Click += new System.EventHandler(this.ActionOpenHebrewLetters_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ActionClose);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // ActionClose
      // 
      resources.ApplyResources(this.ActionClose, "ActionClose");
      this.ActionClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionClose.Name = "ActionClose";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Number";
      resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Hebrew";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
      resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
      resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Translation";
      resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // BooksBindingSource
      // 
      this.BooksBindingSource.DataMember = "Books";
      this.BooksBindingSource.DataSource = this.DataSet;
      // 
      // DataSet
      // 
      this.DataSet.DataSetName = "DataSet";
      this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // BooksTableAdapter
      // 
      this.BooksTableAdapter.ClearBeforeFill = true;
      // 
      // TableAdapterManager
      // 
      this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.TableAdapterManager.BooksTableAdapter = null;
      this.TableAdapterManager.ChaptersTableAdapter = null;
      this.TableAdapterManager.Connection = null;
      this.TableAdapterManager.StrongConcordancesTableAdapter = null;
      this.TableAdapterManager.UpdateOrder = Ordisoftware.HebrewWords.Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      this.TableAdapterManager.VersesTableAdapter = null;
      this.TableAdapterManager.WordsTableAdapter = null;
      // 
      // toolStripMenuItem3
      // 
      resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      // 
      // ActionCopyFontChars
      // 
      resources.ApplyResources(this.ActionCopyFontChars, "ActionCopyFontChars");
      this.ActionCopyFontChars.Name = "ActionCopyFontChars";
      // 
      // ActionCopyUnicodeChars
      // 
      resources.ApplyResources(this.ActionCopyUnicodeChars, "ActionCopyUnicodeChars");
      this.ActionCopyUnicodeChars.Name = "ActionCopyUnicodeChars";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
      // 
      // ActionSearchTranslated
      // 
      resources.ApplyResources(this.ActionSearchTranslated, "ActionSearchTranslated");
      this.ActionSearchTranslated.Name = "ActionSearchTranslated";
      // 
      // ActionSearchWord
      // 
      resources.ApplyResources(this.ActionSearchWord, "ActionSearchWord");
      this.ActionSearchWord.Name = "ActionSearchWord";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
      // 
      // EditBooksForm
      // 
      this.AcceptButton = this.ActionClose;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionClose;
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.EditBooks);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditBooksForm";
      this.ShowInTaskbar = false;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditBooksForm_FormClosing);
      this.Load += new System.EventHandler(this.EditBooksForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.EditBooks)).EndInit();
      this.ContextMenuStripResults.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Data.DataSet DataSet;
    private System.Windows.Forms.BindingSource BooksBindingSource;
    private Data.DataSetTableAdapters.BooksTableAdapter BooksTableAdapter;
    private Data.DataSetTableAdapters.TableAdapterManager TableAdapterManager;
    private System.Windows.Forms.DataGridView EditBooks;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button ActionClose;
    private System.Windows.Forms.ContextMenuStrip ContextMenuStripResults;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenHebrewLetters;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.ToolStripMenuItem ActionOnlineSearch;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyFontChars;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyUnicodeChars;
    private System.Windows.Forms.ToolStripMenuItem ActionSearchTranslated;
    private System.Windows.Forms.ToolStripMenuItem ActionSearchWord;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  }
}