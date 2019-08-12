using AdvancedDLSupport;

namespace FooBar
{
    public static partial class GL
    {
        public static IGL instance = new NativeLibraryBuilder(ImplementationOptions.SuppressSecurity |
                                                     ImplementationOptions.GenerateDisposalChecks |
                                                     ImplementationOptions.UseLazyBinding |
                                                     ImplementationOptions.EnableOptimizations).ActivateInterface<IGL>("libGL.so");
    }
}