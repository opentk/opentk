using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Data
{
    public class Command
    {
        public Method Method { get; }

        public Command(Method method)
        {
            Method = method;
        }
    }
}
