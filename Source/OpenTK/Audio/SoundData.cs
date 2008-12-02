#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio
{
    /// <summary>Encapsulates a pointer to a decoded sound buffer.</summary>
    public class SoundData
    {
        byte[] buffer;
        //int data_length;        // The actual position of the last sample (the buffer may be larger than this).
        SoundFormat format;

        #region --- Constructors ---

        /// <internal />
        /// <summary>Constructs a new SoundData object.</summary>
        /// <param name="buffer">An array of PCM buffer.</param>
        internal SoundData(SoundFormat format, byte[] data)
        {
            if (data == null) throw new ArgumentNullException("buffer", "Must be a valid array of samples.");
            if (data.Length == 0) throw new ArgumentOutOfRangeException("buffer", "Data length must be higher than 0.");
            //Type t = typeof(SampleType);
            //if (!(t == typeof(Byte) || t == typeof(SByte) || t == typeof(Int16) || t == typeof(UInt16) || t == typeof(Int32) ||
            //      t == typeof(UInt32) || t == typeof(Int64) || t == typeof(UInt64) || t == typeof(Single)))
            //    throw new ArgumentException(
            //        "SoundData must have one of the following types: byte, short, int, long, float or their unsigned equivalents.");

            this.SoundFormat = format;

            buffer = new byte[OpenTK.Math.Functions.NextPowerOfTwo(data.Length)];
            Array.Copy(data, buffer, data.Length);
            //buffer = (byte[])data.Clone();
        }

        #endregion

        /// <summary>Gets the raw PCM buffer.</summary>
        public byte[] Data { get { return buffer; } internal set { buffer = value; } }

        /// <summary>Gets the SoundFormat of the SoundData.</summary>
        public SoundFormat SoundFormat { get { return format; } internal set { format = value; } }
    }    
}
