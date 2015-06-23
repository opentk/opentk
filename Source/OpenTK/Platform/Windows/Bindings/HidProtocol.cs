#region License
//
// HidProtocol.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using OpenTK.Platform.Common;

namespace OpenTK.Platform.Windows
{
    class HidProtocol
    {
        const string lib = "hid.dll";

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetButtonCaps")]
        public static extern HidProtocolStatus GetButtonCaps(HidProtocolReportType hidProtocolReportType,
            IntPtr button_caps, ref ushort p, [In] byte[] preparsed_data);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetButtonCaps")]
        public static extern HidProtocolStatus GetButtonCaps(HidProtocolReportType hidProtocolReportType,
            [Out] HidProtocolButtonCaps[] button_caps, ref ushort p, [In] byte[] preparsed_data);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetCaps")]
        public static extern HidProtocolStatus GetCaps([In] byte[] preparsed_data, ref HidProtocolCaps capabilities);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetData")]
        public static extern HidProtocolStatus GetData(HidProtocolReportType type,
            IntPtr data, ref int data_length,
            [In] byte[] preparsed_data, IntPtr report, int report_length);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetData")]
        public static extern HidProtocolStatus GetData(HidProtocolReportType type,
            [Out] HidProtocolData[] data, ref int data_length,
            [In] byte[] preparsed_data, IntPtr report, int report_length);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetLinkCollectionNodes")]
        public static extern HidProtocolStatus GetLinkCollectionNodes(
            [Out] HidProtocolLinkCollectionNode[] LinkCollectionNodes,
            ref int LinkCollectionNodesLength,
            [In] byte[] PreparsedData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetScaledUsageValue")]
        static public extern HidProtocolStatus GetScaledUsageValue(HidProtocolReportType type,
            HIDPage usage_page, short link_collection, short usage, ref int usage_value,
            [In] byte[] preparsed_data, IntPtr report, int report_length);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetSpecificButtonCaps")]
        public static extern HidProtocolStatus GetSpecificButtonCaps(HidProtocolReportType ReportType,
            HIDPage UsagePage, ushort LinkCollection, ushort Usage,
            [Out] HidProtocolButtonCaps[] ButtonCaps, ref ushort ButtonCapsLength,
            [In] byte[] PreparsedData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetUsages")]
        unsafe public static extern HidProtocolStatus GetUsages(HidProtocolReportType type,
            HIDPage usage_page, short link_collection, short* usage_list, ref int usage_length,
            [In] byte[] preparsed_data, IntPtr report, int report_length);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetUsageValue")]
        public static extern HidProtocolStatus GetUsageValue(HidProtocolReportType type,
            HIDPage usage_page, short link_collection, short usage, ref uint usage_value,
            [In] byte[] preparsed_data, IntPtr report, int report_length);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetValueCaps")]
        public static extern HidProtocolStatus GetValueCaps(HidProtocolReportType type,
            IntPtr caps, ref ushort caps_length, [In] byte[] preparsed_data);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_GetValueCaps")]
        public static extern HidProtocolStatus GetValueCaps(HidProtocolReportType type,
            [Out] HidProtocolValueCaps[] caps, ref ushort caps_length, [In] byte[] preparsed_data);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, SetLastError = true, EntryPoint = "HidP_MaxDataListLength")]
        public static extern int MaxDataListLength(HidProtocolReportType type, [In] byte[] preparsed_data);
    }

    enum HidProtocolCollectionType : byte
    {

    }

    enum HidProtocolReportType : ushort
    {
        Input,
        Output,
        Feature
    }

    enum HidProtocolStatus : uint
    {
        Success = 0x00110000,
        Null = 0x80110001,
        InvalidPreparsedData = 0xc0110001,
        InvalidReportType = 0xc0110002,
        InvalidReportLength = 0xc0110003,
        UsageNotFound = 0xc0110004,
        ValueOutOfRange = 0xc0110005,
        BadLogPhyValues = 0xc0110006,
        BufferTooSmall = 0xc0110007,
        InternallError = 0xc0110008,
        I8042TransNotKnown = 0xc0110009,
        IncompatibleReportId = 0xc011000a,
        NotValueArray = 0xc011000b,
        IsValueArray = 0xc011000c,
        DataIndexNotFound = 0xc011000d,
        DataIndexOutOfRange = 0xc011000e,
        ButtonNotPressed = 0xc011000f,
        ReportDoesNotExist = 0xc0110010,
        NotImplemented = 0xc0110020,
    }

    [StructLayout(LayoutKind.Explicit)]
    struct HidProtocolButtonCaps
    {
        [FieldOffset(0)] public HIDPage UsagePage;
        [FieldOffset(2)] public byte ReportID;
        [FieldOffset(3), MarshalAs(UnmanagedType.U1)] public bool IsAlias;
        [FieldOffset(4)] public short BitField;
        [FieldOffset(6)] public short LinkCollection;
        [FieldOffset(8)] public short LinkUsage;
        [FieldOffset(10)] public short LinkUsagePage;
        [FieldOffset(12), MarshalAs(UnmanagedType.U1)] public bool IsRange;
        [FieldOffset(13), MarshalAs(UnmanagedType.U1)] public bool IsStringRange;
        [FieldOffset(14), MarshalAs(UnmanagedType.U1)] public bool IsDesignatorRange;
        [FieldOffset(15), MarshalAs(UnmanagedType.U1)] public bool IsAbsolute;
        //[FieldOffset(16)] unsafe fixed int Reserved[10]; // no need when LayoutKind.Explicit
        [FieldOffset(56)] public HidProtocolRange Range;
        [FieldOffset(56)] public HidProtocolNotRange NotRange;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct HidProtocolCaps
    {
        public short Usage;
        public short UsagePage;
        public ushort InputReportByteLength;
        public ushort OutputReportByteLength;
        public ushort FeatureReportByteLength;
        unsafe fixed ushort Reserved[17];
        public ushort NumberLinkCollectionNodes;
        public ushort NumberInputButtonCaps;
        public ushort NumberInputValueCaps;
        public ushort NumberInputDataIndices;
        public ushort NumberOutputButtonCaps;
        public ushort NumberOutputValueCaps;
        public ushort NumberOutputDataIndices;
        public ushort NumberFeatureButtonCaps;
        public ushort NumberFeatureValueCaps;
        public ushort NumberFeatureDataIndices;
    }

    [StructLayout(LayoutKind.Explicit)]
    struct HidProtocolData
    {
        [FieldOffset(0)] public short DataIndex;
        //[FieldOffset(2)] public short Reserved;
        [FieldOffset(4)] public int RawValue;
        [FieldOffset(4), MarshalAs(UnmanagedType.U1)] public bool On;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct HidProtocolNotRange
    {
        #pragma warning disable 169 // private field is never used
        public short Usage;
        short Reserved1;
        public short StringIndex;
        short Reserved2;
        public short DesignatorIndex;
        short Reserved3;
        public short DataIndex;
        short Reserved4;
        #pragma warning restore 169
    }

    [StructLayout(LayoutKind.Sequential)]
    struct HidProtocolLinkCollectionNode
    {
        public ushort LinkUsage;
        public HIDPage LinkUsagePage;
        public ushort Parent;
        public ushort NumberOfChildren;
        public ushort NextSibling;
        public ushort FirstChild;
        int bitfield;
        public IntPtr   UserContext;

        public HidProtocolCollectionType CollectionType
        {
            get
            {
                return (HidProtocolCollectionType)(bitfield & 0xff);
            }
        }

        public bool IsAlias
        {
            get
            {
                return (bitfield & 0x100) == 1;
            }
        }
    }

    struct HidProtocolRange
    {
#pragma warning disable 0649
        public short UsageMin;
        public short UsageMax;
        public short StringMin;
        public short StringMax;
        public short DesignatorMin;
        public short DesignatorMax;
        public short DataIndexMin;
        public short DataIndexMax;
#pragma warning restore 0649
    }

    [StructLayout(LayoutKind.Explicit)]
    struct HidProtocolValueCaps
    {
        #pragma warning disable 169 // private field is never used
        [FieldOffset(0)] public HIDPage UsagePage;
        [FieldOffset(2)] public byte ReportID;
        [FieldOffset(3), MarshalAs(UnmanagedType.U1)] public bool IsAlias;
        [FieldOffset(4)] public ushort BitField;
        [FieldOffset(6)] public short LinkCollection;
        [FieldOffset(8)] public ushort LinkUsage;
        [FieldOffset(10)] public ushort LinkUsagePage;
        [FieldOffset(12), MarshalAs(UnmanagedType.U1)] public bool IsRange;
        [FieldOffset(13), MarshalAs(UnmanagedType.U1)] public bool IsStringRange;
        [FieldOffset(14), MarshalAs(UnmanagedType.U1)] public bool IsDesignatorRange;
        [FieldOffset(15), MarshalAs(UnmanagedType.U1)] public bool IsAbsolute;
        [FieldOffset(16), MarshalAs(UnmanagedType.U1)] public bool HasNull;
        [FieldOffset(17)] byte Reserved;
        [FieldOffset(18)] public short BitSize;
        [FieldOffset(20)] public short ReportCount;
        //[FieldOffset(22)] ushort Reserved2a;
        //[FieldOffset(24)] ushort Reserved2b;
        //[FieldOffset(26)] ushort Reserved2c;
        //[FieldOffset(28)] ushort Reserved2d;
        //[FieldOffset(30)] ushort Reserved2e;
        [FieldOffset(32)] public int UnitsExp;
        [FieldOffset(36)] public int Units;
        [FieldOffset(40)] public int LogicalMin;
        [FieldOffset(44)] public int LogicalMax;
        [FieldOffset(48)] public int PhysicalMin;
        [FieldOffset(52)] public int PhysicalMax;
        [FieldOffset(56)] public HidProtocolRange Range;
        [FieldOffset(56)] public HidProtocolNotRange NotRange;
        #pragma warning restore 169
    }
}
