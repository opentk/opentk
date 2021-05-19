using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using GeneratorV2.Writing;

namespace GeneratorV2.Process.Overloaders
{
    public class TrimNameOverloader : IOverloader
    {
        private static readonly Regex Endings = new Regex(
            @"([fd]v?|u?[isb](64)?v?|v|i_v|fi)$",
            RegexOptions.Compiled);

        private static readonly Regex EndingsNotToTrim = new Regex(
            "(sh|ib|[tdrey]s|[eE]n[vd]|bled" +
            "|Attrib|Access|Boolean|Coord|Depth|Feedbacks|Finish|Flag" +
            "|Groups|IDs|Indexed|Instanced|Pixels|Queries|Status|Tess|Through" +
            "|Uniforms|Varyings|Weight|Width)$",
            RegexOptions.Compiled);

        private static readonly Regex EndingsAddV = new Regex("^0", RegexOptions.Compiled);

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            // See: https://github.com/opentk/opentk/blob/082c8d228d0def042b11424ac002776432f44f47/src/Generator.Bind/FuncProcessor.cs#L417

            string name = overload.OverloadName;
            string trimmedName = name;
            // FIXME: Remove extension name before we trim endings
            Match m = EndingsNotToTrim.Match(name);
            if ((m.Index + m.Length) != name.Length)
            {
                m = Endings.Match(name);

                if (m.Length > 0 && m.Index + m.Length == name.Length)
                {
                    // Only trim endings, not internal matches.
                    if (m.Value[m.Length - 1] == 'v' && EndingsAddV.IsMatch(name) &&
                        !name.StartsWith("Get") && !name.StartsWith("MatrixIndex"))
                    {
                        // Only trim ending 'v' when there is a number
                        trimmedName = name.Substring(0, m.Index) + "v";
                    }
                    else
                    {
                        if (!name.EndsWith("xedv"))
                        {
                            trimmedName = name.Substring(0, m.Index);
                        }
                        else
                        {
                            trimmedName = name.Substring(0, m.Index + 1);
                        }
                    }
                }
            }

            if (trimmedName != name)
            {
                newOverloads = new List<Overload>() {overload with {OverloadName = trimmedName}};
                return true;
            }
            else
            {
                newOverloads = default;
                return false;
            }
        }
    }
}
