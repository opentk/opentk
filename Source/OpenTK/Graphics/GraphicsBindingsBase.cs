// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Implements BindingsBase for the OpenTK.Graphics namespace (OpenGL and OpenGL|ES).
    /// </summary>
    public abstract class GraphicsBindingsBase : BindingsBase
    {
        /// <summary>
        /// Contains the list of API entry points (function pointers).
        /// This field must be set by an inheriting class.
        /// </summary>
        [Obsolete("Not used - this field remains for 1.1 API compatibility")]
        protected IntPtr[] EntryPointsInstance;

        /// <summary>
        /// with the 1.1 API.
        /// Contains the list of API entry point names.
        /// This field must be set by an inheriting class.
        /// </summary>
        [Obsolete("Not used - this field remains for 1.1 API compatibility")]
        protected string[] EntryPointNamesInstance;


        internal IntPtr[] _EntryPointsInstance;
        internal byte[] _EntryPointNamesInstance;
        internal int[] _EntryPointNameOffsetsInstance;

        /// <summary>
        /// Retrieves an unmanaged function pointer to the specified function.
        /// </summary>
        /// <param name="funcname">
        /// A <see cref="System.String"/> that defines the name of the function.
        /// </param>
        /// <returns>
        /// A <see cref="IntPtr"/> that contains the address of funcname or IntPtr.Zero,
        /// if the function is not supported by the drivers.
        /// </returns>
        /// <remarks>
        /// Note: some drivers are known to return non-zero values for unsupported functions.
        /// Typical values include 1 and 2 - inheritors are advised to check for and ignore these
        /// values.
        /// </remarks>
        protected override IntPtr GetAddress(string funcname)
        {
            var context = GraphicsContext.CurrentContext as IGraphicsContextInternal;
            if (context == null)
                throw new GraphicsContextMissingException();
            return context != null ? context.GetAddress(funcname) : IntPtr.Zero;
        }

        // Loads all available entry points for the current API.
        // Note: we prefer IGraphicsContextInternal.GetAddress over
        // this.GetAddress to improve loading performance (less
        // validation necessary.)
        internal override void LoadEntryPoints()
        {
            Debug.Print("Loading entry points for {0}", GetType().FullName);

            IGraphicsContext context = GraphicsContext.CurrentContext;
            if (context == null)
                throw new GraphicsContextMissingException();

            IGraphicsContextInternal context_internal = context as IGraphicsContextInternal;
            unsafe
            {
                fixed (byte* name = _EntryPointNamesInstance)
                {
                    for (int i = 0; i < _EntryPointsInstance.Length; i++)
                    {
                        _EntryPointsInstance[i] = context_internal.GetAddress(
                            new IntPtr(name + _EntryPointNameOffsetsInstance[i]));
                    }
                }
            }
        }
    }
}
