using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    class EglGraphicsMode : IGraphicsMode
    {
        #region IGraphicsMode Members

        public GraphicsMode SelectGraphicsMode(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum, int buffers, bool stereo)
        {
            EGLConfig[] configs = new EGLConfig[1];
            int[] attribList = new int[]             {                 Egl.SURFACE_TYPE, Egl.WINDOW_BIT,                Egl.RED_SIZE, color.Red,                 Egl.GREEN_SIZE, color.Green,                 Egl.BLUE_SIZE, color.Blue,                Egl.ALPHA_SIZE, color.Alpha,                Egl.DEPTH_SIZE, depth > 0 ? depth : Egl.DONT_CARE,                Egl.STENCIL_SIZE, stencil > 0 ? stencil : Egl.DONT_CARE,                Egl.SAMPLE_BUFFERS, samples > 0 ? 1 : 0,                Egl.SAMPLES, samples > 0 ? samples : 0,                Egl.NONE, Egl.NONE             };

            // Todo: what if we don't wish to use the default display?
            EGLDisplay display = Egl.GetDisplay(EGLNativeDisplayType.Default);

            int num_configs;
            Egl.GetConfigs(display, configs, configs.Length, out num_configs);
            if (num_configs == 0)
                throw new NotSupportedException("The requested GraphicsMode is not supported.");

            // See what we really got
            EGLConfig active_config = configs[0];
            int r, g, b, a;
            Egl.GetConfigAttrib(display, active_config, Egl.RED_SIZE, out r);
            Egl.GetConfigAttrib(display, active_config, Egl.GREEN_SIZE, out g);
            Egl.GetConfigAttrib(display, active_config, Egl.BLUE_SIZE, out b);
            Egl.GetConfigAttrib(display, active_config, Egl.ALPHA_SIZE, out a);
            int d, s;
            Egl.GetConfigAttrib(display, active_config, Egl.DEPTH_SIZE, out d);
            Egl.GetConfigAttrib(display, active_config, Egl.STENCIL_SIZE, out s);
            Egl.GetConfigAttrib(display, active_config, Egl.BLUE_SIZE, out b);
            Egl.GetConfigAttrib(display, active_config, Egl.ALPHA_SIZE, out a);
            int sample_buffers;
            Egl.GetConfigAttrib(display, active_config, Egl.SAMPLES, out sample_buffers);
            Egl.GetConfigAttrib(display, active_config, Egl.SAMPLES, out samples);

            return new GraphicsMode(active_config.Handle.Value, new ColorFormat(r, g, b, a), depth, stencil, sample_buffers > 0 ? samples : 0, 0, 2, false);
        }

        #endregion
    }
}
