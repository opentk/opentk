using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public interface IOverloader
    {
        bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex);
    }
}
