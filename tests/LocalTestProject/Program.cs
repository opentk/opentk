

using OpenTK.Platform;
using OpenTK.Platform.Native.Windows;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using System.Diagnostics;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocalTestProject
{
    public class Program
    {
        static WindowComponent windowComp = new WindowComponent();
        static WindowHandle WindowHandle;
        static WindowHandle WindowHandle2;

        static IOpenGLComponent glComp = new OpenGLComponent();
        static OpenGLContextHandle WindowContext;
        static OpenGLContextHandle Window2Context;

        static DisplayHandle PrimaryDisplayHandle;

        static IMouseComponent mouseComp = new MouseComponent();
        static ICursorComponent cursorComp = new CursorComponent();
        static IIconComponent iconComp = new IconComponent();

        static IDisplayComponent dispComp = new DisplayComponent();

        static IKeyboardComponent keyboardComp = new KeyboardComponent();

        static IClipboardComponent clipComp = new ClipboardComponent();

        static IShellComponent shellComp = new ShellComponent();

        static IJoystickComponent joystickComponent = new JoystickComponent();

        static CursorHandle CursorHandle;
        static CursorHandle ImageCursorHandle;
        static CursorHandle FileCursorHandle;

        static IconHandle IconHandle;
        static IconHandle IconHandle2;

        public static void Main(string[] args)
        {
            // Set the logger for all of the components
            // FIXME: A better way to set all of the loggers at the same time.
            var logger = new ConsoleLogger();
            windowComp.Logger = logger;
            glComp.Logger = logger;
            mouseComp.Logger = logger;
            cursorComp.Logger = logger;
            iconComp.Logger = logger;
            dispComp.Logger = logger;
            keyboardComp.Logger = logger;
            clipComp.Logger = logger;
            joystickComponent.Logger = logger;

            ToolkitOptions options = new ToolkitOptions() { ApplicationName = "LocalTestProject", Logger = logger };

            windowComp.Initialize(options);
            glComp.Initialize(options);

            dispComp.Initialize(options);

            keyboardComp.Initialize(options);

            iconComp.Initialize(options);
            cursorComp.Initialize(options);

            clipComp.Initialize(options);

            shellComp.Initialize(options);

            joystickComponent.Initialize(options);

            Console.WriteLine($"Current Keyboard Layout name: {keyboardComp.GetActiveKeyboardLayout(null)}");

            Console.WriteLine($"Available Keyboard Layouts:\n  {string.Join("\n  ", keyboardComp.GetAvailableKeyboardLayouts())}");

            {
                PrimaryDisplayHandle = dispComp.OpenPrimary();
                string name = dispComp.GetName(PrimaryDisplayHandle);
                dispComp.GetVideoMode(PrimaryDisplayHandle, out VideoMode videoMode);
                dispComp.GetDisplayScale(PrimaryDisplayHandle, out float scaleX, out float scaleY);
                Console.WriteLine($"Primary monitor name: {name}");
                Console.WriteLine($"  {videoMode}");
                Console.WriteLine($"  Scale: {scaleX}, {scaleY}");

                int modeCount = dispComp.GetSupportedVideoModes(PrimaryDisplayHandle).Length;
                Console.WriteLine($"Primary monitor supports {modeCount} video modes.");

                if (dispComp.GetDisplayCount() > 1)
                {
                    var secondaryHandle = dispComp.Open(1);
                    modeCount = dispComp.GetSupportedVideoModes(secondaryHandle).Length;
                    Console.WriteLine($"Secondary monitor supports {modeCount} video modes.");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Monitors: {dispComp.GetDisplayCount()}");
            for (int i = 0; i < dispComp.GetDisplayCount(); i++)
            {
                DisplayHandle disp = dispComp.Open(i);

                string name = dispComp.GetName(disp);
                dispComp.GetVideoMode(disp, out VideoMode videoMode);
                dispComp.GetDisplayScale(disp, out float scaleX, out float scaleY);
                Console.WriteLine($"Primary monitor name: {name}");
                Console.WriteLine($"  {videoMode}");
                Console.WriteLine($"  Scale: {scaleX}, {scaleY}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            OpenGLGraphicsApiHints contextSettings = new OpenGLGraphicsApiHints()
            {
                DoubleBuffer = true,
                sRGBFramebuffer = false,
                Multisamples = 0,
                DepthBits = ContextDepthBits.Depth24,
                StencilBits = ContextStencilBits.Stencil8,
            };

            WindowHandle = windowComp.Create(contextSettings);

            WindowContext = glComp.CreateFromWindow(WindowHandle);

            contextSettings.SharedContext = WindowContext;

            WindowHandle2 = windowComp.Create(contextSettings);

            Window2Context = glComp.CreateFromWindow(WindowHandle2);

            SetWindowSettings(WindowHandle, "Cool test window", 600, 400);
            SetWindowSettings(WindowHandle2, "Cool test window #2", 300, 300);

            windowComp.GetPosition(WindowHandle, out Vector2i position);
            windowComp.GetSize(WindowHandle, out Vector2i size);
            windowComp.GetClientPosition(WindowHandle, out Vector2i cPosition);
            windowComp.GetClientSize(WindowHandle, out Vector2i cSize);
            Console.WriteLine($"Window: X: {position.X}, Y: {position.Y}, Width: {size.X}, Height: {size.Y}");
            Console.WriteLine($"Client: X: {cPosition.X}, Y {cPosition.Y} Width: {cSize.X}, Height: {cSize.Y}");

            windowComp.SetClientSize(WindowHandle, (600, 400));
            windowComp.SetClientPosition(WindowHandle, (100, 100));

            windowComp.SetMinClientSize(WindowHandle, 200, 200);
            windowComp.SetMaxClientSize(WindowHandle, 1600, 900);

            windowComp.GetPosition(WindowHandle, out position);
            windowComp.GetSize(WindowHandle, out size);
            windowComp.GetClientPosition(WindowHandle, out cPosition);
            windowComp.GetClientSize(WindowHandle, out cSize);
            Console.WriteLine($"Window: X: {position.X}, Y: {position.Y}, Width: {size.X}, Height: {size.Y}");
            Console.WriteLine($"Client: X: {cPosition.X}, Y {cPosition.Y} Width: {cSize.X}, Height: {cSize.Y}");

            var mode = windowComp.GetMode(WindowHandle);
            Console.WriteLine($"Mode: {mode}");

            windowComp.SetMode(WindowHandle, WindowMode.Normal);
            windowComp.SetMode(WindowHandle2, WindowMode.Normal);

            windowComp.SetPosition(WindowHandle2, (0, 0));

            mode = windowComp.GetMode(WindowHandle);
            Console.WriteLine($"Mode: {mode}");

            // Subscribe to all events
            EventQueue.EventRaised += EventQueue_EventRaised;

            glComp.SetCurrentContext(WindowContext);
            GLLoader.LoadBindings(glComp.GetBindingsContext(WindowContext));

            CursorHandle = cursorComp.Create(SystemCursorType.TextBeam);
            cursorComp.GetSize(CursorHandle, out _, out _);
            windowComp.SetCursor(WindowHandle, CursorHandle);
            windowComp.SetCursor(WindowHandle2, CursorHandle);

            byte[] image = new byte[16 * 16 * 3];
            byte[] mask = new byte[16 * 16 * 1];
            for (int ccx = 0; ccx < 16; ccx++)
            {
                for (int ccy = 0; ccy < 16; ccy++)
                {
                    int index = (ccy * 16 + ccx) * 3;

                    image[index + 0] = (byte)(ccx * 16);
                    image[index + 1] = (byte)(ccx * 16);
                    image[index + 2] = (byte)(ccx * 16);

                    mask[(ccy * 16 + ccx)] = (byte)((ccy % 2 == 0) ? 1 : 0);
                }
            }
            ImageCursorHandle = cursorComp.Create(16, 16, image, mask, 8, 8);
            windowComp.SetCursor(WindowHandle2, ImageCursorHandle);

            {
                byte[] icon = new byte[16 * 16 * 4];
                for (int ccx = 0; ccx < 16; ccx++)
                {
                    for (int ccy = 0; ccy < 16; ccy++)
                    {
                        int index = (ccy * 16 + ccx) * 4;

                        if (ccx < 5)
                        {
                            icon[index + 0] = 255;
                            icon[index + 1] = 0;
                            icon[index + 2] = 0;
                        }
                        else if (ccx < 10)
                        {
                            icon[index + 0] = 0;
                            icon[index + 1] = 255;
                            icon[index + 2] = 0;
                        }
                        else
                        {
                            icon[index + 0] = 0;
                            icon[index + 1] = 0;
                            icon[index + 2] = 255;
                        }

                        //icon[index + 0] = (byte)(ccx * 16);
                        //icon[index + 1] = (byte)(ccx * 16);
                        //icon[index + 2] = (byte)(ccx * 16);
                        icon[index + 3] = 255;
                        if (ccy < 5) icon[index + 3] = 50;
                    }
                }

                IconHandle = iconComp.Create(16, 16, icon);

                windowComp.SetIcon(WindowHandle, IconHandle);

                // FIXME: Make reading icon data backend specific?
                {
                    iconComp.GetSize(IconHandle, out int iw, out int ih);

                    int bytes = ((IconComponent)iconComp).GetBitmapByteSize(IconHandle);
                    byte[] data = new byte[bytes];

                    ((IconComponent)iconComp).GetBitmapData(IconHandle, data);

                    Debug.Assert(iw == 16);
                    Debug.Assert(ih == 16);
                    Debug.Assert(bytes == 1024);
                    Debug.Assert(data.SequenceEqual(icon));
                }
            }

            {
                IconHandle2 = (iconComp as IconComponent)?.CreateFromIcoFile("Wikipedia-Flags-UN-United-Nations-Flag.ico") ??
                                iconComp.Create(SystemIconType.Default);

                windowComp.SetIcon(WindowHandle2, IconHandle2);
            }

            FileCursorHandle = (cursorComp as CursorComponent)?.CreateFromCurFile("Cute Light Green Normal Select.cur") ??
                                cursorComp.Create(SystemCursorType.Default);

            windowComp.SetCursor(WindowHandle, FileCursorHandle);

            {
                cursorComp.GetSize(ImageCursorHandle, out int curW, out int curH);
                Console.WriteLine($"Width: {curW}, Height: {curH}");
            }

            for (int i = 0; i < 4; i++)
            {
                var handle = joystickComponent.Open(i);

                if (joystickComponent.TryGetBatteryInfo(handle, out GamepadBatteryInfo info))
                {
                    Console.WriteLine($"Gamepad {i + 1}: {info.BatteryType} {info.ChargeLevel * 100}%");
                }
                else
                {
                    Console.WriteLine($"Could not get battery info for gamepad {i + 1}");
                }

                joystickComponent.Close(handle);
            }

            Init();
            while (true)
            {
                windowComp.ProcessEvents(false);

                // If both of our windows are closed, we exit the application.
                if (windowComp.IsWindowDestroyed(WindowHandle) &&
                    windowComp.IsWindowDestroyed(WindowHandle2))
                {
                    break;
                }

                if (Render() == false)
                {
                    break;
                }
            }
        }

        public static void SetWindowSettings(WindowHandle handle, string title, int width, int height)
        {
            windowComp.SetTitle(handle, title);

            windowComp.SetSize(handle, (width, height));
            //windowComp.SetPosition(handle, 100, 100);

            windowComp.SetBorderStyle(handle, WindowBorderStyle.Borderless);
            WindowBorderStyle border = windowComp.GetBorderStyle(handle);
            Console.WriteLine($"Border: {border}");

            windowComp.SetBorderStyle(handle, WindowBorderStyle.FixedBorder);
            border = windowComp.GetBorderStyle(handle);
            Console.WriteLine($"Border: {border}");

            windowComp.SetBorderStyle(handle, WindowBorderStyle.ResizableBorder);
            border = windowComp.GetBorderStyle(handle);
            Console.WriteLine($"Border: {border}");
        }

        static List<Scancode> vks = new List<Scancode>();

        static Vector2 MousePos = (0, 0);
        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (type == PlatformEventType.MouseMove)
            {
                MouseMoveEventArgs mouseMoveArgs = (MouseMoveEventArgs)args;

                //Console.WriteLine($"Delta X: {mouseMoveArgs.DeltaX}, DeltaY: {mouseMoveArgs.DeltaY}");

                MousePos = mouseMoveArgs.ClientPosition;

                if (windowComp.IsWindowDestroyed(WindowHandle) == false)
                {
                    windowComp.ScreenToClient(WindowHandle, MousePos, out Vector2 client);
                    windowComp.SetTitle(WindowHandle, $"({client.X},{client.Y})");
                }
            }
            else if (type == PlatformEventType.MouseDown)
            {
                MouseButtonDownEventArgs mouseButtonDownArgs = (MouseButtonDownEventArgs)args;

                Console.WriteLine($"Pressed Mouse Button: {mouseButtonDownArgs.Button}");

                if (mouseButtonDownArgs.Button == MouseButton.Button1)
                {
                    keyboardComp.BeginIme(WindowHandle);

                    keyboardComp.SetImeRectangle(WindowHandle, (int)MousePos.X, (int)MousePos.Y, 0, 0);

                    keyboardComp.EndIme(WindowHandle);
                }
            }
            else if (type == PlatformEventType.MouseUp)
            {
                MouseButtonUpEventArgs mouseButtonUpArgs = (MouseButtonUpEventArgs)args;

                Console.WriteLine($"Released Mouse Button: {mouseButtonUpArgs.Button}");
            }
            else if (type == PlatformEventType.Close)
            {
                CloseEventArgs closeArgs = (CloseEventArgs)args;

                windowComp.Destroy(closeArgs.Window);
            }
            else if (type == PlatformEventType.Focus)
            {
                FocusEventArgs focus = (FocusEventArgs)args;

                if (focus.GotFocus)
                {
                    Console.WriteLine("Got focus");
                }
                else
                {
                    Console.WriteLine("Lost focus");
                }
            }
            else if (type == PlatformEventType.TextInput)
            {
                TextInputEventArgs input = (TextInputEventArgs)args;

                Console.WriteLine($"Input: {input.Text}");

                Console.WriteLine($"Scancodes: {string.Join(", ", vks)}");

                vks.Clear();
            }
            else if (type == PlatformEventType.MouseEnter)
            {
                MouseEnterEventArgs enter = (MouseEnterEventArgs)args;

                if (enter.Entered)
                {
                    Console.WriteLine($"Mouse entered.");
                }
                else
                {
                    Console.WriteLine("Mouse exited.");
                }
            }
            else if (type == PlatformEventType.FileDrop)
            {
                FileDropEventArgs fileDrop = (FileDropEventArgs)args;

                Console.WriteLine($"Files dropped! Position: {fileDrop.Position}, Paths: {string.Join(", ", fileDrop.FilePaths)}");
            }
            else if (type == PlatformEventType.KeyDown)
            {
                KeyDownEventArgs keyDown = (KeyDownEventArgs)args;

                Console.WriteLine($"keyDown: {keyDown.Key}");

                if (keyDown.IsRepeat == false)
                    vks.Add(keyDown.Scancode);

                if (keyDown.Key == Key.F11)
                {
                    // FIXME: What does bpp=32 compared to bpp=24?
                    VideoMode mode = new VideoMode(1920, 1080, 144, 32);

                    if (windowComp.GetMode(keyDown.Window) == WindowMode.WindowedFullscreen)
                    {
                        windowComp.SetMode(keyDown.Window, WindowMode.Normal);
                    }
                    else
                    {
                        windowComp.SetMode(keyDown.Window, WindowMode.WindowedFullscreen);
                    }
                }
                else if (keyDown.Key == Key.M)
                {
                    windowComp.GetFullscreenDisplay(keyDown.Window, out var display);
                    Console.WriteLine($"Current fullscreen display: {(display != null ? dispComp.GetName(display) : "null")}");
                }
                else if (keyDown.Key == Key.C)
                {
                    clipComp.SetClipboardText("Copy");
                }
                else if (keyDown.Key == Key.V)
                {
                    clipComp.SetClipboardText("Paste");
                }
                else if (keyDown.Key == Key.A)
                {
                    AudioData data = new AudioData();
                    data.SampleRate = 44100;
                    data.Stereo = false;
                    data.Audio = new short[44100 * 2];
                    for (int i = 0; i < data.Audio.Length; i++)
                    {
                        float t = i / (float)data.SampleRate;

                        float sample = MathF.Sin(t * MathHelper.TwoPi * 440);

                        short s = (short)(sample * short.MaxValue);

                        data.Audio[i] = s;
                    }

                    ((ClipboardComponent)clipComp).SetClipboardAudio(data);
                }
                else if (keyDown.Key == Key.B)
                {
                    const int W = 600;
                    const int H = 600;
                    byte[] b = new byte[W * H * 4];
                    for (int xi = 0; xi < W; xi++)
                    {
                        for (int yi = 0; yi < H; yi++)
                        {
                            int index = (yi * W + xi) * 4;

                            static byte ftob(float f) => (byte)(f * 255);

                            float x0 = MathHelper.MapRange(xi, 0f, W, -2f, 0.47f);
                            float y0 = MathHelper.MapRange(yi, 0f, H, -1.12f, 1.12f);

                            float x = 0;
                            float y = 0;
                            const int maxIterations = 1000;
                            int iteration = 0;
                            while (x * x + y * y < 2 * 2 && iteration < maxIterations)
                            {
                                iteration++;

                                float xTemp = x * x - y * y + x0;
                                y = 2 * x * y + y0;
                                x = xTemp;
                            }

                            // See https://stackoverflow.com/a/22681410/9316430
                            static void SpectralColor(float l, out float r, out float g, out float b) // RGB <0,1> <- lambda l <400,700> [nm]
                            {
                                float t; r = 0.0f; g = 0.0f; b = 0.0f;
                                if ((l >= 400.0) && (l < 410.0)) { t = (l - 400.0f) / (410.0f - 400.0f); r = +(0.33f * t) - (0.20f * t * t); }
                                else if ((l >= 410.0) && (l < 475.0)) { t = (l - 410.0f) / (475.0f - 410.0f); r = 0.14f - (0.13f * t * t); }
                                else if ((l >= 545.0) && (l < 595.0)) { t = (l - 545.0f) / (595.0f - 545.0f); r = +(1.98f * t) - (t * t); }
                                else if ((l >= 595.0) && (l < 650.0)) { t = (l - 595.0f) / (650.0f - 595.0f); r = 0.98f + (0.06f * t) - (0.40f * t * t); }
                                else if ((l >= 650.0) && (l < 700.0)) { t = (l - 650.0f) / (700.0f - 650.0f); r = 0.65f - (0.84f * t) + (0.20f * t * t); }
                                if ((l >= 415.0) && (l < 475.0)) { t = (l - 415.0f) / (475.0f - 415.0f); g = +(0.80f * t * t); }
                                else if ((l >= 475.0) && (l < 590.0)) { t = (l - 475.0f) / (590.0f - 475.0f); g = 0.8f + (0.76f * t) - (0.80f * t * t); }
                                else if ((l >= 585.0) && (l < 639.0)) { t = (l - 585.0f) / (639.0f - 585.0f); g = 0.84f - (0.84f * t); }
                                if ((l >= 400.0) && (l < 475.0)) { t = (l - 400.0f) / (475.0f - 400.0f); b = +(2.20f * t) - (1.50f * t * t); }
                                else if ((l >= 475.0) && (l < 560.0)) { t = (l - 475.0f) / (560.0f - 475.0f); b = 0.7f - (t) + (0.30f * t * t); }
                            }

                            float l = MathHelper.MapRange(iteration, 0, maxIterations, 400.0f, 700.0f);
                            SpectralColor(l, out float red, out float green, out float blue);

                            b[index + 0] = ftob(red);
                            b[index + 1] = ftob(green);
                            b[index + 2] = ftob(blue);
                            b[index + 3] = 255;
                        }
                    }

                    Bitmap bitmap = new Bitmap(W, H, b);

                    ((ClipboardComponent)clipComp).SetClipboardBitmap(bitmap);
                }
                else if (keyDown.Key == Key.P)
                {
                    ClipboardFormat format = clipComp.GetClipboardFormat();
                    Console.WriteLine($"Clipboard format: {format}");
                    switch (format)
                    {
                        case ClipboardFormat.Text:
                            Console.WriteLine($"Current clipboard: '{clipComp.GetClipboardText()}'");
                            break;
                        case ClipboardFormat.Files:
                            Console.WriteLine($"Current clipboard: '{string.Join(", ", clipComp.GetClipboardFiles()!)}'");
                            break;
                        case ClipboardFormat.Bitmap:
                            {
                                Bitmap? bitmap = clipComp.GetClipboardBitmap();
                                if (bitmap == null)
                                {
                                    Console.WriteLine("Could not get clipboard image!");
                                    break;
                                }
                                Console.WriteLine($"Current clipboard: width: {bitmap.Width}, height: {bitmap.Height}");

                                var tex = GL.GenTexture();

                                GL.ActiveTexture(TextureUnit.Texture0);
                                GL.BindTexture(TextureTarget.Texture2d, tex);

                                GL.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.Rgba8, bitmap.Width, bitmap.Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, bitmap.Data);

                                GL.GenerateMipmap(TextureTarget.Texture2d);

                                GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
                                GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

                                GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
                                GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);

                                GL.BindTexture(TextureTarget.Texture2d, 0);

                                if (clipboard_tex != 0)
                                {
                                    GL.DeleteTexture(clipboard_tex);
                                }

                                clipboard_tex = tex;

                                break;
                            }
                        case ClipboardFormat.Audio:
                            {
                                var audio = clipComp.GetClipboardAudio()!;

                                int samples = audio.Audio.Length;
                                if (audio.Stereo) samples /= 2;
                                float time = samples * (1f / audio.SampleRate);

                                Console.WriteLine($"Current clipboard: Sample rate: {audio.SampleRate / 1000f}kHz, Stereo: {audio.Stereo}, Length: {time}s");

                                break;
                            }
                        case ClipboardFormat.None:
                        default:
                            break;
                    }
                }
                else if (keyDown.Key == Key.D)
                {
                    DisplayHandle disp = windowComp.GetDisplay(WindowHandle);
                    bool isPrimary = dispComp.IsPrimary(disp);
                    dispComp.GetResolution(disp, out int resX, out int resY);
                    dispComp.GetRefreshRate(disp, out float refreshRate);

                    string name = dispComp.GetName(disp);

                    Console.WriteLine($"Window is on monitor '{name}', primary: {isPrimary}, res: ({resX}x{resY}, refresh rate: {refreshRate:0.})");
                }
                else if (keyDown.Key == Key.S)
                {
                    windowComp.GetClientSize(WindowHandle, out Vector2i size);
                    Console.WriteLine($"Window 1 client size: ({size.X}, {size.Y})");
                }
                else if (keyDown.Key == Key.Q)
                {
                    BatteryStatus status = shellComp.GetBatteryInfo(out BatteryInfo info);
                    switch (status)
                    {
                        default:
                        case BatteryStatus.Unknown:
                            Console.WriteLine("Cannot get battery information.");
                            break;
                        case BatteryStatus.NoSystemBattery:
                            Console.WriteLine("This computer has not battery.");
                            break;
                        case BatteryStatus.HasSystemBattery:
                            Console.WriteLine(info);
                            break;
                    }
                }
                else if (keyDown.Key == Key.M)
                {


                    var style = windowComp.GetBorderStyle(WindowHandle);
                    Console.WriteLine($"Before: {style}");
                    style += 1;
                    style = (WindowBorderStyle)((int)style % 4);

                    windowComp.SetBorderStyle(WindowHandle, style);

                    Console.WriteLine($"After: {style}, Result: {windowComp.GetBorderStyle(WindowHandle)}");
                }
            }
            else if (type == PlatformEventType.KeyUp)
            {
                KeyUpEventArgs keyUp = (KeyUpEventArgs)args;

                Console.WriteLine($"keyUp: {keyUp.Key}");
            }
            else if (type == PlatformEventType.WindowMove)
            {
                WindowMoveEventArgs move = (WindowMoveEventArgs)args;

                Console.WriteLine($"Window '{windowComp.GetTitle(move.Window)}' at client pos: ({move.ClientAreaPosition}), window pos: {move.WindowPosition}");
            }
            else if (type == PlatformEventType.WindowResize)
            {
                WindowResizeEventArgs resize = (WindowResizeEventArgs)args;

                Console.WriteLine($"Window '{windowComp.GetTitle(resize.Window)}' new size: ({resize.NewSize})");
            }
            else if (type == PlatformEventType.WindowModeChange)
            {
                WindowModeChangeEventArgs modeChange = (WindowModeChangeEventArgs)args;

                Console.WriteLine($"Window '{windowComp.GetTitle(modeChange.Window)}' new mode: ({modeChange.NewMode})");
            }
            else if (type == PlatformEventType.PowerStateChange)
            {
                PowerStateChangeEventArgs powerStateChange = (PowerStateChangeEventArgs)args;

                if (powerStateChange.GoingToSleep)
                {
                    Console.WriteLine("Going to sleep?");
                }
                else
                {
                    Console.WriteLine("Waking up?");
                }
            }
            else if (type == PlatformEventType.ClipboardUpdate)
            {
                ClipboardUpdateEventArgs clipboardUpdate = (ClipboardUpdateEventArgs)args;
                Console.WriteLine($"Clipboard update! New format: {clipboardUpdate.NewFormat}");
            }
        }

        static int buffer;

        static int vao;
        static int vao2;

        static int program;
        static int program2;

        const string vertexShaderSource =
    @"#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec2 aUV;
layout (location = 2) in vec3 aColor;

out vec2 oUV;
out vec3 oColor;

void main()
{
    gl_Position = vec4(aPos.x, aPos.y, aPos.z, 1.0);
    oUV = aUV;
    oColor = aColor;
}";

        const string fragmentShaderSource =
    @"#version 330 core
in vec2 oUV;
in vec3 oColor;

out vec4 FragColor;

uniform sampler2D tex;

void main()
{
    FragColor = texture(tex, oUV);
}";

        public static int GetCursorImage(CursorHandle handle)
        {
            cursorComp.GetSize(handle, out int width, out int height);
            byte[] data = new byte[width * height * 4];
            // FIXME: Handle proper RGBA format when using AND and XOR masks. Atm it gets a constant alpha = 0.
            ((CursorComponent)cursorComp).GetImage(handle, data);

            for (int i = 0; i < width * height; i++)
            {
                int index = i * 4;

                data[index + 3] = 255;
            }

            int tex = GL.GenTexture();

            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.Texture2d, tex);

            GL.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.Rgba8, width, height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, data);

            GL.GenerateMipmap(TextureTarget.Texture2d);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);

            GL.BindTexture(TextureTarget.Texture2d, 0);

            return tex;
        }

        public static int GetIconImage(IconHandle handle)
        {
            int size = ((IconComponent)iconComp).GetBitmapByteSize(handle);
            byte[] data = new byte[size];

            // FIXME: Handle proper RGBA format when using AND and XOR masks. Atm it gets a constant alpha = 0.
            ((IconComponent)iconComp).GetBitmapData(handle, data);

            iconComp.GetSize(handle, out int width, out int height);

            int tex = GL.GenTexture();

            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.Texture2d, tex);

            GL.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.Rgba8, width, height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, data);

            GL.GenerateMipmap(TextureTarget.Texture2d);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);

            GL.BindTexture(TextureTarget.Texture2d, 0);

            return tex;
        }

        static int cursor_tex;
        static int icon_tex;

        static int clipboard_tex;

        public static void Init()
        {
            float[] vertices = new float[]
            {
            -1f * 0.5f, -1f * 0.5f, 0f,     0f, 0f,     1f, 0f, 0f,
             1f * 0.5f, -1f * 0.5f, 0f,     1f, 0f,     0f, 1f, 0f,
             1f * 0.5f,  1f * 0.5f, 0f,     1f, 1f,     0f, 0f, 1f,

             1f * 0.5f,  1f * 0.5f, 0f,     1f, 1f,     0f, 0f, 1f,
            -1f * 0.5f,  1f * 0.5f, 0f,     0f, 1f,     0f, 1f, 0f,
            -1f * 0.5f, -1f * 0.5f, 0f,     0f, 0f,     1f, 0f, 0f,
            };

            glComp.SetCurrentContext(WindowContext);

            buffer = CreateBuffer(vertices);
            vao = CreateVAO(buffer);

            CheckError("vao");

            program = CreateShader("", vertexShaderSource, fragmentShaderSource);

            GL.UseProgram(program);

            CheckError("shader");

            cursor_tex = GetCursorImage(ImageCursorHandle);
            icon_tex = GetIconImage(IconHandle2);

            CheckError("get cursor tex");

            glComp.SetCurrentContext(Window2Context);

            vao2 = CreateVAO(buffer);
            program2 = CreateShader("", vertexShaderSource, fragmentShaderSource);

            glComp.SetCurrentContext(WindowContext);

            CheckError("getString");

            GL.GetFramebufferAttachmentParameteri(FramebufferTarget.DrawFramebuffer, (FramebufferAttachment)All.BackLeft, FramebufferAttachmentParameterName.FramebufferAttachmentColorEncoding, out int encoding);

            if ((All)encoding == All.Linear)
            {
                Console.WriteLine("Linear default framebuffer!");
            }
            else if ((All)encoding == All.Srgb)
            {
                Console.WriteLine("sRGB default framebuffer!");
            }
            CheckError("getFramebuffer");

            GL.Disable(EnableCap.FramebufferSrgb);
        }

        public static int CreateBuffer(float[] vertices)
        {
            var buffer = GL.GenBuffer();

            GL.BindBuffer(BufferTarget.ArrayBuffer, buffer);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsage.StaticDraw);

            return buffer;
        }

        public static int CreateVAO(int buffer)
        {
            var vao = GL.GenVertexArray();

            CheckError("buffer");

            GL.BindVertexArray(vao);
            GL.BindBuffer(BufferTarget.ArrayBuffer, buffer);

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, sizeof(float) * 8, 0);
            GL.EnableVertexAttribArray(0);

            GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, sizeof(float) * 8, sizeof(float) * 3);
            GL.EnableVertexAttribArray(1);

            GL.VertexAttribPointer(2, 3, VertexAttribPointerType.Float, false, sizeof(float) * 8, sizeof(float) * 5);
            GL.EnableVertexAttribArray(2);

            return vao;
        }

        public static int CreateShader(string name, string vertexSource, string fragmentSource)
        {
            var vert = GL.CreateShader(ShaderType.VertexShader);
            var frag = GL.CreateShader(ShaderType.FragmentShader);

            GL.ShaderSource(vert, vertexSource);
            GL.ShaderSource(frag, fragmentSource);

            GL.CompileShader(vert);
            GL.CompileShader(frag);

            int success;
            GL.GetShaderi(vert, ShaderParameterName.CompileStatus, out success);
            if (success == 0)
            {
                GL.GetShaderInfoLog(vert, out string info);
                Console.WriteLine(info);
            }
            GL.GetShaderi(frag, ShaderParameterName.CompileStatus, out success);
            if (success == 0)
            {
                GL.GetShaderInfoLog(frag, out string info);
                Console.WriteLine(info);
            }

            var program = GL.CreateProgram();

            GL.AttachShader(program, vert);
            GL.AttachShader(program, frag);

            GL.LinkProgram(program);

            GL.GetProgrami(program, ProgramProperty.LinkStatus, out success);
            if (success == 0)
            {
                GL.GetProgramInfoLog(program, out string info);
                Console.WriteLine(info);
            }

            GL.DetachShader(program, vert);
            GL.DetachShader(program, frag);

            GL.DeleteShader(vert);
            GL.DeleteShader(frag);

            return program;
        }

        static Stopwatch watch = new Stopwatch();
        static float time = 0;
        static int frames = 0;

        static float colorTimer = 0;

        public static bool Render()
        {
            float deltaTime = watch.ElapsedTicks / (float)Stopwatch.Frequency;
            watch.Restart();

            for (int i = 0; i < 4; i++)
            {
                int player = i + 1;
                JoystickHandle handle = joystickComponent.Open(i);

                float leftX = joystickComponent.GetAxis(handle, JoystickAxis.LeftXAxis);
                float leftY = joystickComponent.GetAxis(handle, JoystickAxis.LeftYAxis);
                float rightX = joystickComponent.GetAxis(handle, JoystickAxis.RightXAxis);
                float rightY = joystickComponent.GetAxis(handle, JoystickAxis.RightYAxis);
                float triggerLeft = joystickComponent.GetAxis(handle, JoystickAxis.LeftTrigger);
                float triggerRight = joystickComponent.GetAxis(handle, JoystickAxis.RightTrigger);

                if (MathF.Abs(leftX) < joystickComponent.LeftDeadzone)
                    leftX = 0;

                if (MathF.Abs(leftY) < joystickComponent.LeftDeadzone)
                    leftY = 0;

                if (MathF.Abs(rightX) < joystickComponent.RightDeadzone)
                    rightX = 0;

                if (MathF.Abs(rightY) < joystickComponent.RightDeadzone)
                    rightY = 0;

                if (triggerLeft < joystickComponent.TriggerThreshold)
                    triggerLeft = 0;

                if (triggerRight < joystickComponent.TriggerThreshold)
                    triggerRight = 0;

                Vector2 left = (leftX, leftY);
                Vector2 right = (rightX, rightY);

                if (left.Length > 0)
                {
                    Console.WriteLine($"Player {player} Left: {left}");
                }

                if (right.Length > 0)
                {
                    Console.WriteLine($"Player {player} Right: {right}");
                }

                if (triggerLeft > 0)
                {
                    Console.WriteLine($"Player {player} Trigger left: {triggerLeft}");
                }

                if (triggerRight > 0)
                {
                    Console.WriteLine($"Player {player} Trigger right: {triggerRight}");
                }

                foreach (JoystickButton button in Enum.GetValues<JoystickButton>())
                {
                    if (joystickComponent.GetButton(handle, button))
                    {
                        Console.WriteLine($"Player {player} Button {button}");
                    }
                }

                if (triggerLeft > 0 || triggerRight > 0)
                {
                    Console.WriteLine($"Supports FFB: {(joystickComponent as JoystickComponent)?.SupportsForceFeedback(handle)}");
                }

                joystickComponent.SetVibration(handle, triggerLeft, triggerRight);

                joystickComponent.Close(handle);
            }

            time += deltaTime;
            frames++;

            if (time > 1.5f)
            {
                // FIXME: Only write this out every so often.
                //Console.WriteLine($"Delta time: {(time / frames) * 1000f}ms");
                time = 0;
                frames = 0;
            }

            if (windowComp.IsWindowDestroyed(WindowHandle) == false)
            {
                glComp.SetCurrentContext(WindowContext);

                GL.UseProgram(program);

                colorTimer += deltaTime / 5;
                colorTimer %= 1;
                Color4<Hsva> color = new Color4<Hsva>(colorTimer, 1f, 1f, 1f);

                GL.ClearColor(Color4.ToRgba(color));
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);
                windowComp.GetFramebufferSize(WindowHandle, out Vector2i fbSize);
                GL.Viewport(0, 0, fbSize.X, fbSize.Y);

                CheckError("clear");

                //mouseComp.GetPosition(null, out int x, out int y);
                //windowComp.ScreenToClient(WindowHandle, x, y, out int clientX, out int clientY);
                //windowComp.SetTitle(WindowHandle, $"({clientX},{clientY})");

                GL.ActiveTexture(TextureUnit.Texture0);

                int tex = cursor_tex;
                if (clipboard_tex != 0) tex = clipboard_tex;

                GL.BindTexture(TextureTarget.Texture2d, tex);

                GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
                GL.Enable(EnableCap.Blend);

                GL.BindVertexArray(vao);
                GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

                CheckError("draw");

                glComp.SwapBuffers(WindowContext);
            }

            if (windowComp.IsWindowDestroyed(WindowHandle2) == false)
            {
                glComp.SetCurrentContext(Window2Context);

                GL.UseProgram(program2);

                GL.ClearColor(new Color4<Rgba>(64 / 255f, 0, 127 / 255f, 255));
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);
                windowComp.GetFramebufferSize(WindowHandle2, out Vector2i fbSize);
                GL.Viewport(0, 0, fbSize.X, fbSize.Y);

                GL.ActiveTexture(TextureUnit.Texture0);
                GL.BindTexture(TextureTarget.Texture2d, icon_tex);

                GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
                GL.Enable(EnableCap.Blend);

                GL.BindVertexArray(vao2);
                GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

                glComp.SwapBuffers(Window2Context);
            }

            return true;
        }

        static void CheckError(string place)
        {
            var error = GL.GetError();
            while (error != ErrorCode.NoError)
            {
                Console.WriteLine($"{place} Error: {error}");
                error = GL.GetError();
            }
        }
    }
}
