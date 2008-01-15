#region --- OpenTK.OpenAL License ---
/* AlutFunctions.cs
 * C header: \freealut-1.1.0-src\include\AL\Alut.h
 * Spec: http://www.openal.org/openal_webstf/specs/alut.html
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
#endregion

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenTK.OpenAL
{

    /// <summary>Alut, FreeAlut = Free Audio Library Utilities</summary>
    public static class Alut
    {
        #region Constants

        private const string Lib = "alut.dll";
        private const CallingConvention Style = CallingConvention.Cdecl;

        #endregion Constants

        #region Init/Exit

        /// <summary>Alut.Init initializes the ALUT internals and creates an OpenAL context on the default device and makes it the current OpenAL context. If you want something more complex than that (e.g. running on a non-default device or opening multiple contexts on multiple devices), you can use alutInitWithoutContext  instead. alutInit examines the commandline arguments passed to it and remove those it recognizes. It is acceptable to pass two NULL  pointers in settings where no useful information can be obtained from argc and argv.</summary>
        /// <param name="argcp">Application Main Parameters. Can be IntPtr.Zero.</param>
        /// <param name="argv">Application Main Parameters. Can be IntPtr.Zero.</param>
        /// <returns>Success.</returns>
        [DllImport(Alut.Lib, EntryPoint = "alutInit", ExactSpelling = true, CallingConvention = Alut.Style), SuppressUnmanagedCodeSecurity()]
        public static extern AL.Bool Init([In] IntPtr argcp, [In] IntPtr argv);
        // ALUT_API ALboolean ALUT_APIENTRY alutInit (int *argcp, char **argv);

        /// <summary>Parameterless function for convenience. Internally passes IntPtr.Zero as parameters.</summary>
        /// <returns>Success.</returns>
        public static AL.Bool Init() // overload for convenience
        {
            return Init(IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>Alut.InitWithoutContext initializes the ALUT internals. It does not create any OpenAL context or device, so this has to be done via the usual ALC calls. alutInitWithoutContext examines the commandline arguments passed to it and remove those it recognizes. It is acceptable to pass two NULL pointers in settings where no useful information can be obtained from argc and argv.</summary>
        /// <param name="argcp">Application Main Parameters</param>
        /// <param name="argv">Application Main Parameters</param>
        /// <returns>Success.</returns>
        [DllImport(Alut.Lib, EntryPoint = "alutInitWithoutContext", ExactSpelling = true, CallingConvention = Alut.Style), SuppressUnmanagedCodeSecurity()]
        public static extern AL.Bool InitWithoutContext([In] IntPtr argcp, [In] IntPtr argv);
        // ALUT_API ALboolean ALUT_APIENTRY alutInitWithoutContext (int *argcp, char **argv);

        /// <summary>Alut.InitWithoutContext initializes the ALUT internals. It does not create any OpenAL context or device, so this has to be done via the usual ALC calls. alutInitWithoutContext examines the commandline arguments passed to it and remove those it recognizes. It is acceptable to pass two NULL pointers in settings where no useful information can be obtained from argc and argv.</summary>
        /// <returns>Success.</returns>
        public static AL.Bool InitWithoutContext() // overload for convenience
        {
            return InitWithoutContext(IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>When the application has finished playing audio, it should shut down ALUT using Alut.Exit. This closes any OpenAL device/context that ALUT may have created in alutInit (but not any that the application created using ALC). After calling alutExit, you may subsequently call alutInit or alutInitWithoutContext again. Note that under well-behaved operating systems, it should be acceptable to simply exit from your program without bothering to call alutExit, relying on the OS to clean up after you. However, it is dangerous to rely on this behavior if portable operation is expected.</summary>
        /// <returns>Success.</returns>
        [DllImport(Alut.Lib, EntryPoint = "alutExit", ExactSpelling = true, CallingConvention = Alut.Style), SuppressUnmanagedCodeSecurity()]
        public static extern AL.Bool Exit();
        // ALUT_API ALboolean ALUT_APIENTRY alutExit (void);

        #endregion Init/Exit

        #region Error Checking

        /// <summary>Any ALUT routine that fails will return AL_FALSE / AL_NONE / NULL and set the global error state. If a subsequent error occurs while there is still an error recorded internally, the second error will simply be ignored. Calling alutGetError will reset the error code to ALUT_ERROR_NO_ERROR. Note that the error state is not cleared by other successful ALUT calls. Alut.GetError can be called in any ALUT state and will never fail.</summary>
        /// <returns><see cref="Enums.AlutError"/></returns>
        [DllImport(Alut.Lib, EntryPoint = "alutGetError", ExactSpelling = true, CallingConvention = Alut.Style), SuppressUnmanagedCodeSecurity()]
        public static extern Enums.AlutError GetError();
        // ALUT_API ALenum ALUT_APIENTRY alutGetError (void);

        [DllImport(Alut.Lib, EntryPoint = "alutGetErrorString", ExactSpelling = true, CallingConvention = Alut.Style, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity()]
        private static extern IntPtr GetErrorStringPrivate(Enums.AlutError error);
        // ALUT_API const char *ALUT_APIENTRY alutGetErrorString (ALenum error);

        /// <summary>Alut.GetErrorString can be used to convert an error code into a human-readable description. The precise text of these descriptions may vary from implementation to implementation and should not be relied upon by the application.</summary>
        /// <param name="error">Retrieve first occured error with Alut.GetError</param>
        /// <returns>A human-readable description of the Error.</returns>
        public static string GetErrorString(Enums.AlutError error)
        {
            return Marshal.PtrToStringAnsi(GetErrorStringPrivate(error));
        }

        #endregion Error Checking

        #region File Loading

        /// <summary>Alut.CreateBufferFromFile tries to guess the sound data format by looking at the filename and/or the file contents and loads the sound data into an OpenAL buffer.</summary>
        /// <param name="filename">The file to be loaded</param>
        /// <returns>OpenAL Buffer, 0 on failure.</returns>
        [CLSCompliant(false), DllImport(Alut.Lib, EntryPoint = "alutCreateBufferFromFile", ExactSpelling = true, CallingConvention = Alut.Style, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity()]
        public static extern uint CreateBufferFromFile([In] string filename);
        // ALUT_API ALuint ALUT_APIENTRY alutCreateBufferFromFile (const char *fileName); 

        /// <summary>Alut.CreateBufferFromFileImage tries to guess the sound data format by looking at the contents of the memory region given as parameters and loads the sound data into an OpenAL buffer.</summary>
        /// <param name="data">A Pointer to the sound data in memory.</param>
        /// <param name="length">Size in Bytes of the sound data.</param>
        /// <returns>OpenAL Buffer, 0 on failure.</returns>
        [CLSCompliant(false), DllImport(Alut.Lib, EntryPoint = "alutCreateBufferFromFileImage", ExactSpelling = true, CallingConvention = Alut.Style), SuppressUnmanagedCodeSecurity()]
        public static extern uint CreateBufferFromFileImage([In] IntPtr data, int length);
        // ALUT_API ALuint ALUT_APIENTRY alutCreateBufferFromFileImage (const ALvoid *data, ALsizei length);


        /// <summary>Alut.CreateBufferHelloWorld returns a handle to an OpenAL buffer containing the sound of someone saying 'Hello, world!'.</summary>
        /// <returns>OpenAL Buffer, 0 on failure.</returns>
        [CLSCompliant(false), DllImport(Alut.Lib, EntryPoint = "alutCreateBufferHelloWorld", ExactSpelling = true, CallingConvention = Alut.Style), SuppressUnmanagedCodeSecurity()]
        public static extern uint CreateBufferHelloWorld();
        //ALUT_API ALuint ALUT_APIENTRY alutCreateBufferHelloWorld (void);

        /// <summary>Alut.CreateBufferWaveform returns a handle to an OpenAL buffer containing a snippet of audio with the specified waveshape at the specified frequency (in Hertz), phase (in degrees: -180 to +180) and duration (in seconds).</summary>
        /// <param name="waveshape"></param>
        /// <param name="frequency">Frequency in Hertz [Hz].</param>
        /// <param name="phase">Phase (in degrees: -180 to +180)</param>
        /// <param name="duration">Duration (in seconds)</param>
        /// <returns>OpenAL Buffer, 0 on failure.</returns>
        [CLSCompliant(false), DllImport(Alut.Lib, EntryPoint = "alutCreateBufferWaveform", ExactSpelling = true, CallingConvention = Alut.Style), SuppressUnmanagedCodeSecurity()]
        public static extern uint CreateBufferWaveform(Enums.AlutWaveform waveshape, float frequency, float phase, float duration);
        // ALUT_API ALuint ALUT_APIENTRY alutCreateBufferWaveform (ALenum waveshape, ALfloat frequency, ALfloat phase, ALfloat duration);

        // Warning: these leak memory if not properly free'd
        // ALUT_API ALvoid *ALUT_APIENTRY alutLoadMemoryFromFile (const char *fileName, ALenum *format, ALsizei *size, ALfloat *frequency);
        // ALUT_API ALvoid *ALUT_APIENTRY alutLoadMemoryFromFileImage (const ALvoid *data, ALsizei length, ALenum *format, ALsizei *size, ALfloat *frequency);
        // ALUT_API ALvoid *ALUT_APIENTRY alutLoadMemoryHelloWorld (ALenum *format, ALsizei *size, ALfloat *frequency);
        // ALUT_API ALvoid *ALUT_APIENTRY alutLoadMemoryWaveform (ALenum waveshape, ALfloat frequency, ALfloat phase, ALfloat duration, ALenum *format, ALsizei *size, ALfloat *freq);

        #endregion File Loading

        #region Misc
        [DllImport(Alut.Lib, EntryPoint = "alutGetMIMETypes", ExactSpelling = true, CallingConvention = Alut.Style, CharSet = CharSet.Ansi), SuppressUnmanagedCodeSecurity()]
        private static extern IntPtr GetMIMETypesPrivate(Enums.AlutLoader loader);
        // ALUT_API const char *ALUT_APIENTRY alutGetMIMETypes (ALenum loader); 

        /// <summary>Alut.GetMIMETypes returns a comma-separated list of supported MIME types for the given loader type, e.g. something like "audio/basic,audio/mpeg,audio/x-wav". 
        /// It is possible that Enums.AlutLoader.Memory loaders will be unable to support some file types that Enums.AlutLoader.Buffer loaders can support (although the reverse is never the case). Furthermore, it is possible that for some file types (notably audio/x-wav) the support may be only for a few sub-formats. For example, an implementation may advertise that audio/x-wav is supported when in fact it only supports uncompressed (i.e. PCM) WAV files and not any of the compressed subformats. In this event, the various ALUT loaders may return an error and set ALUT_ERROR_UNSUPPORTED_FILE_SUBTYPE rather than ALUT_ERROR_UNSUPPORTED_FILE_TYPE which would indicate that no files of this type are allowed.
        /// </summary>
        /// <param name="loader"><see cref="Enums.AlutLoader"/></param>
        /// <returns>A comma-separated list of supported MIME types.</returns>
        public static string GetMIMETypes(Enums.AlutLoader loader)
        {
            return Marshal.PtrToStringAnsi(GetMIMETypesPrivate(loader));
        }

        /// <summary>Alut.GetMajorVersion returns the major version number of the ALUT in use, which will match the major version number of the corresponding ALUT specification document. Can be compared using Enums.AlutVersions.</summary>
        /// <returns>Major Version Number.</returns>
        [DllImport(Alut.Lib, EntryPoint = "alutGetMajorVersion", ExactSpelling = true, CallingConvention = Alut.Style), SuppressUnmanagedCodeSecurity()]
        public static extern int GetMajorVersion();
        // ALUT_API ALint ALUT_APIENTRY alutGetMajorVersion (void);

        /// <summary>Alut.GetMinorVersion returns the minor version number of the ALUT in use, which will match the minor version number of the corresponding ALUT specification document. Can be compared using Enums.AlutVersions.</summary>
        /// <returns>Minor Version Number.</returns>
        [DllImport(Alut.Lib, EntryPoint = "alutGetMinorVersion", ExactSpelling = true, CallingConvention = Alut.Style), SuppressUnmanagedCodeSecurity()]
        public static extern int GetMinorVersion();
        // ALUT_API ALint ALUT_APIENTRY alutGetMinorVersion (void);

        /*
        /// <summary>Alut.Sleep will delay the execution of the current thread for at least the given amount of seconds. It will only return earlier if a signal has been delivered to the thread, but this does not count as an error. Note that sleeping for zero seconds will give other runnable threads a chance to run.
        /// Having a general utility function like the following in an audio-related toolkit might seem strange at first, but sleeping is a common task in a lot of audio demos and it can't be done portably without cluttering the source code with #ifdefs.
        /// </summary>
        /// <param name="duration">Number of seconds. May not be negative.</param>
        /// <returns>Success.</returns>
        [DllImport( Alut.Lib, EntryPoint = "alutSleep", ExactSpelling = true, CallingConvention = Alut.Style ), SuppressUnmanagedCodeSecurity( )]
        public static extern AL.Bool Sleep( float duration );
        // ALUT_API ALboolean ALUT_APIENTRY alutSleep (ALfloat duration);
        */
        #endregion Misc
    }

}
