using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;
using Bind.GL2;
using Bind.Structures;
using Delegate=Bind.Structures.Delegate;
using Enum=Bind.Structures.Enum;

namespace Bind.ES
{
    class ESGenerator : Generator
    {
        public ESGenerator(Settings settings, string nsName, string dirName)
            : base(settings, nsName, dirName)
        {
            Settings.ImportsFile = nsName + "Core.cs";
            Settings.DelegatesFile = nsName + "Delegates.cs";
            Settings.EnumsFile = nsName + "Enums.cs";
            Settings.WrappersFile = nsName + ".cs";
        }
    }
}
