using Generator.Common;
using Newtonsoft.Json;

namespace Generator.Bind.Generators
{
    public static class GeneratorExtensions
    {
        public static Profile GetProfile(this IGenerator generator)
        {
            return JsonConvert.DeserializeObject<Profile>(generator.Name + ".json");
        }
    }
}
