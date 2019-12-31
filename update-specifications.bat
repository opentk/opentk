dotnet run -f netcoreapp31 -p "src/Generators/Generator.Converter/Generator.Convert.csproj" -i https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml -o src/Generators/Generator.Bind/Specifications/OpenGL/signatures.xml --prefix gl
pause
