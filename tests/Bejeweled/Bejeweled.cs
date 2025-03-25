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
using ImGuiNET;

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

        public int UniformLocationViewport;
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

            shader.UniformLocationViewport = GL.GetUniformLocation(shader.Program.Handle, "uViewport");
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
        // Hacky stuff to be able to set the gain of all sound effects at the same time.
        // - Noggin_bops 2025-03-12
        static float SoundEffectGain = 1.0f;
        static List<WeakReference<SoundEffect>> AllSoundEffects = new List<WeakReference<SoundEffect>>();
        public static void SetGain(float gain)
        {
            SoundEffectGain = gain;
            for (int i = AllSoundEffects.Count - 1; i >= 0; i--)
            {
                WeakReference<SoundEffect> reference = AllSoundEffects[i];
                if (reference.TryGetTarget(out SoundEffect? effect))
                {
                    foreach (Source source in effect.Sources)
                    {
                        AL.Source(source.ALSource, ALSourcef.Gain, source.Gain * gain);
                    }
                }
                else
                {
                    AllSoundEffects.RemoveAt(i);
                }
            }
        }

        struct Source
        {
            public int ALSource;
            public float Gain;

            public Source(int alSource, float gain)
            {
                ALSource = alSource;
                Gain = gain;
            }
        }

        public SoundClip Clip;
        List<Source> Sources = new List<Source>();

        public SoundEffect(SoundClip clip)
        {
            Clip = clip;

            AllSoundEffects.Add(new WeakReference<SoundEffect>(this));
        }

        public void Update()
        {
            for (int i = Sources.Count - 1; i >= 0; i--)
            {
                int source = Sources[i].ALSource;
                if ((ALSourceState)AL.GetSource(source, ALGetSourcei.SourceState) == ALSourceState.Stopped)
                {
                    AL.DeleteSource(source);
                    Sources.RemoveAt(i);
                }
            }
        }

        public void PlayOneShot(float gain, float pitch)
        {
            int source = AL.GenSource();
            AL.Source(source, ALSourcei.Buffer, Clip.Buffer);
            AL.Source(source, ALSourceb.Looping, false);

            AL.Source(source, ALSourcef.Gain, gain * SoundEffectGain);
            AL.Source(source, ALSourcef.Pitch, pitch);

            AL.SourcePlay(source);

            ALError error = AL.GetError();
            if (error != ALError.NoError)
            {
                Debug.Assert(false, $"ALError: {error}");
            }

            Sources.Add(new Source(source, gain));
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
        public int Width, Height;

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

            static int MultipleOfRoundingUp(int value, int multiple)
            {
                return multiple * ((value + multiple - 1) / multiple);
            }

            int dataOffset = 0;
            int mipWidth = image.Width;
            int mipHeight = image.Height;
            for (int i = 0; i < image.MipmapCount; i++)
            {
                int dataLength = MultipleOfRoundingUp(mipWidth, 4) * MultipleOfRoundingUp(mipHeight, 4);
                if (compressed)
                {
                    GL.CompressedTexImage2D(target, i, (InternalFormat)internalFormat, mipWidth, mipHeight, 0, dataLength, (nint)Unsafe.AsPointer(ref image.AllData[dataOffset]));
                }
                else
                {
                    GL.TexImage2D(target, i, (InternalFormat)internalFormat, mipWidth, mipHeight, 0, pixelFormat, pixelType, (nint)Unsafe.AsPointer(ref image.AllData[dataOffset]));
                }
                dataOffset += dataLength;
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

            return new Texture(texture, image.Width, image.Height);
        }

        public Texture(int handle, int width, int height)
        {
            Handle = handle;
            Width = width;
            Height = height;
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
            GL.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.Rgba16, width, height, 0, PixelFormat.Rgba, PixelType.Float, IntPtr.Zero);

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

    internal struct BreakEffect
    {
        public int Score;
        public Vector3 Color;
        public Vector2 Position;

        public float Timer = 0;

        public BreakEffect(int score, Vector3 color, Vector2 position)
        {
            Score = score;
            Color = color;
            Position = position;
        }

        // Maybe add particle data?


    }

    internal struct BreakParticle
    {
        public Vector2 Position;
        public Vector2 Velocity;
        public Vector3 Color;
        public float Timer = 0;
        public float Delay = 0;
        public int Score;
        public bool Done = false;

        public BreakParticle(Vector2 position, Vector2 velocity, Vector3 color, float delay, int score)
        {
            Position = position;
            Velocity = velocity;
            Color = color;
            Delay = delay;
            Score = score;
        }
    }

    static class VectorExtensions
    {
        public static ref System.Numerics.Vector2 AsNumerics(this ref Vector2 v) => ref Unsafe.As<Vector2, System.Numerics.Vector2>(ref v);
        public static ref System.Numerics.Vector3 AsNumerics(this ref Vector3 v) => ref Unsafe.As<Vector3, System.Numerics.Vector3>(ref v);
        public static ref System.Numerics.Vector4 AsNumerics(this ref Vector4 v) => ref Unsafe.As<Vector4, System.Numerics.Vector4>(ref v);

        public static System.Numerics.Vector2 ToNumerics(this Vector2 v) => Unsafe.As<Vector2, System.Numerics.Vector2>(ref v);
        public static System.Numerics.Vector3 ToNumerics(this Vector3 v) => Unsafe.As<Vector3, System.Numerics.Vector3>(ref v);
        public static System.Numerics.Vector4 ToNumerics(this Vector4 v) => Unsafe.As<Vector4, System.Numerics.Vector4>(ref v);
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

        ImGuiController ImGuiController;
        ImDrawListPtr UIOverlayDrawlist;
        ImDrawListPtr UIBaseDrawlist;
        ImDrawDataPtr CustomDrawData;
        ImFontPtr CurrentImGuiFont;

        Framebuffer RefractionInfoFramebuffer;

        Framebuffer DebugFramebuffer;

        Texture SfxUnmutedTexture;
        Texture SfxMutedTexture;

        Texture MusicUnmutedTexture;
        Texture MusicMutedTexture;

        bool SfxMuted = false;
        bool MusicMuted = false;

        Texture BrdfLUT;
        Cubemap EnvironmentMap;
        Cubemap IrradianceMap;
        Cubemap PrefilteredEnvironmentMap;

        List<BreakEffect> BreakEffects = new List<BreakEffect>();
        List<BreakParticle> BreakParticles = new List<BreakParticle>();

        Texture ParticleTexture;

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
        internal const float SfxVolume = 1.0f;

        internal const float BreakSFXVolume = 0.5f;
        internal const float SwapSFXVolume = 0.25f;

        Music AmbientMusic;

        SoundEffect BreakSoundEffect;
        SoundEffect SwapSoundEffect;
        SoundEffect PointSoundEffect;

        SoundEffect ButtonPressEffect;

        internal Gem[,] Board = new Gem[8, 8];
        internal Vector2[,] BoardPositions = new Vector2[8, 8];
        internal Gem[] TopRow = new Gem[8];
        internal Vector2[] TopRowPositions = new Vector2[8];


        State CurrentState;
        int Score = 0;

        // Idle state
        internal Vector2i HoveredGem = (-1, -1);
        internal Vector2i SelectedGem = (-1, -1);
        internal Vector2 StartPosition;

        internal float HintJiggleTimer = 0;
        internal float HintJiggleAnimationTimer = 0;
        internal const float HintTime = 5.0f;
        internal (Vector2i, Vector2i)? JigglePair;

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
        internal int BrokenGemsComboCount = 0;

        internal const float ParticleDelayTime = 0.18f;
        internal float ParticlePitchResetTimer = 0.0f;
        internal const float ParticlePitchResetTime = 1.5f;
        internal int ParticlePitchCounter = 0;

        public unsafe void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES, ILogger logger)
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

            Toolkit.Window.GetFramebufferSize(Window, out Vector2i fbSize);
            nint oldImguiContext = ImGui.GetCurrentContext();
            ImGuiController = new ImGuiController(fbSize.X, fbSize.Y, useGLES);
            {
                float scale = 6;
                ImFontConfig config = new ImFontConfig();
                config.FontDataOwnedByAtlas = 1;
                config.OversampleH = 3;
                config.OversampleV = 3;
                config.PixelSnapH = 1;
                config.GlyphMaxAdvanceX = float.PositiveInfinity;
                config.RasterizerMultiply = 1;
                config.EllipsisChar = 0xFFFF;
                config.RasterizerDensity = 1;
                unsafe
                {
                    ImFontConfigPtr configPtr = new ImFontConfigPtr(&config);
                    CurrentImGuiFont = ImGui.GetIO().Fonts.AddFontFromFileTTF("./Assets/Fonts/ChivoMono-Regular.ttf", float.Floor(13 * scale), configPtr);
                }
            }
            ImGuiController.RecreateFontDeviceTexture();
            EventQueue.EventRaised += EventQueue_EventRaised;
            
            UIBaseDrawlist = new ImDrawListPtr((ImDrawList*)NativeMemory.AllocZeroed((nuint)sizeof(ImDrawList)));
            UIBaseDrawlist._Data = ImGui.GetDrawListSharedData();

            UIOverlayDrawlist = new ImDrawListPtr((ImDrawList*)NativeMemory.AllocZeroed((nuint)sizeof(ImDrawList)));
            UIOverlayDrawlist._Data = ImGui.GetDrawListSharedData();

            CustomDrawData = new ImDrawDataPtr((ImDrawData*)NativeMemory.AllocZeroed((nuint)sizeof(ImDrawData)));
            CustomDrawData.Clear();

            GemShader = GemShader.Init("./Assets/Shaders/Gem.vert", "./Assets/Shaders/Gem.frag", Logger);
            GemNormalShader = GemNormalShader.Init("./Assets/Shaders/Gem.vert", "./Assets/Shaders/Normal.frag", Logger);

            Toolkit.Window.GetFramebufferSize(Window, out Vector2i framebufferSize);
            RefractionInfoFramebuffer = Framebuffer.CreateNormalDepthFramebuffer(framebufferSize.X, framebufferSize.Y);

            //DebugFramebuffer = Framebuffer.CreateDebugFramebufferMS(framebufferWidth, framebufferHeight, 16);

            DiamondVisual = GemVisual.Create(Gem.Diamond, "./Assets/Models/Diamond.glb");
            RubyVisual = GemVisual.Create(Gem.Ruby, "./Assets/Models/Ruby.glb");
            EmeraldVisual = GemVisual.Create(Gem.Emerald, "./Assets/Models/Emerald.glb");
            SapphireVisual = GemVisual.Create(Gem.Emerald, "./Assets/Models/Sapphire.glb");
            TopazVisual = GemVisual.Create(Gem.Topaz, "./Assets/Models/Topaz.glb");
            AmethystVisual = GemVisual.Create(Gem.Amethyst, "./Assets/Models/Amethyst.glb");
            ZirconVisual = GemVisual.Create(Gem.Zircon, "./Assets/Models/Zircon.glb");

            SfxUnmutedTexture = Texture.LoadTexture("./Assets/Textures/sfx_unmute.dds");
            SfxMutedTexture = Texture.LoadTexture("./Assets/Textures/sfx_mute.dds");

            MusicUnmutedTexture = Texture.LoadTexture("./Assets/Textures/music_unmute.dds");
            MusicMutedTexture = Texture.LoadTexture("./Assets/Textures/music_mute.dds");

            BrdfLUT = Texture.LoadTexture("./Assets/Textures/dancing_hall_4kBrdf.dds");

            EnvironmentMap = Cubemap.LoadCubemap("./Assets/Textures/dancing_hall_4kEnvHDR.dds");
            IrradianceMap = Cubemap.LoadCubemap("./Assets/Textures/dancing_hall_4kDiffuseHDR.dds");
            PrefilteredEnvironmentMap = Cubemap.LoadCubemap("./Assets/Textures/dancing_hall_4kSpecularHDR.dds");

            ParticleTexture = Texture.LoadTexture("./Assets/Textures/particle.dds");

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

            ButtonPressEffect = new SoundEffect(SoundClip.LoadSound("./Assets/Sounds/switch8.ogg"));

            PointSoundEffect = new SoundEffect(SoundClip.LoadSound("./Assets/Sounds/Coin01.ogg"));

            watch.Stop();
            Logger.LogInfo($"Loading assets took: {watch.Elapsed.TotalMilliseconds}ms");

            ImGui.SetCurrentContext(oldImguiContext);
        }

        public void TransitionToGame()
        {
            // We don't generate a starting board, instead we go directly into the falling
            // state and let it populate the board.
            CurrentState = State.Falling;
            for (int x = 0; x < Board.GetLength(0); x++)
            {
                TopRow[x] = ChooseGems[Random.Shared.Next(ChooseGems.Length)];
                TopRowPositions[x] = GetTileLocation(x, -1);

                for (int y = 0; y < Board.GetLength(1); y++)
                {
                    Board[x, y] = Gem.Empty;

                    BoardPositions[x, y] = GetTileLocation(x, y);
                }
            }

            // FIXME: Maybe put a fade-in envelope on this?
            AmbientMusic.SetGain(MusicVolume);
            AmbientMusic.Play();
        }

        // FIXME: Better place..
        const float UI_LEFT_PAD = 0.1f;
        const float UI_BOTTOM_PAD = 0.1f;

        public Box2i GetGemBoardBox()
        {
            Toolkit.Window.GetFramebufferSize(Window, out Vector2i fbSize);
            int leftPadPx = (int)(fbSize.X * UI_LEFT_PAD);
            int bottomPadPx = (int)(fbSize.Y * UI_BOTTOM_PAD);
            return new Box2i(leftPadPx, 0, fbSize.X, fbSize.Y - bottomPadPx);
        }

        public Vector4i GetGemBoardViewport()
        {
            Box2i board = GetGemBoardBox();
            Toolkit.Window.GetFramebufferSize(Window, out Vector2i fbSize);
            int y = (fbSize.Y - (board.Y + board.Height));
            return new Vector4i(board.X, y, board.Width, board.Height);
        }

        public bool TryClientPosToTile(Vector2 clientPos, out Vector2i tile)
        {
            Toolkit.Window.ClientToFramebuffer(Window, clientPos, out Vector2 fbPos);
            return TryFramebufferPosToTile(fbPos, out tile);
        }

        public bool TryFramebufferPosToTile(Vector2 fbPos, out Vector2i tile)
        {
            Box2i board = GetGemBoardBox();
            // FIXME: Contains functions for Box2i that take Vector2?
            if (board.ContainsInclusive((Vector2i)fbPos))
            {
                tile = (Vector2i)Vector2.Floor(((fbPos - board.Min) / board.Size) * 8);
                return true;
            }
            else
            {
                tile = (Vector2i)Vector2.Floor(((fbPos - board.Min) / board.Size) * 8);
                return false;
            }
        }

        Vector2 GetTileLocation(int x, int y)
        {
            return Vector2.Lerp((-3.5f, 3.5f), (3.5f, -3.5f), (x / (float)(Board.GetLength(1) - 1), y / (float)(Board.GetLength(1) - 1)));
        }

        Vector2 GetTileLocation(float x, float y)
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

        List<(Vector2i, Vector2i)> GetLegalMoves()
        {
            List<(Vector2i, Vector2i)> legalMoves = new List<(Vector2i, Vector2i)>();
            for (int x = 0; x < Board.GetLength(0) - 1; x++)
            {
                for (int y = 0; y < Board.GetLength(1) - 1; y++)
                {
                    if (IsValidMove((x, y), (x + 1, y)))
                    {
                        legalMoves.Add(((x, y), (x + 1, y)));
                    }

                    if (IsValidMove((x, y), (x, y + 1)))
                    {
                        legalMoves.Add(((x, y), (x, y + 1)));
                    }
                }
            }

            return legalMoves;
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

        Vector2 RandomDirection(Random rand)
        {
            float theta = rand.NextSingle() * MathHelper.TwoPi;
            return (MathF.Cos(theta), MathF.Sin(theta));
        }

        /// <returns>How many gems where broken, if any.</returns>
        int HandleMovedGem(Vector2i newPosition)
        {
            Gem gemType = Board[newPosition.X, newPosition.Y];
            if (gemType == Gem.Empty)
            {
                // This position has already been broken, so we don't need to do anything here.
                return 0;
            }


            int upCount = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (0, -1));
            int downCount = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (0, +1));
            int leftCount = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (-1, 0));
            int rightCount = CountMatchesInDirection(Board[newPosition.X, newPosition.Y], newPosition, (+1, 0));

            int brokeCount = 0;

            int particle = 0;
            
            int verticalCount = upCount + downCount - 1;
            int horizontalCount = leftCount + rightCount - 1;
            if (verticalCount >= 3)
            {
                brokeCount += verticalCount;

                int gemScore = (verticalCount - 2) * 5;
                int score = verticalCount * gemScore;

                for (int y = newPosition.Y - upCount + 1; y < newPosition.Y + downCount; y++)
                {
                    Board[newPosition.X, y] = Gem.Empty;

                    BreakParticles.Add(new BreakParticle(GetTileLocation(newPosition.X, y), RandomDirection(Random.Shared), GemColors[(int)gemType], particle++ * ParticleDelayTime, gemScore));
                }

                float horizontalLocation = GetTileLocation(newPosition.X, newPosition.Y).X;
                float verticalCenter = GetTileLocation(newPosition.X, newPosition.Y + ((downCount - upCount) / 2)).Y;
                BreakEffect effect = new BreakEffect(score, GemColors[(int)gemType], new Vector2(horizontalLocation, verticalCenter));
                BreakEffects.Add(effect);
            }

            if (horizontalCount >= 3)
            {
                brokeCount += horizontalCount;

                int gemScore = (horizontalCount - 2) * 5;
                int score = horizontalCount * gemScore;

                for (int x = newPosition.X - leftCount + 1; x < newPosition.X + rightCount; x++)
                {
                    Board[x, newPosition.Y] = Gem.Empty;

                    if (verticalCount < 3 || x != newPosition.X)
                        BreakParticles.Add(new BreakParticle(GetTileLocation(x, newPosition.Y), RandomDirection(Random.Shared), GemColors[(int)gemType], particle++ * ParticleDelayTime, gemScore));
                }

                float verticalLocation = GetTileLocation(newPosition.X, newPosition.Y).Y;
                float verticalCenter = GetTileLocation(newPosition.X, newPosition.Y + ((downCount - upCount) / 2)).Y;
                float horizontalCenter = GetTileLocation(newPosition.X + ((rightCount - leftCount) / 2), newPosition.Y).X;
                BreakEffect effect = new BreakEffect(score, GemColors[(int)gemType], new Vector2(horizontalCenter, verticalLocation));
                BreakEffects.Add(effect);
            }

            if (verticalCount >= 3 && horizontalCount >= 3)
            {
                // Remove the double counted gem.
                brokeCount -= 1;
            }

            for (int i = 0; i < brokeCount; i++)
            {
                float verticalCenter = GetTileLocation(newPosition.X, newPosition.Y + ((downCount - upCount) / 2)).Y;
                float horizontalCenter = GetTileLocation(newPosition.X + ((rightCount - leftCount) / 2), newPosition.Y).X;

                // FIXME: If we break multiple rows at once we get particles that sync up.
                // We'd ideally want like a global delay counter or something, so we could delay stuff.
                //BreakParticles.Add(new BreakParticle((horizontalCenter, verticalCenter) + RandomDirection(Random.Shared) * 0.1f, RandomDirection(Random.Shared), GemColors[(int)gemType], i * ParticleDelayTime));
            }

            return brokeCount;
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

        static ImDrawCallback SetBlendModeAdditiveCallback = SetBlendModeAdditive;
        static GCHandle SetBlendModeAdditiveCallbackHandle = GCHandle.Alloc(SetBlendModeAdditiveCallback);
        static void SetBlendModeAdditive(ImDrawListPtr parentList, ImDrawCmdPtr cmd)
        {
            GL.BlendEquation(BlendEquationMode.FuncAdd);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.One);
        }

        static ImDrawCallback SetBlendModeAlphaBlendingCallback = SetBlendModeAlphaBlending;
        static GCHandle SetBlendModeAlphaBlendingCallbackHandle = GCHandle.Alloc(SetBlendModeAlphaBlendingCallback);
        static void SetBlendModeAlphaBlending(ImDrawListPtr parentList, ImDrawCmdPtr cmd)
        {
            GL.BlendEquation(BlendEquationMode.FuncAdd);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
        }

        float Time = 0;
        MouseState PrevMouseState;
        bool[] PrevKeyboardState = new bool[256];
        bool[] KeyboardState = new bool[256];
        public bool Update(float deltaTime)
        {
            nint oldImguiContext = ImGui.GetCurrentContext();
            ImGui.SetCurrentContext(ImGuiController.Context);

            Time += deltaTime;

            // FIXME: A nicer way to automatically update all sfx...
            SwapSoundEffect.Update();
            BreakSoundEffect.Update();
            PointSoundEffect.Update();
            ButtonPressEffect.Update();

            ImGuiController.Update(deltaTime);
            ImGui.PushFont(CurrentImGuiFont);

            UIBaseDrawlist._ResetForNewFrame();
            UIBaseDrawlist.PushClipRectFullScreen();
            UIBaseDrawlist.PushTextureID(ImGui.GetIO().Fonts.TexID);

            UIOverlayDrawlist._ResetForNewFrame();
            UIOverlayDrawlist.PushClipRectFullScreen();
            UIOverlayDrawlist.PushTextureID(ImGui.GetIO().Fonts.TexID);

            var UV00 = new System.Numerics.Vector2(0, 0);
            var UV11 = new System.Numerics.Vector2(1, 1);
            var ImWhite = ImGui.ColorConvertFloat4ToU32(new System.Numerics.Vector4(1, 1, 1, 1));

            Toolkit.Window.GetFramebufferSize(Window, out Vector2i fbSize);

            // Update all current score effects regardless of gameplay state.
            {
                const float Lifetime = 0.7f;
                float RiseAmount = (fbSize.Y / 8) * 0.4f;

                Span<BreakEffect> effects = CollectionsMarshal.AsSpan(BreakEffects);
                for (int i = 0; i < effects.Length; i++)
                {
                    ref BreakEffect effect = ref effects[i];
                    effect.Timer += deltaTime;
                    if (effect.Timer > Lifetime)
                    {
                        // This effect will be deleted after this loop.
                        continue;
                    }

                    static float EaseInExpo(float x)
                    {
                        return x == 0 ? 0 : MathF.Pow(2, 10 * x - 10);
                    }

                    static float EaseOutQuad(float x)
                    {
                        return 1 - (1 - x) * (1 - x);
                    }

                    float t = (effect.Timer / Lifetime);

                    float alpha = float.Lerp(1.0f, 0.0f, EaseInExpo(t));

                    uint col = ImGui.ColorConvertFloat4ToU32(new System.Numerics.Vector4(effect.Color.X, effect.Color.Y, effect.Color.Z, alpha));

                    Vector2 position = effect.Position / 4;
                    position += (1, 1);
                    position *= 0.5f;
                    position.Y = 1 - position.Y;
                    Vector4 board = GetGemBoardViewport();
                    position *= board.Wz;
                    position.X += board.X;

                    string text = $"+{effect.Score}";

                    float fontSize = 70;

                    var textSize = CurrentImGuiFont.CalcTextSizeA(fontSize, float.PositiveInfinity, float.PositiveInfinity, text);

                    // Center the text on the position.
                    position.X -= textSize.X / 2;
                    position.Y -= textSize.Y / 2;

                    position.Y -= EaseOutQuad(t) * RiseAmount;

                    UIOverlayDrawlist.AddText(CurrentImGuiFont, fontSize, new System.Numerics.Vector2(position.X, position.Y), col, text);
                }

                // Remove all break effects that have died.
                BreakEffects.RemoveAll(be => be.Timer > Lifetime);

                UIOverlayDrawlist.AddCallback((nint)SetBlendModeAdditiveCallbackHandle, 0);

                ParticlePitchResetTimer -= deltaTime;
                if (ParticlePitchResetTimer <= 0)
                {
                    ParticlePitchResetTimer = 0;
                    ParticlePitchCounter = 0;
                }

                Span<BreakParticle> particles = CollectionsMarshal.AsSpan(BreakParticles);
                for (int i = 0; i < particles.Length; i++)
                {
                    ref BreakParticle particle = ref particles[i];
                    particle.Timer += deltaTime;



                    Vector2 goal = (-4.5f, -4.5f);
                    Vector2 acceleration = (-4.5f, -4.5f) - particle.Position;

                    static float EaseOutExpo(float x)
                    {
                        return x == 1 ? 1 : 1 - MathF.Pow(2, -10 * x);
                    }

                    static float EaseInOutCirc(float x)
                    {
                       return x < 0.5
                          ? (1 - MathF.Sqrt(1 - MathF.Pow(2 * x, 2))) / 2
                          : (MathF.Sqrt(1 - MathF.Pow(-2 * x + 2, 2)) + 1) / 2;
                    }

                    const float ExplodeAnimationTime = 0.5f;
                    float explodeTime = float.Clamp(particle.Timer / (ExplodeAnimationTime + particle.Delay), 0.0f, 1.0f);

                    Vector2 position = particle.Position + particle.Velocity * EaseOutExpo(explodeTime) * 1.2f;

                    const float GatherStartTime = 0.2f;
                    const float GatherAnimationTime = 1f;
                    float gatherTime = float.Clamp((particle.Timer - GatherStartTime) / (GatherAnimationTime + particle.Delay), 0.0f, 1.0f);

                    position = Vector2.Lerp(position, goal, EaseInOutCirc(gatherTime));

                    static float EaseInExpo(float x)
                    {
                        return x == 0 ? 0 : MathF.Pow(2, 10 * x - 10);
                    }

                    const float FadeOutTime = 1f;
                    float alphaT = float.Clamp((particle.Timer - (GatherStartTime + GatherAnimationTime - FadeOutTime + particle.Delay)) / FadeOutTime, 0.0f, 1.0f);
                    float alpha = float.Lerp(1.0f, 0.0f, EaseInExpo(alphaT));

                    if (particle.Timer > GatherStartTime + GatherAnimationTime + particle.Delay)
                    {
                        ParticlePitchCounter++;
                        ParticlePitchResetTimer = ParticlePitchResetTime;
                        PointSoundEffect.PlayOneShot(0.5f, MathHelper.MapRange(int.Clamp(ParticlePitchCounter - 3, 1, 15), 1.0f, 15.0f, 1.0f, 2.0f) + (Random.Shared.NextSingle() - 0.5f) * 0.01f);
                        particle.Done = true;

                        Score += particle.Score;
                    }

                    position = position / 4;
                    position += (1, 1);
                    position *= 0.5f;
                    position.Y = 1 - position.Y;
                    Vector4 board = GetGemBoardViewport();
                    position *= board.Wz;
                    position.X += board.X;

                    const float ParticleSize = 45.0f;

                    //UIOverlayDrawlist.AddCircleFilled(position.ToNumerics(), 10f, ImGui.ColorConvertFloat4ToU32(new System.Numerics.Vector4(particle.Color.X, particle.Color.Y, particle.Color.Z, 1.0f)));
                    uint col = ImGui.ColorConvertFloat4ToU32(new System.Numerics.Vector4(particle.Color.X, particle.Color.Y, particle.Color.Z, alpha));
                    UIOverlayDrawlist.AddImage(ParticleTexture.Handle, (position - (ParticleSize/2, ParticleSize/2)).ToNumerics(), (position + (ParticleSize/2, ParticleSize/2)).ToNumerics(), System.Numerics.Vector2.Zero, System.Numerics.Vector2.One, col);
                }

                UIOverlayDrawlist.AddCallback((nint)SetBlendModeAlphaBlendingCallbackHandle, 0);

                // Remove all break effects that have died.
                BreakParticles.RemoveAll(be => be.Done);
            }

            Toolkit.Mouse.GetMouseState(Window, out MouseState mouseState);
            Toolkit.Keyboard.GetKeyboardState(KeyboardState);

            Vector2i clientPosition = (Vector2i)mouseState.Position;

            Toolkit.Window.GetClientSize(Window, out Vector2i clientSize);

            {
                float leftArea = fbSize.X * UI_LEFT_PAD;
                float leftIconPad = leftArea * 0.05f;
                float iconSize = leftArea * 0.9f;

                Box2i board = GetGemBoardBox();
                
                UIBaseDrawlist.AddRectFilled(board.Min.ToVector2().ToNumerics(), board.Max.ToVector2().ToNumerics(), ImGui.ColorConvertFloat4ToU32(new System.Numerics.Vector4(0.1f, 0.1f, 0.1f, 1.0f)));
                
                UIBaseDrawlist.AddRectFilled(new System.Numerics.Vector2(0, fbSize.Y - fbSize.Y * UI_BOTTOM_PAD), new System.Numerics.Vector2(fbSize.X, fbSize.Y), ImGui.ColorConvertFloat4ToU32(new System.Numerics.Vector4(0.5f, 0.5f, 0.5f, 1.0f)), (fbSize.Y * UI_BOTTOM_PAD) * 0.5f);
                UIBaseDrawlist.AddText(new System.Numerics.Vector2(leftIconPad * 4, fbSize.Y - fbSize.Y * UI_BOTTOM_PAD + ImGui.GetTextLineHeight() * 0.3f), ImGui.ColorConvertFloat4ToU32(new System.Numerics.Vector4(0.8f, 0.8f, 0.8f, 1.0f)), $"{Score}");

                // FIXME: Sliders for both music and SFX.
                Box2 sfxMuteButtonBox = new Box2(leftIconPad, 0, leftIconPad + iconSize, iconSize);
                UIBaseDrawlist.AddImage(SfxMuted ? SfxMutedTexture.Handle : SfxUnmutedTexture.Handle, sfxMuteButtonBox.Min.ToNumerics(), sfxMuteButtonBox.Max.ToNumerics());
                if (sfxMuteButtonBox.ContainsInclusive(clientPosition) && mouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) && PrevMouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) == false)
                {
                    SfxMuted = !SfxMuted;
                    if (SfxMuted)
                    {
                        SoundEffect.SetGain(0.0f);
                    }
                    else
                    {
                        SoundEffect.SetGain(SfxVolume);
                    }
                }

                Box2 musicMuteButtonBox = new Box2(leftIconPad, leftArea, leftIconPad + iconSize, leftArea + iconSize);
                UIBaseDrawlist.AddImage(MusicMuted ? MusicMutedTexture.Handle : MusicUnmutedTexture.Handle, musicMuteButtonBox.Min.ToNumerics(), musicMuteButtonBox.Max.ToNumerics());
                if (musicMuteButtonBox.ContainsInclusive(clientPosition) && mouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) && PrevMouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) == false)
                {
                    MusicMuted = !MusicMuted;
                    if (MusicMuted)
                    {
                        AmbientMusic.SetGain(0.0f);
                    }
                    else
                    {
                        AmbientMusic.SetGain(MusicVolume);
                    }
                }
            }

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

            ImGui.PopFont();
            ImGui.SetCurrentContext(oldImguiContext);
            return false;

            void DoIdle(float deltaTime)
            {
                bool inWindow = false;
                if (clientPosition.X >= 0 && clientPosition.X < clientSize.X &&
                    clientPosition.Y >= 0 && clientPosition.Y < clientSize.Y)
                {
                    inWindow = true;
                }

                HintJiggleTimer += deltaTime;
                if (HintJiggleTimer > HintTime) {
                    // We want to select a random valid move and jiggle the pieces
                    if (JigglePair == null)
                    {
                        List<(Vector2i, Vector2i)> moves = GetLegalMoves();

                        if (moves.Count > 0)
                        {
                            JigglePair = moves[Random.Shared.Next(moves.Count)];
                        }
                    }

                    if (JigglePair != null)
                    {
                        Vector2i gemA = JigglePair.Value.Item1;
                        Vector2i gemB = JigglePair.Value.Item2;

                        bool vertical = (gemA.X, gemA.Y + 1) == (gemB.X, gemB.Y);

                        float t = HintJiggleTimer - HintTime;
                        const float JiggleExtent = 0.025f;
                        float jiggle = MathF.Sin(t * 30) * MathF.Pow(MathF.Sin(t * 2.1f), 18.0f) * JiggleExtent;

                        Vector2 jiggleOffset = vertical ? (0, jiggle) : (jiggle, 0);

                        // We don't really worry about these positions as the swapping code below will
                        // overwrite these positions if needed.
                        BoardPositions[gemA.X, gemA.Y] = GetTileLocation(gemA.X, gemA.Y) + jiggleOffset;
                        BoardPositions[gemB.X, gemB.Y] = GetTileLocation(gemB.X, gemB.Y) - jiggleOffset;
                    }
                }

                if (TryClientPosToTile(clientPosition, out HoveredGem) == false)
                    inWindow = false;
                //HoveredGem = (clientPosition * 8) / clientSize;

                if (inWindow && mouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) && PrevMouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) == false)
                {
                    SelectedGem = HoveredGem;
                    StartPosition = ((Vector2)clientPosition * 8.0f) / clientSize - new Vector2(4.0f, 4.0f);
                    StartPosition.Y *= -1;
                }
                else if (mouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1) && PrevMouseState.PressedButtons.HasFlag(MouseButtonFlags.Button1))
                {
                    if (SelectedGem != (-1, -1))
                    {
                        Vector2 worldPos = ((Vector2)clientPosition * 8.0f) / clientSize - new Vector2(4.0f, 4.0f);
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

                int legalMoves = CountLegalMoves();
                if (legalMoves == 0 && KeyboardState[(int)Scancode.R] && PrevKeyboardState[(int)Scancode.R] == false)
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
                    Score = 0;

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
                    BrokenGemsComboCount = 0;
                    BrokenGemsComboCount += HandleMovedGem(MovingGem1);
                    BrokenGemsComboCount += HandleMovedGem(MovingGem2);

                    Debug.Assert(BrokenGemsComboCount > 0);

                    Toolkit.Window.GetFramebufferSize(Window, out Vector2i fbSize);

                    // FIXME: Add pitch.
                    BreakSoundEffect.PlayOneShot(BreakSFXVolume, BreakPitchFromComboCount(BrokenGemsComboCount));

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
                            int brokenGems = HandleMovedGem((x, y));
                            BrokenGemsComboCount += brokenGems;
                            combo |= (brokenGems > 0);
                        }
                    }

                    if (combo)
                    {
                        BreakSoundEffect.PlayOneShot(BreakSFXVolume, BreakPitchFromComboCount(BrokenGemsComboCount));
                    }

                    if (combo == false)
                    {
                        Logger.LogInfo("Done falling!");
                        HintJiggleTimer = 0;
                        JigglePair = null;
                        CurrentState = State.Idle;
                        BrokenGemsComboCount = 0;

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

            static float BreakPitchFromComboCount(int brokenGems)
            {
                return float.Lerp(1.0f, 1.2f, float.Clamp((brokenGems - 3) / (float)20, 0, 1));
            }
        }

        public void Render()
        {
            nint oldImguiContext = ImGui.GetCurrentContext();
            ImGui.SetCurrentContext(ImGuiController.Context);

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
            GL.ClearDepth(1);
            GL.ClearColor(Color4.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            RenderDrawList(UIBaseDrawlist);

            switch (CurrentState)
            {
                case State.Idle:
                case State.AnimatingPlayerMove:
                case State.Falling:
                    RenderGame();
                    break;
            }

            ImGuiController.Render();

            Toolkit.Window.GetFramebufferSize(Window, out Vector2i fbSize);
            GL.Viewport(0, 0, fbSize.X, fbSize.Y);

            // FIXME: Set the viewport?
            // The scores are displayed at the wrong positions.
            RenderDrawList(UIOverlayDrawlist);

            Toolkit.OpenGL.SwapBuffers(Context);

            ImGui.SetCurrentContext(oldImguiContext);

            void RenderGame()
            {
                Vector4i viewport = GetGemBoardViewport();
                GL.Viewport(viewport.X, viewport.Y, viewport.Z, viewport.W);
                RenderGemBoard(viewport);
            }

            void RenderGemBoard(Vector4i viewport)
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

                Toolkit.Window.GetFramebufferSize(Window, out Vector2i fbSize);

                //GL.BindFramebuffer(FramebufferTarget.DrawFramebuffer, 0);
                //GL.BlitFramebuffer(0, 0, fbWidth, fbHeight, 0, 0, fbWidth, fbHeight, ClearBufferMask.ColorBufferBit, BlitFramebufferFilter.Nearest);
                //GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);

                GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
                //GL.BindFramebuffer(FramebufferTarget.Framebuffer, DebugFramebuffer.Handle);

                // Don't clear here as we've already begun drawing the UI to the default frame buffer.
                //GL.ClearDepth(1);
                //GL.ClearColor(Color4.Black);
                //GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                GL.DepthFunc(DepthFunction.Less);

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
                    GL.UniformMatrix4f(GemShader.UniformLocationMVP, 1, true, in mvp);
                    GL.UniformMatrix4f(GemShader.UniformLocationModel, 1, true, in model);
                    GL.UniformMatrix4f(GemShader.UniformLocationViewProjection, 1, true, in viewProjection);
                    GL.UniformMatrix3f(GemShader.UniformLocationNormalMat, 1, true, in normalMat);

                    Vector4 viewportF = viewport;
                    GL.Uniform4f(GemShader.UniformLocationViewport, 1, in viewportF);

                    GL.Uniform3f(GemShader.UniformLocationTint, 1, in tint);
                    GL.Uniform3f(GemShader.UniformLocationF0, 1, in GemF0s[(int)gem]);

                    GL.DrawElements(PrimitiveType.Triangles, visual.Elements, DrawElementsType.UnsignedShort, 0);
                }

                //GL.BindFramebuffer(FramebufferTarget.DrawFramebuffer, 0);
                //GL.BlitFramebuffer(0,0,fbWidth,fbHeight,0,0,fbWidth,fbHeight,ClearBufferMask.ColorBufferBit,BlitFramebufferFilter.Nearest);
            }

            void RenderDrawList(ImDrawListPtr drawlist)
            {
                CustomDrawData.Clear();
                CustomDrawData.Valid = true;
                CustomDrawData.DisplayPos = ImGui.GetMainViewport().Pos;
                CustomDrawData.DisplaySize = ImGui.GetMainViewport().Size;
                // FIXME: Get the actual framebuffer scale?
                CustomDrawData.FramebufferScale = new System.Numerics.Vector2(1, 1);
                CustomDrawData.AddDrawList(drawlist);
                ImGuiController.RenderImDrawData(CustomDrawData);
            }
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

        static ImGuiKey ToImgui(Key key)
        {
            // FIXME: Rest of the keycodes.
            switch (key)
            {
                case Key.Return: return ImGuiKey.Enter;
                case Key.Escape: return ImGuiKey.Escape;
                case Key.Tab: return ImGuiKey.Tab;
                case Key.Backspace: return ImGuiKey.Backspace;

                case Key.PageUp: return ImGuiKey.PageUp;
                case Key.PageDown: return ImGuiKey.PageDown;

                case Key.LeftArrow: return ImGuiKey.LeftArrow;
                case Key.RightArrow: return ImGuiKey.RightArrow;
                case Key.UpArrow: return ImGuiKey.UpArrow;
                case Key.DownArrow: return ImGuiKey.DownArrow;

                case Key.LeftShift: return ImGuiKey.LeftShift;
                case Key.RightShift: return ImGuiKey.RightShift;

                case Key.LeftControl: return ImGuiKey.LeftCtrl;
                case Key.RightControl: return ImGuiKey.RightCtrl;

                case Key.LeftAlt: return ImGuiKey.LeftAlt;
                case Key.RightAlt: return ImGuiKey.RightAlt;

                case Key.LeftGUI: return ImGuiKey.LeftSuper;
                case Key.RightGUI: return ImGuiKey.RightSuper;

                default: return ImGuiKey.None;
            }
        }

        private void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            nint oldImguiContext = ImGui.GetCurrentContext();
            ImGui.SetCurrentContext(ImGuiController.Context);

            // Only update imgui stuff for the main window
            if (args is KeyDownEventArgs keyDown)
            {
                ImGuiKey ikey = ToImgui(keyDown.Key);
                ImGui.GetIO().AddKeyEvent(ikey, true);
            }
            else if (args is KeyUpEventArgs keyUp)
            {
                ImGuiKey ikey = ToImgui(keyUp.Key);
                ImGui.GetIO().AddKeyEvent(ikey, false);
            }
            else if (args is TextInputEventArgs textInput)
            {
                ImGui.GetIO().AddInputCharactersUTF8(textInput.Text);
            }
            else if (args is MouseMoveEventArgs mouseMove)
            {
                // FIXME: Add screen, client, and framebuffer coords to mouse move events...

                // Imgui works with framebuffer coordinates.
                Toolkit.Window.ClientToFramebuffer(mouseMove.Window, mouseMove.ClientPosition, out Vector2 fbPos);
                ImGui.GetIO().AddMousePosEvent(fbPos.X, fbPos.Y);
            }
            else if (args is RawMouseMoveEventArgs rawMouseMove)
            {
                Logger.LogDebug($"rmm {rawMouseMove.Delta.X} {rawMouseMove.Delta.Y}");
            }
            else if (args is ScrollEventArgs scroll)
            {
                ImGui.GetIO().AddMouseWheelEvent(scroll.Delta.X, scroll.Delta.Y);
            }
            else if (args is MouseButtonDownEventArgs mouseDown)
            {
                int button = ((int)mouseDown.Button);
                ImGui.GetIO().AddMouseButtonEvent(button, true);
            }
            else if (args is MouseButtonUpEventArgs mouseUp)
            {
                int button = ((int)mouseUp.Button);
                ImGui.GetIO().AddMouseButtonEvent(button, false);
            }
            else if (args is WindowScaleChangeEventArgs scaleChange)
            {
                Logger.LogDebug($"Scale change: (x:{scaleChange.ScaleX}, y:{scaleChange.ScaleY})");
                // FIXME: scale the ImGui text!
                // ImGuiController.RecreateFontDeviceTexture();
            }

            ImGui.SetCurrentContext(oldImguiContext);
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
