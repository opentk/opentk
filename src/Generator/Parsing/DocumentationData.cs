using Generator.Writing;
using System.Collections.Generic;

namespace Generator.Parsing
{
    internal record Documentation(
        // FIXME: Better name
        Dictionary<OutputApi, VersionDocumentation> VersionDocumentation
        );

    internal record VersionDocumentation(
        Dictionary<string, CommandDocumentation> Commands
        );

    internal record CommandDocumentation(
        string Name,
        string Purpose,
        ParameterDocumentation[] Parameters,
        string RefPagesLink);

    internal record ParameterDocumentation(
        string Name,
        string Description
        );
}
