namespace Ordisoftware.HebrewWords
{
  partial class StatisticsForm
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
      this.GroupBoxAllBooks = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.buttonClose = new System.Windows.Forms.Button();
      this.GroupBoxTorah = new System.Windows.Forms.GroupBox();
      this.GroupBoxBook = new System.Windows.Forms.GroupBox();
      this.EditBook = new System.Windows.Forms.ComboBox();
      this.StatBook = new Ordisoftware.HebrewWords.StatControl();
      this.StatTorah = new Ordisoftware.HebrewWords.StatControl();
      this.StatAllBooks = new Ordisoftware.HebrewWords.StatControl();
      this.GroupBoxAllBooks.SuspendLayout();
      this.panel1.SuspendLayout();
      this.GroupBoxTorah.SuspendLayout();
      this.GroupBoxBook.SuspendLayout();
      this.SuspendLayout();
      // 
      // GroupBoxAllBooks
      // 
      this.GroupBoxAllBooks.Controls.Add(this.StatAllBooks);
      this.GroupBoxAllBooks.Location = new System.Drawing.Point(13, 13);
      this.GroupBoxAllBooks.Name = "GroupBoxAllBooks";
      this.GroupBoxAllBooks.Size = new System.Drawing.Size(143, 100);
      this.GroupBoxAllBooks.TabIndex = 0;
      this.GroupBoxAllBooks.TabStop = false;
      this.GroupBoxAllBooks.Text = "All books";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.buttonClose);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(10, 242);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(307, 28);
      this.panel1.TabIndex = 36;
      // 
      // buttonClose
      // 
      this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.buttonClose.Location = new System.Drawing.Point(229, 2);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(75, 24);
      this.buttonClose.TabIndex = 24;
      this.buttonClose.Text = "Close";
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // GroupBoxTorah
      // 
      this.GroupBoxTorah.Controls.Add(this.StatTorah);
      this.GroupBoxTorah.Location = new System.Drawing.Point(167, 13);
      this.GroupBoxTorah.Name = "GroupBoxTorah";
      this.GroupBoxTorah.Size = new System.Drawing.Size(143, 100);
      this.GroupBoxTorah.TabIndex = 0;
      this.GroupBoxTorah.TabStop = false;
      this.GroupBoxTorah.Text = "Torah";
      // 
      // GroupBoxBook
      // 
      this.GroupBoxBook.Controls.Add(this.EditBook);
      this.GroupBoxBook.Controls.Add(this.StatBook);
      this.GroupBoxBook.Location = new System.Drawing.Point(13, 124);
      this.GroupBoxBook.Name = "GroupBoxBook";
      this.GroupBoxBook.Size = new System.Drawing.Size(297, 100);
      this.GroupBoxBook.TabIndex = 0;
      this.GroupBoxBook.TabStop = false;
      this.GroupBoxBook.Text = "Book";
      // 
      // EditBook
      // 
      this.EditBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.EditBook.FormattingEnabled = true;
      this.EditBook.Location = new System.Drawing.Point(11, 24);
      this.EditBook.Name = "EditBook";
      this.EditBook.Size = new System.Drawing.Size(132, 21);
      this.EditBook.TabIndex = 1;
      this.EditBook.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // StatBook
      // 
      this.StatBook.Location = new System.Drawing.Point(165, 24);
      this.StatBook.Name = "StatBook";
      this.StatBook.Size = new System.Drawing.Size(118, 63);
      this.StatBook.TabIndex = 0;
      // 
      // StatTorah
      // 
      this.StatTorah.Location = new System.Drawing.Point(11, 24);
      this.StatTorah.Name = "StatTorah";
      this.StatTorah.Size = new System.Drawing.Size(118, 63);
      this.StatTorah.TabIndex = 0;
      // 
      // StatAllBooks
      // 
      this.StatAllBooks.Location = new System.Drawing.Point(11, 24);
      this.StatAllBooks.Name = "StatAllBooks";
      this.StatAllBooks.Size = new System.Drawing.Size(118, 63);
      this.StatAllBooks.TabIndex = 0;
      // 
      // StatisticsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(327, 280);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.GroupBoxBook);
      this.Controls.Add(this.GroupBoxTorah);
      this.Controls.Add(this.GroupBoxAllBooks);
      this.Name = "StatisticsForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Statistics";
      this.Load += new System.EventHandler(this.StatisticsForm_Load);
      this.GroupBoxAllBooks.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.GroupBoxTorah.ResumeLayout(false);
      this.GroupBoxBook.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox GroupBoxAllBooks;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button buttonClose;
    private StatControl StatAllBooks;
    private System.Windows.Forms.GroupBox GroupBoxTorah;
    private StatControl StatTorah;
    private System.Windows.Forms.GroupBox GroupBoxBook;
    private System.Windows.Forms.ComboBox EditBook;
    private StatControl StatBook;
  }
}