#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.MacOS
{
	// 
	// http://web.archive.org/web/20100501161453/http://www.classicteck.com/rbarticles/mackeyboard.php

    enum MacOSKeyCode
    {
        A = 0,
        B = 11,
        C = 8,
        D = 2,
        E = 14,
        F = 3,
        G = 5,
        H = 4,
        I = 34,
        J = 38,
        K = 40,
        L = 37,
        M = 46,
        N = 45,
        O = 31,
        P = 35,
        Q = 12,
        R = 15,
        S = 1,
        T = 17,
        U = 32,
        V = 9,
        W = 13,
        X = 7,
        Y = 16,
        Z = 6,

        Key_1 = 18,
        Key_2 = 19,
        Key_3 = 20,
        Key_4 = 21,
        Key_5 = 23,
        Key_6 = 22,
        Key_7 = 26,
        Key_8 = 28,
        Key_9 = 25,
        Key_0 = 29,

        Space = 49,
        Tilde = 50,

        Minus = 27,
        Equals = 24,
        BracketLeft = 33, 
        BracketRight = 30, 
        Backslash = 42,
        Semicolon = 41, 
        Quote = 39, 
        Comma = 43,
        Period = 47,
        Slash = 44,

        Enter = 36,
        Tab = 48,
        Backspace = 51,
        Return = 52,
        Esc = 53,
        
        Command = 55,
        Shift = 56,
        CapsLock = 57,
        OptionAlt = 58,
        Control = 59,
        
        KeyPad_Decimal = 65,
        KeyPad_Multiply = 67,
        KeyPad_Add = 69,
        KeyPad_Divide = 75,
        KeyPad_Enter = 76,
        KeyPad_Subtract = 78,
        KeyPad_Equal = 81,
        KeyPad_0 = 82,
        KeyPad_1 = 83,
        KeyPad_2 = 84,
        KeyPad_3 = 85,
        KeyPad_4 = 86,
        KeyPad_5 = 87,
        KeyPad_6 = 88,
        KeyPad_7 = 89,
        KeyPad_8 = 91,
        KeyPad_9 = 92,
        
        F1 = 122,
        F2 = 120,
        F3 = 99,
        F4 = 118,
        F5 = 96,
        F6 = 97,
        F7 = 98,
        F8 = 100,
        F9 = 101,
        F10 = 109,
        F11 = 103,
        F12 = 111,
        F13 = 105,
        F14 = 107,
        F15 = 113,

        Menu = 110,

        Insert = 114,
        Home = 115,
        Pageup = 116,
        Del = 117,
        End = 119,
        Pagedown = 121,
        Up = 126,
        Down = 125,
        Left = 123,
        Right = 124,


    }
    [Flags]
    enum MacOSKeyModifiers
    {
        None     = 0,
        Shift    = 0x0200,
        CapsLock = 0x0400,
        Control  = 0x1000,  // 
        Command  = 0x0100,  // Open-Apple  - Windows key 
        Option   = 0x0800,  // Option key is same position as the alt key on non-mac keyboards.
    }
}
