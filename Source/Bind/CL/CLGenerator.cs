using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;
using Bind.GL2;
using Bind.Structures;
using Delegate=Bind.Structures.Delegate;
using Enum=Bind.Structures.Enum;

namespace Bind.CL
{
    class CLGenerator : Generator
    {
        public CLGenerator(Settings settings, string dirname)
            : base(settings, dirname ?? "CL10")
        {
            Settings.DefaultOutputPath = String.Format(
                Settings.DefaultOutputPath, "Compute", "CL10");
            Settings.DefaultDocPath =
                Path.Combine(Settings.DefaultDocPath, "CL10");

            // Common settings for all OpenCL generators
            Settings.DefaultTypeMapFile = "CL10/cl.tm";
            Settings.DefaultOverridesFile = "../CL10/overrides.xml";

            Settings.FunctionPrefix = "cl";
            Settings.ConstantPrefix = "CL_";
            Settings.EnumPrefix = "Cl";
            Settings.OutputClass = "CL";

            Settings.Compatibility |= Settings.Legacy.NoDebugHelpers;
            Settings.Compatibility |= Settings.Legacy.UseDllImports;
            //Settings.Compatibility |= Settings.Legacy.NoPublicUnsafeFunctions;
            Settings.Compatibility |= Settings.Legacy.NoUnsignedOverloads;

            Settings.DefaultOutputNamespace = "OpenTK.Compute.CL10";
            Settings.DefaultWrappersFile = "CL10.cs";
            Settings.DefaultEnumsFile = "CL10.Enums.cs";
            Settings.DefaultClassesFile = "CL10.Extensions.cs";

            Profile = "cl";
            Version = "1.0";
        }
    }
}
