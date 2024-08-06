using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    // FIXME: Maybe extend this list to encompass more icons
    // See: https://learn.microsoft.com/en-us/windows/win32/api/shellapi/ne-shellapi-shstockiconid
    // Most of these icons aren't imediately useful as you
    // cannot display them yourself if your application,
    // but maybe we can figure out how to get the icon data back.
    // Especially now that we have CanLoadSystemIcon feature switch.
    // - Noggin_bops 2023-09-10

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
        /// Error icon.
        /// </summary>
        Error = 2,

        /// <summary>
        /// An icon with an encircled letter I.
        /// </summary>
        Information = 3,

        /// <summary>
        /// An icon with a question mark.
        /// </summary>
        Question = 4,

        /// <summary>
        /// An icon related to security and super user priveleges.
        /// </summary>
        Shield = 5,

        /// <summary>
        /// An icon which represents a warning.
        /// </summary>
        Warning = 6,

        /// <summary>
        /// An icon displaying the operating system logo.
        /// </summary>
        // FIXME: This doesn't actually work on the windows backend...
        OperatingSystem = 7
    }
}
