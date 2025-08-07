using OpenTK.Audio;
using OpenTK.Audio.OpenAL;
using OpenTK.Audio.OpenAL.ALC;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
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
                AL.EXT.GenEffect(out int effect);
                AL.EXT.Effecti(effect, EffectPNameI.EffectType, (int)EffectType.EffectReverb);
                AL.EXT.GenAuxiliaryEffectSlot(out auxSlot);
                AL.EXT.AuxiliaryEffectSloti(auxSlot, AuxEffectSlotPNameI.EffectslotEffect, effect);
            }

            // Record a second of data
            CheckALError("Before record");
            short[] recording = new short[44100 * 4];
            ALCDevice captureDevice = ALC.CaptureOpenDevice((string)null, 44100u, Format.FormatMono16, 1024);
            {
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

        public static void CheckALError(string str)
        {
            var error = AL.GetError();
            if (error != OpenTK.Audio.OpenAL.ErrorCode.NoError)
            {
                Console.WriteLine($"ALError at '{str}': {AL.GetString((OpenTK.Audio.OpenAL.StringName)error)}");
            }
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
