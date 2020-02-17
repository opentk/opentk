// ALC.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using OpenToolkit.Core;
using OpenToolkit.Core.Native;
using OpenToolkit.OpenAL;

namespace OpenToolkit.Audio.OpenAL
{
    /// <summary>Alc = Audio Library Context.</summary>
    [Api(Lib, typeof(OpenALLibraryNameContainer))]
    public class ALC : ApiContainer<ALC>
    {
        public const string Lib = AL.Lib;
        public const CallingConvention AlcCalliningConv = CallingConvention.Cdecl;

        static ALC()
        {
            // We need to trigger the static contructor of ApiContainer<ALC>.
            _ = ApiContainer<ALC>.StaticConstructorTrigger;
        }

        protected ALC()
        {
        }

        [DllImport(Lib, EntryPoint = "alcCreateContext", ExactSpelling = true, CallingConvention = AlcCalliningConv)]
        private static unsafe extern IntPtr sys_CreateContext([In] IntPtr device, [In] int* attrlist);

        /// <summary>This function creates a context using a specified device.</summary>
        /// <param name="device">a pointer to a device.</param>
        /// <param name="attrlist">a pointer to a set of attributes: ALC_FREQUENCY, ALC_MONO_SOURCES, ALC_REFRESH, ALC_STEREO_SOURCES, ALC_SYNC.</param>
        /// <returns>Returns a pointer to the new context (NULL on failure). The attribute list can be NULL, or a zero terminated list of integer pairs composed of valid ALC attribute tokens and requested values.</returns>
        public static unsafe ALContextHandle CreateContext([In] IntPtr device, [In] int* attrlist)
        {
            return new ALContextHandle(sys_CreateContext(device, attrlist));
        }

        // ALC_API ALCcontext *    ALC_APIENTRY alcCreateContext( ALCdevice *device, const ALCint* attrlist );

        /// <summary>This function creates a context using a specified device.</summary>
        /// <param name="device">a pointer to a device.</param>
        /// <param name="attriblist">an array of a set of attributes: ALC_FREQUENCY, ALC_MONO_SOURCES, ALC_REFRESH, ALC_STEREO_SOURCES, ALC_SYNC.</param>
        /// <returns>Returns a pointer to the new context (NULL on failure).</returns>
        /// <remarks>The attribute list can be NULL, or a zero terminated list of integer pairs composed of valid ALC attribute tokens and requested values.</remarks>
        public static ALContextHandle CreateContext(IntPtr device, int[] attriblist)
        {
            unsafe
            {
                fixed (int* attriblist_ptr = attriblist)
                {
                    return CreateContext(device, attriblist_ptr);
                }
            }
        }

        [DllImport(Lib, EntryPoint = "alcMakeContextCurrent", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        private static extern bool MakeContextCurrent(IntPtr context);

        /// <summary>This function makes a specified context the current context.</summary>
        /// <param name="context">A pointer to the new context.</param>
        /// <returns>Returns True on success, or False on failure.</returns>
        public static bool MakeContextCurrent(ALContextHandle context)
        {
            return MakeContextCurrent(context.Handle);
        }
        // ALC_API ALCboolean      ALC_APIENTRY alcMakeContextCurrent( ALCcontext *context );

        [DllImport(Lib, EntryPoint = "alcProcessContext", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        private static extern void ProcessContext(IntPtr context);

        /// <summary>This function tells a context to begin processing. When a context is suspended, changes in OpenAL state will be accepted but will not be processed. alcSuspendContext can be used to suspend a context, and then all the OpenAL state changes can be applied at once, followed by a call to alcProcessContext to apply all the state changes immediately. In some cases, this procedure may be more efficient than application of properties in a non-suspended state. In some implementations, process and suspend calls are each a NOP.</summary>
        /// <param name="context">A pointer to the new context.</param>
        public static void ProcessContext(ALContextHandle context)
        {
            ProcessContext(context.Handle);
        }
        // ALC_API void            ALC_APIENTRY alcProcessContext( ALCcontext *context );

        [DllImport(Lib, EntryPoint = "alcSuspendContext", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        private static extern void SuspendContext(IntPtr context);

        /// <summary>This function suspends processing on a specified context. When a context is suspended, changes in OpenAL state will be accepted but will not be processed. A typical use of alcSuspendContext would be to suspend a context, apply all the OpenAL state changes at once, and then call alcProcessContext to apply all the state changes at once. In some cases, this procedure may be more efficient than application of properties in a non-suspended state. In some implementations, process and suspend calls are each a NOP.</summary>
        /// <param name="context">a pointer to the context to be suspended.</param>
        public static void SuspendContext(ALContextHandle context)
        {
            SuspendContext(context.Handle);
        }
        // ALC_API void            ALC_APIENTRY alcSuspendContext( ALCcontext *context );

        [DllImport(Lib, EntryPoint = "alcDestroyContext", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        private static extern void DestroyContext(IntPtr context);

        /// <summary>This function destroys a context.</summary>
        /// <param name="context">a pointer to the new context.</param>
        public static void DestroyContext(ALContextHandle context)
        {
            DestroyContext(context.Handle);
        }
        // ALC_API void            ALC_APIENTRY alcDestroyContext( ALCcontext *context );

        [DllImport(Lib, EntryPoint = "alcGetCurrentContext", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr sys_GetCurrentContext();

        /// <summary>This function retrieves the current context.</summary>
        /// <returns>Returns a pointer to the current context.</returns>
        public static ALContextHandle GetCurrentContext()
        {
            return new ALContextHandle(sys_GetCurrentContext());
        }
        // ALC_API ALCcontext *    ALC_APIENTRY alcGetCurrentContext( void );

        [DllImport(Lib, EntryPoint = "alcGetContextsDevice", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr GetContextsDevice(IntPtr context);

        /// <summary>This function retrieves a context's device pointer.</summary>
        /// <param name="context">a pointer to a context.</param>
        /// <returns>Returns a pointer to the specified context's device.</returns>
        public static IntPtr GetContextsDevice(ALContextHandle context)
        {
            return GetContextsDevice(context.Handle);
        }
        // ALC_API ALCdevice*      ALC_APIENTRY alcGetContextsDevice( ALCcontext *context );

        /// <summary>This function opens a device by name.</summary>
        /// <param name="devicename">a null-terminated string describing a device.</param>
        /// <returns>Returns a pointer to the opened device. The return value will be NULL if there is an error.</returns>
        [DllImport(Lib, EntryPoint = "alcOpenDevice", ExactSpelling = true, CallingConvention = AlcCalliningConv, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr OpenDevice([In] string devicename);
        // ALC_API ALCdevice *     ALC_APIENTRY alcOpenDevice( const ALCchar *devicename );

        /// <summary>This function closes a device by name.</summary>
        /// <param name="device">a pointer to an opened device.</param>
        /// <returns>True will be returned on success or False on failure. Closing a device will fail if the device contains any contexts or buffers.</returns>
        [DllImport(Lib, EntryPoint = "alcCloseDevice", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        public static extern bool CloseDevice([In] IntPtr device);
        // ALC_API ALCboolean      ALC_APIENTRY alcCloseDevice( ALCdevice *device );

        /// <summary>This function retrieves the current context error state.</summary>
        /// <param name="device">a pointer to the device to retrieve the error state from.</param>
        /// <returns>Errorcode Int32.</returns>
        [DllImport(Lib, EntryPoint = "alcGetError", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        public static extern AlcError GetError([In] IntPtr device);
        // ALC_API ALCenum         ALC_APIENTRY alcGetError( ALCdevice *device );

        /// <summary>This function queries if a specified context extension is available.</summary>
        /// <param name="device">a pointer to the device to be queried for an extension.</param>
        /// <param name="extname">a null-terminated string describing the extension.</param>
        /// <returns>Returns True if the extension is available, False if the extension is not available.</returns>
        [DllImport(Lib, EntryPoint = "alcIsExtensionPresent", ExactSpelling = true, CallingConvention = AlcCalliningConv, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        public static extern bool IsExtensionPresent([In] IntPtr device, [In] string extname);
        // ALC_API ALCboolean      ALC_APIENTRY alcIsExtensionPresent( ALCdevice *device, const ALCchar *extname );

        /// <summary>This function retrieves the address of a specified context extension function.</summary>
        /// <param name="device">a pointer to the device to be queried for the function.</param>
        /// <param name="funcname">a null-terminated string describing the function.</param>
        /// <returns>Returns the address of the function, or NULL if it is not found.</returns>
        [DllImport(Lib, EntryPoint = "alcGetProcAddress", ExactSpelling = true, CallingConvention = AlcCalliningConv, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr GetProcAddress([In] IntPtr device, [In] string funcname);
        // ALC_API void  *         ALC_APIENTRY alcGetProcAddress( ALCdevice *device, const ALCchar *funcname );

        /// <summary>This function retrieves the enum value for a specified enumeration name.</summary>
        /// <param name="device">a pointer to the device to be queried.</param>
        /// <param name="enumname">a null terminated string describing the enum value.</param>
        /// <returns>Returns the enum value described by the enumName string. This is most often used for querying an enum value for an ALC extension.</returns>
        [DllImport(Lib, EntryPoint = "alcGetEnumValue", ExactSpelling = true, CallingConvention = AlcCalliningConv, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        public static extern int GetEnumValue([In] IntPtr device, [In] string enumname);
        // ALC_API ALCenum         ALC_APIENTRY alcGetEnumValue( ALCdevice *device, const ALCchar *enumname );

        [DllImport(Lib, EntryPoint = "alcGetString", ExactSpelling = true, CallingConvention = AlcCalliningConv, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr GetStringPrivate([In] IntPtr device, AlcGetString param);
        // ALC_API const ALCchar * ALC_APIENTRY alcGetString( ALCdevice *device, ALCenum param );

        /// <summary>This function returns pointers to strings related to the context.</summary>
        /// <remarks>
        /// ALC_DEFAULT_DEVICE_SPECIFIER will return the name of the default output device.
        /// ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER will return the name of the default capture device.
        /// ALC_DEVICE_SPECIFIER will return the name of the specified output device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied. A list is a pointer to a series of strings separated by NULL characters, with the list terminated by two NULL characters. See Enumeration Extension for more details.
        /// ALC_CAPTURE_DEVICE_SPECIFIER will return the name of the specified capture device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied.
        /// ALC_EXTENSIONS returns a list of available context extensions, with each extension separated by a space and the list terminated by a NULL character.
        /// </remarks>
        /// <param name="device">a pointer to the device to be queried.</param>
        /// <param name="param">an attribute to be retrieved: ALC_DEFAULT_DEVICE_SPECIFIER, ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER, ALC_DEVICE_SPECIFIER, ALC_CAPTURE_DEVICE_SPECIFIER, ALC_EXTENSIONS.</param>
        /// <returns>A string containing the name of the Device.</returns>
        public static string GetString(IntPtr device, AlcGetString param)
        {
            IntPtr pstr = GetStringPrivate(device, param);
            string str = string.Empty;
            if (pstr != IntPtr.Zero)
            {
                str = Marshal.PtrToStringAnsi(pstr);
            }
            return str;
        }

        /// <summary>This function returns a List of strings related to the context.</summary>
        /// <remarks>
        /// ALC_DEVICE_SPECIFIER will return the name of the specified output device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied. A list is a pointer to a series of strings separated by NULL characters, with the list terminated by two NULL characters. See Enumeration Extension for more details.
        /// ALC_CAPTURE_DEVICE_SPECIFIER will return the name of the specified capture device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied.
        /// ALC_EXTENSIONS returns a list of available context extensions, with each extension separated by a space and the list terminated by a NULL character.
        /// </remarks>
        /// <param name="device">a pointer to the device to be queried.</param>
        /// <param name="param">an attribute to be retrieved: ALC_DEVICE_SPECIFIER, ALC_CAPTURE_DEVICE_SPECIFIER, ALC_ALL_DEVICES_SPECIFIER.</param>
        /// <returns>A List of strings containing the names of the Devices.</returns>
        public static IList<string> GetString(IntPtr device, AlcGetStringList param)
        {
            List<string> result = new List<string>();

            // We cannot use Marshal.PtrToStringAnsi(),
            //  because alcGetString is defined to return either a nul-terminated string,
            //  or an array of nul-terminated strings terminated by an extra nul.
            // Marshal.PtrToStringAnsi() will fail in the latter case (it will only
            // return the very first string in the array.)
            // We'll have to marshal this ourselves.
            IntPtr t = GetStringPrivate(device, (AlcGetString)param);
            if (t != IntPtr.Zero)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                byte b;
                int offset = 0;
                do
                {
                    b = Marshal.ReadByte(t, offset++);
                    if (b != 0)
                    {
                        sb.Append((char)b);
                    }
                    else
                    {
                        // One string from the array is complete
                        result.Add(sb.ToString());

                        // Check whether the array has finished
                        // Note: offset already been increased through offset++ above
                        if (Marshal.ReadByte(t, offset) == 0)
                        {
                            // 2x consecutive nuls, we've read the whole array
                            break;
                        }
                        else
                        {
                            // Another string is starting, clear the StringBuilder
                            sb.Remove(0, sb.Length);
                        }
                    }
                }
                while (true);
            }
            else
            {
                Debug.Print("[Audio] Alc.GetString({0}, {1}) returned null.", device, param);
            }

            return result;
        }

        [DllImport(Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = AlcCalliningConv, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        private static unsafe extern void GetInteger(IntPtr device, AlcGetInteger param, int size, int* data);
        // ALC_API void            ALC_APIENTRY alcGetIntegerv( ALCdevice *device, ALCenum param, ALCsizei size, ALCint *buffer );

        /// <summary>This function returns integers related to the context.</summary>
        /// <param name="device">a pointer to the device to be queried.</param>
        /// <param name="param">an attribute to be retrieved: ALC_MAJOR_VERSION, ALC_MINOR_VERSION, ALC_ATTRIBUTES_SIZE, ALC_ALL_ATTRIBUTES.</param>
        /// <param name="size">the size of the destination buffer provided, in number of integers.</param>
        /// <param name="data">a pointer to the buffer to be returned.</param>
        public static void GetInteger(IntPtr device, AlcGetInteger param, int size, out int data)
        {
            unsafe
            {
                fixed (int* data_ptr = &data)
                {
                    GetInteger(device, param, size, data_ptr);
                }
            }
        }

        /// <summary>This function returns integers related to the context.</summary>
        /// <param name="device">a pointer to the device to be queried.</param>
        /// <param name="param">an attribute to be retrieved: ALC_MAJOR_VERSION, ALC_MINOR_VERSION, ALC_ATTRIBUTES_SIZE, ALC_ALL_ATTRIBUTES.</param>
        /// <param name="size">the size of the destination buffer provided, in number of integers.</param>
        /// <param name="data">a pointer to the buffer to be returned.</param>
        public static void GetInteger(IntPtr device, AlcGetInteger param, int size, int[] data)
        {
            unsafe
            {
                fixed (int* data_ptr = data)
                {
                    GetInteger(device, param, size, data_ptr);
                }
            }
        }

        /// <summary>This function opens a capture device by name. </summary>
        /// <param name="devicename">a pointer to a device name string.</param>
        /// <param name="frequency">the frequency that the buffer should be captured at.</param>
        /// <param name="format">the requested capture buffer format.</param>
        /// <param name="buffersize">the size of the capture buffer in samples, not bytes.</param>
        /// <returns>Returns the capture device pointer, or NULL on failure.</returns>
        [DllImport(Lib, EntryPoint = "alcCaptureOpenDevice", ExactSpelling = true, CallingConvention = AlcCalliningConv, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr CaptureOpenDevice(string devicename, uint frequency, ALFormat format, int buffersize);

        /// <summary>This function opens a capture device by name. </summary>
        /// <param name="devicename">a pointer to a device name string.</param>
        /// <param name="frequency">the frequency that the buffer should be captured at.</param>
        /// <param name="format">the requested capture buffer format.</param>
        /// <param name="buffersize">the size of the capture buffer in samples, not bytes.</param>
        /// <returns>Returns the capture device pointer, or NULL on failure.</returns>
        [DllImport(Lib, EntryPoint = "alcCaptureOpenDevice", ExactSpelling = true, CallingConvention = AlcCalliningConv, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity]
        public static extern IntPtr CaptureOpenDevice(string devicename, int frequency, ALFormat format, int buffersize);

        // ALC_API ALCdevice*      ALC_APIENTRY alcCaptureOpenDevice( const ALCchar *devicename, ALCuint frequency, ALCenum format, ALCsizei buffersize );

        /// <summary>This function closes the specified capture device.</summary>
        /// <param name="device">a pointer to a capture device.</param>
        /// <returns>Returns True if the close operation was successful, False on failure.</returns>
        [DllImport(Lib, EntryPoint = "alcCaptureCloseDevice", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        public static extern bool CaptureCloseDevice([In] IntPtr device);
        // ALC_API ALCboolean      ALC_APIENTRY alcCaptureCloseDevice( ALCdevice *device );

        /// <summary>This function begins a capture operation.</summary>
        /// <remarks>alcCaptureStart will begin recording to an internal ring buffer of the size specified when opening the capture device. The application can then retrieve the number of samples currently available using the ALC_CAPTURE_SAPMPLES token with alcGetIntegerv. When the application determines that enough samples are available for processing, then it can obtain them with a call to alcCaptureSamples.</remarks>
        /// <param name="device">a pointer to a capture device.</param>
        [DllImport(Lib, EntryPoint = "alcCaptureStart", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        public static extern void CaptureStart([In] IntPtr device);
        // ALC_API void            ALC_APIENTRY alcCaptureStart( ALCdevice *device );

        /// <summary>This function stops a capture operation.</summary>
        /// <param name="device">a pointer to a capture device.</param>
        [DllImport(Lib, EntryPoint = "alcCaptureStop", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        public static extern void CaptureStop([In] IntPtr device);
        // ALC_API void            ALC_APIENTRY alcCaptureStop( ALCdevice *device );

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <param name="device">a pointer to a capture device.</param>
        /// <param name="buffer">a pointer to a buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">the number of samples to be retrieved.</param>
        [DllImport(Lib, EntryPoint = "alcCaptureSamples", ExactSpelling = true, CallingConvention = AlcCalliningConv), SuppressUnmanagedCodeSecurity]
        public static extern void CaptureSamples(IntPtr device, IntPtr buffer, int samples);
        // ALC_API void            ALC_APIENTRY alcCaptureSamples( ALCdevice *device, ALCvoid *buffer, ALCsizei samples );

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <typeparam name="T">The buffer datatype.</typeparam>
        /// <param name="device">a pointer to a capture device.</param>
        /// <param name="buffer">a reference to a buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">the number of samples to be retrieved.</param>
        public static void CaptureSamples<T>(IntPtr device, ref T buffer, int samples)
            where T : unmanaged
        {
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                CaptureSamples(device, handle.AddrOfPinnedObject(), samples);
            }
            finally
            {
                handle.Free();
            }
        }

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <typeparam name="T">The buffer datatype.</typeparam>
        /// <param name="device">a pointer to a capture device.</param>
        /// <param name="buffer">a buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">the number of samples to be retrieved.</param>
        public static void CaptureSamples<T>(IntPtr device, T[] buffer, int samples)
            where T : unmanaged
        {
            CaptureSamples(device, ref buffer[0], samples);
        }

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <typeparam name="T">The buffer datatype.</typeparam>
        /// <param name="device">a pointer to a capture device.</param>
        /// <param name="buffer">a buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">the number of samples to be retrieved.</param>
        public static void CaptureSamples<T>(IntPtr device, T[,] buffer, int samples)
            where T : unmanaged
        {
            CaptureSamples(device, ref buffer[0, 0], samples);
        }

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <typeparam name="T">The buffer datatype.</typeparam>
        /// <param name="device">a pointer to a capture device.</param>
        /// <param name="buffer">a buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">the number of samples to be retrieved.</param>
        public static void CaptureSamples<T>(IntPtr device, T[,,] buffer, int samples)
            where T : unmanaged
        {
            CaptureSamples(device, ref buffer[0, 0, 0], samples);
        }
    }
}
