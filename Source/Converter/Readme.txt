[Introduction]

This is a simple tool to convert C headers to XML files. It works using simple pattern matching - it does not actually parse the header files. For this reason, it will work with only a few, specific header files: ES and CL at this point.


[Usage]

CHeaderToXML.exe -p:{PREFIX} -v:{VERSION} {INPUT}
    {PREFIX} is a simple string that defines the a common prefix for functions and constants in this header. This prefix will be removed from the generated XML file.
    {VERSION} is a string that defines that version that will be used for functions in the generated XML file. Specific input files may override this setting.
    {INPUT} is a space-separated list of input files (headers).
    
Despite what the help says, all three parameters are necessary at the moment.


[Known issues]

OpenGL|ES 2.0: gl*Fence[s|iv]?NV fail to define parameters names. These have been added by hand (take care when updating the header file).


[Support]

If you encounter a bug, please file an issue report at http://www.opentk.com/issues

We will only accept bug reports for supported header files. This is not a generic tool and will fail to parse unsupported files.