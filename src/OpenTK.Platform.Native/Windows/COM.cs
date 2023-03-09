using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
    internal static unsafe class COM
    {
        // FIXME??
        internal struct IUnknown
        {
        }

        [DllImport("ole32.dll")]
        internal static extern int /* HRESULT */ CoCreateInstance(
            in Guid /* CLSID */ rclsid,
            IntPtr pUnkOuter,
            CLSCTX dwClsContext,
            in Guid /* IID */ riid,
            out void* ppv
        );

        [DllImport("ole32.dll", CallingConvention = CallingConvention.ThisCall)]
        internal static extern int /* HRESULT */ CoCreateInstance(
            in Guid /* CLSID */ rclsid,
            IntPtr pUnkOuter,
            CLSCTX dwClsContext,
            in Guid /* IID */ riid,
            out ITfThreadMgr ppv
        );

        internal struct ITfThreadMgrVtbl
        {
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, Guid /* REFIID */, void**, int /* HRESULT */> QueryInterface;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, uint> AddRef;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, uint> Release;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, int* /* TfClientId* */, int /* HRESULT */> Activate;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, int /* HRESULT */> Deactivate;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, int /* HRESULT */> CreateDocumentMgr;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, IntPtr /* IEnumTfDocumentMgrs** */, int /* HRESULT */> EnumDocumentMgrs;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, IntPtr /* ITfDocumentMgr** */, int /* HRESULT */> GetFocus;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, IntPtr /* ITfDocumentMgr* */, int /* HRESULT */> SetFocus;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, IntPtr /* HWND */, IntPtr /* ITfDocumentMgr* */, IntPtr /* ITfDocumentMgr** */, int /* HRESULT */> AssociateFocus;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, int* /* BOOL* */, int /* HRESULT */> IsThreadFocus;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, Guid /* REFCLSID */, IntPtr /* ITfFunctionProvider** */, int /* HRESULT */> GetFunctionProvider;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, IntPtr /* IEnumTfFunctionProviders** */, int /* HRESULT */> EnumFunctionProviders;
            public delegate* unmanaged[Cdecl]<ITfThreadMgr*, IntPtr /* ITfCompartmentMgr** */, int /* HRESULT */> GetGlobalCompartment;
        }

        internal struct ITfThreadMgr
        {
            ITfThreadMgrVtbl *lpVtbl;
        };

    }
}
