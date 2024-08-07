using OpenTK.Platform;
using OpenTK.Graphics.OpenGL;
using OpenTK.Audio.OpenAL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using StbVorbisSharp;
using System.Text;
using System.Runtime.CompilerServices;
using OpenTK.Core.Utility;

namespace Bejeweled
{
    internal enum Gem
    {
        Diamond,
        Ruby,
        Emerald,
        Sapphire,
        Topaz,
        Amethyst,
        Zircon,
        Empty,
    }

    internal struct Vertex
    {
        public Vector3 Position;
        public Vector3 Normal;
        public Vector2 UV;
        public float Thickness;
    }

    internal class GemVisual
    {
        public Gem GemType;

        public int VAO;
        public int VBO;
        public int EBO;

        public int Elements;

        public unsafe static GemVisual Create(Gem gemType, string glbPath)
        {
            int vao = GL.GenVertexArray();

            // Because SharpGLTF decides to rename a bunch of glTF properties
            // without good reason I will annotate the code with the correct glTF
            // names.
            // I couldn't use glTF-Sharp because it doesn't support trimming or AOT.
            // - Noggin_bops 2024-06-13
            SharpGLTF.Schema2.ModelRoot root = SharpGLTF.Schema2.ModelRoot.Load(glbPath);

            Debug.Assert(root.LogicalMeshes.Count == 1);
            Debug.Assert(root.LogicalMeshes[0].Primitives.Count == 1);

            SharpGLTF.Schema2.MeshPrimitive primitive = root.LogicalMeshes[0].Primitives[0];

            Debug.Assert(primitive.DrawPrimitiveType == SharpGLTF.Schema2.PrimitiveType.TRIANGLES);

            // VertexAccessors = "accessors"
            Debug.Assert(primitive.VertexAccessors.ContainsKey("POSITION"));
            Debug.Assert(primitive.VertexAccessors.ContainsKey("NORMAL"));
            Debug.Assert(primitive.VertexAccessors.ContainsKey("TEXCOORD_0"));
            Debug.Assert(primitive.VertexAccessors.ContainsKey("_THICKNESS"));

            ReadOnlySpan<Vector3> positionData  = ReadGLTFBuffer<Vector3>(primitive.VertexAccessors["POSITION"],   SharpGLTF.Schema2.DimensionType.VEC3,   SharpGLTF.Schema2.EncodingType.FLOAT);
            ReadOnlySpan<Vector3> normalData    = ReadGLTFBuffer<Vector3>(primitive.VertexAccessors["NORMAL"],     SharpGLTF.Schema2.DimensionType.VEC3,   SharpGLTF.Schema2.EncodingType.FLOAT);
            ReadOnlySpan<Vector2> UVData        = ReadGLTFBuffer<Vector2>(primitive.VertexAccessors["TEXCOORD_0"], SharpGLTF.Schema2.DimensionType.VEC2,   SharpGLTF.Schema2.EncodingType.FLOAT);
            ReadOnlySpan<float>   thicknessData = ReadGLTFBuffer<float>  (primitive.VertexAccessors["_THICKNESS"], SharpGLTF.Schema2.DimensionType.SCALAR, SharpGLTF.Schema2.EncodingType.FLOAT);

            Debug.Assert(positionData.Length == normalData.Length && normalData.Length == UVData.Length && UVData.Length == thicknessData.Length);

            Vertex[] vertices = new Vertex[positionData.Length];
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].Position = positionData[i];
                vertices[i].Normal = normalData[i];
                vertices[i].UV = UVData[i];
                vertices[i].Thickness = thicknessData[i];
            }

            // primitive.IndexAccessor = "indices"
            Debug.Assert(primitive.IndexAccessor != null);
            ReadOnlySpan<ushort> indices = ReadGLTFIndicesBuffer<ushort>(primitive.IndexAccessor, SharpGLTF.Schema2.DimensionType.SCALAR, SharpGLTF.Schema2.EncodingType.UNSIGNED_SHORT);

            GL.BindVertexArray(vao);

            int vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(Vertex), vertices, BufferUsage.StaticDraw);

            int ebo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Length * sizeof(ushort), indices, BufferUsage.StaticDraw);

            GL.EnableVertexAttribArray(0);
            GL.EnableVertexAttribArray(1);
            GL.EnableVertexAttribArray(2);
            GL.EnableVertexAttribArray(3);

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, sizeof(Vertex), 0);
            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, sizeof(Vertex), 1 * sizeof(Vector3));
            GL.VertexAttribPointer(2, 2, VertexAttribPointerType.Float, false, sizeof(Vertex), 2 * sizeof(Vector3));
            GL.VertexAttribPointer(3, 1, VertexAttribPointerType.Float, false, sizeof(Vertex), 2 * sizeof(Vector3) + sizeof(Vector2));

            return new GemVisual(gemType, vao, vbo, ebo, indices.Length);

            static ReadOnlySpan<T> ReadGLTFBuffer<T>(SharpGLTF.Schema2.Accessor accessor, SharpGLTF.Schema2.DimensionType dimension, SharpGLTF.Schema2.EncodingType encodingType) where T : unmanaged
            {
                // accessor.Format.Dimensions = "type"
                Debug.Assert(accessor.Format.Dimensions == dimension);
                // accessor.Format.Encoding = "componentType"
                Debug.Assert(accessor.Format.Encoding == encodingType);
                Debug.Assert(accessor.ByteOffset == 0);

                // accessor.SourceBufferView.Content = "accessor -> bufferview -> buffer" considering ByteOffset and ByteLength
                ReadOnlySpan<T> data = MemoryMarshal.Cast<byte, T>(accessor.SourceBufferView.Content.AsSpan());
                return data;
            }

            static ReadOnlySpan<T> ReadGLTFIndicesBuffer<T>(SharpGLTF.Schema2.Accessor accessor, SharpGLTF.Schema2.DimensionType dimension, SharpGLTF.Schema2.EncodingType encodingType) where T : unmanaged
            {
                // accessor.Format.Dimensions = "type"
                Debug.Assert(accessor.Format.Dimensions == dimension);
                // accessor.Format.Encoding = "componentType"
                Debug.Assert(accessor.Format.Encoding == encodingType);
                Debug.Assert(accessor.ByteOffset == 0);

                // accessor.SourceBufferView.Content = "accessor -> bufferview -> buffer" considering ByteOffset and ByteLength
                ReadOnlySpan<T> data = MemoryMarshal.Cast<byte, T>(accessor.SourceBufferView.Content.AsSpan());
                return data;
            }
        }

        public GemVisual(Gem type, int vao, int vbo, int ebo, int elements)
        {
            GemType = type;
            VAO = vao;
            VBO = vbo;
            EBO = ebo;
            Elements = elements;
        }
    }

    internal class ShaderProgram
    {
        public int Handle;

        public static ShaderProgram LoadShader(string vertexPath, string fragmentPath, ILogger? logger)
        {
            string vertexSource = File.ReadAllText(vertexPath);
            string fragmentSource = File.ReadAllText(fragmentPath);

            int program = GL.CreateProgram();

            int vert = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(vert, vertexSource);
            GL.CompileShader(vert);
            GL.GetShaderInfoLog(vert, out string vertInfo);
            if (GL.GetShaderi(vert, ShaderParameterName.CompileStatus) == 0)
            {
                Debug.Assert(false, vertInfo);
            }
            else if (string.IsNullOrEmpty(vertInfo) == false)
            {
                logger?.LogWarning($"Vertex info: {vertInfo}");
            }

            int frag = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(frag, fragmentSource);
            GL.CompileShader(frag);
            GL.GetShaderInfoLog(frag, out string fragInfo);
            if (GL.GetShaderi(frag, ShaderParameterName.CompileStatus) == 0)
            {
                Debug.Assert(false, fragInfo);
            }
            else if (string.IsNullOrEmpty(fragInfo) == false)
            {
                logger?.LogWarning($"Fragment info: {fragInfo}");
            }

            GL.AttachShader(program, vert);
            GL.AttachShader(program, frag);

            // FIXME: These need to be set before linking the program.
            // This makes this function not as general as it might be.
            // But for this program maybe this is fine?
            // - Noggin_bops 2024-06-16
            GL.BindAttribLocation(program, 0, "aPosition");
            GL.BindAttribLocation(program, 1, "aNormal");
            GL.BindAttribLocation(program, 2, "aUV");
            GL.BindAttribLocation(program, 3, "aThickness");

            GL.LinkProgram(program);
            GL.GetProgramInfoLog(program, out string programInfo);
            if (GL.GetProgrami(program, ProgramProperty.LinkStatus) == 0)
            {
                Debug.Assert(false, programInfo);
            }
            else if (string.IsNullOrEmpty(programInfo) == false)
            {
                logger?.LogWarning($"Program link info: {programInfo}");
            }

            GL.DetachShader(program, vert);
            GL.DetachShader(program, frag);

            GL.DeleteShader(vert);
            GL.DeleteShader(frag);

            return new ShaderProgram(program);
        }

        public ShaderProgram(int program)
        {
            Handle = program;
        }
    }

    internal struct GemShader
    {
        public ShaderProgram Program;

        public int UniformLocationMVP;
        public int UniformLocationModel;
        public int UniformLocationViewProjection;
        public int UniformLocationNormalMat;

        public int UniformLocationEnvironmentMap;
        public int UniformLocationIrradianceMap;
        public int UniformLocationPrefilteredEnvironmentMap;
        public int UniformLocationBRDFLUT;

        public int UniformLocationScreenSize;
        public int UniformLocationBackfaceNormals;
        public int UniformLocationBackfaceDepth;
        public int UniformLocationDepthScale;

        public int UniformLocationTint;
        public int UniformLocationF0;

        public static GemShader Init(string vertexPath, string fragmentPath, ILogger? logger)
        {
            GemShader shader;
            shader.Program = ShaderProgram.LoadShader(vertexPath, fragmentPath, logger);

            shader.UniformLocationMVP = GL.GetUniformLocation(shader.Program.Handle, "uMVP");
            shader.UniformLocationModel = GL.GetUniformLocation(shader.Program.Handle, "uModel");
            shader.UniformLocationViewProjection = GL.GetUniformLocation(shader.Program.Handle, "uViewProjection");
            shader.UniformLocationNormalMat = GL.GetUniformLocation(shader.Program.Handle, "uNormalMat");

            shader.UniformLocationEnvironmentMap = GL.GetUniformLocation(shader.Program.Handle, "uEnvironmentMap");
            shader.UniformLocationIrradianceMap = GL.GetUniformLocation(shader.Program.Handle, "uIrradianceMap");
            shader.UniformLocationPrefilteredEnvironmentMap = GL.GetUniformLocation(shader.Program.Handle, "uPrefilteredEnvironmentMap");
            shader.UniformLocationBRDFLUT = GL.GetUniformLocation(shader.Program.Handle, "uBRDF_LUT");

            shader.UniformLocationScreenSize = GL.GetUniformLocation(shader.Program.Handle, "uScreenSize");
            shader.UniformLocationBackfaceNormals = GL.GetUniformLocation(shader.Program.Handle, "uBackfaceNormalTexture");
            shader.UniformLocationBackfaceDepth = GL.GetUniformLocation(shader.Program.Handle, "uBackfaceDepthTexture");
            shader.UniformLocationDepthScale = GL.GetUniformLocation(shader.Program.Handle, "uDepthScale");

            shader.UniformLocationTint = GL.GetUniformLocation(shader.Program.Handle, "uTint");
            shader.UniformLocationF0 = GL.GetUniformLocation(shader.Program.Handle, "uF0");

            return shader;
        }
    }

    internal struct GemNormalShader
    {
        public ShaderProgram Program;

        public int UniformLocationMVP;
        public int UniformLocationModel;
        public int UniformLocationNormalMat;

        public static GemNormalShader Init(string vertexPath, string fragmentPath, ILogger? logger)
        {
            GemNormalShader shader;
            shader.Program = ShaderProgram.LoadShader(vertexPath, fragmentPath, logger);

            shader.UniformLocationMVP = GL.GetUniformLocation(shader.Program.Handle, "uMVP");
            shader.UniformLocationModel = GL.GetUniformLocation(shader.Program.Handle, "uModel");
            shader.UniformLocationNormalMat = GL.GetUniformLocation(shader.Program.Handle, "uNormalMat");

            return shader;
        }
    }

    internal class SoundClip
    {
        public int Buffer;

        public static unsafe SoundClip LoadSound(string filename)
        {
            Vorbis soundData = Vorbis.FromMemory(File.ReadAllBytes(filename));
            Debug.Assert(soundData.Channels == 2);

            uint nSamples = StbVorbis.stb_vorbis_stream_length_in_samples(soundData.StbVorbis);
            short[] samples = new short[nSamples * soundData.Channels];
            int decoded = 0;
            fixed (short* samplesPtr = samples)
            {
                decoded = StbVorbis.stb_vorbis_get_samples_short_interleaved(soundData.StbVorbis, soundData.StbVorbisInfo.channels, samplesPtr, samples.Length);
            }

            int buffer = AL.GenBuffer();
            AL.BufferData(buffer, ALFormat.Stereo16, ref samples[0], decoded * soundData.Channels * sizeof(short), soundData.SampleRate);
            ALError error = AL.GetError();
            if (error != ALError.NoError)
            {
                Debug.Assert(false, $"ALError: {error}");
            }

            return new SoundClip(buffer);
        }

        public SoundClip(int buffer)
        {
            Buffer = buffer;
        }
    }

    internal class SoundEffect
    {
        public SoundClip Clip;
        List<int> Sources = new List<int>();

        public SoundEffect(SoundClip clip)
        {
            Clip = clip;
        }

        public void Update()
        {
            for (int i = Sources.Count - 1; i >= 0; i--)
            {
                if ((ALSourceState)AL.GetSource(Sources[i], ALGetSourcei.SourceState) == ALSourceState.Stopped)
                {
                    AL.DeleteSource(Sources[i]);
                    Sources.RemoveAt(i);
                }
            }
        }

        public void PlayOneShot(float gain, float pitch)
        {
            int source = AL.GenSource();
            AL.Source(source, ALSourcei.Buffer, Clip.Buffer);
            AL.Source(source, ALSourceb.Looping, false);

            AL.Source(source, ALSourcef.Gain, gain);
            AL.Source(source, ALSourcef.Pitch, pitch);

            AL.SourcePlay(source);

            ALError error = AL.GetError();
            if (error != ALError.NoError)
            {
                Debug.Assert(false, $"ALError: {error}");
            }

            Sources.Add(source);
        }
    }

    internal class Music
    {
        public SoundClip Clip;
        public int Source;

        public Music(SoundClip clip)
        {
            Clip = clip;
            Source = AL.GenSource();

            AL.Source(Source, ALSourcei.Buffer, clip.Buffer);
            AL.Source(Source, ALSourceb.Looping, true);
        }

        public void Play()
        {
            AL.SourcePlay(Source);
        }

        public void Pause()
        {
            AL.SourcePause(Source);
        }

        public void Stop()
        {
            AL.SourceStop(Source);
        }

        public void SetGain(float gain)
        {
            AL.Source(Source, ALSourcef.Gain, gain);
        }
    }

    internal class Cubemap
    {
        private static ReadOnlySpan<DDSCubemapFaces> OpenGLCubemapFaceOrder => new DDSCubemapFaces[]
        {
            DDSCubemapFaces.PosX,
            DDSCubemapFaces.NegX,
            DDSCubemapFaces.PosY,
            DDSCubemapFaces.NegY,
            DDSCubemapFaces.PosZ,
            DDSCubemapFaces.NegZ,
        };

        private static ReadOnlySpan<TextureTarget> OpenGLCubemapFaceOrderTextureTarget => new TextureTarget[]
        {
            TextureTarget.TextureCubeMapPositiveX,
            TextureTarget.TextureCubeMapNegativeX,
            TextureTarget.TextureCubeMapPositiveY,
            TextureTarget.TextureCubeMapNegativeY,
            TextureTarget.TextureCubeMapPositiveZ,
            TextureTarget.TextureCubeMapNegativeZ,
        };

        public int Handle;

        public static unsafe Cubemap LoadCubemap(string path)
        {
            DDSImage image = DDSReader.LoadImage(path);

            Debug.Assert(image.Type == DDSImageType.CubeMap);

            int depth = 6;
            TextureTarget target = TextureTarget.TextureCubeMap;

            static bool IsExtensionSupported(string name)
            {
                int n = GL.GetInteger(GetPName.NumExtensions);
                for (int i = 0; i < n; i++)
                {
                    string extension = GL.GetStringi(StringName.Extensions, (uint)i)!;
                    if (extension == name) return true;
                }

                return false;
            }

            int major = GL.GetInteger(GetPName.MajorVersion);
            int minor = GL.GetInteger(GetPName.MinorVersion);
            bool BC6HSupported = (major > 4 || (major == 4 && minor >= 2)) || IsExtensionSupported("ARB_texture_compression_bptc") || IsExtensionSupported("GL_ARB_texture_compression_bptc");

            int bytesPerPixel;
            int blockSize;
            SizedInternalFormat internalFormat;
            PixelFormat pixelFormat = 0;
            PixelType pixelType = 0;
            bool compressed;
            switch (image.Format)
            {
                case DDSImageFormat.BC5_UNORM:
                    // FIXME: Should it be unsigned or signed?
                    internalFormat = (SizedInternalFormat)All.CompressedRgRgtc2;
                    compressed = true;
                    bytesPerPixel = 1;
                    blockSize = 16;
                    break;
                case DDSImageFormat.BC7_UNORM:
                    // FIXME: Is this supposed to be sRGB?
                    internalFormat = (SizedInternalFormat)All.CompressedRgbaBptcUnorm;
                    compressed = true;
                    bytesPerPixel = 1;
                    blockSize = 16;
                    break;
                case DDSImageFormat.BC7_UNORM_SRGB:
                    // FIXME: Is this supposed to be sRGB?
                    internalFormat = (SizedInternalFormat)All.CompressedSrgbAlphaBptcUnorm;
                    compressed = true;
                    bytesPerPixel = 1;
                    blockSize = 16;
                    break;
                case DDSImageFormat.BC6H_UF:
                    // This is core since 4.2, but we'll just assume support in 4.1.
                    // FIXME: MacOS does not have support for this texture format...
                    // Maybe we can decompress this format if there is no support.
                    internalFormat = (SizedInternalFormat)All.CompressedRgbBptcUnsignedFloat;
                    compressed = true;
                    bytesPerPixel = 1;
                    blockSize = 16;
                    break;
                case DDSImageFormat.RGBA16F:
                    internalFormat = SizedInternalFormat.Rgba16f;
                    pixelFormat = PixelFormat.Rgba;
                    pixelType = PixelType.HalfFloat;
                    compressed = false;
                    bytesPerPixel = 8;
                    blockSize = -1;
                    break;
                case DDSImageFormat.RGBA32F:
                    internalFormat = SizedInternalFormat.Rgba32f;
                    pixelFormat = PixelFormat.Rgba;
                    pixelType = PixelType.Float;
                    compressed = false;
                    bytesPerPixel = 16;
                    blockSize = -1;
                    break;
                default:
                    throw new Exception();
            }

            int texture = GL.GenTexture();
            GL.BindTexture(target, texture);

            int idealMipCount = MathF.ILogB(Math.Max(image.Width, image.Height)) + 1;

            int dataOffset = 0;
            int layer = -1;
            for (int iFace = 0; iFace < OpenGLCubemapFaceOrder.Length; iFace++)
            {
                DDSCubemapFaces face = OpenGLCubemapFaceOrder[iFace];
                TextureTarget faceTextureTarget = OpenGLCubemapFaceOrderTextureTarget[iFace];

                layer++;
                if (image.Faces.HasFlag(face) == false)
                    continue;

                int mipWidth = image.Width;
                int mipHeight = image.Height;
                for (int i = 0; i < idealMipCount; i++)
                {
                    int dataLength = Math.Max(mipWidth * mipHeight * bytesPerPixel, blockSize);
                    if (image.Format == DDSImageFormat.BC6H_UF && BC6HSupported == false)
                    {
                        if (i < image.MipmapCount)
                        {
                            // We need to decompress the format to RGBA16F.
                            Half[] decompressed = new Half[mipWidth * mipHeight * 4];

                            Span<byte> data = new Span<byte>(image.AllData, dataOffset, dataLength);
                            BC6H.DecompressBC6H(data, mipWidth, mipHeight, decompressed);

                            GL.TexImage2D(faceTextureTarget, i, InternalFormat.Rgba16f, mipWidth, mipHeight, 0, PixelFormat.Rgba, PixelType.HalfFloat, decompressed);
                        }
                        else
                        {
                            GL.TexImage2D(faceTextureTarget, i, InternalFormat.Rgba16f, mipWidth, mipHeight, 0, PixelFormat.Rgba, PixelType.HalfFloat, IntPtr.Zero);
                        }
                    }
                    else if (compressed)
                    {
                        if (i < image.MipmapCount)
                        {
                            GL.CompressedTexImage2D(faceTextureTarget, i, (InternalFormat)internalFormat, mipWidth, mipHeight, 0, dataLength, in image.AllData[dataOffset]);
                            //GL.CompressedTextureSubImage3D(texture, i, 0, 0, layer, mipWidth, mipHeight, 1, (PixelFormat)internalFormat, dataLength, (nint)Unsafe.AsPointer(ref image.AllData[dataOffset]));
                        }
                        else
                        {
                            // We need to do this because AMD compressonator decided it didn't want to produce
                            // 2x2 and 1x1 level mips for block compressed formats,
                            // even though the spec accomodates this...
                            // - Noggin_bops 2024-06-12
                            GL.CompressedTexImage2D(faceTextureTarget, i, (InternalFormat)internalFormat, mipWidth, mipHeight, 0, dataLength, IntPtr.Zero);
                        }
                    }
                    else
                    {
                        if (i < image.MipmapCount)
                        {
                            GL.TexImage2D(faceTextureTarget, i, (InternalFormat)internalFormat, mipWidth, mipHeight, 0, pixelFormat, pixelType, (nint)Unsafe.AsPointer(ref image.AllData[dataOffset]));
                            //GL.TextureSubImage3D(texture, i, 0, 0, layer, mipWidth, mipHeight, 1, pixelFormat, pixelType, (nint)Unsafe.AsPointer(ref image.AllData[dataOffset]));
                        }
                        else
                        {
                            // We need to do this because AMD compressonator decided it didn't want to produce
                            // 2x2 and 1x1 level mips for block compressed formats,
                            // even though the spec accomodates this...
                            // - Noggin_bops 2024-06-12
                            GL.TexImage2D(faceTextureTarget, i, (InternalFormat)internalFormat, mipWidth, mipHeight, 0, pixelFormat, pixelType, IntPtr.Zero);
                        }
                    }

                    if (i < image.MipmapCount)
                        dataOffset += dataLength;
                    mipWidth = Math.Max(1, mipWidth / 2);
                    mipHeight = Math.Max(1, mipHeight / 2);
                }
            }

            if (image.MipmapCount != idealMipCount)
            {
                // We need to do this because AMD compressonator decided it didn't want to produce
                // 2x2 and 1x1 level mips for block compressed formats,
                // even though the spec accomodates this...
                // - Noggin_bops 2024-06-12
                GL.TexParameteri(target, TextureParameterName.TextureMaxLevel, image.MipmapCount);
            }

            if (image.MipmapCount > 1)
            {
                GL.TexParameteri(target, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.LinearMipmapLinear);
            }
            else
            {
                GL.TexParameteri(target, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            }
            GL.TexParameteri(target, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            // FIXME: Set the texture filtering properties to match mipmap levels!

            return new Cubemap(texture);
        }

        public Cubemap(int handle)
        {
            Handle = handle;
        }
    }

    internal class Texture
    {
        public int Handle;

        public static unsafe Texture LoadTexture(string path)
        {
            DDSImage image = DDSReader.LoadImage(path);

            Debug.Assert(image.Type == DDSImageType.Texture2D);

            int depth = 1;
            TextureTarget target = TextureTarget.Texture2d;

            int bytesPerPixel;
            SizedInternalFormat internalFormat;
            PixelFormat pixelFormat = 0;
            PixelType pixelType = 0;
            bool compressed;
            switch (image.Format)
            {
                case DDSImageFormat.BC5_UNORM:
                    // FIXME: Should it be unsigned or signed?
                    internalFormat = (SizedInternalFormat)All.CompressedRgRgtc2;
                    compressed = true;
                    bytesPerPixel = 1;
                    break;
                case DDSImageFormat.BC7_UNORM:
                    // FIXME: Is this supposed to be sRGB?
                    internalFormat = (SizedInternalFormat)All.CompressedRgbaBptcUnorm;
                    compressed = true;
                    bytesPerPixel = 1;
                    break;
                case DDSImageFormat.BC7_UNORM_SRGB:
                    // FIXME: Is this supposed to be sRGB?
                    internalFormat = (SizedInternalFormat)All.CompressedSrgbAlphaBptcUnorm;
                    compressed = true;
                    bytesPerPixel = 1;
                    break;
                case DDSImageFormat.RGBA16F:
                    internalFormat = SizedInternalFormat.Rgba16f;
                    pixelFormat = PixelFormat.Rgba;
                    pixelType = PixelType.HalfFloat;
                    compressed = false;
                    bytesPerPixel = 8;
                    break;
                case DDSImageFormat.RGBA32F:
                    internalFormat = SizedInternalFormat.Rgba32f;
                    pixelFormat = PixelFormat.Rgba;
                    pixelType = PixelType.Float;
                    compressed = false;
                    bytesPerPixel = 16;
                    break;
                default:
                    throw new Exception();
            }

            int texture = GL.GenTexture();
            GL.BindTexture(target, texture);

            //GL.ObjectLabel(ObjectLabelIdentifier.Texture, texture, -1, name);

            //GL.TextureStorage2D(texture, mipmapLevels, internalFormat, image.Width, image.Height);

            int dataOffset = 0;
            int mipWidth = image.Width;
            int mipHeight = image.Height;
            for (int i = 0; i < image.MipmapCount; i++)
            {
                int dataLength = mipWidth * mipHeight;
                if (compressed)
                {
                    Debug.Assert(false);
                    //GL.CompressedTextureSubImage2D(texture, i, 0, 0, mipWidth, mipHeight, (PixelFormat)internalFormat, dataLength, (nint)Unsafe.AsPointer(ref image.AllData[dataOffset]));
                }
                else
                {
                    GL.TexImage2D(target, i, (InternalFormat)internalFormat, mipWidth, mipHeight, 0, pixelFormat, pixelType, (nint)Unsafe.AsPointer(ref image.AllData[dataOffset]));
                }
                dataOffset += mipWidth * mipHeight;
                mipWidth = Math.Max(1, mipWidth / 2);
                mipHeight = Math.Max(1, mipHeight / 2);
            }

            if (image.MipmapCount > 1)
            {
                GL.TexParameteri(target, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.LinearMipmapLinear);
            }
            else
            {
                GL.TexParameteri(target, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            }
            GL.TexParameteri(target, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            // FIXME: Set the texture filtering properties to match mipmap levels!

            return new Texture(texture);
        }

        public Texture(int handle)
        {
            Handle = handle;
        }
    }

    internal class Framebuffer
    {
        public int Handle;
        public int ColorAttachement0;
        public int DepthAttachement;

        public int Samples;

        public static Framebuffer CreateNormalDepthFramebuffer(int width, int height)
        {
            int framebuffer = GL.GenFramebuffer();

            int normalTexture = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2d, normalTexture);
            GL.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.Rgba16Snorm, width, height, 0, PixelFormat.Rgba, PixelType.Float, IntPtr.Zero);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);

            int depthTexture = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2d, depthTexture);
            GL.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.DepthComponent16, width, height, 0, PixelFormat.DepthComponent, PixelType.Float, IntPtr.Zero);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, framebuffer);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, TextureTarget.Texture2d, normalTexture, 0);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.DepthAttachment, TextureTarget.Texture2d, depthTexture, 0);

            FramebufferStatus status = GL.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
            if (status != FramebufferStatus.FramebufferComplete)
            {
                Debug.Assert(false, $"{status}");
            }

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);

            return new Framebuffer(framebuffer, normalTexture, depthTexture, 0);
        }

        public static Framebuffer CreateDebugFramebufferMS(int width, int height, int samples)
        {
            int framebuffer = GL.GenFramebuffer();

            int normalTexture = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2dMultisample, normalTexture);
            GL.TexImage2DMultisample(TextureTarget.Texture2dMultisample, samples, InternalFormat.Rgba32f, width, height, true);

            int depthTexture = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2dMultisample, depthTexture);
            GL.TexImage2DMultisample(TextureTarget.Texture2dMultisample, samples, InternalFormat.DepthComponent32f, width, height, true);

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, framebuffer);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, TextureTarget.Texture2dMultisample, normalTexture, 0);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.DepthAttachment, TextureTarget.Texture2dMultisample, depthTexture, 0);

            FramebufferStatus status = GL.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
            if (status != FramebufferStatus.FramebufferComplete)
            {
                Debug.Assert(false, $"{status}");
            }

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);

            return new Framebuffer(framebuffer, normalTexture, depthTexture, samples);
        }

        public void ResizeNormalDepthFramebuffer(int newWidth, int newHeight)
        {
            GL.BindTexture(TextureTarget.Texture2d, ColorAttachement0);
            GL.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.Rgba16Snorm, newWidth, newHeight, 0, PixelFormat.Rgba, PixelType.Float, IntPtr.Zero);
            GL.BindTexture(TextureTarget.Texture2d, DepthAttachement);
            GL.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.DepthComponent16, newWidth, newHeight, 0, PixelFormat.DepthComponent, PixelType.Float, IntPtr.Zero);

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, Handle);
            FramebufferStatus status = GL.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
            if (status != FramebufferStatus.FramebufferComplete)
            {
                Debug.Assert(false, $"{status}");
            }

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
        }

        public void ResizeDebugFramebufferMS(int newWidth, int newHeight, int samples)
        {
            GL.BindTexture(TextureTarget.Texture2dMultisample, ColorAttachement0);
            GL.TexImage2DMultisample(TextureTarget.Texture2dMultisample, samples, InternalFormat.Rgba32f, newWidth, newHeight, true);
            GL.BindTexture(TextureTarget.Texture2dMultisample, DepthAttachement);
            GL.TexImage2DMultisample(TextureTarget.Texture2dMultisample, samples, InternalFormat.DepthComponent32f, newWidth, newHeight, true);

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, Handle);
            FramebufferStatus status = GL.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
            if (status != FramebufferStatus.FramebufferComplete)
            {
                Debug.Assert(false, $"{status}");
            }

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
        }

        public Framebuffer(int handle, int colorAttachement0, int depthAttachement, int samples)
        {
            Handle = handle;
            ColorAttachement0 = colorAttachement0;
            DepthAttachement = depthAttachement;

            Samples = samples;
        }
    }

    internal enum State
    {
        Idle,
        AnimatingPlayerMove,
        Falling,
    }

    public class Bejeweled
    {
        public string Name => "Bejeweled";

        internal static ILogger Logger;

        WindowHandle Window;
        OpenGLContextHandle Context;

        ALDevice ALDevice;
        ALContext ALContext;

        private bool KHRDebugAvailable;

        internal static readonly Gem[] ChooseGems = new Gem[] { Gem.Diamond, Gem.Ruby, Gem.Emerald, Gem.Sapphire, Gem.Topaz, Gem.Amethyst, Gem.Zircon };

        internal static readonly Vector3[] GemColors = new Vector3[]
        {
            (Vector3)Color4.White.ToRgb() * 0.75f,
            (Vector3)Color4.Red.ToRgb() * 0.75f,
            (Vector3)Color4.Green.ToRgb() * 0.75f,
            (Vector3)Color4.Blue.ToRgb() * 0.75f,
            (Vector3)Color4.Yellow.ToRgb() * 0.75f,
            (Vector3)Color4.Purple.ToRgb() * 0.75f,
            (Vector3)Color4.Cyan.ToRgb() * 0.75f,
        };

        internal static readonly Vector3[] GemF0s = new Vector3[]
        {
            new Vector3(0.171950f, 0.171950f, 0.171950f),
            new Vector3(0.078350f, 0.076697f, 0.076697f),
            new Vector3(0.076697f, 0.078350f, 0.076697f),
            new Vector3(0.076697f, 0.076697f, 0.078350f),
            new Vector3(0.078350f, 0.078350f, 0.076697f),
            new Vector3(0.078350f, 0.076697f, 0.078350f),
            new Vector3(0.076697f, 0.078350f, 0.078350f),
        };

        Framebuffer RefractionInfoFramebuffer;

        Framebuffer DebugFramebuffer;

        Texture BrdfLUT;
        Cubemap EnvironmentMap;
        Cubemap IrradianceMap;
        Cubemap PrefilteredEnvironmentMap;

        GemShader GemShader;
        GemNormalShader GemNormalShader;

        GemVisual DiamondVisual;
        GemVisual RubyVisual;
        GemVisual EmeraldVisual;
        GemVisual SapphireVisual;
        GemVisual TopazVisual;
        GemVisual AmethystVisual;
        GemVisual ZirconVisual;

        internal const float MusicVolume = 0.8f;
        internal const float BreakSFXVolume = 0.5f;
        internal const float SwapSFXVolume = 0.25f;

        Music AmbientMusic;

        SoundEffect BreakSoundEffect;
        SoundEffect SwapSoundEffect;

        internal Gem[,] Board = new Gem[8, 8];
        internal Vector2[,] BoardPositions = new Vector2[8, 8];
        internal Gem[] TopRow = new Gem[8];
        internal Vector2[] TopRowPositions = new Vector2[8];


        State CurrentState;

        // Idle state
        internal Vector2i HoveredGem = (-1, -1);
        internal Vector2i SelectedGem = (-1, -1);
        internal Vector2 StartPosition;

        // Player move state
        internal const float SwapAnimationTime = 0.3f;
        internal Vector2i MovingGem1, MovingGem2;
        internal float AnimationTime = 0.0f;

        // Falling state
        internal const float FallAcceleration = 7.0f;
        internal const float FallStartSpeed = 0.2f;
        internal const float FallMaxSpeed = 10f;
        internal float FallSpeed = FallStartSpeed;

        internal const float FallAnimationTime = 0.2f;
        internal float FallingTime = 0.0f;
        internal int FallingComboCount = 0;

        public void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES, ILogger logger)
        {
            Debug.Assert(useGLES == false, "We don't support GLES for this demo yet.");

            Logger = logger;

            Window = window;
            Context = context;

            Stopwatch watch = Stopwatch.StartNew();

            static bool IsExtensionSupported(string name)
            {
                int n = GL.GetInteger(GetPName.NumExtensions);
                for (int i = 0; i < n; i++)
                {
                    string extension = GL.GetStringi(StringName.Extensions, (uint)i)!;
                    if (extension == name) return true;
                }

                return false;
            }

            string version = GL.GetString(StringName.Version)!;
            string glslVersion = GL.GetString(StringName.ShadingLanguageVersion)!;
            string renderer = GL.GetString(StringName.Renderer)!;
            string vendor = GL.GetString(StringName.Vendor)!;
            Logger.LogInfo($"OpenGL version: {version}");
            Logger.LogInfo($"GLSL version: {glslVersion}");
            Logger.LogInfo($"Renderer: {renderer}");
            Logger.LogInfo($"Vendor: {vendor}");

            int major = GL.GetInteger(GetPName.MajorVersion);
            int minor = GL.GetInteger(GetPName.MinorVersion);
            KHRDebugAvailable = (major == 4 && minor >= 3) || IsExtensionSupported("KHR_debug") || IsExtensionSupported("GL_KHR_debug");

            if (KHRDebugAvailable)
            {
                // Enabling debug output before setting the callback is apprently
                // needed to make certain (Mesa 23.2.1-1ubuntu3.1~22.04.2) linux drivers not segfault.
                // - Noggin_bops 2024-06-16
                GL.Enable(EnableCap.DebugOutput);
                GL.Enable(EnableCap.DebugOutputSynchronous);
                GL.DebugMessageCallback(Bejeweled.DebugProcCallback, IntPtr.Zero);
            }

            GL.Enable(EnableCap.FramebufferSrgb);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.TextureCubeMapSeamless);

            GemShader = GemShader.Init("./Assets/Shaders/Gem.vert", "./Assets/Shaders/Gem.frag", Logger);
            GemNormalShader = GemNormalShader.Init("./Assets/Shaders/Gem.vert", "./Assets/Shaders/Normal.frag", Logger);

            Toolkit.Window.GetFramebufferSize(Window, out int framebufferWidth, out int framebufferHeight);
            RefractionInfoFramebuffer = Framebuffer.CreateNormalDepthFramebuffer(framebufferWidth, framebufferHeight);

            //DebugFramebuffer = Framebuffer.CreateDebugFramebufferMS(framebufferWidth, framebufferHeight, 16);

            DiamondVisual = GemVisual.Create(Gem.Diamond, "./Assets/Models/Diamond.glb");
            RubyVisual = GemVisual.Create(Gem.Ruby, "./Assets/Models/Ruby.glb");
            EmeraldVisual = GemVisual.Create(Gem.Emerald, "./Assets/Models/Emerald.glb");
            SapphireVisual = GemVisual.Create(Gem.Emerald, "./Assets/Models/Sapphire.glb");
            TopazVisual = GemVisual.Create(Gem.Topaz, "./Assets/Models/Topaz.glb");
            AmethystVisual = GemVisual.Create(Gem.Amethyst, "./Assets/Models/Amethyst.glb");
            ZirconVisual = GemVisual.Create(Gem.Zircon, "./Assets/Models/Zircon.glb");

            BrdfLUT = Texture.LoadTexture("./Assets/Textures/dancing_hall_4kBrdf.dds");

            EnvironmentMap = Cubemap.LoadCubemap("./Assets/Textures/dancing_hall_4kEnvHDR.dds");
            IrradianceMap = Cubemap.LoadCubemap("./Assets/Textures/dancing_hall_4kDiffuseHDR.dds");
            PrefilteredEnvironmentMap = Cubemap.LoadCubemap("./Assets/Textures/dancing_hall_4kSpecularHDR.dds");

            // We don't generate a starting board, instead we go directly into the falling
            // state and let it populate the board.
            CurrentState = State.Falling;
            for (int x = 0; x < Board.GetLength(0); x++)
            {
                TopRow[x] = ChooseGems[Random.Shared.Next(ChooseGems.Length)];
                TopRowPositions[x] = GetTileLocation(x, -1);

                for (int y = 0; y < Board.GetLength(1); y++)
                {
                    // FIXME: Make sure we are not generating any collection of gems that is larger than 3 connected.
                    Board[x, y] = Gem.Empty;

                    BoardPositions[x, y] = GetTileLocation(x, y);
                }
            }

            Toolkit.Window.SetTitle(Window, $"Bejeweled");

            // ### OpenAL ###

            // Use bundled OpenAL soft dll on windows.
            if (OperatingSystem.IsWindows())
            {
                OpenALLibraryNameContainer.OverridePath = "win32-x64/soft_oal.dll";
            }
            
            IEnumerable<string> devices = ALC.GetStringList(GetEnumerationStringList.DeviceSpecifier);
            Logger.LogDebug($"Devices: {string.Join(", ", devices)}");

            // Get the default device, then go though all devices and select the AL soft device if it exists.
            string deviceName = ALC.GetString(ALDevice.Null, AlcGetString.DefaultDeviceSpecifier);
            foreach (var d in devices)
            {
                if (d.Contains("OpenAL Soft"))
                {
                    deviceName = d;
                }
            }

            if (ALC.EnumerateAll.IsExtensionPresent())
            {
                IEnumerable<string> allDevices = ALC.EnumerateAll.GetStringList(GetEnumerateAllContextStringList.AllDevicesSpecifier);
                Logger.LogDebug($"All Devices: {string.Join(", ", allDevices)}");
            }

            ALDevice = ALC.OpenDevice(deviceName);
            ALContext = ALC.CreateContext(ALDevice, (int[]?)null);
            ALC.MakeContextCurrent(ALContext);

            ALC.GetInteger(ALDevice, AlcGetInteger.MajorVersion, 1, out int alcMajorVersion);
            ALC.GetInteger(ALDevice, AlcGetInteger.MinorVersion, 1, out int alcMinorVersion);
            string alcExts = ALC.GetString(ALDevice, AlcGetString.Extensions);

            var attrs = ALC.GetContextAttributes(ALDevice);
            Logger.LogDebug($"Attributes: {attrs}");

            string exts = AL.Get(ALGetString.Extensions);
            string rend = AL.Get(ALGetString.Renderer);
            string vend = AL.Get(ALGetString.Vendor);
            string vers = AL.Get(ALGetString.Version);

            Logger.LogDebug($"Vendor: {vend}, \nVersion: {vers}, \nRenderer: {rend}, \nExtensions: {exts}, \nALC Version: {alcMajorVersion}.{alcMinorVersion}, \nALC Extensions: {alcExts}");

            AL.DistanceModel(ALDistanceModel.None);

            AL.Listener(ALListenerf.Gain, 1.0f);

            ALError error = AL.GetError();
            if (error != ALError.NoError)
            {
                Debug.Assert(false, $"ALError: {error}");
            }

            AmbientMusic = new Music(SoundClip.LoadSound("./Assets/Sounds/Ambience.ogg"));

            BreakSoundEffect = new SoundEffect(SoundClip.LoadSound("./Assets/Sounds/Rise01.ogg"));
            SwapSoundEffect = new SoundEffect(SoundClip.LoadSound("./Assets/Sounds/Swap.ogg"));

            watch.Stop();
            Logger.LogInfo($"Loading assets took: {watch.Elapsed.TotalMilliseconds}ms");

            AmbientMusic.SetGain(MusicVolume);
            AmbientMusic.Play();
        }

        Vector2 GetTileLocation(int x, int y)
        {
            return Vector2.Lerp((-3.5f, 3.5f), (3.5f, -3.5f), (x / (float)(Board.GetLength(1) - 1), y / (float)(Board.GetLength(1) - 1)));
        }

        /// <summary>Checks if a moved get will cause gems to break.</summary>
        bool WillBreakGems(Vector2i newPosition)
        {
            int upCount    = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (0, -1));
            int downCount  = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (0, +1));
            int leftCount  = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (-1, 0));
            int rightCount = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (+1, 0));

            bool brokeGems = false;

            int verticalCount = upCount + downCount - 1;
            int horizontalCount = leftCount + rightCount - 1;
            if (verticalCount >= 3)
            {
                brokeGems = true;
            }

            if (horizontalCount >= 3)
            {
                brokeGems = true;
            }

            return brokeGems;
        }

        bool IsValidMove(Vector2i gem1, Vector2i gem2)
        {
            // We try to swap the two gems and see if the change would break any gems.
            // Then we take care to swap them back so we don't change the board!
            (Board[gem1.X, gem1.Y], Board[gem2.X, gem2.Y]) = (Board[gem2.X, gem2.Y], Board[gem1.X, gem1.Y]);
            bool isValid = WillBreakGems(gem1) || WillBreakGems(gem2);
            (Board[gem1.X, gem1.Y], Board[gem2.X, gem2.Y]) = (Board[gem2.X, gem2.Y], Board[gem1.X, gem1.Y]);
            return isValid;
        }

        int CountLegalMoves()
        {
            int legalMoves = 0;
            for (int x = 0; x < Board.GetLength(0) - 1; x++)
            {
                for (int y = 0; y < Board.GetLength(1) - 1; y++)
                {
                    if (IsValidMove((x, y), (x + 1, y)))
                    {
                        legalMoves++;
                    }

                    if (IsValidMove((x, y), (x, y + 1)))
                    {
                        legalMoves++;
                    }
                }
            }

            return legalMoves;
        }

        bool HandleMovedGem(Vector2i newPosition)
        {
            int upCount = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (0, -1));
            int downCount = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (0, +1));
            int leftCount = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (-1, 0));
            int rightCount = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (+1, 0));

            bool brokeGems = false;

            int verticalCount = upCount + downCount - 1;
            int horizontalCount = leftCount + rightCount - 1;
            if (verticalCount >= 3)
            {
                brokeGems = true;
                for (int y = newPosition.Y - upCount + 1; y < newPosition.Y + downCount; y++)
                {
                    Board[newPosition.X, y] = Gem.Empty;
                }
            }

            if (horizontalCount >= 3)
            {
                brokeGems = true;
                for (int x = newPosition.X - leftCount + 1; x < newPosition.X + rightCount; x++)
                {
                    Board[x, newPosition.Y] = Gem.Empty;
                }
            }

            return brokeGems;
        }

        int CountMatchesInDirection(Gem startGem, Vector2i position, Vector2i direction)
        {
            int count = 0;
            do
            {
                count++;
                position += direction;
            }
            while (position.X >= 0 && position.X < Board.GetLength(0) &&
                   position.Y >= 0 && position.Y < Board.GetLength(1) &&
                   Board[position.X, position.Y] == startGem);

            return count;
        }

        float Time = 0;
        MouseState PrevMouseState;
        bool[] PrevKeyboardState = new bool[256];
        bool[] KeyboardState = new bool[256];
        public bool Update(float deltaTime)
        {
            Time += deltaTime;

            SwapSoundEffect.Update();
            BreakSoundEffect.Update();

            Toolkit.Mouse.GetMouseState(out MouseState mouseState);
            Toolkit.Keyboard.GetKeyboardState(KeyboardState);

            if (Toolkit.Window.IsFocused(Window) == false)
            {
                // If the window is not focused we don't want to
                // process any game logic.
                PrevMouseState = mouseState;
                return false;
            }

            Vector2i clientPosition;
            Toolkit.Window.ScreenToClient(Window, mouseState.Position.X, mouseState.Position.Y, out clientPosition.X, out clientPosition.Y);

            Toolkit.Window.GetClientSize(Window, out int clientWidth, out int clientHeight);

            switch (CurrentState)
            {
                case State.Idle:
                    DoIdle(deltaTime);
                    break;
                case State.AnimatingPlayerMove:
                    DoPlayerMoveAnimation(deltaTime);
                    break;
                case State.Falling:
                    DoFalling(deltaTime);
                    break;
                default:
                    break;
            }

            Array.Copy(KeyboardState, PrevKeyboardState, KeyboardState.Length);
            PrevMouseState = mouseState;
            return false;

            void DoIdle(float deltaTime)
            {
                bool inWindow = false;
                if (clientPosition.X >= 0 && clientPosition.X < clientWidth &&
                    clientPosition.Y >= 0 && clientPosition.Y < clientHeight)
                {
                    inWindow = true;
                }

                HoveredGem = (clientPosition * 8) / (clientWidth, clientHeight);

                if (inWindow && mouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) && PrevMouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) == false)
                {
                    SelectedGem = HoveredGem;
                    StartPosition = ((Vector2)clientPosition * 8.0f) / (clientWidth, clientHeight) - new Vector2(4.0f, 4.0f);
                    StartPosition.Y *= -1;
                }
                else if (mouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) && PrevMouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1))
                {
                    if (SelectedGem != (-1, -1))
                    {
                        Vector2 worldPos = ((Vector2)clientPosition * 8.0f) / (clientWidth, clientHeight) - new Vector2(4.0f, 4.0f);
                        worldPos.Y *= -1;
                        Vector2 tilePos = GetTileLocation(SelectedGem.X, SelectedGem.Y);
                        Vector2 delta = worldPos - StartPosition;
                        if (delta.Length > 1.0f)
                            delta = delta.Normalized() * 1.0f;
                        // This metric penalizes diagonal directions so the gem follows the cursor less in diagonal directions.
                        float metric = (3.0f * delta.X) * (3.0f * delta.X) * (3.0f * delta.Y) * (3.0f * delta.Y) + delta.Length * delta.Length + 1.0f;
                        delta = 0.1f * (delta / metric);
                        BoardPositions[SelectedGem.X, SelectedGem.Y] = tilePos + delta;
                    }
                }
                else if (mouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) == false && PrevMouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1))
                {
                    if (SelectedGem != (-1, -1))
                    {
                        Vector2i diff = SelectedGem - HoveredGem;
                        bool doMove = false;
                        Logger.LogDebug($"Selected: {SelectedGem}, Hovered: {HoveredGem}, Diff: {diff}");
                        if (float.Abs(diff.X) > float.Abs(diff.Y) &&
                            SelectedGem.X - int.Sign(diff.X) >= 0 &&
                            SelectedGem.X - int.Sign(diff.X) < Board.GetLength(0))
                        {
                            MovingGem1 = SelectedGem;
                            MovingGem2 = SelectedGem - new Vector2i(int.Sign(diff.X), 0);
                            if (IsValidMove(MovingGem1, MovingGem2))
                            {
                                doMove = true;
                            }
                        }
                        else if (float.Abs(diff.X) < float.Abs(diff.Y) &&
                            SelectedGem.Y - int.Sign(diff.Y) >= 0 &&
                            SelectedGem.Y - int.Sign(diff.Y) < Board.GetLength(1))
                        {
                            MovingGem1 = SelectedGem;
                            MovingGem2 = SelectedGem - new Vector2i(0, int.Sign(diff.Y));
                            if (IsValidMove(MovingGem1, MovingGem2))
                            {
                                doMove = true;
                            }
                        }

                        if (doMove)
                        {
                            AnimationTime = 0.0f;
                            CurrentState = State.AnimatingPlayerMove;

                            SwapSoundEffect.PlayOneShot(SwapSFXVolume, MathHelper.Lerp(0.95f, 1.05f, Random.Shared.NextSingle()));
                        }

                        BoardPositions[SelectedGem.X, SelectedGem.Y] = GetTileLocation(SelectedGem.X, SelectedGem.Y);
                        SelectedGem = (-1, -1);
                    }
                }

                int moves = CountLegalMoves();
                if (moves == 0 && KeyboardState[(int)Scancode.R] && PrevKeyboardState[(int)Scancode.R] == false)
                {
                    for (int x = 0; x < Board.GetLength(0); x++)
                    {
                        for (int y = 0; y < Board.GetLength(1); y++)
                        {
                            Board[x, y] = Gem.Empty;
                        }
                    }

                    // FIXME: Play nice sound effect.

                    CurrentState = State.Falling;

                    // If there was a selected gem, deselect and reset position.
                    if (SelectedGem != (-1, -1))
                    {
                        BoardPositions[SelectedGem.X, SelectedGem.Y] = GetTileLocation(SelectedGem.X, SelectedGem.Y);
                        SelectedGem = (-1, -1);
                    }
                }
            }

            void DoPlayerMoveAnimation(float deltaTime)
            {
                AnimationTime += deltaTime;
                if (AnimationTime >= SwapAnimationTime)
                {
                    // The swap is complete. Change the board state.
                    (Board[MovingGem1.X, MovingGem1.Y], Board[MovingGem2.X, MovingGem2.Y]) = (Board[MovingGem2.X, MovingGem2.Y], Board[MovingGem1.X, MovingGem1.Y]);

                    BoardPositions[MovingGem1.X, MovingGem1.Y] = GetTileLocation(MovingGem1.X, MovingGem1.Y);
                    BoardPositions[MovingGem2.X, MovingGem2.Y] = GetTileLocation(MovingGem2.X, MovingGem2.Y);

                    // Check if any of the moved gems now line up with any other gems
                    bool brokeGems = false;
                    brokeGems |= HandleMovedGem(MovingGem1);
                    brokeGems |= HandleMovedGem(MovingGem2);

                    if (brokeGems)
                    {
                        BreakSoundEffect.PlayOneShot(BreakSFXVolume, 1.0f);
                    }

                    CurrentState = State.Falling;
                }
                else
                {
                    static float EaseOutExpo(float x)
                    {
                        return x >= 1 ? 1 : 1 - MathF.Pow(2, -10 * x);
                    }

                    float t = EaseOutExpo(AnimationTime / SwapAnimationTime);

                    Vector2 gem1Orig = GetTileLocation(MovingGem1.X, MovingGem1.Y);
                    Vector2 gem2Orig = GetTileLocation(MovingGem2.X, MovingGem2.Y);

                    Vector2 gem1Current = Vector2.Lerp(gem1Orig, gem2Orig, t);
                    Vector2 gem2Current = Vector2.Lerp(gem2Orig, gem1Orig, t);

                    BoardPositions[MovingGem1.X, MovingGem1.Y] = gem1Current;
                    BoardPositions[MovingGem2.X, MovingGem2.Y] = gem2Current;
                }
            }

            void DoFalling(float deltaTime)
            {
                FallSpeed += FallAcceleration * deltaTime;
                if (FallSpeed > FallMaxSpeed)
                    FallSpeed = FallMaxSpeed;
                FallingTime += FallSpeed * deltaTime;

                bool anyStillFalling = false;
                for (int x = 0; x < Board.GetLength(0); x++)
                {
                    // For every column, find the first empty space.
                    // Move all gems in that direction.
                    for (int y = Board.GetLength(1) - 1; y >= 0; y--)
                    {
                        if (Board[x, y] == Gem.Empty)
                        {
                            if (FallingTime >= FallAnimationTime)
                            {
                                for (int y2 = 0; y2 < Board.GetLength(1); y2++)
                                {
                                    if (Board[x, y] == Gem.Empty)
                                    {
                                        anyStillFalling = true;
                                        break;
                                    }
                                }

                                // We are done falling, move column down.
                                for (; y > 0; y--)
                                {
                                    (Board[x, y], Board[x, y - 1]) = (Board[x, y - 1], Board[x, y]);
                                    
                                    BoardPositions[x, y] = GetTileLocation(x, y);
                                }

                                // Fill the topmost slot with a gem.
                                if (TopRow[x] == Gem.Empty)
                                {
                                    TopRow[x] = ChooseGems[Random.Shared.Next(ChooseGems.Length)];
                                }
                                Board[x, y] = TopRow[x];
                                TopRow[x] = Gem.Empty;
                                BoardPositions[x, y] = GetTileLocation(x, y);
                            }
                            else
                            {
                                float t = FallingTime / FallAnimationTime;

                                for (; y >= 0; y--)
                                {
                                    Vector2 start = GetTileLocation(x, y);
                                    Vector2 end = GetTileLocation(x, y + 1);
                                    BoardPositions[x, y] = Vector2.Lerp(start, end, t);
                                }

                                if (TopRow[x] == Gem.Empty)
                                {
                                    TopRow[x] = ChooseGems[Random.Shared.Next(ChooseGems.Length)];
                                }

                                TopRowPositions[x] = Vector2.Lerp(GetTileLocation(x, -1), GetTileLocation(x, 0), t);

                                anyStillFalling = true;
                            }
                            break;
                        }
                    }
                }

                if (FallingTime >= FallAnimationTime)
                {
                    FallingTime = 0;
                }

                if (anyStillFalling == false)
                {
                    FallSpeed = FallStartSpeed;

                    bool combo = false;
                    for (int x = 0; x < Board.GetLength(0); x++)
                    {
                        for (int y = 0; y < Board.GetLength(1); y++)
                        {
                            // FIXME: This will not work as this might break
                            // blocks that should be in a separate combo.
                            // We should make these functions update a "break mask"
                            // where we mark gems for destructions so we can apply
                            // all of the destruction all at once.
                            combo |= HandleMovedGem((x, y));
                        }
                    }

                    if (combo)
                    {
                        FallingComboCount++;
                        BreakSoundEffect.PlayOneShot(BreakSFXVolume, MathHelper.Lerp(1.0f, 1.2f, float.Clamp(FallingComboCount / (float)10, 0, 1)));
                    }

                    if (combo == false)
                    {
                        Logger.LogInfo("Done falling!");
                        CurrentState = State.Idle;
                        FallingComboCount = 0;

                        int moves = CountLegalMoves();
                        Logger.LogDebug($"Legal moves: {moves}!");

                        Toolkit.Window.SetTitle(Window, $"Bejeweled ({moves} possible moves)");
                        if (moves == 0)
                        {
                            Toolkit.Window.SetTitle(Window, $"Bejeweled ({moves} possible moves, press R to reset)");
                        }

                        for (int x = 0; x < Board.GetLength(0); x++)
                        {
                            for (int y = 0; y < Board.GetLength(1); y++)
                            {
                                if (Board[x, y] == Gem.Empty)
                                {
                                    Debug.Assert(false);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void Render()
        {
            const float NearPlane = 0.1f;
            const float FarPlane = 10.0f;
            Matrix4 view = Matrix4.Identity;
            Matrix4 projection = Matrix4.CreateOrthographic(8, 8, NearPlane, FarPlane);
            Matrix4 viewProjection = view * projection;

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, RefractionInfoFramebuffer.Handle);

            GL.ClearDepth(0);
            GL.DepthFunc(DepthFunction.Greater);

            GL.ClearColor(Color4.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.UseProgram(GemNormalShader.Program.Handle);

            for (int x = 0; x < Board.GetLength(0); x++)
            {
                for (int y = 0; y < Board.GetLength(1); y++)
                {
                    Gem gem = Board[x, y];
                    RenderGemNormal(gem, BoardPositions[x, y]);
                }

                RenderGemNormal(TopRow[x], TopRowPositions[x]);
            }

            void RenderGemNormal(Gem gem, Vector2 position)
            {
                if (gem == Gem.Empty)
                    return;

                GemVisual visual = GetGemVisual(gem);

                GL.BindVertexArray(visual.VAO);

                Matrix4 model =
                    Matrix4.CreateScale(0.95f) *
                    Matrix4.CreateRotationY(MathF.Sin(Time * 1.6f * 0.3f) * MathHelper.DegreesToRadians(15)) *
                    Matrix4.CreateRotationX(MathF.Cos(Time * 1.1f * 0.3f) * MathHelper.DegreesToRadians(10)) *
                    Matrix4.CreateTranslation(new Vector3(position, -2));
                Matrix4 mvp = model * view * projection;
                Matrix3 normalMat = Matrix3.Invert(Matrix3.Transpose(new Matrix3(model)));
                GL.UniformMatrix4f(GemNormalShader.UniformLocationMVP, 1, true, mvp);
                GL.UniformMatrix4f(GemNormalShader.UniformLocationModel, 1, true, model);
                GL.UniformMatrix3f(GemNormalShader.UniformLocationNormalMat, 1, true, normalMat);

                GL.DrawElements(PrimitiveType.Triangles, visual.Elements, DrawElementsType.UnsignedShort, 0);
            }

            Toolkit.Window.GetFramebufferSize(Window, out int fbWidth, out int fbHeight);

            //GL.BindFramebuffer(FramebufferTarget.DrawFramebuffer, 0);
            //GL.BlitFramebuffer(0, 0, fbWidth, fbHeight, 0, 0, fbWidth, fbHeight, ClearBufferMask.ColorBufferBit, BlitFramebufferFilter.Nearest);
            //GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
            //GL.BindFramebuffer(FramebufferTarget.Framebuffer, DebugFramebuffer.Handle);

            GL.ClearDepth(1);
            GL.DepthFunc(DepthFunction.Less);

            GL.ClearColor(Color4.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.UseProgram(GemShader.Program.Handle);

            
            GL.Uniform1i(GemShader.UniformLocationEnvironmentMap, 0);
            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.TextureCubeMap, EnvironmentMap.Handle);

            GL.Uniform1i(GemShader.UniformLocationIrradianceMap, 1);
            GL.ActiveTexture(TextureUnit.Texture1);
            GL.BindTexture(TextureTarget.TextureCubeMap, IrradianceMap.Handle);

            GL.Uniform1i(GemShader.UniformLocationPrefilteredEnvironmentMap, 2);
            GL.ActiveTexture(TextureUnit.Texture2);
            GL.BindTexture(TextureTarget.TextureCubeMap, PrefilteredEnvironmentMap.Handle);
            
            GL.Uniform1i(GemShader.UniformLocationBRDFLUT, 3);
            GL.ActiveTexture(TextureUnit.Texture3);
            GL.BindTexture(TextureTarget.Texture2d, BrdfLUT.Handle);
            
            GL.Uniform1i(GemShader.UniformLocationBackfaceNormals, 4);
            GL.ActiveTexture(TextureUnit.Texture4);
            GL.BindTexture(TextureTarget.Texture2d, RefractionInfoFramebuffer.ColorAttachement0);

            GL.Uniform1i(GemShader.UniformLocationBackfaceDepth, 5);
            GL.ActiveTexture(TextureUnit.Texture5);
            GL.BindTexture(TextureTarget.Texture2d, RefractionInfoFramebuffer.DepthAttachement);
            
            GL.Uniform1f(GemShader.UniformLocationDepthScale, FarPlane - NearPlane);

            for (int x = 0; x < Board.GetLength(0); x++)
            {
                for (int y = 0; y < Board.GetLength(1); y++)
                {
                    Gem gem = Board[x, y];
                    RenderGem(gem, BoardPositions[x, y], (x, y) == HoveredGem, (x, y) == SelectedGem);
                }

                RenderGem(TopRow[x], TopRowPositions[x], false, false);
            }

            void RenderGem(Gem gem, Vector2 position, bool hovered, bool selected)
            {
                if (gem == Gem.Empty)
                    return;

                Vector3 tint;
                if (selected)
                    tint = GemColors[(int)gem] + (0.4f, 0.4f, 0.4f);
                else if (hovered)
                    tint = GemColors[(int)gem] + (0.2f, 0.2f, 0.2f);
                else
                    tint = GemColors[(int)gem];

                GemVisual visual = GetGemVisual(gem);

                GL.BindVertexArray(visual.VAO);

                Matrix4 model =
                    Matrix4.CreateScale(0.95f) *
                    Matrix4.CreateRotationY(MathF.Sin(Time * 1.6f * 0.3f) * MathHelper.DegreesToRadians(15)) *
                    Matrix4.CreateRotationX(MathF.Cos(Time * 1.1f * 0.3f) * MathHelper.DegreesToRadians(10)) *
                    Matrix4.CreateTranslation(new Vector3(position, -2));
                Matrix4 mvp = model * viewProjection;
                Matrix3 normalMat = Matrix3.Invert(Matrix3.Transpose(new Matrix3(model)));
                GL.UniformMatrix4f(GemShader.UniformLocationMVP, 1, true, mvp);
                GL.UniformMatrix4f(GemShader.UniformLocationModel, 1, true, model);
                GL.UniformMatrix4f(GemShader.UniformLocationViewProjection, 1, true, viewProjection);
                GL.UniformMatrix3f(GemShader.UniformLocationNormalMat, 1, true, normalMat);

                GL.Uniform2f(GemShader.UniformLocationScreenSize, fbWidth, fbHeight);

                GL.Uniform3f(GemShader.UniformLocationTint, 1, tint);
                GL.Uniform3f(GemShader.UniformLocationF0, 1, GemF0s[(int)gem]);

                GL.DrawElements(PrimitiveType.Triangles, visual.Elements, DrawElementsType.UnsignedShort, 0);
            }

            //GL.BindFramebuffer(FramebufferTarget.DrawFramebuffer, 0);
            //GL.BlitFramebuffer(0,0,fbWidth,fbHeight,0,0,fbWidth,fbHeight,ClearBufferMask.ColorBufferBit,BlitFramebufferFilter.Nearest);

            Toolkit.OpenGL.SwapBuffers(Context);
        }

        private GemVisual GetGemVisual(Gem gem)
        {
            GemVisual visual;
            switch (gem)
            {
                case Gem.Diamond:
                    visual = DiamondVisual;
                    break;
                case Gem.Ruby:
                    visual = RubyVisual;
                    break;
                case Gem.Emerald:
                    visual = EmeraldVisual;
                    break;
                case Gem.Sapphire:
                    visual = SapphireVisual;
                    break;
                case Gem.Topaz:
                    visual = TopazVisual;
                    break;
                case Gem.Amethyst:
                    visual = AmethystVisual;
                    break;
                case Gem.Zircon:
                    visual = ZirconVisual;
                    break;
                case Gem.Empty:
                default:
                    throw new UnreachableException();
            }
            return visual;
        }

        public void Deinitialize()
        {
            ALC.MakeContextCurrent(ALContext.Null);
            ALC.DestroyContext(ALContext);
            ALC.CloseDevice(ALDevice);
        }

        public readonly static GLDebugProc DebugProcCallback = Window_DebugProc;
        private static void Window_DebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr messagePtr, IntPtr userParam)
        {
            string message = Marshal.PtrToStringAnsi(messagePtr, length);

            bool showMessage = true;

            switch (source)
            {
                case DebugSource.DebugSourceApplication:
                    showMessage = false;
                    break;
                case DebugSource.DontCare:
                case DebugSource.DebugSourceApi:
                case DebugSource.DebugSourceWindowSystem:
                case DebugSource.DebugSourceShaderCompiler:
                case DebugSource.DebugSourceThirdParty:
                case DebugSource.DebugSourceOther:
                default:
                    showMessage = true;
                    break;
            }

            if (showMessage)
            {
                switch (severity)
                {
                    case DebugSeverity.DontCare:
                        Logger?.LogInfo($"[DontCare] [{source}] {message}");
                        break;
                    case DebugSeverity.DebugSeverityNotification:
                        //Logger?.LogDebug($"[{source}] {message}");
                        break;
                    case DebugSeverity.DebugSeverityHigh:
                        Logger?.LogError($"[{source}] {message}");
                        break;
                    case DebugSeverity.DebugSeverityMedium:
                        Logger?.LogWarning($"[{source}] {message}");
                        break;
                    case DebugSeverity.DebugSeverityLow:
                        Logger?.LogInfo($"[{source}] {message}");
                        break;
                    default:
                        Logger?.LogInfo($"[default] [{source}] {message}");
                        break;
                }
            }
        }
    }
}
