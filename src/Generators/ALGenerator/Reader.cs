using GeneratorBase.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Reflection;

namespace ALGenerator
{
    internal record DocumentationSource(DocumentationFolder[] Folders) : IDisposable
    {
        public void Dispose()
        {
            foreach (DocumentationFolder folder in Folders)
            {
                folder.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }

    internal record DocumentationFolder(string Folder, FileStream[] Files) : IDisposable
    {
        public void Dispose()
        {
            foreach (FileStream file in Files)
            {
                file.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }

    internal static class Reader
    {
        private static readonly string TempDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "..", "..", "..", "SpecificationFiles");

        private static FileStream ReadFileFromGithub(string url, string filePath)
        {
            string fileName = Path.GetFileName(filePath);

            FileStream stream;
            if (File.Exists(filePath))
            {
                Logger.Info($"Found cache file for {fileName}, using that.");
                stream = File.OpenRead(filePath);
            }
            else
            {
                Logger.Info($"Didn't find cache file for {fileName}, downloading from {url}. (looked for {fileName} in this directory: {Path.GetFullPath(filePath)})");
                if (!Directory.Exists(TempDirectory))
                {
                    Directory.CreateDirectory(TempDirectory);
                }
                stream = CreateCache(url, filePath);
            }

            return stream;
        }

        internal static FileStream ReadALSpecFromGithub()
        {
            string url = "https://raw.githubusercontent.com/NogginBops/OpenAL-EXT-Repository/refs/heads/xml-spec/xml/al.xml";
            string filePath = Path.Combine(TempDirectory, "al.xml");

            return ReadFileFromGithub(url, filePath);
        }

        internal static FileStream ReadALCSpecFromGithub()
        {
            string url = "https://raw.githubusercontent.com/NogginBops/OpenAL-EXT-Repository/refs/heads/xml-spec/xml/alc.xml";
            string filePath = Path.Combine(TempDirectory, "alc.xml");

            return ReadFileFromGithub(url, filePath);
        }

        internal static FileStream ReadEFXPresetsSpecFromGithub()
        {
            string url = "https://raw.githubusercontent.com/NogginBops/OpenAL-EXT-Repository/refs/heads/xml-spec/xml/efx_presets.xml";
            string filePath = Path.Combine(TempDirectory, "efx_presets.xml");

            return ReadFileFromGithub(url, filePath);
        }

        private static FileStream CreateCache(string upstreamUrl, string filePath)
        {
            HttpWebRequest fileRequest = WebRequest.CreateHttp(upstreamUrl);
            WebResponse response = fileRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();

            FileStream fileStream = File.Open(filePath, FileMode.Create, FileAccess.ReadWrite);
            responseStream.CopyTo(fileStream);
            fileStream.Flush();
            fileStream.Position = 0;

            return fileStream;
        }
    }
}
