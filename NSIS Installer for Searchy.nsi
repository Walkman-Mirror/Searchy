; Searchy Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

AddBrandingImage top 20
Icon "Searchy\images\1398027695_33852.ico"
Caption "Searchy Installer"
Name "Searchy"
AutoCloseWindow true
ShowInstDetails show

InstallDir $PROGRAMFILES\DeavmiOSS\Searchy

OutFile "Searchy\bin\Release\Searchy-Installer.exe"

; Pages

Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "Searchy Executable & Uninstaller"
  SectionIn RO
  SetOutPath $INSTDIR
  File "Searchy\bin\Release\Searchy.exe"
  WriteUninstaller "Searchy-Uninst.exe"
SectionEnd

Section "Searchy Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\DeavmiOSS"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\Searchy.lnk" "$INSTDIR\Searchy.exe" "" "$INSTDIR\Searchy.exe" "" "" "" "Start Searchy"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\Uninstall Searchy.lnk" "$INSTDIR\Searchy-Uninst.exe" "" "" "" "" "" "Uninstall Searchy"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "Searchy Desktop Shortcut"
  CreateShortCut "$DESKTOP\Searchy.lnk" "$INSTDIR\Searchy.exe" "" "$INSTDIR\Searchy.exe" "" "" "" "Searchy"
SectionEnd

Section "Searchy Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\Searchy.lnk" "$INSTDIR\Searchy.exe" "" "$INSTDIR\Searchy.exe" "" "" "" "Searchy"
SectionEnd

;Section "More apps from DeavmiOSS"
; this should have sub options for available apps, that are downloaded
;SectionEnd

; Uninstaller

Section "Uninstall"
  Delete "$INSTDIR\Searchy-Uninst.exe"   ; Remove Application Files
  Delete "$INSTDIR\Searchy.exe"
  RMDir $INSTDIR
  
  Delete "$SMPROGRAMS\DeavmiOSS\Searchy.lnk"   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\DeavmiOSS\Uninstall Searchy.lnk"
  RMDir $SMPROGRAMS\DeavmiOSS
  
  Delete "$DESKTOP\Searchy.lnk"   ; Remove Desktop Shortcut
  Delete "$QUICKLAUNCH\Searchy.lnk"   ; Remove Quick Launch shortcut
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install Searchy. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetBrandingImage "[/RESIZETOFIT] 'Searchy\images\1398027695_33852.ico'"
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
  MessageBox MB_YESNO "Install Succeeded! Open Wiki?" IDNO NoReadme
    ExecShell "open" "https://github.com/Deavmi/Searchy/wiki"
  NoReadme:
FunctionEnd

; Uninstaller

Function un.onInit
  MessageBox MB_YESNO "This will uninstall Searchy. Do you wish to continue?" IDYES NoAbort
    Abort ; causes uninstaller to quit.
  NoAbort:
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function un.onUninstFailed
  MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
  MessageBox MB_OK "Uninstall Completed"
FunctionEnd
