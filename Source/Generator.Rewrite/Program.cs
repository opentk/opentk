// OpenTK.Rewrite: IL rewriter for OpenTK.dll
// Copyright (C) 2013 Stefanos Apostolopoulos
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;

namespace OpenTK.Rewrite
{
    // Replaces OpenTK.InteropHelper method instances
    // with the s IL instructions.
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: rewrite [file.dll] [file.snk] [options]");
                Console.WriteLine("[options] is:");
                Console.WriteLine("    -debug (enable calls to GL.GetError())");
                return;
            }

            var program = new Program();
            var file = args[0];
            var key = args[1];
            var options = args.Where(a => a.StartsWith("-") || a.StartsWith("/"));
            program.Rewrite(file, key, options);
        }

        // mscorlib types
        static AssemblyDefinition mscorlib;
        static TypeDefinition TypeMarshal;
        static TypeDefinition TypeStringArray;
        static TypeDefinition TypeStringBuilder;
        static TypeDefinition TypeVoid;
        static TypeDefinition TypeIntPtr;
        static TypeDefinition TypeInt32;

        // OpenTK.BindingsBase
        static TypeDefinition TypeBindingsBase;

        void Rewrite(string file, string keyfile, IEnumerable<string> options)
        {
            // Specify assembly read and write parameters
            // We want to keep a valid symbols file (pdb or mdb)
            var read_params = new ReaderParameters();
            var write_params = new WriterParameters();
            var pdb = Path.ChangeExtension(file, "pdb");
            var mdb = Path.ChangeExtension(file, "mdb");
            ISymbolReaderProvider provider = null;
            if (File.Exists(pdb))
            {
                provider = new Mono.Cecil.Pdb.PdbReaderProvider();
            }
            else if (File.Exists(mdb))
            {
                provider = new Mono.Cecil.Mdb.MdbReaderProvider();
            }
            read_params.SymbolReaderProvider = provider;
            read_params.ReadSymbols = true;
            write_params.WriteSymbols = true;

            if (!String.IsNullOrEmpty(keyfile) && File.Exists(keyfile))
            {
                keyfile = Path.GetFullPath(keyfile);
                var fs = new FileStream(keyfile, FileMode.Open);
                var keypair = new System.Reflection.StrongNameKeyPair(fs);
                fs.Close();
                write_params.StrongNameKeyPair = keypair;
            }
            else
            {
                Console.Error.WriteLine("No keyfile specified or keyfile missing.");
            }

            // Load assembly and process all modules
            var assembly = AssemblyDefinition.ReadAssembly(file, read_params);
            var rewritten = assembly.CustomAttributes.FirstOrDefault(a => a.AttributeType.Name == "RewrittenAttribute");
            if (rewritten == null)
            {
                foreach (var module in assembly.Modules)
                {
                    foreach (var reference in module.AssemblyReferences)
                    {
                        var resolved = module.AssemblyResolver.Resolve(reference);
                        if (reference.Name == "mscorlib")
                        {
                            mscorlib = resolved;
                        }
                    }
                }

                if (mscorlib == null)
                {
                    Console.Error.WriteLine("Failed to locate mscorlib");
                    return;
                }
                TypeMarshal = mscorlib.MainModule.GetType("System.Runtime.InteropServices.Marshal");
                TypeStringArray = mscorlib.MainModule.GetType("System.String").MakeArrayType().Resolve();
                TypeStringBuilder = mscorlib.MainModule.GetType("System.Text.StringBuilder");
                TypeVoid = mscorlib.MainModule.GetType("System.Void");
                TypeIntPtr = mscorlib.MainModule.GetType("System.IntPtr");
                TypeInt32 = mscorlib.MainModule.GetType("System.Int32");

                TypeBindingsBase = assembly.Modules.Select(m => m.GetType("OpenTK.BindingsBase")).First();

                foreach (var module in assembly.Modules)
                {
                    foreach (var type in module.Types)
                    {
                        Rewrite(type, options);
                    }
                }
            }
            else
            {
                Console.Error.WriteLine("Error: assembly has already been rewritten");
            }

            // Save rewritten assembly
            assembly.Write(file, write_params);
        }

        void Rewrite(TypeDefinition type, IEnumerable<string> options)
        {
            var entry_points = type.Fields.FirstOrDefault(f => f.Name == "EntryPoints");
            if (entry_points != null)
            {
                // Build list of entry point signatures (one per entry point) 
                var entry_signatures = new List<MethodDefinition>();
                entry_signatures.AddRange(type.Methods
                    .Where(t => t.CustomAttributes.Any(a => a.AttributeType.Name == "SlotAttribute")));

                Rewrite(type, entry_points, entry_signatures, options);

                RemoveNativeSignatures(type, entry_signatures);
            }

            if (type.Name == "RewrittenAttribute")
            {
                var rewritten_constructor = type.GetConstructors().First();
                var rewritten = new CustomAttribute(rewritten_constructor);
                rewritten.ConstructorArguments.Add(new CustomAttributeArgument(
                    type.Module.Import(mscorlib.MainModule.GetType("System.Boolean")), true));
                type.Module.Assembly.CustomAttributes.Add(rewritten);
            }
        }

        int GetSlot(MethodDefinition signature)
        {
            var slot_attribute = signature.CustomAttributes
                        .FirstOrDefault(a => a.AttributeType.Name == "SlotAttribute");
            int slot =
                slot_attribute != null ?
                (int)slot_attribute.ConstructorArguments[0].Value :
                -1;

            return slot;
        }

        void Rewrite(TypeDefinition type, FieldDefinition entry_points,
            List<MethodDefinition> entry_signatures, IEnumerable<string> options)
        {
            // Rewrite all wrapper methods
            var wrapper_signatures = new List<MethodDefinition>();
            wrapper_signatures.AddRange(type.Methods
                .Where(m => m.IsPublic && m.CustomAttributes.Any(a => a.AttributeType.Name == "AutoGeneratedAttribute")));

            foreach (var wrapper in wrapper_signatures)
            {
                var autogenerated = wrapper.CustomAttributes
                    .Where(a => a.AttributeType.Name == "AutoGeneratedAttribute");
                if (autogenerated.Count() > 0)
                {
                    var signature_name = (string)autogenerated.First()
                        .Fields.First(f => f.Name == "EntryPoint").Argument.Value;
                    var signature = entry_signatures.FirstOrDefault(s => s.Name == signature_name);
                    int slot = GetSlot(signature);

                    ProcessMethod(wrapper, signature, slot, entry_points, options);
                }
            }

            RemoveSupportingAttributes(type);

            if (type.NestedTypes.Count > 0)
            {
                foreach (var nested_type in type.NestedTypes)
                {
                    Rewrite(nested_type, entry_points, entry_signatures, options);
                }
            }
        }

        void RemoveNativeSignatures(TypeDefinition type, List<MethodDefinition> methods)
        {
            // Remove all DllImports for functions called through calli, since
            // their signatures are embedded directly into the calli callsite.
            // This reduces dll size by ~400KB.
            foreach (var m in methods.Where(s => GetSlot(s) != -1))
            {
                type.Methods.Remove(m);
            }
        }

        void RemoveSupportingAttributes(TypeDefinition type)
        {
            foreach (var method in type.Methods)
            {
                var attr = method.CustomAttributes;
                for (int i = 0; i < attr.Count; i++)
                {
                    if (attr[i].AttributeType.Name == "AutoGeneratedAttribute")
                    {
                        attr.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        // Create body for method
        static void ProcessMethod(MethodDefinition wrapper, MethodDefinition native, int slot,
                                  FieldDefinition entry_points, IEnumerable<string> options)
        {
            var body = wrapper.Body;
            var il = body.GetILProcessor();
            var instructions = body.Instructions;
            instructions.Clear();

            // Declare pinned variables for every reference and array parameter
            // and push each parameter on the stack

            DebugVariables vars = null;
            if (options.Contains("-debug"))
            {
                vars = EmitDebugPrologue(wrapper, il);
            }

            // Patch convenience wrappers
            if (wrapper.Parameters.Count == native.Parameters.Count)
            {
                EmitParameters(wrapper, body, il);
            }
            else
            {
                int difference = native.Parameters.Count - wrapper.Parameters.Count;
                EmitConvenienceWrapper(wrapper, native, difference, body, il);
            }

            if (slot != -1)
            {
                // push the entry point address on the stack
                EmitEntryPoint(entry_points, il, slot);

                // issue calli
                EmitCalli(il, native);
            }
            else
            {
                // issue DllImport call
                EmitCall(il, native);
            }

            if (wrapper.ReturnType.Name != "Void")
            {
                EmitReturnTypeWrapper(wrapper, native, body, il);
            }

            EmitParameterEpilogues(wrapper, native, body, il);

            if (options.Contains("-debug"))
            {
                EmitDebugEpilogue(wrapper, il, vars);
            }

            // return
            il.Emit(OpCodes.Ret);

            if (body.Variables.Count > 0)
            {
                // Required for verifiable executables
                // (otherwise peverify complains bitterly)
                body.InitLocals = true;
            }
            body.OptimizeMacros();
        }

        class DebugVariables
        {
            public TypeDefinition ErrorHelperType;
            public VariableDefinition ErrorHelperLocal;
            public MethodReference Get_CurrentContext;
            public MethodReference Set_ErrorChecking;
            public Instruction BeginTry;
        }

        static DebugVariables EmitDebugPrologue(MethodDefinition wrapper, ILProcessor il)
        {

            DebugVariables vars = null;
            if (il.Body.Method.Name != "GetError")
            {
                // Pull out the namespace name, method fullname will look 
                // something like "type namespace.class::method(type arg)"
                var module = il.Body.Method.FullName;
                module = module.Substring(module.IndexOf(' ') + 1);
                module = module.Substring(0, module.IndexOf("::"));
                module = module.Substring(0, module.LastIndexOf('.'));

                // Only works for Graphics modules due to hardcoded use of
                // OpenTK.Graphics.GraphicsContext
                if (module == "OpenTK.Graphics.OpenGL4" ||
                    module == "OpenTK.Graphics.OpenGL" ||
                    module == "OpenTK.Graphics.ES10" ||
                    module == "OpenTK.Graphics.ES11" ||
                    module == "OpenTK.Graphics.ES20" ||
                    module == "OpenTK.Graphics.ES30")
                {
                    var errorHelperType = wrapper.Module.GetType(module, "ErrorHelper");

                    if (errorHelperType != null)
                    {
                        vars = new DebugVariables();
                        vars.ErrorHelperType = errorHelperType;

                        // GraphicsContext type
                        var graphicsContext = wrapper.Module.Types.First(
                            type => type.FullName == "OpenTK.Graphics.GraphicsContext");

                        // IGraphicsContext type
                        var iGraphicsContext = wrapper.Module.Types.First(
                            type => type.FullName == "OpenTK.Graphics.IGraphicsContext");

                        // Get the constructor that takes a GraphicsContext parameter
                        var ctor = vars.ErrorHelperType.GetConstructors().FirstOrDefault(
                            c => c.Parameters.Count == 1 &&
                            c.Parameters[0].ParameterType.FullName == iGraphicsContext.FullName);

                        if (ctor == null)
                        {
                            throw new InvalidOperationException(
                                String.Format(
                                    "{0} does needs a constructor taking {1}",
                                    errorHelperType,
                                    graphicsContext));
                        }

                        // GraphicsContext.CurrentContext property getter
                        vars.Get_CurrentContext = graphicsContext.Methods.First(
                            method => method.Name == "get_CurrentContext");

                        vars.Set_ErrorChecking = graphicsContext.Methods.First(
                            method => method.Name == "set_ErrorChecking");

                        vars.ErrorHelperLocal = new VariableDefinition(vars.ErrorHelperType);

                        // using (new ErrorHelper(GraphicsContext.CurrentContext)) { ...
                        il.Body.Variables.Add(vars.ErrorHelperLocal);
                        il.Emit(OpCodes.Ldloca, vars.ErrorHelperLocal);
                        il.Emit(OpCodes.Call, vars.Get_CurrentContext);
                        il.Emit(OpCodes.Call, ctor);

                        vars.BeginTry = Instruction.Create(OpCodes.Nop);
                        il.Append(vars.BeginTry);

                        // Special case Begin to turn off error checking.
                        if (il.Body.Method.Name == "Begin")
                        {
                            il.Emit(OpCodes.Call, vars.Get_CurrentContext);
                            il.Emit(OpCodes.Ldc_I4_0);
                            il.Emit(OpCodes.Conv_I1);
                            il.Emit(OpCodes.Call, vars.Set_ErrorChecking);
                        }
                    }
                }
            }

            return vars;
        }

        static void EmitDebugEpilogue(MethodDefinition wrapper, ILProcessor il, DebugVariables vars)
        {
            if (vars != null)
            {
                var disposeMethod = vars.ErrorHelperType.Methods.First(
                    method => method.Name == "Dispose");

                // Store then reload the result from the call
                var resultLocal = new VariableDefinition(wrapper.ReturnType);
                if (resultLocal.VariableType.FullName != Program.TypeVoid.FullName)
                {
                    il.Body.Variables.Add(resultLocal);
                    il.Emit(OpCodes.Stloc, resultLocal);
                }

                // Special case End to turn on error checking.
                if (il.Body.Method.Name == "End")
                {
                    il.Emit(OpCodes.Call, vars.Get_CurrentContext);
                    il.Emit(OpCodes.Ldc_I4_1);
                    il.Emit(OpCodes.Conv_I1);
                    il.Emit(OpCodes.Call, vars.Set_ErrorChecking);
                }

                // We need a NOP to set up the finally handler range correctly.
                var nopInstruction = Instruction.Create(OpCodes.Nop);
                var loadInstruction = Instruction.Create(OpCodes.Ldloca, vars.ErrorHelperLocal);
                var disposeInstruction = Instruction.Create(OpCodes.Call, disposeMethod);
                var endFinallyInstruction = Instruction.Create(OpCodes.Endfinally);
                var endTryInstruction = Instruction.Create(OpCodes.Leave, nopInstruction);

                il.Append(endTryInstruction);
                il.Append(loadInstruction);
                il.Append(disposeInstruction);
                il.Append(endFinallyInstruction);
                il.Append(nopInstruction);

                var finallyHandler = new ExceptionHandler(ExceptionHandlerType.Finally);
                finallyHandler.TryStart = vars.BeginTry;
                finallyHandler.TryEnd = loadInstruction;
                finallyHandler.HandlerStart = loadInstruction;
                finallyHandler.HandlerEnd = nopInstruction;

                il.Body.ExceptionHandlers.Add(finallyHandler);

                if (resultLocal.VariableType.FullName != Program.TypeVoid.FullName)
                {
                    il.Emit(OpCodes.Ldloc, resultLocal);
                }
            }
        }

        private static void EmitReturnTypeWrapper(MethodDefinition wrapper, MethodDefinition native, MethodBody body, ILProcessor il)
        {
            if (wrapper.Parameters.Count < native.Parameters.Count)
            {
                // Convenience wrapper. The result is stored in the last local variable
                il.Emit(OpCodes.Ldloc, body.Variables.Count - 1);
            }
            else if (wrapper.ReturnType != native.ReturnType)
            {
                if (wrapper.ReturnType.Name == "String")
                {
                    // String return-type wrapper
                    // return new string((sbyte*)((void*)GetString()));

                    var intptr_to_voidpointer = wrapper.Module.Import(mscorlib.MainModule.GetType("System.IntPtr").GetMethods()
                        .First(m =>
                    {
                        return
                                m.Name == "op_Explicit" &&
                        m.ReturnType.Name == "Void*";
                    }));

                    var string_constructor = wrapper.Module.Import(mscorlib.MainModule.GetType("System.String").GetConstructors()
                        .First(m =>
                    {
                        var p = m.Parameters;
                        return p.Count > 0 && p[0].ParameterType.Name == "SByte*";
                    }));

                    il.Emit(OpCodes.Call, intptr_to_voidpointer);
                    il.Emit(OpCodes.Newobj, string_constructor);
                }
                else if (wrapper.ReturnType.Resolve().IsEnum)
                {
                    // Nothing to do
                }
                else if (wrapper.ReturnType.Name == "Boolean" && native.ReturnType.Name == "Byte")
                {
                    // Nothing to do
                    // It appears that a byte with 1 = true (GL_TRUE) and 0 = false (GL_FALSE)
                    // can be reinterpreted as a bool without a problem.
                    // Todo: maybe we should return (value == 0 ? false : true) just to be
                    // on the safe side?
                }
                else
                {
                    Console.Error.WriteLine("Return wrapper for '{1}' not implemented yet ({0})", native.Name, wrapper.ReturnType.Name);
                }
            }
            else
            {
                // nothing to do, the native call leaves the return value
                // on the stack and we return that unmodified to the caller.
            }
        }

        static void EmitParameterEpilogues(MethodDefinition wrapper, MethodDefinition native, MethodBody body, ILProcessor il)
        {
            foreach (var p in wrapper.Parameters)
            {
                if (p.ParameterType.Name == "StringBuilder")
                {
                    EmitStringBuilderEpilogue(wrapper, native, p, body, il);
                }

                if (!p.ParameterType.IsArray && p.ParameterType.Name == "String")
                {
                    EmitStringEpilogue(wrapper, p, body, il);
                }

                if (p.ParameterType.IsArray && p.ParameterType.GetElementType().Name == "String")
                {
                    EmitStringArrayEpilogue(wrapper, p, body, il);
                }
            }
        }

        static void EmitStringBuilderParameter(MethodDefinition method, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;

            // void GetShaderInfoLog(..., StringBuilder foo)
            // IntPtr foo_sb_ptr;
            // try {
            //  foo_sb_ptr = Marshal.AllocHGlobal(sb.Capacity + 1);
            //  glGetShaderInfoLog(..., foo_sb_ptr);
            //  MarshalPtrToStringBuilder(foo_sb_ptr, sb);
            // }
            // finally {
            //  Marshal.FreeHGlobal(sb_ptr);
            // }
            // Make sure we have imported StringBuilder::Capacity and Marshal::AllocHGlobal
            var sb_get_capacity = method.Module.Import(TypeStringBuilder.Methods.First(m => m.Name == "get_Capacity"));
            var alloc_hglobal = method.Module.Import(TypeMarshal.Methods.First(m => m.Name == "AllocHGlobal"));

            // IntPtr ptr;
            var variable_name = parameter.Name + " _sb_ptr";
            body.Variables.Add(new VariableDefinition(variable_name, TypeIntPtr));
            int index = body.Variables.Count - 1;

            // ptr = Marshal.AllocHGlobal(sb.Capacity + 1);
            il.Emit(OpCodes.Callvirt, sb_get_capacity);
            il.Emit(OpCodes.Call, alloc_hglobal);
            il.Emit(OpCodes.Stloc, index);
            il.Emit(OpCodes.Ldloc, index);

            // We'll emit the try-finally block in the epilogue implementation,
            // because we haven't yet emitted all necessary instructions here.
        }

        static void EmitStringBuilderEpilogue(MethodDefinition wrapper, MethodDefinition native, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;
            if (p.Name == "StringBuilder")
            {
                // void GetShaderInfoLog(..., StringBuilder foo)
                // try {
                //  foo_sb_ptr = Marshal.AllocHGlobal(sb.Capacity + 1); -- already emitted
                //  glGetShaderInfoLog(..., foo_sb_ptr); -- already emitted
                //  MarshalPtrToStringBuilder(foo_sb_ptr, foo);
                // }
                // finally {
                //  Marshal.FreeHGlobal(foo_sb_ptr);
                // }

                // Make sure we have imported BindingsBase::MasrhalPtrToStringBuilder and Marshal::FreeHGlobal
                var ptr_to_sb = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "MarshalPtrToStringBuilder"));
                var free_hglobal = wrapper.Module.Import(TypeMarshal.Methods.First(m => m.Name == "FreeHGlobal"));

                var block = new ExceptionHandler(ExceptionHandlerType.Finally);
                block.TryStart = body.Instructions[0];

                var variable_name = parameter.Name + " _sb_ptr";
                var v = body.Variables.First(m => m.Name == variable_name);
                il.Emit(OpCodes.Ldloc, v.Index);
                il.Emit(OpCodes.Ldarg, parameter.Index);
                il.Emit(OpCodes.Call, ptr_to_sb);

                block.TryEnd = body.Instructions.Last();
                block.HandlerStart = body.Instructions.Last();

                il.Emit(OpCodes.Ldloc, v.Index);
                il.Emit(OpCodes.Call, free_hglobal);

                block.HandlerEnd = body.Instructions.Last();
            }
        }

        static void EmitStringParameter(MethodDefinition wrapper, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;

            // string marshaling:
            // IntPtr ptr = MarshalStringToPtr(str);
            // try { calli }
            // finally { Marshal.FreeHGlobal(ptr); }
            var marshal_str_to_ptr = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "MarshalStringToPtr"));

            // IntPtr ptr;
            var variable_name = parameter.Name + "_string_ptr";
            body.Variables.Add(new VariableDefinition(variable_name, TypeIntPtr));
            int index = body.Variables.Count - 1;

            // ptr = Marshal.StringToHGlobalAnsi(str);
            il.Emit(OpCodes.Call, marshal_str_to_ptr);
            il.Emit(OpCodes.Stloc, index);
            il.Emit(OpCodes.Ldloc, index);

            // The finally block will be emitted in the function epilogue
        }

        static void EmitStringEpilogue(MethodDefinition wrapper, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;
            var free = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "FreeStringPtr"));

            // FreeStringPtr(ptr)
            var variable_name = parameter.Name + "_string_ptr";
            var v = body.Variables.First(m => m.Name == variable_name);
            il.Emit(OpCodes.Ldloc, v.Index);
            il.Emit(OpCodes.Call, free);
        }

        static void EmitStringArrayParameter(MethodDefinition wrapper, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;

            // string[] masrhaling:
            // IntPtr ptr = MarshalStringArrayToPtr(strings);
            // try { calli }
            // finally { FreeStringArrayPtr(ptr); }
            var marshal_str_array_to_ptr = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "MarshalStringArrayToPtr"));

            // IntPtr ptr;
            var variable_name = parameter.Name + "_string_array_ptr";
            body.Variables.Add(new VariableDefinition(variable_name, TypeIntPtr));
            int index = body.Variables.Count - 1;

            // ptr = MarshalStringArrayToPtr(strings);
            il.Emit(OpCodes.Call, marshal_str_array_to_ptr);
            il.Emit(OpCodes.Stloc, index);
            il.Emit(OpCodes.Ldloc, index);

            // The finally block will be emitted in the function epilogue
        }

        static void EmitStringArrayEpilogue(MethodDefinition wrapper, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            // Note: only works for string vectors (1d arrays).
            // We do not (and will probably never) support 2d or higher string arrays
            var p = parameter.ParameterType;
            var free = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "FreeStringArrayPtr"));

            // FreeStringArrayPtr(string_array_ptr, string_array.Length)
            var variable_name = parameter.Name + "_string_array_ptr";
            var v = body.Variables.First(m => m.Name == variable_name);

            // load string_array_ptr
            il.Emit(OpCodes.Ldloc, v.Index);

            // load string_array.Length
            il.Emit(OpCodes.Ldarg, parameter.Index);
            il.Emit(OpCodes.Ldlen);
            il.Emit(OpCodes.Conv_I4);

            // call FreeStringArrayPtr
            il.Emit(OpCodes.Call, free);
        }

        static void EmitConvenienceWrapper(MethodDefinition wrapper,
            MethodDefinition native, int difference, MethodBody body, ILProcessor il)
        {
            if (wrapper.Parameters.Count > 2)
            {
                // Todo: emit all parameters bar the last two
                throw new NotImplementedException();
            }

            if (wrapper.ReturnType.Name != "Void")
            {
                if (difference == 2)
                {
                    // Convert sized out-array/reference to return value, for example:
                    // void GenTextures(int n, int[] textures) -> int GenTexture()
                    // {
                    //  const int n = 1;
                    //  int buffers;
                    //  calli GenTextures(n, &textures);
                    //  return result;
                    // }
                    body.Variables.Add(new VariableDefinition(wrapper.ReturnType));
                    il.Emit(OpCodes.Ldc_I4, 1); // const int n = 1
                    il.Emit(OpCodes.Ldloca, body.Variables.Count - 1); // &buffers
                }
                else if (difference == 1)
                {
                    // Convert unsized out-array/reference to return value, for example:
                    // void GetBoolean(GetPName pname, out bool data) -> bool GetBoolean(GetPName pname)
                    // {
                    //   bool result;
                    //   GetBooleanv(pname, &result);
                    //   return result;
                    // }
                    body.Variables.Add(new VariableDefinition(wrapper.ReturnType));
                    EmitParameters(wrapper, body, il);
                    il.Emit(OpCodes.Ldloca, body.Variables.Count - 1);
                }
                else
                {
                    Console.Error.WriteLine("Unknown wrapper type for ({0})", native.Name);
                }
            }
            else
            {
                if (difference == 1)
                {
                    // Convert in-array/reference to single element, for example:
                    // void DeleteTextures(int n, ref int textures) -> void DeleteTexture(int texture)
                    // {
                    //   const int n = 1;
                    //   calli DeleteTextures(n, &textures);
                    // }
                    il.Emit(OpCodes.Ldc_I4, 1); // const int n = 1
                    il.Emit(OpCodes.Ldarga, wrapper.Parameters.Last()); // &textures
                }
                else
                {
                    Console.Error.WriteLine("Unknown wrapper type for ({0})", native.Name);
                }
            }
        }

        static int EmitParameters(MethodDefinition method, MethodBody body, ILProcessor il)
        {
            int i;
            for (i = 0; i < method.Parameters.Count; i++)
            {
                var parameter = method.Parameters[i];
                var p = method.Module.Import(method.Parameters[i].ParameterType);
                il.Emit(OpCodes.Ldarg, i);

                if (p.Name == "StringBuilder")
                {
                    EmitStringBuilderParameter(method, parameter, body, il);
                }
                else if (p.Name == "String" && !p.IsArray)
                {
                    EmitStringParameter(method, parameter, body, il);
                }
                else if (p.IsByReference)
                {
                    body.Variables.Add(new VariableDefinition(new PinnedType(p)));
                    var index = body.Variables.Count - 1;
                    il.Emit(OpCodes.Stloc, index);
                    il.Emit(OpCodes.Ldloc, index);
                    il.Emit(OpCodes.Conv_I);
                }
                else if (p.IsArray)
                {
                    if (p.Name != method.Module.Import(typeof(string[])).Name)
                    {
                        // .Net treats 1d arrays differently than higher rank arrays.
                        // 1d arrays are directly supported by instructions such as ldlen and ldelema.
                        // Higher rank arrays must be accessed through System.Array methods such as get_Length.
                        // 1d array:
                        //    check array is not null
                        //    check ldlen array > 0
                        //    ldc.i4.0
                        //    ldelema
                        // 2d array:
                        //    check array is not null
                        //    check array.get_Length() > 0
                        //    ldc.i4.0
                        //    ldc.i4.0
                        //    call instance T& T[0..., 0...]::Address(int32, int32)
                        // Mono treats everything as a 1d array.
                        // Interestingly, the .Net approach works on both Mono and .Net.
                        // The Mono approach fails when using high-rank arrays on .Net.
                        // We should report a bug to http://bugzilla.xamarin.com

                        // Pin the array and pass the address
                        // of its first element.
                        var array = (ArrayType)p;
                        var element_type = p.GetElementType();
                        body.Variables.Add(new VariableDefinition(new PinnedType(new ByReferenceType(element_type))));
                        int pinned_index = body.Variables.Count - 1;

                        var empty = il.Create(OpCodes.Ldc_I4, 0);
                        var pin = il.Create(OpCodes.Ldarg, i);
                        var end = il.Create(OpCodes.Stloc, pinned_index);

                        // if (array == null) goto empty
                        il.Emit(OpCodes.Brfalse, empty);

                        // else if (array.Length != 0) goto pin
                        il.Emit(OpCodes.Ldarg, i);
                        if (array.Rank == 1)
                        {
                            il.Emit(OpCodes.Ldlen);
                            il.Emit(OpCodes.Conv_I4);
                        }
                        else
                        {
                            var get_length = method.Module.Import(
                                mscorlib.MainModule.GetType("System.Array").Methods.First(m => m.Name == "get_Length"));
                            il.Emit(OpCodes.Callvirt, get_length);
                        }
                        il.Emit(OpCodes.Brtrue, pin);

                        // empty: IntPtr ptr = IntPtr.Zero
                        il.Append(empty);
                        il.Emit(OpCodes.Conv_U);
                        il.Emit(OpCodes.Br, end);

                        // pin: &array[0]
                        il.Append(pin);
                        if (array.Rank == 1)
                        {
                            // 1d array (vector), address is taken by ldelema
                            il.Emit(OpCodes.Ldc_I4, 0);
                            il.Emit(OpCodes.Ldelema, element_type);
                        }
                        else
                        {
                            // 2d-3d array, address must be taken as follows:
                            // call instance T& T[0..., 0..., 0...]::Address(int, int, int)
                            ByReferenceType t_ref = array.ElementType.MakeByReferenceType();
                            MethodReference get_address = new MethodReference("Address", t_ref, array);
                            for (int r = 0; r < array.Rank; r++)
                            {
                                get_address.Parameters.Add(new ParameterDefinition(TypeInt32));
                            }
                            get_address.HasThis = true;

                            // emit the get_address call
                            for (int r = 0; r < array.Rank; r++)
                            {
                                il.Emit(OpCodes.Ldc_I4, 0);
                            }
                            il.Emit(OpCodes.Call, get_address);
                        }

                        // end: fixed (IntPtr ptr = &array[0])
                        il.Append(end);
                        il.Emit(OpCodes.Ldloc, pinned_index);
                        il.Emit(OpCodes.Conv_I);
                    }
                    else
                    {
                        EmitStringArrayParameter(method, parameter, body, il);
                    }
                }
            }
            return i;
        }

        static void EmitEntryPoint(FieldDefinition entry_points, ILProcessor il, int slot)
        {
            il.Emit(OpCodes.Ldsfld, entry_points);
            il.Emit(OpCodes.Ldc_I4, slot);
            il.Emit(OpCodes.Ldelem_I);
        }

        static void EmitCalli(ILProcessor il, MethodReference reference)
        {
            var signature = new CallSite(reference.ReturnType)
            {
                CallingConvention = MethodCallingConvention.StdCall,
            };

            foreach (var p in reference.Parameters)
            {
                signature.Parameters.Add(p);
            }

            // Since the last parameter is always the entry point address,
            // we do not need any special preparation before emiting calli.
            il.Emit(OpCodes.Calli, signature);
        }

        static void EmitCall(ILProcessor il, MethodReference reference)
        {
            il.Emit(OpCodes.Call, reference);
        }
    }
}
