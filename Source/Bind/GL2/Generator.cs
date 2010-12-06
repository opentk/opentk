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

        protected static string glTypemap = "GL2/gl.tm";
        protected static string csTypemap = "csharp.tm";
        protected static string enumSpec = "GL2/enum.spec";
        protected static string enumSpecExt = "GL2/enumext.spec";
        protected static string glSpec = "GL2/gl.spec";
        protected static string glSpecExt = "";

        protected static string loadAllFuncName = "LoadAll";

        protected static Regex enumToDotNet = new Regex("_[a-z|A-Z]?", RegexOptions.Compiled);

        protected static readonly char[] numbers = "0123456789".ToCharArray();
        //protected static readonly Dictionary<string, string> doc_replacements;

        protected ISpecReader SpecReader = new XmlSpecReader();

        #endregion

        #region Constructors

        public Generator()
        {
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
        }

        #endregion

        #region IBind Members

        public DelegateCollection Delegates { get; private set; }
        public EnumCollection Enums { get; private set; }
        public FunctionCollection Wrappers { get; private set; }

        public virtual void Process()
        {
            string overrides = Path.Combine(Settings.InputPath, Settings.OverridesFile);
            Type.GLTypes = SpecReader.ReadTypeMap(Path.Combine(Settings.InputPath, glTypemap));
            Type.CSTypes = SpecReader.ReadCSTypeMap(Path.Combine(Settings.InputPath, csTypemap));
            Enums = SpecReader.ReadEnums(Path.Combine(Settings.InputPath, enumSpec));
            Utilities.Merge(Enums, SpecReader.ReadEnums(overrides));
            Delegates = SpecReader.ReadDelegates(Path.Combine(Settings.InputPath, glSpec));
            Utilities.Merge(Delegates, SpecReader.ReadDelegates(overrides));

            Enums = new EnumProcessor(overrides).Process(Enums);
            Wrappers = new FuncProcessor(overrides).Process(Delegates, Enums);
        }

        #endregion
    }
}
