using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OpenTK.Audio.OpenAL
{
    internal class ALTest
    {
        public static void Main()
        {
            Console.WriteLine("Hello!");
            var devices = ALC.GetStringList(GetEnumerationStringList.DeviceSpecifier);
            Console.WriteLine($"Devices: {string.Join(", ", devices)}");

            // Get the default device, then go though all devices and select the AL soft device if it exists.
            string deviceName = ALC.GetString(ALDevice.Null, AlcGetString.DefaultDeviceSpecifier);
            foreach (var d in devices)
            {
                if (d.Contains("OpenAL Soft"))
                {
                    deviceName = d;
                }
            }

            var allDevices = ALC.EnumerateAll.GetStringList(GetEnumerateAllContextStringList.AllDevicesSpecifier);
            Console.WriteLine($"All Devices: {string.Join(", ", allDevices)}");

            var device = ALC.OpenDevice(deviceName);
            var context = ALC.CreateContext(device, (int[])null);
            ALC.MakeContextCurrent(context);

            CheckALError("Start");

            ALC.GetInteger(device, AlcGetInteger.MajorVersion, 1, out int alcMajorVersion);
            ALC.GetInteger(device, AlcGetInteger.MinorVersion, 1, out int alcMinorVersion);
            string alcExts = ALC.GetString(device, AlcGetString.Extensions);

            var attrs = ALC.GetContextAttributes(device);
            Console.WriteLine($"Attributes: {attrs}");

            string exts = AL.Get(ALGetString.Extensions);
            string rend = AL.Get(ALGetString.Renderer);
            string vend = AL.Get(ALGetString.Vendor);
            string vers = AL.Get(ALGetString.Version);

            Console.WriteLine($"Vendor: {vend}, \nVersion: {vers}, \nRenderer: {rend}, \nExtensions: {exts}, \nALC Version: {alcMajorVersion}.{alcMinorVersion}, \nALC Extensions: {alcExts}");

            Console.WriteLine("Available devices: ");
            var list = ALC.EnumerateAll.GetStringList(GetEnumerateAllContextStringList.AllDevicesSpecifier);
            foreach (var item in list)
            {
                Console.WriteLine("  " + item);
            }

            Console.WriteLine("Available capture devices: ");
            list = ALC.GetStringList(GetEnumerationStringList.CaptureDeviceSpecifier);
            foreach (var item in list)
            {
                Console.WriteLine("  " + item);
            }
            int auxSlot = 0;
            if (ALC.EFX.IsExtensionPresent(device))
            {
                Console.WriteLine("EFX extension is present!!");
                ALC.EFX.GenEffect(out int effect);
                ALC.EFX.Effect(effect, EffectInteger.EffectType, (int)EffectType.Reverb);
                ALC.EFX.GenAuxiliaryEffectSlot(out auxSlot);
                ALC.EFX.AuxiliaryEffectSlot(auxSlot, EffectSlotInteger.Effect, effect);
            }

            // Record a second of data
            CheckALError("Before record");
            short[] recording = new short[44100 * 4];
            ALCaptureDevice captureDevice = ALC.CaptureOpenDevice(null, 44100, ALFormat.Mono16, 1024);
            {
                ALC.CaptureStart(captureDevice);

                int current = 0;
                while (current < recording.Length)
                {
                    int samplesAvailable = ALC.GetInteger(captureDevice, AlcGetInteger.CaptureSamples);
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
            AL.BufferData(alBuffer, ALFormat.Mono16, ref recording[0], recording.Length * 2, 44100);
            CheckALError("After data");

            AL.Listener(ALListenerf.Gain, 0.1f);

            AL.GenSource(out int alSource);
            AL.Source(alSource, ALSourcef.Gain, 1f);
            AL.Source(alSource, ALSourcei.Buffer, alBuffer);
            if (ALC.EFX.IsExtensionPresent(device))
            {
                ALC.EFX.Source(alSource, EFXSourceInteger3.AuxiliarySendFilter, auxSlot, 0, 0);
            }
            AL.SourcePlay(alSource);

            Console.WriteLine("Before Playing: " + AL.GetErrorString(AL.GetError()));

            if (ALC.DeviceClock.IsExtensionPresent(device))
            {
                long[] clockLatency = new long[2];
                ALC.DeviceClock.GetInteger(device, GetInteger64.DeviceClock, clockLatency);
                Console.WriteLine("Clock: " + clockLatency[0] + ", Latency: " + clockLatency[1]);
                CheckALError(" ");
            }

            if (AL.SourceLatency.IsExtensionPresent())
            {
                AL.SourceLatency.GetSource(alSource, SourceLatencyVector2d.SecOffsetLatency, out var values);
                AL.SourceLatency.GetSource(alSource, SourceLatencyVector2i.SampleOffsetLatency, out var values1, out var values2, out var values3);
                Console.WriteLine("Source latency: " + values);
                Console.WriteLine($"Source latency 2: {Convert.ToString(values1, 2)}, {values2}; {values3}");
                CheckALError(" ");
            }

            while ((ALSourceState)AL.GetSource(alSource, ALGetSourcei.SourceState) == ALSourceState.Playing)
            {
                if (AL.SourceLatency.IsExtensionPresent())
                {
                    AL.SourceLatency.GetSource(alSource, SourceLatencyVector2d.SecOffsetLatency, out var values);
                    AL.SourceLatency.GetSource(alSource, SourceLatencyVector2i.SampleOffsetLatency, out var values1, out var values2, out var values3);
                    Console.WriteLine("Source latency: " + values);
                    Console.WriteLine($"Source latency 2: {Convert.ToString(values1, 2)}, {values2}; {values3}");
                    CheckALError(" ");
                }
                if (ALC.DeviceClock.IsExtensionPresent(device))
                {
                    long[] clockLatency = new long[2];
                    ALC.DeviceClock.GetInteger(device, GetInteger64.DeviceClock, 1, clockLatency);
                    Console.WriteLine("Clock: " + clockLatency[0] + ", Latency: " + clockLatency[1]);
                    CheckALError(" ");
                }

                Thread.Sleep(10);
            }

            AL.SourceStop(alSource);

            // Test float32 format extension
            if (AL.EXTFloat32.IsExtensionPresent()) {
                Console.WriteLine("Testing float32 format extension with a sine wave...");

                float[] sine = new float[44100 * 2];
                for (int i = 0; i < sine.Length; i++)
                {
                    sine[i] = MathF.Sin(440 * MathF.PI * 2 * (i / (float)sine.Length));
                }

                var buffer = AL.GenBuffer();
                AL.EXTFloat32.BufferData(buffer, FloatBufferFormat.Mono, sine, 44100);

                AL.Listener(ALListenerf.Gain, 0.1f);

                AL.Source(alSource, ALSourcef.Gain, 1f);
                AL.Source(alSource, ALSourcei.Buffer, buffer);

                AL.SourcePlay(alSource);

                while ((ALSourceState)AL.GetSource(alSource, ALGetSourcei.SourceState) == ALSourceState.Playing)
                {
                    Thread.Sleep(10);
                }

                AL.SourceStop(alSource);
            }

            // Test double format extension
            if (AL.EXTDouble.IsExtensionPresent())
            {
                Console.WriteLine("Testing float64 format extension with a saw wave...");

                double[] saw = new double[44100 * 2];
                for (int i = 0; i < saw.Length; i++)
                {
                    var t = (i / (double)saw.Length) * 440;
                    saw[i] = t - Math.Floor(t);
                }

                var buffer = AL.GenBuffer();
                AL.EXTDouble.BufferData(buffer, DoubleBufferFormat.Mono, saw, 44100);

                AL.Listener(ALListenerf.Gain, 0.1f);

                AL.Source(alSource, ALSourcef.Gain, 1f);
                AL.Source(alSource, ALSourcei.Buffer, buffer);

                AL.SourcePlay(alSource);

                while ((ALSourceState)AL.GetSource(alSource, ALGetSourcei.SourceState) == ALSourceState.Playing)
                {
                    Thread.Sleep(10);
                }

                AL.SourceStop(alSource);
            }

            Console.WriteLine("Goodbye!");

            ALC.MakeContextCurrent(ALContext.Null);
            ALC.DestroyContext(context);
            ALC.CloseDevice(device);
        }

        public static void CheckALError(string str)
        {
            ALError error = AL.GetError();
            if (error != ALError.NoError)
            {
                Console.WriteLine($"ALError at '{str}': {AL.GetErrorString(error)}");
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
