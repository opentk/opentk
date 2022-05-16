﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenTK.Audio.OpenAL.Extensions.Creative.EFX;
using OpenTK.Audio.OpenAL.Extensions.EXT.Double;
using OpenTK.Audio.OpenAL.Extensions.EXT.Float32;
using OpenTK.Audio.OpenAL.Extensions.EXT.FloatFormat;
using OpenTK.Audio.OpenAL.Extensions.SOFT.HRTF;

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

            var allDevices = Extensions.Creative.EnumerateAll.EnumerateAll.GetStringList(Extensions.Creative.EnumerateAll.GetEnumerateAllContextStringList.AllDevicesSpecifier);
            Console.WriteLine($"All Devices: {string.Join(", ", allDevices)}");

            ALContextAttributes attribs = new ALContextAttributes();
            HRTF.AddHRTFAttribute(attribs, HRTFAttributeValue.DontCare);

            var device = ALC.OpenDevice(deviceName);
            var context = ALC.CreateContext(device, attribs);
            ALC.MakeContextCurrent(context);

            if (HRTF.IsExtensionPresent(device))
            {
                HRTF.Device = device;

                Console.WriteLine($"HRTF Available, trying to activate it...");
                attribs = new ALContextAttributes();
                HRTF.AddHRTFAttribute(attribs, HRTFAttributeValue.True);
                attribs.AddAttribute((int)HRTFAttribute.HRTF_ID, 0);
                bool b = HRTF.ResetDeviceSOFT(device, attribs);
                Console.WriteLine(b);

                CheckALCError(device, "Reset device");
                CheckALError("Reset device");

                Console.WriteLine($"HRTF Status: {HRTF.GetHRTFStatus(device)}");

                HRTF.GetInteger(device, HRTFInteger.NumHRTFSpecifierSOFT, out int hrtfs);
                Console.WriteLine($"Number of HRTFs: {hrtfs}");
                for (int i = 0; i < hrtfs; i++)
                {
                    Console.WriteLine($"HRTF 0: {HRTF.GetStringSOFT(device, HRTFAttribute.HRTF, i)}");
                }
            }

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
            var list = Extensions.Creative.EnumerateAll.EnumerateAll.GetStringList(Extensions.Creative.EnumerateAll.GetEnumerateAllContextStringList.AllDevicesSpecifier);
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
            if (EFX.IsExtensionPresent(device))
            {
                Console.WriteLine("EFX extension is present!!");
                EFX.GenEffect(out int effect);
                EFX.Effect(effect, EffectInteger.EffectType, (int)EffectType.Reverb);
                EFX.GenAuxiliaryEffectSlot(out auxSlot);
                EFX.AuxiliaryEffectSlot(auxSlot, EffectSlotInteger.Effect, effect);
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
                    int samplesAvailable = ALC.GetAvailableSamples(captureDevice);
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
            if (EFX.IsExtensionPresent(device))
            {
                EFX.Source(alSource, EFXSourceInteger3.AuxiliarySendFilter, auxSlot, 0, 0);
            }
            AL.SourcePlay(alSource);

            Console.WriteLine("Before Playing: " + AL.GetErrorString(AL.GetError()));

            if (Extensions.SOFT.DeviceClock.DeviceClock.IsExtensionPresent(device))
            {
                long[] clockLatency = new long[2];
                Extensions.SOFT.DeviceClock.DeviceClock.GetInteger(device, Extensions.SOFT.DeviceClock.GetInteger64.DeviceClock, clockLatency);
                Console.WriteLine("Clock: " + clockLatency[0] + ", Latency: " + clockLatency[1]);
                CheckALError(" ");
            }

            if (Extensions.SOFT.SourceLatency.SourceLatency.IsExtensionPresent())
            {
                Extensions.SOFT.SourceLatency.SourceLatency.GetSource(alSource, Extensions.SOFT.SourceLatency.SourceLatencyVector2d.SecOffsetLatency, out var values);
                Extensions.SOFT.SourceLatency.SourceLatency.GetSource(alSource, Extensions.SOFT.SourceLatency.SourceLatencyVector2i.SampleOffsetLatency, out var values1, out var values2, out var values3);
                Console.WriteLine("Source latency: " + values);
                Console.WriteLine($"Source latency 2: {Convert.ToString(values1, 2)}, {values2}; {values3}");
                CheckALError(" ");
            }

            while (AL.GetSourceState(alSource) == ALSourceState.Playing)
            {
                if (Extensions.SOFT.SourceLatency.SourceLatency.IsExtensionPresent())
                {
                    Extensions.SOFT.SourceLatency.SourceLatency.GetSource(alSource, Extensions.SOFT.SourceLatency.SourceLatencyVector2d.SecOffsetLatency, out var values);
                    Extensions.SOFT.SourceLatency.SourceLatency.GetSource(alSource, Extensions.SOFT.SourceLatency.SourceLatencyVector2i.SampleOffsetLatency, out var values1, out var values2, out var values3);
                    Console.WriteLine("Source latency: " + values);
                    Console.WriteLine($"Source latency 2: {Convert.ToString(values1, 2)}, {values2}; {values3}");
                    CheckALError(" ");
                }
                if (Extensions.SOFT.DeviceClock.DeviceClock.IsExtensionPresent(device))
                {
                    long[] clockLatency = new long[2];
                    Extensions.SOFT.DeviceClock.DeviceClock.GetInteger(device, Extensions.SOFT.DeviceClock.GetInteger64.DeviceClock, 1, clockLatency);
                    Console.WriteLine("Clock: " + clockLatency[0] + ", Latency: " + clockLatency[1]);
                    CheckALError(" ");
                }

                Thread.Sleep(10);
            }

            AL.SourceStop(alSource);

            // Test float32 format extension
            if (EXTFloat32.IsExtensionPresent()) {
                Console.WriteLine("Testing float32 format extension with a sine wave...");

                float[] sine = new float[44100 * 2];
                for (int i = 0; i < sine.Length; i++)
                {
                    sine[i] = MathF.Sin(440 * MathF.PI * 2 * (i / (float)sine.Length));
                }

                var buffer = AL.GenBuffer();
                EXTFloat32.BufferData(buffer, FloatBufferFormat.Mono, sine, 44100);

                AL.Listener(ALListenerf.Gain, 0.1f);

                AL.Source(alSource, ALSourcef.Gain, 1f);
                AL.Source(alSource, ALSourcei.Buffer, buffer);

                AL.SourcePlay(alSource);

                while (AL.GetSourceState(alSource) == ALSourceState.Playing)
                {
                    Thread.Sleep(10);
                }

                AL.SourceStop(alSource);
            }

            // Test double format extension
            if (EXTDouble.IsExtensionPresent())
            {
                Console.WriteLine("Testing float64 format extension with a saw wave...");

                double[] saw = new double[44100 * 2];
                for (int i = 0; i < saw.Length; i++)
                {
                    var t = (i / (double)saw.Length) * 440;
                    saw[i] = t - Math.Floor(t);
                }

                var buffer = AL.GenBuffer();
                EXTDouble.BufferData(buffer, DoubleBufferFormat.Mono, saw, 44100);

                AL.Listener(ALListenerf.Gain, 0.1f);

                AL.Source(alSource, ALSourcef.Gain, 1f);
                AL.Source(alSource, ALSourcei.Buffer, buffer);

                AL.SourcePlay(alSource);

                while (AL.GetSourceState(alSource) == ALSourceState.Playing)
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

        public static void CheckALCError(ALDevice device, string str)
        {
            ALCError error = ALC.GetError(device);
            if (error != ALCError.NoError)
            {
                Console.WriteLine($"ALError at '{str}': {ALC.GetErrorString(device, error)}");
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
