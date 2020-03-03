@echo off
cls

.paket\paket.bootstrapper.exe
if errorlevel 1 (
  exit /b %errorlevel%
)

.paket\paket.exe restore
if errorlevel 1 (
  exit /b %errorlevel%
)

IF NOT EXIST build.fsx (
  .paket\paket.exe update
  packages\FAKE.4.64.18\tools\FAKE.exe init.fsx
)

SET BuildTarget=
if "%BuildRunner%" == "MyGet" (
  SET BuildTarget=NuGet

  :: Replace the existing release notes file with one for this build only
  echo ### %PackageVersion% > RELEASE_NOTES.md
  echo 	* git build >> RELEASE_NOTES.md
)

packages\FAKE.4.64.18\tools\FAKE.exe build.fsx %* %BuildTarget%