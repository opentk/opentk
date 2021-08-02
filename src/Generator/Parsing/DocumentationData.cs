using Generator.Writing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Parsing
{
    public record Documentation(
        // FIXME: Better name
        Dictionary<OutputApi, VersionDocumentation> VersionDocumentation
        );

    public record VersionDocumentation(
        Dictionary<string, CommandDocumentation> Commands
        );

    public record CommandDocumentation(
        string Name,
        string Purpose,
        ParameterDocumentation[] Parameters
        );

    public record ParameterDocumentation(
        string Name,
        string Description
        );
}
