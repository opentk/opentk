/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace OpenTK.OpenGL.Bind
{
    static class SpecReader
    {
        #region Read function specs

        public static List<Function> ReadFunctionSpecs(string file)
        {
            List<Function> functions = new List<Function>();

            string path = Path.Combine(Settings.InputPath, file);
            StreamReader sr;

            try
            {
                sr = new StreamReader(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error opening spec file: {0}", path);
                Console.WriteLine("Error: {0}", e.Message);
                throw e;
            }
            Console.WriteLine("Reading function specs from file: {0}", file);

            do
            {
                string line = sr.ReadLine().Trim();

                if (String.IsNullOrEmpty(line) ||
                    line.StartsWith("#") ||  // Disregard comments.
                    line.StartsWith("passthru") ||  // Disregard passthru statements.
                    line.StartsWith("required-props:") ||
                    line.StartsWith("param:") ||
                    line.StartsWith("dlflags:") ||
                    line.StartsWith("glxflags:") ||
                    line.StartsWith("vectorequiv:") ||
                    //line.StartsWith("category:") ||
                    line.StartsWith("version:") ||
                    line.StartsWith("glxsingle:") ||
                    line.StartsWith("glxropcode:") ||
                    line.StartsWith("glxvendorpriv:") ||
                    line.StartsWith("glsflags:") ||
                    line.StartsWith("glsopcode:") ||
                    line.StartsWith("glsalias:") ||
                    line.StartsWith("wglflags:") ||
                    line.StartsWith("extension:") ||
                    line.StartsWith("alias:") ||
                    line.StartsWith("offset:"))
                    continue;

                while (line.Contains("(") && !sr.EndOfStream)
                {
                    Function f = new Function();

                    f.Name = line.Split(Translation.Separators, StringSplitOptions.RemoveEmptyEntries)[0];
                    if (f.Name.EndsWith("ARB") ||
                        f.Name.EndsWith("EXT") ||
                        f.Name.EndsWith("ATI") ||
                        f.Name.EndsWith("NV") ||
                        f.Name.EndsWith("SUN") ||
                        f.Name.EndsWith("SUNX") ||
                        f.Name.EndsWith("SGI") ||
                        f.Name.EndsWith("SGIS") ||
                        f.Name.EndsWith("SGIX") ||
                        f.Name.EndsWith("MESA") ||
                        f.Name.EndsWith("3DFX") ||
                        f.Name.EndsWith("IBM") ||
                        f.Name.EndsWith("GREMEDY") ||
                        f.Name.EndsWith("HP") ||
                        f.Name.EndsWith("INTEL") ||
                        f.Name.EndsWith("PGI") ||
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
                            case "category":
                                f.Category = words[1];
                                break;
                        }
                    }
                    while (!sr.EndOfStream);

                    functions.Add(f);
                }
            }
            while (!sr.EndOfStream);

            return functions;
        }

        #endregion

        #region Read constant specs
        [Obsolete]
        public static List<Constant> ReadConstantSpecs(string file)
        {
            List<Constant> constants = new List<Constant>();

            string path = Path.Combine(Settings.InputPath, file);
            StreamReader sr;

            try
            {
                sr = new StreamReader(path);
            }
            catch (Exception)
            {
                Console.WriteLine("Error opening spec file: {0}", path);
                return null;
            }
            Console.WriteLine("Reading constant specs from file: {0}", file);

            do
            {
                string line = sr.ReadLine().Trim();

                if (String.IsNullOrEmpty(line) ||
                    line.StartsWith("#") ||  // Disregard comments.
                    line.StartsWith("passthru") ||  // Disregard passthru statements.
                    line.StartsWith("required-props:") ||
                    line.StartsWith("param:") ||
                    line.StartsWith("dlflags:") ||
                    line.StartsWith("glxflags:") ||
                    line.StartsWith("vectorequiv:") ||
                    line.StartsWith("category:") ||
                    line.StartsWith("version:") ||
                    line.StartsWith("glxsingle:") ||
                    line.StartsWith("glxropcode:") ||
                    line.StartsWith("glxvendorpriv:") ||
                    line.StartsWith("glsflags:") ||
                    line.StartsWith("glsopcode:") ||
                    line.StartsWith("glsalias:") ||
                    line.StartsWith("wglflags:") ||
                    line.StartsWith("extension:") ||
                    line.StartsWith("alias:") ||
                    line.StartsWith("offset:") ||
                    line.Contains("enum:"))
                    continue;

                line = line.Replace('\t', ' ');

                string[] words = line.Split(Translation.Separators, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length == 0)
                    continue;

                Constant c = new Constant();
                if (line.Contains("="))
                {
                    c.Name = words[0];
                    c.Value = words[2];
                }

                if (!String.IsNullOrEmpty(c.Name) && !ListContainsConstant(constants, c))
                    constants.Add(c);
            }
            while (!sr.EndOfStream);

            return constants;
        }

        public static bool ListContainsConstant(List<Constant> constants, Constant c)
        {
            foreach (Constant d in constants)
                if (d.Name == c.Name)
                    return true;
            return false;
        }

        #endregion

        #region Read enum specs

        public static Hashtable ReadEnumSpecs(string file)
        {
            Hashtable enums = new Hashtable();

            string path = Path.Combine(Settings.InputPath, file);
            StreamReader sr;

            try
            {
                sr = new StreamReader(path);
            }
            catch (Exception)
            {
                Console.WriteLine("Error opening spec file: {0}", path);
                return null;
            }
            Console.WriteLine("Reading enum specs from file: {0}", file);

            do
            {
                string line = sr.ReadLine().Trim();

                if (String.IsNullOrEmpty(line) ||
                    line.StartsWith("#") ||  // Disregard comments.
                    line.StartsWith("passthru") ||  // Disregard passthru statements.
                    line.StartsWith("required-props:") ||
                    line.StartsWith("param:") ||
                    line.StartsWith("dlflags:") ||
                    line.StartsWith("glxflags:") ||
                    line.StartsWith("vectorequiv:") ||
                    line.StartsWith("category:") ||
                    line.StartsWith("version:") ||
                    line.StartsWith("glxsingle:") ||
                    line.StartsWith("glxropcode:") ||
                    line.StartsWith("glxvendorpriv:") ||
                    line.StartsWith("glsflags:") ||
                    line.StartsWith("glsopcode:") ||
                    line.StartsWith("glsalias:") ||
                    line.StartsWith("wglflags:") ||
                    line.StartsWith("extension:") ||
                    line.StartsWith("alias:") ||
                    line.StartsWith("offset:"))
                    continue;

                line = line.Replace('\t', ' ');

                while (line.Contains("enum") && !sr.EndOfStream)
                {
                    string[] words = line.Split(Translation.Separators, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length == 0)
                        continue;

                    Enum e = new Enum();
                    e.Name = words[0];

                    do
                    {
                        line = sr.ReadLine();

                        if (String.IsNullOrEmpty(line) || line.StartsWith("#"))
                            continue;

                        if (line.Contains("enum:") || sr.EndOfStream)
                            break;

                        line = line.Replace('\t', ' ');

                        words = line.Split(Translation.Separators, StringSplitOptions.RemoveEmptyEntries);

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

                    if (enums.ContainsKey(e.Name))
                    {
                        //Merge keys:
                        foreach (Constant c in e.ConstantCollection.Values)
                        {
                            if (!((Enum)enums[e.Name]).ConstantCollection.ContainsKey(c.Name))
                                ((Enum)enums[e.Name]).ConstantCollection.Add(c.Name, c);
                        }
                    }
                    else
                        enums.Add(e.Name, e);
                }
            }
            while (!sr.EndOfStream);

            return enums;
        }

        #endregion

        #region Read type map

        public static Dictionary<string, string> ReadTypeMap(string file)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();

            string path = Path.Combine(Settings.InputPath, file);
            StreamReader sr;

            try
            {
                sr = new StreamReader(path);
            }
            catch (Exception)
            {
                Console.WriteLine("Error opening typemap file: {0}", path);
                return null;
            }
            Console.WriteLine("Reading typemaps from file: {0}", file);

            do
            {
                string line = sr.ReadLine();

                if (String.IsNullOrEmpty(line) || line.StartsWith("#"))
                    continue;

                string[] words = line.Split(new char[] { ' ', ',', '*', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (words[0] == "void")             // Special case for "void" -> ""
                    map.Add("void", String.Empty);
                else if (words[0] == "VoidPointer") // Special case for "VoidPointer" -> "GLvoid*"
                    map.Add("VoidPointer", "IntPtr");
                else if (words[0] == "CharPointer")
                    map.Add("CharPointer", "string");
                else
                    map.Add(words[0], words[1]);
            }
            while (!sr.EndOfStream);

            return map;
        }

        #endregion
    }
}
