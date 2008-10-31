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
            Type extensions_class = type.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
            if (extensions_class == null)
                throw new InvalidOperationException("The specified type does not have any loadable extensions.");

            FieldInfo[] delegates = extensions_class.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            if (delegates == null)
                throw new InvalidOperationException("The specified type does not have any loadable extensions.");

            MethodInfo load_delegate_method_info = type.GetMethod("LoadDelegate", BindingFlags.Static | BindingFlags.NonPublic);
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

            FieldInfo rebuildExtensionList = type.GetField("rebuildExtensionList", BindingFlags.Static | BindingFlags.NonPublic);
            if (rebuildExtensionList != null)
                rebuildExtensionList.SetValue(null, true);

            time.Stop();
            Debug.Print("{0} extensions loaded in {1} ms.", supported, time.ElapsedMilliseconds);
            time.Reset();
        }

        #endregion

        #region internal static void LoadExtension()

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
            Type extensions_class = type.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
            if (extensions_class == null)
            {
                Debug.Print(type.ToString(), " does not contain extensions.");
                return false;
            }

            LoadDelegateFunction LoadDelegate = (LoadDelegateFunction)Delegate.CreateDelegate(typeof(LoadDelegateFunction),
                type.GetMethod("LoadDelegate", BindingFlags.Static | BindingFlags.NonPublic));
            if (LoadDelegate == null)
            {
                Debug.Print(type.ToString(), " does not contain a static LoadDelegate method.");
                return false;
            }

            FieldInfo f = extensions_class.GetField(extension, BindingFlags.Static | BindingFlags.NonPublic);
            if (f == null)
            {
                Debug.Print("Extension \"", extension, "\" not found in ", type.ToString());
                return false;
            }

            Delegate old = f.GetValue(null) as Delegate;
            Delegate @new = LoadDelegate(f.Name, f.FieldType);
            if (old.Target != @new.Target)
            {
                f.SetValue(null, @new);
                FieldInfo rebuildExtensionList = type.GetField("rebuildExtensionList", BindingFlags.Static | BindingFlags.NonPublic);
                if (rebuildExtensionList != null)
                    rebuildExtensionList.SetValue(null, true);
            }
            return @new != null;
        }

        #endregion


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

        #region --- Creating an Graphics Context ---
        #region --- CreateWindowInfo ---
		
		/// <summary>
		/// Creates GraphicsContext and IWindowInfo objects for a WinForms control.
		/// </summary>
        /// <param name="cntrl"></param>
        /// <param name="context"></param>
        /// <param name="info"></param>
        /// <param name="mode"></param>
		public static void CreateGraphicsContext(Graphics.GraphicsMode mode, Control cntrl, out Graphics.GraphicsContext context, out IWindowInfo info)
		{
			CreateGraphicsContext(mode, cntrl.Handle, out context, out info);	
		}
		/// <summary>
		/// Creates GraphicsContext and IWindowInfo objects for a WinForms control.
		/// </summary>
        /// <param name="cntrlHandle"></param>
        /// <param name="context"></param>
        /// <param name="info"></param>
        /// <param name="mode"></param>
		public static void CreateGraphicsContext(Graphics.GraphicsMode mode, IntPtr cntrlHandle, out Graphics.GraphicsContext context, out IWindowInfo info)
		{
			info = CreateWindowInfo(mode, cntrlHandle);
            
            context = new Graphics.GraphicsContext(mode, info);
            context.MakeCurrent(info);

            (context as OpenTK.Graphics.IGraphicsContextInternal).LoadAll();			
		}
        /// <summary>
        /// Creates an object which implements the IWindowInfo interface for the platform
        /// currently running on.  This will create a handle for the control, so it is not
        /// recommended that this be called in the constructor of a custom control.
        /// </summary>
        /// <param name="cntrl"></param>
        /// <returns></returns>
        public static IWindowInfo CreateWindowInfo(Graphics.GraphicsMode mode, Control cntrl)
        {
            return CreateWindowInfo(mode, cntrl.Handle);
        }
        /// <summary>
        /// Creates an object which implements the IWindowInfo interface for the platform
        /// currently running on.  
        /// </summary>
        /// <param name="controlHandle">The handle to the control, obtained from Control.Handle.</param>
        /// <returns></returns>
        public static IWindowInfo CreateWindowInfo(Graphics.GraphicsMode mode, IntPtr controlHandle)
        {
            if (Configuration.RunningOnWindows) return CreateWinWindowInfo(controlHandle);
            else if (Configuration.RunningOnX11) return CreateX11WindowInfo(mode, controlHandle);
            else if (Configuration.RunningOnOSX) return CreateOSXWindowInfo(controlHandle);
            else
                throw new PlatformNotSupportedException("Refer to http://www.opentk.com for more information.");
        }

        #endregion

        #region --- X11 Platform-specific implementation ---

        private static IWindowInfo CreateX11WindowInfo(Graphics.GraphicsMode mode, IntPtr controlHandle)
        {
            Platform.X11.X11WindowInfo window = new OpenTK.Platform.X11.X11WindowInfo();

            Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            if (xplatui == null) throw new PlatformNotSupportedException(
                    "System.Windows.Forms.XplatUIX11 missing. Unsupported platform or Mono runtime version, aborting.");

            window.WindowHandle = controlHandle;

            // get the required handles from the X11 API.
            window.Display = (IntPtr)GetStaticFieldValue(xplatui, "DisplayHandle");
            window.RootWindow = (IntPtr)GetStaticFieldValue(xplatui, "RootWindow");
            window.Screen = (int)GetStaticFieldValue(xplatui, "ScreenNo");

            // get the X11 Visual info for the display.
            Platform.X11.XVisualInfo info = new Platform.X11.XVisualInfo();
            info.visualid = mode.Index;
            int dummy;
            window.VisualInfo = (Platform.X11.XVisualInfo)Marshal.PtrToStructure(
                Platform.X11.Functions.XGetVisualInfo(window.Display, Platform.X11.XVisualInfoMask.ID, 
                                         ref info, out dummy), typeof(Platform.X11.XVisualInfo));

            // set the X11 colormap.
            SetStaticFieldValue(xplatui, "CustomVisual", window.VisualInfo.visual);
            SetStaticFieldValue(xplatui, "CustomColormap", 
                Platform.X11.Functions.XCreateColormap(window.Display, window.RootWindow, window.VisualInfo.visual, 0));

            return window;
        }

        #endregion
        #region --- Windows Platform-specific implementation ---

        private static IWindowInfo CreateWinWindowInfo(IntPtr controlHandle)
        {
            return new OpenTK.Platform.Windows.WinWindowInfo(controlHandle, null);
        }

        #endregion
        #region --- Mac OS X Platform-specific implementation ---

        private static IWindowInfo CreateOSXWindowInfo(IntPtr controlHandle)
        {
            throw new PlatformNotSupportedException("Refer to http://www.opentk.com for more information.");
        }

        #endregion

        #region --- Utility functions for reading/writing non-public static fields through reflection ---

        private static object GetStaticFieldValue(Type type, string fieldName)
        {
            return type.GetField(fieldName,
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
        }
        private static void SetStaticFieldValue(Type type, string fieldName, object value)
        {
            type.GetField(fieldName,
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).SetValue(null, value);
        }

        #endregion

        #endregion
    }
}
