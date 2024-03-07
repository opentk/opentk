using System;
using System.Runtime.InteropServices;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11 
{
    internal unsafe struct XkbDescRec
    {
        public XDisplayPtr         display;        /* connection to X server */
        public ushort              flags;          /* private to Xkb, do not modify */
        public ushort              device_spec;    /* device of interest */
        public byte /* KeyCode */  min_key_code;   /* minimum keycode for device */
        public byte /* KeyCode */  max_key_code;   /* maximum keycode for device */
        public XkbControlsRec*     ctrls;          /* controls */
        public XkbServerMapRec*     server;         /* server keymap */
        public XkbClientMapRec*    map;            /* client keymap */
        public XkbIndicatorRec*    indicators;     /* indicator map */
        public XkbNamesRec*        names;          /* names for all components */
        public XkbCompatMapRec*    compat;         /* compatibility map */
        public XkbGeometryRec*     geom;           /* physical geometry of keyboard */
    }

    internal unsafe struct XkbControlsRec
    {
        public const int XkbMaxLegalKeyCode = 255;
        public const int XkbPerKeyBitArraySize = (XkbMaxLegalKeyCode+1)/8;

        public byte              mk_dflt_btn;       /* default button for keyboard driven mouse */
        public byte              num_groups;        /* number of keyboard groups */
        public byte              groups_wrap;       /* how to wrap out-of-bounds groups */
        public XkbModsRec        @internal;          /* defines server internal modifiers */
        public XkbModsRec        ignore_lock;       /* modifiers to ignore when checking for grab */
        public uint              enabled_ctrls;     /* 1 bit corresponding boolean control enabled */
        public ushort            repeat_delay;      /* ms delay until first repeat */
        public ushort            repeat_interval;   /* ms delay between repeats */
        public ushort            slow_keys_delay;   /* ms minimum time key must be down to be ok */
        public ushort            debounce_delay;    /* ms delay before key reactivated */
        public ushort            mk_delay;          /* ms delay to second mouse motion event */
        public ushort            mk_interval;       /* ms delay between repeat mouse events */
        public ushort            mk_time_to_max;    /* # intervals until public constant mouse move */
        public ushort            mk_max_speed;      /* multiplier for maximum mouse speed */
        public short             mk_curve;          /* determines mouse move curve type */
        public ushort            ax_options;        /* 1 bit ⇒ Access X option enabled */
        public ushort            ax_timeout;        /* seconds until Access X disabled */
        public ushort            axt_opts_mask;     /* 1 bit ⇒ options to reset on Access X timeout */
        public ushort            axt_opts_values;   /* 1 bit ⇒ turn option on, 0⇒ off */
        public uint              axt_ctrls_mask;    /* which bits in enabled_ctrls to modify */
        public uint              axt_ctrls_values;  /* values for new bits in enabled_ctrls */
        public fixed byte        per_key_repeat[XkbPerKeyBitArraySize]; /* per key auto repeat */
    }

    internal struct XkbModsRec
    {
        public byte   mask;       /* real_mods | vmods mapped to real modifiers */
        public byte   real_mods;  /* real modifier bits */
        public ushort vmods;      /* virtual modifier bits */
    }

    internal unsafe struct XkbServerMapRec
    {
        public const int XkbNumVirtualMods = 16;

        public ushort     num_acts;       /* # of occupied entries in acts */
        public ushort     size_acts;      /* # of entries in acts */
        public XkbAction *        acts;           /* linear 2d tables of key actions, 1 per keycode */
        public XkbBehavior *      behaviors;      /* key behaviors, 1 per keycode */
        public ushort *   key_acts;       /* index into acts, 1 per keycode */
        public byte *     @explicit;       /* explicit overrides of core remapping, 1 per key */
        public fixed byte      vmods[XkbNumVirtualMods];  /* real mods bound to virtual mods */
        public ushort *   vmodmap;        /* virtual mods bound to key, 1 per keycode */
    }

    internal unsafe struct XkbClientMapRec
    {
        public byte            size_types;    /* # occupied entries in types */
        public byte            num_types;     /* # entries in types */
        public XkbKeyTypeRec*   types;         /* vector of key types used by this keymap */
        public ushort          size_syms;     /* length of the syms array */
        public ushort          num_syms;      /* # entries in syms */
        public XKeySym*        syms;          /* linear 2d tables of keysyms, 1 per key */
        public XkbSymMapRec*   key_sym_map;   /* 1 per keycode, maps keycode to syms */
        public byte*           modmap;        /* 1 per keycode, real mods bound to key */
    }

    internal unsafe struct XkbIndicatorRec
    {
        public const int XkbNumIndicators = 32;

        public ulong                      phys_indicators;            /* LEDs existence */
        // FIXME: Make this an InlineArray when we update to C# 12 and .net 8.
        // public fixed XkbIndicatorMapRec   maps[XkbNumIndicators];     /* indicator maps */
        public XkbIndicatorMapRec   maps0;     /* indicator maps */
        public XkbIndicatorMapRec   maps1;     /* indicator maps */
        public XkbIndicatorMapRec   maps2;     /* indicator maps */
        public XkbIndicatorMapRec   maps3;     /* indicator maps */
        public XkbIndicatorMapRec   maps4;     /* indicator maps */
        public XkbIndicatorMapRec   maps5;     /* indicator maps */
        public XkbIndicatorMapRec   maps6;     /* indicator maps */
        public XkbIndicatorMapRec   maps7;     /* indicator maps */
        public XkbIndicatorMapRec   maps8;     /* indicator maps */
        public XkbIndicatorMapRec   maps9;     /* indicator maps */
        public XkbIndicatorMapRec   maps10;     /* indicator maps */
        public XkbIndicatorMapRec   maps11;     /* indicator maps */
        public XkbIndicatorMapRec   maps12;     /* indicator maps */
        public XkbIndicatorMapRec   maps13;     /* indicator maps */
        public XkbIndicatorMapRec   maps14;     /* indicator maps */
        public XkbIndicatorMapRec   maps15;     /* indicator maps */
        public XkbIndicatorMapRec   maps16;     /* indicator maps */
        public XkbIndicatorMapRec   maps17;     /* indicator maps */
        public XkbIndicatorMapRec   maps18;     /* indicator maps */
        public XkbIndicatorMapRec   maps19;     /* indicator maps */
        public XkbIndicatorMapRec   maps20;     /* indicator maps */
        public XkbIndicatorMapRec   maps21;     /* indicator maps */
        public XkbIndicatorMapRec   maps22;     /* indicator maps */
        public XkbIndicatorMapRec   maps23;     /* indicator maps */
        public XkbIndicatorMapRec   maps24;     /* indicator maps */
        public XkbIndicatorMapRec   maps25;     /* indicator maps */
        public XkbIndicatorMapRec   maps26;     /* indicator maps */
        public XkbIndicatorMapRec   maps27;     /* indicator maps */
        public XkbIndicatorMapRec   maps28;     /* indicator maps */
        public XkbIndicatorMapRec   maps29;     /* indicator maps */
        public XkbIndicatorMapRec   maps30;     /* indicator maps */
        public XkbIndicatorMapRec   maps31;     /* indicator maps */

        
    }

    internal unsafe struct XkbKeyNameRec
    {
        public const int XkbKeyNameLength = 4;
        public fixed byte      name[XkbKeyNameLength];      /* symbolic key names */
    }

    internal unsafe struct XkbCompatMapRec
    {
        public XkbSymInterpretRec* sym_interpret;    /* symbol based key semantics */
        public XkbModsRec          groups0; /* group ⇒ modifier map */
        public XkbModsRec          groups1; /* group ⇒ modifier map */
        public XkbModsRec          groups2; /* group ⇒ modifier map */
        public XkbModsRec          groups3; /* group ⇒ modifier map */
        public ushort              num_si;           /* # structures used in sym_interpret */
        public ushort              size_si;          /* # structures allocated in sym_interpret */
    }

    /* top-level keyboard geometry structure */
    internal unsafe struct XkbGeometryRec
    {
        public XAtom            name;            /* keyboard name */
        public ushort           width_mm;        /* keyboard width in mm/10 */
        public ushort           height_mm;       /* keyboard height in mm/10 */
        public byte*            label_font;      /* font for key labels */
        public XkbColorRec*     label_color;     /* color for key labels - pointer into colors array */
        public XkbColorRec*     base_color;      /* color for basic keyboard - pointer into colors array */
        public ushort           sz_properties;   /* size of properties array */
        public ushort           sz_colors;       /* size of colors array */
        public ushort           sz_shapes;       /* size of shapes array */
        public ushort           sz_sections;     /* size of sections array */
        public ushort           sz_doodads;      /* size of doodads array */
        public ushort           sz_key_aliases;  /* size of key aliases array */
        public ushort           num_properties;  /* number of properties in the properties array */
        public ushort           num_colors;      /* number of colors in the colors array */
        public ushort           num_shapes;      /* number of shapes in the shapes array */
        public ushort           num_sections;    /* number of sections in the sections array */
        public ushort           num_doodads;     /* number of doodads in the doodads array */
        public ushort           num_key_aliases; /* number of key aliases in the key_aliases array */
        public XkbPropertyRec*  properties;      /* properties array */
        public XkbColorRec*     colors;          /* colors array */
        public XkbShapeRec*      shapes;          /* shapes array */
        public XkbSectionRec*    sections;        /* sections array */
        public XkbDoodadRec*     doodads;         /* doodads array */
        public XkbKeyAliasRec*  key_aliases;     /* key aliases array */
    }

    internal unsafe struct XkbPropertyRec
    {
        public byte*      name;                   /* property name */
        public byte*      value;                  /* property value */
    }

    internal unsafe struct XkbColorRec
    {
        public uint    pixel;            /* color */
        public byte*   spec;             /* color name */
    }

    internal unsafe struct XkbShapeRec
    {
        public XAtom              name;             /* shape’s name */
        public ushort    num_outlines;     /* number of outlines for the shape */
        public ushort    sz_outlines;      /* size of the outlines array */
        public XkbOutlineRec*    outlines;         /* array of outlines for the shape */
        public XkbOutlineRec*    approx;           /* pointer into the array to the approximating outline */
        public XkbOutlineRec*    primary;          /* pointer into the array to the primary outline */
        public XkbBoundsRec      bounds;           /* bounding box for the shape; encompasses all outlines */
    }

    internal unsafe struct XkbSectionRec
    {
        XAtom           name;          /* section name */
        byte            priority;      /* drawing priority, 0⇒highest, 255⇒lowest */
        short           top;           /* top coordinate of section origin */
        short           left;          /* left coordinate of row origin */
        ushort          width;         /* section width, in mm/10 */
        ushort          height;        /* section height, in mm/10 */
        short           angle;         /* angle of section rotation, counterclockwise */
        ushort          num_rows;      /* number of rows in the rows array */
        ushort          num_doodads;   /* number of doodads in the doodads array */
        ushort          num_overlays;  /* number of overlays in the overlays array */
        ushort          sz_rows;       /* size of the rows array */
        ushort          sz_doodads;    /* size of the doodads array */
        ushort          sz_overlays;   /* size of the overlays array */
        XkbRowRec*      rows;          /* section rows array */
        XkbDoodadRec*   doodads;       /* section doodads array */
        XkbBoundsRec    bounds;        /* bounding box for the section, before rotation */
        XkbOverlayRec*  overlays;      /* section overlays array */
    }

    /* row in a section */
    internal unsafe struct XkbRowRec
    {
        public short               top;       /* top coordinate of row origin, relative to section’s origin */
        public short               left;      /* left coordinate of row origin, relative to section’s origin */
        public ushort              num_keys;  /* number of keys in the keys array */
        public ushort              sz_keys;   /* size of the keys array */
        public int                 vertical;  /* True ⇒vertical row, False ⇒horizontal row */
        public XkbKeyRec*          keys;      /* array of keys in the row */
        public XkbBoundsRec        bounds;    /* bounding box for the row */
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct  XkbDoodadRec
    {
        [FieldOffset(0)] public XkbAnyDoodadRec        any;
        [FieldOffset(0)] public XkbShapeDoodadRec      shape;
        [FieldOffset(0)] public XkbTextDoodadRec       text;
        [FieldOffset(0)] public XkbIndicatorDoodadRec  indicator;
        [FieldOffset(0)] public XkbLogoDoodadRec       logo;
    }

    internal unsafe struct XkbOverlayRec
    {
        XAtom              name;           /* overlay name */
        XkbSectionRec*     section_under;  /* the section under this overlay */
        ushort             num_rows;       /* number of rows in the rows array */
        ushort             sz_rows;        /* size of the rows array */
        XkbOverlayRowRec*  rows;           /* array of rows in the overlay */
        XkbBoundsRec*      bounds;         /* bounding box for the overlay */
    }

    internal unsafe struct XkbOverlayRowRec
    {
        public ushort            row_under;    /* index into the row under this overlay row */
        public ushort            num_keys;     /* number of keys in the keys array */
        public ushort            sz_keys;      /* size of the keys array */
        public XkbOverlayKeyRec* keys;         /* array of keys in the overlay row */
    }

    internal struct XkbOverlayKeyRec
    {
        XkbKeyNameRec      over;      /* name of this overlay key */
        XkbKeyNameRec      under;     /* name of the key under this overlay key */
    }

    internal struct XkbAnyDoodadRec
    {
        public XAtom    name;         /* doodad name */
        public byte     type;         /*  */
        public byte     priority;     /* drawing priority, 0⇒highest, 255⇒lowest */
        public short    top;          /* top coordinate, in mm/10 */
        public short    left;         /* left coordinate, in mm/10 */
        public short    angle;        /* angle of rotation, clockwise, in 1/10 degrees */
    }

    internal struct XkbShapeDoodadRec
    {
        public XAtom    name;         /* doodad name */
        public byte     type;         /* XkbOutlineDoodad or XkbSolidDoodad */
        public byte     priority;     /* drawing priority, 0⇒highest, 255⇒lowest */
        public short    top;          /* top coordinate, in mm/10 */
        public short    left;         /* left coordinate, in mm/10 */
        public short    angle;        /* angle of rotation, clockwise, in 1/10 degrees */
        public ushort   color_ndx;    /* doodad color */
        public ushort   shape_ndx;    /* doodad shape */
    }

    internal unsafe struct XkbTextDoodadRec
    {
        public XAtom   name;         /* doodad name */
        public byte    type;         /* XkbTextDoodad */
        public byte    priority;     /* drawing priority, 0⇒highest, 255⇒lowest */
        public short   top;          /* top coordinate, in mm/10 */
        public short   left;         /* left coordinate, in mm/10 */
        public short   angle;        /* angle of rotation, clockwise, in 1/10 degrees */
        public short   width;        /* width in mm/10 */
        public short   height;       /* height in mm/10 */
        public ushort  color_ndx;    /* doodad color */
        public byte*   text;         /* doodad text */
        public byte*   font;         /* arbitrary font name for doodad text */
    }

    internal struct XkbIndicatorDoodadRec
    {
        public XAtom   name;         /* doodad name */
        public byte    type;         /* XkbIndicatorDoodad */
        public byte    priority;     /* drawing priority, 0⇒highest, 255⇒lowest */
        public short   top;          /* top coordinate, in mm/10 */
        public short   left;         /* left coordinate, in mm/10 */
        public short   angle;        /* angle of rotation, clockwise, in 1/10 degrees */
        public ushort  shape_ndx;    /* doodad shape */
        public ushort  on_color_ndx; /* color for doodad if indicator is on */
        public ushort  off_color_ndx;/* color for doodad if indicator is off */
    }

    internal unsafe struct XkbLogoDoodadRec
    {
        public XAtom   name;         /* doodad name */
        public byte    type;         /* XkbLogoDoodad */
        public byte    priority;     /* drawing priority, 0⇒highest, 255⇒lowest */
        public short   top;          /* top coordinate, in mm/10 */
        public short   left;         /* left coordinate, in mm/10 */
        public short   angle;        /* angle of rotation, clockwise, in 1/10 degrees */
        public ushort  color_ndx;    /* doodad color */
        public ushort  shape_ndx;    /* doodad shape */
        public byte*   logo_name;    /* text for logo */
    }

    /* key in a row */
    internal struct XkbKeyRec
    {
        public XkbKeyNameRec    name;         /* key name */
        public short            gap;          /* gap in mm/10 from previous key in row */
        public byte             shape_ndx;    /* index of shape for key */
        public byte             color_ndx;    /* index of color for key body */
    } 

    internal unsafe struct XkbOutlineRec
    {
        ushort        num_points;     /* number of points in the outline */
        ushort        sz_points;      /* size of the points array */
        ushort        corner_radius;  /* draw corners as circles with this radius */
        XkbPointRec*  points;         /* array of points defining the outline */
    }

    /* x, y coordinates */
    internal struct XkbPointRec
    {
        public short      x;
        public short      y;
    }

    internal struct XkbBoundsRec
    {
        public short      x1, y1;       /* upper left corner of the bounds, in mm/10 */
        public short      x2, y2;       /* lower right corner of the bounds, in mm/10 */
    } 

    internal struct XkbSymInterpretRec
    {
        public XKeySym       sym;          /* keysym of interest or NULL */
        public byte          flags;        /* XkbSI_AutoRepeat, XkbSI_LockingKey */
        public byte          match;        /* specifies how mods is interpreted */
        public byte          mods;         /* modifier bits, correspond to eight real modifiers */
        public byte          virtual_mod;  /* 1 modifier to add to key virtual mod map */
        public XkbAnyAction  act;          /* action to bind to symbol position on key */
    }

    internal unsafe struct XkbKeyAliasRec
    {
        public const int XkbKeyNameLength = 4;
        public fixed byte      real[XkbKeyNameLength];  /* this key name must be in the keys array */
        public fixed byte      alias[XkbKeyNameLength]; /* symbolic key name as alias for the key */
    }

    internal unsafe struct XkbNamesRec
    {
        public const int XkbNumVirtualMods = 16;
        public const int XkbNumIndicators = 32;
        public const int XkbNumKbdGroups = 4;
        public const int XkbMaxRadioGroups = 32;

        public XAtom            keycodes;        /* identifies range and meaning of keycodes */
        public XAtom            geometry;        /* identifies physical location, size, and shape of keys */
        public XAtom            symbols;         /* identifies the symbols logically bound to the keys */
        public XAtom            types;           /* identifies the set of key types */
        public XAtom            compat;          /* identifies actions for keys using core protocol */
        public VMods            vmods;           /* symbolic names for virtual modifiers */
        public Indicators       indicators;      /* symbolic names for indicators */
        public Groups           groups;          /* symbolic names for keyboard groups */
        public XkbKeyNameRec*   keys;            /* symbolic key name array */
        public XkbKeyAliasRec*  key_aliases;     /* real/alias symbolic name pairs array */
        public XAtom*           radio_groups;    /* radio group name array */
        public XAtom            phys_symbols;    /* identifies the symbols engraved on the keyboard */
        public byte             num_keys;        /* number of keys in the keys array */
        public byte             num_key_aliases; /* number of keys in the key_aliases array */
        public ushort           num_rg;          /* number of radio groups */

        // FIXME: Make into InlineArray in C# 12 and .net 8.
        internal struct VMods
        {
            public XAtom            vmods0;
            public XAtom            vmods1;
            public XAtom            vmods2;
            public XAtom            vmods3;
            public XAtom            vmods4;
            public XAtom            vmods5;
            public XAtom            vmods6;
            public XAtom            vmods7;
            public XAtom            vmods8;
            public XAtom            vmods9;
            public XAtom            vmods10;
            public XAtom            vmods11;
            public XAtom            vmods12;
            public XAtom            vmods13;
            public XAtom            vmods14;
            public XAtom            vmods15;

            public XAtom this[int i]
            {
                readonly get 
                {
                    switch (i)
                    {
                        case < 0: throw new IndexOutOfRangeException($"Index must be larger than zero. Got: {i}");
                        case >= 16: throw new IndexOutOfRangeException($"Index must be smaller than 16. Got: {i}");

                        case 0:  return vmods0;
                        case 1:  return vmods1;
                        case 2:  return vmods2;
                        case 3:  return vmods3;
                        case 4:  return vmods4;
                        case 5:  return vmods5;
                        case 6:  return vmods6;
                        case 7:  return vmods7;
                        case 8:  return vmods8;
                        case 9:  return vmods9;
                        case 10: return vmods10;
                        case 11: return vmods11;
                        case 12: return vmods12;
                        case 13: return vmods13;
                        case 14: return vmods14;
                        case 15: return vmods15;
                    }
                }

                set 
                {
                    switch (i)
                    {
                        case < 0: throw new IndexOutOfRangeException($"Index must be larger than zero. Got: {i}");
                        case >= 16: throw new IndexOutOfRangeException($"Index must be smaller than 16. Got: {i}");

                        case 0:  vmods0 = value; break;
                        case 1:  vmods1 = value; break;
                        case 2:  vmods2 = value; break;
                        case 3:  vmods3 = value; break;
                        case 4:  vmods4 = value; break;
                        case 5:  vmods5 = value; break;
                        case 6:  vmods6 = value; break;
                        case 7:  vmods7 = value; break;
                        case 8:  vmods8 = value; break;
                        case 9:  vmods9 = value; break;
                        case 10: vmods10 = value; break;
                        case 11: vmods11 = value; break;
                        case 12: vmods12 = value; break;
                        case 13: vmods13 = value; break;
                        case 14: vmods14 = value; break;
                        case 15: vmods15 = value; break;
                    }
                }
            }
        }
    
        internal struct Indicators 
        {
            public XAtom indicators0;
            public XAtom indicators1;
            public XAtom indicators2;
            public XAtom indicators3;
            public XAtom indicators4;
            public XAtom indicators5;
            public XAtom indicators6;
            public XAtom indicators7;
            public XAtom indicators8;
            public XAtom indicators9;
            public XAtom indicators10;
            public XAtom indicators11;
            public XAtom indicators12;
            public XAtom indicators13;
            public XAtom indicators14;
            public XAtom indicators15;
            public XAtom indicators16;
            public XAtom indicators17;
            public XAtom indicators18;
            public XAtom indicators19;
            public XAtom indicators20;
            public XAtom indicators21;
            public XAtom indicators22;
            public XAtom indicators23;
            public XAtom indicators24;
            public XAtom indicators25;
            public XAtom indicators26;
            public XAtom indicators27;
            public XAtom indicators28;
            public XAtom indicators29;
            public XAtom indicators30;
            public XAtom indicators31;

            public XAtom this[int i]
            {
                readonly get 
                {
                    switch (i)
                    {
                        case < 0: throw new IndexOutOfRangeException($"Index must be larger than zero. Got: {i}");
                        case >= 32: throw new IndexOutOfRangeException($"Index must be smaller than 32. Got: {i}");

                        case 0:  return indicators0;
                        case 1:  return indicators1;
                        case 2:  return indicators2;
                        case 3:  return indicators3;
                        case 4:  return indicators4;
                        case 5:  return indicators5;
                        case 6:  return indicators6;
                        case 7:  return indicators7;
                        case 8:  return indicators8;
                        case 9:  return indicators9;
                        case 10: return indicators10;
                        case 11: return indicators11;
                        case 12: return indicators12;
                        case 13: return indicators13;
                        case 14: return indicators14;
                        case 15: return indicators15;
                        case 16: return indicators16;
                        case 17: return indicators17;
                        case 18: return indicators18;
                        case 19: return indicators19;
                        case 20: return indicators20;
                        case 21: return indicators21;
                        case 22: return indicators22;
                        case 23: return indicators23;
                        case 24: return indicators24;
                        case 25: return indicators25;
                        case 26: return indicators26;
                        case 27: return indicators27;
                        case 28: return indicators28;
                        case 29: return indicators29;
                        case 30: return indicators30;
                        case 31: return indicators31;
                    }
                }

                set 
                {
                    switch (i)
                    {
                        case < 0: throw new IndexOutOfRangeException($"Index must be larger than zero. Got: {i}");
                        case >= 32: throw new IndexOutOfRangeException($"Index must be smaller than 32. Got: {i}");

                        case 0:  indicators0 = value; break;
                        case 1:  indicators1 = value; break;
                        case 2:  indicators2 = value; break;
                        case 3:  indicators3 = value; break;
                        case 4:  indicators4 = value; break;
                        case 5:  indicators5 = value; break;
                        case 6:  indicators6 = value; break;
                        case 7:  indicators7 = value; break;
                        case 8:  indicators8 = value; break;
                        case 9:  indicators9 = value; break;
                        case 10: indicators10 = value; break;
                        case 11: indicators11 = value; break;
                        case 12: indicators12 = value; break;
                        case 13: indicators13 = value; break;
                        case 14: indicators14 = value; break;
                        case 15: indicators15 = value; break;
                        case 16: indicators16 = value; break;
                        case 17: indicators17 = value; break;
                        case 18: indicators18 = value; break;
                        case 19: indicators19 = value; break;
                        case 20: indicators20 = value; break;
                        case 21: indicators21 = value; break;
                        case 22: indicators22 = value; break;
                        case 23: indicators23 = value; break;
                        case 24: indicators24 = value; break;
                        case 25: indicators25 = value; break;
                        case 26: indicators26 = value; break;
                        case 27: indicators27 = value; break;
                        case 28: indicators28 = value; break;
                        case 29: indicators29 = value; break;
                        case 30: indicators30 = value; break;
                        case 31: indicators31 = value; break;
                    }
                }
            }
        }
    
        internal struct Groups
        {
            public XAtom groups0;
            public XAtom groups1;
            public XAtom groups2;
            public XAtom groups3;

            public XAtom this[int i]
            {
                readonly get
                {
                    switch (i)
                    {
                        case < 0: throw new IndexOutOfRangeException($"Index must be larger than zero. Got: {i}");
                        case >= 4: throw new IndexOutOfRangeException($"Index must be smaller than 4. Got: {i}");

                        case 0:  return groups0;
                        case 1:  return groups1;
                        case 2:  return groups2;
                        case 3:  return groups3;
                    }
                }

                set 
                {
                    switch (i)
                    {
                        case < 0: throw new IndexOutOfRangeException($"Index must be larger than zero. Got: {i}");
                        case >= 16: throw new IndexOutOfRangeException($"Index must be smaller than 4. Got: {i}");

                        case 0:  groups0 = value; break;
                        case 1:  groups1 = value; break;
                        case 2:  groups2 = value; break;
                        case 3:  groups3 = value; break;
                    }
                }
            }
        }
    }

    internal struct XkbIndicatorMapRec
    {
        public byte        flags;         /* how the indicator can be changed */
        public byte        which_groups;  /* match criteria for groups */
        public byte        groups;        /* which keyboard groups the indicator watches */
        public byte        which_mods;    /* match criteria for modifiers */
        public XkbModsRec  mods;          /* which modifiers the indicator watches */
        public uint        ctrls;         /* which controls the indicator watches */
    }

    internal unsafe struct XkbKeyTypeRec 
    {                     /* Key Type */
        public XkbModsRec        mods;          /* modifiers used to compute shift level */
        public byte              num_levels;    /* total # shift levels, do not modify directly */
        public byte              map_count;     /* # entries in map, preserve (if non-NULL) */
        public XkbKTMapEntryRec* map;           /* vector of modifiers for each shift level */
        public XkbModsRec*       preserve;      /* mods to preserve for corresponding map entry */
        public XAtom             name;          /* name of key type */
        public XAtom *           level_names;   /* array of names of each shift level */
    }

    /* Modifiers for a key type */
    internal unsafe struct XkbKTMapEntryRec 
    {
        public int /* Bool */    active;        /* True ⇒ entry active when determining shift level */
        public byte              level;         /* shift level if modifiers match mods */
        public XkbModsRec        mods;          /* mods needed for this level to be selected */
    } 

    /* map to keysyms for a single keycode */
    internal unsafe struct XkbSymMapRec 
    {
        public const int XkbNumKbdGroups = 4;
        public const int XkbMaxKbdGroup = (XkbNumKbdGroups-1);

        public fixed byte  kt_index[XkbNumKbdGroups]; /* key type index for each group */
        public byte        group_info;        /* # of groups and out of range group handling */
        public byte        width;             /* max # of shift levels for key */
        public ushort      offset;            /* index to keysym table in syms array */
    }

    internal struct XkbBehavior
    {
        public byte  type;              /* behavior type + optional XkbKB_Permanent bit */
        public byte  data;
    }

    [StructLayout(LayoutKind.Explicit)]
    struct XkbAction
    {
        [FieldOffset(0)] public byte             type;
        [FieldOffset(0)] public XkbAnyAction              any;
        [FieldOffset(0)] public XkbModAction              mods;
        [FieldOffset(0)] public XkbGroupAction            group;
        [FieldOffset(0)] public XkbISOAction              iso;
        [FieldOffset(0)] public XkbPtrAction              ptr;
        [FieldOffset(0)] public XkbPtrBtnAction           btn;
        [FieldOffset(0)] public XkbPtrDfltAction          dflt;
        [FieldOffset(0)] public XkbSwitchScreenAction     screen;
        [FieldOffset(0)] public XkbCtrlsAction            ctrls;
        [FieldOffset(0)] public XkbMessageAction          msg;
        [FieldOffset(0)] public XkbRedirectKeyAction      redirect;
        [FieldOffset(0)] public XkbDeviceBtnAction        devbtn;
        [FieldOffset(0)] public XkbDeviceValuatorAction   devval;
    }

    internal unsafe struct XkbAnyAction
    {
        public const int XkbAnyActionDataSize = 7;

        public byte       type;            /* type of action; determines interpretation for data */
        public fixed byte data[XkbAnyActionDataSize];
    }

    internal unsafe struct XkbModAction
    {
        public byte     type;         /* XkbSA_{Set|Latch|Lock}Mods */
        public byte     flags;        /* with type, controls the effect on modifiers */
        public byte     mask;         /* same as mask field of a modifier description */
        public byte     real_mods;    /* same as real_mods field of a modifier description */
        public byte     vmods1;       /* derived from vmods field of a modifier description */
        public byte     vmods2;       /* derived from vmods field of a modifier description */
    }

    internal unsafe struct XkbGroupAction
    {
        public byte   type;       /* XkbSA_{Set|Latch|Lock}Group */
        public byte   flags;      /* with type , controls the effect on groups */
        public byte  group_XXX;  /* represents a group index or delta */
    }

    internal unsafe struct XkbISOAction
    {
        public byte   type;        /* XkbSA_ISOLock */
        public byte   flags;       /* controls changes to group or modifier state */
        public byte   mask;        /* same as mask field of a modifier description */
        public byte   real_mods;   /* same as real_mods field of a modifier description */
        public byte   group_XXX;   /* group index or delta group */
        public byte   affect;      /* specifies whether to affect mods, group, ptrbtn, or controls */
        public byte   vmods1;      /* derived from vmods field of a modifier description */
        public byte   vmods2;      /* derived from vmods field of a modifier description */
    }

    internal unsafe struct XkbPtrAction
    {
        public byte      type;      /* XkbSA_MovePtr */
        public byte      flags;     /* determines type of pointer motion */
        public byte      high_XXX;  /* x coordinate, high bits */
        public byte      low_XXX;   /* y coordinate, low bits */
        public byte      high_YYY;  /* x coordinate, high bits */
        public byte      low_YYY;   /* y coordinate, low bits */
    }

    internal unsafe struct XkbPtrBtnAction
    {
        public byte   type;     /* XkbSA_PtrBtn, XkbSA_LockPtrBtn */
        public byte   flags;    /* with type, controls the effect on pointer buttons */
        public byte   count;    /* controls number of ButtonPress and ButtonRelease events */
        public byte   button;   /* pointer button to simulate */
    }

    internal unsafe struct XkbPtrDfltAction
    {
        public byte   type;      /* XkbSA_SetPtrDflt */
        public byte   flags;     /* controls the pointer button number */
        public byte   affect;    /* XkbSA_AffectDfltBtn */
        public byte   valueXXX;  /* new default button member */
    }

    internal unsafe struct XkbSwitchScreenAction
    {
        public byte   type;        /* XkbSA_SwitchScreen */
        public byte   flags;       /* controls screen switching */
        public byte   screenXXX;   /* screen number or delta */
    }

    internal unsafe struct XkbCtrlsAction
    {
        public byte     type;        /* XkbSA_SetControls, XkbSA_LockControls */
        public byte     flags;       /* with type, controls enabling and disabling of controls */
        public byte     ctrls3;      /* ctrls0 through ctrls3 represent the boolean controls */
        public byte     ctrls2;      /* ctrls0 through ctrls3 represent the boolean controls */
        public byte     ctrls1;      /* ctrls0 through ctrls3 represent the boolean controls */
        public byte     ctrls0;      /* ctrls0 through ctrls3 represent the boolean controls */
    }

    internal unsafe struct XkbMessageAction
    {
        public const int XkbActionMessageLength = 6;

        public byte   type;             /* XkbSA_ActionMessage */
        public byte   flags;            /* controls event generation via key presses and releases */
        public fixed byte   message[XkbActionMessageLength];    /* message */
    }

    internal unsafe struct XkbActionMessageEvent
    {
        public const int XkbActionMessageLength = 6;

        public int                type;             /* Xkb extension base event code */
        public ulong              serial;           /* X server serial number for event */
        public int /* Bool */     send_event;       /* True ⇒ synthetically generated */
        public XDisplayPtr        display;          /* server connection where event generated */
        public XTime              time;             /* server time when event generated */
        public int                xkb_type;         /* XkbActionMessage */
        public int                device;           /* Xkb device ID, will not be XkbUseCoreKbd */
        public byte /* KeyCode */ keycode;          /* keycode of key triggering event */
        public int /* Bool */     press;            /* True ⇒ key press, False ⇒ release */
        public int /* Bool */     key_event_follows;/* True ⇒ KeyPress/KeyRelease follows */
        public fixed byte         message[XkbActionMessageLength+1];  /* message text */
    }

    internal struct XkbRedirectKeyAction
    {
        public byte      type;          /* XkbSA_RedirectKey */
        public byte      new_key;       /* keycode to be put in event */
        public byte      mods_mask;     /* mask of real mods to be reset */
        public byte      mods;          /* mask of real mods to take values from */
        public byte      vmods_mask0;   /* first half of mask of virtual mods to be reset */
        public byte      vmods_mask1;   /* other half of mask of virtual mods to be reset */
        public byte      vmods0;        /* first half of mask of virtual mods to take values from */
        public byte      vmods1;        /* other half of mask of virtual mods to take values from */
    }

    internal struct XkbDeviceBtnAction
    {
        public byte    type;      /* XkbSA_DeviceBtn, XkbSA_LockDeviceBtn */
        public byte    flags;     /* with type, specifies locking or unlocking */
        public byte    count;     /* controls number of DeviceButtonPress and Release events */
        public byte    button;    /* index of button on device */
        public byte    device;    /* device ID of an X input extension device */
    }

    internal struct XkbDeviceValuatorAction
    {
        public byte    type;        /* XkbSA_DeviceValuator */
        public byte    device;      /* device ID */
        public byte    v1_what;     /* determines how valuator is to behave for valuator 1 */
        public byte    v1_ndx;      /* specifies a real valuator */
        public byte    v1_value;    /* the value for valuator 1 */
        public byte    v2_what;     /* determines how valuator is to behave for valuator 2 */
        public byte    v2_ndx;      /* specifies a real valuator */
        public byte    v2_value;    /* the value for valuator 1 */
    }
}
