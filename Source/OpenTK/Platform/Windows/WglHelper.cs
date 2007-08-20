#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 *
 * Date: 12/8/2007
 * Time: 6:43 μμ
 */
#endregion

using System;
using System.Runtime.InteropServices;
using System.Reflection;

namespace OpenTK.Platform.Windows
{
	/// <summary>
	/// 
	/// </summary>
	public partial class Wgl
    {
        #region --- Constructors ---

        static Wgl()
        {
            assembly = Assembly.GetExecutingAssembly();
            wglClass = assembly.GetType("OpenTK.Platform.Windows.Wgl");
            delegatesClass = wglClass.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
            importsClass = wglClass.GetNestedType("Imports", BindingFlags.Static | BindingFlags.NonPublic);

            //LoadAll();
        }

        #endregion

        #region --- Fields ---

        internal const string Library = "OPENGL32.DLL";

        private static Assembly assembly;
        private static Type wglClass;
        private static Type delegatesClass;
        private static Type importsClass;

        #endregion

        #region public static Delegate GetDelegate(string name, Type signature)

        /// <summary>
        /// Creates a System.Delegate that can be used to call an OpenGL function, core or extension.
        /// </summary>
        /// <param name="name">The name of the Wgl function (eg. "wglNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function, or null if the specified
        /// function name did not correspond to an OpenGL function.
        /// </returns>
        public static Delegate GetDelegate(string name, Type signature)
        {
            Delegate d;
            string realName = name.StartsWith("wgl") ? name.Substring(3) : name;

            if (importsClass.GetMethod(realName,
                BindingFlags.NonPublic | BindingFlags.Static) != null)
            {
                d = Utilities.GetExtensionDelegate(name, signature) ??
                    Delegate.CreateDelegate(signature, typeof(Imports), realName);
            }
            else
            {
                d = Utilities.GetExtensionDelegate(name, signature);
            }

            return d;
        }

        #endregion

        /// <summary>
        /// Loads all Wgl entry points, core and extensions.
        /// </summary>
        public static void LoadAll()
        {
            FieldInfo[] v = delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            foreach (FieldInfo f in v)
            {
                f.SetValue(null, GetDelegate(f.Name, f.FieldType));
            }
        }

        /// <summary>
        /// Loads the given Wgl entry point.
        /// </summary>
        /// <param name="function">The name of the function to load.</param>
        /// <returns></returns>
        public static bool Load(string function)
        {
            FieldInfo f = delegatesClass.GetField(function);
            if (f == null)
                return false;

            f.SetValue(null, GetDelegate(f.Name, f.FieldType));

            return f.GetValue(null) != null;
        }
            
	}
}
