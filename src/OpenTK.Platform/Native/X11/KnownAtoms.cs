using System;

namespace OpenTK.Platform.Native.X11
{
    internal enum KnownAtoms
    {
        #region Common Property Types
        ATOM,
        CARDINAL,
        STRING,
        UTF8_STRING,
        WINDOW,
        AnyPropertyType,
        #endregion

        #region ICCCM
        WM_TAKE_FOCUS,
        [Obsolete]
        WM_SAVE_YOURSELF,
        WM_DELETE_WINDOW,
        WM_STATE,
        WM_CHANGE_STATE,
        WM_NAME,
        WM_NORMAL_HINTS,
        WM_TRANSIENT_FOR,

        PRIMARY,
        SECONDARY,
        CLIPBOARD,
        INCR,
        TARGETS,
        MULTIPLE,
        #endregion

        #region Freedesktop Atoms
        _NET_SUPPORTED,
        _NET_CLIENT_LIST,
        _NET_NUMBER_OF_DESKTOPS,
        _NET_DESKTOP_GEOMETRY,
        _NET_DESKTOP_VIEWPORT,
        _NET_CURRENT_DESKTOP,
        _NET_DESKTOP_NAMES,
        _NET_ACTIVE_WINDOW,
        _NET_WORKAREA,
        _NET_SUPPORTING_WM_CHECK,
        _NET_VIRTUAL_ROOTS,
        _NET_DESKTOP_LAYOUT,
        _NET_SHOWING_DESKTOP,
        _NET_CLOSE_WINDOW,
        _NET_MOVERESIZE_WINDOW,
        _NET_WM_MOVERESIZE,
        _NET_RESTACK_WINDOW,
        _NET_REQUEST_FRAME_EXTENTS,
        _NET_WM_NAME,
        _NET_WM_VISIBLE_NAME,
        _NET_WM_ICON_NAME,
        _NET_WM_VISIBLE_ICON_NAME,
        _NET_WM_DESKTOP,
        _NET_WM_WINDOW_TYPE,
        _NET_WM_WINDOW_TYPE_DESKTOP,
        _NET_WM_WINDOW_TYPE_DOCK,
        _NET_WM_WINDOW_TYPE_TOOLBAR,
        _NET_WM_WINDOW_TYPE_MENU,
        _NET_WM_WINDOW_TYPE_UTILITY,
        _NET_WM_WINDOW_TYPE_SPLASH,
        _NET_WM_WINDOW_TYPE_DIALOG,
        _NET_WM_WINDOW_TYPE_DROPDOWN_MENU,
        _NET_WM_WINDOW_TYPE_POPUP_MENU,
        _NET_WM_WINDOW_TYPE_TOOLTIP,
        _NET_WM_WINDOW_TYPE_NOTIFICATION,
        _NET_WM_WINDOW_TYPE_COMBO,
        _NET_WM_WINDOW_TYPE_DND,
        _NET_WM_WINDOW_TYPE_NORMAL,
        _NET_WM_STATE,
        _NET_WM_STATE_MODAL,
        _NET_WM_STATE_STICKY,
        _NET_WM_STATE_MAXIMIZED_VERT,
        _NET_WM_STATE_MAXIMIZED_HORZ,
        _NET_WM_STATE_SHADED,
        _NET_WM_STATE_SKIP_TASKBAR,
        _NET_WM_STATE_SKIP_PAGER,
        _NET_WM_STATE_HIDDEN,
        _NET_WM_STATE_FULLSCREEN,
        _NET_WM_STATE_ABOVE,
        _NET_WM_STATE_BELOW,
        _NET_WM_STATE_DEMANDS_ATTENTION,
        _NET_WM_STATE_FOCUSED,
        _NET_WM_ALLOWED_ACTIONS,
        _NET_WM_ACTION_MOVE,
        _NET_WM_ACTION_RESIZE,
        _NET_WM_ACTION_MINIMIZE,
        _NET_WM_ACTION_SHADE,
        _NET_WM_ACTION_STICK,
        _NET_WM_ACTION_MAXIMIZE_HORZ,
        _NET_WM_ACTION_MAXIMIZE_VERT,
        _NET_WM_ACTION_FULLSCREEN,
        _NET_WM_ACTION_CHANGE_DESKTOP,
        _NET_WM_ACTION_CLOSE,
        _NET_WM_ACTION_ABOVE,
        _NET_WM_ACTION_BELOW,
        _NET_WM_STRUT,
        _NET_WM_STRUT_PARTIAL,
        _NET_WM_ICON_GEOMETRY,
        _NET_WM_ICON,
        _NET_WM_PID,
        _NET_WM_HANDLED_ICONS,
        _NET_WM_USER_TIME,
        _NET_WM_USER_TIME_WINDOW,
        _NET_FRAME_EXTENTS,
        _NET_WM_OPAQUE_REGION,
        _NET_WM_PING,
        _NET_WM_SYNC_REQUEST,
        _NET_WM_FULLSCREEN_MONITORS,
        _NET_WM_FULL_PLACEMENT,
        #endregion

        #region Motif
        _MOTIF_WM_HINTS,
        #endregion

        #region XDnD
        XdndAware,
        XdndSelection,
        XdndEnter,
        XdndLeave,
        XdndPosition,
        XdndDrop,
        XdndFinished,
        XdndStatus,
        XdndActionCopy,
        XdndActionMove,
        XdndActionLink,
        XdndActionAsk,
        XdndActionPrivate,
        XdndTypeList,
        XdndActionList,
        XdndActionDescription,
        #endregion

        EDID,

        // This Atom is apparently non-standard so there is no documentation to reference.
        // But it seems that if _NET_SUPPORTED lists this atom we could probably use it.
        // - Noggin_bops 2024-11-01
        _NET_WM_WINDOW_OPACITY,

        // We use this atom so we can ignore debug prints
        // when we get PropertyNotify events updating this property.
        // - Noggin_bops 2024-11-03
        _GTK_EDGE_CONSTRAINTS,

        /// <summary>
        /// This is not a valid known atom name, however it is used for internal verification.
        /// </summary>
        KNOWN_ATOMS_MAX
    }
}
