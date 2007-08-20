#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Bind
{
    static class Settings
    {
        public static string InputPath = "..\\..\\..\\Source\\Bind\\Specifications";
        public static string OutputPath = "..\\..\\..\\Source\\OpenTK\\OpenGL\\Bindings";
        public static string OutputNamespace = "OpenTK.OpenGL";

        public readonly static string DefaultInputPath = "..\\..\\..\\Source\\Bind\\Specifications";
        public readonly static string DefaultOutputPath = "..\\..\\..\\Source\\OpenTK\\OpenGL\\Bindings";
        public readonly static string DefaultOutputNamespace = "OpenTK.OpenGL";

        public static string OutputClass = "GL";
        public static string FunctionPrefix = "gl";
        public static string ConstantPrefix = "GL_";

        private static string enumsClass = "Enums";
        public static string GLEnumsClass
        {
            get { return OutputClass + "." + enumsClass; }
            set { enumsClass = value; }

        }
        public static string DelegatesClass = "Delegates";
        public static string ImportsClass = "Imports";

        public static Legacy Compatibility = Legacy.None;

        public readonly static string DefaultWglOutputPath = "..\\..\\..\\Source\\OpenTK\\Platform\\Windows\\Bindings";

        /// <summary>
        /// The name of the C# enum which holds every single OpenGL enum (for compatibility purposes).
        /// </summary>
        public static string CompleteEnumName = "All";
        
        public enum Legacy
        {
            None,
            Tao,
        }
        
        public static string WindowsGDI = "OpenTK.Platform.Windows.API";
    }
}
