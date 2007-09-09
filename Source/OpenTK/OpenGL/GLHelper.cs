#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using OpenTK.Platform;
using System.Diagnostics;
using System.Reflection.Emit;

#endregion

[assembly: CLSCompliant(true)]

namespace OpenTK.OpenGL
{
    /// <summary>
    /// OpenGL binding for .NET, implementing OpenGL 2.1, plus extensions.
    /// </summary>
    /// <remarks>
    /// <para>
    /// OpenTK.OpenGL.GL contains all OpenGL enums and functions defined in the 2.1 specification.
    /// The official .spec files can be found at: http://opengl.org/registry/.
    /// </para>
    /// <para>
    /// OpenTK.OpenGL.GL relies on static initialization to obtain the entry points for OpenGL functions.
    /// Please ensure that a valid OpenGL context has been made current in the pertinent thread <b>before</b>
    /// any OpenGL functions are called (toolkits like GLUT, SDL or GLFW will automatically take care of
    /// the context initialization process). Without a valid OpenGL context, OpenTK.OpenGL.GL will only be able
    /// to retrieve statically exported entry points (typically corresponding to OpenGL version 1.1 under Windows,
    /// 1.3 under Linux and 1.4 under Windows Vista), and extension methods will need to be loaded manually.
    /// </para>
    /// <para>
    /// If you prefer not to rely on static initialisation for the Gl class, you can use the
    /// ReloadFunctions or ReloadFunction methods to manually force the initialisation of OpenGL entry points.
    /// The ReloadFunctions method should be called whenever you change an existing visual or pixelformat. This
    /// generally happens when you change the color/stencil/depth buffer associated with a window (but probably
    /// not the resolution). This may or may not be necessary under Linux/MacOS, but is generally required for
    /// Windows.
    /// </para>
    /// <para>
    /// You can use the Gl.IsExtensionSupported method to check whether any given category of extension functions
    /// exists in the current OpenGL context. The results can be cached to speed up future searches.
    /// Keep in mind that different OpenGL contexts may support different extensions, and under different entry
    /// points. Always check if all required extensions are still supported when changing visuals or pixel
    /// formats.
    /// </para>
    /// <para>
    /// You may retrieve the entry point for an OpenGL function using the GL.GetDelegate method.
    /// </para>
    /// <para>
    /// <see href="http://opengl.org/registry/"/>
    /// <seealso cref="GL.SupportsExtension"/>
    /// <seealso cref="GL.GetDelegate"/>
    /// <seealso cref="GL.LoadAll"/>
    /// <seealso cref="GL.Load"/>
    /// </para>
    /// </remarks>
    public static partial class GL
    {
        static GL()
        {
            assembly = Assembly.GetExecutingAssembly();//Assembly.Load("OpenTK.OpenGL");
            glClass = assembly.GetType("OpenTK.OpenGL.GL");
            delegatesClass = glClass.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
            importsClass = glClass.GetNestedType("Imports", BindingFlags.Static | BindingFlags.NonPublic);
        }

        internal static partial class Imports
        {
            internal static SortedList<string, MethodInfo> import;  // This is faster than either Dictionary or SortedDictionary
            static Imports()
            {
                MethodInfo[] methods = importsClass.GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
                import = new SortedList<string, MethodInfo>(methods.Length);
                foreach (MethodInfo m in methods)
                {
                    import.Add(m.Name, m);
                }
            }
        }

        #region --- Fields ---

        internal const string Library = "opengl32.dll";
        
        //private static Dictionary<string, bool> AvailableExtensions = new Dictionary<string, bool>();
        private static SortedList<string, bool> AvailableExtensions = new SortedList<string, bool>();
        private static bool rebuildExtensionList;

        private static Assembly assembly;
        private static Type glClass;
        private static Type delegatesClass;
        private static Type importsClass;
        private static FieldInfo[] delegates;
        
        #endregion

        #region public static bool SupportsExtension(string name)

        /// <summary>
        /// Determines whether the specified OpenGL extension category is available in
        /// the current OpenGL context. Equivalent to IsExtensionSupported(name, true)
        /// </summary>
        /// <param name="name">The string for the OpenGL extension category (eg. "GL_ARB_multitexture")</param>
        /// <returns>True if the specified extension is available, false otherwise.</returns>
        public static bool SupportsExtension(string name)
        {
            if (rebuildExtensionList)
            {
                BuildExtensionList();
            }

            // Search the cache for the string. Note that the cache substitutes
            // strings "1.0" to "2.1" with "GL_VERSION_1_0" to "GL_VERSION_2_1"
            if (AvailableExtensions.ContainsKey(name))
            {
                //return AvailableExtensions[name];
                return true;
            }
                
            return false;
        }

        #endregion

        #region private static void BuildExtensionList()

        /// <summary>
        /// Builds a cache of the supported extensions to speed up searches.
        /// </summary>
        private static void BuildExtensionList()
        {
            // Assumes there is an opengl context current.
            AvailableExtensions.Clear();
            string version_string = GL.GetString(OpenTK.OpenGL.GL.Enums.StringName.VERSION);
            if (String.IsNullOrEmpty(version_string))
            {
                throw new ApplicationException("Failed to build extension list. Is there an opengl context current?");
            }

            string version = version_string.Trim(' ');

            if (version.StartsWith("1.2"))
            {
                AvailableExtensions.Add("VERSION_1_2", true);
            }
            else if (version.StartsWith("1.3"))
            {
                AvailableExtensions.Add("VERSION_1_2", true);
                AvailableExtensions.Add("VERSION_1_3", true);
            }
            else if (version.StartsWith("1.4"))
            {
                AvailableExtensions.Add("VERSION_1_2", true);
                AvailableExtensions.Add("VERSION_1_3", true);
                AvailableExtensions.Add("VERSION_1_4", true);
            }
            else if (version.StartsWith("1.5"))
            {
                AvailableExtensions.Add("VERSION_1_2", true);
                AvailableExtensions.Add("VERSION_1_3", true);
                AvailableExtensions.Add("VERSION_1_4", true);
                AvailableExtensions.Add("VERSION_1_5", true);
            }
            else if (version.StartsWith("2.0"))
            {
                AvailableExtensions.Add("VERSION_1_2", true);
                AvailableExtensions.Add("VERSION_1_3", true);
                AvailableExtensions.Add("VERSION_1_4", true);
                AvailableExtensions.Add("VERSION_1_5", true);
                AvailableExtensions.Add("VERSION_2_0", true);
            }
            else if (version.StartsWith("2.1"))
            {
                AvailableExtensions.Add("VERSION_1_2", true);
                AvailableExtensions.Add("VERSION_1_3", true);
                AvailableExtensions.Add("VERSION_1_4", true);
                AvailableExtensions.Add("VERSION_1_5", true);
                AvailableExtensions.Add("VERSION_2_0", true);
                AvailableExtensions.Add("VERSION_2_1", true);
            }

            string extension_string = GL.GetString(OpenTK.OpenGL.GL.Enums.StringName.EXTENSIONS);
            if (String.IsNullOrEmpty(extension_string))
                return;               // no extensions are available

            string[] extensions = extension_string.Split(' ');
            foreach (string ext in extensions)
            {
                AvailableExtensions.Add(ext, true);
            }

            rebuildExtensionList = false;
        }

        #endregion

        #region public static Delegate GetDelegate(string name, Type signature)

        /// <summary>
        /// Creates a System.Delegate that can be used to call an OpenGL function, core or extension.
        /// </summary>
        /// <param name="name">The name of the OpenGL function (eg. "glNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function, or null if the specified
        /// function name did not correspond to an OpenGL function.
        /// </returns>
        public static Delegate GetDelegate(string name, Type signature)
        {
            MethodInfo m;
            return
                Utilities.GetExtensionDelegate(name, signature) ??
                /*((m = importsClass.GetMethod(name.Substring(2), BindingFlags.Static | BindingFlags.NonPublic)) != null ?*/
                (Imports.import.TryGetValue((name.Substring(2)), out m) ?
                Delegate.CreateDelegate(signature, m) : null);
        }

        #endregion

        #region public static void LoadAll()

        /// <summary>
        /// Loads all OpenGL functions (core and extensions).
        /// </summary>
        /// <remarks>
        /// <para>
        /// This function will be automatically called the first time you use any opengl function. There is 
        /// </para>
        /// <para>
        /// Call this function manually whenever you need to update OpenGL entry points.
        /// This need may arise if you change the pixelformat/visual, or in case you cannot
        /// (or do not want) to use the automatic initialization of the GL class.
        /// </para>
        /// </remarks>
        public static void LoadAll()
        {
            int supported = 0;
            if (delegates == null)
            {
                delegates = delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            }

            Debug.Print("GL.LoadAll(): Loading all {0} OpenGL functions.", delegates.Length);

            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Reset();
            time.Start();

            foreach (FieldInfo f in delegates)
            {
                Delegate d = GetDelegate(f.Name, f.FieldType);
                if (d != null)
                {
                    ++supported;
                }
                
                f.SetValue(null, d);
            }

            time.Stop();
            Trace.WriteLine(String.Format("{0} OpenGL extensions loaded in {1} milliseconds.", supported, time.ElapsedMilliseconds));
            time.Reset();

            rebuildExtensionList = true;
        }

        static void set(object d, Delegate value)
        {
            d = value;
        }

        #endregion

        #region public static bool Load(string function)

        /// <summary>
        /// Tries to reload the given OpenGL function (core or extension).
        /// </summary>
        /// <param name="name">The name of the OpenGL function (i.e. glShaderSource)</param>
        /// <returns>True if the function was found and reloaded, false otherwise.</returns>
        /// <remarks>
        /// <para>
        /// Use this function if you require greater granularity when loading OpenGL entry points.
        /// </para>
        /// <para>
        /// While the automatic initialisation will load all OpenGL entry points, in some cases
        /// the initialisation can take place before an OpenGL Context has been established.
        /// In this case, use this function to load the entry points for the OpenGL functions
        /// you will need, or use ReloadFunctions() to load all available entry points.
        /// </para>
        /// <para>
        /// This function returns true if the given OpenGL function is supported, false otherwise.
        /// </para>
        /// <para>
        /// To query for supported extensions use the IsExtensionSupported() function instead.
        /// </para>
        /// </remarks>
        public static bool Load(string function)
        {
            FieldInfo f = delegatesClass.GetField(function, BindingFlags.Static | BindingFlags.NonPublic);
            if (f == null)
                return false;

            Delegate old = f.GetValue(null) as Delegate;
            Delegate @new = f.GetValue(null) as Delegate;
            if (old.Target != @new.Target)
            {
                f.SetValue(null, @new);
                rebuildExtensionList = true;
                return true;
            }
            return false;
        }

        #endregion

        #region public static void Color[34]() overloads

        public static void Color4(System.Drawing.Color color)
        {
            GL.Color4(color.R, color.G, color.B, color.A);
        }

        public static void Color3(System.Drawing.Color color)
        {
            GL.Color3(color.R, color.G, color.B);
        }

        #endregion

        #region public static void ClearColor() overloads

        public static void ClearColor(System.Drawing.Color color)
        {
            GL.ClearColor(color.R/255.0f, color.G/255.0f, color.B/255.0f, color.A/255.0f);
        }

        #endregion
    }
}
