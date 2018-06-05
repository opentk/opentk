/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bind
{
    [Serializable]
    internal class Settings
    {
        public Settings()
        {
            OverridesFiles = new List<string>();
        }

        public string DefaultInputPath = "src/Generator.Bind/Specifications";
        public string DefaultOutputPath = "src/OpenTK/Graphics/OpenGL";
        public string DefaultOutputNamespace = "OpenTK.Graphics.OpenGL";
        public string DefaultDocPath = "src/Generator.Bind/Specifications/Docs";
        public string DefaultFallbackDocPath = "src/Generator.Bind/Specifications/Docs/GL";
        public string DefaultLicenseFile = "License.txt";
        public string DefaultLanguageTypeMapFile = "csharp.tm";
        public string DefaultKeywordEscapeCharacter = "@";
        public string DefaultImportsFile = "Core.cs";
        public string DefaultDelegatesFile = "Delegates.cs";
        public string DefaultEnumsFile = "Enums.cs";
        public string DefaultWrappersFile = "GL.cs";

        private string inputPath, outputPath, outputNamespace, docPath, fallbackDocPath, licenseFile,
            languageTypeMapFile, keywordEscapeCharacter, importsFile, delegatesFile, enumsFile,
            wrappersFile;

        public string InputPath { get { return inputPath ?? DefaultInputPath; } set { inputPath = value; } }
        public string OutputPath { get { return outputPath ?? DefaultOutputPath; } set { outputPath = value; } }
        public string OutputNamespace { get { return outputNamespace ?? DefaultOutputNamespace; } set { outputNamespace = value; } }
        public string DocPath { get { return docPath ?? DefaultDocPath; } set { docPath = value; } }
        public string FallbackDocPath { get { return fallbackDocPath ?? DefaultFallbackDocPath; } set { fallbackDocPath = value; } }
        public string LicenseFile { get { return licenseFile ?? DefaultLicenseFile; } set { licenseFile = value; } }
        public List<string> OverridesFiles { get; private set; }
        public string LanguageTypeMapFile { get { return languageTypeMapFile ?? DefaultLanguageTypeMapFile; } set { languageTypeMapFile = value; } }
        public string KeywordEscapeCharacter { get { return keywordEscapeCharacter ?? DefaultKeywordEscapeCharacter; } set { keywordEscapeCharacter = value; } }
        public string ImportsFile { get { return importsFile ?? DefaultImportsFile; } set { importsFile = value; } }
        public string DelegatesFile { get { return delegatesFile ?? DefaultDelegatesFile; } set { delegatesFile = value; } }
        public string EnumsFile { get { return enumsFile ?? DefaultEnumsFile; } set { enumsFile = value; } }
        public string WrappersFile { get { return wrappersFile ?? DefaultWrappersFile; } set { wrappersFile = value; } }

        public string OutputClass = "GL";    // The real output class. Can be set through -class:"xxx".
        public string FunctionPrefix = "gl";
        public string ConstantPrefix = "GL_";
        public string NamespaceSeparator = ".";

        public string EnumsOutput
        {
            get
            {
                return String.IsNullOrEmpty(EnumsNamespace) ? OutputNamespace : OutputNamespace + NamespaceSeparator + EnumsNamespace;
            }
        }

        // New enums namespace (don't use a nested class).
        public string EnumsNamespace = null; // = "Enums";

        public string DelegatesClass = "Delegates";
        public string ImportsClass = "Core";

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
