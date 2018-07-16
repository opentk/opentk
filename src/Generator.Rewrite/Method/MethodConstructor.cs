using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using System;
using System.Collections.Generic;

namespace OpenTK.Rewrite.Method
{
    public partial class MethodConstructor
    {
        private readonly MethodDefinition _wrapper;
        private readonly MethodDefinition _native;
        private readonly RewriteOptions _options;

        private readonly TypeDefinition _arrayType;
        private readonly TypeDefinition _bindingsBaseType;
        private readonly TypeDefinition _int32Type;
        private readonly TypeDefinition _intPtrType;
        private readonly TypeDefinition _marshalType;
        private readonly TypeDefinition _stringType;
        private readonly TypeDefinition _voidType;

        private readonly MethodBody _body;
        private readonly ILProcessor _ilProcessor;

        public MethodConstructor(AssemblyDefinition mscorlib, MethodDefinition wrapper, MethodDefinition native, TypeDefinition bindingsBaseType, RewriteOptions options)
        {
            if (mscorlib == null)
            {
                throw new ArgumentNullException(nameof(mscorlib));
            }

            _wrapper = wrapper ?? throw new ArgumentNullException(nameof(wrapper));
            _native = native ?? throw new ArgumentNullException(nameof(_native));
            _bindingsBaseType = bindingsBaseType ?? throw new ArgumentNullException(nameof(bindingsBaseType));
            _options = options ?? throw new ArgumentNullException(nameof(options));

            _arrayType = mscorlib.MainModule.GetType(typeof(Array).FullName);
            _int32Type = mscorlib.MainModule.GetType(typeof(int).FullName);
            _intPtrType = mscorlib.MainModule.GetType(typeof(IntPtr).FullName);
            _marshalType = mscorlib.MainModule.GetType(typeof(System.Runtime.InteropServices.Marshal).FullName);
            _stringType = mscorlib.MainModule.GetType(typeof(string).FullName);
            _voidType = mscorlib.MainModule.GetType(typeof(void).FullName);

            _body = _wrapper.Body;
            _ilProcessor = _body.GetILProcessor();
            _body.Instructions.Clear();
        }

        public MethodDefinition ConstructBody(int slot, FieldDefinition entryPoints)
        {
            DebugVariables vars = null;
            if (_options.EnableDebugCalls)
            {
                vars = EmitDebugPrologue();
            }

            IEnumerable<GeneratedVariableIdentifier> generatedVariables;
            int paramCountDifference = _wrapper.Parameters.Count - _native.Parameters.Count;
            if (paramCountDifference == 0)
            {
                generatedVariables = EmitParameters();
            }
            else
            {
                generatedVariables = EmitConvenienceWrapper(paramCountDifference);
            }

            if (slot == -1 || _options.UseDllImport)
            {
                // issue DllImport call
                _ilProcessor.Emit(OpCodes.Call, _native);
            }
            else
            {
                // push the entry point address on the stack
                _ilProcessor.Emit(OpCodes.Ldsfld, entryPoints);
                _ilProcessor.Emit(OpCodes.Ldc_I4, slot);
                _ilProcessor.Emit(OpCodes.Ldelem_I);

                // issue calli
                var signature = new CallSite(_native.ReturnType)
                {
                    CallingConvention = MethodCallingConvention.StdCall,
                };

                foreach (var p in _native.Parameters)
                {
                    signature.Parameters.Add(p);
                }

                // Since the last parameter is always the entry point address,
                // we do not need any special preparation before emiting calli.
                _ilProcessor.Emit(OpCodes.Calli, signature);
            }

            if (!_wrapper.ReturnType.FullNameEquals(typeof(void)))
            {
                EmitReturnTypeWrapper();
            }

            EmitParameterEpilogues(generatedVariables);

            if (_options.EnableDebugCalls)
            {
                EmitDebugEpilogue(vars);
            }

            // return
            _ilProcessor.Emit(OpCodes.Ret);

            if (_body.Variables.Count > 0)
            {
                // Required for verifiable executables
                // (otherwise peverify complains bitterly)
                _body.InitLocals = true;
            }

            _body.OptimizeMacros();

            return _wrapper;
        }
    }
}