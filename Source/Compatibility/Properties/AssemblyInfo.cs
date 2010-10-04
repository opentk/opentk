using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("OpenTK.Compatibility")]
[assembly: AssemblyDescription("Provides compatibility with previous versions of OpenTK and the Tao framework.")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("7c495044-4b1a-4bff-aee9-ff9dbf85433f")]

[assembly: System.CLSCompliant(true)]
[assembly: System.Security.AllowPartiallyTrustedCallers]
#if NET40
[assembly: System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
#endif
