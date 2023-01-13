using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    public enum HitType
    {
        /// <summary>
        /// Do what would be done if no hit test delegate was set.
        /// </summary>
        Default,
        // FIXME:
        // Add PassThrough to allow events to pass through to other OpenTK windows?
        Normal,
        Draggable,
        ResizeTopLeft,
        ResizeTop,
        ResizeTopRight,
        ResizeRight,
        ResizeBottomRight,
        ResizeBottom,
        ResizeBottomLeft,
        ResizeLeft,
    }
}
