#define MyAppVersion "3.0"
#define MyAppName "Hebrew Words"
#define MyAppNameNoSpace "HebrewWords"
#define MyAppExeName "Ordisoftware.HebrewWords.exe"
#define MyAppPublisher "Ordisoftware"
#define MyAppURL "https://www.ordisoftware.com/projects/hebrew-words"

[Setup]
AppId={{9D7815C4-E95E-48E7-9D2E-0CB5118BDC61}
AppMutex=9117fa5b-51de-481e-9cb1-65a606d6ca69
AppCopyright=Copyright 2012-2020 Olivier Rogier
#include "Scripts\CommonSetup.iss"

#include "Scripts\CommonMessages.iss"

[Tasks]
#include "Scripts\CommonTasks.iss"


[Dirs]

[InstallDelete]
#include "Scripts\CommonInstallDelete.iss"

[Files]
#include "Scripts\CommonFiles.iss"

[Icons]
#include "Scripts\CommonIcons.iss"


[Run]
#include "Scripts\CommonRun.iss"

[Code]
procedure CurStepChanged(CurStep: TSetupStep);
var
	filename, sourcepath, destpath : string;
begin
	case CurStep of
		// executed just before installation starts
    ssInstall:
    begin
      sourcepath := ExpandConstant('{app}') + '\Bin\';
      destpath := ExpandConstant('{userappdata}') + '\{#MyAppPublisher}\{#MyAppName}\';
      filename := 'Bookmarks.txt';
			if FileExists(sourcepath + filename) then
			begin
				RenameFile(sourcepath + filename, destpath + filename);
			end;
      filename := 'History.txt';
			if FileExists(sourcepath + filename) then
			begin
				RenameFile(sourcepath + filename, destpath + filename);
			end;
    end;
		// executed just after the installation finishes
		ssPostInstall:
		begin
		end;
  end;
end;

#include "Scripts\CheckDotNetFramework.iss"
