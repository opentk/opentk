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
                Console.WriteLine("Usage: rewrite [file.dll] [file.snk]");
                return;
            }

            var program = new Program();
            var file = args[0];
            var key = args.Length >= 2 ? args[1] : null;
            program.Rewrite(file, key);
        }

        // mscorlib types
        static AssemblyDefinition mscorlib;
        static TypeDefinition TypeMarshal;
        static TypeDefinition TypeStringArray;
        static TypeDefinition TypeStringBuilder;
        static TypeDefinition TypeVoid;
        static TypeDefinition TypeIntPtr;

        // OpenTK.BindingsBase
        static TypeDefinition TypeBindingsBase;

        void Rewrite(string file, string keyfile)
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

                TypeBindingsBase = assembly.Modules.Select(m => m.GetType("OpenTK.BindingsBase")).First();

                foreach (var module in assembly.Modules)
                {
                    foreach (var type in module.Types)
                    {
                        Rewrite(type);
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

        void Rewrite(TypeDefinition type)
        {
            var entry_points = type.Fields.FirstOrDefault(f => f.Name == "EntryPoints");
            if (entry_points != null)
            {
                // Build list of entry point signatures (one per entry point) 
                var entry_signatures = new List<MethodDefinition>();
                entry_signatures.AddRange(type.Methods
                    .Where(t => t.CustomAttributes.Any(a => a.AttributeType.Name == "SlotAttribute")));

                Rewrite(type, entry_points, entry_signatures);

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

        void Rewrite(TypeDefinition type, FieldDefinition entry_points,
            List<MethodDefinition> entry_signatures)
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
                    var signature = entry_signatures.First(s => s.Name == signature_name);
                    var slot = (int)signature.CustomAttributes
                        .First(a => a.AttributeType.Name == "SlotAttribute")
                        .ConstructorArguments[0].Value;

                    ProcessMethod(wrapper, signature, slot, entry_points);
                }
            }

            RemoveSupportingAttributes(type);

            if (type.NestedTypes.Count > 0)
            {
                foreach (var nested_type in type.NestedTypes)
                {
                    Rewrite(nested_type, entry_points, entry_signatures);
                }
            }
        }

        void RemoveNativeSignatures(TypeDefinition type, List<MethodDefinition> methods)
        {
            while (methods.Count > 0)
            {
                type.Methods.Remove(methods.Last());
                methods.RemoveAt(methods.Count - 1);
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
        static void ProcessMethod(MethodDefinition wrapper, MethodDefinition native, int slot, FieldDefinition entry_points)
        {
            var body = wrapper.Body;
            var il = body.GetILProcessor();
            var instructions = body.Instructions;
            instructions.Clear();

            // Declare pinned variables for every reference and array parameter
            // and push each parameter on the stack

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

            // push the entry point address on the stack
            EmitEntryPoint(entry_points, il, slot);

            // issue calli
            EmitCall(il, native);

            if (wrapper.ReturnType.Name != "Void")
            {
                EmitReturnTypeWrapper(wrapper, native, body, il);
            }
            if (wrapper.Parameters.Any(p => p.ParameterType.Name == "StringBuilder"))
            {
                EmitStringBuilderEpilogue(wrapper, native, body, il);
            }
            if (wrapper.Parameters.Any(p => p.ParameterType.Name == "String" && p.ParameterType.IsArray))
            {
                EmitStringArrayEpilogue(wrapper, body, il);
            }
            if (wrapper.Parameters.Any(p => p.ParameterType.Name == "String" && !p.ParameterType.IsArray))
            {
                EmitStringEpilogue(wrapper, body, il);
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

        static void EmitStringBuilderEpilogue(MethodDefinition wrapper, MethodDefinition native, MethodBody body, ILProcessor il)
        {
            for (int i = 0; i < wrapper.Parameters.Count; i++)
            {
                var p = wrapper.Parameters[i].ParameterType;
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

                    var variable_name = p.Name + " _sb_ptr";
                    var v = body.Variables.First(m => m.Name == variable_name);
                    il.Emit(OpCodes.Ldloc, v.Index);
                    il.Emit(OpCodes.Ldarg, i);
                    il.Emit(OpCodes.Call, ptr_to_sb);

                    block.TryEnd = body.Instructions.Last();
                    block.HandlerStart = body.Instructions.Last();

                    il.Emit(OpCodes.Ldloc, v.Index);
                    il.Emit(OpCodes.Call, free_hglobal);

                    block.HandlerEnd = body.Instructions.Last();
                }
            }
        }

        static void EmitStringParameter(MethodDefinition wrapper, TypeReference p, MethodBody body, ILProcessor il)
        {
            // string marshaling:
            // IntPtr ptr = Marshal.StringToHGlobalAnsi(str);
            // try { calli }
            // finally { Marshal.FreeHGlobal(ptr); }
            var marshal_str_to_ptr = wrapper.Module.Import(TypeMarshal.Methods.First(m => m.Name == "StringToHGlobalAnsi"));

            // IntPtr ptr;
            var variable_name = p.Name + "_string_ptr";
            body.Variables.Add(new VariableDefinition(variable_name, TypeIntPtr));
            int index = body.Variables.Count - 1;

            // ptr = Marshal.StringToHGlobalAnsi(str);
            il.Emit(OpCodes.Call, marshal_str_to_ptr);
            il.Emit(OpCodes.Stloc, index);
            il.Emit(OpCodes.Ldloc, index);

            // The finally block will be emitted in the function epilogue
        }

        static void EmitStringEpilogue(MethodDefinition wrapper, MethodBody body, ILProcessor il)
        {
            for (int i = 0; i < wrapper.Parameters.Count; i++)
            {
                var p = wrapper.Parameters[i].ParameterType;
                if (p.Name == "String" && !p.IsArray)
                {
                    var free = wrapper.Module.Import(TypeMarshal.Methods.First(m => m.Name == "FreeHGlobal"));

                    // Marshal.FreeHGlobal(ptr)
                    var variable_name = p.Name + "_string_ptr";
                    var v = body.Variables.First(m => m.Name == variable_name);
                    il.Emit(OpCodes.Ldloc, v.Index);
                    il.Emit(OpCodes.Call, free);
                }
            }
        }

        static void EmitStringArrayParameter(MethodDefinition wrapper, TypeReference p, MethodBody body, ILProcessor il)
        {
            // string[] masrhaling:
            // IntPtr ptr = MarshalStringArrayToPtr(strings);
            // try { calli }
            // finally { UnmarshalStringArray(ptr); }
            var marshal_str_array_to_ptr = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "MarshalStringArrayToPtr"));

            // IntPtr ptr;
            var variable_name = p.Name + " _string_array_ptr";
            body.Variables.Add(new VariableDefinition(variable_name, TypeIntPtr));
            int index = body.Variables.Count - 1;

            // ptr = MarshalStringArrayToPtr(strings);
            il.Emit(OpCodes.Call, marshal_str_array_to_ptr);
            il.Emit(OpCodes.Stloc, index);
            il.Emit(OpCodes.Ldloc, index);

            // The finally block will be emitted in the function epilogue
        }

        static void EmitStringArrayEpilogue(MethodDefinition wrapper, MethodBody body, ILProcessor il)
        {
            for (int i = 0; i < wrapper.Parameters.Count; i++)
            {
                var p = wrapper.Parameters[i].ParameterType;
                if (p.Name == "String" && p.IsArray)
                {
                    var free = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "FreeStringArrayPtr"));
                    var get_length = wrapper.Module.Import(TypeStringArray.Methods.First(m => m.Name == "get_Length"));

                    // FreeStringArrayPtr(string_array_ptr, string_array.Length)
                    var variable_name = p.Name + "_string_array_ptr";
                    var v = body.Variables.First(m => m.Name == variable_name);
                    il.Emit(OpCodes.Ldloc, v.Index);
                    il.Emit(OpCodes.Ldarg, i);
                    il.Emit(OpCodes.Callvirt, get_length);
                    il.Emit(OpCodes.Call, free);
                }
            }
        }

        private static void EmitConvenienceWrapper(MethodDefinition wrapper,
            MethodDefinition native, int difference, MethodBody body, ILProcessor il)
        {
            if (wrapper.Parameters.Count > 1)
            {
                EmitParameters(wrapper, body, il);
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
                var p = method.Module.Import(method.Parameters[i].ParameterType);
                il.Emit(OpCodes.Ldarg, i);

                if (p.Name == "StringBuilder")
                {
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
                    var variable_name = p.Name + " _sb_ptr";
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
                else if (p.Name == "String" && !p.IsArray)
                {
                    EmitStringParameter(method, p, body, il);
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
                        // Pin the array and pass the address
                        // of its first element.
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
                        il.Emit(OpCodes.Ldlen);
                        il.Emit(OpCodes.Conv_I4);
                        il.Emit(OpCodes.Brtrue, pin);

                        // empty: IntPtr ptr = IntPtr.Zero
                        il.Append(empty);
                        il.Emit(OpCodes.Conv_U);
                        il.Emit(OpCodes.Br, end);

                        // pin: &array[0]
                        il.Append(pin);
                        il.Emit(OpCodes.Ldc_I4, 0);
                        il.Emit(OpCodes.Ldelema, element_type);

                        // end: fixed (IntPtr ptr = &array[0])
                        il.Append(end);
                        il.Emit(OpCodes.Ldloc, pinned_index);
                        il.Emit(OpCodes.Conv_I);
                    }
                    else
                    {
                        EmitStringArrayParameter(method, p, body, il);
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

        static void EmitCall(ILProcessor il, MethodReference reference)
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
    }
}
