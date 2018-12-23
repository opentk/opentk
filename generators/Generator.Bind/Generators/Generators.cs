using System.Collections.Generic;

namespace Generator.Bind.Generators
{
    public static class Generators
    {
        public class GlesGenerator : IGenerator
        {
            public string Name => "GLES";
        }

        public class GlscGenerator : IGenerator
        {
            public string Name => "GLSC";
        }

        public class CoreGenerator : IGenerator
        {
            public string Name => "OpenGL (Core Profile)";
        }

        public class CompatibilityGenerator : IGenerator
        {
            public string Name => "OpenGL";
        }

        public static IReadOnlyList<IGenerator> Default { get; } = new List<IGenerator>()
        {
            new GlesGenerator(),
            new GlscGenerator(),
            new CoreGenerator(),
            new CompatibilityGenerator()
        };
    }
}
