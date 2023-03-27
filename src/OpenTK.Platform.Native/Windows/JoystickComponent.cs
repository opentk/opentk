using OpenTK.Core;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.Windows.DirectInput;

namespace OpenTK.Platform.Native.Windows
{
    public class JoystickComponent : IPalComponent
    {
        public string Name => "Win32JoystickComponent";

        public PalComponents Provides => PalComponents.Joystick;

        public ILogger? Logger { get; set; }

        private DirectInput.IDirectInput8 DirectInput8;

        private List<Joystick> Joysticks = new List<Joystick>();

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Joystick)
            {
                throw new PalException(this, "JoystickComponent can only initialize the Joystick component.");
            }

            // We don't need to call CoInitializeEx as the CLR already does that for all threads.
            Guid CLSID_DirectInput = DirectInput.CLSID_DirectInput;
            Guid IID_IDirectInputW = DirectInput.IID_IDirectInputW;
            CoCreateInstance(
                ref CLSID_DirectInput,
                IUnknown.Null,
                CLSCTX.INPROC_SERVER,
                ref IID_IDirectInputW,
                out IUnknown directInput8IUnk);

            DirectInput8 = (IDirectInput8)directInput8IUnk;

            DirectInput8.Initialize(WindowComponent.HInstance, 0x0800);

            unsafe int DeviceEnumCallback(DIDEVICEINSTANCE* lpddi, IntPtr pvRef)
            {
                string instanceName = Utils.FromTszString(lpddi->tszInstanceName, MAX_PATH);
                string productName = Utils.FromTszString(lpddi->tszProductName, MAX_PATH);

                Console.WriteLine($"Type: {lpddi->dwDevType & (DevType)0xFF}, Instance Name: {instanceName}, ProductName: {productName}, GUID Instance: {lpddi->guidInstance}, GUID Product: {lpddi->guidProduct}");

                DirectInput8.CreateDevice(lpddi->guidInstance, out IDirectInputDevice8 device, IUnknown.Null);

                device.Initialize(WindowComponent.HInstance, 0x0800, ref lpddi->guidInstance);

                device.GetCapabilities(out DIDEVCAPS capabilities);

                Console.WriteLine($"  Capabilities: Flags: {capabilities.dwFlags}, Axes: {capabilities.dwAxes}, Buttons: {capabilities.dwButtons}, POVs: {capabilities.dwPOVs}, FFSamplePeriod: {capabilities.dwFFSamplePeriod}, FFMinTimeResolution: {capabilities.dwFFMinTimeResolution}");

                Joysticks.Add(new Joystick(device, lpddi->guidInstance, instanceName));

                // Set the format to c_dfDIJoystick2, we can get the definition from here.
                // http://docs.ros.org/en/kinetic/api/librealsense2/html/win32__joystick_8c_source.html
                // https://github.com/elmindreda/c_dfDIJoystick2

                return 1;
            }

            unsafe
            {
                DirectInput8.EnumDevices(DevType.ClassGameCtrl, DeviceEnumCallback, IntPtr.Zero, DIEDFL.AttachedOnly);
            }
        }

        public JoystickHandle Open(int deviceIndex)
        {
            // FIXME: Reference count??
            return Joysticks[deviceIndex];
        }

        public void Close(JoystickHandle handle)
        {
            Joystick joystick = handle.As<Joystick>(this);
        }

        public unsafe string GetName(JoystickHandle handle)
        {
            Joystick joystick = handle.As<Joystick>(this);
            joystick.Device.GetDeviceInfo(out var info);
            return Utils.FromTszString(info.tszInstanceName, DirectInput.MAX_PATH);
        }

        public int GetNumberOfButtons(JoystickHandle handle)
        {
            Joystick joystick = handle.As<Joystick>(this);
            joystick.Device.GetCapabilities(out DIDEVCAPS capabilities);
            return (int)capabilities.dwButtons;
        }

        public int GetNumberOfAxes(JoystickHandle handle)
        {
            Joystick joystick = handle.As<Joystick>(this);
            joystick.Device.GetCapabilities(out DIDEVCAPS capabilities);
            return (int)capabilities.dwAxes;
        }

        public bool SupportsForceFeedback(JoystickHandle handle)
        {
            Joystick joystick = handle.As<Joystick>(this);
            joystick.Device.GetCapabilities(out DIDEVCAPS capabilities);
            return capabilities.dwFlags.HasFlag(DIDC.ForceFeedback);
        }

        public float GetAxis(JoystickHandle handle, int axisIndex)
        {
            Joystick joystick = handle.As<Joystick>(this);
        }
    }
}
