using System.Linq;

namespace Generator.Convert.Baking
{
    /// <summary>
    /// A builder class for <see cref="ProfileBakeryInformation"/>.
    /// </summary>
    public class ProfileBakeryInformationBuilder
    {
        /// <summary>
        /// Gets the resulting <see cref="ProfileBakeryInformation"/>.
        /// </summary>
        public ProfileBakeryInformation Result { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileBakeryInformationBuilder"/> class.
        /// </summary>
        public ProfileBakeryInformationBuilder()
        {
            Result = new ProfileBakeryInformation();
        }

        /// <summary>
        /// Adds the given implemented profiles to the <see cref="ProfileBakeryInformation"/>.
        /// </summary>
        /// <param name="implements">The profiles to implement.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder Implements(params string[] implements)
        {
            Result.Implements.AddRange(implements);
            return this;
        }

        /// <summary>
        /// Sets the profile's namespaces.
        /// </summary>
        /// <param name="ns">The root namespace.</param>
        /// <param name="extensionNs">The extension root namespace.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithNamespaces(string ns, string extensionNs)
        {
            Result.Namespace = ns;
            Result.ExtensionsNamespace = extensionNs;
            return this;
        }

        /// <summary>
        /// Sets the profile's name.
        /// </summary>
        /// <param name="name">The name of the profile.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithName(string name)
        {
            Result.Name = name;
            return this;
        }

        /// <summary>
        /// Sets the output folder.
        /// </summary>
        /// <param name="folder">The output folder.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithOutputFolder(string folder)
        {
            Result.OutputFolder = folder;
            return this;
        }
    }
}
