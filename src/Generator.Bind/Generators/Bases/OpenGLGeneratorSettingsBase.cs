/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Bind.Versioning;

namespace Bind.Generators.Bases
{
    /// <summary>
    /// Base class for OpenGL API generators.
    /// </summary>
    internal abstract class OpenGLGeneratorSettingsBase : GeneratorSettingsBase
    {
        /// <inheritdoc/>
        public override string OutputSubfolder => "OpenGL";

        /// <inheritdoc/>
        public override string Namespace => "OpenTK.Graphics.OpenGL";

        /// <inheritdoc/>
        public override string ClassName => "GL";

        /// <inheritdoc/>
        public override string FunctionPrefix => "gl";

        /// <inheritdoc/>
        public override string ConstantPrefix => "GL_";

        /// <inheritdoc/>
        public override string APITypemap => Path.Combine("OpenGL", "gl.tm");

        /// <inheritdoc/>
        public override string LicenseText { get; }

        /// <inheritdoc/>
        public override string SpecificationFile => Path.Combine("OpenGL", "signatures.xml");

        /// <inheritdoc/>
        public override string BaseProfileName => null;

        /// <inheritdoc />
        public override VersionRange Versions => new VersionRange();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGLGeneratorSettingsBase"/> class.
        /// </summary>
        protected OpenGLGeneratorSettingsBase()
        {
            var overrideFileDirectoryPath = Path.Combine(Program.Arguments.InputPath, "OpenGL", "GL");
            var fullPath = Path.GetFullPath(overrideFileDirectoryPath);

<<<<<<< HEAD
=======
            if (!Directory.Exists(fullPath))
            {
                string solutionPath = fullPath.Substring(0, fullPath.IndexOf(@"src"));
                string InsertSolutionDir(string str) => str.Insert(0, solutionPath);

                Program.Arguments.InputPath = InsertSolutionDir(Program.Arguments.InputPath);
                Program.Arguments.OutputPath = InsertSolutionDir(Program.Arguments.OutputPath);
                Program.Arguments.DocumentationPath = InsertSolutionDir(Program.Arguments.DocumentationPath);
                Program.Arguments.LicenseFile = InsertSolutionDir(Program.Arguments.LicenseFile);
                System.Console.WriteLine("Adding solution path to directory");

                overrideFileDirectoryPath = Path.Combine(Program.Arguments.InputPath, "OpenGL", "GL");
            }

            var extraOverrides = Directory.GetFiles(overrideFileDirectoryPath, "*.xml", SearchOption.AllDirectories);

>>>>>>> 8ee326fdcb04412916581eda1afe167b84015141
            using (var fs = File.OpenText(Program.Arguments.LicenseFile))
            {
                var licenseContents = fs.ReadToEnd().TrimEnd();
                LicenseText = licenseContents;
            }

            OverrideFiles = new[]
            {
                Path.Combine(Program.Arguments.InputPath, "OpenGL", "overrides.xml")
            }
            .Concat(extraOverrides);
        }
    }
}
