using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Audio
{
    // FIXME: Make a proper loader!
    internal class ALCLoader
    {
        private static IBindingsContext? _bindingsContext;

        internal static IBindingsContext BindingsContext => _bindingsContext ??
                throw new Exception("Bindings not loaded, load with ALCLoader.LoadBindings");

        /// <summary>
        /// Sets the <see cref="IBindingsContext"/> that is used when loading OpenGL functions.
        /// </summary>
        /// <param name="c">The <see cref="IBindingsContext"/> to use when loading OpenGL functions.</param>
        public static void LoadBindings(IBindingsContext c) => _bindingsContext = c;
    }
}
