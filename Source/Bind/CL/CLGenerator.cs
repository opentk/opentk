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
            : base(settings, dirname)
        {
            glTypemap = "CL10/cl.tm";

            Settings.FunctionPrefix = "cl";
            Settings.ConstantPrefix = "CL_";
            Settings.EnumPrefix = "Cl";
            Settings.OutputClass = "CL";

            Settings.Compatibility |= Settings.Legacy.NoDebugHelpers;

            Settings.DefaultOutputNamespace = "OpenTK.Compute.CL10";
            Settings.DefaultWrappersFile = "CL10.cs";
            Settings.DefaultEnumsFile = "CL10.Enums.cs";
        }
    }
}
