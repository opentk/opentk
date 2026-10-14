using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Compute2.OpenCL;

namespace OpenCLTest
{
    internal class Program
    {
        static string GetPlatformInfoString(nint platformId, PlatformInfo param)
        {
            nuint size = 0;
            CL.GetPlatformInfo(platformId, param, 0, 0, ref size);
            byte[] nameBytes = new byte[size];
            CL.GetPlatformInfo(platformId, param, (uint)nameBytes.Length, nameBytes, null);
            return Encoding.UTF8.GetString(nameBytes);
        }

        static string GetDeviceInfoString(nint deviceId, DeviceInfo param)
        {
            nuint size = 0;
            CL.GetDeviceInfo(deviceId, param, 0, 0, ref size);
            byte[] nameBytes = new byte[size];
            CL.GetDeviceInfo(deviceId, param, (uint)nameBytes.Length, nameBytes, null);
            return Encoding.UTF8.GetString(nameBytes);
        }

        static nint FindOpenCLDevice()
        {
            uint num_platforms = 0;
            CL.GetPlatformIDs(0, ref Unsafe.NullRef<nint>(), ref num_platforms);
            nint[] platform_ids = new nint[num_platforms];
            CL.GetPlatformIDs(num_platforms, platform_ids, null);

            for (int i = 0; i < platform_ids.Length; i++)
            {
                DeviceType AcceleratorOrGpu = DeviceType.DeviceTypeGpu | DeviceType.DeviceTypeAccelerator;

                uint count = 0;
                nint device = 0;
                CL.GetDeviceIDs(platform_ids[i], AcceleratorOrGpu, 1u, ref device, ref count);

                if (count == 0)
                    continue;

                return device;
            }

            for (int i = 0; i < platform_ids.Length; i++)
            {
                uint count = 0;
                nint device = 0;
                CL.GetDeviceIDs(platform_ids[i], DeviceType.DeviceTypeAll, 1u, ref device, ref count);

                if (count == 0)
                    continue;

                return device;
            }

            throw new Exception("Could not find OpenCL device to run on.");
        }

        static unsafe void Main(string[] args)
        {
            nint device = FindOpenCLDevice();

            // Print device info
            {
                nint platform = 0;
                CL.GetDeviceInfo(device, DeviceInfo.DevicePlatform, (uint)sizeof(nint), ref platform, ref Unsafe.NullRef<nuint>());

                string platformName = GetPlatformInfoString(platform, PlatformInfo.PlatformName);
                string[] platformExtensions = GetPlatformInfoString(platform, PlatformInfo.PlatformExtensions).Split(',');

                string deviceName = GetDeviceInfoString(device, DeviceInfo.DeviceName);
                string deviceVendor = GetDeviceInfoString(device, DeviceInfo.DeviceVendor);
                string driverVersion = GetDeviceInfoString(device, DeviceInfo.DriverVersion);
                string deviceProfile = GetDeviceInfoString(device, DeviceInfo.DeviceProfile);
                string deviceVersion = GetDeviceInfoString(device, DeviceInfo.DeviceVersion);
                string[] deviceExtensions = GetDeviceInfoString(device, DeviceInfo.DeviceExtensions).Split(',');
                DeviceType deviceType = 0;
                CL.GetDeviceInfo(device, DeviceInfo.DeviceType, sizeof(DeviceType), ref deviceType, ref Unsafe.NullRef<nuint>());
                string deviceTypeString = deviceType switch
                {
                    DeviceType.DeviceTypeCpu => "CPU",
                    DeviceType.DeviceTypeGpu => "GPU",
                    DeviceType.DeviceTypeAccelerator => "Accelerator",
                    DeviceType.DeviceTypeCustom => "Custom",
                    _ => throw new NotImplementedException(),
                };

                Console.WriteLine($"---- OpenCL Device ----");
                Console.WriteLine($"Name:     {deviceName}");
                Console.WriteLine($"Vendor:   {deviceVendor}");
                Console.WriteLine($"Type:     {deviceTypeString}");
                Console.WriteLine($"Version:  {deviceVersion}");
                Console.WriteLine($"Platform: {platformName}");
                Console.WriteLine($"Profile:  {deviceProfile}");
                Console.WriteLine($"Driver:   {driverVersion}");
                Console.WriteLine();
            }

            ErrorCodes errorCode = default;
            nint context = CL.CreateContext(ref Unsafe.NullRef<nint>(), 1, ref device, null, 0, ref Unsafe.As<ErrorCodes, int>(ref errorCode));
            nint queue = CL.CreateCommandQueueWithProperties(context, device, ref Unsafe.NullRef<QueueProperties>(), ref Unsafe.As<ErrorCodes, int>(ref errorCode));

            string[] source = [
                """
                __kernel void hello_kernel(__global char* message) {
                    int gid = get_global_id(0);

                    // Only the first work-item writes the message
                    if (gid == 0) {
                        message[0] = 'H';
                        message[1] = 'e';
                        message[2] = 'l';
                        message[3] = 'l';
                        message[4] = 'o';
                        message[5] = ' ';
                        message[6] = 'f';
                        message[7] = 'r';
                        message[8] = 'o';
                        message[9] = 'm';
                        message[10] = ' ';
                        message[11] = 'G';
                        message[12] = 'P';
                        message[13] = 'U';
                        message[14] = '!';
                        message[15] = '\0';
                    }
                }
                """
            ];
            nuint[] lengths = [(nuint)source[0].Length];
            int[] errors = new int[source.Length];
            nint program = CL.CreateProgramWithSource(context, (uint)source.Length, source, lengths, errors);

            errorCode = (ErrorCodes)CL.BuildProgram(program, 1, ref device, null, null, ref Unsafe.NullRef<uint>());
            if (errorCode != ErrorCodes.Success)
            {
                Console.WriteLine($"Failed to compile OpenCL program:");
                nuint logSize = 0;
                CL.GetProgramBuildInfo(program, device, ProgramBuildInfo.ProgramBuildLog, 0, 0, ref logSize);
                byte[] logBytes = new byte[logSize];
                CL.GetProgramBuildInfo(program, device, ProgramBuildInfo.ProgramBuildLog, logSize, logBytes, null);
                Console.WriteLine(Encoding.UTF8.GetString(logBytes));
            }

            nint kernel = CL.CreateKernel(program, "hello_kernel", ref Unsafe.As<ErrorCodes, int>(ref errorCode));

            nuint messageSize = 16;
            nint messageBuffer = CL.CreateBuffer(context, MemFlags.MemWriteOnly, messageSize, 0, ref Unsafe.As<ErrorCodes, int>(ref errorCode));

            CL.SetKernelArg(kernel, 0, (nuint)sizeof(nint), &messageBuffer);

            nuint globalWorkSize = 1;
            CL.EnqueueNDRangeKernel(queue, kernel, 1, null, &globalWorkSize, null, 0, null, null);

            byte[] message = new byte[messageSize];
            CL.EnqueueReadBuffer(queue, messageBuffer, Bool.Blocking, 0, messageSize, message, 0, null, null);

            Console.WriteLine(Encoding.UTF8.GetString(message));

            CL.ReleaseMemObject(messageBuffer);
            CL.ReleaseKernel(kernel);
            CL.ReleaseProgram(program);
            CL.ReleaseCommandQueue(queue);
            CL.ReleaseContext(context);
        }
    }
}
