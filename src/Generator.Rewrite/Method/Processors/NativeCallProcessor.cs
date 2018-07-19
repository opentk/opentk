using System;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace OpenTK.Rewrite.Method.Processors
{
    public class NativeCallProcessor : IMethodProcessor
    {
        private readonly int _slot;
        private readonly FieldDefinition _entryPoints;

        public NativeCallProcessor(int slot, FieldDefinition entryPointsField)
        {
            _slot = slot;
            _entryPoints = entryPointsField ?? throw new ArgumentNullException(nameof(entryPointsField));
        }

        public void Process(ILProcessor ilProcessor, MethodDefinition wrapper, MethodDefinition native)
        {
            if (_slot == -1)
            {
                // issue DllImport call
                ilProcessor.Emit(OpCodes.Call, native);
            }
            else
            {
                // push the entry point address on the stack
                ilProcessor.Emit(OpCodes.Ldsfld, _entryPoints);
                ilProcessor.Emit(OpCodes.Ldc_I4, _slot);
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
