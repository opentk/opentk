using System;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Compute.OpenCL;

namespace OpenToolkit.OpenCL.Tests
{
	class Program
	{
		void Main(string[] args)
		{
            //Get the ids of available opencl platforms
            var resultCode = CL.GetPlatformIds(out CLPlatform[] platformIds);
            CLPlatform interopPlatform;
            try
            {
                HandleResultCode(resultCode, "CL.GetPlatformIds");

                if (platformIds.Length == 0)
                {
                    throw new Exception("No CLPlatforms found");
                }

                foreach (CLPlatform platform in platformIds)
                {
                    // Get platform info for all found platforms
                    resultCode = CL.GetPlatformInfo(platform, PlatformInfo.Name, out byte[] val);
                    HandleResultCode(resultCode, "CL.GetPlatformInfo");
                    Console.WriteLine(Encoding.ASCII.GetString(val));

                    resultCode = CL.SupportsPlatformExtension(platform, "cl_khr_gl_sharing", out bool supported);
                    HandleResultCode(resultCode, "CL.SupportsPlatformExtension");

                    if (supported)
                    {
                        interopPlatform = platform;
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("Unable to run OpenCL tests:");
                Console.WriteLine(e.ToString());
                return;
            }

			//Get the device ids for each platform
			foreach (CLPlatform platform in platformIds)
			{
                resultCode = CL.GetDeviceIds(platform, DeviceType.All, out CLDevice[] deviceIds);
                HandleResultCode(resultCode, "CL.GetDeviceIds");

                foreach (var device in deviceIds){
                    resultCode = CL.GetDeviceInfo(device, DeviceInfo.Type, out byte[] val);
                    HandleResultCode(resultCode, "CL.GetDeviceIds");
                    Console.WriteLine(Encoding.ASCII.GetString(val));
                }

                CLContext context = CL.CreateContext(IntPtr.Zero, (uint)deviceIds.Length, deviceIds, IntPtr.Zero,
					IntPtr.Zero, out resultCode);
                HandleResultCode(resultCode, "CL.CreateContext");

				string code = @"
                __kernel void add(__global float* A, __global float* B,__global float* result, const float mul)
                {
                    int i = get_global_id(0);
                    result[i] = (A[i] + B[i])*mul;
                }";

				CLProgram program = CL.CreateProgramWithSource(context, code, out resultCode);
                HandleResultCode(resultCode, "CL.CreateProgramWithSource");

                resultCode = CL.BuildProgram(program, (uint)deviceIds.Length, deviceIds, null, IntPtr.Zero, IntPtr.Zero);
                HandleResultCode(resultCode, "CL.BuildProgram");

                CLKernel kernel = CL.CreateKernel(program, "add", out resultCode);
                HandleResultCode(resultCode, "CL.CreateKernel");

                int arraySize = 20;
				float[] A = new float[arraySize];
				float[] B = new float[arraySize];

				for (int i = 0; i < arraySize; i++)
				{
					A[i] = 1;
					B[i] = i;
				}

				CLBuffer bufferA = CL.CreateBuffer(context, MemoryFlags.ReadOnly | MemoryFlags.CopyHostPtr, A, out resultCode);
                HandleResultCode(resultCode, "CL.CreateBuffer");
                CLBuffer bufferB = CL.CreateBuffer(context, MemoryFlags.ReadOnly | MemoryFlags.CopyHostPtr, B, out resultCode);
                HandleResultCode(resultCode, "CL.CreateBuffer");

                float[] pattern = new float[]{1,3,5,7};

				CLBuffer resultBuffer =  CL.CreateBuffer(context, MemoryFlags.WriteOnly, new UIntPtr((uint)(arraySize * sizeof(float))), IntPtr.Zero, out resultCode);
                HandleResultCode(resultCode, "CL.CreateBuffer");

                try
				{
					CL.SetKernelArg(kernel, 0, bufferA);
                    HandleResultCode(resultCode, "CL.SetKernelArg");
                    CL.SetKernelArg(kernel, 1, bufferB);
                    HandleResultCode(resultCode, "CL.SetKernelArg");
                    CL.SetKernelArg(kernel, 2, resultBuffer);
                    HandleResultCode(resultCode, "CL.SetKernelArg");
                    CL.SetKernelArg(kernel, 3, -1f);
                    HandleResultCode(resultCode, "CL.SetKernelArg");

                    CLCommandQueue commandQueue = CL.CreateCommandQueueWithProperties(context, deviceIds[0], CommandQueueProperty.None, out resultCode);
                    HandleResultCode(resultCode, "CL.CreateCommandQueueWithProperties");

                    resultCode = CL.EnqueueFillBuffer(commandQueue, bufferB, pattern, UIntPtr.Zero, (UIntPtr)(arraySize * sizeof(float)), null,
						out _);
                    HandleResultCode(resultCode, "CL.EnqueueFillBuffer");

                    //CL.EnqueueNDRangeKernel(commandQueue, kernel, 1, null, new UIntPtr[] {new UIntPtr((uint)A.Length)},
                    //	null, 0, null,  out CLEvent eventHandle);

                    resultCode = CL.EnqueueNDRangeKernel(commandQueue, kernel, 1, null, new UIntPtr[] {new UIntPtr((uint)A.Length)},
						null, 0, null,  out CLEvent eventHandle);
                    HandleResultCode(resultCode, "CL.EnqueueNDRangeKernel");


                    resultCode = CL.Finish(commandQueue);
                    HandleResultCode(resultCode, "CL.Finish");

                    resultCode = CL.SetEventCallback(eventHandle, (int)CommandExecutionStatus.Complete, (waitEvent, data) =>
					{
						float[] resultValues = new float[arraySize];
                        resultCode = CL.EnqueueReadBuffer(commandQueue, resultBuffer, true, UIntPtr.Zero, resultValues, null, out _);
                        HandleResultCode(resultCode, "CL.EnqueueReadBuffer");

                        StringBuilder line = new StringBuilder();
						foreach (float res in resultValues)
						{
							line.Append(res);
							line.Append(", ");
						}

						Console.WriteLine(line.ToString());
					}, IntPtr.Zero);
                    HandleResultCode(resultCode, "CL.SetEventCallback");

                    //get rid of the buffers because we no longer need them
                    resultCode = CL.ReleaseMemoryObject(bufferA);
                    HandleResultCode(resultCode, "CL.ReleaseMemoryObject");
                    resultCode = CL.ReleaseMemoryObject(bufferB);
                    HandleResultCode(resultCode, "CL.ReleaseMemoryObject");
                    resultCode = CL.ReleaseMemoryObject(resultBuffer);
                    HandleResultCode(resultCode, "CL.ReleaseMemoryObject");

                    //Release the program kernels and queues
                    resultCode = CL.ReleaseProgram(program);
                    HandleResultCode(resultCode, "CL.ReleaseProgram");
                    resultCode = CL.ReleaseKernel(kernel);
                    HandleResultCode(resultCode, "CL.ReleaseKernel");
                    resultCode = CL.ReleaseCommandQueue(commandQueue);
                    HandleResultCode(resultCode, "CL.ReleaseCommandQueue");
                    resultCode = CL.ReleaseContext(context);
                    HandleResultCode(resultCode, "CL.ReleaseContext");
                    resultCode = CL.ReleaseEvent(eventHandle);
                    HandleResultCode(resultCode, "CL.ReleaseEvent");
                }
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
					throw;
				}

			}
        }
        // what level of OpenCL is available
        // this is per device


        protected static void HandleResultCode(CLResultCode resultCode, string method)
        {
            if (resultCode == CLResultCode.Success) return;
            throw new Exception($"{method}: {Enum.GetName(typeof(CLResultCode), resultCode)}");
        }
    }
}
