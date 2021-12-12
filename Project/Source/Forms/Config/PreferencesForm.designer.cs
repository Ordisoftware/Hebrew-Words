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
      this.EditImageExportFileFormat = new System.Windows.Forms.ComboBox();
      this.LabelExportFolder = new System.Windows.Forms.Label();
      this.ActionResetExportFolder = new System.Windows.Forms.Button();
      this.LabelDataExportFileFormat = new System.Windows.Forms.Label();
      this.EditDataExportFileFormat = new System.Windows.Forms.ComboBox();
      this.ActionSelectExportFolder = new System.Windows.Forms.Button();
      this.LabelImageExportFileFormat = new System.Windows.Forms.Label();
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
      this.EditAutoOpenExportedFile = new System.Windows.Forms.CheckBox();
      this.EditAutoOpenExportFolder = new System.Windows.Forms.CheckBox();
      this.TabPageStartup = new System.Windows.Forms.TabPage();
      this.EditGoToLastVerseAtStartup = new System.Windows.Forms.CheckBox();
      this.EditGoToMasterBookmarkAtStartup = new System.Windows.Forms.CheckBox();
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
      this.ActionCheckAllComments = new System.Windows.Forms.Button();
      this.EditCommentLinePrefix = new System.Windows.Forms.TextBox();
      this.LabelInfoAutoSaveDelay = new System.Windows.Forms.Label();
      this.LabelInfoAutoBackupCount = new System.Windows.Forms.Label();
      this.EditAutoSaveDelay = new System.Windows.Forms.NumericUpDown();
      this.EditAutoBackupCount = new System.Windows.Forms.NumericUpDown();
      this.EditVolume = new System.Windows.Forms.TrackBar();
      this.LabelVolume = new System.Windows.Forms.Label();
      this.LabelVolumeValue = new System.Windows.Forms.Label();
      this.ActionSelectLangEN = new System.Windows.Forms.Button();
      this.ActionSelectLangFR = new System.Windows.Forms.Button();
      this.EditWindowsDoubleBufferingEnabled = new System.Windows.Forms.CheckBox();
      this.EditCommentLineRemovePrefix = new System.Windows.Forms.CheckBox();
      this.EditCommentLineAddPrefix = new System.Windows.Forms.CheckBox();
      this.EditBookNameHebrewWithCommonName = new System.Windows.Forms.CheckBox();
      this.EditWebLinksMenuEnabled = new System.Windows.Forms.CheckBox();
      this.EditDebuggerEnabled = new System.Windows.Forms.CheckBox();
      this.EditUsageStatisticsEnabled = new System.Windows.Forms.CheckBox();
      this.EditLogEnabled = new System.Windows.Forms.CheckBox();
      this.EditAutoSortBookmarks = new System.Windows.Forms.CheckBox();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.TabPageBookmarks = new System.Windows.Forms.TabPage();
      this.EditHistoryCount = new System.Windows.Forms.NumericUpDown();
      this.LabelInfoHistoryCount = new System.Windows.Forms.Label();
      this.EditBookmarksCount = new System.Windows.Forms.NumericUpDown();
      this.LabelInfoBookmarksCount = new System.Windows.Forms.Label();
      this.TabPageTheme = new System.Windows.Forms.TabPage();
      this.ActionOpenTheme = new System.Windows.Forms.Button();
      this.ActionSaveTheme = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.EditThemeNavigatorItems = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.EditThemeTranslationBack = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.EditThemeCommentaryBack = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.EditThemeCurrentControl = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.EditThemeSearchLettersBack = new System.Windows.Forms.Panel();
      this.EditThemeSearchWordBack = new System.Windows.Forms.Panel();
      this.label6 = new System.Windows.Forms.Label();
      this.ActionUseColorsPastel = new System.Windows.Forms.LinkLabel();
      this.ActionUseColorsSystem = new System.Windows.Forms.LinkLabel();
      this.TabPageRendering = new System.Windows.Forms.TabPage();
      this.LabelInfoSearchMinRefForDialog = new System.Windows.Forms.Label();
      this.LabelInfoSearchDisplayMaxRef = new System.Windows.Forms.Label();
      this.LabelFontSizeCommentaryInfo = new System.Windows.Forms.Label();
      this.LabelFontSizeTranslationInfo = new System.Windows.Forms.Label();
      this.LabelFontSizeHebrewInfo = new System.Windows.Forms.Label();
      this.LabelInfoWordControlWidth = new System.Windows.Forms.Label();
      this.LabelInfoWordtranslateLinesCount = new System.Windows.Forms.Label();
      this.LabelInfoCommentLinesCount = new System.Windows.Forms.Label();
      this.EditFontSizeCommentary = new System.Windows.Forms.NumericUpDown();
      this.EditFontSizeTranslation = new System.Windows.Forms.NumericUpDown();
      this.EditFontSizeHebrew = new System.Windows.Forms.NumericUpDown();
      this.EditWordControlWidth = new System.Windows.Forms.NumericUpDown();
      this.EditSearchMinRefForDialog = new System.Windows.Forms.NumericUpDown();
      this.EditSearchDisplayMaxRef = new System.Windows.Forms.NumericUpDown();
      this.EditWordTranslateLinesCount = new System.Windows.Forms.NumericUpDown();
      this.EditCommentaryLinesCount = new System.Windows.Forms.NumericUpDown();
      this.TabPageTools = new System.Windows.Forms.TabPage();
      this.GroupBoxHebrewWordClickShift = new System.Windows.Forms.GroupBox();
      this.GroupBoxHebrewWordClickShift5 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShift0 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShift1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShift3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShift2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShift4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickAlt = new System.Windows.Forms.GroupBox();
      this.GroupBoxHebrewWordClickShiftCtrl5 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShiftCtrl0 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShiftCtrl1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShiftCtrl3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShiftCtrl2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickShiftCtrl4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxVerseLabelClick = new System.Windows.Forms.GroupBox();
      this.GroupBoxVerseLabelClick4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxVerseLabelClick1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxVerseLabelClick2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxVerseLabelClick3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxTranslatedItemDoubleClick = new System.Windows.Forms.GroupBox();
      this.GroupBoxTranslatedItemDoubleClick4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxTranslatedItemDoubleClick1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxTranslatedItemDoubleClick2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxTranslatedItemDoubleClick3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl = new System.Windows.Forms.GroupBox();
      this.GroupBoxHebrewWordClickCtrl5 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl0 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClickCtrl4 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick = new System.Windows.Forms.GroupBox();
      this.GroupBoxHebrewWordClick5 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick0 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick1 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick3 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick2 = new System.Windows.Forms.RadioButton();
      this.GroupBoxHebrewWordClick4 = new System.Windows.Forms.RadioButton();
      this.ActionOnlineSearchHelp = new System.Windows.Forms.Button();
      this.ActionOnlineVerseHelp = new System.Windows.Forms.Button();
      this.ActionSelectOnlineSearch = new System.Windows.Forms.Button();
      this.ActionSelectOnlineVerseURL = new System.Windows.Forms.Button();
      this.EditOnlineVerseURL = new System.Windows.Forms.TextBox();
      this.EditOnlineSearch = new System.Windows.Forms.TextBox();
      this.SaveThemeDialog = new System.Windows.Forms.SaveFileDialog();
      this.OpenThemeDialog = new System.Windows.Forms.OpenFileDialog();
      this.MenuSelectSearchRequest = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.MenuSelectOnlineVerseURL = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
      ((System.ComponentModel.ISupportInitialize)(this.EditCheckUpdateAtStartupInterval)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditVacuumAtStartupInterval)).BeginInit();
      this.TabPageApplication.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoSaveDelay)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoBackupCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditVolume)).BeginInit();
      this.TabControl.SuspendLayout();
      this.TabPageBookmarks.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditHistoryCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditBookmarksCount)).BeginInit();
      this.TabPageTheme.SuspendLayout();
      this.TabPageRendering.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSizeCommentary)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSizeTranslation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditFontSizeHebrew)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditWordControlWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditSearchMinRefForDialog)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditSearchDisplayMaxRef)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditWordTranslateLinesCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditCommentaryLinesCount)).BeginInit();
      this.TabPageTools.SuspendLayout();
      this.GroupBoxHebrewWordClickShift.SuspendLayout();
      this.GroupBoxHebrewWordClickAlt.SuspendLayout();
      this.GroupBoxVerseLabelClick.SuspendLayout();
      this.GroupBoxTranslatedItemDoubleClick.SuspendLayout();
      this.GroupBoxHebrewWordClickCtrl.SuspendLayout();
      this.GroupBoxHebrewWordClick.SuspendLayout();
      this.SuspendLayout();
      // 
      // LabelWordControlWidth
      // 
      resources.ApplyResources(LabelWordControlWidth, "LabelWordControlWidth");
      LabelWordControlWidth.Name = "LabelWordControlWidth";
      this.toolTip1.SetToolTip(LabelWordControlWidth, resources.GetString("LabelWordControlWidth.ToolTip"));
      // 
      // LabelMinRefCount
      // 
      resources.ApplyResources(LabelMinRefCount, "LabelMinRefCount");
      LabelMinRefCount.Name = "LabelMinRefCount";
      this.toolTip1.SetToolTip(LabelMinRefCount, resources.GetString("LabelMinRefCount.ToolTip"));
      // 
      // LabelMaxRefCount
      // 
      resources.ApplyResources(LabelMaxRefCount, "LabelMaxRefCount");
      LabelMaxRefCount.Name = "LabelMaxRefCount";
      this.toolTip1.SetToolTip(LabelMaxRefCount, resources.GetString("LabelMaxRefCount.ToolTip"));
      // 
      // LabelHistoryCount
      // 
      resources.ApplyResources(LabelHistoryCount, "LabelHistoryCount");
      LabelHistoryCount.Name = "LabelHistoryCount";
      this.toolTip1.SetToolTip(LabelHistoryCount, resources.GetString("LabelHistoryCount.ToolTip"));
      // 
      // LabelBookmarksCount
      // 
      resources.ApplyResources(LabelBookmarksCount, "LabelBookmarksCount");
      LabelBookmarksCount.Name = "LabelBookmarksCount";
      this.toolTip1.SetToolTip(LabelBookmarksCount, resources.GetString("LabelBookmarksCount.ToolTip"));
      // 
      // LabelCommentaryLinesCount
      // 
      resources.ApplyResources(LabelCommentaryLinesCount, "LabelCommentaryLinesCount");
      LabelCommentaryLinesCount.Name = "LabelCommentaryLinesCount";
      this.toolTip1.SetToolTip(LabelCommentaryLinesCount, resources.GetString("LabelCommentaryLinesCount.ToolTip"));
      // 
      // LabelBackupPath
      // 
      resources.ApplyResources(LabelBackupPath, "LabelBackupPath");
      LabelBackupPath.Name = "LabelBackupPath";
      this.toolTip1.SetToolTip(LabelBackupPath, resources.GetString("LabelBackupPath.ToolTip"));
      // 
      // LabelOnlineVerseURL
      // 
      resources.ApplyResources(LabelOnlineVerseURL, "LabelOnlineVerseURL");
      LabelOnlineVerseURL.Name = "LabelOnlineVerseURL";
      this.toolTip1.SetToolTip(LabelOnlineVerseURL, resources.GetString("LabelOnlineVerseURL.ToolTip"));
      // 
      // LabelOnlineSearch
      // 
      resources.ApplyResources(LabelOnlineSearch, "LabelOnlineSearch");
      LabelOnlineSearch.Name = "LabelOnlineSearch";
      this.toolTip1.SetToolTip(LabelOnlineSearch, resources.GetString("LabelOnlineSearch.ToolTip"));
      // 
      // LabelAutoSaveDelay
      // 
      resources.ApplyResources(LabelAutoSaveDelay, "LabelAutoSaveDelay");
      LabelAutoSaveDelay.Name = "LabelAutoSaveDelay";
      this.toolTip1.SetToolTip(LabelAutoSaveDelay, resources.GetString("LabelAutoSaveDelay.ToolTip"));
      // 
      // LabelBackupCount
      // 
      resources.ApplyResources(LabelBackupCount, "LabelBackupCount");
      LabelBackupCount.Name = "LabelBackupCount";
      this.toolTip1.SetToolTip(LabelBackupCount, resources.GetString("LabelBackupCount.ToolTip"));
      // 
      // LabelWordtranslateLinesCount
      // 
      resources.ApplyResources(LabelWordtranslateLinesCount, "LabelWordtranslateLinesCount");
      LabelWordtranslateLinesCount.Name = "LabelWordtranslateLinesCount";
      this.toolTip1.SetToolTip(LabelWordtranslateLinesCount, resources.GetString("LabelWordtranslateLinesCount.ToolTip"));
      // 
      // LabelFontSizeHebrew
      // 
      resources.ApplyResources(LabelFontSizeHebrew, "LabelFontSizeHebrew");
      LabelFontSizeHebrew.Name = "LabelFontSizeHebrew";
      this.toolTip1.SetToolTip(LabelFontSizeHebrew, resources.GetString("LabelFontSizeHebrew.ToolTip"));
      // 
      // LabelFontSizeTranslation
      // 
      resources.ApplyResources(LabelFontSizeTranslation, "LabelFontSizeTranslation");
      LabelFontSizeTranslation.Name = "LabelFontSizeTranslation";
      this.toolTip1.SetToolTip(LabelFontSizeTranslation, resources.GetString("LabelFontSizeTranslation.ToolTip"));
      // 
      // LabelFontSizeComentary
      // 
      resources.ApplyResources(LabelFontSizeComentary, "LabelFontSizeComentary");
      LabelFontSizeComentary.Name = "LabelFontSizeComentary";
      this.toolTip1.SetToolTip(LabelFontSizeComentary, resources.GetString("LabelFontSizeComentary.ToolTip"));
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
      this.toolTip1.SetToolTip(this.ActionClose, resources.GetString("ActionClose.ToolTip"));
      this.ActionClose.UseVisualStyleBackColor = true;
      // 
      // PanelButtons
      // 
      resources.ApplyResources(this.PanelButtons, "PanelButtons");
      this.PanelButtons.Controls.Add(this.ActionExportSettings);
      this.PanelButtons.Controls.Add(this.ActionImportSettings);
      this.PanelButtons.Controls.Add(this.ActionResetSettings);
      this.PanelButtons.Controls.Add(this.ActionClose);
      this.PanelButtons.Name = "PanelButtons";
      this.toolTip1.SetToolTip(this.PanelButtons, resources.GetString("PanelButtons.ToolTip"));
      // 
      // ActionExportSettings
      // 
      resources.ApplyResources(this.ActionExportSettings, "ActionExportSettings");
      this.ActionExportSettings.AllowDrop = true;
      this.ActionExportSettings.FlatAppearance.BorderSize = 0;
      this.ActionExportSettings.Name = "ActionExportSettings";
      this.toolTip1.SetToolTip(this.ActionExportSettings, resources.GetString("ActionExportSettings.ToolTip"));
      this.ActionExportSettings.UseVisualStyleBackColor = true;
      this.ActionExportSettings.Click += new System.EventHandler(this.ActionExportSettings_Click);
      // 
      // ActionImportSettings
      // 
      resources.ApplyResources(this.ActionImportSettings, "ActionImportSettings");
      this.ActionImportSettings.AllowDrop = true;
      this.ActionImportSettings.FlatAppearance.BorderSize = 0;
      this.ActionImportSettings.Name = "ActionImportSettings";
      this.toolTip1.SetToolTip(this.ActionImportSettings, resources.GetString("ActionImportSettings.ToolTip"));
      this.ActionImportSettings.UseVisualStyleBackColor = true;
      this.ActionImportSettings.Click += new System.EventHandler(this.ActionImportSettings_Click);
      // 
      // ActionResetSettings
      // 
      resources.ApplyResources(this.ActionResetSettings, "ActionResetSettings");
      this.ActionResetSettings.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      this.ActionResetSettings.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.ActionResetSettings.LinkColor = System.Drawing.Color.Navy;
      this.ActionResetSettings.Name = "ActionResetSettings";
      this.ActionResetSettings.TabStop = true;
      this.toolTip1.SetToolTip(this.ActionResetSettings, resources.GetString("ActionResetSettings.ToolTip"));
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
      this.toolTip1.SetToolTip(this.PanelBottomSeparator, resources.GetString("PanelBottomSeparator.ToolTip"));
      // 
      // FolderBrowserDialog
      // 
      resources.ApplyResources(this.FolderBrowserDialog, "FolderBrowserDialog");
      // 
      // SaveSettingsDialog
      // 
      resources.ApplyResources(this.SaveSettingsDialog, "SaveSettingsDialog");
      // 
      // OpenSettingsDialog
      // 
      resources.ApplyResources(this.OpenSettingsDialog, "OpenSettingsDialog");
      // 
      // TabPagePaths
      // 
      resources.ApplyResources(this.TabPagePaths, "TabPagePaths");
      this.TabPagePaths.BackColor = System.Drawing.SystemColors.Window;
      this.TabPagePaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPagePaths.Controls.Add(this.EditImageExportFileFormat);
      this.TabPagePaths.Controls.Add(LabelBackupPath);
      this.TabPagePaths.Controls.Add(this.LabelExportFolder);
      this.TabPagePaths.Controls.Add(this.ActionResetExportFolder);
      this.TabPagePaths.Controls.Add(this.LabelDataExportFileFormat);
      this.TabPagePaths.Controls.Add(this.EditDataExportFileFormat);
      this.TabPagePaths.Controls.Add(this.ActionSelectExportFolder);
      this.TabPagePaths.Controls.Add(this.LabelImageExportFileFormat);
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
      this.TabPagePaths.Name = "TabPagePaths";
      this.toolTip1.SetToolTip(this.TabPagePaths, resources.GetString("TabPagePaths.ToolTip"));
      // 
      // EditImageExportFileFormat
      // 
      resources.ApplyResources(this.EditImageExportFileFormat, "EditImageExportFileFormat");
      this.EditImageExportFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.EditImageExportFileFormat.FormattingEnabled = true;
      this.EditImageExportFileFormat.Name = "EditImageExportFileFormat";
      this.toolTip1.SetToolTip(this.EditImageExportFileFormat, resources.GetString("EditImageExportFileFormat.ToolTip"));
      this.EditImageExportFileFormat.SelectedIndexChanged += new System.EventHandler(this.EditImageExportFileFormat_SelectedIndexChanged);
      this.EditImageExportFileFormat.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.EditImageExportFileFormat_Format);
      // 
      // LabelExportFolder
      // 
      resources.ApplyResources(this.LabelExportFolder, "LabelExportFolder");
      this.LabelExportFolder.Name = "LabelExportFolder";
      this.toolTip1.SetToolTip(this.LabelExportFolder, resources.GetString("LabelExportFolder.ToolTip"));
      // 
      // ActionResetExportFolder
      // 
      resources.ApplyResources(this.ActionResetExportFolder, "ActionResetExportFolder");
      this.ActionResetExportFolder.FlatAppearance.BorderSize = 0;
      this.ActionResetExportFolder.Name = "ActionResetExportFolder";
      this.toolTip1.SetToolTip(this.ActionResetExportFolder, resources.GetString("ActionResetExportFolder.ToolTip"));
      this.ActionResetExportFolder.UseVisualStyleBackColor = true;
      this.ActionResetExportFolder.Click += new System.EventHandler(this.ActionResetExportFolder_Click);
      // 
      // LabelDataExportFileFormat
      // 
      resources.ApplyResources(this.LabelDataExportFileFormat, "LabelDataExportFileFormat");
      this.LabelDataExportFileFormat.Name = "LabelDataExportFileFormat";
      this.toolTip1.SetToolTip(this.LabelDataExportFileFormat, resources.GetString("LabelDataExportFileFormat.ToolTip"));
      // 
      // EditDataExportFileFormat
      // 
      resources.ApplyResources(this.EditDataExportFileFormat, "EditDataExportFileFormat");
      this.EditDataExportFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.EditDataExportFileFormat.FormattingEnabled = true;
      this.EditDataExportFileFormat.Name = "EditDataExportFileFormat";
      this.toolTip1.SetToolTip(this.EditDataExportFileFormat, resources.GetString("EditDataExportFileFormat.ToolTip"));
      this.EditDataExportFileFormat.SelectedIndexChanged += new System.EventHandler(this.EditDataExportFileFormat_SelectedIndexChanged);
      this.EditDataExportFileFormat.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.EditDataExportFileFormat_Format);
      // 
      // ActionSelectExportFolder
      // 
      resources.ApplyResources(this.ActionSelectExportFolder, "ActionSelectExportFolder");
      this.ActionSelectExportFolder.FlatAppearance.BorderSize = 0;
      this.ActionSelectExportFolder.Name = "ActionSelectExportFolder";
      this.toolTip1.SetToolTip(this.ActionSelectExportFolder, resources.GetString("ActionSelectExportFolder.ToolTip"));
      this.ActionSelectExportFolder.UseVisualStyleBackColor = true;
      this.ActionSelectExportFolder.Click += new System.EventHandler(this.ActionSelectExportFolder_Click);
      // 
      // LabelImageExportFileFormat
      // 
      resources.ApplyResources(this.LabelImageExportFileFormat, "LabelImageExportFileFormat");
      this.LabelImageExportFileFormat.Name = "LabelImageExportFileFormat";
      this.toolTip1.SetToolTip(this.LabelImageExportFileFormat, resources.GetString("LabelImageExportFileFormat.ToolTip"));
      // 
      // LabelCalculatorPath
      // 
      resources.ApplyResources(this.LabelCalculatorPath, "LabelCalculatorPath");
      this.LabelCalculatorPath.Name = "LabelCalculatorPath";
      this.toolTip1.SetToolTip(this.LabelCalculatorPath, resources.GetString("LabelCalculatorPath.ToolTip"));
      // 
      // ActionResetBackupFolder
      // 
      resources.ApplyResources(this.ActionResetBackupFolder, "ActionResetBackupFolder");
      this.ActionResetBackupFolder.FlatAppearance.BorderSize = 0;
      this.ActionResetBackupFolder.Name = "ActionResetBackupFolder";
      this.toolTip1.SetToolTip(this.ActionResetBackupFolder, resources.GetString("ActionResetBackupFolder.ToolTip"));
      this.ActionResetBackupFolder.UseVisualStyleBackColor = true;
      this.ActionResetBackupFolder.Click += new System.EventHandler(this.ActionResetBackupFolder_Click);
      // 
      // ActionResetHebrewLettersPath
      // 
      resources.ApplyResources(this.ActionResetHebrewLettersPath, "ActionResetHebrewLettersPath");
      this.ActionResetHebrewLettersPath.FlatAppearance.BorderSize = 0;
      this.ActionResetHebrewLettersPath.Name = "ActionResetHebrewLettersPath";
      this.toolTip1.SetToolTip(this.ActionResetHebrewLettersPath, resources.GetString("ActionResetHebrewLettersPath.ToolTip"));
      this.ActionResetHebrewLettersPath.UseVisualStyleBackColor = true;
      this.ActionResetHebrewLettersPath.Click += new System.EventHandler(this.ActionResetHebrewLettersPath_Click);
      // 
      // ActionResetCalculatorPath
      // 
      resources.ApplyResources(this.ActionResetCalculatorPath, "ActionResetCalculatorPath");
      this.ActionResetCalculatorPath.FlatAppearance.BorderSize = 0;
      this.ActionResetCalculatorPath.Name = "ActionResetCalculatorPath";
      this.toolTip1.SetToolTip(this.ActionResetCalculatorPath, resources.GetString("ActionResetCalculatorPath.ToolTip"));
      this.ActionResetCalculatorPath.UseVisualStyleBackColor = true;
      this.ActionResetCalculatorPath.Click += new System.EventHandler(this.ActionResetCalculatorPath_Click);
      // 
      // ActionSelectCalculatorPath
      // 
      resources.ApplyResources(this.ActionSelectCalculatorPath, "ActionSelectCalculatorPath");
      this.ActionSelectCalculatorPath.FlatAppearance.BorderSize = 0;
      this.ActionSelectCalculatorPath.Name = "ActionSelectCalculatorPath";
      this.toolTip1.SetToolTip(this.ActionSelectCalculatorPath, resources.GetString("ActionSelectCalculatorPath.ToolTip"));
      this.ActionSelectCalculatorPath.UseVisualStyleBackColor = true;
      this.ActionSelectCalculatorPath.Click += new System.EventHandler(this.ActionSelectCalculatorPath_Click);
      // 
      // LabelHebrewLettersPath
      // 
      resources.ApplyResources(this.LabelHebrewLettersPath, "LabelHebrewLettersPath");
      this.LabelHebrewLettersPath.Name = "LabelHebrewLettersPath";
      this.toolTip1.SetToolTip(this.LabelHebrewLettersPath, resources.GetString("LabelHebrewLettersPath.ToolTip"));
      // 
      // ActionSelectBackupFolder
      // 
      resources.ApplyResources(this.ActionSelectBackupFolder, "ActionSelectBackupFolder");
      this.ActionSelectBackupFolder.FlatAppearance.BorderSize = 0;
      this.ActionSelectBackupFolder.Name = "ActionSelectBackupFolder";
      this.toolTip1.SetToolTip(this.ActionSelectBackupFolder, resources.GetString("ActionSelectBackupFolder.ToolTip"));
      this.ActionSelectBackupFolder.UseVisualStyleBackColor = true;
      this.ActionSelectBackupFolder.Click += new System.EventHandler(this.ActionSelectBackupFolder_Click);
      // 
      // ActionSelectHebrewLettersPath
      // 
      resources.ApplyResources(this.ActionSelectHebrewLettersPath, "ActionSelectHebrewLettersPath");
      this.ActionSelectHebrewLettersPath.FlatAppearance.BorderSize = 0;
      this.ActionSelectHebrewLettersPath.Name = "ActionSelectHebrewLettersPath";
      this.toolTip1.SetToolTip(this.ActionSelectHebrewLettersPath, resources.GetString("ActionSelectHebrewLettersPath.ToolTip"));
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
      this.toolTip1.SetToolTip(this.EditBackupFolder, resources.GetString("EditBackupFolder.ToolTip"));
      // 
      // EditExportFolder
      // 
      resources.ApplyResources(this.EditExportFolder, "EditExportFolder");
      this.EditExportFolder.BackColor = System.Drawing.SystemColors.Control;
      this.EditExportFolder.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditExportFolder.Name = "EditExportFolder";
      this.EditExportFolder.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditExportFolder, resources.GetString("EditExportFolder.ToolTip"));
      // 
      // EditCalculatorPath
      // 
      resources.ApplyResources(this.EditCalculatorPath, "EditCalculatorPath");
      this.EditCalculatorPath.BackColor = System.Drawing.SystemColors.Control;
      this.EditCalculatorPath.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditCalculatorPath.Name = "EditCalculatorPath";
      this.EditCalculatorPath.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditCalculatorPath, resources.GetString("EditCalculatorPath.ToolTip"));
      // 
      // EditHebrewLettersPath
      // 
      resources.ApplyResources(this.EditHebrewLettersPath, "EditHebrewLettersPath");
      this.EditHebrewLettersPath.BackColor = System.Drawing.SystemColors.Control;
      this.EditHebrewLettersPath.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      this.EditHebrewLettersPath.Name = "EditHebrewLettersPath";
      this.EditHebrewLettersPath.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditHebrewLettersPath, resources.GetString("EditHebrewLettersPath.ToolTip"));
      // 
      // EditAutoOpenExportedFile
      // 
      resources.ApplyResources(this.EditAutoOpenExportedFile, "EditAutoOpenExportedFile");
      this.EditAutoOpenExportedFile.Name = "EditAutoOpenExportedFile";
      this.toolTip1.SetToolTip(this.EditAutoOpenExportedFile, resources.GetString("EditAutoOpenExportedFile.ToolTip"));
      this.EditAutoOpenExportedFile.UseVisualStyleBackColor = true;
      this.EditAutoOpenExportedFile.CheckedChanged += new System.EventHandler(this.EditAutoOpenExportedFile_CheckedChanged);
      // 
      // EditAutoOpenExportFolder
      // 
      resources.ApplyResources(this.EditAutoOpenExportFolder, "EditAutoOpenExportFolder");
      this.EditAutoOpenExportFolder.Name = "EditAutoOpenExportFolder";
      this.toolTip1.SetToolTip(this.EditAutoOpenExportFolder, resources.GetString("EditAutoOpenExportFolder.ToolTip"));
      this.EditAutoOpenExportFolder.UseVisualStyleBackColor = true;
      this.EditAutoOpenExportFolder.CheckedChanged += new System.EventHandler(this.EditAutoOpenExportFolder_CheckedChanged);
      // 
      // TabPageStartup
      // 
      resources.ApplyResources(this.TabPageStartup, "TabPageStartup");
      this.TabPageStartup.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageStartup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageStartup.Controls.Add(this.EditGoToLastVerseAtStartup);
      this.TabPageStartup.Controls.Add(this.EditGoToMasterBookmarkAtStartup);
      this.TabPageStartup.Controls.Add(this.EditShowLastNewInVersionAfterUpdate);
      this.TabPageStartup.Controls.Add(this.LabelLastDBOptimizeDate);
      this.TabPageStartup.Controls.Add(this.LabelLastDBOptimize);
      this.TabPageStartup.Controls.Add(this.LabelLastStartupCheckDate);
      this.TabPageStartup.Controls.Add(this.LabelLastStartupCheck);
      this.TabPageStartup.Controls.Add(this.LabelInfoCheckUpdateAtStartup);
      this.TabPageStartup.Controls.Add(this.EditCheckUpdateAtStartup);
      this.TabPageStartup.Controls.Add(this.EditCheckUpdateAtStartupInterval);
      this.TabPageStartup.Controls.Add(this.EditVacuumAtStartupInterval);
      this.TabPageStartup.Controls.Add(this.EditVacuumAtStartup);
      this.TabPageStartup.Controls.Add(this.LabelInfoOptimizeDatabaseIntervalInfo);
      this.TabPageStartup.Name = "TabPageStartup";
      this.toolTip1.SetToolTip(this.TabPageStartup, resources.GetString("TabPageStartup.ToolTip"));
      // 
      // EditGoToLastVerseAtStartup
      // 
      resources.ApplyResources(this.EditGoToLastVerseAtStartup, "EditGoToLastVerseAtStartup");
      this.EditGoToLastVerseAtStartup.Name = "EditGoToLastVerseAtStartup";
      this.toolTip1.SetToolTip(this.EditGoToLastVerseAtStartup, resources.GetString("EditGoToLastVerseAtStartup.ToolTip"));
      this.EditGoToLastVerseAtStartup.UseVisualStyleBackColor = true;
      this.EditGoToLastVerseAtStartup.CheckedChanged += new System.EventHandler(this.EditGoToLastVerseAtStartup_CheckedChanged);
      // 
      // EditGoToMasterBookmarkAtStartup
      // 
      resources.ApplyResources(this.EditGoToMasterBookmarkAtStartup, "EditGoToMasterBookmarkAtStartup");
      this.EditGoToMasterBookmarkAtStartup.Name = "EditGoToMasterBookmarkAtStartup";
      this.toolTip1.SetToolTip(this.EditGoToMasterBookmarkAtStartup, resources.GetString("EditGoToMasterBookmarkAtStartup.ToolTip"));
      this.EditGoToMasterBookmarkAtStartup.UseVisualStyleBackColor = true;
      this.EditGoToMasterBookmarkAtStartup.CheckedChanged += new System.EventHandler(this.EditGoToMasterBookmarkAtStartup_CheckedChanged);
      // 
      // EditShowLastNewInVersionAfterUpdate
      // 
      resources.ApplyResources(this.EditShowLastNewInVersionAfterUpdate, "EditShowLastNewInVersionAfterUpdate");
      this.EditShowLastNewInVersionAfterUpdate.Name = "EditShowLastNewInVersionAfterUpdate";
      this.toolTip1.SetToolTip(this.EditShowLastNewInVersionAfterUpdate, resources.GetString("EditShowLastNewInVersionAfterUpdate.ToolTip"));
      this.EditShowLastNewInVersionAfterUpdate.UseVisualStyleBackColor = true;
      // 
      // LabelLastDBOptimizeDate
      // 
      resources.ApplyResources(this.LabelLastDBOptimizeDate, "LabelLastDBOptimizeDate");
      this.LabelLastDBOptimizeDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelLastDBOptimizeDate.Name = "LabelLastDBOptimizeDate";
      this.toolTip1.SetToolTip(this.LabelLastDBOptimizeDate, resources.GetString("LabelLastDBOptimizeDate.ToolTip"));
      // 
      // LabelLastDBOptimize
      // 
      resources.ApplyResources(this.LabelLastDBOptimize, "LabelLastDBOptimize");
      this.LabelLastDBOptimize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelLastDBOptimize.Name = "LabelLastDBOptimize";
      this.toolTip1.SetToolTip(this.LabelLastDBOptimize, resources.GetString("LabelLastDBOptimize.ToolTip"));
      // 
      // LabelLastStartupCheckDate
      // 
      resources.ApplyResources(this.LabelLastStartupCheckDate, "LabelLastStartupCheckDate");
      this.LabelLastStartupCheckDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelLastStartupCheckDate.Name = "LabelLastStartupCheckDate";
      this.toolTip1.SetToolTip(this.LabelLastStartupCheckDate, resources.GetString("LabelLastStartupCheckDate.ToolTip"));
      // 
      // LabelLastStartupCheck
      // 
      resources.ApplyResources(this.LabelLastStartupCheck, "LabelLastStartupCheck");
      this.LabelLastStartupCheck.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelLastStartupCheck.Name = "LabelLastStartupCheck";
      this.toolTip1.SetToolTip(this.LabelLastStartupCheck, resources.GetString("LabelLastStartupCheck.ToolTip"));
      // 
      // LabelInfoCheckUpdateAtStartup
      // 
      resources.ApplyResources(this.LabelInfoCheckUpdateAtStartup, "LabelInfoCheckUpdateAtStartup");
      this.LabelInfoCheckUpdateAtStartup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoCheckUpdateAtStartup.Name = "LabelInfoCheckUpdateAtStartup";
      this.toolTip1.SetToolTip(this.LabelInfoCheckUpdateAtStartup, resources.GetString("LabelInfoCheckUpdateAtStartup.ToolTip"));
      // 
      // EditCheckUpdateAtStartup
      // 
      resources.ApplyResources(this.EditCheckUpdateAtStartup, "EditCheckUpdateAtStartup");
      this.EditCheckUpdateAtStartup.Name = "EditCheckUpdateAtStartup";
      this.toolTip1.SetToolTip(this.EditCheckUpdateAtStartup, resources.GetString("EditCheckUpdateAtStartup.ToolTip"));
      this.EditCheckUpdateAtStartup.UseVisualStyleBackColor = true;
      this.EditCheckUpdateAtStartup.CheckedChanged += new System.EventHandler(this.EditCheckUpdateAtStartup_CheckedChanged);
      // 
      // EditCheckUpdateAtStartupInterval
      // 
      resources.ApplyResources(this.EditCheckUpdateAtStartupInterval, "EditCheckUpdateAtStartupInterval");
      this.EditCheckUpdateAtStartupInterval.BackColor = System.Drawing.SystemColors.Window;
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
      this.toolTip1.SetToolTip(this.EditCheckUpdateAtStartupInterval, resources.GetString("EditCheckUpdateAtStartupInterval.ToolTip"));
      this.EditCheckUpdateAtStartupInterval.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
      // 
      // EditVacuumAtStartupInterval
      // 
      resources.ApplyResources(this.EditVacuumAtStartupInterval, "EditVacuumAtStartupInterval");
      this.EditVacuumAtStartupInterval.BackColor = System.Drawing.SystemColors.Window;
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
      this.toolTip1.SetToolTip(this.EditVacuumAtStartupInterval, resources.GetString("EditVacuumAtStartupInterval.ToolTip"));
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
      this.toolTip1.SetToolTip(this.EditVacuumAtStartup, resources.GetString("EditVacuumAtStartup.ToolTip"));
      this.EditVacuumAtStartup.UseVisualStyleBackColor = true;
      this.EditVacuumAtStartup.CheckedChanged += new System.EventHandler(this.EditVacuumAtStartup_CheckedChanged);
      // 
      // LabelInfoOptimizeDatabaseIntervalInfo
      // 
      resources.ApplyResources(this.LabelInfoOptimizeDatabaseIntervalInfo, "LabelInfoOptimizeDatabaseIntervalInfo");
      this.LabelInfoOptimizeDatabaseIntervalInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoOptimizeDatabaseIntervalInfo.Name = "LabelInfoOptimizeDatabaseIntervalInfo";
      this.toolTip1.SetToolTip(this.LabelInfoOptimizeDatabaseIntervalInfo, resources.GetString("LabelInfoOptimizeDatabaseIntervalInfo.ToolTip"));
      // 
      // TabPageApplication
      // 
      resources.ApplyResources(this.TabPageApplication, "TabPageApplication");
      this.TabPageApplication.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageApplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageApplication.Controls.Add(this.ActionCheckAllComments);
      this.TabPageApplication.Controls.Add(this.EditCommentLinePrefix);
      this.TabPageApplication.Controls.Add(this.LabelInfoAutoSaveDelay);
      this.TabPageApplication.Controls.Add(this.LabelInfoAutoBackupCount);
      this.TabPageApplication.Controls.Add(this.EditAutoSaveDelay);
      this.TabPageApplication.Controls.Add(LabelAutoSaveDelay);
      this.TabPageApplication.Controls.Add(this.EditAutoBackupCount);
      this.TabPageApplication.Controls.Add(LabelBackupCount);
      this.TabPageApplication.Controls.Add(this.EditAutoOpenExportedFile);
      this.TabPageApplication.Controls.Add(this.EditAutoOpenExportFolder);
      this.TabPageApplication.Controls.Add(this.EditVolume);
      this.TabPageApplication.Controls.Add(this.LabelVolume);
      this.TabPageApplication.Controls.Add(this.LabelVolumeValue);
      this.TabPageApplication.Controls.Add(this.ActionSelectLangEN);
      this.TabPageApplication.Controls.Add(this.ActionSelectLangFR);
      this.TabPageApplication.Controls.Add(this.EditWindowsDoubleBufferingEnabled);
      this.TabPageApplication.Controls.Add(this.EditCommentLineRemovePrefix);
      this.TabPageApplication.Controls.Add(this.EditCommentLineAddPrefix);
      this.TabPageApplication.Controls.Add(this.EditBookNameHebrewWithCommonName);
      this.TabPageApplication.Controls.Add(this.EditWebLinksMenuEnabled);
      this.TabPageApplication.Controls.Add(this.EditDebuggerEnabled);
      this.TabPageApplication.Controls.Add(this.EditUsageStatisticsEnabled);
      this.TabPageApplication.Controls.Add(this.EditLogEnabled);
      this.TabPageApplication.Name = "TabPageApplication";
      this.toolTip1.SetToolTip(this.TabPageApplication, resources.GetString("TabPageApplication.ToolTip"));
      // 
      // ActionCheckAllComments
      // 
      resources.ApplyResources(this.ActionCheckAllComments, "ActionCheckAllComments");
      this.ActionCheckAllComments.AllowDrop = true;
      this.ActionCheckAllComments.FlatAppearance.BorderSize = 0;
      this.ActionCheckAllComments.Name = "ActionCheckAllComments";
      this.toolTip1.SetToolTip(this.ActionCheckAllComments, resources.GetString("ActionCheckAllComments.ToolTip"));
      this.ActionCheckAllComments.UseVisualStyleBackColor = true;
      this.ActionCheckAllComments.Click += new System.EventHandler(this.ActionCheckAllComments_Click);
      // 
      // EditCommentLinePrefix
      // 
      resources.ApplyResources(this.EditCommentLinePrefix, "EditCommentLinePrefix");
      this.EditCommentLinePrefix.Name = "EditCommentLinePrefix";
      this.toolTip1.SetToolTip(this.EditCommentLinePrefix, resources.GetString("EditCommentLinePrefix.ToolTip"));
      // 
      // LabelInfoAutoSaveDelay
      // 
      resources.ApplyResources(this.LabelInfoAutoSaveDelay, "LabelInfoAutoSaveDelay");
      this.LabelInfoAutoSaveDelay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoAutoSaveDelay.Name = "LabelInfoAutoSaveDelay";
      this.toolTip1.SetToolTip(this.LabelInfoAutoSaveDelay, resources.GetString("LabelInfoAutoSaveDelay.ToolTip"));
      // 
      // LabelInfoAutoBackupCount
      // 
      resources.ApplyResources(this.LabelInfoAutoBackupCount, "LabelInfoAutoBackupCount");
      this.LabelInfoAutoBackupCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoAutoBackupCount.Name = "LabelInfoAutoBackupCount";
      this.toolTip1.SetToolTip(this.LabelInfoAutoBackupCount, resources.GetString("LabelInfoAutoBackupCount.ToolTip"));
      // 
      // EditAutoSaveDelay
      // 
      resources.ApplyResources(this.EditAutoSaveDelay, "EditAutoSaveDelay");
      this.EditAutoSaveDelay.BackColor = System.Drawing.SystemColors.Window;
      this.EditAutoSaveDelay.Name = "EditAutoSaveDelay";
      this.EditAutoSaveDelay.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditAutoSaveDelay, resources.GetString("EditAutoSaveDelay.ToolTip"));
      // 
      // EditAutoBackupCount
      // 
      resources.ApplyResources(this.EditAutoBackupCount, "EditAutoBackupCount");
      this.EditAutoBackupCount.BackColor = System.Drawing.SystemColors.Window;
      this.EditAutoBackupCount.Name = "EditAutoBackupCount";
      this.EditAutoBackupCount.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditAutoBackupCount, resources.GetString("EditAutoBackupCount.ToolTip"));
      // 
      // EditVolume
      // 
      resources.ApplyResources(this.EditVolume, "EditVolume");
      this.EditVolume.Maximum = 100;
      this.EditVolume.Name = "EditVolume";
      this.EditVolume.TickFrequency = 10;
      this.toolTip1.SetToolTip(this.EditVolume, resources.GetString("EditVolume.ToolTip"));
      this.EditVolume.Value = 100;
      this.EditVolume.ValueChanged += new System.EventHandler(this.EditVolume_ValueChanged);
      // 
      // LabelVolume
      // 
      resources.ApplyResources(this.LabelVolume, "LabelVolume");
      this.LabelVolume.Name = "LabelVolume";
      this.toolTip1.SetToolTip(this.LabelVolume, resources.GetString("LabelVolume.ToolTip"));
      // 
      // LabelVolumeValue
      // 
      resources.ApplyResources(this.LabelVolumeValue, "LabelVolumeValue");
      this.LabelVolumeValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelVolumeValue.Name = "LabelVolumeValue";
      this.toolTip1.SetToolTip(this.LabelVolumeValue, resources.GetString("LabelVolumeValue.ToolTip"));
      // 
      // ActionSelectLangEN
      // 
      resources.ApplyResources(this.ActionSelectLangEN, "ActionSelectLangEN");
      this.ActionSelectLangEN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
      this.ActionSelectLangEN.Name = "ActionSelectLangEN";
      this.ActionSelectLangEN.TabStop = false;
      this.toolTip1.SetToolTip(this.ActionSelectLangEN, resources.GetString("ActionSelectLangEN.ToolTip"));
      this.ActionSelectLangEN.UseVisualStyleBackColor = true;
      this.ActionSelectLangEN.Click += new System.EventHandler(this.ActionSelectLangEN_Click);
      // 
      // ActionSelectLangFR
      // 
      resources.ApplyResources(this.ActionSelectLangFR, "ActionSelectLangFR");
      this.ActionSelectLangFR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
      this.ActionSelectLangFR.Name = "ActionSelectLangFR";
      this.ActionSelectLangFR.TabStop = false;
      this.toolTip1.SetToolTip(this.ActionSelectLangFR, resources.GetString("ActionSelectLangFR.ToolTip"));
      this.ActionSelectLangFR.UseVisualStyleBackColor = true;
      this.ActionSelectLangFR.Click += new System.EventHandler(this.ActionSelectLangFR_Click);
      // 
      // EditWindowsDoubleBufferingEnabled
      // 
      resources.ApplyResources(this.EditWindowsDoubleBufferingEnabled, "EditWindowsDoubleBufferingEnabled");
      this.EditWindowsDoubleBufferingEnabled.Name = "EditWindowsDoubleBufferingEnabled";
      this.toolTip1.SetToolTip(this.EditWindowsDoubleBufferingEnabled, resources.GetString("EditWindowsDoubleBufferingEnabled.ToolTip"));
      this.EditWindowsDoubleBufferingEnabled.UseVisualStyleBackColor = true;
      // 
      // EditCommentLineRemovePrefix
      // 
      resources.ApplyResources(this.EditCommentLineRemovePrefix, "EditCommentLineRemovePrefix");
      this.EditCommentLineRemovePrefix.Name = "EditCommentLineRemovePrefix";
      this.toolTip1.SetToolTip(this.EditCommentLineRemovePrefix, resources.GetString("EditCommentLineRemovePrefix.ToolTip"));
      this.EditCommentLineRemovePrefix.UseVisualStyleBackColor = true;
      this.EditCommentLineRemovePrefix.CheckedChanged += new System.EventHandler(this.EditCommentLineRemovePrefix_CheckedChanged);
      // 
      // EditCommentLineAddPrefix
      // 
      resources.ApplyResources(this.EditCommentLineAddPrefix, "EditCommentLineAddPrefix");
      this.EditCommentLineAddPrefix.Name = "EditCommentLineAddPrefix";
      this.toolTip1.SetToolTip(this.EditCommentLineAddPrefix, resources.GetString("EditCommentLineAddPrefix.ToolTip"));
      this.EditCommentLineAddPrefix.UseVisualStyleBackColor = true;
      this.EditCommentLineAddPrefix.CheckedChanged += new System.EventHandler(this.EditCommentLineAddPrefix_CheckedChanged);
      // 
      // EditBookNameHebrewWithCommonName
      // 
      resources.ApplyResources(this.EditBookNameHebrewWithCommonName, "EditBookNameHebrewWithCommonName");
      this.EditBookNameHebrewWithCommonName.Name = "EditBookNameHebrewWithCommonName";
      this.toolTip1.SetToolTip(this.EditBookNameHebrewWithCommonName, resources.GetString("EditBookNameHebrewWithCommonName.ToolTip"));
      this.EditBookNameHebrewWithCommonName.UseVisualStyleBackColor = true;
      // 
      // EditWebLinksMenuEnabled
      // 
      resources.ApplyResources(this.EditWebLinksMenuEnabled, "EditWebLinksMenuEnabled");
      this.EditWebLinksMenuEnabled.Name = "EditWebLinksMenuEnabled";
      this.toolTip1.SetToolTip(this.EditWebLinksMenuEnabled, resources.GetString("EditWebLinksMenuEnabled.ToolTip"));
      this.EditWebLinksMenuEnabled.UseVisualStyleBackColor = true;
      // 
      // EditDebuggerEnabled
      // 
      resources.ApplyResources(this.EditDebuggerEnabled, "EditDebuggerEnabled");
      this.EditDebuggerEnabled.Name = "EditDebuggerEnabled";
      this.toolTip1.SetToolTip(this.EditDebuggerEnabled, resources.GetString("EditDebuggerEnabled.ToolTip"));
      this.EditDebuggerEnabled.UseVisualStyleBackColor = true;
      this.EditDebuggerEnabled.CheckedChanged += new System.EventHandler(this.EditDebuggerEnabled_CheckedChanged);
      // 
      // EditUsageStatisticsEnabled
      // 
      resources.ApplyResources(this.EditUsageStatisticsEnabled, "EditUsageStatisticsEnabled");
      this.EditUsageStatisticsEnabled.Name = "EditUsageStatisticsEnabled";
      this.toolTip1.SetToolTip(this.EditUsageStatisticsEnabled, resources.GetString("EditUsageStatisticsEnabled.ToolTip"));
      this.EditUsageStatisticsEnabled.UseVisualStyleBackColor = true;
      this.EditUsageStatisticsEnabled.CheckedChanged += new System.EventHandler(this.EditUsageStatisticsEnabled_CheckedChanged);
      // 
      // EditLogEnabled
      // 
      resources.ApplyResources(this.EditLogEnabled, "EditLogEnabled");
      this.EditLogEnabled.Name = "EditLogEnabled";
      this.toolTip1.SetToolTip(this.EditLogEnabled, resources.GetString("EditLogEnabled.ToolTip"));
      this.EditLogEnabled.UseVisualStyleBackColor = true;
      this.EditLogEnabled.CheckedChanged += new System.EventHandler(this.EditLogEnabled_CheckedChanged);
      // 
      // EditAutoSortBookmarks
      // 
      resources.ApplyResources(this.EditAutoSortBookmarks, "EditAutoSortBookmarks");
      this.EditAutoSortBookmarks.Name = "EditAutoSortBookmarks";
      this.toolTip1.SetToolTip(this.EditAutoSortBookmarks, resources.GetString("EditAutoSortBookmarks.ToolTip"));
      this.EditAutoSortBookmarks.UseVisualStyleBackColor = true;
      // 
      // TabControl
      // 
      resources.ApplyResources(this.TabControl, "TabControl");
      this.TabControl.Controls.Add(this.TabPageApplication);
      this.TabControl.Controls.Add(this.TabPageStartup);
      this.TabControl.Controls.Add(this.TabPageBookmarks);
      this.TabControl.Controls.Add(this.TabPageTheme);
      this.TabControl.Controls.Add(this.TabPageRendering);
      this.TabControl.Controls.Add(this.TabPageTools);
      this.TabControl.Controls.Add(this.TabPagePaths);
      this.TabControl.Multiline = true;
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      this.toolTip1.SetToolTip(this.TabControl, resources.GetString("TabControl.ToolTip"));
      // 
      // TabPageBookmarks
      // 
      resources.ApplyResources(this.TabPageBookmarks, "TabPageBookmarks");
      this.TabPageBookmarks.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageBookmarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageBookmarks.Controls.Add(this.EditAutoSortBookmarks);
      this.TabPageBookmarks.Controls.Add(LabelBookmarksCount);
      this.TabPageBookmarks.Controls.Add(this.EditHistoryCount);
      this.TabPageBookmarks.Controls.Add(this.LabelInfoHistoryCount);
      this.TabPageBookmarks.Controls.Add(LabelHistoryCount);
      this.TabPageBookmarks.Controls.Add(this.EditBookmarksCount);
      this.TabPageBookmarks.Controls.Add(this.LabelInfoBookmarksCount);
      this.TabPageBookmarks.Name = "TabPageBookmarks";
      this.toolTip1.SetToolTip(this.TabPageBookmarks, resources.GetString("TabPageBookmarks.ToolTip"));
      // 
      // EditHistoryCount
      // 
      resources.ApplyResources(this.EditHistoryCount, "EditHistoryCount");
      this.EditHistoryCount.BackColor = System.Drawing.SystemColors.Window;
      this.EditHistoryCount.Name = "EditHistoryCount";
      this.EditHistoryCount.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditHistoryCount, resources.GetString("EditHistoryCount.ToolTip"));
      // 
      // LabelInfoHistoryCount
      // 
      resources.ApplyResources(this.LabelInfoHistoryCount, "LabelInfoHistoryCount");
      this.LabelInfoHistoryCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoHistoryCount.Name = "LabelInfoHistoryCount";
      this.toolTip1.SetToolTip(this.LabelInfoHistoryCount, resources.GetString("LabelInfoHistoryCount.ToolTip"));
      // 
      // EditBookmarksCount
      // 
      resources.ApplyResources(this.EditBookmarksCount, "EditBookmarksCount");
      this.EditBookmarksCount.BackColor = System.Drawing.SystemColors.Window;
      this.EditBookmarksCount.Name = "EditBookmarksCount";
      this.EditBookmarksCount.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditBookmarksCount, resources.GetString("EditBookmarksCount.ToolTip"));
      // 
      // LabelInfoBookmarksCount
      // 
      resources.ApplyResources(this.LabelInfoBookmarksCount, "LabelInfoBookmarksCount");
      this.LabelInfoBookmarksCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoBookmarksCount.Name = "LabelInfoBookmarksCount";
      this.toolTip1.SetToolTip(this.LabelInfoBookmarksCount, resources.GetString("LabelInfoBookmarksCount.ToolTip"));
      // 
      // TabPageTheme
      // 
      resources.ApplyResources(this.TabPageTheme, "TabPageTheme");
      this.TabPageTheme.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageTheme.Controls.Add(this.ActionOpenTheme);
      this.TabPageTheme.Controls.Add(this.ActionSaveTheme);
      this.TabPageTheme.Controls.Add(this.label8);
      this.TabPageTheme.Controls.Add(this.EditThemeNavigatorItems);
      this.TabPageTheme.Controls.Add(this.label4);
      this.TabPageTheme.Controls.Add(this.EditThemeTranslationBack);
      this.TabPageTheme.Controls.Add(this.label2);
      this.TabPageTheme.Controls.Add(this.EditThemeCommentaryBack);
      this.TabPageTheme.Controls.Add(this.label1);
      this.TabPageTheme.Controls.Add(this.EditThemeCurrentControl);
      this.TabPageTheme.Controls.Add(this.label3);
      this.TabPageTheme.Controls.Add(this.EditThemeSearchLettersBack);
      this.TabPageTheme.Controls.Add(this.EditThemeSearchWordBack);
      this.TabPageTheme.Controls.Add(this.label6);
      this.TabPageTheme.Controls.Add(this.ActionUseColorsPastel);
      this.TabPageTheme.Controls.Add(this.ActionUseColorsSystem);
      this.TabPageTheme.Name = "TabPageTheme";
      this.toolTip1.SetToolTip(this.TabPageTheme, resources.GetString("TabPageTheme.ToolTip"));
      // 
      // ActionOpenTheme
      // 
      resources.ApplyResources(this.ActionOpenTheme, "ActionOpenTheme");
      this.ActionOpenTheme.FlatAppearance.BorderSize = 0;
      this.ActionOpenTheme.Name = "ActionOpenTheme";
      this.toolTip1.SetToolTip(this.ActionOpenTheme, resources.GetString("ActionOpenTheme.ToolTip"));
      this.ActionOpenTheme.UseVisualStyleBackColor = true;
      this.ActionOpenTheme.Click += new System.EventHandler(this.ActionOpenTheme_Click);
      // 
      // ActionSaveTheme
      // 
      resources.ApplyResources(this.ActionSaveTheme, "ActionSaveTheme");
      this.ActionSaveTheme.FlatAppearance.BorderSize = 0;
      this.ActionSaveTheme.Name = "ActionSaveTheme";
      this.toolTip1.SetToolTip(this.ActionSaveTheme, resources.GetString("ActionSaveTheme.ToolTip"));
      this.ActionSaveTheme.UseVisualStyleBackColor = true;
      this.ActionSaveTheme.Click += new System.EventHandler(this.ActionSaveTheme_Click);
      // 
      // label8
      // 
      resources.ApplyResources(this.label8, "label8");
      this.label8.Name = "label8";
      this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
      // 
      // EditThemeNavigatorItems
      // 
      resources.ApplyResources(this.EditThemeNavigatorItems, "EditThemeNavigatorItems");
      this.EditThemeNavigatorItems.BackColor = System.Drawing.Color.LightYellow;
      this.EditThemeNavigatorItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditThemeNavigatorItems.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeNavigatorItems.Name = "EditThemeNavigatorItems";
      this.toolTip1.SetToolTip(this.EditThemeNavigatorItems, resources.GetString("EditThemeNavigatorItems.ToolTip"));
      this.EditThemeNavigatorItems.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
      // 
      // EditThemeTranslationBack
      // 
      resources.ApplyResources(this.EditThemeTranslationBack, "EditThemeTranslationBack");
      this.EditThemeTranslationBack.BackColor = System.Drawing.SystemColors.Window;
      this.EditThemeTranslationBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditThemeTranslationBack.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeTranslationBack.Name = "EditThemeTranslationBack";
      this.toolTip1.SetToolTip(this.EditThemeTranslationBack, resources.GetString("EditThemeTranslationBack.ToolTip"));
      this.EditThemeTranslationBack.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
      // 
      // EditThemeCommentaryBack
      // 
      resources.ApplyResources(this.EditThemeCommentaryBack, "EditThemeCommentaryBack");
      this.EditThemeCommentaryBack.BackColor = System.Drawing.Color.Honeydew;
      this.EditThemeCommentaryBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditThemeCommentaryBack.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeCommentaryBack.Name = "EditThemeCommentaryBack";
      this.toolTip1.SetToolTip(this.EditThemeCommentaryBack, resources.GetString("EditThemeCommentaryBack.ToolTip"));
      this.EditThemeCommentaryBack.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
      // 
      // EditThemeCurrentControl
      // 
      resources.ApplyResources(this.EditThemeCurrentControl, "EditThemeCurrentControl");
      this.EditThemeCurrentControl.BackColor = System.Drawing.Color.AliceBlue;
      this.EditThemeCurrentControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditThemeCurrentControl.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeCurrentControl.Name = "EditThemeCurrentControl";
      this.toolTip1.SetToolTip(this.EditThemeCurrentControl, resources.GetString("EditThemeCurrentControl.ToolTip"));
      this.EditThemeCurrentControl.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
      // 
      // EditThemeSearchLettersBack
      // 
      resources.ApplyResources(this.EditThemeSearchLettersBack, "EditThemeSearchLettersBack");
      this.EditThemeSearchLettersBack.BackColor = System.Drawing.Color.LightYellow;
      this.EditThemeSearchLettersBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditThemeSearchLettersBack.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeSearchLettersBack.Name = "EditThemeSearchLettersBack";
      this.toolTip1.SetToolTip(this.EditThemeSearchLettersBack, resources.GetString("EditThemeSearchLettersBack.ToolTip"));
      this.EditThemeSearchLettersBack.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // EditThemeSearchWordBack
      // 
      resources.ApplyResources(this.EditThemeSearchWordBack, "EditThemeSearchWordBack");
      this.EditThemeSearchWordBack.BackColor = System.Drawing.Color.AliceBlue;
      this.EditThemeSearchWordBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditThemeSearchWordBack.ForeColor = System.Drawing.SystemColors.Control;
      this.EditThemeSearchWordBack.Name = "EditThemeSearchWordBack";
      this.toolTip1.SetToolTip(this.EditThemeSearchWordBack, resources.GetString("EditThemeSearchWordBack.ToolTip"));
      this.EditThemeSearchWordBack.Click += new System.EventHandler(this.EditColor_Click);
      // 
      // label6
      // 
      resources.ApplyResources(this.label6, "label6");
      this.label6.Name = "label6";
      this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
      // 
      // ActionUseColorsPastel
      // 
      resources.ApplyResources(this.ActionUseColorsPastel, "ActionUseColorsPastel");
      this.ActionUseColorsPastel.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      this.ActionUseColorsPastel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.ActionUseColorsPastel.LinkColor = System.Drawing.Color.Navy;
      this.ActionUseColorsPastel.Name = "ActionUseColorsPastel";
      this.ActionUseColorsPastel.TabStop = true;
      this.toolTip1.SetToolTip(this.ActionUseColorsPastel, resources.GetString("ActionUseColorsPastel.ToolTip"));
      this.ActionUseColorsPastel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ActionUseColorsPastel_LinkClicked);
      // 
      // ActionUseColorsSystem
      // 
      resources.ApplyResources(this.ActionUseColorsSystem, "ActionUseColorsSystem");
      this.ActionUseColorsSystem.ActiveLinkColor = System.Drawing.Color.MediumBlue;
      this.ActionUseColorsSystem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.ActionUseColorsSystem.LinkColor = System.Drawing.Color.Navy;
      this.ActionUseColorsSystem.Name = "ActionUseColorsSystem";
      this.ActionUseColorsSystem.TabStop = true;
      this.toolTip1.SetToolTip(this.ActionUseColorsSystem, resources.GetString("ActionUseColorsSystem.ToolTip"));
      this.ActionUseColorsSystem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ActionUseColorsSystem_LinkClicked);
      // 
      // TabPageRendering
      // 
      resources.ApplyResources(this.TabPageRendering, "TabPageRendering");
      this.TabPageRendering.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageRendering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageRendering.Controls.Add(this.LabelInfoSearchMinRefForDialog);
      this.TabPageRendering.Controls.Add(this.LabelInfoSearchDisplayMaxRef);
      this.TabPageRendering.Controls.Add(this.LabelFontSizeCommentaryInfo);
      this.TabPageRendering.Controls.Add(this.LabelFontSizeTranslationInfo);
      this.TabPageRendering.Controls.Add(this.LabelFontSizeHebrewInfo);
      this.TabPageRendering.Controls.Add(this.LabelInfoWordControlWidth);
      this.TabPageRendering.Controls.Add(this.LabelInfoWordtranslateLinesCount);
      this.TabPageRendering.Controls.Add(this.LabelInfoCommentLinesCount);
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
      this.TabPageRendering.Name = "TabPageRendering";
      this.toolTip1.SetToolTip(this.TabPageRendering, resources.GetString("TabPageRendering.ToolTip"));
      // 
      // LabelInfoSearchMinRefForDialog
      // 
      resources.ApplyResources(this.LabelInfoSearchMinRefForDialog, "LabelInfoSearchMinRefForDialog");
      this.LabelInfoSearchMinRefForDialog.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoSearchMinRefForDialog.Name = "LabelInfoSearchMinRefForDialog";
      this.toolTip1.SetToolTip(this.LabelInfoSearchMinRefForDialog, resources.GetString("LabelInfoSearchMinRefForDialog.ToolTip"));
      // 
      // LabelInfoSearchDisplayMaxRef
      // 
      resources.ApplyResources(this.LabelInfoSearchDisplayMaxRef, "LabelInfoSearchDisplayMaxRef");
      this.LabelInfoSearchDisplayMaxRef.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoSearchDisplayMaxRef.Name = "LabelInfoSearchDisplayMaxRef";
      this.toolTip1.SetToolTip(this.LabelInfoSearchDisplayMaxRef, resources.GetString("LabelInfoSearchDisplayMaxRef.ToolTip"));
      // 
      // LabelFontSizeCommentaryInfo
      // 
      resources.ApplyResources(this.LabelFontSizeCommentaryInfo, "LabelFontSizeCommentaryInfo");
      this.LabelFontSizeCommentaryInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelFontSizeCommentaryInfo.Name = "LabelFontSizeCommentaryInfo";
      this.toolTip1.SetToolTip(this.LabelFontSizeCommentaryInfo, resources.GetString("LabelFontSizeCommentaryInfo.ToolTip"));
      // 
      // LabelFontSizeTranslationInfo
      // 
      resources.ApplyResources(this.LabelFontSizeTranslationInfo, "LabelFontSizeTranslationInfo");
      this.LabelFontSizeTranslationInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelFontSizeTranslationInfo.Name = "LabelFontSizeTranslationInfo";
      this.toolTip1.SetToolTip(this.LabelFontSizeTranslationInfo, resources.GetString("LabelFontSizeTranslationInfo.ToolTip"));
      // 
      // LabelFontSizeHebrewInfo
      // 
      resources.ApplyResources(this.LabelFontSizeHebrewInfo, "LabelFontSizeHebrewInfo");
      this.LabelFontSizeHebrewInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelFontSizeHebrewInfo.Name = "LabelFontSizeHebrewInfo";
      this.toolTip1.SetToolTip(this.LabelFontSizeHebrewInfo, resources.GetString("LabelFontSizeHebrewInfo.ToolTip"));
      // 
      // LabelInfoWordControlWidth
      // 
      resources.ApplyResources(this.LabelInfoWordControlWidth, "LabelInfoWordControlWidth");
      this.LabelInfoWordControlWidth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoWordControlWidth.Name = "LabelInfoWordControlWidth";
      this.toolTip1.SetToolTip(this.LabelInfoWordControlWidth, resources.GetString("LabelInfoWordControlWidth.ToolTip"));
      // 
      // LabelInfoWordtranslateLinesCount
      // 
      resources.ApplyResources(this.LabelInfoWordtranslateLinesCount, "LabelInfoWordtranslateLinesCount");
      this.LabelInfoWordtranslateLinesCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoWordtranslateLinesCount.Name = "LabelInfoWordtranslateLinesCount";
      this.toolTip1.SetToolTip(this.LabelInfoWordtranslateLinesCount, resources.GetString("LabelInfoWordtranslateLinesCount.ToolTip"));
      // 
      // LabelInfoCommentLinesCount
      // 
      resources.ApplyResources(this.LabelInfoCommentLinesCount, "LabelInfoCommentLinesCount");
      this.LabelInfoCommentLinesCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoCommentLinesCount.Name = "LabelInfoCommentLinesCount";
      this.toolTip1.SetToolTip(this.LabelInfoCommentLinesCount, resources.GetString("LabelInfoCommentLinesCount.ToolTip"));
      // 
      // EditFontSizeCommentary
      // 
      resources.ApplyResources(this.EditFontSizeCommentary, "EditFontSizeCommentary");
      this.EditFontSizeCommentary.BackColor = System.Drawing.SystemColors.Window;
      this.EditFontSizeCommentary.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.EditFontSizeCommentary.Name = "EditFontSizeCommentary";
      this.EditFontSizeCommentary.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditFontSizeCommentary, resources.GetString("EditFontSizeCommentary.ToolTip"));
      this.EditFontSizeCommentary.ValueChanged += new System.EventHandler(this.EditRenderVerseControl_ValueChanged);
      // 
      // EditFontSizeTranslation
      // 
      resources.ApplyResources(this.EditFontSizeTranslation, "EditFontSizeTranslation");
      this.EditFontSizeTranslation.BackColor = System.Drawing.SystemColors.Window;
      this.EditFontSizeTranslation.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.EditFontSizeTranslation.Name = "EditFontSizeTranslation";
      this.EditFontSizeTranslation.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditFontSizeTranslation, resources.GetString("EditFontSizeTranslation.ToolTip"));
      this.EditFontSizeTranslation.ValueChanged += new System.EventHandler(this.EditRenderWordControl_ValueChanged);
      // 
      // EditFontSizeHebrew
      // 
      resources.ApplyResources(this.EditFontSizeHebrew, "EditFontSizeHebrew");
      this.EditFontSizeHebrew.BackColor = System.Drawing.SystemColors.Window;
      this.EditFontSizeHebrew.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.EditFontSizeHebrew.Name = "EditFontSizeHebrew";
      this.EditFontSizeHebrew.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditFontSizeHebrew, resources.GetString("EditFontSizeHebrew.ToolTip"));
      this.EditFontSizeHebrew.ValueChanged += new System.EventHandler(this.EditRenderWordControl_ValueChanged);
      // 
      // EditWordControlWidth
      // 
      resources.ApplyResources(this.EditWordControlWidth, "EditWordControlWidth");
      this.EditWordControlWidth.BackColor = System.Drawing.SystemColors.Window;
      this.EditWordControlWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.EditWordControlWidth.Name = "EditWordControlWidth";
      this.EditWordControlWidth.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditWordControlWidth, resources.GetString("EditWordControlWidth.ToolTip"));
      // 
      // EditSearchMinRefForDialog
      // 
      resources.ApplyResources(this.EditSearchMinRefForDialog, "EditSearchMinRefForDialog");
      this.EditSearchMinRefForDialog.BackColor = System.Drawing.SystemColors.Window;
      this.EditSearchMinRefForDialog.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.EditSearchMinRefForDialog.Name = "EditSearchMinRefForDialog";
      this.EditSearchMinRefForDialog.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditSearchMinRefForDialog, resources.GetString("EditSearchMinRefForDialog.ToolTip"));
      // 
      // EditSearchDisplayMaxRef
      // 
      resources.ApplyResources(this.EditSearchDisplayMaxRef, "EditSearchDisplayMaxRef");
      this.EditSearchDisplayMaxRef.BackColor = System.Drawing.SystemColors.Window;
      this.EditSearchDisplayMaxRef.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.EditSearchDisplayMaxRef.Name = "EditSearchDisplayMaxRef";
      this.EditSearchDisplayMaxRef.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditSearchDisplayMaxRef, resources.GetString("EditSearchDisplayMaxRef.ToolTip"));
      this.EditSearchDisplayMaxRef.ValueChanged += new System.EventHandler(this.EditMaxRefCount_ValueChanged);
      // 
      // EditWordTranslateLinesCount
      // 
      resources.ApplyResources(this.EditWordTranslateLinesCount, "EditWordTranslateLinesCount");
      this.EditWordTranslateLinesCount.BackColor = System.Drawing.SystemColors.Window;
      this.EditWordTranslateLinesCount.Name = "EditWordTranslateLinesCount";
      this.EditWordTranslateLinesCount.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditWordTranslateLinesCount, resources.GetString("EditWordTranslateLinesCount.ToolTip"));
      this.EditWordTranslateLinesCount.ValueChanged += new System.EventHandler(this.EditRenderWordControl_ValueChanged);
      // 
      // EditCommentaryLinesCount
      // 
      resources.ApplyResources(this.EditCommentaryLinesCount, "EditCommentaryLinesCount");
      this.EditCommentaryLinesCount.BackColor = System.Drawing.SystemColors.Window;
      this.EditCommentaryLinesCount.Name = "EditCommentaryLinesCount";
      this.EditCommentaryLinesCount.ReadOnly = true;
      this.toolTip1.SetToolTip(this.EditCommentaryLinesCount, resources.GetString("EditCommentaryLinesCount.ToolTip"));
      this.EditCommentaryLinesCount.ValueChanged += new System.EventHandler(this.EditRenderVerseControl_ValueChanged);
      // 
      // TabPageTools
      // 
      resources.ApplyResources(this.TabPageTools, "TabPageTools");
      this.TabPageTools.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageTools.Controls.Add(this.GroupBoxHebrewWordClickShift);
      this.TabPageTools.Controls.Add(this.GroupBoxHebrewWordClickAlt);
      this.TabPageTools.Controls.Add(this.GroupBoxVerseLabelClick);
      this.TabPageTools.Controls.Add(this.GroupBoxTranslatedItemDoubleClick);
      this.TabPageTools.Controls.Add(this.GroupBoxHebrewWordClickCtrl);
      this.TabPageTools.Controls.Add(this.GroupBoxHebrewWordClick);
      this.TabPageTools.Controls.Add(this.ActionOnlineSearchHelp);
      this.TabPageTools.Controls.Add(this.ActionOnlineVerseHelp);
      this.TabPageTools.Controls.Add(this.ActionSelectOnlineSearch);
      this.TabPageTools.Controls.Add(this.ActionSelectOnlineVerseURL);
      this.TabPageTools.Controls.Add(LabelOnlineVerseURL);
      this.TabPageTools.Controls.Add(this.EditOnlineVerseURL);
      this.TabPageTools.Controls.Add(LabelOnlineSearch);
      this.TabPageTools.Controls.Add(this.EditOnlineSearch);
      this.TabPageTools.Name = "TabPageTools";
      this.toolTip1.SetToolTip(this.TabPageTools, resources.GetString("TabPageTools.ToolTip"));
      // 
      // GroupBoxHebrewWordClickShift
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift, "GroupBoxHebrewWordClickShift");
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift5);
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift0);
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift1);
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift3);
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift2);
      this.GroupBoxHebrewWordClickShift.Controls.Add(this.GroupBoxHebrewWordClickShift4);
      this.GroupBoxHebrewWordClickShift.Name = "GroupBoxHebrewWordClickShift";
      this.GroupBoxHebrewWordClickShift.TabStop = false;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShift, resources.GetString("GroupBoxHebrewWordClickShift.ToolTip"));
      // 
      // GroupBoxHebrewWordClickShift5
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift5, "GroupBoxHebrewWordClickShift5");
      this.GroupBoxHebrewWordClickShift5.Name = "GroupBoxHebrewWordClickShift5";
      this.GroupBoxHebrewWordClickShift5.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShift5, resources.GetString("GroupBoxHebrewWordClickShift5.ToolTip"));
      this.GroupBoxHebrewWordClickShift5.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShift0
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift0, "GroupBoxHebrewWordClickShift0");
      this.GroupBoxHebrewWordClickShift0.Name = "GroupBoxHebrewWordClickShift0";
      this.GroupBoxHebrewWordClickShift0.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShift0, resources.GetString("GroupBoxHebrewWordClickShift0.ToolTip"));
      this.GroupBoxHebrewWordClickShift0.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShift1
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift1, "GroupBoxHebrewWordClickShift1");
      this.GroupBoxHebrewWordClickShift1.Name = "GroupBoxHebrewWordClickShift1";
      this.GroupBoxHebrewWordClickShift1.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShift1, resources.GetString("GroupBoxHebrewWordClickShift1.ToolTip"));
      this.GroupBoxHebrewWordClickShift1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShift3
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift3, "GroupBoxHebrewWordClickShift3");
      this.GroupBoxHebrewWordClickShift3.Name = "GroupBoxHebrewWordClickShift3";
      this.GroupBoxHebrewWordClickShift3.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShift3, resources.GetString("GroupBoxHebrewWordClickShift3.ToolTip"));
      this.GroupBoxHebrewWordClickShift3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShift2
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift2, "GroupBoxHebrewWordClickShift2");
      this.GroupBoxHebrewWordClickShift2.Name = "GroupBoxHebrewWordClickShift2";
      this.GroupBoxHebrewWordClickShift2.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShift2, resources.GetString("GroupBoxHebrewWordClickShift2.ToolTip"));
      this.GroupBoxHebrewWordClickShift2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShift4
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShift4, "GroupBoxHebrewWordClickShift4");
      this.GroupBoxHebrewWordClickShift4.Name = "GroupBoxHebrewWordClickShift4";
      this.GroupBoxHebrewWordClickShift4.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShift4, resources.GetString("GroupBoxHebrewWordClickShift4.ToolTip"));
      this.GroupBoxHebrewWordClickShift4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickAlt
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickAlt, "GroupBoxHebrewWordClickAlt");
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl5);
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl0);
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl1);
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl3);
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl2);
      this.GroupBoxHebrewWordClickAlt.Controls.Add(this.GroupBoxHebrewWordClickShiftCtrl4);
      this.GroupBoxHebrewWordClickAlt.Name = "GroupBoxHebrewWordClickAlt";
      this.GroupBoxHebrewWordClickAlt.TabStop = false;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickAlt, resources.GetString("GroupBoxHebrewWordClickAlt.ToolTip"));
      // 
      // GroupBoxHebrewWordClickShiftCtrl5
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl5, "GroupBoxHebrewWordClickShiftCtrl5");
      this.GroupBoxHebrewWordClickShiftCtrl5.Name = "GroupBoxHebrewWordClickShiftCtrl5";
      this.GroupBoxHebrewWordClickShiftCtrl5.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShiftCtrl5, resources.GetString("GroupBoxHebrewWordClickShiftCtrl5.ToolTip"));
      this.GroupBoxHebrewWordClickShiftCtrl5.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShiftCtrl0
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl0, "GroupBoxHebrewWordClickShiftCtrl0");
      this.GroupBoxHebrewWordClickShiftCtrl0.Name = "GroupBoxHebrewWordClickShiftCtrl0";
      this.GroupBoxHebrewWordClickShiftCtrl0.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShiftCtrl0, resources.GetString("GroupBoxHebrewWordClickShiftCtrl0.ToolTip"));
      this.GroupBoxHebrewWordClickShiftCtrl0.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShiftCtrl1
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl1, "GroupBoxHebrewWordClickShiftCtrl1");
      this.GroupBoxHebrewWordClickShiftCtrl1.Name = "GroupBoxHebrewWordClickShiftCtrl1";
      this.GroupBoxHebrewWordClickShiftCtrl1.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShiftCtrl1, resources.GetString("GroupBoxHebrewWordClickShiftCtrl1.ToolTip"));
      this.GroupBoxHebrewWordClickShiftCtrl1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShiftCtrl3
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl3, "GroupBoxHebrewWordClickShiftCtrl3");
      this.GroupBoxHebrewWordClickShiftCtrl3.Name = "GroupBoxHebrewWordClickShiftCtrl3";
      this.GroupBoxHebrewWordClickShiftCtrl3.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShiftCtrl3, resources.GetString("GroupBoxHebrewWordClickShiftCtrl3.ToolTip"));
      this.GroupBoxHebrewWordClickShiftCtrl3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShiftCtrl2
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl2, "GroupBoxHebrewWordClickShiftCtrl2");
      this.GroupBoxHebrewWordClickShiftCtrl2.Name = "GroupBoxHebrewWordClickShiftCtrl2";
      this.GroupBoxHebrewWordClickShiftCtrl2.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShiftCtrl2, resources.GetString("GroupBoxHebrewWordClickShiftCtrl2.ToolTip"));
      this.GroupBoxHebrewWordClickShiftCtrl2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickShiftCtrl4
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickShiftCtrl4, "GroupBoxHebrewWordClickShiftCtrl4");
      this.GroupBoxHebrewWordClickShiftCtrl4.Name = "GroupBoxHebrewWordClickShiftCtrl4";
      this.GroupBoxHebrewWordClickShiftCtrl4.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickShiftCtrl4, resources.GetString("GroupBoxHebrewWordClickShiftCtrl4.ToolTip"));
      this.GroupBoxHebrewWordClickShiftCtrl4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxVerseLabelClick
      // 
      resources.ApplyResources(this.GroupBoxVerseLabelClick, "GroupBoxVerseLabelClick");
      this.GroupBoxVerseLabelClick.Controls.Add(this.GroupBoxVerseLabelClick4);
      this.GroupBoxVerseLabelClick.Controls.Add(this.GroupBoxVerseLabelClick1);
      this.GroupBoxVerseLabelClick.Controls.Add(this.GroupBoxVerseLabelClick2);
      this.GroupBoxVerseLabelClick.Controls.Add(this.GroupBoxVerseLabelClick3);
      this.GroupBoxVerseLabelClick.Name = "GroupBoxVerseLabelClick";
      this.GroupBoxVerseLabelClick.TabStop = false;
      this.toolTip1.SetToolTip(this.GroupBoxVerseLabelClick, resources.GetString("GroupBoxVerseLabelClick.ToolTip"));
      // 
      // GroupBoxVerseLabelClick4
      // 
      resources.ApplyResources(this.GroupBoxVerseLabelClick4, "GroupBoxVerseLabelClick4");
      this.GroupBoxVerseLabelClick4.Name = "GroupBoxVerseLabelClick4";
      this.GroupBoxVerseLabelClick4.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxVerseLabelClick4, resources.GetString("GroupBoxVerseLabelClick4.ToolTip"));
      this.GroupBoxVerseLabelClick4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxVerseLabelClick1
      // 
      resources.ApplyResources(this.GroupBoxVerseLabelClick1, "GroupBoxVerseLabelClick1");
      this.GroupBoxVerseLabelClick1.Name = "GroupBoxVerseLabelClick1";
      this.GroupBoxVerseLabelClick1.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxVerseLabelClick1, resources.GetString("GroupBoxVerseLabelClick1.ToolTip"));
      this.GroupBoxVerseLabelClick1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxVerseLabelClick2
      // 
      resources.ApplyResources(this.GroupBoxVerseLabelClick2, "GroupBoxVerseLabelClick2");
      this.GroupBoxVerseLabelClick2.Name = "GroupBoxVerseLabelClick2";
      this.GroupBoxVerseLabelClick2.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxVerseLabelClick2, resources.GetString("GroupBoxVerseLabelClick2.ToolTip"));
      this.GroupBoxVerseLabelClick2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxVerseLabelClick3
      // 
      resources.ApplyResources(this.GroupBoxVerseLabelClick3, "GroupBoxVerseLabelClick3");
      this.GroupBoxVerseLabelClick3.Name = "GroupBoxVerseLabelClick3";
      this.GroupBoxVerseLabelClick3.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxVerseLabelClick3, resources.GetString("GroupBoxVerseLabelClick3.ToolTip"));
      this.GroupBoxVerseLabelClick3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxTranslatedItemDoubleClick
      // 
      resources.ApplyResources(this.GroupBoxTranslatedItemDoubleClick, "GroupBoxTranslatedItemDoubleClick");
      this.GroupBoxTranslatedItemDoubleClick.Controls.Add(this.GroupBoxTranslatedItemDoubleClick4);
      this.GroupBoxTranslatedItemDoubleClick.Controls.Add(this.GroupBoxTranslatedItemDoubleClick1);
      this.GroupBoxTranslatedItemDoubleClick.Controls.Add(this.GroupBoxTranslatedItemDoubleClick2);
      this.GroupBoxTranslatedItemDoubleClick.Controls.Add(this.GroupBoxTranslatedItemDoubleClick3);
      this.GroupBoxTranslatedItemDoubleClick.Name = "GroupBoxTranslatedItemDoubleClick";
      this.GroupBoxTranslatedItemDoubleClick.TabStop = false;
      this.toolTip1.SetToolTip(this.GroupBoxTranslatedItemDoubleClick, resources.GetString("GroupBoxTranslatedItemDoubleClick.ToolTip"));
      // 
      // GroupBoxTranslatedItemDoubleClick4
      // 
      resources.ApplyResources(this.GroupBoxTranslatedItemDoubleClick4, "GroupBoxTranslatedItemDoubleClick4");
      this.GroupBoxTranslatedItemDoubleClick4.Name = "GroupBoxTranslatedItemDoubleClick4";
      this.GroupBoxTranslatedItemDoubleClick4.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxTranslatedItemDoubleClick4, resources.GetString("GroupBoxTranslatedItemDoubleClick4.ToolTip"));
      this.GroupBoxTranslatedItemDoubleClick4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxTranslatedItemDoubleClick1
      // 
      resources.ApplyResources(this.GroupBoxTranslatedItemDoubleClick1, "GroupBoxTranslatedItemDoubleClick1");
      this.GroupBoxTranslatedItemDoubleClick1.Name = "GroupBoxTranslatedItemDoubleClick1";
      this.GroupBoxTranslatedItemDoubleClick1.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxTranslatedItemDoubleClick1, resources.GetString("GroupBoxTranslatedItemDoubleClick1.ToolTip"));
      this.GroupBoxTranslatedItemDoubleClick1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxTranslatedItemDoubleClick2
      // 
      resources.ApplyResources(this.GroupBoxTranslatedItemDoubleClick2, "GroupBoxTranslatedItemDoubleClick2");
      this.GroupBoxTranslatedItemDoubleClick2.Name = "GroupBoxTranslatedItemDoubleClick2";
      this.GroupBoxTranslatedItemDoubleClick2.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxTranslatedItemDoubleClick2, resources.GetString("GroupBoxTranslatedItemDoubleClick2.ToolTip"));
      this.GroupBoxTranslatedItemDoubleClick2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxTranslatedItemDoubleClick3
      // 
      resources.ApplyResources(this.GroupBoxTranslatedItemDoubleClick3, "GroupBoxTranslatedItemDoubleClick3");
      this.GroupBoxTranslatedItemDoubleClick3.Name = "GroupBoxTranslatedItemDoubleClick3";
      this.GroupBoxTranslatedItemDoubleClick3.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxTranslatedItemDoubleClick3, resources.GetString("GroupBoxTranslatedItemDoubleClick3.ToolTip"));
      this.GroupBoxTranslatedItemDoubleClick3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl, "GroupBoxHebrewWordClickCtrl");
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl5);
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl0);
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl1);
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl3);
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl2);
      this.GroupBoxHebrewWordClickCtrl.Controls.Add(this.GroupBoxHebrewWordClickCtrl4);
      this.GroupBoxHebrewWordClickCtrl.Name = "GroupBoxHebrewWordClickCtrl";
      this.GroupBoxHebrewWordClickCtrl.TabStop = false;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickCtrl, resources.GetString("GroupBoxHebrewWordClickCtrl.ToolTip"));
      // 
      // GroupBoxHebrewWordClickCtrl5
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl5, "GroupBoxHebrewWordClickCtrl5");
      this.GroupBoxHebrewWordClickCtrl5.Name = "GroupBoxHebrewWordClickCtrl5";
      this.GroupBoxHebrewWordClickCtrl5.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickCtrl5, resources.GetString("GroupBoxHebrewWordClickCtrl5.ToolTip"));
      this.GroupBoxHebrewWordClickCtrl5.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl0
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl0, "GroupBoxHebrewWordClickCtrl0");
      this.GroupBoxHebrewWordClickCtrl0.Name = "GroupBoxHebrewWordClickCtrl0";
      this.GroupBoxHebrewWordClickCtrl0.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickCtrl0, resources.GetString("GroupBoxHebrewWordClickCtrl0.ToolTip"));
      this.GroupBoxHebrewWordClickCtrl0.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl1
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl1, "GroupBoxHebrewWordClickCtrl1");
      this.GroupBoxHebrewWordClickCtrl1.Name = "GroupBoxHebrewWordClickCtrl1";
      this.GroupBoxHebrewWordClickCtrl1.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickCtrl1, resources.GetString("GroupBoxHebrewWordClickCtrl1.ToolTip"));
      this.GroupBoxHebrewWordClickCtrl1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl3
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl3, "GroupBoxHebrewWordClickCtrl3");
      this.GroupBoxHebrewWordClickCtrl3.Name = "GroupBoxHebrewWordClickCtrl3";
      this.GroupBoxHebrewWordClickCtrl3.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickCtrl3, resources.GetString("GroupBoxHebrewWordClickCtrl3.ToolTip"));
      this.GroupBoxHebrewWordClickCtrl3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl2
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl2, "GroupBoxHebrewWordClickCtrl2");
      this.GroupBoxHebrewWordClickCtrl2.Name = "GroupBoxHebrewWordClickCtrl2";
      this.GroupBoxHebrewWordClickCtrl2.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickCtrl2, resources.GetString("GroupBoxHebrewWordClickCtrl2.ToolTip"));
      this.GroupBoxHebrewWordClickCtrl2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClickCtrl4
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClickCtrl4, "GroupBoxHebrewWordClickCtrl4");
      this.GroupBoxHebrewWordClickCtrl4.Name = "GroupBoxHebrewWordClickCtrl4";
      this.GroupBoxHebrewWordClickCtrl4.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClickCtrl4, resources.GetString("GroupBoxHebrewWordClickCtrl4.ToolTip"));
      this.GroupBoxHebrewWordClickCtrl4.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick, "GroupBoxHebrewWordClick");
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick5);
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick0);
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick1);
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick3);
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick2);
      this.GroupBoxHebrewWordClick.Controls.Add(this.GroupBoxHebrewWordClick4);
      this.GroupBoxHebrewWordClick.Name = "GroupBoxHebrewWordClick";
      this.GroupBoxHebrewWordClick.TabStop = false;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClick, resources.GetString("GroupBoxHebrewWordClick.ToolTip"));
      // 
      // GroupBoxHebrewWordClick5
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick5, "GroupBoxHebrewWordClick5");
      this.GroupBoxHebrewWordClick5.Name = "GroupBoxHebrewWordClick5";
      this.GroupBoxHebrewWordClick5.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClick5, resources.GetString("GroupBoxHebrewWordClick5.ToolTip"));
      this.GroupBoxHebrewWordClick5.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick0
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick0, "GroupBoxHebrewWordClick0");
      this.GroupBoxHebrewWordClick0.Name = "GroupBoxHebrewWordClick0";
      this.GroupBoxHebrewWordClick0.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClick0, resources.GetString("GroupBoxHebrewWordClick0.ToolTip"));
      this.GroupBoxHebrewWordClick0.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick1
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick1, "GroupBoxHebrewWordClick1");
      this.GroupBoxHebrewWordClick1.Name = "GroupBoxHebrewWordClick1";
      this.GroupBoxHebrewWordClick1.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClick1, resources.GetString("GroupBoxHebrewWordClick1.ToolTip"));
      this.GroupBoxHebrewWordClick1.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick3
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick3, "GroupBoxHebrewWordClick3");
      this.GroupBoxHebrewWordClick3.Name = "GroupBoxHebrewWordClick3";
      this.GroupBoxHebrewWordClick3.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClick3, resources.GetString("GroupBoxHebrewWordClick3.ToolTip"));
      this.GroupBoxHebrewWordClick3.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick2
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick2, "GroupBoxHebrewWordClick2");
      this.GroupBoxHebrewWordClick2.Name = "GroupBoxHebrewWordClick2";
      this.GroupBoxHebrewWordClick2.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClick2, resources.GetString("GroupBoxHebrewWordClick2.ToolTip"));
      this.GroupBoxHebrewWordClick2.UseVisualStyleBackColor = true;
      // 
      // GroupBoxHebrewWordClick4
      // 
      resources.ApplyResources(this.GroupBoxHebrewWordClick4, "GroupBoxHebrewWordClick4");
      this.GroupBoxHebrewWordClick4.Name = "GroupBoxHebrewWordClick4";
      this.GroupBoxHebrewWordClick4.TabStop = true;
      this.toolTip1.SetToolTip(this.GroupBoxHebrewWordClick4, resources.GetString("GroupBoxHebrewWordClick4.ToolTip"));
      this.GroupBoxHebrewWordClick4.UseVisualStyleBackColor = true;
      // 
      // ActionOnlineSearchHelp
      // 
      resources.ApplyResources(this.ActionOnlineSearchHelp, "ActionOnlineSearchHelp");
      this.ActionOnlineSearchHelp.AllowDrop = true;
      this.ActionOnlineSearchHelp.FlatAppearance.BorderSize = 0;
      this.ActionOnlineSearchHelp.Name = "ActionOnlineSearchHelp";
      this.toolTip1.SetToolTip(this.ActionOnlineSearchHelp, resources.GetString("ActionOnlineSearchHelp.ToolTip"));
      this.ActionOnlineSearchHelp.UseVisualStyleBackColor = true;
      this.ActionOnlineSearchHelp.Click += new System.EventHandler(this.ActionOnlineSearchHelp_Click);
      // 
      // ActionOnlineVerseHelp
      // 
      resources.ApplyResources(this.ActionOnlineVerseHelp, "ActionOnlineVerseHelp");
      this.ActionOnlineVerseHelp.AllowDrop = true;
      this.ActionOnlineVerseHelp.FlatAppearance.BorderSize = 0;
      this.ActionOnlineVerseHelp.Name = "ActionOnlineVerseHelp";
      this.toolTip1.SetToolTip(this.ActionOnlineVerseHelp, resources.GetString("ActionOnlineVerseHelp.ToolTip"));
      this.ActionOnlineVerseHelp.UseVisualStyleBackColor = true;
      this.ActionOnlineVerseHelp.Click += new System.EventHandler(this.ActionOnlineVerseHelp_Click);
      // 
      // ActionSelectOnlineSearch
      // 
      resources.ApplyResources(this.ActionSelectOnlineSearch, "ActionSelectOnlineSearch");
      this.ActionSelectOnlineSearch.AllowDrop = true;
      this.ActionSelectOnlineSearch.FlatAppearance.BorderSize = 0;
      this.ActionSelectOnlineSearch.Name = "ActionSelectOnlineSearch";
      this.toolTip1.SetToolTip(this.ActionSelectOnlineSearch, resources.GetString("ActionSelectOnlineSearch.ToolTip"));
      this.ActionSelectOnlineSearch.UseVisualStyleBackColor = true;
      this.ActionSelectOnlineSearch.Click += new System.EventHandler(this.ActionSelectOnlineSearch_Click);
      // 
      // ActionSelectOnlineVerseURL
      // 
      resources.ApplyResources(this.ActionSelectOnlineVerseURL, "ActionSelectOnlineVerseURL");
      this.ActionSelectOnlineVerseURL.AllowDrop = true;
      this.ActionSelectOnlineVerseURL.FlatAppearance.BorderSize = 0;
      this.ActionSelectOnlineVerseURL.Name = "ActionSelectOnlineVerseURL";
      this.toolTip1.SetToolTip(this.ActionSelectOnlineVerseURL, resources.GetString("ActionSelectOnlineVerseURL.ToolTip"));
      this.ActionSelectOnlineVerseURL.UseVisualStyleBackColor = true;
      this.ActionSelectOnlineVerseURL.Click += new System.EventHandler(this.ActionSelectOnlineVerseURL_Click);
      // 
      // EditOnlineVerseURL
      // 
      resources.ApplyResources(this.EditOnlineVerseURL, "EditOnlineVerseURL");
      this.EditOnlineVerseURL.Name = "EditOnlineVerseURL";
      this.toolTip1.SetToolTip(this.EditOnlineVerseURL, resources.GetString("EditOnlineVerseURL.ToolTip"));
      // 
      // EditOnlineSearch
      // 
      resources.ApplyResources(this.EditOnlineSearch, "EditOnlineSearch");
      this.EditOnlineSearch.Name = "EditOnlineSearch";
      this.toolTip1.SetToolTip(this.EditOnlineSearch, resources.GetString("EditOnlineSearch.ToolTip"));
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
      resources.ApplyResources(this.MenuSelectSearchRequest, "MenuSelectSearchRequest");
      this.MenuSelectSearchRequest.Name = "MenuSelectOnlineVerseURL";
      this.toolTip1.SetToolTip(this.MenuSelectSearchRequest, resources.GetString("MenuSelectSearchRequest.ToolTip"));
      // 
      // MenuSelectOnlineVerseURL
      // 
      resources.ApplyResources(this.MenuSelectOnlineVerseURL, "MenuSelectOnlineVerseURL");
      this.MenuSelectOnlineVerseURL.Name = "MenuSelectOnlineVerseURL";
      this.toolTip1.SetToolTip(this.MenuSelectOnlineVerseURL, resources.GetString("MenuSelectOnlineVerseURL.ToolTip"));
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
      this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
      ((System.ComponentModel.ISupportInitialize)(this.EditCheckUpdateAtStartupInterval)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditVacuumAtStartupInterval)).EndInit();
      this.TabPageApplication.ResumeLayout(false);
      this.TabPageApplication.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoSaveDelay)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoBackupCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditVolume)).EndInit();
      this.TabControl.ResumeLayout(false);
      this.TabPageBookmarks.ResumeLayout(false);
      this.TabPageBookmarks.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditHistoryCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditBookmarksCount)).EndInit();
      this.TabPageTheme.ResumeLayout(false);
      this.TabPageTheme.PerformLayout();
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
      this.TabPageTools.ResumeLayout(false);
      this.TabPageTools.PerformLayout();
      this.GroupBoxHebrewWordClickShift.ResumeLayout(false);
      this.GroupBoxHebrewWordClickShift.PerformLayout();
      this.GroupBoxHebrewWordClickAlt.ResumeLayout(false);
      this.GroupBoxHebrewWordClickAlt.PerformLayout();
      this.GroupBoxVerseLabelClick.ResumeLayout(false);
      this.GroupBoxVerseLabelClick.PerformLayout();
      this.GroupBoxTranslatedItemDoubleClick.ResumeLayout(false);
      this.GroupBoxTranslatedItemDoubleClick.PerformLayout();
      this.GroupBoxHebrewWordClickCtrl.ResumeLayout(false);
      this.GroupBoxHebrewWordClickCtrl.PerformLayout();
      this.GroupBoxHebrewWordClick.ResumeLayout(false);
      this.GroupBoxHebrewWordClick.PerformLayout();
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
    private ComboBox EditImageExportFileFormat;
    private ComboBox EditDataExportFileFormat;
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
    private TextBox EditOnlineVerseURL;
    private TextBox EditOnlineSearch;
    private CheckBox EditGoToMasterBookmarkAtStartup;
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
    private Label LabelInfoCommentLinesCount;
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
    private Label LabelInfoWordtranslateLinesCount;
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
    private ToolTip toolTip1;
    private CheckBox EditBookNameHebrewWithCommonName;
    private CheckBox EditCommentLineAddPrefix;
    private TextBox EditCommentLinePrefix;
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
  }
}
