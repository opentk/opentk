﻿// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    // Provides methods to access internal GdiPlus fields. This is necessary for
    // managed <-> native GdiPlus interoperability.
    // Note that the fields are named differently between .Net and Mono.
    // GdiPlus is considered deprecated by Microsoft - it is highly unlikely that
    // future framework upgrades will break this code, but it is something to
    // keep in mind.
    interface IGdiPlusInternals
    {
        IntPtr GetNativeGraphics(System.Drawing.Graphics graphics);

        IntPtr GetNativeFont(System.Drawing.Font font);

        IntPtr GetNativeStringFormat(System.Drawing.StringFormat format);
    }
}
