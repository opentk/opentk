namespace OpenTK.Core.Platform
{
    // FIXME: Better documentation string.
    // FIXME: Maybe start the enum values at 0?

    /// <summary>
    /// Enumeration of system cursor types based on the Win32 and MacOS mouse cursor set.
    /// </summary>
    public enum SystemCursorType
    {
        /// <summary>
        /// Default mouse cursor.
        /// </summary>
        Default = 1,

        /// <summary>
        /// A mouse cursor to tell the user something is loading (like an arrow with an hour glass)
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
        /// A cursor which tells the user they can't do something (like a crossed out red circle)
        /// </summary>
        Forbidden = 8,

        /// <summary>
        /// A cursor with arrows pointing in all four direction.
        /// </summary>
        ArrowFourway = 9,

        /// <summary>
        /// A cursor with arrows pointing North and South.
        /// </summary>
        ArrowNS = 10,

        /// <summary>
        /// A cursor with arrows pointing East and West.
        /// </summary>
        ArrowEW = 11,

        /// <summary>
        /// A cursor with arrows pointing North-East and South-West.
        /// </summary>
        ArrowNESW = 12,

        /// <summary>
        /// A cursor with arrows pointing North-West and South-East.
        /// </summary>
        ArrowNWSE = 13,

        /// <summary>
        /// A cursor pointing up.
        /// </summary>
        ArrowUp = 14,

        /// <summary>
        /// A cursor with an arrow pointing north. (intend to resize)
        /// </summary>
        ArrowN = 15,

        /// <summary>
        /// A cursor with an arrow pointing east. (intend to resize)
        /// </summary>
        ArrowE = 16,

        /// <summary>
        /// A cursor with an arrow pointing south. (intend to resize)
        /// </summary>
        ArrowS = 17,

        /// <summary>
        /// A cursor with an arrow pointing west. (intend to resize)
        /// </summary>
        ArrowW = 18,

        /// <summary>
        /// A cursor with an arrow pointing north east. (intend to resize)
        /// </summary>
        ArrowNE = 19,

        /// <summary>
        /// A cursor with an arrow pointing south east. (intend to resize)
        /// </summary>
        ArrowSE = 20,

        /// <summary>
        /// A cursor with an arrow pointing south west. (intend to resize)
        /// </summary>
        ArrowSW = 21,

        /// <summary>
        /// A cursor with an arrow pointing north west. (intend to resize)
        /// </summary>
        ArrowNW = 22,
    }
}
