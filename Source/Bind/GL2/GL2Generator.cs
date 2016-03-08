// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.IO;

namespace Bind.GL2
{

    class GL2Generator : Generator
    {
        public GL2Generator(Settings settings)
            : base(settings)
        {
            if (Settings.Compatibility == Settings.Legacy.Tao)
            {
                Settings.OutputNamespace = "Tao.OpenGl";
                Settings.OutputClass = "Gl";
            }
            else
            {
                // Defaults
            }

            Settings.DefaultOutputNamespace = "OpenTK.Graphics.OpenGL";
            Settings.DefaultImportsFile = "GLCore.cs";
            Settings.DefaultDelegatesFile = "GLDelegates.cs";
            Settings.DefaultEnumsFile = "GLEnums.cs";
            Settings.DefaultWrappersFile = "GL.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "GL");

            Settings.OverridesFiles.Add("GL2/overrides.xml");
            Settings.OverridesFiles.Add("GL2/GL/");

            //Settings.DefaultCompatibility |=
            //    Settings.Legacy.UseDllImports | Settings.Legacy.UseWindowsCompatibleGL;
        }
    }
}

