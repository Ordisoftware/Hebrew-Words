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
      this.EditChapterTranslation = new Ordisoftware.Core.RichTextBoxEx();
      this.TabPageVerseFiltered = new System.Windows.Forms.TabPage();
      this.PanelViewVerseFiltered = new System.Windows.Forms.Panel();
      this.PanelViewVerseFilteredSingle = new System.Windows.Forms.Panel();
      this.PanelViewVerseFilters = new System.Windows.Forms.Panel();
      this.LabelInfoFilterVerses = new System.Windows.Forms.Button();
      this.ActionGoFromVerseFilteredToVersesPanel = new System.Windows.Forms.Button();
      this.ActionApplyFilterVerse = new System.Windows.Forms.Button();
      this.ActionClearFilterVerse = new System.Windows.Forms.Button();
      this.ActionApplyFilterChapter = new System.Windows.Forms.Button();
      this.ActionApplyFilterBook = new System.Windows.Forms.Button();
      this.ActionClearFilterChapter = new System.Windows.Forms.Button();
      this.ActionClearFilterBook = new System.Windows.Forms.Button();
      this.EditFilterVerse = new System.Windows.Forms.TextBox();
      this.EditFilterChapter = new System.Windows.Forms.TextBox();
      this.EditFilterBook = new System.Windows.Forms.TextBox();
      this.EditFilterVersesTranslated = new System.Windows.Forms.CheckBox();
      this.EditFilterChaptersWithTitle = new System.Windows.Forms.CheckBox();
      this.SelectFilterVerse = new System.Windows.Forms.ComboBox();
      this.FilterVersesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.FilterChaptersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.FilterBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.SelectFilterChapter = new System.Windows.Forms.ComboBox();
      this.SelectFilterBook = new System.Windows.Forms.ComboBox();
      this.LabelFilterBook = new System.Windows.Forms.Label();
      this.LabelFilterChapter = new System.Windows.Forms.Label();
      this.LabelFilterVerse = new System.Windows.Forms.Label();
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
      this.SelectSearchTranslationOnlyComments = new System.Windows.Forms.RadioButton();
      this.SelectSearchTranslationOnlyTranslations = new System.Windows.Forms.RadioButton();
      this.SelectSearchTranslationIncludeComments = new System.Windows.Forms.RadioButton();
      this.LabelSearchTranslationHelp = new System.Windows.Forms.Label();
      this.EditSearchTranslation = new Ordisoftware.Core.TextBoxEx();
      this.SelectSearchTypeVerses = new System.Windows.Forms.TabPage();
      this.SelectSearchRequestAllUntranslated = new System.Windows.Forms.RadioButton();
      this.SelectSearchRequestAllPartiallyTranslated = new System.Windows.Forms.RadioButton();
      this.SelectSearchRequestAllFullyTranslated = new System.Windows.Forms.RadioButton();
      this.SelectSearchRequestAllTranslated = new System.Windows.Forms.RadioButton();
      this.TabPageText = new System.Windows.Forms.TabPage();
      this.PanelViewOriginalText = new System.Windows.Forms.Panel();
      this.EditChapterOriginal = new Ordisoftware.Core.RichTextBoxEx();
      this.TabPageELS50 = new System.Windows.Forms.TabPage();
      this.PanelViewELS50 = new System.Windows.Forms.Panel();
      this.EditChapterELS50 = new Ordisoftware.Core.RichTextBoxEx();
      this.PanelNavigation = new System.Windows.Forms.Panel();
      this.EditELS50HScrollBar = new System.Windows.Forms.HScrollBar();
      this.SelectChapterNavigator = new Ordisoftware.Core.ComboBoxNavigator();
      this.SelectChapter = new System.Windows.Forms.ComboBox();
      this.ChaptersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.BooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.SelectBookNavigator = new Ordisoftware.Core.ComboBoxNavigator();
      this.SelectBook = new System.Windows.Forms.ComboBox();
      this.ActionSelectRenderAllVersesKeepHelp = new System.Windows.Forms.Button();
      this.SelectVerseNavigator = new Ordisoftware.Core.ComboBoxNavigator();
      this.SelectVerse = new System.Windows.Forms.ComboBox();
      this.VersesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.SelectRenderAllVersesKeep = new System.Windows.Forms.CheckBox();
      this.SelectRenderAllVerses = new System.Windows.Forms.CheckBox();
      this.EditChapterMemo = new Ordisoftware.Core.TextBoxEx();
      this.LabelChapterMemo = new System.Windows.Forms.Label();
      this.LabelBookTranslation = new System.Windows.Forms.Label();
      this.LabelSelectVerse = new System.Windows.Forms.Label();
      this.LabelChapterTitle = new System.Windows.Forms.Label();
      this.ActionEditBookMemo = new System.Windows.Forms.Button();
      this.ActionEditChapterMemo = new System.Windows.Forms.Button();
      this.ActionELS50CopyToClipboard = new System.Windows.Forms.Button();
      this.ActionExportChapter = new System.Windows.Forms.Button();
      this.ActionExportBook = new System.Windows.Forms.Button();
      this.ActionSearchVerse = new System.Windows.Forms.Button();
      this.EditBookTranslation = new Ordisoftware.Core.TextBoxEx();
      this.EditChapterTitle = new Ordisoftware.Core.TextBoxEx();
      this.EditELS50Single = new Ordisoftware.Core.TextBoxEx();
      this.LabelChapterELS50 = new System.Windows.Forms.Label();
      this.LabelSelectBook = new System.Windows.Forms.Label();
      this.LabelSelectChapter = new System.Windows.Forms.Label();
      this.PanelSepTop = new System.Windows.Forms.Panel();
      this.PanelTitle = new System.Windows.Forms.Panel();
      this.PanelTitleInner = new System.Windows.Forms.Panel();
      this.LabelTitleReferenceName = new System.Windows.Forms.Label();
      this.LabelTitle = new System.Windows.Forms.Label();
      this.LabelProgress = new System.Windows.Forms.Label();
      this.TimerTooltip = new System.Windows.Forms.Timer(this.components);
      this.ToolStrip = new System.Windows.Forms.ToolStrip();
      this.ActionExit = new System.Windows.Forms.ToolStripButton();
      this.SepExit = new System.Windows.Forms.ToolStripSeparator();
      this.ActionPreferences = new System.Windows.Forms.ToolStripButton();
      this.ActionBookmarks = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionSortBookmarks = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionAddBookmark = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionClearBookmarks = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionGoToBookmarkMain = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionHistory = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionClearHistory = new System.Windows.Forms.ToolStripMenuItem();
      this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionViewVerses = new System.Windows.Forms.ToolStripButton();
      this.ActionViewTranslations = new System.Windows.Forms.ToolStripButton();
      this.ActionViewVerseFiltered = new System.Windows.Forms.ToolStripButton();
      this.ActionViewSearch = new System.Windows.Forms.ToolStripButton();
      this.Sep2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionViewRawText = new System.Windows.Forms.ToolStripButton();
      this.ActionViewELS50 = new System.Windows.Forms.ToolStripButton();
      this.Sep3 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionGoToReference = new System.Windows.Forms.ToolStripButton();
      this.ActionRefresh = new System.Windows.Forms.ToolStripButton();
      this.Sep4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionDatabase = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionNew = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionRestore = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionBackup = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionVacuum = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionOpenBackupPath = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenExportFolder = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSave = new System.Windows.Forms.ToolStripButton();
      this.sep5 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionTools = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionViewBooksBoard = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionViewParashotBoard = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionShowGrammarGuide = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionOpenHebrewLetters = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionViewBibleStatistics = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionOpenCalculator = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCloseWindows = new System.Windows.Forms.ToolStripMenuItem();
      this.SeparatorImportConcordances = new System.Windows.Forms.ToolStripSeparator();
      this.ActionImportConcordances = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionWebLinks = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionInformation = new System.Windows.Forms.ToolStripDropDownButton();
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
      this.ActionGoToBookmarks = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionImportConsole = new System.Windows.Forms.ToolStripMenuItem();
      this.ContextMenuStripWord = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionWordSearchOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
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
      this.ToolTipSearchResult = new System.Windows.Forms.ToolTip(this.components);
      this.PanelMain.SuspendLayout();
      this.PanelMainOuter.SuspendLayout();
      this.PanelMainInner.SuspendLayout();
      this.PanelMainCenter.SuspendLayout();
      this.TabControl.SuspendLayout();
      this.TabPageVerses.SuspendLayout();
      this.TabPageTranslations.SuspendLayout();
      this.PanelViewTranslations.SuspendLayout();
      this.TabPageVerseFiltered.SuspendLayout();
      this.PanelViewVerseFiltered.SuspendLayout();
      this.PanelViewVerseFilters.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FilterVersesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.FilterChaptersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.FilterBooksBindingSource)).BeginInit();
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
      this.TabPageText.SuspendLayout();
      this.PanelViewOriginalText.SuspendLayout();
      this.TabPageELS50.SuspendLayout();
      this.PanelViewELS50.SuspendLayout();
      this.PanelNavigation.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ChaptersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.VersesBindingSource)).BeginInit();
      this.PanelTitle.SuspendLayout();
      this.PanelTitleInner.SuspendLayout();
      this.ToolStrip.SuspendLayout();
      this.ContextMenuStripVerse.SuspendLayout();
      this.ContextMenuStripWord.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.WordsBindingSource)).BeginInit();
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
      this.TabControl.Controls.Add(this.TabPageVerseFiltered);
      this.TabControl.Controls.Add(this.TabPageSearch);
      this.TabControl.Controls.Add(this.TabPageText);
      this.TabControl.Controls.Add(this.TabPageELS50);
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
      this.PanelViewTranslations.Controls.Add(this.EditChapterTranslation);
      resources.ApplyResources(this.PanelViewTranslations, "PanelViewTranslations");
      this.PanelViewTranslations.Name = "PanelViewTranslations";
      // 
      // EditChapterTranslation
      // 
      this.EditChapterTranslation.BackColor = System.Drawing.SystemColors.Window;
      this.EditChapterTranslation.BorderStyle = System.Windows.Forms.BorderStyle.None;
      resources.ApplyResources(this.EditChapterTranslation, "EditChapterTranslation");
      this.EditChapterTranslation.Name = "EditChapterTranslation";
      this.EditChapterTranslation.ReadOnly = true;
      this.EditChapterTranslation.SelectionAlignment = Ordisoftware.Core.TextAlign.Left;
      // 
      // TabPageVerseFiltered
      // 
      this.TabPageVerseFiltered.Controls.Add(this.PanelViewVerseFiltered);
      resources.ApplyResources(this.TabPageVerseFiltered, "TabPageVerseFiltered");
      this.TabPageVerseFiltered.Name = "TabPageVerseFiltered";
      this.TabPageVerseFiltered.UseVisualStyleBackColor = true;
      // 
      // PanelViewVerseFiltered
      // 
      resources.ApplyResources(this.PanelViewVerseFiltered, "PanelViewVerseFiltered");
      this.PanelViewVerseFiltered.BackColor = System.Drawing.SystemColors.Control;
      this.PanelViewVerseFiltered.Controls.Add(this.PanelViewVerseFilteredSingle);
      this.PanelViewVerseFiltered.Controls.Add(this.PanelViewVerseFilters);
      this.PanelViewVerseFiltered.Name = "PanelViewVerseFiltered";
      // 
      // PanelViewVerseFilteredSingle
      // 
      resources.ApplyResources(this.PanelViewVerseFilteredSingle, "PanelViewVerseFilteredSingle");
      this.PanelViewVerseFilteredSingle.BackColor = System.Drawing.SystemColors.Control;
      this.PanelViewVerseFilteredSingle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PanelViewVerseFilteredSingle.Name = "PanelViewVerseFilteredSingle";
      // 
      // PanelViewVerseFilters
      // 
      this.PanelViewVerseFilters.Controls.Add(this.LabelInfoFilterVerses);
      this.PanelViewVerseFilters.Controls.Add(this.ActionGoFromVerseFilteredToVersesPanel);
      this.PanelViewVerseFilters.Controls.Add(this.ActionApplyFilterVerse);
      this.PanelViewVerseFilters.Controls.Add(this.ActionClearFilterVerse);
      this.PanelViewVerseFilters.Controls.Add(this.ActionApplyFilterChapter);
      this.PanelViewVerseFilters.Controls.Add(this.ActionApplyFilterBook);
      this.PanelViewVerseFilters.Controls.Add(this.ActionClearFilterChapter);
      this.PanelViewVerseFilters.Controls.Add(this.ActionClearFilterBook);
      this.PanelViewVerseFilters.Controls.Add(this.EditFilterVerse);
      this.PanelViewVerseFilters.Controls.Add(this.EditFilterChapter);
      this.PanelViewVerseFilters.Controls.Add(this.EditFilterBook);
      this.PanelViewVerseFilters.Controls.Add(this.EditFilterVersesTranslated);
      this.PanelViewVerseFilters.Controls.Add(this.EditFilterChaptersWithTitle);
      this.PanelViewVerseFilters.Controls.Add(this.SelectFilterVerse);
      this.PanelViewVerseFilters.Controls.Add(this.SelectFilterChapter);
      this.PanelViewVerseFilters.Controls.Add(this.SelectFilterBook);
      this.PanelViewVerseFilters.Controls.Add(this.LabelFilterBook);
      this.PanelViewVerseFilters.Controls.Add(this.LabelFilterChapter);
      this.PanelViewVerseFilters.Controls.Add(this.LabelFilterVerse);
      resources.ApplyResources(this.PanelViewVerseFilters, "PanelViewVerseFilters");
      this.PanelViewVerseFilters.Name = "PanelViewVerseFilters";
      // 
      // LabelInfoFilterVerses
      // 
      resources.ApplyResources(this.LabelInfoFilterVerses, "LabelInfoFilterVerses");
      this.LabelInfoFilterVerses.FlatAppearance.BorderSize = 0;
      this.LabelInfoFilterVerses.Name = "LabelInfoFilterVerses";
      this.LabelInfoFilterVerses.UseVisualStyleBackColor = true;
      this.LabelInfoFilterVerses.Click += new System.EventHandler(this.LabelInfoFilterVerses_Click);
      // 
      // ActionGoFromVerseFilteredToVersesPanel
      // 
      resources.ApplyResources(this.ActionGoFromVerseFilteredToVersesPanel, "ActionGoFromVerseFilteredToVersesPanel");
      this.ActionGoFromVerseFilteredToVersesPanel.FlatAppearance.BorderSize = 0;
      this.ActionGoFromVerseFilteredToVersesPanel.Name = "ActionGoFromVerseFilteredToVersesPanel";
      this.ActionGoFromVerseFilteredToVersesPanel.UseVisualStyleBackColor = true;
      this.ActionGoFromVerseFilteredToVersesPanel.Click += new System.EventHandler(this.ActionGoFromVerseFilteredToVersesPanel_Click);
      // 
      // ActionApplyFilterVerse
      // 
      this.ActionApplyFilterVerse.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionApplyFilterVerse, "ActionApplyFilterVerse");
      this.ActionApplyFilterVerse.Name = "ActionApplyFilterVerse";
      this.ActionApplyFilterVerse.UseVisualStyleBackColor = true;
      this.ActionApplyFilterVerse.Click += new System.EventHandler(this.UpdateFilters);
      // 
      // ActionClearFilterVerse
      // 
      this.ActionClearFilterVerse.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionClearFilterVerse, "ActionClearFilterVerse");
      this.ActionClearFilterVerse.Name = "ActionClearFilterVerse";
      this.ActionClearFilterVerse.UseVisualStyleBackColor = true;
      this.ActionClearFilterVerse.Click += new System.EventHandler(this.ActionClearFilterVerse_Click);
      // 
      // ActionApplyFilterChapter
      // 
      this.ActionApplyFilterChapter.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionApplyFilterChapter, "ActionApplyFilterChapter");
      this.ActionApplyFilterChapter.Name = "ActionApplyFilterChapter";
      this.ActionApplyFilterChapter.UseVisualStyleBackColor = true;
      this.ActionApplyFilterChapter.Click += new System.EventHandler(this.UpdateFilters);
      // 
      // ActionApplyFilterBook
      // 
      this.ActionApplyFilterBook.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionApplyFilterBook, "ActionApplyFilterBook");
      this.ActionApplyFilterBook.Name = "ActionApplyFilterBook";
      this.ActionApplyFilterBook.UseVisualStyleBackColor = true;
      this.ActionApplyFilterBook.Click += new System.EventHandler(this.UpdateFilters);
      // 
      // ActionClearFilterChapter
      // 
      this.ActionClearFilterChapter.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionClearFilterChapter, "ActionClearFilterChapter");
      this.ActionClearFilterChapter.Name = "ActionClearFilterChapter";
      this.ActionClearFilterChapter.UseVisualStyleBackColor = true;
      this.ActionClearFilterChapter.Click += new System.EventHandler(this.ActionClearFilterChapter_Click);
      // 
      // ActionClearFilterBook
      // 
      this.ActionClearFilterBook.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionClearFilterBook, "ActionClearFilterBook");
      this.ActionClearFilterBook.Name = "ActionClearFilterBook";
      this.ActionClearFilterBook.UseVisualStyleBackColor = true;
      this.ActionClearFilterBook.Click += new System.EventHandler(this.ActionClearFilterBook_Click);
      // 
      // EditFilterVerse
      // 
      resources.ApplyResources(this.EditFilterVerse, "EditFilterVerse");
      this.EditFilterVerse.Name = "EditFilterVerse";
      this.EditFilterVerse.TextChanged += new System.EventHandler(this.EditFilter_TextChanged);
      this.EditFilterVerse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditFilterBook_KeyUp);
      this.EditFilterVerse.Leave += new System.EventHandler(this.EditFilter_Leave);
      // 
      // EditFilterChapter
      // 
      resources.ApplyResources(this.EditFilterChapter, "EditFilterChapter");
      this.EditFilterChapter.Name = "EditFilterChapter";
      this.EditFilterChapter.TextChanged += new System.EventHandler(this.EditFilter_TextChanged);
      this.EditFilterChapter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditFilterBook_KeyUp);
      this.EditFilterChapter.Leave += new System.EventHandler(this.EditFilter_Leave);
      // 
      // EditFilterBook
      // 
      resources.ApplyResources(this.EditFilterBook, "EditFilterBook");
      this.EditFilterBook.Name = "EditFilterBook";
      this.EditFilterBook.TextChanged += new System.EventHandler(this.EditFilter_TextChanged);
      this.EditFilterBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditFilterBook_KeyUp);
      this.EditFilterBook.Leave += new System.EventHandler(this.EditFilter_Leave);
      // 
      // EditFilterVersesTranslated
      // 
      resources.ApplyResources(this.EditFilterVersesTranslated, "EditFilterVersesTranslated");
      this.EditFilterVersesTranslated.Name = "EditFilterVersesTranslated";
      this.EditFilterVersesTranslated.UseVisualStyleBackColor = true;
      this.EditFilterVersesTranslated.CheckedChanged += new System.EventHandler(this.UpdateFilters);
      // 
      // EditFilterChaptersWithTitle
      // 
      resources.ApplyResources(this.EditFilterChaptersWithTitle, "EditFilterChaptersWithTitle");
      this.EditFilterChaptersWithTitle.Name = "EditFilterChaptersWithTitle";
      this.EditFilterChaptersWithTitle.UseVisualStyleBackColor = true;
      this.EditFilterChaptersWithTitle.CheckedChanged += new System.EventHandler(this.UpdateFilters);
      // 
      // SelectFilterVerse
      // 
      resources.ApplyResources(this.SelectFilterVerse, "SelectFilterVerse");
      this.SelectFilterVerse.DataSource = this.FilterVersesBindingSource;
      this.SelectFilterVerse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectFilterVerse.DropDownWidth = 500;
      this.SelectFilterVerse.FormattingEnabled = true;
      this.SelectFilterVerse.Name = "SelectFilterVerse";
      this.SelectFilterVerse.SelectedIndexChanged += new System.EventHandler(this.SelectFilterVerse_SelectedIndexChanged);
      // 
      // FilterVersesBindingSource
      // 
      this.FilterVersesBindingSource.DataMember = "Verses";
      this.FilterVersesBindingSource.DataSource = this.FilterChaptersBindingSource;
      // 
      // FilterChaptersBindingSource
      // 
      this.FilterChaptersBindingSource.DataMember = "Chapters";
      this.FilterChaptersBindingSource.DataSource = this.FilterBooksBindingSource;
      // 
      // FilterBooksBindingSource
      // 
      this.FilterBooksBindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.BookRow);
      // 
      // SelectFilterChapter
      // 
      resources.ApplyResources(this.SelectFilterChapter, "SelectFilterChapter");
      this.SelectFilterChapter.DataSource = this.FilterChaptersBindingSource;
      this.SelectFilterChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectFilterChapter.DropDownWidth = 500;
      this.SelectFilterChapter.FormattingEnabled = true;
      this.SelectFilterChapter.Name = "SelectFilterChapter";
      this.SelectFilterChapter.SelectedIndexChanged += new System.EventHandler(this.SelectFilterChapter_SelectedIndexChanged);
      // 
      // SelectFilterBook
      // 
      resources.ApplyResources(this.SelectFilterBook, "SelectFilterBook");
      this.SelectFilterBook.DataSource = this.FilterBooksBindingSource;
      this.SelectFilterBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectFilterBook.DropDownWidth = 500;
      this.SelectFilterBook.FormattingEnabled = true;
      this.SelectFilterBook.Name = "SelectFilterBook";
      this.SelectFilterBook.SelectedIndexChanged += new System.EventHandler(this.SelectFilterBook_SelectedIndexChanged);
      // 
      // LabelFilterBook
      // 
      resources.ApplyResources(this.LabelFilterBook, "LabelFilterBook");
      this.LabelFilterBook.Name = "LabelFilterBook";
      // 
      // LabelFilterChapter
      // 
      resources.ApplyResources(this.LabelFilterChapter, "LabelFilterChapter");
      this.LabelFilterChapter.Name = "LabelFilterChapter";
      // 
      // LabelFilterVerse
      // 
      resources.ApplyResources(this.LabelFilterVerse, "LabelFilterVerse");
      this.LabelFilterVerse.Name = "LabelFilterVerse";
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
      this.ActionSearchRun.Click += new System.EventHandler(this.ActionSearchRun_Click);
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
      resources.ApplyResources(this.SelectSearchType, "SelectSearchType");
      this.SelectSearchType.Name = "SelectSearchType";
      this.SelectSearchType.SelectedIndex = 0;
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
      this.SelectSearchTypeTranslation.Controls.Add(this.SelectSearchTranslationOnlyComments);
      this.SelectSearchTypeTranslation.Controls.Add(this.SelectSearchTranslationOnlyTranslations);
      this.SelectSearchTypeTranslation.Controls.Add(this.SelectSearchTranslationIncludeComments);
      this.SelectSearchTypeTranslation.Controls.Add(this.LabelSearchTranslationHelp);
      this.SelectSearchTypeTranslation.Controls.Add(this.EditSearchTranslation);
      resources.ApplyResources(this.SelectSearchTypeTranslation, "SelectSearchTypeTranslation");
      this.SelectSearchTypeTranslation.Name = "SelectSearchTypeTranslation";
      this.SelectSearchTypeTranslation.UseVisualStyleBackColor = true;
      // 
      // SelectSearchTranslationOnlyComments
      // 
      resources.ApplyResources(this.SelectSearchTranslationOnlyComments, "SelectSearchTranslationOnlyComments");
      this.SelectSearchTranslationOnlyComments.Name = "SelectSearchTranslationOnlyComments";
      this.SelectSearchTranslationOnlyComments.TabStop = true;
      this.SelectSearchTranslationOnlyComments.UseVisualStyleBackColor = true;
      this.SelectSearchTranslationOnlyComments.CheckedChanged += new System.EventHandler(this.SelectSearchTranslationOnlyTranslations_CheckedChanged);
      // 
      // SelectSearchTranslationOnlyTranslations
      // 
      resources.ApplyResources(this.SelectSearchTranslationOnlyTranslations, "SelectSearchTranslationOnlyTranslations");
      this.SelectSearchTranslationOnlyTranslations.Name = "SelectSearchTranslationOnlyTranslations";
      this.SelectSearchTranslationOnlyTranslations.TabStop = true;
      this.SelectSearchTranslationOnlyTranslations.UseVisualStyleBackColor = true;
      this.SelectSearchTranslationOnlyTranslations.CheckedChanged += new System.EventHandler(this.SelectSearchTranslationOnlyTranslations_CheckedChanged);
      // 
      // SelectSearchTranslationIncludeComments
      // 
      resources.ApplyResources(this.SelectSearchTranslationIncludeComments, "SelectSearchTranslationIncludeComments");
      this.SelectSearchTranslationIncludeComments.Name = "SelectSearchTranslationIncludeComments";
      this.SelectSearchTranslationIncludeComments.TabStop = true;
      this.SelectSearchTranslationIncludeComments.UseVisualStyleBackColor = true;
      this.SelectSearchTranslationIncludeComments.CheckedChanged += new System.EventHandler(this.SelectSearchTranslationOnlyTranslations_CheckedChanged);
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
      this.SelectSearchRequestAllUntranslated.CheckedChanged += new System.EventHandler(this.SelectSearchRequestAllTranslated_CheckedChanged);
      // 
      // SelectSearchRequestAllPartiallyTranslated
      // 
      resources.ApplyResources(this.SelectSearchRequestAllPartiallyTranslated, "SelectSearchRequestAllPartiallyTranslated");
      this.SelectSearchRequestAllPartiallyTranslated.Name = "SelectSearchRequestAllPartiallyTranslated";
      this.SelectSearchRequestAllPartiallyTranslated.UseVisualStyleBackColor = true;
      this.SelectSearchRequestAllPartiallyTranslated.CheckedChanged += new System.EventHandler(this.SelectSearchRequestAllTranslated_CheckedChanged);
      // 
      // SelectSearchRequestAllFullyTranslated
      // 
      resources.ApplyResources(this.SelectSearchRequestAllFullyTranslated, "SelectSearchRequestAllFullyTranslated");
      this.SelectSearchRequestAllFullyTranslated.Name = "SelectSearchRequestAllFullyTranslated";
      this.SelectSearchRequestAllFullyTranslated.UseVisualStyleBackColor = true;
      this.SelectSearchRequestAllFullyTranslated.CheckedChanged += new System.EventHandler(this.SelectSearchRequestAllTranslated_CheckedChanged);
      // 
      // SelectSearchRequestAllTranslated
      // 
      resources.ApplyResources(this.SelectSearchRequestAllTranslated, "SelectSearchRequestAllTranslated");
      this.SelectSearchRequestAllTranslated.Checked = true;
      this.SelectSearchRequestAllTranslated.Name = "SelectSearchRequestAllTranslated";
      this.SelectSearchRequestAllTranslated.TabStop = true;
      this.SelectSearchRequestAllTranslated.UseVisualStyleBackColor = true;
      this.SelectSearchRequestAllTranslated.CheckedChanged += new System.EventHandler(this.SelectSearchRequestAllTranslated_CheckedChanged);
      // 
      // TabPageText
      // 
      this.TabPageText.Controls.Add(this.PanelViewOriginalText);
      resources.ApplyResources(this.TabPageText, "TabPageText");
      this.TabPageText.Name = "TabPageText";
      this.TabPageText.UseVisualStyleBackColor = true;
      // 
      // PanelViewOriginalText
      // 
      this.PanelViewOriginalText.BackColor = System.Drawing.SystemColors.Window;
      this.PanelViewOriginalText.Controls.Add(this.EditChapterOriginal);
      resources.ApplyResources(this.PanelViewOriginalText, "PanelViewOriginalText");
      this.PanelViewOriginalText.Name = "PanelViewOriginalText";
      // 
      // EditChapterOriginal
      // 
      this.EditChapterOriginal.BackColor = System.Drawing.SystemColors.Window;
      this.EditChapterOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
      resources.ApplyResources(this.EditChapterOriginal, "EditChapterOriginal");
      this.EditChapterOriginal.Name = "EditChapterOriginal";
      this.EditChapterOriginal.ReadOnly = true;
      this.EditChapterOriginal.SelectionAlignment = Ordisoftware.Core.TextAlign.Left;
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
      this.PanelViewELS50.Controls.Add(this.EditChapterELS50);
      resources.ApplyResources(this.PanelViewELS50, "PanelViewELS50");
      this.PanelViewELS50.Name = "PanelViewELS50";
      // 
      // EditChapterELS50
      // 
      this.EditChapterELS50.BackColor = System.Drawing.SystemColors.Window;
      this.EditChapterELS50.BorderStyle = System.Windows.Forms.BorderStyle.None;
      resources.ApplyResources(this.EditChapterELS50, "EditChapterELS50");
      this.EditChapterELS50.Name = "EditChapterELS50";
      this.EditChapterELS50.ReadOnly = true;
      this.EditChapterELS50.SelectionAlignment = Ordisoftware.Core.TextAlign.Left;
      // 
      // PanelNavigation
      // 
      this.PanelNavigation.Controls.Add(this.EditELS50HScrollBar);
      this.PanelNavigation.Controls.Add(this.SelectChapterNavigator);
      this.PanelNavigation.Controls.Add(this.SelectBookNavigator);
      this.PanelNavigation.Controls.Add(this.ActionSelectRenderAllVersesKeepHelp);
      this.PanelNavigation.Controls.Add(this.SelectVerseNavigator);
      this.PanelNavigation.Controls.Add(this.SelectVerse);
      this.PanelNavigation.Controls.Add(this.SelectRenderAllVersesKeep);
      this.PanelNavigation.Controls.Add(this.SelectRenderAllVerses);
      this.PanelNavigation.Controls.Add(this.EditChapterMemo);
      this.PanelNavigation.Controls.Add(this.LabelChapterMemo);
      this.PanelNavigation.Controls.Add(this.LabelBookTranslation);
      this.PanelNavigation.Controls.Add(this.LabelSelectVerse);
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
      this.PanelNavigation.Controls.Add(this.EditELS50Single);
      this.PanelNavigation.Controls.Add(this.SelectChapter);
      this.PanelNavigation.Controls.Add(this.LabelChapterELS50);
      this.PanelNavigation.Controls.Add(this.LabelSelectBook);
      this.PanelNavigation.Controls.Add(this.LabelSelectChapter);
      resources.ApplyResources(this.PanelNavigation, "PanelNavigation");
      this.PanelNavigation.Name = "PanelNavigation";
      // 
      // EditELS50HScrollBar
      // 
      resources.ApplyResources(this.EditELS50HScrollBar, "EditELS50HScrollBar");
      this.EditELS50HScrollBar.LargeChange = 20;
      this.EditELS50HScrollBar.Maximum = 0;
      this.EditELS50HScrollBar.Minimum = -100;
      this.EditELS50HScrollBar.Name = "EditELS50HScrollBar";
      this.EditELS50HScrollBar.SmallChange = 10;
      this.EditELS50HScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.EditELS50HScrollBar_Scroll);
      // 
      // SelectChapterNavigator
      // 
      resources.ApplyResources(this.SelectChapterNavigator, "SelectChapterNavigator");
      this.SelectChapterNavigator.ComboBox = this.SelectChapter;
      this.SelectChapterNavigator.KeepFocus = false;
      this.SelectChapterNavigator.Name = "SelectChapterNavigator";
      this.SelectChapterNavigator.SelectedIndex = -1;
      this.SelectChapterNavigator.SelectedItem = null;
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
      // ChaptersBindingSource
      // 
      this.ChaptersBindingSource.DataMember = "Chapters";
      this.ChaptersBindingSource.DataSource = this.BooksBindingSource;
      this.ChaptersBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.ChaptersBindingSource_ListChanged);
      this.ChaptersBindingSource.PositionChanged += new System.EventHandler(this.ChaptersBindingSource_PositionChanged);
      // 
      // BooksBindingSource
      // 
      this.BooksBindingSource.DataSource = typeof(Ordisoftware.Hebrew.Words.BookRow);
      this.BooksBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.BookRowBindingSource_ListChanged);
      this.BooksBindingSource.PositionChanged += new System.EventHandler(this.BookRowBindingSource_PositionChanged);
      // 
      // SelectBookNavigator
      // 
      resources.ApplyResources(this.SelectBookNavigator, "SelectBookNavigator");
      this.SelectBookNavigator.ComboBox = this.SelectBook;
      this.SelectBookNavigator.KeepFocus = false;
      this.SelectBookNavigator.Name = "SelectBookNavigator";
      this.SelectBookNavigator.SelectedIndex = -1;
      this.SelectBookNavigator.SelectedItem = null;
      // 
      // SelectBook
      // 
      this.SelectBook.DataSource = this.BooksBindingSource;
      this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.SelectBook, "SelectBook");
      this.SelectBook.FormattingEnabled = true;
      this.SelectBook.Name = "SelectBook";
      this.SelectBook.SelectedIndexChanged += new System.EventHandler(this.SelectBook_SelectedIndexChanged);
      // 
      // ActionSelectRenderAllVersesKeepHelp
      // 
      resources.ApplyResources(this.ActionSelectRenderAllVersesKeepHelp, "ActionSelectRenderAllVersesKeepHelp");
      this.ActionSelectRenderAllVersesKeepHelp.FlatAppearance.BorderSize = 0;
      this.ActionSelectRenderAllVersesKeepHelp.Name = "ActionSelectRenderAllVersesKeepHelp";
      this.ActionSelectRenderAllVersesKeepHelp.UseVisualStyleBackColor = true;
      this.ActionSelectRenderAllVersesKeepHelp.Click += new System.EventHandler(this.ActionSelectRenderAllVersesKeepHelp_Click);
      // 
      // SelectVerseNavigator
      // 
      resources.ApplyResources(this.SelectVerseNavigator, "SelectVerseNavigator");
      this.SelectVerseNavigator.ComboBox = this.SelectVerse;
      this.SelectVerseNavigator.KeepFocus = false;
      this.SelectVerseNavigator.Name = "SelectVerseNavigator";
      this.SelectVerseNavigator.SelectedIndex = -1;
      this.SelectVerseNavigator.SelectedItem = null;
      // 
      // SelectVerse
      // 
      this.SelectVerse.DataSource = this.VersesBindingSource;
      this.SelectVerse.DisplayMember = "Number";
      this.SelectVerse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectVerse.FormattingEnabled = true;
      resources.ApplyResources(this.SelectVerse, "SelectVerse");
      this.SelectVerse.Name = "SelectVerse";
      this.SelectVerse.SelectedIndexChanged += new System.EventHandler(this.SelectVerse_SelectedIndexChanged);
      // 
      // VersesBindingSource
      // 
      this.VersesBindingSource.DataMember = "Verses";
      this.VersesBindingSource.DataSource = this.ChaptersBindingSource;
      // 
      // SelectRenderAllVersesKeep
      // 
      resources.ApplyResources(this.SelectRenderAllVersesKeep, "SelectRenderAllVersesKeep");
      this.SelectRenderAllVersesKeep.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.RenderAllChapterVersesKeep;
      this.SelectRenderAllVersesKeep.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "RenderAllChapterVersesKeep", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectRenderAllVersesKeep.Name = "SelectRenderAllVersesKeep";
      this.SelectRenderAllVersesKeep.UseVisualStyleBackColor = true;
      // 
      // SelectRenderAllVerses
      // 
      resources.ApplyResources(this.SelectRenderAllVerses, "SelectRenderAllVerses");
      this.SelectRenderAllVerses.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.RenderAllChapterVerses;
      this.SelectRenderAllVerses.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "RenderAllChapterVerses", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.SelectRenderAllVerses.Name = "SelectRenderAllVerses";
      this.SelectRenderAllVerses.UseVisualStyleBackColor = true;
      this.SelectRenderAllVerses.CheckedChanged += new System.EventHandler(this.SelectRenderAllVerses_CheckedChanged);
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
      // LabelSelectVerse
      // 
      resources.ApplyResources(this.LabelSelectVerse, "LabelSelectVerse");
      this.LabelSelectVerse.Name = "LabelSelectVerse";
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
      // EditBookTranslation
      // 
      this.EditBookTranslation.BackColor = System.Drawing.Color.LightYellow;
      this.EditBookTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditBookTranslation.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditBookTranslation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BooksBindingSource, "Translation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
      // EditELS50Single
      // 
      resources.ApplyResources(this.EditELS50Single, "EditELS50Single");
      this.EditELS50Single.BackColor = System.Drawing.Color.LightYellow;
      this.EditELS50Single.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditELS50Single.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditELS50Single.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ChaptersBindingSource, "ELS50", true));
      this.EditELS50Single.Name = "EditELS50Single";
      this.EditELS50Single.ReadOnly = true;
      this.EditELS50Single.TextChanged += new System.EventHandler(this.EditELS50_TextChanged);
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
      this.PanelTitle.Controls.Add(this.PanelTitleInner);
      resources.ApplyResources(this.PanelTitle, "PanelTitle");
      this.PanelTitle.Name = "PanelTitle";
      // 
      // PanelTitleInner
      // 
      this.PanelTitleInner.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.PanelTitleInner.Controls.Add(this.LabelTitleReferenceName);
      this.PanelTitleInner.Controls.Add(this.LabelTitle);
      this.PanelTitleInner.Controls.Add(this.LabelProgress);
      resources.ApplyResources(this.PanelTitleInner, "PanelTitleInner");
      this.PanelTitleInner.Name = "PanelTitleInner";
      // 
      // LabelTitleReferenceName
      // 
      this.LabelTitleReferenceName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      resources.ApplyResources(this.LabelTitleReferenceName, "LabelTitleReferenceName");
      this.LabelTitleReferenceName.Name = "LabelTitleReferenceName";
      // 
      // LabelTitle
      // 
      this.LabelTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      resources.ApplyResources(this.LabelTitle, "LabelTitle");
      this.LabelTitle.Name = "LabelTitle";
      // 
      // LabelProgress
      // 
      this.LabelProgress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      resources.ApplyResources(this.LabelProgress, "LabelProgress");
      this.LabelProgress.Name = "LabelProgress";
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
            this.ActionExit,
            this.SepExit,
            this.ActionPreferences,
            this.ActionBookmarks,
            this.ActionHistory,
            this.Sep1,
            this.ActionViewVerses,
            this.ActionViewTranslations,
            this.ActionViewVerseFiltered,
            this.ActionViewSearch,
            this.Sep2,
            this.ActionViewRawText,
            this.ActionViewELS50,
            this.Sep3,
            this.ActionGoToReference,
            this.ActionRefresh,
            this.Sep4,
            this.ActionDatabase,
            this.ActionSave,
            this.sep5,
            this.ActionTools,
            this.ActionWebLinks,
            this.ActionInformation,
            this.ActionSettings});
      this.ToolStrip.Name = "ToolStrip";
      this.ToolStrip.ShowItemToolTips = false;
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
      // SepExit
      // 
      this.SepExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.SepExit.Name = "SepExit";
      resources.ApplyResources(this.SepExit, "SepExit");
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
      // ActionBookmarks
      // 
      this.ActionBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionBookmarks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionSortBookmarks,
            this.ActionAddBookmark,
            this.ActionClearBookmarks,
            this.toolStripSeparator8,
            this.ActionGoToBookmarkMain,
            this.toolStripSeparator12});
      resources.ApplyResources(this.ActionBookmarks, "ActionBookmarks");
      this.ActionBookmarks.Name = "ActionBookmarks";
      this.ActionBookmarks.Padding = new System.Windows.Forms.Padding(5);
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
      // ActionHistory
      // 
      this.ActionHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionClearHistory});
      resources.ApplyResources(this.ActionHistory, "ActionHistory");
      this.ActionHistory.Name = "ActionHistory";
      this.ActionHistory.Padding = new System.Windows.Forms.Padding(5);
      // 
      // ActionClearHistory
      // 
      resources.ApplyResources(this.ActionClearHistory, "ActionClearHistory");
      this.ActionClearHistory.Name = "ActionClearHistory";
      // 
      // Sep1
      // 
      this.Sep1.Name = "Sep1";
      resources.ApplyResources(this.Sep1, "Sep1");
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
      // ActionViewVerseFiltered
      // 
      this.ActionViewVerseFiltered.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewVerseFiltered, "ActionViewVerseFiltered");
      this.ActionViewVerseFiltered.Name = "ActionViewVerseFiltered";
      this.ActionViewVerseFiltered.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewVerseFiltered.Click += new System.EventHandler(this.ActionViewFilters_Click);
      this.ActionViewVerseFiltered.MouseEnter += new System.EventHandler(this.ShowToolTip_OnMouseEnter);
      this.ActionViewVerseFiltered.MouseLeave += new System.EventHandler(this.ShowToolTip_OnMouseLeave);
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
      // Sep2
      // 
      this.Sep2.Name = "Sep2";
      resources.ApplyResources(this.Sep2, "Sep2");
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
      // Sep3
      // 
      this.Sep3.Name = "Sep3";
      resources.ApplyResources(this.Sep3, "Sep3");
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
      // Sep4
      // 
      this.Sep4.Name = "Sep4";
      resources.ApplyResources(this.Sep4, "Sep4");
      // 
      // ActionDatabase
      // 
      this.ActionDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionNew,
            this.ActionRestore,
            this.ActionBackup,
            this.toolStripSeparator5,
            this.ActionVacuum,
            this.ActionOpenBackupPath,
            this.toolStripSeparator2,
            this.ActionOpenExportFolder});
      resources.ApplyResources(this.ActionDatabase, "ActionDatabase");
      this.ActionDatabase.Name = "ActionDatabase";
      this.ActionDatabase.Padding = new System.Windows.Forms.Padding(5);
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
      // ActionOpenBackupPath
      // 
      resources.ApplyResources(this.ActionOpenBackupPath, "ActionOpenBackupPath");
      this.ActionOpenBackupPath.Name = "ActionOpenBackupPath";
      this.ActionOpenBackupPath.Click += new System.EventHandler(this.ActionOpenBackupPath_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
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
      // sep5
      // 
      this.sep5.Name = "sep5";
      resources.ApplyResources(this.sep5, "sep5");
      // 
      // ActionTools
      // 
      resources.ApplyResources(this.ActionTools, "ActionTools");
      this.ActionTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ActionTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionViewBooksBoard,
            this.ActionViewParashotBoard,
            this.toolStripSeparator6,
            this.ActionShowGrammarGuide,
            this.ActionOpenHebrewLetters,
            this.toolStripSeparator16,
            this.ActionViewBibleStatistics,
            this.ActionOpenCalculator,
            this.toolStripSeparator1,
            this.ActionCopyToClipboard,
            this.ActionCloseWindows,
            this.SeparatorImportConcordances,
            this.ActionImportConcordances});
      this.ActionTools.Name = "ActionTools";
      this.ActionTools.Padding = new System.Windows.Forms.Padding(5);
      // 
      // ActionViewBooksBoard
      // 
      resources.ApplyResources(this.ActionViewBooksBoard, "ActionViewBooksBoard");
      this.ActionViewBooksBoard.Name = "ActionViewBooksBoard";
      this.ActionViewBooksBoard.Click += new System.EventHandler(this.ActionViewBooksTranslation_Click);
      // 
      // ActionViewParashotBoard
      // 
      resources.ApplyResources(this.ActionViewParashotBoard, "ActionViewParashotBoard");
      this.ActionViewParashotBoard.Name = "ActionViewParashotBoard";
      this.ActionViewParashotBoard.Click += new System.EventHandler(this.ActionViewParashot_Click);
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
      // ActionCopyToClipboard
      // 
      resources.ApplyResources(this.ActionCopyToClipboard, "ActionCopyToClipboard");
      this.ActionCopyToClipboard.Name = "ActionCopyToClipboard";
      this.ActionCopyToClipboard.Click += new System.EventHandler(this.ActionCopyToClipboard_Click);
      // 
      // ActionViewBibleStatistics
      // 
      resources.ApplyResources(this.ActionViewBibleStatistics, "ActionViewBibleStatistics");
      this.ActionViewBibleStatistics.Name = "ActionViewBibleStatistics";
      this.ActionViewBibleStatistics.Click += new System.EventHandler(this.ActionViewBibleStatistics_Click);
      // 
      // ActionOpenCalculator
      // 
      this.ActionOpenCalculator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      resources.ApplyResources(this.ActionOpenCalculator, "ActionOpenCalculator");
      this.ActionOpenCalculator.Name = "ActionOpenCalculator";
      this.ActionOpenCalculator.Click += new System.EventHandler(this.ActionOpenCalculator_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      // 
      // ActionCloseWindows
      // 
      resources.ApplyResources(this.ActionCloseWindows, "ActionCloseWindows");
      this.ActionCloseWindows.Name = "ActionCloseWindows";
      this.ActionCloseWindows.Click += new System.EventHandler(this.ActionCloseWindows_Click);
      // 
      // SeparatorImportConcordances
      // 
      this.SeparatorImportConcordances.Name = "SeparatorImportConcordances";
      resources.ApplyResources(this.SeparatorImportConcordances, "SeparatorImportConcordances");
      // 
      // ActionImportConcordances
      // 
      resources.ApplyResources(this.ActionImportConcordances, "ActionImportConcordances");
      this.ActionImportConcordances.Name = "ActionImportConcordances";
      this.ActionImportConcordances.Click += new System.EventHandler(this.ActionImportConcordances_Click);
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
      this.EditConfirmClosing.Checked = true;
      this.EditConfirmClosing.CheckOnClick = true;
      this.EditConfirmClosing.CheckState = System.Windows.Forms.CheckState.Checked;
      resources.ApplyResources(this.EditConfirmClosing, "EditConfirmClosing");
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
            this.ActionGoToBookmarks,
            this.toolStripMenuItem4,
            this.ActionImportConsole});
      this.ContextMenuStripVerse.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStripVerse, "ContextMenuStripVerse");
      this.ContextMenuStripVerse.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripVerse_Opening);
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
      // ActionGoToBookmarks
      // 
      resources.ApplyResources(this.ActionGoToBookmarks, "ActionGoToBookmarks");
      this.ActionGoToBookmarks.Name = "ActionGoToBookmarks";
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
            this.toolStripSeparator10,
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
      // 
      // toolStripSeparator10
      // 
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
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
      this.ActionSearchWord.Click += new System.EventHandler(this.ActionSearchWord_Click);
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
      this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
      this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
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
      this.TabPageVerseFiltered.ResumeLayout(false);
      this.PanelViewVerseFiltered.ResumeLayout(false);
      this.PanelViewVerseFilters.ResumeLayout(false);
      this.PanelViewVerseFilters.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FilterVersesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.FilterChaptersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.FilterBooksBindingSource)).EndInit();
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
      this.TabPageText.ResumeLayout(false);
      this.PanelViewOriginalText.ResumeLayout(false);
      this.TabPageELS50.ResumeLayout(false);
      this.PanelViewELS50.ResumeLayout(false);
      this.PanelNavigation.ResumeLayout(false);
      this.PanelNavigation.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ChaptersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.VersesBindingSource)).EndInit();
      this.PanelTitle.ResumeLayout(false);
      this.PanelTitleInner.ResumeLayout(false);
      this.ToolStrip.ResumeLayout(false);
      this.ToolStrip.PerformLayout();
      this.ContextMenuStripVerse.ResumeLayout(false);
      this.ContextMenuStripWord.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.WordsBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    internal BindingSource BooksBindingSource;
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
    internal System.Windows.Forms.ContextMenuStrip ContextMenuStripVerse;
    internal System.Windows.Forms.ContextMenuStrip ContextMenuStripWord;
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
    private System.Windows.Forms.Panel PanelViewOriginalText;
    private System.Windows.Forms.Panel PanelViewSearch;
    private System.Windows.Forms.Panel PanelViewSearchSeparator;
    private System.Windows.Forms.Panel PanelViewTranslations;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllFullyTranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllPartiallyTranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllTranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllUntranslated;
    private Ordisoftware.Core.RichTextBoxEx EditChapterELS50;
    private Ordisoftware.Core.RichTextBoxEx EditChapterOriginal;
    private Ordisoftware.Core.RichTextBoxEx EditChapterTranslation;
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
    private Ordisoftware.Core.TextBoxEx EditELS50Single;
    private System.Windows.Forms.TextBox EditSearchPaging;
    private System.Windows.Forms.Timer TimerTooltip;
    private System.Windows.Forms.ToolStripButton ActionExit;
    private System.Windows.Forms.ToolStripButton ActionGoToReference;
    private System.Windows.Forms.ToolStripButton ActionPreferences;
    private System.Windows.Forms.ToolStripButton ActionViewELS50;
    private System.Windows.Forms.ToolStripButton ActionViewRawText;
    private System.Windows.Forms.ToolStripButton ActionViewSearch;
    private System.Windows.Forms.ToolStripButton ActionViewTranslations;
    private System.Windows.Forms.ToolStripButton ActionViewVerses;
    private System.Windows.Forms.ToolStripDropDownButton ActionWebLinks;
    private System.Windows.Forms.ToolStripDropDownButton ActionBookmarks;
    private System.Windows.Forms.ToolStripDropDownButton ActionDatabase;
    private System.Windows.Forms.ToolStripDropDownButton ActionTools;
    private System.Windows.Forms.ToolStripMenuItem ActionAddBookmark;
    private System.Windows.Forms.ToolStripMenuItem ActionGoToBookmarks;
    private System.Windows.Forms.ToolStripMenuItem ActionBackup;
    private System.Windows.Forms.ToolStripMenuItem ActionClearBookmarks;
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
    private System.Windows.Forms.ToolStripMenuItem ActionViewBooksBoard;
    private System.Windows.Forms.ToolStripSeparator MenuSeparator1;
    private System.Windows.Forms.ToolStripSeparator MenuSeparator2;
    private System.Windows.Forms.ToolStripSeparator SepExit;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    private System.Windows.Forms.ToolStripSeparator Sep1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator Sep3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripSeparator Sep4;
    private System.Windows.Forms.TrackBar SelectSearchPaging;
    private ToolStripMenuItem ActionOpenExportFolder;
    public Ordisoftware.Hebrew.LettersControl EditLetters;
    public System.Windows.Forms.Button ActionSearchRun;
    public System.Windows.Forms.Panel PanelViewVerses;
    public System.Windows.Forms.TabControl SelectSearchType;
    public System.Windows.Forms.TabPage SelectSearchTypeHebrew;
    public System.Windows.Forms.Timer TimerAutoSave;
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
    internal ToolStripMenuItem ActionViewParashotBoard;
    private ToolStripMenuItem ActionOpenCalculator;
    private RadioButton SelectSearchTranslationIncludeComments;
    private RadioButton SelectSearchTranslationOnlyComments;
    private RadioButton SelectSearchTranslationOnlyTranslations;
    private TabPage TabPageVerseFiltered;
    private ToolStripButton ActionViewVerseFiltered;
    public System.Windows.Forms.Panel PanelViewVerseFiltered;
    private ToolStripSeparator Sep2;
    private ComboBox SelectVerse;
    private ComboBoxNavigator SelectVerseNavigator;
    private BindingSource FilterBooksBindingSource;
    private BindingSource FilterChaptersBindingSource;
    private BindingSource FilterVersesBindingSource;
    private Panel PanelViewVerseFilters;
    public Button ActionClearFilterVerse;
    public Button ActionClearFilterChapter;
    public Button ActionClearFilterBook;
    private TextBox EditFilterVerse;
    private TextBox EditFilterChapter;
    private TextBox EditFilterBook;
    private CheckBox EditFilterVersesTranslated;
    private CheckBox EditFilterChaptersWithTitle;
    private ComboBox SelectFilterVerse;
    private ComboBox SelectFilterChapter;
    private ComboBox SelectFilterBook;
    private Label LabelFilterBook;
    private Label LabelFilterChapter;
    private Label LabelFilterVerse;
    private Button ActionGoFromVerseFilteredToVersesPanel;
    public Button ActionApplyFilterVerse;
    public Button ActionApplyFilterChapter;
    public Button ActionApplyFilterBook;
    public System.Windows.Forms.Panel PanelViewVerseFilteredSingle;
    private ToolStripSeparator toolStripSeparator10;
    private Button LabelInfoFilterVerses;
    private CheckBox SelectRenderAllVersesKeep;
    private Button ActionSelectRenderAllVersesKeepHelp;
    private Label LabelTitleReferenceName;
    private ToolTip ToolTipSearchResult;
    private ComboBoxNavigator SelectChapterNavigator;
    private ComboBoxNavigator SelectBookNavigator;
    private Label LabelSelectVerse;
    private HScrollBar EditELS50HScrollBar;
    internal CheckBox SelectRenderAllVerses;
    internal ToolStripButton ActionRefresh;
    private ToolStripMenuItem ActionCopyToClipboard;
    private ToolStripMenuItem ActionImportConcordances;
    private ToolStripSeparator SeparatorImportConcordances;
    private ToolStripSeparator sep5;
    internal ToolStripMenuItem ActionCloseWindows;
    private ToolStripMenuItem ActionAddToBookmarks;
    private Panel PanelTitleInner;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripDropDownButton ActionHistory;
    private ToolStripMenuItem ActionClearHistory;
  }
}

