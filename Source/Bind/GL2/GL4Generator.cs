// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bind.GL2
{
    class GL4Generator : Generator
    {
        public GL4Generator(Settings settings)
            : base(settings)
        {
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "../OpenGL4");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.OpenGL4";
            Settings.DefaultImportsFile = "GL4Core.cs";
            Settings.DefaultDelegatesFile = "GL4Delegates.cs";
            Settings.DefaultEnumsFile = "GL4Enums.cs";
            Settings.DefaultWrappersFile = "GL4.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "GL");

            Settings.OverridesFiles.Add("GL2/overrides.xml");
            Settings.OverridesFiles.Add("GL2/GL/");

            Profile = "glcore";

            //Settings.DefaultCompatibility |=
            //    Settings.Legacy.UseDllImports | Settings.Legacy.UseWindowsCompatibleGL;
        }
    }
}
