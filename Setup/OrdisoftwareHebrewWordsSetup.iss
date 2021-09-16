#define MyAppVersion "3.0"
#define MyAppName "Hebrew Words"
#define MyAppNameNoSpace "HebrewWords"
#define MyAppExeName "Ordisoftware.Hebrew.Words.exe"
#define MyAppPublisher "Ordisoftware"
#define MyAppURL "https://www.ordisoftware.com/projects/hebrew-words"

[Setup]
AppCopyright=Copyright 2012-2021 Olivier Rogier
AppId={{9D7815C4-E95E-48E7-9D2E-0CB5118BDC61}
;AppMutex=9117fa5b-51de-481e-9cb1-65a606d6ca69
#include "Scripts\Setup.iss"

[Languages]
#include "Scripts\Languages.iss"

[CustomMessages]
#include "Scripts\Messages.iss"

[Tasks]
#include "Scripts\Tasks.iss"


[Dirs]

[InstallDelete]
#include "Scripts\InstallDelete.iss"

[Files]
#include "Scripts\Files.iss"

[Icons]
#include "Scripts\Icons.iss"


[Registry]


[Run]
#include "Scripts\Run.iss"

[Code]
#include "Scripts\CheckDotNetFramework.iss"
