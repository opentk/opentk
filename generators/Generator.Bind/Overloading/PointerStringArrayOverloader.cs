using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generator.Common.Builders;
using Generator.Common.Functions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Generator.Bind.Overloading
{
    public class PointerStringArrayOverloader : IFunctionOverloader
    {
        public bool IsApplicable(Function function)
        {
            return function.ReturnType.Name == "char" &&
                   function.ReturnType.IndirectionLevels == 2;
        }
        
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            var newSignatureBuilder = new FunctionSignatureBuilder(function);
            var returnTypeAffected = function.ReturnType.IndirectionLevels >= 2 && function.ReturnType.Name == "char";
            var argsAffected = function.Parameters.Any(x => x.Type.Name == "char" && x.Type.IndirectionLevels >= 2);
            if (returnTypeAffected)
            {
                Console.WriteLine("Warning: Failed to overload function with expected string[] return type.");
                yield break;
                // TODO: We'll implement return type marshalling when it's required by the spec
                newSignatureBuilder.WithReturnType
                (
                    new TypeSignatureBuilder(function.ReturnType)
                        .WithName("string")
                        .WithIndirectionLevel(0)
                        .WithArrayDimensions(function.ReturnType.IndirectionLevels - 1)
                        .Build()
                );
            }

            if (argsAffected)
            {
                newSignatureBuilder.WithParameters
                (
                    function.Parameters.Select
                    (
                        x => x.Type.Name == "char" && x.Type.IndirectionLevels >= 2
                            ? new ParameterSignatureBuilder(x).WithType
                            (
                                new TypeSignatureBuilder(function.ReturnType).WithName("string")
                                    .WithIndirectionLevel(0)
                                    .WithArrayDimensions(function.ReturnType.IndirectionLevels - 1)
                                    .Build()
                            )
                            .Build()
                            : x
                    )
                    .ToList()
                );
            }

            if (returnTypeAffected && !argsAffected)
            {
                // the signatures only differ in return type! 
                newSignatureBuilder.WithName(function.Name + "AsArray");
            }

            var sig = newSignatureBuilder.Build();
            var sb = new StringBuilder();
            var paramsList = new List<string>();
            var freeList = new Dictionary<string, string>();
            if (argsAffected)
            {
                for (var index = 0; index < sig.Parameters.Count; index++)
                {
                    var arg = sig.Parameters[index];
                    if (arg.Type.Name == "string" && arg.Type.ArrayDimensions ==
                        function.Parameters[index].Type.IndirectionLevels - 1)
                    {
                        sb.AppendLine("var arg" + index + " = MarshalTk.MarshalStringArrayToPtr(" + arg.Name + ");");
                        paramsList.Add("(" + function.Parameters[index].Type + ")arg" + index);
                        freeList.Add("arg" + index, arg.Name);
                    }
                    else
                    {
                        paramsList.Add(arg.Name);
                    }
                }
            }

            if (returnTypeAffected)
            {
                sb.Append("var result = MarshalTk.PointerSpanToStringArray("); // TODO line 28
            }
            else if (sig.ReturnType.ToString() != "void")
            {
                sb.Append("var result = ");
            }

            sb.Append(function.Name + "(" + string.Join(", ", paramsList) + ")");
            sb.AppendLine(returnTypeAffected ? ");" : ";");
            foreach (var free in freeList)
            {
                sb.AppendLine("MarshalTk.FreeStringArrayPtr(" + free.Key + ", " + free.Value + ".Length);");
            }

            sb.AppendLine("return result;");
            yield return new Overload(sig, sb, true);
        }
    }
}
