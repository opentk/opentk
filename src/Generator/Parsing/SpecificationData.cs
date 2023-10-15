using Generator.Writing;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.IO.Compression;

namespace Generator.Parsing
{
    public enum InputAPI
    {
        GL,
        GLES1,
        GLES2,
        WGL,
        GLX,
    }

    [Flags]
    public enum EnumAPI
    {
        None = 0,
        GL = 1 << 0,
        GLCompat = 1 << 1,
        GLES1 = 1 << 2,
        GLES2 = 1 << 3,
        WGL = 1 << 4,
        GLX = 1 << 5,
    }

    public record GLFileData(
        GLFile File,
        List<NativeFunction> Functions,
        List<EnumEntry> Enums,
        List<API> APIs);

    public record Specification2(
        //List<Command> Commands,
        List<NativeFunction> Functions,
        List<EnumEntry> Enums,
        List<API> APIs);

    public record API(
        InputAPI Name,
        List<FunctionReference> Functions,
        List<EnumReference> Enums);

    public record FunctionReference(
        string EntryPoint,
        Version? AddedIn,
        Version? RemovedIn,
        List<ExtensionReference> PartOfExtensions,
        GLProfile Profile);

    public record EnumReference(
        string EnumName,
        Version? AddedIn,
        Version? RemovedIn,
        List<ExtensionReference> PartOfExtensions,
        // FIXME! there can be multiple profiles??
        GLProfile Profile,
        // Is this enum reference copied from another namespace.
        bool IsCrossReferenced);

    public record APIVersion(
        Version Name,
        List<string> EntryPoints,
        List<string> EnumValues);

    public record ExtensionReference(
        string Name,
        string Vendor);
        //List<string> EntryPoints,
        //List<string> EnumValues);


    /*public record Specification(
        List<Command> Commands,
        List<Enums> Enums,
        List<Feature> Features,
        List<Extension> Extensions);*/


    /*public record Command(
        string EntryPoint,
        PType ReturnType,
        GLParameter[] Parameters);*/

    // FIXME: Maybe flatten the list of enums?
    /*public record Enums(
        string Namespace,
        GroupRef[] Groups,
        EnumType Type,
        string? Vendor,
        Range? Range,
        string? Comment,
        List<EnumEntry> Entries);*/

    public record EnumEntry(
        string Name,
        string MangledName,
        ulong Value,
        OutputApiFlags Apis,
        EnumType Type,
        string? Vendor,
        string? Alias,
        GroupRef[] Groups,
        TypeSuffix Suffix);


    public record Feature(
        GLAPI Api,
        Version Version,
        string Name,
        List<RequireEntry> Requires,
        List<RemoveEntry> Removes);

    public record Extension(
        string Name,
        string Vendor,
        GLAPI[] SupportedApis,
        string? Comment,
        List<RequireEntry> Requires);


    public record RequireEntry(
        GLAPI Api,
        GLProfile Profile,
        string? Comment,
        List<string> Commands,
        List<string> Enums);

    public record RemoveEntry(
        GLProfile Profile,
        string? Comment,
        List<string> Commands,
        List<string> Enums);


    public record PType(
        GLType Type,
        HandleType? Handle,
        GroupRef? Group);

    public enum GLFile
    {
        GL,
        WGL,
        GLX,
    }

    /// <param name="Name">The name of the referenced enum group.</param>
    /// <param name="Namespace">The enum namespace that is referenced (gl, wgl, or glx).</param>
    public record GroupRef(string Name, GLFile Namespace);

    public abstract record GLType();

    public record GLBaseType(
        string OriginalString,
        PrimitiveType Type,
        bool Constant) : GLType;

    public record GLPointerType(
        GLType BaseType,
        bool Constant) : GLType;


    public record Expression
    {
        // FIXME: Clean up this mess. We assume a lot of things we maybe dont wanna assume?
        // Can all lengths even be inverted and what should happen if they cant?
        // For now this works, but it might break later. 2021-06-23.
        public static string? InvertExpressionAndGetReferencedName(Expression expr, out Func<string, string> inverseExpression)
        {
            switch (expr)
            {
                case Constant c:
                    inverseExpression = s => c.Value.ToString();
                    return null;
                case ParameterReference pr:
                    inverseExpression = s => $"{s}.Length";
                    return pr.ParameterName;
                case BinaryOperation bo:
                    // FIXME: We don't want to assume that the left expression contains the
                    // parameter name, but this is true for gl.xml 2020-12-30
                    string? reference = InvertExpressionAndGetReferencedName(bo.Left, out var leftExpr);
                    InvertExpressionAndGetReferencedName(bo.Right, out var rightExpr);
                    var invOp = BinaryOperation.Invert(bo.Operator);
                    inverseExpression = s => $"{leftExpr(s)} {BinaryOperation.GetOperationChar(invOp)} {rightExpr(s)}";
                    return reference;
                default:
                    inverseExpression = s => "";
                    return null;
            }
        }
    }

    public record Constant(int Value) : Expression;

    public record CompSize(Expression[] Parameters) : Expression;

    public enum BinaryOperator
    {
        Invalid,
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }

    public record BinaryOperation(
        Expression Left,
        BinaryOperator Operator,
        Expression Right) : Expression
    {
        public static BinaryOperator Invert(BinaryOperator @operator) => @operator switch
        {
            BinaryOperator.Addition => BinaryOperator.Subtraction,
            BinaryOperator.Subtraction => BinaryOperator.Addition,
            BinaryOperator.Multiplication => BinaryOperator.Division,
            BinaryOperator.Division => BinaryOperator.Multiplication,
            _ => throw new Exception("Invalid binary operator, we can't invert it."),
        };

        public static char GetOperationChar(BinaryOperator @operator) => @operator switch
        {
            BinaryOperator.Addition => '+',
            BinaryOperator.Subtraction => '-',
            BinaryOperator.Multiplication => '*',
            BinaryOperator.Division => '/',
            _ => throw new Exception("Invalid binary operator, there is no char associated."),
        };

        public bool TryDecomposeIntoParameterRefAndConstant([NotNullWhen(true)] out Constant? constant, [NotNullWhen(true)] out ParameterReference? reference)
        {
            if (Left is ParameterReference leftRef && Right is Constant rightConst)
            {
                reference = leftRef;
                constant = rightConst;
                return true;
            }
            else if (Right is ParameterReference rightRef && Left is Constant leftConst)
            {
                reference = rightRef;
                constant = leftConst;
                return true;
            }
            else
            {
                constant = default;
                reference = default;
                return false;
            }
        }
    }

    public record ParameterReference(string ParameterName) : Expression;



    public enum GLAPI
    {
        Invalid,
        None,
        GL,
        GLES1,
        GLES2,
        GLSC2,
        GLCore,

        WGL,
        GLX,
    }

    public enum GLProfile
    {
        Invalid,
        None,
        Core,
        Compatibility,
        Common,
    }


    public enum PrimitiveType
    {
        Invalid,

        Void,
        Byte,
        Sbyte,
        Short,
        Ushort,
        Int,
        Uint,
        Long,
        Ulong,
        Half,
        Float,
        Double,
        IntPtr,
        Nint,
        Enum,
        Bool8,
        Bool32,
        Char8,
        VoidPtr,


        GLHandleARB,
        GLSync,
        CLContext,
        CLEvent,
        GLDebugProc,
        GLDebugProcARB,
        GLDebugProcKHR,
        GLDebugProcAMD,
        GLDebugProcNV,
        GLVulkanProcNV,

        // WGL Types
        WGL_Proc,
        WGL_Rect,
        WGL_LPString,
        WGL_COLORREF,
        WGL_LAYERPLANEDESCRIPTOR,
        WGL_PIXELFORMATDESCRIPTOR,
        WGL_GPU_DEVICE,
        WGL_PGPU_DEVICE,

        // GLX Types
        GLX_Colormap,
        GLX_Display,
        GLX_Font,
        GLX_Pixmap,
        GLX_Screen,
        GLX_Status,
        GLX_Window,
        GLX_EXTFuncPtr,
        GLX_XVisualInfo,
        GLX_DMbuffer,
        GLX_DMparams,
        GLX_VLNode,
        GLX_VLPath,
        GLX_VLServer,
        GLX_FBConfigID,
        GLX_FBConfig,
        GLX_ContextID,
        GLX_Context,
        GLX_GLXPixmap,
        GLX_GLXDrawable,
        GLX_GLXWindow,
        GLX_GLXPbuffer,
        GLX_VideoCaptureDeviceNV,
        GLX_VideoDeviceNV,
        GLX_VideoSourceSGIX,
        GLX_FBConfigIDSGIX,
        GLX_FBConfigSGIX,
        GLX_GLXPbufferSGIX,
        GLX_GLXPbufferClobberEvent,
        GLX_GLXBufferSwapComplete,
        GLX_GLXEvent,
        GLX_GLXStereoNotifyEventEXT,
        GLX_GLXBufferClobberEventSGIX,
        GLX_GLXHyperpipeNetworkSGIX,
        GLX_GLXHyperpipeConfigSGIX,
        GLX_GLXPipeRect,
        GLX_GLXPipeRectLimits,

    }

    public enum HandleType
    {
        ProgramHandle,
        ProgramPipelineHandle,
        TextureHandle,
        BufferHandle,
        ShaderHandle,
        QueryHandle,
        FramebufferHandle,
        RenderbufferHandle,
        SamplerHandle,
        TransformFeedbackHandle,
        VertexArrayHandle,
        DisplayListHandle,
        PerfQueryHandle,
    }


    public enum EnumType
    {
        Invalid,
        None,
        Bitmask
    }

    /// <summary>
    /// "
    /// Legal C suffix for the value to force it to a specific type.
    /// Currently only \code{u} and \code{ull} are used,
    /// for \code{unsigned} 32 - and 64 - bit integer values, respectively.
    /// Separated from the \attr{value} field since this eases parsing and
    /// sorting of values, and is rarely used.
    /// "
    /// <br/>
    /// Taken from <see href="https://github.com/KhronosGroup/OpenGL-Registry/blob/0dc24166d162723781f1bf9fe433f71fa03a7aa0/xml/readme.tex#L383">KhronosGroup/OpenGL-Registry/xml/readme.tex#L383</see> 2020-11-22
    /// </summary>
    public enum TypeSuffix
    {
        Invalid,
        None,
        U,
        Ull,
    }
}
