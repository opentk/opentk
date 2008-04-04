#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;

namespace OpenTK.Audio
{
    /// <summary>Describes the format of the SoundData.</summary>
    public struct SoundFormat
    {
        #region --- Constructors ---

        /// <summary>Constructs a new SoundFormat.</summary>
        public SoundFormat(int channels, int bitsPerSample, int sampleRate)
        {
            if (sampleRate <= 0) throw new ArgumentOutOfRangeException("sampleRate", "Must be higher than 0.");

            SampleFormat = 0;

            switch (channels)
            {
                case 1:
                    if (bitsPerSample == 8) SampleFormat = SampleFormat.Mono8;
                    else if (bitsPerSample == 16) SampleFormat = SampleFormat.Mono16;
                    break;

                case 2:
                    if (bitsPerSample == 8) SampleFormat = SampleFormat.Stereo8;
                    else if (bitsPerSample == 16) SampleFormat = SampleFormat.Stereo16;
                    break;
            }
            SampleRate = sampleRate;
        }

        #endregion

        #region --- Public Members ---

        /// <summary>Describes the SampleFormat of the SoundData.</summary>
        public readonly SampleFormat SampleFormat;

        /// <summary>Describes the sample rate (frequency) of the SoundData.</summary>
        public readonly int SampleRate;

        /// <summary>Gets the SampleFormat of the buffer as an OpenTK.Audio.ALFormat enumeration.</summary>
        public OpenTK.Audio.ALFormat SampleFormatAsOpenALFormat
        {
            get
            {
                switch (SampleFormat)
                {
                    case SampleFormat.Mono8: return OpenTK.Audio.ALFormat.Mono8;
                    case SampleFormat.Mono16: return OpenTK.Audio.ALFormat.Mono16;
                    case SampleFormat.Stereo8: return OpenTK.Audio.ALFormat.Stereo8;
                    case SampleFormat.Stereo16: return OpenTK.Audio.ALFormat.Stereo16;
                    default: throw new NotSupportedException("Unknown PCM SampleFormat.");
                }
            }
        }

        #endregion
    }

    #region public enum SampleFormat

    /// <summary>Defines the available formats for SoundData.</summary>
    public enum SampleFormat
    {
        /// <summary>8 bits per sample, 1 channel.</summary>
        Mono8 = OpenTK.Audio.ALFormat.Mono8,
        /// <summary>16 bits per sample, 1 channel.</summary>
        Mono16 = OpenTK.Audio.ALFormat.Mono16,
        /// <summary>8 bits per sample, 2 channels.</summary>
        Stereo8 = OpenTK.Audio.ALFormat.Stereo8,
        /// <summary>16 bits per sample, 2 channels.</summary>
        Stereo16 = OpenTK.Audio.ALFormat.Stereo16
    }

    #endregion
}