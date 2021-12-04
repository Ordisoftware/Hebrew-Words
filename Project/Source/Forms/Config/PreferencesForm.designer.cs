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
      this.EditAutoSortBookmarks = new System.Windows.Forms.CheckBox();
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
      this.EditWebLinksMenuEnabled = new System.Windows.Forms.CheckBox();
      this.EditDebuggerEnabled = new System.Windows.Forms.CheckBox();
      this.EditUsageStatisticsEnabled = new System.Windows.Forms.CheckBox();
      this.EditLogEnabled = new System.Windows.Forms.CheckBox();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.TabPageRendering = new System.Windows.Forms.TabPage();
      this.LabelInfoSearchMinRefForDialog = new System.Windows.Forms.Label();
      this.LabelInfoSearchDisplayMaxRef = new System.Windows.Forms.Label();
      this.LabelInfoHistoryCount = new System.Windows.Forms.Label();
      this.LabelInfoBookmarksCount = new System.Windows.Forms.Label();
      this.LabelInfoWordControlWidth = new System.Windows.Forms.Label();
      this.LabelInfoCommentLinesCount = new System.Windows.Forms.Label();
      this.EditWordControlWidth = new System.Windows.Forms.NumericUpDown();
      this.EditSearchMinRefForDialog = new System.Windows.Forms.NumericUpDown();
      this.EditSearchDisplayMaxRef = new System.Windows.Forms.NumericUpDown();
      this.EditHistoryCount = new System.Windows.Forms.NumericUpDown();
      this.EditBookmarksCount = new System.Windows.Forms.NumericUpDown();
      this.EditCommentLinesCount = new System.Windows.Forms.NumericUpDown();
      this.TabPageTools = new System.Windows.Forms.TabPage();
      this.GroupBoxHebrewWordClick = new System.Windows.Forms.GroupBox();
      this.SelectOpenNothing = new System.Windows.Forms.RadioButton();
      this.SelectOpenOnlineSearch = new System.Windows.Forms.RadioButton();
      this.SelectOpenTranslated = new System.Windows.Forms.RadioButton();
      this.SelectOpenHebrewLetters = new System.Windows.Forms.RadioButton();
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
      this.TabPageRendering.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditWordControlWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditSearchMinRefForDialog)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditSearchDisplayMaxRef)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditHistoryCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditBookmarksCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditCommentLinesCount)).BeginInit();
      this.TabPageTools.SuspendLayout();
      this.GroupBoxHebrewWordClick.SuspendLayout();
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
      resources.ApplyResources(this.TabPagePaths, "TabPagePaths");
      this.TabPagePaths.Name = "TabPagePaths";
      // 
      // EditImageExportFileFormat
      // 
      this.EditImageExportFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.EditImageExportFileFormat.FormattingEnabled = true;
      resources.ApplyResources(this.EditImageExportFileFormat, "EditImageExportFileFormat");
      this.EditImageExportFileFormat.Name = "EditImageExportFileFormat";
      this.EditImageExportFileFormat.SelectedIndexChanged += new System.EventHandler(this.EditImageExportFileFormat_SelectedIndexChanged);
      this.EditImageExportFileFormat.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.EditImageExportFileFormat_Format);
      // 
      // LabelExportFolder
      // 
      resources.ApplyResources(this.LabelExportFolder, "LabelExportFolder");
      this.LabelExportFolder.Name = "LabelExportFolder";
      // 
      // ActionResetExportFolder
      // 
      this.ActionResetExportFolder.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionResetExportFolder, "ActionResetExportFolder");
      this.ActionResetExportFolder.Name = "ActionResetExportFolder";
      this.ActionResetExportFolder.UseVisualStyleBackColor = true;
      this.ActionResetExportFolder.Click += new System.EventHandler(this.ActionResetExportFolder_Click);
      // 
      // LabelDataExportFileFormat
      // 
      resources.ApplyResources(this.LabelDataExportFileFormat, "LabelDataExportFileFormat");
      this.LabelDataExportFileFormat.Name = "LabelDataExportFileFormat";
      // 
      // EditDataExportFileFormat
      // 
      this.EditDataExportFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.EditDataExportFileFormat.FormattingEnabled = true;
      resources.ApplyResources(this.EditDataExportFileFormat, "EditDataExportFileFormat");
      this.EditDataExportFileFormat.Name = "EditDataExportFileFormat";
      this.EditDataExportFileFormat.SelectedIndexChanged += new System.EventHandler(this.EditDataExportFileFormat_SelectedIndexChanged);
      this.EditDataExportFileFormat.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.EditDataExportFileFormat_Format);
      // 
      // ActionSelectExportFolder
      // 
      this.ActionSelectExportFolder.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionSelectExportFolder, "ActionSelectExportFolder");
      this.ActionSelectExportFolder.Name = "ActionSelectExportFolder";
      this.ActionSelectExportFolder.UseVisualStyleBackColor = true;
      this.ActionSelectExportFolder.Click += new System.EventHandler(this.ActionSelectExportFolder_Click);
      // 
      // LabelImageExportFileFormat
      // 
      resources.ApplyResources(this.LabelImageExportFileFormat, "LabelImageExportFileFormat");
      this.LabelImageExportFileFormat.Name = "LabelImageExportFileFormat";
      // 
      // LabelCalculatorPath
      // 
      resources.ApplyResources(this.LabelCalculatorPath, "LabelCalculatorPath");
      this.LabelCalculatorPath.Name = "LabelCalculatorPath";
      // 
      // ActionResetBackupFolder
      // 
      this.ActionResetBackupFolder.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionResetBackupFolder, "ActionResetBackupFolder");
      this.ActionResetBackupFolder.Name = "ActionResetBackupFolder";
      this.ActionResetBackupFolder.UseVisualStyleBackColor = true;
      this.ActionResetBackupFolder.Click += new System.EventHandler(this.ActionResetBackupFolder_Click);
      // 
      // ActionResetHebrewLettersPath
      // 
      this.ActionResetHebrewLettersPath.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionResetHebrewLettersPath, "ActionResetHebrewLettersPath");
      this.ActionResetHebrewLettersPath.Name = "ActionResetHebrewLettersPath";
      this.ActionResetHebrewLettersPath.UseVisualStyleBackColor = true;
      this.ActionResetHebrewLettersPath.Click += new System.EventHandler(this.ActionResetHebrewLettersPath_Click);
      // 
      // ActionResetCalculatorPath
      // 
      this.ActionResetCalculatorPath.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionResetCalculatorPath, "ActionResetCalculatorPath");
      this.ActionResetCalculatorPath.Name = "ActionResetCalculatorPath";
      this.ActionResetCalculatorPath.UseVisualStyleBackColor = true;
      this.ActionResetCalculatorPath.Click += new System.EventHandler(this.ActionResetCalculatorPath_Click);
      // 
      // ActionSelectCalculatorPath
      // 
      this.ActionSelectCalculatorPath.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionSelectCalculatorPath, "ActionSelectCalculatorPath");
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
      this.ActionSelectBackupFolder.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionSelectBackupFolder, "ActionSelectBackupFolder");
      this.ActionSelectBackupFolder.Name = "ActionSelectBackupFolder";
      this.ActionSelectBackupFolder.UseVisualStyleBackColor = true;
      this.ActionSelectBackupFolder.Click += new System.EventHandler(this.ActionSelectBackupFolder_Click);
      // 
      // ActionSelectHebrewLettersPath
      // 
      this.ActionSelectHebrewLettersPath.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionSelectHebrewLettersPath, "ActionSelectHebrewLettersPath");
      this.ActionSelectHebrewLettersPath.Name = "ActionSelectHebrewLettersPath";
      this.ActionSelectHebrewLettersPath.UseVisualStyleBackColor = true;
      this.ActionSelectHebrewLettersPath.Click += new System.EventHandler(this.ActionSelectHebrewLettersPath_Click);
      // 
      // EditBackupFolder
      // 
      this.EditBackupFolder.BackColor = System.Drawing.SystemColors.Control;
      this.EditBackupFolder.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      resources.ApplyResources(this.EditBackupFolder, "EditBackupFolder");
      this.EditBackupFolder.Name = "EditBackupFolder";
      this.EditBackupFolder.ReadOnly = true;
      // 
      // EditExportFolder
      // 
      this.EditExportFolder.BackColor = System.Drawing.SystemColors.Control;
      this.EditExportFolder.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      resources.ApplyResources(this.EditExportFolder, "EditExportFolder");
      this.EditExportFolder.Name = "EditExportFolder";
      this.EditExportFolder.ReadOnly = true;
      // 
      // EditCalculatorPath
      // 
      this.EditCalculatorPath.BackColor = System.Drawing.SystemColors.Control;
      this.EditCalculatorPath.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      resources.ApplyResources(this.EditCalculatorPath, "EditCalculatorPath");
      this.EditCalculatorPath.Name = "EditCalculatorPath";
      this.EditCalculatorPath.ReadOnly = true;
      // 
      // EditHebrewLettersPath
      // 
      this.EditHebrewLettersPath.BackColor = System.Drawing.SystemColors.Control;
      this.EditHebrewLettersPath.CaretAfterPaste = Ordisoftware.Core.CaretPositionAfterPaste.Ending;
      resources.ApplyResources(this.EditHebrewLettersPath, "EditHebrewLettersPath");
      this.EditHebrewLettersPath.Name = "EditHebrewLettersPath";
      this.EditHebrewLettersPath.ReadOnly = true;
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
      this.TabPageStartup.Controls.Add(this.EditAutoSortBookmarks);
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
      resources.ApplyResources(this.TabPageStartup, "TabPageStartup");
      this.TabPageStartup.Name = "TabPageStartup";
      // 
      // EditAutoSortBookmarks
      // 
      resources.ApplyResources(this.EditAutoSortBookmarks, "EditAutoSortBookmarks");
      this.EditAutoSortBookmarks.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.AutoSortBookmarks;
      this.EditAutoSortBookmarks.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "AutoSortBookmarks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditAutoSortBookmarks.Name = "EditAutoSortBookmarks";
      this.EditAutoSortBookmarks.UseVisualStyleBackColor = true;
      // 
      // EditGoToMasterBookmarkAtStartup
      // 
      resources.ApplyResources(this.EditGoToMasterBookmarkAtStartup, "EditGoToMasterBookmarkAtStartup");
      this.EditGoToMasterBookmarkAtStartup.Checked = global::Ordisoftware.Hebrew.Words.Properties.Settings.Default.GoToMasterBookmarkAtStartup;
      this.EditGoToMasterBookmarkAtStartup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ordisoftware.Hebrew.Words.Properties.Settings.Default, "GoToMasterBookmarkAtStartup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.EditGoToMasterBookmarkAtStartup.Name = "EditGoToMasterBookmarkAtStartup";
      this.EditGoToMasterBookmarkAtStartup.UseVisualStyleBackColor = true;
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
      this.TabPageApplication.Controls.Add(this.EditWebLinksMenuEnabled);
      this.TabPageApplication.Controls.Add(this.EditDebuggerEnabled);
      this.TabPageApplication.Controls.Add(this.EditUsageStatisticsEnabled);
      this.TabPageApplication.Controls.Add(this.EditLogEnabled);
      resources.ApplyResources(this.TabPageApplication, "TabPageApplication");
      this.TabPageApplication.Name = "TabPageApplication";
      // 
      // LabelInfoAutoSaveDelay
      // 
      resources.ApplyResources(this.LabelInfoAutoSaveDelay, "LabelInfoAutoSaveDelay");
      this.LabelInfoAutoSaveDelay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoAutoSaveDelay.Name = "LabelInfoAutoSaveDelay";
      // 
      // LabelInfoAutoBackupCount
      // 
      resources.ApplyResources(this.LabelInfoAutoBackupCount, "LabelInfoAutoBackupCount");
      this.LabelInfoAutoBackupCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoAutoBackupCount.Name = "LabelInfoAutoBackupCount";
      // 
      // EditAutoSaveDelay
      // 
      resources.ApplyResources(this.EditAutoSaveDelay, "EditAutoSaveDelay");
      this.EditAutoSaveDelay.Name = "EditAutoSaveDelay";
      // 
      // EditAutoBackupCount
      // 
      resources.ApplyResources(this.EditAutoBackupCount, "EditAutoBackupCount");
      this.EditAutoBackupCount.Name = "EditAutoBackupCount";
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
      // TabControl
      // 
      resources.ApplyResources(this.TabControl, "TabControl");
      this.TabControl.Controls.Add(this.TabPageApplication);
      this.TabControl.Controls.Add(this.TabPageStartup);
      this.TabControl.Controls.Add(this.TabPageRendering);
      this.TabControl.Controls.Add(this.TabPageTools);
      this.TabControl.Controls.Add(this.TabPagePaths);
      this.TabControl.Multiline = true;
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      // 
      // TabPageRendering
      // 
      this.TabPageRendering.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageRendering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageRendering.Controls.Add(this.LabelInfoSearchMinRefForDialog);
      this.TabPageRendering.Controls.Add(this.LabelInfoSearchDisplayMaxRef);
      this.TabPageRendering.Controls.Add(this.LabelInfoHistoryCount);
      this.TabPageRendering.Controls.Add(this.LabelInfoBookmarksCount);
      this.TabPageRendering.Controls.Add(this.LabelInfoWordControlWidth);
      this.TabPageRendering.Controls.Add(this.LabelInfoCommentLinesCount);
      this.TabPageRendering.Controls.Add(this.EditWordControlWidth);
      this.TabPageRendering.Controls.Add(LabelWordControlWidth);
      this.TabPageRendering.Controls.Add(this.EditSearchMinRefForDialog);
      this.TabPageRendering.Controls.Add(LabelMinRefCount);
      this.TabPageRendering.Controls.Add(this.EditSearchDisplayMaxRef);
      this.TabPageRendering.Controls.Add(LabelMaxRefCount);
      this.TabPageRendering.Controls.Add(this.EditHistoryCount);
      this.TabPageRendering.Controls.Add(LabelHistoryCount);
      this.TabPageRendering.Controls.Add(this.EditBookmarksCount);
      this.TabPageRendering.Controls.Add(LabelBookmarksCount);
      this.TabPageRendering.Controls.Add(this.EditCommentLinesCount);
      this.TabPageRendering.Controls.Add(LabelCommentaryLinesCount);
      resources.ApplyResources(this.TabPageRendering, "TabPageRendering");
      this.TabPageRendering.Name = "TabPageRendering";
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
      // LabelInfoHistoryCount
      // 
      resources.ApplyResources(this.LabelInfoHistoryCount, "LabelInfoHistoryCount");
      this.LabelInfoHistoryCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoHistoryCount.Name = "LabelInfoHistoryCount";
      // 
      // LabelInfoBookmarksCount
      // 
      resources.ApplyResources(this.LabelInfoBookmarksCount, "LabelInfoBookmarksCount");
      this.LabelInfoBookmarksCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoBookmarksCount.Name = "LabelInfoBookmarksCount";
      // 
      // LabelInfoWordControlWidth
      // 
      resources.ApplyResources(this.LabelInfoWordControlWidth, "LabelInfoWordControlWidth");
      this.LabelInfoWordControlWidth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoWordControlWidth.Name = "LabelInfoWordControlWidth";
      // 
      // LabelInfoCommentLinesCount
      // 
      resources.ApplyResources(this.LabelInfoCommentLinesCount, "LabelInfoCommentLinesCount");
      this.LabelInfoCommentLinesCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.LabelInfoCommentLinesCount.Name = "LabelInfoCommentLinesCount";
      // 
      // EditWordControlWidth
      // 
      this.EditWordControlWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      resources.ApplyResources(this.EditWordControlWidth, "EditWordControlWidth");
      this.EditWordControlWidth.Name = "EditWordControlWidth";
      // 
      // EditSearchMinRefForDialog
      // 
      this.EditSearchMinRefForDialog.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      resources.ApplyResources(this.EditSearchMinRefForDialog, "EditSearchMinRefForDialog");
      this.EditSearchMinRefForDialog.Name = "EditSearchMinRefForDialog";
      // 
      // EditSearchDisplayMaxRef
      // 
      this.EditSearchDisplayMaxRef.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      resources.ApplyResources(this.EditSearchDisplayMaxRef, "EditSearchDisplayMaxRef");
      this.EditSearchDisplayMaxRef.Name = "EditSearchDisplayMaxRef";
      this.EditSearchDisplayMaxRef.ValueChanged += new System.EventHandler(this.EditMaxRefCount_ValueChanged);
      // 
      // EditHistoryCount
      // 
      resources.ApplyResources(this.EditHistoryCount, "EditHistoryCount");
      this.EditHistoryCount.Name = "EditHistoryCount";
      // 
      // EditBookmarksCount
      // 
      resources.ApplyResources(this.EditBookmarksCount, "EditBookmarksCount");
      this.EditBookmarksCount.Name = "EditBookmarksCount";
      // 
      // EditCommentLinesCount
      // 
      resources.ApplyResources(this.EditCommentLinesCount, "EditCommentLinesCount");
      this.EditCommentLinesCount.Name = "EditCommentLinesCount";
      // 
      // TabPageTools
      // 
      this.TabPageTools.BackColor = System.Drawing.SystemColors.Window;
      this.TabPageTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TabPageTools.Controls.Add(this.GroupBoxHebrewWordClick);
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
      // GroupBoxHebrewWordClick
      // 
      this.GroupBoxHebrewWordClick.Controls.Add(this.SelectOpenNothing);
      this.GroupBoxHebrewWordClick.Controls.Add(this.SelectOpenOnlineSearch);
      this.GroupBoxHebrewWordClick.Controls.Add(this.SelectOpenTranslated);
      this.GroupBoxHebrewWordClick.Controls.Add(this.SelectOpenHebrewLetters);
      resources.ApplyResources(this.GroupBoxHebrewWordClick, "GroupBoxHebrewWordClick");
      this.GroupBoxHebrewWordClick.Name = "GroupBoxHebrewWordClick";
      this.GroupBoxHebrewWordClick.TabStop = false;
      // 
      // SelectOpenNothing
      // 
      resources.ApplyResources(this.SelectOpenNothing, "SelectOpenNothing");
      this.SelectOpenNothing.Name = "SelectOpenNothing";
      this.SelectOpenNothing.TabStop = true;
      this.SelectOpenNothing.UseVisualStyleBackColor = true;
      // 
      // SelectOpenOnlineSearch
      // 
      resources.ApplyResources(this.SelectOpenOnlineSearch, "SelectOpenOnlineSearch");
      this.SelectOpenOnlineSearch.Name = "SelectOpenOnlineSearch";
      this.SelectOpenOnlineSearch.TabStop = true;
      this.SelectOpenOnlineSearch.UseVisualStyleBackColor = true;
      // 
      // SelectOpenTranslated
      // 
      resources.ApplyResources(this.SelectOpenTranslated, "SelectOpenTranslated");
      this.SelectOpenTranslated.Name = "SelectOpenTranslated";
      this.SelectOpenTranslated.TabStop = true;
      this.SelectOpenTranslated.UseVisualStyleBackColor = true;
      // 
      // SelectOpenHebrewLetters
      // 
      resources.ApplyResources(this.SelectOpenHebrewLetters, "SelectOpenHebrewLetters");
      this.SelectOpenHebrewLetters.Name = "SelectOpenHebrewLetters";
      this.SelectOpenHebrewLetters.TabStop = true;
      this.SelectOpenHebrewLetters.UseVisualStyleBackColor = true;
      // 
      // ActionOnlineSearchHelp
      // 
      this.ActionOnlineSearchHelp.AllowDrop = true;
      this.ActionOnlineSearchHelp.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionOnlineSearchHelp, "ActionOnlineSearchHelp");
      this.ActionOnlineSearchHelp.Name = "ActionOnlineSearchHelp";
      this.ActionOnlineSearchHelp.UseVisualStyleBackColor = true;
      this.ActionOnlineSearchHelp.Click += new System.EventHandler(this.ActionOnlineSearchHelp_Click);
      // 
      // ActionOnlineVerseHelp
      // 
      this.ActionOnlineVerseHelp.AllowDrop = true;
      this.ActionOnlineVerseHelp.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionOnlineVerseHelp, "ActionOnlineVerseHelp");
      this.ActionOnlineVerseHelp.Name = "ActionOnlineVerseHelp";
      this.ActionOnlineVerseHelp.UseVisualStyleBackColor = true;
      this.ActionOnlineVerseHelp.Click += new System.EventHandler(this.ActionOnlineVerseHelp_Click);
      // 
      // ActionSelectOnlineSearch
      // 
      this.ActionSelectOnlineSearch.AllowDrop = true;
      this.ActionSelectOnlineSearch.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionSelectOnlineSearch, "ActionSelectOnlineSearch");
      this.ActionSelectOnlineSearch.Name = "ActionSelectOnlineSearch";
      this.ActionSelectOnlineSearch.UseVisualStyleBackColor = true;
      this.ActionSelectOnlineSearch.Click += new System.EventHandler(this.ActionSelectOnlineSearch_Click);
      // 
      // ActionSelectOnlineVerseURL
      // 
      this.ActionSelectOnlineVerseURL.AllowDrop = true;
      this.ActionSelectOnlineVerseURL.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.ActionSelectOnlineVerseURL, "ActionSelectOnlineVerseURL");
      this.ActionSelectOnlineVerseURL.Name = "ActionSelectOnlineVerseURL";
      this.ActionSelectOnlineVerseURL.UseVisualStyleBackColor = true;
      this.ActionSelectOnlineVerseURL.Click += new System.EventHandler(this.ActionSelectOnlineVerseURL_Click);
      // 
      // EditOnlineVerseURL
      // 
      resources.ApplyResources(this.EditOnlineVerseURL, "EditOnlineVerseURL");
      this.EditOnlineVerseURL.Name = "EditOnlineVerseURL";
      // 
      // EditOnlineSearch
      // 
      resources.ApplyResources(this.EditOnlineSearch, "EditOnlineSearch");
      this.EditOnlineSearch.Name = "EditOnlineSearch";
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
      ((System.ComponentModel.ISupportInitialize)(this.EditCheckUpdateAtStartupInterval)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditVacuumAtStartupInterval)).EndInit();
      this.TabPageApplication.ResumeLayout(false);
      this.TabPageApplication.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoSaveDelay)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditAutoBackupCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditVolume)).EndInit();
      this.TabControl.ResumeLayout(false);
      this.TabPageRendering.ResumeLayout(false);
      this.TabPageRendering.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditWordControlWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditSearchMinRefForDialog)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditSearchDisplayMaxRef)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditHistoryCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditBookmarksCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditCommentLinesCount)).EndInit();
      this.TabPageTools.ResumeLayout(false);
      this.TabPageTools.PerformLayout();
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
    private NumericUpDown EditCommentLinesCount;
    private TabPage TabPageTools;
    private Button ActionOnlineSearchHelp;
    private Button ActionOnlineVerseHelp;
    private Button ActionSelectOnlineSearch;
    private Button ActionSelectOnlineVerseURL;
    private TextBox EditOnlineVerseURL;
    private TextBox EditOnlineSearch;
    private GroupBox GroupBoxHebrewWordClick;
    private RadioButton SelectOpenNothing;
    private RadioButton SelectOpenOnlineSearch;
    private RadioButton SelectOpenTranslated;
    private RadioButton SelectOpenHebrewLetters;
    private CheckBox EditGoToMasterBookmarkAtStartup;
    private CheckBox EditAutoSortBookmarks;
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
  }
}
