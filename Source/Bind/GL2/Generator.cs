using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;
using System.Diagnostics;

namespace Bind.GL2
{
    class Generator : IBind
    {
        internal static SpecReader specReader;
        internal static SpecWriter specWriter;

        string specFolder;

        public Generator(string folder)
        {
            specFolder = folder;
            specReader = new GL2.SpecReader();
            specWriter = new GL2.SpecWriter();
        }

        #region IBind Members

        #region public void Process()

        public void Process()
        {
            Bind.Structures.Type.Initialize();
            Bind.Structures.Enum.Initialize();
            Bind.Structures.Function.Initialize();
            Bind.Structures.Delegate.Initialize();

            // Process enums and delegates - create wrappers.
            this.Translate();

            // Write
            using (BindStreamWriter sw = new BindStreamWriter(Path.Combine(Settings.OutputPath, "GLEnums.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");
                
                sw.Indent();
                sw.WriteLine("public static partial class {0}", Settings.GLClass);
                sw.WriteLine("{");
                
                sw.Indent();
                specWriter.WriteEnums(sw, Bind.Structures.Enum.GLEnums);
                sw.Unindent();

                sw.WriteLine("}");
                sw.Unindent();

                sw.WriteLine("}");
            }
            using (BindStreamWriter sw = new BindStreamWriter(Path.Combine(Settings.OutputPath, "GLDelegates.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");

                sw.Indent();
                //specWriter.WriteTypes(sw, Bind.Structures.Type.CSTypes);
                sw.WriteLine("using System;");
                sw.WriteLine("using System.Runtime.InteropServices;");
                specWriter.WriteDelegates(sw, Bind.Structures.Delegate.Delegates);
                sw.Unindent();

                sw.WriteLine("}");
            }
            using (BindStreamWriter sw = new BindStreamWriter(Path.Combine(Settings.OutputPath, "GLCore.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");

                sw.Indent();
                //specWriter.WriteTypes(sw, Bind.Structures.Type.CSTypes);
                sw.WriteLine("using System;");
                sw.WriteLine("using System.Runtime.InteropServices;");
                specWriter.WriteImports(sw, Bind.Structures.Delegate.Delegates);
                sw.Unindent();

                sw.WriteLine("}");
            }
            using (BindStreamWriter sw = new BindStreamWriter(Path.Combine(Settings.OutputPath, "GL.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");

                sw.Indent();
                //specWriter.WriteTypes(sw, Bind.Structures.Type.CSTypes);
                sw.WriteLine("using System;");
                sw.WriteLine("using System.Runtime.InteropServices;");
                specWriter.WriteWrappers(sw, Bind.Structures.Function.Wrappers, Bind.Structures.Type.CSTypes);
                sw.Unindent();

                sw.WriteLine("}");
            }
        }

        #endregion

        #endregion

        #region private void Translate()

        private void Translate()
        {
            foreach (Bind.Structures.Enum e in Bind.Structures.Enum.GLEnums.Values)
            {
                TranslateEnum(e);
            }

            foreach (Bind.Structures.Delegate d in Bind.Structures.Delegate.Delegates.Values)
            {
                //wrappers.AddRange(d.CreateWrappers());

            }
        }

        #endregion

        #region private void TranslateEnum(Bind.Structures.Enum e)

        private void TranslateEnum(Bind.Structures.Enum e)
        {
            foreach (Constant c in e.ConstantCollection.Values)
            {
                // There are cases when a value is an aliased constant, with no enum specified.
                // (e.g. FOG_COORD_ARRAY_TYPE = GL_FOG_COORDINATE_ARRAY_TYPE)
                // In this case try searching all enums for the correct constant to alias (stupid opengl specs).
                if (String.IsNullOrEmpty(c.Reference) && !Char.IsDigit(c.Value[0]))
                {
                    foreach (Bind.Structures.Enum @enum in Bind.Structures.Enum.GLEnums.Values)
                    {
                        // Skip generic GLenum
                        if (@enum.Name == "GLenum")
                            continue;

                        if (@enum.ConstantCollection.ContainsKey(c.Value))
                        {
                            c.Reference = @enum.Name;
                        }
                    }
                }
            }
        }

        #endregion

        #region ISpecReader Members

        public DelegateCollection ReadDelegates(StreamReader specFile)
        {
            return specReader.ReadDelegates(specFile);
        }

        public EnumCollection ReadEnums(StreamReader specFile)
        {
            return specReader.ReadEnums(specFile);
        }

        public Dictionary<string, string> ReadTypeMap(StreamReader specFile)
        {
            return specReader.ReadTypeMap(specFile);
        }

        public Dictionary<string, string> ReadCSTypeMap(StreamReader specFile)
        {
            return specReader.ReadCSTypeMap(specFile);
        }

        #endregion

        #region ISpecWriter Members

        public void WriteDelegates(BindStreamWriter sw, DelegateCollection delegates)
        {
            specWriter.WriteDelegates(sw, delegates);
        }

        public void WriteWrappers(BindStreamWriter sw, FunctionCollection wrappers, Dictionary<string, string> CSTypes)
        {
            specWriter.WriteWrappers(sw, wrappers, CSTypes);
        }

        public void WriteEnums(BindStreamWriter sw, EnumCollection enums)
        {
            specWriter.WriteEnums(sw, enums);
        }

        public void WriteTypes(BindStreamWriter sw, Dictionary<string, string> CSTypes)
        {
            specWriter.WriteTypes(sw, CSTypes);
        }

        #endregion
    }
}
