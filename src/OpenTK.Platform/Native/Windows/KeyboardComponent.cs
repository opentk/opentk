using OpenTK.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace OpenTK.Platform.Native.Windows
{
    public class KeyboardComponent : IKeyboardComponent
    {
        // FIXME: We should change the design
        private static KeyboardComponent? Instance;

        // FIXME: API for disabling native IME window? See what SDL does.

        /// <inheritdoc/>
        public string Name => "Win32KeyboardComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.KeyboardInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        private Key[] Keymap = new Key[256];

        private static bool[] KeyboardState = new bool[256];

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            // FIXME: Signleton, we should change the design!
            Instance = this;

            UpdateKeymap();

            // Resources for custom IME window:
            // https://learn.microsoft.com/en-us/windows/win32/dxtecharts/using-an-input-method-editor-in-a-game
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            if (Instance == this)
                Instance = null;
        }

        private void UpdateKeymap()
        {
            // Loop through all scancodes and get their keys.
            Scancode[] scancodes = Enum.GetValues<Scancode>();
            for (int i = 0; i < scancodes.Length; i++)
            {
                if (scancodes[i] == Scancode.Unknown) continue;

                // Find the windows VK_ that corresponds to this scancode
                int index = Array.IndexOf(ScancodeLookup, scancodes[i]);
                int indexExt = Array.IndexOf(ScancodeLookupExt, scancodes[i]);

                Key key;
                if (index != -1)
                {
                    uint res = Win32.MapVirtualKey((uint)index, MAPVK.ScancodeToVirtualKeyEx);
                    if (res == 0)
                    {
                        Logger?.LogDebug($"Scancode {scancodes[i]} (Win32 Scancode: 0x{index:X}) didn't have mapping!");
                    }
                    key = res == 0 ? Key.Unknown : ToKey(index, (VK)res, false);
                }
                else if (indexExt != -1)
                {
                    uint res = Win32.MapVirtualKey((uint)indexExt | 0xe000, MAPVK.ScancodeToVirtualKeyEx);
                    if (res == 0)
                    {
                        Logger?.LogDebug($"Scancode {scancodes[i]} (Extended Win32 Scancode: 0x{indexExt:X}) didn't have ex mapping!");
                    }
                    key = res == 0 ? Key.Unknown : ToKey(indexExt, (VK)res, true);
                }
                else
                {
                    // Media keys don't have scancodes, so we map them here.
                    switch (scancodes[i])
                    {
                        case Scancode.PlayPause:         key = Key.PlayPause;     break;
                        case Scancode.ScanNextTrack:     key = Key.NextTrack;     break;
                        case Scancode.ScanPreviousTrack: key = Key.PreviousTrack; break;
                        case Scancode.Stop:              key = Key.Stop;          break;
                        case Scancode.VolumeIncrement:   key = Key.VolumeUp;      break;
                        case Scancode.VolumeDecrement:   key = Key.VolumeDown;    break;
                        case Scancode.Mute:              key = Key.Mute;          break;
                        default:
                            Logger?.LogDebug($"Scancode {scancodes[i]} is not mapped in the scancode lookup table!");
                            key = Key.Unknown;
                            break;
                    }
                }

                Keymap[(int)scancodes[i]] = key;
            }
        }

        internal static void KeyboardLayoutChange(WindowHandle handle, IntPtr hKL)
        {
            // FIXME: We shouldn't need to call this statically...
            if (Instance != null)
            {
                Instance.UpdateKeymap();

                // FIXME: Make a platform independent language name/id!
                int langid = (int)(hKL.ToInt64() & 0x0000FFFF);
                int lcid = (int)SortOrderIdentifier.SORT_DEFAULT << 16 | langid;
                StringBuilder localeName = new StringBuilder(Win32.LOCALE_NAME_MAX_LENGTH);
                Win32.LCIDToLocaleName(lcid, localeName, localeName.Capacity, 0);


                int length = Win32.GetLocaleInfoEx(localeName, LCType.SLocalizedDisplayName, null, 0);
                StringBuilder displayName = new StringBuilder(length);
                Win32.GetLocaleInfoEx(localeName, LCType.SLocalizedDisplayName, displayName, displayName.Capacity);

                string layoutName = Instance.GetHKLLayoutName(hKL);
                string layoutDisplayName = Instance.LayoutDisplayNameFromKeyboardLayoutName(layoutName);

                EventQueue.Raise(handle, PlatformEventType.InputLanguageChanged, new InputLanguageChangedEventArgs(layoutName, layoutDisplayName, localeName.ToString(), displayName.ToString()));
            }
        }

        /// <returns>If the state of the key changed.</returns>
        internal static bool KeyStateChanged(Scancode code, bool pressed)
        {
            bool prev = KeyboardState[(int)code];
            KeyboardState[(int)code] = pressed;
            return prev != pressed;
        }

        /// <inheritdoc/>
        public bool SupportsLayouts => true;

        /// <inheritdoc/>
        public bool SupportsIme => true;

        private string LayoutDisplayNameFromKeyboardLayoutName(string layoutName)
        {
            const string LAYOUTS_REGISTRY_PATH = @"SYSTEM\CurrentControlSet\Control\Keyboard Layouts";

            int status;

            status = Win32.RegOpenKeyEx((UIntPtr)PredefinedKeys.HKEY_LOCAL_MACHINE, LAYOUTS_REGISTRY_PATH, 0, AccessMask.KeyRead, out UIntPtr layoutsKey);
            if (status != 0)
            {
                throw new Exception($"RegOpenKeyEx (\"HKEY_LOCAL_MACHINE\\{LAYOUTS_REGISTRY_PATH}\") error: 0x{status:X8}");
            }

            status = Win32.RegOpenKeyEx(layoutsKey, layoutName, 0, AccessMask.KeyRead, out UIntPtr layoutKey);
            if (status != 0)
            {
                throw new Exception($"RegOpenKeyEx (\"{layoutName}\") error: 0x{status:X8}");
            }

            // Read the "Layout Text" to get the layout name
            uint dataSize = 0;
            status = Win32.RegGetValue(layoutKey, null, "Layout Display Name", RRF.TypeRegSZ, out RegValueType _, Span<byte>.Empty, ref dataSize);
            if (status != 0)
            {
                throw new Exception($"RegGetValue (\"Layout Display Name\") error: 0x{status:X8}");
            }

            // FIXME: Maybe not allocate on the stack if it's too big?
            Span<char> data = stackalloc char[(int)(dataSize / sizeof(char))];
            status = Win32.RegGetValue(layoutKey, null, "Layout Display Name", RRF.TypeRegSZ, out RegValueType _, data, ref dataSize);
            if (status != 0)
            {
                throw new Exception($"RegGetValue (\"Layout Display Name\") error: 0x{status:X8}");
            }

            // We use the same size as Winforms does and hope that that isn't a problem...
            // https://github.com/dotnet/winforms/blob/d2160cfd081d5a34be03a2bd9c7ce9cbdcc38c09/src/System.Windows.Forms/src/System/Windows/Forms/InputLanguage.cs#L258
            // - Noggin_bops 2023-04-18
            Span<char> buffer = stackalloc char[512];
            unsafe
            {
                fixed (char* source = data)
                fixed (char* bufferPtr = buffer)
                {
                    int result = (int)Win32.SHLoadIndirectString(source, bufferPtr, (uint)buffer.Length, null);
                    Marshal.ThrowExceptionForHR(result);
                }
            }

            buffer = buffer.SliceAtFirstNull();
            string displayName = new string(buffer);

            return displayName;
        }

        private string GetHKLLayoutName(IntPtr hKL)
        {
            // FIXME: Maybe error check?
            IntPtr oldLayout = Win32.ActivateKeyboardLayout(hKL, 0);

            StringBuilder builder = new StringBuilder();
            builder.EnsureCapacity(Win32.KL_NAMELENGTH);
            Win32.GetKeyboardLayoutName(builder);

            Win32.ActivateKeyboardLayout(oldLayout, 0);

            return builder.ToString();
        }

        /// <inheritdoc/>
        public string GetActiveKeyboardLayout(WindowHandle? handle = null)
        {
            // FIXME: The window doesn't matter here??
            // Can window have differing layouts?

            StringBuilder builder = new StringBuilder();
            builder.EnsureCapacity(Win32.KL_NAMELENGTH);
            Win32.GetKeyboardLayoutName(builder);
            string layoutName = builder.ToString();

            return LayoutDisplayNameFromKeyboardLayoutName(layoutName);
        }

        /// <inheritdoc/>
        /// <remarks>This function is expensive and should be cached if possible.</remarks>
        public string[] GetAvailableKeyboardLayouts()
        {
            int count = Win32.GetKeyboardLayoutList(0, Span<IntPtr>.Empty);
            Span<IntPtr> layouts = stackalloc IntPtr[count];

            int read = Win32.GetKeyboardLayoutList(count, layouts);
            if (read == 0)
            {
                throw new Win32Exception();
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

                result[i] = LayoutDisplayNameFromKeyboardLayoutName(layoutName);
            }
            Win32.ActivateKeyboardLayout(oldLayout, 0);

            return result;
        }

        /// <inheritdoc/>
        public Scancode GetScancodeFromKey(Key key)
        {
            int index = Array.IndexOf(Keymap, key);
            return index == -1 ? Scancode.Unknown : (Scancode)index;
        }

        /// <inheritdoc/>
        public Key GetKeyFromScancode(Scancode scancode)
        {
            return Keymap[(int)scancode];
        }

        /// <inheritdoc/>
        public unsafe void GetKeyboardState(bool[] keyboardState)
        {
            // Copy over the current keyboard state.
            Array.Fill(keyboardState, false);
            Array.Copy(KeyboardState, keyboardState, Math.Min(KeyboardState.Length, keyboardState.Length));
            return;
        }

        internal static KeyModifier GetKeyboardModifiersInternal()
        {
            KeyModifier modifiers = KeyModifier.None;
            if ((Win32.GetKeyState(VK.CapsLock) & 0x0001) != 0)
                modifiers |= KeyModifier.CapsLock;
            if ((Win32.GetKeyState(VK.NumLock) & 0x0001) != 0)
                modifiers |= KeyModifier.NumLock;
            if ((Win32.GetKeyState(VK.ScrollLock) & 0x0001) != 0)
                modifiers |= KeyModifier.ScrollLock;

            if ((Win32.GetKeyState(VK.LeftShift) & 0x8000) != 0)
                modifiers |= KeyModifier.LeftShift;
            if ((Win32.GetKeyState(VK.RightShift) & 0x8000) != 0)
                modifiers |= KeyModifier.RightShift;
            // FIXME: This is going to be true if we have Alt-gr pressed
            if ((Win32.GetKeyState(VK.LeftControl) & 0x8000) != 0 && KeyboardState[(int)Scancode.LeftControl])
                modifiers |= KeyModifier.LeftControl;
            if ((Win32.GetKeyState(VK.RightControl) & 0x8000) != 0)
                modifiers |= KeyModifier.RightControl;
            if ((Win32.GetKeyState(VK.LeftMenu) & 0x8000) != 0)
                modifiers |= KeyModifier.LeftAlt;
            if ((Win32.GetKeyState(VK.RightMenu) & 0x8000) != 0)
                modifiers |= KeyModifier.RightAlt;
            if ((Win32.GetKeyState(VK.LeftWindows) & 0x8000) != 0)
                modifiers |= KeyModifier.LeftGUI;
            if ((Win32.GetKeyState(VK.RightWindows) & 0x8000) != 0)
                modifiers |= KeyModifier.RightGUI;

            if (modifiers.HasFlag(KeyModifier.LeftShift) || modifiers.HasFlag(KeyModifier.RightShift))
                modifiers |= KeyModifier.Shift;
            if (modifiers.HasFlag(KeyModifier.LeftControl) || modifiers.HasFlag(KeyModifier.RightControl))
                modifiers |= KeyModifier.Control;
            if (modifiers.HasFlag(KeyModifier.LeftAlt) || modifiers.HasFlag(KeyModifier.RightAlt))
                modifiers |= KeyModifier.Alt;
            if (modifiers.HasFlag(KeyModifier.LeftGUI) || modifiers.HasFlag(KeyModifier.RightGUI))
                modifiers |= KeyModifier.GUI;

            return modifiers;
        }

        /// <inheritdoc/>
        public KeyModifier GetKeyboardModifiers()
        {
            return GetKeyboardModifiersInternal();
        }

        private bool _imeActive;

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
        public void SetImeRectangle(WindowHandle window, float x, float y, float width, float height)
        {
            HWND hwnd = window.As<HWND>(this);

            IntPtr hmic = Win32.ImmGetContext(hwnd.HWnd);
            if (hmic != IntPtr.Zero)
            {
                // FIXME: Make the entire rect
                Win32.COMPOSITIONFORM compForm = new Win32.COMPOSITIONFORM()
                {
                    dwStyle = CFS.ForcePosition,
                    ptCurrentPos = new Win32.POINT((int)x, (int)y),
                    rcArea = default
                };

                Win32.ImmSetCompositionWindow(hmic, in compForm);
                Win32.ImmReleaseContext(hwnd.HWnd, hmic);
            }
        }

        /// <inheritdoc/>
        public void EndIme(WindowHandle window)
        {
            if (_imeActive == false)
            {
                Logger?.LogWarning($"IME input is not active. Are you calling {nameof(EndIme)} twice?");
            }

            _imeActive = false;
        }

        // The scancode lookups are derived from the following list of scan codes
        // https://learn.microsoft.com/en-au/windows/win32/inputdev/about-keyboard-input?redirectedfrom=MSDN#scan-codes
        static readonly Scancode[] ScancodeLookup = new Scancode[256]
        {
            // 0x00 - 0x07
            0, Scancode.Escape, Scancode.D1, Scancode.D2, Scancode.D3, Scancode.D4, Scancode.D5, Scancode.D6,
            // 0x08 - 0x0F
            Scancode.D7, Scancode.D8, Scancode.D9, Scancode.D0, Scancode.Dash, Scancode.Equals, Scancode.Backspace, Scancode.Tab,
            // 0x10 - 0x17
            Scancode.Q, Scancode.W, Scancode.E, Scancode.R, Scancode.T, Scancode.Y, Scancode.U, Scancode.I,
            // 0x18 - 0x1F
            Scancode.O, Scancode.P, Scancode.LeftBrace, Scancode.RightBrace, Scancode.Return, Scancode.LeftControl, Scancode.A, Scancode.S,
            // 0x20 - 0x27
            Scancode.D, Scancode.F, Scancode.G, Scancode.H, Scancode.J, Scancode.K, Scancode.L, Scancode.SemiColon,
            // 0x28 - 0x2F
            Scancode.LeftApostrophe, Scancode.GraveAccent, Scancode.LeftShift, Scancode.Pipe, Scancode.Z, Scancode.X, Scancode.C, Scancode.V,
            // 0x30 - 0x37
            Scancode.B, Scancode.N, Scancode.M, Scancode.Comma, Scancode.Period, Scancode.QuestionMark, Scancode.RightShift, Scancode.KeypadStar,
            // 0x38 - 0x3F
            Scancode.LeftAlt, Scancode.Spacebar, Scancode.CapsLock, Scancode.F1, Scancode.F2, Scancode.F3, Scancode.F4, Scancode.F5,
            // 0x40 - 0x47
            Scancode.F6, Scancode.F7, Scancode.F8, Scancode.F9, Scancode.F10, Scancode.Pause, Scancode.ScrollLock, Scancode.Keypad7,
            // 0x48 - 0x4F
            Scancode.Keypad8, Scancode.Keypad9, Scancode.KeypadDash, Scancode.Keypad4, Scancode.Keypad5, Scancode.Keypad6, Scancode.KeypadPlus, Scancode.Keypad1,
            // 0x50 - 0x57
            Scancode.Keypad2, Scancode.Keypad3, Scancode.Keypad0, Scancode.KeypadPeriod, Scancode.PrintScreen, 0, Scancode.NonUSSlashBar, Scancode.F11,
            // 0x58 - 0x5F
            Scancode.F12, Scancode.KeypadEquals, 0, 0, Scancode.International6, 0, 0, 0,
            // 0x60 - 0x67
            0, 0, 0, 0, Scancode.F13, Scancode.F14, Scancode.F15, Scancode.F16,
            // 0x68 - 0x6F
            Scancode.F17, Scancode.F18, Scancode.F19, Scancode.F20, Scancode.F21, Scancode.F22, Scancode.F23, 0,
            // 0x70 - 0x77
            Scancode.International2, Scancode.LANG2, Scancode.LANG1, Scancode.International1, 0, 0, Scancode.LANG5, Scancode.LANG4,
            // 0x78 - 0x7F
            Scancode.LANG3, Scancode.International4, 0, Scancode.International5, 0, Scancode.International3, Scancode.KeypadComma, 0,
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

        // FIXME: Should we add stuff like "AC Search" and "AL Calculator" to the scancodes?
        static readonly Scancode[] ScancodeLookupExt = new Scancode[256]
        {
            // 0x00 - 0x07
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x08 - 0x0F
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x10 - 0x17
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x18 - 0x1F
            0, 0, 0, 0, Scancode.KeypadEnter, Scancode.RightControl, 0, 0,
            // 0x20 - 0x27
            0, 0, Scancode.PlayPause, 0, 0, 0, 0, 0,
            // 0x28 - 0x2F
            0, 0, Scancode.RightShift, 0, 0, 0, 0, 0,
            // 0x30 - 0x37
            0, 0, 0, 0, 0, Scancode.KeypadForwardSlash, 0, Scancode.PrintScreen,
            // 0x38 - 0x3F
            Scancode.RightAlt, 0, 0, 0, 0, 0, 0, 0,
            // 0x40 - 0x47
            0, 0, 0, 0, 0, Scancode.NumLock, Scancode.Pause, Scancode.Home,
            // 0x48 - 0x4F
            Scancode.UpArrow, Scancode.PageUp, 0, Scancode.LeftArrow, 0, Scancode.RightArrow, 0, Scancode.End,
            // 0x50 - 0x57
            Scancode.DownArrow, Scancode.PageDown, Scancode.Insert, Scancode.Delete, 0, 0, 0, 0,
            // 0x58 - 0x5F
            0, 0, 0, Scancode.LeftGUI, Scancode.RightGUI, Scancode.Application, Scancode.SystemPowerDown, Scancode.SystemSleep,
            // 0x60 - 0x67
            0, 0, 0, Scancode.SystemWakeUp, 0, 0, 0, 0,
            // 0x68 - 0x6F
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x70 - 0x77
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x78 - 0x7F
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

        // https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
        static readonly Key[] KeyLookup = new Key[256]
        {
            // 0x00 - 0x07
            0, 0, 0, Key.PauseBreak, 0, 0, 0, 0,
            // 0x08 - 0x0F
            Key.Backspace, Key.Tab, 0, 0, 0, Key.Return, 0, 0,
            // 0x10 - 0x17
            0, 0, 0, Key.PauseBreak, Key.CapsLock, 0, 0, 0,
            // 0x18 - 0x1F
            0, 0, 0, Key.Escape, 0, 0, 0, 0,
            // 0x20 - 0x27
            Key.Space, Key.PageUp, Key.PageDown, Key.End, Key.Home, Key.LeftArrow, Key.UpArrow, Key.RightArrow,
            // 0x28 - 0x2F
            Key.DownArrow, 0, 0, 0, Key.PrintScreen, Key.Insert, Key.Delete, Key.Help,
            // 0x30 - 0x37
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x38 - 0x3F
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x40 - 0x47
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x48 - 0x4F
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x50 - 0x57
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x58 - 0x5F
            0, 0, 0, Key.LeftGUI, Key.RightGUI, Key.Application, 0, Key.Sleep,
            // 0x60 - 0x67
            Key.Keypad0, Key.Keypad1, Key.Keypad2, Key.Keypad3, Key.Keypad4, Key.Keypad5, Key.Keypad6, Key.Keypad7,
            // 0x68 - 0x6F
            Key.Keypad8, Key.Keypad9, Key.KeypadMultiply, Key.KeypadAdd, Key.KeypadSeparator, Key.KeypadSubtract, Key.KeypadDecimal, Key.KeypadDivide,
            // 0x70 - 0x77
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x78 - 0x7F
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x80 - 0x87
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x88 - 0x8F
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0x90 - 0x97
            Key.NumLock, Key.ScrollLock, 0, 0, 0, 0, 0, 0,
            // 0x98 - 0x9F
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0xA0 - 0xA7
            Key.LeftShift, Key.RightShift, Key.LeftControl, Key.RightControl, Key.LeftAlt, Key.RightAlt, 0, 0,
            // 0xA8 - 0xAF
            0, 0, 0, 0, 0, Key.Mute, Key.VolumeDown, Key.VolumeUp,
            // 0xB0 - 0xB7
            Key.NextTrack, Key.PreviousTrack, Key.Stop, Key.PlayPause, 0, 0, 0, 0,
            // 0xB8 - 0xBF
            0, 0, Key.OEM1, Key.Plus, Key.Comma, Key.Minus, Key.Period, Key.OEM2,
            // 0xC0 - 0xC7
            Key.OEM3, 0, 0, 0, 0, 0, 0, 0,
            // 0xC8 - 0xCF
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0xD0 - 0xD7
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0xD8 - 0xDF
            0, 0, 0, Key.OEM4, Key.OEM5, Key.OEM6, Key.OEM7, Key.OEM8,
            // 0xE0 - 0xE7
            0, 0, Key.OEM102, 0, 0, 0, 0, 0,
            // 0xE8 - 0xEF
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0xF0 - 0xF7
            0, 0, 0, 0, 0, 0, 0, 0,
            // 0xF8 - 0xFF
            0, 0, 0, 0, 0, 0, 0, 0,
        };

        internal static Scancode ToScancode(int winScancode, VK virtualKey, bool extended)
        {
            // FIXME: Pipe and NonUS is the same scancode, do we do anything about it?

            // Some keys like the media keys don't get scancodes in their messages
            // so we fix those here.
            switch (virtualKey)
            {
                case VK.MediaPlayPause:
                    return Scancode.PlayPause;
                case VK.MediaNextTrack:
                    return Scancode.ScanNextTrack;
                case VK.MediaPrevTrack:
                    return Scancode.ScanPreviousTrack;
                case VK.MediaStop:
                    return Scancode.Stop;
                case VK.VolumeUp:
                    return Scancode.VolumeIncrement;
                case VK.VolumeDown:
                    return Scancode.VolumeDecrement;
                case VK.VolumeMute:
                    return Scancode.Mute;
            }

            // F24 conflicts with LANG5, so we use the VK to
            // get the correct scancode.
            // It is not entierly tested if this is necessary
            // - 2023-04-17 Noggin_bops
            switch (virtualKey)
            {
                case VK.F13: return Scancode.F13;
                case VK.F14: return Scancode.F14;
                case VK.F15: return Scancode.F15;
                case VK.F16: return Scancode.F16;
                case VK.F17: return Scancode.F17;
                case VK.F18: return Scancode.F18;
                case VK.F19: return Scancode.F19;
                case VK.F20: return Scancode.F20;
                case VK.F21: return Scancode.F21;
                case VK.F22: return Scancode.F22;
                case VK.F23: return Scancode.F23;
                case VK.F24: return Scancode.F24;
            }

            Scancode code;
            if (extended)
            {
                code = ScancodeLookupExt[winScancode]; 
            }
            else
            {
                code = ScancodeLookup[winScancode];
            }

            return code;
        }

        internal static Key ToKey(int scancode, VK virtualKey, bool extended)
        {
            // FIXME: Should Keypad enter and enter be different keys?
            // They are different scancodes.

            // FIXME: Make number scancodes always map to number keys. AZERTY.

            // FIXME: SDLLib marks some keys as not remappable and will always correspond to the scancode
            // https://github.com/libsdl-org/SDL/blob/4187c6c08c2f0a6c84ea274c95c10ac7fdc5147a/include/SDL3/SDL_keycode.h#L47
            // This might be a good solution in the future.

            // Because some keypad keys get converted into
            // their functional keys like Keypad7 -> Home we
            // manually convert all keypad scancodes to keypad keys.
            // FIXME: We probably want to do the non remappable character stuff from SDLLib.
            // This is mostly done for the keymap to work correctly
            // - Noggin_bops 2023-02-15
            if (extended)
            {
                switch (scancode)
                {
                    case 0x1C: return Key.KeypadEnter;
                    case 0x35: return Key.KeypadDivide;
                    case 0x45: return Key.NumLock;
                }
            }
            else
            {
                switch (scancode)
                {
                    case 0x37: return Key.KeypadMultiply;
                    case 0x47: return Key.Keypad7;
                    case 0x48: return Key.Keypad8;
                    case 0x49: return Key.Keypad9;
                    case 0x4A: return Key.KeypadSubtract;
                    case 0x4B: return Key.Keypad4;
                    case 0x4C: return Key.Keypad5;
                    case 0x4D: return Key.Keypad6;
                    case 0x4E: return Key.KeypadAdd;
                    case 0x4F: return Key.Keypad1;
                    case 0x50: return Key.Keypad2;
                    case 0x51: return Key.Keypad3;
                    case 0x52: return Key.Keypad0;
                    case 0x53: return Key.KeypadDecimal;
                    case 0x59: return Key.KeypadEqual;
                    case 0x7E: return Key.KeypadSeparator;
                }
            }

            // Letters map directly.
            if (virtualKey >= VK.A && virtualKey <= VK.Z)
            {
                return (Key)virtualKey;
            }

            // Numbers map directly
            if (virtualKey >= VK.N0 && virtualKey <= VK.N9)
            {
                return (Key)virtualKey;
            }

            // Map function keys
            if (virtualKey >= VK.F1 && virtualKey <= VK.F24)
            {
                return (virtualKey - VK.F1) + Key.F1;
            }

            // We need to figure out which shift key is pressed.
            if (virtualKey == VK.Shift)
            {
                const int RightShift = 0x36;
                return scancode == RightShift ? Key.RightShift : Key.LeftShift;
            }

            if (virtualKey == VK.Control)
            {
                return extended ? Key.RightControl : Key.LeftControl;
            }

            if (virtualKey == VK.Menu)
            {
                return extended ? Key.RightAlt : Key.LeftAlt;
            }

            Key key = KeyLookup[(byte)virtualKey];

            return key;
        }
    }
}
