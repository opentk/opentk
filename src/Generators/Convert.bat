set "TYPEMAPS=Specifications\Typemaps"
set "COMMAND=dotnet run -f netcoreapp20 -p Generator.Convert\Generator.Convert.csproj"
set "GL_SPEC=https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml"
set "DOCS=Specifications\Docs"
set "OUTPUT=Generator.Bind\Specifications"
%COMMAND% -i %GL_SPEC" -o %OUTPUT% -p gl -t %TYPEMAPS%\gl.json %TYPEMAPS%\csharp.json -d %DOCS% %*
pause