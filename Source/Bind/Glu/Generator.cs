#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System.Diagnostics;
using Bind.Structures;

namespace Bind.Glu
{
    class Generator : GL2.Generator
    {
        string enumSpecAux = null;// = "GL2\\enum.spec";

        #region --- Constructors ---

        public Generator()
            : base()
        {
            glTypemap = "Glu\\glu.tm";
            csTypemap = "csharp.tm";
            enumSpec = "Glu\\enumglu.spec";
            enumSpecExt = "";
            glSpec = "Glu\\glu.spec";
            glSpecExt = "";

            importsFile = "GluCore.cs";
            delegatesFile = "GluDelegates.cs";
            enumsFile = "GluEnums.cs";
            wrappersFile = "Glu.cs";

            Settings.OutputClass = "Glu";
            Settings.FunctionPrefix = "glu";
            Settings.ConstantPrefix = "GLU_";

            if (Settings.Compatibility == Settings.Legacy.Tao)
            {
                Settings.OutputNamespace = "Tao.OpenGl";
                //Settings.WindowsGDI = "Tao.Platform.Windows.Gdi";
            }
            else
            {
                //Settings.OutputNamespace = "OpenTK.Graphics.OpenGL";
            }

            Settings.CompleteEnumName = "AllGlu";
        }

        #endregion

        public override void Process()
        {
            Type.Initialize(glTypemap, csTypemap);
            Enum.Initialize(enumSpec, enumSpecExt, enumSpecAux);
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
