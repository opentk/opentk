using AdvancedDLSupport;

namespace FooBar
{
    public static partial class GL
    {
        public static IGL instance = new NativeLibraryBuilder().ActivateInterface<IGL>("libGL.so");
    }
}