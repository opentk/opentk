using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Compute.CL10;

namespace Examples
{
    using cl_context = IntPtr;
    using cl_device_id = IntPtr;
    using cl_command_queue = IntPtr;
    using cl_program = IntPtr;
    using cl_kernel = IntPtr;
    using cl_mem = IntPtr;

    [Example("Vector Addition", ExampleCategory.OpenCL, "1.0")]
    class FFT
    {
        public static void Main()
        {
            const int cnBlockSize = 512;
            const int cnBlocks    = 3;
            IntPtr cnDimension = new IntPtr(cnBlocks * cnBlockSize);
            string sProgramSource = @"
__kernel void
vectorAdd(__global const float * a,
          __global const float * b,
          __global       float * c)
{
    // Vector element index
    int nIndex = get_global_id(0);
    c[nIndex] = a[nIndex] + b[nIndex];
}
";

            ErrorCode error;

            // create OpenCL device & context
            cl_context hContext;
            unsafe { hContext = CL.CreateContextFromType((ContextProperties*)null, DeviceTypeFlags.DeviceTypeDefault, IntPtr.Zero, IntPtr.Zero, &error); }

            // query all devices available to the context
            IntPtr nContextDescriptorSize;
            CL.GetContextInfo(hContext, ContextInfo.ContextDevices, IntPtr.Zero, IntPtr.Zero, out nContextDescriptorSize);
            cl_device_id[] aDevices = new cl_device_id[nContextDescriptorSize.ToInt32()];
            unsafe
            {
                fixed (cl_device_id* ptr = aDevices)
                {
                    IntPtr ret;
                    CL.GetContextInfo(hContext, ContextInfo.ContextDevices, nContextDescriptorSize, new IntPtr(ptr), out ret);
                }
            }
            
            
            // create a command queue for first device the context reported
            cl_command_queue hCmdQueue = CL.CreateCommandQueue(hContext, aDevices[0], (CommandQueueFlags)0, out error);
            // create & compile program
            cl_program hProgram;
            unsafe {  hProgram = CL.CreateProgramWithSource(hContext, 1, new string[] { sProgramSource }, null, &error); }
            CL.BuildProgram(hProgram, 0, (IntPtr[])null, null, IntPtr.Zero, IntPtr.Zero);

            // create kernel
            cl_kernel hKernel = CL.CreateKernel(hProgram, "vectorAdd", out error);
            // allocate host  vectors
            float[] A = new  float[cnDimension.ToInt32()];
            float[] B = new float[cnDimension.ToInt32()];
            float[] C = new float[cnDimension.ToInt32()];
            // initialize host memory
           // randomInit(pA, cnDimension);
            //randomInit(pB, cnDimension);
            
            // allocate device memory
            unsafe
            {
                fixed (float* pA = A)
                fixed (float* pB = B)
                fixed (float* pC = C)
                {
                    cl_mem hDeviceMemA, hDeviceMemB, hDeviceMemC;
                    hDeviceMemA = CL.CreateBuffer(hContext,
                        MemFlags.MemReadOnly | MemFlags.MemCopyHostPtr,
                        new IntPtr(cnDimension.ToInt32() * sizeof(float)),
                        new IntPtr(pA),
                        out error);
                    hDeviceMemB = CL.CreateBuffer(hContext,
                       MemFlags.MemReadOnly | MemFlags.MemCopyHostPtr,
                       new IntPtr(cnDimension.ToInt32() * sizeof(float)),
                       new IntPtr(pA),
                       out error);
                    hDeviceMemC = CL.CreateBuffer(hContext,
                        MemFlags.MemWriteOnly,
                        new IntPtr(cnDimension.ToInt32() * sizeof(float)),
                        IntPtr.Zero,
                        out error);

                    // setup parameter values
                    CL.SetKernelArg(hKernel, 0, new IntPtr(sizeof(cl_mem)), new IntPtr(&hDeviceMemA));
                    CL.SetKernelArg(hKernel, 1, new IntPtr(sizeof(cl_mem)), new IntPtr(&hDeviceMemB));
                    CL.SetKernelArg(hKernel, 2, new IntPtr(sizeof(cl_mem)), new IntPtr(&hDeviceMemC));

                    // execute kernel
                    CL.EnqueueNDRangeKernel(hCmdQueue, hKernel, 1, null, &cnDimension, null, 0, null, null);
                    // copy results from device back to host
                    CL.EnqueueReadBuffer(hContext, hDeviceMemC, true, IntPtr.Zero,
                                         new IntPtr(cnDimension.ToInt32() * sizeof(float)),
                                         new IntPtr(pC), 0, null, (IntPtr[])null);

                    CL.ReleaseMemObject(hDeviceMemA);
                    CL.ReleaseMemObject(hDeviceMemB);
                    CL.ReleaseMemObject(hDeviceMemC);
                }
            }
        }
    }
}
