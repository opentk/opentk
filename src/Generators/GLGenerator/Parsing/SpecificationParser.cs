using GeneratorBase;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace GLGenerator.Parsing
{
    internal class SpecificationParser
    {
        internal static SpecificationFile Parse(Stream input, NameMangler nameMangler, ApiFile currentFile, List<string> ignoreFunctions)
        {
            XDocument? xdocument = XDocument.Load(input);

            if (xdocument.Root == null)
                throw new NullReferenceException("The parsed xml didn't contain a Root node.");

            List<Function> functions = ParseCommands(xdocument.Root, nameMangler, currentFile, ignoreFunctions);
            List<EnumEntry> enums = ParseEnums(xdocument.Root, nameMangler, currentFile);

            List<Feature> features = ParseFeatures(xdocument.Root, ignoreFunctions);
            List<Extension> extensions = ParseExtensions(xdocument.Root, nameMangler, ignoreFunctions);

            return new SpecificationFile(currentFile, functions, enums, features, extensions);
        }

        private static List<Function> ParseCommands(XElement input, NameMangler nameMangler, ApiFile currentFile, List<string> ignoreFunctions)
        {
            Logger.Info("Begining parsing of commands.");
            List<Function> functions = new List<Function>();
            foreach (var commands in input.Elements("commands"))
            {
                foreach (XElement command in commands.Elements("command"))
                {
                    XElement proto = command.Element("proto") ?? throw new Exception("Missing proto tag!");

                    string entryPoint = proto.Element("name")?.Value ?? throw new Exception("Missing name tag!");
                    if (ignoreFunctions.Contains(entryPoint))
                    {
                        continue;
                    }

                    HashSet<GroupRef> referencedEnumGroups = new HashSet<GroupRef>();

                    List<Parameter>? paramList = new List<Parameter>();
                    foreach (XElement? element in command.Elements("param"))
                    {
                        string paramName = element.Element("name")?.Value ?? throw new Exception("Missing parameter name!");
                        string mangledName = NameMangler.MangleParameterName(paramName);

                        BaseCSType type = ParsePType(element, currentFile, nameMangler, out GroupRef? groupRef);
                        if (groupRef != null) referencedEnumGroups.Add(groupRef);

                        string[] kinds = element.Attribute("kind")?.Value?.Split(',') ?? Array.Empty<string>();

                        string? length = element.Attribute("len")?.Value;
                        Expression? paramLength = length == null ? null : ParseExpression(length);

                        paramList.Add(new Parameter()
                        {
                            Name = mangledName,
                            OriginalName = paramName,
                            Type = type.ToCSString(),
                            Length = length,

                            StrongType = type,
                            StrongLength = paramLength,

                            Kinds = kinds
                        });
                    }

                    BaseCSType returnType = ParsePType(proto, currentFile, nameMangler, out GroupRef? returnGroup);
                    if (returnGroup != null) referencedEnumGroups.Add(returnGroup);

                    string functionName = nameMangler.MangleFunctionName(entryPoint);

                    functions.Add(new Function()
                    {
                        Name = functionName,
                        EntryPoint = entryPoint,
                        ReturnType = returnType.ToCSString(),
                        Parameters = paramList,

                        StrongReturnType = returnType,

                        ReferencedEnumGroups = referencedEnumGroups.ToArray(),
                    });
                }
            }
            return functions;
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

                retExpr = new BinaryOperationExpression(retExpr, op, right);
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

                retExpr = new BinaryOperationExpression(retExpr, op, right);
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
                return new CompSizeExpression(arguments.ToArray());
            }
            else if (char.IsDigit(expression[0]))
            {
                int i = 1;
                while (i < expression.Length && char.IsDigit(expression[i]))
                {
                    i++;
                }

                leftOver = expression[i..];
                return new ConstantExpression(int.Parse(expression[0..i]));
            }
            else if (char.IsLetter(expression[0]))
            {
                int i = 1;
                while (i < expression.Length && (char.IsLetterOrDigit(expression[i]) || expression[i] == '_'))
                {
                    i++;
                }

                leftOver = expression[i..];
                return new ParameterReferenceExpression(expression[0..i]);
            }
            else throw new Exception($"Could not parse expression '{expression}'");
        }

        private static BaseCSType ParsePType(XElement t, ApiFile currentFile, NameMangler nameMangler, out GroupRef? groupRef)
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
                "any" => HandleType.AnyHandle,
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
                        case "AHardwareBuffer":
                            return new CSStructPrimitive("AHardwareBuffer", opaque.Constant, CSPrimitive.IntPtr(true));
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
                    return CSPrimitive.Int(@const);
                }

                // For now we only expect int and uint to be able to be turned into groupNameToEnumGroup.
                // - 2022-08-09
                // FIXME: We might want to make sure that the underlying type for the enumName groupName is the same as the parameter groupName.
                //   Right now we blindly substituting the type for the enumName.
                if (group != null &&
                        (type == "GLuint" ||
                        type == "GLint" ||
                        type == "INT" ||
                        type == "UINT" ||
                        type == "INT32" ||
                        type == "int" ||
                        type == "int32_t" ||
                        type == "EGLint" ||
                        type == "EGLuint"))
                {
                    Logger.Info($"Making {type} into group {group.TranslatedName}");
                    CSPrimitive baseType = type switch
                    {
                        "GLint" => CSPrimitive.Int(@const),
                        "GLuint" => CSPrimitive.Uint(@const),
                        "INT" => CSPrimitive.Int(@const),
                        "UINT" => CSPrimitive.Uint(@const),
                        "INT32" => CSPrimitive.Int(@const),
                        "int" => CSPrimitive.Int(@const),
                        "int32_t" => CSPrimitive.Int(@const),
                        "EGLint" => CSPrimitive.Int(@const),
                        "EGLuint" => CSPrimitive.Uint(@const),
                        _ => throw new Exception("This should not happen!"),
                    };

                    return new CSEnum(group.TranslatedName, baseType, @const);
                }
                
                BaseCSType csType;
                {
                    csType = type switch
                    {
                        "void" => new CSVoid(@const),
                        "GLenum" => new CSEnum(group?.TranslatedName ?? "All", CSPrimitive.Uint(@const), @const),
                        "GLboolean" => new CSBool8(@const),
                        "GLbitfield" => group != null ?
                                            new CSEnum(group.TranslatedName, CSPrimitive.Uint(@const), @const) :
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
                        "GLhandleARB" => new CSStructPrimitive("GLHandleARB", @const, CSPrimitive.IntPtr(@const)),

                        // The following have a custom c# implementation in the writer.
                        "GLsync" => new CSStructPrimitive("GLSync", @const, CSPrimitive.IntPtr(@const)),
                        "_cl_context" => new CSStructPrimitive("CLContext", @const, CSPrimitive.IntPtr(@const)),
                        "_cl_event" => new CSStructPrimitive("CLEvent", @const, CSPrimitive.IntPtr(@const)),
                        "GLDEBUGPROC" => new CSOpaqueFunctionPointer("GLDebugProc", @const),
                        "GLDEBUGPROCARB" => new CSOpaqueFunctionPointer("GLDebugProcARB", @const),
                        "GLDEBUGPROCKHR" => new CSOpaqueFunctionPointer("GLDebugProcKHR", @const),
                        "GLDEBUGPROCAMD" => new CSOpaqueFunctionPointer("GLDebugProcAMD", @const),
                        "GLDEBUGPROCNV" => new CSOpaqueFunctionPointer("GLDebugProcNV", @const),
                        // This isn't actually used in the output bindings.
                        // But we leave it here as a primitive type so we have the information if we need it later.
                        // - 2021-06-23
                        "GLVULKANPROCNV" => new CSOpaqueFunctionPointer("GLVulkanProcNV", @const),

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
                        "PROC" => new CSOpaqueFunctionPointer("???", @const),
                        "RECT" => new CSStruct("Rect", @const),
                        "LPCSTR" => new CSPointer(new CSChar8(true), @const),
                        "LPVOID" => CSPrimitive.IntPtr(@const),
                        "UINT" => CSPrimitive.Uint(@const),
                        "USHORT" => CSPrimitive.Ushort(@const),
                        "VOID" => new CSVoid(@const),
                        "COLORREF" => new CSStructPrimitive("ColorRef", @const, CSPrimitive.Uint(false)),
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
                        "Colormap" => new CSStructPrimitive("Colormap", @const, CSPrimitive.Nuint(@const)),
                        "Display" => new CSOpaqueStruct("Display", @const),
                        "Font" => new CSStructPrimitive("Font", @const, CSPrimitive.Nuint(@const)),
                        "Pixmap" => new CSStructPrimitive("Pixmap", @const, CSPrimitive.Nuint(@const)),
                        "Screen" => new CSOpaqueStruct("Screen", @const),
                        "Status" => CSPrimitive.Int(@const), // FIXME: Maybe type?
                        "Window" => new CSStructPrimitive("Window", @const, CSPrimitive.Nuint(@const)),
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

                        "__GLXextFuncPtr" => new CSOpaqueFunctionPointer("__GLXextFuncPtr", @const), // FIXME!

                        "GLXFBConfigID" => new CSStructPrimitive("FBConfigID", @const, CSPrimitive.Nuint(@const)),
                        "GLXFBConfig" => new CSStructPrimitive("GLXFBConfig", @const, CSPrimitive.IntPtr(@const)),
                        "GLXContextID" => new CSStructPrimitive("GLXContextID", @const, CSPrimitive.Nuint(@const)),
                        "GLXContext" => new CSStructPrimitive("GLXContext", @const, CSPrimitive.IntPtr(@const)),
                        "GLXPixmap" => new CSStructPrimitive("GLXPixmap", @const, CSPrimitive.Nuint(@const)),
                        "GLXDrawable" => new CSStructPrimitive("GLXDrawable", @const, CSPrimitive.Nuint(@const)),
                        "GLXWindow" => new CSStructPrimitive("GLXWindow", @const, CSPrimitive.Nuint(@const)),
                        "GLXPbuffer" => new CSStructPrimitive("GLXPbuffer", @const, CSPrimitive.Nuint(@const)),
                        "GLXVideoCaptureDeviceNV" => new CSStructPrimitive("GLXVideoCaptureDeviceNV", @const, CSPrimitive.Nuint(@const)),
                        "GLXVideoDeviceNV" => new CSStructPrimitive("GLXVideoDeviceNV", @const, CSPrimitive.Uint(@const)),
                        "GLXVideoSourceSGIX" => new CSStructPrimitive("GLXVideoSourceSGIX", @const, CSPrimitive.Nuint(@const)),
                        "GLXFBConfigIDSGIX" => new CSStructPrimitive("GLXFBConfigIDSGIX", @const, CSPrimitive.Nuint(@const)),
                        "GLXFBConfigSGIX" => new CSStructPrimitive("GLXFBConfigSGIX", @const, CSPrimitive.IntPtr(@const)),
                        "GLXPbufferSGIX" => new CSStructPrimitive("GLXPbufferSGIX", @const, CSPrimitive.Nuint(@const)),
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

                        "EGLNativeDisplayType" => CSPrimitive.IntPtr(@const),
                        "EGLNativePixmapType" => CSPrimitive.IntPtr(@const),
                        "EGLNativeWindowType" => CSPrimitive.IntPtr(@const),

                        "EGLint" => CSPrimitive.Int(@const),
                        "EGLenum" => new CSEnum(group?.TranslatedName ?? "All", CSPrimitive.Uint(@const), @const),
                        "EGLBoolean" => new CSBool32(@const),
                        "EGLAttribKHR" => CSPrimitive.IntPtr(@const),
                        "EGLAttrib" => CSPrimitive.IntPtr(@const),

                        "EGLClientBuffer" => new CSStructPrimitive("EGLClientBuffer", @const, CSPrimitive.IntPtr(@const)),
                        "EGLConfig" => new CSStructPrimitive("EGLConfig", @const, CSPrimitive.IntPtr(@const)),
                        "EGLContext" => new CSStructPrimitive("EGLContext", @const, CSPrimitive.IntPtr(@const)),
                        "EGLDeviceEXT" => new CSStructPrimitive("EGLDeviceEXT", @const, CSPrimitive.IntPtr(@const)),
                        "EGLDisplay" => new CSStructPrimitive("EGLDisplay", @const, CSPrimitive.IntPtr(@const)),
                        "EGLImage" => new CSStructPrimitive("EGLImage", @const, CSPrimitive.IntPtr(@const)),
                        "EGLImageKHR" => new CSStructPrimitive("EGLImageKHR", @const, CSPrimitive.IntPtr(@const)),
                        "EGLLabelKHR" => new CSStructPrimitive("EGLLabelKHR", @const, CSPrimitive.IntPtr(@const)),
                        "EGLObjectKHR" => new CSStructPrimitive("EGLObjectKHR", @const, CSPrimitive.IntPtr(@const)),
                        "EGLOutputLayerEXT" => new CSStructPrimitive("EGLOutputLayerEXT", @const, CSPrimitive.IntPtr(@const)),
                        "EGLOutputPortEXT" => new CSStructPrimitive("EGLOutputPortEXT", @const, CSPrimitive.IntPtr(@const)),
                        "EGLStreamKHR" => new CSStructPrimitive("EGLStreamKHR", @const, CSPrimitive.IntPtr(@const)),
                        "EGLSurface" => new CSStructPrimitive("EGLSurface", @const, CSPrimitive.IntPtr(@const)),
                        "EGLSync" => new CSStructPrimitive("EGLSync", @const, CSPrimitive.IntPtr(@const)),
                        "EGLSyncKHR" => new CSStructPrimitive("EGLSyncKHR", @const, CSPrimitive.IntPtr(@const)),
                        "EGLSyncNV" => new CSStructPrimitive("EGLSyncNV", @const, CSPrimitive.IntPtr(@const)),

                        "EGLTimeKHR" => CSPrimitive.Ulong(@const),
                        "EGLTime" => CSPrimitive.Ulong(@const),
                        "EGLTimeNV" => CSPrimitive.Ulong(@const),
                        "EGLuint64NV" => CSPrimitive.Ulong(@const),
                        "EGLuint64KHR" => CSPrimitive.Ulong(@const),
                        "EGLnsecsANDROID" => CSPrimitive.Long(@const),

                        "EGLNativeFileDescriptorKHR" => CSPrimitive.Int(@const),

                        "EGLClientPixmapHI" => new CSStruct("EGLClientPixmapHI", @const),

                        "EGLFrameTokenANGLE" => CSPrimitive.Ulong(@const),

                        "EGLDEBUGPROCKHR" => new CSOpaqueFunctionPointer("EGLDebugProcKHR", @const),
                        "EGLSetBlobFuncANDROID" => new CSOpaqueFunctionPointer("EGLSetBlobFuncANDROID", @const),
                        "EGLGetBlobFuncANDROID" => new CSOpaqueFunctionPointer("EGLGetBlobFuncANDROID", @const),

                        "AHardwareBuffer" => new CSOpaqueStruct("AHardwareBuffer", @const),

                        "__eglMustCastToProperFunctionPointerType" => CSPrimitive.IntPtr(@const),

                        // FIXME: What are the actual wayland types?
                        "wl_buffer" => CSPrimitive.IntPtr(@const),
                        "wl_display" => CSPrimitive.IntPtr(@const),
                        "wl_resource" => CSPrimitive.IntPtr(@const),

                        _ => throw new Exception($"Type conversion has not been created for type {type}"),
                    };
                }

                return csType;
            }
        }


        internal static List<EnumEntry> ParseEnums(XElement input, NameMangler nameMangler, ApiFile currentFile)
        {
            Logger.Info("Begining parsing of enums.");
            List<EnumEntry> enumsEntries = new List<EnumEntry>();
            foreach (XElement? enums in input.Elements("enums"))
            {
                string @namespace = enums.Attribute("namespace")?.Value ?? throw new Exception($"Enums entry '{enums}' is missing a namespace attribute.");

                // GLX.xml abuses enum tags to define strings,
                // to work around this we skip all enums tags marked
                // with the GLXStrings namespace
                // - 2023-03-25 NogginBops
                if (@namespace == "GLXStrings")
                    continue;

                GroupRef[] parentGroups = ParseGroups(enums.Attribute("group")?.Value, currentFile, nameMangler);

                string? vendor = enums.Attribute("vendor")?.Value;

                bool isFlags = IsEnumTypeBitmask(enums.Attribute("type")?.Value);

                string? enumsComment = enums.Attribute("comment")?.Value;

                foreach (XElement? @enum in enums.Elements("enum"))
                {
                    string? name = @enum.Attribute("name")?.Value;
                    string? valueStr = @enum.Attribute("value")?.Value;
                    if (valueStr == null || name == null)
                    {
                        throw new Exception($"Enum {name} did not pass correctly");
                    }

                    EnumSize size = ParseEnumTypeSuffix(@enum.Attribute("type")?.Value);

                    ulong value = ConvertToUInt64(valueStr, size);

                    string? alias = @enum.Attribute("alias")?.Value;

                    GroupRef[] groups = ParseGroups(@enum.Attribute("group")?.Value, currentFile, nameMangler);
                    // Mark this with all of the groups from the parent tag.
                    groups = ArrayUtil.MergeDeduplicate(groups, parentGroups);

                    string? enumComment = @enum.Attribute("comment")?.Value;

                    OutputApi api = ParseApi(@enum.Attribute("api")?.Value);
                    OutputApiFlags enumApi;
                    if (api == OutputApi.Invalid)
                    {
                        enumApi = currentFile switch
                        {
                            ApiFile.GL => OutputApiFlags.GL | OutputApiFlags.GLCompat | OutputApiFlags.GLES1 | OutputApiFlags.GLES2,
                            ApiFile.WGL => OutputApiFlags.WGL,
                            ApiFile.GLX => OutputApiFlags.GLX,
                            ApiFile.EGL => OutputApiFlags.EGL,

                            _ => throw new Exception(),
                        };
                    }
                    else 
                    {
                        enumApi = api switch
                        {
                            OutputApi.GL => OutputApiFlags.GL | OutputApiFlags.GLCompat,
                            OutputApi.GLES1 => OutputApiFlags.GLES1,
                            OutputApi.GLES2 => OutputApiFlags.GLES2,
                            OutputApi.WGL => OutputApiFlags.WGL,
                            OutputApi.GLX => OutputApiFlags.GLX,
                            OutputApi.EGL => OutputApiFlags.EGL,

                            OutputApi.Invalid => throw new Exception(),
                            _ => throw new Exception(),
                        };
                    }

                    foreach (var group in groups)
                    {
                        switch (group.Namespace)
                        {
                            case ApiFile.GL:
                                enumApi |= OutputApiFlags.GL | OutputApiFlags.GLCompat | OutputApiFlags.GLES1 | OutputApiFlags.GLES2;
                                break;
                            case ApiFile.WGL:
                                enumApi |= OutputApiFlags.WGL;
                                break;
                            case ApiFile.GLX:
                                enumApi |= OutputApiFlags.GLX;
                                break;
                            case ApiFile.EGL:
                                enumApi |= OutputApiFlags.EGL;
                                break;
                        }
                    }

                    enumsEntries.Add(new EnumEntry(nameMangler.MangleEnumName(name), name, value, enumApi, isFlags, vendor, alias, groups, size));
                }
            }

            return enumsEntries;

            static bool IsEnumTypeBitmask(string? value) => value switch
            {
                null or "" => false,
                "bitmask" => true,
                _ => throw new Exception(),
            };

            static EnumSize ParseEnumTypeSuffix(string? suffix) => suffix switch
            {
                // See https://github.com/KhronosGroup/OpenGL-Registry/blob/0dc24166d162723781f1bf9fe433f71fa03a7aa0/xml/readme.tex#L383
                // 2020-11-22
                null or "" => EnumSize.Int32,
                "u" => EnumSize.Uint32,
                "ull" => EnumSize.Uint64,
                _ => EnumSize.Invalid,
            };

            static ulong ConvertToUInt64(string val, EnumSize type)
            {
                if (val.StartsWith("EGL_CAST("))
                {
                    // FIXME: We could try to verify the type we are casting to here...
                    return (ulong)(long)new Int64Converter().ConvertFromString(val[(val.IndexOf(',')+1)..val.IndexOf(')')])!;
                }

                return type switch
                {
                    EnumSize.Int32 => (uint)(int)new Int32Converter().ConvertFromString(val)!,
                    EnumSize.Uint32 => (uint)new UInt32Converter().ConvertFromString(val)!,
                    EnumSize.Int64 => (ulong)new Int64Converter().ConvertFromString(val)!,
                    EnumSize.Uint64 => (ulong)new UInt64Converter().ConvertFromString(val)!,
                    EnumSize.Invalid or _ => throw new Exception($"Invalid suffix '{type}'!"),
                };
            }
        }

        internal static GroupRef[] ParseGroups(string? groups, ApiFile currentFile, NameMangler nameMangler)
        {
            if (groups == null) return [];

            string[] rawGroups = groups.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? [];
            List<GroupRef> groupRefs = new List<GroupRef>(rawGroups.Length);
            for (int i = 0; i < rawGroups.Length; i++)
            {
                GroupRef group = GroupRefFromString(rawGroups[i], currentFile, nameMangler);
                // FIXME: Make this a per file "ignorable" group...
                if (group.OriginalName == "SpecialNumbers")
                    continue;
                groupRefs.Add(group);
            }

            return groupRefs.ToArray();
        }

        internal static GroupRef GroupRefFromString(string group, ApiFile currentFile, NameMangler nameMangler)
        {
            string name;
            ApiFile file;
            if (group.StartsWith("gl::"))
            {
                name = NameMangler.RemoveStart(group, "gl::");
                file = ApiFile.GL;
            }
            else if (group.StartsWith("wgl::"))
            {
                name = NameMangler.RemoveStart(group, "wgl::");
                file = ApiFile.WGL;
            }
            else if (group.StartsWith("glx::"))
            {
                name = NameMangler.RemoveStart(group, "glx::");
                file = ApiFile.GLX;
            }
            else
            {
                name = group;
                file = currentFile;
            }

            string translatedName = nameMangler.TranslateEnumGroupName(name);

            return new GroupRef(name, translatedName, file);
        }


        internal static List<Feature> ParseFeatures(XElement input, List<string> ignoreFunctions)
        {
            Logger.Info("Begining parsing of features.");

            List<Feature> features = new List<Feature>();

            foreach (XElement? feature in input.Elements("feature"))
            {
                string? apiStr = feature.Attribute("api")?.Value;
                if (apiStr == "glsc2")
                    continue;
                string? name = feature.Attribute("name")?.Value;
                string? number = feature.Attribute("number")?.Value;

                if (apiStr == null || name == null || number == null)
                {
                    throw new Exception($"Feature '{feature}' is missing an attribute.");
                }

                Version? version = Version.Parse(number);
                OutputApi api = ParseApi(apiStr);

                List<RequireTag> requireEntries = new List<RequireTag>();
                foreach (XElement? require in feature.Elements("require"))
                {
                    RequireTag reqTag = ParseRequire(require, ignoreFunctions);
                    if (reqTag.Api == OutputApi.Invalid)
                        reqTag = reqTag with { Api = api };
                    requireEntries.Add(reqTag);
                }

                List<RemoveTag> removeEntries = new List<RemoveTag>();
                foreach (XElement? remove in feature.Elements("remove"))
                {
                    RemoveTag removeTag = ParseRemove(remove, ignoreFunctions);
                    removeEntries.Add(removeTag);
                }

                features.Add(new Feature()
                {
                    Name = name,
                    Version = version,
                    RequireTags = requireEntries,
                    DeprecateTags = [],
                    RemoveTags = removeEntries,

                    Api = api,
                });
            }

            return features;
        }

        internal static List<Extension> ParseExtensions(XElement input, NameMangler nameMangler, List<string> ignoreFunctions)
        {
            List<Extension> extensions = new List<Extension>();
            foreach (var exts in input.Elements("extensions"))
            {
                foreach (XElement? extension in exts.Elements("extension"))
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

                    OutputApi[]? supportedApis = extension
                        .Attribute("supported")?.Value?
                        .Split('|', StringSplitOptions.RemoveEmptyEntries)
                        .Where(s => s != "glcore" && s != "glsc2" && s != "disabled")
                        .Select(s => ParseApi(s)).ToArray();

                    if (supportedApis == null)
                    {
                        throw new Exception($"Extension '{extension}' did not specify any supported APIs.");
                    }

                    List<RequireTag> requires = new List<RequireTag>();
                    foreach (XElement? require in extension.Elements("require"))
                    {
                        RequireTag reqTag = ParseRequire(require, ignoreFunctions);
                        if (reqTag.Api == OutputApi.Invalid)
                        {
                            foreach (var api in supportedApis)
                            {
                                reqTag = reqTag with { Api = api };
                                requires.Add(reqTag);
                            }
                        }
                        else
                        {
                            requires.Add(reqTag);
                        }
                    }

                    extensions.Add(new Extension()
                    {
                        Name = extName,
                        RequireTags = requires,
                        DeprecateTags = [],
                        RemoveTags = [],

                        Comment = comment,

                        Vendor = vendor,
                        SupportedApis = supportedApis,
                    });
                }
            }


            return extensions;
        }

        internal static RequireTag ParseRequire(XElement requires, List<string> ignoreFunctions)
        {
            OutputApi api = ParseApi(requires.Attribute("api")?.Value);
            GLProfile profile = ParseProfile(requires.Attribute("profile")?.Value);
            string? comment = requires.Attribute("comment")?.Value;

            List<CommandRef> reqCommands = new List<CommandRef>();
            List<EnumRef> reqEnums = new List<EnumRef>();

            foreach (XElement? entry in requires.Elements())
            {
                // A few entries here have a comment attribute, but we don't bother with it
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");
                // GLX_EXTENSION_NAME is a string that we don't want to include.
                if (name == "GLX_EXTENSION_NAME")
                    continue;

                switch (entry.Name.LocalName)
                {
                    case "command":
                        if (ignoreFunctions.Contains(name))
                            continue;
                        reqCommands.Add(new CommandRef(name));
                        break;
                    case "enum":
                        reqEnums.Add(new EnumRef(name));
                        break;
                    case "type":
                        continue;
                    default:
                        throw new Exception();
                }
            }

            return new RequireTag()
            {
                Commands = reqCommands,
                Enums = reqEnums,
                Constants = [],

                Comment = comment,

                Api = api,
                GLProfile = profile,
            };
        }

        internal static RemoveTag ParseRemove(XElement requires, List<string> ignoreFunctions)
        {
            GLProfile profile = ParseProfile(requires.Attribute("profile")?.Value);
            string? comment = requires.Attribute("comment")?.Value;

            List<CommandRef> removeCommands = new List<CommandRef>();
            List<EnumRef> removeEnums = new List<EnumRef>();

            foreach (XElement? entry in requires.Elements())
            {
                // A few entries here have a comment attribute, but we don't bother with it
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");

                switch (entry.Name.LocalName)
                {
                    case "command":
                        if (ignoreFunctions.Contains(name))
                            continue;
                        removeCommands.Add(new CommandRef(name));
                        break;
                    case "enum":
                        removeEnums.Add(new EnumRef(name));
                        break;
                    default:
                        throw new Exception();
                }
            }

            //return new RemoveTag(profile, comment, removeCommands, removeEnums);
            return new RemoveTag()
            {
                Commands = removeCommands,
                Enums = removeEnums,
                Constants = [],

                Comment = comment,

                Profile = profile,
            };
        }

        internal static OutputApi ParseApi(string? api) => api switch
        {
            null or "" => OutputApi.Invalid,

            "gl" => OutputApi.GL,
            "gles1" => OutputApi.GLES1,
            "gles2" => OutputApi.GLES2,

            "wgl" => OutputApi.WGL,
            "glx" => OutputApi.GLX,
            "egl" => OutputApi.EGL,

            _ => OutputApi.Invalid,
        };

        internal static GLProfile ParseProfile(string? profile) => profile switch
        {
            null or "" => GLProfile.None,

            "core" => GLProfile.Core,
            "compatibility" => GLProfile.Compatibility,
            "common" => GLProfile.Common,

            _ => throw new Exception(),
        };
    }
}
