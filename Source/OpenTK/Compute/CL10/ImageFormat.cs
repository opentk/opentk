// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
#if EXPERIMENTAL

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Compute.CL10
{
    /// <summary>
    /// Defines the format of an OpenCL image.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ImageFormat
    {
        ChannelOrder image_channel_order;
        ChannelType image_channel_data_type;

        /// <summary>
        /// Gets or sets a <see cref="ChannelOrder"/> value, which indicates the order of the image channels.
        /// </summary>
        public ChannelOrder ChannelOrder { get { return image_channel_order; } set { image_channel_order = value; } }

        /// <summary>
        /// Gets or sets a <see cref="ChannelType"/> value, which indicates the data type of each image channel.
        /// </summary>
        public ChannelType ChannelType { get { return image_channel_data_type; } set { image_channel_data_type = value; } }
    }
}

#endif