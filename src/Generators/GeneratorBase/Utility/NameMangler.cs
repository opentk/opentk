using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System;
using System.Buffers;

namespace GeneratorBase.Utility
{
    public class NameManglerSettings
    {
        public List<string> ExtensionPrefixes { get; init; }
        public HashSet<string> ExtensionsWithoutPrefixes { get; init; }
        public string FunctionPrefix { get; init; }
        public List<string> EnumPrefixes { get; init; }
        public HashSet<string> FunctionsWithoutPrefix { get; init; }
        public HashSet<string> EnumsWithoutPrefix { get; init; }
        public string DefinePrefix { get; init; }

        public Dictionary<string, string> EnumGroupNameTranslationTable { get; init; }

        public List<string> EnumAcronymsToKeepCapitalization { get; init; }

        public NameManglerSettings()
        {
            ExtensionPrefixes = ["GL_"];
            ExtensionsWithoutPrefixes = [];
            FunctionPrefix = "gl";
            EnumPrefixes = new List<string> { "GL_" };
            FunctionsWithoutPrefix = new HashSet<string>();
            EnumsWithoutPrefix = new HashSet<string>();
            EnumGroupNameTranslationTable = new Dictionary<string, string>();
            DefinePrefix = "";
        }
    }

    // FIXME: Make this not a static class with static settings. Make this an object you have to pass around.
    // This will make this much less error prone.
    public class NameMangler
    {
        public NameManglerSettings Settings = new NameManglerSettings();

        // FIXME: This is OpenGL/OpenAL/etc specific so it needs to be configurable...
        private static readonly List<string> VendorNames = new List<string>
        {
            "AAX",
            "EXT",
            "LOKI",
            "SOFT",
        };

        public NameMangler(NameManglerSettings settings)
        {
            Settings = settings;
        }

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

        public string RemoveEnumPrefix(string @enum)
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

            throw new Exception($"'{@enum}' dosen't start with any of the valid prefixes '{string.Join(", ", Settings.EnumPrefixes)}'");
        }

        public string RemoveExtensionPrefix(string extension)
        {
            if (Settings.ExtensionsWithoutPrefixes.Contains(extension))
            {
                return extension;
            }

            // FIXME: Get the settings from a more direct source
            foreach (var prefix in Settings.ExtensionPrefixes)
            {
                if (extension.StartsWith(prefix))
                {
                    return extension[prefix.Length..];
                }
            }

            throw new Exception($"'{extension}' dosen't start with any of the valid prefixes '{string.Join(", ", Settings.ExtensionPrefixes)}'");
        }

        public static string RemoveVendorPostfix(string str)
        {
            foreach (var vendor in VendorNames)
            {
                // This check only works if no vendors are has and ending substring the same as some other vendor
                // e.g. the potential vendor "XWIN" would together with "WIN" break this algorithm.
                // This doesn't happen atm.
                // - Noggin_bops 2023-01-25
                if (str.EndsWith(vendor))
                {
                    return RemoveEnd(str, vendor);
                }
            }

            return str;
        }

        public static string GetVendorPostfix(string str)
        {
            foreach (var vendor in VendorNames)
            {
                if (str.EndsWith(vendor))
                {
                    return vendor;
                }
            }
            return "";
        }

        public string TranslateEnumGroupName(string name)
        {
            if (Settings.EnumGroupNameTranslationTable.TryGetValue(name, out string? translated))
            {
                return translated;
            }

            return name;
        }

        public static string EscapeKeywords(string name) => name switch
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

        // Mangle functions

        public string MangleFunctionName(string functionName)
        {
            // FIXME: Get the settings from a more direct source
            if (Settings.FunctionsWithoutPrefix.Contains(functionName))
                return functionName;

            string prefix = Settings.FunctionPrefix;

            if (!functionName.StartsWith(prefix))
                throw new Exception($"'{functionName}' dosen't start with '{prefix}'");

            return functionName[prefix.Length..];
        }

        public string MangleDefineName(string name)
        {
            var mangledName = MaybeRemoveStart(name, Settings.DefinePrefix);
            // For now we leave it capitalized.
            // - Noggin_bops 2025-07-06
            return mangledName;
        }

        public string MangleConstantName(string name)
        {
            var mangledName = RemoveEnumPrefix(name);
            return MangleCapsUnderscoreName(mangledName);
        }

        public string MangleEnumName(string name)
        {
            // Remove the "GL_" prefix.
            var mangledName = RemoveEnumPrefix(name);
            return MangleCapsUnderscoreName(mangledName);
        }

        public static string MangleParameterName(string name) => EscapeKeywords(name);

        public string MangleClassName(string name)
        {
            return MangleCapsUnderscoreName(name);
        }

        public string MangleExtensionName(string name)
        {
            return MangleCapsUnderscoreName(name);
        }

        // FIXME: Add support for keeping abbreviations capitalized.
        private string MangleCapsUnderscoreName(string name)
        {
            var stringBuilder = new StringBuilder(name.Length);
            var nextUpper = true;
            if (char.IsDigit(name[0]))
            {
                stringBuilder.Append('_');
            }
            for (var i = 0; i < name.Length; i++)
            {
                bool appliedAcronym = false;
                for (int a = 0; a < Settings.EnumAcronymsToKeepCapitalization?.Count; a++)
                {
                    string acronym = Settings.EnumAcronymsToKeepCapitalization[a];
                    if (name.IndexOf(acronym, i, Math.Min(acronym.Length, name.Length - i), StringComparison.InvariantCultureIgnoreCase) == i)
                    {
                        stringBuilder.Append(acronym);
                        i += acronym.Length - 1;
                        appliedAcronym = true;
                        break;
                    }
                }
                if (appliedAcronym)
                    continue;

                char c = name[i];
                if (c == '_')
                {
                    nextUpper = true;
                }
                else
                {
                    stringBuilder.Append(nextUpper ? char.ToUpperInvariant(c) : char.ToLowerInvariant(c));
                    nextUpper = false;
                }
            }
            return stringBuilder.ToString();
        }

        public string MangleStructMemberName(string name) => EscapeKeywords(name);

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
