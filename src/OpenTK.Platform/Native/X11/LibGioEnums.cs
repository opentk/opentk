using System;

namespace OpenTK.Platform.Native
{

    internal enum GBusType
    {
        G_BUS_TYPE_STARTER = -1,
        G_BUS_TYPE_NONE = 0,
        G_BUS_TYPE_SYSTEM  = 1,
        G_BUS_TYPE_SESSION = 2
    }

    internal enum GDBusProxyFlags
    {
        G_DBUS_PROXY_FLAGS_NONE = 0,
        G_DBUS_PROXY_FLAGS_DO_NOT_LOAD_PROPERTIES = (1<<0),
        G_DBUS_PROXY_FLAGS_DO_NOT_CONNECT_SIGNALS = (1<<1),
        G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START = (1<<2),
        G_DBUS_PROXY_FLAGS_GET_INVALIDATED_PROPERTIES = (1<<3),
        G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START_AT_CONSTRUCTION = (1<<4),
        // GIO_AVAILABLE_ENUMERATOR_IN_2_72
        G_DBUS_PROXY_FLAGS_NO_MATCH_RULE = (1<<5)
    }

     enum GDBusCallFlags
     {
        G_DBUS_CALL_FLAGS_NONE = 0,
        G_DBUS_CALL_FLAGS_NO_AUTO_START = (1<<0),
        G_DBUS_CALL_FLAGS_ALLOW_INTERACTIVE_AUTHORIZATION = (1<<1)
    }

    internal enum GDBusError
    {
        /* Well-known errors in the org.freedesktop.DBus.Error namespace */
        G_DBUS_ERROR_FAILED,                           /* org.freedesktop.DBus.Error.Failed */
        G_DBUS_ERROR_NO_MEMORY,                        /* org.freedesktop.DBus.Error.NoMemory */
        G_DBUS_ERROR_SERVICE_UNKNOWN,                  /* org.freedesktop.DBus.Error.ServiceUnknown */
        G_DBUS_ERROR_NAME_HAS_NO_OWNER,                /* org.freedesktop.DBus.Error.NameHasNoOwner */
        G_DBUS_ERROR_NO_REPLY,                         /* org.freedesktop.DBus.Error.NoReply */
        G_DBUS_ERROR_IO_ERROR,                         /* org.freedesktop.DBus.Error.IOError */
        G_DBUS_ERROR_BAD_ADDRESS,                      /* org.freedesktop.DBus.Error.BadAddress */
        G_DBUS_ERROR_NOT_SUPPORTED,                    /* org.freedesktop.DBus.Error.NotSupported */
        G_DBUS_ERROR_LIMITS_EXCEEDED,                  /* org.freedesktop.DBus.Error.LimitsExceeded */
        G_DBUS_ERROR_ACCESS_DENIED,                    /* org.freedesktop.DBus.Error.AccessDenied */
        G_DBUS_ERROR_AUTH_FAILED,                      /* org.freedesktop.DBus.Error.AuthFailed */
        G_DBUS_ERROR_NO_SERVER,                        /* org.freedesktop.DBus.Error.NoServer */
        G_DBUS_ERROR_TIMEOUT,                          /* org.freedesktop.DBus.Error.Timeout */
        G_DBUS_ERROR_NO_NETWORK,                       /* org.freedesktop.DBus.Error.NoNetwork */
        G_DBUS_ERROR_ADDRESS_IN_USE,                   /* org.freedesktop.DBus.Error.AddressInUse */
        G_DBUS_ERROR_DISCONNECTED,                     /* org.freedesktop.DBus.Error.Disconnected */
        G_DBUS_ERROR_INVALID_ARGS,                     /* org.freedesktop.DBus.Error.InvalidArgs */
        G_DBUS_ERROR_FILE_NOT_FOUND,                   /* org.freedesktop.DBus.Error.FileNotFound */
        G_DBUS_ERROR_FILE_EXISTS,                      /* org.freedesktop.DBus.Error.FileExists */
        G_DBUS_ERROR_UNKNOWN_METHOD,                   /* org.freedesktop.DBus.Error.UnknownMethod */
        G_DBUS_ERROR_TIMED_OUT,                        /* org.freedesktop.DBus.Error.TimedOut */
        G_DBUS_ERROR_MATCH_RULE_NOT_FOUND,             /* org.freedesktop.DBus.Error.MatchRuleNotFound */
        G_DBUS_ERROR_MATCH_RULE_INVALID,               /* org.freedesktop.DBus.Error.MatchRuleInvalid */
        G_DBUS_ERROR_SPAWN_EXEC_FAILED,                /* org.freedesktop.DBus.Error.Spawn.ExecFailed */
        G_DBUS_ERROR_SPAWN_FORK_FAILED,                /* org.freedesktop.DBus.Error.Spawn.ForkFailed */
        G_DBUS_ERROR_SPAWN_CHILD_EXITED,               /* org.freedesktop.DBus.Error.Spawn.ChildExited */
        G_DBUS_ERROR_SPAWN_CHILD_SIGNALED,             /* org.freedesktop.DBus.Error.Spawn.ChildSignaled */
        G_DBUS_ERROR_SPAWN_FAILED,                     /* org.freedesktop.DBus.Error.Spawn.Failed */
        G_DBUS_ERROR_SPAWN_SETUP_FAILED,               /* org.freedesktop.DBus.Error.Spawn.FailedToSetup */
        G_DBUS_ERROR_SPAWN_CONFIG_INVALID,             /* org.freedesktop.DBus.Error.Spawn.ConfigInvalid */
        G_DBUS_ERROR_SPAWN_SERVICE_INVALID,            /* org.freedesktop.DBus.Error.Spawn.ServiceNotValid */
        G_DBUS_ERROR_SPAWN_SERVICE_NOT_FOUND,          /* org.freedesktop.DBus.Error.Spawn.ServiceNotFound */
        G_DBUS_ERROR_SPAWN_PERMISSIONS_INVALID,        /* org.freedesktop.DBus.Error.Spawn.PermissionsInvalid */
        G_DBUS_ERROR_SPAWN_FILE_INVALID,               /* org.freedesktop.DBus.Error.Spawn.FileInvalid */
        G_DBUS_ERROR_SPAWN_NO_MEMORY,                  /* org.freedesktop.DBus.Error.Spawn.NoMemory */
        G_DBUS_ERROR_UNIX_PROCESS_ID_UNKNOWN,          /* org.freedesktop.DBus.Error.UnixProcessIdUnknown */
        G_DBUS_ERROR_INVALID_SIGNATURE,                /* org.freedesktop.DBus.Error.InvalidSignature */
        G_DBUS_ERROR_INVALID_FILE_CONTENT,             /* org.freedesktop.DBus.Error.InvalidFileContent */
        G_DBUS_ERROR_SELINUX_SECURITY_CONTEXT_UNKNOWN, /* org.freedesktop.DBus.Error.SELinuxSecurityContextUnknown */
        G_DBUS_ERROR_ADT_AUDIT_DATA_UNKNOWN,           /* org.freedesktop.DBus.Error.AdtAuditDataUnknown */
        G_DBUS_ERROR_OBJECT_PATH_IN_USE,               /* org.freedesktop.DBus.Error.ObjectPathInUse */
        G_DBUS_ERROR_UNKNOWN_OBJECT,                   /* org.freedesktop.DBus.Error.UnknownObject */
        G_DBUS_ERROR_UNKNOWN_INTERFACE,                /* org.freedesktop.DBus.Error.UnknownInterface */
        G_DBUS_ERROR_UNKNOWN_PROPERTY,                 /* org.freedesktop.DBus.Error.UnknownProperty */
        G_DBUS_ERROR_PROPERTY_READ_ONLY                /* org.freedesktop.DBus.Error.PropertyReadOnly */
    }

    internal enum GConnectFlags
    {
        // GOBJECT_AVAILABLE_ENUMERATOR_IN_2_74
        G_CONNECT_DEFAULT  = 0,
        G_CONNECT_AFTER	= 1 << 0,
        G_CONNECT_SWAPPED	= 1 << 1
    }
}
