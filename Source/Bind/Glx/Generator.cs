#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System.Diagnostics;
using Bind.Structures;

namespace Bind.Glx
{
    class Generator : GL2.Generator
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
            Type.Initialize(glTypemap, csTypemap);
            Enum.Initialize(enumSpec, enumSpecExt);
            Function.Initialize();
            Delegate.Initialize(glSpec, glSpecExt);

            // Process enums and delegates - create wrappers.
            Trace.WriteLine("Processing specs, please wait...");
            //this.Translate();

            WriteBindings(
                Delegate.Delegates,
                Function.Wrappers,
                Enum.GLEnums);
        }
    }
}
