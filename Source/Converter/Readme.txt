[Introduction]

This is a simple tool to convert C headers to XML files. It works using simple pattern matching - it does not actually parse the header files. For this reason, it will work with only a few, specific header files: ES and CL at this point.


[Examples]

To download and convert the new XML API registry from Khronos:
Convert.exe -p:gl -t:xml -o:../../../Source/Bind/Specifications/GL2/signatures.xml https://cvs.khronos.org/svn/repos/ogl/trunk/doc/registry/public/api/gl.xml

To download and convert the old .spec files from Khronos:
Convert.exe -p:gl -t:spec -o:../../../Source/Bind/Specifications/GL2/signatures.xml https://cvs.khronos.org/svn/repos/ogl/trunk/doc/registry/public/oldspecs/gl.spec https://cvs.khronos.org/svn/repos/ogl/trunk/doc/registry/public/oldspecs/enum.spec https://cvs.khronos.org/svn/repos/ogl/trunk/doc/registry/public/oldspecs/enumext.spec

The line above will download the latest .spec files from the public Khronos repository and update signatures.xml for the binding generator.

[Usage]

Convert.exe -p:{PREFIX} -v:{VERSION} -t:{TYPE} -o:{OUT} {INPUT1} ... {INPUTn}
    {PREFIX} is a simple string that defines the a common prefix for functions and constants in this header. This prefix will be removed from the generated XML file.
    {VERSION} is a string that defines that version that will be used for functions in the generated XML file. Specific input files may override this setting.
	{TYPE} can be either 'spec' or 'header' to indicate whether the input files are OpenGL .spec files or C headers.
	{OUT} is the output filename (optional). If no output file is specified, output will be directed to the console.
    {INPUT1..n} is a space-separated list of input files (headers).
    
Despite what the help says, all three parameters are necessary at the moment.


[Support]

If you encounter a bug, please file an issue report at http://github.com/opentk/opentk/issues

We will only accept bug reports for supported header files. This is not a generic tool and will fail to parse unsupported files.