using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with window classes.
        /// </summary>
        public static class WindowClass
        {
            /// <summary>
            /// Retrieves information about a window class,
            /// including a handle to the small icon associated with the window class.
            /// </summary>
            /// <param name="instance">
            /// A handle to the instance of the application that created the class.
            /// To retrieve information about classes defined by the system (such as buttons or list boxes),
            /// set this parameter to <see cref="IntPtr.Zero"/>.
            /// </param>
            /// <param name="className">
            /// A string containing the class name. The name must be that of a preregistered class or a class
            /// registered by a previous call to the RegisterClass or
            /// <see cref="RegisterClassEx(ref ExtendedWindowClass)"/> function.
            /// </param>
            /// <param name="extendedWindowClass">
            /// A pointer to a <see cref="ExtendedWindowClass"/> structure
            /// that receives the information about the class.
            /// </param>
            /// <returns>
            /// If the function finds a matching class and successfully copies the data, the return value is
            /// true.<para/>
            /// If the function does not find a matching class and successfully copy the data, the return value is
            /// false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetClassInfoEx
            (
                [In] [Optional] IntPtr instance,
                [In] string className,
                [Out] out ExtendedWindowClass extendedWindowClass
            );

            /// <summary>
            /// Retrieves information about a window class,
            /// including a handle to the small icon associated with the window class.
            /// </summary>
            /// <param name="instance">
            /// A handle to the instance of the application that created the class.
            /// To retrieve information about classes defined by the system (such as buttons or list boxes),
            /// set this parameter to <see cref="IntPtr.Zero"/>.
            /// </param>
            /// <param name="className">
            /// A pointer to a string containing the class name.
            /// The name must be that of a preregistered class or a class registered by a previous call to the
            /// RegisterClass or <see cref="RegisterClassEx(ref ExtendedWindowClass)"/> function.
            /// </param>
            /// <param name="extendedWindowClass">
            /// A pointer to a <see cref="ExtendedWindowClass"/> structure
            /// that receives the information about the class.
            /// </param>
            /// <returns>
            /// If the function finds a matching class and successfully copies the data, the return value is
            /// true.<para/>
            /// If the function does not find a matching class and successfully copy the data, the return value
            /// is false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetClassInfoEx
            (
                [In] IntPtr instance,
                [In] IntPtr className,
                [Out] out ExtendedWindowClass extendedWindowClass
            );

            /// <summary>
            /// Retrieves information about a window class,
            /// including a handle to the small icon associated with the window class.
            /// </summary>
            /// <param name="instance">
            /// A handle to the instance of the application that created the class.
            /// To retrieve information about classes defined by the system (such as buttons or list boxes),
            /// set this parameter to <see cref="IntPtr.Zero"/>.
            /// </param>
            /// <param name="classAtom">
            /// A class atom created by a previous call to RegisterClass
            /// or <see cref="RegisterClassEx(ref ExtendedWindowClass)"/>.
            /// </param>
            /// <param name="extendedWindowStyle">
            /// A pointer to a <see cref="ExtendedWindowClass"/> structure
            /// that receives the information about the class.
            /// </param>
            /// <returns>
            /// If the function finds a matching class and successfully copies the data, the return value is
            /// true.<para/>
            /// If the function does not find a matching class and successfully copy the data, the return value is
            /// false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static bool GetClassInfoEx
            (
                [In] IntPtr instance,
                [In] ushort classAtom,
                [Out] out ExtendedWindowClass extendedWindowStyle
            )
            {
                return GetClassInfoEx(instance, new IntPtr(classAtom), out extendedWindowStyle);
            }

            /// <summary>
            /// Registers a window class for subsequent use in calls to the CreateWindow or
            /// <see cref="Window.CreateWindowEx(ExtendedWindowStyles, IntPtr, string,
            /// WindowStyles, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)"/> function.
            /// </summary>
            /// <param name="extendedWindowClass">
            /// A pointer to a <see cref="ExtendedWindowClass"/> structure. You must fill the structure with the
            /// appropriate class attributes before passing it to the function.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is a class atom that uniquely identifies the class being
            /// registered. This atom can only be used by the CreateWindow,
            /// <see cref="Window.CreateWindowEx(ExtendedWindowStyles, IntPtr, string,
            /// WindowStyles, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)"/>,
            /// GetClassInfo, <see cref="GetClassInfoEx(IntPtr, IntPtr, out ExtendedWindowClass)"/>, FindWindow,
            /// FindWindowEx, and <see cref="UnregisterClass(string, IntPtr)"/> functions
            /// and the IActiveIMMap::FilterClientWindows method.<para/>
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern ushort RegisterClassEx([In] ref ExtendedWindowClass extendedWindowClass);

            /// <summary>
            /// Unregisters a window class, freeing the memory required for the class.
            /// </summary>
            /// <param name="className">
            /// A string specifying the window class name. This class name must have been
            /// registered by a previous call to the RegisterClass or
            /// <see cref="RegisterClassEx(ref ExtendedWindowClass)"/> function.
            /// </param>
            /// <param name="moduleInstance">A handle to the instance of the module that created the class.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the class could not be found or if a window still exists that was created with the class, the return
            /// value is false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            /// <remarks>
            /// Before calling this function, an application must destroy all windows created with the
            /// specified class.<para/>
            /// All window classes that an application registers are unregistered when it terminates.
            /// </remarks>
            [DllImport(Library, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool UnregisterClass([In] string className, [In] [Optional] IntPtr moduleInstance);

            /// <summary>
            /// Unregisters a window class, freeing the memory required for the class.
            /// </summary>
            /// <param name="className">
            /// A pointer to a string specifying the window class name. This class name must
            /// have been registered by a previous call to the RegisterClass or
            /// <see cref="RegisterClassEx(ref ExtendedWindowClass)"/> function.
            /// </param>
            /// <param name="moduleInstance">A handle to the instance of the module that created the class.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the class could not be found or if a window still exists that was created with the class, the return
            /// value is false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            /// <remarks>
            /// Before calling this function, an application must destroy all windows created with the
            /// specified class.<para/>
            /// All window classes that an application registers are unregistered when it terminates.
            /// </remarks>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool UnregisterClass
            (
                [In] IntPtr className,
                [In] [Optional] IntPtr moduleInstance
            );

            /// <summary>
            /// Unregisters a window class, freeing the memory required for the class.
            /// </summary>
            /// <param name="classAtom">
            /// A class atom created by a previous call to the RegisterClass or
            /// <see cref="RegisterClassEx(ref ExtendedWindowClass)"/> function.
            /// </param>
            /// <param name="moduleInstance">A handle to the instance of the module that created the class.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the class could not be found or if a window still exists that was created with the class, the return
            /// value is false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            /// <remarks>
            /// Before calling this function, an application must destroy all windows created with the
            /// specified class.<para/>
            /// All window classes that an application registers are unregistered when it terminates.
            /// </remarks>
            public static bool UnregisterClass([In] ushort classAtom, [In] [Optional] IntPtr moduleInstance)
            {
                return UnregisterClass(new IntPtr(classAtom), moduleInstance);
            }
        }
    }
}
