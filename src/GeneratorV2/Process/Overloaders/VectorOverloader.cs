using System;
using System.Collections.Generic;
using System.Linq;
using GeneratorV2.Data;
using GeneratorV2.Writing;

namespace GeneratorV2.Process.Overloaders
{
    public class VectorOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, out List<Overload>? newOverloads)
        {
            string name = overload.OverloadName;

            // First the name is passed so we can check for the correct vector type.
            int vIndex = name.IndexOf('v');
            if (vIndex == -1)
            {
                newOverloads = null;
                return false;
            }
            char typeChar = name[vIndex - 1];
            string baseType;
            switch (typeChar)
            {
                case 'i':
                    baseType = "int";
                    break;
                case'd':
                    baseType = "double";
                    break;
                case 'f':
                    baseType = "float";
                    break;
                case 'h':
                    baseType = "half";
                    break;
                default:
                    // Logger.Warning($"Couldn't turn {typeChar} into a vector type.");
                    newOverloads = null;
                    return false;
            }

            bool foundVector = false;
            NameTable nameTable = overload.NameTable.New();
            Parameter[] parameters = overload.InputParameters;
            List<Parameter> newParameters = parameters.ToList();
            List<Parameter> pointerParameters = new List<Parameter>();
            List<Parameter> vectorParameters = new List<Parameter>();
            List<Parameter> countParameters = new List<Parameter>();
            for (int i = 0; i < parameters.Length; i++)
            {
                Parameter parameter = parameters[i];
                if (parameter.Type is CSPointer {BaseType: CSType csType} &&
                    csType.TypeName == baseType)
                {
                    // Check if the length of the parameter is correct.
                    int length = -1;
                    if (parameter.Length is Constant constant)
                    {
                        length = constant.Value;
                    }
                    else if (parameter.Length is BinaryOperation binary)
                    {
                        // If we have a binary operation length we need to set the count parameter to 1.
                        Expression other;
                        if (binary.Left is Constant left)
                        {
                            length = left.Value;
                            other = binary.Right;
                        }
                        else if (binary.Right is Constant right)
                        {
                            length = right.Value;
                            other = binary.Left;
                        }
                        else
                        {
                            newOverloads = null;
                            return false;
                        }

                        if (other is ParameterReference reference)
                        {
                            Parameter? countParameter = newParameters.Find(p => p.Name == reference.ParameterName);
                            if (countParameter == null)
                                throw new Exception($"{reference.ParameterName} is not a valid reference on {name}");
                            countParameters.Add(countParameter);
                        }
                    }

                    if (length < 2 || length > 4)
                    {
                        continue;
                    }

                    // Save the new parameter.
                    nameTable.Rename(parameter, parameter.Name + "_ptr");
                    string vectorType = "Vector" + length + (typeChar == 'f' ? "" : typeChar);
                    newParameters[i] = parameter with
                    {
                        Type = new CSRef(csType.Constant ? CSRef.Type.In : CSRef.Type.Ref, new CSType(vectorType, csType.Constant)),
                        Length = null
                    };
                    foundVector = true;
                    pointerParameters.Add(parameter);
                    vectorParameters.Add(newParameters[i]);
                }
            }

            if (foundVector)
            {
                // Remove the count parameters from the new overload.
                for (var i = countParameters.Count - 1; i >= 0; i--)
                {
                    Parameter parameterToRemove = countParameters[i];
                    newParameters.Remove(parameterToRemove);
                }

                // Get the new name for the overload.
                int vectorStartIndexInName = vIndex - 1;
                if (char.IsDigit(name[vIndex - 2]))
                {
                    vectorStartIndexInName -= 1;
                }
                string newName = name[..(vectorStartIndexInName)] + name[(vIndex+1)..];

                newOverloads = new List<Overload>()
                {
                    overload with
                    {
                        InputParameters = newParameters.ToArray(),
                        NameTable = nameTable,
                        NestedOverload = overload,
                        OverloadName = newName,
                        MarshalLayerToNested = new VectorOverloadLayer(pointerParameters, vectorParameters, countParameters),
                    },
                    overload,
                };
                return true;
            }

            newOverloads = null;
            return false;
        }

        public class VectorOverloadLayer : IOverloadLayer
        {
            private readonly List<Parameter> _pointerParameters;
            private readonly List<Parameter> _vectorParameters;
            private readonly List<Parameter> _countParameters;

            public VectorOverloadLayer(List<Parameter> pointerParameters,
                List<Parameter> vectorParameters, List<Parameter> countParameters)
            {
                _pointerParameters = pointerParameters;
                _vectorParameters = vectorParameters;
                _countParameters = countParameters;
            }

            private CsScope _scope;
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                for (int i = 0; i < _vectorParameters.Count; i++)
                {
                    Parameter pointerParameter = _pointerParameters[i];
                    Parameter vectorParameter = _vectorParameters[i];
                    string pointerName = nameTable[pointerParameter];
                    string vectorName = nameTable[vectorParameter];

                    writer.WriteLine($"fixed ({pointerParameter.Type.ToCSString()} {pointerName} = &{vectorName}.X)");
                }
                _scope = writer.CsScope();

                foreach (Parameter countParameter in _countParameters)
                {
                    writer.WriteLine($"{countParameter.Type.ToCSString()} {nameTable[countParameter]} = 1;");
                }
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                _scope.Dispose();
                return returnName;
            }
        }
    }
}
