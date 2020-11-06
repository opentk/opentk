//
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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using OpenTK.Audio.OpenAL.Native;
using OpenTK.Core;
using OpenTK.Core.Native;
using OpenTK.OpenAL;

namespace OpenTK.Audio.OpenAL
{
    /// <summary>Alc = Audio Library Context.</summary>
    public class ALC : ALBase
    {
        internal const string Lib = AL.Lib;
        internal const CallingConvention AlcCallingConv = CallingConvention.Cdecl;

        static ALC()
        {
            // We need to register the resolver for OpenAL before we can DllImport functions.
            ALBase.RegisterOpenALResolver();
        }

        private ALC()
        {
        }

        /// <summary>This function creates a context using a specified device.</summary>
        /// <param name="device">A pointer to a device.</param>
        /// <param name="attributeList">A zero terminated array of a set of attributes: ALC_FREQUENCY, ALC_MONO_SOURCES, ALC_REFRESH, ALC_STEREO_SOURCES, ALC_SYNC.</param>
        /// <returns>Returns a pointer to the new context (NULL on failure).</returns>
        /// <remarks>The attribute list can be NULL, or a zero terminated list of integer pairs composed of valid ALC attribute tokens and requested values.</remarks>
        [DllImport(Lib, EntryPoint = "alcCreateContext", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static unsafe extern ALContext CreateContext([In] ALDevice device, [In] int* attributeList);
        // ALC_API ALCcontext *    ALC_APIENTRY alcCreateContext( ALCdevice *device, const ALCint* attrlist );

        /// <summary>This function creates a context using a specified device.</summary>
        /// <param name="device">A pointer to a device.</param>
        /// <param name="attributeList">A zero terminated array of a set of attributes: ALC_FREQUENCY, ALC_MONO_SOURCES, ALC_REFRESH, ALC_STEREO_SOURCES, ALC_SYNC.</param>
        /// <returns>Returns a pointer to the new context (NULL on failure).</returns>
        /// <remarks>The attribute list can be NULL, or a zero terminated list of integer pairs composed of valid ALC attribute tokens and requested values.</remarks>
        [DllImport(Lib, EntryPoint = "alcCreateContext", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern ALContext CreateContext([In] ALDevice device, [In] ref int attributeList);
        // ALC_API ALCcontext *    ALC_APIENTRY alcCreateContext( ALCdevice *device, const ALCint* attrlist );

        /// <summary>This function creates a context using a specified device.</summary>
        /// <param name="device">A pointer to a device.</param>
        /// <param name="attributeList">A zero terminated array of a set of attributes: ALC_FREQUENCY, ALC_MONO_SOURCES, ALC_REFRESH, ALC_STEREO_SOURCES, ALC_SYNC.</param>
        /// <returns>Returns a pointer to the new context (NULL on failure).</returns>
        /// <remarks>The attribute list can be NULL, or a zero terminated list of integer pairs composed of valid ALC attribute tokens and requested values.</remarks>
        [DllImport(Lib, EntryPoint = "alcCreateContext", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern ALContext CreateContext([In] ALDevice device, [In] int[] attributeList);
        // ALC_API ALCcontext *    ALC_APIENTRY alcCreateContext( ALCdevice *device, const ALCint* attrlist );

        /// <summary>This function creates a context using a specified device.</summary>
        /// <param name="device">A pointer to a device.</param>
        /// <param name="attributeList">A zero terminated span of a set of attributes: ALC_FREQUENCY, ALC_MONO_SOURCES, ALC_REFRESH, ALC_STEREO_SOURCES, ALC_SYNC.</param>
        /// <returns>Returns a pointer to the new context (NULL on failure).</returns>
        /// <remarks>The attribute list can be NULL, or a zero terminated list of integer pairs composed of valid ALC attribute tokens and requested values.</remarks>
        public static ALContext CreateContext(ALDevice device, Span<int> attributeList)
        {
            return CreateContext(device, ref attributeList[0]);
        }

        /// <summary>This function creates a context using a specified device.</summary>
        /// <param name="device">A pointer to a device.</param>
        /// <param name="attributes">The ALContext attributes to request.</param>
        /// <returns>Returns a pointer to the new context (NULL on failure).</returns>
        /// <remarks>The attribute list can be NULL, or a zero terminated list of integer pairs composed of valid ALC attribute tokens and requested values.</remarks>
        public static ALContext CreateContext(ALDevice device, ALContextAttributes attributes)
        {
            return CreateContext(device, attributes.CreateAttributeArray());
        }

        /// <summary>This function makes a specified context the current context.</summary>
        /// <param name="context">A pointer to the new context.</param>
        /// <returns>Returns True on success, or False on failure.</returns>
        [DllImport(Lib, EntryPoint = "alcMakeContextCurrent", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern bool MakeContextCurrent(ALContext context);
        // ALC_API ALCboolean      ALC_APIENTRY alcMakeContextCurrent( ALCcontext *context );

        /// <summary>This function tells a context to begin processing. When a context is suspended, changes in OpenAL state will be accepted but will not be processed. alcSuspendContext can be used to suspend a context, and then all the OpenAL state changes can be applied at once, followed by a call to alcProcessContext to apply all the state changes immediately. In some cases, this procedure may be more efficient than application of properties in a non-suspended state. In some implementations, process and suspend calls are each a NOP.</summary>
        /// <param name="context">A pointer to the new context.</param>
        [DllImport(Lib, EntryPoint = "alcProcessContext", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern void ProcessContext(ALContext context);
        // ALC_API void            ALC_APIENTRY alcProcessContext( ALCcontext *context );

        /// <summary>This function suspends processing on a specified context. When a context is suspended, changes in OpenAL state will be accepted but will not be processed. A typical use of alcSuspendContext would be to suspend a context, apply all the OpenAL state changes at once, and then call alcProcessContext to apply all the state changes at once. In some cases, this procedure may be more efficient than application of properties in a non-suspended state. In some implementations, process and suspend calls are each a NOP.</summary>
        /// <param name="context">A pointer to the context to be suspended.</param>
        [DllImport(Lib, EntryPoint = "alcSuspendContext", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern void SuspendContext(ALContext context);
        // ALC_API void            ALC_APIENTRY alcSuspendContext( ALCcontext *context );

        /// <summary>This function destroys a context.</summary>
        /// <param name="context">A pointer to the new context.</param>
        [DllImport(Lib, EntryPoint = "alcDestroyContext", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern void DestroyContext(ALContext context);
        // ALC_API void            ALC_APIENTRY alcDestroyContext( ALCcontext *context );

        /// <summary>This function retrieves the current context.</summary>
        /// <returns>Returns a pointer to the current context.</returns>
        [DllImport(Lib, EntryPoint = "alcGetCurrentContext", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern ALContext GetCurrentContext();
        // ALC_API ALCcontext *    ALC_APIENTRY alcGetCurrentContext( void );

        /// <summary>This function retrieves a context's device pointer.</summary>
        /// <param name="context">A pointer to a context.</param>
        /// <returns>Returns a pointer to the specified context's device.</returns>
        [DllImport(Lib, EntryPoint = "alcGetContextsDevice", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern ALDevice GetContextsDevice(ALContext context);
        // ALC_API ALCdevice*      ALC_APIENTRY alcGetContextsDevice( ALCcontext *context );

        /// <summary>This function opens a device by name.</summary>
        /// <param name="devicename">A null-terminated string describing a device.</param>
        /// <returns>Returns a pointer to the opened device. The return value will be NULL if there is an error.</returns>
        [DllImport(Lib, EntryPoint = "alcOpenDevice", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static extern ALDevice OpenDevice([In] string devicename);
        // ALC_API ALCdevice *     ALC_APIENTRY alcOpenDevice( const ALCchar *devicename );

        /// <summary>This function closes a device by name.</summary>
        /// <param name="device">A pointer to an opened device.</param>
        /// <returns>True will be returned on success or False on failure. Closing a device will fail if the device contains any contexts or buffers.</returns>
        [DllImport(Lib, EntryPoint = "alcCloseDevice", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern bool CloseDevice([In] ALDevice device);
        // ALC_API ALCboolean      ALC_APIENTRY alcCloseDevice( ALCdevice *device );

        /// <summary>This function retrieves the current context error state.</summary>
        /// <param name="device">A pointer to the device to retrieve the error state from.</param>
        /// <returns>Errorcode Int32.</returns>
        [DllImport(Lib, EntryPoint = "alcGetError", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern AlcError GetError([In] ALDevice device);
        // ALC_API ALCenum         ALC_APIENTRY alcGetError( ALCdevice *device );

        /// <summary>This function queries if a specified context extension is available.</summary>
        /// <param name="device">A pointer to the device to be queried for an extension.</param>
        /// <param name="extname">A null-terminated string describing the extension.</param>
        /// <returns>Returns True if the extension is available, False if the extension is not available.</returns>
        [DllImport(Lib, EntryPoint = "alcIsExtensionPresent", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static extern bool IsExtensionPresent([In] ALDevice device, [In] string extname);
        // ALC_API ALCboolean      ALC_APIENTRY alcIsExtensionPresent( ALCdevice *device, const ALCchar *extname );

        /// <summary>This function queries if a specified context extension is available.</summary>
        /// <param name="device">A pointer to the device to be queried for an extension.</param>
        /// <param name="extname">A null-terminated string describing the extension.</param>
        /// <returns>Returns True if the extension is available, False if the extension is not available.</returns>
        [DllImport(Lib, EntryPoint = "alcIsExtensionPresent", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static extern bool IsExtensionPresent([In] ALCaptureDevice device, [In] string extname);
        // ALC_API ALCboolean      ALC_APIENTRY alcIsExtensionPresent( ALCdevice *device, const ALCchar *extname );

        /// <summary>This function retrieves the address of a specified context extension function.</summary>
        /// <param name="device">a pointer to the device to be queried for the function.</param>
        /// <param name="funcname">a null-terminated string describing the function.</param>
        /// <returns>Returns the address of the function, or NULL if it is not found.</returns>
        [DllImport(Lib, EntryPoint = "alcGetProcAddress", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi),]
        public static extern IntPtr GetProcAddress([In] ALDevice device, [In] string funcname);
        // ALC_API void  *         ALC_APIENTRY alcGetProcAddress( ALCdevice *device, const ALCchar *funcname );

        /// <summary>This function retrieves the enum value for a specified enumeration name.</summary>
        /// <param name="device">a pointer to the device to be queried.</param>
        /// <param name="enumname">a null terminated string describing the enum value.</param>
        /// <returns>Returns the enum value described by the enumName string. This is most often used for querying an enum value for an ALC extension.</returns>
        [DllImport(Lib, EntryPoint = "alcGetEnumValue", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static extern int GetEnumValue([In] ALDevice device, [In] string enumname);
        // ALC_API ALCenum         ALC_APIENTRY alcGetEnumValue( ALCdevice *device, const ALCchar *enumname );

        /// <summary>This strings related to the context.</summary>
        /// <remarks>
        /// ALC_DEFAULT_DEVICE_SPECIFIER will return the name of the default output device.
        /// ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER will return the name of the default capture device.
        /// ALC_DEVICE_SPECIFIER will return the name of the specified output device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied. A list is a pointer to a series of strings separated by NULL characters, with the list terminated by two NULL characters. See Enumeration Extension for more details.
        /// ALC_CAPTURE_DEVICE_SPECIFIER will return the name of the specified capture device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied.
        /// ALC_EXTENSIONS returns a list of available context extensions, with each extension separated by a space and the list terminated by a NULL character.
        /// </remarks>
        /// <param name="device">A pointer to the device to be queried.</param>
        /// <param name="param">An attribute to be retrieved: ALC_DEFAULT_DEVICE_SPECIFIER, ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER, ALC_DEVICE_SPECIFIER, ALC_CAPTURE_DEVICE_SPECIFIER, ALC_EXTENSIONS.</param>
        /// <returns>A string containing the name of the Device.</returns>
        [DllImport(Lib, EntryPoint = "alcGetString", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static unsafe extern byte* GetStringPtr([In] ALDevice device, AlcGetString param);
        // ALC_API const ALCchar * ALC_APIENTRY alcGetString( ALCdevice *device, ALCenum param );

        /// <summary>This strings related to the context.</summary>
        /// <remarks>
        /// ALC_DEFAULT_DEVICE_SPECIFIER will return the name of the default output device.
        /// ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER will return the name of the default capture device.
        /// ALC_DEVICE_SPECIFIER will return the name of the specified output device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied. A list is a pointer to a series of strings separated by NULL characters, with the list terminated by two NULL characters. See Enumeration Extension for more details.
        /// ALC_CAPTURE_DEVICE_SPECIFIER will return the name of the specified capture device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied.
        /// ALC_EXTENSIONS returns a list of available context extensions, with each extension separated by a space and the list terminated by a NULL character.
        /// </remarks>
        /// <param name="device">A pointer to the device to be queried.</param>
        /// <param name="param">An attribute to be retrieved: ALC_DEFAULT_DEVICE_SPECIFIER, ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER, ALC_DEVICE_SPECIFIER, ALC_CAPTURE_DEVICE_SPECIFIER, ALC_EXTENSIONS.</param>
        /// <returns>A string containing the name of the Device.</returns>
        [DllImport(Lib, EntryPoint = "alcGetString", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string GetString([In] ALDevice device, AlcGetString param);
        // ALC_API const ALCchar * ALC_APIENTRY alcGetString( ALCdevice *device, ALCenum param );

        /// <summary>This function returns a List of strings related to the context.</summary>
        /// <remarks>
        /// ALC_DEVICE_SPECIFIER will return the name of the specified output device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied. A list is a pointer to a series of strings separated by NULL characters, with the list terminated by two NULL characters. See Enumeration Extension for more details.
        /// ALC_CAPTURE_DEVICE_SPECIFIER will return the name of the specified capture device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied.
        /// ALC_EXTENSIONS returns a list of available context extensions, with each extension separated by a space and the list terminated by a NULL character.
        /// </remarks>
        /// <param name="device">A pointer to the device to be queried.</param>
        /// <param name="param">An attribute to be retrieved: ALC_DEVICE_SPECIFIER, ALC_CAPTURE_DEVICE_SPECIFIER, ALC_ALL_DEVICES_SPECIFIER.</param>
        /// <returns>A List of strings containing the names of the Devices.</returns>
        public static unsafe List<string> GetString(ALDevice device, AlcGetStringList param)
        {
            byte* result = GetStringPtr(device, (AlcGetString)param);
            return ALStringListToList(result);
        }

        /// <summary>This function returns a List of strings related to the context.</summary>
        /// <remarks>
        /// ALC_DEVICE_SPECIFIER will return the name of the specified output device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied. A list is a pointer to a series of strings separated by NULL characters, with the list terminated by two NULL characters. See Enumeration Extension for more details.
        /// ALC_CAPTURE_DEVICE_SPECIFIER will return the name of the specified capture device if a pointer is supplied, or will return a list of all available devices if a NULL device pointer is supplied.
        /// ALC_EXTENSIONS returns a list of available context extensions, with each extension separated by a space and the list terminated by a NULL character.
        /// </remarks>
        /// <param name="param">An attribute to be retrieved: ALC_DEVICE_SPECIFIER, ALC_CAPTURE_DEVICE_SPECIFIER, ALC_ALL_DEVICES_SPECIFIER.</param>
        /// <returns>A List of strings containing the names of the Devices.</returns>
        public static List<string> GetString(AlcGetStringList param) => GetString(ALDevice.Null, param);

        /// <summary>This function returns integers related to the context.</summary>
        /// <param name="device">a pointer to the device to be queried.</param>
        /// <param name="param">an attribute to be retrieved: ALC_MAJOR_VERSION, ALC_MINOR_VERSION, ALC_ATTRIBUTES_SIZE, ALC_ALL_ATTRIBUTES.</param>
        /// <param name="size">the size of the destination buffer provided, in number of integers.</param>
        /// <param name="data">a pointer to the buffer to be returned.</param>
        [DllImport(Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static unsafe extern void GetInteger(ALDevice device, AlcGetInteger param, int size, int* data);
        // ALC_API void            ALC_APIENTRY alcGetIntegerv( ALCdevice *device, ALCenum param, ALCsizei size, ALCint *buffer );

        /// <summary>This function returns integers related to the context.</summary>
        /// <param name="device">a pointer to the device to be queried.</param>
        /// <param name="param">an attribute to be retrieved: ALC_MAJOR_VERSION, ALC_MINOR_VERSION, ALC_ATTRIBUTES_SIZE, ALC_ALL_ATTRIBUTES.</param>
        /// <param name="size">the size of the destination buffer provided, in number of integers.</param>
        /// <param name="data">a pointer to the buffer to be returned.</param>
        [DllImport(Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static extern void GetInteger(ALDevice device, AlcGetInteger param, int size, int[] data);
        // ALC_API void            ALC_APIENTRY alcGetIntegerv( ALCdevice *device, ALCenum param, ALCsizei size, ALCint *buffer );

        /// <summary>This function returns integers related to the context.</summary>
        /// <param name="device">A pointer to the device to be queried.</param>
        /// <param name="param">An attribute to be retrieved: ALC_MAJOR_VERSION, ALC_MINOR_VERSION, ALC_ATTRIBUTES_SIZE, ALC_ALL_ATTRIBUTES.</param>
        /// <param name="size">The size of the destination buffer provided, in number of integers.</param>
        /// <param name="data">A pointer to the buffer to be returned.</param>
        [DllImport(Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static extern void GetInteger(ALDevice device, AlcGetInteger param, int size, out int data);
        // ALC_API void            ALC_APIENTRY alcGetIntegerv( ALCdevice *device, ALCenum param, ALCsizei size, ALCint *buffer );

        /// <summary>This function returns integers related to the context.</summary>
        /// <param name="device">A pointer to the device to be queried.</param>
        /// <param name="param">An attribute to be retrieved: ALC_MAJOR_VERSION, ALC_MINOR_VERSION, ALC_ATTRIBUTES_SIZE, ALC_ALL_ATTRIBUTES.</param>
        /// <param name="data">A pointer to the buffer to be returned.</param>
        public static void GetInteger(ALDevice device, AlcGetInteger param, out int data)
        {
            GetInteger(device, param, 1, out data);
        }

        /// <summary>This function returns integers related to the context.</summary>
        /// <param name="device">A pointer to the device to be queried.</param>
        /// <param name="param">An attribute to be retrieved: ALC_MAJOR_VERSION, ALC_MINOR_VERSION, ALC_ATTRIBUTES_SIZE, ALC_ALL_ATTRIBUTES.</param>
        /// <returns>The value returned.</returns>
        public static int GetInteger(ALDevice device, AlcGetInteger param)
        {
            GetInteger(device, param, 1, out int data);
            return data;
        }

        /// <summary>
        /// Returns a list of attributes for the current context of the specified device.
        /// </summary>
        /// <param name="device">The device to get attributes from.</param>
        /// <returns>A list of attributes for the device.</returns>
        public static int[] GetAttributeArray(ALDevice device)
        {
            GetInteger(device, AlcGetInteger.AttributesSize, 1, out int size);
            int[] attributes = new int[size];
            GetInteger(device, AlcGetInteger.AllAttributes, size, attributes);
            return attributes;
        }

        /// <summary>
        /// Returns a list of attributes for the current context of the specified device.
        /// </summary>
        /// <param name="device">The device to get attributes from.</param>
        /// <returns>A list of attributes for the device.</returns>
        public static ALContextAttributes GetContextAttributes(ALDevice device)
        {
            GetInteger(device, AlcGetInteger.AttributesSize, 1, out int size);
            int[] attributes = new int[size];
            GetInteger(device, AlcGetInteger.AllAttributes, size, attributes);
            return ALContextAttributes.FromArray(attributes);
        }

        // -------- ALC_EXT_CAPTURE --------

        /// <summary>
        /// Checks to see that the ALC_EXT_CAPTURE extension is present. This will always be available in 1.1 devices or later.
        /// </summary>
        /// <param name="device">The device to check the extension is present for.</param>
        /// <returns>If the ALC_EXT_CAPTURE extension was present.</returns>
        public static bool IsCaptureExtensionPresent(ALDevice device)
        {
            return IsExtensionPresent(device, "ALC_EXT_CAPTURE");
        }

        /// <summary>
        /// Checks to see that the ALC_EXT_CAPTURE extension is present. This will always be available in 1.1 devices or later.
        /// </summary>
        /// <param name="device">The device to check the extension is present for.</param>
        /// <returns>If the ALC_EXT_CAPTURE extension was present.</returns>
        public static bool IsCaptureExtensionPresent(ALCaptureDevice device)
        {
            return IsExtensionPresent(device, "ALC_EXT_CAPTURE");
        }

        /// <summary>This function opens a capture device by name. </summary>
        /// <param name="devicename">A pointer to a device name string.</param>
        /// <param name="frequency">The frequency that the buffer should be captured at.</param>
        /// <param name="format">The requested capture buffer format.</param>
        /// <param name="buffersize">The size of the capture buffer in samples, not bytes.</param>
        /// <returns>Returns the capture device pointer, or <see cref="ALCaptureDevice.Null"/> on failure.</returns>
        [DllImport(Lib, EntryPoint = "alcCaptureOpenDevice", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static extern ALCaptureDevice CaptureOpenDevice(string devicename, uint frequency, ALFormat format, int buffersize);
        // ALC_API ALCdevice*      ALC_APIENTRY alcCaptureOpenDevice( const ALCchar *devicename, ALCuint frequency, ALCenum format, ALCsizei buffersize );

        /// <summary>This function opens a capture device by name. </summary>
        /// <param name="devicename">A pointer to a device name string.</param>
        /// <param name="frequency">The frequency that the buffer should be captured at.</param>
        /// <param name="format">The requested capture buffer format.</param>
        /// <param name="buffersize">The size of the capture buffer in samples, not bytes.</param>
        /// <returns>Returns the capture device pointer, or <see cref="ALCaptureDevice.Null"/> on failure.</returns>
        [DllImport(Lib, EntryPoint = "alcCaptureOpenDevice", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static extern ALCaptureDevice CaptureOpenDevice(string devicename, int frequency, ALFormat format, int buffersize);
        // ALC_API ALCdevice*      ALC_APIENTRY alcCaptureOpenDevice( const ALCchar *devicename, ALCuint frequency, ALCenum format, ALCsizei buffersize );

        /// <summary>This function closes the specified capture device.</summary>
        /// <param name="device">A pointer to a capture device.</param>
        /// <returns>Returns True if the close operation was successful, False on failure.</returns>
        [DllImport(Lib, EntryPoint = "alcCaptureCloseDevice", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern bool CaptureCloseDevice([In] ALCaptureDevice device);
        // ALC_API ALCboolean      ALC_APIENTRY alcCaptureCloseDevice( ALCdevice *device );

        /// <summary>This function begins a capture operation.</summary>
        /// <remarks>alcCaptureStart will begin recording to an internal ring buffer of the size specified when opening the capture device. The application can then retrieve the number of samples currently available using the ALC_CAPTURE_SAPMPLES token with alcGetIntegerv. When the application determines that enough samples are available for processing, then it can obtain them with a call to alcCaptureSamples.</remarks>
        /// <param name="device">A pointer to a capture device.</param>
        [DllImport(Lib, EntryPoint = "alcCaptureStart", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern void CaptureStart([In] ALCaptureDevice device);
        // ALC_API void            ALC_APIENTRY alcCaptureStart( ALCdevice *device );

        /// <summary>This function stops a capture operation.</summary>
        /// <param name="device">A pointer to a capture device.</param>
        [DllImport(Lib, EntryPoint = "alcCaptureStop", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern void CaptureStop([In] ALCaptureDevice device);
        // ALC_API void            ALC_APIENTRY alcCaptureStop( ALCdevice *device );

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <param name="device">A pointer to a capture device.</param>
        /// <param name="buffer">A pointer to a buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">The number of samples to be retrieved.</param>
        [DllImport(Lib, EntryPoint = "alcCaptureSamples", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern void CaptureSamples(ALCaptureDevice device, IntPtr buffer, int samples);
        // ALC_API void            ALC_APIENTRY alcCaptureSamples( ALCdevice *device, ALCvoid *buffer, ALCsizei samples );

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <param name="device">A pointer to a capture device.</param>
        /// <param name="buffer">A pointer to a buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">The number of samples to be retrieved.</param>
        [DllImport(Lib, EntryPoint = "alcCaptureSamples", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static unsafe extern void CaptureSamples(ALCaptureDevice device, void* buffer, int samples);
        // ALC_API void            ALC_APIENTRY alcCaptureSamples( ALCdevice *device, ALCvoid *buffer, ALCsizei samples );

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <param name="device">A pointer to a capture device.</param>
        /// <param name="buffer">A pointer to a buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">The number of samples to be retrieved.</param>
        [DllImport(Lib, EntryPoint = "alcCaptureSamples", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern void CaptureSamples(ALCaptureDevice device, ref byte buffer, int samples);
        // ALC_API void            ALC_APIENTRY alcCaptureSamples( ALCdevice *device, ALCvoid *buffer, ALCsizei samples );

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <param name="device">A pointer to a capture device.</param>
        /// <param name="buffer">A pointer to a buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">The number of samples to be retrieved.</param>
        [DllImport(Lib, EntryPoint = "alcCaptureSamples", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static extern void CaptureSamples(ALCaptureDevice device, ref short buffer, int samples);
        // ALC_API void            ALC_APIENTRY alcCaptureSamples( ALCdevice *device, ALCvoid *buffer, ALCsizei samples );

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <typeparam name="T">The buffer datatype.</typeparam>
        /// <param name="device">A pointer to a capture device.</param>
        /// <param name="buffer">A reference to a buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">The number of samples to be retrieved.</param>
        public static unsafe void CaptureSamples<T>(ALCaptureDevice device, ref T buffer, int samples)
            where T : unmanaged
        {
            fixed (T* ptr = &buffer)
            {
                CaptureSamples(device, ptr, samples);
            }
        }

        /// <summary>This function completes a capture operation, and does not block.</summary>
        /// <typeparam name="T">The buffer datatype.</typeparam>
        /// <param name="device">A pointer to a capture device.</param>
        /// <param name="buffer">A buffer, which must be large enough to accommodate the number of samples.</param>
        /// <param name="samples">The number of samples to be retrieved.</param>
        public static void CaptureSamples<T>(ALCaptureDevice device, T[] buffer, int samples)
            where T : unmanaged
        {
            CaptureSamples(device, ref buffer[0], samples);
        }

        /// <summary>This function returns integers related to the context.</summary>
        /// <param name="device">A pointer to the device to be queried.</param>
        /// <param name="param">An attribute to be retrieved: ALC_MAJOR_VERSION, ALC_MINOR_VERSION, ALC_ATTRIBUTES_SIZE, ALC_ALL_ATTRIBUTES.</param>
        /// <param name="size">The size of the destination buffer provided, in number of integers.</param>
        /// <param name="data">A pointer to the buffer to be returned.</param>
        [DllImport(Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static unsafe extern void GetInteger(ALCaptureDevice device, AlcGetInteger param, int size, int* data);
        // ALC_API void            ALC_APIENTRY alcGetIntegerv( ALCdevice *device, ALCenum param, ALCsizei size, ALCint *buffer );

        /// <summary>This function returns integers related to the context.</summary>
        /// <param name="device">A pointer to the device to be queried.</param>
        /// <param name="param">An attribute to be retrieved: ALC_MAJOR_VERSION, ALC_MINOR_VERSION, ALC_ATTRIBUTES_SIZE, ALC_ALL_ATTRIBUTES.</param>
        /// <param name="size">The size of the destination buffer provided, in number of integers.</param>
        /// <param name="data">A pointer to the buffer to be returned.</param>
        [DllImport(Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static extern void GetInteger(ALCaptureDevice device, AlcGetInteger param, int size, int[] data);
        // ALC_API void            ALC_APIENTRY alcGetIntegerv( ALCdevice *device, ALCenum param, ALCsizei size, ALCint *buffer );

        /// <summary>This function returns integers related to the context.</summary>
        /// <param name="device">A pointer to the device to be queried.</param>
        /// <param name="param">An attribute to be retrieved: ALC_MAJOR_VERSION, ALC_MINOR_VERSION, ALC_ATTRIBUTES_SIZE, ALC_ALL_ATTRIBUTES.</param>
        /// <param name="size">The size of the destination buffer provided, in number of integers.</param>
        /// <param name="data">A pointer to the buffer to be returned.</param>
        [DllImport(Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = AlcCallingConv, CharSet = CharSet.Ansi)]
        public static extern void GetInteger(ALCaptureDevice device, AlcGetInteger param, int size, out int data);
        // ALC_API void            ALC_APIENTRY alcGetIntegerv( ALCdevice *device, ALCenum param, ALCsizei size, ALCint *buffer );

        /// <summary>
        /// Gets the current number of available capture samples.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <returns>The number of capture samples available.</returns>
        public static int GetAvailableSamples(ALCaptureDevice device)
        {
            GetInteger(device, AlcGetInteger.CaptureSamples, 1, out int result);
            return result;
        }

        // -------- ALC_ENUMERATION_EXT --------

        /// <summary>
        /// Checks to see that the ALC_ENUMERATION_EXT extension is present. This will always be available in 1.1 devices or later.
        /// </summary>
        /// <param name="device">The device to check the extension is present for.</param>
        /// <returns>If the ALC_ENUMERATION_EXT extension was present.</returns>
        public static bool IsEnumerationExtensionPresent(ALDevice device)
        {
            return IsExtensionPresent(device, "ALC_ENUMERATION_EXT");
        }

        /// <summary>
        /// Checks to see that the ALC_ENUMERATION_EXT extension is present. This will always be available in 1.1 devices or later.
        /// </summary>
        /// <param name="device">The device to check the extension is present for.</param>
        /// <returns>If the ALC_ENUMERATION_EXT extension was present.</returns>
        public static bool IsEnumerationExtensionPresent(ALCaptureDevice device)
        {
            return IsExtensionPresent(device, "ALC_ENUMERATION_EXT");
        }

        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        [DllImport(Lib, EntryPoint = "alcGetString", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string GetString(ALDevice device, GetEnumerationString param);

        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        [DllImport(Lib, EntryPoint = "alcGetString", ExactSpelling = true, CallingConvention = AlcCallingConv)]
        public static unsafe extern byte* GetStringListPtr(ALDevice device, GetEnumerationStringList param);

        /// <inheritdoc cref="GetString(ALDevice, GetEnumerationString)"/>
        public static unsafe IEnumerable<string> GetStringList(GetEnumerationStringList param)
        {
            byte* result = GetStringListPtr(ALDevice.Null, param);
            return ALStringListToList(result);
        }

        /// <summary>
        /// Used to convert a OpenAL string list to a C# List.
        /// </summary>
        /// <param name="alList">A pointer to the AL list. Usually returned from GetStringList like AL functions.</param>
        /// <returns>The string list.</returns>
        internal static unsafe List<string> ALStringListToList(byte* alList)
        {
            if (alList == (byte*)0)
            {
                return new List<string>();
            }

            var strings = new List<string>();

            byte* currentPos = alList;
            while (true)
            {
                var currentString = Marshal.PtrToStringAnsi(new IntPtr(currentPos));
                if (string.IsNullOrEmpty(currentString))
                {
                    break;
                }

                strings.Add(currentString);
                currentPos += currentString.Length + 1;
            }

            return strings;
        }
    }
}
