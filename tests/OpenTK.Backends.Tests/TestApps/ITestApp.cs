using System;
using System.Collections.Generic;
using System.Reflection;
using OpenTK.Core.Platform;

namespace OpenTK.Backends.Tests
{
    /// <summary>
    /// Decorate a class with this attribute to automatically load it at run time.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class TestAppAttribute : Attribute
    {
        /// <summary>
        /// The name of the test app in UI.
        /// </summary>
        public readonly string UIName;

        /// <summary>
        /// Load this as a test application at start up.
        /// </summary>
        /// <param name="uiName">Name of the app in UI.</param>
        public TestAppAttribute(string uiName)
        {
            UIName = uiName;
        }
    }

    /// <summary>
    /// Interface for UI test application.
    /// </summary>
    public interface ITestApp
    {
        /// <summary>
        /// Name of the application.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Called once when the app is initialized.
        /// </summary>
        /// <param name="window">The window</param>
        /// <param name="context">The context</param>
        void Initialize(WindowHandle window, OpenGLContextHandle context);

        /// <summary>
        /// Called once when the app is exiting.
        /// </summary>
        /// <param name="cleanExit">True to cleanly exit, destroying context objects.</param>
        void Deinitialize(bool cleanExit);

        /// <summary>
        /// Render the application view.
        /// </summary>
        void Render();
    }

    /// <summary>
    /// Manager class for test applications.
    /// </summary>
    public static class TestApps
    {
        static readonly List<Type> all = new List<Type>();
        static readonly Dictionary<string, Type> byName = new Dictionary<string, Type>();

        /// <summary>
        /// All loaded test apps.
        /// </summary>
        public static IReadOnlyList<Type> All => all;
        /// <summary>
        /// All loaded test apps by name.
        /// </summary>
        public static IReadOnlyDictionary<string, Type> ByName => byName;

        static TestApps()
        {
            foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                AddAssembly(asm);
            }
        }

        /// <summary>
        /// Add an assembly to the test app collection.
        /// </summary>
        /// <param name="asm">The assembly to scan.</param>
        public static void AddAssembly(Assembly asm)
        {
            foreach (Type t in asm.ExportedTypes)
            {
                TestAppAttribute? attrib = t.GetCustomAttribute<TestAppAttribute>();

                if (attrib == null)
                    continue;

                AddType(t);
            }
        }

        /// <summary>
        /// Add a type to the test app collection.
        /// </summary>
        /// <typeparam name="T">The type to add.</typeparam>
        public static void AddType<T>() where T : ITestApp
        {
            AddType(typeof(T));
        }

        /// <summary>
        /// Add a type to the test app collection.
        /// </summary>
        /// <param name="t">The type to add.</param>
        public static void AddType(Type t)
        {
            TestAppAttribute? attrib = t.GetCustomAttribute<TestAppAttribute>();
            all.Add(t);
            byName.Add(attrib?.UIName ?? t.Name, t);
        }

        /// <summary>
        /// Create a test app instance.
        /// </summary>
        /// <param name="t">The type to create.</param>
        /// <returns>A test app.</returns>
        /// <remarks>
        /// * <paramref name="t"/> must implement ITestApp and have a parameterless constructor.s
        /// </remarks>
        public static ITestApp Create(Type t)
        {
            return
                (t.GetConstructor(Array.Empty<Type>())?.Invoke(null) as ITestApp)
                ?? throw new Exception("No suitable constructor found");
        }

        /// <summary>
        /// Create a test app instance.
        /// </summary>
        /// <param name="index">The index of the app.</param>
        /// <returns>A test app.</returns>
        public static ITestApp Create(int index)
        {
            return Create(all[index]);
        }

        /// <summary>
        /// Create a test app instance.
        /// </summary>
        /// <param name="name">Name of the app.</param>
        /// <returns>A test app.</returns>
        public static ITestApp Create(string name)
        {
            return Create(byName[name]);
        }
    }
}