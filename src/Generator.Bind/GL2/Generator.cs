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
        protected string glTypemap = "GL2/gl.tm";
        protected string csTypemap = "csharp.tm";
        protected string enumSpec = "GL2/enum.spec";
        protected string enumSpecExt = "GL2/enumext.spec";
        protected string glSpec = "GL2/gl.spec";
        protected string glSpecExt = "";

        protected string loadAllFuncName = "LoadAll";

        protected Regex enumToDotNet = new Regex("_[a-z|A-Z]?", RegexOptions.Compiled);

        protected readonly char[] numbers = "0123456789".ToCharArray();
        //protected static readonly Dictionary<string, string> doc_replacements;

        protected ISpecReader SpecReader { get; set; }

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
        protected string Version = String.Empty;

        public Settings Settings { get; protected set; }

        public Generator(Settings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }

            Settings = settings.Clone();

            glTypemap = "GL2/gl.tm";
            csTypemap = Settings.LanguageTypeMapFile;

            enumSpec = Path.Combine("GL2", "signatures.xml");
            enumSpecExt = String.Empty;
            glSpec = Path.Combine("GL2", "signatures.xml");
            glSpecExt = String.Empty;

            Settings.ImportsClass = "Core";
            Settings.DelegatesClass = "Delegates";
            Settings.OutputClass = "GL";

            Delegates = new DelegateCollection();
            Enums = new EnumCollection();
            Wrappers = new FunctionCollection();

            SpecReader = new XmlSpecReader(Settings);
        }

        private IEnumerable<string> GetFiles(string path)
        {
            path = Path.Combine(Settings.InputPath, path);
            if ((File.GetAttributes(path) & FileAttributes.Directory) != 0)
            {
                foreach (var file in Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories))
                {
                    Console.WriteLine($"Reading: {file}");
                    yield return file;
                }
            }
            else
            {
                yield return path;
            }
        }

        public DelegateCollection Delegates { get; private set; }
        public EnumCollection Enums { get; private set; }
        public FunctionCollection Wrappers { get; private set; }
        public IDictionary<string, string> GLTypes { get; private set; }
        public IDictionary<string, string> CSTypes { get; private set; }

        public virtual void Process()
        {
            var overrides = Settings.OverridesFiles.SelectMany(GetFiles);

            GLTypes = SpecReader.ReadTypeMap(Path.Combine(Settings.InputPath, glTypemap));
            CSTypes = SpecReader.ReadCSTypeMap(Path.Combine(Settings.InputPath, csTypemap));

            // Read enum signatures
            SpecReader.ReadEnums(Path.Combine(Settings.InputPath, enumSpec), Enums, Profile, Version);
            foreach (var file in overrides)
            {
                SpecReader.ReadEnums(file, Enums, Profile, Version);
            }

            // Read delegate signatures
            SpecReader.ReadDelegates(Path.Combine(Settings.InputPath, glSpec), Delegates, Profile, Version);
            foreach (var file in overrides)
            {
                SpecReader.ReadDelegates(file, Delegates, Profile, Version);
            }

            HashSet<string> extensions = new HashSet<string>();
            foreach (var (name, list) in Delegates)
            {
                var @delegate = list[0];
                if (string.IsNullOrEmpty(@delegate.Category) == false)
                {
                    foreach (var part in @delegate.Category.Split('|'))
                    {
                        extensions.Add(part);
                    }
                }
            }

            foreach(var (name, @enum) in Enums)
            {
                var match = Utilities.Extensions.Match(name);
                if (match.Index == 0 && match.Length != 0)
                {
                    extensions.Add(name);
                }
            }

            var enum_processor = new EnumProcessor(this, overrides);
            var func_processor = new FuncProcessor(this, overrides);
            var doc_processor = new DocProcessor(this);

            Enums = enum_processor.Process(Enums, Profile, extensions);
            Wrappers = func_processor.Process(enum_processor, doc_processor, Delegates, Enums, Profile, Version);
        }
    }
}
