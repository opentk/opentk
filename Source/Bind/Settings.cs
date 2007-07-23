#region License
//Copyright (c) 2006 Stefanos Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.OpenGL.Bind
{
    static class Settings
    {
        public static string InputPath = "..\\..\\..\\Source\\OpenGL\\Specifications";
        public static string OutputPath = "..\\..\\..\\Source\\OpenGL\\OpenGL\\Bindings";
        public static string OutputNamespace = "OpenTK.OpenGL";
        public static string GLClass = "GL";
        public static string WglClass = "Wgl";
        public static string GlxClass = "Glx";
        public static string GluClass = "Glu";

        public static string GLFunctionPrepend = String.Empty;
    }
}
