cd..
Build\Prebuild.exe /target nant /file prebuild.xml
NAnt.exe -t:mono-2.0
Build\PostBuild.bat