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
using System.Linq;
using CommandLine;
using Mono.Cecil;
using OpenTK.Rewrite.Methods;
using OpenTK.Rewrite.Methods.Processors;
using OpenTK.Rewrite.Types;

namespace OpenTK.Rewrite
{
    /// <summary>
    /// A commandline tool that replaces OpenTK.InteropHelper method instances with the correct IL instructions.
    /// </summary>
    internal class Program
    {
        private static RewriteOptions Options;

        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<RewriteOptions>(args)
                .WithParsed(result => Options = result)
                .WithNotParsed(errors => Environment.Exit(-1));

            try
            {
                var resolver = new DefaultAssemblyResolver();
                var rewriter = new AssemblyRewriter(resolver, CreateTypeRewriter);
                rewriter.RewriteAssembly(Options.TargetAssembly, Options.EnableDebugCalls, Options.UseDllImport);
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine("An error occurred:");
                Console.Error.WriteLine(exc);
            }
        }

        private static ITypeRewriter CreateTypeRewriter
        (
            AssemblyDefinition mscorlib,
            TypeDefinition bindingsBaseType,
            bool useDllImport
        )
        {
            var methodProcessors = new IMethodProcessor[]
            {
                new ParameterProcessor(mscorlib, bindingsBaseType),
                new NativeCallProcessor(useDllImport),
                new ReturnTypeProcessor(mscorlib),
            };

            if (Options.EnableDebugCalls)
            {
                methodProcessors = methodProcessors.Prepend(new DebugPrologueProcessor(mscorlib)).ToArray();
            }

            var methodRewriter = new MethodRewriter(methodProcessors);

            return new TypeRewriter(mscorlib, useDllImport, methodRewriter);
        }
    }
}
