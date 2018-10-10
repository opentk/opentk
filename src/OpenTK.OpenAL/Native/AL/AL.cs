/* AlFunctions.cs
 * C header: \OpenAL 1.1 SDK\include\Al.h
 * Spec: http://www.openal.org/openal_webstf/specs/Open<see cref="AL11Specification.pdf"/>
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

using System;
using System.Runtime.InteropServices;
using System.Security;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;

namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// Provides access to the OpenAL 1.1 flat API.
    /// </summary>
    public static class AL
    {
        /// <summary>
        /// The name of the library.
        /// </summary>
        internal const string Library = "openal32.dll";
        private const CallingConvention Style = CallingConvention.Cdecl;

        /// <summary>
        /// This function enables a feature of the OpenAL driver. There are no capabilities defined in OpenAL 1.1 to be
        /// used with this function, but it may be used by an extension.
        /// </summary>
        /// <param name="capability">The name of a capability to enable.</param>
        [DllImport(Library, EntryPoint = "alEnable", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Enable(ALCapability capability);

        /// <summary>
        /// This function disables a feature of the OpenAL driver.
        /// </summary>
        /// <param name="capability">The name of a capability to disable.</param>
        [DllImport(Library, EntryPoint = "alDisable", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Disable(ALCapability capability);

        /// <summary>
        /// This function returns a boolean indicating if a specific feature is enabled in the OpenAL driver.
        /// </summary>
        /// <param name="capability">The name of a capability to enable.</param>
        /// <returns>True if enabled, False if disabled.</returns>
        [DllImport(Library, EntryPoint = "alIsEnabled", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern bool IsEnabled(ALCapability capability);

        [DllImport(Library, EntryPoint = "alGetString", ExactSpelling = true, CallingConvention = Style, CharSet = CharSet.Ansi)]
        [SuppressUnmanagedCodeSecurity]
        private static extern IntPtr GetStringPrivate(ALGetString param);

        /// <summary>
        /// This function retrieves an OpenAL string property.
        /// </summary>
        /// <param name="param">The property to be returned: Vendor, Version, Renderer and Extensions.</param>
        /// <returns>Returns a pointer to a null-terminated string.</returns>
        public static string Get(ALGetString param)
        {
            return Marshal.PtrToStringAnsi(GetStringPrivate(param));
        }

        /// <summary>
        /// This function retrieves an OpenAL string property.
        /// </summary>
        /// <param name="param">The human-readable error string to be returned.</param>
        /// <returns>Returns a pointer to a null-terminated string.</returns>
        public static string GetErrorString(ALError param)
        {
            return Marshal.PtrToStringAnsi(GetStringPrivate((ALGetString)param));
        }

        /// <summary>
        /// This function returns an integer OpenAL state.
        /// </summary>
        /// <param name="param">the state to be queried: DistanceModel.</param>
        /// <returns>The integer state described by param will be returned.</returns>
        [DllImport(Library, EntryPoint = "alGetInteger", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int Get(ALGetInteger param);

        /// <summary>
        /// This function returns a floating-point OpenAL state.
        /// </summary>
        /// <param name="param">the state to be queried: DopplerFactor, SpeedOfSound.</param>
        /// <returns>The floating-point state described by param will be returned.</returns>
        [DllImport(Library, EntryPoint = "alGetFloat", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern float Get(ALGetFloat param);

        /// <summary>
        /// Error support. Obtain the most recent error generated in the AL state machine. When an error is detected by
        /// AL, a flag is set and the error code is recorded. Further errors, if they occur, do not affect this recorded code.
        /// When alGetError is called, the code is returned and the flag is cleared, so that a further error will again record
        /// its code.
        /// </summary>
        /// <returns>
        /// The first error that occured. can be used with <see cref="AL.GetString"/>. Returns an Alenum representing the error state.
        /// When an OpenAL error occurs, the error state is set and will not be changed until the error state is retrieved
        /// using alGetError. Whenever alGetError is called, the error state is cleared and the last state (the current state
        /// when the call was made) is returned. To isolate error detection to a specific portion of code, alGetError should be
        /// called before the isolated section to clear the current error state.
        /// </returns>
        [DllImport(Library, EntryPoint = "alGetError", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern ALError GetError();

        /// <summary>
        /// This function tests if a specific Extension is available for the OpenAL driver.
        /// </summary>
        /// <param name="extname">A string naming the desired extension. Example: "EAX-RAM".</param>
        /// <returns>Returns True if the Extension is available or False if not available.</returns>
        [DllImport(Library, EntryPoint = "alIsExtensionPresent", ExactSpelling = true, CallingConvention = Style, CharSet = CharSet.Ansi)]
        [SuppressUnmanagedCodeSecurity]
        public static extern bool IsExtensionPresent([In] string extname);

        /// <summary>
        /// This function returns the address of an OpenAL extension function. Handle with care.
        /// </summary>
        /// <param name="fname">A string containing the function name.</param>
        /// <returns>
        /// The return value is a pointer to the specified function. The return value will be IntPtr.Zero if the function
        /// is not found.
        /// </returns>
        [DllImport(Library, EntryPoint = "alGetProcAddress", ExactSpelling = true, CallingConvention = Style, CharSet = CharSet.Ansi)]
        [SuppressUnmanagedCodeSecurity]
        public static extern IntPtr GetProcAddress([In] string fname);

        /// <summary>
        /// This function returns the enumeration value of an OpenAL token, described by a string.
        /// </summary>
        /// <param name="ename">A string describing an OpenAL token. Example "AL_DISTANCE_MODEL".</param>
        /// <returns>
        /// Returns the actual ALenum described by a string. Returns 0 if the string doesn’t describe a valid OpenAL
        /// token.
        /// </returns>
        [DllImport(Library, EntryPoint = "alGetEnumValue", ExactSpelling = true, CallingConvention = Style, CharSet = CharSet.Ansi)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int GetEnumValue([In] string ename);

        /// <summary>
        /// This function sets a floating-point property for the listener.
        /// </summary>
        /// <param name="param">The name of the attribute to be set: <see cref="ALListenerf.Gain"/>.</param>
        /// <param name="value">The float value to set the attribute to.</param>
        [DllImport(Library, EntryPoint = "alListenerf", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Listener(ALListenerf param, float value);

        /// <summary>
        /// This function sets a floating-point property for the listener.
        /// </summary>
        /// <param name="param">The name of the attribute to set: <see cref="ALListener3f.Position"/>, <see cref="ALListener3f.Velocity"/>.</param>
        /// <param name="value1">The value to set the first element in the attribute to.</param>
        /// <param name="value2">The value to set the second element in the attribute to.</param>
        /// <param name="value3">The value to set the third element in the attribute to.</param>
        [DllImport(Library, EntryPoint = "alListener3f", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Listener(ALListener3f param, float value1, float value2, float value3);

        /// <summary>
        /// This function sets a Math.Vector3 property for the listener.
        /// </summary>
        /// <param name="param">The name of the attribute to set: <see cref="ALListener3f.Position"/>, <see cref="ALListener3f.Velocity"/>.</param>
        /// <param name="values">The Math.Vector3 to set the attribute to.</param>
        public static void Listener(ALListener3f param, ref Vector3 values)
        {
            Listener(param, values.X, values.Y, values.Z);
        }

        [DllImport(Library, EntryPoint = "alListenerfv", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        private static extern unsafe void ListenerPrivate(ALListenerfv param, float* values);

        /// <summary>
        /// This function sets a floating-point vector property of the listener.
        /// </summary>
        /// <param name="param">
        /// The name of the attribute to be set: <see cref="ALListener3f.Position"/>, <see cref="ALListener3f.Velocity"/>,
        /// <see cref="ALListenerfv.Orientation"/>.
        /// </param>
        /// <param name="values">Pointer to floating-point vector values.</param>
        public static void Listener(ALListenerfv param, ref float[] values)
        {
            unsafe
            {
                fixed (float* ptr = &values[0])
                {
                    ListenerPrivate(param, ptr);
                }
            }
        }

        /// <summary>
        /// This function sets two Math.Vector3 properties of the listener.
        /// </summary>
        /// <param name="param">The name of the attribute to be set: <see cref="ALListenerfv.Orientation"/>.</param>
        /// <param name="at">A Math.Vector3 for the At-Vector.</param>
        /// <param name="up">A Math.Vector3 for the Up-Vector.</param>
        public static void Listener(ALListenerfv param, ref Vector3 at, ref Vector3 up)
        {
            var temp = new float[6];

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

        /// <summary>
        /// This function retrieves a floating-point property of the listener.
        /// </summary>
        /// <param name="param">the name of the attribute to be retrieved: <see cref="ALListenerf.Gain"/>.</param>
        /// <param name="value">a pointer to the floating-point value being retrieved.</param>
        [DllImport(Library, EntryPoint = "alGetListenerf", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void GetListener(ALListenerf param, [Out] out float value);

        /// <summary>
        /// This function retrieves a set of three floating-point values from a property of the listener.
        /// </summary>
        /// <param name="param">The name of the attribute to be retrieved: <see cref="ALListener3f.Position"/>, <see cref="ALListener3f.Velocity"/>.</param>
        /// <param name="value1">The first floating-point value being retrieved.</param>
        /// <param name="value2">The second floating-point value  being retrieved.</param>
        /// <param name="value3">The third floating-point value  being retrieved.</param>
        [DllImport(Library, EntryPoint = "alGetListener3f", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void GetListener(ALListener3f param, [Out] out float value1, [Out] out float value2, [Out] out float value3);

        /// <summary>
        /// This function retrieves a Math.Vector3 from a property of the listener.
        /// </summary>
        /// <param name="param">The name of the attribute to be retrieved: <see cref="ALListener3f.Position"/>, <see cref="ALListener3f.Velocity"/>.</param>
        /// <param name="values">A Math.Vector3 to hold the three floats being retrieved.</param>
        public static void GetListener(ALListener3f param, out Vector3 values)
        {
            GetListener(param, out values.X, out values.Y, out values.Z);
        }

        /// <summary>
        /// This function retrieves a floating-point vector property of the listener. You must pin it manually.
        /// </summary>
        /// <param name="param">
        /// the name of the attribute to be retrieved: <see cref="ALListener3f.Position"/>, <see cref="ALListener3f.Velocity"/>,
        /// <see cref="ALListenerfv.Orientation"/>.
        /// </param>
        /// <param name="values">A pointer to the floating-point vector value being retrieved.</param>
        [DllImport(Library, EntryPoint = "alGetListenerfv", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void GetListener(ALListenerfv param, float* values);

        /// <summary>
        /// This function retrieves two Math.Vector3 properties of the listener.
        /// </summary>
        /// <param name="param">the name of the attribute to be retrieved: <see cref="ALListenerfv.Orientation"/>.</param>
        /// <param name="at">A Math.Vector3 for the At-Vector.</param>
        /// <param name="up">A Math.Vector3 for the Up-Vector.</param>
        public static void GetListener(ALListenerfv param, out Vector3 at, out Vector3 up)
        {
            var pinned = new float[6]; // should lose scope when the function exits
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

        [DllImport(Library, EntryPoint = "alGenSources", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        private static extern unsafe void GenSourcesPrivate(int n, [Out] uint* sources);

        /// <summary>
        /// This function generates one or more sources. References to sources are uint values, which are used wherever a
        /// source reference is needed (in calls such as <see cref="AL.DeleteSources"/> and <see cref="AL.Source"/> with parameter ALSourcei).
        /// </summary>
        /// <param name="n">The number of sources to be generated.</param>
        /// <param name="sources">Pointer to an array of uint values which will store the names of the new sources.</param>
        public static void GenSources(int n, out uint sources)
        {
            unsafe
            {
                fixed (uint* sources_ptr = &sources)
                {
                    GenSourcesPrivate(n, sources_ptr);
                }
            }
        }

        /// <summary>
        /// This function generates one or more sources. References to sources are int values, which are used wherever a
        /// source reference is needed (in calls such as <see cref="AL.DeleteSources"/> and <see cref="AL.Source"/> with parameter ALSourcei).
        /// </summary>
        /// <param name="n">The number of sources to be generated.</param>
        /// <param name="sources">Pointer to an array of int values which will store the names of the new sources.</param>
        public static void GenSources(int n, out int sources)
        {
            unsafe
            {
                fixed (int* sources_ptr = &sources)
                {
                    GenSourcesPrivate(n, (uint*)sources_ptr);
                }
            }
        }

        /// <summary>
        /// This function generates one or more sources. References to sources are int values, which are used wherever a
        /// source reference is needed (in calls such as <see cref="AL.DeleteSources"/> and <see cref="AL.Source"/> with parameter ALSourcei).
        /// </summary>
        /// <param name="sources">Pointer to an array of int values which will store the names of the new sources.</param>
        public static void GenSources(int[] sources)
        {
            var temp = new uint[sources.Length];
            GenSources(temp.Length, out temp[0]);
            for (var i = 0; i < temp.Length; i++)
            {
                sources[i] = (int)temp[i];
            }
        }

        /// <summary>
        /// This function generates one or more sources. References to sources are int values, which are used wherever a
        /// source reference is needed (in calls such as <see cref="AL.DeleteSources"/> and <see cref="AL.Source"/> with parameter ALSourcei).
        /// </summary>
        /// <param name="n">The number of sources to be generated.</param>
        /// <returns>Pointer to an array of int values which will store the names of the new sources.</returns>
        public static int[] GenSources(int n)
        {
            var temp = new uint[n];
            GenSources(temp.Length, out temp[0]);
            var sources = new int[n];
            for (var i = 0; i < temp.Length; i++)
            {
                sources[i] = (int)temp[i];
            }

            return sources;
        }

        /// <summary>
        /// This function generates one source only. References to sources are int values, which are used wherever a
        /// source reference is needed (in calls such as <see cref="AL.DeleteSources"/> and <see cref="AL.Source"/> with parameter ALSourcei).
        /// </summary>
        /// <returns>Pointer to an int value which will store the name of the new source.</returns>
        public static int GenSource()
        {
            GenSources(1, out int temp);
            return temp;
        }

        /// <summary>
        /// This function generates one source only. References to sources are uint values, which are used wherever a
        /// source reference is needed (in calls such as <see cref="AL.DeleteSources"/> and <see cref="AL.Source"/> with parameter ALSourcei).
        /// </summary>
        /// <param name="source">Pointer to an uint value which will store the name of the new source.</param>
        public static void GenSource(out uint source)
        {
            GenSources(1, out source);
        }

        /// <summary>
        /// This function deletes one or more sources.
        /// </summary>
        /// <param name="n">The number of sources to be deleted.</param>
        /// <param name="sources">Pointer to an array of source names identifying the sources to be deleted.</param>
        [DllImport(Library, EntryPoint = "alDeleteSources", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void DeleteSources(int n, [In] uint* sources);

        /// <summary>
        /// This function deletes one or more sources.
        /// </summary>
        /// <param name="n">The number of sources to be deleted.</param>
        /// <param name="sources">Reference to a single source, or an array of source names identifying the sources to be deleted.</param>
        [DllImport(Library, EntryPoint = "alDeleteSources", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void DeleteSources(int n, ref uint sources);

        /// <summary>
        /// This function deletes one or more sources.
        /// </summary>
        /// <param name="n">The number of sources to be deleted.</param>
        /// <param name="sources">Reference to a single source, or an array of source names identifying the sources to be deleted.</param>
        [DllImport(Library, EntryPoint = "alDeleteSources", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void DeleteSources(int n, ref int sources);

        /// <summary>
        /// This function deletes one or more sources.
        /// </summary>
        /// <param name="sources">An array of source names identifying the sources to be deleted.</param>
        public static void DeleteSources(uint[] sources)
        {
            if (sources == null)
            {
                throw new ArgumentNullException();
            }

            if (sources.Length == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            DeleteBuffers(sources.Length, ref sources[0]);
        }

        /// <summary>
        /// This function deletes one or more sources.
        /// </summary>
        /// <param name="sources">An array of source names identifying the sources to be deleted.</param>
        public static void DeleteSources(int[] sources)
        {
            if (sources == null)
            {
                throw new ArgumentNullException();
            }

            if (sources.Length == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            DeleteBuffers(sources.Length, ref sources[0]);
        }

        /// <summary>
        /// This function deletes one source only.
        /// </summary>
        /// <param name="source">Pointer to a source name identifying the source to be deleted.</param>
        public static void DeleteSource(ref uint source)
        {
            DeleteSources(1, ref source);
        }

        /// <summary>
        /// This function deletes one source only.
        /// </summary>
        /// <param name="source">Pointer to a source name identifying the source to be deleted.</param>
        public static void DeleteSource(int source)
        {
            DeleteSources(1, ref source);
        }

        /// <summary>
        /// This function tests if a source name is valid, returning True if valid and False if not.
        /// </summary>
        /// <param name="sid">A source name to be tested for validity.</param>
        /// <returns>Success.</returns>
        [DllImport(Library, EntryPoint = "alIsSource", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern bool IsSource(uint sid);

        /// <summary>
        /// This function tests if a source name is valid, returning True if valid and False if not.
        /// </summary>
        /// <param name="sid">A source name to be tested for validity.</param>
        /// <returns>Success.</returns>
        public static bool IsSource(int sid)
        {
            return IsSource((uint)sid);
        }

        /// <summary>
        /// This function sets a floating-point property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">
        /// The name of the attribute to set: <see cref="ALSourcef.Pitch"/>, Gain, MinGain, MaxGain, MaxDistance,
        /// RolloffFactor, ConeOuterGain, ConeInnerAngle, ConeOuterAngle, ReferenceDistance, EfxAirAbsorptionFactor,
        /// EfxRoomRolloffFactor, EfxConeOuterGainHighFrequency.
        /// </param>
        /// <param name="value">The value to set the attribute to.</param>
        [DllImport(Library, EntryPoint = "alSourcef", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Source(uint sid, ALSourcef param, float value);

        /// <summary>
        /// This function sets a floating-point property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">
        /// The name of the attribute to set: <see cref="ALSourcef.Pitch"/>, Gain, MinGain, MaxGain, MaxDistance,
        /// RolloffFactor, ConeOuterGain, ConeInnerAngle, ConeOuterAngle, ReferenceDistance, EfxAirAbsorptionFactor,
        /// EfxRoomRolloffFactor, EfxConeOuterGainHighFrequency.
        /// </param>
        /// <param name="value">The value to set the attribute to.</param>
        public static void Source(int sid, ALSourcef param, float value)
        {
            Source((uint)sid, param, value);
        }

        /// <summary>
        /// This function sets a source property requiring three floating-point values.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: <see cref="ALSource3f.Position"/>, Velocity, Direction.</param>
        /// <param name="value1">The first ALfloat value which the attribute will be set to.</param>
        /// <param name="value2">The second ALfloat value which the attribute will be set to.</param>
        /// <param name="value3">The third ALfloat value which the attribute will be set to.</param>
        [DllImport(Library, EntryPoint = "alSource3f", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Source(uint sid, ALSource3f param, float value1, float value2, float value3);

        /// <summary>
        /// This function sets a source property requiring three floating-point values.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: <see cref="ALSource3f.Position"/>, Velocity, Direction.</param>
        /// <param name="value1">The first ALfloat value which the attribute will be set to.</param>
        /// <param name="value2">The second ALfloat value which the attribute will be set to.</param>
        /// <param name="value3">The third ALfloat value which the attribute will be set to.</param>
        public static void Source(int sid, ALSource3f param, float value1, float value2, float value3)
        {
            Source((uint)sid, param, value1, value2, value3);
        }

        /// <summary>
        /// This function sets a source property requiring three floating-point values.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: <see cref="ALSource3f.Position"/>, Velocity, Direction.</param>
        /// <param name="values">A Math.Vector3 which the attribute will be set to.</param>
        public static void Source(uint sid, ALSource3f param, ref Vector3 values)
        {
            Source(sid, param, values.X, values.Y, values.Z);
        }

        /// <summary>
        /// This function sets a source property requiring three floating-point values.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: <see cref="ALSource3f.Position"/>, Velocity, Direction.</param>
        /// <param name="values">A Math.Vector3 which the attribute will be set to.</param>
        public static void Source(int sid, ALSource3f param, ref Vector3 values)
        {
            Source((uint)sid, param, values.X, values.Y, values.Z);
        }

        /// <summary>
        /// This function sets an integer property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">
        /// The name of the attribute to set: <see cref="ALSourcei.SourceRelative"/>, ConeInnerAngle, ConeOuterAngle,
        /// Looping, Buffer, SourceState.
        /// </param>
        /// <param name="value">The value to set the attribute to.</param>
        [DllImport(Library, EntryPoint = "alSourcei", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Source(uint sid, ALSourcei param, int value);

        /// <summary>
        /// This function sets an integer property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">
        /// The name of the attribute to set: <see cref="ALSourcei.SourceRelative"/>, ConeInnerAngle, ConeOuterAngle,
        /// Looping, Buffer, SourceState.
        /// </param>
        /// <param name="value">The value to set the attribute to.</param>
        public static void Source(int sid, ALSourcei param, int value)
        {
            Source((uint)sid, param, value);
        }

        /// <summary>
        /// This function sets an bool property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: <see cref="ALSourceb.SourceRelative"/>, Looping.</param>
        /// <param name="value">The value to set the attribute to.</param>
        public static void Source(uint sid, ALSourceb param, bool value)
        {
            Source(sid, (ALSourcei)param, value ? 1 : 0);
        }

        /// <summary>
        /// This function sets an bool property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: <see cref="ALSourceb.SourceRelative"/>, Looping.</param>
        /// <param name="value">The value to set the attribute to.</param>
        public static void Source(int sid, ALSourceb param, bool value)
        {
            Source((uint)sid, (ALSourcei)param, value ? 1 : 0);
        }

        /// <summary>
        /// (Helper) Binds a Buffer to a Source handle.
        /// </summary>
        /// <param name="source">Source name to attach the Buffer to.</param>
        /// <param name="buffer">Buffer name which is attached to the Source.</param>
        public static void BindBufferToSource(uint source, uint buffer)
        {
            Source(source, ALSourcei.Buffer, (int)buffer);
        }

        /// <summary>
        /// (Helper) Binds a Buffer to a Source handle.
        /// </summary>
        /// <param name="source">Source name to attach the Buffer to.</param>
        /// <param name="buffer">Buffer name which is attached to the Source.</param>
        public static void BindBufferToSource(int source, int buffer)
        {
            Source((uint)source, ALSourcei.Buffer, buffer);
        }

        /// <summary>
        /// This function sets 3 integer properties of a source. This property is used to establish connections between
        /// Sources and Auxiliary Effect Slots.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: EfxAuxiliarySendFilter.</param>
        /// <param name="value1">The value to set the attribute to. (EFX Extension) The destination Auxiliary Effect Slot ID.</param>
        /// <param name="value2">The value to set the attribute to. (EFX Extension) The Auxiliary Send number.</param>
        /// <param name="value3">The value to set the attribute to. (EFX Extension) optional Filter ID.</param>
        [DllImport(Library, EntryPoint = "alSource3i", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void Source(uint sid, ALSource3i param, int value1, int value2, int value3);

        /// <summary>
        /// This function sets 3 integer properties of a source. This property is used to establish connections between
        /// Sources and Auxiliary Effect Slots.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being set.</param>
        /// <param name="param">The name of the attribute to set: EfxAuxiliarySendFilter.</param>
        /// <param name="value1">The value to set the attribute to. (EFX Extension) The destination Auxiliary Effect Slot ID.</param>
        /// <param name="value2">The value to set the attribute to. (EFX Extension) The Auxiliary Send number.</param>
        /// <param name="value3">The value to set the attribute to. (EFX Extension) optional Filter ID.</param>
        public static void Source(int sid, ALSource3i param, int value1, int value2, int value3)
        {
            Source((uint)sid, param, value1, value2, value3);
        }

        /// <summary>
        /// This function retrieves a floating-point property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">
        /// The name of the attribute to set: <see cref="ALSourcef.Pitch"/>, Gain, MinGain, MaxGain, MaxDistance,
        /// RolloffFactor, ConeOuterGain, ConeInnerAngle, ConeOuterAngle, ReferenceDistance, EfxAirAbsorptionFactor,
        /// EfxRoomRolloffFactor, EfxConeOuterGainHighFrequency.
        /// </param>
        /// <param name="value">A pointer to the floating-point value being retrieved.</param>
        [DllImport(Library, EntryPoint = "alGetSourcef", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void GetSource(uint sid, ALSourcef param, [Out] out float value);

        /// <summary>
        /// This function retrieves a floating-point property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">
        /// The name of the attribute to set: <see cref="ALSourcef.Pitch"/>, Gain, MinGain, MaxGain, MaxDistance,
        /// RolloffFactor, ConeOuterGain, ConeInnerAngle, ConeOuterAngle, ReferenceDistance, EfxAirAbsorptionFactor,
        /// EfxRoomRolloffFactor, EfxConeOuterGainHighFrequency.
        /// </param>
        /// <param name="value">A pointer to the floating-point value being retrieved.</param>
        public static void GetSource(int sid, ALSourcef param, out float value)
        {
            GetSource((uint)sid, param, out value);
        }

        /// <summary>
        /// This function retrieves three floating-point values representing a property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">the name of the attribute being retrieved: <see cref="ALSource3f.Position"/>, Velocity, Direction.</param>
        /// <param name="value1">Pointer to the first element in the  value to retrieve.</param>
        /// <param name="value2">Pointer to the second element in the  value to retrieve.</param>
        /// <param name="value3">Pointer to the third element in the  value to retrieve.</param>
        [DllImport(Library, EntryPoint = "alGetSource3f", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void GetSource(uint sid, ALSource3f param, [Out] out float value1, [Out] out float value2, [Out] out float value3);

        /// <summary>
        /// This function retrieves three floating-point values representing a property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">the name of the attribute being retrieved: <see cref="ALSource3f.Position"/>, Velocity, Direction.</param>
        /// <param name="value1">Pointer to the first element in the  value to retrieve.</param>
        /// <param name="value2">Pointer to the second element in the  value to retrieve.</param>
        /// <param name="value3">Pointer to the third element in the  value to retrieve.</param>
        public static void GetSource(int sid, ALSource3f param, out float value1, out float value2, out float value3)
        {
            GetSource((uint)sid, param, out value1, out value2, out value3);
        }

        /// <summary>
        /// This function retrieves three floating-point values representing a property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">the name of the attribute being retrieved: <see cref="ALSource3f.Position"/>, Velocity, Direction.</param>
        /// <param name="values">A Math.Vector3 to retrieve the values to.</param>
        public static void GetSource(uint sid, ALSource3f param, out Vector3 values)
        {
            GetSource(sid, param, out values.X, out values.Y, out values.Z);
        }

        /// <summary>
        /// This function retrieves three floating-point values representing a property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">the name of the attribute being retrieved: <see cref="ALSource3f.Position"/>, Velocity, Direction.</param>
        /// <param name="values">A Math.Vector3 to retrieve the values to.</param>
        public static void GetSource(int sid, ALSource3f param, out Vector3 values)
        {
            GetSource((uint)sid, param, out values.X, out values.Y, out values.Z);
        }

        /// <summary>
        /// This function retrieves an integer property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">
        /// The name of the attribute to retrieve: <see cref="ALSourcei.SourceRelative"/>, Buffer, SourceState,
        /// BuffersQueued, BuffersProcessed.
        /// </param>
        /// <param name="value">A pointer to the integer value being retrieved.</param>
        [DllImport(Library, EntryPoint = "alGetSourcei", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void GetSource(uint sid, ALGetSourcei param, [Out] out int value);

        /// <summary>
        /// This function retrieves an integer property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">
        /// The name of the attribute to retrieve: <see cref="ALSourcei.SourceRelative"/>, Buffer, SourceState,
        /// BuffersQueued, BuffersProcessed.
        /// </param>
        /// <param name="value">A pointer to the integer value being retrieved.</param>
        public static void GetSource(int sid, ALGetSourcei param, out int value)
        {
            GetSource((uint)sid, param, out value);
        }

        /// <summary>
        /// This function retrieves a bool property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute to get: <see cref="ALSourceb.SourceRelative"/>, Looping.</param>
        /// <param name="value">A pointer to the bool value being retrieved.</param>
        public static void GetSource(uint sid, ALSourceb param, out bool value)
        {
            GetSource(sid, (ALGetSourcei)param, out int result);
            value = result != 0;
        }

        /// <summary>
        /// This function retrieves a bool property of a source.
        /// </summary>
        /// <param name="sid">Source name whose attribute is being retrieved.</param>
        /// <param name="param">The name of the attribute to get: <see cref="ALSourceb.SourceRelative"/>, Looping.</param>
        /// <param name="value">A pointer to the bool value being retrieved.</param>
        public static void GetSource(int sid, ALSourceb param, out bool value)
        {
            GetSource((uint)sid, (ALGetSourcei)param, out int result);
            value = result != 0;
        }

        /// <summary>
        /// This function plays a set of sources. The playing sources will have their state changed to
        /// <see cref="ALSourceState.Playing"/>. When called on a source which is already playing, the source will restart at the beginning.
        /// When the attached buffer(s) are done playing, the source will progress to the <see cref="ALSourceState.Stopped"/> state.
        /// </summary>
        /// <param name="ns">The number of sources to be played.</param>
        /// <param name="sids">A pointer to an array of sources to be played.</param>
        [DllImport(Library, EntryPoint = "alSourcePlayv")]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void SourcePlay(int ns, [In] uint* sids);

        /// <summary>
        /// This function plays a set of sources. The playing sources will have their state changed to
        /// <see cref="ALSourceState.Playing"/>. When called on a source which is already playing, the source will restart at the beginning.
        /// When the attached buffer(s) are done playing, the source will progress to the <see cref="ALSourceState.Stopped"/> state.
        /// </summary>
        /// <param name="ns">The number of sources to be played.</param>
        /// <param name="sids">A pointer to an array of sources to be played.</param>
        public static void SourcePlay(int ns, uint[] sids)
        {
            unsafe
            {
                fixed (uint* ptr = sids)
                {
                    SourcePlay(ns, ptr);
                }
            }
        }

        /// <summary>
        /// This function plays a set of sources. The playing sources will have their state changed to
        /// <see cref="ALSourceState.Playing"/>. When called on a source which is already playing, the source will restart at the beginning.
        /// When the attached buffer(s) are done playing, the source will progress to the <see cref="ALSourceState.Stopped"/> state.
        /// </summary>
        /// <param name="ns">The number of sources to be played.</param>
        /// <param name="sids">A pointer to an array of sources to be played.</param>
        public static void SourcePlay(int ns, int[] sids)
        {
            var temp = new uint[ns];
            for (var i = 0; i < ns; i++)
            {
                temp[i] = (uint)sids[i];
            }

            SourcePlay(ns, temp);
        }

        /// <summary>
        /// This function plays a set of sources. The playing sources will have their state changed to
        /// <see cref="ALSourceState.Playing"/>. When called on a source which is already playing, the source will restart at the beginning.
        /// When the attached buffer(s) are done playing, the source will progress to the <see cref="ALSourceState.Stopped"/> state.
        /// </summary>
        /// <param name="ns">The number of sources to be played.</param>
        /// <param name="sids">A pointer to an array of sources to be played.</param>
        public static void SourcePlay(int ns, ref uint sids)
        {
            unsafe
            {
                fixed (uint* ptr = &sids)
                {
                    SourcePlay(ns, ptr);
                }
            }
        }

        /// <summary>
        /// This function stops a set of sources. The stopped sources will have their state changed to
        /// <see cref="ALSourceState.Stopped"/>.
        /// </summary>
        /// <param name="ns">The number of sources to stop.</param>
        /// <param name="sids">A pointer to an array of sources to be stopped.</param>
        [DllImport(Library, EntryPoint = "alSourceStopv")]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void SourceStop(int ns, [In] uint* sids);

        /// <summary>
        /// This function stops a set of sources. The stopped sources will have their state changed to
        /// <see cref="ALSourceState.Stopped"/>.
        /// </summary>
        /// <param name="ns">The number of sources to stop.</param>
        /// <param name="sids">A pointer to an array of sources to be stopped.</param>
        public static void SourceStop(int ns, uint[] sids)
        {
            unsafe
            {
                fixed (uint* ptr = sids)
                {
                    SourceStop(ns, ptr);
                }
            }
        }

        /// <summary>
        /// This function stops a set of sources. The stopped sources will have their state changed to
        /// <see cref="ALSourceState.Stopped"/>.
        /// </summary>
        /// <param name="ns">The number of sources to stop.</param>
        /// <param name="sids">A pointer to an array of sources to be stopped.</param>
        public static void SourceStop(int ns, int[] sids)
        {
            var temp = new uint[ns];
            for (var i = 0; i < ns; i++)
            {
                temp[i] = (uint)sids[i];
            }

            SourceStop(ns, temp);
        }

        /// <summary>
        /// This function stops a set of sources. The stopped sources will have their state changed to
        /// <see cref="ALSourceState.Stopped"/>.
        /// </summary>
        /// <param name="ns">The number of sources to stop.</param>
        /// <param name="sids">A pointer to an array of sources to be stopped.</param>
        public static void SourceStop(int ns, ref uint sids)
        {
            unsafe
            {
                fixed (uint* ptr = &sids)
                {
                    SourceStop(ns, ptr);
                }
            }
        }

        /// <summary>
        /// This function stops a set of sources and sets all their states to <see cref="ALSourceState.Initial"/>.
        /// </summary>
        /// <param name="ns">The number of sources to be rewound.</param>
        /// <param name="sids">A pointer to an array of sources to be rewound.</param>
        [DllImport(Library, EntryPoint = "alSourceRewindv")]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void SourceRewind(int ns, [In] uint* sids);

        /// <summary>
        /// This function stops a set of sources and sets all their states to <see cref="ALSourceState.Initial"/>.
        /// </summary>
        /// <param name="ns">The number of sources to be rewound.</param>
        /// <param name="sids">A pointer to an array of sources to be rewound.</param>
        public static void SourceRewind(int ns, uint[] sids)
        {
            unsafe
            {
                fixed (uint* ptr = sids)
                {
                    SourceRewind(ns, ptr);
                }
            }
        }

        /// <summary>
        /// This function stops a set of sources and sets all their states to <see cref="ALSourceState.Initial"/>.
        /// </summary>
        /// <param name="ns">The number of sources to be rewound.</param>
        /// <param name="sids">A pointer to an array of sources to be rewound.</param>
        public static void SourceRewind(int ns, int[] sids)
        {
            var temp = new uint[ns];
            for (var i = 0; i < ns; i++)
            {
                temp[i] = (uint)sids[i];
            }

            SourceRewind(ns, temp);
        }

        /// <summary>
        /// This function stops a set of sources and sets all their states to <see cref="ALSourceState.Initial"/>.
        /// </summary>
        /// <param name="ns">The number of sources to be rewound.</param>
        /// <param name="sids">A pointer to an array of sources to be rewound.</param>
        public static void SourceRewind(int ns, ref uint sids)
        {
            unsafe
            {
                fixed (uint* ptr = &sids)
                {
                    SourceRewind(ns, ptr);
                }
            }
        }

        /// <summary>
        /// This function pauses a set of sources. The paused sources will have their state changed to
        /// <see cref="ALSourceState.Paused"/>.
        /// </summary>
        /// <param name="ns">The number of sources to be paused.</param>
        /// <param name="sids">A pointer to an array of sources to be paused.</param>
        [DllImport(Library, EntryPoint = "alSourcePausev")]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void SourcePause(int ns, [In] uint* sids);

        /// <summary>
        /// This function pauses a set of sources. The paused sources will have their state changed to
        /// <see cref="ALSourceState.Paused"/>.
        /// </summary>
        /// <param name="ns">The number of sources to be paused.</param>
        /// <param name="sids">A pointer to an array of sources to be paused.</param>
        public static void SourcePause(int ns, uint[] sids)
        {
            unsafe
            {
                fixed (uint* ptr = sids)
                {
                    SourcePause(ns, ptr);
                }
            }
        }

        /// <summary>
        /// This function pauses a set of sources. The paused sources will have their state changed to
        /// <see cref="ALSourceState.Paused"/>.
        /// </summary>
        /// <param name="ns">The number of sources to be paused.</param>
        /// <param name="sids">A pointer to an array of sources to be paused.</param>
        public static void SourcePause(int ns, int[] sids)
        {
            var temp = new uint[ns];
            for (var i = 0; i < ns; i++)
            {
                temp[i] = (uint)sids[i];
            }

            SourcePause(ns, temp);
        }

        /// <summary>
        /// This function pauses a set of sources. The paused sources will have their state changed to
        /// <see cref="ALSourceState.Paused"/>.
        /// </summary>
        /// <param name="ns">The number of sources to be paused.</param>
        /// <param name="sids">A pointer to an array of sources to be paused.</param>
        public static void SourcePause(int ns, ref uint sids)
        {
            unsafe
            {
                fixed (uint* ptr = &sids)
                {
                    SourcePause(ns, ptr);
                }
            }
        }

        /// <summary>
        /// This function plays, replays or resumes a source. The playing source will have it's state changed to
        /// <see cref="ALSourceState.Playing"/>. When called on a source which is already playing, the source will restart at the beginning.
        /// When the attached buffer(s) are done playing, the source will progress to the <see cref="ALSourceState.Stopped"/> state.
        /// </summary>
        /// <param name="sid">The name of the source to be played.</param>
        [DllImport(Library, EntryPoint = "alSourcePlay", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void SourcePlay(uint sid);

        /// <summary>
        /// This function plays, replays or resumes a source. The playing source will have it's state changed to
        /// <see cref="ALSourceState.Playing"/>. When called on a source which is already playing, the source will restart at the beginning.
        /// When the attached buffer(s) are done playing, the source will progress to the <see cref="ALSourceState.Stopped"/> state.
        /// </summary>
        /// <param name="sid">The name of the source to be played.</param>
        public static void SourcePlay(int sid)
        {
            SourcePlay((uint)sid);
        }

        /// <summary>
        /// This function stops a source. The stopped source will have it's state changed to <see cref="ALSourceState.Stopped"/>.
        /// </summary>
        /// <param name="sid">The name of the source to be stopped.</param>
        [DllImport(Library, EntryPoint = "alSourceStop", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void SourceStop(uint sid);

        /// <summary>
        /// This function stops a source. The stopped source will have it's state changed to <see cref="ALSourceState.Stopped"/>.
        /// </summary>
        /// <param name="sid">The name of the source to be stopped.</param>
        public static void SourceStop(int sid)
        {
            SourceStop((uint)sid);
        }

        /// <summary>
        /// This function stops the source and sets its state to <see cref="ALSourceState.Initial"/>.
        /// </summary>
        /// <param name="sid">The name of the source to be rewound.</param>
        [DllImport(Library, EntryPoint = "alSourceRewind", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void SourceRewind(uint sid);

        /// <summary>
        /// This function stops the source and sets its state to <see cref="ALSourceState.Initial"/>.
        /// </summary>
        /// <param name="sid">The name of the source to be rewound.</param>
        public static void SourceRewind(int sid)
        {
            SourceRewind((uint)sid);
        }

        /// <summary>
        /// This function pauses a source. The paused source will have its state changed to <see cref="ALSourceState.Paused"/>.
        /// </summary>
        /// <param name="sid">The name of the source to be paused.</param>
        [DllImport(Library, EntryPoint = "alSourcePause", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void SourcePause(uint sid);

        /// <summary>
        /// This function pauses a source. The paused source will have its state changed to <see cref="ALSourceState.Paused"/>.
        /// </summary>
        /// <param name="sid">The name of the source to be paused.</param>
        public static void SourcePause(int sid)
        {
            SourcePause((uint)sid);
        }

        /// <summary>
        /// This function queues a set of buffers on a source. All buffers attached to a source will be played in
        /// sequence, and the number of processed buffers can be detected using <see cref="AL.GetSource"/> with parameter
        /// <see cref="ALGetSourcei.BuffersProcessed"/>. When first created, a source will be of type <see cref="ALSourceType.Undetermined"/>. A successful
        /// <see cref="AL.SourceQueueBuffers"/> call will change the source type to <see cref="ALSourceType.Streaming"/>.
        /// </summary>
        /// <param name="sid">The name of the source to queue buffers onto.</param>
        /// <param name="numEntries">The number of buffers to be queued.</param>
        /// <param name="bids">A pointer to an array of buffer names to be queued.</param>
        [DllImport(Library, EntryPoint = "alSourceQueueBuffers")]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void SourceQueueBuffers(uint sid, int numEntries, [In] uint* bids);

        /// <summary>
        /// This function queues a set of buffers on a source. All buffers attached to a source will be played in
        /// sequence, and the number of processed buffers can be detected using <see cref="AL.GetSource"/> with parameter
        /// <see cref="ALGetSourcei.BuffersProcessed"/>. When first created, a source will be of type <see cref="ALSourceType.Undetermined"/>. A successful
        /// <see cref="AL.SourceQueueBuffers"/> call will change the source type to <see cref="ALSourceType.Streaming"/>.
        /// </summary>
        /// <param name="sid">The name of the source to queue buffers onto.</param>
        /// <param name="numEntries">The number of buffers to be queued.</param>
        /// <param name="bids">A pointer to an array of buffer names to be queued.</param>
        public static void SourceQueueBuffers(uint sid, int numEntries, uint[] bids)
        {
            unsafe
            {
                fixed (uint* ptr = bids)
                {
                    SourceQueueBuffers(sid, numEntries, ptr);
                }
            }
        }

        /// <summary>
        /// This function queues a set of buffers on a source. All buffers attached to a source will be played in
        /// sequence, and the number of processed buffers can be detected using <see cref="AL.GetSource"/> with parameter
        /// <see cref="ALGetSourcei.BuffersProcessed"/>. When first created, a source will be of type <see cref="ALSourceType.Undetermined"/>. A successful
        /// <see cref="AL.SourceQueueBuffers"/> call will change the source type to <see cref="ALSourceType.Streaming"/>.
        /// </summary>
        /// <param name="sid">The name of the source to queue buffers onto.</param>
        /// <param name="numEntries">The number of buffers to be queued.</param>
        /// <param name="bids">A pointer to an array of buffer names to be queued.</param>
        public static void SourceQueueBuffers(int sid, int numEntries, int[] bids)
        {
            var temp = new uint[numEntries];
            for (var i = 0; i < numEntries; i++)
            {
                temp[i] = (uint)bids[i];
            }

            SourceQueueBuffers((uint)sid, numEntries, temp);
        }

        /// <summary>
        /// This function queues a set of buffers on a source. All buffers attached to a source will be played in
        /// sequence, and the number of processed buffers can be detected using <see cref="AL.GetSource"/> with parameter
        /// <see cref="ALGetSourcei.BuffersProcessed"/>. When first created, a source will be of type <see cref="ALSourceType.Undetermined"/>. A successful
        /// <see cref="AL.SourceQueueBuffers"/> call will change the source type to <see cref="ALSourceType.Streaming"/>.
        /// </summary>
        /// <param name="sid">The name of the source to queue buffers onto.</param>
        /// <param name="numEntries">The number of buffers to be queued.</param>
        /// <param name="bids">A pointer to an array of buffer names to be queued.</param>
        public static void SourceQueueBuffers(uint sid, int numEntries, ref uint bids)
        {
            unsafe
            {
                fixed (uint* ptr = &bids)
                {
                    SourceQueueBuffers(sid, numEntries, ptr);
                }
            }
        }

        /// <summary>
        /// This function queues a set of buffers on a source. All buffers attached to a source will be played in
        /// sequence, and the number of processed buffers can be detected using <see cref="AL.GetSource"/> with parameter
        /// <see cref="ALGetSourcei.BuffersProcessed"/>. When first created, a source will be of type <see cref="ALSourceType.Undetermined"/>. A successful
        /// <see cref="AL.SourceQueueBuffers"/> call will change the source type to <see cref="ALSourceType.Streaming"/>.
        /// </summary>
        /// <param name="source">The name of the source to queue buffers onto.</param>
        /// <param name="buffer">The name of the buffer to be queued.</param>
        public static void SourceQueueBuffer(int source, int buffer)
        {
            unsafe
            {
                SourceQueueBuffers((uint)source, 1, (uint*)&buffer);
            }
        }

        /// <summary>
        /// This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected
        /// using <see cref="AL.GetSource"/> with parameter <see cref="ALGetSourcei.BuffersProcessed"/>, which is the maximum number of buffers that can be
        /// unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the
        /// queue.
        /// </summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <param name="bids">A pointer to an array of buffer names that were removed.</param>
        [DllImport(Library, EntryPoint = "alSourceUnqueueBuffers")]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void SourceUnqueueBuffers(uint sid, int numEntries, [Out] uint* bids);

        /// <summary>
        /// This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected
        /// using <see cref="AL.GetSource"/> with parameter <see cref="ALGetSourcei.BuffersProcessed"/>, which is the maximum number of buffers that can be
        /// unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the
        /// queue.
        /// </summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <param name="bids">A pointer to an array of buffer names that were removed.</param>
        [DllImport(Library, EntryPoint = "alSourceUnqueueBuffers")]
        [SuppressUnmanagedCodeSecurity]
        public static extern void SourceUnqueueBuffers(uint sid, int numEntries, [Out] uint[] bids);

        /// <summary>
        /// This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected
        /// using <see cref="AL.GetSource"/> with parameter <see cref="ALGetSourcei.BuffersProcessed"/>, which is the maximum number of buffers that can be
        /// unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the
        /// queue.
        /// </summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <param name="bids">A pointer to an array of buffer names that were removed.</param>
        [DllImport(Library, EntryPoint = "alSourceUnqueueBuffers")]
        [SuppressUnmanagedCodeSecurity]
        public static extern void SourceUnqueueBuffers(int sid, int numEntries, [Out] int[] bids);

        /// <summary>
        /// This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected
        /// using <see cref="AL.GetSource"/> with parameter <see cref="ALGetSourcei.BuffersProcessed"/>, which is the maximum number of buffers that can be
        /// unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the
        /// queue.
        /// </summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <param name="bids">A pointer to an array of buffer names that were removed.</param>
        [DllImport(Library, EntryPoint = "alSourceUnqueueBuffers")]
        [SuppressUnmanagedCodeSecurity]
        public static extern void SourceUnqueueBuffers(uint sid, int numEntries, out uint bids);

        /// <summary>
        /// This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected
        /// using <see cref="AL.GetSource"/> with parameter <see cref="ALGetSourcei.BuffersProcessed"/>, which is the maximum number of buffers that can be
        /// unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the
        /// queue.
        /// </summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <param name="bids">A pointer to an array of buffer names that were removed.</param>
        [DllImport(Library, EntryPoint = "alSourceUnqueueBuffers")]
        [SuppressUnmanagedCodeSecurity]
        public static extern void SourceUnqueueBuffers(int sid, int numEntries, out int bids);

        /// <summary>
        /// This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected
        /// using <see cref="AL.GetSource"/> with parameter <see cref="ALGetSourcei.BuffersProcessed"/>, which is the maximum number of buffers that can be
        /// unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the
        /// queue.
        /// </summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <returns>The buffer that was unqueued.</returns>
        public static int SourceUnqueueBuffer(int sid)
        {
            uint buf;
            unsafe
            {
                SourceUnqueueBuffers((uint)sid, 1, &buf);
            }

            return (int)buf;
        }

        /// <summary>
        /// This function unqueues a set of buffers attached to a source. The number of processed buffers can be detected
        /// using <see cref="AL.GetSource"/> with parameter <see cref="ALGetSourcei.BuffersProcessed"/>, which is the maximum number of buffers that can be
        /// unqueued using this call. The unqueue operation will only take place if all n buffers can be removed from the
        /// queue.
        /// </summary>
        /// <param name="sid">The name of the source to unqueue buffers from.</param>
        /// <param name="numEntries">The number of buffers to be unqueued.</param>
        /// <returns>The buffers that were unqueued.</returns>
        public static int[] SourceUnqueueBuffers(int sid, int numEntries)
        {
            if (numEntries <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numEntries), "Must be greater than zero.");
            }

            var buf = new int[numEntries];
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

        /// <summary>
        /// This function generates one or more buffers, which contain audio buffer (see <see cref="AL.BufferData"/>). References to
        /// buffers are uint values, which are used wherever a buffer reference is needed (in calls such as <see cref="AL.DeleteBuffers"/>,
        /// <see cref="AL.Source"/> with parameter ALSourcei, <see cref="AL.SourceQueueBuffers"/>, and <see cref="AL.SourceUnqueueBuffers"/>).
        /// </summary>
        /// <param name="n">The number of buffers to be generated.</param>
        /// <param name="buffers">Pointer to an array of uint values which will store the names of the new buffers.</param>
        [DllImport(Library, EntryPoint = "alGenBuffers", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void GenBuffers(int n, [Out] uint* buffers);

        /// <summary>
        /// This function generates one or more buffers, which contain audio buffer (see <see cref="AL.BufferData"/>). References to
        /// buffers are uint values, which are used wherever a buffer reference is needed (in calls such as <see cref="AL.DeleteBuffers"/>,
        /// <see cref="AL.Source"/> with parameter ALSourcei, <see cref="AL.SourceQueueBuffers"/>, and <see cref="AL.SourceUnqueueBuffers"/>).
        /// </summary>
        /// <param name="n">The number of buffers to be generated.</param>
        /// <param name="buffers">Pointer to an array of uint values which will store the names of the new buffers.</param>
        [DllImport(Library, EntryPoint = "alGenBuffers", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void GenBuffers(int n, [Out] int* buffers);

        /// <summary>
        /// This function generates one or more buffers, which contain audio buffer (see <see cref="AL.BufferData"/>). References to
        /// buffers are uint values, which are used wherever a buffer reference is needed (in calls such as <see cref="AL.DeleteBuffers"/>,
        /// <see cref="AL.Source"/> with parameter ALSourcei, <see cref="AL.SourceQueueBuffers"/>, and <see cref="AL.SourceUnqueueBuffers"/>).
        /// </summary>
        /// <param name="n">The number of buffers to be generated.</param>
        /// <param name="buffers">Pointer to an array of uint values which will store the names of the new buffers.</param>
        public static void GenBuffers(int n, out uint buffers)
        {
            unsafe
            {
                fixed (uint* pbuffers = &buffers)
                {
                    GenBuffers(n, pbuffers);
                }
            }
        }

        /// <summary>
        /// This function generates one or more buffers, which contain audio buffer (see <see cref="AL.BufferData"/>). References to
        /// buffers are uint values, which are used wherever a buffer reference is needed (in calls such as <see cref="AL.DeleteBuffers"/>,
        /// <see cref="AL.Source"/> with parameter ALSourcei, <see cref="AL.SourceQueueBuffers"/>, and <see cref="AL.SourceUnqueueBuffers"/>).
        /// </summary>
        /// <param name="n">The number of buffers to be generated.</param>
        /// <param name="buffers">Pointer to an array of uint values which will store the names of the new buffers.</param>
        public static void GenBuffers(int n, out int buffers)
        {
            unsafe
            {
                fixed (int* pbuffers = &buffers)
                {
                    GenBuffers(n, pbuffers);
                }
            }
        }

        /// <summary>
        /// This function generates one or more buffers, which contain audio data (see <see cref="AL.BufferData"/>). References to
        /// buffers are uint values, which are used wherever a buffer reference is needed (in calls such as <see cref="AL.DeleteBuffers"/>,
        /// <see cref="AL.Source"/> with parameter ALSourcei, <see cref="AL.SourceQueueBuffers"/>, and <see cref="AL.SourceUnqueueBuffers"/>).
        /// </summary>
        /// <param name="n">The number of buffers to be generated.</param>
        /// <returns>Pointer to an array of uint values which will store the names of the new buffers.</returns>
        public static int[] GenBuffers(int n)
        {
            var buffers = new int[n];
            GenBuffers(buffers.Length, out buffers[0]);
            return buffers;
        }

        /// <summary>
        /// This function generates one buffer only, which contain audio data (see <see cref="AL.BufferData"/>). References to buffers
        /// are uint values, which are used wherever a buffer reference is needed (in calls such as <see cref="AL.DeleteBuffers"/>, <see cref="AL.Source"/>
        /// with parameter ALSourcei, <see cref="AL.SourceQueueBuffers"/>, and <see cref="AL.SourceUnqueueBuffers"/>).
        /// </summary>
        /// <returns>Pointer to an uint value which will store the name of the new buffer.</returns>
        public static int GenBuffer()
        {
            GenBuffers(1, out int temp);
            return temp;
        }

        /// <summary>
        /// This function generates one buffer only, which contain audio data (see <see cref="AL.BufferData"/>). References to buffers
        /// are uint values, which are used wherever a buffer reference is needed (in calls such as <see cref="AL.DeleteBuffers"/>, <see cref="AL.Source"/>
        /// with parameter ALSourcei, <see cref="AL.SourceQueueBuffers"/>, and <see cref="AL.SourceUnqueueBuffers"/>).
        /// </summary>
        /// <param name="buffer">Pointer to an uint value which will store the names of the new buffer.</param>
        public static void GenBuffer(out uint buffer)
        {
            GenBuffers(1, out buffer);
        }

        /// <summary>
        /// This function deletes one or more buffers, freeing the resources used by the buffer. Buffers which are
        /// attached to a source can not be deleted. See <see cref="AL.Source"/> (ALSourcei) and <see cref="AL.SourceUnqueueBuffers"/> for information on
        /// how to detach a buffer from a source.
        /// </summary>
        /// <param name="n">The number of buffers to be deleted.</param>
        /// <param name="buffers">Pointer to an array of buffer names identifying the buffers to be deleted.</param>
        [DllImport(Library, EntryPoint = "alDeleteBuffers", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void DeleteBuffers(int n, [In] uint* buffers);

        /// <summary>
        /// This function deletes one or more buffers, freeing the resources used by the buffer. Buffers which are
        /// attached to a source can not be deleted. See <see cref="AL.Source"/> (ALSourcei) and <see cref="AL.SourceUnqueueBuffers"/> for information on
        /// how to detach a buffer from a source.
        /// </summary>
        /// <param name="n">The number of buffers to be deleted.</param>
        /// <param name="buffers">Pointer to an array of buffer names identifying the buffers to be deleted.</param>
        [DllImport(Library, EntryPoint = "alDeleteBuffers", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern unsafe void DeleteBuffers(int n, [In] int* buffers);

        /// <summary>
        /// This function deletes one or more buffers, freeing the resources used by the buffer. Buffers which are
        /// attached to a source can not be deleted. See <see cref="AL.Source"/> (ALSourcei) and <see cref="AL.SourceUnqueueBuffers"/> for information on
        /// how to detach a buffer from a source.
        /// </summary>
        /// <param name="n">The number of buffers to be deleted.</param>
        /// <param name="buffers">Pointer to an array of buffer names identifying the buffers to be deleted.</param>
        public static void DeleteBuffers(int n, [In] ref uint buffers)
        {
            unsafe
            {
                fixed (uint* pbuffers = &buffers)
                {
                    DeleteBuffers(n, pbuffers);
                }
            }
        }

        /// <summary>
        /// This function deletes one or more buffers, freeing the resources used by the buffer. Buffers which are
        /// attached to a source can not be deleted. See <see cref="AL.Source"/> (ALSourcei) and <see cref="AL.SourceUnqueueBuffers"/> for information on
        /// how to detach a buffer from a source.
        /// </summary>
        /// <param name="n">The number of buffers to be deleted.</param>
        /// <param name="buffers">Pointer to an array of buffer names identifying the buffers to be deleted.</param>
        public static void DeleteBuffers(int n, [In] ref int buffers)
        {
            unsafe
            {
                fixed (int* pbuffers = &buffers)
                {
                    DeleteBuffers(n, pbuffers);
                }
            }
        }

        /// <summary>
        /// This function deletes one buffer only, freeing the resources used by the buffer. Buffers which are attached to
        /// a source can not be deleted. See <see cref="AL.Source"/> (ALSourcei) and <see cref="AL.SourceUnqueueBuffers"/> for information on how to detach
        /// a buffer from a source.
        /// </summary>
        /// <param name="buffers">Pointer to a buffer name identifying the buffer to be deleted.</param>
        public static void DeleteBuffers(uint[] buffers)
        {
            if (buffers == null)
            {
                throw new ArgumentNullException();
            }

            if (buffers.Length == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            DeleteBuffers(buffers.Length, ref buffers[0]);
        }

        /// <summary>
        /// This function deletes one or more buffers, freeing the resources used by the buffer. Buffers which are
        /// attached to a source can not be deleted. See <see cref="AL.Source"/> (ALSourcei) and <see cref="AL.SourceUnqueueBuffers"/> for information on
        /// how to detach a buffer from a source.
        /// </summary>
        /// <param name="buffers">Pointer to an array of buffer names identifying the buffers to be deleted.</param>
        public static void DeleteBuffers(int[] buffers)
        {
            if (buffers == null)
            {
                throw new ArgumentNullException();
            }

            if (buffers.Length == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            DeleteBuffers(buffers.Length, ref buffers[0]);
        }

        /// <summary>
        /// This function deletes one buffer only, freeing the resources used by the buffer. Buffers which are attached to
        /// a source can not be deleted. See <see cref="AL.Source"/> (ALSourcei) and <see cref="AL.SourceUnqueueBuffers"/> for information on how to detach
        /// a buffer from a source.
        /// </summary>
        /// <param name="buffer">Pointer to a buffer name identifying the buffer to be deleted.</param>
        public static void DeleteBuffer(ref uint buffer)
        {
            DeleteBuffers(1, ref buffer);
        }

        /// <summary>
        /// This function deletes one buffer only, freeing the resources used by the buffer. Buffers which are attached to
        /// a source can not be deleted. See <see cref="AL.Source"/> (ALSourcei) and <see cref="AL.SourceUnqueueBuffers"/> for information on how to detach
        /// a buffer from a source.
        /// </summary>
        /// <param name="buffer">Pointer to a buffer name identifying the buffer to be deleted.</param>
        public static void DeleteBuffer(int buffer)
        {
            DeleteBuffers(1, ref buffer);
        }

        /// <summary>
        /// This function tests if a buffer name is valid, returning True if valid, False if not.
        /// </summary>
        /// <param name="bid">A buffer Handle previously allocated with <see cref="GenBuffers(int)" />.</param>
        /// <returns>Success.</returns>
        [DllImport(Library, EntryPoint = "alIsBuffer", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern bool IsBuffer(uint bid);

        /// <summary>
        /// This function tests if a buffer name is valid, returning True if valid, False if not.
        /// </summary>
        /// <param name="bid">A buffer Handle previously allocated with <see cref="GenBuffers(int)" />.</param>
        /// <returns>Success.</returns>
        public static bool IsBuffer(int bid)
        {
            var temp = (uint)bid;
            return IsBuffer(temp);
        }

        /// <summary>
        /// This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function
        /// may be used by extensions to load other buffer types as well.
        /// </summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">
        /// Format type from among the following: <see cref="ALFormat.Mono8"/>, <see cref="ALFormat.Mono16"/>, <see cref="ALFormat.Stereo8"/>,
        /// <see cref="ALFormat.Stereo16"/>.
        /// </param>
        /// <param name="buffer">Pointer to a pinned audio buffer.</param>
        /// <param name="size">The size of the audio buffer in bytes.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        [DllImport(Library, EntryPoint = "alBufferData", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void BufferData(uint bid, ALFormat format, IntPtr buffer, int size, int freq);

        /// <summary>
        /// This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function
        /// may be used by extensions to load other buffer types as well.
        /// </summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">
        /// Format type from among the following: <see cref="ALFormat.Mono8"/>, <see cref="ALFormat.Mono16"/>, <see cref="ALFormat.Stereo8"/>,
        /// <see cref="ALFormat.Stereo16"/>.
        /// </param>
        /// <param name="buffer">Pointer to a pinned audio buffer.</param>
        /// <param name="size">The size of the audio buffer in bytes.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        public static void BufferData(int bid, ALFormat format, IntPtr buffer, int size, int freq)
        {
            BufferData((uint)bid, format, buffer, size, freq);
        }

        /// <summary>
        /// This function fills a buffer with audio buffer. All the pre-defined formats are PCM buffer, but this function
        /// may be used by extensions to load other buffer types as well.
        /// </summary>
        /// <param name="bid">buffer Handle/Name to be filled with buffer.</param>
        /// <param name="format">
        /// Format type from among the following: <see cref="ALFormat.Mono8"/>, <see cref="ALFormat.Mono16"/>, <see cref="ALFormat.Stereo8"/>,
        /// <see cref="ALFormat.Stereo16"/>.
        /// </param>
        /// <typeparam name="TBuffer">The type of the buffer.</typeparam>
        /// <param name="buffer">The audio buffer.</param>
        /// <param name="size">The size of the audio buffer in bytes.</param>
        /// <param name="freq">The frequency of the audio buffer.</param>
        public static void BufferData<TBuffer>(int bid, ALFormat format, TBuffer[] buffer, int size, int freq)
            where TBuffer : struct
        {
            if (!BlittableValueType.Check(buffer))
            {
                throw new ArgumentException("buffer");
            }

            var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                BufferData(bid, format, handle.AddrOfPinnedObject(), size, freq);
            }
            finally
            {
                handle.Free();
            }
        }

        /// <summary>
        /// This function retrieves an integer property of a buffer.
        /// </summary>
        /// <param name="bid">Buffer name whose attribute is being retrieved.</param>
        /// <param name="param">
        /// The name of the attribute to be retrieved: <see cref="ALGetBufferi.Frequency"/>, Bits, Channels, Size, and the
        /// currently hidden AL_DATA (dangerous).
        /// </param>
        /// <param name="value">A pointer to an int to hold the retrieved buffer.</param>
        [DllImport(Library, EntryPoint = "alGetBufferi", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void GetBuffer(uint bid, ALGetBufferi param, [Out] out int value);

        /// <summary>
        /// This function retrieves an integer property of a buffer.
        /// </summary>
        /// <param name="bid">Buffer name whose attribute is being retrieved.</param>
        /// <param name="param">
        /// The name of the attribute to be retrieved: <see cref="ALGetBufferi.Frequency"/>, Bits, Channels, Size, and the
        /// currently hidden AL_DATA (dangerous).
        /// </param>
        /// <param name="value">A pointer to an int to hold the retrieved buffer.</param>
        public static void GetBuffer(int bid, ALGetBufferi param, out int value)
        {
            GetBuffer((uint)bid, param, out value);
        }

        /// <summary>
        /// <see cref="AL.DopplerFactor"/> is a simple scaling of source and listener velocities to exaggerate or deemphasize the
        /// Doppler (pitch) shift resulting from the calculation.
        /// </summary>
        /// <param name="value">
        /// A negative value will result in an error, the command is then ignored. The default value is 1f. The
        /// current setting can be queried using <see cref="AL.Get"/> with parameter <see cref="ALGetFloat.SpeedOfSound"/>.
        /// </param>
        [DllImport(Library, EntryPoint = "alDopplerFactor", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void DopplerFactor(float value);

        /// <summary>
        /// This function is deprecated and should not be used.
        /// </summary>
        /// <param name="value">The default is 1.0f.</param>
        [DllImport(Library, EntryPoint = "alDopplerVelocity", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void DopplerVelocity(float value);

        /// <summary>
        /// <see cref="AL.SpeedOfSound"/> allows the application to change the reference (propagation) speed used in the Doppler
        /// calculation. The source and listener velocities should be expressed in the same units as the speed of sound.
        /// </summary>
        /// <param name="value">
        /// A negative or zero value will result in an error, and the command is ignored. Default: 343.3f
        /// (appropriate for velocity units of meters and air as the propagation medium). The current setting can be queried
        /// using <see cref="AL.Get"/> with parameter <see cref="ALGetFloat.SpeedOfSound"/>.
        /// </param>
        [DllImport(Library, EntryPoint = "alSpeedOfSound", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void SpeedOfSound(float value);

        /// <summary>
        /// This function selects the OpenAL distance model – <see cref="ALDistanceModel.InverseDistance"/>,
        /// <see cref="ALDistanceModel.InverseDistanceClamped"/>, <see cref="ALDistanceModel.LinearDistance"/>, <see cref="ALDistanceModel.LinearDistanceClamped"/>,
        /// <see cref="ALDistanceModel.ExponentDistance"/>, <see cref="ALDistanceModel.ExponentDistanceClamped"/>, or <see cref="ALDistanceModel.None"/>. The default
        /// distance model in OpenAL is <see cref="ALDistanceModel.InverseDistanceClamped"/>.
        /// </summary>
        /// <remarks>
        /// The ALDistanceModel .InverseDistance model works according to the following formula:
        /// gain = <see cref="ALSourcef.ReferenceDistance"/> / (<see cref="ALSourcef.ReferenceDistance"/> + <see cref="ALSourcef.RolloffFactor"/> * (distance –
        /// <see cref="ALSourcef.ReferenceDistance"/>));
        /// The ALDistanceModel .InverseDistanceClamped model works according to the following formula:
        /// distance = max(distance,<see cref="ALSourcef.ReferenceDistance"/>);
        /// distance = min(distance,<see cref="ALSourcef.MaxDistance"/>);
        /// gain = <see cref="ALSourcef.ReferenceDistance"/> / (<see cref="ALSourcef.ReferenceDistance"/> + <see cref="ALSourcef.RolloffFactor"/> * (distance –
        /// <see cref="ALSourcef.ReferenceDistance"/>));
        /// The <see cref="ALDistanceModel.LinearDistance"/> model works according to the following formula:
        /// distance = min(distance, <see cref="ALSourcef.MaxDistance"/>) // avoid negative gain
        /// gain = (1 – <see cref="ALSourcef.RolloffFactor"/> * (distance – <see cref="ALSourcef.ReferenceDistance"/>) / (<see cref="ALSourcef.MaxDistance"/> –
        /// <see cref="ALSourcef.ReferenceDistance"/>))
        /// The <see cref="ALDistanceModel.LinearDistanceClamped"/> model works according to the following formula:
        /// distance = max(distance, <see cref="ALSourcef.ReferenceDistance"/>)
        /// distance = min(distance, <see cref="ALSourcef.MaxDistance"/>)
        /// gain = (1 – <see cref="ALSourcef.RolloffFactor"/> * (distance – <see cref="ALSourcef.ReferenceDistance"/>) / (<see cref="ALSourcef.MaxDistance"/> –
        /// <see cref="ALSourcef.ReferenceDistance"/>))
        /// The <see cref="ALDistanceModel.ExponentDistance"/> model works according to the following formula:
        /// gain = (distance / <see cref="ALSourcef.ReferenceDistance"/>) ^ (- <see cref="ALSourcef.RolloffFactor"/>)
        /// The <see cref="ALDistanceModel.ExponentDistanceClamped"/> model works according to the following formula:
        /// distance = max(distance, <see cref="ALSourcef.ReferenceDistance"/>)
        /// distance = min(distance, <see cref="ALSourcef.MaxDistance"/>)
        /// gain = (distance / <see cref="ALSourcef.ReferenceDistance"/>) ^ (- <see cref="ALSourcef.RolloffFactor"/>)
        /// The <see cref="ALDistanceModel.None"/> model works according to the following formula:
        /// gain = 1f.
        /// </remarks>
        /// <param name="distancemodel">The distance model.</param>
        [DllImport(Library, EntryPoint = "alDistanceModel", ExactSpelling = true, CallingConvention = Style)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void DistanceModel(ALDistanceModel distancemodel);

        /// <summary>
        /// (Helper) Returns Source state information.
        /// </summary>
        /// <param name="sid">The source to be queried.</param>
        /// <returns>state information from OpenAL.</returns>
        public static ALSourceState GetSourceState(uint sid)
        {
            GetSource(sid, ALGetSourcei.SourceState, out int temp);
            return (ALSourceState)temp;
        }

        /// <summary>
        /// (Helper) Returns Source state information.
        /// </summary>
        /// <param name="sid">The source to be queried.</param>
        /// <returns>state information from OpenAL.</returns>
        public static ALSourceState GetSourceState(int sid)
        {
            GetSource(sid, ALGetSourcei.SourceState, out int temp);
            return (ALSourceState)temp;
        }

        /// <summary>
        /// (Helper) Returns Source type information.
        /// </summary>
        /// <param name="sid">The source to be queried.</param>
        /// <returns>type information from OpenAL.</returns>
        public static ALSourceType GetSourceType(uint sid)
        {
            GetSource(sid, ALGetSourcei.SourceType, out int temp);
            return (ALSourceType)temp;
        }

        /// <summary>
        /// (Helper) Returns Source type information.
        /// </summary>
        /// <param name="sid">The source to be queried.</param>
        /// <returns>type information from OpenAL.</returns>
        public static ALSourceType GetSourceType(int sid)
        {
            GetSource(sid, ALGetSourcei.SourceType, out int temp);
            return (ALSourceType)temp;
        }

        /// <summary>
        /// Returns the <see cref="ALDistanceModel" /> of the current context.
        /// </summary>
        /// <returns>The <see cref="ALDistanceModel" /> of the current context.</returns>
        public static ALDistanceModel GetDistanceModel()
        {
            return (ALDistanceModel)Get(ALGetInteger.DistanceModel);
        }
    }
}
