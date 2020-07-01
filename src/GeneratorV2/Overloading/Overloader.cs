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
        private readonly IOverloader[] _overloaders = { new EnumOverloader() };
        private readonly Specification _spec;
        private readonly HashSet<string> _overloadedCommandNames = new HashSet<string>();

        private class CallLayer : ILayer
        {
            private readonly OverloadContext _context;

            public CallLayer(OverloadContext context)
            {
                _context = context;
            }

            public void WriteLayer(IndentedTextWriter writer, string methodName)
            {
                if (_context.Method.ReturnType.Name != "void")
                {
                    writer.Write("return ");
                }
                writer.Write(methodName);
                writer.Write('(');
                var args = _context.Arguments;
                for (int i = 0; i < args.Count; i++)
                {
                    writer.Write(args[i]);
                    if (i != args.Count - 1)
                    {
                        writer.Write(", ");
                    }
                }
                writer.WriteLine(");");
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
                int i = 0;
                while (i < context.Parameters.Count) //Could be for loop.
                {
                    foreach (var overloader in _overloaders)
                    {
                        if (overloader.TryOverloadParameter(context, ref currentLayer, i))
                        {
                            overloadHappened = true;
                            isValidOverload = true;
                            break;
                        }
                    }
                    ++i;
                }
            } while (overloadHappened);

            if (!isValidOverload)
            {
                return;
            }

            Action<IndentedTextWriter, string> bodyWriter = (writer, commandName) =>
            {
                currentLayer.WriteLayer(writer, commandName);
            };
            command.Overloads.Add(new Overload(method.ReturnType, bodyWriter, context.Parameters.ToArray()));
            if (isFeatureCommand)
            {
                CreateGroupedOverload(command, method, context, bodyWriter);
            }
        }

        private static void CreateGroupedOverload(Command command, Method method, OverloadContext context, Action<IndentedTextWriter, string> bodyWriter)
        {
            bool hasGroupedEnum = false;
            for (int i = 0; i < context.Parameters.Count; i++)
            {
                var parameter = context.Parameters[i];
                if (parameter.Type.Group != null && parameter.Type.OriginalTypeName.Contains("GLenum"))
                {
                    hasGroupedEnum = true;
                    var type = parameter.Type;
                    context.Parameters[i] = new Parameter(new PType(type.Name.Replace("All", type.Group), type.OriginalTypeName,
                        type.Modifier, type.Group, type.Length), parameter.Name);
                }
            }
            if (hasGroupedEnum)
            {
                command.Overloads.Add(new Overload(method.ReturnType, bodyWriter, context.Parameters.ToArray()));
            }
        }
    }

    //public class SpanOverloader : IOverloader
    //{
    //    public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex)
    //    {
    //        throw new NotImplementedException();
    //        //var parameters = context.Parameters[paramIndex];

    //    }

    //    class SpanLayer : ILayer
    //    {

    //        private ILayer _nestedLayer;
    //        public SpanLayer(ILayer nestedLayer)
    //        {
    //            _nestedLayer = nestedLayer;
    //        }
    //        public void WriteLayer(IndentedTextWriter writer)
    //        {
    //            using (writer.Scope())
    //            {
    //                NestedLayer.WriteLayer(writer);
    //            }
    //        }
    //    }
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
