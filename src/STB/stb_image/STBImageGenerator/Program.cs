using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace STBImageGenerator
{

    public static class Program
    {

        private static readonly Dictionary<string, string> ReplaceQueries = new Dictionary<string, string>()
        {
            {"char const", "byte"},
            {"stbi_uc", "byte"},
            {"stbi_us", "short"},
            {"char", "byte"},
            {"const", ""},
            {"size_t", "UIntPtr"}
        };

        private static readonly Regex[] BlacklistQueries =
        {
            new Regex(".*_from_callbacks.*"),
            new Regex(".*_from_file.*"),
            new Regex(".*stbi_convert_wbyte_to_utf8.*")
        };

        private static readonly string[] BlacklistFunctions =
        {
            "stbi_convert_wbyte_to_utf8"
        };

        private static readonly string FunctionPreset = @"
        [DllImport(Lib, EntryPoint = ""{name}"", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern {type} {name}{parameters}
";

        static void Main(string[] args)
        {
            Regex selectRegex = new Regex("STBIDEF\\s*(\\w*)\\s*(\\w*)\\s*(.*)");

            string[] data = File.ReadAllLines("stb_image.h");

            string final = @"
using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace OpenTK.OpenAL
{
    internal static unsafe class STBImageLow
    {
        private const CallingConvention STBCallingConvention = CallingConvention.Cdecl;
        private const string Lib = """";
";

            List<string> loadedFunctions = new List<string>();

            foreach (var lineData in data)
            {
                bool blacklisted = false;
                foreach (var query in BlacklistQueries)
                {
                    if (query.Match(lineData).Success)
                    {
                        blacklisted = true;
                        break;
                    }
                }

                if(blacklisted)
                    continue;

                string line = lineData;
                foreach (var query in ReplaceQueries)
                {
                    line = line.Replace(query.Key, query.Value);
                }

                var match = selectRegex.Match(line);

                if (!match.Success)
                    continue;

                if(loadedFunctions.Contains(match.Groups[2].Value.Trim()))
                    continue;

                if (match.Groups[2].Value.Trim() == "")
                    continue;

                foreach (var function in BlacklistFunctions)
                {
                    if (match.Groups[2].Value.Trim() == function)
                    {
                        blacklisted = true;
                        break;
                    }
                }

                if(blacklisted)
                    continue;

                string def = FunctionPreset;

                loadedFunctions.Add(match.Groups[2].Value.Trim());

                def = def.Replace("{type}", match.Groups["1"].Value);
                def = def.Replace("{name}", match.Groups["2"].Value);
                def = def.Replace("{parameters}", match.Groups["3"].Value);
                final += def;

            }

            final += @"
    }
}
";

            Console.WriteLine(final);

        }
    }

}
