using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.Graphics
{
    public class GL
    {
        [DllImport("OpenToolkit.Opengl32.dll/EXT", EntryPoint = "glAccum")]
        public static extern void Accum(System.UInt32 op, System.Single value);

        public void AccumxOES(System.UInt32 op, System.Int32 value)
        {
            throw new System.NotImplementedException();
        }

        public void ActiveProgramEXT(System.UInt32 program)
        {
            throw new System.NotImplementedException();
        }

        public void ActiveShaderProgram(System.UInt32 pipeline, System.UInt32 program)
        {
            throw new System.NotImplementedException();
        }

        public void ActiveShaderProgramEXT(System.UInt32 pipeline, System.UInt32 program)
        {
            throw new System.NotImplementedException();
        }

        public void ActiveStencilFaceEXT(System.UInt32 face)
        {
            throw new System.NotImplementedException();
        }
    }
}
