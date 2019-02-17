using System.Collections.Generic;
using Generator.Common;

namespace Generator.Convert.Baking
{
    /// <summary>
    /// Represents information to be passed to the profile bakery (a script or recipe if you will).
    /// </summary>
    public class ProfileBakeryInformation
    {
        // ReSharper disable InconsistentNaming

        /// <summary>
        /// Gets <see cref="ProfileBakeryInformation"/> implementing OpenGL for Embedded Systems,
        /// versions 2.0 through 3.2.
        /// </summary>
        public static ProfileBakeryInformation GLES { get; } = new ProfileBakeryInformationBuilder()
            .Implements("gles2", "gles2-2.0", "gles2-3.0", "gles2-3.1", "gles2-3.2")
            .WithNamespaces("OpenToolkit.OpenGLES", "OpenToolkit.OpenGLES.Extensions")
            .WithName("GLES")
            .WithOutputFolder("OpenGL")
            .WithLibraries
            (
                "OpenGLESLibraryNameContainer",
                linux: "libGLESv2.so",
                android: "libGLESv2.so",
                osx: "/System/Library/Frameworks/OpenGLES.framework/OpenGLES",
                windows: "libGLESv2.dll",
                ios: "/System/Library/Frameworks/OpenGLES.framework/OpenGLES"
            )
            .Result;

        /// <summary>
        /// Gets <see cref="ProfileBakeryInformation"/> implementing the OpenGL Compatibility Profile, versions 1.0
        /// through 4.6.
        /// </summary>
        public static ProfileBakeryInformation GLCompatibility { get; } = new ProfileBakeryInformationBuilder()
            .Implements("gl", "gl-1.0", "gl-1.1", "gl-1.2", "gl-1.3", "gl-1.4", "gl-1.5")
            .Implements("gl-2.0", "gl-2.1")
            .Implements("gl-3.0", "gl-3.1", "gl-3.2", "gl-3.3")
            .Implements("gl-4.0", "gl-4.1", "gl-4.2", "gl-4.3", "gl-4.4", "gl-4.5", "gl-4.6")
            .WithNamespaces("OpenToolkit.OpenGL", "OpenToolkit.OpenGL.Extensions")
            .WithName("OpenGL")
            .WithOutputFolder("OpenGL")
            .WithLibraries
            (
                "OpenGLLibraryNameContainer",
                linux: "libGL.so.1",
                android: "libGL.so.1",
                osx: "/System/Library/Frameworks/OpenGL.framework/OpenGL",
                windows: "opengl32.dll",
                ios: "/System/Library/Frameworks/OpenGL.framework/OpenGL"
            )
            .Result;

        /// <summary>
        /// Gets <see cref="ProfileBakeryInformation"/> implementing the OpenGL Core Profile, versions 1.0
        /// through 4.6.
        /// </summary>
        public static ProfileBakeryInformation GLCore { get; } = new ProfileBakeryInformationBuilder()
            .Implements("glcore", "glcore-1.0", "glcore-1.1", "glcore-1.2", "glcore-1.3", "glcore-1.4", "glcore-1.5")
            .Implements("glcore-2.0", "glcore-2.1")
            .Implements("glcore-3.0", "glcore-3.1", "glcore-3.2", "glcore-3.3")
            .Implements("glcore-4.0", "glcore-4.1", "glcore-4.2", "glcore-4.3", "glcore-4.4", "glcore-4.5")
            .Implements("glcore-4.6")
            .WithNamespaces("OpenToolkit.OpenGL.Core", "OpenToolkit.OpenGL.Core.Extensions")
            .WithName("OpenGL (Core Profile)")
            .WithOutputFolder("OpenGL")
            .WithLibraries
            (
                "GLCoreLibraryNameContainer",
                linux: "libGL.so.1",
                android: "libGL.so.1",
                osx: "/System/Library/Frameworks/OpenGL.framework/OpenGL",
                windows: "opengl32.dll",
                ios: "/System/Library/Frameworks/OpenGL.framework/OpenGL"
            )
            .Result;

/*
*        /// <summary>
*        /// Gets <see cref="ProfileBakeryInformation"/> implementing OpenGL Safety Critical, version 2.0.
*        /// </summary>
*        public static ProfileBakeryInformation GLSC { get; } = new ProfileBakeryInformationBuilder()
*            .Implements("glsc2", "glsc2-2.0")
*            .WithNamespaces("OpenToolkit.OpenGLSC", "OpenToolkit.OpenGLSC.Extensions")
*            .WithName("GLSC")
*            .WithOutputFolder("OpenGL")
*            .Result;
*/

        // ReSharper restore InconsistentNaming

        /// <summary>
        /// Gets or sets a list of the APIs that should be baked into this profile.
        /// </summary>
        public List<string> Implements { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the namespace in which the Core functions and enums should be placed.
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

        /// <summary>
        /// Gets or sets the name container for this profile.
        /// </summary>
        public NameContainer NameContainer { get; set; } = new NameContainer();

        /// <summary>
        /// Gets all of the out-of-the-box-supported bakery info.
        /// </summary>
        public static List<ProfileBakeryInformation> Default { get; } = new List<ProfileBakeryInformation>()
        {
            GLCore,
            GLCompatibility,
            GLES,
            /* GLSC */
        };
    }
}