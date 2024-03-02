using System;
using System.Runtime.InteropServices;
using static System.Net.WebRequestMethods;

namespace OpenTK.Compute.OpenCL
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    #region Context

    /// <summary>
    /// <para>
    ///     The supported properties for creating a context using
    ///     <c><see cref="CL.CreateContext(IntPtr[], CLDevice[], IntPtr, IntPtr, out CLResultCode)">CreateContext()</see></c>, or
    ///     <c><see cref="CL.CreateContextFromType(IntPtr, DeviceType, IntPtr, IntPtr, out CLResultCode)">CreateContextFromType()</see></c>.
    /// </para>
    /// <para>
    ///     For more info look at the original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#context-properties-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum ContextProperties : int
    {
        /// <summary>
        /// <para>
        ///     Specifies the platform to use.
        /// </para>
        /// <para>
        ///     <i><u>Property Value:</u></i> <c><see cref="CLProgram">CLProgram</see></c>
        /// </para>
        /// </summary>
        ContextPlatform = 0x1084,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing byefore verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Specifies whether the user is responsible for synchronization between
        ///     OpenCL and other APIs. Please refer to the specific sections in the OpenCL
        ///     Extension Specification that describe sharing with other APIs for restrictions
        ///     on using this flag.
        /// </para>
        /// <para>
        ///     If <c><see cref="InteropUserSync">InteropUserSync</see></c> is not specified,
        ///     a default of FALSE is assumed.
        /// </para>
        /// <para>
        ///     <i><u>Property Value:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        InteropUserSync = 0x1085,

        // Extension Values

        GlContextKHR = 0x2008,
        EglDisplayKHR = 0x2009,
        GlxDisplayKHR = 0x200A,
        WglHDCKHR = 0x200B,
        CglShareGroupKHR = 0x200C,

        D3D10DeviceKHR = 0x4014,

        AdapterD3D9KHR = 0x2025,
        AdapterD3D9EXKHR = 0x2026,
        AdapterDXVAKHR = 0x2027,

        D3D11DeviceKHR = 0x401D,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c>cl_khr_initialize_memory</c> extension</pre></i>
        /// </para>
        /// <para>
        ///     Describes which memory types for the context must be initialized.
        /// </para>
        /// <para>
        ///     If the context is created with <c><see cref="MemoryInitializeKHR">MemoryInitializeKHR</see></c>,
        ///     appropriate memory locations as specified by the bit-field is initialized with zeroes,
        ///     prior to the start of execution of any kernel.
        ///     The driver chooses when, prior to kernel execution,
        ///     the initialization of local and/or private memory is performed.
        ///     The only requirement is there should be no values set from outside the context,
        ///     which can be read during a kernel execution.
        /// </para>
        /// <para>
        ///     <i><u>Property Value:</u></i> <c><see cref="ContextMemoryInitializeKHR">ContextMemoryInitializeKHR</see></c>
        /// </para>
        /// </summary>
        MemoryInitializeKHR = 0x2030,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c>cl_khr_terminate_context</c> extension</pre></i>
        /// </para>
        /// <para>
        ///     Specifies whether the context can be terminated. The default value is FALSE.
        /// </para>
        /// <para>
        ///     Can be specified in the context properties only if all devices associated with
        ///     the context support the ability to support context termination
        ///     (i.e. CL_DEVICE_TERMINATE_CAPABILITY_CONTEXT_KHR is set for CL_DEVICE_TERMINATE_CAPABILITY_KHR).
        ///     Otherwise, context creation fails with error code of CL_INVALID_PROPERTY.
        /// </para>
        /// <para>
        ///     <i><u>Property Value:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        TerminateKHR = 0x2032,
    }

    /// <summary>
    /// <para>
    ///     The list of supported values and the information returned by
    ///     <c><see cref="CL.GetContextInfo(CLContext, ContextInfo, out byte[])">GetContextInfo()</see></c>.
    /// </para>
    /// <para>
    ///     Original documentation <see href="https://registry.khronos.org/OpenCL/sdk/3.0/docs/man/html/clGetContextInfo.html">here</see>.
    /// </para>
    /// </summary>
    public enum ContextInfo : uint
    {
        /// <summary>
        /// <para>
        ///      Return the <c>context</c> reference count.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ReferenceCount = 0x1080,

        /// <summary>
        /// <para>
        ///      Return the <c>context</c> reference count.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLDevice">CLDevice[]</see></c>
        /// </para>
        /// </summary>
        Devices = 0x1081,

        /// <summary>
        /// <para>
        ///     Return the properties argument specified in
        ///     <c><see cref="CL.CreateContext(IntPtr, CLDevice[], IntPtr, IntPtr, out CLResultCode)">CreateContext()</see></c>
        ///     or <c><see cref="CL.CreateContextFromType(IntPtr, DeviceType, IntPtr, IntPtr, out CLResultCode)">CreateContextFromType()</see></c>.
        /// </para>
        /// <para>
        ///     If the <c>properties</c> argument specified in
        ///     <c><see cref="CL.CreateContext(IntPtr, CLDevice[], IntPtr, IntPtr, out CLResultCode)">CreateContext()</see></c>
        ///     or <c><see cref="CL.CreateContextFromType(IntPtr, DeviceType, IntPtr, IntPtr, out CLResultCode)">CreateContextFromType()</see></c>
        ///     used to create context was not NULL,
        ///     the implementation must return the values specified in the properties argument in the same order
        ///     and without including additional properties.
        /// </para>
        /// <para>
        ///     If the <c>properties</c> argument specified in
        ///     <c><see cref="CL.CreateContext(IntPtr, CLDevice[], IntPtr, IntPtr, out CLResultCode)">CreateContext()</see></c>
        ///     or <c><see cref="CL.CreateContextFromType(IntPtr, DeviceType, IntPtr, IntPtr, out CLResultCode)">CreateContextFromType()</see></c>
        ///     used to create context was NULL,
        ///     the implementation must return <c>param_value_size_ret</c> equal to 0,
        ///     indicating that there are no properties to be returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="ContextProperties">ContextProperties[]</see></c>
        /// </para>
        /// </summary>
        Properties = 0x1082,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before version ~1.1.</pre></i>
        /// </para>
        /// <para>
        ///      Return the number of devices in <c>context</c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        NumberOfDevices = 0x1083
    }

    /// <summary>
    /// <para>
    ///     <i><pre>Requires the <c>cl_khr_initialize_memory</c> extension</pre></i>
    /// </para>
    /// <para>
    ///     A Bitfield that describes which memory types for the context must be initialized.
    /// </para>
    /// </summary>
    [Flags]
    public enum ContextMemoryInitializeKHR : uint
    {
        /// <summary>
        /// <para>
        ///     Initialize local memory to zeros.
        /// </para>
        /// </summary>
        LocalKHR = 1 << 0,

        /// <summary>
        /// <para>
        ///     Initialize private memory to zeros.
        /// </para>
        /// </summary>
        PrivateKHR = 1 << 1
    }

    #endregion

    #region Platform

    /// <summary>
    /// <para>
    ///     The information that can be queried using
    ///     <c><see cref="CL.GetPlatformInfo(CLPlatform, PlatformInfo, out byte[])">GetPlatformInfo()</see></c>.
    /// </para>
    /// <para>
    ///     Original documentation <see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#platform-queries-table">here</see>.
    /// </para>
    /// </summary>
    public enum PlatformInfo : uint
    {
        /// <summary>
        /// <para>
        ///     OpenCL profile string. Returns the profile name supported by the implementation.
        ///     The profile name returned can be one of the following strings:
        /// </para>
        /// <list type="bullet">
        /// <item>
        /// <description>
        ///     <b>FULL_PROFILE</b> - if the implementation supports the OpenCL specification
        ///     (functionality defined as part of the core specification
        ///     and does not require any extensions to be supported).
        /// </description></item>
        ///
        /// <item>
        /// <description>
        ///     <b>EMBEDDED_PROFILE</b> - if the implementation supports the OpenCL embedded profile.
        ///     The embedded profile for OpenCL is described in:
        ///     https://www.khronos.org/registry/OpenCL/specs/3.0-unified/html/OpenCL_API.html#opencl-embedded-profile.
        /// </description></item>
        /// </list>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Profile = 0x0900,

        /// <summary>
        /// <para>
        ///     OpenCL version string. Returns the OpenCL version supported by the implementation.
        ///     This version string has the following format:
        /// </para>
        /// <para>
        ///     <c><pre>OpenCL&lt;space&gt;&lt;major_version.minor_version&gt;&lt;space&gt;&lt;platform-specific information&gt;</pre></c>
        /// </para>
        /// <para>
        ///     The major_version.minor_version value returned will be one of 1.0, 1.1, 1.2, 2.0, 2.1, 2.2 or 3.0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Version = 0x0901,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the detailed (major, minor, patch) version supported by the platform.
        ///     The major and minor version numbers returned must match those returned via
        ///     <c><see cref="Version">Version</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLVersion">CLVersion</see></c>
        /// </para>
        /// </summary>
        NumericVersion = 0x0906,

        /// <summary>
        /// <para>
        ///     Platform name string.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Name = 0x0902,

        /// <summary>
        /// <para>
        ///     Platform vendor string.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Vendor = 0x0903,

        /// <summary>
        /// <para>
        ///     Returns a space separated list of extension names (the extension names themselves do not contain any spaces)~
        ///     supported by the platform. Each extension that is supported by all devices associated with this
        ///     platform must be reported here.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        /// <remarks>Return Type: string</remarks>
        Extensions = 0x0904,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLNameVersion">CLNameVersion</see></c>
        /// </para>
        /// </summary>
        ExtensionsWithVersion = 0x0907,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.1.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the resolution of the host timer in nanoseconds as used by
        ///     <c><see cref="CL.GetHostTimer(CLDevice, IntPtr)">GetHostTimer()</see></c>.
        ///     This value must be 0 for devices that do not support device and host timer synchronization.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>ulong</c>
        /// </para>
        /// </summary>
        PlatformHostTimerResolution = 0x0905,
    }

    #endregion

    #region Device

    /// <summary>
    ///     The valid types of OpenCL devices.
    /// <para>
    ///     The device type is purely informational and has no semantic meaning.
    /// </para>
    /// <para>
    ///     Some devices may be more than one type. For example,
    ///     a <c><see cref="Cpu">CPU</see></c> device may also be a
    ///     <c><see cref="Gpu">GPU</see></c> device,
    ///     or a <c><see cref="Accelerator">Accelerator</see></c>
    ///     device may also be some other, more descriptive device type.
    ///     <c><see cref="Custom">Custom</see></c> devices must not be combined with any other device types.
    /// </para>
    /// <para>
    ///     One device in the platform should be a <c><see cref="Default">Default</see></c> device.
    ///     The default device should also be a more specific device type,
    ///     such as <c><see cref="Cpu">CPU</see></c> or <c><see cref="Gpu">GPU</see></c>.
    /// </para>
    /// </summary>
    [Flags]
    public enum DeviceType : ulong
    {
        /// <summary>
        ///     The default OpenCL device in the platform. The default OpenCL device must not be a
        ///     <c><see cref="Custom">Custom</see></c> device.
        /// </summary>
        Default = 1 << 0,

        /// <summary>
        ///     An OpenCL device similar to a traditional CPU (Central Processing Unit).
        ///     The host processor that executes OpenCL host code may also be considered a CPU OpenCL device.
        /// </summary>
        Cpu = 1 << 1,

        /// <summary>
        ///     An OpenCL device similar to a GPU (Graphics Processing Unit).
        ///     Many systems include a dedicated processor for graphics or
        ///     rendering that may be considered a GPU OpenCL device.
        /// </summary>
        Gpu = 1 << 2,

        /// <summary>
        ///     Dedicated devices that may accelerate OpenCL programs,
        ///     such as FPGAs (Field Programmable Gate Arrays),
        ///     DSPs (Digital Signal Processors), or AI (Artificial Intelligence) processors.
        /// </summary>
        Accelerator = 1 << 3,

        /// <summary>
        ///     Specialized devices that implement some of the OpenCL runtime
        ///     APIs but do not support all required OpenCL functionality.
        ///     </summary>
        /// <remarks>Only available after OpenCL 1.2</remarks>
        Custom = 1 << 4,

        /// <summary>
        ///     All OpenCL devices available in the platform,
        ///     except for <c><see cref="Custom">Custom</see></c> devices.
        /// </summary>
        All = 0xFFFFFFFF
    }

    /// <summary>
    /// <para>
    ///     The information that can be queried using
    ///     <c><see cref="CL.GetDeviceInfo(CLDevice, DeviceInfo, out byte[])">GetDeviceInfo()</see></c>.
    /// </para>
    /// <para>
    ///     For more info look at the original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#device-queries-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum DeviceInfo : ulong
    {
        /// <summary>
        /// <para>
        ///     The type or types of the OpenCL device. Please see <c><see cref="DeviceType">DeviceType</see></c>
        ///     for supported device types and device type combinations.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceType">DeviceType</see></c>
        /// </para>
        /// </summary>
        Type = 0x1000,

        /// <summary>
        /// <para>
        ///     A unique device vendor identifier.
        /// </para>
        /// <para>
        ///     If the vendor has a PCI vendor ID, the low 16 bits must contain that PCI vendor ID,
        ///     and the remaining bits must be set to zero. Otherwise, the value returned must be a
        ///     valid Khronos vendor ID represented by type <c>cl_khronos_vendor_id</c>.
        ///     Khronos vendor IDs are allocated starting at 0x10000, to distinguish them from the PCI vendor ID namespace.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        VendorId = 0x1001,

        /// <summary>
        /// <para>
        ///     The number of parallel compute units on the OpenCL device.
        ///     A work-group executes on a single compute unit. The minimum value is 1.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumComputeUnits = 0x1002,

        /// <summary>
        /// <para>
        ///     Maximum dimensions that specify the global and local work-item IDs used by the data parallel execution model.
        ///     (Refer to
        ///     <c><see cref="CL.EnqueueNDRangeKernel(CLCommandQueue,
        ///     CLKernel, uint, UIntPtr[], UIntPtr[], UIntPtr[], uint,
        ///     CLEvent[], out CLEvent)">EnqueueNDRangeKernel()</see></c>).
        ///     The minimum value is 3 for devices that are not of type
        ///     <c><see cref="DeviceType.Custom">DeviceType.Custom</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        MaximumWorkItemDimensions = 0x1003,

        /// <summary>
        /// <para>
        ///     Maximum number of work-items that can be specified in each dimension of the work-group to
        ///     <c><see cref="CL.EnqueueNDRangeKernel(CLCommandQueue,
        ///     CLKernel, uint, UIntPtr[], UIntPtr[], UIntPtr[], uint,
        ///     CLEvent[], out CLEvent)">EnqueueNDRangeKernel()</see></c>.
        ///     Returns n <c>UIntPtr</c> entries, where n is the value returned by the query for
        ///     <c><see cref="MaximumWorkItemDimensions">MaximumWorkItemDimensions</see></c>.
        ///     The minimum value is (1, 1, 1) for devices that are not of type
        ///     <c><see cref="DeviceType.Custom">Custom</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        MaximumWorkItemSizes = 0x1005,

        /// <summary>
        /// <para>
        ///     Maximum number of work-items in a work-group that a device is capable
        ///     of executing on a single compute unit, for any given kernel-instance running on the device.
        ///     (Refer to <c><see cref="CL.EnqueueNDRangeKernel(CLCommandQueue,
        ///     CLKernel, uint, UIntPtr[], UIntPtr[], UIntPtr[], uint,
        ///     CLEvent[], out CLEvent)">EnqueueNDRangeKernel()</see></c> and
        ///     <c><see cref="KernelWorkGroupInfo.WorkGroupSize">WorkGroupSize</see></c>).
        ///     The minimum value is 1.
        /// </para>
        /// <para>
        ///     The returned value is an upper limit and will not necessarily maximize performance.
        ///     This maximum may be larger than supported by a specific kernel
        ///     (refer to the <c><see cref="KernelWorkGroupInfo.WorkGroupSize">WorkGroupSize</see></c>
        ///     query of <c><see cref="CL.GetKernelWorkGroupInfo(CLKernel, CLDevice,
        ///     KernelWorkGroupInfo, UIntPtr, byte[], out UIntPtr)">GetKernelWorkGroupInfo()</see></c>).
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        MaximumWorkGroupSize = 0x1004,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before version 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     Preferred native vector width size for built-in scalar types that can be put into vectors.
        /// </para>
        /// <para>
        ///     The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        PreferredVectorWidthChar = 0x1006,

        /// <inheritdoc cref="PreferredVectorWidthChar"/>
        PreferredVectorWidthShort = 0x1007,

        /// <inheritdoc cref="PreferredVectorWidthChar"/>
        PreferredVectorWidthInt = 0x1008,

        /// <inheritdoc cref="PreferredVectorWidthChar"/>
        PreferredVectorWidthLong = 0x1009,

        /// <inheritdoc cref="PreferredVectorWidthChar"/>
        PreferredVectorWidthFloat = 0x100A,

        /// <summary>
        /// <para>
        ///     Preferred native vector width size for built-in scalar types that can be put into vectors.
        /// </para>
        /// <para>
        ///     The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// </para>
        /// <para>
        ///     If double precision is not supported, must return 0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        PreferredVectorWidthDouble = 0x100B,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing byefore verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     Preferred native vector width size for built-in scalar types that can be put into vectors.
        /// </para>
        /// <para>
        ///     The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// </para>
        /// <para>
        ///     If the <c>cl_khr_fp16</c> extension is not supported, must return 0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        PreferredVectorWidthHalf = 0x1034,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the native ISA vector width.
        ///     The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        NativeVectorWidthChar = 0x1036,

        /// <inheritdoc cref="NativeVectorWidthChar"/>
        NativeVectorWidthShort = 0x1037,

        /// <inheritdoc cref="PreferredVectorWidthChar"/>
        NativeVectorWidthInt = 0x1038,

        /// <inheritdoc cref="PreferredVectorWidthChar"/>
        NativeVectorWidthLong = 0x1039,

        /// <inheritdoc cref="PreferredVectorWidthChar"/>
        NativeVectorWidthFloat = 0x103A,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the native ISA vector width.
        ///     The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// </para>
        /// <para>
        ///     If double precision is not supported, must return 0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        NativeVectorWidthDouble = 0x103B,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the native ISA vector width.
        ///     The vector width is defined as the number of scalar elements that can be stored in the vector.
        /// </para>
        /// <para>
        ///     If the <c>cl_khr_fp16</c> extension is not supported, must return 0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        NativeVectorWidthHalf = 0x103C,

        /// <summary>
        /// <list type="bullet">
        /// <item>
        ///     <term><b>Before OpenCL 2.2: </b></term>
        ///     <description>Maximum configured clock frequency of the device in MHz.</description>
        /// </item>
        ///
        /// <item>
        ///     <term><b>After OpenCL 2.2: </b></term>
        ///     <description>Clock frequency of the device in MHz.
        ///     The meaning of this value is implementation-defined.
        ///     For devices with multiple clock domains,
        ///     the clock frequency for any of the clock domains may be returned.
        ///     For devices that dynamically change frequency for power or thermal reasons,
        ///     the returned clock frequency may be any valid frequency.</description>
        /// </item>
        /// </list>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumClockFrequency = 0x100C,

        /// <summary>
        /// <para>
        ///     The default compute device address space size of the global
        ///     address space specified as an unsigned integer value in bits.
        ///     Currently supported values are 32 or 64 bits.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        AddressBits = 0x100D,

        /// <summary>
        /// <para>
        ///     Max size of memory object allocation in bytes.
        ///     The minimum value is:
        /// </para>
        /// <para>
        /// <pre>max(min(1024 × 1024 × 1024, 1/4th of <see cref="GlobalMemorySize">DeviceInfo.GlobalMemorySize</see>), 32 × 1024 × 1024)</pre>
        /// </para>
        /// <para>
        ///     for devices that are not of type <c><see cref="DeviceType.Custom">DeviceType.Custom</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>ulong</c>
        /// </para>
        /// </summary>
        MaximumMemoryAllocationSize = 0x1010,

        /// <summary>
        /// <para>
        ///     Is TRUE if images are supported by the OpenCL device and FALSE otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        ImageSupport = 0x1016,

        /// <summary>
        /// <para>
        ///     Max number of image objects arguments of a kernel
        ///     declared with the read_only qualifier.
        ///     The minimum value is 128 if <c><see cref="ImageSupport">ImageSupport</see></c> is TRUE, the value is 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumReadImageArguments = 0x100E,

        /// <summary>
        /// <para>
        ///     Max number of image objects arguments of a kernel
        ///     declared with the write_only qualifier.
        ///     The minimum value is 64 if <c><see cref="ImageSupport">ImageSupport</see></c> is TRUE, the value is 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumWriteImageArguments = 0x100F,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Max number of image objects arguments of a kernel
        ///     declared with the <c>write_only</c> or <c>read_write</c> qualifier.
        /// </para>
        /// <para>
        ///     The minimum value is 64 if the device supports read-write images arguments,
        ///     and must be 0 for devices that do not support read-write images.
        /// </para>
        /// <para>
        ///     Support for read-write image arguments is required for
        ///     an OpenCL 2.0, 2.1, or 2.2 device if <c><see cref="ImageSupport">ImageSupport</see></c> is TRUE.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumReadWriteImageArguments = 0x104C,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.1.</pre></i>
        /// </para>
        /// <para>
        ///     The intermediate languages that can be supported by
        ///     <c><see cref="CL.CreateProgramWithIL(CLContext, IntPtr, UIntPtr, out CLResultCode)">CreateProgramWithIL()</see></c>
        ///     for this device. Returns a space-separated list of IL version strings of the form
        ///     <c>&lt;IL_Prefix&gt;_&lt;Major_Version&gt;.&lt;Minor_Version&gt;</c>.
        /// </para>
        /// <para>
        ///      For an OpenCL 2.1 or 2.2 device, SPIR-V is a required IL prefix.
        ///      If the device does not support intermediate language programs, the value must be "" (an empty string).
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        IntermediateLanguageVersion = 0x105B,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns an array of descriptions (name and version)
        ///     for all supported intermediate languages.
        ///     Intermediate languages with the same name may
        ///     be reported more than once but each name and major/minor
        ///     version combination may only be reported once.
        ///     The list of intermediate languages reported must match
        ///     the list reported via <c><see cref="IntermediateLanguageVersion">IntermediateLanguageVersion</see></c>.
        /// </para>
        /// <para>
        ///      For an OpenCL 2.1 or 2.2 device, at least one version of SPIR-V must be reported.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>cl_name_version[]</c>
        /// </para>
        /// </summary>
        IntermediateLanguagesWithVersion = 0x1061,

        /// <summary>
        /// <para>
        ///     Max width of 2D image or 1D image not created from a buffer object in pixels.
        ///     The minimum value is 16384 if <c><see cref="ImageSupport">ImageSupport</see></c> is TRUE,
        ///     the value is 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        Image2DMaximumWidth = 0x1011,

        /// <summary>
        /// <para>
        ///     Max height of 2D image in pixels.
        ///     The minimum value is 16384 if <c><see cref="ImageSupport">ImageSupport</see></c> is TRUE,
        ///     the value is 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        Image2DMaximumHeight = 0x1012,

        /// <summary>
        /// <para>
        ///     Max width of 3D image in pixels.
        ///     The minimum value is 2048 if <c><see cref="ImageSupport">ImageSupport</see></c> is TRUE,
        ///     the value is 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        Image3DMaximumWidth = 0x1013,

        /// <summary>
        /// <para>
        ///     Max height of 3D image in pixels.
        ///     The minimum value is 2048 if <c><see cref="ImageSupport">ImageSupport</see></c> is TRUE,
        ///     the value is 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        Image3DMaximumHeight = 0x1014,

        /// <summary>
        /// <para>
        ///     Max depth of 3D image in pixels.
        ///     The minimum value is 2048 if <c><see cref="ImageSupport">ImageSupport</see></c> is TRUE,
        ///     the value is 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        Image3DMaximumDepth = 0x1015,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Max number of pixels for a 1D image created from a buffer object.
        ///     The minimum value is 65536 if <c><see cref="ImageSupport">ImageSupport</see></c>
        ///     is TRUE, the value is 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        ImageMaximumBufferSize = 0x1040,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Max number of images in a 1D or 2D image array.
        ///     The minimum value is 2048 <c><see cref="ImageSupport">ImageSupport</see></c>
        ///     is TRUE, the value is 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        ImageMaximumArraySize = 0x1041,

        /// <summary>
        /// <para>
        ///     Maximum number of samplers that can be used in a kernel.
        ///     The minimum value is 16 if <c><see cref="ImageSupport">ImageSupport</see></c>
        ///     is TRUE, the value is 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumSamplers = 0x1018,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     The row pitch alignment size in pixels for 2D images
        ///     created from a buffer. The value returned must be a power of 2.
        /// </para>
        /// <para>
        ///     Support for 2D images created from a buffer is required
        ///     for an OpenCL 2.0, 2.1, or 2.2 device if <c><see cref="ImageSupport">ImageSupport</see></c>
        ///     is TRUE.
        /// </para>
        /// <para>
        ///     This value must be 0 for devices that do not support 2D images created from a buffer.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ImagePitchAlignment = 0x104A,

        /// #TODO: CreateBufferWithProperties() isnt implemented
        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     This query specifies the minimum alignment in pixels of the <c>host_ptr</c> specified to
        ///     <c><see cref="CL.CreateBuffer(CLContext, MemoryFlags, UIntPtr, IntPtr, out CLResultCode)">CreateBuffer()</see></c> or
        ///     <c><see cref="CL.CreateBufferWithProperties()">CreateBufferWithProperties()</see></c>
        ///     when a 2D image is created from a buffer which was created using <c><see cref="MemoryFlags.UseHostPtr">UseHostPtr</see></c>.
        ///     The value returned must be a power of 2.
        /// </para>
        /// <para>
        ///     Support for 2D images created from a buffer is required
        ///     for an OpenCL 2.0, 2.1, or 2.2 device if <c><see cref="ImageSupport">ImageSupport</see></c>
        ///     is TRUE.
        /// </para>
        /// <para>
        ///     This value must be 0 for devices that do not support 2D images created from a buffer.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ImageBaseAddressAlignment = 0x104B,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     The maximum number of pipe objects that can be passed
        ///     as arguments to a kernel. The minimum value is 16 for devices supporting pipes,
        ///     and must be 0 for devices that do not support pipes.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumPipeArguments = 0x1055,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     The maximum number of reservations that can be active for a pipe
        ///     per work-item in a kernel. A work-group reservation is counted as one
        ///     reservation per work-item. The minimum value is 1 for devices supporting pipes,
        ///     and must be 0 for devices that do not support pipes.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        PipeMaximumActiveReservations = 0x1056,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     The maximum size of pipe packet in bytes.
        /// </para>
        /// <para>
        ///     Support for pipes is required for an OpenCL 2.0, 2.1, or 2.2 device.
        ///     The minimum value is 1024 bytes if the device supports pipes,
        ///     and must be 0 for devices that do not support pipes.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        PipeMaximumPacketSize = 0x1057,

        /// <summary>
        /// <para>
        ///     Max size in bytes of all arguments that can be passed to a kernel.
        ///     The minimum value is 1024 for devices that are not of type
        ///     <c><see cref="DeviceType.Custom">DeviceType.Custom</see></c>.
        ///     For this minimum value, only a maximum of 128 arguments can be passed to a kernel.
        ///     For all other values, a maximum of 255 arguments can be passed to a kernel.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        MaximumParameterSize = 0x1017,

        /// <summary>
        /// <para>
        ///     Alignment requirement (in bits) for sub-buffer offsets.
        ///     The minimum value is the size (in bits) of the largest OpenCL built-in data type
        ///     supported by the device (long16 in FULL profile, long16 or int16 in EMBEDDED profile)
        ///     for devices that are not of type <c><see cref="DeviceType.Custom">DeviceType.Custom</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MemoryBaseAddressAlignment = 0x1019,

        /// <summary>
        /// <para>
        ///     <i><pre>Deprecated by version 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     The minimum value is the size (in bytes)
        ///     of the largest OpenCL data type supported by the device
        ///     (long16 in FULL profile, long16 or int16 in EMBEDDED profile).
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        [Obsolete("MinimumDataTypeAlignmentSize is a deprecated OpenCL 1.1 property.")]
        MinimumDataTypeAlignmentSize = 0x101A,

        /// <summary>
        /// <para>
        ///     Describes single precision floating-point capability of the device.
        /// </para>
        /// <para>
        ///     For the full profile, the mandated minimum floating-point capability
        ///     for devices that are not of type <c><see cref="DeviceType.Custom">Custom</see></c> is:
        /// </para>
        /// <para>
        ///     <pre><see cref="DeviceFloatingPointConfig.RoundToNearest">RoundToNearest</see> | <see cref="DeviceFloatingPointConfig.InfinityNaN">InfinityNaN</see></pre>
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceFloatingPointConfig">DeviceFloatingPointConfig</see></c>
        /// </para>
        /// </summary>
        SingleFloatingPointConfiguration = 0x101B,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Describes double precision floating-point capability of the OpenCL device.
        ///     Double precision is an optional feature so the mandated minimum double
        ///     precision floating-point capability is 0.
        /// </para>
        /// <para>
        ///     If double precision is supported by the device,
        ///     then the minimum double precision floating-point capability
        ///     for OpenCL 2.0 or newer devices is:
        /// </para>
        /// <para>
        ///     <pre><see cref="DeviceFloatingPointConfig.FusedMultiplyAdd">FusedMultiplyAdd</see> | <see cref="DeviceFloatingPointConfig.RoundToNearest">RoundToNearest</see> | <see cref="DeviceFloatingPointConfig.InfinityNaN">InfinityNaN</see> | <see cref="DeviceFloatingPointConfig.Denorm">Denorm</see></pre>
        /// </para>
        /// <para>
        ///     or for OpenCL 1.0, OpenCL 1.1 or OpenCL 1.2 devices:
        /// </para>
        /// <para>
        ///     <pre><see cref="DeviceFloatingPointConfig.FusedMultiplyAdd">FusedMultiplyAdd</see> | <see cref="DeviceFloatingPointConfig.RoundToNearest">RoundToNearest</see> | <see cref="DeviceFloatingPointConfig.RoundToZero">RoundToZero</see> | <see cref="DeviceFloatingPointConfig.RoundToInfinity">RoundToInfinity</see> | <see cref="DeviceFloatingPointConfig.InfinityNaN">InfinityNaN</see> | <see cref="DeviceFloatingPointConfig.Denorm">Denorm</see></pre>
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceFloatingPointConfig">DeviceFloatingPointConfig</see></c>
        /// </para>
        /// </summary>
        DoubleFloatingPointConfiguration = 0x1032,

        /// <summary>
        /// <para>
        ///     Type of global memory cache supported.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceMemoryCacheType">DeviceMemoryCacheType</see></c>
        /// </para>
        /// </summary>
        GlobalMemoryCacheType = 0x101C,

        /// <summary>
        /// <para>
        ///     Size of global memory cache line in bytes.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        GlobalMemoryCachelineSize = 0x101D,

        /// <summary>
        /// <para>
        ///     Size of global memory cache in bytes.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>ulong</c>
        /// </para>
        /// </summary>
        GlobalMemoryCacheSize = 0x101E,

        /// <summary>
        /// <para>
        ///     Size of global device memory in bytes.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>ulong</c>
        /// </para>
        /// </summary>
        GlobalMemorySize = 0x101F,

        /// <summary>
        /// <para>
        ///     Max size in bytes of a constant buffer allocation.
        ///     The minimum value is 64 KB for devices that are not of type
        ///     <c><see cref="DeviceType.Custom">Custom</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>ulong</c>
        /// </para>
        /// </summary>
        MaximumConstantBufferSize = 0x1020,

        /// <summary>
        /// <para>
        ///     Max number of arguments declared with the <c>__constant</c> qualifier in a kernel.
        ///     The minimum value is 8 for devices that are not of type
        ///     <c><see cref="DeviceType.Custom">Custom</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumConstantArguments = 0x1021,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     The maximum number of bytes of storage that may be allocated for any single
        ///     variable in program scope or inside a function in an OpenCL kernel
        ///     language declared in the global address space.
        /// </para>
        /// <para>
        ///     Support for program scope global variables is required
        ///     for an OpenCL 2.0, 2.1, or 2.2 device. The minimum value is 64 KB if the device
        ///     supports program scope global variables, and must be 0 for devices that do
        ///     not support program scope global variables.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        MaximumGlobalVariableSize = 0x104D,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Maximum preferred total size, in bytes,
        ///     of all program variables in the global address space.
        ///     This is a performance hint. An implementation may place such variables
        ///     in storage with optimized device access.
        ///     This query returns the capacity of such storage. The minimum value is 0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        GlobalVariablePreferredTotalSize = 0x1054,

        /// <summary>
        /// <para>
        ///     Type of local memory supported.
        ///     This can be set to <c><see cref="DeviceLocalMemoryType.Local">Local</see></c>
        ///     implying dedicated local memory storage such as SRAM, or
        ///     <c><see cref="DeviceLocalMemoryType.Global">Global</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceLocalMemoryType">DeviceLocalMemoryType</see></c>
        /// </para>
        /// </summary>
        LocalMemoryType = 0x1022,

        /// <summary>
        /// <para>
        ///     Size of local memory arena in bytes.
        ///     The minimum value is 32 KB for devices that are not of type
        ///     <c><see cref="DeviceType.Custom">Custom</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>ulong</c>
        /// </para>
        /// </summary>
        LocalMemorySize = 0x1023,

        /// <summary>
        /// <para>
        ///     Is TRUE if the device implements error correction
        ///     for all accesses to compute device memory (global and constant).
        ///     Is FALSE if the device does not implement such error correction.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        ErrorCorrectionSupport = 0x1024,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1 and deprecated by version 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Is TRUE if the device and the host have a unified memory subsystem and is FALSE otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        [Obsolete("HostUnifiedMemory is a deprecated OpenCL 1.2 property.")]
        HostUnifiedMemory = 0x1035,

        /// <summary>
        /// <para>
        ///     Describes the resolution of device timer. This is measured in nanoseconds. Refer to
        ///     <see href="https://www.khronos.org/registry/OpenCL/specs/3.0-unified/html/OpenCL_API.html#profiling-operations">Profiling Operations</see> for details.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        ProfilingTimerResolution = 0x1025,

        /// <summary>
        /// <para>
        ///     Is TRUE if the OpenCL device is a little endian device and FALSE otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        EndianLittle = 0x1026,

        /// <summary>
        /// <para>
        ///     Is TRUE if the device is available and FALSE if the device is not available.
        ///     A device is considered to be available if the device can be expected to
        ///     successfully execute commands enqueued to the device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        Available = 0x1027,

        /// <summary>
        /// <para>
        ///     Is FALSE if the implementation does not have
        ///     a compiler available to compile the program source.
        ///     Is TRUE if the compiler is available.
        ///     This can be FALSE for the embedded platform profile only.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        CompilerAvailable = 0x1028,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Is FALSE if the implementation does not have a linker available. Is TRUE if the linker is available.
        /// </para>
        /// <para>
        ///     This can be FALSE for the embedded platform profile only.
        ///     This must be TRUE if <c><see cref="CompilerAvailable">CompilerAvailable</see></c> is TRUE.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        LinkerAvailable = 0x103E,

        /// <summary>
        /// <para>
        ///     Describes the execution capabilities of the device.
        ///     This is a bit-field that describes one or more of the following values:
        /// </para>
        /// <list type="bullet">
        /// <item><term>
        ///     <c><see cref="DeviceExecutionCapabilities.Kernel">Kernel</see></c></term>
        /// <description>
        ///     The OpenCL device can execute OpenCL kernels.
        /// </description></item>
        ///
        /// <item><term>
        ///     <c><see cref="DeviceExecutionCapabilities.NativeKernel">NativeKernel</see></c></term>
        /// <description>
        ///     The OpenCL device can execute native kernels.
        /// </description></item>
        /// </list>
        /// <para>
        ///     The mandated minimum capability is
        ///     <c><see cref="DeviceExecutionCapabilities.Kernel">Kernel</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceExecutionCapabilities">DeviceExecutionCapabilities</see></c>
        /// </para>
        /// </summary>
        ExecutionCapabilities = 0x1029,

        /// <summary>
        /// <para>
        ///     <i><pre>Deprecated by verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     See description of <c><see cref="QueueOnHostProperties">QueueOnHostProperties</see></c>
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CommandQueueProperties">CommandQueueProperties</see></c>
        /// </para>
        /// </summary>
        [Obsolete("QueueProperties is a deprecated OpenCL 1.2 property, please use QueueOnHostProperties.")]
        QueueProperties = 0x102A,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Describes the on host command-queue properties supported by the device.
        ///     The mandated minimum capability is:
        ///     <c><see cref="CommandQueueProperties.ProfilingEnable">ProfilingEnable</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CommandQueueProperties">CommandQueueProperties</see></c>
        /// </para>
        /// </summary>
        QueueOnHostProperties = 0x102A,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Describes the on device command-queue properties supported by the device.
        /// </para>
        /// <para>
        ///     Support for on-device queues is required for an OpenCL 2.0, 2.1, or 2.2 device.
        ///     When on-device queues are supported, the mandated minimum capability is:
        /// </para>
        /// <para>
        ///     <pre><see cref="CommandQueueProperties.OutOfOrderExecutionModeEnable">OutOfOrderExecutionModeEnable</see> | <see cref="CommandQueueProperties.ProfilingEnable">ProfilingEnable</see></pre>
        /// </para>
        /// <para>
        ///     Must be 0 for devices that do not support on-device queues.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CommandQueueProperties">CommandQueueProperties</see></c>
        /// </para>
        /// </summary>
        QueueOnDeviceProperties = 0x104E,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     The preferred size of the device queue, in bytes.
        ///     Applications should use this size for the device queue to ensure good performance.
        /// </para>
        /// <para>
        ///     The minimum value is 16 KB for devices supporting on-device queues,
        ///     and must be 0 for devices that do not support on-device queues.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        QueueOnDevicePreferredSize = 0x104F,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     The maximum size of the device queue in bytes.
        /// </para>
        /// <para>
        ///     The minimum value is 256 KB for the full profile and 64 KB for
        ///     the embedded profile for devices supporting on-device queues,
        ///     and must be 0 for devices that do not support on-device queues.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        QueueOnDeviceMaximumSize = 0x1050,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     The maximum number of device queues that can be created for this device in a single context.
        /// </para>
        /// <para>
        ///     The minimum value is 1 for devices supporting on-device queues,
        ///     and must be 0 for devices that do not support on-device queues.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumOnDeviceQueues = 0x1051,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///      The maximum number of events in use by a device queue.
        ///      These refer to events returned by the <c>enqueue_</c> built-in functions
        ///      to a device queue or user events returned by the <c>create_user_event</c>
        ///      built-in function that have not been released.
        /// </para>
        /// <para>
        ///     The minimum value is 1024 for devices supporting on-device queues,
        ///     and must be 0 for devices that do not support on-device queues.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumOnDeviceEvents = 0x1052,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///      A semi-colon separated list of built-in kernels supported by the device.
        ///      An empty string is returned if no built-in kernels are supported by the device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        BuiltInKernels = 0x103F,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns an array of descriptions for the built-in kernels supported by the device.
        ///     Each built-in kernel may only be reported once.
        ///     The list of reported kernels must match the list returned via
        ///     <c><see cref="BuiltInKernels">BuiltInKernels</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLNameVersion">CLNameVersion[]</see></c>
        /// </para>
        /// </summary>
        BuiltInKernelsWithVersion = 0x1062,

        /// <summary>
        /// <para>
        ///     The platform associated with this device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLPlatform">CLPlatform</see></c>
        /// </para>
        /// </summary>
        Platform = 0x1031,

        /// <summary>
        /// <para>
        ///     Device name string.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Name = 0x102B,

        /// <summary>
        /// <para>
        ///     Vendor name string.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        /// <remarks>Return Type: string</remarks>
        Vendor = 0x102C,

        /// <summary>
        /// <para>
        ///     OpenCL software driver version string. Follows a vendor-specific format.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        DriverVersion = 0x102D,

        /// <summary>
        /// <para>
        ///     OpenCL profile string.
        ///     Returns the profile name supported by the device.
        ///     The profile name returned can be one of the following strings:
        /// </para>
        /// <list type="bullet">
        /// <item>
        ///     <term><b>FULL_PROFILE: </b></term>
        ///     <description>
        ///         if the device supports the OpenCL specification
        ///         (functionality defined as part of the core specification and
        ///         does not require any extensions to be supported).
        ///     </description>
        /// </item>
        ///
        /// <item>
        ///     <term><b>EMBEDED_PROFILE: </b></term>
        ///     <description>
        ///         if the device supports the OpenCL embedded profile.
        ///     </description>
        /// </item>
        /// </list>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Profile = 0x102E,

        /// <summary>
        /// <para>
        ///     OpenCL version string. Returns the OpenCL version supported by the device.
        ///     This version string has the following format:
        /// </para>
        /// <para>
        ///     <c><pre>OpenCL&lt;space&gt;&lt;major_version.minor_version&gt;&lt;space&gt;&lt;vendor-specific information&gt;</pre></c>
        /// </para>
        /// <para>
        ///     The <c>major_version.minor_version</c>
        ///     value returned will be one of 1.0, 1.1, 1.2, 2.0, 2.1, 2.2, or 3.0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Version = 0x102F,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the detailed (major, minor, patch)
        ///     version supported by the device. The major and minor version numbers
        ///     returned must match those returned via <c><see cref="Version">Version</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLVersion">CLVersion</see></c>
        /// </para>
        /// </summary>
        NumericVersion = 0x105E,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1 and deprecated by version 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the highest fully backwards compatible OpenCL C version
        ///     supported by the compiler for the device.
        ///     For devices supporting compilation from OpenCL C source,
        ///     this will return a version string with the following format:
        /// </para>
        /// <para>
        ///     <c><pre>OpenCL&lt;space&gt;C&lt;space&gt;&lt;major_version.minor_version&gt;&lt;space&gt;&lt;vendor-specific information&gt;</pre></c>
        /// </para>
        /// <para>
        ///     For devices that support compilation from OpenCL C source:
        /// </para>
        /// <para>
        ///     Because OpenCL 3.0 is backwards compatible with OpenCL C 1.2,
        ///     an OpenCL 3.0 device must support at least OpenCL C 1.2. An OpenCL 3.0
        ///     device may return an OpenCL C version newer than OpenCL C 1.2 if and only
        ///     if all optional OpenCL C features are supported by the device for the newer version.
        /// </para>
        /// <para>
        ///     Support for OpenCL C 2.0 is required for an OpenCL 2.0, OpenCL 2.1, or OpenCL 2.2 device.
        /// </para>
        /// <para>
        ///     Support for OpenCL C 1.2 is required for an OpenCL 1.2 device.
        /// </para>
        /// <para>
        ///     Support for OpenCL C 1.1 is required for an OpenCL 1.1 device.
        /// </para>
        /// <para>
        ///     Support for either OpenCL C 1.0 or OpenCL C 1.1 is required for an OpenCL 1.0 device.
        /// </para>
        /// <para>
        ///     For devices that do not support compilation from OpenCL C source,
        ///     such as when <c><see cref="CompilerAvailable">CompilerAvailable</see></c>
        ///     is FALSE, this query may return an empty string.
        /// </para>
        /// <para>
        ///     This query has been superseded by the CL_DEVICE_OPENCL_C_ALL_VERSIONS query, which returns a set of OpenCL C versions supported by a device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        OpenClCVersion = 0x103D,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns an array of name, version descriptions listing all
        ///     the versions of OpenCL C supported by the compiler for the device.
        ///     In each returned description structure, the name field is required
        ///     to be "OpenCL C". The list may include both newer non-backwards compatible OpenCL C versions,
        ///     such as OpenCL C 3.0, and older OpenCL C versions with mandatory backwards compatibility.
        ///     The version returned by <c><see cref="OpenClCVersion">OpenClCVersion</see></c>
        ///     is required to be present in the list.
        /// </para>
        /// <para>
        ///     For devices that support compilation from OpenCL C source:
        /// </para>
        /// <para>
        ///     Because OpenCL 3.0 is backwards compatible with OpenCL C 1.2,
        ///     and OpenCL C 1.2 is backwards compatible with OpenCL C 1.1 and OpenCL C 1.0,
        ///     support for at least OpenCL C 3.0, OpenCL C 1.2, OpenCL C 1.1,
        ///     and OpenCL C 1.0 is required for an OpenCL 3.0 device.
        /// </para>
        /// <para>
        ///     Support for OpenCL C 2.0, OpenCL C 1.2, OpenCL C 1.1,
        ///     and OpenCL C 1.0 is required for an OpenCL 2.0, OpenCL 2.1,
        ///     or OpenCL 2.2 device.
        /// </para>
        /// <para>
        ///     Support for OpenCL C 1.2, OpenCL C 1.1, and OpenCL C 1.0
        ///     is required for an OpenCL 1.2 device.
        /// </para>
        /// <para>
        ///     Support for OpenCL C 1.1 and OpenCL C 1.0 is required for an OpenCL 1.1 device.
        /// </para>
        /// <para>
        ///     Support for at least OpenCL C 1.0 is required for an OpenCL 1.0 device.
        /// </para>
        /// <para>
        ///    For devices that do not support compilation from OpenCL C source,
        ///    this query may return an empty array. this query may return an empty string.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLNameVersion">CLNameVersion[]</see></c>
        /// </para>
        /// </summary>
        OpenClCAllVersions = 0x1066,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns an array of optional OpenCL C features supported by the compiler
        ///     for the device alongside the OpenCL C version that introduced the feature macro.
        ///     For example, if a compiler supports an OpenCL C 3.0 feature,
        ///     the returned name will be the full name of the OpenCL C feature macro,
        ///     and the returned version will be 3.0.0.
        /// </para>
        /// <para>
        ///     For devices that do not support compilation from OpenCL C source,
        ///     this query may return an empty array.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLNameVersion">CLNameVersion[]</see></c>
        /// </para>
        /// </summary>
        OpenCLCFeatures = 0x106F,

        /// <summary>
        /// <para>
        ///     Returns a space separated list of extension names
        ///     (the extension names themselves do not contain any spaces) supported by the device.
        ///     The list of extension names may include Khronos
        ///     approved extension names and vendor specified extension names.
        /// </para>
        /// <para>
        ///     The following Khronos extension names must be returned by all devices that support OpenCL 1.1:
        /// </para>
        /// <list type="bullet">
        /// <item>
        ///     <description><b>cl_khr_byte_addressable_store</b></description>
        /// </item>
        /// <item>
        ///     <description><b>cl_khr_global_int32_base_atomics</b></description>
        /// </item>
        /// <item>
        ///     <description><b>cl_khr_global_int32_extended_atomics</b></description>
        /// </item>
        /// <item>
        ///     <description><b>cl_khr_local_int32_base_atomics</b></description>
        /// </item>
        /// <item>
        ///     <description><b>cl_khr_local_int32_extended_atomics</b></description>
        /// </item>
        /// </list>
        /// <para>
        ///     Additionally, the following Khronos extension names must be returned by all devices
        ///     that support OpenCL 1.2 when and only when the optional feature is supported:
        /// </para>
        /// <list type="bullet">
        /// <item>
        ///     <description><b>cl_khr_fp64</b></description>
        /// </item>
        /// </list>
        /// <para>
        ///     Additionally, the following Khronos extension names must be returned
        ///     by all devices that support OpenCL 2.0, OpenCL 2.1, or OpenCL 2.2.
        ///     For devices that support OpenCL 3.0,
        ///     these extension names must be returned when and only when the optional feature is supported:
        /// </para>
        /// <list type="bullet">
        /// <item>
        ///     <description><b>cl_khr_3d_image_writes</b></description>
        /// </item>
        /// <item>
        ///     <description><b>cl_khr_depth_images</b></description>
        /// </item>
        /// <item>
        ///     <description><b>cl_khr_image2d_from_buffer</b></description>
        /// </item>
        /// </list>
        /// <para>
        ///     Please refer to the OpenCL Extension Specification or vendor provided documentation
        ///     for a detailed description of these extensions.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Extensions = 0x1030,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns an array of description (name and version) structures.
        ///     The same extension name must not be reported more than once.
        ///     The list of extensions reported must match the list reported via
        ///     <c><see cref="Extensions">Extensions</see></c>.
        /// </para>
        /// <para>
        ///     See <c><see cref="Extensions">Extensions</see></c>
        ///     for a list of extensions that are required to be reported for a given OpenCL version.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLNameVersion">CLNameVersion[]</see></c>
        /// </para>
        /// </summary>
        ExtensionsWithVersion = 0x1060,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Maximum size in bytes of the internal buffer that holds the output of
        ///     printf calls from a kernel. The minimum value for the FULL profile is 1 MB.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        PrintfBufferSize = 0x1049,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Is TRUE if the devices preference is for the user to be responsible
        ///     for synchronization, when sharing memory objects between OpenCL and other APIs
        ///     such as DirectX, FALSE if the device / implementation has a performant path
        ///     for performing synchronization of memory object shared between
        ///     OpenCL and other APIs such as DirectX.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        PreferredInteropUserSync = 0x1048,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the <c><see cref="CLDevice">CLDevice</see></c> of the parent
        ///     device to which this sub-device belongs.
        ///     If <c><see cref="CL.GetDeviceInfo(CLDevice, DeviceInfo, UIntPtr, byte[], out UIntPtr)">device</see></c> is a root-level device, a NULL value is returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLDevice">CLDevice</see></c>
        /// </para>
        /// </summary>
        ParentDevice = 0x1042,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the maximum number of sub-devices that can be created when a device is partitioned.
        ///     The value returned cannot exceed <c><see cref="MaximumComputeUnits">MaximumComputeUnits</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        PartitionMaximumSubDevices = 0x1043,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the list of partition types supported by device.
        ///     If the device cannot be partitioned (i.e. there is no partitioning scheme
        ///     supported by the device that will return at least two sub-devices),
        ///     a value of 0 will be returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DevicePartitionProperty">DevicePartitionProperty[]</see></c>
        /// </para>
        /// </summary>
        PartitionProperties = 0x1044,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the list of supported affinity domains for
        ///     partitioning the device using
        ///     <c><see cref="DevicePartitionProperty.ByAffinityDomain">ByAffinityDomain</see></c>.
        /// </para>
        /// <para>
        ///     If the device does not support any affinity domains, a value of 0 will be returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceAffinityDomain">DeviceAffinityDomain</see></c>
        /// </para>
        /// </summary>
        PartitionAffinityDomain = 0x1045,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the properties argument specified in
        ///     <c><see cref="CL.CreateSubDevices(CLDevice, IntPtr[], uint, CLDevice[], out uint)">CreateSubDevices()</see></c>
        ///     if device is a sub-device. In the case where the properties argument to
        ///     <c><see cref="CL.CreateSubDevices(CLDevice, IntPtr[], uint, CLDevice[], out uint)">CreateSubDevices()</see></c>
        ///     is <c><see cref="DevicePartitionProperty.ByAffinityDomain">ByAffinityDomain</see></c>,
        ///     C<c><see cref="DeviceAffinityDomain.NextPartionable">NextPartionable</see></c>,
        ///     the affinity domain used to perform the partition will be returned.
        /// </para>
        /// <para>
        ///     Otherwise the implementation may either return a
        ///     <c><see cref="CL.GetDeviceInfo(CLDevice, DeviceInfo, UIntPtr, byte[], out UIntPtr)">paramValueSizeReturned</see></c>
        ///     of 0 i.e. there is no partition type associated with device or can return
        ///     a property value of 0 (where 0 is used to terminate the partition property list) in the memory that
        ///     <c><see cref="CL.GetDeviceInfo(CLDevice, DeviceInfo, UIntPtr, byte[], out UIntPtr)">paramValue</see></c>
        ///     points to.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DevicePartitionProperty">DevicePartitionProperty[]</see></c>
        /// </para>
        /// </summary>
        PartitionType = 0x1046,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the <c><see cref="CL.GetDeviceInfo(CLDevice, DeviceInfo, UIntPtr, byte[], out UIntPtr)">device</see></c>
        ///     reference count. If the device is a root-level device, a reference count of one is returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ReferenceCount = 0x1047,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Describes the various shared virtual memory (SVM) memory allocation types the device supports.
        /// </para>
        /// <para>
        ///      The mandated minimum capability for an OpenCL 2.0, 2.1, or 2.2 device is
        ///      <c><see cref="DeviceSvmCapabilities.CoarseGrainBuffer">CoarseGrainBuffer</see></c>.
        ///      For other device versions there is no mandated minimum capability.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceSvmCapabilities">DeviceSvmCapabilities</see></c>
        /// </para>
        /// </summary>
        SvmCapabilities = 0x1053,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the value representing the preferred alignment in bytes for OpenCL 2.0
        ///     fine-grained SVM atomic types. This query can return 0 which indicates that
        ///     the preferred alignment is aligned to the natural size of the type.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        PreferredPlatformAtomicAlignment = 0x1058,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the value representing the preferred alignment in bytes
        ///     for OpenCL 2.0 atomic types to global memory. This query can return
        ///     0 which indicates that the preferred alignment is aligned to the natural size of the type.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        PreferredGlobalAtomicAlignment = 0x1059,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the value representing the preferred alignment in
        ///     bytes for OpenCL 2.0 atomic types to local memory. This query
        ///     can return 0 which indicates that the preferred alignment
        ///     is aligned to the natural size of the type.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        PreferredLocalAtomicAlignment = 0x105A,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.1.</pre></i>
        /// </para>
        /// <para>
        ///     Maximum number of sub-groups in a work-group that a device is capable
        ///     of executing on a single compute unit,
        ///     for any given kernel-instance running on the device.
        /// </para>
        /// <para>
        ///     The minimum value is 1 if the device supports sub-groups,
        ///     and must be 0 for devices that do not support sub-groups.
        ///     Support for sub-groups is required for an OpenCL 2.1 or 2.2 device.
        /// </para>
        /// <para>
        ///     (Refer also to
        ///     <c><see cref="CL.GetKernelSubGroupInfo(CLKernel, CLDevice, KernelSubGroupInfo, UIntPtr, IntPtr, UIntPtr, byte[], out UIntPtr)">GetKernelSubGroupInfo()</see></c>.)
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumNumberOfSubGroups = 0x105C,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.1.</pre></i>
        /// </para>
        /// <para>
        ///     Is TRUE if this device supports independent forward progress of sub-groups, FALSE otherwise.
        /// </para>
        /// <para>
        ///     This query must return TRUE for devices that support the <c>cl_khr_subgroups</c> extension,
        ///     and must return FALSE for devices that do not support sub-groups.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        SubGroupIndependentForwardProgress = 0x105D,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Describes the various memory orders and scopes that the device supports for atomic memory operations.
        /// </para>
        /// <para>
        ///     Because atomic memory orders are hierarchical,
        ///     a device that supports a strong memory order must also support all weaker memory orders.
        /// </para>
        /// <para>
        ///     Because atomic scopes are hierarchical,
        ///     a device that supports a wide scope must also support all narrower scopes,
        ///     except for the work-item scope, which is a special case.
        /// </para>
        /// <para>
        ///     The mandated minimum capability is:
        /// </para>
        ///     <pre><c><see cref="DeviceAtomicCapabilities.OrderRelaxed">OrderRelaxed</see></c> | <c><see cref="DeviceAtomicCapabilities.ScopeWorkGroup">ScopeWorkGroup</see></c></pre>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceAtomicCapabilities">DeviceAtomicCapabilities</see></c>
        /// </para>
        /// </summary>
        AtomicMemoryCapabilities = 0x1063,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Describes the various memory orders and scopes that the device
        ///     supports for atomic fence operations. This is a bit-field that has
        ///     the same set of possible values as described for
        ///     <c><see cref="AtomicMemoryCapabilities">AtomicMemoryCapabilities</see></c>.
        /// </para>
        /// <para>
        ///     The mandated minimum capability is:
        /// </para>
        ///     <pre><c><see cref="DeviceAtomicCapabilities.OrderRelaxed">OrderRelaxed</see></c> | <c><see cref="DeviceAtomicCapabilities.OrderAcquireRelease">OrderAcquireRelease</see></c> | <c><see cref="DeviceAtomicCapabilities.ScopeWorkGroup">ScopeWorkGroup</see></c></pre>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceAtomicCapabilities">DeviceAtomicCapabilities</see></c>
        /// </para>
        /// </summary>
        AtomicFenceCapabilities = 0x1064,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Is TRUE if the device supports non-uniform work-groups, and FALSE otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        NonUniformGroupSupport = 0x1065,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Is TRUE if the device supports work-group collective functions, e.g.
        ///     <c><see href="https://registry.khronos.org/OpenCL/sdk/3.0/docs/man/html/workGroupFunctions.html">these</see></c>,
        ///     and FALSE otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        WorkGroupCollectiveFunctionsSupport = 0x1068,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Is TRUE if the device supports the generic address space
        ///     and its associated built-in functions, and FALSE otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        GenericAddressSpaceSupport = 0x1069,

        /// <summary>
        ///  <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Describes device-side enqueue capabilities of the device.
        /// </para>
        /// <para>
        ///     If <c><see cref="DeviceDeviceEnqueueCapabilities.QueueReplaceableDefault">QueueReplaceableDefault</see></c>
        ///     is set, <c><see cref="DeviceDeviceEnqueueCapabilities.QueueSupported">QueueSupported</see></c>
        ///     must also be set.
        /// </para>
        /// <para>
        ///     Devices that set <c><see cref="DeviceDeviceEnqueueCapabilities.QueueSupported">QueueSupported</see></c>
        ///     for <c><see cref="DeviceDeviceEnqueueCapabilities">DeviceDeviceEnqueueCapabilities</see></c>
        ///     must also return TRUE for <c><see cref="GenericAddressSpaceSupport">GenericAddressSpaceSupport</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceDeviceEnqueueCapabilities">DeviceDeviceEnqueueCapabilities</see></c>
        /// </para>
        /// </summary>
        DeviceEnqueueCapabilities = 0x1070,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Is TRUE if the device supports pipes, and FALSE otherwise.
        /// </para>
        /// <para>
        ///     Devices that return TRUE for <c><see cref="PipeSupport">PipeSupport</see></c>
        ///     must also return TRUE for
        ///     <c><see cref="GenericAddressSpaceSupport">GenericAddressSpaceSupport</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        PipeSupport = 0x1071,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the preferred multiple of work-group size for the given device.
        ///     This is a performance hint intended as a guide when specifying
        ///     the local work size argument to
        ///     <c><see cref="CL.EnqueueNDRangeKernel(CLCommandQueue, CLKernel, uint,
        ///     UIntPtr[], UIntPtr[], UIntPtr[], uint,
        ///     CLEvent[], out CLEvent)">EnqueueNDRangeKernel()</see></c>.
        /// </para>
        /// <para>
        ///     (Refer also to
        ///     <c><see cref="CL.GetKernelWorkGroupInfo(CLKernel, CLDevice,
        ///     KernelWorkGroupInfo, out byte[])">GetKernelWorkGroupInfo()</see></c>
        ///     where <c><see cref="KernelWorkGroupInfo.PreferredWorkGroupSizeMultiple"/></c>
        ///     can return a different value to
        ///     <c><see cref="PreferredWorkGroupSizeMultiple"/></c> which may be more optimal.)
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        PreferredWorkGroupSizeMultiple = 0x1067,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the latest version of the conformance test suite that this device has
        ///     fully passed in accordance with the official conformance process.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        LatestConformanceVersionPassed = 0x1072,

        // Values added by extensions:

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/sdk/3.0/docs/man/html/cl_khr_fp16.html">cl_khr_fp16</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///      Bitfield that describes half precision floating-point capability of the OpenCL device.
        /// </para>
        /// <para>
        ///     The required minimum half precision floating-point capability as implemented by this extension is:
        /// </para>
        /// <para>
        ///     <pre><c><see cref="DeviceFloatingPointConfig.RoundToZero">RoundToZero</see></c> | <c><see cref="DeviceFloatingPointConfig.RoundToNearest">RoundToNearest</see></c> | <c><see cref="DeviceFloatingPointConfig.InfinityNaN">InfinityNaN</see></c></pre>
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceFloatingPointConfig">DeviceFloatingPointConfig</see></c>
        /// </para>
        /// </summary>
        HalfFloatingPointConfiguration = 0x1033,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/sdk/3.0/docs/man/html/cl_khr_terminate_context.html">cl_khr_terminate_context</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     Bitfield that describes the termination capability of the OpenCL device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="DeviceTerminateCapability">DeviceTerminateCapability</see></c>
        /// </para>
        /// </summary>
        TerminateCapabilityKHR = 0x2031,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/sdk/3.0/docs/man/html/cl_khr_spir.html">cl_khr_spir</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     A space separated list of SPIR versions supported by the device.
        /// </para>
        /// <para>
        ///     For example, returning "1.2" in this query implies that SPIR version
        ///     1.2 is supported by the implementation.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        SPIRVersions = 0x40E0,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/nv/cl_nv_device_attribute_query.txt">cl_nv_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query device attributes specific to NVIDIA hardware.
        /// </para>
        /// <para>
        ///     Returns the major revision number that defines the CUDA compute capability of the device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ComputeCapabilityMajorNVIDIA = 0x4000,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/nv/cl_nv_device_attribute_query.txt">cl_nv_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query device attributes specific to NVIDIA hardware.
        /// </para>
        /// <para>
        ///     Returns the minor revision number that defines the CUDA compute capability of the device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ComputeCapabilityMinorNVIDIA = 0x4001,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/nv/cl_nv_device_attribute_query.txt">cl_nv_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query device attributes specific to NVIDIA hardware.
        /// </para>
        /// <para>
        ///     Maximum number of 32-bit registers available to a work-group.
        ///     this number is shared by all work-groups simultaneously resident on a multiprocessor.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        RegistersPerBlockNVIDIA = 0x4002,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/nv/cl_nv_device_attribute_query.txt">cl_nv_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query device attributes specific to NVIDIA hardware.
        /// </para>
        /// <para>
        ///     Warp size in work-items.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        WarpSizeNVIDIA = 0x4003,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/nv/cl_nv_device_attribute_query.txt">cl_nv_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query device attributes specific to NVIDIA hardware.
        /// </para>
        /// <para>
        ///     Returns TRUE if the device can concurrently copy memory between host
        ///     and device while executing a kernel, or FALSE if not.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        GPUOverlapNVIDIA = 0x4004,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/nv/cl_nv_device_attribute_query.txt">cl_nv_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query device attributes specific to NVIDIA hardware.
        /// </para>
        /// <para>
        ///     TRUE if there is a run time limit for kernels executed
        ///     on the device, or FALSE if not.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        KernelExecutionTimeoutNVIDIA = 0x4005,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/nv/cl_nv_device_attribute_query.txt">cl_nv_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query device attributes specific to NVIDIA hardware.
        /// </para>
        /// <para>
        ///     TRUE if the device is integrated with the memory
        ///     subsystem, or FALSE if not.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        IntegratedMemoryNVIDIA = 0x4006,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the offset in nano-seconds between an event timestamp and Epoch.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        ProfilingTimerOffsetAMD = 0x4036,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the topology for the device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        TopologyAMD = 0x4037,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the SKU board name for the device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        BoardNameAMD = 0x4038,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the global free memory in KBytes for the device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        GlobalFreeMemoryAMD = 0x4039,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return number of SIMD (Single Instruction Multiple Data) units per compute unit that execute in parallel.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        SIMDPerComputeUnitAMD = 0x4040,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the maximum number of work items from the same work group that can be executed by a SIMD in parellel.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        SIMDWidthAMD = 0x4041,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the number of instructions that a SIMD can execute in parallel.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        SIMDInstructionWidthAMD = 0x4042,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the number of workitems per wavefront.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        WavefrontWidth = 0x4043,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the number of global memory channels.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        GlobalMemoryChannelsAMD = 0x4044,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the number of banks in each global memory channel.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        GlobalMemoryChannelBanksAMD = 0x4045,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the width in bytes of each of global memory bank.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        GlobalMemoryChannelBankWidthAMD = 0x4046,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the local memory size in bytes per CU.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        LocalMemorySizePerComputeUnitAMD = 0x4047,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the number of banks of local memory.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        LocalMemoryBanksAMD = 0x4048,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return 1 if thread trace is supported, 0 otherwise.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        ThreadTraceSupportedAMD = 0x4049,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the core engine GFXIP major version.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        GFXIPMajorAMD = 0x404A,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the core engine GFXIP minor version.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        GFXIPMinorAMD = 0x404B,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the number of available async queues.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        AvailableAsyncQueuesAMD = 0x404C,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the preferred work group size.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        PreferredWorkGroupSizeAMD = 0x4030,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the extended maximum work group size.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        MaximumWorkGroupSizeAMD = 0x4031,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the preferred constant buffer size.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        PreferredConstantBufferSizeAMD = 0x4033,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This value provides a mechanism to query AMD specific device attributes.
        /// </para>
        /// <para>
        ///     Return the device PCIe ID.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> (TODO)
        /// </para>
        /// </summary>
        PCIeIdAMD = 0x4034,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/amd/cl_amd_device_attribute_query.txt">cl_amd_device_attribute_query</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the version of the C++ for OpenCL language supported by the device compiler.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint(cl_version)</c>
        /// </para>
        /// </summary>
        CxxForOpenCLNumericVersionEXT = 0x4230,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/qcom/cl_qcom_ext_host_ptr.txt">cl_qcom_ext_host_ptr</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the amount of memory padding that the application must add
        ///     to the end of every external allocation that will be used in conjunction
        ///     with <i>(Unimplemented)<c>CL_MEM_EXT_HOST_PTR_QCOM</c></i>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ExternalMemoryPaddingInBytesQCOM = 0x40A0,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/extensions/qcom/cl_qcom_ext_host_ptr.txt">cl_qcom_ext_host_ptr</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the device's page size.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        PageSizeQCOM = 0x40A1,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_Ext.html#cl_khr_subgroup_named_barrier">cl_khr_subgroup_named_barrier</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     Maximum number of named barriers in a work-group for
        ///     any given kernel-instance running on the device.
        ///     The minimum value is 8.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumNamedBarrierCountKHR = 0x2035,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_Ext.html#cl_khr_extended_versioning">cl_khr_extended_versioning</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     Functions like <c><see cref="NumericVersion">NumericVersion</see></c>
        /// </para>
        /// </summary>
        NumericVersionKHR = 0x105E,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_Ext.html#cl_khr_extended_versioning">cl_khr_extended_versioning</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     Functions like <c><see cref="OpenClCVersion">OpenClCVersion</see></c>
        /// </para>
        /// </summary>
        OpenCLCNumericVersionKHR = 0x105F,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_Ext.html#cl_khr_extended_versioning">cl_khr_extended_versioning</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     Functions like <c><see cref="ExtensionsWithVersion">ExtensionsWithVersion</see></c>
        /// </para>
        /// </summary>
        ExtensionsWithVersionKHR = 0x1060,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_Ext.html#cl_khr_extended_versioning">cl_khr_extended_versioning</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     Functions like <c><see cref="IntermediateLanguagesWithVersion">IntermediateLanguagesWithVersion</see></c>
        /// </para>
        /// </summary>
        IntermediateLanguagesWithVersionKHR = 0x1061,

        /// <summary>
        /// <para>
        ///     <i><pre>Requires the <c><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_Ext.html#cl_khr_extended_versioning">cl_khr_extended_versioning</see></c> extension.</pre></i>
        /// </para>
        /// <para>
        ///     Functions like <c><see cref="BuiltInKernelsWithVersion">BuiltInKernelsWithVersion</see></c>
        /// </para>
        /// </summary>
        BuiltInKernelsWithVersionKHR = 0x1062
    }

    /// <summary>
    /// <para>
    ///     <i><pre>Missing before verison 2.0.</pre></i>
    /// </para>
    /// <para>
    ///     Bitfield that describes the various shared virtual memory (SVM) memory allocation types a device supports.
    /// </para>
    /// </summary>
    [Flags]
    public enum DeviceSvmCapabilities : ulong
    {
        /// <summary>
        ///     Support for coarse-grain buffer sharing using
        ///     <c><see cref="CL.SVMAlloc(CLContext, SvmMemoryFlags, UIntPtr, uint)">SVMAlloc()</see></c>.
        ///     Memory consistency is guaranteed at synchronization points and the host must use calls to
        ///     <c><see cref="CL.EnqueueMapBuffer(CLCommandQueue, CLBuffer, bool,
        ///     MapFlags, UIntPtr, UIntPtr, uint, CLEvent[],out CLEvent, out CLResultCode)">EnqueueMapBuffer()</see></c> and
        ///     <c><see cref="CL.EnqueueUnmapMemoryObject(CLCommandQueue, CLBuffer, IntPtr, uint, CLEvent[], out CLEvent)">EnqueueUnmapMemoryObject()</see></c>.
        /// </summary>
        CoarseGrainBuffer = 1 << 0,

        /// <summary>
        ///     Support for fine-grain buffer sharing using
        ///     <c><see cref="CL.SVMAlloc(CLContext, SvmMemoryFlags, UIntPtr, uint)">SVMAlloc()</see></c>.
        ///     Memory consistency is guaranteed at synchronization points and the host must use calls to
        ///     <c><see cref="CL.EnqueueMapBuffer(CLCommandQueue, CLBuffer, bool,
        ///     MapFlags, UIntPtr, UIntPtr, uint, CLEvent[],out CLEvent, out CLResultCode)">EnqueueMapBuffer()</see></c> and
        ///     <c><see cref="CL.EnqueueUnmapMemoryObject(CLCommandQueue, CLBuffer, IntPtr, uint, CLEvent[], out CLEvent)">EnqueueUnmapMemoryObject()</see></c>.
        /// </summary>
        FineGrainBuffer = 1 << 1,

        /// <summary>
        ///     Support for sharing the host’s entire virtual memory including memory allocated using <c>malloc</c>.
        ///     Memory consistency is guaranteed at synchronization points.
        /// </summary>
        FineGrainSystem = 1 << 2,

        /// <summary>
        ///     Support for the OpenCL 2.0 atomic operations that provide memory consistency
        ///     across the host and all OpenCL devices supporting fine-grain SVM allocations.
        /// </summary>
        Atomics = 1 << 3
    }

    /// <summary>
    /// Type of local memory supported.
    /// </summary>
    public enum DeviceLocalMemoryType : uint
    {
        /// <summary>
        /// Implies dedicated local memory storage such as SRAM
        /// </summary>
        Local = 1,

        /// <summary>
        /// Uses the global machine memory
        /// </summary>
        Global = 2
    }

    /// <summary>
    /// Bitfield that describes the kernel execution capabilities of a device.
    /// </summary>
    [Flags]
    public enum DeviceExecutionCapabilities : ulong
    {
        /// <summary>
        /// The OpenCL device can execute OpenCL kernels.
        /// </summary>
        Kernel = 1 << 0,

        /// <summary>
        /// The OpenCL device can execute native kernels.
        /// </summary>
        NativeKernel = 1 << 1
    }

    /// <summary>
    /// Type of global memory cache supported by a device.
    /// </summary>
    public enum DeviceMemoryCacheType : uint
    {
        /// <summary>
        /// No cache is supported
        /// </summary>
        None = 0,

        /// <summary>
        /// Read only cache is supported
        /// </summary>
        ReadOnly = 1,

        /// <summary>
        /// Read and Write cache is supported
        /// </summary>
        ReadWrite = 2
    }

    /// <summary>
    /// Bitfield that describes the floating point configuration of a device.
    /// </summary>
    [Flags]
    public enum DeviceFloatingPointConfig : ulong
    {
        /// <summary>
        /// Denorms are supported
        /// </summary>
        Denorm = 1 << 0,

        /// <summary>
        ///  INF and NaNs are supported
        /// </summary>
        InfinityNaN = 1 << 1,

        /// <summary>
        /// Round to nearest even rounding mode supported
        /// </summary>
        RoundToNearest = 1 << 2,

        /// <summary>
        /// Round to zero rounding mode supported
        /// </summary>
        RoundToZero = 1 << 3,

        /// <summary>
        ///  Round to positive and negative infinity rounding modes supported
        /// </summary>
        RoundToInfinity = 1 << 4,

        /// <summary>
        /// IEEE754-2008 fused multiply-add is supported
        /// </summary>
        FusedMultiplyAdd = 1 << 5,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     Basic floating-point operations
        ///     (such as addition, subtraction, multiplication) are implemented in software.
        ///  </para>
        /// </summary>
        SoftFloat = 1 << 6,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Divide and sqrt are correctly rounded as defined by the IEEE754 specification
        /// </para>
        /// </summary>
        CorrectlyRoundedDivideSqrt = 1 << 7
    }

    /// <summary>
    /// Bitfield that describes the termination capability of the OpenCL device.
    /// </summary>
    [Flags]
    public enum DeviceTerminateCapability : ulong
    {
        /// <summary>
        /// Indicates that context termination is supported.
        /// </summary>
        ContextKHR = 1 << 0
    }

    /// <summary>
    /// <para>
    ///     <i><pre>Missing before verison 1.2.</pre></i>
    /// </para>
    /// <para>
    ///     Specifies the supported methods for partioning a device that can be used
    ///     in <c><see cref="CL.CreateSubDevices(CLDevice, IntPtr[], uint, CLDevice[], out uint)">CreateSubDevices()</see></c>.
    /// </para>
    /// </summary>
    public enum DevicePartitionProperty : uint
    {
        /// <summary>
        /// <para>
        ///     Split the aggregate device into as many smaller aggregate devices as can be created,
        ///     each containing <i>n</i> compute units. The value <i>n</i> is passed as the value accompanying this property.
        ///     If <i>n</i> does not divide evenly into <c><see cref="DeviceInfo.MaximumComputeUnits">MaximumComputeUnits</see></c>,
        ///     then the remaining compute units are not used.
        /// </para>
        /// <para>
        ///     <i><u>Partition Value:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        Equally = 0x1086,

        /// <summary>
        /// <para>
        ///     This property is followed by a list of compute unit counts terminated with 0.
        ///     For each non-zero count <i>m</i> in the list, a sub-device is created with <i>m</i> compute units in it.
        /// </para>
        /// <para>
        ///     The number of non-zero count entries in the list may not exceed
        ///     <c><see cref="DeviceInfo.PartitionMaximumSubDevices">PartitionMaximumSubDevices</see></c>.
        /// </para>
        /// <para>
        ///     The total number of compute units specified may not exceed
        ///     <c><see cref="DeviceInfo.PartitionMaximumSubDevices">PartitionMaximumSubDevices</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Partition Value:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ByCounts = 0x1087,

        /// <summary>
        /// <para>
        ///     Split the device into smaller aggregate devices containing one or more compute units
        ///     that all share part of a cache hierarchy.
        /// </para>
        /// <para>
        ///     The user may determine what happened by calling
        ///     <c><see cref="CL.CreateSubDevices(CLDevice, IntPtr[], uint, CLDevice[], out uint)">CreateSubDevices(<see cref="DeviceInfo.PartitionType">PartitionType</see>)</see></c>
        ///     on the sub-devices.
        /// </para>
        /// <para>
        ///     <i><u>Partition Value:</u></i> <c><see cref="DeviceAffinityDomain">DeviceAffinityDomain</see></c>
        /// </para>
        /// </summary>
        ByAffinityDomain = 0x1088
    }

    /// <summary>
    /// <para>
    ///     <i><pre>Missing before verison 1.2.</pre></i>
    /// </para>
    /// <para>
    ///     Bitfield with the supported affinity domains for partitioning a device.
    /// </para>
    /// </summary>
    [Flags]
    public enum DeviceAffinityDomain : ulong
    {
        /// <summary>
        ///     Split the device into sub-devices comprised of compute units that share a NUMA node.
        /// </summary>
        Numa = 1 << 0,

        /// <summary>
        ///     Split the device into sub-devices comprised of compute units that share a level 4 data cache.
        /// </summary>
        L4Cache = 1 << 1,

        /// <summary>
        ///     Split the device into sub-devices comprised of compute units that share a level 3 data cache.
        /// </summary>
        L3Cache = 1 << 2,

        /// <summary>
        ///     Split the device into sub-devices comprised of compute units that share a level 2 data cache.
        /// </summary>
        L2Cache = 1 << 3,

        /// <summary>
        ///     Split the device into sub-devices comprised of compute units that share a level 1 data cache.
        /// </summary>
        L1Cache = 1 << 4,

        /// <summary>
        ///     Split the device along the next partitionable affinity domain.
        ///     The implementation shall find the first level along which the device or sub-device
        ///     may be further subdivided in the order NUMA, L4, L3, L2, L1, and partition the device
        ///     into sub-devices comprised of compute units that share memory subsystems at this level.
        /// </summary>
        NextPartionable = 1 << 5
    }

    /// <summary>
    /// Bitfield to describe the atomic memory capabilities of a device.
    /// </summary>
    [Flags]
    public enum DeviceAtomicCapabilities : ulong
    {
        /// <summary>
        /// Support for the <b>relaxed</b> memory order.
        /// </summary>
        OrderRelaxed = 1 << 0,

        /// <summary>
        /// Support for the <b>acquire</b>, <b>release</b>, and <b>acquire-release</b> memory orders.
        /// </summary>
        OrderAcquireRelease = 1 << 1,

        /// <summary>
        /// Support for the <b>sequentially consistent</b> memory order.
        /// </summary>
        OrderSequentiallyConsistent = 1 << 2,

        /// <summary>
        /// Support for memory ordering constraints that apply to a single work-item.
        /// </summary>
        ScopeWorkItem = 1 << 3,

        /// <summary>
        /// Support for memory ordering constraints that apply to all work-items in a work-group.
        /// </summary>
        ScopeWorkGroup = 1 << 4,

        /// <summary>
        /// Support for memory ordering constraints that apply to all work-items executing on the device.
        /// </summary>
        ScopeDevice = 1 << 5,

        /// <summary>
        /// Support for memory ordering constraints that apply to all work-items
        /// executing across all devices that can share SVM memory with each other and the host process.
        /// </summary>
        SccopeAllDevices = 1 << 6,
    }

    /// <summary>
    /// Bitfield that describes device-side enqueue capabilities of the device.
    /// </summary>
    [Flags]
    public enum DeviceDeviceEnqueueCapabilities : ulong
    {
        /// <summary>
        /// Device supports device-side enqueue and on-device queues.
        /// </summary>
        QueueSupported = 1 << 0,

        /// <summary>
        /// Device supports a replaceable default on-device queue.
        /// </summary>
        QueueReplaceableDefault = 1 << 1
    }

    #endregion

    #region Command Queue

    /// <summary>
    ///     The list of supported values for, and the information returned by
    ///     <c><see cref="CL.GetCommandQueueInfo(CLCommandQueue, CommandQueueInfo, out byte[])">GetCommandQueueInfo()</see></c>.
    /// </summary>
    public enum CommandQueueInfo : uint
    {
        /// <summary>
        /// <para>
        ///     Return the context specified when the command-queue is created.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLContext">CLContext</see></c>
        /// </para>
        /// </summary>
        Context = 0x1090,

        /// <summary>
        /// <para>
        ///     Return the device specified when the command-queue is created.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLDevice">CLDevice</see></c>
        /// </para>
        /// </summary>
        Device = 0x1091,

        /// <summary>
        /// <para>
        ///     Return the command-queue reference count.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ReferenceCount = 0x1092,

        /// <summary>
        /// <para>
        ///     Return the currently specified properties for the command-queue.
        ///     These properties are specified by the value associated with the
        ///     <c><see cref="QueueProperties.Properties">Properties</see></c> passed in <c>properties</c>
        ///     argument in
        ///     <c><see cref="CL.CreateCommandQueueWithProperties(CLContext, IntPtr, IntPtr, out CLResultCode)">CreateCommandQueueWithProperties()</see></c>,
        ///     or the value of the properties argument in
        ///     <c><see cref="CL.CreateCommandQueue(CLContext, CLDevice, CommandQueueProperties, out CLResultCode)">CreateCommandQueue()</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CommandQueueProperties">CommandQueueProperties</see></c>
        /// </para>
        /// </summary>
        Properties = 0x1093,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Return the properties argument specified in
        ///     <c><see cref="CL.CreateCommandQueueWithProperties(CLContext, IntPtr, IntPtr, out CLResultCode)">CreateCommandQueueWithProperties()</see></c>.
        /// </para>
        /// <para>
        ///     If the properties argument specified in
        ///     <c><see cref="CL.CreateCommandQueueWithProperties(CLContext, IntPtr, IntPtr, out CLResultCode)">CreateCommandQueueWithProperties()</see></c>
        ///     used to create <c>command_queue</c> was not NULL,
        ///     the implementation must return the values specified
        ///     in the properties argument in the same order and without including additional properties.
        /// </para>
        /// <para>
        ///     If <c>command_queue</c> was created using
        ///     <c><see cref="CL.CreateCommandQueue(CLContext, CLDevice, CommandQueueProperties, out CLResultCode)">CreateCommandQueue()</see></c>,
        ///     or if the properties argument specified in
        ///     <c><see cref="CL.CreateCommandQueueWithProperties(CLContext, IntPtr, IntPtr, out CLResultCode)">CreateCommandQueueWithProperties()</see></c>
        ///     was NULL, the implementation must return <c>param_value_size_ret</c> equal to 0,
        ///     indicating that there are no properties to be returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="QueueProperties">QueueProperties[]</see></c>
        /// </para>
        /// </summary>
        PropertiesArray = 0x1098,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Return the size of the device command-queue.
        ///     To be considered valid for this query,
        ///     command_queue must be a device command-queue.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        Size = 0x1094,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.1.</pre></i>
        /// </para>
        /// <para>
        ///     Return the current default command-queue for the underlying device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLCommandQueue">CLCommandQueue</see></c>
        /// </para>
        /// </summary>
        DeviceDefault = 0x1095
    }

    /// <summary>
    ///     Bitfield that describes the properties of a command queue.
    /// </summary>
    [Flags]
    public enum CommandQueueProperties : ulong
    {
        /// <summary>
        ///     Determines whether the commands queued in the command-queue are executed in-order or out-of-order.
        ///     If set, the commands in the command-queue are executed out-of-order.
        ///     Otherwise, commands are executed in-order.
        /// </summary>
        OutOfOrderExecutionModeEnable = 1 << 0,

        /// <summary>
        ///     Enable or disable profiling of commands in the command-queue.
        ///     If set, the profiling of commands is enabled.
        ///     Otherwise profiling of commands is disabled.
        /// </summary>
        ProfilingEnable = 1 << 1,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Indicates that this is a device queue.
        ///     If <c><see cref="OnDevice">OnDevice</see></c> is set,
        ///     <c><see cref="OutOfOrderExecutionModeEnable">OutOfOrderExecutionModeEnable</see></c>
        ///     must also be set.
        /// </para>
        /// </summary>
        OnDevice = 1 << 2,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Indicates that this is the default device queue.
        ///     This can only be used with <c><see cref="OnDevice">OnDevice</see></c>.
        /// </para>
        /// </summary>
        OnDeviceDefault = 1 << 3
    }

    /// <summary>
    /// <para>
    ///     <i><pre>Missing before verison 2.0.</pre></i>
    /// </para>
    /// <para>
    ///     List of supported queue creation properties by
    ///     <c><see cref="CL.CreateCommandQueueWithProperties(CLContext, IntPtr, IntPtr, out CLResultCode)">CreateCommandQueueWithProperties()</see></c>.
    /// </para>
    /// </summary>
    public enum QueueProperties : ulong
    {
        /// <summary>
        /// <para>
        ///     If <c><see cref="Properties">Properties</see></c> is not specified an
        ///     in-order host command-queue is created for the specified device
        /// </para>
        /// <para>
        ///     <i><u>Property Value:</u></i> <c><see cref="CommandQueueProperties">CommandQueueProperties</see></c>
        /// </para>
        /// </summary>
        Properties = 0x1093,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.1.</pre></i>
        /// </para>
        /// <para>
        ///     Specifies the size of the device queue in bytes.
        /// </para>
        /// <para>
        ///     This can only be specified if <c><see cref="CommandQueueProperties.OnDevice">OnDevice</see></c>
        ///     is set in <c><see cref="Properties">Properties</see></c>.
        ///     This must be a value ≤
        ///     <c><see cref="DeviceInfo.QueueOnDeviceMaximumSize">QueueOnDeviceMaximumSize</see></c>.
        /// </para>
        /// <para>
        ///     For best performance, this should be ≤
        ///     <c><see cref="DeviceInfo.QueueOnDevicePreferredSize">QueueOnDevicePreferredSize</see></c>.
        /// </para>
        /// <para>
        ///     If <c><see cref="Size">Size</see></c> is not specified,
        ///     the device queue is created with
        ///     <c><see cref="DeviceInfo.QueueOnDevicePreferredSize">QueueOnDevicePreferredSize</see></c>
        ///     as the size of the queue.
        /// </para>
        /// <para>
        ///     <i><u>Property Value:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        Size = 0x1094
    }

    public enum CommandExecutionStatus : int
    {
        Error = -0x1,
        Complete = 0x0,
        Running = 0x1,
        Submitted = 0x2,
        Queued = 0x3
    }

    #endregion

    #region Memory

    /// <summary>
    /// <para>
    ///     Bit-field that is used to specify allocation and usage
    ///     information about a memory object being created.
    /// </para>
    /// </summary>
    [Flags]
    public enum MemoryFlags : ulong
    {
        /// <summary>
        ///     This flag specifies that the memory object will be read
        ///     and written by a kernel. This is the default.
        /// </summary>
        ReadWrite = 1 << 0,

        /// <summary>
        /// <para>
        ///     This flag specifies that the memory object will be written but not read by a kernel.
        /// </para>
        /// <para>
        ///     Reading from a buffer or image object created with
        ///     <c><see cref="WriteOnly">WriteOnly</see></c> inside a kernel is undefined.
        /// </para>
        /// <para>
        ///     <c><see cref="ReadWrite">ReadWrite</see></c> and <c><see cref="WriteOnly">WriteOnly</see></c>
        ///     are mutually exclusive.
        /// </para>
        /// </summary>
        WriteOnly = 1 << 1,

        /// <summary>
        /// <para>
        ///     This flag specifies that the memory object is a readonly memory object when used inside a kernel.
        /// </para>
        /// <para>
        ///     Writing to a buffer or image object created with <c><see cref="ReadOnly">ReadOnly</see></c>
        ///     inside a kernel is undefined.
        /// </para>
        /// <para>
        ///     <c><see cref="ReadWrite">ReadWrite</see></c>
        ///     or <c><see cref="WriteOnly">WriteOnly</see></c>
        ///     and <c><see cref="ReadOnly">ReadOnly</see></c> are mutually exclusive.
        /// </para>
        /// </summary>
        ReadOnly = 1 << 2,

        /// #TODO: CreateBufferWithProperties() isnt implemented
        /// #TODO: CreateImageWithProperties() isnt implemented
        /// <summary>
        /// <para>
        ///     This flag is valid only if <c>host_ptr</c> is not NULL.
        ///     If specified, it indicates that the application wants the OpenCL
        ///     implementation to use memory referenced by <c>host_ptr</c>
        ///     as the storage bits for the memory object.
        /// </para>
        /// <para>
        ///     The contents of the memory pointed to by <c>host_ptr</c> at the time of the
        ///     <c><see cref="CL.CreateBuffer(CLContext, MemoryFlags, UIntPtr, IntPtr, out CLResultCode)">CreateBuffer()</see></c>,
        ///     <c><see cref="CL.CreateBufferWithProperties()">CreateBufferWithProperties()</see></c>,
        ///     <c><see cref="CL.CreateImage(CLContext, MemoryFlags, ref CLImageFormat, ref CLImageDescription,
        ///     IntPtr, out CLResultCode)">CreateImage()</see></c>,
        ///     <c><see cref="CL.CreateImageWithProperties()">CreateImageWithProperties()</see></c>,
        ///     <c><see cref="CL.CreateImage2D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, IntPtr, out CLResultCode)">CreateImage2D()</see></c>,
        ///     or <c><see cref="CL.CreateImage3D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, UIntPtr, UIntPtr, IntPtr, out CLResultCode)">CreateImage3D()</see></c>
        ///     call define the initial contents of the memory object.
        /// </para>
        /// <para>
        ///     OpenCL implementations are allowed to cache the contents pointed to by <c>host_ptr</c>
        ///     in device memory. This cached copy can be used when kernels are executed on a device.
        /// </para>
        /// <para>
        ///     The result of OpenCL commands that operate on multiple buffer
        ///     objects created with the same <c>host_ptr</c> or from overlapping host
        ///     or SVM regions is considered to be undefined.
        /// </para>
        /// </summary>
        UseHostPtr = 1 << 3,

        /// <summary>
        /// <para>
        ///     This flag specifies that the application wants the OpenCL implementation
        ///     to allocate memory from host accessible memory.
        /// </para>
        /// <para>
        ///     <c><see cref="AllocHostPtr">AllocHostPtr</see></c>
        ///     and <c><see cref="UseHostPtr">UseHostPtr</see></c>
        ///     are mutually exclusive.
        /// </para>
        /// </summary>
        AllocHostPtr = 1 << 4,

        /// #TODO: CreateBufferWithProperties() isnt implemented
        /// #TODO: CreateImageWithProperties() isnt implemented
        /// <summary>
        /// <para>
        ///      This flag is valid only if <c>host_ptr</c> is not NULL.
        ///      If specified, it indicates that the application wants the OpenCL
        ///      implementation to allocate memory for the memory object and
        ///      copy the data from memory referenced by <c>host_ptr</c>.
        ///      The implementation will copy the memory immediately and <c>host_ptr</c>
        ///      is available for reuse by the application when the
        ///      <c><see cref="CL.CreateBuffer(CLContext, MemoryFlags, UIntPtr, IntPtr, out CLResultCode)">CreateBuffer()</see></c>,
        ///     <c><see cref="CL.CreateBufferWithProperties()">CreateBufferWithProperties()</see></c>,
        ///     <c><see cref="CL.CreateImage(CLContext, MemoryFlags, ref CLImageFormat, ref CLImageDescription,
        ///     IntPtr, out CLResultCode)">CreateImage()</see></c>,
        ///     <c><see cref="CL.CreateImageWithProperties()">CreateImageWithProperties()</see></c>,
        ///     <c><see cref="CL.CreateImage2D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, IntPtr, out CLResultCode)">CreateImage2D()</see></c>,
        ///     or <c><see cref="CL.CreateImage3D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, UIntPtr, UIntPtr, IntPtr, out CLResultCode)">CreateImage3D()</see></c>
        ///     operation returns.
        /// </para>
        /// <para>
        ///     <c><see cref="CopyHostPtr">CopyHostPtr</see></c> and
        ///     <c><see cref="UseHostPtr">UseHostPtr</see></c> are mutually exclusive.
        /// </para>
        /// <para>
        ///     <c><see cref="CopyHostPtr">CopyHostPtr</see></c>
        ///     can be used with <c><see cref="AllocHostPtr">AllocHostPtr</see></c>
        ///     to initialize the contents of the <c><b>cl_mem</b></c> object allocated
        ///     using host-accessible (e.g. PCIe) memory.
        /// </para>
        /// </summary>
        CopyHostPtr = 1 << 5,

        // Reserved = 1 << 6,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This flag specifies that the host will only write to the memory
        ///     object (using OpenCL APIs that enqueue a write or a map for write).
        ///     This can be used to optimize write access from the host
        ///     (e.g. enable write-combined allocations for memory objects for devices
        ///     that communicate with the host over a system bus such as PCIe).
        /// </para>
        /// </summary>
        HostWriteOnly = 1 << 7,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This flag specifies that the host will only read the memory object
        ///     (using OpenCL APIs that enqueue a read or a map for read).
        /// </para>
        /// <para>
        ///     <c><see cref="HostWriteOnly">HostWriteOnly</see></c>
        ///     and <c><see cref="HostReadOnly">HostReadOnly</see></c> are mutually exclusive.
        /// </para>
        /// </summary>
        HostReadOnly = 1 << 8,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This flag specifies that the host will not read or write the memory object.
        /// </para>
        /// <para>
        ///     <c><see cref="HostWriteOnly">HostWriteOnly</see></c>
        ///     or <c><see cref="HostReadOnly">HostReadOnly</see></c> and
        ///     <c><see cref="HostNoAccess">HostNoAccess</see></c>
        ///     are mutually exclusive.
        /// </para>
        /// </summary>
        HostNoAccess = 1 << 9,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Only used in
        ///     <c><see cref="CL.SVMAlloc(CLContext, MemoryFlags, UIntPtr, uint)"/></c>
        /// </para>
        /// <para>
        ///     This specifies that the application wants the OpenCL implementation to do a fine-grained allocation.
        /// </para>
        /// </summary>
        SvmFineGrainBuffer = 1 << 10,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Only used in
        ///     <c><see cref="CL.SVMAlloc(CLContext, MemoryFlags, UIntPtr, uint)"/></c>
        /// </para>
        /// <para>
        ///     This flag is valid only if <c><see cref="SvmFineGrainBuffer">SvmFineGrainBuffer</see></c>
        ///     is specified in flags. It is used to indicate that SVM atomic operations
        ///     can control visibility of memory accesses in this SVM buffer.
        /// </para>
        /// </summary>
        SvmAtomics = 1 << 11,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     This flag is only used by
        ///     <c><see cref="CL.GetSupportedImageFormats(CLContext, MemoryFlags,
        ///     MemoryObjectType, out CLImageFormat[])">GetSupportedImageFormats()</see></c>
        ///     to query image formats that may be both read from and written to by the same kernel instance.
        ///     To create a memory object that may be read from and written to use
        ///     <c><see cref="ReadWrite">ReadWrite</see></c>.
        /// </para>
        /// </summary>
        KernelReadAndWrite = 1 << 12,
    }

    /// <summary>
    ///     Describes the type of memory a object.
    /// </summary>
    public enum MemoryObjectType : uint
    {
        /// #TODO: CreateBufferWithProperties() isnt implemented
        /// <summary>
        ///     <c><see cref="CLBuffer"/></c> memory object created using
        ///     <c><see cref="CL.CreateBuffer(CLContext, MemoryFlags,
        ///     UIntPtr, IntPtr, out CLResultCode)">CreateBuffer()</see></c>,
        ///     <c><see cref="CL.CreateBufferWithProperties()">CreateBufferWithProperties()</see></c>
        ///     or <c><see cref="CL.CreateSubBuffer(CLBuffer, MemoryFlags,
        ///     BufferCreateType, IntPtr, out CLResultCode)">CreateSubBuffer()</see></c>
        /// </summary>
        Buffer = 0x10F0,

        /// <summary>
        ///     <c><see cref="CLImage"/></c> memory object created using
        ///     <c><see cref="CL.CreateImage2D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, IntPtr, out CLResultCode)">CreateImage2D()</see></c>.
        /// </summary>
        Image2D = 0x10F1,

        /// <summary>
        ///     <c><see cref="CLImage"/></c> memory object created using
        ///     <c><see cref="CL.CreateImage3D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, UIntPtr, UIntPtr, IntPtr, out CLResultCode)">CreateImage3D()</see></c>.
        /// </summary>
        Image3D = 0x10F2,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Array of 2D <c><see cref="CLImage"/></c> memory objects.
        /// </para>
        /// </summary>
        Image2DArray = 0x10F3,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     <c><see cref="CLImage"/></c> memory object stored as a single
        ///     scanline which is a linear sequence of adjacent elements.
        /// </para>
        /// </summary>
        Image1D = 0x10F4,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Array of 1D <c><see cref="CLImage"/></c> memory objects.
        /// </para>
        /// </summary>
        Image1DArray = 0x10F5,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     1D <c><see cref="CLImage"/></c> memory objects created from a <c><see cref="CLBuffer"/></c>.
        /// </para>
        /// </summary>
        Image1DBuffer = 0x10F6,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     <c><see cref="CLPipe"/></c> memory object created using
        ///     <c><see cref="CL.CreatePipe(CLContext, MemoryFlags, uint, uint,
        ///     IntPtr[], out CLResultCode)">CreatePipe()</see></c>.
        /// </para>
        /// </summary>
        Pipe = 0x10F7
    }

    /// <summary>
    /// <para>
    ///     Specifies the information to query using
    ///     <c><see cref="CL.GetMemObjectInfo(ICLMemoryObject, MemoryObjectInfo, out byte[])"/></c>.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#mem-info-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum MemoryObjectInfo : uint
    {
        /// #TODO: CreateImageWithProperties() isnt implemented
        /// <summary>
        /// <para>
        ///     Returns the type of the memory object queried
        /// </para>
        /// <para>
        ///     The value of <c><see cref="CLImageDescription.ImageType"/></c> if object is created with
        ///     <c><see cref="CL.CreateImage(CLContext, MemoryFlags, ref CLImageFormat, ref CLImageDescription,
        ///     IntPtr, out CLResultCode)">CreateImage()</see></c> or
        ///     <c><see cref="CL.CreateImageWithProperties()">CreateImageWithProperties()</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="MemoryObjectType">MemoryObjectType</see></c>
        /// </para>
        /// </summary>
        Type = 0x1100,

        /// #TODO: CreateImageWithProperties() isnt implemented
        /// #TODO: CreateBufferWithProperties() isnt implemented
        /// <summary>
        /// <para>
        ///     Return the flags argument value specified when <c>memobj</c> is created with
        ///     <c><see cref="CL.CreateBuffer(CLContext, MemoryFlags, UIntPtr,
        ///     IntPtr, out CLResultCode)">CreateBuffer()</see></c>,
        ///     <c><see cref="CL.CreateBufferWithProperties()">CreateBufferWithProperties()</see></c>,
        ///     <c><see cref="CL.CreateSubBuffer(CLBuffer, MemoryFlags, BufferCreateType,
        ///     IntPtr, out CLResultCode)">CreateSubBuffer()</see></c>,
        ///     <c><see cref="CL.CreateImage(CLContext, MemoryFlags, ref CLImageFormat, ref CLImageDescription,
        ///     IntPtr, out CLResultCode)">CreateImage()</see></c>,
        ///     <c><see cref="CL.CreateImageWithProperties()">CreateImageWithProperties()</see></c>,
        ///     <c><see cref="CL.CreateImage2D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, IntPtr, out CLResultCode)">CreateImage2D()</see></c>,
        ///     <c><see cref="CL.CreateImage3D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, UIntPtr, UIntPtr,
        ///     IntPtr, out CLResultCode)">CreateImage3D()</see></c>, or
        ///     <c><see cref="CL.CreatePipe(CLContext, MemoryFlags, uint, uint,
        ///     IntPtr[], out CLResultCode)">CreatePipe()</see></c>.
        /// </para>
        /// <para>
        ///     If <c>memobj</c> is a sub-buffer the memory access qualifiers
        ///     inherited from parent buffer is also returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="MemoryFlags">MemoryFlags</see></c>
        /// </para>
        /// </summary>
        Flags = 0x1101,

        /// <summary>
        /// <para>
        ///     Return actual size of the data store associated with <c>memobj</c> in bytes.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        Size = 0x1102,

        /// #TODO: CreateImageWithProperties() isnt implemented
        /// #TODO: CreateBufferWithProperties() isnt implemented
        /// <summary>
        /// <para>
        ///     If <c>memobj</c> is created with <c><see cref="CL.CreateBuffer(CLContext, MemoryFlags, UIntPtr,
        ///     IntPtr, out CLResultCode)">CreateBuffer()</see></c>,
        ///     <c><see cref="CL.CreateBufferWithProperties()">CreateBufferWithProperties()</see></c>,
        ///     <c><see cref="CL.CreateImage(CLContext, MemoryFlags, ref CLImageFormat, ref CLImageDescription,
        ///     IntPtr, out CLResultCode)">CreateImage()</see></c>,
        ///     <c><see cref="CL.CreateImageWithProperties()">CreateImageWithProperties()</see></c>,
        ///     <c><see cref="CL.CreateImage2D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, IntPtr, out CLResultCode)">CreateImage2D()</see></c>,
        ///     or <c><see cref="CL.CreateImage3D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, UIntPtr, UIntPtr,
        ///     IntPtr, out CLResultCode)">CreateImage3D()</see></c>,
        ///     and <c><see cref="MemoryFlags.UseHostPtr">UseHostPtr</see></c> is specified in
        ///     <c>mem_flags</c>, return the <c>host_ptr</c> argument value specified when <c>memobj</c> is created.
        /// </para>
        /// <para>
        ///     Otherwise, if <c>memobj</c> is created with
        ///     <c><see cref="CL.CreateSubBuffer(CLBuffer, MemoryFlags, BufferCreateType,
        ///     IntPtr, out CLResultCode)">CreateSubBuffer()</see></c>,
        ///     and <c>memobj</c> is created from a buffer that was created with
        ///     <c><see cref="MemoryFlags.UseHostPtr">UseHostPtr</see></c>
        ///     specified in <c>mem_flags</c>, return the <c>host_ptr</c>
        ///     passed to <c><see cref="CL.CreateBuffer(CLContext, MemoryFlags, UIntPtr,
        ///     IntPtr, out CLResultCode)">CreateBuffer()</see></c> or
        ///     <c><see cref="CL.CreateBufferWithProperties()">CreateBufferWithProperties()</see></c>,
        ///     plus the origin value specified in <c>buffer_create_info</c> when <c>memobj</c> is created.
        /// </para>
        /// <para>
        ///     Otherwise, returns NULL.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr (void *)</c>
        /// </para>
        /// </summary>
        HostPointer = 0x1103,

        /// <summary>
        /// <para>
        ///     Map count.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MapCount = 0x1104,

        /// <summary>
        /// <para>
        ///     Return <c>memobj</c> reference count.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ReferenceCount = 0x1105,

        /// <summary>
        /// <para>
        ///     Return context specified when memory object is created.
        ///     If <c>memobj</c> is created using
        ///     <c><see cref="CL.CreateSubBuffer(CLBuffer, MemoryFlags, BufferCreateType,
        ///     IntPtr, out CLResultCode)">CreateSubBuffer()</see></c>,
        ///     the context associated with the memory object specified as the buffer argument
        ///     to <c><see cref="CL.CreateSubBuffer(CLBuffer, MemoryFlags, BufferCreateType,
        ///     IntPtr, out CLResultCode)">CreateSubBuffer()</see></c> is returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLContext">CLContext</see></c>
        /// </para>
        /// </summary>
        Context = 0x1106,

        /// #TODO: CreateImageWithProperties() isnt implemented
        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     Return memory object from which <c>memobj</c> is created.
        /// </para>
        /// <para>
        ///     This returns the memory object specified as buffer argument
        ///     to <c><see cref="CL.CreateSubBuffer(CLBuffer, MemoryFlags, BufferCreateType,
        ///     IntPtr, out CLResultCode)">CreateSubBuffer()</see></c> if <c>memobj</c>
        ///     is a subbuffer object created using to
        ///     <c><see cref="CL.CreateSubBuffer(CLBuffer, MemoryFlags, BufferCreateType,
        ///     IntPtr, out CLResultCode)">CreateSubBuffer()</see></c>.
        /// </para>
        /// <para>
        ///     This returns <c><see cref="CLImageDescription.MemoryObject"/></c> if
        ///     <c>memobj</c> is an image object created using
        ///     <c><see cref="CL.CreateImage(CLContext, MemoryFlags, ref CLImageFormat, ref CLImageDescription,
        ///     IntPtr, out CLResultCode)">CreateImage()</see></c>
        ///     or <c><see cref="CL.CreateImageWithProperties()">CreateImageWithProperties()</see></c>.
        /// </para>
        /// <para>
        ///     Otherwise, returns NULL.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="ICLMemoryObject">ICLMemoryObject</see></c>
        /// </para>
        /// </summary>
        AssociatedMemoryObject = 0x1107,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     Return offset if <c>memobj</c>
        ///     is a sub-buffer object created using
        ///     <c><see cref="CL.CreateSubBuffer(CLBuffer, MemoryFlags, BufferCreateType,
        ///     IntPtr, out CLResultCode)">CreateSubBuffer()</see></c>.
        /// </para>
        /// <para>
        ///     This return 0 if <c>memobj</c> is not a subbuffer object.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        Offset = 0x1108,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Return TRUE if <c>memobj</c> is a buffer object that
        ///     was created with <c><see cref="MemoryFlags.UseHostPtr">UseHostPtr</see></c>
        ///     or is a sub-buffer object of a buffer object that was created
        ///     with <c><see cref="MemoryFlags.UseHostPtr">UseHostPtr</see></c> and the
        ///    <c>host_ptr</c> specified when the buffer object was created is a SVM pointer;
        ///    otherwise returns FALSE.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        UsesSvmPointer = 0x1109,

        /// #TODO: CreateImageWithProperties() isnt implemented
        /// #TODO: CreateBufferWithProperties() isnt implemented
        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Return the properties argument specified in
        ///     <c><see cref="CL.CreateBufferWithProperties()">CreateBufferWithProperties()</see></c> or
        ///     <c><see cref="CL.CreateImageWithProperties()">CreateImageWithProperties()</see></c>.
        /// </para>
        /// <para>
        ///     If the properties argument specified in
        ///     <c><see cref="CL.CreateBufferWithProperties()">CreateBufferWithProperties()</see></c>
        ///     or <c><see cref="CL.CreateImageWithProperties()">CreateImageWithProperties()</see></c>
        ///     used to create <c>memobj</c> was not NULL,
        ///     the implementation must return the values specified in the properties
        ///     argument in the same order and without including additional properties.
        /// </para>
        /// <para>
        ///     If <c>memobj</c> was created using
        ///     <c><see cref="CL.CreateBuffer(CLContext, MemoryFlags, UIntPtr,
        ///     IntPtr, out CLResultCode)">CreateBuffer()</see></c>,
        ///     <c><see cref="CL.CreateSubBuffer(CLBuffer, MemoryFlags, BufferCreateType,
        ///     IntPtr, out CLResultCode)">CreateSubBuffer()</see></c>,
        ///     <c><see cref="CL.CreateImage(CLContext, MemoryFlags, ref CLImageFormat, ref CLImageDescription,
        ///     IntPtr, out CLResultCode)">CreateImage()</see></c>,
        ///     <c><see cref="CL.CreateImage2D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, IntPtr, out CLResultCode)">CreateImage2D()</see></c>,
        ///     or <c><see cref="CL.CreateImage3D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, UIntPtr, UIntPtr,
        ///     IntPtr, out CLResultCode)">CreateImage3D()</see></c>,
        ///     or if the properties argument specified in
        ///     <c><see cref="CL.CreateBufferWithProperties()">CreateBufferWithProperties()</see></c>
        ///     or <c><see cref="CL.CreateImageWithProperties()">CreateImageWithProperties()</see></c>
        ///     was NULL, the implementation must return <c>param_value_size_ret</c> equal to 0,
        ///     indicating that there are no properties to be returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="OpenCL.MemoryProperties">MemoryProperties[]</see></c>
        /// </para>
        /// </summary>
        Properties = 0x110A
    }

    /// <summary>
    /// <para>
    ///     <i><pre>Missing before verison 1.2.</pre></i>
    /// </para>
    /// <para>
    ///     Bit-field used to specify memory migration options.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#migration-flags-table">here</see></u></b>.
    /// </para>
    /// </summary>
    [Flags]
    public enum MemoryMigrationFlags : ulong
    {
        /// <summary>
        ///     This flag indicates that the specified set of memory objects
        ///     are to be migrated to the host, regardless of the target command-queue.
        /// </summary>
        Host = 1 << 0,

        /// <summary>
        ///     This flag indicates that the contents of the set of memory
        ///     objects are undefined after migration. The specified set of memory
        ///     objects are migrated to the device associated with
        ///     <c>command_queue</c> without incurring the overhead of migrating their contents.
        /// </summary>
        ContentUndefined = 1 << 1
    }

    public enum MemoryProperties : ulong
    {
    }
    #endregion

    #region Image

    /// <summary>
    /// <para>
    ///     Specifies the information to query using
    ///     <c><see cref="CL.GetImageInfo(CLImage, ImageInfo, out byte[])">GetImageInfo()</see></c>.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#image-info-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum ImageInfo : uint
    {
        /// <summary>
        /// <para>
        ///     Return the image format descriptor specified when image is created with
        ///     <c><see cref="CL.CreateImage(CLContext, MemoryFlags, ref CLImageFormat, ref CLImageDescription,
        ///     IntPtr, out CLResultCode)">CreateImage()</see></c>,
        ///     <c><see cref="CL.CreateImageWithProperties()">CreateImageWithProperties()</see></c>,
        ///     <c><see cref="CL.CreateImage2D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, IntPtr, out CLResultCode)">CreateImage2D()</see></c> or
        ///     <c><see cref="CL.CreateImage3D(CLContext, MemoryFlags, ref CLImageFormat,
        ///     UIntPtr, UIntPtr, UIntPtr, UIntPtr, UIntPtr,
        ///     IntPtr, out CLResultCode)">CreateImage3D()</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLImageFormat">CLImageFormat</see></c>
        /// </para>
        /// </summary>
        Format = 0x1110,

        /// <summary>
        /// <para>
        ///     Return size of each element of the image memory object given by image in bytes.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        ElementSize = 0x1111,

        /// <summary>
        /// <para>
        ///     Returns the row pitch in bytes of a row of elements of the image object given by image.
        /// </para>
        /// <para>
        ///     If image was created with a non-zero value for <c>image_row_pitch</c>,
        ///     then the value provided for <c>image_row_pitch</c> by the application is returned,
        ///     otherwise the returned value is calculated as <c><see cref="Width">Width</see></c> ×
        ///     <c><see cref="ElementSize">ElementSize</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        RowPitch = 0x1112,

        /// <summary>
        /// <para>
        ///     Returns the slice pitch in bytes of a 2D slice for the 3D image object or size
        ///     of each image in a 1D or 2D image array given by image.
        /// </para>
        /// <para>
        ///     If image was created with a non-zero value for <c>image_slice_pitch</c>
        ///     then the value provided for <c>image_slice_pitch</c> by the application is returned,
        ///     otherwise the returned value is calculated as:
        /// </para>
        /// <list type="bullet">
        /// <item>
        ///     <description>
        ///         <c><see cref="RowPitch">RowPitch</see></c> for 1D image arrays.
        ///     </description>
        /// </item>
        /// <item>
        ///     <description>
        ///         <c><see cref="Height">Height</see></c> × <c><see cref="RowPitch">RowPitch</see></c>
        ///         for 3D images and 2D image arrays.
        ///     </description>
        /// </item>
        /// </list>
        /// <para>
        ///     For a 1D image, 1D image buffer and 2D image object return 0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        SlicePitch = 0x1113,

        /// <summary>
        /// <para>
        ///     Return width of the image in pixels.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        Width = 0x1114,

        /// <summary>
        /// <para>
        ///     Return height of the image in pixels.
        ///     For a 1D image, 1D image buffer and 1D image array object, height = 0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        Height = 0x1115,

        /// <summary>
        /// <para>
        ///     Return depth of the image in pixels.
        ///     For a 1D image, 1D image buffer, 2D image or 1D and 2D image array object, depth = 0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        Depth = 0x1116,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Return number of images in the image array. If image is not an image array, 0 is returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        ArraySize = 0x1117,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2. and deprecated by version 2.0</pre></i>
        /// </para>
        /// <para>
        ///     Return buffer object associated with image.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="ICLMemoryObject">ICLMemoryObject</see></c>
        /// </para>
        /// </summary>
        Buffer = 0x1118,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Return <c><see cref="CLImageDescription.MipLevels">MipLevels</see></c> associated with image.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        NumberOfMipLevels = 0x1119,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Return <c><see cref="CLImageDescription.Samples">Samples</see></c> associated with image.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        NumberOfSamples = 0x111A
    }

    /// <summary>
    /// <para>
    ///     Specifies the number of channels and the channel layout i.e. the memory layout in which channels are stored an image.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#image-channel-order-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum ChannelOrder : uint
    {
        /// <summary>
        ///     Single channel image formats where the single channel represents a <b>RED</b> component
        /// </summary>
        R = 0x10B0,

        /// <summary>
        ///     Single channel image formats where the single channel represents an <b>ALPHA</b> component
        /// </summary>
        A = 0x10B1,

        /// <summary>
        ///     Two channel image formats. The first channel represents a <b>RED</b> component.
        ///     The second channel represents a <b>GREEN</b> component.
        /// </summary>
        Rg = 0x10B2,

        /// <summary>
        ///     Two channel image formats. The first channel represents a <b>RED</b> component.
        ///     The second channel represents an <b>ALPHA</b> component.
        /// </summary>
        Ra = 0x10B3,

        /// <summary>
        ///     A three channel image format, where the three channels represent <b>RED</b>,
        ///     <b>GREEN</b>, and <b>BLUE</b> components.
        /// </summary>
        Rgb = 0x10B4,

        /// <summary>
        ///     Four channel image formats, where the four channels represent <b>RED</b>,
        ///     <b>GREEN</b>, <b>BLUE</b>, and <b>ALPHA</b> components.
        /// </summary>
        Rgba = 0x10B5,

        /// <inheritdoc cref="Rgba"/>
        Bgra = 0x10B6,

        /// <inheritdoc cref="Rgba"/>
        Argb = 0x10B7,

        /// <summary>
        ///     A single channel image format where the single channel represents an
        ///     <b>INTENSITY</b> value. The <b>INTENSITY</b> value is replicated
        ///     into the <b>RED</b>, <b>GREEN</b>, <b>BLUE</b>, and <b>ALPHA</b> components.
        /// </summary>
        Intensity = 0x10B8,

        /// <summary>
        ///     A single channel image format where the single channel represents a
        ///     <b>LUMINANCE</b> value. The <b>LUMINANCE</b> value is replicated into the
        ///     <b>RED</b>, <b>GREEN</b> and <b>BLUE</b> components.
        /// </summary>
        Luminance = 0x10B9,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     A two channel image format, where the first channel represents
        ///     a <b>RED</b> component and the second channel is ignored.
        /// </para>
        /// </summary>
        Rx = 0x10BA,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     A three channel image format, where the first two channels represent
        ///     <b>RED</b> and <b>GREEN</b> components and the third channel is ignored.
        /// </para>
        /// </summary>
        Rgx = 0x10BB,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.1.</pre></i>
        /// </para>
        /// <para>
        ///     A four channel image format, where the first three channels represent
        ///     <b>RED</b>, <b>GREEN</b> and <b>BLUE</b> components and the fourth channel is ignored.
        /// </para>
        /// </summary>
        Rgbx = 0x10BC,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     A single channel image format where the single channel represents a <b>DEPTH</b> component.
        /// </para>
        /// </summary>
        Depth = 0x10BD,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     A three channel image format, where the three channels represent
        ///     <b>RED</b>, <b>GREEN</b> and <b>BLUE</b> components in the sRGB color space.
        /// </para>
        /// </summary>
        Srgb = 0x10BF,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     A four channel image format, where the three channels represent
        ///     <b>RED</b>, <b>GREEN</b> and <b>BLUE</b> components in the sRGB color space.
        ///     The fourth channel is ignored.
        /// </para>
        /// </summary>
        Srgbx = 0x10C0,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Four channel image formats, where the first three channels represent
        ///     <b>RED</b>, <b>GREEN</b> and <b>BLUE</b> components in the sRGB color space.
        ///     The fourth channel represents an <b>ALPHA</b> component.
        /// </para>
        /// </summary>
        Srgba = 0x10C1,

        /// <inheritdoc cref="Srgba"/>
        Sbgra = 0x10C2,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Four channel image formats, where the four channels represent <b>RED</b>,
        ///     <b>GREEN</b>, <b>BLUE</b>, and <b>ALPHA</b> components.
        /// </para>
        /// </summary>
        Abgr = 0x10C3
    }

    /// <summary>
    /// <para>
    ///     Describes the size of the channel data type.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#image-channel-data-types-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum ChannelType : uint
    {
        /// <summary>
        ///     Each channel component is a normalized signed 8-bit integer value.
        /// </summary>
        NormalizedSignedInteger8 = 0x10D0,

        /// <summary>
        ///     Each channel component is a normalized signed 16-bit integer value.
        /// </summary>
        NormalizedSignedInteger16 = 0x10D1,

        /// <summary>
        ///     Each channel component is a normalized unsigned 8-bit integer value.
        /// </summary>
        NormalizedUnsignedInteger8 = 0x10D2,

        /// <summary>
        ///     Each channel component is a normalized unsigned 16-bit integer value.
        /// </summary>
        NormalizedUnsignedInteger16 = 0x10D3,

        /// <summary>
        ///     Represents a normalized 5-6-5 3-channel RGB image. The channel order must be
        ///     <c><see cref="ChannelOrder.Rgb">Rgb</see></c> or <c><see cref="ChannelOrder.Rgbx">Rgbx</see></c>.
        /// </summary>
        NormalizedUnsignedShortFloat565 = 0x10D4,

        /// <summary>
        ///     Represents a normalized x-5-5-5 4-channel xRGB image. The channel order must be
        ///     <c><see cref="ChannelOrder.Rgb">Rgb</see></c> or <c><see cref="ChannelOrder.Rgbx">Rgbx</see></c>.
        /// </summary>
        NormalizedUnsignedShortFloat555 = 0x10D5,

        /// <summary>
        ///     Represents a normalized x-10-10-10 4-channel xRGB image. The channel order must be
        ///     <c><see cref="ChannelOrder.Rgb">Rgb</see></c> or <c><see cref="ChannelOrder.Rgbx">Rgbx</see></c>.
        /// </summary>
        NormalizedUnsignedInteger101010 = 0x10D6,

        /// <summary>
        ///     Each channel component is an unnormalized signed 8-bit integer value.
        /// </summary>
        SignedInteger8 = 0x10D7,

        /// <summary>
        ///     Each channel component is an unnormalized signed 16-bit integer value.
        /// </summary>
        SignedInteger16 = 0x10D8,

        /// <summary>
        ///     Each channel component is an unnormalized signed 32-bit integer value.
        /// </summary>
        SignedInteger32 = 0x10D9,

        /// <summary>
        ///     Each channel component is an unnormalized unsigned 8-bit integer value.
        /// </summary>
        UnsignedInteger8 = 0x10DA,

        /// <summary>
        ///     Each channel component is an unnormalized unsigned 16-bit integer value.
        /// </summary>
        UnsignedInteger16 = 0x10DB,

        /// <summary>
        ///     Each channel component is an unnormalized unsigned 32-bit integer value.
        /// </summary>
        UnsignedInteger32 = 0x10DC,

        /// <summary>
        ///     Each channel component is a 16-bit half-float value´.
        /// </summary>
        HalfFloat = 0x10DD,

        /// <summary>
        ///     Each channel component is a single precision floating-point value.
        /// </summary>
        Float = 0x10DE,

        /// <summary>
        ///     Represents a normalized 10-10-10-2 four-channel RGBA image.
        ///     The channel order must be <c><see cref="ChannelOrder.Rgba">Rgba</see></c>.
        /// </summary>
        NormalizedUnsignedInteger101010Version2 = 0x10E0
    }

    #endregion

    #region Buffer
    public enum BufferCreateType : uint
    {
        Region = 0x1220
    }

    #endregion

    #region Pipe

    /// <summary>
    /// <para>
    ///     Specifies the information to query using
    ///     <c><see cref="CL.GetPipeInfo(CLPipe, PipeInfo, out byte[])">GetPipeInfo()</see></c>.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#pipe-info-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum PipeInfo : uint
    {
        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Return pipe packet size specified when pipe is created with
        ///     <c><see cref="CL.CreatePipe(CLContext, MemoryFlags, uint, uint,
        ///     IntPtr[], out CLResultCode)">CreatePipe()</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        PacketSize = 0x1120,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     Return maximum number of packets specified when pipe is created with
        ///     <c><see cref="CL.CreatePipe(CLContext, MemoryFlags, uint, uint,
        ///     IntPtr[], out CLResultCode)">CreatePipe()</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        MaximumNumberOfPackets = 0x1121,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Return the properties argument specified in
        ///     <c><see cref="CL.CreatePipe(CLContext, MemoryFlags, uint, uint,
        ///     IntPtr[], out CLResultCode)">CreatePipe()</see></c>.
        /// </para>
        /// <para>
        ///     If the properties argument specified in
        ///     <c><see cref="CL.CreatePipe(CLContext, MemoryFlags, uint, uint,
        ///     IntPtr[], out CLResultCode)">CreatePipe()</see></c>
        ///     used to create pipe was not NULL,
        ///     the implementation must return the values specified in the properties
        ///     argument in the same order and without including additional properties.
        /// </para>
        /// <para>
        ///     If the properties argument specified in
        ///     <c><see cref="CL.CreatePipe(CLContext, MemoryFlags, uint, uint,
        ///     IntPtr[], out CLResultCode)">CreatePipe()</see></c>
        ///     used to create pipe was NULL, the implementation must return <c>param_value_size_ret</c>
        ///     equal to 0, indicating that there are no properties to be returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="PipeProperties">PipeProperties[]</see></c>
        /// </para>
        /// </summary>
        Properties = 0x1122
    }

    public enum PipeProperties : ulong
    {
    }

    #endregion

    #region Sampler

    /// <summary>
    /// <para>
    ///     Specifies the information to query using
    ///     <c><see cref="CL.GetSamplerInfo(CLSampler, SamplerInfo, out byte[])">GetSamplerInfo()</see></c>.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#sampler-info-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum SamplerInfo : uint
    {
        /// <summary>
        /// <para>
        ///     Return the sampler reference count.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ReferenceCount = 0x1150,

        /// <summary>
        /// <para>
        ///     Return the context specified when the sampler is created.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLContext">CLContext</see></c>
        /// </para>
        /// </summary>
        Context = 0x1151,

        /// <summary>
        /// <para>
        ///     Return the normalized coords value associated with sampler.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        NormalizedCoordinates = 0x1152,

        /// <summary>
        /// <para>
        ///     Return the addressing mode value associated with sampler.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="OpenCL.AddressingMode">AddressingMode</see></c>
        /// </para>
        /// </summary>
        AddressingMode = 0x1153,

        /// <summary>
        /// <para>
        ///     Return the filter mode value associated with sampler.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="OpenCL.FilterMode">FilterMode</see></c>
        /// </para>
        /// </summary>
        FilterMode = 0x1154,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     Return the properties argument specified in
        ///     <c><see cref="CL.CreateSamplerWithProperties(CLContext,
        ///     IntPtr, out CLResultCode)">CreateSamplerWithProperties()</see></c>.
        /// </para>
        /// <para>
        ///     If the properties argument specified in
        ///     <c><see cref="CL.CreateSamplerWithProperties(CLContext,
        ///     IntPtr, out CLResultCode)">CreateSamplerWithProperties()</see></c>
        ///     used to create sampler was not NULL, the implementation must return
        ///     the values specified in the properties argument in the same order
        ///     and without including additional properties.
        /// </para>
        /// <para>
        ///     If sampler was created using  <c><see cref="CL.CreateSampler(CLContext, uint,
        ///     OpenCL.AddressingMode, OpenCL.FilterMode, out CLResultCode)">CreateSampler()</see></c>,
        ///     or if the properties argument specified in
        ///     <c><see cref="CL.CreateSamplerWithProperties(CLContext,
        ///     IntPtr, out CLResultCode)">CreateSamplerWithProperties()</see></c>
        ///     was NULL, the implementation must return <c>param_value_size_ret</c> equal to 0,
        ///     indicating that there are no properties to be returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="SamplerProperties">SamplerProperties[]</see></c>
        /// </para>
        /// </summary>
        Properties = 0x1158
    }

    /// <summary>
    ///     Specifies the type of filter that is applied when reading an image.
    /// </summary>
    public enum FilterMode : uint
    {
        /// <summary>
        ///     Returns the image element nearest to the image coordinate.
        /// </summary>
        Nearest = 0x1140,

        /// <summary>
        ///     Returns a weighted average of the four image elements nearest to the image coordinate.
        /// </summary>
        Linear = 0x1141
    }

    /// <summary>
    ///     Specifies how out-of-range image coordinates are handled when reading from an image.
    /// </summary>
    public enum AddressingMode : uint
    {
        /// <summary>
        ///     Behavior is undefined for out-of-range image coordinates.
        /// </summary>
        None = 0x1130,

        /// <summary>
        ///     Out-of-range image coordinates are clamped to the edge of the image.
        /// </summary>
        ClampToEdge = 0x1131,

        /// <summary>
        ///     Out-of-range image coordinates are assigned a border color value.
        /// </summary>
        Clamp = 0x1132,

        /// <summary>
        ///     Out-of-range image coordinates read from the image as if
        ///     the image data were replicated in all dimensions.
        /// </summary>
        Repeat = 0x1133,

        /// <summary>
        ///     Out-of-range image coordinates read from the image as if the image
        ///     data were replicated in all dimensions, mirroring the image
        ///     contents at the edge of each replication.
        /// </summary>
        MirroredRepeat = 0x1134
    }

    /// <summary>
    /// <para>
    ///     Specifies a list of sampler property names.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#sampler-properties-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum SamplerProperties : ulong
    {
        /// <summary>
        /// <para>
        ///     A boolean value that specifies whether the image coordinates specified are normalized or not.
        ///     The default value (i.e. the value used if this property is not specified in sampler_properties) is TRUE.
        /// </para>
        /// <para>
        ///     <i><u>Property Value:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        NormalizedCoords = 0x1152,

        /// <summary>
        /// <para>
        ///     Specifies how out-of-range image coordinates are handled when reading from an image.
        ///     The default is <c><see cref="AddressingMode.Clamp">Clamp</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Property Value:</u></i> <c><see cref="OpenCL.AddressingMode">AddressingMode</see></c>
        /// </para>
        /// </summary>
        AddressingMode = 0x1153,

        /// <summary>
        /// <para>
        ///     Specifies the type of filter that is applied when reading an image.
        ///     The default value is <c><see cref="FilterMode.Nearest">Nearest</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Property Value:</u></i> <c><see cref="OpenCL.FilterMode">FilterMode</see></c>
        /// </para>
        /// </summary>
        FilterMode = 0x1154
    }

    #endregion

    #region Program

    /// <summary>
    /// <para>
    ///     Specifies the information to query using
    ///     <c><see cref="CL.GetPlatformInfo(CLPlatform, PlatformInfo,
    ///     UIntPtr, byte[], out UIntPtr)">GetPlatformInfo()</see></c>.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#program-info-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum ProgramInfo : uint
    {
        /// <summary>
        /// <para>
        ///     Return the program reference count.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ReferenceCount = 0x1160,

        /// <summary>
        /// <para>
        ///     Return the context specified when the program object is created.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLContext">CLContext</see></c>
        /// </para>
        /// </summary>
        Context = 0x1161,

        /// <summary>
        /// <para>
        ///     Return the number of devices associated with program.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        NumberOfDevices = 0x1162,

        /// <summary>
        /// <para>
        ///     Return the list of devices associated with the program object.
        ///     This can be the devices associated with context on which the
        ///     program object has been created or can be a subset of devices
        ///     that are specified when a program object is created using
        ///     <c><see cref="CL.CreateProgramWithBinary(CLContext, uint, IntPtr[], UIntPtr[],
        ///     IntPtr[], out CLResultCode[], out CLResultCode)">CreateProgramWithBinary()</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLDevice">CLDevice[]</see></c>
        /// </para>
        /// </summary>
        Devices = 0x1163,

        /// <summary>
        /// <para>
        ///     Return the program source code specified by
        ///     <c><see cref="CL.CreateProgramWithSource(CLContext, string, out CLResultCode)">
        ///     CreateProgramWithSource()</see></c>.
        ///     The source string returned is a concatenation of all source strings specified to
        ///     <c><see cref="CL.CreateProgramWithSource(CLContext, string, out CLResultCode)">
        ///     CreateProgramWithSource()</see></c> with a null terminator.
        ///     The concatenation strips any nulls in the original source strings.
        /// </para>
        /// <para>
        ///     Return the program source code specified by
        ///     <c><see cref="CL.CreateProgramWithSource(CLContext, string, out CLResultCode)">
        ///     CreateProgramWithSource()</see></c>. The source string returned
        ///     is a concatenation of all source strings specified to
        ///     <c><see cref="CL.CreateProgramWithSource(CLContext, string, out CLResultCode)">
        ///     CreateProgramWithSource()</see></c> with a null terminator.
        ///     The concatenation strips any nulls in the original source strings.
        ///     If program is created using
        ///     <c><see cref="CL.CreateProgramWithBinary(CLContext, uint, IntPtr[], UIntPtr[],
        ///     IntPtr[], out CLResultCode[], out CLResultCode)">CreateProgramWithBinary()</see></c>,
        ///     <c><see cref="CL.CreateProgramWithIL(CLContext, IntPtr,
        ///     UIntPtr, out CLResultCode)">CreateProgramWithIL()</see></c>
        ///     or <c><see cref="CL.CreateProgramWithBuiltInKernels(CLContext, uint,
        ///     IntPtr[], string, out CLResultCode)">CreateProgramWithBuiltInKernels()</see></c>,
        ///     a null string or the appropriate program source code is returned depending
        ///     on whether or not the program source code is stored in the binary.
        /// </para>
        /// <para>
        ///     The actual number of characters that represents the program source code including
        ///     the null terminator is returned in <c>param_value_size_ret</c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Source = 0x1164,

        /// <summary>
        /// <para>
        ///     Returns an array that contains the size in bytes of the program binary
        ///     (could be an executable binary, compiled binary or library binary)
        ///     for each device associated with program. The size of the array is the number
        ///     of devices associated with program. If a binary is not available for a device(s),
        ///     a size of zero is returned.
        /// </para>
        /// <para>
        ///     If program is created using <c><see cref="CL.CreateProgramWithBuiltInKernels(CLContext, uint,
        ///     IntPtr[], string, out CLResultCode)">CreateProgramWithBuiltInKernels()</see></c>,
        ///     the implementation may return zero in any entries of the returned array.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr[]</c>
        /// </para>
        /// </summary>
        BinarySizes = 0x1165,

        /// <summary>
        /// <para>
        ///     Return the program binaries (could be an executable binary,
        ///     compiled binary or library binary) for all devices associated with program.
        ///     For each device in program, the binary returned can be the binary specified
        ///     for the device when program is created with
        ///     <c><see cref="CL.CreateProgramWithBinary(CLContext, uint, IntPtr[], UIntPtr[],
        ///     IntPtr[], out CLResultCode[], out CLResultCode)">CreateProgramWithBinary()</see></c>
        ///     or it can be the executable binary generated by
        ///     <c><see cref="CL.BuildProgram(CLProgram, CLDevice[], string,
        ///     CL.ClEventCallback)">BuildProgram()</see></c> or
        ///     <c><see cref="CL.LinkProgram(CLContext, uint, CLDevice[], string, uint,
        ///     CLProgram[], IntPtr, IntPtr, out CLResultCode)">LinkProgram()</see></c>.
        ///     If program is created with
        ///     <c><see cref="CL.CreateProgramWithSource(CLContext, string, out CLResultCode)">
        ///     CreateProgramWithSource()</see></c>
        ///     or <c><see cref="CL.CreateProgramWithIL(CLContext, IntPtr,
        ///     UIntPtr, out CLResultCode)">CreateProgramWithIL()</see></c>,
        ///     the binary returned is the binary generated by
        ///     <c><see cref="CL.BuildProgram(CLProgram, CLDevice[], string,
        ///     CL.ClEventCallback)">BuildProgram()</see></c>,
        ///     <c><see cref="CL.CompileProgram(CLProgram, uint, CLDevice[], string, uint,
        ///     IntPtr[], out IntPtr, IntPtr, IntPtr)">CompileProgram()</see></c>
        ///     or <c><see cref="CL.LinkProgram(CLContext, uint, CLDevice[], string, uint,
        ///     CLProgram[], IntPtr, IntPtr, out CLResultCode)">LinkProgram()</see></c>.
        ///     The bits returned can be an implementation-specific intermediate representation
        ///     (a.k.a. IR) or device specific executable bits or both.
        ///     The decision on which information is returned in the binary is up to the OpenCL implementation.
        /// </para>
        /// <para>
        ///     <c>param_value</c> points to an array of <b>n</b> pointers allocated by the caller,
        ///     where <b>n</b> is the number of devices associated with program.
        ///     The buffer sizes needed to allocate the memory that these <b>n</b> pointers refer to can be
        ///     queried using the <c><see cref="BinarySizes">BinarySizes</see></c> query as described in this table.
        /// </para>
        /// <para>
        ///     Each entry in this array is used by the implementation as the location in memory where
        ///     to copy the program binary for a specific device, if there is a binary available.
        ///     To find out which device the program binary in the array refers to,
        ///     use the <c><see cref="Devices">Devices</see></c> query to get the list of devices.
        ///     There is a one-to-one correspondence between the array of <b>n</b> pointers returned by
        ///     <c><see cref="Binaries">Binaries</see></c> and array of devices returned by
        ///     <c><see cref="Devices">Devices</see></c>.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>IntPtr[]</c>
        /// </para>
        /// </summary>
        Binaries = 0x1166,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the number of kernels declared in program that can be created with
        ///     <c><see cref="CL.CreateKernel(CLProgram, string, out CLResultCode)">CreateKernel()</see></c>.
        ///     This information is only available after a successful program executable has been
        ///     built for at least one device in the list of devices associated with program.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        NumberOfKernels = 0x1167,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Returns a semi-colon separated list of kernel names in program that can be created with
        ///     <c><see cref="CL.CreateKernel(CLProgram, string, out CLResultCode)">CreateKernel()</see></c>.
        ///     This information is only available after a successful program executable has been built for at
        ///     least one device in the list of devices associated with program.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        KernelNames = 0x1168,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.1.</pre></i>
        /// </para>
        /// <para>
        ///     Returns the program IL for programs created with
        ///     <c><see cref="CL.CreateProgramWithIL(CLContext, IntPtr,
        ///     UIntPtr, out CLResultCode)">CreateProgramWithIL()</see></c>.
        /// </para>
        /// <para>
        ///     If program is created with
        ///     <c><see cref="CL.CreateProgramWithSource(CLContext, string, out CLResultCode)">
        ///     CreateProgramWithSource()</see></c>,
        ///     <c><see cref="CL.CreateProgramWithBinary(CLContext, uint, IntPtr[], UIntPtr[],
        ///     IntPtr[], out CLResultCode[], out CLResultCode)">CreateProgramWithBinary()</see></c>
        ///     or <c><see cref="CL.CreateProgramWithBuiltInKernels(CLContext, uint,
        ///     IntPtr[], string, out CLResultCode)">CreateProgramWithBuiltInKernels()</see></c>
        ///     the memory pointed to by <c>param_value</c> will be unchanged and
        ///     <c>param_value_size_ret</c> will be set to 0.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Il = 0x1169,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.2 and deprecated by version 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     This indicates that the program object contains non-trivial constructor(s)
        ///     that will be executed by runtime before any kernel from the program is executed.
        ///     This information is only available after a successful program executable has
        ///     been built for at least one device in the list of devices associated with program.
        /// </para>
        /// <para>
        ///     Querying <c><see cref="ProgramScopeGlobalConstructorsPresent"/></c> may unconditionally return FALSE if
        ///     no devices associated with program support constructors for program scope global variables.
        ///     Support for constructors and destructors for program scope global variables is required
        ///     only for OpenCL 2.2 devices.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        ProgramScopeGlobalConstructorsPresent = 0x116A,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.2 and deprecated by version 3.0.</pre></i>
        /// </para>
        /// <para>
        ///     This indicates that the program object contains non-trivial destructor(s)
        ///     that will be executed by runtime before any kernel from the program is executed.
        ///     This information is only available after a successful program executable has
        ///     been built for at least one device in the list of devices associated with program.
        /// </para>
        /// <para>
        ///     Querying <c><see cref="ProgramScopeGlobalDestructorsPresent"/></c> may unconditionally return FALSE if
        ///     no devices associated with program support destructors for program scope global variables.
        ///     Support for constructors and destructors for program scope global variables is required
        ///     only for OpenCL 2.2 devices.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>bool</c>
        /// </para>
        /// </summary>
        ProgramScopeGlobalDestructorsPresent = 0x116B
    }

    /// <summary>
    /// <para>
    ///     Specifies the information to query using
    ///     <c><see cref="CL.GetProgramBuildInfo(CLProgram, CLDevice,
    ///     ProgramBuildInfo, out byte[])">GetProgramBuildInfo()</see></c>.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#program-build-info-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum ProgramBuildInfo : uint
    {
        /// <summary>
        /// <para>
        ///     Returns the build, compile or link status,
        ///     whichever was performed last on the specified program object for device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="BuildStatus">BuildStatus</see></c>
        /// </para>
        /// </summary>
        Status = 0x1181,

        /// <summary>
        /// <para>
        ///     Return the build, compile or link options specified by the options argument in
        ///     <c><see cref="CL.BuildProgram(CLProgram, CLDevice[], string,
        ///     CL.ClEventCallback)">BuildProgram()</see></c>,
        ///     <c><see cref="CL.CompileProgram(CLProgram, uint, CLDevice[], string, uint,
        ///     IntPtr[], out IntPtr, IntPtr, IntPtr)">CompileProgram()</see></c>
        ///     or <c><see cref="CL.LinkProgram(CLContext, uint, CLDevice[], string, uint,
        ///     CLProgram[], IntPtr, IntPtr, out CLResultCode)">LinkProgram()</see></c>,
        ///     whichever was performed last on the specified program object for device.
        /// </para>
        /// <para>
        ///     If build status of the specified program for device is
        ///     <c><see cref="BuildStatus.None">None</see></c>, an empty string is returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Options = 0x1182,

        /// <summary>
        /// <para>
        ///     Return the build, compile or link log for
        ///     <c><see cref="CL.BuildProgram(CLProgram, CLDevice[], string,
        ///     CL.ClEventCallback)">BuildProgram()</see></c>,
        ///     <c><see cref="CL.CompileProgram(CLProgram, uint, CLDevice[], string, uint,
        ///     IntPtr[], out IntPtr, IntPtr, IntPtr)">CompileProgram()</see></c> or
        ///     <c><see cref="CL.LinkProgram(CLContext, uint, CLDevice[], string, uint,
        ///     CLProgram[], IntPtr, IntPtr, out CLResultCode)">LinkProgram()</see></c>,
        ///     whichever was performed last on program for device.
        /// </para>
        /// <para>
        ///     If build status of the specified program for device is
        ///     <c><see cref="BuildStatus.None">None</see></c>, an empty string is returned.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Log = 0x1183,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Return the program binary type for device.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="ProgramBinaryType">ProgramBinaryType</see></c>
        /// </para>
        /// </summary>
        BinaryType = 0x1184,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 2.0.</pre></i>
        /// </para>
        /// <para>
        ///     The total amount of storage, in bytes, used by program variables in the global address space.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>UIntPtr</c>
        /// </para>
        /// </summary>
        GlobalVariableTotalSize = 0x1185
    }

    /// <summary>
    ///     Valid options for the return value of
    ///     <c><see cref="CL.GetProgramBuildInfo(CLProgram, CLDevice,
    ///     ProgramBuildInfo, out byte[])">GetProgramBuildInfo()</see></c> using
    ///     <c><see cref="ProgramBuildInfo.BinaryType"/></c>.
    /// </summary>
    public enum ProgramBinaryType : uint
    {
        /// <summary>
        ///     There is no binary associated with the specified program object for device.
        /// </summary>
        None = 0,

        /// <summary>
        ///     A compiled binary is associated with device.
        ///     This is the case when the specified program object was created using
        ///     <c><see cref="CL.CreateProgramWithSource(CLContext, string, out CLResultCode)">
        ///     CreateProgramWithSource()</see></c> and compiled using
        ///     <c><see cref="CL.CompileProgram(CLProgram, uint, CLDevice[], string, uint,
        ///     IntPtr[], out IntPtr, IntPtr, IntPtr)">CompileProgram()</see></c>,
        ///     or when a compiled binary was loaded using
        ///     <c><see cref="CL.CreateProgramWithBinary(CLContext, uint, IntPtr[],
        ///     UIntPtr[], IntPtr[], out CLResultCode[], out CLResultCode)">CreateProgramWithBinary()</see></c>.
        /// </summary>
        CompiledObject = 1,

        /// <summary>
        ///     A library binary is associated with device.
        ///     This is the case when the specified program object was linked by
        ///     <c><see cref="CL.LinkProgram(CLContext, uint, CLDevice[], string, uint,
        ///     CLProgram[], IntPtr, IntPtr, out CLResultCode)">LinkProgram()</see></c>
        ///     using the <c>-create-library</c> link option, or when a compiled library
        ///     binary was loaded using
        ///     <c><see cref="CL.CreateProgramWithBinary(CLContext, uint, IntPtr[],
        ///     UIntPtr[], IntPtr[], out CLResultCode[], out CLResultCode)">CreateProgramWithBinary()</see></c>.
        /// </summary>
        Library = 2,

        /// <summary>
        ///     An executable binary is associated with device.
        ///     This is the case when the specified program object was linked by
        ///     <c><see cref="CL.LinkProgram(CLContext, uint, CLDevice[], string, uint,
        ///     CLProgram[], IntPtr, IntPtr, out CLResultCode)">LinkProgram()</see></c>
        ///     without the <c>-create-library</c> link option, or when an executable binary
        ///     was built using <c><see cref="CL.BuildProgram(CLProgram, CLDevice[], string,
        ///     CL.ClEventCallback)">BuildProgram()</see></c>.
        /// </summary>
        Executable = 3
    }

    /// <summary>
    ///     Valid options for the return value of
    ///     <c><see cref="CL.GetProgramBuildInfo(CLProgram, CLDevice,
    ///     ProgramBuildInfo, out byte[])">GetProgramBuildInfo()</see></c> using
    ///     <c><see cref="ProgramBuildInfo.Status"/></c>.
    /// </summary>
    public enum BuildStatus : int
    {
        /// <summary>
        ///     The build status returned if
        ///     <c><see cref="CL.BuildProgram(CLProgram, CLDevice[], string,
        ///     CL.ClEventCallback)">BuildProgram()</see></c>,
        ///     <c><see cref="CL.CompileProgram(CLProgram, uint, CLDevice[], string, uint,
        ///     IntPtr[], out IntPtr, IntPtr, IntPtr)">CompileProgram()</see></c> or
        ///     <c><see cref="CL.LinkProgram(CLContext, uint, CLDevice[], string, uint,
        ///     CLProgram[], IntPtr, IntPtr, out CLResultCode)">LinkProgram()</see></c>
        ///     - whichever was performed last on the specified program object for device - was successful.
        /// </summary>
        Success = 0,

        /// <summary>
        ///     The build status returned if no
        ///     <c><see cref="CL.BuildProgram(CLProgram, CLDevice[], string,
        ///     CL.ClEventCallback)">BuildProgram()</see></c>,
        ///     <c><see cref="CL.CompileProgram(CLProgram, uint, CLDevice[], string, uint,
        ///     IntPtr[], out IntPtr, IntPtr, IntPtr)">CompileProgram()</see></c> or
        ///     <c><see cref="CL.LinkProgram(CLContext, uint, CLDevice[], string, uint,
        ///     CLProgram[], IntPtr, IntPtr, out CLResultCode)">LinkProgram()</see></c>
        ///     has been performed on the specified program object for device.
        /// </summary>
        None = -1,

        /// <summary>
        ///     The build status returned if
        ///     <c><see cref="CL.BuildProgram(CLProgram, CLDevice[], string,
        ///     CL.ClEventCallback)">BuildProgram()</see></c>,
        ///     <c><see cref="CL.CompileProgram(CLProgram, uint, CLDevice[], string, uint,
        ///     IntPtr[], out IntPtr, IntPtr, IntPtr)">CompileProgram()</see></c> or
        ///     <c><see cref="CL.LinkProgram(CLContext, uint, CLDevice[], string, uint,
        ///     CLProgram[], IntPtr, IntPtr, out CLResultCode)">LinkProgram()</see></c>
        ///     - whichever was performed last on the specified program object for device - generated an error.
        /// </summary>
        Error = -2,

        /// <summary>
        ///     The build status returned if
        ///     <c><see cref="CL.BuildProgram(CLProgram, CLDevice[], string,
        ///     CL.ClEventCallback)">BuildProgram()</see></c>,
        ///     <c><see cref="CL.CompileProgram(CLProgram, uint, CLDevice[], string, uint,
        ///     IntPtr[], out IntPtr, IntPtr, IntPtr)">CompileProgram()</see></c> or
        ///     <c><see cref="CL.LinkProgram(CLContext, uint, CLDevice[], string, uint,
        ///     CLProgram[], IntPtr, IntPtr, out CLResultCode)">LinkProgram()</see></c>
        ///     - whichever was performed last on the specified program object for device - has not finished.
        /// </summary>
        InProgress = -3
    }

    #endregion

    #region Kernel
    public enum KernelExecInfo : uint
    {
        SvmPointers = 0x11B6,
        SvmFineGrainSystem = 0x11B7
    }

    /// <summary>
    /// <para>
    ///     Specifies the information to query using
    ///     <c><see cref="CL.GetKernelInfo(CLKernel,
    ///     KernelInfo, out byte[])">GetKernelInfo()</see></c>.
    /// </para>
    /// <para>
    ///     Original documentation
    ///     <b><u><see href="https://registry.khronos.org/OpenCL/specs/3.0-unified/html/OpenCL_API.html#kernel-info-table">here</see></u></b>.
    /// </para>
    /// </summary>
    public enum KernelInfo : uint
    {
        /// <summary>
        /// <para>
        ///     Return the kernel function name.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        FunctionName = 0x1190,

        /// <summary>
        /// <para>
        ///     Return the number of arguments to kernel.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        NumberOfArguments = 0x1191,

        /// <summary>
        /// <para>
        ///     Return the kernel reference count.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>uint</c>
        /// </para>
        /// </summary>
        ReferenceCount = 0x1192,

        /// <summary>
        /// <para>
        ///     Return the context associated with kernel.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLContext">CLContext</see></c>
        /// </para>
        /// </summary>
        Context = 0x1193,

        /// <summary>
        /// <para>
        ///     Return the program object associated with kernel.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c><see cref="CLProgram">CLProgram</see></c>
        /// </para>
        /// </summary>
        Program = 0x1194,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     Returns any attributes specified using the <c>__attribute__</c>
        ///     OpenCL C qualifier (or using an OpenCL C++ qualifier syntax [[]] )
        ///     with the kernel function declaration in the program source.
        ///     These attributes include attributes described in the earlier OpenCL C
        ///     kernel language specifications and other attributes supported by an implementation.
        /// </para>
        /// <para>
        ///     Attributes are returned as they were declared inside <c>__attribute__((...))</c>,
        ///     with any surrounding whitespace and embedded newlines removed.
        ///     When multiple attributes are present, they are returned as a single,
        ///     space delimited string.
        /// </para>
        /// <para>
        ///     <i><u>Return Type:</u></i> <c>string</c>
        /// </para>
        /// </summary>
        Attributes = 0x1195,
    }

    public enum KernelArgInfo : uint
    {
        AddressQualifier = 0x1196,
        AccessQualifier = 0x1197,
        TypeName = 0x1198,
        TypeQualifier = 0x1199,
        Name = 0x119A
    }

    public enum KernelWorkGroupInfo : uint
    {
        WorkGroupSize = 0x11B0,
        CompileWorkGroupSize = 0x11B1,
        LocalMemorySize = 0x11B2,
        PreferredWorkGroupSizeMultiple = 0x11B3,
        PrivateMemorySize = 0x11B4,
        GlobalWorkSize = 0x11B5
    }

    public enum KernelSubGroupInfo : uint
    {
        MaximumSubGroupSizeForNdRange = 0x2033,
        SubGroupCountForNdRange = 0x2034,
        LocalSizeForSubGroupCount = 0x11B8
    }

    #endregion

    #region Other
    public enum EventInfo : uint
    {
        CommandQueue = 0x11D0,
        CommandType = 0x11D1,
        ReferenceCount = 0x11D2,
        CommandExecutionStatus = 0x11D3,
        Context = 0x11D4
    }

    public enum ProfilingInfo : uint
    {
        CommandQueued = 0x1280,
        CommandSubmit = 0x1281,
        CommandStart = 0x1282,
        CommandEnd = 0x1283,
        CommandComplete = 0x1284
    }

    /// <summary>
    ///     Bit-field for describing mapping operations.
    /// </summary>
    [Flags]
    public enum MapFlags : ulong
    {
        /// <summary>
        /// <para>
        ///     This flag specifies that the region being mapped in the memory object is being mapped for reading.
        /// </para>
        /// <para>
        ///     The pointer returned by
        ///     <c><see cref="CL.EnqueueMapBuffer(CLCommandQueue, CLBuffer, bool,
        ///     MapFlags, UIntPtr, UIntPtr, uint,
        ///     CLEvent[], out CLEvent, out CLResultCode)">EnqueueMapBuffer()</see></c>
        ///     (<c><see cref="CL.EnqueueMapImage(CLCommandQueue, CLImage, bool, MapFlags,
        ///     UIntPtr[], UIntPtr[], UIntPtr, UIntPtr, uint,
        ///     CLEvent[], out CLEvent, out CLResultCode)">EnqueueMapImage()</see></c>)
        ///     is guaranteed to contain the latest bits in the region being
        ///     mapped when the <c><see cref="CL.EnqueueMapBuffer(CLCommandQueue, CLBuffer, bool,
        ///     MapFlags, UIntPtr, UIntPtr, uint,
        ///     CLEvent[], out CLEvent, out CLResultCode)">EnqueueMapBuffer()</see></c>
        ///     (<c><see cref="CL.EnqueueMapImage(CLCommandQueue, CLImage, bool, MapFlags,
        ///     UIntPtr[], UIntPtr[], UIntPtr, UIntPtr, uint,
        ///     CLEvent[], out CLEvent, out CLResultCode)">EnqueueMapImage()</see></c>)
        ///     command has completed.
        /// </para>
        /// </summary>
        Read = 1 << 0,

        /// <summary>
        /// <para>
        ///     This flag specifies that the region being mapped in the memory object is being mapped for writing.
        /// </para>
        /// <para>
        ///     The pointer returned by
        ///     <c><see cref="CL.EnqueueMapBuffer(CLCommandQueue, CLBuffer, bool,
        ///     MapFlags, UIntPtr, UIntPtr, uint,
        ///     CLEvent[], out CLEvent, out CLResultCode)">EnqueueMapBuffer()</see></c>
        ///     (<c><see cref="CL.EnqueueMapImage(CLCommandQueue, CLImage, bool, MapFlags,
        ///     UIntPtr[], UIntPtr[], UIntPtr, UIntPtr, uint,
        ///     CLEvent[], out CLEvent, out CLResultCode)">EnqueueMapImage()</see></c>)
        ///     is guaranteed to contain the latest bits in the region being
        ///     mapped when the <c><see cref="CL.EnqueueMapBuffer(CLCommandQueue, CLBuffer, bool,
        ///     MapFlags, UIntPtr, UIntPtr, uint,
        ///     CLEvent[], out CLEvent, out CLResultCode)">EnqueueMapBuffer()</see></c>
        ///     (<c><see cref="CL.EnqueueMapImage(CLCommandQueue, CLImage, bool, MapFlags,
        ///     UIntPtr[], UIntPtr[], UIntPtr, UIntPtr, uint,
        ///     CLEvent[], out CLEvent, out CLResultCode)">EnqueueMapImage()</see></c>)
        ///     command has completed.
        /// </para>
        /// </summary>
        Write = 1 << 1,

        /// <summary>
        /// <para>
        ///     <i><pre>Missing before verison 1.2.</pre></i>
        /// </para>
        /// <para>
        ///     This flag specifies that the region being mapped in the memory object is being mapped for writing.
        /// </para>
        /// <para>
        ///     The contents of the region being mapped are to be discarded.
        ///     This is typically the case when the region being mapped is overwritten by the host.
        ///     This flag allows the implementation to no longer guarantee that the pointer returned
        ///     by <c><see cref="CL.EnqueueMapBuffer(CLCommandQueue, CLBuffer, bool,
        ///     MapFlags, UIntPtr, UIntPtr, uint,
        ///     CLEvent[], out CLEvent, out CLResultCode)">EnqueueMapBuffer()</see></c>
        ///     (<c><see cref="CL.EnqueueMapImage(CLCommandQueue, CLImage, bool, MapFlags,
        ///     UIntPtr[], UIntPtr[], UIntPtr, UIntPtr, uint,
        ///     CLEvent[], out CLEvent, out CLResultCode)">EnqueueMapImage()</see></c>)
        ///     contains the latest bits in the region being mapped which can be
        ///     a significant performance enhancement.
        /// </para>
        /// <para>
        ///     <c><see cref="Read">Read</see></c> or
        ///     <c><see cref="Write">Write</see></c>
        ///     and <c><see cref="WriteInvalidateRegion">WriteInvalidateRegion</see></c>
        ///     are mutually exclusive.
        /// </para>
        /// </summary>
        WriteInvalidateRegion = 1 << 2
    }

    #endregion
}
