using System;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Used to load the OpenGL bindings.
    /// </summary>
    public unsafe static class GLLoader
    {
        private static IBindingsContext? _bindingsContext;

        internal static IBindingsContext BindingsContext => _bindingsContext ??
                throw new Exception("Bindings not loaded, load with GLLoader.LoadBindings");

        /// <summary>
        /// Sets the <see cref="IBindingsContext"/> that is used when loading OpenGL functions.
        /// </summary>
        /// <param name="c">The <see cref="IBindingsContext"/> to use when loading OpenGL functions.</param>
        public static void LoadBindings(IBindingsContext c) => _bindingsContext = c;
    }
}
