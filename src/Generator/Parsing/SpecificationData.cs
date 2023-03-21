using Generator.Writing;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.IO.Compression;

namespace Generator.Parsing
{
    public record Specification(
        List<Command> Commands,
        List<Enums> Enums,
        List<Feature> Features,
        List<Extension> Extensions);


    public record Command(
        string EntryPoint,
        PType ReturnType,
        GLParameter[] Parameters);


    public record Enums(
        string Namespace,
        string[] Groups,
        EnumType Type,
        string? Vendor,
        Range? Range,
        string? Comment,
        List<EnumEntry> Entries);

    public record EnumEntry(
        string Name,
        GLAPI Api,
        ulong Value,
        string? Alias,
        string? Comment,
        string[] Groups,
        TypeSuffix Type);


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


    public record GLParameter(
        PType Type,
        string[] Kinds,
        string Name,
        Expression? Length);

    public record PType(
        GLType Type,
        HandleType? Handle,
        string? Group);


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
