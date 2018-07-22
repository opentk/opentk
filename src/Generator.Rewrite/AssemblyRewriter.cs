using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Mono.Cecil;
using OpenTK.Rewrite.Types;

namespace OpenTK.Rewrite
{
    /// <summary>
    /// Provides functionality to rewrite types in an assembly.
    /// </summary>
    public sealed class AssemblyRewriter
    {
        private readonly ReaderParameters _readerParams;
        private readonly WriterParameters _writerParams;

        private readonly Func<AssemblyDefinition, TypeDefinition, bool, ITypeRewriter> _typeRewriterFactory;

        public AssemblyRewriter
        (
            IAssemblyResolver assemblyResolver,
            Func<AssemblyDefinition, TypeDefinition, bool, ITypeRewriter> typeRewriterFactory,
            string strongNameKeyPath
        )
        {
            _readerParams = new ReaderParameters
            {
                AssemblyResolver = assemblyResolver,
                ReadSymbols = true,
                ReadWrite = true,
            };

            _typeRewriterFactory = typeRewriterFactory ?? throw new ArgumentNullException(nameof(typeRewriterFactory));

            string absoluteKeyFilePath = Path.GetFullPath(strongNameKeyPath);

            using (var fs = new FileStream(absoluteKeyFilePath, FileMode.Open, FileAccess.Read))
            {
                _writerParams = new WriterParameters
                {
                    WriteSymbols = true,
                    StrongNameKeyPair = new StrongNameKeyPair(fs)
                };
            }
        }

        public void RewriteAssembly(string targetAssemblyPath, bool enableDebugCalls, bool useDllImport)
        {
            if (!File.Exists(targetAssemblyPath))
            {
                throw new ArgumentException
                (
                    $"Target assembly not found.\nPlease check the given path '{targetAssemblyPath}'",
                    nameof(targetAssemblyPath)
                );
            }

            if (!File.Exists(Path.ChangeExtension(targetAssemblyPath, "pdb")))
            {
                throw new ArgumentException
                (
                    "Debugging symbols for target assembly not found. " +
                    "Please make sure that debugging symbols are being generated."
                );
            }

            Console.WriteLine($"Reading target assembly from '{targetAssemblyPath}'...");
            using (var assembly = AssemblyDefinition.ReadAssembly(targetAssemblyPath, _readerParams))
            {
                if (assembly.CustomAttributes.Any(a => a.AttributeType.Name == AttributeNames.Rewritten))
                {
                    throw new InvalidOperationException
                    (
                        $"The '{AttributeNames.Rewritten}' is already present in the target assembly, " +
                        "which means that it has already been rewritten."
                    );
                }

                Console.WriteLine("Starting rewriting process...");
                Console.WriteLine("Trying to locate mscorlib...");

                AssemblyDefinition mscorlib = null;
                foreach (var module in assembly.Modules)
                {
                    foreach (var reference in module.AssemblyReferences)
                    {
                        var resolved = module.AssemblyResolver.Resolve(reference);
                        if (reference.Name == "mscorlib" && mscorlib is null)
                        {
                            mscorlib = resolved;
                        }
                    }
                }

                if (mscorlib is null)
                {
                    throw new ArgumentException("Failed to locate mscorlib in the given target assembly.");
                }
                Console.WriteLine($"Rewriting assembly with mscorlib: {mscorlib}");
                Console.WriteLine();

                var bindingsBaseType = assembly.Modules.First().GetType("OpenTK.BindingsBase");
                var typeRewriter = _typeRewriterFactory(mscorlib, bindingsBaseType, useDllImport);

                foreach (var module in assembly.Modules)
                {
                    foreach (var type in module.Types)
                    {
                        Console.WriteLine($"Rewriting type {type}...");
                        typeRewriter.Rewrite(type);
                    }
                }

                Console.WriteLine("Persisting rewritten assembly to file...");
                assembly.Write(_writerParams);
            }
        }
    }
}
