//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using OpenTK.Core;
using OpenTK.OpenAL.Native;

namespace OpenTK.OpenAL
{
    internal static class AudioDeviceEnumerator
    {
        private static readonly List<string> AvailablePlaybackDevicesValue = new List<string>();
        private static readonly List<string> AvailableRecordingDevicesValue = new List<string>();

        // Loads all available audio devices into the available_*_devices lists.
        static AudioDeviceEnumerator()
        {
            var dummy_device = IntPtr.Zero;
            var dummy_context = ContextHandle.Zero;

            try
            {
                Debug.WriteLine("Enumerating audio devices.");
                Debug.Indent();

                // need a dummy context for correct results
                dummy_device = Alc.OpenDevice(null);
                dummy_context = Alc.CreateContext(dummy_device, (int[])null);
                var dummy_success = Alc.MakeContextCurrent(dummy_context);
                var dummy_error = Alc.GetError(dummy_device);
                if (!dummy_success || dummy_error != AlcError.NoError)
                {
                    throw new AudioContextException("Failed to create dummy Context. Device (" + dummy_device +
                                                    ") Context (" + dummy_context.Handle +
                                                    ") MakeContextCurrent " + (dummy_success ? "succeeded" : "failed") +
                                                    ", Alc Error (" + dummy_error + ") " +
                                                    Alc.GetString(IntPtr.Zero, (AlcGetString)dummy_error));
                }

                // Get a list of all known playback devices, using best extension available
                if (Alc.IsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATION_EXT"))
                {
                    Version = AlcVersion.Alc1_1;
                    if (Alc.IsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATE_ALL_EXT"))
                    {
                        AvailablePlaybackDevicesValue.AddRange
                        (
                            Alc.GetString(IntPtr.Zero, AlcGetStringList.AllDevicesSpecifier)
                        );
                        DefaultPlaybackDevice = Alc.GetString(IntPtr.Zero, AlcGetString.DefaultAllDevicesSpecifier);
                    }
                    else
                    {
                        AvailablePlaybackDevicesValue.AddRange
                        (
                            Alc.GetString(IntPtr.Zero, AlcGetStringList.DeviceSpecifier)
                        );
                        DefaultPlaybackDevice = Alc.GetString(IntPtr.Zero, AlcGetString.DefaultDeviceSpecifier);
                    }
                }
                else
                {
                    Version = AlcVersion.Alc1_0;
                    Debug.Print("Device enumeration extension not available. Failed to enumerate playback devices.");
                }

                var playback_err = Alc.GetError(dummy_device);
                if (playback_err != AlcError.NoError)
                {
                    throw new AudioContextException
                    (
                        $"Alc Error occured when querying available playback devices: {playback_err}"
                    );
                }

                // Get a list of all known recording devices, at least ALC_ENUMERATION_EXT is needed too
                if (Version == AlcVersion.Alc1_1 && Alc.IsExtensionPresent(IntPtr.Zero, "ALC_EXT_CAPTURE"))
                {
                    AvailableRecordingDevicesValue.AddRange
                    (
                        Alc.GetString(IntPtr.Zero, AlcGetStringList.CaptureDeviceSpecifier)
                    );
                    DefaultRecordingDevice = Alc.GetString(IntPtr.Zero, AlcGetString.CaptureDefaultDeviceSpecifier);
                }
                else
                {
                    Debug.Print("Capture extension not available. Failed to enumerate recording devices.");
                }

                var record_err = Alc.GetError(dummy_device);
                if (record_err != AlcError.NoError)
                {
                    throw new AudioContextException
                    (
                        $"Alc Error occured when querying available recording devices: {record_err}"
                    );
                }

#if DEBUG
                Debug.WriteLine("Found playback devices:");
                foreach (var s in AvailablePlaybackDevicesValue)
                {
                    Debug.WriteLine(s);
                }

                Debug.WriteLine("Default playback device: " + DefaultPlaybackDevice);

                Debug.WriteLine("Found recording devices:");
                foreach (var s in AvailableRecordingDevicesValue)
                {
                    Debug.WriteLine(s);
                }

                Debug.WriteLine("Default recording device: " + DefaultRecordingDevice);
#endif
            }
            catch (DllNotFoundException e)
            {
                Trace.WriteLine(e.ToString());
                IsOpenALSupported = false;
            }
            catch (AudioContextException ace)
            {
                Trace.WriteLine(ace.ToString());
                IsOpenALSupported = false;
            }
            finally
            {
                Debug.Unindent();

                if (IsOpenALSupported)
                {
                    try
                    {
                        // clean up the dummy context
                        Alc.MakeContextCurrent(ContextHandle.Zero);
                        if (dummy_context != ContextHandle.Zero && dummy_context.Handle != IntPtr.Zero)
                        {
                            Alc.DestroyContext(dummy_context);
                        }

                        if (dummy_device != IntPtr.Zero)
                        {
                            Alc.CloseDevice(dummy_device);
                        }
                    }
                    catch
                    {
                        IsOpenALSupported = false;
                    }
                }
            }
        }

        internal static IList<string> AvailablePlaybackDevices => AvailablePlaybackDevicesValue.AsReadOnly();

        internal static IList<string> AvailableRecordingDevices => AvailableRecordingDevicesValue.AsReadOnly();

        internal static string DefaultPlaybackDevice { get; }

        internal static string DefaultRecordingDevice { get; }

        internal static bool IsOpenALSupported { get; } = true;

        internal static AlcVersion Version { get; }

        internal enum AlcVersion
        {
            Alc1_0,
            Alc1_1
        }
    }
}
