#!/bin/bash
set -e #exit on errors

# Pass all arguments to the .NET application
dotnet /app/MyGitHubActionApp.dll "$@"