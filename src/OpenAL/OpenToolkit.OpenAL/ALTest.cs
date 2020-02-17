using System;
using System.Collections.Generic;
using System.Text;

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

            string alcExts = ALC.GetString(device, AlcGetString.Extensions);

            string exts = AL.Get(ALGetString.Extensions);
            string rend = AL.Get(ALGetString.Renderer);
            string vend = AL.Get(ALGetString.Vendor);
            string vers = AL.Get(ALGetString.Version);

            Console.WriteLine($"Vendor: {vend}, Version: {vers}, Renderer: {rend}, Extensions: {exts}, ALC Extensions: {alcExts}");

            Console.WriteLine("Available devices: ");
            var list = Extensions.Creative.EnumerateAll.EnumerateAll.GetStringList(Extensions.Creative.EnumerateAll.GetEnumerateAllContextStringList.AllDevicesSpecifier);
            foreach (var item in list)
            {
                Console.WriteLine("  " + item);
            }

            Console.WriteLine("Goodbye!");

            ALC.MakeContextCurrent(ALContextHandle.Zero);
            ALC.DestroyContext(context);
            ALC.CloseDevice(device);
        }
    }
}
