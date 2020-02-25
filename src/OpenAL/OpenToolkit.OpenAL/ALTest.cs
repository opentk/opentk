using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OpenToolkit.Audio.OpenAL
{
    internal class ALTest
    {
        public static void Main()
        {
            Console.WriteLine("Hello!");
            var device = ALC.OpenDevice(string.Empty);
            var context = ALC.CreateContext(device, (int[])null);
            ALC.MakeContextCurrent(context);

            CheckALError("Start");

            var devices = ALC.GetStringList(GetEnumerationStringList.DeviceSpecifier);
            Console.WriteLine($"Devices: {string.Join(", ", devices)}");

            var allDevices = Extensions.Creative.EnumerateAll.EnumerateAll.GetStringList(Extensions.Creative.EnumerateAll.GetEnumerateAllContextStringList.AllDevicesSpecifier);
            Console.WriteLine($"All Devices: {string.Join(", ", allDevices)}");

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

            // Record a second of data
            CheckALError("Before record");
            short[] recording = new short[44100 * 4];
            ALCaptureDevice captureDevice = Extensions.EXT.Capture.Capture.CaptureOpenDevice(null, 44100, ALFormat.Mono16, 1024);
            {
                Extensions.EXT.Capture.Capture.CaptureStart(captureDevice);

                int current = 0;
                while (current < recording.Length)
                {
                    int samplesAvailable = Extensions.EXT.Capture.Capture.GetAvailableSamples(captureDevice);
                    int samplesToRead = Math.Min(samplesAvailable, recording.Length - current);
                    Extensions.EXT.Capture.Capture.CaptureSamples(captureDevice, ref recording[current], samplesToRead);
                    current += samplesToRead;
                }

                Extensions.EXT.Capture.Capture.CaptureStop(captureDevice);
            }
            CheckALError("After record");

            // Playback the recorded data
            CheckALError("Before data");
            AL.GenBuffer(out int alBuffer);
            // short[] sine = new short[44100 * 1];
            // FillSine(sine, 4400, 44100);
            // FillSine(recording, 440, 44100);
            AL.BufferData(alBuffer, ALFormat.Mono16, ref recording[0], recording.Length * 2, 14400);
            CheckALError("After data");

            AL.Listener(ALListenerf.Gain, 0.1f);

            AL.GenSource(out int alSource);
            AL.Source(alSource, ALSourcef.Gain, 1f);
            AL.Source(alSource, ALSourcei.Buffer, alBuffer);
            AL.SourcePlay(alSource);

            Thread.Sleep(1000);

            AL.SourceStop(alSource);

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
