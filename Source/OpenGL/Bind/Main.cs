/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Text;
using System.IO;
using System.Security;
using System.Security.Permissions;
using Settings = OpenTK.OpenGL.Bind.Properties.Bind;
using System.Threading;

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

            try
            {
                foreach (string a in arguments)
                {
                    if (a.StartsWith("--") || a.StartsWith("-") || a.StartsWith("/"))
                    {
                        string[] b = a.Split(new char[] { '-', '/', '=' }, StringSplitOptions.RemoveEmptyEntries);
                        switch (b[0])
                        {
                            case "?":
                            case "help":
                                Console.WriteLine("Help not implemented yet.");
                                return;
                            case "in":
                            case "input":
                                Properties.Bind.Default.InputPath = b[1];
                                break;
                            case "out":
                            case "Properties.Bind.Default.OutputPath":
                                Properties.Bind.Default.OutputPath = b[1];
                                break;
                            case "class":
                                Properties.Bind.Default.OutputGLClass = b[1];
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

            try
            {
                new Process();
            }
            catch (SecurityException e)
            {
                Console.WriteLine("Security violation \"{0}\" in method \"{1}\".", e.Message, e.Method);
                Console.WriteLine("This application does not have permission to take the requested actions.");
            }
            /*finally
            {
                Console.WriteLine("Press any key to continue...");
                while (!Console.KeyAvailable)
                    Thread.Sleep(100);
            }*/
        }
    }
}
