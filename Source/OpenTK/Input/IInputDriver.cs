using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    public interface IInputDriver
    {
        IList<IInputDevice> InputDevices { get; }
        IList<IKeyboard> Keyboards { get; }
        //IEnumerable<IMouse> Mice { get; }
        //IEnumerable<IHid> Hids { get; }
    }
}