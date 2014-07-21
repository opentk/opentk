// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Examples.Tutorial
{
    [Example( "Anaglyph Stereo", ExampleCategory.OpenGL, "1.x", Documentation = "Anaglyph" )]

    class Anaglyph : GameWindow
    {

        Examples.Shapes.DrawableShape Object;

        /// <summary>Creates a 800x600 window with the specified title.</summary>
        public Anaglyph()
            : base(800, 600, GraphicsMode.Default, "OpenTK Quick Start Sample", GameWindowFlags.Default, DisplayDevice.Default, 3, 1, GraphicsContextFlags.Default)
        {
            VSync = VSyncMode.On;
        }

        /// <summary>Load resources here.</summary>
        /// <param name="e">Not used.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(System.Drawing.Color.Black);
            GL.Enable(EnableCap.DepthTest);

            GL.Enable( EnableCap.Lighting );
            GL.Enable( EnableCap.Light0 );

            Object = new Examples.Shapes.MengerSponge(1.0, Shapes.MengerSponge.eSubdivisions.Two, true );
            // Object = new Examples.Shapes.TorusKnot( 256, 32, 0.1, 3, 4, 1, true );
        }

        protected override void OnUnload( EventArgs e )
        {
            base.OnUnload( e );

            Object.Dispose();
        }

        /// <summary>
        /// Called when your window is resized. Set your viewport here. It is also
        /// a good place to set up your projection matrix (which probably changes
        /// along when the aspect ratio of your window).
        /// </summary>
        /// <param name="e">Not used.</param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(ClientRectangle);
        }

        /// <summary>
        /// Called when it is time to setup the next frame. Add you game logic here.
        /// </summary>
        /// <param name="e">Contains timing information for framerate independent logic.</param>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            var keyboard = OpenTK.Input.Keyboard.GetState();
            if (keyboard[Key.Escape])
                Exit();
        }

        struct Camera
        {
            public Vector3 Position, Direction, Up;
            public double NearPlane, FarPlane;
            public double EyeSeparation;
            public double Aperture; // FOV in degrees
            public double FocalLength;
        }

        enum Eye
        {
            left,
            right,
        }

        void SetupCamera( Eye eye )
        {
            Camera camera;

            camera.Position = Vector3.UnitZ;
            camera.Up = Vector3.UnitY;
            camera.Direction = -Vector3.UnitZ;
            camera.NearPlane = 1.0;
            camera.FarPlane = 5.0;
            camera.FocalLength = 2.0;
            camera.EyeSeparation = camera.FocalLength / 30.0;
            camera.Aperture = 75.0;

            double left, right,
                   bottom, top;

            double widthdiv2 = camera.NearPlane * Math.Tan( MathHelper.DegreesToRadians( (float)( camera.Aperture / 2.0 ) ) ); // aperture in radians
            double precalc1 = ClientRectangle.Width / (double)ClientRectangle.Height * widthdiv2;
            double precalc2 = 0.5 * camera.EyeSeparation * camera.NearPlane / camera.FocalLength;

            Vector3 Right = Vector3.Cross( camera.Direction, camera.Up ); // Each unit vectors
            Right.Normalize();

            Right.X *= (float)( camera.EyeSeparation / 2.0 );
            Right.Y *= (float)( camera.EyeSeparation / 2.0 );
            Right.Z *= (float)( camera.EyeSeparation / 2.0 );

            // Projection Matrix
            top = widthdiv2;
            bottom = -widthdiv2;
            if ( eye == Eye.right )
            {
                left = -precalc1 - precalc2;
                right = precalc1 - precalc2;
            }
            else
            {
                left = -precalc1 + precalc2;
                right = precalc1 + precalc2;
            }

            GL.MatrixMode( MatrixMode.Projection );
            GL.LoadIdentity();
            GL.Frustum( left, right, bottom, top, camera.NearPlane, camera.FarPlane );

            // Modelview Matrix
            Matrix4 modelview;
            if ( eye == Eye.right )
            {
                modelview = Matrix4.LookAt(
                    new Vector3( camera.Position.X + Right.X, camera.Position.Y + Right.Y, camera.Position.Z + Right.Z ),
                    new Vector3( camera.Position.X + Right.X + camera.Direction.X, camera.Position.Y + Right.Y + camera.Direction.Y, camera.Position.Z + Right.Z + camera.Direction.Z ),
                    camera.Up );
            }
            else
            {
                modelview = Matrix4.LookAt(
                    new Vector3( camera.Position.X - Right.X, camera.Position.Y - Right.Y, camera.Position.Z - Right.Z ),
                    new Vector3( camera.Position.X - Right.X + camera.Direction.X, camera.Position.Y - Right.Y + camera.Direction.Y, camera.Position.Z - Right.Z + camera.Direction.Z ),
                    camera.Up );
            }
            GL.MatrixMode( MatrixMode.Modelview );
            GL.LoadIdentity();
            GL.MultMatrix( ref modelview );

        }

        float Angle;

        void Draw()
        {
            GL.Translate( 0f, 0f, -2f );
            GL.Rotate( Angle, Vector3.UnitY );
            Object.Draw();
        }

        /// <summary>
        /// Called when it is time to render the next frame. Add your rendering code here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        protected override void OnRenderFrame( FrameEventArgs e )
        {
            Angle += (float)(e.Time *20.0);

    
            GL.Clear( ClearBufferMask.DepthBufferBit | ClearBufferMask.ColorBufferBit );
            SetupCamera( Eye.right );
            GL.ColorMask( true, false, false, true );
            Draw();

            GL.Clear( ClearBufferMask.DepthBufferBit ); // 
            SetupCamera( Eye.left );
            GL.ColorMask( false, true, true, true );
            Draw();

            GL.ColorMask( true, true, true, true );
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
            using (Anaglyph game = new Anaglyph())
            {
                game.Run(10.0);
            }
        }
    }
}