namespace OpenTK.Platform.MacOS
{
    enum NSApplicationPresentationOptions
    {
        Default = 0,
        AutoHideDock = 1,
        HideDock = 2,
        AutoHideMenuBar = 4,
        HideMenuBar = 8,
        DisableAppleMenu = 16,
        DisableProcessSwitching = 32,
        DisableForceQuit = 64,
        DisableSessionTermination = 128,
        DisableHideApplication = 256,
        DisableMenuBarTransparency = 512,
        FullScreen = 1024,
        AutoHideToolbar = 2048,
    }
}
