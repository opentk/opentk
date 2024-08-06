using System;

namespace OpenTK.Platform
{
    /// <summary>
    /// An <see cref="IBindingsContext"/> to use with PAL2.
    /// </summary>
    public class Pal2BindingsContext : IBindingsContext
    {
        /// <summary>
        /// The <see cref="IOpenGLComponent"/> component.
        /// </summary>
        public IOpenGLComponent OpenGLComp { get; private set; }

        /// <summary>
        /// A handle to the context to use to load OpenGL functions.
        /// </summary>
        public OpenGLContextHandle ContextHandle { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pal2BindingsContext"/> class given an OpenGL conponent and a context handle.
        /// </summary>
        /// <param name="openGLComp">The OpenGL component.</param>
        /// <param name="contextHandle">The OpenGL context handle.</param>
        public Pal2BindingsContext(IOpenGLComponent openGLComp, OpenGLContextHandle contextHandle)
        {
            OpenGLComp = openGLComp;
            ContextHandle = contextHandle;
        }

        /// <inheritdoc/>
        public IntPtr GetProcAddress(string procName)
        {
            return OpenGLComp.GetProcedureAddress(ContextHandle, procName);
        }
    }
}
