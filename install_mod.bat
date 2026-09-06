@echo off
setlocal enabledelayedexpansion

echo ==========================================================
echo  Subnautica Below Zero Multiplayer - Windows Installer
echo ==========================================================

REM Ensure user-installed dotnet is in PATH
if exist "%LocalAppData%\Microsoft\dotnet" (
    set "PATH=%LocalAppData%\Microsoft\dotnet;%PATH%"
)

REM Detect Default Steam Game Path if not provided
if "%SUBNAUTICA_DIR%"=="" (
    if exist "C:\Program Files (x86)\Steam\steamapps\common\SubnauticaZero" (
        set "GAME_DIR=C:\Program Files (x86)\Steam\steamapps\common\SubnauticaZero"
    ) else if exist "D:\SteamLibrary\steamapps\common\SubnauticaZero" (
        set "GAME_DIR=D:\SteamLibrary\steamapps\common\SubnauticaZero"
    ) else if exist "E:\SteamLibrary\steamapps\common\SubnauticaZero" (
        set "GAME_DIR=E:\SteamLibrary\steamapps\common\SubnauticaZero"
    ) else (
        set "GAME_DIR=C:\Program Files (x86)\Steam\steamapps\common\SubnauticaZero"
    )
) else (
    set "GAME_DIR=%SUBNAUTICA_DIR%"
)

if not exist "%GAME_DIR%" (
    echo Subnautica: Below Zero not found at default location: "%GAME_DIR%"
    set /p "GAME_DIR=Please enter the path to your SubnauticaZero game folder: "
    REM Strip surrounding quotes if user entered them
    set "GAME_DIR=!GAME_DIR:"=!"
)

if not exist "%GAME_DIR%" (
    echo Error: Directory "%GAME_DIR%" does not exist.
    exit /b 1
)

echo Game directory: "%GAME_DIR%"

echo.
echo [1/4] Building mod in Release mode...
dotnet build "%~dp0Subnautica.Multiplayer.csproj" -c Release -p:GameManagedPath="%GAME_DIR%\SubnauticaZero_Data\Managed"
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
set "BUILD_DIR=%~dp0bin\Release\netstandard2.0"
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
