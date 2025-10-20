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
        /// <summary>
        /// Access to the device has been lost.  It must be re-acquired.
        /// </summary>
        internal static readonly int DIERR_INPUTLOST = MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_READ_FAULT);

        /// <summary>
        /// The operation cannot be performed while the device is acquired.
        /// </summary>
        internal static readonly int DIERR_ACQUIRED = MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_BUSY);

        /// <summary>
        /// The operation cannot be performed unless the device is acquired.
        /// </summary>
        internal static readonly int DIERR_NOTACQUIRED = MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_INVALID_ACCESS);

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
                GC.KeepAlive(callback);
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
            public DIDFT dwType;
            public DIDOI dwFlags;
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
            public DIPHHow dwHow;
        }

        internal struct DIPROPDWORD
        {
            public DIPROPHEADER diph;
            public uint dwData;
        }

        internal struct DIPROPRANGE
        {
            public DIPROPHEADER diph;
            public int lMin;
            public int lMax;
        }

        internal unsafe struct DIPROPSTRING
        {
            public DIPROPHEADER diph;
            public fixed char wsz[MAX_PATH];
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

        internal enum DIPHHow : uint
        {
            /// <summary>
            /// The dwObj member must be 0.
            /// </summary>
            Device = 0,
            /// <summary>
            /// The dwObj member is the offset into the current data format of the object whose property is being accessed.
            /// </summary>
            ByOffset = 1,
            /// <summary>
            /// The dwObj member is the object type/instance identifier.
            /// This identifier is returned in the dwType member of the DIDEVICEOBJECTINSTANCE structure returned from a previous call to the IDirectInputDevice8::EnumObjects member.
            /// </summary>
            ByID = 2,
            /// <summary>
            /// The dwObj member is the human interface device usage page and usage values in packed form.
            /// </summary>
            ByUsage = 3,
        }

        internal static readonly unsafe Guid* DIPROP_BUFFERSIZE         = (Guid*)1;
        internal enum DIPropAxisMode : int
        {
            Abs = 0,
            Rel = 1,
        }
        internal static readonly unsafe Guid* DIPROP_AXISMODE           = (Guid*)2;
        internal static readonly unsafe Guid* DIPROP_GRANULARITY        = (Guid*)3;
        internal static readonly unsafe Guid* DIPROP_RANGE              = (Guid*)4;
        internal static readonly unsafe Guid* DIPROP_DEADZONE           = (Guid*)5;
        internal static readonly unsafe Guid* DIPROP_SATURATION         = (Guid*)6;
        internal static readonly unsafe Guid* DIPROP_FFGAIN             = (Guid*)7;
        internal static readonly unsafe Guid* DIPROP_FFLOAD             = (Guid*)8;
        internal enum DIPropAutoCenter : int
        {
            Off = 0,
            On = 1,
        }
        internal static readonly unsafe Guid* DIPROP_AUTOCENTER         = (Guid*)9;
        internal enum DIPropCalibrationMode : int
        {
            Cooked = 0,
            Raw = 1,
        }
        internal static readonly unsafe Guid* DIPROP_CALIBRATIONMODE    = (Guid*)10;
        internal static readonly unsafe Guid* DIPROP_CALIBRATION        = (Guid*)11;
        internal static readonly unsafe Guid* DIPROP_GUIDANDPATH        = (Guid*)12;
        internal static readonly unsafe Guid* DIPROP_INSTANCENAME       = (Guid*)13;
        internal static readonly unsafe Guid* DIPROP_PRODUCTNAME        = (Guid*)14;
        internal static readonly unsafe Guid* DIPROP_JOYSTICKID         = (Guid*)15;
        internal static readonly unsafe Guid* DIPROP_GETPORTDISPLAYNAME = (Guid*)16;
        internal static readonly unsafe Guid* DIPROP_PHYSICALRANGE      = (Guid*)18;
        internal static readonly unsafe Guid* DIPROP_LOGICALRANGE       = (Guid*)19;
        internal static readonly unsafe Guid* DIPROP_KEYNAME            = (Guid*)20;
        internal static readonly unsafe Guid* DIPROP_CPOINTS            = (Guid*)21;
        internal static readonly unsafe Guid* DIPROP_APPDATA            = (Guid*)22;
        internal static readonly unsafe Guid* DIPROP_SCANCODE           = (Guid*)23;
        internal static readonly unsafe Guid* DIPROP_VIDPID             = (Guid*)24;
        internal static readonly unsafe Guid* DIPROP_USERNAME           = (Guid*)25;
        internal static readonly unsafe Guid* DIPROP_TYPENAME           = (Guid*)26;

        internal static readonly int DIJOFS_X  = (int)Marshal.OffsetOf<DIJOYSTATE>(nameof(DIJOYSTATE.lX));
        internal static readonly int DIJOFS_Y  = (int)Marshal.OffsetOf<DIJOYSTATE>(nameof(DIJOYSTATE.lY));
        internal static readonly int DIJOFS_Z  = (int)Marshal.OffsetOf<DIJOYSTATE>(nameof(DIJOYSTATE.lZ));
        internal static readonly int DIJOFS_RX = (int)Marshal.OffsetOf<DIJOYSTATE>(nameof(DIJOYSTATE.lRx));
        internal static readonly int DIJOFS_RY = (int)Marshal.OffsetOf<DIJOYSTATE>(nameof(DIJOYSTATE.lRy));
        internal static readonly int DIJOFS_RZ = (int)Marshal.OffsetOf<DIJOYSTATE>(nameof(DIJOYSTATE.lRz));
        internal static readonly int rglSlider_Offset = (int)Marshal.OffsetOf<DIJOYSTATE>(nameof(DIJOYSTATE.rglSlider));
        internal static int DIJOFS_SLIDER(int n) => (rglSlider_Offset + n * sizeof(int));
        internal static readonly int rgdwPOV_Offset = (int)Marshal.OffsetOf<DIJOYSTATE>(nameof(DIJOYSTATE.rgdwPOV));
        internal static int DIJOFS_POV(int n) => (rgdwPOV_Offset + n * sizeof(uint));
        internal static readonly int rgbButtons_Offset = (int)Marshal.OffsetOf<DIJOYSTATE>(nameof(DIJOYSTATE.rgbButtons));
        internal static int DIJOFS_BUTTON(int n) => (rgbButtons_Offset + (n));
        internal static readonly int DIJOFS_BUTTON0  = DIJOFS_BUTTON(0);
        internal static readonly int DIJOFS_BUTTON1  = DIJOFS_BUTTON(1);
        internal static readonly int DIJOFS_BUTTON2  = DIJOFS_BUTTON(2);
        internal static readonly int DIJOFS_BUTTON3  = DIJOFS_BUTTON(3);
        internal static readonly int DIJOFS_BUTTON4  = DIJOFS_BUTTON(4);
        internal static readonly int DIJOFS_BUTTON5  = DIJOFS_BUTTON(5);
        internal static readonly int DIJOFS_BUTTON6  = DIJOFS_BUTTON(6);
        internal static readonly int DIJOFS_BUTTON7  = DIJOFS_BUTTON(7);
        internal static readonly int DIJOFS_BUTTON8  = DIJOFS_BUTTON(8);
        internal static readonly int DIJOFS_BUTTON9  = DIJOFS_BUTTON(9);
        internal static readonly int DIJOFS_BUTTON10 = DIJOFS_BUTTON(10);
        internal static readonly int DIJOFS_BUTTON11 = DIJOFS_BUTTON(11);
        internal static readonly int DIJOFS_BUTTON12 = DIJOFS_BUTTON(12);
        internal static readonly int DIJOFS_BUTTON13 = DIJOFS_BUTTON(13);
        internal static readonly int DIJOFS_BUTTON14 = DIJOFS_BUTTON(14);
        internal static readonly int DIJOFS_BUTTON15 = DIJOFS_BUTTON(15);
        internal static readonly int DIJOFS_BUTTON16 = DIJOFS_BUTTON(16);
        internal static readonly int DIJOFS_BUTTON17 = DIJOFS_BUTTON(17);
        internal static readonly int DIJOFS_BUTTON18 = DIJOFS_BUTTON(18);
        internal static readonly int DIJOFS_BUTTON19 = DIJOFS_BUTTON(19);
        internal static readonly int DIJOFS_BUTTON20 = DIJOFS_BUTTON(20);
        internal static readonly int DIJOFS_BUTTON21 = DIJOFS_BUTTON(21);
        internal static readonly int DIJOFS_BUTTON22 = DIJOFS_BUTTON(22);
        internal static readonly int DIJOFS_BUTTON23 = DIJOFS_BUTTON(23);
        internal static readonly int DIJOFS_BUTTON24 = DIJOFS_BUTTON(24);
        internal static readonly int DIJOFS_BUTTON25 = DIJOFS_BUTTON(25);
        internal static readonly int DIJOFS_BUTTON26 = DIJOFS_BUTTON(26);
        internal static readonly int DIJOFS_BUTTON27 = DIJOFS_BUTTON(27);
        internal static readonly int DIJOFS_BUTTON28 = DIJOFS_BUTTON(28);
        internal static readonly int DIJOFS_BUTTON29 = DIJOFS_BUTTON(29);
        internal static readonly int DIJOFS_BUTTON30 = DIJOFS_BUTTON(30);
        internal static readonly int DIJOFS_BUTTON31 = DIJOFS_BUTTON(31);

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
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_XAxis),  DIJOFS_X, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_YAxis),  DIJOFS_Y, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_ZAxis),  DIJOFS_Z, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),

            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_RxAxis), DIJOFS_RX, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_RyAxis), DIJOFS_RY, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_RzAxis), DIJOFS_RZ, DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),

            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_Slider), DIJOFS_SLIDER(0), DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_Slider), DIJOFS_SLIDER(1), DIDFT.Axis|DIDFT.Optional|DIDFT.AnyInstance, DIDOI.AspectPosition),

            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_POV),    DIJOFS_POV(0), DIDFT.Pov|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_POV),    DIJOFS_POV(1), DIDFT.Pov|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_POV),    DIJOFS_POV(2), DIDFT.Pov|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT((Guid*)Unsafe.AsPointer(ref GUID_POV),    DIJOFS_POV(3), DIDFT.Pov|DIDFT.Optional|DIDFT.AnyInstance, 0),

            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(0), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(1), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(2), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(3), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(4), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(5), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(6), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(7), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(8), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(9), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(10), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(11), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(12), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(13), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(14), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(15), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(16), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(17), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(18), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(19), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(20), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(21), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(22), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(23), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(24), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(25), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(26), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(27), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(28), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(29), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(30), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
            new DIOBJECTDATAFORMAT(null,                                     DIJOFS_BUTTON(31), DIDFT.Button|DIDFT.Optional|DIDFT.AnyInstance, 0),
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

        internal struct DIPERIODIC
        {
            public uint dwMagnitude;
            public int lOffset;
            public uint dwPhase;
            public uint dwPeriod;
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

        [return: MarshalAs(UnmanagedType.Bool)]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal unsafe delegate bool DIEnumDeviceObjectsCallback(DIDEVICEOBJECTINSTANCE* lpddoi, IntPtr pvRef);

        internal unsafe struct IDirectInputDevice8
        {
            public struct _VTable
            {
                public IntPtr QueryInterface;
                public delegate* unmanaged<IntPtr, uint> AddRef;
                public delegate* unmanaged<IntPtr, uint> Release;

                public delegate* unmanaged<IDirectInputDevice8, DIDEVCAPS*, int> GetCapabilities;
                public delegate* unmanaged<IDirectInputDevice8, delegate* unmanaged<DIDEVICEOBJECTINSTANCE*, IntPtr, int>, IntPtr, DIDFT, int> EnumObjects;
                public delegate* unmanaged<IDirectInputDevice8, Guid*, DIPROPHEADER*, int> GetProperty;
                public delegate* unmanaged<IDirectInputDevice8, Guid*, DIPROPHEADER*, int> SetProperty;
                public delegate* unmanaged<IDirectInputDevice8, int> Acquire;
                public delegate* unmanaged<IDirectInputDevice8, int> Unacquire;
                public delegate* unmanaged<IDirectInputDevice8, uint, IntPtr, int> GetDeviceState;
                public delegate* unmanaged<IDirectInputDevice8, uint, DIDEVICEOBJECTDATA*, uint*, uint, int> GetDeviceData;
                public delegate* unmanaged<IDirectInputDevice8, DIDATAFORMAT*, int> SetDataFormat;
                public delegate* unmanaged<IDirectInputDevice8, IntPtr /* HANDLE */, int> SetEventNotification;
                public delegate* unmanaged<IDirectInputDevice8, IntPtr /* HWND */, DISCL, int> SetCooperativeLevel;
                public delegate* unmanaged<IDirectInputDevice8, DIDEVICEOBJECTINSTANCE*, uint, uint, int> GetObjectInfo;
                public delegate* unmanaged<IDirectInputDevice8, DIDEVICEINSTANCE*, int> GetDeviceInfo;
                public delegate* unmanaged<IDirectInputDevice8, IntPtr /* HWND */, uint, int> RunControlPanel;
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

            public uint Release()
            {
                return (*VTable)->Release(Handle);
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

            public void EnumObjects(delegate* unmanaged<DIDEVICEOBJECTINSTANCE*, IntPtr, int> callback, IntPtr pvRef, DIDFT flags)
            {
                int result = (*VTable)->EnumObjects(this, callback, pvRef, flags);
                CheckHResult(result);
            }

            public void EnumObjects(DIEnumDeviceObjectsCallback callback, IntPtr pvRef, DIDFT flags)
            {
                IntPtr callbackPtr = Marshal.GetFunctionPointerForDelegate(callback);
                int result = (*VTable)->EnumObjects(this, (delegate* unmanaged<DIDEVICEOBJECTINSTANCE*, IntPtr, int>)callbackPtr, pvRef, flags);
                GC.KeepAlive(callback);
                CheckHResult(result);
            }

            public void GetProperty(Guid* property, DIPROPHEADER* pdiph)
            {
                int result = (*VTable)->GetProperty(this, property, pdiph);
                CheckHResult(result);
            }

            public void SetProperty(Guid* property, DIPROPHEADER* pdiph)
            {
                int result = (*VTable)->SetProperty(this, property, pdiph);
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

            public int GetDeviceState(uint cbData, void* lpvData)
            {
                return (*VTable)->GetDeviceState(this, cbData, (nint)lpvData);
            }

            public unsafe void SetDataFormat(ref DIDATAFORMAT format)
            {
                int result = (*VTable)->SetDataFormat(this, (DIDATAFORMAT*)Unsafe.AsPointer(ref format));
                CheckHResult(result);
            }

            public void SetCooperativeLevel(IntPtr /* HWND */ hwnd, DISCL flags)
            {
                int result = (*VTable)->SetCooperativeLevel(this, hwnd, flags);
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

            public void Initialize(IntPtr hinst, uint dwVersion, ref Guid rguid)
            {
                int result = (*VTable)->Initialize(this, hinst, dwVersion, ref rguid);
                CheckHResult(result);
            }

            public int Poll()
            {
                return (*VTable)->Poll(this);
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
