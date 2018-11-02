//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using OpenToolkit.Core.Loader;
using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// Represents an error watchdog that can be used by wrapping calls to OpenAL in it.
    /// </summary>
    public struct AudioDeviceErrorChecker : IDisposable
    {
        private readonly unsafe Device* _device;
        private static readonly IContextErrors ErrorAPI = APILoader.Load<ALContext, OpenALLibraryNameContainer>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeviceErrorChecker"/> struct.
        /// </summary>
        /// <param name="device">The device to monitor.</param>
        public AudioDeviceErrorChecker(IntPtr device)
        {
            if (device == IntPtr.Zero)
            {
                throw new AudioDeviceException();
            }

            unsafe
            {
                _device = (Device*)device.ToPointer();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeviceErrorChecker"/> struct.
        /// </summary>
        /// <param name="device">The device to monitor.</param>
        public unsafe AudioDeviceErrorChecker(Device* device)
            : this(new IntPtr(device))
        {
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            unsafe
            {
                var err = ErrorAPI.GetError(_device);

                if (err == ContextError.NoError)
                {
                    return;
                }

                var message = $"Device {new UIntPtr(_device).ToString()} reported {err}.";
                switch (err)
                {
                    case ContextError.OutOfMemory:
                    {
                        throw new OutOfMemoryException(message);
                    }
                    case ContextError.InvalidValue:
                    {
                        throw new AudioValueException(message);
                    }
                    case ContextError.InvalidDevice:
                    {
                        throw new AudioDeviceException(message);
                    }
                    case ContextError.InvalidContext:
                    {
                        throw new AudioContextException(message);
                    }
                }
            }
        }
    }
}
