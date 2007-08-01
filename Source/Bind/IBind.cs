using System;
using System.Collections.Generic;
using System.Text;

namespace Bind
{
    interface IBind : ISpecReader, ISpecWriter
    {
        //ISpecReader SpecReader { get; }
        void Process();
    }
}
