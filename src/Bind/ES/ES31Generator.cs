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
    // Generation implementation for OpenGL ES 3.1
    class ES31Generator : Generator
    {
        public ES31Generator(Settings settings)
            : base(settings)
        {
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "../ES31");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES31";
            Settings.DefaultImportsFile = "ES31.Core.cs";
            Settings.DefaultDelegatesFile = "ES31.Delegates.cs";
            Settings.DefaultEnumsFile = "ES31.Enums.cs";
            Settings.DefaultWrappersFile = "ES31.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "ES31");

            Settings.OverridesFiles.Add("GL2/overrides.xml");
            Settings.OverridesFiles.Add("GL2/ES/3.1");

            Profile = "gles2";
            Version = "2.0|3.0|3.1";

            // For compatibility with OpenTK 1.0 and Xamarin, generate
            // overloads using the "All" enum in addition to strongly-typed enums.
            // This can be disabled by passing "-o:-keep_untyped_enums" as a cmdline parameter.
            Settings.DefaultCompatibility |= Settings.Legacy.KeepUntypedEnums;
            //Settings.DefaultCompatibility |= Settings.Legacy.UseDllImports;
        }
    }
}
