#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System.Diagnostics;
using Bind.Structures;

namespace Bind.Wgl
{
    class Generator : GL2.Generator
    {
        #region --- Constructors ---

        public Generator()
            : base()
        {
            glTypemap = "Wgl/wgl.tm";
            csTypemap = "csharp.tm";
            enumSpec = "Wgl/wglenum.spec";
            enumSpecExt = "Wgl/wglenumext.spec";
            glSpec = "Wgl/wgl.spec";
            glSpecExt = "Wgl/wglext.spec";
            
            importsFile = "WglCore.cs";
            delegatesFile = "WglDelegates.cs";
            enumsFile = "WglEnums.cs";
            wrappersFile = "Wgl.cs";

            Settings.OutputClass = "Wgl";
            Settings.FunctionPrefix = "wgl";
            Settings.ConstantPrefix = "WGL_";

            if (Settings.Compatibility == Settings.Legacy.Tao)
            {
                Settings.OutputNamespace = "Tao.Platform.Windows";
                Settings.WindowsGDI = "Tao.Platform.Windows.Gdi";
            }
            else
            {
                Settings.OutputNamespace = "OpenTK.Platform.Windows";
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
