using VkGenerator.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Linq;
using System.Reflection;

namespace VkGenerator
{
    public record DocumentationSource(DocumentationFolder[] Folders) : IDisposable
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

    public record DocumentationFolder(string Folder, FileStream[] Files) : IDisposable
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

    public static class Reader
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

        public static FileStream ReadVKSpecFromGithub()
        {
            string url = "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/main/xml/vk.xml";
            string filePath = Path.Combine(TempDirectory, "vk.xml");

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
