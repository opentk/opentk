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
    // Generation implementation for OpenGL ES 3.0
    class ES3Generator : ESGenerator
    {
        public ES3Generator(Settings settings, string dirName)
            : base(settings, dirName)
        {
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "../ES30");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES30";
            Settings.DefaultImportsFile = "ES30Core.cs";
            Settings.DefaultDelegatesFile = "ES30Delegates.cs";
            Settings.DefaultEnumsFile = "ES30Enums.cs";
            Settings.DefaultWrappersFile = "ES30.cs";

            Profile = "gles2"; // The 3.0 spec reuses the gles2 apiname
            Version = "2.0|3.0";
        }
    }
}
