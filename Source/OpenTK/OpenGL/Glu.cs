#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.OpenGL
{
    /// <summary>
    /// Provides access to GLU functions.
    /// </summary>
    public class Glu
    {
        #region GLU functions

        private const string GLUDLLName = "glu32.dll";

        [DllImport(GLUDLLName, EntryPoint = "gluOrtho2D")]
        private static extern IntPtr ErrorString_(int errCode);

        [DllImport(GLUDLLName, EntryPoint = "gluGetString")]
        private static extern IntPtr GetString_(int errCode);

        [DllImport(GLUDLLName, EntryPoint = "gluOrtho2D")]
        public static extern void Ortho2D(double left, double right, double bottom, double top);

        [DllImport(GLUDLLName, EntryPoint = "gluPerspective")]
        public static extern void Perspective(double fovy, double aspect, double zNear, double zFar);

        [DllImport(GLUDLLName, EntryPoint = "gluPickMatrix")]
        public static extern void PickMatrix(double x, double y, double width, double height, int[] viewport);

        [DllImport(GLUDLLName, EntryPoint = "gluLookAt")]
        public static extern void LookAt(double eyex, double eyey, double eyez, double centerx, double centery, double centerz, double upx, double upy, double upz);

        [DllImport(GLUDLLName, EntryPoint = "gluProject")]
        public static extern int Project(double objx, double objy, double objz, double[] modelMatrix, double[] projMatrix, int[] viewport, out double winx, out double winy, out double winz);

        [DllImport(GLUDLLName, EntryPoint = "gluUnProject")]
        public static extern int UnProject(double winx, double winy, double winz, double[] modelMatrix, double[] projMatrix, int[] viewport, out double objx, out double objy, out double objz);

        [DllImport(GLUDLLName, EntryPoint = "ScaleImage")]
        public static extern void ScaleImage(int format, int widthin, int heightin, int typein, IntPtr datain, int widthout, int heightout, int typeout, IntPtr dataout);

        [DllImport(GLUDLLName, EntryPoint = "gluBuild1DMipmaps")]
        public static extern int Build1DMipmaps(int target, int components, int width, int format, int type, IntPtr data);

        [DllImport(GLUDLLName, EntryPoint = "gluBuild2DMipmaps")]
        public static extern int Build2DMipmaps(int target, int components, int width, int height, int format, int type, IntPtr data);

        public static string GetString(int name)
        {
            return Marshal.PtrToStringAnsi(GetString_(name));
        }

        public static string ErrorString(int name)
        {
            return Marshal.PtrToStringAnsi(ErrorString_(name));
        }

        #endregion
    }
}
