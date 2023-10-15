using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    internal class GeneratorSettings
    {
        public static GeneratorSettings Settings;

        public string ExtensionPrefix { get; init; }
        public string FunctionPrefix { get; init; }
        public List<string> EnumPrefixes { get; init; }
        public HashSet<string> FunctionsWithoutPrefix { get; init; }
        public HashSet<string> EnumsWithoutPrefix { get; init; }

        public List<string> IgnoreFunctions { get; init; }

        public GeneratorSettings()
        {
            ExtensionPrefix = "GL_";
            FunctionPrefix = "gl";
            EnumPrefixes = new List<string> { "GL_" };
            FunctionsWithoutPrefix = new HashSet<string>();
            EnumsWithoutPrefix = new HashSet<string>();
            IgnoreFunctions = new List<string>();
        }
    }
}
