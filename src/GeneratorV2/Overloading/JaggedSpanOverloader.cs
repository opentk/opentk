using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorV2.Overloading
{
    /*
    public class JaggedSpanOverloader : IOverloader
    {
        private class Layer : ILayer
        {
            private readonly ILayer _nestedLayer;
            private readonly int _argIndex;
            private readonly IExpression? _length;

            public Layer(ILayer nestedLayer, int argIndex, IExpression? length)
            {
                _nestedLayer = nestedLayer;
                _argIndex = argIndex;
                _length = length;
            }

            private string? ExpressionToString(IExpression? expr, Argument[] args, out int lenIdx)
            {
                lenIdx = -1;
                if (expr is ParameterReference pRef)
                {
                    var arg = args[_argIndex];
                    //lenIdx = pRef.ParameterIndex;
                    throw new Exception("!!!");
                    //args[pRef.ParameterIndex] = args[pRef.ParameterIndex].CloneWithName(args[_argIndex].Name);
                    return arg.Name + ".Length";
                }
                else if (expr is BinaryOperation binaryOperation)
                {
                    var left = ExpressionToString(binaryOperation.Left, args, out var leftLenIdx);
                    var right = ExpressionToString(binaryOperation.Right, args, out var rightLenIdx);
                    if (left == null || right == null)
                    {
                        lenIdx = -1;
                        return null;
                    }
                    if (leftLenIdx != -1 && rightLenIdx != -1 && leftLenIdx != rightLenIdx)
                    {
                        Logger.Warning($"Ambigous argument indices: {leftLenIdx} != {rightLenIdx}");
                    }

                    lenIdx = Math.Max(leftLenIdx, rightLenIdx);
                    if (binaryOperation.Operator != BinaryOperator.Multiplication)
                    {
                        Logger.Warning("Cannot compute non multiplication for length");
                    }

                    return (leftLenIdx == lenIdx) ? $"{left} / {right}" : $"{right} / {left}";
                }
                else if(expr is Constant constant)
                {
                    return constant.Value.ToString();
                }
                return null;
            }

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var spanArg = args[_argIndex];

                int sInd = spanArg.Type.IndexOf('<');
                int eInd = spanArg.Type.LastIndexOf('>');

                var newType = spanArg.Type.Substring(sInd + 1, eInd - sInd - 1) + "**";

                var lengthExpression = ExpressionToString(_length, args, out var lenIndex);
                args[_argIndex] = spanArg.Clone(newType, $"{spanArg.Name}_vptr");
                if (lengthExpression != null && lenIndex != -1)
                {
                    var lenArg = args[lenIndex];
                    writer.WriteLine($"{lenArg.Type} {lenArg.Name} = ({lenArg.Type})({lengthExpression});");
                }
                writer.WriteLine($"var {spanArg.Name}_vptr = {(newType.StartsWith("T") ? "(void**)" : string.Empty)}(({newType}){spanArg.Name});");
                return _nestedLayer.WriteLayer(writer, methodName, args);
            }
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex)
        {
            var parameter = context.Parameters[paramIndex];
            if (parameter == null)
            {
                return false;
            }
            var type = parameter.Type;
            var ptrLoc1 = type.Name.IndexOf('*');
            var ptrLoc2 = type.Name.IndexOf('*', ptrLoc1 + 1);
            if (type == null || type.Length == null || ptrLoc1 == -1 || ptrLoc2 == -1 || type.Length is Constant || type.OriginalTypeName.Contains("GLchar"))
            {
                return false;
            }

            //TODO: code deduplication
            var references = GetAllReferences(type.Length);
            var useParameter = true;
            foreach (var reference in references)
            {
                int otherReferences = 0;
                foreach (var p in context.Method.Parameters)
                {
                    if (p == parameter || p == null || p.Type.Length == null)
                    {
                        continue;
                    }
                    var refs = GetAllReferences(p.Type.Length);
                    throw new Exception("!!!");
                    //otherReferences += refs.Count(r => r.ParameterIndex == reference.ParameterIndex);
                }
                if (otherReferences == 0)
                {
                    throw new Exception("!!!");
                    //context.Parameters[reference.ParameterIndex] = null;
                    useParameter = false;
                }
            }

            var elementType = type.Name.Remove(ptrLoc2, 1).Remove(ptrLoc1, 1).Trim();
            if (elementType == "void")
            {
                elementType = $"T{++context.TypeParameterCount}";
            }
            var typeName = $"JaggedSpan<{elementType}>";

            context.Parameters[paramIndex] = new Parameter(new PType(typeName, type.OriginalTypeName,
                type.Modifier, type.Group, null), parameter.Name);

            topLayer = new Layer(topLayer, paramIndex, useParameter ? null : type.Length);
            return true;
        }

        //TODO: code deduplication
        private List<ParameterReference> GetAllReferences(IExpression expression, List<ParameterReference>? references = null)
        {
            if (references == null)
            {
                references = new List<ParameterReference>();
            }

            if (expression is BinaryOperation binaryOperation)
            {
                _ = GetAllReferences(binaryOperation.Left, references);
                _ = GetAllReferences(binaryOperation.Right, references);
            }
            //else if (expression is CompSize compSize)
            //{
            //    foreach (var e in compSize.Parameters)
            //    {
            //        _ = GetAllReferences(e, references);
            //    }
            //}
            else if (expression is ParameterReference pRef)
            {
                references.Add(pRef);
            }
            return references;
        }
    }
    */
}
