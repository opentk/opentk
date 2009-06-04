#region --- OpenTK.OpenAL License ---
/* AlutTokens.cs
 * C header: \freealut-1.1.0-src\include\AL\Alut.h
 * Spec: http://www.openal.org/openal_webstf/specs/alut.html
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
#endregion

using System;

namespace OpenTK.Audio
{
    /// <summary>
    /// Defines the version of the Alut library.
    /// </summary>
    public enum AlutVersions : int
    {
        /// <summary>Defines the A in OpenAL A.B</summary>
        ApiMajorVersion = 1,
        /// <summary>Defines the B in OpenAL A.B</summary>
        ApiMinorVersion = 1,
    }

    /// <summary>
    /// Defines available alut error codes.
    /// </summary>
    public enum AlutError : int
    {
        /// <summary>No ALUT error found.</summary>
        NoError = 0,
        /// <summary>ALUT ran out of memory.</summary>
        OutOfMemory = 0x200,
        /// <summary>ALUT was given an invalid enumeration token.</summary>
        InvalidEnum = 0x201,
        /// <summary>ALUT was given an invalid value.</summary>
        InvalidValue = 0x202,
        /// <summary>The operation is invalid in the current ALUT state.</summary>
        InvalidOperation = 0x203,
        /// <summary>There is no current AL context.</summary>
        NoCurrentContext = 0x204,
        /// <summary>There was already an AL error on entry to an ALUT function.</summary>
        AlErrorOnEntry = 0x205,
        /// <summary>There was already an ALC error on entry to an ALUT function.</summary>
        AlcErrorOnEntry = 0x206,
        /// <summary>There was an error opening the ALC device.</summary>
        OpenDevice = 0x207,
        /// <summary>There was an error closing the ALC device.</summary>
        CloseDevice = 0x208,
        /// <summary>There was an error creating an ALC context.</summary>
        CreateContext = 0x209,
        /// <summary>Could not change the current ALC context.</summary>
        MakeContextCurrent = 0x20A,
        /// <summary>There was an error destroying the ALC context.</summary>
        DestroyContext = 0x20B,
        /// <summary>There was an error generating an AL buffer.</summary>
        GenBuffers = 0x20C,
        /// <summary>There was an error passing buffer buffer to AL.</summary>
        BufferData = 0x20D,
        /// <summary>I/O error, consult errno for more details.</summary>
        IoError = 0x20E,
        /// <summary>Unsupported file type.</summary>
        UnsupportedFileType = 0x20F,
        /// <summary>Unsupported mode within an otherwise usable file type.</summary>
        UnsupportedFileSubtype = 0x210,
        /// <summary>The sound buffer was corrupt or truncated.</summary>
        CorruptOrTruncatedData = 0x211,
    }

    /// <summary>
    /// Defines available alut waveform types.
    /// </summary>
    public enum AlutWaveform : int
    {
        /// <summary>A sine waveform</summary>
        Sine = 0x100,
        /// <summary>A square waveform</summary>
        Square = 0x101,
        /// <summary>A sawtooth waveform</summary>
        SawTooth = 0x102,
        /// <summary>A waveform containing white noise</summary>
        WhiteNoise = 0x103,
        /// <summary>A waveform containing an impusle</summary>
        Impulse = 0x104,
    }

    /// <summary>
    /// Defines parameters for alut loaders.
    /// </summary>
    public enum AlutLoader : int
    {
        ///<summary>For the loaders returning sound buffer in an OpenAL buffer, e.g. Alut.CreateBufferFromFile and Alut.CreateBufferFromFileImage</summary>
        Buffer = 0x300,
        ///<summary>For the loaders returning sound buffer in a newly allocated memory region, e.g. Alut.LoadMemoryFromFile and Alut.LoadMemoryFromFileImage.</summary>
        Memory = 0x301,
    }

}
