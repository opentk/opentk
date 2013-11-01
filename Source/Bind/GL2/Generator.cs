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
    class Generator : IBind
    {
        #region Fields

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
        protected string Profile = "gl";
        public Settings Settings { get; protected set; }

        #endregion

        #region Constructors

        public Generator(Settings settings, string nsName, string dirName)
        {
            if (settings == null)
                throw new ArgumentNullException("settings");
            if (String.IsNullOrEmpty(nsName))
                throw new ArgumentNullException("nsName");
            if (dirName == null)
                dirName = "GL2";

            Settings = settings.Clone();

            glTypemap = "GL2/gl.tm";
            csTypemap = Settings.LanguageTypeMapFile;

            enumSpec = Path.Combine(dirName, "signatures.xml");
            enumSpecExt = String.Empty;
            glSpec = Path.Combine(dirName, "signatures.xml");
            glSpecExt = String.Empty;
            Settings.OverridesFile = Path.Combine(dirName, "overrides.xml");

            Settings.ImportsClass = "Core";
            Settings.DelegatesClass = "Delegates";
            Settings.OutputClass = "GL";
            Settings.OutputNamespace = nsName;

            if (Settings.Compatibility == Settings.Legacy.Tao)
            {
                Settings.OutputNamespace = "Tao.OpenGl";
                Settings.OutputClass = "Gl";
            }
            else
            {
                // Defaults
            }

            Settings.ImportsFile = "GLCore.cs";
            Settings.DelegatesFile = "GLDelegates.cs";
            Settings.EnumsFile = "GLEnums.cs";
            Settings.WrappersFile = "GL.cs";

            Delegates = new DelegateCollection();
            Enums = new EnumCollection();
            Wrappers = new FunctionCollection();

            SpecReader = new XmlSpecReader(Settings);
        }

        #endregion

        #region IBind Members

        public DelegateCollection Delegates { get; private set; }
        public EnumCollection Enums { get; private set; }
        public FunctionCollection Wrappers { get; private set; }
        public IDictionary<string, string> GLTypes { get; private set; }
        public IDictionary<string, string> CSTypes { get; private set; }

        public virtual void Process()
        {
            string overrides = Path.Combine(Settings.InputPath, Settings.OverridesFile);
            
            GLTypes = SpecReader.ReadTypeMap(Path.Combine(Settings.InputPath, glTypemap));
            CSTypes = SpecReader.ReadCSTypeMap(Path.Combine(Settings.InputPath, csTypemap));

            SpecReader.ReadEnums(Path.Combine(Settings.InputPath, enumSpec), Enums, Profile);
            SpecReader.ReadEnums(overrides, Enums, "");
            SpecReader.ReadDelegates(Path.Combine(Settings.InputPath, glSpec), Delegates, Profile);
            SpecReader.ReadDelegates(overrides, Delegates, "");

            var enum_processor = new EnumProcessor(this, overrides);
            var func_processor = new FuncProcessor(this, overrides);

            Enums = enum_processor.Process(Enums);
            Wrappers = func_processor.Process(enum_processor, Delegates, Enums);
        }

        #endregion
    }
}
