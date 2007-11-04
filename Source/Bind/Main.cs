#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Text;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Collections.Generic;
using System.CodeDom;
using System.Diagnostics;

namespace Bind
{
    enum GeneratorMode
    {
        Unknown,
        GL2,
        GL3,
        Wgl,
        Glx,
        Glu,
    }

    static class MainClass
    {
        static GeneratorMode mode;

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
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            Console.WriteLine("For comments, bugs and suggestions visit http://opentk.sourceforge.net");
            //Console.WriteLine(" - the OpenTK team ;-)");
            Console.WriteLine();

            try
            {
                foreach (string a in arguments)
                {
                    if (a.StartsWith("--") || a.StartsWith("-") || a.StartsWith("/"))
                    {
                        string[] b = a.Split(new char[] { '-', '/', ':', '=' }, StringSplitOptions.RemoveEmptyEntries);
                        switch (b[0])
                        {
                            case "?":
                            case "help":
                                ShowHelp();
                                return;
                            case "in":
                            case "input":
                                Settings.InputPath = b[1];
                                break;
                            case "out":
                            case "output":
                                Settings.OutputPath = b[1];
                                break;
                            case "mode":
                                string arg = b[1].ToLower();
                                mode =
                                    arg == "gl" ? GeneratorMode.GL2 : 
                                    arg == "gl2" ? GeneratorMode.GL2 : 
                                    arg == "gl3" ? GeneratorMode.GL3 :
                                    arg == "wgl" ? GeneratorMode.Wgl : 
                                    arg == "glu" ? GeneratorMode.Glu :
                                    arg == "glx" ? GeneratorMode.Glx : GeneratorMode.Unknown;
                                if (mode == GeneratorMode.Unknown)
                                    throw new ArgumentException(String.Format("Mode {0} unknown.", arg));
                                break;
                            case "namespace":
                            case "ns":
                                Settings.OutputNamespace = b[1];
                                break;
                            case "class":
                                Settings.OutputClass = b[1];
                                break;
                            case "gl":
                                Settings.GLClass = b[1];
                                break;
                            case "legacy":
                            case "o":
                            case "option":
                                Settings.Compatibility |= b[1].ToLower().Contains("tao") ? Settings.Legacy.Tao : Settings.Legacy.None;
                                Settings.Compatibility |= b[1].ToLower().Contains("enums") ? Settings.Legacy.NoAdvancedEnumProcessing : Settings.Legacy.None;
                                Settings.Compatibility |= b[1].ToLower().Contains("safe") ? Settings.Legacy.NoPublicUnsafeFunctions : Settings.Legacy.None;
                                //Settings.Compatibility |= b[1].ToLower().Contains("novoid") ? Settings.Legacy.TurnVoidPointersToIntPtr : Settings.Legacy.None;
                                Settings.Compatibility |= b[1].ToLower().Contains("permutations") ? Settings.Legacy.GenerateAllPermutations : Settings.Legacy.None;
                                Settings.Compatibility |= b[1].ToLower().Contains("enums_in_class") ? Settings.Legacy.NestedEnums : Settings.Legacy.None;
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
                long ticks = System.DateTime.Now.Ticks;

                switch (mode)
                {
                    case GeneratorMode.GL2:
                        Generator = new Bind.GL2.Generator();
                        break;

                    case GeneratorMode.Wgl:
                        Generator = new Bind.Wgl.Generator();
                        break;

                    case GeneratorMode.Glu:
                        Generator = new Bind.Glu.Generator();
                        break;

                    case GeneratorMode.Glx:
                        Generator = new Bind.Glx.Generator();
                        break;

                    case GeneratorMode.GL3:
                        throw new NotImplementedException(String.Format("Mode {0} not implemented.", mode));
                    
                    case GeneratorMode.Unknown:
                    default:
                        Console.WriteLine("Please specify a generator mode (use '-mode:gl2/gl3/glu/wgl/glx])'");
                        return;
                        
                }

                Generator.Process();

                ticks = System.DateTime.Now.Ticks - ticks;

                Console.WriteLine();
                Console.WriteLine("Bindings generated in {0} seconds.", ticks / (double)10000000.0);
                Console.WriteLine();
                //Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
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

        private static void ShowHelp()
        {
            Console.WriteLine(
@"Usage: bind -mode:[gl/gl2/gl3/glu/wgl/glx] [switches]
Available switches:
-in:         Input directory (e.g. -in:../specs/)
-out:        Output directory (e.g. -out:out)
-ns:         Output namespace (e.g. -ns:OpenTK.OpenGL).
             Default: OpenTK.OpenGL
-namespace:  Same as -ns
-class:      Output class (e.g. -class:GL3).
             Default: GL/Wgl/Glu/Glx (depends on -mode)
-o/-option:  Set advanced option. Available options:
    -o:tao   Tao compatibility mode.
    -o:enums Follow OpenGL instead .Net naming conventions.
    -o:safe  Do not generate public unsafe functions.
    -o:permutations
             Generate all possible parameter permutations.
    -o:enums_in_class
             Place enums in a nested class (i.e. GL.Enums)
             instead of a namespace (i.e. OpenTK.OpenGL.Enums)
");
        }
    }
}
