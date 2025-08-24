using OpenTK.Graphics.Vulkan;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.Windows.DirectInput;
using static OpenTK.Platform.Native.Windows.Win32;

namespace OpenTK.Platform.Native.Windows
{
    internal static unsafe partial class Dxgi
    {
        internal const int DXGI_ERROR_NOT_FOUND = unchecked((int)0x887A0002);

        [GeneratedComInterface(Options = ComInterfaceOptions.ComObjectWrapper)]
        [Guid("AEC22FB8-76F3-4639-9BE0-28EB43A67A2E")]
        internal partial interface IDXGIObject
        {
            void SetPrivateData(in Guid name, uint dataSize, void* data);
            void SetPrivateDataInterface(in Guid name, IntPtr /* IUnknown* */ data);
            void GetPrivateData(in Guid name, ref uint dataSize, out void* data);
            void GetParent(in Guid name, out void* data);
        }

        [GeneratedComInterface(Options = ComInterfaceOptions.ComObjectWrapper)]
        [Guid("7B7166EC-21C7-44AE-B21A-C9AE321AE369")]
        internal partial interface IDXGIFactory : IDXGIObject
        {
            [PreserveSig] int /* HRESULT */ EnumAdapters(uint adapter, out IntPtr /* IDXGIAdapter** */ pAdapter);
            // FIXME: Flags
            [PreserveSig] int /* HRESULT */ MakeWindowAssociation(IntPtr /* HWND */ windowHandle, uint flags);
            [PreserveSig] int /* HRESULT */ GetWindowAssociation(out IntPtr /* HWND* */ windowHandle);
            [PreserveSig] int /* HRESULT */ CreateSwapChain(IntPtr /**/ device, IntPtr /* FIXME: DXGI_SWAP_CHAIN_DESC* */ desc, out IntPtr /* IDXGISwapChain** */ swapChain);
            [PreserveSig] int /* HRESULT */ CreateSoftwareAdapter(IntPtr /* HMODULE */ module, out IntPtr /* IDXGIAdapter** */ adapter);
        }

        [DllImport("dxgi.dll")]
        internal static extern int /* HRESULT */ CreateDXGIFactory(in Guid riid, out IntPtr ppFactory);

        internal struct DXGI_ADAPTER_DESC
        {
            public fixed char Description[128];
            public uint VendorId;
            public uint DeviceId;
            public uint SubSysId;
            public uint Revision;
            public nuint DedicatedVideoMemory;
            public nuint DedicatedSystemMemory;
            public nuint SharedSystemMemory;
            public LUID AdapterLuid;
        }

        [GeneratedComInterface(Options = ComInterfaceOptions.ComObjectWrapper)]
        [Guid("2411E7E1-12AC-4CCF-BD14-9798E8534DC0")]
        internal partial interface IDXGIAdapter : IDXGIObject
        {
            [PreserveSig] int /* HRESULT */  EnumOutputs(uint output, out IntPtr /* IDXGIOutput** */ pOutput);
            [PreserveSig] int /* HRESULT */  GetDesc(out DXGI_ADAPTER_DESC /* DXGI_ADAPTER_DESC* */ pOutput);
            [PreserveSig] int /* HRESULT */  CheckInterfaceSupport(in Guid interfaceName, out long umdVersion);
        }

        internal struct DXGI_OUTPUT_DESC
        {
            public fixed char DeviceName[32];
            public RECT DesktopCoordinates;
            public int /* BOOL */ AttachedToDesktop;
            public DXGI_MODE_ROTATION Rotation;
            public IntPtr /* HMONITOR */ Monitor;
        }

        internal struct DXGI_MODE_DESC
        {
            public uint Width;
            public uint Height;
            public DXGI_RATIONAL RefreshRate;
            public DXGI_FORMAT Format;
            public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
            public DXGI_MODE_SCALING Scaling;
        }

        internal struct DXGI_RATIONAL
        {
            public uint Numerator;
            public uint Denominator;
        }

        internal struct DXGI_GAMMA_CONTROL_CAPABILITIES
        {
            public BOOL ScaleAndOffsetSupported;
            public float MaxConvertedValue;
            public float MinConvertedValue;
            public uint NumGammaControlPoints;
            public fixed float ControlPointPositions[1025];
        }

        internal struct DXGI_GAMMA_CONTROL
        {
            public DXGI_RGB Scale;
            public DXGI_RGB Offset;
            public GammaCurveInlineArray GammaCurve;

            [InlineArray(1025)]
            public struct GammaCurveInlineArray
            {
                private DXGI_RGB GammaCurve;
            }
        }

        internal struct DXGI_RGB
        {
            public float Red;
            public float Green;
            public float Blue;
        }

        internal struct DXGI_FRAME_STATISTICS
        {
            public uint PresentCount;
            public uint PresentRefreshCount;
            public uint SyncRefreshCount;
            public long SyncQPCTime;
            public long SyncGPUTime;
        }

        [GeneratedComInterface(Options = ComInterfaceOptions.ComObjectWrapper)]
        [Guid("AE02EEDB-C735-4690-8D52-5A8DC20213AA")]
        internal partial interface IDXGIOutput : IDXGIObject
        {
            [PreserveSig] int GetDesc(out DXGI_OUTPUT_DESC desc);
            [PreserveSig] int GetDisplayModeList(DXGI_FORMAT enumFormat, uint flags, ref uint numModes, out DXGI_MODE_DESC desc);
            [PreserveSig] int FindClosestMatchingMode(in DXGI_MODE_DESC* modeToMatch, out DXGI_MODE_DESC closestMatch, IntPtr /* IUnknown* */ concernedDevice);
            [PreserveSig] int WaitForVBlank();
            [PreserveSig] int TakeOwnership(IntPtr /* IUnknown* */ device, [MarshalAs(UnmanagedType.Bool)] bool exclusive);
            [PreserveSig] void ReleaseOwnership();
            [PreserveSig] int GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES gammaCaps);
            [PreserveSig] int SetGammaControl(in DXGI_GAMMA_CONTROL array);
            [PreserveSig] int GetGammaControl(out DXGI_GAMMA_CONTROL array);
            [PreserveSig] int SetDisplaySurface(IntPtr /* IDXGISurface* */ scanoutSurface);
            [PreserveSig] int GetDisplaySurface(IntPtr /* IDXGISurface* */ destination);
            [PreserveSig] int GetFrameStatistics(out DXGI_FRAME_STATISTICS stats);
        }

        internal struct DXGI_MODE_DESC1
        {
            public uint Width;
            public uint Height;
            public DXGI_RATIONAL RefreshRate;
            public DXGI_FORMAT Format;
            public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
            public DXGI_MODE_SCALING Scaling;
            public BOOL Stereo;
        }

        [GeneratedComInterface(Options = ComInterfaceOptions.ComObjectWrapper)]
        [Guid("00CDDEA8-939B-4B83-A340-A685226666CC")]
        internal partial interface IDXGIOutput1 : IDXGIOutput
        {
            [PreserveSig] int GetDisplayModeList1(DXGI_FORMAT enumFormat, uint flags, ref uint numModes, out DXGI_MODE_DESC1 desc);
            [PreserveSig] int FindClosestMatchingMode1(in DXGI_MODE_DESC1* modeToMatch, out DXGI_MODE_DESC1 closestMatch, IntPtr /* IUnknown* */ concernedDevice);
            [PreserveSig] int GetDisplaySurfaceData1(IntPtr /* IDXGIResource* */ destination);
            [PreserveSig] int DuplicateOutput(IntPtr /* IUnknown* */ device, out IntPtr /* IDXGIOutputDuplication** */ outputDuplication);
        }

        [GeneratedComInterface(Options = ComInterfaceOptions.ComObjectWrapper)]
        [Guid("595E39D1-2724-4663-99B1-DA969DE28364")]
        internal partial interface IDXGIOutput2 : IDXGIOutput1
        {
            [PreserveSig] BOOL SupportsOverlays();
        }

        [GeneratedComInterface(Options = ComInterfaceOptions.ComObjectWrapper)]
        [Guid("8A6BB301-7E7E-41F4-A8E0-5B32F7F99B18")]
        internal partial interface IDXGIOutput3 : IDXGIOutput2
        {
            [PreserveSig] int CheckOverlaySupport(DXGI_FORMAT enumFormat, IUnknown* concernedDevice, out uint flags);
        }

        [GeneratedComInterface(Options = ComInterfaceOptions.ComObjectWrapper)]
        [Guid("DC7DCA35-2196-414D-9F53-617884032A60")]
        internal partial interface IDXGIOutput4 : IDXGIOutput3
        {
            [PreserveSig] int CheckOverlayColorSpaceSupport(DXGI_FORMAT format, DXGI_COLOR_SPACE_TYPE colorSpace, IntPtr /* IUnknown* */ concernedDevice, out DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG flags);
        }

        [GeneratedComInterface(Options = ComInterfaceOptions.ComObjectWrapper)]
        [Guid("80A07424-AB52-42EB-833C-0C42FD282D98")]
        internal partial interface IDXGIOutput5 : IDXGIOutput4
        {
            [PreserveSig] int /* HRESULT */ DuplicateOutput1(IntPtr /* IUnknown* */ device, uint flags, uint supportedFormatsCount, in DXGI_FORMAT /* const DXGI_FORMAT* */ supportedFormats, out IntPtr /* IDXGIOutputDuplication** */ outputDuplication);
        }

        internal struct DXGI_OUTPUT_DESC1
        {
            public fixed char DeviceName[32];
            public RECT DesktopCoordinates;
            public BOOL AttachedToDesktop;
            public DXGI_MODE_ROTATION Rotation;
            public IntPtr /* HMONITOR */ Monitor;
            public uint BitsPerColor;
            public DXGI_COLOR_SPACE_TYPE ColorSpace;
            public XYCoordinate RedPrimary;
            public XYCoordinate GreenPrimary;
            public XYCoordinate BluePrimary;
            public XYCoordinate WhitePoint;
            public float MinLuminance;
            public float MaxLuminance;
            public float MaxFullFrameLuminance;
        }

        internal struct XYCoordinate
        {
            public float X;
            public float Y;

            public static explicit operator Vector2(XYCoordinate xy) => new Vector2(xy.X, xy.Y);
        }

        [GeneratedComInterface(Options = ComInterfaceOptions.ComObjectWrapper)]
        [Guid("068346E8-AAEC-4B84-ADD7-137F513F77A1")]
        internal partial interface IDXGIOutput6 : IDXGIOutput5
        {
            [PreserveSig] int /* HRESULT */ GetDesc1(out DXGI_OUTPUT_DESC1 desc);
            [PreserveSig] int /* HRESULT */ CheckHardwareCompositionSupport(out DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS flags);
        }
    }

    internal enum DXGI_MODE_ROTATION
    {
        Unspecified = 0,
        Identity = 1,
        Rotate90 = 2,
        Rotate180 = 3,
        Rotate270 = 4
    }

    internal enum DXGI_FORMAT : uint
    {
        UNKNOWN = 0,
        R32G32B32A32_TYPELESS = 1,
        R32G32B32A32_FLOAT = 2,
        R32G32B32A32_UINT = 3,
        R32G32B32A32_SINT = 4,
        R32G32B32_TYPELESS = 5,
        R32G32B32_FLOAT = 6,
        R32G32B32_UINT = 7,
        R32G32B32_SINT = 8,
        R16G16B16A16_TYPELESS = 9,
        R16G16B16A16_FLOAT = 10,
        R16G16B16A16_UNORM = 11,
        R16G16B16A16_UINT = 12,
        R16G16B16A16_SNORM = 13,
        R16G16B16A16_SINT = 14,
        R32G32_TYPELESS = 15,
        R32G32_FLOAT = 16,
        R32G32_UINT = 17,
        R32G32_SINT = 18,
        R32G8X24_TYPELESS = 19,
        D32_FLOAT_S8X24_UINT = 20,
        R32_FLOAT_X8X24_TYPELESS = 21,
        X32_TYPELESS_G8X24_UINT = 22,
        R10G10B10A2_TYPELESS = 23,
        R10G10B10A2_UNORM = 24,
        R10G10B10A2_UINT = 25,
        R11G11B10_FLOAT = 26,
        R8G8B8A8_TYPELESS = 27,
        R8G8B8A8_UNORM = 28,
        R8G8B8A8_UNORM_SRGB = 29,
        R8G8B8A8_UINT = 30,
        R8G8B8A8_SNORM = 31,
        R8G8B8A8_SINT = 32,
        R16G16_TYPELESS = 33,
        R16G16_FLOAT = 34,
        R16G16_UNORM = 35,
        R16G16_UINT = 36,
        R16G16_SNORM = 37,
        R16G16_SINT = 38,
        R32_TYPELESS = 39,
        D32_FLOAT = 40,
        R32_FLOAT = 41,
        R32_UINT = 42,
        R32_SINT = 43,
        R24G8_TYPELESS = 44,
        D24_UNORM_S8_UINT = 45,
        R24_UNORM_X8_TYPELESS = 46,
        X24_TYPELESS_G8_UINT = 47,
        R8G8_TYPELESS = 48,
        R8G8_UNORM = 49,
        R8G8_UINT = 50,
        R8G8_SNORM = 51,
        R8G8_SINT = 52,
        R16_TYPELESS = 53,
        R16_FLOAT = 54,
        D16_UNORM = 55,
        R16_UNORM = 56,
        R16_UINT = 57,
        R16_SNORM = 58,
        R16_SINT = 59,
        R8_TYPELESS = 60,
        R8_UNORM = 61,
        R8_UINT = 62,
        R8_SNORM = 63,
        R8_SINT = 64,
        A8_UNORM = 65,
        R1_UNORM = 66,
        R9G9B9E5_SHAREDEXP = 67,
        R8G8_B8G8_UNORM = 68,
        G8R8_G8B8_UNORM = 69,
        BC1_TYPELESS = 70,
        BC1_UNORM = 71,
        BC1_UNORM_SRGB = 72,
        BC2_TYPELESS = 73,
        BC2_UNORM = 74,
        BC2_UNORM_SRGB = 75,
        BC3_TYPELESS = 76,
        BC3_UNORM = 77,
        BC3_UNORM_SRGB = 78,
        BC4_TYPELESS = 79,
        BC4_UNORM = 80,
        BC4_SNORM = 81,
        BC5_TYPELESS = 82,
        BC5_UNORM = 83,
        BC5_SNORM = 84,
        B5G6R5_UNORM = 85,
        B5G5R5A1_UNORM = 86,
        B8G8R8A8_UNORM = 87,
        B8G8R8X8_UNORM = 88,
        R10G10B10_XR_BIAS_A2_UNORM = 89,
        B8G8R8A8_TYPELESS = 90,
        B8G8R8A8_UNORM_SRGB = 91,
        B8G8R8X8_TYPELESS = 92,
        B8G8R8X8_UNORM_SRGB = 93,
        BC6H_TYPELESS = 94,
        BC6H_UF16 = 95,
        BC6H_SF16 = 96,
        BC7_TYPELESS = 97,
        BC7_UNORM = 98,
        BC7_UNORM_SRGB = 99,
        AYUV = 100,
        Y410 = 101,
        Y416 = 102,
        NV12 = 103,
        P010 = 104,
        P016 = 105,
        _420_OPAQUE = 106,
        YUY2 = 107,
        Y210 = 108,
        Y216 = 109,
        NV11 = 110,
        AI44 = 111,
        IA44 = 112,
        P8 = 113,
        A8P8 = 114,
        B4G4R4A4_UNORM = 115,
        P208 = 130,
        V208 = 131,
        V408 = 132,
        SAMPLER_FEEDBACK_MIN_MIP_OPAQUE = 189,
        SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE = 190,
    }

    internal enum DXGI_MODE_SCANLINE_ORDER
    {
        Unspecified = 0,
        Progressive = 1,
        UpperFieldFirst = 2,
        LowerFieldFirst = 3
    }

    internal enum DXGI_MODE_SCALING
    {
        Unspecified = 0,
        Centered = 1,
        Stretched = 2
    }

    internal enum DXGI_COLOR_SPACE_TYPE : uint
    {
        RGB_FULL_G22_NONE_P709 = 0,
        RGB_FULL_G10_NONE_P709 = 1,
        RGB_STUDIO_G22_NONE_P709 = 2,
        RGB_STUDIO_G22_NONE_P2020 = 3,
        RESERVED = 4,
        YCBCR_FULL_G22_NONE_P709_X601 = 5,
        YCBCR_STUDIO_G22_LEFT_P601 = 6,
        YCBCR_FULL_G22_LEFT_P601 = 7,
        YCBCR_STUDIO_G22_LEFT_P709 = 8,
        YCBCR_FULL_G22_LEFT_P709 = 9,
        YCBCR_STUDIO_G22_LEFT_P2020 = 10,
        YCBCR_FULL_G22_LEFT_P2020 = 11,
        RGB_FULL_G2084_NONE_P2020 = 12,
        YCBCR_STUDIO_G2084_LEFT_P2020 = 13,
        RGB_STUDIO_G2084_NONE_P2020 = 14,
        YCBCR_STUDIO_G22_TOPLEFT_P2020 = 15,
        YCBCR_STUDIO_G2084_TOPLEFT_P2020 = 16,
        RGB_FULL_G22_NONE_P2020 = 17,
        YCBCR_STUDIO_GHLG_TOPLEFT_P2020 = 18,
        YCBCR_FULL_GHLG_TOPLEFT_P2020 = 19,
        RGB_STUDIO_G24_NONE_P709 = 20,
        RGB_STUDIO_G24_NONE_P2020 = 21,
        YCBCR_STUDIO_G24_LEFT_P709 = 22,
        YCBCR_STUDIO_G24_LEFT_P2020 = 23,
        YCBCR_STUDIO_G24_TOPLEFT_P2020 = 24,
        CUSTOM = 0xFFFFFFFF
    }

    [Flags]
    internal enum DXGI_OVERLAY_SUPPORT_FLAG : uint
    {
        /// <summary>
        /// Direct overlay support.
        /// </summary>
        Direct = 0x1,
        /// <summary>
        /// Scaling overlay support.
        /// </summary>
        Scaling = 0x2
    }

    [Flags]
    internal enum DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG : uint
    {
        /// <summary>
        /// Overlay color space support is present.
        /// </summary>
        Present = 0x1
    }

    [Flags]
    internal enum DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS : uint
    {
        Fullscreen = 1,
        Windowed = 2,
        CursorStretched = 4,
    }
}
