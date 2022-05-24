namespace OpenTK.Core.Platform
{
    public readonly struct DisplayResolution
    {
        public readonly int ResolutionX;
        public readonly int ResolutionY;

        public DisplayResolution(int resolutionX, int resolutionY)
        {
            ResolutionX = resolutionX;
            ResolutionY = resolutionY;
        }
    }
}
