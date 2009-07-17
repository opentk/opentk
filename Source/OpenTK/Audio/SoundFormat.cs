#region License
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