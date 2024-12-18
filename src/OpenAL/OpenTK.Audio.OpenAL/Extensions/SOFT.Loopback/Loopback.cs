using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace OpenTK.Audio.OpenAL
{
    public partial class ALC
    {
        internal class Loopback
        {
            /// <summary>
            /// The name of this AL extension.
            /// </summary>
            public const string ExtensionName = "ALC_SOFT_loopback";

            static Loopback()
            {
                // We need to register the resolver for OpenAL before we can DllImport functions.
                ALBase.RegisterOpenALResolver();
            }

            private Loopback()
            {
            }

            /// <summary>
            /// Checks if this extension is present.
            /// </summary>
            /// <param name="device">The device to query.</param>
            /// <returns>Whether the extension was present or not.</returns>
            public static bool IsExtensionPresent(ALDevice device)
            {
                return ALC.IsExtensionPresent(device, ExtensionName);
            }

#pragma warning disable SA1516 // Elements should be separated by blank line
            public static ALDevice LoopbackOpenDeviceSOFT(ALDevice device) => _LoopbackOpenDeviceSOFT(device);
            [UnmanagedFunctionPointer(AL.ALCallingConvention)]
            private delegate ALDevice LoopbackOpenDeviceSOFTDelegate(ALDevice device);
            private static readonly LoopbackOpenDeviceSOFTDelegate _LoopbackOpenDeviceSOFT = LoadDelegate<LoopbackOpenDeviceSOFTDelegate>("alcLoopbackOpenDeviceSOFT");

            public static bool IsRenderFormatSupportedSOFT(ALDevice device, int frequency, Channels channels, RenderFormat type) => _IsRenderFormatSupportedSOFT(device, frequency, channels, type);
            [UnmanagedFunctionPointer(AL.ALCallingConvention)]
            private delegate bool IsRenderFormatSupportedSOFTDelegate(ALDevice device, int frequency, Channels channels, RenderFormat type);
            private static readonly IsRenderFormatSupportedSOFTDelegate _IsRenderFormatSupportedSOFT = LoadDelegate<IsRenderFormatSupportedSOFTDelegate>("alcIsRenderFormatSupportedSOFT");

            public static unsafe void RenderSamplesSOFT(ALDevice device, byte* buffer, int samples) => _RenderSamplesSOFTPtr(device, buffer, samples);
            [UnmanagedFunctionPointer(AL.ALCallingConvention)]
            private unsafe delegate void RenderSamplesSOFTPtrDelegate(ALDevice device, byte* buffer, int samples);
            private static readonly RenderSamplesSOFTPtrDelegate _RenderSamplesSOFTPtr = LoadDelegate<RenderSamplesSOFTPtrDelegate>("alcLoopbackOpenDeviceSOFT");

            public static void RenderSamplesSOFT(ALDevice device, ref byte buffer, int samples) => _RenderSamplesSOFTRef(device, ref buffer, samples);
            [UnmanagedFunctionPointer(AL.ALCallingConvention)]
            private delegate void RenderSamplesSOFTRefDelegate(ALDevice device, ref byte buffer, int samples);
            private static readonly RenderSamplesSOFTRefDelegate _RenderSamplesSOFTRef = LoadDelegate<RenderSamplesSOFTRefDelegate>("alcLoopbackOpenDeviceSOFT");

            public static void RenderSamplesSOFT(ALDevice device, byte[] buffer, int samples) => _RenderSamplesSOFTArray(device, buffer, samples);
            [UnmanagedFunctionPointer(AL.ALCallingConvention)]
            private delegate void RenderSamplesSOFTArrayDelegate(ALDevice device, byte[] buffer, int samples);
            private static readonly RenderSamplesSOFTArrayDelegate _RenderSamplesSOFTArray = LoadDelegate<RenderSamplesSOFTArrayDelegate>("alcLoopbackOpenDeviceSOFT");
#pragma warning restore SA1516 // Elements should be separated by blank line

            public static unsafe void RenderSamplesSOFT<TBuffer>(ALDevice device, TBuffer[] buffer, int samples)
                where TBuffer : unmanaged
            {
                fixed (TBuffer* b = buffer)
                {
                    RenderSamplesSOFT(device, (byte*)b, samples);
                }
            }
        }
    }
}
