#region License
//Copyright (c) 2006 Stefanos Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Bind
{
    static class Settings
    {
        public static string InputPath = "..\\..\\..\\Source\\Bind\\Specifications\\gl2";
        public static string OutputPath = "..\\..\\..\\Source\\OpenTK\\OpenGL\\Bindings";
        public static string OutputNamespace = "OpenTK.OpenGL";
        public static string GLClass = "GL";
        private static string enumsClass = "Enums";
        public static string GLEnumsClass
        {
            get { return GLClass + "." + enumsClass; }
            set { enumsClass = value; }

        }
        public static string DelegatesClass = "Delegates";
        public static string ImportsClass = "Imports";
        public static string WglClass = "Wgl";
        public static string GlxClass = "Glx";
        public static string GluClass = "Glu";
        public static Legacy Compatibility = Legacy.None;

        /// <summary>
        /// The name of the C# enum which holds every single OpenGL enum (for compatibility purposes).
        /// </summary>
        public static string CompleteEnumName = "All";

        public enum Legacy
        {
            None,
            Tao,
        }
    }
}
