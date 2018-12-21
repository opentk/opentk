using System.Collections.Generic;
using System.IO;
using System.Linq;
using Generator.Common;
using Generator.Common.Baking;
using MoreLinq.Extensions;
using Newtonsoft.Json;

namespace Generator.Convert.Baking
{
    public class ProfileBakery
    {
        public static void Bake(ProfileBakeryInformation information, string folder, bool pretty)
        {
            // get APIs implemented
            var impl = information.Implements.Select(x => File.ReadAllText(Path.Combine(folder, "api-" + x + ".json")))
                .Select(JsonConvert.DeserializeObject<Profile>)
                .ToList();

            // get profiles extended
            var ext = information.Extends.Select(x => File.ReadAllText(Path.Combine(folder, x + ".json")))
                .Select(JsonConvert.DeserializeObject<BakedProfile>)
                .ToList();

            // create the profile
            var profile = new Profile
            {
                Name = information.Name,
                Namespace = information.Namespace,
                ExtensionsNamespace = information.ExtensionsNamespace,
                OutputFolder = information.OutputFolder,
            };
            profile.Projects.Add
            (
                "Core",
                new Project()
                {
                    CategoryName = "Core", ExtensionName = "Core", Namespace = information.Namespace, IsRoot = true
                }
            );

            // bake in the implemented interfaces, enums, and extension projects
            var extProjects = impl.SelectMany(x => x.Projects.Where(y => y.Key != "Core"));
            var coreProjects = impl.Select(x => x.Projects["Core"]).ToList();
            var coreFunc = coreProjects.SelectMany(x => x.Interfaces);
            var coreEnums = coreProjects.SelectMany(x => x.Enums);
            profile.Projects["Core"].Interfaces = profile.Projects["Core"].Interfaces.Concat(coreFunc).ToDictionary();
            profile.Projects["Core"].Enums.AddRange(coreEnums);
            profile.Projects = profile.Projects.Concat(extProjects).ToDictionary();

            // create the output (baked) profile referencing the extended APIs
            var bakedProfile = new BakedProfile
            {
                Profile = profile,
                PackageReferences = ext.SelectMany(x => x.PackageReferences)
                    .Concat(ext.Select(x => x.Profile.Namespace))
                    .ToList()
            };

            // save this to disk
            File.WriteAllText
            (
                Path.Combine(folder, information.Name + ".json"),
                JsonConvert.SerializeObject(bakedProfile, pretty ? Formatting.Indented : Formatting.None)
            );
        }

        public static void Bake(IEnumerable<ProfileBakeryInformation> information, string folder, bool pretty)
        {
            foreach (var info in information)
            {
                Bake(info, folder, pretty);
            }
        }

        public static void DeleteRawAPIs(string folder)
        {
            foreach (var file in Directory.GetFiles
                    (folder)
                .Where(x => Path.GetFileName(x).StartsWith("api-") && x.EndsWith(".json")))
            {
                File.Delete(file);
            }
        }
    }
}
