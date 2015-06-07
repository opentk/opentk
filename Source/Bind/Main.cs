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
    enum GeneratorMode
    {
        All = 0,
        Default = All,
        GL2,
        GL3,
        GL4,
        ES10,
        ES11,
        ES20,
        ES30,
        ES31,
        CL10,
    }

    static class MainClass
    {
        static GeneratorMode mode = GeneratorMode.Default;
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
            Console.WriteLine("For comments, bugs and suggestions visit http://github.com/opentk/opentk");
            Console.WriteLine();
            
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
                            case "mode":
                                {
                                    string arg = val.ToLower();
                                    SetGeneratorMode(arg);
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
                switch (mode)
                {
                    case GeneratorMode.All:
                        Console.WriteLine("Using 'all' generator mode.");
                        Console.WriteLine("Use '-mode:all/gl2/gl4/es10/es11/es20/es30/es31' to select a specific mode.");
                        Generators.Add(new GL2Generator(Settings));
                        Generators.Add(new GL4Generator(Settings));
                        Generators.Add(new ESGenerator(Settings));
                        Generators.Add(new ES2Generator(Settings));
                        Generators.Add(new ES3Generator(Settings));
                        Generators.Add(new ES31Generator(Settings));
                        break;

                    case GeneratorMode.GL2:
                        Generators.Add(new GL2Generator(Settings));
                        break;

                    case GeneratorMode.GL3:
                    case GeneratorMode.GL4:
                        Generators.Add(new GL4Generator(Settings));
                        break;

                    case GeneratorMode.ES10:
                        Generators.Add(new ESGenerator(Settings));
                        break;
                    
                    case GeneratorMode.ES11:
                        Generators.Add(new ESGenerator(Settings));
                        break;
                    
                    case GeneratorMode.ES20:
                        Generators.Add(new ES2Generator(Settings));
                        break;

                    case GeneratorMode.ES30:
                        Generators.Add(new ES3Generator(Settings));
                        break;

                    case GeneratorMode.ES31:
                        Generators.Add(new ES31Generator(Settings));
                        break;

                    case GeneratorMode.CL10:
                        Generators.Add(new CLGenerator(Settings));
                        break;
                    
                    default:
                        Console.WriteLine("Please specify a generator mode (use '-mode:gl2/gl4/es10/es11/es20/es30')");
                        return;
                }

                foreach (var generator in Generators)
                {
                    long ticks = DateTime.Now.Ticks;

                    generator.Process();

                    var writer = new CSharpSpecWriter();
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

        private static void SetGeneratorMode(string arg)
        {
            switch (arg)
            {
                case "gl":
                case "gl2":
                    mode = GeneratorMode.GL2;
                    break;

                case "gl3":
                case "gl4":
					mode = GeneratorMode.GL4;
                    break;

                case "es10":
                    mode = GeneratorMode.ES10;
                    break;

                case "es11":
                    mode = GeneratorMode.ES11;
                    break;

                case "es2":
                case "es20":
                    mode = GeneratorMode.ES20;
                    break;

                case "es3":
                case "es30":
                    mode = GeneratorMode.ES30;
                    break;

                case "es31":
                    mode = GeneratorMode.ES31;
                    break;

                case "cl":
                case "cl10":
                    mode = GeneratorMode.CL10;
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
