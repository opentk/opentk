using System;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using OpenTK.Rewrite.Extensions;

namespace OpenTK.Rewrite.Methods.Processors
{
    public sealed class NativeCallProcessor : IMethodProcessor
    {
        private readonly bool _useDllImport;

        public NativeCallProcessor(bool useDllImport)
        {
            _useDllImport = useDllImport;
        }

        public void Process(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            int slot = native.GetSlot();

            if (slot == -1 || _useDllImport)
            {
                // issue DllImport call
                ilProcessor.Emit(OpCodes.Call, native);
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
                ilProcessor.Emit(OpCodes.Ldsfld, entryPointsField);
                ilProcessor.Emit(OpCodes.Ldc_I4, slot);
                ilProcessor.Emit(OpCodes.Ldelem_I);

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
                ilProcessor.Emit(OpCodes.Calli, signature);
            }
        }
    }
}
