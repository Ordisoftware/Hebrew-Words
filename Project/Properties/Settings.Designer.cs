﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ordisoftware.HebrewWords.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Center")]
        public global::Ordisoftware.HebrewCommon.ControlLocation MainFormPosition {
            get {
                return ((global::Ordisoftware.HebrewCommon.ControlLocation)(this["MainFormPosition"]));
            }
            set {
                this["MainFormPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int MainFormLeft {
            get {
                return ((int)(this["MainFormLeft"]));
            }
            set {
                this["MainFormLeft"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int MainFormTop {
            get {
                return ((int)(this["MainFormTop"]));
            }
            set {
                this["MainFormTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int MainFormWidth {
            get {
                return ((int)(this["MainFormWidth"]));
            }
            set {
                this["MainFormWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int MainFormHeight {
            get {
                return ((int)(this["MainFormHeight"]));
            }
            set {
                this["MainFormHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState MainFormState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["MainFormState"]));
            }
            set {
                this["MainFormState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ConfirmClosing {
            get {
                return ((bool)(this["ConfirmClosing"]));
            }
            set {
                this["ConfirmClosing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowTips {
            get {
                return ((bool)(this["ShowTips"]));
            }
            set {
                this["ShowTips"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Verses")]
        public global::Ordisoftware.HebrewWords.ViewMode CurrentView {
            get {
                return ((global::Ordisoftware.HebrewWords.ViewMode)(this["CurrentView"]));
            }
            set {
                this["CurrentView"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Dsn=Hebrew-Words")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\Program Files\\Ordisoftware\\Hebrew Letters\\Bin\\Ordisoftware.HebrewLetters.exe")]
        public string HebrewLettersExe {
            get {
                return ((string)(this["HebrewLettersExe"]));
            }
            set {
                this["HebrewLettersExe"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.pealim.com/search/?q=%WORD%")]
        public string SearchOnlineURL {
            get {
                return ((string)(this["SearchOnlineURL"]));
            }
            set {
                this["SearchOnlineURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BackupPath {
            get {
                return ((string)(this["BackupPath"]));
            }
            set {
                this["BackupPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int BackupCount {
            get {
                return ((int)(this["BackupCount"]));
            }
            set {
                this["BackupCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int AutoSaveDelay {
            get {
                return ((int)(this["AutoSaveDelay"]));
            }
            set {
                this["AutoSaveDelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SearchTranslated")]
        public global::Ordisoftware.HebrewWords.HebrewWordClickOpen HebrewWordClickOpen {
            get {
                return ((global::Ordisoftware.HebrewWords.HebrewWordClickOpen)(this["HebrewWordClickOpen"]));
            }
            set {
                this["HebrewWordClickOpen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://studybible.info/IHOT/%BOOKSB% %CHAPTERNUM%:%VERSENUM%")]
        public string OpenVerseOnlineURL {
            get {
                return ((string)(this["OpenVerseOnlineURL"]));
            }
            set {
                this["OpenVerseOnlineURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int VerseCommentaryLinesCount {
            get {
                return ((int)(this["VerseCommentaryLinesCount"]));
            }
            set {
                this["VerseCommentaryLinesCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int BookmarksCount {
            get {
                return ((int)(this["BookmarksCount"]));
            }
            set {
                this["BookmarksCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int BookmarkMasterBook {
            get {
                return ((int)(this["BookmarkMasterBook"]));
            }
            set {
                this["BookmarkMasterBook"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int BookmarkMasterChapter {
            get {
                return ((int)(this["BookmarkMasterChapter"]));
            }
            set {
                this["BookmarkMasterChapter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int BookmarkMasterVerse {
            get {
                return ((int)(this["BookmarkMasterVerse"]));
            }
            set {
                this["BookmarkMasterVerse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("205")]
        public int WordControlWidth {
            get {
                return ((int)(this["WordControlWidth"]));
            }
            set {
                this["WordControlWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int FoundReferencesViewable {
            get {
                return ((int)(this["FoundReferencesViewable"]));
            }
            set {
                this["FoundReferencesViewable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("292, 466")]
        public global::System.Drawing.Size SearchTranslatedFormSize {
            get {
                return ((global::System.Drawing.Size)(this["SearchTranslatedFormSize"]));
            }
            set {
                this["SearchTranslatedFormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1, -1")]
        public global::System.Drawing.Point SearchTranslatedFormLocation {
            get {
                return ((global::System.Drawing.Point)(this["SearchTranslatedFormLocation"]));
            }
            set {
                this["SearchTranslatedFormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int HistoryCount {
            get {
                return ((int)(this["HistoryCount"]));
            }
            set {
                this["HistoryCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int FoundReferencesToOpenDialog {
            get {
                return ((int)(this["FoundReferencesToOpenDialog"]));
            }
            set {
                this["FoundReferencesToOpenDialog"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1, -1")]
        public global::System.Drawing.Point GrammarGuideFormLocation {
            get {
                return ((global::System.Drawing.Point)(this["GrammarGuideFormLocation"]));
            }
            set {
                this["GrammarGuideFormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("492, 566")]
        public global::System.Drawing.Size GrammarGuideFormSize {
            get {
                return ((global::System.Drawing.Size)(this["GrammarGuideFormSize"]));
            }
            set {
                this["GrammarGuideFormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SearchTranslatedFormFilterDistinct {
            get {
                return ((bool)(this["SearchTranslatedFormFilterDistinct"]));
            }
            set {
                this["SearchTranslatedFormFilterDistinct"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int CurrentSearchTypeTab {
            get {
                return ((int)(this["CurrentSearchTypeTab"]));
            }
            set {
                this["CurrentSearchTypeTab"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CheckUpdateAtStartup {
            get {
                return ((bool)(this["CheckUpdateAtStartup"]));
            }
            set {
                this["CheckUpdateAtStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CloseSearchTranslatedFormReturnToReference {
            get {
                return ((bool)(this["CloseSearchTranslatedFormReturnToReference"]));
            }
            set {
                this["CloseSearchTranslatedFormReturnToReference"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OpenLastViewAtStartup {
            get {
                return ((bool)(this["OpenLastViewAtStartup"]));
            }
            set {
                this["OpenLastViewAtStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SearchInTorah {
            get {
                return ((bool)(this["SearchInTorah"]));
            }
            set {
                this["SearchInTorah"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SearchInNeviim {
            get {
                return ((bool)(this["SearchInNeviim"]));
            }
            set {
                this["SearchInNeviim"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SearchInKetouvim {
            get {
                return ((bool)(this["SearchInKetouvim"]));
            }
            set {
                this["SearchInKetouvim"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("792, 666")]
        public global::System.Drawing.Size ImportVerseFormSize {
            get {
                return ((global::System.Drawing.Size)(this["ImportVerseFormSize"]));
            }
            set {
                this["ImportVerseFormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OpenGeneratedMSWordFiles {
            get {
                return ((bool)(this["OpenGeneratedMSWordFiles"]));
            }
            set {
                this["OpenGeneratedMSWordFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SearchInBookSelectedNumber {
            get {
                return ((int)(this["SearchInBookSelectedNumber"]));
            }
            set {
                this["SearchInBookSelectedNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int ImportVerseFormSplitterDistance {
            get {
                return ((int)(this["ImportVerseFormSplitterDistance"]));
            }
            set {
                this["ImportVerseFormSplitterDistance"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("130")]
        public int FoundReferencesColumnRefWidth {
            get {
                return ((int)(this["FoundReferencesColumnRefWidth"]));
            }
            set {
                this["FoundReferencesColumnRefWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ReachReference")]
        public global::Ordisoftware.HebrewWords.TranslatedItemDoubleClickOpen TranslatedItemDoubleClickOpen {
            get {
                return ((global::Ordisoftware.HebrewWords.TranslatedItemDoubleClickOpen)(this["TranslatedItemDoubleClickOpen"]));
            }
            set {
                this["TranslatedItemDoubleClickOpen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("492, 266")]
        public global::System.Drawing.Size EditMemoFormClientSize {
            get {
                return ((global::System.Drawing.Size)(this["EditMemoFormClientSize"]));
            }
            set {
                this["EditMemoFormClientSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("692, 666")]
        public global::System.Drawing.Size EditBooksFormClientSize {
            get {
                return ((global::System.Drawing.Size)(this["EditBooksFormClientSize"]));
            }
            set {
                this["EditBooksFormClientSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GoToMasterBookmarkAtStartup {
            get {
                return ((bool)(this["GoToMasterBookmarkAtStartup"]));
            }
            set {
                this["GoToMasterBookmarkAtStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("150")]
        public int ImportVerseFormGridColumnWidthHebrew {
            get {
                return ((int)(this["ImportVerseFormGridColumnWidthHebrew"]));
            }
            set {
                this["ImportVerseFormGridColumnWidthHebrew"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250")]
        public int ImportVerseFormGridColumnWidthTranslationCurrent {
            get {
                return ((int)(this["ImportVerseFormGridColumnWidthTranslationCurrent"]));
            }
            set {
                this["ImportVerseFormGridColumnWidthTranslationCurrent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoSortBookmarks {
            get {
                return ((bool)(this["AutoSortBookmarks"]));
            }
            set {
                this["AutoSortBookmarks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool VacuumAtStartup {
            get {
                return ((bool)(this["VacuumAtStartup"]));
            }
            set {
                this["VacuumAtStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DebuggerEnabled {
            get {
                return ((bool)(this["DebuggerEnabled"]));
            }
            set {
                this["DebuggerEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime VacuumLastDone {
            get {
                return ((global::System.DateTime)(this["VacuumLastDone"]));
            }
            set {
                this["VacuumLastDone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime CheckUpdateLastDone {
            get {
                return ((global::System.DateTime)(this["CheckUpdateLastDone"]));
            }
            set {
                this["CheckUpdateLastDone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1, -1")]
        public global::System.Drawing.Point LogFormLocation {
            get {
                return ((global::System.Drawing.Point)(this["LogFormLocation"]));
            }
            set {
                this["LogFormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("784, 561")]
        public global::System.Drawing.Size LogFormSize {
            get {
                return ((global::System.Drawing.Size)(this["LogFormSize"]));
            }
            set {
                this["LogFormSize"] = value;
            }
        }
    }
}
