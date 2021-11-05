using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;
using System.Text;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class ProgramAPITest
    {
        CLDevice device;
        CLContext context;
        CLPlatform platform;
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
            CL.GetDeviceIDs(platform, DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            var properties = new CLContextProperties(platform, false);
            context = CL.CreateContext(properties, new[] { device }, null, IntPtr.Zero, out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            CL.ReleaseContext(context);
        }

        [TestMethod]
        public void CreateProgramWithSource()
        {
            // Create program
            var program = CL.CreateProgramWithSource(context, code, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseProgram(program);
        }

        [TestMethod]
        public void CreateProgramWithBinary()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateProgramWithBuiltInKernels()
        {
            CL.GetDeviceInfo(device, DeviceInfo.BuiltInKernels, out byte[] bytes);
            var kernelName = Encoding.ASCII.GetString(bytes).Split(";")[0];
            var program = CL.CreateProgramWithBuiltInKernels(context, new[] { device }, kernelName, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseProgram(program);
        }

        [TestMethod]
        public void CreateProgramWithIL()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void RetainProgram()
        {
            // Create program
            var program = CL.CreateProgramWithSource(context, code, out _);

            // Increment memobj reference count
            CLResultCode resultCode = CL.RetainProgram(program);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can be decremented twice
            CL.ReleaseProgram(program);
            resultCode = CL.ReleaseProgram(program);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can't be decremented a third time
            resultCode = CL.ReleaseProgram(program);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseProgram()
        {
            // Create program
            var program = CL.CreateProgramWithSource(context, code, out _);

            // Decrement memobj ref count 
            CLResultCode resultCode = CL.ReleaseProgram(program);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify memobj ref count can't be decremented a second time
            resultCode = CL.ReleaseProgram(program);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void BuildProgram()
        {
            var program = CL.CreateProgramWithSource(context, code, out _);
            var resultCode = CL.BuildProgram(program, null, null, null, IntPtr.Zero);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseProgram(program);
        }

        [TestMethod]
        public void CompileProgram()
        {
            var program = CL.CreateProgramWithSource(context, code, out _);
            var resultCode = CL.CompileProgram(program, null, null, null, null, null, IntPtr.Zero);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseProgram(program);
        }

        [TestMethod]
        public void LinkProgram()
        {
            var program = CL.CreateProgramWithSource(context, code, out _);
            CL.CompileProgram(program, null, null, null, null, null, IntPtr.Zero);
            var linkedProgram = CL.LinkProgram(context, null, null, new[] { program }, null, IntPtr.Zero, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseProgram(program);
            CL.ReleaseProgram(linkedProgram);
        }

        [TestMethod]
        public void SetProgramSpecializationConstant()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UnloadPlatformCompiler()
        {
            // Compile and build a program on platform
            var program = CL.CreateProgramWithSource(context, code, out _);
            CL.CompileProgram(program, null, null, null, null, null, IntPtr.Zero);
            var linkedProgram = CL.LinkProgram(context, null, null, new[] { program }, null, IntPtr.Zero, out _);

            // Unload platform
            var resultCode = CL.UnloadPlatformCompiler(platform);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseProgram(program);
            CL.ReleaseProgram(linkedProgram);
        }

        [TestMethod]
        [DataRow(ProgramInfo.ReferenceCount)]
        [DataRow(ProgramInfo.Context)]
        [DataRow(ProgramInfo.NumberOfDevices)]
        [DataRow(ProgramInfo.Devices)]
        [DataRow(ProgramInfo.Source)]
        [DataRow(ProgramInfo.BinarySizes)]
        [DataRow(ProgramInfo.Binaries)]
        [DataRow(ProgramInfo.NumberOfKernels)]
        [DataRow(ProgramInfo.KernelNames)]
        [DataRow(ProgramInfo.Il)]
        public void GetProgramInfo(ProgramInfo paramName)
        {
            // Create program
            var program = CL.CreateProgramWithSource(context, code, out _);
            CL.BuildProgram(program, null, null, null, IntPtr.Zero);

            // Check that paramName is valid
            var resultCode = CL.GetProgramInfo(program, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != ProgramInfo.Il)
                Assert.IsTrue(bytes.Length > 0);

            CL.ReleaseProgram(program);
        }

        [TestMethod]
        [DataRow(ProgramBuildInfo.Status)]
        [DataRow(ProgramBuildInfo.Options)]
        [DataRow(ProgramBuildInfo.Log)]
        [DataRow(ProgramBuildInfo.BinaryType)]
        [DataRow(ProgramBuildInfo.GlobalVariableTotalSize)]
        public void GetProgramBuildInfo(ProgramBuildInfo paramName)
        {
            // Create program
            var program = CL.CreateProgramWithSource(context, code, out _);

            var resultCode = CL.GetProgramBuildInfo(program, device, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);

            CL.ReleaseProgram(program);
        }
    }
}
