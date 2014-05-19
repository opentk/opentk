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
    // Generator implementation for OpenGL ES 1.0 and 1.1
    class ESGenerator : Generator
    {
        public ESGenerator(Settings settings, string dirName)
            : base(settings, dirName)
        {
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "../ES11");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES11";
            Settings.DefaultImportsFile = "ES11Core.cs";
            Settings.DefaultDelegatesFile = "ES11Delegates.cs";
            Settings.DefaultEnumsFile = "ES11Enums.cs";
            Settings.DefaultWrappersFile = "ES11.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "ES20"); // no ES11 docbook sources available

            // Khronos releases a combined 1.0+1.1 specification,
            // so we cannot distinguish between the two.
            // Todo: add support for common and light profiles.
            Profile = "gles1";
            // no explicit version means both 1.0 and 1.1 versions

            // For compatibility with OpenTK 1.0 and Xamarin, generate
            // overloads using the "All" enum in addition to strongly-typed enums.
            // This can be disabled by passing "-o:-keep_untyped_enums" as a cmdline parameter.
            Settings.DefaultCompatibility |= Settings.Legacy.KeepUntypedEnums;
            //Settings.DefaultCompatibility |= Settings.Legacy.UseDllImports;
        }
    }
}
