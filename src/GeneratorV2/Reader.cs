using System;
using System.IO;
using System.Net;

namespace GeneratorV2
{
    public static class Reader
    {
        public static Stream ReadSpecFromGithub()
        {
            var link = "https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml";
            Logger.Info($"Beggining to download openGL spec from {link}");
            var request = HttpWebRequest.CreateHttp(link);
            Logger.Info($"File downloaded.");

            var response = request.GetResponse();
            return response.GetResponseStream();
        }
    }
}
