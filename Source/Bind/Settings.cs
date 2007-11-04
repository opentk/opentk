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

        public static string GLClass = "GL";        // Needed by Glu for the AuxEnumsClass. Can be set through -gl:"xxx".
        public static string OutputClass = "GL";    // The real output class. Can be set through -class:"xxx".
        public static string FunctionPrefix = "gl";
        public static string ConstantPrefix = "GL_";

        // TODO: This code is too fragile.
        // Old enums code:
        public static string normalEnumsClassOverride;
        public static string NestedEnumsClass = "Enums";
        public static string NormalEnumsClass
        {
            get
            {
                return
                    normalEnumsClassOverride == null ?
                        String.IsNullOrEmpty(NestedEnumsClass) ? OutputClass : OutputClass + "." + NestedEnumsClass :
                        normalEnumsClassOverride;
            }
        }
 
        public static string AuxEnumsClass 
        {
            get { return GLClass + "." + NestedEnumsClass; }
        }

        public static string EnumsOutput
        {
            get
            {
                if ((Settings.Compatibility & Settings.Legacy.NestedEnums) != Settings.Legacy.None)
                    return OutputNamespace + "." + OutputClass + "." + NestedEnumsClass;
                else
                    return OutputNamespace + "." + EnumsNamespace;
            }
        }

        public static string EnumsAuxOutput
        {
            get
            {
                if ((Settings.Compatibility & Settings.Legacy.NestedEnums) != Settings.Legacy.None)
                    return OutputNamespace + "." + GLClass + "." + NestedEnumsClass;
                else
                    return OutputNamespace + "." + EnumsNamespace;
            }
        }

        // New enums namespace (no nested class).
        public static string EnumsNamespace = "Enums";

        public static string DelegatesClass = "Delegates";
        public static string ImportsClass = "Imports";

        public static Legacy Compatibility = Legacy.None;

        /// <summary>
        /// The name of the C# enum which holds every single OpenGL enum (for compatibility purposes).
        /// </summary>
        public static string CompleteEnumName = "All";
        
        [Flags]
        public enum Legacy
        {
            None = 0x00,
            ConstIntEnums = 0x01,
            NoAdvancedEnumProcessing = 0x02,
            NoPublicUnsafeFunctions = 0x04,
            NoTrimFunctionEnding = NoPublicUnsafeFunctions,
            NoTrimFunctionPrefix = 0x08,
            NoSeparateFunctionNamespaces = 0x10,
            TurnVoidPointersToIntPtr = 0x20,
            GenerateAllPermutations = 0x40,
            NestedEnums = 0x80,
            Tao = ConstIntEnums | NoAdvancedEnumProcessing | NoPublicUnsafeFunctions | NoTrimFunctionEnding | NoTrimFunctionPrefix | NoSeparateFunctionNamespaces | TurnVoidPointersToIntPtr | GenerateAllPermutations,
        }
        
        public static string WindowsGDI = "OpenTK.Platform.Windows.API";
    }
}
