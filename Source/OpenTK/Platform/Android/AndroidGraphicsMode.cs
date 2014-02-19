#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2011 Xamarin, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using OpenTK.Graphics;
using Javax.Microedition.Khronos.Egl;
using Android.Util;
using Android.Runtime;
using System.Collections.Generic;

namespace OpenTK.Platform.Android
{
	/// <summary>
	///	  This class wraps an <see cref="T:Javax.Microedition.Khronos.Egl.EGLConfig" /> that represents this
	///	  graphics configuration in the OpenGL space. The underlying <see cref="T:Javax.Microedition.Khronos.Egl.EGLConfig" />
	///	  will only be created if there is a valid <see cref="T:Javax.Microedition.Khronos.Egl.EGLDisplay" /> passed to
	///	  one of the constructors. If user code does not pass a valid <see cref="T:Javax.Microedition.Khronos.Egl.EGLDisplay" />
	///	  the <see cref="T:OpenTK.Platform.Android.AndroidGraphicsContext" /> initialization will create one when
	///	  <see cref="M:OpenTK.Platform.Android.AndroidGameView.CreateFrameBuffer" /> is called, or if user code calls
	///	  <see cref="M:OpenTK.Platform.Android.AndroidGraphicsMode.Initialize(Javax.Microedition.Khronos.Egl.EGLDisplay,int)" />
	/// </summary>
	public class AndroidGraphicsMode : GraphicsMode, IGraphicsMode
	{
		int Version;

		public EGLConfig Config {
			get; private set;
		}

		public AndroidGraphicsMode () : base () {}

		/// <summary>
		///	  Creates an AndroidGraphicsMode instance with the defined settings.
		///	  Defaults to EGL 1.x. To use EGL 2.0, call the
		///	  <see cref="M:OpenTK.Platform.Android.AndroidGraphicsMode(Javax.Microedition.Khronos.Egl.EGLDisplay,int,OpenTK.Graphics.GraphicsMode)" />
		///	  or
		///	  <see cref="M:OpenTK.Platform.Android.AndroidGraphicsMode(Javax.Microedition.Khronos.Egl.EGLDisplay,int,OpenTK.Graphics.ColorFormat,int,int,int,int,bool)" />
		///	  constructors (pass null to the display parameter for lazy initialization)
		/// </summary>
		public AndroidGraphicsMode (ColorFormat color, int depth, int stencil, int samples, int buffers, bool stereo) :
			this (null, 1, color, depth, stencil, samples, buffers, stereo)
		{
		}

		/// <summary>
		///	  Creates an AndroidGraphicsMode instance, copying the values set in the mode parameter.
		///	  Passing null to the display parameter for lazy initialization is recommended.
		/// </summary>
		/// <param name="display">
		///	  A <see cref="T:Javax.Microedition.Khronos.Egl.EGLDisplay" /> with the display to use for creating the
		///	  <see cref="T:Javax.Microedition.Khronos.Egl.EGLConfig" /> that represents this graphics configuration in
		///	 the OpenGL space. Pass null for lazy initialization.
		/// </param>
		/// <param name="version">Requested OpenGL version (1 or 2)</param>
		/// <param name="mode">GraphicsMode to copy values from.</param>
		public AndroidGraphicsMode (EGLDisplay display, int version, GraphicsMode mode) :
			this (display, version, mode.ColorFormat, mode.Depth, mode.Stencil, mode.Samples, mode.Buffers, mode.Stereo)
		{
		}

		/// <summary>
		///	  Creates an AndroidGraphicsMode instance with the required settings.
		///	  Passing null to the display parameter for lazy initialization is recommended.
		/// </summary>
		/// <param name="display">
		///	  A <see cref="T:Javax.Microedition.Khronos.Egl.EGLDisplay" /> with the display to use for creating the
		///	  <see cref="T:Javax.Microedition.Khronos.Egl.EGLConfig" /> that represents this graphics configuration in
		///	 the OpenGL space. Pass null for lazy initialization.
		/// </param>
		/// <param name="version">Requested OpenGL version (1 or 2)</param>
		/// <param name="color">The ColorFormat of the color buffer.</param>
		/// <param name="depth">The number of bits in the depth buffer.</param>
		/// <param name="stencil">The number of bits in the stencil buffer.</param>
		/// <param name="samples">The number of samples for FSAA.</param>
		/// <param name="stereo">Set to true for a GraphicsMode with stereographic capabilities.</param>
		/// <param name="buffers">The number of render buffers. Typical values include one (single-), two (double-) or three (triple-buffering).</param>
		public AndroidGraphicsMode (EGLDisplay display, int version, ColorFormat color, int depth, int stencil, int samples, int buffers, bool stereo)
		{
			this.ColorFormat = color;
			this.Depth = depth;
			this.Stencil = stencil;
			this.Samples = samples;
			this.AccumulatorFormat = color;
			this.Buffers = buffers;
			this.Stereo = stereo;
			this.Version = version;
		}

		void ChooseConfig (EGLDisplay display)
		{
#if LOGGING
			Log.Verbose ("AndroidGraphicsMode", "Requested graphics mode on display {7} with red {0} green {1} blue {2} alpha {3} depth {4} stencil {5} buffers {6}",
					ColorFormat.Red, ColorFormat.Green, ColorFormat.Blue, ColorFormat.Alpha, Depth, Stencil, Buffers, display);
#endif

			var egl = EGLContext.EGL.JavaCast<IEGL10> ();

			try {
				if (display == null)
					display = egl.EglGetDisplay (EGL11.EglDefaultDisplay);
			} catch {
				throw EglException.GenerateException ("Failed to get default display", egl, null);
			}

			List<int> configSpec = new List<int> {
			};

			if (ColorFormat.Red > 0) {
				configSpec.Add (EGL11.EglRedSize);
				configSpec.Add (ColorFormat.Red);
			}

			if (ColorFormat.Green > 0) {
				configSpec.Add (EGL11.EglGreenSize);
				configSpec.Add (ColorFormat.Green);
			}

			if (ColorFormat.Blue > 0) {
				configSpec.Add (EGL11.EglBlueSize);
				configSpec.Add (ColorFormat.Blue);
			}

			if (ColorFormat.Alpha > 0) {
				configSpec.Add (EGL11.EglAlphaSize);
				configSpec.Add (ColorFormat.Alpha);
			}

			if (Depth > 0) {
				configSpec.Add (EGL11.EglDepthSize);
				configSpec.Add (Depth);
			}

			if (Stencil > 0) {
				configSpec.Add (EGL11.EglStencilSize);
				configSpec.Add (Stencil);
			}
			//http://code.google.com/p/gdc2011-android-opengl/source/browse/trunk/src/com/example/gdc11/MultisampleConfigChooser.java?r=5
			if (Samples > 0) {
				// Enable Multi Sampling if we can
				configSpec.Add (EGL11.EglSampleBuffers);
				configSpec.Add (1);
				configSpec.Add (EGL11.EglSamples);
				configSpec.Add (Samples);
			}

			if (Version > 1) {
				configSpec.Add (EGL11.EglRenderableType);
				configSpec.Add (4);
			}

			configSpec.Add (EGL11.EglNone);

			int[] num_configs = new int[1];
			if (!egl.EglGetConfigs (display, null, 0, num_configs) || num_configs[0] < 1) {
				throw EglException.GenerateException ("Failed to retrieve GraphicsMode configurations", egl, null);
			}

			EGLConfig[] configs = new EGLConfig[1];
			if (!egl.EglChooseConfig (display, configSpec.ToArray(), configs, configs.Length, num_configs)) {
				Log.Warn ("AndroidGraphicsMode", "Failed to choose GraphicsMode with red {0} green {1} blue {2} alpha {3} depth {4} stencil {5} buffers {6}: egl error {7}. Falling back go lowest configuration available.",
				ColorFormat.Red, ColorFormat.Green, ColorFormat.Blue, ColorFormat.Alpha, Depth, Stencil, Buffers, egl.EglGetError ());

				configSpec = new List<int> {
					EGL11.EglRedSize, 4,
					EGL11.EglGreenSize, 4,
					EGL11.EglBlueSize, 4,
					EGL11.EglNone
				};

				if (!egl.EglChooseConfig (display, configSpec.ToArray(), configs, configs.Length, num_configs)) {
					throw EglException.GenerateException ("Failed to find a valid GraphicsMode configuration", egl, null);
				}
			}

			EGLConfig active_config = configs[0];

#if LOGGING
			Log.Verbose ("AndroidGraphicsMode", "Checking selected config {0}", active_config);
#endif

			if (active_config == null)
				throw EglException.GenerateException ("Failed to find a valid GraphicsMode configuration", egl, null);

			var r = GetAttrib (egl, display, active_config, EGL11.EglRedSize);
			var g = GetAttrib (egl, display, active_config, EGL11.EglGreenSize);
			var b = GetAttrib (egl, display, active_config, EGL11.EglBlueSize);
			var a = GetAttrib (egl, display, active_config, EGL11.EglAlphaSize);
			var depth = GetAttrib (egl, display, active_config, EGL11.EglDepthSize);
			var stencil = GetAttrib (egl, display, active_config, EGL11.EglStencilSize);
			var s = GetAttrib (egl, display, active_config, EGL11.EglSampleBuffers);
			var samples = GetAttrib (egl, display, active_config, EGL11.EglSamples);
			var bufs = GetAttrib (egl, display, active_config, EGL11.EglRenderBuffer);

#if LOGGING
			Log.Verbose ("AndroidGraphicsMode", "Requested graphics mode with red {0} green {1} blue {2} alpha {3} depth {4} stencil {5} buffers {6} samples {7}",
					ColorFormat.Red, ColorFormat.Green, ColorFormat.Blue, ColorFormat.Alpha, Depth, Stencil, Buffers, Samples);
#endif

			this.Index = active_config.Handle;
			this.ColorFormat = new ColorFormat (r, g, b, a);
			this.Depth = depth;
			this.Stencil = stencil;
			this.Samples = s > 0 ? samples : 0;
			this.Config = active_config;
			this.Buffers = bufs;

#if LOGGING
			Log.Verbose ("AndroidGraphicsMode", "Selected  graphics mode with red {0} green {1} blue {2} alpha {3} depth {4} stencil {5} buffers {6}, samples {7}",
					ColorFormat.Red, ColorFormat.Green, ColorFormat.Blue, ColorFormat.Alpha, Depth, Stencil, Buffers, Samples);
#endif
		}

		public GraphicsMode SelectGraphicsMode (ColorFormat color, int depth, int stencil, int samples, ColorFormat accum, int buffers, bool stereo)
		{
			return new AndroidGraphicsMode (color, depth, stencil, samples, buffers, stereo);
		}

		public void Initialize (EGLDisplay display, int version)
		{
			Version = version;
			ChooseConfig (display);
		}

		int GetAttrib (IEGL10 egl, EGLDisplay display, EGLConfig config, int attrib)
		{
			int[] ret = new int [1];
			try {
				egl.EglGetConfigAttrib (display, config, attrib, ret);
			} catch (Exception e) {
				Log.Warn ("AndroidGraphicsMode", "EglGetConfigAttrib {0} threw exception {1}", attrib, e);
			}
			return ret[0];
		}
	}
}
