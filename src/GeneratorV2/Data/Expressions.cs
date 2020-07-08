using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GeneratorV2.Data
{
    public interface IExpression
    {

    }

    public class LazyEvaluatedExpression : IExpression
    {
        public LazyEvaluatedExpression(string expression)
        {
            Expression = expression;
        }

        public string Expression { get; }
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
        public IExpression?[] Parameters { get; }

        public CompSize(IExpression?[] parameters)
        {
            Parameters = parameters;
        }
    }

    public class BinaryOperation : IExpression
    {
        public IExpression Left { get; }
        public char Operator { get; }
        public IExpression Right { get; }

        public BinaryOperation(IExpression left, char op, IExpression right)
        {
            Left = left;
            Operator = op;
            Right = right;
        }
    }

    public class ParameterReference : IExpression
    {
        public int ParameterIndex { get; }
        public Parameter Parameter { get; }

        public ParameterReference(int parameterIndex, Parameter parameter)
        {
            ParameterIndex = parameterIndex;
            Parameter = parameter;
        }
    }
}
