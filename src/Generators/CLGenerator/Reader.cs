using GeneratorBase.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Reflection;
using System.Net.Http;
using System.Linq.Expressions;

namespace CLGenerator
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

        private static string ReadFileFromUrl(string url, string fileName)
        {
            string filePath = Path.Combine(TempDirectory, fileName);
            if (File.Exists(filePath))
            {
                Logger.Info($"Found cache file for {fileName}, using that.");
                return filePath;
            }
            else
            {
                Logger.Info($"Didn't find cache file for {fileName}, downloading from {url}. (looked for {fileName} in this directory: {Path.GetFullPath(filePath)})");
                if (!Directory.Exists(TempDirectory))
                {
                    Directory.CreateDirectory(TempDirectory);
                }

                HttpClient client = new HttpClient();
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, url);
                HttpResponseMessage response = client.Send(message, HttpCompletionOption.ResponseContentRead);
                response.EnsureSuccessStatusCode();

                using (var file = File.Open(filePath, FileMode.Create, FileAccess.Write))
                    response.Content.ReadAsStream().CopyTo(file);
                return filePath;
            }
        }

        internal static FileStream ReadCLSpecFromGithub()
        {
            string url = "https://raw.githubusercontent.com/KhronosGroup/OpenCL-Docs/refs/heads/main/xml/cl.xml";
            string filePath = ReadFileFromUrl(url, "cl.xml");
            return File.OpenRead(filePath);
        }
    }
}
