

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

    public static void Main(string[] args)
    {
        windowComp = new WindowComponent();

        windowComp.Initialize(PalComponents.Window);

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
            //sRGBFramebuffer = true,
            //Multisample = true,
            //Samples = 8,
            DepthBits = ContextDepthBits.Depth24,
            StencilBits = ContextStencilBits.Stencil8,
        };

        OpenGLContextHandle context = glComp.CreateFromWindow(handle, contextSettings);

        glComp.SetCurrentContext(context);

        Win32BindingsContext w32bc = new Win32BindingsContext(glComp, context);
        GLLoader.LoadBindings(w32bc);

        Init();

        windowComp.Loop(handle, Render);
    }

    static bool enabled_sRGB = false;
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
    }

    static VertexArrayHandle vao;
    static BufferHandle buffer;
    static ProgramHandle program;

    const string vertexShaderSource =
@"#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aColor;

out vec3 oColor;

void main()
{
    gl_Position = vec4(aPos.x, aPos.y, aPos.z, 1.0);
    oColor = aColor;
}";

    const string fragmentShaderSource =
@"#version 330 core
in vec3 oColor;

out vec4 FragColor;

void main()
{
    FragColor = vec4(oColor, 1.0f);
}";

    public static void Init()
    {
        vao = GL.GenVertexArray();
        buffer = GL.GenBuffer();

        float[] vertices = new float[]
        {
            -0.5f, -0.5f, 0.0f,     1f, 0f, 0f,
             0.5f, -0.5f, 0.0f,     0f, 1f, 0f,
             0.0f,  0.5f, 0.0f,     0f, 0f, 1f,
        };

        GL.BindBuffer(BufferTargetARB.ArrayBuffer, buffer);
        GL.BufferData(BufferTargetARB.ArrayBuffer, vertices, BufferUsageARB.StaticDraw);

        CheckError("buffer");

        GL.BindVertexArray(vao);

        GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, sizeof(float) * 6, 0);
        GL.EnableVertexAttribArray(0);

        GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, sizeof(float) * 6, sizeof(float) * 3);
        GL.EnableVertexAttribArray(1);

        CheckError("vao");

        var vert = GL.CreateShader(ShaderType.VertexShader);
        var frag = GL.CreateShader(ShaderType.FragmentShader);

        GL.ShaderSource(vert, vertexShaderSource);
        GL.ShaderSource(frag, fragmentShaderSource);

        GL.CompileShader(vert);
        GL.CompileShader(frag);

        program = GL.CreateProgram();

        GL.AttachShader(program, vert);
        GL.AttachShader(program, frag);

        GL.LinkProgram(program);

        GL.DetachShader(program, vert);
        GL.DetachShader(program, frag);

        GL.DeleteShader(vert);
        GL.DeleteShader(frag);

        GL.UseProgram(program);

        CheckError("shader");

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

        //GL.Enable(EnableCap.FramebufferSrgb);
    }

    public static bool Render()
    {
        

        GL.ClearColor(Color4.Darkslategray);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);
        windowComp.GetClientSize(handle, out int width, out int height);
        GL.Viewport(0, 0, width, height);

        CheckError("clear");

        GL.BindVertexArray(vao);
        GL.DrawArrays(PrimitiveType.Triangles, 0, 3);

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
