using System;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Compute.OpenCL;

namespace OpenToolkit.OpenCL.Tests
{
	class Program
	{
		static void Main(string[] args)
		{
			//Get the ids of available opencl platforms

			var resultCode = CL.GetPlatformIds(out CLPlatform[] platformIds);

			Console.WriteLine(platformIds.Length);
			foreach (CLPlatform platform in platformIds)
			{
				CL.GetPlatformInfo(platform, PlatformInfo.Name, out byte[] val);
                Console.WriteLine(Encoding.ASCII.GetString(val));
            }

			//Get the device ids for each platform
			foreach (IntPtr platformId in platformIds)
			{
				CL.GetDeviceIds(new CLPlatform(platformId), DeviceType.All, out CLDevice[] deviceIds);

				CLContext context = CL.CreateContext(IntPtr.Zero, (uint)deviceIds.Length, deviceIds, IntPtr.Zero,
					IntPtr.Zero, out CLResultCode result);
				if (result != CLResultCode.Success)
				{
					throw new Exception("The context couldn't be created.");
				}

				string code = @"
                __kernel void add(__global float* A, __global float* B,__global float* result, const float mul)
                {
                    int i = get_global_id(0);
                    result[i] = (A[i] + B[i])*mul;
                }";

				CLProgram program = CL.CreateProgramWithSource(context, code, out result);

				CL.BuildProgram(program, (uint)deviceIds.Length, deviceIds, null, IntPtr.Zero, IntPtr.Zero);

				CLKernel kernel = CL.CreateKernel(program, "add", out result);

				int arraySize = 20;
				float[] A = new float[arraySize];
				float[] B = new float[arraySize];

				for (int i = 0; i < arraySize; i++)
				{
					A[i] = 1;
					B[i] = i;
				}

				CLBuffer bufferA = CL.CreateBuffer(context, MemoryFlags.ReadOnly | MemoryFlags.CopyHostPtr, A,
					out result);
				CLBuffer bufferB = CL.CreateBuffer(context, MemoryFlags.ReadOnly | MemoryFlags.CopyHostPtr, B,
					out result);

				float[] pattern = new float[]{1,3,5,7};

				CLBuffer resultBuffer =  new CLBuffer(CL.CreateBuffer(context, MemoryFlags.WriteOnly,
					new UIntPtr((uint)(arraySize * sizeof(float))), IntPtr.Zero, out result));

				try
				{
					CL.SetKernelArg(kernel, 0, bufferA);
					CL.SetKernelArg(kernel, 1, bufferB);
					CL.SetKernelArg(kernel, 2, resultBuffer);
					CL.SetKernelArg(kernel, 3, -1f);

					CLCommandQueue commandQueue = new CLCommandQueue(
						CL.CreateCommandQueueWithProperties(context, deviceIds[0], CommandQueueProperty.None, out result));

					CL.EnqueueFillBuffer(commandQueue, bufferB, pattern, UIntPtr.Zero, (UIntPtr)(arraySize * sizeof(float)), null,
						out _);

					//CL.EnqueueNDRangeKernel(commandQueue, kernel, 1, null, new UIntPtr[] {new UIntPtr((uint)A.Length)},
					//	null, 0, null,  out CLEvent eventHandle);

					CL.EnqueueNDRangeKernel(commandQueue, kernel, 1, null, new UIntPtr[] {new UIntPtr((uint)A.Length)},
						null, 0, null,  out CLEvent eventHandle);


					CL.Finish(commandQueue);

					CL.SetEventCallback(eventHandle, (int)CommandExecutionStatus.Complete, (waitEvent, data) =>
					{
						float[] resultValues = new float[arraySize];
						CL.EnqueueReadBuffer(commandQueue, resultBuffer, true, UIntPtr.Zero, resultValues, null, out _);

						StringBuilder line = new StringBuilder();
						foreach (float res in resultValues)
						{
							line.Append(res);
							line.Append(", ");
						}

						Console.WriteLine(line.ToString());
					}, IntPtr.Zero);

					//get rid of the buffers because we no longer need them
					CL.ReleaseMemoryObject(bufferA);
					CL.ReleaseMemoryObject(bufferB);
					CL.ReleaseMemoryObject(resultBuffer);

					//Release the program kernels and queues
					CL.ReleaseProgram(program);
					CL.ReleaseKernel(kernel);
					CL.ReleaseCommandQueue(commandQueue);
					CL.ReleaseContext(context);
					CL.ReleaseEvent(eventHandle);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
					throw;
				}

			}
		}
	}
}
