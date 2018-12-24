using System.Collections.Generic;

namespace Generator.Bind.Generators
{
    /// <summary>
    /// Contains default generators.
    /// </summary>
    public static class Generators
    {
        /// <summary>
        /// A generator for OpenGL for Embedded Systems.
        /// </summary>
        public class GlesGenerator : IGenerator
        {
            /// <inheritdoc />
            public string Name => "GLES";
        }

        /// <summary>
        /// A generator for OpenGL: Safety Critical.
        /// </summary>
        public class GlscGenerator : IGenerator
        {
            /// <inheritdoc />
            public string Name => "GLSC";
        }

        /// <summary>
        /// A generator for OpenGL Core Profile.
        /// </summary>
        public class CoreGenerator : IGenerator
        {
            /// <inheritdoc />
            public string Name => "OpenGL (Core Profile)";
        }

        /// <summary>
        /// A generator for OpenGL Compatibility profile.
        /// </summary>
        public class CompatibilityGenerator : IGenerator
        {
            /// <inheritdoc />
            public string Name => "OpenGL";
        }

        /// <summary>
        /// Gets all of the default generators.
        /// </summary>
        public static IReadOnlyList<IGenerator> Default { get; } = new List<IGenerator>()
        {
            new GlesGenerator(),
            new GlscGenerator(),
            new CoreGenerator(),
            new CompatibilityGenerator()
        };
    }
}
