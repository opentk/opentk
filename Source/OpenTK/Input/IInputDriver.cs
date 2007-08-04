using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    public interface IInputDriver : IKeyboardDriver, IMouseDriver
    {
        IList<IInputDevice> InputDevices { get; }
        //void ProcessEvents
        //IEnumerable<IMouse> Mice { get; }
        //IEnumerable<IHid> Hids { get; }
    }
}