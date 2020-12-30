using GeneratorV2.Data;
using GeneratorV2.Writing2;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class OverloadContext { }

    public interface IOverloader
    {
        bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex);
    }

    /*
    public class Overloader
    {
        static readonly IOverloader[] _overloaders = {
            new EnumOverloader(),
            new SyncOverloader(),
            new StringOverloader(),
            new JaggedSpanOverloader(),
            new SpanOverloader(),
            new StringSpanOverloader(),
            new IntPtrOverloader(),
            new RefOverloader(),
            new VectorOverloader() };

        static readonly IOverloader[] _returnOverloaders =
        {
            new IntPtrReturnOverloader(),
            new ReturnStringOverloader(),
            new ReturnSyncOverloader()
        };

        //private readonly HashSet<string> _overloadedCommandNames = new HashSet<string>();

        private const string ReturnValueName = "returnValue";
        private class CallLayer : ILayer
        {
            private readonly NativeFunction Function;

            public CallLayer(NativeFunction function)
            {
                Function = function;
            }

            public string Suffix { get; set; } = "";
            public ILayer? NestedLayer => null;

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                bool returnValue = Function.ReturnType is not CSVoid;
                if (returnValue)
                {
                    writer.Write($"{ReturnValueName} = ");
                }
                writer.Write(methodName + Suffix);
                writer.Write("(");
                for (int i = 0; i < args.Length; i++)
                {
                    writer.Write(args[i].Name);
                    if (i != args.Length - 1)
                    {
                        writer.Write(", ");
                    }
                }
                writer.WriteLine(");");
                return returnValue ? new Argument(Function.ReturnType.ToCSString(), ReturnValueName) : null;
            }
        }

        private class ReturnVariableLayer : ILayer
        {
            private readonly ICSType ReturnType;

            public ReturnVariableLayer(ICSType returnType, ILayer nestedLayer)
            {
                ReturnType = returnType;
                NestedLayer = nestedLayer;
            }
            public ILayer NestedLayer { get; }

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                bool hasReturnValue = ReturnType is not CSVoid;
                if (hasReturnValue)
                {
                    writer.WriteLine($"{ReturnType.ToCSString()} {ReturnValueName};");
                }

                var returnValue = NestedLayer.WriteLayer(writer, methodName, args);

                if (hasReturnValue)
                {
                    writer.WriteLine($"return {returnValue.Name};");
                }

                return returnValue;
            }
        }

        static void Overload(List<NativeFunction> functions)
        {
            foreach (var function in functions)
            {
                Overload(function);
            }
        }

        static void Overload(NativeFunction function)
        {
            //var context = new OverloadContext(function);
            var callLayer = new CallLayer(function);
            ILayer currentLayer = callLayer;

            bool isValidOverload = false;
            bool overloadHappened;
            do
            {
                overloadHappened = false;
                for (int i = 0; i < function.Parameters.Count; i++)
                {
                    if (function.Parameters[i] == null)
                    {
                        continue;
                    }
                    foreach (var overloader in _overloaders)
                    {
                        if (overloader.TryOverloadParameter(function, ref currentLayer, i))
                        {
                            overloadHappened = true;
                            isValidOverload = true;
                            break;
                        }
                    }
                }
            } while (overloadHappened);

            do
            {
                overloadHappened = false;
                foreach (var overloader in _returnOverloaders)
                {
                    if (overloader.TryOverloadParameter(function, ref currentLayer, -1))
                    {
                        if (!isValidOverload)
                        {
                            callLayer.Suffix = "Raw";
                            //method.Suffix = "Raw";
                            isValidOverload = true;
                        }
                    }
                }
            } while (overloadHappened);

            if (!isValidOverload)
            {
                return;
            }

            currentLayer = new ReturnVariableLayer(function.ReturnType, currentLayer);

            CreateOverload(function, context, currentLayer);

            if (isFeatureCommand)
            {
                if (TryCreateGroupedParameters(context))
                {
                    CreateOverload(function, context, currentLayer);
                }
            }
        }

        private static Overload CreateOverload(Command2 command, OverloadContext context, ILayer currentLayer)
        {
            /*
            var method = command.Method;
            var args = context.Parameters.Zip(method.Parameters, (contextParam, methodParam) => new Argument(contextParam ?? methodParam)).ToArray();
            void bodyWriter(IndentedTextWriter writer, string commandName)
            {
                currentLayer.WriteLayer(writer, commandName, args.ToArray());
            }
            command.Overloads.Add(new Overload(context.ReturnType, bodyWriter, context.TypeParameterCount, context.Parameters.Where(x => x != null).OfType<Parameter>().ToArray()));
            *
        }
    }*/

    //public extern unsafe void Test(int** array, int count, uint enm);
    //void Test(Span<int>* p1, SomeEnum enm)
    //{
    //    var count = p1.Length;
    //    var p2 = (uint)enm;
    //    fixed(int* ptr = &p1.GetPinnableReference())
    //    {
    //        Test(ptr, count, p2);
    //    }
    //}
    //void Test(int* array, int count, uint enm)
    //{
    //    var count = p1.Length;
    //    fixed(int* array = &p1.GetPinnableReference())
    //    {
    //        Test(array, count, enm);
    //    }
    //}

    //public unsafe void Test(Span<int> p1, SomeEnum p2)
    //{
    //    var count = p1.Length;
    //    fixed(int* array = &p1.GetPinnableReference())
    //    {
    //        var enm = (uint)p2;
    //        Test(array, count, enm);
    //    }
    //}
}
