//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace OpenTK.Compute.CL11
{
    /// <summary>
    /// Used in GL.CreateSampler
    /// </summary>
    public enum AddressingMode : int
    {
        /// <summary>
        /// Original was CL_ADDRESS_NONE = 0x1130
        /// </summary>
        AddressNone = ((int)0x1130),
        /// <summary>
        /// Original was CL_ADDRESS_CLAMP_TO_EDGE = 0x1131
        /// </summary>
        AddressClampToEdge = ((int)0x1131),
        /// <summary>
        /// Original was CL_ADDRESS_CLAMP = 0x1132
        /// </summary>
        AddressClamp = ((int)0x1132),
        /// <summary>
        /// Original was CL_ADDRESS_REPEAT = 0x1133
        /// </summary>
        AddressRepeat = ((int)0x1133),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum All : int
    {
        /// <summary>
        /// Original was CL_DEVICE_TYPE_DEFAULT = (1 &lt;&lt; 0)
        /// </summary>
        DeviceTypeDefault = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_EXEC_KERNEL = (1 &lt;&lt; 0)
        /// </summary>
        ExecKernel = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_FP_DENORM = (1 &lt;&lt; 0)
        /// </summary>
        FpDenorm = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_MAP_READ = (1 &lt;&lt; 0)
        /// </summary>
        MapRead = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_MEM_READ_WRITE = (1 &lt;&lt; 0)
        /// </summary>
        MemReadWrite = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE = (1 &lt;&lt; 0)
        /// </summary>
        QueueOutOfOrderExecModeEnable = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_DEVICE_TYPE_CPU = (1 &lt;&lt; 1)
        /// </summary>
        DeviceTypeCpu = ((int)(1 << 1)),
        /// <summary>
        /// Original was CL_EXEC_NATIVE_KERNEL = (1 &lt;&lt; 1)
        /// </summary>
        ExecNativeKernel = ((int)(1 << 1)),
        /// <summary>
        /// Original was CL_FP_INF_NAN = (1 &lt;&lt; 1)
        /// </summary>
        FpInfNan = ((int)(1 << 1)),
        /// <summary>
        /// Original was CL_MAP_WRITE = (1 &lt;&lt; 1)
        /// </summary>
        MapWrite = ((int)(1 << 1)),
        /// <summary>
        /// Original was CL_MEM_WRITE_ONLY = (1 &lt;&lt; 1)
        /// </summary>
        MemWriteOnly = ((int)(1 << 1)),
        /// <summary>
        /// Original was CL_QUEUE_PROFILING_ENABLE = (1 &lt;&lt; 1)
        /// </summary>
        QueueProfilingEnable = ((int)(1 << 1)),
        /// <summary>
        /// Original was CL_DEVICE_TYPE_GPU = (1 &lt;&lt; 2)
        /// </summary>
        DeviceTypeGpu = ((int)(1 << 2)),
        /// <summary>
        /// Original was CL_FP_ROUND_TO_NEAREST = (1 &lt;&lt; 2)
        /// </summary>
        FpRoundToNearest = ((int)(1 << 2)),
        /// <summary>
        /// Original was CL_MEM_READ_ONLY = (1 &lt;&lt; 2)
        /// </summary>
        MemReadOnly = ((int)(1 << 2)),
        /// <summary>
        /// Original was CL_DEVICE_TYPE_ACCELERATOR = (1 &lt;&lt; 3)
        /// </summary>
        DeviceTypeAccelerator = ((int)(1 << 3)),
        /// <summary>
        /// Original was CL_FP_ROUND_TO_ZERO = (1 &lt;&lt; 3)
        /// </summary>
        FpRoundToZero = ((int)(1 << 3)),
        /// <summary>
        /// Original was CL_MEM_USE_HOST_PTR = (1 &lt;&lt; 3)
        /// </summary>
        MemUseHostPtr = ((int)(1 << 3)),
        /// <summary>
        /// Original was CL_FP_ROUND_TO_INF = (1 &lt;&lt; 4)
        /// </summary>
        FpRoundToInf = ((int)(1 << 4)),
        /// <summary>
        /// Original was CL_MEM_ALLOC_HOST_PTR = (1 &lt;&lt; 4)
        /// </summary>
        MemAllocHostPtr = ((int)(1 << 4)),
        /// <summary>
        /// Original was CL_FP_FMA = (1 &lt;&lt; 5)
        /// </summary>
        FpFma = ((int)(1 << 5)),
        /// <summary>
        /// Original was CL_MEM_COPY_HOST_PTR = (1 &lt;&lt; 5)
        /// </summary>
        MemCopyHostPtr = ((int)(1 << 5)),
        /// <summary>
        /// Original was CL_BUILD_SUCCESS = 0
        /// </summary>
        BuildSuccess = ((int)0),
        /// <summary>
        /// Original was CL_DEFAULT = 0
        /// </summary>
        Default = ((int)0),
        /// <summary>
        /// Original was CL_FALSE = 0
        /// </summary>
        False = ((int)0),
        /// <summary>
        /// Original was CL_SUCCESS = 0
        /// </summary>
        Success = ((int)0),
        /// <summary>
        /// Original was CL_COMPLETE = 0x0
        /// </summary>
        Complete = ((int)0x0),
        /// <summary>
        /// Original was CL_NONE = 0x0
        /// </summary>
        None = ((int)0x0),
        /// <summary>
        /// Original was CL_PLATFORM_PROFILE = 0x0900
        /// </summary>
        PlatformProfile = ((int)0x0900),
        /// <summary>
        /// Original was CL_PLATFORM_VERSION = 0x0901
        /// </summary>
        PlatformVersion = ((int)0x0901),
        /// <summary>
        /// Original was CL_PLATFORM_NAME = 0x0902
        /// </summary>
        PlatformName = ((int)0x0902),
        /// <summary>
        /// Original was CL_PLATFORM_VENDOR = 0x0903
        /// </summary>
        PlatformVendor = ((int)0x0903),
        /// <summary>
        /// Original was CL_PLATFORM_EXTENSIONS = 0x0904
        /// </summary>
        PlatformExtensions = ((int)0x0904),
        /// <summary>
        /// Original was CL_LOCAL = 0x1
        /// </summary>
        Local = ((int)0x1),
        /// <summary>
        /// Original was CL_READ_ONLY_CACHE = 0x1
        /// </summary>
        ReadOnlyCache = ((int)0x1),
        /// <summary>
        /// Original was CL_RUNNING = 0x1
        /// </summary>
        Running = ((int)0x1),
        /// <summary>
        /// Original was CL_DEVICE_TYPE = 0x1000
        /// </summary>
        DeviceType = ((int)0x1000),
        /// <summary>
        /// Original was CL_DEVICE_VENDOR_ID = 0x1001
        /// </summary>
        DeviceVendorId = ((int)0x1001),
        /// <summary>
        /// Original was CL_DEVICE_MAX_COMPUTE_UNITS = 0x1002
        /// </summary>
        DeviceMaxComputeUnits = ((int)0x1002),
        /// <summary>
        /// Original was CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS = 0x1003
        /// </summary>
        DeviceMaxWorkItemDimensions = ((int)0x1003),
        /// <summary>
        /// Original was CL_DEVICE_MAX_WORK_GROUP_SIZE = 0x1004
        /// </summary>
        DeviceMaxWorkGroupSize = ((int)0x1004),
        /// <summary>
        /// Original was CL_DEVICE_MAX_WORK_ITEM_SIZES = 0x1005
        /// </summary>
        DeviceMaxWorkItemSizes = ((int)0x1005),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR = 0x1006
        /// </summary>
        DevicePreferredVectorWidthChar = ((int)0x1006),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT = 0x1007
        /// </summary>
        DevicePreferredVectorWidthShort = ((int)0x1007),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT = 0x1008
        /// </summary>
        DevicePreferredVectorWidthInt = ((int)0x1008),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG = 0x1009
        /// </summary>
        DevicePreferredVectorWidthLong = ((int)0x1009),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT = 0x100A
        /// </summary>
        DevicePreferredVectorWidthFloat = ((int)0x100A),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE = 0x100B
        /// </summary>
        DevicePreferredVectorWidthDouble = ((int)0x100B),
        /// <summary>
        /// Original was CL_DEVICE_MAX_CLOCK_FREQUENCY = 0x100C
        /// </summary>
        DeviceMaxClockFrequency = ((int)0x100C),
        /// <summary>
        /// Original was CL_DEVICE_ADDRESS_BITS = 0x100D
        /// </summary>
        DeviceAddressBits = ((int)0x100D),
        /// <summary>
        /// Original was CL_DEVICE_MAX_READ_IMAGE_ARGS = 0x100E
        /// </summary>
        DeviceMaxReadImageArgs = ((int)0x100E),
        /// <summary>
        /// Original was CL_DEVICE_MAX_WRITE_IMAGE_ARGS = 0x100F
        /// </summary>
        DeviceMaxWriteImageArgs = ((int)0x100F),
        /// <summary>
        /// Original was CL_DEVICE_MAX_MEM_ALLOC_SIZE = 0x1010
        /// </summary>
        DeviceMaxMemAllocSize = ((int)0x1010),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE2D_MAX_WIDTH = 0x1011
        /// </summary>
        DeviceImage2DMaxWidth = ((int)0x1011),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE2D_MAX_HEIGHT = 0x1012
        /// </summary>
        DeviceImage2DMaxHeight = ((int)0x1012),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE3D_MAX_WIDTH = 0x1013
        /// </summary>
        DeviceImage3DMaxWidth = ((int)0x1013),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE3D_MAX_HEIGHT = 0x1014
        /// </summary>
        DeviceImage3DMaxHeight = ((int)0x1014),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE3D_MAX_DEPTH = 0x1015
        /// </summary>
        DeviceImage3DMaxDepth = ((int)0x1015),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE_SUPPORT = 0x1016
        /// </summary>
        DeviceImageSupport = ((int)0x1016),
        /// <summary>
        /// Original was CL_DEVICE_MAX_PARAMETER_SIZE = 0x1017
        /// </summary>
        DeviceMaxParameterSize = ((int)0x1017),
        /// <summary>
        /// Original was CL_DEVICE_MAX_SAMPLERS = 0x1018
        /// </summary>
        DeviceMaxSamplers = ((int)0x1018),
        /// <summary>
        /// Original was CL_DEVICE_MEM_BASE_ADDR_ALIGN = 0x1019
        /// </summary>
        DeviceMemBaseAddrAlign = ((int)0x1019),
        /// <summary>
        /// Original was CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE = 0x101A
        /// </summary>
        DeviceMinDataTypeAlignSize = ((int)0x101A),
        /// <summary>
        /// Original was CL_DEVICE_SINGLE_FP_CONFIG = 0x101B
        /// </summary>
        DeviceSingleFpConfig = ((int)0x101B),
        /// <summary>
        /// Original was CL_DEVICE_GLOBAL_MEM_CACHE_TYPE = 0x101C
        /// </summary>
        DeviceGlobalMemCacheType = ((int)0x101C),
        /// <summary>
        /// Original was CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE = 0x101D
        /// </summary>
        DeviceGlobalMemCachelineSize = ((int)0x101D),
        /// <summary>
        /// Original was CL_DEVICE_GLOBAL_MEM_CACHE_SIZE = 0x101E
        /// </summary>
        DeviceGlobalMemCacheSize = ((int)0x101E),
        /// <summary>
        /// Original was CL_DEVICE_GLOBAL_MEM_SIZE = 0x101F
        /// </summary>
        DeviceGlobalMemSize = ((int)0x101F),
        /// <summary>
        /// Original was CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE = 0x1020
        /// </summary>
        DeviceMaxConstantBufferSize = ((int)0x1020),
        /// <summary>
        /// Original was CL_DEVICE_MAX_CONSTANT_ARGS = 0x1021
        /// </summary>
        DeviceMaxConstantArgs = ((int)0x1021),
        /// <summary>
        /// Original was CL_DEVICE_LOCAL_MEM_TYPE = 0x1022
        /// </summary>
        DeviceLocalMemType = ((int)0x1022),
        /// <summary>
        /// Original was CL_DEVICE_LOCAL_MEM_SIZE = 0x1023
        /// </summary>
        DeviceLocalMemSize = ((int)0x1023),
        /// <summary>
        /// Original was CL_DEVICE_ERROR_CORRECTION_SUPPORT = 0x1024
        /// </summary>
        DeviceErrorCorrectionSupport = ((int)0x1024),
        /// <summary>
        /// Original was CL_DEVICE_PROFILING_TIMER_RESOLUTION = 0x1025
        /// </summary>
        DeviceProfilingTimerResolution = ((int)0x1025),
        /// <summary>
        /// Original was CL_DEVICE_ENDIAN_LITTLE = 0x1026
        /// </summary>
        DeviceEndianLittle = ((int)0x1026),
        /// <summary>
        /// Original was CL_DEVICE_AVAILABLE = 0x1027
        /// </summary>
        DeviceAvailable = ((int)0x1027),
        /// <summary>
        /// Original was CL_DEVICE_COMPILER_AVAILABLE = 0x1028
        /// </summary>
        DeviceCompilerAvailable = ((int)0x1028),
        /// <summary>
        /// Original was CL_DEVICE_EXECUTION_CAPABILITIES = 0x1029
        /// </summary>
        DeviceExecutionCapabilities = ((int)0x1029),
        /// <summary>
        /// Original was CL_DEVICE_QUEUE_PROPERTIES = 0x102A
        /// </summary>
        DeviceQueueProperties = ((int)0x102A),
        /// <summary>
        /// Original was CL_DEVICE_NAME = 0x102B
        /// </summary>
        DeviceName = ((int)0x102B),
        /// <summary>
        /// Original was CL_DEVICE_VENDOR = 0x102C
        /// </summary>
        DeviceVendor = ((int)0x102C),
        /// <summary>
        /// Original was CL_DRIVER_VERSION = 0x102D
        /// </summary>
        DriverVersion = ((int)0x102D),
        /// <summary>
        /// Original was CL_DEVICE_PROFILE = 0x102E
        /// </summary>
        DeviceProfile = ((int)0x102E),
        /// <summary>
        /// Original was CL_DEVICE_VERSION = 0x102F
        /// </summary>
        DeviceVersion = ((int)0x102F),
        /// <summary>
        /// Original was CL_DEVICE_EXTENSIONS = 0x1030
        /// </summary>
        DeviceExtensions = ((int)0x1030),
        /// <summary>
        /// Original was CL_DEVICE_PLATFORM = 0x1031
        /// </summary>
        DevicePlatform = ((int)0x1031),
        /// <summary>
        /// Original was CL_DEVICE_HOST_UNIFIED_MEMORY = 0x1035
        /// </summary>
        DeviceHostUnifiedMemory = ((int)0x1035),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR = 0x1036
        /// </summary>
        DeviceNativeVectorWidthChar = ((int)0x1036),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT = 0x1037
        /// </summary>
        DeviceNativeVectorWidthShort = ((int)0x1037),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_INT = 0x1038
        /// </summary>
        DeviceNativeVectorWidthInt = ((int)0x1038),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG = 0x1039
        /// </summary>
        DeviceNativeVectorWidthLong = ((int)0x1039),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT = 0x103A
        /// </summary>
        DeviceNativeVectorWidthFloat = ((int)0x103A),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE = 0x103B
        /// </summary>
        DeviceNativeVectorWidthDouble = ((int)0x103B),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF = 0x103C
        /// </summary>
        DeviceNativeVectorWidthHalf = ((int)0x103C),
        /// <summary>
        /// Original was CL_DEVICE_OPENCL_C_VERSION = 0x103D
        /// </summary>
        DeviceOpenclCVersion = ((int)0x103D),
        /// <summary>
        /// Original was CL_CONTEXT_REFERENCE_COUNT = 0x1080
        /// </summary>
        ContextReferenceCount = ((int)0x1080),
        /// <summary>
        /// Original was CL_CONTEXT_DEVICES = 0x1081
        /// </summary>
        ContextDevices = ((int)0x1081),
        /// <summary>
        /// Original was CL_CONTEXT_PROPERTIES = 0x1082
        /// </summary>
        ContextProperties = ((int)0x1082),
        /// <summary>
        /// Original was CL_CONTEXT_NUM_DEVICES = 0x1083
        /// </summary>
        ContextNumDevices = ((int)0x1083),
        /// <summary>
        /// Original was CL_CONTEXT_PLATFORM = 0x1084
        /// </summary>
        ContextPlatform = ((int)0x1084),
        /// <summary>
        /// Original was CL_QUEUE_CONTEXT = 0x1090
        /// </summary>
        QueueContext = ((int)0x1090),
        /// <summary>
        /// Original was CL_QUEUE_DEVICE = 0x1091
        /// </summary>
        QueueDevice = ((int)0x1091),
        /// <summary>
        /// Original was CL_QUEUE_REFERENCE_COUNT = 0x1092
        /// </summary>
        QueueReferenceCount = ((int)0x1092),
        /// <summary>
        /// Original was CL_QUEUE_PROPERTIES = 0x1093
        /// </summary>
        QueueProperties = ((int)0x1093),
        /// <summary>
        /// Original was CL_R = 0x10B0
        /// </summary>
        R = ((int)0x10B0),
        /// <summary>
        /// Original was CL_A = 0x10B1
        /// </summary>
        A = ((int)0x10B1),
        /// <summary>
        /// Original was CL_RG = 0x10B2
        /// </summary>
        Rg = ((int)0x10B2),
        /// <summary>
        /// Original was CL_RA = 0x10B3
        /// </summary>
        Ra = ((int)0x10B3),
        /// <summary>
        /// Original was CL_RGB = 0x10B4
        /// </summary>
        Rgb = ((int)0x10B4),
        /// <summary>
        /// Original was CL_RGBA = 0x10B5
        /// </summary>
        Rgba = ((int)0x10B5),
        /// <summary>
        /// Original was CL_BGRA = 0x10B6
        /// </summary>
        Bgra = ((int)0x10B6),
        /// <summary>
        /// Original was CL_ARGB = 0x10B7
        /// </summary>
        Argb = ((int)0x10B7),
        /// <summary>
        /// Original was CL_INTENSITY = 0x10B8
        /// </summary>
        Intensity = ((int)0x10B8),
        /// <summary>
        /// Original was CL_LUMINANCE = 0x10B9
        /// </summary>
        Luminance = ((int)0x10B9),
        /// <summary>
        /// Original was CL_Rx = 0x10BA
        /// </summary>
        Rx = ((int)0x10BA),
        /// <summary>
        /// Original was CL_RGx = 0x10BB
        /// </summary>
        RGx = ((int)0x10BB),
        /// <summary>
        /// Original was CL_RGBx = 0x10BC
        /// </summary>
        RGBx = ((int)0x10BC),
        /// <summary>
        /// Original was CL_SNORM_INT8 = 0x10D0
        /// </summary>
        SnormInt8 = ((int)0x10D0),
        /// <summary>
        /// Original was CL_SNORM_INT16 = 0x10D1
        /// </summary>
        SnormInt16 = ((int)0x10D1),
        /// <summary>
        /// Original was CL_UNORM_INT8 = 0x10D2
        /// </summary>
        UnormInt8 = ((int)0x10D2),
        /// <summary>
        /// Original was CL_UNORM_INT16 = 0x10D3
        /// </summary>
        UnormInt16 = ((int)0x10D3),
        /// <summary>
        /// Original was CL_UNORM_SHORT_565 = 0x10D4
        /// </summary>
        UnormShort565 = ((int)0x10D4),
        /// <summary>
        /// Original was CL_UNORM_SHORT_555 = 0x10D5
        /// </summary>
        UnormShort555 = ((int)0x10D5),
        /// <summary>
        /// Original was CL_UNORM_INT_101010 = 0x10D6
        /// </summary>
        UnormInt101010 = ((int)0x10D6),
        /// <summary>
        /// Original was CL_SIGNED_INT8 = 0x10D7
        /// </summary>
        SignedInt8 = ((int)0x10D7),
        /// <summary>
        /// Original was CL_SIGNED_INT16 = 0x10D8
        /// </summary>
        SignedInt16 = ((int)0x10D8),
        /// <summary>
        /// Original was CL_SIGNED_INT32 = 0x10D9
        /// </summary>
        SignedInt32 = ((int)0x10D9),
        /// <summary>
        /// Original was CL_UNSIGNED_INT8 = 0x10DA
        /// </summary>
        UnsignedInt8 = ((int)0x10DA),
        /// <summary>
        /// Original was CL_UNSIGNED_INT16 = 0x10DB
        /// </summary>
        UnsignedInt16 = ((int)0x10DB),
        /// <summary>
        /// Original was CL_UNSIGNED_INT32 = 0x10DC
        /// </summary>
        UnsignedInt32 = ((int)0x10DC),
        /// <summary>
        /// Original was CL_HALF_FLOAT = 0x10DD
        /// </summary>
        HalfFloat = ((int)0x10DD),
        /// <summary>
        /// Original was CL_FLOAT = 0x10DE
        /// </summary>
        Float = ((int)0x10DE),
        /// <summary>
        /// Original was CL_MEM_OBJECT_BUFFER = 0x10F0
        /// </summary>
        MemObjectBuffer = ((int)0x10F0),
        /// <summary>
        /// Original was CL_MEM_OBJECT_IMAGE2D = 0x10F1
        /// </summary>
        MemObjectImage2D = ((int)0x10F1),
        /// <summary>
        /// Original was CL_MEM_OBJECT_IMAGE3D = 0x10F2
        /// </summary>
        MemObjectImage3D = ((int)0x10F2),
        /// <summary>
        /// Original was CL_MEM_TYPE = 0x1100
        /// </summary>
        MemType = ((int)0x1100),
        /// <summary>
        /// Original was CL_MEM_FLAGS = 0x1101
        /// </summary>
        MemFlags = ((int)0x1101),
        /// <summary>
        /// Original was CL_MEM_SIZE = 0x1102
        /// </summary>
        MemSize = ((int)0x1102),
        /// <summary>
        /// Original was CL_MEM_HOST_PTR = 0x1103
        /// </summary>
        MemHostPtr = ((int)0x1103),
        /// <summary>
        /// Original was CL_MEM_MAP_COUNT = 0x1104
        /// </summary>
        MemMapCount = ((int)0x1104),
        /// <summary>
        /// Original was CL_MEM_REFERENCE_COUNT = 0x1105
        /// </summary>
        MemReferenceCount = ((int)0x1105),
        /// <summary>
        /// Original was CL_MEM_CONTEXT = 0x1106
        /// </summary>
        MemContext = ((int)0x1106),
        /// <summary>
        /// Original was CL_IMAGE_FORMAT = 0x1110
        /// </summary>
        ImageFormat = ((int)0x1110),
        /// <summary>
        /// Original was CL_IMAGE_ELEMENT_SIZE = 0x1111
        /// </summary>
        ImageElementSize = ((int)0x1111),
        /// <summary>
        /// Original was CL_IMAGE_ROW_PITCH = 0x1112
        /// </summary>
        ImageRowPitch = ((int)0x1112),
        /// <summary>
        /// Original was CL_IMAGE_SLICE_PITCH = 0x1113
        /// </summary>
        ImageSlicePitch = ((int)0x1113),
        /// <summary>
        /// Original was CL_IMAGE_WIDTH = 0x1114
        /// </summary>
        ImageWidth = ((int)0x1114),
        /// <summary>
        /// Original was CL_IMAGE_HEIGHT = 0x1115
        /// </summary>
        ImageHeight = ((int)0x1115),
        /// <summary>
        /// Original was CL_IMAGE_DEPTH = 0x1116
        /// </summary>
        ImageDepth = ((int)0x1116),
        /// <summary>
        /// Original was CL_ADDRESS_NONE = 0x1130
        /// </summary>
        AddressNone = ((int)0x1130),
        /// <summary>
        /// Original was CL_ADDRESS_CLAMP_TO_EDGE = 0x1131
        /// </summary>
        AddressClampToEdge = ((int)0x1131),
        /// <summary>
        /// Original was CL_ADDRESS_CLAMP = 0x1132
        /// </summary>
        AddressClamp = ((int)0x1132),
        /// <summary>
        /// Original was CL_ADDRESS_REPEAT = 0x1133
        /// </summary>
        AddressRepeat = ((int)0x1133),
        /// <summary>
        /// Original was CL_FILTER_NEAREST = 0x1140
        /// </summary>
        FilterNearest = ((int)0x1140),
        /// <summary>
        /// Original was CL_FILTER_LINEAR = 0x1141
        /// </summary>
        FilterLinear = ((int)0x1141),
        /// <summary>
        /// Original was CL_SAMPLER_REFERENCE_COUNT = 0x1150
        /// </summary>
        SamplerReferenceCount = ((int)0x1150),
        /// <summary>
        /// Original was CL_SAMPLER_CONTEXT = 0x1151
        /// </summary>
        SamplerContext = ((int)0x1151),
        /// <summary>
        /// Original was CL_SAMPLER_NORMALIZED_COORDS = 0x1152
        /// </summary>
        SamplerNormalizedCoords = ((int)0x1152),
        /// <summary>
        /// Original was CL_SAMPLER_ADDRESSING_MODE = 0x1153
        /// </summary>
        SamplerAddressingMode = ((int)0x1153),
        /// <summary>
        /// Original was CL_SAMPLER_FILTER_MODE = 0x1154
        /// </summary>
        SamplerFilterMode = ((int)0x1154),
        /// <summary>
        /// Original was CL_PROGRAM_REFERENCE_COUNT = 0x1160
        /// </summary>
        ProgramReferenceCount = ((int)0x1160),
        /// <summary>
        /// Original was CL_PROGRAM_CONTEXT = 0x1161
        /// </summary>
        ProgramContext = ((int)0x1161),
        /// <summary>
        /// Original was CL_PROGRAM_NUM_DEVICES = 0x1162
        /// </summary>
        ProgramNumDevices = ((int)0x1162),
        /// <summary>
        /// Original was CL_PROGRAM_DEVICES = 0x1163
        /// </summary>
        ProgramDevices = ((int)0x1163),
        /// <summary>
        /// Original was CL_PROGRAM_SOURCE = 0x1164
        /// </summary>
        ProgramSource = ((int)0x1164),
        /// <summary>
        /// Original was CL_PROGRAM_BINARY_SIZES = 0x1165
        /// </summary>
        ProgramBinarySizes = ((int)0x1165),
        /// <summary>
        /// Original was CL_PROGRAM_BINARIES = 0x1166
        /// </summary>
        ProgramBinaries = ((int)0x1166),
        /// <summary>
        /// Original was CL_PROGRAM_BUILD_STATUS = 0x1181
        /// </summary>
        ProgramBuildStatus = ((int)0x1181),
        /// <summary>
        /// Original was CL_PROGRAM_BUILD_OPTIONS = 0x1182
        /// </summary>
        ProgramBuildOptions = ((int)0x1182),
        /// <summary>
        /// Original was CL_PROGRAM_BUILD_LOG = 0x1183
        /// </summary>
        ProgramBuildLog = ((int)0x1183),
        /// <summary>
        /// Original was CL_KERNEL_FUNCTION_NAME = 0x1190
        /// </summary>
        KernelFunctionName = ((int)0x1190),
        /// <summary>
        /// Original was CL_KERNEL_NUM_ARGS = 0x1191
        /// </summary>
        KernelNumArgs = ((int)0x1191),
        /// <summary>
        /// Original was CL_KERNEL_REFERENCE_COUNT = 0x1192
        /// </summary>
        KernelReferenceCount = ((int)0x1192),
        /// <summary>
        /// Original was CL_KERNEL_CONTEXT = 0x1193
        /// </summary>
        KernelContext = ((int)0x1193),
        /// <summary>
        /// Original was CL_KERNEL_PROGRAM = 0x1194
        /// </summary>
        KernelProgram = ((int)0x1194),
        /// <summary>
        /// Original was CL_KERNEL_WORK_GROUP_SIZE = 0x11B0
        /// </summary>
        KernelWorkGroupSize = ((int)0x11B0),
        /// <summary>
        /// Original was CL_KERNEL_COMPILE_WORK_GROUP_SIZE = 0x11B1
        /// </summary>
        KernelCompileWorkGroupSize = ((int)0x11B1),
        /// <summary>
        /// Original was CL_KERNEL_LOCAL_MEM_SIZE = 0x11B2
        /// </summary>
        KernelLocalMemSize = ((int)0x11B2),
        /// <summary>
        /// Original was CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE = 0x11B3
        /// </summary>
        KernelPreferredWorkGroupSizeMultiple = ((int)0x11B3),
        /// <summary>
        /// Original was CL_EVENT_COMMAND_QUEUE = 0x11D0
        /// </summary>
        EventCommandQueue = ((int)0x11D0),
        /// <summary>
        /// Original was CL_EVENT_COMMAND_TYPE = 0x11D1
        /// </summary>
        EventCommandType = ((int)0x11D1),
        /// <summary>
        /// Original was CL_EVENT_REFERENCE_COUNT = 0x11D2
        /// </summary>
        EventReferenceCount = ((int)0x11D2),
        /// <summary>
        /// Original was CL_EVENT_COMMAND_EXECUTION_STATUS = 0x11D3
        /// </summary>
        EventCommandExecutionStatus = ((int)0x11D3),
        /// <summary>
        /// Original was CL_COMMAND_NDRANGE_KERNEL = 0x11F0
        /// </summary>
        CommandNdrangeKernel = ((int)0x11F0),
        /// <summary>
        /// Original was CL_COMMAND_TASK = 0x11F1
        /// </summary>
        CommandTask = ((int)0x11F1),
        /// <summary>
        /// Original was CL_COMMAND_NATIVE_KERNEL = 0x11F2
        /// </summary>
        CommandNativeKernel = ((int)0x11F2),
        /// <summary>
        /// Original was CL_COMMAND_READ_BUFFER = 0x11F3
        /// </summary>
        CommandReadBuffer = ((int)0x11F3),
        /// <summary>
        /// Original was CL_COMMAND_WRITE_BUFFER = 0x11F4
        /// </summary>
        CommandWriteBuffer = ((int)0x11F4),
        /// <summary>
        /// Original was CL_COMMAND_COPY_BUFFER = 0x11F5
        /// </summary>
        CommandCopyBuffer = ((int)0x11F5),
        /// <summary>
        /// Original was CL_COMMAND_READ_IMAGE = 0x11F6
        /// </summary>
        CommandReadImage = ((int)0x11F6),
        /// <summary>
        /// Original was CL_COMMAND_WRITE_IMAGE = 0x11F7
        /// </summary>
        CommandWriteImage = ((int)0x11F7),
        /// <summary>
        /// Original was CL_COMMAND_COPY_IMAGE = 0x11F8
        /// </summary>
        CommandCopyImage = ((int)0x11F8),
        /// <summary>
        /// Original was CL_COMMAND_COPY_IMAGE_TO_BUFFER = 0x11F9
        /// </summary>
        CommandCopyImageToBuffer = ((int)0x11F9),
        /// <summary>
        /// Original was CL_COMMAND_COPY_BUFFER_TO_IMAGE = 0x11FA
        /// </summary>
        CommandCopyBufferToImage = ((int)0x11FA),
        /// <summary>
        /// Original was CL_COMMAND_MAP_BUFFER = 0x11FB
        /// </summary>
        CommandMapBuffer = ((int)0x11FB),
        /// <summary>
        /// Original was CL_COMMAND_MAP_IMAGE = 0x11FC
        /// </summary>
        CommandMapImage = ((int)0x11FC),
        /// <summary>
        /// Original was CL_COMMAND_UNMAP_MEM_OBJECT = 0x11FD
        /// </summary>
        CommandUnmapMemObject = ((int)0x11FD),
        /// <summary>
        /// Original was CL_COMMAND_MARKER = 0x11FE
        /// </summary>
        CommandMarker = ((int)0x11FE),
        /// <summary>
        /// Original was CL_COMMAND_ACQUIRE_GL_OBJECTS = 0x11FF
        /// </summary>
        CommandAcquireGlObjects = ((int)0x11FF),
        /// <summary>
        /// Original was CL_COMMAND_RELEASE_GL_OBJECTS = 0x1200
        /// </summary>
        CommandReleaseGlObjects = ((int)0x1200),
        /// <summary>
        /// Original was CL_BUFFER_CREATE_TYPE_REGION = 0x1220
        /// </summary>
        BufferCreateTypeRegion = ((int)0x1220),
        /// <summary>
        /// Original was CL_PROFILING_COMMAND_QUEUED = 0x1280
        /// </summary>
        ProfilingCommandQueued = ((int)0x1280),
        /// <summary>
        /// Original was CL_PROFILING_COMMAND_SUBMIT = 0x1281
        /// </summary>
        ProfilingCommandSubmit = ((int)0x1281),
        /// <summary>
        /// Original was CL_PROFILING_COMMAND_START = 0x1282
        /// </summary>
        ProfilingCommandStart = ((int)0x1282),
        /// <summary>
        /// Original was CL_PROFILING_COMMAND_END = 0x1283
        /// </summary>
        ProfilingCommandEnd = ((int)0x1283),
        /// <summary>
        /// Original was CL_GLOBAL = 0x2
        /// </summary>
        Global = ((int)0x2),
        /// <summary>
        /// Original was CL_READ_WRITE_CACHE = 0x2
        /// </summary>
        ReadWriteCache = ((int)0x2),
        /// <summary>
        /// Original was CL_SUBMITTED = 0x2
        /// </summary>
        Submitted = ((int)0x2),
        /// <summary>
        /// Original was CL_QUEUED = 0x3
        /// </summary>
        Queued = ((int)0x3),
        /// <summary>
        /// Original was CL_DEVICE_TYPE_ALL = 0xFFFFFFFF
        /// </summary>
        DeviceTypeAll = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// Original was CL_TRUE = 1
        /// </summary>
        True = ((int)1),
        /// <summary>
        /// Original was CL_VERSION_1_0 = 1
        /// </summary>
        Version10 = ((int)1),
        /// <summary>
        /// Original was CL_BUILD_NONE = -1
        /// </summary>
        BuildNone = ((int)-1),
        /// <summary>
        /// Original was CL_DEVICE_NOT_FOUND = -1
        /// </summary>
        DeviceNotFound = ((int)-1),
        /// <summary>
        /// Original was CL_IMAGE_FORMAT_NOT_SUPPORTED = -10
        /// </summary>
        ImageFormatNotSupported = ((int)-10),
        /// <summary>
        /// Original was CL_BUILD_PROGRAM_FAILURE = -11
        /// </summary>
        BuildProgramFailure = ((int)-11),
        /// <summary>
        /// Original was CL_MAP_FAILURE = -12
        /// </summary>
        MapFailure = ((int)-12),
        /// <summary>
        /// Original was CL_BUILD_ERROR = -2
        /// </summary>
        BuildError = ((int)-2),
        /// <summary>
        /// Original was CL_DEVICE_NOT_AVAILABLE = -2
        /// </summary>
        DeviceNotAvailable = ((int)-2),
        /// <summary>
        /// Original was CL_BUILD_IN_PROGRESS = -3
        /// </summary>
        BuildInProgress = ((int)-3),
        /// <summary>
        /// Original was CL_COMPILER_NOT_AVAILABLE = -3
        /// </summary>
        CompilerNotAvailable = ((int)-3),
        /// <summary>
        /// Original was CL_INVALID_VALUE = -30
        /// </summary>
        InvalidValue = ((int)-30),
        /// <summary>
        /// Original was CL_INVALID_DEVICE_TYPE = -31
        /// </summary>
        InvalidDeviceType = ((int)-31),
        /// <summary>
        /// Original was CL_INVALID_PLATFORM = -32
        /// </summary>
        InvalidPlatform = ((int)-32),
        /// <summary>
        /// Original was CL_INVALID_DEVICE = -33
        /// </summary>
        InvalidDevice = ((int)-33),
        /// <summary>
        /// Original was CL_INVALID_CONTEXT = -34
        /// </summary>
        InvalidContext = ((int)-34),
        /// <summary>
        /// Original was CL_INVALID_QUEUE_PROPERTIES = -35
        /// </summary>
        InvalidQueueProperties = ((int)-35),
        /// <summary>
        /// Original was CL_INVALID_COMMAND_QUEUE = -36
        /// </summary>
        InvalidCommandQueue = ((int)-36),
        /// <summary>
        /// Original was CL_INVALID_HOST_PTR = -37
        /// </summary>
        InvalidHostPtr = ((int)-37),
        /// <summary>
        /// Original was CL_INVALID_MEM_OBJECT = -38
        /// </summary>
        InvalidMemObject = ((int)-38),
        /// <summary>
        /// Original was CL_INVALID_IMAGE_FORMAT_DESCRIPTOR = -39
        /// </summary>
        InvalidImageFormatDescriptor = ((int)-39),
        /// <summary>
        /// Original was CL_MEM_OBJECT_ALLOCATION_FAILURE = -4
        /// </summary>
        MemObjectAllocationFailure = ((int)-4),
        /// <summary>
        /// Original was CL_INVALID_IMAGE_SIZE = -40
        /// </summary>
        InvalidImageSize = ((int)-40),
        /// <summary>
        /// Original was CL_INVALID_SAMPLER = -41
        /// </summary>
        InvalidSampler = ((int)-41),
        /// <summary>
        /// Original was CL_INVALID_BINARY = -42
        /// </summary>
        InvalidBinary = ((int)-42),
        /// <summary>
        /// Original was CL_INVALID_BUILD_OPTIONS = -43
        /// </summary>
        InvalidBuildOptions = ((int)-43),
        /// <summary>
        /// Original was CL_INVALID_PROGRAM = -44
        /// </summary>
        InvalidProgram = ((int)-44),
        /// <summary>
        /// Original was CL_INVALID_PROGRAM_EXECUTABLE = -45
        /// </summary>
        InvalidProgramExecutable = ((int)-45),
        /// <summary>
        /// Original was CL_INVALID_KERNEL_NAME = -46
        /// </summary>
        InvalidKernelName = ((int)-46),
        /// <summary>
        /// Original was CL_INVALID_KERNEL_DEFINITION = -47
        /// </summary>
        InvalidKernelDefinition = ((int)-47),
        /// <summary>
        /// Original was CL_INVALID_KERNEL = -48
        /// </summary>
        InvalidKernel = ((int)-48),
        /// <summary>
        /// Original was CL_INVALID_ARG_INDEX = -49
        /// </summary>
        InvalidArgIndex = ((int)-49),
        /// <summary>
        /// Original was CL_OUT_OF_RESOURCES = -5
        /// </summary>
        OutOfResources = ((int)-5),
        /// <summary>
        /// Original was CL_INVALID_ARG_VALUE = -50
        /// </summary>
        InvalidArgValue = ((int)-50),
        /// <summary>
        /// Original was CL_INVALID_ARG_SIZE = -51
        /// </summary>
        InvalidArgSize = ((int)-51),
        /// <summary>
        /// Original was CL_INVALID_KERNEL_ARGS = -52
        /// </summary>
        InvalidKernelArgs = ((int)-52),
        /// <summary>
        /// Original was CL_INVALID_WORK_DIMENSION = -53
        /// </summary>
        InvalidWorkDimension = ((int)-53),
        /// <summary>
        /// Original was CL_INVALID_WORK_GROUP_SIZE = -54
        /// </summary>
        InvalidWorkGroupSize = ((int)-54),
        /// <summary>
        /// Original was CL_INVALID_WORK_ITEM_SIZE = -55
        /// </summary>
        InvalidWorkItemSize = ((int)-55),
        /// <summary>
        /// Original was CL_INVALID_GLOBAL_OFFSET = -56
        /// </summary>
        InvalidGlobalOffset = ((int)-56),
        /// <summary>
        /// Original was CL_INVALID_EVENT_WAIT_LIST = -57
        /// </summary>
        InvalidEventWaitList = ((int)-57),
        /// <summary>
        /// Original was CL_INVALID_EVENT = -58
        /// </summary>
        InvalidEvent = ((int)-58),
        /// <summary>
        /// Original was CL_INVALID_OPERATION = -59
        /// </summary>
        InvalidOperation = ((int)-59),
        /// <summary>
        /// Original was CL_OUT_OF_HOST_MEMORY = -6
        /// </summary>
        OutOfHostMemory = ((int)-6),
        /// <summary>
        /// Original was CL_INVALID_GL_OBJECT = -60
        /// </summary>
        InvalidGlObject = ((int)-60),
        /// <summary>
        /// Original was CL_INVALID_BUFFER_SIZE = -61
        /// </summary>
        InvalidBufferSize = ((int)-61),
        /// <summary>
        /// Original was CL_INVALID_MIP_LEVEL = -62
        /// </summary>
        InvalidMipLevel = ((int)-62),
        /// <summary>
        /// Original was CL_PROFILING_INFO_NOT_AVAILABLE = -7
        /// </summary>
        ProfilingInfoNotAvailable = ((int)-7),
        /// <summary>
        /// Original was CL_MEM_COPY_OVERLAP = -8
        /// </summary>
        MemCopyOverlap = ((int)-8),
        /// <summary>
        /// Original was CL_IMAGE_FORMAT_MISMATCH = -9
        /// </summary>
        ImageFormatMismatch = ((int)-9),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Bool : int
    {
        /// <summary>
        /// Original was CL_FALSE = 0
        /// </summary>
        False = ((int)0),
        /// <summary>
        /// Original was CL_TRUE = 1
        /// </summary>
        True = ((int)1),
    }

    /// <summary>
    /// Used in GL.CreateSubBuffer
    /// </summary>
    public enum BufferCreateType : int
    {
        /// <summary>
        /// Original was CL_BUFFER_CREATE_TYPE_REGION = 0x1220
        /// </summary>
        BufferCreateTypeRegion = ((int)0x1220),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BuildStatus : int
    {
        /// <summary>
        /// Original was CL_BUILD_SUCCESS = 0
        /// </summary>
        BuildSuccess = ((int)0),
        /// <summary>
        /// Original was CL_BUILD_NONE = -1
        /// </summary>
        BuildNone = ((int)-1),
        /// <summary>
        /// Original was CL_BUILD_ERROR = -2
        /// </summary>
        BuildError = ((int)-2),
        /// <summary>
        /// Original was CL_BUILD_IN_PROGRESS = -3
        /// </summary>
        BuildInProgress = ((int)-3),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ChannelOrder : int
    {
        /// <summary>
        /// Original was CL_R = 0x10B0
        /// </summary>
        R = ((int)0x10B0),
        /// <summary>
        /// Original was CL_A = 0x10B1
        /// </summary>
        A = ((int)0x10B1),
        /// <summary>
        /// Original was CL_RG = 0x10B2
        /// </summary>
        Rg = ((int)0x10B2),
        /// <summary>
        /// Original was CL_RA = 0x10B3
        /// </summary>
        Ra = ((int)0x10B3),
        /// <summary>
        /// Original was CL_RGB = 0x10B4
        /// </summary>
        Rgb = ((int)0x10B4),
        /// <summary>
        /// Original was CL_RGBA = 0x10B5
        /// </summary>
        Rgba = ((int)0x10B5),
        /// <summary>
        /// Original was CL_BGRA = 0x10B6
        /// </summary>
        Bgra = ((int)0x10B6),
        /// <summary>
        /// Original was CL_ARGB = 0x10B7
        /// </summary>
        Argb = ((int)0x10B7),
        /// <summary>
        /// Original was CL_INTENSITY = 0x10B8
        /// </summary>
        Intensity = ((int)0x10B8),
        /// <summary>
        /// Original was CL_LUMINANCE = 0x10B9
        /// </summary>
        Luminance = ((int)0x10B9),
        /// <summary>
        /// Original was CL_Rx = 0x10BA
        /// </summary>
        Rx = ((int)0x10BA),
        /// <summary>
        /// Original was CL_RGx = 0x10BB
        /// </summary>
        RGx = ((int)0x10BB),
        /// <summary>
        /// Original was CL_RGBx = 0x10BC
        /// </summary>
        RGBx = ((int)0x10BC),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ChannelType : int
    {
        /// <summary>
        /// Original was CL_SNORM_INT8 = 0x10D0
        /// </summary>
        SnormInt8 = ((int)0x10D0),
        /// <summary>
        /// Original was CL_SNORM_INT16 = 0x10D1
        /// </summary>
        SnormInt16 = ((int)0x10D1),
        /// <summary>
        /// Original was CL_UNORM_INT8 = 0x10D2
        /// </summary>
        UnormInt8 = ((int)0x10D2),
        /// <summary>
        /// Original was CL_UNORM_INT16 = 0x10D3
        /// </summary>
        UnormInt16 = ((int)0x10D3),
        /// <summary>
        /// Original was CL_UNORM_SHORT_565 = 0x10D4
        /// </summary>
        UnormShort565 = ((int)0x10D4),
        /// <summary>
        /// Original was CL_UNORM_SHORT_555 = 0x10D5
        /// </summary>
        UnormShort555 = ((int)0x10D5),
        /// <summary>
        /// Original was CL_UNORM_INT_101010 = 0x10D6
        /// </summary>
        UnormInt101010 = ((int)0x10D6),
        /// <summary>
        /// Original was CL_SIGNED_INT8 = 0x10D7
        /// </summary>
        SignedInt8 = ((int)0x10D7),
        /// <summary>
        /// Original was CL_SIGNED_INT16 = 0x10D8
        /// </summary>
        SignedInt16 = ((int)0x10D8),
        /// <summary>
        /// Original was CL_SIGNED_INT32 = 0x10D9
        /// </summary>
        SignedInt32 = ((int)0x10D9),
        /// <summary>
        /// Original was CL_UNSIGNED_INT8 = 0x10DA
        /// </summary>
        UnsignedInt8 = ((int)0x10DA),
        /// <summary>
        /// Original was CL_UNSIGNED_INT16 = 0x10DB
        /// </summary>
        UnsignedInt16 = ((int)0x10DB),
        /// <summary>
        /// Original was CL_UNSIGNED_INT32 = 0x10DC
        /// </summary>
        UnsignedInt32 = ((int)0x10DC),
        /// <summary>
        /// Original was CL_HALF_FLOAT = 0x10DD
        /// </summary>
        HalfFloat = ((int)0x10DD),
        /// <summary>
        /// Original was CL_FLOAT = 0x10DE
        /// </summary>
        Float = ((int)0x10DE),
    }

    /// <summary>
    /// Used in GL.SetEventCallback, GL.SetUserEventStatus
    /// </summary>
    public enum CommandExecutionStatusFlags : int
    {
        /// <summary>
        /// Original was CL_COMPLETE = 0x0
        /// </summary>
        Complete = ((int)0x0),
        /// <summary>
        /// Original was CL_RUNNING = 0x1
        /// </summary>
        Running = ((int)0x1),
        /// <summary>
        /// Original was CL_SUBMITTED = 0x2
        /// </summary>
        Submitted = ((int)0x2),
        /// <summary>
        /// Original was CL_QUEUED = 0x3
        /// </summary>
        Queued = ((int)0x3),
    }

    /// <summary>
    /// Used in GL.CreateCommandQueue
    /// </summary>
    public enum CommandQueueFlags : long
    {
        /// <summary>
        /// Original was CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE = (1 &lt;&lt; 0)
        /// </summary>
        QueueOutOfOrderExecModeEnable = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_QUEUE_PROFILING_ENABLE = (1 &lt;&lt; 1)
        /// </summary>
        QueueProfilingEnable = ((int)(1 << 1)),
        /// <summary>
        /// Original was CL_DEFAULT = 0
        /// </summary>
        Default = ((int)0),
    }

    /// <summary>
    /// Used in GL.GetCommandQueueInfo
    /// </summary>
    public enum CommandQueueInfo : int
    {
        /// <summary>
        /// Original was CL_QUEUE_CONTEXT = 0x1090
        /// </summary>
        QueueContext = ((int)0x1090),
        /// <summary>
        /// Original was CL_QUEUE_DEVICE = 0x1091
        /// </summary>
        QueueDevice = ((int)0x1091),
        /// <summary>
        /// Original was CL_QUEUE_REFERENCE_COUNT = 0x1092
        /// </summary>
        QueueReferenceCount = ((int)0x1092),
        /// <summary>
        /// Original was CL_QUEUE_PROPERTIES = 0x1093
        /// </summary>
        QueueProperties = ((int)0x1093),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum CommandType : int
    {
        /// <summary>
        /// Original was CL_COMMAND_NDRANGE_KERNEL = 0x11F0
        /// </summary>
        CommandNdrangeKernel = ((int)0x11F0),
        /// <summary>
        /// Original was CL_COMMAND_TASK = 0x11F1
        /// </summary>
        CommandTask = ((int)0x11F1),
        /// <summary>
        /// Original was CL_COMMAND_NATIVE_KERNEL = 0x11F2
        /// </summary>
        CommandNativeKernel = ((int)0x11F2),
        /// <summary>
        /// Original was CL_COMMAND_READ_BUFFER = 0x11F3
        /// </summary>
        CommandReadBuffer = ((int)0x11F3),
        /// <summary>
        /// Original was CL_COMMAND_WRITE_BUFFER = 0x11F4
        /// </summary>
        CommandWriteBuffer = ((int)0x11F4),
        /// <summary>
        /// Original was CL_COMMAND_COPY_BUFFER = 0x11F5
        /// </summary>
        CommandCopyBuffer = ((int)0x11F5),
        /// <summary>
        /// Original was CL_COMMAND_READ_IMAGE = 0x11F6
        /// </summary>
        CommandReadImage = ((int)0x11F6),
        /// <summary>
        /// Original was CL_COMMAND_WRITE_IMAGE = 0x11F7
        /// </summary>
        CommandWriteImage = ((int)0x11F7),
        /// <summary>
        /// Original was CL_COMMAND_COPY_IMAGE = 0x11F8
        /// </summary>
        CommandCopyImage = ((int)0x11F8),
        /// <summary>
        /// Original was CL_COMMAND_COPY_IMAGE_TO_BUFFER = 0x11F9
        /// </summary>
        CommandCopyImageToBuffer = ((int)0x11F9),
        /// <summary>
        /// Original was CL_COMMAND_COPY_BUFFER_TO_IMAGE = 0x11FA
        /// </summary>
        CommandCopyBufferToImage = ((int)0x11FA),
        /// <summary>
        /// Original was CL_COMMAND_MAP_BUFFER = 0x11FB
        /// </summary>
        CommandMapBuffer = ((int)0x11FB),
        /// <summary>
        /// Original was CL_COMMAND_MAP_IMAGE = 0x11FC
        /// </summary>
        CommandMapImage = ((int)0x11FC),
        /// <summary>
        /// Original was CL_COMMAND_UNMAP_MEM_OBJECT = 0x11FD
        /// </summary>
        CommandUnmapMemObject = ((int)0x11FD),
        /// <summary>
        /// Original was CL_COMMAND_MARKER = 0x11FE
        /// </summary>
        CommandMarker = ((int)0x11FE),
        /// <summary>
        /// Original was CL_COMMAND_ACQUIRE_GL_OBJECTS = 0x11FF
        /// </summary>
        CommandAcquireGlObjects = ((int)0x11FF),
        /// <summary>
        /// Original was CL_COMMAND_RELEASE_GL_OBJECTS = 0x1200
        /// </summary>
        CommandReleaseGlObjects = ((int)0x1200),
    }

    /// <summary>
    /// Used in GL.GetContextInfo
    /// </summary>
    public enum ContextInfo : int
    {
        /// <summary>
        /// Original was CL_CONTEXT_REFERENCE_COUNT = 0x1080
        /// </summary>
        ContextReferenceCount = ((int)0x1080),
        /// <summary>
        /// Original was CL_CONTEXT_DEVICES = 0x1081
        /// </summary>
        ContextDevices = ((int)0x1081),
        /// <summary>
        /// Original was CL_CONTEXT_PROPERTIES = 0x1082
        /// </summary>
        ContextProperties = ((int)0x1082),
        /// <summary>
        /// Original was CL_CONTEXT_NUM_DEVICES = 0x1083
        /// </summary>
        ContextNumDevices = ((int)0x1083),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ContextProperties : int
    {
        /// <summary>
        /// Original was CL_CONTEXT_PLATFORM = 0x1084
        /// </summary>
        ContextPlatform = ((int)0x1084),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DeviceExecCapabilitiesFlags : long
    {
        /// <summary>
        /// Original was CL_EXEC_KERNEL = (1 &lt;&lt; 0)
        /// </summary>
        ExecKernel = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_EXEC_NATIVE_KERNEL = (1 &lt;&lt; 1)
        /// </summary>
        ExecNativeKernel = ((int)(1 << 1)),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DeviceFpConfigFlags : long
    {
        /// <summary>
        /// Original was CL_FP_DENORM = (1 &lt;&lt; 0)
        /// </summary>
        FpDenorm = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_FP_INF_NAN = (1 &lt;&lt; 1)
        /// </summary>
        FpInfNan = ((int)(1 << 1)),
        /// <summary>
        /// Original was CL_FP_ROUND_TO_NEAREST = (1 &lt;&lt; 2)
        /// </summary>
        FpRoundToNearest = ((int)(1 << 2)),
        /// <summary>
        /// Original was CL_FP_ROUND_TO_ZERO = (1 &lt;&lt; 3)
        /// </summary>
        FpRoundToZero = ((int)(1 << 3)),
        /// <summary>
        /// Original was CL_FP_ROUND_TO_INF = (1 &lt;&lt; 4)
        /// </summary>
        FpRoundToInf = ((int)(1 << 4)),
        /// <summary>
        /// Original was CL_FP_FMA = (1 &lt;&lt; 5)
        /// </summary>
        FpFma = ((int)(1 << 5)),
    }

    /// <summary>
    /// Used in GL.GetDeviceInfo
    /// </summary>
    public enum DeviceInfo : int
    {
        /// <summary>
        /// Original was CL_DEVICE_TYPE = 0x1000
        /// </summary>
        DeviceType = ((int)0x1000),
        /// <summary>
        /// Original was CL_DEVICE_VENDOR_ID = 0x1001
        /// </summary>
        DeviceVendorId = ((int)0x1001),
        /// <summary>
        /// Original was CL_DEVICE_MAX_COMPUTE_UNITS = 0x1002
        /// </summary>
        DeviceMaxComputeUnits = ((int)0x1002),
        /// <summary>
        /// Original was CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS = 0x1003
        /// </summary>
        DeviceMaxWorkItemDimensions = ((int)0x1003),
        /// <summary>
        /// Original was CL_DEVICE_MAX_WORK_GROUP_SIZE = 0x1004
        /// </summary>
        DeviceMaxWorkGroupSize = ((int)0x1004),
        /// <summary>
        /// Original was CL_DEVICE_MAX_WORK_ITEM_SIZES = 0x1005
        /// </summary>
        DeviceMaxWorkItemSizes = ((int)0x1005),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR = 0x1006
        /// </summary>
        DevicePreferredVectorWidthChar = ((int)0x1006),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT = 0x1007
        /// </summary>
        DevicePreferredVectorWidthShort = ((int)0x1007),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT = 0x1008
        /// </summary>
        DevicePreferredVectorWidthInt = ((int)0x1008),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG = 0x1009
        /// </summary>
        DevicePreferredVectorWidthLong = ((int)0x1009),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT = 0x100A
        /// </summary>
        DevicePreferredVectorWidthFloat = ((int)0x100A),
        /// <summary>
        /// Original was CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE = 0x100B
        /// </summary>
        DevicePreferredVectorWidthDouble = ((int)0x100B),
        /// <summary>
        /// Original was CL_DEVICE_MAX_CLOCK_FREQUENCY = 0x100C
        /// </summary>
        DeviceMaxClockFrequency = ((int)0x100C),
        /// <summary>
        /// Original was CL_DEVICE_ADDRESS_BITS = 0x100D
        /// </summary>
        DeviceAddressBits = ((int)0x100D),
        /// <summary>
        /// Original was CL_DEVICE_MAX_READ_IMAGE_ARGS = 0x100E
        /// </summary>
        DeviceMaxReadImageArgs = ((int)0x100E),
        /// <summary>
        /// Original was CL_DEVICE_MAX_WRITE_IMAGE_ARGS = 0x100F
        /// </summary>
        DeviceMaxWriteImageArgs = ((int)0x100F),
        /// <summary>
        /// Original was CL_DEVICE_MAX_MEM_ALLOC_SIZE = 0x1010
        /// </summary>
        DeviceMaxMemAllocSize = ((int)0x1010),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE2D_MAX_WIDTH = 0x1011
        /// </summary>
        DeviceImage2DMaxWidth = ((int)0x1011),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE2D_MAX_HEIGHT = 0x1012
        /// </summary>
        DeviceImage2DMaxHeight = ((int)0x1012),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE3D_MAX_WIDTH = 0x1013
        /// </summary>
        DeviceImage3DMaxWidth = ((int)0x1013),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE3D_MAX_HEIGHT = 0x1014
        /// </summary>
        DeviceImage3DMaxHeight = ((int)0x1014),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE3D_MAX_DEPTH = 0x1015
        /// </summary>
        DeviceImage3DMaxDepth = ((int)0x1015),
        /// <summary>
        /// Original was CL_DEVICE_IMAGE_SUPPORT = 0x1016
        /// </summary>
        DeviceImageSupport = ((int)0x1016),
        /// <summary>
        /// Original was CL_DEVICE_MAX_PARAMETER_SIZE = 0x1017
        /// </summary>
        DeviceMaxParameterSize = ((int)0x1017),
        /// <summary>
        /// Original was CL_DEVICE_MAX_SAMPLERS = 0x1018
        /// </summary>
        DeviceMaxSamplers = ((int)0x1018),
        /// <summary>
        /// Original was CL_DEVICE_MEM_BASE_ADDR_ALIGN = 0x1019
        /// </summary>
        DeviceMemBaseAddrAlign = ((int)0x1019),
        /// <summary>
        /// Original was CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE = 0x101A
        /// </summary>
        DeviceMinDataTypeAlignSize = ((int)0x101A),
        /// <summary>
        /// Original was CL_DEVICE_SINGLE_FP_CONFIG = 0x101B
        /// </summary>
        DeviceSingleFpConfig = ((int)0x101B),
        /// <summary>
        /// Original was CL_DEVICE_GLOBAL_MEM_CACHE_TYPE = 0x101C
        /// </summary>
        DeviceGlobalMemCacheType = ((int)0x101C),
        /// <summary>
        /// Original was CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE = 0x101D
        /// </summary>
        DeviceGlobalMemCachelineSize = ((int)0x101D),
        /// <summary>
        /// Original was CL_DEVICE_GLOBAL_MEM_CACHE_SIZE = 0x101E
        /// </summary>
        DeviceGlobalMemCacheSize = ((int)0x101E),
        /// <summary>
        /// Original was CL_DEVICE_GLOBAL_MEM_SIZE = 0x101F
        /// </summary>
        DeviceGlobalMemSize = ((int)0x101F),
        /// <summary>
        /// Original was CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE = 0x1020
        /// </summary>
        DeviceMaxConstantBufferSize = ((int)0x1020),
        /// <summary>
        /// Original was CL_DEVICE_MAX_CONSTANT_ARGS = 0x1021
        /// </summary>
        DeviceMaxConstantArgs = ((int)0x1021),
        /// <summary>
        /// Original was CL_DEVICE_LOCAL_MEM_TYPE = 0x1022
        /// </summary>
        DeviceLocalMemType = ((int)0x1022),
        /// <summary>
        /// Original was CL_DEVICE_LOCAL_MEM_SIZE = 0x1023
        /// </summary>
        DeviceLocalMemSize = ((int)0x1023),
        /// <summary>
        /// Original was CL_DEVICE_ERROR_CORRECTION_SUPPORT = 0x1024
        /// </summary>
        DeviceErrorCorrectionSupport = ((int)0x1024),
        /// <summary>
        /// Original was CL_DEVICE_PROFILING_TIMER_RESOLUTION = 0x1025
        /// </summary>
        DeviceProfilingTimerResolution = ((int)0x1025),
        /// <summary>
        /// Original was CL_DEVICE_ENDIAN_LITTLE = 0x1026
        /// </summary>
        DeviceEndianLittle = ((int)0x1026),
        /// <summary>
        /// Original was CL_DEVICE_AVAILABLE = 0x1027
        /// </summary>
        DeviceAvailable = ((int)0x1027),
        /// <summary>
        /// Original was CL_DEVICE_COMPILER_AVAILABLE = 0x1028
        /// </summary>
        DeviceCompilerAvailable = ((int)0x1028),
        /// <summary>
        /// Original was CL_DEVICE_EXECUTION_CAPABILITIES = 0x1029
        /// </summary>
        DeviceExecutionCapabilities = ((int)0x1029),
        /// <summary>
        /// Original was CL_DEVICE_QUEUE_PROPERTIES = 0x102A
        /// </summary>
        DeviceQueueProperties = ((int)0x102A),
        /// <summary>
        /// Original was CL_DEVICE_NAME = 0x102B
        /// </summary>
        DeviceName = ((int)0x102B),
        /// <summary>
        /// Original was CL_DEVICE_VENDOR = 0x102C
        /// </summary>
        DeviceVendor = ((int)0x102C),
        /// <summary>
        /// Original was CL_DRIVER_VERSION = 0x102D
        /// </summary>
        DriverVersion = ((int)0x102D),
        /// <summary>
        /// Original was CL_DEVICE_PROFILE = 0x102E
        /// </summary>
        DeviceProfile = ((int)0x102E),
        /// <summary>
        /// Original was CL_DEVICE_VERSION = 0x102F
        /// </summary>
        DeviceVersion = ((int)0x102F),
        /// <summary>
        /// Original was CL_DEVICE_EXTENSIONS = 0x1030
        /// </summary>
        DeviceExtensions = ((int)0x1030),
        /// <summary>
        /// Original was CL_DEVICE_PLATFORM = 0x1031
        /// </summary>
        DevicePlatform = ((int)0x1031),
        /// <summary>
        /// Original was CL_DEVICE_HOST_UNIFIED_MEMORY = 0x1035
        /// </summary>
        DeviceHostUnifiedMemory = ((int)0x1035),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR = 0x1036
        /// </summary>
        DeviceNativeVectorWidthChar = ((int)0x1036),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT = 0x1037
        /// </summary>
        DeviceNativeVectorWidthShort = ((int)0x1037),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_INT = 0x1038
        /// </summary>
        DeviceNativeVectorWidthInt = ((int)0x1038),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG = 0x1039
        /// </summary>
        DeviceNativeVectorWidthLong = ((int)0x1039),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT = 0x103A
        /// </summary>
        DeviceNativeVectorWidthFloat = ((int)0x103A),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE = 0x103B
        /// </summary>
        DeviceNativeVectorWidthDouble = ((int)0x103B),
        /// <summary>
        /// Original was CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF = 0x103C
        /// </summary>
        DeviceNativeVectorWidthHalf = ((int)0x103C),
        /// <summary>
        /// Original was CL_DEVICE_OPENCL_C_VERSION = 0x103D
        /// </summary>
        DeviceOpenclCVersion = ((int)0x103D),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DeviceLocalMemType : int
    {
        /// <summary>
        /// Original was CL_LOCAL = 0x1
        /// </summary>
        Local = ((int)0x1),
        /// <summary>
        /// Original was CL_GLOBAL = 0x2
        /// </summary>
        Global = ((int)0x2),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DeviceMemCacheType : int
    {
        /// <summary>
        /// Original was CL_NONE = 0x0
        /// </summary>
        None = ((int)0x0),
        /// <summary>
        /// Original was CL_READ_ONLY_CACHE = 0x1
        /// </summary>
        ReadOnlyCache = ((int)0x1),
        /// <summary>
        /// Original was CL_READ_WRITE_CACHE = 0x2
        /// </summary>
        ReadWriteCache = ((int)0x2),
    }

    /// <summary>
    /// Used in GL.CreateContextFromType, GL.GetDeviceIDs
    /// </summary>
    public enum DeviceTypeFlags : long
    {
        /// <summary>
        /// Original was CL_DEVICE_TYPE_DEFAULT = (1 &lt;&lt; 0)
        /// </summary>
        DeviceTypeDefault = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_DEVICE_TYPE_CPU = (1 &lt;&lt; 1)
        /// </summary>
        DeviceTypeCpu = ((int)(1 << 1)),
        /// <summary>
        /// Original was CL_DEVICE_TYPE_GPU = (1 &lt;&lt; 2)
        /// </summary>
        DeviceTypeGpu = ((int)(1 << 2)),
        /// <summary>
        /// Original was CL_DEVICE_TYPE_ACCELERATOR = (1 &lt;&lt; 3)
        /// </summary>
        DeviceTypeAccelerator = ((int)(1 << 3)),
        /// <summary>
        /// Original was CL_DEVICE_TYPE_ALL = 0xFFFFFFFF
        /// </summary>
        DeviceTypeAll = unchecked((int)0xFFFFFFFF),
    }

    /// <summary>
    /// Used in GL.CreateBuffer, GL.CreateCommandQueue and 5 other functions
    /// </summary>
    public enum ErrorCode : int
    {
        /// <summary>
        /// Original was CL_SUCCESS = 0
        /// </summary>
        Success = ((int)0),
        /// <summary>
        /// Original was CL_DEVICE_NOT_FOUND = -1
        /// </summary>
        DeviceNotFound = ((int)-1),
        /// <summary>
        /// Original was CL_IMAGE_FORMAT_NOT_SUPPORTED = -10
        /// </summary>
        ImageFormatNotSupported = ((int)-10),
        /// <summary>
        /// Original was CL_BUILD_PROGRAM_FAILURE = -11
        /// </summary>
        BuildProgramFailure = ((int)-11),
        /// <summary>
        /// Original was CL_MAP_FAILURE = -12
        /// </summary>
        MapFailure = ((int)-12),
        /// <summary>
        /// Original was CL_DEVICE_NOT_AVAILABLE = -2
        /// </summary>
        DeviceNotAvailable = ((int)-2),
        /// <summary>
        /// Original was CL_COMPILER_NOT_AVAILABLE = -3
        /// </summary>
        CompilerNotAvailable = ((int)-3),
        /// <summary>
        /// Original was CL_INVALID_VALUE = -30
        /// </summary>
        InvalidValue = ((int)-30),
        /// <summary>
        /// Original was CL_INVALID_DEVICE_TYPE = -31
        /// </summary>
        InvalidDeviceType = ((int)-31),
        /// <summary>
        /// Original was CL_INVALID_PLATFORM = -32
        /// </summary>
        InvalidPlatform = ((int)-32),
        /// <summary>
        /// Original was CL_INVALID_DEVICE = -33
        /// </summary>
        InvalidDevice = ((int)-33),
        /// <summary>
        /// Original was CL_INVALID_CONTEXT = -34
        /// </summary>
        InvalidContext = ((int)-34),
        /// <summary>
        /// Original was CL_INVALID_QUEUE_PROPERTIES = -35
        /// </summary>
        InvalidQueueProperties = ((int)-35),
        /// <summary>
        /// Original was CL_INVALID_COMMAND_QUEUE = -36
        /// </summary>
        InvalidCommandQueue = ((int)-36),
        /// <summary>
        /// Original was CL_INVALID_HOST_PTR = -37
        /// </summary>
        InvalidHostPtr = ((int)-37),
        /// <summary>
        /// Original was CL_INVALID_MEM_OBJECT = -38
        /// </summary>
        InvalidMemObject = ((int)-38),
        /// <summary>
        /// Original was CL_INVALID_IMAGE_FORMAT_DESCRIPTOR = -39
        /// </summary>
        InvalidImageFormatDescriptor = ((int)-39),
        /// <summary>
        /// Original was CL_MEM_OBJECT_ALLOCATION_FAILURE = -4
        /// </summary>
        MemObjectAllocationFailure = ((int)-4),
        /// <summary>
        /// Original was CL_INVALID_IMAGE_SIZE = -40
        /// </summary>
        InvalidImageSize = ((int)-40),
        /// <summary>
        /// Original was CL_INVALID_SAMPLER = -41
        /// </summary>
        InvalidSampler = ((int)-41),
        /// <summary>
        /// Original was CL_INVALID_BINARY = -42
        /// </summary>
        InvalidBinary = ((int)-42),
        /// <summary>
        /// Original was CL_INVALID_BUILD_OPTIONS = -43
        /// </summary>
        InvalidBuildOptions = ((int)-43),
        /// <summary>
        /// Original was CL_INVALID_PROGRAM = -44
        /// </summary>
        InvalidProgram = ((int)-44),
        /// <summary>
        /// Original was CL_INVALID_PROGRAM_EXECUTABLE = -45
        /// </summary>
        InvalidProgramExecutable = ((int)-45),
        /// <summary>
        /// Original was CL_INVALID_KERNEL_NAME = -46
        /// </summary>
        InvalidKernelName = ((int)-46),
        /// <summary>
        /// Original was CL_INVALID_KERNEL_DEFINITION = -47
        /// </summary>
        InvalidKernelDefinition = ((int)-47),
        /// <summary>
        /// Original was CL_INVALID_KERNEL = -48
        /// </summary>
        InvalidKernel = ((int)-48),
        /// <summary>
        /// Original was CL_INVALID_ARG_INDEX = -49
        /// </summary>
        InvalidArgIndex = ((int)-49),
        /// <summary>
        /// Original was CL_OUT_OF_RESOURCES = -5
        /// </summary>
        OutOfResources = ((int)-5),
        /// <summary>
        /// Original was CL_INVALID_ARG_VALUE = -50
        /// </summary>
        InvalidArgValue = ((int)-50),
        /// <summary>
        /// Original was CL_INVALID_ARG_SIZE = -51
        /// </summary>
        InvalidArgSize = ((int)-51),
        /// <summary>
        /// Original was CL_INVALID_KERNEL_ARGS = -52
        /// </summary>
        InvalidKernelArgs = ((int)-52),
        /// <summary>
        /// Original was CL_INVALID_WORK_DIMENSION = -53
        /// </summary>
        InvalidWorkDimension = ((int)-53),
        /// <summary>
        /// Original was CL_INVALID_WORK_GROUP_SIZE = -54
        /// </summary>
        InvalidWorkGroupSize = ((int)-54),
        /// <summary>
        /// Original was CL_INVALID_WORK_ITEM_SIZE = -55
        /// </summary>
        InvalidWorkItemSize = ((int)-55),
        /// <summary>
        /// Original was CL_INVALID_GLOBAL_OFFSET = -56
        /// </summary>
        InvalidGlobalOffset = ((int)-56),
        /// <summary>
        /// Original was CL_INVALID_EVENT_WAIT_LIST = -57
        /// </summary>
        InvalidEventWaitList = ((int)-57),
        /// <summary>
        /// Original was CL_INVALID_EVENT = -58
        /// </summary>
        InvalidEvent = ((int)-58),
        /// <summary>
        /// Original was CL_INVALID_OPERATION = -59
        /// </summary>
        InvalidOperation = ((int)-59),
        /// <summary>
        /// Original was CL_OUT_OF_HOST_MEMORY = -6
        /// </summary>
        OutOfHostMemory = ((int)-6),
        /// <summary>
        /// Original was CL_INVALID_GL_OBJECT = -60
        /// </summary>
        InvalidGlObject = ((int)-60),
        /// <summary>
        /// Original was CL_INVALID_BUFFER_SIZE = -61
        /// </summary>
        InvalidBufferSize = ((int)-61),
        /// <summary>
        /// Original was CL_INVALID_MIP_LEVEL = -62
        /// </summary>
        InvalidMipLevel = ((int)-62),
        /// <summary>
        /// Original was CL_PROFILING_INFO_NOT_AVAILABLE = -7
        /// </summary>
        ProfilingInfoNotAvailable = ((int)-7),
        /// <summary>
        /// Original was CL_MEM_COPY_OVERLAP = -8
        /// </summary>
        MemCopyOverlap = ((int)-8),
        /// <summary>
        /// Original was CL_IMAGE_FORMAT_MISMATCH = -9
        /// </summary>
        ImageFormatMismatch = ((int)-9),
    }

    /// <summary>
    /// Used in GL.GetEventInfo
    /// </summary>
    public enum EventInfo : int
    {
        /// <summary>
        /// Original was CL_EVENT_COMMAND_QUEUE = 0x11D0
        /// </summary>
        EventCommandQueue = ((int)0x11D0),
        /// <summary>
        /// Original was CL_EVENT_COMMAND_TYPE = 0x11D1
        /// </summary>
        EventCommandType = ((int)0x11D1),
        /// <summary>
        /// Original was CL_EVENT_REFERENCE_COUNT = 0x11D2
        /// </summary>
        EventReferenceCount = ((int)0x11D2),
        /// <summary>
        /// Original was CL_EVENT_COMMAND_EXECUTION_STATUS = 0x11D3
        /// </summary>
        EventCommandExecutionStatus = ((int)0x11D3),
    }

    /// <summary>
    /// Used in GL.CreateSampler
    /// </summary>
    public enum FilterMode : int
    {
        /// <summary>
        /// Original was CL_FILTER_NEAREST = 0x1140
        /// </summary>
        FilterNearest = ((int)0x1140),
        /// <summary>
        /// Original was CL_FILTER_LINEAR = 0x1141
        /// </summary>
        FilterLinear = ((int)0x1141),
    }

    /// <summary>
    /// Used in GL.GetImageInfo
    /// </summary>
    public enum ImageInfo : int
    {
        /// <summary>
        /// Original was CL_IMAGE_FORMAT = 0x1110
        /// </summary>
        ImageFormat = ((int)0x1110),
        /// <summary>
        /// Original was CL_IMAGE_ELEMENT_SIZE = 0x1111
        /// </summary>
        ImageElementSize = ((int)0x1111),
        /// <summary>
        /// Original was CL_IMAGE_ROW_PITCH = 0x1112
        /// </summary>
        ImageRowPitch = ((int)0x1112),
        /// <summary>
        /// Original was CL_IMAGE_SLICE_PITCH = 0x1113
        /// </summary>
        ImageSlicePitch = ((int)0x1113),
        /// <summary>
        /// Original was CL_IMAGE_WIDTH = 0x1114
        /// </summary>
        ImageWidth = ((int)0x1114),
        /// <summary>
        /// Original was CL_IMAGE_HEIGHT = 0x1115
        /// </summary>
        ImageHeight = ((int)0x1115),
        /// <summary>
        /// Original was CL_IMAGE_DEPTH = 0x1116
        /// </summary>
        ImageDepth = ((int)0x1116),
    }

    /// <summary>
    /// Used in GL.GetKernelInfo
    /// </summary>
    public enum KernelInfo : int
    {
        /// <summary>
        /// Original was CL_KERNEL_FUNCTION_NAME = 0x1190
        /// </summary>
        KernelFunctionName = ((int)0x1190),
        /// <summary>
        /// Original was CL_KERNEL_NUM_ARGS = 0x1191
        /// </summary>
        KernelNumArgs = ((int)0x1191),
        /// <summary>
        /// Original was CL_KERNEL_REFERENCE_COUNT = 0x1192
        /// </summary>
        KernelReferenceCount = ((int)0x1192),
        /// <summary>
        /// Original was CL_KERNEL_CONTEXT = 0x1193
        /// </summary>
        KernelContext = ((int)0x1193),
        /// <summary>
        /// Original was CL_KERNEL_PROGRAM = 0x1194
        /// </summary>
        KernelProgram = ((int)0x1194),
    }

    /// <summary>
    /// Used in GL.GetKernelWorkGroupInfo
    /// </summary>
    public enum KernelWorkGroupInfo : int
    {
        /// <summary>
        /// Original was CL_KERNEL_WORK_GROUP_SIZE = 0x11B0
        /// </summary>
        KernelWorkGroupSize = ((int)0x11B0),
        /// <summary>
        /// Original was CL_KERNEL_COMPILE_WORK_GROUP_SIZE = 0x11B1
        /// </summary>
        KernelCompileWorkGroupSize = ((int)0x11B1),
        /// <summary>
        /// Original was CL_KERNEL_LOCAL_MEM_SIZE = 0x11B2
        /// </summary>
        KernelLocalMemSize = ((int)0x11B2),
        /// <summary>
        /// Original was CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE = 0x11B3
        /// </summary>
        KernelPreferredWorkGroupSizeMultiple = ((int)0x11B3),
    }

    /// <summary>
    /// Used in GL.EnqueueMapBuffer, GL.EnqueueMapImage
    /// </summary>
    public enum MapFlags : long
    {
        /// <summary>
        /// Original was CL_MAP_READ = (1 &lt;&lt; 0)
        /// </summary>
        MapRead = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_MAP_WRITE = (1 &lt;&lt; 1)
        /// </summary>
        MapWrite = ((int)(1 << 1)),
    }

    /// <summary>
    /// Used in GL.CreateBuffer, GL.CreateImage2D and 3 other functions
    /// </summary>
    public enum MemFlags : long
    {
        /// <summary>
        /// Original was CL_MEM_READ_WRITE = (1 &lt;&lt; 0)
        /// </summary>
        MemReadWrite = ((int)(1 << 0)),
        /// <summary>
        /// Original was CL_MEM_WRITE_ONLY = (1 &lt;&lt; 1)
        /// </summary>
        MemWriteOnly = ((int)(1 << 1)),
        /// <summary>
        /// Original was CL_MEM_READ_ONLY = (1 &lt;&lt; 2)
        /// </summary>
        MemReadOnly = ((int)(1 << 2)),
        /// <summary>
        /// Original was CL_MEM_USE_HOST_PTR = (1 &lt;&lt; 3)
        /// </summary>
        MemUseHostPtr = ((int)(1 << 3)),
        /// <summary>
        /// Original was CL_MEM_ALLOC_HOST_PTR = (1 &lt;&lt; 4)
        /// </summary>
        MemAllocHostPtr = ((int)(1 << 4)),
        /// <summary>
        /// Original was CL_MEM_COPY_HOST_PTR = (1 &lt;&lt; 5)
        /// </summary>
        MemCopyHostPtr = ((int)(1 << 5)),
    }

    /// <summary>
    /// Used in GL.GetMemObjectInfo
    /// </summary>
    public enum MemInfo : int
    {
        /// <summary>
        /// Original was CL_MEM_TYPE = 0x1100
        /// </summary>
        MemType = ((int)0x1100),
        /// <summary>
        /// Original was CL_MEM_FLAGS = 0x1101
        /// </summary>
        MemFlags = ((int)0x1101),
        /// <summary>
        /// Original was CL_MEM_SIZE = 0x1102
        /// </summary>
        MemSize = ((int)0x1102),
        /// <summary>
        /// Original was CL_MEM_HOST_PTR = 0x1103
        /// </summary>
        MemHostPtr = ((int)0x1103),
        /// <summary>
        /// Original was CL_MEM_MAP_COUNT = 0x1104
        /// </summary>
        MemMapCount = ((int)0x1104),
        /// <summary>
        /// Original was CL_MEM_REFERENCE_COUNT = 0x1105
        /// </summary>
        MemReferenceCount = ((int)0x1105),
        /// <summary>
        /// Original was CL_MEM_CONTEXT = 0x1106
        /// </summary>
        MemContext = ((int)0x1106),
    }

    /// <summary>
    /// Used in GL.GetSupportedImageFormats
    /// </summary>
    public enum MemObjectType : int
    {
        /// <summary>
        /// Original was CL_MEM_OBJECT_BUFFER = 0x10F0
        /// </summary>
        MemObjectBuffer = ((int)0x10F0),
        /// <summary>
        /// Original was CL_MEM_OBJECT_IMAGE2D = 0x10F1
        /// </summary>
        MemObjectImage2D = ((int)0x10F1),
        /// <summary>
        /// Original was CL_MEM_OBJECT_IMAGE3D = 0x10F2
        /// </summary>
        MemObjectImage3D = ((int)0x10F2),
    }

    /// <summary>
    /// Used in GL.GetPlatformInfo
    /// </summary>
    public enum PlatformInfo : int
    {
        /// <summary>
        /// Original was CL_PLATFORM_PROFILE = 0x0900
        /// </summary>
        PlatformProfile = ((int)0x0900),
        /// <summary>
        /// Original was CL_PLATFORM_VERSION = 0x0901
        /// </summary>
        PlatformVersion = ((int)0x0901),
        /// <summary>
        /// Original was CL_PLATFORM_NAME = 0x0902
        /// </summary>
        PlatformName = ((int)0x0902),
        /// <summary>
        /// Original was CL_PLATFORM_VENDOR = 0x0903
        /// </summary>
        PlatformVendor = ((int)0x0903),
        /// <summary>
        /// Original was CL_PLATFORM_EXTENSIONS = 0x0904
        /// </summary>
        PlatformExtensions = ((int)0x0904),
    }

    /// <summary>
    /// Used in GL.GetEventProfilingInfo
    /// </summary>
    public enum ProfilingInfo : int
    {
        /// <summary>
        /// Original was CL_PROFILING_COMMAND_QUEUED = 0x1280
        /// </summary>
        ProfilingCommandQueued = ((int)0x1280),
        /// <summary>
        /// Original was CL_PROFILING_COMMAND_SUBMIT = 0x1281
        /// </summary>
        ProfilingCommandSubmit = ((int)0x1281),
        /// <summary>
        /// Original was CL_PROFILING_COMMAND_START = 0x1282
        /// </summary>
        ProfilingCommandStart = ((int)0x1282),
        /// <summary>
        /// Original was CL_PROFILING_COMMAND_END = 0x1283
        /// </summary>
        ProfilingCommandEnd = ((int)0x1283),
    }

    /// <summary>
    /// Used in GL.GetProgramBuildInfo
    /// </summary>
    public enum ProgramBuildInfo : int
    {
        /// <summary>
        /// Original was CL_PROGRAM_BUILD_STATUS = 0x1181
        /// </summary>
        ProgramBuildStatus = ((int)0x1181),
        /// <summary>
        /// Original was CL_PROGRAM_BUILD_OPTIONS = 0x1182
        /// </summary>
        ProgramBuildOptions = ((int)0x1182),
        /// <summary>
        /// Original was CL_PROGRAM_BUILD_LOG = 0x1183
        /// </summary>
        ProgramBuildLog = ((int)0x1183),
    }

    /// <summary>
    /// Used in GL.GetProgramInfo
    /// </summary>
    public enum ProgramInfo : int
    {
        /// <summary>
        /// Original was CL_PROGRAM_REFERENCE_COUNT = 0x1160
        /// </summary>
        ProgramReferenceCount = ((int)0x1160),
        /// <summary>
        /// Original was CL_PROGRAM_CONTEXT = 0x1161
        /// </summary>
        ProgramContext = ((int)0x1161),
        /// <summary>
        /// Original was CL_PROGRAM_NUM_DEVICES = 0x1162
        /// </summary>
        ProgramNumDevices = ((int)0x1162),
        /// <summary>
        /// Original was CL_PROGRAM_DEVICES = 0x1163
        /// </summary>
        ProgramDevices = ((int)0x1163),
        /// <summary>
        /// Original was CL_PROGRAM_SOURCE = 0x1164
        /// </summary>
        ProgramSource = ((int)0x1164),
        /// <summary>
        /// Original was CL_PROGRAM_BINARY_SIZES = 0x1165
        /// </summary>
        ProgramBinarySizes = ((int)0x1165),
        /// <summary>
        /// Original was CL_PROGRAM_BINARIES = 0x1166
        /// </summary>
        ProgramBinaries = ((int)0x1166),
    }

    /// <summary>
    /// Used in GL.GetSamplerInfo
    /// </summary>
    public enum SamplerInfo : int
    {
        /// <summary>
        /// Original was CL_SAMPLER_REFERENCE_COUNT = 0x1150
        /// </summary>
        SamplerReferenceCount = ((int)0x1150),
        /// <summary>
        /// Original was CL_SAMPLER_CONTEXT = 0x1151
        /// </summary>
        SamplerContext = ((int)0x1151),
        /// <summary>
        /// Original was CL_SAMPLER_NORMALIZED_COORDS = 0x1152
        /// </summary>
        SamplerNormalizedCoords = ((int)0x1152),
        /// <summary>
        /// Original was CL_SAMPLER_ADDRESSING_MODE = 0x1153
        /// </summary>
        SamplerAddressingMode = ((int)0x1153),
        /// <summary>
        /// Original was CL_SAMPLER_FILTER_MODE = 0x1154
        /// </summary>
        SamplerFilterMode = ((int)0x1154),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version : int
    {
        /// <summary>
        /// Original was CL_VERSION_1_0 = 1
        /// </summary>
        Version10 = ((int)1),
    }

}
