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
        Modulo,
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
