//
// KeyboardCharModEventArgs.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Windowing.Common.Input;

namespace OpenToolkit.Windowing.EventingModels
{
    public class KeyboardCharModEventArgs : EventArgs
    {
        public KeyboardCharModEventArgs()
        {
            
        }
        
        public KeyboardCharModEventArgs(uint codepoint, KeyModifiers mods)
        {
            this.codepoint = codepoint;
            this.mods = mods;
        }

        public KeyboardCharModEventArgs(KeyboardCharModEventArgs other)
        {
            this.codepoint = other.codepoint;
            this.mods = other.mods;
        }
        
        public uint codepoint;
        public KeyModifiers mods;
    }
}