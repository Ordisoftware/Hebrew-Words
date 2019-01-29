# Hebrew Words

>This project follows the [Manufacturing Software Guidelines](https://github.com/Ordisoftware/Guidelines).

>Licensed under the terms of the [Mozilla Public License 2.0](LICENSE)<br/>
>[Project Website](http://www.ordisoftware.com/projects/hebrew-words)<br/>
>[Twitter](https://twitter.com/ordisoftware)<br/>

A tool for Windows written in C# that helps for the translation of the Bible's hebrew words.

## Functionalities

- Translate verses words by words.
- Left mouse click on a word to open online strong's concordance.
- Right mouse click on a word to open Hebrew Letters.
- Click on a verse number to open online text with contextual strong's concordances.
- Determine the equidistant letter sequence of 50 for Tav.
- Search a word.
- Show statistics.
- MS Word export.
- English, French.

## Requirements

- Windows Vista x32/x64 or superior
- Screen 1024x768 or superior
- Framework .NET 4.5 or superior
- [SQLite ODBC Driver](http://www.ch-werner.de/sqliteodbc/)

## Screenshots

![verses Tab](http://www.ordisoftware.com/uploads/2019/01/hebrew-words-verses.png)

![Translations Tab](http://www.ordisoftware.com/uploads/2019/01/hebrew-words-translations.png)

![Stats Tab](http://www.ordisoftware.com/uploads/2019/01/hebrew-words-stats.png)

## Videos

[![Showing video](https://img.youtube.com/vi/dYFQS4PP0ws/0.jpg)](https://www.youtube.com/watch?v=dYFQS4PP0ws)

## Frequently asked questions

#### How to install SQlite ODBC Driver?

- [sqliteodbc.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc.exe) must be installed on Windows 32-bit.
- [sqliteodbc.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc.exe) and [sqliteodbc_w64.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc_w64.exe) must be installed on Windows 64-bit.

#### What to do in case of ODBC datasource connection error?

The setup tries to register an ODBC DSN to the registry but in case of problem run "C:\Program Files\Ordisoftware\Hebrew Words\Register ODBC.reg" or open the ODBC datasource manager (Admin tools in Windows' Control panel) and create a user datasource named "Hebrew-Words" for "SQLite 3 ODBC Driver" with "Database Name" sets to:

"%USERPROFILE%\AppData\Roaming\Ordisoftware\Hebrew Words\Hebrew-Words.sqlite"

Watch the [video](https://www.youtube.com/watch?v=WPVF8pj9I3E).

## Changelog

#### 2019.__.__ - Version 1.2

- Add word docx export.

#### 2019.01.28 - Version 1.1

- Add books names translation form.
- Add search a word.
- Add open verse online.
- Add verse comment edition.
- Some improvments.

#### 2019.01.26 - Version 1.0

- Initial release.