module TypeMapping

let csharpTypeToSpecType =
    [| "BooleanPointer", "GLboolean*"
       "Boolean", "GLboolean"
       "Char", "GLchar"
       "CharPointer", "GLchar*"
       "ConstCharPointer", "GLchar* const"
       "CheckedFloat32", "GLfloat"
       "CheckedInt32", "GLint"
       "ClampedFixed", "GLfixed"
       "ClampedFloat32", "GLclampf"
       "ClampedFloat64", "GLclampd"
       "ClampedStencilValue", "GLint"
       "ColorB", "GLbyte"
       "ColorD", "GLdouble"
       "ColorF", "GLfloat"
       "ColorI", "GLint"
       "ColorIndexValueD", "GLdouble"
       "ColorIndexValueF", "GLfloat"
       "ColorIndexValueI", "GLint"
       "ColorIndexValueS", "GLshort"
       "ColorIndexValueUB", "GLubyte"
       "ColorS", "GLshort"
       "ColorUB", "GLubyte"
       "ColorUI", "GLuint"
       "ColorUS", "GLushort"
       "CompressedTextureARB", "GLvoid*"
       "CoordD", "GLdouble"
       "CoordF", "GLfloat"
       "CoordI", "GLint"
       "CoordS", "GLshort"
       "DrawBufferName", "GLint"
       "FeedbackElement", "GLfloat"
       "FenceNV", "GLuint"
       "Float32", "GLfloat"
       "Float32Pointer", "GLfloat*"
       "Float64", "GLdouble"
       "Float64Pointer", "GLdouble*"
       "Fixed", "GLfixed"
       "ConstFixed", "GLfixed"
       "FunctionPointer", "_GLfuncptr"
       "IglooParameterSGIX", "GLvoid*"
       "Int16", "GLshort"
       "Int32", "GLint"
       "Int8", "GLbyte"
       "LineStipple", "GLushort"
       "List", "GLuint"
       "MaskedColorIndexValueF", "GLfloat"
       "MaskedColorIndexValueI", "GLuint"
       "MaskedStencilValue", "GLuint"
       "ProgramCharacterNV", "GLubyte"
       "ReplacementCodeSUN", "GLuint"
       "SelectName", "GLuint"
       "SizeI", "GLsizei"
       "StencilValue", "GLint"
       "Texture", "GLuint"
       "UInt16", "GLushort"
       "UInt32", "GLuint"
       "UInt8", "GLubyte"
       "Void", "GLvoid"
       "VoidPointer", "GLvoid*"
       "ConstVoidPointer", "GLvoid* const"
       "WinCoord", "GLint"
       "ConstByte", "GLbyte"
       "ConstUByte", "GLubyte"
       "ConstFloat32", "GLfloat"
       "ConstInt32", "GLint"
       "ConstUInt32", "GLuint"
       "ConstVoid", "GLvoid"
       // ARB_vertex_buffer_object types and core equivalents for new types
       "BufferOffset", "GLintptr"
       "BufferSize", "GLsizeiptr"
       "BufferOffsetARB", "GLintptrARB"
       "BufferSizeARB", "GLsizeiptrARB"
       // NV_half
       "Half16NV", "GLhalfNV"
       // Generic types for as-yet-unspecified enums
       "TypeEnum", "GLenum"
       "Int64", "GLint64"
       "UInt64", "GLuint64"
       // Object handle & data pointers
       "handleARB", "GLhandleARB"
       "charARB", "GLcharARB"
       "charPointerARB", "GLcharARB*"
       "sync", "GLsync"
       // EXT_timer_query
       "Int64EXT", "GLint64EXT"
       "UInt64EXT", "GLuint64EXT"
       // EXT_direct_state_access
       "Framebuffer", "GLuint"
       "Intptr", "GLintptr"
       "Renderbuffer", "GLuint"
       "Sizeiptr", "GLsizeiptr"
       // NV_vdpau_interop
       "vdpauSurfaceNV", "GLvdpauSurfaceNV"
       // External API types
       "Path", "GLuint"
       "PathCommand", "GLubyte"
       "PathElement", "GLvoid*" |]
    |> Map.ofArray

let specTypeToCSharpType =
    [| // Normal types.
       "GLsizei", "uint"
       "GLsizeiptr", "UIntPtr"
       "GLintptr", "IntPtr"
       "GLboolean", "bool" // Boolean // Int32
       "GLbitfield", "uint"
       "GLvoid", "void" //Object
       "GLchar", "char"
       "GLbyte", "sbyte"
       "GLubyte", "byte"
       "GLshort", "short"
       "GLushort", "ushort"
       "GLint", "int"
       "GLuint", "uint"
       "GLfloat", "float"
       "GLclampf", "float"
       "GLdouble", "double"
       "GLclampd", "double"
       "GLstring", "string"
       "String", "string"
       // Pointer types
       "GLvoid*", "void*"
       "GLchar*", "string"
       "GLcharARB*", "string"
       "GLfloat*", "float*"
       "GLdouble*", "double*"
       "GLboolean*", "bool*"
       // Note: ADL cannot marshal arrays as return types.
       // There's no function in the spec that does but if one's added we need to look into this.
       "GLchar**", "string[]"
       // ARB and NV types.
       "GLsizeiptrARB", "UIntPtr"
       "GLintptrARB", "IntPtr"
       "GLhandleARB", "uint"
       "GLhalfARB", "OpenTK.Mathematics.Half"
       "GLhalfNV", "OpenTK.Mathematics.Half"
       "GLcharARB", "char"
       // 64 bit types (introduced in 2.1)
       "GLint64EXT", "long"
       "GLuint64EXT", "ulong"
       "GLint64", "long"
       "GLuint64", "ulong"
       // ARB_sync (introduced in 3.2)
       "sync", "IntPtr"
       "GLsync", "IntPtr"
       // Debug callbacks
       "GLDEBUGPROC", "DebugProc"
       "GLDEBUGPROCAMD", "DebugProcAmd"
       "GLDEBUGPROCARB", "DebugProcArb"
       "GLDEBUGPROCKHR", "DebugProcKhr"
       // NV_vdpau
       "GLvdpauSurfaceNV", "IntPtr"
       // Wgl types.
       "PROC", "IntPtr"
       "LPCSTR", "string"
       "COLORREF", "int"
       "BOOL", "bool"
       "DWORD", "int"
       "FLOAT", "float"
       "HANDLE", "IntPtr"
       "HDC", "IntPtr"
       "HGLRC", "IntPtr"
       "HPBUFFERARB", "IntPtr" //HPBUFFERARB
       "HPBUFFEREXT", "IntPtr" //HPBUFFEREXT
       "INT32", "int"
       "INT64", "long"
       "LPVOID", "void*"
       "UINT", "uint"
       "USHORT", "ushort"
       "VOID", "void"
       "VoidPointer", "void*"
       // Glu types.
       "Float64", "double"
       "Float64Pointer", "double*"
       "Float32", "float"
       "Float32Pointer", "float*"
       // Glx types.
       "Void", "void"
       "Bool", "bool"
       "int64_t", "long"
       "int32_t", "int"
       "Display", "IntPtr"
       "Window", "IntPtr"
       "Pixmap", "IntPtr"
       "Colormap", "IntPtr"
       "GLXWindow", "IntPtr"
       "GLXContext", "IntPtr"
       "GLXDrawable", "IntPtr"
       "GLXPixmap", "IntPtr"
       "__GLXextFuncPtr", "IntPtr"
       "VLServer", "IntPtr"
       "VLPath", "IntPtr"
       "VLNode", "IntPtr"
       // OpenGL|ES types.
       "GLclampx", "int"
       "GLfixed", "int"
       "GLeglImageOES", "IntPtr"
       // External egl buffer type added in OpenGL 4.6
       "GLeglClientBufferEXT", "IntPtr"
       // nVidia vulkan entry point added by NV_draw_vulkan_image extension
       "GLVULKANPROCNV", "IntPtr"
       // OpenCL types.
       "_cl_context", "IntPtr"
       "_cl_event", "IntPtr"
       "cl_command_queue", "IntPtr"
       "cl_context", "IntPtr"
       "cl_device_id", "IntPtr"
       "cl_event", "IntPtr"
       "cl_kernel", "IntPtr"
       "cl_mem", "IntPtr"
       "cl_platform_id", "IntPtr"
       "cl_program", "IntPtr"
       "cl_sampler", "IntPtr"
       "size_t", "IntPtr"
       "cl_bool", "bool"
       "cl_int", "int"
       "cl_uint", "uint"
       "uchar", "byte"
       "cl_addressing_mode", "AddressingMode"
       "cl_command_queue_info", "CommandQueueInfo"
       "cl_command_queue_properties", "CommandQueueProperties"
       "cl_context_info", "ContextInfo"
       "cl_context_properties", "IntPtr" // ContextProperties
       "cl_device_info", "DeviceInfo"
       "cl_device_type", "DeviceType"
       "cl_event_info", "EventInfo"
       "cl_filter_mode", "FilterMode"
       "cl_image_format", "ImageFormat"
       "cl_image_info", "ImageInfo"
       "cl_kernel_group_info", "KernelGroupInfo"
       "cl_kernel_info", "KernelInfo"
       "cl_kernel_work_group_info", "KernelWorkGroupInfo"
       "cl_map_flags", "MapFlags"
       "cl_mem_info", "MemInfo"
       "cl_mem_flags", "MemFlags"
       "cl_mem_object_type", "MemObjectType"
       "cl_platform_info", "PlatformInfo"
       "cl_profiling_info", "ProfilingInfo"
       "cl_program_build_info", "ProgramBuildInfo"
       "cl_program_info", "ProgramInfo"
       "cl_sampler_info", "SamplerInfo"
       "cl_work_group_info", "WorkGroupInfo" |]
    |> Map.ofArray

open Util
open Types

let looslyTypedFunctionsToTypedFunctions enumMap functions =
    let typecheckParams parameters =
        let len = (parameters |> Array.length)
        let res = Array.zeroCreate len

        let rec typecheck index =
            if index < len then
                let currParam = parameters.[index]
                match currParam.paramType
                      |> Parsing.tryParseType enumMap currParam.paramName with
                | Some typ ->
                    res.[index] <- typedParameterInfoWith currParam.paramName typ currParam.lengthParamName
                    typecheck (index + 1)
                | None -> false
            else true
        if typecheck 0 then Some res
        else None
    functions
    |> Array.Parallel.choose (fun func ->
        maybe {
            let! retType = func.retType
                           |> Parsing.tryParseType enumMap func.funcName
            let! parameters = func.parameters |> typecheckParams
            let res = typedFunctionDeclaration func.funcName parameters retType [||]
            return! Some res
        })

let rec tryGetEnumType (typ: GLType) =
    match typ with
    | GLType.Pointer inner -> tryGetEnumType inner
    | GLType.GLenum group -> Some group
    | _ -> None
