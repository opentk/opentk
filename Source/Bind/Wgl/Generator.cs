#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Bind.Wgl
{
    class Generator : Bind.GL2.Generator
    {
        #region --- Constructors ---

        public Generator(string path)
            : base(path)
        {
            glTypemap = "Wgl\\wgl.tm";
            csTypemap = "csharp.tm";
            enumSpec = "Wgl\\wglenum.spec";
            enumSpecExt = "Wgl\\wglenumext.spec";
            glSpec = "Wgl\\wgl.spec";
            glSpecExt = "Wgl\\wglext.spec";
            
            importsFile = "WglCore.cs";
            delegatesFile = "WglDelegates.cs";
            enumsFile = "WglEnums.cs";
            wrappersFile = "Wgl.cs";
            
            className = "Wgl";

            functionPrefix = "wgl";
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
            this.Translate();

            this.WriteBindings(
            	Bind.Structures.Delegate.Delegates,
            	Bind.Structures.Function.Wrappers,
            	Bind.Structures.Enum.GLEnums);
        }
        
		public override Bind.Structures.DelegateCollection ReadDelegates(System.IO.StreamReader specFile)
		{
			return base.ReadDelegates(specFile);
		}
    }
}
