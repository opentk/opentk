#region --- OpenTK.OpenAL License ---
/* AlFunctions.cs
 * C header: \OpenAL 1.1 SDK\include\Al.h
 * Spec: http://www.openal.org/openal_webstf/specs/OpenAL11Specification.pdf
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
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
    public static class AL
    {
        #region Constants

        public const string Lib = "openal32.dll";
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

        /// <summary>This function enables a feature of the OpenAL driver. There are no capabilities defined in OpenAL 1.1 to be used with this function, but it may be used by an extension.</summary>
        /// <param name="capability">The name of a capability to enable.</param>
        [DllImport(AL.Lib, EntryPoint = "alEnable", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void Enable(Enums.ALCapability capability);
        //AL_API void AL_APIENTRY alEnable( ALenum capability );

        /// <summary>This function disables a feature of the OpenAL driver.</summary>
        /// <param name="capability">The name of a capability to disable.</param>
        [DllImport(AL.Lib, EntryPoint = "alDisable", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void Disable(Enums.ALCapability capability);
        // AL_API void AL_APIENTRY alDisable( ALenum capability ); 

        /// <summary>This function returns a boolean indicating if a specific feature is enabled in the OpenAL driver.</summary>
        /// <param name="capability">The name of a capability to enable.</param>
        /// <returns>True if enabled, False if disabled.</returns>
        [DllImport(AL.Lib, EntryPoint = "alIsEnabled", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern AL.Bool IsEnabled(Enums.ALCapability capability);
        // AL_API ALboolean AL_APIENTRY alIsEnabled( ALenum capability ); 

        #endregion Renderer State management

        #region State retrieval

        [DllImport(AL.Lib, EntryPoint = "alGetString", ExactSpelling = true, CallingConvention = AL.Style, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity()]
        private static extern IntPtr GetStringPrivate(Enums.ALGetString param); // accepts the enums Enums.AlError, Enums.AlContextString
        // AL_API const ALchar* AL_APIENTRY alGetString( ALenum param );

        /// <summary>This function retrieves an OpenAL string property.</summary>
        /// <param name="param">The property to be returned: AL_VENDOR, AL_VERSION, AL_RENDERER, AL_EXTENSIONS</param>
        /// <returns>Returns a pointer to a null-terminated string.</returns>
        public static string Get(Enums.ALGetString param)
        {
            return Marshal.PtrToStringAnsi(GetStringPrivate(param));
        }

        /// <summary>This function retrieves an OpenAL string property.</summary>
        /// <param name="param">The human-readable errorstring to be returned.</param>
        /// <returns>Returns a pointer to a null-terminated string.</returns>
        public static string GetErrorString(Enums.ALError param)
        {
            return Marshal.PtrToStringAnsi(GetStringPrivate((Enums.ALGetString)param));
        }

        /* no functions return more than 1 result ..
// AL_API void AL_APIENTRY alGetBooleanv( ALenum param, ALboolean* data );
// AL_API void AL_APIENTRY alGetIntegerv( ALenum param, ALint* data );
// AL_API void AL_APIENTRY alGetFloatv( ALenum param, ALfloat* data );
// AL_API void AL_APIENTRY alGetDoublev( ALenum param, ALdouble* data );
         */

        /* disabled due to no token using it
        /// <summary>This function returns a boolean OpenAL state.</summary>
        /// <param name="param">the state to be queried: AL_DOPPLER_FACTOR, AL_SPEED_OF_SOUND, AL_DISTANCE_MODEL</param>
        /// <returns>The boolean state described by param will be returned.</returns>
        [DllImport( AL.Lib, EntryPoint = "alGetBoolean", ExactSpelling = true, CallingConvention = AL.Style ), SuppressUnmanagedCodeSecurity( )]
        public static extern AL.Bool Get( Enums.ALGetBoolean param );
        // AL_API ALboolean AL_APIENTRY alGetBoolean( ALenum param );
        */

        /// <summary>This function returns an integer OpenAL state.</summary>
        /// <param name="param">the state to be queried: AL_DOPPLER_FACTOR, AL_SPEED_OF_SOUND, AL_DISTANCE_MODEL</param>
        /// <returns>The integer state described by param will be returned.</returns>
        [DllImport(AL.Lib, EntryPoint = "alGetInteger", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern int Get(Enums.ALGetInteger param);
        // AL_API ALint AL_APIENTRY alGetInteger( ALenum param );

        /// <summary>This function returns a floating point OpenAL state.</summary>
        /// <param name="param">the state to be queried: AL_DOPPLER_FACTOR, AL_SPEED_OF_SOUND, AL_DISTANCE_MODEL</param>
        /// <returns>The floating point state described by param will be returned.</returns>
        [DllImport(AL.Lib, EntryPoint = "alGetFloat", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern float Get(Enums.ALGetFloat param);
        // AL_API ALfloat AL_APIENTRY alGetFloat( ALenum param );

        /* disabled due to no token using it
       /// <summary>This function returns a double precision floating point OpenAL state.</summary>
       /// <param name="param">the state to be queried: AL_DOPPLER_FACTOR, AL_SPEED_OF_SOUND, AL_DISTANCE_MODEL</param>
       /// <returns>The double value described by param will be returned.</returns>
       [DllImport( AL.Lib, EntryPoint = "alGetDouble", ExactSpelling = true, CallingConvention = AL.Style ), SuppressUnmanagedCodeSecurity( )]
       public static extern double Get( Enums.ALGetDouble param );
       // AL_API ALdouble AL_APIENTRY alGetDouble( ALenum param );
       */

        /// <summary>Error support. Obtain the most recent error generated in the AL state machine. When an error is detected by AL, a flag is set and the error code is recorded. Further errors, if they occur, do not affect this recorded code. When alGetError is called, the code is returned and the flag is cleared, so that a further error will again record its code.</summary>
        /// <returns>The first error that occured. can be used with Al.GetString. Returns an Alenum representing the error state. When an OpenAL error occurs, the error state is set and will not be changed until the error state is retrieved using alGetError. Whenever alGetError is called, the error state is cleared and the last state (the current state when the call was made) is returned. To isolate error detection to a specific portion of code, alGetError should be called before the isolated section to clear the current error state.</returns>
        [DllImport(AL.Lib, EntryPoint = "alGetError", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern Enums.ALError GetError();
        // AL_API ALenum AL_APIENTRY alGetError( void );

        #endregion State retrieval

        #region Extension support.

        /// <summary>This function tests if a specific extension is available for the OpenAL driver.</summary>
        /// <param name="extname">A null-terminated string describing the desired extension.</param>
        /// <returns>Returns AL_TRUE if the extension is available, AL_FALSE if the extension is not available.</returns>
        [DllImport(AL.Lib, EntryPoint = "alIsExtensionPresent", ExactSpelling = true, CallingConvention = AL.Style, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity()]
        public static extern AL.Bool IsExtensionPresent([In] string extname);
        // AL_API ALboolean AL_APIENTRY alIsExtensionPresent( const ALchar* extname );

        /// <summary>This function returns the address of an OpenAL extension function. Handle with care.</summary>
        /// <param name="fname">A null-terminated string containing the function name.</param>
        /// <returns>The return value is a pointer to the specified function. The return value will be NULL if the function is not found.</returns>
        [DllImport(AL.Lib, EntryPoint = "alGetProcAddress", ExactSpelling = true, CallingConvention = AL.Style, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity()]
        public static extern IntPtr GetProcAddress([In] string fname);
        // AL_API void* AL_APIENTRY alGetProcAddress( const ALchar* fname );

        /// <summary>This function returns the enumeration value of an OpenAL enum described by a string.</summary>
        /// <param name="ename">A null-terminated string describing an OpenAL enum.</param>
        /// <returns>Returns the actual ALenum described by a string. Returns NULL if the string doesn’t describe a valid OpenAL enum.</returns>
        [DllImport(AL.Lib, EntryPoint = "alGetEnumValue", ExactSpelling = true, CallingConvention = AL.Style, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity()]
        public static extern int GetEnumValue([In] string ename);
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

        /// <summary>This function sets a floating point property for the listener.</summary>
        /// <param name="param">The name of the attribute to be set: AL_GAIN</param>
        /// <param name="value">The float value to set the attribute to.</param>
        [DllImport(AL.Lib, EntryPoint = "alListenerf", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void Listener(Enums.ALListenerf param, float value);
        // AL_API void AL_APIENTRY alListenerf( ALenum param, ALfloat value );

        /// <summary>This function sets a floating point property for the listener.</summary>
        /// <param name="param">The name of the attribute to set: AL_POSITION, AL_VELOCITY</param>
        /// <param name="value1">The value to set the attribute to.</param>
        /// <param name="value2">The value to set the attribute to.</param>
        /// <param name="value3">The value to set the attribute to.</param>
        [DllImport(AL.Lib, EntryPoint = "alListener3f", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void Listener(Enums.ALListener3f param, float value1, float value2, float value3);
        // AL_API void AL_APIENTRY alListener3f( ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );

        /// <summary>This function sets a Math.Vector3 property for the listener.</summary>
        /// <param name="param">The name of the attribute to set: AL_POSITION, AL_VELOCITY</param>
        /// <param name="values">The Math.Vector3 to set the attribute to.</param>
        public static void Listener(Enums.ALListener3f param, ref Vector3 values)
        {
            Listener(param, values.X, values.Y, values.Z);
        }

        [DllImport(AL.Lib, EntryPoint = "alListenerfv", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        unsafe private static extern void ListenerPrivate(Enums.ALListenerfv param, float* values);
        // AL_API void AL_APIENTRY alListenerfv( ALenum param, const ALfloat* values );

        /// <summary>This function sets a floating point-vector property of the listener.</summary>
        /// <param name="param">The name of the attribute to be set: AL_POSITION, AL_VELOCITY, AL_ORIENTATION</param>
        /// <param name="values">Pointer to floating point-vector values.</param>
        public static void Listener(Enums.ALListenerfv param, ref float[] values)
        {
            unsafe
            {
                fixed (float* ptr = &values[0])
                {
                    ListenerPrivate(param, ptr);
                }
            }
        }

        /// <summary>This function sets two Math.Vector3 properties of the listener.</summary>
        /// <param name="param">The name of the attribute to be set: AL_ORIENTATION</param>
        /// <param name="at">A Math.Vector3 for the At-Vector.</param>
        /// <param name="up">A Math.Vector3 for the Up-Vector.</param>
        public static void Listener(Enums.ALListenerfv param, ref Vector3 at, ref Vector3 up)
        {
            float[] temp = new float[6];

            temp[0] = at.X;
            temp[1] = at.Y;
            temp[2] = at.Z;

            temp[3] = up.X;
            temp[4] = up.Y;
            temp[5] = up.Z;

            unsafe
            {
                fixed (float* ptr = &temp[0])
                {
                    ListenerPrivate(param, ptr);
                }
            }
        }

        // AL_API void AL_APIENTRY alListeneri( ALenum param, ALint value );
        // AL_API void AL_APIENTRY alListener3i( ALenum param, ALint value1, ALint value2, ALint value3 );
        // AL_API void AL_APIENTRY alListeneriv( ALenum param, const ALint* values );

        #endregion Set Listener parameters

        #region Get Listener parameters

        /// <summary>This function retrieves a floating point property of the listener.</summary>
        /// <param name="param">the name of the attribute to be retrieved: AL_GAIN</param>
        /// <param name="value">a pointer to the floating point value being retrieved.</param>
        [DllImport(AL.Lib, EntryPoint = "alGetListenerf", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void GetListener(Enums.ALListenerf param, [Out] out float value);
        // AL_API void AL_APIENTRY alGetListenerf( ALenum param, ALfloat* value );

        /// <summary>This function retrieves a set of three floating point values from a property of the listener.</summary>
        /// <param name="param">The name of the attribute to be retrieved: AL_POSITION, AL_VELOCITY</param>
        /// <param name="value1">Pointers to the three floating point being retrieved.</param>
        /// <param name="value2">Pointers to the three floating point being retrieved.</param>
        /// <param name="value3">Pointers to the three floating point being retrieved.</param>
        [DllImport(AL.Lib, EntryPoint = "alGetListener3f", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void GetListener(Enums.ALListener3f param, [Out] out float value1, [Out] out float value2, [Out] out float value3);
        // AL_API void AL_APIENTRY alGetListener3f( ALenum param, ALfloat *value1, ALfloat *value2, ALfloat *value3 );

        /// <summary>This function retrieves a Math.Vector3 from a property of the listener.</summary>
        /// <param name="param">The name of the attribute to be retrieved: AL_POSITION, AL_VELOCITY</param>
        /// <param name="values">A Math.Vector3 to hold the three floats being retrieved.</param>
        public static void GetListener(Enums.ALListener3f param, out Vector3 values)
        {
            GetListener(param, out values.X, out values.Y, out values.Z);
        }

        /// <summary>This function retrieves a floating point-vector property of the listener. You must pin it manually.</summary>
        /// <param name="param">the name of the attribute to be retrieved: AL_POSITION, AL_VELOCITY, AL_ORIENTATION</param>
        /// <param name="values">A pointer to the floating point-vector value being retrieved.</param>
        [DllImport(AL.Lib, EntryPoint = "alGetListenerfv", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        unsafe public static extern void GetListener(Enums.ALListenerfv param, float* values);
        // AL_API void AL_APIENTRY alGetListenerfv( ALenum param, ALfloat* values );

        /// <summary>This function retrieves two Math.Vector3 properties of the listener.</summary>
        /// <param name="param">the name of the attribute to be retrieved: AL_ORIENTATION</param>
        /// <param name="at">A Math.Vector3 for the At-Vector.</param>
        /// <param name="up">A Math.Vector3 for the Up-Vector.</param>
        public static void GetListener(Enums.ALListenerfv param, out Vector3 at, out Vector3 up)
        {
            float[] pinned = new float[6]; // should lose scope when the function exits
            unsafe
            {
                fixed (float* ptr = &pinned[0])
                {
                    GetListener(param, ptr);

                    at.X = pinned[0];
                    at.Y = pinned[1];
                    at.Z = pinned[2];

                    up.X = pinned[3];
                    up.Y = pinned[4];
                    up.Z = pinned[5];
                }
            }
        }

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

        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alGenSources", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        unsafe private static extern void GenSourcesPrivate(int n, [Out] uint* sources);
        // AL_API void AL_APIENTRY alGenSources( ALsizei n, ALuint* Sources );

        /// <summary>This function generates one or more sources. References to sources are ALuint values, which are used wherever a source reference is needed (in calls such as alDeleteSources and alSourcei).</summary>
        /// <param name="n">The number of sources to be generated.</param>
        /// <param name="sources">Pointer to an array of uint values which will store the names of the new sources.</param>
        [CLSCompliant(false)]
        public static void GenSources(int n, out uint sources)
        {
            unsafe
            {
                fixed (uint* ptr = &sources)
                {
                    GenSourcesPrivate(n, (uint*)ptr);
                    sources = *ptr;
                }
            }
        }

        /// <summary>This function generates one source only. References to sources are ALuint values, which are used wherever a source reference is needed (in calls such as alDeleteSources and alSourcei).</summary>
        /// <param name="sources">Pointer to an uint value which will store the name of the new source.</param>
        [CLSCompliant(false)]
        public static void GenSources(out uint source)
        {
            GenSources(1, out source);
        }

        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alDeleteSources", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        unsafe private static extern void DeleteSourcesPrivate(int n, [In] uint* sources); // Delete Source objects 
        // AL_API void AL_APIENTRY alDeleteSources( ALsizei n, const ALuint* Sources );

        /// <summary>This function deletes one or more sources.</summary>
        /// <param name="n">The number of sources to be deleted.</param>
        /// <param name="sources">Pointer to an array of source names identifying the sources to be deleted.</param>
        [CLSCompliant(false)]
        public static void DeleteSources(int n, ref uint[] sources)
        {
            unsafe
            {
                fixed (uint* ptr = sources)
                {
                    DeleteSourcesPrivate(n, (uint*)ptr);
                }
            }
        }

        /// <summary>This function deletes one source only.</summary>
        /// <param name="sources">Pointer to a source name identifying the source to be deleted.</param>
        [CLSCompliant(false)]
        public static void DeleteSources(ref uint source)
        {
            uint[] t = new uint[1];
            t[0] = source;
            DeleteSources(1, ref t);
        }

        /// <summary>This function tests if a source name is valid, returning True if valid and False if not.</summary>
        /// <param name="sid">A source name to be tested for validity</param>
        /// <returns>Success.</returns>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alIsSource", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern AL.Bool IsSource(uint sid); // Verify a handle is a valid Source 
        // AL_API ALboolean AL_APIENTRY alIsSource( ALuint sid );

        #endregion Create Source objects

        #region Set Source parameters

        /// <summary>This function sets a floating point property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being set</param>
        /// <param name="param">The name of the attribute to set: AL_PITCH, AL_GAIN, AL_MIN_GAIN, AL_MAX_GAIN, AL_MAX_DISTANCE, AL_ROLLOFF_FACTOR, AL_CONE_OUTER_GAIN, AL_CONE_INNER_ANGLE, AL_CONE_OUTER_ANGLE, AL_REFERENCE_DISTANCE</param>
        /// <param name="value">The value to set the attribute to.</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourcef", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void Source(uint sid, Enums.ALSourcef param, float value);
        // AL_API void AL_APIENTRY alSourcef( ALuint sid, ALenum param, ALfloat value );

        /// <summary>This function sets a source property requiring three floating point values.</summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: AL_POSITION, AL_VELOCITY, AL_DIRECTION</param>
        /// <param name="value1">The three ALfloat values which the attribute will be set to.</param>
        /// <param name="value2">The three ALfloat values which the attribute will be set to.</param>
        /// <param name="value3">The three ALfloat values which the attribute will be set to.</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSource3f", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void Source(uint sid, Enums.ALSource3f param, float value1, float value2, float value3);
        // AL_API void AL_APIENTRY alSource3f( ALuint sid, ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );

        /// <summary>This function sets a source property requiring three floating point values.</summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: AL_POSITION, AL_VELOCITY, AL_DIRECTION</param>
        /// <param name="values">A Math.Vector3 which the attribute will be set to.</param>
        [CLSCompliant(false)]
        public static void Source(uint sid, Enums.ALSource3f param, ref Vector3 values)
        {
            Source(sid, param, values.X, values.Y, values.Z);
        }

        /// <summary>This function sets an integer property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: AL_SOURCE_RELATIVE, AL_CONE_INNER_ANGLE, AL_CONE_OUTER_ANGLE, AL_LOOPING, AL_BUFFER, AL_SOURCE_STATE</param>
        /// <param name="value">The value to set the attribute to.</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourcei", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void Source(uint sid, Enums.ALSourcei param, int value);
        // AL_API void AL_APIENTRY alSourcei( ALuint sid, ALenum param, ALint value ); 

        /// <summary>This function sets an bool property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: AL_SOURCE_RELATIVE, AL_LOOPING</param>
        /// <param name="value">The value to set the attribute to.</param>
        [CLSCompliant(false)]
        public static void Source(uint sid, Enums.ALSourceb param, bool value)
        {
            Source(sid, (Enums.ALSourcei)param, (value) ? 1 : 0);
        }

        // AL_API void AL_APIENTRY alSourcefv( ALuint sid, ALenum param, const ALfloat* values );
        // AL_API void AL_APIENTRY alSource3i( ALuint sid, ALenum param, ALint value1, ALint value2, ALint value3 );
        // AL_API void AL_APIENTRY alSourceiv( ALuint sid, ALenum param, const ALint* values );

        #endregion Set Source parameters

        #region Get Source parameters

        /// <summary>This function retrieves a floating point property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute to retrieve: AL_PITCH, AL_GAIN, AL_MIN_GAIN, AL_MAX_GAIN, AL_MAX_DISTANCE, AL_ROLLOFF_FACTOR, AL_CONE_OUTER_GAIN, AL_CONE_INNER_ANGLE, AL_CONE_OUTER_ANGLE, AL_REFERENCE_DISTANCE</param>
        /// <param name="value">A pointer to the floating point value being retrieved</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alGetSourcef", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void GetSource(uint sid, Enums.ALSourcef param, [Out] out float value);
        // AL_API void AL_APIENTRY alGetSourcef( ALuint sid, ALenum param, ALfloat* value );

        /// <summary>This function retrieves three floating point values representing a property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">the name of the attribute being retrieved: AL_POSITION, AL_VELOCITY, AL_DIRECTION</param>
        /// <param name="value1">Pointer to the value to retrieve.</param>
        /// <param name="value2">Pointer to the value to retrieve.</param>
        /// <param name="value3">Pointer to the value to retrieve.</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alGetSource3f", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void GetSource(uint sid, Enums.ALSource3f param, [Out] out float value1, [Out] out float value2, [Out] out float value3);
        // AL_API void AL_APIENTRY alGetSource3f( ALuint sid, ALenum param, ALfloat* value1, ALfloat* value2, ALfloat* value3);

        /// <summary>This function retrieves three floating point values representing a property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">the name of the attribute being retrieved: AL_POSITION, AL_VELOCITY, AL_DIRECTION</param>
        /// <param name="values">A Math.Vector3 to retrieve the values to.</param>
        [CLSCompliant(false)]
        public static void GetSource(uint sid, Enums.ALSource3f param, out Vector3 values)
        {
            GetSource(sid, param, out values.X, out values.Y, out values.Z);
        }

        /// <summary>This function retrieves an integer property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute to retrieve: AL_SOURCE_RELATIVE, AL_BUFFER, AL_SOURCE_STATE, AL_BUFFERS_QUEUED, AL_BUFFERS_PROCESSED</param>
        /// <param name="value">A pointer to the integer value being retrieved.</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alGetSourcei", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void GetSource(uint sid, Enums.ALSourceiGet param, [Out] out int value);
        // AL_API void AL_APIENTRY alGetSourcei( ALuint sid,  ALenum param, ALint* value );

        /// <summary>This function retrieves a bool property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute to get: AL_SOURCE_RELATIVE, AL_LOOPING</param>
        /// <param name="value">A pointer to the bool value being retrieved.</param>
        [CLSCompliant(false)]
        public static void GetSource(uint sid, Enums.ALSourceb param, [Out] out bool value)
        {
            int result;
            GetSource(sid, (Enums.ALSourceiGet)param, out result);
            if (result == 1)
                value = true;
            else
                value = false;
        }

        // AL_API void AL_APIENTRY alGetSourcefv( ALuint sid, ALenum param, ALfloat* values );
        // AL_API void AL_APIENTRY alGetSource3i( ALuint sid, ALenum param, ALint* value1, ALint* value2, ALint* value3);
        // AL_API void AL_APIENTRY alGetSourceiv( ALuint sid,  ALenum param, ALint* values );

        #endregion Get Source parameters

        #region Source vector based playback calls

        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourcePlayv"), SuppressUnmanagedCodeSecurity]
        unsafe private static extern void SourcePlayPrivate(int ns, [In] uint* sids);
        // AL_API void AL_APIENTRY alSourcePlayv( ALsizei ns, const ALuint *sids );

        /// <summary>This function plays a set of sources. The playing sources will have their state changed to AL_PLAYING. When called on a source which is already playing, the source will restart at the beginning. When the attached buffer(s) are done playing, the source will progress to the AL_STOPPED state.</summary>
        /// <param name="ns">The number of sources to be played.</param>
        /// <param name="sids">A pointer to an array of sources to be played.</param>
        [CLSCompliant(false)]
        public static void SourcePlay(int ns, [In] uint[] sids)
        {
            unsafe
            {
                fixed (uint* ptr = sids)
                {
                    SourcePlayPrivate(ns, ptr);
                }
            }
        }

        /// <summary>This function plays a set of sources. The playing sources will have their state changed to AL_PLAYING. When called on a source which is already playing, the source will restart at the beginning. When the attached buffer(s) are done playing, the source will progress to the AL_STOPPED state.</summary>
        /// <param name="ns">The number of sources to be played.</param>
        /// <param name="sids">A pointer to an array of sources to be played.</param>
        [CLSCompliant(false)]
        public static void SourcePlay(int ns, [In] ref uint sids)
        {
            unsafe
            {
                fixed (uint* ptr = &sids)
                {
                    SourcePlayPrivate(ns, ptr);
                }
            }
        }

        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourceStopv"), SuppressUnmanagedCodeSecurity]
        unsafe private static extern void SourceStopPrivate(int ns, [In] uint* sids);
        // AL_API void AL_APIENTRY alSourceStopv( ALsizei ns, const ALuint *sids );

        /// <summary>This function stops a set of sources. The stopped sources will have their state changed to AL_STOPPED.</summary>
        /// <param name="ns">The number of sources to stop.</param>
        /// <param name="sids">A pointer to an array of sources to be stopped.</param>
        [CLSCompliant(false)]
        public static void SourceStop(int ns, [In] uint[] sids)
        {
            unsafe
            {
                fixed (uint* ptr = sids)
                {
                    SourceStopPrivate(ns, ptr);
                }
            }
        }

        /// <summary>This function stops a set of sources. The stopped sources will have their state changed to AL_STOPPED.</summary>
        /// <param name="ns">The number of sources to stop.</param>
        /// <param name="sids">A pointer to an array of sources to be stopped.</param>
        [CLSCompliant(false)]
        public static void SourceStop(int ns, [In] ref uint sids)
        {
            unsafe
            {
                fixed (uint* ptr = &sids)
                {
                    SourceStopPrivate(ns, ptr);
                }
            }
        }

        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourceRewindv"), SuppressUnmanagedCodeSecurity]
        unsafe private static extern void SourceRewindPrivate(int ns, [In] uint* sids);
        // AL_API void AL_APIENTRY alSourceRewindv( ALsizei ns, const ALuint *sids );

        /// <summary>This function stops a set of sources and sets all their states to AL_INITIAL.</summary>
        /// <param name="ns">The number of sources to be rewound.</param>
        /// <param name="sids">A pointer to an array of sources to be rewound.</param>
        [CLSCompliant(false)]
        public static void SourceRewind(int ns, [In] uint[] sids)
        {
            unsafe
            {
                fixed (uint* ptr = sids)
                {
                    SourceRewindPrivate(ns, ptr);
                }
            }
        }

        /// <summary>This function stops a set of sources and sets all their states to AL_INITIAL.</summary>
        /// <param name="ns">The number of sources to be rewound.</param>
        /// <param name="sids">A pointer to an array of sources to be rewound.</param>
        [CLSCompliant(false)]
        public static void SourceRewind(int ns, [In] ref uint sids)
        {
            unsafe
            {
                fixed (uint* ptr = &sids)
                {
                    SourceRewindPrivate(ns, ptr);
                }
            }
        }

        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourcePausev"), SuppressUnmanagedCodeSecurity]
        unsafe private static extern void SourcePausePrivate(int ns, [In] uint* sids);
        // AL_API void AL_APIENTRY alSourcePausev( ALsizei ns, const ALuint *sids );

        /// <summary>This function pauses a set of sources. The paused sources will have their state changed to AL_PAUSED.</summary>
        /// <param name="ns">The number of sources to be paused.</param>
        /// <param name="sids">A pointer to an array of sources to be paused.</param>
        [CLSCompliant(false)]
        public static void SourcePause(int ns, [In] uint[] sids)
        {
            unsafe
            {
                fixed (uint* ptr = sids)
                {
                    SourcePausePrivate(ns, ptr);
                }
            }
        }

        /// <summary>This function pauses a set of sources. The paused sources will have their state changed to AL_PAUSED.</summary>
        /// <param name="ns">The number of sources to be paused.</param>
        /// <param name="sids">A pointer to an array of sources to be paused.</param>
        [CLSCompliant(false)]
        public static void SourcePause(int ns, [In] ref uint sids)
        {
            unsafe
            {
                fixed (uint* ptr = &sids)
                {
                    SourcePausePrivate(ns, ptr);
                }
            }
        }

        #endregion Source vector based playback calls

        #region Source based playback calls

        /// <summary>This function plays a source. The playing source will have its state changed to AL_PLAYING. When called on a source which is already playing, the source will restart at the beginning. When the attached buffer(s) are done playing, the source will progress to the AL_STOPPED state.</summary>
        /// <param name="sid">The name of the source to be played.</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourcePlay", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void SourcePlay(uint sid);// Play, replay, or resume a Source
        // AL_API void AL_APIENTRY alSourcePlay( ALuint sid );

        /// <summary>This function stops a source. The stopped source will have its state changed to AL_STOPPED.</summary>
        /// <param name="sid">The name of the source to be stopped.</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourceStop", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void SourceStop(uint sid); // Stop a Source
        // AL_API void AL_APIENTRY alSourceStop( ALuint sid );

        /// <summary>This function stops the source and sets its state to AL_INITIAL.</summary>
        /// <param name="sid">The name of the source to be rewound.</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourceRewind", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void SourceRewind(uint sid);// Rewind a Source (set playback postiton to beginning) 
        // AL_API void AL_APIENTRY alSourceRewind( ALuint sid );

        /// <summary>This function pauses a source. The paused source will have its state changed to AL_PAUSED.</summary>
        /// <param name="sid">The name of the source to be paused.</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourcePause", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void SourcePause(uint sid); // Pause a Source
        // AL_API void AL_APIENTRY alSourcePause( ALuint sid );

        #endregion Source based playback calls

        #region Source Queuing

        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourceQueueBuffers"), SuppressUnmanagedCodeSecurity]
        unsafe private static extern void SourceQueueBuffers(uint sid, int numEntries, [In] uint* bids);
        // AL_API void AL_APIENTRY alSourceQueueBuffers( ALuint sid, ALsizei numEntries, const ALuint *bids );

        /// <summary>This function queues a set of buffers on a source. All buffers attached to a source will be played in sequence, and the number of processed buffers can be detected using an alSourcei call to retrieve AL_BUFFERS_PROCESSED. When first created, a source will be of type AL_UNDETERMINED. A successful alSourceQueueBuffers call will change the source type to AL_STREAMING.</summary>
        /// <param name="sid">The name of the source to queue buffers onto.</param>
        /// <param name="numEntries">The number of buffers to be queued.</param>
        /// <param name="bids">A pointer to an array of buffer names to be queued.</param>
        [CLSCompliant(false)]
        public static void SourceQueueBuffers(uint sid, int numEntries, [In] uint[] bids)
        {
            unsafe
            {
                fixed (uint* ptr = bids)
                {
                    SourceQueueBuffers(sid, numEntries, ptr);
                }
            }
        }

        /// <summary>This function queues a set of buffers on a source. All buffers attached to a source will be played in sequence, and the number of processed buffers can be detected using an alSourcei call to retrieve AL_BUFFERS_PROCESSED. When first created, a source will be of type AL_UNDETERMINED. A successful alSourceQueueBuffers call will change the source type to AL_STREAMING.</summary>
        /// <param name="sid">The name of the source to queue buffers onto.</param>
        /// <param name="numEntries">The number of buffers to be queued.</param>
        /// <param name="bids">A pointer to an array of buffer names to be queued.</param>
        [CLSCompliant(false)]
        public static void SourceQueueBuffers(uint sid, int numEntries, [In] ref uint bids)
        {
            unsafe
            {
                fixed (uint* ptr = &bids)
                {
                    SourceQueueBuffers(sid, numEntries, ptr);
                }
            }
        }

        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alSourceUnqueueBuffers"), SuppressUnmanagedCodeSecurity]
        unsafe private static extern void SourceUnqueueBuffers(uint sid, int numEntries, [In] uint* bids);
        // AL_API void AL_APIENTRY alSourceUnqueueBuffers( ALuint sid, ALsizei numEntries, ALuint *bids );

        /// <summary>This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected using an alSourcei call to retrieve AL_BUFFERS_PROCESSED, which is the maximum number of buffers that can be unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the queue.</summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <param name="bids">A pointer to an array of buffer names that were removed.</param>
        [CLSCompliant(false)]
        public static void SourceUnqueueBuffers(uint sid, int numEntries, [In] uint[] bids)
        {
            unsafe
            {
                fixed (uint* ptr = bids)
                {
                    SourceUnqueueBuffers(sid, numEntries, ptr);
                }
            }
        }

        /// <summary>This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected using an alSourcei call to retrieve AL_BUFFERS_PROCESSED, which is the maximum number of buffers that can be unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the queue.</summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <param name="bids">A pointer to an array of buffer names that were removed.</param>
        [CLSCompliant(false)]
        public static void SourceUnqueueBuffers(uint sid, int numEntries, [In] ref uint bids)
        {
            unsafe
            {
                fixed (uint* ptr = &bids)
                {
                    SourceUnqueueBuffers(sid, numEntries, ptr);
                }
            }
        }

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

        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alGenBuffers", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        unsafe private static extern void GenBuffersPrivate(int n, [Out] uint* buffers);
        // AL_API void AL_APIENTRY alGenBuffers( ALsizei n, ALuint* Buffers );

        /// <summary>This function generates one or more buffers, which contain audio data (see alBufferData). References to buffers are ALuint values, which are used wherever a buffer reference is needed (in calls such as alDeleteBuffers, alSourcei, alSourceQueueBuffers, and alSourceUnqueueBuffers).</summary>
        /// <param name="n">The number of buffers to be generated.</param>
        /// <param name="buffers">Pointer to an array of uint values which will store the names of the new buffers.</param>
        [CLSCompliant(false)]
        public static void GenBuffers(int n, out uint buffers)
        {
            unsafe
            {
                fixed (uint* ptr = &buffers)
                {
                    GenBuffersPrivate(n, (uint*)ptr);
                    buffers = *ptr;
                }
            }
        }

        /// <summary>This function generates one buffer only, which contain audio data (see alBufferData). References to buffers are ALuint values, which are used wherever a buffer reference is needed (in calls such as alDeleteBuffers, alSourcei, alSourceQueueBuffers, and alSourceUnqueueBuffers).</summary>
        /// <param name="buffers">Pointer to an uint value which will store the name of the new buffer.</param>
        [CLSCompliant(false)]
        public static void GenBuffers(out uint buffer)
        {
            GenBuffers(1, out buffer);
        }

        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alDeleteBuffers", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        unsafe private static extern void DeleteBuffersPrivate(int n, [In] uint* buffers);  // Delete Buffer objects
        // AL_API void AL_APIENTRY alDeleteBuffers( ALsizei n, const ALuint* Buffers );

        /// <summary>This function deletes one or more buffers, freeing the resources used by the buffer. Buffers which are attached to a source can not be deleted. See alSourcei and alSourceUnqueueBuffers for information on how to detach a buffer from a source.</summary>
        /// <param name="n">The number of buffers to be deleted.</param>
        /// <param name="buffers">Pointer to an array of buffer names identifying the buffers to be deleted.</param>
        [CLSCompliant(false)]
        public static void DeleteBuffers(int n, ref uint[] buffers)
        {
            unsafe
            {
                fixed (uint* ptr = buffers)
                {
                    DeleteBuffersPrivate(n, (uint*)ptr);
                }
            }
        }

        /// <summary>This function deletes one buffer only, freeing the resources used by the buffer. Buffers which are attached to a source can not be deleted. See AL.Source and AL.SourceUnqueueBuffers for information on how to detach a buffer from a source.</summary>
        /// <param name="buffers">Pointer to a buffer name identifying the buffer to be deleted.</param>
        [CLSCompliant(false)]
        public static void DeleteBuffers(ref uint buffer)
        {
            unsafe
            {
                fixed (uint* ptr = &buffer)
                {
                    DeleteBuffersPrivate(1, (uint*)ptr);
                }
            }
        }

        /// <summary>This function tests if a buffer name is valid, returning AL_TRUE if valid, AL_FALSE if not.</summary>
        /// <param name="bid">A buffer Handle previously allocated with <see cref="Al.GenBuffers"/>.</param>
        /// <returns>Success.</returns>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alIsBuffer", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern AL.Bool IsBuffer(uint bid);
        // AL_API ALboolean AL_APIENTRY alIsBuffer( ALuint bid );

        /// <summary>This function fills a buffer with audio data. All the pre-defined formats are PCM data, but this function may be used by extensions to load other data types as well.</summary>
        /// <param name="bid">buffer Handle/Name to be filled with data.</param>
        /// <param name="format">Format type from among the following: AL_FORMAT_MONO8, AL_FORMAT_MONO16, AL_FORMAT_STEREO8, AL_FORMAT_STEREO16</param>
        /// <param name="data">Pointer to the audio data. YOU MUST PIN THIS MANUALLY.</param>
        /// <param name="size">The size of the audio data in bytes.</param>
        /// <param name="freq">The frequency of the audio data.</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alBufferData", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void BufferData(uint bid, Enums.ALFormat format, IntPtr data, int size, int freq); // Specify the data to be copied into a Buffer
        // AL_API void AL_APIENTRY alBufferData( ALuint bid, ALenum format, const ALvoid* data, ALsizei size, ALsizei freq );

        #endregion Buffer objects

        #region Set Buffer parameters (currently parameters can only be read)

        /*
        Remarks (from Manual)
         * There are no relevant buffer properties defined in OpenAL 1.1 which can be affected by this call,
         * but this function may be used by OpenAL extensions.

        // AL_API void AL_APIENTRY alBufferf( ALuint bid, ALenum param, ALfloat value );
        // AL_API void AL_APIENTRY alBufferfv( ALuint bid, ALenum param, const ALfloat* values );
        // AL_API void AL_APIENTRY alBufferi( ALuint bid, ALenum param, ALint value );
        // AL_API void AL_APIENTRY alBuffer3i( ALuint bid, ALenum param, ALint value1, ALint value2, ALint value3 );
        // AL_API void AL_APIENTRY alBufferiv( ALuint bid, ALenum param, const ALint* values );
        // AL_API void AL_APIENTRY alBuffer3f( ALuint bid, ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );
       */
        /*
        [DllImport( Al.Lib, EntryPoint = "alBuffer3f", ExactSpelling = true, CallingConvention = Al.Style ), SuppressUnmanagedCodeSecurity( )]
        public static extern void Buffer3f( uint bid, ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );

        public static void Bufferv3( uint bid, Alenum param, ref Vector3 values )
        {
            Buffer3f( bid, param, values.X, values.Y, values.Z );
        }*/

        #endregion Set Buffer parameters

        #region Get Buffer parameters

        /// <summary>This function retrieves an integer property of a buffer.</summary>
        /// <param name="bid">Buffer name whose attribute is being retrieved</param>
        /// <param name="param">The name of the attribute to be retrieved: AL_FREQUENCY, AL_BITS, AL_CHANNELS, AL_SIZE, and the currently hidden AL_DATA.</param>
        /// <param name="value">A pointer to an ALint to hold the retrieved data</param>
        [CLSCompliant(false), DllImport(AL.Lib, EntryPoint = "alGetBufferi", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void GetBuffer(uint bid, Enums.ALGetBufferi param, [Out] out int value);
        // AL_API void AL_APIENTRY alGetBufferi( ALuint bid, ALenum param, ALint* value );

        // AL_API void AL_APIENTRY alGetBufferf( ALuint bid, ALenum param, ALfloat* value );
        // AL_API void AL_APIENTRY alGetBuffer3f( ALuint bid, ALenum param, ALfloat* value1, ALfloat* value2, ALfloat* value3);
        // AL_API void AL_APIENTRY alGetBufferfv( ALuint bid, ALenum param, ALfloat* values );
        // AL_API void AL_APIENTRY alGetBuffer3i( ALuint bid, ALenum param, ALint* value1, ALint* value2, ALint* value3);
        // AL_API void AL_APIENTRY alGetBufferiv( ALuint bid, ALenum param, ALint* values );

        #endregion Get Buffer parameters

        #region Global Parameters

        /// <summary>AL.DopplerFactor is a simple scaling of source and listener velocities to exaggerate or deemphasize the Doppler (pitch) shift resulting from the calculation.</summary>
        /// <param name="value">A negative value will result in an error, the command is then ignored. The default value is 1f. The current setting can be queried using Al.GetFloat.</param>
        [DllImport(AL.Lib, EntryPoint = "alDopplerFactor", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void DopplerFactor(float value);
        // AL_API void AL_APIENTRY alDopplerFactor( ALfloat value );

        /// <summary>This function is deprecated and should not be used.</summary>
        /// <param name="value">The default is 1.0f.</param>
        [DllImport(AL.Lib, EntryPoint = "alDopplerVelocity", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void DopplerVelocity(float value);
        // AL_API void AL_APIENTRY alDopplerVelocity( ALfloat value );

        /// <summary>Al.SpeedOfSound allows the application to change the reference (propagation) speed used in the Doppler calculation. The source and listener velocities should be expressed in the same units as the speed of sound.</summary>
        /// <param name="value">A negative or zero value will result in an error, and the command is ignored. The default value is 343.3f (appropriate for velocity units of meters and air as the propagation medium). The current setting can be queried using Al.GetFloat</param>
        [DllImport(AL.Lib, EntryPoint = "alSpeedOfSound", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void SpeedOfSound(float value);
        // AL_API void AL_APIENTRY alSpeedOfSound( ALfloat value );

        /// <summary>This function selects the OpenAL distance model – AL_INVERSE_DISTANCE, AL_INVERSE_DISTANCE_CLAMPED, AL_LINEAR_DISTANCE, AL_LINEAR_DISTANCE_CLAMPED, AL_EXPONENT_DISTANCE, AL_EXPONENT_DISTANCE_CLAMPED, or AL_NONE. The default distance model in OpenAL is AL_INVERSE_DISTANCE_CLAMPED.</summary>
        /// <remarks>
        /// The AL_INVERSE_DISTANCE model works according to the following formula:
        /// gain = AL_REFERENCE_DISTANCE / (AL_REFERENCE_DISTANCE + AL_ROLLOFF_FACTOR * (distance – AL_REFERENCE_DISTANCE));
        /// 
        /// The AL_INVERSE_DISTANCE_CLAMPED model works according to the following formula:
        /// distance = max(distance,AL_REFERENCE_DISTANCE);
        /// distance = min(distance,AL_MAX_DISTANCE);
        /// gain = AL_REFERENCE_DISTANCE / (AL_REFERENCE_DISTANCE + AL_ROLLOFF_FACTOR * (distance – AL_REFERENCE_DISTANCE));
        /// 
        /// The AL_LINEAR_DISTANCE model works according to the following formula: 
        /// distance = min(distance, AL_MAX_DISTANCE) // avoid negative gain
        /// gain = (1 – AL_ROLLOFF_FACTOR * (distance – AL_REFERENCE_DISTANCE) / (AL_MAX_DISTANCE – AL_REFERENCE_DISTANCE))
        /// 
        /// The AL_LINEAR_DISTANCE_CLAMPED model works according to the following formula:
        /// distance = max(distance, AL_REFERENCE_DISTANCE)
        /// distance = min(distance, AL_MAX_DISTANCE)
        /// gain = (1 – AL_ROLLOFF_FACTOR * (distance – AL_REFERENCE_DISTANCE) / (AL_MAX_DISTANCE – AL_REFERENCE_DISTANCE))
        /// 
        /// The AL_EXPONENT_DISTANCE model works according to the following formula:
        /// gain = (distance / AL_REFERENCE_DISTANCE) ^ (- AL_ROLLOFF_FACTOR) 
        /// 
        /// The AL_EXPONENT_DISTANCE_CLAMPED model works according to the following formula:
        /// distance = max(distance, AL_REFERENCE_DISTANCE)
        /// distance = min(distance, AL_MAX_DISTANCE)
        /// gain = (distance / AL_REFERENCE_DISTANCE) ^ (- AL_ROLLOFF_FACTOR)
        /// 
        /// The AL_NONE model works according to the following formula:
        /// gain = 1f;
        /// </remarks>
        /// <param name="distancemodel"></param>
        [DllImport(AL.Lib, EntryPoint = "alDistanceModel", ExactSpelling = true, CallingConvention = AL.Style), SuppressUnmanagedCodeSecurity()]
        public static extern void DistanceModel(Enums.ALDistanceModel distancemodel);
        // AL_API void AL_APIENTRY alDistanceModel( ALenum distanceModel );

        #endregion Global Parameters
    }

}