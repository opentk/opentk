using System;
using System.Runtime.CompilerServices;
using System.Text;
//using OpenTK.Compute2;
using OpenTK.Compute2.OpenCL;
//using OpenTK.Compute.OpenCL;

namespace OpenCLTest
{
    internal class Program
    {
        /*static string GetPlatformInfoString(CLPlatform platform, PlatformInfo param)
        {
            CL.GetPlatformInfo(platform, param, 0, null, out nuint size);
            byte[] bytes = new byte[size];
            CL.GetPlatformInfo(platform, param, size, bytes, out _);
            return Encoding.UTF8.GetString(bytes);
        }

        static void Main(string[] args)
        {
            CL.GetPlatformIds(out CLPlatform[] platforms);
            Console.WriteLine($"n platforms: {platforms.Length}");
            for (int i = 0; i < platforms.Length; i++)
            {
                string name = GetPlatformInfoString(platforms[i], PlatformInfo.Name);
                string extensions = GetPlatformInfoString(platforms[i], PlatformInfo.Extensions);
                Console.WriteLine($"platform id: {platforms[i]} name: {name}, extensions: {extensions}");
            }
        }*/

        
        static string GetPlatformInfoString(nint platformId, PlatformInfo param)
        {
            nuint size = 0;
            CL.GetPlatformInfo(platformId, param, 0, 0, ref size);
            byte[] nameBytes = new byte[size];
            CL.GetPlatformInfo(platformId, param, (uint)nameBytes.Length, nameBytes, null);
            return Encoding.UTF8.GetString(nameBytes);
        }

        static void Main(string[] args)
        {
            uint num_platforms = 0;
            CL.GetPlatformIDs(0, ref Unsafe.NullRef<nint>(), ref num_platforms);
            nint[] platform_ids = new nint[num_platforms];
            CL.GetPlatformIDs(num_platforms, platform_ids, null);

            Console.WriteLine($"n platforms: {num_platforms}");
            for (int i = 0; i < platform_ids.Length; i++)
            {
                string name = GetPlatformInfoString(platform_ids[i], PlatformInfo.PlatformName);
                string extensions = GetPlatformInfoString(platform_ids[i], PlatformInfo.PlatformExtensions);

                Console.WriteLine($"platform id: {platform_ids[i]} name: {name}, extensions: {extensions}");
            }
        }
    }
}
