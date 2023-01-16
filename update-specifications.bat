dotnet run -f netcoreapp3.1 --project "src/Generator.Converter/Generator.Convert.csproj" -i https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml -o src/Generator.Bind/Specifications/GL2/signatures.xml --prefix gl
pause
