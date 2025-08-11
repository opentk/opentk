using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorBase
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

    public interface IBitwidthCSType
    {
        public int? BitWidth { get; }
    }

    public record CSNotSupportedType(string UnsupportedType) : BaseCSType
    {
        public override string ToCSString()
        {
            throw new NotSupportedException($"Type '{UnsupportedType}' not supported.");
        }
    }

    public record CSVoid(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => "void";
    }

    public record CSPrimitive(string TypeName, bool Constant, int? BitWidth) : BaseCSType, IConstantCSType, IBitwidthCSType
    {
        // FIXME: const??
        public static CSPrimitive Sbyte(bool @const) => new CSPrimitive("sbyte", @const, 8);
        public static CSPrimitive Byte(bool @const) => new CSPrimitive("byte", @const, 8);
        public static CSPrimitive Short(bool @const) => new CSPrimitive("short", @const, 16);
        public static CSPrimitive Ushort(bool @const) => new CSPrimitive("ushort", @const, 16);
        public static CSPrimitive Int(bool @const) => new CSPrimitive("int", @const, 32);
        public static CSPrimitive Uint(bool @const) => new CSPrimitive("uint", @const, 32);
        public static CSPrimitive Long(bool @const) => new CSPrimitive("long", @const, 64);
        public static CSPrimitive Ulong(bool @const) => new CSPrimitive("ulong", @const, 64);

        public static CSPrimitive Nint(bool @const) => new CSPrimitive("nint", @const, null);
        public static CSPrimitive Nuint(bool @const) => new CSPrimitive("nuint", @const, null);
        public static CSPrimitive IntPtr(bool @const) => new CSPrimitive("IntPtr", @const, null);

        public static CSPrimitive Half(bool @const) => new CSPrimitive("Half", @const, null);
        public static CSPrimitive Float(bool @const) => new CSPrimitive("float", @const, null);
        public static CSPrimitive Double(bool @const) => new CSPrimitive("double", @const, null);

        public override string ToCSString()
        {
            return TypeName;
        }
    }

    public record CSEnum(string TypeName, CSPrimitive PrimitiveType, bool Constant) : BaseCSType, IConstantCSType, IBitwidthCSType
    {
        int? IBitwidthCSType.BitWidth => (PrimitiveType as IBitwidthCSType)?.BitWidth;

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

    // This struct type is used publicly to mark that this struct is opaque and needs to be converted to
    // a pointer variant before it can be used.
    // - Noggin_bops 2024-03-07
    public record CSOpaqueStruct(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            throw new InvalidOperationException($"Opaque type '{TypeName}' should never be used directly");
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

    public record CSPointer(BaseCSType BaseType, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return $"{BaseType.ToCSString()}*";
        }
    }

    public record CSRef(CSRef.Type RefType, BaseCSType ReferencedType) : BaseCSType, IBaseTypeCSType
    {
        public enum Type { Ref, Out, RefReadonly }

        public BaseCSType BaseType => ReferencedType;

        public bool TakeAddressInFixedStatement => true;

        public override string ToCSString()
        {
            string modifier = RefType switch
            {
                Type.Ref => "ref",
                Type.Out => "out",
                Type.RefReadonly => "ref readonly",
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

    public record CSFunctionPointer(string TypeName, bool Constant, BaseCSType ReturnType, List<BaseCSType> ParameterTypes) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            StringBuilder types = new StringBuilder();
            for (int i = 0; i < ParameterTypes.Count; i++)
            {
                types.Append(ParameterTypes[i].ToCSString());
                types.Append(", ");
            }
            types.Append(ReturnType.ToCSString());
            return $"delegate* unmanaged[Cdecl]<{types}>";
        }
    }

    public record CSOpaqueFunctionPointer(string TypeName, bool Constant) : BaseCSType, IConstantCSType
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

    public record CSBitfield(BaseCSType UnderlyingType, int BitWidth) : BaseCSType, IBitwidthCSType
    {
        int? IBitwidthCSType.BitWidth => BitWidth;

        public override string ToCSString()
        {
            return $"{UnderlyingType.ToCSString()}:{BitWidth}";
        }
    }
}
