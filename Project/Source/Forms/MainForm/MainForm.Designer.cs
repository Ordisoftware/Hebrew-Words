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
      this.PanelSearchResults = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.PanelSearchFilters = new System.Windows.Forms.Panel();
      this.PanelSearchFiltersRight = new System.Windows.Forms.Panel();
      this.LabelSearchCount = new System.Windows.Forms.Label();
      this.TrackBarSearchPaging = new System.Windows.Forms.TrackBar();
      this.EditSearchPaging = new System.Windows.Forms.TextBox();
      this.EditSearchOnlyTorah = new System.Windows.Forms.CheckBox();
      this.ActionSearchWord = new System.Windows.Forms.Button();
      this.ActionNavigateFirst = new System.Windows.Forms.Button();
      this.ActionNavigatePrevious = new System.Windows.Forms.Button();
      this.ActionNavigateNext = new System.Windows.Forms.Button();
      this.ActionNavigateLast = new System.Windows.Forms.Button();
      this.ActionClearWord = new System.Windows.Forms.Button();
      this.SelectSearchType = new System.Windows.Forms.TabControl();
      this.SelectSearchTypeHebrew = new System.Windows.Forms.TabPage();
      this.PanelSearchTop = new System.Windows.Forms.Panel();
      this.SelectSearchTypeTranslation = new System.Windows.Forms.TabPage();
      this.label2 = new System.Windows.Forms.Label();
      this.EditSearchTranslation = new System.Windows.Forms.TextBox();
      this.SelectSearchTypeRequest = new System.Windows.Forms.TabPage();
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
      this.label1 = new System.Windows.Forms.Label();
      this.TimerTooltip = new System.Windows.Forms.Timer(this.components);
      this.ToolStrip = new System.Windows.Forms.ToolStrip();
      this.MenuBookmarks = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionClearBookmarks = new System.Windows.Forms.ToolStripMenuItem();
      this.menusep = new System.Windows.Forms.ToolStripSeparator();
      this.MenuHistory = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCloseWindows = new System.Windows.Forms.ToolStripButton();
      this.ActionRefresh = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
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
      this.ActionOpenTanakMP3 = new System.Windows.Forms.ToolStripMenuItem();
      this.bibleFourmilabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bibleBiblehubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tanakOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.euangélionOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.quranCorpusqurancomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.shorashonLexicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuTools = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionViewBooksTranslation = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionViewStatistics = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionShowGrammarGuide = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuDatabase = new System.Windows.Forms.ToolStripDropDownButton();
      this.ActionNew = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionRestore = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionBackup = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionOpenBackupPath = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopyToClipboard = new System.Windows.Forms.ToolStripButton();
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
      this.SaveFileDialogWord = new System.Windows.Forms.SaveFileDialog();
      this.SaveFileDialogDB = new System.Windows.Forms.SaveFileDialog();
      this.OpenFileDialogDB = new System.Windows.Forms.OpenFileDialog();
      this.SaveFileDialogRTF = new System.Windows.Forms.SaveFileDialog();
      this.TimerAutoSave = new System.Windows.Forms.Timer(this.components);
      this.ContextMenuStripVerse = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionOpenVerseOnline = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionExportVerse = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionCopyTranslation = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionSetAsBookmarkMaster = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionAddToBookmarks = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionImportConsole = new System.Windows.Forms.ToolStripMenuItem();
      this.EditLetters = new Ordisoftware.HebrewWords.LettersControl();
      this.BooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DataSet = new Ordisoftware.HebrewWords.Data.DataSet();
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
      this.PanelSearchFilters.SuspendLayout();
      this.PanelSearchFiltersRight.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TrackBarSearchPaging)).BeginInit();
      this.SelectSearchType.SuspendLayout();
      this.SelectSearchTypeHebrew.SuspendLayout();
      this.PanelSearchTop.SuspendLayout();
      this.SelectSearchTypeTranslation.SuspendLayout();
      this.SelectSearchTypeRequest.SuspendLayout();
      this.PanelNavigation.SuspendLayout();
      this.PanelTitle.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.WordsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.VersesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChaptersBindingSource)).BeginInit();
      this.ToolStrip.SuspendLayout();
      this.ContextMenuStripVerse.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
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
      this.PanelMainInner.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.PanelMainInner.Controls.Add(this.PanelMainCenter);
      resources.ApplyResources(this.PanelMainInner, "PanelMainInner");
      this.PanelMainInner.Name = "PanelMainInner";
      // 
      // PanelMainCenter
      // 
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
      this.PanelViewSearch.Controls.Add(this.PanelSearchResults);
      this.PanelViewSearch.Controls.Add(this.panel1);
      this.PanelViewSearch.Controls.Add(this.PanelSearchFilters);
      resources.ApplyResources(this.PanelViewSearch, "PanelViewSearch");
      this.PanelViewSearch.Name = "PanelViewSearch";
      // 
      // PanelSearchResults
      // 
      resources.ApplyResources(this.PanelSearchResults, "PanelSearchResults");
      this.PanelSearchResults.BackColor = System.Drawing.SystemColors.Window;
      this.PanelSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
      this.PanelSearchFilters.Controls.Add(this.PanelSearchFiltersRight);
      this.PanelSearchFilters.Controls.Add(this.SelectSearchType);
      resources.ApplyResources(this.PanelSearchFilters, "PanelSearchFilters");
      this.PanelSearchFilters.Name = "PanelSearchFilters";
      // 
      // PanelSearchFiltersRight
      // 
      this.PanelSearchFiltersRight.Controls.Add(this.LabelSearchCount);
      this.PanelSearchFiltersRight.Controls.Add(this.TrackBarSearchPaging);
      this.PanelSearchFiltersRight.Controls.Add(this.EditSearchPaging);
      this.PanelSearchFiltersRight.Controls.Add(this.EditSearchOnlyTorah);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionSearchWord);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionNavigateFirst);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionNavigatePrevious);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionNavigateNext);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionNavigateLast);
      this.PanelSearchFiltersRight.Controls.Add(this.ActionClearWord);
      resources.ApplyResources(this.PanelSearchFiltersRight, "PanelSearchFiltersRight");
      this.PanelSearchFiltersRight.Name = "PanelSearchFiltersRight";
      // 
      // LabelSearchCount
      // 
      resources.ApplyResources(this.LabelSearchCount, "LabelSearchCount");
      this.LabelSearchCount.Name = "LabelSearchCount";
      // 
      // TrackBarSearchPaging
      // 
      resources.ApplyResources(this.TrackBarSearchPaging, "TrackBarSearchPaging");
      this.TrackBarSearchPaging.Maximum = 1;
      this.TrackBarSearchPaging.Minimum = 1;
      this.TrackBarSearchPaging.Name = "TrackBarSearchPaging";
      this.TrackBarSearchPaging.TickStyle = System.Windows.Forms.TickStyle.None;
      this.TrackBarSearchPaging.Value = 1;
      this.TrackBarSearchPaging.ValueChanged += new System.EventHandler(this.TrackBarSearchPaging_ValueChanged);
      this.TrackBarSearchPaging.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBarSearchPaging_MouseDown);
      this.TrackBarSearchPaging.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBarSearchPaging_MouseUp);
      // 
      // EditSearchPaging
      // 
      resources.ApplyResources(this.EditSearchPaging, "EditSearchPaging");
      this.EditSearchPaging.Name = "EditSearchPaging";
      this.EditSearchPaging.ReadOnly = true;
      // 
      // EditSearchOnlyTorah
      // 
      resources.ApplyResources(this.EditSearchOnlyTorah, "EditSearchOnlyTorah");
      this.EditSearchOnlyTorah.Checked = global::Ordisoftware.HebrewWords.Properties.Settings.Default.SearchOnlyInTorah;
      this.EditSearchOnlyTorah.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditSearchOnlyTorah.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "SearchOnlyInTorah", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditSearchOnlyTorah.Name = "EditSearchOnlyTorah";
      this.EditSearchOnlyTorah.UseVisualStyleBackColor = true;
      // 
      // ActionSearchWord
      // 
      resources.ApplyResources(this.ActionSearchWord, "ActionSearchWord");
      this.ActionSearchWord.FlatAppearance.BorderSize = 0;
      this.ActionSearchWord.Name = "ActionSearchWord";
      this.ActionSearchWord.UseVisualStyleBackColor = true;
      this.ActionSearchWord.Click += new System.EventHandler(this.ActionSearchWord_Click);
      // 
      // ActionNavigateFirst
      // 
      resources.ApplyResources(this.ActionNavigateFirst, "ActionNavigateFirst");
      this.ActionNavigateFirst.FlatAppearance.BorderSize = 0;
      this.ActionNavigateFirst.Name = "ActionNavigateFirst";
      this.ActionNavigateFirst.UseVisualStyleBackColor = true;
      this.ActionNavigateFirst.Click += new System.EventHandler(this.ActionNavigateFirst_Click);
      // 
      // ActionNavigatePrevious
      // 
      resources.ApplyResources(this.ActionNavigatePrevious, "ActionNavigatePrevious");
      this.ActionNavigatePrevious.FlatAppearance.BorderSize = 0;
      this.ActionNavigatePrevious.Name = "ActionNavigatePrevious";
      this.ActionNavigatePrevious.UseVisualStyleBackColor = true;
      this.ActionNavigatePrevious.Click += new System.EventHandler(this.ActionNavigatePrevious_Click);
      // 
      // ActionNavigateNext
      // 
      resources.ApplyResources(this.ActionNavigateNext, "ActionNavigateNext");
      this.ActionNavigateNext.FlatAppearance.BorderSize = 0;
      this.ActionNavigateNext.Name = "ActionNavigateNext";
      this.ActionNavigateNext.UseVisualStyleBackColor = true;
      this.ActionNavigateNext.Click += new System.EventHandler(this.ActionNavigateNext_Click);
      // 
      // ActionNavigateLast
      // 
      resources.ApplyResources(this.ActionNavigateLast, "ActionNavigateLast");
      this.ActionNavigateLast.FlatAppearance.BorderSize = 0;
      this.ActionNavigateLast.Name = "ActionNavigateLast";
      this.ActionNavigateLast.UseVisualStyleBackColor = true;
      this.ActionNavigateLast.Click += new System.EventHandler(this.ActionNavigateLast_Click);
      // 
      // ActionClearWord
      // 
      resources.ApplyResources(this.ActionClearWord, "ActionClearWord");
      this.ActionClearWord.FlatAppearance.BorderSize = 0;
      this.ActionClearWord.Name = "ActionClearWord";
      this.ActionClearWord.UseVisualStyleBackColor = true;
      this.ActionClearWord.Click += new System.EventHandler(this.ActionClearWord_Click);
      // 
      // SelectSearchType
      // 
      this.SelectSearchType.Controls.Add(this.SelectSearchTypeHebrew);
      this.SelectSearchType.Controls.Add(this.SelectSearchTypeTranslation);
      this.SelectSearchType.Controls.Add(this.SelectSearchTypeRequest);
      this.SelectSearchType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", global::Ordisoftware.HebrewWords.Properties.Settings.Default, "CurrentSearchTypeTab", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      resources.ApplyResources(this.SelectSearchType, "SelectSearchType");
      this.SelectSearchType.Name = "SelectSearchType";
      this.SelectSearchType.SelectedIndex = global::Ordisoftware.HebrewWords.Properties.Settings.Default.CurrentSearchTypeTab;
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
      // SelectSearchTypeTranslation
      // 
      this.SelectSearchTypeTranslation.Controls.Add(this.label2);
      this.SelectSearchTypeTranslation.Controls.Add(this.EditSearchTranslation);
      resources.ApplyResources(this.SelectSearchTypeTranslation, "SelectSearchTypeTranslation");
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
      this.EditSearchTranslation.BackColor = System.Drawing.Color.AliceBlue;
      this.EditSearchTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditSearchTranslation, "EditSearchTranslation");
      this.EditSearchTranslation.Name = "EditSearchTranslation";
      this.EditSearchTranslation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PanelLetterSearch_KeyPress);
      // 
      // SelectSearchTypeRequest
      // 
      this.SelectSearchTypeRequest.Controls.Add(this.SelectSearchRequestAllUntranslated);
      this.SelectSearchTypeRequest.Controls.Add(this.SelectSearchRequestAllPartiallyTranslated);
      this.SelectSearchTypeRequest.Controls.Add(this.SelectSearchRequestAllFullyTranslated);
      this.SelectSearchTypeRequest.Controls.Add(this.SelectSearchRequestAllTranslated);
      resources.ApplyResources(this.SelectSearchTypeRequest, "SelectSearchTypeRequest");
      this.SelectSearchTypeRequest.Name = "SelectSearchTypeRequest";
      this.SelectSearchTypeRequest.UseVisualStyleBackColor = true;
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
      resources.ApplyResources(this.PanelNavigation, "PanelNavigation");
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
      this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.SelectBook, "SelectBook");
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
      this.SelectChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.SelectChapter, "SelectChapter");
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
      this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.PanelTitle.Controls.Add(this.LabelTitle);
      resources.ApplyResources(this.PanelTitle, "PanelTitle");
      this.PanelTitle.Name = "PanelTitle";
      // 
      // LabelTitle
      // 
      this.LabelTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      resources.ApplyResources(this.LabelTitle, "LabelTitle");
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
            this.MenuBookmarks,
            this.ActionCloseWindows,
            this.ActionRefresh,
            this.toolStripSeparator4,
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
            this.toolStripSeparator7,
            this.MenuTools,
            this.MenuDatabase,
            this.toolStripSeparator1,
            this.ActionCopyToClipboard,
            this.ActionSave});
      this.ToolStrip.Name = "ToolStrip";
      this.ToolStrip.ShowItemToolTips = false;
      // 
      // MenuBookmarks
      // 
      this.MenuBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuBookmarks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionClearBookmarks,
            this.menusep,
            this.MenuHistory,
            this.toolStripMenuItem2});
      resources.ApplyResources(this.MenuBookmarks, "MenuBookmarks");
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
      this.menusep.Name = "menusep";
      resources.ApplyResources(this.menusep, "menusep");
      // 
      // MenuHistory
      // 
      resources.ApplyResources(this.MenuHistory, "MenuHistory");
      this.MenuHistory.Name = "MenuHistory";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
      // 
      // ActionCloseWindows
      // 
      this.ActionCloseWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionCloseWindows, "ActionCloseWindows");
      this.ActionCloseWindows.Name = "ActionCloseWindows";
      this.ActionCloseWindows.Padding = new System.Windows.Forms.Padding(5);
      this.ActionCloseWindows.Click += new System.EventHandler(this.ActionCloseWindows_Click);
      this.ActionCloseWindows.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionCloseWindows.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionRefresh
      // 
      this.ActionRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionRefresh, "ActionRefresh");
      this.ActionRefresh.Name = "ActionRefresh";
      this.ActionRefresh.Padding = new System.Windows.Forms.Padding(5);
      this.ActionRefresh.Click += new System.EventHandler(this.ActionRefresh_Click);
      this.ActionRefresh.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionRefresh.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
      // 
      // ActionViewVerses
      // 
      this.ActionViewVerses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewVerses, "ActionViewVerses");
      this.ActionViewVerses.Name = "ActionViewVerses";
      this.ActionViewVerses.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewVerses.Click += new System.EventHandler(this.ActionViewVerses_Click);
      this.ActionViewVerses.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewVerses.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionExit
      // 
      this.ActionExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionExit, "ActionExit");
      this.ActionExit.Name = "ActionExit";
      this.ActionExit.Padding = new System.Windows.Forms.Padding(5);
      this.ActionExit.Click += new System.EventHandler(this.ActionExit_Click);
      this.ActionExit.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionExit.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // Sep4
      // 
      this.Sep4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.Sep4.Name = "Sep4";
      resources.ApplyResources(this.Sep4, "Sep4");
      // 
      // ActionHelp
      // 
      this.ActionHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionHelp, "ActionHelp");
      this.ActionHelp.Name = "ActionHelp";
      this.ActionHelp.Padding = new System.Windows.Forms.Padding(5);
      this.ActionHelp.Click += new System.EventHandler(this.ActionHelp_Click);
      this.ActionHelp.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionHelp.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionAbout
      // 
      this.ActionAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionAbout, "ActionAbout");
      this.ActionAbout.Name = "ActionAbout";
      this.ActionAbout.Padding = new System.Windows.Forms.Padding(5);
      this.ActionAbout.Click += new System.EventHandler(this.ActionAbout_Click);
      this.ActionAbout.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionAbout.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // MenuWeb
      // 
      this.MenuWeb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.MenuWeb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuWeb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionWebHome,
            this.ActionWebContact,
            this.ActionCreateGitHubIssue,
            this.toolStripSeparator2,
            this.ActionWebCheckUpdate,
            this.toolStripMenuItem5,
            this.ActionOpenTanakMP3,
            this.bibleFourmilabToolStripMenuItem,
            this.bibleBiblehubcomToolStripMenuItem,
            this.tanakOnlineToolStripMenuItem,
            this.euangélionOnlineToolStripMenuItem,
            this.quranCorpusqurancomToolStripMenuItem,
            this.toolStripSeparator3,
            this.shorashonLexicalToolStripMenuItem,
            this.dictionnaireHéritageDuSanscritToolStripMenuItem,
            this.anAkkadianDictionaryToolStripMenuItem});
      resources.ApplyResources(this.MenuWeb, "MenuWeb");
      this.MenuWeb.Name = "MenuWeb";
      // 
      // ActionWebHome
      // 
      this.ActionWebHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      resources.ApplyResources(this.ActionWebHome, "ActionWebHome");
      this.ActionWebHome.Name = "ActionWebHome";
      this.ActionWebHome.Click += new System.EventHandler(this.ActionWebHome_Click);
      // 
      // ActionWebContact
      // 
      this.ActionWebContact.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      resources.ApplyResources(this.ActionWebContact, "ActionWebContact");
      this.ActionWebContact.Name = "ActionWebContact";
      this.ActionWebContact.Click += new System.EventHandler(this.ActionWebContact_Click);
      // 
      // ActionCreateGitHubIssue
      // 
      this.ActionCreateGitHubIssue.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      resources.ApplyResources(this.ActionCreateGitHubIssue, "ActionCreateGitHubIssue");
      this.ActionCreateGitHubIssue.Name = "ActionCreateGitHubIssue";
      this.ActionCreateGitHubIssue.Tag = "https://github.com/Ordisoftware/Hebrew-Words/issues";
      this.ActionCreateGitHubIssue.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      // 
      // ActionWebCheckUpdate
      // 
      this.ActionWebCheckUpdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      resources.ApplyResources(this.ActionWebCheckUpdate, "ActionWebCheckUpdate");
      this.ActionWebCheckUpdate.Name = "ActionWebCheckUpdate";
      this.ActionWebCheckUpdate.Click += new System.EventHandler(this.ActionWebCheckUpdate_Click);
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
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
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
      // 
      // shorashonLexicalToolStripMenuItem
      // 
      resources.ApplyResources(this.shorashonLexicalToolStripMenuItem, "shorashonLexicalToolStripMenuItem");
      this.shorashonLexicalToolStripMenuItem.Name = "shorashonLexicalToolStripMenuItem";
      this.shorashonLexicalToolStripMenuItem.Tag = "http://shorashon.free.fr/";
      this.shorashonLexicalToolStripMenuItem.Click += new System.EventHandler(this.ActionOpenWebsiteURL_Click);
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
      this.Sep6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.Sep6.Name = "Sep6";
      resources.ApplyResources(this.Sep6, "Sep6");
      // 
      // ActionPreferences
      // 
      this.ActionPreferences.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionPreferences, "ActionPreferences");
      this.ActionPreferences.Name = "ActionPreferences";
      this.ActionPreferences.Padding = new System.Windows.Forms.Padding(5);
      this.ActionPreferences.Click += new System.EventHandler(this.ActionPreferences_Click);
      this.ActionPreferences.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionPreferences.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // MenuSettings
      // 
      this.MenuSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.MenuSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuitemScreenPosition,
            this.ActionResetWinSettings,
            this.Sep7,
            this.EditShowTips,
            this.EditConfirmClosing});
      resources.ApplyResources(this.MenuSettings, "MenuSettings");
      this.MenuSettings.Name = "MenuSettings";
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
      // EditShowTips
      // 
      this.EditShowTips.Checked = true;
      this.EditShowTips.CheckOnClick = true;
      this.EditShowTips.CheckState = System.Windows.Forms.CheckState.Checked;
      resources.ApplyResources(this.EditShowTips, "EditShowTips");
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
      this.ActionViewTranslations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewTranslations, "ActionViewTranslations");
      this.ActionViewTranslations.Name = "ActionViewTranslations";
      this.ActionViewTranslations.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewTranslations.Click += new System.EventHandler(this.ActionViewTranslations_Click);
      this.ActionViewTranslations.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewTranslations.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionViewRawText
      // 
      this.ActionViewRawText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewRawText, "ActionViewRawText");
      this.ActionViewRawText.Name = "ActionViewRawText";
      this.ActionViewRawText.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewRawText.Click += new System.EventHandler(this.ActionViewRawText_Click);
      this.ActionViewRawText.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewRawText.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionViewELS50
      // 
      this.ActionViewELS50.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewELS50, "ActionViewELS50");
      this.ActionViewELS50.Name = "ActionViewELS50";
      this.ActionViewELS50.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewELS50.Click += new System.EventHandler(this.ActionViewELS50_Click);
      this.ActionViewELS50.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewELS50.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionViewSearch
      // 
      this.ActionViewSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewSearch, "ActionViewSearch");
      this.ActionViewSearch.Name = "ActionViewSearch";
      this.ActionViewSearch.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewSearch.Click += new System.EventHandler(this.ActionViewSearch_Click);
      this.ActionViewSearch.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewSearch.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
      // 
      // MenuTools
      // 
      this.MenuTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionViewBooksTranslation,
            this.ActionViewStatistics,
            this.ActionShowGrammarGuide});
      resources.ApplyResources(this.MenuTools, "MenuTools");
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
      // ActionShowGrammarGuide
      // 
      resources.ApplyResources(this.ActionShowGrammarGuide, "ActionShowGrammarGuide");
      this.ActionShowGrammarGuide.Name = "ActionShowGrammarGuide";
      this.ActionShowGrammarGuide.Click += new System.EventHandler(this.ActionShowGrammarGuide_Click);
      // 
      // MenuDatabase
      // 
      this.MenuDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionNew,
            this.ActionRestore,
            this.ActionBackup,
            this.toolStripSeparator5,
            this.ActionOpenBackupPath});
      resources.ApplyResources(this.MenuDatabase, "MenuDatabase");
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
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
      // 
      // ActionOpenBackupPath
      // 
      resources.ApplyResources(this.ActionOpenBackupPath, "ActionOpenBackupPath");
      this.ActionOpenBackupPath.Name = "ActionOpenBackupPath";
      this.ActionOpenBackupPath.Click += new System.EventHandler(this.ActionOpenBackupPath_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      // 
      // ActionCopyToClipboard
      // 
      this.ActionCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionCopyToClipboard, "ActionCopyToClipboard");
      this.ActionCopyToClipboard.Name = "ActionCopyToClipboard";
      this.ActionCopyToClipboard.Padding = new System.Windows.Forms.Padding(5);
      this.ActionCopyToClipboard.Click += new System.EventHandler(this.ActionCopyToClipboard_Click);
      this.ActionCopyToClipboard.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionCopyToClipboard.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionSave
      // 
      this.ActionSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionSave, "ActionSave");
      this.ActionSave.Name = "ActionSave";
      this.ActionSave.Padding = new System.Windows.Forms.Padding(5);
      this.ActionSave.Click += new System.EventHandler(this.ActionSave_Click);
      this.ActionSave.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionSave.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
      // 
      // booksBindingNavigatorSaveItem
      // 
      this.booksBindingNavigatorSaveItem.Name = "booksBindingNavigatorSaveItem";
      resources.ApplyResources(this.booksBindingNavigatorSaveItem, "booksBindingNavigatorSaveItem");
      // 
      // SaveFileDialogWord
      // 
      resources.ApplyResources(this.SaveFileDialogWord, "SaveFileDialogWord");
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
            this.ActionOpenVerseOnline,
            this.ActionExportVerse,
            this.toolStripMenuItem1,
            this.ActionCopyTranslation,
            this.toolStripMenuItem3,
            this.ActionSetAsBookmarkMaster,
            this.ActionAddToBookmarks,
            this.toolStripMenuItem4,
            this.ActionImportConsole});
      this.ContextMenuStripVerse.Name = "ContextMenuStrip";
      resources.ApplyResources(this.ContextMenuStripVerse, "ContextMenuStripVerse");
      // 
      // ActionOpenVerseOnline
      // 
      resources.ApplyResources(this.ActionOpenVerseOnline, "ActionOpenVerseOnline");
      this.ActionOpenVerseOnline.Name = "ActionOpenVerseOnline";
      this.ActionOpenVerseOnline.Click += new System.EventHandler(this.ActionOpenVerseOnline_Click);
      // 
      // ActionExportVerse
      // 
      resources.ApplyResources(this.ActionExportVerse, "ActionExportVerse");
      this.ActionExportVerse.Name = "ActionExportVerse";
      this.ActionExportVerse.Click += new System.EventHandler(this.ActionExportVerse_Click);
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
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
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
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
      // 
      // ActionImportConsole
      // 
      resources.ApplyResources(this.ActionImportConsole, "ActionImportConsole");
      this.ActionImportConsole.Name = "ActionImportConsole";
      this.ActionImportConsole.Click += new System.EventHandler(this.ActionImportConsole_Click);
      // 
      // EditLetters
      // 
      this.EditLetters.InputBackground = System.Drawing.Color.AliceBlue;
      this.EditLetters.LettersBackground = System.Drawing.Color.LightYellow;
      resources.ApplyResources(this.EditLetters, "EditLetters");
      this.EditLetters.Name = "EditLetters";
      this.EditLetters.InputTextChanged += new System.EventHandler(this.EditLetters_InputTextChanged);
      this.EditLetters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PanelLetterSearch_KeyPress);
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
      this.PanelSearchFilters.ResumeLayout(false);
      this.PanelSearchFiltersRight.ResumeLayout(false);
      this.PanelSearchFiltersRight.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TrackBarSearchPaging)).EndInit();
      this.SelectSearchType.ResumeLayout(false);
      this.SelectSearchTypeHebrew.ResumeLayout(false);
      this.PanelSearchTop.ResumeLayout(false);
      this.SelectSearchTypeTranslation.ResumeLayout(false);
      this.SelectSearchTypeTranslation.PerformLayout();
      this.SelectSearchTypeRequest.ResumeLayout(false);
      this.SelectSearchTypeRequest.PerformLayout();
      this.PanelNavigation.ResumeLayout(false);
      this.PanelNavigation.PerformLayout();
      this.PanelTitle.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.WordsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.VersesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChaptersBindingSource)).EndInit();
      this.ToolStrip.ResumeLayout(false);
      this.ToolStrip.PerformLayout();
      this.ContextMenuStripVerse.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
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
    private System.Windows.Forms.BindingSource BooksBindingSource;
    private Data.DataSetTableAdapters.BooksTableAdapter BooksTableAdapter;
    private Data.DataSetTableAdapters.TableAdapterManager TableAdapterManager;
    private Data.DataSetTableAdapters.ChaptersTableAdapter ChaptersTableAdapter;
    private System.Windows.Forms.BindingSource ChaptersBindingSource;
    private Data.DataSetTableAdapters.VersesTableAdapter VersesTableAdapter;
    private System.Windows.Forms.BindingSource VersesBindingSource;
    private Data.DataSetTableAdapters.WordsTableAdapter WordsTableAdapter;
    private System.Windows.Forms.BindingSource WordsBindingSource;
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
    private System.Windows.Forms.Button ActionSearchWord;
    private System.Windows.Forms.Button ActionClearWord;
    private LettersControl EditLetters;
    private System.Windows.Forms.Panel PanelSearchResults;
    internal System.Windows.Forms.ComboBox SelectChapter;
    internal System.Windows.Forms.ComboBox SelectBook;
    private System.Windows.Forms.CheckBox EditSearchOnlyTorah;
    private System.Windows.Forms.Button ActionSearchVerse;
    private System.Windows.Forms.Button ActionExportBook;
    private System.Windows.Forms.SaveFileDialog SaveFileDialogWord;
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
    private System.Windows.Forms.ToolStripMenuItem shorashonLexicalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dictionnaireHéritageDuSanscritToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem anAkkadianDictionaryToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.TabPage SelectSearchTypeRequest;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllUntranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllPartiallyTranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllFullyTranslated;
    private System.Windows.Forms.RadioButton SelectSearchRequestAllTranslated;
    private System.Windows.Forms.ToolStripMenuItem ActionCreateGitHubIssue;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem ActionOpenBackupPath;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    internal System.Windows.Forms.ToolStripButton ActionCloseWindows;
    private System.Windows.Forms.Button ActionNavigateFirst;
    private System.Windows.Forms.Button ActionNavigatePrevious;
    private System.Windows.Forms.Button ActionNavigateNext;
    private System.Windows.Forms.Button ActionNavigateLast;
    private System.Windows.Forms.TextBox EditSearchPaging;
    private System.Windows.Forms.TrackBar TrackBarSearchPaging;
    private System.Windows.Forms.Label LabelSearchCount;
  }
}

