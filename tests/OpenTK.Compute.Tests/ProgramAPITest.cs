using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;

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
            platform.GetDeviceIDs(DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            var properties = new CLContextProperties(platform, false);
            context = properties.CreateContext(new[] { device }, null, IntPtr.Zero, out _);
        }

        [TestMethod]
        public void CreateProgramWithSource()
        {
            // Create program
            var program = context.CreateProgramWithSource(code, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            program.ReleaseProgram();
        }

        [TestMethod]
        public void CreateProgramWithBinary()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateProgramWithBuiltInKernels()
        {
            var program = context.CreateProgramWithBuiltInKernels(new[] { device }, code, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            program.ReleaseProgram();
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
            var program = context.CreateProgramWithSource(code, out _);

            // Increment memobj reference count
            CLResultCode resultCode = program.RetainProgram();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can be decremented twice
            program.ReleaseProgram();
            resultCode = program.ReleaseProgram();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can't be decremented a third time
            resultCode = program.ReleaseProgram();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseProgram()
        {
            // Create program
            var program = context.CreateProgramWithSource(code, out _);

            // Decrement memobj ref count 
            CLResultCode resultCode = program.ReleaseProgram();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify memobj ref count can't be decremented a second time
            resultCode = program.ReleaseProgram();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void BuildProgram()
        {
            var program = context.CreateProgramWithSource(code, out _);
            var resultCode = program.BuildProgram(null, null, null, IntPtr.Zero);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            program.ReleaseProgram();
        }

        [TestMethod]
        public void CompileProgram()
        {
            var program = context.CreateProgramWithSource(code, out _);
            var resultCode = program.CompileProgram(null, null, null, null, null, IntPtr.Zero);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            program.ReleaseProgram();
        }

        [TestMethod]
        public void LinkProgram()
        {
            var program = context.CreateProgramWithSource(code, out _);
            program.CompileProgram(null, null, null, null, null, IntPtr.Zero);
            var linkedProgram = context.LinkProgram(null, null, new[] { program }, null, IntPtr.Zero, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            program.ReleaseProgram();
            linkedProgram.ReleaseProgram();
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
            var program = context.CreateProgramWithSource(code, out _);
            program.CompileProgram(null, null, null, null, null, IntPtr.Zero);
            var linkedProgram = context.LinkProgram(null, null, new[] { program }, null, IntPtr.Zero, out _);

            // Unload platform
            var resultCode = platform.UnloadPlatformCompiler();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            program.ReleaseProgram();
            linkedProgram.ReleaseProgram();
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
            var program = context.CreateProgramWithSource(code, out _);
            program.BuildProgram(null, null, null, IntPtr.Zero);

            // Check that paramName is valid
            var resultCode = program.GetProgramInfo(paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != ProgramInfo.Il)
                Assert.IsTrue(bytes.Length > 0);

            program.ReleaseProgram();
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
            var program = context.CreateProgramWithSource(code, out _);

            var resultCode = program.GetProgramBuildInfo(device, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);

            program.ReleaseProgram();
        }
    }
}
