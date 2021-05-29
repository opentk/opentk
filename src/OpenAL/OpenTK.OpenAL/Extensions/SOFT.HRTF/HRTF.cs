using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Audio.OpenAL.Native;

namespace OpenTK.Audio.OpenAL.Extensions.SOFT.HRTF
{
    public class HRTF : ALCBase
    {
        /// <summary>
        /// The name of this AL extension.
        /// </summary>
        public const string ExtensionName = "ALC_SOFT_HRTF";

        static HRTF()
        {
            // We need to register the resolver for OpenAL before we can DllImport functions.
            ALBase.RegisterOpenALResolver();
        }

        private HRTF()
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

        private static ALDevice _Device;

        /// <summary>
        /// The device from which to get the functions in this extension.
        /// </summary>
        public static ALDevice Device
        {
            get => _Device;
            set
            {
                _Device = value;

                // Here we need to reload all of the delegates unfortunately
                // This is error prone, but there is not really any other solution that
                // offers reasonable ease of use for the end user.
                _GetStringSOFTPtr = LoadDelegate<GetStringSOFTPtrDelegate>(_Device, "alcGetStringiSOFT");
                _ResetDeviceSOFTPtr = LoadDelegate<ResetDeviceSOFTPtrDelegate>(_Device, "alcResetDeviceSOFT");
                _ResetDeviceSOFTRef = LoadDelegate<ResetDeviceSOFTRefDelegate>(_Device, "alcResetDeviceSOFT");
                _ResetDeviceSOFTArray = LoadDelegate<ResetDeviceSOFTArrayDelegate>(_Device, "alcResetDeviceSOFT");
            }
        }

#pragma warning disable SA1516 // Elements should be separated by blank line
        public static unsafe string GetStringSOFT(ALDevice device, HRTFAttribute param, int index) => _GetStringSOFTPtr(device, param, index);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        private unsafe delegate string GetStringSOFTPtrDelegate(ALDevice device, HRTFAttribute param, int index);
        private static GetStringSOFTPtrDelegate _GetStringSOFTPtr = LoadDelegate<GetStringSOFTPtrDelegate>(_Device, "alcGetStringiSOFT");

        public static unsafe bool ResetDeviceSOFT(ALDevice device, int* attrList) => _ResetDeviceSOFTPtr(device, attrList);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate bool ResetDeviceSOFTPtrDelegate(ALDevice device, int* attrList);
        private static ResetDeviceSOFTPtrDelegate _ResetDeviceSOFTPtr = LoadDelegate<ResetDeviceSOFTPtrDelegate>(_Device, "alcResetDeviceSOFT");

        public static bool ResetDeviceSOFT(ALDevice device, ref int attrList) => _ResetDeviceSOFTRef(device, ref attrList);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate bool ResetDeviceSOFTRefDelegate(ALDevice device, ref int attrList);
        private static ResetDeviceSOFTRefDelegate _ResetDeviceSOFTRef = LoadDelegate<ResetDeviceSOFTRefDelegate>(_Device, "alcResetDeviceSOFT");

        public static bool ResetDeviceSOFT(ALDevice device, int[] attrList) => _ResetDeviceSOFTArray(device, attrList);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate bool ResetDeviceSOFTArrayDelegate(ALDevice device, int[] attrList);
        private static ResetDeviceSOFTArrayDelegate _ResetDeviceSOFTArray = LoadDelegate<ResetDeviceSOFTArrayDelegate>(_Device, "alcResetDeviceSOFT");
#pragma warning restore SA1516 // Elements should be separated by blank line

        /// <summary>
        /// Convenience function for adding HRTF related attributes to <see cref="ALContextAttributes"/>.
        /// </summary>
        /// <param name="attrList">The attribute list to add the attribute to.</param>
        /// <param name="value">The value of the HRTF attribute, either False, True, or DontCare.</param>
        public static void AddHRTFAttribute(ALContextAttributes attrList, HRTFAttributeValue value)
        {
            attrList.AddAttribute((int)HRTFAttribute.HRTF, (int)value);
        }

        public static bool ResetDeviceSOFT(ALDevice device, ALContextAttributes attributeList)
        {
            return ResetDeviceSOFT(device, attributeList.CreateAttributeArray());
        }

        /// <summary>
        /// Gets the HRTF status of this device.
        /// This is equivalent to calling:
        /// <code>ALC.GetInteger(device, HRTFInteger.HRTFStatusSOFT, out int status)</code>
        /// </summary>
        /// <param name="device">The device to query.</param>
        /// <returns>The HRTF status.</returns>
        public static HRTFStatus GetHRTFStatus(ALDevice device)
        {
            ALC.GetInteger(device, (AlcGetInteger)HRTFInteger.StatusSOFT, out int istatus);
            return (HRTFStatus)istatus;
        }

        /// <summary>
        /// Gets HRTF related integers. The same as calling <see cref="ALC.GetInteger(ALCaptureDevice, AlcGetInteger, int, out int)"/> with the approprite arguments.
        /// </summary>
        /// <param name="device">The device to query.</param>
        /// <param name="param">The property to query.</param>
        /// <param name="value">The value of the queried property.</param>
        public static void GetInteger(ALDevice device, HRTFInteger param, out int value)
        {
            ALC.GetInteger(device, (AlcGetInteger)param, out value);
        }
    }
}
