using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using OpenToolkit.Native;

namespace OpenToolkit.Core.Emitter
{
    public class Generator
    {
        public void GenerateMethod(in MethodGenerationContext context)
        {
            EmitPrologue(context);
            EmitEntryPoint(context);
            EmitNativeCall(context);
            EmitEpilogue(context);
            EmitReturn(context);
        }

        public virtual void EmitPrologue(in MethodGenerationContext ctx)
        {
            for (var i = 1; i < ctx.MethodInfo.GetParameters().Length + 1; i++)
            {
                ctx.ILGenerator.Emit(OpCodes.Ldarg, (short)i);
            }
        }

        internal void EmitEntryPoint(in MethodGenerationContext ctx)
        {
            ctx.ILGenerator.Emit(OpCodes.Ldarg_0);
            ctx.ILGenerator.Emit(OpCodes.Ldc_I4, ctx.Slot);
            ctx.ILGenerator.Emit(OpCodes.Ldstr, ctx.ProcName);
            ctx.ILGenerator.Emit(OpCodes.Call, ApiContainer.GetOrLoadMethod);
        }

        internal void EmitNativeCall(in MethodGenerationContext ctx)
        {
            // FIXME!! This will not work because of argument loading (marshaling)!!
            // We want to use SignatureHelper to emit arg loading for the arguments
            ctx.ILGenerator.EmitCalli(
                OpCodes.Calli,
                CallingConventions.Standard,
                ctx.MethodInfo.ReturnType,
                ctx.MethodInfo.GetParameters().Select(param => param.ParameterType).ToArray(),
                null);
        }

        public virtual void EmitEpilogue(in MethodGenerationContext ctx)
        {
        }

        public virtual void EmitReturn(in MethodGenerationContext ctx)
        {
            ctx.ILGenerator.Emit(OpCodes.Ret);
        }
    }
}
