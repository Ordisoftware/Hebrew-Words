﻿namespace Ordisoftware.Hebrew.Words
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibleStatisticsForm));
      this.GroupBoxAllBooks = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ActionClose = new System.Windows.Forms.Button();
      this.GroupBoxTorah = new System.Windows.Forms.GroupBox();
      this.GroupBoxBook = new System.Windows.Forms.GroupBox();
      this.SelectBook = new System.Windows.Forms.ComboBox();
      this.GroupBoxMiddle = new System.Windows.Forms.GroupBox();
      this.LabelMiddleReferenceValue = new System.Windows.Forms.LinkLabel();
      this.ContextMenuStripWord = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionWordSearchDefault = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionWordSearchOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSearchWord = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenHebrewLetters2 = new System.Windows.Forms.ToolStripMenuItem();
      this.LabelMiddleLetter = new System.Windows.Forms.Label();
      this.LabelMiddleLetterValue = new System.Windows.Forms.Label();
      this.LabelMiddleWordValue = new System.Windows.Forms.Label();
      this.LabelMiddleWord = new System.Windows.Forms.Label();
      this.LabelMiddleReference = new System.Windows.Forms.Label();
      this.GroupBoxOccurencesTorah = new System.Windows.Forms.GroupBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.LabelLongestTorahReferenceValue = new System.Windows.Forms.LinkLabel();
      this.LabelLongestWordTorahValue = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.LabelLongestTorahWordReference = new System.Windows.Forms.Label();
      this.LabelLongestTanakReferenceValue = new System.Windows.Forms.LinkLabel();
      this.LabelLongestWordTanakValue = new System.Windows.Forms.Label();
      this.LabelLongestTanakWord = new System.Windows.Forms.Label();
      this.LabelLongestTorahWord = new System.Windows.Forms.Label();
      this.GroupBoxOccurencesAll = new System.Windows.Forms.GroupBox();
      this.LabelInfoOccurences = new System.Windows.Forms.Label();
      this.GroupBoxMostFrequentWordsTanak = new System.Windows.Forms.GroupBox();
      this.LabelInfoFrequent = new System.Windows.Forms.Label();
      this.GroupBoxMostFrequentWordsTorah = new System.Windows.Forms.GroupBox();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.TabPageWordsLength = new System.Windows.Forms.TabPage();
      this.GroupBoxWordslength = new System.Windows.Forms.GroupBox();
      this.LabelAverageWordLength = new System.Windows.Forms.Label();
      this.LabelCountWordsLengthMoreThan10 = new System.Windows.Forms.Label();
      this.LabelCountWordsLength1or2 = new System.Windows.Forms.Label();
      this.LabelCountWordsLength10 = new System.Windows.Forms.Label();
      this.LabelCountWordsLength3 = new System.Windows.Forms.Label();
      this.LabelCountWordsLength9 = new System.Windows.Forms.Label();
      this.LabelCountWordsLength4 = new System.Windows.Forms.Label();
      this.LabelCountWordsLength8 = new System.Windows.Forms.Label();
      this.LabelCountWordsLength5 = new System.Windows.Forms.Label();
      this.LabelCountWordsLength7 = new System.Windows.Forms.Label();
      this.LabelCountWordsLength6 = new System.Windows.Forms.Label();
      this.StatTorah = new Ordisoftware.Hebrew.Words.StatControl();
      this.StatBook = new Ordisoftware.Hebrew.Words.StatControl();
      this.StatAllBooks = new Ordisoftware.Hebrew.Words.StatControl();
      this.GroupBoxAllBooks.SuspendLayout();
      this.panel1.SuspendLayout();
      this.GroupBoxTorah.SuspendLayout();
      this.GroupBoxBook.SuspendLayout();
      this.GroupBoxMiddle.SuspendLayout();
      this.ContextMenuStripWord.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.TabPageWordsLength.SuspendLayout();
      this.GroupBoxWordslength.SuspendLayout();
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
      this.LabelMiddleReferenceValue.ContextMenuStrip = this.ContextMenuStripWord;
      this.LabelMiddleReferenceValue.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.LabelMiddleReferenceValue.LinkColor = System.Drawing.Color.Navy;
      this.LabelMiddleReferenceValue.Name = "LabelMiddleReferenceValue";
      this.LabelMiddleReferenceValue.TabStop = true;
      this.LabelMiddleReferenceValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelReferenceValue_LinkClicked);
      // 
      // ContextMenuStripWord
      // 
      this.ContextMenuStripWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionWordSearchDefault,
            this.ActionWordSearchOnline,
            this.toolStripSeparator10,
            this.ActionSearchWord,
            this.toolStripSeparator8,
            this.ActionOpenHebrewLetters2});
      this.ContextMenuStripWord.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStripWord, "ContextMenuStripWord");
      // 
      // ActionWordSearchDefault
      // 
      resources.ApplyResources(this.ActionWordSearchDefault, "ActionWordSearchDefault");
      this.ActionWordSearchDefault.Name = "ActionWordSearchDefault";
      this.ActionWordSearchDefault.Click += new System.EventHandler(this.ActionWordSearchDefault_Click);
      // 
      // ActionWordSearchOnline
      // 
      resources.ApplyResources(this.ActionWordSearchOnline, "ActionWordSearchOnline");
      this.ActionWordSearchOnline.Name = "ActionWordSearchOnline";
      // 
      // toolStripSeparator10
      // 
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
      // 
      // ActionSearchWord
      // 
      resources.ApplyResources(this.ActionSearchWord, "ActionSearchWord");
      this.ActionSearchWord.Name = "ActionSearchWord";
      this.ActionSearchWord.Click += new System.EventHandler(this.ActionSearchWord_Click);
      // 
      // toolStripSeparator8
      // 
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
      // 
      // ActionOpenHebrewLetters2
      // 
      resources.ApplyResources(this.ActionOpenHebrewLetters2, "ActionOpenHebrewLetters2");
      this.ActionOpenHebrewLetters2.Name = "ActionOpenHebrewLetters2";
      this.ActionOpenHebrewLetters2.Click += new System.EventHandler(this.ActionOpenHebrewLetters_Click);
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
      this.LabelMiddleLetterValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelHebrew_MouseClick);
      this.LabelMiddleLetterValue.MouseEnter += new System.EventHandler(this.LabelMiddleValue_MouseEnter);
      this.LabelMiddleLetterValue.MouseLeave += new System.EventHandler(this.LabelMiddleValue_MouseLeave);
      // 
      // LabelMiddleWordValue
      // 
      resources.ApplyResources(this.LabelMiddleWordValue, "LabelMiddleWordValue");
      this.LabelMiddleWordValue.Name = "LabelMiddleWordValue";
      this.LabelMiddleWordValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelHebrew_MouseClick);
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
      this.groupBox1.Controls.Add(this.LabelLongestTorahReferenceValue);
      this.groupBox1.Controls.Add(this.LabelLongestWordTorahValue);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.LabelLongestTorahWordReference);
      this.groupBox1.Controls.Add(this.LabelLongestTanakReferenceValue);
      this.groupBox1.Controls.Add(this.LabelLongestWordTanakValue);
      this.groupBox1.Controls.Add(this.LabelLongestTanakWord);
      this.groupBox1.Controls.Add(this.LabelLongestTorahWord);
      resources.ApplyResources(this.groupBox1, "groupBox1");
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      // 
      // LabelLongestTorahReferenceValue
      // 
      this.LabelLongestTorahReferenceValue.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      resources.ApplyResources(this.LabelLongestTorahReferenceValue, "LabelLongestTorahReferenceValue");
      this.LabelLongestTorahReferenceValue.ContextMenuStrip = this.ContextMenuStripWord;
      this.LabelLongestTorahReferenceValue.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.LabelLongestTorahReferenceValue.LinkColor = System.Drawing.Color.Navy;
      this.LabelLongestTorahReferenceValue.Name = "LabelLongestTorahReferenceValue";
      this.LabelLongestTorahReferenceValue.TabStop = true;
      this.LabelLongestTorahReferenceValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelReferenceValue_LinkClicked);
      // 
      // LabelLongestWordTorahValue
      // 
      resources.ApplyResources(this.LabelLongestWordTorahValue, "LabelLongestWordTorahValue");
      this.LabelLongestWordTorahValue.Name = "LabelLongestWordTorahValue";
      this.LabelLongestWordTorahValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelHebrew_MouseClick);
      this.LabelLongestWordTorahValue.MouseEnter += new System.EventHandler(this.LabelMiddleValue_MouseEnter);
      this.LabelLongestWordTorahValue.MouseLeave += new System.EventHandler(this.LabelMiddleValue_MouseLeave);
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // LabelLongestTorahWordReference
      // 
      resources.ApplyResources(this.LabelLongestTorahWordReference, "LabelLongestTorahWordReference");
      this.LabelLongestTorahWordReference.Name = "LabelLongestTorahWordReference";
      // 
      // LabelLongestTanakReferenceValue
      // 
      this.LabelLongestTanakReferenceValue.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      resources.ApplyResources(this.LabelLongestTanakReferenceValue, "LabelLongestTanakReferenceValue");
      this.LabelLongestTanakReferenceValue.ContextMenuStrip = this.ContextMenuStripWord;
      this.LabelLongestTanakReferenceValue.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.LabelLongestTanakReferenceValue.LinkColor = System.Drawing.Color.Navy;
      this.LabelLongestTanakReferenceValue.Name = "LabelLongestTanakReferenceValue";
      this.LabelLongestTanakReferenceValue.TabStop = true;
      this.LabelLongestTanakReferenceValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelReferenceValue_LinkClicked);
      // 
      // LabelLongestWordTanakValue
      // 
      resources.ApplyResources(this.LabelLongestWordTanakValue, "LabelLongestWordTanakValue");
      this.LabelLongestWordTanakValue.Name = "LabelLongestWordTanakValue";
      this.LabelLongestWordTanakValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelHebrew_MouseClick);
      this.LabelLongestWordTanakValue.MouseEnter += new System.EventHandler(this.LabelMiddleValue_MouseEnter);
      this.LabelLongestWordTanakValue.MouseLeave += new System.EventHandler(this.LabelMiddleValue_MouseLeave);
      // 
      // LabelLongestTanakWord
      // 
      resources.ApplyResources(this.LabelLongestTanakWord, "LabelLongestTanakWord");
      this.LabelLongestTanakWord.Name = "LabelLongestTanakWord";
      // 
      // LabelLongestTorahWord
      // 
      resources.ApplyResources(this.LabelLongestTorahWord, "LabelLongestTorahWord");
      this.LabelLongestTorahWord.Name = "LabelLongestTorahWord";
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
      // GroupBoxMostFrequentWordsTanak
      // 
      resources.ApplyResources(this.GroupBoxMostFrequentWordsTanak, "GroupBoxMostFrequentWordsTanak");
      this.GroupBoxMostFrequentWordsTanak.Name = "GroupBoxMostFrequentWordsTanak";
      this.GroupBoxMostFrequentWordsTanak.TabStop = false;
      // 
      // LabelInfoFrequent
      // 
      resources.ApplyResources(this.LabelInfoFrequent, "LabelInfoFrequent");
      this.LabelInfoFrequent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoFrequent.Name = "LabelInfoFrequent";
      // 
      // GroupBoxMostFrequentWordsTorah
      // 
      resources.ApplyResources(this.GroupBoxMostFrequentWordsTorah, "GroupBoxMostFrequentWordsTorah");
      this.GroupBoxMostFrequentWordsTorah.Name = "GroupBoxMostFrequentWordsTorah";
      this.GroupBoxMostFrequentWordsTorah.TabStop = false;
      // 
      // tabControl1
      // 
      resources.ApplyResources(this.tabControl1, "tabControl1");
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.TabPageWordsLength);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.GroupBoxMostFrequentWordsTorah);
      resources.ApplyResources(this.tabPage1, "tabPage1");
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.GroupBoxMostFrequentWordsTanak);
      resources.ApplyResources(this.tabPage2, "tabPage2");
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // TabPageWordsLength
      // 
      this.TabPageWordsLength.Controls.Add(this.GroupBoxWordslength);
      resources.ApplyResources(this.TabPageWordsLength, "TabPageWordsLength");
      this.TabPageWordsLength.Name = "TabPageWordsLength";
      this.TabPageWordsLength.UseVisualStyleBackColor = true;
      // 
      // GroupBoxWordslength
      // 
      this.GroupBoxWordslength.Controls.Add(this.LabelAverageWordLength);
      this.GroupBoxWordslength.Controls.Add(this.LabelCountWordsLengthMoreThan10);
      this.GroupBoxWordslength.Controls.Add(this.LabelCountWordsLength1or2);
      this.GroupBoxWordslength.Controls.Add(this.LabelCountWordsLength10);
      this.GroupBoxWordslength.Controls.Add(this.LabelCountWordsLength3);
      this.GroupBoxWordslength.Controls.Add(this.LabelCountWordsLength9);
      this.GroupBoxWordslength.Controls.Add(this.LabelCountWordsLength4);
      this.GroupBoxWordslength.Controls.Add(this.LabelCountWordsLength8);
      this.GroupBoxWordslength.Controls.Add(this.LabelCountWordsLength5);
      this.GroupBoxWordslength.Controls.Add(this.LabelCountWordsLength7);
      this.GroupBoxWordslength.Controls.Add(this.LabelCountWordsLength6);
      resources.ApplyResources(this.GroupBoxWordslength, "GroupBoxWordslength");
      this.GroupBoxWordslength.Name = "GroupBoxWordslength";
      this.GroupBoxWordslength.TabStop = false;
      // 
      // LabelAverageWordLength
      // 
      resources.ApplyResources(this.LabelAverageWordLength, "LabelAverageWordLength");
      this.LabelAverageWordLength.Name = "LabelAverageWordLength";
      // 
      // LabelCountWordsLengthMoreThan10
      // 
      resources.ApplyResources(this.LabelCountWordsLengthMoreThan10, "LabelCountWordsLengthMoreThan10");
      this.LabelCountWordsLengthMoreThan10.Name = "LabelCountWordsLengthMoreThan10";
      // 
      // LabelCountWordsLength1or2
      // 
      resources.ApplyResources(this.LabelCountWordsLength1or2, "LabelCountWordsLength1or2");
      this.LabelCountWordsLength1or2.Name = "LabelCountWordsLength1or2";
      // 
      // LabelCountWordsLength10
      // 
      resources.ApplyResources(this.LabelCountWordsLength10, "LabelCountWordsLength10");
      this.LabelCountWordsLength10.Name = "LabelCountWordsLength10";
      // 
      // LabelCountWordsLength3
      // 
      resources.ApplyResources(this.LabelCountWordsLength3, "LabelCountWordsLength3");
      this.LabelCountWordsLength3.Name = "LabelCountWordsLength3";
      // 
      // LabelCountWordsLength9
      // 
      resources.ApplyResources(this.LabelCountWordsLength9, "LabelCountWordsLength9");
      this.LabelCountWordsLength9.Name = "LabelCountWordsLength9";
      // 
      // LabelCountWordsLength4
      // 
      resources.ApplyResources(this.LabelCountWordsLength4, "LabelCountWordsLength4");
      this.LabelCountWordsLength4.Name = "LabelCountWordsLength4";
      // 
      // LabelCountWordsLength8
      // 
      resources.ApplyResources(this.LabelCountWordsLength8, "LabelCountWordsLength8");
      this.LabelCountWordsLength8.Name = "LabelCountWordsLength8";
      // 
      // LabelCountWordsLength5
      // 
      resources.ApplyResources(this.LabelCountWordsLength5, "LabelCountWordsLength5");
      this.LabelCountWordsLength5.Name = "LabelCountWordsLength5";
      // 
      // LabelCountWordsLength7
      // 
      resources.ApplyResources(this.LabelCountWordsLength7, "LabelCountWordsLength7");
      this.LabelCountWordsLength7.Name = "LabelCountWordsLength7";
      // 
      // LabelCountWordsLength6
      // 
      resources.ApplyResources(this.LabelCountWordsLength6, "LabelCountWordsLength6");
      this.LabelCountWordsLength6.Name = "LabelCountWordsLength6";
      // 
      // StatTorah
      // 
      resources.ApplyResources(this.StatTorah, "StatTorah");
      this.StatTorah.Name = "StatTorah";
      // 
      // StatBook
      // 
      resources.ApplyResources(this.StatBook, "StatBook");
      this.StatBook.Name = "StatBook";
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
      this.Controls.Add(this.GroupBoxOccurencesAll);
      this.Controls.Add(this.GroupBoxTorah);
      this.Controls.Add(this.GroupBoxOccurencesTorah);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.GroupBoxMiddle);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.LabelInfoFrequent);
      this.Controls.Add(this.LabelInfoOccurences);
      this.Controls.Add(this.GroupBoxBook);
      this.Controls.Add(this.GroupBoxAllBooks);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "BibleStatisticsForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BibleStatisticsForm_FormClosing);
      this.GroupBoxAllBooks.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.GroupBoxTorah.ResumeLayout(false);
      this.GroupBoxBook.ResumeLayout(false);
      this.GroupBoxMiddle.ResumeLayout(false);
      this.GroupBoxMiddle.PerformLayout();
      this.ContextMenuStripWord.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.TabPageWordsLength.ResumeLayout(false);
      this.GroupBoxWordslength.ResumeLayout(false);
      this.GroupBoxWordslength.PerformLayout();
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
    private System.Windows.Forms.LinkLabel LabelLongestTanakReferenceValue;
    private System.Windows.Forms.Label LabelLongestWordTanakValue;
    private System.Windows.Forms.Label LabelLongestTanakWord;
    private System.Windows.Forms.Label LabelLongestTorahWord;
    private GroupBox GroupBoxOccurencesAll;
    private Label LabelInfoOccurences;
    private GroupBox GroupBoxMostFrequentWordsTanak;
    private Label LabelInfoFrequent;
    private GroupBox GroupBoxMostFrequentWordsTorah;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    internal ContextMenuStrip ContextMenuStripWord;
    private ToolStripMenuItem ActionWordSearchDefault;
    private ToolStripMenuItem ActionWordSearchOnline;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripMenuItem ActionSearchWord;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripMenuItem ActionOpenHebrewLetters2;
    private LinkLabel LabelLongestTorahReferenceValue;
    private Label LabelLongestWordTorahValue;
    private Label label2;
    private Label LabelLongestTorahWordReference;
    private TabPage TabPageWordsLength;
    private Label LabelAverageWordLength;
    private Label LabelCountWordsLength1or2;
    private Label LabelCountWordsLength3;
    private Label LabelCountWordsLength5;
    private Label LabelCountWordsLength4;
    private Label LabelCountWordsLength8;
    private Label LabelCountWordsLength7;
    private Label LabelCountWordsLength6;
    private Label LabelCountWordsLength9;
    private Label LabelCountWordsLengthMoreThan10;
    private Label LabelCountWordsLength10;
    private GroupBox GroupBoxWordslength;
  }
}