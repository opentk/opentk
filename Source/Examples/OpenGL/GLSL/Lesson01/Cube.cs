using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using OpenTK.OpenGL;

namespace Lesson01
{
    public partial class Cube : Form
    {
        #region Shaders
        string[] vertex_shader =
        {
            "void main() { ",
            "gl_FrontColor = gl_Color;",
            "gl_Position = ftransform();",
            "}"
        };

        string[] fragment_shader =
        {
            "void main() { gl_FragColor = gl_Color; }"
        };
        #endregion

        Context context;
        static float angle;

        #region Constructor
        public Cube()
        {
            InitializeComponent();

            Application.Idle += new EventHandler(OnApplicationIdle);
        }
        #endregion

        #region Load event handler
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            context = Context.Create(this, 8, 8, 8, 8, 16, 0, false);

            Text =
                GL.GetString(Enums.StringName.VENDOR) + " " +
                GL.GetString(Enums.StringName.RENDERER) + " " +
                GL.GetString(Enums.StringName.VERSION);

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(Enums.EnableCap.DEPTH_TEST);

            int vertex_shader_object, fragment_shader_object;
            int[] status = new int[1];
            int shader_program;

            vertex_shader_object = GL.CreateShader(Enums.VERSION_2_0.VERTEX_SHADER);
            fragment_shader_object = GL.CreateShader(Enums.VERSION_2_0.FRAGMENT_SHADER);

            GL.ShaderSource(vertex_shader_object, 1, vertex_shader, null);
            GL.CompileShader(vertex_shader_object);
            GL.GetShaderiv(vertex_shader_object, Enums.VERSION_2_0.COMPILE_STATUS, status);
            //if (status[0] != GL._TRUE)
            //    throw new Exception("Could not compile vertex shader");

            GL.ShaderSource(fragment_shader_object, 1, fragment_shader, null);
            GL.CompileShader(fragment_shader_object);
            GL.GetShaderiv(fragment_shader_object, Enums.VERSION_2_0.COMPILE_STATUS, status);
            //if (status[0] != GL._TRUE)
            //    throw new Exception("Could not compile fragment shader");

            shader_program = GL.CreateProgram();
            GL.AttachShader(shader_program, fragment_shader_object);
            GL.AttachShader(shader_program, vertex_shader_object);

            GL.LinkProgram(shader_program);
            GL.UseProgram(shader_program);

            OnResize(e);
        }
        #endregion

        #region Resize event handler
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (ClientSize.Height == 0)
                ClientSize = new System.Drawing.Size(ClientSize.Width, 1);

            if (context == null)
                return;
            
            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

            double ratio = 0.0;
            if (ClientSize.Width > ClientSize.Height)
                ratio = ClientSize.Width / (double)ClientSize.Height;
            //else
            //    ratio = ClientSize.Height / (double)ClientSize.Width;

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();

            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }
        #endregion

        #region Paint event handler
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
            GL.Rotatef(angle, 0.0f, 1.0f, 0.0f);
            angle += 0.05f;

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT | Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            DrawCube();

            context.SwapBuffers();

            //Thread.Sleep(1);
            //this.Invalidate();
        }
        #endregion

        #region Application main loop
        /// <summary>
        /// Called when all pending messages have been processed, this is where the application 'Main Loop' resides.
        /// </summary>
        /// <param name="sender">Not used.</param>
        /// <param name="e">Not used.</param>
        void OnApplicationIdle(object sender, EventArgs e)
        {
            // Check if any new messages have popped up. If not, then run the logic at full speed.
            while (IsApplicationIdle())
            {
                // We'd like to play nice with the scheduler. If the window is not in focus,
                // we give back some thread-time to the OS, to allow other apps to function full-speed.
                // However, if the window _is_ in focus we grab all processor resources.
                if (ActiveForm != this)
                    Thread.Sleep(100);
                OnPaint(null);
            }
        }
        #endregion

        #region IsApplicationIdle
        /// <summary>
        /// Checks if there all pending messages have been processed.
        /// </summary>
        /// <returns>Returns true if there are no messages left, false otherwise.</returns>
        static public bool IsApplicationIdle()
        {
            //OpenTK.Platform.Windows.Api.MessageStruct msg;
            Message msg;
            return !OpenTK.Platform.Windows.Api.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
        }
        #endregion

        #region DrawCube
        public void DrawCube()
        {
            GL.Begin(Enums.BeginMode.QUADS);

            GL.Color3f(1, 0, 0);
            GL.Vertex3f(-1.0f, -1.0f, -1.0f);
            GL.Vertex3f(-1.0f, 1.0f, -1.0f);
            GL.Vertex3f(1.0f, 1.0f, -1.0f);
            GL.Vertex3f(1.0f, -1.0f, -1.0f);

            GL.Color3f(1, 1, 0);
            GL.Vertex3f(-1.0f, -1.0f, -1.0f);
            GL.Vertex3f(1.0f, -1.0f, -1.0f);
            GL.Vertex3f(1.0f, -1.0f, 1.0f);
            GL.Vertex3f(-1.0f, -1.0f, 1.0f);

            GL.Color3f(1, 0, 1);
            GL.Vertex3f(-1.0f, -1.0f, -1.0f);
            GL.Vertex3f(-1.0f, -1.0f, 1.0f);
            GL.Vertex3f(-1.0f, 1.0f, 1.0f);
            GL.Vertex3f(-1.0f, 1.0f, -1.0f);

            GL.Color3f(0, 1, 0);
            GL.Vertex3f(-1.0f, -1.0f, 1.0f);
            GL.Vertex3f(1.0f, -1.0f, 1.0f);
            GL.Vertex3f(1.0f, 1.0f, 1.0f);
            GL.Vertex3f(-1.0f, 1.0f, 1.0f);

            GL.Color3f(0, 0, 1);
            GL.Vertex3f(-1.0f, 1.0f, -1.0f);
            GL.Vertex3f(-1.0f, 1.0f, 1.0f);
            GL.Vertex3f(1.0f, 1.0f, 1.0f);
            GL.Vertex3f(1.0f, 1.0f, -1.0f);

            GL.Color3f(0, 1, 1);
            GL.Vertex3f(1.0f, -1.0f, -1.0f);
            GL.Vertex3f(1.0f, 1.0f, -1.0f);
            GL.Vertex3f(1.0f, 1.0f, 1.0f);
            GL.Vertex3f(1.0f, -1.0f, 1.0f);

            GL.End();
        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cube());
        }
    }
}