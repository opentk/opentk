//
// WindowIcon.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.Common.Input
{
    /// <summary>
    ///     Stores an array of <see cref="Image" />s, meant for use as window icons.
    /// </summary>
    public class WindowIcon
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="WindowIcon" /> class.
        /// </summary>
        /// <param name="images">An array of <see cref="Image" />s, which will be used as the window icons.</param>
        public WindowIcon(params Image[] images) => Images = images;

        /// <summary>
        ///     Initializes a new instance of the <see cref="WindowIcon" /> class.
        /// </summary>
        private WindowIcon()
        {
        }

        /// <summary>
        ///     Gets or sets the array of <see cref="Image" />s to use.
        /// </summary>
        public Image[] Images { get; set; }
    }
}
