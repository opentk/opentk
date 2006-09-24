/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

/* There are several errors in the spec files.
 * enum.spec:
 * A missing "#" to comment out a constant for a commented-out SGI extension (inoffensive, but erroneous nonetheless).
 * Uses LightProperty instead of the correct LightParameter.
 * References the commented out SGIX_icc_texture enum.
 * 
 * enumext.spec
 * The renaming scheme for the 2.0 version (e.g. SRC_ALPHA2 instead of SOURCE_ALPHA2) references the GL_* versions
 * instead of the * which will break when a generator does not add the GL_ prefix. Moreover these reside in different enums
 * so the reference will only work for the C preprocessor. As a workaround I added the missing constants outside of any enum.
 */

namespace OpenTK.OpenGL.Bind
{
    public partial class Process
    {
        void ReadSpecs(string specfile)
        {
            string path = Path.Combine(Properties.Bind.Default.InputPath, specfile);
            StreamReader sr;
            try
            {
                sr = new StreamReader(path);
            }
            catch (Exception)
            {
                Console.WriteLine("Error opening spec file: {0}", path);
                return;
            }
            Console.WriteLine("Reading specs from: {0}", specfile);

            do
            {
                string line = sr.ReadLine().Trim();

                if (String.IsNullOrEmpty(line)  ||
                    line.StartsWith("#")        ||  // Disregard comments.
                    line.StartsWith("passthru") ||  // Disregard passthru statements.
                    line.StartsWith("required-props:") ||
                    line.StartsWith("param:")   ||
                    line.StartsWith("dlflags:")   ||
                    line.StartsWith("glxflags:")   ||
                    line.StartsWith("vectorequiv:")   ||
                    line.StartsWith("category:")   ||
                    line.StartsWith("version:")   ||
                    line.StartsWith("glxsingle:")   ||
                    line.StartsWith("glxropcode:")   ||
                    line.StartsWith("glxvendorpriv:")   ||
                    line.StartsWith("glsflags:")   ||
                    line.StartsWith("glsopcode:")   ||
                    line.StartsWith("glsalias:")   ||
                    line.StartsWith("wglflags:")   ||
                    line.StartsWith("extension:")   ||
                    line.StartsWith("alias:")   ||
                    line.StartsWith("offset:"))
                    continue;

                while (line.Contains("(") && !sr.EndOfStream)
                    //complete_block.Functions.Add(ReadFunction(sr, line));
                    FunctionCollection.Add(ReadFunction(sr, ref line));

                while (line.Contains("enum") && !sr.EndOfStream)
                {
                    Enum e = ReadEnum(sr, ref line);
                    if (EnumCollection.ContainsKey(e.Name))
                    {
                        //Merge keys:
                        foreach (Constant c in e.ConstantCollection.Values)
                        {
                            if (!((Enum)EnumCollection[e.Name]).ConstantCollection.ContainsKey(c.Name))
                                ((Enum)EnumCollection[e.Name]).ConstantCollection.Add(c.Name, c);
                        }
                    }
                    else
                        EnumCollection.Add(e.Name, e);
                }
//                    EnumCollection.Add(ReadEnum(sr, ref line));

                
            }
            while (!sr.EndOfStream);
        }

        #region Read enumeration function

        private Enum ReadEnum(StreamReader sr, ref string line)
        {
            Enum e = new Enum();

            e.Name = line.Split(Translation.Separators, StringSplitOptions.RemoveEmptyEntries)[0];

            do
            {
                line = sr.ReadLine();

                if (String.IsNullOrEmpty(line) || line.StartsWith("#"))
                    continue;

                if (line.Contains("enum:") || sr.EndOfStream)
                    break;
                
                line = line.Replace('\t', ' ');

                string[] words = line.Split(Translation.Separators, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length == 0)
                    continue;

                Constant c = new Constant();
                if (words[0] == "use")
                {
                    c.Name = words[2];
                    c.Value = words[1] + "." + words[2];
                }

                if (line.Contains("="))
                {
                    c.Name = words[0];
                    c.Value = words[2];
                }
                
                if (!String.IsNullOrEmpty(c.Name) && !e.ConstantCollection.ContainsKey(c.Name))
                    e.ConstantCollection.Add(c.Name, c);
            }
            while (!sr.EndOfStream);

            return e;
        }

        #endregion

        #region Read function function

        Function ReadFunction(StreamReader sr, ref string line)
        {
            Function f = new Function();

            //string line = sr.ReadLine();
            f.Name = line.Split(Translation.Separators, StringSplitOptions.RemoveEmptyEntries)[0];
            if (f.Name.EndsWith("ARB")  ||
                f.Name.EndsWith("EXT")  ||
                f.Name.EndsWith("ATI")  ||
                f.Name.EndsWith("NV")   ||
                f.Name.EndsWith("SUN")  ||
                f.Name.EndsWith("SUNX") ||
                f.Name.EndsWith("SGI")  ||
                f.Name.EndsWith("SGIS") ||
                f.Name.EndsWith("SGIX") ||
                f.Name.EndsWith("MESA") ||
                f.Name.EndsWith("3DFX") ||
                f.Name.EndsWith("IBM")  ||
                f.Name.EndsWith("GREMEDY")  ||
                f.Name.EndsWith("HP")   ||
                f.Name.EndsWith("INTEL")    ||
                f.Name.EndsWith("PGI")  ||
                f.Name.EndsWith("INGR") ||
                f.Name.EndsWith("APPLE"))
                f.Extension = true;

            do
            {
                line = sr.ReadLine();
                line = line.Replace('\t', ' ');

                string[] words = line.Split(Translation.Separators, StringSplitOptions.RemoveEmptyEntries);

                if (String.IsNullOrEmpty(line) || words.Length == 0)
                    break;

                switch (words[0])
                {
                    case "return":
                        f.ReturnValue = words[1];
                        break;
                    case "param":
                        Parameter p = new Parameter();
                        p.Name = words[1];
                        p.Flow = words[3] == "in" ? Parameter.FlowDirection.In : Parameter.FlowDirection.Out;
                        p.Type = words[2];
                        if (words[4] == "array")
                            p.Array = true;
                        f.Parameters.Add(p);
                        break;
                    case "version":
                        f.Version = words[1];
                        break;
                }
            }
            while (!sr.EndOfStream);

            return f;
        }

        #endregion
    }
}
