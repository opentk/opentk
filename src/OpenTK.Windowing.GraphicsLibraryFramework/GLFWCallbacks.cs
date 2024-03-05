//
// GLFWCallbacks.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Class containing GLFW related callbacks.
    /// </summary>
    public static unsafe class GLFWCallbacks
    {
        /// <summary>
        /// The function signature for Unicode character callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="codepoint">The Unicode code point of the character.</param>
        /// <seealso cref="GLFW.SetCharCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CharCallback(Window* window, uint codepoint);

        /// <summary>
        /// The function signature for Unicode character with modifiers callback functions.
        /// It is called for each input character, regardless of what modifier keys are held down.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="codepoint">The Unicode code point of the character.</param>
        /// <param name="modifiers">Bit field describing which modifier keys were held down.</param>
        /// <seealso cref="GLFW.SetCharModsCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CharModsCallback(Window* window, uint codepoint, KeyModifiers modifiers);

        /// <summary>
        /// The function signature for cursor enter/leave callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="entered"><c>true</c> if the cursor entered the window's client area, or <c>false</c> if it left it.</param>
        /// <seealso cref="GLFW.SetCursorEnterCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CursorEnterCallback(Window* window, bool entered);

        /// <summary>
        /// The function signature for cursor position callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="x">The new cursor x-coordinate, relative to the left edge of the client area.</param>
        /// <param name="y">The new cursor y-coordinate, relative to the top edge of the client area.</param>
        /// <seealso cref="GLFW.SetCursorPosCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CursorPosCallback(Window* window, double x, double y);

        /// <summary>
        /// The function signature for file drop callbacks.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="count">The number of dropped files.</param>
        /// <param name="paths">The UTF-8 encoded file and/or directory path names.</param>
        /// <seealso cref="GLFW.SetDropCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void DropCallback(Window* window, int count, byte** paths);

        /// <summary>
        /// The function signature for joystick configuration callback functions.
        /// </summary>
        /// <param name="joystick">The joystick that was connected or disconnected.</param>
        /// <param name="state">
        /// One of <see cref="ConnectedState.Connected"/> or <see cref="ConnectedState.Disconnected"/>.
        /// </param>
        /// <seealso cref="GLFW.SetJoystickCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JoystickCallback(int joystick, ConnectedState state);

        /// <summary>
        /// The function signature for keyboard key callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="key">The keyboard key that was pressed or released.</param>
        /// <param name="scanCode">The system-specific scancode of the key.</param>
        /// <param name="action">The <see cref="InputAction"/> for that <paramref name="key"/>.</param>
        /// <param name="mods">Bit field describing which modifier keys were held down.</param>
        /// <seealso cref="GLFW.SetKeyCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void KeyCallback(Window* window, Keys key, int scanCode, InputAction action, KeyModifiers mods);

        /// <summary>
        /// The function signature for mouse button callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="button">The mouse button that was pressed or released.</param>
        /// <param name="action">One of <see cref="InputAction.Press"/> or <see cref="InputAction.Release"/>.</param>
        /// <param name="mods">Bit field describing which modifier keys were held down.</param>
        /// <seealso cref="GLFW.SetMouseButtonCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void MouseButtonCallback(Window* window, MouseButton button, InputAction action, KeyModifiers mods); // TODO: Make enums for int params in callback

        /// <summary>
        /// The function signature for scroll callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="offsetX">The scroll offset along the x-axis.</param>
        /// <param name="offsetY">The scroll offset along the y-axis.</param>
        /// <seealso cref="GLFW.SetScrollCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ScrollCallback(Window* window, double offsetX, double offsetY);

        /// <summary>
        /// The function signature for monitor configuration callback functions.
        /// </summary>
        /// <param name="monitor">The monitor that was connected or disconnected.</param>
        /// <param name="state">
        /// One <see cref="ConnectedState.Connected"/> of  or <see cref="ConnectedState.Disconnected"/>.
        /// </param>
        /// <seealso cref="GLFW.SetMonitorCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void MonitorCallback(Monitor* monitor, ConnectedState state);

        /// <summary>
        /// The function signature for window close callback functions.
        /// </summary>
        /// <param name="window">The window that the user attempted to close.</param>
        /// <seealso cref="GLFW.SetWindowCloseCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void WindowCloseCallback(Window* window);

        /// <summary>
        /// The function signature for window focus callback functions.
        /// </summary>
        /// <param name="window">The window that gained or lost input focus.</param>
        /// <param name="focused"><c>true</c> if the window was given input focus, or <c>false</c> if it lost it.</param>
        /// <seealso cref="GLFW.SetWindowFocusCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void WindowFocusCallback(Window* window, bool focused);

        /// <summary>
        /// The function signature for window iconify/restore callback functions.
        /// </summary>
        /// <param name="window">The window that was iconified or restored.</param>
        /// <param name="iconified"><c>true</c> if the window was iconified(minimized), or <c>false</c> if it was restored.</param>
        /// <seealso cref="GLFW.SetWindowIconifyCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void WindowIconifyCallback(Window* window, bool iconified);

        /// <summary>
        /// The function signature for window maximize/restore callback functions.
        /// </summary>
        /// <param name="window">The window that was maximized or restored.</param>
        /// <param name="maximized"><c>true</c> if the window was maximized, or <c>false</c> if it was restored.</param>
        /// <seealso cref="GLFW.SetWindowMaximizeCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void WindowMaximizeCallback(Window* window, bool maximized);

        /// <summary>
        /// The function signature for framebuffer size callback functions.
        /// </summary>
        /// <param name="window">The window whose framebuffer was resized.</param>
        /// <param name="width">The new width, in pixels, of the framebuffer.</param>
        /// <param name="height">The new height, in pixels, of the framebuffer.</param>
        /// <seealso cref="GLFW.SetFramebufferSizeCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FramebufferSizeCallback(Window* window, int width, int height);

        /// <summary>
        /// This is the function pointer type for window content scale callbacks.
        /// </summary>
        /// <param name="window">The window whose content scale changed. </param>
        /// <param name="xscale">The new x-axis content scale of the window. </param>
        /// <param name="yscale">The new y-axis content scale of the window.</param>
        /// <seealso cref="GLFW.SetWindowContentScaleCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void WindowContentScaleCallback(Window* window, float xscale, float yscale);

        /// <summary>
        /// The function signature for window position callback functions.
        /// </summary>
        /// <param name="window">The window that was moved.</param>
        /// <param name="x">
        /// The new x-coordinate, in screen coordinates, of the upper-left corner of the client area of the window.
        /// </param>
        /// <param name="y">
        /// The new y-coordinate, in screen coordinates, of the upper-left corner of the client area of the window.
        /// </param>
        /// <seealso cref="GLFW.SetWindowPosCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void WindowPosCallback(Window* window, int x, int y);

        /// <summary>
        /// The function signature for window size callback functions.
        /// </summary>
        /// <param name="window">The window that was resized.</param>
        /// <param name="width">The new width, in screen coordinates, of the window.</param>
        /// <param name="height">The new height, in screen coordinates, of the window.</param>
        /// <seealso cref="GLFW.SetWindowSizeCallback"/>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void WindowSizeCallback(Window* window, int width, int height);

        /// <summary>
        /// The function signature for error callback functions.
        /// </summary>
        /// <param name="error">An error code.</param>
        /// <param name="description">A UTF-8 encoded string describing the error.</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ErrorCallback(ErrorCode error, string description);

        /// <summary>
        /// The function signature for window refresh functions.
        /// </summary>
        /// <param name="window">The window that needs to be refreshed.</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void WindowRefreshCallback(Window* window);
    }

    /// <summary>
    /// The function pointer type for memory allocation callbacks.
    ///
    /// This is the function pointer type for memory allocation callbacks. A memory
    /// allocation callback function has the following signature:
    /// <code>
    /// void* function_name(size_t size, void* user)
    /// </code>
    ///
    /// This function must return either a memory block at least `size` bytes long,
    /// or `NULL` if allocation failed.Note that not all parts of GLFW handle allocation
    /// failures gracefully yet.
    ///
    /// This function must support being called during @ref glfwInit but before the library is
    /// flagged as initialized, as well as during @ref glfwTerminate after the library is no
    /// longer flagged as initialized.
    ///
    /// Any memory allocated via this function will be deallocated via the same allocator
    /// during library termination or earlier.
    ///
    /// Any memory allocated via this function must be suitably aligned for any object type.
    /// If you are using C99 or earlier, this alignment is platform-dependent but will be the
    /// same as what `malloc` provides.If you are using C11 or later, this is the value of
    /// `alignof(max_align_t)`.
    ///
    /// The size will always be greater than zero.  Allocations of size zero are filtered out
    /// before reaching the custom allocator.
    ///
    /// If this function returns `NULL`, GLFW will emit <see cref="ErrorCode.OutOfMemory"/>.
    ///
    /// This function must not call any GLFW function.
    ///
    /// Added in version 3.4.
    /// </summary>
    /// <remarks>
    /// The returned memory block must be valid at least until it is deallocated.
    ///
    /// This function should not call any GLFW function.
    ///
    /// This function must support being called from any thread that calls GLFW functions.
    /// </remarks>
    /// <param name="size">The minimum size, in bytes, of the memory block.</param>
    /// <param name="user">The user-defined pointer from the allocator.</param>
    /// <returns>The address of the newly allocated memory block, or `NULL` if an error occurred.</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* GLFWallocatefun(UIntPtr size, void* user);

    /// <summary>
    /// The function pointer type for memory reallocation callbacks.
    ///
    /// This is the function pointer type for memory reallocation callbacks.
    /// A memory reallocation callback function has the following signature:
    /// <code>
    /// void* function_name(void* block, size_t size, void* user)
    /// </code>
    ///
    /// This function must return a memory block at least <c>size</c> bytes long, or
    /// <c>null</c> if allocation failed. Note that not all parts of GLFW handle allocation
    /// failures gracefully yet.
    ///
    /// This function must support being called during <see cref="glfwInit"/> but before the library is
    /// flagged as initialized, as well as during <see cref="glfwTerminate"/> after the library is no
    /// longer flagged as initialized.
    ///
    /// Any memory allocated via this function will be deallocated via the same allocator
    /// during library termination or earlier.
    ///
    /// Any memory allocated via this function must be suitably aligned for any object type.
    /// If you are using C99 or earlier, this alignment is platform-dependent but will be the
    /// same as what <c>realloc</c> provides.If you are using C11 or later, this is the value of
    /// <c>alignof(max_align_t)</c>.
    ///
    /// The block address will never be <c>null</c> and the size will always be greater than zero.
    /// Reallocations of a block to size zero are converted into deallocations before reaching
    /// the custom allocator.Reallocations of <c>null</c> to a non-zero size are converted into
    /// regular allocations before reaching the custom allocator.
    ///
    /// If this function returns <c>null</c>, GLFW will emit <see cref="ErrorCode.OutOfMemory"/>.
    ///
    /// This function must not call any GLFW function.
    /// </summary>
    /// <remarks>
    ///  The returned memory block must be valid at least until it is deallocated.
    ///
    /// This function should not call any GLFW function.
    ///
    /// This function must support being called from any thread that calls GLFW functions.
    /// </remarks>
    /// <param name="block">The address of the memory block to reallocate.</param>
    /// <param name="size">The new minimum size, in bytes, of the memory block.</param>
    /// <param name="user">The user-defined pointer from the allocator.</param>
    /// <returns>The address of the newly allocated or resized memory block, or <c>null</c> if an error occurred.</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* GLFWreallocatefun(void* block, UIntPtr size, void* user);

    /// <summary>
    /// The function pointer type for memory deallocation callbacks.
    ///
    /// This is the function pointer type for memory deallocation callbacks.
    /// A memory deallocation callback function has the following signature:
    /// @code
    /// void function_name(void* block, void* user)
    /// @endcode
    ///
    /// This function may deallocate the specified memory block.This memory block
    /// will have been allocated with the same allocator.
    ///
    /// This function must support being called during @ref glfwInit but before the library is
    /// flagged as initialized, as well as during @ref glfwTerminate after the library is no
    /// longer flagged as initialized.
    ///
    /// The block address will never be `NULL`.  Deallocations of `NULL` are filtered out
    /// before reaching the custom allocator.
    ///
    /// If this function returns `NULL`, GLFW will emit @ref GLFW_OUT_OF_MEMORY.
    ///
    /// This function must not call any GLFW function.
    /// </summary>
    /// <remarks>
    /// The specified memory block will not be accessed by GLFW after this function is called.
    ///
    /// This function should not call any GLFW function.
    ///
    /// This function must support being called from any thread that calls GLFW functions.
    /// </remarks>
    /// <param name="block">The address of the memory block to deallocate.</param>
    /// <param name="user">The user-defined pointer from the allocator.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void GLFWdeallocatefun(void* block, void* user);

    public unsafe struct GLFWallocator
    {
        /// <summary>
        /// The memory allocation function.  See <see cref="GLFWallocatefun"/> for details about allocation function.
        /// </summary>
        public GLFWallocatefun Allocate;

        /// <summary>
        /// The memory reallocation function.  See <see cref="GLFWreallocatefun"/> for details about reallocation function.
        /// </summary>
        public GLFWreallocatefun Reallocate;

        /// <summary>
        /// The memory deallocation function.  See <see cref="GLFWdeallocatefun"/> for details about deallocation function.
        /// </summary>
        public GLFWdeallocatefun Deallocate;

        /// <summary>
        /// The user pointer for this custom allocator.  This value will be passed to the allocator functions.
        /// </summary>
        public void* User;
    }
}
