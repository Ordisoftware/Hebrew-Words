#define MyAppVersion "4.0"
#define MyAppCopyright="Copyright 2012-2026 Olivier Rogier"
#define MyAppPublisher "Ordisoftware"
#define MyAppName "Hebrew Words"
#define MyAppNameNoSpace "HebrewWords"
#define MyAppExeName "Ordisoftware.Hebrew.Words.exe"
#define MyAppURL "https://www.ordisoftware.com/projects/hebrew-words"

[Setup]
AppId={{9D7815C4-E95E-48E7-9D2E-0CB5118BDC61}
;AppMutex=9117fa5b-51de-481e-9cb1-65a606d6ca69
#include "Scripts\Setup.iss"

[Languages]
#include "Scripts\Languages.iss"

[Dirs]

[InstallDelete]
#include "Scripts\InstallDelete.iss"

[Files]
#include "Scripts\Files.iss"
#include "Scripts\FilesHebrewFont.iss"

[Run]
#include "Scripts\Run.iss"

[Registry]

[Tasks]
#include "Scripts\Tasks.iss"

[Icons]
#include "Scripts\Icons.iss"

[CustomMessages]
#include "Scripts\Messages.iss"

[Code]
#include "Scripts\CheckDotNetFramework.iss"
