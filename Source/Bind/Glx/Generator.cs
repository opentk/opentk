#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Bind.Glx
{
    class Generator : Bind.GL2.Generator
    {
        #region --- Constructors ---

        public Generator()
            : base()
        {
            glTypemap = "Glx\\glx.tm";
            csTypemap = "csharp.tm";
            enumSpec = "Glx\\glxenum.spec";
            enumSpecExt = "Glx\\glxenumext.spec";
            glSpec = "Glx\\glx.spec";
            glSpecExt = "Glx\\glxext.spec";

            importsFile = "GlxCore.cs";
            delegatesFile = "GlxDelegates.cs";
            enumsFile = "GlxEnums.cs";
            wrappersFile = "Glx.cs";

            Settings.OutputClass = "Glx";
            Settings.FunctionPrefix = "glX";
            Settings.ConstantPrefix = "GLX_";


            if (Settings.Compatibility == Settings.Legacy.Tao)
            {
                Settings.OutputNamespace = "Tao.Platform.Glx";
                //Settings.WindowsGDI = "Tao.Platform.Windows.Gdi";
            }
            else
            {
                Settings.OutputNamespace = "OpenTK.Platform.X11";
            }
        }

        #endregion

        public override void Process()
        {
            Bind.Structures.Type.Initialize(glTypemap, csTypemap);
            Bind.Structures.Enum.Initialize(enumSpec, enumSpecExt);
            Bind.Structures.Function.Initialize();
            Bind.Structures.Delegate.Initialize(glSpec, glSpecExt);

            // Process enums and delegates - create wrappers.
            Trace.WriteLine("Processing specs, please wait...");
            //this.Translate();

            this.WriteBindings(
                Bind.Structures.Delegate.Delegates,
                Bind.Structures.Function.Wrappers,
                Bind.Structures.Enum.GLEnums);
        }
    }
}
