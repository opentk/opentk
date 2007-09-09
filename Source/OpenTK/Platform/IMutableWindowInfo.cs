using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    /// <summary>
    /// Provides methods to 
    /// </summary>
    public interface IMutableWindowInfo : IWindowInfo
    {
        IWindowInfo GetInfoFrom(System.Windows.Forms.Control control);
        IWindowInfo GetInfoFrom(System.Windows.Forms.NativeWindow window);
        IWindowInfo GetInfoFrom(OpenTK.GameWindow window);
        IWindowInfo GetInfoFrom(IWindowInfo info);
        void CopyInfoFrom(IWindowInfo info);
    }
}
