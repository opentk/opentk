using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GeneratorV2.Writing
{
    // FIXME: Switch to ToString and use [DebuggerDisplay] for nice debug strings
    public interface ICSType
    {
        public string ToCSString();
    }

    [DebuggerDisplay("{TypeName} (Constant = {Constant})")]
    public class CSType : ICSType
    {
        public readonly string TypeName;

        // FIXME: Think through this
        public readonly bool Constant;

        public CSType(string typeName, bool constant)
        {
            TypeName = typeName;
            Constant = constant;
        }

        public string ToCSString()
        {
            return TypeName;
        }
    }

    // FIXME: Split into CSChar8 and CSChar16
    public class CSChar : ICSType
    {
        public readonly bool IsByteSize;

        // FIXME: Think through this
        public readonly bool Constant;

        public CSChar(bool isByteSize, bool constant)
        {
            IsByteSize = isByteSize;
            Constant = constant;
        }

        public string ToCSString()
        {
            return IsByteSize ? "byte" : "char";
        }
    }

    // FIXME: This type should never really be visible here?
    // It should atleast never be written out...

    // FIXME: Remove this. What we do instead is when we make a ICSType out of
    // glPathGlyphIndexRangeNV we change the type into a pointer
    // and add a constant length expression to the parameter.
    public class CSFixedSizeArray : ICSType
    {
        public readonly ICSType BaseType;

        // FIXME: Think through size, see GLArrayType
        public readonly bool Constant;
        public readonly int Size;

        public CSFixedSizeArray(ICSType baseType, int size, bool constant)
        {
            BaseType = baseType;
            Size = size;
            Constant = constant;
        }

        public string ToCSString()
        {
            throw new Exception();
            // FIXME: Maybe do something with size or constant??
            return $"{BaseType.ToCSString()}[]";
        }
    }

    public class CSArray : ICSType
    {
        public readonly ICSType BaseType;

        // FIXME: Think through size, see GLArrayType
        public readonly bool Readonly;

        public CSArray(ICSType baseType, bool @readonly)
        {
            BaseType = baseType;
            Readonly = @readonly;
        }

        public string ToCSString()
        {
            // FIXME: Maybe do something with size or constant??
            return $"{BaseType.ToCSString()}[]";
        }
    }

    public class CSPointer : ICSType
    {
        public readonly ICSType BaseType;

        // FIXME: Think through this, see GLPointerType
        public readonly bool Constant;

        public CSPointer(ICSType baseType, bool constant)
        {
            BaseType = baseType;
            Constant = constant;
        }

        public string ToCSString()
        {
            // FIXME: Maybe do something with constant??
            return $"{BaseType.ToCSString()}*";
        }
    }

    public class CSVoid : ICSType
    {
        public CSVoid()
        { }

        public string ToCSString() => "void";
    }

    public class CSRef : ICSType
    {
        public enum Type { Ref, Out, In }
        public readonly Type RefType;
        public readonly ICSType ReferencedType;

        public CSRef(Type refType, ICSType referencedType)
        {
            RefType = refType;
            ReferencedType = referencedType;
        }

        public string ToCSString()
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
    }

    public class CSString : ICSType
    {
        public readonly bool Nullable;

        public CSString(bool nullable)
        {
            Nullable = nullable;
        }

        public string ToCSString()
        {
            return $"string{(Nullable ? "?" : "")}";
        }
    }

    public class CSSpan : ICSType
    {
        public readonly ICSType BaseType;
        public readonly bool Readonly;

        public CSSpan(ICSType baseType, bool @readonly)
        {
            BaseType = baseType;
            Readonly = @readonly;
        }

        public string ToCSString()
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
    }

    public class CSGenericType : ICSType
    {
        public readonly string GenericTypeName;

        public CSGenericType(string genericTypeName)
        {
            GenericTypeName = genericTypeName;
        }

        public string ToCSString()
        {
            return GenericTypeName;
        }
    }

    public class Parameter
    {
        public readonly ICSType Type;
        public readonly string Name;
        // FIXME: This is only used for overloading,
        // this is the parsed version of the length without processing.
        // We might want to do further processing on this before overloading, or move it.
        public readonly IExpression? Length;

        public Parameter(ICSType type, string name, IExpression? length)
        {
            Type = type;
            Name = name;
            Length = length;
        }

        public override string ToString()
        {
            return $"{Type.ToCSString()} {Name}{(Length != null ? " (has length)" : string.Empty)}";
        }
    }

    public class NativeFunction
    {
        // FIXME: Add string for the C# name of the function.
        public readonly string EntryPoint;
        public readonly List<Parameter> Parameters;
        // Possibly update this to use Type.
        public readonly ICSType ReturnType;

        public NativeFunction(string entryPoint, List<Parameter> parameters, ICSType returnType)
        {
            EntryPoint = entryPoint;
            Parameters = parameters;
            ReturnType = returnType;
        }
    }

    public interface IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads);
    }

    // FIXME: We could maybe move this into the Overload class
    // and make the overloads inherit from this Overload.
    // Might be a cleaner solution, and stuff like that.
    public interface IOverloadLayer
    {
        public void WritePrologue(IndentedTextWriter writer);
        public string? WriteEpilogue(IndentedTextWriter writer, string? returnName);
    }

    public class Overload
    {
        public readonly Overload? NestedOverload;
        public readonly IOverloadLayer? MarshalLayerToNested;

        public readonly Parameter[] InputParameters;
        public readonly NativeFunction NativeFunction;
        public readonly ICSType ReturnType;

        public readonly string[] GenericTypes;

        public Overload(Overload? nestedOverload, IOverloadLayer? marshalLayerToNested, Parameter[] inputParameters, NativeFunction nativeFunction, ICSType returnType, string[] genericTypes)
        {
            NestedOverload = nestedOverload;
            MarshalLayerToNested = marshalLayerToNested;
            InputParameters = inputParameters;
            NativeFunction = nativeFunction;
            ReturnType = returnType;
            GenericTypes = genericTypes;
        }
    }

    // FIXME: Better name
    public class EnumMemberData : IEquatable<EnumMemberData?>
    {
        // FIXME: This is the c name still
        public readonly string Name;
        public readonly ulong Value;
        public readonly string[]? Groups;
        public readonly bool IsFlag;

        public EnumMemberData(string name, ulong value, string[]? groups, bool isFlag)
        {
            Name = name;
            Value = value;
            Groups = groups;
            IsFlag = isFlag;
        }

        // It is important to have an equals and hashcode because
        // this type will be used in a lot of hash tables

        public override bool Equals(object? obj)
        {
            return Equals(obj as EnumMemberData);
        }

        public bool Equals(EnumMemberData? other)
        {
            return other != null &&
                   Name == other.Name &&
                   Value == other.Value &&
                   EqualityComparer<string[]?>.Default.Equals(Groups, other.Groups) &&
                   IsFlag == other.IsFlag;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Value, Groups, IsFlag);
        }

        public static bool operator ==(EnumMemberData? left, EnumMemberData? right)
        {
            return EqualityComparer<EnumMemberData>.Default.Equals(left, right);
        }

        public static bool operator !=(EnumMemberData? left, EnumMemberData? right)
        {
            return !(left == right);
        }
    }

    // FIXME: Better name
    public class EnumGroupData
    {
        public readonly string Name;
        public readonly bool IsFlags;

        public EnumGroupData(string name, bool isFlags)
        {
            Name = name;
            IsFlags = isFlags;
        }
    }

    public class EnumGroup
    {
        public readonly string Name;
        public readonly bool IsFlags;
        public readonly List<EnumMemberData> Members;

        public EnumGroup(string name, bool isFlags, List<EnumMemberData> members)
        {
            Name = name;
            IsFlags = isFlags;
            Members = members;
        }
    }

    public class GLVersionOutput
    {
        // FIXME: Make this into GLAPI + Version
        public readonly string Version;
        public readonly List<NativeFunction> Functions;
        public readonly List<Overload> Overloads;
        public readonly List<EnumMemberData> AllEnums;
        public readonly List<EnumGroup> EnumGroups;

        public GLVersionOutput(string version, List<NativeFunction> functions, List<Overload> overloads, List<EnumMemberData> allEnums, List<EnumGroup> enumGroups)
        {
            Version = version;
            Functions = functions;
            Overloads = overloads;
            AllEnums = allEnums;
            EnumGroups = enumGroups;
        }
    }

    public class OutputData
    {
        public readonly List<GLVersionOutput> Versions;

        public OutputData(List<GLVersionOutput> versions)
        {
            Versions = versions;
        }
    }
}
