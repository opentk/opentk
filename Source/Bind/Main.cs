#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using Bind.CL;
using Bind.ES;
using Bind.GL2;
using System.Text.RegularExpressions;

namespace Bind
{
    enum GeneratorMode
    {
        Unknown,
        GL2,
        GL3,
        ES10,
        ES11,
        ES20,
        CL10,
    }

    enum GeneratorLanguage
    {
        CSharp,
        Cpp,
        Java
    }

    static class MainClass
    {
        static GeneratorMode mode = GeneratorMode.GL2;
        static internal IBind Generator;

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
            Console.WriteLine("For comments, bugs and suggestions visit http://opentk.sourceforge.net");
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
                                    string arg = val.ToLower();
                                    SetGeneratorMode(dirName, arg);
                                    dirName = val;
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
                                Settings.Compatibility |= val.ToLower() == "tao" ? Settings.Legacy.Tao : Settings.Legacy.None;
                                Settings.Compatibility |= val.ToLower() == "simple_enums" ? Settings.Legacy.NoAdvancedEnumProcessing : Settings.Legacy.None;
                                Settings.Compatibility |= val.ToLower() == "safe" ? Settings.Legacy.NoPublicUnsafeFunctions : Settings.Legacy.None;
                                //Settings.Compatibility |= b[1].ToLower().Contains("novoid") ? Settings.Legacy.TurnVoidPointersToIntPtr : Settings.Legacy.None;
                                Settings.Compatibility |= val.ToLower() == "permutations" ? Settings.Legacy.GenerateAllPermutations : Settings.Legacy.None;
                                Settings.Compatibility |= val.ToLower() == "enums_in_class" ? Settings.Legacy.NestedEnums : Settings.Legacy.None;
                                Settings.Compatibility |= val.ToLower() == "nodocs" ? Settings.Legacy.NoDocumentation : Settings.Legacy.None;
                                Settings.Compatibility |= val.ToLower() == "keep_untyped_enums" ? Settings.Legacy.KeepUntypedEnums : Settings.Legacy.None;
                                break;
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
                long ticks = DateTime.Now.Ticks;

                switch (mode)
                {
                    case GeneratorMode.GL3:
                    case GeneratorMode.GL2:
                        Generator = new GL4Generator("OpenGL", dirName);
                        break;

                    case GeneratorMode.ES10:
                        Generator = new ESGenerator("ES10", dirName);
                        break;
                    
                    case GeneratorMode.ES11:
                        Generator = new ESGenerator("ES11", dirName);
                        break;
                    
                    case GeneratorMode.ES20:
                        Generator = new ESGenerator("ES20", dirName);
                        break;

                    case GeneratorMode.CL10:
                        Generator = new CLGenerator("CL10", dirName);
                        break;
                    
                    case GeneratorMode.Unknown:
                    default:
                        Console.WriteLine("Please specify a generator mode (use '-mode:gl2/gl3/glu/wgl/glx])'");
                        return;
                }

                Generator.Process();
                ISpecWriter writer = null;
                switch (Settings.Language)
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
                writer.WriteBindings(Generator);

                ticks = DateTime.Now.Ticks - ticks;

                Console.WriteLine();
                Console.WriteLine("Bindings generated in {0} seconds.", ticks / (double)10000000.0);
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

        private static void SetGeneratorMode(string dirName, string arg)
        {
            if (arg == "gl" || arg == "gl2" || arg == "gl3" || arg == "gl4")
            {
                mode = GeneratorMode.GL2;
                Settings.DefaultOutputNamespace = "OpenTK.Graphics.OpenGL";
            }
            else if (arg == "es10")
            {
                mode = GeneratorMode.ES10;
                Settings.DefaultOutputPath = Path.Combine(
                    Directory.GetParent(Settings.DefaultOutputPath).ToString(),
                    dirName);
                Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES10";
            }
            else if (arg == "es11")
            {
                mode = GeneratorMode.ES11;
                Settings.DefaultOutputPath = Path.Combine(
                    Directory.GetParent(Settings.DefaultOutputPath).ToString(),
                    dirName);
                Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES11";
            }
            else if (arg == "es20")
            {
                mode = GeneratorMode.ES20;
                Settings.DefaultOutputPath = Path.Combine(
                    Directory.GetParent(Settings.DefaultOutputPath).ToString(),
                    dirName);
                Settings.DefaultOutputNamespace = "OpenTK.Graphics.ES20";
            }
            else if (arg == "cl" || arg == "cl10")
            {
                mode = GeneratorMode.CL10;
            }
            else
            {
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
