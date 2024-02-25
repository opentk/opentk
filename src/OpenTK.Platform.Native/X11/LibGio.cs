using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native
{
    internal static class LibGio
    {
        private const string Gio = "Gio";

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GDBusProxy* */ g_dbus_proxy_new_for_bus_sync(
                                GBusType bus_type,
                                GDBusProxyFlags flags,
                                IntPtr /* GDBusInterfaceInfo* */ info,
                                byte* /* const gchar* */ name,
                                byte* /* const gchar* */ object_path,
                                byte* /* const gchar* */ interface_name,
                                IntPtr /* GCancellable* */ cancellable,
                                GError** error);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GVariant* */ g_dbus_proxy_call_sync(
                                IntPtr /* GDBusProxy * */ proxy,
                                byte* /* const gchar * */ method_name,
                                IntPtr /* GVariant* */ parameters,
                                GDBusCallFlags flags,
                                int /* gint */ timeout_msec,
                                IntPtr /* GCancellable* */ cancellable,
                                GError **error);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GVariant* */ g_variant_new(byte* /* const gchar* */ format_string, /* ... */ byte* str1, byte* str2);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void g_variant_get(IntPtr /* GVariant* */ value, byte* /* const gchar* */ format_string, /* ... */ out IntPtr /* GVariant* */ var1);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint g_variant_get_uint32(IntPtr /* GVariant* */ value);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void g_clear_error(GError **err);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint /* GQuark */ g_dbus_error_quark();

        internal static unsafe ulong g_signal_connect(
                                IntPtr /* gpointer */ instance,
                                byte* /* const gchar* */ detailed_signal,
                                delegate* unmanaged<IntPtr, byte*, byte*, IntPtr, IntPtr, void> /* GCallback */ c_handler,
                                IntPtr /* gpoiner */ data)
        {
            return g_signal_connect_data(instance, detailed_signal, (IntPtr)c_handler, data, IntPtr.Zero, 0);
        }

        internal static unsafe ulong g_signal_connect(
                                IntPtr /* gpointer */ instance,
                                byte* /* const gchar* */ detailed_signal,
                                IntPtr /* GCallback */ c_handler,
                                IntPtr /* gpoiner */ data)
        {
            return g_signal_connect_data(instance, detailed_signal, c_handler, data, IntPtr.Zero, 0);
        }

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern ulong /* gulong */ g_signal_connect_data(
                                IntPtr /* gpointer */ instance,
                                byte* /* const gchar* */ detailed_signal,
                                IntPtr /* GCallback */ c_handler,
                                IntPtr /* gpoiner */ data,
                                IntPtr /* GClosureNotify */ destroy_data,
                                GConnectFlags connect_flags);
    }
}