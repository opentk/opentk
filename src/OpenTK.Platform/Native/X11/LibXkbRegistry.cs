using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    public static unsafe class LibXkbRegistry
    {
        static LibXkbRegistry()
        {
            DllResolver.InitLoader();
        }

        const string XkbRegistry = "XkbRegistry";

        [DllImport(XkbRegistry, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* rxkb_context* */ rxkb_context_new(rxkb_context_flags flags);

        [DllImport(XkbRegistry, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool rxkb_context_parse_default_ruleset(IntPtr /* rxkb_context* */ ctx);

        [DllImport(XkbRegistry, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* rxkb_context* */ rxkb_context_unref(IntPtr /* rxkb_context* */ ctx);

        [DllImport(XkbRegistry, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* rxkb_layout* */ rxkb_layout_first(IntPtr /* rxkb_context* */ ctx);

        [DllImport(XkbRegistry, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* rxkb_layout* */ rxkb_layout_next(IntPtr /* rxkb_layout* */ l);

        [DllImport(XkbRegistry, CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte* /* const char* */ rxkb_layout_get_name(IntPtr /* rxkb_layout* */ l);

        [DllImport(XkbRegistry, CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte* /* const char* */ rxkb_layout_get_variant(IntPtr /* rxkb_layout* */ l);

        [DllImport(XkbRegistry, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* rxkb_iso639_code* */ rxkb_layout_get_iso639_first(IntPtr /* rxkb_layout* */ layout);

        [DllImport(XkbRegistry, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* rxkb_iso639_code* */ rxkb_iso639_code_next(IntPtr /* rxkb_iso639_code* */ iso639);

        [DllImport(XkbRegistry, CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte* /* char* */ rxkb_iso639_code_get_code(IntPtr /* rxkb_iso639_code* */ iso639);

    }

    internal enum rxkb_popularity : int {
        RXKB_POPULARITY_STANDARD = 1 ,
        RXKB_POPULARITY_EXOTIC
    }
    internal enum rxkb_context_flags : int {
        NoFlags = 0,
        NoDefaultIncludes = 1 << 0,
        LoadExoticRules = 1 << 1,
        NoSecureGetenv = 1 << 2,
    }

    internal enum rxkb_log_level : int {
        Critical = 10,
        Error = 20,
        Warning = 30,
        Info = 40,
        Debug = 50,
    }
}

