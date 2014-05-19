#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bind
{
    [Serializable]
    class Settings
    {
        // Disable BeforeFieldInit.
        public Settings()
        {
        }

        public string DefaultInputPath = "../../../Source/Bind/Specifications";
        public string DefaultOutputPath = "../../../Source/OpenTK/Graphics/OpenGL";
        public string DefaultOutputNamespace = "OpenTK.Graphics.OpenGL";
        public string DefaultDocPath = "../../../Source/Bind/Specifications/Docs";
        public string DefaultFallbackDocPath = "../../../Source/Bind/Specifications/Docs/GL";
        public string DefaultLicenseFile = "License.txt";
        public string DefaultOverridesFile = "GL2/gloverrides.xml";
        public string DefaultLanguageTypeMapFile = "csharp.tm";
        public string DefaultKeywordEscapeCharacter = "@";
        public string DefaultImportsFile = "Core.cs";
        public string DefaultDelegatesFile = "Delegates.cs";
        public string DefaultEnumsFile = "Enums.cs";
        public string DefaultWrappersFile = "GL.cs";
        public Legacy DefaultCompatibility = Legacy.NoDropMultipleTokens;

        string inputPath, outputPath, outputNamespace, docPath, fallbackDocPath, licenseFile, overridesFile,
            languageTypeMapFile, keywordEscapeCharacter, importsFile, delegatesFile, enumsFile,
            wrappersFile;
        Nullable<Legacy> compatibility;
        public string InputPath { get { return inputPath ?? DefaultInputPath; } set { inputPath = value; } }
        public string OutputPath { get { return outputPath ?? DefaultOutputPath; } set { outputPath = value; } }
        public string OutputNamespace { get { return outputNamespace ?? DefaultOutputNamespace; } set { outputNamespace = value; } }
        public string DocPath { get { return docPath ?? DefaultDocPath; } set { docPath = value; } }
        public string FallbackDocPath { get { return fallbackDocPath ?? DefaultFallbackDocPath; } set { fallbackDocPath = value; } }
        public string LicenseFile { get { return licenseFile ?? DefaultLicenseFile; } set { licenseFile = value; } }
        public string OverridesFile { get { return overridesFile ?? DefaultOverridesFile; } set { overridesFile = value; } }
        public string LanguageTypeMapFile { get { return languageTypeMapFile ?? DefaultLanguageTypeMapFile; } set { languageTypeMapFile = value; } }
        public string KeywordEscapeCharacter { get { return keywordEscapeCharacter ?? DefaultKeywordEscapeCharacter; } set { keywordEscapeCharacter = value; } }
        public string ImportsFile { get { return importsFile ?? DefaultImportsFile; } set { importsFile = value; } }
        public string DelegatesFile { get { return delegatesFile ?? DefaultDelegatesFile; } set { delegatesFile = value; } }
        public string EnumsFile { get { return enumsFile ?? DefaultEnumsFile; } set { enumsFile = value; } }
        public string WrappersFile { get { return wrappersFile ?? DefaultWrappersFile; } set { wrappersFile = value; } }
        public Legacy Compatibility { get { return compatibility ?? DefaultCompatibility; } set { compatibility = value; } }

        public string GLClass = "GL";        // Needed by Glu for the AuxEnumsClass. Can be set through -gl:"xxx".
        public string OutputClass = "GL";    // The real output class. Can be set through -class:"xxx".
        public string FunctionPrefix = "gl";
        public string ConstantPrefix = "GL_";
        public string EnumPrefix = "";
        public string NamespaceSeparator = ".";

        // TODO: This code is too fragile.
        // Old enums code:
        public string normalEnumsClassOverride = null;
        public string NestedEnumsClass = "Enums";
        public string NormalEnumsClass
        {
            get
            {
                return
                    normalEnumsClassOverride == null ?
                        String.IsNullOrEmpty(NestedEnumsClass) ? OutputClass : OutputClass + NamespaceSeparator + NestedEnumsClass :
                        normalEnumsClassOverride;
            }
        }
 
        public string AuxEnumsClass 
        {
            get { return GLClass + NamespaceSeparator + NestedEnumsClass; }
        }

        public string EnumsOutput
        {
            get
            {
                if ((Compatibility & Legacy.NestedEnums) != Legacy.None)
                    return OutputNamespace + NamespaceSeparator + OutputClass + NamespaceSeparator + NestedEnumsClass;
                else
                    return String.IsNullOrEmpty(EnumsNamespace) ? OutputNamespace : OutputNamespace + NamespaceSeparator + EnumsNamespace;
            }
        }

        public string EnumsAuxOutput
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
        public string EnumsNamespace = null;// = "Enums";

        public string DelegatesClass = "Delegates";
        public string ImportsClass = "Core";

        /// <summary>
        /// The name of the C# enum which holds every single OpenGL enum (for compatibility purposes).
        /// </summary>
        public string CompleteEnumName = "All";
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
            /// <summary>Use DllImport declaration for core functions (do not generate entry point slots)</summary>
            UseDllImports = 0x4000,
            /// <summary>
            /// Use in conjuction with UseDllImports, to create
            /// bindings that are compatible with opengl32.dll on Windows.
            /// This uses DllImports up to GL 1.1 and function pointers
            /// for higher versions.
            /// </summary>
            UseWindowsCompatibleGL = 0x8000,
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
                  NoDebugHelpers,
            /*GenerateAllPermutations,*/
        }

        // Returns true if flag is enabled.
        public bool IsEnabled(Legacy flag)
        {
            return (Compatibility & flag) != (Legacy)0;
        }

        // Enables the specified flag.
        public void Enable(Legacy flag)
        {
            Compatibility |= flag;
        }

        // Disables the specified flag.
        public void Disable(Legacy flag)
        {
            Compatibility &= ~flag;
        }

        /// <summary>True if multiple tokens should be dropped (e.g. FooARB, FooEXT and FooSGI).</summary>
        public bool DropMultipleTokens
        { 
            get { return (Compatibility & Legacy.NoDropMultipleTokens) == Legacy.None; } 
            set { if (value) Compatibility |= Legacy.NoDropMultipleTokens; else Compatibility &= ~Legacy.NoDropMultipleTokens; }
        }
        
        public string WindowsGDI = "OpenTK.Platform.Windows.API";

        public GeneratorLanguage Language { get; set; }

        public Settings Clone()
        {
            IFormatter formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                return (Settings)formatter.Deserialize(stream);
            }
        }
    }
}
