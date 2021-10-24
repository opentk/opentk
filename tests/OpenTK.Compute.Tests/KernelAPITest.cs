using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class KernelAPITest
    {
        CLDevice device;
        CLContext context;
        CLPlatform platform;
        CLProgram program;
        string code = @"
                __kernel void add(__global float* A, __global float* B,__global float* result, const float mul)
                {
                    int i = get_global_id(0);
                    result[i] = (A[i] + B[i])*mul;
                }";

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            platform = platformIds[0];
            platform.GetDeviceIDs(DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            var properties = new CLContextProperties(platform, false);
            context = properties.CreateContext(new[] { device }, null, IntPtr.Zero, out _);
            program = context.CreateProgramWithSource(code, out _);
            program.BuildProgram();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            program.ReleaseProgram();
            context.ReleaseContext();
        }

        [TestMethod]
        public void CreateKernel()
        {
            var kernel = program.CreateKernel("add", out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            kernel.ReleaseKernel();
        }

        [TestMethod]
        public void CreateKernelsInProgram()
        {
            // Create all kernels for program
            var resultCode = program.CreateKernelsInProgram(out CLKernel[] kernels);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Ensure number of kernels matches source
            Assert.AreEqual(1, kernels.Length);

            foreach (var kernel in kernels)
                kernel.ReleaseKernel();
        }

        [TestMethod]
        public void CloneKernel()
        {
            // Create kernel
            var kernel = program.CreateKernel("add", out _);
            var clone = kernel.CloneKernel(out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            clone.ReleaseKernel();
            kernel.ReleaseKernel();
        }

        [TestMethod]
        public void RetainKernel()
        {
            // Create kernel
            var kernel = program.CreateKernel("add", out _);

            // Increment memobj reference count
            CLResultCode resultCode = kernel.RetainKernel();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can be decremented twice
            kernel.ReleaseKernel();
            resultCode = kernel.ReleaseKernel();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can't be decremented a third time
            resultCode = kernel.ReleaseKernel();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseKernel()
        {
            // Create kernel
            var kernel = program.CreateKernel("add", out _);

            // Decrement memobj ref count 
            CLResultCode resultCode = kernel.ReleaseKernel();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify memobj ref count can't be decremented a second time
            resultCode = kernel.ReleaseKernel();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void SetKernelArg()
        {
            var kernel = program.CreateKernel("add", out _);
            kernel.SetKernelArg((uint)3, 1.0f);
        }

        [TestMethod]
        public void SetKernelArgSVMPointer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetKernelExecInfo()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        [DataRow(KernelInfo.FunctionName)]
        [DataRow(KernelInfo.NumberOfArguments)]
        [DataRow(KernelInfo.ReferenceCount)]
        [DataRow(KernelInfo.Context)]
        [DataRow(KernelInfo.Program)]
        [DataRow(KernelInfo.Attributes)]
        public void GetKernelInfo(KernelInfo paramName)
        {
            // Create kernel
            var kernel = program.CreateKernel("add", out _);

            // Check that paramName is valid
            CLResultCode resultCode = kernel.GetKernelInfo(paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);

            kernel.ReleaseKernel();
        }

        [TestMethod]
        [DataRow(KernelArgInfo.AddressQualifier)]
        [DataRow(KernelArgInfo.AccessQualifier)]
        [DataRow(KernelArgInfo.TypeName)]
        [DataRow(KernelArgInfo.TypeQualifier)]
        [DataRow(KernelArgInfo.Name)]
        public void GetKernelArgInfo(KernelArgInfo paramName)
        {
            // Create kernel
            var kernel = program.CreateKernel("add", out _);

            // Check that paramName is valid
            CLResultCode resultCode = kernel.GetKernelArgInfo(0, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);

            kernel.ReleaseKernel();
        }

        [TestMethod]

        [DataRow(KernelWorkGroupInfo.WorkGroupSize)]
        [DataRow(KernelWorkGroupInfo.CompileWorkGroupSize)]
        [DataRow(KernelWorkGroupInfo.LocalMemorySize)]
        [DataRow(KernelWorkGroupInfo.PreferredWorkGroupSizeMultiple)]
        [DataRow(KernelWorkGroupInfo.PrivateMemorySize)]
        //[DataRow(KernelWorkGroupInfo.GlobalWorkSize)] // Only applicable to built in kernels on custom devices 
        public void GetKernelWorkGroupInfo(KernelWorkGroupInfo paramName)
        {
            var kernel = program.CreateKernel("add", out _);
            var resultCode = kernel.GetKernelWorkGroupInfo(device, paramName, out byte[] data);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(data.Length > 0);
            kernel.ReleaseKernel();
        }

        [TestMethod]
        [DataRow(KernelSubGroupInfo.MaximumSubGroupSizeForNdRange)]
        [DataRow(KernelSubGroupInfo.SubGroupCountForNdRange)]
        //[DataRow(KernelSubGroupInfo.LocalSizeForSubGroupCount)] // This always returns an Invalid_Value error when tested
        [DataRow(KernelSubGroupInfo.MaxNumberOfSubGroups)]
        [DataRow(KernelSubGroupInfo.CompileNumberOfSubGroups)]
        public void GetKernelSubGroupInfo(KernelSubGroupInfo paramName)
        {
            // Create kernel
            var kernel = program.CreateKernel("add", out _);

            // Check that paramName is valid
            var resultCode = paramName == KernelSubGroupInfo.LocalSizeForSubGroupCount ?
                kernel.GetKernelSubGroupInfo(device, paramName, 4, out nuint[] data) :
                kernel.GetKernelSubGroupInfo(device, paramName, new nuint[] { 0 }, out data);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(data.Length > 0);
            kernel.ReleaseKernel();
        }
    }
}
