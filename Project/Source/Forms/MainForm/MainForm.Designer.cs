namespace Ordisoftware.HebrewWords
{
  partial class MainForm
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && (components != null) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.PanelMain = new System.Windows.Forms.Panel();
      this.PanelMainOuter = new System.Windows.Forms.Panel();
      this.PanelMainInner = new System.Windows.Forms.Panel();
      this.PanelMainCenter = new System.Windows.Forms.Panel();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.TabPageVerses = new System.Windows.Forms.TabPage();
      this.PanelViewVerses = new System.Windows.Forms.Panel();
      this.TabPageTranslations = new System.Windows.Forms.TabPage();
      this.PanelViewTranslations = new System.Windows.Forms.Panel();
      this.EditTranslations = new System.Windows.Forms.RichTextBox();
      this.TabPageText = new System.Windows.Forms.TabPage();
      this.PanelViewRawText = new System.Windows.Forms.Panel();
      this.EditRawText = new System.Windows.Forms.RichTextBox();
      this.TabPageELS50 = new System.Windows.Forms.TabPage();
      this.PanelViewELS50 = new System.Windows.Forms.Panel();
      this.EditELS50All = new System.Windows.Forms.RichTextBox();
      this.TabPageSearch = new System.Windows.Forms.TabPage();
      this.PanelViewSearch = new System.Windows.Forms.Panel();
      this.PanelSearchResultsOuter = new System.Windows.Forms.Panel();
      this.PanelSearchResults = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.PanelSearchFilters = new System.Windows.Forms.Panel();
      this.PanelSearchFiltersRight = new System.Windows.Forms.Panel();
      this.ActionSearchInRemoveAll = new System.Windows.Forms.Button();
      this.ActionSearchInAddAll = new System.Windows.Forms.Button();
      this.SelectSearchInBook = new System.Windows.Forms.ComboBox();
      this.SelectSearchPaging = new System.Windows.Forms.TrackBar();
      this.EditSearchPaging = new System.Windows.Forms.TextBox();
      this.EditSearchInKetouvim = new System.Windows.Forms.CheckBox();
      this.EditSearchInNeviim = new System.Windows.Forms.CheckBox();
      this.EditSearchInTorah = new System.Windows.Forms.CheckBox();
      this.ActionSearchRun = new System.Windows.Forms.Button();
      this.ActionNavigateSearchFirst = new System.Windows.Forms.Button();
      this.ActionSearchNavigatePrevious = new System.Windows.Forms.Button();
      this.ActionSearchNavigateNext = new System.Windows.Forms.Button();
      this.ActionSearchNavigateLast = new System.Windows.Forms.Button();
      this.ActionSearchClear = new System.Windows.Forms.Button();
      this.SelectSearchType = new System.Windows.Forms.TabControl();
      this.SelectSearchTypeHebrew = new System.Windows.Forms.TabPage();
      this.PanelSearchTop = new System.Windows.Forms.Panel();
      this.EditLetters = new Ordisoftware.HebrewWords.LettersControl();
      this.SelectSearchTypeTranslation = new System.Windows.Forms.TabPage();
      this.label2 = new System.Windows.Forms.Label();
      this.EditSearchTranslation = new System.Windows.Forms.TextBox();
      this.SelectSearchTypeVerses = new System.Windows.Forms.TabPage();
      this.SelectSearchRequestAllUntranslated = new System.Windows.Forms.RadioButton();
      this.SelectSearchRequestAllPartiallyTranslated = new System.Windows.Forms.RadioButton();
      this.SelectSearchRequestAllFullyTranslated = new System.Windows.Forms.RadioButton();
      this.SelectSearchRequestAllTranslated = new System.Windows.Forms.RadioButton();
      this.PanelNavigation = new System.Windows.Forms.Panel();
      this.ActionELS50CopyToClipboard = new System.Windows.Forms.Button();
      this.ActionExportChapter = new System.Windows.Forms.Button();
      this.ActionExportBook = new System.Windows.Forms.Button();
      this.ActionSearchVerse = new System.Windows.Forms.Button();
      this.SelectBook = new System.Windows.Forms.ComboBox();
      this.EditELS50 = new System.Windows.Forms.TextBox();
      this.SelectChapter = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.LabelSelectBook = new System.Windows.Forms.Label();
      this.LabelSelectChapter = new System.Windows.Forms.Label();
      this.PanelSepTop = new System.Windows.Forms.Panel();
      this.PanelTitle = new System.Windows.Forms.Panel();
      this.LabelTitle = new System.Windows.Forms.Label();
      this.WordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.VersesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.ChaptersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.BooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DataSet = new Ordisoftware.HebrewWords.Data.DataSet();
      this.label1 = new System.Windows.Forms.Label();
      this.TimerTooltip = new System.Windows.Forms.Timer(this.components);
      this.ToolStrip = new System.Windows.Forms.ToolStrip();
      this.ActionViewVerses = new System.Windows.Forms.ToolStripButton();
      this.ActionExit = new System.Windows.Forms.ToolStripButton();
      this.Sep4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionHelp = new System.Windows.Forms.ToolStripButton();
      this.ActionAbout = new System.Windows.Forms.ToolStripButton();
      this.MenuWeb = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionWebHome = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionWebContact = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCreateGitHubIssue = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionWebCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenHebrewAlphabet = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenTanakMP3 = new System.Windows.Forms.ToolStripMenuItem();
      this.bibleFourmilabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bibleBiblehubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tanakOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.euangélionOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.quranCorpusqurancomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.dictionnaireHéritageDuSanscritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.anAkkadianDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Sep6 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionPreferences = new System.Windows.Forms.ToolStripButton();
      this.MenuSettings = new System.Windows.Forms.ToolStripDropDownButton();
      this.MenuitemScreenPosition = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenNone = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenTopLeft = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenTopRight = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenBottomLeft = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenBottomRight = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenCenter = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionResetWinSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.Sep7 = new System.Windows.Forms.ToolStripSeparator();
      this.EditShowTips = new System.Windows.Forms.ToolStripMenuItem();
      this.EditConfirmClosing = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionViewTranslations = new System.Windows.Forms.ToolStripButton();
      this.ActionViewRawText = new System.Windows.Forms.ToolStripButton();
      this.ActionViewELS50 = new System.Windows.Forms.ToolStripButton();
      this.ActionViewSearch = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionGoToReference = new System.Windows.Forms.ToolStripButton();
      this.ActionRefresh = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCloseWindows = new System.Windows.Forms.ToolStripButton();
      this.ActionCopyToClipboard = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuBookmarks = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionClearBookmarks = new System.Windows.Forms.ToolStripMenuItem();
      this.menusep = new System.Windows.Forms.ToolStripSeparator();
      this.MenuHistory = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuTools = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionViewBooksTranslation = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionViewStatistics = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionShowGrammarGuide = new System.Windows.Forms.ToolStripMenuItem();
      this.shorashonLexicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionStartHebrewLetters = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuDatabase = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionNew = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionRestore = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionBackup = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenBackupPath = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSave = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.booksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.SaveFileDialogMSWord = new System.Windows.Forms.SaveFileDialog();
      this.SaveFileDialogDB = new System.Windows.Forms.SaveFileDialog();
      this.OpenFileDialogDB = new System.Windows.Forms.OpenFileDialog();
      this.SaveFileDialogRTF = new System.Windows.Forms.SaveFileDialog();
      this.TimerAutoSave = new System.Windows.Forms.Timer(this.components);
      this.ContextMenuStripVerse = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionOpenVerseOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopyTranslation = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionExportVerse = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSetAsBookmarkMaster = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionAddToBookmarks = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionImportConsole = new System.Windows.Forms.ToolStripMenuItem();
      this.BooksTableAdapter = new Ordisoftware.HebrewWords.Data.DataSetTableAdapters.BooksTableAdapter();
      this.TableAdapterManager = new Ordisoftware.HebrewWords.Data.DataSetTableAdapters.TableAdapterManager();
      this.ChaptersTableAdapter = new Ordisoftware.HebrewWords.Data.DataSetTableAdapters.ChaptersTableAdapter();
      this.VersesTableAdapter = new Ordisoftware.HebrewWords.Data.DataSetTableAdapters.VersesTableAdapter();
      this.WordsTableAdapter = new Ordisoftware.HebrewWords.Data.DataSetTableAdapters.WordsTableAdapter();
      this.PanelMain.SuspendLayout();
      this.PanelMainOuter.SuspendLayout();
      this.PanelMainInner.SuspendLayout();
      this.PanelMainCenter.SuspendLayout();
      this.TabControl.SuspendLayout();
      this.TabPageVerses.SuspendLayout();
      this.TabPageTranslations.SuspendLayout();
      this.PanelViewTranslations.SuspendLayout();
      this.TabPageText.SuspendLayout();
      this.PanelViewRawText.SuspendLayout();
      this.TabPageELS50.SuspendLayout();
      this.PanelViewELS50.SuspendLayout();
      this.TabPageSearch.SuspendLayout();
      this.PanelViewSearch.SuspendLayout();
      this.PanelSearchResultsOuter.SuspendLayout();
      this.PanelSearchFilters.SuspendLayout();
      this.PanelSearchFiltersRight.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SelectSearchPaging)).BeginInit();
      this.SelectSearchType.SuspendLayout();
      this.SelectSearchTypeHebrew.SuspendLayout();
      this.PanelSearchTop.SuspendLayout();
      this.SelectSearchTypeTranslation.SuspendLayout();
      this.SelectSearchTypeVerses.SuspendLayout();
      this.PanelNavigation.SuspendLayout();
      this.PanelTitle.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.WordsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.VersesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChaptersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
      this.ToolStrip.SuspendLayout();
      this.ContextMenuStripVerse.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelMain
      // 
      resources.ApplyResources(this.PanelMain, "PanelMain");
      this.PanelMain.Controls.Add(this.PanelMainOuter);
      this.PanelMain.Controls.Add(this.PanelNavigation);
      this.PanelMain.Controls.Add(this.PanelSepTop);
      this.PanelMain.Controls.Add(this.PanelTitle);
      this.PanelMain.Name = "PanelMain";
      // 
      // PanelMainOuter
      // 
      resources.ApplyResources(this.PanelMainOuter, "PanelMainOuter");
      this.PanelMainOuter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.PanelMainOuter.Controls.Add(this.PanelMainInner);
      this.PanelMainOuter.Name = "PanelMainOuter";
      // 
      // PanelMainInner
      // 
      resources.ApplyResources(this.PanelMainInner, "PanelMainInner");
      this.PanelMainInner.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.PanelMainInner.Controls.Add(this.PanelMainCenter);
      this.PanelMainInner.Name = "PanelMainInner";
      // 
      // PanelMainCenter
      // 
      resources.ApplyResources(this.PanelMainCenter, "PanelMainCenter");
      this.PanelMainCenter.BackColor = System.Drawing.SystemColors.Control;
      this.PanelMainCenter.Controls.Add(this.TabControl);
      this.PanelMainCenter.Name = "PanelMainCenter";
      // 
      // TabControl
      // 
      resources.ApplyResources(this.TabControl, "TabControl");
      this.TabControl.Controls.Add(this.TabPageVerses);
      this.TabControl.Controls.Add(this.TabPageTranslations);
      this.TabControl.Controls.Add(this.TabPageText);
      this.TabControl.Controls.Add(this.TabPageELS50);
      this.TabControl.Controls.Add(this.TabPageSearch);
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      this.TabControl.TabStop = false;
      // 
      // TabPageVerses
      // 
      resources.ApplyResources(this.TabPageVerses, "TabPageVerses");
      this.TabPageVerses.Controls.Add(this.PanelViewVerses);
      this.TabPageVerses.Name = "TabPageVerses";
      this.TabPageVerses.UseVisualStyleBackColor = true;
      // 
      // PanelViewVerses
      // 
      resources.ApplyResources(this.PanelViewVerses, "PanelViewVerses");
      this.PanelViewVerses.BackColor = System.Drawing.SystemColors.Control;
      this.PanelViewVerses.Name = "PanelViewVerses";
      this.PanelViewVerses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelViewVerses_MouseClick);
      // 
      // TabPageTranslations
      // 
      resources.ApplyResources(this.TabPageTranslations, "TabPageTranslations");
      this.TabPageTranslations.Controls.Add(this.PanelViewTranslations);
      this.TabPageTranslations.Name = "TabPageTranslations";
      this.TabPageTranslations.UseVisualStyleBackColor = true;
      // 
      // PanelViewTranslations
      // 
      resources.ApplyResources(this.PanelViewTranslations, "PanelViewTranslations");
      this.PanelViewTranslations.BackColor = System.Drawing.SystemColors.Window;
      this.PanelViewTranslations.Controls.Add(this.EditTranslations);
      this.PanelViewTranslations.Name = "PanelViewTranslations";
      // 
      // EditTranslations
      // 
      resources.ApplyResources(this.EditTranslations, "EditTranslations");
      this.EditTranslations.BackColor = System.Drawing.SystemColors.Window;
      this.EditTranslations.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.EditTranslations.Name = "EditTranslations";
      this.EditTranslations.ReadOnly = true;
      // 
      // TabPageText
      // 
      resources.ApplyResources(this.TabPageText, "TabPageText");
      this.TabPageText.Controls.Add(this.PanelViewRawText);
      this.TabPageText.Name = "TabPageText";
      this.TabPageText.UseVisualStyleBackColor = true;
      // 
      // PanelViewRawText
      // 
      resources.ApplyResources(this.PanelViewRawText, "PanelViewRawText");
      this.PanelViewRawText.BackColor = System.Drawing.SystemColors.Window;
      this.PanelViewRawText.Controls.Add(this.EditRawText);
      this.PanelViewRawText.Name = "PanelViewRawText";
      // 
      // EditRawText
      // 
      resources.ApplyResources(this.EditRawText, "EditRawText");
      this.EditRawText.BackColor = System.Drawing.SystemColors.Window;
      this.EditRawText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.EditRawText.Name = "EditRawText";
      this.EditRawText.ReadOnly = true;
      // 
      // TabPageELS50
      // 
      resources.ApplyResources(this.TabPageELS50, "TabPageELS50");
      this.TabPageELS50.Controls.Add(this.PanelViewELS50);
      this.TabPageELS50.Name = "TabPageELS50";
      this.TabPageELS50.UseVisualStyleBackColor = true;
      // 
      // PanelViewELS50
      // 
      resources.ApplyResources(this.PanelViewELS50, "PanelViewELS50");
      this.PanelViewELS50.BackColor = System.Drawing.SystemColors.Window;
      this.PanelViewELS50.Controls.Add(this.EditELS50All);
      this.PanelViewELS50.Name = "PanelViewELS50";
      // 
      // EditELS50All
      // 
      resources.ApplyResources(this.EditELS50All, "EditELS50All");
      this.EditELS50All.BackColor = System.Drawing.SystemColors.Window;
      this.EditELS50All.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.EditELS50All.Name = "EditELS50All";
      this.EditELS50All.ReadOnly = true;
      // 
      // TabPageSearch
      // 
      resources.ApplyResources(this.TabPageSearch, "TabPageSearch");
      this.TabPageSearch.Controls.Add(this.PanelViewSearch);
      this.TabPageSearch.Name = "TabPageSearch";
      this.TabPageSearch.UseVisualStyleBackColor = true;
      // 
      // PanelViewSearch
      // 
      resources.ApplyResources(this.PanelViewSearch, "PanelViewSearch");
      this.PanelViewSearch.BackColor = System.Drawing.SystemColors.Control;
      this.PanelViewSearch.Controls.Add(this.PanelSearchResultsOuter);
      this.PanelViewSearch.Controls.Add(this.panel1);
      this.PanelViewSearch.Controls.Add(this.PanelSearchFilters);
      this.PanelViewSearch.Name = "PanelViewSearch";
      // 
      // PanelSearchResultsOuter
      // 
      resources.ApplyResources(this.PanelSearchResultsOuter, "PanelSearchResultsOuter");
      this.PanelSearchResultsOuter.BackColor = System.Drawing.SystemColors.Window;
      this.PanelSearchResultsOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PanelSearchResultsOuter.Controls.Add(this.PanelSearchResults);
      this.PanelSearchResultsOuter.Name = "PanelSearchResultsOuter";
      // 
      // PanelSearchResults
      // 
      resources.ApplyResources(this.PanelSearchResults, "PanelSearchResults");
      this.PanelSearchResults.BackColor = System.Drawing.SystemColors.Window;
      this.PanelSearchResults.Name = "PanelSearchResults";
      this.PanelSearchResults.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelSearchResults_MouseClick);
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // PanelSearchFilters
      // 
      resources.ApplyResources(this.PanelSearchFilters, "PanelSearchFilters");
      this.PanelSearchFilters.Controls.Add(this.PanelSearchFiltersRight);
      this.PanelSearchFilters.Controls.Add(this.SelectSearchType);
      this.PanelSearchFilters.Name = "PanelSearchFilters";
      // 
      // PanelSearchFiltersRight
      // 
      resources.ApplyResources(this.PanelSearchFiltersRight, "PanelSearchFiltersRight");
      this.PanelSearchFiltersRight.Controls.Add(this.ActionSearchInRemoveAll);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionSearchInAddAll);
      this.PanelSearchFiltersRight.Controls.Add(this.SelectSearchInBook);
      this.PanelSearchFiltersRight.Controls.Add(this.SelectSearchPaging);
      this.PanelSearchFiltersRight.Controls.Add(this.EditSearchPaging);
      this.PanelSearchFiltersRight.Controls.Add(this.EditSearchInKetouvim);
      this.PanelSearchFiltersRight.Controls.Add(this.EditSearchInNeviim);
      this.PanelSearchFiltersRight.Controls.Add(this.EditSearchInTorah);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionSearchRun);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionNavigateSearchFirst);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionSearchNavigatePrevious);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionSearchNavigateNext);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionSearchNavigateLast);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionSearchClear);
      this.PanelSearchFiltersRight.Name = "PanelSearchFiltersRight";
      // 
      // ActionSearchInRemoveAll
      // 
      resources.ApplyResources(this.ActionSearchInRemoveAll, "ActionSearchInRemoveAll");
      this.ActionSearchInRemoveAll.FlatAppearance.BorderSize = 0;
      this.ActionSearchInRemoveAll.ForeColor = System.Drawing.Color.DarkBlue;
      this.ActionSearchInRemoveAll.Name = "ActionSearchInRemoveAll";
      this.ActionSearchInRemoveAll.UseVisualStyleBackColor = true;
      this.ActionSearchInRemoveAll.Click += new System.EventHandler(this.ActionSearchInRemoveAll_Click);
      // 
      // ActionSearchInAddAll
      // 
      resources.ApplyResources(this.ActionSearchInAddAll, "ActionSearchInAddAll");
      this.ActionSearchInAddAll.FlatAppearance.BorderSize = 0;
      this.ActionSearchInAddAll.ForeColor = System.Drawing.Color.DarkBlue;
      this.ActionSearchInAddAll.Name = "ActionSearchInAddAll";
      this.ActionSearchInAddAll.UseVisualStyleBackColor = true;
      this.ActionSearchInAddAll.Click += new System.EventHandler(this.ActionSearchInAddAll_Click);
      // 
      // SelectSearchInBook
      // 
      resources.ApplyResources(this.SelectSearchInBook, "SelectSearchInBook");
      this.SelectSearchInBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectSearchInBook.FormattingEnabled = true;
      this.SelectSearchInBook.Name = "SelectSearchInBook";
      this.SelectSearchInBook.SelectedIndexChanged += new System.EventHandler(this.SelectSearchInBook_SelectedIndexChanged);
      // 
      // SelectSearchPaging
      // 
      resources.ApplyResources(this.SelectSearchPaging, "SelectSearchPaging");
      this.SelectSearchPaging.Maximum = 1;
      this.SelectSearchPaging.Minimum = 1;
      this.SelectSearchPaging.Name = "SelectSearchPaging";
      this.SelectSearchPaging.TickStyle = System.Windows.Forms.TickStyle.None;
      this.SelectSearchPaging.Value = 1;
      this.SelectSearchPaging.ValueChanged += new System.EventHandler(this.SelectSearchPaging_ValueChanged);
      this.SelectSearchPaging.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectSearchPaging_MouseDown);
      this.SelectSearchPaging.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectSearchPaging_MouseUp);
      // 
      // EditSearchPaging
      // 
      resources.ApplyResources(this.EditSearchPaging, "EditSearchPaging");
      this.EditSearchPaging.Name = "EditSearchPaging";
      this.EditSearchPaging.ReadOnly = true;
      // 
      // EditSearchInKetouvim
      // 
      resources.ApplyResources(this.EditSearchInKetouvim, "EditSearchInKetouvim");
      this.EditSearchInKetouvim.Checked = global::Ordisoftware.HebrewWords.Properties.Settings.Default.SearchInKetouvim;
      this.EditSearchInKetouvim.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "SearchInKetouvim", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSearchInKetouvim.Name = "EditSearchInKetouvim";
      this.EditSearchInKetouvim.UseVisualStyleBackColor = true;
      this.EditSearchInKetouvim.CheckedChanged += new System.EventHandler(this.EditSearchInSelectBook_CheckedChanged);
      // 
      // EditSearchInNeviim
      // 
      resources.ApplyResources(this.EditSearchInNeviim, "EditSearchInNeviim");
      this.EditSearchInNeviim.Checked = global::Ordisoftware.HebrewWords.Properties.Settings.Default.SearchInNeviim;
      this.EditSearchInNeviim.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "SearchInNeviim", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSearchInNeviim.Name = "EditSearchInNeviim";
      this.EditSearchInNeviim.UseVisualStyleBackColor = true;
      this.EditSearchInNeviim.CheckedChanged += new System.EventHandler(this.EditSearchInSelectBook_CheckedChanged);
      // 
      // EditSearchInTorah
      // 
      resources.ApplyResources(this.EditSearchInTorah, "EditSearchInTorah");
      this.EditSearchInTorah.Checked = global::Ordisoftware.HebrewWords.Properties.Settings.Default.SearchInTorah;
      this.EditSearchInTorah.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditSearchInTorah.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "SearchInTorah", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSearchInTorah.Name = "EditSearchInTorah";
      this.EditSearchInTorah.UseVisualStyleBackColor = true;
      this.EditSearchInTorah.CheckedChanged += new System.EventHandler(this.EditSearchInSelectBook_CheckedChanged);
      // 
      // ActionSearchRun
      // 
      resources.ApplyResources(this.ActionSearchRun, "ActionSearchRun");
      this.ActionSearchRun.FlatAppearance.BorderSize = 0;
      this.ActionSearchRun.Name = "ActionSearchRun";
      this.ActionSearchRun.UseVisualStyleBackColor = true;
      this.ActionSearchRun.Click += new System.EventHandler(this.ActionSearchWord_Click);
      // 
      // ActionNavigateSearchFirst
      // 
      resources.ApplyResources(this.ActionNavigateSearchFirst, "ActionNavigateSearchFirst");
      this.ActionNavigateSearchFirst.FlatAppearance.BorderSize = 0;
      this.ActionNavigateSearchFirst.Name = "ActionNavigateSearchFirst";
      this.ActionNavigateSearchFirst.UseVisualStyleBackColor = true;
      this.ActionNavigateSearchFirst.Click += new System.EventHandler(this.ActionSearchNavigateFirst_Click);
      // 
      // ActionSearchNavigatePrevious
      // 
      resources.ApplyResources(this.ActionSearchNavigatePrevious, "ActionSearchNavigatePrevious");
      this.ActionSearchNavigatePrevious.FlatAppearance.BorderSize = 0;
      this.ActionSearchNavigatePrevious.Name = "ActionSearchNavigatePrevious";
      this.ActionSearchNavigatePrevious.UseVisualStyleBackColor = true;
      this.ActionSearchNavigatePrevious.Click += new System.EventHandler(this.ActionSearchNavigatePrevious_Click);
      // 
      // ActionSearchNavigateNext
      // 
      resources.ApplyResources(this.ActionSearchNavigateNext, "ActionSearchNavigateNext");
      this.ActionSearchNavigateNext.FlatAppearance.BorderSize = 0;
      this.ActionSearchNavigateNext.Name = "ActionSearchNavigateNext";
      this.ActionSearchNavigateNext.UseVisualStyleBackColor = true;
      this.ActionSearchNavigateNext.Click += new System.EventHandler(this.ActionSearchNavigateNext_Click);
      // 
      // ActionSearchNavigateLast
      // 
      resources.ApplyResources(this.ActionSearchNavigateLast, "ActionSearchNavigateLast");
      this.ActionSearchNavigateLast.FlatAppearance.BorderSize = 0;
      this.ActionSearchNavigateLast.Name = "ActionSearchNavigateLast";
      this.ActionSearchNavigateLast.UseVisualStyleBackColor = true;
      this.ActionSearchNavigateLast.Click += new System.EventHandler(this.ActionSearchNavigateLast_Click);
      // 
      // ActionSearchClear
      // 
      resources.ApplyResources(this.ActionSearchClear, "ActionSearchClear");
      this.ActionSearchClear.FlatAppearance.BorderSize = 0;
      this.ActionSearchClear.Name = "ActionSearchClear";
      this.ActionSearchClear.UseVisualStyleBackColor = true;
      this.ActionSearchClear.Click += new System.EventHandler(this.ActionSearchClear_Click);
      // 
      // SelectSearchType
      // 
      resources.ApplyResources(this.SelectSearchType, "SelectSearchType");
      this.SelectSearchType.Controls.Add(this.SelectSearchTypeHebrew);
      this.SelectSearchType.Controls.Add(this.SelectSearchTypeTranslation);
      this.SelectSearchType.Controls.Add(this.SelectSearchTypeVerses);
      this.SelectSearchType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "CurrentSearchTypeTab", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectSearchType.Name = "SelectSearchType";
      this.SelectSearchType.SelectedIndex = global::Ordisoftware.HebrewWords.Properties.Settings.Default.CurrentSearchTypeTab;
      this.SelectSearchType.Selected += new System.Windows.Forms.TabControlEventHandler(this.SelectSearchType_Selected);
      // 
      // SelectSearchTypeHebrew
      // 
      resources.ApplyResources(this.SelectSearchTypeHebrew, "SelectSearchTypeHebrew");
      this.SelectSearchTypeHebrew.Controls.Add(this.PanelSearchTop);
      this.SelectSearchTypeHebrew.Name = "SelectSearchTypeHebrew";
      this.SelectSearchTypeHebrew.UseVisualStyleBackColor = true;
      // 
      // PanelSearchTop
      // 
      resources.ApplyResources(this.PanelSearchTop, "PanelSearchTop");
      this.PanelSearchTop.Controls.Add(this.EditLetters);
      this.PanelSearchTop.Name = "PanelSearchTop";
      // 
      // EditLetters
      // 
      resources.ApplyResources(this.EditLetters, "EditLetters");
      this.EditLetters.InputBackColor = System.Drawing.Color.AliceBlue;
      this.EditLetters.LettersBackground = System.Drawing.Color.LightYellow;
      this.EditLetters.Name = "EditLetters";
      this.EditLetters.InputTextChanged += new System.EventHandler(this.EditLetters_InputTextChanged);
      this.EditLetters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PanelLetterSearch_KeyPress);
      // 
      // SelectSearchTypeTranslation
      // 
      resources.ApplyResources(this.SelectSearchTypeTranslation, "SelectSearchTypeTranslation");
      this.SelectSearchTypeTranslation.Controls.Add(this.label2);
      this.SelectSearchTypeTranslation.Controls.Add(this.EditSearchTranslation);
      this.SelectSearchTypeTranslation.Name = "SelectSearchTypeTranslation";
      this.SelectSearchTypeTranslation.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // EditSearchTranslation
      // 
      resources.ApplyResources(this.EditSearchTranslation, "EditSearchTranslation");
      this.EditSearchTranslation.BackColor = System.Drawing.Color.AliceBlue;
      this.EditSearchTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditSearchTranslation.Name = "EditSearchTranslation";
      this.EditSearchTranslation.TextChanged += new System.EventHandler(this.EditSearchTranslation_TextChanged);
      this.EditSearchTranslation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PanelLetterSearch_KeyPress);
      // 
      // SelectSearchTypeVerses
      // 
      resources.ApplyResources(this.SelectSearchTypeVerses, "SelectSearchTypeVerses");
      this.SelectSearchTypeVerses.Controls.Add(this.SelectSearchRequestAllUntranslated);
      this.SelectSearchTypeVerses.Controls.Add(this.SelectSearchRequestAllPartiallyTranslated);
      this.SelectSearchTypeVerses.Controls.Add(this.SelectSearchRequestAllFullyTranslated);
      this.SelectSearchTypeVerses.Controls.Add(this.SelectSearchRequestAllTranslated);
      this.SelectSearchTypeVerses.Name = "SelectSearchTypeVerses";
      this.SelectSearchTypeVerses.UseVisualStyleBackColor = true;
      // 
      // SelectSearchRequestAllUntranslated
      // 
      resources.ApplyResources(this.SelectSearchRequestAllUntranslated, "SelectSearchRequestAllUntranslated");
      this.SelectSearchRequestAllUntranslated.Name = "SelectSearchRequestAllUntranslated";
      this.SelectSearchRequestAllUntranslated.UseVisualStyleBackColor = true;
      // 
      // SelectSearchRequestAllPartiallyTranslated
      // 
      resources.ApplyResources(this.SelectSearchRequestAllPartiallyTranslated, "SelectSearchRequestAllPartiallyTranslated");
      this.SelectSearchRequestAllPartiallyTranslated.Name = "SelectSearchRequestAllPartiallyTranslated";
      this.SelectSearchRequestAllPartiallyTranslated.UseVisualStyleBackColor = true;
      // 
      // SelectSearchRequestAllFullyTranslated
      // 
      resources.ApplyResources(this.SelectSearchRequestAllFullyTranslated, "SelectSearchRequestAllFullyTranslated");
      this.SelectSearchRequestAllFullyTranslated.Name = "SelectSearchRequestAllFullyTranslated";
      this.SelectSearchRequestAllFullyTranslated.UseVisualStyleBackColor = true;
      // 
      // SelectSearchRequestAllTranslated
      // 
      resources.ApplyResources(this.SelectSearchRequestAllTranslated, "SelectSearchRequestAllTranslated");
      this.SelectSearchRequestAllTranslated.Checked = true;
      this.SelectSearchRequestAllTranslated.Name = "SelectSearchRequestAllTranslated";
      this.SelectSearchRequestAllTranslated.TabStop = true;
      this.SelectSearchRequestAllTranslated.UseVisualStyleBackColor = true;
      // 
      // PanelNavigation
      // 
      resources.ApplyResources(this.PanelNavigation, "PanelNavigation");
      this.PanelNavigation.Controls.Add(this.ActionELS50CopyToClipboard);
      this.PanelNavigation.Controls.Add(this.ActionExportChapter);
      this.PanelNavigation.Controls.Add(this.ActionExportBook);
      this.PanelNavigation.Controls.Add(this.ActionSearchVerse);
      this.PanelNavigation.Controls.Add(this.SelectBook);
      this.PanelNavigation.Controls.Add(this.EditELS50);
      this.PanelNavigation.Controls.Add(this.SelectChapter);
      this.PanelNavigation.Controls.Add(this.label4);
      this.PanelNavigation.Controls.Add(this.LabelSelectBook);
      this.PanelNavigation.Controls.Add(this.LabelSelectChapter);
      this.PanelNavigation.Name = "PanelNavigation";
      // 
      // ActionELS50CopyToClipboard
      // 
      resources.ApplyResources(this.ActionELS50CopyToClipboard, "ActionELS50CopyToClipboard");
      this.ActionELS50CopyToClipboard.FlatAppearance.BorderSize = 0;
      this.ActionELS50CopyToClipboard.Name = "ActionELS50CopyToClipboard";
      this.ActionELS50CopyToClipboard.UseVisualStyleBackColor = true;
      this.ActionELS50CopyToClipboard.Click += new System.EventHandler(this.ActionELS50CopyToClipboard_Click);
      // 
      // ActionExportChapter
      // 
      resources.ApplyResources(this.ActionExportChapter, "ActionExportChapter");
      this.ActionExportChapter.FlatAppearance.BorderSize = 0;
      this.ActionExportChapter.Name = "ActionExportChapter";
      this.ActionExportChapter.UseVisualStyleBackColor = true;
      this.ActionExportChapter.Click += new System.EventHandler(this.ActionExportChapter_Click);
      // 
      // ActionExportBook
      // 
      resources.ApplyResources(this.ActionExportBook, "ActionExportBook");
      this.ActionExportBook.FlatAppearance.BorderSize = 0;
      this.ActionExportBook.Name = "ActionExportBook";
      this.ActionExportBook.UseVisualStyleBackColor = true;
      this.ActionExportBook.Click += new System.EventHandler(this.ActionExportBook_Click);
      // 
      // ActionSearchVerse
      // 
      resources.ApplyResources(this.ActionSearchVerse, "ActionSearchVerse");
      this.ActionSearchVerse.FlatAppearance.BorderSize = 0;
      this.ActionSearchVerse.Name = "ActionSearchVerse";
      this.ActionSearchVerse.UseVisualStyleBackColor = true;
      this.ActionSearchVerse.Click += new System.EventHandler(this.ActionSearchVerse_Click);
      // 
      // SelectBook
      // 
      resources.ApplyResources(this.SelectBook, "SelectBook");
      this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectBook.FormattingEnabled = true;
      this.SelectBook.Name = "SelectBook";
      this.SelectBook.SelectedIndexChanged += new System.EventHandler(this.SelectBook_SelectedIndexChanged);
      // 
      // EditELS50
      // 
      resources.ApplyResources(this.EditELS50, "EditELS50");
      this.EditELS50.BackColor = System.Drawing.Color.LightYellow;
      this.EditELS50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditELS50.Name = "EditELS50";
      this.EditELS50.ReadOnly = true;
      // 
      // SelectChapter
      // 
      resources.ApplyResources(this.SelectChapter, "SelectChapter");
      this.SelectChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectChapter.FormattingEnabled = true;
      this.SelectChapter.Name = "SelectChapter";
      this.SelectChapter.SelectedIndexChanged += new System.EventHandler(this.SelectChapter_SelectedIndexChanged);
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // LabelSelectBook
      // 
      resources.ApplyResources(this.LabelSelectBook, "LabelSelectBook");
      this.LabelSelectBook.Name = "LabelSelectBook";
      // 
      // LabelSelectChapter
      // 
      resources.ApplyResources(this.LabelSelectChapter, "LabelSelectChapter");
      this.LabelSelectChapter.Name = "LabelSelectChapter";
      // 
      // PanelSepTop
      // 
      resources.ApplyResources(this.PanelSepTop, "PanelSepTop");
      this.PanelSepTop.Name = "PanelSepTop";
      // 
      // PanelTitle
      // 
      resources.ApplyResources(this.PanelTitle, "PanelTitle");
      this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.PanelTitle.Controls.Add(this.LabelTitle);
      this.PanelTitle.Name = "PanelTitle";
      // 
      // LabelTitle
      // 
      resources.ApplyResources(this.LabelTitle, "LabelTitle");
      this.LabelTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.LabelTitle.Name = "LabelTitle";
      // 
      // WordsBindingSource
      // 
      this.WordsBindingSource.DataMember = "Verses_Words";
      this.WordsBindingSource.DataSource = this.VersesBindingSource;
      // 
      // VersesBindingSource
      // 
      this.VersesBindingSource.DataMember = "Chapters_Verses";
      this.VersesBindingSource.DataSource = this.ChaptersBindingSource;
      // 
      // ChaptersBindingSource
      // 
      this.ChaptersBindingSource.DataMember = "Books_Chapters";
      this.ChaptersBindingSource.DataSource = this.BooksBindingSource;
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
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // TimerTooltip
      // 
      this.TimerTooltip.Interval = 500;
      this.TimerTooltip.Tick += new System.EventHandler(this.TimerTooltip_Tick);
      // 
      // ToolStrip
      // 
      resources.ApplyResources(this.ToolStrip, "ToolStrip");
      this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.ToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
      this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionViewVerses,
            this.ActionExit,
            this.Sep4,
            this.ActionHelp,
            this.ActionAbout,
            this.MenuWeb,
            this.Sep6,
            this.ActionPreferences,
            this.MenuSettings,
            this.ActionViewTranslations,
            this.ActionViewRawText,
            this.ActionViewELS50,
            this.ActionViewSearch,
            this.toolStripSeparator4,
            this.ActionGoToReference,
            this.ActionRefresh,
            this.toolStripSeparator9,
            this.ActionCloseWindows,
            this.ActionCopyToClipboard,
            this.toolStripSeparator7,
            this.MenuBookmarks,
            this.MenuTools,
            this.MenuDatabase,
            this.toolStripSeparator1,
            this.ActionSave});
      this.ToolStrip.Name = "ToolStrip";
      this.ToolStrip.ShowItemToolTips = false;
      // 
      // ActionViewVerses
      // 
      resources.ApplyResources(this.ActionViewVerses, "ActionViewVerses");
      this.ActionViewVerses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionViewVerses.Name = "ActionViewVerses";
      this.ActionViewVerses.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewVerses.Click += new System.EventHandler(this.ActionViewVerses_Click);
      this.ActionViewVerses.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewVerses.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionExit
      // 
      resources.ApplyResources(this.ActionExit, "ActionExit");
      this.ActionExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionExit.Name = "ActionExit";
      this.ActionExit.Padding = new System.Windows.Forms.Padding(5);
      this.ActionExit.Click += new System.EventHandler(this.ActionExit_Click);
      this.ActionExit.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionExit.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // Sep4
      // 
      resources.ApplyResources(this.Sep4, "Sep4");
      this.Sep4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.Sep4.Name = "Sep4";
      // 
      // ActionHelp
      // 
      resources.ApplyResources(this.ActionHelp, "ActionHelp");
      this.ActionHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionHelp.Name = "ActionHelp";
      this.ActionHelp.Padding = new System.Windows.Forms.Padding(5);
      this.ActionHelp.Click += new System.EventHandler(this.ActionHelp_Click);
      this.ActionHelp.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionHelp.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionAbout
      // 
      resources.ApplyResources(this.ActionAbout, "ActionAbout");
      this.ActionAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionAbout.Name = "ActionAbout";
      this.ActionAbout.Padding = new System.Windows.Forms.Padding(5);
      this.ActionAbout.Click += new System.EventHandler(this.ActionAbout_Click);
      this.ActionAbout.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionAbout.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // MenuWeb
      // 
      resources.ApplyResources(this.MenuWeb, "MenuWeb");
      this.MenuWeb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.MenuWeb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuWeb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionWebHome,
            this.ActionWebContact,
            this.ActionCreateGitHubIssue,
            this.toolStripSeparator2,
            this.ActionWebCheckUpdate,
            this.toolStripMenuItem5,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6,
            this.toolStripSeparator10,
            this.ActionOpenHebrewAlphabet,
            this.toolStripSeparator8,
            this.ActionOpenTanakMP3,
            this.bibleFourmilabToolStripMenuItem,
            this.bibleBiblehubcomToolStripMenuItem,
            this.tanakOnlineToolStripMenuItem,
            this.euangélionOnlineToolStripMenuItem,
            this.quranCorpusqurancomToolStripMenuItem,
            this.toolStripSeparator3,
            this.dictionnaireHéritageDuSanscritToolStripMenuItem,
            this.anAkkadianDictionaryToolStripMenuItem});
      this.MenuWeb.Name = "MenuWeb";
      // 
      // ActionWebHome
      // 
      resources.ApplyResources(this.ActionWebHome, "ActionWebHome");
      this.ActionWebHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionWebHome.Name = "ActionWebHome";
      this.ActionWebHome.Click += new System.EventHandler(this.ActionWebHome_Click);
      // 
      // ActionWebContact
      // 
      resources.ApplyResources(this.ActionWebContact, "ActionWebContact");
      this.ActionWebContact.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionWebContact.Name = "ActionWebContact";
      this.ActionWebContact.Click += new System.EventHandler(this.ActionWebContact_Click);
      // 
      // ActionCreateGitHubIssue
      // 
      resources.ApplyResources(this.ActionCreateGitHubIssue, "ActionCreateGitHubIssue");
      this.ActionCreateGitHubIssue.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionCreateGitHubIssue.Name = "ActionCreateGitHubIssue";
      this.ActionCreateGitHubIssue.Tag = "";
      this.ActionCreateGitHubIssue.Click += new System.EventHandler(this.ActionCreateGitHubIssue_Click);
      // 
      // toolStripSeparator2
      // 
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      // 
      // ActionWebCheckUpdate
      // 
      resources.ApplyResources(this.ActionWebCheckUpdate, "ActionWebCheckUpdate");
      this.ActionWebCheckUpdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionWebCheckUpdate.Name = "ActionWebCheckUpdate";
      this.ActionWebCheckUpdate.Click += new System.EventHandler(this.ActionWebCheckUpdate_Click);
      // 
      // toolStripMenuItem5
      // 
      resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      // 
      // toolStripMenuItem7
      // 
      resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
      this.toolStripMenuItem7.Name = "toolStripMenuItem7";
      this.toolStripMenuItem7.Tag = "http://www.ordisoftware.com/projects/hebrew-letters";
      this.toolStripMenuItem7.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // toolStripMenuItem6
      // 
      resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Tag = "http://www.ordisoftware.com/projects/hebrew-calendar";
      this.toolStripMenuItem6.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // toolStripSeparator10
      // 
      resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      // 
      // ActionOpenHebrewAlphabet
      // 
      resources.ApplyResources(this.ActionOpenHebrewAlphabet, "ActionOpenHebrewAlphabet");
      this.ActionOpenHebrewAlphabet.Name = "ActionOpenHebrewAlphabet";
      this.ActionOpenHebrewAlphabet.Tag = "https://sites.google.com/site/asherhaimhalevi/hebrew-alphabet";
      this.ActionOpenHebrewAlphabet.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // toolStripSeparator8
      // 
      resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      // 
      // ActionOpenTanakMP3
      // 
      resources.ApplyResources(this.ActionOpenTanakMP3, "ActionOpenTanakMP3");
      this.ActionOpenTanakMP3.Name = "ActionOpenTanakMP3";
      this.ActionOpenTanakMP3.Tag = "https://www.mechon-mamre.org/p/pt/ptmp3prq.htm";
      this.ActionOpenTanakMP3.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // bibleFourmilabToolStripMenuItem
      // 
      resources.ApplyResources(this.bibleFourmilabToolStripMenuItem, "bibleFourmilabToolStripMenuItem");
      this.bibleFourmilabToolStripMenuItem.Name = "bibleFourmilabToolStripMenuItem";
      this.bibleFourmilabToolStripMenuItem.Tag = "http://www.fourmilab.ch/etexts/www/hebrew/Bible/";
      this.bibleFourmilabToolStripMenuItem.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // bibleBiblehubcomToolStripMenuItem
      // 
      resources.ApplyResources(this.bibleBiblehubcomToolStripMenuItem, "bibleBiblehubcomToolStripMenuItem");
      this.bibleBiblehubcomToolStripMenuItem.Name = "bibleBiblehubcomToolStripMenuItem";
      this.bibleBiblehubcomToolStripMenuItem.Tag = "https://biblehub.com/interlinear/";
      this.bibleBiblehubcomToolStripMenuItem.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // tanakOnlineToolStripMenuItem
      // 
      resources.ApplyResources(this.tanakOnlineToolStripMenuItem, "tanakOnlineToolStripMenuItem");
      this.tanakOnlineToolStripMenuItem.Name = "tanakOnlineToolStripMenuItem";
      this.tanakOnlineToolStripMenuItem.Tag = "https://studybible.info/IHOT/";
      this.tanakOnlineToolStripMenuItem.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // euangélionOnlineToolStripMenuItem
      // 
      resources.ApplyResources(this.euangélionOnlineToolStripMenuItem, "euangélionOnlineToolStripMenuItem");
      this.euangélionOnlineToolStripMenuItem.Name = "euangélionOnlineToolStripMenuItem";
      this.euangélionOnlineToolStripMenuItem.Tag = "https://studybible.info/IGNT";
      this.euangélionOnlineToolStripMenuItem.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // quranCorpusqurancomToolStripMenuItem
      // 
      resources.ApplyResources(this.quranCorpusqurancomToolStripMenuItem, "quranCorpusqurancomToolStripMenuItem");
      this.quranCorpusqurancomToolStripMenuItem.Name = "quranCorpusqurancomToolStripMenuItem";
      this.quranCorpusqurancomToolStripMenuItem.Tag = "http://corpus.quran.com/wordbyword.jsp";
      this.quranCorpusqurancomToolStripMenuItem.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // toolStripSeparator3
      // 
      resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      // 
      // dictionnaireHéritageDuSanscritToolStripMenuItem
      // 
      resources.ApplyResources(this.dictionnaireHéritageDuSanscritToolStripMenuItem, "dictionnaireHéritageDuSanscritToolStripMenuItem");
      this.dictionnaireHéritageDuSanscritToolStripMenuItem.Name = "dictionnaireHéritageDuSanscritToolStripMenuItem";
      this.dictionnaireHéritageDuSanscritToolStripMenuItem.Tag = "https://sanskrit.inria.fr/DICO/index.fr.html";
      this.dictionnaireHéritageDuSanscritToolStripMenuItem.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // anAkkadianDictionaryToolStripMenuItem
      // 
      resources.ApplyResources(this.anAkkadianDictionaryToolStripMenuItem, "anAkkadianDictionaryToolStripMenuItem");
      this.anAkkadianDictionaryToolStripMenuItem.Name = "anAkkadianDictionaryToolStripMenuItem";
      this.anAkkadianDictionaryToolStripMenuItem.Tag = "http://www.assyrianlanguages.org/akkadian/index_fr.php";
      this.anAkkadianDictionaryToolStripMenuItem.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // Sep6
      // 
      resources.ApplyResources(this.Sep6, "Sep6");
      this.Sep6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.Sep6.Name = "Sep6";
      // 
      // ActionPreferences
      // 
      resources.ApplyResources(this.ActionPreferences, "ActionPreferences");
      this.ActionPreferences.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionPreferences.Name = "ActionPreferences";
      this.ActionPreferences.Padding = new System.Windows.Forms.Padding(5);
      this.ActionPreferences.Click += new System.EventHandler(this.ActionPreferences_Click);
      this.ActionPreferences.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionPreferences.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // MenuSettings
      // 
      resources.ApplyResources(this.MenuSettings, "MenuSettings");
      this.MenuSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.MenuSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuitemScreenPosition,
            this.ActionResetWinSettings,
            this.Sep7,
            this.EditShowTips,
            this.EditConfirmClosing});
      this.MenuSettings.Name = "MenuSettings";
      // 
      // MenuitemScreenPosition
      // 
      resources.ApplyResources(this.MenuitemScreenPosition, "MenuitemScreenPosition");
      this.MenuitemScreenPosition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditScreenNone,
            this.EditScreenTopLeft,
            this.EditScreenTopRight,
            this.EditScreenBottomLeft,
            this.EditScreenBottomRight,
            this.EditScreenCenter});
      this.MenuitemScreenPosition.Name = "MenuitemScreenPosition";
      // 
      // EditScreenNone
      // 
      resources.ApplyResources(this.EditScreenNone, "EditScreenNone");
      this.EditScreenNone.CheckOnClick = true;
      this.EditScreenNone.Name = "EditScreenNone";
      this.EditScreenNone.Click += new System.EventHandler(this.SelectScreenPosition_Click);
      // 
      // EditScreenTopLeft
      // 
      resources.ApplyResources(this.EditScreenTopLeft, "EditScreenTopLeft");
      this.EditScreenTopLeft.CheckOnClick = true;
      this.EditScreenTopLeft.Name = "EditScreenTopLeft";
      this.EditScreenTopLeft.Click += new System.EventHandler(this.SelectScreenPosition_Click);
      // 
      // EditScreenTopRight
      // 
      resources.ApplyResources(this.EditScreenTopRight, "EditScreenTopRight");
      this.EditScreenTopRight.CheckOnClick = true;
      this.EditScreenTopRight.Name = "EditScreenTopRight";
      this.EditScreenTopRight.Click += new System.EventHandler(this.SelectScreenPosition_Click);
      // 
      // EditScreenBottomLeft
      // 
      resources.ApplyResources(this.EditScreenBottomLeft, "EditScreenBottomLeft");
      this.EditScreenBottomLeft.CheckOnClick = true;
      this.EditScreenBottomLeft.Name = "EditScreenBottomLeft";
      this.EditScreenBottomLeft.Click += new System.EventHandler(this.SelectScreenPosition_Click);
      // 
      // EditScreenBottomRight
      // 
      resources.ApplyResources(this.EditScreenBottomRight, "EditScreenBottomRight");
      this.EditScreenBottomRight.CheckOnClick = true;
      this.EditScreenBottomRight.Name = "EditScreenBottomRight";
      this.EditScreenBottomRight.Click += new System.EventHandler(this.SelectScreenPosition_Click);
      // 
      // EditScreenCenter
      // 
      resources.ApplyResources(this.EditScreenCenter, "EditScreenCenter");
      this.EditScreenCenter.CheckOnClick = true;
      this.EditScreenCenter.Name = "EditScreenCenter";
      this.EditScreenCenter.Click += new System.EventHandler(this.SelectScreenPosition_Click);
      // 
      // ActionResetWinSettings
      // 
      resources.ApplyResources(this.ActionResetWinSettings, "ActionResetWinSettings");
      this.ActionResetWinSettings.Name = "ActionResetWinSettings";
      this.ActionResetWinSettings.Click += new System.EventHandler(this.ActionResetWinSettings_Click);
      // 
      // Sep7
      // 
      resources.ApplyResources(this.Sep7, "Sep7");
      this.Sep7.Name = "Sep7";
      // 
      // EditShowTips
      // 
      resources.ApplyResources(this.EditShowTips, "EditShowTips");
      this.EditShowTips.Checked = true;
      this.EditShowTips.CheckOnClick = true;
      this.EditShowTips.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditShowTips.Name = "EditShowTips";
      // 
      // EditConfirmClosing
      // 
      resources.ApplyResources(this.EditConfirmClosing, "EditConfirmClosing");
      this.EditConfirmClosing.Checked = true;
      this.EditConfirmClosing.CheckOnClick = true;
      this.EditConfirmClosing.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditConfirmClosing.Name = "EditConfirmClosing";
      // 
      // ActionViewTranslations
      // 
      resources.ApplyResources(this.ActionViewTranslations, "ActionViewTranslations");
      this.ActionViewTranslations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionViewTranslations.Name = "ActionViewTranslations";
      this.ActionViewTranslations.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewTranslations.Click += new System.EventHandler(this.ActionViewTranslations_Click);
      this.ActionViewTranslations.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewTranslations.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionViewRawText
      // 
      resources.ApplyResources(this.ActionViewRawText, "ActionViewRawText");
      this.ActionViewRawText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionViewRawText.Name = "ActionViewRawText";
      this.ActionViewRawText.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewRawText.Click += new System.EventHandler(this.ActionViewRawText_Click);
      this.ActionViewRawText.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewRawText.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionViewELS50
      // 
      resources.ApplyResources(this.ActionViewELS50, "ActionViewELS50");
      this.ActionViewELS50.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionViewELS50.Name = "ActionViewELS50";
      this.ActionViewELS50.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewELS50.Click += new System.EventHandler(this.ActionViewELS50_Click);
      this.ActionViewELS50.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewELS50.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionViewSearch
      // 
      resources.ApplyResources(this.ActionViewSearch, "ActionViewSearch");
      this.ActionViewSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionViewSearch.Name = "ActionViewSearch";
      this.ActionViewSearch.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewSearch.Click += new System.EventHandler(this.ActionViewSearch_Click);
      this.ActionViewSearch.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewSearch.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // toolStripSeparator4
      // 
      resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      // 
      // ActionGoToReference
      // 
      resources.ApplyResources(this.ActionGoToReference, "ActionGoToReference");
      this.ActionGoToReference.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionGoToReference.Name = "ActionGoToReference";
      this.ActionGoToReference.Padding = new System.Windows.Forms.Padding(5);
      this.ActionGoToReference.Click += new System.EventHandler(this.ActionGoToVerse_Click);
      this.ActionGoToReference.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionGoToReference.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionRefresh
      // 
      resources.ApplyResources(this.ActionRefresh, "ActionRefresh");
      this.ActionRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionRefresh.Name = "ActionRefresh";
      this.ActionRefresh.Padding = new System.Windows.Forms.Padding(5);
      this.ActionRefresh.Click += new System.EventHandler(this.ActionRefresh_Click);
      this.ActionRefresh.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionRefresh.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // toolStripSeparator9
      // 
      resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      // 
      // ActionCloseWindows
      // 
      resources.ApplyResources(this.ActionCloseWindows, "ActionCloseWindows");
      this.ActionCloseWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionCloseWindows.Name = "ActionCloseWindows";
      this.ActionCloseWindows.Padding = new System.Windows.Forms.Padding(5);
      this.ActionCloseWindows.Click += new System.EventHandler(this.ActionCloseWindows_Click);
      this.ActionCloseWindows.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionCloseWindows.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionCopyToClipboard
      // 
      resources.ApplyResources(this.ActionCopyToClipboard, "ActionCopyToClipboard");
      this.ActionCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionCopyToClipboard.Name = "ActionCopyToClipboard";
      this.ActionCopyToClipboard.Padding = new System.Windows.Forms.Padding(5);
      this.ActionCopyToClipboard.Click += new System.EventHandler(this.ActionCopyToClipboard_Click);
      this.ActionCopyToClipboard.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionCopyToClipboard.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // toolStripSeparator7
      // 
      resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      // 
      // MenuBookmarks
      // 
      resources.ApplyResources(this.MenuBookmarks, "MenuBookmarks");
      this.MenuBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuBookmarks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionClearBookmarks,
            this.menusep,
            this.MenuHistory,
            this.toolStripMenuItem2});
      this.MenuBookmarks.Name = "MenuBookmarks";
      // 
      // ActionClearBookmarks
      // 
      resources.ApplyResources(this.ActionClearBookmarks, "ActionClearBookmarks");
      this.ActionClearBookmarks.Name = "ActionClearBookmarks";
      this.ActionClearBookmarks.Click += new System.EventHandler(this.ActionClearBookmarks_Click);
      // 
      // menusep
      // 
      resources.ApplyResources(this.menusep, "menusep");
      this.menusep.Name = "menusep";
      // 
      // MenuHistory
      // 
      resources.ApplyResources(this.MenuHistory, "MenuHistory");
      this.MenuHistory.Name = "MenuHistory";
      // 
      // toolStripMenuItem2
      // 
      resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      // 
      // MenuTools
      // 
      resources.ApplyResources(this.MenuTools, "MenuTools");
      this.MenuTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionViewBooksTranslation,
            this.ActionViewStatistics,
            this.toolStripSeparator6,
            this.ActionShowGrammarGuide,
            this.shorashonLexicalToolStripMenuItem,
            this.ActionStartHebrewLetters});
      this.MenuTools.Name = "MenuTools";
      // 
      // ActionViewBooksTranslation
      // 
      resources.ApplyResources(this.ActionViewBooksTranslation, "ActionViewBooksTranslation");
      this.ActionViewBooksTranslation.Name = "ActionViewBooksTranslation";
      this.ActionViewBooksTranslation.Click += new System.EventHandler(this.ActionViewBooksTranslation_Click);
      // 
      // ActionViewStatistics
      // 
      resources.ApplyResources(this.ActionViewStatistics, "ActionViewStatistics");
      this.ActionViewStatistics.Name = "ActionViewStatistics";
      this.ActionViewStatistics.Click += new System.EventHandler(this.ActionViewStatistics_Click);
      // 
      // toolStripSeparator6
      // 
      resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      // 
      // ActionShowGrammarGuide
      // 
      resources.ApplyResources(this.ActionShowGrammarGuide, "ActionShowGrammarGuide");
      this.ActionShowGrammarGuide.Name = "ActionShowGrammarGuide";
      this.ActionShowGrammarGuide.Click += new System.EventHandler(this.ActionShowGrammarGuide_Click);
      // 
      // shorashonLexicalToolStripMenuItem
      // 
      resources.ApplyResources(this.shorashonLexicalToolStripMenuItem, "shorashonLexicalToolStripMenuItem");
      this.shorashonLexicalToolStripMenuItem.Name = "shorashonLexicalToolStripMenuItem";
      this.shorashonLexicalToolStripMenuItem.Tag = "http://shorashon.free.fr/online/";
      this.shorashonLexicalToolStripMenuItem.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // ActionStartHebrewLetters
      // 
      resources.ApplyResources(this.ActionStartHebrewLetters, "ActionStartHebrewLetters");
      this.ActionStartHebrewLetters.Name = "ActionStartHebrewLetters";
      this.ActionStartHebrewLetters.Click += new System.EventHandler(this.ActionStartHebrewLetters_Click);
      // 
      // MenuDatabase
      // 
      resources.ApplyResources(this.MenuDatabase, "MenuDatabase");
      this.MenuDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionNew,
            this.ActionRestore,
            this.ActionBackup,
            this.toolStripSeparator5,
            this.ActionOpenBackupPath});
      this.MenuDatabase.Name = "MenuDatabase";
      // 
      // ActionNew
      // 
      resources.ApplyResources(this.ActionNew, "ActionNew");
      this.ActionNew.Name = "ActionNew";
      this.ActionNew.Click += new System.EventHandler(this.ActionNew_Click);
      // 
      // ActionRestore
      // 
      resources.ApplyResources(this.ActionRestore, "ActionRestore");
      this.ActionRestore.Name = "ActionRestore";
      this.ActionRestore.Click += new System.EventHandler(this.ActionRestore_Click);
      // 
      // ActionBackup
      // 
      resources.ApplyResources(this.ActionBackup, "ActionBackup");
      this.ActionBackup.Name = "ActionBackup";
      this.ActionBackup.Click += new System.EventHandler(this.ActionBackup_Click);
      // 
      // toolStripSeparator5
      // 
      resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      // 
      // ActionOpenBackupPath
      // 
      resources.ApplyResources(this.ActionOpenBackupPath, "ActionOpenBackupPath");
      this.ActionOpenBackupPath.Name = "ActionOpenBackupPath";
      this.ActionOpenBackupPath.Click += new System.EventHandler(this.ActionOpenBackupPath_Click);
      // 
      // toolStripSeparator1
      // 
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      // 
      // ActionSave
      // 
      resources.ApplyResources(this.ActionSave, "ActionSave");
      this.ActionSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionSave.Name = "ActionSave";
      this.ActionSave.Padding = new System.Windows.Forms.Padding(5);
      this.ActionSave.Click += new System.EventHandler(this.ActionSave_Click);
      this.ActionSave.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionSave.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // bindingNavigatorMoveFirstItem
      // 
      resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      // 
      // bindingNavigatorSeparator
      // 
      resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      // 
      // bindingNavigatorPositionItem
      // 
      resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      // 
      // bindingNavigatorCountItem
      // 
      resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      // 
      // bindingNavigatorSeparator1
      // 
      resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      // 
      // bindingNavigatorMoveNextItem
      // 
      resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      // 
      // bindingNavigatorMoveLastItem
      // 
      resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      // 
      // bindingNavigatorSeparator2
      // 
      resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      // 
      // bindingNavigatorAddNewItem
      // 
      resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      // 
      // bindingNavigatorDeleteItem
      // 
      resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      // 
      // booksBindingNavigatorSaveItem
      // 
      resources.ApplyResources(this.booksBindingNavigatorSaveItem, "booksBindingNavigatorSaveItem");
      this.booksBindingNavigatorSaveItem.Name = "booksBindingNavigatorSaveItem";
      // 
      // SaveFileDialogMSWord
      // 
      resources.ApplyResources(this.SaveFileDialogMSWord, "SaveFileDialogMSWord");
      // 
      // SaveFileDialogDB
      // 
      resources.ApplyResources(this.SaveFileDialogDB, "SaveFileDialogDB");
      // 
      // OpenFileDialogDB
      // 
      resources.ApplyResources(this.OpenFileDialogDB, "OpenFileDialogDB");
      // 
      // SaveFileDialogRTF
      // 
      resources.ApplyResources(this.SaveFileDialogRTF, "SaveFileDialogRTF");
      // 
      // TimerAutoSave
      // 
      this.TimerAutoSave.Tick += new System.EventHandler(this.TimerAutoSave_Tick);
      // 
      // ContextMenuStripVerse
      // 
      resources.ApplyResources(this.ContextMenuStripVerse, "ContextMenuStripVerse");
      this.ContextMenuStripVerse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionOpenVerseOnline,
            this.toolStripMenuItem1,
            this.ActionCopyTranslation,
            this.ActionExportVerse,
            this.toolStripMenuItem3,
            this.ActionSetAsBookmarkMaster,
            this.ActionAddToBookmarks,
            this.toolStripMenuItem4,
            this.ActionImportConsole});
      this.ContextMenuStripVerse.Name = "ContextMenuStrip";
      // 
      // ActionOpenVerseOnline
      // 
      resources.ApplyResources(this.ActionOpenVerseOnline, "ActionOpenVerseOnline");
      this.ActionOpenVerseOnline.Name = "ActionOpenVerseOnline";
      // 
      // toolStripMenuItem1
      // 
      resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      // 
      // ActionCopyTranslation
      // 
      resources.ApplyResources(this.ActionCopyTranslation, "ActionCopyTranslation");
      this.ActionCopyTranslation.Name = "ActionCopyTranslation";
      this.ActionCopyTranslation.Click += new System.EventHandler(this.ActionCopyTranslation_Click);
      // 
      // ActionExportVerse
      // 
      resources.ApplyResources(this.ActionExportVerse, "ActionExportVerse");
      this.ActionExportVerse.Name = "ActionExportVerse";
      this.ActionExportVerse.Click += new System.EventHandler(this.ActionExportVerse_Click);
      // 
      // toolStripMenuItem3
      // 
      resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      // 
      // ActionSetAsBookmarkMaster
      // 
      resources.ApplyResources(this.ActionSetAsBookmarkMaster, "ActionSetAsBookmarkMaster");
      this.ActionSetAsBookmarkMaster.Name = "ActionSetAsBookmarkMaster";
      this.ActionSetAsBookmarkMaster.Click += new System.EventHandler(this.ActionSetAsBookmarkMaster_Click);
      // 
      // ActionAddToBookmarks
      // 
      resources.ApplyResources(this.ActionAddToBookmarks, "ActionAddToBookmarks");
      this.ActionAddToBookmarks.Name = "ActionAddToBookmarks";
      this.ActionAddToBookmarks.Click += new System.EventHandler(this.ActionAddToBookmarks_Click);
      // 
      // toolStripMenuItem4
      // 
      resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      // 
      // ActionImportConsole
      // 
      resources.ApplyResources(this.ActionImportConsole, "ActionImportConsole");
      this.ActionImportConsole.Name = "ActionImportConsole";
      this.ActionImportConsole.Click += new System.EventHandler(this.ActionImportConsole_Click);
      // 
      // BooksTableAdapter
      // 
      this.BooksTableAdapter.ClearBeforeFill = true;
      // 
      // TableAdapterManager
      // 
      this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.TableAdapterManager.BooksTableAdapter = this.BooksTableAdapter;
      this.TableAdapterManager.ChaptersTableAdapter = this.ChaptersTableAdapter;
      this.TableAdapterManager.UpdateOrder = Ordisoftware.HebrewWords.Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      this.TableAdapterManager.VersesTableAdapter = this.VersesTableAdapter;
      this.TableAdapterManager.WordsTableAdapter = this.WordsTableAdapter;
      // 
      // ChaptersTableAdapter
      // 
      this.ChaptersTableAdapter.ClearBeforeFill = true;
      // 
      // VersesTableAdapter
      // 
      this.VersesTableAdapter.ClearBeforeFill = true;
      // 
      // WordsTableAdapter
      // 
      this.WordsTableAdapter.ClearBeforeFill = true;
      // 
      // MainForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.ToolStrip);
      this.Name = "MainForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.Shown += new System.EventHandler(this.MainForm_Shown);
      this.ClientSizeChanged += new System.EventHandler(this.MainForm_WindowsChanged);
      this.LocationChanged += new System.EventHandler(this.MainForm_WindowsChanged);
      this.PanelMain.ResumeLayout(false);
      this.PanelMainOuter.ResumeLayout(false);
      this.PanelMainInner.ResumeLayout(false);
      this.PanelMainCenter.ResumeLayout(false);
      this.TabControl.ResumeLayout(false);
      this.TabPageVerses.ResumeLayout(false);
      this.TabPageTranslations.ResumeLayout(false);
      this.PanelViewTranslations.ResumeLayout(false);
      this.TabPageText.ResumeLayout(false);
      this.PanelViewRawText.ResumeLayout(false);
      this.TabPageELS50.ResumeLayout(false);
      this.PanelViewELS50.ResumeLayout(false);
      this.TabPageSearch.ResumeLayout(false);
      this.PanelViewSearch.ResumeLayout(false);
      this.PanelSearchResultsOuter.ResumeLayout(false);
      this.PanelSearchFilters.ResumeLayout(false);
      this.PanelSearchFiltersRight.ResumeLayout(false);
      this.PanelSearchFiltersRight.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SelectSearchPaging)).EndInit();
      this.SelectSearchType.ResumeLayout(false);
      this.SelectSearchTypeHebrew.ResumeLayout(false);
      this.PanelSearchTop.ResumeLayout(false);
      this.SelectSearchTypeTranslation.ResumeLayout(false);
      this.SelectSearchTypeTranslation.PerformLayout();
      this.SelectSearchTypeVerses.ResumeLayout(false);
      this.SelectSearchTypeVerses.PerformLayout();
      this.PanelNavigation.ResumeLayout(false);
      this.PanelNavigation.PerformLayout();
      this.PanelTitle.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.WordsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.VersesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChaptersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
      this.ToolStrip.ResumeLayout(false);
      this.ToolStrip.PerformLayout();
      this.ContextMenuStripVerse.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStrip ToolStrip;
    private System.Windows.Forms.ToolStripButton ActionExit;
    private System.Windows.Forms.ToolStripButton ActionAbout;
    private System.Windows.Forms.ToolStripSeparator Sep4;
    private System.Windows.Forms.ToolStripDropDownButton MenuSettings;
    private System.Windows.Forms.ToolStripMenuItem MenuitemScreenPosition;
    private System.Windows.Forms.ToolStripButton ActionHelp;
    private System.Windows.Forms.ToolStripSeparator Sep7;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenNone;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenCenter;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenTopLeft;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenTopRight;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenBottomLeft;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenBottomRight;
    internal System.Windows.Forms.ToolStripMenuItem EditConfirmClosing;
    private System.Windows.Forms.ToolStripMenuItem ActionResetWinSettings;
    internal System.Windows.Forms.ToolStripMenuItem EditShowTips;
    private System.Windows.Forms.ToolStripSeparator Sep6;
    private System.Windows.Forms.Panel PanelMain;
    private System.Windows.Forms.Panel PanelSepTop;
    private System.Windows.Forms.Panel PanelTitle;
    private System.Windows.Forms.Label LabelTitle;
    private System.Windows.Forms.Panel PanelMainOuter;
    private System.Windows.Forms.Panel PanelMainInner;
    private System.Windows.Forms.Label label1;
    internal System.Windows.Forms.Panel PanelMainCenter;
    private System.Windows.Forms.Timer TimerTooltip;
    private System.Windows.Forms.TabControl TabControl;
    private System.Windows.Forms.TabPage TabPageVerses;
    private System.Windows.Forms.ToolStripButton ActionViewTranslations;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton booksBindingNavigatorSaveItem;
    private System.Windows.Forms.Label LabelSelectChapter;
    private System.Windows.Forms.Label LabelSelectBook;
    private System.Windows.Forms.TextBox EditELS50;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button ActionELS50CopyToClipboard;
    private System.Windows.Forms.ToolStripButton ActionViewVerses;
    private System.Windows.Forms.Panel PanelNavigation;
    private System.Windows.Forms.TabPage TabPageTranslations;
    private System.Windows.Forms.Panel PanelViewTranslations;
    private System.Windows.Forms.TabPage TabPageELS50;
    private System.Windows.Forms.Panel PanelViewELS50;
    private System.Windows.Forms.ToolStripButton ActionViewELS50;
    private System.Windows.Forms.ToolStripButton ActionViewRawText;
    private System.Windows.Forms.TabPage TabPageText;
    private System.Windows.Forms.Panel PanelViewRawText;
    private System.Windows.Forms.RichTextBox EditRawText;
    private System.Windows.Forms.RichTextBox EditELS50All;
    private System.Windows.Forms.RichTextBox EditTranslations;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    internal Data.DataSet DataSet;
    internal System.Windows.Forms.ToolStripButton ActionSave;
    private System.Windows.Forms.ToolStripButton ActionViewSearch;
    private System.Windows.Forms.ToolStripButton ActionPreferences;
    private System.Windows.Forms.TabPage TabPageSearch;
    private System.Windows.Forms.Panel PanelViewSearch;
    private System.Windows.Forms.Panel PanelSearchTop;
    private System.Windows.Forms.Button ActionSearchRun;
    private System.Windows.Forms.Button ActionSearchClear;
    private LettersControl EditLetters;
    private System.Windows.Forms.Panel PanelSearchResults;
    internal System.Windows.Forms.ComboBox SelectChapter;
    internal System.Windows.Forms.ComboBox SelectBook;
    private System.Windows.Forms.CheckBox EditSearchInTorah;
    private System.Windows.Forms.Button ActionSearchVerse;
    private System.Windows.Forms.Button ActionExportBook;
    private System.Windows.Forms.SaveFileDialog SaveFileDialogMSWord;
    private System.Windows.Forms.Button ActionExportChapter;
    private System.Windows.Forms.SaveFileDialog SaveFileDialogDB;
    private System.Windows.Forms.OpenFileDialog OpenFileDialogDB;
    private System.Windows.Forms.ToolStripButton ActionCopyToClipboard;
    private System.Windows.Forms.SaveFileDialog SaveFileDialogRTF;
    internal System.Windows.Forms.Timer TimerAutoSave;
    private System.Windows.Forms.ContextMenuStrip ContextMenuStripVerse;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenVerseOnline;
    private System.Windows.Forms.ToolStripMenuItem ActionExportVerse;
    private System.Windows.Forms.ToolStripDropDownButton MenuDatabase;
    private System.Windows.Forms.ToolStripDropDownButton MenuBookmarks;
    private System.Windows.Forms.ToolStripMenuItem ActionAddToBookmarks;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem ActionSetAsBookmarkMaster;
    private System.Windows.Forms.ToolStripMenuItem ActionClearBookmarks;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem ActionNew;
    private System.Windows.Forms.ToolStripMenuItem ActionRestore;
    private System.Windows.Forms.ToolStripMenuItem ActionBackup;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyTranslation;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    internal System.Windows.Forms.Panel PanelViewVerses;
    private System.Windows.Forms.ToolStripButton ActionRefresh;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem ActionImportConsole;
    private System.Windows.Forms.ToolStripSeparator menusep;
    private System.Windows.Forms.ToolStripMenuItem MenuHistory;
    private System.Windows.Forms.Panel PanelSearchFilters;
    private System.Windows.Forms.TabControl SelectSearchType;
    private System.Windows.Forms.TabPage SelectSearchTypeHebrew;
    private System.Windows.Forms.TabPage SelectSearchTypeTranslation;
    private System.Windows.Forms.Panel PanelSearchFiltersRight;
    public System.Windows.Forms.TextBox EditSearchTranslation;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ToolStripDropDownButton MenuTools;
    private System.Windows.Forms.ToolStripMenuItem ActionViewBooksTranslation;
    private System.Windows.Forms.ToolStripMenuItem ActionShowGrammarGuide;
    private System.Windows.Forms.ToolStripMenuItem ActionViewStatistics;
    private System.Windows.Forms.ToolStripDropDownButton MenuWeb;
    private System.Windows.Forms.ToolStripMenuItem ActionWebHome;
    private System.Windows.Forms.ToolStripMenuItem ActionWebCheckUpdate;
    private System.Windows.Forms.ToolStripMenuItem ActionWebContact;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenTanakMP3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem bibleFourmilabToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bibleBiblehubcomToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tanakOnlineToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem euangélionOnlineToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem quranCorpusqurancomToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dictionnaireHéritageDuSanscritToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem anAkkadianDictionaryToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.TabPage SelectSearchTypeVerses;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllUntranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllPartiallyTranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllFullyTranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllTranslated;
    private System.Windows.Forms.ToolStripMenuItem ActionCreateGitHubIssue;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenBackupPath;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    internal System.Windows.Forms.ToolStripButton ActionCloseWindows;
    private System.Windows.Forms.Button ActionNavigateSearchFirst;
    private System.Windows.Forms.Button ActionSearchNavigatePrevious;
    private System.Windows.Forms.Button ActionSearchNavigateNext;
    private System.Windows.Forms.Button ActionSearchNavigateLast;
    private System.Windows.Forms.TextBox EditSearchPaging;
    private System.Windows.Forms.TrackBar SelectSearchPaging;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripMenuItem ActionStartHebrewLetters;
    private System.Windows.Forms.ToolStripMenuItem shorashonLexicalToolStripMenuItem;
    private System.Windows.Forms.CheckBox EditSearchInKetouvim;
    private System.Windows.Forms.CheckBox EditSearchInNeviim;
    internal Data.DataSetTableAdapters.BooksTableAdapter BooksTableAdapter;
    internal Data.DataSetTableAdapters.TableAdapterManager TableAdapterManager;
    internal Data.DataSetTableAdapters.ChaptersTableAdapter ChaptersTableAdapter;
    internal Data.DataSetTableAdapters.VersesTableAdapter VersesTableAdapter;
    internal Data.DataSetTableAdapters.WordsTableAdapter WordsTableAdapter;
    internal System.Windows.Forms.BindingSource BooksBindingSource;
    internal System.Windows.Forms.BindingSource ChaptersBindingSource;
    internal System.Windows.Forms.BindingSource VersesBindingSource;
    internal System.Windows.Forms.BindingSource WordsBindingSource;
    private System.Windows.Forms.Panel PanelSearchResultsOuter;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenHebrewAlphabet;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripButton ActionGoToReference;
    private System.Windows.Forms.ComboBox SelectSearchInBook;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    private System.Windows.Forms.Button ActionSearchInRemoveAll;
    private System.Windows.Forms.Button ActionSearchInAddAll;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
  }
}

