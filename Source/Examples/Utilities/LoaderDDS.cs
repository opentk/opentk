#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

// #define READALL
// uncomment so ALL fields read from file are interpreted and filled. Necessary to implement uncompressed DDS

// TODO: Find app that can build compressed dds cubemaps and verify that the import code works.

using System;
using System.IO;
using System.Diagnostics;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Examples.TextureLoaders
{
    /// <summary> 
    /// Expects the presence of a valid OpenGL Context and Texture Compression Extensions (GL 1.5) and Cube Maps (GL 1.3).
    /// You will get what you give. No automatic Mipmap generation or automatic compression is done. (both bad quality)
    /// Textures are never rescaled or checked if Power of 2, but you should make the Width and Height a multiple of 4 because DXTn uses 4x4 blocks.
    /// (Image displays correctly but runs extremely slow with non-power-of-two Textures on FX5600, Cache misses?)
    /// CubeMap support is experimental and the file must specify all 6 faces to work at all.
    /// </summary>
    static class ImageDDS
    {
        #region Constants
        private const byte HeaderSizeInBytes = 128; // all non-image data together is 128 Bytes
        private const uint BitMask = 0x00000007; // bits = 00 00 01 11
       

        private static NotImplementedException Unfinished = new NotImplementedException( "ERROR: Only 2 Dimensional DXT1/3/5 compressed images for now. 1D/3D Textures may not be compressed according to spec." );
        #endregion Constants

        #region Simplified In-Memory representation of the Image
        private static bool _IsCompressed;
        private static int _Width, _Height, _Depth, _MipMapCount;
        private static int _BytesForMainSurface; // must be handled with care when implementing uncompressed formats!
        private static byte _BytesPerBlock;
        private static PixelInternalFormat _PixelInternalFormat;
        #endregion Simplified In-Memory representation of the Image

        #region Flag Enums
        [Flags] // Surface Description
        private enum eDDSD: uint
        {
            CAPS = 0x00000001, // is always present
            HEIGHT = 0x00000002, // is always present
            WIDTH = 0x00000004, // is always present
            PITCH = 0x00000008, // is set if the image is uncompressed
            PIXELFORMAT = 0x00001000, // is always present
            MIPMAPCOUNT = 0x00020000, // is set if the image contains MipMaps
            LINEARSIZE = 0x00080000, // is set if the image is compressed
            DEPTH = 0x00800000 // is set for 3D Volume Textures
        }

        [Flags] // Pixelformat 
        private enum eDDPF: uint
        {
            NONE = 0x00000000, // not part of DX, added for convenience
            ALPHAPIXELS = 0x00000001,
            FOURCC = 0x00000004,
            RGB = 0x00000040,
            RGBA = 0x00000041
        }

        /// <summary>This list was derived from nVidia OpenGL SDK</summary>
        [Flags] // Texture types
        private enum eFOURCC: uint
        {
            UNKNOWN = 0,
#if READALL
            R8G8B8 = 20,
            A8R8G8B8 = 21,
            X8R8G8B8 = 22,
            R5G6B5 = 23,
            X1R5G5B5 = 24,
            A1R5G5B5 = 25,
            A4R4G4B4 = 26,
            R3G3B2 = 27,
            A8 = 28,
            A8R3G3B2 = 29,
            X4R4G4B4 = 30,
            A2B10G10R10 = 31,
            A8B8G8R8 = 32,
            X8B8G8R8 = 33,
            G16R16 = 34,
            A2R10G10B10 = 35,
            A16B16G16R16 = 36,

            L8 = 50,
            A8L8 = 51,
            A4L4 = 52,

            D16_LOCKABLE = 70,
            D32 = 71,
            D24X8 = 77,
            D16 = 80,

            D32F_LOCKABLE = 82,
            L16 = 81,

            // s10e5 formats (16-bits per channel)
            R16F = 111,
            G16R16F = 112,
            A16B16G16R16F = 113,

            // IEEE s23e8 formats (32-bits per channel)
            R32F = 114,
            G32R32F = 115,
            A32B32G32R32F = 116
#endif
            DXT1 = 0x31545844,
            DXT2 = 0x32545844,
            DXT3 = 0x33545844,
            DXT4 = 0x34545844,
            DXT5 = 0x35545844,
        }

        [Flags] // dwCaps1
        private enum eDDSCAPS: uint
        {
            NONE = 0x00000000, // not part of DX, added for convenience
            COMPLEX = 0x00000008, // should be set for any DDS file with more than one main surface
            TEXTURE = 0x00001000, // should always be set
            MIPMAP = 0x00400000 // only for files with MipMaps
        }

        [Flags]  // dwCaps2
        private enum eDDSCAPS2: uint
        {
            NONE = 0x00000000, // not part of DX, added for convenience
            CUBEMAP = 0x00000200,
            CUBEMAP_POSITIVEX = 0x00000400,
            CUBEMAP_NEGATIVEX = 0x00000800,
            CUBEMAP_POSITIVEY = 0x00001000,
            CUBEMAP_NEGATIVEY = 0x00002000,
            CUBEMAP_POSITIVEZ = 0x00004000,
            CUBEMAP_NEGATIVEZ = 0x00008000,
            CUBEMAP_ALL_FACES = 0x0000FC00,
            VOLUME = 0x00200000 // for 3D Textures
        }
        #endregion Flag Enums

        #region Private Members
        private static string idString; // 4 bytes, must be "DDS "
        private static UInt32 dwSize; // Size of structure is 124 bytes, 128 including all sub-structs and the header
        private static UInt32 dwFlags; // Flags to indicate valid fields.
        private static UInt32 dwHeight; // Height of the main image in pixels
        private static UInt32 dwWidth; // Width of the main image in pixels
        private static UInt32 dwPitchOrLinearSize; // For compressed formats, this is the total number of bytes for the main image.
        private static UInt32 dwDepth; // For volume textures, this is the depth of the volume.
        private static UInt32 dwMipMapCount; // total number of levels in the mipmap chain of the main image.
#if READALL
        private static UInt32[] dwReserved1; // 11 UInt32s
#endif
        // Pixelformat sub-struct, 32 bytes
        private static UInt32 pfSize; // Size of Pixelformat structure. This member must be set to 32.
        private static UInt32 pfFlags; // Flags to indicate valid fields.
        private static UInt32 pfFourCC; // This is the four-character code for compressed formats.
#if READALL
        private static UInt32 pfRGBBitCount; // For RGB formats, this is the total number of bits in the format. dwFlags should include DDpf_RGB in this case. This value is usually 16, 24, or 32. For A8R8G8B8, this value would be 32.
        private static UInt32 pfRBitMask; // For RGB formats, these three fields contain the masks for the red, green, and blue channels. For A8R8G8B8, these values would be 0x00ff0000, 0x0000ff00, and 0x000000ff respectively.
        private static UInt32 pfGBitMask; // ..
        private static UInt32 pfBBitMask; // ..
        private static UInt32 pfABitMask; // For RGB formats, this contains the mask for the alpha channel, if any. dwFlags should include DDpf_ALPHAPIXELS in this case. For A8R8G8B8, this value would be 0xff000000.
#endif
        // Capabilities sub-struct, 16 bytes
        private static UInt32 dwCaps1; // always includes DDSCAPS_TEXTURE. with more than one main surface DDSCAPS_COMPLEX should also be set.
        private static UInt32 dwCaps2; // For cubic environment maps, DDSCAPS2_CUBEMAP should be included as well as one or more faces of the map (DDSCAPS2_CUBEMAP_POSITIVEX, DDSCAPS2_CUBEMAP_NEGATIVEX, DDSCAPS2_CUBEMAP_POSITIVEY, DDSCAPS2_CUBEMAP_NEGATIVEY, DDSCAPS2_CUBEMAP_POSITIVEZ, DDSCAPS2_CUBEMAP_NEGATIVEZ). For volume textures, DDSCAPS2_VOLUME should be included.
#if READALL
        private static UInt32[] dwReserved2; // 3 = 2 + 1 UInt32
#endif
        #endregion Private Members

        /// <summary>
        /// This function will generate, bind and fill a Texture Object with a DXT1/3/5 compressed Texture in .dds Format.
        /// MipMaps below 4x4 Pixel Size are discarded, because DXTn's smallest unit is a 4x4 block of Pixel data.
        /// It will set correct MipMap parameters, Filtering, Wrapping and EnvMode for the Texture. 
        /// The only call inside this function affecting OpenGL State is GL.BindTexture();
        /// </summary>
        /// <param name="filename">The name of the file you wish to load, including path and file extension.</param>
        /// <param name="texturehandle">0 if invalid, otherwise a Texture Object usable with GL.BindTexture().</param>
        /// <param name="dimension">0 if invalid, will output what was loaded (typically Texture1D/2D/3D or Cubemap)</param>
        public static void LoadFromDisk( string filename, out uint texturehandle, out TextureTarget dimension )
        {
            #region Prep data
            // invalidate whatever it was before
            dimension = (TextureTarget) 0;
            texturehandle = TextureLoaderParameters.OpenGLDefaultTexture;
            ErrorCode GLError = ErrorCode.NoError;

            _IsCompressed = false;
            _Width = 0;
            _Height = 0;
            _Depth = 0;
            _MipMapCount = 0;
            _BytesForMainSurface = 0;
            _BytesPerBlock = 0;
            _PixelInternalFormat = PixelInternalFormat.Rgba8;
            byte[] _RawDataFromFile;
            #endregion

            #region Try
            try // Exceptions will be thrown if any Problem occurs while working on the file. 
            {
                _RawDataFromFile = File.ReadAllBytes( @filename );

                #region Translate Header to less cryptic representation
                ConvertDX9Header( ref _RawDataFromFile ); // The first 128 Bytes of the file is non-image data

                // start by checking if all forced flags are present. Flags indicate valid fields, but aren't written by every tool .....
                if ( idString != "DDS " || // magic key
                     dwSize != 124 || // constant size of struct, never reused
                     pfSize != 32 || // constant size of struct, never reused
                     !CheckFlag( dwFlags, (uint) eDDSD.CAPS ) ||        // must know it's caps
                     !CheckFlag( dwFlags, (uint) eDDSD.PIXELFORMAT ) || // must know it's format
                     !CheckFlag( dwCaps1, (uint) eDDSCAPS.TEXTURE )     // must be a Texture
                    )
                    throw new ArgumentException( "ERROR: File has invalid signature or missing Flags." );

                #region Examine Flags
                if ( CheckFlag( dwFlags, (uint) eDDSD.WIDTH ) )
                    _Width = (int) dwWidth;
                else
                    throw new ArgumentException( "ERROR: Flag for Width not set." );

                if ( CheckFlag( dwFlags, (uint) eDDSD.HEIGHT ) )
                    _Height = (int) dwHeight;
                else
                    throw new ArgumentException( "ERROR: Flag for Height not set." );

                if ( CheckFlag( dwFlags, (uint) eDDSD.DEPTH ) && CheckFlag( dwCaps2, (uint) eDDSCAPS2.VOLUME ) )
                {
                    dimension = TextureTarget.Texture3D; // image is 3D Volume
                    _Depth = (int) dwDepth;
                    throw Unfinished;
                } else
                {// image is 2D or Cube
                    if ( CheckFlag( dwCaps2, (uint) eDDSCAPS2.CUBEMAP ) )
                    {
                        dimension = TextureTarget.TextureCubeMap;
                        _Depth = 6;
                    } else
                    {
                        dimension = TextureTarget.Texture2D;
                        _Depth = 1;
                    }
                }

                // these flags must be set for mipmaps to be included
                if ( CheckFlag( dwCaps1, (uint) eDDSCAPS.MIPMAP ) && CheckFlag( dwFlags, (uint) eDDSD.MIPMAPCOUNT ) )
                    _MipMapCount = (int) dwMipMapCount; // image contains MipMaps
                else
                    _MipMapCount = 1; // only 1 main image

                // Should never happen
                if ( CheckFlag( dwFlags, (uint) eDDSD.PITCH ) && CheckFlag( dwFlags, (uint) eDDSD.LINEARSIZE ) )
                    throw new ArgumentException( "INVALID: Pitch AND Linear Flags both set. Image cannot be uncompressed and DTXn compressed at the same time." );

                // This flag is set if format is uncompressed RGB RGBA etc.
                if ( CheckFlag( dwFlags, (uint) eDDSD.PITCH ) )
                {
                    // _BytesForMainSurface = (int) dwPitchOrLinearSize; // holds bytes-per-scanline for uncompressed
                    _IsCompressed = false;
                    throw Unfinished;
                }

                // This flag is set if format is compressed DXTn.
                if ( CheckFlag( dwFlags, (uint) eDDSD.LINEARSIZE ) )
                {
                    _BytesForMainSurface = (int) dwPitchOrLinearSize;
                    _IsCompressed = true;
                }
                #endregion Examine Flags

                #region Examine Pixel Format, anything but DXTn will fail atm.
                if ( CheckFlag( pfFlags, (uint) eDDPF.FOURCC ) )
                    switch ( (eFOURCC) pfFourCC )
                    {
                    case eFOURCC.DXT1:
                        _PixelInternalFormat = (PixelInternalFormat) ExtTextureCompressionS3tc.CompressedRgbS3tcDxt1Ext;
                        _BytesPerBlock = 8;
                        _IsCompressed = true;
                        break;
                    //case eFOURCC.DXT2:
                    case eFOURCC.DXT3:
                        _PixelInternalFormat = (PixelInternalFormat) ExtTextureCompressionS3tc.CompressedRgbaS3tcDxt3Ext;
                        _BytesPerBlock = 16;
                        _IsCompressed = true;
                        break;
                    //case eFOURCC.DXT4:
                    case eFOURCC.DXT5:
                        _PixelInternalFormat = (PixelInternalFormat) ExtTextureCompressionS3tc.CompressedRgbaS3tcDxt5Ext;
                        _BytesPerBlock = 16;
                        _IsCompressed = true;
                        break;
                    default:
                        throw Unfinished; // handle uncompressed formats 
                    } else
                    throw Unfinished;
                // pf*Bitmasks should be examined here
                #endregion

                // Works, but commented out because some texture authoring tools don't set this flag.
                /* Safety Check, if file is only 1x 2D surface without mipmaps, eDDSCAPS.COMPLEX should not be set
                if ( CheckFlag( dwCaps1, (uint) eDDSCAPS.COMPLEX ) )
                {
                    if ( result == eTextureDimension.Texture2D && _MipMapCount == 1 ) // catch potential problem
                        Trace.WriteLine( "Warning: Image is declared complex, but contains only 1 surface." );
                }*/

                if ( TextureLoaderParameters.Verbose )
                    Trace.WriteLine( "\n" + GetDescriptionFromMemory( filename, dimension ) );
                #endregion Translate Header to less cryptic representation

                #region send the Texture to GL
                #region Generate and Bind Handle
                GL.GenTextures( 1, out texturehandle );
                GL.BindTexture( dimension, texturehandle );
                #endregion Generate and Bind Handle

                int Cursor = HeaderSizeInBytes;
                // foreach face in the cubemap, get all it's mipmaps levels. Only one iteration for Texture2D
                for ( int Slices = 0 ; Slices < _Depth ; Slices++ )
                {
                    int trueMipMapCount = _MipMapCount - 1; // TODO: triplecheck correctness
                    int Width = _Width;
                    int Height = _Height;
                    for ( int Level = 0 ; Level < _MipMapCount ; Level++ ) // start at base image
                    {
                        #region determine Dimensions
                        int BlocksPerRow = ( Width + 3 ) >> 2;
                        int BlocksPerColumn = ( Height + 3 ) >> 2;
                        int SurfaceBlockCount = BlocksPerRow * BlocksPerColumn; //   // DXTn stores Texels in 4x4 blocks, a Color block is 8 Bytes, an Alpha block is 8 Bytes for DXT3/5
                        int SurfaceSizeInBytes = SurfaceBlockCount * _BytesPerBlock;

                        // this check must evaluate to false for 2D and Cube maps, or it's impossible to determine MipMap sizes.
                        if ( TextureLoaderParameters.Verbose && Level == 0 && _IsCompressed && _BytesForMainSurface != SurfaceSizeInBytes )
                            Trace.WriteLine( "Warning: Calculated byte-count of main image differs from what was read from file." );
                        #endregion determine Dimensions

                        // skip mipmaps smaller than a 4x4 Pixels block, which is the smallest DXTn unit.
                        if ( Width > 2 && Height > 2 )
                        { // Note: there could be a potential problem with non-power-of-two cube maps
                            #region Prepare Array for TexImage
                            byte[] RawDataOfSurface = new byte[SurfaceSizeInBytes];
                            if ( !TextureLoaderParameters.FlipImages )
                            { // no changes to the image, copy as is
                                Array.Copy( _RawDataFromFile, Cursor, RawDataOfSurface, 0, SurfaceSizeInBytes );
                            } else
                            {  // Turn the blocks upside down and the rows aswell, done in a single pass through all blocks
                                for ( int sourceColumn = 0 ; sourceColumn < BlocksPerColumn ; sourceColumn++ )
                                {
                                    int targetColumn = BlocksPerColumn - sourceColumn - 1;
                                    for ( int row = 0 ; row < BlocksPerRow ; row++ )
                                    {
                                        int target = ( targetColumn * BlocksPerRow + row ) * _BytesPerBlock;
                                        int source = ( sourceColumn * BlocksPerRow + row ) * _BytesPerBlock + Cursor;
                                        #region Swap Bytes
                                        switch ( _PixelInternalFormat )
                                        {
                                        case (PixelInternalFormat) ExtTextureCompressionS3tc.CompressedRgbS3tcDxt1Ext:
                                            // Color only
                                            RawDataOfSurface[target + 0] = _RawDataFromFile[source + 0];
                                            RawDataOfSurface[target + 1] = _RawDataFromFile[source + 1];
                                            RawDataOfSurface[target + 2] = _RawDataFromFile[source + 2];
                                            RawDataOfSurface[target + 3] = _RawDataFromFile[source + 3];
                                            RawDataOfSurface[target + 4] = _RawDataFromFile[source + 7];
                                            RawDataOfSurface[target + 5] = _RawDataFromFile[source + 6];
                                            RawDataOfSurface[target + 6] = _RawDataFromFile[source + 5];
                                            RawDataOfSurface[target + 7] = _RawDataFromFile[source + 4];
                                            break;
                                        case (PixelInternalFormat) ExtTextureCompressionS3tc.CompressedRgbaS3tcDxt3Ext:
                                            // Alpha
                                            RawDataOfSurface[target + 0] = _RawDataFromFile[source + 6];
                                            RawDataOfSurface[target + 1] = _RawDataFromFile[source + 7];
                                            RawDataOfSurface[target + 2] = _RawDataFromFile[source + 4];
                                            RawDataOfSurface[target + 3] = _RawDataFromFile[source + 5];
                                            RawDataOfSurface[target + 4] = _RawDataFromFile[source + 2];
                                            RawDataOfSurface[target + 5] = _RawDataFromFile[source + 3];
                                            RawDataOfSurface[target + 6] = _RawDataFromFile[source + 0];
                                            RawDataOfSurface[target + 7] = _RawDataFromFile[source + 1];

                                            // Color
                                            RawDataOfSurface[target + 8] = _RawDataFromFile[source + 8];
                                            RawDataOfSurface[target + 9] = _RawDataFromFile[source + 9];
                                            RawDataOfSurface[target + 10] = _RawDataFromFile[source + 10];
                                            RawDataOfSurface[target + 11] = _RawDataFromFile[source + 11];
                                            RawDataOfSurface[target + 12] = _RawDataFromFile[source + 15];
                                            RawDataOfSurface[target + 13] = _RawDataFromFile[source + 14];
                                            RawDataOfSurface[target + 14] = _RawDataFromFile[source + 13];
                                            RawDataOfSurface[target + 15] = _RawDataFromFile[source + 12];
                                            break;
                                        case (PixelInternalFormat) ExtTextureCompressionS3tc.CompressedRgbaS3tcDxt5Ext:
                                            // Alpha, the first 2 bytes remain 
                                            RawDataOfSurface[target + 0] = _RawDataFromFile[source + 0];
                                            RawDataOfSurface[target + 1] = _RawDataFromFile[source + 1];

                                            // extract 3 bits each and flip them
                                            GetBytesFromUInt24( ref RawDataOfSurface, (uint) target + 5, FlipUInt24( GetUInt24( ref _RawDataFromFile, (uint) source + 2 ) ) );
                                            GetBytesFromUInt24( ref RawDataOfSurface, (uint) target + 2, FlipUInt24( GetUInt24( ref _RawDataFromFile, (uint) source + 5 ) ) );

                                            // Color
                                            RawDataOfSurface[target + 8] = _RawDataFromFile[source + 8];
                                            RawDataOfSurface[target + 9] = _RawDataFromFile[source + 9];
                                            RawDataOfSurface[target + 10] = _RawDataFromFile[source + 10];
                                            RawDataOfSurface[target + 11] = _RawDataFromFile[source + 11];
                                            RawDataOfSurface[target + 12] = _RawDataFromFile[source + 15];
                                            RawDataOfSurface[target + 13] = _RawDataFromFile[source + 14];
                                            RawDataOfSurface[target + 14] = _RawDataFromFile[source + 13];
                                            RawDataOfSurface[target + 15] = _RawDataFromFile[source + 12];
                                            break;
                                        default:
                                            throw new ArgumentException( "ERROR: Should have never arrived here! Bad _PixelInternalFormat! Should have been dealt with much earlier." );
                                        }
                                        #endregion Swap Bytes
                                    }
                                }
                            }
                            #endregion Prepare Array for TexImage

                            #region Create TexImage
                            switch ( dimension )
                            {
                            case TextureTarget.Texture2D:
                                GL.CompressedTexImage2D( TextureTarget.Texture2D,
                                                         Level,
                                                         _PixelInternalFormat,
                                                         Width,
                                                         Height,
                                                        TextureLoaderParameters.Border,
                                                         SurfaceSizeInBytes,
                                                         RawDataOfSurface );
                                break;
                            case TextureTarget.TextureCubeMap:
                                GL.CompressedTexImage2D( TextureTarget.TextureCubeMapPositiveX + Slices,
                                                         Level,
                                                         _PixelInternalFormat,
                                                         Width,
                                                         Height,
                                                         TextureLoaderParameters.Border,
                                                         SurfaceSizeInBytes,
                                                         RawDataOfSurface );
                                break;
                            case TextureTarget.Texture1D: // Untested
                            case TextureTarget.Texture3D: // Untested
                            default:
                                throw new ArgumentException( "ERROR: Use DXT for 2D Images only. Cannot evaluate " + dimension );
                            }
                            GL.Finish( );
                            #endregion Create TexImage

                            #region Query Success
                            int width, height, internalformat, compressed;
                            switch ( dimension )
                            {
                            case TextureTarget.Texture1D:
                            case TextureTarget.Texture2D:
                            case TextureTarget.Texture3D:
                                GL.GetTexLevelParameter( dimension, Level, GetTextureParameter.TextureWidth, out width );
                                GL.GetTexLevelParameter( dimension, Level, GetTextureParameter.TextureHeight, out height );
                                GL.GetTexLevelParameter( dimension, Level, GetTextureParameter.TextureInternalFormat, out internalformat );
                                GL.GetTexLevelParameter( dimension, Level, GetTextureParameter.TextureCompressed, out compressed );
                                break;
                            case TextureTarget.TextureCubeMap:
                                GL.GetTexLevelParameter( TextureTarget.TextureCubeMapPositiveX + Slices, Level, GetTextureParameter.TextureWidth, out width );
                                GL.GetTexLevelParameter( TextureTarget.TextureCubeMapPositiveX + Slices, Level, GetTextureParameter.TextureHeight, out height );
                                GL.GetTexLevelParameter( TextureTarget.TextureCubeMapPositiveX + Slices, Level, GetTextureParameter.TextureInternalFormat, out internalformat );
                                GL.GetTexLevelParameter( TextureTarget.TextureCubeMapPositiveX + Slices, Level, GetTextureParameter.TextureCompressed, out compressed );
                                break;
                            default:
                                throw Unfinished;
                            }
                            GLError = GL.GetError( );
                            if ( TextureLoaderParameters.Verbose )
                                Trace.WriteLine( "GL: " + GLError.ToString( ) + " Level: " + Level + " DXTn: " + ( ( compressed == 1 ) ? "Yes" : "No" ) + " Frmt:" + (ExtTextureCompressionS3tc) internalformat + " " + width + "*" + height );
                            if ( GLError != ErrorCode.NoError || compressed == 0 || width == 0 || height == 0 || internalformat == 0 )
                            {
                                GL.DeleteTextures( 1, ref texturehandle );
                                throw new ArgumentException( "ERROR: Something went wrong after GL.CompressedTexImage(); Last GL Error: " + GLError.ToString( ) );
                            }
                            #endregion Query Success
                        } else
                        {
                            if ( trueMipMapCount > Level )
                                trueMipMapCount = Level - 1; // The current Level is invalid
                        }

                        #region Prepare the next MipMap level
                        Width /= 2;
                        if ( Width < 1 )
                            Width = 1;
                        Height /= 2;
                        if ( Height < 1 )
                            Height = 1;
                        Cursor += SurfaceSizeInBytes;
                        #endregion Prepare the next MipMap level
                    }

                    #region Set States properly
                    GL.TexParameter( dimension, (TextureParameterName) All.TextureBaseLevel, 0 );
                    GL.TexParameter( dimension, (TextureParameterName) All.TextureMaxLevel, trueMipMapCount );

                    int TexMaxLevel;
                    GL.GetTexParameter( dimension, GetTextureParameter.TextureMaxLevel, out TexMaxLevel );

                    if ( TextureLoaderParameters.Verbose )
                        Trace.WriteLine( "Verification: GL: " + GL.GetError( ).ToString( ) + " TextureMaxLevel: " + TexMaxLevel + ( ( TexMaxLevel == trueMipMapCount ) ? " (Correct.)" : " (Wrong!)" ) );
                    #endregion Set States properly
                }

                #region Set Texture Parameters
                GL.TexParameter( dimension, TextureParameterName.TextureMinFilter, (int) TextureLoaderParameters.MinificationFilter );
                GL.TexParameter( dimension, TextureParameterName.TextureMagFilter, (int) TextureLoaderParameters.MagnificationFilter );

                GL.TexParameter( dimension, TextureParameterName.TextureWrapS, (int) TextureLoaderParameters.WrapModeS );
                GL.TexParameter( dimension, TextureParameterName.TextureWrapT, (int) TextureLoaderParameters.WrapModeT );

                GL.TexEnv( TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, (int) TextureLoaderParameters.EnvMode );

                GLError = GL.GetError( );
                if ( GLError != ErrorCode.NoError )
                {
                    throw new ArgumentException( "Error setting Texture Parameters. GL Error: " + GLError );
                }
                #endregion Set Texture Parameters

                // If it made it here without throwing any Exception the result is a valid Texture.
                return; // success
                #endregion send the Texture to GL
            } catch ( Exception e )
            {
                dimension = (TextureTarget) 0;
                texturehandle = TextureLoaderParameters.OpenGLDefaultTexture;
                throw new ArgumentException( "ERROR: Exception caught when attempting to load file " + filename + ".\n" + e + "\n" + GetDescriptionFromFile( filename ) );
                // return; // failure
            } finally
            {
                _RawDataFromFile = null; // clarity, not really needed
            }
            #endregion Try
        }

        #region Helpers
        private static void ConvertDX9Header( ref byte[] input )
        {
            UInt32 offset = 0;
            idString = GetString( ref input, offset );
            offset += 4;
            dwSize = GetUInt32( ref input, offset );
            offset += 4;
            dwFlags = GetUInt32( ref input, offset );
            offset += 4;
            dwHeight = GetUInt32( ref input, offset );
            offset += 4;
            dwWidth = GetUInt32( ref input, offset );
            offset += 4;
            dwPitchOrLinearSize = GetUInt32( ref input, offset );
            offset += 4;
            dwDepth = GetUInt32( ref input, offset );
            offset += 4;
            dwMipMapCount = GetUInt32( ref input, offset );
            offset += 4;
#if READALL
            dwReserved1 = new UInt32[11]; // reserved
#endif
            offset += 4 * 11;
            pfSize = GetUInt32( ref input, offset );
            offset += 4;
            pfFlags = GetUInt32( ref input, offset );
            offset += 4;
            pfFourCC = GetUInt32( ref input, offset );
            offset += 4;
#if READALL
            pfRGBBitCount = GetUInt32( ref input, offset );
            offset += 4;
            pfRBitMask = GetUInt32( ref input, offset );
            offset += 4;
            pfGBitMask = GetUInt32( ref input, offset );
            offset += 4;
            pfBBitMask = GetUInt32( ref input, offset );
            offset += 4;
            pfABitMask = GetUInt32( ref input, offset );
            offset += 4;
#else
            offset += 20;
#endif
            dwCaps1 = GetUInt32( ref input, offset );
            offset += 4;
            dwCaps2 = GetUInt32( ref input, offset );
            offset += 4;
#if READALL
            dwReserved2 = new UInt32[3]; // offset is 4+112 here, + 12 = 4+124 
#endif
            offset += 4 * 3;
        }

        /// <summary> Returns true if the flag is set, false otherwise</summary>
        private static bool CheckFlag( uint variable, uint flag )
        {
            return ( variable & flag ) > 0 ? true : false;
        }

        private static string GetString( ref byte[] input, uint offset )
        {
            return "" + (char) input[offset + 0] + (char) input[offset + 1] + (char) input[offset + 2] + (char) input[offset + 3];
        }

        private static uint GetUInt32( ref byte[] input, uint offset )
        {
            return (uint) ( ( ( input[offset + 3] * 256 + input[offset + 2] ) * 256 + input[offset + 1] ) * 256 + input[offset + 0] );
        }

        private static uint GetUInt24( ref byte[] input, uint offset )
        {
            return (uint) ( ( input[offset + 2] * 256 + input[offset + 1] ) * 256 + input[offset + 0] );
        }

        private static void GetBytesFromUInt24( ref byte[] input, uint offset, uint splitme )
        {
            input[offset + 0] = (byte) ( splitme & 0x000000ff );
            input[offset + 1] = (byte) ( ( splitme & 0x0000ff00 ) >> 8 );
            input[offset + 2] = (byte) ( ( splitme & 0x00ff0000 ) >> 16 );
            return;
        }

        /// <summary>DXT5 Alpha block flipping, inspired by code from Evan Hart (nVidia SDK)</summary>
        private static uint FlipUInt24( uint inputUInt24 )
        {
            byte[][] ThreeBits = new byte[2][];
            for ( int i = 0 ; i < 2 ; i++ )
                ThreeBits[i] = new byte[4];

            // extract 3 bits each into the array
            ThreeBits[0][0] = (byte) ( inputUInt24 & BitMask );
            inputUInt24 >>= 3;
            ThreeBits[0][1] = (byte) ( inputUInt24 & BitMask );
            inputUInt24 >>= 3;
            ThreeBits[0][2] = (byte) ( inputUInt24 & BitMask );
            inputUInt24 >>= 3;
            ThreeBits[0][3] = (byte) ( inputUInt24 & BitMask );
            inputUInt24 >>= 3;
            ThreeBits[1][0] = (byte) ( inputUInt24 & BitMask );
            inputUInt24 >>= 3;
            ThreeBits[1][1] = (byte) ( inputUInt24 & BitMask );
            inputUInt24 >>= 3;
            ThreeBits[1][2] = (byte) ( inputUInt24 & BitMask );
            inputUInt24 >>= 3;
            ThreeBits[1][3] = (byte) ( inputUInt24 & BitMask );

            // stuff 8x 3bits into 3 bytes
            uint Result = 0;
            Result = Result | (uint) ( ThreeBits[1][0] << 0 );
            Result = Result | (uint) ( ThreeBits[1][1] << 3 );
            Result = Result | (uint) ( ThreeBits[1][2] << 6 );
            Result = Result | (uint) ( ThreeBits[1][3] << 9 );
            Result = Result | (uint) ( ThreeBits[0][0] << 12 );
            Result = Result | (uint) ( ThreeBits[0][1] << 15 );
            Result = Result | (uint) ( ThreeBits[0][2] << 18 );
            Result = Result | (uint) ( ThreeBits[0][3] << 21 );
            return Result;
        }
        #endregion Helpers

        #region String Representations
        private static string GetDescriptionFromFile( string filename )
        {
            return "\n--> Header of " + filename +
                   "\nID: " + idString +
                   "\nSize: " + dwSize +
                   "\nFlags: " + dwFlags + " (" + (eDDSD) dwFlags + ")" +
                   "\nHeight: " + dwHeight +
                   "\nWidth: " + dwWidth +
                   "\nPitch: " + dwPitchOrLinearSize +
                   "\nDepth: " + dwDepth +
                   "\nMipMaps: " + dwMipMapCount +
                   "\n\n---PixelFormat---" + filename +
                   "\nSize: " + pfSize +
                   "\nFlags: " + pfFlags + " (" + (eDDPF) pfFlags + ")" +
                   "\nFourCC: " + pfFourCC + " (" + (eFOURCC) pfFourCC + ")" +
#if READALL
                   "\nBitcount: " + pfRGBBitCount +
                   "\nBitMask Red: " + pfRBitMask +
                   "\nBitMask Green: " + pfGBitMask +
                   "\nBitMask Blue: " + pfBBitMask +
                   "\nBitMask Alpha: " + pfABitMask +
#endif
 "\n\n---Capabilities---" + filename +
                   "\nCaps1: " + dwCaps1 + " (" + (eDDSCAPS) dwCaps1 + ")" +
                   "\nCaps2: " + dwCaps2 + " (" + (eDDSCAPS2) dwCaps2 + ")";
        }

        private static string GetDescriptionFromMemory( string filename, TextureTarget Dimension )
        {
            return "\nFile: " + filename +
                   "\nDimension: " + Dimension +
                   "\nSize: " + _Width + " * " + _Height + " * " + _Depth +
                   "\nCompressed: " + _IsCompressed +
                   "\nBytes for Main Image: " + _BytesForMainSurface +
                   "\nMipMaps: " + _MipMapCount;
        }
        #endregion String Representations
    }
}
