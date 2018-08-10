using System;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Methods.Processors
{
    /// <summary>
    /// Rewrites wrapper method IL to call the native function, either via DllImport or the calli opcode.
    /// </summary>
    public sealed class NativeCallProcessor : IMethodProcessor
    {
        private readonly bool _useDllImport;

        /// <summary>
        /// Initializes a new instance of the <see cref="NativeCallProcessor"/> class.
        /// </summary>
        /// <param name="useDllImport">Whether to use DllImport instead of GetProcAddress.</param>
        public NativeCallProcessor(bool useDllImport)
        {
            _useDllImport = useDllImport;
        }

        /// <inheritdoc/>
        public void Process(ILProcessor cilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            int slot = native.GetSlot();

            if (slot == -1 || _useDllImport)
            {
                // issue DllImport call
                cilProcessor.Emit(OpCodes.Call, native);
            }
            else
            {
                FieldDefinition entryPointsField = null;
                TypeDefinition currentType = wrapper.DeclaringType;

                do
                {
                    entryPointsField = currentType.Fields.FirstOrDefault(f => f.Name == "EntryPoints");
                }
                while (entryPointsField is null && !((currentType = currentType.DeclaringType) is null));

                if (entryPointsField is null)
                {
                    throw new InvalidOperationException
                    (
                        "The 'EntryPoints' field could not be found in any enclosing class."
                    );
                }

                // push the entry point address on the stack
                cilProcessor.Emit(OpCodes.Ldsfld, entryPointsField);
                cilProcessor.Emit(OpCodes.Ldc_I4, slot);
                cilProcessor.Emit(OpCodes.Ldelem_I);

                // issue calli
                var signature = new CallSite(native.ReturnType)
                {
                    CallingConvention = MethodCallingConvention.StdCall,
                };

                foreach (var p in native.Parameters)
                {
                    signature.Parameters.Add(p);
                }

                // Since the last parameter is always the entry point address,
                // we do not need any special preparation before emiting calli.
                cilProcessor.Emit(OpCodes.Calli, signature);
            }
        }
    }
}
