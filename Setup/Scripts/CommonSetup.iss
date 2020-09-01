AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppPublisher} {#MyAppName} {#MyAppVersion}
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
Compression=lzma2/max
SolidCompression=true
ChangesAssociations=true
ShowTasksTreeLines=true
VersionInfoVersion={#MyAppVersion}
VersionInfoCompany={#MyAppPublisher}
VersionInfoDescription={#MyAppPublisher} {#MyAppName}
PrivilegesRequired=admin
InternalCompressLevel=normal
DisableStartupPrompt=false
MinVersion=0,6.1sp1
ArchitecturesAllowed=x86 x64 ia64
ArchitecturesInstallIn64BitMode=x64 ia64
WizardStyle=Modern
