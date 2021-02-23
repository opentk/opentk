using System.Runtime.CompilerServices;

namespace OpenTK.Compute.Native
{
	/// <summary>
	/// This is a base class for OpenCL APIs that are using DllImport and want to resolve different dll names on different platforms.
	/// </summary>
	public abstract class CLBase
	{
		/// <summary>
		/// This needs to be called before trying to use any OpenCL functions.
		/// This should be done in the static constructor of any class that DllImports OpenCL functions.
		/// </summary>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RegisterOpenCLResolver()
		{
			CLLoader.RegisterDllResolver();
		}
	}
}
