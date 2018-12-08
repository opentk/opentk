using System.Threading.Tasks;
using Bind.Generators;
using Bind.Writers.Structure;
using Bind.XML.Documentation;
using Bind.XML.Signatures;

namespace Bind.Writers
{
    /// <summary>
    /// A class which generates AdvancedDLSupport bindings from a given API specification.
    /// </summary>
    internal class BindingWriter
    {
        /// <summary>
        /// Gets the API documentation being used.
        /// </summary>
        public ProfileDocumentation ProfileDocs { get; }

        /// <summary>
        /// Gets the API specification being used.
        /// </summary>
        public ApiProfile Profile { get; }

        /// <summary>
        /// Gets the bindings generator settings being used.
        /// </summary>
        public IGeneratorSettings Settings { get; }

        /// <summary>
        /// Creates an instance with the given <see cref="Settings"/>, <see cref="Profile"/>, and <see cref="ProfileDocs"/>.
        /// </summary>
        /// <param name="generatorSettings">The settings to use.</param>
        /// <param name="overloadedProfile">The API specification to use.</param>
        /// <param name="bakedDocs">The API documentation to use.</param>
        public BindingWriter(IGeneratorSettings generatorSettings, ApiProfile overloadedProfile, ProfileDocumentation bakedDocs)
        {
            Settings = generatorSettings;
            Profile = overloadedProfile;
            ProfileDocs = bakedDocs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task WriteBindingsAsync()
        {
            Subsystem subsystem = new Subsystem(Settings,Profile,ProfileDocs);
            await subsystem.GenerateAsync();
            await subsystem.FlushAsync();
        }

        public async Task GenerateProjectsAsync(string outputFolder)
        {
            
        }
    }
}