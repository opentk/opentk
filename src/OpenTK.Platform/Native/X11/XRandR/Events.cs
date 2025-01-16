namespace OpenTK.Platform.Native.X11.XRandR
{
    internal struct XRRScreenChangeNotifyEvent
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

    internal struct XRRNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
    }

    internal struct XRROutputChangeNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
        public RROutput Output;
        public RRCrtc Crtc;
        public RRMode Mode;
        public Rotation Rotation;
        public Connection Connection;
        public SubpixelOrder SubPixelOrder;
    }

    internal struct XRRCrtcChangedNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
        public RROutput Output;
        public RRCrtc Crtc;
        public RRMode Mode;
        public Rotation Rotation;
        public int X;
        public int Y;
        public uint Width;
        public uint Height;
    }

    internal struct XRROutputPropertyNotifyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
        public RRNotifySubType SubType;
        public RROutput Output;
        public XAtom Property;
        public XTime TimeStamp;
        public int State;
    }

    internal struct XRRProviderChangeNotifyEvent
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

    internal struct XRRProviderPropertyNotifyEvent
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

    internal struct XRRResourceChangeNotifyEvent
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
