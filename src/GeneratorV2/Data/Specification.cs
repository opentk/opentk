using GeneratorV2.Data;
using System.Collections.Generic;

namespace GeneratorV2.Data
{
    public class Specification
    {
        // FIXME: Read only versions!
        public readonly Dictionary<string, Api> Apis;
        public readonly Dictionary<string, Command2> Commands;
        public readonly EnumEntryCollection Enums;

        public Specification(Dictionary<string, Api> apis, Dictionary<string, Command2> commands)
        {
            Apis = apis;
            Commands = commands;
            Enums = default;
            throw new System.Exception("!!!!");
        }
        /*
        private Api GetOrCreateApi(string apiName)
        {
            if (!Apis.TryGetValue(apiName, out Api? value))
            {
                value = new Api(apiName);
                Apis.Add(apiName, value);
            }
            return value;
        }

        public void AddFeature(Feature feature)
        {
            Api orCreateApi = GetOrCreateApi(feature.Api);
            orCreateApi.AddEnums(feature);
            orCreateApi.Features.Add(feature);
        }

        public void AddExtension(Extension extension)
        {
            Api orCreateApi = GetOrCreateApi(extension.Api);
            orCreateApi.AddEnums(extension);
            orCreateApi.Extensions.AddExtension(extension);
        }*/
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
