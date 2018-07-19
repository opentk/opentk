using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Mono.Cecil;
using Mono.Cecil.Rocks;
using OpenTK.Rewrite.Extensions;
using OpenTK.Rewrite.Method;
using OpenTK.Rewrite.Method.Processors;

namespace OpenTK.Rewrite
{
    /// <summary>
    /// Provides functionality to rewrite types in an assembly.
    /// </summary>
    public sealed class AssemblyRewriter
    {
        private readonly RewriteOptions _options;

        private AssemblyDefinition _mscorlib;

        private TypeDefinition _boolType;
        private TypeDefinition _bindingsBaseType;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyRewriter"/> class.
        /// </summary>
        /// <param name="options">The <see cref="RewriteOptions"/> to use during the rewriting process.</param>
        public AssemblyRewriter(RewriteOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (!File.Exists(options.TargetAssembly))
            {
                throw new ArgumentException
                (
                    $"Target assembly not found.\nPlease check the given path ({options.TargetAssembly})",
                    nameof(options.TargetAssembly)
                );
            }

            if (!File.Exists(Path.ChangeExtension(options.TargetAssembly, "pdb")))
            {
                throw new ArgumentException
                (
                    "Debugging symbols for target assembly not found. " +
                    "Please make sure that debugging symbols are being generated."
                );
            }

            _options = options;
        }

        /// <summary>
        /// Rewrite the given assembly.
        /// </summary>
        public void RewriteAssembly()
        {
            // we want to keep a valid symbols file (pdb/mdb)
            var readerParams = new ReaderParameters
            {
                AssemblyResolver = new DefaultAssemblyResolver(),
                ReadSymbols = true,
                ReadWrite = true,
            };

            var writerParams = new WriterParameters
            {
                WriteSymbols = true,
            };

            // check for keyfile
            if (!string.IsNullOrEmpty(_options.StrongNameKey) && File.Exists(_options.StrongNameKey))
            {
                string absoluteKeyFilePath = Path.GetFullPath(_options.StrongNameKey);

                using (var fs = new FileStream(absoluteKeyFilePath, FileMode.Open, FileAccess.Read))
                {
                    writerParams.StrongNameKeyPair = new StrongNameKeyPair(fs);
                }
            }
            else
            {
                Console.Error.WriteLine("No keyfile specified or keyfile missing.");
            }

            try
            {
                using (var assemblyDef = AssemblyDefinition.ReadAssembly(_options.TargetAssembly, readerParams))
                {
                    if (assemblyDef.CustomAttributes.Any(a => a.AttributeType.Name == AttributeNames.Rewritten))
                    {
                        Console.Error.WriteLine("Error: Assembly has already been rewritten.");
                        return;
                    }

                    foreach (var module in assemblyDef.Modules)
                    {
                        foreach (var reference in module.AssemblyReferences)
                        {
                            var resolved = module.AssemblyResolver.Resolve(reference);
                            if (reference.Name == "mscorlib")
                            {
                                _mscorlib = resolved;
                            }
                        }
                    }

                    _boolType = _mscorlib.MainModule.GetType(typeof(bool).FullName);
                    _bindingsBaseType = assemblyDef.Modules.First().GetType("OpenTK.BindingsBase");

                    if (_mscorlib == null)
                    {
                        Console.Error.WriteLine("Error: Failed to locate mscorlib.");
                        return;
                    }

                    foreach (var module in assemblyDef.Modules)
                    {
                        foreach (var type in module.Types)
                        {
                            RewriteType(type);
                        }
                    }

                    assemblyDef.Write(writerParams);
                }
            }
            catch (InvalidOperationException exc)
            {
                Console.Error.WriteLine
                (
                    "Failed to load the assembly. " +
                    "It may already have been rewritten, and the debug symbols no longer match."
                );
                Console.Error.WriteLine(exc);
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine(exc);
            }
        }

        private void RewriteType(TypeDefinition type)
        {
            var entryPoints = type.Fields.FirstOrDefault(f => f.Name == "EntryPoints");
            if (entryPoints != null)
            {
                // Build list of entry point signatures (one per entry point)
                var entrySignatures = type.Methods.Where(t =>
                {
                    return t.CustomAttributes.Any(a => a.AttributeType.Name == AttributeNames.Slot);
                }).ToList();

                RewriteWrapperMethods(type, entryPoints, entrySignatures);

                RemoveNativeSignatures(type, entrySignatures);
            }

            if (type.Name == AttributeNames.Rewritten)
            {
                var rewrittenConstructor = type.GetConstructors().First();
                var rewritten = new CustomAttribute(rewrittenConstructor);
                var attributeArg = new CustomAttributeArgument(type.Module.ImportReference(_boolType), true);
                rewritten.ConstructorArguments.Add(attributeArg);
                type.Module.Assembly.CustomAttributes.Add(rewritten);
            }
        }

        private int GetSlot(MethodDefinition signature)
        {
            if (_options.UseDllImport)
            {
                return -1;
            }

            var slotAttribute = signature.CustomAttributes.FirstOrDefault(a =>
            {
                return a.AttributeType.Name == AttributeNames.Slot;
            });
            return (int)(slotAttribute?.ConstructorArguments[0].Value ?? -1);
        }

        private void RemoveNativeSignatures(TypeDefinition type, IEnumerable<MethodDefinition> methods)
        {
            // Remove all DllImports for functions called through calli, since
            // their signatures are embedded directly into the calli callsite.
            // This reduces dll size by ~400KB.
            foreach (var m in methods.Where(s => GetSlot(s) != -1))
            {
                type.Methods.Remove(m);
            }
        }

        private void RewriteWrapperMethods
        (
            TypeDefinition type,
            FieldDefinition entryPoints,
            IEnumerable<MethodDefinition> entrySignatures
        )
        {
            var wrapperSignatures = type.Methods.Where(m =>
            {
                return m.IsPublic && m.CustomAttributes.Any(a => a.AttributeType.Name == AttributeNames.AutoGenerated);
            }).ToList();

            foreach (var wrapper in wrapperSignatures)
            {
                var autoGenerated = wrapper.GetCustomAttribute(AttributeNames.AutoGenerated, throwIfNoneFound: false);
                if (autoGenerated != null)
                {
                    string signatureName = (string)autoGenerated
                        .Fields
                        .First(f => f.Name == "EntryPoint")
                        .Argument
                        .Value;

                    var nativeSignature = entrySignatures.FirstOrDefault(s => s.Name == signatureName);
                    int slot = GetSlot(nativeSignature);

                    var processors = new IMethodProcessor[]
                    {
                        new ParameterProcessor(_mscorlib, _bindingsBaseType),
                        new NativeCallProcessor(slot, entryPoints),
                        new ReturnTypeProcessor(_mscorlib),
                    };

                    if (_options.EnableDebugCalls)
                    {
                        processors = processors.Prepend(new DebugPrologueProcessor()).ToArray();
                    }

                    var methodRewriter = new MethodRewriter(processors);
                    methodRewriter.ProcessWrapper(nativeSignature, wrapper);
                }
            }

            RemoveSupportingAttributes(type);

            foreach (var nestedType in type.NestedTypes)
            {
                RewriteWrapperMethods(nestedType, entryPoints, entrySignatures);
            }
        }

        private void RemoveSupportingAttributes(TypeDefinition type)
        {
            foreach (var method in type.Methods)
            {
                var attr = method.CustomAttributes;
                for (int i = 0; i < attr.Count; i++)
                {
                    if (attr[i].AttributeType.Name == AttributeNames.AutoGenerated)
                    {
                        attr.RemoveAt(i--);
                    }
                }

                foreach (var parameter in method.Parameters)
                {
                    var paramAttr = parameter.CustomAttributes;
                    for (var i = 0; i < paramAttr.Count; i++)
                    {
                        if (paramAttr[i].AttributeType.Name == AttributeNames.Count)
                        {
                            paramAttr.RemoveAt(i--);
                        }
                    }
                }
            }
        }
    }
}
