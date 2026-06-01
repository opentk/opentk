using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace GeneratorBase.Utility
{
    public static class DocumentationExtensions
    {
        extension(IndentedTextWriter writer)
        {
            public void WriteVersionInfo(VersionInfo versionInfo)
            {
                List<string> strs = [.. versionInfo.Extensions.Select(e => e.Name)];
                if (versionInfo.Version != null)
                {
                    strs.Insert(0, $"v{versionInfo.Version.Major}.{versionInfo.Version.Minor}");
                }
                writer.Write($"<b>[requires: {string.Join(" | ", strs)}]</b> ");

                if (versionInfo.DeprecatedBy?.Count > 0)
                {
                    writer.WriteLine();
                    foreach (DeprecationReason deprecation in versionInfo.DeprecatedBy)
                    {
                        string v = deprecation.Version != null ? $"v{deprecation.Version}" : deprecation.Extension ?? throw new Exception();
                        string explanationLink = deprecation.ExplanationLink != null ? $"See: <see href=\"{deprecation.ExplanationLink}\" />" : "";
                        writer.WriteLine($"/// <br/><b>[deprecated by: {v}]</b> {explanationLink}<br/>");
                    }
                    writer.Write("/// ");
                }

                if (versionInfo.RemovedBy?.Count > 0)
                {
                    writer.WriteLine();
                    foreach (RemoveReason removed in versionInfo.RemovedBy)
                    {
                        string v = removed.Version != null ? $"v{removed.Version}" : removed.Extension ?? throw new Exception();
                        string explanationLink = removed.ExplanationLink != null ? $"See: <see href=\"{removed.ExplanationLink}\" />" : "";
                        writer.WriteLine($"/// <br/><b>[removed in: {v}]</b> {explanationLink}<br/>");
                    }
                    writer.Write("/// ");
                }
            }
        }
    }
}
