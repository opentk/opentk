#region License
/*
MIT License
Copyright ©2003-2006 Tao Framework Team
http://www.taoframework.com
All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License

// Disable missing XML comment warnings
#pragma warning disable 1591 

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Collections.Generic;
using System.Text;

namespace Tao.OpenAl
{
    #region Class Documentation
    /// <summary>
    ///     OpenAL binding for .NET, implementing ALC 1.1.
    /// </summary>
    /// <remarks>
    ///     Binds functions and definitions in OpenAL32.dll or libAL.so.
    /// </remarks>
    #endregion Class Documentation
    [Obsolete("Use OpenTK.Audio.OpenAL instead.")]
    public static class Alc
    {
        // --- Fields ---
        #region Private Constants
        #region string ALC_NATIVE_LIBRARY
        /// <summary>
        ///     Specifies OpenAl's native library archive.
        /// </summary>
        /// <remarks>
        ///     Specifies OpenAl32.dll everywhere; will be mapped via .config for mono.
        /// </remarks>
        private const string ALC_NATIVE_LIBRARY = "OpenAL32.dll";
        #endregion string ALC_NATIVE_LIBRARY

        #region CallingConvention CALLING_CONVENTION
        /// <summary>
        ///     Specifies the calling convention.
        /// </summary>
        /// <remarks>
        ///     Specifies <see cref="CallingConvention.Cdecl" />.
        /// </remarks>
        private const CallingConvention CALLING_CONVENTION = CallingConvention.Cdecl;
        #endregion CallingConvention CALLING_CONVENTION
        #endregion Private Constants

        #region Public OpenAL 1.1 Constants
        #region ALC_INVALID
        /// <summary>
        ///     Bad value.
        /// </summary>
        // #define ALC_INVALID (0)
        public const int ALC_INVALID = (0);
        #endregion ALC_INVALID

        #region ALC_FALSE
        /// <summary>
        ///     bool false.
        /// </summary>
        // #define ALC_FALSE 0
        public const int ALC_FALSE = 0;
        #endregion ALC_FALSE

        #region ALC_TRUE
        /// <summary>
        ///     bool true.
        /// </summary>
        // #define ALC_TRUE 1
        public const int ALC_TRUE = 1;
        #endregion ALC_TRUE

        #region ALC_NO_ERROR
        /// <summary>
        ///     No error.
        /// </summary>
        // #define ALC_NO_ERROR ALC_FALSE
        public const int ALC_NO_ERROR = ALC_FALSE;
        #endregion ALC_NO_ERROR

        #region ALC_MAJOR_VERSION
        /// <summary>
        ///     Major version.
        /// </summary>
        // #define ALC_MAJOR_VERSION 0x1000
        public const int ALC_MAJOR_VERSION = 0x1000;
        #endregion ALC_MAJOR_VERSION

        #region ALC_MINOR_VERSION
        /// <summary>
        ///     Minor version.
        /// </summary>
        // #define ALC_MINOR_VERSION 0x1001
        public const int ALC_MINOR_VERSION = 0x1001;
        #endregion ALC_MINOR_VERSION

        #region ALC_ATTRIBUTES_SIZE
        /// <summary>
        ///     Attributes size.
        /// </summary>
        // #define ALC_ATTRIBUTES_SIZE 0x1002
        public const int ALC_ATTRIBUTES_SIZE = 0x1002;
        #endregion ALC_ATTRIBUTES_SIZE

        #region ALC_ALL_ATTRIBUTES
        /// <summary>
        ///     All attributes.
        /// </summary>
        // #define ALC_ALL_ATTRIBUTES 0x1003
        public const int ALC_ALL_ATTRIBUTES = 0x1003;
        #endregion ALC_ALL_ATTRIBUTES

        #region ALC_CAPTURE_DEVICE_SPECIFIER
        /// <summary>
        ///     Capture device specifier.
        /// </summary>
        // #define ALC_CAPTURE_DEVICE_SPECIFIER 0x310
        public const int ALC_CAPTURE_DEVICE_SPECIFIER = 0x310;
        #endregion ALC_CAPTURE_DEVICE_SPECIFIER

        #region ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER
        /// <summary>
        ///     Capture default device specifier.
        /// </summary>
        // #define ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER 0x311
        public const int ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER = 0x311;
        #endregion ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER

        #region ALC_CAPTURE_SAMPLES
        /// <summary>
        ///     Capture samples.
        /// </summary>
        // #define ALC_CAPTURE_SAMPLES 0x312
        public const int ALC_CAPTURE_SAMPLES = 0x312;
        #endregion ALC_CAPTURE_SAMPLES

        #region ALC_DEFAULT_DEVICE_SPECIFIER
        /// <summary>
        ///     Default device specifier.
        /// </summary>
        // #define ALC_DEFAULT_DEVICE_SPECIFIER 0x1004
        public const int ALC_DEFAULT_DEVICE_SPECIFIER = 0x1004;
        #endregion ALC_DEFAULT_DEVICE_SPECIFIER

        #region ALC_DEVICE_SPECIFIER
        /// <summary>
        ///     Device specifier.
        /// </summary>
        // #define ALC_DEVICE_SPECIFIER 0x1005
        public const int ALC_DEVICE_SPECIFIER = 0x1005;
        #endregion ALC_DEVICE_SPECIFIER

        #region ALC_EXTENSIONS
        /// <summary>
        ///     Extensions.
        /// </summary>
        // #define ALC_EXTENSIONS 0x1006
        public const int ALC_EXTENSIONS = 0x1006;
        #endregion ALC_EXTENSIONS

        #region ALC_FREQUENCY
        /// <summary>
        ///     Frequency.
        /// </summary>
        // #define ALC_FREQUENCY 0x1007
        public const int ALC_FREQUENCY = 0x1007;
        #endregion ALC_FREQUENCY

        #region ALC_REFRESH
        /// <summary>
        ///     Refresh.
        /// </summary>
        // #define ALC_REFRESH 0x1008
        public const int ALC_REFRESH = 0x1008;
        #endregion ALC_REFRESH

        #region ALC_SYNC
        /// <summary>
        ///     Sync.
        /// </summary>
        // #define ALC_SYNC 0x1009
        public const int ALC_SYNC = 0x1009;
        #endregion ALC_SYNC

        #region ALC_MONO_SOURCES
        /// <summary>
        ///     Num of requested Mono (3D) Sources
        /// </summary>
        // #define ALC_MONO_SOURCES 0x1010
        public const int ALC_MONO_SOURCES = 0x1010;
        #endregion ALC_MONO_SOURCES

        #region ALC_STEREO_SOURCES
        /// <summary>
        ///     Num of requested Stereo Sources
        /// </summary>
        // #define ALC_STEREO_SOURCES 0x1011
        public const int ALC_STEREO_SOURCES = 0x1011;
        #endregion ALC_STEREO_SOURCES

        #region ALC_INVALID_DEVICE
        /// <summary>
        ///     The device argument does not name a valid device.
        /// </summary>
        // #define ALC_INVALID_DEVICE 0xA001
        public const int ALC_INVALID_DEVICE = 0xA001;
        #endregion ALC_INVALID_DEVICE

        #region ALC_INVALID_CONTEXT
        /// <summary>
        ///     The context argument does not name a valid context.
        /// </summary>
        // #define ALC_INVALID_CONTEXT 0xA002
        public const int ALC_INVALID_CONTEXT = 0xA002;
        #endregion ALC_INVALID_CONTEXT

        #region ALC_INVALID_ENUM
        /// <summary>
        ///     A function was called at inappropriate time, or in an inappropriate way, causing
        ///     an illegal state.  This can be an incompatible value, object ID, and/or function.
        /// </summary>
        // #define ALC_INVALID_ENUM 0xA003
        public const int ALC_INVALID_ENUM = 0xA003;
        #endregion ALC_INVALID_ENUM

        #region ALC_INVALID_VALUE
        /// <summary>
        ///     Illegal value passed as an argument to an AL call.  Applies to parameter values,
        ///     but not to enumerations.
        /// </summary>
        // #define ALC_INVALID_VALUE 0xA004
        public const int ALC_INVALID_VALUE = 0xA004;
        #endregion ALC_INVALID_VALUE

        #region ALC_OUT_OF_MEMORY
        /// <summary>
        ///     A function could not be completed, because there is not enough memory available.
        /// </summary>
        // #define ALC_OUT_OF_MEMORY 0xA005
        public const int ALC_OUT_OF_MEMORY = 0xA005;
        #endregion ALC_OUT_OF_MEMORY

        #region ALC_ENUMERATE_ALL_EXT
        public const int ALC_DEFAULT_ALL_DEVICES_SPECIFIER = 0x1012;
        public const int ALC_ALL_DEVICES_SPECIFIER = 0x1013;
        #endregion

        #region ALC_EFX_EXT
        public const string ALC_EXT_EFX_NAME = "ALC_EXT_EFX";
        public const int ALC_EFX_MAJOR_VERSION = 0x20001;
        public const int ALC_EFX_MINOR_VERSION = 0x20002;
        public const int ALC_MAX_AUXILIARY_SENDS = 0x20003;
        #endregion

        #endregion Public OpenAL 1.0 Constants

        // --- Public Externs ---
        #region Public OpenAL 1.1 Methods
        #region alcCloseDevice([In] IntPtr device)
        /// <summary>
        ///     Closes a device.
        /// </summary>
        /// <param name="device">
        ///     A pointer to an opened device.
        /// </param>
        // ALCAPI ALCvoid ALCAPIENTRY alcCloseDevice(ALCdevice *device);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern void alcCloseDevice([In] IntPtr device);
        #endregion alcCloseDevice([In] IntPtr device)

        #region IntPtr alcCreateContext([In] IntPtr device, [In] ref int attribute)
        /// <summary>
        ///     Creates a context using a specified device.
        /// </summary>
        /// <param name="device">
        ///     A pointer to a device.
        /// </param>
        /// <param name="attribute">
        ///     <para>
        ///         A pointer to a set of attributes:
        ///     </para>
        ///     <para>
        ///         <list type="bullet">
        ///             <item><see cref="ALC_FREQUENCY" /></item>
        ///             <item><see cref="ALC_REFRESH" /></item>
        ///             <item><see cref="ALC_SYNC" /></item>
        ///         </list>
        ///     </para>
        /// </param>
        /// <returns>
        ///     Returns a pointer to the new context (IntPtr.Zero on failure).
        /// </returns>
        // ALCAPI ALCcontext* ALCAPIENTRY alcCreateContext(ALCdevice *device, ALCint *attrList);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr alcCreateContext([In] IntPtr device, [In] ref int attribute);
        #endregion IntPtr alcCreateContext([In] IntPtr device, [In] ref int attribute)

        #region IntPtr alcCreateContext([In] IntPtr device, [In] int[] attribute)
        /// <summary>
        ///     Creates a context using a specified device.
        /// </summary>
        /// <param name="device">
        ///     A pointer to a device.
        /// </param>
        /// <param name="attribute">
        ///     <para>
        ///         A pointer to a set of attributes:
        ///     </para>
        ///     <para>
        ///         <list type="bullet">
        ///             <item><see cref="ALC_FREQUENCY" /></item>
        ///             <item><see cref="ALC_REFRESH" /></item>
        ///             <item><see cref="ALC_SYNC" /></item>
        ///         </list>
        ///     </para>
        /// </param>
        /// <returns>
        ///     Returns a pointer to the new context (IntPtr.Zero on failure).
        /// </returns>
        // ALCAPI ALCcontext* ALCAPIENTRY alcCreateContext(ALCdevice *device, ALCint *attrList);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr alcCreateContext([In] IntPtr device, [In] int[] attribute);
        #endregion IntPtr alcCreateContext([In] IntPtr device, [In] int[] attribute)

        #region IntPtr alcCreateContext([In] IntPtr device, [In] IntPtr attribute)
        /// <summary>
        ///     Creates a context using a specified device.
        /// </summary>
        /// <param name="device">
        ///     A pointer to a device.
        /// </param>
        /// <param name="attribute">
        ///     <para>
        ///         A pointer to a set of attributes:
        ///     </para>
        ///     <para>
        ///         <list type="bullet">
        ///             <item><see cref="ALC_FREQUENCY" /></item>
        ///             <item><see cref="ALC_REFRESH" /></item>
        ///             <item><see cref="ALC_SYNC" /></item>
        ///         </list>
        ///     </para>
        /// </param>
        /// <returns>
        ///     Returns a pointer to the new context (IntPtr.Zero on failure).
        /// </returns>
        // ALCAPI ALCcontext* ALCAPIENTRY alcCreateContext(ALCdevice *device, ALCint *attrList);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr alcCreateContext([In] IntPtr device, [In] IntPtr attribute);
        #endregion IntPtr alcCreateContext([In] IntPtr device, [In] IntPtr attribute)

        #region IntPtr alcCreateContext([In] IntPtr device, [In] int *attribute)
        /// <summary>
        ///     Creates a context using a specified device.
        /// </summary>
        /// <param name="device">
        ///     A pointer to a device.
        /// </param>
        /// <param name="attribute">
        ///     <para>
        ///         A pointer to a set of attributes:
        ///     </para>
        ///     <para>
        ///         <list type="bullet">
        ///             <item><see cref="ALC_FREQUENCY" /></item>
        ///             <item><see cref="ALC_REFRESH" /></item>
        ///             <item><see cref="ALC_SYNC" /></item>
        ///         </list>
        ///     </para>
        /// </param>
        /// <returns>
        ///     Returns a pointer to the new context (IntPtr.Zero on failure).
        /// </returns>
        // ALCAPI ALCcontext* ALCAPIENTRY alcCreateContext(ALCdevice *device, ALCint *attrList);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), CLSCompliant(false), SuppressUnmanagedCodeSecurity]
        public unsafe static extern IntPtr alcCreateContext([In] IntPtr device, [In] int* attribute);
        #endregion IntPtr alcCreateContext([In] IntPtr device, [In] int *attribute)

        #region alcDestroyContext([In] IntPtr context)
        /// <summary>
        ///     Destroys a context.
        /// </summary>
        /// <param name="context">
        ///     Pointer to the context to be destroyed.
        /// </param>
        // ALCAPI ALCvoid ALCAPIENTRY alcDestroyContext(ALCcontext *context);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern void alcDestroyContext([In] IntPtr context);
        #endregion alcDestroyContext([In] IntPtr context)

        #region IntPtr alcGetContextsDevice([In] IntPtr context)
        /// <summary>
        ///     Gets the device for a context.
        /// </summary>
        /// <param name="context">
        ///     The context to query.
        /// </param>
        /// <returns>
        ///     A pointer to a device or IntPtr.Zero on failue.
        /// </returns>
        // ALCAPI ALCdevice* ALCAPIENTRY alcGetContextsDevice(ALCcontext *context);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr alcGetContextsDevice([In] IntPtr context);
        #endregion IntPtr alcGetContextsDevice([In] IntPtr context)

        #region IntPtr alcGetCurrentContext()
        /// <summary>
        ///     Retrieves the current context.
        /// </summary>
        /// <returns>
        ///     Returns a pointer to the current context or IntPtr.Zero on failure.
        /// </returns>
        // ALCAPI ALCcontext* ALCAPIENTRY alcGetCurrentContext(ALCvoid);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr alcGetCurrentContext();
        #endregion IntPtr alcGetCurrentContext()

        #region int alcGetEnumValue([In] IntPtr device, string enumName)
        /// <summary>
        ///     Retrieves the enum value for a specified enumeration name.
        /// </summary>
        /// <param name="device">
        ///     The device to be queried.
        /// </param>
        /// <param name="enumName">
        ///     A null terminated string describing the enum value.
        /// </param>
        /// <returns>
        ///     Returns the enum value described by the <i>enumName</i> string.
        /// </returns>
        // ALCAPI ALCenum ALCAPIENTRY alcGetEnumValue(ALCdevice *device, ALCubyte *enumName);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        public static extern int alcGetEnumValue([In] IntPtr device, string enumName);
        #endregion int alcGetEnumValue([In] IntPtr device, string enumName)

        #region int alcGetError([In] IntPtr device)
        /// <summary>
        ///     Retrieves the current context error state.
        /// </summary>
        /// <param name="device">
        ///     The device to query.
        /// </param>
        /// <returns>
        ///     The current context error state will be returned.
        /// </returns>
        // ALCAPI ALCenum ALCAPIENTRY alcGetError(ALCdevice *device);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern int alcGetError([In] IntPtr device);
        #endregion int alcGetError([In] IntPtr device)

        #region alcGetIntegerv([In] IntPtr device, int attribute, int size, out int data)
        /// <summary>
        ///     Returns integers related to the context.
        /// </summary>
        /// <param name="device">
        ///     The device to be queried.
        /// </param>
        /// <param name="attribute">
        ///     <para>
        ///         An attribute to be retrieved:
        ///     </para>
        ///     <para>
        ///         <list type="bullet">
        ///             <item><see cref="ALC_MAJOR_VERSION" /></item>
        ///             <item><see cref="ALC_MINOR_VERSION" /></item>
        ///             <item><see cref="ALC_ATTRIBUTES_SIZE" /></item>
        ///             <item><see cref="ALC_ALL_ATTRIBUTES" /></item>
        ///         </list>
        ///     </para>
        /// </param>
        /// <param name="size">
        ///     The size of the destination buffer provided.
        /// </param>
        /// <param name="data">
        ///     A pointer to the data to be returned.
        /// </param>
        // ALCAPI ALCvoid ALCAPIENTRY alcGetIntegerv(ALCdevice *device, ALCenum param, ALCsizei size, ALCint *data);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern void alcGetIntegerv([In] IntPtr device, int attribute, int size, out int data);
        #endregion alcGetIntegerv([In] IntPtr device, int attribute, int size, out int data)

        #region alcGetIntegerv([In] IntPtr device, int attribute, int size, [Out] int[] data)
        /// <summary>
        ///     Returns integers related to the context.
        /// </summary>
        /// <param name="device">
        ///     The device to be queried.
        /// </param>
        /// <param name="attribute">
        ///     <para>
        ///         An attribute to be retrieved:
        ///     </para>
        ///     <para>
        ///         <list type="bullet">
        ///             <item><see cref="ALC_MAJOR_VERSION" /></item>
        ///             <item><see cref="ALC_MINOR_VERSION" /></item>
        ///             <item><see cref="ALC_ATTRIBUTES_SIZE" /></item>
        ///             <item><see cref="ALC_ALL_ATTRIBUTES" /></item>
        ///         </list>
        ///     </para>
        /// </param>
        /// <param name="size">
        ///     The size of the destination buffer provided.
        /// </param>
        /// <param name="data">
        ///     A pointer to the data to be returned.
        /// </param>
        // ALCAPI ALCvoid ALCAPIENTRY alcGetIntegerv(ALCdevice *device, ALCenum param, ALCsizei size, ALCint *data);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern void alcGetIntegerv([In] IntPtr device, int attribute, int size, [Out] int[] data);
        #endregion alcGetIntegerv([In] IntPtr device, int attribute, int size, [Out] int[] data)

        #region alcGetIntegerv([In] IntPtr device, int attribute, int size, [Out] IntPtr data)
        /// <summary>
        ///     Returns integers related to the context.
        /// </summary>
        /// <param name="device">
        ///     The device to be queried.
        /// </param>
        /// <param name="attribute">
        ///     <para>
        ///         An attribute to be retrieved:
        ///     </para>
        ///     <para>
        ///         <list type="bullet">
        ///             <item><see cref="ALC_MAJOR_VERSION" /></item>
        ///             <item><see cref="ALC_MINOR_VERSION" /></item>
        ///             <item><see cref="ALC_ATTRIBUTES_SIZE" /></item>
        ///             <item><see cref="ALC_ALL_ATTRIBUTES" /></item>
        ///         </list>
        ///     </para>
        /// </param>
        /// <param name="size">
        ///     The size of the destination buffer provided.
        /// </param>
        /// <param name="data">
        ///     A pointer to the data to be returned.
        /// </param>
        // ALCAPI ALCvoid ALCAPIENTRY alcGetIntegerv(ALCdevice *device, ALCenum param, ALCsizei size, ALCint *data);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern void alcGetIntegerv([In] IntPtr device, int attribute, int size, [Out] IntPtr data);
        #endregion alcGetIntegerv([In] IntPtr device, int attribute, int size, [Out] IntPtr data)

        #region alcGetIntegerv([In] IntPtr device, int attribute, int size, [Out] int *data)
        /// <summary>
        ///     Returns integers related to the context.
        /// </summary>
        /// <param name="device">
        ///     The device to be queried.
        /// </param>
        /// <param name="attribute">
        ///     <para>
        ///         An attribute to be retrieved:
        ///     </para>
        ///     <para>
        ///         <list type="bullet">
        ///             <item><see cref="ALC_MAJOR_VERSION" /></item>
        ///             <item><see cref="ALC_MINOR_VERSION" /></item>
        ///             <item><see cref="ALC_ATTRIBUTES_SIZE" /></item>
        ///             <item><see cref="ALC_ALL_ATTRIBUTES" /></item>
        ///         </list>
        ///     </para>
        /// </param>
        /// <param name="size">
        ///     The size of the destination buffer provided.
        /// </param>
        /// <param name="data">
        ///     A pointer to the data to be returned.
        /// </param>
        // ALCAPI ALCvoid ALCAPIENTRY alcGetIntegerv(ALCdevice *device, ALCenum param, ALCsizei size, ALCint *data);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), CLSCompliant(false), SuppressUnmanagedCodeSecurity]
        public unsafe static extern void alcGetIntegerv([In] IntPtr device, int attribute, int size, [Out] int* data);
        #endregion alcGetIntegerv([In] IntPtr device, int attribute, int size, [Out] int *data)

        #region IntPtr alcGetProcAddress([In] IntPtr device, string functionName)
        /// <summary>
        ///     Retrieves the address of a specified context extension function.
        /// </summary>
        /// <param name="device">
        ///     The device to be queried for the function.
        /// </param>
        /// <param name="functionName">
        ///     A null terminated string describing the function.
        /// </param>
        /// <returns>
        ///     Returns the address of the function, or IntPtr.Zero if it is not found.
        /// </returns>
        // ALCAPI ALCvoid* ALCAPIENTRY alcGetProcAddress(ALCdevice *device, ALCubyte *funcName);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr alcGetProcAddress([In] IntPtr device, string functionName);
        #endregion IntPtr alcGetProcAddress([In] IntPtr device, string functionName)

        #region string alcGetString([In] IntPtr device, int attribute)
        /// <summary>
        ///     Returns strings related to the context.
        /// </summary>
        /// <param name="device">
        ///     The device to be queried.
        /// </param>
        /// <param name="attribute">
        ///     <para>
        ///         An attribute to be retrieved:
        ///     </para>
        ///     <para>
        ///         <list type="bullet">
        ///             <item><see cref="ALC_DEFAULT_DEVICE_SPECIFIER" /></item>
        ///             <item><see cref="ALC_DEVICE_SPECIFIER" /></item>
        ///             <item><see cref="ALC_EXTENSIONS" /></item>
        ///         </list>
        ///     </para>
        /// </param>
        /// <returns>
        ///     Returns a pointer to a string.
        /// </returns>
        // ALCAPI ALCubyte* ALCAPIENTRY alcGetString(ALCdevice *device, ALCenum param);
        //[DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION, CharSet = CharSet.Ansi, EntryPoint = "alcGetString"), SuppressUnmanagedCodeSecurity]
        //public static extern string alcGetString([In] IntPtr device, int attribute);
        public static string alcGetString([In] IntPtr device, int attribute)
        {
            return Marshal.PtrToStringAnsi(alcGetStringInternal(device, attribute));
        }

        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION, CharSet = CharSet.Ansi, EntryPoint = "alcGetString"), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr alcGetStringInternal([In] IntPtr device, int attribute);

        /// <summary>
        ///     Returns strings related to the context.
        /// </summary>
        /// <param name="device">
        ///     The device to be queried.
        /// </param>
        /// <param name="attribute">
        ///     <para>
        ///         An attribute to be retrieved:
        ///     </para>
        ///     <para>
        ///         <list type="bullet">
        ///             <item><see cref="ALC_DEFAULT_DEVICE_SPECIFIER" /></item>
        ///             <item><see cref="ALC_DEVICE_SPECIFIER" /></item>
        ///             <item><see cref="ALC_EXTENSIONS" /></item>
        ///         </list>
        ///     </para>
        /// </param>
        /// <returns>
        ///     Returns a pointer to a string.
        /// </returns>
        public static string[] alcGetStringv([In] IntPtr device, int attribute)
        {
            return GetStringArray(alcGetStringInternal(device, attribute));
        }

        private static string[] GetStringArray(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }
            List<string> rv = new List<string>();
            StringBuilder builder = new StringBuilder();
            for (int index = 0; ; index++)
            {
                char ch = (char)Marshal.ReadByte(ptr, index);
                if (ch == '\0')
                {
                    if (builder.Length == 0)
                    {
                        break;
                    }
                    else
                    {
                        rv.Add(builder.ToString());
                        builder.Length = 0;
                    }
                }
                else
                {
                    builder.Append(ch);
                }
            }
            return rv.ToArray();
        }
        #endregion string alcGetString([In] IntPtr device, int attribute)

        #region int alcIsExtensionPresent([In] IntPtr device, string extensionName)
        /// <summary>
        ///     Queries if a specified context extension is available.
        /// </summary>
        /// <param name="device">
        ///     The device to be queried for an extension.
        /// </param>
        /// <param name="extensionName">
        ///     A null terminated string describing the extension.
        /// </param>
        /// <returns>
        ///     Returns <see cref="ALC_TRUE" /> if the extension is available,
        ///     <see cref="ALC_FALSE" /> if the extension is not available.
        /// </returns>
        // ALCAPI ALCboolean ALCAPIENTRY alcIsExtensionPresent(ALCdevice *device, ALCubyte *extName);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        public static extern int alcIsExtensionPresent([In] IntPtr device, string extensionName);
        #endregion int alcIsExtensionPresent([In] IntPtr device, string extensionName)

        #region int alcMakeContextCurrent([In] IntPtr context)
        /// <summary>
        ///     Makes a specified context the current context.
        /// </summary>
        /// <param name="context">
        ///     Pointer to the new context.
        /// </param>
        /// <returns>
        ///     Returns an error code on failure.
        /// </returns>
        // ALCAPI ALCboolean ALCAPIENTRY alcMakeContextCurrent(ALCcontext *context);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern int alcMakeContextCurrent([In] IntPtr context);
        #endregion int alcMakeContextCurrent([In] IntPtr context)

        #region IntPtr alcOpenDevice(string deviceName)
        /// <summary>
        ///     Opens a device by name.
        /// </summary>
        /// <param name="deviceName">
        ///     A null-terminated string describing a device.
        /// </param>
        /// <returns>
        ///     Returns a pointer to the opened device.
        /// </returns>
        // ALCAPI ALCdevice* ALCAPIENTRY alcOpenDevice(ALCubyte *deviceName);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr alcOpenDevice(string deviceName);
        #endregion IntPtr alcOpenDevice(string deviceName)

        #region alcProcessContext([In] IntPtr context)
        /// <summary>
        ///     Tells a context to begin processing.
        /// </summary>
        /// <param name="context">
        ///     Pointer to the new context.
        /// </param>
        // ALCAPI ALCvoid ALCAPIENTRY alcProcessContext(ALCcontext *context);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern void alcProcessContext([In] IntPtr context);
        #endregion alcProcessContext([In] IntPtr context)

        #region alcSuspendContext([In] IntPtr context)
        /// <summary>
        ///     Suspends processing on a specified context.
        /// </summary>
        /// <param name="context">
        ///     A pointer to the context to be suspended.
        /// </param>
        // ALCAPI ALCvoid ALCAPIENTRY alcSuspendContext(ALCcontext *context);
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern void alcSuspendContext([In] IntPtr context);
        #endregion alcSuspendContext([In] IntPtr context)

        #region IntPtr alcCaptureOpenDevice(string devicename, int frequency, int format, int buffersize)
        /// <summary>
        ///     
        /// </summary>
        /// <returns>
        ///     The Open Device will be captured
        /// </returns>
        // ALC_API ALCdevice* ALC_APIENTRY alcCaptureOpenDevice( const ALCchar *devicename, ALCuint frequency, ALCenum format, ALCsizei buffersize );
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr alcCaptureOpenDevice(string devicename, int frequency, int format, int buffersize);
        #endregion IntPtr alcCaptureOpenDevice(string devicename, int frequency, int format, int buffersize)

        #region int alcCaptureCloseDevice([In] IntPtr device)
        /// <summary>
        ///     
        /// </summary>
        /// <returns>
        ///     
        /// </returns>
        // ALC_API ALCboolean ALC_APIENTRY alcCaptureStart( ALCdevice *device );
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern int alcCaptureCloseDevice([In] IntPtr device);
        #endregion int alcCaptureCloseDevice([In] IntPtr device)

        #region void alcCaptureStart([In] IntPtr device)
        /// <summary>
        ///     
        /// </summary>
        /// <returns>
        ///     
        /// </returns>
        // ALC_API ALCboolean ALC_APIENTRY alcCaptureStart( ALCdevice *device );
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern void alcCaptureStart([In] IntPtr device);
        #endregion void alcCaptureStart([In] IntPtr device)

        #region void alcCaptureStop([In] IntPtr device)
        /// <summary>
        ///     
        /// </summary>
        /// <returns>
        ///     
        /// </returns>
        // ALC_API ALCboolean ALC_APIENTRY alcCaptureStop( ALCdevice *device );
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern void alcCaptureStop([In] IntPtr device);
        #endregion void alcCaptureStop([In] IntPtr device)

        #region void alcCaptureSamples([In] IntPtr device, [In] IntPtr buffer, int samples)
        /// <summary>
        ///     
        /// </summary>
        /// <returns>
        ///     
        /// </returns>
        // ALC_API ALCboolean ALC_APIENTRY alcCaptureSamples( ALCdevice *device, ALCvoid *buffer, ALCsizei samples );
        [DllImport(ALC_NATIVE_LIBRARY, CallingConvention = CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
        public static extern void alcCaptureSamples([In] IntPtr device, [In] IntPtr buffer, int samples);
        #endregion void alcCaptureSamples([In] IntPtr device, [In] IntPtr buffer, int samples)
        #endregion Public OpenAL 1.1 Methods

        #region Public OpenAL 1.1 Delegates
        #region IntPtr LPALCCREATECONTEXTDelegate([In] IntPtr device, [In] ref int attrlist)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr LPALCCREATECONTEXTDelegate([In] IntPtr device, [In] ref int attrlist);
        #endregion IntPtr LPALCCREATECONTEXTDelegate([In] IntPtr device, [In] ref int attrlist)

        #region int LPALCMAKECONTEXTCURRENTDelegate([In] IntPtr context)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int LPALCMAKECONTEXTCURRENTDelegate([In] IntPtr context);
        #endregion int LPALCMAKECONTEXTCURRENTDelegate([In] IntPtr context)

        #region void LPALCPROCESSCONTEXTDelegate([In] IntPtr context)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void LPALCPROCESSCONTEXTDelegate([In] IntPtr context);
        #endregion void LPALCPROCESSCONTEXTDelegate([In] IntPtr context)

        #region void LPALCSUSPENDCONTEXTDelegate([In] IntPtr context)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void LPALCSUSPENDCONTEXTDelegate([In] IntPtr context);
        #endregion void LPALCSUSPENDCONTEXTDelegate([In] IntPtr context)

        #region void LPALCDESTROYCONTEXTDelegate([In] IntPtr context)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void LPALCDESTROYCONTEXTDelegate([In] IntPtr context);
        #endregion void LPALCDESTROYCONTEXTDelegate([In] IntPtr context)

        #region IntPtr LPALCGETCURRENTECONTEXTDelegate()
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr LPALCGETCURRENTECONTEXTDelegate();
        #endregion IntPtr LPALCGETCURRENTECONTEXTDelegate()

        #region IntPtr LPALCCONTEXTSDEVICEDelegate([In] IntPtr context)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr LPALCGETCONTEXTSDEVICEDelegate([In] IntPtr context);
        #endregion IntPtr LPALCGETCONTEXTSDEVICEDelegate([In] IntPtr context)

        #region IntPtr LPALCOPENDEVICEDelegate(string devicename)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr LPALCOPENDEVICEDelegate(string devicename);
        #endregion IntPtr LPALCOPENDEVICEDelegate(string devicename)

        #region int LPALCCLOSEDEVICEDelegate([In] IntPtr device)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int LPALCCLOSEDEVICEDelegate([In] IntPtr device);
        #endregion int LPALCCLOSEDEVICEDelegate([In] IntPtr device)

        #region int LPALCCLOSEDEVICEDelegate([In] IntPtr device)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int LPALCGETERRORDelegate([In] IntPtr device);
        #endregion int LPALCCLOSEDEVICEDelegate([In] IntPtr device)

        #region int LPALCISEXTENSIONPRESENTDelegate([In] IntPtr device, string extname)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int LPALCISEXTENSIONPRESENTDelegate([In] IntPtr device, string extname);
        #endregion int LPALCISEXTENSIONPRESENTDelegate([In] IntPtr device, string extname)

        #region IntPtr LPALCGETPROCADDRESSDelegate([In] IntPtr device, string funcname)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr LPALCGETPROCADDRESSDelegate([In] IntPtr device, string funcname);
        #endregion IntPtr LPALCGETPROCADDRESSDelegate([In] IntPtr device, string funcname)

        #region int  LPALCGETENUMVALUEDelegate([In] IntPtr device, string enumname)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int LPALCGETENUMVALUEDelegate([In] IntPtr device, string enumname);
        #endregion int LPALCGETENUMVALUEDelegate([In] IntPtr device, string enumname)

        #region string LPALCGETSTRINGDelegate([In] IntPtr device, string enumname)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string LPALCGETSTRINGDelegate([In] IntPtr device, string enumname);
        #endregion string LPALCGETSTRINGDelegate([In] IntPtr device, string enumname)

        #region void LPALCGETINTEGERVDelegate([In] IntPtr context, int param, int size, out int data)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void LPALCGETINTEGERVDelegate([In] IntPtr context, int param, int size, out int data);
        #endregion void LPALCGETINTEGERVDelegate([In] IntPtr context, int param, int size, out int data)

        #region void LPALCCAPTUREOPENDEVICEDelegate(string devicename, int frequency, int format, int buffersize)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void LPALCCAPTUREOPENDEVICEDelegate(string devicename, int frequency, int format, int buffersize);
        #endregion void LPALCCAPTUREOPENDEVICEDelegate(string devicename, int frequency, int format, int buffersize)

        #region int LPALCCAPTURECLOSEDEVICEDelegate([In] IntPtr device)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int LPALCCAPTURECLOSEDEVICEDelegate([In] IntPtr device);
        #endregion int LPALCCAPTURECLOSEDEVICEDelegate([In] IntPtr device)

        #region void LPALCCAPTURESTARTDelegate([In] IntPtr device)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void LPALCCAPTURESTARTDelegate([In] IntPtr device);
        #endregion void LPALCCAPTURESTARTDelegate([In] IntPtr device)

        #region void LPALCCAPTURESTOPDelegate([In] IntPtr device)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void LPALCCAPTURESTOPDelegate([In] IntPtr device);
        #endregion void LPALCCAPTURESTOPDelegate([In] IntPtr device)

        #region void LPALCCAPTURESAMPLESDelegate([In] IntPtr device, [In] IntPtr buffer, int samples)
        /// <summary>
        /// 
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void LPALCCAPTURESAMPLESDelegate([In] IntPtr device, [In] IntPtr buffer, int samples);
        #endregion void LPALCCAPTURESAMPLESDelegate([In] IntPtr device, [In] IntPtr buffer, int samples)
        #endregion Public OpenAL 1.1 Delegates
    }
}
