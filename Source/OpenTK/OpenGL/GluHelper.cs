using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using OpenTK.Platform;

namespace OpenTK.OpenGL
{
    public static partial class Glu
    {
        private const string Library = "glu32.dll";

        private static Dictionary<string, bool> AvailableExtensions = new Dictionary<string, bool>();
        private static bool rebuildExtensionList = true;

        private static Assembly assembly;
        private static Type glClass;
        private static Type delegatesClass;
        private static Type importsClass;

        static Glu()
        {
            assembly = Assembly.GetExecutingAssembly();//Assembly.Load("OpenTK.OpenGL");
            glClass = assembly.GetType("OpenTK.OpenGL.Glu");
            delegatesClass = glClass.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
            importsClass = glClass.GetNestedType("Imports", BindingFlags.Static | BindingFlags.NonPublic);
        }

        #region private static Delegate GetDelegate(string name, Type signature)

        /// <summary>
        /// Creates a System.Delegate that can be used to call a GLU function, core or extension.
        /// </summary>
        /// <param name="name">The name of the GLU function (eg. "gluBuild2DMipmaps")</param>
        /// <param name="signature">The signature of the GLU function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this GLU function, or null if the specified
        /// function name did not correspond to an GLU function.
        /// </returns>
        private static Delegate GetDelegate(string name, Type signature)
        {
            MethodInfo m = importsClass.GetMethod(name.Substring(3), BindingFlags.Static | BindingFlags.NonPublic);
            return 
                Utilities.GetExtensionDelegate(name, signature) ??
                (m != null ? Delegate.CreateDelegate(signature, m) : null);
        }

        #endregion

        #region public static void LoadAll()

        /// <summary>
        /// Loads all GLU functions (core and extensions).
        /// </summary>
        /// <remarks>
        /// <para>
        /// Call this function manually whenever you need to update GLU entry points.
        /// This need will never arise under normal usage patterns.
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
        /// Tries to reload the given GLU function (core or extension).
        /// </summary>
        /// <param name="name">The name of the GLU function.</param>
        /// <returns>True if the function was found and reloaded, false otherwise.</returns>
        /// <remarks>
        /// <para>
        /// While the automatic initialisation will load all GLU entry points, in some cases
        /// the initialization can take place before a render context has been established.
        /// In this case, use this function to load the entry points for the GLU functions
        /// you will need, or use LoadAll() to load all available entry points.
        /// </para>
        /// <para>
        /// This function returns true if the given GLU function is supported, false otherwise.
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

        #region public static bool SupportsExtension(string name)

        /// <summary>
        /// Determines whether the specified GLU extension is available in
        /// the current GLU context.
        /// </summary>
        /// <param name="name">The string for the GLU extension.</param>
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

            AvailableExtensions.Clear();

            string version_string = Glu.GetString(Enums.StringName.VERSION);
            if (String.IsNullOrEmpty(version_string))
            {
                throw new ApplicationException("Failed to build extension list. Is there an opengl context current?");
            }
            
            string version = version_string.Trim(' ');
            if (version.StartsWith("1.0"))
            {
                AvailableExtensions.Add("VERSION_1_0", true);
            }
            else if (version.StartsWith("1.1"))
            {
                AvailableExtensions.Add("VERSION_1_0", true);
                AvailableExtensions.Add("VERSION_1_1", true);
            }
            else if (version.StartsWith("1.2"))
            {
                AvailableExtensions.Add("VERSION_1_0", true);
                AvailableExtensions.Add("VERSION_1_1", true);
                AvailableExtensions.Add("VERSION_1_2", true);
            }
            else if (version.StartsWith("1.3"))
            {
                AvailableExtensions.Add("VERSION_1_0", true);
                AvailableExtensions.Add("VERSION_1_1", true);
                AvailableExtensions.Add("VERSION_1_2", true);
                AvailableExtensions.Add("VERSION_1_3", true);
            }

            string extension_string = Glu.GetString(Enums.StringName.EXTENSIONS);
            if (String.IsNullOrEmpty(extension_string))
            {   // no extensions are available
                return;               
            }

            string[] extensions = extension_string.Split(' ');
            foreach (string ext in extensions)
            {
                AvailableExtensions.Add(ext, true);
            }

            rebuildExtensionList = false;
        }

        #endregion

        public class GLUnurbs
        {
        }

        public class GLUtesselator
        {
        }

        public class GLUquadric
        {
        }
    }
}
