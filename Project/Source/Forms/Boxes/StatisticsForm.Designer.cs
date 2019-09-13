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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
      this.GroupBoxAllBooks = new System.Windows.Forms.GroupBox();
      this.StatAllBooks = new Ordisoftware.HebrewWords.StatControl();
      this.panel1 = new System.Windows.Forms.Panel();
      this.buttonClose = new System.Windows.Forms.Button();
      this.GroupBoxTorah = new System.Windows.Forms.GroupBox();
      this.StatTorah = new Ordisoftware.HebrewWords.StatControl();
      this.GroupBoxBook = new System.Windows.Forms.GroupBox();
      this.SelectBook = new System.Windows.Forms.ComboBox();
      this.StatBook = new Ordisoftware.HebrewWords.StatControl();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.LabelMiddleReferenceValue = new System.Windows.Forms.LinkLabel();
      this.LabelMiddleLetter = new System.Windows.Forms.Label();
      this.LabelMiddleLetterValue = new System.Windows.Forms.Label();
      this.LabelMiddleWordValue = new System.Windows.Forms.Label();
      this.LabelMiddleWord = new System.Windows.Forms.Label();
      this.LabelMiddleReference = new System.Windows.Forms.Label();
      this.GroupBoxAllBooks.SuspendLayout();
      this.panel1.SuspendLayout();
      this.GroupBoxTorah.SuspendLayout();
      this.GroupBoxBook.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // GroupBoxAllBooks
      // 
      this.GroupBoxAllBooks.Controls.Add(this.StatAllBooks);
      resources.ApplyResources(this.GroupBoxAllBooks, "GroupBoxAllBooks");
      this.GroupBoxAllBooks.Name = "GroupBoxAllBooks";
      this.GroupBoxAllBooks.TabStop = false;
      // 
      // StatAllBooks
      // 
      resources.ApplyResources(this.StatAllBooks, "StatAllBooks");
      this.StatAllBooks.Name = "StatAllBooks";
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
      // GroupBoxTorah
      // 
      this.GroupBoxTorah.Controls.Add(this.StatTorah);
      resources.ApplyResources(this.GroupBoxTorah, "GroupBoxTorah");
      this.GroupBoxTorah.Name = "GroupBoxTorah";
      this.GroupBoxTorah.TabStop = false;
      // 
      // StatTorah
      // 
      resources.ApplyResources(this.StatTorah, "StatTorah");
      this.StatTorah.Name = "StatTorah";
      // 
      // GroupBoxBook
      // 
      this.GroupBoxBook.Controls.Add(this.SelectBook);
      this.GroupBoxBook.Controls.Add(this.StatBook);
      resources.ApplyResources(this.GroupBoxBook, "GroupBoxBook");
      this.GroupBoxBook.Name = "GroupBoxBook";
      this.GroupBoxBook.TabStop = false;
      // 
      // SelectBook
      // 
      this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectBook.FormattingEnabled = true;
      resources.ApplyResources(this.SelectBook, "SelectBook");
      this.SelectBook.Name = "SelectBook";
      this.SelectBook.SelectedIndexChanged += new System.EventHandler(this.SelectBook_SelectedIndexChanged);
      // 
      // StatBook
      // 
      resources.ApplyResources(this.StatBook, "StatBook");
      this.StatBook.Name = "StatBook";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.LabelMiddleReferenceValue);
      this.groupBox1.Controls.Add(this.LabelMiddleLetter);
      this.groupBox1.Controls.Add(this.LabelMiddleLetterValue);
      this.groupBox1.Controls.Add(this.LabelMiddleWordValue);
      this.groupBox1.Controls.Add(this.LabelMiddleWord);
      this.groupBox1.Controls.Add(this.LabelMiddleReference);
      resources.ApplyResources(this.groupBox1, "groupBox1");
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      // 
      // LabelMiddleReferenceValue
      // 
      resources.ApplyResources(this.LabelMiddleReferenceValue, "LabelMiddleReferenceValue");
      this.LabelMiddleReferenceValue.Name = "LabelMiddleReferenceValue";
      this.LabelMiddleReferenceValue.TabStop = true;
      this.LabelMiddleReferenceValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelMiddleReferenceValue_LinkClicked);
      // 
      // LabelMiddleLetter
      // 
      resources.ApplyResources(this.LabelMiddleLetter, "LabelMiddleLetter");
      this.LabelMiddleLetter.Name = "LabelMiddleLetter";
      // 
      // LabelMiddleLetterValue
      // 
      resources.ApplyResources(this.LabelMiddleLetterValue, "LabelMiddleLetterValue");
      this.LabelMiddleLetterValue.Name = "LabelMiddleLetterValue";
      this.LabelMiddleLetterValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelMiddleValue_MouseClick);
      this.LabelMiddleLetterValue.MouseEnter += new System.EventHandler(this.LabelMiddleValue_MouseEnter);
      this.LabelMiddleLetterValue.MouseLeave += new System.EventHandler(this.LabelMiddleValue_MouseLeave);
      // 
      // LabelMiddleWordValue
      // 
      resources.ApplyResources(this.LabelMiddleWordValue, "LabelMiddleWordValue");
      this.LabelMiddleWordValue.Name = "LabelMiddleWordValue";
      this.LabelMiddleWordValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelMiddleValue_MouseClick);
      this.LabelMiddleWordValue.MouseEnter += new System.EventHandler(this.LabelMiddleValue_MouseEnter);
      this.LabelMiddleWordValue.MouseLeave += new System.EventHandler(this.LabelMiddleValue_MouseLeave);
      // 
      // LabelMiddleWord
      // 
      resources.ApplyResources(this.LabelMiddleWord, "LabelMiddleWord");
      this.LabelMiddleWord.Name = "LabelMiddleWord";
      // 
      // LabelMiddleReference
      // 
      resources.ApplyResources(this.LabelMiddleReference, "LabelMiddleReference");
      this.LabelMiddleReference.Name = "LabelMiddleReference";
      // 
      // StatisticsForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonClose;
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.GroupBoxBook);
      this.Controls.Add(this.GroupBoxTorah);
      this.Controls.Add(this.GroupBoxAllBooks);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "StatisticsForm";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.StatisticsForm_Load);
      this.GroupBoxAllBooks.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.GroupBoxTorah.ResumeLayout(false);
      this.GroupBoxBook.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
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
    private System.Windows.Forms.ComboBox SelectBook;
    private StatControl StatBook;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label LabelMiddleLetter;
    private System.Windows.Forms.Label LabelMiddleWord;
    private System.Windows.Forms.Label LabelMiddleReference;
    private System.Windows.Forms.LinkLabel LabelMiddleReferenceValue;
    private System.Windows.Forms.Label LabelMiddleLetterValue;
    private System.Windows.Forms.Label LabelMiddleWordValue;
  }
}