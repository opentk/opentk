using System;

namespace OpenTK.Platform.MacOS
{
    enum NSDragOperation : int
    {
        None = 0,
        Copy = 1,
        Link = 2,
        Generic = 4,
        Private = 8,
        AllObsolete = 15,
        Move = 16,
        Delete = 32,
        Every = Int32.MaxValue,
    }
}