#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * Contributions by Andy Gill.
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using OpenTK.Platform;

using OpenTK.Math;
using OpenTK.OpenGL.Enums;

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
                GL.GetExtensionDelegate(name, signature) ??
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

            string version_string = Glu.GetString(GluStringName.Version);
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

            string extension_string = Glu.GetString(GluStringName.Extensions);
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

		#region Overloads

		public static void LookAt(Vector3 eye, Vector3 center, Vector3 up)
		{
			Delegates.gluLookAt((double)eye.X, (double)eye.Y, (double)eye.Z, (double)center.X, (double)center.Y, (double)center.Z, (double)up.X, (double)up.Y, (double)up.Z);
		}

		// One token Project overload, I picked this one because it's CLS compliant, and it
		// makes reasonably clear which args are inputs and which are outputs.
		public static Int32 Project(Vector3 obj, double[] model, double[] proj, Int32[] view, out Vector3 win)
		{
			unsafe
			{
				double winX, winY, winZ;
				double* winX_ptr = &winX;
				double* winY_ptr = &winY;
				double* winZ_ptr = &winZ;
				fixed (double* model_ptr = model)
				fixed (double* proj_ptr = proj)
				fixed (Int32* view_ptr = view)
				{
					Int32 retval = Delegates.gluProject((double)obj.X, (double)obj.Y, (double)obj.Z, (double*)model_ptr, (double*)proj_ptr, (Int32*)view_ptr, (double*)winX_ptr, (double*)winY_ptr, (double*)winZ_ptr);
					win = new Vector3((float)*winX_ptr, (float)*winY_ptr, (float)*winZ_ptr);
					return retval;
				}
			}
		}

		public static void TessNormal(int tess, Vector3 normal)
		{
			Delegates.gluTessNormal((int)tess, (double)normal.X, (double)normal.Y, (double)normal.Z);
		}

		public static Int32 UnProject(Vector3 win, double[] model, double[] proj, Int32[] view, out Vector3 obj)
		{
			unsafe
			{
				double objX, objY, objZ;
				double* objX_ptr = &objX;
				double* objY_ptr = &objY;
				double* objZ_ptr = &objZ;
				fixed (double* model_ptr = model)
				fixed (double* proj_ptr = proj)
				fixed (Int32* view_ptr = view)
				{
					Int32 retval = Delegates.gluUnProject((double)win.X, (double)win.Y, (double)win.Z, (double*)model_ptr, (double*)proj_ptr, (Int32*)view_ptr, (double*)objX_ptr, (double*)objY_ptr, (double*)objZ_ptr);
					obj = new Vector3((float)*objX_ptr, (float)*objY_ptr, (float)*objZ_ptr);
					return retval;
				}
			}
		}

		public static Int32 UnProject4(Vector4 win, double[] model, double[] proj, Int32[] view, double near, double far, out Vector4 obj)
		{
			unsafe
			{
				double objX, objY, objZ, objW;
				double* objX_ptr = &objX;
				double* objY_ptr = &objY;
				double* objZ_ptr = &objZ;
				double* objW_ptr = &objW;
				fixed (double* model_ptr = model)
				fixed (double* proj_ptr = proj)
				fixed (Int32* view_ptr = view)
				{
					Int32 retval = Delegates.gluUnProject4((double)win.X, (double)win.Y, (double)win.Z, (double)win.W, (double*)model_ptr, (double*)proj_ptr, (Int32*)view_ptr, (double)near, (double)far, (double*)objX_ptr, (double*)objY_ptr, (double*)objZ_ptr, (double*)objW_ptr);
					obj = new Vector4((float)*objX_ptr, (float)*objY_ptr, (float)*objZ_ptr, (float)*objW_ptr);
					return retval;
				}
			}
		}

        public static string ErrorString(ErrorCode error)
        {
            return ErrorString((GluErrorCode)error);
        }

		#endregion
	}
}
