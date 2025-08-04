using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorBase
{
    public record Expression
    {
        // FIXME: Clean up this mess. We assume a lot of things we maybe dont wanna assume?
        // Can all lengths even be inverted and what should happen if they cant?
        // For now this works, but it might break later. 2021-06-23.
        public static string? InvertExpressionAndGetReferencedName(Expression expr, out Func<string, string> inverseExpression)
        {
            switch (expr)
            {
                case ConstantExpression c:
                    inverseExpression = s => c.Value.ToString();
                    return null;
                case ParameterReferenceExpression pr:
                    inverseExpression = s => $"{s}.Length";
                    return pr.ParameterName;
                case BinaryOperationExpression bo:
                    // FIXME: We don't want to assume that the left expression contains the
                    // parameter name, but this is true for gl.xml 2020-12-30
                    string? reference = InvertExpressionAndGetReferencedName(bo.Left, out var leftExpr);
                    InvertExpressionAndGetReferencedName(bo.Right, out var rightExpr);
                    var invOp = BinaryOperationExpression.Invert(bo.Operator);
                    inverseExpression = s => $"{leftExpr(s)} {BinaryOperationExpression.GetOperationChar(invOp)} {rightExpr(s)}";
                    return reference;
                default:
                    inverseExpression = s => "";
                    return null;
            }
        }
    }

    public record ConstantExpression(int Value) : Expression;

    public record CompSizeExpression(Expression[] Parameters) : Expression;

    public enum BinaryOperator
    {
        Invalid,
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }

    public record BinaryOperationExpression(
        Expression Left,
        BinaryOperator Operator,
        Expression Right) : Expression
    {
        public static BinaryOperator Invert(BinaryOperator @operator) => @operator switch
        {
            BinaryOperator.Addition => BinaryOperator.Subtraction,
            BinaryOperator.Subtraction => BinaryOperator.Addition,
            BinaryOperator.Multiplication => BinaryOperator.Division,
            BinaryOperator.Division => BinaryOperator.Multiplication,
            _ => throw new Exception("Invalid binary operator, we can't invert it."),
        };

        public static char GetOperationChar(BinaryOperator @operator) => @operator switch
        {
            BinaryOperator.Addition => '+',
            BinaryOperator.Subtraction => '-',
            BinaryOperator.Multiplication => '*',
            BinaryOperator.Division => '/',
            _ => throw new Exception("Invalid binary operator, there is no char associated."),
        };

        public bool TryDecomposeIntoParameterRefAndConstant([NotNullWhen(true)] out ConstantExpression? constant, [NotNullWhen(true)] out ParameterReferenceExpression? reference)
        {
            if (Left is ParameterReferenceExpression leftRef && Right is ConstantExpression rightConst)
            {
                reference = leftRef;
                constant = rightConst;
                return true;
            }
            else if (Right is ParameterReferenceExpression rightRef && Left is ConstantExpression leftConst)
            {
                reference = rightRef;
                constant = leftConst;
                return true;
            }
            else
            {
                constant = default;
                reference = default;
                return false;
            }
        }
    }

    public record ParameterReferenceExpression(string ParameterName) : Expression;

}
