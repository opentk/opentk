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

            ALC.GetInteger(device, AlcGetInteger.MajorVersion, 1, out int alcMajorVersion);
            ALC.GetInteger(device, AlcGetInteger.MinorVersion, 1, out int alcMinorVersion);
            string alcExts = ALC.GetString(device, AlcGetString.Extensions);

            int[] attrs = ALC.GetAttributes(device);
            Console.WriteLine("Attributes:");
            foreach (var attr in attrs)
            {
                Console.WriteLine("  " + (AlcContextAttributes)attr);
            }

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

            Console.WriteLine("Goodbye!");

            ALC.MakeContextCurrent(ALContextHandle.Zero);
            ALC.DestroyContext(context);
            ALC.CloseDevice(device);
        }
    }
}
