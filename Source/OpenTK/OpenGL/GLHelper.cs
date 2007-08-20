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
    /// You may retrieve the entry point for an OpenGL extension using the Gl.GetDelegateForExtensionMethod
    /// and Gl.GetFunctionPointerForExtensionMethod methods. You may retrieve the entry point for an OpenGL
    /// function using the Gl.GetDelegateForMethod method. All three methods are cross-platform.
    /// </para>
    /// <para>
    /// <see href="http://opengl.org/registry/"/>
    /// <seealso cref="Gl.IsExtensionSupported(string, bool)"/>
    /// <seealso cref="Gl.GetDelegateForExtensionMethod"/>
    /// <seealso cref="Gl.GetFunctionPointerForExtensionMethod"/>
    /// <seealso cref="Gl.GetDelegateForMethod"/>
    /// <seealso cref="Gl.ReloadFunctions"/>
    /// <seealso cref="Gl.ReloadFunction"/>
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

        #region --- Fields ---

        internal const string Library = "opengl32.dll";
        
        private static System.Collections.Generic.Dictionary<string, bool> AvailableExtensions = new Dictionary<string, bool>();
        private static bool rebuildExtensionList;

        private static Assembly assembly;
        private static Type glClass;
        private static Type delegatesClass;
        private static Type importsClass;

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
                return AvailableExtensions[name];
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
            Delegate d;

            if (importsClass.GetMethod(name.Substring(2), BindingFlags.NonPublic | BindingFlags.Static) != null)
            {
                d = Utilities.GetExtensionDelegate(name, signature) ??
                    Delegate.CreateDelegate(signature, typeof(Imports), name.Substring(2));
            }
            else
            {
                d = Utilities.GetExtensionDelegate(name, signature);
            }

            return d;
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
        /// (or do not want) to use the automatic initialisation of the GL class.
        /// </para>
        /// </remarks>
        public static void LoadAll()
        {
            FieldInfo[] v = delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            foreach (FieldInfo f in v)
            {
                f.SetValue(null, GetDelegate(f.Name, f.FieldType));
            }

            AvailableExtensions.Clear();
            rebuildExtensionList = true;
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
            FieldInfo f = delegatesClass.GetField(function);
            if (f == null)
                return false;

            f.SetValue(null, GetDelegate(f.Name, f.FieldType));
            rebuildExtensionList = true;

            return f.GetValue(null) != null;
        }

        #endregion
    }
}
