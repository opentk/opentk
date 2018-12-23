using Generator.Common.Baking;
using Newtonsoft.Json;

namespace Generator.Bind.Generators
{
    public static class GeneratorExtensions
    {
        public static BakedProfile GetProfile(this IGenerator generator)
        {
            return JsonConvert.DeserializeObject<BakedProfile>(generator.Name + ".json");
        }
    }
}
