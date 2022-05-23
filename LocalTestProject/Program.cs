

using OpenTK.Core.Platform;
using OpenTK.Core.Platform.Implementations.Windows;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

namespace LocalTestProject;

public class Program
{
    static WindowComponent windowComp;
    static WindowHandle handle;

    static IMouseComponent mouseComp = new MouseComponent();
    static ICursorComponent cursorComp = new CursorComponent();

    static IDisplayComponent dispComp = new DisplayComponent();

    static CursorHandle CursorHandle;
    static CursorHandle ImageCursorHandle;
    static CursorHandle FileCursorHandle;

    public static void Main(string[] args)
    {
        windowComp = new WindowComponent();

        windowComp.Initialize(PalComponents.Window);

        dispComp.Initialize(PalComponents.Display);

        handle = windowComp.Create();

        windowComp.SetTitle(handle, "Cool test window");

        windowComp.SetSize(handle, 600, 400);
        windowComp.SetPosition(handle, 100, 100);

        windowComp.SetBorderStyle(handle, WindowStyle.Borderless);
        WindowStyle border = windowComp.GetBorderStyle(handle);
        Console.WriteLine($"Border: {border}");

        windowComp.SetBorderStyle(handle, WindowStyle.FixedBorder);
        border = windowComp.GetBorderStyle(handle);
        Console.WriteLine($"Border: {border}");

        windowComp.SetBorderStyle(handle, WindowStyle.ResizableBorder);
        border = windowComp.GetBorderStyle(handle);
        Console.WriteLine($"Border: {border}");

        windowComp.GetPosition(handle, out var x, out var y);
        windowComp.GetSize(handle, out var width, out var height);
        windowComp.GetClientPosition(handle, out var cx, out var cy);
        windowComp.GetClientSize(handle, out var cwidth, out var cheight);
        Console.WriteLine($"Window: X: {x}, Y: {y}, Width: {width}, Height: {height}");
        Console.WriteLine($"Client: X: {cx}, Y {cy} Width: {cwidth}, Height: {cheight}");

        windowComp.SetClientSize(handle, 600, 400);
        windowComp.SetClientPosition(handle, 100, 100);

        windowComp.GetPosition(handle, out x, out y);
        windowComp.GetSize(handle, out width, out height);
        windowComp.GetClientPosition(handle, out cx, out cy);
        windowComp.GetClientSize(handle, out cwidth, out cheight);
        Console.WriteLine($"Window: X: {x}, Y: {y}, Width: {width}, Height: {height}");
        Console.WriteLine($"Client: X: {cx}, Y {cy} Width: {cwidth}, Height: {cheight}");

        var mode = windowComp.GetMode(handle);
        Console.WriteLine($"Mode: {mode}");

        windowComp.SetMode(handle, WindowMode.Normal);

        mode = windowComp.GetMode(handle);
        Console.WriteLine($"Mode: {mode}");

        var eventQueue = windowComp.GetEventQueue(handle);
        eventQueue.EventRaised += EventQueue_EventRaised;

        OpenGLComponent glComp = new OpenGLComponent();
        glComp.Initialize(PalComponents.OpenGL);

        ContextSettings contextSettings = new ContextSettings()
        {
            DoubleBuffer = true,
            sRGBFramebuffer = false,
            //Multisample = true,
            //Samples = 8,
            DepthBits = ContextDepthBits.Depth24,
            StencilBits = ContextStencilBits.Stencil8,
        };

        OpenGLContextHandle context = glComp.CreateFromWindow(handle, contextSettings);

        glComp.SetCurrentContext(context);

        Win32BindingsContext w32bc = new Win32BindingsContext(glComp, context);
        GLLoader.LoadBindings(w32bc);

        CursorHandle = cursorComp.Create();
        cursorComp.Load(CursorHandle, SystemCursorType.TextBeam);
        cursorComp.GetSize(CursorHandle, out _, out _);
        windowComp.SetCursor(handle, CursorHandle);

        ImageCursorHandle = cursorComp.Create();
        byte[] image = new byte[16 * 16 * 3];
        byte[] mask  = new byte[16 * 16 * 1];
        for (int ccx = 0; ccx < 16; ccx++)
        {
            for (int ccy = 0; ccy < 16; ccy++)
            {
                int index = (ccy * 16 + ccx) * 3;

                image[index + 0] = (byte)(ccx * 16);
                image[index + 1] = (byte)(ccx * 16);
                image[index + 2] = (byte)(ccx * 16);
                //image[index + 1] = (byte)(ccy * 16);
                //image[index + 2] = (byte)(ccx * ccy);
                //image[index + 3] = (byte)(ccx * ccy);

                mask[(ccy * 16 + ccx)] = (byte)((ccy % 2 == 0) ? 1 : 0);
            }
        }
        cursorComp.SetHotspot(ImageCursorHandle, 8, 8);
        cursorComp.Load(ImageCursorHandle, 16, 16, image, mask);
        windowComp.SetCursor(handle, ImageCursorHandle);

        FileCursorHandle = cursorComp.Create();
        cursorComp.Load(FileCursorHandle, "Cute Light Green Normal Select.cur");
        windowComp.SetCursor(handle, FileCursorHandle);

        {
            cursorComp.GetSize(ImageCursorHandle, out int curW, out int curH);
            Console.WriteLine($"Width: {curW}, Height: {curH}");
        }
        Init();

        windowComp.Loop(handle, Render);
    }

    static bool enabled_sRGB = false;
    static bool is_ibeam = false;
    private static void EventQueue_EventRaised(object sender, WindowEventType type, WindowEventArgs arguments)
    {
        if (enabled_sRGB == false)
        {
            Console.WriteLine("Enabled sRGB");
            GL.Enable(EnableCap.FramebufferSrgb);
            enabled_sRGB = true;
        }
        else
        {
            Console.WriteLine("Disabled sRGB");
            GL.Disable(EnableCap.FramebufferSrgb);
            enabled_sRGB = false;
        }

        if (is_ibeam)
        {
            //cursorComp.Load(CursorHandle, SystemCursorType.TextBeam);
        }
        else
        {
            //cursorComp.Load(CursorHandle, SystemCursorType.Default);
        }
        //windowComp.SetCursor(handle, CursorHandle);

        is_ibeam = !is_ibeam;

        cursorComp.GetSize(ImageCursorHandle, out int width, out int height);
        cursorComp.GetHotspot(ImageCursorHandle, out int x, out int y);
        cursorComp.SetHotspot(ImageCursorHandle, (x + 1) % width, y);
    }

    static VertexArrayHandle vao;
    static BufferHandle buffer;
    static ProgramHandle program;

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
        cursorComp.GetImage(handle, data);

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

    public static void Init()
    {
        vao = GL.GenVertexArray();
        buffer = GL.GenBuffer();

        float[] vertices = new float[]
        {
            -1f * 0.5f, -1f * 0.5f, 0f,     0f, 0f,     1f, 0f, 0f,
             1f * 0.5f, -1f * 0.5f, 0f,     1f, 0f,     0f, 1f, 0f,
             1f * 0.5f,  1f * 0.5f, 0f,     1f, 1f,     0f, 0f, 1f,

             1f * 0.5f,  1f * 0.5f, 0f,     1f, 1f,     0f, 0f, 1f,
            -1f * 0.5f,  1f * 0.5f, 0f,     0f, 1f,     0f, 1f, 0f,
            -1f * 0.5f, -1f * 0.5f, 0f,     0f, 0f,     1f, 0f, 0f,
        };

        GL.BindBuffer(BufferTargetARB.ArrayBuffer, buffer);
        GL.BufferData(BufferTargetARB.ArrayBuffer, vertices, BufferUsageARB.StaticDraw);

        CheckError("buffer");

        GL.BindVertexArray(vao);

        GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, sizeof(float) * 8, 0);
        GL.EnableVertexAttribArray(0);

        GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, sizeof(float) * 8, sizeof(float) * 3);
        GL.EnableVertexAttribArray(1);

        GL.VertexAttribPointer(2, 3, VertexAttribPointerType.Float, false, sizeof(float) * 8, sizeof(float) * 5);
        GL.EnableVertexAttribArray(2);

        CheckError("vao");

        var vert = GL.CreateShader(ShaderType.VertexShader);
        var frag = GL.CreateShader(ShaderType.FragmentShader);

        GL.ShaderSource(vert, vertexShaderSource);
        GL.ShaderSource(frag, fragmentShaderSource);

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

        program = GL.CreateProgram();

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

        GL.UseProgram(program);

        CheckError("shader");

        cursor_tex = GetCursorImage(ImageCursorHandle);

        CheckError("get cursor tex");

        /*
        int numExtensions = 0;
        Console.WriteLine($"Extensions:");
        GL.GetInteger(GetPName.NumExtensions, ref numExtensions);
        for (int i = 0; i < numExtensions; i++)
        {
            string ext = GL.GetStringi(StringName.Extensions, (uint)i);
            
            if (ext.StartsWith("WGL"))
            {
                Console.WriteLine("  " + ext);
            }
            else
            {
                Console.WriteLine(ext);
            }
        }
        */

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

    public static bool Render()
    {
        GL.ClearColor(new Color4<Rgba>(127/255f, 0, 64/255f, 255));
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);
        windowComp.GetClientSize(handle, out int width, out int height);
        GL.Viewport(0, 0, width, height);

        CheckError("clear");

        mouseComp.GetPosition(null, out int x, out int y);
        windowComp.ScreenToClient(handle, x, y, out int clientX, out int clientY);
        windowComp.SetTitle(handle, $"({clientX},{clientY})");

        GL.ActiveTexture(TextureUnit.Texture0);
        GL.BindTexture(TextureTarget.Texture2d, cursor_tex);

        GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
        GL.Enable(EnableCap.Blend);

        GL.BindVertexArray(vao);
        GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

        CheckError("draw");

        windowComp.SwapBuffers(handle);
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
