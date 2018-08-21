/* XRamExtension.cs
 * C header: \OpenAL 1.1 SDK\include\xram.h
 * Spec: ?
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details (MIT)
 * http://www.OpenTK.net */

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// The X-Ram Extension is provided on the top-end Sound Blaster X-Fi solutions (Sound Blaster X-Fi Fatal1ty, Sound
    /// Blaster X-Fi Elite Pro, or later).
    /// These products feature 64MB of X-Ram that can only be used for audio purposes, which can be controlled by this
    /// Extension.
    /// </summary>
    public sealed class XRamExtension
    {
        /// <summary>
        /// This enum is used to abstract the need of using AL.GetEnumValue() with the Extension. The values do NOT
        /// correspond to AL_STORAGE_* tokens!.
        /// </summary>
        public enum XRamStorage : byte
        {
            /// <summary>
            /// Put an Open AL Buffer into X-RAM if memory is available, otherwise use host RAM.  This is the default mode.
            /// </summary>
            Automatic = 0,

            /// <summary>
            /// Force an Open AL Buffer into X-RAM, good for non-streaming buffers.
            /// </summary>
            Hardware = 1,

            /// <summary>
            /// Force an Open AL Buffer into 'accessible' (currently host) RAM, good for streaming buffers.
            /// </summary>
            Accessible = 2,
        }

        private readonly int _eaxRamFree;

        private readonly int _eaxRamSize;
        private readonly int _storageAccessible;

        private readonly int _storageAutomatic;
        private readonly int _storageHardware;

        private readonly Delegates.GetBufferMode _eAxGetBufferMode;

        private readonly Delegates.SetBufferMode _eAxSetBufferMode;

        /// <summary>
        /// Initializes a new instance of the <see cref="XRamExtension"/> class.
        /// </summary>
        public XRamExtension()
        {
            IsInitialized = false;
            if (AL.IsExtensionPresent("EAX-RAM") == false)
            {
                return;
            }

            _eaxRamSize = AL.GetEnumValue("AL_EAX_RAM_SIZE");
            _eaxRamFree = AL.GetEnumValue("AL_EAX_RAM_FREE");
            _storageAutomatic = AL.GetEnumValue("AL_STORAGE_AUTOMATIC");
            _storageHardware = AL.GetEnumValue("AL_STORAGE_HARDWARE");
            _storageAccessible = AL.GetEnumValue("AL_STORAGE_ACCESSIBLE");

            if (_eaxRamSize == 0 ||
                _eaxRamFree == 0 ||
                _storageAutomatic == 0 ||
                _storageHardware == 0 ||
                _storageAccessible == 0)
            {
                Debug.WriteLine("X-Ram: Token values could not be retrieved.");
                return;
            }

            try
            {
                _eAxGetBufferMode =
                    (Delegates.GetBufferMode)Marshal.GetDelegateForFunctionPointer(
                        AL.GetProcAddress("EAXGetBufferMode"), typeof(Delegates.GetBufferMode));
                _eAxSetBufferMode =
                    (Delegates.SetBufferMode)Marshal.GetDelegateForFunctionPointer(
                        AL.GetProcAddress("EAXSetBufferMode"), typeof(Delegates.SetBufferMode));
            }
            catch (Exception e)
            {
                Debug.WriteLine("X-Ram: Attempt to marshal function pointers with AL.GetProcAddress failed. " + e);
                return;
            }

            IsInitialized = true;
        }

        /// <summary>
        /// Gets a value indicating whether the X-Ram Extension has been found and could be initialized.
        /// </summary>
        public bool IsInitialized { get; }

        /// <summary>
        /// Gets total amount of X-RAM in bytes.
        /// </summary>
        public int GetRamSize => AL.Get((ALGetInteger)_eaxRamSize);

        /// <summary>
        /// Gets free X-RAM available in bytes.
        /// </summary>
        public int GetRamFree => AL.Get((ALGetInteger)_eaxRamFree);

        /// <summary>
        /// This function is used to set the storage Mode of an array of OpenAL Buffers.
        /// </summary>
        /// <param name="n">The number of OpenAL Buffers pointed to by buffer.</param>
        /// <param name="buffer">An array of OpenAL Buffer handles.</param>
        /// <param name="mode">
        /// The storage mode that should be used for all the given buffers. Should be the value of one of the
        /// following enum names: XRamStorage.Automatic, XRamStorage.Hardware, XRamStorage.Accessible.
        /// </param>
        /// <returns>True if all the Buffers were successfully set to the requested storage mode, False otherwise.</returns>
        public bool SetBufferMode(int n, ref uint buffer, XRamStorage mode)
        {
            switch (mode)
            {
                case XRamStorage.Accessible:
                    return _eAxSetBufferMode(n, ref buffer, _storageAccessible);
                case XRamStorage.Hardware:
                    return _eAxSetBufferMode(n, ref buffer, _storageHardware);
                default:
                    return _eAxSetBufferMode(n, ref buffer, _storageAutomatic);
            }
        }

        /// <summary>
        /// This function is used to set the storage Mode of an array of OpenAL Buffers.
        /// </summary>
        /// <param name="n">The number of OpenAL Buffers pointed to by buffer.</param>
        /// <param name="buffer">An array of OpenAL Buffer handles.</param>
        /// <param name="mode">
        /// The storage mode that should be used for all the given buffers. Should be the value of one of the
        /// following enum names: XRamStorage.Automatic, XRamStorage.Hardware, XRamStorage.Accessible.
        /// </param>
        /// <returns>True if all the Buffers were successfully set to the requested storage mode, False otherwise.</returns>
        public bool SetBufferMode(int n, ref int buffer, XRamStorage mode)
        {
            var temp = (uint)buffer;
            return SetBufferMode(n, ref temp, mode);
        }

        /// <summary>
        /// This function is used to retrieve the storage Mode of a single OpenAL Buffer.
        /// </summary>
        /// <param name="buffer">The handle of an OpenAL Buffer.</param>
        /// <returns>The current Mode of the Buffer.</returns>
        public XRamStorage GetBufferMode(ref uint buffer)
        {
            var tempresult = _eAxGetBufferMode(buffer, IntPtr.Zero); // IntPtr.Zero due to the parameter being unused/reserved atm

            if (tempresult == _storageAccessible)
            {
                return XRamStorage.Accessible;
            }

            if (tempresult == _storageHardware)
            {
                return XRamStorage.Hardware;
            }

            return XRamStorage.Automatic;
        }

        /// <summary>
        /// This function is used to retrieve the storage Mode of a single OpenAL Buffer.
        /// </summary>
        /// <param name="buffer">The handle of an OpenAL Buffer.</param>
        /// <returns>The current Mode of the Buffer.</returns>
        public XRamStorage GetBufferMode(ref int buffer)
        {
            var temp = (uint)buffer;
            return GetBufferMode(ref temp);
        }

        private class Delegates
        {
            internal delegate bool SetBufferMode(int n, ref uint buffers, int value);

            internal delegate int GetBufferMode(uint buffer, IntPtr value);
        }
    }
}
