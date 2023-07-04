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
            XIconHandle xicon = new XIconHandle();

            IconImage image;
            image.Width = width;
            image.Height = height;
            // FIXME: Is data in the right format?
            image.Data = data.ToArray();

            xicon.Width = width;
            xicon.Height = height;
            xicon.Images = new IconImage[1] { image };

            return xicon;
        }

        public IconHandle Create(int width, int height, IconImage[] images)
        {
            XIconHandle xicon = new XIconHandle();

            xicon.Width = width;
            xicon.Height = height;
            xicon.Images = images;

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
