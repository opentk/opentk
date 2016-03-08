// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio
{
    /// <summary>Encapsulates a pointer to a decoded sound buffer.</summary>
    public class SoundData
    {
        byte[] buffer;
        SoundFormat format;

        #region --- Constructors ---

        /// <internal />
        /// <summary>Constructs a new SoundData object.</summary>
        /// <param name="format">The SoundFormat of these SoundData.</param>
        /// <param name="data">An array of PCM buffer.</param>
        internal SoundData(SoundFormat format, byte[] data)
        {
            if (data == null) throw new ArgumentNullException("buffer", "Must be a valid array of samples.");
            if (data.Length == 0) throw new ArgumentOutOfRangeException("buffer", "Data length must be higher than 0.");

            this.SoundFormat = format;

            buffer = new byte[data.Length];
            Array.Copy(data, buffer, data.Length);
        }

        #endregion

        /// <summary>Gets the raw PCM buffer.</summary>
        public byte[] Data { get { return buffer; } internal set { buffer = value; } }

        /// <summary>Gets the SoundFormat of the SoundData.</summary>
        public SoundFormat SoundFormat { get { return format; } internal set { format = value; } }
    }    
}
