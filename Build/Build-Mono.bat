cd..
Build\Prebuild.exe /target nant /file Prebuild.xml
NAnt.exe -t:mono-2.0
Build\PostBuild.bat