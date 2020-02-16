using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using OpenToolkit.Native;

namespace OpenToolkit.Core.Emitter
{
    public class APIBuilder
    {
        public static Assembly CreateAssembly(string name, Type type)
        {
            // We want to create a new assembly where we can add our own types.

            // TODO: Add RunAndSave thing to builder access so we can inspect the assembly in ildasm, ilspy, or similar
            AssemblyBuilder asmBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(name), AssemblyBuilderAccess.Run);
            ModuleBuilder modBuilder = asmBuilder.DefineDynamicModule(name + ".dll");

            var typeBuilder = modBuilder.DefineType(type.Name + ".X", TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.Class, type);

            var slots = CreateMethods(type, typeBuilder);
            CreateConstructor(type, typeBuilder, slots);

            return asmBuilder;
        }

        public static IReadOnlyList<string> CreateMethods(Type type, TypeBuilder builder)
        {
            // FIXME: Generator should come from somewhere!
            Generator gen = new Generator();

            List<string> slots = new List<string>();
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
            foreach (var method in methods)
            {
                if (method.IsAbstract == false)
                {
                    continue;
                }

                var attr = method.GetCustomAttribute<ApiAttribute>();

                var metBuilder = builder.DefineMethod(
                    method.Name,
                    MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig,
                    method.CallingConvention,
                    method.ReturnType,
                    method.ReturnParameter.GetRequiredCustomModifiers(),
                    method.ReturnParameter.GetOptionalCustomModifiers(),
                    method.GetParameters().Select(param => param.ParameterType).ToArray(),
                    method.GetParameters().Select(param => param.GetRequiredCustomModifiers()).ToArray(),
                    method.GetParameters().Select(param => param.GetOptionalCustomModifiers()).ToArray());

                var context = new MethodGenerationContext(CallingConvention.Cdecl, method, metBuilder, slots.Count, attr.Name);

                slots.Add(attr.Name);
                gen.GenerateMethod(context);
            }

            return slots;
        }

        public static void CreateConstructor(Type type, TypeBuilder builder, IReadOnlyList<string> slots)
        {
            var ctor = builder.DefineConstructor(MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, CallingConventions.Standard, null);
            var il = ctor.GetILGenerator();

            // FIXME: Generate constructor!

            il.Emit(OpCodes.Ret);
        }
    }
}
