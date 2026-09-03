@echo off
setlocal enabledelayedexpansion

:: Define game installation path
set "GAME_PATH=C:\Games\Steam\steamapps\common\Terra Invicta"

:: Define files to manage
set "FILE1=%GAME_PATH%\TerraInvicta_Data\boot.config"
set "FILE2=%GAME_PATH%\MonoBleedingEdge\EmbedRuntime\mono-2.0-bdwgc.dll"
set "FILE3=%GAME_PATH%\UnityPlayer.dll"

:: Clear screen
cls

echo.
echo ========================================
echo Terra Invicta Game Files Switcher
echo ========================================
echo.
echo This script will switch game files between debug (dbg) and original (orig) versions.
echo.

:: Get user input
:input_loop
set /p "VERSION=Enter version (dbg or orig): "

if /i "!VERSION!"=="dbg" (
	set "PREFIX=boot-dbg"
	set "DLL_PREFIX=mono-2.0-bdwgc-dbg"
	set "UNITY_PREFIX=UnityPlayer-dbg"
	echo.
	echo Switching to DEBUG version...
	goto proceed
) else if /i "!VERSION!"=="orig" (
	set "PREFIX=boot-orig"
	set "DLL_PREFIX=mono-2.0-bdwgc-orig"
	set "UNITY_PREFIX=UnityPlayer-orig"
	echo.
	echo Switching to ORIGINAL version...
	goto proceed
) else (
	echo.
	echo ERROR: Invalid input. Please enter 'dbg' or 'orig'.
	echo.
	goto input_loop
)

:proceed
echo.

:: Function to switch a file
call :switch_file "!FILE1!" "boot.config" "!PREFIX!.config"
call :switch_file "!FILE2!" "mono-2.0-bdwgc.dll" "!DLL_PREFIX!.dll"
call :switch_file "!FILE3!" "UnityPlayer.dll" "!UNITY_PREFIX!.dll"

echo.
echo ========================================
echo File switching complete!
echo ========================================
echo.
pause
exit /b 0

:switch_file
set "DEST_FILE=%~1"
set "FILE_NAME=%~2"
set "SOURCE_FILE=%~3"
set "SOURCE_PATH=%GAME_PATH%\!SOURCE_FILE!"

:: Adjust path for boot.config files
if "!FILE_NAME!"=="boot.config" (
	set "SOURCE_PATH=%GAME_PATH%\TerraInvicta_Data\!SOURCE_FILE!"
)

:: Adjust path for mono-2.0-bdwgc.dll files
if "!FILE_NAME!"=="mono-2.0-bdwgc.dll" (
	set "SOURCE_PATH=%GAME_PATH%\MonoBleedingEdge\EmbedRuntime\!SOURCE_FILE!"
)

echo Processing: !FILE_NAME!

:: Check if source file exists
if not exist "!SOURCE_PATH!" (
	echo   ERROR: Source file not found - !SOURCE_PATH!
	exit /b 1
)

:: Delete the original file if it exists
if exist "!DEST_FILE!" (
	echo   Deleting: !DEST_FILE!
	del /f /q "!DEST_FILE!" >nul 2>&1
	if !errorlevel! neq 0 (
		echo   ERROR: Failed to delete !DEST_FILE!
		exit /b 1
	)
)

:: Copy the versioned file and rename it
echo   Copying from: !SOURCE_PATH!
copy /y "!SOURCE_PATH!" "!DEST_FILE!" >nul
if !errorlevel! neq 0 (
	echo   ERROR: Failed to copy !SOURCE_PATH!
	exit /b 1
)
echo   Success: !FILE_NAME! switched to !VERSION!
echo.

exit /b 0
