; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Hebrew Words"
#define MyAppNameNoSpace "HebrewWords"
#define MyAppVersion "3.0"
#define MyAppPublisher "Ordisoftware"
#define MyAppURL "https://www.ordisoftware.com/projects/hebrew-words"
#define MyAppExeName "Ordisoftware.HebrewWords.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{9D7815C4-E95E-48E7-9D2E-0CB5118BDC61}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppPublisher} {#MyAppName} {#MyAppVersion}
AppCopyright=Copyright 2012-2020 Olivier Rogier
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
UninstallFilesDir={app}\Uninstall
DefaultDirName={commonpf}\{#MyAppPublisher}\{#MyAppName}
DefaultGroupName={#MyAppPublisher}
AllowNoIcons=true
LicenseFile=..\Project\License\MPL 2.0.rtf
InfoBeforeFile=
OutputDir=.\
OutputBaseFilename={#MyAppPublisher}{#MyAppNameNoSpace}Setup-{#MyAppVersion}
SetupIconFile=
Compression=lzma
SolidCompression=true
ChangesAssociations=true
ShowTasksTreeLines=true
VersionInfoVersion={#MyAppVersion}
VersionInfoCompany={#MyAppPublisher}
VersionInfoDescription={#MyAppPublisher} {#MyAppName}
PrivilegesRequired=admin
InternalCompressLevel=normal
ArchitecturesAllowed=x86 x64 ia64
ArchitecturesInstallIn64BitMode=x64 ia64
DisableStartupPrompt=false
MinVersion=0,6.1sp1

[Languages]
Name: english; MessagesFile: compiler:Default.isl
Name: french; MessagesFile: compiler:Languages\French.isl

[CustomMessages]
english.DotNetRequired_msg=Install .NET Framework 4.7.2
french.DotNetRequired_msg=Installer .NET Framework 4.7.2
english.DotNetInstalling_msg=Microsoft Framework 4.7.2 is being installed. Please wait...
french.DotNetInstalling_msg=Microsoft Framework 4.7.2 est en cours d'installation. Veuillez patienter...
english.RunSettings_msg=Modify application settings
french.RunSettings_msg=Modifier les param�tres de l'application
english.HelpFile_msg=Documentation of %1
french.HelpFile_msg=Documentation de %1
english.LicenseFile_msg=License of %1
french.LicenseFile_msg=Licence de %1
english.SourceCode_msg=Source code of %1
french.SourceCode_msg=Code source de %1
english.StartWithWindows_msg=Start with Windows
french.StartWithWindows_msg=D�marrer avec Windows
english.OpenSQLiteODBC_msg=Install or update SQLite ODBC Driver
french.OpenSQLiteODBC_msg=Installer ou mettre � jour SQLite ODBC Driver

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked


[Dirs]

[InstallDelete]
Name: {app}\*; Type: files
Name: {app}\Bin\*; Type: filesandordirs
Name: {app}\Documents\*; Type: filesandordirs
Name: {app}\Help\*; Type: filesandordirs
Name: {app}\Project\*; Type: filesandordirs
Name: {app}\Setup\*; Type: filesandordirs
Name: {app}\{cm:LaunchProgram,{#MyAppName}}.*; Type: files
Name: {group}\{cm:LaunchProgram,{#MyAppName}}.*; Type: files


[Files]
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: *; DestDir: {app}\Setup; Flags: ignoreversion recursesubdirs; Excludes: *.---, *.bak,  *.bak, *.suo, *.user, obj, .vs, {#MyAppPublisher}{#MyAppNameNoSpace}Setup*.exe
Source: ..\*; DestDir: {app}; Flags: ignoreversion
Source: ..\Bin\Release\*.exe; DestDir: {app}\Bin; Flags: ignoreversion recursesubdirs; Excludes: *vshost.exe
Source: ..\Bin\Release\*.dll; DestDir: {app}\Bin; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist
Source: ..\Bin\Release\*.pdb; DestDir: {app}\Bin; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist
Source: ..\Bin\Release\*.xml; DestDir: {app}\Bin; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist
Source: ..\Documents\*; DestDir: {app}\Documents; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist
Source: ..\Help\*; DestDir: {app}\Help; Excludes: *.bak; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist
Source: ..\Project\*; DestDir: {app}\Project; Flags: ignoreversion recursesubdirs; Excludes: *.psess, *.vsp, *.bak, *.suo, *.user, obj, .vs
Source: ..\Project\Dependencies\Font\Hebrew.ttf; DestDir: {fonts}; FontInstall: Hebrew Normal; Flags: onlyifdoesntexist uninsneveruninstall


[Icons]
Name: {commondesktop}\{#MyAppPublisher} {#MyAppName}; Filename: {app}\Bin\{#MyAppExeName}; Tasks: desktopicon; IconFilename: {app}\Application.ico
;Name: {app}\{#MyAppName}; Filename: {app}\Bin\{#MyAppExeName}; IconFilename: {app}\Application.ico
Name: {group}\{#MyAppName}; Filename: {app}\Bin\{#MyAppExeName}; IconFilename: {app}\Application.ico
Name: {group}\{cm:ProgramOnTheWeb,{#MyAppPublisher}}; Filename: {app}\Ordisoftware.com.url; IconFilename: {app}\Project\Dependencies\Fatcow\house.ico
Name: {group}\{#MyAppName}\{cm:SourceCode_msg,{#MyAppName}}; Filename: {app}\Project; IconFilename: {app}\Project\Dependencies\Fatcow\page_white_csharp.ico; WorkingDir: {app}\Project
Name: {group}\{#MyAppName}\{cm:HelpFile_msg,{#MyAppName}}; Filename: {app}\Help\index.htm; IconFilename: {app}\Project\Dependencies\Fatcow\help.ico
Name: {group}\{#MyAppName}\{cm:LicenseFile_msg,{#MyAppName}}; Filename: {app}\Project\License\MPL 2.0.htm; IconFilename: {app}\Project\Dependencies\Fatcow\info_rhombus.ico
Name: {group}\{#MyAppName}\{cm:ProgramOnTheWeb,{#MyAppName}}; Filename: {app}\{#MyAppName}.url; IconFilename: {app}\Project\Dependencies\Fatcow\house.ico
Name: {group}\{#MyAppName}\{cm:UninstallProgram,{#MyAppName}}; Filename: {uninstallexe}
Name: {group}\{#MyAppName}\Register {#MyAppName} ODBC Datasource; Filename: {app}\Register ODBC.reg


[Run]
Filename: {app}\Setup\.NET\NDP472-KB4054531-Web.exe; Check: CheckForFramework; StatusMsg: {cm:DotNetInstalling_msg}; Parameters: /q /norestart
Filename: {app}\Setup\SQLiteODBCInstaller\SQLiteODBCInstaller.exe
Filename: c:\Windows\regedit.exe; Parameters: "/s ""{app}\Register ODBC.reg"""
Filename: {app}\Bin\{#MyAppExeName}; Description: {cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}; Flags: nowait postinstall

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

function IsDotNetDetected(version: string; service: cardinal): boolean;
// Indicates whether the specified version and service pack of the .NET Framework is installed.
//
// version -- Specify one of these strings for the required .NET Framework version:
//    'v1.1'          .NET Framework 1.1
//    'v2.0'          .NET Framework 2.0
//    'v3.0'          .NET Framework 3.0
//    'v3.5'          .NET Framework 3.5
//    'v4\Client'     .NET Framework 4.0 Client Profile
//    'v4\Full'       .NET Framework 4.0 Full Installation
//    'v4.5'          .NET Framework 4.5
//    'v4.5.1'        .NET Framework 4.5.1
//    'v4.5.2'        .NET Framework 4.5.2
//    'v4.6'          .NET Framework 4.6
//    'v4.6.1'        .NET Framework 4.6.1
//    'v4.6.2'        .NET Framework 4.6.2
//    'v4.7'          .NET Framework 4.7
//    'v4.7.1'        .NET Framework 4.7.1
//    'v4.7.2'        .NET Framework 4.7.2
//    'v4.8'          .NET Framework 4.8
//
// service -- Specify any non-negative integer for the required service pack level:
//    0               No service packs required
//    1, 2, etc.      Service pack 1, 2, etc. required
var
    key, versionKey: string;
    install, release, serviceCount, versionRelease: cardinal;
    success: boolean;
begin
    versionKey := version;
    versionRelease := 0;

    // .NET 1.1 and 2.0 embed release number in version key
    if version = 'v1.1' then begin
        versionKey := 'v1.1.4322';
    end else if version = 'v2.0' then begin
        versionKey := 'v2.0.50727';
    end

    // .NET 4.5 and newer install as update to .NET 4.0 Full
    else if Pos('v4.', version) = 1 then begin
        versionKey := 'v4\Full';
        case version of
          'v4.5':   versionRelease := 378389;
          'v4.5.1': versionRelease := 378675; // 378758 on Windows 8 and older
          'v4.5.2': versionRelease := 379893;
          'v4.6':   versionRelease := 393295; // 393297 on Windows 8.1 and older
          'v4.6.1': versionRelease := 394254; // 394271 before Win10 November Update
          'v4.6.2': versionRelease := 394802; // 394806 before Win10 Anniversary Update
          'v4.7':   versionRelease := 460798; // 460805 before Win10 Creators Update
          'v4.7.1': versionRelease := 461308; // 461310 before Win10 Fall Creators Update
          'v4.7.2': versionRelease := 461808; // 461814 before Win10 April 2018 Update
          'v4.8':   versionRelease := 528040; // 528049 before Win10 May 2019 Update
        end;
    end;

    // installation key group for all .NET versions
    key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\' + versionKey;

    // .NET 3.0 uses value InstallSuccess in subkey Setup
    if Pos('v3.0', version) = 1 then begin
        success := RegQueryDWordValue(HKLM, key + '\Setup', 'InstallSuccess', install);
    end else begin
        success := RegQueryDWordValue(HKLM, key, 'Install', install);
    end;

    // .NET 4.0 and newer use value Servicing instead of SP
    if Pos('v4', version) = 1 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Servicing', serviceCount);
    end else begin
        success := success and RegQueryDWordValue(HKLM, key, 'SP', serviceCount);
    end;

    // .NET 4.5 and newer use additional value Release
    if versionRelease > 0 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Release', release);
        success := success and (release >= versionRelease);
    end;

    result := success and (install = 1) and (serviceCount >= service);
end;

function CheckForFramework(): Boolean;
begin
    result := not IsDotNetDetected('v4.7.2', 0);
end;

function UpdateReadyMemo(Space, NewLine, MemoUserInfoInfo, MemoDirInfo, MemoTypeInfo, MemoComponentsInfo, MemoGroupInfo, MemoTasksInfo: String): String;
var
	s: string;
begin
	s := MemoDirInfo;
  if ( MemoGroupInfo <> '' ) then
		s := s + NewLine + NewLine + MemoGroupInfo;
  if ( MemoTasksInfo <> '' ) then
		s := s + NewLine + NewLine + MemoTasksInfo;
  if ( CheckForFramework() ) then
  begin
		s := s + NewLine + NewLine + ExpandConstant('{cm:DotNetRequired_msg}');
  end;
	Result := s + NewLine + NewLine + ExpandConstant('{cm:OpenSQLiteODBC_msg}');
end;
