using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum GetMouseMovePointsResolution : DWORD
    {
        UseDisplayPoints = 1,
        UseHighResolutionPoints = 2
    }
}
