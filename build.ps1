# https://www.appveyor.com/docs/build-configuration/#interpreters-and-scripts
# $ErrorActionPreference = "Stop";
# This causes any failure inside of build.fsx to cause things to stop. 
# This is not great as fake tends to print quite a few error messages.

dotnet tool restore
dotnet paket restore
dotnet fake run build.fsx $($args)

$nupgk_files = Get-ChildItem ./bin/nuget/*.nupkg

foreach ($nupkg_file in $nupgk_files) {
    <# $nupkg_file is the current item #>
    appveyor PushArtifact $($nupkg_file)
}