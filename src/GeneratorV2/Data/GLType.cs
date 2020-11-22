using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
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
        VoidPtr,

        Enum,

        GLHandleARB,

        //The following have a custom c# implementation in the writer.
        GLSync,
        CLContext,
        CLEvent,
        GLDEBUGPROC,
        GLDEBUGPROCARB,
        GLDEBUGPROCKHR,
        GLDEBUGPROCAMD,
        GLDEBUGPROCNV,
    }

    public abstract class GLType
    {
    }

    public class GLBaseType : GLType
    {
        public readonly string OrignalString;
        public readonly PrimitiveType Type;
        public readonly bool Const;

        public GLBaseType(string orignalString, PrimitiveType type, bool @const)
        {
            OrignalString = orignalString;
            Type = type;
            Const = @const;
        }
    }

    public class GLPointerType : GLType
    {
        public readonly GLType BaseType;
        public readonly bool Const;

        public GLPointerType(GLType baseType, bool @const)
        {
            BaseType = baseType;
            Const = @const;
        }
    }

    public class GLArrayType : GLPointerType
    {
        public readonly int Length;

        public GLArrayType(GLType baseType, bool @const, int length) : base(baseType, @const)
        {
            Length = length;
        }
    }
}
