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
            foreach (var module in assembly.Modules)
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

            // Save rewritten assembly
            assembly.Write(file, write_params);
        }

        void Rewrite(TypeDefinition type)
        {
            foreach (var method in type.Methods)
            {
                if (method.HasBody)
                {
                    ProcessMethodBody(method.Body);
                }
            }
        }

        // Search the instruction stream for calls
        // to methods we need to rewrite.
        static void ProcessMethodBody(MethodBody body)
        {
            var instructions = body.Instructions;
            var il = body.GetILProcessor();

            Instruction inst1 = instructions[0];
            Instruction inst2 = instructions[0];

            for (int i = 1; i < instructions.Count; i++)
            {
                var inst = instructions[i];
                if ((inst.OpCode == OpCodes.Call || inst.OpCode == OpCodes.Callvirt) &&
                    inst.Operand is MethodReference)
                {
                    var reference = inst.Operand as MethodReference;

                    // Make sure we are rewriting OpenTK.InteropHelper methods
                    // and not random methods that happen to have similar names.
                    if (reference.DeclaringType.Name == "InteropHelper")
                    {
                        switch (reference.Name)
                        {
                            case "Call":
                            case "CallReturn":
                                RewriteCall(il, inst, reference);
                                break;

                            case "Pin":
                                RewritePin(il, inst, reference);
                                break;
                        }
                    }
                }
            }
        }

        static void RewriteCall(ILProcessor il, Instruction inst, MethodReference reference)
        {
            var signature = new CallSite(reference.ReturnType)
            {
                CallingConvention = MethodCallingConvention.Default,
            };

            if (reference is GenericInstanceMethod)
            {
                var greference = reference as GenericInstanceMethod;

                if (reference.Name.EndsWith("Return"))
                {
                    // "TRet CallReturn<TRet, T0, ...>(T0 arg0, ..., IntPtr address)"
                    // The first generic parameter is the return type
                    // The rest are function parameters types
                    // The entry point address is not in the generic arg list
                    signature.ReturnType = greference.GenericArguments.First();
                    foreach (var ptype in greference.GenericArguments.Skip(1))
                    {
                        signature.Parameters.Add(new ParameterDefinition(ptype));
                    }
                }
                else
                {
                    // "void Call<T0, ...>(T0 arg0, ..., IntPtr address)"
                    // The generic arguments define the function parameters
                    // The entry point address is not in the generic arg list
                    foreach (var ptype in greference.GenericArguments)
                    {
                        signature.Parameters.Add(new ParameterDefinition(ptype));
                    }
                }
            }
            else
            {
                // Call(IntPtr address)
                // The last parameter is the function address of this entry point.
                // It is placed at the top of the stack (first parameter of calli)
                // but is not actually part of the unmanaged signature, so we must
                // not add it to the signature parameters.
                foreach (var p in reference.Parameters.Take(reference.Parameters.Count - 1))
                {
                    signature.Parameters.Add(p);
                }
            }

            // Since the last parameter is always the entry point address,
            // we do not need any special preparation before emiting calli.
            var call = il.Create(OpCodes.Calli, signature);
            il.Replace(inst, call);
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
