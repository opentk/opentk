#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;

namespace Bind
{
    static class Settings
    {
        // Disable BeforeFieldInit.
        static Settings() { }

        public static string DefaultInputPath = "../../../Source/Bind/Specifications";
        public static string DefaultOutputPath = "../../../Source/OpenTK/Graphics/OpenGL";
        public static string DefaultOutputNamespace = "OpenTK.Graphics.OpenGL";
        public static string DefaultDocPath = "../../../Source/Bind/Specifications/Docs";
        public static string DefaultDocFile = "ToInlineDocs.xslt";
        public static string DefaultLicenseFile = "License.txt";
        public static string DefaultOverridesFile = "GL2/gloverrides.xml";
        public static string DefaultLanguageTypeMapFile = "csharp.tm";
        public static string DefaultKeywordEscapeCharacter = "@";

        static string inputPath, outputPath, outputNamespace, docPath, docFile, licenseFile, overridesFile,
            languageTypeMapFile, keywordEscapeCharacter;
        public static string InputPath { get { return inputPath ?? DefaultInputPath; } set { inputPath = value; } }
        public static string OutputPath { get { return outputPath ?? DefaultOutputPath; } set { outputPath = value; } }
        public static string OutputNamespace { get { return outputNamespace ?? DefaultOutputNamespace; } set { outputNamespace = value; } }
        public static string DocPath { get { return docPath ?? DefaultDocPath; } set { docPath = value; } }
        public static string DocFile { get { return docFile ?? DefaultDocFile; } set { docFile = value; } }
        public static string LicenseFile { get { return licenseFile ?? DefaultLicenseFile; } set { licenseFile = value; } }
        public static string OverridesFile { get { return overridesFile ?? DefaultOverridesFile; } set { overridesFile = value; } }
        public static string LanguageTypeMapFile { get { return languageTypeMapFile ?? DefaultLanguageTypeMapFile; } set { languageTypeMapFile = value; } }
        public static string KeywordEscapeCharacter { get { return keywordEscapeCharacter ?? DefaultKeywordEscapeCharacter; } set { keywordEscapeCharacter = value; } }

        public static string GLClass = "GL";        // Needed by Glu for the AuxEnumsClass. Can be set through -gl:"xxx".
        public static string OutputClass = "GL";    // The real output class. Can be set through -class:"xxx".
        public static string FunctionPrefix = "gl";
        public static string ConstantPrefix = "GL_";
        public static string EnumPrefix = "";
        public static string NamespaceSeparator = ".";

        public static string ImportsFile = "Core.cs";
        public static string DelegatesFile = "Delegates.cs";
        public static string EnumsFile = "Enums.cs";
        public static string WrappersFile = "GL.cs";

        // TODO: This code is too fragile.
        // Old enums code:
        public static string normalEnumsClassOverride = null;
        public static string NestedEnumsClass = "Enums";
        public static string NormalEnumsClass
        {
            get
            {
                return
                    normalEnumsClassOverride == null ?
                        String.IsNullOrEmpty(NestedEnumsClass) ? OutputClass : OutputClass + NamespaceSeparator + NestedEnumsClass :
                        normalEnumsClassOverride;
            }
        }
 
        public static string AuxEnumsClass 
        {
            get { return GLClass + NamespaceSeparator + NestedEnumsClass; }
        }

        public static string EnumsOutput
        {
            get
            {
                if ((Compatibility & Legacy.NestedEnums) != Legacy.None)
                    return OutputNamespace + NamespaceSeparator + OutputClass + NamespaceSeparator + NestedEnumsClass;
                else
                    return String.IsNullOrEmpty(EnumsNamespace) ? OutputNamespace : OutputNamespace + NamespaceSeparator + EnumsNamespace;
            }
        }

        public static string EnumsAuxOutput
        {
            get
            {
                if ((Compatibility & Legacy.NestedEnums) != Legacy.None)
                    return OutputNamespace + NamespaceSeparator + GLClass + NamespaceSeparator + NestedEnumsClass;
                else
                    return OutputNamespace + NamespaceSeparator + EnumsNamespace;
            }
        }

        // New enums namespace (don't use a nested class).
        public static string EnumsNamespace = null;// = "Enums";

        public static string DelegatesClass = "Delegates";
        public static string ImportsClass = "Core";

        public static Legacy Compatibility = Legacy.NoDropMultipleTokens;

        /// <summary>
        /// The name of the C# enum which holds every single OpenGL enum (for compatibility purposes).
        /// </summary>
        public static string CompleteEnumName = "All";
        [Flags]
        public enum Legacy
        {
            /// <summary>Default value.</summary>
            None = 0x00,
            /// <summary>Leave enums as plain const ints.</summary>
            ConstIntEnums = 0x01,
            /// <summary>Leave enums in the default STRANGE_capitalization.ALL_CAPS form.</summary>
            NoAdvancedEnumProcessing = 0x02,
            /// <summary>Don't allow unsafe wrappers in the interface.</summary>
            NoPublicUnsafeFunctions = 0x04,
            /// <summary>Don't trim the [fdisub]v? endings from functions.</summary>
            NoTrimFunctionEnding = NoPublicUnsafeFunctions,
            /// <summary>Don't trim the [gl|wgl|glx|glu] prefixes from functions.</summary>
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
            /// <summary>Generate all possible permutations for ref/array/pointer parameters.</summary>
            GenerateAllPermutations = 0x40,
            /// <summary>Nest enums inside the GL class.</summary>
            NestedEnums = 0x80,
            /// <summary>Turn GLboolean to int (Boolean enum), not bool.</summary>
            NoBoolParameters = 0x100,
            /// <summary>Keep all enum tokens, even if same value (e.g. FooARB, FooEXT and FooSGI).</summary>
            NoDropMultipleTokens = 0x200,
            /// <summary>Do not emit inline documentation.</summary>
            NoDocumentation = 0x400,
            /// <summary>Disables ErrorHelper generation.</summary>
            NoDebugHelpers = 0x800,
            /// <summary>Generate both typed and untyped ("All") signatures for enum parameters.</summary>
            KeepUntypedEnums = 0x1000,
            /// <summary>Marks deprecated functions as [Obsolete]</summary>
            AddDeprecationWarnings = 0x2000,
            Tao = ConstIntEnums |
                  NoAdvancedEnumProcessing |
                  NoPublicUnsafeFunctions |
                  NoTrimFunctionEnding |
                  NoTrimFunctionPrefix |
                  NoSeparateFunctionNamespaces |
                  TurnVoidPointersToIntPtr |
                  NestedEnums |
                  NoBoolParameters |
                  NoDropMultipleTokens |
                  NoDocumentation | 
                  NoDebugHelpers
                  /*GenerateAllPermutations,*/
        }

        // Returns true if flag is enabled.
        public static bool IsEnabled(Legacy flag)
        {
            return (Compatibility & flag) != (Legacy)0;
        }

        // Enables the specified flag.
        public static void Enable(Legacy flag)
        {
            Compatibility |= flag;
        }

        // Disables the specified flag.
        public static void Disable(Legacy flag)
        {
            Compatibility &= ~flag;
        }

        /// <summary>True if multiple tokens should be dropped (e.g. FooARB, FooEXT and FooSGI).</summary>
        public static bool DropMultipleTokens
        { 
            get { return (Compatibility & Legacy.NoDropMultipleTokens) == Legacy.None; } 
            set { if (value) Compatibility |= Legacy.NoDropMultipleTokens; else Compatibility &= ~Legacy.NoDropMultipleTokens; }
        }
        
        public static string WindowsGDI = "OpenTK.Platform.Windows.API";

        public static GeneratorLanguage Language { get; set; }
    }
}
