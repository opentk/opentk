using System;

namespace OpenTK.Platform.MacOS
{
    // Values for enum : https://developer.apple.com/documentation/appkit/nsdragoperation?language=objc
    // or for Mac users /System/Library/Frameworks/AppKit.framework/Headers
    // Used by draggingSourceOperationMask(:) to get permission for dropped object
    // also used for respones to drag source
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
