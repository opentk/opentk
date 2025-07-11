using System;
namespace OpenTK.Platform.Native.macOS
{
    internal enum CVReturn : int
    {
        /// <summary>
        /// Indicates the operation completed successfully.
        /// </summary>
        kCVReturnSuccess                         = 0,
    
        /// <summary>
        /// Placeholder to mark the beginning of Core Video result codes (not returned by any functions).
        /// </summary>
        kCVReturnFirst                           = -6660,
    
        /// <summary>
        /// An otherwise undefined error occurred.
        /// </summary>
        kCVReturnError                           = kCVReturnFirst,
        /// <summary>
        /// Invalid function parameter. For example, out of range or the wrong type.
        /// </summary>
        kCVReturnInvalidArgument                 = -6661,
        /// <summary>
        /// Memory allocation for a buffer or buffer pool failed.
        /// </summary>
        kCVReturnAllocationFailed                = -6662,
        kCVReturnUnsupported                     = -6663,
        
        // DisplayLink related errors
        kCVReturnInvalidDisplay                  = -6670,
        kCVReturnDisplayLinkAlreadyRunning       = -6671,
        kCVReturnDisplayLinkNotRunning           = -6672,
        kCVReturnDisplayLinkCallbacksNotSet      = -6673,
        
        // Buffer related errors
        kCVReturnInvalidPixelFormat              = -6680,
        kCVReturnInvalidSize                     = -6681,
        kCVReturnInvalidPixelBufferAttributes    = -6682,
        kCVReturnPixelBufferNotOpenGLCompatible  = -6683,
        kCVReturnPixelBufferNotMetalCompatible   = -6684,
        
        // Buffer Pool related errors
        kCVReturnWouldExceedAllocationThreshold  = -6689,
        kCVReturnPoolAllocationFailed            = -6690,
        kCVReturnInvalidPoolAttributes           = -6691,
        
        /// <summary>
        /// Placeholder to mark the end of Core Video result codes (not returned by any functions).
        /// </summary>
        kCVReturnLast                            = -6699
    }
}