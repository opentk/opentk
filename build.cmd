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
  packages\FAKE\tools\FAKE.exe init.fsx
)

SET BuildTarget=
if "%BuildRunner%" == "MyGet" (
  SET BuildTarget=NuGet
)

packages\FAKE\tools\FAKE.exe build.fsx %* %BuildTarget%