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

namespace OpenTK.OpenGL
{
	/// <summary>
	/// 
	/// </summary>
	public partial class Wgl
	{
		internal const string Library = "OPENGL32.DLL";
		
		internal static IntPtr LoadAddress(string function)
		{
			return Wgl.GetProcAddress(function);
		}
		
		public static Delegate LoadExtension(string function, Type signature)
		{
			IntPtr address = LoadAddress(function);
			
            if (address == IntPtr.Zero ||
                address == new IntPtr(1) ||     // Workaround for buggy nvidia drivers which return
                address == new IntPtr(2))       // 1 or 2 instead of IntPtr.Zero for some extensions.
            {
                return null;
            }
            else
            {
                return Marshal.GetDelegateForFunctionPointer(address, signature);
            }
		}
		
		public static Delegate Load(string function, Type signature)
		{
            return null;
		}
	}
}
