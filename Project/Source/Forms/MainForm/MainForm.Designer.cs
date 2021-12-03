namespace Ordisoftware.Hebrew.Words
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
      if ( disposing && ( components != null ) )
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
      this.PanelViewSearchSeparator = new System.Windows.Forms.Panel();
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
      this.EditLetters = new Ordisoftware.Hebrew.LettersControl();
      this.SelectSearchTypeTranslation = new System.Windows.Forms.TabPage();
      this.LabelSearchTranslationHelp = new System.Windows.Forms.Label();
      this.EditSearchTranslation = new Ordisoftware.Core.TextBoxEx();
      this.SelectSearchTypeVerses = new System.Windows.Forms.TabPage();
      this.SelectSearchRequestAllUntranslated = new System.Windows.Forms.RadioButton();
      this.SelectSearchRequestAllPartiallyTranslated = new System.Windows.Forms.RadioButton();
      this.SelectSearchRequestAllFullyTranslated = new System.Windows.Forms.RadioButton();
      this.SelectSearchRequestAllTranslated = new System.Windows.Forms.RadioButton();
      this.PanelNavigation = new System.Windows.Forms.Panel();
      this.EditChapterMemo = new Ordisoftware.Core.TextBoxEx();
      this.ChaptersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.BookRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.LabelChapterMemo = new System.Windows.Forms.Label();
      this.LabelBookTranslation = new System.Windows.Forms.Label();
      this.LabelChapterTitle = new System.Windows.Forms.Label();
      this.ActionEditBookMemo = new System.Windows.Forms.Button();
      this.ActionEditChapterMemo = new System.Windows.Forms.Button();
      this.ActionELS50CopyToClipboard = new System.Windows.Forms.Button();
      this.ActionExportChapter = new System.Windows.Forms.Button();
      this.ActionExportBook = new System.Windows.Forms.Button();
      this.ActionSearchVerse = new System.Windows.Forms.Button();
      this.SelectBook = new System.Windows.Forms.ComboBox();
      this.EditBookTranslation = new Ordisoftware.Core.TextBoxEx();
      this.EditChapterTitle = new Ordisoftware.Core.TextBoxEx();
      this.EditELS50 = new System.Windows.Forms.TextBox();
      this.SelectChapter = new System.Windows.Forms.ComboBox();
      this.LabelChapterELS50 = new System.Windows.Forms.Label();
      this.LabelSelectBook = new System.Windows.Forms.Label();
      this.LabelSelectChapter = new System.Windows.Forms.Label();
      this.PanelSepTop = new System.Windows.Forms.Panel();
      this.PanelTitle = new System.Windows.Forms.Panel();
      this.LabelProgress = new System.Windows.Forms.Label();
      this.LabelTitle = new System.Windows.Forms.Label();
      this.TimerTooltip = new System.Windows.Forms.Timer(this.components);
      this.ToolStrip = new System.Windows.Forms.ToolStrip();
      this.ActionViewVerses = new System.Windows.Forms.ToolStripButton();
      this.ActionExit = new System.Windows.Forms.ToolStripButton();
      this.Sep4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionPreferences = new System.Windows.Forms.ToolStripButton();
      this.ActionViewSearch = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionViewTranslations = new System.Windows.Forms.ToolStripButton();
      this.ActionViewRawText = new System.Windows.Forms.ToolStripButton();
      this.ActionViewELS50 = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionGoToReference = new System.Windows.Forms.ToolStripButton();
      this.ActionRefresh = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCloseWindows = new System.Windows.Forms.ToolStripButton();
      this.ActionCopyToClipboard = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuDatabase = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionNew = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionRestore = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionBackup = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionVacuum = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenBackupPath = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionOpenExportFolder = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSave = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuBookmarks = new System.Windows.Forms.ToolStripDropDownButton();
      this.MenuHistory = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionClearHistory = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSortBookmarks = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionAddBookmark = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionClearBookmarks = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionGoToBookmarkMain = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuTools = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionViewBooksTranslation = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionViewParashot = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionShowGrammarGuide = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenHebrewLetters = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionViewBibleStatistics = new System.Windows.Forms.ToolStripMenuItem();
      this.sYSTEMSTATSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionWebLinks = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionInformation = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionImportConcordances = new System.Windows.Forms.ToolStripButton();
      this.ActionSettings = new System.Windows.Forms.ToolStripDropDownButton();
      this.MenuitemScreenPosition = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenNone = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenTopLeft = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenTopRight = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenBottomLeft = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenBottomRight = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenCenter = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionResetWinSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.Sep7 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionShowKeyboardNotice = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
      this.EditShowTips = new System.Windows.Forms.ToolStripMenuItem();
      this.EditUseAdvancedDialogBoxes = new System.Windows.Forms.ToolStripMenuItem();
      this.EditSoundsEnabled = new System.Windows.Forms.ToolStripMenuItem();
      this.EditShowSuccessDialogs = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
      this.EditConfirmClosing = new System.Windows.Forms.ToolStripMenuItem();
      this.SaveFileDialogMSWord = new System.Windows.Forms.SaveFileDialog();
      this.SaveFileDialogDB = new System.Windows.Forms.SaveFileDialog();
      this.OpenFileDialogDB = new System.Windows.Forms.OpenFileDialog();
      this.SaveFileDialogRTF = new System.Windows.Forms.SaveFileDialog();
      this.TimerAutoSave = new System.Windows.Forms.Timer(this.components);
      this.ContextMenuStripVerse = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionVerseReadOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopyTranslation = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionExportVerse = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSetAsBookmarkMain = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionAddToBookmarks = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionImportConsole = new System.Windows.Forms.ToolStripMenuItem();
      this.ContextMenuStripWord = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionWordSearchOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSearchTranslated = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSearchWord = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionShowGrammarGuide2 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenHebrewLetters2 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCountOccurences = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCountRootOccurences = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopyFontChars = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyUnicodeChars = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionCopyWordTranslation = new System.Windows.Forms.ToolStripMenuItem();
      this.WordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.VersesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
      ((System.ComponentModel.ISupportInitialize)(this.ChaptersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BookRowBindingSource)).BeginInit();
      this.PanelTitle.SuspendLayout();
      this.ToolStrip.SuspendLayout();
      this.ContextMenuStripVerse.SuspendLayout();
      this.ContextMenuStripWord.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.WordsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.VersesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // PanelMain
      // 
      this.PanelMain.Controls.Add(this.PanelMainOuter);
      this.PanelMain.Controls.Add(this.PanelNavigation);
      this.PanelMain.Controls.Add(this.PanelSepTop);
      this.PanelMain.Controls.Add(this.PanelTitle);
      resources.ApplyResources(this.PanelMain, "PanelMain");
      this.PanelMain.Name = "PanelMain";
      // 
      // PanelMainOuter
      // 
      this.PanelMainOuter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.PanelMainOuter.Controls.Add(this.PanelMainInner);
      resources.ApplyResources(this.PanelMainOuter, "PanelMainOuter");
      this.PanelMainOuter.Name = "PanelMainOuter";
      // 
      // PanelMainInner
      // 
      this.PanelMainInner.BackColor = System.Drawing.SystemColors.Control;
      this.PanelMainInner.Controls.Add(this.PanelMainCenter);
      resources.ApplyResources(this.PanelMainInner, "PanelMainInner");
      this.PanelMainInner.Name = "PanelMainInner";
      // 
      // PanelMainCenter
      // 
      this.PanelMainCenter.BackColor = System.Drawing.SystemColors.Control;
      this.PanelMainCenter.Controls.Add(this.TabControl);
      resources.ApplyResources(this.PanelMainCenter, "PanelMainCenter");
      this.PanelMainCenter.Name = "PanelMainCenter";
      // 
      // TabControl
      // 
      this.TabControl.Controls.Add(this.TabPageVerses);
      this.TabControl.Controls.Add(this.TabPageTranslations);
      this.TabControl.Controls.Add(this.TabPageText);
      this.TabControl.Controls.Add(this.TabPageELS50);
      this.TabControl.Controls.Add(this.TabPageSearch);
      resources.ApplyResources(this.TabControl, "TabControl");
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      this.TabControl.TabStop = false;
      // 
      // TabPageVerses
      // 
      this.TabPageVerses.Controls.Add(this.PanelViewVerses);
      resources.ApplyResources(this.TabPageVerses, "TabPageVerses");
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
      this.TabPageTranslations.Controls.Add(this.PanelViewTranslations);
      resources.ApplyResources(this.TabPageTranslations, "TabPageTranslations");
      this.TabPageTranslations.Name = "TabPageTranslations";
      this.TabPageTranslations.UseVisualStyleBackColor = true;
      // 
      // PanelViewTranslations
      // 
      this.PanelViewTranslations.BackColor = System.Drawing.SystemColors.Window;
      this.PanelViewTranslations.Controls.Add(this.EditTranslations);
      resources.ApplyResources(this.PanelViewTranslations, "PanelViewTranslations");
      this.PanelViewTranslations.Name = "PanelViewTranslations";
      // 
      // EditTranslations
      // 
      this.EditTranslations.BackColor = System.Drawing.SystemColors.Window;
      this.EditTranslations.BorderStyle = System.Windows.Forms.BorderStyle.None;
      resources.ApplyResources(this.EditTranslations, "EditTranslations");
      this.EditTranslations.Name = "EditTranslations";
      this.EditTranslations.ReadOnly = true;
      // 
      // TabPageText
      // 
      this.TabPageText.Controls.Add(this.PanelViewRawText);
      resources.ApplyResources(this.TabPageText, "TabPageText");
      this.TabPageText.Name = "TabPageText";
      this.TabPageText.UseVisualStyleBackColor = true;
      // 
      // PanelViewRawText
      // 
      this.PanelViewRawText.BackColor = System.Drawing.SystemColors.Window;
      this.PanelViewRawText.Controls.Add(this.EditRawText);
      resources.ApplyResources(this.PanelViewRawText, "PanelViewRawText");
      this.PanelViewRawText.Name = "PanelViewRawText";
      // 
      // EditRawText
      // 
      this.EditRawText.BackColor = System.Drawing.SystemColors.Window;
      this.EditRawText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      resources.ApplyResources(this.EditRawText, "EditRawText");
      this.EditRawText.Name = "EditRawText";
      this.EditRawText.ReadOnly = true;
      // 
      // TabPageELS50
      // 
      this.TabPageELS50.Controls.Add(this.PanelViewELS50);
      resources.ApplyResources(this.TabPageELS50, "TabPageELS50");
      this.TabPageELS50.Name = "TabPageELS50";
      this.TabPageELS50.UseVisualStyleBackColor = true;
      // 
      // PanelViewELS50
      // 
      this.PanelViewELS50.BackColor = System.Drawing.SystemColors.Window;
      this.PanelViewELS50.Controls.Add(this.EditELS50All);
      resources.ApplyResources(this.PanelViewELS50, "PanelViewELS50");
      this.PanelViewELS50.Name = "PanelViewELS50";
      // 
      // EditELS50All
      // 
      this.EditELS50All.BackColor = System.Drawing.SystemColors.Window;
      this.EditELS50All.BorderStyle = System.Windows.Forms.BorderStyle.None;
      resources.ApplyResources(this.EditELS50All, "EditELS50All");
      this.EditELS50All.Name = "EditELS50All";
      this.EditELS50All.ReadOnly = true;
      // 
      // TabPageSearch
      // 
      this.TabPageSearch.Controls.Add(this.PanelViewSearch);
      resources.ApplyResources(this.TabPageSearch, "TabPageSearch");
      this.TabPageSearch.Name = "TabPageSearch";
      this.TabPageSearch.UseVisualStyleBackColor = true;
      // 
      // PanelViewSearch
      // 
      this.PanelViewSearch.BackColor = System.Drawing.SystemColors.Control;
      this.PanelViewSearch.Controls.Add(this.PanelSearchResultsOuter);
      this.PanelViewSearch.Controls.Add(this.PanelViewSearchSeparator);
      this.PanelViewSearch.Controls.Add(this.PanelSearchFilters);
      resources.ApplyResources(this.PanelViewSearch, "PanelViewSearch");
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
      // PanelViewSearchSeparator
      // 
      resources.ApplyResources(this.PanelViewSearchSeparator, "PanelViewSearchSeparator");
      this.PanelViewSearchSeparator.Name = "PanelViewSearchSeparator";
      // 
      // PanelSearchFilters
      // 
      this.PanelSearchFilters.Controls.Add(this.PanelSearchFiltersRight);
      this.PanelSearchFilters.Controls.Add(this.SelectSearchType);
      resources.ApplyResources(this.PanelSearchFilters, "PanelSearchFilters");
      this.PanelSearchFilters.Name = "PanelSearchFilters";
      // 
      // PanelSearchFiltersRight
      // 
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
      resources.ApplyResources(this.PanelSearchFiltersRight, "PanelSearchFiltersRight");
      this.PanelSearchFiltersRight.Name = "PanelSearchFiltersRight";
      // 
      // ActionSearchInRemoveAll
      // 
      this.ActionSearchInRemoveAll.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionSearchInRemoveAll, "ActionSearchInRemoveAll");
      this.ActionSearchInRemoveAll.ForeColor = System.Drawing.Color.DarkBlue;
      this.ActionSearchInRemoveAll.Name = "ActionSearchInRemoveAll";
      this.ActionSearchInRemoveAll.UseVisualStyleBackColor = true;
      this.ActionSearchInRemoveAll.Click += new System.EventHandler(this.ActionSearchInRemoveAll_Click);
      // 
      // ActionSearchInAddAll
      // 
      this.ActionSearchInAddAll.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionSearchInAddAll, "ActionSearchInAddAll");
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
      this.EditSearchPaging.TabStop = false;
      // 
      // EditSearchInKetouvim
      // 
      resources.ApplyResources(this.EditSearchInKetouvim, "EditSearchInKetouvim");
      this.EditSearchInKetouvim.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SearchInKetouvim;
      this.EditSearchInKetouvim.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SearchInKetouvim", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSearchInKetouvim.Name = "EditSearchInKetouvim";
      this.EditSearchInKetouvim.UseVisualStyleBackColor = true;
      this.EditSearchInKetouvim.CheckedChanged += new System.EventHandler(this.EditSearchInSelectBook_CheckedChanged);
      // 
      // EditSearchInNeviim
      // 
      resources.ApplyResources(this.EditSearchInNeviim, "EditSearchInNeviim");
      this.EditSearchInNeviim.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SearchInNeviim;
      this.EditSearchInNeviim.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SearchInNeviim", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSearchInNeviim.Name = "EditSearchInNeviim";
      this.EditSearchInNeviim.UseVisualStyleBackColor = true;
      this.EditSearchInNeviim.CheckedChanged += new System.EventHandler(this.EditSearchInSelectBook_CheckedChanged);
      // 
      // EditSearchInTorah
      // 
      resources.ApplyResources(this.EditSearchInTorah, "EditSearchInTorah");
      this.EditSearchInTorah.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.SearchInTorah;
      this.EditSearchInTorah.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditSearchInTorah.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "SearchInTorah", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
      this.SelectSearchType.Controls.Add(this.SelectSearchTypeHebrew);
      this.SelectSearchType.Controls.Add(this.SelectSearchTypeTranslation);
      this.SelectSearchType.Controls.Add(this.SelectSearchTypeVerses);
      this.SelectSearchType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "CurrentSearchTypeTab", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      resources.ApplyResources(this.SelectSearchType, "SelectSearchType");
      this.SelectSearchType.Name = "SelectSearchType";
      this.SelectSearchType.SelectedIndex = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.CurrentSearchTypeTab;
      this.SelectSearchType.Selected += new System.Windows.Forms.TabControlEventHandler(this.SelectSearchType_Selected);
      // 
      // SelectSearchTypeHebrew
      // 
      this.SelectSearchTypeHebrew.Controls.Add(this.PanelSearchTop);
      resources.ApplyResources(this.SelectSearchTypeHebrew, "SelectSearchTypeHebrew");
      this.SelectSearchTypeHebrew.Name = "SelectSearchTypeHebrew";
      this.SelectSearchTypeHebrew.UseVisualStyleBackColor = true;
      // 
      // PanelSearchTop
      // 
      this.PanelSearchTop.Controls.Add(this.EditLetters);
      resources.ApplyResources(this.PanelSearchTop, "PanelSearchTop");
      this.PanelSearchTop.Name = "PanelSearchTop";
      // 
      // EditLetters
      // 
      this.EditLetters.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.EditLetters, "EditLetters");
      this.EditLetters.Name = "EditLetters";
      this.EditLetters.ShowValues = false;
      this.EditLetters.InputTextChanged += new System.EventHandler(this.EditLetters_InputTextChanged);
      this.EditLetters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PanelLetterSearch_KeyPress);
      // 
      // SelectSearchTypeTranslation
      // 
      this.SelectSearchTypeTranslation.Controls.Add(this.LabelSearchTranslationHelp);
      this.SelectSearchTypeTranslation.Controls.Add(this.EditSearchTranslation);
      resources.ApplyResources(this.SelectSearchTypeTranslation, "SelectSearchTypeTranslation");
      this.SelectSearchTypeTranslation.Name = "SelectSearchTypeTranslation";
      this.SelectSearchTypeTranslation.UseVisualStyleBackColor = true;
      // 
      // LabelSearchTranslationHelp
      // 
      resources.ApplyResources(this.LabelSearchTranslationHelp, "LabelSearchTranslationHelp");
      this.LabelSearchTranslationHelp.Name = "LabelSearchTranslationHelp";
      // 
      // EditSearchTranslation
      // 
      this.EditSearchTranslation.BackColor = System.Drawing.Color.AliceBlue;
      this.EditSearchTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditSearchTranslation.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      resources.ApplyResources(this.EditSearchTranslation, "EditSearchTranslation");
      this.EditSearchTranslation.Name = "EditSearchTranslation";
      this.EditSearchTranslation.TextChanged += new System.EventHandler(this.EditSearchTranslation_TextChanged);
      this.EditSearchTranslation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PanelLetterSearch_KeyPress);
      // 
      // SelectSearchTypeVerses
      // 
      this.SelectSearchTypeVerses.Controls.Add(this.SelectSearchRequestAllUntranslated);
      this.SelectSearchTypeVerses.Controls.Add(this.SelectSearchRequestAllPartiallyTranslated);
      this.SelectSearchTypeVerses.Controls.Add(this.SelectSearchRequestAllFullyTranslated);
      this.SelectSearchTypeVerses.Controls.Add(this.SelectSearchRequestAllTranslated);
      resources.ApplyResources(this.SelectSearchTypeVerses, "SelectSearchTypeVerses");
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
      this.PanelNavigation.Controls.Add(this.EditChapterMemo);
      this.PanelNavigation.Controls.Add(this.LabelChapterMemo);
      this.PanelNavigation.Controls.Add(this.LabelBookTranslation);
      this.PanelNavigation.Controls.Add(this.LabelChapterTitle);
      this.PanelNavigation.Controls.Add(this.ActionEditBookMemo);
      this.PanelNavigation.Controls.Add(this.ActionEditChapterMemo);
      this.PanelNavigation.Controls.Add(this.ActionELS50CopyToClipboard);
      this.PanelNavigation.Controls.Add(this.ActionExportChapter);
      this.PanelNavigation.Controls.Add(this.ActionExportBook);
      this.PanelNavigation.Controls.Add(this.ActionSearchVerse);
      this.PanelNavigation.Controls.Add(this.SelectBook);
      this.PanelNavigation.Controls.Add(this.EditBookTranslation);
      this.PanelNavigation.Controls.Add(this.EditChapterTitle);
      this.PanelNavigation.Controls.Add(this.EditELS50);
      this.PanelNavigation.Controls.Add(this.SelectChapter);
      this.PanelNavigation.Controls.Add(this.LabelChapterELS50);
      this.PanelNavigation.Controls.Add(this.LabelSelectBook);
      this.PanelNavigation.Controls.Add(this.LabelSelectChapter);
      resources.ApplyResources(this.PanelNavigation, "PanelNavigation");
      this.PanelNavigation.Name = "PanelNavigation";
      // 
      // EditChapterMemo
      // 
      resources.ApplyResources(this.EditChapterMemo, "EditChapterMemo");
      this.EditChapterMemo.BackColor = System.Drawing.Color.LightYellow;
      this.EditChapterMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditChapterMemo.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditChapterMemo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ChaptersBindingSource, "Memo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditChapterMemo.Name = "EditChapterMemo";
      this.EditChapterMemo.Enter += new System.EventHandler(this.EditDbTextBox_Enter);
      this.EditChapterMemo.Leave += new System.EventHandler(this.EditDbTextBox_Leave);
      // 
      // ChaptersBindingSource
      // 
      this.ChaptersBindingSource.DataMember = "Chapters";
      this.ChaptersBindingSource.DataSource = this.BookRowBindingSource;
      this.ChaptersBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.ChaptersBindingSource_ListChanged);
      this.ChaptersBindingSource.PositionChanged += new System.EventHandler(this.ChaptersBindingSource_PositionChanged);
      // 
      // BookRowBindingSource
      // 
      this.BookRowBindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.BookRow);
      this.BookRowBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.BookRowBindingSource_ListChanged);
      this.BookRowBindingSource.PositionChanged += new System.EventHandler(this.BookRowBindingSource_PositionChanged);
      // 
      // LabelChapterMemo
      // 
      resources.ApplyResources(this.LabelChapterMemo, "LabelChapterMemo");
      this.LabelChapterMemo.Name = "LabelChapterMemo";
      // 
      // LabelBookTranslation
      // 
      resources.ApplyResources(this.LabelBookTranslation, "LabelBookTranslation");
      this.LabelBookTranslation.Name = "LabelBookTranslation";
      // 
      // LabelChapterTitle
      // 
      resources.ApplyResources(this.LabelChapterTitle, "LabelChapterTitle");
      this.LabelChapterTitle.Name = "LabelChapterTitle";
      // 
      // ActionEditBookMemo
      // 
      this.ActionEditBookMemo.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionEditBookMemo, "ActionEditBookMemo");
      this.ActionEditBookMemo.Name = "ActionEditBookMemo";
      this.ActionEditBookMemo.UseVisualStyleBackColor = true;
      this.ActionEditBookMemo.Click += new System.EventHandler(this.ActionEditBookMemo_Click);
      // 
      // ActionEditChapterMemo
      // 
      resources.ApplyResources(this.ActionEditChapterMemo, "ActionEditChapterMemo");
      this.ActionEditChapterMemo.FlatAppearance.BorderSize = 0;
      this.ActionEditChapterMemo.Name = "ActionEditChapterMemo";
      this.ActionEditChapterMemo.UseVisualStyleBackColor = true;
      this.ActionEditChapterMemo.Click += new System.EventHandler(this.ActionEditChapterMemo_Click);
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
      this.ActionExportChapter.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionExportChapter, "ActionExportChapter");
      this.ActionExportChapter.Name = "ActionExportChapter";
      this.ActionExportChapter.UseVisualStyleBackColor = true;
      this.ActionExportChapter.Click += new System.EventHandler(this.ActionExportChapter_Click);
      // 
      // ActionExportBook
      // 
      this.ActionExportBook.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionExportBook, "ActionExportBook");
      this.ActionExportBook.Name = "ActionExportBook";
      this.ActionExportBook.UseVisualStyleBackColor = true;
      this.ActionExportBook.Click += new System.EventHandler(this.ActionExportBook_Click);
      // 
      // ActionSearchVerse
      // 
      this.ActionSearchVerse.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionSearchVerse, "ActionSearchVerse");
      this.ActionSearchVerse.Name = "ActionSearchVerse";
      this.ActionSearchVerse.UseVisualStyleBackColor = true;
      this.ActionSearchVerse.Click += new System.EventHandler(this.ActionSearchVerse_Click);
      // 
      // SelectBook
      // 
      this.SelectBook.DataSource = this.BookRowBindingSource;
      this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.SelectBook, "SelectBook");
      this.SelectBook.FormattingEnabled = true;
      this.SelectBook.Name = "SelectBook";
      this.SelectBook.SelectedIndexChanged += new System.EventHandler(this.SelectBook_SelectedIndexChanged);
      // 
      // EditBookTranslation
      // 
      this.EditBookTranslation.BackColor = System.Drawing.Color.LightYellow;
      this.EditBookTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditBookTranslation.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditBookTranslation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BookRowBindingSource, "Translation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      resources.ApplyResources(this.EditBookTranslation, "EditBookTranslation");
      this.EditBookTranslation.Name = "EditBookTranslation";
      this.EditBookTranslation.Enter += new System.EventHandler(this.EditDbTextBox_Enter);
      this.EditBookTranslation.Leave += new System.EventHandler(this.EditDbTextBox_Leave);
      // 
      // EditChapterTitle
      // 
      this.EditChapterTitle.BackColor = System.Drawing.Color.LightYellow;
      this.EditChapterTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditChapterTitle.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditChapterTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ChaptersBindingSource, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      resources.ApplyResources(this.EditChapterTitle, "EditChapterTitle");
      this.EditChapterTitle.Name = "EditChapterTitle";
      this.EditChapterTitle.Enter += new System.EventHandler(this.EditDbTextBox_Enter);
      this.EditChapterTitle.Leave += new System.EventHandler(this.EditDbTextBox_Leave);
      // 
      // EditELS50
      // 
      resources.ApplyResources(this.EditELS50, "EditELS50");
      this.EditELS50.BackColor = System.Drawing.Color.LightYellow;
      this.EditELS50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditELS50.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ChaptersBindingSource, "ELS50", true));
      this.EditELS50.Name = "EditELS50";
      this.EditELS50.ReadOnly = true;
      // 
      // SelectChapter
      // 
      this.SelectChapter.DataSource = this.ChaptersBindingSource;
      this.SelectChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.SelectChapter, "SelectChapter");
      this.SelectChapter.FormattingEnabled = true;
      this.SelectChapter.Name = "SelectChapter";
      this.SelectChapter.SelectedIndexChanged += new System.EventHandler(this.SelectChapter_SelectedIndexChanged);
      // 
      // LabelChapterELS50
      // 
      resources.ApplyResources(this.LabelChapterELS50, "LabelChapterELS50");
      this.LabelChapterELS50.Name = "LabelChapterELS50";
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
      this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.PanelTitle.Controls.Add(this.LabelProgress);
      this.PanelTitle.Controls.Add(this.LabelTitle);
      resources.ApplyResources(this.PanelTitle, "PanelTitle");
      this.PanelTitle.Name = "PanelTitle";
      // 
      // LabelProgress
      // 
      this.LabelProgress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      resources.ApplyResources(this.LabelProgress, "LabelProgress");
      this.LabelProgress.Name = "LabelProgress";
      // 
      // LabelTitle
      // 
      this.LabelTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      resources.ApplyResources(this.LabelTitle, "LabelTitle");
      this.LabelTitle.Name = "LabelTitle";
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
            this.ActionPreferences,
            this.ActionViewSearch,
            this.toolStripSeparator10,
            this.ActionViewTranslations,
            this.ActionViewRawText,
            this.ActionViewELS50,
            this.toolStripSeparator4,
            this.ActionGoToReference,
            this.ActionRefresh,
            this.toolStripSeparator9,
            this.ActionCloseWindows,
            this.ActionCopyToClipboard,
            this.toolStripSeparator7,
            this.MenuDatabase,
            this.ActionSave,
            this.toolStripSeparator1,
            this.MenuBookmarks,
            this.MenuTools,
            this.ActionWebLinks,
            this.ActionInformation,
            this.ActionImportConcordances,
            this.ActionSettings});
      this.ToolStrip.Name = "ToolStrip";
      this.ToolStrip.ShowItemToolTips = false;
      // 
      // ActionViewVerses
      // 
      this.ActionViewVerses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewVerses, "ActionViewVerses");
      this.ActionViewVerses.Name = "ActionViewVerses";
      this.ActionViewVerses.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewVerses.Click += new System.EventHandler(this.ActionViewVerses_Click);
      this.ActionViewVerses.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionViewVerses.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // ActionExit
      // 
      this.ActionExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionExit, "ActionExit");
      this.ActionExit.Name = "ActionExit";
      this.ActionExit.Padding = new System.Windows.Forms.Padding(5);
      this.ActionExit.Click += new System.EventHandler(this.ActionExit_Click);
      this.ActionExit.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionExit.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      this.ActionExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ActionExit_MouseUp);
      // 
      // Sep4
      // 
      this.Sep4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.Sep4.Name = "Sep4";
      resources.ApplyResources(this.Sep4, "Sep4");
      // 
      // ActionPreferences
      // 
      this.ActionPreferences.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionPreferences, "ActionPreferences");
      this.ActionPreferences.Name = "ActionPreferences";
      this.ActionPreferences.Padding = new System.Windows.Forms.Padding(5);
      this.ActionPreferences.Click += new System.EventHandler(this.ActionPreferences_Click);
      this.ActionPreferences.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionPreferences.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // ActionViewSearch
      // 
      this.ActionViewSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewSearch, "ActionViewSearch");
      this.ActionViewSearch.Name = "ActionViewSearch";
      this.ActionViewSearch.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewSearch.Click += new System.EventHandler(this.ActionViewSearch_Click);
      this.ActionViewSearch.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionViewSearch.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // toolStripSeparator10
      // 
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
      // 
      // ActionViewTranslations
      // 
      this.ActionViewTranslations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewTranslations, "ActionViewTranslations");
      this.ActionViewTranslations.Name = "ActionViewTranslations";
      this.ActionViewTranslations.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewTranslations.Click += new System.EventHandler(this.ActionViewTranslations_Click);
      this.ActionViewTranslations.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionViewTranslations.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // ActionViewRawText
      // 
      this.ActionViewRawText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewRawText, "ActionViewRawText");
      this.ActionViewRawText.Name = "ActionViewRawText";
      this.ActionViewRawText.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewRawText.Click += new System.EventHandler(this.ActionViewRawText_Click);
      this.ActionViewRawText.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionViewRawText.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // ActionViewELS50
      // 
      this.ActionViewELS50.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewELS50, "ActionViewELS50");
      this.ActionViewELS50.Name = "ActionViewELS50";
      this.ActionViewELS50.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewELS50.Click += new System.EventHandler(this.ActionViewELS50_Click);
      this.ActionViewELS50.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionViewELS50.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
      // 
      // ActionGoToReference
      // 
      this.ActionGoToReference.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionGoToReference, "ActionGoToReference");
      this.ActionGoToReference.Name = "ActionGoToReference";
      this.ActionGoToReference.Padding = new System.Windows.Forms.Padding(5);
      this.ActionGoToReference.Click += new System.EventHandler(this.ActionGoToVerse_Click);
      this.ActionGoToReference.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionGoToReference.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // ActionRefresh
      // 
      this.ActionRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionRefresh, "ActionRefresh");
      this.ActionRefresh.Name = "ActionRefresh";
      this.ActionRefresh.Padding = new System.Windows.Forms.Padding(5);
      this.ActionRefresh.Click += new System.EventHandler(this.ActionRefresh_Click);
      this.ActionRefresh.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionRefresh.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // toolStripSeparator9
      // 
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
      // 
      // ActionCloseWindows
      // 
      this.ActionCloseWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionCloseWindows, "ActionCloseWindows");
      this.ActionCloseWindows.Name = "ActionCloseWindows";
      this.ActionCloseWindows.Padding = new System.Windows.Forms.Padding(5);
      this.ActionCloseWindows.Click += new System.EventHandler(this.ActionCloseWindows_Click);
      this.ActionCloseWindows.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionCloseWindows.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // ActionCopyToClipboard
      // 
      this.ActionCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionCopyToClipboard, "ActionCopyToClipboard");
      this.ActionCopyToClipboard.Name = "ActionCopyToClipboard";
      this.ActionCopyToClipboard.Padding = new System.Windows.Forms.Padding(5);
      this.ActionCopyToClipboard.Click += new System.EventHandler(this.ActionCopyToClipboard_Click);
      this.ActionCopyToClipboard.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionCopyToClipboard.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
      // 
      // MenuDatabase
      // 
      this.MenuDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionNew,
            this.ActionRestore,
            this.ActionBackup,
            this.toolStripSeparator5,
            this.ActionVacuum,
            this.toolStripSeparator2,
            this.ActionOpenBackupPath,
            this.ActionOpenExportFolder});
      resources.ApplyResources(this.MenuDatabase, "MenuDatabase");
      this.MenuDatabase.Name = "MenuDatabase";
      this.MenuDatabase.Padding = new System.Windows.Forms.Padding(5);
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
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
      // 
      // ActionVacuum
      // 
      resources.ApplyResources(this.ActionVacuum, "ActionVacuum");
      this.ActionVacuum.Name = "ActionVacuum";
      this.ActionVacuum.Click += new System.EventHandler(this.ActionVacuum_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      // 
      // ActionOpenBackupPath
      // 
      resources.ApplyResources(this.ActionOpenBackupPath, "ActionOpenBackupPath");
      this.ActionOpenBackupPath.Name = "ActionOpenBackupPath";
      this.ActionOpenBackupPath.Click += new System.EventHandler(this.ActionOpenBackupPath_Click);
      // 
      // ActionOpenExportFolder
      // 
      resources.ApplyResources(this.ActionOpenExportFolder, "ActionOpenExportFolder");
      this.ActionOpenExportFolder.Name = "ActionOpenExportFolder";
      this.ActionOpenExportFolder.Click += new System.EventHandler(this.ActionOpenExportFolder_Click);
      // 
      // ActionSave
      // 
      this.ActionSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionSave, "ActionSave");
      this.ActionSave.Name = "ActionSave";
      this.ActionSave.Padding = new System.Windows.Forms.Padding(5);
      this.ActionSave.Click += new System.EventHandler(this.ActionSave_Click);
      this.ActionSave.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionSave.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      // 
      // MenuBookmarks
      // 
      this.MenuBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuBookmarks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHistory,
            this.toolStripSeparator17,
            this.ActionSortBookmarks,
            this.ActionAddBookmark,
            this.ActionClearBookmarks,
            this.toolStripSeparator8,
            this.ActionGoToBookmarkMain,
            this.toolStripSeparator12});
      resources.ApplyResources(this.MenuBookmarks, "MenuBookmarks");
      this.MenuBookmarks.Name = "MenuBookmarks";
      this.MenuBookmarks.Padding = new System.Windows.Forms.Padding(5);
      // 
      // MenuHistory
      // 
      this.MenuHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionClearHistory});
      resources.ApplyResources(this.MenuHistory, "MenuHistory");
      this.MenuHistory.Name = "MenuHistory";
      // 
      // ActionClearHistory
      // 
      resources.ApplyResources(this.ActionClearHistory, "ActionClearHistory");
      this.ActionClearHistory.Name = "ActionClearHistory";
      this.ActionClearHistory.Click += new System.EventHandler(this.ActionClearHistory_Click);
      // 
      // toolStripSeparator17
      // 
      this.toolStripSeparator17.Name = "toolStripSeparator17";
      resources.ApplyResources(this.toolStripSeparator17, "toolStripSeparator17");
      // 
      // ActionSortBookmarks
      // 
      resources.ApplyResources(this.ActionSortBookmarks, "ActionSortBookmarks");
      this.ActionSortBookmarks.Name = "ActionSortBookmarks";
      this.ActionSortBookmarks.Click += new System.EventHandler(this.ActionSortBookmarks_Click);
      // 
      // ActionAddBookmark
      // 
      resources.ApplyResources(this.ActionAddBookmark, "ActionAddBookmark");
      this.ActionAddBookmark.Name = "ActionAddBookmark";
      this.ActionAddBookmark.Click += new System.EventHandler(this.ActionAddBookmark_Click);
      // 
      // ActionClearBookmarks
      // 
      resources.ApplyResources(this.ActionClearBookmarks, "ActionClearBookmarks");
      this.ActionClearBookmarks.Name = "ActionClearBookmarks";
      this.ActionClearBookmarks.Click += new System.EventHandler(this.ActionClearBookmarks_Click);
      // 
      // toolStripSeparator8
      // 
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
      // 
      // ActionGoToBookmarkMain
      // 
      resources.ApplyResources(this.ActionGoToBookmarkMain, "ActionGoToBookmarkMain");
      this.ActionGoToBookmarkMain.Name = "ActionGoToBookmarkMain";
      // 
      // toolStripSeparator12
      // 
      this.toolStripSeparator12.Name = "toolStripSeparator12";
      resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
      // 
      // MenuTools
      // 
      resources.ApplyResources(this.MenuTools, "MenuTools");
      this.MenuTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionViewBooksTranslation,
            this.ActionViewParashot,
            this.toolStripSeparator6,
            this.ActionShowGrammarGuide,
            this.toolStripSeparator13,
            this.ActionOpenHebrewLetters,
            this.toolStripSeparator16,
            this.ActionViewBibleStatistics,
            this.sYSTEMSTATSToolStripMenuItem});
      this.MenuTools.Name = "MenuTools";
      this.MenuTools.Padding = new System.Windows.Forms.Padding(5);
      // 
      // ActionViewBooksTranslation
      // 
      resources.ApplyResources(this.ActionViewBooksTranslation, "ActionViewBooksTranslation");
      this.ActionViewBooksTranslation.Name = "ActionViewBooksTranslation";
      this.ActionViewBooksTranslation.Click += new System.EventHandler(this.ActionViewBooksTranslation_Click);
      // 
      // ActionViewParashot
      // 
      resources.ApplyResources(this.ActionViewParashot, "ActionViewParashot");
      this.ActionViewParashot.Name = "ActionViewParashot";
      this.ActionViewParashot.Click += new System.EventHandler(this.ActionViewParashot_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
      // 
      // ActionShowGrammarGuide
      // 
      resources.ApplyResources(this.ActionShowGrammarGuide, "ActionShowGrammarGuide");
      this.ActionShowGrammarGuide.Name = "ActionShowGrammarGuide";
      this.ActionShowGrammarGuide.Click += new System.EventHandler(this.ActionShowGrammarGuide_Click);
      // 
      // toolStripSeparator13
      // 
      this.toolStripSeparator13.Name = "toolStripSeparator13";
      resources.ApplyResources(this.toolStripSeparator13, "toolStripSeparator13");
      // 
      // ActionOpenHebrewLetters
      // 
      resources.ApplyResources(this.ActionOpenHebrewLetters, "ActionOpenHebrewLetters");
      this.ActionOpenHebrewLetters.Name = "ActionOpenHebrewLetters";
      this.ActionOpenHebrewLetters.Click += new System.EventHandler(this.ActionStartHebrewLetters_Click);
      // 
      // toolStripSeparator16
      // 
      this.toolStripSeparator16.Name = "toolStripSeparator16";
      resources.ApplyResources(this.toolStripSeparator16, "toolStripSeparator16");
      // 
      // ActionViewBibleStatistics
      // 
      resources.ApplyResources(this.ActionViewBibleStatistics, "ActionViewBibleStatistics");
      this.ActionViewBibleStatistics.Name = "ActionViewBibleStatistics";
      this.ActionViewBibleStatistics.Click += new System.EventHandler(this.ActionViewBibleStatistics_Click);
      // 
      // sYSTEMSTATSToolStripMenuItem
      // 
      this.sYSTEMSTATSToolStripMenuItem.Name = "sYSTEMSTATSToolStripMenuItem";
      resources.ApplyResources(this.sYSTEMSTATSToolStripMenuItem, "sYSTEMSTATSToolStripMenuItem");
      this.sYSTEMSTATSToolStripMenuItem.Click += new System.EventHandler(this.ActionViewStats_Click);
      // 
      // ActionWebLinks
      // 
      resources.ApplyResources(this.ActionWebLinks, "ActionWebLinks");
      this.ActionWebLinks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionWebLinks.Name = "ActionWebLinks";
      this.ActionWebLinks.Padding = new System.Windows.Forms.Padding(5);
      // 
      // ActionInformation
      // 
      resources.ApplyResources(this.ActionInformation, "ActionInformation");
      this.ActionInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionInformation.Name = "ActionInformation";
      this.ActionInformation.Padding = new System.Windows.Forms.Padding(5);
      // 
      // ActionImportConcordances
      // 
      this.ActionImportConcordances.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionImportConcordances, "ActionImportConcordances");
      this.ActionImportConcordances.Name = "ActionImportConcordances";
      this.ActionImportConcordances.Click += new System.EventHandler(this.ActionImportConcordances_Click);
      // 
      // ActionSettings
      // 
      this.ActionSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuitemScreenPosition,
            this.ActionResetWinSettings,
            this.Sep7,
            this.ActionShowKeyboardNotice,
            this.toolStripSeparator11,
            this.EditShowTips,
            this.EditUseAdvancedDialogBoxes,
            this.EditSoundsEnabled,
            this.EditShowSuccessDialogs,
            this.toolStripSeparator15,
            this.EditConfirmClosing});
      resources.ApplyResources(this.ActionSettings, "ActionSettings");
      this.ActionSettings.Name = "ActionSettings";
      this.ActionSettings.Padding = new System.Windows.Forms.Padding(5);
      // 
      // MenuitemScreenPosition
      // 
      this.MenuitemScreenPosition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditScreenNone,
            this.EditScreenTopLeft,
            this.EditScreenTopRight,
            this.EditScreenBottomLeft,
            this.EditScreenBottomRight,
            this.EditScreenCenter});
      resources.ApplyResources(this.MenuitemScreenPosition, "MenuitemScreenPosition");
      this.MenuitemScreenPosition.Name = "MenuitemScreenPosition";
      // 
      // EditScreenNone
      // 
      this.EditScreenNone.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenNone, "EditScreenNone");
      this.EditScreenNone.Name = "EditScreenNone";
      this.EditScreenNone.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // EditScreenTopLeft
      // 
      this.EditScreenTopLeft.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenTopLeft, "EditScreenTopLeft");
      this.EditScreenTopLeft.Name = "EditScreenTopLeft";
      this.EditScreenTopLeft.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // EditScreenTopRight
      // 
      this.EditScreenTopRight.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenTopRight, "EditScreenTopRight");
      this.EditScreenTopRight.Name = "EditScreenTopRight";
      this.EditScreenTopRight.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // EditScreenBottomLeft
      // 
      this.EditScreenBottomLeft.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenBottomLeft, "EditScreenBottomLeft");
      this.EditScreenBottomLeft.Name = "EditScreenBottomLeft";
      this.EditScreenBottomLeft.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // EditScreenBottomRight
      // 
      this.EditScreenBottomRight.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenBottomRight, "EditScreenBottomRight");
      this.EditScreenBottomRight.Name = "EditScreenBottomRight";
      this.EditScreenBottomRight.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // EditScreenCenter
      // 
      this.EditScreenCenter.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenCenter, "EditScreenCenter");
      this.EditScreenCenter.Name = "EditScreenCenter";
      this.EditScreenCenter.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // ActionResetWinSettings
      // 
      resources.ApplyResources(this.ActionResetWinSettings, "ActionResetWinSettings");
      this.ActionResetWinSettings.Name = "ActionResetWinSettings";
      this.ActionResetWinSettings.Click += new System.EventHandler(this.ActionResetWinSettings_Click);
      // 
      // Sep7
      // 
      this.Sep7.Name = "Sep7";
      resources.ApplyResources(this.Sep7, "Sep7");
      // 
      // ActionShowKeyboardNotice
      // 
      resources.ApplyResources(this.ActionShowKeyboardNotice, "ActionShowKeyboardNotice");
      this.ActionShowKeyboardNotice.Name = "ActionShowKeyboardNotice";
      this.ActionShowKeyboardNotice.Click += new System.EventHandler(this.ActionShowKeyboardNotice_Click);
      // 
      // toolStripSeparator11
      // 
      this.toolStripSeparator11.Name = "toolStripSeparator11";
      resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
      // 
      // EditShowTips
      // 
      this.EditShowTips.Checked = true;
      this.EditShowTips.CheckOnClick = true;
      this.EditShowTips.CheckState = System.Windows.Forms.CheckState.Checked;
      resources.ApplyResources(this.EditShowTips, "EditShowTips");
      this.EditShowTips.Name = "EditShowTips";
      // 
      // EditUseAdvancedDialogBoxes
      // 
      this.EditUseAdvancedDialogBoxes.Checked = true;
      this.EditUseAdvancedDialogBoxes.CheckOnClick = true;
      this.EditUseAdvancedDialogBoxes.CheckState = System.Windows.Forms.CheckState.Checked;
      resources.ApplyResources(this.EditUseAdvancedDialogBoxes, "EditUseAdvancedDialogBoxes");
      this.EditUseAdvancedDialogBoxes.Name = "EditUseAdvancedDialogBoxes";
      this.EditUseAdvancedDialogBoxes.CheckedChanged += new System.EventHandler(this.EditDialogBoxesSettings_CheckedChanged);
      // 
      // EditSoundsEnabled
      // 
      this.EditSoundsEnabled.Checked = true;
      this.EditSoundsEnabled.CheckOnClick = true;
      this.EditSoundsEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
      resources.ApplyResources(this.EditSoundsEnabled, "EditSoundsEnabled");
      this.EditSoundsEnabled.Name = "EditSoundsEnabled";
      this.EditSoundsEnabled.CheckedChanged += new System.EventHandler(this.EditDialogBoxesSettings_CheckedChanged);
      // 
      // EditShowSuccessDialogs
      // 
      this.EditShowSuccessDialogs.Checked = true;
      this.EditShowSuccessDialogs.CheckOnClick = true;
      this.EditShowSuccessDialogs.CheckState = System.Windows.Forms.CheckState.Checked;
      resources.ApplyResources(this.EditShowSuccessDialogs, "EditShowSuccessDialogs");
      this.EditShowSuccessDialogs.Name = "EditShowSuccessDialogs";
      this.EditShowSuccessDialogs.CheckedChanged += new System.EventHandler(this.EditShowSuccessDialogs_CheckedChanged);
      // 
      // toolStripSeparator15
      // 
      this.toolStripSeparator15.Name = "toolStripSeparator15";
      resources.ApplyResources(this.toolStripSeparator15, "toolStripSeparator15");
      // 
      // EditConfirmClosing
      // 
      resources.ApplyResources(this.EditConfirmClosing, "EditConfirmClosing");
      this.EditConfirmClosing.Checked = true;
      this.EditConfirmClosing.CheckOnClick = true;
      this.EditConfirmClosing.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditConfirmClosing.Name = "EditConfirmClosing";
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
      this.ContextMenuStripVerse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionVerseReadOnline,
            this.toolStripMenuItem1,
            this.ActionCopyTranslation,
            this.ActionExportVerse,
            this.toolStripMenuItem3,
            this.ActionSetAsBookmarkMain,
            this.ActionAddToBookmarks,
            this.toolStripMenuItem4,
            this.ActionImportConsole});
      this.ContextMenuStripVerse.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStripVerse, "ContextMenuStripVerse");
      // 
      // ActionVerseReadOnline
      // 
      resources.ApplyResources(this.ActionVerseReadOnline, "ActionVerseReadOnline");
      this.ActionVerseReadOnline.Name = "ActionVerseReadOnline";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
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
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
      // 
      // ActionSetAsBookmarkMain
      // 
      resources.ApplyResources(this.ActionSetAsBookmarkMain, "ActionSetAsBookmarkMain");
      this.ActionSetAsBookmarkMain.Name = "ActionSetAsBookmarkMain";
      this.ActionSetAsBookmarkMain.Click += new System.EventHandler(this.ActionSetAsBookmarkMaster_Click);
      // 
      // ActionAddToBookmarks
      // 
      resources.ApplyResources(this.ActionAddToBookmarks, "ActionAddToBookmarks");
      this.ActionAddToBookmarks.Name = "ActionAddToBookmarks";
      this.ActionAddToBookmarks.Click += new System.EventHandler(this.ActionAddToBookmarks_Click);
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
      // 
      // ActionImportConsole
      // 
      resources.ApplyResources(this.ActionImportConsole, "ActionImportConsole");
      this.ActionImportConsole.Name = "ActionImportConsole";
      this.ActionImportConsole.Click += new System.EventHandler(this.ActionImportConsole_Click);
      // 
      // ContextMenuStripWord
      // 
      this.ContextMenuStripWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionWordSearchOnline,
            this.ActionSearchTranslated,
            this.ActionSearchWord,
            this.MenuSeparator2,
            this.ActionShowGrammarGuide2,
            this.toolStripSeparator3,
            this.ActionOpenHebrewLetters2,
            this.toolStripSeparator14,
            this.ActionCountOccurences,
            this.ActionCountRootOccurences,
            this.MenuSeparator1,
            this.ActionCopyFontChars,
            this.ActionCopyUnicodeChars,
            this.ActionCopyWordTranslation});
      this.ContextMenuStripWord.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStripWord, "ContextMenuStripWord");
      // 
      // ActionWordSearchOnline
      // 
      resources.ApplyResources(this.ActionWordSearchOnline, "ActionWordSearchOnline");
      this.ActionWordSearchOnline.Name = "ActionWordSearchOnline";
      this.ActionWordSearchOnline.Click += new System.EventHandler(this.ActionSearchOnline_Click);
      // 
      // ActionSearchTranslated
      // 
      resources.ApplyResources(this.ActionSearchTranslated, "ActionSearchTranslated");
      this.ActionSearchTranslated.Name = "ActionSearchTranslated";
      this.ActionSearchTranslated.Click += new System.EventHandler(this.ActionSearchTranslated_Click);
      // 
      // ActionSearchWord
      // 
      resources.ApplyResources(this.ActionSearchWord, "ActionSearchWord");
      this.ActionSearchWord.Name = "ActionSearchWord";
      this.ActionSearchWord.Click += new System.EventHandler(this.ActionSearchWordInDatabase_Click);
      // 
      // MenuSeparator2
      // 
      this.MenuSeparator2.Name = "MenuSeparator2";
      resources.ApplyResources(this.MenuSeparator2, "MenuSeparator2");
      // 
      // ActionShowGrammarGuide2
      // 
      resources.ApplyResources(this.ActionShowGrammarGuide2, "ActionShowGrammarGuide2");
      this.ActionShowGrammarGuide2.Name = "ActionShowGrammarGuide2";
      this.ActionShowGrammarGuide2.Click += new System.EventHandler(this.ActionShowGrammarGuide_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
      // 
      // ActionOpenHebrewLetters2
      // 
      resources.ApplyResources(this.ActionOpenHebrewLetters2, "ActionOpenHebrewLetters2");
      this.ActionOpenHebrewLetters2.Name = "ActionOpenHebrewLetters2";
      this.ActionOpenHebrewLetters2.Click += new System.EventHandler(this.ActionStartHebrewLetters_Click);
      // 
      // toolStripSeparator14
      // 
      this.toolStripSeparator14.Name = "toolStripSeparator14";
      resources.ApplyResources(this.toolStripSeparator14, "toolStripSeparator14");
      // 
      // ActionCountOccurences
      // 
      resources.ApplyResources(this.ActionCountOccurences, "ActionCountOccurences");
      this.ActionCountOccurences.Name = "ActionCountOccurences";
      // 
      // ActionCountRootOccurences
      // 
      resources.ApplyResources(this.ActionCountRootOccurences, "ActionCountRootOccurences");
      this.ActionCountRootOccurences.Name = "ActionCountRootOccurences";
      // 
      // MenuSeparator1
      // 
      this.MenuSeparator1.Name = "MenuSeparator1";
      resources.ApplyResources(this.MenuSeparator1, "MenuSeparator1");
      // 
      // ActionCopyFontChars
      // 
      resources.ApplyResources(this.ActionCopyFontChars, "ActionCopyFontChars");
      this.ActionCopyFontChars.Name = "ActionCopyFontChars";
      this.ActionCopyFontChars.Click += new System.EventHandler(this.ActionCopyFontChars_Click);
      // 
      // ActionCopyUnicodeChars
      // 
      resources.ApplyResources(this.ActionCopyUnicodeChars, "ActionCopyUnicodeChars");
      this.ActionCopyUnicodeChars.Name = "ActionCopyUnicodeChars";
      this.ActionCopyUnicodeChars.Click += new System.EventHandler(this.ActionCopyUnicodeChars_Click);
      // 
      // ActionCopyWordTranslation
      // 
      resources.ApplyResources(this.ActionCopyWordTranslation, "ActionCopyWordTranslation");
      this.ActionCopyWordTranslation.Name = "ActionCopyWordTranslation";
      this.ActionCopyWordTranslation.Click += new System.EventHandler(this.ActionCopyWordTranslation_Click);
      // 
      // WordsBindingSource
      // 
      this.WordsBindingSource.DataMember = "Words";
      this.WordsBindingSource.DataSource = this.VersesBindingSource;
      // 
      // VersesBindingSource
      // 
      this.VersesBindingSource.DataMember = "Verses";
      this.VersesBindingSource.DataSource = this.ChaptersBindingSource;
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
      ((System.ComponentModel.ISupportInitialize)(this.ChaptersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BookRowBindingSource)).EndInit();
      this.PanelTitle.ResumeLayout(false);
      this.ToolStrip.ResumeLayout(false);
      this.ToolStrip.PerformLayout();
      this.ContextMenuStripVerse.ResumeLayout(false);
      this.ContextMenuStripWord.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.WordsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.VersesBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    internal BindingSource BookRowBindingSource;
    internal BindingSource ChaptersBindingSource;
    internal BindingSource VersesBindingSource;
    internal BindingSource WordsBindingSource;
    internal System.Windows.Forms.ToolStrip ToolStrip;
    private Label LabelProgress;
    private Ordisoftware.Core.TextBoxEx EditBookTranslation;
    private Ordisoftware.Core.TextBoxEx EditChapterMemo;
    private Ordisoftware.Core.TextBoxEx EditChapterTitle;
    private Ordisoftware.Core.TextBoxEx EditSearchTranslation;
    private System.Windows.Forms.Button ActionEditBookMemo;
    private System.Windows.Forms.Button ActionEditChapterMemo;
    private System.Windows.Forms.Button ActionELS50CopyToClipboard;
    private System.Windows.Forms.Button ActionExportBook;
    private System.Windows.Forms.Button ActionExportChapter;
    private System.Windows.Forms.Button ActionNavigateSearchFirst;
    private System.Windows.Forms.Button ActionSearchClear;
    private System.Windows.Forms.Button ActionSearchInAddAll;
    private System.Windows.Forms.Button ActionSearchInRemoveAll;
    private System.Windows.Forms.Button ActionSearchNavigateLast;
    private System.Windows.Forms.Button ActionSearchNavigateNext;
    private System.Windows.Forms.Button ActionSearchNavigatePrevious;
    private System.Windows.Forms.Button ActionSearchVerse;
    private System.Windows.Forms.CheckBox EditSearchInKetouvim;
    private System.Windows.Forms.CheckBox EditSearchInNeviim;
    private System.Windows.Forms.CheckBox EditSearchInTorah;
    private System.Windows.Forms.ComboBox SelectBook;
    private System.Windows.Forms.ComboBox SelectChapter;
    private System.Windows.Forms.ComboBox SelectSearchInBook;
    private System.Windows.Forms.ContextMenuStrip ContextMenuStripVerse;
    private System.Windows.Forms.ContextMenuStrip ContextMenuStripWord;
    private System.Windows.Forms.Label LabelBookTranslation;
    private System.Windows.Forms.Label LabelChapterELS50;
    private System.Windows.Forms.Label LabelChapterMemo;
    private System.Windows.Forms.Label LabelChapterTitle;
    private System.Windows.Forms.Label LabelSearchTranslationHelp;
    private System.Windows.Forms.Label LabelSelectBook;
    private System.Windows.Forms.Label LabelSelectChapter;
    private System.Windows.Forms.Label LabelTitle;
    private System.Windows.Forms.OpenFileDialog OpenFileDialogDB;
    private System.Windows.Forms.Panel PanelMain;
    private System.Windows.Forms.Panel PanelMainCenter;
    private System.Windows.Forms.Panel PanelMainInner;
    private System.Windows.Forms.Panel PanelMainOuter;
    private System.Windows.Forms.Panel PanelNavigation;
    private System.Windows.Forms.Panel PanelSearchFilters;
    private System.Windows.Forms.Panel PanelSearchFiltersRight;
    private System.Windows.Forms.Panel PanelSearchResults;
    private System.Windows.Forms.Panel PanelSearchResultsOuter;
    private System.Windows.Forms.Panel PanelSearchTop;
    private System.Windows.Forms.Panel PanelSepTop;
    private System.Windows.Forms.Panel PanelTitle;
    private System.Windows.Forms.Panel PanelViewELS50;
    private System.Windows.Forms.Panel PanelViewRawText;
    private System.Windows.Forms.Panel PanelViewSearch;
    private System.Windows.Forms.Panel PanelViewSearchSeparator;
    private System.Windows.Forms.Panel PanelViewTranslations;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllFullyTranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllPartiallyTranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllTranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllUntranslated;
    private System.Windows.Forms.RichTextBox EditELS50All;
    private System.Windows.Forms.RichTextBox EditRawText;
    private System.Windows.Forms.RichTextBox EditTranslations;
    private System.Windows.Forms.SaveFileDialog SaveFileDialogDB;
    private System.Windows.Forms.SaveFileDialog SaveFileDialogMSWord;
    private System.Windows.Forms.SaveFileDialog SaveFileDialogRTF;
    private System.Windows.Forms.TabControl TabControl;
    private System.Windows.Forms.TabPage SelectSearchTypeTranslation;
    private System.Windows.Forms.TabPage SelectSearchTypeVerses;
    private System.Windows.Forms.TabPage TabPageELS50;
    private System.Windows.Forms.TabPage TabPageSearch;
    private System.Windows.Forms.TabPage TabPageText;
    private System.Windows.Forms.TabPage TabPageTranslations;
    private System.Windows.Forms.TabPage TabPageVerses;
    private System.Windows.Forms.TextBox EditELS50;
    private System.Windows.Forms.TextBox EditSearchPaging;
    private System.Windows.Forms.Timer TimerTooltip;
    private System.Windows.Forms.ToolStripButton ActionCopyToClipboard;
    private System.Windows.Forms.ToolStripButton ActionExit;
    private System.Windows.Forms.ToolStripButton ActionGoToReference;
    private System.Windows.Forms.ToolStripButton ActionImportConcordances;
    private System.Windows.Forms.ToolStripButton ActionPreferences;
    private System.Windows.Forms.ToolStripButton ActionRefresh;
    private System.Windows.Forms.ToolStripButton ActionViewELS50;
    private System.Windows.Forms.ToolStripButton ActionViewRawText;
    private System.Windows.Forms.ToolStripButton ActionViewSearch;
    private System.Windows.Forms.ToolStripButton ActionViewTranslations;
    private System.Windows.Forms.ToolStripButton ActionViewVerses;
    private System.Windows.Forms.ToolStripDropDownButton ActionWebLinks;
    private System.Windows.Forms.ToolStripDropDownButton MenuBookmarks;
    private System.Windows.Forms.ToolStripDropDownButton MenuDatabase;
    private System.Windows.Forms.ToolStripDropDownButton MenuTools;
    private System.Windows.Forms.ToolStripMenuItem ActionAddBookmark;
    private System.Windows.Forms.ToolStripMenuItem ActionAddToBookmarks;
    private System.Windows.Forms.ToolStripMenuItem ActionBackup;
    private System.Windows.Forms.ToolStripMenuItem ActionClearBookmarks;
    private System.Windows.Forms.ToolStripMenuItem ActionClearHistory;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyFontChars;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyTranslation;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyUnicodeChars;
    private System.Windows.Forms.ToolStripMenuItem ActionCopyWordTranslation;
    private System.Windows.Forms.ToolStripMenuItem ActionCountOccurences;
    private System.Windows.Forms.ToolStripMenuItem ActionCountRootOccurences;
    private System.Windows.Forms.ToolStripMenuItem ActionExportVerse;
    private System.Windows.Forms.ToolStripMenuItem ActionGoToBookmarkMain;
    private System.Windows.Forms.ToolStripMenuItem ActionImportConsole;
    private System.Windows.Forms.ToolStripMenuItem ActionNew;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenBackupPath;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenHebrewLetters;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenHebrewLetters2;
    private System.Windows.Forms.ToolStripMenuItem ActionVerseReadOnline;
    private System.Windows.Forms.ToolStripMenuItem ActionRestore;
    private System.Windows.Forms.ToolStripMenuItem ActionWordSearchOnline;
    private System.Windows.Forms.ToolStripMenuItem ActionSearchWord;
    private System.Windows.Forms.ToolStripMenuItem ActionSetAsBookmarkMain;
    private System.Windows.Forms.ToolStripMenuItem ActionShowGrammarGuide;
    private System.Windows.Forms.ToolStripMenuItem ActionShowGrammarGuide2;
    private System.Windows.Forms.ToolStripMenuItem ActionSortBookmarks;
    private System.Windows.Forms.ToolStripMenuItem ActionVacuum;
    private System.Windows.Forms.ToolStripMenuItem ActionViewBibleStatistics;
    private System.Windows.Forms.ToolStripMenuItem ActionViewBooksTranslation;
    private System.Windows.Forms.ToolStripMenuItem MenuHistory;
    private System.Windows.Forms.ToolStripSeparator MenuSeparator1;
    private System.Windows.Forms.ToolStripSeparator MenuSeparator2;
    private System.Windows.Forms.ToolStripSeparator Sep4;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    private System.Windows.Forms.TrackBar SelectSearchPaging;
    private ToolStripMenuItem ActionOpenExportFolder;
    public Ordisoftware.Hebrew.LettersControl EditLetters;
    public System.Windows.Forms.Button ActionSearchRun;
    public System.Windows.Forms.Panel PanelViewVerses;
    public System.Windows.Forms.TabControl SelectSearchType;
    public System.Windows.Forms.TabPage SelectSearchTypeHebrew;
    public System.Windows.Forms.Timer TimerAutoSave;
    public System.Windows.Forms.ToolStripButton ActionCloseWindows;
    public System.Windows.Forms.ToolStripButton ActionSave;
    public System.Windows.Forms.ToolStripDropDownButton ActionInformation;
    public System.Windows.Forms.ToolStripMenuItem ActionSearchTranslated;
    private ToolStripDropDownButton ActionSettings;
    private ToolStripMenuItem MenuitemScreenPosition;
    public ToolStripMenuItem EditScreenNone;
    public ToolStripMenuItem EditScreenTopLeft;
    public ToolStripMenuItem EditScreenTopRight;
    public ToolStripMenuItem EditScreenBottomLeft;
    public ToolStripMenuItem EditScreenBottomRight;
    public ToolStripMenuItem EditScreenCenter;
    private ToolStripMenuItem ActionResetWinSettings;
    private ToolStripSeparator Sep7;
    private ToolStripMenuItem ActionShowKeyboardNotice;
    private ToolStripSeparator toolStripSeparator11;
    public ToolStripMenuItem EditShowTips;
    public ToolStripMenuItem EditUseAdvancedDialogBoxes;
    public ToolStripMenuItem EditSoundsEnabled;
    public ToolStripMenuItem EditShowSuccessDialogs;
    private ToolStripSeparator toolStripSeparator15;
    public ToolStripMenuItem EditConfirmClosing;
    internal ToolStripMenuItem ActionViewParashot;
    private ToolStripMenuItem sYSTEMSTATSToolStripMenuItem;
  }
}

