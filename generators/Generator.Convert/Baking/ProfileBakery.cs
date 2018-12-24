using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.Common;
using Generator.Convert.Construction;
using MoreLinq.Extensions;
using Newtonsoft.Json;

namespace Generator.Convert.Baking
{
    /// <summary>
    /// A collection of methods for baking/fusing APIs together.
    /// </summary>
    public class ProfileBakery
    {
        /// <summary>
        /// Asynchronously bakes APIs together given the <see cref="ProfileBakeryInformation"/>, and outputs the baked
        /// profile to the given folder.
        /// </summary>
        /// <param name="information">The information of what APIs to bake.</param>
        /// <param name="folder">The output folder.</param>
        /// <param name="pretty">Whether the output JSON should be pretty-printed.</param>
        /// <returns>An asynchronous task.</returns>
        public static Task BakeAsync(ProfileBakeryInformation information, string folder, bool pretty)
        {
            // get APIs implemented
            var impl = information.Implements.Select(x => File.ReadAllText(Path.Combine(folder, "api-" + x + ".json")))
                .Select(JsonConvert.DeserializeObject<Profile>)
                .ToList();

            // create the profile
            var profile = new Profile
            {
                Name = information.Name,
                Namespace = information.Namespace,
                ExtensionsNamespace = information.ExtensionsNamespace,
            };
            profile.Projects.Add
            (
                "Core",
                new Project()
                {
                    CategoryName = "Core", ExtensionName = "Core", Namespace = string.Empty, IsRoot = true
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

            // bake in the documentation. we don't do this at the construction stage
            // because we want to be able to get the latest documentation for functions.
            DocumentationWriter.Write
            (
                profile,
                DocumentationWriter.GetDocumentation(profile, Program.CliOptions.DocumentationPath)
            );

            // save this to disk
            File.WriteAllText
            (
                Path.Combine(folder, information.Name + ".json"),
                JsonConvert.SerializeObject(profile, pretty ? Formatting.Indented : Formatting.None)
            );
            return Task.CompletedTask;
        }

        /// <summary>
        /// Asynchronously bakes multiple sets of APIs together, and outputs them to the given folder.
        /// </summary>
        /// <param name="information">The information for the sets of APIs.</param>
        /// <param name="folder">The output folder.</param>
        /// <param name="pretty">Whether the output JSON should be pretty-printed.</param>
        /// <returns>An asynchronous task.</returns>
        public static async Task BakeAsync
        (
            IEnumerable<ProfileBakeryInformation> information, string folder, bool pretty
        )
        {
            await Task.WhenAll(information.Select(info => BakeAsync(info, folder, pretty)));
        }

        /// <summary>
        /// Deletes all of the unbaked/raw APIs in a folder.
        /// </summary>
        /// <param name="folder">The folder to search and destroy APIs in.</param>
        public static void DeleteRawAPIs(string folder)
        {
            foreach (var file in Directory.GetFiles
                    (folder)
                .Where(x => Path.GetFileName(x).StartsWith("api-") && x.EndsWith(".json")))
            {
                File.Delete(file);
            }
        }

        /// <summary>
        /// Bakes multiple sets of APIs together, and outputs them to the given folder.
        /// </summary>
        /// <param name="information">The information for the sets of APIs.</param>
        /// <param name="folder">The output folder.</param>
        /// <param name="pretty">Whether the output JSON should be pretty-printed.</param>
        public static void Bake(IEnumerable<ProfileBakeryInformation> information, string folder, bool pretty)
        {
            BakeAsync(information, folder, pretty).GetAwaiter().GetResult();
        }
    }
}
