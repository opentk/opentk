using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    public interface IKeyboard
    {
        bool this[Keys k] { get; set; }
        //void Poll();
    }
}
