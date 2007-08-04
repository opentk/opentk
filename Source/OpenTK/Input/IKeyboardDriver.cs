using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    public interface IKeyboardDriver
    {
        IList<Keyboard> Keyboards { get; }
    }
}
