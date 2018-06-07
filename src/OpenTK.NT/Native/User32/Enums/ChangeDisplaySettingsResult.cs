namespace OpenTK.NT.Native
{
    public enum ChangeDisplaySettingsResult
    {
        Successful = 0,
        Restart = 1,
        Failed = -1,
        BadMode = -2,
        NotUpdated = -3,
        BadFlags = -4,
        BadParam = -5,
        BadDualView = -6, // Win XP and higher
    }
}
