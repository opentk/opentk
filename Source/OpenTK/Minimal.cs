using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    // Override a number of System.* classes when compiling for
    // minimal targets (e.g. MonoTouch).
    // Note: the "overriden" classes must not be fully qualified for this to work!

#if IPHONE
    // System.Diagnostics.Debug
    static class Debug
    {
        public static void Write(string message) { }
        public static void Write(object obj) { }
        public static void WriteLine(string message) { }
        public static void WriteLine(object obj) { }
        public static void Print(string message) { }
        public static void Print(string format, params object[] args) { }
        public static void Indent() { }
        public static void Unindent() { }
        public static void Flush() { }
    }

    // System.Diagnostics.Trace
    static class Trace
    {
        public static void Write(string message) { }
        public static void Write(object obj) { }
        public static void WriteLine(string message) { }
        public static void WriteLine(object obj) { }
        public static void Indent() { }
        public static void Unindent() { }
        public static void Flush() { }
    }

    // System.Diagnostics.Stopwatch
    sealed class Stopwatch
    {
        DateTime start, stop;
        bool running;

        public void Reset()
        {
            start = stop = DateTime.MinValue;
            running = false;
        }

        public void Start()
        {
            start = DateTime.Now;
            running = true;
        }

        public void Stop()
        {
            stop = DateTime.Now;
            running = false;
        }

        public TimeSpan Elapsed
        {
            get
            {
                if (running)
                    return TimeSpan.FromTicks(DateTime.Now.Ticks - start.Ticks);
                else
                    return TimeSpan.FromTicks(stop.Ticks - start.Ticks);
            }
        }
    }

    // System.Xml.XmlIgnoreAttribute
    class XmlIgnoreAttribute : Attribute
    {
    }

    // System.ComponentModel.EditorBrowrableAttribute
    class EditorBrowsableAttribute : Attribute
    {
        public EditorBrowsableAttribute(EditorBrowsableState state) { }
    }

    // System.ComponentModel.EditorBrowsableState
    enum EditorBrowsableState
    {
        Always = 0,
        Never = 1,
        Advanced = 2,
    }
#endif
}
