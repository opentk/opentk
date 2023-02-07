using OpenTK.Core.Platform;
using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OpenTK.Platform.Native.Windows
{
    public class KeyboardComponent : IKeyboardComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32KeyboardComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.KeyboardInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.KeyboardInput)
            {
                throw new Exception("KeyboardComponent can only initialize the KeyboardInput component.");
            }
        }

        /// <inheritdoc/>
        public bool SupportsLayouts => true;

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public string GetActiveKeyboardLayout(WindowHandle? handle = null)
        {
            StringBuilder builder = new StringBuilder();
            builder.EnsureCapacity(Win32.KL_NAMELENGTH);
            Win32.GetKeyboardLayoutName(builder);
            string layoutName = builder.ToString();

            return LayoutNameFromKeyboardLayoutName(layoutName);
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public void BeginIme(WindowHandle window)
        {
            if (_imeActive)
            {
                Logger?.LogWarning($"IME input is already active. Did you forget to call {nameof(EndIme)}?");
            }

            _imeActive = true;
        }

        // FIXME: Make width and height optional.
        /// <inheritdoc/>
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
                    dwStyle = CFS.ForcePosition,
                    ptCurrentPos = new Win32.POINT(x, y),
                    rcArea = default
                };

                Win32.ImmSetCompositionWindow(hmic, in compForm);
                Win32.ImmReleaseContext(hwnd.HWnd, hmic);
            }
        }

        // FIXME: API for getting the candidate list.
        /// <inheritdoc/>
        public void EndIme(WindowHandle window)
        {
            if (_imeActive == false)
            {
                Logger?.LogWarning($"IME input is not active. Are you calling {nameof(EndIme)} twice?");
            }

            _imeActive = false;
        }

        // Continue from "Keyboard UpArrow"
        // https://learn.microsoft.com/en-au/windows/win32/inputdev/about-keyboard-input?redirectedfrom=MSDN#_win32_Keyboard_Input_Model
        // - 2023-02-07 NogginBops

        static readonly Scancode[] ScancodeLookup = new Scancode[256]
        {
            // 0x00 - 0x07
            0, Scancode.Escape, Scancode.D1, Scancode.D2, Scancode.D3, Scancode.D4, Scancode.D5, Scancode.D6,
            // 0x08 - 0x0F
            Scancode.D7, Scancode.D8, Scancode.D9, Scancode.D0, Scancode.Dash, Scancode.Equals, Scancode.Backspace, Scancode.Tab,
            // 0x10 - 0x17
            Scancode.Q, Scancode.W, Scancode.E, Scancode.R, Scancode.T, Scancode.Y, Scancode.U, Scancode.I,
            // 0x18 - 0x1F
            Scancode.O, Scancode.P, Scancode.LeftBrace, Scancode.RightBrace, Scancode.Return, 0, Scancode.A, Scancode.S,
            // 0x20 - 0x27
            Scancode.D, Scancode.F, Scancode.G, Scancode.H, Scancode.J, Scancode.K, Scancode.L, Scancode.SemiColon,
            // 0x28 - 0x2F
            Scancode.LeftApostrophe, Scancode.GraveAccent, Scancode.Pipe, Scancode.NonUS, Scancode.Z, Scancode.X, Scancode.C, Scancode.V,
            // 0x30 - 0x37
            Scancode.B, Scancode.N, Scancode.M, Scancode.Comma, Scancode.Period, Scancode.QuestionMark, 0, 0,
            // 0x38 - 0x3F
            0, Scancode.Spacebar, Scancode.CapsLock, Scancode.F1, Scancode.F2, Scancode.F3, Scancode.F4, Scancode.F5,
            // 0x40 - 0x47
            Scancode.F6, Scancode.F7, Scancode.F8, Scancode.F9, Scancode.F10, Scancode.Pause, Scancode.ScrollLock, Scancode.Home,
            // 0x48 - 0x4F
            Scancode.UpArrow, Scancode.PageUp, 0, Scancode.LeftAlt, 0, Scancode.RightArrow, 0, Scancode.End,
            // 0x50 - 0x57
            Scancode.DownArrow, Scancode.PageDown, Scancode.Insert, Scancode.Delete, 0, 0, 0, Scancode.F11,
            // 0x58 - 0x5F
            Scancode.F12, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0,
        };

        internal static Scancode ToScancode(int winScancode, bool extended)
        {
            Scancode code = ScancodeLookup[winScancode];
            Console.WriteLine($"Scancode {code}, Win: 0x{winScancode:X}");
            return code;
        }
    }
}
