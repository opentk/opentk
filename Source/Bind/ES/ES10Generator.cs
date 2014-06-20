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
    class ES10Generator : Generator
    {
        public ES10Generator(Settings settings, string dirName)
            : base(settings, dirName)
        {
            Settings.DefaultOutputPath = String.Format(
                Settings.DefaultOutputPath, "Graphics", "ES10");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES10";
            Settings.DefaultEnumsFile = "ES10.Enums.cs";
            Settings.DefaultWrappersFile = "ES10.cs";
            Settings.DefaultClassesFile = "ES10.Extensions.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "ES20"); // no ES10 docbook sources available

            // Khronos releases a combined 1.0+1.1 specification,
            // so we cannot distinguish between the two.
            // Todo: add support for common and light profiles.
            Profile = "gles1";
            Version = "1.0";

            // For compatibility with OpenTK 1.0 and Xamarin, generate
            // overloads using the "All" enum in addition to strongly-typed enums.
            // This can be disabled by passing "-o:-keep_untyped_enums" as a cmdline parameter.
            Settings.DefaultCompatibility |= Settings.Legacy.KeepUntypedEnums;
            Settings.DefaultCompatibility |=
                Settings.Legacy.KeepStringArrayOverloads;
            Settings.DefaultCompatibility |=
                Settings.Legacy.KeepCoreOnly;
        }
    }
}
