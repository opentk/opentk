using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text;

namespace XrGenerator.Utility
{
    public class NameManglerSettings
    {
        public string ExtensionPrefix { get; init; }
        public string FunctionPrefix { get; init; }
        public List<string> EnumPrefixes { get; init; }
        public HashSet<string> FunctionsWithoutPrefix { get; init; }
        public HashSet<string> EnumsWithoutPrefix { get; init; }

        public NameManglerSettings()
        {
            ExtensionPrefix = "XR_";
            FunctionPrefix = "xr";
            EnumPrefixes = new List<string> { "XR_" };
            FunctionsWithoutPrefix = new HashSet<string>();
            EnumsWithoutPrefix = new HashSet<string>();
        }
    }

    public static class NameMangler
    {
        public static NameManglerSettings Settings = new NameManglerSettings();

        [return: NotNullIfNotNull(nameof(str))]
        public static string? MaybeRemoveStart(string? str, string start)
        {
            if (str == null)
                return str;

            if (!str.StartsWith(start))
                return str;

            return str[start.Length..];
        }

        public static string RemoveStart(string str, string start)
        {
            if (!str.StartsWith(start))
                throw new System.Exception($"'{str}' dosen't start with '{start}'");

            return str[start.Length..];
        }

        public static string RemoveEnd(string str, string end)
        {
            if (!str.EndsWith(end))
                throw new System.Exception($"'{str}' dosen't end with '{end}'");

            return str[0..^end.Length];
        }

        public static string RemoveFunctionPrefix(string function)
        {
            // FIXME: Get the settings from a more direct source
            if (Settings.FunctionsWithoutPrefix.Contains(function))
                return function;

            string prefix = Settings.FunctionPrefix;

            if (!function.StartsWith(prefix))
                throw new System.Exception($"'{function}' dosen't start with '{prefix}'");

            return function[prefix.Length..];
        }

        public static string RemoveEnumPrefix(string @enum)
        {
            // FIXME: Get the settings from a more direct source
            if (Settings.EnumsWithoutPrefix.Contains(@enum))
                return @enum;

            foreach (var prefix in Settings.EnumPrefixes)
            {
                if (@enum.StartsWith(prefix))
                {
                    return @enum[prefix.Length..];
                }
            }

            throw new System.Exception($"'{@enum}' dosen't start with any of the valid prefixes '{string.Join(", ", Settings.EnumPrefixes)}'");
        }

        public static string RemoveExtensionPrefix(string extension)
        {
            // FIXME: Get the settings from a more direct source
            string prefix = Settings.ExtensionPrefix;

            if (!extension.StartsWith(prefix))
                throw new System.Exception($"'{extension}' dosen't start with '{prefix}'");

            return extension[prefix.Length..];
        }

        public static string MangleConstantName(string name)
        {
            var mangledName = RemoveEnumPrefix(name);
            return MangleCapsUnderscoreName(mangledName);
        }

        public static string MangleFunctionName(string name)
        {
            // Remove the "gl" prefix.
            return RemoveFunctionPrefix(name);
        }

        public static string MangleEnumName(string name)
        {
            var mangledName = RemoveEnumPrefix(name);
            return MangleCapsUnderscoreName(mangledName);
        }

        public static string MangleMemberName(string name) => name switch
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
            return MangleCapsUnderscoreName(name);
        }

        public static string MangleExtensionName(string name)
        {
            return MangleCapsUnderscoreName(name);
        }

        private static string MangleCapsUnderscoreName(string name)
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

        // Documentation functions

        private static readonly char[] NewlineAndTabCharacters = new[] { '\r', '\n', '\t' };

        public static string MangleCommandPurpose(string purpose)
        {
            purpose = TrimAndRemoveChars(purpose, NewlineAndTabCharacters);
            purpose = XmlEscapeCharacters(purpose);
            return CapitalizeFirst(purpose) + ".";
        }

        public static string MangleParameterDescription(string description)
        {
            description = TrimAndRemoveChars(description, NewlineAndTabCharacters);
            description = XmlEscapeCharacters(description);
            return RemoveRepeatedSpaces(description);
        }

        private static string RemoveRepeatedSpaces(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != ' ' || str[i + 1] != ' ')
                {
                    builder.Append(str[i]);
                }
            }
            builder.Append(str[^1]);
            return builder.ToString();
        }

        private static string CapitalizeFirst(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            return char.ToUpper(str[0]).ToString() + str[1..];
        }

        private static string TrimAndRemoveChars(string str, params char[] characters)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char strChar in str)
            {
                bool match = false;
                for (int i = 0; i < characters.Length; i++)
                {
                    if (characters[i] == strChar)
                    {
                        match = true;
                        break;
                    }
                }

                if (match == false)
                {
                    builder.Append(strChar);
                }
            }
            return builder.ToString();
        }

        /// <summary>
        /// Escapes all "'&lt;&gt;&amp; characters.
        /// This extension will not detect already escaped strings.
        /// </summary>
        public static string XmlEscapeCharacters(string? str)
        {
            StringBuilder sb = new StringBuilder(str);

            // We don't want to replace all of the & we are going to add
            // so replace that first
            // - Noggin_bops 2023-01-26
            sb.Replace("&", "&amp;");

            sb.Replace("\"", "&quot;");
            sb.Replace("'", "&apos;");
            sb.Replace("<", "&lt;");
            sb.Replace(">", "&gt;");

            return sb.ToString();
        }
    }
}
