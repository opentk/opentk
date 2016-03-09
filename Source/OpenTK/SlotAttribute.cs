// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;

namespace OpenTK
{
	/// <summary>
	/// Defines the slot index for a wrapper function.
	/// This type supports OpenTK and should not be
	/// used in user code.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public class SlotAttribute : Attribute
	{
		/// <summary>
		/// Defines the slot index for a wrapper function.
		/// </summary>
		internal int Slot;

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		/// <param name="index">The slot index for a wrapper function.</param>
		public SlotAttribute(int index)
		{
			Slot = index;
		}
	}
}

