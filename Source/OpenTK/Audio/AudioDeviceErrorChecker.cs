// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Audio.OpenAL;

namespace OpenTK.Audio
{
    struct AudioDeviceErrorChecker : IDisposable
    {
        #region Fields

        readonly IntPtr Device;
        static readonly string ErrorString = "Device {0} reported {1}.";

        #endregion

        #region Constructors

        public AudioDeviceErrorChecker(IntPtr device)
        {
            if (device == IntPtr.Zero)
                throw new AudioDeviceException();

            Device = device;
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            AlcError err = Alc.GetError(Device);
            switch (err)
            {
                case AlcError.OutOfMemory:
                    throw new OutOfMemoryException(String.Format(ErrorString, Device, err));
                
                case AlcError.InvalidValue:
                    throw new AudioValueException(String.Format(ErrorString, Device, err));
                
                case AlcError.InvalidDevice:
                    throw new AudioDeviceException(String.Format(ErrorString, Device, err));
                
                case AlcError.InvalidContext:
                    throw new AudioContextException(String.Format(ErrorString, Device, err));
                
                case AlcError.NoError:
                default:
                    // everything went fine, do nothing
                    break;
            }
        }

        #endregion
    }
}
