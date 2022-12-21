using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.X11
{
    public class XOpenGLContextHandle : OpenGLContextHandle
    {
        public XDisplayPtr Display { get; }
        public GLXContext Context { get; }

        public XDrawable Drawable { get; }

        public XOpenGLContextHandle? SharedContext { get; }

        public XOpenGLContextHandle(
            XDisplayPtr display,
            GLXContext context,
            XDrawable drawable,
            XOpenGLContextHandle? sharedContext = null)
        {
            Display = display;
            Context = context;
            Drawable = drawable;
            SharedContext = sharedContext;
        }
    }
}
