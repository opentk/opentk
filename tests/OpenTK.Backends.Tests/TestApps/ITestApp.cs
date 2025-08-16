using System;
using System.Collections.Generic;
using System.Reflection;
using OpenTK.Platform;

namespace OpenTK.Backends.Tests
{
    /// <summary>
    /// Decorate a class with this attribute to automatically load it at run time.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class TestAppAttribute : Attribute
    {
        /// <summary>
        /// Load this as a test application at start up.
        /// </summary>
        public TestAppAttribute()
        {
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
        static abstract string Name { get; }

        /// <summary>
        /// Called once when the app is initialized.
        /// </summary>
        /// <param name="window">The window</param>
        /// <param name="context">The context</param>
        /// <param name="useGLES">If the app should render using OpenGL ES instead of OpeGL.</param>
        void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES);

        /// <summary>
        /// Called for every <see cref="WindowEventArgs"/> related to this window, and for
        /// window agnostic events.
        /// </summary>
        /// <param name="args">The event args.</param>
        void HandleEvent(EventArgs args);

        /// <summary>
        /// Update the application logic.
        /// </summary>
        /// <param name="deltaTime">The time since the last call to Update.</param>
        /// <returns>If the application should quit.</returns>
        bool Update(float deltaTime);

        /// <summary>
        /// Render the application view.
        /// </summary>
        void Render();

        /// <summary>
        /// Called once when the app is exiting.
        /// </summary>
        void Deinitialize();
    }

    /// <summary>
    /// Manager class for test applications.
    /// </summary>
    public static class TestApps
    {
        /// <summary>
        /// All loaded test apps.
        /// </summary>
        public static readonly List<Type> All = new List<Type>();

        static TestApps()
        {
            foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type t in asm.DefinedTypes)
                {
                    TestAppAttribute? attrib = t.GetCustomAttribute<TestAppAttribute>();

                    if (attrib == null)
                        continue;

                    All.Add(t);
                }
            }
        }

        /// <summary>
        /// Create a test app instance.
        /// </summary>
        /// <param name="index">The index of the app.</param>
        /// <returns>A test app.</returns>
        public static ITestApp Create(int index)
        {
            return (ITestApp)Activator.CreateInstance(All[index])!;
        }
    }
}
