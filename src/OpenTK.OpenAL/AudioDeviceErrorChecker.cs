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
using OpenTK.OpenAL.Native;

namespace OpenTK.OpenAL
{
    /// <summary>
    /// A helper struct to mark a region with a using statement to be error checked for ALC errors, which get checked at the end of the using block or with a dispose statement.
    /// </summary>
    internal struct AudioDeviceErrorChecker : IDisposable
    {
        private static readonly string ErrorString = "Device {0} reported {1}.";

        private readonly IntPtr _device;

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeviceErrorChecker"/> struct.
        /// </summary>
        /// <param name="device">The ALC device handle.</param>
        /// <exception cref="AudioDeviceException">Thrown if <paramref name="device"/> is <seealso cref="IntPtr.Zero"/>.</exception>
        public AudioDeviceErrorChecker(IntPtr device)
        {
            if (device == IntPtr.Zero)
            {
                throw new AudioDeviceException();
            }

            this._device = device;
        }

        /// <summary>
        /// Checks for ALC errors.
        /// </summary>
        /// <exception cref="OutOfMemoryException">Thrown if an out of memory error occured in ALC.</exception>
        /// <exception cref="AudioValueException">Thrown if an invalid error occured in ALC.</exception>
        /// <exception cref="AudioDeviceException">Thrown if an invalid device error occured in ALC.</exception>
        /// <exception cref="AudioContextException">Thrown if an invalid context error occured in ALC.</exception>
        public void Dispose()
        {
            var err = Alc.GetError(_device);
            switch (err)
            {
                case AlcError.OutOfMemory:
                    throw new OutOfMemoryException(string.Format(ErrorString, _device, err));

                case AlcError.InvalidValue:
                    throw new AudioValueException(string.Format(ErrorString, _device, err));

                case AlcError.InvalidDevice:
                    throw new AudioDeviceException(string.Format(ErrorString, _device, err));

                case AlcError.InvalidContext:
                    throw new AudioContextException(string.Format(ErrorString, _device, err));

                case AlcError.NoError:
                default:
                    // everything went fine, do nothing
                    break;
            }
        }
    }
}
