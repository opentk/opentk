// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Compute2;

namespace OpenTK.Compute2.OpenCL
{
    public static unsafe partial class CL
    {
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clBuildProgram</c>]</b><br/> Builds (compiles and links) a program executable from the program source or binary. </summary>
        /// <param name="program">program is the program object.</param>
        /// <param name="num_devices">num_devices is the number of devices listed in device_list.</param>
        /// <param name="device_list">device_list is a pointer to a list of devices associated with program.<br/>If device_list is a NULL value, the program executable is built for all<br/>devices associated with program for which a source or binary has been<br/>loaded.<br/>If device_list is a non-NULL value, the program executable is built for<br/>devices specified in this list for which a source or binary has been loaded.</param>
        /// <param name="options">options is a pointer to a null-terminated string of characters that<br/>describes the build options to be used for building the program executable.<br/>The list of supported options is described in Compiler<br/>Options.<br/>If the program was created using clCreateProgramWithBinary and options<br/>is a NULL pointer, the program will be built as if options were the same<br/>as when the program binary was originally built.<br/>If the program was created using clCreateProgramWithBinary and options<br/>string contains anything other than the same options in the same order<br/>(whitespace ignored) as when the program binary was originally built, then<br/>the behavior is implementation-defined.<br/>Otherwise, if options is a NULL pointer then it will have the same<br/>result as the empty string.</param>
        /// <param name="pfn_notify">pfn_notify is a function pointer to a notification routine.<br/>The notification routine is a callback function that an application can<br/>register and which will be called when the program executable has been built<br/>(successfully or unsuccessfully).<br/>If pfn_notify is not NULL, clBuildProgram does not need to wait for<br/>the build to complete and can return immediately once the build operation<br/>can begin.<br/>Any state changes of the program object that result from calling<br/>clBuildProgram (e.g. build status or log) will be observable from this<br/>callback function.<br/>The build operation can begin if the context, program whose sources are<br/>being compiled and linked, list of devices and build options specified are<br/>all valid and appropriate host and device resources needed to perform the<br/>build are available.<br/>If pfn_notify is NULL, clBuildProgram does not return until the build<br/>has completed.<br/>This callback function may be called asynchronously by the OpenCL<br/>implementation.<br/>It is the application’s responsibility to ensure that the callback function<br/>is thread-safe.</param>
        /// <param name="user_data">user_data will be passed as an argument when pfn_notify is called.<br/>user_data can be NULL.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clBuildProgram.html"/></remarks>
        public static int BuildProgram(IntPtr program, uint num_devices, IntPtr* device_list, byte* options, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clBuildProgram_Lazy(program, num_devices, device_list, options, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clCloneKernel</c>]</b><br/> Make a shallow copy of the kernel object. </summary>
        /// <param name="source_kernel">source_kernel is a valid cl_kernel object that will be copied.<br/>source_kernel will not be modified in any way by this function.</param>
        /// <param name="errcode_ret">errcode_ret will be assigned an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCloneKernel.html"/></remarks>
        public static IntPtr CloneKernel(IntPtr source_kernel, int* errcode_ret) => CLPointers.clCloneKernel_Lazy(source_kernel, errcode_ret);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clCompileProgram</c>]</b><br/> Compiles a program's source for all the devices or a specific device(s) in the OpenCL context associated with a program. </summary>
        /// <param name="program">program is the program object that is the compilation target.</param>
        /// <param name="num_devices">num_devices is the number of devices listed in device_list.</param>
        /// <param name="device_list">device_list is a pointer to a list of devices associated with program.<br/>If device_list is a NULL value, the compile is performed for all devices<br/>associated with program.<br/>If device_list is a non-NULL value, the compile is performed for devices<br/>specified in this list.</param>
        /// <param name="options">options is a pointer to a null-terminated string of characters that<br/>describes the compilation options to be used for building the program<br/>executable.<br/>If options is a NULL pointer then it will have the same result as the<br/>empty string.<br/>Certain options are ignored when program is created with IL.<br/>The list of supported options is as described in Compiler Options.</param>
        /// <param name="num_input_headers">num_input_headers specifies the number of programs that describe headers<br/>in the array referenced by input_headers.</param>
        /// <param name="input_headers">input_headers is an array of program embedded headers created with<br/>clCreateProgramWithSource.</param>
        /// <param name="header_include_names">header_include_names is an array that has a one to one correspondence with<br/>input_headers.<br/>Each entry in header_include_names specifies the include name used by<br/>source in program that comes from an embedded header.<br/>The corresponding entry in input_headers identifies the program object<br/>which contains the header source to be used.<br/>The embedded headers are first searched before the headers in the list of<br/>directories specified by the -I compile option (as described in<br/>Preprocessor options).<br/>If multiple entries in header_include_names refer to the same header name,<br/>the first one encountered will be used.</param>
        /// <param name="pfn_notify">pfn_notify is a function pointer to a notification routine.<br/>The notification routine is a callback function that an application can<br/>register and which will be called when the program executable has been built<br/>(successfully or unsuccessfully).<br/>If pfn_notify is not NULL, clCompileProgram does not need to wait for<br/>the compiler to complete and can return immediately once the compilation can<br/>begin.<br/>Any state changes of the program object that result from calling<br/>clCompileProgram (e.g. compile status or log) will be observable from this<br/>callback function.<br/>The compilation can begin if the context, program whose sources are being<br/>compiled, list of devices, input headers, programs that describe input<br/>headers and compiler options specified are all valid and appropriate host<br/>and device resources needed to perform the compile are available.<br/>If pfn_notify is NULL, clCompileProgram does not return until the<br/>compiler has completed.<br/>This callback function may be called asynchronously by the OpenCL<br/>implementation.<br/>It is the application’s responsibility to ensure that the callback function<br/>is thread-safe.</param>
        /// <param name="user_data">user_data will be passed as an argument when pfn_notify is called.<br/>user_data can be NULL.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCompileProgram.html"/></remarks>
        public static int CompileProgram(IntPtr program, uint num_devices, IntPtr* device_list, byte* options, uint num_input_headers, IntPtr* input_headers, byte** header_include_names, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clCompileProgram_Lazy(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateBuffer</c>]</b><br/> Creates a buffer object. </summary>
        /// <param name="context">context is a valid OpenCL context used to create the buffer object.</param>
        /// <param name="flags">flags is a bit-field that is used to specify allocation and usage<br/>information about the buffer memory object being created and is described in<br/>the supported memory flag values table.</param>
        /// <param name="size">size is the size in bytes of the buffer memory object to be allocated.</param>
        /// <param name="host_ptr">host_ptr is a pointer to the buffer data that may already be allocated<br/>by the application.<br/>The size of the buffer that host_ptr points to must be greater than or equal to size<br/>bytes.</param>
        /// <param name="errcode_ret">errcode_ret may return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateBuffer.html"/></remarks>
        public static IntPtr CreateBuffer(IntPtr context, MemFlags flags, nuint size, void* host_ptr, int* errcode_ret) => CLPointers.clCreateBuffer_Lazy(context, (ulong)flags, size, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>clCreateBufferWithProperties</c>]</b><br/> Creates a buffer object. </summary>
        /// <param name="context">context is a valid OpenCL context used to create the buffer object.</param>
        /// <param name="properties">properties is an optional list of properties for the buffer object and their corresponding values.<br/>The list is terminated with the special property 0.<br/>If no properties are required, properties may be NULL.<br/>OpenCL does not define any optional properties for buffers,<br/>but extensions may define properties as described in the<br/>https://www.khronos.org/registry/OpenCL/specs/unified/html/OpenCL_API.html#external-buffer-memory-properties-table.</param>
        /// <param name="flags">flags is a bit-field that is used to specify allocation and usage<br/>information about the buffer memory object being created and is described in<br/>the supported memory flag values table.</param>
        /// <param name="size">size is the size in bytes of the buffer memory object to be allocated.</param>
        /// <param name="host_ptr">host_ptr is a pointer to the buffer data that may already be allocated<br/>by the application.<br/>The size of the buffer that host_ptr points to must be greater than or equal to size<br/>bytes.</param>
        /// <param name="errcode_ret">errcode_ret may return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateBufferWithProperties.html"/></remarks>
        public static IntPtr CreateBufferWithProperties(IntPtr context, MemProperties* properties, MemFlags flags, nuint size, void* host_ptr, int* errcode_ret) => CLPointers.clCreateBufferWithProperties_Lazy(context, (ulong*)properties, (ulong)flags, size, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateCommandQueue</c>]</b><br/> Create a host command-queue on a specific device. </summary>
        /// <param name="context">context must be a valid OpenCL context.</param>
        /// <param name="device">device must be a device or sub-device associated with context.<br/>It can either be in the list of devices and sub-devices specified when<br/>context is created using clCreateContext or be a root device with the<br/>same device type as specified when context is created using<br/>clCreateContextFromType.</param>
        /// <param name="properties">properties specifies a list of properties for the command-queue.<br/>This is a bit-field and the supported properties are described in the<br/>table below.<br/>Only command-queue properties specified in this table can be used,<br/>otherwise the value specified in properties is considered to be not<br/>valid.<br/>properties can be 0 in which case the default values for supported<br/>command-queue properties will be used.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateCommandQueue.html"/></remarks>
        public static IntPtr CreateCommandQueue(IntPtr context, IntPtr device, CommandQueueProperties properties, int* errcode_ret) => CLPointers.clCreateCommandQueue_Lazy(context, device, (ulong)properties, errcode_ret);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clCreateCommandQueueWithProperties</c>]</b><br/> Create a host or device command-queue on a specific device. </summary>
        /// <param name="context">context must be a valid OpenCL context.</param>
        /// <param name="device">device must be a device or sub-device associated with context.<br/>It can either be in the list of devices and sub-devices specified when<br/>context is created using clCreateContext or be a root device with<br/>the same device type as specified when context is created using<br/>clCreateContextFromType.</param>
        /// <param name="properties">properties specifies a list of properties for the command-queue and their<br/>corresponding values.<br/>Each property name is immediately followed by the corresponding desired<br/>value.<br/>The list is terminated with 0.<br/>The list of supported properties is described in the<br/>table below.<br/>If a supported property and its value is not specified in properties, its<br/>default value will be used.<br/>properties can be NULL in which case the default values for supported<br/>command-queue properties will be used.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateCommandQueueWithProperties.html"/></remarks>
        public static IntPtr CreateCommandQueueWithProperties(IntPtr context, IntPtr device, QueueProperties* properties, int* errcode_ret) => CLPointers.clCreateCommandQueueWithProperties_Lazy(context, device, (ulong*)properties, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateContext</c>]</b><br/> Create an OpenCL context </summary>
        /// <param name="properties">properties specifies a list of context property names and their<br/>corresponding values.<br/>Each property name is immediately followed by the corresponding desired<br/>value.<br/>The list is terminated with 0.<br/>The list of supported properties, and their default values if not<br/>present in properties, is described in the Context Properties table.<br/>properties can be NULL, in which case all properties take on their<br/>default values.</param>
        /// <param name="num_devices">num_devices is the number of devices specified in the devices argument.</param>
        /// <param name="devices">devices is a pointer to a list of unique devices returned by<br/>clGetDeviceIDs or sub-devices created by clCreateSubDevices for a<br/>platform. [1]</param>
        /// <param name="pfn_notify">pfn_notify is a callback function that can be registered by the<br/>application.<br/>This callback function will be used by the OpenCL implementation to report<br/>information on errors during context creation as well as errors that occur<br/>at runtime in this context.<br/>This callback function may be called asynchronously by the OpenCL<br/>implementation.<br/>It is the application’s responsibility to ensure that the callback function<br/>is thread-safe.<br/>If pfn_notify is NULL, no callback function is registered.</param>
        /// <param name="user_data">user_data will be passed as the user_data argument when pfn_notify is<br/>called.<br/>user_data can be NULL.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateContext.html"/></remarks>
        public static IntPtr CreateContext(IntPtr* properties, uint num_devices, IntPtr* devices, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, void* user_data, int* errcode_ret) => CLPointers.clCreateContext_Lazy(properties, num_devices, devices, pfn_notify, user_data, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateContextFromType</c>]</b><br/> Create an OpenCL context from a device type </summary>
        /// <param name="properties">properties specifies a list of context property names and their<br/>corresponding values.<br/>Each property name is immediately followed by the corresponding desired<br/>value.<br/>The list of supported properties, and their default values if not<br/>present in properties, is described in the Context Properties table.<br/>properties can be NULL, in which case all properties take on their<br/>default values.</param>
        /// <param name="device_type">device_type is a bit-field that identifies the type of device and is<br/>described in the Device Types table.</param>
        /// <param name="pfn_notify">pfn_notify and user_data are described in clCreateContext.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateContextFromType.html"/></remarks>
        public static IntPtr CreateContextFromType(IntPtr* properties, DeviceType device_type, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, void* user_data, int* errcode_ret) => CLPointers.clCreateContextFromType_Lazy(properties, (ulong)device_type, pfn_notify, user_data, errcode_ret);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clCreateImage</c>]</b><br/> Creates a 1D image, 1D image buffer, 1D image array, 2D image, 2D image array or 3D image object. </summary>
        /// <param name="context">context is a valid OpenCL context used to create the image object.</param>
        /// <param name="flags">flags is a bit-field that is used to specify allocation and usage<br/>information about the image memory object being created and is described in<br/>the supported memory flag values table.</param>
        /// <param name="image_format">image_format is a pointer to a structure that describes format properties<br/>of the image to be allocated.<br/>A 1D image buffer can be created from a buffer by specifying a buffer object<br/>in image_desc→mem_object.<br/>If the cl_khr_image2d_from_buffer extension is supported, a 2D image<br/>can be created from a buffer by specifying a buffer object in<br/>image_desc→mem_object.<br/>If the cl_ext_image_from_buffer extension is supported, an image of<br/>any type can be created from a buffer by specifying a buffer object in<br/>image_desc→mem_object.<br/>A 2D image can be created from another 2D image object by specifying an<br/>image object in the image_desc→mem_object.<br/>Refer to the Image Format Descriptor section<br/>for a detailed description of the image format descriptor.</param>
        /// <param name="image_desc">image_desc is a pointer to a structure that describes type and dimensions<br/>of the image to be allocated.<br/>Refer to the Image Descriptor section for a detailed<br/>description of the image descriptor.</param>
        /// <param name="host_ptr">host_ptr is a pointer to the image data that may already be allocated by<br/>the application.<br/>Refer to the table below for a description<br/>of how large the buffer that host_ptr points to must be.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateImage.html"/></remarks>
        public static IntPtr CreateImage(IntPtr context, MemFlags flags, cl_image_format* image_format, cl_image_desc* image_desc, void* host_ptr, int* errcode_ret) => CLPointers.clCreateImage_Lazy(context, (ulong)flags, image_format, image_desc, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateImage2D</c>]</b><br/> Creates a 2D image. </summary>
        /// <param name="context">context is a valid OpenCL context on which the image object is to be<br/>created.</param>
        /// <param name="flags">flags is a bit-field that is used to specify allocation and usage<br/>information about the image memory object being created and is described in<br/>the supported memory flag values table.<br/>If the value specified for flags is 0, the default is used which is<br/>CL_MEM_READ_WRITE.</param>
        /// <param name="image_format">image_format is a pointer to a structure that describes format properties<br/>of the image to be allocated.<br/>Refer to the Image Format Descriptor section<br/>for a detailed description of the image format descriptor.</param>
        /// <param name="image_width">image_width and image_height are the width and height of the image in<br/>pixels.<br/>These must be values greater than or equal to 1.</param>
        /// <param name="image_row_pitch">image_row_pitch is the  scan-line pitch in bytes.<br/>This must be 0 if host_ptr is NULL and can be either 0 or ≥<br/>image_width × size of element in bytes if host_ptr is not NULL.<br/>If host_ptr is not NULL and image_row_pitch is 0, image_row_pitch<br/>is calculated as image_width × size of element in bytes.<br/>If image_row_pitch is not 0, it must be a multiple of the image element<br/>size in bytes.</param>
        /// <param name="host_ptr">host_ptr is a pointer to the image data that may already be allocated by<br/>the application.<br/>Refer to the CL_MEM_OBJECT_IMAGE2D entry in the<br/>required host_ptr buffer size table for a<br/>description of how large the buffer that host_ptr points to must be.<br/>The image data specified by host_ptr is stored as a linear sequence of<br/>adjacent scanlines.<br/>Each scanline is a linear sequence of image elements.<br/>Image elements are stored according to their image format as described in<br/>the Image Format Descriptor section.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateImage2D.html"/></remarks>
        public static IntPtr CreateImage2D(IntPtr context, MemFlags flags, cl_image_format* image_format, nuint image_width, nuint image_height, nuint image_row_pitch, void* host_ptr, int* errcode_ret) => CLPointers.clCreateImage2D_Lazy(context, (ulong)flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateImage3D</c>]</b><br/> Creates a 3D image. </summary>
        /// <param name="context">context is a valid OpenCL context on which the image object is to be<br/>created.</param>
        /// <param name="flags">flags is a bit-field that is used to specify allocation and usage<br/>information about the image memory object being created and is described in<br/>the supported memory flag values table.<br/>If the value specified for flags is 0, the default is used which is<br/>CL_MEM_READ_WRITE.</param>
        /// <param name="image_format">image_format is a pointer to a structure that describes format properties<br/>of the image to be allocated.<br/>Refer to the Image Format Descriptor section<br/>for a detailed description of the image format descriptor.</param>
        /// <param name="image_width">image_width and image_height are the width and height of the image in<br/>pixels.<br/>These must be values greater than or equal to 1.</param>
        /// <param name="image_depth">image_depth is the depth of the image in pixels.  For clCreateImage3D,<br/>this must be a value &gt; 1.</param>
        /// <param name="image_row_pitch">image_row_pitch is the  scan-line pitch in bytes.<br/>This must be 0 if host_ptr is NULL and can be either 0 or ≥<br/>image_width × size of element in bytes if host_ptr is not NULL.<br/>If host_ptr is not NULL and image_row_pitch is 0, image_row_pitch<br/>is calculated as image_width × size of element in bytes.<br/>If image_row_pitch is not 0, it must be a multiple of the image element<br/>size in bytes.</param>
        /// <param name="image_slice_pitch">image_slice_pitch is the size in bytes of each 2D slice in the 3D image.<br/>This must be 0 if host_ptr is NULL and can be 0 or ≥<br/>image_row_pitch × image_height if host_ptr is not NULL.<br/>If host_ptr is not NULL and image_slice_pitch is 0,<br/>image_slice_pitch is calculated as image_row_pitch ×<br/>image_height.<br/>If image_slice_pitch is not 0, it must be a multiple of the<br/>image_row_pitch.</param>
        /// <param name="host_ptr">host_ptr is a pointer to the image data that may already be allocated by<br/>the application.<br/>Refer to the CL_MEM_OBJECT_IMAGE3D entry in the<br/>required host_ptr buffer size table for a<br/>description of how large the buffer that host_ptr points to must be.<br/>The image data specified by host_ptr is stored as a linear sequence of<br/>adjacent 2D slices.<br/>Each scanline is a linear sequence of image elements.<br/>Image elements are stored according to their image format as described in<br/>the Image Format Descriptor section.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateImage3D.html"/></remarks>
        public static IntPtr CreateImage3D(IntPtr context, MemFlags flags, cl_image_format* image_format, nuint image_width, nuint image_height, nuint image_depth, nuint image_row_pitch, nuint image_slice_pitch, void* host_ptr, int* errcode_ret) => CLPointers.clCreateImage3D_Lazy(context, (ulong)flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>clCreateImageWithProperties</c>]</b><br/> Creates a 1D image, 1D image buffer, 1D image array, 2D image, 2D image array or 3D image object. </summary>
        /// <param name="context">context is a valid OpenCL context used to create the image object.</param>
        /// <param name="properties">properties is an optional list of properties for the image object and their corresponding values.<br/>The list is terminated with the special property 0.<br/>If no properties are required, properties may be NULL.<br/>OpenCL does not define any optional properties for images,<br/>but extensions may define properties as described in the<br/>https://www.khronos.org/registry/OpenCL/specs/unified/html/OpenCL_API.html#external-image-memory-properties-table.</param>
        /// <param name="flags">flags is a bit-field that is used to specify allocation and usage<br/>information about the image memory object being created and is described in<br/>the supported memory flag values table.</param>
        /// <param name="image_format">image_format is a pointer to a structure that describes format properties<br/>of the image to be allocated.<br/>A 1D image buffer can be created from a buffer by specifying a buffer object<br/>in image_desc→mem_object.<br/>If the cl_khr_image2d_from_buffer extension is supported, a 2D image<br/>can be created from a buffer by specifying a buffer object in<br/>image_desc→mem_object.<br/>If the cl_ext_image_from_buffer extension is supported, an image of<br/>any type can be created from a buffer by specifying a buffer object in<br/>image_desc→mem_object.<br/>A 2D image can be created from another 2D image object by specifying an<br/>image object in the image_desc→mem_object.<br/>Refer to the Image Format Descriptor section<br/>for a detailed description of the image format descriptor.</param>
        /// <param name="image_desc">image_desc is a pointer to a structure that describes type and dimensions<br/>of the image to be allocated.<br/>Refer to the Image Descriptor section for a detailed<br/>description of the image descriptor.</param>
        /// <param name="host_ptr">host_ptr is a pointer to the image data that may already be allocated by<br/>the application.<br/>Refer to the table below for a description<br/>of how large the buffer that host_ptr points to must be.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateImageWithProperties.html"/></remarks>
        public static IntPtr CreateImageWithProperties(IntPtr context, MemProperties* properties, MemFlags flags, cl_image_format* image_format, cl_image_desc* image_desc, void* host_ptr, int* errcode_ret) => CLPointers.clCreateImageWithProperties_Lazy(context, (ulong*)properties, (ulong)flags, image_format, image_desc, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateKernel</c>]</b><br/> Creates a kernel object. </summary>
        /// <param name="program">program is a program object with a successfully built executable.</param>
        /// <param name="kernel_name">kernel_name is a function name in the program declared with the<br/>__kernel qualifier.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateKernel.html"/></remarks>
        public static IntPtr CreateKernel(IntPtr program, byte* kernel_name, int* errcode_ret) => CLPointers.clCreateKernel_Lazy(program, kernel_name, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateKernelsInProgram</c>]</b><br/> Creates kernel objects for all kernel functions in a program object. </summary>
        /// <param name="program">program is a program object with a successfully built executable.</param>
        /// <param name="num_kernels">num_kernels is the size of memory pointed to by kernels specified as the<br/>number of cl_kernel entries.</param>
        /// <param name="kernels">kernels is the buffer where the kernel objects for kernels in program<br/>will be returned.<br/>If kernels is NULL, it is ignored.<br/>If kernels is not NULL, num_kernels must be greater than or equal to<br/>the number of kernels in program.</param>
        /// <param name="num_kernels_ret">num_kernels_ret is the number of kernels in program.<br/>If num_kernels_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateKernelsInProgram.html"/></remarks>
        public static int CreateKernelsInProgram(IntPtr program, uint num_kernels, IntPtr* kernels, uint* num_kernels_ret) => CLPointers.clCreateKernelsInProgram_Lazy(program, num_kernels, kernels, num_kernels_ret);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clCreatePipe</c>]</b><br/> Creates a pipe object. </summary>
        /// <param name="context">context is a valid OpenCL context used to create the pipe object.</param>
        /// <param name="flags">flags is a bit-field that is used to specify allocation and usage<br/>information such as the memory arena that should be used to allocate the<br/>pipe object and how it will be used.<br/>The Memory Flags table describes the possible values for<br/>flags.<br/>Only CL_MEM_READ_WRITE and CL_MEM_HOST_NO_ACCESS can be specified when<br/>creating a pipe object.<br/>If the value specified for flags is 0, the default is used which is<br/>CL_MEM_READ_WRITE | CL_MEM_HOST_NO_ACCESS.</param>
        /// <param name="pipe_packet_size">pipe_packet_size is the size in bytes of a pipe packet.</param>
        /// <param name="pipe_max_packets">pipe_max_packets specifies the pipe capacity by specifying the maximum<br/>number of packets the pipe can hold.</param>
        /// <param name="properties">properties specifies a list of properties for the pipe and their<br/>corresponding values.<br/>Each property name is immediately followed by the corresponding desired<br/>value.<br/>The list is terminated with 0.<br/>Currently, in all OpenCL versions, properties must be NULL.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreatePipe.html"/></remarks>
        public static IntPtr CreatePipe(IntPtr context, MemFlags flags, uint pipe_packet_size, uint pipe_max_packets, IntPtr* properties, int* errcode_ret) => CLPointers.clCreatePipe_Lazy(context, (ulong)flags, pipe_packet_size, pipe_max_packets, properties, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateProgramWithBinary</c>]</b><br/> Creates a program object for a context, and loads binary bits into the program object. </summary>
        /// <param name="context">context must be a valid OpenCL context.</param>
        /// <param name="num_devices">num_devices is the number of devices listed in device_list.</param>
        /// <param name="device_list">device_list is a pointer to a list of devices that are in context.<br/>device_list must be a non-NULL value.<br/>The binaries are loaded for devices specified in this list.</param>
        /// <param name="lengths">lengths is an array of the size in bytes of the program binaries to be<br/>loaded for devices specified by device_list.</param>
        /// <param name="binaries">binaries is an array of pointers to program binaries to be loaded for<br/>devices specified by device_list.<br/>For each device given by device_list[i], the pointer to the program binary<br/>for that device is given by binaries[i] and the length of this<br/>corresponding binary is given by lengths[i].<br/>lengths[i] cannot be zero and binaries[i] cannot be a NULL pointer.</param>
        /// <param name="binary_status">binary_status returns whether the program binary for each device specified<br/>in device_list was loaded successfully or not.<br/>It is an array of num_devices entries and returns CL_SUCCESS in<br/>binary_status[i] if binary was successfully loaded for device specified by<br/>device_list[i]; otherwise returns CL_INVALID_VALUE if lengths[i] is zero<br/>or if binaries[i] is a NULL value or CL_INVALID_BINARY in<br/>binary_status[i] if program binary is not a valid binary for the specified<br/>device.<br/>If binary_status is NULL, it is ignored.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateProgramWithBinary.html"/></remarks>
        public static IntPtr CreateProgramWithBinary(IntPtr context, uint num_devices, IntPtr* device_list, nuint* lengths, byte** binaries, int* binary_status, int* errcode_ret) => CLPointers.clCreateProgramWithBinary_Lazy(context, num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clCreateProgramWithBuiltInKernels</c>]</b><br/> Creates a program object for a context, and loads the information related to the built-in kernels into a program object. </summary>
        /// <param name="context">context must be a valid OpenCL context.</param>
        /// <param name="num_devices">num_devices is the number of devices listed in device_list.</param>
        /// <param name="device_list">device_list is a pointer to a list of devices that are in context.<br/>device_list must be a non-NULL value.<br/>The built-in kernels are loaded for devices specified in this list.</param>
        /// <param name="kernel_names">kernel_names is a semi-colon separated list of built-in kernel names.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateProgramWithBuiltInKernels.html"/></remarks>
        public static IntPtr CreateProgramWithBuiltInKernels(IntPtr context, uint num_devices, IntPtr* device_list, byte* kernel_names, int* errcode_ret) => CLPointers.clCreateProgramWithBuiltInKernels_Lazy(context, num_devices, device_list, kernel_names, errcode_ret);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clCreateProgramWithIL</c>]</b><br/> Creates a program object for a context, and loads the IL into the program object. </summary>
        /// <param name="context">context must be a valid OpenCL context.</param>
        /// <param name="il">il is a pointer to a block of memory containing SPIR-V or an<br/>implementation-defined intermediate language.</param>
        /// <param name="length">length is the length of the block pointed to by il.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateProgramWithIL.html"/></remarks>
        public static IntPtr CreateProgramWithIL(IntPtr context, void* il, nuint length, int* errcode_ret) => CLPointers.clCreateProgramWithIL_Lazy(context, il, length, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateProgramWithSource</c>]</b><br/> Creates a program object for a context, and loads source code specified by text strings into the program object. </summary>
        /// <param name="context">context must be a valid OpenCL context.</param>
        /// <param name="strings">strings is an array of count pointers to optionally null-terminated<br/>character strings that make up the source code.</param>
        /// <param name="lengths">lengths argument is an array with the number of chars in each string<br/>(the string length).<br/>If an element in lengths is zero, its accompanying string is<br/>null-terminated.<br/>If lengths is NULL, all strings in the strings argument are considered<br/>null-terminated.<br/>Any length value passed in that is greater than zero excludes the null<br/>terminator in its count.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateProgramWithSource.html"/></remarks>
        public static IntPtr CreateProgramWithSource(IntPtr context, uint count, byte** strings, nuint* lengths, int* errcode_ret) => CLPointers.clCreateProgramWithSource_Lazy(context, count, strings, lengths, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateSampler</c>]</b><br/> Creates a sampler object. </summary>
        /// <param name="context">context must be a valid OpenCL context.</param>
        /// <param name="normalized_coords">normalized_coords has the same interpretation as<br/>CL_SAMPLER_NORMALIZED_COORDS in the sampler<br/>creation properties table.</param>
        /// <param name="addressing_mode">addressing_mode has the same interpretation as<br/>CL_SAMPLER_ADDRESSING_MODE in the sampler<br/>creation properties table.</param>
        /// <param name="filter_mode">filter_mode has the same interpretation as<br/>CL_SAMPLER_FILTER_MODE in the sampler<br/>creation properties table.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateSampler.html"/></remarks>
        public static IntPtr CreateSampler(IntPtr context, Bool normalized_coords, AddressingMode addressing_mode, FilterMode filter_mode, int* errcode_ret) => CLPointers.clCreateSampler_Lazy(context, (uint)normalized_coords, (uint)addressing_mode, (uint)filter_mode, errcode_ret);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clCreateSamplerWithProperties</c>]</b><br/> Creates a sampler object. </summary>
        /// <param name="context">context must be a valid OpenCL context.</param>
        /// <param name="sampler_properties">sampler_properties specifies a list of sampler property names and their<br/>corresponding values.<br/>Each sampler property name is immediately followed by the corresponding<br/>desired value.<br/>The list is terminated with 0.<br/>The list of supported properties is described in the<br/>Sampler Properties table.<br/>If a supported property and its value is not specified in<br/>sampler_properties, its default value will be used.<br/>sampler_properties can be NULL in which case the default values for<br/>supported sampler properties will be used.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateSamplerWithProperties.html"/></remarks>
        public static IntPtr CreateSamplerWithProperties(IntPtr context, ulong* sampler_properties, int* errcode_ret) => CLPointers.clCreateSamplerWithProperties_Lazy(context, sampler_properties, errcode_ret);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clCreateSubBuffer</c>]</b><br/> Creates a new buffer object (referred to as a sub-buffer object) from an existing buffer object. </summary>
        /// <param name="buffer">buffer must be a valid buffer object and cannot be a sub-buffer object.</param>
        /// <param name="flags">flags is a bit-field that is used to specify allocation and usage<br/>information about the sub-buffer memory object being created and is<br/>described in the Memory Flags table.<br/>If the CL_MEM_READ_WRITE, CL_MEM_READ_ONLY,<br/>CL_MEM_IMMUTABLE_EXT,<br/>or CL_MEM_WRITE_ONLY values are<br/>not specified in flags, they are inherited from the corresponding memory<br/>access qualifiers associated with buffer.<br/>The CL_MEM_USE_HOST_PTR, CL_MEM_ALLOC_HOST_PTR, and CL_MEM_COPY_HOST_PTR<br/>values cannot be specified in flags but are inherited from the<br/>corresponding memory access qualifiers associated with buffer.<br/>If CL_MEM_COPY_HOST_PTR is specified in the memory access qualifier values<br/>associated with buffer it does not imply any additional copies when the<br/>sub-buffer is created from buffer.<br/>If the CL_MEM_HOST_WRITE_ONLY, CL_MEM_HOST_READ_ONLY, or<br/>CL_MEM_HOST_NO_ACCESS values are not specified in flags, they are<br/>inherited from the corresponding memory access qualifiers associated with<br/>buffer.</param>
        /// <param name="buffer_create_type">buffer_create_type and buffer_create_info describe the type of buffer<br/>object to be created.<br/>The list of supported values for buffer_create_type and corresponding<br/>descriptor that buffer_create_info points to is described in the<br/>SubBuffer Attributes table.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateSubBuffer.html"/></remarks>
        public static IntPtr CreateSubBuffer(IntPtr buffer, MemFlags flags, BufferCreateType buffer_create_type, void* buffer_create_info, int* errcode_ret) => CLPointers.clCreateSubBuffer_Lazy(buffer, (ulong)flags, (uint)buffer_create_type, buffer_create_info, errcode_ret);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clCreateSubDevices</c>]</b><br/> Create sub-devices partitioning an OpenCL device </summary>
        /// <param name="in_device">in_device is the device to be partitioned.</param>
        /// <param name="properties">properties specifies how in_device is to be partitioned, described by a<br/>partition name and its corresponding value.<br/>Each partition name is immediately followed by the corresponding desired<br/>value.<br/>The list is terminated with 0.<br/>The list of supported partitioning schemes is described in the<br/>Sub-device Partition table.<br/>Only one of the listed partitioning schemes can be specified in<br/>properties.</param>
        /// <param name="num_devices">num_devices is the size of memory pointed to by out_devices specified as<br/>the number of cl_device_id entries.</param>
        /// <param name="out_devices">out_devices is the buffer where the OpenCL sub-devices will be returned.<br/>If out_devices is NULL, this argument is ignored.<br/>If out_devices is not NULL, num_devices must be greater than or equal<br/>to the number of sub-devices that device may be partitioned into according<br/>to the partitioning scheme specified in properties.</param>
        /// <param name="num_devices_ret">num_devices_ret returns the number of sub-devices that device may be<br/>partitioned into according to the partitioning scheme specified in<br/>properties.<br/>If num_devices_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateSubDevices.html"/></remarks>
        public static int CreateSubDevices(IntPtr in_device, IntPtr* properties, uint num_devices, IntPtr* out_devices, uint* num_devices_ret) => CLPointers.clCreateSubDevices_Lazy(in_device, properties, num_devices, out_devices, num_devices_ret);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clCreateUserEvent</c>]</b><br/> Creates a user event object. </summary>
        /// <param name="context">context must be a valid OpenCL context.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clCreateUserEvent.html"/></remarks>
        public static IntPtr CreateUserEvent(IntPtr context, int* errcode_ret) => CLPointers.clCreateUserEvent_Lazy(context, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueBarrier</c>]</b><br/> A synchronization point that enqueues a barrier operation. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueBarrier.html"/></remarks>
        public static int EnqueueBarrier(IntPtr command_queue) => CLPointers.clEnqueueBarrier_Lazy(command_queue);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clEnqueueBarrierWithWaitList</c>]</b><br/> A synchronization point that enqueues a barrier operation. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueBarrierWithWaitList.html"/></remarks>
        public static int EnqueueBarrierWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueBarrierWithWaitList_Lazy(command_queue, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueCopyBuffer</c>]</b><br/> Enqueues a command to copy from one buffer object to another. </summary>
        /// <param name="command_queue">command_queue refers to a host command-queue in which the copy command<br/>will be queued.<br/>The OpenCL context associated with command_queue, src_buffer and<br/>dst_buffer must be the same.</param>
        /// <param name="src_offset">src_offset refers to the offset where to begin copying data from<br/>src_buffer.</param>
        /// <param name="dst_offset">dst_offset refers to the offset where to begin copying data into<br/>dst_buffer.</param>
        /// <param name="size">size refers to the size in bytes to copy.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueCopyBuffer.html"/></remarks>
        public static int EnqueueCopyBuffer(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCopyBuffer_Lazy(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clEnqueueCopyBufferRect</c>]</b><br/> Enqueues a command to copy a 2D or 3D rectangular region from a buffer object to another buffer object. </summary>
        /// <param name="command_queue">command_queue refers to the host command-queue in which the copy command<br/>will be queued.<br/>The OpenCL context associated with command_queue, src_buffer and<br/>dst_buffer must be the same.</param>
        /// <param name="src_origin">src_origin defines the (x, y, z) offset in the memory region<br/>associated with src_buffer.<br/>For a 2D rectangle region, the z value given by src_origin[2] should be<br/>0.<br/>The offset in bytes is computed as src_origin[2] × src_slice_pitch<br/>+ src_origin[1] × src_row_pitch + src_origin[0].</param>
        /// <param name="dst_origin">dst_origin defines the (x, y, z) offset in the memory region<br/>associated with dst_buffer.<br/>For a 2D rectangle region, the z value given by dst_origin[2] should be<br/>0.<br/>The offset in bytes is computed as dst_origin[2] × dst_slice_pitch<br/>+ dst_origin[1] × dst_row_pitch + dst_origin[0].</param>
        /// <param name="region">region defines the (width in bytes, height in rows, depth in slices)<br/>of the 2D or 3D rectangle being copied.<br/>For a 2D rectangle, the depth value given by region[2] should be 1.<br/>The values in region cannot be 0.</param>
        /// <param name="src_row_pitch">src_row_pitch is the length of each row in bytes to be used for the memory<br/>region associated with src_buffer.<br/>If src_row_pitch is 0, src_row_pitch is computed as region[0].</param>
        /// <param name="src_slice_pitch">src_slice_pitch is the length of each 2D slice in bytes to be used for the<br/>memory region associated with src_buffer.<br/>If src_slice_pitch is 0, src_slice_pitch is computed as region[1]<br/>× src_row_pitch.</param>
        /// <param name="dst_row_pitch">dst_row_pitch is the length of each row in bytes to be used for the memory<br/>region associated with dst_buffer.<br/>If dst_row_pitch is 0, dst_row_pitch is computed as region[0].</param>
        /// <param name="dst_slice_pitch">dst_slice_pitch is the length of each 2D slice in bytes to be used for the<br/>memory region associated with dst_buffer.<br/>If dst_slice_pitch is 0, dst_slice_pitch is computed as region[1]<br/>× dst_row_pitch.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueCopyBufferRect.html"/></remarks>
        public static int EnqueueCopyBufferRect(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, nuint* src_origin, nuint* dst_origin, nuint* region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCopyBufferRect_Lazy(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueCopyBufferToImage</c>]</b><br/> Enqueues a command to copy a buffer object to an image object. </summary>
        /// <param name="command_queue">command_queue must be a valid host command-queue.<br/>The OpenCL context associated with command_queue, src_buffer and<br/>dst_image must be the same.</param>
        /// <param name="src_buffer">src_buffer is a valid buffer object.</param>
        /// <param name="dst_image">dst_image is a valid image object.</param>
        /// <param name="src_offset">src_offset refers to the offset where to begin copying data from<br/>src_buffer.</param>
        /// <param name="dst_origin">dst_origin defines the (x, y, z) offset in pixels in the 1D, 2D or<br/>3D image, the (x, y) offset and the image index in the 2D image array or<br/>the (x) offset and the image index in the 1D image array.<br/>If dst_image is a 2D image object, dst_origin[2] must be 0.<br/>If dst_image is a 1D image or 1D image buffer object, dst_origin[1] and<br/>dst_origin[2] must be 0.<br/>If dst_image is a 1D image array object, dst_origin[2] must be 0.<br/>If dst_image is a 1D image array object, dst_origin[1] describes the<br/>image index in the 1D image array.<br/>If dst_image is a 2D image array object, dst_origin[2] describes the<br/>image index in the 2D image array.<br/>If dst_image is a mipmapped image, the mip level to write is<br/>determined from dst_origin as described in Specifying Mipmap Levels to Image Operations</param>
        /// <param name="region">region defines the (width, height, depth) in pixels of the 1D, 2D or<br/>3D rectangle, the (width, height) in pixels of the 2D rectangle and the<br/>number of images of a 2D image array or the (width) in pixels of the 1D<br/>rectangle and the number of images of a 1D image array.<br/>If dst_image is a 2D image object, region[2] must be 1.<br/>If dst_image is a 1D image or 1D image buffer object, region[1] and<br/>region[2] must be 1.<br/>If dst_image is a 1D image array object, region[2] must be 1.<br/>The values in region cannot be 0.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueCopyBufferToImage.html"/></remarks>
        public static int EnqueueCopyBufferToImage(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, nuint* dst_origin, nuint* region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCopyBufferToImage_Lazy(command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueCopyImage</c>]</b><br/> Enqueues a command to copy image objects. </summary>
        /// <param name="command_queue">command_queue refers to the host command-queue in which the copy command<br/>will be queued.<br/>The OpenCL context associated with command_queue, src_image and<br/>dst_image must be the same.</param>
        /// <param name="src_image">src_image and dst_image can be 1D, 2D, 3D image or a 1D, 2D image array<br/>objects.<br/>It is possible to copy subregions between any combinations of source and<br/>destination types, provided that the dimensions of the subregions are the<br/>same e.g., one can copy a rectangular region from a 2D image to a slice of a<br/>3D image.</param>
        /// <param name="src_origin">src_origin defines the (x, y, z) offset in pixels in the 1D, 2D or<br/>3D image, the (x, y) offset and the image index in the 2D image array or<br/>the (x) offset and the image index in the 1D image array.<br/>If image is a 2D image object, src_origin[2] must be 0.<br/>If src_image is a 1D image object, src_origin[1] and src_origin[2]<br/>must be 0.<br/>If src_image is a 1D image array object, src_origin[2] must be 0.<br/>If src_image is a 1D image array object, src_origin[1] describes the<br/>image index in the 1D image array.<br/>If src_image is a 2D image array object, src_origin[2] describes the<br/>image index in the 2D image array.<br/>If src_image is a mipmapped image, the mip level to read is determined<br/>from src_origin as described in Specifying<br/>Mipmap Levels to Image Operations</param>
        /// <param name="dst_origin">dst_origin defines the (x, y, z) offset in pixels in the 1D, 2D or<br/>3D image, the (x, y) offset and the image index in the 2D image array or<br/>the (x) offset and the image index in the 1D image array.<br/>If dst_image is a 2D image object, dst_origin[2] must be 0.<br/>If dst_image is a 1D image or 1D image buffer object, dst_origin[1] and<br/>dst_origin[2] must be 0.<br/>If dst_image is a 1D image array object, dst_origin[2] must be 0.<br/>If dst_image is a 1D image array object, dst_origin[1] describes the<br/>image index in the 1D image array.<br/>If dst_image is a 2D image array object, dst_origin[2] describes the<br/>image index in the 2D image array.<br/>If dst_image is a mipmapped image, the mip level to write is<br/>determined from dst_origin as described in Specifying Mipmap Levels to Image Operations</param>
        /// <param name="region">region defines the (width, height, depth) in pixels of the 1D, 2D or<br/>3D rectangle, the (width, height) in pixels of the 2D rectangle and the<br/>number of images of a 2D image array or the (width) in pixels of the 1D<br/>rectangle and the number of images of a 1D image array.<br/>If src_image or dst_image is a 2D image object, region[2] must be 1.<br/>If src_image or dst_image is a 1D image or 1D image buffer object,<br/>region[1] and region[2] must be 1.<br/>If src_image or dst_image is a 1D image array object, region[2] must<br/>be 1.<br/>The values in region cannot be 0.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueCopyImage.html"/></remarks>
        public static int EnqueueCopyImage(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, nuint* src_origin, nuint* dst_origin, nuint* region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCopyImage_Lazy(command_queue, src_image, dst_image, src_origin, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueCopyImageToBuffer</c>]</b><br/> Enqueues a command to copy an image object to a buffer object. </summary>
        /// <param name="command_queue">command_queue must be a valid host command-queue.<br/>The OpenCL context associated with command_queue, src_image and<br/>dst_buffer must be the same.</param>
        /// <param name="src_image">src_image is a valid image object.</param>
        /// <param name="dst_buffer">dst_buffer is a valid buffer object.</param>
        /// <param name="src_origin">src_origin defines the (x, y, z) offset in pixels in the 1D, 2D or<br/>3D image, the (x, y) offset and the image index in the 2D image array or<br/>the (x) offset and the image index in the 1D image array.<br/>If src_image is a 2D image object, src_origin[2] must be 0.<br/>If src_image is a 1D image or 1D image buffer object, src_origin[1] and<br/>src_origin[2] must be 0.<br/>If src_image is a 1D image array object, src_origin[2] must be 0.<br/>If src_image is a 1D image array object, src_origin[1] describes the<br/>image index in the 1D image array.<br/>If src_image is a 2D image array object, src_origin[2] describes the<br/>image index in the 2D image array.<br/>If src_image is a mipmapped image, the mip level to read is determined<br/>from src_origin as described in Specifying<br/>Mipmap Levels to Image Operations</param>
        /// <param name="region">region defines the (width, height, depth) in pixels of the 1D, 2D or<br/>3D rectangle, the (width, height) in pixels of the 2D rectangle and the<br/>number of images of a 2D image array or the (width) in pixels of the 1D<br/>rectangle and the number of images of a 1D image array.<br/>If src_image is a 2D image object, region[2] must be 1.<br/>If src_image is a 1D image or 1D image buffer object, region[1] and<br/>region[2] must be 1.<br/>If src_image is a 1D image array object, region[2] must be 1.<br/>The values in region cannot be 0.</param>
        /// <param name="dst_offset">dst_offset refers to the offset where to begin copying data into<br/>dst_buffer.<br/>The size in bytes of the region to be copied referred to as dst_cb is<br/>computed as width × height × depth × bytes/image<br/>element if src_image is a 3D image object, is computed as width ×<br/>height × bytes/image element if src_image is a 2D image, is<br/>computed as width × height × arraysize ×<br/>bytes/image element if src_image is a 2D image array object, is computed<br/>as width × bytes/image element if src_image is a 1D image or 1D<br/>image buffer object and is computed as width × arraysize ×<br/>bytes/image element if src_image is a 1D image array object.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueCopyImageToBuffer.html"/></remarks>
        public static int EnqueueCopyImageToBuffer(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, nuint* src_origin, nuint* region, nuint dst_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCopyImageToBuffer_Lazy(command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clEnqueueFillBuffer</c>]</b><br/> Enqueues a command to fill a buffer object with a pattern of a given pattern size. </summary>
        /// <param name="command_queue">command_queue refers to the host command-queue in which the fill command<br/>will be queued.<br/>The OpenCL context associated with command_queue and buffer must be the<br/>same.</param>
        /// <param name="buffer">buffer is a valid buffer object.</param>
        /// <param name="pattern">pattern is a pointer to the data pattern of size pattern_size in bytes.<br/>pattern will be used to fill a region in buffer starting at offset and<br/>is size bytes in size.<br/>The data pattern must be a scalar or vector integer or floating-point data<br/>type supported by OpenCL as described in Shared<br/>Application Scalar Data Types and Supported<br/>Application Vector Data Types.<br/>For example, if buffer is to be filled with a pattern of float4 values,<br/>then pattern will be a pointer to a cl_float4 value and pattern_size<br/>will be sizeof(cl_float4).<br/>The maximum value of pattern_size is the size of the largest integer or<br/>floating-point vector data type supported by the OpenCL device.<br/>The memory associated with pattern can be reused or freed after the<br/>function returns.</param>
        /// <param name="offset">offset is the location in bytes of the region being filled in buffer and<br/>must be a multiple of pattern_size.</param>
        /// <param name="size">size is the size in bytes of region being filled in buffer and must be a<br/>multiple of pattern_size.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueFillBuffer.html"/></remarks>
        public static int EnqueueFillBuffer(IntPtr command_queue, IntPtr buffer, void* pattern, nuint pattern_size, nuint offset, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueFillBuffer_Lazy(command_queue, buffer, pattern, pattern_size, offset, size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clEnqueueFillImage</c>]</b><br/> Enqueues a command to fill an image object with a specified color. </summary>
        /// <param name="command_queue">command_queue refers to the host command-queue in which the fill command<br/>will be queued.<br/>The OpenCL context associated with command_queue and image must be the<br/>same.</param>
        /// <param name="image">image is a valid image object.</param>
        /// <param name="fill_color">fill_color is the color used to fill the image.<br/>The fill color is a single floating-point value if the channel order is<br/>CL_DEPTH.<br/>Otherwise, the fill color is a four component RGBA floating-point color<br/>value if the image channel data type is not an unnormalized signed or<br/>unsigned integer type, is a four component signed integer value if the<br/>image channel data type is an unnormalized signed integer type and is a<br/>four component unsigned integer value if the image channel data type is an<br/>unnormalized unsigned integer type.<br/>The fill color will be converted to the appropriate image channel format<br/>and order associated with image.</param>
        /// <param name="origin">origin defines the (x, y, z) offset in pixels in the 1D, 2D or 3D<br/>image, the (x, y) offset and the image index in the 2D image array or<br/>the (x) offset and the image index in the 1D image array.<br/>If image is a 2D image object, origin[2] must be 0.<br/>If image is a 1D image or 1D image buffer object, origin[1] and<br/>origin[2] must be 0.<br/>If image is a 1D image array object, origin[2] must be 0.<br/>If image is a 1D image array object, origin[1] describes the image index<br/>in the 1D image array.<br/>If image is a 2D image array object, origin[2] describes the image index<br/>in the 2D image array.<br/>If image is a mipmapped image, the mip level to fill is determined<br/>from origin as described in Specifying Mipmap<br/>Levels to Image Operations</param>
        /// <param name="region">region defines the (width, height, depth) in pixels of the 1D, 2D or<br/>3D rectangle, the (width, height) in pixels of the 2D rectangle and the<br/>number of images of a 2D image array or the (width) in pixels of the 1D<br/>rectangle and the number of images of a 1D image array.<br/>If image is a 2D image object, region[2] must be 1.<br/>If image is a 1D image or 1D image buffer object, region[1] and<br/>region[2] must be 1.<br/>If image is a 1D image array object, region[2] must be 1.<br/>The values in region cannot be 0.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueFillImage.html"/></remarks>
        public static int EnqueueFillImage(IntPtr command_queue, IntPtr image, void* fill_color, nuint* origin, nuint* region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueFillImage_Lazy(command_queue, image, fill_color, origin, region, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueMapBuffer</c>]</b><br/> Enqueues a command to map a region of a buffer object into the host address space and returns a pointer to this mapped region. </summary>
        /// <param name="command_queue">command_queue must be a valid host command-queue.</param>
        /// <param name="blocking_map">blocking_map indicates if the map operation is blocking or<br/>non-blocking.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueMapBuffer.html"/></remarks>
        public static void* EnqueueMapBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_map, MapFlags map_flags, nuint offset, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event, int* errcode_ret) => CLPointers.clEnqueueMapBuffer_Lazy(command_queue, buffer, (uint)blocking_map, (ulong)map_flags, offset, size, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueMapImage</c>]</b><br/> Enqueues a command to map a region of an image object into the host address space and returns a pointer to this mapped region. </summary>
        /// <param name="command_queue">command_queue must be a valid host command-queue.</param>
        /// <param name="image">image is a valid image object.<br/>The OpenCL context associated with command_queue and image must be the<br/>same.</param>
        /// <param name="blocking_map">blocking_map indicates if the map operation is blocking or<br/>non-blocking.</param>
        /// <param name="map_flags">map_flags is a bit-field and is described in the<br/>Memory Map Flags table.</param>
        /// <param name="origin">origin defines the (x, y, z) offset in pixels in the 1D, 2D or 3D<br/>image, the (x, y) offset and the image index in the 2D image array or<br/>the (x) offset and the image index in the 1D image array.<br/>If image is a 2D image object, origin[2] must be 0.<br/>If image is a 1D image or 1D image buffer object, origin[1] and<br/>origin[2] must be 0.<br/>If image is a 1D image array object, origin[2] must be 0.<br/>If image is a 1D image array object, origin[1] describes the image index<br/>in the 1D image array.<br/>If image is a 2D image array object, origin[2] describes the image index<br/>in the 2D image array.</param>
        /// <param name="region">region defines the (width, height, depth) in pixels of the 1D, 2D or<br/>3D rectangle, the (width, height) in pixels of the 2D rectangle and the<br/>number of images of a 2D image array or the (width) in pixels of the 1D<br/>rectangle and the number of images of a 1D image array.<br/>If image is a 2D image object, region[2] must be 1.<br/>If image is a 1D image or 1D image buffer object, region[1] and<br/>region[2] must be 1.<br/>If image is a 1D image array object, region[2] must be 1.<br/>The values in region cannot be 0.</param>
        /// <param name="image_row_pitch">image_row_pitch returns the scan-line pitch in bytes for the mapped<br/>region.<br/>This must be a non-NULL value.</param>
        /// <param name="image_slice_pitch">image_slice_pitch returns the size in bytes of each 2D slice of a 3D image<br/>or the size of each 1D or 2D image in a 1D or 2D image array for the mapped<br/>region.<br/>For a 1D and 2D image, zero is returned if this argument is not NULL.<br/>For a 3D image, 1D and 2D image array, image_slice_pitch must be a<br/>non-NULL value.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before clEnqueueMapImage can be executed.<br/>If event_wait_list is NULL, then clEnqueueMapImage does not wait on<br/>any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueMapImage.html"/></remarks>
        public static void* EnqueueMapImage(IntPtr command_queue, IntPtr image, Bool blocking_map, MapFlags map_flags, nuint* origin, nuint* region, nuint* image_row_pitch, nuint* image_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event, int* errcode_ret) => CLPointers.clEnqueueMapImage_Lazy(command_queue, image, (uint)blocking_map, (ulong)map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueMarker</c>]</b><br/> Enqueues a marker command which waits for all previously enqueued commands to complete. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueMarker.html"/></remarks>
        public static int EnqueueMarker(IntPtr command_queue, IntPtr* @event) => CLPointers.clEnqueueMarker_Lazy(command_queue, @event);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clEnqueueMarkerWithWaitList</c>]</b><br/> Enqueues a marker command which waits for either a list of events to complete, or all previously enqueued commands to complete. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueMarkerWithWaitList.html"/></remarks>
        public static int EnqueueMarkerWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMarkerWithWaitList_Lazy(command_queue, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clEnqueueMigrateMemObjects</c>]</b><br/> Enqueues a command to indicate which device a set of memory objects should be associated with. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.<br/>The specified set of memory objects in mem_objects will be migrated to the<br/>OpenCL device associated with command_queue or to the host if the<br/>CL_MIGRATE_MEM_OBJECT_HOST has been specified.</param>
        /// <param name="num_mem_objects">num_mem_objects is the number of memory objects specified in<br/>mem_objects.</param>
        /// <param name="mem_objects">mem_objects is a pointer to a list of memory objects.</param>
        /// <param name="flags">flags is a bit-field that is used to specify migration options.<br/>The Memory Migration Flags describes the possible<br/>values for flags.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueMigrateMemObjects.html"/></remarks>
        public static int EnqueueMigrateMemObjects(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMigrateMemObjects_Lazy(command_queue, num_mem_objects, mem_objects, (ulong)flags, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueNativeKernel</c>]</b><br/> Enqueues a command to execute a native C/C++ function not compiled using the OpenCL compiler. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.<br/>A native user function can only be executed on a command-queue created on a<br/>device that has CL_EXEC_NATIVE_KERNEL capability set in<br/>CL_DEVICE_EXECUTION_CAPABILITIES as specified in the<br/>Device Queries table.</param>
        /// <param name="user_func">user_func is a pointer to a host-callable user function.<br/>It is the application’s responsibility to ensure that the host-callable user<br/>function is thread-safe.</param>
        /// <param name="args">args is a pointer to the args list that user_func should be called with.</param>
        /// <param name="cb_args">cb_args is the size in bytes of the args list that args points to.</param>
        /// <param name="num_mem_objects">num_mem_objects is the number of buffer objects that are passed in args.</param>
        /// <param name="mem_list">mem_list is a list of valid buffer objects, if num_mem_objects &gt; 0.<br/>The buffer object values specified in mem_list are memory object handles<br/>(cl_mem values) returned by clCreateBuffer or clCreateBufferWithProperties,<br/>or NULL.</param>
        /// <param name="args_mem_loc">args_mem_loc is a pointer to appropriate locations that args points to<br/>where memory object handles (cl_mem values) are stored.<br/>Before the user function is executed, the memory object handles are replaced<br/>by pointers to global memory.</param>
        /// <param name="event_wait_list">event_wait_list, num_events_in_wait_list and event are as described in<br/>clEnqueueNDRangeKernel.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueNativeKernel.html"/></remarks>
        public static int EnqueueNativeKernel(IntPtr command_queue, delegate* unmanaged[Cdecl]<void*, void> user_func, void* args, nuint cb_args, uint num_mem_objects, IntPtr* mem_list, void** args_mem_loc, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueNativeKernel_Lazy(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueNDRangeKernel</c>]</b><br/> Enqueues a command to execute a kernel on a device. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.<br/>The kernel will be queued for execution on the device associated with<br/>command_queue.</param>
        /// <param name="kernel">kernel is a valid kernel object.<br/>The OpenCL context associated with kernel and command-queue must be the<br/>same.</param>
        /// <param name="work_dim">work_dim is the number of dimensions used to specify the global work-items<br/>and work-items in the work-group.<br/>work_dim must be greater than zero and less than or equal to<br/>CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS.</param>
        /// <param name="global_work_offset">global_work_offset can be used to specify an array of work_dim unsigned<br/>values that describe the offset used to calculate the global ID of a<br/>work-item.<br/>If global_work_offset is NULL, the global IDs start at offset (0, 0, 0).<br/>global_work_offset must be NULL before version 1.1.</param>
        /// <param name="global_work_size">global_work_size points to an array of work_dim unsigned values that<br/>describe the number of global work-items in work_dim dimensions that will<br/>execute the kernel function.<br/>The total number of global work-items is computed as global_work_size[0]<br/>× …​ × global_work_size[work_dim - 1].<br/>If the device associated with command_queue is an OpenCL 2.1 or newer<br/>device, and global_work_size is NULL or the value in any passed<br/>dimension is zero,<br/>then the kernel command will trivially succeed after its event dependencies<br/>are satisfied and subsequently update its completion event.<br/>The behavior in this situation is similar to that of an enqueued marker,<br/>except that unlike a marker, an enqueued kernel with no events passed to<br/>event_wait_list may run at any time.</param>
        /// <param name="local_work_size">local_work_size points to an array of work_dim unsigned values that<br/>describe the number of work-items that make up a work-group (also referred<br/>to as the size of the work-group) that will execute the kernel specified by<br/>kernel.<br/>The total number of work-items in a work-group is computed as<br/>local_work_size[0] × …​ × local_work_size[work_dim - 1].<br/>The total number of work-items in the work-group must be less than or equal<br/>to the CL_KERNEL_WORK_GROUP_SIZE value specified in the<br/>Kernel Object Device Queries table, and the<br/>number of work-items specified in local_work_size[0], …​,<br/>local_work_size[work_dim - 1] must be less than or equal to the<br/>corresponding values specified by CL_DEVICE_MAX_WORK_GROUP_SIZES[0], …​,<br/>CL_DEVICE_MAX_WORK_GROUP_SIZES[work_dim - 1].<br/>The explicitly specified local_work_size will be used to determine how to<br/>break the global work-items specified by global_work_size into appropriate<br/>work-group instances.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueNDRangeKernel.html"/></remarks>
        public static int EnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* local_work_size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueNDRangeKernel_Lazy(command_queue, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueReadBuffer</c>]</b><br/> Enqueue commands to read from a buffer object to host memory. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue in which the read / write<br/>command will be queued.<br/>command_queue and buffer must be created with the same OpenCL context.</param>
        /// <param name="buffer">buffer refers to a valid buffer object.</param>
        /// <param name="blocking_read">blocking_read and blocking_write indicate if the read and write<br/>operations are blocking or non-blocking (see below).</param>
        /// <param name="offset">offset is the offset in bytes in the buffer object to read from or write<br/>to.</param>
        /// <param name="size">size is the size in bytes of data being read or written.</param>
        /// <param name="ptr">ptr is the pointer to buffer in host memory where data is to be read into<br/>or to be written from.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueReadBuffer.html"/></remarks>
        public static int EnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint offset, nuint size, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReadBuffer_Lazy(command_queue, buffer, (uint)blocking_read, offset, size, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clEnqueueReadBufferRect</c>]</b><br/> Enqueue command to read from a 2D or 3D rectangular region from a buffer object to host memory. </summary>
        /// <param name="command_queue">command_queue refers is a valid host command-queue in which the read /<br/>write command will be queued.<br/>command_queue and buffer must be created with the same OpenCL context.</param>
        /// <param name="buffer">buffer refers to a valid buffer object.</param>
        /// <param name="blocking_read">blocking_read and blocking_write indicate if the read and write<br/>operations are blocking or non-blocking (see below).</param>
        /// <param name="buffer_origin">buffer_origin defines the (x, y, z) offset in the memory region<br/>associated with buffer.<br/>For a 2D rectangle region, the z value given by buffer_origin[2] should<br/>be 0.<br/>The offset in bytes is computed as buffer_origin[2] ×<br/>buffer_slice_pitch + buffer_origin[1] × buffer_row_pitch + <br/>buffer_origin[0].</param>
        /// <param name="host_origin">host_origin defines the (x, y, z) offset in the memory region<br/>pointed to by ptr.<br/>For a 2D rectangle region, the z value given by host_origin[2] should be<br/>0.<br/>The offset in bytes is computed as host_origin[2] ×<br/>host_slice_pitch + host_origin[1] × host_row_pitch + <br/>host_origin[0].</param>
        /// <param name="region">region defines the (width in bytes, height in rows, depth in slices)<br/>of the 2D or 3D rectangle being read or written.<br/>For a 2D rectangle copy, the depth value given by region[2] should be 1.<br/>The values in region cannot be 0.</param>
        /// <param name="buffer_row_pitch">buffer_row_pitch is the length of each row in bytes to be used for the<br/>memory region associated with buffer.<br/>If buffer_row_pitch is 0, buffer_row_pitch is computed as region[0].</param>
        /// <param name="buffer_slice_pitch">buffer_slice_pitch is the length of each 2D slice in bytes to be used for<br/>the memory region associated with buffer.<br/>If buffer_slice_pitch is 0, buffer_slice_pitch is computed as<br/>region[1] × buffer_row_pitch.</param>
        /// <param name="host_row_pitch">host_row_pitch is the length of each row in bytes to be used for the<br/>memory region pointed to by ptr.<br/>If host_row_pitch is 0, host_row_pitch is computed as region[0].</param>
        /// <param name="host_slice_pitch">host_slice_pitch is the length of each 2D slice in bytes to be used for<br/>the memory region pointed to by ptr.<br/>If host_slice_pitch is 0, host_slice_pitch is computed as region[1]<br/>× host_row_pitch.</param>
        /// <param name="ptr">ptr is the pointer to buffer in host memory where data is to be read into<br/>or to be written from.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueReadBufferRect.html"/></remarks>
        public static int EnqueueReadBufferRect(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint* buffer_origin, nuint* host_origin, nuint* region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReadBufferRect_Lazy(command_queue, buffer, (uint)blocking_read, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueReadImage</c>]</b><br/> Enqueue commands to read from an image or image array object to host memory. </summary>
        /// <param name="command_queue">command_queue refers to the host command-queue in which the read / write<br/>command will be queued.<br/>command_queue and image must be created with the same OpenCL context.</param>
        /// <param name="image">image refers to a valid image or image array object.</param>
        /// <param name="blocking_read">blocking_read and blocking_write indicate if the read and write<br/>operations are blocking or non-blocking.</param>
        /// <param name="origin">origin defines the (x, y, z) offset in pixels in the 1D, 2D or 3D<br/>image, the (x, y) offset and the image index in the 2D image array or<br/>the (x) offset and the image index in the 1D image array.<br/>If image is a 2D image object, origin[2] must be 0.<br/>If image is a 1D image or 1D image buffer object, origin[1] and<br/>origin[2] must be 0.<br/>If image is a 1D image array object, origin[2] must be 0.<br/>If image is a 1D image array object, origin[1] describes the image index<br/>in the 1D image array.<br/>If image is a 2D image array object, origin[2] describes the image index<br/>in the 2D image array.</param>
        /// <param name="region">region defines the (width, height, depth) in pixels of the 1D, 2D or<br/>3D rectangle, the (width, height) in pixels of the 2D rectangle and the<br/>number of images of a 2D image array or the (width) in pixels of the 1D<br/>rectangle and the number of images of a 1D image array.<br/>If image is a 2D image object, region[2] must be 1.<br/>If image is a 1D image or 1D image buffer object, region[1] and<br/>region[2] must be 1.<br/>If image is a 1D image array object, region[2] must be 1.<br/>The values in region cannot be 0.<br/>If image is a mipmapped image, the mip level to read or write is<br/>determined from origin as described in Specifying Mipmap Levels to Image Operations</param>
        /// <param name="row_pitch">row_pitch in clEnqueueReadImage and input_row_pitch in<br/>clEnqueueWriteImage is the length of each row in bytes.<br/>This value must be greater than or equal to the element size in bytes<br/>× width.<br/>If row_pitch (or input_row_pitch) is set to 0, the appropriate row pitch<br/>is calculated based on the size of each element in bytes multiplied by<br/>width.</param>
        /// <param name="slice_pitch">slice_pitch in clEnqueueReadImage and input_slice_pitch in<br/>clEnqueueWriteImage is the size in bytes of the 2D slice of the 3D region<br/>of a 3D image or each image of a 1D or 2D image array being read or written<br/>respectively.<br/>This must be 0 if image is a 1D or 2D image.<br/>Otherwise this value must be greater than or equal to row_pitch ×<br/>height.<br/>If slice_pitch (or input_slice_pitch) is set to 0, the appropriate slice<br/>pitch is calculated based on the row_pitch × height.</param>
        /// <param name="ptr">ptr is the pointer to a buffer in host memory where image data is to be<br/>read from or to be written to.<br/>The alignment requirements for ptr are specified in<br/>Alignment of Application Data Types.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueReadImage.html"/></remarks>
        public static int EnqueueReadImage(IntPtr command_queue, IntPtr image, Bool blocking_read, nuint* origin, nuint* region, nuint row_pitch, nuint slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReadImage_Lazy(command_queue, image, (uint)blocking_read, origin, region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clEnqueueSVMFree</c>]</b><br/> Enqueues a command to free shared virtual memory allocated using clSVMAlloc or a shared system memory pointer. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.</param>
        /// <param name="svm_pointers">svm_pointers and num_svm_pointers specify shared virtual memory pointers<br/>to be freed.<br/>Each pointer in svm_pointers that was allocated using clSVMAlloc must<br/>have been allocated from the same context from which command_queue was<br/>created.<br/>The memory associated with svm_pointers can be reused or freed after the<br/>function returns.</param>
        /// <param name="pfn_free_func">pfn_free_func specifies the callback function to be called to free the SVM<br/>pointers.<br/>This callback function may be called asynchronously by the OpenCL<br/>implementation.<br/>It is the application’s responsibility to ensure that the callback function<br/>is thread-safe.<br/>pfn_free_func takes four arguments: queue which is the command-queue in<br/>which clEnqueueSVMFree was enqueued, the count and list of SVM pointers to<br/>free and user_data which is a pointer to user specified data.<br/>If pfn_free_func is NULL, all pointers specified in svm_pointers must<br/>be allocated using clSVMAlloc and the OpenCL implementation will free<br/>these SVM pointers.<br/>pfn_free_func must be a valid callback function if any SVM pointer to be<br/>freed is a shared system memory pointer i.e. not allocated using<br/>clSVMAlloc.<br/>If pfn_free_func is a valid callback function, the OpenCL implementation<br/>will call pfn_free_func to free all the SVM pointers specified in<br/>svm_pointers.</param>
        /// <param name="user_data">user_data will be passed as the user_data argument when pfn_free_func<br/>is called.<br/>user_data can be NULL.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before clEnqueueSVMFree can be executed.<br/>If event_wait_list is NULL, then clEnqueueSVMFree does not wait on any<br/>event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueSVMFree.html"/></remarks>
        public static int EnqueueSVMFree(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, void* user_data, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMFree_Lazy(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clEnqueueSVMMap</c>]</b><br/> Enqueues a command that will allow the host to update a region of a SVM buffer </summary>
        /// <param name="command_queue">command_queue must be a valid host command-queue.</param>
        /// <param name="blocking_map">blocking_map indicates if the map operation is blocking or<br/>non-blocking.</param>
        /// <param name="svm_ptr">svm_ptr and size are a pointer to a memory region and size in bytes that<br/>will be updated by the host.<br/>If svm_ptr is allocated using clSVMAlloc then it must be allocated from<br/>the same context from which command_queue was created.<br/>Otherwise the behavior is undefined.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueSVMMap.html"/></remarks>
        public static int EnqueueSVMMap(IntPtr command_queue, Bool blocking_map, MapFlags flags, void* svm_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMap_Lazy(command_queue, (uint)blocking_map, (ulong)flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clEnqueueSVMMemcpy</c>]</b><br/> Enqueues a command to do a memcpy operation. </summary>
        /// <param name="command_queue">command_queue refers to the host command-queue in which the read / write<br/>command will be queued.<br/>If either dst_ptr or src_ptr is allocated using clSVMAlloc then the<br/>OpenCL context allocated against must match that of command_queue.</param>
        /// <param name="blocking_copy">blocking_copy indicates if the copy operation is blocking or<br/>non-blocking.</param>
        /// <param name="dst_ptr">dst_ptr is the pointer to a host or SVM memory allocation where data is<br/>copied to.</param>
        /// <param name="src_ptr">src_ptr is the pointer to a host or SVM memory allocation where data is<br/>copied from.</param>
        /// <param name="size">size is the size in bytes of data being copied.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueSVMMemcpy.html"/></remarks>
        public static int EnqueueSVMMemcpy(IntPtr command_queue, Bool blocking_copy, void* dst_ptr, void* src_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMemcpy_Lazy(command_queue, (uint)blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clEnqueueSVMMemFill</c>]</b><br/> Enqueues a command to fill a region in memory with a pattern of a given pattern size. </summary>
        /// <param name="command_queue">command_queue refers to the host command-queue in which the fill command<br/>will be queued.<br/>The OpenCL context associated with command_queue and SVM pointer referred<br/>to by svm_ptr must be the same.</param>
        /// <param name="svm_ptr">svm_ptr is a pointer to a memory region that will be filled with<br/>pattern.<br/>It must be aligned to pattern_size bytes.<br/>If svm_ptr is allocated using clSVMAlloc then it must be allocated from<br/>the same context from which command_queue was created.<br/>Otherwise the behavior is undefined.</param>
        /// <param name="pattern">pattern is a pointer to the data pattern of size pattern_size in bytes.<br/>pattern will be used to fill a region in buffer starting at svm_ptr<br/>and is size bytes in size.<br/>The data pattern must be a scalar or vector integer or floating-point data<br/>type supported by OpenCL as described in Shared<br/>Application Scalar Data Types and Supported<br/>Application Vector Data Types.<br/>For example, if region pointed to by svm_ptr is to be filled with a<br/>pattern of float4 values, then pattern will be a pointer to a cl_float4<br/>value and pattern_size will be sizeof(cl_float4).<br/>The maximum value of pattern_size is the size of the largest integer or<br/>floating-point vector data type supported by the OpenCL device.<br/>The memory associated with pattern can be reused or freed after the<br/>function returns.</param>
        /// <param name="size">size is the size in bytes of region being filled starting with svm_ptr<br/>and must be a multiple of pattern_size.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueSVMMemFill.html"/></remarks>
        public static int EnqueueSVMMemFill(IntPtr command_queue, void* svm_ptr, void* pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMemFill_Lazy(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clEnqueueSVMMigrateMem</c>]</b><br/> Enqueues a command to indicate which device a set of ranges of SVM allocations should be associated with. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.<br/>The specified set of allocation ranges will be migrated to the OpenCL device<br/>associated with command_queue.</param>
        /// <param name="num_svm_pointers">num_svm_pointers is the number of pointers in the specified svm_pointers<br/>array, and the number of sizes in the sizes array, if sizes is not<br/>NULL.</param>
        /// <param name="svm_pointers">svm_pointers is a pointer to an array of pointers.<br/>Each pointer in this array must be within an allocation produced by a call<br/>to clSVMAlloc.</param>
        /// <param name="sizes">sizes is an array of sizes.<br/>The pair svm_pointers[i] and sizes[i] together define the starting<br/>address and number of bytes in a range to be migrated.<br/>sizes may be NULL indicating that every allocation containing any<br/>svm_pointer[i] is to be migrated.<br/>Also, if sizes[i] is zero, then the entire allocation containing<br/>svm_pointer[i] is migrated.</param>
        /// <param name="flags">flags is a bit-field that is used to specify migration options.<br/>The Memory Migration Flags describes the possible<br/>values for flags.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueSVMMigrateMem.html"/></remarks>
        public static int EnqueueSVMMigrateMem(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, nuint* sizes, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMigrateMem_Lazy(command_queue, num_svm_pointers, svm_pointers, sizes, (ulong)flags, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clEnqueueSVMUnmap</c>]</b><br/> Enqueues a command to indicate that the host has completed updating the region given by an SVM pointer and which was specified in a previous call to clEnqueueSVMMap. </summary>
        /// <param name="command_queue">command_queue must be a valid host command-queue.</param>
        /// <param name="svm_ptr">svm_ptr is a pointer that was specified in a previous call to<br/>clEnqueueSVMMap.<br/>If svm_ptr is allocated using clSVMAlloc then it must be allocated from<br/>the same context from which command_queue was created.<br/>Otherwise the behavior is undefined.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before clEnqueueSVMUnmap can be executed.<br/>If event_wait_list is NULL, then clEnqueueSVMUnmap does not wait on any<br/>event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueSVMUnmap.html"/></remarks>
        public static int EnqueueSVMUnmap(IntPtr command_queue, void* svm_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMUnmap_Lazy(command_queue, svm_ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueTask</c>]</b><br/> Enqueues a command to execute a kernel, using a single work-item, on a device. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.<br/>The kernel will be queued for execution on the device associated with<br/>command_queue.</param>
        /// <param name="kernel">kernel is a valid kernel object.<br/>The OpenCL context associated with kernel and command-queue must be the<br/>same.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueTask.html"/></remarks>
        public static int EnqueueTask(IntPtr command_queue, IntPtr kernel, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueTask_Lazy(command_queue, kernel, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueUnmapMemObject</c>]</b><br/> Enqueues a command to unmap a previously mapped region of a memory object. </summary>
        /// <param name="command_queue">command_queue must be a valid host command-queue.</param>
        /// <param name="memobj">memobj is a valid memory (buffer or image) object.<br/>The OpenCL context associated with command_queue and memobj must be the<br/>same.</param>
        /// <param name="mapped_ptr">mapped_ptr is the host address returned by a previous call to<br/>clEnqueueMapBuffer, or clEnqueueMapImage for memobj.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before clEnqueueUnmapMemObject can be executed.<br/>If event_wait_list is NULL, then clEnqueueUnmapMemObject does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueUnmapMemObject.html"/></remarks>
        public static int EnqueueUnmapMemObject(IntPtr command_queue, IntPtr memobj, void* mapped_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueUnmapMemObject_Lazy(command_queue, memobj, mapped_ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueWaitForEvents</c>]</b><br/> Enqueues a wait on a list of events to complete. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue.</param>
        /// <param name="event_list">event_list and num_events specify events that need to complete before<br/>this particular command can be executed.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueWaitForEvents.html"/></remarks>
        public static int EnqueueWaitForEvents(IntPtr command_queue, uint num_events, IntPtr* event_list) => CLPointers.clEnqueueWaitForEvents_Lazy(command_queue, num_events, event_list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueWriteBuffer</c>]</b><br/> Enqueue commands to read from a buffer object to host memory. </summary>
        /// <param name="command_queue">command_queue is a valid host command-queue in which the read / write<br/>command will be queued.<br/>command_queue and buffer must be created with the same OpenCL context.</param>
        /// <param name="buffer">buffer refers to a valid buffer object.</param>
        /// <param name="offset">offset is the offset in bytes in the buffer object to read from or write<br/>to.</param>
        /// <param name="size">size is the size in bytes of data being read or written.</param>
        /// <param name="ptr">ptr is the pointer to buffer in host memory where data is to be read into<br/>or to be written from.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueWriteBuffer.html"/></remarks>
        public static int EnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint offset, nuint size, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueWriteBuffer_Lazy(command_queue, buffer, (uint)blocking_write, offset, size, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clEnqueueWriteBufferRect</c>]</b><br/> Enqueue command to read from a 2D or 3D rectangular region from a buffer object to host memory. </summary>
        /// <param name="command_queue">command_queue refers is a valid host command-queue in which the read /<br/>write command will be queued.<br/>command_queue and buffer must be created with the same OpenCL context.</param>
        /// <param name="buffer">buffer refers to a valid buffer object.</param>
        /// <param name="buffer_origin">buffer_origin defines the (x, y, z) offset in the memory region<br/>associated with buffer.<br/>For a 2D rectangle region, the z value given by buffer_origin[2] should<br/>be 0.<br/>The offset in bytes is computed as buffer_origin[2] ×<br/>buffer_slice_pitch + buffer_origin[1] × buffer_row_pitch + <br/>buffer_origin[0].</param>
        /// <param name="host_origin">host_origin defines the (x, y, z) offset in the memory region<br/>pointed to by ptr.<br/>For a 2D rectangle region, the z value given by host_origin[2] should be<br/>0.<br/>The offset in bytes is computed as host_origin[2] ×<br/>host_slice_pitch + host_origin[1] × host_row_pitch + <br/>host_origin[0].</param>
        /// <param name="region">region defines the (width in bytes, height in rows, depth in slices)<br/>of the 2D or 3D rectangle being read or written.<br/>For a 2D rectangle copy, the depth value given by region[2] should be 1.<br/>The values in region cannot be 0.</param>
        /// <param name="buffer_row_pitch">buffer_row_pitch is the length of each row in bytes to be used for the<br/>memory region associated with buffer.<br/>If buffer_row_pitch is 0, buffer_row_pitch is computed as region[0].</param>
        /// <param name="buffer_slice_pitch">buffer_slice_pitch is the length of each 2D slice in bytes to be used for<br/>the memory region associated with buffer.<br/>If buffer_slice_pitch is 0, buffer_slice_pitch is computed as<br/>region[1] × buffer_row_pitch.</param>
        /// <param name="host_row_pitch">host_row_pitch is the length of each row in bytes to be used for the<br/>memory region pointed to by ptr.<br/>If host_row_pitch is 0, host_row_pitch is computed as region[0].</param>
        /// <param name="host_slice_pitch">host_slice_pitch is the length of each 2D slice in bytes to be used for<br/>the memory region pointed to by ptr.<br/>If host_slice_pitch is 0, host_slice_pitch is computed as region[1]<br/>× host_row_pitch.</param>
        /// <param name="ptr">ptr is the pointer to buffer in host memory where data is to be read into<br/>or to be written from.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueWriteBufferRect.html"/></remarks>
        public static int EnqueueWriteBufferRect(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint* buffer_origin, nuint* host_origin, nuint* region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueWriteBufferRect_Lazy(command_queue, buffer, (uint)blocking_write, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueWriteImage</c>]</b><br/> Enqueue commands to read from an image or image array object to host memory. </summary>
        /// <param name="command_queue">command_queue refers to the host command-queue in which the read / write<br/>command will be queued.<br/>command_queue and image must be created with the same OpenCL context.</param>
        /// <param name="image">image refers to a valid image or image array object.</param>
        /// <param name="origin">origin defines the (x, y, z) offset in pixels in the 1D, 2D or 3D<br/>image, the (x, y) offset and the image index in the 2D image array or<br/>the (x) offset and the image index in the 1D image array.<br/>If image is a 2D image object, origin[2] must be 0.<br/>If image is a 1D image or 1D image buffer object, origin[1] and<br/>origin[2] must be 0.<br/>If image is a 1D image array object, origin[2] must be 0.<br/>If image is a 1D image array object, origin[1] describes the image index<br/>in the 1D image array.<br/>If image is a 2D image array object, origin[2] describes the image index<br/>in the 2D image array.</param>
        /// <param name="region">region defines the (width, height, depth) in pixels of the 1D, 2D or<br/>3D rectangle, the (width, height) in pixels of the 2D rectangle and the<br/>number of images of a 2D image array or the (width) in pixels of the 1D<br/>rectangle and the number of images of a 1D image array.<br/>If image is a 2D image object, region[2] must be 1.<br/>If image is a 1D image or 1D image buffer object, region[1] and<br/>region[2] must be 1.<br/>If image is a 1D image array object, region[2] must be 1.<br/>The values in region cannot be 0.<br/>If image is a mipmapped image, the mip level to read or write is<br/>determined from origin as described in Specifying Mipmap Levels to Image Operations</param>
        /// <param name="ptr">ptr is the pointer to a buffer in host memory where image data is to be<br/>read from or to be written to.<br/>The alignment requirements for ptr are specified in<br/>Alignment of Application Data Types.</param>
        /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not wait<br/>on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and command_queue<br/>must be the same.<br/>The memory associated with event_wait_list can be reused or freed after<br/>the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clEnqueueWriteImage.html"/></remarks>
        public static int EnqueueWriteImage(IntPtr command_queue, IntPtr image, Bool blocking_write, nuint* origin, nuint* region, nuint input_row_pitch, nuint input_slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueWriteImage_Lazy(command_queue, image, (uint)blocking_write, origin, region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clFinish</c>]</b><br/> Blocks until all previously queued OpenCL commands in a command-queue are issued to the associated device and have completed. </summary>
        /// <param name="command_queue">command_queue is the command-queue to wait for.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clFinish.html"/></remarks>
        public static int Finish(IntPtr command_queue) => CLPointers.clFinish_Lazy(command_queue);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clFlush</c>]</b><br/> Issues all previously queued OpenCL commands in a command-queue to the device associated with the command-queue. </summary>
        /// <param name="command_queue">command_queue is the command-queue to flush.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clFlush.html"/></remarks>
        public static int Flush(IntPtr command_queue) => CLPointers.clFlush_Lazy(command_queue);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetCommandQueueInfo</c>]</b><br/> Query information about a command-queue. </summary>
        /// <param name="command_queue">command_queue specifies the command-queue being queried.</param>
        /// <param name="param_name">param_name specifies the information to query.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Command-Queue Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetCommandQueueInfo.html"/></remarks>
        public static int GetCommandQueueInfo(IntPtr command_queue, CommandQueueInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetCommandQueueInfo_Lazy(command_queue, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetContextInfo</c>]</b><br/> Query information about an OpenCL context </summary>
        /// <param name="context">context specifies the OpenCL context being queried.</param>
        /// <param name="param_name">param_name is an enumeration constant that specifies the information to<br/>query.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Context Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetContextInfo.html"/></remarks>
        public static int GetContextInfo(IntPtr context, ContextInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetContextInfo_Lazy(context, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clGetDeviceAndHostTimer</c>]</b><br/> Query synchronized host and device timestamps </summary>
        /// <param name="device">device is a device returned by clGetDeviceIDs.</param>
        /// <param name="device_timestamp">device_timestamp will be updated with the value of the device timer in<br/>nanoseconds.<br/>The resolution of the timer is the same as the device profiling timer<br/>returned by clGetDeviceInfo and the CL_DEVICE_PROFILING_TIMER_RESOLUTION<br/>query.</param>
        /// <param name="host_timestamp">host_timestamp will be updated with the value of the host timer in<br/>nanoseconds at the closest possible point in time to that at which<br/>device_timer was returned.<br/>The resolution of the timer may be queried via clGetPlatformInfo and the<br/>flag CL_PLATFORM_HOST_TIMER_RESOLUTION.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetDeviceAndHostTimer.html"/></remarks>
        public static int GetDeviceAndHostTimer(IntPtr device, ulong* device_timestamp, ulong* host_timestamp) => CLPointers.clGetDeviceAndHostTimer_Lazy(device, device_timestamp, host_timestamp);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetDeviceIDs</c>]</b><br/> Query devices available on a platform </summary>
        /// <param name="platform">platform refers to the platform ID returned by clGetPlatformIDs or can<br/>be NULL.<br/>If platform is NULL, the behavior is implementation-defined.</param>
        /// <param name="device_type">device_type is a bitfield that identifies the type of OpenCL device.<br/>The device_type can be used to query specific OpenCL devices or all OpenCL<br/>devices available.<br/>The valid values for device_type are specified in the<br/>Device Types table.</param>
        /// <param name="num_entries">num_entries is the number of cl_device_id entries that can be added to<br/>devices.<br/>If devices is not NULL, the num_entries must be greater than zero.</param>
        /// <param name="devices">devices returns a list of OpenCL devices found.<br/>The cl_device_id values returned in devices can be used to identify a<br/>specific OpenCL device.<br/>If devices is NULL, this argument is ignored.<br/>The number of OpenCL devices returned is the minimum of the value specified<br/>by num_entries or the number of OpenCL devices whose type matches<br/>device_type.</param>
        /// <param name="num_devices">num_devices returns the number of OpenCL devices available that match<br/>device_type.<br/>If num_devices is NULL, this argument is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetDeviceIDs.html"/></remarks>
        public static int GetDeviceIDs(IntPtr platform, DeviceType device_type, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDs_Lazy(platform, (ulong)device_type, num_entries, devices, num_devices);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetDeviceInfo</c>]</b><br/> Query specific information about a device </summary>
        /// <param name="device">device may be a device returned by clGetDeviceIDs or a sub-device<br/>created by clCreateSubDevices.<br/>If device is a sub-device, the specific information for the sub-device<br/>will be returned.<br/>The information that can be queried using clGetDeviceInfo is specified in<br/>the Device Queries table.</param>
        /// <param name="param_name">param_name is an enumeration constant that identifies the device<br/>information being queried.<br/>It can be one of the following values as specified in the<br/>Device Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Device Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory location where appropriate values for a<br/>given param_name, as specified in the Device<br/>Queries table, will be returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetDeviceInfo.html"/></remarks>
        public static int GetDeviceInfo(IntPtr device, DeviceInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetDeviceInfo_Lazy(device, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetEventInfo</c>]</b><br/> Returns information about the event object. </summary>
        /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetEventInfo is described in the<br/>Event Object Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Event Object Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetEventInfo.html"/></remarks>
        public static int GetEventInfo(IntPtr @event, EventInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetEventInfo_Lazy(@event, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetEventProfilingInfo</c>]</b><br/> Returns profiling information for the command associated with event if profiling is enabled. </summary>
        /// <param name="param_name">param_name specifies the profiling data to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetEventProfilingInfo is described in the<br/>Event Profiling Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Event Profiling Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetEventProfilingInfo.html"/></remarks>
        public static int GetEventProfilingInfo(IntPtr @event, ProfilingInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetEventProfilingInfo_Lazy(@event, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetExtensionFunctionAddress</c>]</b><br/> Gets an extension function pointer. </summary>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetExtensionFunctionAddress.html"/></remarks>
        public static void* GetExtensionFunctionAddress(byte* func_name) => CLPointers.clGetExtensionFunctionAddress_Lazy(func_name);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clGetExtensionFunctionAddressForPlatform</c>]</b><br/> Gets an extension function pointer. </summary>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetExtensionFunctionAddressForPlatform.html"/></remarks>
        public static void* GetExtensionFunctionAddressForPlatform(IntPtr platform, byte* func_name) => CLPointers.clGetExtensionFunctionAddressForPlatform_Lazy(platform, func_name);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clGetHostTimer</c>]</b><br/> Query the host clock </summary>
        /// <param name="device">device is a device returned by clGetDeviceIDs.</param>
        /// <param name="host_timestamp">host_timestamp will be updated with the value of the current timer in<br/>nanoseconds.<br/>The resolution of the timer may be queried via clGetPlatformInfo and the<br/>flag CL_PLATFORM_HOST_TIMER_RESOLUTION.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetHostTimer.html"/></remarks>
        public static int GetHostTimer(IntPtr device, ulong* host_timestamp) => CLPointers.clGetHostTimer_Lazy(device, host_timestamp);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetImageInfo</c>]</b><br/> Get information specific to an image object created with clCreateImage. </summary>
        /// <param name="image">image specifies the image object being queried.</param>
        /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetImageInfo is described in the<br/>Image Object Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Image Object Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetImageInfo.html"/></remarks>
        public static int GetImageInfo(IntPtr image, ImageInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetImageInfo_Lazy(image, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clGetKernelArgInfo</c>]</b><br/> Returns information about the arguments of a kernel. </summary>
        /// <param name="kernel">kernel specifies the kernel object being queried.</param>
        /// <param name="arg_index">arg_index is the argument index.<br/>Arguments to the kernel are referred by indices that go from 0 for the<br/>leftmost argument to n - 1, where n is the total number of arguments<br/>declared by a kernel.</param>
        /// <param name="param_name">param_name specifies the argument information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetKernelArgInfo is described in the<br/>Kernel Argument Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Kernel Argument Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetKernelArgInfo.html"/></remarks>
        public static int GetKernelArgInfo(IntPtr kernel, uint arg_index, KernelArgInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetKernelArgInfo_Lazy(kernel, arg_index, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetKernelInfo</c>]</b><br/> Returns information about the kernel object. </summary>
        /// <param name="kernel">kernel specifies the kernel object being queried.</param>
        /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetKernelInfo is described in the<br/>Kernel Object Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Kernel Object Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetKernelInfo.html"/></remarks>
        public static int GetKernelInfo(IntPtr kernel, KernelInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetKernelInfo_Lazy(kernel, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clGetKernelSubGroupInfo</c>]</b><br/> Returns information about the kernel object. </summary>
        /// <param name="kernel">kernel specifies the kernel object being queried.</param>
        /// <param name="device">device identifies a specific device in the list of devices associated with<br/>kernel.<br/>The list of devices is the list of devices in the OpenCL context that is<br/>associated with kernel.<br/>If the list of devices associated with kernel is a single device, device<br/>can be a NULL value.</param>
        /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetKernelSubGroupInfo is described in the<br/>Kernel Object Sub-group Queries table.</param>
        /// <param name="input_value_size">input_value_size is used to specify the size in bytes of memory pointed to<br/>by input_value.<br/>This size must be == size of input type as described in the table below.</param>
        /// <param name="input_value">input_value is a pointer to memory where the appropriate parameterization<br/>of the query is passed from.<br/>If input_value is NULL, it is ignored.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Kernel Object Sub-group Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetKernelSubGroupInfo.html"/></remarks>
        public static int GetKernelSubGroupInfo(IntPtr kernel, IntPtr device, KernelSubGroupInfo param_name, nuint input_value_size, void* input_value, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetKernelSubGroupInfo_Lazy(kernel, device, (uint)param_name, input_value_size, input_value, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>clGetKernelSuggestedLocalWorkSize</c>]</b><br/> Query suggested local work size for a kernel object </summary>
        /// <param name="command_queue">command_queue specifies the command-queue and device for the query.</param>
        /// <param name="kernel">kernel specifies the kernel object and kernel arguments for the query.<br/>The OpenCL context associated with kernel and command_queue must the<br/>same.</param>
        /// <param name="work_dim">work_dim specifies the number of work dimensions in the input global<br/>work offset and global work size, and the output suggested local work<br/>size.</param>
        /// <param name="global_work_offset">global_work_offset can be used to specify an array of at least<br/>work_dim global ID offset values for the query.<br/>This is optional and may be NULL to indicate there is no global ID<br/>offset.</param>
        /// <param name="global_work_size">global_work_size is an array of at least work_dim values describing<br/>the global work size for the query.</param>
        /// <param name="suggested_local_work_size">suggested_local_work_size is an output array of at least work_dim<br/>values that will contain the result of the query.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetKernelSuggestedLocalWorkSize.html"/></remarks>
        public static int GetKernelSuggestedLocalWorkSize(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* suggested_local_work_size) => CLPointers.clGetKernelSuggestedLocalWorkSize_Lazy(command_queue, kernel, work_dim, global_work_offset, global_work_size, suggested_local_work_size);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetKernelWorkGroupInfo</c>]</b><br/> Returns information about the kernel object that may be specific to a device. </summary>
        /// <param name="kernel">kernel specifies the kernel object being queried.</param>
        /// <param name="device">device identifies a specific device in the list of devices associated with<br/>kernel.<br/>The list of devices is the list of devices in the OpenCL context that is<br/>associated with kernel.<br/>If the list of devices associated with kernel is a single device, device<br/>can be a NULL value.</param>
        /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetKernelWorkGroupInfo is described in the<br/>Kernel Object Device Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Kernel Object Device Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetKernelWorkGroupInfo.html"/></remarks>
        public static int GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, KernelWorkGroupInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetKernelWorkGroupInfo_Lazy(kernel, device, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetMemObjectInfo</c>]</b><br/> Get information that is common to all memory objects (buffer and image objects). </summary>
        /// <param name="memobj">memobj specifies the memory object being queried.</param>
        /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetMemObjectInfo is described in the<br/>Memory Object Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Memory Object Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetMemObjectInfo.html"/></remarks>
        public static int GetMemObjectInfo(IntPtr memobj, MemInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetMemObjectInfo_Lazy(memobj, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clGetPipeInfo</c>]</b><br/> Get information specific to a pipe object created with clCreatePipe. </summary>
        /// <param name="pipe">pipe specifies the pipe object being queried.</param>
        /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetPipeInfo is described in the Pipe<br/>Object Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Pipe Object Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetPipeInfo.html"/></remarks>
        public static int GetPipeInfo(IntPtr pipe, PipeInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetPipeInfo_Lazy(pipe, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetPlatformIDs</c>]</b><br/> Query list of available platforms </summary>
        /// <param name="num_entries">num_entries is the number of cl_platform_id entries that can be added to<br/>platforms.<br/>If platforms is not NULL, num_entries must be greater than zero.</param>
        /// <param name="platforms">platforms returns a list of OpenCL platforms found.<br/>The cl_platform_id values returned in platforms can be used to<br/>identify a specific OpenCL platform.<br/>If platforms is NULL, this argument is ignored.<br/>The number of OpenCL platforms returned is the minimum of the value<br/>specified by num_entries or the number of OpenCL platforms available.</param>
        /// <param name="num_platforms">num_platforms returns the number of OpenCL platforms available.<br/>If num_platforms is NULL, this argument is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetPlatformIDs.html"/></remarks>
        public static int GetPlatformIDs(uint num_entries, IntPtr* platforms, uint* num_platforms) => CLPointers.clGetPlatformIDs_Lazy(num_entries, platforms, num_platforms);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetPlatformInfo</c>]</b><br/> Query information about an OpenCL platform </summary>
        /// <param name="platform">platform refers to the platform ID returned by clGetPlatformIDs or can<br/>be NULL.<br/>If platform is NULL, the behavior is implementation-defined.</param>
        /// <param name="param_name">param_name is an enumeration constant that identifies the platform<br/>information being queried.<br/>It can be one of the following values as specified in the<br/>Platform Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Platform Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory location where appropriate values for a<br/>given param_name, as specified in the Platform<br/>Queries table, will be returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetPlatformInfo.html"/></remarks>
        public static int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetPlatformInfo_Lazy(platform, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetProgramBuildInfo</c>]</b><br/> Returns build information for each device in the program object. </summary>
        /// <param name="program">program specifies the program object being queried.</param>
        /// <param name="device">device specifies the device for which build information is being queried.<br/>device must be a valid device associated with program.</param>
        /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetProgramBuildInfo is described in the<br/>Program Build Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Program Build Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetProgramBuildInfo.html"/></remarks>
        public static int GetProgramBuildInfo(IntPtr program, IntPtr device, ProgramBuildInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetProgramBuildInfo_Lazy(program, device, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetProgramInfo</c>]</b><br/> Returns information about the program object. </summary>
        /// <param name="program">program specifies the program object being queried.</param>
        /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetProgramInfo is described in the<br/>Program Object Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Program Object Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetProgramInfo.html"/></remarks>
        public static int GetProgramInfo(IntPtr program, ProgramInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetProgramInfo_Lazy(program, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetSamplerInfo</c>]</b><br/> Returns information about the sampler object. </summary>
        /// <param name="sampler">sampler specifies the sampler being queried.</param>
        /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetSamplerInfo is described in the<br/>Sampler Object Queries table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Sampler Object Queries table.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
        /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetSamplerInfo.html"/></remarks>
        public static int GetSamplerInfo(IntPtr sampler, SamplerInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetSamplerInfo_Lazy(sampler, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetSupportedImageFormats</c>]</b><br/> Get the list of image formats supported by an OpenCL implementation. </summary>
        /// <param name="context">context is a valid OpenCL context on which the image object(s) will be<br/>created.</param>
        /// <param name="flags">flags is a bit-field that is used to specify usage<br/>information about the image formats being queried and is described in<br/>the Memory Flags table.<br/>flags may be CL_MEM_READ_WRITE to query image formats that may be read<br/>from and written to by different kernel-instances when correctly ordered by<br/>event dependencies, or CL_MEM_READ_ONLY to query image formats that may<br/>be read from by a kernel, or CL_MEM_WRITE_ONLY to query image formats that<br/>may be written to by a kernel, or CL_MEM_KERNEL_READ_AND_WRITE to query<br/>image formats that may be both read from and written to by the same kernel<br/>instance.<br/>flags may also be CL_MEM_IMMUTABLE_EXT to query image formats that<br/>may be used to create immutable images.<br/>Please see Image Format Mapping for clarification.</param>
        /// <param name="image_type">image_type describes the image type and must be either<br/>CL_MEM_OBJECT_IMAGE1D, CL_MEM_OBJECT_IMAGE1D_BUFFER, CL_MEM_OBJECT_IMAGE2D,<br/>CL_MEM_OBJECT_IMAGE3D, CL_MEM_OBJECT_IMAGE1D_ARRAY, or<br/>CL_MEM_OBJECT_IMAGE2D_ARRAY.</param>
        /// <param name="num_entries">num_entries specifies the number of entries that can be returned in the<br/>memory location given by image_formats.</param>
        /// <param name="image_formats">image_formats is a pointer to a memory location where the list of<br/>supported image formats are returned.<br/>Each entry describes a cl_image_format structure supported by the OpenCL<br/>implementation.<br/>If image_formats is NULL, it is ignored.</param>
        /// <param name="num_image_formats">num_image_formats is the actual number of supported image formats for a<br/>specific context and values specified by flags.<br/>If num_image_formats is NULL, it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clGetSupportedImageFormats.html"/></remarks>
        public static int GetSupportedImageFormats(IntPtr context, MemFlags flags, MemObjectType image_type, uint num_entries, cl_image_format* image_formats, uint* num_image_formats) => CLPointers.clGetSupportedImageFormats_Lazy(context, (ulong)flags, (uint)image_type, num_entries, image_formats, num_image_formats);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clLinkProgram</c>]</b><br/> Links a set of compiled program objects and libraries for all the devices or a specific device(s) in the OpenCL context and creates a library or executable. </summary>
        /// <param name="context">context must be a valid OpenCL context.</param>
        /// <param name="num_devices">num_devices is the number of devices listed in device_list.</param>
        /// <param name="device_list">device_list is a pointer to a list of devices that are in context.<br/>If device_list is a NULL value, the link is performed for all devices<br/>associated with context for which a compiled object is available.<br/>If device_list is a non-NULL value, the link is performed for devices<br/>specified in this list for which a compiled object is available.</param>
        /// <param name="options">options is a pointer to a null-terminated string of characters that<br/>describes the link options to be used for building the program executable.<br/>The list of supported options is as described in Linker<br/>Options.<br/>If the program was created using clCreateProgramWithBinary and options<br/>is a NULL pointer, the program will be linked as if options were the<br/>same as when the program binary was originally built.<br/>If the program was created using clCreateProgramWithBinary and options<br/>string contains anything other than the same options in the same order<br/>(whitespace ignored) as when the program binary was originally built, then<br/>the behavior is implementation-defined.<br/>Otherwise, if options is a NULL pointer then it will have the same<br/>result as the empty string.</param>
        /// <param name="num_input_programs">num_input_programs specifies the number of programs in array referenced by<br/>input_programs.</param>
        /// <param name="input_programs">input_programs is an array of program objects that are compiled binaries<br/>or libraries that are to be linked to create the program executable.<br/>For each device in device_list or if device_list is NULL the list of<br/>devices associated with context, the following cases occur:</param>
        /// <param name="pfn_notify">pfn_notify is a function pointer to a notification routine.<br/>The notification routine is a callback function that an application can<br/>register and which will be called when the program executable has been built<br/>(successfully or unsuccessfully).</param>
        /// <param name="user_data">user_data will be passed as an argument when pfn_notify is called.<br/>user_data can be NULL.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clLinkProgram.html"/></remarks>
        public static IntPtr LinkProgram(IntPtr context, uint num_devices, IntPtr* device_list, byte* options, uint num_input_programs, IntPtr* input_programs, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data, int* errcode_ret) => CLPointers.clLinkProgram_Lazy(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseCommandQueue</c>]</b><br/> Decrements the command_queue reference count. </summary>
        /// <param name="command_queue">command_queue specifies the command-queue to be released.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clReleaseCommandQueue.html"/></remarks>
        public static int ReleaseCommandQueue(IntPtr command_queue) => CLPointers.clReleaseCommandQueue_Lazy(command_queue);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseContext</c>]</b><br/> Release an OpenCL context </summary>
        /// <param name="context">context specifies the OpenCL context to release.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clReleaseContext.html"/></remarks>
        public static int ReleaseContext(IntPtr context) => CLPointers.clReleaseContext_Lazy(context);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clReleaseDevice</c>]</b><br/> Release an OpenCL device </summary>
        /// <param name="device">device is the OpenCL device to release.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clReleaseDevice.html"/></remarks>
        public static int ReleaseDevice(IntPtr device) => CLPointers.clReleaseDevice_Lazy(device);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseEvent</c>]</b><br/> Decrements the event reference count. </summary>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clReleaseEvent.html"/></remarks>
        public static int ReleaseEvent(IntPtr @event) => CLPointers.clReleaseEvent_Lazy(@event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseKernel</c>]</b><br/> Decrements the kernel reference count. </summary>
        /// <param name="kernel">kernel is the kernel object to be released.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clReleaseKernel.html"/></remarks>
        public static int ReleaseKernel(IntPtr kernel) => CLPointers.clReleaseKernel_Lazy(kernel);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseMemObject</c>]</b><br/> Decrements the memory object reference count. </summary>
        /// <param name="memobj">memobj specifies the memory object to be released.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clReleaseMemObject.html"/></remarks>
        public static int ReleaseMemObject(IntPtr memobj) => CLPointers.clReleaseMemObject_Lazy(memobj);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseProgram</c>]</b><br/> Decrements the program reference count. </summary>
        /// <param name="program">program is the program object to be released.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clReleaseProgram.html"/></remarks>
        public static int ReleaseProgram(IntPtr program) => CLPointers.clReleaseProgram_Lazy(program);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseSampler</c>]</b><br/> Decrements the sampler reference count. </summary>
        /// <param name="sampler">sampler specifies the sampler to be released.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clReleaseSampler.html"/></remarks>
        public static int ReleaseSampler(IntPtr sampler) => CLPointers.clReleaseSampler_Lazy(sampler);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainCommandQueue</c>]</b><br/> Increments the command_queue reference count. </summary>
        /// <param name="command_queue">command_queue specifies the command-queue to be retained.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clRetainCommandQueue.html"/></remarks>
        public static int RetainCommandQueue(IntPtr command_queue) => CLPointers.clRetainCommandQueue_Lazy(command_queue);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainContext</c>]</b><br/> Retain an OpenCL context </summary>
        /// <param name="context">context specifies the OpenCL context to retain.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clRetainContext.html"/></remarks>
        public static int RetainContext(IntPtr context) => CLPointers.clRetainContext_Lazy(context);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clRetainDevice</c>]</b><br/> Retain an OpenCL device </summary>
        /// <param name="device">device is the OpenCL device to retain.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clRetainDevice.html"/></remarks>
        public static int RetainDevice(IntPtr device) => CLPointers.clRetainDevice_Lazy(device);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainEvent</c>]</b><br/> Increments the event reference count. </summary>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clRetainEvent.html"/></remarks>
        public static int RetainEvent(IntPtr @event) => CLPointers.clRetainEvent_Lazy(@event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainKernel</c>]</b><br/> Increments the kernel object reference count. </summary>
        /// <param name="kernel">kernel is the kernel object to be retained.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clRetainKernel.html"/></remarks>
        public static int RetainKernel(IntPtr kernel) => CLPointers.clRetainKernel_Lazy(kernel);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainMemObject</c>]</b><br/> Increments the memory object reference count. </summary>
        /// <param name="memobj">memobj specifies the memory object to be retained.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clRetainMemObject.html"/></remarks>
        public static int RetainMemObject(IntPtr memobj) => CLPointers.clRetainMemObject_Lazy(memobj);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainProgram</c>]</b><br/> Increments the program reference count. </summary>
        /// <param name="program">program is the program object to be retained.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clRetainProgram.html"/></remarks>
        public static int RetainProgram(IntPtr program) => CLPointers.clRetainProgram_Lazy(program);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainSampler</c>]</b><br/> Increments the sampler reference count. </summary>
        /// <param name="sampler">sampler specifies the sampler to be released.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clRetainSampler.html"/></remarks>
        public static int RetainSampler(IntPtr sampler) => CLPointers.clRetainSampler_Lazy(sampler);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clSetCommandQueueProperty</c>]</b><br/> Enable or disable properties of a command-queue. </summary>
        /// <param name="command_queue">command_queue specifies the command-queue being modified.</param>
        /// <param name="properties">properties specifies the new list of properties for the command-queue.<br/>This is a bit-field and the supported properties are described in the<br/>Command-Queue Properties table for<br/>clCreateCommandQueue.<br/>Only command-queue properties specified in this table can be used,<br/>otherwise the value specified in properties is considered to be not<br/>valid.</param>
        /// <param name="enable">enable determines whether the values specified by properties are<br/>enabled (if enable is CL_TRUE) or disabled (if enable is CL_FALSE)<br/>for the command-queue.</param>
        /// <param name="old_properties">old_properties returns the command-queue properties before they were<br/>changed by clSetCommandQueueProperty. If old_properties is NULL,<br/>it is ignored.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetCommandQueueProperty.html"/></remarks>
        public static int SetCommandQueueProperty(IntPtr command_queue, CommandQueueProperties properties, Bool enable, CommandQueueProperties* old_properties) => CLPointers.clSetCommandQueueProperty_Lazy(command_queue, (ulong)properties, (uint)enable, (ulong*)old_properties);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>clSetContextDestructorCallback</c>]</b><br/> Registers a destructor callback function with a context. </summary>
        /// <param name="context">context specifies the OpenCL context to register the callback to.</param>
        /// <param name="pfn_notify">pfn_notify is the callback function to register.<br/>This callback function may be called asynchronously by the OpenCL<br/>implementation.<br/>It is the application’s responsibility to ensure that the callback function<br/>is thread-safe.<br/>The parameters to this callback function are:</param>
        /// <param name="user_data">user_data will be passed as the user_data argument when pfn_notify is<br/>called.<br/>user_data can be NULL.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetContextDestructorCallback.html"/></remarks>
        public static int SetContextDestructorCallback(IntPtr context, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clSetContextDestructorCallback_Lazy(context, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clSetDefaultDeviceCommandQueue</c>]</b><br/> Replaces the default command-queue on the device. </summary>
        /// <param name="context">context is the OpenCL context used to create command_queue.</param>
        /// <param name="device">device is a valid OpenCL device associated with context.</param>
        /// <param name="command_queue">command_queue specifies a command-queue object which replaces the<br/>default device command-queue</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetDefaultDeviceCommandQueue.html"/></remarks>
        public static int SetDefaultDeviceCommandQueue(IntPtr context, IntPtr device, IntPtr command_queue) => CLPointers.clSetDefaultDeviceCommandQueue_Lazy(context, device, command_queue);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clSetEventCallback</c>]</b><br/> Registers a user callback function for a specific command execution status. </summary>
        /// <param name="command_exec_callback_type">command_exec_callback_type specifies the command execution status for<br/>which the callback is registered.<br/>The command execution status types for which a callback can be registered<br/>are CL_SUBMITTED, CL_RUNNING, or CL_COMPLETE.<br/>The callback function registered for a command_exec_callback_type value of<br/>CL_COMPLETE will be called when the command has completed successfully or<br/>is abnormally terminated.</param>
        /// <param name="user_data">user_data will be passed as the user_data argument when pfn_notify is<br/>called.<br/>user_data can be NULL.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetEventCallback.html"/></remarks>
        public static int SetEventCallback(IntPtr @event, int command_exec_callback_type, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void> pfn_notify, void* user_data) => CLPointers.clSetEventCallback_Lazy(@event, command_exec_callback_type, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clSetKernelArg</c>]</b><br/> Set the argument value for a specific argument of a kernel. </summary>
        /// <param name="kernel">kernel is a valid kernel object.</param>
        /// <param name="arg_index">arg_index is the kernel argument index.<br/>Kernel arguments are referred to by indices that go from zero to<br/>n - 1, where n is the total number of arguments declared by the kernel.</param>
        /// <param name="arg_size">arg_size specifies the size of the kernel argument value.</param>
        /// <param name="arg_value">arg_value is a pointer to the data for the kernel argument.<br/>The argument data pointed to by arg_value is copied and the arg_value<br/>pointer can therefore be reused by the application after clSetKernelArg<br/>returns.<br/>The argument data is used by all API calls that enqueue the kernel until the<br/>argument is changed by another call to clSetKernelArg for the kernel.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetKernelArg.html"/></remarks>
        public static int SetKernelArg(IntPtr kernel, uint arg_index, nuint arg_size, void* arg_value) => CLPointers.clSetKernelArg_Lazy(kernel, arg_index, arg_size, arg_value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clSetKernelArgSVMPointer</c>]</b><br/> Set a SVM pointer as the argument value for a specific argument of a kernel. </summary>
        /// <param name="kernel">kernel is a valid kernel object.</param>
        /// <param name="arg_index">arg_index is the argument index.<br/>Arguments to the kernel are referred by indices that go from 0 for the<br/>leftmost argument to n - 1, where n is the total number of arguments<br/>declared by a kernel.</param>
        /// <param name="arg_value">arg_value is the SVM pointer that should be used as the argument value for<br/>argument specified by arg_index.<br/>The SVM pointer specified is the value used by all API calls that enqueue<br/>kernel (clEnqueueNDRangeKernel and clEnqueueTask) until the argument<br/>value is changed by a call to clSetKernelArgSVMPointer for kernel.<br/>The SVM pointer can only be used for arguments that are declared to be a<br/>pointer to global or constant memory.<br/>The SVM pointer value must be aligned according to the arguments type.<br/>For example, if the argument is declared to be global float4 *p, the SVM<br/>pointer value passed for p must be at a minimum aligned to a float4.<br/>The SVM pointer value specified as the argument value can be the pointer<br/>returned by clSVMAlloc or can be a pointer offset into the SVM region.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetKernelArgSVMPointer.html"/></remarks>
        public static int SetKernelArgSVMPointer(IntPtr kernel, uint arg_index, void* arg_value) => CLPointers.clSetKernelArgSVMPointer_Lazy(kernel, arg_index, arg_value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clSetKernelExecInfo</c>]</b><br/> Set additional execution information for a kernel. </summary>
        /// <param name="kernel">kernel is a valid kernel object.</param>
        /// <param name="param_name">param_name specifies the type of information to set.<br/>The list of supported param_name types and the corresponding values passed<br/>in param_value is described in the Kernel<br/>Execution Properties table.</param>
        /// <param name="param_value_size">param_value_size specifies the size in bytes of the memory pointed to by<br/>param_value.</param>
        /// <param name="param_value">param_value is a pointer to memory where the appropriate values determined<br/>by param_name are specified.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetKernelExecInfo.html"/></remarks>
        public static int SetKernelExecInfo(IntPtr kernel, KernelExecInfo param_name, nuint param_value_size, void* param_value) => CLPointers.clSetKernelExecInfo_Lazy(kernel, (uint)param_name, param_value_size, param_value);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clSetMemObjectDestructorCallback</c>]</b><br/> Registers a destructor callback function with a memory object. </summary>
        /// <param name="memobj">memobj specifies the memory object to register the callback to.</param>
        /// <param name="pfn_notify">pfn_notify is the callback function to register.<br/>This callback function may be called asynchronously by the OpenCL<br/>implementation.<br/>It is the application’s responsibility to ensure that the callback function<br/>is thread-safe.<br/>The parameters to this callback function are:</param>
        /// <param name="user_data">user_data will be passed as the user_data argument when pfn_notify is<br/>called.<br/>user_data can be NULL.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetMemObjectDestructorCallback.html"/></remarks>
        public static int SetMemObjectDestructorCallback(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clSetMemObjectDestructorCallback_Lazy(memobj, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v2.2]</b> <b>[entry point: <c>clSetProgramReleaseCallback</c>]</b><br/> Registers a destructor callback function with a program object. </summary>
        /// <param name="program">program specifies the memory object to register the callback to.</param>
        /// <param name="pfn_notify">pfn_notify is the callback function to register.<br/>This callback function may be called asynchronously by the OpenCL<br/>implementation.<br/>It is the application’s responsibility to ensure that the callback function<br/>is thread-safe.<br/>The parameters to this callback function are:</param>
        /// <param name="user_data">user_data will be passed as the user_data argument when pfn_notify is<br/>called.<br/>user_data can be NULL.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetProgramReleaseCallback.html"/></remarks>
        public static int SetProgramReleaseCallback(IntPtr program, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clSetProgramReleaseCallback_Lazy(program, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v2.2]</b> <b>[entry point: <c>clSetProgramSpecializationConstant</c>]</b><br/> NO SHORT DESCRIPTION PROVIDED </summary>
        /// <param name="program">program must be a valid OpenCL program created from an intermediate<br/>language (e.g. SPIR-V).</param>
        /// <param name="spec_id">spec_id identifies the specialization constant whose value will be<br/>set.</param>
        /// <param name="spec_size">spec_size specifies the size in bytes of the data pointed to by<br/>spec_value.</param>
        /// <param name="spec_value">spec_value is a pointer to value of the specialization constant.<br/>The specialization constant value pointed to by spec_value is copied and<br/>can therefore can be reused or freed after the function returns.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetProgramSpecializationConstant.html"/></remarks>
        public static int SetProgramSpecializationConstant(IntPtr program, uint spec_id, nuint spec_size, void* spec_value) => CLPointers.clSetProgramSpecializationConstant_Lazy(program, spec_id, spec_size, spec_value);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clSetUserEventStatus</c>]</b><br/> Sets the execution status of a user event object. </summary>
        /// <param name="execution_status">execution_status specifies the new execution status to be set and can be<br/>CL_COMPLETE or a negative integer value to indicate an error.<br/>A negative integer value causes all enqueued commands that wait on this user<br/>event to be terminated.<br/>clSetUserEventStatus can only be called once to change the execution<br/>status of event.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSetUserEventStatus.html"/></remarks>
        public static int SetUserEventStatus(IntPtr @event, int execution_status) => CLPointers.clSetUserEventStatus_Lazy(@event, execution_status);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clSVMAlloc</c>]</b><br/> Allocates a shared virtual memory (SVM) buffer that can be shared by the host and all devices in an OpenCL context that support shared virtual memory. </summary>
        /// <param name="context">context is a valid OpenCL context used to create the SVM buffer.</param>
        /// <param name="flags">flags is a bit-field that is used to specify allocation and usage<br/>information.<br/>The SVM Memory Flags table describes the possible values<br/>for flags.</param>
        /// <param name="size">size is the size in bytes of the SVM buffer to be allocated.</param>
        /// <param name="alignment">alignment is the minimum alignment in bytes that is required for the newly<br/>created buffers memory region.<br/>It must be a power of two up to the largest data type supported by the<br/>OpenCL device.<br/>For the full profile, the largest data type is long16.<br/>For the embedded profile, it is long16 if the device supports 64-bit<br/>integers; otherwise it is int16.<br/>If alignment is 0, a default alignment will be used that is equal to the<br/>size of largest data type supported by the OpenCL implementation.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSVMAlloc.html"/></remarks>
        public static void* SVMAlloc(IntPtr context, ulong flags, nuint size, uint alignment) => CLPointers.clSVMAlloc_Lazy(context, flags, size, alignment);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clSVMFree</c>]</b><br/> Frees a shared virtual memory buffer allocated using clSVMAlloc. </summary>
        /// <param name="context">context is a valid OpenCL context used to create the SVM buffer.<br/>If no devices in context support SVM, no action occurs.</param>
        /// <param name="svm_pointer">svm_pointer must be the value returned by a call to clSVMAlloc.<br/>If a NULL pointer is passed in svm_pointer, no action occurs.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clSVMFree.html"/></remarks>
        public static void SVMFree(IntPtr context, void* svm_pointer) => CLPointers.clSVMFree_Lazy(context, svm_pointer);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clUnloadCompiler</c>]</b><br/> Allows the implementation to release the resources allocated by the OpenCL compiler. </summary>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clUnloadCompiler.html"/></remarks>
        public static int UnloadCompiler() => CLPointers.clUnloadCompiler_Lazy();
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clUnloadPlatformCompiler</c>]</b><br/> Allows the implementation to release the resources allocated by the OpenCL compiler for a platform. </summary>
        /// <param name="platform">platform is the platform to unload.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clUnloadPlatformCompiler.html"/></remarks>
        public static int UnloadPlatformCompiler(IntPtr platform) => CLPointers.clUnloadPlatformCompiler_Lazy(platform);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clWaitForEvents</c>]</b><br/> Waits on the host thread for commands identified by event objects to complete. </summary>
        /// <param name="num_events">num_events is the number of events in event_list.</param>
        /// <param name="event_list">event_list is a pointer to a list of event object handles.</param>
        /// <remarks><see href="https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/clWaitForEvents.html"/></remarks>
        public static int WaitForEvents(uint num_events, IntPtr* event_list) => CLPointers.clWaitForEvents_Lazy(num_events, event_list);
        
        /// <summary>APPLE extensions.</summary>
        public static unsafe partial class APPLE
        {
            /// <summary> <b>[requires: cl_APPLE_ContextLoggingFunctions]</b> <b>[entry point: <c>clLogMessagesToStderrAPPLE</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/apple/cl_APPLE_ContextLoggingFunctions.txt">APPLE_ContextLoggingFunctions.txt</see></remarks>
            public static void LogMessagesToStderrAPPLE(byte* errstr, void* private_info, nuint cb, void* user_data) => CLPointers.clLogMessagesToStderrAPPLE_Lazy(errstr, private_info, cb, user_data);
            
            /// <summary> <b>[requires: cl_APPLE_ContextLoggingFunctions]</b> <b>[entry point: <c>clLogMessagesToStdoutAPPLE</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/apple/cl_APPLE_ContextLoggingFunctions.txt">APPLE_ContextLoggingFunctions.txt</see></remarks>
            public static void LogMessagesToStdoutAPPLE(byte* errstr, void* private_info, nuint cb, void* user_data) => CLPointers.clLogMessagesToStdoutAPPLE_Lazy(errstr, private_info, cb, user_data);
            
            /// <summary> <b>[requires: cl_APPLE_ContextLoggingFunctions]</b> <b>[entry point: <c>clLogMessagesToSystemLogAPPLE</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/apple/cl_APPLE_ContextLoggingFunctions.txt">APPLE_ContextLoggingFunctions.txt</see></remarks>
            public static void LogMessagesToSystemLogAPPLE(byte* errstr, void* private_info, nuint cb, void* user_data) => CLPointers.clLogMessagesToSystemLogAPPLE_Lazy(errstr, private_info, cb, user_data);
            
            /// <summary> <b>[requires: cl_APPLE_SetMemObjectDestructor]</b> <b>[entry point: <c>clSetMemObjectDestructorAPPLE</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/apple/cl_APPLE_SetMemObjectDestructor.txt">APPLE_SetMemObjectDestructor.txt</see></remarks>
            public static int SetMemObjectDestructorAPPLE(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clSetMemObjectDestructorAPPLE_Lazy(memobj, pfn_notify, user_data);
            
        }
        /// <summary>ARM extensions.</summary>
        public static unsafe partial class ARM
        {
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clEnqueueSVMFreeARM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/arm/cl_arm_shared_virtual_memory.txt">arm_shared_virtual_memory.txt</see></remarks>
            public static int EnqueueSVMFreeARM(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, void* user_data, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMFreeARM_Lazy(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clEnqueueSVMMapARM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/arm/cl_arm_shared_virtual_memory.txt">arm_shared_virtual_memory.txt</see></remarks>
            public static int EnqueueSVMMapARM(IntPtr command_queue, Bool blocking_map, MapFlags flags, void* svm_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMapARM_Lazy(command_queue, (uint)blocking_map, (ulong)flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clEnqueueSVMMemcpyARM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/arm/cl_arm_shared_virtual_memory.txt">arm_shared_virtual_memory.txt</see></remarks>
            public static int EnqueueSVMMemcpyARM(IntPtr command_queue, Bool blocking_copy, void* dst_ptr, void* src_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMemcpyARM_Lazy(command_queue, (uint)blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clEnqueueSVMMemFillARM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/arm/cl_arm_shared_virtual_memory.txt">arm_shared_virtual_memory.txt</see></remarks>
            public static int EnqueueSVMMemFillARM(IntPtr command_queue, void* svm_ptr, void* pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMemFillARM_Lazy(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clEnqueueSVMUnmapARM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/arm/cl_arm_shared_virtual_memory.txt">arm_shared_virtual_memory.txt</see></remarks>
            public static int EnqueueSVMUnmapARM(IntPtr command_queue, void* svm_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMUnmapARM_Lazy(command_queue, svm_ptr, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_arm_import_memory]</b> <b>[entry point: <c>clImportMemoryARM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/arm/cl_arm_import_memory.txt">arm_import_memory.txt</see></remarks>
            public static IntPtr ImportMemoryARM(IntPtr context, MemFlags flags, IntPtr* properties, void* memory, nuint size, int* errcode_ret) => CLPointers.clImportMemoryARM_Lazy(context, (ulong)flags, properties, memory, size, errcode_ret);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clSetKernelArgSVMPointerARM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/arm/cl_arm_shared_virtual_memory.txt">arm_shared_virtual_memory.txt</see></remarks>
            public static int SetKernelArgSVMPointerARM(IntPtr kernel, uint arg_index, void* arg_value) => CLPointers.clSetKernelArgSVMPointerARM_Lazy(kernel, arg_index, arg_value);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clSetKernelExecInfoARM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/arm/cl_arm_shared_virtual_memory.txt">arm_shared_virtual_memory.txt</see></remarks>
            public static int SetKernelExecInfoARM(IntPtr kernel, KernelExecInfoArm param_name, nuint param_value_size, void* param_value) => CLPointers.clSetKernelExecInfoARM_Lazy(kernel, (uint)param_name, param_value_size, param_value);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clSVMAllocARM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/arm/cl_arm_shared_virtual_memory.txt">arm_shared_virtual_memory.txt</see></remarks>
            public static void* SVMAllocARM(IntPtr context, ulong flags, nuint size, uint alignment) => CLPointers.clSVMAllocARM_Lazy(context, flags, size, alignment);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clSVMFreeARM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/arm/cl_arm_shared_virtual_memory.txt">arm_shared_virtual_memory.txt</see></remarks>
            public static void SVMFreeARM(IntPtr context, void* svm_pointer) => CLPointers.clSVMFreeARM_Lazy(context, svm_pointer);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: cl_ext_device_fission]</b> <b>[entry point: <c>clCreateSubDevicesEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/ext/cl_ext_device_fission.txt">ext_device_fission.txt</see></remarks>
            public static int CreateSubDevicesEXT(IntPtr in_device, DevicePartitionPropertyExt* properties, uint num_entries, IntPtr* out_devices, uint* num_devices) => CLPointers.clCreateSubDevicesEXT_Lazy(in_device, (ulong*)properties, num_entries, out_devices, num_devices);
            
            /// <summary> <b>[requires: cl_ext_migrate_memobject]</b> <b>[entry point: <c>clEnqueueMigrateMemObjectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/ext/cl_ext_migrate_memobject.txt">ext_migrate_memobject.txt</see></remarks>
            public static int EnqueueMigrateMemObjectEXT(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, ulong flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMigrateMemObjectEXT_Lazy(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_ext_image_requirements_info]</b> <b>[entry point: <c>clGetImageRequirementsInfoEXT</c>]</b><br/> Get information on image requirements. </summary>
            /// <param name="context">context is the OpenCL context in which the query will be performed.</param>
            /// <param name="properties">properties is an optional list of properties for the image object and their<br/>corresponding values. The list is terminated with the special property 0. If<br/>no properties are required, properties may be NULL.</param>
            /// <param name="flags">flags is a bit-field that is used to specify allocation and usage information<br/>about the image format being queried and is described in the<br/>Memory Flags table. flags may be CL_MEM_READ_WRITE to<br/>specialize the query for images that may be read from and written to by different<br/>kernel-instances when correctly ordered by event dependencies, or CL_MEM_READ_ONLY<br/>to specialize the query for images that may be read from by a kernel, or<br/>CL_MEM_WRITE_ONLY to specialiaze the query for images that may be written to by<br/>a kernel, or CL_MEM_KERNEL_READ_AND_WRITE to specialize the query for images that<br/>may be both read from and written to by the same kernel-instance. When flags is<br/>0 the value returned for the query must be correct for all possible values of flags.</param>
            /// <param name="image_format">image_format is a pointer to a structure describing the format of the image<br/>for which requirements are being queried. Refer to the<br/>Image Format Descriptor section for a detailed<br/>description.</param>
            /// <param name="image_desc">image_desc is a pointer to a structure that describes type and dimensions of<br/>the image for which requirements are being queried. Refer to the<br/>Image Descriptor section for a detailed description of<br/>the image descriptor.</param>
            /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetImageRequirementsInfoEXT is described in the<br/>Image Requirements Queries table.</param>
            /// <param name="param_value_size">param_value_size is used to specify the size in bytes of memory pointed to<br/>by param_value.<br/>This size must be ≥ size of return type as described in the<br/>Image Requirements Queries table.</param>
            /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/ext/cl_ext_image_requirements_info.txt">ext_image_requirements_info.txt</see></remarks>
            public static int GetImageRequirementsInfoEXT(IntPtr context, MemProperties* properties, MemFlags flags, cl_image_format* image_format, cl_image_desc* image_desc, ImageRequirementsInfoExt param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetImageRequirementsInfoEXT_Lazy(context, (ulong*)properties, (ulong)flags, image_format, image_desc, (uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_ext_device_fission]</b> <b>[entry point: <c>clReleaseDeviceEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/ext/cl_ext_device_fission.txt">ext_device_fission.txt</see></remarks>
            public static int ReleaseDeviceEXT(IntPtr device) => CLPointers.clReleaseDeviceEXT_Lazy(device);
            
            /// <summary> <b>[requires: cl_ext_device_fission]</b> <b>[entry point: <c>clRetainDeviceEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/ext/cl_ext_device_fission.txt">ext_device_fission.txt</see></remarks>
            public static int RetainDeviceEXT(IntPtr device) => CLPointers.clRetainDeviceEXT_Lazy(device);
            
            /// <summary> <b>[requires: cl_ext_buffer_device_address]</b> <b>[entry point: <c>clSetKernelArgDevicePointerEXT</c>]</b><br/> Set a device pointer as the argument value for a specific argument of a kernel. </summary>
            /// <param name="kernel">kernel is a valid kernel object.</param>
            /// <param name="arg_index">arg_index is the argument index.<br/>Arguments to the kernel are referred by indices that go from 0 for the<br/>leftmost argument to n - 1, where n is the total number of arguments<br/>declared by a kernel.</param>
            /// <param name="arg_value">arg_value is the device pointer that should be used as the argument value for<br/>argument specified by arg_index.<br/>The device pointer specified is the value used by all API calls that enqueue<br/>kernel (clEnqueueNDRangeKernel and clEnqueueTask) until the argument<br/>value is changed by a call to clSetKernelArgDevicePointerEXT for kernel.<br/>The device pointer can only be used for arguments that are declared to be a<br/>pointer to global memory allocated with clCreateBufferWithProperties with<br/>the CL_MEM_DEVICE_PRIVATE_ADDRESS_EXT property. The pointer value specified as<br/>the argument value can be the pointer to the beginning of the buffer or any offset into<br/>the buffer region. The device pointer value must be naturally aligned according to<br/>the argument’s type. It should be noted that it’s legal to pass invalid<br/>pointers as the value (similarly to C/C++ function calls with pointer arguments) as<br/>long as the kernel doesn’t dereference the pointer.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/ext/cl_ext_buffer_device_address.txt">ext_buffer_device_address.txt</see></remarks>
            public static int SetKernelArgDevicePointerEXT(IntPtr kernel, uint arg_index, ulong arg_value) => CLPointers.clSetKernelArgDevicePointerEXT_Lazy(kernel, arg_index, arg_value);
            
        }
        /// <summary>IMG extensions.</summary>
        public static unsafe partial class IMG
        {
            /// <summary> <b>[requires: cl_img_cancel_command]</b> <b>[entry point: <c>clCancelCommandsIMG</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/img/cl_img_cancel_command.txt">img_cancel_command.txt</see></remarks>
            public static int CancelCommandsIMG(IntPtr* event_list, nuint num_events_in_list) => CLPointers.clCancelCommandsIMG_Lazy(event_list, num_events_in_list);
            
            /// <summary> <b>[requires: cl_img_use_gralloc_ptr]</b> <b>[entry point: <c>clEnqueueAcquireGrallocObjectsIMG</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/img/cl_img_use_gralloc_ptr.txt">img_use_gralloc_ptr.txt</see></remarks>
            public static int EnqueueAcquireGrallocObjectsIMG(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireGrallocObjectsIMG_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_img_generate_mipmap]</b> <b>[entry point: <c>clEnqueueGenerateMipmapIMG</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/img/cl_img_generate_mipmap.txt">img_generate_mipmap.txt</see></remarks>
            public static int EnqueueGenerateMipmapIMG(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, MipmapFilterModeImg mipmap_filter_mode, nuint* array_region, nuint* mip_region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueGenerateMipmapIMG_Lazy(command_queue, src_image, dst_image, (uint)mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_img_use_gralloc_ptr]</b> <b>[entry point: <c>clEnqueueReleaseGrallocObjectsIMG</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/img/cl_img_use_gralloc_ptr.txt">img_use_gralloc_ptr.txt</see></remarks>
            public static int EnqueueReleaseGrallocObjectsIMG(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseGrallocObjectsIMG_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
        }
        /// <summary>INTEL extensions.</summary>
        public static unsafe partial class INTEL
        {
            /// <summary> <b>[requires: cl_intel_accelerator]</b> <b>[entry point: <c>clCreateAcceleratorINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_accelerator.txt">intel_accelerator.txt</see></remarks>
            public static IntPtr CreateAcceleratorINTEL(IntPtr context, AcceleratorTypeIntel accelerator_type, nuint descriptor_size, void* descriptor, int* errcode_ret) => CLPointers.clCreateAcceleratorINTEL_Lazy(context, (uint)accelerator_type, descriptor_size, descriptor, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_create_buffer_with_properties]</b> <b>[entry point: <c>clCreateBufferWithPropertiesINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_create_buffer_with_properties.txt">intel_create_buffer_with_properties.txt</see></remarks>
            public static IntPtr CreateBufferWithPropertiesINTEL(IntPtr context, MemPropertiesIntel* properties, MemFlags flags, nuint size, void* host_ptr, int* errcode_ret) => CLPointers.clCreateBufferWithPropertiesINTEL_Lazy(context, (ulong*)properties, (ulong)flags, size, host_ptr, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_dx9_media_sharing]</b> <b>[entry point: <c>clCreateFromDX9MediaSurfaceINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_dx9_media_sharing.txt">intel_dx9_media_sharing.txt</see></remarks>
            public static IntPtr CreateFromDX9MediaSurfaceINTEL(IntPtr context, MemFlags flags, IntPtr* resource, IntPtr sharedHandle, uint plane, int* errcode_ret) => CLPointers.clCreateFromDX9MediaSurfaceINTEL_Lazy(context, (ulong)flags, resource, sharedHandle, plane, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_va_api_media_sharing]</b> <b>[entry point: <c>clCreateFromVA_APIMediaSurfaceINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_va_api_media_sharing.txt">intel_va_api_media_sharing.txt</see></remarks>
            public static IntPtr CreateFromVA_APIMediaSurfaceINTEL(IntPtr context, MemFlags flags, uint* surface, uint plane, int* errcode_ret) => CLPointers.clCreateFromVA_APIMediaSurfaceINTEL_Lazy(context, (ulong)flags, surface, plane, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clDeviceMemAllocINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static void* DeviceMemAllocINTEL(IntPtr context, IntPtr device, MemPropertiesIntel* properties, nuint size, uint alignment, int* errcode_ret) => CLPointers.clDeviceMemAllocINTEL_Lazy(context, device, (ulong*)properties, size, alignment, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_dx9_media_sharing]</b> <b>[entry point: <c>clEnqueueAcquireDX9ObjectsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_dx9_media_sharing.txt">intel_dx9_media_sharing.txt</see></remarks>
            public static int EnqueueAcquireDX9ObjectsINTEL(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireDX9ObjectsINTEL_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_va_api_media_sharing]</b> <b>[entry point: <c>clEnqueueAcquireVA_APIMediaSurfacesINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_va_api_media_sharing.txt">intel_va_api_media_sharing.txt</see></remarks>
            public static int EnqueueAcquireVA_APIMediaSurfacesINTEL(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireVA_APIMediaSurfacesINTEL_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clEnqueueMemAdviseINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static int EnqueueMemAdviseINTEL(IntPtr command_queue, void* ptr, nuint size, uint advice, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMemAdviseINTEL_Lazy(command_queue, ptr, size, advice, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clEnqueueMemcpyINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static int EnqueueMemcpyINTEL(IntPtr command_queue, Bool blocking, void* dst_ptr, void* src_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMemcpyINTEL_Lazy(command_queue, (uint)blocking, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clEnqueueMemFillINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static int EnqueueMemFillINTEL(IntPtr command_queue, void* dst_ptr, void* pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMemFillINTEL_Lazy(command_queue, dst_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clEnqueueMemsetINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static int EnqueueMemsetINTEL(IntPtr command_queue, void* dst_ptr, int value, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMemsetINTEL_Lazy(command_queue, dst_ptr, value, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clEnqueueMigrateMemINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static int EnqueueMigrateMemINTEL(IntPtr command_queue, void* ptr, nuint size, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMigrateMemINTEL_Lazy(command_queue, ptr, size, (ulong)flags, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_program_scope_host_pipe]</b> <b>[entry point: <c>clEnqueueReadHostPipeINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_program_scope_host_pipe.txt">intel_program_scope_host_pipe.txt</see></remarks>
            public static int EnqueueReadHostPipeINTEL(IntPtr command_queue, IntPtr program, byte* pipe_symbol, Bool blocking_read, void* ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReadHostPipeINTEL_Lazy(command_queue, program, pipe_symbol, (uint)blocking_read, ptr, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_dx9_media_sharing]</b> <b>[entry point: <c>clEnqueueReleaseDX9ObjectsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_dx9_media_sharing.txt">intel_dx9_media_sharing.txt</see></remarks>
            public static int EnqueueReleaseDX9ObjectsINTEL(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseDX9ObjectsINTEL_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_va_api_media_sharing]</b> <b>[entry point: <c>clEnqueueReleaseVA_APIMediaSurfacesINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_va_api_media_sharing.txt">intel_va_api_media_sharing.txt</see></remarks>
            public static int EnqueueReleaseVA_APIMediaSurfacesINTEL(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseVA_APIMediaSurfacesINTEL_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_program_scope_host_pipe]</b> <b>[entry point: <c>clEnqueueWriteHostPipeINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_program_scope_host_pipe.txt">intel_program_scope_host_pipe.txt</see></remarks>
            public static int EnqueueWriteHostPipeINTEL(IntPtr command_queue, IntPtr program, byte* pipe_symbol, Bool blocking_write, void* ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueWriteHostPipeINTEL_Lazy(command_queue, program, pipe_symbol, (uint)blocking_write, ptr, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_accelerator]</b> <b>[entry point: <c>clGetAcceleratorInfoINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_accelerator.txt">intel_accelerator.txt</see></remarks>
            public static int GetAcceleratorInfoINTEL(IntPtr accelerator, AcceleratorInfoIntel param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetAcceleratorInfoINTEL_Lazy(accelerator, (uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_intel_dx9_media_sharing]</b> <b>[entry point: <c>clGetDeviceIDsFromDX9INTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_dx9_media_sharing.txt">intel_dx9_media_sharing.txt</see></remarks>
            public static int GetDeviceIDsFromDX9INTEL(IntPtr platform, Dx9DeviceSourceIntel dx9_device_source, void* dx9_object, Dx9DeviceSetIntel dx9_device_set, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDsFromDX9INTEL_Lazy(platform, (uint)dx9_device_source, dx9_object, (uint)dx9_device_set, num_entries, devices, num_devices);
            
            /// <summary> <b>[requires: cl_intel_va_api_media_sharing]</b> <b>[entry point: <c>clGetDeviceIDsFromVA_APIMediaAdapterINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_va_api_media_sharing.txt">intel_va_api_media_sharing.txt</see></remarks>
            public static int GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr platform, VaApiDeviceSourceIntel media_adapter_type, void* media_adapter, VaApiDeviceSetIntel media_adapter_set, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDsFromVA_APIMediaAdapterINTEL_Lazy(platform, (uint)media_adapter_type, media_adapter, (uint)media_adapter_set, num_entries, devices, num_devices);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clGetMemAllocInfoINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static int GetMemAllocInfoINTEL(IntPtr context, void* ptr, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetMemAllocInfoINTEL_Lazy(context, ptr, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_intel_sharing_format_query_d3d10]</b> <b>[entry point: <c>clGetSupportedD3D10TextureFormatsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_sharing_format_query_d3d10.txt">intel_sharing_format_query_d3d10.txt</see></remarks>
            public static int GetSupportedD3D10TextureFormatsINTEL(IntPtr context, MemFlags flags, MemObjectType image_type, uint num_entries, uint* d3d10_formats, uint* num_texture_formats) => CLPointers.clGetSupportedD3D10TextureFormatsINTEL_Lazy(context, (ulong)flags, (uint)image_type, num_entries, d3d10_formats, num_texture_formats);
            
            /// <summary> <b>[requires: cl_intel_sharing_format_query_d3d11]</b> <b>[entry point: <c>clGetSupportedD3D11TextureFormatsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_sharing_format_query_d3d11.txt">intel_sharing_format_query_d3d11.txt</see></remarks>
            public static int GetSupportedD3D11TextureFormatsINTEL(IntPtr context, MemFlags flags, MemObjectType image_type, uint plane, uint num_entries, uint* d3d11_formats, uint* num_texture_formats) => CLPointers.clGetSupportedD3D11TextureFormatsINTEL_Lazy(context, (ulong)flags, (uint)image_type, plane, num_entries, d3d11_formats, num_texture_formats);
            
            /// <summary> <b>[requires: cl_intel_sharing_format_query_dx9]</b> <b>[entry point: <c>clGetSupportedDX9MediaSurfaceFormatsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_sharing_format_query_dx9.txt">intel_sharing_format_query_dx9.txt</see></remarks>
            public static int GetSupportedDX9MediaSurfaceFormatsINTEL(IntPtr context, MemFlags flags, MemObjectType image_type, uint plane, uint num_entries, uint* dx9_formats, uint* num_surface_formats) => CLPointers.clGetSupportedDX9MediaSurfaceFormatsINTEL_Lazy(context, (ulong)flags, (uint)image_type, plane, num_entries, dx9_formats, num_surface_formats);
            
            /// <summary> <b>[requires: cl_intel_sharing_format_query_gl]</b> <b>[entry point: <c>clGetSupportedGLTextureFormatsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_sharing_format_query_gl.txt">intel_sharing_format_query_gl.txt</see></remarks>
            public static int GetSupportedGLTextureFormatsINTEL(IntPtr context, MemFlags flags, MemObjectType image_type, uint num_entries, uint* gl_formats, uint* num_texture_formats) => CLPointers.clGetSupportedGLTextureFormatsINTEL_Lazy(context, (ulong)flags, (uint)image_type, num_entries, gl_formats, num_texture_formats);
            
            /// <summary> <b>[requires: cl_intel_sharing_format_query_va_api]</b> <b>[entry point: <c>clGetSupportedVA_APIMediaSurfaceFormatsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_sharing_format_query_va_api.txt">intel_sharing_format_query_va_api.txt</see></remarks>
            public static int GetSupportedVA_APIMediaSurfaceFormatsINTEL(IntPtr context, MemFlags flags, MemObjectType image_type, uint plane, uint num_entries, VAImageFormat* va_api_formats, uint* num_surface_formats) => CLPointers.clGetSupportedVA_APIMediaSurfaceFormatsINTEL_Lazy(context, (ulong)flags, (uint)image_type, plane, num_entries, va_api_formats, num_surface_formats);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clHostMemAllocINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static void* HostMemAllocINTEL(IntPtr context, MemPropertiesIntel* properties, nuint size, uint alignment, int* errcode_ret) => CLPointers.clHostMemAllocINTEL_Lazy(context, (ulong*)properties, size, alignment, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clMemBlockingFreeINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static int MemBlockingFreeINTEL(IntPtr context, void* ptr) => CLPointers.clMemBlockingFreeINTEL_Lazy(context, ptr);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clMemFreeINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static int MemFreeINTEL(IntPtr context, void* ptr) => CLPointers.clMemFreeINTEL_Lazy(context, ptr);
            
            /// <summary> <b>[requires: cl_intel_accelerator]</b> <b>[entry point: <c>clReleaseAcceleratorINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_accelerator.txt">intel_accelerator.txt</see></remarks>
            public static int ReleaseAcceleratorINTEL(IntPtr accelerator) => CLPointers.clReleaseAcceleratorINTEL_Lazy(accelerator);
            
            /// <summary> <b>[requires: cl_intel_accelerator]</b> <b>[entry point: <c>clRetainAcceleratorINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_accelerator.txt">intel_accelerator.txt</see></remarks>
            public static int RetainAcceleratorINTEL(IntPtr accelerator) => CLPointers.clRetainAcceleratorINTEL_Lazy(accelerator);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clSetKernelArgMemPointerINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static int SetKernelArgMemPointerINTEL(IntPtr kernel, uint arg_index, void* arg_value) => CLPointers.clSetKernelArgMemPointerINTEL_Lazy(kernel, arg_index, arg_value);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clSharedMemAllocINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/intel/cl_intel_unified_shared_memory.txt">intel_unified_shared_memory.txt</see></remarks>
            public static void* SharedMemAllocINTEL(IntPtr context, IntPtr device, MemPropertiesIntel* properties, nuint size, uint alignment, int* errcode_ret) => CLPointers.clSharedMemAllocINTEL_Lazy(context, device, (ulong*)properties, size, alignment, errcode_ret);
            
        }
        /// <summary>KHR extensions.</summary>
        public static unsafe partial class KHR
        {
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandBarrierWithWaitListKHR</c>]</b><br/> Record a barrier operation to a command-queue </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="command_queue">command_queue specifies the command-queue the command will be recorded to.<br/><br/>If the cl_khr_command_buffer_multi_device extension is not supported,<br/>only a single command-queue is supported, and command_queue must be<br/>NULL.<br/><br/>If the cl_khr_command_buffer_multi_device extension is supported and<br/>command_queue is NULL, then only one command-queue must have been set on<br/>command_buffer creation; otherwise, command_queue must not be NULL.</param>
            /// <param name="properties">properties specifies a list of properties for the command and their<br/>corresponding values. Each property name is immediately followed by the<br/>corresponding desired value. The list is terminated with 0. The<br/>cl_khr_command_buffer extension does not define any properties, but<br/>supported properties may be defined by layered extensions in future.</param>
            /// <param name="sync_point_wait_list">sync_point_wait_list, num_sync_points_in_wait_list specify<br/>synchronization-points that need to complete before this particular<br/>command can be executed.</param>
            /// <param name="sync_point">sync_point returns a synchronization-point ID that identifies this<br/>particular command.<br/>Synchronization-point objects are unique and can be used to identify<br/>this barrier command later on.<br/>sync_point can be NULL in which case it will not be possible for the<br/>application to record a wait for this command to complete.<br/>If the sync_point_wait_list and the sync_point arguments are not<br/>NULL, the sync_point argument should not refer to an element of the<br/>sync_point_wait_list array.</param>
            /// <param name="mutable_handle">mutable_handle returns a handle to the command.<br/>This parameter is unused, and must be NULL.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandBarrierWithWaitListKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandBarrierWithWaitListKHR_Lazy(command_buffer, command_queue, (ulong*)properties, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandCopyBufferKHR</c>]</b><br/> Record a command to copy between two buffer objects </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="command_queue">command_queue specifies the command-queue the command will be recorded to.<br/><br/>If the cl_khr_command_buffer_multi_device extension is not supported,<br/>only a single command-queue is supported, and command_queue must be<br/>NULL.<br/><br/>If the cl_khr_command_buffer_multi_device extension is supported and<br/>command_queue is NULL, then only one command-queue must have been set on<br/>command_buffer creation; otherwise, command_queue must not be NULL.</param>
            /// <param name="properties">properties specifies a list of properties for the command and their<br/>corresponding values. Each property name is immediately followed by the<br/>corresponding desired value. The list is terminated with 0. The<br/>cl_khr_command_buffer extension does not define any properties, but<br/>supported properties may be defined by layered extensions in future.</param>
            /// <param name="src_buffer">src_buffer, dst_buffer, src_offset, dst_offset, size refer<br/>to clEnqueueCopyBuffer.</param>
            /// <param name="sync_point_wait_list">sync_point_wait_list, num_sync_points_in_wait_list specify<br/>synchronization-points that need to complete before this particular<br/>command can be executed.</param>
            /// <param name="sync_point">sync_point returns a synchronization-point ID that identifies this<br/>particular command.<br/>Synchronization-point objects are unique and can be used to identify<br/>this command later on.<br/>sync_point can be NULL in which case it will not be possible for the<br/>application to record a wait for this command to complete.<br/>If the sync_point_wait_list and the sync_point arguments are not<br/>NULL, the sync_point argument should not refer to an element of the<br/>sync_point_wait_list array.</param>
            /// <param name="mutable_handle">mutable_handle returns a handle to the command.<br/>This parameter is unused, and must be NULL.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandCopyBufferKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandCopyBufferKHR_Lazy(command_buffer, command_queue, (ulong*)properties, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandCopyBufferRectKHR</c>]</b><br/> Record a command to copy a rectangular region from one buffer object to another </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="command_queue">command_queue specifies the command-queue the command will be recorded to.<br/><br/>If the cl_khr_command_buffer_multi_device extension is not supported,<br/>only a single command-queue is supported, and command_queue must be<br/>NULL.<br/><br/>If the cl_khr_command_buffer_multi_device extension is supported and<br/>command_queue is NULL, then only one command-queue must have been set on<br/>command_buffer creation; otherwise, command_queue must not be NULL.</param>
            /// <param name="properties">properties specifies a list of properties for the command and their<br/>corresponding values. Each property name is immediately followed by the<br/>corresponding desired value. The list is terminated with 0. The<br/>cl_khr_command_buffer extension does not define any properties, but<br/>supported properties may be defined by layered extensions in future.</param>
            /// <param name="src_origin">src_origin, dst_origin, region, src_row_pitch,<br/>src_slice_pitch, dst_row_pitch, dst_slice_pitch refer to<br/>clEnqueueCopyBufferRect.</param>
            /// <param name="sync_point_wait_list">sync_point_wait_list, num_sync_points_in_wait_list specify<br/>synchronization-points that need to complete before this particular<br/>command can be executed.</param>
            /// <param name="sync_point">sync_point returns a synchronization-point ID that identifies this<br/>particular command.<br/>Synchronization-point objects are unique and can be used to identify<br/>this command later on.<br/>sync_point can be NULL in which case it will not be possible for the<br/>application to record a wait for this command to complete.<br/>If the sync_point_wait_list and the sync_point arguments are not<br/>NULL, the sync_point argument should not refer to an element of the<br/>sync_point_wait_list array.</param>
            /// <param name="mutable_handle">mutable_handle returns a handle to the command.<br/>This parameter is unused, and must be NULL.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandCopyBufferRectKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, IntPtr src_buffer, IntPtr dst_buffer, nuint* src_origin, nuint* dst_origin, nuint* region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandCopyBufferRectKHR_Lazy(command_buffer, command_queue, (ulong*)properties, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandCopyBufferToImageKHR</c>]</b><br/> Record a command to copy a buffer object to an image object </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="command_queue">command_queue specifies the command-queue the command will be recorded to.<br/><br/>If the cl_khr_command_buffer_multi_device extension is not supported,<br/>only a single command-queue is supported, and command_queue must be<br/>NULL.<br/><br/>If the cl_khr_command_buffer_multi_device extension is supported and<br/>command_queue is NULL, then only one command-queue must have been set on<br/>command_buffer creation; otherwise, command_queue must not be NULL.</param>
            /// <param name="properties">properties specifies a list of properties for the command and their<br/>corresponding values. Each property name is immediately followed by the<br/>corresponding desired value. The list is terminated with 0. The<br/>cl_khr_command_buffer extension does not define any properties, but<br/>supported properties may be defined by layered extensions in future.</param>
            /// <param name="src_buffer">src_buffer, dst_image, src_offset, dst_origin, region refer to<br/>clEnqueueCopyBufferToImage</param>
            /// <param name="sync_point_wait_list">sync_point_wait_list, num_sync_points_in_wait_list specify<br/>synchronization-points that need to complete before this particular<br/>command can be executed.</param>
            /// <param name="sync_point">sync_point returns a synchronization-point ID that identifies this<br/>particular command.<br/>Synchronization-point objects are unique and can be used to identify<br/>this command later on.<br/>sync_point can be NULL in which case it will not be possible for the<br/>application to record a wait for this command to complete.<br/>If the sync_point_wait_list and the sync_point arguments are not<br/>NULL, the sync_point argument should not refer to an element of the<br/>sync_point_wait_list array.</param>
            /// <param name="mutable_handle">mutable_handle returns a handle to the command.<br/>This parameter is unused, and must be NULL.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandCopyBufferToImageKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, nuint* dst_origin, nuint* region, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandCopyBufferToImageKHR_Lazy(command_buffer, command_queue, (ulong*)properties, src_buffer, dst_image, src_offset, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandCopyImageKHR</c>]</b><br/> Record a command to copy between two image objects </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="command_queue">command_queue specifies the command-queue the command will be recorded to.<br/><br/>If the cl_khr_command_buffer_multi_device extension is not supported,<br/>only a single command-queue is supported, and command_queue must be<br/>NULL.<br/><br/>If the cl_khr_command_buffer_multi_device extension is supported and<br/>command_queue is NULL, then only one command-queue must have been set on<br/>command_buffer creation; otherwise, command_queue must not be NULL.</param>
            /// <param name="properties">properties specifies a list of properties for the command and their<br/>corresponding values. Each property name is immediately followed by the<br/>corresponding desired value. The list is terminated with 0. The<br/>cl_khr_command_buffer extension does not define any properties, but<br/>supported properties may be defined by layered extensions in future.</param>
            /// <param name="src_image">src_image, dst_image, src_origin, dst_origin, region refer to<br/>clEnqueueCopyImage.</param>
            /// <param name="sync_point_wait_list">sync_point_wait_list, num_sync_points_in_wait_list specify<br/>synchronization-points that need to complete before this particular<br/>command can be executed.</param>
            /// <param name="sync_point">sync_point returns a synchronization-point ID that identifies this<br/>particular command.<br/>Synchronization-point objects are unique and can be used to identify<br/>this command later on.<br/>sync_point can be NULL in which case it will not be possible for the<br/>application to record a wait for this command to complete.<br/>If the sync_point_wait_list and the sync_point arguments are not<br/>NULL, the sync_point argument should not refer to an element of the<br/>sync_point_wait_list array.</param>
            /// <param name="mutable_handle">mutable_handle returns a handle to the command.<br/>This parameter is unused, and must be NULL.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandCopyImageKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, IntPtr src_image, IntPtr dst_image, nuint* src_origin, nuint* dst_origin, nuint* region, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandCopyImageKHR_Lazy(command_buffer, command_queue, (ulong*)properties, src_image, dst_image, src_origin, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandCopyImageToBufferKHR</c>]</b><br/> Record a command to copy an image object to a buffer object </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="command_queue">command_queue specifies the command-queue the command will be recorded to.<br/><br/>If the cl_khr_command_buffer_multi_device extension is not supported,<br/>only a single command-queue is supported, and command_queue must be<br/>NULL.<br/><br/>If the cl_khr_command_buffer_multi_device extension is supported and<br/>command_queue is NULL, then only one command-queue must have been set on<br/>command_buffer creation; otherwise, command_queue must not be NULL.</param>
            /// <param name="properties">properties specifies a list of properties for the command and their<br/>corresponding values. Each property name is immediately followed by the<br/>corresponding desired value. The list is terminated with 0. The<br/>cl_khr_command_buffer extension does not define any properties, but<br/>supported properties may be defined by layered extensions in future.</param>
            /// <param name="src_image">src_image, dst_buffer, src_origin, region, dst_offset refer to<br/>clEnqueueCopyImageToBuffer.</param>
            /// <param name="sync_point_wait_list">sync_point_wait_list, num_sync_points_in_wait_list specify<br/>synchronization-points that need to complete before this particular<br/>command can be executed.</param>
            /// <param name="sync_point">sync_point returns a synchronization-point ID that identifies this<br/>particular command.<br/>Synchronization-point objects are unique and can be used to identify<br/>this command later on.<br/>sync_point can be NULL in which case it will not be possible for the<br/>application to record a wait for this command to complete.<br/>If the sync_point_wait_list and the sync_point arguments are not<br/>NULL, the sync_point argument should not refer to an element of the<br/>sync_point_wait_list array.</param>
            /// <param name="mutable_handle">mutable_handle returns a handle to the command.<br/>This parameter is unused, and must be NULL.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandCopyImageToBufferKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, IntPtr src_image, IntPtr dst_buffer, nuint* src_origin, nuint* region, nuint dst_offset, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandCopyImageToBufferKHR_Lazy(command_buffer, command_queue, (ulong*)properties, src_image, dst_buffer, src_origin, region, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandFillBufferKHR</c>]</b><br/> Record a command to fill a buffer object with a pattern </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandFillBufferKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, IntPtr buffer, void* pattern, nuint pattern_size, nuint offset, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandFillBufferKHR_Lazy(command_buffer, command_queue, (ulong*)properties, buffer, pattern, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandFillImageKHR</c>]</b><br/> Record a command to fill an image object with a specified color </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandFillImageKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, IntPtr image, void* fill_color, nuint* origin, nuint* region, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandFillImageKHR_Lazy(command_buffer, command_queue, (ulong*)properties, image, fill_color, origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandNDRangeKernelKHR</c>]</b><br/> Record a command to execute a kernel on a device </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="command_queue">command_queue specifies the command-queue the command will be recorded to.<br/><br/>If the cl_khr_command_buffer_multi_device extension is not supported,<br/>only a single command-queue is supported, and command_queue must be<br/>NULL.<br/><br/>If the cl_khr_command_buffer_multi_device extension is supported and<br/>command_queue is NULL, then only one command-queue must have been set on<br/>command_buffer creation; otherwise, command_queue must not be NULL.</param>
            /// <param name="properties">properties specifies a list of properties for the kernel command and<br/>their corresponding values.<br/>Each property name is immediately followed by the corresponding desired<br/>value.<br/>The list is terminated with 0.<br/>If a supported property and its value is not specified in properties, its<br/>default value will be used.<br/>properties may be NULL, in which case the default values for supported<br/>properties will be used.<br/>The cl_khr_command_buffer extension does not define any<br/>properties, but supported properties defined by extensions are defined<br/>in the List of supported properties<br/>by clCommandNDRangeKernelKHR table.</param>
            /// <param name="kernel">kernel is a valid kernel object, which must have its arguments set<br/>unless the command has the CL_MUTABLE_DISPATCH_ARGUMENTS_KHR property set<br/>(see description of argument mutable_handle).<br/>Any changes to kernel after calling clCommandNDRangeKernelKHR, such<br/>as with clSetKernelArg or clSetKernelExecInfo, have no effect on the<br/>recorded command.<br/>If kernel is recorded to a following clCommandNDRangeKernelKHR<br/>command however, then that command will capture the updated state of<br/>kernel.</param>
            /// <param name="work_dim">work_dim, global_work_offset, global_work_size, local_work_size<br/>Refer to clEnqueueNDRangeKernel.</param>
            /// <param name="sync_point_wait_list">sync_point_wait_list, num_sync_points_in_wait_list specify<br/>synchronization-points that need to complete before this particular<br/>command can be executed.</param>
            /// <param name="sync_point">sync_point returns a synchronization-point ID that identifies this<br/>particular command.<br/>Synchronization-point objects are unique and can be used to identify<br/>this command later on.<br/>sync_point can be NULL in which case it will not be possible for the<br/>application to record a wait for this command to complete.<br/>If the sync_point_wait_list and the sync_point arguments are not<br/>NULL, the sync_point argument should not refer to an element of the<br/>sync_point_wait_list array.</param>
            /// <param name="mutable_handle">mutable_handle returns a handle to the command.<br/>If the cl_khr_command_buffer_mutable_dispatch extension is<br/>supported, and mutable_handle is not NULL, it can be used in the<br/>cl_mutable_dispatch_config_khr struct to update the command<br/>configuration between recordings.<br/>The lifetime of this handle is tied to the parent command-buffer, such<br/>that freeing the command-buffer will also free this handle.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandNDRangeKernelKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* local_work_size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandNDRangeKernelKHR_Lazy(command_buffer, command_queue, (ulong*)properties, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandSVMMemcpyKHR</c>]</b><br/> Record a command to do an SVM memcpy operation </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="command_queue">command_queue specifies the command-queue the command will be recorded to.<br/><br/>If the cl_khr_command_buffer_multi_device extension is not supported,<br/>only a single command-queue is supported, and command_queue must be<br/>NULL.<br/><br/>If the cl_khr_command_buffer_multi_device extension is supported and<br/>command_queue is NULL, then only one command-queue must have been set on<br/>command_buffer creation; otherwise, command_queue must not be NULL.</param>
            /// <param name="properties">properties specifies a list of properties for the command and thier<br/>corresponding values. Each property name is immediately followed by the<br/>corresponding desired value. The list is terminated with 0. The<br/>cl_khr_command_buffer extension does not define any properties, but<br/>supported properties may be defined by layered extensions in future.</param>
            /// <param name="dst_ptr">dst_ptr is the pointer to a host (if the device supports system SVM)<br/>or SVM memory allocation where data is copied to.</param>
            /// <param name="src_ptr">src_ptr is the pointer to a host (if the device supports system SVM)<br/>or SVM memory allocation where data is copied from.</param>
            /// <param name="size">size is the size in bytes of data being copied.</param>
            /// <param name="sync_point_wait_list">sync_point_wait_list, num_sync_points_in_wait_list specify<br/>synchronization-points that need to complete before this particular<br/>command can be executed.</param>
            /// <param name="sync_point">sync_point returns a synchronization-point ID that identifies this<br/>particular command.<br/>Synchronization-point objects are unique and can be used to identify<br/>this command later on.<br/>sync_point can be NULL in which case it will not be possible for the<br/>application to record a wait for this command to complete.<br/>If the sync_point_wait_list and the sync_point arguments are not<br/>NULL, the sync_point argument should not refer to an element of the<br/>sync_point_wait_list array.</param>
            /// <param name="mutable_handle">mutable_handle returns a handle to the command.<br/>This parameter is unused, and must be NULL.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandSVMMemcpyKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, void* dst_ptr, void* src_ptr, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandSVMMemcpyKHR_Lazy(command_buffer, command_queue, (ulong*)properties, dst_ptr, src_ptr, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandSVMMemFillKHR</c>]</b><br/> Record a command to fill a region in SVM with a pattern of a given pattern size </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="command_queue">command_queue specifies the command-queue the command will be recorded to.<br/><br/>If the cl_khr_command_buffer_multi_device extension is not supported,<br/>only a single command-queue is supported, and command_queue must be<br/>NULL.<br/><br/>If the cl_khr_command_buffer_multi_device extension is supported and<br/>command_queue is NULL, then only one command-queue must have been set on<br/>command_buffer creation; otherwise, command_queue must not be NULL.</param>
            /// <param name="properties">properties specifies a list of properties for the command and their<br/>corresponding values. Each property name is immediately followed by the<br/>corresponding desired value. The list is terminated with 0. The<br/>cl_khr_command_buffer extension does not define any properties, but<br/>supported properties may be defined by layered extensions in future.</param>
            /// <param name="svm_ptr">svm_ptr is a pointer to a (if the device supports system SVM)<br/>or SVM memory region that will be filled with pattern.<br/>It must be aligned to pattern_size bytes.<br/>If svm_ptr is allocated using clSVMAlloc, then it must be allocated<br/>from the same context from which command_queue was created.<br/>Otherwise the behavior is undefined.</param>
            /// <param name="pattern">pattern is a pointer to the data pattern of size pattern_size in<br/>bytes.<br/>pattern will be used to fill a region in buffer starting at<br/>svm_ptr and is size bytes in size.<br/>The data pattern must be a scalar or vector integer or floating-point<br/>data type supported by OpenCL.<br/>For example, if the region pointed to by svm_ptr is to be filled with<br/>a pattern of float4 values, then pattern will be a pointer to a<br/>cl_float4 value and pattern_size will be sizeof(cl_float4).<br/>The maximum value of pattern_size is the size of the largest integer<br/>or floating-point vector data type supported by the OpenCL device.<br/>The memory associated with pattern can be reused or freed after the<br/>function returns.</param>
            /// <param name="size">size is the size in bytes of region being filled starting with<br/>svm_ptr and must be a multiple of pattern_size.</param>
            /// <param name="sync_point_wait_list">sync_point_wait_list, num_sync_points_in_wait_list specify<br/>synchronization-points that need to complete before this<br/>particular command can be executed.</param>
            /// <param name="sync_point">sync_point returns a synchronization-point ID that identifies this<br/>particular command.<br/>Synchronization-point objects are unique and can be used to identify<br/>this command later on.<br/>sync_point can be NULL in which case it will not be possible for the<br/>application to record a wait for this command to complete.<br/>If the sync_point_wait_list and the sync_point arguments are not<br/>NULL, the sync_point argument should not refer to an element of the<br/>sync_point_wait_list array.</param>
            /// <param name="mutable_handle">mutable_handle returns a handle to the command.<br/>This parameter is unused, and must be NULL.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int CommandSVMMemFillKHR(IntPtr command_buffer, IntPtr command_queue, CommandPropertiesKhr* properties, void* svm_ptr, void* pattern, nuint pattern_size, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandSVMMemFillKHR_Lazy(command_buffer, command_queue, (ulong*)properties, svm_ptr, pattern, pattern_size, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCreateCommandBufferKHR</c>]</b><br/> Create a command-buffer </summary>
            /// <param name="num_queues">num_queues is the number of command-queues listed in queues.<br/>If the cl_khr_command_buffer_multi_device extension is not<br/>supported, this must be one.</param>
            /// <param name="queues">queues is a pointer to a list of command-queues that the<br/>command-buffer commands will be recorded to.<br/>queues must be a non-NULL value and the length of the list equal to<br/>num_queues.</param>
            /// <param name="properties">properties specifies a list of properties for the command-buffer and<br/>their corresponding values.<br/>Each property name is immediately followed by the corresponding desired<br/>value.<br/>The list is terminated with 0.<br/>The list of supported properties is described in the table below.<br/>If a supported property and its value is not specified in properties,<br/>its default value will be used.<br/>properties can be NULL in which case the default values for<br/>supported command-buffer properties will be used.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static IntPtr CreateCommandBufferKHR(uint num_queues, IntPtr* queues, CommandBufferPropertiesKhr* properties, int* errcode_ret) => CLPointers.clCreateCommandBufferKHR_Lazy(num_queues, queues, (ulong*)properties, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_create_command_queue]</b> <b>[entry point: <c>clCreateCommandQueueWithPropertiesKHR</c>]</b><br/> Create a host or device command-queue on a specific device. </summary>
            /// <param name="context">context must be a valid OpenCL context.</param>
            /// <param name="device">device must be a device or sub-device associated with context.<br/>It can either be in the list of devices and sub-devices specified when<br/>context is created using clCreateContext or be a root device with<br/>the same device type as specified when context is created using<br/>clCreateContextFromType.</param>
            /// <param name="properties">properties specifies a list of properties for the command-queue and their<br/>corresponding values.<br/>Each property name is immediately followed by the corresponding desired<br/>value.<br/>The list is terminated with 0.<br/>The list of supported properties is described in the<br/>table below.<br/>If a supported property and its value is not specified in properties, its<br/>default value will be used.<br/>properties can be NULL in which case the default values for supported<br/>command-queue properties will be used.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_create_command_queue.txt">khr_create_command_queue.txt</see></remarks>
            public static IntPtr CreateCommandQueueWithPropertiesKHR(IntPtr context, IntPtr device, ulong* properties, int* errcode_ret) => CLPointers.clCreateCommandQueueWithPropertiesKHR_Lazy(context, device, properties, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_egl_event]</b> <b>[entry point: <c>clCreateEventFromEGLSyncKHR</c>]</b><br/> Link OpenCL event object to an EGL sync object </summary>
            /// <param name="context">context is a valid OpenCL context created from an OpenGL context or<br/>share group, using the cl_khr_gl_sharing extension.</param>
            /// <param name="sync">sync is the name of a sync object of type EGL_SYNC_FENCE_KHR created<br/>with respect to EGLDisplay display.</param>
            /// <param name="display">display is the EGLDisplay handle.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_egl_event.txt">khr_egl_event.txt</see></remarks>
            public static IntPtr CreateEventFromEGLSyncKHR(IntPtr context, void* sync, void* display, int* errcode_ret) => CLPointers.clCreateEventFromEGLSyncKHR_Lazy(context, sync, display, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_event]</b> <b>[entry point: <c>clCreateEventFromGLsyncKHR</c>]</b><br/> Create OpenCL event object linked to an OpenGL sync object </summary>
            /// <param name="context">context is a valid OpenCL context created from an OpenGL context or<br/>share group, using the cl_khr_gl_sharing extension.</param>
            /// <param name="sync">sync is the name of a sync object in the GL share group associated<br/>with context.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_event.txt">khr_gl_event.txt</see></remarks>
            public static IntPtr CreateEventFromGLsyncKHR(IntPtr context, IntPtr sync, int* errcode_ret) => CLPointers.clCreateEventFromGLsyncKHR_Lazy(context, sync, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clCreateFromD3D10BufferKHR</c>]</b><br/> Create OpenCL buffer object from a Direct3D 10 buffer </summary>
            /// <param name="context">context is a valid OpenCL context created from a Direct3D 10 device.</param>
            /// <param name="flags">flags is a bit-field that is used to specify usage information.<br/>Refer to the List of supported memory flag<br/>values table for a description of flags.<br/>Only the CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY and CL_MEM_READ_WRITE<br/>flags specified in that table can be used.</param>
            /// <param name="resource">resource is a pointer to the Direct3D 10 buffer to share.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d10_sharing.txt">khr_d3d10_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D10BufferKHR(IntPtr context, MemFlags flags, IntPtr* resource, int* errcode_ret) => CLPointers.clCreateFromD3D10BufferKHR_Lazy(context, (ulong)flags, resource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clCreateFromD3D10Texture2DKHR</c>]</b><br/> Create OpenCL 2D image object from a Direct3D 10 2D texture </summary>
            /// <param name="context">context is a valid OpenCL context created from a Direct3D 10 device.</param>
            /// <param name="flags">flags is a bit-field that is used to specify usage information.<br/>Refer to the List of supported memory flag<br/>values table for a description of flags.<br/>Only the CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY and CL_MEM_READ_WRITE<br/>flags specified in that table can be used.</param>
            /// <param name="resource">resource is a pointer to the Direct3D 10 2D texture to share.</param>
            /// <param name="subresource">subresource is the subresource of resource to share.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d10_sharing.txt">khr_d3d10_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D10Texture2DKHR(IntPtr context, MemFlags flags, IntPtr* resource, uint subresource, int* errcode_ret) => CLPointers.clCreateFromD3D10Texture2DKHR_Lazy(context, (ulong)flags, resource, subresource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clCreateFromD3D10Texture3DKHR</c>]</b><br/> Create OpenCL 3D image object from a Direct3D 10 3D texture </summary>
            /// <param name="context">context is a valid OpenCL context created from a Direct3D 10 device.</param>
            /// <param name="flags">flags is a bit-field that is used to specify usage information.<br/>Refer to the List of supported memory flag<br/>values table for a description of flags.<br/>Only the CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY and CL_MEM_READ_WRITE<br/>flags specified in that table can be used.</param>
            /// <param name="resource">resource is a pointer to the Direct3D 10 3D texture to share.</param>
            /// <param name="subresource">subresource is the subresource of resource to share.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d10_sharing.txt">khr_d3d10_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D10Texture3DKHR(IntPtr context, MemFlags flags, IntPtr* resource, uint subresource, int* errcode_ret) => CLPointers.clCreateFromD3D10Texture3DKHR_Lazy(context, (ulong)flags, resource, subresource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clCreateFromD3D11BufferKHR</c>]</b><br/> Create OpenCL buffer object from a Direct3D 11 buffer </summary>
            /// <param name="context">context is a valid OpenCL context created from a Direct3D 11 device.</param>
            /// <param name="flags">flags is a bit-field that is used to specify usage information.<br/>Refer to the List of supported memory flag<br/>values table for a description of flags.<br/>Only the CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY and CL_MEM_READ_WRITE<br/>flags specified in that table can be used.</param>
            /// <param name="resource">resource is a pointer to the Direct3D 11 buffer to share.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d11_sharing.txt">khr_d3d11_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D11BufferKHR(IntPtr context, MemFlags flags, IntPtr* resource, int* errcode_ret) => CLPointers.clCreateFromD3D11BufferKHR_Lazy(context, (ulong)flags, resource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clCreateFromD3D11Texture2DKHR</c>]</b><br/> Create OpenCL 2D image object from a Direct3D 11 2D texture </summary>
            /// <param name="context">context is a valid OpenCL context created from a Direct3D 11 device.</param>
            /// <param name="flags">flags is a bit-field that is used to specify usage information.<br/>Refer to the List of supported memory flag<br/>values table for a description of flags.<br/>Only the CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY and CL_MEM_READ_WRITE<br/>flags specified in that table can be used.</param>
            /// <param name="resource">resource is a pointer to the Direct3D 11 2D texture to share.</param>
            /// <param name="subresource">subresource is the subresource of resource to share.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d11_sharing.txt">khr_d3d11_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D11Texture2DKHR(IntPtr context, MemFlags flags, IntPtr* resource, uint subresource, int* errcode_ret) => CLPointers.clCreateFromD3D11Texture2DKHR_Lazy(context, (ulong)flags, resource, subresource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clCreateFromD3D11Texture3DKHR</c>]</b><br/> Create OpenCL 3D image object from a Direct3D 11 3D texture </summary>
            /// <param name="context">context is a valid OpenCL context created from a Direct3D 11 device.</param>
            /// <param name="flags">flags is a bit-field that is used to specify usage information.<br/>Refer to the List of supported memory flag<br/>values table for a description of flags.<br/>Only the CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY and CL_MEM_READ_WRITE<br/>flags specified in that table can be used.</param>
            /// <param name="resource">resource is a pointer to the Direct3D 11 3D texture to share.</param>
            /// <param name="subresource">subresource is the subresource of resource to share.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d11_sharing.txt">khr_d3d11_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D11Texture3DKHR(IntPtr context, MemFlags flags, IntPtr* resource, uint subresource, int* errcode_ret) => CLPointers.clCreateFromD3D11Texture3DKHR_Lazy(context, (ulong)flags, resource, subresource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_dx9_media_sharing]</b> <b>[entry point: <c>clCreateFromDX9MediaSurfaceKHR</c>]</b><br/> Create OpenCL image object from a media surface </summary>
            /// <param name="context">context is a valid OpenCL context created from a media adapter.</param>
            /// <param name="flags">flags is a bit-field that is used to specify usage information.<br/>Refer to the List of supported memory flag<br/>values table for a description of flags.<br/>Only the CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY and CL_MEM_READ_WRITE<br/>flags specified in that table can be used.</param>
            /// <param name="adapter_type">adapter_type is a value from enumeration of supported adapters<br/>described in the cl_dx9_media_adapter_type_khr values table.<br/>The type of surface_info is determined by the adapter type.<br/>The implementation does not need to support all adapter types.<br/>This approach provides flexibility to support additional adapter types<br/>in the future.<br/>Supported adapter types are CL_ADAPTER_D3D9_KHR,<br/>CL_ADAPTER_D3D9EX_KHR and CL_ADAPTER_DXVA_KHR.</param>
            /// <param name="surface_info">surface_info is a pointer to one of the structures defined in the<br/>adapter_type description above, passed in as a void *.<br/>If adapter_type is CL_ADAPTER_D3D9_KHR, CL_ADAPTER_D3D9EX_KHR and<br/>CL_ADAPTER_DXVA_KHR, surface_info points to a<br/>https://www.khronos.org/registry/OpenCL/specs/unified/html/OpenCL_API.html#cl_dx9_surface_info_khr structure describing the surface.</param>
            /// <param name="plane">plane is the plane of resource to share for planar surface formats.<br/>For planar formats, we use the plane parameter to obtain a handle to<br/>thie specific plane (Y, U or V for example).<br/>For non-planar formats used by media, plane must be 0.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_dx9_media_sharing.txt">khr_dx9_media_sharing.txt</see></remarks>
            public static IntPtr CreateFromDX9MediaSurfaceKHR(IntPtr context, MemFlags flags, Dx9MediaAdapterTypeKhr adapter_type, void* surface_info, uint plane, int* errcode_ret) => CLPointers.clCreateFromDX9MediaSurfaceKHR_Lazy(context, (ulong)flags, (uint)adapter_type, surface_info, plane, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_egl_image]</b> <b>[entry point: <c>clCreateFromEGLImageKHR</c>]</b><br/> Create cl_mem target from EGLImage source </summary>
            /// <param name="flags">flags is a bit-field that is used to specify usage information about<br/>the memory object being created.<br/>Refer to the Memory Flags table for a<br/>description of flags.<br/>Accepted values in flags are described below.</param>
            /// <param name="properties">properties specifies a list of property names and their corresponding<br/>values.<br/>Each property name is immediately followed by the corresponding desired<br/>value.<br/>The list is terminated with 0.<br/>No properties are currently supported with this version of the<br/>extension.<br/>properties can be NULL.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_egl_image.txt">khr_egl_image.txt</see></remarks>
            public static IntPtr CreateFromEGLImageKHR(IntPtr context, void* egldisplay, void* eglimage, MemFlags flags, IntPtr* properties, int* errcode_ret) => CLPointers.clCreateFromEGLImageKHR_Lazy(context, egldisplay, eglimage, (ulong)flags, properties, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clCreateFromGLBuffer</c>]</b><br/> Create OpenCL buffer object from an OpenGL buffer object </summary>
            /// <param name="context">context is a valid OpenCL context created from an OpenGL context.</param>
            /// <param name="flags">flags is a bit-field that is used to specify usage information.<br/>Refer to the Memory Flags table for a<br/>description of flags.<br/>Only the CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY and CL_MEM_READ_WRITE<br/>flags specified in that table can be used.</param>
            /// <param name="bufobj">bufobj is the name of an OpenGL buffer object.<br/>The data store of the OpenGL buffer object must have been<br/>previously created by calling glBufferData, although its contents need<br/>not be initialized.<br/>The size of the data store will be used to determine the size of the<br/>OpenCL buffer object.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code as described below.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_sharing.txt">khr_gl_sharing.txt</see></remarks>
            public static IntPtr CreateFromGLBuffer(IntPtr context, MemFlags flags, uint bufobj, int* errcode_ret) => CLPointers.clCreateFromGLBuffer_Lazy(context, (ulong)flags, bufobj, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clCreateFromGLRenderbuffer</c>]</b><br/> Create OpenCL 2D image object from an OpenGL renderbuffer </summary>
            /// <param name="context">context is a valid OpenCL context created from an OpenGL context.</param>
            /// <param name="flags">flags is a bit-field that is used to specify usage information.<br/>Refer to the Memory Flags table for a<br/>description of flags.<br/>Only the CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY and CL_MEM_READ_WRITE<br/>flags specified in that table can be used.</param>
            /// <param name="renderbuffer">renderbuffer is the name of an OpenGL renderbuffer object.<br/>The renderbuffer storage must be specified before the image object can<br/>be created.<br/>The renderbuffer format and dimensions defined by OpenGL will be used<br/>to create the 2D image object.<br/>Only OpenGL renderbuffers with an internal format that maps to an<br/>appropriate Image Channel Order and<br/>Image Channel Data Type may be used<br/>to create the 2D image object.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code as described below.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_sharing.txt">khr_gl_sharing.txt</see></remarks>
            public static IntPtr CreateFromGLRenderbuffer(IntPtr context, MemFlags flags, uint renderbuffer, int* errcode_ret) => CLPointers.clCreateFromGLRenderbuffer_Lazy(context, (ulong)flags, renderbuffer, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clCreateFromGLTexture</c>]</b><br/> Create OpenCL image object from an OpenGL texture object </summary>
            /// <param name="context">context is a valid OpenCL context created from an OpenGL context.</param>
            /// <param name="flags">flags is a bit-field that is used to specify usage information.<br/>Refer to the Memory Flags table for a<br/>description of flags.<br/>Only the CL_MEM_READ_ONLY, CL_MEM_WRITE_ONLY and CL_MEM_READ_WRITE<br/>flags specified in that table can be used.</param>
            /// <param name="miplevel">miplevel is the mipmap level to be used.<br/>If texture_target is GL_TEXTURE_BUFFER, miplevel must be 0.<br/>Note: Implementations may return CL_INVALID_OPERATION for miplevel<br/>values &gt; 0.</param>
            /// <param name="texture">texture is the name of an OpenGL 1D, 2D, 3D, 1D array, 2D array,<br/>cubemap, rectangle or buffer texture object.<br/>The texture object must be a complete texture as per OpenGL rules on<br/>texture completeness.<br/>The texture format and dimensions defined by OpenGL for the specified<br/>miplevel of the texture will be used to create the OpenCL image memory<br/>object.<br/>Only OpenGL texture objects with an internal format that maps to an<br/>appropriate Image Channel Order and<br/>Image Channel Data Type may be used<br/>to create the OpenCL image memory object.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code as described below.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_sharing.txt">khr_gl_sharing.txt</see></remarks>
            public static IntPtr CreateFromGLTexture(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, int* errcode_ret) => CLPointers.clCreateFromGLTexture_Lazy(context, (ulong)flags, target, miplevel, texture, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clCreateFromGLTexture2D</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_sharing.txt">khr_gl_sharing.txt</see></remarks>
            public static IntPtr CreateFromGLTexture2D(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, int* errcode_ret) => CLPointers.clCreateFromGLTexture2D_Lazy(context, (ulong)flags, target, miplevel, texture, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clCreateFromGLTexture3D</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_sharing.txt">khr_gl_sharing.txt</see></remarks>
            public static IntPtr CreateFromGLTexture3D(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, int* errcode_ret) => CLPointers.clCreateFromGLTexture3D_Lazy(context, (ulong)flags, target, miplevel, texture, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_il_program]</b> <b>[entry point: <c>clCreateProgramWithILKHR</c>]</b><br/> Creates a program object for a context, and loads the IL into the program object. </summary>
            /// <param name="context">context must be a valid OpenCL context.</param>
            /// <param name="il">il is a pointer to a block of memory containing SPIR-V or an<br/>implementation-defined intermediate language.</param>
            /// <param name="length">length is the length of the block pointed to by il.</param>
            /// <param name="errcode_ret">errcode_ret will return an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_il_program.txt">khr_il_program.txt</see></remarks>
            public static IntPtr CreateProgramWithILKHR(IntPtr context, void* il, nuint length, int* errcode_ret) => CLPointers.clCreateProgramWithILKHR_Lazy(context, il, length, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clCreateSemaphoreWithPropertiesKHR</c>]</b><br/> Create a semaphore object </summary>
            /// <param name="context">context identifies a valid OpenCL context that the created<br/>cl_semaphore_khr will belong to.</param>
            /// <param name="sema_props">sema_props specifies additional semaphore properties in the form list<br/>of &lt;property_name, property_value&gt; pairs terminated with 0.<br/>CL_SEMAPHORE_TYPE_KHR must be part of the list of properties specified<br/>by sema_props.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_semaphore.txt">khr_semaphore.txt</see></remarks>
            public static IntPtr CreateSemaphoreWithPropertiesKHR(IntPtr context, SemaphorePropertiesKhr* sema_props, int* errcode_ret) => CLPointers.clCreateSemaphoreWithPropertiesKHR_Lazy(context, (ulong*)sema_props, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clEnqueueAcquireD3D10ObjectsKHR</c>]</b><br/> Acquire OpenCL memory objects created from Direct3D 10 resources </summary>
            /// <param name="command_queue">command_queue is a valid command-queue.</param>
            /// <param name="num_objects">num_objects is the number of memory objects to be acquired in<br/>mem_objects.</param>
            /// <param name="mem_objects">mem_objects is a pointer to a list of OpenCL memory objects that were<br/>created from Direct3D 10 resources.</param>
            /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need<br/>to complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d10_sharing.txt">khr_d3d10_sharing.txt</see></remarks>
            public static int EnqueueAcquireD3D10ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireD3D10ObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clEnqueueAcquireD3D11ObjectsKHR</c>]</b><br/> Acquire OpenCL memory objects created from Direct3D 11 resources </summary>
            /// <param name="command_queue">command_queue is a valid command-queue.</param>
            /// <param name="num_objects">num_objects is the number of memory objects to be acquired in<br/>mem_objects.</param>
            /// <param name="mem_objects">mem_objects is a pointer to a list of OpenCL memory objects that were<br/>created from Direct3D 11 resources.</param>
            /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need<br/>to complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d11_sharing.txt">khr_d3d11_sharing.txt</see></remarks>
            public static int EnqueueAcquireD3D11ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireD3D11ObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_dx9_media_sharing]</b> <b>[entry point: <c>clEnqueueAcquireDX9MediaSurfacesKHR</c>]</b><br/> Acquire OpenCL memory objects created from a media surface </summary>
            /// <param name="command_queue">command_queue is a valid command-queue.</param>
            /// <param name="num_objects">num_objects is the number of memory objects to be acquired in<br/>mem_objects.</param>
            /// <param name="mem_objects">mem_objects is a pointer to a list of OpenCL memory objects that were<br/>created from media surfaces.</param>
            /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need<br/>to complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_dx9_media_sharing.txt">khr_dx9_media_sharing.txt</see></remarks>
            public static int EnqueueAcquireDX9MediaSurfacesKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireDX9MediaSurfacesKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_egl_image]</b> <b>[entry point: <c>clEnqueueAcquireEGLObjectsKHR</c>]</b><br/> Acquire OpenCL memory objects created from EGL resources </summary>
            /// <param name="command_queue">command_queue is a valid command-queue.</param>
            /// <param name="num_objects">num_objects is the number of memory objects to be acquired in<br/>mem_objects.</param>
            /// <param name="mem_objects">mem_objects is a pointer to a list of OpenCL memory objects that were<br/>created from EGL resources, within the context associate with<br/>command_queue.</param>
            /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need<br/>to complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_egl_image.txt">khr_egl_image.txt</see></remarks>
            public static int EnqueueAcquireEGLObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireEGLObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_external_memory]</b> <b>[entry point: <c>clEnqueueAcquireExternalMemObjectsKHR</c>]</b><br/> Enqueue a command to acquire OpenCL memory objects created from external memory handles </summary>
            /// <param name="command_queue">command_queue specifies a valid command-queue.</param>
            /// <param name="num_mem_objects">num_mem_objects specifies the number of memory objects to acquire.</param>
            /// <param name="mem_objects">mem_objects points to a list of valid memory objects.</param>
            /// <param name="num_events_in_wait_list">num_events_in_wait_list specifies the number of events in<br/>event_wait_list.</param>
            /// <param name="event_wait_list">event_wait_list points to the list of events that need to complete<br/>before clEnqueueAcquireExternalMemObjectsKHR can be executed.<br/>If event_wait_list is NULL, then<br/>clEnqueueAcquireExternalMemObjectsKHR does not explicitly wait on any<br/>event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and that of<br/>command_queue must be the same.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_external_memory.txt">khr_external_memory.txt</see></remarks>
            public static int EnqueueAcquireExternalMemObjectsKHR(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireExternalMemObjectsKHR_Lazy(command_queue, num_mem_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clEnqueueAcquireGLObjects</c>]</b><br/> Acquire OpenCL memory objects created from OpenGL objects </summary>
            /// <param name="command_queue">command_queue is a valid command-queue.<br/>All devices used to create the OpenCL context associated with<br/>command_queue must support acquiring shared OpenCL/OpenGL objects.<br/>This constraint is enforced at context creation time.</param>
            /// <param name="num_objects">num_objects is the number of memory objects to be acquired in<br/>mem_objects.</param>
            /// <param name="mem_objects">mem_objects is a pointer to a list of OpenCL memory objects that<br/>correspond to OpenGL objects.</param>
            /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need<br/>to complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_sharing.txt">khr_gl_sharing.txt</see></remarks>
            public static int EnqueueAcquireGLObjects(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireGLObjects_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clEnqueueCommandBufferKHR</c>]</b><br/> Enqueue a command-buffer to execute on command-queues </summary>
            /// <param name="num_queues">num_queues is the number of command-queues listed in queues.</param>
            /// <param name="queues">queues is a pointer to an ordered list of command-queues to execute the<br/>command-buffer on. queues can be NULL, in which case the default<br/>command-queues used on command-buffer creation are used and num_queues<br/>must be 0.</param>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="event_wait_list">event_wait_list, num_events_in_wait_list specify events that need to<br/>complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and<br/>command_queue must be the same.<br/>The memory associated with event_wait_list can be reused or freed<br/>after the function returns.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int EnqueueCommandBufferKHR(uint num_queues, IntPtr* queues, IntPtr command_buffer, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCommandBufferKHR_Lazy(num_queues, queues, command_buffer, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clEnqueueReleaseD3D10ObjectsKHR</c>]</b><br/> Release OpenCL memory objects created from Direct3D 10 resources </summary>
            /// <param name="num_objects">num_objects is the number of memory objects to be released in<br/>mem_objects.</param>
            /// <param name="mem_objects">mem_objects is a pointer to a list of OpenCL memory objects that were<br/>created from Direct3D 10 resources.</param>
            /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need<br/>to complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d10_sharing.txt">khr_d3d10_sharing.txt</see></remarks>
            public static int EnqueueReleaseD3D10ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseD3D10ObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clEnqueueReleaseD3D11ObjectsKHR</c>]</b><br/> Release OpenCL memory objects created from Direct3D 11 resources </summary>
            /// <param name="num_objects">num_objects is the number of memory objects to be released in<br/>mem_objects.</param>
            /// <param name="mem_objects">mem_objects is a pointer to a list of OpenCL memory objects that were<br/>created from Direct3D 11 resources.</param>
            /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need<br/>to complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d11_sharing.txt">khr_d3d11_sharing.txt</see></remarks>
            public static int EnqueueReleaseD3D11ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseD3D11ObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_dx9_media_sharing]</b> <b>[entry point: <c>clEnqueueReleaseDX9MediaSurfacesKHR</c>]</b><br/> Release OpenCL memory objects created from a media surface </summary>
            /// <param name="num_objects">num_objects is the number of memory objects to be released in<br/>mem_objects.</param>
            /// <param name="mem_objects">mem_objects is a pointer to a list of OpenCL memory objects that were<br/>created from media surfaces.</param>
            /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need<br/>to complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_dx9_media_sharing.txt">khr_dx9_media_sharing.txt</see></remarks>
            public static int EnqueueReleaseDX9MediaSurfacesKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseDX9MediaSurfacesKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_egl_image]</b> <b>[entry point: <c>clEnqueueReleaseEGLObjectsKHR</c>]</b><br/> Release OpenCL memory objects created from EGL resources </summary>
            /// <param name="command_queue">command_queue is a valid command-queue.</param>
            /// <param name="num_objects">num_objects is the number of memory objects to be acquired in<br/>mem_objects.</param>
            /// <param name="mem_objects">mem_objects is a pointer to a list of OpenCL memory objects that were<br/>created from EGL resources, within the context associate with<br/>command_queue.</param>
            /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need<br/>to complete before this particular command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_egl_image.txt">khr_egl_image.txt</see></remarks>
            public static int EnqueueReleaseEGLObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseEGLObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_external_memory]</b> <b>[entry point: <c>clEnqueueReleaseExternalMemObjectsKHR</c>]</b><br/> Enqueue a command to release OpenCL memory objects created from external memory handles </summary>
            /// <param name="command_queue">command_queue specifies a valid command-queue.</param>
            /// <param name="num_mem_objects">num_mem_objects specifies the number of memory objects to release.</param>
            /// <param name="mem_objects">mem_objects points to a list of valid memory objects.</param>
            /// <param name="num_events_in_wait_list">num_events_in_wait_list specifies the number of events in<br/>event_wait_list.</param>
            /// <param name="event_wait_list">event_wait_list points to the list of events that need to complete<br/>before clEnqueueReleaseExternalMemObjectsKHR can be executed.<br/>If event_wait_list is NULL, then<br/>clEnqueueReleaseExternalMemObjectsKHR does not wait on any event to<br/>complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and that of<br/>command_queue must be the same.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_external_memory.txt">khr_external_memory.txt</see></remarks>
            public static int EnqueueReleaseExternalMemObjectsKHR(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseExternalMemObjectsKHR_Lazy(command_queue, num_mem_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clEnqueueReleaseGLObjects</c>]</b><br/> Release OpenCL memory objects created from OpenGL objects </summary>
            /// <param name="num_objects">num_objects is the number of memory objects to be released in<br/>mem_objects.</param>
            /// <param name="mem_objects">mem_objects is a pointer to a list of OpenCL memory objects that<br/>correspond to OpenGL objects.</param>
            /// <param name="event_wait_list">event_wait_list and num_events_in_wait_list specify events that need<br/>to complete before this command can be executed.<br/>If event_wait_list is NULL, then this particular command does not<br/>wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_sharing.txt">khr_gl_sharing.txt</see></remarks>
            public static int EnqueueReleaseGLObjects(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseGLObjects_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clEnqueueSignalSemaphoresKHR</c>]</b><br/> Enqueue a command to signal a set of semaphores </summary>
            /// <param name="command_queue">command_queue specifies a valid command-queue.</param>
            /// <param name="num_sema_objects">num_sema_objects specifies the number of semaphore objects to signal.</param>
            /// <param name="sema_objects">sema_objects points to the list of semaphore objects to signal.<br/>The length of the list must be at least num_sema_objects.</param>
            /// <param name="sema_payload_list">sema_payload_list points to the list of values of type<br/>cl_semaphore_payload_khr containing semaphore payload values to<br/>signal.<br/>This can be set to NULL or will be ignored if no semaphores in the<br/>list of sema_objects require a payload.</param>
            /// <param name="num_events_in_wait_list">num_events_in_wait_list specifies the number of events in</param>
            /// <param name="event_wait_list">event_wait_list points to the list of events that need to complete<br/>before clEnqueueSignalSemaphoresKHR can be executed.<br/>If event_wait_list is NULL, then clEnqueueSignalSemaphoresKHR does<br/>not wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and that<br/>associated with command_queue must be the same.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_semaphore.txt">khr_semaphore.txt</see></remarks>
            public static int EnqueueSignalSemaphoresKHR(IntPtr command_queue, uint num_sema_objects, IntPtr* sema_objects, ulong* sema_payload_list, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSignalSemaphoresKHR_Lazy(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clEnqueueWaitSemaphoresKHR</c>]</b><br/> Enqueue a command to wait on a set of semaphores </summary>
            /// <param name="command_queue">command_queue specifies a valid command-queue.</param>
            /// <param name="num_sema_objects">num_sema_objects specifies the number of semaphore objects to wait on.</param>
            /// <param name="sema_objects">sema_objects points to the list of semaphore objects to wait on.<br/>The length of the list must be at least num_sema_objects.</param>
            /// <param name="sema_payload_list">sema_payload_list points to the list of values of type<br/>cl_semaphore_payload_khr containing valid semaphore payload<br/>values to wait on.<br/>This can be set to NULL or will be ignored if no semaphores in the<br/>list of sema_objects require a payload.</param>
            /// <param name="num_events_in_wait_list">num_events_in_wait_list specifies the number of events in<br/>event_wait_list.</param>
            /// <param name="event_wait_list">event_wait_list specifies list of events that need to complete before<br/>clEnqueueWaitSemaphoresKHR can be executed.<br/>If event_wait_list is NULL, then clEnqueueWaitSemaphoresKHR does<br/>not wait on any event to complete.<br/>If event_wait_list is NULL, num_events_in_wait_list must be 0.<br/>If event_wait_list is not NULL, the list of events pointed to by<br/>event_wait_list must be valid and num_events_in_wait_list must be<br/>greater than 0.<br/>The events specified in event_wait_list act as synchronization points.<br/>The context associated with events in event_wait_list and that<br/>associated with command_queue must be the same.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_semaphore.txt">khr_semaphore.txt</see></remarks>
            public static int EnqueueWaitSemaphoresKHR(IntPtr command_queue, uint num_sema_objects, IntPtr* sema_objects, ulong* sema_payload_list, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueWaitSemaphoresKHR_Lazy(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clFinalizeCommandBufferKHR</c>]</b><br/> Finalize command recording for a command-buffer </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int FinalizeCommandBufferKHR(IntPtr command_buffer) => CLPointers.clFinalizeCommandBufferKHR_Lazy(command_buffer);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clGetCommandBufferInfoKHR</c>]</b><br/> Query information about a command-buffer </summary>
            /// <param name="command_buffer">command_buffer specifies the command-buffer being queried.</param>
            /// <param name="param_name">param_name specifies the information to query.</param>
            /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Command-Buffer Queries table.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value">param_value is a pointer to a memory location where the appropriate<br/>result being queried is returned.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_value.<br/>If param_value_size_ret is NULL, it is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int GetCommandBufferInfoKHR(IntPtr command_buffer, CommandBufferInfoKhr param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetCommandBufferInfoKHR_Lazy(command_buffer, (uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clGetDeviceIDsFromD3D10KHR</c>]</b><br/> Query OpenCL devices corresponding to a Direct3D 10 or DXGI device </summary>
            /// <param name="platform">platform refers to the platform ID returned by clGetPlatformIDs.</param>
            /// <param name="d3d_device_source">d3d_device_source specifies the type of d3d_object, and must be one<br/>of the values shown in the<br/>Direct3D 10 Object Types table.</param>
            /// <param name="d3d_object">d3d_object specifies the object whose corresponding OpenCL devices are<br/>being queried.<br/>The type of d3d_object must be as specified in the<br/>Direct3D 10 Object Types table.</param>
            /// <param name="d3d_device_set">d3d_device_set specifies the set of devices to return, and must be one<br/>of the values shown in the<br/>Direct3D 10 Device Sets table.</param>
            /// <param name="num_entries">num_entries is the number of cl_device_id entries that can be<br/>added to devices.<br/>If devices is not NULL then num_entries must be greater than zero.</param>
            /// <param name="devices">devices returns a list of OpenCL devices found.<br/>The cl_device_id values returned in devices can be used to<br/>identify a specific OpenCL device.<br/>If devices is NULL, this argument is ignored.<br/>The number of OpenCL devices returned is the minimum of the value<br/>specified by num_entries and the number of OpenCL devices<br/>corresponding to d3d_object.</param>
            /// <param name="num_devices">num_devices returns the number of OpenCL devices available that<br/>correspond to d3d_object.<br/>If num_devices is NULL, this argument is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d10_sharing.txt">khr_d3d10_sharing.txt</see></remarks>
            public static int GetDeviceIDsFromD3D10KHR(IntPtr platform, D3D10DeviceSourceKhr d3d_device_source, void* d3d_object, D3D10DeviceSetKhr d3d_device_set, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDsFromD3D10KHR_Lazy(platform, (uint)d3d_device_source, d3d_object, (uint)d3d_device_set, num_entries, devices, num_devices);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clGetDeviceIDsFromD3D11KHR</c>]</b><br/> Query OpenCL devices corresponding to a Direct3D 11 or DXGI device </summary>
            /// <param name="platform">platform refers to the platform ID returned by clGetPlatformIDs.</param>
            /// <param name="d3d_device_source">d3d_device_source specifies the type of d3d_object, and must be one<br/>of the values shown in the<br/>Direct3D 11 Object Types table.</param>
            /// <param name="d3d_object">d3d_object specifies the object whose corresponding OpenCL devices are<br/>being queried.<br/>The type of d3d_object must be as specified in the<br/>Direct3D 11 Object Types table.</param>
            /// <param name="d3d_device_set">d3d_device_set specifies the set of devices to return, and must be one<br/>of the values shown in the<br/>Direct3D 11 Device Sets table.</param>
            /// <param name="num_entries">num_entries is the number of cl_device_id entries that can be<br/>added to devices.<br/>If devices is not NULL then num_entries must be greater than zero.</param>
            /// <param name="devices">devices returns a list of OpenCL devices found.<br/>The cl_device_id values returned in devices can be used to<br/>identify a specific OpenCL device.<br/>If devices is NULL, this argument is ignored.<br/>The number of OpenCL devices returned is the minimum of the value<br/>specified by num_entries and the number of OpenCL devices<br/>corresponding to d3d_object.</param>
            /// <param name="num_devices">num_devices returns the number of OpenCL devices available that<br/>correspond to d3d_object.<br/>If num_devices is NULL, this argument is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_d3d11_sharing.txt">khr_d3d11_sharing.txt</see></remarks>
            public static int GetDeviceIDsFromD3D11KHR(IntPtr platform, D3D11DeviceSourceKhr d3d_device_source, void* d3d_object, D3D11DeviceSetKhr d3d_device_set, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDsFromD3D11KHR_Lazy(platform, (uint)d3d_device_source, d3d_object, (uint)d3d_device_set, num_entries, devices, num_devices);
            
            /// <summary> <b>[requires: cl_khr_dx9_media_sharing]</b> <b>[entry point: <c>clGetDeviceIDsFromDX9MediaAdapterKHR</c>]</b><br/> Query media adapter for any associated OpenCL devices </summary>
            /// <param name="platform">platform refers to the platform ID returned by clGetPlatformIDs.</param>
            /// <param name="num_media_adapters">num_media_adapters specifies the number of media adapters.</param>
            /// <param name="media_adapters">media_adapters is an array of num_media_adapters entries.<br/>Each entry specifies the actual adapter whose type is specified by<br/>media_adapter_type.<br/>The media_adapters must be one of the types described in the<br/>cl_dx9_media_adapter_type_khr values<br/>table.</param>
            /// <param name="media_adapter_set">media_adapter_set specifies the set of adapters to return and must be<br/>one of the values described in the cl_dx9_media_adapter_set_khr values table.</param>
            /// <param name="num_entries">num_entries is the number of cl_device_id entries that can be<br/>added to devices.<br/>If devices is not NULL, the num_entries must be greater than zero.</param>
            /// <param name="devices">devices returns a list of OpenCL devices found that support the list<br/>of media adapters specified.<br/>The cl_device_id values returned in devices can be used to<br/>identify a specific OpenCL device.<br/>If devices argument is NULL, this argument is ignored.<br/>The number of OpenCL devices returned is the minimum of the value<br/>specified by num_entries or the number of OpenCL devices whose type<br/>matches device_type.</param>
            /// <param name="num_devices">num_devices returns the number of OpenCL devices.<br/>If num_devices is NULL, this argument is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_dx9_media_sharing.txt">khr_dx9_media_sharing.txt</see></remarks>
            public static int GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr platform, uint num_media_adapters, Dx9MediaAdapterTypeKhr* media_adapter_type, void* media_adapters, Dx9MediaAdapterSetKhr media_adapter_set, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDsFromDX9MediaAdapterKHR_Lazy(platform, num_media_adapters, (uint*)media_adapter_type, media_adapters, (uint)media_adapter_set, num_entries, devices, num_devices);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clGetGLContextInfoKHR</c>]</b><br/> Query OpenCL device corresponding to an OpenGL context </summary>
            /// <param name="properties">properties points to an property list whose format and valid contents<br/>are identical to the properties argument of clCreateContext.<br/>properties must identify a single valid GL context or GL share group<br/>object.</param>
            /// <param name="param_name">param_name is a constant that specifies the device types to query, and<br/>must be one of the values shown in the Supported Device Types table below.</param>
            /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Supported Device Types table.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value">param_value is a pointer to memory where the result of the query is<br/>returned, as described in the Supported Device<br/>Types table.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_value.<br/>If param_value_size_ret is NULL, it is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_sharing.txt">khr_gl_sharing.txt</see></remarks>
            public static int GetGLContextInfoKHR(IntPtr* properties, GlContextInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetGLContextInfoKHR_Lazy(properties, (uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clGetGLObjectInfo</c>]</b><br/> Query OpenGL object and object type used to create an OpenCL memory object </summary>
            /// <param name="memobj">memobj is the memory object to query.</param>
            /// <param name="gl_object_type">gl_object_type returns the type of OpenGL object attached to memobj<br/>and can be CL_GL_OBJECT_BUFFER, CL_GL_OBJECT_TEXTURE2D,<br/>CL_GL_OBJECT_TEXTURE3D, CL_GL_OBJECT_TEXTURE2D_ARRAY,<br/>CL_GL_OBJECT_TEXTURE1D, CL_GL_OBJECT_TEXTURE1D_ARRAY,<br/>CL_GL_OBJECT_TEXTURE_BUFFER, or CL_GL_OBJECT_RENDERBUFFER.<br/>If gl_object_type is NULL, it is ignored</param>
            /// <param name="gl_object_name">gl_object_name returns the OpenGL object name used to create memobj.<br/>If gl_object_name is NULL, it is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_sharing.txt">khr_gl_sharing.txt</see></remarks>
            public static int GetGLObjectInfo(IntPtr memobj, GlObjectType* gl_object_type, uint* gl_object_name) => CLPointers.clGetGLObjectInfo_Lazy(memobj, (uint*)gl_object_type, gl_object_name);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clGetGLTextureInfo</c>]</b><br/> Query additional information about the OpenGL texture object associated with an OpenCL memory object </summary>
            /// <param name="memobj">memobj is the memory object to query.</param>
            /// <param name="param_name">param_name specifies what additional information about the OpenGL<br/>texture object associated with memobj to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetGLTextureInfo is described in the table below.</param>
            /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the OpenGL Texture Queries table.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value">param_value is a pointer to memory where the result being queried is<br/>returned.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data copied<br/>to param_value.<br/>If param_value_size_ret is NULL, it is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_gl_sharing.txt">khr_gl_sharing.txt</see></remarks>
            public static int GetGLTextureInfo(IntPtr memobj, GlTextureInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetGLTextureInfo_Lazy(memobj, (uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_subgroups]</b> <b>[entry point: <c>clGetKernelSubGroupInfoKHR</c>]</b><br/> Returns information about the kernel object. </summary>
            /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetKernelSubGroupInfo is described in the<br/>Kernel Object Sub-group Queries table.</param>
            /// <param name="input_value_size">input_value_size is used to specify the size in bytes of memory pointed to<br/>by input_value.<br/>This size must be == size of input type as described in the table below.</param>
            /// <param name="input_value">input_value is a pointer to memory where the appropriate parameterization<br/>of the query is passed from.<br/>If input_value is NULL, it is ignored.</param>
            /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Kernel Object Sub-group Queries table.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_subgroups.txt">khr_subgroups.txt</see></remarks>
            public static int GetKernelSubGroupInfoKHR(IntPtr in_kernel, IntPtr in_device, KernelSubGroupInfo param_name, nuint input_value_size, void* input_value, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetKernelSubGroupInfoKHR_Lazy(in_kernel, in_device, (uint)param_name, input_value_size, input_value, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_suggested_local_work_size]</b> <b>[entry point: <c>clGetKernelSuggestedLocalWorkSizeKHR</c>]</b><br/> Query suggested local work size for a kernel object </summary>
            /// <param name="command_queue">command_queue specifies the command-queue and device for the query.</param>
            /// <param name="kernel">kernel specifies the kernel object and kernel arguments for the query.<br/>The OpenCL context associated with kernel and command_queue must the<br/>same.</param>
            /// <param name="work_dim">work_dim specifies the number of work dimensions in the input global<br/>work offset and global work size, and the output suggested local work<br/>size.</param>
            /// <param name="global_work_offset">global_work_offset can be used to specify an array of at least<br/>work_dim global ID offset values for the query.<br/>This is optional and may be NULL to indicate there is no global ID<br/>offset.</param>
            /// <param name="global_work_size">global_work_size is an array of at least work_dim values describing<br/>the global work size for the query.</param>
            /// <param name="suggested_local_work_size">suggested_local_work_size is an output array of at least work_dim<br/>values that will contain the result of the query.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_suggested_local_work_size.txt">khr_suggested_local_work_size.txt</see></remarks>
            public static int GetKernelSuggestedLocalWorkSizeKHR(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* suggested_local_work_size) => CLPointers.clGetKernelSuggestedLocalWorkSizeKHR_Lazy(command_queue, kernel, work_dim, global_work_offset, global_work_size, suggested_local_work_size);
            
            /// <summary> <b>[requires: cl_khr_command_buffer_mutable_dispatch]</b> <b>[entry point: <c>clGetMutableCommandInfoKHR</c>]</b><br/> Query information about a mutable command object </summary>
            /// <param name="command">command specifies the mutable-command object being queried.</param>
            /// <param name="param_name">param_name specifies the information to query.<br/>The list of supported param_name types and the information returned in<br/>param_value by clGetMutableCommandInfoKHR is described in the<br/>Mutable Command Object Queries<br/>table.</param>
            /// <param name="param_value_size">param_value_size is used to specify the size in bytes of memory<br/>pointed to by param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Mutable Command Object Queries table.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value">param_value is a pointer to memory where the appropriate result being<br/>queried is returned.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_name.<br/>If param_value_size_ret is NULL, it is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer_mutable_dispatch.txt">khr_command_buffer_mutable_dispatch.txt</see></remarks>
            public static int GetMutableCommandInfoKHR(IntPtr command, MutableCommandInfoKhr param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetMutableCommandInfoKHR_Lazy(command, (uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_external_semaphore]</b> <b>[entry point: <c>clGetSemaphoreHandleForTypeKHR</c>]</b><br/> Export external handle from a semaphore </summary>
            /// <param name="sema_object">sema_object specifies a valid semaphore object with exportable<br/>properties.</param>
            /// <param name="device">device specifies a valid device for which a semaphore handle is being<br/>requested.</param>
            /// <param name="handle_type">handle_type specifies the type of semaphore handle that should be<br/>returned for this exportable sema_object, and must be one of the<br/>values specified when sema_object was created.</param>
            /// <param name="handle_size">handle_size specifies the size in bytes of memory pointed to by<br/>handle_ptr.<br/>This size must be greater than or equal to the size of the handle type<br/>specified by handle_type.<br/>If handle_ptr is NULL, it is ignored.</param>
            /// <param name="handle_ptr">handle_ptr is a pointer to memory where the exported external handle<br/>is returned.<br/>If handle_ptr is NULL, it is ignored.</param>
            /// <param name="handle_size_ret">handle_size_ret returns the actual size in bytes for the external<br/>handle.<br/>If handle_size_ret is NULL, it is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_external_semaphore.txt">khr_external_semaphore.txt</see></remarks>
            public static int GetSemaphoreHandleForTypeKHR(IntPtr sema_object, IntPtr device, ExternalSemaphoreHandleTypeKhr handle_type, nuint handle_size, void* handle_ptr, nuint* handle_size_ret) => CLPointers.clGetSemaphoreHandleForTypeKHR_Lazy(sema_object, device, (uint)handle_type, handle_size, handle_ptr, handle_size_ret);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clGetSemaphoreInfoKHR</c>]</b><br/> Query information about a semaphore object </summary>
            /// <param name="sema_object">sema_object specifies the semaphore object being queried.</param>
            /// <param name="param_name">param_name is a constant that specifies the semaphore information to<br/>query, and must be one of the values shown in the<br/>Semaphore Queries table.</param>
            /// <param name="param_value_size">param_value_size specifies the size in bytes of memory pointed to by<br/>param_value.<br/>This size must be greater than or equal to the size of the return type<br/>specified in the Semaphore Queries table.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value">param_value is a pointer to memory where the result of the query is<br/>returned as described in the Semaphore<br/>Queries table.<br/>If param_value is NULL, it is ignored.</param>
            /// <param name="param_value_size_ret">param_value_size_ret returns the actual size in bytes of data being<br/>queried by param_value.<br/>If param_value_size_ret is NULL, it is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_semaphore.txt">khr_semaphore.txt</see></remarks>
            public static int GetSemaphoreInfoKHR(IntPtr sema_object, SemaphoreInfoKhr param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetSemaphoreInfoKHR_Lazy(sema_object, (uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_unified_svm]</b> <b>[entry point: <c>clGetSVMPointerInfoKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_unified_svm.txt">khr_unified_svm.txt</see></remarks>
            public static int GetSVMPointerInfoKHR(IntPtr context, IntPtr device, void* ptr, SvmPointerInfoKhr param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetSVMPointerInfoKHR_Lazy(context, device, ptr, (uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_unified_svm]</b> <b>[entry point: <c>clGetSVMSuggestedTypeIndexKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_unified_svm.txt">khr_unified_svm.txt</see></remarks>
            public static int GetSVMSuggestedTypeIndexKHR(IntPtr context, SvmCapabilitiesKhr required_capabilities, SvmCapabilitiesKhr desired_capabilities, SvmAllocPropertiesKhr* properties, nuint size, uint* suggested_svm_type_index) => CLPointers.clGetSVMSuggestedTypeIndexKHR_Lazy(context, (ulong)required_capabilities, (ulong)desired_capabilities, (ulong*)properties, size, suggested_svm_type_index);
            
            /// <summary> <b>[requires: cl_khr_icd]</b> <b>[entry point: <c>clIcdGetFunctionAddressForPlatformKHR</c>]</b><br/> Query API entry points for a platform </summary>
            /// <param name="platform">platform refers to the platform ID returned by clIcdGetPlatformIDsKHR</param>
            /// <param name="func_name">func_name name of an API entry point</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_icd.txt">khr_icd.txt</see></remarks>
            public static void* IcdGetFunctionAddressForPlatformKHR(IntPtr platform, byte* func_name) => CLPointers.clIcdGetFunctionAddressForPlatformKHR_Lazy(platform, func_name);
            
            /// <summary> <b>[requires: cl_khr_icd]</b> <b>[entry point: <c>clIcdGetPlatformIDsKHR</c>]</b><br/> Query platforms accessible through the Khronos ICD Loader </summary>
            /// <param name="num_entries">num_entries is the number of cl_platform_id entries that can be<br/>added to platforms.<br/>If platforms is not NULL, then num_entries must be greater than<br/>zero.</param>
            /// <param name="platforms">platforms returns a list of OpenCL platforms available for access<br/>through the Khronos ICD Loader.<br/>The cl_platform_id values returned in platforms are ICD<br/>compatible and can be used to identify a specific OpenCL platform.<br/>If the platforms argument is NULL, then this argument is ignored.<br/>The number of OpenCL platforms returned is the minimum of the value<br/>specified by num_entries or the number of OpenCL platforms available.</param>
            /// <param name="num_platforms">num_platforms returns the number of OpenCL platforms available.<br/>If num_platforms is NULL, then this argument is ignored.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_icd.txt">khr_icd.txt</see></remarks>
            public static int IcdGetPlatformIDsKHR(uint num_entries, IntPtr* platforms, uint* num_platforms) => CLPointers.clIcdGetPlatformIDsKHR_Lazy(num_entries, platforms, num_platforms);
            
            /// <summary> <b>[requires: cl_khr_icd]</b> <b>[entry point: <c>clIcdSetPlatformDispatchDataKHR</c>]</b><br/> Set the dispatch data for a platform </summary>
            /// <param name="platform">platform refers to the platform ID returned by clIcdGetPlatformIDsKHR</param>
            /// <param name="dispatch_data">dispatch_data is the value to set the dispatch_data field of the<br/>structure to</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_icd.txt">khr_icd.txt</see></remarks>
            public static int IcdSetPlatformDispatchDataKHR(IntPtr platform, void* dispatch_data) => CLPointers.clIcdSetPlatformDispatchDataKHR_Lazy(platform, dispatch_data);
            
            /// <summary> <b>[requires: cl_khr_external_semaphore_sync_fd]</b> <b>[entry point: <c>clReImportSemaphoreSyncFdKHR</c>]</b><br/> Re-import sync fd handle into an existing semaphore </summary>
            /// <param name="sema_object">sema_object specifies a valid semaphore object with importable<br/>properties.</param>
            /// <param name="reimport_props">reimport_props is an optional list of properties that affect the<br/>re-import behavior. The list is terminated with the special property 0.<br/>If no properties are required, reimport_props may be NULL. This extension<br/>does not define any optional properties.</param>
            /// <param name="fd">fd specifies an external file descriptor handle to import</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_external_semaphore_sync_fd.txt">khr_external_semaphore_sync_fd.txt</see></remarks>
            public static int ReImportSemaphoreSyncFdKHR(IntPtr sema_object, ulong* reimport_props, int fd) => CLPointers.clReImportSemaphoreSyncFdKHR_Lazy(sema_object, reimport_props, fd);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clReleaseCommandBufferKHR</c>]</b><br/> Decrement a command-buffer's reference count </summary>
            /// <param name="command_buffer">command_buffer specifies the command-buffer to release.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int ReleaseCommandBufferKHR(IntPtr command_buffer) => CLPointers.clReleaseCommandBufferKHR_Lazy(command_buffer);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clReleaseSemaphoreKHR</c>]</b><br/> Release a semaphore object </summary>
            /// <param name="sema_object">sema_object specifies the semaphore object to be released.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_semaphore.txt">khr_semaphore.txt</see></remarks>
            public static int ReleaseSemaphoreKHR(IntPtr sema_object) => CLPointers.clReleaseSemaphoreKHR_Lazy(sema_object);
            
            /// <summary> <b>[requires: cl_khr_command_buffer_multi_device]</b> <b>[entry point: <c>clRemapCommandBufferKHR</c>]</b><br/> Create copy of a command-buffer remapped to specified command-queues </summary>
            /// <param name="command_buffer">command_buffer specifies the command-buffer to create a remapped deep<br/>copy of.</param>
            /// <param name="automatic">automatic indicates if the remapping is done explicitly by the user,<br/>or automatically by the OpenCL runtime.<br/>If automatic is CL_FALSE, then each element of queues will replace<br/>the queue used on command_buffer creation at the same index.<br/>If CL_TRUE and CL_COMMAND_BUFFER_PLATFORM_AUTOMATIC_REMAP_KHR is<br/>supported, then the OpenCL runtime will decide in a way it determines<br/>optimal which of the elements in queues each command in the returned<br/>command-buffer will be associated with.</param>
            /// <param name="num_queues">num_queues is the number of command-queues listed in queues, must<br/>not be 0.</param>
            /// <param name="queues">queues is a pointer to an ordered list of command-queues for the<br/>returned command-buffer to target, must be a non-NULL value.</param>
            /// <param name="num_handles">num_handles is the number of command handles passed in both handles<br/>and handles_ret lists, may be 0.</param>
            /// <param name="handles">handles is an ordered list of handles belonging to command_buffer to<br/>create remapped copies of, may be NULL.</param>
            /// <param name="handles_ret">handles_ret returns an ordered list of handles where each handle is<br/>equivalent to the handle at the same index in handles, but belonging<br/>to the returned command-buffer.</param>
            /// <param name="errcode_ret">errcode_ret returns an appropriate error code.<br/>If errcode_ret is NULL, no error code is returned.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer_multi_device.txt">khr_command_buffer_multi_device.txt</see></remarks>
            public static IntPtr RemapCommandBufferKHR(IntPtr command_buffer, Bool automatic, uint num_queues, IntPtr* queues, uint num_handles, IntPtr* handles, IntPtr* handles_ret, int* errcode_ret) => CLPointers.clRemapCommandBufferKHR_Lazy(command_buffer, (uint)automatic, num_queues, queues, num_handles, handles, handles_ret, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clRetainCommandBufferKHR</c>]</b><br/> Increment a command-buffer's reference count </summary>
            /// <param name="command_buffer">command_buffer specifies the command-buffer to retain.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer.txt">khr_command_buffer.txt</see></remarks>
            public static int RetainCommandBufferKHR(IntPtr command_buffer) => CLPointers.clRetainCommandBufferKHR_Lazy(command_buffer);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clRetainSemaphoreKHR</c>]</b><br/> Retain a semaphore object </summary>
            /// <param name="sema_object">sema_object specifies the semaphore object to be retained.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_semaphore.txt">khr_semaphore.txt</see></remarks>
            public static int RetainSemaphoreKHR(IntPtr sema_object) => CLPointers.clRetainSemaphoreKHR_Lazy(sema_object);
            
            /// <summary> <b>[requires: cl_khr_unified_svm]</b> <b>[entry point: <c>clSVMAllocWithPropertiesKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_unified_svm.txt">khr_unified_svm.txt</see></remarks>
            public static void* SVMAllocWithPropertiesKHR(IntPtr context, SvmAllocPropertiesKhr* properties, uint svm_type_index, nuint size, int* errcode_ret) => CLPointers.clSVMAllocWithPropertiesKHR_Lazy(context, (ulong*)properties, svm_type_index, size, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_unified_svm]</b> <b>[entry point: <c>clSVMFreeWithPropertiesKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_unified_svm.txt">khr_unified_svm.txt</see></remarks>
            public static int SVMFreeWithPropertiesKHR(IntPtr context, ulong* properties, ulong flags, void* ptr) => CLPointers.clSVMFreeWithPropertiesKHR_Lazy(context, properties, flags, ptr);
            
            /// <summary> <b>[requires: cl_khr_terminate_context]</b> <b>[entry point: <c>clTerminateContextKHR</c>]</b><br/> Terminate pending work associated with a context and render data owned by the context invalid </summary>
            /// <param name="context">context must be a valid OpenCL context.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_terminate_context.txt">khr_terminate_context.txt</see></remarks>
            public static int TerminateContextKHR(IntPtr context) => CLPointers.clTerminateContextKHR_Lazy(context);
            
            /// <summary> <b>[requires: cl_khr_command_buffer_mutable_dispatch]</b> <b>[entry point: <c>clUpdateMutableCommandsKHR</c>]</b><br/> Modify configuration of mutable-command handles to update behavior for future enqueues </summary>
            /// <param name="command_buffer">command_buffer refers to a valid command-buffer object.</param>
            /// <param name="num_configs">num_configs  Number of elements in the config_types and config arrays.</param>
            /// <param name="config_types">config_types An array of length num_configs with each element identifying<br/>the type of each config in configs at the same array index.</param>
            /// <param name="configs">configs An array of length num_configs containing structs which define how a<br/>mutable-command handle in command_buffer is to be updated, each of which is<br/>interpreted using config_types at the same index with the mapping defined<br/>in the Mutable Command Update Structs section.</param>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/khr/cl_khr_command_buffer_mutable_dispatch.txt">khr_command_buffer_mutable_dispatch.txt</see></remarks>
            public static int UpdateMutableCommandsKHR(IntPtr command_buffer, uint num_configs, CommandBufferUpdateTypeKhr* config_types, void** configs) => CLPointers.clUpdateMutableCommandsKHR_Lazy(command_buffer, num_configs, (uint*)config_types, configs);
            
        }
        /// <summary>LOADER extensions.</summary>
        public static unsafe partial class LOADER
        {
            /// <summary> <b>[requires: cl_loader_layers]</b> <b>[entry point: <c>clDeinitLayer</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/loader/cl_loader_layers.txt">loader_layers.txt</see></remarks>
            public static int DeinitLayer() => CLPointers.clDeinitLayer_Lazy();
            
            /// <summary> <b>[requires: cl_loader_info]</b> <b>[entry point: <c>clGetICDLoaderInfoOCLICD</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/loader/cl_loader_info.txt">loader_info.txt</see></remarks>
            public static int GetICDLoaderInfoOCLICD(IcdlInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetICDLoaderInfoOCLICD_Lazy((uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_loader_layers]</b> <b>[entry point: <c>clGetLayerInfo</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/loader/cl_loader_layers.txt">loader_layers.txt</see></remarks>
            public static int GetLayerInfo(LayerInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetLayerInfo_Lazy((uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_loader_layers]</b> <b>[entry point: <c>clInitLayer</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/loader/cl_loader_layers.txt">loader_layers.txt</see></remarks>
            public static int InitLayer(uint num_entries, IntPtr target_dispatch, uint* num_entries_ret, IntPtr* layer_dispatch_ret) => CLPointers.clInitLayer_Lazy(num_entries, target_dispatch, num_entries_ret, layer_dispatch_ret);
            
            /// <summary> <b>[requires: cl_loader_layers]</b> <b>[entry point: <c>clInitLayerWithProperties</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/loader/cl_loader_layers.txt">loader_layers.txt</see></remarks>
            public static int InitLayerWithProperties(uint num_entries, IntPtr target_dispatch, uint* num_entries_ret, IntPtr* layer_dispatch_ret, ulong* properties) => CLPointers.clInitLayerWithProperties_Lazy(num_entries, target_dispatch, num_entries_ret, layer_dispatch_ret, properties);
            
        }
        /// <summary>POCL extensions.</summary>
        public static unsafe partial class POCL
        {
            /// <summary> <b>[requires: cl_pocl_content_size]</b> <b>[entry point: <c>clSetContentSizeBufferPoCL</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/pocl/cl_pocl_content_size.txt">pocl_content_size.txt</see></remarks>
            public static int SetContentSizeBufferPoCL(IntPtr buffer, IntPtr content_size_buffer) => CLPointers.clSetContentSizeBufferPoCL_Lazy(buffer, content_size_buffer);
            
        }
        /// <summary>QCOM extensions.</summary>
        public static unsafe partial class QCOM
        {
            /// <summary> <b>[requires: cl_qcom_ext_host_ptr]</b> <b>[entry point: <c>clGetDeviceImageInfoQCOM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/qcom/cl_qcom_ext_host_ptr.txt">qcom_ext_host_ptr.txt</see></remarks>
            public static int GetDeviceImageInfoQCOM(IntPtr device, nuint image_width, nuint image_height, cl_image_format* image_format, ImagePitchInfoQcom param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetDeviceImageInfoQCOM_Lazy(device, image_width, image_height, image_format, (uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_qcom_perf_hint]</b> <b>[entry point: <c>clSetPerfHintQCOM</c>]</b><br/>  </summary>
            /// <remarks><see href="https://registry.khronos.org/OpenCL/extensions/qcom/cl_qcom_perf_hint.txt">qcom_perf_hint.txt</see></remarks>
            public static int SetPerfHintQCOM(IntPtr context, PerfHintQcom perf_hint) => CLPointers.clSetPerfHintQCOM_Lazy(context, (uint)perf_hint);
            
        }
    }
}
