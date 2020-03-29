# Hebrew Words

>This project follows the [Manufacturing Software Guidelines](https://github.com/Ordisoftware/Guidelines).

>Licensed under the terms of the [Mozilla Public License 2.0](LICENSE)<br/>
>[Project Website](http://www.ordisoftware.com/projects/hebrew-words)<br/>
>[Twitter](https://twitter.com/ordisoftware)<br/>

A tool for Windows written in C# that helps for the literal word-for-word translation of the Torah and the Hebrew Bible verses.

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

## Requirements

- Windows Vista x32/x64 or higher
- Screen 1024x768 or higher
- Framework .NET 4.5
- SQLite ODBC Driver

## Screenshots

![verses Tab](http://www.ordisoftware.com/uploads/2019/09/hebrew-words-verses-en.png)

![Translations Tab](http://www.ordisoftware.com/uploads/2019/09/hebrew-words-translation-en.png)

![Search Tab](http://www.ordisoftware.com/uploads/2019/09/hebrew-words-search-en.png)

![Stats Tab](http://www.ordisoftware.com/uploads/2019/09/hebrew-words-stats-en.png)

## Videos

[![Showing video](https://img.youtube.com/vi/2c5JAdFU1Kk/0.jpg)](https://www.youtube.com/watch?v=2c5JAdFU1Kk)

[![Showing video](https://img.youtube.com/vi/Wc5SdiASvCg/0.jpg)](https://www.youtube.com/watch?v=Wc5SdiASvCg)

## Frequently asked questions

#### How to install SQlite ODBC Driver?

The setup tries to install the driver:

- [sqliteodbc.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc.exe) on Windows 32-bit.
- [sqliteodbc_w64.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc_w64.exe) on Windows 64-bit.

#### What to do in case of ODBC datasource connection error?

The setup tries to register an ODBC DSN to the registry but in case of problem run "C:\Program Files\Ordisoftware\Hebrew Words\Register ODBC.reg" or open the ODBC datasource manager (Admin tools in Windows' Control panel) and create a user datasource named "Hebrew-Words" for "SQLite 3 ODBC Driver" with "Database Name" sets to:

"%USERPROFILE%\AppData\Roaming\Ordisoftware\Hebrew Words\Hebrew-Words.sqlite"

Watch the [video](https://www.youtube.com/watch?v=WPVF8pj9I3E).

#### What to do if there is a problem with the display?

Use the refresh view action of the menu at the top.

#### The software sometimes runs slowly, is this normal?

Yes, because implementing features requires a lot of Windows resources that depend on the performance of the computer.

#### Keyboard shortcuts

- F1 : Verses view
- F2 : Translation view
- F3 : Hebrew text view
- F4 : ELS50 verses view
- F5 : Search view
- Ctrl+S : Save changes
- Ctrl+R : Find reference
- Ctrl+F : Find verse number in current chapter (0 for first untranslated)
- Ctrl+G : Open the grammar guide
- Ctrl+H : Open Hebrew Letters
- Ctrl+L : Open Shorashon web page
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

## Changelog

#### 2020.__.__ - Version 3.0

- Add keyboard shortcuts to open Hebrew Letters and Shorashon web page.
- Add links to Lexilogos and Hebrew Gematria web pages.
- Add online search from several providers (Pealim, Sefaria, Dict.com, Wiktionary, Google, Bing, Reverso, Glosbe).
>>>>- Add some links to Serafia website: Sefer Yetsirah and Pirke Avot.
>>>>- Add chapter title and memo text box on top of verses panel.
(>>>>- Add letters values in the input panel.)
>>>>- Add copy/cut/paste for the hebrew letters input box.
>>>>- Add copy hebrew unicode to clipboard button for the hebrew letters input box.
>>>>- Add paste from unicode clipboard content button for the hebrew letters input box.
>>>>- Add "add translation (to a word)" action in the search translated form, in addition to the "use" action.
>>>>- Add popup box to show hebrew source word in the search translated form.
>>>>- Add option to choose double-click action on a word in the search translated form.
>>>>- Add option to choose a default search word online action.
(>>>>- Improve auto-backup to allow periodic archive as weekly or monthly)
(>>>>- Improve import console to support hebrew unicode chars in addition to hebrew font.)
- Improve UI.
(- Database updated to support internal strong concordance popup menus in the future.)
- Bug to solve in the future : error message when several SearchTranslatedForm are opened - using the top refresh button cancels that.
- Bug to solve in the future : error message, sometimes, when typing too fastly in the comment boxes.

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
