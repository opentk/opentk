using System.Collections.Generic;
using OpenTK.OpenGL.Generator.Process;

namespace OpenTK.OpenGL.Generator.Parsing
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
