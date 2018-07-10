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

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool RegisterRawInputDevices
            (
                [In] RawInputDevice[] pRawInputDevices,
                [In] uint uiNumDevices,
                [In] uint cbSize
            );

            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetRegisteredRawInputDevices
            (
                [Out] [Optional] Native.RawInput[] pRawInputDevices,
                [In] [Out] ref uint puiNumDevices,
                [In] uint cbSize
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
            public static extern int GetRawInputBuffer
            (
                [Out] [Optional] IntPtr pData,
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
