using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform.Implementations.Windows
{
    public class CursorComponent : ICursorComponent
    {
        public string Name => "Win32CursorComponent";

        public PalComponents Provides => PalComponents.MouseCursor;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MouseCursor)
            {
                throw new Exception("CursorComponent can only initialize the MouseCursor component.");
            }
        }

        public bool CanLoadFromFile => throw new NotImplementedException();

        public bool CanLoadSystemCursor => true;

        public bool CanScaleCursor => throw new NotImplementedException();

        public CursorHandle Create()
        {
            return new Win32CursorHandle();
        }

        public void Destroy(CursorHandle handle)
        {
            Win32CursorHandle win32handle = handle.As<Win32CursorHandle>(this);

            if (win32handle.IsShared)
            {
                bool success = Win32.DestroyCursor(win32handle.Cursor);
                if (success == false)
                {
                    throw new Win32Exception("DestroyCursor failed.");
                }
            }
        }

        public void GetSize(CursorHandle handle, out int width, out int height)
        {
            throw new NotImplementedException();
        }

        public void GetHotspot(CursorHandle handle, out int x, out int y)
        {
            throw new NotImplementedException();
        }

        public void GetImage(CursorHandle handle, Span<byte> image)
        {
            throw new NotImplementedException();
        }

        public void GetScale(CursorHandle handle, out float horizontal, out float vertical)
        {
            throw new NotImplementedException();
        }

        public void Load(CursorHandle handle, SystemCursorType systemCursor)
        {
            Win32CursorHandle win32handle = handle.As<Win32CursorHandle>(this);

            if (win32handle.Cursor != IntPtr.Zero)
            {
                // FIXME: Figure if we really need to destroy the cursor.
                // FIXME: We want to call win32 DestroyCursor() if this is a non-shared cursor.
                Destroy(handle);
            }

            IDC cursor;
            switch (systemCursor)
            {
                case SystemCursorType.Default:
                    cursor = IDC.Arrow;
                    break;
                case SystemCursorType.Loading:
                    cursor = IDC.Wait;
                    break;
                case SystemCursorType.Wait:
                    cursor = IDC.Wait;
                    break;
                case SystemCursorType.Cross:
                    cursor = IDC.Cross;
                    break;
                case SystemCursorType.Hand:
                    cursor = IDC.Hand;
                    break;
                case SystemCursorType.Help:
                    cursor = IDC.Help;
                    break;
                case SystemCursorType.TextBeam:
                    cursor = IDC.IBeam;
                    break;
                case SystemCursorType.Forbidden:
                    cursor = IDC.No;
                    break;
                case SystemCursorType.ArrowFourway:
                    cursor = IDC.SizeAll;
                    break;
                case SystemCursorType.ArrowNS:
                    cursor = IDC.SizeNS;
                    break;
                case SystemCursorType.ArrowEW:
                    cursor = IDC.SizeWE;
                    break;
                case SystemCursorType.ArrowNESW:
                    cursor = IDC.SizeNESW;
                    break;
                case SystemCursorType.ArrowNWSE:
                    cursor = IDC.SizeNWSE;
                    break;
                case SystemCursorType.ArrowUp:
                    cursor = IDC.UpArrow;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(systemCursor), (int)systemCursor, typeof(SystemCursorType));
            }

            win32handle.Cursor = Win32.LoadCursor(IntPtr.Zero, cursor);

            if (win32handle.Cursor == IntPtr.Zero)
            {
                throw new Win32Exception($"Could not load cursor '{cursor}'");
            }
        }

        public void Load(CursorHandle handle, int width, int height, ReadOnlySpan<byte> image)
        {
            throw new NotImplementedException();
        }

        public void Load(CursorHandle handle, string file)
        {
            throw new NotImplementedException();
        }

        public void Load(CursorHandle handle, Stream stream)
        {
            throw new NotImplementedException();
        }

        public void SetHotspot(CursorHandle handle, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void SetScale(CursorHandle handle, float horizontal, float vertical)
        {
            throw new NotImplementedException();
        }
    }
}
