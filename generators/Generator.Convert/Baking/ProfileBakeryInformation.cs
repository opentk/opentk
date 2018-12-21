using System.Collections.Generic;

namespace Generator.Convert.Baking
{
    public class ProfileBakeryInformation
    {
        public static ProfileBakeryInformation ES20 { get; } = new ProfileBakeryInformationBuilder()
            .Implements("gles2", "gles2-2.0")
            .WithNamespaces("OpenToolkit.OpenGL.ES20", "OpenToolkit.OpenGL.ES20.Extensions")
            .WithName("ES20")
            .WithOutputFolder("OpenGL")
            .Result;

        public static ProfileBakeryInformation ES30 { get; } = new ProfileBakeryInformationBuilder()
            .Extends("ES20")
            .Implements("gles2-3.0")
            .WithNamespaces("OpenToolkit.OpenGL.ES30", "OpenToolkit.OpenGL.ES30.Extensions")
            .WithName("ES30")
            .WithOutputFolder("OpenGL")
            .Result;

        public static ProfileBakeryInformation ES31 { get; } = new ProfileBakeryInformationBuilder()
            .Extends("ES20", "ES30")
            .Implements("gles2-3.1")
            .WithNamespaces("OpenToolkit.OpenGL.ES31", "OpenToolkit.OpenGL.ES31.Extensions")
            .WithName("ES31")
            .WithOutputFolder("OpenGL")
            .Result;

        public static ProfileBakeryInformation GL2 { get; } = new ProfileBakeryInformationBuilder()
            .Implements("gl", "gl-1.0", "gl-1.1", "gl-1.2", "gl-1.3", "gl-1.4", "gl-1.5", "gl-2.0")
            .WithNamespaces("OpenToolkit.OpenGL", "OpenToolkit.OpenGL.Extensions")
            .WithName("GL2")
            .WithOutputFolder("OpenGL")
            .Result;

        public static ProfileBakeryInformation GL4 { get; } = new ProfileBakeryInformationBuilder()
            .Implements("glcore", "glcore-1.0", "glcore-1.1", "glcore-1.2", "glcore-1.3", "glcore-1.4", "glcore-1.5")
            .Implements("glcore-2.0", "glcore-2.1")
            .Implements("glcore-3.0", "glcore-3.1", "glcore-3.2", "glcore-3.3")
            .Implements("glcore-4.0")
            .WithNamespaces("OpenToolkit.OpenGL.GL4", "OpenToolkit.OpenGL.GL4.Extensions")
            .WithName("GL4")
            .WithOutputFolder("OpenGL")
            .Result;

        /// <summary>
        /// Gets or sets a list of the APIs that should be baked into this profile
        /// </summary>
        public List<string> Implements { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets a list of baked profiles that this baked profile should extend.
        /// </summary>
        public List<string> Extends { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the namespace in which the Core functions and enums should be placed
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets the root namespace in which Extension namespaces should be prefixed.
        /// </summary>
        public string ExtensionsNamespace { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the baked profile.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the subfolder (relative to src) in which this profile should be exported.
        /// </summary>
        public string OutputFolder { get; set; }
        
        public static List<ProfileBakeryInformation> Default { get; } = new List<ProfileBakeryInformation>()
        {
            ES20,
            ES30,
            ES31,
            GL2,
            GL4
        };
    }
}
