#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
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

namespace OpenTK.Input
{
    public abstract class JoystickDevice : IInputDevice
    {
        #region Fields

        int id;
        string description;
        List<float> axis = new List<float>();
        List<bool> button = new List<bool>();
        IList<float> axis_readonly;
        IList<bool> button_readonly;

        #endregion

        #region Constructors

        internal JoystickDevice(int id, int axes, int buttons)
        {
            if (axes <= 0)
                throw new ArgumentOutOfRangeException("axes");

            if (buttons <= 0)
                throw new ArgumentOutOfRangeException("buttons");

            Id = id;
            axis.AddRange(new float[axes]);
            button.AddRange(new bool[buttons]);

            axis_readonly = axis.AsReadOnly();
            button_readonly = button.AsReadOnly();
        }

        #endregion

        #region Public Members

        public IList<float> Axis { get { return axis_readonly; } }

        public IList<bool> Button { get { return button_readonly; } }

        #endregion

        #region IInputDevice Members
                
        public string Description
        {
            get { return description; }
            internal set { description = value; }
        }

        public InputDeviceType DeviceType
        {
            get { return InputDeviceType.Hid; }
        }

        #endregion

        #region Internal Members

        internal int Id
        {
            get { return id; }
            set { id = value; }
        }

        internal void SetAxis(int num, float @value)
        {
            axis[num] = @value;
        }

        internal void SetButton(int num, bool @value)
        {
            button[num] = @value;
        }

        #endregion
    }

    // Provides platform-specific information about the relevant JoystickDevice.
    internal sealed class JoystickDevice<TDetail> : JoystickDevice
    {
        TDetail details;

        internal JoystickDevice(int id, int axes, int buttons)
            : base(id, axes, buttons)
        { }

        internal TDetail Details { get { return details; } set { details = value; } }
    }
}
