using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GeneratorV2.Data
{
    public interface IExpression
    {

    }

    public class Constant : IExpression
    {
        public int Value { get; }

        public Constant(int value)
        {
            Value = value;
        }
    }

    public class CompSize : IExpression
    {
        // FIXME: These are all probably ParameterReference...
        public IExpression[] Parameters { get; }

        public CompSize(IExpression[] parameters)
        {
            Parameters = parameters;
        }
    }

    public enum BinaryOperator
    {
        Invalid,
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }

    public class BinaryOperation : IExpression
    {
        public IExpression Left { get; }
        public BinaryOperator Operator { get; }
        public IExpression Right { get; }

        public BinaryOperation(IExpression left, BinaryOperator op, IExpression right)
        {
            Left = left;
            Operator = op;
            Right = right;
        }

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

    public class ParameterReference : IExpression
    {
        public string ParameterName { get; }

        public ParameterReference(string parameter)
        {
            ParameterName = parameter;
        }
    }
}
