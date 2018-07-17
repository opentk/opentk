using System;
using System.Collections.Generic;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using OpenTK.Rewrite.Extensions;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="MethodConstructor"/> class.
        /// </summary>
        /// <param name="mscorlib">The mscorlib assembly definition to use for base types.</param>
        /// <param name="wrapper">The wrapper method that should be rewritten.</param>
        /// <param name="native">The native function definition that will be called by the wrapper method.</param>
        /// <param name="bindingsBaseType">
        /// The "BindingsBase" type which provides additional types and methods
        /// that help with wrapping around native functions.
        /// </param>
        /// <param name="options">The rewriter CLI options.</param>
        public MethodConstructor
        (
            AssemblyDefinition mscorlib,
            MethodDefinition wrapper,
            MethodDefinition native,
            TypeDefinition bindingsBaseType,
            RewriteOptions options
        )
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

        /// <summary>
        /// Constructs the method body with a given slot and entry points.
        /// </summary>
        /// <param name="slot">
        /// The index of the entry point to use in the EntryPoints array.<para/>
        /// Should be -1 if DllImport is used.
        /// </param>
        /// <param name="entryPoints">
        /// The field called "EntryPoints" that contains the entry points for the native function calls.
        /// </param>
        /// <returns>The rewritten wrapper method definition.</returns>
        public MethodDefinition ConstructBody(int slot, FieldDefinition entryPoints)
        {
            DebugVariables vars = null;
            if (_options.EnableDebugCalls)
            {
                vars = EmitDebugPrologue();
            }

            IEnumerable<GeneratedVariableIdentifier> generatedVariables;
            int paramCountDifference = _native.Parameters.Count - _wrapper.Parameters.Count;
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
