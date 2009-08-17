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
using System.Threading;
using System.IO;
using OpenTK.Audio;
using OpenTK.Audio.OpenAL;

namespace Examples
{
    [Example("EFX: Reverb", ExampleCategory.OpenAL, "EFX", Documentation="EFXReverb")]
    public class ReverbExample
    {
        static readonly string filename = Path.Combine(Path.Combine("Data", "Audio"), "the_ring_that_fell.wav");

        public static void Main()
        {
            using (AudioContext context = new AudioContext())
            {
                Console.WriteLine("Testing WaveReader({0}).ReadToEnd()", filename);

                EffectsExtension efx = new EffectsExtension();

                int buffer = AL.GenBuffer();
                int source = AL.GenSource();
                int state;

                int effect = efx.GenEffect();
                int slot = efx.GenAuxiliaryEffectSlot();

                efx.BindEffect(effect, EfxEffectType.Reverb);
                efx.Effect(effect, EfxEffectf.ReverbDecayTime, 3.0f);
                efx.Effect(effect, EfxEffectf.ReverbDecayHFRatio, 0.91f);
                efx.Effect(effect, EfxEffectf.ReverbDensity, 0.7f);
                efx.Effect(effect, EfxEffectf.ReverbDiffusion, 0.9f);
                efx.Effect(effect, EfxEffectf.ReverbRoomRolloffFactor, 3.1f);
                efx.Effect(effect, EfxEffectf.ReverbReflectionsGain, 0.723f);
                efx.Effect(effect, EfxEffectf.ReverbReflectionsDelay, 0.03f);
                efx.Effect(effect, EfxEffectf.ReverbGain, 0.23f);

                efx.AuxiliaryEffectSlot(slot, EfxAuxiliaryi.EffectslotEffect, effect);

                int channels, bits, rate;
                byte[] data = Playback.LoadWave(File.Open(filename, FileMode.Open), out channels, out bits, out rate);
                AL.BufferData(buffer, Playback.GetSoundFormat(channels, bits), data, data.Length, rate);

                AL.Source(source, ALSourcef.ConeOuterGain, 1.0f);
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
                efx.DeleteEffect(effect);
                efx.DeleteAuxiliaryEffectSlot(slot);
            }
        }
    }
}