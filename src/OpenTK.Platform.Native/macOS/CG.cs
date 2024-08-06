using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.macOS
{
    internal static unsafe class CG
    {
        private const string Lib = "/System/Library/Frameworks/ApplicationServices.framework/Versions/Current/ApplicationServices";

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGError CGGetActiveDisplayList(uint maxDisplays, uint* /* CGDirectDisplayID* */ activeDisplays, out uint displayCount);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* boolean_t */ CGDisplayIsAsleep(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint CGDisplayUnitNumber(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* boolean_t */ CGDisplayIsMain(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CGDisplayModeRef */ CGDisplayCopyDisplayMode(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void CGDisplayModeRelease(IntPtr /* CGDisplayModeRef */ mode);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CFArrayRef */ CGDisplayCopyAllDisplayModes(uint /* CGDirectDisplayID */ display, IntPtr /* CFDictionaryRef */ options);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern nint /* size_t */ CGDisplayModeGetWidth(IntPtr /* CGDisplayModeRef */ mode);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern nint /* size_t */ CGDisplayModeGetHeight(IntPtr /* CGDisplayModeRef */ mode);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double CGDisplayModeGetRefreshRate(IntPtr /* CGDisplayModeRef */ mode);

        // Deprecated, but we don't have any better options...
        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CFStringRef */ CGDisplayModeCopyPixelEncoding(IntPtr /* CGDisplayModeRef */ mode);

        // FIXME: Make return enum
        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern DisplayModeIOFlags CGDisplayModeGetIOFlags(IntPtr /* CGDisplayModeRef */ mode);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGRect CGDisplayBounds(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern nint /* size_t */ CGDisplayPixelsHigh(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern nint /* size_t */ CGDisplayPixelsWide(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGError CGWarpMouseCursorPosition(CGPoint newCursorPosition);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint /* CGDirectDisplayID */ CGMainDisplayID();

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGError CGAssociateMouseAndMouseCursorPosition([MarshalAs(UnmanagedType.Bool)] bool connected);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGError CGDisplayMoveCursorToPoint(uint /* CGDirectDisplayID */ display, CGPoint point);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CGColorSpaceRef */ CGColorSpaceCreateWithName(IntPtr /* CFStringRef */ name);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CGContextRef */ CGBitmapContextCreate(void* data, nuint width, nuint height, nuint bitsPerComponent, nuint bytesPerRow, IntPtr /* CGColorSpaceRef */ space, uint bitmapInfo);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void CGContextRelease(IntPtr /* CGContextRef */ c);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void CGContextTranslateCTM(IntPtr /* CGContextRef */ c, NFloat tx, NFloat ty);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void CGContextScaleCTM(IntPtr /* CGContextRef */ c, NFloat sx, NFloat sy);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CGImageRef */ CGImageCreate(
            nuint /* size_t */ width,
            nuint /* size_t */ height,
            nuint /* size_t */ bitsPerComponent,
            nuint /* size_t */ bitsPerPixel,
            nuint /* size_t */ bytesPerRow,
            IntPtr /* CGColorSpaceRef */ space,
            uint /* CGBitmapInfo */ bitmapInfo,
            IntPtr /* CGDataProviderRef */ provider,
            NFloat* /* const CGFloat* */ decode,
            bool shouldInterpolate,
            CGColorRenderingIntent intent);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CGDataProviderRef */ CGDataProviderCreateWithData(
            void* info,
            void* /* const void* */ data,
            nuint /* size_t */ size,
            // FIXME: Proper function pointer type...
            delegate* unmanaged[Cdecl]<void*, void*, nuint /* size_t */, void> /* CGDataProviderReleaseDataCallback */ releaseData);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void CGImageRelease(IntPtr /* CGImageRef */ image);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void CGDataProviderRelease(IntPtr /* CGDataProviderRef */ provider);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint /* CGOpenGLDisplayMask */ CGDisplayIDToOpenGLDisplayMask(uint /* CGDirectDisplayID */ display);

        /// <summary>
        /// Flips the Y coordinate from a bottom to top space to a top to bottom space, and vice versa.
        /// </summary>
        /// <param name="y">The y coordinate.</param>
        /// <returns>The flipped y coordinate.</returns>
        internal static float FlipYCoordinate(float y)
        {
            float height = (float)CGDisplayBounds(CGMainDisplayID()).size.y;
            return height - y;
        }

        /// <summary>
        /// Flips the Y coordinate from a bottom to top space to a top to bottom space, and vice versa.
        /// </summary>
        /// <param name="y">The y coordinate.</param>
        /// <returns>The flipped y coordinate.</returns>
        internal static NFloat FlipYCoordinate(NFloat y)
        {
            NFloat height = CGDisplayBounds(CGMainDisplayID()).size.y;
            return height - y;
        }

        /// <summary>
        /// Flips the Y coordinate from a bottom to top space to a top to bottom space, and vice versa.
        /// </summary>
        /// <param name="p">The coordinate to flip.</param>
        /// <returns>The flipped coordinate.</returns>
        internal static CGPoint FlipYCoordinate(CGPoint p)
        {
            NFloat height = CGDisplayBounds(CGMainDisplayID()).size.y;
            return new CGPoint(p.x, height - p.y);
        }

        /// <summary>
        /// Flips the Y coordinate from a bottom to top space to a top to bottom space, and vice versa.
        /// </summary>
        /// <param name="rect">The rectangle to flip.</param>
        /// <returns>The flipped rectangle.</returns>
        internal static CGRect FlipYCoordinate(CGRect rect)
        {
            // Get the upper left corner and invert that.
            return new CGRect(FlipYCoordinate(new CGPoint(rect.origin.x, rect.origin.y + rect.size.y)), rect.size);
        }
    }
}
