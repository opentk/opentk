using Generator.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Linq;

namespace Generator
{
    public static class Reader
    {
        static readonly string TempDirectory = Path.Combine(".", "GeneratorFiles");

        // Fixme: file stream + caching
        public static Stream ReadSpecFromGithub()
        {
            var link = "https://raw.githubusercontent.com/frederikja163/OpenGL-Registry/otk5/xml/gl.xml";
            Logger.Info($"Beginning to download openGL spec from {link}");
            var request = WebRequest.CreateHttp(link);
            
            var response = request.GetResponse();
            return response.GetResponseStream();
        }

        public record DocumentationFolder(string Folder, FileStream[] Files);

        // FIXME: Better type!
        public static DocumentationFolder[] ReadDocumentationFromGithub()
        {
            string[] DocumentationFolders = new string[]
            {
                "es1.1",
                "es3",
                "gl2.1",
                "gl4",
            };

            DocumentationFolder[] results = new DocumentationFolder[DocumentationFolders.Length];

            for (int folderIndex = 0; folderIndex < DocumentationFolders.Length; folderIndex++)
            {
                string folderPath = Path.Combine(TempDirectory, DocumentationFolders[folderIndex]);
                if (Directory.Exists(folderPath))
                {
                    Logger.Info($"Found cache folder for {DocumentationFolders[folderIndex]} documentation, using that.");

                    // We already have the files
                    List<FileStream> files = new List<FileStream>();
                    foreach (var file in Directory.EnumerateFiles(folderPath))
                    {
                        FileStream stream = File.OpenRead(file);
                        files.Add(stream);
                    }

                    results[folderIndex] = new DocumentationFolder(DocumentationFolders[folderIndex], files.ToArray());
                }
                else
                {
                    // We need to download the files
                    Logger.Info($"Didn't find cache folder for {DocumentationFolders[folderIndex]}, downloading fron github.");

                    Directory.CreateDirectory(folderPath);

                    string url = $"https://api.github.com/repos/KhronosGroup/OpenGL-Refpages/contents/{DocumentationFolders[folderIndex]}/";

                    var request = WebRequest.CreateHttp(url);
                    request.Headers.Add("User-Agent: Other");
                    var response = request.GetResponse();
                    JsonElement json = JsonDocument.Parse(response.GetResponseStream()).RootElement;
                    
                    List<JsonElement> fileInfos = new List<JsonElement>();
                    foreach (var fileInfo in json.EnumerateArray())
                    {
                        string fileName = fileInfo.GetProperty("name").GetString()!;
                        if (fileName.StartsWith("gl") && fileName.StartsWith("gl_") == false)
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

                        Logger.Info($"{$"({fileIndex+1}/{numberOfFiles})":,-8}Downloading {fileName} from {fileUrl}...");

                        var fileRequest = WebRequest.CreateHttp(fileUrl);
                        var fileResponse = fileRequest.GetResponse();
                        string filePath = Path.Combine(folderPath, fileName);
                        FileStream fileStream = File.Open(filePath, FileMode.Create, FileAccess.ReadWrite);
                        fileResponse.GetResponseStream().CopyTo(fileStream);
                        fileStream.Flush();
                        fileStream.Position = 0;

                        files[fileIndex] = fileStream;
                    }

                    results[folderIndex] = new DocumentationFolder(DocumentationFolders[folderIndex], files);
                }
            }

            return results;
        }
    }
}
