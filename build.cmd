REM Install .NET Core (https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script)

@powershell -NoProfile -ExecutionPolicy unrestricted -Command "[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12; &([scriptblock]::Create((Invoke-WebRequest -useb 'https://dot.net/v1/dotnet-install.ps1'))) --version 2.2.401"

SET PATH=%LOCALAPPDATA%\Microsoft\dotnet;%PATH%
dotnet restore build-bootstrap.csproj
dotnet fake run build.fsx %* 