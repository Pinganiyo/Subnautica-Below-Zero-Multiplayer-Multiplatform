@echo off
setlocal enabledelayedexpansion

echo ==========================================================
echo  Subnautica Below Zero Multiplayer - Windows Installer
echo ==========================================================

REM Detect Default Steam Game Path if not provided
if "%SUBNAUTICA_DIR%"=="" (
    set "GAME_DIR=C:\Program Files (x86)\Steam\steamapps\common\SubnauticaZero"
) else (
    set "GAME_DIR=%SUBNAUTICA_DIR%"
)

if not exist "%GAME_DIR%" (
    echo Subnautica: Below Zero not found at default location: "%GAME_DIR%"
    set /p "GAME_DIR=Please enter the path to your SubnauticaZero game folder: "
)

if not exist "%GAME_DIR%" (
    echo Error: Directory "%GAME_DIR%" does not exist.
    exit /b 1
)

echo Game directory: "%GAME_DIR%"

echo.
echo [1/4] Building mod in Release mode...
dotnet build "%~dp0Subnautica.Multiplayer.csproj" -c Release
if %ERRORLEVEL% neq 0 (
    echo Build failed!
    exit /b %ERRORLEVEL%
)

echo.
echo [2/4] Installing BepInEx to game folder...
xcopy /E /I /Y "%~dp0lib\BepInEx\*" "%GAME_DIR%\"

echo.
echo [3/4] Deploying compiled multiplayer mod assemblies...
set "PLUGIN_DIR=%GAME_DIR%\BepInEx\plugins\SubnauticaMultiplayer"
if not exist "%PLUGIN_DIR%" mkdir "%PLUGIN_DIR%"

copy /Y "%BUILD_DIR%\*.dll" "%PLUGIN_DIR%\"
copy /Y "%BUILD_DIR%\*.pdb" "%PLUGIN_DIR%\" 2>nul

if exist "%~dp0Data" (
    xcopy /E /I /Y "%~dp0Data\*" "%PLUGIN_DIR%\Data\"
)

echo.
echo [4/4] Setting up AppData directories...
if not exist "%APPDATA%\.botbenson\Subnautica Below Zero\Game\Plugins" (
    mkdir "%APPDATA%\.botbenson\Subnautica Below Zero\Game\Plugins"
    mkdir "%APPDATA%\.botbenson\Subnautica Below Zero\Game\Dependencies"
    mkdir "%APPDATA%\.botbenson\Subnautica Below Zero\Game\Logs"
    mkdir "%APPDATA%\.botbenson\Subnautica Below Zero\Game\Saves"
)

echo.
echo ==========================================================
echo  Installation Complete!
echo ==========================================================
echo You can now launch Subnautica: Below Zero from Steam or your desktop.
pause
