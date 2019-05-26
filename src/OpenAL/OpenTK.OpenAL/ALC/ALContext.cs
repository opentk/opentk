﻿//
// ALContext.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using OpenToolkit.Core;
using OpenToolkit.Core.Loader;
using OpenToolkit.OpenAL.Extensions;
using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// Provides access to the OpenAL 1.1 context API.
    /// </summary>
    public abstract class ALContext : NativeLibraryBase, IALC
    {
        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <returns>The instance.</returns>
        public static ALContext GetAPI()
        {
            return APILoader.Load<ALContext, OpenALLibraryNameContainer>();
        }

        /// <inheritdoc cref="NativeLibraryBase"/>
        protected ALContext(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <summary>
        /// Gets an instance of the API of an extension to the API.
        /// </summary>
        /// <typeparam name="TContextExtension">The extension type.</typeparam>
        /// <param name="device">The device the context is on.</param>
        /// <returns>The extension.</returns>
        public unsafe TContextExtension GetExtension<TContextExtension>(Device* device)
            where TContextExtension : ContextExtensionBase
        {
            return ALExtensionLoader.LoadContextExtension<TContextExtension>(device, this);
        }

        /// <inheritdoc />
        public abstract unsafe Context* CreateContext(Device* device, int* attributeList);

        /// <inheritdoc cref="CreateContext"/>
        public unsafe ContextHandle CreateContextHandle(Device* device, int* attributeList)
        {
            return new ContextHandle(CreateContext(device, attributeList));
        }

        /// <inheritdoc />
        public abstract unsafe bool MakeContextCurrent(Context* context);

        /// <inheritdoc cref="MakeContextCurrent(OpenToolkit.OpenAL.Context*)"/>
        public bool MakeContextCurrent(ContextHandle context)
        {
            unsafe
            {
                return MakeContextCurrent((Context*)context.Handle);
            }
        }

        /// <inheritdoc />
        public abstract unsafe void ProcessContext(Context* context);

        /// <inheritdoc />
        public abstract unsafe void SuspendContext(Context* context);

        /// <inheritdoc />
        public abstract unsafe void DestroyContext(Context* context);

        /// <inheritdoc />
        public abstract unsafe Context* GetCurrentContext();

        /// <inheritdoc cref="GetCurrentContext"/>
        public ContextHandle GetCurrentContextHandle()
        {
            unsafe
            {
                return new ContextHandle(GetCurrentContext());
            }
        }

        /// <inheritdoc />
        public abstract unsafe Device* GetContextsDevice(Context* context);

        /// <inheritdoc />
        public abstract unsafe Device* OpenDevice(string deviceName);

        /// <inheritdoc />
        public abstract unsafe bool CloseDevice(Device* device);

        /// <inheritdoc />
        public abstract unsafe ContextError GetError(Device* device);

        /// <inheritdoc />
        public abstract unsafe bool IsExtensionPresent(Device* device, string name);

        /// <inheritdoc />
        public abstract unsafe void* GetProcAddress(Device* device, string name);

        /// <inheritdoc />
        public abstract unsafe int GetEnumValue(Device* device, string name);

        /// <inheritdoc />
        public abstract unsafe string GetContextProperty(Device* device, GetContextString param);

        /// <inheritdoc />
        public abstract unsafe void GetContextProperty(Device* device, GetContextInteger param, int count, IntPtr data);
    }
}
