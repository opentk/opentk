using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native
{
    internal static class LibGio
    {
        // FIXME: All of these imports are not from GIO, some are from Glib
        // but because these symbols live in the same shared object file
        // this still works.
        // - Noggin_bops 2024-07-22
        private const string Gio = "Gio";


        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern byte* /* const gchar* */ glib_check_version(uint required_major, uint required_minor, uint required_micro);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* GMainContext* */ g_main_context_default();

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* GMainLoop* */ g_main_loop_new(IntPtr /* GMainContext* */ context, int /* gboolean */ is_running);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void g_main_loop_quit(IntPtr /* GMainLoop* */ loop);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void g_main_loop_unref(IntPtr /* GMainLoop* */ loop);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* gboolean */ g_main_context_iteration(IntPtr /* GMainContext* */ context, int /* gboolean */ may_block); 
 
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
        internal static unsafe extern IntPtr /* GVariant* */ g_variant_new(byte* /* const gchar* */ format_string, /* ... */ byte* str1);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GVariant* */ g_variant_new(byte* /* const gchar* */ format_string, /* ... */ byte* str1, byte* str2);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GVariant* */ g_variant_new(byte* /* const gchar* */ format_string, /* ... */ int x, int y, int h, int w);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GVariant* */ g_variant_new(byte* /* const gchar* */ format_string, /* ... */ uint v0);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GVariant* */ g_variant_new(byte* /* const gchar* */ format_string, /* ... */ uint v0, uint v1, uint v2);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GVariant* */ g_variant_ref(IntPtr /* GVariant* */ value);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void g_variant_unref(IntPtr /* GVariant* */ value);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void g_variant_get(IntPtr /* GVariant* */ value, byte* /* const gchar* */ format_string, /* ... */ out IntPtr /* GVariant* */ var1);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void g_variant_get(IntPtr /* GVariant* */ value, byte* /* const gchar* */ format_string, /* ... */ out IntPtr /* GVariant* */ var1, out IntPtr /* GVariant* */ var2);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void g_variant_get(IntPtr /* GVariant* */ value, byte* /* const gchar* */ format_string, /* ... */ out IntPtr /* GVariant* */ var1, out IntPtr /* GVariant* */ var2, out IntPtr /* GVariant* */ var3);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint g_variant_get_uint32(IntPtr /* GVariant* */ value);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* gboolean */ g_variant_get_boolean(IntPtr /* GVariant* */ value);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* const GVariantType* */ g_variant_get_type(IntPtr /* GVariant* */ value);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* const gchar* */ g_variant_type_peek_string(IntPtr /* const GVariantType* */ type);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern nuint g_variant_type_get_string_length(IntPtr /* const GVariantType* */ type);

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
                                delegate* unmanaged<IntPtr, byte*, IntPtr, void> /* GCallback */ c_handler,
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

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void g_signal_handler_disconnect(IntPtr /* GObject* */ instance, ulong /* gulong */ handler_id);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GPowerProfileMonitor* */ g_power_profile_monitor_dup_default();

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern int /* gboolean */ g_power_profile_monitor_get_power_saver_enabled(IntPtr /* GPowerProfileMonitor* */ monitor);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void g_object_unref(IntPtr /* GObject* */ @object);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GSettings* */ g_settings_new(byte* /* const gchar* */ schema_id);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GSettings* */ g_settings_new_full(IntPtr /* GSettingsSchema* */ schema, IntPtr /* GSettingsBackend* */ backend, byte* /* const gchar* */ path);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern int g_settings_get_int(IntPtr /* GSettings* */ settings, byte* /* const gchar* */ key);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern double g_settings_get_double(IntPtr /* GSettings* */ settings, byte* /* const gchar* */ key);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern byte** g_settings_schema_list_keys(IntPtr /* GSettingsSchema* */ settings);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern byte* /* const gchar* */ g_settings_schema_get_path(IntPtr /* GSettingsSchema* */ schema);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* GSettingsSchemaSource* */ g_settings_schema_source_get_default();

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GSettingsSchema* */ g_settings_schema_source_lookup(IntPtr /* GSettingsSchemaSource* */ source, byte* /* const gchar* */ schema_id, int /* gboolean */ recursive);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void g_strfreev(byte** /* gchar** */ str_array);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void g_object_get_property(IntPtr /* GObject* */ @object, byte* /* const gchar* */ property_name, GValue* value);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void g_object_get(IntPtr /* GObject* */ @object, byte* /* const gchar* */ first_property_name, out IntPtr value, byte* @null);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr /* GObject* */ g_value_get_object(GValue* /* const GValue* */ value);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern IntPtr g_value_get_pointer(GValue* /* const GValue* */ value);


        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static extern nint /* GType */ g_value_get_gtype(ref readonly GValue /* const GValue* */ value);

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern byte* /* gchar* */ g_strdup_value_contents(ref readonly GValue /* const GValue* */ value);
        
        

        [DllImport(Gio, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern byte* /* const gchar* */ g_type_name(nint /* GType */ type);
    }
}
