#!/bin/bash

set -e -o

dotnet run --project ./build/build.fsproj $@
