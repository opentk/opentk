using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class Overloader
    {
        private readonly IOverloader[] _overloaders = {
            new EnumOverloader(),
            new StringOverloader(),
            new SpanOverloader(),
            new IntPtrOverloader(),
            new RefOverloader() };
        private readonly Specification _spec;
        private readonly HashSet<string> _overloadedCommandNames = new HashSet<string>();

        private const string ReturnValueName = "returnValue";
        private class CallLayer : ILayer
        {
            private readonly OverloadContext _context;

            public CallLayer(OverloadContext context)
            {
                _context = context;
            }

            public ILayer? NestedLayer => null;

            public void WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                if (_context.Method.ReturnType.Name != "void")
                {
                    writer.Write($"{ReturnValueName} = ");
                }
                writer.Write(methodName);
                writer.Write('(');
                for (int i = 0; i < args.Length; i++)
                {
                    writer.Write(args[i].Name);
                    if (i != args.Length - 1)
                    {
                        writer.Write(", ");
                    }
                }
                writer.WriteLine(");");
            }
        }
        private class ReturnVariableLayer : ILayer
        {
            private readonly OverloadContext _context;

            public ReturnVariableLayer(OverloadContext context, ILayer nestedLayer)
            {
                _context = context;
                NestedLayer = nestedLayer;
            }
            public ILayer? NestedLayer { get; }

            public void WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                bool hasReturnValue = _context.Method.ReturnType.Name != "void";
                if (hasReturnValue)
                {
                    writer.WriteLine($"{_context.Method.ReturnType.Name} {ReturnValueName};");
                }
                NestedLayer.WriteLayer(writer, methodName, args);
                if (hasReturnValue)
                {
                    writer.WriteLine($"return {ReturnValueName};");
                }
            }
        }

        public Overloader(Specification specification)
        {
            _spec = specification;
        }

        public void Overload()
        {
            foreach (var (apiName, api) in _spec.Apis)
            {
                foreach (var feature in api.Features)
                {
                    Overload(feature);
                }

                foreach(var (vendorName, extensions) in api.Extensions)
                {
                    foreach (var extension in extensions)
                    {
                        Overload(extension);
                    }
                }
            }
        }
        private void Overload(CommandEnumCollection commandCollection)
        {
            bool isFeatureCommand = commandCollection is Feature;
            foreach (var (commandName, c) in commandCollection.Commands)
            {
                if (!_overloadedCommandNames.Contains(commandName))
                {
                    _overloadedCommandNames.Add(commandName);
                    Overload(c, isFeatureCommand);
                }
            }
        }

        private void Overload(Command command, bool isFeatureCommand)
        {
            var method = command.Method;
            var context = new OverloadContext(command);
            ILayer currentLayer = new CallLayer(context);

            bool isValidOverload = false;
            bool overloadHappened;
            do
            {
                overloadHappened = false;
                for (int i = 0; i < context.Parameters.Length; i++)
                {
                    if (context.Parameters[i] == null)
                    {
                        continue;
                    }
                    foreach (var overloader in _overloaders)
                    {
                        if (overloader.TryOverloadParameter(context, ref currentLayer, i))
                        {
                            overloadHappened = true;
                            isValidOverload = true;
                            break;
                        }
                    }
                }
            } while (overloadHappened);

            if (!isValidOverload)
            {
                return;
            }

            currentLayer = new ReturnVariableLayer(context, currentLayer);

            CreateOverload(command, context, currentLayer);

            if (isFeatureCommand)
            {
                if (TryCreateGroupedParameters(context))
                {
                    CreateOverload(command, context, currentLayer);
                }
            }
        }

        private static void CreateOverload(Command command, OverloadContext context, ILayer currentLayer)
        {
            var method = command.Method;
            var args = context.Parameters.Zip(method.Parameters, (contextParam, methodParam) => new Argument(contextParam ?? methodParam)).ToArray();
            Action<IndentedTextWriter, string> bodyWriter = (writer, commandName) =>
            {
                currentLayer.WriteLayer(writer, commandName, args.ToArray());
            };
            command.Overloads.Add(new Overload(method.ReturnType, bodyWriter, context.TypeParameterCount, context.Parameters.Where(x => x != null).OfType<Parameter>().ToArray()));
        }

        private static bool TryCreateGroupedParameters(OverloadContext context)
        {
            bool hasGroupedEnum = false;
            for (int i = 0; i < context.Parameters.Length; i++)
            {
                var parameter = context.Parameters[i];
                if (parameter != null && parameter.Type.Group != null && parameter.Type.OriginalTypeName.Contains("GLenum"))
                {
                    hasGroupedEnum = true;
                    var type = parameter.Type;
                    context.Parameters[i] = new Parameter(new PType(type.Name.Replace("All", type.Group), type.OriginalTypeName,
                        type.Modifier, type.Group, type.Length), parameter.Name);
                }
            }
            return hasGroupedEnum;
        }
    }

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
