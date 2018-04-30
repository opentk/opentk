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

if [[ "$OS" != "Windows_NT" ]] &&
       [ ! -e ~/.config/.mono/certs ]
then
  mozroots --import --sync --quiet
fi

dotnet restore

FAKE_VERSION="4.64.12"
FAKE_PATH="tools/FAKE"
FAKE_EXECUTABLE="${FAKE_PATH}/FAKE.${FAKE_VERSION}/tools/FAKE.exe"

[ ! -e packages/FAKE/tools/FAKE.exe ] && nuget install FAKE -Version ${FAKE_VERSION} -OutputDirectory ${FAKE_PATH}
[ ! -e build.fsx ] && run ${FAKE_EXECUTABLE} init.fsx
run ${FAKE_EXECUTABLE} "$@" $FSIARGS build.fsx