#region License
//
// JoystickButton.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//       Button limit increased to 128 by Christopher Lees (Fixes Saitek x55 having too many buttons....)
//
// Copyright (c) 2006-2013 Stefanos Apostolopoulos
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

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Defines available JoystickDevice buttons.
    /// </summary>
    public enum JoystickButton
    {
        /// <summary>The first button of the JoystickDevice.</summary>
        Button0 = 0,
        /// <summary>The second button of the JoystickDevice.</summary>
        Button1,
        /// <summary>The third button of the JoystickDevice.</summary>
        Button2,
        /// <summary>The fourth button of the JoystickDevice.</summary>
        Button3,
        /// <summary>The fifth button of the JoystickDevice.</summary>
        Button4,
        /// <summary>The sixth button of the JoystickDevice.</summary>
        Button5,
        /// <summary>The seventh button of the JoystickDevice.</summary>
        Button6,
        /// <summary>The eighth button of the JoystickDevice.</summary>
        Button7,
        /// <summary>The ninth button of the JoystickDevice.</summary>
        Button8,
        /// <summary>The tenth button of the JoystickDevice.</summary>
        Button9,
        /// <summary>The eleventh button of the JoystickDevice.</summary>
        Button10,
        /// <summary>The twelfth button of the JoystickDevice.</summary>
        Button11,
        /// <summary>The thirteenth button of the JoystickDevice.</summary>
        Button12,
        /// <summary>The fourteenth button of the JoystickDevice.</summary>
        Button13,
        /// <summary>The fifteenth button of the JoystickDevice.</summary>
        Button14,
        /// <summary>The sixteenth button of the JoystickDevice.</summary>
        Button15,
        /// <summary>The seventeenth button of the JoystickDevice.</summary>
        Button16,
        /// <summary>The eighteenth button of the JoystickDevice.</summary>
        Button17,
        /// <summary>The nineteenth button of the JoystickDevice.</summary>
        Button18,
        /// <summary>The twentieth button of the JoystickDevice.</summary>
        Button19,
        /// <summary>The twentyfirst button of the JoystickDevice.</summary>
        Button20,
        /// <summary>The twentysecond button of the JoystickDevice.</summary>
        Button21,
        /// <summary>The twentythird button of the JoystickDevice.</summary>
        Button22,
        /// <summary>The twentyfourth button of the JoystickDevice.</summary>
        Button23,
        /// <summary>The twentyfifth button of the JoystickDevice.</summary>
        Button24,
        /// <summary>The twentysixth button of the JoystickDevice.</summary>
        Button25,
        /// <summary>The twentyseventh button of the JoystickDevice.</summary>
        Button26,
        /// <summary>The twentyeighth button of the JoystickDevice.</summary>
        Button27,
        /// <summary>The twentynineth button of the JoystickDevice.</summary>
        Button28,
        /// <summary>The thirtieth button of the JoystickDevice.</summary>
        Button29,
        /// <summary>The thirtyfirst button of the JoystickDevice.</summary>
        Button30,
        /// <summary>The thirtysecond button of the JoystickDevice.</summary>
        Button31,
        /// <summary>The thirtythird button of the JoystickDevice.</summary>
        Button32,
        /// <summary>The thirtyfourth button of the JoystickDevice.</summary>
        Button33,
        /// <summary>The thirtyfifth button of the JoystickDevice.</summary>
        Button34,
        /// <summary>The thirtysixth button of the JoystickDevice.</summary>
        Button35,
        /// <summary>The thirtyseventh button of the JoystickDevice.</summary>
        Button36,
        /// <summary>The thirtyeighth button of the JoystickDevice.</summary>
        Button37,
        /// <summary>The thirtyninth button of the JoystickDevice.</summary>
        Button38,
        /// <summary>The fourtieth button of the JoystickDevice.</summary>
        Button39,
        /// <summary>The fourtyfirst button of the JoystickDevice.</summary>
        Button40,
        /// <summary>The fourtysecond button of the JoystickDevice.</summary>
        Button41,
        /// <summary>The fourtythird button of the JoystickDevice.</summary>
        Button42,
        /// <summary>The fourtyfourth button of the JoystickDevice.</summary>
        Button43,
        /// <summary>The fourtyfifth button of the JoystickDevice.</summary>
        Button44,
        /// <summary>The fourtysixth button of the JoystickDevice.</summary>
        Button45,
        /// <summary>The fourtyseventh button of the JoystickDevice.</summary>
        Button46,
        /// <summary>The fourtyeigth button of the JoystickDevice.</summary>
        Button47,
        /// <summary>The fourtyninth button of the JoystickDevice.</summary>
        Button48,
        /// <summary>The fiftyth button of the JoystickDevice.</summary>
        Button49,
        /// <summary>The fiftyfirst button of the JoystickDevice.</summary>
        Button50,
        /// <summary>The fiftysecond button of the JoystickDevice.</summary>
        Button51,
        /// <summary>The fiftythird button of the JoystickDevice.</summary>
        Button52,
        /// <summary>The fiftyfourth button of the JoystickDevice.</summary>
        Button53,
        /// <summary>The fiftyfifth button of the JoystickDevice.</summary>
        Button54,
        /// <summary>The fiftysixth button of the JoystickDevice.</summary>
        Button55,
        /// <summary>The fiftyseventh button of the JoystickDevice.</summary>
        Button56,
        /// <summary>The fiftyeighth button of the JoystickDevice.</summary>
        Button57,
        /// <summary>The fiftyninth button of the JoystickDevice.</summary>
        Button58,
        /// <summary>The sixtyth button of the JoystickDevice.</summary>
        Button59,
        /// <summary>The sixtyfirst button of the JoystickDevice.</summary>
        Button60,
        /// <summary>The sixtysecond button of the JoystickDevice.</summary>
        Button61,
        /// <summary>The sixtythird button of the JoystickDevice.</summary>
        Button62,
        /// <summary>The sixtyfourth button of the JoystickDevice.</summary>
        Button63,
        /// <summary>The sixtyfifth button of the JoystickDevice.</summary>
        Button64,
        /// <summary>The sixtysixth button of the JoystickDevice.</summary>
        Button65,
        /// <summary>The sixtyseventh button of the JoystickDevice.</summary>
        Button66,
        /// <summary>The sixtyeighth button of the JoystickDevice.</summary>
        Button67,
        /// <summary>The sixtyninth button of the JoystickDevice.</summary>
        Button68,
        /// <summary>The seventyth button of the JoystickDevice.</summary>
        Button69,
        /// <summary>The seventyfirst button of the JoystickDevice.</summary>
        Button70,
        /// <summary>The seventysecond button of the JoystickDevice.</summary>
        Button71,
        /// <summary>The seventythird button of the JoystickDevice.</summary>
        Button72,
        /// <summary>The seventyfourth button of the JoystickDevice.</summary>
        Button73,
        /// <summary>The seventyfifth button of the JoystickDevice.</summary>
        Button74,
        /// <summary>The seventysixth button of the JoystickDevice.</summary>
        Button75,
        /// <summary>The seventyseventh button of the JoystickDevice.</summary>
        Button76,
        /// <summary>The seventyeighth button of the JoystickDevice.</summary>
        Button77,
        /// <summary>The seventyninth button of the JoystickDevice.</summary>
        Button78,
        /// <summary>The eightyth button of the JoystickDevice.</summary>
        Button79,
        /// <summary>The eightyfirst button of the JoystickDevice.</summary>
        Button80,
        /// <summary>The eightysecond button of the JoystickDevice.</summary>
        Button81,
        /// <summary>The eightythird button of the JoystickDevice.</summary>
        Button82,
        /// <summary>The eightyfourth button of the JoystickDevice.</summary>
        Button83,
        /// <summary>The eightyfifth button of the JoystickDevice.</summary>
        Button84,
        /// <summary>The eightysixth button of the JoystickDevice.</summary>
        Button85,
        /// <summary>The eightyseventh button of the JoystickDevice.</summary>
        Button86,
        /// <summary>The eightyeighth button of the JoystickDevice.</summary>
        Button87,
        /// <summary>The eightyninth button of the JoystickDevice.</summary>
        Button88,
        /// <summary>The ninetyth button of the JoystickDevice.</summary>
        Button89,
        /// <summary>The ninetyfirst button of the JoystickDevice.</summary>
        Button90,
        /// <summary>The ninetysecond button of the JoystickDevice.</summary>
        Button91,
        /// <summary>The ninetythird button of the JoystickDevice.</summary>
        Button92,
        /// <summary>The ninetyfourth button of the JoystickDevice.</summary>
        Button93,
        /// <summary>The ninetyfifth button of the JoystickDevice.</summary>
        Button94,
        /// <summary>The ninetysixth button of the JoystickDevice.</summary>
        Button95,
        /// <summary>The ninetyseventh button of the JoystickDevice.</summary>
        Button96,
        /// <summary>The ninetyeighth button of the JoystickDevice.</summary>
        Button97,
        /// <summary>The ninetyninth button of the JoystickDevice.</summary>
        Button98,
        /// <summary>The hundredth button of the JoystickDevice.</summary>
        Button99,
        /// <summary>The hundredfirst button of the JoystickDevice.</summary>
        Button100,
        /// <summary>The hundredsecond button of the JoystickDevice.</summary>
        Button101,
        /// <summary>The hundredthird button of the JoystickDevice.</summary>
        Button102,
        /// <summary>The hundredfourth button of the JoystickDevice.</summary>
        Button103,
        /// <summary>The hundredfifth button of the JoystickDevice.</summary>
        Button104,
        /// <summary>The hundredsixth button of the JoystickDevice.</summary>
        Button105,
        /// <summary>The hundredseventh button of the JoystickDevice.</summary>
        Button106,
        /// <summary>The hundredeighth button of the JoystickDevice.</summary>
        Button107,
        /// <summary>The hundredninth button of the JoystickDevice.</summary>
        Button108,
        /// <summary>The hundredtenth button of the JoystickDevice.</summary>
        Button109,
        /// <summary>The hundredeleventh button of the JoystickDevice.</summary>
        Button110,
        /// <summary>The hundredtwelfth button of the JoystickDevice.</summary>
        Button111,
        /// <summary>The hundredthirteenth button of the JoystickDevice.</summary>
        Button112,
        /// <summary>The hundredfourteenth button of the JoystickDevice.</summary>
        Button113,
        /// <summary>The hundredfifteenth button of the JoystickDevice.</summary>
        Button114,
        /// <summary>The hundredsixteenth button of the JoystickDevice.</summary>
        Button115,
        /// <summary>The hundredseventeenth button of the JoystickDevice.</summary>
        Button116,
        /// <summary>The hundredeighteenth button of the JoystickDevice.</summary>
        Button117,
        /// <summary>The hundrednineteenth button of the JoystickDevice.</summary>
        Button118,
        /// <summary>The hundredtwentieth button of the JoystickDevice.</summary>
        Button119,
        /// <summary>The hundredtwentyfirst button of the JoystickDevice.</summary>
        Button120,
        /// <summary>The hundredtwentysecond button of the JoystickDevice.</summary>
        Button121,
        /// <summary>The hundredtwentythird button of the JoystickDevice.</summary>
        Button122,
        /// <summary>The hundredtwentyfourth button of the JoystickDevice.</summary>
        Button123,
        /// <summary>The hundredtwentyfifth button of the JoystickDevice.</summary>
        Button124,
        /// <summary>The hundredtwentysixth button of the JoystickDevice.</summary>
        Button125,
        /// <summary>The hundredtwentyseventh button of the JoystickDevice.</summary>
        Button126,
        /// <summary>The hundredtwentyeighth button of the JoystickDevice.</summary>
        Button127,
        /// <summary>The last button of the JoystickDevice.</summary>
        Last = Button127,
    }
}