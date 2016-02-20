// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Drawing;
using System.Threading;

using Gtk;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Examples.GLWidget
{
    [Example("GLWidget Simple", ExampleCategory.OpenTK, "GLWidget", 1, Documentation="GLWidgetSimple")]
    public class SimpleWindow : Window
    {
        VBox vbox1;
        HBox hbox1;
        Button button_red, button_green, button_blue;
        OpenTK.GLWidget glwidget1;

        public SimpleWindow()
            : base(WindowType.Toplevel)
        {
            Build();
        }

        private void Build()
        {
            this.Title = "Sample GLWidget Example";
            this.DefaultWidth = 800;
            this.DefaultHeight = 600;

            vbox1 = new VBox();

            glwidget1 = new OpenTK.GLWidget();
            glwidget1.Initialized += Glwidget1_Initialized;

            // do note that if you are placing the widget inside a container you have to do it after initalization
            var t = new Thread(new ThreadStart(delegate {
                Thread.Sleep(50);

                Application.Invoke(delegate {
                    vbox1.PackStart(glwidget1, true, true, 1);
                    glwidget1.Show();
                });
            }));
            t.Start();

            hbox1 = new HBox();

            button_blue = new Button("Clear Blue");
            button_blue.Clicked += Button_blue_Clicked;
            hbox1.PackStart(button_blue, true, true, 0);

            button_green = new Button("Clear Green");
            button_green.Clicked += Button_green_Clicked;
            hbox1.PackStart(button_green, true, true, 1);

            button_red = new Button("Clear Red");
            button_red.Clicked += Button_red_Clicked;
            hbox1.PackStart(button_red, true, true, 2);

            vbox1.PackStart(hbox1, false, false, 0);

            this.Add(vbox1);
            this.ShowAll();

            this.DeleteEvent += OnDeleteEvent;
        }

        #region Events

        protected void Glwidget1_Initialized(object sender, EventArgs e)
        {
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);

            glwidget1.SizeAllocated += Glwidget1_SizeAllocated;
            glwidget1.RenderFrame += Glwidget1_RenderFrame;
        }

        protected void Glwidget1_SizeAllocated(object o, SizeAllocatedArgs args)
        {
            GL.Viewport(0, 0, args.Allocation.Width, args.Allocation.Height);
        }

        protected void Glwidget1_RenderFrame(object sender, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Begin(PrimitiveType.Triangles);

            GL.Color3(Color.MidnightBlue);
            GL.Vertex2(-1.0f, 1.0f);
            GL.Color3(Color.SpringGreen);
            GL.Vertex2(0.0f, -1.0f);
            GL.Color3(Color.Ivory);
            GL.Vertex2(1.0f, 1.0f);

            GL.End();

            GraphicsContext.CurrentContext.SwapBuffers();
        }

        protected void Button_blue_Clicked(object sender, EventArgs e)
        {
            GL.ClearColor(Color.RoyalBlue);
            glwidget1.QueueDraw();
        }

        protected void Button_green_Clicked(object sender, EventArgs e)
        {
            GL.ClearColor(Color.ForestGreen);
            glwidget1.QueueDraw();
        }

        protected void Button_red_Clicked(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Crimson);
            glwidget1.QueueDraw();
        }

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        #endregion

        #region public static void Main()

        public static void Main(string[] args)
        {
            Application.Init();

            SimpleWindow win = new SimpleWindow();
            win.Show();

            Application.Run();
        }

        #endregion
    }
}
