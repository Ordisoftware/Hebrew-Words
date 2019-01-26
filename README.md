# Hebrew Words

>This project follows the [Manufacturing Software Guidelines](https://github.com/Ordisoftware/Guidelines).

>Licensed under the terms of the [Mozilla Public License 2.0](LICENSE)<br/>
>[Project Website](http://www.ordisoftware.com/projects/hebrew-words)<br/>
>[Twitter](https://twitter.com/ordisoftware)<br/>

A tool for Windows written in C# that helps for the translation of the Bible's hebrew words.

## Functionalities

- Translate verses words by words.
- Left mouse click on a word to open online strong's definition.
- Right mouse click on a word to open Hebrew Letters.
- Original and translation views.
- Determine the equidistant letter sequence of 50 for Tav.
- Show statistics.
- English, French.

## Requirements

- Windows Vista x32/x64 or superior
- Screen 1024x768 or superior
- Framework .NET 3.5 or superior
- [SQLite ODBC Driver](http://www.ch-werner.de/sqliteodbc/)

## Screenshots

![verses Tab](http://www.ordisoftware.com/uploads/2019/01/hebrew-words-verses.png)

![Translations Tab](http://www.ordisoftware.com/uploads/2019/01/hebrew-words-translations.png)

## Videos

[![Showing video](https://img.youtube.com/vi/dYFQS4PP0ws/0.jpg)](https://www.youtube.com/watch?v=dYFQS4PP0ws)

## Frequently asked questions

#### How to install SQlite ODBC Driver?

- [sqliteodbc.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc.exe) must be installed on Windows 32-bit.
- [sqliteodbc.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc.exe) and [sqliteodbc_w64.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc_w64.exe) must be installed on Windows 64-bit.

#### What to do in case of ODBC datasource connection error?

The setup tries to register an ODBC DSN to the registry but in case of problem run "C:\Program Files\Ordisoftware\Hebrew Letters\Register ODBC.reg" or open the ODBC datasource manager (Admin tools in Windows' Control panel) and create a user datasource named "Hebrew-Letters" for "SQLite 3 ODBC Driver" with "Database Name" sets to:

"%USERPROFILE%\AppData\Roaming\Ordisoftware\Hebrew Letters\Hebrew-Letters.sqlite"

Watch the [video](https://www.youtube.com/watch?v=WPVF8pj9I3E).

## Changelog

#### Year.Month.Day - Version 1.0

- Initial release.