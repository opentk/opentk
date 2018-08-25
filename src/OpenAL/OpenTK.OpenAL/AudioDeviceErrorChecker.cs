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

namespace OpenTK.OpenAL
{
    /// <summary>
    /// Represents an error watchdog that can be used by wrapping calls to OpenAL in it.
    /// </summary>
    internal struct AudioDeviceErrorChecker : IDisposable
    {
        private readonly IntPtr _device;
        private static readonly string ErrorString = "Device {0} reported {1}.";

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

            _device = device;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            var err = ALContext.GetError(_device);
            switch (err)
            {
                case ContextError.OutOfMemory:
                {
                    throw new OutOfMemoryException(string.Format(ErrorString, _device, err));
                }
                case ContextError.InvalidValue:
                {
                    throw new AudioValueException(string.Format(ErrorString, _device, err));
                }
                case ContextError.InvalidDevice:
                {
                    throw new AudioDeviceException(string.Format(ErrorString, _device, err));
                }
                case ContextError.InvalidContext:
                {
                    throw new AudioContextException(string.Format(ErrorString, _device, err));
                }
            }
        }
    }
}
