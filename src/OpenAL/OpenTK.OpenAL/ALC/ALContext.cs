/* AlcFunctions.cs
 * C header: \OpenAL 1.1 SDK\include\Alc.h
 * Spec: http://www.openal.org/openal_webstf/specs/OpenAL11Specification.pdf
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

using System;
using AdvancedDLSupport;
using OpenTK.OpenAL.Interfaces;

namespace OpenTK.OpenAL
{
    /// <summary>
    /// Provides access to the OpenAL 1.1 context API.
    /// </summary>
    public abstract class ALContext : NativeLibraryBase, IALC
    {
        /// <inheritdoc cref="NativeLibraryBase"/>
        protected ALContext(string path, ImplementationOptions options) : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe void* CreateContext(void* device, int* attributeList);

        /// <inheritdoc />
        public abstract unsafe bool MakeContextCurrent(void* context);

        /// <inheritdoc />
        public abstract unsafe void ProcessContext(void* context);

        /// <inheritdoc />
        public abstract unsafe void SuspendContext(void* context);

        /// <inheritdoc />
        public abstract unsafe void DestroyContext(void* context);

        /// <inheritdoc />
        public abstract unsafe void* GetCurrentContext();

        /// <inheritdoc />
        public abstract unsafe void* GetContextsDevice(void* context);

        /// <inheritdoc />
        public abstract unsafe void* OpenDevice(string deviceName);

        /// <inheritdoc />
        public abstract unsafe bool CloseDevice(void* device);

        /// <inheritdoc />
        public abstract unsafe ContextError GetError(void* device);

        /// <inheritdoc />
        public abstract bool IsExtensionPresent(string name);

        /// <inheritdoc />
        public abstract IntPtr GetProcAddress(string name);

        /// <inheritdoc />
        public abstract int GetEnumValue(string name);

        /// <inheritdoc />
        public abstract unsafe string GetContextProperty(void* device, GetContextString param);

        /// <inheritdoc />
        public abstract unsafe void GetContextProperty(void* device, GetContextInteger param, int count, void* data);
    }
}
