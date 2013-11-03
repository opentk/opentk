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
        public CLGenerator(Settings settings, string dirname)
            : base(settings, dirname)
        {
            glTypemap = null;

            Settings.WrappersFile = "CL.cs";

            Settings.FunctionPrefix = "cl";
            Settings.ConstantPrefix = "CL_";
            Settings.EnumPrefix = "Cl";

            Settings.OutputClass = "CL";

            //Settings.Compatibility &= ~Settings.Legacy.TurnVoidPointersToIntPtr;
            Settings.Compatibility |= Settings.Legacy.NoDebugHelpers;

            Settings.DefaultImportsFile = "CLCore.cs";
            Settings.DefaultDelegatesFile = "CLDelegates.cs";
            Settings.DefaultEnumsFile = "CLEnums.cs";
            Settings.DefaultWrappersFile = "CL.cs";
        }
    }
}
