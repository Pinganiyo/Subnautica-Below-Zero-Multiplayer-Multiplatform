<#
.SYNOPSIS
    Cleans corrupted/incomplete or all Subnautica: Below Zero multiplayer saves.
.DESCRIPTION
    Scans %APPDATA%\.botbenson\Subnautica Below Zero\Game\Saves for servers and client saves.
    Can clean only incomplete saves (missing World.bin) or wipe all saves for a clean state.
.PARAMETER Mode
    'bugged' (default) - Deletes only saves that lack World.bin data.
    'all' - Deletes all multiplayer server and client saves.
#>
param(
    [ValidateSet('bugged', 'all', 'prompt')]
    [string]$Mode = 'prompt'
)

$ErrorActionPreference = 'Stop'

$appData = [Environment]::GetFolderPath('ApplicationData')
$savesDir = Join-Path $appData '.botbenson\Subnautica Below Zero\Game\Saves'
$serverDir = Join-Path $savesDir 'Server'
$clientDir = Join-Path $savesDir 'Client'

Write-Host "==========================================================" -ForegroundColor Cyan
Write-Host " Subnautica: Below Zero Multiplayer - Save Cleanup Tool" -ForegroundColor Cyan
Write-Host "==========================================================" -ForegroundColor Cyan
Write-Host ""

if (-not (Test-Path $serverDir)) {
    Write-Host "No server saves found at: $serverDir" -ForegroundColor Yellow
    exit 0
}

# Scan server directories
$serverFolders = Get-ChildItem -Path $serverDir -Directory
$buggedSaves = @()
$validSaves = @()

foreach ($folder in $serverFolders) {
    $worldFile = Join-Path $folder.FullName 'World.bin'
    if (-not (Test-Path $worldFile)) {
        $buggedSaves += $folder
    } else {
        $validSaves += $folder
    }
}

$statusColor = if ($buggedSaves.Count -gt 0) { 'Red' } else { 'Green' }
Write-Host "Status of Saved Games:" -ForegroundColor White
Write-Host "  - Bugged / Incomplete saves (missing World.bin) : $($buggedSaves.Count)" -ForegroundColor $statusColor
Write-Host "  - Valid saves (contain World.bin)               : $($validSaves.Count)" -ForegroundColor Green
Write-Host ""

if ($Mode -eq 'prompt') {
    Write-Host "Choose cleanup option:" -ForegroundColor Yellow
    Write-Host "  [1] Delete ONLY bugged / incomplete saves (Recommended)" -ForegroundColor Cyan
    Write-Host "  [2] Delete ALL multiplayer saves (Completely clean slate)" -ForegroundColor Red
    Write-Host "  [3] Cancel" -ForegroundColor Gray
    Write-Host ""
    $choice = Read-Host "Select an option [1-3]"
    switch ($choice.Trim()) {
        '1' { $Mode = 'bugged' }
        '2' { $Mode = 'all' }
        default {
            Write-Host "Operation cancelled." -ForegroundColor Yellow
            exit 0
        }
    }
}

if ($Mode -eq 'bugged') {
    if ($buggedSaves.Count -eq 0) {
        Write-Host "No bugged saves found to delete." -ForegroundColor Green
        exit 0
    }

    Write-Host "Deleting $($buggedSaves.Count) bugged saves..." -ForegroundColor Yellow
    foreach ($save in $buggedSaves) {
        Write-Host "  Removing incomplete save: $($save.Name)" -ForegroundColor Gray
        # Also check and remove matching client save if incomplete
        $matchingClient = Join-Path $clientDir $save.Name
        if (Test-Path $matchingClient) {
            Remove-Item -Path $matchingClient -Recurse -Force -ErrorAction SilentlyContinue
        }
        Remove-Item -Path $save.FullName -Recurse -Force -ErrorAction SilentlyContinue
    }
    Write-Host ""
    Write-Host "Successfully deleted $($buggedSaves.Count) bugged saves!" -ForegroundColor Green
}
elseif ($Mode -eq 'all') {
    Write-Host "Deleting ALL multiplayer saves..." -ForegroundColor Red
    if (Test-Path $serverDir) {
        Get-ChildItem -Path $serverDir -Directory | ForEach-Object {
            Write-Host "  Removing server save: $($_.Name)" -ForegroundColor Gray
            Remove-Item -Path $_.FullName -Recurse -Force -ErrorAction SilentlyContinue
        }
    }
    if (Test-Path $clientDir) {
        Get-ChildItem -Path $clientDir -Directory | ForEach-Object {
            Write-Host "  Removing client save: $($_.Name)" -ForegroundColor Gray
            Remove-Item -Path $_.FullName -Recurse -Force -ErrorAction SilentlyContinue
        }
    }
    Write-Host ""
    Write-Host "All multiplayer saves have been deleted." -ForegroundColor Green
}

Write-Host ""
Write-Host "Done." -ForegroundColor Cyan
