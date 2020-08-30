//
// AL.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;
using System.Security;
using OpenTK.Audio.OpenAL;
using OpenTK.Audio.OpenAL.Native;
using OpenTK.Core.Native;
using OpenTK.Mathematics;
using OpenTK.OpenAL;

namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// Provides access to the OpenAL 1.1 flat API.
    /// </summary>
    public partial class AL : ALBase
    {
        internal const string Lib = nameof(AL);
        internal const CallingConvention ALCallingConvention = CallingConvention.Cdecl;

        static AL()
        {
            // We need to register the resolver for OpenAL before we can DllImport functions.
            ALBase.RegisterOpenALResolver();
        }

        private AL()
        {
        }

        /// <summary>This function enables a feature of the OpenAL driver. There are no capabilities defined in OpenAL 1.1 to be used with this function, but it may be used by an extension.</summary>
        /// <param name="capability">The name of a capability to enable.</param>
        [DllImport(Lib, EntryPoint = "alEnable", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Enable(ALCapability capability);
        // AL_API void AL_APIENTRY alEnable( ALenum capability );

        /// <summary>This function disables a feature of the OpenAL driver.</summary>
        /// <param name="capability">The name of a capability to disable.</param>
        [DllImport(Lib, EntryPoint = "alDisable", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Disable(ALCapability capability);
        // AL_API void AL_APIENTRY alDisable( ALenum capability );

        /// <summary>This function returns a boolean indicating if a specific feature is enabled in the OpenAL driver.</summary>
        /// <param name="capability">The name of a capability to enable.</param>
        /// <returns>True if enabled, False if disabled.</returns>
        [DllImport(Lib, EntryPoint = "alIsEnabled", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern bool IsEnabled(ALCapability capability);
        // AL_API ALboolean AL_APIENTRY alIsEnabled( ALenum capability );

        /// <summary>This function retrieves an OpenAL string property.</summary>
        /// <param name="param">The property to be returned: Vendor, Version, Renderer and Extensions.</param>
        /// <returns>Returns a pointer to a null-terminated string.</returns>
        [DllImport(Lib, EntryPoint = "alGetString", ExactSpelling = true, CallingConvention = ALCallingConvention, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string Get(ALGetString param);

        /// <summary>This function retrieves an OpenAL string property.</summary>
        /// <param name="param">The human-readable errorstring to be returned.</param>
        /// <returns>Returns a pointer to a null-terminated string.</returns>
        public static string GetErrorString(ALError param) => Get((ALGetString)param);

        /* no functions return more than 1 result ..
        // AL_API void AL_APIENTRY alGetBooleanv( ALenum param, ALboolean* buffer );
        // AL_API void AL_APIENTRY alGetIntegerv( ALenum param, ALint* buffer );
        // AL_API void AL_APIENTRY alGetFloatv( ALenum param, ALfloat* buffer );
        // AL_API void AL_APIENTRY alGetDoublev( ALenum param, ALdouble* buffer );
        */

        /* disabled due to no token using it
        /// <summary>This function returns a boolean OpenAL state.</summary>
        /// <param name="param">the state to be queried: AL_DOPPLER_FACTOR, AL_SPEED_OF_SOUND, AL_DISTANCE_MODEL</param>
        /// <returns>The boolean state described by param will be returned.</returns>
        [DllImport( AL.Lib, EntryPoint = "alGetBoolean", ExactSpelling = true, CallingConvention = AL.Style ), SuppressUnmanagedCodeSecurity( )]
        public static extern bool Get( ALGetBoolean param );
        // AL_API ALboolean AL_APIENTRY alGetBoolean( ALenum param );
        */

        /// <summary>This function returns an integer OpenAL state.</summary>
        /// <param name="param">the state to be queried: DistanceModel.</param>
        /// <returns>The integer state described by param will be returned.</returns>
        [DllImport(Lib, EntryPoint = "alGetInteger", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern int Get(ALGetInteger param);
        // AL_API ALint AL_APIENTRY alGetInteger( ALenum param );

        /// <summary>This function returns a floating-point OpenAL state.</summary>
        /// <param name="param">the state to be queried: DopplerFactor, SpeedOfSound.</param>
        /// <returns>The floating-point state described by param will be returned.</returns>
        [DllImport(Lib, EntryPoint = "alGetFloat", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern float Get(ALGetFloat param);
        // AL_API ALfloat AL_APIENTRY alGetFloat( ALenum param );

        /* disabled due to no token using it
        /// <summary>This function returns a double-precision floating-point OpenAL state.</summary>
        /// <param name="param">the state to be queried: AL_DOPPLER_FACTOR, AL_SPEED_OF_SOUND, AL_DISTANCE_MODEL</param>
        /// <returns>The double value described by param will be returned.</returns>
        [DllImport( AL.Lib, EntryPoint = "alGetDouble", ExactSpelling = true, CallingConvention = AL.Style ), SuppressUnmanagedCodeSecurity( )]
        public static extern double Get( ALGetDouble param );
        // AL_API ALdouble AL_APIENTRY alGetDouble( ALenum param );
        */

        /// <summary>Error support. Obtain the most recent error generated in the AL state machine. When an error is detected by AL, a flag is set and the error code is recorded. Further errors, if they occur, do not affect this recorded code. When alGetError is called, the code is returned and the flag is cleared, so that a further error will again record its code.</summary>
        /// <returns>The first error that occured. can be used with AL.GetString. Returns an Alenum representing the error state. When an OpenAL error occurs, the error state is set and will not be changed until the error state is retrieved using alGetError. Whenever alGetError is called, the error state is cleared and the last state (the current state when the call was made) is returned. To isolate error detection to a specific portion of code, alGetError should be called before the isolated section to clear the current error state.</returns>
        [DllImport(Lib, EntryPoint = "alGetError", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern ALError GetError();
        // AL_API ALenum AL_APIENTRY alGetError( void );

        /// <summary>This function tests if a specific Extension is available for the OpenAL driver.</summary>
        /// <param name="extname">A string naming the desired extension. Example: "EAX-RAM".</param>
        /// <returns>Returns True if the Extension is available or False if not available.</returns>
        [DllImport(Lib, EntryPoint = "alIsExtensionPresent", ExactSpelling = true, CallingConvention = ALCallingConvention, CharSet = CharSet.Ansi)]
        public static extern bool IsExtensionPresent([In] string extname);
        // AL_API ALboolean AL_APIENTRY alIsExtensionPresent( const ALchar* extname );

        /// <summary>This function returns the address of an OpenAL extension function. Handle with care.</summary>
        /// <param name="fname">A string containing the function name.</param>
        /// <returns>The return value is a pointer to the specified function. The return value will be IntPtr.Zero if the function is not found.</returns>
        [DllImport(Lib, EntryPoint = "alGetProcAddress", ExactSpelling = true, CallingConvention = ALCallingConvention, CharSet = CharSet.Ansi)]
        public static extern IntPtr GetProcAddress([In] string fname);
        // AL_API void* AL_APIENTRY alGetProcAddress( const ALchar* fname );

        /// <summary>This function returns the enumeration value of an OpenAL token, described by a string.</summary>
        /// <param name="ename">A string describing an OpenAL token. Example "AL_DISTANCE_MODEL".</param>
        /// <returns>Returns the actual ALenum described by a string. Returns 0 if the string doesn’t describe a valid OpenAL token.</returns>
        [DllImport(Lib, EntryPoint = "alGetEnumValue", ExactSpelling = true, CallingConvention = ALCallingConvention, CharSet = CharSet.Ansi)]
        public static extern int GetEnumValue([In] string ename);
        // AL_API ALenum AL_APIENTRY alGetEnumValue( const ALchar* ename );

        /* Listener
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

        /// <summary>This function sets a floating-point property for the listener.</summary>
        /// <param name="param">The name of the attribute to be set.</param>
        /// <param name="value">The float value to set the attribute to.</param>
        [DllImport(Lib, EntryPoint = "alListenerf", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Listener(ALListenerf param, float value);
        // AL_API void AL_APIENTRY alListenerf( ALenum param, ALfloat value );

        /// <summary>This function sets a floating-point property for the listener.</summary>
        /// <param name="param">The name of the attribute to set.</param>
        /// <param name="value1">The first value to set the attribute to.</param>
        /// <param name="value2">The second value to set the attribute to.</param>
        /// <param name="value3">The third value to set the attribute to.</param>
        [DllImport(Lib, EntryPoint = "alListener3f", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Listener(ALListener3f param, float value1, float value2, float value3);
        // AL_API void AL_APIENTRY alListener3f( ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );

        /// <summary>This function sets a Math.Vector3 property for the listener.</summary>
        /// <param name="param">The name of the attribute to set.</param>
        /// <param name="values">The Math.Vector3 to set the attribute to.</param>
        public static void Listener(ALListener3f param, ref Vector3 values)
        {
            Listener(param, values.X, values.Y, values.Z);
        }

        /// <summary>This function sets a floating-point vector property of the listener.</summary>
        /// <param name="param">The name of the attribute to be set.</param>
        /// <param name="values">Pointer to floating-point vector values.</param>
        [DllImport(Lib, EntryPoint = "alListenerfv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void Listener(ALListenerfv param, float* values);
        // AL_API void AL_APIENTRY alListenerfv( ALenum param, const ALfloat* values );

        /// <summary>This function sets a floating-point vector property of the listener.</summary>
        /// <param name="param">The name of the attribute to be set.</param>
        /// <param name="values">Pointer to floating-point vector values.</param>
        [DllImport(Lib, EntryPoint = "alListenerfv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Listener(ALListenerfv param, ref float values);
        // AL_API void AL_APIENTRY alListenerfv( ALenum param, const ALfloat* values );

        /// <summary>This function sets a floating-point vector property of the listener.</summary>
        /// <param name="param">The name of the attribute to be set.</param>
        /// <param name="values">Pointer to floating-point vector values.</param>
        [DllImport(Lib, EntryPoint = "alListenerfv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Listener(ALListenerfv param, float[] values);
        // AL_API void AL_APIENTRY alListenerfv( ALenum param, const ALfloat* values );

        /// <summary>This function sets two Math.Vector3 properties of the listener.</summary>
        /// <param name="param">The name of the attribute to be set.</param>
        /// <param name="at">A Math.Vector3 for the At-Vector.</param>
        /// <param name="up">A Math.Vector3 for the Up-Vector.</param>
        public static void Listener(ALListenerfv param, ref Vector3 at, ref Vector3 up)
        {
            Span<float> data = stackalloc float[6];

            data[0] = at.X;
            data[1] = at.Y;
            data[2] = at.Z;

            data[3] = up.X;
            data[4] = up.Y;
            data[5] = up.Z;

            Listener(param, ref data[0]);
        }

        // Not used by any Enums
        // AL_API void AL_APIENTRY alListeneri( ALenum param, ALint value );
        // AL_API void AL_APIENTRY alListener3i( ALenum param, ALint value1, ALint value2, ALint value3 );
        // AL_API void AL_APIENTRY alListeneriv( ALenum param, const ALint* values );

        /// <summary>This function retrieves a floating-point property of the listener.</summary>
        /// <param name="param">the name of the attribute to be retrieved: ALListenerf.Gain.</param>
        /// <param name="value">a pointer to the floating-point value being retrieved.</param>
        [DllImport(Lib, EntryPoint = "alGetListenerf", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GetListener(ALListenerf param, [Out] out float value);
        // AL_API void AL_APIENTRY alGetListenerf( ALenum param, ALfloat* value );

        /// <summary>This function retrieves a set of three floating-point values from a property of the listener.</summary>
        /// <param name="param">The name of the attribute to be retrieved.</param>
        /// <param name="value1">The first floating-point value being retrieved.</param>
        /// <param name="value2">The second floating-point value  being retrieved.</param>
        /// <param name="value3">The third floating-point value  being retrieved.</param>
        [DllImport(Lib, EntryPoint = "alGetListener3f", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GetListener(ALListener3f param, [Out] out float value1, [Out] out float value2, [Out] out float value3);
        // AL_API void AL_APIENTRY alGetListener3f( ALenum param, ALfloat *value1, ALfloat *value2, ALfloat *value3 );

        /// <summary>This function retrieves a Math.Vector3 from a property of the listener.</summary>
        /// <param name="param">The name of the attribute to be retrieved: ALListener3f.Position, ALListener3f.Velocity.</param>
        /// <param name="values">A Math.Vector3 to hold the three floats being retrieved.</param>
        public static void GetListener(ALListener3f param, out Vector3 values)
        {
            GetListener(param, out values.X, out values.Y, out values.Z);
        }

        /// <summary>This function retrieves a floating-point vector property of the listener. You must pin it manually.</summary>
        /// <param name="param">the name of the attribute to be retrieved: ALListener3f.Position, ALListener3f.Velocity, ALListenerfv.Orientation.</param>
        /// <param name="values">A pointer to the floating-point vector value being retrieved.</param>
        [DllImport(Lib, EntryPoint = "alGetListenerfv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void GetListener(ALListenerfv param, float* values);
        // AL_API void AL_APIENTRY alGetListenerfv( ALenum param, ALfloat* values );

        /// <summary>This function retrieves a floating-point vector property of the listener. You must pin it manually.</summary>
        /// <param name="param">the name of the attribute to be retrieved: ALListener3f.Position, ALListener3f.Velocity, ALListenerfv.Orientation.</param>
        /// <param name="values">A pointer to the floating-point vector value being retrieved.</param>
        [DllImport(Lib, EntryPoint = "alGetListenerfv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void GetListener(ALListenerfv param, ref float values);
        // AL_API void AL_APIENTRY alGetListenerfv( ALenum param, ALfloat* values );

        /// <summary>This function retrieves a floating-point vector property of the listener. You must pin it manually.</summary>
        /// <param name="param">the name of the attribute to be retrieved: ALListener3f.Position, ALListener3f.Velocity, ALListenerfv.Orientation.</param>
        /// <param name="values">A pointer to the floating-point vector value being retrieved.</param>
        [DllImport(Lib, EntryPoint = "alGetListenerfv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GetListener(ALListenerfv param, [In] float[] values);
        // AL_API void AL_APIENTRY alGetListenerfv( ALenum param, ALfloat* values );

        /// <summary>This function retrieves two Math.Vector3 properties of the listener.</summary>
        /// <param name="param">the name of the attribute to be retrieved: ALListenerfv.Orientation.</param>
        /// <param name="at">A Math.Vector3 for the At-Vector.</param>
        /// <param name="up">A Math.Vector3 for the Up-Vector.</param>
        public static void GetListener(ALListenerfv param, out Vector3 at, out Vector3 up)
        {
            Span<float> values = stackalloc float[6];
            GetListener(param, ref values[0]);

            at.X = values[0];
            at.Y = values[1];
            at.Z = values[2];

            up.X = values[3];
            up.Y = values[4];
            up.Z = values[5];
        }

        // Not used by any Enum:
        // AL_API void AL_APIENTRY alGetListeneri( ALenum param, ALint* value );
        // AL_API void AL_APIENTRY alGetListener3i( ALenum param, ALint *value1, ALint *value2, ALint *value3 );
        // AL_API void AL_APIENTRY alGetListeneriv( ALenum param, ALint* values );

        /* Source
         * Sources represent individual sound objects in 3D-space.
         * Sources take the PCM buffer provided in the specified Buffer,
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

        /// <summary>This function generates one or more sources.</summary>
        /// <param name="n">The number of sources to be generated.</param>
        /// <param name="sources">Pointer to an array of int values which will store the names of the new sources.</param>
        [DllImport(Lib, EntryPoint = "alGenSources", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void GenSources(int n, [In] int* sources);
        // AL_API void AL_APIENTRY alGenSources( ALsizei n, ALuint* Sources );

        /// <summary>This function generates one or more sources.</summary>
        /// <param name="n">The number of sources to be generated.</param>
        /// <param name="sources">Pointer to an array of int values which will store the names of the new sources.</param>
        [DllImport(Lib, EntryPoint = "alGenSources", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GenSources(int n, ref int sources);
        // AL_API void AL_APIENTRY alGenSources( ALsizei n, ALuint* Sources );

        /// <summary>This function generates one or more sources.</summary>
        /// <param name="n">The number of sources to be generated.</param>
        /// <param name="sources">Pointer to an array of int values which will store the names of the new sources.</param>
        [DllImport(Lib, EntryPoint = "alGenSources", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GenSources(int n, int[] sources);
        // AL_API void AL_APIENTRY alGenSources( ALsizei n, ALuint* Sources );

        /// <summary>This function generates one or more sources.</summary>
        /// <param name="sources">Pointer to an array of int values which will store the names of the new sources.</param>
        public static void GenSources(int[] sources)
        {
            if (sources == null)
            {
                throw new ArgumentNullException(nameof(sources));
            }
            GenSources(sources.Length, sources);
        }

        /// <summary>This function generates one or more sources.</summary>
        /// <param name="sources">Span of int values which will store the names of the new sources.</param>
        public static void GenSources(Span<int> sources)
        {
            GenSources(sources.Length, ref sources[0]);
        }

        /// <summary>This function generates one or more sources.</summary>
        /// <param name="n">The number of sources to be generated.</param>
        /// <returns>Pointer to an array of int values which will store the names of the new sources.</returns>
        public static int[] GenSources(int n)
        {
            int[] sources = new int[n];
            GenSources(n, sources);
            return sources;
        }

        /// <summary>This function generates one source only.</summary>
        /// <returns>Pointer to an int value which will store the name of the new source.</returns>
        public static int GenSource()
        {
            int source = 0;
            GenSources(1, ref source);
            return source;
        }

        /// <summary>This function generates one source only.</summary>
        /// <param name="source">Pointer to an int value which will store the name of the new source.</param>
        public static void GenSource(out int source)
        {
            int newSource = 0;
            GenSources(1, ref newSource);
            source = newSource;
        }

        /// <summary>This function deletes one or more sources.</summary>
        /// <param name="n">The number of sources to be deleted.</param>
        /// <param name="sources">Pointer to an array of source names identifying the sources to be deleted.</param>
        [DllImport(Lib, EntryPoint = "alDeleteSources", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void DeleteSources(int n, [In] int* sources);
        // AL_API void AL_APIENTRY alDeleteSources( ALsizei n, const ALuint* Sources );

        /// <summary>This function deletes one or more sources.</summary>
        /// <param name="n">The number of sources to be deleted.</param>
        /// <param name="sources">Reference to a single source, or an array of source names identifying the sources to be deleted.</param>
        [DllImport(Lib, EntryPoint = "alDeleteSources", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void DeleteSources(int n, ref int sources);

        /// <summary>This function deletes one or more sources.</summary>
        /// <param name="sources">An array of source names identifying the sources to be deleted.</param>
        public static void DeleteSources(int[] sources)
        {
            if (sources == null)
            {
                throw new ArgumentNullException(nameof(sources));
            }
            DeleteBuffers(sources.Length, ref sources[0]);
        }

        /// <summary>This function deletes one or more sources.</summary>
        /// <param name="sources">An array of source names identifying the sources to be deleted.</param>
        public static void DeleteSources(Span<int> sources)
        {
            DeleteBuffers(sources.Length, ref sources[0]);
        }

        /// <summary>This function deletes one source only.</summary>
        /// <param name="source">Pointer to a source name identifying the source to be deleted.</param>
        public static void DeleteSource(int source)
        {
            DeleteSources(1, ref source);
        }

        /// <summary>This function tests if a source name is valid, returning True if valid and False if not.</summary>
        /// <param name="sid">A source name to be tested for validity.</param>
        /// <returns>Success.</returns>
        [DllImport(Lib, EntryPoint = "alIsSource", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern bool IsSource(int sid);
        // AL_API ALboolean AL_APIENTRY alIsSource( ALuint sid );

        /// <summary>This function sets a floating-point property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: ALSourcef.Pitch, Gain, MinGain, MaxGain, MaxDistance, RolloffFactor, ConeOuterGain, ConeInnerAngle, ConeOuterAngle, SecOffset, ReferenceDistance, EfxAirAbsorptionFactor, EfxRoomRolloffFactor, EfxConeOuterGainHighFrequency.</param>
        /// <param name="value">The value to set the attribute to.</param>
        [DllImport(Lib, EntryPoint = "alSourcef", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Source(int sid, ALSourcef param, float value);
        // AL_API void AL_APIENTRY alSourcef( ALuint sid, ALenum param, ALfloat value );

        /// <summary>This function sets a source property requiring three floating-point values.</summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: ALSource3f.Position, Velocity, Direction.</param>
        /// <param name="value1">The first ALfloat value which the attribute will be set to.</param>
        /// <param name="value2">The second ALfloat value which the attribute will be set to.</param>
        /// <param name="value3">The third ALfloat value which the attribute will be set to.</param>
        [DllImport(Lib, EntryPoint = "alSource3f", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Source(int sid, ALSource3f param, float value1, float value2, float value3);
        // AL_API void AL_APIENTRY alSource3f( ALuint sid, ALenum param, ALfloat value1, ALfloat value2, ALfloat value3 );

        /// <summary>This function sets a source property requiring three floating-point values.</summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: ALSource3f.Position, Velocity, Direction.</param>
        /// <param name="values">A Math.Vector3 which the attribute will be set to.</param>
        public static void Source(int sid, ALSource3f param, ref Vector3 values)
        {
            Source(sid, param, values.X, values.Y, values.Z);
        }

        /// <summary>This function sets an integer property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: ALSourcei.SourceRelative, ConeInnerAngle, ConeOuterAngle, Looping, Buffer, SourceState.</param>
        /// <param name="value">The value to set the attribute to.</param>
        [DllImport(Lib, EntryPoint = "alSourcei", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Source(int sid, ALSourcei param, int value);
        // AL_API void AL_APIENTRY alSourcei( ALuint sid, ALenum param, ALint value );

        /// <summary>This function sets an bool property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: ALSourceb.SourceRelative, Looping.</param>
        /// <param name="value">The value to set the attribute to.</param>
        [DllImport(Lib, EntryPoint = "alSourcei", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Source(int sid, ALSourceb param, bool value);
        // FIXME: Double check that the mashaling here works!!

        /// <summary>(Helper) Binds a Buffer to a Source handle.</summary>
        /// <param name="source">Source name to attach the Buffer to.</param>
        /// <param name="buffer">Buffer name which is attached to the Source.</param>
        public static void BindBufferToSource(int source, int buffer)
        {
            Source(source, ALSourcei.Buffer, buffer);
        }

        /// <summary>This function sets 3 integer properties of a source.</summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: EfxAuxiliarySendFilter..</param>
        /// <param name="value1">The first value to set the attribute to.</param>
        /// <param name="value2">The second value to set the attribute to.</param>
        /// <param name="value3">The third value to set the attribute to.</param>
        [DllImport(Lib, EntryPoint = "alSource3i", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void Source(int sid, ALSource3i param, int value1, int value2, int value3);
        // AL_API void AL_APIENTRY alSource3i( ALuint sid, ALenum param, ALint value1, ALint value2, ALint value3 );

        // Not used by any Enum:
        // AL_API void AL_APIENTRY alSourcefv( ALuint sid, ALenum param, const ALfloat* values );
        // AL_API void AL_APIENTRY alSourceiv( ALuint sid, ALenum param, const ALint* values );

        /// <summary>This function retrieves a floating-point property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute to set: ALSourcef.Pitch, Gain, MinGain, MaxGain, MaxDistance, RolloffFactor, ConeOuterGain, ConeInnerAngle, ConeOuterAngle, SecOffset, ReferenceDistance, EfxAirAbsorptionFactor, EfxRoomRolloffFactor, EfxConeOuterGainHighFrequency.</param>
        /// <param name="value">A pointer to the floating-point value being retrieved.</param>
        [DllImport(Lib, EntryPoint = "alGetSourcef", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GetSource(int sid, ALSourcef param, out float value);

        /// <summary>This function retrieves three floating-point values representing a property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute being retrieved: ALSource3f.Position, Velocity, Direction.</param>
        /// <param name="value1">Pointer to the first value to retrieve.</param>
        /// <param name="value2">Pointer to the second value to retrieve.</param>
        /// <param name="value3">Pointer to the third value to retrieve.</param>
        [DllImport(Lib, EntryPoint = "alGetSource3f", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GetSource(int sid, ALSource3f param, out float value1, out float value2, out float value3);
        // AL_API void AL_APIENTRY alGetSource3f( ALuint sid, ALenum param, ALfloat* value1, ALfloat* value2, ALfloat* value3);

        /// <summary>This function retrieves three floating-point values representing a property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute being retrieved: ALSource3f.Position, Velocity, Direction.</param>
        /// <param name="values">A Math.Vector3 to retrieve the values to.</param>
        public static void GetSource(int sid, ALSource3f param, out Vector3 values)
        {
            GetSource(sid, param, out values.X, out values.Y, out values.Z);
        }

        /// <summary>This function retrieves three integer-point values representing a property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute being retrieved: ALSource3f.Position, Velocity, Direction.</param>
        /// <param name="value1">Pointer to the first value to retrieve.</param>
        /// <param name="value2">Pointer to the second value to retrieve.</param>
        /// <param name="value3">Pointer to the third value to retrieve.</param>
        [DllImport(Lib, EntryPoint = "alGetSource3i", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GetSource(int sid, ALSource3i param, out int value1, out int value2, out int value3);
        // AL_API void AL_APIENTRY alGetSource3i( ALuint sid, ALenum param, ALint* value1, ALint* value2, ALint* value3);

        /// <summary>This function retrieves three integer-point values representing a property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute being retrieved: ALSource3f.Position, Velocity, Direction.</param>
        /// <param name="values">A Math.Vector3i to retrieve the values to.</param>
        public static void GetSource(int sid, ALSource3i param, out Vector3i values)
        {
            GetSource(sid, param, out values.X, out values.Y, out values.Z);
        }
        // AL_API void AL_APIENTRY alGetSource3i( ALuint sid, ALenum param, ALint* value1, ALint* value2, ALint* value3);

        /// <summary>This function retrieves an integer property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute to retrieve: ALSourcei.SourceRelative, Buffer, SourceState, BuffersQueued, BuffersProcessed.</param>
        /// <param name="value">A pointer to the integer value being retrieved.</param>
        [DllImport(Lib, EntryPoint = "alGetSourcei", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GetSource(int sid, ALGetSourcei param, [Out] out int value);
        // AL_API void AL_APIENTRY alGetSourcei( ALuint sid,  ALenum param, ALint* value );

        /// <summary>This function retrieves a bool property of a source.</summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute to get: ALSourceb.SourceRelative, Looping.</param>
        /// <param name="value">A pointer to the bool value being retrieved.</param>
        public static void GetSource(int sid, ALSourceb param, out bool value)
        {
            GetSource(sid, (ALGetSourcei)param, out int result);
            value = result != 0;
        }

        // Not used by any Enum:
        // AL_API void AL_APIENTRY alGetSource3i( ALuint sid, ALenum param, ALint* value1, ALint* value2, ALint* value3);
        // AL_API void AL_APIENTRY alGetSourcefv( ALuint sid, ALenum param, ALfloat* values );
        // AL_API void AL_APIENTRY alGetSourceiv( ALuint sid,  ALenum param, ALint* values );

        /// <summary>This function plays a set of sources. The playing sources will have their state changed to ALSourceState.Playing. When called on a source which is already playing, the source will restart at the beginning. When the attached buffer(s) are done playing, the source will progress to the ALSourceState.Stopped state.</summary>
        /// <param name="ns">The number of sources to be played.</param>
        /// <param name="sids">A pointer to an array of sources to be played.</param>
        [DllImport(Lib, EntryPoint = "alSourcePlayv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void SourcePlay(int ns, [In] int* sids);
        // AL_API void AL_APIENTRY alSourcePlayv( ALsizei ns, const ALuint *sids );

        /// <summary>This function plays a set of sources. The playing sources will have their state changed to ALSourceState.Playing. When called on a source which is already playing, the source will restart at the beginning. When the attached buffer(s) are done playing, the source will progress to the ALSourceState.Stopped state.</summary>
        /// <param name="ns">The number of sources to be played.</param>
        /// <param name="sids">A pointer to an array of sources to be played.</param>
        [DllImport(Lib, EntryPoint = "alSourcePlayv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourcePlay(int ns, [In] ref int sids);
        // AL_API void AL_APIENTRY alSourcePlayv( ALsizei ns, const ALuint *sids );

        /// <summary>This function plays a set of sources. The playing sources will have their state changed to ALSourceState.Playing. When called on a source which is already playing, the source will restart at the beginning. When the attached buffer(s) are done playing, the source will progress to the ALSourceState.Stopped state.</summary>
        /// <param name="ns">The number of sources to be played.</param>
        /// <param name="sids">A pointer to an array of sources to be played.</param>
        [DllImport(Lib, EntryPoint = "alSourcePlayv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourcePlay(int ns, [In] int[] sids);
        // AL_API void AL_APIENTRY alSourcePlayv( ALsizei ns, const ALuint *sids );

        /// <summary>This function plays a set of sources. The playing sources will have their state changed to ALSourceState.Playing. When called on a source which is already playing, the source will restart at the beginning. When the attached buffer(s) are done playing, the source will progress to the ALSourceState.Stopped state.</summary>
        /// <param name="sources">The sources to be played.</param>
        public static void SourcePlay(Span<int> sources)
        {
            SourcePlay(sources.Length, ref sources[0]);
        }

        /// <summary>This function stops a set of sources. The stopped sources will have their state changed to ALSourceState.Stopped.</summary>
        /// <param name="ns">The number of sources to stop.</param>
        /// <param name="sids">A pointer to an array of sources to be stopped.</param>
        [DllImport(Lib, EntryPoint = "alSourceStopv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void SourceStop(int ns, [In] int* sids);
        // AL_API void AL_APIENTRY alSourceStopv( ALsizei ns, const ALuint *sids );

        /// <summary>This function stops a set of sources. The stopped sources will have their state changed to ALSourceState.Stopped.</summary>
        /// <param name="ns">The number of sources to stop.</param>
        /// <param name="sids">A pointer to an array of sources to be stopped.</param>
        [DllImport(Lib, EntryPoint = "alSourceStopv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourceStop(int ns, ref int sids);
        // AL_API void AL_APIENTRY alSourceStopv( ALsizei ns, const ALuint *sids );

        /// <summary>This function stops a set of sources. The stopped sources will have their state changed to ALSourceState.Stopped.</summary>
        /// <param name="ns">The number of sources to stop.</param>
        /// <param name="sids">A pointer to an array of sources to be stopped.</param>
        [DllImport(Lib, EntryPoint = "alSourceStopv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourceStop(int ns, int[] sids);
        // AL_API void AL_APIENTRY alSourceStopv( ALsizei ns, const ALuint *sids );

        /// <summary>This function stops a set of sources. The stopped sources will have their state changed to ALSourceState.Stopped.</summary>
        /// <param name="sources">The sources to be stopped.</param>
        public static void SourceStop(Span<int> sources)
        {
            SourceStop(sources.Length, ref sources[0]);
        }

        /// <summary>This function stops a set of sources and sets all their states to ALSourceState.Initial.</summary>
        /// <param name="ns">The number of sources to be rewound.</param>
        /// <param name="sids">A pointer to an array of sources to be rewound.</param>
        [DllImport(Lib, EntryPoint = "alSourceRewindv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void SourceRewind(int ns, [In] int* sids);
        // AL_API void AL_APIENTRY alSourceRewindv( ALsizei ns, const ALuint *sids );

        /// <summary>This function stops a set of sources and sets all their states to ALSourceState.Initial.</summary>
        /// <param name="ns">The number of sources to be rewound.</param>
        /// <param name="sids">A pointer to an array of sources to be rewound.</param>
        [DllImport(Lib, EntryPoint = "alSourceRewindv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourceRewind(int ns, ref int sids);
        // AL_API void AL_APIENTRY alSourceRewindv( ALsizei ns, const ALuint *sids );

        /// <summary>This function stops a set of sources and sets all their states to ALSourceState.Initial.</summary>
        /// <param name="ns">The number of sources to be rewound.</param>
        /// <param name="sids">A pointer to an array of sources to be rewound.</param>
        [DllImport(Lib, EntryPoint = "alSourceRewindv", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourceRewind(int ns, int[] sids);
        // AL_API void AL_APIENTRY alSourceRewindv( ALsizei ns, const ALuint *sids );

        /// <summary>This function stops a set of sources and sets all their states to ALSourceState.Initial.</summary>
        /// <param name="sources">The sources to be rewound.</param>
        public static void SourceRewind(Span<int> sources)
        {
            SourceRewind(sources.Length, ref sources[0]);
        }

        /// <summary>This function pauses a set of sources. The paused sources will have their state changed to ALSourceState.Paused.</summary>
        /// <param name="ns">The number of sources to be paused.</param>
        /// <param name="sids">A pointer to an array of sources to be paused.</param>
        [DllImport(Lib, EntryPoint = "alSourcePausev", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void SourcePause(int ns, [In] int* sids);
        // AL_API void AL_APIENTRY alSourcePausev( ALsizei ns, const ALuint *sids );

        /// <summary>This function pauses a set of sources. The paused sources will have their state changed to ALSourceState.Paused.</summary>
        /// <param name="ns">The number of sources to be paused.</param>
        /// <param name="sids">A pointer to an array of sources to be paused.</param>
        [DllImport(Lib, EntryPoint = "alSourcePausev", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourcePause(int ns, ref int sids);
        // AL_API void AL_APIENTRY alSourcePausev( ALsizei ns, const ALuint *sids );

        /// <summary>This function pauses a set of sources. The paused sources will have their state changed to ALSourceState.Paused.</summary>
        /// <param name="ns">The number of sources to be paused.</param>
        /// <param name="sids">A pointer to an array of sources to be paused.</param>
        [DllImport(Lib, EntryPoint = "alSourcePausev", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourcePause(int ns, int[] sids);
        // AL_API void AL_APIENTRY alSourcePausev( ALsizei ns, const ALuint *sids );

        /// <summary>This function plays, replays or resumes a source. The playing source will have it's state changed to ALSourceState.Playing. When called on a source which is already playing, the source will restart at the beginning. When the attached buffer(s) are done playing, the source will progress to the ALSourceState.Stopped state.</summary>
        /// <param name="sid">The name of the source to be played.</param>
        [DllImport(Lib, EntryPoint = "alSourcePlay", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourcePlay(int sid);
        // AL_API void AL_APIENTRY alSourcePlay( ALuint sid );

        /// <summary>This function stops a source. The stopped source will have it's state changed to ALSourceState.Stopped.</summary>
        /// <param name="sid">The name of the source to be stopped.</param>
        [DllImport(Lib, EntryPoint = "alSourceStop", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourceStop(int sid);
        // AL_API void AL_APIENTRY alSourceStop( ALuint sid );

        /// <summary>This function stops the source and sets its state to ALSourceState.Initial.</summary>
        /// <param name="sid">The name of the source to be rewound.</param>
        [DllImport(Lib, EntryPoint = "alSourceRewind", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourceRewind(int sid);
        // AL_API void AL_APIENTRY alSourceRewind( ALuint sid );

        /// <summary>This function pauses a source. The paused source will have its state changed to ALSourceState.Paused.</summary>
        /// <param name="sid">The name of the source to be paused.</param>
        [DllImport(Lib, EntryPoint = "alSourcePause", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourcePause(int sid);
        // AL_API void AL_APIENTRY alSourcePause( ALuint sid );

        /// <summary>This function queues a set of buffers on a source. All buffers attached to a source will be played in sequence, and the number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed. When first created, a source will be of type ALSourceType.Undetermined. A successful AL.SourceQueueBuffers call will change the source type to ALSourceType.Streaming.</summary>
        /// <param name="sid">The name of the source to queue buffers onto.</param>
        /// <param name="numEntries">The number of buffers to be queued.</param>
        /// <param name="bids">A pointer to an array of buffer names to be queued.</param>
        [DllImport(Lib, EntryPoint = "alSourceQueueBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void SourceQueueBuffers(int sid, int numEntries, [In] int* bids);
        // AL_API void AL_APIENTRY alSourceQueueBuffers( ALuint sid, ALsizei numEntries, const ALuint *bids );

        /// <summary>This function queues a set of buffers on a source. All buffers attached to a source will be played in sequence, and the number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed. When first created, a source will be of type ALSourceType.Undetermined. A successful AL.SourceQueueBuffers call will change the source type to ALSourceType.Streaming.</summary>
        /// <param name="sid">The name of the source to queue buffers onto.</param>
        /// <param name="numEntries">The number of buffers to be queued.</param>
        /// <param name="bids">A pointer to an array of buffer names to be queued.</param>
        [DllImport(Lib, EntryPoint = "alSourceQueueBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourceQueueBuffers(int sid, int numEntries, int[] bids);
        // AL_API void AL_APIENTRY alSourceQueueBuffers( ALuint sid, ALsizei numEntries, const ALuint *bids );

        /// <summary>This function queues a set of buffers on a source. All buffers attached to a source will be played in sequence, and the number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed. When first created, a source will be of type ALSourceType.Undetermined. A successful AL.SourceQueueBuffers call will change the source type to ALSourceType.Streaming.</summary>
        /// <param name="sid">The name of the source to queue buffers onto.</param>
        /// <param name="numEntries">The number of buffers to be queued.</param>
        /// <param name="bids">A pointer to an array of buffer names to be queued.</param>
        [DllImport(Lib, EntryPoint = "alSourceQueueBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourceQueueBuffers(int sid, int numEntries, ref int bids);
        // AL_API void AL_APIENTRY alSourceQueueBuffers( ALuint sid, ALsizei numEntries, const ALuint *bids );

        /// <summary>This function queues a set of buffers on a source. All buffers attached to a source will be played in sequence, and the number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed. When first created, a source will be of type ALSourceType.Undetermined. A successful AL.SourceQueueBuffers call will change the source type to ALSourceType.Streaming.</summary>
        /// <param name="sid">The name of the source to queue buffers onto.</param>
        /// <param name="buffers">A pointer to an array of buffer names to be queued.</param>
        public static void SourceQueueBuffers(int sid, Span<int> buffers)
        {
            SourceQueueBuffers(sid, buffers.Length, ref buffers[0]);
        }

        /// <summary>This function queues a set of buffers on a source. All buffers attached to a source will be played in sequence, and the number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed. When first created, a source will be of type ALSourceType.Undetermined. A successful AL.SourceQueueBuffers call will change the source type to ALSourceType.Streaming.</summary>
        /// <param name="source">The name of the source to queue buffers onto.</param>
        /// <param name="buffer">The name of the buffer to be queued.</param>
        public static void SourceQueueBuffer(int source, int buffer)
        {
            SourceQueueBuffers(source, 1, ref buffer);
        }

        /// <summary>This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed, which is the maximum number of buffers that can be unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the queue.</summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <param name="bids">A pointer to an array of buffer names that were removed.</param>
        [DllImport(Lib, EntryPoint = "alSourceUnqueueBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void SourceUnqueueBuffers(int sid, int numEntries, int* bids);
        // AL_API void AL_APIENTRY alSourceUnqueueBuffers( ALuint sid, ALsizei numEntries, ALuint *bids );

        /// <summary>This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed, which is the maximum number of buffers that can be unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the queue.</summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <param name="bids">A pointer to an array of buffer names that were removed.</param>
        [DllImport(Lib, EntryPoint = "alSourceUnqueueBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourceUnqueueBuffers(int sid, int numEntries, int[] bids);

        /// <summary>This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed, which is the maximum number of buffers that can be unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the queue.</summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <param name="bids">A pointer to an array of buffer names that were removed.</param>
        [DllImport(Lib, EntryPoint = "alSourceUnqueueBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SourceUnqueueBuffers(int sid, int numEntries, ref int bids);

        /// <summary>This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed, which is the maximum number of buffers that can be unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the queue.</summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="bids">Array to fill with buffer names that were removed.</param>
        public static void SourceUnqueueBuffers(int sid, int[] bids)
        {
            SourceUnqueueBuffers(sid, bids.Length, bids);
        }

        /// <summary>This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed, which is the maximum number of buffers that can be unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the queue.</summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="bids">Span to fill with buffer names that were removed.</param>
        public static void SourceUnqueueBuffers(int sid, Span<int> bids)
        {
            SourceUnqueueBuffers(sid, bids.Length, ref bids[0]);
        }

        /// <summary>This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed, which is the maximum number of buffers that can be unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the queue.</summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <returns>The unqueued buffer.</returns>
        public static int SourceUnqueueBuffer(int sid)
        {
            int buffer = 0;
            SourceUnqueueBuffers(sid, 1, ref buffer);
            return buffer;
        }

        /// <summary>This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected using AL.GetSource with parameter ALGetSourcei.BuffersProcessed, which is the maximum number of buffers that can be unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the queue.</summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <returns>The unqueued buffers.</returns>
        public static int[] SourceUnqueueBuffers(int sid, int numEntries)
        {
            if (numEntries <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numEntries), "Must be greater than zero.");
            }
            int[] buf = new int[numEntries];
            SourceUnqueueBuffers(sid, numEntries, buf);
            return buf;
        }

        /*
         * Buffer
         * Buffer objects are storage space for sample buffer.
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

        /// <summary>This function generates one or more buffers, which contain audio buffer (see AL.BufferData). References to buffers are uint values, which are used wherever a buffer reference is needed (in calls such as AL.DeleteBuffers, AL.Source with parameter ALSourcei, AL.SourceQueueBuffers, and AL.SourceUnqueueBuffers).</summary>
        /// <param name="n">The number of buffers to be generated.</param>
        /// <param name="buffers">Pointer to an array of uint values which will store the names of the new buffers.</param>
        [DllImport(Lib, EntryPoint = "alGenBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void GenBuffers(int n, [Out] int* buffers);
        // AL_API void AL_APIENTRY alGenBuffers( ALsizei n, ALuint* Buffers );

        /// <summary>This function generates one or more buffers, which contain audio buffer (see AL.BufferData).</summary>
        /// <param name="n">The number of buffers to be generated.</param>
        /// <param name="buffers">Pointer to an array of int values which will store the names of the new buffers.</param>
        [DllImport(Lib, EntryPoint = "alGenBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GenBuffers(int n, ref int buffers);
        // AL_API void AL_APIENTRY alGenBuffers( ALsizei n, ALuint* Buffers );

        /// <summary>This function generates one or more buffers, which contain audio buffer (see AL.BufferData).</summary>
        /// <param name="n">The number of buffers to be generated.</param>
        /// <param name="buffers">Pointer to an array of int values which will store the names of the new buffers.</param>
        [DllImport(Lib, EntryPoint = "alGenBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GenBuffers(int n, [Out] int[] buffers);
        // AL_API void AL_APIENTRY alGenBuffers( ALsizei n, ALuint* Buffers );

        /// <summary>This function generates one or more buffers, which contain audio buffer (see AL.BufferData).</summary>
        /// <param name="buffers">Span to fill with generated buffer names.</param>
        public static void GenBuffers(Span<int> buffers)
        {
            GenBuffers(buffers.Length, ref buffers[0]);
        }

        /// <summary>This function generates one or more buffers, which contain audio data (see AL.BufferData). References to buffers are uint values, which are used wherever a buffer reference is needed (in calls such as AL.DeleteBuffers, AL.Source with parameter ALSourcei, AL.SourceQueueBuffers, and AL.SourceUnqueueBuffers).</summary>
        /// <param name="n">The number of buffers to be generated.</param>
        /// <returns>Pointer to an array of uint values which will store the names of the new buffers.</returns>
        public static int[] GenBuffers(int n)
        {
            int[] buffers = new int[n];
            GenBuffers(buffers.Length, buffers);
            return buffers;
        }

        /// <summary>This function generates one buffer only, which contain audio data (see AL.BufferData). References to buffers are uint values, which are used wherever a buffer reference is needed (in calls such as AL.DeleteBuffers, AL.Source with parameter ALSourcei, AL.SourceQueueBuffers, and AL.SourceUnqueueBuffers).</summary>
        /// <returns>Pointer to an uint value which will store the name of the new buffer.</returns>
        public static int GenBuffer()
        {
            int buffer = 0;
            GenBuffers(1, ref buffer);
            return buffer;
        }

        /// <summary>This function generates one buffer only, which contain audio data (see AL.BufferData). References to buffers are uint values, which are used wherever a buffer reference is needed (in calls such as AL.DeleteBuffers, AL.Source with parameter ALSourcei, AL.SourceQueueBuffers, and AL.SourceUnqueueBuffers).</summary>
        /// <param name="buffer">Pointer to an uint value which will store the names of the new buffer.</param>
        public static void GenBuffer(out int buffer)
        {
            int newBuffer = 0;
            GenBuffers(1, ref newBuffer);
            buffer = newBuffer;
        }

        /// <summary>This function deletes one or more buffers, freeing the resources used by the buffer. Buffers which are attached to a source can not be deleted. See AL.Source (ALSourcei) and AL.SourceUnqueueBuffers for information on how to detach a buffer from a source.</summary>
        /// <param name="n">The number of buffers to be deleted.</param>
        /// <param name="buffers">Pointer to an array of buffer names identifying the buffers to be deleted.</param>
        [DllImport(Lib, EntryPoint = "alDeleteBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void DeleteBuffers(int n, [In] int* buffers);
        // AL_API void AL_APIENTRY alDeleteBuffers( ALsizei n, const ALuint* Buffers );

        /// <summary>This function deletes one or more buffers, freeing the resources used by the buffer. Buffers which are attached to a source can not be deleted. See AL.Source (ALSourcei) and AL.SourceUnqueueBuffers for information on how to detach a buffer from a source.</summary>
        /// <param name="n">The number of buffers to be deleted.</param>
        /// <param name="buffers">Pointer to an array of buffer names identifying the buffers to be deleted.</param>
        [DllImport(Lib, EntryPoint = "alDeleteBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void DeleteBuffers(int n, [In] ref int buffers);
        // AL_API void AL_APIENTRY alDeleteBuffers( ALsizei n, const ALuint* Buffers );

        /// <summary>This function deletes one or more buffers, freeing the resources used by the buffer. Buffers which are attached to a source can not be deleted. See AL.Source (ALSourcei) and AL.SourceUnqueueBuffers for information on how to detach a buffer from a source.</summary>
        /// <param name="n">The number of buffers to be deleted.</param>
        /// <param name="buffers">Pointer to an array of buffer names identifying the buffers to be deleted.</param>
        [DllImport(Lib, EntryPoint = "alDeleteBuffers", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void DeleteBuffers(int n, [In] int[] buffers);
        // AL_API void AL_APIENTRY alDeleteBuffers( ALsizei n, const ALuint* Buffers );

        /// <summary>This function deletes an array of buffers, freeing the resources used by the buffer. Buffers which are attached to a source can not be deleted. See AL.Source (ALSourcei) and AL.SourceUnqueueBuffers for information on how to detach a buffer from a source.</summary>
        /// <param name="buffers">An array of buffer names to delete.</param>
        public static void DeleteBuffers(int[] buffers)
        {
            if (buffers == null)
            {
                throw new ArgumentNullException(nameof(buffers));
            }
            DeleteBuffers(buffers.Length, buffers);
        }

        /// <summary>This function deletes a span of buffers, freeing the resources used by the buffer. Buffers which are attached to a source can not be deleted. See AL.Source (ALSourcei) and AL.SourceUnqueueBuffers for information on how to detach a buffer from a source.</summary>
        /// <param name="buffers">Span of buffer names to delete.</param>
        public static void DeleteBuffers(Span<int> buffers)
        {
            DeleteBuffers(buffers.Length, ref buffers[0]);
        }

        /// <summary>This function deletes one buffer only, freeing the resources used by the buffer. Buffers which are attached to a source can not be deleted. See AL.Source (ALSourcei) and AL.SourceUnqueueBuffers for information on how to detach a buffer from a source.</summary>
        /// <param name="buffer">Pointer to a buffer name identifying the buffer to be deleted.</param>
        public static void DeleteBuffer(int buffer)
        {
            DeleteBuffers(1, ref buffer);
        }

        /// <summary>This function tests if a buffer name is valid, returning True if valid, False if not.</summary>
        /// <param name="bid">A buffer Handle previously allocated with <see cref="GenBuffers(int)"/>.</param>
        /// <returns>Success.</returns>
        [DllImport(Lib, EntryPoint = "alIsBuffer", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern bool IsBuffer(int bid);
        // AL_API ALboolean AL_APIENTRY alIsBuffer( ALuint bid );

        /// <summary>This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function may be used by extensions to load other buffer types as well.</summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">Format type from among the following: ALFormat.Mono8, ALFormat.Mono16, ALFormat.Stereo8, ALFormat.Stereo16.</param>
        /// <param name="buffer">Pointer to a pinned audio buffer.</param>
        /// <param name="size">The size of the audio buffer in bytes.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        [DllImport(Lib, EntryPoint = "alBufferData", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void BufferData(int bid, ALFormat format, IntPtr buffer, int size, int freq);
        // AL_API void AL_APIENTRY alBufferData( ALuint bid, ALenum format, const ALvoid* buffer, ALsizei size, ALsizei freq );

        /// <summary>This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function may be used by extensions to load other buffer types as well.</summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">Format type from among the following: ALFormat.Mono8, ALFormat.Mono16, ALFormat.Stereo8, ALFormat.Stereo16.</param>
        /// <param name="buffer">Pointer to a pinned audio buffer.</param>
        /// <param name="size">The size of the audio buffer in bytes.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        [DllImport(Lib, EntryPoint = "alBufferData", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static unsafe extern void BufferData(int bid, ALFormat format, void* buffer, int size, int freq);
        // AL_API void AL_APIENTRY alBufferData( ALuint bid, ALenum format, const ALvoid* buffer, ALsizei size, ALsizei freq );

        /// <summary>This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function may be used by extensions to load other buffer types as well.</summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">Format type from among the following: ALFormat.Mono8, ALFormat.Mono16, ALFormat.Stereo8, ALFormat.Stereo16.</param>
        /// <param name="buffer">Pointer to a pinned audio buffer.</param>
        /// <param name="size">The size of the audio buffer in bytes.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        [DllImport(Lib, EntryPoint = "alBufferData", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void BufferData(int bid, ALFormat format, ref byte buffer, int size, int freq);
        // AL_API void AL_APIENTRY alBufferData( ALuint bid, ALenum format, const ALvoid* buffer, ALsizei size, ALsizei freq );

        /// <summary>This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function may be used by extensions to load other buffer types as well.</summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">Format type from among the following: ALFormat.Mono8, ALFormat.Mono16, ALFormat.Stereo8, ALFormat.Stereo16.</param>
        /// <param name="buffer">Pointer to a pinned audio buffer.</param>
        /// <param name="bytes">The size of the audio buffer in bytes.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        [DllImport(Lib, EntryPoint = "alBufferData", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void BufferData(int bid, ALFormat format, ref short buffer, int bytes, int freq);
        // AL_API void AL_APIENTRY alBufferData( ALuint bid, ALenum format, const ALvoid* buffer, ALsizei size, ALsizei freq );

        /// <summary>This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function may be used by extensions to load other buffer types as well.</summary>
        /// <typeparam name="TBuffer">The type of the data buffer.</typeparam>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">Format type from among the following: ALFormat.Mono8, ALFormat.Mono16, ALFormat.Stereo8, ALFormat.Stereo16.</param>
        /// <param name="buffer">The audio buffer.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        /// FIXME: Should "size" be changed to "elements"?
        public static unsafe void BufferData<TBuffer>(int bid, ALFormat format, TBuffer[] buffer, int freq)
            where TBuffer : unmanaged
        {
            fixed (TBuffer* b = buffer)
            {
                BufferData(bid, format, b, buffer.Length * sizeof(TBuffer), freq);
            }
        }

        /// <summary>This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function may be used by extensions to load other buffer types as well.</summary>
        /// <typeparam name="TBuffer">The type of the buffer elements.</typeparam>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">Format type from among the following: ALFormat.Mono8, ALFormat.Mono16, ALFormat.Stereo8, ALFormat.Stereo16.</param>
        /// <param name="buffer">Span representing the audio buffer.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        public static unsafe void BufferData<TBuffer>(int bid, ALFormat format, Span<TBuffer> buffer, int freq)
            where TBuffer : unmanaged
        {
            fixed (TBuffer* b = buffer)
            {
                BufferData(bid, format, b, buffer.Length * sizeof(TBuffer), freq);
            }
        }

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

        /// <summary>This function retrieves an integer property of a buffer.</summary>
        /// <param name="bid">Buffer name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute to be retrieved: ALGetBufferi.Frequency, Bits, Channels, Size, and the currently hidden AL_DATA (dangerous).</param>
        /// <param name="value">A pointer to an int to hold the retrieved buffer.</param>
        [DllImport(Lib, EntryPoint = "alGetBufferi", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void GetBuffer(int bid, ALGetBufferi param, [Out] out int value);
        // AL_API void AL_APIENTRY alGetBufferi( ALuint bid, ALenum param, ALint* value );

        // AL_API void AL_APIENTRY alGetBufferf( ALuint bid, ALenum param, ALfloat* value );
        // AL_API void AL_APIENTRY alGetBuffer3f( ALuint bid, ALenum param, ALfloat* value1, ALfloat* value2, ALfloat* value3);
        // AL_API void AL_APIENTRY alGetBufferfv( ALuint bid, ALenum param, ALfloat* values );
        // AL_API void AL_APIENTRY alGetBuffer3i( ALuint bid, ALenum param, ALint* value1, ALint* value2, ALint* value3);
        // AL_API void AL_APIENTRY alGetBufferiv( ALuint bid, ALenum param, ALint* values );

        /// <summary>AL.DopplerFactor is a simple scaling of source and listener velocities to exaggerate or deemphasize the Doppler (pitch) shift resulting from the calculation.</summary>
        /// <param name="value">A negative value will result in an error, the command is then ignored. The default value is 1f. The current setting can be queried using AL.Get with parameter ALGetFloat.SpeedOfSound.</param>
        [DllImport(Lib, EntryPoint = "alDopplerFactor", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void DopplerFactor(float value);
        // AL_API void AL_APIENTRY alDopplerFactor( ALfloat value );

        /// <summary>This function is deprecated and should not be used.</summary>
        /// <param name="value">The default is 1.0f.</param>
        [DllImport(Lib, EntryPoint = "alDopplerVelocity", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void DopplerVelocity(float value);
        // AL_API void AL_APIENTRY alDopplerVelocity( ALfloat value );

        /// <summary>AL.SpeedOfSound allows the application to change the reference (propagation) speed used in the Doppler calculation. The source and listener velocities should be expressed in the same units as the speed of sound.</summary>
        /// <param name="value">A negative or zero value will result in an error, and the command is ignored. Default: 343.3f (appropriate for velocity units of meters and air as the propagation medium). The current setting can be queried using AL.Get with parameter ALGetFloat.SpeedOfSound.</param>
        [DllImport(Lib, EntryPoint = "alSpeedOfSound", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void SpeedOfSound(float value);
        // AL_API void AL_APIENTRY alSpeedOfSound( ALfloat value );

        /// <summary>This function selects the OpenAL distance model – ALDistanceModel.InverseDistance, ALDistanceModel.InverseDistanceClamped, ALDistanceModel.LinearDistance, ALDistanceModel.LinearDistanceClamped, ALDistanceModel.ExponentDistance, ALDistanceModel.ExponentDistanceClamped, or ALDistanceModel.None. The default distance model in OpenAL is ALDistanceModel.InverseDistanceClamped.</summary>
        /// <remarks>
        /// The ALDistanceModel .InverseDistance model works according to the following formula:
        /// gain = ALSourcef.ReferenceDistance / (ALSourcef.ReferenceDistance + ALSourcef.RolloffFactor * (distance – ALSourcef.ReferenceDistance));
        ///
        /// The ALDistanceModel .InverseDistanceClamped model works according to the following formula:
        /// distance = max(distance,ALSourcef.ReferenceDistance);
        /// distance = min(distance,ALSourcef.MaxDistance);
        /// gain = ALSourcef.ReferenceDistance / (ALSourcef.ReferenceDistance + ALSourcef.RolloffFactor * (distance – ALSourcef.ReferenceDistance));
        ///
        /// The ALDistanceModel.LinearDistance model works according to the following formula:
        /// distance = min(distance, ALSourcef.MaxDistance) // avoid negative gain
        /// gain = (1 – ALSourcef.RolloffFactor * (distance – ALSourcef.ReferenceDistance) / (ALSourcef.MaxDistance – ALSourcef.ReferenceDistance))
        ///
        /// The ALDistanceModel.LinearDistanceClamped model works according to the following formula:
        /// distance = max(distance, ALSourcef.ReferenceDistance)
        /// distance = min(distance, ALSourcef.MaxDistance)
        /// gain = (1 – ALSourcef.RolloffFactor * (distance – ALSourcef.ReferenceDistance) / (ALSourcef.MaxDistance – ALSourcef.ReferenceDistance))
        ///
        /// The ALDistanceModel.ExponentDistance model works according to the following formula:
        /// gain = (distance / ALSourcef.ReferenceDistance) ^ (- ALSourcef.RolloffFactor)
        ///
        /// The ALDistanceModel.ExponentDistanceClamped model works according to the following formula:
        /// distance = max(distance, ALSourcef.ReferenceDistance)
        /// distance = min(distance, ALSourcef.MaxDistance)
        /// gain = (distance / ALSourcef.ReferenceDistance) ^ (- ALSourcef.RolloffFactor)
        ///
        /// The ALDistanceModel.None model works according to the following formula:
        /// <code>gain = 1f;</code>.
        /// </remarks>
        /// <param name="distancemodel">The distance model to use.</param>
        [DllImport(Lib, EntryPoint = "alDistanceModel", ExactSpelling = true, CallingConvention = ALCallingConvention)]
        public static extern void DistanceModel(ALDistanceModel distancemodel);
        // AL_API void AL_APIENTRY alDistanceModel( ALenum distanceModel );

        /// <summary>
        /// Returns the <see cref="ALDistanceModel"/> of the current context.
        /// </summary>
        /// <returns>The <see cref="ALDistanceModel"/> of the current context.</returns>
        public static ALDistanceModel GetDistanceModel()
        {
            return (ALDistanceModel)Get(ALGetInteger.DistanceModel);
        }

        /// <summary>(Helper) Returns Source state information.</summary>
        /// <param name="sid">The source to be queried.</param>
        /// <returns>state information from OpenAL.</returns>
        public static ALSourceState GetSourceState(int sid)
        {
            GetSource(sid, ALGetSourcei.SourceState, out int state);
            return (ALSourceState)state;
        }

        /// <summary>(Helper) Returns Source type information.</summary>
        /// <param name="sid">The source to be queried.</param>
        /// <returns>type information from OpenAL.</returns>
        public static ALSourceType GetSourceType(int sid)
        {
            GetSource(sid, ALGetSourcei.SourceType, out int temp);
            return (ALSourceType)temp;
        }
    }
}
