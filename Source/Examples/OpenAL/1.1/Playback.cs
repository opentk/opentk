#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Threading;
using System.IO;

using OpenTK.Audio;

namespace Examples
{
    [Example("Playback", ExampleCategory.OpenAL, "1.1", Documentation="Playback")]
    public class Playback
    {
        static readonly string filename = Path.Combine(Path.Combine("Data", "Audio"), "the_ring_that_fell.wav");

        public static void Main()
        {
            using (AudioContext context = new AudioContext())
            using (AudioReader sound = new AudioReader(filename))
            {
                Console.WriteLine("Testing WaveReader({0}).ReadToEnd()", filename);

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
                AL.DeleteSource(source);
                AL.DeleteBuffer(buffer);
            }
        }
    }
}
