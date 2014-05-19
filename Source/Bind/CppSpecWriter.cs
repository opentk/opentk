#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Bind.Structures;

namespace Bind
{
    using Delegate = Bind.Structures.Delegate;
    using Enum = Bind.Structures.Enum;
    using Type = Bind.Structures.Type;

    sealed class CppSpecWriter : ISpecWriter
    {
        const string AllowDeprecated = "GLPP_COMPATIBLE";
        const string DigitPrefix = "T"; // Prefix for identifiers that start with a digit
        const string OutputFileHeader = "gl++.h";

        IBind Generator { get; set; }
        Settings Settings { get { return Generator.Settings; } }

        #region Verbatim parts of output file

        const string GetAddressDefinition = @"
    namespace Internals
    {
        #if defined(_WIN32)
        extern ""C""
        {
           #define GLPP_APIENTRY __stdcall
            typedef int (*PROC)();
            extern void* __stdcall wglGetCurrentContext();
            extern PROC __stdcall wglGetProcAddress(const char *procname);
            extern void* __stdcall LoadLibraryA(const char *libname);
            extern PROC __stdcall GetProcAddress(void *module, const char *procname);
        }
        inline void*& LoadGLAddress()
        {
            static void* address = LoadLibraryA(""opengl32.dll"");
            return address;
        }
        inline void*& GetGLAddress()
        {
            static void* address = LoadGLAddress();
            return address;
        }
        inline PROC winGetAddress(const char *procname)
        {
            PROC addr = GetProcAddress(GetGLAddress(), procname);
            return addr ? addr : wglGetProcAddress(procname);
        }

        #elif !defined(__APPLE__)
        extern ""C""
        {
            #define GLPP_APIENTRY
            extern void* glXGetCurrentContext();
            extern void (*glXGetProcAddress(const char *procname))();
        }
        #endif

        #if defined(__APPLE__)
            #define GLPP_APIENTRY
            #include <stdlib.h>
            #include <string.h>
            #include <AvailabilityMacros.h>

            extern ""C"" void* CGLGetCurrentContext();

            #ifdef MAC_OS_X_VERSION_10_3
                #include <dlfcn.h>
                inline void* NSGLGetProcAddress(const char *name)
                {
                  static void* image = NULL;
                  if (NULL == image)
                  {
                    image = dlopen(""/System/Library/Frameworks/OpenGL.framework/Versions/Current/OpenGL"", RTLD_LAZY);
                  }
                  return image ? dlsym(image, (const char*)name) : NULL;
                }
            #else
                #include <mach-o/dyld.h>
                inline void* NSGLGetProcAddress(const char *name)
                {
                  static const struct mach_header* image = NULL;
                  NSSymbol symbol;
                  char* symbolName;
                  if (NULL == image)
                  {
                    image = NSAddImage(""/System/Library/Frameworks/OpenGL.framework/Versions/Current/OpenGL"", NSADDIMAGE_OPTION_RETURN_ON_ERROR);
                  }
                  // prepend a '_' for the Unix C symbol mangling convention
                  symbolName = malloc(strlen((const char*)name) + 2);
                  strcpy(symbolName+1, (const char*)name);
                  symbolName[0] = '_';
                  symbol = NULL;
                  symbol = image ? NSLookupSymbolInImage(image, symbolName, NSLOOKUPSYMBOLINIMAGE_OPTION_BIND | NSLOOKUPSYMBOLINIMAGE_OPTION_RETURN_ON_ERROR) : NULL;
                  free(symbolName);
                  return symbol ? NSAddressOfSymbol(symbol) : NULL;
                }
            #endif /* MAC_OS_X_VERSION_10_3 */
        #endif /* __APPLE__ */

        #if defined(__sgi) || defined (__sun)
            #define GLPP_APIENTRY
            #include <dlfcn.h>
            #include <stdio.h>
            #include <stdlib.h>
            inline void* LoadSymbol(const char *name)
            {
                // dlopen what?
                if ((void *h = dlopen(NULL, RTLD_LAZY | RTLD_LOCAL)) == NULL) return NULL;
                return dlsym(h, ""glXGetProcAddress"");
            }
            inline void* dlGetProcAddress(const char *name)
            {
                static void* gpa = LoadSymbol(""glXGetProcAddress"");

                if (gpa != NULL)
                    return ((void*(*)(const char*))gpa)(name);
                else
                    return dlsym(h, (const char*)name);
            }
            inline void* dlGetCurrentContext()
            {
                static void* gpa = LoadSymbol(""glXGetProcAddress"");

                if (gpa != NULL)
                    return ((void*(*)())gpa)();

                return NULL;
            }
        #endif /* __sgi || __sun */

        inline void* GetAddress(const char* name)
        {
        #if defined(_WIN32)
            return (void*)winGetAddress(name);
        #elif defined(__APPLE__)
            return (void*)NSGLGetProcAddress(name);
        #elif defined(__sgi) || defined(__sun)
            return (void*)dlGetProcAddress(name);
        #else
            return (void*)glXGetProcAddress((const char*)name);
        #endif
        }

        inline void* GetCurrentContext()
        {
        #if defined(_WIN32)
            return wglGetCurrentContext();
        #elif defined(__APPLE__)
            return CGLGetCurrentContext();
        #elif defined(__sgi) || defined(__sun)
            return dlGetCurrentContext();
        #else
            return glXGetCurrentContext();
        #endif
        }
    }
         ";

        const string TypeDefinitions = @"
    template<typename T>
    struct Enumeration
    {
    private:
        int value;

    public:
        inline Enumeration(int value)
        {
            this->value = value;
        }

        inline operator int() const
        {
            return value;
        }
    };

    typedef unsigned int GLenum;
    typedef unsigned int GLbitfield;
    typedef int GLsizei; // size_t
    typedef bool GLboolean;
    typedef signed char GLbyte;
    typedef unsigned char GLubyte;
    typedef short GLshort;
    typedef unsigned short GLushort;
    typedef int GLint;
    typedef unsigned int GLuint;
    typedef long GLlong;
    typedef unsigned long GLulong;
    typedef float GLfloat;
    typedef float GLclampf;
    typedef double GLdouble;
    typedef double GLclampd;
    typedef void GLvoid;
    typedef GLint* GLintptr;
    typedef GLsizei* GLsizeiptr;

typedef const char* GLstring;
    #if defined(_MSC_VER) && _MSC_VER < 1400
        typedef __int64 GLint64EXT;
        typedef unsigned __int64 GLuint64EXT;
    #else
        typedef signed long long GLint64EXT;
        typedef unsigned long long GLuint64EXT;
    #endif
    typedef GLint64EXT  GLint64;
    typedef GLuint64EXT GLuint64;
    typedef struct __GLsync { } *GLsync;
    typedef struct __GLhandleARB { } *GLhandleARB;
    typedef GLintptr GLintptrARB;
    typedef GLsizeiptr GLsizeiptrARB;

    typedef char GLchar;
    typedef void (*GLDEBUGPROCAMD)(GLuint id,
        GLenum category, GLenum severity, GLsizei length,
        const GLchar* message, GLvoid* userParam);

    /* For ARB_debug_output */

    typedef void (*GLDEBUGPROCARB)(GLenum source,
        GLenum type, GLuint id, GLenum severity,
        GLsizei length, const GLchar* message, GLvoid* userParam);

    /* For GL_ARB_cl_event */

    typedef struct cl_context *_cl_context;
    typedef struct cl_event *_cl_event;

    //typedef GLsizei IntPtr;
    typedef void* IntPtr;
    typedef GLbyte SByte;
    typedef GLubyte Byte;
    typedef GLshort Int16;
    typedef GLushort UInt16;
    typedef GLint Int32;
    typedef GLuint UInt32;
    typedef GLlong Int64;
    typedef GLulong UInt64;
    typedef GLfloat Single;
    typedef GLdouble Double;
    typedef GLstring String;
    typedef char* StringBuilder;
    typedef GLDEBUGPROCAMD DebugProcAmd;
    typedef GLDEBUGPROCARB DebugProcArb;
    typedef struct _GLvdpauSurfaceNV *GLvdpauSurfaceNV;

    struct Half
    {
    private:
        GLushort value;
    public:
    };
    typedef Half GLhalf;
    typedef GLhalf GLhalfNV;
";

        #endregion

        BindStreamWriter sw_h = new BindStreamWriter(Path.GetTempFileName());

        #region WriteBindings

        public void WriteBindings(IBind generator)
        {
            Generator = generator;
            WriteBindings(generator.Delegates, generator.Wrappers, generator.Enums);
        }

        void WriteBindings(DelegateCollection delegates, FunctionCollection wrappers, EnumCollection enums)
        {
            Console.WriteLine("Writing bindings to {0}", Settings.OutputPath);
            if (!Directory.Exists(Settings.OutputPath))
                Directory.CreateDirectory(Settings.OutputPath);

            // Hack: Fix 3dfx extension category so it doesn't start with a digit
            if (wrappers.ContainsKey("3dfx"))
            {
                var three_dee_fx = wrappers["3dfx"];
                wrappers.Remove("3dfx");
                wrappers.Add(DigitPrefix + "3dfx", three_dee_fx);
            }

            Settings.DefaultOutputNamespace = "OpenTK";

            using (var sw = sw_h)
            {
                sw.WriteLine("#pragma once");
                sw.WriteLine("#ifndef GLPP_H");
                sw.WriteLine("#define GLPP_H");
                sw.WriteLine();

                WriteLicense(sw);

                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");
                sw.Indent();

                WriteGetAddress(sw);
                WriteTypes(sw);
                WriteEnums(sw, enums);
                WriteDefinitions(sw, enums, wrappers, Generator.CSTypes); // Core definitions

                sw.Unindent();
                sw.WriteLine("}");

                sw.WriteLine("#endif");

                sw.Flush();
                sw.Close();
            }

            string output_header = Path.Combine(Settings.OutputPath, OutputFileHeader);
            Move(sw_h.File, output_header);
        }

        void Move(string file, string dest)
        {
            if (File.Exists(dest))
                File.Delete(dest);
            File.Move(file, dest);
        }

        static Delegate WriteWrapper(Delegate last_delegate, Function f, BindStreamWriter sw)
        {
            //if (last_delegate == f.WrappedDelegate)
            //    return last_delegate; // Multiple wrappers for the same delegate are not necessary in C++
            
            var valid = true;
            var parameters = GenerateParameterString(f, true, out valid);
            if (!valid)
                return last_delegate;

            last_delegate = f.WrappedDelegate;

            sw.WriteLine("inline {0} {1}({2})", f.WrappedDelegate.ReturnType,
                f.TrimmedName, parameters);
            sw.WriteLine("{");
            sw.Indent();
            WriteMethodBody(sw, f);
            sw.Unindent();
            sw.WriteLine("}");
            return last_delegate;
        }

        static string GenerateParameterString(Delegate d, bool check_validity, out bool valid)
        {
            if (d == null)
                throw new ArgumentNullException("d");

            valid = true;
            var sb = new StringBuilder();

            if (d.Parameters.Count > 0)
            {
                foreach (var p in d.Parameters)
                {
                    if (p.CurrentType.ToLower() == "string[]")
                        p.CurrentType = "char**";
                    if (p.CurrentType.ToLower() == "string")
                        p.CurrentType = "char*";

                    if (p.Reference)
                    {
                       if (/*check_validity &&*/ p.Generic)
                        {
                            // We don't need generic parameters in C++ and void& is illegal.
                            valid = false;
                            return String.Empty;
                        }

                        if (p.Flow != FlowDirection.Out)
                            sb.Append("const ");
                        sb.Append(p.QualifiedType);
                        sb.Append('*', p.Array);
                        sb.Append("&");
                    }
                    else if (p.Array > 0)
                    {
                        // Hack: generic parameters with array types are
                        // not real (i.e. they are created by the generator
                        // specifically for managed languages). We don't
                        // need them in C++.
                        // Todo: move C#/Java-specific code to their respective
                        // classes, instead of the main generator.
                        // Note: the 1-dimensional array is handled through the pointer case below.
                        // (C# differentiates between arrays and pointers, C++ doesn't).
                        if (check_validity && (p.Generic || p.Array == 1))
                        {
                            valid = false;
                            return String.Empty;
                        }

                        if (p.Flow != FlowDirection.Out)
                            sb.Append("const ");
                        sb.Append(p.Generic ? "void" : p.QualifiedType); // We don't need generic parameters in C++.
                        sb.Append('*', p.Array);
                    }
                    else if (p.Pointer > 0)
                    {
                        if (p.Flow != FlowDirection.Out)
                            sb.Append("const ");
                        sb.Append(p.Generic ? "void" : p.QualifiedType); // We don't need generic parameters in C++.
                        sb.Append('*', p.Pointer);
                    }
                    else if (p.CurrentType == "IntPtr")
                    {
                        if (p.Flow != FlowDirection.Out)
                            sb.Append("const ");
                        sb.Append("void*");
                    }
                    else
                    {
                        sb.Append(p.QualifiedType);
                    }

                    sb.Append(" ");
                    sb.Append(p.Name);
                    sb.Append(", ");
                }

                if (d.Parameters.Count > 0)
                    sb.Remove(sb.Length - 2, 2);
            }

            return sb.ToString();
        }

        static Delegate WriteInitDelegate(Delegate last_delegate, BindStreamWriter sw, Function f)
        {
            if (last_delegate != f.WrappedDelegate)
            {
                sw.WriteLine("Delegates::{0}() = (Delegates::p{0})OpenTK::Internals::GetAddress(\"gl{0}\");", f.WrappedDelegate.Name);
                last_delegate = f.WrappedDelegate;
            }
            return last_delegate;
        }

        #endregion

        #region WriteDefinitions

        void WriteDefinitions(BindStreamWriter sw,
            EnumCollection enums, FunctionCollection wrappers,
            IDictionary<string, string> CSTypes)
        {
            sw.WriteLine("namespace {0}", Settings.GLClass);
            sw.WriteLine("{");
            sw.Indent();

            foreach (string extension in wrappers.Keys)
            {
                if (extension != "Core")
                {
                    sw.WriteLine("namespace {0}", extension);
                    sw.WriteLine("{");
                    sw.Indent();
                }

                // Avoid multiple definitions of the same function
                Delegate last_delegate = null;

                // Write delegates
                sw.WriteLine("namespace Delegates");
                sw.WriteLine("{");
                sw.Indent();
                var functions = wrappers[extension];
                last_delegate = null;
                foreach (var f in functions.Where(f => !f.Deprecated))
                {
                    WriteDelegate(sw, f.WrappedDelegate, ref last_delegate);
                }
                last_delegate = null;
                sw.WriteLine("#if defined({0})", AllowDeprecated);
                foreach (var f in functions.Where(f => f.Deprecated))
                {
                    WriteDelegate(sw, f.WrappedDelegate, ref last_delegate);
                }
                sw.WriteLine("#endif");

                sw.Unindent();
                sw.WriteLine("};");

                // Write wrappers
                sw.WriteLine("inline void Init()");
                sw.WriteLine("{");
                sw.Indent();
                last_delegate = null;
                foreach (var f in functions.Where(f => !f.Deprecated))
                {
                    last_delegate = WriteInitDelegate(last_delegate, sw, f);
                }
                last_delegate = null;
                sw.WriteLine("#if defined({0})", AllowDeprecated);
                foreach (var f in functions.Where(f => f.Deprecated))
                {
                    last_delegate = WriteInitDelegate(last_delegate, sw, f);
                }
                sw.WriteLine("#endif");
                sw.Unindent();
                sw.WriteLine("}");
                last_delegate = null;
                foreach (var f in functions.Where(f => !f.Deprecated))
                {
                    last_delegate = WriteWrapper(last_delegate, f, sw);
                }
                sw.WriteLine("#if defined({0})", AllowDeprecated);
                foreach (var f in functions.Where(f => f.Deprecated))
                {
                    last_delegate = WriteWrapper(last_delegate, f, sw);
                }
                sw.WriteLine("#endif");

                if (extension != "Core")
                {
                    sw.Unindent();
                    sw.WriteLine("};");
                }
            }

            sw.Unindent();
            sw.WriteLine("};");
        }

        #endregion

        string GetNamespace(string ext)
        {
            if (ext == "Core")
                return Settings.GLClass;
            else
                return String.Format("{0}::{1}", Settings.GLClass, Char.IsDigit(ext[0]) ? DigitPrefix + ext : ext);
        }

        #region WriteEnums

        public void WriteEnums(BindStreamWriter sw, EnumCollection enums)
        {
            foreach (Enum @enum in enums.Values)
            {
                sw.WriteLine("struct {0} : Enumeration<{0}>", @enum.Name);
                sw.WriteLine("{");
                sw.Indent();
                sw.WriteLine("inline {0}(int value) : Enumeration<{0}>(value) {{ }}", @enum.Name);
                sw.WriteLine("enum");
                sw.WriteLine("{");
                sw.Indent();
                foreach (var c in @enum.ConstantCollection.Values)
                {
                    sw.WriteLine(String.Format("{0} = {1}{2},",
                        c.Name,
                        !String.IsNullOrEmpty(c.Reference) ? (c.Reference + Settings.NamespaceSeparator) : "",
                        !String.IsNullOrEmpty(c.Reference) ? c.Value : c.Value.ToLower()));
                }
                sw.Unindent();
                sw.WriteLine("};");
                sw.Unindent();
                sw.WriteLine("};");
                sw.WriteLine();
            }
        }

        #endregion

        #region WriteTypes

        void WriteTypes(BindStreamWriter sw)
        {
            sw.WriteLine(TypeDefinitions);
        }

        #endregion

        #region WriteGetAddress

        void WriteGetAddress(BindStreamWriter sw)
        {
            sw.WriteLine(GetAddressDefinition);
        }

        #endregion

        #region WriteDelegate

        static void WriteDelegate(BindStreamWriter sw, Delegate d, ref Delegate last_delegate)
        {
            // Avoid multiple definitions of the same function
            if (d != last_delegate)
            {
                last_delegate = d;
                bool valid = true;
                var parameters = GenerateParameterString(d, false, out valid);
                sw.WriteLine("typedef {0} (GLPP_APIENTRY *p{1})({2});", d.ReturnType, d.Name, parameters);
                sw.WriteLine("inline p{0}& {0}()", d.Name);
                sw.WriteLine("{");
                sw.Indent();
                sw.WriteLine("static p{0} address = 0;", d.Name);
                sw.WriteLine("return address;");
                sw.Unindent();
                sw.WriteLine("}");
            }
        }

        #endregion

        #region WriteWrappers

        static void WriteMethodBody(BindStreamWriter sw, Function f)
        {
            //var callstring = f.Parameters.CallString()
            //    .Replace("String[]", "String*");

            var callstring = GenerateCallString(f);

            if (f.ReturnType != null && !f.ReturnType.ToString().ToLower().Contains("void"))
                sw.Write("return ");
            sw.WriteLine("Delegates::{0}()({1});", f.WrappedDelegate.Name, callstring);
        }

        static object GenerateCallString(Function f)
        {
            var sb = new StringBuilder();
            foreach (var p in f.Parameters)
            {
                if (p.Reference)
                    sb.Append("&"); // Convert to pointer
                sb.Append(p.Name);
                sb.Append(", ");
            }
            if (f.Parameters.Count > 0)
                sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

        void WriteDocumentation(BindStreamWriter sw, Function f)
        {
            var docs = f.Documentation;

            try
            {
                string warning = "[deprecated: v{0}]";
                string category = "[requires: {0}]";
                if (f.Deprecated)
                {
                    warning = String.Format(warning, f.DeprecatedVersion);
                    docs.Summary = docs.Summary.Insert(0, warning);
                }

                if (f.Extension != "Core" && !String.IsNullOrEmpty(f.Category))
                {
                    category = String.Format(category, f.Category);
                    docs.Summary = docs.Summary.Insert(0, category);
                }
                else if (!String.IsNullOrEmpty(f.Version))
                {
                    if (f.Category.StartsWith("VERSION"))
                        category = String.Format(category, "v" + f.Version);
                    else
                        category = String.Format(category, "v" + f.Version + " and " + f.Category);
                    docs.Summary = docs.Summary.Insert(0, category);
                }

                for (int i = 0; i < f.WrappedDelegate.Parameters.Count; i++)
                {
                    var param = f.WrappedDelegate.Parameters[i];
                    if (param.ComputeSize != String.Empty)
                    {
                        docs.Parameters[i].Documentation.Insert(0,
                            String.Format("[length: {0}]", param.ComputeSize));
                    }
                }

                sw.Write("/// \brief ");
                sw.WriteLine(docs.Summary);
                foreach (var p in docs.Parameters)
                {
                    sw.Write(@"/// \param ");
                    sw.Write(p.Name);
                    sw.WriteLine(p.Documentation);
                }
            }
            catch (Exception e)
            {
            Console.WriteLine("[Warning] Error documenting function {0}: {1}", f.WrappedDelegate.Name, e.ToString());
            }
        }

        #endregion

        #region WriteLicense

        public void WriteLicense(BindStreamWriter sw)
        {
            sw.WriteLine(File.ReadAllText(Path.Combine(Settings.InputPath, Settings.LicenseFile)));
            sw.WriteLine();
        }

        #endregion
    }
}
