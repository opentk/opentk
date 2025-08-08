using ALGenerator.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGenerator.Parsing
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
