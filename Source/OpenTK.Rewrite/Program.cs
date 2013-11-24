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
                Console.WriteLine("Usage: rewrite [file1] [file2] ...");
                return;
            }

            var program = new Program();
            foreach (var file in args)
            {
                program.Rewrite(file);
            }
        }

        void Rewrite(string file)
        {
            var assembly = AssemblyDefinition.ReadAssembly(file);
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

            var fs = new FileStream("../../../OpenTK.snk", FileMode.Open);
            var keypair = new System.Reflection.StrongNameKeyPair(fs);
            fs.Close();
            assembly.Write(
                file,
                new WriterParameters
                {
                    StrongNameKeyPair = keypair
                });
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
                        }
                    }
                }
            }
        }

        static void RewriteCall(ILProcessor il, Instruction inst, MethodReference reference)
        {
            var signature = new CallSite(reference.ReturnType)
            {
                CallingConvention = MethodCallingConvention.StdCall,
            };
            if (reference is GenericInstanceMethod)
            {
                var greference = reference as GenericInstanceMethod;
                foreach (var ptype in greference.GenericArguments)
                {
                    var p = new ParameterDefinition(ptype);
                    signature.Parameters.Add(p);
                }
            }
            else
            {
                // The last parameter is the function address of this entry point.
                // It is placed at the top of the stack (first parameter of calli)
                // but is not actually part of the unmanaged signature, so we must
                // not add it to the signature parameters.
                foreach (var p in reference.Parameters.Take(reference.Parameters.Count - 1))
                {
                    signature.Parameters.Add(p);
                }
            }
            var call = il.Create(OpCodes.Calli, signature);
            il.Replace(inst, call);
        }
        
    }
}
