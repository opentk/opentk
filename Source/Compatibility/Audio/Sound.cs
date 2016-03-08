﻿// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OpenTK.Audio
{
#if false
    /// <summary>Defines methods to load and hold sound buffer.</summary>
    public class Sound<SampleType> : IDisposable
    {
        bool disposed;
        SoundReader<SampleType> reader;
        SoundData<SampleType> data;

        public Sound(Stream s)
        {
            if (s == null) throw new ArgumentNullException("s", "Must be a valid System.IO.Stream.");

            reader = SoundReader.Create(s);
        }

        public Sound(string filename)
        {
            if (String.IsNullOrEmpty(filename)) throw new ArgumentNullException("s", "Must be a valid System.IO.Stream.");

            reader = SoundReader.Create(filename);
        }

        #region --- Public Members ---

        public SoundData ReadSamples(int count)
        {
            if (count <= 0) throw new ArgumentOutOfRangeException("count", "Must be larger than zero.");
            throw new NotImplementedException();
        }

        public SoundData ReadToEnd()
        {
            return reader.ReadToEnd();
        }

        public SoundData SoundData { get { return data; } }

        public void WriteToBuffer(int buffer, int length)
        {
            if (buffer == 0) throw new ArgumentOutOfRangeException("buffer", "May not be zero.");
        }

        #endregion

        #region --- IDisposable Members ---

        /// <summary>Disposes of the sound buffer.</summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                    reader.Dispose();
                disposed = true;
            }
        }

        ~Sound()
        {
            this.Dispose(false);
        }

        #endregion
    }
#endif
}
