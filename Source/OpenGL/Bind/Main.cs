#region License
//Copyright (c) 2006 Stephen Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Text;
using System.IO;
using System.Security;
using System.Security.Permissions;
//using Settings = Tao.OpenGl.Bind.Properties.Bind;
using System.Threading;
using System.Collections.Generic;
using System.Collections;

[assembly:CLSCompliant(true), FileIOPermission(SecurityAction.RequestMinimum, Unrestricted = true)]
namespace OpenTK.OpenGL.Bind
{
    static class MainClass
    {
        static void Main(string[] arguments)
        {
            Console.WriteLine("{0} {1} by Stephen Apostolopoulos (stapostol@gmail.com)",
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());

            #region Handle Arguments

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
                            case "Properties.Bind.Default.OutputPath":
                                Settings.OutputPath = b[1];
                                break;
                            case "class":
                                Settings.OutputClass = b[1];
                                break;
                            default:
                                throw new ArgumentException("Argument " + a + " not recognized. Use the '/?' switch for help.");
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

            #endregion

            try
            {
                long ticks = System.DateTime.Now.Ticks;

                List<Function> wrappers;
                List<Function> functions = SpecReader.ReadFunctionSpecs("gl.spec");
                Hashtable enums = SpecReader.ReadEnumSpecs("enum.spec");
                Hashtable enums2= SpecReader.ReadEnumSpecs("enumext.spec");
                foreach (Enum e in enums2.Values)
                    if (!enums.ContainsKey(e.Name))
                        enums.Add(e.Name, e);
                    else
                    {
                        foreach (Constant c in e.ConstantCollection.Values)
                            if (!((Enum)enums[e.Name]).ConstantCollection.ContainsKey(c.Name))
                                ((Enum)enums[e.Name]).ConstantCollection.Add(c.Name, c);
                    }

                Translation.GLtypes = SpecReader.ReadTypeMap("gl_types.txt");
                Translation.CStypes = SpecReader.ReadTypeMap("cs_types.txt");

                Translation.TranslateFunctions(functions, enums, out wrappers);
                Translation.TranslateEnums(enums);

                SpecWriter.WriteSpecs(Settings.OutputPath, functions, wrappers, enums);

                ContextWriter.WriteMainContext(Settings.OutputPath, functions);
                ContextWriter.WriteDerivedContext(Settings.OutputPath, "WindowsContext", functions, "1.0", "1.1");
                ContextWriter.WriteDerivedContext(Settings.OutputPath, "WindowsVistaContext", functions, "1.0", "1.1", "1.2", "1.3", "1.4");
                ContextWriter.WriteDerivedContext(Settings.OutputPath, "X11Context", functions, "1.0", "1.1", "1.2", "1.3", "1.4", "1.5", "2.0");

                ticks = System.DateTime.Now.Ticks - ticks;

                Console.WriteLine("Bindings generated in {0} seconds.", ticks / (double)10000000.0);
            }
            catch (SecurityException e)
            {
                Console.WriteLine("Security violation \"{0}\" in method \"{1}\".", e.Message, e.Method);
                Console.WriteLine("This application does not have permission to take the requested actions.");
            }
            //finally
            //{
            //    Console.WriteLine("Press any key to continue...");
            //    Console.ReadKey(false);
            //}
        }
    }
}
