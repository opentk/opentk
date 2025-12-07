using ALGenerator.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGenerator.Parsing
{
    internal record Documentation(
        Dictionary<string, EnumMemberDocumentation> EnumDocs,
        Dictionary<string, CommandDocumentation> CommandDocs
        );

    internal record VersionDocumentation(
        Dictionary<string, CommandDocumentation> Commands
        );

    internal record CommandDocumentation(
        string Name,
        string Purpose,
        ParameterDocumentation[] Parameters,
        Link? RefPagesLink);

    internal record Link(string Url, string? DisplayString = null);

    internal record ParameterDocumentation(
        string Name,
        string Description
        );

    internal record EnumMemberDocumentation(
        string Name,
        string? Comment,
        string? Comment2,
        PropertyInfo? PropertyInfo);

    internal record PropertyInfo(
        string[] PropertyOn,
        string? Type,
        string[]? Groups,
        PropertyRange? Range,
        string? Default
        );

    internal record PropertyRange(string Start, string? End, bool Inclusive)
    {
        public override string ToString()
        {
            return $"[{Start}, {End ?? "∞"}{(Inclusive ? "]" : ")")}";
        }
    }
}
