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
    /// <summary>
    /// Enumerates available audio devices.
    /// </summary>
    internal static class AudioDeviceEnumerator
    {
        private static readonly List<string> AvailablePlaybackDevicesValue = new List<string>();
        private static readonly List<string> AvailableRecordingDevicesValue = new List<string>();

        // Loads all available audio devices into the available_*_devices lists.
        static AudioDeviceEnumerator()
        {
            var dummyDevice = IntPtr.Zero;
            var dummyContext = ContextHandle.Zero;

            try
            {
                Debug.WriteLine("Enumerating audio devices.");
                Debug.Indent();

                // need a dummy context for correct results
                dummyDevice = Alc.OpenDevice(null);
                dummyContext = Alc.CreateContext(dummyDevice, (int[])null);
                var dummySuccess = Alc.MakeContextCurrent(dummyContext);
                var dummyError = Alc.GetError(dummyDevice);
                if (!dummySuccess || dummyError != ContextError.NoError)
                {
                    throw new AudioContextException
                    (
                        $"Failed to create dummy Context.\n" +
                        $"Device ({dummyDevice}) \n" +
                        $"Context ({dummyContext.Handle}) \n" +
                        $"MakeContextCurrent {(dummySuccess ? "succeeded" : "failed")}\n" +
                        $"Alc Error ({dummyError}) {Alc.GetString(IntPtr.Zero, (GetContextString)dummyError)}"
                    );
                }

                // Get a list of all known playback devices, using best extension available
                if (Alc.IsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATION_EXT"))
                {
                    Version = AlcVersion.Alc11;
                    if (Alc.IsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATE_ALL_EXT"))
                    {
                        AvailablePlaybackDevicesValue.AddRange
                        (
                            Alc.GetString(IntPtr.Zero, GetContextStringList.AllDevicesSpecifier)
                        );

                        DefaultPlaybackDevice = Alc.GetString(IntPtr.Zero, GetContextString.DefaultAllDevicesSpecifier);
                    }
                    else
                    {
                        AvailablePlaybackDevicesValue.AddRange
                        (
                            Alc.GetString(IntPtr.Zero, GetContextStringList.DeviceSpecifier)
                        );

                        DefaultPlaybackDevice = Alc.GetString(IntPtr.Zero, GetContextString.DefaultDeviceSpecifier);
                    }
                }
                else
                {
                    Version = AlcVersion.Alc10;
                    Debug.Print("Device enumeration extension not available. Failed to enumerate playback devices.");
                }

                var playbackErr = Alc.GetError(dummyDevice);
                if (playbackErr != ContextError.NoError)
                {
                    throw new AudioContextException
                    (
                        $"Alc Error occured when querying available playback devices: {playbackErr}"
                    );
                }

                // Get a list of all known recording devices, at least ALC_ENUMERATION_EXT is needed too
                if (Version == AlcVersion.Alc11 && Alc.IsExtensionPresent(IntPtr.Zero, "ALC_EXT_CAPTURE"))
                {
                    AvailableRecordingDevicesValue.AddRange
                    (
                        Alc.GetString(IntPtr.Zero, GetContextStringList.CaptureDeviceSpecifier)
                    );
                    DefaultRecordingDevice = Alc.GetString(IntPtr.Zero, GetContextString.CaptureDefaultDeviceSpecifier);
                }
                else
                {
                    Debug.Print("Capture extension not available. Failed to enumerate recording devices.");
                }

                var recordErr = Alc.GetError(dummyDevice);
                if (recordErr != ContextError.NoError)
                {
                    throw new AudioContextException
                    (
                        $"Alc Error occured when querying available recording devices: {recordErr}"
                    );
                }
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
                        if (dummyContext != ContextHandle.Zero && dummyContext.Handle != IntPtr.Zero)
                        {
                            Alc.DestroyContext(dummyContext);
                        }

                        if (dummyDevice != IntPtr.Zero)
                        {
                            Alc.CloseDevice(dummyDevice);
                        }
                    }
                    catch
                    {
                        IsOpenALSupported = false;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the names of the available playback devices.
        /// </summary>
        internal static IList<string> AvailablePlaybackDevices => AvailablePlaybackDevicesValue.AsReadOnly();

        /// <summary>
        /// Gets the names of the available recording devices.
        /// </summary>
        internal static IList<string> AvailableRecordingDevices => AvailableRecordingDevicesValue.AsReadOnly();

        /// <summary>
        /// Gets the name of the default playback device.
        /// </summary>
        internal static string DefaultPlaybackDevice { get; }

        /// <summary>
        /// Gets the name of the default recording device.
        /// </summary>
        internal static string DefaultRecordingDevice { get; }

        /// <summary>
        /// Gets a value indicating whether OpenAL is supported.
        /// </summary>
        internal static bool IsOpenALSupported { get; } = true;

        /// <summary>
        /// Gets the OpenAL version.
        /// </summary>
        internal static AlcVersion Version { get; }
    }
}
