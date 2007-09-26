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
        static bool throw_on_error;
        internal static bool ThrowOnX11Error
        {
            get { return throw_on_error; }
            set
            {
                if (value && !throw_on_error)
                {
                    Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms")
                        .GetField("ErrorExceptions", System.Reflection.BindingFlags.Static |
                            System.Reflection.BindingFlags.NonPublic)
                        .SetValue(null, true);
                    throw_on_error = true;
                }
                else if (!value && throw_on_error)
                {
                    Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms")
                        .GetField("ErrorExceptions", System.Reflection.BindingFlags.Static |
                            System.Reflection.BindingFlags.NonPublic)
                        .SetValue(null, false);
                    throw_on_error = false;
                }
            }
        }

        #region public bool IsIdle

        interface IIsIdle { bool IsIdle { get; } }

        class X11IsIdle : IIsIdle
        {
            public bool IsIdle
            {
                get
                {
                    return X11.API.Pending(IntPtr.Zero) == 0;
                }
            }
        }

        class WindowsIsIdle : IIsIdle
        {
            Windows.MSG msg;

            public bool IsIdle
            {
                get
                {
                    return !Windows.Functions.PeekMessage(ref msg, IntPtr.Zero, 0, 0, 0);
                }
            }
        }

        static IIsIdle isIdleImpl =
            System.Environment.OSVersion.Platform == PlatformID.Unix ?
            (IIsIdle)new X11IsIdle() : (IIsIdle)new WindowsIsIdle();

        public static bool IsIdle
        {
            get
            {
                return isIdleImpl.IsIdle;
            }
        }


        #endregion
    }
}
