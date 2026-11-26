using AngleSharp.Html.Dom;
using GeneratorBase.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;

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

    internal record DocumentationFolder(string Folder, FunctionFile[] FunctionFiles) : IDisposable
    {
        public void Dispose()
        {
            foreach (var file in FunctionFiles)
            {
                file.File.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }

    internal record FunctionFile(string FunctionName, FileStream File);

    internal static class Reader
    {
        private static readonly string SpecificationFilesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "..", "..", "..", "SpecificationFiles");

        private static string ReadFileFromUrl(string url, string fileName)
        {
            string filePath = Path.Combine(SpecificationFilesDirectory, fileName);
            if (File.Exists(filePath))
            {
                Logger.Info($"Found cache file for {fileName}, using that.");
                return filePath;
            }
            else
            {
                Logger.Info($"Didn't find cache file for {fileName}, downloading from {url}. (looked for {fileName} in this directory: {Path.GetFullPath(filePath)})");
                if (!Directory.Exists(SpecificationFilesDirectory))
                {
                    Directory.CreateDirectory(SpecificationFilesDirectory);
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

        internal static DocumentationSource ReadDocumentationFromRefPages()
        {
            string folderPath = Path.Combine(SpecificationFilesDirectory, "cl");
            if (Directory.Exists(folderPath))
            {
                Logger.Info($"Found cache folder for cl documentation, using that.");

                List<FunctionFile> files = new List<FunctionFile>();
                foreach (var file in Directory.EnumerateFiles(folderPath))
                {
                    FileStream stream = File.OpenRead(file);
                    files.Add(new FunctionFile(Path.GetFileNameWithoutExtension(file), stream));
                }

                return new DocumentationSource([new DocumentationFolder("cl", files.ToArray())]);
            }
            else
            {
                Logger.Info($"Didn't find cache folder for cl, downloading from OpenCL refpages.");

                Directory.CreateDirectory(folderPath);

                HttpWebRequest request = WebRequest.CreateHttp("https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/toc.html");
                request.Headers.Add("User-Agent: Other");
                WebResponse response = request.GetResponse();

                var htmlParser = new AngleSharp.Html.Parser.HtmlParser();
                string text = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var toc = htmlParser.ParseDocument(text);
                var li = toc.QuerySelector("ul#containerul > li:nth-child(2)")!;
                Debug.Assert(li.InnerHtml.StartsWith("Alphabetic Contents"));

                var tocLinks = li.QuerySelectorAll("ul li ul li a");

                List<(string Function, string File)> functionFiles = new List<(string Function, string File)>();
                foreach (var tocLink in tocLinks)
                {
                    if (tocLink is not IHtmlAnchorElement anchor)
                        throw new Exception("Expected anchor element.");

                    string fileName = anchor.GetAttribute("href")!;
                    string functionName = anchor.InnerHtml;

                    if (fileName.StartsWith("cl") && fileName.Length > 3 && char.IsAsciiLetterUpper(fileName[2]))
                    {
                        functionFiles.Add((functionName, fileName));
                    }
                }

                int numberOfFunctions = functionFiles.Count;
                FunctionFile[] functions = new FunctionFile[numberOfFunctions];
                for (int functionIndex = 0; functionIndex < numberOfFunctions; functionIndex++)
                {
                    var (functionName, fileName) = functionFiles[functionIndex];
                    string fileUrl = $"https://registry.khronos.org/OpenCL/specs/unified/refpages/man/html/{fileName}";

                    string folderStatus = $"({functionIndex + 1}/{numberOfFunctions})";
                    Logger.Info($"{folderStatus:,-8} Downloading {fileName} from {fileUrl}...");

                    string filePath = Path.Combine(folderPath,  functionName + ".html");
                    FileStream fileStream = CreateCache(fileUrl, filePath);

                    functions[functionIndex] = new FunctionFile(functionName, fileStream);
                }

                return new DocumentationSource([new DocumentationFolder("cl", functions)]);
            }
        }

        private static FileStream CreateCache(string upstreamUrl, string filePath)
        {
            HttpWebRequest fileRequest = WebRequest.CreateHttp(upstreamUrl);
            fileRequest.Headers.Add("User-Agent: Other");
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
