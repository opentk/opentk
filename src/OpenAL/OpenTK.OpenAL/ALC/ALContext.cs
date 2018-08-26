/* AlcFunctions.cs
 * C header: \OpenAL 1.1 SDK\include\Alc.h
 * Spec: http://www.openal.org/openal_webstf/specs/OpenAL11Specification.pdf
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

using System;
using AdvancedDLSupport;
using OpenTK.Core;
using OpenTK.Core.Loader;
using OpenTK.OpenAL.Attributes;
using OpenTK.OpenAL.Extensions;
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

        /// <summary>
        /// Gets an instance of the API of an extension to the API.
        /// </summary>
        /// <typeparam name="TContextExtension">The extension type.</typeparam>
        /// <returns>The extension.</returns>
        public unsafe TContextExtension GetExtension<TContextExtension>(void* device) where TContextExtension : ContextExtensionBase
        {
            return ExtensionLoader.LoadContextExtension<TContextExtension>(device, this);
        }

        /// <inheritdoc />
        public abstract unsafe void* CreateContext(void* device, int* attributeList);

        /// <inheritdoc cref="CreateContext"/>
        public unsafe ContextHandle CreateContextHandle(void* device, int* attributeList)
        {
            return new ContextHandle(CreateContext(device, attributeList));
        }

        /// <inheritdoc />
        public abstract unsafe bool MakeContextCurrent(void* context);

        /// <inheritdoc cref="MakeContextCurrent(void*)"/>
        public bool MakeContextCurrent(ContextHandle context)
        {
            unsafe
            {
                return MakeContextCurrent((void*)context);
            }
        }

        /// <inheritdoc />
        public abstract unsafe void ProcessContext(void* context);

        /// <inheritdoc />
        public abstract unsafe void SuspendContext(void* context);

        /// <inheritdoc />
        public abstract unsafe void DestroyContext(void* context);

        /// <inheritdoc />
        public abstract unsafe void* GetCurrentContext();

        /// <inheritdoc cref="GetCurrentContext"/>
        public ContextHandle GetCurrentContextHandle()
        {
            unsafe
            {
                return new ContextHandle(GetCurrentContext());
            }
        }

        /// <inheritdoc />
        public abstract unsafe void* GetContextsDevice(void* context);

        /// <inheritdoc />
        public abstract unsafe void* OpenDevice(string deviceName);

        /// <inheritdoc />
        public abstract unsafe bool CloseDevice(void* device);

        /// <inheritdoc />
        public abstract unsafe ContextError GetError(void* device);

        /// <inheritdoc />
        public abstract unsafe bool IsExtensionPresent(void* device, string name);

        /// <inheritdoc />
        public abstract unsafe void* GetProcAddress(void* device, string name);

        /// <inheritdoc />
        public abstract unsafe int GetEnumValue(void* device, string name);

        /// <inheritdoc />
        public abstract unsafe string GetContextProperty(void* device, GetContextString param);

        /// <inheritdoc />
        public abstract unsafe void GetContextProperty(void* device, GetContextInteger param, int count, void* data);

        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <returns></returns>
        public static ALContext GetAPI()
        {
            return APILoader.Load<ALContext, OpenALLibraryNameContainer>();
        }
    }
}
