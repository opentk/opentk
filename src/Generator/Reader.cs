using Generator.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Linq;
using System.Reflection;
using System.Net.Http;

namespace Generator
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

        internal static FileStream ReadGLSpecFromGithub()
        {
            string url = "https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/main/xml/gl.xml";
            string filePath = Path.Combine(TempDirectory, "gl.xml");

            return ReadFileFromGithub(url, filePath);
        }

        internal static FileStream ReadWGLSpecFromGithub()
        {
            string url = "https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/main/xml/wgl.xml";
            string filePath = Path.Combine(TempDirectory, "wgl.xml");

            return ReadFileFromGithub(url, filePath);
        }

        internal static FileStream ReadGLXSpecFromGithub()
        {
            string url = "https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/main/xml/glx.xml";
            string filePath = Path.Combine(TempDirectory, "glx.xml");

            return ReadFileFromGithub(url, filePath);
        }

        internal static FileStream ReadEGLSpecFromGithub()
        {
            string url = "https://raw.githubusercontent.com/KhronosGroup/EGL-Registry/refs/heads/main/api/egl.xml";
            string filePath = Path.Combine(TempDirectory, "egl.xml");

            return ReadFileFromGithub(url, filePath);
        }

        internal static FileStream ReadEGLANGLESpecFromFile()
        {
            string filePath = Path.Combine(TempDirectory, "egl_angle_ext.xml");
            return File.OpenRead(filePath);
        }

        internal static DocumentationSource ReadDocumentationFromGithub()
        {
            Path.GetFullPath(TempDirectory);
            string[] DocumentationFolders = new string[]
            {
                "es1.1",
                "es3",
                "gl2.1",
                "gl4",
            };

            DocumentationFolder[] folders = new DocumentationFolder[DocumentationFolders.Length];

            for (int folderIndex = 0; folderIndex < DocumentationFolders.Length; folderIndex++)
            {
                string folderPath = Path.Combine(TempDirectory, DocumentationFolders[folderIndex]);
                if (Directory.Exists(folderPath))
                {
                    Logger.Info($"Found cache folder for {DocumentationFolders[folderIndex]} documentation, using that.");

                    // We already have the files
                    List<FileStream> files = new List<FileStream>();
                    foreach (string file in Directory.EnumerateFiles(folderPath))
                    {
                        FileStream stream = File.OpenRead(file);
                        files.Add(stream);
                    }

                    folders[folderIndex] = new DocumentationFolder(DocumentationFolders[folderIndex], files.ToArray());
                }
                else
                {
                    // We need to download the files
                    Logger.Info($"Didn't find cache folder for {DocumentationFolders[folderIndex]}, downloading from github.");

                    Directory.CreateDirectory(folderPath);

                    string url = $"https://api.github.com/repos/KhronosGroup/OpenGL-Refpages/contents/{DocumentationFolders[folderIndex]}/";


                    HttpWebRequest request = WebRequest.CreateHttp(url);
                    request.Headers.Add("User-Agent: Other");
                    WebResponse response = request.GetResponse();
                    JsonElement json = JsonDocument.Parse(response.GetResponseStream()).RootElement;
                    
                    List<JsonElement> fileInfos = new List<JsonElement>();
                    foreach (JsonElement fileInfo in json.EnumerateArray())
                    {
                        string fileName = fileInfo.GetProperty("name").GetString()!;
                        // Ignore glu and glX files as well as glIntro.xml from es1.1.
                        if (fileName.StartsWith("gl") &&
                            char.IsUpper(fileName[2]) &&
                            fileName[2] != 'X' &&
                            fileName != "glIntro.xml")
                        {
                            fileInfos.Add(fileInfo);
                        }
                    }

                    int numberOfFiles = fileInfos.Count;

                    FileStream[] files = new FileStream[numberOfFiles];
                    for (int fileIndex = 0; fileIndex < numberOfFiles; fileIndex++)
                    {
                        string fileName = fileInfos[fileIndex].GetProperty("name").GetString()!;
                        string fileUrl = fileInfos[fileIndex].GetProperty("download_url").GetString()!;

                        string folderStatus = $"({fileIndex + 1}/{numberOfFiles})";
                        Logger.Info($"{folderStatus:,-8} Downloading {fileName} from {fileUrl}...");

                        string filePath = Path.Combine(folderPath, fileName);
                        FileStream fileStream = CreateCache(fileUrl, filePath);

                        files[fileIndex] = fileStream;
                    }

                    folders[folderIndex] = new DocumentationFolder(DocumentationFolders[folderIndex], files);
                }
            }

            return new DocumentationSource(folders);
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
