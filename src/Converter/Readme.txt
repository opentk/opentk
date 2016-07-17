[Introduction]

This is a simple tool to convert Khronos XML to OpenTK XML files. 

[Examples]

To download and convert the XML API registry from Khronos:
Convert.exe -p:gl -o:../../../Source/Bind/Specifications/GL2/signatures.xml https://cvs.khronos.org/svn/repos/ogl/trunk/doc/registry/public/api/gl.xml

The line above will download the latest .xml files from the public Khronos repository and update signatures.xml for the binding generator.

[Usage]

Convert.exe -p:{PREFIX} -v:{VERSION} -t:{TYPE} -o:{OUT} {INPUT1} ... {INPUTn}
    {PREFIX} is a simple string that defines the a common prefix for functions and constants in this header. This prefix will be removed from the generated XML file.
    {VERSION} is a string that defines that version that will be used for functions in the generated XML file. Specific input files may override this setting.
	{OUT} is the output filename (optional). If no output file is specified, output will be directed to the console.
    {INPUT1..n} is a space-separated list of input files.
    
Despite what the help says, prefix and version parameters are necessary at the moment.

[Support]

If you encounter a bug, please file an issue report at http://github.com/opentk/opentk/issues