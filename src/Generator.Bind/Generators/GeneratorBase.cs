/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using System.IO;
using Bind.Structures;
using JetBrains.Annotations;

namespace Bind.Generators
{
    /// <summary>
    /// Base class for API generators.
    /// </summary>
    internal abstract class GeneratorBase : IGenerator
    {
        /// <inheritdoc/>
        public virtual string APIIdentifier => "GL";

        /// <inheritdoc/>
        public virtual string OutputSubfolder => "OpenGL";

        /// <inheritdoc/>
        public virtual string Namespace => "OpenTK.Graphics.OpenGL";

        /// <inheritdoc/>
        public virtual string ClassName => "GL";

        /// <inheritdoc/>
        public virtual string FunctionPrefix => "gl";

        /// <inheritdoc/>
        public virtual string ConstantPrefix => "GL_";

        /// <inheritdoc/>
        public virtual string SpecificationDocumentationPath => "GL";

        /// <summary>
        /// Gets or sets a set of paths, indicating files to scan for specification overrides.
        /// </summary>
        public virtual IEnumerable<string> OverrideFiles { get; set; }

        /// <summary>
        /// Gets the path to the file that contains the language typemap.
        /// </summary>
        [NotNull]
        protected virtual string LanguageTypemap => "csharp.tm";

        /// <summary>
        /// Gets the path to the file that contains the API typemap.
        /// </summary>
        [NotNull]
        protected virtual string APITypemap => Path.Combine("GL2", "gl.tm");

        /// <summary>
        /// Gets the path to the file that contains the API specification.
        /// </summary>
        [NotNull]
        protected virtual string SpecificationFile => Path.Combine("GL2", "signatures.xml");

        /// <summary>
        /// Gets the path to the file that contains the API enum specification.
        /// </summary>
        [NotNull]
        protected virtual string EnumSpecificationFile => Path.Combine("GL2", "signatures.xml");

        /// <summary>
        /// Gets the name of the function that loads all entrypoints.
        /// </summary>
        [NotNull]
        protected const string LoadAllFuncName = "LoadAll";

        /// <summary>
        /// Gets the name that corresponds to the "profile" attribute in the OpenGL registry. We use this to distinguish
        /// between different profiles (e.g. "gl", "glcore", "gles1", "gles2").
        /// </summary>
        [NotNull]
        protected virtual string ProfileName => "gl";

        /// <summary>
        /// Gets the version that corresponds to the "number" attribute in the OpenGL registry. We use this to
        /// distinguish between OpenGL ES 2.0 and 3.0, which share the same profile "gles2". If empty, then all elements
        /// of a profile will be parsed, and their version number will be ignored.
        /// </summary>
        [NotNull]
        protected virtual string Version => string.Empty;

        /// <summary>
        /// Gets the specification reader associated with this generator.
        /// </summary>
        [NotNull]
        protected ISpecificationReader SpecificationReader { get; }

        /// <inheritdoc />
        public DelegateCollection Delegates { get; private set; }

        /// <inheritdoc />
        public EnumCollection Enums { get; private set; }

        /// <inheritdoc />
        public FunctionCollection Wrappers { get; private set; }

        /// <inheritdoc />
        public IDictionary<string, string> APITypes { get; private set; }

        /// <inheritdoc />
        public IDictionary<string, string> LanguageTypes { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratorBase"/> class.
        /// </summary>
        protected GeneratorBase()
        {
            OverrideFiles = new List<string>();

            Wrappers = new FunctionCollection();

            SpecificationReader = new XmlSpecificationReader();
        }

        /// <inheritdoc />
        public virtual void LoadData()
        {
            var apiTypemapPath = Path.Combine(Program.Arguments.InputPath, APITypemap);
            var languageTypemapPath = Path.Combine(Program.Arguments.InputPath, LanguageTypemap);

            var specificationFilePath = Path.Combine(Program.Arguments.InputPath, SpecificationFile);
            var enumSpecificationPath = Path.Combine(Program.Arguments.InputPath, EnumSpecificationFile);

            APITypes = SpecificationReader.ReadAPITypeMap(apiTypemapPath);
            LanguageTypes = SpecificationReader.ReadLanguageTypeMap(languageTypemapPath);

            // Read enum signatures
            Enums = SpecificationReader.ReadEnums(enumSpecificationPath, OverrideFiles, ProfileName, Version);

            // Read delegate signatures
            Delegates = SpecificationReader.ReadDelegates(specificationFilePath, OverrideFiles, ProfileName, Version);

            var enumProcessor = new EnumProcessor(this, OverrideFiles);
            var funcProcessor = new FuncProcessor(this, OverrideFiles);
            var docProcessor = new DocProcessor(this);

            Enums = enumProcessor.Process(Enums, ProfileName);
            Wrappers = funcProcessor.Process(enumProcessor, docProcessor, Delegates, Enums, ProfileName, Version);
        }
    }
}
