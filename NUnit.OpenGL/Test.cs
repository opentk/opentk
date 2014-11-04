using NUnit.Framework;
using System;

namespace NUnit.OpenGL
{
	[TestFixture()]
	public class GameWindowTests
	{
		[Test()]
		public void OpenClose()
		{
			OpenTK.GameWindow gamewindow = new OpenTK.GameWindow();
			gamewindow.Close();
		}

		[Test()]
		public void OpenExit()
		{
			OpenTK.GameWindow gamewindow = new OpenTK.GameWindow();
			gamewindow.Exit();
		}

		[Test()]
		public void OpenRunExit()
		{
			OpenTK.GameWindow gamewindow = new OpenTK.GameWindow();
			gamewindow.UpdateFrame += (object sender, OpenTK.FrameEventArgs e) =>
			{
				var me = sender as OpenTK.GameWindow;
				me.Exit();
			};
			gamewindow.Run();
		}

		[Test()]
		public void ClearColor()
		{
			OpenTK.GameWindow gamewindow = new OpenTK.GameWindow();
			gamewindow.RenderFrame += (object sender, OpenTK.FrameEventArgs e) =>
			{
				var me = sender as OpenTK.GameWindow;

				OpenTK.Graphics.OpenGL.GL.ClearColor(System.Drawing.Color.CornflowerBlue);
				OpenTK.Graphics.OpenGL.GL.Clear(OpenTK.Graphics.OpenGL.ClearBufferMask.ColorBufferBit);

				me.SwapBuffers();

				var pixels = new byte[32 * 32 * 4];
				OpenTK.Graphics.OpenGL.GL.ReadPixels(0, 0, 32, 32, OpenTK.Graphics.OpenGL.PixelFormat.Rgba, OpenTK.Graphics.OpenGL.PixelType.UnsignedByte, pixels);

				for(int i = 0; i < pixels.Length; i += 4)
				{
					Assert.AreEqual(System.Drawing.Color.CornflowerBlue.R, pixels[i + 0]);
					Assert.AreEqual(System.Drawing.Color.CornflowerBlue.G, pixels[i + 1]);
					Assert.AreEqual(System.Drawing.Color.CornflowerBlue.B, pixels[i + 2]);
					Assert.AreEqual(System.Drawing.Color.CornflowerBlue.A, pixels[i + 3]);
				}

				me.Exit();
			};
			gamewindow.Run();
		}
	}
}

