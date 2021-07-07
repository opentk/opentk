using System.Text;

namespace Generator.Utility
{
    public class NameMangler
    {
        public static string RemoveStart(string str, string start)
        {
            if (!str.StartsWith(start))
                throw new System.Exception($"'{str}' dosen't start with '{start}'");

            return str[start.Length..];
        }

        public static string MangleFunctionName(string name)
        {
            // Remove the "gl" prefix.
            return RemoveStart(name, "gl");
        }

        public static string MangleEnumName(string name)
        {
            // Remove the "GL_" prefix.
            var mangledName = RemoveStart(name, "GL_");
            return MangleMemberName(mangledName);
        }

        public static string MangleParameterName(string name) => name switch
        {
            "base" => "@base",
            "event" => "@event",
            "in" => "input",
            "object" => "obj",
            "params" => "parameters",
            "ref" => "reference",
            "string" => "str",
            _ => name
        };

        public static string MangleClassName(string name)
        {
            return MangleMemberName(name);
        }

        public static string MangleExtensionName(string name)
        {
            return MangleMemberName(name);
        }

        private static string MangleMemberName(string name)
        {
            var stringBuilder = new StringBuilder(name.Length);
            var nextUpper = true;
            if (char.IsDigit(name[0]))
            {
                stringBuilder.Append('_');
            }
            for (var i = 0; i < name.Length; i++)
            {
                var c = name[i];
                if (c == '_')
                {
                    nextUpper = true;
                }
                else
                {
                    stringBuilder.Append(nextUpper ? char.ToUpper(c) : char.ToLower(c));
                    nextUpper = false;
                }
            }
            return stringBuilder.ToString();
        }
    }
}
