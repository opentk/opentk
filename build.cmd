@echo off
cls

dotnet restore

IF NOT EXIST build.fsx (
  packages\FAKE\tools\FAKE.exe init.fsx
)

SET BuildTarget=
if "%BuildRunner%" == "MyGet" (
  SET BuildTarget=NuGet

  :: Replace the existing release notes file with one for this build only
  echo ### %PackageVersion% > RELEASE_NOTES.md
  echo 	* git build >> RELEASE_NOTES.md
)

packages\FAKE\tools\FAKE.exe build.fsx %* %BuildTarget%