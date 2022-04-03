namespace Ordisoftware.Hebrew.Words
{
  partial class BibleStatisticsForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibleStatisticsForm));
      this.GroupBoxAllBooks = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ActionClose = new System.Windows.Forms.Button();
      this.GroupBoxTorah = new System.Windows.Forms.GroupBox();
      this.GroupBoxBook = new System.Windows.Forms.GroupBox();
      this.SelectBook = new System.Windows.Forms.ComboBox();
      this.GroupBoxMiddle = new System.Windows.Forms.GroupBox();
      this.LabelMiddleReferenceValue = new System.Windows.Forms.LinkLabel();
      this.LabelMiddleLetter = new System.Windows.Forms.Label();
      this.LabelMiddleLetterValue = new System.Windows.Forms.Label();
      this.LabelMiddleWordValue = new System.Windows.Forms.Label();
      this.LabelMiddleWord = new System.Windows.Forms.Label();
      this.LabelMiddleReference = new System.Windows.Forms.Label();
      this.GroupBoxOccurencesTorah = new System.Windows.Forms.GroupBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.LabelLongestReferenceValue = new System.Windows.Forms.LinkLabel();
      this.LabelLongestWordValue = new System.Windows.Forms.Label();
      this.LabelLongestWord = new System.Windows.Forms.Label();
      this.LabelLongestWordReference = new System.Windows.Forms.Label();
      this.GroupBoxOccurencesAll = new System.Windows.Forms.GroupBox();
      this.LabelInfoOccurences = new System.Windows.Forms.Label();
      this.GroupBoxMostFrequentWords = new System.Windows.Forms.GroupBox();
      this.LabelInfoFrequent = new System.Windows.Forms.Label();
      this.StatBook = new Ordisoftware.Hebrew.Words.StatControl();
      this.StatTorah = new Ordisoftware.Hebrew.Words.StatControl();
      this.StatAllBooks = new Ordisoftware.Hebrew.Words.StatControl();
      this.GroupBoxAllBooks.SuspendLayout();
      this.panel1.SuspendLayout();
      this.GroupBoxTorah.SuspendLayout();
      this.GroupBoxBook.SuspendLayout();
      this.GroupBoxMiddle.SuspendLayout();
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
      // panel1
      // 
      this.panel1.Controls.Add(this.ActionClose);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // ActionClose
      // 
      resources.ApplyResources(this.ActionClose, "ActionClose");
      this.ActionClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ActionClose.Name = "ActionClose";
      this.ActionClose.Click += new System.EventHandler(this.ActionClose_Click);
      // 
      // GroupBoxTorah
      // 
      this.GroupBoxTorah.Controls.Add(this.StatTorah);
      resources.ApplyResources(this.GroupBoxTorah, "GroupBoxTorah");
      this.GroupBoxTorah.Name = "GroupBoxTorah";
      this.GroupBoxTorah.TabStop = false;
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
      // GroupBoxMiddle
      // 
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleReferenceValue);
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleLetter);
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleLetterValue);
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleWordValue);
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleWord);
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleReference);
      resources.ApplyResources(this.GroupBoxMiddle, "GroupBoxMiddle");
      this.GroupBoxMiddle.Name = "GroupBoxMiddle";
      this.GroupBoxMiddle.TabStop = false;
      // 
      // LabelMiddleReferenceValue
      // 
      this.LabelMiddleReferenceValue.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      resources.ApplyResources(this.LabelMiddleReferenceValue, "LabelMiddleReferenceValue");
      this.LabelMiddleReferenceValue.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.LabelMiddleReferenceValue.LinkColor = System.Drawing.Color.Navy;
      this.LabelMiddleReferenceValue.Name = "LabelMiddleReferenceValue";
      this.LabelMiddleReferenceValue.TabStop = true;
      this.LabelMiddleReferenceValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelReferenceValue_LinkClicked);
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
      // GroupBoxOccurencesTorah
      // 
      resources.ApplyResources(this.GroupBoxOccurencesTorah, "GroupBoxOccurencesTorah");
      this.GroupBoxOccurencesTorah.Name = "GroupBoxOccurencesTorah";
      this.GroupBoxOccurencesTorah.TabStop = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.LabelLongestReferenceValue);
      this.groupBox1.Controls.Add(this.LabelLongestWordValue);
      this.groupBox1.Controls.Add(this.LabelLongestWord);
      this.groupBox1.Controls.Add(this.LabelLongestWordReference);
      resources.ApplyResources(this.groupBox1, "groupBox1");
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      // 
      // LabelLongestReferenceValue
      // 
      this.LabelLongestReferenceValue.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      resources.ApplyResources(this.LabelLongestReferenceValue, "LabelLongestReferenceValue");
      this.LabelLongestReferenceValue.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.LabelLongestReferenceValue.LinkColor = System.Drawing.Color.Navy;
      this.LabelLongestReferenceValue.Name = "LabelLongestReferenceValue";
      this.LabelLongestReferenceValue.TabStop = true;
      this.LabelLongestReferenceValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelReferenceValue_LinkClicked);
      // 
      // LabelLongestWordValue
      // 
      resources.ApplyResources(this.LabelLongestWordValue, "LabelLongestWordValue");
      this.LabelLongestWordValue.Name = "LabelLongestWordValue";
      this.LabelLongestWordValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelMiddleValue_MouseClick);
      this.LabelLongestWordValue.MouseEnter += new System.EventHandler(this.LabelMiddleValue_MouseEnter);
      this.LabelLongestWordValue.MouseLeave += new System.EventHandler(this.LabelMiddleValue_MouseLeave);
      // 
      // LabelLongestWord
      // 
      resources.ApplyResources(this.LabelLongestWord, "LabelLongestWord");
      this.LabelLongestWord.Name = "LabelLongestWord";
      // 
      // LabelLongestWordReference
      // 
      resources.ApplyResources(this.LabelLongestWordReference, "LabelLongestWordReference");
      this.LabelLongestWordReference.Name = "LabelLongestWordReference";
      // 
      // GroupBoxOccurencesAll
      // 
      resources.ApplyResources(this.GroupBoxOccurencesAll, "GroupBoxOccurencesAll");
      this.GroupBoxOccurencesAll.Name = "GroupBoxOccurencesAll";
      this.GroupBoxOccurencesAll.TabStop = false;
      // 
      // LabelInfoOccurences
      // 
      resources.ApplyResources(this.LabelInfoOccurences, "LabelInfoOccurences");
      this.LabelInfoOccurences.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoOccurences.Name = "LabelInfoOccurences";
      // 
      // GroupBoxMostFrequentWords
      // 
      resources.ApplyResources(this.GroupBoxMostFrequentWords, "GroupBoxMostFrequentWords");
      this.GroupBoxMostFrequentWords.Name = "GroupBoxMostFrequentWords";
      this.GroupBoxMostFrequentWords.TabStop = false;
      // 
      // LabelInfoFrequent
      // 
      resources.ApplyResources(this.LabelInfoFrequent, "LabelInfoFrequent");
      this.LabelInfoFrequent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoFrequent.Name = "LabelInfoFrequent";
      // 
      // StatBook
      // 
      resources.ApplyResources(this.StatBook, "StatBook");
      this.StatBook.Name = "StatBook";
      // 
      // StatTorah
      // 
      resources.ApplyResources(this.StatTorah, "StatTorah");
      this.StatTorah.Name = "StatTorah";
      // 
      // StatAllBooks
      // 
      resources.ApplyResources(this.StatAllBooks, "StatAllBooks");
      this.StatAllBooks.Name = "StatAllBooks";
      // 
      // BibleStatisticsForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionClose;
      this.Controls.Add(this.GroupBoxMostFrequentWords);
      this.Controls.Add(this.GroupBoxOccurencesAll);
      this.Controls.Add(this.GroupBoxOccurencesTorah);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.GroupBoxMiddle);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.LabelInfoFrequent);
      this.Controls.Add(this.LabelInfoOccurences);
      this.Controls.Add(this.GroupBoxBook);
      this.Controls.Add(this.GroupBoxTorah);
      this.Controls.Add(this.GroupBoxAllBooks);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "BibleStatisticsForm";
      this.ShowInTaskbar = false;
      this.GroupBoxAllBooks.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.GroupBoxTorah.ResumeLayout(false);
      this.GroupBoxBook.ResumeLayout(false);
      this.GroupBoxMiddle.ResumeLayout(false);
      this.GroupBoxMiddle.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox GroupBoxAllBooks;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button ActionClose;
    private StatControl StatAllBooks;
    private System.Windows.Forms.GroupBox GroupBoxTorah;
    private StatControl StatTorah;
    private System.Windows.Forms.GroupBox GroupBoxBook;
    private System.Windows.Forms.ComboBox SelectBook;
    private StatControl StatBook;
    private System.Windows.Forms.GroupBox GroupBoxMiddle;
    private System.Windows.Forms.Label LabelMiddleLetter;
    private System.Windows.Forms.Label LabelMiddleWord;
    private System.Windows.Forms.Label LabelMiddleReference;
    private System.Windows.Forms.LinkLabel LabelMiddleReferenceValue;
    private System.Windows.Forms.Label LabelMiddleLetterValue;
    private System.Windows.Forms.Label LabelMiddleWordValue;
    private System.Windows.Forms.GroupBox GroupBoxOccurencesTorah;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.LinkLabel LabelLongestReferenceValue;
    private System.Windows.Forms.Label LabelLongestWordValue;
    private System.Windows.Forms.Label LabelLongestWord;
    private System.Windows.Forms.Label LabelLongestWordReference;
    private GroupBox GroupBoxOccurencesAll;
    private Label LabelInfoOccurences;
    private GroupBox GroupBoxMostFrequentWords;
    private Label LabelInfoFrequent;
  }
}