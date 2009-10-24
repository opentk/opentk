/*
 * Copyright (c) 2006, Creative Labs Inc.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification, are permitted provided
 * that the following conditions are met:
 * 
 *     * Redistributions of source code must retain the above copyright notice, this list of conditions and
 * 	     the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions
 * 	     and the following disclaimer in the documentation and/or other materials provided with the distribution.
 *     * Neither the name of Creative Labs Inc. nor the names of its contributors may be used to endorse or
 * 	     promote products derived from this software without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A
 * PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
 * ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
 * TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 */

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
