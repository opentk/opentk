using System;
using System.Diagnostics;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.X11.XRandR.XRandR;
using static OpenTK.Platform.Native.X11.LibX11;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Platform.Native.X11.XRandR;

namespace OpenTK.Platform.Native.X11
{
    public class X11DisplayComponent : IDisplayComponent
    {
        /// <inheritdoc />
        public string Name => "X11DisplayComponent";

        /// <inheritdoc />
        public PalComponents Provides => PalComponents.Display;

        /// <inheritdoc />
        public ILogger? Logger { get ; set; }

        // TODO: Write Xinerama fallback.

        /// <inheritdoc />
        public bool CanGetVirtualPosition => HasRANDR == true;

        private static bool HasRANDR = false;

        private static readonly List<XDisplayHandle> _displays = new List<XDisplayHandle>();

        // FIXME: Do we really need this?
        internal struct DisplayRect
        {
            public XDisplayHandle Handle;
            public Box2i Bounds;
        }

        // FIXME: Is there some better way to expose this function?
        // See X11WindowComponent.GetDisplay for why this function is needed.
        internal static unsafe List<DisplayRect> GetDisplayRects()
        {
            // XRRGetScreenResourcesCurrent?
            XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);

            List<DisplayRect> rects = new List<DisplayRect>(_displays.Count);

            foreach (var xdisplay in _displays)
            {
                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, xdisplay.Crtc);

                // FIXME: Handle screen rotation!
                
                // FIXME: Should we use crtc size or output size?

                int x = crtcInfo->x;
                int y = crtcInfo->y;
                int width = (int)crtcInfo->width;
                int height = (int)crtcInfo->height;

                rects.Add(new DisplayRect() { Handle = xdisplay, Bounds = new Box2i(x, y, x + width, y + height) });

                XRRFreeCrtcInfo(crtcInfo);
            }

            XRRFreeScreenResources(resources);

            return rects;
        }

        internal static unsafe Box2i GetBounds(XDisplayHandle handle)
        {
            // XRRGetScreenResourcesCurrent?
            XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
            XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, handle.Crtc);

            Box2i bounds = new Box2i(crtcInfo->x, crtcInfo->y, crtcInfo->x + (int)crtcInfo->width, crtcInfo->y + (int)crtcInfo->height);

            XRRFreeCrtcInfo(crtcInfo);
            XRRFreeScreenResources(resources);

            return bounds;
        }

        internal static unsafe bool SetVideoMode(IPalComponent comp, XDisplayHandle handle, VideoMode mode)
        {
            // Find the mode that best matches the desired video mode.
            // Priority is color depth > resolution > refresh rate
            XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
            XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, handle.Crtc);
            XRROutputInfo* outputInfo = XRRGetOutputInfo(X11.Display, resources, handle.Output);

            XRRModeInfo* bestMode = null;
            int bestColorDiff = int.MaxValue;
            int bestSizeDiff = int.MaxValue;
            float bestRateDiff = int.MaxValue;
            for (int i = 0; i < outputInfo->nmode; i++)
            {
                // FIXME: glfw removes RR_Interlaced modes. Why?
                XRRModeInfo* info = GetModeInfo(resources, outputInfo->modes[i]);

                int colorDiff = int.Abs(XDefaultDepth(X11.Display, X11.DefaultScreen) - mode.BitsPerPixel);

                int sizeDiff = ((int)info->Width - mode.Width) * ((int)info->Width - mode.Width) +
                                ((int)info->Height - mode.Height) * ((int)info->Height - mode.Height);

                float rateDiff = float.Abs(CalculateRefreshRate(comp, info) - mode.RefreshRate);

                if (colorDiff < bestColorDiff ||
                    (colorDiff == bestColorDiff && sizeDiff < bestSizeDiff) ||
                    (colorDiff == bestColorDiff && sizeDiff == bestSizeDiff && rateDiff < bestRateDiff))
                {
                    bestMode = info;
                    bestColorDiff = colorDiff;
                    bestSizeDiff = sizeDiff;
                    bestRateDiff = rateDiff;
                }
            }

            if (bestMode != null)
            {
                // If the new mode is the same as the current mode
                // we don't need to do anything, we can just return.
                // We don't have to keep track of any "OldMode".
                if (bestMode->ModeId == crtcInfo->mode)
                {
                    return true;
                }

                // We are changing mode. 
                // If there is no old mode, set it.
                if (handle.OldMode == RRMode.None)
                {
                    handle.OldMode = crtcInfo->mode;
                }

                // Keep everything the same except the mode.
                RRConfigStatus status = XRRSetCrtcConfig(
                    X11.Display, resources, 
                    handle.Crtc,
                    XTime.CurrentTime, 
                    crtcInfo->x, crtcInfo->y,
                    bestMode->ModeId,
                    crtcInfo->rotation,
                    crtcInfo->outputs,
                    crtcInfo->noutput);

                if (status != RRConfigStatus.Success)
                {
                    throw new PalException(comp, $"RRSetCrtcConfig failed with: '{status}' in SetVideoMode().");
                }

                XRRFreeOutputInfo(outputInfo);
                XRRFreeCrtcInfo(crtcInfo);
                XRRFreeScreenResources(resources);
                return true;
            }
            else 
            {
                comp.Logger?.LogWarning($"No mode matched '{mode}' out of {outputInfo->nmode} modes.");
                XRRFreeOutputInfo(outputInfo);
                XRRFreeCrtcInfo(crtcInfo);
                XRRFreeScreenResources(resources);
                return false;
            }
        }

        internal static unsafe void RestoreVideoMode(IPalComponent comp, XDisplayHandle handle)
        {
            // If we don't have an old mode set, we haven't changed mode ever.
            if (handle.OldMode == RRMode.None)
                return;

            XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
            XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, handle.Crtc);
            XRROutputInfo* outputInfo = XRRGetOutputInfo(X11.Display, resources, handle.Output);

            RRConfigStatus status = XRRSetCrtcConfig(
                X11.Display, resources, 
                handle.Crtc,
                XTime.CurrentTime, 
                crtcInfo->x, crtcInfo->y,
                handle.OldMode,
                crtcInfo->rotation,
                crtcInfo->outputs,
                crtcInfo->noutput);

            if (status != RRConfigStatus.Success)
            {
                throw new PalException(comp, $"RRSetCrtcConfig failed with: '{status}' in RestoreVideoMode().");
            }

            XRRFreeOutputInfo(outputInfo);
            XRRFreeCrtcInfo(crtcInfo);
            XRRFreeScreenResources(resources);
        }

        private static unsafe XRRModeInfo* GetModeInfo(XRRScreenResources* resources, RRMode mode)
        {
            for (int i = 0; i < resources->NumberOfModes; i++)
            {
                if (resources->Modes[i].ModeId == mode)
                {
                    return &resources->Modes[i];
                }
            }

            return null;
        }

        private static unsafe float CalculateRefreshRate(IPalComponent comp, XRRModeInfo* info)
        {
            if (info->DotClock != 0 && info->VTotal != 0 && info->HTotal != 0)
            {
                return ((info->DotClock * 100) / (info->VTotal * info->HTotal)) / 100.0f;
            }
            else
            {
                // FIXME: Name or index of the display or some info about the mode...?
                comp.Logger?.LogWarning($"Could not get refresh rate. (dotclock: {info->DotClock}, vtotal: {info->VTotal}, htotal: {info->HTotal})");
                return 0;
            }
        }

        private static unsafe string GetOutputName(RROutput output, XRROutputInfo* outputInfo, ILogger? logger)
        {
            string name = Marshal.PtrToStringUTF8((IntPtr)outputInfo->name)!;

            Span<XAtom> atoms = XRRListOutputProperties(X11.Display, output, out int nprops);

            string? displayName = null;

            List<string> list = new List<string>();
            foreach (var atom in atoms)
            {
                list.Add(XGetAtomName(X11.Display, atom));

                if (atom == X11.Atoms[KnownAtoms.EDID])
                {
                    int status = XRRGetOutputProperty(
                        X11.Display, output,
                        X11.Atoms[KnownAtoms.EDID],
                        0, ~0,
                        false, false,
                        new XAtom(0),
                        out XAtom actualType,
                        out int actualFormat,
                        out long nitems,
                        out long bytesAfter,
                        out IntPtr prop);

                    if (status == X11.Success)
                    {
                        byte* edid = (byte*)prop;

                        EDID.EDIDInfo info = EDID.Parse(edid, logger);

                        displayName = info.DisplayName;

                        XFree(prop);
                    }
                }
            }

            XFree(atoms);
        
            return displayName ?? name;
        }

        // FIXME: In the current implementation we rely on function like
        // XRRGetScreenResources to always return a valid pointer.
        // This isn't really robust as this might fail in some rare cases.
        // We should fix this.
        // - Noggin_bops 2024-02-26

        /// <inheritdoc />
        public void Initialize(ToolkitOptions options)
        {
            if (X11.Extensions.Contains("RANDR"))
            {
                if (XRRQueryExtension(X11.Display, out int eventBase, out int errorBase) != 0)
                {
                    X11.XRandREventBase = eventBase;
                    X11.XRandRErrorBase = errorBase;

                    int major = 1;
                    int minor = 3;
                    XRRQueryVersion(X11.Display, ref major, ref minor);
                    if (major != 1 && minor < 3)
                    {
                        Logger?.LogError($"XRandR failed to load. Got version {major}.{minor} but 1.3 is required.");
                        return;
                    }

                    unsafe {
                        XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);

                        RROutput primaryOutput = XRRGetOutputPrimary(X11.Display, X11.DefaultRootWindow);

                        if (resources != null)
                        {
                            for (int i = 0; i < resources->NumberOfOutputs; i++)
                            {
                                RROutput output = resources->Outputs[i];
                                XRROutputInfo* outputInfo = XRRGetOutputInfo(X11.Display, resources, output);

                                if (outputInfo->crtc == RRCrtc.None || outputInfo->connection == Connection.Disconnected)
                                {
                                    XRRFreeOutputInfo(outputInfo);
                                    continue;
                                }

                                string name = GetOutputName(output, outputInfo, Logger);

                                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, outputInfo->crtc);

                                if (crtcInfo == null)
                                {
                                    continue;
                                }

                                bool isPrimary = output == primaryOutput;

                                Logger?.LogDebug($"Name: {name}");
                                if (isPrimary) Logger?.LogDebug($"Primary display");
                                Logger?.LogDebug($"Position: ({crtcInfo->x}, {crtcInfo->y})");
                                Logger?.LogDebug($"Resolution: ({crtcInfo->width}, {crtcInfo->height})");
                                Logger?.LogDebug($"Rotation: {crtcInfo->rotation}");

                                XDisplayHandle handle = new XDisplayHandle(output, outputInfo->crtc, name);

                                // FIXME: More proper order of displays?
                                if (isPrimary)
                                    _displays.Insert(0, handle);
                                else
                                    _displays.Add(handle);

                                XRRFreeOutputInfo(outputInfo);
                                XRRFreeCrtcInfo(crtcInfo);
                            }

                            XRRFreeScreenResources(resources);
                        }

                        Debug.Assert(_displays.Count > 0);

                        // Subscribe to events relating to connecting and disconnecting monitors.
                        XRRSelectInput(X11.Display, X11.DefaultRootWindow,  RRSelectMask.OutputChangeNotifyMask);
                    }
                
                    HasRANDR = true;
                    Logger?.LogInfo("Using XRANDR for display component.");
                }

                // FIXME: Error message for when this fails?
            }
            else 
            {
                HasRANDR = false;
                Logger?.LogError("Could not find XRANDR extension. The display component will not work.");
            }
        }

        internal static void HandleXRREvent(XEvent @event, ILogger? logger)
        {
            switch ((RREventType)(@event.Type - X11.XRandREventBase))
            {
                case RREventType.RRScreenChangeNotify:
                    Console.WriteLine("RR Screen change notify.");
                    break;
                case RREventType.RRNotify:
                {
                    logger?.LogDebug($"RR Notify (subtype: {@event.RRNotify.SubType})");
                    if (@event.RRNotify.SubType == RRNotifySubType.OutputChange)
                    {
                        XRROutputChangeNotifyEvent outputChanged = @event.RROutputChangeNotify;

                        // Find the XDisplayHandle that this event relates to...
                        XDisplayHandle? handle = null;
                        foreach (XDisplayHandle display in _displays)
                        {
                            if (display.Output == outputChanged.Output)
                            {
                                handle = display;
                                break;
                            }
                        }

                        if (outputChanged.Connection == Connection.Connected)
                        {
                            if (handle == null)
                            {
                                unsafe
                                {
                                    XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
                                    RROutput primaryOutput = XRRGetOutputPrimary(X11.Display, X11.DefaultRootWindow);

                                    if (resources != null)
                                    {
                                        XRROutputInfo* outputInfo = XRRGetOutputInfo(X11.Display, resources, outputChanged.Output);

                                        if (outputInfo->crtc == RRCrtc.None || outputInfo->connection == Connection.Disconnected)
                                        {
                                            XRRFreeOutputInfo(outputInfo);
                                            XRRFreeScreenResources(resources);
                                            return;
                                        }

                                        string name = GetOutputName(outputChanged.Output, outputInfo, logger);

                                        handle = new XDisplayHandle(outputChanged.Output, outputInfo->crtc, name);

                                        if (handle.Output == primaryOutput)
                                            _displays.Insert(0, handle);
                                        else
                                            _displays.Add(handle);

                                        EventQueue.Raise(handle, PlatformEventType.DisplayConnectionChanged, new DisplayConnectionChangedEventArgs(handle, false));
                                        logger?.LogDebug($"Connected display '{name}'!");

                                        XRRFreeOutputInfo(outputInfo);
                                        XRRFreeScreenResources(resources);
                                    }
                                }
                            }
                            else
                            {
                                logger?.LogDebug("Connected already connected display!");
                                // This display already existed.
                                // FIXME: Update rotation?
                            }
                        }
                        else if (outputChanged.Connection == Connection.Disconnected)
                        {
                            if (handle != null)
                            {
                                logger?.LogDebug($"Disconnected display '{handle.Name}'!");
                                _displays.Remove(handle);
                                EventQueue.Raise(handle, PlatformEventType.DisplayConnectionChanged, new DisplayConnectionChangedEventArgs(handle, true));
                            }
                        }
                    }
                    break;
                }
                default:
                    break;
            }
        }

        /// <inheritdoc />
        public int GetDisplayCount()
        {
            return _displays.Count;
        }

        /// <inheritdoc />
        public DisplayHandle Open(int index)
        {
            // FIXME: Bounds check
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index), $"Display index cannot be negative. {index}");
            if (index >= _displays.Count) throw new ArgumentOutOfRangeException(nameof(index), $"Display index cannot be larger or equal to the number of displays. Index: {index}, Display count: {_displays.Count}");

            return _displays[index];
        }

        /// <inheritdoc />
        public DisplayHandle OpenPrimary()
        {
            return Open(0);
        }

        /// <inheritdoc />
        public void Close(DisplayHandle handle)
        {
            // We don't need to do anything here, we just verify that we got the right type of handle.
            XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);
        }

        /// <inheritdoc />
        public bool IsPrimary(DisplayHandle handle)
        {
            XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);
            RROutput primary = XRRGetOutputPrimary(X11.Display, X11.DefaultRootWindow);

            return xdisplay.Output == primary;
        }

        /// <inheritdoc />
        public string GetName(DisplayHandle handle)
        {
            XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);
            return xdisplay.Name;
        }

        /// <inheritdoc />
        public void GetVideoMode(DisplayHandle handle, out VideoMode mode)
        {
            XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

            unsafe
            {
                XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, xdisplay.Crtc);

                if (crtcInfo != null)
                {
                    XRRModeInfo* info = GetModeInfo(resources, crtcInfo->mode);
                    if (info != null)
                    {
                        // FIXME: Handle screen rotation!
                        mode.Width = (int)crtcInfo->width;
                        mode.Height = (int)crtcInfo->height;
                        mode.RefreshRate = CalculateRefreshRate(this, info);
                        mode.BitsPerPixel = XDefaultDepth(X11.Display, X11.DefaultScreen);
                    }
                    else
                    {
                        mode = default;
                        Logger?.LogError("Could not get the current video mode.");
                    }

                    XRRFreeCrtcInfo(crtcInfo);
                }
                else
                {
                    mode = default;
                    Logger?.LogError($"GetCrtcInfo returned null, could not get video mode for {xdisplay.Name} (crtc={xdisplay.Crtc})");
                }

                XRRFreeScreenResources(resources);
            }
        }

        internal static void GetVideoMode(IPalComponent comp, XDisplayHandle handle, out VideoMode mode)
        {
            unsafe
            {
                XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, handle.Crtc);

                if (crtcInfo != null)
                {
                    XRRModeInfo* info = GetModeInfo(resources, crtcInfo->mode);
                    if (info != null)
                    {
                        // FIXME: Handle screen rotation!
                        mode.Width = (int)crtcInfo->width;
                        mode.Height = (int)crtcInfo->height;
                        mode.RefreshRate = CalculateRefreshRate(comp, info);
                        mode.BitsPerPixel = XDefaultDepth(X11.Display, X11.DefaultScreen);
                    }
                    else
                    {
                        mode = default;
                        comp.Logger?.LogError($"Could not get the current video mode for {handle.Name}.");
                    }

                    XRRFreeCrtcInfo(crtcInfo);
                }
                else
                {
                    mode = default;
                    comp.Logger?.LogError($"GetCrtcInfo returned null, could not get video mode for {handle.Name} (crtc={handle.Crtc})");
                }

                XRRFreeScreenResources(resources);
            }
        }

        /// <inheritdoc />
        public VideoMode[] GetSupportedVideoModes(DisplayHandle handle)
        {
            unsafe
            {
                XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

                XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
                XRROutputInfo* outputInfo = XRRGetOutputInfo(X11.Display, resources, xdisplay.Output);
                if (outputInfo == null)
                {
                    return Array.Empty<VideoMode>();
                }

                VideoMode[] modes = new VideoMode[outputInfo->nmode];
                for (int i = 0; i < outputInfo->nmode; i++)
                {
                    // FIXME: glfw removes RR_Interlaced modes. Why?
                    XRRModeInfo* info = GetModeInfo(resources, outputInfo->modes[i]);

                    modes[i].Width = (int)info->Width;
                    modes[i].Height = (int)info->Height;
                    modes[i].RefreshRate = CalculateRefreshRate(this, info);
                    modes[i].BitsPerPixel = XDefaultDepth(X11.Display, X11.DefaultScreen);
                }

                XRRFreeOutputInfo(outputInfo);
                XRRFreeScreenResources(resources);

                return modes;
            }
        }

        /// <inheritdoc />
        public void GetVirtualPosition(DisplayHandle handle, out int x, out int y)
        {
            // FIXME: Should we get this every time or should we cache this?
            unsafe
            {
                XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

                XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, xdisplay.Crtc);

                if (crtcInfo != null)
                {
                    x = crtcInfo->x;
                    y = crtcInfo->y;

                    XRRFreeCrtcInfo(crtcInfo);
                }
                else
                {
                    x = 0;
                    y = 0;
                    Logger?.LogError($"GetCrtcInfo returned null, could not get virtual position for {xdisplay.Name} (crtc={xdisplay.Crtc})");

                }

                XRRFreeScreenResources(resources);
            }
        }

        /// <inheritdoc />
        public void GetResolution(DisplayHandle handle, out int width, out int  height)
        {
            // FIXME: Should we get this every time or should we cache this?
            unsafe
            {
                XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

                XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, xdisplay.Crtc);

                if (crtcInfo != null)
                {
                    // FIXME: Handle screen rotation!
                    // FIXME: Should we use crtc size or output size?
                    width = (int)crtcInfo->width;
                    height = (int)crtcInfo->height;

                    XRRFreeCrtcInfo(crtcInfo);
                }
                else
                {
                    width = 0;
                    height = 0;
                    Logger?.LogError($"GetCrtcInfo returned null, could not get resolution for {xdisplay.Name} (crtc={xdisplay.Crtc})");
                }

                XRRFreeScreenResources(resources);
            }
        }

        /// <inheritdoc />
        public void GetWorkArea(DisplayHandle handle, out Box2i area)
        {
            XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

            unsafe
            {
                XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, xdisplay.Crtc);

                if (crtcInfo != null)
                {
                    // FIXME: Get mode info to handle rotated displays!

                    // FIXME: Should we use crtc size or output size?
                    area = new Box2i(crtcInfo->x, crtcInfo->y, crtcInfo->x + (int)crtcInfo->width, crtcInfo->y + (int)crtcInfo->height);

                    XRRFreeCrtcInfo(crtcInfo);
                }
                else
                {
                    area = default;
                    Logger?.LogError($"GetCrtcInfo returned null, could not get work area for {xdisplay.Name} (crtc={xdisplay.Crtc})");
                    XRRFreeScreenResources(resources);
                    return;
                }

                XRRFreeScreenResources(resources);
            }

            // _NET_WORKAREA tells us the area of the screen where desktops
            // should place desktop icons.
            // We intersect this area with the display area as a best effort
            // to get the "usable" area of the display.
            // - Noggin_bops 2023-08-28
            if (X11.Atoms[KnownAtoms._NET_WORKAREA] != XAtom.None &&
                X11.Atoms[KnownAtoms._NET_CURRENT_DESKTOP] != XAtom.None)
            {
                XGetWindowProperty(
                    X11.Display, 
                    X11.DefaultRootWindow,
                    X11.Atoms[KnownAtoms._NET_WORKAREA],
                    0, long.MaxValue,
                    false,
                    X11.Atoms![KnownAtoms.CARDINAL],
                    out XAtom actualType,
                    out int _,
                    out long workAreaCount,
                    out long _,
                    out IntPtr workAreasPtr);

                XGetWindowProperty(X11.Display, 
                    X11.DefaultRootWindow,
                    X11.Atoms[KnownAtoms._NET_CURRENT_DESKTOP],
                    0, long.MaxValue,
                    false,
                    X11.Atoms[KnownAtoms.CARDINAL],
                    out _,
                    out _,
                    out long items,
                    out _,
                    out IntPtr desktopPtr);
                
                if (items > 0)
                unsafe 
                {
                    int desktop = *(int*)desktopPtr;

                    if (workAreaCount >= 4 && desktop < (workAreaCount / 4))
                    {
                        nint* workAreas = (nint*)workAreasPtr;

                        int x = (int)workAreas[desktop * 4 + 0];
                        int y = (int)workAreas[desktop * 4 + 1];
                        int w = (int)workAreas[desktop * 4 + 2];
                        int h = (int)workAreas[desktop * 4 + 3];

                        area = Box2i.Intersect(area, new Box2i(x, y, x + w, y + h));
                    }
                }
            
                if (workAreasPtr != IntPtr.Zero)
                    XFree(workAreasPtr);

                if (desktopPtr != IntPtr.Zero)
                    XFree(desktopPtr);
            }
            else
            {
                Logger?.LogInfo("Could not get work area from _NET_WORKAREA. Reporting display area as work area.");
            }
        }

        /// <inheritdoc />
        public void GetRefreshRate(DisplayHandle handle, out float refreshRate)
        {
            unsafe
            {
                XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

                XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);
                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, xdisplay.Crtc);

                if (crtcInfo != null)
                {
                    XRRModeInfo* info = GetModeInfo(resources, crtcInfo->mode);
                    if (info != null)
                    {
                        if (info->DotClock != 0 && info->VTotal != 0 && info->HTotal != 0)
                        {
                            refreshRate = ((info->DotClock * 100) / (info->VTotal * info->HTotal)) / 100.0f;
                        }
                        else
                        {
                            // FIXME: Name or index of the display...
                            Logger?.LogWarning($"Could not get refresh rate. (crtc={xdisplay.Crtc.Id})");
                            refreshRate = 0;
                        }
                    }
                    else
                    {
                        // FIXME: Name or index of the display...
                        Logger?.LogWarning($"Could not find mode info for display. (crtc={xdisplay.Crtc.Id})");
                        refreshRate = 0;
                    }

                    XRRFreeCrtcInfo(crtcInfo);
                }
                else
                {
                    refreshRate = 0;
                    Logger?.LogError($"GetCrtcInfo returned null, could not get refresh rate for {xdisplay.Name} (crtc={xdisplay.Crtc})");
                }

                XRRFreeScreenResources(resources);
            }
        }

        /// <inheritdoc />
        public void GetDisplayScale(DisplayHandle handle, out float scaleX, out float scaleY)
        {
            // FIXME: We can read something like XrmGetResource "Xft.dpi" or use X11_XGetDefault(dpy, "Xft", "dpi")
            // But the question is how do we get the scale factor from just the DPI?
            scaleX = 1;
            scaleY = 1;
            Logger?.LogWarning("Display scale is always 1 on X11 atm.");
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the RandR <c>RRCrtc</c> associated with the display handle.
        /// </summary>
        /// <param name="handle">A handle to a display to get the <c>RRCrtc</c> from.</param>
        /// <returns>The <c>RRCrtc</c> associated with the display handle.</returns>
        public IntPtr GetRRCrtc(DisplayHandle handle)
        {
            XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

            // FIXME: XID is a `unsigned long int` and should be IntPtr in C#
            // but for now we have them as ulong.
            // - Noggin_bops 2024-03-06
            return (IntPtr)xdisplay.Crtc.Id;
        }

        /// <summary>
        /// Gets the RandR <c>RROutput</c> associated with the display handle.
        /// </summary>
        /// <param name="handle">A handle to a display to get the <c>RROutput</c> from.</param>
        /// <returns>The <c>RROutput</c> associated with the display handle.</returns>
        public IntPtr GetRROutput(DisplayHandle handle)
        {
            XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

            // FIXME: XID is a `unsigned long int` and should be IntPtr in C#
            // but for now we have them as ulong.
            // - Noggin_bops 2024-03-06
            return (IntPtr)xdisplay.Output.Id;
        }
    }
}
