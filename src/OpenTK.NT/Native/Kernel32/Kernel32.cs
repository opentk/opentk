using System;
using System.Runtime.InteropServices;
using System.Security;

using BOOL = System.Boolean;
using DWORD = System.UInt32;
using FARPROC = System.IntPtr;
using HMODULE = System.IntPtr;
using LARGE_INTEGER = System.Int64;
using LPCSTR = System.String;
using LPCTSTR = System.String;

namespace OpenTK.NT.Native
{
    public static class Kernel32
    {
        private const string Library = "kernel32.dll";

        /// <summary>
        /// Retrieves the frequency of the performance counter. The frequency of the performance counter is fixed at system boot and is consistent across all processors. Therefore, the frequency need only be queried upon application initialization, and the result can be cached.
        /// </summary>
        /// <param name="lpFrequency">A pointer to a variable that receives the current performance-counter frequency, in counts per second. If the installed hardware doesn't support a high-resolution performance counter, this parameter can be zero (this will not occur on systems that run Windows XP or later).</param>
        /// <returns>If the installed hardware supports a high-resolution performance counter, the return value is true.<para/>
        /// If the function fails, the return value is false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>. On systems that run Windows XP or later, the function will always succeed and will thus never return false.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL QueryPerformanceFrequency([Out] out LARGE_INTEGER lpFrequency);

        /// <summary>
        /// Retrieves the current value of the performance counter, which is a high resolution (&lt;1us) time stamp that can be used for time-interval measurements.
        /// </summary>
        /// <param name="lpPerformanceCount">A pointer to a variable that receives the current performance-counter value, in counts. </param>
        /// <returns>If the function succeeds, the return value is true.
        /// If the function fails, the return value is false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>. On systems that run Windows XP or later, the function will always succeed and will thus never return false.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL QueryPerformanceCounter([Out] out LARGE_INTEGER lpPerformanceCount);

        /// <summary>
        /// Retrieves the address of an exported function or variable from the specified dynamic-link library (DLL).
        /// </summary>
        /// <param name="hModule">A handle to the DLL module that contains the function or variable. The <see cref="LoadLibrary"/>, LoadLibraryEx, LoadPackagedLibrary, or <see cref="GetModuleHandle"/> functions return this handle.</param>
        /// <param name="lpProcName">The function or variable name.</param>
        /// <returns>If the function succeeds, the return value is the address of the exported function or variable.<para/>
        /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</returns>
        [DllImport(Library, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern FARPROC GetProcAddress
        (
            [In] HMODULE hModule,
            [In] [MarshalAs(UnmanagedType.LPTStr)] LPCSTR lpProcName
        );

        /// <summary>
        /// Retrieves the address of an exported function or variable from the specified dynamic-link library (DLL).
        /// </summary>
        /// <param name="hModule">A handle to the DLL module that contains the function or variable. The <see cref="LoadLibrary(LPCSTR)"/>, LoadLibraryEx, LoadPackagedLibrary, or <see cref="GetModuleHandle(LPCSTR)"/> functions return this handle.</param>
        /// <param name="lpProcName">The function's ordinal value. It must be in the low-order word; the high-order word must be zero.</param>
        /// <returns>If the function succeeds, the return value is the address of the exported function or variable.<para/>
        /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</returns>
        [DllImport(Library, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern FARPROC GetProcAddress([In] HMODULE hModule, [In] IntPtr lpProcName);

        /// <summary>
        /// Sets the last-error code for the calling thread.
        /// </summary>
        /// <param name="dwErrCode">The last-error code for the thread.</param>
        [DllImport(Library)]
        public static extern void SetLastError(DWORD dwErrCode);

        /// <summary>
        /// Retrieves a module handle for the specified module. The module must have been loaded by the calling process.
        /// </summary>
        /// <param name="lpModuleName">The name of the loaded module (either a .dll or .exe file). If the file name extension is omitted, the default library extension .dll is appended. The file name string can include a trailing point character (.) to indicate that the module name has no extension. The string does not have to specify a path. When specifying a path, be sure to use backslashes (\), not forward slashes (/). The name is compared (case independently) to the names of modules currently mapped into the address space of the calling process.<para/>
        /// If this parameter is null, <see cref="GetModuleHandle(LPCSTR)"/> returns a handle to the file used to create the calling process (.exe file).</param>
        /// <returns>If the function succeeds, the return value is a handle to the specified module.<para/>
        /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</returns>
        [DllImport(Library, SetLastError = true)]
        public static extern HMODULE GetModuleHandle
        (
            [In] [Optional] [MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpModuleName
        );

        /// <summary>
        /// Loads the specified module into the address space of the calling process. The specified module may cause other modules to be loaded.
        /// </summary>
        /// <param name="lpFileName">The name of the module. This can be either a library module (a .dll file) or an executable module (an .exe file). The name specified is the file name of the module and is not related to the name stored in the library module itself, as specified by the LIBRARY keyword in the module-definition (.def) file.<para/>
        /// If the string specifies a full path, the function searches only that path for the module.<para/>
        /// If the string specifies a relative path or a module name without a path, the function uses a standard search strategy to find the module; for more information, see the Remarks.<para/>
        /// If the function cannot find the module, the function fails. When specifying a path, be sure to use backslashes (\), not forward slashes (/).<para/>
        /// If the string specifies a module name without a path and the file name extension is omitted, the function appends the default library extension .dll to the module name. To prevent the function from appending .dll to the module name, include a trailing point character (.) in the module name string.</param>
        /// <returns>If the function succeeds, the return value is a handle to the module.<para/>
        /// If the function fails, the return value is NULL. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</returns>
        [DllImport(Library, SetLastError = true)]
        public static extern HMODULE LoadLibrary([In] LPCTSTR lpFileName);

        /// <summary>
        /// Frees the loaded dynamic-link library (DLL) module and, if necessary, decrements its reference count. When the reference count reaches zero, the module is unloaded from the address space of the calling process and the handle is no longer valid.
        /// </summary>
        /// <param name="hModule">A handle to the loaded library module. The <see cref="LoadLibrary(LPCSTR)"/>, LoadLibraryEx, <see cref="GetModuleHandle(LPCSTR)"/>, or GetModuleHandleEx functions return this handle.</param>
        /// <returns>If the function succeeds, the return value is true.<para/>
        /// If the function fails, the return value is zero. To get extended error information, call the <see cref="Marshal.GetLastWin32Error"/> function.</returns>
        [DllImport(Library)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL FreeLibrary([In] HMODULE hModule);
    }
}
