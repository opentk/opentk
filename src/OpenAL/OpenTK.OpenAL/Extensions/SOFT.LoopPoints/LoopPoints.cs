using System;
using System.Runtime.InteropServices;

namespace OpenTK.Audio.OpenAL
{
    public partial class AL
    {
        public class LoopPoints : ALBase
        {
            public const string ExtensionName = "AL_SOFT_loop_points";

            static LoopPoints()
            {
                // We need to register the resolver for OpenAL before we can DllImport functions.
                ALBase.RegisterOpenALResolver();
            }

            private LoopPoints()
            {
            }

            /// <summary>
            /// Checks if this extension is present.
            /// </summary>
            /// <returns>Whether the extension was present or not.</returns>
            public static bool IsExtensionPresent()
            {
                return AL.IsExtensionPresent(ExtensionName);
            }

            [DllImport(AL.Lib, EntryPoint = "alBufferiv", ExactSpelling = true, CallingConvention = AL.ALCallingConvention)]
            public static unsafe extern void Buffer(int buffer, BufferLoopPoint param, int* values);

            [DllImport(AL.Lib, EntryPoint = "alBufferiv", ExactSpelling = true, CallingConvention = AL.ALCallingConvention)]
            public static extern void Buffer(int buffer, BufferLoopPoint param, ref int values);

            public static unsafe void Buffer(int buffer, BufferLoopPoint param, ReadOnlySpan<int> values)
            {
                Buffer(buffer, param, ref MemoryMarshal.GetReference(values));
            }

            public static void Buffer(int buffer, BufferLoopPoint param, int start, int end)
            {
                Span<int> data = stackalloc int[2];
                data[0] = start;
                data[1] = end;

                Buffer(buffer, param, data);
            }
        }
    }
}
