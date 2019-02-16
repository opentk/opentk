//
// TitleChangedEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.EventingModels
{
    public class TitleChangedEventArgs : EventArgs
    {
        public TitleChangedEventArgs()
        {
            
        }

        public TitleChangedEventArgs(TitleChangedEventArgs other)
        {
            this.Title = other.Title;
        }

        internal TitleChangedEventArgs(string Title)
        {
            this.Title = Title;
        }
        
        public string Title { get; internal set; }
    }
}