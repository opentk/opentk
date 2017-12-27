### Introduction

This is a simple tool to convert Khronos XML to OpenTK XML files.

### Usage
```
Converting local files:
  Convert.exe --input-files gl.xml --output-file signatures.xml --prefix gl
Converting latest remote specification:
  Convert.exe --input-files https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml --output-file signatures.xml --prefix gl

  -p, --prefix         Required. (Default: gl) The prefix to remove from parsed functions and constants.

  -o, --output-file    The path to the output file. Defaults to stdout if no path is provided.

  -i, --input-files    Required. A list of the Khronos XML files to parse into OpenTK XML. Remote resources in the form of URLs are supported.

  --help               Display this help screen.

  --version            Display version information.
```
### Support

If you encounter a bug, please file an issue report at the OpenTK [issue tracker](http://github.com/opentk/opentk/issues).