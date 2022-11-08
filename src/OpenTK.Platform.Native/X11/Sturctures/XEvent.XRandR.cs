using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    public struct XRRScreenChangeNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public XWindow Root;
        public XTime TimeStamp;
        public XTime ConfigurationTimeStamp;
        public ushort SizeId;
        public ushort SubPixelOrder;
        public ushort Rotation;
        public int Width;
        public int Height;
        public int MWidth;
        public int MHeight;
    }

    public struct XRRNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
    }

    public struct XRROutputChangeNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
        public XID Output;
        public XID Crtc;
        public XID Mode;
        public ushort Rotation;
        public ushort Connection;
        public ushort SubPixelOrder;
    }

    public struct XRRCrtcChangedNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
        public XID Output;
        public XID Crtc;
        public XID Mode;
        public ushort Rotation;
        public int X;
        public int Y;
        public uint Width;
        public uint Height;
    }

    public struct XRROutputPropertyNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
        public XID Output;
        public XAtom Property;
        public XTime TimeStamp;
        public int State;
    }

    public struct XRRProviderChangeNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
        public XID Provider;
        public XTime TimeStamp;
        public uint CurrentRole;
    }

    public struct XRRProviderPropertyNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
        public XID Provider;
        public XAtom Property;
        public XTime TimeStamp;
        public int State;
    }

    public struct XRRResourceChangeNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
        public XTime TimeStamp;
    }
}
