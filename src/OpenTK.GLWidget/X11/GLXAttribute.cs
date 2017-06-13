//
//  GLXAttribute.cs
//
//  The Open Toolkit Library License
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2006 - 2009 the Open Toolkit library, except where noted.
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights to
//  use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
//  the Software, and to permit persons to whom the Software is furnished to do
//  so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//  EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//  OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//  HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//  WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//  FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//  OTHER DEALINGS IN THE SOFTWARE.
//

namespace OpenTK.X11
{
	public enum GLXAttribute
	{
		None			= 0,
		UseGL			= 1,
		BufferSize		= 2,
		Level			= 3,
		RGBA			= 4,
		DoubleBuffer	= 5,
		Stereo			= 6,
		AuxBuffers		= 7,
		RedSize			= 8,
		GreenSize		= 9,
		BlueSize		= 10,
		AlphaSize		= 11,
		DepthSize		= 12,
		StencilSize		= 13,
		AccumRedSize	= 14,
		AccumGreenSize	= 15,
		AccumBlueSize	= 16,
		AccumAlphaSize	= 17
	}
}