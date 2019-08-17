#!/bin/bash

set -e -o

function version_compare() {
    ver1=(${1//./ })
    ver2=(${2//./ })

    len1=${#ver1[@]}
    len2=${#ver2[@]}

    vlen=$(($len1 < $len2 ? $len1 : $len2))
    
    for ((i=0;i<vlen;i++))
    do
        if [ ${ver1[$i]} -gt ${ver2[$i]} ]; then
            return 1
        fi
    done
    return 0
}

MINIMAL_DOTNET_VERSION=2.2.401

CURRENT_DOTNET_VERSION=$(dotnet --version 2> /dev/null || EXIT_CODE=$?)

if [ $EXIT_CODE ] && [ version_compare "$MINIMAL_DOTNET_VERSION" "$CURRENT_DOTNET_VERSION" ]; then
    echo "dotnet command already installed"
else
    # Install .NET Core (https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script)
    curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --version 2.2.401
fi



PATH="~/.dotnet:$PATH"
dotnet restore build-bootstrap.csproj
dotnet fake run build.fsx $@