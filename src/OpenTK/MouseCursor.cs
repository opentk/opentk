#region License
//
// Cursor.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
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
using System.Collections;
using System.Collections.Generic;

namespace OpenTK
{
    /// <summary>
    /// Represents a predefined or custom mouse cursor.
    /// </summary>
    public sealed class MouseCursor : IEnumerable<MouseCursorFrame>
    {
        static readonly MouseCursor default_cursor = new MouseCursor();
        static readonly MouseCursor empty_cursor = new MouseCursor(0, 0, 16, 16, new byte[16 * 16 * 4]);

        static MouseCursor()
        {
            default_cursor.AddFrame(MouseCursorFrame.Default);
        }

        private List<MouseCursorFrame> _frames = new List<MouseCursorFrame>();


        public MouseCursor()
        {
        }

        public MouseCursor(int hotx, int hoty, int width, int height, byte[] data)
        {
            var frame = new MouseCursorFrame(hotx, hoty, width, height, data);
            _frames.Add(frame);
        }

        public void AddFrame(MouseCursorFrame frame)
        {
            _frames.Add(frame);
        }


        public IEnumerator<MouseCursorFrame> GetEnumerator()
        {
            return _frames.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _frames.GetEnumerator();
        }

        public static MouseCursor Empty
        {
            get
            {
                return empty_cursor;
            }
        }

        public static MouseCursor Default
        {
            get
            {
                return default_cursor;
            }
        }

        public MouseCursorFrame DefaultFrame
        {
            get
            {
                if (_frames.Count > 0)
                    return _frames[0];
                return Default.DefaultFrame;
            }
        }
    }

}
