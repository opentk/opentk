#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OpenTK.Platform
{
    /// <summary>
    /// Describes a Windows.Form.Control, Windows.Forms.NativeWindow or OpenTK.GameWindow.
    /// </summary>
    public sealed class WindowInfo : IMutableWindowInfo
    {
        IMutableWindowInfo implementation;

        #region --- Constructors ---

        /// <summary>
        /// Detects the underlying platform and constructs a new WindowInfo class.
        /// </summary>
        /// <exception cref="PlatformNotSupportedException">Raised when the underlying platform is not supported.</exception>
        public WindowInfo()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                case (PlatformID)128:
                    implementation = new X11.WindowInfo();
                    break;

                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    implementation = new Windows.WindowInfo();
                    break;

                default:
                    throw new PlatformNotSupportedException("Your Operating System is not supported. Please refer to http://opentk.sourceforge.net for more information.");
            }
        }

        /// <summary>
        /// Detects the underlying platform and constructs a new WindowInfo class describing the specified Control.
        /// </summary>
        /// <param name="control">The System.Windows.Forms.Control to get info from.</param>
        public WindowInfo(Control control) : this()
        {
            implementation.CopyInfoFrom(implementation.GetInfoFrom(control));
        }

        /// <summary>
        /// Detects the underlying platform and constructs a new WindowInfo class describing the specified NativeWindow.
        /// </summary>
        /// <param name="window">The System.Windows.Forms.NativeWindow to get info from.</param>
        public WindowInfo(NativeWindow window) : this()
        {
            implementation.CopyInfoFrom(implementation.GetInfoFrom(window));
        }

        /// <summary>
        /// Detects the underlying platform and constructs a new WindowInfo class describing the specified GameWindow.
        /// </summary>
        /// <param name="window">The OpenTK.GameWindow to get info from.</param>
        public WindowInfo(GameWindow window) : this()
        {
            implementation.CopyInfoFrom(implementation.GetInfoFrom(window));
        }

        #endregion

        #region --- IWindowInfo Members ---

        /// <summary>
        /// Gets the platform specific handle of the window described by the WindowInfo class.
        /// </summary>
        public IntPtr Handle
        {
            get { return implementation.Handle; }
        }
        
        /// <summary>
        /// Gets the parent of the window described by the WindowInfo class.
        /// </summary>
        public IWindowInfo Parent
        {
            get { return implementation.Parent; }
        }

        /// <summary>
        /// Updates the WindowInfo to describe the specified Control.
        /// </summary>
        /// <param name="control">The System.Windows.Forms.Control to describe.</param>
        public IWindowInfo GetInfoFrom(Control control)
        {
            return implementation.GetInfoFrom(control);
        }

        /// <summary>
        /// Updates the WindowInfo to describe the specified NativeWindow.
        /// </summary>
        /// <param name="window">The System.Windows.Forms.NativeWindow to describe.</param>
        public IWindowInfo GetInfoFrom(NativeWindow window)
        {
            return implementation.GetInfoFrom(window);
        }

        /// <summary>
        /// Updates the WindowInfo to describe the specified GameWindow.
        /// </summary>
        /// <param name="window">The OpenTK.GameWindow to describe.</param>
        public IWindowInfo GetInfoFrom(GameWindow window)
        {
            return implementation.GetInfoFrom(window);
        }

        /// <summary>
        /// Updates the WindowInfo using the specified IWindowInfo.
        /// </summary>
        /// <param name="window">The OpenTK.Platform.IWindowInfo to get information from.</param>
        public IWindowInfo GetInfoFrom(IWindowInfo info)
        {
            return implementation.GetInfoFrom(info);
        }

        #endregion

        #region --- IMutableWindowInfo Members ---

        public void CopyInfoFrom(IWindowInfo info)
        {
            implementation.CopyInfoFrom(info);
        }

        public static explicit operator Windows.WindowInfo(WindowInfo info)
        {
            return (Windows.WindowInfo)info.implementation;
        }

        public static explicit operator X11.WindowInfo(WindowInfo info)
        {
            return (X11.WindowInfo)info.implementation;
        }

        #endregion
    }
}
