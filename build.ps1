# https://www.appveyor.com/docs/build-configuration/#interpreters-and-scripts
$ErrorActionPreference = "Stop";

dotnet tool restore
dotnet paket restore
dotnet fake run build.fsx $($args)