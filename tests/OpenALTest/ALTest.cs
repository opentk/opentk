using OpenTK.Audio;
using OpenTK.Audio.OpenAL;
using OpenTK.Audio.OpenAL.ALC;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace OpenALTest
{
    internal class ALTest
    {
        public static ALCContextAttributes GetContextAttributes(ALCDevice device)
        {
            int size = 0;
            ALC.GetInteger(device, OpenTK.Audio.OpenAL.ALC.GetPNameIV.AttributesSize, 1, ref size);
            int[] attributes = new int[size];
            ALC.GetInteger(device, OpenTK.Audio.OpenAL.ALC.GetPNameIV.AllAttributes, size, attributes);
            return ALCContextAttributes.FromArray(attributes);
        }

        public static unsafe List<string> ALCGetStringList(ALCDevice device, OpenTK.Audio.OpenAL.ALC.StringName name)
        {
            byte* result = ALC.GetString_(device, name);
            return ALStringListToList(result);

            static unsafe List<string> ALStringListToList(byte* alList)
            {
                if (alList == (byte*)0)
                {
                    return new List<string>();
                }

                var strings = new List<string>();

                byte* currentPos = alList;
                while (true)
                {
                    var currentString = Marshal.PtrToStringAnsi(new IntPtr(currentPos));
                    if (string.IsNullOrEmpty(currentString))
                    {
                        break;
                    }

                    strings.Add(currentString);
                    currentPos += currentString.Length + 1;
                }

                return strings;
            }
        }

        public static unsafe int LoadEffect(ReverbProperties preset)
        {
            AL.GetError();
            int effect = AL.EXT.GenEffect();
            AL.EXT.Effecti(effect, EffectPNameI.EffectType, (int)EffectType.EffectEaxreverb);
            var error = AL.GetError();
            if (error == OpenTK.Audio.OpenAL.ErrorCode.NoError)
            {
                Console.WriteLine("Using EAX reverb.");

                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbDensity, preset.Density);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbDiffusion, preset.Diffusion);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbGain, preset.Gain);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbGainhf, preset.GainHF);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbGainlf, preset.GainLF);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbDecayTime, preset.DecayTime);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbDecayHfratio, preset.DecayHFRatio);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbDecayLfratio, preset.DecayLFRatio);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbReflectionsGain, preset.ReflectionsGain);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbReflectionsDelay, preset.ReflectionsDelay);
                AL.EXT.Effectfv(effect, EffectPNameFV.EaxreverbReflectionsPan, ref Unsafe.AsRef(in preset.ReflectionsPan.X));
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbLateReverbGain, preset.LateReverbGain);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbLateReverbDelay, preset.LateReverbDelay);
                AL.EXT.Effectfv(effect, EffectPNameFV.EaxreverbLateReverbPan, ref Unsafe.AsRef(in preset.LateReverbPan.X));
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbEchoTime, preset.EchoTime);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbEchoDepth, preset.EchoDepth);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbModulationTime, preset.ModulationTime);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbModulationDepth, preset.ModulationDepth);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbAirAbsorptionGainhf, preset.AirAbsorptionGainHF);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbHfreference, preset.HFReference);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbLfreference, preset.LFReference);
                AL.EXT.Effectf(effect, EffectPNameF.EaxreverbRoomRolloffFactor, preset.RoomRolloffFactor);
                AL.EXT.Effecti(effect, EffectPNameI.EaxreverbDecayHflimit, preset.DecayHFLimit);
            }
            else
            {
                Console.WriteLine("Using standard reverb.");
                AL.EXT.Effecti(effect, EffectPNameI.EffectType, (int)EffectType.EffectReverb);

                AL.EXT.Effectf(effect, EffectPNameF.ReverbDensity, preset.Density);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbDiffusion, preset.Diffusion);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbGain, preset.Gain);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbGainhf, preset.GainHF);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbDecayTime, preset.DecayTime);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbDecayHfratio, preset.DecayHFRatio);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbReflectionsGain, preset.ReflectionsGain);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbReflectionsDelay, preset.ReflectionsDelay);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbLateReverbGain, preset.LateReverbGain);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbLateReverbDelay, preset.LateReverbDelay);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbAirAbsorptionGainhf, preset.AirAbsorptionGainHF);
                AL.EXT.Effectf(effect, EffectPNameF.ReverbRoomRolloffFactor, preset.RoomRolloffFactor);
                AL.EXT.Effecti(effect, EffectPNameI.ReverbDecayHflimit, preset.DecayHFLimit);
            }

            error = AL.GetError();
            if (error != OpenTK.Audio.OpenAL.ErrorCode.NoError)
            {
                Console.WriteLine($"Could not create effect, error: {error}");
            }

            return effect;
        }

        public static void Main()
        {
            Console.WriteLine("Hello!");
            var devices = ALCGetStringList(ALCDevice.Null, OpenTK.Audio.OpenAL.ALC.StringName.DeviceSpecifier);
            Console.WriteLine($"Devices: {string.Join(", ", devices)}");

            // Get the default device, then go though all devices and select the AL soft device if it exists.
            string deviceName = ALC.GetString(ALCDevice.Null, OpenTK.Audio.OpenAL.ALC.StringName.DefaultDeviceSpecifier);
            foreach (var d in devices)
            {
                if (d.Contains("OpenAL Soft"))
                {
                    deviceName = d;
                }
            }

            var allDevices = ALC.GetString(ALCDevice.Null, OpenTK.Audio.OpenAL.ALC.StringName.AllDevicesSpecifier);
            Console.WriteLine($"All Devices: {string.Join(", ", allDevices)}");

            var device = ALC.OpenDevice(deviceName);
            var context = ALC.CreateContext(device, (int[])null);
            ALC.MakeContextCurrent(context);

            ALLoader.SetALCDevice(device);

            CheckALError("Start");

            int alcMajorVersion = 0, alcMinorVersion = 0;
            ALC.GetInteger(device, OpenTK.Audio.OpenAL.ALC.GetPNameIV.MajorVersion, 1, ref alcMajorVersion);
            ALC.GetInteger(device, OpenTK.Audio.OpenAL.ALC.GetPNameIV.MinorVersion, 1, ref alcMinorVersion);
            string alcExts = ALC.GetString(device, OpenTK.Audio.OpenAL.ALC.StringName.Extensions);

            var attrs = GetContextAttributes(device);
            Console.WriteLine($"Attributes: {attrs}");

            string exts = AL.GetString(OpenTK.Audio.OpenAL.StringName.Extensions);
            string rend = AL.GetString(OpenTK.Audio.OpenAL.StringName.Renderer);
            string vend = AL.GetString(OpenTK.Audio.OpenAL.StringName.Vendor);
            string vers = AL.GetString(OpenTK.Audio.OpenAL.StringName.Version);

            Console.WriteLine($"Vendor: {vend}, \nVersion: {vers}, \nRenderer: {rend}, \nExtensions: {exts}, \nALC Version: {alcMajorVersion}.{alcMinorVersion}, \nALC Extensions: {alcExts}");

            Console.WriteLine("Available devices: ");
            var list = ALCGetStringList(ALCDevice.Null, OpenTK.Audio.OpenAL.ALC.StringName.AllDevicesSpecifier);
            foreach (var item in list)
            {
                Console.WriteLine("  " + item);
            }

            Console.WriteLine("Available capture devices: ");
            list = ALCGetStringList(ALCDevice.Null, OpenTK.Audio.OpenAL.ALC.StringName.CaptureDeviceSpecifier);
            foreach (var item in list)
            {
                Console.WriteLine("  " + item);
            }
            int auxSlot = 0;
            if (ALC.IsExtensionPresent(device, "ALC_EXT_EFX"))
            {
                Console.WriteLine("EFX extension is present!!");
                int effect = LoadEffect(ReverbPresets.CastleHall);
                AL.EXT.GenAuxiliaryEffectSlot(out auxSlot);
                AL.EXT.AuxiliaryEffectSloti(auxSlot, AuxEffectSlotPNameI.EffectslotEffect, effect);
            }

            // Record a second of data
            CheckALError("Before record");
            short[] recording = new short[44100 * 4];
            ALCDevice captureDevice = ALC.CaptureOpenDevice((string)null, 44100u, Format.FormatMono16, 1024);
            {
                string defaultCaptureName = ALC.GetString(captureDevice, OpenTK.Audio.OpenAL.ALC.StringName.CaptureDefaultDeviceSpecifier);
                string version = AL.GetString(OpenTK.Audio.OpenAL.StringName.Version);
                string vendor = AL.GetString(OpenTK.Audio.OpenAL.StringName.Vendor);
                string renderer = AL.GetString(OpenTK.Audio.OpenAL.StringName.Renderer);
                Console.WriteLine($"Recording 4 seconds of audio from {defaultCaptureName} OpenAL version: {version} {vendor} {renderer}...");
                ALC.CaptureStart(captureDevice);

                int current = 0;
                while (current < recording.Length)
                {
                    int samplesAvailable = ALC.GetInteger(captureDevice, OpenTK.Audio.OpenAL.ALC.GetPNameIV.CaptureSamples);
                    if (samplesAvailable > 512)
                    {
                        int samplesToRead = Math.Min(samplesAvailable, recording.Length - current);
                        ALC.CaptureSamples(captureDevice, ref recording[current], samplesToRead);
                        current += samplesToRead;
                    }
                    Thread.Yield();
                }

                ALC.CaptureStop(captureDevice);
            }
            CheckALError("After record");

            // Playback the recorded data
            CheckALError("Before data");
            AL.GenBuffer(out int alBuffer);
            // short[] sine = new short[44100 * 1];
            // FillSine(sine, 4400, 44100);
            // FillSine(recording, 440, 44100);
            AL.BufferData(alBuffer, Format.FormatMono16, ref recording[0], recording.Length * 2, 44100);
            CheckALError("After data");

            AL.Listenerf(ListenerPNameF.Gain, 0.1f);

            AL.GenSource(out int alSource);
            AL.Sourcef(alSource, SourcePNameF.Gain, 1f);
            AL.Sourcei(alSource, SourcePNameI.Buffer, alBuffer);
            if (ALC.IsExtensionPresent(device, "ALC_EXT_EFX"))
            {
                AL.Source3i(alSource, SourcePName3I.AuxiliarySendFilter, auxSlot, 0, 0);
            }
            AL.SourcePlay(alSource);

            Console.WriteLine("Before Playing: " + AL.GetString((OpenTK.Audio.OpenAL.StringName)AL.GetError()));

            if (ALC.IsExtensionPresent(device, "ALC_SOFT_device_clock"))
            {
                long[] clockLatency = new long[2];
                ALC.SOFT.GetInteger64vSOFT(device, GetPNameI64V.DeviceClockSoft, 2, clockLatency);
                Console.WriteLine("Clock: " + clockLatency[0] + ", Latency: " + clockLatency[1]);
                CheckALError(" ");
            }

            Span<long> offsets = stackalloc long[2];
            if (AL.IsExtensionPresent("AL_SOFT_source_latency"))
            {
                Vector2d values = default;
                AL.SOFT.GetSourcedvSOFT(alSource, SourceGetPNameDV.SecOffsetLatencySoft, ref values.X);
                AL.SOFT.GetSourcei64vSOFT(alSource, SourceGetPNameI64V.SampleOffsetLatencySoft, offsets);
                Console.WriteLine("Source latency: " + values);
                Console.WriteLine($"Source latency 2: {offsets[0] / (float)(1 << 32)}; {offsets[1]}");
                CheckALError(" ");
            }

            while ((SourceState)AL.GetSourcei(alSource, SourceGetPNameI.SourceState) == SourceState.Playing)
            {
                if (AL.IsExtensionPresent("AL_SOFT_source_latency"))
                {
                    Vector2d values = default;
                    AL.SOFT.GetSourcedvSOFT(alSource, SourceGetPNameDV.SecOffsetLatencySoft, ref values.X);
                    AL.SOFT.GetSourcei64vSOFT(alSource, SourceGetPNameI64V.SampleOffsetLatencySoft, offsets);
                    Console.WriteLine("Source latency: " + values);
                    Console.WriteLine($"Source latency 2: {offsets[0] / (float)(1 << 32)}; {offsets[1]}");
                    CheckALError(" ");
                }
                if (ALC.IsExtensionPresent(device, "ALC_SOFT_device_clock"))
                {
                    long[] clockLatency = new long[2];
                    ALC.SOFT.GetInteger64vSOFT(device, OpenTK.Audio.OpenAL.ALC.GetPNameI64V.DeviceClockSoft, 1, clockLatency);
                    Console.WriteLine("Clock: " + clockLatency[0] + ", Latency: " + clockLatency[1]);
                    CheckALError(" ");
                }

                Thread.Sleep(10);
            }

            AL.SourceStop(alSource);

            // Test float32 format extension
            if (AL.IsExtensionPresent("AL_EXT_float32")) {
                Console.WriteLine("Testing float32 format extension with a sine wave...");

                float[] sine = new float[44100 * 2];
                for (int i = 0; i < sine.Length; i++)
                {
                    sine[i] = MathF.Sin(440 * MathF.PI * 2 * (i / (float)sine.Length));
                }

                var buffer = AL.GenBuffer();
                AL.BufferData(buffer, Format.FormatMonoFloat32, sine, sine.Length * sizeof(float), 44100);

                AL.Listenerf(ListenerPNameF.Gain, 0.1f);

                AL.Sourcef(alSource, SourcePNameF.Gain, 1f);
                AL.Sourcei(alSource, SourcePNameI.Buffer, (int)buffer);

                AL.SourcePlay(alSource);

                while ((SourceState)AL.GetSourcei(alSource, SourceGetPNameI.SourceState) == SourceState.Playing)
                {
                    Thread.Sleep(10);
                }

                AL.SourceStop(alSource);
            }

            // Test double format extension
            if (AL.IsExtensionPresent("AL_EXT_double"))
            {
                Console.WriteLine("Testing float64 format extension with a saw wave...");

                double[] saw = new double[44100 * 2];
                for (int i = 0; i < saw.Length; i++)
                {
                    var t = (i / (double)saw.Length) * 440;
                    saw[i] = t - Math.Floor(t);
                }

                var buffer = AL.GenBuffer();
                AL.BufferData(buffer, Format.FormatMonoDoubleExt, saw, saw.Length * sizeof(double), 44100);

                AL.Listenerf(ListenerPNameF.Gain, 0.1f);

                AL.Sourcef(alSource, SourcePNameF.Gain, 1f);
                AL.Sourcei(alSource, SourcePNameI.Buffer, (int)buffer);

                AL.SourcePlay(alSource);

                while ((SourceState)AL.GetSourcei(alSource, SourceGetPNameI.SourceState) == SourceState.Playing)
                {
                    Thread.Sleep(10);
                }

                AL.SourceStop(alSource);
            }

            Console.WriteLine("Goodbye!");

            ALC.MakeContextCurrent(ALCContext.Null);
            ALC.DestroyContext(context);
            ALC.CloseDevice(device);
        }

        public static bool CheckALError(string str)
        {
            bool hadError = false;
            var error = AL.GetError();
            if (error != OpenTK.Audio.OpenAL.ErrorCode.NoError)
            {
                hadError = true;
                Console.WriteLine($"ALError at '{str}': {AL.GetString((OpenTK.Audio.OpenAL.StringName)error)}");
            }
            return hadError;
        }

        public static void FillSine(short[] buffer, float frequency, float sampleRate)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (short)(MathF.Sin((i * frequency * MathF.PI * 2) / sampleRate) * short.MaxValue);
            }
        }
    }
}
