//
// IconifyEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.EventingModels
{
    public class IconifyEventArgs
    {
        public IconifyEventArgs()
        {
            
        }

        public IconifyEventArgs(IconifyEventArgs other)
        {
            this.isIconified = other.isIconified;
        }

        internal IconifyEventArgs(bool isIconified)
        {
            this.isIconified = isIconified;
        }
        
        public bool isIconified { get; internal set; }
    }
}