using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorV2.Writing2
{
    // FIXME...?
    interface ICSType
    {
        public string ToCSString();
    }

    class CSType : ICSType
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

    class CSArray : ICSType
    {
        public readonly ICSType BaseType;

        // FIXME: Think through size, see GLArrayType
        public readonly bool Constant;
        public readonly int Size;

        public CSArray(ICSType baseType, int size, bool constant)
        {
            BaseType = baseType;
            Size = size;
            Constant = constant;
        }

        public string ToCSString()
        {
            // FIXME: Maybe do something with size or constant??
            return $"{BaseType.ToCSString()}[]";
        }
    }

    class CSPointer : ICSType
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

    class CSVoid :ICSType
    {
        public CSVoid()
        { }

        public string ToCSString() => "void";
    }

    class NativeParameter
    {
        public readonly ICSType Type;
        public readonly string Name;

        public NativeParameter(ICSType type, string name)
        {
            Type = type;
            Name = name;
        }
    }

    class NativeFunction
    {
        public readonly string EntryPoint;
        public readonly List<NativeParameter> Parameters;
        public readonly ICSType ReturnType;

        public NativeFunction(string entryPoint, List<NativeParameter> parameters, ICSType returnType)
        {
            EntryPoint = entryPoint;
            Parameters = parameters;
            ReturnType = returnType;
        }
    }

    // FIXME: Better name
    class EnumMemberData : IEquatable<EnumMemberData?>
    {
        // This is the c name still
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
    class EnumGroupData
    {
        public readonly string Name;
        public readonly bool IsFlags;

        public EnumGroupData(string name, bool isFlags)
        {
            Name = name;
            IsFlags = isFlags;
        }
    }

    class EnumGroup
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

    class GLVersionOutput
    {
        public readonly string Version;
        public readonly List<NativeFunction> Functions;
        public readonly List<EnumMemberData> AllEnums;
        public readonly List<EnumGroup> EnumGroups;

        public GLVersionOutput(string version, List<NativeFunction> functions, List<EnumMemberData> allEnums, List<EnumGroup> enumGroups)
        {
            Version = version;
            Functions = functions;
            AllEnums = allEnums;
            EnumGroups = enumGroups;
        }
    }

    class OutputData
    {
        public readonly List<GLVersionOutput> Versions;

        public OutputData(List<GLVersionOutput> versions)
        {
            Versions = versions;
        }
    }
}
