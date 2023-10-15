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
    public class SpecificationParser
    {
        class APIData
        {
            public GLAPI API;
            public List<Feature> Features = new List<Feature>();
            public List<Extension> Extensions = new List<Extension>();

            public APIData(GLAPI api)
            {
                API = api;
            }
        }

        public static Specification2 Parse(Stream input)
        {
            XDocument? xdocument = XDocument.Load(input);

            if (xdocument.Root == null)
                throw new NullReferenceException("The parsed xml didn't contain a Root node.");

            List<Command>? commands = ParseCommands(xdocument.Root);
            List<Enums>? enums = ParseEnums(xdocument.Root);

            List<Feature>? features = ParseFeatures(xdocument.Root);
            List<Extension>? extensions = ParseExtensions(xdocument.Root);

            List<API> APIs = MakeAPIs(features, extensions);

            return new Specification2(commands, enums, APIs);
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

                // FIXME: If we want to generate the compatibility thing we want to remove all of the 
                foreach (var feature in features)
                {
                    foreach (var requires in feature.Requires)
                    {
                        Debug.Assert(requires.Api != feature.Api);

                        foreach (var enumName in requires.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName, feature.Version, null, new List<ExtensionReference>(), GLProfile.None);
                                enumNameToReference.Add(enumName, value);
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
                                value = new EnumReference(enumName, feature.Version, null, new List<ExtensionReference>(), GLProfile.None);
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
                                value = new EnumReference(enumName, null, null, new List<ExtensionReference>(), GLProfile.None);
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

        private static List<Command> ParseCommands(XElement input)
        {
            Logger.Info("Begining parsing of commands.");
            XElement? xelement = input.Element("commands")!;

            List<Command>? commands = new List<Command>();
            foreach (XElement? element in xelement.Elements("command"))
            {
                Command? command = ParseCommand(element);

                // Don't add this command to the list if we should ignore it.
                if (GeneratorSettings.Settings.IgnoreFunctions.Contains(command.EntryPoint))
                {
                    continue;
                }

                commands.Add(command);
            }

            return commands;
        }

        private static Command ParseCommand(XElement c)
        {
            XElement? proto = c.Element("proto");
            if (proto == null) throw new Exception("Missing proto tag!");

            string? entryPoint = proto.Element("name")?.Value;
            if (entryPoint == null) throw new Exception("Missing name tag!");

            List<GLParameter>? parameterList = new List<GLParameter>();
            foreach (XElement? element in c.Elements("param"))
            {
                string? paramName = element.Element("name")?.Value;
                PType? ptype = ParsePType(element);

                string[] kind = element.Attribute("kind")?.Value?.Split(',') ?? Array.Empty<string>();

                if (paramName == null) throw new Exception("Missing parameter name!");

                string? length = element.Attribute("len")?.Value;
                Expression? paramLength = length == null ? null : ParseExpression(length);

                parameterList.Add(new GLParameter(ptype, kind, paramName, paramLength));
            }

            PType? returnType = ParsePType(proto);

            return new Command(entryPoint, returnType, parameterList.ToArray());
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

        private static PType ParsePType(XElement t)
        {
            string? group = t.Attribute("group")?.Value;

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

            return new PType(ParseType(str), handle, group);
        }

        private static GLType ParseType(string type)
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

                GLType? baseType = ParseType(withoutAsterisk);

                return new GLPointerType(baseType, @const);
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

                PrimitiveType primitiveType = type switch
                {
                    "void" => PrimitiveType.Void,
                    "GLenum" => PrimitiveType.Enum,
                    "GLboolean" => PrimitiveType.Bool8,
                    "GLbitfield" => PrimitiveType.Uint,
                    "GLvoid" => PrimitiveType.Void,
                    "GLbyte" => PrimitiveType.Sbyte,
                    "GLubyte" => PrimitiveType.Byte,
                    "GLshort" => PrimitiveType.Short,
                    "GLushort" => PrimitiveType.Ushort,
                    "GLint" => PrimitiveType.Int,
                    "GLuint" => PrimitiveType.Uint,
                    "GLclampx" => PrimitiveType.Int,
                    "GLsizei" => PrimitiveType.Int,
                    "GLfloat" => PrimitiveType.Float,
                    "GLclampf" => PrimitiveType.Float,
                    "GLdouble" => PrimitiveType.Double,
                    "GLclampd" => PrimitiveType.Double,
                    "GLeglClientBufferEXT" => PrimitiveType.VoidPtr,
                    "GLeglImageOES" => PrimitiveType.VoidPtr,
                    "GLchar" => PrimitiveType.Char8,
                    "GLcharARB" => PrimitiveType.Char8,
                    "GLhalf" => PrimitiveType.Half,
                    "GLhalfARB" => PrimitiveType.Half,
                    "GLfixed" => PrimitiveType.Int,
                    "GLintptr" => PrimitiveType.IntPtr,
                    "GLintptrARB" => PrimitiveType.IntPtr,
                    "GLsizeiptr" => PrimitiveType.Nint,
                    "GLsizeiptrARB" => PrimitiveType.Nint,
                    "GLint64" => PrimitiveType.Long,
                    "GLint64EXT" => PrimitiveType.Long,
                    "GLuint64" => PrimitiveType.Ulong,
                    "GLuint64EXT" => PrimitiveType.Ulong,
                    "GLhalfNV" => PrimitiveType.Half,
                    "GLvdpauSurfaceNV" => PrimitiveType.IntPtr,

                    // This type is platform specific on apple.
                    "GLhandleARB" => PrimitiveType.GLHandleARB,

                    // The following have a custom c# implementation in the writer.
                    "GLsync" => PrimitiveType.GLSync,
                    "_cl_context" => PrimitiveType.CLContext,
                    "_cl_event" => PrimitiveType.CLEvent,
                    "GLDEBUGPROC" => PrimitiveType.GLDebugProc,
                    "GLDEBUGPROCARB" => PrimitiveType.GLDebugProcARB,
                    "GLDEBUGPROCKHR" => PrimitiveType.GLDebugProcKHR,
                    "GLDEBUGPROCAMD" => PrimitiveType.GLDebugProcAMD,
                    "GLDEBUGPROCNV" => PrimitiveType.GLDebugProcNV,
                    // This isn't actually used in the output bindings.
                    // But we leave it here as a primitive type so we have the information if we need it later.
                    // - 2021-06-23
                    "GLVULKANPROCNV" => PrimitiveType.GLVulkanProcNV,

                    // WGL.xml types
                    "BOOL" => PrimitiveType.Bool32,
                    "CHAR" => PrimitiveType.Char8,
                    "DWORD" => PrimitiveType.Uint,
                    "FLOAT" => PrimitiveType.Float,
                    "HANDLE" => PrimitiveType.IntPtr,
                    "HDC" => PrimitiveType.IntPtr,
                    "HGLRC" => PrimitiveType.IntPtr,
                    "INT" => PrimitiveType.Int,
                    "INT32" => PrimitiveType.Int,
                    "INT64" => PrimitiveType.Long,
                    "PROC" => PrimitiveType.WGL_Proc,
                    "RECT" => PrimitiveType.WGL_Rect,
                    "LPCSTR" => PrimitiveType.WGL_LPString,
                    "LPVOID" => PrimitiveType.IntPtr,
                    "UINT" => PrimitiveType.Uint,
                    "USHORT" => PrimitiveType.Ushort,
                    "VOID" => PrimitiveType.Void,
                    "COLORREF" => PrimitiveType.WGL_COLORREF,
                    "HENHMETAFILE" => PrimitiveType.IntPtr,
                    "LAYERPLANEDESCRIPTOR" => PrimitiveType.WGL_LAYERPLANEDESCRIPTOR,
                    // FIXME?
                    "LPGLYPHMETRICSFLOAT" => PrimitiveType.IntPtr,
                    "PIXELFORMATDESCRIPTOR" => PrimitiveType.WGL_PIXELFORMATDESCRIPTOR,
                    "HPBUFFERARB" => PrimitiveType.IntPtr,
                    "HPBUFFEREXT" => PrimitiveType.IntPtr,
                    "HVIDEOOUTPUTDEVICENV" => PrimitiveType.IntPtr,
                    "HPVIDEODEV" => PrimitiveType.IntPtr,
                    "HPGPUNV" => PrimitiveType.IntPtr,
                    "HGPUNV" => PrimitiveType.IntPtr,
                    "HVIDEOINPUTDEVICENV" => PrimitiveType.IntPtr,
                    "GPU_DEVICE" => PrimitiveType.WGL_GPU_DEVICE,
                    // FIXME? _GPU_DEVICE*
                    "PGPU_DEVICE" => PrimitiveType.WGL_PGPU_DEVICE,

                    "int" => PrimitiveType.Int,
                    "unsigned int" => PrimitiveType.Uint,
                    "char" => PrimitiveType.Char8,
                    "float" => PrimitiveType.Float,
                    "long" => PrimitiveType.Long,
                    "unsigned long" => PrimitiveType.Ulong,

                    // GLX types

                    "Bool" => PrimitiveType.Bool8,
                    "Colormap" => PrimitiveType.GLX_Colormap,
                    "Display" => PrimitiveType.GLX_Display,
                    "Font" => PrimitiveType.GLX_Font,
                    "Pixmap" => PrimitiveType.GLX_Pixmap,
                    "Screen" => PrimitiveType.GLX_Screen,
                    "Status" => PrimitiveType.GLX_Status, // FIXME: Maybe type?
                    "Window" => PrimitiveType.GLX_Window,
                    "XVisualInfo" => PrimitiveType.GLX_XVisualInfo,
                    "DMbuffer" => PrimitiveType.GLX_DMbuffer,
                    "DMparams" => PrimitiveType.GLX_DMparams,
                    "VLNode" => PrimitiveType.GLX_VLNode,
                    "VLPath" => PrimitiveType.GLX_VLPath,
                    "VLServer" => PrimitiveType.GLX_VLServer,
                    "GLXFBConfigID" => PrimitiveType.GLX_FBConfigID,
                    "GLXFBConfig" => PrimitiveType.GLX_FBConfig,
                    "GLXContextID" => PrimitiveType.GLX_ContextID,
                    "GLXContext" => PrimitiveType.GLX_Context,
                    "GLXPixmap" => PrimitiveType.GLX_GLXPixmap,
                    "GLXDrawable" => PrimitiveType.GLX_GLXDrawable,
                    "GLXWindow" => PrimitiveType.GLX_GLXWindow,
                    "__GLXextFuncPtr" => PrimitiveType.GLX_EXTFuncPtr, // FIXME!
                    "GLXPbuffer" => PrimitiveType.GLX_GLXPbuffer,
                    "GLXVideoCaptureDeviceNV" => PrimitiveType.GLX_VideoCaptureDeviceNV,
                    "GLXVideoDeviceNV" => PrimitiveType.GLX_VideoDeviceNV,
                    "GLXVideoSourceSGIX" => PrimitiveType.GLX_VideoSourceSGIX,
                    "GLXFBConfigIDSGIX" => PrimitiveType.GLX_FBConfigIDSGIX,
                    "GLXFBConfigSGIX" => PrimitiveType.GLX_FBConfigSGIX,
                    "GLXPbufferSGIX" => PrimitiveType.GLX_GLXPbufferSGIX,
                    "GLXPbufferClobberEvent" => PrimitiveType.GLX_GLXPbufferClobberEvent,
                    "GLXBufferSwapComplete" => PrimitiveType.GLX_GLXBufferSwapComplete,
                    "GLXEvent" => PrimitiveType.GLX_GLXEvent,
                    "GLXStereoNotifyEventEXT" => PrimitiveType.GLX_GLXStereoNotifyEventEXT,
                    "GLXBufferClobberEventSGIX" => PrimitiveType.GLX_GLXBufferClobberEventSGIX,
                    "GLXHyperpipeNetworkSGIX" => PrimitiveType.GLX_GLXHyperpipeNetworkSGIX,
                    "GLXHyperpipeConfigSGIX" => PrimitiveType.GLX_GLXHyperpipeConfigSGIX,
                    "GLXPipeRect" => PrimitiveType.GLX_GLXPipeRect,
                    "GLXPipeRectLimits" => PrimitiveType.GLX_GLXPipeRectLimits,

                    "int32_t" => PrimitiveType.Int,
                    "int64_t" => PrimitiveType.Long,

                    _ => PrimitiveType.Invalid,
                };

                if (primitiveType == PrimitiveType.Invalid)
                {
                    throw new Exception($"Type conversion has not been created for type {type}");
                }

                return new GLBaseType(type, primitiveType, @const);
            }
        }


        public static List<Enums> ParseEnums(XElement input)
        {
            Logger.Info("Begining parsing of enums.");
            List<Enums> enumsEntries = new List<Enums>();
            foreach (XElement? enums in input.Elements("enums"))
            {
                string? @namespace = enums.Attribute("namespace")?.Value;
                if (@namespace == null) throw new Exception($"Enums entry '{enums}' is missing a namespace attribute.");

                // GLX.xml abuses enum tags to define strings,
                // to work around this we skip all enums tags marked
                // with the GLXStrings namespace
                // - 2023-03-25 NogginBops
                if (@namespace == "GLXStrings") continue;

                string[] group = enums.Attribute("group")?.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

                string? vendor = enums.Attribute("vendor")?.Value;

                EnumType type = ParseEnumsType(enums.Attribute("type")?.Value);

                string? startStr = enums.Attribute("start")?.Value;
                string? endStr = enums.Attribute("end")?.Value;
                if (startStr == null && endStr != null ||
                    startStr != null && endStr == null)
                    throw new Exception($"Enums entry '{enums}' is missing either a start or end attribute.");

                Range? range = null;
                if (startStr != null && endStr != null)
                {
                    Index start = (Index)ParseInt(startStr);
                    Index end = (Index)ParseInt(endStr);
                    range = new Range(start, end);

                    static int ParseInt(string str)
                    {
                        bool hex = str.StartsWith("0x");
                        if (hex) str = str[2..];
                        return int.Parse(str, hex ? NumberStyles.HexNumber : NumberStyles.Integer);
                    }
                }

                string? comment = enums.Attribute("comment")?.Value;

                List<EnumEntry> entries = new List<EnumEntry>();
                foreach (XElement? @enum in enums.Elements("enum"))
                {
                    entries.Add(ParseEnumEntry(@enum));
                }

                enumsEntries.Add(new Enums(@namespace, group, type, vendor, range, comment, entries));
            }

            return enumsEntries;

            static EnumType ParseEnumsType(string? value) => value switch
            {
                null or "" => EnumType.None,
                "bitmask" => EnumType.Bitmask,
                _ => EnumType.Invalid,
            };
        }

        public static EnumEntry ParseEnumEntry(XElement @enum)
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

            string[] groups = @enum.Attribute("group")?.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

            string? comment = @enum.Attribute("comment")?.Value;

            GLAPI api = ParseApi(@enum.Attribute("api")?.Value);

            return new EnumEntry(name, api, value, alias, comment, groups, suffix);

            static TypeSuffix ParseEnumTypeSuffix(string? suffix) => suffix switch
            {
                null or "" => TypeSuffix.None,
                "u" => TypeSuffix.U,
                "ull" => TypeSuffix.Ull,
                _ => TypeSuffix.Invalid,
            };

            static ulong ConvertToUInt64(string val, TypeSuffix type) => type switch
            {
                TypeSuffix.None => (uint)(int)new Int32Converter().ConvertFromString(val),
                TypeSuffix.Ull => (ulong)(long)new Int64Converter().ConvertFromString(val),
                TypeSuffix.U => (uint)new UInt32Converter().ConvertFromString(val),
                TypeSuffix.Invalid or _ => throw new Exception($"Invalid suffix '{type}'!"),
            };
        }


        public static List<Feature> ParseFeatures(XElement input)
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

        public static List<Extension> ParseExtensions(XElement input)
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
                string? extNameWithoutGLPrefix = NameMangler.RemoveExtensionPrefix(extName);
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

        public static RequireEntry ParseRequire(XElement requires)
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

        public static RemoveEntry ParseRemove(XElement requires)
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


        public static GLAPI ParseApi(string? api) => api switch
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

        public static GLProfile ParseProfile(string? profile) => profile switch
        {
            null or "" => GLProfile.None,

            "core" => GLProfile.Core,
            "compatibility" => GLProfile.Compatibility,
            "common" => GLProfile.Common,

            _ => GLProfile.Invalid,
        };
    }
}
