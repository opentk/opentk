/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Bind.Structures;

namespace Bind.GL2
{
    internal abstract class Generator : IBind
    {
        protected readonly char[] Numbers = "0123456789".ToCharArray();
        protected string CSTypemap = "csharp.tm";
        protected string EnumSpec = "GL2/enum.spec";
        protected string EnumSpecExt = "GL2/enumext.spec";

        protected Regex EnumToDotNet = new Regex("_[a-z|A-Z]?", RegexOptions.Compiled);
        protected string GLSpec = "GL2/gl.spec";
        protected string GLSpecExt = "";
        protected string GLTypemap = "GL2/gl.tm";

        protected string LoadAllFuncName = "LoadAll";

        /// <summary>
        /// The Profile field corresponds to the "profile" attribute
        /// in the OpenGL registry. We use this to distinguish between
        /// different profiles (e.g. "gl", "glcore", "gles1", "gles2").
        /// </summary>
        protected string Profile = "gl";

        /// <summary>
        /// The Version field corresponds to the "number" attribute
        /// in the OpenGL registry. We use this to distinguish between
        /// OpenGL ES 2.0 and 3.0, which share the same profile "gles2".
        /// If empty, then all elements of a profile will be parsed, and
        /// their version number will be ignored.
        /// </summary>
        protected string Version = string.Empty;

        public Generator(Settings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            Settings = settings.Clone();

            GLTypemap = "GL2/gl.tm";
            CSTypemap = Settings.LanguageTypeMapFile;

            EnumSpec = Path.Combine("GL2", "signatures.xml");
            EnumSpecExt = string.Empty;
            GLSpec = Path.Combine("GL2", "signatures.xml");
            GLSpecExt = string.Empty;

            Settings.ImportsClass = "Core";
            Settings.DelegatesClass = "Delegates";
            Settings.OutputClass = "GL";

            Delegates = new DelegateCollection();
            Enums = new EnumCollection();
            Wrappers = new FunctionCollection();

            SpecReader = new XmlSpecReader(Settings);
        }
        //protected static readonly Dictionary<string, string> doc_replacements;

        protected ISpecReader SpecReader { get; set; }

        public Settings Settings { get; protected set; }

        public DelegateCollection Delegates { get; }
        public EnumCollection Enums { get; private set; }
        public FunctionCollection Wrappers { get; private set; }
        public IDictionary<string, string> GLTypes { get; private set; }
        public IDictionary<string, string> CSTypes { get; private set; }

        public virtual void Process()
        {
            var overrides = Settings.OverridesFiles.SelectMany(GetFiles);

            GLTypes = SpecReader.ReadTypeMap(Path.Combine(Settings.InputPath, GLTypemap));
            CSTypes = SpecReader.ReadCSTypeMap(Path.Combine(Settings.InputPath, CSTypemap));

            // Read enum signatures
            SpecReader.ReadEnums(Path.Combine(Settings.InputPath, EnumSpec), Enums, Profile, Version);
            foreach (var file in overrides)
            {
                SpecReader.ReadEnums(file, Enums, Profile, Version);
            }

            // Read delegate signatures
            SpecReader.ReadDelegates(Path.Combine(Settings.InputPath, GLSpec), Delegates, Profile, Version);
            foreach (var file in overrides)
            {
                SpecReader.ReadDelegates(file, Delegates, Profile, Version);
            }

            var enumProcessor = new EnumProcessor(this, overrides);
            var funcProcessor = new FuncProcessor(this, overrides);
            var docProcessor = new DocProcessor(this);

            Enums = enumProcessor.Process(Enums, Profile);
            Wrappers = funcProcessor.Process(enumProcessor, docProcessor,
                Delegates, Enums, Profile, Version);
        }

        private IEnumerable<string> GetFiles(string path)
        {
            path = Path.Combine(Settings.InputPath, path);
            if ((File.GetAttributes(path) & FileAttributes.Directory) != 0)
            {
                foreach (var file in Directory.GetFiles(
                    path, "*.xml", SearchOption.AllDirectories))
                {
                    yield return file;
                }
            }
            else
            {
                yield return path;
            }
        }
    }
}
