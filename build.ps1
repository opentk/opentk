# https://www.appveyor.com/docs/build-configuration/#interpreters-and-scripts
# $ErrorActionPreference = "Stop";
# This causes any failure inside of build.fsx to cause things to stop. 
# This is not great as fake tends to print quite a few error messages.

dotnet tool restore
dotnet paket restore
dotnet run --project ./build/build.fsproj $($args)

if ($LASTEXITCODE -ne 0)
{
    Write-Error ([string]::Format("dotnet run failed with: {0}", $LASTEXITCODE))
    # Make sure we are not closing the terminal when running locally.
    if ($env:APPVEYOR -ceq "True")
    {
        $host.SetShouldExit($LASTEXITCODE)
    }
}