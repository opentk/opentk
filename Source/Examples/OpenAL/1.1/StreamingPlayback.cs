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
using System.Threading;
using System.ComponentModel;

using OpenTK.Audio;

namespace Examples.OpenAL
{
    // Not working correctly (sound pops).

    //[Example("Streaming Playback", ExampleCategory.OpenAL)]
    public class StreamingPlayback
    {
        const string filename = "Data\\Audio\\the_ring_that_fell.wav";
        const int buffer_size = (int)(0.5*44100);
        const int buffer_count = 4;

        //static object openal_lock = new object();   // Should be global in your app.

        public static void Main()
        {
            using (AudioContext context = new AudioContext())
            using (AudioReader sound = new AudioReader(filename))
            {
                int source = AL.GenSource();
                int[] buffers = AL.GenBuffers(buffer_count);
                int state;

                Console.WriteLine("Testing WaveReader({0}).ReadSamples()", filename);

                Console.Write("Playing");

                foreach (int buffer in buffers)
                    AL.BufferData(buffer, sound.ReadSamples(buffer_size));
                AL.SourceQueueBuffers(source, buffers.Length, buffers);
                AL.SourcePlay(source);

                int processed_count, queued_count;

                do
                {
                    //Console.Write(".");

                    do
                    {
                        AL.GetSource(source, ALGetSourcei.BuffersProcessed, out processed_count);
                        //Thread.Sleep(1);
                    }
                    while (processed_count == 0);

                    Console.WriteLine(processed_count);
                    while (processed_count > 0)
                    {
                        int buffer = AL.SourceUnqueueBuffer(source);
                        if (buffer != 0 && !sound.EndOfFile)
                        {
                            Console.WriteLine("    " + buffer.ToString());
                            AL.BufferData(buffer, sound.ReadSamples(buffer_size));
                            AL.SourceQueueBuffer(source, buffer);
                        }
                        --processed_count;
                    }

                    AL.GetSource(source, ALGetSourcei.BuffersQueued, out queued_count);
                    if (queued_count > 0)
                    {
                        AL.GetSource(source, ALGetSourcei.SourceState, out state);
                        if ((ALSourceState)state != ALSourceState.Playing)
                        {
                            AL.SourcePlay(source);
                            Console.WriteLine("r");
                        }
                    }
                    else
                        break;
                }
                while (true);

                AL.SourceStop(source);
                AL.DeleteSource(source);
                AL.DeleteBuffers(buffers);
            }

            Console.WriteLine();
        }
    }
}
