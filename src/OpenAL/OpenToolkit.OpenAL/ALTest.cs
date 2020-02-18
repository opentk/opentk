using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OpenToolkit.Audio.OpenAL
{
    internal class ALTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            var device = ALC.OpenDevice(string.Empty);
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
            var list = Extensions.Creative.EnumerateAll.EnumerateAll.GetStringList(Extensions.Creative.EnumerateAll.GetEnumerateAllContextStringList.AllDevicesSpecifier);
            foreach (var item in list)
            {
                Console.WriteLine("  " + item);
            }

            CheckALError("Before data");
            AL.GenBuffer(out int alBuffer);
            short[] sine = new short[44100 * 1];
            FillSine(sine, 4400, 44100);
            AL.BufferData(alBuffer, ALFormat.Mono16, sine.AsSpan(), 14400);
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
