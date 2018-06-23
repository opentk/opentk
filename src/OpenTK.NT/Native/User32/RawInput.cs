using System;
using System.Runtime.InteropServices;
using System.Security;

using HANDLE = System.IntPtr;
using HRAWINPUT = System.IntPtr;
using LPVOID = System.IntPtr;
using LRESULT = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class RawInput
        {
            /// <summary>
            /// calls the default raw input procedure to provide default processing for
            /// any raw input messages that an application does not process.
            /// This function ensures that every message is processed.
            /// DefRawInputProc is called with the same parameters received by the window procedure.
            /// </summary>
            /// <param name="hRawInput">Pointer to an array of RawInput structures.</param>
            /// <param name="nInput">Number of RawInput structures pointed to by paRawInput.</param>
            /// <param name="cbSizeHeader">Size, in bytes, of the RawInputHeader structure.</param>
            /// <returns>If successful, the function returns S_OK. Otherwise it returns an error value.</returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll")]
            public static extern LRESULT DefRawInputProc
            (
                [In] Native.RawInput[] paRawInput,
                [In] int nInput,
                [In] uint cbSizeHeader
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll")]
            public static extern LRESULT DefRawInputProc
            (
                [In] IntPtr paRawInput,
                [In] int nInput,
                [In] uint cbSizeHeader
            );

            /// <summary>
            /// Registers the devices that supply the raw input data.
            /// </summary>
            /// <param name="pRawInputDevices">
            /// Pointer to an array of RawInputDevice structures that represent the devices that supply the raw input.
            /// </param>
            /// <param name="puiNumDevices">
            /// Number of RawInputDevice structures pointed to by RawInputDevices.
            /// </param>
            /// <param name="cbSize">
            /// Size, in bytes, of a RAWINPUTDEVICE structure.
            /// </param>
            /// <returns>
            /// TRUE if the function succeeds; otherwise, FALSE. If the function fails, call GetLastError for more information.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool RegisterRawInputDevices
            (
                [In] RawInputDevice[] pRawInputDevices,
                [In] uint uiNumDevices,
                [In] uint cbSize
            );

            /// <summary>
            /// Gets the information about the raw input devices for the current application.
            /// </summary>
            /// <param name="pRawInputDevices">
            /// Pointer to an array of RawInputDevice structures for the application.
            /// </param>
            /// <param name="puiNumDevices">
            /// Number of RawInputDevice structures in RawInputDevices.
            /// </param>
            /// <param name="cbSize">
            /// Size, in bytes, of a RawInputDevice structure.
            /// </param>
            /// <returns>
            ///  <para>
            /// If successful, the function returns a non-negative number that is
            /// the number of RawInputDevice structures written to the buffer.
            ///  </para>
            ///  <para>
            /// If the pRawInputDevices buffer is too small or NULL, the function sets
            /// the last error as ERROR_INSUFFICIENT_BUFFER, returns -1,
            /// and sets NumDevices to the required number of devices.
            ///  </para>
            ///  <para>
            /// If the function fails for any other reason, it returns -1. For more details, call GetLastError.
            ///  </para>
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRegisteredRawInputDevices
            (
                [Out] [Optional] Native.RawInput[] pRawInputDevices,
                [In] [Out] ref uint puiNumDevices,
                [In] uint cbSize
            );

            /// <summary>
            /// Does a buffered read of the raw input data.
            /// </summary>
            /// <param name="pData">
            /// Pointer to a buffer of RawInput structures that contain the raw input data.
            /// If NULL, the minimum required buffer, in bytes, is returned in Size.
            /// </param>
            /// <param name="pcbSize">Pointer to a variable that specifies the size, in bytes, of a RawInput structure.</param>
            /// <param name="cbSizeHeader">Size, in bytes, of RawInputHeader.</param>
            /// <returns>
            /// If Data is NULL and the function is successful, the return value is zero.
            /// If Data is not NULL and the function is successful, the return value is the number
            /// of RawInput structures written to Data.
            /// If an error occurs, the return value is (UINT)-1. Call GetLastError for the error code.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputBuffer
            (
                [Out] [Optional] Native.RawInput[] pData,
                [In] [Out] ref uint pcbSize,
                [In] uint cbSizeHeader
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern int GetRawInputBuffer
            (
                [Out] [Optional] IntPtr pData,
                [In] [Out] ref uint pcbSize,
                [In] uint cbSizeHeader
            );

            

            /// <summary>
            /// Enumerates the raw input devices attached to the system.
            /// </summary>
            /// <param name="pRawInputDeviceList">
            /// ointer to buffer that holds an array of RawInputDeviceList structures
            /// for the devices attached to the system.
            /// If NULL, the number of devices are returned in NumDevices.
            /// </param>
            /// <param name="puiNumDevices">
            /// Pointer to a variable. If RawInputDeviceList is NULL, it specifies the number
            /// of devices attached to the system. Otherwise, it contains the size, in bytes,
            /// of the preallocated buffer pointed to by pRawInputDeviceList.
            /// However, if NumDevices is smaller than needed to contain RawInputDeviceList structures,
            /// the required buffer size is returned here.
            /// </param>
            /// <param name="cbSize">
            /// Size of a RawInputDeviceList structure.
            /// </param>
            /// <returns>
            /// If the function is successful, the return value is the number of devices stored in the buffer
            /// pointed to by RawInputDeviceList.
            /// If RawInputDeviceList is NULL, the return value is zero.
            /// If NumDevices is smaller than needed to contain all the RawInputDeviceList structures,
            /// the return value is (UINT) -1 and the required buffer is returned in NumDevices.
            /// Calling GetLastError returns ERROR_INSUFFICIENT_BUFFER.
            /// On any other error, the function returns (UINT) -1 and GetLastError returns the error indication.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputDeviceList(
                [Out] [Optional] RawInputDeviceList[] pRawInputDeviceList,
                [In] [Out] ref uint puiNumDevices,
                [In] uint cbSize
            );

            /// <summary>
            /// Enumerates the raw input devices attached to the system.
            /// </summary>
            /// <param name="pRawInputDeviceList">
            /// ointer to buffer that holds an array of RawInputDeviceList structures
            /// for the devices attached to the system.
            /// If NULL, the number of devices are returned in NumDevices.
            /// </param>
            /// <param name="puiNumDevices">
            /// Pointer to a variable. If RawInputDeviceList is NULL, it specifies the number
            /// of devices attached to the system. Otherwise, it contains the size, in bytes,
            /// of the preallocated buffer pointed to by pRawInputDeviceList.
            /// However, if NumDevices is smaller than needed to contain RawInputDeviceList structures,
            /// the required buffer size is returned here.
            /// </param>
            /// <param name="cbSize">
            /// Size of a RawInputDeviceList structure.
            /// </param>
            /// <returns>
            /// If the function is successful, the return value is the number of devices stored in the buffer
            /// pointed to by RawInputDeviceList.
            /// If RawInputDeviceList is NULL, the return value is zero.
            /// If NumDevices is smaller than needed to contain all the RawInputDeviceList structures,
            /// the return value is (UINT) -1 and the required buffer is returned in NumDevices.
            /// Calling GetLastError returns ERROR_INSUFFICIENT_BUFFER.
            /// On any other error, the function returns (UINT) -1 and GetLastError returns the error indication.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputDeviceList(
                [Out] [Optional] IntPtr pRawInputDeviceList,
                [In] [Out] ref uint puiNumDevices,
                [In] uint cbSize
            );

            /// <summary>
            /// Gets information about the raw input device.
            /// </summary>
            /// <param name="hDevice">
            /// Handle to the raw input device. This comes from the lParam of the WM_INPUT message,
            /// from RawInputHeader.Device, or from GetRawInputDeviceList.
            /// It can also be NULL if an application inserts input data, for example, by using SendInput.
            /// </param>
            /// <param name="uiCommand">
            /// Specifies what data will be returned in pData. It can be one of the following values.
            /// RawInputDeviceInfoEnum.PREPARSEDDATA
            /// Data points to the previously parsed data.
            /// RawInputDeviceInfoEnum.DEVICENAME
            /// Data points to a string that contains the device name.
            /// For this Command only, the value in Size is the character count (not the byte count).
            /// RawInputDeviceInfoEnum.DEVICEINFO
            /// Data points to an RawInputDeviceInfo structure.
            /// </param>
            /// <param name="pData">
            /// ointer to a buffer that contains the information specified by Command.
            /// If Command is RawInputDeviceInfoEnum.DEVICEINFO, set RawInputDeviceInfo.Size to sizeof(RawInputDeviceInfo)
            /// before calling GetRawInputDeviceInfo. (This is done automatically in OpenTK)
            /// </param>
            /// <param name="pcbSize">
            /// Pointer to a variable that contains the size, in bytes, of the data in Data.
            /// </param>
            /// <returns>
            ///  <para>If successful, this function returns a non-negative number indicating the number of bytes copied to Data.</para>
            ///  <para>
            /// If Data is not large enough for the data, the function returns -1. If Data is NULL, the function returns a
            /// value of zero. In both of these cases, Size is set to the minimum size required for the Data buffer.
            ///  </para>
            ///  <para>Call GetLastError to identify any other errors.</para>
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern int GetRawInputDeviceInfo(
                [In] [Optional] HANDLE hDevice,
                [In] GetRawInputDeviceInfoEnum uiCommand,
                [In] [Out] [Optional] byte[] pData,
                [In] [Out] ref uint pcbSize
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern int GetRawInputDeviceInfo(
                [In] [Optional] HANDLE hDevice,
                [In] GetRawInputDeviceInfoEnum uiCommand,
                [In] [Out] [Optional] LPVOID pData,
                [In] [Out] ref uint pcbSize
            );

            /// <summary>
            /// Gets information about the raw input device.
            /// </summary>
            /// <param name="hDevice">
            /// Handle to the raw input device. This comes from the lParam of the WM_INPUT message,
            /// from RawInputHeader.Device, or from GetRawInputDeviceList.
            /// It can also be NULL if an application inserts input data, for example, by using SendInput.
            /// </param>
            /// <param name="uiCommand">
            /// Specifies what data will be returned in pData. It can be one of the following values.
            /// RawInputDeviceInfoEnum.PREPARSEDDATA
            /// Data points to the previously parsed data.
            /// RawInputDeviceInfoEnum.DEVICENAME
            /// Data points to a string that contains the device name.
            /// For this Command only, the value in Size is the character count (not the byte count).
            /// RawInputDeviceInfoEnum.DEVICEINFO
            /// Data points to an RawInputDeviceInfo structure.
            /// </param>
            /// <param name="pData">
            /// ointer to a buffer that contains the information specified by Command.
            /// If Command is RawInputDeviceInfoEnum.DEVICEINFO, set RawInputDeviceInfo.Size to sizeof(RawInputDeviceInfo)
            /// before calling GetRawInputDeviceInfo. (This is done automatically in OpenTK)
            /// </param>
            /// <param name="pcbSize">
            /// Pointer to a variable that contains the size, in bytes, of the data in Data.
            /// </param>
            /// <returns>
            ///  <para>If successful, this function returns a non-negative number indicating the number of bytes copied to Data.</para>
            ///  <para>
            /// If Data is not large enough for the data, the function returns -1. If Data is NULL, the function returns a
            /// value of zero. In both of these cases, Size is set to the minimum size required for the Data buffer.
            ///  </para>
            ///  <para>Call GetLastError to identify any other errors.</para>
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputDeviceInfo(
                [In] [Optional] HANDLE hDevice,
                [In] GetRawInputDeviceInfoEnum uiCommand,
                [In] [Out] [Optional] RawInputDeviceInfo pData,
                [In] [Out] ref uint pcbSize
            );

            public static uint GetRawInputData(IntPtr raw, out RawInputHeader header)
            {
                var size = RawInputHeader.SizeInBytes;
                unsafe
                {
                    fixed (RawInputHeader* pheader = &header)
                    {
                        if (GetRawInputData(raw, GetRawInputDataCommand.Header,
                                (IntPtr)pheader, ref size, RawInputHeader.SizeInBytes) != RawInputHeader.SizeInBytes)
                        {
                            System.Diagnostics.Debug.Print("[Error] Failed to retrieve raw input header. Error: {0}",
                                Marshal.GetLastWin32Error());
                        }
                    }
                }

                return size;
            }

            public static uint GetRawInputData(IntPtr raw, out Native.RawInput data)
            {
                var size = Native.RawInput.SizeInBytes;
                unsafe
                {
                    fixed (Native.RawInput* pdata = &data)
                    {
                        GetRawInputData(raw, GetRawInputDataCommand.Input,
                            (LPVOID)pdata, ref size, RawInputHeader.SizeInBytes);
                    }
                }

                return size;
            }

            public static uint GetRawInputData(IntPtr raw, byte[] data)
            {
                var size = (uint)data.Length;
                unsafe
                {
                    fixed (byte* pdata = data)
                    {
                        GetRawInputData(raw, GetRawInputDataCommand.Input,
                            (IntPtr)pdata, ref size, RawInputHeader.SizeInBytes);
                    }
                }

                return size;
            }

            /// <summary>
            /// Gets the raw input from the specified device.
            /// </summary>
            /// <param name="hRawInput">Handle to the RawInput structure. This comes from the lParam in WM_INPUT.</param>
            /// <param name="uiCommand">
            /// Command flag. This parameter can be one of the following values.
            /// RawInputDateEnum.INPUT
            /// Get the raw data from the RawInput structure.
            /// RawInputDateEnum.HEADER
            /// Get the header information from the RawInput structure.
            /// </param>
            /// <param name="pData">
            /// Pointer to the data that comes from the RawInput structure. This depends on the value of uiCommand.
            /// If Data is NULL, the required size of the buffer is returned in Size.
            /// </param>
            /// <param name="pcbSize">Pointer to a variable that specifies the size, in bytes, of the data in Data.</param>
            /// <param name="cbSizeHeader">Size, in bytes, of RawInputHeader.</param>
            /// <returns>
            ///  <para>
            /// If Data is NULL and the function is successful, the return value is 0. If Data is not NULL and the function
            /// is successful, the return value is the number of bytes copied into Data.
            ///  </para>
            ///  <para>If there is an error, the return value is (UINT)-1.</para>
            /// </returns>
            /// <remarks>
            /// GetRawInputData gets the raw input one RawInput structure at a time. In contrast, GetRawInputBuffer gets an array
            /// of RawInput structures.
            /// </remarks>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputData(
                [In] HRAWINPUT hRawInput,
                [In] GetRawInputDataCommand uiCommand,
                [Out] [Optional] LPVOID pData,
                [In] [Out] ref uint pcbSize,
                [In] uint cbSizeHeader
            );

            /// <summary>
            /// Gets the raw input from the specified device.
            /// </summary>
            /// <param name="hRawInput">Handle to the RawInput structure. This comes from the lParam in WM_INPUT.</param>
            /// <param name="uiCommand">
            /// Command flag. This parameter can be one of the following values.
            /// RawInputDateEnum.INPUT
            /// Get the raw data from the RawInput structure.
            /// RawInputDateEnum.HEADER
            /// Get the header information from the RawInput structure.
            /// </param>
            /// <param name="pData">
            /// Pointer to the data that comes from the RawInput structure. This depends on the value of uiCommand.
            /// If Data is NULL, the required size of the buffer is returned in Size.
            /// </param>
            /// <param name="pcbSize">Pointer to a variable that specifies the size, in bytes, of the data in Data.</param>
            /// <param name="cbSizeHeader">Size, in bytes, of RawInputHeader.</param>
            /// <returns>
            ///  <para>
            /// If Data is NULL and the function is successful, the return value is 0. If Data is not NULL and the function
            /// is successful, the return value is the number of bytes copied into Data.
            ///  </para>
            ///  <para>If there is an error, the return value is (UINT)-1.</para>
            /// </returns>
            /// <remarks>
            /// GetRawInputData gets the raw input one RawInput structure at a time. In contrast, GetRawInputBuffer gets an array
            /// of RawInput structures.
            /// </remarks>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputData(
                [In] HRAWINPUT hRawInput,
                [In] GetRawInputDataCommand uiCommand,
                [Out] [Optional] out Native.RawInput pData,
                [In] [Out] ref uint pcbSize,
                [In] uint cbSizeHeader
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern unsafe int GetRawInputData(
                HRAWINPUT RawInput,
                GetRawInputDataCommand Command,
                Native.RawInput* Data,
                [In] [Out] ref int Size,
                int SizeHeader
            );

            public static IntPtr NextRawInputStructure(IntPtr data)
            {
                unsafe
                {
                    return RawInputAlign((IntPtr)((byte*)data + RawInputHeader.SizeInBytes));
                }
            }

            private static IntPtr RawInputAlign(IntPtr data)
            {
                unsafe
                {
                    return (IntPtr)((byte*)data + ((IntPtr.Size - 1) & ~(IntPtr.Size - 1)));
                }
            }
        }
    }
}
