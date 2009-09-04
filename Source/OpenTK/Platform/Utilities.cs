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
using System.Reflection;
using System.Diagnostics;
using OpenTK.Graphics;

#endregion

namespace OpenTK.Platform
{
    /// <summary>
    /// Provides cross-platform utilities to help interact with the underlying platform.
    /// </summary>
    public static class Utilities
    {
        #region internal static bool ThrowOnX11Error

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

        #endregion

        #region internal static void LoadExtensions(Type type)

        delegate Delegate LoadDelegateFunction(string name, Type signature);

        /// <internal />
        /// <summary>Loads all extensions for the specified class. This function is intended
        /// for OpenGL, Wgl, Glx, OpenAL etc.</summary>
        /// <param name="type">The class to load extensions for.</param>
        /// <remarks>
        /// <para>The Type must contain a nested class called "Delegates".</para>
        /// <para>
        /// The Type must also implement a static function called LoadDelegate with the
        /// following signature:
        /// <code>static Delegate LoadDelegate(string name, Type signature)</code>
        /// </para>
        /// <para>This function allocates memory.</para>
        /// </remarks>
        internal static void LoadExtensions(Type type)
        {
            // Using reflection is more than 3 times faster than directly loading delegates on the first
            // run, probably due to code generation overhead. Subsequent runs are faster with direct loading
            // than with reflection, but the first time is more significant.

            int supported = 0;
            Type extensions_class = type.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            if (extensions_class == null)
                throw new InvalidOperationException("The specified type does not have any loadable extensions.");

            FieldInfo[] delegates = extensions_class.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            if (delegates == null)
                throw new InvalidOperationException("The specified type does not have any loadable extensions.");

            MethodInfo load_delegate_method_info = type.GetMethod("LoadDelegate", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            if (load_delegate_method_info == null)
                throw new InvalidOperationException(type.ToString() + " does not contain a static LoadDelegate method.");
            LoadDelegateFunction LoadDelegate = (LoadDelegateFunction)Delegate.CreateDelegate(
                typeof(LoadDelegateFunction), load_delegate_method_info);

            Debug.Write("Load extensions for " + type.ToString() + "... ");

            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Reset();
            time.Start();

            foreach (FieldInfo f in delegates)
            {
                Delegate d = LoadDelegate(f.Name, f.FieldType);
                if (d != null)
                    ++supported;

                f.SetValue(null, d);
            }

            FieldInfo rebuildExtensionList = type.GetField("rebuildExtensionList", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            if (rebuildExtensionList != null)
                rebuildExtensionList.SetValue(null, true);

            time.Stop();
            Debug.Print("{0} extensions loaded in {1} ms.", supported, time.ElapsedMilliseconds);
            time.Reset();
        }

        #endregion

        #region internal static bool TryLoadExtension(Type type, string extension)

        /// <internal />
        /// <summary>Loads the specified extension for the specified class. This function is intended
        /// for OpenGL, Wgl, Glx, OpenAL etc.</summary>
        /// <param name="type">The class to load extensions for.</param>
        /// <param name="extension">The extension to load.</param>
        /// <remarks>
        /// <para>The Type must contain a nested class called "Delegates".</para>
        /// <para>
        /// The Type must also implement a static function called LoadDelegate with the
        /// following signature:
        /// <code>static Delegate LoadDelegate(string name, Type signature)</code>
        /// </para>
        /// <para>This function allocates memory.</para>
        /// </remarks>
        internal static bool TryLoadExtension(Type type, string extension)
        {
            Type extensions_class = type.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            if (extensions_class == null)
            {
                Debug.Print(type.ToString(), " does not contain extensions.");
                return false;
            }

            LoadDelegateFunction LoadDelegate = (LoadDelegateFunction)Delegate.CreateDelegate(typeof(LoadDelegateFunction),
                type.GetMethod("LoadDelegate", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public));
            if (LoadDelegate == null)
            {
                Debug.Print(type.ToString(), " does not contain a static LoadDelegate method.");
                return false;
            }

            FieldInfo f = extensions_class.GetField(extension, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            if (f == null)
            {
                Debug.Print("Extension \"", extension, "\" not found in ", type.ToString());
                return false;
            }

            Delegate old = f.GetValue(null) as Delegate;
            Delegate @new = LoadDelegate(f.Name, f.FieldType);
            if ((old != null ? old.Target : null) != (@new != null ? @new.Target : null))
            {
                f.SetValue(null, @new);
                FieldInfo rebuildExtensionList = type.GetField("rebuildExtensionList", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
                if (rebuildExtensionList != null)
                    rebuildExtensionList.SetValue(null, true);
            }
            return @new != null;
        }

        #endregion

        #region --- Creating a Graphics Context ---

        /// <summary>
        /// Creates an IGraphicsContext instance for the specified window.
        /// </summary>
        /// <param name="mode">The GraphicsMode for the GraphicsContext.</param>
        /// <param name="window">An IWindowInfo instance describing the parent window for this IGraphicsContext.</param>
        /// <param name="major">The major OpenGL version number for this IGraphicsContext.</param>
        /// <param name="minor">The minor OpenGL version number for this IGraphicsContext.</param>
        /// <param name="flags">A bitwise collection of GraphicsContextFlags with specific options for this IGraphicsContext.</param>
        /// <returns>A new IGraphicsContext instance.</returns>
        [Obsolete("Call new OpenTK.Graphics.GraphicsContext() directly, instead.")]
        public static IGraphicsContext CreateGraphicsContext(
            GraphicsMode mode, IWindowInfo window,
            int major, int minor, GraphicsContextFlags flags)
        {
            GraphicsContext context = new GraphicsContext(mode, window, major, minor, flags);
            context.MakeCurrent(window);

            (context as IGraphicsContextInternal).LoadAll();

            return context;
        }

        #region CreateX11WindowInfo

        /// <summary>
        /// Constructs a new IWindowInfo instance for the X11 platform.
        /// </summary>
        /// <param name="display">The display connection.</param>
        /// <param name="screen">The screen.</param>
        /// <param name="windowHandle">The handle for the window.</param>
        /// <param name="rootWindow">The root window for screen.</param>
        /// <param name="visualInfo">A pointer to a XVisualInfo structure obtained through XGetVisualInfo.</param>
        /// <returns>A new IWindowInfo instance.</returns>
        public static IWindowInfo CreateX11WindowInfo(IntPtr display, int screen, IntPtr windowHandle, IntPtr rootWindow, IntPtr visualInfo)
        {
            Platform.X11.X11WindowInfo window = new OpenTK.Platform.X11.X11WindowInfo();
            window.Display = display;
            window.Screen = screen;
            window.WindowHandle = windowHandle;
            window.RootWindow = rootWindow;
            window.VisualInfo = (X11.XVisualInfo)Marshal.PtrToStructure(visualInfo, typeof(X11.XVisualInfo));

            return window;
        }

        #endregion

        #region CreateWindowsWindowInfo

        /// <summary>
        /// Creates an IWindowInfo instance for the windows platform.
        /// </summary>
        /// <param name="windowHandle">The handle of the window.</param>
        /// <returns>A new IWindowInfo instance.</returns>
        public static IWindowInfo CreateWindowsWindowInfo(IntPtr windowHandle)
        {
            return new OpenTK.Platform.Windows.WinWindowInfo(windowHandle, null);
        }

        #endregion

        #region CreateMacOSCarbonWindowInfo

        /// <summary>
        /// Creates an IWindowInfo instance for the Mac OS X platform.
        /// </summary>
        /// <param name="windowHandle">The handle of the window.</param>
        /// <param name="ownHandle">Ignored. This is reserved for future use.</param>
        /// <param name="isControl">Set to true if windowHandle corresponds to a System.Windows.Forms control.</param>
        /// <returns>A new IWindowInfo instance.</returns>
        public static IWindowInfo CreateMacOSCarbonWindowInfo(IntPtr windowHandle, bool ownHandle, bool isControl)
        {
            return new OpenTK.Platform.MacOS.CarbonWindowInfo(windowHandle, false, isControl);
        }

        #endregion

        #region CreateDummyWindowInfo

        /// <summary>
        /// Creates an IWindowInfo instance for the dummy platform.
        /// </summary>
        /// <returns>A new IWindowInfo instance.</returns>
        public static IWindowInfo CreateDummyWindowInfo()
        {
            return new Dummy.DummyWindowInfo();
        }

        #endregion

        #endregion


    }
}
