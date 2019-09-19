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
      this.GroupBoxMiddle = new System.Windows.Forms.GroupBox();
      this.LabelMiddleReferenceValue = new System.Windows.Forms.LinkLabel();
      this.LabelMiddleLetter = new System.Windows.Forms.Label();
      this.LabelMiddleLetterValue = new System.Windows.Forms.Label();
      this.LabelMiddleWordValue = new System.Windows.Forms.Label();
      this.LabelMiddleWord = new System.Windows.Forms.Label();
      this.LabelMiddleReference = new System.Windows.Forms.Label();
      this.GroupBoxOccurences = new System.Windows.Forms.GroupBox();
      this.LabelCountTorahValue = new System.Windows.Forms.Label();
      this.LabelCountMitsvahValue = new System.Windows.Forms.Label();
      this.LabelCountMoshehValue = new System.Windows.Forms.Label();
      this.LabelCountYHVHValue = new System.Windows.Forms.Label();
      this.LabelCountElohimValue = new System.Windows.Forms.Label();
      this.LabelCountTorah = new System.Windows.Forms.Label();
      this.LabelCountMitsvah = new System.Windows.Forms.Label();
      this.LabelCountMosheh = new System.Windows.Forms.Label();
      this.LabelCountYHVH = new System.Windows.Forms.Label();
      this.LabelCountElohim = new System.Windows.Forms.Label();
      this.GroupBoxAllBooks.SuspendLayout();
      this.panel1.SuspendLayout();
      this.GroupBoxTorah.SuspendLayout();
      this.GroupBoxBook.SuspendLayout();
      this.GroupBoxMiddle.SuspendLayout();
      this.GroupBoxOccurences.SuspendLayout();
      this.SuspendLayout();
      // 
      // GroupBoxAllBooks
      // 
      resources.ApplyResources(this.GroupBoxAllBooks, "GroupBoxAllBooks");
      this.GroupBoxAllBooks.Controls.Add(this.StatAllBooks);
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
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.buttonClose);
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
      resources.ApplyResources(this.GroupBoxTorah, "GroupBoxTorah");
      this.GroupBoxTorah.Controls.Add(this.StatTorah);
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
      resources.ApplyResources(this.GroupBoxBook, "GroupBoxBook");
      this.GroupBoxBook.Controls.Add(this.SelectBook);
      this.GroupBoxBook.Controls.Add(this.StatBook);
      this.GroupBoxBook.Name = "GroupBoxBook";
      this.GroupBoxBook.TabStop = false;
      // 
      // SelectBook
      // 
      resources.ApplyResources(this.SelectBook, "SelectBook");
      this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectBook.FormattingEnabled = true;
      this.SelectBook.Name = "SelectBook";
      this.SelectBook.SelectedIndexChanged += new System.EventHandler(this.SelectBook_SelectedIndexChanged);
      // 
      // StatBook
      // 
      resources.ApplyResources(this.StatBook, "StatBook");
      this.StatBook.Name = "StatBook";
      // 
      // GroupBoxMiddle
      // 
      resources.ApplyResources(this.GroupBoxMiddle, "GroupBoxMiddle");
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleReferenceValue);
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleLetter);
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleLetterValue);
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleWordValue);
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleWord);
      this.GroupBoxMiddle.Controls.Add(this.LabelMiddleReference);
      this.GroupBoxMiddle.Name = "GroupBoxMiddle";
      this.GroupBoxMiddle.TabStop = false;
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
      // GroupBoxOccurences
      // 
      resources.ApplyResources(this.GroupBoxOccurences, "GroupBoxOccurences");
      this.GroupBoxOccurences.Controls.Add(this.LabelCountTorahValue);
      this.GroupBoxOccurences.Controls.Add(this.LabelCountMitsvahValue);
      this.GroupBoxOccurences.Controls.Add(this.LabelCountMoshehValue);
      this.GroupBoxOccurences.Controls.Add(this.LabelCountYHVHValue);
      this.GroupBoxOccurences.Controls.Add(this.LabelCountElohimValue);
      this.GroupBoxOccurences.Controls.Add(this.LabelCountTorah);
      this.GroupBoxOccurences.Controls.Add(this.LabelCountMitsvah);
      this.GroupBoxOccurences.Controls.Add(this.LabelCountMosheh);
      this.GroupBoxOccurences.Controls.Add(this.LabelCountYHVH);
      this.GroupBoxOccurences.Controls.Add(this.LabelCountElohim);
      this.GroupBoxOccurences.Name = "GroupBoxOccurences";
      this.GroupBoxOccurences.TabStop = false;
      // 
      // LabelCountTorahValue
      // 
      resources.ApplyResources(this.LabelCountTorahValue, "LabelCountTorahValue");
      this.LabelCountTorahValue.Name = "LabelCountTorahValue";
      // 
      // LabelCountMitsvahValue
      // 
      resources.ApplyResources(this.LabelCountMitsvahValue, "LabelCountMitsvahValue");
      this.LabelCountMitsvahValue.Name = "LabelCountMitsvahValue";
      // 
      // LabelCountMoshehValue
      // 
      resources.ApplyResources(this.LabelCountMoshehValue, "LabelCountMoshehValue");
      this.LabelCountMoshehValue.Name = "LabelCountMoshehValue";
      // 
      // LabelCountYHVHValue
      // 
      resources.ApplyResources(this.LabelCountYHVHValue, "LabelCountYHVHValue");
      this.LabelCountYHVHValue.Name = "LabelCountYHVHValue";
      // 
      // LabelCountElohimValue
      // 
      resources.ApplyResources(this.LabelCountElohimValue, "LabelCountElohimValue");
      this.LabelCountElohimValue.Name = "LabelCountElohimValue";
      // 
      // LabelCountTorah
      // 
      resources.ApplyResources(this.LabelCountTorah, "LabelCountTorah");
      this.LabelCountTorah.Name = "LabelCountTorah";
      // 
      // LabelCountMitsvah
      // 
      resources.ApplyResources(this.LabelCountMitsvah, "LabelCountMitsvah");
      this.LabelCountMitsvah.Name = "LabelCountMitsvah";
      // 
      // LabelCountMosheh
      // 
      resources.ApplyResources(this.LabelCountMosheh, "LabelCountMosheh");
      this.LabelCountMosheh.Name = "LabelCountMosheh";
      // 
      // LabelCountYHVH
      // 
      resources.ApplyResources(this.LabelCountYHVH, "LabelCountYHVH");
      this.LabelCountYHVH.Name = "LabelCountYHVH";
      // 
      // LabelCountElohim
      // 
      resources.ApplyResources(this.LabelCountElohim, "LabelCountElohim");
      this.LabelCountElohim.Name = "LabelCountElohim";
      // 
      // StatisticsForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonClose;
      this.Controls.Add(this.GroupBoxOccurences);
      this.Controls.Add(this.GroupBoxMiddle);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.GroupBoxBook);
      this.Controls.Add(this.GroupBoxTorah);
      this.Controls.Add(this.GroupBoxAllBooks);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "StatisticsForm";
      this.ShowInTaskbar = false;
      this.GroupBoxAllBooks.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.GroupBoxTorah.ResumeLayout(false);
      this.GroupBoxBook.ResumeLayout(false);
      this.GroupBoxMiddle.ResumeLayout(false);
      this.GroupBoxMiddle.PerformLayout();
      this.GroupBoxOccurences.ResumeLayout(false);
      this.GroupBoxOccurences.PerformLayout();
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
    private System.Windows.Forms.GroupBox GroupBoxMiddle;
    private System.Windows.Forms.Label LabelMiddleLetter;
    private System.Windows.Forms.Label LabelMiddleWord;
    private System.Windows.Forms.Label LabelMiddleReference;
    private System.Windows.Forms.LinkLabel LabelMiddleReferenceValue;
    private System.Windows.Forms.Label LabelMiddleLetterValue;
    private System.Windows.Forms.Label LabelMiddleWordValue;
    private System.Windows.Forms.GroupBox GroupBoxOccurences;
    private System.Windows.Forms.Label LabelCountYHVHValue;
    private System.Windows.Forms.Label LabelCountElohimValue;
    private System.Windows.Forms.Label LabelCountYHVH;
    private System.Windows.Forms.Label LabelCountElohim;
    private System.Windows.Forms.Label LabelCountTorahValue;
    private System.Windows.Forms.Label LabelCountTorah;
    private System.Windows.Forms.Label LabelCountMoshehValue;
    private System.Windows.Forms.Label LabelCountMosheh;
    private System.Windows.Forms.Label LabelCountMitsvahValue;
    private System.Windows.Forms.Label LabelCountMitsvah;
  }
}