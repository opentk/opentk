cd..
Build\Prebuild /target nant /file prebuild.xml
NAnt.exe

rem Copying files to output directory

xcopy Source\OpenGL\Bind\bin\Release\*.exe Binaries\Release\Exe\*.* /Q /Y
xcopy Source\OpenGL\OpenGL\bin\Release\*.dll Binaries\Release\Libraries\*.* /Q /Y
xcopy Source\OpenGL\OpenGL\*.config Binaries\Release\Libraries\*.* /Q /Y

xcopy Source\Platform\Windows\bin\Release\*.dll Binaries\Release\Libraries\*.* /Q /Y
xcopy Source\Platform\X11\bin\Release\*.dll Binaries\Release\Libraries\*.* /Q /Y

xcopy Source\Framework\bin\Release\*.dll Binaries\Release\Libraries\*.* /Q /Y

xcopy Source\Examples\OpenGL\Basic\Lesson01\bin\Release\*.exe Binaries\Release\Examples\*.* /Q /Y
xcopy Source\Examples\OpenGL\Basic\NoFramework\bin\Release\*.exe Binaries\Release\Examples\*.* /Q /Y
xcopy Source\Examples\OpenGL\Basic\QueryDisplayModes\bin\Release\*.exe Binaries\Release\Examples\*.* /Q /Y
xcopy Source\Examples\OpenGL\GLSL\Lesson01\bin\Release\*.exe Binaries\Release\Examples\*.* /Q /Y

xcopy Binaries\Release\Libraries\*.* Binaries\Release\Examples\*.* /Q /Y

pause