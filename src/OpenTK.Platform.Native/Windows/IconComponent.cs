using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
    internal class IconComponent : IIconComponent
    {
        public string Name => "Win32IconComponent";

        public PalComponents Provides => PalComponents.WindowIcon;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.WindowIcon)
            {
                throw new Exception("IconComponent can only initialize the WindowIcon component.");
            }
        }

        public bool CanLoadFile => throw new NotImplementedException();

        public bool CanLoadSystemIcon => throw new NotImplementedException();

        public bool HasMipmaps => throw new NotImplementedException();

        public IconHandle Create()
        {
            return new HIcon();
        }

        public void Destroy(IconHandle handle)
        {
            HIcon hicon = handle.As<HIcon>(this);

            
        }

        public void GenerateMipmaps(IconHandle handle)
        {
            throw new NotImplementedException();
        }

        public void GetDimensions(IconHandle handle, out int width, out int height)
        {
            throw new NotImplementedException();
        }

        public void GetDimensions(IconHandle handle, int level, out int width, out int height)
        {
            throw new NotImplementedException();
        }

        public void GetBitmap(IconHandle handle, Span<byte> data)
        {
            throw new NotImplementedException();
        }

        public void GetBitmap(IconHandle handle, int level, Span<byte> data)
        {
            throw new NotImplementedException();
        }

        public int GetBitmapSize(IconHandle handle)
        {
            throw new NotImplementedException();
        }

        public int GetBitmapSize(IconHandle handle, int level)
        {
            throw new NotImplementedException();
        }

        public void Load(IconHandle handle, int width, int height, ReadOnlySpan<byte> data)
        {
            throw new NotImplementedException();
        }

        public void Load(IconHandle handle, int width, int height, ReadOnlySpan<byte> data, int level)
        {
            throw new NotImplementedException();
        }

        public void Load(IconHandle handle, string file)
        {
            throw new NotImplementedException();
        }

        public void Load(IconHandle handle, Stream stream)
        {
            throw new NotImplementedException();
        }

        public void Load(IconHandle handle, SystemIconType name)
        {
            throw new NotImplementedException();
        }
    }
}
