#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using Bind.Structures;
using Delegate=Bind.Structures.Delegate;
using Enum=Bind.Structures.Enum;
using Type=Bind.Structures.Type;

namespace Bind.GL2
{
    abstract class Generator : IBind
    {
        #region Fields

        protected string path;
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

        #endregion

        #region Constructors

        public Generator(Settings settings, string dirName)
        {
            if (settings == null)
                throw new ArgumentNullException("settings");
            if (String.IsNullOrEmpty(dirName))
                dirName = "GL2";

            Settings = settings.Clone();
            Settings.DefaultTypeMapFile = "GL2/gl.tm";

            path = Path.Combine(Settings.InputPath, dirName);

            Settings.OutputClass = "GL";
            Settings.DefaultClassesFile = "GL.Extensions.cs";

            Delegates = new DelegateCollection();
            Enums = new EnumCollection();
            Wrappers = new FunctionCollection();
            Classes = new ClassCollection();

            SpecReader = new XmlSpecReader(Settings);
        }

        #endregion

        #region IBind Members

        public DelegateCollection Delegates { get; private set; }
        public EnumCollection Enums { get; private set; }
        public FunctionCollection Wrappers { get; private set; }
        public ClassCollection Classes { get; private set; }
        public IDictionary<string, string> GLTypes { get; private set; }
        public IDictionary<string, string> CSTypes { get; private set; }

        public virtual void Process()
        {
            string overrides = Path.Combine(path, Settings.OverridesFile);
            string enums = Path.Combine(path, Settings.SignaturesFile);
            string functions = Path.Combine(path, Settings.SignaturesFile);

            GLTypes = SpecReader.ReadTypeMap(Path.Combine(Settings.InputPath, Settings.TypeMapFile));
            CSTypes = SpecReader.ReadCSTypeMap(Path.Combine(Settings.InputPath, Settings.LanguageTypeMapFile));

            SpecReader.ReadEnums(enums, Enums, Profile, Version);
            SpecReader.ReadEnums(overrides, Enums, Profile, Version);
            SpecReader.ReadDelegates(functions, Delegates, Profile, Version);
            SpecReader.ReadDelegates(overrides, Delegates, Profile, Version);

            var enum_processor = new EnumProcessor(this, overrides);
            var func_processor = new FuncProcessor(this, overrides);
            var doc_processor = new DocProcessor(this);

            Enums = enum_processor.Process(Enums, Profile);
            Wrappers = func_processor.Process(enum_processor, doc_processor,
                Delegates, Enums, Profile, Version, Classes);
        }

        #endregion
    }
}
