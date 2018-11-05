using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenToolkit.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with raw input.
        /// </summary>
        public static class RawInput
        {
            /// <summary>
            /// Calls the default raw input procedure to provide default processing for any raw input messages that
            /// an application does not process. This function ensures that every message is processed.
            /// <see cref="DefRawInputProc(Native.RawInput[], int, uint)"/> is called with the same parameters
            /// received by the window procedure.
            /// </summary>
            /// <param name="rawInputArrayOut">An array of <see cref="Native.RawInput"/> structures.</param>
            /// <param name="rawInputAmount">
            /// The number of <see cref="Native.RawInput"/>
            /// structures pointed to by <paramref name="rawInputArrayOut"/>.
            /// </param>
            /// <param name="headerSize">The size, in bytes, of the <see cref="RawInputHeader"/> structure.</param>
            /// <returns>
            /// If successful, the function returns <see cref="IntPtr.Zero"/>. Otherwise it returns an error value.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library)]
            public static extern IntPtr DefRawInputProc
            (
                [In] Native.RawInput[] rawInputArrayOut,
                [In] int rawInputAmount,
                [In] uint headerSize
            );

            /// <summary>
            /// Calls the default raw input procedure to provide default processing for any raw input messages that
            /// an application does not process. This function ensures that every message is processed.
            /// <see cref="DefRawInputProc(Native.RawInput[], int, uint)"/> is called with the same parameters
            /// received by the window procedure.
            /// </summary>
            /// <param name="rawInputArrayOut">
            /// A pointer to an array of <see cref="Native.RawInput"/> structures.
            /// </param>
            /// <param name="rawInputAmount">
            /// The number of <see cref="Native.RawInput"/>
            /// structures pointed to by <paramref name="rawInputArrayOut"/>.
            /// </param>
            /// <param name="headerSize">The size, in bytes, of the <see cref="RawInputHeader"/> structure.</param>
            /// <returns>
            /// If successful, the function returns <see cref="IntPtr.Zero"/>. Otherwise it returns an error value.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library)]
            public static unsafe extern IntPtr DefRawInputProc
            (
                [In] Native.RawInput* rawInputArrayOut,
                [In] int rawInputAmount,
                [In] uint headerSize
            );

            /// <summary>
            /// Registers the devices that supplies the raw input data.
            /// </summary>
            /// <param name="rawInputDevices">
            /// An array of <see cref="RawInputDevice"/> structures that
            /// represent the devices that supply the raw input.
            /// </param>
            /// <param name="deviceAmount">
            /// The number of <see cref="RawInputDevice"/> structures pointed to by <paramref name="rawInputDevices"/>.
            /// </param>
            /// <param name="size">The size, in bytes, of a <see cref="RawInputDevice"/> structure.</param>
            /// <returns>
            /// True if the function succeeds; otherwise, false.<para/>
            /// If the function fails, call <see cref="Marshal.GetLastWin32Error"/> for more information.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool RegisterRawInputDevices
            (
                [In] RawInputDevice[] rawInputDevices,
                [In] uint deviceAmount,
                [In] uint size
            );

            /// <summary>
            /// Retrieves the information about the raw input devices for the current application.
            /// </summary>
            /// <param name="rawInputDevicesOut">
            /// An array of <see cref="RawInputDevice"/> structures for the application.
            /// </param>
            /// <param name="deviceAmount">
            /// The number of <see cref="RawInputDevice"/> structures in <paramref name="rawInputDevicesOut"/>.
            /// </param>
            /// <param name="size">The size, in bytes, of a <see cref="RawInputDevice"/> structure.</param>
            /// <returns>
            /// If successful, the function returns a non-negative number that is
            /// the number of <see cref="RawInputDevice"/> structures written to the buffer.<para/>
            /// If the <paramref name="rawInputDevicesOut"/> buffer is too small or null, the function sets the last
            /// error as ERROR_INSUFFICIENT_BUFFER, returns -1, and sets <paramref name="deviceAmount"/> to the
            /// required number of devices. If the function fails for any other reason, it returns -1.<para/>
            /// For more details, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            public static extern uint GetRegisteredRawInputDevices
            (
                [Out] [Optional] RawInputDevice[] rawInputDevicesOut,
                [In] [Out] ref uint deviceAmount,
                [In] uint size
            );

            /// <summary>
            /// Performs a buffered read of the raw input data.
            /// </summary>
            /// <param name="data">
            /// A buffer of <see cref="RawInput"/> structures that contain the raw input data.
            /// If null, the minimum required buffer, in bytes, is returned in <paramref name="rawInputSize"/>.
            /// </param>
            /// <param name="rawInputSize">The size, in bytes, of a <see cref="RawInput"/> structure.</param>
            /// <param name="headerSize">The size, in bytes, of the <see cref="RawInputHeader"/> structure.</param>
            /// <returns>
            /// If <paramref name="data"/> is null and the function is successful, the return value is zero.
            /// If <paramref name="data"/> is not null and the function is successful, the return value is the
            /// number of <see cref="RawInput"/> structures written to <paramref name="data"/>.<para/>
            /// If an error occurs, the return value is -1.
            /// Call <see cref="Marshal.GetLastWin32Error"/> for the error code.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static extern uint GetRawInputBuffer
            (
                [Out] [Optional] Native.RawInput[] data,
                [In] [Out] ref uint rawInputSize,
                [In] uint headerSize
            );

            /// <summary>
            /// Performs a buffered read of the raw input data.
            /// </summary>
            /// <param name="data">
            /// A pointer to a buffer of <see cref="RawInput"/> structures that contain the raw input data.
            /// If null, the minimum required buffer, in bytes, is returned in <paramref name="rawInputSize"/>.
            /// </param>
            /// <param name="rawInputSize">The size, in bytes, of a <see cref="RawInput"/> structure.</param>
            /// <param name="headerSize">The size, in bytes, of the <see cref="RawInputHeader"/> structure.</param>
            /// <returns>
            /// If <paramref name="data"/> is null and the function is successful, the return value is zero.
            /// If <paramref name="data"/> is not null and the function is successful, the return value is the
            /// number of <see cref="RawInput"/> structures written to <paramref name="data"/>.<para/>
            /// If an error occurs, the return value is (uint)-1.
            /// Call <see cref="Marshal.GetLastWin32Error"/> for the error code.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static unsafe extern uint GetRawInputBuffer
            (
                [Out] [Optional] Native.RawInput* data,
                [In] [Out] ref uint rawInputSize,
                [In] uint headerSize
            );

            /// <summary>
            /// Enumerates the raw input devices attached to the system.
            /// </summary>
            /// <param name="deviceListArrayOut">
            /// An array of <see cref="RawInputDeviceList"/> structures for the devices attached to the system.
            /// If null, the number of devices are returned in <paramref name="deviceListAmount"/>.
            /// </param>
            /// <param name="deviceListAmount">
            /// If <paramref name="deviceListArrayOut"/> is null, the function populates this variable with
            /// the number of devices attached to the system; otherwise, this variable specifies the number of
            /// <see cref="RawInputDeviceList"/> structures that can be contained in the buffer to which
            /// <paramref name="deviceListArrayOut"/> points. If this value is less than the number of devices
            /// attached to the system, the function returns the actual number of devices in this variable
            /// and fails with ERROR_INSUFFICIENT_BUFFER.
            /// </param>
            /// <param name="deviceListSize">
            /// The size of a <see cref="RawInputDeviceList"/> structure, in bytes.
            /// </param>
            /// <returns>
            /// If the function is successful, the return value is the number of devices stored in the buffer
            /// pointed to by <paramref name="deviceListArrayOut"/>.<para/>
            /// On any other error, the function returns (uint)-1 and
            /// <see cref="Marshal.GetLastWin32Error"/> returns the error indication.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            public static extern uint GetRawInputDeviceList
            (
                [Out] [Optional] RawInputDeviceList[] deviceListArrayOut,
                [In] [Out] ref uint deviceListAmount,
                [In] uint deviceListSize
            );

            /// <summary>
            /// Enumerates the raw input devices attached to the system.
            /// </summary>
            /// <param name="deviceListArrayOut">
            /// A pointer to an array of <see cref="RawInputDeviceList"/> structures for the devices attached to the
            /// system. If null, the number of devices are returned in <paramref name="deviceListAmount"/>.
            /// </param>
            /// <param name="deviceListAmount">
            /// If <paramref name="deviceListArrayOut"/> is null, the function populates this variable with
            /// the number of devices attached to the system; otherwise, this variable specifies the number of
            /// <see cref="RawInputDeviceList"/> structures that can be contained in the buffer to which
            /// <paramref name="deviceListArrayOut"/> points. If this value is less than the number of devices
            /// attached to the system, the function returns the actual number of devices in this variable
            /// and fails with ERROR_INSUFFICIENT_BUFFER.
            /// </param>
            /// <param name="deviceListSize">
            /// The size of a <see cref="RawInputDeviceList"/> structure, in bytes.
            /// </param>
            /// <returns>
            /// If the function is successful, the return value is the number of devices stored in the buffer
            /// pointed to by <paramref name="deviceListArrayOut"/>.<para/>
            /// On any other error, the function returns (uint)-1 and
            /// <see cref="Marshal.GetLastWin32Error"/> returns the error indication.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            public static unsafe extern uint GetRawInputDeviceList
            (
                [Out] [Optional] RawInputDeviceList* deviceListArrayOut,
                [In] [Out] ref uint deviceListAmount,
                [In] uint deviceListSize
            );

            /// <summary>
            /// Retrieves information about the raw input device.
            /// </summary>
            /// <param name="device">
            /// A handle to the raw input device. This comes from the <see cref="RawInputHeader.Device"/> or
            /// from <see cref="GetRawInputDeviceList(RawInputDeviceList[], ref uint, uint)"/>.
            /// </param>
            /// <param name="command">Specifies what data will be returned in <paramref name="data"/>.</param>
            /// <param name="data">
            /// A buffer that contains the information specified by <paramref name="command"/>.
            /// If <paramref name="command"/> is <see cref="GetRawInputDeviceInfoEnum.DeviceInfo"/>, set the
            /// <see cref="RawInputDeviceInfo.Size"/> to <see cref="RawInputDeviceInfo.SizeInBytes"/> before calling
            /// <see cref="GetRawInputDeviceInfo(IntPtr, GetRawInputDeviceInfoEnum, IntPtr, ref uint)"/>.
            /// </param>
            /// <param name="dataSize">The size, in bytes, of the data in <paramref name="data"/>.</param>
            /// <returns>
            /// If successful, this function returns a non-negative number indicating the number
            /// of bytes copied to <paramref name="data"/>.<para/>
            /// If pData is not large enough for the data, the function returns -1. If <paramref name="data"/> is
            /// <see cref="IntPtr.Zero"/>, the function returns a value of zero. In both of these cases,
            /// <paramref name="dataSize"/> is set to the minimum size required for the <paramref name="data"/> buffer.
            /// <para/>
            /// Call <see cref="Marshal.GetLastWin32Error"/> to identify any other errors.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static extern uint GetRawInputDeviceInfo
            (
                [In] [Optional] IntPtr device,
                [In] GetRawInputDeviceInfoEnum command,
                [In] [Out] [Optional] byte[] data,
                [In] [Out] ref uint dataSize
            );

            /// <summary>
            /// Retrieves information about the raw input device.
            /// </summary>
            /// <param name="device">
            /// A handle to the raw input device. This comes from the <see cref="RawInputHeader.Device"/> or
            /// from <see cref="GetRawInputDeviceList(RawInputDeviceList[], ref uint, uint)"/>.
            /// </param>
            /// <param name="command">Specifies what data will be returned in <paramref name="data"/>.</param>
            /// <param name="data">
            /// A pointer to a buffer that contains the information specified by <paramref name="command"/>.
            /// If <paramref name="command"/> is <see cref="GetRawInputDeviceInfoEnum.DeviceInfo"/>, set the
            /// <see cref="RawInputDeviceInfo.Size"/> to <see cref="RawInputDeviceInfo.SizeInBytes"/> before calling
            /// <see cref="GetRawInputDeviceInfo(IntPtr, GetRawInputDeviceInfoEnum, IntPtr, ref uint)"/>.
            /// </param>
            /// <param name="dataSize">The size, in bytes, of the data in <paramref name="data"/>.</param>
            /// <returns>
            /// If successful, this function returns a non-negative number indicating the number
            /// of bytes copied to <paramref name="data"/>.<para/>
            /// If pData is not large enough for the data, the function returns -1. If <paramref name="data"/> is
            /// <see cref="IntPtr.Zero"/>, the function returns a value of zero. In both of these cases,
            /// <paramref name="dataSize"/> is set to the minimum size required for the <paramref name="data"/> buffer.
            /// <para/>
            /// Call <see cref="Marshal.GetLastWin32Error"/> to identify any other errors.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static unsafe extern uint GetRawInputDeviceInfo
            (
                [In] [Optional] IntPtr device,
                [In] GetRawInputDeviceInfoEnum command,
                [In] [Out] [Optional] IntPtr data,
                [In] [Out] ref uint dataSize
            );

            /// <summary>
            /// Retrieves information about the raw input device.
            /// </summary>
            /// <param name="device">
            /// A handle to the raw input device. This comes from <see cref="RawInputHeader.Device"/> or from
            /// <see cref="GetRawInputDeviceList(RawInputDeviceList[], ref uint, uint)"/>.
            /// </param>
            /// <param name="command">Specifies what data will be returned in <paramref name="data"/>.</param>
            /// <param name="data">
            /// A pointer to a buffer that contains the information specified by <paramref name="command"/>. If
            /// <paramref name="command"/> is <see cref="GetRawInputDeviceInfoEnum.DeviceInfo"/>, set the
            /// <see cref="RawInputDeviceInfo.Size"/> to <see cref="RawInputDeviceInfo.SizeInBytes"/>
            /// before calling this.
            /// </param>
            /// <param name="size">The size, in bytes, of the data in <paramref name="data"/>.</param>
            /// <returns>
            /// If successful, this function returns a non-negative number
            /// indicating the number of bytes copied to <paramref name="data"/>.<para/>
            /// If <paramref name="data"/> is not large enough for the data, the function returns -1. If
            /// <paramref name="data"/> is null, the function returns a value of zero. In both of these cases,
            /// <paramref name="size"/> is set to the minimum size required for the <paramref name="data"/> buffer.
            /// <para/>
            /// Call <see cref="Marshal.GetLastWin32Error"/> to identify any other errors.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static extern uint GetRawInputDeviceInfo
            (
                [In] [Optional] IntPtr device,
                [In] GetRawInputDeviceInfoEnum command,
                [In] [Out] [Optional] ref RawInputDeviceInfo data,
                [In] [Out] ref uint size
            );

            /// <summary>
            /// Retrieves the raw input header from the specified device.
            /// </summary>
            /// <param name="rawInput">
            /// A handle to the <see cref="Native.RawInput"/> structure. This comes from the lParam in
            /// <see cref="WindowMessage.Input"/>.
            /// </param>
            /// <param name="header">The <see cref="RawInputHeader"/> structure to receive the raw data.</param>
            /// <returns>
            /// If the function is successful, the return value is the number of bytes copied into
            /// <paramref name="header"/>.<para/>
            /// If there is an error, the return value is (uint)-1 [== <see cref="uint.MaxValue"/>].
            /// </returns>
            public static unsafe uint GetRawInputData(IntPtr rawInput, out RawInputHeader header)
            {
                uint size = RawInputHeader.SizeInBytes;
                fixed (RawInputHeader* headerPtr = &header)
                {
                    return GetRawInputData
                    (
                        rawInput,
                        GetRawInputDataCommand.Header,
                        (IntPtr)headerPtr,
                        ref size,
                        RawInputHeader.SizeInBytes
                    );
                }
            }

            /// <summary>
            /// Retrieves raw input data from the specified device.
            /// </summary>
            /// <param name="rawInput">
            /// A handle to the <see cref="Native.RawInput"/> structure. This comes from the lParam in
            /// <see cref="WindowMessage.Input"/>.
            /// </param>
            /// <param name="data">The <see cref="Native.RawInput"/> structure to receive the raw data.</param>
            /// <returns>
            /// If the function is successful, the return value is the number of bytes copied into
            /// <paramref name="data"/>.<para/>
            /// If there is an error, the return value is (uint)-1 [== <see cref="uint.MaxValue"/>].
            /// </returns>
            public static unsafe uint GetRawInputData(IntPtr rawInput, out Native.RawInput data)
            {
                uint size = Native.RawInput.SizeInBytes;
                fixed (Native.RawInput* dataPtr = &data)
                {
                    return GetRawInputData
                    (
                        rawInput,
                        GetRawInputDataCommand.Input,
                        (IntPtr)dataPtr,
                        ref size,
                        RawInputHeader.SizeInBytes
                    );
                }
            }

            /// <summary>
            /// Retrieves the raw input from the specified device.<para/>
            /// Consider using one of the other overloads for a better experience.
            /// </summary>
            /// <param name="rawInput">
            /// A handle to the <see cref="Native.RawInput"/> structure. This comes from the lParam in
            /// <see cref="WindowMessage.Input"/>.
            /// </param>
            /// <param name="command">The command flag.</param>
            /// <param name="data">
            /// A pointer to the data that comes from the <see cref="Native.RawInput"/> structure. This depends on the
            /// value of <paramref name="command"/>. If <paramref name="data"/> is <see cref="IntPtr.Zero"/>,
            /// the required size of the buffer is returned in <paramref name="size"/>.
            /// </param>
            /// <param name="size">The size, in bytes, of the data in <paramref name="data"/>.</param>
            /// <param name="headerSize">The size, in bytes, of the <see cref="RawInputHeader"/> structure.</param>
            /// <returns>
            /// If <paramref name="data"/> is <see cref="IntPtr.Zero"/> and the function is successful, the return
            /// value is 0. If <paramref name="data"/> is not <see cref="IntPtr.Zero"/> and the function is successful,
            /// the return value is the number of bytes copied into <paramref name="data"/>.<para/>
            /// If there is an error, the return value is (uint)-1 [== <see cref="uint.MaxValue"/>].
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static extern uint GetRawInputData
            (
                [In] IntPtr rawInput,
                [In] GetRawInputDataCommand command,
                [Out] [Optional] IntPtr data,
                [In] [Out] ref uint size,
                [In] uint headerSize
            );
        }
    }
}
