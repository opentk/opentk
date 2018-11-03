namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies the resolution desired by <see cref="User32.Mouse.GetMouseMovePointsEx(uint, ref MouseMovePoint,
    /// MouseMovePoint*, int, GetMouseMovePointsResolution)"/>.
    /// </summary>
    public enum GetMouseMovePointsResolution : uint
    {
        /// <summary>
        /// Retrieves the points using the display resolution.
        /// </summary>
        UseDisplayPoints = 1,

        /// <summary>
        /// Retrieves high resolution points. Points can range from zero to 65,535 (0xFFFF) in both x- and
        /// y-coordinates. This is the resolution provided by absolute coordinate pointing devices
        /// such as drawing tablets.
        /// </summary>
        UseHighResolutionPoints = 2
    }
}
