# Hebrew Words

>This project follows the [Manufacturing Software Guidelines](https://github.com/Ordisoftware/Guidelines).

>Licensed under the terms of the [Mozilla Public License 2.0](LICENSE)<br/>
>[Project Website](https://www.ordisoftware.com/projects/hebrew-words)<br/>
>[Twitter](https://twitter.com/ordisoftware)<br/>

A tool for Windows written in C# that helps for the literal word-for-word translation of the Torah and the Hebrew Bible verses.

## Table of content

1. [Functionalities](#Functionalities)
2. [Review](#Review)
3. [Requirements](#Requirements)
4. [Screenshots](#Screenshots)
5. [Videos](#Videos)
6. [Frequently asked questions](#Frequently-asked-questions)
    - [How to install SQlite ODBC Driver?](#How-to-install-SQlite-ODBC-Driver)
    - [What to do in case of ODBC datasource connection error?](#What-to-do-in-case-of-ODBC-datasource-connection-error)
    - [What to do if the check update tells that the SSL certificate is wrong or expired?](#What-to-do-if-the-check-update-tells-that-the-SSL-certificate-is-wrong-or-expired)
    - [What to do if there is a problem with the display?](#What-to-do-if-there-is-a-problem-with-the-display)
    - [The software sometimes runs slowly, is this normal?](#The-software-sometimes-runs-slowly-is-this-normal)
7. [Keyboard shortcuts](#Keyboard-shortcuts)
8. [Future improvements](#Future-improvements)
9. [Changelog](#Changelog)

## Functionalities

- Translate verses word-for-word.
- Left mouse click on a word to open online strong's concordance or Hebrew Letters or search already translated.
- Right mouse click on a word to open context menu with more options like search verses having the word.
- Left mouse click on a verse number to open online text with contextual strong's concordances.
- Right mouse click on a verse number to open context menu with more options like bookmarks.
- MS Word export of a book or a chapter or a verse.
- Determine the Equidistant Letter Sequence of 50 for Tav.
- Search hebrew or translated words with filters.
- Grammar guide.
- Links to various online resources.
- Show some statistics.
- English, French.

## Review

[Softpedia.com](https://www.softpedia.com/get/Others/Home-Education/Hebrew-Words.shtml)

_"Well-designed Hebrew Bible app that can serve both as an exploratory tool, as well as a way to perform exact translations"_

[![Note](https://www.ordisoftware.com/theme/softpedia3.5-white.png)](https://www.softpedia.com/get/Others/Home-Education/Hebrew-Words.shtml)

## Requirements

- Windows 7 SP1 x32/x64 or higher
- Screen 1024x768 or higher
- Framework .NET 4.7.2
- SQLite ODBC Driver

## Screenshots

[![verses View](https://i1.wp.com/www.ordisoftware.com/uploads/2019/09/hebrew-words-verses-en.png?resize=300%2C233&ssl=1)](https://www.ordisoftware.com/uploads/2019/09/hebrew-words-verses-en.png)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Translation View](https://i1.wp.com/www.ordisoftware.com/uploads/2019/09/hebrew-words-translation-en.png?resize=300%2C233&ssl=1)](https://www.ordisoftware.com/uploads/2019/09/hebrew-words-translation-en.png)

[![Search View](https://i1.wp.com/www.ordisoftware.com/uploads/2019/09/hebrew-words-search-en.png?resize=300%2C233&ssl=1)](https://www.ordisoftware.com/uploads/2019/09/hebrew-words-search-en.png)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Statistics](https://i0.wp.com/www.ordisoftware.com/uploads/2019/09/hebrew-words-stats-en.png?resize=149%2C200&ssl=1)](https://www.ordisoftware.com/uploads/2019/09/hebrew-words-stats-en.png)

## Videos

[![Showing video](https://img.youtube.com/vi/2c5JAdFU1Kk/mqdefault.jpg)](https://www.youtube.com/watch?v=2c5JAdFU1Kk)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Showing video](https://img.youtube.com/vi/Wc5SdiASvCg/mqdefault.jpg)](https://www.youtube.com/watch?v=Wc5SdiASvCg)

## Frequently asked questions

#### How to install SQlite ODBC Driver?

The setup installs:

- [sqliteodbc.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc.exe) on Windows 32-bit.
- [sqliteodbc_w64.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc_w64.exe) on Windows 64-bit.

In the event that an error message indicates that a DLL file could not be copied, it is usually due to the fact that an application using this driver already installed is running and is blocking the file. You can ignore this error or close the application in question and restart the installation to obtain a driver update.

#### What to do in case of ODBC datasource connection error?

The software tries to register an ODBC DSN to the registry but in case of problem run "C:\Program Files\Ordisoftware\Hebrew Words\Register ODBC.reg" or open the ODBC datasource manager (Admin tools in Windows' Control panel) and create a user datasource named "Hebrew-Words" for "SQLite 3 ODBC Driver" with "Database Name" sets to:

"%USERPROFILE%\AppData\Roaming\Ordisoftware\Hebrew Words\Hebrew-Words.sqlite"

Watch the [video](https://www.youtube.com/watch?v=WPVF8pj9I3E).

#### What to do if the check update tells that the SSL certificate is wrong or expired?

The software verifies the validity of the certificate of the update server in addition to the SHA-512 checksum of the installation file before downloading and running it. This certificate is normally updated within the two months of its annual expiration and a new version is released. If the application has not been updated within this period, you can manually check the latest version available online.

#### What to do if there is a problem with the display?

Use the refresh view action of the menu at the top.

#### The software sometimes runs slowly, is this normal?

Yes, because implementing features requires a lot of Windows resources that depend on the performance of the computer.

## Keyboard shortcuts

- F1 : Verses view
- F2 : Translation view
- F3 : Hebrew text view
- F4 : ELS50 verses view
- F5 : Search view
- Ctrl+B : Open the books names editor
- Ctrl+H : Open Hebrew Letters
- Ctrl+T : Open translated form for the focused hebrew word
- Ctrl+K : Open search panel for the focused hebrew word
- Ctrl+G : Open the grammar guide
- Ctrl+L : Open Shorashon web page
- Ctrl+R : Find reference
- Ctrl+F : Find verse number in current chapter (0 for first untranslated)
- Ctrl+S : Save changes
- Ctrl+Home : Reach the beginning of the view
- Ctrl+End : Reach the ending of the view
- Ctrl+Up : Scroll the view up (fine)
- Ctrl+Down : Scroll the view down (fine)
- PageUp : Scroll the view up
- PageDown : Scroll the view down
- F8 : Preferences
- F11 : Help
- F12 : About
- Escape : Close window or Cancel process 

## Future improvements

- Add strong's concordances to database.
- Add classic english translation to database.
- Add form to edit strong's concordances.
- Add form to edit classis english translation.
- Add classic english translation between an hebrew word and the working translation.
- Change contextual click on a hebrew word to use database instead of web search.

## Changelog

#### Version 3.0 (in progress)

- Integrate the new input panel from Hebrew Letters v4 having undo/redo/copy/cit/paste capabilities.
- Fix error message when several SearchTranslatedForm are opened.
- Fix error message when typing in the comment boxes.
- Add keyboard shortcuts to open the books names editor, Hebrew Letters and Shorashon.
- Add online search a word for several providers : Pealim, Sefaria, Dict.com, Wiktionary, Google, Bing, Reverso, Glosbe.
- Add book name translation text box in the navigation panel.
- Add chapter title and memo text boxes in the navigation panel.
- Add buttons to edit book and chapter memos in the navigation panel.
- Add "add translation (to a word)" action in the search translated form, in addition to the "use" action.
- Add books common names field in the database and in the edit books information form.
- Add open book menu item in the edit books information form.
- Fix edit books information form : modifications are not saved since an old version.
- Add some context menu items in the edit books information form to search online, copy to clipboard and edit memo.
- Add source hebrew word in the search translated form.
- Change selection controls in the go to reference form.
- Add options to filter the books in the go to reference form.
- Add "Add a bookmark" menu item.
- Add "Sort bookmarks" menu item.
- Add auto sort bookmarks option.
- Add option to open the master bookmark else the first verse of the Tanak.
- Fix bookmarks and history files introduced in v2.4 (stored in bin folder instead of user data, moved by the setup).
- Add menu for web links about judaism.
- Improve open Hebrew Letters for the current word when focused on the verses view.
- Add Ctrl+T shortcut to open the translated form the focused hebrew word.
- Add Ctrl+K shortcut to open the search view for the focused hebrew word.
- Add optimize database menu.
- Add option to auto optimize database at startup once a week.
- Add option to enable debugger.
- Add debugger (exception information form with GitHub issue creation).
- Move online providers values from code to files in the application documents folder.
- Move tanak text files in Documents in a dedicated folder.

> Add bookmarks backup/restore.

> Add option to go to last reference on startup.

> Add parasha list form with references links.

> Add count the number of a word occurences.

> Add option to choose double-click action on a word in the search translated form.

> Improve search to find words in chapters translated title.

> Add book memo and chapter title/memo in DOCX export.

> Add book name/translation/memo and chapter number/title/memo in RTF (translation) export.

> Add menu to open a batch export form.

> Add option to enable or disable the web links menu.

> (Add word occurences calculator button in the search panel.)

> (Add option to change fonts size.)

> (Improve auto-backup to allow periodic archive as weekly or monthly)

> (Improve import console to support hebrew unicode chars in addition to hebrew font.)

> (Database updated to support internal strong concordance popup menus in the future.)

- Add permanent database file locking while running.
- Add usage statistics form in tools menu.
- Add option to set automatic web check update frequency.
- Add option to enable or disable the web links menu.
- Add option to enable or disable message boxes sounds.
- Add option to set application's volume.
- Improve message boxes.
- Improve check update to allow auto update or direct download or open app web page.
- Improve check update to verify the SSL certificate of the website and the checksum of the setup file.
- Improve debugger to support logging.
- Improve exception form to view log.
- Improve UI/UX.
- Massive code refactoring.
- Update help.
- Update to SQLite 3.32.3 ODBC Driver.
- Update Framework .NET version to 4.7.2 and supported Windows only 7 SP1 or higher.
- The application now automatically creates the ODBC DSN in the Windows registry.
- Improve setup.
- Rename 32x32 icon files.
- Refactor project folders hierarchy.
- Replace simple internal command line parser by CommandLineParser NuGet package.
- Add Serilog NuGet package.
- Add Serilog-sinks-file NuGet package.
- Add Markdig NuGet package.
- Add Newtonsoft.Json NuGet package.
- Add MoreLINQ NuGet package.
- Add Humanizer NuGet package.
- Add FluentValidation NuGet package.
- Replace DocX 1.2 dependency by the NuGet package 1.7.1.

#### 2020.09.01 - Version 2.5

- Maintenance release.

#### 2019.11.14 - Version 2.4

- Add history persistence.
- Fix buttons location when resizing SearchTranslatedForm.
- Change SearchTranslatedForm and GrammarGuideForm min width.
- Update help.

#### 2019.10.18 - Version 2.3

- Improve UI.
- Some fixes.
- Some code refactorings.
- Setup install SQLite ODBC Driver if not present.

#### 2019.09.24 - Version 2.2

- Add option to choose language.
- Improve UI.
- Update help.
- Fix reload data.
- Some code refactorings.

#### 2019.09.21 - Version 2.1

- Add find reference menu button.
- Add search in book filter.
- Add option to open generated MSWord files.
- Add import verse console.
- Improve reference management.
- Fix books file names and indexes.

#### 2019.09.19 - Version 2.0

- Add context menu on hebrew words, on verses numbers and on search reference found.
- Add search translations of a word.
- Add option to define url to open verse online.
- Add option to set commentary lines count.
- Add option to disable startup check update.
- Add master bookmark used at startup.
- Add bookmarks.
- Add navigation history.
- Add grammar guide.
- Improve UI.
- Improve verses rendering.
- Improve translations rendering.
- Improve search rendering.
- Improve search filters.
- Improve statistics.
- Improve tools.
- Some fixes.
- Update help.

#### 2019.09.03 - Version 1.8

- Improve verses view.
- Improve export UI.
- Fix select chapter combobox.

#### 2019.08.30 - Version 1.7

- Add MSWord export for one verse.
- Auto save option.
- Some fixes.

#### 2019.08.29 - Version 1.6

- Add default backup location.
- Add auto backup.
- Add copy to clipboard.
- Add export to RTF.
- Fix backup operations.

#### 2019.08.28 - Version 1.5

- Add create new and restore database.

#### 2019.08.25 - Version 1.4

- Add shortcut for hebrew raw text view.
- Improve check update.

#### 2019.05.22 - Version 1.3

- Add backup database.
- Add check update.

#### 2019.01.29 - Version 1.2

- Add word docx export.

#### 2019.01.28 - Version 1.1

- Add books names translation form.
- Add search a word.
- Add open verse online.
- Add verse comment edition.
- Some improvments.

#### 2019.01.26 - Version 1.0

- Initial release.