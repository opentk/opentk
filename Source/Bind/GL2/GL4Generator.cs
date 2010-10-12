using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bind.GL2
{
    class GL4Generator : ES.ESGenerator
    {
        public GL4Generator(string name, string dirname)
			: base(name, dirname)
        {
            glTypemap = "GL2/gl.tm";
            csTypemap = "csharp.tm";

            enumSpec = "GL2/signatures.xml";
            enumSpecExt = String.Empty;
            glSpec = "GL2/signatures.xml";
            glSpecExt = String.Empty;
            functionOverridesFile = "GL2/gloverrides.xml";

            importsFile = "GLCore.cs";
            delegatesFile = "GLDelegates.cs";
            enumsFile = "GLEnums.cs";
            wrappersFile = "GL.cs";
            Settings.ImportsClass = "Core";
            Settings.DelegatesClass = "Delegates";

            Settings.OutputClass = "GL";
            Settings.OutputNamespace = "OpenTK.Graphics.OpenGL";
            Settings.OutputPath = "../../../Source/OpenTK/Graphics/OpenGL";
        }
    }
}
