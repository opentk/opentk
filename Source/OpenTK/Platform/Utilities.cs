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
using System.Diagnostics;
using OpenTK.Graphics;

#endregion

namespace OpenTK.Platform
{
    namespace MacOS
    {
        /// <summary>
        /// This delegate represents any method that takes no arguments and returns an int.
        /// I would have used Func but that requires .NET 4
        /// </summary>
        /// <returns>The int value that your method returns</returns>
        public delegate int GetInt();
    }

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

        #region CreateGetAddress

        internal static GraphicsContext.GetAddressDelegate CreateGetAddress()
        {
            GraphicsContext.GetAddressDelegate loader = null;
            if (Configuration.RunningOnWindows)
            {
                loader = Platform.Windows.Wgl.GetProcAddress;
            }
            else if (Configuration.RunningOnX11)
            {
                loader = Platform.X11.Glx.GetProcAddress;
            }
            else if (Configuration.RunningOnMacOS)
            {
                loader = Platform.MacOS.NS.GetAddress;
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
            return loader;
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
            window.Handle = windowHandle;
            window.RootWindow = rootWindow;
            window.Visual = visualInfo;
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
            return CreateMacOSCarbonWindowInfo(windowHandle, ownHandle, isControl, null, null);
        }

        /// <summary>
        /// Creates an IWindowInfo instance for the Mac OS X platform with an X and Y offset for the GL viewport location.
        /// </summary>
        /// <param name="windowHandle">The handle of the window.</param>
        /// <param name="ownHandle">Ignored. This is reserved for future use.</param>
        /// <param name="isControl">Set to true if windowHandle corresponds to a System.Windows.Forms control.</param>
        /// <param name="xOffset">The X offset for the GL viewport</param>
        /// <param name="yOffset">The Y offset for the GL viewport</param>
        /// <returns>A new IWindowInfo instance.</returns>
        public static IWindowInfo CreateMacOSCarbonWindowInfo(IntPtr windowHandle, bool ownHandle, bool isControl, 
            OpenTK.Platform.MacOS.GetInt xOffset, OpenTK.Platform.MacOS.GetInt yOffset)
        {
            return new OpenTK.Platform.MacOS.CarbonWindowInfo(windowHandle, false, isControl, xOffset, yOffset);
        }

        #endregion

        #region CreateMacOSWindowInfo

        /// <summary>
        /// Creates an IWindowInfo instance for the Mac OS X platform.
        /// </summary>
        /// <param name="windowHandle">The handle of the NSWindow.</param>
        /// <remarks>Assumes that the NSWindow's contentView is the NSView we want to attach to our context.</remarks>
        /// <returns>A new IWindowInfo instance.</returns>
        public static IWindowInfo CreateMacOSWindowInfo(IntPtr windowHandle)
        {
            return new OpenTK.Platform.MacOS.CocoaWindowInfo(windowHandle);
        }

        /// <summary>
        /// Creates an IWindowInfo instance for the Mac OS X platform.
        /// </summary>
        /// <param name="windowHandle">The handle of the NSWindow.</param>
        /// <param name="viewHandle">The handle of the NSView.</param>
        /// <returns>A new IWindowInfo instance.</returns>
        public static IWindowInfo CreateMacOSWindowInfo(IntPtr windowHandle, IntPtr viewHandle)
        {
            return new OpenTK.Platform.MacOS.CocoaWindowInfo(windowHandle, viewHandle);
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

        #region CreateSdl2WindowInfo

        /// <summary>
        /// Creates an IWindowInfo instance for the windows platform.
        /// </summary>
        /// <param name="windowHandle">The handle of the window.</param>
        /// <returns>A new IWindowInfo instance.</returns>
        public static IWindowInfo CreateSdl2WindowInfo(IntPtr windowHandle)
        {
            return new OpenTK.Platform.SDL2.Sdl2WindowInfo(
                windowHandle, null);
        }

        #endregion

        #endregion

        #region RelaxGraphicsMode

        internal static bool RelaxGraphicsMode(ref GraphicsMode mode)
        {
            ColorFormat color = mode.ColorFormat;
            int depth = mode.Depth;
            int stencil = mode.Stencil;
            int samples = mode.Samples;
            ColorFormat accum = mode.AccumulatorFormat;
            int buffers = mode.Buffers;
            bool stereo = mode.Stereo;

            bool success = RelaxGraphicsMode(
                ref color, ref depth, ref stencil, ref samples,
                ref accum, ref buffers, ref stereo);

            mode = new GraphicsMode(
                color, depth, stencil, samples,
                accum, buffers, stereo);

            return success;
        }

        /// \internal
        /// <summary>
        /// Relaxes graphics mode parameters. Use this function to increase compatibility
        /// on systems that do not directly support a requested GraphicsMode. For example:
        /// - user requested stereoscopic rendering, but GPU does not support stereo
        /// - user requseted 16x antialiasing, but GPU only supports 4x
        /// </summary>
        /// <returns><c>true</c>, if a graphics mode parameter was relaxed, <c>false</c> otherwise.</returns>
        /// <param name="color">Color bits.</param>
        /// <param name="depth">Depth bits.</param>
        /// <param name="stencil">Stencil bits.</param>
        /// <param name="samples">Number of antialiasing samples.</param>
        /// <param name="accum">Accumulator buffer bits.</param>
        /// <param name="buffers">Number of rendering buffers (1 for single buffering, 2+ for double buffering, 0 for don't care).</param>
        /// <param name="stereo">Stereoscopic rendering enabled/disabled.</param>
        internal static bool RelaxGraphicsMode(ref ColorFormat color, ref int depth, ref int stencil, ref int samples, ref ColorFormat accum, ref int buffers, ref bool stereo)
        {
            // Parameters are relaxed in order of importance.
            // - Accumulator buffers are way outdated as a concept,
            // so they go first.
            // - Triple+ buffering is generally not supported by the
            // core WGL/GLX/AGL/CGL/EGL specs, so we clamp
            // to double-buffering as a second step. (If this doesn't help
            // we will also fall back to undefined single/double buffering
            // as a last resort).
            // - AA samples are an easy way to increase compatibility
            // so they go next.
            // - Stereoscopic is only supported on very few GPUs
            // (Quadro/FirePro series) so it goes next.
            // - The rest of the parameters then follow.

            if (accum != 0)
            {
                accum = 0;
                return true;
            }

            if (buffers > 2)
            {
                buffers = 2;
                return true;
            }

            if (samples > 0)
            {
                samples = Math.Max(samples - 1, 0);
                return true;
            }

            if (stereo)
            {
                stereo = false;
                return true;
            }

            if (stencil != 0)
            {
                stencil = 0;
                return true;
            }

            if (depth != 0)
            {
                depth = 0;
                return true;
            }

            if (color != 24)
            {
                color = 24;
                return true;
            }

            if (buffers != 0)
            {
                buffers = 0;
                return true;
            }

            // no parameters left to relax, fail
            return false;
        }

        #endregion
    }
}
