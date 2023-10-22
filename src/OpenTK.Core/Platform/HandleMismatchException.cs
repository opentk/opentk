using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Core.Platform.Interfaces;

namespace OpenTK.Core.Platform
{
    internal class HandleMismatchException<T> : PalException
    {
        public object MissmatchedHandle { get; private set; }

        public HandleMismatchException(IPalComponent component, object mismatchedHandle)
            : base(component, $"Expected handle of type {typeof(T)} but got handle of type {mismatchedHandle}")
        {
        }
    }
}
