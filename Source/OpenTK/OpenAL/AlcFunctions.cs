#region --- OpenTK.OpenAL License ---
/* AlcFunctions.cs
 * C header: \OpenAL 1.1 SDK\include\Alc.h
 * Spec: http://www.openal.org/openal_webstf/specs/OpenAL11Specification.pdf
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details (MIT)
 * http://www.OpenTK.net
 */

/* Version History:
 * 0.1
 * 
 * 
 * 
 */
#endregion

using System;
using System.Runtime.InteropServices;
using System.Security;

/* Type Mapping
// 8-bit boolean 
typedef char ALCboolean;
 * byte
// character 
typedef char ALCchar;
 * byte
// signed 8-bit 2's complement integer 
typedef char ALCbyte;
 * byte

// unsigned 8-bit integer 
typedef unsigned char ALCubyte;
 * ubyte

// signed 16-bit 2's complement integer 
typedef short ALCshort;
 * short

// unsigned 16-bit integer 
typedef unsigned short ALCushort;
 * ushort

// unsigned 32-bit integer 
typedef unsigned int ALCuint;
 * uint
  
// signed 32-bit 2's complement integer 
typedef int ALCint;
 * int
// non-negative 32-bit binary integer size
typedef int ALCsizei;
 * int
// enumerated 32-bit value
typedef int ALCenum;
 * int

// 32-bit IEEE754 floating-point
typedef float ALCfloat;
 * float

// 64-bit IEEE754 floating-point
typedef double ALCdouble;
 * double
 
// void type (for opaque pointers only)
typedef void ALCvoid;
 * void
 
 * ALCdevice
 * ALCcontext *context
 * IntPtr
*/
 
namespace OpenTK.OpenAL
{
 /// <summary>Alc = Audio Library Context</summary>
    public static class Alc
    {
        #region Constants
        private const string Lib = Al.Lib;
        private const CallingConvention Style = CallingConvention.Cdecl;
        #endregion Constants

        #region Context Management
        // ALC_API ALCcontext *    ALC_APIENTRY alcCreateContext( ALCdevice *device, const ALCint* attrlist );
        [DllImport( Alc.Lib, EntryPoint = "alcCreateContext", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern IntPtr CreateContext( [In] IntPtr device, [In] IntPtr attrlist );

        // ALC_API ALCboolean      ALC_APIENTRY alcMakeContextCurrent( ALCcontext *context );
        [DllImport( Alc.Lib, EntryPoint = "alcMakeContextCurrent", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Al.Bool MakeContextCurrent( [In] IntPtr context );

        // ALC_API void            ALC_APIENTRY alcProcessContext( ALCcontext *context );
        [DllImport( Alc.Lib, EntryPoint = "alcProcessContext", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void ProcessContext( [In] IntPtr context );

        // ALC_API void            ALC_APIENTRY alcSuspendContext( ALCcontext *context );
        [DllImport( Alc.Lib, EntryPoint = "alcSuspendContext", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void SuspendContext( [In] IntPtr context );


        // ALC_API void            ALC_APIENTRY alcDestroyContext( ALCcontext *context );
        [DllImport( Alc.Lib, EntryPoint = "alcDestroyContext", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void DestroyContext( [In] IntPtr context );

        // ALC_API ALCcontext *    ALC_APIENTRY alcGetCurrentContext( void );
        [DllImport( Alc.Lib, EntryPoint = "alcGetCurrentContext", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern IntPtr GetCurrentContext( );

        // ALC_API ALCdevice*      ALC_APIENTRY alcGetContextsDevice( ALCcontext *context );
        [DllImport( Alc.Lib, EntryPoint = "alcGetContextsDevice", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern IntPtr GetContextsDevice( [In] IntPtr context );
        #endregion Context Management

        #region Device Management
        // ALC_API ALCdevice *     ALC_APIENTRY alcOpenDevice( const ALCchar *devicename );
        [DllImport( Alc.Lib, EntryPoint = "alcOpenDevice", ExactSpelling = true, CallingConvention = Alc.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        internal static extern IntPtr OpenDevice( [In] string devicename );

        // ALC_API ALCboolean      ALC_APIENTRY alcCloseDevice( ALCdevice *device );
        [DllImport( Alc.Lib, EntryPoint = "alcCloseDevice", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Al.Bool CloseDevice( [In] IntPtr device );
        #endregion Device Management

        #region Error support.
        // Obtain the most recent Context error

        // ALC_API ALCenum         ALC_APIENTRY alcGetError( ALCdevice *device );
        [DllImport( Alc.Lib, EntryPoint = "alcGetError", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Enums.AlcError GetError( [In] IntPtr device );
        #endregion Error support.

        #region Extension support.
        // Query for the presence of an extension, and obtain any appropriate function pointers and enum values.

        // ALC_API ALCboolean      ALC_APIENTRY alcIsExtensionPresent( ALCdevice *device, const ALCchar *extname );
        [DllImport( Alc.Lib, EntryPoint = "alcIsExtensionPresent", ExactSpelling = true, CallingConvention = Alc.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Al.Bool IsExtensionPresent( [In] IntPtr device, [In] string extname );

        // ALC_API void  *         ALC_APIENTRY alcGetProcAddress( ALCdevice *device, const ALCchar *funcname );
        [DllImport( Alc.Lib, EntryPoint = "alcGetProcAddress", ExactSpelling = true, CallingConvention = Alc.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        internal static extern IntPtr GetProcAddress( [In] IntPtr device, [In] string funcname );

        // ALC_API ALCenum         ALC_APIENTRY alcGetEnumValue( ALCdevice *device, const ALCchar *enumname );
        [DllImport( Alc.Lib, EntryPoint = "alcGetEnumValue", ExactSpelling = true, CallingConvention = Alc.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        internal static extern int GetEnumValue( [In] IntPtr device, [In] string enumname );
        #endregion Extension support.

        #region Query functions
        // ALC_API const ALCchar * ALC_APIENTRY alcGetString( ALCdevice *device, ALCenum param );
        [DllImport( Alc.Lib, EntryPoint = "alcGetString", ExactSpelling = true, CallingConvention = Alc.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        private static extern IntPtr GetStringInternal( [In] IntPtr device, Enums.AlcGetString param );
       
        internal static string GetString( IntPtr device, Enums.AlcGetString param )
        {
            return Marshal.PtrToStringAnsi( GetStringInternal( device, param ) );
        }

        internal static string GetStringDevices( )
        {
            return  Marshal.PtrToStringBSTR( GetStringInternal( Al.Null, Enums.AlcGetString.DeviceSpecifier ));
        }

        // ALC_API void            ALC_APIENTRY alcGetIntegerv( ALCdevice *device, ALCenum param, ALCsizei size, ALCint *data );
        [DllImport( Alc.Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = Alc.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void GetInteger( [In] IntPtr device, Enums.AlcGetInteger param, int sizeofdatainbytes, [Out] out int data );
        #endregion Query functions

        #region Capture functions
        // ALC_API ALCdevice*      ALC_APIENTRY alcCaptureOpenDevice( const ALCchar *devicename, ALCuint frequency, ALCenum format, ALCsizei buffersize );
        [DllImport( Alc.Lib, EntryPoint = "alcCaptureOpenDevice", ExactSpelling = true, CallingConvention = Alc.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        internal static extern IntPtr CaptureOpenDevice( string devicename, uint frequency, Enums.AlFormat format, int buffersize );

        // ALC_API ALCboolean      ALC_APIENTRY alcCaptureCloseDevice( ALCdevice *device );
        [DllImport( Alc.Lib, EntryPoint = "alcCaptureCloseDevice", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Al.Bool CaptureCloseDevice( [In] IntPtr device );

        // ALC_API void            ALC_APIENTRY alcCaptureStart( ALCdevice *device );
        [DllImport( Alc.Lib, EntryPoint = "alcCaptureStart", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void CaptureStart( [In] IntPtr device );

        // ALC_API void            ALC_APIENTRY alcCaptureStop( ALCdevice *device );
        [DllImport( Alc.Lib, EntryPoint = "alcCaptureStop", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void CaptureStop( [In] IntPtr device );

        // ALC_API void            ALC_APIENTRY alcCaptureSamples( ALCdevice *device, ALCvoid *buffer, ALCsizei samples );
        [DllImport( Alc.Lib, EntryPoint = "alcCaptureSamples", ExactSpelling = true, CallingConvention = Alc.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void CaptureSamples( [In] IntPtr device, [Out] out IntPtr buffer, [Out] out int samples );
        #endregion Capture functions

        /* delegates
   // Pointer-to-function types, useful for dynamically getting ALC entry points.

   typedef ALCcontext *   (ALC_APIENTRY *LPALCCREATECONTEXT) (ALCdevice *device, const ALCint *attrlist);
   typedef ALCboolean     (ALC_APIENTRY *LPALCMAKECONTEXTCURRENT)( ALCcontext *context );
   typedef void           (ALC_APIENTRY *LPALCPROCESSCONTEXT)( ALCcontext *context );
   typedef void           (ALC_APIENTRY *LPALCSUSPENDCONTEXT)( ALCcontext *context );
   typedef void           (ALC_APIENTRY *LPALCDESTROYCONTEXT)( ALCcontext *context );
   typedef ALCcontext *   (ALC_APIENTRY *LPALCGETCURRENTCONTEXT)( void );
   typedef ALCdevice *    (ALC_APIENTRY *LPALCGETCONTEXTSDEVICE)( ALCcontext *context );
   typedef ALCdevice *    (ALC_APIENTRY *LPALCOPENDEVICE)( const ALCchar *devicename );
   typedef ALCboolean     (ALC_APIENTRY *LPALCCLOSEDEVICE)( ALCdevice *device );
   typedef ALCenum        (ALC_APIENTRY *LPALCGETERROR)( ALCdevice *device );
   typedef ALCboolean     (ALC_APIENTRY *LPALCISEXTENSIONPRESENT)( ALCdevice *device, const ALCchar *extname );
   typedef void *         (ALC_APIENTRY *LPALCGETPROCADDRESS)(ALCdevice *device, const ALCchar *funcname );
   typedef ALCenum        (ALC_APIENTRY *LPALCGETENUMVALUE)(ALCdevice *device, const ALCchar *enumname );
   typedef const ALCchar* (ALC_APIENTRY *LPALCGETSTRING)( ALCdevice *device, ALCenum param );
   typedef void           (ALC_APIENTRY *LPALCGETINTEGERV)( ALCdevice *device, ALCenum param, ALCsizei size, ALCint *dest );
   typedef ALCdevice *    (ALC_APIENTRY *LPALCCAPTUREOPENDEVICE)( const ALCchar *devicename, ALCuint frequency, ALCenum format, ALCsizei Buffersize );
   typedef ALCboolean     (ALC_APIENTRY *LPALCCAPTURECLOSEDEVICE)( ALCdevice *device );
   typedef void           (ALC_APIENTRY *LPALCCAPTURESTART)( ALCdevice *device );
   typedef void           (ALC_APIENTRY *LPALCCAPTURESTOP)( ALCdevice *device );
   typedef void           (ALC_APIENTRY *LPALCCAPTURESAMPLES)( ALCdevice *device, ALCvoid *Buffer, ALCsizei samples );
           */
    }
}
