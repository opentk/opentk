//
// Xkb.cs
//
// Author:
//       Stefanos Apostolopoulos <stapostol@gmail.com>
//
// Copyright (c) 2006-2014
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

#pragma warning disable 0169

namespace OpenTK.Platform.X11
{
    using Atom = IntPtr;
    using KeyCode = Byte;
    using XkbControlsPtr = IntPtr;
    using XkbServerMapPtr = IntPtr;
    using XkbClientMapPtr = IntPtr;
    using XkbIndicatorPtr = IntPtr;
    using XkbCompatMapPtr = IntPtr;
    using XkbGeometryPtr = IntPtr;

    internal class Xkb
    {
        private const string lib = "libX11";

        internal const int KeyNameLength = 4;
        internal const int NumModifiers = 8;
        internal const int NumVirtualMods = 16;
        internal const int NumIndicators = 32;
        internal const int NumKbdGroups = 4;
        internal const int UseCoreKeyboard = 0x0100;

        [DllImport(lib, EntryPoint = "XkbFreeKeyboard")]
        internal static extern unsafe void FreeKeyboard(XkbDesc* descr, int which, bool free);

        [DllImport(lib, EntryPoint = "XkbAllocKeyboard")]
        internal static extern unsafe XkbDesc* AllocKeyboard(IntPtr display);

        [DllImport(lib, EntryPoint = "XkbGetKeyboard")]
        internal static extern IntPtr GetKeyboard(IntPtr display, XkbKeyboardMask which, int device_id);

        [DllImport(lib, EntryPoint = "XkbGetMap")]
        internal static extern IntPtr GetMap(IntPtr display, XkbKeyboardMask which, int device_spec);

        [DllImport(lib, EntryPoint = "XkbGetNames")]
        internal static extern unsafe IntPtr GetNames(IntPtr display, XkbNamesMask which, XkbDesc* xkb);

        [DllImport(lib, EntryPoint = "XkbKeycodeToKeysym")]
        internal static extern XKey KeycodeToKeysym(IntPtr display, int keycode, int group, int level);

        [DllImport(lib, EntryPoint = "XkbQueryExtension")]
        internal static extern bool QueryExtension(IntPtr display, out int opcode_rtrn, out int event_rtrn,
            out int error_rtrn, ref int major_in_out, ref int minor_in_out);

        [DllImport(lib, EntryPoint = "XkbSetDetectableAutoRepeat")]
        internal static extern bool SetDetectableAutoRepeat(IntPtr display, bool detectable, out bool supported);

        internal static bool IsSupported(IntPtr display)
        {
            // The XkbQueryExtension manpage says that we cannot
            // use XQueryExtension with XKB.
            int opcode, error, ev;
            var major = 1;
            var minor = 0;
            var supported = QueryExtension(display, out opcode, out ev, out error, ref major, ref minor);
            Debug.Print("XKB extension is {0}.", supported ? "supported" : "not supported");
            if (supported)
            {
                Debug.Print("XKB version is {0}.{1}", major, minor);
            }

            return supported;
        }
    }

    [Flags]
    internal enum XkbKeyboardMask
    {
        Controls = 1 << 0,
        ServerMap = 1 << 1,
        IClientMap = 1 << 2,
        IndicatorMap = 1 << 3,
        Names = 1 << 4,
        CompatibilityMap = 1 << 5,
        Geometry = 1 << 6,
        AllComponents = 1 << 7
    }

    [Flags]
    internal enum XkbNamesMask
    {
        Keycodes = 1 << 0,
        Geometry = 1 << 1,
        Symbols = 1 << 2,
        PhysSymbols = 1 << 3,
        Types = 1 << 4,
        Compat = 1 << 5,
        KeyType = 1 << 6,
        KTLevel = 1 << 7,
        Indicator = 1 << 8,
        Key = 1 << 9,
        KeyAliasesMask = 1 << 10,
        VirtualMod = 1 << 11,
        Group = 1 << 12,
        RG = 1 << 13,
        Component = 0x3f,
        All = 0x3fff
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct XkbDesc
    {
        internal IntPtr dpy;
        internal ushort flags;
        internal ushort device_spec;
        internal byte min_key_code;
        internal byte max_key_code;

        internal XkbControlsPtr ctrls;
        internal XkbServerMapPtr server;
        internal XkbClientMapPtr map;
        internal XkbIndicatorPtr indicators;
        internal XkbNames* names;
        internal XkbCompatMapPtr compat;
        internal XkbGeometryPtr geom;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct XkbKeyAlias
    {
        internal fixed byte real[Xkb.KeyNameLength];
        internal fixed byte alias[Xkb.KeyNameLength];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct XkbKeyName
    {
        internal fixed byte name[Xkb.KeyNameLength];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct XkbNames
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct Groups
        {
            private Atom groups0;
            private readonly Atom groups1;
            private readonly Atom groups2;
            private readonly Atom groups3;

            internal Atom this[int i]
            {
                get
                {
                    if (i < 0 || i > 3)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    fixed (Atom* ptr = &groups0)
                    {
                        return *(ptr + i);
                    }
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct Indicators
        {
            private Atom indicators0;
            private readonly Atom indicators1;
            private readonly Atom indicators2;
            private readonly Atom indicators3;
            private readonly Atom indicators4;
            private readonly Atom indicators5;
            private readonly Atom indicators6;
            private readonly Atom indicators7;
            private readonly Atom indicators8;
            private readonly Atom indicators9;
            private readonly Atom indicators10;
            private readonly Atom indicators11;
            private readonly Atom indicators12;
            private readonly Atom indicators13;
            private readonly Atom indicators14;
            private readonly Atom indicators15;
            private readonly Atom indicators16;
            private readonly Atom indicators17;
            private readonly Atom indicators18;
            private readonly Atom indicators19;
            private readonly Atom indicators20;
            private readonly Atom indicators21;
            private readonly Atom indicators22;
            private readonly Atom indicators23;
            private readonly Atom indicators24;
            private readonly Atom indicators25;
            private readonly Atom indicators26;
            private readonly Atom indicators27;
            private readonly Atom indicators28;
            private readonly Atom indicators29;
            private readonly Atom indicators30;
            private readonly Atom indicators31;

            internal Atom this[int i]
            {
                get
                {
                    if (i < 0 || i > 31)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    fixed (Atom* ptr = &indicators0)
                    {
                        return *(ptr + i);
                    }
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct VMods
        {
            private Atom vmods0;
            private readonly Atom vmods1;
            private readonly Atom vmods2;
            private readonly Atom vmods3;
            private readonly Atom vmods4;
            private readonly Atom vmods5;
            private readonly Atom vmods6;
            private readonly Atom vmods7;
            private readonly Atom vmods8;
            private readonly Atom vmods9;
            private readonly Atom vmods10;
            private readonly Atom vmods11;
            private readonly Atom vmods12;
            private readonly Atom vmods13;
            private readonly Atom vmods14;
            private readonly Atom vmods15;

            internal Atom this[int i]
            {
                get
                {
                    if (i < 0 || i > 15)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    fixed (Atom* ptr = &vmods0)
                    {
                        return *(ptr + i);
                    }
                }
            }
        }

        internal Atom keycodes;
        internal Atom geometry;
        internal Atom symbols;
        internal Atom types;
        internal Atom compat;
        internal VMods vmods;
        internal Indicators indicators;
        internal Groups groups;
        internal XkbKeyName* keys;
        internal XkbKeyAlias* key_aliases;
        internal Atom* radio_groups;
        internal Atom phys_symbols;

        internal byte num_keys;
        internal byte num_key_aliases;
        internal byte num_rg;
    }
}