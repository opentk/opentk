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

        void Rewrite(string file, string keyfile)
        {
            // Specify assembly read and write parameters
            // We want to keep a valid symbols file (pdb or mdb)
            var read_params = new ReaderParameters();
            var write_params = new WriterParameters();
#if false // Disabled because symbols file is locked during AfterBuild
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
#endif

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
                    if (rewritten == null)
                    {
                        foreach (var reference in module.AssemblyReferences)
                        {
                            module.AssemblyResolver.Resolve(reference);
                        }

                        foreach (var type in module.Types)
                        {
                            Rewrite(type);
                        }
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
                foreach (var method in type.Methods)
                {
                    if (method.CustomAttributes.Any(a => a.AttributeType.Name == "SlotAttribute"))
                    {
                        ProcessMethod(method, entry_points);
                    }
                }
            }

            if (type.Name == "RewrittenAttribute")
            {
                var rewritten_constructor = type.GetConstructors().First();
                var rewritten = new CustomAttribute(rewritten_constructor, BitConverter.GetBytes(true));
                type.Module.Assembly.CustomAttributes.Add(rewritten);
            }
        }

        // Create body for method
        static void ProcessMethod(MethodDefinition method, FieldDefinition entry_points)
        {
            var nint = method.DeclaringType.Module.Import(typeof(IntPtr));
            var body = method.Body;
            var instructions = body.Instructions;
            var il = body.GetILProcessor();
            var slot_attribute = method.CustomAttributes
                .First(a => a.AttributeType.Name == "SlotAttribute");
            var slot = (int)slot_attribute.ConstructorArguments.First().Value;

            instructions.Clear();

            // Declare pinned variables for every reference and array parameter
            // and push each parameter on the stack
            EmitParameters(method, nint, body, il);

            // push the entry point address on the stack
            EmitEntryPoint(entry_points, il, slot);

            // issue calli
            EmitCall(il, method);

            // return
            il.Emit(OpCodes.Ret);

            body.OptimizeMacros();
        }

        static void EmitParameters(MethodDefinition method, TypeReference nint, MethodBody body, ILProcessor il)
        {
            for (int i = 0; i < method.Parameters.Count; i++)
            {
                var p = method.Parameters[i];
                il.Emit(OpCodes.Ldarg, i);

                if (p.ParameterType.IsArray || p.ParameterType.IsByReference)
                {
                    body.Variables.Add(new VariableDefinition(new PinnedType(nint)));
                    var index = body.Variables.Count - 1;
                    il.Emit(OpCodes.Stloc, index);
                    il.Emit(OpCodes.Ldloc, index);
                    //il.Emit(OpCodes.Conv_I);
                }
            }
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
                CallingConvention = MethodCallingConvention.Default,
            };

            foreach (var p in reference.Parameters)
            {
                signature.Parameters.Add(p);
            }

            // Since the last parameter is always the entry point address,
            // we do not need any special preparation before emiting calli.
            il.Emit(OpCodes.Calli, signature);
        }

        // IntPtr Pin<T>({ref} T{[];[,];[,,]} arg)
        // Pin the parameter and return an unmanaged pointer
        static void RewritePin(ILProcessor il, Instruction inst, MethodReference reference)
        {
            var greference = reference as GenericInstanceMethod;
            if (greference == null)
                throw new InvalidOperationException("reference must match generic method Pin<T>");

            var ptype = greference.GenericArguments.First();
        }
    }
}
