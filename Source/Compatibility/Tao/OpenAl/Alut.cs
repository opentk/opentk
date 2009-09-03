#region License
/*
MIT License
Copyright ©2003-2006 Tao Framework Team
http://www.taoframework.com
All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License

using System;
using System.IO;
using System.Security;
using System.Runtime.InteropServices;
using System.Text;

namespace Tao.OpenAl
{
	#region Class Documentation
	/// <summary>
	/// OpenAL binding for .NET, implementing ALUT 1.1.
	/// </summary>
	/// <remarks>
	/// ALUT is non-standard.
	/// </remarks>
	#endregion Class Documentation
    [Obsolete("Use OpenTK.Audio.OpenAL instead.")]
    public static class Alut
	{
		// --- Fields ---
		#region Private Constants
		#region string ALUT_NATIVE_LIBRARY
		/// <summary>
		/// Specifies OpenAl's native library archive.
		/// </summary>
		/// <remarks>
		/// Specifies OpenAl32.dll everywhere; will be mapped via .config for mono.
		/// </remarks>
		private const string ALUT_NATIVE_LIBRARY = "alut.dll";
		#endregion string ALUT_NATIVE_LIBRARY

		#region CallingConvention CALLING_CONVENTION
		/// <summary>
		/// Specifies the calling convention.
		/// </summary>
		/// <remarks>
		/// Specifies <see cref="CallingConvention.Cdecl" />.
		/// </remarks>
		private const CallingConvention CALLING_CONVENTION = CallingConvention.Cdecl;
		#endregion CallingConvention CALLING_CONVENTION
		#endregion Private Constants

		#region Public OpenAL 1.1 Constants
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_API_MAJOR_VERSION = 1;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_API_MINOR_VERSION = 1;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_NO_ERROR = 0;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_OUT_OF_MEMORY = 0x200;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_INVALID_ENUM = 0x201;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_INVALID_VALUE = 0x202;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_INVALID_OPERATION = 0x203;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_NO_CURRENT_CONTEXT = 0x204;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_AL_ERROR_ON_ENTRY = 0x205;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_ALC_ERROR_ON_ENTRY = 0x206;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_OPEN_DEVICE = 0x207;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_CLOSE_DEVICE = 0x208;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_CREATE_CONTEXT = 0x209;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_MAKE_CONTEXT_CURRENT = 0x20A;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_DESTROY_CONTEXT = 0x20B;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_GEN_BUFFERS = 0x20C;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_BUFFER_DATA = 0x20D;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_IO_ERROR = 0x20E;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_UNSUPPORTED_FILE_TYPE = 0x20F;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_UNSUPPORTED_FILE_SUBTYPE = 0x210;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_ERROR_CORRUPT_OR_TRUNCATED_DATA = 0x211;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_WAVEFORM_SINE = 0x100;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_WAVEFORM_SQUARE = 0x101;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_WAVEFORM_SAWTOOTH = 0x102;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_WAVEFORM_WHITENOISE = 0x103;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_WAVEFORM_IMPULSE = 0x104;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_LOADER_BUFFER = 0x300;
		/// <summary>
		/// 
		/// </summary>
		public const int ALUT_LOADER_MEMORY = 0x301;
		#endregion Public OpenAL 1.1 Constants

		// --- Public Methods ---		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="argcp"></param>
		/// <param name="argv"></param>
		/// <returns></returns>
		//		ALUT_API ALboolean ALUT_APIENTRY alutInit (int *argcp, char **argv);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutInit(int[] argcp, string[] argv);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static int alutInit()
		{
			return alutInit(null, null);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="argcp"></param>
		/// <param name="argv"></param>
		/// <returns></returns>
		//		ALUT_API ALboolean ALUT_APIENTRY alutInitWithoutContext (int *argcp, char **argv);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutInitWithoutContext(int[] argcp, string[] argv);

		/// <summary>
		/// 
		/// </summary>
		//		ALUT_API ALboolean ALUT_APIENTRY alutExit (void);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutExit();

		/// <summary>
		/// 
		/// </summary>
		//		ALUT_API ALenum ALUT_APIENTRY alutGetError (void);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutGetError();

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		//		ALUT_API const char *ALUT_APIENTRY alutGetErrorString (ALenum error);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern string alutGetErrorString(int error);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
		//		ALUT_API ALuint ALUT_APIENTRY alutCreateBufferFromFile (const char *fileName);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutCreateBufferFromFile(string fileName);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="data"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		//		ALUT_API ALuint ALUT_APIENTRY alutCreateBufferFromFileImage (const ALvoid *data, ALsizei length);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutCreateBufferFromFileImage(IntPtr data, int length);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		//		ALUT_API ALuint ALUT_APIENTRY alutCreateBufferHelloWorld (void);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutCreateBufferHelloWorld();
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="waveshape"></param>
		/// <param name="frequency"></param>
		/// <param name="phase"></param>
		/// <param name="duration"></param>
		/// <returns></returns>
		//		ALUT_API ALuint ALUT_APIENTRY alutCreateBufferWaveform (ALenum waveshape, ALfloat frequency, ALfloat phase, ALfloat duration);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutCreateBufferWaveform(int waveshape, float frequency, float phase, float duration);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="format"></param>
		/// <param name="size"></param>
		/// <param name="frequency"></param>
		/// <returns></returns>
		//		ALUT_API ALvoid *ALUT_APIENTRY alutLoadMemoryFromFile (const char *fileName, ALenum *format, ALsizei *size, ALfloat *frequency);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern IntPtr alutLoadMemoryFromFile(string fileName, out int format, out int size, out float frequency);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="data"></param>
		/// <param name="length"></param>
		/// <param name="format"></param>
		/// <param name="size"></param>
		/// <param name="frequency"></param>
		/// <returns></returns>
		//		ALUT_API ALvoid *ALUT_APIENTRY alutLoadMemoryFromFileImage (const ALvoid *data, ALsizei length, ALenum *format, ALsizei *size, ALfloat *frequency);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern IntPtr alutLoadMemoryFromFileImage(IntPtr data, int length, out int format, out int size, out float frequency);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="format"></param>
		/// <param name="size"></param>
		/// <param name="frequency"></param>
		/// <returns></returns>
		//		ALUT_API ALvoid *ALUT_APIENTRY alutLoadMemoryHelloWorld (ALenum *format, ALsizei *size, ALfloat *frequency);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern IntPtr alutLoadMemoryHelloWorld(out int format, out int size, out float frequency);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="waveshape"></param>
		/// <param name="frequency"></param>
		/// <param name="phase"></param>
		/// <param name="duration"></param>
		/// <param name="format"></param>
		/// <param name="size"></param>
		/// <param name="freq"></param>
		/// <returns></returns>
		//		ALUT_API ALvoid *ALUT_APIENTRY alutLoadMemoryWaveform (ALenum waveshape, ALfloat frequency, ALfloat phase, ALfloat duration, ALenum *format, ALsizei *size, ALfloat *freq);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern IntPtr alutLoadMemoryWaveform(int waveshape, float frequency, float phase, float duration, out int format, out int size, out float freq);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="loader"></param>
		/// <returns></returns>
		//		ALUT_API const char *ALUT_APIENTRY alutGetMIMETypes (ALenum loader);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern string alutGetMIMETypes(int loader);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		//		ALUT_API ALint ALUT_APIENTRY alutGetMajorVersion (void);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutGetMajorVersion();

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		//		ALUT_API ALint ALUT_APIENTRY alutGetMinorVersion (void);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutGetMinorVersion();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="duration"></param>
		/// <returns></returns>
		//		ALUT_API ALboolean ALUT_APIENTRY alutSleep (ALfloat duration);
		[DllImport(ALUT_NATIVE_LIBRARY, CallingConvention=CALLING_CONVENTION), SuppressUnmanagedCodeSecurity]
		public static extern int alutSleep(float duration);

		#region DEPRECATED

//		#region InitializeAlut()
//		/// <summary>
//		/// Initializes OpenAL device and context.
//		/// </summary>
//		private static void InitializeAlut()
//		{
//#if WIN32
//			IntPtr device = Alc.alcOpenDevice("DirectSound3D");
//#else
//IntPtr device = Alc.alcOpenDevice(null);
//#endif
//			IntPtr context = Alc.alcCreateContext(device, IntPtr.Zero);
//			Alc.alcMakeContextCurrent(context);
//		}
//		#endregion InitializeAlut()
//
//		#region ReadWavFile(Stream stream, out int format, out byte[] data, out int size, out int frequency, out int loop)
//		/// <summary>
//		/// Reads a WAV file.
//		/// </summary>
//		/// <param name="stream">
//		/// The stream to be read.
//		/// </param>
//		/// <param name="format">
//		/// The format of the WAV file.
//		/// </param>
//		/// <param name="data">
//		/// The WAV file data.
//		/// </param>
//		/// <param name="size">
//		/// The size of the WAV file data.
//		/// </param>
//		/// <param name="frequency">
//		/// The frequency of the WAV file.
//		/// </param>
//		/// <param name="loop">
//		/// Does the WAV file loop?
//		/// </param>
//		private static void ReadWavFile(Stream stream, out int format, out byte[] data, out int size, out int frequency, out int loop)
//		{
//			bool success = true;
//			format = Al.AL_FORMAT_MONO16;
//			data = null;
//			size = 0;
//			frequency = 22050;
//			loop = Al.AL_FALSE;
//
//			BinaryReader reader = new BinaryReader(stream, System.Text.Encoding.ASCII);
//
//			try
//			{
//				WavFileHeader fileHeader = new WavFileHeader();
//				WavChunkHeader chunkHeader = new WavChunkHeader();
//				WavFormatChunk formatChunk = new WavFormatChunk();
//
//				// Read WAV file header
//				fileHeader.Id = reader.ReadChars(4);
//				fileHeader.Length = reader.ReadInt32();
//				fileHeader.Type = reader.ReadChars(4);
//
//				if(new string(fileHeader.Id) != "RIFF" && fileHeader.Length <= 0 && new string(fileHeader.Type) != "WAVE")
//				{
//					success = false;
//				}
//				else
//				{
//					while(fileHeader.Length > 8)
//					{
//						// Read WAV chunk header
//						chunkHeader.Id = reader.ReadChars(4);
//						chunkHeader.Length = reader.ReadInt32();
//
//						// Determine chunk action
//						if(new string(chunkHeader.Id) == "fmt ")
//						{
//							// Read WAV format header
//							formatChunk.Format = reader.ReadInt16();
//							formatChunk.Channels = reader.ReadInt16();
//							formatChunk.SamplesPerSecond = reader.ReadInt32();
//							formatChunk.BytesPerSecond = reader.ReadInt32();
//							formatChunk.BytesPerSample = reader.ReadInt16();
//							formatChunk.BitsPerSample = reader.ReadInt16();
//
//							if(chunkHeader.Length > 16)
//							{
//								formatChunk.ExtraBytesLength = reader.ReadInt16();
//								formatChunk.ExtraBytes = reader.ReadBytes(formatChunk.ExtraBytesLength);
//							}
//							else
//							{
//								formatChunk.ExtraBytesLength = 0;
//								formatChunk.ExtraBytes = null;
//							}
//
//							if(formatChunk.Format == 0x0001)
//							{
//								if(formatChunk.Channels == 1)
//								{
//									if(formatChunk.BitsPerSample == 8)
//									{
//										format = Al.AL_FORMAT_MONO8;
//									}
//									else
//									{
//										format = Al.AL_FORMAT_MONO16;
//									}
//								}
//								else
//								{
//									if(formatChunk.BitsPerSample == 8)
//									{
//										format = Al.AL_FORMAT_STEREO8;
//									}
//									else
//									{
//										format = Al.AL_FORMAT_STEREO16;
//									}
//								}
//							}
//							frequency = formatChunk.SamplesPerSecond;
//						}
//						else if(new string(chunkHeader.Id) == "data")
//						{
//							if(formatChunk.Format == 0x0001)
//							{
//								size = chunkHeader.Length - 8;
//								data = reader.ReadBytes(size);
//							}
//						}
//						else
//						{
//							if(chunkHeader.Length <= fileHeader.Length && chunkHeader.Length > 0)
//							{
//								reader.ReadBytes(chunkHeader.Length);
//							}
//						}
//
//						if(chunkHeader.Length <= fileHeader.Length && chunkHeader.Length > 0)
//						{
//							fileHeader.Length -= chunkHeader.Length;
//						}
//						else
//						{
//							fileHeader.Length = 0;
//						}
//					}
//				}
//				success = true;
//			}
//			catch
//			{
//				success = false;
//			}
//			finally
//			{
//				reader.Close();
//			}
//
//			if(!success)
//			{
//				format = -1;
//				data = null;
//				size = -1;
//				frequency = -1;
//				loop = -1;
//			}
//		}
//		#endregion ReadWavFile(string fileName, out int format, out byte[] data, out int size, out int frequency, out int loop)

		//		#region alutExit()
		//		/// <summary>
		//		/// Destroys OpenAL context and device.
		//		/// </summary>
		//		// ALUTAPI ALvoid ALUTAPIENTRY alutExit(ALvoid);
		//		public static void alutExit()
		//		{
		//			IntPtr context = Alc.alcGetCurrentContext();
		//			IntPtr device = Alc.alcGetContextsDevice(context);
		//			Alc.alcMakeContextCurrent(IntPtr.Zero);
		//			Alc.alcDestroyContext(context);
		//			Alc.alcCloseDevice(device);
		//			context = IntPtr.Zero;
		//			device = IntPtr.Zero;
		//		}
		//		#endregion alutExit()

//		#region alutInit()
//		/// <summary>
//		/// Initializes an OpenAL device and context.
//		/// </summary>
//		// ALUTAPI ALvoid ALUTAPIENTRY alutInit(ALint *argc, ALbyte **argv);
//		public static void alutInit()
//		{
//			InitializeAlut();
//		}
//		#endregion alutInit()
//
//		#region alutInit(int argc, StringBuilder argv)
//		/// <summary>
//		/// Initializes an OpenAL device and context.
//		/// </summary>
//		/// <param name="argc">
//		/// Number of commandline arguments.
//		/// </param>
//		/// <param name="argv">
//		/// The commandline arguments.
//		/// </param>
//		// ALUTAPI ALvoid ALUTAPIENTRY alutInit(ALint *argc, ALbyte **argv);
//		public static void alutInit(int argc, StringBuilder argv)
//		{
//			InitializeAlut();
//		}
//		#endregion alutInit(int argc, StringBuilder argv)

//		#region Private Structs
//		#region WavFileHeader
//		/// <summary>
//		/// WAV file header.
//		/// </summary>
//		// 12 bytes total
//		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
//			private struct WavFileHeader
//		{
//			[MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
//			public char[] Id;
//			public int Length;
//			[MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
//			public char[] Type;
//		}
//		#endregion WavFileHeader
//
//		#region WavChunkHeader
//		/// <summary>
//		/// WAV chunk header.
//		/// </summary>
//		// 8 bytes total
//		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
//			private struct WavChunkHeader
//		{
//			[MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
//			public char[] Id;
//			public int Length;
//		}
//		#endregion WavChunkHeader
//
//		#region WavFormatChunk
//		/// <summary>
//		/// WAV format chunk.
//		/// </summary>
//		// 16 bytes total
//		[StructLayout(LayoutKind.Sequential)]
//			private struct WavFormatChunk
//		{
//			public short Format;
//			public short Channels;
//			public int SamplesPerSecond;
//			public int BytesPerSecond;
//			public short BytesPerSample;
//			public short BitsPerSample;
//			public short ExtraBytesLength;
//			public byte[] ExtraBytes;
//		}
//		#endregion WavFormatChunk
//		#endregion Private Structs

//		#region alutLoadWAVFile(string fileName, out int format, out byte[] data, out int size, out int frequency, out int loop)
//		/// <summary>
//		/// Loads a WAV file.
//		/// </summary>
//		/// <param name="fileName">
//		/// The filename to be loaded.
//		/// </param>
//		/// <param name="format">
//		/// The format of the WAV file.
//		/// </param>
//		/// <param name="data">
//		/// The WAV file data.
//		/// </param>
//		/// <param name="size">
//		/// The size of the WAV file data.
//		/// </param>
//		/// <param name="frequency">
//		/// The WAV file frequency.
//		/// </param>
//		/// <param name="loop">
//		/// Does the WAV file loop?
//		/// </param>
//		// ALUTAPI ALvoid ALUTAPIENTRY alutLoadWAVFile(ALbyte *file, ALenum *format, ALvoid **data, ALsizei *size, ALsizei *freq, ALboolean *loop);
//		public static void alutLoadWAVFile(string fileName, out int format, out byte[] data, out int size, out int frequency, out int loop)
//		{
//			if(File.Exists(fileName))
//			{
//				FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
//				ReadWavFile(stream, out format, out data, out size, out frequency, out loop);
//				stream.Close();
//				stream = null;
//			}
//			else
//			{
//				format = -1;
//				data = null;
//				size = -1;
//				frequency = -1;
//				loop = -1;
//			}
//		}
//		#endregion alutLoadWAVFile(string fileName, out int format, out byte[] data, out int size, out int frequency, out int loop)
//
//		#region alutLoadWAVMemory([In] byte[] memory, out int format, out byte[] data, out int size, out int frequency, out int loop)
//		/// <summary>
//		/// Loads a WAV file from memory.
//		/// </summary>
//		/// <param name="memory">
//		/// The WAV memory to be loaded.
//		/// </param>
//		/// <param name="format">
//		/// The format of the WAV file.
//		/// </param>
//		/// <param name="data">
//		/// The WAV file data.
//		/// </param>
//		/// <param name="size">
//		/// The size of the WAV file data.
//		/// </param>
//		/// <param name="frequency">
//		/// The WAV file frequency.
//		/// </param>
//		/// <param name="loop">
//		/// Does the WAV file loop?
//		/// </param>
//		// ALUTAPI ALvoid ALUTAPIENTRY alutLoadWAVMemory(ALbyte *memory, ALenum *format, ALvoid **data, ALsizei *size, ALsizei *freq, ALboolean *loop);
//		public static void alutLoadWAVMemory([In] byte[] memory, out int format, out byte[] data, out int size, out int frequency, out int loop)
//		{
//			if(memory != null)
//			{
//				MemoryStream stream = new MemoryStream(memory, 0, memory.Length);
//				ReadWavFile(stream, out format, out data, out size, out frequency, out loop);
//				stream.Close();
//				stream = null;
//			}
//			else
//			{
//				format = -1;
//				data = null;
//				size = -1;
//				frequency = -1;
//				loop = -1;
//			}
//		}
//		#endregion alutLoadWAVMemory([In] byte[] memory, out int format, out byte[] data, out int size, out int frequency, out int loop)
//
//		#region alutUnloadWAV(int format, out byte[] data, int size, int frequency)
//		/// <summary>
//		/// Unloads a WAV file.
//		/// </summary>
//		/// <param name="format">
//		/// The format of the WAV file.
//		/// </param>
//		/// <param name="data">
//		/// The data of the WAV file.
//		/// </param>
//		/// <param name="size">
//		/// The size of the WAV file's data.
//		/// </param>
//		/// <param name="frequency">
//		/// The frequency of the WAV file.
//		/// </param>
//		// ALUTAPI ALvoid ALUTAPIENTRY alutUnloadWAV(ALenum format, ALvoid *data, ALsizei size, ALsizei freq);
//		public static void alutUnloadWAV(int format, out byte[] data, int size, int frequency)
//		{
//			data = null;
//		}
//		#endregion alutUnloadWAV(int format, out byte[] data, int size, int frequency)
	#endregion DEPRECATED
	}
}
