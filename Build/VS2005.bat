@rem Generates a solution (.sln) and a set of project files (.csproj, .vbproj, etc.)
@rem for Microsoft Visual Studio .NET 2005
cd ..
Build\Prebuild.exe /target vs2005 /file Prebuild.xml /pause
