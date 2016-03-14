// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Diagnostics;
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
                Trace.WriteLine("Testing WaveReader({0}).ReadToEnd()", filename);

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

                Trace.Write("Playing");

                // Query the source to find out when it stops playing.
                do
                {
                    Thread.Sleep(250);
                    Trace.Write(".");
                    AL.GetSource(source, ALGetSourcei.SourceState, out state);
                }
                while ((ALSourceState)state == ALSourceState.Playing);

                Trace.WriteLine("");

                AL.SourceStop(source);
                AL.DeleteSource(source);
                AL.DeleteBuffer(buffer);
                efx.DeleteEffect(effect);
                efx.DeleteAuxiliaryEffectSlot(slot);
            }
        }
    }
}