using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("The Open Toolkit Library Build Script")]
[assembly: AssemblyDescription("Cross-platform build script for OpenTK")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("The Open Toolkit Library")]
[assembly: AssemblyProduct("The Open Toolkit Library")]
[assembly: AssemblyCopyright("Copyright ©  2006-2009 the Open Toolkit Library")]
[assembly: AssemblyTrademark("OpenTK")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3041e6aa-1f0c-47f0-81ad-b10fd7791103")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("0.9.9.4")]
[assembly: AssemblyFileVersion("0.9.9.4")]

#if SIGN_ASSEMBLY
[assembly: AssemblyKeyFile(@"../../../OpenTK.snk")]
#endif