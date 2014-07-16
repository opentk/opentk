// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Compute;
using OpenTK.Compute.CL12;
using OpenTK.Extensions;

namespace Examples.OpenCL.CL12
{
    class Simple
    {
        static string SourceCode = @"
__kernel void
VectorAdd(__global const float * a,
          __global const float * b,
          __global       float * c)
{
    // Vector element index
    int nIndex = get_global_id(0);
    c[nIndex] = a[nIndex] + b[nIndex];
}
";

        static void CheckErrors(ErrorCode error)
        {
            if (error != ErrorCode.Success)
                throw new InvalidOperationException(error.ToString());
        }

        static void ContextNotify(string errinfo, IntPtr private_info, IntPtr cb, IntPtr user_data)
        {
            Console.Error.WriteLine(errinfo);
        }

        public static void Main()
        {
            ErrorCode error;
            IntPtr length_ret;
            var length = new IntPtr(1024);
            var data = new byte[length.ToInt32()];

            // Query available platforms
            int platform_count;
            var platforms = new ComputePlatform[4];
            error = ComputePlatform.GetPlatformIDs(platforms.Length, platforms, out platform_count);
            CheckErrors(error);

            for (int j = 0; j < platform_count; j++)
            {
                var platform = platforms[j];
                Console.WriteLine("Platform: {0}", j + 1);

                // Create OpenCL context
                var context_notify = new ContextNotifyDelegate(ContextNotify);
                var context = ComputeContext.CreateContextFromType(
                    new ContextProperty[]
                    {
                        new ContextProperty(platform)
                    },
                    DeviceTypeFlags.DeviceTypeAll,
                    context_notify,
                    IntPtr.Zero,
                    out error);
                CheckErrors(error);

                // Query available devices
                int device_count;
                ComputeDevice[] devices = new ComputeDevice[4];
                error = platform.GetDeviceIDs(DeviceTypeFlags.DeviceTypeAll,
                    devices.Length, devices, out device_count);
                CheckErrors(error);

                for (int i = 0; i < device_count; i++)
                {
                    var device = devices[i];

                    device.GetDeviceInfo(DeviceInfo.DeviceName, length, data, out length_ret);
                    var name = Encoding.ASCII.GetString(data, 0, length_ret.ToInt32());

                    device.GetDeviceInfo(DeviceInfo.DriverVersion, length, data, out length_ret);
                    var version = Encoding.ASCII.GetString(data, 0, length_ret.ToInt32());

                    device.GetDeviceInfo(DeviceInfo.DeviceType, length, data, out length_ret);
                    var type = (DeviceTypeFlags)BitConverter.ToInt64(data, 0);

                    Console.WriteLine(" Device: {0}", i + 1);
                    Console.WriteLine("   name: {0}", name);
                    Console.WriteLine("version: {0}", version);
                    Console.WriteLine("   type: {0}", type);
                    Console.WriteLine();

                    //error = context.GetContextInfo(ContextInfo.ContextDevices,
                    //    (IntPtr)devices.Length, devices, out length_ret);
                    //CheckErrors(error);

                    // Create a command queue
                    var command = context.CreateCommandQueue(device,
                        CommandQueueFlags.Default, out error);
                    CheckErrors(error);

                    // Create a program
                    IntPtr lengths = IntPtr.Zero; // use null-terminated strings
                    var program = context.CreateProgramWithSource(1,
                        ref SourceCode, ref lengths, out error);
                    CheckErrors(error);
                    error = program.BuildProgram(0, (ComputeDevice[])null, null, null, IntPtr.Zero);
                    CheckErrors(error);

                    // Allocate host vectors
                    var A = new Vector3[] { Vector3.UnitX };
                    var B = new Vector3[] { Vector3.UnitY };
                    var C = new Vector3[] { Vector3.Zero };

                    // Allocate device memory
                    var AHandle = context.CreateBuffer(
                        MemFlags.MemReadOnly | MemFlags.MemCopyHostPtr,
                        A.Size(),
                        A,
                        out error);
                    CheckErrors(error);

                    var BHandle = context.CreateBuffer(
                        MemFlags.MemReadOnly | MemFlags.MemCopyHostPtr,
                        B.Size(),
                        B,
                        out error);
                    CheckErrors(error);

                    var CHandle = context.CreateBuffer(
                        MemFlags.MemWriteOnly,
                        C.Size(),
                        IntPtr.Zero,
                        out error);
                    CheckErrors(error);

                    // Create kernel
                    var kernel = program.CreateKernel("VectorAdd", out error);
                    CheckErrors(error);

                    // Setup kernel arguments
                    error = kernel.SetKernelArg(0,
                        AHandle.Size(),
                        ref AHandle);
                    CheckErrors(error);
                    error = kernel.SetKernelArg(1,
                        BHandle.Size(),
                        ref BHandle);
                    CheckErrors(error);
                    error = kernel.SetKernelArg(2,
                        CHandle.Size(),
                        ref CHandle);
                    CheckErrors(error);

                    // Write data from host to device
                    ComputeEvent e;
                    error = command.EnqueueWriteBuffer(AHandle, true, IntPtr.Zero,
                        A.Size(), A, 0, null, out e);
                    CheckErrors(error);
                    error = command.EnqueueWriteBuffer(BHandle, true, IntPtr.Zero,
                        B.Size(), B, 0, null, out e);
                    CheckErrors(error);

                    // Execute kernel
                    error = command.EnqueueNDRangeKernel(kernel,
                        1, null, new IntPtr[] { A.Size() }, null,
                        0, null, out e);
                    CheckErrors(error);

                    // Read results from device
                    error = command.EnqueueReadBuffer(CHandle, true, IntPtr.Zero,
                        C.Size(), C, 0, null, out e);
                    CheckErrors(error);

                    command.Finish();

                    AHandle.ReleaseMemObject();
                    BHandle.ReleaseMemObject();
                    CHandle.ReleaseMemObject();

                    bool success = true;
                    for (int test = 0; test < A.Length && success; test++)
                    {
                        Console.WriteLine("    {0} + {1} == {2}", A[test], B[test], C[test]);
                        success &= A[test] + B[test] == C[test];
                    }

                    Console.Write("    ");
                    Console.WriteLine(success ? "Test succeessful!" : "Test failed.");
                }
                Console.WriteLine();
            }
        }
    }
}
