#region --- OpenTK.OpenAL License ---
/* XRamExtension.cs
 * C header: \OpenAL 1.1 SDK\include\xram.h
 * Spec: ?
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details (MIT)
 * http://www.OpenTK.net */
#endregion

using System;
using System.Runtime.InteropServices;

namespace OpenTK.OpenAL
{

    public class XRamExtension
    {
        #region instance state

        private bool _valid = false;

        /// <summary>Returns True if the X-Ram Extension has been found and could be initialized.</summary>
        public bool IsInitialized
        {
            get { return _valid; }
        }

        #endregion instance state

        #region X-RAM Function pointer definitions

        public unsafe delegate AL.Bool SetBufferMode(int n, ref uint buffers, int value);
        //typedef ALboolean (__cdecl *EAXSetBufferMode)(ALsizei n, ALuint *buffers, ALint value);

        public delegate int GetBufferMode(uint buffer, out int value);
        //typedef ALenum    (__cdecl *EAXGetBufferMode)(ALuint buffer, ALint *value);

        public SetBufferMode EAXSetBufferMode;
        public GetBufferMode EAXGetBufferMode;

        #endregion X-RAM Function pointer definitions

        #region X-RAM Tokens

        private int AL_EAX_RAM_SIZE, AL_EAX_RAM_FREE,
                    AL_STORAGE_AUTOMATIC, AL_STORAGE_HARDWARE, AL_STORAGE_ACCESSIBLE;

        #endregion X-RAM Tokens

        #region Constructor / Extension Loading

        public XRamExtension()
        { // Query if Extension supported and retrieve Tokens/Pointers if it is.
            _valid = false;
            if (AL.IsExtensionPresent("EAX-RAM") == AL.Bool.False)
                return;

            AL_EAX_RAM_SIZE = AL.GetEnumValue("AL_EAX_RAM_SIZE");
            AL_EAX_RAM_FREE = AL.GetEnumValue("AL_EAX_RAM_FREE");
            AL_STORAGE_AUTOMATIC = AL.GetEnumValue("AL_STORAGE_AUTOMATIC");
            AL_STORAGE_HARDWARE = AL.GetEnumValue("AL_STORAGE_HARDWARE");
            AL_STORAGE_ACCESSIBLE = AL.GetEnumValue("AL_STORAGE_ACCESSIBLE");

            Console.WriteLine("RamSize: {0} RamFree: {1} StorageAuto: {2} StorageHW: {3} StorageAccess: {4}", AL_EAX_RAM_SIZE, AL_EAX_RAM_FREE, AL_STORAGE_AUTOMATIC, AL_STORAGE_HARDWARE, AL_STORAGE_ACCESSIBLE);

            if (AL_EAX_RAM_SIZE == 0 ||
                 AL_EAX_RAM_FREE == 0 ||
                 AL_STORAGE_AUTOMATIC == 0 ||
                 AL_STORAGE_HARDWARE == 0 ||
                 AL_STORAGE_ACCESSIBLE == 0)
            {
                Console.WriteLine("Token values could not be retrieved.");
                return;
            }

            Console.WriteLine("Free Ram: {0} / {1}", GetRamFree(), GetRamSize());

            try
            {
                EAXGetBufferMode = (GetBufferMode)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("EAXGetBufferMode"), typeof(GetBufferMode));
                EAXSetBufferMode = (SetBufferMode)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("EAXSetBufferMode"), typeof(SetBufferMode));
            }
            catch (Exception e)
            {
                Console.WriteLine("Attempt to marshal AL.GetProcAddress failed. " + e.ToString());
                return;
            }

            _valid = true;
        }

        #endregion Constructor / Extension Loading

        #region Public Methods

        /// <summary>Query total amount of X-RAM.</summary>
        public int GetRamSize()
        {
            return AL.Get((Enums.ALGetInteger)AL_EAX_RAM_SIZE);
        }

        /// <summary>Query free X-RAM available.</summary>
        public int GetRamFree()
        {
            return AL.Get((Enums.ALGetInteger)AL_EAX_RAM_FREE);
        }

        public enum XRamStorage : byte
        {
            /// <summary>Put an Open AL Buffer into X-RAM if memory is available, otherwise use host RAM.  This is the default mode.
            /// alGenBuffers(1, &uiBuffer);
            /// eaxSetBufferMode(1, &uiBuffer, alGetEnumValue("AL_STORAGE_AUTOMATIC"));
            /// alBufferData(...);
            /// </summary>
            Automatic,
            /// <summary>Force an Open AL Buffer into X-RAM (good for non-streaming buffers)
            // alGenBuffers(1, &uiBuffer);
            // eaxSetBufferMode(1, &uiBuffer, alGetEnumValue("AL_STORAGE_HARDWARE"));
            // alBufferData(...);
            /// </summary>
            Hardware = 1,
            /// <summary>Force an Open AL Buffer into 'accessible' (currently host) RAM (good for streaming buffers)
            /// alGenBuffers(1, &uiBuffer);
            /// eaxSetBufferMode(1, &uiBuffer, alGetEnumValue("AL_STORAGE_ACCESSIBLE"));
            /// alBufferData(...);
            /// </summary>
            Acessible = 2,

        }

        public void _SetBufferMode(ref uint buffer, XRamStorage mode)
        {
            switch (mode)
            {
                case XRamStorage.Acessible:
                    EAXSetBufferMode(1, ref buffer, AL_STORAGE_ACCESSIBLE);
                    break;
                case XRamStorage.Hardware:
                    EAXSetBufferMode(1, ref buffer, AL_STORAGE_HARDWARE);
                    break;
                default:
                    EAXSetBufferMode(1, ref buffer, AL_STORAGE_AUTOMATIC);
                    break;
            }
        }

        #endregion Public Methods
    }
}