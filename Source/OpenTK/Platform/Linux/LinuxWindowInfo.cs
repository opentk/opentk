// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Diagnostics;
using OpenTK.Platform.Egl;

namespace OpenTK.Platform.Linux
{
    class LinuxWindowInfo : EglWindowInfo
    {
        public int FD { get; private set; }
        public LinuxDisplay DisplayDevice { get; private set; }
        public IntPtr BufferManager { get; private set; }

        public LinuxWindowInfo(IntPtr display, int fd, IntPtr gbm, LinuxDisplay display_device)
            : base(IntPtr.Zero, display, IntPtr.Zero)
        {
            if (display_device == null)
                throw new ArgumentNullException();

            FD = fd;
            BufferManager = gbm;
            DisplayDevice = display_device;
            // The window handle and surface handle must
            // be filled in manually once they are known.
        }
    }
}

