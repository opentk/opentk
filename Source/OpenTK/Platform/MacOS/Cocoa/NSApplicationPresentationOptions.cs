#region License
//
// NSApplicationPresentationOptions.cs
//
// Author:
//       Olle Håkansson <ollhak@gmail.com>
//
// Copyright (c) 2014 Olle Håkansson
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

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
