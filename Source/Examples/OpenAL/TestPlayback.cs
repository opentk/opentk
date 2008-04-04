#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Threading;

using OpenTK.Audio;

namespace Examples
{
    [Example("Playback", ExampleCategory.OpenAL)]
    public partial class Playback
    {
        public static void Main()
        {
            const string file = "Data\\Audio\\the_ring_that_fell.wav";

            AudioContext context = new AudioContext();

            using (SoundReader sound = new SoundReader(file))
            {
                Console.WriteLine("Testing WaveReader({0}).ReadToEnd()", file);

                int buffer = AL.GenBuffer();
                int source = AL.GenSource();
                int state;

                AL.BufferData(buffer, sound.ReadToEnd());
                AL.Source(source, ALSourcei.Buffer, buffer);
                AL.SourcePlay(source);

                Console.Write("Playing");

                // Query the source to find out when it stops playing.
                do
                {
                    Thread.Sleep(250);
                    Console.Write(".");
                    AL.GetSource(source, ALGetSourcei.SourceState, out state);
                }
                while ((ALSourceState)state == ALSourceState.Playing);

                Console.WriteLine();

                AL.SourceStop(source);
                AL.DeleteSources(ref source);
                AL.DeleteBuffers(ref buffer);

                sound.Dispose();
            }
        }

        #region static void TestWaveReaderStreaming(string filename)

        static void TestWaveReaderStreaming(string filename)
        {
            using (SoundReader sound = new SoundReader(filename))
            {
                int[] buffers = AL.GenBuffers(2);
                int source = AL.GenSource();
                int state;

                Console.WriteLine("Testing WaveReader({0}).ReadSamples()", filename);

                Console.Write("Playing");

                //new Thread().Start(buffers



                // Query the source to find out when it stops playing.
                do
                {
                    Thread.Sleep(100);
                    Console.Write(".");
                    AL.GetSource(source, ALGetSourcei.SourceState, out state);
                } while ((ALSourceState)state == ALSourceState.Playing);

                Console.WriteLine();

                AL.SourceStop(source);
                AL.DeleteSources(ref source);
                AL.DeleteBuffers(buffers);

                sound.Dispose();
            }
        }

        class SoundStreamer
        {
            public SoundStreamer(SoundReader sound, int source, int[] buffers)
            {
                while (!sound.EndOfFile)
                {
                    int processed_count;
                    AL.GetSource(source, ALGetSourcei.BuffersProcessed, out processed_count);
                    while (processed_count-- > 0)
                    {
                        int buffer = AL.SourceUnqueueBuffer(source);
                        AL.BufferData(buffer, sound.ReadSamples(8096));
                        AL.SourceQueueBuffer(source, buffer);
                    }
                }
            }
        }

        #endregion
    }
}
