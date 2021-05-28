# Hebrew Words

> Licensed under the terms of the [Mozilla Public License 2.0](LICENSE)<br/>
> This project follows the [Manufacturing Software Guidelines](https://github.com/Ordisoftware/Guidelines).<br/>
> [Website](https://www.ordisoftware.com/projects/hebrew-words)<br/>
> [Twitter](https://twitter.com/ordisoftware)<br/>

A libre and open-source software written in C# that helps for the literal word-for-word translation of the Torah and Hebrew Bible.

## Table of content

1. [Functionalities](#Functionalities)
2. [Review](#Review)
3. [Requirements](#Requirements)
4. [Download](#Download)
5. [Screenshots](#Screenshots)
6. [Videos](#Videos)
7. [Frequently asked questions](#Frequently-asked-questions)
8. [Keyboard shortcuts](#Keyboard-shortcuts)
9. [Future improvements](#Future-improvements)
10. [Changelog](#Changelog)

## Functionalities

- Translate verses word-for-word.
- Left mouse click on a word to open online strong's concordance or Hebrew Letters or search already translated.
- Right mouse click on a word to open context menu with more options like search verses having the word.
- Left mouse click on a verse number to open online text with contextual strong's concordances.
- Right mouse click on a verse number to open context menu with more options like bookmarks.
- MS Word export of a book or a chapter or a verse.
- Determine the Equidistant Letter Sequence of 50 for Tav.
- Search Hebrew or translated words with filters.
- Grammar guide.
- Links to various online resources.
- Show some statistics.
- English, French.

## Review

[Softpedia.com](https://www.softpedia.com/get/Others/Home-Education/Hebrew-Words.shtml)

_"Well-designed Hebrew Bible app that can serve both as an exploratory tool, as well as a way to perform exact translations"_

[![Note](https://www.ordisoftware.com/wp-content/theming/softpedia3.5-white.png)](https://www.softpedia.com/get/Others/Home-Education/Hebrew-Words.shtml)

## Requirements

- Windows 7 SP1 x32/x64 or higher
- Screen 1024x768 or higher
- Framework .NET 4.7.2
- SQLite ODBC Driver

## Download

**What's new in the latest version**

-

[Last release](https://github.com/Ordisoftware/Hebrew-Words/releases/latest)

[French Tanak database decoded by the author](https://github.com/Ordisoftware/Torah-Physicalist-Exegesis-Books/tree/master/Tanak)

## Screenshots

[![verses View](https://i1.wp.com/www.ordisoftware.com/uploads/2019/09/hebrew-words-verses-en.png?resize=300%2C233&ssl=1)](https://www.ordisoftware.com/uploads/2019/09/hebrew-words-verses-en.png)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Translation View](https://i1.wp.com/www.ordisoftware.com/uploads/2019/09/hebrew-words-translation-en.png?resize=300%2C233&ssl=1)](https://www.ordisoftware.com/uploads/2019/09/hebrew-words-translation-en.png)

[![Search View](https://i1.wp.com/www.ordisoftware.com/uploads/2019/09/hebrew-words-search-en.png?resize=300%2C233&ssl=1)](https://www.ordisoftware.com/uploads/2019/09/hebrew-words-search-en.png)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Statistics](https://i0.wp.com/www.ordisoftware.com/uploads/2019/09/hebrew-words-stats-en.png?resize=149%2C200&ssl=1)](https://www.ordisoftware.com/uploads/2019/09/hebrew-words-stats-en.png)

## Videos

[![Showing video](https://img.youtube.com/vi/2c5JAdFU1Kk/mqdefault.jpg)](https://www.youtube.com/watch?v=2c5JAdFU1Kk)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Showing video](https://img.youtube.com/vi/Wc5SdiASvCg/mqdefault.jpg)](https://www.youtube.com/watch?v=Wc5SdiASvCg)

## Frequently asked questions

#### What to do if the check update tells that the SSL certificate is wrong or expired?

The software verifies the validity of the certificate of the update server in addition to the SHA-512 checksum of the installation file before downloading and running it. This certificate is normally updated within the two months of its annual expiration and a new version is released. You can manually check the latest version available online in case of problem.

#### What to do if there is a problem with the display?

Use the refresh view action of the menu at the top.

#### The software sometimes runs slowly, is this normal?

Yes, because implementing features requires a lot of Windows resources that depend on the performance of the computer.

#### Are personal data collected?

This software doesn't collect any personal information about you, your computer and your network, unless it is specified by its features.

However, it can collect for debugging purposes the type of processor and operating system as well as errors caused by the code, but these information are only stored locally and only transmitted upon conscious validations by the user.

#### What about possible virus issues?

Alerts since early 2021 regarding a *Trojan.Malware.300983.susgen* from a little known vendor, and a *Nibiru detection* from a Sigma Crowdsourced rule, appear to be false positives.

Kaspersky, F-Secure, Trend Micro, McAfee, CrowdStrike Falcon, MetaDefender and Malwarebytes could not find anything on the solo-computer that is behind software and hardware firewalls, and which is used to create the binaries. Additionally, inspection of the Windows registry and file system did not reveal anything conclusive about a potential infection. A cursory review of the source code, just like using an old workstation backup, could not identify the cause of these flags.

The Hebrew software use certain functions of the Windows system like for error tracing and global keyboard shortcuts management, as well as multiple timers, and some command line options to control each other via IPC. The author also uses advanced coding techniques such as generics and factorization, and the database access layer has been completely rewritten for Calender 8, Letters 6 and Words 3.

If in doubt, the source code available at https://github.com/Ordisoftware can be build using Visual Studio 2017 or later. Please do not hesitate to contact the author or create a GitHub Issue if you have any information on this, and if there is a real problem with the binaries or the source code.
## Keyboard shortcuts

| Keys | Actions |
|-|-|
| F1 | Verses view |
| F2 | Translation view |
| F3 | Hebrew text view |
| F4 | ELS50 verses view |
| F5 | Search view |
| Ctrl + B | Open the books names editor |
| Ctrl + H | Open Hebrew Letters |
| Ctrl + T | Open translated form for the focused Hebrew word |
| Ctrl + K | Open search panel for the focused Hebrew word |
| Ctrl + G | Open the grammar guide |
| Ctrl + F | Find verse number in current chapter (0 for first untranslated) |
| Ctrl + Alt + F | Find reference |
| Ctrl + S | Save changes |
| Ctrl + Back | Cancel changes |
| Ctrl + Home | Reach the beginning of the view |
| Ctrl + End | Reach the ending of the view |
| Ctrl + Up | Scroll the view up (fine) |
| Ctrl + Down | Scroll the view down (fine) |
| PageUp | Scroll the view up |
| PageDown | Scroll the view down |
| Alt + T | Show tools menu |
| Alt + L | Show web links menu |
| Alt + S | Show settings menu |
| Alt + I | Show information menu |
| F9 | Preferences |
| F10 | Log file window |
| F11 | Usage statistics window |
| F12 | About |
| Alt + F4 (or Escape) | Exit application |

## Future improvements

- Add strong's concordances to database.
- Add classic english translation to database.
- Add form to edit strong's concordances.
- Add form to edit classis english translation.
- Add classic english translation between an Hebrew word and the working translation.
- Change contextual click on a Hebrew word to use database instead of web search.

## Changelog

#### In progress - Version 3.0

- Switch from SQLite ODBC Driver to SQLite-Net with SQLitePCLraw nugets.
- Optimize overall performances.
- Add parashot board with literal translations, lettriqs, verses references, study tools, edition and export.
- Add online search a word for several providers : Pealim, Sefaria, Dict.com, Wiktionary, Google, Bing, Reverso, Glosbe.
- Add source Hebrew word in the search translated form.
- Add Ctrl+T shortcut to open the translated form the focused Hebrew word.
- Add Ctrl+K shortcut to open the search view for the focused Hebrew word.
- Add "Add translation (to a word)" action in the search translated form, in addition to the "use" action.
- Add "Add a bookmark" menu item.
- Add "Sort bookmarks" menu item.
- Add auto sort bookmarks option.
- Add new input panel from Hebrew Letters v4+.
- Add new advanced textbox for future undo/redo.
- Add optimize database menu.
- Add link to *hebrew.ch* shorashim database.
- Add menu for web links.
- Improve message boxes.
- Improve check update to allow auto update or direct download or open app web page.
- Improve check update to verify the SSL certificate of the website and the checksum of the setup file.
- Improve debugger to support logging.
- Improve exception form to view log.
- Improve UI/UX.
- Fix drop down menus shown on another monitor instead of the same screen.
- Fix error message when several SearchTranslatedForm are opened.
- Fix error message when typing in the comment boxes.
- Fix edit books information form : modifications are not saved since an old version.
- Replace simple internal command line parser by CommandLineParser NuGet package.
- Replace DocX 1.2 dependency by the NuGet package 1.4.1 version (the last being in MS-PL, up to 1.6 being proprietary and from 1.7 limited to 10 end-users).
- Add debugger and serilog tracing (exception information form with GitHub issue creation).
- The application now permanently lock database file while running.
- The application now automatically creates the ODBC DSN in the Windows registry.
- Move online providers values from code to files in the application documents folder.
- Move tanak text files in Documents in a dedicated folder.
- Add books common names field in the database and in the edit books information form.
- Add common code written since more than one year for Calendar.
- Files and code refactoring.
- Update to SQLite 3.32.3 ODBC Driver.
- Update to Framework .NET 4.7.2 and supported Windows only 7 SP1 or higher.
- Update setup.
- Update web links.
- Update help.

> TO CHECK
- Add option to open the last verse else the master bookmark else the first verse of the Tanak.
- Add open book menu item in the edit books information form.
- Add some context menu items in the edit books information form to search online, copy to clipboard and edit memo.
- Add keyboard shortcuts to open the books names editor, Hebrew Letters and Shorashon.
- Add option to enable debugger.
- Add option to set automatic web check update frequency.
- Add option to auto optimize database at startup once a week.
- Add show usage statistics from about box.
- Add check update from about box.

> IN PROGRESS
- Add book name translation text box in the navigation panel.
- Add chapter title and memo text boxes in the navigation panel.
- Add buttons to edit book and chapter memos in the navigation panel.
- Add options to filter the books in the go to reference form.
- Add keyboard shortcuts notice in windows settings menu.
- Add sounds to clipboard actions.
- Add option to enable or disable the web links menu.
- Add option to enable or disable message boxes sounds.
- Add option to enable or disable success dialogs.
- Add option to set application's volume.
- Add usage statistics form in tools menu.
- Change selection controls in the go to reference form.
- Improve open Hebrew Letters for the current word when focused on the verses view.
- Improve search to find words in chapters translated title.

> FUTURE

- Add bookmarks backup/restore.
- Add book memo and chapter title/memo in DOCX export.
- Add book name/translation/memo and chapter number/title/memo in RTF (translation) export.
- Add menu to open a batch export form.
- Add count the number of a word occurences.
- Add option to go to last reference on startup.
- Add option to choose double-click action on a word in the search translated form.

> VERY FUTURE
- Add word occurences calculator button in the search panel.
- Add option to change fonts size.
- Improve auto-backup to allow periodic archive as weekly or monthly
- Improve import console to support Hebrew unicode chars in addition to Hebrew font.
- Database updated to support internal strong concordance popup menus in the future.

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

- Add context menu on Hebrew words, on verses numbers and on search reference found.
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

- Add shortcut for Hebrew raw text view.
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