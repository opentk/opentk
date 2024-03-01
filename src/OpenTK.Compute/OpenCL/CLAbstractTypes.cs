using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Compute.OpenCL
{
    public interface ICLMemoryObject
    {
       IntPtr Handle { get; }
    }
}
