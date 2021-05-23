//
// ConstCharPtrMarshaler.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Audio.OpenAL.Native
{
    internal class ConstCharPtrMarshaler : ICustomMarshaler
    {
        private static readonly ConstCharPtrMarshaler Instance = new ConstCharPtrMarshaler();

        public void CleanUpManagedData(object ManagedObj)
        {
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
        }

        public int GetNativeDataSize()
        {
            return IntPtr.Size;
        }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            switch (ManagedObj)
            {
                case string str:
                    return Marshal.StringToHGlobalAnsi(str);
                default:
                    throw new ArgumentException($"{nameof(ConstCharPtrMarshaler)} only supports marshaling of strings. Got '{ManagedObj.GetType()}'");
            }
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            return Marshal.PtrToStringAnsi(pNativeData);
        }

        // See https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.custommarshalers.typetotypeinfomarshaler.getinstance
#pragma warning disable IDE0060 // Remove unused parameter
        public static ICustomMarshaler GetInstance(string cookie) => Instance;
#pragma warning restore IDE0060 // Remove unused parameter
    }
}
