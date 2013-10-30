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
        public ESGenerator(string nsName, string dirName)
            : base(nsName, dirName)
        {
            Settings.ImportsFile = "Core.cs";
            Settings.DelegatesFile = "Delegates.cs";
            Settings.EnumsFile = "Enums.cs";
            Settings.WrappersFile = "ES.cs";
        }
    }
}
