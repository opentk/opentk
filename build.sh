#!/usr/bin/env bash

set -eu
set -o pipefail

cd `dirname $0`

FSIARGS=""
OS=${OS:-"unknown"}
if [[ "$OS" != "Windows_NT" ]]
then
  FSIARGS="--fsiargs -d:MONO"
fi

function run() {
  if [[ "$OS" != "Windows_NT" ]]
  then
    mono "$@"
  else
    "$@"
  fi
}

run .paket/paket.bootstrapper.exe

if [[ "$OS" != "Windows_NT" ]] &&
       [ ! -e ~/.config/.mono/certs ]
then
  mozroots --import --sync --quiet
fi

run .paket/paket.exe restore

# FAKE workaround - msbuild is the new primary build tool on Mono >= 5.0
if [[ -z $(command -v mono) ]]; then
  if [[ -z $(command -v awk) ]]; then
    echo "awk is required to correctly detect the installed mono version."
    exit 1
  fi

  MONO_VER=$(mono --version | awk 'NR == 1 { print $5; }')
  if [[ ( ${MONO_VER} > "5.0.0.0" )  || ( ${MONO_VER} == "5.0.0.0" ) ]]
  then
    MSBUILD_PRESENT=$(command -v msbuild)
    if [[ -z ${MSBUILD_PRESENT} ]]; then
      MSBuild=${MSBUILD_PRESENT}
    else
      MSBuild=$(command -v xbuild)
    fi
  fi
fi
[ ! -e build.fsx ] && run .paket/paket.exe update
[ ! -e build.fsx ] && run packages/FAKE/tools/FAKE.exe init.fsx
run packages/FAKE/tools/FAKE.exe "$@" $FSIARGS build.fsx

