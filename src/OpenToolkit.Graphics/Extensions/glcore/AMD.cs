using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLCORE.Extensions
{
    public static partial class AMD
    {
        public unsafe static partial class FramebufferMultisampleAdvanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleAdvancedAMD")]
            public static extern void GlRenderbufferStorageMultisampleAdvanced(uint target, int samples, int storageSamples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedRenderbufferStorageMultisampleAdvancedAMD")]
            public static extern void GlNamedRenderbufferStorageMultisampleAdvanced(uint renderbuffer, int samples, int storageSamples, uint internalformat, int width, int height);
            
        }
        public unsafe static partial class PerformanceMonitor
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorGroupsAMD")]
            public static extern void GlGetPerfMonitorGroups(int* numGroups, int groupsSize, uint* groups);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorCountersAMD")]
            public static extern void GlGetPerfMonitorCounters(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorGroupStringAMD")]
            public static extern void GlGetPerfMonitorGroupString(uint group, int bufSize, int* length, char* groupString);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorCounterStringAMD")]
            public static extern void GlGetPerfMonitorCounterString(uint group, uint counter, int bufSize, int* length, char* counterString);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
            public static extern void GlGetPerfMonitorCounterInfo(uint group, uint counter, uint pname, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenPerfMonitorsAMD")]
            public static extern void GlGenPerfMonitors(int n, uint* monitors);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeletePerfMonitorsAMD")]
            public static extern void GlDeletePerfMonitors(int n, uint* monitors);
            
            [DllImport("opengl32.dll", EntryPoint = "glSelectPerfMonitorCountersAMD")]
            public static extern void GlSelectPerfMonitorCounters(uint monitor, byte enable, uint group, int numCounters, uint* counterList);
            
            [DllImport("opengl32.dll", EntryPoint = "glBeginPerfMonitorAMD")]
            public static extern void GlBeginPerfMonitor(uint monitor);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndPerfMonitorAMD")]
            public static extern void GlEndPerfMonitor(uint monitor);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorCounterDataAMD")]
            public static extern void GlGetPerfMonitorCounterData(uint monitor, uint pname, int dataSize, uint* data, int* bytesWritten);
            
        }
    }
}
