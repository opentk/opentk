#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Bind.Wgl
{
    class Generator : Bind.GL2.Generator
    {
        public Generator(string path)
            : base(path)
        {
            glTypemap = "wgl.tm";
            csTypemap = "..\\gl2\\csharp.tm";
            enumSpec = "wglenum.spec";
            enumSpecExt = "wglenumext.spec";
            glSpec = "wgl.spec";
            glSpecExt = "wglext.spec";
        }

        public override void Process()
        {
            base.Process();
        }
    }
}
