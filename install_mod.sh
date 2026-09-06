#!/usr/bin/env bash
set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIR"

# Game directory detection
GAME_DIR="${SUBNAUTICA_DIR:-/home/rko735/.steam/debian-installation/steamapps/common/SubnauticaZero}"

if [ ! -d "$GAME_DIR" ]; then
    echo "Error: Subnautica: Below Zero directory not found at '$GAME_DIR'"
    echo "Please set SUBNAUTICA_DIR environment variable to your game path."
    exit 1
fi

echo "=========================================================="
echo " Subnautica Below Zero Multiplayer - Linux Installer"
echo "=========================================================="
echo "Game directory: $GAME_DIR"

# 1. Compile the mod
echo ""
echo "[1/4] Building mod in Release mode..."
export PATH="$HOME/.dotnet:$PATH"
if command -v dotnet >/dev/null 2>&1; then
    DOTNET_CMD="dotnet"
elif [ -f "$HOME/.dotnet/dotnet" ]; then
    DOTNET_CMD="$HOME/.dotnet/dotnet"
else
    echo "Error: .NET SDK not found. Please install .NET 8 SDK."
    exit 1
fi

"$DOTNET_CMD" build "$SCRIPT_DIR/Subnautica.Multiplayer.csproj" -c Release -p:GameManagedPath="$GAME_DIR/SubnauticaZero_Data/Managed"

# 2. Install BepInEx 5 into game directory
echo ""
echo "[2/4] Installing BepInEx 5 to game directory..."
cp -rn "$SCRIPT_DIR/lib/BepInEx/"* "$GAME_DIR/" || cp -r "$SCRIPT_DIR/lib/BepInEx/"* "$GAME_DIR/"
mkdir -p "$GAME_DIR/BepInEx/plugins/SubnauticaMultiplayer"

# 3. Deploy Mod DLLs and dependencies
echo ""
echo "[3/4] Deploying compiled multiplayer mod assemblies..."
PLUGIN_DIR="$GAME_DIR/BepInEx/plugins/SubnauticaMultiplayer"
BUILD_DIR="$SCRIPT_DIR/bin/Release/netstandard2.0"

cp -v "$BUILD_DIR"/*.dll "$PLUGIN_DIR/"
cp -v "$BUILD_DIR"/*.pdb "$PLUGIN_DIR/" 2>/dev/null || true

# Copy Data directory assets
if [ -d "$SCRIPT_DIR/Data" ]; then
    mkdir -p "$PLUGIN_DIR/Data"
    cp -r "$SCRIPT_DIR/Data/"* "$PLUGIN_DIR/Data/"
fi

# 4. Prepare local AppData (.botbenson)
echo ""
echo "[4/4] Setting up AppData directories..."
BOTBENSON_DIR="$HOME/.botbenson/Subnautica Below Zero"
mkdir -p "$BOTBENSON_DIR/Game/Plugins"
mkdir -p "$BOTBENSON_DIR/Game/Dependencies"
mkdir -p "$BOTBENSON_DIR/Game/Logs"
mkdir -p "$BOTBENSON_DIR/Game/Saves"

echo ""
echo "=========================================================="
echo " Installation Complete!"
echo "=========================================================="
echo ""
echo "IMPORTANT LINUX STEAM STEP:"
echo "In Steam -> Right click 'Subnautica: Below Zero' -> Properties"
echo "Set Launch Options to:"
echo ""
echo '    WINEDLLOVERRIDES="winhttp=n,b" %command%'
echo ""
echo "This allows Proton/Wine to load BepInEx (winhttp.dll) and your mod."
echo "You can now launch the game from Steam!"
