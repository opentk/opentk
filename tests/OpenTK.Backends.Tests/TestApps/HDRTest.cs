using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    [TestApp]
    internal class HDRTest : ITestApp
    {
        public static string Name => "HDR Test";

        private WindowHandle Window;
        private OpenGLContextHandle Context;

        private bool HasHDR = false;

        const string vertex_shader =
@"#version 330 core

out vec2 fUV;
 
void main()
{
    float x = -1.0 + float((gl_VertexID & 1) << 2);
    float y = -1.0 + float((gl_VertexID & 2) << 1);
    fUV.x = (x + 1.0) * 0.5;
    fUV.y = (y + 1.0) * 0.5;
    gl_Position = vec4(x, y, 0.0, 1.0);
}
";

        /*
            "Waveform" by @XorDev
    
            I wish Soundcloud worked on ShaderToy again

            From: https://www.shadertoy.com/view/Wcc3z2
        */
        const string fragment_shader =
@"#version 330 core
in vec2 fUV;

out vec4 out_color;

uniform vec2 iResolution;
uniform float iTime;

uniform bool iHDR;

void mainImage(out vec4 O, vec2 I)
{
    //Raymarch iterator, step distance, depth and reflection
    float i, d, z, r;
    //Clear fragcolor and raymarch 90 steps
    for(O*= i; i++<9e1;
    //Pick color and attenuate
    O += (cos(z*.5+iTime+vec4(0,2,4,3))+1.3)/d/z)
    {
        //Raymarch sample point
        vec3 p = z * normalize(vec3(I+I,0) - iResolution.xyy);
        //Shift camera and get reflection coordinates
        r = max(-++p, 0.).y;
        //Mirror
        p.y += r+r;
        //Music test
        //-4.*texture(iChannel0, vec2(p.x,-10)/2e1+.5,2.).r
        
        //Sine waves
        for(d=1.; d<3e1; d+=d)
            p.y += cos(p*d+2.*iTime*cos(d)+z).x/d;
            
        //Step forward (reflections are softer)
        z += d = (.1*r+abs(p.y-1.)/ (1.+r+r+r*r) + max(d=p.z+3.,-d*.1))/8.;
    }
    if (iHDR)
        O = O/9e2;
    else
        //Tanh tonemapping
        O = tanh(O/9e2);
}

void main() {
    mainImage(out_color, fUV * iResolution);
}
";

        int program;
        int iResolutionLocation;
        int iTimeLocation;
        int iHDRLocation;

        float Time;

        public void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES)
        {
            Window = window;
            Context = context;

            ContextValues contextValues = Toolkit.OpenGL.GetContextValues(context);
            HasHDR = contextValues.PixelFormat != ContextPixelFormat.RGBA;

            Toolkit.Window.SetTitle(window, $"{Toolkit.Window.GetTitle(window)} - HDR: {HasHDR}");

            int vao = GL.GenVertexArray();
            GL.BindVertexArray(vao);

            int vert = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(vert, vertex_shader);
            GL.CompileShader(vert);
            if (GL.GetShaderi(vert, ShaderParameterName.CompileStatus) == 0)
            {
                GL.GetShaderInfoLog(vert, out string info);
                Debug.Assert(false, $"Vertex shader compilation error: {info}");
            }

            int frag = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(frag, fragment_shader);
            GL.CompileShader(frag);
            if (GL.GetShaderi(frag, ShaderParameterName.CompileStatus) == 0)
            {
                GL.GetShaderInfoLog(frag, out string info);
                Debug.Assert(false, $"Fragment shader compilation error: {info}");
            }

            program = GL.CreateProgram();
            GL.AttachShader(program, vert);
            GL.AttachShader(program, frag);
            GL.LinkProgram(program);
            if (GL.GetProgrami(program, ProgramProperty.LinkStatus) == 0)
            {
                GL.GetProgramInfoLog(program, out string info);
                Debug.Assert(false, $"Shader link error: {info}");
            }
            GL.DetachShader(program, vert);
            GL.DetachShader(program, frag);

            GL.DeleteShader(vert);
            GL.DeleteShader(frag);

            iResolutionLocation = GL.GetUniformLocation(program, "iResolution");
            iTimeLocation = GL.GetUniformLocation(program, "iTime");
            iHDRLocation = GL.GetUniformLocation(program, "iHDR");
        }

        public void HandleEvent(EventArgs args)
        {
            if (args is CloseEventArgs close)
            {
                // FIXME: Close OpenGL context related to this window.
                Toolkit.Window.Destroy(close.Window);
            }
        }

        public bool Update(float deltaTime)
        {
            Time += deltaTime;

            return false;
        }

        public void Render()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Toolkit.Window.GetFramebufferSize(Window, out Vector2i fbSizei);
            GL.Viewport(0, 0, fbSizei.X, fbSizei.Y);

            Vector2 fbSize = fbSizei;

            GL.UseProgram(program);
            GL.Uniform2f(iResolutionLocation, 1, ref fbSize);
            GL.Uniform1f(iTimeLocation, Time);
            GL.Uniform1i(iHDRLocation, HasHDR ? 1 : 0);

            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);

            Toolkit.OpenGL.SwapBuffers(Context);
        }

        public void Deinitialize()
        {
            GL.DeleteProgram(program);
        }
    }
}
