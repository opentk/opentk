using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GeneratorV2.Data
{
    public record Expression;

    public record Constant(int Value) : Expression;

    public record CompSize(Expression[] Parameters) : Expression;

    public enum BinaryOperator
    {
        Invalid,
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }

    public record BinaryOperation(
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
    }

    public record ParameterReference(string ParameterName) : Expression;
}
