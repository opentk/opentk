using System;
using System.IO;
using System.Net;

namespace OpenToolkit.Generator
{
    public static class Reader
    {
        public static string ReadSpecFromGithub()
        {

            var link = "https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml";
            try
            {
                Logger.Info($"Beggining to download openGL spec from {link}");
                var request =
                    HttpWebRequest.CreateHttp(
                        "https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml");
                Logger.Info($"File downloaded.");
                var response = request.GetResponse();
                var stream = new StreamReader(response.GetResponseStream() ?? throw new Exception("Response stream is not initialized"));

                var file = stream.ReadToEnd();

                stream.Dispose();

                return file;
            }
            catch (Exception e)
            {
                Logger.Fatal($"Failed to download gl spec from link \"{link}\"");
                throw;
            }
        }
    }
}
