// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Threading;

using OpenTK.Audio;


namespace Examples
{
#if false
    [Example("PlayStatic Sample", ExampleCategory.OpenAL)]
    public partial class PlayStatic
    {
        public static void Main()
        {
            AudioContext context = new AudioContext();

            Sound sound = new Sound("Data\\Audio\\Asterisk.wav");
            uint buffer;
            uint source;
            int state;

            Trace.WriteLine("PlayStatic Test Application\n");

            // Generate an AL Buffer
            AL.GenBuffers(out buffer);

            // Load Wave file into OpenAL Buffer
            AL.BufferData(buffer, sound.ReadToEnd());

            // Generate a Source to playback the Buffer
            AL.GenSources(out source);

            // Attach Source to Buffer
            AL.Source(source, ALSourcei.Buffer, (int)buffer);

            // Play Source
            AL.SourcePlay(source);
            Trace.WriteLine("Playing Source ");

            do
            {
                Thread.Sleep(100);
                Trace.Write(".");
                // Get Source State
                AL.GetSource(source, ALGetSourcei.SourceState, out state);
            } while ((ALSourceState)state == ALSourceState.Playing);

            Trace.WriteLine();

            // Clean up by deleting Source(s) and Buffer(s)
            AL.SourceStop(source);
            AL.DeleteSources(ref source);
            AL.DeleteBuffers(ref buffer);

            return;
        }
    }
#endif
}
