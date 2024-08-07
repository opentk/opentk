namespace OpenTK.Platform
{
    // FIXME: Maybe start the enum values at 0?

    /// <summary>
    /// Represents system mouse cursor icons.
    /// </summary>
    public enum SystemCursorType
    {
        /// <summary>
        /// Default mouse cursor.
        /// </summary>
        Default = 1,

        /// <summary>
        /// A mouse cursor to tell the user something is loading (like an arrow with an hour glass.)
        /// </summary>
        Loading = 2,

        /// <summary>
        /// A mouse cursor to tell the user to wait. (like an hour glass).
        /// </summary>
        Wait = 3,

        /// <summary>
        /// A cursor with a cross.
        /// </summary>
        Cross = 4,

        /// <summary>
        /// A cursor with a hand.
        /// </summary>
        Hand = 5,

        /// <summary>
        /// A cursor with a quetion mark.
        /// </summary>
        Help = 6,

        /// <summary>
        /// A cursor which is displayed when text is selectable.
        /// </summary>
        TextBeam = 7,

        /// <summary>
        /// A cursor which tells the user they can't do something (like a crossed out red circle.)
        /// </summary>
        Forbidden = 8,

        /// <summary>
        /// A cursor with arrows pointing in all four direction.
        /// </summary>
        ArrowFourway = 9,

        /// <summary>
        /// A resize cursor with arrows pointing north and south.
        /// </summary>
        ArrowNS = 10,

        /// <summary>
        /// A resize cursor with arrows pointing east and west.
        /// </summary>
        ArrowEW = 11,

        /// <summary>
        /// A resize cursor with arrows pointing northeast and southwest.
        /// </summary>
        ArrowNESW = 12,

        /// <summary>
        /// A resize cursor with arrows pointing northwest and southeast.
        /// </summary>
        ArrowNWSE = 13,

        /// <summary>
        /// A cursor pointing up.
        /// </summary>
        ArrowUp = 14,

        /// <summary>
        /// A resize cursor pointing north.<br/>
        /// On windows this is the same as <see cref="ArrowNS"/>.<br/>
        /// On macos and X11 this will be an arrow pointing north.
        /// </summary>
        ArrowN = 15,

        /// <summary>
        /// A resize cursor pointing east.<br/>
        /// On windows this is the same as <see cref="ArrowEW"/>.<br/>
        /// On macos and X11 this will be an arrow pointing east.
        /// </summary>
        ArrowE = 16,

        /// <summary>
        /// A resize cursor pointing south.<br/>
        /// On windows this is the same as <see cref="ArrowNS"/>.<br/>
        /// On macos and X11 this will be an arrow pointing south.
        /// </summary>
        ArrowS = 17,

        /// <summary>
        /// A resize cursor pointing west.<br/>
        /// On windows this is the same as <see cref="ArrowEW"/>.<br/>
        /// On macos and X11 this will be an arrow pointing west.
        /// </summary>
        ArrowW = 18,

        /// <summary>
        /// A resize cursor pointing northeast.<br/>
        /// On windows this is the same as <see cref="ArrowNESW"/>.<br/>
        /// On macos and X11 this will be an arrow pointing northeast.
        /// </summary>
        ArrowNE = 19,

        /// <summary>
        /// A resize cursor pointing southeast.<br/>
        /// On windows this is the same as <see cref="ArrowNWSE"/>.<br/>
        /// On macos and X11 this will be an arrow pointing southeast.
        /// </summary>
        ArrowSE = 20,

        /// <summary>
        /// A resize cursor pointing southwest.<br/>
        /// On windows this is the same as <see cref="ArrowNESW"/>.<br/>
        /// On macos and X11 this will be an arrow pointing southwest.
        /// </summary>
        ArrowSW = 21,

        /// <summary>
        /// A resize cursor pointing northwest.<br/>
        /// On windows this is the same as <see cref="ArrowNWSE"/>.<br/>
        /// On macos and X11 this will be an arrow pointing northwest.
        /// </summary>
        ArrowNW = 22,
    }
}
