using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace GeneratorBase
{
    public record Link(string Url, string? DisplayString = null)
    {
        public string ToSeeXmlTag()
        {
            if (DisplayString != null)
            {
                return $"<see href=\"{Url}\">{DisplayString}</see>";
            }
            else
            {
                return $"<see href=\"{Url}\"/>";
            }
        }
    }

    public interface IDocumentation
    {
        Dictionary<Function, FunctionDocumentation> CreateFunctionDocumentation(OutputApi api, List<VendorFunctions> functions);
        Dictionary<string, EnumMemberDocumentation> CreateEnumMemberDocumentation(OutputApi api, List<EnumMember> enums);
    }

    public record class FunctionDocumentation
    {
        public required string FunctionName { get; init; }
        public required string Purpose { get; init; }
        public required ParameterDocumentation[] Parameters { get; init; }
        public required List<Link> RefPagesLinks { get; init; }
        public required VersionInfo VersionInfo { get; init; }
    }

    public record class ParameterDocumentation(string ParameterName, string Description);

    public record class EnumMemberDocumentation(string MemberName, string? Comment)
    {
        // OpenAL
        public PropertyInfo? PropertyInfo { get; init; }
    }

    #region OpenAL

    public record PropertyInfo(
        string[] PropertyOn,
        string? Type,
        string[]? Groups,
        PropertyRange? Range,
        string? Default
        );

    public record PropertyRange(string Start, string? End, bool Inclusive)
    {
        public override string ToString()
        {
            return $"[{Start}, {End ?? "∞"}{(Inclusive ? "]" : ")")}";
        }
    }

    #endregion
}
