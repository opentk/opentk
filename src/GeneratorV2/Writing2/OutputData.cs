using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorV2.Writing2
{
    class CSType
    {
        // FIXME!!!!!
        public string Type;

        public CSType(string type)
        {
            Type = type;
        }
    }

    class NativeParameter
    {
        public readonly CSType Type;
        public readonly string Name;

        public NativeParameter(CSType type, string name)
        {
            Type = type;
            Name = name;
        }
    }

    class NativeFunction
    {
        public readonly string Name;
        public readonly List<NativeParameter> Parameters;
        public readonly CSType ReturnType;

        public NativeFunction(string name, List<NativeParameter> parameters, CSType returnType)
        {
            Name = name;
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
