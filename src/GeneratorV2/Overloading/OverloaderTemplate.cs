#pragma warning disable CS0162 // Unreachable code detected
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class OverloaderTemplate : IOverloader
    {
        private class Layer : ILayer
        {
            private readonly ILayer _nestedLayer;
            private readonly int _argIndex;

            public Layer(ILayer layer, int argIndex)
            {
                _nestedLayer = layer;
                _argIndex = argIndex;
            }

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                //Write here

                //Modify args here

                return _nestedLayer.WriteLayer(writer, methodName, args);
            }
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex)
        {
            if (true) //Check if we want to overload
            {
                return false;
            }

            topLayer = new Layer(topLayer, paramIndex);
            return true;
        }
    }
}

#pragma warning restore CS0162 // Unreachable code detected
