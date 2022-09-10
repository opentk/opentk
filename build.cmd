::@echo off

.paket\paket.bootstrapper.exe
if errorlevel 1 (
  exit /b %errorlevel%
)

::.paket\paket.exe restore
::if errorlevel 1 (
::  exit /b %errorlevel%
::)

SET BuildTarget=
if "%BuildRunner%" == "MyGet" (
  SET BuildTarget=NuGet

  :: Replace the existing release notes file with one for this build only
  echo ### %PackageVersion% > RELEASE_NOTES.md
  echo 	* git build >> RELEASE_NOTES.md
)

dotnet tool restore

dotnet fake run build.fsx %* %BuildTarget%

:: packages\FAKE\tools\FAKE.exe build.fsx %* 