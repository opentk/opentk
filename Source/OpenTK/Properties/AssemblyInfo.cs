using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("OpenTK")]
[assembly: AssemblyDescription("Open source game development toolkit for .Net/Mono.")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("7652241e-158d-4eb1-85f4-ed40ee356791")]

[assembly: CLSCompliant(true)]
[assembly: System.Security.AllowPartiallyTrustedCallers]
#if NET40
[assembly: System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
#endif
