@echo off
setlocal enabledelayedexpansion

REM CreepingBorders Deployment Script
REM Copies compiled artifacts to the mod directory only if source is newer
REM Deletes cache files from the mod directory

set "sourceDir=C:\Users\Chris\source\repos\CreepingBorders"
set "targetDir=C:\Games\Steam\steamapps\common\Terra Invicta\Mods\Enabled\What's Yours Is Mine"

echo.
echo ===============================================
echo  CreepingBorders Deployment
echo ===============================================
echo.

REM Verify source directory exists
if not exist "!sourceDir!" (
	echo ERROR: Source directory not found: !sourceDir!
	pause
	exit /b 1
)

REM Create target directory if it doesn't exist
if not exist "!targetDir!" (
	echo [*] Creating mod directory...
	mkdir "!targetDir!"
	echo [+] Mod directory created
)

REM Clean cache files from previous runs
echo [*] Cleaning cache files...
if exist "!targetDir!\Cache" (
	rmdir /s /q "!targetDir!\Cache" 2>nul
	echo [+] Cache directory deleted
)

REM Clean temporary and cache files
for /f "delims=" %%F in ('dir /b "!targetDir!\*.tmp" 2^>nul') do (
	del /q "!targetDir!\%%F" 2>nul
)
for /f "delims=" %%F in ('dir /b "!targetDir!\*.cache" 2^>nul') do (
	del /q "!targetDir!\%%F" 2>nul
	echo [+] Deleted cache file: %%F
)

REM Deploy DLL (only if source is newer)
echo [*] Deploying CreepingBorders.dll...
if not exist "!sourceDir!\bin\Debug\CreepingBorders.dll" (
	echo [!] ERROR: DLL not found at !sourceDir!\bin\Debug\CreepingBorders.dll
	echo [!] Please ensure the project has been built in Debug configuration
	pause
	exit /b 1
)
xcopy /D /Y "!sourceDir!\bin\Debug\CreepingBorders.dll" "!targetDir!\" >nul 2>&1
if !errorlevel! equ 1 (
	echo [+] DLL deployed (newer version copied)
) else (
	echo [~] DLL already current
)

REM Deploy ModInfo.json (only if source is newer)
echo [*] Deploying ModInfo.json...
if not exist "!sourceDir!\ModInfo.json" (
	echo [!] ERROR: ModInfo.json not found
	pause
	exit /b 1
)
xcopy /D /Y "!sourceDir!\ModInfo.json" "!targetDir!\" >nul 2>&1
if !errorlevel! equ 1 (
	echo [+] ModInfo.json deployed (newer version copied)
) else (
	echo [~] ModInfo.json already current
)

REM Deploy localization files (only if source is newer)
echo [*] Checking for localization files...
if not exist "!targetDir!\Localization\en" (
	mkdir "!targetDir!\Localization\en"
	echo [+] Created localization directory structure
)

REM Use absolute path and simplified check
set "locSourceFile=C:\Users\Chris\source\repos\CreepingBorders\UINation.en"
for %%F in ("!locSourceFile!") do if exist "%%F" (
	xcopy /D /Y "%%F" "!targetDir!\Localization\en\" >nul 2>&1
	if !errorlevel! equ 1 (
		echo [+] UINation.en deployed to Localization/en/
	) else (
		echo [~] UINation.en already current
	)
)
if not exist "!targetDir!\Localization\en\UINation.en" (
	if exist "!locSourceFile!" (
		echo [!] WARNING: Direct copy required
		copy "!locSourceFile!" "!targetDir!\Localization\en\UINation.en" >nul
		echo [+] UINation.en copied successfully
	)
)

echo.
echo ===============================================
echo [+] Deployment Complete
echo ===============================================
echo.
echo Target directory: !targetDir!
echo.