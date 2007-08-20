#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

#endregion

namespace OpenTK.Platform
{
    /// <summary>
    /// Provides cross-platform utilities to help interact with the underlying platform.
    /// </summary>
    public static class Utilities
    {
        #region --- LoadAddress ---

        internal interface ILoadAddress
        {
            IntPtr LoadAddress(string function);
        }

        internal class LoadAddressWindows : ILoadAddress
        {
            public IntPtr LoadAddress(string function)
            {
                return OpenTK.Platform.Windows.Wgl.Imports.GetProcAddress(function);
            }
        }

        internal class LoadAddressX11 : ILoadAddress
        {
            public IntPtr LoadAddress(string function)
            {
                return X11.Glx.GetProcAddress(function);
            }
        }

        internal class LoadAddressOSX : ILoadAddress
        {
            public IntPtr LoadAddress(string function)
            {
                string fname = "_" + function;
                if (!OSX.Functions.NSIsSymbolNameDefined(fname))
                    return IntPtr.Zero;

                IntPtr symbol = OSX.Functions.NSLookupAndBindSymbol(fname);
                if (symbol != IntPtr.Zero)
                    symbol = OSX.Functions.NSAddressOfSymbol(symbol);

                return symbol;
            }
        }

        #endregion

        #region --- Fields ---

        /// <summary>
        /// Enumerates the platforms OpenTK can run on.
        /// </summary>
        private enum Platform
        {
            Unknown,
            Windows,
            X11,
            X11_ARB,
            OSX
        };

        private static ILoadAddress loadAddress;

        #endregion

        private static Platform platform = Platform.Unknown;

        public static IWindowInfo GetWindowInfo(Form form)
        {
            throw new NotImplementedException();
        }

        #region public static IntPtr GetAddress(string function)

        /// <summary>
        /// Retrieves the entry point for a dynamically exported OpenGL function.
        /// </summary>
        /// <param name="name">The function string for the OpenGL function (eg. "glNewList")</param>
        /// <returns>
        /// An IntPtr contaning the address for the entry point, or IntPtr.Zero if the specified
        /// OpenGL function is not dynamically exported.
        /// </returns>
        /// <remarks>
        /// <para>
        /// The Marshal.GetDelegateForFunctionPointer method can be used to turn the return value
        /// into a call-able delegate.
        /// </para>
        /// <para>
        /// This function is cross-platform. It determines the underlying platform and uses the
        /// correct wgl, glx or agl GetAddress function to retrieve the function pointer.
        /// </para>
        /// <see cref="Marshal.GetDelegateForFunctionPointer"/>
        /// <seealso cref="Gl.GetDelegateForExtensionMethod"/>
        /// </remarks>
        public static IntPtr GetAddress(string function)
        {
            if (platform == Platform.Unknown)
            {
                if (System.Environment.OSVersion.Platform == PlatformID.Win32NT ||
                    System.Environment.OSVersion.Platform == PlatformID.Win32S ||
                    System.Environment.OSVersion.Platform == PlatformID.Win32Windows ||
                    System.Environment.OSVersion.Platform == PlatformID.WinCE)
                {
                    platform = Platform.Windows;
                    loadAddress = new LoadAddressWindows();
                }
                else if (System.Environment.OSVersion.Platform == PlatformID.Unix)
                {
                    platform = Platform.X11;
                    loadAddress = new LoadAddressX11();
                }
                else
                {
                    throw new PlatformNotSupportedException(
                        "Extension loading is only supported under X11 and Windows. We are sorry for the inconvience.");
                }
            }

            return loadAddress.LoadAddress(function);
        }

        #endregion

        #region private static Delegate GetExtensionDelegate(string name, Type signature)

        /// <summary>
        /// Creates a System.Delegate that can be used to call a dynamically exported OpenGL function.
        /// </summary>
        /// <param name="name">The name of the OpenGL function (eg. "glNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function or null
        /// if the function is not available in the current OpenGL context.
        /// </returns>
        internal static Delegate GetExtensionDelegate(string name, Type signature)
        {
            IntPtr address = GetAddress(name);

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

        #endregion
    }
}
