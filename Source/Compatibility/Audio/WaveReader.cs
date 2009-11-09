#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.IO;

using OpenTK.Audio;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Audio
{
    internal sealed class WaveReader : AudioReader
	{
        SoundData decoded_data;

		//RIFF header
		string signature;
		int riff_chunck_size;
		string format;
			
		//WAVE header
		string format_signature;
		int format_chunk_size;
		short audio_format;
		short channels;
		int sample_rate;
		int byte_rate;
		short block_align;
		short bits_per_sample;
			
		//DATA header
		string data_signature;
		int data_chunk_size;

        BinaryReader reader;

        internal WaveReader() { }

        internal WaveReader(Stream s)
        {
            if (s == null) throw new ArgumentNullException();
            if (!s.CanRead) throw new ArgumentException("Cannot read from specified Stream.");

            reader = new BinaryReader(s);
            this.Stream = s;
        }

#if false
		/// <summary>
		/// Writes the WaveSound's data to the specified OpenAL buffer in the correct format.
		/// </summary>
		/// <param name="bid">
		/// A <see cref="System.UInt32"/>
		/// </param>
        public void WriteToBuffer(uint bid)
        {
            unsafe
            {
                //fix the array as a byte
                fixed (byte* p_Data = _Data)
                {
                    if (Channels == 1)
                    {
                        if (BitsPerSample == 16)
                        {
                            Console.Write("Uploading 16-bit mono data to OpenAL...");
                            AL.BufferData(bid, ALFormat.Mono16, (IntPtr)p_Data, _Data.Length, SampleRate);
                        }
                        else
                        {
                            if (BitsPerSample == 8)
                            {
                                Console.Write("Uploading 8-bit mono data to OpenAL...");
                                AL.BufferData(bid, ALFormat.Mono8, (IntPtr)p_Data, _Data.Length, SampleRate);
                            }
                        }

                    }
                    else
                    {
                        if (Channels == 2)
                        {
                            if (BitsPerSample == 16)
                            {
                                Console.Write("Uploading 16-bit stereo data to OpenAL...");
                                AL.BufferData(bid, ALFormat.Stereo16, (IntPtr)p_Data, _Data.Length, SampleRate);
                            }
                            else
                            {
                                if (BitsPerSample == 8)
                                {
                                    Console.Write("Uploading 8-bit stereo data to OpenAL...");
                                    AL.BufferData(bid, ALFormat.Stereo8, (IntPtr)p_Data, _Data.Length, SampleRate);
                                }
                            }
                        }
                    }
                }
            }
        }

		/// <summary>
		/// Writes all relevent information about the WaveSound to the console window.
		/// </summary>
		public void DumpParamsToConsole()
		{			
			Console.WriteLine("AudioFormat:" + AudioFormat);
			Console.WriteLine("Channels:" + Channels);
			Console.WriteLine("SampleRate:" + SampleRate);
			Console.WriteLine("ByteRate:" + ByteRate);
			Console.WriteLine("BlockAlign:" + BlockAlign);
			Console.WriteLine("BitsPerSample:" + BitsPerSample);
		}
		
		/// <value>
		/// Returns the WaveSound's raw sound data as an array of bytes.
		/// </value>
		public byte[] Data
		{
			get
			{
				return _Data;
			}
		}
#endif

        #region --- Public Members ---

        #region public override bool Supports(Stream s)

        /// <summary>
        /// Checks whether the specified stream contains valid WAVE/RIFF buffer.
        /// </summary>
        /// <param name="s">The System.IO.Stream to check.</param>
        /// <returns>True if the stream is a valid WAVE/RIFF file; false otherwise.</returns>
        public override bool Supports(Stream s)
        {
            BinaryReader reader = new BinaryReader(s);
            return this.ReadHeaders(reader);
        }

        #endregion

        #region public override SoundData ReadSamples(int samples)

        /// <summary>
        /// Reads and decodes the specified number of samples from the sound stream.
        /// </summary>
        /// <param name="samples">The number of samples to read and decode.</param>
        /// <returns>An OpenTK.Audio.SoundData object that contains the decoded buffer.</returns>
        public override SoundData ReadSamples(long samples)
        {
            if (samples > reader.BaseStream.Length - reader.BaseStream.Position)
                samples = reader.BaseStream.Length - reader.BaseStream.Position;

            //while (samples > decoded_data.Data.Length * (bits_per_sample / 8))
            //    Array.Resize<byte>(ref decoded_data.Data, decoded_data.Data.Length * 2);

            decoded_data = new SoundData(new SoundFormat(channels, bits_per_sample, sample_rate),
                                                         reader.ReadBytes((int)samples));

            return decoded_data;
        }

        #endregion

        #region public override SoundData ReadToEnd()

        /// <summary>
        /// Reads and decodes the sound stream.
        /// </summary>
        /// <returns>An OpenTK.Audio.SoundData object that contains the decoded buffer.</returns>
        public override SoundData ReadToEnd()
        {
            try
            {
                //read the buffer into a byte array, even if the format is 16 bit
                //decoded_data = new byte[data_chunk_size];

                decoded_data = new SoundData(new SoundFormat(channels, bits_per_sample, sample_rate),
                                                             reader.ReadBytes((int)reader.BaseStream.Length));
                
                Debug.WriteLine("decoded!");

                //return new SoundData(decoded_data, new SoundFormat(channels, bits_per_sample, sample_rate));
                return decoded_data;
            }
            catch (AudioReaderException)
            {
                reader.Close();
                throw;
            }
        }

        #endregion

        #endregion

        #region --- Protected Members ---

        protected override Stream Stream
        {
            get { return base.Stream; }
            set
            {
                base.Stream = value;
                if (!ReadHeaders(reader))
                    throw new AudioReaderException("Invalid WAVE/RIFF file: invalid or corrupt signature.");

                Debug.Write(String.Format("Opened WAVE/RIFF file: ({0}, {1}, {2}, {3}) ", sample_rate.ToString(), bits_per_sample.ToString(),
                                          channels.ToString(), audio_format.ToString()));
            }
        }

        #endregion

        #region --- Private Members ---

        // Tries to read the WAVE/RIFF headers, and returns true if they are valid.
        bool ReadHeaders(BinaryReader reader)
        {
            // Don't explicitly call reader.Close()/.Dispose(), as that will close the inner stream.
            // There's no such danger if the BinaryReader isn't explicitly destroyed.

            // RIFF header
            signature = new string(reader.ReadChars(4));
            if (signature != "RIFF")
                return false;

            riff_chunck_size = reader.ReadInt32();

            format = new string(reader.ReadChars(4));
            if (format != "WAVE")
                return false;

            // WAVE header
            format_signature = new string(reader.ReadChars(4));
            if (format_signature != "fmt ")
                return false;

            format_chunk_size = reader.ReadInt32();
            audio_format = reader.ReadInt16();
            channels = reader.ReadInt16();
            sample_rate = reader.ReadInt32();
            byte_rate = reader.ReadInt32();
            block_align = reader.ReadInt16();
            bits_per_sample = reader.ReadInt16();

            data_signature = new string(reader.ReadChars(4));
            if (data_signature != "data")
                return false;

            data_chunk_size = reader.ReadInt32();

            return true;
        }

        #endregion
    }
}
