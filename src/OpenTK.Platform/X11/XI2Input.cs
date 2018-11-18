//
// XI2Input.cs
//
// Author:
//       thefiddler <stapostol@gmail.com>
//
// Copyright (c) 2006-2014
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

using System.Diagnostics;
using OpenToolkit.Input;
using OpenToolkit.Platform.Linux;

namespace OpenToolkit.Platform.X11
{
    internal class XI2Input : IInputDriver2
    {
        private readonly LinuxJoystick joystick = new LinuxJoystick();
        private readonly XI2MouseKeyboard mouse_keyboard = new XI2MouseKeyboard();

        internal XI2Input()
        {
            Debug.WriteLine("Using XI2 input driver.");
        }

        public IMouseDriver2 MouseDriver => mouse_keyboard;

        public IKeyboardDriver2 KeyboardDriver => mouse_keyboard;

        public IGamePadDriver GamePadDriver { get; } = new MappedGamePadDriver();

        public IJoystickDriver2 JoystickDriver => joystick;

        public void Dispose()
        {
            mouse_keyboard.Dispose();
            joystick.Dispose();
        }
    }
}