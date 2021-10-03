namespace OpenTK.Compute.OpenCL
{
	public enum CLResultCode : int
	{
		Success = 0,

		#region Run-time and JIT Compiler Error

		DeviceNotFound = -1,
		DeviceNotAvailable = -2,
		CompilerNotAvailable = -3,
		MemObjectAllocationFailure = -4,
		OutOfResources = -5,
		OutOfHostMemory = -6,
		ProfilingInformationNotAvailable = -7,
		MemCopyOverlap = -8,
		ImageFormatMismatch = -9,
		ImageFormatNotSupported = -10,
		BuildProgramFailure = -11,
		MapFailure = -12,
		MisalignedSubBufferOffset = -13,
		ExecStatusErrorForEventsInWaitList = -14,
		CompileProgramFailure = -15,
		LinkerNotAvailable = -16,
		LinkProgramFailure = -17,
		DevicePartitionFailed = -18,
		KernelArgInfoNotAvailable = -19,

		#endregion

		#region Compile-time Errors

		InvalidValue = -30,
		InvalidDeviceType = -31,
		InvalidPlatform = -32,
		InvalidDevice = -33,
		InvalidContext = -34,
		InvalidQueueProperties = -35,
		InvalidCommandQueue = -36,
		InvalidHostPtr = -37,
		InvalidMemObject = -38,
		InvalidImageFormatDescriptor = -39,
		InvalidImageSize = -40,
		InvalidSampler = -41,
		InvalidBinary = -42,
		InvalidBuildOptions = -43,
		InvalidProgram = -44,
		InvalidProgramExecutable = -45,
		InvalidKernelName = -46,
		InvalidKernelDefinition = -47,
		InvalidKernel = -48,
		InvalidArgIndex = -49,
		InvalidArgValue = -50,
		InvalidArgSize = -51,
		InvalidKernelArgs = -52,
		InvalidWorkDimension = -53,
		InvalidWorkGroupSize = -54,
		InvalidWorkItemSize = -55,
		InvalidGlobalOffset = -56,
		InvalidEventWaitList = -57,
		InvalidEvent = -58,
		InvalidOperation = -59,
		InvalidGlObject = -60,
		InvalidBufferSize = -61,
		InvalidMipLevel = -62,
		InvalidGlobalWorkSize = -63,
		InvalidProperty = -64,
		InvalidImageDescriptor = -65,
		InvalidCompilerOptions = -66,
		InvalidLinkerOptions = -67,
		InvalidDevicePartitionCount = -68,
		InvalidPipeSize = -69,
        InvalidDeviceQueue = -70,
        InvalidSpecID = -71,
        MaxSizeRestrictionExceeded = -72,

        #endregion

        #region Errors thrown by extensions

        InvalidGlShaderGroupReferenceKhr = -1000,
		PlatformNotFoundKhr = -1001,
		InvalidD3D10DeviceKhr = -1002,
		InvalidD3D10ResourceKhr = -1003,
		D3D10ResourceAlreadyAcquiredKhr = -1004,
		D3D10ResourceNotAcquiredKhr = -1005,
		InvalidD3D11DeviceKhr = -1006,
		InvalidD3D11ResourceKhr = -1007,
		D3D11ResourceAlreadyAcquiredKhr = -1008,
		D3D11ResourceNotAcquiredKhr = -1009,

		InvalidD3D9DeviceNv = -1010,
		InvalidDx9DeviceIntel = -1010,

		InvalidD3D9ResourceNv = -1011,
		InvalidDx9ResourceIntel = -1011,

		D3D9ResourceAlreadyAcquiredNv = -1012,
		Dx9ResourceAlreadyAcquiredIntel = -1012,

		D3D9ResourceNotAcquiredNv = -1013,
		Dx9ResourceNotAcquiredIntel = -1013,

		EglResourceNotAcquiredKhr = -1092,
		InvalidEglObjectKhr = -1093,
		InvalidAcceleratorIntel = -1094,
		InvalidAcceleratorTypeIntel = -1095,
		InvalidAcceleratorDescriptorIntel = -1096,
		AcceleratorTypeNotSupportedIntel = -1097,
		InvalidVaApiMediaAdapterIntel = -1098,
		InvalidVaApiMediaSurfaceIntel = -1099,
		VaApiMediaSurfaceAlreadyAcquiredIntel = -1100,
		VaApiMediaSurfaceNotAcquiredIntel = -1101

		#endregion
	}
}
