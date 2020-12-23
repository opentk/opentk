using GeneratorV2.Data;
using System.Collections.Generic;

namespace GeneratorV2.Data
{
    public class Specification
    {
        // These are lists of all the functions and enums in the spec
        public readonly List<Command2> Commands;
        public readonly List<EnumsEntry> Enums;

        // This is a list of all the gl versions in the spec.
        // This contains what functions are part of what version.
        public readonly List<Feature> Features;

        public readonly List<Extension> Extensions;

        public Specification(List<Command2> commands, List<EnumsEntry> enums, List<Feature> features, List<Extension> extensions)
        {
            Commands = commands;
            Enums = enums;
            Features = features;
            Extensions = extensions;
        }
    }

    public class OverloadedSpecification
    {
        public readonly Specification Specification;

        public readonly Dictionary<Command2, List<Overload>> CommandOverloads;

        public OverloadedSpecification(Specification specification, Dictionary<Command2, List<Overload>> commandOverloads)
        {
            Specification = specification;
            CommandOverloads = commandOverloads;
        }
    }
}
