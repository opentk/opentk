cd..
Build\Prebuild.exe /target nant /file Prebuild.xml
NAnt.exe -t:net-2.0
Build\PostBuild.bat