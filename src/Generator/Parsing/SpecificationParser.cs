using Generator.Utility;
using Generator.Utility.Extensions;
using Generator.Writing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Generator.Parsing
{
    internal class SpecificationParser
    {
        internal static Specification2 Parse(Stream input, NameMangler nameMangler, GLFile currentFile, List<string> ignoreFunctions)
        {
            XDocument? xdocument = XDocument.Load(input);

            if (xdocument.Root == null)
                throw new NullReferenceException("The parsed xml didn't contain a Root node.");

            List<NativeFunction> functions = ParseCommands(xdocument.Root, nameMangler, currentFile, ignoreFunctions);
            List<EnumEntry>? enums = ParseEnums(xdocument.Root, nameMangler, currentFile);

            List<Feature>? features = ParseFeatures(xdocument.Root);
            List<Extension>? extensions = ParseExtensions(xdocument.Root, nameMangler);

            List<API> APIs = MakeAPIs(features, extensions);

            return new Specification2(functions, enums, APIs);
        }

        private static List<API> MakeAPIs(List<Feature> features, List<Extension> extensions)
        {
            Dictionary<GLAPI, List<Feature>> FeaturesPerAPI = new Dictionary<GLAPI, List<Feature>>();
            foreach (var feature in features)
            {
                FeaturesPerAPI.AddToNestedList(feature.Api, feature);
            }

            Dictionary<GLAPI, List<Extension>> ExtensionsPerAPI = new Dictionary<GLAPI, List<Extension>>();
            foreach (var extension in extensions)
            {
                foreach (var supportedAPI in extension.SupportedApis)
                {
                    ExtensionsPerAPI.AddToNestedList(supportedAPI, extension);
                }
            }

            List<API> APIs = new List<API>();
            foreach (var api in FeaturesPerAPI.Keys.Union(ExtensionsPerAPI.Keys))
            {
                // FIXME: Better way of filtering things.
                // We don't case about GLSC2.
                // Ignore GLAPI-None, there is only one disabled extension that doesn't have an API.
                // - 2023-03-21 NogginBops
                // Only extensions are marked with GLCore and they always
                // support normal GL.
                // - 2023-03-21 NogginBops
                if (api == GLAPI.GLSC2 ||
                    api == GLAPI.None ||
                    api == GLAPI.GLCore)
                    continue;

                List<FunctionReference> functions = MakeFunctionReferences(FeaturesPerAPI[api], ExtensionsPerAPI[api], api);
                // FIXME: Here we miss the enums that where not defined in this file. for example wgl::ObjectTypeDX
                List<EnumReference> enums = MakeEnumReferences(FeaturesPerAPI[api], ExtensionsPerAPI[api], api);

                InputAPI inAPI = api switch
                {
                    GLAPI.GL => InputAPI.GL,
                    GLAPI.GLES1 => InputAPI.GLES1,
                    GLAPI.GLES2 => InputAPI.GLES2,
                    GLAPI.WGL => InputAPI.WGL,
                    GLAPI.GLX => InputAPI.GLX,

                    _ => throw new Exception(),
                };

                APIs.Add(new API(inAPI, functions, enums));
            }

            return APIs;

            static List<FunctionReference> MakeFunctionReferences(List<Feature> features, List<Extension> extensions, GLAPI api)
            {
                //List<FunctionReference> functions = new List<FunctionReference>();
                Dictionary<string, FunctionReference> entryPointToReference = new Dictionary<string, FunctionReference>();

                // FIXME: If we want to generate the compatibility thing we want to remove all of the 
                foreach (var feature in features)
                {
                    foreach (var requires in feature.Requires)
                    {
                        Debug.Assert(requires.Api != feature.Api);

                        foreach (var entryPoint in requires.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint, feature.Version, null, new List<ExtensionReference>(), GLProfile.None);
                                entryPointToReference.Add(entryPoint, value);
                            }

                            // FIXME: This isn't strictly needed... they are already going to be in order.
                            if (feature.Version < value.AddedIn)
                            {
                                value = value with { AddedIn = feature.Version };
                            }

                            value = value with { Profile = requires.Profile };

                            entryPointToReference[entryPoint] = value;
                        }
                    }

                    foreach (var removes in feature.Removes)
                    {
                        bool isCompatibility = removes.Profile == GLProfile.Compatibility;

                        foreach (var entryPoint in removes.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint, feature.Version, null, new List<ExtensionReference>(), GLProfile.None);
                                entryPointToReference.Add(entryPoint, value);
                            }

                            // If we should, update the removed in.
                            if (value.RemovedIn == null || feature.Version < value.RemovedIn)
                            {
                                value = value with { RemovedIn = feature.Version };
                            }

                            value = value with { Profile = removes.Profile };

                            entryPointToReference[entryPoint] = value;
                        }
                    }
                }

                foreach (var extension in extensions)
                {
                    Debug.Assert(extension.SupportedApis.Contains(api));

                    foreach (var requires in extension.Requires)
                    {
                        Debug.Assert(extension.SupportedApis.Contains(requires.Api) || requires.Api == GLAPI.None);

                        foreach (var entryPoint in requires.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint, null, null, new List<ExtensionReference>(), GLProfile.None);
                                entryPointToReference.Add(entryPoint, value);
                            }

                            value.PartOfExtensions.Add(new ExtensionReference(extension.Name, extension.Vendor));

                            // FIXME: Should we do this?
                            value = value with { Profile = requires.Profile };

                            entryPointToReference[entryPoint] = value;
                        }
                    }
                }

                return entryPointToReference.Values.ToList();
            }

            static List<EnumReference> MakeEnumReferences(List<Feature> features, List<Extension> extensions, GLAPI api)
            {
                Dictionary<string, EnumReference> enumNameToReference = new Dictionary<string, EnumReference>();

                foreach (var feature in features)
                {
                    foreach (var requires in feature.Requires)
                    {
                        Debug.Assert(requires.Api != feature.Api);

                        foreach (var enumName in requires.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName, feature.Version, null, new List<ExtensionReference>(), GLProfile.None, false);
                                enumNameToReference.Add(enumName, value);
                            }

                            // If this enum value was removed and later readded.
                            if (value.RemovedIn != null && feature.Version > value.RemovedIn)
                            {
                                value = value with { AddedIn = feature.Version, RemovedIn = null };
                            }

                            // FIXME: This isn't strictly needed... they are already going to be in order.
                            if (feature.Version < value.AddedIn)
                            {
                                value = value with { AddedIn = feature.Version };
                            }

                            value = value with { Profile = requires.Profile };

                            enumNameToReference[enumName] = value;
                        }
                    }

                    foreach (var removes in feature.Removes)
                    {
                        foreach (var enumName in removes.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName, feature.Version, null, new List<ExtensionReference>(), GLProfile.None, false);
                                enumNameToReference.Add(enumName, value);
                            }

                            // If we should, update the removed in.
                            if (value.RemovedIn == null || feature.Version < value.RemovedIn)
                            {
                                value = value with { RemovedIn = feature.Version };
                            }

                            value = value with { Profile = removes.Profile };

                            enumNameToReference[enumName] = value;
                        }
                    }
                }

                foreach (var extension in extensions)
                {
                    Debug.Assert(extension.SupportedApis.Contains(api));

                    foreach (var requires in extension.Requires)
                    {
                        Debug.Assert(extension.SupportedApis.Contains(requires.Api) || requires.Api == GLAPI.None);

                        foreach (var enumName in requires.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName, null, null, new List<ExtensionReference>(), GLProfile.None, false);
                                enumNameToReference.Add(enumName, value);
                            }

                            value.PartOfExtensions.Add(new ExtensionReference(extension.Name, extension.Vendor));

                            // FIXME: Should we do this?
                            value = value with { Profile = requires.Profile };

                            enumNameToReference[enumName] = value;
                        }
                    }
                }

                return enumNameToReference.Values.ToList();
            }
        }

        // FIXME: Maybe change name?
        private static List<NativeFunction> ParseCommands(XElement input, NameMangler nameMangler, GLFile currentFile, List<string> ignoreFunctions)
        {
            Logger.Info("Begining parsing of commands.");
            XElement? xelement = input.Element("commands")!;

            List<NativeFunction> functions = new List<NativeFunction>();
            foreach (XElement element in xelement.Elements("command"))
            {
                NativeFunction function = ParseCommand(element, nameMangler, currentFile);

                // Don't add this command to the list if we should ignore it.
                if (ignoreFunctions.Contains(function.EntryPoint))
                {
                    continue;
                }

                functions.Add(function);
            }

            return functions;
        }

        private static NativeFunction ParseCommand(XElement c, NameMangler nameMangler, GLFile currentFile)
        {
            XElement? proto = c.Element("proto");
            if (proto == null) throw new Exception("Missing proto tag!");

            string? entryPoint = proto.Element("name")?.Value;
            if (entryPoint == null) throw new Exception("Missing name tag!");

            HashSet<GroupRef> referencedEnumGroups = new HashSet<GroupRef>();

            List<Parameter>? paramList = new List<Parameter>();
            foreach (XElement? element in c.Elements("param"))
            {
                string paramName = element.Element("name")?.Value ?? throw new Exception("Missing parameter name!");
                string mangledName = NameMangler.MangleParameterName(paramName);

                BaseCSType type = ParsePType(element, currentFile, nameMangler, out GroupRef? groupRef);
                if (groupRef != null) referencedEnumGroups.Add(groupRef);

                string[] kind = element.Attribute("kind")?.Value?.Split(',') ?? Array.Empty<string>();

                string? length = element.Attribute("len")?.Value;
                Expression? paramLength = length == null ? null : ParseExpression(length);

                // FIXME: Parse kinds in some way?
                paramList.Add(new Parameter(type, kind, mangledName, paramLength));
            }

            BaseCSType returnType = ParsePType(proto, currentFile, nameMangler, out GroupRef? returnGroup);
            if (returnGroup != null) referencedEnumGroups.Add(returnGroup);
            
            string functionName = nameMangler.MangleFunctionName(entryPoint);

            return new NativeFunction(entryPoint, functionName, paramList, returnType, referencedEnumGroups.ToArray());
        }

        private static Expression ParseExpression(string expression)
        {
            Expression? retExpr = ParseExpressionPrio2(expression, out string leftOver);

            if (string.IsNullOrEmpty(leftOver) == false)
                throw new Exception($"Failed to parse expression '{expression}' with leftover '{leftOver}'");

            return retExpr;
        }

        private static Expression ParseExpressionPrio2(string expression, out string leftOver)
        {
            Expression? retExpr = ParseExpressionPrio1(expression, out string exp);
            exp = exp.TrimStart();

            BinaryOperator op;
            // GetOperation is a local function defined below return.
            while ((op = GetOperation(exp)) != BinaryOperator.Invalid)
            {
                exp = exp[1..];
                Expression? right = ParseExpressionPrio1(exp, out exp);
                exp = exp.TrimStart();

                retExpr = new BinaryOperation(retExpr, op, right);
            }

            leftOver = exp;
            return retExpr;

            static BinaryOperator GetOperation(string expression)
            {
                if (expression.Length == 0) return BinaryOperator.Invalid;
                return expression[0] switch
                {
                    '+' => BinaryOperator.Addition,
                    '-' => BinaryOperator.Subtraction,
                    _ => BinaryOperator.Invalid,
                };
            }
        }

        private static Expression ParseExpressionPrio1(string expression, out string leftOver)
        {
            Expression? retExpr = ParseExpressionPrio0(expression, out string exp);
            exp = exp.TrimStart();

            BinaryOperator op;
            // GetOperation is a local function defined below return.
            while ((op = GetOperation(exp)) != BinaryOperator.Invalid)
            {
                exp = exp[1..];
                Expression? right = ParseExpressionPrio0(exp, out exp);
                exp = exp.TrimStart();

                retExpr = new BinaryOperation(retExpr, op, right);
            }

            leftOver = exp;
            return retExpr;

            static BinaryOperator GetOperation(string expression)
            {
                if (expression.Length == 0) return BinaryOperator.Invalid;
                return expression[0] switch
                {
                    '*' => BinaryOperator.Multiplication,
                    '/' => BinaryOperator.Division,
                    _ => BinaryOperator.Invalid,
                };
            }
        }

        private static Expression ParseExpressionPrio0(string expression, out string leftOver)
        {
            expression = expression.TrimStart();
            if (expression.StartsWith("COMPSIZE("))
            {
                string? exp = expression["COMPSIZE(".Length..];
                List<Expression> arguments = new List<Expression>();
                while (exp[0] != ')')
                {
                    arguments.Add(ParseExpressionPrio2(exp, out exp));

                    // NOTE: Possible error here, if whitespaces are introduced in COMPSIZE() inside the spec.
                    if (exp[0] == ',')
                        exp = exp[1..];
                }
                // Remove the last ')'
                leftOver = exp[1..];
                return new CompSize(arguments.ToArray());
            }
            else if (char.IsDigit(expression[0]))
            {
                int i = 1;
                while (i < expression.Length && char.IsDigit(expression[i]))
                {
                    i++;
                }

                leftOver = expression[i..];
                return new Constant(int.Parse(expression[0..i]));
            }
            else if (char.IsLetter(expression[0]))
            {
                int i = 1;
                while (i < expression.Length && char.IsLetterOrDigit(expression[i]))
                {
                    i++;
                }

                leftOver = expression[i..];
                return new ParameterReference(expression[0..i]);
            }
            else throw new Exception($"Could not parse expression '{expression}'");
        }

        private static BaseCSType ParsePType(XElement t, GLFile currentFile, NameMangler nameMangler, out GroupRef? groupRef)
        {
            string? group = t.Attribute("group")?.Value;
            if (group != null)
                groupRef = GroupRefFromString(group, currentFile, nameMangler);
            else
                groupRef = null;

            string? className = t.Attribute("class")?.Value;
            HandleType? handle = className switch
            {
                null => null,
                "program" => HandleType.ProgramHandle,
                "program pipeline" => HandleType.ProgramPipelineHandle,
                "texture" => HandleType.TextureHandle,
                "buffer" => HandleType.BufferHandle,
                "shader" => HandleType.ShaderHandle,
                "query" => HandleType.QueryHandle,
                "framebuffer" => HandleType.FramebufferHandle,
                "renderbuffer" => HandleType.RenderbufferHandle,
                "sampler" => HandleType.SamplerHandle,
                "transform feedback" => HandleType.TransformFeedbackHandle,
                "vertex array" => HandleType.VertexArrayHandle,
                // The "Sync" class is already marked with the "GLSync" type which is handled differently from the other types
                // We leave it null here to let the "GLSync" handling do this.
                "sync" => null,
                "display list" => HandleType.DisplayListHandle,
                "perf query handle" => HandleType.PerfQueryHandle,
                "perf query id" => null,
                _ => throw new Exception(className + " is not a supported handle type yet!"),
            };

            string? str = t.GetXmlText(element => element.Name != "name" ? element.Value : string.Empty).Trim();

            BaseCSType type = ParseType(str, handle, groupRef, nameMangler);
            return type;
        }

        private static BaseCSType ParseType(string type, HandleType? handle, GroupRef? group, NameMangler nameMangler)
        {
            type = type.Trim();

            if (type.EndsWith('*'))
            {
                // This removes the last character of the string, ^1 is an exclusive upper bound.
                string? withoutAsterisk = type[0..^1].TrimEnd();

                // A pointer is only const if const is directly in front of the pointer,
                // if the const is in front of the type the type is the constant and not the pointer.
                bool @const = false;
                if (withoutAsterisk.EndsWith("const"))
                {
                    @const = true;
                    withoutAsterisk = withoutAsterisk[0..^"const".Length];
                }

                BaseCSType? baseType = ParseType(withoutAsterisk, handle, group, nameMangler);

                // Some structs are created as CSOpaqueStructs, this means that the only 
                // valid way to use these is through a pointer. We intercept them here
                // and create the proper CSStructPrimitive types from them.
                // - Noggin_bops 2024-03-07
                if (baseType is CSOpaqueStruct opaque)
                {
                    switch (opaque.TypeName)
                    {
                        // FIXME: Decide if we want `DisplayPtr`, `Display` or something like `XDisplay`?
                        // - Noggin_bops 2024-03-07
                        case "Display":
                            return new CSStructPrimitive("DisplayPtr", opaque.Constant, CSPrimitive.IntPtr(true));
                        case "Screen":
                            return new CSStructPrimitive("ScreenPtr", opaque.Constant, CSPrimitive.IntPtr(true));
                        case "XVisualInfo":
                            return new CSStructPrimitive("XVisualInfoPtr", opaque.Constant, CSPrimitive.IntPtr(true));
                        default:
                            throw new Exception($"Unknown opaque struct type {opaque.TypeName}.");
                    }
                }
                else
                {
                    return new CSPointer(baseType, @const);
                }

            }
            else
            {
                bool @const = false;
                if (type.StartsWith("const"))
                {
                    @const = true;
                    type = type["const".Length..].TrimStart();
                }

                // This is needed for _cl_context, and _cl_event
                // We don't care about struct here because it doesn't add any information (we are not a c compiler).
                if (type.StartsWith("struct"))
                {
                    type = type["struct".Length..].TrimStart();
                }

                // To make OpenTK 5 more like OpenTK 4 we want handles to be int instead of uint
                if (handle != null)
                {
                    return new CSPrimitive("int", @const);
                }

                // For now we only expect int and uint to be able to be turned into groupNameToEnumGroup.
                // - 2022-08-09
                // FIXME: We might want to make sure that the underlying type for the enumName groupName is the same as the parameter groupName.
                //   Right now we blindly substituting the type for the enumName.
                if (group != null && (type == "GLuint" || type == "GLint" || type == "INT" || type == "UINT" || type == "INT32" || type == "int" || type == "int32_t"))
                {
                    Logger.Info($"Making {type} into group {group.TranslatedName}");
                    CSPrimitive baseType = type switch
                    {
                        "GLint" => new CSPrimitive("int", @const),
                        "GLuint" => new CSPrimitive("uint", @const),
                        "INT" => new CSPrimitive("int", @const),
                        "UINT" => new CSPrimitive("uint", @const),
                        "INT32" => new CSPrimitive("int", @const),
                        "int" => new CSPrimitive("int", @const),
                        "int32_t" => new CSPrimitive("int", @const),
                        _ => throw new Exception("This should not happen!"),
                    };

                    return new CSEnum(group.TranslatedName, group, baseType, @const);
                }

                BaseCSType csType;
                {
                    csType = type switch
                    {
                        "void" => new CSVoid(@const),
                        "GLenum" => new CSEnum(group?.TranslatedName ?? "All", group, CSPrimitive.Uint(@const), @const),
                        "GLboolean" => new CSBool8(@const),
                        "GLbitfield" => group != null ?
                                            new CSEnum(group.TranslatedName, group, CSPrimitive.Uint(@const), @const) :
                                            CSPrimitive.Uint(@const),
                        "GLvoid" => new CSVoid(@const),
                        "GLbyte" => CSPrimitive.Sbyte(@const),
                        "GLubyte" => CSPrimitive.Byte(@const),
                        "GLshort" => CSPrimitive.Short(@const),
                        "GLushort" => CSPrimitive.Ushort(@const),
                        "GLint" => CSPrimitive.Int(@const),
                        "GLuint" => CSPrimitive.Uint(@const),
                        "GLclampx" => CSPrimitive.Int(@const),
                        "GLsizei" => CSPrimitive.Int(@const),
                        "GLfloat" => CSPrimitive.Float(@const),
                        "GLclampf" => CSPrimitive.Float(@const),
                        "GLdouble" => CSPrimitive.Double(@const),
                        "GLclampd" => CSPrimitive.Double(@const),
                        "GLeglClientBufferEXT" => new CSPointer(new CSVoid(false), @const),
                        "GLeglImageOES" => new CSPointer(new CSVoid(false), @const),
                        "GLchar" => new CSChar8(@const),
                        "GLcharARB" => new CSChar8(@const),
                        "GLhalf" => CSPrimitive.Half(@const),
                        "GLhalfARB" => CSPrimitive.Half(@const),
                        "GLfixed" => CSPrimitive.Int(@const),
                        "GLintptr" => CSPrimitive.IntPtr(@const),
                        "GLintptrARB" => CSPrimitive.IntPtr(@const),
                        "GLsizeiptr" => CSPrimitive.Nint(@const),
                        "GLsizeiptrARB" => CSPrimitive.Nint(@const),
                        "GLint64" => CSPrimitive.Long(@const),
                        "GLint64EXT" => CSPrimitive.Long(@const),
                        "GLuint64" => CSPrimitive.Ulong(@const),
                        "GLuint64EXT" => CSPrimitive.Ulong(@const),
                        "GLhalfNV" => CSPrimitive.Half(@const),
                        "GLvdpauSurfaceNV" => CSPrimitive.IntPtr(@const),

                        // This type is platform specific on apple.
                        "GLhandleARB" => new CSStructPrimitive("GLHandleARB", @const, new CSPrimitive("IntPtr", @const)),

                        // The following have a custom c# implementation in the writer.
                        "GLsync" => new CSStructPrimitive("GLSync", @const, new CSPrimitive("IntPtr", @const)),
                        "_cl_context" => new CSStructPrimitive("CLContext", @const, new CSPrimitive("IntPtr", @const)),
                        "_cl_event" => new CSStructPrimitive("CLEvent", @const, new CSPrimitive("IntPtr", @const)),
                        "GLDEBUGPROC" => new CSFunctionPointer("GLDebugProc", @const),
                        "GLDEBUGPROCARB" => new CSFunctionPointer("GLDebugProcARB", @const),
                        "GLDEBUGPROCKHR" => new CSFunctionPointer("GLDebugProcKHR", @const),
                        "GLDEBUGPROCAMD" => new CSFunctionPointer("GLDebugProcAMD", @const),
                        "GLDEBUGPROCNV" => new CSFunctionPointer("GLDebugProcNV", @const),
                        // This isn't actually used in the output bindings.
                        // But we leave it here as a primitive type so we have the information if we need it later.
                        // - 2021-06-23
                        "GLVULKANPROCNV" => new CSFunctionPointer("GLVulkanProcNV", @const),

                        // WGL.xml types
                        "BOOL" => new CSBool32(@const),
                        "CHAR" => new CSChar8(@const),
                        "DWORD" => CSPrimitive.Uint(@const),
                        "FLOAT" => CSPrimitive.Float(@const),
                        "HANDLE" => CSPrimitive.IntPtr(@const),
                        // FIXME: Do we want types for types like HDC and HGLRC
                        // that we could use both here and in PAL2?
                        // - Noggin_bops 2024-03-06
                        "HDC" => CSPrimitive.IntPtr(@const),
                        "HGLRC" => CSPrimitive.IntPtr(@const),
                        "INT" => CSPrimitive.Int(@const),
                        "INT32" => CSPrimitive.Int(@const),
                        "INT64" => CSPrimitive.Long(@const),
                        "PROC" => new CSFunctionPointer("???", @const),
                        "RECT" => new CSStruct("Rect", @const),
                        "LPCSTR" => new CSPointer(new CSChar8(true), @const),
                        "LPVOID" => CSPrimitive.IntPtr(@const),
                        "UINT" => CSPrimitive.Uint(@const),
                        "USHORT" => CSPrimitive.Ushort(@const),
                        "VOID" => new CSVoid(@const),
                        "COLORREF" => new CSStructPrimitive("ColorRef", @const, new CSPrimitive("uint", false)),
                        "HENHMETAFILE" => CSPrimitive.IntPtr(@const),
                        "LAYERPLANEDESCRIPTOR" => new CSStruct("LayerPlaneDescriptor", @const),
                        // FIXME?
                        "LPGLYPHMETRICSFLOAT" => CSPrimitive.IntPtr(@const),
                        "PIXELFORMATDESCRIPTOR" => new CSStruct("PixelFormatDescriptor", @const),
                        "HPBUFFERARB" => CSPrimitive.IntPtr(@const),
                        "HPBUFFEREXT" => CSPrimitive.IntPtr(@const),
                        "HVIDEOOUTPUTDEVICENV" => CSPrimitive.IntPtr(@const),
                        "HPVIDEODEV" => CSPrimitive.IntPtr(@const),
                        "HPGPUNV" => CSPrimitive.IntPtr(@const),
                        "HGPUNV" => CSPrimitive.IntPtr(@const),
                        "HVIDEOINPUTDEVICENV" => CSPrimitive.IntPtr(@const),
                        "GPU_DEVICE" => new CSStruct("_GPU_DEVICE", @const),
                        // FIXME? _GPU_DEVICE*
                        "PGPU_DEVICE" => new CSPointer(new CSStruct("_GPU_DEVICE", false), @const),

                        "int" => CSPrimitive.Int(@const),
                        "unsigned int" => CSPrimitive.Uint(@const),
                        "char" => new CSChar8(@const),
                        "float" => CSPrimitive.Float(@const),
                        "long" => CSPrimitive.Long(@const),
                        "unsigned long" => CSPrimitive.Ulong(@const),

                        // GLX types

                        "Bool" => new CSBool8(@const),
                        "Colormap" => new CSStructPrimitive("Colormap", @const, new CSPrimitive("nuint", @const)),
                        "Display" => new CSOpaqueStruct("Display", @const),
                        "Font" => new CSStructPrimitive("Font", @const, new CSPrimitive("nuint", @const)),
                        "Pixmap" => new CSStructPrimitive("Pixmap", @const, new CSPrimitive("nuint", @const)),
                        "Screen" => new CSOpaqueStruct("Screen", @const),
                        "Status" => new CSPrimitive("int", @const), // FIXME: Maybe type?
                        "Window" => new CSStructPrimitive("Window", @const, new CSPrimitive("nuint", @const)),
                        "XVisualInfo" => new CSOpaqueStruct("XVisualInfo", @const),

                        // FIXME: These types are conditionally removed from the header if _DM_BUFFER_H_ is not defined
                        // Should we have some way to say that specific functions should be ignored?
                        "DMbuffer" => new CSVoid(@const),
                        "DMparams" => new CSVoid(@const),

                        // FIXME: These types are conditionally removed from the header if _VL_H_ is not defined.
                        // Should we have some way to say that specific functions should be ignored?
                        "VLNode" => new CSVoid(@const),
                        "VLPath" => new CSVoid(@const),
                        "VLServer" => new CSVoid(@const),

                        "__GLXextFuncPtr" => new CSFunctionPointer("__GLXextFuncPtr", @const), // FIXME!

                        "GLXFBConfigID" => new CSStructPrimitive("FBConfigID", @const, new CSPrimitive("nuint", @const)),
                        "GLXFBConfig" => new CSStructPrimitive("GLXFBConfig", @const, new CSPrimitive("IntPtr", @const)),
                        "GLXContextID" => new CSStructPrimitive("GLXContextID", @const, new CSPrimitive("nuint", @const)),
                        "GLXContext" => new CSStructPrimitive("GLXContext", @const, new CSPrimitive("IntPtr", @const)),
                        "GLXPixmap" => new CSStructPrimitive("GLXPixmap", @const, new CSPrimitive("nuint", @const)),
                        "GLXDrawable" => new CSStructPrimitive("GLXDrawable", @const, new CSPrimitive("nuint", @const)),
                        "GLXWindow" => new CSStructPrimitive("GLXWindow", @const, new CSPrimitive("nuint", @const)),
                        "GLXPbuffer" => new CSStructPrimitive("GLXPbuffer", @const, new CSPrimitive("nuint", @const)),
                        "GLXVideoCaptureDeviceNV" => new CSStructPrimitive("GLXVideoCaptureDeviceNV", @const, new CSPrimitive("nuint", @const)),
                        "GLXVideoDeviceNV" => new CSStructPrimitive("GLXVideoDeviceNV", @const, new CSPrimitive("uint", @const)),
                        "GLXVideoSourceSGIX" => new CSStructPrimitive("GLXVideoSourceSGIX", @const, new CSPrimitive("nuint", @const)),
                        "GLXFBConfigIDSGIX" => new CSStructPrimitive("GLXFBConfigIDSGIX", @const, new CSPrimitive("nuint", @const)),
                        "GLXFBConfigSGIX" => new CSStructPrimitive("GLXFBConfigSGIX", @const, new CSPrimitive("IntPtr", @const)),
                        "GLXPbufferSGIX" => new CSStructPrimitive("GLXPbufferSGIX", @const, new CSPrimitive("nuint", @const)),
                        "GLXPbufferClobberEvent" => new CSStruct("GLXPbufferClobberEvent", @const),
                        "GLXBufferSwapComplete" => new CSStruct("GLXBufferSwapComplete", @const),
                        "GLXEvent" => new CSStruct("GLXEvent", @const),
                        "GLXStereoNotifyEventEXT" => new CSStruct("GLXStereoNotifyEventEXT", @const),
                        "GLXBufferClobberEventSGIX" => new CSStruct("GLXBufferClobberEventSGIX", @const),
                        "GLXHyperpipeNetworkSGIX" => new CSStruct("GLXHyperpipeNetworkSGIX", @const),
                        "GLXHyperpipeConfigSGIX" => new CSStruct("GLXHyperpipeConfigSGIX", @const),
                        "GLXPipeRect" => new CSStruct("GLXPipeRect", @const),
                        "GLXPipeRectLimits" => new CSStruct("GLXPipeRectLimits", @const),

                        "int32_t" => CSPrimitive.Int(@const),
                        "int64_t" => CSPrimitive.Long(@const),

                        _ => throw new Exception($"Type conversion has not been created for type {type}"),
                    };
                }

                return csType;
            }
        }


        internal static List<EnumEntry> ParseEnums(XElement input, NameMangler nameMangler, GLFile currentFile)
        {
            Logger.Info("Begining parsing of enums.");
            List<EnumEntry> enumsEntries = new List<EnumEntry>();
            foreach (XElement? enums in input.Elements("enums"))
            {
                string? @namespace = enums.Attribute("namespace")?.Value;
                if (@namespace == null) throw new Exception($"Enums entry '{enums}' is missing a namespace attribute.");

                // GLX.xml abuses enum tags to define strings,
                // to work around this we skip all enums tags marked
                // with the GLXStrings namespace
                // - 2023-03-25 NogginBops
                if (@namespace == "GLXStrings") continue;

                GroupRef[] parentGroups = ParseGroups(enums.Attribute("group")?.Value, currentFile, nameMangler);

                string? vendor = enums.Attribute("vendor")?.Value;

                EnumType type = ParseEnumsType(enums.Attribute("type")?.Value);

                string? enumsComment = enums.Attribute("comment")?.Value;

                foreach (XElement? @enum in enums.Elements("enum"))
                {
                    string? name = @enum.Attribute("name")?.Value;
                    string? valueStr = @enum.Attribute("value")?.Value;
                    if (valueStr == null || name == null)
                    {
                        throw new Exception($"Enum {name} did not pass correctly");
                    }

                    TypeSuffix suffix = ParseEnumTypeSuffix(@enum.Attribute("type")?.Value);

                    ulong value = ConvertToUInt64(valueStr, suffix);

                    string? alias = @enum.Attribute("alias")?.Value;

                    GroupRef[] groups = ParseGroups(@enum.Attribute("group")?.Value, currentFile, nameMangler);
                    // Mark this with all of the groups from the parent tag.
                    groups = ArrayUtil.MergeDeduplicate(groups, parentGroups);

                    string? enumComment = @enum.Attribute("comment")?.Value;

                    GLAPI api = ParseApi(@enum.Attribute("api")?.Value);
                    OutputApiFlags enumApi;
                    if (api == GLAPI.None)
                    {
                        enumApi = currentFile switch
                        {
                            GLFile.GL => OutputApiFlags.GL | OutputApiFlags.GLCompat | OutputApiFlags.GLES1 | OutputApiFlags.GLES2,
                            GLFile.WGL => OutputApiFlags.WGL,
                            GLFile.GLX => OutputApiFlags.GLX,

                            _ => throw new Exception(),
                        };
                    }
                    else 
                    {
                        enumApi = api switch
                        {
                            GLAPI.GL => OutputApiFlags.GL | OutputApiFlags.GLCompat,
                            GLAPI.GLES1 => OutputApiFlags.GLES1,
                            GLAPI.GLES2 => OutputApiFlags.GLES2,
                            GLAPI.WGL => OutputApiFlags.WGL,
                            GLAPI.GLX => OutputApiFlags.GLX,

                            GLAPI.GLCore => throw new Exception(),
                            GLAPI.GLSC2 => throw new Exception(),
                            GLAPI.Invalid => throw new Exception(),
                            _ => throw new Exception(),
                        };
                    }

                    foreach (var group in groups)
                    {
                        switch (group.Namespace)
                        {
                            case GLFile.GL:
                                enumApi |= OutputApiFlags.GL | OutputApiFlags.GLCompat | OutputApiFlags.GLES1 | OutputApiFlags.GLES2;
                                break;
                            case GLFile.WGL:
                                enumApi |= OutputApiFlags.WGL;
                                break;
                            case GLFile.GLX:
                                enumApi |= OutputApiFlags.GLX;
                                break;
                        }
                    }

                    enumsEntries.Add(new EnumEntry(name, nameMangler.MangleEnumName(name), value, enumApi, type, vendor, alias, groups, suffix));
                }
            }

            return enumsEntries;

            static EnumType ParseEnumsType(string? value) => value switch
            {
                null or "" => EnumType.None,
                "bitmask" => EnumType.Bitmask,
                _ => EnumType.Invalid,
            };

            static TypeSuffix ParseEnumTypeSuffix(string? suffix) => suffix switch
            {
                null or "" => TypeSuffix.None,
                "u" => TypeSuffix.U,
                "ull" => TypeSuffix.Ull,
                _ => TypeSuffix.Invalid,
            };

            static ulong ConvertToUInt64(string val, TypeSuffix type) => type switch
            {
                TypeSuffix.None => (uint)(int)new Int32Converter().ConvertFromString(val)!,
                TypeSuffix.Ull => (ulong)(long)new Int64Converter().ConvertFromString(val)!,
                TypeSuffix.U => (uint)new UInt32Converter().ConvertFromString(val)!,
                TypeSuffix.Invalid or _ => throw new Exception($"Invalid suffix '{type}'!"),
            };
        }

        internal static GroupRef[] ParseGroups(string? groups, GLFile currentFile, NameMangler nameMangler)
        {
            if (groups == null) return Array.Empty<GroupRef>();

            string[] rawGroups = groups.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
            GroupRef[] groupRefs = new GroupRef[rawGroups.Length];
            for (int i = 0; i < rawGroups.Length; i++)
            {
                groupRefs[i] = GroupRefFromString(rawGroups[i], currentFile, nameMangler);
            }

            return groupRefs;
        }

        internal static GroupRef GroupRefFromString(string group, GLFile currentFile, NameMangler nameMangler)
        {
            string name;
            GLFile file;
            if (group.StartsWith("gl::"))
            {
                name = NameMangler.RemoveStart(group, "gl::");
                file = GLFile.GL;
            }
            else if (group.StartsWith("wgl::"))
            {
                name = NameMangler.RemoveStart(group, "wgl::");
                file = GLFile.WGL;
            }
            else if (group.StartsWith("glx::"))
            {
                name = NameMangler.RemoveStart(group, "glx::");
                file = GLFile.GLX;
            }
            else
            {
                name = group;
                file = currentFile;
            }

            string translatedName = nameMangler.TranslateEnumGroupName(name);

            return new GroupRef(name, translatedName, file);
        }


        internal static List<Feature> ParseFeatures(XElement input)
        {
            Logger.Info("Begining parsing of features.");

            List<Feature> features = new List<Feature>();

            foreach (XElement? feature in input.Elements("feature"))
            {
                string? apiStr = feature.Attribute("api")?.Value;
                string? name = feature.Attribute("name")?.Value;
                string? number = feature.Attribute("number")?.Value;

                if (apiStr == null || name == null || number == null)
                {
                    throw new Exception($"Feature '{feature}' is missing an attribute.");
                }

                Version? version = Version.Parse(number);
                GLAPI api = ParseApi(apiStr);

                List<RequireEntry> requireEntries = new List<RequireEntry>();
                foreach (XElement? require in feature.Elements("require"))
                {
                    RequireEntry reqEntry = ParseRequire(require);
                    requireEntries.Add(reqEntry);
                }

                List<RemoveEntry> removeEntries = new List<RemoveEntry>();
                foreach (XElement? remove in feature.Elements("remove"))
                {
                    RemoveEntry removeEntry = ParseRemove(remove);
                    removeEntries.Add(removeEntry);
                }

                features.Add(new Feature(api, version, name, requireEntries, removeEntries));
            }

            return features;
        }

        internal static List<Extension> ParseExtensions(XElement input, NameMangler nameMangler)
        {
            List<Extension> extensions = new List<Extension>();
            XElement? xelement = input.Element("extensions")!;

            foreach (XElement? extension in xelement.Elements("extension"))
            {
                string? extName = extension.Attribute("name")?.Value;
                if (extName == null)
                {
                    throw new Exception($"Extension '{extension}' is missing a name!");
                }

                // Remove "GL_" and get the vendor name from the first part of the extension name
                // Extension name convention: "GL_VENDOR_EXTENSION_NAME"
                string? extNameWithoutGLPrefix = nameMangler.RemoveExtensionPrefix(extName);
                string? vendor = extNameWithoutGLPrefix[..extNameWithoutGLPrefix.IndexOf("_")];
                if (string.IsNullOrEmpty(vendor))
                {
                    throw new Exception($"Extension '{extension}' doesn't have the vendor in it's name!");
                }

                if (char.IsDigit(vendor[0]))
                {
                    vendor = "_" + vendor;
                }

                string? comment = extension.Attribute("comment")?.Value;

                GLAPI[]? supportedApis = extension
                    .Attribute("supported")?.Value?
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => ParseApi(s)).ToArray();

                if (supportedApis == null)
                {
                    throw new Exception($"Extension '{extension}' did not specify any supported APIs.");
                }

                List<RequireEntry> requires = new List<RequireEntry>();
                foreach (XElement? require in extension.Elements("require"))
                {
                    requires.Add(ParseRequire(require));
                }

                extensions.Add(new Extension(extName, vendor, supportedApis, comment, requires));
            }

            return extensions;
        }

        internal static RequireEntry ParseRequire(XElement requires)
        {
            GLAPI api = ParseApi(requires.Attribute("api")?.Value);
            GLProfile profile = ParseProfile(requires.Attribute("profile")?.Value);
            string? comment = requires.Attribute("comment")?.Value;

            List<string> reqCommands = new List<string>();
            List<string> reqEnums = new List<string>();

            foreach (XElement? entry in requires.Elements())
            {
                // A few entries here have a comment attribute, but we don't bother with it
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");

                switch (entry.Name.LocalName)
                {
                    case "command":
                        reqCommands.Add(name);
                        break;
                    case "enum":
                        reqEnums.Add(name);
                        break;
                    default:
                        continue;
                }
            }

            return new RequireEntry(api, profile, comment, reqCommands, reqEnums);
        }

        internal static RemoveEntry ParseRemove(XElement requires)
        {
            GLProfile profile = ParseProfile(requires.Attribute("profile")?.Value);
            string? comment = requires.Attribute("comment")?.Value;

            List<string> removeCommands = new List<string>();
            List<string> removeEnums = new List<string>();

            foreach (XElement? entry in requires.Elements())
            {
                // A few entries here have a comment attribute, but we don't bother with it
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");

                switch (entry.Name.LocalName)
                {
                    case "command":
                        removeCommands.Add(name);
                        break;
                    case "enum":
                        removeEnums.Add(name);
                        break;
                    default:
                        continue;
                }
            }

            return new RemoveEntry(profile, comment, removeCommands, removeEnums);
        }


        internal static GLAPI ParseApi(string? api) => api switch
        {
            null or "" or "disabled" => GLAPI.None,

            "gl" => GLAPI.GL,
            "gles1" => GLAPI.GLES1,
            "gles2" => GLAPI.GLES2,
            "glsc2" => GLAPI.GLSC2,
            "glcore" => GLAPI.GLCore,

            "wgl" => GLAPI.WGL,
            "glx" => GLAPI.GLX,

            _ => GLAPI.Invalid,
        };

        internal static GLProfile ParseProfile(string? profile) => profile switch
        {
            null or "" => GLProfile.None,

            "core" => GLProfile.Core,
            "compatibility" => GLProfile.Compatibility,
            "common" => GLProfile.Common,

            _ => GLProfile.Invalid,
        };
    }
}
