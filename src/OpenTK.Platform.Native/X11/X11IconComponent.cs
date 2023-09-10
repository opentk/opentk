using System;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;

namespace OpenTK.Platform.Native.X11
{
    public class X11IconComponent : IIconComponent
    {
        public struct IconImage
        {
            public int Width;
            public int Height;
            public byte[] Data;

            public IconImage(int width, int height, byte[] data)
            {
                Width = width;
                Height = height;
                Data = data;
            }
        }

        public string Name => nameof(X11IconComponent);

        public PalComponents Provides => PalComponents.WindowIcon;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }
        }

        public bool CanLoadSystemIcon => false;

        public IconHandle Create(SystemIconType systemIcon)
        {
            // FIXME: Is there some way to get system cursors?
            throw new NotSupportedException("X11 doesn't support system icons!");
        }

        public IconHandle Create(int width, int height, ReadOnlySpan<byte> data)
        {
            IconImage image = new IconImage(width, height, data.ToArray());
            IconImage[] images = new IconImage[1] { image };

            XIconHandle xicon = new XIconHandle(width, height, images);
            
            return xicon;
        }

        /// <summary>
        /// Creates a _NET_WM_ICON from a number of images.
        /// This is useful for specifying icon images at multiple resolutions.
        /// </summary>
        /// <param name="width">The width of the icon to report in <see cref="GetSize"/>.</param>
        /// <param name="height">The height of the icon to report in <see cref="GetSize"/>.</param>
        /// <param name="images">The icon images.</param>
        /// <returns>A handle to the created icon.</returns>
        // FIXME: Should we pass a width and height or what should we do?
        public IconHandle Create(int width, int height, IconImage[] images)
        {
            XIconHandle xicon = new XIconHandle(width, height, images);

            return xicon;
        }

        public void Destroy(IconHandle handle)
        {
            XIconHandle xicon = handle.As<XIconHandle>(this);

            xicon.Images = null;
            xicon.Width = -1;
            xicon.Height = -1;
        }

        public void GetSize(IconHandle handle, out int width, out int height)
        {
            XIconHandle xicon = handle.As<XIconHandle>(this);

            width = xicon.Width;
            height = xicon.Height;
        }
    }
}