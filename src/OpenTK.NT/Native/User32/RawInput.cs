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
            [DllImport("user32.dll")]
            public static extern LRESULT DefRawInputProc
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
            [DllImport("user32.dll")]
            public static unsafe extern LRESULT DefRawInputProc
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
            [DllImport("user32.dll", SetLastError = true)]
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
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRegisteredRawInputDevices
            (
                [Out] [Optional] Native.RawInput[] rawInputDevicesOut,
                [In] [Out] ref uint deviceAmount,
                [In] uint size
            );

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
            public static unsafe extern int GetRawInputBuffer
            (
                [Out] [Optional] Native.RawInput* pData,
                [In] [Out] ref uint pcbSize,
                [In] uint cbSizeHeader
            );

            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputDeviceList
            (
                [Out] [Optional] RawInputDeviceList[] pRawInputDeviceList,
                [In] [Out] ref uint puiNumDevices,
                [In] uint cbSize
            );

            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputDeviceList
            (
                [Out] [Optional] IntPtr pRawInputDeviceList,
                [In] [Out] ref uint puiNumDevices,
                [In] uint cbSize
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern int GetRawInputDeviceInfo
            (
                [In] [Optional] HANDLE hDevice,
                [In] GetRawInputDeviceInfoEnum uiCommand,
                [In] [Out] [Optional] byte[] pData,
                [In] [Out] ref uint pcbSize
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern int GetRawInputDeviceInfo
            (
                [In] [Optional] HANDLE hDevice,
                [In] GetRawInputDeviceInfoEnum uiCommand,
                [In] [Out] [Optional] LPVOID pData,
                [In] [Out] ref uint pcbSize
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputDeviceInfo
            (
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
                        uint dataSize = GetRawInputData
                        (
                            raw,
                            GetRawInputDataCommand.Header,
                            (IntPtr)pheader,
                            ref size,
                            RawInputHeader.SizeInBytes
                        );

                        if (dataSize != RawInputHeader.SizeInBytes)
                        {
                            System.Diagnostics.Debug.Print
                            (
                                $"[Error] Failed to retrieve raw input header. Error: {Marshal.GetLastWin32Error()}"
                            );
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
                        GetRawInputData
                        (
                            raw,
                            GetRawInputDataCommand.Input,
                            (LPVOID)pdata,
                            ref size,
                            RawInputHeader.SizeInBytes
                        );
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
                        GetRawInputData
                        (
                            raw,
                            GetRawInputDataCommand.Input,
                            (IntPtr)pdata,
                            ref size,
                            RawInputHeader.SizeInBytes
                        );
                    }
                }

                return size;
            }

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputData
            (
                [In] HRAWINPUT hRawInput,
                [In] GetRawInputDataCommand uiCommand,
                [Out] [Optional] LPVOID pData,
                [In] [Out] ref uint pcbSize,
                [In] uint cbSizeHeader
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRawInputData
            (
                [In] HRAWINPUT hRawInput,
                [In] GetRawInputDataCommand uiCommand,
                [Out] [Optional] out Native.RawInput pData,
                [In] [Out] ref uint pcbSize,
                [In] uint cbSizeHeader
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern unsafe int GetRawInputData
            (
                HRAWINPUT rawInput,
                GetRawInputDataCommand command,
                Native.RawInput* data,
                [In] [Out] ref int size,
                int sizeHeader
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
