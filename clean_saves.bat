@echo off
setlocal enabledelayedexpansion

REM Forward any arguments (e.g. -Mode bugged or -Mode all) to PowerShell
if "%1"=="--all" (
    powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0clean_saves.ps1" -Mode all
) else if "%1"=="-a" (
    powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0clean_saves.ps1" -Mode all
) else if "%1"=="--bugged" (
    powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0clean_saves.ps1" -Mode bugged
) else if "%1"=="-b" (
    powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0clean_saves.ps1" -Mode bugged
) else (
    powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0clean_saves.ps1"
)

echo.
pause
