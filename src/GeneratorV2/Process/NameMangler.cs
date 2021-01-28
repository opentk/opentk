using System.Text;


#nullable enable
namespace GeneratorV2.Parsing
{
    public class NameMangler
    {
        public static string MangleFunctionName(string name)
        {
            // Remove the "gl" prefix.
            return name[2..];
        }

        public static string MangleEnumName(string name)
        {
            // Remove the "GL_" prefix.
            return MangleMemberName(name[3..]);
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
