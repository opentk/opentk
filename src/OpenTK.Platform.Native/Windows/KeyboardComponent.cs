using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public bool SupportsLayouts => true;

        public bool SupportsIme => true;

        // FIXME: Better name!
        private string LayoutNameFromKeyboardLayoutName(string layoutName)
        {
            // FIXME: Read "Layout Display Name" resource instead of "Layout Text".

            const string LAYOUTS_REGISTRY_PATH = @"SYSTEM\ControlSet001\Control\Keyboard Layouts";

            int status;

            status = Win32.RegOpenKeyEx((IntPtr)PredefinedKeys.HKEY_LOCAL_MACHINE, LAYOUTS_REGISTRY_PATH, 0, AccessMask.KeyRead, out IntPtr layoutsKey);
            if (status != 0)
            {
                // FIXME: Good error message
                throw new Exception();
            }

            status = Win32.RegOpenKeyEx(layoutsKey, layoutName, 0, AccessMask.KeyRead, out IntPtr layoutKey);
            if (status != 0)
            {
                // FIXME: Good error message
                throw new Exception();
            }

            // Read the "Layout Text" to get the layout name
            uint dataSize = 0;
            status = Win32.RegGetValue(layoutKey, null, "Layout Text", RRF.TypeRegSZ, out RegValueType _, Span<byte>.Empty, ref dataSize);
            if (status != 0)
            {
                // FIXME: Good error message
                throw new Exception();
            }

            // FIXME: Maybe not allocate on the stack if it's too big?
            Span<byte> data = stackalloc byte[(int)dataSize];
            status = Win32.RegGetValue(layoutKey, null, "Layout Text", RRF.TypeRegSZ, out RegValueType _, data, ref dataSize);
            if (status != 0)
            {
                // FIXME: Good error message
                throw new Exception();
            }

            // Convert to string and trim away the \0 characters at the end.
            string layoutText = Encoding.Unicode.GetString(data).TrimEnd('\0');

            return layoutText;
        }

        public string GetActiveKeyboardLayout(WindowHandle? handle = null)
        {
            StringBuilder builder = new StringBuilder();
            builder.EnsureCapacity(Win32.KL_NAMELENGTH);
            Win32.GetKeyboardLayoutName(builder);
            string layoutName = builder.ToString();

            return LayoutNameFromKeyboardLayoutName(layoutName);
        }

        public string[] GetAvailableKeyboardLayouts()
        {
            int count = Win32.GetKeyboardLayoutList(0, Span<IntPtr>.Empty);
            Span<IntPtr> layouts = stackalloc IntPtr[count];

            int read = Win32.GetKeyboardLayoutList(count, layouts);
            if (read == 0)
            {
                throw new Win32Exception("GetKeyboardLayoutList failed");
            }

            IntPtr oldLayout = Win32.GetKeyboardLayout(0);

            string[] result = new string[count];
            for (int i = 0; i < layouts.Length; i++)
            {
                Win32.ActivateKeyboardLayout(layouts[i], 0);

                StringBuilder builder = new StringBuilder();
                builder.EnsureCapacity(Win32.KL_NAMELENGTH);
                Win32.GetKeyboardLayoutName(builder);
                string layoutName = builder.ToString();

                result[i] = LayoutNameFromKeyboardLayoutName(layoutName);
            }
            Win32.ActivateKeyboardLayout(oldLayout, 0);

            return result;
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
                // FIXME: Make the entire rect
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
