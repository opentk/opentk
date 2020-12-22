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

    class EnumMember
    {
        public readonly string Name;
        public readonly ulong Value;

        public EnumMember(string name, ulong value)
        {
            Name = name;
            Value = value;
        }
    }

    class EnumGroup
    {
        public readonly string Name;
        public readonly List<EnumMember> Members;
        public bool Flags;

        public EnumGroup(string name, List<EnumMember> members, bool flags)
        {
            Name = name;
            Members = members;
            Flags = flags;
        }
    }

    class GLVersionOutput
    {
        public readonly string Version;
        public readonly List<NativeFunction> Functions;
        public readonly List<EnumGroup> EnumGroups;

        public GLVersionOutput(string version, List<NativeFunction> functions, List<EnumGroup> enumGroups)
        {
            Version = version;
            Functions = functions;
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
