using System;

namespace OpenTK.Platform.MacOS
{
    /// <summary>
    /// The <see cref="NSAutoreleasePool"/> class is a wrapper around the native objective-C NSAutoreleasePool.
    /// In particular, this construct mimics the usage of an @autorelease block and can be used in much the same way,
    /// only with a C# using block instead.
    /// </summary>
    public sealed class NSAutoreleasePool : IDisposable
    {
        private readonly IntPtr _autoreleasePool;

        /// <summary>
        /// Allocates and initializes a new <see cref="NSAutoreleasePool"/>.
        /// </summary>
        public NSAutoreleasePool()
        {
            var uninitializedPool = Cocoa.SendIntPtr(Class.NSAutoreleasePool, Selector.Alloc);
            _autoreleasePool = Cocoa.SendIntPtr(uninitializedPool, Selector.Init);
        }

        /// <summary>
        /// Disposes of the <see cref="NSAutoreleasePool"/> instance, draining it.
        /// </summary>
        public void Dispose()
        {
            if (_autoreleasePool != IntPtr.Zero)
            {
                Cocoa.SendVoid(_autoreleasePool, Selector.Get("drain"));
            }
        }
    }
}