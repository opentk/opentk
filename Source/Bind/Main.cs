#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text.RegularExpressions;
using Bind.CL;
using Bind.ES;
using Bind.GL2;

namespace Bind
{
    enum GeneratorLanguage
    {
        CSharp,
        Cpp,
        Java
    }

    static class MainClass
    {
        static internal List<IBind> Generators = new List<IBind>();
        static Settings Settings = new Settings();

        static void Main(string[] arguments)
        {
            Debug.Listeners.Clear();
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.AutoFlush = true;
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.AutoFlush = true;

            Console.WriteLine("OpenGL binding generator {0} for OpenTK.",
                Assembly.GetExecutingAssembly().GetName().Version.ToString());
            Console.WriteLine("http://www.opentk.com");
            Console.WriteLine();

            string dirName =  null;

            try
            {
                var split = new Regex(@"-\w+", RegexOptions.Compiled);
                foreach (var argument in arguments)
                {
                    string a = argument.Replace("--", "-").Trim();
                    var match = split.Match(a);
                    if (match.Success)
                    {
                        string opt = match.Value.Substring(1).Trim();
                        string val = a.Substring(match.Value.Length + 1).Trim();
                        switch (opt)
                        {
                            case "?":
                            case "help":
                                ShowHelp();
                                return;
                            case "in":
                            case "input":
                                Settings.InputPath = val;
                                break;
                            case "out":
                            case "output":
                                Settings.OutputPath = val;
                                break;
                            case "l":
                            case "lang":
                            case "language":
                                {
                                    string arg = val.ToLower();
                                    if (arg == "cpp" || arg == "c++" || arg == "c")
                                    {
                                        Settings.Language = GeneratorLanguage.Cpp;
                                        Settings.DefaultOutputPath = "gl";
                                        Settings.DefaultOutputNamespace = "OpenTK";
                                        // Settings.DefaultLanguageTypeMapFile = "cpp.tm"; // Todo: create this file!
                                        Settings.EnumsNamespace = "";
                                        Settings.NamespaceSeparator = "::";
                                        Settings.DefaultKeywordEscapeCharacter = "_";
                                    }
                                    else if (arg == "java")
                                    {
                                        Settings.Language = GeneratorLanguage.Java;
                                        Settings.DefaultOutputPath = "gl";
                                        Settings.DefaultOutputNamespace = "com.opentk";
                                        Settings.DefaultLanguageTypeMapFile = "java.tm";
                                        Settings.EnumsNamespace = "";
                                        Settings.NamespaceSeparator = ".";
                                        Settings.DefaultKeywordEscapeCharacter = "_";
                                    }
                                    break;
                                }
                            case "mode":
                                {
                                    foreach (var arg in val.ToLower().Split(','))
                                    {
                                        EnableGenerator(dirName, arg);
                                    }
                                    break;
                                }
                            case "namespace":
                            case "ns":
                                Settings.OutputNamespace = val;
                                break;
                            case "class":
                                Settings.OutputClass = val;
                                break;
                            case "gl":
                                Settings.GLClass = val;
                                break;
                            case "legacy":
                            case "o":
                            case "option":
                            {
                                val = val.ToLower();
                                bool enable = !opt.StartsWith("-");
                                if (val.StartsWith("+") || val.StartsWith("-"))
                                    val = val.Substring(1);

                                var settings = Settings.Legacy.None;
                                switch (val)
                                {
                                    case "tao": settings |= Settings.Legacy.Tao; break;
                                    case "simple_enums": settings |= Settings.Legacy.NoAdvancedEnumProcessing; break;
                                    case "safe": settings |= Settings.Legacy.NoPublicUnsafeFunctions; break;
                                    case "permutations": settings |= Settings.Legacy.GenerateAllPermutations; break;
                                    case "enums_in_class": settings |= Settings.Legacy.NestedEnums; break;
                                    case "nodocs": settings |= Settings.Legacy.NoDocumentation; break;
                                    case "keep_untyped_enums": settings |= Settings.Legacy.KeepUntypedEnums; break;
                                }

                                if (enable)
                                {
                                    Settings.Compatibility |= settings;
                                }
                                else
                                {
                                    Settings.Compatibility &= ~settings;
                                }

                                break;
                            }
                            default:
                                throw new ArgumentException(
                                    String.Format("Argument {0} not recognized. Use the '/?' switch for help.", a)
                                );
                        }
                    }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Argument error ({0}). Please use the '-?' switch for help.", e.ToString());
                return;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument error ({0}). Please use the '-?' switch for help.", e.ToString());
                return;
            }

            try
            {
                foreach (var generator in Generators)
                {
                    Console.WriteLine("Executing {0}", generator.GetType());

                    long ticks = DateTime.Now.Ticks;

                    generator.Process();

                    ISpecWriter writer = null;
                    switch (generator.Settings.Language)
                    {
                        case GeneratorLanguage.Cpp:
                            writer = new CppSpecWriter();
                            break;

                        case GeneratorLanguage.Java:
                            writer = new JavaSpecWriter();
                            break;

                        case GeneratorLanguage.CSharp:
                        default:
                            writer = new CSharpSpecWriter();
                            break;
                    }
                    writer.WriteBindings(generator);

                    ticks = DateTime.Now.Ticks - ticks;

                    Console.WriteLine();
                    Console.WriteLine("Bindings generated in {0} seconds.", ticks / (double)10000000.0);
                }
                
                Console.WriteLine();
                if (Debugger.IsAttached)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                }
            }
            catch (SecurityException e)
            {
                Console.WriteLine("Security violation \"{0}\" in method \"{1}\".", e.Message, e.Method);
                Console.WriteLine("This application does not have permission to take the requested actions.");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The requested functionality is not implemented yet.");
            }
        }

        static void EnableGenerator(string dirName, string arg)
        {
            switch (arg)
            {
                case "all":
                    {
                        Console.WriteLine("Using 'all' generator mode.");
                        Console.WriteLine("Use '-mode:all/gl2/gl4/es10/es11/es20/es30' to select a specific mode.");

                        var desktop = Settings.Clone();
                        Generators.Add(new GL2Generator(desktop, dirName));
                        Generators.Add(new GL4Generator(desktop, dirName));
                        Generators.Add(new ES11Generator(desktop, dirName));
                        Generators.Add(new ES20Generator(desktop, dirName));
                        Generators.Add(new ES30Generator(desktop, dirName));
                        Generators.Add(new CLGenerator(desktop, dirName));
                        Generators.Add(new CL12Generator(desktop, dirName));
                        Generators.Add(new CL20Generator(desktop, dirName));

                        /* Temporarily disabled
                        var android = Settings.Clone();
                        android.Compatibility |= Settings.Legacy.UseDllImports;
                        android.DefaultOutputPath += ".Android";
                        Generators.Add(new ESGenerator(android, dirName));
                        Generators.Add(new ES2Generator(android, dirName));
                        Generators.Add(new ES3Generator(android, dirName));

                        var ios = Settings.Clone();
                        ios.Compatibility |= Settings.Legacy.ForceDllImports;
                        ios.DefaultOutputPath += ".iPhone";
                        Generators.Add(new ESGenerator(ios, dirName));
                        Generators.Add(new ES2Generator(ios, dirName));
                        Generators.Add(new ES3Generator(ios, dirName));
                        */
                    }
                    break;
                
                case "gl":
                    Generators.Add(new GL2Generator(Settings.Clone(), dirName));
                    Generators.Add(new GL4Generator(Settings.Clone(), dirName));
                    break;

                case "gl2":
                    Generators.Add(new GL2Generator(Settings.Clone(), dirName));
                    break;

                case "gl4":
                    Generators.Add(new GL4Generator(Settings.Clone(), dirName));
                    break;

                case "es":
                    Generators.Add(new ES10Generator(Settings.Clone(), dirName));
                    Generators.Add(new ES11Generator(Settings.Clone(), dirName));
                    Generators.Add(new ES20Generator(Settings.Clone(), dirName));
                    Generators.Add(new ES30Generator(Settings.Clone(), dirName));
                    break;

                case "es10":
                    Generators.Add(new ES10Generator(Settings.Clone(), dirName));
                    break;

                case "es11":
                    Generators.Add(new ES11Generator(Settings.Clone(), dirName));
                    break;

                case "es20":
                    Generators.Add(new ES20Generator(Settings.Clone(), dirName));
                    break;

                case "es30":
                    Generators.Add(new ES30Generator(Settings.Clone(), dirName));
                    break;

                case "cl":
                    Generators.Add(new CLGenerator(Settings.Clone(), dirName));
                    Generators.Add(new CL11Generator(Settings.Clone(), dirName));
                    Generators.Add(new CL12Generator(Settings.Clone(), dirName));
                    Generators.Add(new CL20Generator(Settings.Clone(), dirName));
                    break;

                case "cl10":
                    Generators.Add(new CLGenerator(Settings.Clone(), dirName));
                    break;

                case "cl11":
                    Generators.Add(new CL11Generator(Settings.Clone(), dirName));
                    break;

                case "cl12":
                    Generators.Add(new CL12Generator(Settings.Clone(), dirName));
                    break;

                case "cl20":
                    Generators.Add(new CL20Generator(Settings.Clone(), dirName));
                    break;

                default:
                    throw new NotSupportedException();
            }
        }

        private static void ShowHelp()
        {
            Console.WriteLine(
@"Usage: bind [-in:path] [-out:path] [switches]
Available switches:
-in:         Input directory (e.g. -in:../specs/)
-out:        Output directory (e.g. -out:out)
-ns:         Output namespace (e.g. -ns:OpenTK.Graphics).
             Default: OpenTK.Graphics.OpenGL
-namespace:  Same as -ns
-class:      Output class (e.g. -class:GL3).
             Default: GL/Wgl/Glu/Glx (depends on -mode)
-mode:       Generator mode (e.g. -mode:gl4).
             Default: all
             Accepted: all/gl2/gl4/es10/es11/es20
-o/-option:  Set advanced option. Available options:
    -o:tao   Tao compatibility mode.
    -o:enums Follow OpenGL instead .Net naming conventions.
    -o:safe  Do not generate public unsafe functions.
    -o:enums_in_class
             Place enums in a nested class (i.e. GL.Enums)
             instead of a namespace (i.e. OpenTK.Graphics.OpenGL.Enums)
");
        }
    }
}
