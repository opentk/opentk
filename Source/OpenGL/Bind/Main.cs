#region License
//Copyright (c) 2006 Stephen Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Text;
using System.IO;
using System.Security;
using System.Security.Permissions;
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
                                Settings.GLClass = b[1];
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

                // GL binding generation.

                Translation.GLTypes = SpecReader.ReadTypeMap("gl.tm");
                Translation.CSTypes = SpecReader.ReadTypeMap("csharp.tm");

                List<Function> wrappers;
                List<Function> functions = SpecReader.ReadFunctionSpecs("gl.spec");
                Hashtable enums = SpecReader.ReadEnumSpecs("enum.spec");
                Hashtable enums2 = SpecReader.ReadEnumSpecs("enumext.spec");
                foreach (Enum e in enums2.Values)
                    if (!enums.ContainsKey(e.Name))
                        enums.Add(e.Name, e);
                    else
                    {
                        foreach (Constant c in e.ConstantCollection.Values)
                            if (!((Enum)enums[e.Name]).ConstantCollection.ContainsKey(c.Name))
                                ((Enum)enums[e.Name]).ConstantCollection.Add(c.Name, c);
                    }

                Translation.TranslateFunctions(functions, enums, out wrappers);
                Translation.TranslateEnums(enums);

                SpecWriter.WriteSpecs(Settings.OutputPath, Settings.GLClass, functions, wrappers, enums);

                //ContextWriter.WriteMainContext(Settings.OutputPath, "GLContext", Settings.GLClass, functions);
                //ContextWriter.WriteDerivedContext(Settings.OutputPath, "WindowsContext", Settings.GLClass, functions, "1.0", "1.1");
                //ContextWriter.WriteDerivedContext(Settings.OutputPath, "WindowsVistaContext", Settings.GLClass, functions, "1.0", "1.1", "1.2", "1.3", "1.4");
                //ContextWriter.WriteDerivedContext(Settings.OutputPath, "X11Context", Settings.GLClass, functions, "1.0", "1.1", "1.2", "1.3", "1.4", "1.5", "2.0");

                // GLX binding generation.
                //Translation.GLXTypes = SpecReader.ReadTypeMap("glx.tm"); // Works semi-ok.
                //List<Function> functions = SpecReader.ReadFunctionSpecs("glx.spec"); // Works ok!
                //Hashtable enums = SpecReader.ReadEnumSpecs("glxenum.spec"); // Works ok!
                //SpecWriter.WriteSpecs(Settings.OutputPath, "Glx", functions, null, enums); // Needs updating.

                ticks = System.DateTime.Now.Ticks - ticks;

                Console.WriteLine("Bindings generated in {0} seconds.", ticks / (double)10000000.0);
            }
            catch (SecurityException e)
            {
                Console.WriteLine("Security violation \"{0}\" in method \"{1}\".", e.Message, e.Method);
                Console.WriteLine("This application does not have permission to take the requested actions.");
            }
        }
    }
}
