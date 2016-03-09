// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;

namespace OpenTK
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	class RewrittenAttribute : Attribute
	{
		internal bool Rewritten;

		public RewrittenAttribute(bool rewritten)
		{
			Rewritten = rewritten;
		}
	}
}

