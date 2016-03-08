// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace OpenTK.Convert
{
    // The base class for a parser.
    abstract class Parser
    {
        // Defines a prefix that should be removed from methods and tokens in the XML files, e.g. "gl", "cl", etc.
        public string Prefix { get; set; }
        
        // Defines the version of the spec files (optional).
        public string Version { get; set; }

        // Implements the parsing logic for a specific input file.
        public abstract IEnumerable<XElement> Parse(string[] lines);

        public IEnumerable<XElement> Parse(string path)
        {
            string[] contents = null;
            if (path.StartsWith("http://") || path.StartsWith("https://"))
            {
                // Download from the specified url into a temporary file
                using (var wb = new WebClient())
                {
                    string filename = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());

                    try
                    {
                        wb.DownloadFile(path, filename);
                    }
                    catch (WebException e)
                    {
                        if (e.Message == "The remote server returned an error: (401) Unauthorized.")
                        {
                            System.Console.WriteLine(e.Message);
                            System.Console.Write("Username: ");
                            string username = System.Console.ReadLine();
                            System.Console.Write("Password: ");
                            string password = System.Console.ReadLine();

                            wb.UseDefaultCredentials = true;
                            wb.Credentials = new NetworkCredential(username, password);
                            wb.DownloadFile(path, filename);
                        }
                    }

                    contents = File.ReadAllLines(filename);
                    File.Delete(filename);
                }
            }
            else
            {
                // The file is on disk, just read it directly
                contents = File.ReadAllLines(path);
            }

            return Parse(contents);
        }
    }
}
