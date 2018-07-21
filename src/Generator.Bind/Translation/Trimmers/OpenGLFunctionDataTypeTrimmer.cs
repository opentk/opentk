using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Trimmers
{
    /// <summary>
    /// Trims OpenGL data type endings from function names.
    /// </summary>
    public class OpenGLFunctionDataTypeTrimmer : ITrimmer<FunctionSignature>
    {
        private static readonly Regex Endings = new Regex(
            @"([fd]v?|u?[isb](64)?v?|v|i_v|fi)$",
            RegexOptions.Compiled);

        private static readonly Regex EndingsNotToTrim = new Regex(
            "(sh|ib|[tdrey]s|[eE]n[vd]|bled" +
            "|Attrib|Access|Boolean|Coord|Depth|Feedbacks|Finish|Flag" +
            "|Groups|IDs|Indexed|Instanced|Pixels|Queries|Status|Tess|Through" +
            "|Uniforms|Varyings|Weight|Width|Bias|Id)$",
            RegexOptions.Compiled);

        private static readonly Regex EndingsAddV = new Regex("^0", RegexOptions.Compiled);

        /// <inheritdoc/>
        public bool IsRelevant(FunctionSignature trimmable)
        {
            if (!trimmable.Parameters.Any())
            {
                return false;
            }

            var hasVectorParameter = trimmable.Parameters.Any(p => p.Type.Name.Contains('*'));
            var hasIndexedVectorParameterPair = trimmable.Parameters.Any(p => p.Name == "index") && hasVectorParameter;

            if (hasIndexedVectorParameterPair)
            {
                return true;
            }

            return true;
        }

        /// <inheritdoc/>
        public FunctionSignature Trim(FunctionSignature trimmable)
        {
            var trimmedName = trimmable.Name;

            // Note: some endings should not be trimmed, for example: 'b' from Attrib.
            // Check the endingsNotToTrim regex for details.
            if (EndingsNotToTrim.IsMatch(trimmedName))
            {
                return trimmable;
            }

            var match = Endings.Match(trimmedName);
            if (!match.Success)
            {
                return trimmable;
            }

            // Only trim endings, not internal matches.
            if (match.Value[match.Length - 1] == 'v' && EndingsAddV.IsMatch(trimmedName) &&
                !trimmedName.StartsWith("Get") && !trimmedName.StartsWith("MatrixIndex"))
            {
                // Only trim ending 'v' when there is a number
                trimmedName = trimmedName.Substring(0, match.Index) + "v";
            }
            else
            {
                // Workaround for names ending with "Indexedv"
                if (!trimmedName.EndsWith("xedv"))
                {
                    trimmedName = trimmedName.Substring(0, match.Index);
                }
                else
                {
                    trimmedName = trimmedName.Substring(0, match.Index + 1);
                }
            }

            using (var wr = new StreamWriter("/home/jarl/test.txt", true))
            {
                wr.WriteLine(trimmedName);
            }

            return trimmable;
            // throw new NotImplementedException();
        }
    }
}
