using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    public interface IMouseDriver
    {
        IList<Mouse> Mouse { get; }
    }
}
