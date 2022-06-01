using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
    public class KeyboardComponent : IKeyboardComponent
    {
        public string Name => "Win32KeyboardComponent";

        public PalComponents Provides => PalComponents.KeyboardInput;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.KeyboardInput)
            {
                throw new Exception("KeyboardComponent can only initialize the KeyboardInput component.");
            }
        }

        public bool SupportsLayouts => throw new NotImplementedException();

        public bool SupportsIme => throw new NotImplementedException();

        public string GetActiveKeyboardLayout(WindowHandle handle = null)
        {
            throw new NotImplementedException();
        }

        public string[] GetAvailableKeyboardLayouts()
        {
            throw new NotImplementedException();
        }

        bool _imeActive;

        public void BeginIme(WindowHandle window)
        {
            // FIXME: Check that we've not already begun ime
            _imeActive = true;
        }

        // FIXME: Make width and height optional.
        public void SetImeRectangle(WindowHandle window, int x, int y, int width, int height)
        {
            HWND hwnd = window.As<HWND>(this);

            if (_imeActive == false) throw new InvalidOperationException("Call BeginIme before calling SetImeRectangle!");

            IntPtr hmic = Win32.ImmGetContext(hwnd.HWnd);
            if (hmic != IntPtr.Zero)
            {
                Win32.COMPOSITIONFORM compForm = new Win32.COMPOSITIONFORM()
                {
                    dwStyle = CFS.CFS_FORCE_POSITION,
                    ptCurrentPos = new Win32.POINT(x, y),
                    rcArea = default
                };

                Win32.ImmSetCompositionWindow(hmic, in compForm);
                Win32.ImmReleaseContext(hwnd.HWnd, hmic);
            }
        }

        public void EndIme(WindowHandle window)
        {
            // Check so that we are not double closing ime
            _imeActive = false;
        }
    }
}
