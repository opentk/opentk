// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Examples.Tutorial
{

    [Example("VBO Dynamic", ExampleCategory.OpenGL, "1.x", 4, Documentation = "VBODynamic")]
    class T09_VBO_Dynamic : GameWindow
    {
        /// <summary>Creates a 800x600 window with the specified title.</summary>
        public T09_VBO_Dynamic()
            : base(800, 600)
        {
            this.VSync = VSyncMode.Off;
        }

        #region Particles
        static int MaxParticleCount = 2000;
        int VisibleParticleCount;
        VertexC4ubV3f[] VBO = new VertexC4ubV3f[MaxParticleCount];
        ParticleAttribut[] ParticleAttributes = new ParticleAttribut[MaxParticleCount];

        // this struct is used for drawing
        struct VertexC4ubV3f
        {
            public byte R, G, B, A;
            public Vector3 Position;

            public static int SizeInBytes = 16;
        }

        // this struct is used for updates
        struct ParticleAttribut
        {
            public Vector3 Direction;
            public uint Age;
            //  more stuff could be here: Rotation, Radius, whatever
        }

        uint VBOHandle;
        #endregion Particles

        /// <summary>Load resources here.</summary>
        /// <param name="e">Not used.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Version version = new Version(GL.GetString(StringName.Version).Substring(0, 3));
            Version target = new Version(1, 5);
            if (version < target)
            {
                throw new NotSupportedException(String.Format(
                    "OpenGL {0} is required (you only have {1}).", target, version));
            }

            GL.ClearColor(.1f, 0f, .1f, 0f);
            GL.Enable(EnableCap.DepthTest);

            // Setup parameters for Points
            GL.PointSize(5f);
            GL.Enable(EnableCap.PointSmooth);
            GL.Hint(HintTarget.PointSmoothHint, HintMode.Nicest);

            // Setup VBO state
            GL.EnableClientState(ArrayCap.ColorArray);
            GL.EnableClientState(ArrayCap.VertexArray);

            GL.GenBuffers(1, out VBOHandle);

            // Since there's only 1 VBO in the app, might aswell setup here.
            GL.BindBuffer(BufferTarget.ArrayBuffer, VBOHandle);
            GL.ColorPointer(4, ColorPointerType.UnsignedByte, VertexC4ubV3f.SizeInBytes, (IntPtr)0);
            GL.VertexPointer(3, VertexPointerType.Float, VertexC4ubV3f.SizeInBytes, (IntPtr)(4 * sizeof(byte)));

            Random rnd = new Random();
            Vector3 temp = Vector3.Zero;

            // generate some random stuff for the particle system
            for (uint i = 0; i < MaxParticleCount; i++)
            {
                VBO[i].R = (byte)rnd.Next(0, 256);
                VBO[i].G = (byte)rnd.Next(0, 256);
                VBO[i].B = (byte)rnd.Next(0, 256);
                VBO[i].A = (byte)rnd.Next(0, 256); // isn't actually used
                VBO[i].Position = Vector3.Zero; // all particles are born at the origin

                // generate direction vector in the range [-0.25f...+0.25f] 
                // that's slow enough so you can see particles 'disappear' when they are respawned
                temp.X = (float)((rnd.NextDouble() - 0.5) * 0.5f);
                temp.Y = (float)((rnd.NextDouble() - 0.5) * 0.5f);
                temp.Z = (float)((rnd.NextDouble() - 0.5) * 0.5f);
                ParticleAttributes[i].Direction = temp; // copy 
                ParticleAttributes[i].Age = 0;
            }

            VisibleParticleCount = 0;

        }

        protected override void OnUnload(EventArgs e)
        {
            GL.DeleteBuffers(1, ref VBOHandle);
        }

        /// <summary>
        /// Called when your window is resized. Set your viewport here. It is also
        /// a good place to set up your projection matrix (which probably changes
        /// along when the aspect ratio of your window).
        /// </summary>
        /// <param name="e">Contains information on the new Width and Size of the GameWindow.</param>
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            GL.MatrixMode(MatrixMode.Projection);
            Matrix4 p = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, Width / (float)Height, 0.1f, 50.0f);
            GL.LoadMatrix(ref p);

            GL.MatrixMode(MatrixMode.Modelview);
            Matrix4 mv = Matrix4.LookAt(Vector3.UnitZ, Vector3.Zero, Vector3.UnitY);
            GL.LoadMatrix(ref mv);
        }

        /// <summary>
        /// Called when it is time to setup the next frame. Add you game logic here.
        /// </summary>
        /// <param name="e">Contains timing information for framerate independent logic.</param>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            var keyboard = OpenTK.Input.Keyboard.GetState();
            if (keyboard[Key.Escape])
            {
                Exit();
            }

            // will update particles here. When using a Physics SDK, it's update rate is much higher than
            // the framerate and it would be a waste of cycles copying to the VBO more often than drawing it.
            if (VisibleParticleCount < MaxParticleCount)
                VisibleParticleCount++;

            Vector3 temp;

            for (int i = MaxParticleCount - VisibleParticleCount; i < MaxParticleCount; i++)
            {
                if (ParticleAttributes[i].Age >= MaxParticleCount)
                {
                    // reset particle
                    ParticleAttributes[i].Age = 0;
                    VBO[i].Position = Vector3.Zero;
                }
                else
                {
                    ParticleAttributes[i].Age += (uint)Math.Max(ParticleAttributes[i].Direction.LengthFast * 10, 1);
                    Vector3.Multiply(ref ParticleAttributes[i].Direction, (float)e.Time, out temp);
                    Vector3.Add(ref VBO[i].Position, ref temp, out VBO[i].Position);
                }
            }
        }

        /// <summary>
        /// Called when it is time to render the next frame. Add your rendering code here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            this.Title = VisibleParticleCount + " Points. FPS: " + string.Format("{0:F}", 1.0 / e.Time);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.PushMatrix();

            GL.Translate(0f, 0f, -5f);

            // Tell OpenGL to discard old VBO when done drawing it and reserve memory _now_ for a new buffer.
            // without this, GL would wait until draw operations on old VBO are complete before writing to it
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(VertexC4ubV3f.SizeInBytes * MaxParticleCount), IntPtr.Zero, BufferUsageHint.StreamDraw);
            // Fill newly allocated buffer
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(VertexC4ubV3f.SizeInBytes * MaxParticleCount), VBO, BufferUsageHint.StreamDraw);
            // Only draw particles that are alive
            GL.DrawArrays(PrimitiveType.Points, MaxParticleCount - VisibleParticleCount, VisibleParticleCount);

            GL.PopMatrix();

            SwapBuffers();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // The 'using' idiom guarantees proper resource cleanup.
            // We request 30 UpdateFrame events per second, and unlimited
            // RenderFrame events (as fast as the computer can handle).
            using (T09_VBO_Dynamic example = new T09_VBO_Dynamic())
            {
                Utilities.SetWindowTitle(example);
                example.Run(60.0, 0.0);
            }
        }
    }
}