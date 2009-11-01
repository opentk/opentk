using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("The Open Toolkit Library")]
[assembly: AssemblyDescription("Open source game development toolkit for .Net/Mono.")]
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
[assembly: Guid("7652241e-158d-4eb1-85f4-ed40ee356791")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("0.9.9.4")]
[assembly: AssemblyFileVersion("0.9.9.4")]

[assembly: CLSCompliant(true)]
[assembly: System.Security.AllowPartiallyTrustedCallers]

#if SIGN_ASSEMBLY
[assembly: AssemblyKeyFile(@"../../../OpenTK.snk")]
#endif