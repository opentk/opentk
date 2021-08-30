using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Enumeration of system icons based on the Win32 base icon set.
    /// </summary>
    public enum SystemIconType
    {
        /// <summary>
        /// Default icon for applications.
        /// </summary>
        Default = 1,

        /// <summary>
        /// An icon with an asterisk.
        /// </summary>
        Asterisk = 2,

        /// <summary>
        /// Error icon.
        /// </summary>
        Error = 3,

        /// <summary>
        /// Icon with an exclamation mark.
        /// </summary>
        Exclamation = 4,

        /// <summary>
        /// An icon with a hand.
        /// </summary>
        Hand = 5,

        /// <summary>
        /// An icon with an encircled letter I.
        /// </summary>
        Information = 6,

        /// <summary>
        /// An icon with a question mark.
        /// </summary>
        Question = 7,

        /// <summary>
        /// An icon related to security and super user priveleges.
        /// </summary>
        Shield = 8,

        /// <summary>
        /// An icon which represents a warning.
        /// </summary>
        Warning = 9,

        /// <summary>
        /// An icon displaying the operating system logo.
        /// </summary>
        OperatingSystem = 10
    }
}
