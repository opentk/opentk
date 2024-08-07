using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.Windows.DirectInput;
using static OpenTK.Platform.Native.Windows.Win32;
using static System.Formats.Asn1.AsnWriter;

namespace OpenTK.Platform.Native.Windows
{
#pragma warning disable CS0649 // Field '' is never assigned to, and will always have its default value 0
    internal static class DirectInput
    {
        internal static void CheckHResult(int hresult)
        {
            Marshal.ThrowExceptionForHR(hresult);
        }

        internal unsafe struct IUnknown
        {
            public static readonly IUnknown Null = default;

            public struct _VTable
            {
                public IntPtr QueryInterface;
                public delegate* unmanaged<IntPtr, uint> AddRef;
                public delegate* unmanaged<IntPtr, uint> Release;
            }

            public _VTable** VTable;

            public IntPtr Handle => (IntPtr)VTable;

            // FIXME: This is only temporary while we have COM objects refered to by IntPtr
            public static explicit operator IUnknown(IntPtr ptr) => new IUnknown() { VTable = (_VTable**)ptr };

            public uint Release()
            {
                return (*VTable)->Release((IntPtr)VTable);
            }
        }

        internal const int MAX_PATH = 260;

        internal unsafe struct DIDEVICEINSTANCE
        {
            public uint dwSize;
            public Guid guidInstance;
            public Guid guidProduct;
            public DevType dwDevType;
            public fixed char tszInstanceName[MAX_PATH];
            public fixed char tszProductName[MAX_PATH];
            public Guid guidFFDriver;
            public ushort wUsagePage;
            public ushort wUsage;
        }

        public unsafe delegate int EnumDeviceCallback(DIDEVICEINSTANCE* lpddi, IntPtr pvRef);

        internal unsafe struct IDirectInput8
        {
            public struct _VTable
            {
                public IntPtr QueryInterface;
                public delegate* unmanaged<IntPtr, uint> AddRef;
                public delegate* unmanaged<IntPtr, uint> Release;

                public delegate* unmanaged<IDirectInput8, ref Guid, out IDirectInputDevice8, IntPtr, int> CreateDevice;
                public delegate* unmanaged<IDirectInput8, DevType, delegate* unmanaged<ref DIDEVICEINSTANCE, IntPtr, int>, IntPtr, DIEDFL, int> EnumDevices;
                public delegate* unmanaged<IDirectInput8, int> GetDeviceStatus;
                public delegate* unmanaged<IDirectInput8, int> RunControlPanel;
                public delegate* unmanaged<IDirectInput8, IntPtr, uint, int> Initialize;
                public delegate* unmanaged<IDirectInput8, int> FindDevice;
                public delegate* unmanaged<IDirectInput8, int> EnumDevicesBySemantics;
                public delegate* unmanaged<IDirectInput8, int> ConfigureDevices;
            }

            public _VTable** VTable;

            public IntPtr Handle => (IntPtr)VTable;

            public static explicit operator IDirectInput8(IUnknown ptr) => new IDirectInput8() { VTable = (_VTable**)ptr.VTable };

            public void Initialize(IntPtr hinst, uint dwVersion)
            {
                int result = (*VTable)->Initialize(this, hinst, dwVersion);
                CheckHResult(result);
            }

            public void CreateDevice(Guid rguid, out IDirectInputDevice8 lplpDirectInputDevice, IUnknown pUnkOuter)
            {
                int result = (*VTable)->CreateDevice(this, ref rguid, out lplpDirectInputDevice, pUnkOuter.Handle);
                CheckHResult(result);
            }

            public void EnumDevices(DevType devType, EnumDeviceCallback callback, IntPtr pvRef, DIEDFL dwFlags)
            {
                IntPtr callbackPtr = Marshal.GetFunctionPointerForDelegate(callback);
                int result = (*VTable)->EnumDevices(this, devType, (delegate* unmanaged<ref DIDEVICEINSTANCE, IntPtr, int>)callbackPtr, pvRef, dwFlags);
                CheckHResult(result);
            }
        }

        // FIXME: Enums!
        internal struct DIDEVCAPS
        {
            public uint dwSize;
            public DIDC dwFlags;
            public uint dwDevType;
            public uint dwAxes;
            public uint dwButtons;
            public uint dwPOVs;
            public uint dwFFSamplePeriod;
            public uint dwFFMinTimeResolution;
            public uint dwFirmwareRevision;
            public uint dwHardwareRevision;
            public uint dwFFDriverVersion;
        }

        internal unsafe struct DIDEVICEOBJECTINSTANCE
        {
            public uint dwSize;
            public Guid guidType;
            public uint dwOfs;
            public uint dwType;
            public uint dwFlags;
            public fixed char tszName[MAX_PATH];
            public uint dwFFMaxForce;
            public uint dwFFForceResolution;
            public ushort wCollectionNumber;
            public ushort wDesignatorIndex;
            public ushort wUsagePage;
            public ushort wUsage;
            public uint dwDimension;
            public ushort wExponent;
            public ushort wReportId;
        }

        internal struct DIPROPHEADER
        {
            public uint dwSize;
            public uint dwHeaderSize;
            public uint dwObj;
            public uint dwHow;
        }

        internal struct DIDEVICEOBJECTDATA
        {
            public uint dwOfs;
            public uint dwData;
            public uint dwTimeStamp;
            public uint dwSequence;
            public UIntPtr uAppData;
        }

        internal unsafe struct DIDATAFORMAT
        {
            public uint dwSize;
            public uint dwObjSize;
            public DIDF dwFlags;
            public uint dwDataSize;
            public uint dwNumObjs;
            public DIOBJECTDATAFORMAT* rgodf;
        }

        internal unsafe struct DIOBJECTDATAFORMAT
        {
            public Guid* pguid;
            public int dwOfs;
            public DIDFT dwType;
            public DIDOI dwFlags;

            public DIOBJECTDATAFORMAT(Guid* pguid, int dwOfs, DIDFT dwType, DIDOI dwFlags)
            {
                this.pguid = pguid;
                this.dwOfs = dwOfs;
                this.dwType = dwType;
                this.dwFlags = dwFlags;
            }
        }

        // FIXME: FixedAddressValueType doesn't work with AssemblyLoadContext...
        [FixedAddressValueType]
        internal static readonly Guid GUID_XAxis = new Guid(0xA36D02E0,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
        [FixedAddressValueType]
        internal static readonly Guid GUID_YAxis = new Guid(0xA36D02E1,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
        [FixedAddressValueType]
        internal static readonly Guid GUID_ZAxis = new Guid(0xA36D02E2,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
        [FixedAddressValueType]
        internal static readonly Guid GUID_RxAxis = new Guid(0xA36D02F4,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
        [FixedAddressValueType]
        internal static readonly Guid GUID_RyAxis = new Guid(0xA36D02F5,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
        [FixedAddressValueType]
        internal static readonly Guid GUID_RzAxis = new Guid(0xA36D02E3,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
        [FixedAddressValueType]
        internal static readonly Guid GUID_Slider = new Guid(0xA36D02E4,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
        [FixedAddressValueType]
        internal static readonly Guid GUID_Button = new Guid(0xA36D02F0,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
        [FixedAddressValueType]
        internal static readonly Guid GUID_Key = new Guid(0x55728220,0xD33C,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
        [FixedAddressValueType]
        internal static readonly Guid GUID_POV = new Guid(0xA36D02F2,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
        [FixedAddressValueType]
        internal static readonly Guid GUID_Unknown = new Guid(0xA36D02F3,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);

        [FixedAddressValueType]
        internal unsafe static readonly DIOBJECTDATAFORMAT[] c_dfDIJoystick_rgodf = new DIOBJECTDATAFORMAT[]
        {
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_XAxis),   0, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_YAxis),   4, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_ZAxis),   8, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),

            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_RxAxis), 12, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_RyAxis), 16, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_RzAxis), 20, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),

            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_Slider), 24, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_Slider), 28, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),

            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_POV),    32, DIDFT.POV|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_POV),    36, DIDFT.POV|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_POV),    40, DIDFT.POV|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_POV),    44, DIDFT.POV|DIDFT.Optional|DIDFT.AnyInstance, 0),

            new DIOBJECTDATAFORMAT(null,                                     48, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     49, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     50, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     51, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     52, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     53, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     54, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     55, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     56, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     57, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     58, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     59, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     60, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     61, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     62, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     63, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     64, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     65, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     66, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     67, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     68, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     69, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     70, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     71, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     72, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     73, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     74, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     75, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     76, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     77, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     78, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     79, DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
        };

        [FixedAddressValueType]
        internal unsafe static DIDATAFORMAT c_dfDIJoystick = new DIDATAFORMAT()
        {
            dwSize = (uint)sizeof(DIDATAFORMAT),
            dwObjSize = (uint)sizeof(DIOBJECTDATAFORMAT),
            dwFlags = DIDF.AbsAxis,
            dwDataSize = (uint)sizeof(DIJOYSTATE),
            dwNumObjs = (uint)c_dfDIJoystick_rgodf.Length,
            rgodf = (DIOBJECTDATAFORMAT*)Unsafe.AsPointer(ref MemoryMarshal.GetArrayDataReference(c_dfDIJoystick_rgodf)),
        };

        internal unsafe struct DIJOYSTATE
        {
            public int lX;
            public int lY;
            public int lZ;
            public int lRx;
            public int lRy;
            public int lRz;
            public fixed int rglSlider[2];
            public fixed uint rgdwPOV[4];
            public fixed byte rgbButtons[32];
        }

        internal unsafe struct DIEFFECT
        {
            public uint dwSize;
            public uint dwFlags;
            public uint dwDuration;
            public uint dwSamplePeriod;
            public uint dwGain;
            public uint dwTriggerButton;
            public uint dwTriggerRepeatInterval;
            public uint cAxes;
            public uint* rgdwAxes;
            public int* rglDirection;
            public DIENVELOPE* lpEnvelope;
            public uint cbTypeSpecificParams;
            public void* lpvTypeSpecificParams;
            public uint dwStartDelay;
        }

        internal struct DIENVELOPE
        {
            public uint dwSize;
            public uint dwAttackLevel;
            public uint dwAttackTime;
            public uint dwFadeLevel;
            public uint dwFadeTime;
        }

        internal unsafe struct DIEFFECTINFO
        {
            public uint dwSize;
            public Guid guid;
            public uint dwEffType;
            public uint dwStaticParams;
            public uint dwDynamicParams;
            public fixed char tszName[MAX_PATH];
        }

        internal unsafe struct DIEFFESCAPE
        {
            public uint dwSize;
            public uint dwCommand;
            public void* lpvInBuffer;
            public uint cbInBuffer;
            public void* lpvOutBuffer;
            public uint cbOutBuffer;
        }

        internal unsafe struct DIFILEEFFECT
        {
            public uint dwSize;
            public Guid GuidEffect;
            public DIEFFECT* lpDiEffect;
            public fixed char szFriendlyName[MAX_PATH];
        }

        internal unsafe struct DIACTIONFORMAT
        {
            public uint dwSize;
            public uint dwActionSize;
            public uint dwDataSize;
            public uint dwNumActions;
            public DIACTION* rgoAction;
            public Guid guidActionMap;
            public uint dwGenre;
            public uint dwBufferSize;
            public int lAxisMin;
            public int lAxisMax;
            public IntPtr /* HINSTANCE */ hInstString;
            public FILETIME ftTimeStamp;
            public uint dwCRC;
            public fixed char tszActionMap[MAX_PATH];
        }

        internal unsafe struct DIACTION
        {
            public UIntPtr uAppData;
            public uint dwSemantic;
            public uint dwFlags;
            public Union union;
            public Guid guidInstance;
            public uint dwObjID;
            public uint dwHow;

            internal struct Union
            {
                public char* lptszActionName;
                public uint uResIdString;
            }
        }

        internal unsafe struct DIDEVICEIMAGEINFOHEADER
        {
            public uint dwSize;
            public uint dwSizeImageInfo;
            public uint dwcViews;
            public uint dwcButtons;
            public uint dwcAxes;
            public uint dwcPOVs;
            public uint dwBufferSize;
            public uint dwBufferUsed;
            public DIDEVICEIMAGEINFO* lprgImageInfoArray;
        }

        internal unsafe struct DIDEVICEIMAGEINFO
        {
            public fixed char tszImagePath[MAX_PATH];
            public uint dwFlags;
            public uint dwViewID;
            public RECT rcOverlay;
            public uint dwObjID;
            public uint dwcValidPts;
            // POINT rgptCalloutLine[5];
            // Can't make a fixed member of structs...
            public POINT rgptCalloutLine0;
            public POINT rgptCalloutLine1;
            public POINT rgptCalloutLine2;
            public POINT rgptCalloutLine3;
            public POINT rgptCalloutLine4;
            public RECT rcCalloutRect;
            public uint dwTextAlign;
        }

        internal unsafe struct IDirectInputDevice8
        {
            public struct _VTable
            {
                public IntPtr QueryInterface;
                public delegate* unmanaged<IntPtr, uint> AddRef;
                public delegate* unmanaged<IntPtr, uint> Release;

                public delegate* unmanaged<IDirectInputDevice8, DIDEVCAPS*, int> GetCapabilities;
                public delegate* unmanaged<IDirectInputDevice8, delegate* unmanaged<DIDEVICEOBJECTINSTANCE*, IntPtr, int>, IntPtr, uint, int> EnumObjects;
                public delegate* unmanaged<IDirectInputDevice8, ref Guid, DIPROPHEADER*, int> GetProperty;
                public delegate* unmanaged<IDirectInputDevice8, ref Guid, DIPROPHEADER*, int> SetProperty;
                public delegate* unmanaged<IDirectInputDevice8, int> Acquire;
                public delegate* unmanaged<IDirectInputDevice8, int> Unacquire;
                public delegate* unmanaged<IDirectInputDevice8, uint, IntPtr, int> GetDeviceState;
                public delegate* unmanaged<IDirectInputDevice8, uint, DIDEVICEOBJECTDATA*, uint*, uint, int> GetDeviceData;
                public delegate* unmanaged<IDirectInputDevice8, DIDATAFORMAT*, int> SetDataFormat;
                public delegate* unmanaged<IDirectInputDevice8, IntPtr /* HANDLE */, int> SetEventNotification;
                public delegate* unmanaged<IDirectInputDevice8, HWND, uint, int> SetCooperativeLevel;
                public delegate* unmanaged<IDirectInputDevice8, DIDEVICEOBJECTINSTANCE*, uint, uint, int> GetObjectInfo;
                public delegate* unmanaged<IDirectInputDevice8, DIDEVICEINSTANCE*, int> GetDeviceInfo;
                public delegate* unmanaged<IDirectInputDevice8, HWND, uint, int> RunControlPanel;
                public delegate* unmanaged<IDirectInputDevice8, IntPtr /* HINSTANCE */, uint, ref Guid, int> Initialize;
                public delegate* unmanaged<IDirectInputDevice8, ref Guid, DIEFFECT*, out IDirectInputEffect, IUnknown, int> CreateEffect;
                public delegate* unmanaged<IDirectInputDevice8, delegate* unmanaged<DIEFFECTINFO*, IntPtr, int>, IntPtr, uint, int> EnumEffects;
                public delegate* unmanaged<IDirectInputDevice8, DIEFFECTINFO*, ref Guid, int> GetEffectInfo;
                public delegate* unmanaged<IDirectInputDevice8, out ushort, int> GetForceFeedbackState;
                public delegate* unmanaged<IDirectInputDevice8, uint, int> SendForceFeedbackCommand;
                public delegate* unmanaged<IDirectInputDevice8, delegate* unmanaged<IDirectInputEffect, IntPtr, int>, IntPtr, uint, int> EnumCreatedEffectObjects;
                public delegate* unmanaged<IDirectInputDevice8, DIEFFESCAPE*, int> Escape;
                public delegate* unmanaged<IDirectInputDevice8, int> Poll;
                public delegate* unmanaged<IDirectInputDevice8, uint, DIDEVICEOBJECTDATA*, ref ushort, uint, int> SendDeviceData;
                public delegate* unmanaged<IDirectInputDevice8, char*, delegate* unmanaged<DIFILEEFFECT, IntPtr, int>, IntPtr, uint, int> EnumEffectsInFile;
                public delegate* unmanaged<IDirectInputDevice8, char*, uint, DIFILEEFFECT*, uint, int> WriteEffectToFile;
                public delegate* unmanaged<IDirectInputDevice8, DIACTIONFORMAT*, char*, uint, int> BuildActionMap;
                public delegate* unmanaged<IDirectInputDevice8, DIACTIONFORMAT*, char*, uint, int> SetActionMap;
                public delegate* unmanaged<IDirectInputDevice8, DIDEVICEIMAGEINFOHEADER*, int> GetImageInfo;

            }

            public _VTable** VTable;

            public IntPtr Handle => (IntPtr)VTable;

            public void Initialize(IntPtr hinst, uint dwVersion, ref Guid rguid)
            {
                int result = (*VTable)->Initialize(this, hinst, dwVersion, ref rguid);
                CheckHResult(result);
            }

            public void GetCapabilities(out DIDEVCAPS lpDIDevCaps)
            {
                lpDIDevCaps.dwSize = (uint)Unsafe.SizeOf<DIDEVCAPS>();
                int result;
                fixed (DIDEVCAPS* ptr = &lpDIDevCaps)
                {
                    result = (*VTable)->GetCapabilities(this, ptr);
                }
                CheckHResult(result);
            }

            public void Acquire()
            {
                int result = (*VTable)->Acquire(this);
                CheckHResult(result);
            }

            public void Unacquire()
            {
                int result = (*VTable)->Unacquire(this);
                CheckHResult(result);
            }

            public void GetDeviceData(uint cbObjectData, ref DIDEVICEOBJECTDATA rgdod)
            {

            }

            public unsafe void SetDataFormat(ref DIDATAFORMAT format)
            {
                int result = (*VTable)->SetDataFormat(this, (DIDATAFORMAT*)Unsafe.AsPointer(ref format));
                CheckHResult(result);
            }

            public unsafe void GetDeviceInfo(out DIDEVICEINSTANCE pdidi)
            {
                pdidi.dwSize = (uint)Unsafe.SizeOf<DIDEVICEINSTANCE>();
                int result;
                fixed (DIDEVICEINSTANCE* ptr = &pdidi)
                {
                    result = (*VTable)->GetDeviceInfo(this, ptr);
                }
                CheckHResult(result);
            }

        }

        internal unsafe struct IDirectInputEffect
        {
            public struct _VTable
            {
                public IntPtr QueryInterface;
                public delegate* unmanaged<IntPtr, uint> AddRef;
                public delegate* unmanaged<IntPtr, uint> Release;

                public delegate* unmanaged<IDirectInputEffect, IntPtr /* HINSTANCE */, uint, ref Guid, int> Initialize;
                public delegate* unmanaged<IDirectInputEffect, out Guid, int> GetEffectGuid;
                public delegate* unmanaged<IDirectInputEffect, DIEFFECT*, uint, int> GetParameters;
                public delegate* unmanaged<IDirectInputEffect, DIEFFECT*, uint, int> SetParameters;
                public delegate* unmanaged<IDirectInputEffect, uint, uint, int> Start;
                public delegate* unmanaged<IDirectInputEffect, int> Stop;
                public delegate* unmanaged<IDirectInputEffect, out ushort, int> GetEffectStatus;
                public delegate* unmanaged<IDirectInputEffect, int> Download;
                public delegate* unmanaged<IDirectInputEffect, int> Unload;
                public delegate* unmanaged<IDirectInputEffect, DIEFFESCAPE*, int> Escape;
            }

            public _VTable** VTable;

            public IntPtr Handle => (IntPtr)VTable;
        }

        internal static readonly Guid CLSID_DirectInput = new Guid(0x25E609E4, 0xB259, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00);

        internal static readonly Guid IID_IDirectInputW = new Guid(0xBF798031, 0x483A, 0x4DA2, 0xAA, 0x99, 0x5D, 0x64, 0xED, 0x36, 0x97, 0x00);

        internal static void CoCreateInstance(
            ref Guid /* REFCLSID */ rclsid,
            IUnknown pUnkOuter,
            CLSCTX dwClsContext,
            ref Guid /* REFIID */ riid,
            out IUnknown ppv)
        {
            int result = CoCreateInstance(ref rclsid, pUnkOuter, dwClsContext, ref riid, out ppv);
            CheckHResult(result);

            [DllImport("ole32.dll")]
            static extern int /* HRESULT */ CoCreateInstance(
                ref Guid /* REFCLSID */ rclsid,
                IUnknown pUnkOuter,
                CLSCTX dwClsContext,
                ref Guid /* REFIID */ riid,
                out IUnknown ppv);
        }
    }
#pragma warning disable CS0649 // Field '' is never assigned to, and will always have its default value 0
}
