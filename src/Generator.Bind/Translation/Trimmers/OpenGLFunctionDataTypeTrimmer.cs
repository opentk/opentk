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

            // Note: some endings should not be trimmed, for example: 'b' from Attrib.
            // Check the endingsNotToTrim regex for details.
            if (EndingsNotToTrim.IsMatch(trimmable.Name))
            {
                return false;
            }

            if (!Endings.IsMatch(trimmable.Name))
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc/>
        public FunctionSignature Trim(FunctionSignature trimmable)
        {
            var name = trimmable.Name;

            var match = Endings.Match(name);

            // Workaround for names ending with "Indexedv"
            if (!name.EndsWith("xedv"))
            {
                name = name.Remove(match.Index);
            }
            else
            {
                name = name.Remove(match.Index + 1);
            }

            using (var wr = new StreamWriter("/home/jarl/test.txt", true))
            {
                wr.WriteLine(name);
            }

            return trimmable;
            // throw new NotImplementedException();
        }
    }
}
