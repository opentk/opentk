#region --- OpenTK.OpenAL License ---
/* XRamExtension.cs
 * C header: \OpenAL 1.1 SDK\include\xram.h
 * Spec: ?
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details (MIT)
 * http://www.OpenTK.net */
#endregion

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Audio.OpenAL
{

    ///<summary>
    ///The X-Ram Extension is provided on the top-end Sound Blaster X-Fi solutions (Sound Blaster X-Fi Fatal1ty, Sound Blaster X-Fi Elite Pro, or later).
    ///These products feature 64MB of X-Ram that can only be used for audio purposes, which can be controlled by this Extension.
    ///</summary>
    [CLSCompliant(true)]
    public sealed class XRamExtension
    {
        #region Instance state

        private bool _valid = false;

        /// <summary>Returns True if the X-Ram Extension has been found and could be initialized.</summary>
        public bool IsInitialized
        {
            get { return _valid; }
        }

        #endregion Instance state

        #region X-RAM Function pointer definitions

        // [CLSCompliant(false)]
        private delegate bool Delegate_SetBufferMode(int n, ref uint buffers, int value);
        //typedef ALboolean (__cdecl *EAXSetBufferMode)(ALsizei n, ALuint *buffers, ALint value);

        // [CLSCompliant( false )]
        private delegate int Delegate_GetBufferMode(uint buffer, IntPtr value);
        //typedef ALenum    (__cdecl *EAXGetBufferMode)(ALuint buffer, ALint *value);

        //[CLSCompliant(false)]
        private Delegate_SetBufferMode Imported_SetBufferMode;
        //[CLSCompliant(false)]
        private Delegate_GetBufferMode Imported_GetBufferMode;

        #endregion X-RAM Function pointer definitions

        #region X-RAM Tokens

        private int AL_EAX_RAM_SIZE, AL_EAX_RAM_FREE,
                    AL_STORAGE_AUTOMATIC, AL_STORAGE_HARDWARE, AL_STORAGE_ACCESSIBLE;

        #endregion X-RAM Tokens

        #region Constructor / Extension Loading

        /// <summary>
        /// Constructs a new XRamExtension instance.
        /// </summary>
        public XRamExtension()
        { // Query if Extension supported and retrieve Tokens/Pointers if it is.
            _valid = false;
            if (AL.IsExtensionPresent("EAX-RAM") == false)
                return;

            AL_EAX_RAM_SIZE = AL.GetEnumValue("AL_EAX_RAM_SIZE");
            AL_EAX_RAM_FREE = AL.GetEnumValue("AL_EAX_RAM_FREE");
            AL_STORAGE_AUTOMATIC = AL.GetEnumValue("AL_STORAGE_AUTOMATIC");
            AL_STORAGE_HARDWARE = AL.GetEnumValue("AL_STORAGE_HARDWARE");
            AL_STORAGE_ACCESSIBLE = AL.GetEnumValue("AL_STORAGE_ACCESSIBLE");

            // Console.WriteLine("RamSize: {0} RamFree: {1} StorageAuto: {2} StorageHW: {3} StorageAccess: {4}",AL_EAX_RAM_SIZE,AL_EAX_RAM_FREE,AL_STORAGE_AUTOMATIC,AL_STORAGE_HARDWARE,AL_STORAGE_ACCESSIBLE);

            if (AL_EAX_RAM_SIZE == 0 ||
                 AL_EAX_RAM_FREE == 0 ||
                 AL_STORAGE_AUTOMATIC == 0 ||
                 AL_STORAGE_HARDWARE == 0 ||
                 AL_STORAGE_ACCESSIBLE == 0)
            {
                Debug.WriteLine("X-Ram: Token values could not be retrieved.");
                return;
            }

            // Console.WriteLine("Free Ram: {0} / {1}",GetRamFree( ),GetRamSize( ));

            try
            {
                Imported_GetBufferMode = (Delegate_GetBufferMode)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("EAXGetBufferMode"), typeof(Delegate_GetBufferMode));
                Imported_SetBufferMode = (Delegate_SetBufferMode)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("EAXSetBufferMode"), typeof(Delegate_SetBufferMode));
            }
            catch (Exception e)
            {
                Debug.WriteLine("X-Ram: Attempt to marshal function pointers with AL.GetProcAddress failed. " + e.ToString());
                return;
            }

            _valid = true;
        }

        #endregion Constructor / Extension Loading

        #region Public Methods

        /// <summary>Query total amount of X-RAM in bytes.</summary>
        public int GetRamSize
        {
            get
            {
                return AL.Get((ALGetInteger)AL_EAX_RAM_SIZE);
            }
        }

        /// <summary>Query free X-RAM available in bytes.</summary>
        public int GetRamFree
        {
            get
            {
                return AL.Get((ALGetInteger)AL_EAX_RAM_FREE);
            }
        }

        /// <summary>This enum is used to abstract the need of using AL.GetEnumValue() with the Extension. The values do NOT correspond to AL_STORAGE_* tokens!</summary>
        public enum XRamStorage : byte
        {
            /// <summary>Put an Open AL Buffer into X-RAM if memory is available, otherwise use host RAM.  This is the default mode.</summary>
            Automatic = 0,
            /// <summary>Force an Open AL Buffer into X-RAM, good for non-streaming buffers.</summary>
            Hardware = 1,
            /// <summary>Force an Open AL Buffer into 'accessible' (currently host) RAM, good for streaming buffers.</summary>
            Accessible = 2,
        }

        /// <summary>This function is used to set the storage Mode of an array of OpenAL Buffers.</summary>
        /// <param name="n">The number of OpenAL Buffers pointed to by buffer.</param>
        /// <param name="buffer">An array of OpenAL Buffer handles.</param>
        /// <param name="mode">The storage mode that should be used for all the given buffers. Should be the value of one of the following enum names: XRamStorage.Automatic, XRamStorage.Hardware, XRamStorage.Accessible</param>
        /// <returns>True if all the Buffers were successfully set to the requested storage mode, False otherwise.</returns>
        [CLSCompliant(false)]
        public bool SetBufferMode(int n, ref uint buffer, XRamStorage mode)
        {
            switch (mode)
            {
                case XRamStorage.Accessible:
                    return Imported_SetBufferMode(n, ref buffer, AL_STORAGE_ACCESSIBLE);
                case XRamStorage.Hardware:
                    return Imported_SetBufferMode(n, ref buffer, AL_STORAGE_HARDWARE);
                default:
                    return Imported_SetBufferMode(n, ref buffer, AL_STORAGE_AUTOMATIC);
            }
        }

        /// <summary>This function is used to set the storage Mode of an array of OpenAL Buffers.</summary>
        /// <param name="n">The number of OpenAL Buffers pointed to by buffer.</param>
        /// <param name="buffer">An array of OpenAL Buffer handles.</param>
        /// <param name="mode">The storage mode that should be used for all the given buffers. Should be the value of one of the following enum names: XRamStorage.Automatic, XRamStorage.Hardware, XRamStorage.Accessible</param>
        /// <returns>True if all the Buffers were successfully set to the requested storage mode, False otherwise.</returns>
        [CLSCompliant(true)]
        public bool SetBufferMode(int n, ref int buffer, XRamStorage mode)
        {
            uint temp = (uint)buffer;
            return SetBufferMode(n, ref temp, mode);
        }

        /// <summary>This function is used to retrieve the storage Mode of a single OpenAL Buffer.</summary>
        /// <param name="buffer">The handle of an OpenAL Buffer.</param>
        /// <returns>The current Mode of the Buffer.</returns>
        [CLSCompliant(false)]
        public XRamStorage GetBufferMode(ref uint buffer)
        {
            int tempresult = Imported_GetBufferMode(buffer, IntPtr.Zero); // IntPtr.Zero due to the parameter being unused/reserved atm

            if (tempresult == AL_STORAGE_ACCESSIBLE)
                return XRamStorage.Accessible;
            if (tempresult == AL_STORAGE_HARDWARE)
                return XRamStorage.Hardware;
            // default:
            return XRamStorage.Automatic;
        }

        /// <summary>This function is used to retrieve the storage Mode of a single OpenAL Buffer.</summary>
        /// <param name="buffer">The handle of an OpenAL Buffer.</param>
        /// <returns>The current Mode of the Buffer.</returns>
        [CLSCompliant(true)]
        public XRamStorage GetBufferMode(ref int buffer)
        {
            uint temp = (uint)buffer;
            return GetBufferMode(ref temp);
        }

        #endregion Public Methods
    }

}

