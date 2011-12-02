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
        {
            if (String.IsNullOrEmpty(nsName))
                throw new ArgumentNullException("nsName");
            if (dirName == null)
                dirName = nsName;

            glTypemap = "GL2/gl.tm";
            csTypemap = Settings.LanguageTypeMapFile;

            enumSpec = dirName + "/signatures.xml";
            enumSpecExt = String.Empty;
            glSpec = dirName  + "/signatures.xml";
            glSpecExt = String.Empty;
            Settings.OverridesFile = dirName + "/overrides.xml";

            Settings.ImportsFile = "Core.cs";
            Settings.DelegatesFile = "Delegates.cs";
            Settings.EnumsFile = "Enums.cs";
            Settings.WrappersFile = "ES.cs";
            Settings.ImportsClass = "Core";
            Settings.DelegatesClass = "Delegates";

            Settings.OutputClass = "GL";
        }
    }
}
