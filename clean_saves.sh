#!/usr/bin/env bash
set -e

# Detect wine / steam proton AppData if on Linux
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

if [ -n "$APPDATA" ]; then
    SAVES_DIR="$APPDATA/.botbenson/Subnautica Below Zero/Game/Saves"
elif [ -d "$HOME/.steam/steam/steamapps/compatdata/848450/pfx/drive_c/users/steamuser/AppData/Roaming/.botbenson/Subnautica Below Zero/Game/Saves" ]; then
    SAVES_DIR="$HOME/.steam/steam/steamapps/compatdata/848450/pfx/drive_c/users/steamuser/AppData/Roaming/.botbenson/Subnautica Below Zero/Game/Saves"
else
    SAVES_DIR="$HOME/.wine/drive_c/users/$USER/AppData/Roaming/.botbenson/Subnautica Below Zero/Game/Saves"
fi

SERVER_DIR="$SAVES_DIR/Server"
CLIENT_DIR="$SAVES_DIR/Client"

echo "=========================================================="
echo " Subnautica: Below Zero Multiplayer - Save Cleanup Tool"
echo "=========================================================="
echo ""

if [ ! -d "$SERVER_DIR" ]; then
    echo "No server saves found at: $SERVER_DIR"
    exit 0
fi

MODE="${1:-prompt}"

if [ "$MODE" = "prompt" ]; then
    echo "Choose cleanup option:"
    echo "  [1] Delete ONLY bugged / incomplete saves (missing World.bin)"
    echo "  [2] Delete ALL multiplayer saves (Clean slate)"
    echo "  [3] Cancel"
    read -p "Select an option [1-3]: " choice
    case "$choice" in
        1) MODE="bugged" ;;
        2) MODE="all" ;;
        *) echo "Cancelled."; exit 0 ;;
    esac
fi

if [ "$MODE" = "bugged" ] || [ "$MODE" = "--bugged" ] || [ "$MODE" = "-b" ]; then
    echo "Scanning for incomplete saves in $SERVER_DIR..."
    count=0
    for save in "$SERVER_DIR"/*; do
        if [ -d "$save" ] && [ ! -f "$save/World.bin" ]; then
            save_name=$(basename "$save")
            echo "  Removing incomplete save: $save_name"
            rm -rf "$save"
            rm -rf "$CLIENT_DIR/$save_name"
            count=$((count + 1))
        fi
    done
    echo "Deleted $count incomplete saves."
elif [ "$MODE" = "all" ] || [ "$MODE" = "--all" ] || [ "$MODE" = "-a" ]; then
    echo "Removing ALL multiplayer saves..."
    rm -rf "$SERVER_DIR"/*
    rm -rf "$CLIENT_DIR"/*
    echo "All saves deleted."
fi

echo "Done."
