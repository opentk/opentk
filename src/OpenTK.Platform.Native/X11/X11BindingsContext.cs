using System;

namespace OpenTK.Platform.Native.X11
{
    public class X11BindingsContext : IBindingsContext
    {
        public X11AbstractionLayer Layer { get; }
        public XOpenGLContextHandle Context { get; }

        public X11BindingsContext(X11AbstractionLayer layer, XOpenGLContextHandle context)
        {
            Layer = layer;
            Context = context;
        }

        public IntPtr GetProcAddress(string procName)
        {
            return Layer.GetProcedureAddress(Context, procName);
        }
    }
}