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
        GL2,
        GL3,
        Wgl,
        Glx,
        Glu
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
                                Console.WriteLine("Help not implemented yet.");
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
                                    arg == "gl2" ? GeneratorMode.GL2 : 
                                    arg == "gl3" ? GeneratorMode.GL3 :
                                    arg == "wgl" ? GeneratorMode.Wgl : 
                                    arg == "glu" ? GeneratorMode.Glu : 
                                    arg == "glx" ? GeneratorMode.Glx : GeneratorMode.GL2;
                                break;
                            case "namespace":
                            case "ns":
                                Settings.OutputNamespace = b[1];
                                break;
                            //case "gl":
                            //    Settings.OutputClass = b[1];
                            //    break;
                            //case "glu":
                            //    Settings.OutputClass = b[1];
                            //    break;
                            case "legacy":
                                Settings.Compatibility = b[1].ToLower() == "tao" ? Settings.Legacy.Tao : Settings.Legacy.None;
                                break;
                            case "class":
                                Settings.OutputClass = b[1];
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
                Console.WriteLine("Argument error ({0}). Please use the '/?' switch for help.", e.ToString());
                return;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument error ({0}). Please use the '/?' switch for help.", e.ToString());
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
                    default:
                        throw new NotImplementedException(String.Format("Mode {0} not implemented.", mode));
                }

                Generator.Process();

                ticks = System.DateTime.Now.Ticks - ticks;

                Console.WriteLine();
                Console.WriteLine("Bindings generated in {0} seconds.", ticks / (double)10000000.0);
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
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
    }
}
