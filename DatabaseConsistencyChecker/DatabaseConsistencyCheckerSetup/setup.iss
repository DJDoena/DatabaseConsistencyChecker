[Setup]
AppName=DatabaseConsistencyChecker
AppId=DatabaseConsistencyChecker
AppVerName=DatabaseConsistencyChecker 1.1.3.0
AppCopyright=Copyright � Doena Soft. 2020
AppPublisher=Doena Soft.
; AppPublisherURL=http://doena-journal.net/en/dvd-profiler-tools/
DefaultDirName={commonpf64}\Doena Soft.\DatabaseConsistencyChecker
DefaultGroupName=DVD Profiler Database Consistency Checker
DirExistsWarning=No
SourceDir=..\DatabaseConsistencyChecker\bin\x64\DatabaseConsistencyChecker
Compression=zip/9
AppMutex=DatabaseConsistencyChecker
OutputBaseFilename=DatabaseConsistencyCheckerSetup
OutputDir=..\..\..\..\DatabaseConsistencyCheckerSetup\Setup\DatabaseConsistencyChecker
MinVersion=0,6.0
PrivilegesRequired=admin
WizardImageFile=compiler:wizmodernimage-is.bmp
WizardSmallImageFile=compiler:wizmodernsmallimage-is.bmp
DisableReadyPage=yes
ShowLanguageDialog=no
VersionInfoCompany=Doena Soft.
VersionInfoCopyright=2020
VersionInfoDescription=DatabaseConsistencyChecker Setup
VersionInfoVersion=1.1.3.0
UninstallDisplayIcon={app}\djdsoft.ico

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Messages]
WinVersionTooLowError=This program requires Windows XP or above to be installed.%n%nWindows 9x, NT and 2000 are not supported.

[Types]
Name: "full"; Description: "Full installation"

[Files]
Source: "djdsoft.ico"; DestDir: "{app}"; Flags: ignoreversion
Source: "DVDProfilerHelper.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "DVDProfilerHelper.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "DVDProfilerXML.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "DVDProfilerXML.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "DatabaseConsistencyChecker.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "DatabaseConsistencyChecker.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "DatabaseConsistencyCheckerLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "DatabaseConsistencyCheckerLib.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "DatabaseConsistencyCheckerLib.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "SampleConfiguration.xml"; DestDir: "{app}"; Flags: ignoreversion

Source: "de\DVDProfilerHelper.resources.dll"; DestDir: "{app}\de"; Flags: ignoreversion

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Database Consistency Checker"; Filename: "{app}\DatabaseConsistencyChecker.exe"; WorkingDir: "{app}"; IconFilename: "{app}\djdsoft.ico"
Name: "{commondesktop}\DVD Profiler Database Consistency Checker"; Filename: "{app}\DatabaseConsistencyChecker.exe"; WorkingDir: "{app}"; IconFilename: "{app}\djdsoft.ico"

[Run]

;[UninstallDelete]

[UninstallRun]

[Registry]

[Code]
function IsDotNET40Detected(): boolean;
// Function to detect dotNet framework version 2.0
// Returns true if it is available, false it's not.
var
dotNetStatus: boolean;
begin
dotNetStatus := RegKeyExists(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4');
Result := dotNetStatus;
end;

function InitializeSetup(): Boolean;
// Called at the beginning of the setup package.
begin

if not IsDotNET40Detected then
begin
MsgBox( 'The Microsoft .NET Framework version 4.0 is not installed. Please install it and try again.', mbInformation, MB_OK );
Result := false;
end
else
Result := true;
end;