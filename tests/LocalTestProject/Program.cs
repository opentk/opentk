

using OpenTK.Core.Platform;
using OpenTK.Platform.Native.Windows;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using System.Text;
using System.Diagnostics;

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

        static CursorHandle CursorHandle;
        static CursorHandle ImageCursorHandle;
        static CursorHandle FileCursorHandle;

        static IconHandle IconHandle;
        static IconHandle IconHandle2;

        public static void Main(string[] args)
        {
            windowComp.Initialize(PalComponents.Window);
            glComp.Initialize(PalComponents.OpenGL);

            dispComp.Initialize(PalComponents.Display);

            keyboardComp.Initialize(PalComponents.KeyboardInput);

            iconComp.Initialize(PalComponents.WindowIcon);
            cursorComp.Initialize(PalComponents.MouseCursor);

            Console.WriteLine($"Current Keyboard Layout name: {keyboardComp.GetActiveKeyboardLayout()}");

            Console.WriteLine($"Available Keyboard Layouts:\n  {string.Join("\n  ", keyboardComp.GetAvailableKeyboardLayouts())}");

            {
                PrimaryDisplayHandle = dispComp.CreatePrimary();
                string name = dispComp.GetName(PrimaryDisplayHandle);
                dispComp.GetVideoMode(PrimaryDisplayHandle, out VideoMode videoMode);
                dispComp.GetDisplayScale(PrimaryDisplayHandle, out float scaleX, out float scaleY);
                Console.WriteLine($"Primary monitor name: {name}");
                Console.WriteLine($"  Resoltion: {videoMode.HorizontalResolution}x{videoMode.VerticalResolution}");
                Console.WriteLine($"  Refresh rate: {videoMode.RefreshRate}");
                Console.WriteLine($"  Scale: {videoMode.Scale}");
                Console.WriteLine($"  Dpi: {videoMode.Dpi}");
                Console.WriteLine($"  Scale2: {scaleX}, {scaleY}");

                int modeCount = dispComp.GetSupportedVideoModeCount(PrimaryDisplayHandle);
                Console.WriteLine($"Primary monitor supports {modeCount} video modes.");

                if (dispComp.GetDisplayCount() > 1)
                {
                    var secondaryHandle = dispComp.Create(1);
                    modeCount = dispComp.GetSupportedVideoModeCount(secondaryHandle);
                    Console.WriteLine($"Secondary monitor supports {modeCount} video modes.");
                }
                
                Console.WriteLine();
            }

            Console.WriteLine($"Monitors: {dispComp.GetDisplayCount()}");
            for (int i = 0; i < dispComp.GetDisplayCount(); i++)
            {
                DisplayHandle disp = dispComp.Create(i);

                string name = dispComp.GetName(disp);
                dispComp.GetVideoMode(disp, out VideoMode videoMode);
                dispComp.GetDisplayScale(disp, out float scaleX, out float scaleY);
                Console.WriteLine($"Primary monitor name: {name}");
                Console.WriteLine($"  Resoltion: {videoMode.HorizontalResolution}x{videoMode.VerticalResolution}");
                Console.WriteLine($"  Refresh rate: {videoMode.RefreshRate}");
                Console.WriteLine($"  Scale: {videoMode.Scale}");
                Console.WriteLine($"  Dpi: {videoMode.Dpi}");
                Console.WriteLine($"  Scale2: {scaleX}, {scaleY}");
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

            windowComp.GetPosition(WindowHandle, out var x, out var y);
            windowComp.GetSize(WindowHandle, out var width, out var height);
            windowComp.GetClientPosition(WindowHandle, out var cx, out var cy);
            windowComp.GetClientSize(WindowHandle, out var cwidth, out var cheight);
            Console.WriteLine($"Window: X: {x}, Y: {y}, Width: {width}, Height: {height}");
            Console.WriteLine($"Client: X: {cx}, Y {cy} Width: {cwidth}, Height: {cheight}");

            windowComp.SetClientSize(WindowHandle, 600, 400);
            windowComp.SetClientPosition(WindowHandle, 100, 100);

            windowComp.GetPosition(WindowHandle, out x, out y);
            windowComp.GetSize(WindowHandle, out width, out height);
            windowComp.GetClientPosition(WindowHandle, out cx, out cy);
            windowComp.GetClientSize(WindowHandle, out cwidth, out cheight);
            Console.WriteLine($"Window: X: {x}, Y: {y}, Width: {width}, Height: {height}");
            Console.WriteLine($"Client: X: {cx}, Y {cy} Width: {cwidth}, Height: {cheight}");

            var mode = windowComp.GetMode(WindowHandle);
            Console.WriteLine($"Mode: {mode}");

            windowComp.SetMode(WindowHandle, WindowMode.Normal);
            windowComp.SetMode(WindowHandle2, WindowMode.Normal);

            mode = windowComp.GetMode(WindowHandle);
            Console.WriteLine($"Mode: {mode}");

            // Subscribe to all events
            EventQueue.EventRaised += EventQueue_EventRaised;

            glComp.SetCurrentContext(WindowContext);

            Win32BindingsContext w32bc = new Win32BindingsContext(glComp, WindowContext);
            GLLoader.LoadBindings(w32bc);

            CursorHandle = cursorComp.Create();
            cursorComp.Load(CursorHandle, SystemCursorType.TextBeam);
            cursorComp.GetSize(CursorHandle, out _, out _);
            windowComp.SetCursor(WindowHandle, CursorHandle);
            windowComp.SetCursor(WindowHandle2, CursorHandle);

            ImageCursorHandle = cursorComp.Create();
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
            cursorComp.SetHotspot(ImageCursorHandle, 8, 8);
            cursorComp.Load(ImageCursorHandle, 16, 16, image, mask);
            windowComp.SetCursor(WindowHandle, ImageCursorHandle);

            {
                byte[] icon = new byte[16 * 16 * 4];
                for (int ccx = 0; ccx < 16; ccx++)
                {
                    for (int ccy = 0; ccy < 16; ccy++)
                    {
                        int index = (ccy * 16 + ccx) * 4;

                        icon[index + 0] = (byte)(ccx * 16);
                        icon[index + 1] = (byte)(ccx * 16);
                        icon[index + 2] = (byte)(ccx * 16);
                        icon[index + 3] = 255;
                    }
                }

                IconHandle = iconComp.Create();
                iconComp.Load(IconHandle, 16, 16, icon);

                windowComp.SetIcon(WindowHandle, IconHandle);
            }

            {
                IconHandle2 = iconComp.Create();
                iconComp.Load(IconHandle2, "Wikipedia-Flags-UN-United-Nations-Flag.ico");

                windowComp.SetIcon(WindowHandle2, IconHandle2);
            }

            FileCursorHandle = cursorComp.Create();
            cursorComp.Load(FileCursorHandle, "Cute Light Green Normal Select.cur");
            windowComp.SetCursor(WindowHandle, FileCursorHandle);

            {
                cursorComp.GetSize(ImageCursorHandle, out int curW, out int curH);
                Console.WriteLine($"Width: {curW}, Height: {curH}");
            }
            Init();

            windowComp.Loop(WindowHandle, Render);
        }

        public static void SetWindowSettings(WindowHandle handle, string title, int width, int height)
        {
            windowComp.SetTitle(handle, title);

            windowComp.SetSize(handle, width, height);
            //windowComp.SetPosition(handle, 100, 100);

            windowComp.SetBorderStyle(handle, WindowStyle.Borderless);
            WindowStyle border = windowComp.GetBorderStyle(handle);
            Console.WriteLine($"Border: {border}");

            windowComp.SetBorderStyle(handle, WindowStyle.FixedBorder);
            border = windowComp.GetBorderStyle(handle);
            Console.WriteLine($"Border: {border}");

            windowComp.SetBorderStyle(handle, WindowStyle.ResizableBorder);
            border = windowComp.GetBorderStyle(handle);
            Console.WriteLine($"Border: {border}");
        }

        static List<ulong> vks = new List<ulong>();

        static Vector2i MousePos = (0, 0);
        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (type == PlatformEventType.MouseMove)
            {
                MouseMoveEventArgs mouseMoveArgs = (MouseMoveEventArgs)args;

                //Console.WriteLine($"Delta X: {mouseMoveArgs.DeltaX}, DeltaY: {mouseMoveArgs.DeltaY}");

                MousePos = (mouseMoveArgs.DeltaX, mouseMoveArgs.DeltaY);

                if (WindowHandle.UserData is not false)
                {
                    windowComp.ScreenToClient(WindowHandle, MousePos.X, MousePos.Y, out int clientX, out int clientY);
                    windowComp.SetTitle(WindowHandle, $"({clientX},{clientY})");
                }

                return;
            }
            else if (type == PlatformEventType.MouseDown)
            {
                MouseButtonDownEventArgs mouseButtonDownArgs = (MouseButtonDownEventArgs)args;

                Console.WriteLine($"Pressed Mouse Button: {mouseButtonDownArgs.Button}");

                if (mouseButtonDownArgs.Button == MouseButton.Button1)
                {
                    keyboardComp.BeginIme(WindowHandle);

                    keyboardComp.SetImeRectangle(WindowHandle, MousePos.X, MousePos.Y, 0, 0);

                    keyboardComp.EndIme(WindowHandle);
                }

                return;
            }
            else if (type == PlatformEventType.MouseUp)
            {
                MouseButtonUpEventArgs mouseButtonUpArgs = (MouseButtonUpEventArgs)args;

                Console.WriteLine($"Released Mouse Button: {mouseButtonUpArgs.Button}");

                return;
            }
            else if (type == PlatformEventType.Close)
            {
                CloseEventArgs closeArgs = (CloseEventArgs)args;
                
                handle!.UserData = false;

                //closeArgs.Window.UserData = false;

                return;
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

                return;
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

                Console.WriteLine($"Files dropped! Position: {fileDrop.Position}, In Window: {fileDrop.DroppedInWindow}, Paths: {string.Join(", ", fileDrop.FilePaths)}");
            }
            else if (type == PlatformEventType.KeyDown)
            {
                KeyDownEventArgs keyDown = (KeyDownEventArgs)args;

                if (keyDown.WasDown == false)
                    vks.Add(keyDown.VirtualKey);

                if (keyDown.VirtualKey == 'C')
                {
                    clipComp.SetClipboardText("Copy");
                }
                else if (keyDown.VirtualKey == 'V')
                {
                    clipComp.SetClipboardText("Paste");
                }
                else if (keyDown.VirtualKey == 'P')
                {
                    ClipboardFormat format = clipComp.GetClipboardFormat();
                    Console.WriteLine($"Clipboard format: {format}");
                    switch (format)
                    {
                        case ClipboardFormat.Text:
                            Console.WriteLine($"Current clipboard: '{clipComp.GetClipboardText()}'");
                            break;
                        case ClipboardFormat.HTML:
                            Console.WriteLine($"Current clipboard: '{clipComp.GetClipboardHTML()}',\nunformated: '{clipComp.GetClipboardText()}'");
                            break;
                        case ClipboardFormat.Files:
                            Console.WriteLine($"Current clipboard: '{string.Join(", ", clipComp.GetClipboardFiles()!)}'");
                            break;
                        case ClipboardFormat.Audio:
                        case ClipboardFormat.Bitmap:
                        case ClipboardFormat.None:
                        default:
                            break;
                    }
                }
            }
        }

        static BufferHandle buffer;

        static VertexArrayHandle vao;
        static VertexArrayHandle vao2;

        static ProgramHandle program;
        static ProgramHandle program2;

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

        public static TextureHandle GetCursorImage(CursorHandle handle)
        {
            cursorComp.GetSize(handle, out int width, out int height);
            byte[] data = new byte[width * height * 4];
            // FIXME: Handle proper RGBA format when using AND and XOR masks. Atm it gets a constant alpha = 0.
            cursorComp.GetImage(handle, data);

            for (int i = 0; i < width * height; i++)
            {
                int index = i * 4;

                data[index + 3] = 255;
            }

            TextureHandle tex = GL.GenTexture();

            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.Texture2d, tex);

            GL.TexImage2D(TextureTarget.Texture2d, 0, (int)InternalFormat.Rgba8, width, height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, data);

            GL.GenerateMipmap(TextureTarget.Texture2d);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);

            GL.BindTexture(TextureTarget.Texture2d, TextureHandle.Zero);

            return tex;
        }

        public static TextureHandle GetIconImage(IconHandle handle)
        {
            int size = iconComp.GetBitmapSize(handle);
            byte[] data = new byte[size];
            
            // FIXME: Handle proper RGBA format when using AND and XOR masks. Atm it gets a constant alpha = 0.
            iconComp.GetBitmap(handle, data);

            iconComp.GetDimensions(handle, out int width, out int height);

            TextureHandle tex = GL.GenTexture();

            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.Texture2d, tex);

            GL.TexImage2D(TextureTarget.Texture2d, 0, (int)InternalFormat.Rgba8, width, height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, data);

            GL.GenerateMipmap(TextureTarget.Texture2d);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);

            GL.BindTexture(TextureTarget.Texture2d, TextureHandle.Zero);

            return tex;
        }

        static TextureHandle cursor_tex;
        static TextureHandle icon_tex;

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

            int encoding = 0;
            GL.GetFramebufferAttachmentParameteri(FramebufferTarget.DrawFramebuffer, (FramebufferAttachment)All.BackLeft, FramebufferAttachmentParameterName.FramebufferAttachmentColorEncoding, ref encoding);

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

        public static BufferHandle CreateBuffer(float[] vertices)
        {
            var buffer = GL.GenBuffer();

            GL.BindBuffer(BufferTargetARB.ArrayBuffer, buffer);
            GL.BufferData(BufferTargetARB.ArrayBuffer, vertices, BufferUsageARB.StaticDraw);

            return buffer;
        }

        public static VertexArrayHandle CreateVAO(BufferHandle buffer)
        {
            var vao = GL.GenVertexArray();

            CheckError("buffer");

            GL.BindVertexArray(vao);
            GL.BindBuffer(BufferTargetARB.ArrayBuffer, buffer);

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, sizeof(float) * 8, 0);
            GL.EnableVertexAttribArray(0);

            GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, sizeof(float) * 8, sizeof(float) * 3);
            GL.EnableVertexAttribArray(1);

            GL.VertexAttribPointer(2, 3, VertexAttribPointerType.Float, false, sizeof(float) * 8, sizeof(float) * 5);
            GL.EnableVertexAttribArray(2);

            return vao;
        }

        public static ProgramHandle CreateShader(string name, string vertexSource, string fragmentSource)
        {
            var vert = GL.CreateShader(ShaderType.VertexShader);
            var frag = GL.CreateShader(ShaderType.FragmentShader);

            GL.ShaderSource(vert, vertexSource);
            GL.ShaderSource(frag, fragmentSource);

            GL.CompileShader(vert);
            GL.CompileShader(frag);

            int success = 0;
            GL.GetShaderi(vert, ShaderParameterName.CompileStatus, ref success);
            if (success == 0)
            {
                GL.GetShaderInfoLog(vert, out string info);
                Console.WriteLine(info);
            }
            GL.GetShaderi(frag, ShaderParameterName.CompileStatus, ref success);
            if (success == 0)
            {
                GL.GetShaderInfoLog(frag, out string info);
                Console.WriteLine(info);
            }

            var program = GL.CreateProgram();

            GL.AttachShader(program, vert);
            GL.AttachShader(program, frag);

            GL.LinkProgram(program);

            GL.GetProgrami(program, ProgramPropertyARB.LinkStatus, ref success);
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

        public static bool Render()
        {
            float deltaTime = watch.ElapsedTicks / (float)Stopwatch.Frequency;
            watch.Restart();

            time += deltaTime;
            frames++;

            if (time > 1.5f)
            {
                // FIXME: Only write this out every so often.
                //Console.WriteLine($"Delta time: {(time / frames) * 1000f}ms");
                time = 0;
                frames = 0;
            }

            if (WindowHandle.UserData is not false)
            {
                glComp.SetCurrentContext(WindowContext);

                GL.UseProgram(program);

                GL.ClearColor(new Color4<Rgba>(127 / 255f, 0, 64 / 255f, 255));
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);
                windowComp.GetClientSize(WindowHandle, out int width, out int height);
                GL.Viewport(0, 0, width, height);

                CheckError("clear");

                //mouseComp.GetPosition(null, out int x, out int y);
                //windowComp.ScreenToClient(WindowHandle, x, y, out int clientX, out int clientY);
                //windowComp.SetTitle(WindowHandle, $"({clientX},{clientY})");

                GL.ActiveTexture(TextureUnit.Texture0);
                GL.BindTexture(TextureTarget.Texture2d, cursor_tex);

                GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
                GL.Enable(EnableCap.Blend);

                GL.BindVertexArray(vao);
                GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

                CheckError("draw");

                windowComp.SwapBuffers(WindowHandle);
            }

            if (WindowHandle2.UserData is not false)
            {
                glComp.SetCurrentContext(Window2Context);

                GL.UseProgram(program2);

                GL.ClearColor(new Color4<Rgba>(64 / 255f, 0, 127 / 255f, 255));
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);
                windowComp.GetClientSize(WindowHandle2, out int width, out int height);
                GL.Viewport(0, 0, width, height);

                GL.ActiveTexture(TextureUnit.Texture0);
                GL.BindTexture(TextureTarget.Texture2d, icon_tex);

                GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
                GL.Enable(EnableCap.Blend);

                GL.BindVertexArray(vao2);
                GL.DrawArrays(PrimitiveType.Triangles, 0, 6);
                windowComp.SwapBuffers(WindowHandle2);
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
