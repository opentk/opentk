using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System.CodeDom.Compiler;

namespace VkGenerator.Process
{
    public abstract record BaseCSType()
    {
        // We use a custom ToString here to allow ToString to be used for debugging,
        // also this way we make sure you have to override the custom ToString method.
        public abstract string ToCSString();
    }

    public interface IConstantCSType
    {
        public bool Constant { get; }
    }

    public interface IBaseTypeCSType
    {
        public BaseCSType BaseType { get; }

        public bool TakeAddressInFixedStatement { get; }

        public BaseCSType CreateWithNewType(BaseCSType type);
    }

    public record CSNotSupportedType : BaseCSType
    {
        public override string ToCSString()
        {
            throw new NotSupportedException();
        }
    }

    public record CSVoid(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => "void";
    }

    public record CSPrimitive(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        // FIXME: const??
        public static CSPrimitive Sbyte(bool @const) => new CSPrimitive("sbyte", @const);
        public static CSPrimitive Byte(bool @const) => new CSPrimitive("byte", @const);
        public static CSPrimitive Short(bool @const) => new CSPrimitive("short", @const);
        public static CSPrimitive Ushort(bool @const) => new CSPrimitive("ushort", @const);
        public static CSPrimitive Int(bool @const) => new CSPrimitive("int", @const);
        public static CSPrimitive Uint(bool @const) => new CSPrimitive("uint", @const);
        public static CSPrimitive Long(bool @const) => new CSPrimitive("long", @const);
        public static CSPrimitive Ulong(bool @const) => new CSPrimitive("ulong", @const);

        public static CSPrimitive Nint(bool @const) => new CSPrimitive("nint", @const);
        public static CSPrimitive Nuint(bool @const) => new CSPrimitive("nuint", @const);
        public static CSPrimitive IntPtr(bool @const) => new CSPrimitive("IntPtr", @const);

        public static CSPrimitive Half(bool @const) => new CSPrimitive("half", @const);
        public static CSPrimitive Float(bool @const) => new CSPrimitive("float", @const);
        public static CSPrimitive Double(bool @const) => new CSPrimitive("double", @const);

        public override string ToCSString()
        {
            return TypeName;
        }
    }

    public record CSEnum(string TypeName, CSPrimitive PrimitiveType, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return TypeName;
        }
    }

    public record CSStructPrimitive(string StructName, bool Constant, CSPrimitive UnderlyingType) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return StructName;
        }
    }

    public record CSStruct(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return TypeName;
        }
    }

    public record CSBool8(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return "bool";
        }
    }

    public record CSBool32(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return "int";
        }
    }

    public interface ICSCharType : IConstantCSType { }

    public record CSChar8(bool Constant) : BaseCSType, IConstantCSType, ICSCharType
    {
        public override string ToCSString()
        {
            return "byte";
        }
    }

    public record CSChar16(bool Constant) : BaseCSType, IConstantCSType, ICSCharType
    {
        public override string ToCSString()
        {
            return "char";
        }
    }

    public record CSString(bool Nullable) : BaseCSType
    {
        public override string ToCSString()
        {
            return $"string{(Nullable ? "?" : "")}";
        }
    }

    public record CSPointer(BaseCSType BaseType, bool Constant) : BaseCSType, IConstantCSType, IBaseTypeCSType
    {
        public bool TakeAddressInFixedStatement => false;

        public override string ToCSString()
        {
            return $"{BaseType.ToCSString()}*";
        }

        public BaseCSType CreateWithNewType(BaseCSType type)
        {
            return new CSPointer(type, false);
        }
    }

    public record CSRef(CSRef.Type RefType, BaseCSType ReferencedType) : BaseCSType, IBaseTypeCSType
    {
        public enum Type { Ref, Out, In }

        public BaseCSType BaseType => ReferencedType;

        public bool TakeAddressInFixedStatement => true;

        public override string ToCSString()
        {
            string modifier = RefType switch
            {
                Type.Ref => "ref",
                Type.Out => "out",
                Type.In => "in",
                _ => throw new Exception()
            };
            return $"{modifier} {ReferencedType.ToCSString()}";
        }

        public BaseCSType CreateWithNewType(BaseCSType type)
        {
            return new CSRef(RefType, type);
        }
    }

    public record CSArray(BaseCSType BaseType) : BaseCSType, IBaseTypeCSType
    {
        public bool TakeAddressInFixedStatement => false;

        public override string ToCSString()
        {
            return $"{BaseType.ToCSString()}[]";
        }

        public BaseCSType CreateWithNewType(BaseCSType type)
        {
            return new CSArray(type);
        }
    }

    public record CSSpan(BaseCSType BaseType, bool Readonly) : BaseCSType, IBaseTypeCSType
    {
        public bool TakeAddressInFixedStatement => false;

        public override string ToCSString()
        {
            if (Readonly)
            {
                return $"ReadOnlySpan<{BaseType.ToCSString()}>";
            }
            else
            {
                return $"Span<{BaseType.ToCSString()}>";
            }
        }

        public BaseCSType CreateWithNewType(BaseCSType type)
        {
            return new CSSpan(type, Readonly);
        }
    }

    public record CSFixedSizeArray(BaseCSType BaseType, ulong Size) : BaseCSType, IBaseTypeCSType
    {
        public bool TakeAddressInFixedStatement => throw new NotImplementedException();

        public override string ToCSString()
        {
            // FIXME!!
            return $"{BaseType.ToCSString()}[{Size}]";
        }

        public BaseCSType CreateWithNewType(BaseCSType type)
        {
            return new CSFixedSizeArray(type, Size);
        }
    }

    public record CSGenericType(string GenericTypeName) : BaseCSType
    {
        public override string ToCSString()
        {
            return GenericTypeName;
        }
    }

    public record CSFunctionPointer(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return "IntPtr";
        }
    }

    public record CSDelegateType(string TypeName) : BaseCSType
    {
        public override string ToCSString()
        {
            return TypeName;
        }
    }
}
