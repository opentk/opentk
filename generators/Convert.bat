dotnet build -p Generator.Convert\Generator.Convert.csproj
Generator.Convert\bin\Debug\net461\Convert -i https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml -o Generator.Bind\Specifications -p gl -t gl.json csharp.json
pause