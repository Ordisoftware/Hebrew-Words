namespace Ordisoftware.Hebrew.Words
{
  partial class PreferencesForm
  {
    /// <summary>
    /// Required designer variable
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
      System.Windows.Forms.Label LabelWordControlWidth;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
      System.Windows.Forms.Label LabelMinRefCount;
      System.Windows.Forms.Label LabelMaxRefCount;
      System.Windows.Forms.Label LabelHistoryCount;
      System.Windows.Forms.Label LabelBookmarksCount;
      System.Windows.Forms.Label LabelCommentaryLinesCount;
      System.Windows.Forms.Label LabelBackupPath;
      System.Windows.Forms.Label LabelOnlineVerseURL;
      System.Windows.Forms.Label LabelOnlineSearch;
      System.Windows.Forms.Label LabelAutoSaveDelay;
      System.Windows.Forms.Label LabelBackupCount;
      System.Windows.Forms.Label LabelWordtranslateLinesCount;
      System.Windows.Forms.Label LabelFontSizeHebrew;
      System.Windows.Forms.Label LabelFontSizeTranslation;
      System.Windows.Forms.Label LabelFontSizeComentary;
      this.DialogColor = new System.Windows.Forms.ColorDialog();
      this.ActionClose = new System.Windows.Forms.Button();
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.ActionExportSettings = new System.Windows.Forms.Button();
      this.ActionImportSettings = new System.Windows.Forms.Button();
      this.ActionResetSettings = new System.Windows.Forms.LinkLabel();
      this.OpenExeFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.PanelBottomSeparator = new System.Windows.Forms.Panel();
      this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.SaveSettingsDialog = new System.Windows.Forms.SaveFileDialog();
      this.OpenSettingsDialog = new System.Windows.Forms.OpenFileDialog();
      this.TabPagePaths = new System.Windows.Forms.TabPage();
      this.LabelExportFolder = new System.Windows.Forms.Label();
      this.ActionResetExportFolder = new System.Windows.Forms.Button();
      this.ActionSelectExportFolder = new System.Windows.Forms.Button();
      this.LabelCalculatorPath = new System.Windows.Forms.Label();
      this.ActionResetBackupFolder = new System.Windows.Forms.Button();
      this.ActionResetHebrewLettersPath = new System.Windows.Forms.Button();
      this.ActionResetCalculatorPath = new System.Windows.Forms.Button();
      this.ActionSelectCalculatorPath = new System.Windows.Forms.Button();
      this.LabelHebrewLettersPath = new System.Windows.Forms.Label();
      this.ActionSelectBackupFolder = new System.Windows.Forms.Button();
      this.ActionSelectHebrewLettersPath = new System.Windows.Forms.Button();
      this.EditBackupFolder = new Ordisoftware.Core.TextBoxEx();
      this.EditExportFolder = new Ordisoftware.Core.TextBoxEx();
      this.EditCalculatorPath = new Ordisoftware.Core.TextBoxEx();
      this.EditHebrewLettersPath = new Ordisoftware.Core.TextBoxEx();
      this.LabelDocumentMargins = new System.Windows.Forms.Label();
      this.LabelDocumentMarginIntervalInfo = new System.Windows.Forms.Label();
      this.SelectExportDocumentTheme = new System.Windows.Forms.ComboBox();
      this.SelectImageExportFileFormat = new System.Windows.Forms.ComboBox();
      this.LabelDataExportFileFormat = new System.Windows.Forms.Label();
      this.SelectDataExportFileFormat = new System.Windows.Forms.ComboBox();
      this.LabelExportDocumentTheme = new System.Windows.Forms.Label();
      this.LabelImageExportFileFormat = new System.Windows.Forms.Label();
      this.EditAutoOpenExportedFile = new System.Windows.Forms.CheckBox();
      this.EditAutoOpenExportFolder = new System.Windows.Forms.CheckBox();
      this.TabPageStartup = new System.Windows.Forms.TabPage();
      this.LabelInfoAutoBackupCount = new System.Windows.Forms.Label();
      this.EditGoToLastVerseAtStartup = new System.Windows.Forms.CheckBox();
      this.EditGoToBookmarkMainAtStartup = new System.Windows.Forms.CheckBox();
      this.EditAutoBackupCount = new System.Windows.Forms.NumericUpDown();
      this.EditShowLastNewInVersionAfterUpdate = new System.Windows.Forms.CheckBox();
      this.LabelLastDBOptimizeDate = new System.Windows.Forms.Label();
      this.LabelLastDBOptimize = new System.Windows.Forms.Label();
      this.LabelLastStartupCheckDate = new System.Windows.Forms.Label();
      this.LabelLastStartupCheck = new System.Windows.Forms.Label();
      this.LabelInfoCheckUpdateAtStartup = new System.Windows.Forms.Label();
      this.EditCheckUpdateAtStartup = new System.Windows.Forms.CheckBox();
      this.EditCheckUpdateAtStartupInterval = new System.Windows.Forms.NumericUpDown();
      this.EditVacuumAtStartupInterval = new System.Windows.Forms.NumericUpDown();
      this.EditVacuumAtStartup = new System.Windows.Forms.CheckBox();
      this.LabelInfoOptimizeDatabaseIntervalInfo = new System.Windows.Forms.Label();
      this.TabPageApplication = new System.Windows.Forms.TabPage();
      this.EditSearchHebrewCharsInBold = new System.Windows.Forms.CheckBox();
      this.EditVolume = new System.Windows.Forms.TrackBar();
      this.LabelVolume = new System.Windows.Forms.Label();
      this.LabelVolumeValue = new System.Windows.Forms.Label();
      this.EditTrayIconEnabled = new System.Windows.Forms.CheckBox();
      this.ActionSelectLangEN = new System.Windows.Forms.Button();
      this.ActionSelectLangFR = new System.Windows.Forms.Button();
      this.EditWindowsDoubleBufferingEnabled = new System.Windows.Forms.CheckBox();
      this.EditBookmarksWithParashah = new System.Windows.Forms.CheckBox();
      this.EditDatabaseRestoreAskToBackup = new System.Windows.Forms.CheckBox();
      this.EditBookmarksWithTranslation = new System.Windows.Forms.CheckBox();
      this.EditBookNameHebrewWithParashah = new System.Windows.Forms.CheckBox();
      this.EditBookNameHebrewWithCommonName = new System.Windows.Forms.CheckBox();
      this.EditWebLinksMenuEnabled = new System.Windows.Forms.CheckBox();
      this.EditDebuggerEnabled = new System.Windows.Forms.CheckBox();
      this.EditSystemStatisticsCalculateDbSize = new System.Windows.Forms.CheckBox();
      this.EditUsageStatisticsEnabled = new System.Windows.Forms.CheckBox();
      this.EditLogEnabled = new System.Windows.Forms.CheckBox();
      this.ActionCheckAllComments = new System.Windows.Forms.Button();
      this.LabelInfoAutoSaveDelay = new System.Windows.Forms.Label();
      this.EditAutoSaveDelay = new System.Windows.Forms.NumericUpDown();
      this.EditCommentLineRemovePrefix = new System.Windows.Forms.CheckBox();
      this.EditCommentLineAddPrefix = new System.Windows.Forms.CheckBox();
      this.EditAutoSortBookmarks = new System.Windows.Forms.CheckBox();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.TabPageBookmarks = new System.Windows.Forms.TabPage();
      this.EditHistoryCount = new System.Windows.Forms.NumericUpDown();
      this.LabelInfoHistoryCount = new System.Windows.Forms.Label();
      this.EditBookmarksCount = new System.Windows.Forms.NumericUpDown();
      this.LabelInfoBookmarksCount = new System.Windows.Forms.Label();
      this.TabPageEditing = new System.Windows.Forms.TabPage();
      this.EditSpellCheckEnabled = new System.Windows.Forms.CheckBox();
      this.EditWordControlTabInverted = new System.Windows.Forms.CheckBox();
      this.EditAutoSaveOnLeaveControl = new System.Windows.Forms.CheckBox();
      this.EditCommentLinePrefix = new Ordisoftware.Core.TextBoxEx();
      this.TabPageRendering = new System.Windows.Forms.TabPage();
      this.ActionResetRendering = new System.Windows.Forms.Button();
      this.LabelInfoSearchMinRefForDialog = new System.Windows.Forms.Label();
      this.LabelInfoSearchDisplayMaxRef = new System.Windows.Forms.Label();
      this.LabelFontSizeCommentaryInfo = new System.Windows.Forms.Label();
      this.LabelFontSizeTranslationInfo = new System.Windows.Forms.Label();
      this.LabelFontSizeHebrewInfo = new System.Windows.Forms.Label();
      this.LabelInfoWordControlWidth = new System.Windows.Forms.Label();
      this.LabelWordtranslateLinesCountInfo = new System.Windows.Forms.Label();
      this.LabelInfoCommentLinesCountInfos = new System.Windows.Forms.Label();
      this.EditFontSizeCommentary = new System.Windows.Forms.NumericUpDown();
      this.EditFontSizeTranslation = new System.Windows.Forms.NumericUpDown();
      this.EditFontSizeHebrew = new System.Windows.Forms.NumericUpDown();
      this.EditWordControlWidth = new System.Windows.Forms.NumericUpDown();
      this.EditSearchMinRefForDialog = new System.Windows.Forms.NumericUpDown();
      this.EditSearchDisplayMaxRef = new System.Windows.Forms.NumericUpDown();
      this.EditWordTranslateLinesCount = new System.Windows.Forms.NumericUpDown();
      this.EditCommentaryLinesCount = new System.Windows.Forms.NumericUpDown();
      this.TabPageTheme = new System.Windows.Forms.TabPage();
      this.ActionOpenTheme = new System.Windows.Forms.Button();
      this.ActionSaveTheme = new System.Windows.Forms.Button();
      this.LabelThemeVerseNumberColor = new System.Windows.Forms.Label();
      this.EditThemeVerseNumberColor = new System.Windows.Forms.Panel();
      this.label8 = new System.Windows.Forms.Label();
      this.LabelThemeVerseHebrewColor = new System.Windows.Forms.Label();
      this.EditThemeNavigatorItems = new System.Windows.Forms.Panel();
      this.EditThemeVerseHebrewColor = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.LabelThemeTranslationTextColor = new System.Windows.Forms.Label();
      this.LabelThemeVerseHebrewColorHover = new System.Windows.Forms.Label();
      this.EditThemeTranslationTextColor = new System.Windows.Forms.Panel();
      this.EditThemeTranslationBack = new System.Windows.Forms.Panel();
      this.EditThemeVerseHebrewColorHover = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.LabelThemeVerseNumberColorHover = new System.Windows.Forms.Label();
      this.EditThemeCommentaryBack = new System.Windows.Forms.Panel();
      this.EditThemeVerseNumberColorHover = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.EditThemeCurrentControl = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.EditThemeSearchLettersBack = new System.Windows.Forms.Panel();
      this.EditThemeSearchWordBack = new System.Windows.Forms.Panel();
      this.label6 = new System.Windows.Forms.Label();
      this.ActionUseColorsPastel = new System.Windows.Forms.LinkLabel();
      this.ActionUseColorsSystem = new System.Windows.Forms.LinkLabel();
      this.TabPageMouse = new System.Windows.Forms.TabPage();
      this.GroupBoxHebrewWordClickShift = new System.Windows.Forms.GroupBox();
      this.GroupBoxHebrewWordClickShift5 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShift0 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShift1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShift3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShift2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShift4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxVerseLabelClick = new System.Windows.Forms.GroupBox();
      this.GroupBoxVerseLabelClick4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxVerseLabelClick1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxVerseLabelClick2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxVerseLabelClick3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick = new System.Windows.Forms.GroupBox();
      this.GroupBoxHebrewWordClick5 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick0 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickAlt = new System.Windows.Forms.GroupBox();
      this.GroupBoxHebrewWordClickShiftCtrl5 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShiftCtrl0 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShiftCtrl1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShiftCtrl3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShiftCtrl2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShiftCtrl4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl = new System.Windows.Forms.GroupBox();
      this.GroupBoxHebrewWordClickCtrl5 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl0 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxTranslatedItemDoubleClick = new System.Windows.Forms.GroupBox();
      this.GroupBoxTranslatedItemDoubleClick4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxTranslatedItemDoubleClick1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxTranslatedItemDoubleClick2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxTranslatedItemDoubleClick3 = new System.Windows.Forms.RadioButton();
      this.TabPageMSWord = new System.Windows.Forms.TabPage();
      this.SelectPageSize = new System.Windows.Forms.Button();
      this.EditExportDocumentVerseRefInBold = new System.Windows.Forms.CheckBox();
      this.EditExportDocumentLandscape = new System.Windows.Forms.CheckBox();
      this.EditDocumentMarginTop = new System.Windows.Forms.NumericUpDown();
      this.LabelDocumentMarginHFIntervalInfo = new System.Windows.Forms.Label();
      this.EditPageHeight = new System.Windows.Forms.NumericUpDown();
      this.EditDocumentWordColumnsCount = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      this.EditDifferentFirstPage = new System.Windows.Forms.CheckBox();
      this.EditPageWidth = new System.Windows.Forms.NumericUpDown();
      this.SelectExportDocumentModel = new System.Windows.Forms.ComboBox();
      this.EditDocumentMarginBottom = new System.Windows.Forms.NumericUpDown();
      this.EditExportDocumentDifferentOddAndEvenPages = new System.Windows.Forms.CheckBox();
      this.LabelDocumentSize = new System.Windows.Forms.Label();
      this.EditDocumentMarginLeft = new System.Windows.Forms.NumericUpDown();
      this.EditExportDocumentOverrideWordColumnsCount = new System.Windows.Forms.CheckBox();
      this.LabelPageWidthIntervalInfo = new System.Windows.Forms.Label();
      this.EditDocumentMarginHeader = new System.Windows.Forms.NumericUpDown();
      this.LabelPageHeightIntervalInfo = new System.Windows.Forms.Label();
      this.EditDocumentMarginRight = new System.Windows.Forms.NumericUpDown();
      this.LabelDocumentWordColumnsCountIntervalInfo = new System.Windows.Forms.Label();
      this.EditDocumentMarginFooter = new System.Windows.Forms.NumericUpDown();
      this.TabPageExport = new System.Windows.Forms.TabPage();
      this.TabPageTools = new System.Windows.Forms.TabPage();
      this.ActionOnlineSearchHelp = new System.Windows.Forms.Button();
      this.ActionOnlineVerseHelp = new System.Windows.Forms.Button();
      this.ActionSelectOnlineSearch = new System.Windows.Forms.Button();
      this.ActionSelectOnlineVerseURL = new System.Windows.Forms.Button();
      this.EditOnlineVerseURL = new Ordisoftware.Core.TextBoxEx();
      this.EditOnlineSearch = new Ordisoftware.Core.TextBoxEx();
      this.SaveThemeDialog = new System.Windows.Forms.SaveFileDialog();
      this.OpenThemeDialog = new System.Windows.Forms.OpenFileDialog();
      this.MenuSelectSearchRequest = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.MenuSelectOnlineVerseURL = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.MenuPredefinedPageSizes = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ActionSetPageSizeA5 = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSetPageSizeA4 = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSetPageSizePocket = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSetPageSizeDigest = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSetPageSizeRoman = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSetPageSizeRoyal = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSetPageSizeCrownQuarto = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSetPageSizeExecutive = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionSetPageSizeUSLetter = new System.Windows.Forms.ToolStripMenuItem();
      LabelWordControlWidth = new System.Windows.Forms.Label();
      LabelMinRefCount = new System.Windows.Forms.Label();
      LabelMaxRefCount = new System.Windows.Forms.Label();
      LabelHistoryCount = new System.Windows.Forms.Label();
      LabelBookmarksCount = new System.Windows.Forms.Label();
      LabelCommentaryLinesCount = new System.Windows.Forms.Label();
      LabelBackupPath = new System.Windows.Forms.Label();
      LabelOnlineVerseURL = new System.Windows.Forms.Label();
      LabelOnlineSearch = new System.Windows.Forms.Label();
      LabelAutoSaveDelay = new System.Windows.Forms.Label();
      LabelBackupCount = new System.Windows.Forms.Label();
      LabelWordtranslateLinesCount = new System.Windows.Forms.Label();
      LabelFontSizeHebrew = new System.Windows.Forms.Label();
      LabelFontSizeTranslation = new System.Windows.Forms.Label();
      LabelFontSizeComentary = new System.Windows.Forms.Label();
      this.PanelButtons.SuspendLayout();
      this.TabPagePaths.SuspendLayout();
      this.TabPageStartup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoBackupCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditCheckUpdateAtStartupInterval)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditVacuumAtStartupInterval)).BeginInit();
      this.TabPageApplication.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditVolume)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoSaveDelay)).BeginInit();
      this.TabControl.SuspendLayout();
      this.TabPageBookmarks.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditHistoryCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditBookmarksCount)).BeginInit();
      this.TabPageEditing.SuspendLayout();
      this.TabPageRendering.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSizeCommentary)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSizeTranslation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSizeHebrew)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditWordControlWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditSearchMinRefForDialog)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditSearchDisplayMaxRef)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditWordTranslateLinesCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditCommentaryLinesCount)).BeginInit();
      this.TabPageTheme.SuspendLayout();
      this.TabPageMouse.SuspendLayout();
      this.GroupBoxHebrewWordClickShift.SuspendLayout();
      this.GroupBoxVerseLabelClick.SuspendLayout();
      this.GroupBoxHebrewWordClick.SuspendLayout();
      this.GroupBoxHebrewWordClickAlt.SuspendLayout();
      this.GroupBoxHebrewWordClickCtrl.SuspendLayout();
      this.GroupBoxTranslatedItemDoubleClick.SuspendLayout();
      this.TabPageMSWord.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginTop)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditPageHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentWordColumnsCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditPageWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginBottom)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginLeft)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginHeader)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginRight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginFooter)).BeginInit();
      this.TabPageExport.SuspendLayout();
      this.TabPageTools.SuspendLayout();
      this.MenuPredefinedPageSizes.SuspendLayout();
      this.SuspendLayout();
      // 
      // LabelWordControlWidth
      // 
      resources.ApplyResources(LabelWordControlWidth, "LabelWordControlWidth");
      LabelWordControlWidth.Name = "LabelWordControlWidth";
      // 
      // LabelMinRefCount
      // 
      resources.ApplyResources(LabelMinRefCount, "LabelMinRefCount");
      LabelMinRefCount.Name = "LabelMinRefCount";
      // 
      // LabelMaxRefCount
      // 
      resources.ApplyResources(LabelMaxRefCount, "LabelMaxRefCount");
      LabelMaxRefCount.Name = "LabelMaxRefCount";
      // 
      // LabelHistoryCount
      // 
      resources.ApplyResources(LabelHistoryCount, "LabelHistoryCount");
      LabelHistoryCount.Name = "LabelHistoryCount";
      // 
      // LabelBookmarksCount
      // 
      resources.ApplyResources(LabelBookmarksCount, "LabelBookmarksCount");
      LabelBookmarksCount.Name = "LabelBookmarksCount";
      // 
      // LabelCommentaryLinesCount
      // 
      resources.ApplyResources(LabelCommentaryLinesCount, "LabelCommentaryLinesCount");
      LabelCommentaryLinesCount.Name = "LabelCommentaryLinesCount";
      // 
      // LabelBackupPath
      // 
      resources.ApplyResources(LabelBackupPath, "LabelBackupPath");
      LabelBackupPath.Name = "LabelBackupPath";
      // 
      // LabelOnlineVerseURL
      // 
      resources.ApplyResources(LabelOnlineVerseURL, "LabelOnlineVerseURL");
      LabelOnlineVerseURL.Name = "LabelOnlineVerseURL";
      // 
      // LabelOnlineSearch
      // 
      resources.ApplyResources(LabelOnlineSearch, "LabelOnlineSearch");
      LabelOnlineSearch.Name = "LabelOnlineSearch";
      // 
      // LabelAutoSaveDelay
      // 
      resources.ApplyResources(LabelAutoSaveDelay, "LabelAutoSaveDelay");
      LabelAutoSaveDelay.Name = "LabelAutoSaveDelay";
      // 
      // LabelBackupCount
      // 
      resources.ApplyResources(LabelBackupCount, "LabelBackupCount");
      LabelBackupCount.Name = "LabelBackupCount";
      // 
      // LabelWordtranslateLinesCount
      // 
      resources.ApplyResources(LabelWordtranslateLinesCount, "LabelWordtranslateLinesCount");
      LabelWordtranslateLinesCount.Name = "LabelWordtranslateLinesCount";
      // 
      // LabelFontSizeHebrew
      // 
      resources.ApplyResources(LabelFontSizeHebrew, "LabelFontSizeHebrew");
      LabelFontSizeHebrew.Name = "LabelFontSizeHebrew";
      // 
      // LabelFontSizeTranslation
      // 
      resources.ApplyResources(LabelFontSizeTranslation, "LabelFontSizeTranslation");
      LabelFontSizeTranslation.Name = "LabelFontSizeTranslation";
      // 
      // LabelFontSizeComentary
      // 
      resources.ApplyResources(LabelFontSizeComentary, "LabelFontSizeComentary");
      LabelFontSizeComentary.Name = "LabelFontSizeComentary";
      // 
      // DialogColor
      // 
      this.DialogColor.FullOpen = true;
      // 
      // ActionClose
      // 
      resources.ApplyResources(this.ActionClose, "ActionClose");
      this.ActionClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ActionClose.Name = "ActionClose";
      this.ActionClose.UseVisualStyleBackColor = true;
      // 
      // PanelButtons
      // 
      this.PanelButtons.Controls.Add(this.ActionExportSettings);
      this.PanelButtons.Controls.Add(this.ActionImportSettings);
      this.PanelButtons.Controls.Add(this.ActionResetSettings);
      this.PanelButtons.Controls.Add(this.ActionClose);
      resources.ApplyResources(this.PanelButtons, "PanelButtons");
      this.PanelButtons.Name = "PanelButtons";
      // 
      // ActionExportSettings
      // 
      this.ActionExportSettings.AllowDrop = true;
      this.ActionExportSettings.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionExportSettings, "ActionExportSettings");
      this.ActionExportSettings.Name = "ActionExportSettings";
      this.ActionExportSettings.UseVisualStyleBackColor = true;
      this.ActionExportSettings.Click += new System.EventHandler(this.ActionExportSettings_Click);
      // 
      // ActionImportSettings
      // 
      this.ActionImportSettings.AllowDrop = true;
      this.ActionImportSettings.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionImportSettings, "ActionImportSettings");
      this.ActionImportSettings.Name = "ActionImportSettings";
      this.ActionImportSettings.UseVisualStyleBackColor = true;
      this.ActionImportSettings.Click += new System.EventHandler(this.ActionImportSettings_Click);
      // 
      // ActionResetSettings
      // 
      this.ActionResetSettings.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      resources.ApplyResources(this.ActionResetSettings, "ActionResetSettings");
      this.ActionResetSettings.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.ActionResetSettings.LinkColor = System.Drawing.Color.Navy;
      this.ActionResetSettings.Name = "ActionResetSettings";
      this.ActionResetSettings.TabStop = true;
      this.ActionResetSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ActionResetSettings_LinkClicked);
      // 
      // OpenExeFileDialog
      // 
      resources.ApplyResources(this.OpenExeFileDialog, "OpenExeFileDialog");
      // 
      // PanelBottomSeparator
      // 
      resources.ApplyResources(this.PanelBottomSeparator, "PanelBottomSeparator");
      this.PanelBottomSeparator.Name = "PanelBottomSeparator";
      // 
      // TabPagePaths
      // 
      this.TabPagePaths.BackColor = System.Drawing.SystemColors.Window;
      this.TabPagePaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPagePaths.Controls.Add(LabelBackupPath);
      this.TabPagePaths.Controls.Add(this.LabelExportFolder);
      this.TabPagePaths.Controls.Add(this.ActionResetExportFolder);
      this.TabPagePaths.Controls.Add(this.ActionSelectExportFolder);
      this.TabPagePaths.Controls.Add(this.LabelCalculatorPath);
      this.TabPagePaths.Controls.Add(this.ActionResetBackupFolder);
      this.TabPagePaths.Controls.Add(this.ActionResetHebrewLettersPath);
      this.TabPagePaths.Controls.Add(this.ActionResetCalculatorPath);
      this.TabPagePaths.Controls.Add(this.ActionSelectCalculatorPath);
      this.TabPagePaths.Controls.Add(this.LabelHebrewLettersPath);
      this.TabPagePaths.Controls.Add(this.ActionSelectBackupFolder);
      this.TabPagePaths.Controls.Add(this.ActionSelectHebrewLettersPath);
      this.TabPagePaths.Controls.Add(this.EditBackupFolder);
      this.TabPagePaths.Controls.Add(this.EditExportFolder);
      this.TabPagePaths.Controls.Add(this.EditCalculatorPath);
      this.TabPagePaths.Controls.Add(this.EditHebrewLettersPath);
      resources.ApplyResources(this.TabPagePaths, "TabPagePaths");
      this.TabPagePaths.Name = "TabPagePaths";
      // 
      // LabelExportFolder
      // 
      resources.ApplyResources(this.LabelExportFolder, "LabelExportFolder");
      this.LabelExportFolder.Name = "LabelExportFolder";
      // 
      // ActionResetExportFolder
      // 
      resources.ApplyResources(this.ActionResetExportFolder, "ActionResetExportFolder");
      this.ActionResetExportFolder.FlatAppearance.BorderSize = 0;
      this.ActionResetExportFolder.Name = "ActionResetExportFolder";
      this.ActionResetExportFolder.UseVisualStyleBackColor = true;
      this.ActionResetExportFolder.Click += new System.EventHandler(this.ActionResetExportFolder_Click);
      // 
      // ActionSelectExportFolder
      // 
      resources.ApplyResources(this.ActionSelectExportFolder, "ActionSelectExportFolder");
      this.ActionSelectExportFolder.FlatAppearance.BorderSize = 0;
      this.ActionSelectExportFolder.Name = "ActionSelectExportFolder";
      this.ActionSelectExportFolder.UseVisualStyleBackColor = true;
      this.ActionSelectExportFolder.Click += new System.EventHandler(this.ActionSelectExportFolder_Click);
      // 
      // LabelCalculatorPath
      // 
      resources.ApplyResources(this.LabelCalculatorPath, "LabelCalculatorPath");
      this.LabelCalculatorPath.Name = "LabelCalculatorPath";
      // 
      // ActionResetBackupFolder
      // 
      resources.ApplyResources(this.ActionResetBackupFolder, "ActionResetBackupFolder");
      this.ActionResetBackupFolder.FlatAppearance.BorderSize = 0;
      this.ActionResetBackupFolder.Name = "ActionResetBackupFolder";
      this.ActionResetBackupFolder.UseVisualStyleBackColor = true;
      this.ActionResetBackupFolder.Click += new System.EventHandler(this.ActionResetBackupFolder_Click);
      // 
      // ActionResetHebrewLettersPath
      // 
      resources.ApplyResources(this.ActionResetHebrewLettersPath, "ActionResetHebrewLettersPath");
      this.ActionResetHebrewLettersPath.FlatAppearance.BorderSize = 0;
      this.ActionResetHebrewLettersPath.Name = "ActionResetHebrewLettersPath";
      this.ActionResetHebrewLettersPath.UseVisualStyleBackColor = true;
      this.ActionResetHebrewLettersPath.Click += new System.EventHandler(this.ActionResetHebrewLettersPath_Click);
      // 
      // ActionResetCalculatorPath
      // 
      resources.ApplyResources(this.ActionResetCalculatorPath, "ActionResetCalculatorPath");
      this.ActionResetCalculatorPath.FlatAppearance.BorderSize = 0;
      this.ActionResetCalculatorPath.Name = "ActionResetCalculatorPath";
      this.ActionResetCalculatorPath.UseVisualStyleBackColor = true;
      this.ActionResetCalculatorPath.Click += new System.EventHandler(this.ActionResetCalculatorPath_Click);
      // 
      // ActionSelectCalculatorPath
      // 
      resources.ApplyResources(this.ActionSelectCalculatorPath, "ActionSelectCalculatorPath");
      this.ActionSelectCalculatorPath.FlatAppearance.BorderSize = 0;
      this.ActionSelectCalculatorPath.Name = "ActionSelectCalculatorPath";
      this.ActionSelectCalculatorPath.UseVisualStyleBackColor = true;
      this.ActionSelectCalculatorPath.Click += new System.EventHandler(this.ActionSelectCalculatorPath_Click);
      // 
      // LabelHebrewLettersPath
      // 
      resources.ApplyResources(this.LabelHebrewLettersPath, "LabelHebrewLettersPath");
      this.LabelHebrewLettersPath.Name = "LabelHebrewLettersPath";
      // 
      // ActionSelectBackupFolder
      // 
      resources.ApplyResources(this.ActionSelectBackupFolder, "ActionSelectBackupFolder");
      this.ActionSelectBackupFolder.FlatAppearance.BorderSize = 0;
      this.ActionSelectBackupFolder.Name = "ActionSelectBackupFolder";
      this.ActionSelectBackupFolder.UseVisualStyleBackColor = true;
      this.ActionSelectBackupFolder.Click += new System.EventHandler(this.ActionSelectBackupFolder_Click);
      // 
      // ActionSelectHebrewLettersPath
      // 
      resources.ApplyResources(this.ActionSelectHebrewLettersPath, "ActionSelectHebrewLettersPath");
      this.ActionSelectHebrewLettersPath.FlatAppearance.BorderSize = 0;
      this.ActionSelectHebrewLettersPath.Name = "ActionSelectHebrewLettersPath";
      this.ActionSelectHebrewLettersPath.UseVisualStyleBackColor = true;
      this.ActionSelectHebrewLettersPath.Click += new System.EventHandler(this.ActionSelectHebrewLettersPath_Click);
      // 
      // EditBackupFolder
      // 
      resources.ApplyResources(this.EditBackupFolder, "EditBackupFolder");
      this.EditBackupFolder.BackColor = System.Drawing.SystemColors.Control;
      this.EditBackupFolder.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditBackupFolder.Name = "EditBackupFolder";
      this.EditBackupFolder.ReadOnly = true;
      this.EditBackupFolder.SpellCheckAllowed = false;
      // 
      // EditExportFolder
      // 
      resources.ApplyResources(this.EditExportFolder, "EditExportFolder");
      this.EditExportFolder.BackColor = System.Drawing.SystemColors.Control;
      this.EditExportFolder.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditExportFolder.Name = "EditExportFolder";
      this.EditExportFolder.ReadOnly = true;
      this.EditExportFolder.SpellCheckAllowed = false;
      // 
      // EditCalculatorPath
      // 
      resources.ApplyResources(this.EditCalculatorPath, "EditCalculatorPath");
      this.EditCalculatorPath.BackColor = System.Drawing.SystemColors.Control;
      this.EditCalculatorPath.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditCalculatorPath.Name = "EditCalculatorPath";
      this.EditCalculatorPath.ReadOnly = true;
      this.EditCalculatorPath.SpellCheckAllowed = false;
      // 
      // EditHebrewLettersPath
      // 
      resources.ApplyResources(this.EditHebrewLettersPath, "EditHebrewLettersPath");
      this.EditHebrewLettersPath.BackColor = System.Drawing.SystemColors.Control;
      this.EditHebrewLettersPath.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditHebrewLettersPath.Name = "EditHebrewLettersPath";
      this.EditHebrewLettersPath.ReadOnly = true;
      this.EditHebrewLettersPath.SpellCheckAllowed = false;
      // 
      // LabelDocumentMargins
      // 
      resources.ApplyResources(this.LabelDocumentMargins, "LabelDocumentMargins");
      this.LabelDocumentMargins.Name = "LabelDocumentMargins";
      // 
      // LabelDocumentMarginIntervalInfo
      // 
      resources.ApplyResources(this.LabelDocumentMarginIntervalInfo, "LabelDocumentMarginIntervalInfo");
      this.LabelDocumentMarginIntervalInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelDocumentMarginIntervalInfo.Name = "LabelDocumentMarginIntervalInfo";
      // 
      // SelectExportDocumentTheme
      // 
      this.SelectExportDocumentTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectExportDocumentTheme.FormattingEnabled = true;
      this.SelectExportDocumentTheme.Items.AddRange(new object[] {
            resources.GetString("SelectExportDocumentTheme.Items"),
            resources.GetString("SelectExportDocumentTheme.Items1"),
            resources.GetString("SelectExportDocumentTheme.Items2")});
      resources.ApplyResources(this.SelectExportDocumentTheme, "SelectExportDocumentTheme");
      this.SelectExportDocumentTheme.Name = "SelectExportDocumentTheme";
      // 
      // SelectImageExportFileFormat
      // 
      this.SelectImageExportFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectImageExportFileFormat.FormattingEnabled = true;
      resources.ApplyResources(this.SelectImageExportFileFormat, "SelectImageExportFileFormat");
      this.SelectImageExportFileFormat.Name = "SelectImageExportFileFormat";
      this.SelectImageExportFileFormat.SelectedIndexChanged += new System.EventHandler(this.EditImageExportFileFormat_SelectedIndexChanged);
      this.SelectImageExportFileFormat.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.EditImageExportFileFormat_Format);
      // 
      // LabelDataExportFileFormat
      // 
      resources.ApplyResources(this.LabelDataExportFileFormat, "LabelDataExportFileFormat");
      this.LabelDataExportFileFormat.Name = "LabelDataExportFileFormat";
      // 
      // SelectDataExportFileFormat
      // 
      this.SelectDataExportFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectDataExportFileFormat.FormattingEnabled = true;
      resources.ApplyResources(this.SelectDataExportFileFormat, "SelectDataExportFileFormat");
      this.SelectDataExportFileFormat.Name = "SelectDataExportFileFormat";
      this.SelectDataExportFileFormat.SelectedIndexChanged += new System.EventHandler(this.EditDataExportFileFormat_SelectedIndexChanged);
      this.SelectDataExportFileFormat.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.EditDataExportFileFormat_Format);
      // 
      // LabelExportDocumentTheme
      // 
      resources.ApplyResources(this.LabelExportDocumentTheme, "LabelExportDocumentTheme");
      this.LabelExportDocumentTheme.Name = "LabelExportDocumentTheme";
      // 
      // LabelImageExportFileFormat
      // 
      resources.ApplyResources(this.LabelImageExportFileFormat, "LabelImageExportFileFormat");
      this.LabelImageExportFileFormat.Name = "LabelImageExportFileFormat";
      // 
      // EditAutoOpenExportedFile
      // 
      resources.ApplyResources(this.EditAutoOpenExportedFile, "EditAutoOpenExportedFile");
      this.EditAutoOpenExportedFile.Name = "EditAutoOpenExportedFile";
      this.EditAutoOpenExportedFile.UseVisualStyleBackColor = true;
      this.EditAutoOpenExportedFile.CheckedChanged += new System.EventHandler(this.EditAutoOpenExportedFile_CheckedChanged);
      // 
      // EditAutoOpenExportFolder
      // 
      resources.ApplyResources(this.EditAutoOpenExportFolder, "EditAutoOpenExportFolder");
      this.EditAutoOpenExportFolder.Name = "EditAutoOpenExportFolder";
      this.EditAutoOpenExportFolder.UseVisualStyleBackColor = true;
      this.EditAutoOpenExportFolder.CheckedChanged += new System.EventHandler(this.EditAutoOpenExportFolder_CheckedChanged);
      // 
      // TabPageStartup
      // 
      this.TabPageStartup.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageStartup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageStartup.Controls.Add(this.LabelInfoAutoBackupCount);
      this.TabPageStartup.Controls.Add(this.EditGoToLastVerseAtStartup);
      this.TabPageStartup.Controls.Add(this.EditGoToBookmarkMainAtStartup);
      this.TabPageStartup.Controls.Add(this.EditAutoBackupCount);
      this.TabPageStartup.Controls.Add(this.EditShowLastNewInVersionAfterUpdate);
      this.TabPageStartup.Controls.Add(this.LabelLastDBOptimizeDate);
      this.TabPageStartup.Controls.Add(LabelBackupCount);
      this.TabPageStartup.Controls.Add(this.LabelLastDBOptimize);
      this.TabPageStartup.Controls.Add(this.LabelLastStartupCheckDate);
      this.TabPageStartup.Controls.Add(this.LabelLastStartupCheck);
      this.TabPageStartup.Controls.Add(this.LabelInfoCheckUpdateAtStartup);
      this.TabPageStartup.Controls.Add(this.EditCheckUpdateAtStartup);
      this.TabPageStartup.Controls.Add(this.EditCheckUpdateAtStartupInterval);
      this.TabPageStartup.Controls.Add(this.EditVacuumAtStartupInterval);
      this.TabPageStartup.Controls.Add(this.EditVacuumAtStartup);
      this.TabPageStartup.Controls.Add(this.LabelInfoOptimizeDatabaseIntervalInfo);
      resources.ApplyResources(this.TabPageStartup, "TabPageStartup");
      this.TabPageStartup.Name = "TabPageStartup";
      // 
      // LabelInfoAutoBackupCount
      // 
      resources.ApplyResources(this.LabelInfoAutoBackupCount, "LabelInfoAutoBackupCount");
      this.LabelInfoAutoBackupCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoAutoBackupCount.Name = "LabelInfoAutoBackupCount";
      // 
      // EditGoToLastVerseAtStartup
      // 
      resources.ApplyResources(this.EditGoToLastVerseAtStartup, "EditGoToLastVerseAtStartup");
      this.EditGoToLastVerseAtStartup.Name = "EditGoToLastVerseAtStartup";
      this.EditGoToLastVerseAtStartup.UseVisualStyleBackColor = true;
      this.EditGoToLastVerseAtStartup.CheckedChanged += new System.EventHandler(this.EditGoToLastVerseAtStartup_CheckedChanged);
      // 
      // EditGoToBookmarkMainAtStartup
      // 
      resources.ApplyResources(this.EditGoToBookmarkMainAtStartup, "EditGoToBookmarkMainAtStartup");
      this.EditGoToBookmarkMainAtStartup.Name = "EditGoToBookmarkMainAtStartup";
      this.EditGoToBookmarkMainAtStartup.UseVisualStyleBackColor = true;
      this.EditGoToBookmarkMainAtStartup.CheckedChanged += new System.EventHandler(this.EditGoToBookmarkMainAtStartup_CheckedChanged);
      // 
      // EditAutoBackupCount
      // 
      this.EditAutoBackupCount.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditAutoBackupCount, "EditAutoBackupCount");
      this.EditAutoBackupCount.Name = "EditAutoBackupCount";
      this.EditAutoBackupCount.ReadOnly = true;
      // 
      // EditShowLastNewInVersionAfterUpdate
      // 
      resources.ApplyResources(this.EditShowLastNewInVersionAfterUpdate, "EditShowLastNewInVersionAfterUpdate");
      this.EditShowLastNewInVersionAfterUpdate.Name = "EditShowLastNewInVersionAfterUpdate";
      this.EditShowLastNewInVersionAfterUpdate.UseVisualStyleBackColor = true;
      // 
      // LabelLastDBOptimizeDate
      // 
      resources.ApplyResources(this.LabelLastDBOptimizeDate, "LabelLastDBOptimizeDate");
      this.LabelLastDBOptimizeDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelLastDBOptimizeDate.Name = "LabelLastDBOptimizeDate";
      // 
      // LabelLastDBOptimize
      // 
      resources.ApplyResources(this.LabelLastDBOptimize, "LabelLastDBOptimize");
      this.LabelLastDBOptimize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelLastDBOptimize.Name = "LabelLastDBOptimize";
      // 
      // LabelLastStartupCheckDate
      // 
      resources.ApplyResources(this.LabelLastStartupCheckDate, "LabelLastStartupCheckDate");
      this.LabelLastStartupCheckDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelLastStartupCheckDate.Name = "LabelLastStartupCheckDate";
      // 
      // LabelLastStartupCheck
      // 
      resources.ApplyResources(this.LabelLastStartupCheck, "LabelLastStartupCheck");
      this.LabelLastStartupCheck.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelLastStartupCheck.Name = "LabelLastStartupCheck";
      // 
      // LabelInfoCheckUpdateAtStartup
      // 
      resources.ApplyResources(this.LabelInfoCheckUpdateAtStartup, "LabelInfoCheckUpdateAtStartup");
      this.LabelInfoCheckUpdateAtStartup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoCheckUpdateAtStartup.Name = "LabelInfoCheckUpdateAtStartup";
      // 
      // EditCheckUpdateAtStartup
      // 
      resources.ApplyResources(this.EditCheckUpdateAtStartup, "EditCheckUpdateAtStartup");
      this.EditCheckUpdateAtStartup.Name = "EditCheckUpdateAtStartup";
      this.EditCheckUpdateAtStartup.UseVisualStyleBackColor = true;
      this.EditCheckUpdateAtStartup.CheckedChanged += new System.EventHandler(this.EditCheckUpdateAtStartup_CheckedChanged);
      // 
      // EditCheckUpdateAtStartupInterval
      // 
      this.EditCheckUpdateAtStartupInterval.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditCheckUpdateAtStartupInterval, "EditCheckUpdateAtStartupInterval");
      this.EditCheckUpdateAtStartupInterval.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.EditCheckUpdateAtStartupInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.EditCheckUpdateAtStartupInterval.Name = "EditCheckUpdateAtStartupInterval";
      this.EditCheckUpdateAtStartupInterval.ReadOnly = true;
      this.EditCheckUpdateAtStartupInterval.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
      // 
      // EditVacuumAtStartupInterval
      // 
      this.EditVacuumAtStartupInterval.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditVacuumAtStartupInterval, "EditVacuumAtStartupInterval");
      this.EditVacuumAtStartupInterval.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.EditVacuumAtStartupInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.EditVacuumAtStartupInterval.Name = "EditVacuumAtStartupInterval";
      this.EditVacuumAtStartupInterval.ReadOnly = true;
      this.EditVacuumAtStartupInterval.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
      // 
      // EditVacuumAtStartup
      // 
      resources.ApplyResources(this.EditVacuumAtStartup, "EditVacuumAtStartup");
      this.EditVacuumAtStartup.Name = "EditVacuumAtStartup";
      this.EditVacuumAtStartup.UseVisualStyleBackColor = true;
      this.EditVacuumAtStartup.CheckedChanged += new System.EventHandler(this.EditVacuumAtStartup_CheckedChanged);
      // 
      // LabelInfoOptimizeDatabaseIntervalInfo
      // 
      resources.ApplyResources(this.LabelInfoOptimizeDatabaseIntervalInfo, "LabelInfoOptimizeDatabaseIntervalInfo");
      this.LabelInfoOptimizeDatabaseIntervalInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoOptimizeDatabaseIntervalInfo.Name = "LabelInfoOptimizeDatabaseIntervalInfo";
      // 
      // TabPageApplication
      // 
      this.TabPageApplication.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageApplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageApplication.Controls.Add(this.EditSearchHebrewCharsInBold);
      this.TabPageApplication.Controls.Add(this.EditVolume);
      this.TabPageApplication.Controls.Add(this.LabelVolume);
      this.TabPageApplication.Controls.Add(this.LabelVolumeValue);
      this.TabPageApplication.Controls.Add(this.EditTrayIconEnabled);
      this.TabPageApplication.Controls.Add(this.ActionSelectLangEN);
      this.TabPageApplication.Controls.Add(this.ActionSelectLangFR);
      this.TabPageApplication.Controls.Add(this.EditWindowsDoubleBufferingEnabled);
      this.TabPageApplication.Controls.Add(this.EditBookmarksWithParashah);
      this.TabPageApplication.Controls.Add(this.EditDatabaseRestoreAskToBackup);
      this.TabPageApplication.Controls.Add(this.EditBookmarksWithTranslation);
      this.TabPageApplication.Controls.Add(this.EditBookNameHebrewWithParashah);
      this.TabPageApplication.Controls.Add(this.EditBookNameHebrewWithCommonName);
      this.TabPageApplication.Controls.Add(this.EditWebLinksMenuEnabled);
      this.TabPageApplication.Controls.Add(this.EditDebuggerEnabled);
      this.TabPageApplication.Controls.Add(this.EditSystemStatisticsCalculateDbSize);
      this.TabPageApplication.Controls.Add(this.EditUsageStatisticsEnabled);
      this.TabPageApplication.Controls.Add(this.EditLogEnabled);
      resources.ApplyResources(this.TabPageApplication, "TabPageApplication");
      this.TabPageApplication.Name = "TabPageApplication";
      // 
      // EditSearchHebrewCharsInBold
      // 
      resources.ApplyResources(this.EditSearchHebrewCharsInBold, "EditSearchHebrewCharsInBold");
      this.EditSearchHebrewCharsInBold.Name = "EditSearchHebrewCharsInBold";
      this.EditSearchHebrewCharsInBold.UseVisualStyleBackColor = true;
      this.EditSearchHebrewCharsInBold.CheckedChanged += new System.EventHandler(this.EditSearchHebrewCharsInBold_CheckedChanged);
      // 
      // EditVolume
      // 
      resources.ApplyResources(this.EditVolume, "EditVolume");
      this.EditVolume.Maximum = 100;
      this.EditVolume.Name = "EditVolume";
      this.EditVolume.TickFrequency = 10;
      this.EditVolume.Value = 100;
      this.EditVolume.ValueChanged += new System.EventHandler(this.EditVolume_ValueChanged);
      // 
      // LabelVolume
      // 
      resources.ApplyResources(this.LabelVolume, "LabelVolume");
      this.LabelVolume.Name = "LabelVolume";
      // 
      // LabelVolumeValue
      // 
      resources.ApplyResources(this.LabelVolumeValue, "LabelVolumeValue");
      this.LabelVolumeValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelVolumeValue.Name = "LabelVolumeValue";
      // 
      // EditTrayIconEnabled
      // 
      resources.ApplyResources(this.EditTrayIconEnabled, "EditTrayIconEnabled");
      this.EditTrayIconEnabled.Name = "EditTrayIconEnabled";
      this.EditTrayIconEnabled.UseVisualStyleBackColor = true;
      this.EditTrayIconEnabled.CheckedChanged += new System.EventHandler(this.EditUsageStatisticsEnabled_CheckedChanged);
      // 
      // ActionSelectLangEN
      // 
      this.ActionSelectLangEN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
      resources.ApplyResources(this.ActionSelectLangEN, "ActionSelectLangEN");
      this.ActionSelectLangEN.Name = "ActionSelectLangEN";
      this.ActionSelectLangEN.TabStop = false;
      this.ActionSelectLangEN.UseVisualStyleBackColor = true;
      this.ActionSelectLangEN.Click += new System.EventHandler(this.ActionSelectLangEN_Click);
      // 
      // ActionSelectLangFR
      // 
      this.ActionSelectLangFR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
      resources.ApplyResources(this.ActionSelectLangFR, "ActionSelectLangFR");
      this.ActionSelectLangFR.Name = "ActionSelectLangFR";
      this.ActionSelectLangFR.TabStop = false;
      this.ActionSelectLangFR.UseVisualStyleBackColor = true;
      this.ActionSelectLangFR.Click += new System.EventHandler(this.ActionSelectLangFR_Click);
      // 
      // EditWindowsDoubleBufferingEnabled
      // 
      resources.ApplyResources(this.EditWindowsDoubleBufferingEnabled, "EditWindowsDoubleBufferingEnabled");
      this.EditWindowsDoubleBufferingEnabled.Name = "EditWindowsDoubleBufferingEnabled";
      this.EditWindowsDoubleBufferingEnabled.UseVisualStyleBackColor = true;
      // 
      // EditBookmarksWithParashah
      // 
      resources.ApplyResources(this.EditBookmarksWithParashah, "EditBookmarksWithParashah");
      this.EditBookmarksWithParashah.Name = "EditBookmarksWithParashah";
      this.EditBookmarksWithParashah.UseVisualStyleBackColor = true;
      this.EditBookmarksWithParashah.CheckedChanged += new System.EventHandler(this.EditBookNameHebrewWithCommonName_CheckedChanged);
      // 
      // EditDatabaseRestoreAskToBackup
      // 
      resources.ApplyResources(this.EditDatabaseRestoreAskToBackup, "EditDatabaseRestoreAskToBackup");
      this.EditDatabaseRestoreAskToBackup.Name = "EditDatabaseRestoreAskToBackup";
      this.EditDatabaseRestoreAskToBackup.UseVisualStyleBackColor = true;
      this.EditDatabaseRestoreAskToBackup.CheckedChanged += new System.EventHandler(this.EditBookNameHebrewWithCommonName_CheckedChanged);
      // 
      // EditBookmarksWithTranslation
      // 
      resources.ApplyResources(this.EditBookmarksWithTranslation, "EditBookmarksWithTranslation");
      this.EditBookmarksWithTranslation.Name = "EditBookmarksWithTranslation";
      this.EditBookmarksWithTranslation.UseVisualStyleBackColor = true;
      this.EditBookmarksWithTranslation.CheckedChanged += new System.EventHandler(this.EditBookNameHebrewWithCommonName_CheckedChanged);
      // 
      // EditBookNameHebrewWithParashah
      // 
      resources.ApplyResources(this.EditBookNameHebrewWithParashah, "EditBookNameHebrewWithParashah");
      this.EditBookNameHebrewWithParashah.Name = "EditBookNameHebrewWithParashah";
      this.EditBookNameHebrewWithParashah.UseVisualStyleBackColor = true;
      this.EditBookNameHebrewWithParashah.CheckedChanged += new System.EventHandler(this.EditBookNameHebrewWithCommonName_CheckedChanged);
      // 
      // EditBookNameHebrewWithCommonName
      // 
      resources.ApplyResources(this.EditBookNameHebrewWithCommonName, "EditBookNameHebrewWithCommonName");
      this.EditBookNameHebrewWithCommonName.Name = "EditBookNameHebrewWithCommonName";
      this.EditBookNameHebrewWithCommonName.UseVisualStyleBackColor = true;
      this.EditBookNameHebrewWithCommonName.CheckedChanged += new System.EventHandler(this.EditBookNameHebrewWithCommonName_CheckedChanged);
      // 
      // EditWebLinksMenuEnabled
      // 
      resources.ApplyResources(this.EditWebLinksMenuEnabled, "EditWebLinksMenuEnabled");
      this.EditWebLinksMenuEnabled.Name = "EditWebLinksMenuEnabled";
      this.EditWebLinksMenuEnabled.UseVisualStyleBackColor = true;
      // 
      // EditDebuggerEnabled
      // 
      resources.ApplyResources(this.EditDebuggerEnabled, "EditDebuggerEnabled");
      this.EditDebuggerEnabled.Name = "EditDebuggerEnabled";
      this.EditDebuggerEnabled.UseVisualStyleBackColor = true;
      this.EditDebuggerEnabled.CheckedChanged += new System.EventHandler(this.EditDebuggerEnabled_CheckedChanged);
      // 
      // EditSystemStatisticsCalculateDbSize
      // 
      resources.ApplyResources(this.EditSystemStatisticsCalculateDbSize, "EditSystemStatisticsCalculateDbSize");
      this.EditSystemStatisticsCalculateDbSize.Name = "EditSystemStatisticsCalculateDbSize";
      this.EditSystemStatisticsCalculateDbSize.UseVisualStyleBackColor = true;
      this.EditSystemStatisticsCalculateDbSize.CheckedChanged += new System.EventHandler(this.EditUsageStatisticsEnabled_CheckedChanged);
      // 
      // EditUsageStatisticsEnabled
      // 
      resources.ApplyResources(this.EditUsageStatisticsEnabled, "EditUsageStatisticsEnabled");
      this.EditUsageStatisticsEnabled.Name = "EditUsageStatisticsEnabled";
      this.EditUsageStatisticsEnabled.UseVisualStyleBackColor = true;
      this.EditUsageStatisticsEnabled.CheckedChanged += new System.EventHandler(this.EditUsageStatisticsEnabled_CheckedChanged);
      // 
      // EditLogEnabled
      // 
      resources.ApplyResources(this.EditLogEnabled, "EditLogEnabled");
      this.EditLogEnabled.Name = "EditLogEnabled";
      this.EditLogEnabled.UseVisualStyleBackColor = true;
      this.EditLogEnabled.CheckedChanged += new System.EventHandler(this.EditLogEnabled_CheckedChanged);
      // 
      // ActionCheckAllComments
      // 
      this.ActionCheckAllComments.AllowDrop = true;
      this.ActionCheckAllComments.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionCheckAllComments, "ActionCheckAllComments");
      this.ActionCheckAllComments.Name = "ActionCheckAllComments";
      this.ActionCheckAllComments.UseVisualStyleBackColor = true;
      this.ActionCheckAllComments.Click += new System.EventHandler(this.ActionCheckAllComments_Click);
      // 
      // LabelInfoAutoSaveDelay
      // 
      resources.ApplyResources(this.LabelInfoAutoSaveDelay, "LabelInfoAutoSaveDelay");
      this.LabelInfoAutoSaveDelay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoAutoSaveDelay.Name = "LabelInfoAutoSaveDelay";
      // 
      // EditAutoSaveDelay
      // 
      this.EditAutoSaveDelay.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditAutoSaveDelay, "EditAutoSaveDelay");
      this.EditAutoSaveDelay.Name = "EditAutoSaveDelay";
      this.EditAutoSaveDelay.ReadOnly = true;
      // 
      // EditCommentLineRemovePrefix
      // 
      resources.ApplyResources(this.EditCommentLineRemovePrefix, "EditCommentLineRemovePrefix");
      this.EditCommentLineRemovePrefix.Name = "EditCommentLineRemovePrefix";
      this.EditCommentLineRemovePrefix.UseVisualStyleBackColor = true;
      this.EditCommentLineRemovePrefix.CheckedChanged += new System.EventHandler(this.EditCommentLineRemovePrefix_CheckedChanged);
      // 
      // EditCommentLineAddPrefix
      // 
      resources.ApplyResources(this.EditCommentLineAddPrefix, "EditCommentLineAddPrefix");
      this.EditCommentLineAddPrefix.Name = "EditCommentLineAddPrefix";
      this.EditCommentLineAddPrefix.UseVisualStyleBackColor = true;
      this.EditCommentLineAddPrefix.CheckedChanged += new System.EventHandler(this.EditCommentLineAddPrefix_CheckedChanged);
      // 
      // EditAutoSortBookmarks
      // 
      resources.ApplyResources(this.EditAutoSortBookmarks, "EditAutoSortBookmarks");
      this.EditAutoSortBookmarks.Name = "EditAutoSortBookmarks";
      this.EditAutoSortBookmarks.UseVisualStyleBackColor = true;
      // 
      // TabControl
      // 
      resources.ApplyResources(this.TabControl, "TabControl");
      this.TabControl.Controls.Add(this.TabPageApplication);
      this.TabControl.Controls.Add(this.TabPageStartup);
      this.TabControl.Controls.Add(this.TabPageBookmarks);
      this.TabControl.Controls.Add(this.TabPageEditing);
      this.TabControl.Controls.Add(this.TabPageRendering);
      this.TabControl.Controls.Add(this.TabPageTheme);
      this.TabControl.Controls.Add(this.TabPageMouse);
      this.TabControl.Controls.Add(this.TabPageMSWord);
      this.TabControl.Controls.Add(this.TabPageExport);
      this.TabControl.Controls.Add(this.TabPagePaths);
      this.TabControl.Controls.Add(this.TabPageTools);
      this.TabControl.Multiline = true;
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      // 
      // TabPageBookmarks
      // 
      this.TabPageBookmarks.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageBookmarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageBookmarks.Controls.Add(this.EditAutoSortBookmarks);
      this.TabPageBookmarks.Controls.Add(LabelBookmarksCount);
      this.TabPageBookmarks.Controls.Add(this.EditHistoryCount);
      this.TabPageBookmarks.Controls.Add(this.LabelInfoHistoryCount);
      this.TabPageBookmarks.Controls.Add(LabelHistoryCount);
      this.TabPageBookmarks.Controls.Add(this.EditBookmarksCount);
      this.TabPageBookmarks.Controls.Add(this.LabelInfoBookmarksCount);
      resources.ApplyResources(this.TabPageBookmarks, "TabPageBookmarks");
      this.TabPageBookmarks.Name = "TabPageBookmarks";
      // 
      // EditHistoryCount
      // 
      this.EditHistoryCount.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditHistoryCount, "EditHistoryCount");
      this.EditHistoryCount.Name = "EditHistoryCount";
      this.EditHistoryCount.ReadOnly = true;
      // 
      // LabelInfoHistoryCount
      // 
      resources.ApplyResources(this.LabelInfoHistoryCount, "LabelInfoHistoryCount");
      this.LabelInfoHistoryCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoHistoryCount.Name = "LabelInfoHistoryCount";
      // 
      // EditBookmarksCount
      // 
      this.EditBookmarksCount.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditBookmarksCount, "EditBookmarksCount");
      this.EditBookmarksCount.Name = "EditBookmarksCount";
      this.EditBookmarksCount.ReadOnly = true;
      // 
      // LabelInfoBookmarksCount
      // 
      resources.ApplyResources(this.LabelInfoBookmarksCount, "LabelInfoBookmarksCount");
      this.LabelInfoBookmarksCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoBookmarksCount.Name = "LabelInfoBookmarksCount";
      // 
      // TabPageEditing
      // 
      this.TabPageEditing.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageEditing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageEditing.Controls.Add(this.ActionCheckAllComments);
      this.TabPageEditing.Controls.Add(this.EditCommentLineAddPrefix);
      this.TabPageEditing.Controls.Add(this.EditCommentLineRemovePrefix);
      this.TabPageEditing.Controls.Add(this.EditSpellCheckEnabled);
      this.TabPageEditing.Controls.Add(this.EditWordControlTabInverted);
      this.TabPageEditing.Controls.Add(this.EditAutoSaveOnLeaveControl);
      this.TabPageEditing.Controls.Add(LabelAutoSaveDelay);
      this.TabPageEditing.Controls.Add(this.LabelInfoAutoSaveDelay);
      this.TabPageEditing.Controls.Add(this.EditAutoSaveDelay);
      this.TabPageEditing.Controls.Add(this.EditCommentLinePrefix);
      resources.ApplyResources(this.TabPageEditing, "TabPageEditing");
      this.TabPageEditing.Name = "TabPageEditing";
      // 
      // EditSpellCheckEnabled
      // 
      resources.ApplyResources(this.EditSpellCheckEnabled, "EditSpellCheckEnabled");
      this.EditSpellCheckEnabled.Name = "EditSpellCheckEnabled";
      this.EditSpellCheckEnabled.UseVisualStyleBackColor = true;
      this.EditSpellCheckEnabled.CheckedChanged += new System.EventHandler(this.EditUseSpellCheck_CheckedChanged);
      // 
      // EditWordControlTabInverted
      // 
      resources.ApplyResources(this.EditWordControlTabInverted, "EditWordControlTabInverted");
      this.EditWordControlTabInverted.Name = "EditWordControlTabInverted";
      this.EditWordControlTabInverted.UseVisualStyleBackColor = true;
      // 
      // EditAutoSaveOnLeaveControl
      // 
      resources.ApplyResources(this.EditAutoSaveOnLeaveControl, "EditAutoSaveOnLeaveControl");
      this.EditAutoSaveOnLeaveControl.Name = "EditAutoSaveOnLeaveControl";
      this.EditAutoSaveOnLeaveControl.UseVisualStyleBackColor = true;
      // 
      // EditCommentLinePrefix
      // 
      this.EditCommentLinePrefix.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      resources.ApplyResources(this.EditCommentLinePrefix, "EditCommentLinePrefix");
      this.EditCommentLinePrefix.Name = "EditCommentLinePrefix";
      this.EditCommentLinePrefix.SpellCheckAllowed = false;
      // 
      // TabPageRendering
      // 
      this.TabPageRendering.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageRendering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageRendering.Controls.Add(this.ActionResetRendering);
      this.TabPageRendering.Controls.Add(this.LabelInfoSearchMinRefForDialog);
      this.TabPageRendering.Controls.Add(this.LabelInfoSearchDisplayMaxRef);
      this.TabPageRendering.Controls.Add(this.LabelFontSizeCommentaryInfo);
      this.TabPageRendering.Controls.Add(this.LabelFontSizeTranslationInfo);
      this.TabPageRendering.Controls.Add(this.LabelFontSizeHebrewInfo);
      this.TabPageRendering.Controls.Add(this.LabelInfoWordControlWidth);
      this.TabPageRendering.Controls.Add(this.LabelWordtranslateLinesCountInfo);
      this.TabPageRendering.Controls.Add(this.LabelInfoCommentLinesCountInfos);
      this.TabPageRendering.Controls.Add(this.EditFontSizeCommentary);
      this.TabPageRendering.Controls.Add(this.EditFontSizeTranslation);
      this.TabPageRendering.Controls.Add(this.EditFontSizeHebrew);
      this.TabPageRendering.Controls.Add(this.EditWordControlWidth);
      this.TabPageRendering.Controls.Add(LabelFontSizeComentary);
      this.TabPageRendering.Controls.Add(LabelFontSizeTranslation);
      this.TabPageRendering.Controls.Add(LabelFontSizeHebrew);
      this.TabPageRendering.Controls.Add(LabelWordControlWidth);
      this.TabPageRendering.Controls.Add(this.EditSearchMinRefForDialog);
      this.TabPageRendering.Controls.Add(LabelMinRefCount);
      this.TabPageRendering.Controls.Add(this.EditSearchDisplayMaxRef);
      this.TabPageRendering.Controls.Add(LabelMaxRefCount);
      this.TabPageRendering.Controls.Add(this.EditWordTranslateLinesCount);
      this.TabPageRendering.Controls.Add(LabelWordtranslateLinesCount);
      this.TabPageRendering.Controls.Add(this.EditCommentaryLinesCount);
      this.TabPageRendering.Controls.Add(LabelCommentaryLinesCount);
      resources.ApplyResources(this.TabPageRendering, "TabPageRendering");
      this.TabPageRendering.Name = "TabPageRendering";
      // 
      // ActionResetRendering
      // 
      this.ActionResetRendering.AllowDrop = true;
      resources.ApplyResources(this.ActionResetRendering, "ActionResetRendering");
      this.ActionResetRendering.FlatAppearance.BorderSize = 0;
      this.ActionResetRendering.Name = "ActionResetRendering";
      this.ActionResetRendering.UseVisualStyleBackColor = true;
      this.ActionResetRendering.Click += new System.EventHandler(this.ActionResetRendering_Click);
      // 
      // LabelInfoSearchMinRefForDialog
      // 
      resources.ApplyResources(this.LabelInfoSearchMinRefForDialog, "LabelInfoSearchMinRefForDialog");
      this.LabelInfoSearchMinRefForDialog.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoSearchMinRefForDialog.Name = "LabelInfoSearchMinRefForDialog";
      // 
      // LabelInfoSearchDisplayMaxRef
      // 
      resources.ApplyResources(this.LabelInfoSearchDisplayMaxRef, "LabelInfoSearchDisplayMaxRef");
      this.LabelInfoSearchDisplayMaxRef.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoSearchDisplayMaxRef.Name = "LabelInfoSearchDisplayMaxRef";
      // 
      // LabelFontSizeCommentaryInfo
      // 
      resources.ApplyResources(this.LabelFontSizeCommentaryInfo, "LabelFontSizeCommentaryInfo");
      this.LabelFontSizeCommentaryInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelFontSizeCommentaryInfo.Name = "LabelFontSizeCommentaryInfo";
      // 
      // LabelFontSizeTranslationInfo
      // 
      resources.ApplyResources(this.LabelFontSizeTranslationInfo, "LabelFontSizeTranslationInfo");
      this.LabelFontSizeTranslationInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelFontSizeTranslationInfo.Name = "LabelFontSizeTranslationInfo";
      // 
      // LabelFontSizeHebrewInfo
      // 
      resources.ApplyResources(this.LabelFontSizeHebrewInfo, "LabelFontSizeHebrewInfo");
      this.LabelFontSizeHebrewInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelFontSizeHebrewInfo.Name = "LabelFontSizeHebrewInfo";
      // 
      // LabelInfoWordControlWidth
      // 
      resources.ApplyResources(this.LabelInfoWordControlWidth, "LabelInfoWordControlWidth");
      this.LabelInfoWordControlWidth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoWordControlWidth.Name = "LabelInfoWordControlWidth";
      // 
      // LabelWordtranslateLinesCountInfo
      // 
      resources.ApplyResources(this.LabelWordtranslateLinesCountInfo, "LabelWordtranslateLinesCountInfo");
      this.LabelWordtranslateLinesCountInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelWordtranslateLinesCountInfo.Name = "LabelWordtranslateLinesCountInfo";
      // 
      // LabelInfoCommentLinesCountInfos
      // 
      resources.ApplyResources(this.LabelInfoCommentLinesCountInfos, "LabelInfoCommentLinesCountInfos");
      this.LabelInfoCommentLinesCountInfos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoCommentLinesCountInfos.Name = "LabelInfoCommentLinesCountInfos";
      // 
      // EditFontSizeCommentary
      // 
      this.EditFontSizeCommentary.BackColor = System.Drawing.SystemColors.Window;
      this.EditFontSizeCommentary.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      resources.ApplyResources(this.EditFontSizeCommentary, "EditFontSizeCommentary");
      this.EditFontSizeCommentary.Name = "EditFontSizeCommentary";
      this.EditFontSizeCommentary.ReadOnly = true;
      this.EditFontSizeCommentary.ValueChanged += new System.EventHandler(this.EditRenderVerseControl_ValueChanged);
      // 
      // EditFontSizeTranslation
      // 
      this.EditFontSizeTranslation.BackColor = System.Drawing.SystemColors.Window;
      this.EditFontSizeTranslation.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      resources.ApplyResources(this.EditFontSizeTranslation, "EditFontSizeTranslation");
      this.EditFontSizeTranslation.Name = "EditFontSizeTranslation";
      this.EditFontSizeTranslation.ReadOnly = true;
      this.EditFontSizeTranslation.ValueChanged += new System.EventHandler(this.EditRenderWordControl_ValueChanged);
      // 
      // EditFontSizeHebrew
      // 
      this.EditFontSizeHebrew.BackColor = System.Drawing.SystemColors.Window;
      this.EditFontSizeHebrew.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      resources.ApplyResources(this.EditFontSizeHebrew, "EditFontSizeHebrew");
      this.EditFontSizeHebrew.Name = "EditFontSizeHebrew";
      this.EditFontSizeHebrew.ReadOnly = true;
      this.EditFontSizeHebrew.ValueChanged += new System.EventHandler(this.EditRenderWordControl_ValueChanged);
      // 
      // EditWordControlWidth
      // 
      this.EditWordControlWidth.BackColor = System.Drawing.SystemColors.Window;
      this.EditWordControlWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      resources.ApplyResources(this.EditWordControlWidth, "EditWordControlWidth");
      this.EditWordControlWidth.Name = "EditWordControlWidth";
      this.EditWordControlWidth.ReadOnly = true;
      // 
      // EditSearchMinRefForDialog
      // 
      this.EditSearchMinRefForDialog.BackColor = System.Drawing.SystemColors.Window;
      this.EditSearchMinRefForDialog.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      resources.ApplyResources(this.EditSearchMinRefForDialog, "EditSearchMinRefForDialog");
      this.EditSearchMinRefForDialog.Name = "EditSearchMinRefForDialog";
      this.EditSearchMinRefForDialog.ReadOnly = true;
      // 
      // EditSearchDisplayMaxRef
      // 
      this.EditSearchDisplayMaxRef.BackColor = System.Drawing.SystemColors.Window;
      this.EditSearchDisplayMaxRef.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      resources.ApplyResources(this.EditSearchDisplayMaxRef, "EditSearchDisplayMaxRef");
      this.EditSearchDisplayMaxRef.Name = "EditSearchDisplayMaxRef";
      this.EditSearchDisplayMaxRef.ReadOnly = true;
      this.EditSearchDisplayMaxRef.ValueChanged += new System.EventHandler(this.EditMaxRefCount_ValueChanged);
      // 
      // EditWordTranslateLinesCount
      // 
      this.EditWordTranslateLinesCount.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditWordTranslateLinesCount, "EditWordTranslateLinesCount");
      this.EditWordTranslateLinesCount.Name = "EditWordTranslateLinesCount";
      this.EditWordTranslateLinesCount.ReadOnly = true;
      this.EditWordTranslateLinesCount.ValueChanged += new System.EventHandler(this.EditRenderWordControl_ValueChanged);
      // 
      // EditCommentaryLinesCount
      // 
      this.EditCommentaryLinesCount.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditCommentaryLinesCount, "EditCommentaryLinesCount");
      this.EditCommentaryLinesCount.Name = "EditCommentaryLinesCount";
      this.EditCommentaryLinesCount.ReadOnly = true;
      this.EditCommentaryLinesCount.ValueChanged += new System.EventHandler(this.EditRenderVerseControl_ValueChanged);
      // 
      // TabPageTheme
      // 
      this.TabPageTheme.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageTheme.Controls.Add(this.ActionOpenTheme);
      this.TabPageTheme.Controls.Add(this.ActionSaveTheme);
      this.TabPageTheme.Controls.Add(this.LabelThemeVerseNumberColor);
      this.TabPageTheme.Controls.Add(this.EditThemeVerseNumberColor);
      this.TabPageTheme.Controls.Add(this.label8);
      this.TabPageTheme.Controls.Add(this.LabelThemeVerseHebrewColor);
      this.TabPageTheme.Controls.Add(this.EditThemeNavigatorItems);
      this.TabPageTheme.Controls.Add(this.EditThemeVerseHebrewColor);
      this.TabPageTheme.Controls.Add(this.label4);
      this.TabPageTheme.Controls.Add(this.LabelThemeTranslationTextColor);
      this.TabPageTheme.Controls.Add(this.LabelThemeVerseHebrewColorHover);
      this.TabPageTheme.Controls.Add(this.EditThemeTranslationTextColor);
      this.TabPageTheme.Controls.Add(this.EditThemeTranslationBack);
      this.TabPageTheme.Controls.Add(this.EditThemeVerseHebrewColorHover);
      this.TabPageTheme.Controls.Add(this.label2);
      this.TabPageTheme.Controls.Add(this.LabelThemeVerseNumberColorHover);
      this.TabPageTheme.Controls.Add(this.EditThemeCommentaryBack);
      this.TabPageTheme.Controls.Add(this.EditThemeVerseNumberColorHover);
      this.TabPageTheme.Controls.Add(this.label1);
      this.TabPageTheme.Controls.Add(this.EditThemeCurrentControl);
      this.TabPageTheme.Controls.Add(this.label3);
      this.TabPageTheme.Controls.Add(this.EditThemeSearchLettersBack);
      this.TabPageTheme.Controls.Add(this.EditThemeSearchWordBack);
      this.TabPageTheme.Controls.Add(this.label6);
      this.TabPageTheme.Controls.Add(this.ActionUseColorsPastel);
      this.TabPageTheme.Controls.Add(this.ActionUseColorsSystem);
      resources.ApplyResources(this.TabPageTheme, "TabPageTheme");
      this.TabPageTheme.Name = "TabPageTheme";
      // 
      // ActionOpenTheme
      // 
      resources.ApplyResources(this.ActionOpenTheme, "ActionOpenTheme");
      this.ActionOpenTheme.FlatAppearance.BorderSize = 0;
      this.ActionOpenTheme.Name = "ActionOpenTheme";
      this.ActionOpenTheme.UseVisualStyleBackColor = true;
      this.ActionOpenTheme.Click += new System.EventHandler(this.ActionOpenTheme_Click);
      // 
      // ActionSaveTheme
      // 
      resources.ApplyResources(this.ActionSaveTheme, "ActionSaveTheme");
      this.ActionSaveTheme.FlatAppearance.BorderSize = 0;
      this.ActionSaveTheme.Name = "ActionSaveTheme";
      this.ActionSaveTheme.UseVisualStyleBackColor = true;
      this.ActionSaveTheme.Click += new System.EventHandler(this.ActionSaveTheme_Click);
      // 
      // LabelThemeVerseNumberColor
      // 
      resources.ApplyResources(this.LabelThemeVerseNumberColor, "LabelThemeVerseNumberColor");
      this.LabelThemeVerseNumberColor.Name = "LabelThemeVerseNumberColor";
      // 
      // EditThemeVerseNumberColor
      // 
      this.EditThemeVerseNumberColor.BackColor = System.Drawing.Color.DarkBlue;
      this.EditThemeVerseNumberColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeVerseNumberColor, "EditThemeVerseNumberColor");
      this.EditThemeVerseNumberColor.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeVerseNumberColor.Name = "EditThemeVerseNumberColor";
      this.EditThemeVerseNumberColor.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label8
      // 
      resources.ApplyResources(this.label8, "label8");
      this.label8.Name = "label8";
      // 
      // LabelThemeVerseHebrewColor
      // 
      resources.ApplyResources(this.LabelThemeVerseHebrewColor, "LabelThemeVerseHebrewColor");
      this.LabelThemeVerseHebrewColor.Name = "LabelThemeVerseHebrewColor";
      // 
      // EditThemeNavigatorItems
      // 
      this.EditThemeNavigatorItems.BackColor = System.Drawing.Color.LightYellow;
      this.EditThemeNavigatorItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeNavigatorItems, "EditThemeNavigatorItems");
      this.EditThemeNavigatorItems.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeNavigatorItems.Name = "EditThemeNavigatorItems";
      this.EditThemeNavigatorItems.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // EditThemeVerseHebrewColor
      // 
      this.EditThemeVerseHebrewColor.BackColor = System.Drawing.SystemColors.ControlText;
      this.EditThemeVerseHebrewColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeVerseHebrewColor, "EditThemeVerseHebrewColor");
      this.EditThemeVerseHebrewColor.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeVerseHebrewColor.Name = "EditThemeVerseHebrewColor";
      this.EditThemeVerseHebrewColor.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // LabelThemeTranslationTextColor
      // 
      resources.ApplyResources(this.LabelThemeTranslationTextColor, "LabelThemeTranslationTextColor");
      this.LabelThemeTranslationTextColor.Name = "LabelThemeTranslationTextColor";
      // 
      // LabelThemeVerseHebrewColorHover
      // 
      resources.ApplyResources(this.LabelThemeVerseHebrewColorHover, "LabelThemeVerseHebrewColorHover");
      this.LabelThemeVerseHebrewColorHover.Name = "LabelThemeVerseHebrewColorHover";
      // 
      // EditThemeTranslationTextColor
      // 
      this.EditThemeTranslationTextColor.BackColor = System.Drawing.SystemColors.ControlText;
      this.EditThemeTranslationTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeTranslationTextColor, "EditThemeTranslationTextColor");
      this.EditThemeTranslationTextColor.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeTranslationTextColor.Name = "EditThemeTranslationTextColor";
      this.EditThemeTranslationTextColor.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // EditThemeTranslationBack
      // 
      this.EditThemeTranslationBack.BackColor = System.Drawing.SystemColors.Window;
      this.EditThemeTranslationBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeTranslationBack, "EditThemeTranslationBack");
      this.EditThemeTranslationBack.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeTranslationBack.Name = "EditThemeTranslationBack";
      this.EditThemeTranslationBack.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // EditThemeVerseHebrewColorHover
      // 
      this.EditThemeVerseHebrewColorHover.BackColor = System.Drawing.Color.DarkRed;
      this.EditThemeVerseHebrewColorHover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeVerseHebrewColorHover, "EditThemeVerseHebrewColorHover");
      this.EditThemeVerseHebrewColorHover.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeVerseHebrewColorHover.Name = "EditThemeVerseHebrewColorHover";
      this.EditThemeVerseHebrewColorHover.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // LabelThemeVerseNumberColorHover
      // 
      resources.ApplyResources(this.LabelThemeVerseNumberColorHover, "LabelThemeVerseNumberColorHover");
      this.LabelThemeVerseNumberColorHover.Name = "LabelThemeVerseNumberColorHover";
      // 
      // EditThemeCommentaryBack
      // 
      this.EditThemeCommentaryBack.BackColor = System.Drawing.Color.Honeydew;
      this.EditThemeCommentaryBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeCommentaryBack, "EditThemeCommentaryBack");
      this.EditThemeCommentaryBack.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeCommentaryBack.Name = "EditThemeCommentaryBack";
      this.EditThemeCommentaryBack.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // EditThemeVerseNumberColorHover
      // 
      this.EditThemeVerseNumberColorHover.BackColor = System.Drawing.Color.RoyalBlue;
      this.EditThemeVerseNumberColorHover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeVerseNumberColorHover, "EditThemeVerseNumberColorHover");
      this.EditThemeVerseNumberColorHover.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeVerseNumberColorHover.Name = "EditThemeVerseNumberColorHover";
      this.EditThemeVerseNumberColorHover.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // EditThemeCurrentControl
      // 
      this.EditThemeCurrentControl.BackColor = System.Drawing.Color.AliceBlue;
      this.EditThemeCurrentControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeCurrentControl, "EditThemeCurrentControl");
      this.EditThemeCurrentControl.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeCurrentControl.Name = "EditThemeCurrentControl";
      this.EditThemeCurrentControl.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // EditThemeSearchLettersBack
      // 
      this.EditThemeSearchLettersBack.BackColor = System.Drawing.Color.LightYellow;
      this.EditThemeSearchLettersBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeSearchLettersBack, "EditThemeSearchLettersBack");
      this.EditThemeSearchLettersBack.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeSearchLettersBack.Name = "EditThemeSearchLettersBack";
      this.EditThemeSearchLettersBack.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // EditThemeSearchWordBack
      // 
      this.EditThemeSearchWordBack.BackColor = System.Drawing.Color.AliceBlue;
      this.EditThemeSearchWordBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.EditThemeSearchWordBack, "EditThemeSearchWordBack");
      this.EditThemeSearchWordBack.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeSearchWordBack.Name = "EditThemeSearchWordBack";
      this.EditThemeSearchWordBack.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label6
      // 
      resources.ApplyResources(this.label6, "label6");
      this.label6.Name = "label6";
      // 
      // ActionUseColorsPastel
      // 
      this.ActionUseColorsPastel.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      resources.ApplyResources(this.ActionUseColorsPastel, "ActionUseColorsPastel");
      this.ActionUseColorsPastel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.ActionUseColorsPastel.LinkColor = System.Drawing.Color.Navy;
      this.ActionUseColorsPastel.Name = "ActionUseColorsPastel";
      this.ActionUseColorsPastel.TabStop = true;
      this.ActionUseColorsPastel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ActionUseColorsPastel_LinkClicked);
      // 
      // ActionUseColorsSystem
      // 
      this.ActionUseColorsSystem.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      resources.ApplyResources(this.ActionUseColorsSystem, "ActionUseColorsSystem");
      this.ActionUseColorsSystem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.ActionUseColorsSystem.LinkColor = System.Drawing.Color.Navy;
      this.ActionUseColorsSystem.Name = "ActionUseColorsSystem";
      this.ActionUseColorsSystem.TabStop = true;
      this.ActionUseColorsSystem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ActionUseColorsSystem_LinkClicked);
      // 
      // TabPageMouse
      // 
      this.TabPageMouse.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageMouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageMouse.Controls.Add(this.GroupBoxHebrewWordClickShift);
      this.TabPageMouse.Controls.Add(this.GroupBoxVerseLabelClick);
      this.TabPageMouse.Controls.Add(this.GroupBoxHebrewWordClick);
      this.TabPageMouse.Controls.Add(this.GroupBoxHebrewWordClickAlt);
      this.TabPageMouse.Controls.Add(this.GroupBoxHebrewWordClickCtrl);
      this.TabPageMouse.Controls.Add(this.GroupBoxTranslatedItemDoubleClick);
      resources.ApplyResources(this.TabPageMouse, "TabPageMouse");
      this.TabPageMouse.Name = "TabPageMouse";
      // 
      // GroupBoxHebrewWordClickShift
      // 
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift5);
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift0);
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift1);
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift3);
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift2);
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift4);
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift, "GroupBoxHebrewWordClickShift");
      this.GroupBoxHebrewWordClickShift.Name = "GroupBoxHebrewWordClickShift";
      this.GroupBoxHebrewWordClickShift.TabStop = false;
      // 
      // GroupBoxHebrewWordClickShift5
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift5, "GroupBoxHebrewWordClickShift5");
      this.GroupBoxHebrewWordClickShift5.Name = "GroupBoxHebrewWordClickShift5";
      this.GroupBoxHebrewWordClickShift5.TabStop = true;
      this.GroupBoxHebrewWordClickShift5.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShift0
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift0, "GroupBoxHebrewWordClickShift0");
      this.GroupBoxHebrewWordClickShift0.Name = "GroupBoxHebrewWordClickShift0";
      this.GroupBoxHebrewWordClickShift0.TabStop = true;
      this.GroupBoxHebrewWordClickShift0.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShift1
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift1, "GroupBoxHebrewWordClickShift1");
      this.GroupBoxHebrewWordClickShift1.Name = "GroupBoxHebrewWordClickShift1";
      this.GroupBoxHebrewWordClickShift1.TabStop = true;
      this.GroupBoxHebrewWordClickShift1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShift3
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift3, "GroupBoxHebrewWordClickShift3");
      this.GroupBoxHebrewWordClickShift3.Name = "GroupBoxHebrewWordClickShift3";
      this.GroupBoxHebrewWordClickShift3.TabStop = true;
      this.GroupBoxHebrewWordClickShift3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShift2
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift2, "GroupBoxHebrewWordClickShift2");
      this.GroupBoxHebrewWordClickShift2.Name = "GroupBoxHebrewWordClickShift2";
      this.GroupBoxHebrewWordClickShift2.TabStop = true;
      this.GroupBoxHebrewWordClickShift2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShift4
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift4, "GroupBoxHebrewWordClickShift4");
      this.GroupBoxHebrewWordClickShift4.Name = "GroupBoxHebrewWordClickShift4";
      this.GroupBoxHebrewWordClickShift4.TabStop = true;
      this.GroupBoxHebrewWordClickShift4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxVerseLabelClick
      // 
      this.GroupBoxVerseLabelClick.Controls.Add(this.GroupBoxVerseLabelClick4);
      this.GroupBoxVerseLabelClick.Controls.Add(this.GroupBoxVerseLabelClick1);
      this.GroupBoxVerseLabelClick.Controls.Add(this.GroupBoxVerseLabelClick2);
      this.GroupBoxVerseLabelClick.Controls.Add(this.GroupBoxVerseLabelClick3);
      resources.ApplyResources(this.GroupBoxVerseLabelClick, "GroupBoxVerseLabelClick");
      this.GroupBoxVerseLabelClick.Name = "GroupBoxVerseLabelClick";
      this.GroupBoxVerseLabelClick.TabStop = false;
      // 
      // GroupBoxVerseLabelClick4
      // 
      resources.ApplyResources(this.GroupBoxVerseLabelClick4, "GroupBoxVerseLabelClick4");
      this.GroupBoxVerseLabelClick4.Name = "GroupBoxVerseLabelClick4";
      this.GroupBoxVerseLabelClick4.TabStop = true;
      this.GroupBoxVerseLabelClick4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxVerseLabelClick1
      // 
      resources.ApplyResources(this.GroupBoxVerseLabelClick1, "GroupBoxVerseLabelClick1");
      this.GroupBoxVerseLabelClick1.Name = "GroupBoxVerseLabelClick1";
      this.GroupBoxVerseLabelClick1.TabStop = true;
      this.GroupBoxVerseLabelClick1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxVerseLabelClick2
      // 
      resources.ApplyResources(this.GroupBoxVerseLabelClick2, "GroupBoxVerseLabelClick2");
      this.GroupBoxVerseLabelClick2.Name = "GroupBoxVerseLabelClick2";
      this.GroupBoxVerseLabelClick2.TabStop = true;
      this.GroupBoxVerseLabelClick2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxVerseLabelClick3
      // 
      resources.ApplyResources(this.GroupBoxVerseLabelClick3, "GroupBoxVerseLabelClick3");
      this.GroupBoxVerseLabelClick3.Name = "GroupBoxVerseLabelClick3";
      this.GroupBoxVerseLabelClick3.TabStop = true;
      this.GroupBoxVerseLabelClick3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick
      // 
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick5);
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick0);
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick1);
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick3);
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick2);
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick4);
      resources.ApplyResources(this.GroupBoxHebrewWordClick, "GroupBoxHebrewWordClick");
      this.GroupBoxHebrewWordClick.Name = "GroupBoxHebrewWordClick";
      this.GroupBoxHebrewWordClick.TabStop = false;
      // 
      // GroupBoxHebrewWordClick5
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick5, "GroupBoxHebrewWordClick5");
      this.GroupBoxHebrewWordClick5.Name = "GroupBoxHebrewWordClick5";
      this.GroupBoxHebrewWordClick5.TabStop = true;
      this.GroupBoxHebrewWordClick5.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick0
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick0, "GroupBoxHebrewWordClick0");
      this.GroupBoxHebrewWordClick0.Name = "GroupBoxHebrewWordClick0";
      this.GroupBoxHebrewWordClick0.TabStop = true;
      this.GroupBoxHebrewWordClick0.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick1
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick1, "GroupBoxHebrewWordClick1");
      this.GroupBoxHebrewWordClick1.Name = "GroupBoxHebrewWordClick1";
      this.GroupBoxHebrewWordClick1.TabStop = true;
      this.GroupBoxHebrewWordClick1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick3
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick3, "GroupBoxHebrewWordClick3");
      this.GroupBoxHebrewWordClick3.Name = "GroupBoxHebrewWordClick3";
      this.GroupBoxHebrewWordClick3.TabStop = true;
      this.GroupBoxHebrewWordClick3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick2
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick2, "GroupBoxHebrewWordClick2");
      this.GroupBoxHebrewWordClick2.Name = "GroupBoxHebrewWordClick2";
      this.GroupBoxHebrewWordClick2.TabStop = true;
      this.GroupBoxHebrewWordClick2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick4
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick4, "GroupBoxHebrewWordClick4");
      this.GroupBoxHebrewWordClick4.Name = "GroupBoxHebrewWordClick4";
      this.GroupBoxHebrewWordClick4.TabStop = true;
      this.GroupBoxHebrewWordClick4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickAlt
      // 
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl5);
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl0);
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl1);
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl3);
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl2);
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl4);
      resources.ApplyResources(this.GroupBoxHebrewWordClickAlt, "GroupBoxHebrewWordClickAlt");
      this.GroupBoxHebrewWordClickAlt.Name = "GroupBoxHebrewWordClickAlt";
      this.GroupBoxHebrewWordClickAlt.TabStop = false;
      // 
      // GroupBoxHebrewWordClickShiftCtrl5
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl5, "GroupBoxHebrewWordClickShiftCtrl5");
      this.GroupBoxHebrewWordClickShiftCtrl5.Name = "GroupBoxHebrewWordClickShiftCtrl5";
      this.GroupBoxHebrewWordClickShiftCtrl5.TabStop = true;
      this.GroupBoxHebrewWordClickShiftCtrl5.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShiftCtrl0
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl0, "GroupBoxHebrewWordClickShiftCtrl0");
      this.GroupBoxHebrewWordClickShiftCtrl0.Name = "GroupBoxHebrewWordClickShiftCtrl0";
      this.GroupBoxHebrewWordClickShiftCtrl0.TabStop = true;
      this.GroupBoxHebrewWordClickShiftCtrl0.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShiftCtrl1
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl1, "GroupBoxHebrewWordClickShiftCtrl1");
      this.GroupBoxHebrewWordClickShiftCtrl1.Name = "GroupBoxHebrewWordClickShiftCtrl1";
      this.GroupBoxHebrewWordClickShiftCtrl1.TabStop = true;
      this.GroupBoxHebrewWordClickShiftCtrl1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShiftCtrl3
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl3, "GroupBoxHebrewWordClickShiftCtrl3");
      this.GroupBoxHebrewWordClickShiftCtrl3.Name = "GroupBoxHebrewWordClickShiftCtrl3";
      this.GroupBoxHebrewWordClickShiftCtrl3.TabStop = true;
      this.GroupBoxHebrewWordClickShiftCtrl3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShiftCtrl2
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl2, "GroupBoxHebrewWordClickShiftCtrl2");
      this.GroupBoxHebrewWordClickShiftCtrl2.Name = "GroupBoxHebrewWordClickShiftCtrl2";
      this.GroupBoxHebrewWordClickShiftCtrl2.TabStop = true;
      this.GroupBoxHebrewWordClickShiftCtrl2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShiftCtrl4
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl4, "GroupBoxHebrewWordClickShiftCtrl4");
      this.GroupBoxHebrewWordClickShiftCtrl4.Name = "GroupBoxHebrewWordClickShiftCtrl4";
      this.GroupBoxHebrewWordClickShiftCtrl4.TabStop = true;
      this.GroupBoxHebrewWordClickShiftCtrl4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl
      // 
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl5);
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl0);
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl1);
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl3);
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl2);
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl4);
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl, "GroupBoxHebrewWordClickCtrl");
      this.GroupBoxHebrewWordClickCtrl.Name = "GroupBoxHebrewWordClickCtrl";
      this.GroupBoxHebrewWordClickCtrl.TabStop = false;
      // 
      // GroupBoxHebrewWordClickCtrl5
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl5, "GroupBoxHebrewWordClickCtrl5");
      this.GroupBoxHebrewWordClickCtrl5.Name = "GroupBoxHebrewWordClickCtrl5";
      this.GroupBoxHebrewWordClickCtrl5.TabStop = true;
      this.GroupBoxHebrewWordClickCtrl5.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl0
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl0, "GroupBoxHebrewWordClickCtrl0");
      this.GroupBoxHebrewWordClickCtrl0.Name = "GroupBoxHebrewWordClickCtrl0";
      this.GroupBoxHebrewWordClickCtrl0.TabStop = true;
      this.GroupBoxHebrewWordClickCtrl0.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl1
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl1, "GroupBoxHebrewWordClickCtrl1");
      this.GroupBoxHebrewWordClickCtrl1.Name = "GroupBoxHebrewWordClickCtrl1";
      this.GroupBoxHebrewWordClickCtrl1.TabStop = true;
      this.GroupBoxHebrewWordClickCtrl1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl3
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl3, "GroupBoxHebrewWordClickCtrl3");
      this.GroupBoxHebrewWordClickCtrl3.Name = "GroupBoxHebrewWordClickCtrl3";
      this.GroupBoxHebrewWordClickCtrl3.TabStop = true;
      this.GroupBoxHebrewWordClickCtrl3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl2
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl2, "GroupBoxHebrewWordClickCtrl2");
      this.GroupBoxHebrewWordClickCtrl2.Name = "GroupBoxHebrewWordClickCtrl2";
      this.GroupBoxHebrewWordClickCtrl2.TabStop = true;
      this.GroupBoxHebrewWordClickCtrl2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl4
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl4, "GroupBoxHebrewWordClickCtrl4");
      this.GroupBoxHebrewWordClickCtrl4.Name = "GroupBoxHebrewWordClickCtrl4";
      this.GroupBoxHebrewWordClickCtrl4.TabStop = true;
      this.GroupBoxHebrewWordClickCtrl4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxTranslatedItemDoubleClick
      // 
      this.GroupBoxTranslatedItemDoubleClick.Controls.Add(this.GroupBoxTranslatedItemDoubleClick4);
      this.GroupBoxTranslatedItemDoubleClick.Controls.Add(this.GroupBoxTranslatedItemDoubleClick1);
      this.GroupBoxTranslatedItemDoubleClick.Controls.Add(this.GroupBoxTranslatedItemDoubleClick2);
      this.GroupBoxTranslatedItemDoubleClick.Controls.Add(this.GroupBoxTranslatedItemDoubleClick3);
      resources.ApplyResources(this.GroupBoxTranslatedItemDoubleClick, "GroupBoxTranslatedItemDoubleClick");
      this.GroupBoxTranslatedItemDoubleClick.Name = "GroupBoxTranslatedItemDoubleClick";
      this.GroupBoxTranslatedItemDoubleClick.TabStop = false;
      // 
      // GroupBoxTranslatedItemDoubleClick4
      // 
      resources.ApplyResources(this.GroupBoxTranslatedItemDoubleClick4, "GroupBoxTranslatedItemDoubleClick4");
      this.GroupBoxTranslatedItemDoubleClick4.Name = "GroupBoxTranslatedItemDoubleClick4";
      this.GroupBoxTranslatedItemDoubleClick4.TabStop = true;
      this.GroupBoxTranslatedItemDoubleClick4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxTranslatedItemDoubleClick1
      // 
      resources.ApplyResources(this.GroupBoxTranslatedItemDoubleClick1, "GroupBoxTranslatedItemDoubleClick1");
      this.GroupBoxTranslatedItemDoubleClick1.Name = "GroupBoxTranslatedItemDoubleClick1";
      this.GroupBoxTranslatedItemDoubleClick1.TabStop = true;
      this.GroupBoxTranslatedItemDoubleClick1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxTranslatedItemDoubleClick2
      // 
      resources.ApplyResources(this.GroupBoxTranslatedItemDoubleClick2, "GroupBoxTranslatedItemDoubleClick2");
      this.GroupBoxTranslatedItemDoubleClick2.Name = "GroupBoxTranslatedItemDoubleClick2";
      this.GroupBoxTranslatedItemDoubleClick2.TabStop = true;
      this.GroupBoxTranslatedItemDoubleClick2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxTranslatedItemDoubleClick3
      // 
      resources.ApplyResources(this.GroupBoxTranslatedItemDoubleClick3, "GroupBoxTranslatedItemDoubleClick3");
      this.GroupBoxTranslatedItemDoubleClick3.Name = "GroupBoxTranslatedItemDoubleClick3";
      this.GroupBoxTranslatedItemDoubleClick3.TabStop = true;
      this.GroupBoxTranslatedItemDoubleClick3.UseVisualStyleBackColor = true;
      // 
      // TabPageMSWord
      // 
      this.TabPageMSWord.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageMSWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageMSWord.Controls.Add(this.SelectPageSize);
      this.TabPageMSWord.Controls.Add(this.EditExportDocumentVerseRefInBold);
      this.TabPageMSWord.Controls.Add(this.EditExportDocumentLandscape);
      this.TabPageMSWord.Controls.Add(this.EditDocumentMarginTop);
      this.TabPageMSWord.Controls.Add(this.LabelDocumentMarginHFIntervalInfo);
      this.TabPageMSWord.Controls.Add(this.EditPageHeight);
      this.TabPageMSWord.Controls.Add(this.EditDocumentWordColumnsCount);
      this.TabPageMSWord.Controls.Add(this.LabelExportDocumentTheme);
      this.TabPageMSWord.Controls.Add(this.label5);
      this.TabPageMSWord.Controls.Add(this.EditDifferentFirstPage);
      this.TabPageMSWord.Controls.Add(this.SelectExportDocumentTheme);
      this.TabPageMSWord.Controls.Add(this.EditPageWidth);
      this.TabPageMSWord.Controls.Add(this.SelectExportDocumentModel);
      this.TabPageMSWord.Controls.Add(this.EditDocumentMarginBottom);
      this.TabPageMSWord.Controls.Add(this.EditExportDocumentDifferentOddAndEvenPages);
      this.TabPageMSWord.Controls.Add(this.LabelDocumentSize);
      this.TabPageMSWord.Controls.Add(this.EditDocumentMarginLeft);
      this.TabPageMSWord.Controls.Add(this.EditExportDocumentOverrideWordColumnsCount);
      this.TabPageMSWord.Controls.Add(this.LabelPageWidthIntervalInfo);
      this.TabPageMSWord.Controls.Add(this.EditDocumentMarginHeader);
      this.TabPageMSWord.Controls.Add(this.LabelDocumentMargins);
      this.TabPageMSWord.Controls.Add(this.LabelPageHeightIntervalInfo);
      this.TabPageMSWord.Controls.Add(this.EditDocumentMarginRight);
      this.TabPageMSWord.Controls.Add(this.LabelDocumentMarginIntervalInfo);
      this.TabPageMSWord.Controls.Add(this.LabelDocumentWordColumnsCountIntervalInfo);
      this.TabPageMSWord.Controls.Add(this.EditDocumentMarginFooter);
      resources.ApplyResources(this.TabPageMSWord, "TabPageMSWord");
      this.TabPageMSWord.Name = "TabPageMSWord";
      // 
      // SelectPageSize
      // 
      this.SelectPageSize.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.SelectPageSize, "SelectPageSize");
      this.SelectPageSize.Name = "SelectPageSize";
      this.SelectPageSize.UseVisualStyleBackColor = true;
      this.SelectPageSize.Click += new System.EventHandler(this.SelectPageSize_Click);
      // 
      // EditExportDocumentVerseRefInBold
      // 
      resources.ApplyResources(this.EditExportDocumentVerseRefInBold, "EditExportDocumentVerseRefInBold");
      this.EditExportDocumentVerseRefInBold.Name = "EditExportDocumentVerseRefInBold";
      this.EditExportDocumentVerseRefInBold.UseVisualStyleBackColor = true;
      // 
      // EditExportDocumentLandscape
      // 
      resources.ApplyResources(this.EditExportDocumentLandscape, "EditExportDocumentLandscape");
      this.EditExportDocumentLandscape.Name = "EditExportDocumentLandscape";
      this.EditExportDocumentLandscape.UseVisualStyleBackColor = true;
      // 
      // EditDocumentMarginTop
      // 
      this.EditDocumentMarginTop.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditDocumentMarginTop, "EditDocumentMarginTop");
      this.EditDocumentMarginTop.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.EditDocumentMarginTop.Name = "EditDocumentMarginTop";
      this.EditDocumentMarginTop.ReadOnly = true;
      // 
      // LabelDocumentMarginHFIntervalInfo
      // 
      resources.ApplyResources(this.LabelDocumentMarginHFIntervalInfo, "LabelDocumentMarginHFIntervalInfo");
      this.LabelDocumentMarginHFIntervalInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelDocumentMarginHFIntervalInfo.Name = "LabelDocumentMarginHFIntervalInfo";
      // 
      // EditPageHeight
      // 
      this.EditPageHeight.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditPageHeight, "EditPageHeight");
      this.EditPageHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.EditPageHeight.Name = "EditPageHeight";
      this.EditPageHeight.ReadOnly = true;
      // 
      // EditDocumentWordColumnsCount
      // 
      this.EditDocumentWordColumnsCount.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditDocumentWordColumnsCount, "EditDocumentWordColumnsCount");
      this.EditDocumentWordColumnsCount.Name = "EditDocumentWordColumnsCount";
      this.EditDocumentWordColumnsCount.ReadOnly = true;
      // 
      // label5
      // 
      resources.ApplyResources(this.label5, "label5");
      this.label5.Name = "label5";
      // 
      // EditDifferentFirstPage
      // 
      resources.ApplyResources(this.EditDifferentFirstPage, "EditDifferentFirstPage");
      this.EditDifferentFirstPage.Name = "EditDifferentFirstPage";
      this.EditDifferentFirstPage.UseVisualStyleBackColor = true;
      // 
      // EditPageWidth
      // 
      this.EditPageWidth.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditPageWidth, "EditPageWidth");
      this.EditPageWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.EditPageWidth.Name = "EditPageWidth";
      this.EditPageWidth.ReadOnly = true;
      // 
      // SelectExportDocumentModel
      // 
      this.SelectExportDocumentModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SelectExportDocumentModel.FormattingEnabled = true;
      this.SelectExportDocumentModel.Items.AddRange(new object[] {
            resources.GetString("SelectExportDocumentModel.Items"),
            resources.GetString("SelectExportDocumentModel.Items1"),
            resources.GetString("SelectExportDocumentModel.Items2"),
            resources.GetString("SelectExportDocumentModel.Items3"),
            resources.GetString("SelectExportDocumentModel.Items4"),
            resources.GetString("SelectExportDocumentModel.Items5"),
            resources.GetString("SelectExportDocumentModel.Items6"),
            resources.GetString("SelectExportDocumentModel.Items7"),
            resources.GetString("SelectExportDocumentModel.Items8")});
      resources.ApplyResources(this.SelectExportDocumentModel, "SelectExportDocumentModel");
      this.SelectExportDocumentModel.Name = "SelectExportDocumentModel";
      // 
      // EditDocumentMarginBottom
      // 
      this.EditDocumentMarginBottom.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditDocumentMarginBottom, "EditDocumentMarginBottom");
      this.EditDocumentMarginBottom.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.EditDocumentMarginBottom.Name = "EditDocumentMarginBottom";
      this.EditDocumentMarginBottom.ReadOnly = true;
      // 
      // EditExportDocumentDifferentOddAndEvenPages
      // 
      resources.ApplyResources(this.EditExportDocumentDifferentOddAndEvenPages, "EditExportDocumentDifferentOddAndEvenPages");
      this.EditExportDocumentDifferentOddAndEvenPages.Name = "EditExportDocumentDifferentOddAndEvenPages";
      this.EditExportDocumentDifferentOddAndEvenPages.UseVisualStyleBackColor = true;
      // 
      // LabelDocumentSize
      // 
      resources.ApplyResources(this.LabelDocumentSize, "LabelDocumentSize");
      this.LabelDocumentSize.Name = "LabelDocumentSize";
      // 
      // EditDocumentMarginLeft
      // 
      this.EditDocumentMarginLeft.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditDocumentMarginLeft, "EditDocumentMarginLeft");
      this.EditDocumentMarginLeft.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.EditDocumentMarginLeft.Name = "EditDocumentMarginLeft";
      this.EditDocumentMarginLeft.ReadOnly = true;
      // 
      // EditExportDocumentOverrideWordColumnsCount
      // 
      resources.ApplyResources(this.EditExportDocumentOverrideWordColumnsCount, "EditExportDocumentOverrideWordColumnsCount");
      this.EditExportDocumentOverrideWordColumnsCount.Name = "EditExportDocumentOverrideWordColumnsCount";
      this.EditExportDocumentOverrideWordColumnsCount.UseVisualStyleBackColor = true;
      this.EditExportDocumentOverrideWordColumnsCount.CheckedChanged += new System.EventHandler(this.EditExportDocumentOverrideWordColumnsCount_CheckedChanged);
      // 
      // LabelPageWidthIntervalInfo
      // 
      resources.ApplyResources(this.LabelPageWidthIntervalInfo, "LabelPageWidthIntervalInfo");
      this.LabelPageWidthIntervalInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelPageWidthIntervalInfo.Name = "LabelPageWidthIntervalInfo";
      // 
      // EditDocumentMarginHeader
      // 
      this.EditDocumentMarginHeader.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditDocumentMarginHeader, "EditDocumentMarginHeader");
      this.EditDocumentMarginHeader.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.EditDocumentMarginHeader.Name = "EditDocumentMarginHeader";
      this.EditDocumentMarginHeader.ReadOnly = true;
      // 
      // LabelPageHeightIntervalInfo
      // 
      resources.ApplyResources(this.LabelPageHeightIntervalInfo, "LabelPageHeightIntervalInfo");
      this.LabelPageHeightIntervalInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelPageHeightIntervalInfo.Name = "LabelPageHeightIntervalInfo";
      // 
      // EditDocumentMarginRight
      // 
      this.EditDocumentMarginRight.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditDocumentMarginRight, "EditDocumentMarginRight");
      this.EditDocumentMarginRight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.EditDocumentMarginRight.Name = "EditDocumentMarginRight";
      this.EditDocumentMarginRight.ReadOnly = true;
      // 
      // LabelDocumentWordColumnsCountIntervalInfo
      // 
      resources.ApplyResources(this.LabelDocumentWordColumnsCountIntervalInfo, "LabelDocumentWordColumnsCountIntervalInfo");
      this.LabelDocumentWordColumnsCountIntervalInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelDocumentWordColumnsCountIntervalInfo.Name = "LabelDocumentWordColumnsCountIntervalInfo";
      // 
      // EditDocumentMarginFooter
      // 
      this.EditDocumentMarginFooter.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.EditDocumentMarginFooter, "EditDocumentMarginFooter");
      this.EditDocumentMarginFooter.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.EditDocumentMarginFooter.Name = "EditDocumentMarginFooter";
      this.EditDocumentMarginFooter.ReadOnly = true;
      // 
      // TabPageExport
      // 
      this.TabPageExport.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageExport.Controls.Add(this.EditAutoOpenExportedFile);
      this.TabPageExport.Controls.Add(this.EditAutoOpenExportFolder);
      this.TabPageExport.Controls.Add(this.LabelDataExportFileFormat);
      this.TabPageExport.Controls.Add(this.SelectDataExportFileFormat);
      this.TabPageExport.Controls.Add(this.LabelImageExportFileFormat);
      this.TabPageExport.Controls.Add(this.SelectImageExportFileFormat);
      resources.ApplyResources(this.TabPageExport, "TabPageExport");
      this.TabPageExport.Name = "TabPageExport";
      // 
      // TabPageTools
      // 
      this.TabPageTools.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageTools.Controls.Add(this.ActionOnlineSearchHelp);
      this.TabPageTools.Controls.Add(this.ActionOnlineVerseHelp);
      this.TabPageTools.Controls.Add(this.ActionSelectOnlineSearch);
      this.TabPageTools.Controls.Add(this.ActionSelectOnlineVerseURL);
      this.TabPageTools.Controls.Add(LabelOnlineVerseURL);
      this.TabPageTools.Controls.Add(this.EditOnlineVerseURL);
      this.TabPageTools.Controls.Add(LabelOnlineSearch);
      this.TabPageTools.Controls.Add(this.EditOnlineSearch);
      resources.ApplyResources(this.TabPageTools, "TabPageTools");
      this.TabPageTools.Name = "TabPageTools";
      // 
      // ActionOnlineSearchHelp
      // 
      this.ActionOnlineSearchHelp.AllowDrop = true;
      resources.ApplyResources(this.ActionOnlineSearchHelp, "ActionOnlineSearchHelp");
      this.ActionOnlineSearchHelp.FlatAppearance.BorderSize = 0;
      this.ActionOnlineSearchHelp.Name = "ActionOnlineSearchHelp";
      this.ActionOnlineSearchHelp.UseVisualStyleBackColor = true;
      this.ActionOnlineSearchHelp.Click += new System.EventHandler(this.ActionOnlineSearchHelp_Click);
      // 
      // ActionOnlineVerseHelp
      // 
      this.ActionOnlineVerseHelp.AllowDrop = true;
      resources.ApplyResources(this.ActionOnlineVerseHelp, "ActionOnlineVerseHelp");
      this.ActionOnlineVerseHelp.FlatAppearance.BorderSize = 0;
      this.ActionOnlineVerseHelp.Name = "ActionOnlineVerseHelp";
      this.ActionOnlineVerseHelp.UseVisualStyleBackColor = true;
      this.ActionOnlineVerseHelp.Click += new System.EventHandler(this.ActionOnlineVerseHelp_Click);
      // 
      // ActionSelectOnlineSearch
      // 
      this.ActionSelectOnlineSearch.AllowDrop = true;
      resources.ApplyResources(this.ActionSelectOnlineSearch, "ActionSelectOnlineSearch");
      this.ActionSelectOnlineSearch.FlatAppearance.BorderSize = 0;
      this.ActionSelectOnlineSearch.Name = "ActionSelectOnlineSearch";
      this.ActionSelectOnlineSearch.UseVisualStyleBackColor = true;
      this.ActionSelectOnlineSearch.Click += new System.EventHandler(this.ActionSelectOnlineSearch_Click);
      // 
      // ActionSelectOnlineVerseURL
      // 
      this.ActionSelectOnlineVerseURL.AllowDrop = true;
      resources.ApplyResources(this.ActionSelectOnlineVerseURL, "ActionSelectOnlineVerseURL");
      this.ActionSelectOnlineVerseURL.FlatAppearance.BorderSize = 0;
      this.ActionSelectOnlineVerseURL.Name = "ActionSelectOnlineVerseURL";
      this.ActionSelectOnlineVerseURL.UseVisualStyleBackColor = true;
      this.ActionSelectOnlineVerseURL.Click += new System.EventHandler(this.ActionSelectOnlineVerseURL_Click);
      // 
      // EditOnlineVerseURL
      // 
      resources.ApplyResources(this.EditOnlineVerseURL, "EditOnlineVerseURL");
      this.EditOnlineVerseURL.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditOnlineVerseURL.Name = "EditOnlineVerseURL";
      this.EditOnlineVerseURL.SpellCheckAllowed = false;
      // 
      // EditOnlineSearch
      // 
      resources.ApplyResources(this.EditOnlineSearch, "EditOnlineSearch");
      this.EditOnlineSearch.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditOnlineSearch.Name = "EditOnlineSearch";
      this.EditOnlineSearch.SpellCheckAllowed = false;
      // 
      // SaveThemeDialog
      // 
      resources.ApplyResources(this.SaveThemeDialog, "SaveThemeDialog");
      // 
      // OpenThemeDialog
      // 
      this.OpenThemeDialog.FileName = "openFileDialog1";
      resources.ApplyResources(this.OpenThemeDialog, "OpenThemeDialog");
      // 
      // MenuSelectSearchRequest
      // 
      this.MenuSelectSearchRequest.Name = "MenuSelectOnlineVerseURL";
      resources.ApplyResources(this.MenuSelectSearchRequest, "MenuSelectSearchRequest");
      // 
      // MenuSelectOnlineVerseURL
      // 
      this.MenuSelectOnlineVerseURL.Name = "MenuSelectOnlineVerseURL";
      resources.ApplyResources(this.MenuSelectOnlineVerseURL, "MenuSelectOnlineVerseURL");
      // 
      // MenuPredefinedPageSizes
      // 
      this.MenuPredefinedPageSizes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionSetPageSizeA5,
            this.ActionSetPageSizeA4,
            this.ActionSetPageSizePocket,
            this.ActionSetPageSizeDigest,
            this.ActionSetPageSizeRoman,
            this.ActionSetPageSizeRoyal,
            this.ActionSetPageSizeCrownQuarto,
            this.ActionSetPageSizeExecutive,
            this.ActionSetPageSizeUSLetter});
      this.MenuPredefinedPageSizes.Name = "MenuSelectMoonDayTextFormat";
      this.MenuPredefinedPageSizes.ShowImageMargin = false;
      resources.ApplyResources(this.MenuPredefinedPageSizes, "MenuPredefinedPageSizes");
      // 
      // ActionSetPageSizeA5
      // 
      this.ActionSetPageSizeA5.Name = "ActionSetPageSizeA5";
      resources.ApplyResources(this.ActionSetPageSizeA5, "ActionSetPageSizeA5");
      this.ActionSetPageSizeA5.Click += new System.EventHandler(this.ActionSetPageSizeA5_Click);
      // 
      // ActionSetPageSizeA4
      // 
      this.ActionSetPageSizeA4.Name = "ActionSetPageSizeA4";
      resources.ApplyResources(this.ActionSetPageSizeA4, "ActionSetPageSizeA4");
      this.ActionSetPageSizeA4.Click += new System.EventHandler(this.ActionSetPageSizeA4_Click);
      // 
      // ActionSetPageSizePocket
      // 
      this.ActionSetPageSizePocket.Name = "ActionSetPageSizePocket";
      resources.ApplyResources(this.ActionSetPageSizePocket, "ActionSetPageSizePocket");
      this.ActionSetPageSizePocket.Click += new System.EventHandler(this.ActionSetPageSizePocket_Click);
      // 
      // ActionSetPageSizeDigest
      // 
      this.ActionSetPageSizeDigest.Name = "ActionSetPageSizeDigest";
      resources.ApplyResources(this.ActionSetPageSizeDigest, "ActionSetPageSizeDigest");
      this.ActionSetPageSizeDigest.Click += new System.EventHandler(this.ActionSetPageSizeDigest_Click);
      // 
      // ActionSetPageSizeRoman
      // 
      this.ActionSetPageSizeRoman.Name = "ActionSetPageSizeRoman";
      resources.ApplyResources(this.ActionSetPageSizeRoman, "ActionSetPageSizeRoman");
      this.ActionSetPageSizeRoman.Click += new System.EventHandler(this.ActionSetPageSizeRoman_Click);
      // 
      // ActionSetPageSizeRoyal
      // 
      this.ActionSetPageSizeRoyal.Name = "ActionSetPageSizeRoyal";
      resources.ApplyResources(this.ActionSetPageSizeRoyal, "ActionSetPageSizeRoyal");
      this.ActionSetPageSizeRoyal.Click += new System.EventHandler(this.ActionSetPageSizeRoyal_Click);
      // 
      // ActionSetPageSizeCrownQuarto
      // 
      this.ActionSetPageSizeCrownQuarto.Name = "ActionSetPageSizeCrownQuarto";
      resources.ApplyResources(this.ActionSetPageSizeCrownQuarto, "ActionSetPageSizeCrownQuarto");
      this.ActionSetPageSizeCrownQuarto.Click += new System.EventHandler(this.ActionSetPageSizeCrownQuarto_Click);
      // 
      // ActionSetPageSizeExecutive
      // 
      this.ActionSetPageSizeExecutive.Name = "ActionSetPageSizeExecutive";
      resources.ApplyResources(this.ActionSetPageSizeExecutive, "ActionSetPageSizeExecutive");
      this.ActionSetPageSizeExecutive.Click += new System.EventHandler(this.ActionSetPageSizeExecutive_Click);
      // 
      // ActionSetPageSizeUSLetter
      // 
      this.ActionSetPageSizeUSLetter.Name = "ActionSetPageSizeUSLetter";
      resources.ApplyResources(this.ActionSetPageSizeUSLetter, "ActionSetPageSizeUSLetter");
      this.ActionSetPageSizeUSLetter.Click += new System.EventHandler(this.ActionSetPageSizeUSLetter_Click);
      // 
      // PreferencesForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ActionClose;
      this.Controls.Add(this.TabControl);
      this.Controls.Add(this.PanelBottomSeparator);
      this.Controls.Add(this.PanelButtons);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PreferencesForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesForm_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PreferencesForm_FormClosed);
      this.Load += new System.EventHandler(this.PreferencesForm_Load);
      this.Shown += new System.EventHandler(this.PreferencesForm_Shown);
      this.PanelButtons.ResumeLayout(false);
      this.PanelButtons.PerformLayout();
      this.TabPagePaths.ResumeLayout(false);
      this.TabPagePaths.PerformLayout();
      this.TabPageStartup.ResumeLayout(false);
      this.TabPageStartup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoBackupCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditCheckUpdateAtStartupInterval)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditVacuumAtStartupInterval)).EndInit();
      this.TabPageApplication.ResumeLayout(false);
      this.TabPageApplication.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditVolume)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoSaveDelay)).EndInit();
      this.TabControl.ResumeLayout(false);
      this.TabPageBookmarks.ResumeLayout(false);
      this.TabPageBookmarks.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditHistoryCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditBookmarksCount)).EndInit();
      this.TabPageEditing.ResumeLayout(false);
      this.TabPageEditing.PerformLayout();
      this.TabPageRendering.ResumeLayout(false);
      this.TabPageRendering.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSizeCommentary)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSizeTranslation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSizeHebrew)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditWordControlWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditSearchMinRefForDialog)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditSearchDisplayMaxRef)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditWordTranslateLinesCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditCommentaryLinesCount)).EndInit();
      this.TabPageTheme.ResumeLayout(false);
      this.TabPageTheme.PerformLayout();
      this.TabPageMouse.ResumeLayout(false);
      this.GroupBoxHebrewWordClickShift.ResumeLayout(false);
      this.GroupBoxHebrewWordClickShift.PerformLayout();
      this.GroupBoxVerseLabelClick.ResumeLayout(false);
      this.GroupBoxVerseLabelClick.PerformLayout();
      this.GroupBoxHebrewWordClick.ResumeLayout(false);
      this.GroupBoxHebrewWordClick.PerformLayout();
      this.GroupBoxHebrewWordClickAlt.ResumeLayout(false);
      this.GroupBoxHebrewWordClickAlt.PerformLayout();
      this.GroupBoxHebrewWordClickCtrl.ResumeLayout(false);
      this.GroupBoxHebrewWordClickCtrl.PerformLayout();
      this.GroupBoxTranslatedItemDoubleClick.ResumeLayout(false);
      this.GroupBoxTranslatedItemDoubleClick.PerformLayout();
      this.TabPageMSWord.ResumeLayout(false);
      this.TabPageMSWord.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginTop)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditPageHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentWordColumnsCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditPageWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginBottom)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginLeft)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginHeader)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginRight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditDocumentMarginFooter)).EndInit();
      this.TabPageExport.ResumeLayout(false);
      this.TabPageExport.PerformLayout();
      this.TabPageTools.ResumeLayout(false);
      this.TabPageTools.PerformLayout();
      this.MenuPredefinedPageSizes.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button ActionClose;
    private System.Windows.Forms.Button ActionExportSettings;
    private System.Windows.Forms.Button ActionImportSettings;
    private System.Windows.Forms.ColorDialog DialogColor;
    private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    private System.Windows.Forms.LinkLabel ActionResetSettings;
    private System.Windows.Forms.OpenFileDialog OpenExeFileDialog;
    private System.Windows.Forms.OpenFileDialog OpenSettingsDialog;
    private System.Windows.Forms.Panel PanelBottomSeparator;
    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.SaveFileDialog SaveSettingsDialog;
    private TabPage TabPagePaths;
    private Label LabelExportFolder;
    private Button ActionResetExportFolder;
    private Button ActionSelectExportFolder;
    private Label LabelCalculatorPath;
    private Button ActionResetHebrewLettersPath;
    private Button ActionResetCalculatorPath;
    private Button ActionSelectCalculatorPath;
    private Label LabelHebrewLettersPath;
    private Button ActionSelectHebrewLettersPath;
    private TextBoxEx EditExportFolder;
    private TextBoxEx EditCalculatorPath;
    private TextBoxEx EditHebrewLettersPath;
    private ComboBox SelectImageExportFileFormat;
    private ComboBox SelectDataExportFileFormat;
    private Label LabelImageExportFileFormat;
    private Label LabelDataExportFileFormat;
    private CheckBox EditAutoOpenExportedFile;
    private CheckBox EditAutoOpenExportFolder;
    private TabPage TabPageStartup;
    private CheckBox EditShowLastNewInVersionAfterUpdate;
    private Label LabelLastDBOptimizeDate;
    private Label LabelLastDBOptimize;
    private Label LabelLastStartupCheckDate;
    private Label LabelLastStartupCheck;
    private Label LabelInfoCheckUpdateAtStartup;
    private CheckBox EditCheckUpdateAtStartup;
    private NumericUpDown EditCheckUpdateAtStartupInterval;
    private NumericUpDown EditVacuumAtStartupInterval;
    private CheckBox EditVacuumAtStartup;
    private Label LabelInfoOptimizeDatabaseIntervalInfo;
    private TabPage TabPageApplication;
    private TrackBar EditVolume;
    private Label LabelVolume;
    private Label LabelVolumeValue;
    private Button ActionSelectLangEN;
    private Button ActionSelectLangFR;
    private CheckBox EditWindowsDoubleBufferingEnabled;
    private CheckBox EditWebLinksMenuEnabled;
    private CheckBox EditDebuggerEnabled;
    private CheckBox EditUsageStatisticsEnabled;
    private CheckBox EditLogEnabled;
    private TabControl TabControl;
    private SaveFileDialog SaveThemeDialog;
    private OpenFileDialog OpenThemeDialog;
    private TabPage TabPageRendering;
    private NumericUpDown EditWordControlWidth;
    private NumericUpDown EditSearchMinRefForDialog;
    private NumericUpDown EditSearchDisplayMaxRef;
    private NumericUpDown EditHistoryCount;
    private NumericUpDown EditBookmarksCount;
    private NumericUpDown EditCommentaryLinesCount;
    private TabPage TabPageTools;
    private Button ActionOnlineSearchHelp;
    private Button ActionOnlineVerseHelp;
    private Button ActionSelectOnlineSearch;
    private Button ActionSelectOnlineVerseURL;
    private TextBoxEx EditOnlineVerseURL;
    private TextBoxEx EditOnlineSearch;
    private CheckBox EditGoToBookmarkMainAtStartup;
    private NumericUpDown EditAutoSaveDelay;
    private NumericUpDown EditAutoBackupCount;
    private TextBoxEx EditBackupFolder;
    private Button ActionResetBackupFolder;
    private Button ActionSelectBackupFolder;
    private ContextMenuStrip MenuSelectSearchRequest;
    private ContextMenuStrip MenuSelectOnlineVerseURL;
    private Label LabelInfoAutoSaveDelay;
    private Label LabelInfoAutoBackupCount;
    private Label LabelInfoSearchMinRefForDialog;
    private Label LabelInfoSearchDisplayMaxRef;
    private Label LabelInfoHistoryCount;
    private Label LabelInfoBookmarksCount;
    private Label LabelInfoWordControlWidth;
    private Label LabelInfoCommentLinesCountInfos;
    private GroupBox GroupBoxHebrewWordClickAlt;
    private RadioButton GroupBoxHebrewWordClickShiftCtrl5;
    private RadioButton GroupBoxHebrewWordClickShiftCtrl1;
    private RadioButton GroupBoxHebrewWordClickShiftCtrl2;
    private RadioButton GroupBoxHebrewWordClickShiftCtrl4;
    private GroupBox GroupBoxHebrewWordClickShift;
    private RadioButton GroupBoxHebrewWordClickShift5;
    private RadioButton GroupBoxHebrewWordClickShift1;
    private RadioButton GroupBoxHebrewWordClickShift2;
    private RadioButton GroupBoxHebrewWordClickShift4;
    private GroupBox GroupBoxHebrewWordClickCtrl;
    private RadioButton GroupBoxHebrewWordClickCtrl5;
    private RadioButton GroupBoxHebrewWordClickCtrl1;
    private RadioButton GroupBoxHebrewWordClickCtrl2;
    private RadioButton GroupBoxHebrewWordClickCtrl4;
    private GroupBox GroupBoxHebrewWordClick;
    private RadioButton GroupBoxHebrewWordClick5;
    private RadioButton GroupBoxHebrewWordClick1;
    private RadioButton GroupBoxHebrewWordClick2;
    private RadioButton GroupBoxHebrewWordClick4;
    private GroupBox GroupBoxTranslatedItemDoubleClick;
    private RadioButton GroupBoxTranslatedItemDoubleClick4;
    private RadioButton GroupBoxTranslatedItemDoubleClick1;
    private RadioButton GroupBoxTranslatedItemDoubleClick2;
    private RadioButton GroupBoxTranslatedItemDoubleClick3;
    private GroupBox GroupBoxVerseLabelClick;
    private RadioButton GroupBoxVerseLabelClick4;
    private RadioButton GroupBoxVerseLabelClick1;
    private RadioButton GroupBoxVerseLabelClick2;
    private RadioButton GroupBoxVerseLabelClick3;
    private RadioButton GroupBoxHebrewWordClick0;
    private RadioButton GroupBoxHebrewWordClickShift0;
    private RadioButton GroupBoxHebrewWordClickShiftCtrl0;
    private RadioButton GroupBoxHebrewWordClickCtrl0;
    private Label LabelWordtranslateLinesCountInfo;
    private NumericUpDown EditWordTranslateLinesCount;
    private RadioButton GroupBoxHebrewWordClickShift3;
    private RadioButton GroupBoxHebrewWordClickShiftCtrl3;
    private RadioButton GroupBoxHebrewWordClickCtrl3;
    private RadioButton GroupBoxHebrewWordClick3;
    private Label LabelFontSizeHebrewInfo;
    private NumericUpDown EditFontSizeHebrew;
    private Label LabelFontSizeTranslationInfo;
    private NumericUpDown EditFontSizeTranslation;
    private Label LabelFontSizeCommentaryInfo;
    private NumericUpDown EditFontSizeCommentary;
    private CheckBox EditBookNameHebrewWithCommonName;
    private CheckBox EditCommentLineAddPrefix;
    private TextBoxEx EditCommentLinePrefix;
    private CheckBox EditCommentLineRemovePrefix;
    private Button ActionCheckAllComments;
    private CheckBox EditGoToLastVerseAtStartup;
    private CheckBox EditAutoSortBookmarks;
    private TabPage TabPageBookmarks;
    private TabPage TabPageTheme;
    private Label label3;
    public Panel EditThemeSearchLettersBack;
    public Panel EditThemeSearchWordBack;
    private Label label6;
    private LinkLabel ActionUseColorsPastel;
    private LinkLabel ActionUseColorsSystem;
    private Label label1;
    public Panel EditThemeCurrentControl;
    private Label label2;
    public Panel EditThemeCommentaryBack;
    private Label label8;
    public Panel EditThemeNavigatorItems;
    private Button ActionOpenTheme;
    private Button ActionSaveTheme;
    private Label label4;
    public Panel EditThemeTranslationBack;
    private CheckBox EditAutoSaveOnLeaveControl;
    private TabPage TabPageEditing;
    private TabPage TabPageMouse;
    private CheckBox EditSearchHebrewCharsInBold;
    private Button ActionResetRendering;
    private ComboBox SelectExportDocumentTheme;
    private Label LabelExportDocumentTheme;
    private Label LabelDocumentMargins;
    private Label LabelDocumentMarginIntervalInfo;
    private TabPage TabPageExport;
    private NumericUpDown EditDocumentMarginTop;
    private CheckBox EditExportDocumentOverrideWordColumnsCount;
    private CheckBox EditExportDocumentLandscape;
    private NumericUpDown EditDocumentWordColumnsCount;
    private Label LabelDocumentWordColumnsCountIntervalInfo;
    private NumericUpDown EditDocumentMarginRight;
    private NumericUpDown EditDocumentMarginLeft;
    private NumericUpDown EditDocumentMarginBottom;
    private CheckBox EditExportDocumentDifferentOddAndEvenPages;
    private NumericUpDown EditPageHeight;
    private NumericUpDown EditPageWidth;
    private Label LabelDocumentSize;
    private Label LabelPageHeightIntervalInfo;
    private CheckBox EditDifferentFirstPage;
    private NumericUpDown EditDocumentMarginFooter;
    private NumericUpDown EditDocumentMarginHeader;
    private Label LabelDocumentMarginHFIntervalInfo;
    private Label LabelPageWidthIntervalInfo;
    private Button SelectPageSize;
    private ContextMenuStrip MenuPredefinedPageSizes;
    private ToolStripMenuItem ActionSetPageSizeA5;
    private ToolStripMenuItem ActionSetPageSizeA4;
    private ToolStripMenuItem ActionSetPageSizePocket;
    private ToolStripMenuItem ActionSetPageSizeDigest;
    private ToolStripMenuItem ActionSetPageSizeRoman;
    private ToolStripMenuItem ActionSetPageSizeRoyal;
    private ToolStripMenuItem ActionSetPageSizeCrownQuarto;
    private ToolStripMenuItem ActionSetPageSizeExecutive;
    private ToolStripMenuItem ActionSetPageSizeUSLetter;
    private Label label5;
    private ComboBox SelectExportDocumentModel;
    private CheckBox EditExportDocumentVerseRefInBold;
    private CheckBox EditSpellCheckEnabled;
    private CheckBox EditWordControlTabInverted;
    private CheckBox EditTrayIconEnabled;
    private CheckBox EditSystemStatisticsCalculateDbSize;
    private CheckBox EditBookmarksWithParashah;
    private CheckBox EditBookmarksWithTranslation;
    private CheckBox EditBookNameHebrewWithParashah;
    private TabPage TabPageMSWord;
    private CheckBox EditDatabaseRestoreAskToBackup;
    private Label LabelThemeVerseNumberColor;
    public Panel EditThemeVerseNumberColor;
    private Label LabelThemeVerseHebrewColor;
    public Panel EditThemeVerseHebrewColor;
    private Label LabelThemeVerseHebrewColorHover;
    public Panel EditThemeVerseHebrewColorHover;
    private Label LabelThemeVerseNumberColorHover;
    public Panel EditThemeVerseNumberColorHover;
    private Label LabelThemeTranslationTextColor;
    public Panel EditThemeTranslationTextColor;
  }
}
