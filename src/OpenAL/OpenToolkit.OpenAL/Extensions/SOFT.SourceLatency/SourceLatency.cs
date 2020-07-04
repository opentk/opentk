using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Audio.OpenAL.Extensions.SOFT.SourceLatency
{
    [Api(AL.Lib, typeof(OpenALLibraryNameContainer))]
    public class SourceLatency : ApiContainer<SourceLatency>
    {
        /// <summary>
        /// The name of this AL extension.
        /// </summary>
        public const string ExtensionName = "AL_SOFT_source_latency";

        static SourceLatency()
        {
            _ = ApiContainer<SourceLatency>.StaticConstructorTrigger;
        }

        private SourceLatency()
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

#pragma warning disable SA1516 // Elements should be separated by blank line
        public static unsafe void GetSource(int source, SourceLatencyVector2i param, long* values) => _GetSourcei64vPtr(source, param, values);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetSourcei64vPtrDelegate(int source, SourceLatencyVector2i param, long* values);
        private static readonly GetSourcei64vPtrDelegate _GetSourcei64vPtr = LoadDelegate<GetSourcei64vPtrDelegate>("alGetSourcei64vSOFT");

        private static void GetSource(int source, SourceLatencyVector2i param, out long values) => _GetSourcei64vRef(source, param, out values);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetSourcei64vRefDelegate(int source, SourceLatencyVector2i param, out long values);
        private static readonly GetSourcei64vRefDelegate _GetSourcei64vRef = LoadDelegate<GetSourcei64vRefDelegate>("alGetSourcei64vSOFT");

        public static void GetSource(int source, SourceLatencyVector2i param, long[] values) => _GetSourcei64vArray(source, param, values);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetSourcei64vArrayDelegate(int source, SourceLatencyVector2i param, long[] values);
        private static readonly GetSourcei64vArrayDelegate _GetSourcei64vArray = LoadDelegate<GetSourcei64vArrayDelegate>("alGetSourcei64vSOFT");

        public static unsafe void GetSource(int source, SourceLatencyVector2d param, double* values) => _GetSourcedvPtr(source, param, values);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetSourcedvPtrDelegate(int source, SourceLatencyVector2d param, double* values);
        private static readonly GetSourcedvPtrDelegate _GetSourcedvPtr = LoadDelegate<GetSourcedvPtrDelegate>("alGetSourcedvSOFT");

        private static void GetSource(int source, SourceLatencyVector2d param, out double values) => _GetSourcedvRef(source, param, out values);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetSourcedvRefDelegate(int source, SourceLatencyVector2d param, out double values);
        private static readonly GetSourcedvRefDelegate _GetSourcedvRef = LoadDelegate<GetSourcedvRefDelegate>("alGetSourcedvSOFT");

        public static void GetSource(int source, SourceLatencyVector2d param, double[] values) => _GetSourcedvArray(source, param, values);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetSourcedvArrayDelegate(int source, SourceLatencyVector2d param, double[] values);
        private static readonly GetSourcedvArrayDelegate _GetSourcedvArray = LoadDelegate<GetSourcedvArrayDelegate>("alGetSourcedvSOFT");
#pragma warning restore SA1516 // Elements should be separated by blank line

        public static void GetSource(int source, SourceLatencyVector2i param, out long value1, out long value2)
        {
            Span<long> values = stackalloc long[2];
            GetSource(source, param, values);
            value1 = values[0];
            value2 = values[1];
        }

        public static void GetSource(int source, SourceLatencyVector2i param, Span<long> values)
        {
            unsafe
            {
                // Beacuse we don't know how this span is allocated we need to fix it
                fixed (long* ptr = &values[0])
                {
                    GetSource(source, param, ptr);
                }
            }
        }

        public static void GetSource(int source, SourceLatencyVector2i param, out int value1, out int value2, out long value3)
        {
            // FIXME: This might result in wrong values, though it seems to be somewhat correct...
            Span<int> values = stackalloc int[4];
            GetSource(source, param, out Unsafe.As<int, long>(ref values[0]));
            value1 = values[0];
            value2 = values[1];
            value3 = Unsafe.As<int, long>(ref values[2]);
        }

        public static void GetSource(int source, SourceLatencyVector2d param, out double value1, out double value2)
        {
            Span<double> values = stackalloc double[2];
            GetSource(source, param, values);
            value1 = values[0];
            value2 = values[1];
        }

        public static void GetSource(int source, SourceLatencyVector2d param, Span<double> values)
        {
            unsafe
            {
                // Beacuse we don't know how this span is allocated we need to fix it
                fixed (double* ptr = &values[0])
                {
                    GetSource(source, param, ptr);
                }
            }
        }

        public static void GetSource(int source, SourceLatencyVector2d param, out Vector2d values)
        {
            values.Y = 0;
            GetSource(source, param, out values.X);
        }
    }
}
