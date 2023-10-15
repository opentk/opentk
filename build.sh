#!/bin/bash

set -e -o

dotnet tool restore
dotnet paket restore
dotnet run --project ./build/build.fsproj $@
