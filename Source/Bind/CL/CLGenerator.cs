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
    class CLGenerator : ES.ESGenerator
    {
        public CLGenerator(string name, string dirname)
			: base(name, dirname)
        {
            glTypemap = null;

			wrappersFile = "CL.cs";

            Settings.FunctionPrefix = "cl";
            Settings.ConstantPrefix = "CL_";
            Settings.EnumPrefix = "Cl";

            Settings.OutputClass = "CL";
            Settings.OutputNamespace = "OpenTK.Compute." + name;

            //Settings.Compatibility &= ~Settings.Legacy.TurnVoidPointersToIntPtr;
            Settings.Compatibility |= Settings.Legacy.NoDebugHelpers;
        }
    }
}
