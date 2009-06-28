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
using System.IO;

namespace OpenTK.Audio
{
    /// <summary>
    /// Encapsulates a sound stream and provides decoding and streaming capabilities.
    /// </summary>
    public class AudioReader : IDisposable
    {
        static object reader_lock = new object();
        static List<AudioReader> readers = new List<AudioReader>();

        bool disposed;
        Stream stream;
        AudioReader implementation;

        #region --- Constructors ---

        #region static AudioReader()

        static AudioReader()
        {
            // TODO: Plugin architecture for sound formats. This is overkill now that we only have a WaveReader (future proofing).
            readers.Add(new WaveReader());
        }

        #endregion

        #region protected AudioReader()

        protected AudioReader() { }

        #endregion

        #region public AudioReader(string filename)

        /// <summary>Creates a new AudioReader that can read the specified sound file.</summary>
        /// <param name="filename">The path to the sound file.</param>
        /// <returns>A new OpenTK.Audio.AudioReader, which can be used to read from the specified sound file.</returns>
        public AudioReader(string filename)
            : this(new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        { }

        #endregion

        #region public AudioReader(Stream s)

        /// <summary>Creates a new AudioReader that can read the specified soundstream.</summary>
        /// <param name="s">The System.IO.Stream to read from.</param>
        /// <returns>A new OpenTK.Audio.AudioReader, which can be used to read from the specified sound stream.</returns>
        public AudioReader(Stream s)
        {
            try
            {
                lock (reader_lock)
                {
                    foreach (AudioReader reader in readers)
                    {
                        long pos = s.Position;
                        if (reader.Supports(s))
                        {
                            s.Position = pos;
                            implementation = (AudioReader)
                                reader.GetType().GetConstructor(
                                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public |
                                    System.Reflection.BindingFlags.Instance,
                                    null,
                                    new Type[] { typeof(Stream) },
                                    null)
                                .Invoke(new object[] { s });
                            return;
                        }
                        s.Position = pos;
                    }
                }
            }
            catch (Exception)
            {
                s.Close();
                throw;
            }
            throw new NotSupportedException("Could not find a decoder for the specified sound stream.");
        }

        #endregion

        #endregion

        #region --- Public Members ---

        #region public virtual bool Supports(Stream s)

        /// <summary>When overriden in a derived class, checks if the decoder supports the specified sound stream.</summary>
        /// <param name="s">The System.IO.Stream to check.</param>
        /// <returns>True if the sound stream is supported; false otherwise.</returns>
        public virtual bool Supports(Stream s)
        {
            if (implementation != null)
                return implementation.Supports(s);
            throw new NotImplementedException();
        }

        #endregion

        #region public virtual SoundData<SampleType> ReadSamples(long count)

        /// <summary>
        /// When overriden in a derived class, reads and decodes the specified number of samples from the sound stream.
        /// </summary>
        /// <param name="count">The number of samples to read and decode.</param>
        /// <returns>An OpenTK.Audio.SoundData object that contains the decoded buffer.</returns>
        public virtual SoundData ReadSamples(long count)
        {
            if (implementation != null)
                return implementation.ReadSamples(count);
            throw new NotImplementedException();
        }

        #endregion

        #region public virtual SoundData<SampleType> ReadToEnd()

        /// <summary>
        /// When overriden in a derived class, reads and decodes the sound stream.
        /// </summary>
        /// <returns>An OpenTK.Audio.SoundData object that contains the decoded buffer.</returns>
        public virtual SoundData ReadToEnd()
        {
            if (implementation != null)
                return implementation.ReadToEnd();
            throw new NotImplementedException();
        }

        #endregion

        #region public virtual int Frequency

        /// <summary>
        /// 
        /// </summary>
        public virtual int Frequency
        {
            get
            {
                if (implementation != null)
                    return implementation.Frequency;
                else
                    throw new NotImplementedException();
            }
            protected set
            {
                if (implementation != null)
                    implementation.Frequency = value;
                else
                    throw new NotImplementedException();
            }
        }

        #endregion

        #region public virtual bool EndOfFile

        /// <summary>
        /// Returns true if the AudioReader has reached the end of the file.
        /// </summary>
        public virtual bool EndOfFile
        {
            get
            {
                if (implementation != null)
                    return implementation.EndOfFile;

                return this.Stream.Position >= this.Stream.Length;
            }
        }
        #endregion

        #endregion

        #region --- Protected Members ---

        /// <summary>
        /// Gets or sets the input <see cref="System.IO.Stream"/> of the AudioReader.
        /// </summary>
        protected virtual Stream Stream
        {
            get { return stream; }
            set { stream = value; }
        }

        #endregion

        #region IDisposable Members

        /// <summary>Closes the underlying Stream and disposes of the AudioReader resources.</summary>
        public virtual void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                    if (this.Stream != null)
                        this.Stream.Close();

                disposed = true;
            }
        }

        /// <summary>
        /// Finalizes this AudioReader.
        /// </summary>
        ~AudioReader()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
