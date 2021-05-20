using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using GeneratorV2.Writing;

namespace GeneratorV2.Process.Overloaders
{
    internal class RefInsteadOfPointerOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            Parameter[] parameters = new Parameter[overload.InputParameters.Length];
            List<Parameter> original = new List<Parameter>();
            List<Parameter> changed = new List<Parameter>();
            NameTable nameTable = overload.NameTable.New();
            string[] genericTypes = overload.GenericTypes;
            for (int i = 0; i < overload.InputParameters.Length; i++)
            {
                Parameter parameter = overload.InputParameters[i];
                parameters[i] = parameter;

                if (parameter.Type is CSPointer pt)
                {
                    bool constant = pt.Constant;
                    BaseCSType baseType;
                    switch (pt.BaseType)
                    {
                        case CSVoid btVoid:
                            genericTypes = genericTypes.MakeCopyAndGrow(1);
                            genericTypes[^1] = $"T{genericTypes.Length}";
                            baseType = new CSGenericType(genericTypes[^1]);
                            constant |= btVoid.Constant;
                            break;
                        case CSType bt:
                            baseType = pt.BaseType;
                            constant |= bt.Constant;
                            break;
                        default:
                            continue;
                    }
                    // FIXME: When do we know it's an out ref type?
                    CSRef.Type refType = constant ? CSRef.Type.In : CSRef.Type.Ref;

                    // Rename the parameter
                    nameTable.Rename(parameter, $"{parameter.Name}_ptr");

                    original.Add(parameters[i]);

                    parameters[i] = parameters[i] with { Type = new CSRef(refType, baseType) };

                    changed.Add(parameters[i]);
                }
            }

            if (changed.Count > 0)
            {
                var layer = new RefInsteadOfPointerLayer(changed, original);
                newOverloads = new List<Overload>()
                {
                    overload with { NestedOverload = overload, MarshalLayerToNested = layer, InputParameters = parameters, NameTable = nameTable, GenericTypes = genericTypes }
                };
                return true;
            }
            else
            {
                newOverloads = default;
                return false;
            }
        }

        class RefInsteadOfPointerLayer : IOverloadLayer
        {
            public readonly List<Parameter> RefParameters;
            public readonly List<Parameter> PointerParameters;

            public RefInsteadOfPointerLayer(List<Parameter> refParameters, List<Parameter> pointerParameters)
            {
                RefParameters = refParameters;
                PointerParameters = pointerParameters;
            }

            private Scope Scope;
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                for (int i = 0; i < RefParameters.Count; i++)
                {
                    string type = PointerParameters[i].Type.ToCSString();
                    writer.WriteLine($"fixed ({type} {nameTable[PointerParameters[i]]} = &{nameTable[RefParameters[i]]})");
                }

                Scope = writer.Scope();
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                Scope.Dispose();
                return returnName;
            }
        }
    }
}
