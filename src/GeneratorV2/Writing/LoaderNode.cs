using GeneratorV2.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorV2.Writing
{
    public class LoaderNode : WriterNode
    {
        public LoaderNode() : base(null)
        {

        }

        public override void Write()
        {
            Writer.WriteLine("internal static object LockObj = new object();");
            Writer.WriteLine("private static IBindingsContext? _bindingsContext;");
            Writer.WriteLine("internal static IBindingsContext BindingsContext");
            //using (IndentationExtension.Indentation(Writer))
            {
                Writer.WriteLine("=> _bindingsContext ?? throw new Exception(\"Bindings not loaded, load with GLLoader.LoadBindings\");");
            }

            Writer.WriteLine("public static void LoadBindings(IBindingsContext c)");
            //using (IndentationExtension.Indentation(Writer))
            {
                Writer.WriteLine("=> _bindingsContext = c;");
            }
        }
    }
}
