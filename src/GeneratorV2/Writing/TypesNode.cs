using GeneratorV2.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Writing
{
    public class TypesNode : WriterNode
    {
        public TypesNode()
        {
        }

        public override void Write()
        {
            Writer.WriteLine("public unsafe delegate void GLDEBUGPROC(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
            Writer.WriteLine("public unsafe delegate void GLDEBUGPROCARB(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
            Writer.WriteLine("public unsafe delegate void GLDEBUGPROCKHR(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
            Writer.WriteLine("public unsafe delegate void GLDEBUGPROCAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);");
            Writer.WriteLine("public unsafe delegate void GLDEBUGPROCNV();");
            Writer.WriteLine("public struct CLContext{}");
            Writer.WriteLine("public struct CLEvent{}");
            Writer.WriteLine("public struct GLsync{}");
            Writer.WriteLine("public unsafe struct GLsyncObject");
            using (Writer.Scope())
            {
                Writer.WriteLine("internal GLsync* ObjPtr;");
                Writer.WriteLine("internal GLsyncObject(GLsync* syncObject)");
                using (Writer.Scope())
                {
                    Writer.WriteLine("ObjPtr = syncObject;");
                }

                Writer.WriteLine("public static implicit operator GLsync*(GLsyncObject obj) => obj.ObjPtr;");
                Writer.WriteLine("public static implicit operator GLsyncObject(GLsync* obj) => new GLsyncObject(obj);");
            }

            //GLhandleArb
            Writer.WriteLine("public struct GLhandleARB");
            using (Writer.Scope())
            {
                Writer.WriteLine("private readonly uint _value1;");
                Writer.WriteLine("private readonly IntPtr _value2;");
                Writer.WriteLine("public GLhandleARB(uint val)");
                using (Writer.Scope())
                {
                    Writer.WriteLine("_value2 = IntPtr.Zero;");
                    Writer.WriteLine("_value1 = val;");
                }
                Writer.WriteLine("public GLhandleARB(IntPtr val)");
                using (Writer.Scope())
                {
                    Writer.WriteLine("_value1 = 0;");
                    Writer.WriteLine("_value2 = val;");
                }
                Writer.WriteLine("public static implicit operator GLhandleARB(uint val) => new GLhandleARB(val);");
                Writer.WriteLine("public static implicit operator GLhandleARB(IntPtr val) => new GLhandleARB(val);");
                Writer.WriteLine("public static implicit operator uint(GLhandleARB val) => val._value1;");
                Writer.WriteLine("public static implicit operator IntPtr(GLhandleARB val) => val._value2;");
            }
        }
    }
}
