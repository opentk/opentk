/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OpenTK.OpenGL.Bind
{
    partial class Process 
    {
        public void WriteEnums(string output_path)
        {
            if (!Directory.Exists(output_path))
                Directory.CreateDirectory(output_path);

            StreamWriter sw = new StreamWriter(Path.Combine(output_path, "GLConstants.cs"), false);

            Console.WriteLine("Writing opengl constants to: {0}", output_path);

            sw.WriteLine("using System;");
            sw.WriteLine();
            sw.WriteLine("namespace {0}", Properties.Bind.Default.OutputNamespace);
            sw.WriteLine("{");
            sw.WriteLine("    public static class Enums");
            sw.WriteLine("    {");

            WriteMissingConstants(sw);
            
            sw.WriteLine("        #region OpenGL enums");
            sw.WriteLine();

            foreach (Enum e in EnumCollection.Values)
            {
                sw.WriteLine(e.ToString());
            }

            sw.WriteLine();
            sw.WriteLine("        #endregion");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.WriteLine();

            sw.Flush();
            sw.Close();
        }

        private void WriteMissingConstants(StreamWriter sw)
        {
            sw.WriteLine("        #region Missing Constants");
            sw.WriteLine();

            // Version 1.4 enum
            sw.WriteLine("        const uint GL_FOG_COORDINATE_SOURCE = 0x8450;");
            sw.WriteLine("        const uint GL_FOG_COORDINATE = 0x8451;");
            sw.WriteLine("        const uint GL_CURRENT_FOG_COORDINATE = 0x8453;");
            sw.WriteLine("        const uint GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454;");
            sw.WriteLine("        const uint GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455;");
            sw.WriteLine("        const uint GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456;");
            sw.WriteLine("        const uint GL_FOG_COORDINATE_ARRAY = 0x8457;");

            // Version 1.5 enum
            sw.WriteLine("        const uint GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;");

            // Version 1.3 enum
            sw.WriteLine("        const uint GL_SOURCE0_RGB = 0x8580;");
            sw.WriteLine("        const uint GL_SOURCE1_RGB = 0x8581;");
            sw.WriteLine("        const uint GL_SOURCE2_RGB = 0x8582;");
            sw.WriteLine("        const uint GL_SOURCE0_ALPHA = 0x8588;");
            sw.WriteLine("        const uint GL_SOURCE1_ALPHA = 0x8589;");
            sw.WriteLine("        const uint GL_SOURCE2_ALPHA = 0x858A;");

            // Version 2.0 enum
            sw.WriteLine("        const uint GL_BLEND_EQUATION = 0x8009;");

            sw.WriteLine("        const uint GL_MODELVIEW_MATRIX = 0x0BA6;");
            sw.WriteLine("        const uint GL_MODELVIEW = 0x1700;");
            sw.WriteLine("        const uint GL_MODELVIEW_STACK_DEPTH = 0x0BA3;");

            // NV_texture_shader enum
            sw.WriteLine("        const uint GL_OFFSET_TEXTURE_MATRIX_NV = 0x86E1;");
            sw.WriteLine("        const uint GL_OFFSET_TEXTURE_SCALE_NV = 0x86E2;");
            sw.WriteLine("        const uint GL_OFFSET_TEXTURE_BIAS_NV = 0x86E3;");

            sw.WriteLine();
            sw.WriteLine("        #endregion");
            sw.WriteLine();
        }
    }
}
