#!/usr/bin/env bash
set -e

# Download and add .NET 9 SDK
wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh --channel 9.0 --install-dir "$HOME/dotnet"

export PATH="$HOME/dotnet:$PATH"

# Confirm version and build
dotnet --version
dotnet publish -c Release