using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Exception type when an optional feature is invoked in an abstraction
    /// layer driver which does not implement it.
    /// </summary>
    [Serializable]
    public class PalNotImplementedException : PalException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PalNotImplementedException"/> class.
        /// </summary>
        /// <param name="component">The component which throws the exception.</param>
        public PalNotImplementedException(IPalComponent component)
            : base(component, "Driver does not implement optional feature.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PalNotImplementedException"/> class.
        /// </summary>
        /// <param name="component">The component which throws the exception.</param>
        /// <param name="name">Name of the feature the driver doesn't implement.</param>
        public PalNotImplementedException(IPalComponent component, string name)
            : base(component, $"Driver does not implement optional feature \"{name}\".")
        {
        }
    }
}
