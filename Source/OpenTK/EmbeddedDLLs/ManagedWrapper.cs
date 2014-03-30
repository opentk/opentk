using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace OpenTK.EmbeddedDLLs
{
	class ManagedWrapper
	{
		static ManagedWrapper()
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += new ResolveEventHandler(currentDomain_AssemblyResolve);
		}

		static Assembly currentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			return GetEmbeddedDLL(args.Name);
		}

		static string Platform
		{
			get
			{
				if (IntPtr.Size == 4) {
					return "x86";
				} else {
					return "x64";
				}
			}
		}

		private static Assembly GetEmbeddedDLL(string dll)
		{
			dll = dll.Replace(".dll", Platform + ".dll"); //Get the correct DLL name

			Assembly _assembly = Assembly.GetExecutingAssembly();
			Stream _asmStream = _assembly.GetManifestResourceStream("OptnTK.EmbeddedDLLs." + dll);
			Assembly target = Assembly.Load(ToByteArray(_asmStream));
			return target;
		}

		public static byte[] ToByteArray(Stream stream)
		{
			stream.Position = 0;
			byte[] buffer = new byte[stream.Length];
			for (int totalBytesCopied = 0; totalBytesCopied < stream.Length; )
				totalBytesCopied += stream.Read(buffer, totalBytesCopied, Convert.ToInt32(stream.Length) - totalBytesCopied);
			return buffer;
		}

		internal static void EnsureLoaded()
		{
			// Do nothing, this call will trigger the static method, registering this class as an assembly resolver.
		}
	}
}
