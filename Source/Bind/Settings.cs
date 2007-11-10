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
            /// <summary>
            /// Default value.
            /// </summary>
            None = 0x00,
            /// <summary>
            /// Leave enums as plain const ints.
            /// </summary>
            ConstIntEnums = 0x01,
            /// <summary>
            /// Leave enums in the default STRANGE_capitalization.ALL_CAPS form.
            /// </summary>
            NoAdvancedEnumProcessing = 0x02,
            /// <summary>
            /// Don't allow unsafe wrappers in the interface.
            /// </summary>
            NoPublicUnsafeFunctions = 0x04,
            /// <summary>
            /// Don't trim the [fdisub]v? endings from functions.
            /// </summary>
            NoTrimFunctionEnding = NoPublicUnsafeFunctions,
            /// <summary>
            /// Don't trim the [gl|wgl|glx|glu] prefixes from functions.
            /// </summary>
            NoTrimFunctionPrefix = 0x08,
            /// <summary>
            /// Don't spearate functions in different namespaces, according to their extension category
            /// (e.g. GL.Arb, GL.Ext etc).
            /// </summary>
            NoSeparateFunctionNamespaces = 0x10,
            /// <summary>
            /// No public void* parameters (should always be enabled. Disable at your own risk. Disabling
            /// means that BitmapData.Scan0 and other .Net properties/functions must be cast to (void*)
            /// explicitly, to avoid the 'object' overload from being called.)
            /// </summary>
            TurnVoidPointersToIntPtr = 0x20,
            /// <summary>
            /// Generate all possible permutations for ref/array/pointer parameters.
            /// </summary>
            GenerateAllPermutations = 0x40,
            /// <summary>
            /// Nest enums inside the GL class.
            /// </summary>
            NestedEnums = 0x80,
            /// <summary>
            /// Turn GLboolean to int (Boolean enum), not bool.
            /// </summary>
            NoBoolParameters = 0100,
            Tao = ConstIntEnums |
                  NoAdvancedEnumProcessing |
                  NoPublicUnsafeFunctions |
                  NoTrimFunctionEnding |
                  NoTrimFunctionPrefix |
                  NoSeparateFunctionNamespaces |
                  TurnVoidPointersToIntPtr |
                  NestedEnums |
                  NoBoolParameters,
                  /*GenerateAllPermutations,*/
        }
        
        public static string WindowsGDI = "OpenTK.Platform.Windows.API";
    }
}
