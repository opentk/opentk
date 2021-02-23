using System;
using System.Reflection;
using System.Runtime.InteropServices;
using OpenTK.Compute.OpenCL;

namespace OpenTK.Compute.Native
{
	/// <summary>
	/// Provides a base for ApiContext so that it can register dll intercepts.
	/// </summary>
	internal static class CLLoader
	{
		private static readonly OpenCLLibraryNameContainer CLLibraryNameContainer = new OpenCLLibraryNameContainer();

		private static bool RegisteredResolver = false;

		static CLLoader()
		{
			RegisterDllResolver();
		}

		internal static void RegisterDllResolver()
		{
			if (RegisteredResolver == false)
			{
				NativeLibrary.SetDllImportResolver(typeof(CLLoader).Assembly, ImportResolver);
				RegisteredResolver = true;
			}
		}

		private static IntPtr ImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
		{
			string libName = CLLibraryNameContainer.GetLibraryName();

			if (NativeLibrary.TryLoad(libName, assembly, searchPath, out IntPtr libHandle) == false)
			{
				throw new DllNotFoundException(
					$"Could not load the dll '{libName}' (this load is intercepted, specified in DllImport as '{libraryName}').");
			}

			return libHandle;
		}
	}
}
