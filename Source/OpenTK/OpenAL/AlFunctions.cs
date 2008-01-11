#region --- OpenTK.OpenAL License ---
/* AlFunctions.cs
 * C header: \OpenAL 1.1 SDK\include\Al.h
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

using OpenTK.Math;

/* Type Mapping
// 8-bit boolean 
typedef char ALboolean;
 * byte
// character 
typedef char ALchar;
 * byte
// signed 8-bit 2's complement integer 
typedef char ALbyte;
 * byte

// unsigned 8-bit integer 
typedef unsigned char ALubyte;
 * ubyte

// signed 16-bit 2's complement integer 
typedef short ALshort;
 * short

// unsigned 16-bit integer 
typedef unsigned short ALushort;
 * ushort

// unsigned 32-bit integer 
typedef unsigned int ALuint;
 * uint
 
// signed 32-bit 2's complement integer 
typedef int ALint;
 * int
// non-negative 32-bit binary integer size 
typedef int ALsizei;
 * int
// enumerated 32-bit value
typedef int ALenum;
 * int

// 32-bit IEEE754 floating-point 
typedef float ALfloat;
 * float

// 64-bit IEEE754 floating-point 
typedef double ALdouble;
 * double

// void type (for opaque pointers only) 
typedef void ALvoid;
 * void
*/

namespace OpenTK.OpenAL
{
    // Al = Audio Library
    public static class Al
    {
        #region Constants
        public const string Lib = "OpenAL32.dll";
        private const CallingConvention Style = CallingConvention.Cdecl;
        #endregion Constants

        #region Type Helpers
        /// <summary>An IntPtr.Zero that can be used as Al.Null, for convenience.</summary>
        public static readonly IntPtr Null = IntPtr.Zero; // do NOT touch.

        /// <summary>OpenAL 8-Bit Boolean char, can either be True or False.</summary>
        public enum Bool : byte
        {
            ///<summary>Boolean False.</summary>
            False = 0,
            ///<summary>Boolean True.</summary>
            True = 1,
        }
        #endregion Type Helpers

        #region Renderer State management
        [DllImport( Al.Lib, EntryPoint = "alEnable", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void Enable( Enums.AlCapability capability );
        //AL_API void AL_APIENTRY alEnable( ALenum capability );

        [DllImport( Al.Lib, EntryPoint = "alDisable", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void Disable( Enums.AlCapability capability );
        // AL_API void AL_APIENTRY alDisable( ALenum capability ); 

        [DllImport( Al.Lib, EntryPoint = "alIsEnabled", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Al.Bool IsEnabled( Enums.AlCapability capability );
        // AL_API ALboolean AL_APIENTRY alIsEnabled( ALenum capability ); 
        #endregion Renderer State management

        #region State retrieval
        [DllImport( Al.Lib, EntryPoint = "alGetString", ExactSpelling = true, CallingConvention = Al.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        private static extern IntPtr GetStringInternal( int param ); // accepts the enums Enums.AlError, Enums.AlContextString
        // AL_API const ALchar* AL_APIENTRY alGetString( ALenum param );

        internal static string GetString( int param )
        {
            return Marshal.PtrToStringAnsi( GetStringInternal( param ) );
        }

        /* no functions return more than 1 result ..
// AL_API void AL_APIENTRY alGetBooleanv( ALenum param, ALboolean* data );
// AL_API void AL_APIENTRY alGetIntegerv( ALenum param, ALint* data );
// AL_API void AL_APIENTRY alGetFloatv( ALenum param, ALfloat* data );
// AL_API void AL_APIENTRY alGetDoublev( ALenum param, ALdouble* data );
         */

        [DllImport( Al.Lib, EntryPoint = "alGetBoolean", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Al.Bool alGetBoolean( Enums.AlGlobalTweakage param );
        // AL_API ALboolean AL_APIENTRY alGetBoolean( ALenum param );

        [DllImport( Al.Lib, EntryPoint = "alGetInteger", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern int GetInteger( Enums.AlGlobalTweakage param );
        // AL_API ALint AL_APIENTRY alGetInteger( ALenum param );

        [DllImport( Al.Lib, EntryPoint = "alGetFloat", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern float GetFloat( Enums.AlGlobalTweakage param );
        // AL_API ALfloat AL_APIENTRY alGetFloat( ALenum param );

        [DllImport( Al.Lib, EntryPoint = "alGetDouble", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern double GetDouble( Enums.AlGlobalTweakage param );
        // AL_API ALdouble AL_APIENTRY alGetDouble( ALenum param );

        /// <summary>Error support. Obtain the most recent error generated in the AL state machine. When an error is detected by AL, a flag is set and the error code is recorded. Further errors, if they occur, do not affect this recorded code. When alGetError is called, the code is returned and the flag is cleared, so that a further error will again record its code.</summary>
        /// <returns>The first error that occured. can be used with Al.GetString</returns>
        [DllImport( Al.Lib, EntryPoint = "alGetError", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Enums.AlError GetError( );
        // AL_API ALenum AL_APIENTRY alGetError( void );
        #endregion State retrieval

        #region Extension support.
        // Query for the presence of an extension, and obtain any appropriate function pointers and enum values.

        [DllImport( Al.Lib, EntryPoint = "alIsExtensionPresent", ExactSpelling = true, CallingConvention = Al.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Al.Bool IsExtensionPresent( [In] string extname );
        // AL_API ALboolean AL_APIENTRY alIsExtensionPresent( const ALchar* extname );

        [DllImport( Al.Lib, EntryPoint = "alGetProcAddress", ExactSpelling = true, CallingConvention = Al.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        internal static extern IntPtr GetProcAddress( [In] string fname );
        // AL_API void* AL_APIENTRY alGetProcAddress( const ALchar* fname );

        [DllImport( Al.Lib, EntryPoint = "alGetEnumValue", ExactSpelling = true, CallingConvention = Al.Style, CharSet = CharSet.Ansi ), SuppressUnmanagedCodeSecurity( )]
        internal static extern int GetEnumValue( [In] string ename );
        // AL_API ALenum AL_APIENTRY alGetEnumValue( const ALchar* ename );
        #endregion Extension support.

        /*
         * Listener
         * Listener represents the location and orientation of the
         * 'user' in 3D-space.
         *
         * Properties include: -
         *
         * Gain         AL_GAIN         ALfloat
         * Position     AL_POSITION     ALfloat[3]
         * Velocity     AL_VELOCITY     ALfloat[3]
         * Orientation  AL_ORIENTATION  ALfloat[6] (Forward then Up vectors)
        */

        #region Set Listener parameters

        // AL_API void AL_APIENTRY alListenerf( ALenum param, ALfloat value );
        [DllImport( Al.Lib, EntryPoint = "alListenerf", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void Listenerf( Enums.AlListenerf param, float value );

        // AL_API void AL_APIENTRY alListener3f( ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );
        [DllImport( Al.Lib, EntryPoint = "alListener3f", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void Listener3f( Enums.AlListener3f param, float value1, float value2, float value3 );

        internal static void Listener3f( Enums.AlListener3f param, Vector3 value )
        {
            Listener3f( param, value.X, value.Y, value.Z );
        }

        // AL_API void AL_APIENTRY alListenerfv( ALenum param, const ALfloat* values );
        [DllImport( Al.Lib, EntryPoint = "alListenerfv", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        unsafe private static extern void Listenerfv( Enums.AlListenerfv param, float* values );

        internal static void Listenerfv( Enums.AlListenerfv param, ref float[] values )
        {
            unsafe
            {
                fixed ( float* ptr = &values[0] )
                {
                    Listenerfv( param, ptr );
                }
            }
        }


        // AL_API void AL_APIENTRY alListeneri( ALenum param, ALint value );
        // AL_API void AL_APIENTRY alListener3i( ALenum param, ALint value1, ALint value2, ALint value3 );
        // AL_API void AL_APIENTRY alListeneriv( ALenum param, const ALint* values );
        #endregion Set Listener parameters

        #region Get Listener parameters

        // AL_API void AL_APIENTRY alGetListenerf( ALenum param, ALfloat* value );
        [DllImport( Al.Lib, EntryPoint = "alGetListenerf", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        unsafe internal static extern void GetListenerf( Enums.AlListenerf param, float* value );

        // AL_API void AL_APIENTRY alGetListener3f( ALenum param, ALfloat *value1, ALfloat *value2, ALfloat *value3 );
        [DllImport( Al.Lib, EntryPoint = "alGetListener3f", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        unsafe internal static extern void GetListener3f( Enums.AlListener3f param, float* value1, float* value2, float* value3 );

        // AL_API void AL_APIENTRY alGetListenerfv( ALenum param, ALfloat* values );
        [DllImport( Al.Lib, EntryPoint = "alGetListenerfv", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        unsafe internal static extern void GetListenerfv( Enums.AlListenerfv param, float* values );

        // AL_API void AL_APIENTRY alGetListeneri( ALenum param, ALint* value );
        // AL_API void AL_APIENTRY alGetListener3i( ALenum param, ALint *value1, ALint *value2, ALint *value3 );
        // AL_API void AL_APIENTRY alGetListeneriv( ALenum param, ALint* values );
        #endregion Get Listener parameters

        /*
         * Source
         * Sources represent individual sound objects in 3D-space.
         * Sources take the PCM data provided in the specified Buffer,
         * apply Source-specific modifications, and then
         * submit them to be mixed according to spatial arrangement etc.
         * 
         * Properties include: -
         *
        
         * Position                          AL_POSITION             ALfloat[3]
         * Velocity                          AL_VELOCITY             ALfloat[3]
         * Direction                         AL_DIRECTION            ALfloat[3]

         * Head Relative Mode                AL_SOURCE_RELATIVE      ALint (AL_TRUE or AL_FALSE)
         * Looping                           AL_LOOPING              ALint (AL_TRUE or AL_FALSE)
         * 
         * Reference Distance                AL_REFERENCE_DISTANCE   ALfloat
         * Max Distance                      AL_MAX_DISTANCE         ALfloat
         * RollOff Factor                    AL_ROLLOFF_FACTOR       ALfloat
         * Pitch                             AL_PITCH                ALfloat
         * Gain                              AL_GAIN                 ALfloat
         * Min Gain                          AL_MIN_GAIN             ALfloat
         * Max Gain                          AL_MAX_GAIN             ALfloat
         * Inner Angle                       AL_CONE_INNER_ANGLE     ALint or ALfloat
         * Outer Angle                       AL_CONE_OUTER_ANGLE     ALint or ALfloat
         * Cone Outer Gain                   AL_CONE_OUTER_GAIN      ALint or ALfloat 
         * 
         * MS Offset                         AL_MSEC_OFFSET          ALint or ALfloat
         * Byte Offset                       AL_BYTE_OFFSET          ALint or ALfloat
         * Sample Offset                     AL_SAMPLE_OFFSET        ALint or ALfloat
         * Attached Buffer                   AL_BUFFER               ALint
         * 
         * State (Query only)                AL_SOURCE_STATE         ALint
         * Buffers Queued (Query only)       AL_BUFFERS_QUEUED       ALint
         * Buffers Processed (Query only)    AL_BUFFERS_PROCESSED    ALint
         */

        #region Create Source objects
        [DllImport( Al.Lib, EntryPoint = "alGenSources", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        unsafe private static extern void GenSourcesInternal( int n, [Out] uint* sources );
        // AL_API void AL_APIENTRY alGenSources( ALsizei n, ALuint* Sources );

        internal static void GenSources( int n, [Out] out uint sources )
        {
            unsafe
            {
                fixed ( uint* ptr = &sources )
                {
                    GenSourcesInternal( n, (uint*) ptr );
                    sources = *ptr;
                }
            }
        }

        [DllImport( Al.Lib, EntryPoint = "alDeleteSources", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        unsafe private static extern void DeleteSourcesInternal( int n, [In] uint* sources ); // Delete Source objects 
        // AL_API void AL_APIENTRY alDeleteSources( ALsizei n, const ALuint* Sources );

        internal static void DeleteSources( int n, uint[] sources )
        {
            unsafe
            {
                fixed ( uint* ptr = sources )
                {
                    DeleteSourcesInternal( n, (uint*) ptr );
                }
            }
        }

        [DllImport( Al.Lib, EntryPoint = "alIsSource", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Al.Bool IsSource( uint sid ); // Verify a handle is a valid Source 
        // AL_API ALboolean AL_APIENTRY alIsSource( ALuint sid );
        #endregion Create Source objects

        #region Set Source parameters
        [DllImport( Al.Lib, EntryPoint = "alSourcef", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void Sourcef( uint sid, Enums.AlSourcef param, float value );
        // AL_API void AL_APIENTRY alSourcef( ALuint sid, ALenum param, ALfloat value );

        [DllImport( Al.Lib, EntryPoint = "alSource3f", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void Source3f( uint sid, Enums.AlSource3f param, float value1, float value2, float value3 );
        // AL_API void AL_APIENTRY alSource3f( ALuint sid, ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );

        internal static void Sourcev3( uint sid, Enums.AlSource3f param, ref Vector3 values )
        {
            Source3f( sid, param, values.X, values.Y, values.Z );
        }

        [DllImport( Al.Lib, EntryPoint = "alSourcei", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void alSourcei( uint sid, Enums.AlSourcei param, int value );
        // AL_API void AL_APIENTRY alSourcei( ALuint sid, ALenum param, ALint value ); 

        internal static void alSourceBool( uint sid, Enums.AlSourceBool param, bool value )
        {
            alSourcei( sid, (Enums.AlSourcei) param, ( value ) ? 1 : 0 );
        }

        // AL_API void AL_APIENTRY alSourcefv( ALuint sid, ALenum param, const ALfloat* values );
        // AL_API void AL_APIENTRY alSource3i( ALuint sid, ALenum param, ALint value1, ALint value2, ALint value3 );
        // AL_API void AL_APIENTRY alSourceiv( ALuint sid, ALenum param, const ALint* values );
        #endregion Set Source parameters

        #region Get Source parameters
        [DllImport( Al.Lib, EntryPoint = "alGetSourcef", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void GetSourcef( uint sid, Enums.AlSourcef param, [Out] out float value );
        // AL_API void AL_APIENTRY alGetSourcef( ALuint sid, ALenum param, ALfloat* value );

        [DllImport( Al.Lib, EntryPoint = "alGetSource3f", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void GetSource3f( uint sid, Enums.AlSource3f param, [Out] out float value1, [Out] out float value2, [Out] out float value3 );
        // AL_API void AL_APIENTRY alGetSource3f( ALuint sid, ALenum param, ALfloat* value1, ALfloat* value2, ALfloat* value3);

        internal static void GetSource3f( uint sid, Enums.AlSource3f param, out Vector3 values )
        {
            GetSource3f( sid, param, out values.X, out values.Y, out values.Z );
        }

        [DllImport( Al.Lib, EntryPoint = "alGetSourcei", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void GetSourcei( uint sid, Enums.AlSourceiGet param, [Out] out int value );
        // AL_API void AL_APIENTRY alGetSourcei( ALuint sid,  ALenum param, ALint* value );

        public static void GetSourceBool( uint sid, Enums.AlSourceBool param, [Out] out bool value )
        {
            int result;
            GetSourcei( sid, (Enums.AlSourceiGet) param, out result );
            if ( result == 1 )
                value = true;
            else
                value = false;
        }

        // AL_API void AL_APIENTRY alGetSourcefv( ALuint sid, ALenum param, ALfloat* values );
        // AL_API void AL_APIENTRY alGetSource3i( ALuint sid, ALenum param, ALint* value1, ALint* value2, ALint* value3);
        // AL_API void AL_APIENTRY alGetSourceiv( ALuint sid,  ALenum param, ALint* values );
        #endregion Get Source parameters

        #region Source vector based playback calls
        // Play, replay, or resume (if paused) a list of Sources
        // AL_API void AL_APIENTRY alSourcePlayv( ALsizei ns, const ALuint *sids );

        // Stop a list of Sources
        // AL_API void AL_APIENTRY alSourceStopv( ALsizei ns, const ALuint *sids );

        // Rewind a list of Sources
        // AL_API void AL_APIENTRY alSourceRewindv( ALsizei ns, const ALuint *sids );

        // Pause a list of Sources
        // AL_API void AL_APIENTRY alSourcePausev( ALsizei ns, const ALuint *sids );
        #endregion Source vector based playback calls

        #region Source based playback calls
        [DllImport( Al.Lib, EntryPoint = "alSourcePlay", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void SourcePlay( uint sid );// Play, replay, or resume a Source
        // AL_API void AL_APIENTRY alSourcePlay( ALuint sid );

        [DllImport( Al.Lib, EntryPoint = "alSourceStop", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void SourceStop( uint sid ); // Stop a Source
        // AL_API void AL_APIENTRY alSourceStop( ALuint sid );

        [DllImport( Al.Lib, EntryPoint = "alSourceRewind", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void SourceRewind( uint sid );// Rewind a Source (set playback postiton to beginning) 
        // AL_API void AL_APIENTRY alSourceRewind( ALuint sid );

        [DllImport( Al.Lib, EntryPoint = "alSourcePause", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void SourcePause( uint sid ); // Pause a Source
        // AL_API void AL_APIENTRY alSourcePause( ALuint sid );
        #endregion Source based playback calls

        #region Source Queuing
        // AL_API void AL_APIENTRY alSourceQueueBuffers( ALuint sid, ALsizei numEntries, const ALuint *bids );

        // AL_API void AL_APIENTRY alSourceUnqueueBuffers( ALuint sid, ALsizei numEntries, ALuint *bids );

        #endregion Source Queuing

        /*
         * Buffer
         * Buffer objects are storage space for sample data.
         * Buffers are referred to by Sources. One Buffer can be used
         * by multiple Sources.
         *
         * Properties include: -
         *
         * Frequency (Query only)    AL_FREQUENCY      ALint
         * Size (Query only)         AL_SIZE           ALint
         * Bits (Query only)         AL_BITS           ALint
         * Channels (Query only)     AL_CHANNELS       ALint
         */

        #region Buffer objects
        [DllImport( Al.Lib, EntryPoint = "alGenBuffers", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        unsafe private static extern void GenBuffersInternal( int n, [Out] uint* buffers );
        // AL_API void AL_APIENTRY alGenBuffers( ALsizei n, ALuint* Buffers );

        internal static void GenBuffers( int n, [Out] out uint buffers )
        {
            unsafe
            {
                fixed ( uint* ptr = &buffers )
                {
                    GenBuffersInternal( n, (uint*) ptr );
                    buffers = *ptr;
                }
            }
        }

        [DllImport( Al.Lib, EntryPoint = "alDeleteBuffers", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        unsafe private static extern void DeleteBuffersInternal( int n, [In] uint* buffers );  // Delete Buffer objects
        // AL_API void AL_APIENTRY alDeleteBuffers( ALsizei n, const ALuint* Buffers );

        internal static void DeleteBuffers( int n, uint[] buffers )
        {
            unsafe
            {
                fixed ( uint* ptr = buffers )
                {
                    DeleteBuffersInternal( n, (uint*) ptr );
                }
            }
        }

        /// <summary>
        /// Verify a handle is a valid Buffer
        /// </summary>
        /// <param name="bid">a buffer previously allocated with <see cref="Al.GenBuffers"/>.</param>
        /// <returns>success</returns>
        [DllImport( Al.Lib, EntryPoint = "alIsBuffer", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Al.Bool IsBuffer( uint bid );
        // AL_API ALboolean AL_APIENTRY alIsBuffer( ALuint bid );

        [DllImport( Al.Lib, EntryPoint = "alBufferData", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void BufferData( uint bid, Enums.AlFormat format, IntPtr data, int size, int freq ); // Specify the data to be copied into a Buffer
        // AL_API void AL_APIENTRY alBufferData( ALuint bid, ALenum format, const ALvoid* data, ALsizei size, ALsizei freq );
        #endregion Buffer objects

        #region Set Buffer parameters (currently parameters can only be read)
        // AL_API void AL_APIENTRY alBufferf( ALuint bid, ALenum param, ALfloat value );

        // AL_API void AL_APIENTRY alBuffer3f( ALuint bid, ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );
        /* [DllImport( Al.Lib, EntryPoint = "alBuffer3f", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
         internal static extern void Buffer3f( uint bid, ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );

         internal static void Bufferv3( uint bid, Alenum param, ref Vector3 values )
         {
             Buffer3f( bid, param, values.X, values.Y, values.Z );
         }*/

        // AL_API void AL_APIENTRY alBufferfv( ALuint bid, ALenum param, const ALfloat* values );
        // AL_API void AL_APIENTRY alBufferi( ALuint bid, ALenum param, ALint value );
        // AL_API void AL_APIENTRY alBuffer3i( ALuint bid, ALenum param, ALint value1, ALint value2, ALint value3 );
        // AL_API void AL_APIENTRY alBufferiv( ALuint bid, ALenum param, const ALint* values );
        #endregion Set Buffer parameters

        #region Get Buffer parameters
        [DllImport( Al.Lib, EntryPoint = "alGetBufferi", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern Al.Bool alGetBufferi( uint bid, Enums.AlBufferAttribute param, [Out] out float value );
        // AL_API void AL_APIENTRY alGetBufferi( ALuint bid, ALenum param, ALint* value );


        // AL_API void AL_APIENTRY alGetBufferf( ALuint bid, ALenum param, ALfloat* value );
        // AL_API void AL_APIENTRY alGetBuffer3f( ALuint bid, ALenum param, ALfloat* value1, ALfloat* value2, ALfloat* value3);
        // AL_API void AL_APIENTRY alGetBufferfv( ALuint bid, ALenum param, ALfloat* values );
        // AL_API void AL_APIENTRY alGetBuffer3i( ALuint bid, ALenum param, ALint* value1, ALint* value2, ALint* value3);
        // AL_API void AL_APIENTRY alGetBufferiv( ALuint bid, ALenum param, ALint* values );
        #endregion Get Buffer parameters

        #region Global Parameters
        [DllImport( Al.Lib, EntryPoint = "alDopplerFactor", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void DopplerFactor( float value );
        // AL_API void AL_APIENTRY alDopplerFactor( ALfloat value );

        [DllImport( Al.Lib, EntryPoint = "alDopplerVelocity", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void DopplerVelocity( float value );
        // AL_API void AL_APIENTRY alDopplerVelocity( ALfloat value );

        [DllImport( Al.Lib, EntryPoint = "alSpeedOfSound", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void SpeedOfSound( float value );
        // AL_API void AL_APIENTRY alSpeedOfSound( ALfloat value );

        [DllImport( Al.Lib, EntryPoint = "alDistanceModel", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        internal static extern void DistanceModel( Enums.AlDistanceModels distancemodel );
        // AL_API void AL_APIENTRY alDistanceModel( ALenum distanceModel );
        #endregion Global Parameters

        /*
#else // AL_NO_PROTOTYPES 

typedef void           (AL_APIENTRY *LPALENABLE)( ALenum capability );
typedef void           (AL_APIENTRY *LPALDISABLE)( ALenum capability ); 
typedef ALboolean      (AL_APIENTRY *LPALISENABLED)( ALenum capability ); 
typedef const ALchar*  (AL_APIENTRY *LPALGETSTRING)( ALenum param );
typedef void           (AL_APIENTRY *LPALGETBOOLEANV)( ALenum param, ALboolean* data );
typedef void           (AL_APIENTRY *LPALGETINTEGERV)( ALenum param, ALint* data );
typedef void           (AL_APIENTRY *LPALGETFLOATV)( ALenum param, ALfloat* data );
typedef void           (AL_APIENTRY *LPALGETDOUBLEV)( ALenum param, ALdouble* data );
typedef ALboolean      (AL_APIENTRY *LPALGETBOOLEAN)( ALenum param );
typedef ALint          (AL_APIENTRY *LPALGETINTEGER)( ALenum param );
typedef ALfloat        (AL_APIENTRY *LPALGETFLOAT)( ALenum param );
typedef ALdouble       (AL_APIENTRY *LPALGETDOUBLE)( ALenum param );
typedef ALenum         (AL_APIENTRY *LPALGETERROR)( void );
typedef ALboolean      (AL_APIENTRY *LPALISEXTENSIONPRESENT)(const ALchar* extname );
typedef void*          (AL_APIENTRY *LPALGETPROCADDRESS)( const ALchar* fname );
typedef ALenum         (AL_APIENTRY *LPALGETENUMVALUE)( const ALchar* ename );
typedef void           (AL_APIENTRY *LPALListenerF)( ALenum param, ALfloat value );
typedef void           (AL_APIENTRY *LPALListener3F)( ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );
typedef void           (AL_APIENTRY *LPALListenerFV)( ALenum param, const ALfloat* values );
typedef void           (AL_APIENTRY *LPALListenerI)( ALenum param, ALint value );
typedef void           (AL_APIENTRY *LPALListener3I)( ALenum param, ALint value1, ALint value2, ALint value3 );
typedef void           (AL_APIENTRY *LPALListenerIV)( ALenum param, const ALint* values );
typedef void           (AL_APIENTRY *LPALGETListenerF)( ALenum param, ALfloat* value );
typedef void           (AL_APIENTRY *LPALGETListener3F)( ALenum param, ALfloat *value1, ALfloat *value2, ALfloat *value3 );
typedef void           (AL_APIENTRY *LPALGETListenerFV)( ALenum param, ALfloat* values );
typedef void           (AL_APIENTRY *LPALGETListenerI)( ALenum param, ALint* value );
typedef void           (AL_APIENTRY *LPALGETListener3I)( ALenum param, ALint *value1, ALint *value2, ALint *value3 );
typedef void           (AL_APIENTRY *LPALGETListenerIV)( ALenum param, ALint* values );
typedef void           (AL_APIENTRY *LPALGENSourceS)( ALsizei n, ALuint* Sources ); 
typedef void           (AL_APIENTRY *LPALDELETESourceS)( ALsizei n, const ALuint* Sources );
typedef ALboolean      (AL_APIENTRY *LPALISSource)( ALuint sid ); 
typedef void           (AL_APIENTRY *LPALSourceF)( ALuint sid, ALenum param, ALfloat value); 
typedef void           (AL_APIENTRY *LPALSource3F)( ALuint sid, ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );
typedef void           (AL_APIENTRY *LPALSourceFV)( ALuint sid, ALenum param, const ALfloat* values );
typedef void           (AL_APIENTRY *LPALSourceI)( ALuint sid, ALenum param, ALint value); 
typedef void           (AL_APIENTRY *LPALSource3I)( ALuint sid, ALenum param, ALint value1, ALint value2, ALint value3 );
typedef void           (AL_APIENTRY *LPALSourceIV)( ALuint sid, ALenum param, const ALint* values );
typedef void           (AL_APIENTRY *LPALGETSourceF)( ALuint sid, ALenum param, ALfloat* value );
typedef void           (AL_APIENTRY *LPALGETSource3F)( ALuint sid, ALenum param, ALfloat* value1, ALfloat* value2, ALfloat* value3);
typedef void           (AL_APIENTRY *LPALGETSourceFV)( ALuint sid, ALenum param, ALfloat* values );
typedef void           (AL_APIENTRY *LPALGETSourceI)( ALuint sid, ALenum param, ALint* value );
typedef void           (AL_APIENTRY *LPALGETSource3I)( ALuint sid, ALenum param, ALint* value1, ALint* value2, ALint* value3);
typedef void           (AL_APIENTRY *LPALGETSourceIV)( ALuint sid, ALenum param, ALint* values );
typedef void           (AL_APIENTRY *LPALSourcePLAYV)( ALsizei ns, const ALuint *sids );
typedef void           (AL_APIENTRY *LPALSourceSTOPV)( ALsizei ns, const ALuint *sids );
typedef void           (AL_APIENTRY *LPALSourceREWINDV)( ALsizei ns, const ALuint *sids );
typedef void           (AL_APIENTRY *LPALSourcePAUSEV)( ALsizei ns, const ALuint *sids );
typedef void           (AL_APIENTRY *LPALSourcePLAY)( ALuint sid );
typedef void           (AL_APIENTRY *LPALSourceSTOP)( ALuint sid );
typedef void           (AL_APIENTRY *LPALSourceREWIND)( ALuint sid );
typedef void           (AL_APIENTRY *LPALSourcePAUSE)( ALuint sid );
typedef void           (AL_APIENTRY *LPALSourceQUEUEBufferS)(ALuint sid, ALsizei numEntries, const ALuint *bids );
typedef void           (AL_APIENTRY *LPALSourceUNQUEUEBufferS)(ALuint sid, ALsizei numEntries, ALuint *bids );
typedef void           (AL_APIENTRY *LPALGENBufferS)( ALsizei n, ALuint* Buffers );
typedef void           (AL_APIENTRY *LPALDELETEBufferS)( ALsizei n, const ALuint* Buffers );
typedef ALboolean      (AL_APIENTRY *LPALISBuffer)( ALuint bid );
typedef void           (AL_APIENTRY *LPALBufferDATA)( ALuint bid, ALenum format, const ALvoid* data, ALsizei size, ALsizei freq );
typedef void           (AL_APIENTRY *LPALBufferF)( ALuint bid, ALenum param, ALfloat value);
typedef void           (AL_APIENTRY *LPALBuffer3F)( ALuint bid, ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );
typedef void           (AL_APIENTRY *LPALBufferFV)( ALuint bid, ALenum param, const ALfloat* values );
typedef void           (AL_APIENTRY *LPALBufferI)( ALuint bid, ALenum param, ALint value);
typedef void           (AL_APIENTRY *LPALBuffer3I)( ALuint bid, ALenum param, ALint value1, ALint value2, ALint value3 );
typedef void           (AL_APIENTRY *LPALBufferIV)( ALuint bid, ALenum param, const ALint* values );
typedef void           (AL_APIENTRY *LPALGETBufferF)( ALuint bid, ALenum param, ALfloat* value );
typedef void           (AL_APIENTRY *LPALGETBuffer3F)( ALuint bid, ALenum param, ALfloat* value1, ALfloat* value2, ALfloat* value3);
typedef void           (AL_APIENTRY *LPALGETBufferFV)( ALuint bid, ALenum param, ALfloat* values );
typedef void           (AL_APIENTRY *LPALGETBufferI)( ALuint bid, ALenum param, ALint* value );
typedef void           (AL_APIENTRY *LPALGETBuffer3I)( ALuint bid, ALenum param, ALint* value1, ALint* value2, ALint* value3);
typedef void           (AL_APIENTRY *LPALGETBufferIV)( ALuint bid, ALenum param, ALint* values );
typedef void           (AL_APIENTRY *LPALDOPPLERFACTOR)( ALfloat value );
typedef void           (AL_APIENTRY *LPALDOPPLERVELOCITY)( ALfloat value );
typedef void           (AL_APIENTRY *LPALSPEEDOFSOUND)( ALfloat value );
typedef void           (AL_APIENTRY *LPALDISTANCEMODEL)( ALenum distanceModel );
         */
    }
}
