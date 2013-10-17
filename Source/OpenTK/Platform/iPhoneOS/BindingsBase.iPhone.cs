/*
 * BindingsBase: A mostly empty base class for the GraphicsBindingsBase class
 *
 * Author:
 *   Rolf Bjarne Kvinge <rolf@xamarin.com>
 *
 * (c) Copyright 2012 Xamarin Inc
 */

using System;

namespace OpenTK
{
	public abstract class BindingsBase
	{
		protected abstract object SyncRoot { get; }
	}
}

