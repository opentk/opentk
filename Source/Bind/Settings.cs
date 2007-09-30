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

        public const string DefaultInputPath = "..\\..\\..\\Source\\Bind\\Specifications";
        public const string DefaultOutputPath = "..\\..\\..\\Source\\OpenTK\\OpenGL\\Bindings";
        public const string DefaultOutputNamespace = "OpenTK.OpenGL";

        public static string OutputClass = "GL";
        public static string FunctionPrefix = "gl";
        public static string ConstantPrefix = "GL_";

        // TODO: This code is too fragile.
        public static string NestedEunmsClass = "Enums";
        private static string normalEnumsClassOverride;
        public static string NormalEnumsClass
        {
            get
            {
                if (!String.IsNullOrEmpty(normalEnumsClassOverride))
                    return normalEnumsClassOverride;
                return OutputClass + "." + NestedEunmsClass;
            }
            set { normalEnumsClassOverride = value; }
        }
        public static string AuxEnumsClass = "GL." + NestedEunmsClass;

        public static string DelegatesClass = "Delegates";
        public static string ImportsClass = "Imports";

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
        
        public static string WindowsGDI = "OpenTK.Platform.Windows.API";
    }
}
