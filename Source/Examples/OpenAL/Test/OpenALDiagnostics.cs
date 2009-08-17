#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

using OpenTK;
using OpenTK.Audio;
using OpenTK.Audio.OpenAL;

namespace Examples
{
    /// <summary>
    /// A text-based diagnosis program for OpenAL.
    /// The constructors will call the OpenAL commands, the Print() methods just show the information.
    /// </summary>
    [Example("OpenAL diagnostics", ExampleCategory.OpenAL, "Test", 0, true)]
    class OpenALDiagnostics
    {
        public static void checkForErrors()
        {
            {
                IntPtr device = Alc.GetContextsDevice(Alc.GetCurrentContext());
                AlcError error = Alc.GetError(device);

                if (error != AlcError.NoError)
                    Trace.WriteLine("ALC ERROR: (" + error + ")  " + Alc.GetString(device, (AlcGetString)error));
            }
            {
                ALError error = AL.GetError();
                if (error != ALError.NoError)
                    Trace.WriteLine("AL ERROR: (" + error + ") " + AL.GetErrorString(error));
            }
        }

        [STAThread]
        static void Main()
        {
            Trace.Listeners.RemoveAt(0);
            Trace.Listeners.Add(new ConsoleTraceListener());

            Trace.WriteLine("This application is currently running as " + (IntPtr.Size == 4 ? "x86" : "x64"));

            DeviceDiagnostic DevDiag = new DeviceDiagnostic();
            DevDiag.Print();
            DevDiag = null;

            using (AudioContext A = new AudioContext())
            {
                AlcDiagnostic AlcDiag = new AlcDiagnostic(Alc.GetContextsDevice(Alc.GetCurrentContext()));
                checkForErrors();
                AlcDiag.Print();
                AlcDiag = null;

                ALDiagnostic ALdiag = new ALDiagnostic(A);
                checkForErrors();
                ALdiag.Print();
                ALdiag = null;

                EfxDiagnostic EfxDiag = new EfxDiagnostic();
                checkForErrors();
                EfxDiag.Print();
                EfxDiag = null;

                XRamDiagnostic XRamDiag = new XRamDiagnostic();
                checkForErrors();
                XRamDiag.Print();
                XRamDiag = null;

                RecorderDiagnostic rec = new RecorderDiagnostic();
                rec.Print();
                rec = null;
            }

            Trace.WriteLine("All done. Press Enter to exit.");
            Console.ReadLine();
        }
    }

    class DeviceDiagnostic
    {
        #region Fields
        public readonly IList<string> AllPlaybackDevices;
        public readonly IList<string> AllRecordingDevices;

        public readonly string DefaultPlaybackDevice;
        public readonly string DefaultRecordingDevice;
        #endregion Fields

        public DeviceDiagnostic()
        {
            Trace.WriteLine("--- Device related errors ---");

            AllPlaybackDevices = AudioContext.AvailableDevices;
            AllRecordingDevices = AudioCapture.AvailableDevices;

            DefaultPlaybackDevice = AudioContext.DefaultDevice;
            DefaultRecordingDevice = AudioCapture.DefaultDevice;
        }

        public void Print()
        {
            Trace.WriteLine("--- Device related analysis ---");
            Trace.Indent();
            {
                Trace.WriteLine("Default playback device: " + DefaultPlaybackDevice);
                Trace.WriteLine("All known playback devices:");
                Trace.Indent();
                {
                    foreach (string s in AllPlaybackDevices)
                        Trace.WriteLine(s);
                }
                Trace.Unindent();

                Trace.WriteLine("Default recording device: " + DefaultRecordingDevice);
                Trace.WriteLine("All known recording devices:");
                Trace.Indent();
                {
                    foreach (string s in AllRecordingDevices)
                        Trace.WriteLine(s);
                }
                Trace.Unindent();
            }
            Trace.Unindent();
        }
    }

    class AlcDiagnostic
    {
        #region Fields
        private string[] Alc_Extension_C_Names = new string[]
          {
            "ALC_ENUMERATE_ALL_EXT",
            "ALC_ENUMERATION_EXT",
            "ALC_EXT_ASA",
            "ALC_EXT_ASA_DISTORTION",
            "ALC_EXT_ASA_ROGER_BEEP",
            "ALC_EXT_BRS_GAME_LICENSE_REQUIRED",
            "ALC_EXT_capture",
            "ALC_EXT_DEDICATED",
            "ALC_EXT_EFX",
          };

        public readonly int MajorVersion;
        public readonly int MinorVersion;
        public readonly int EfxMajorVersion;
        public readonly int EfxMinorVersion;
        public readonly int EfxMaxAuxiliarySends;
        public readonly string ExtensionString;
        public readonly Dictionary<string, bool> Extensions = new Dictionary<string, bool>();
        #endregion Fields

        public AlcDiagnostic(IntPtr dev)
        {
            Trace.WriteLine("--- Alc related errors ---");

            Alc.GetInteger(dev, AlcGetInteger.MajorVersion, 1, out MajorVersion);
            Alc.GetInteger(dev, AlcGetInteger.MinorVersion, 1, out MinorVersion);
            Alc.GetInteger(dev, AlcGetInteger.EfxMajorVersion, 1, out EfxMajorVersion);
            Alc.GetInteger(dev, AlcGetInteger.EfxMinorVersion, 1, out EfxMinorVersion);
            Alc.GetInteger(dev, AlcGetInteger.EfxMaxAuxiliarySends, 1, out EfxMaxAuxiliarySends);

            ExtensionString = Alc.GetString(dev, AlcGetString.Extensions);

            foreach (string s in Alc_Extension_C_Names)
                Extensions.Add(s, Alc.IsExtensionPresent(dev, s));
        }

        public void Print()
        {
            Trace.WriteLine("--- Alc related analysis ---");
            Trace.Indent();
            {
                Trace.WriteLine("Alc Version: " + MajorVersion + "." + MinorVersion);
                Trace.WriteLine("Efx Version: " + EfxMajorVersion + "." + EfxMinorVersion);
                Trace.WriteLine("Efx max. Auxiliary sends: " + EfxMaxAuxiliarySends);
                Trace.WriteLine("Alc Extension string: " + ExtensionString);

                Trace.WriteLine("Confirmed Alc Extensions:");
                Trace.Indent();
                {
                    foreach (KeyValuePair<string, bool> pair in Extensions)
                        Trace.WriteLine(pair.Key + ": " + pair.Value);
                }
                Trace.Unindent();
            }
            Trace.Unindent();
        }
    }

    class ALDiagnostic
    {
        #region Fields
        private string[] AL_Extension_Names = new string[]
        {
          "AL_EXT_ALAW",
          "AL_EXT_BFORMAT",
          "AL_EXT_double",
          "AL_EXT_EXPONENT_DISTANCE",
          "AL_EXT_float32",
          "AL_EXT_FOLDBACK",
          "AL_EXT_IMA4",
          "AL_EXT_LINEAR_DISTANCE",
          "AL_EXT_MCFORMATS",
          "AL_EXT_mp3",
          "AL_EXT_MULAW",
          "AL_EXT_OFFSET",
          "AL_EXT_vorbis",
          "AL_LOKI_quadriphonic",
          "EAX-RAM",
          "EAX",
          "EAX1.0",
          "EAX2.0",
          "EAX3.0",
          "EAX3.0EMULATED",
          "EAX4.0",
          "EAX4.0EMULATED",
          "EAX5.0"
        };

        public readonly Dictionary<string, bool> Extensions = new Dictionary<string, bool>();

        public readonly string DeviceName;
        public readonly float SpeedOfSound;
        public readonly string ExtensionString;
        public readonly string Renderer;
        public readonly string Vendor;
        public readonly string Version;
        public readonly ALDistanceModel DistanceModel;

        const uint MaxSourcesLimit = 128;
        public readonly uint MaxSources;
        #endregion Fields

        public ALDiagnostic(AudioContext ac)
        {
            Trace.WriteLine("--- AL related errors ---");

            DeviceName = ac.CurrentDevice;

            ExtensionString = AL.Get(ALGetString.Extensions);
            Renderer = AL.Get(ALGetString.Renderer);
            Vendor = AL.Get(ALGetString.Vendor);
            Version = AL.Get(ALGetString.Version);

            SpeedOfSound = AL.Get(ALGetFloat.SpeedOfSound);
            DistanceModel = AL.GetDistanceModel();

            foreach (string s in AL_Extension_Names)
                Extensions.Add(s, AL.IsExtensionPresent(s));

            AL.GetError(); // clear it, need this for the source counting to work properly
            uint[] dummy_sources = new uint[MaxSourcesLimit];
            for (MaxSources = 0; MaxSources < MaxSourcesLimit; MaxSources++)
            {
                AL.GenSource(out dummy_sources[MaxSources]);
                if (AL.GetError() != ALError.NoError)
                    break;
            }

            for (int i = 0; i < MaxSources; i++)
                AL.DeleteSource(ref dummy_sources[i]);
        }

        public void Print()
        {
            Trace.WriteLine("--- AL related analysis ---");
            Trace.Indent();
            {
                Trace.WriteLine("Used Device: "+DeviceName);
                Trace.WriteLine("AL Renderer: " + Renderer);
                Trace.WriteLine("AL Vendor: " + Vendor);
                Trace.WriteLine("AL Version: " + Version);

                Trace.WriteLine("AL Speed of sound: " + SpeedOfSound);
                Trace.WriteLine("AL Distance Model: " + DistanceModel.ToString());
                Trace.WriteLine("AL Maximum simultanous Sources: " + MaxSources);

                Trace.WriteLine("AL Extension string: " + ExtensionString);
                Trace.WriteLine("Confirmed AL Extensions:");
                Trace.Indent();
                {
                    foreach (KeyValuePair<string, bool> pair in Extensions)
                        Trace.WriteLine(pair.Key + ": " + pair.Value);
                }
                Trace.Unindent();
            }
            Trace.Unindent();
        }
    }

    class EfxDiagnostic
    {
        #region Fields
        private EfxEffectType[] EffectNames = new EfxEffectType[]
          { 
            EfxEffectType.Autowah,
            EfxEffectType.Chorus,
            EfxEffectType.Compressor,
            EfxEffectType.Distortion,
            EfxEffectType.EaxReverb,
            EfxEffectType.Echo,
            EfxEffectType.Equalizer,
            EfxEffectType.Flanger,
            EfxEffectType.FrequencyShifter, 
            EfxEffectType.PitchShifter,
            EfxEffectType.Reverb,
            EfxEffectType.RingModulator,
            EfxEffectType.VocalMorpher,
          };

        private EfxFilterType[] FilterNames = new EfxFilterType[] 
          {
            EfxFilterType.Bandpass,
            EfxFilterType.Highpass,
            EfxFilterType.Lowpass,
          };

        public readonly Dictionary<string, bool> Effects = new Dictionary<string, bool>();
        public readonly Dictionary<string, bool> Filters = new Dictionary<string, bool>();

        const uint MaxAuxiliaryEffectSlotsLimit = 4;
        public readonly uint MaxAuxiliaryEffectSlots;
        #endregion Fields

        public EfxDiagnostic()
        {
            Trace.WriteLine("--- Efx related errors ---");

            EffectsExtension Efx = new EffectsExtension();
            Trace.Assert(Efx.IsInitialized);

            #region Test for available Effects
            uint effect;
            Efx.GenEffect(out effect);
            AL.GetError();
            foreach (EfxEffectType e in EffectNames)
            {
                Efx.BindEffect(effect, e);
                Effects.Add(e.ToString(), AL.GetError() == ALError.NoError);
            }
            Efx.DeleteEffect(ref effect);
            #endregion Test for available Effects

            #region Test for available Filters
            uint filter;
            Efx.GenFilter(out filter);
            AL.GetError();
            foreach (EfxFilterType f in FilterNames)
            {
                Efx.Filter(filter, EfxFilteri.FilterType, (int)f);
                Filters.Add(f.ToString(), AL.GetError() == ALError.NoError);
            }
            Efx.DeleteFilter(ref filter);
            #endregion Test for available Filters

            AL.GetError();
            uint[] dummy_slots = new uint[MaxAuxiliaryEffectSlotsLimit];
            for (MaxAuxiliaryEffectSlots = 0; MaxAuxiliaryEffectSlots < MaxAuxiliaryEffectSlotsLimit; MaxAuxiliaryEffectSlots++)
            {
                Efx.GenAuxiliaryEffectSlot(out dummy_slots[MaxAuxiliaryEffectSlots]);
                if (AL.GetError() != ALError.NoError)
                    break;
            }
            for (uint i = 0; i < MaxAuxiliaryEffectSlots; i++)
                Efx.DeleteAuxiliaryEffectSlot(ref dummy_slots[i]);
        }

        public void Print()
        {
            Trace.WriteLine("--- Efx related analysis ---");
            Trace.Indent();
            {
                Trace.WriteLine("Efx Effects supported:");
                Trace.Indent();
                {
                    foreach (KeyValuePair<string, bool> pair in Effects)
                        Trace.WriteLine(pair.Key + ": " + pair.Value);
                }
                Trace.Unindent();

                Trace.WriteLine("Efx Filters supported:");
                Trace.Indent();
                {
                    foreach (KeyValuePair<string, bool> pair in Filters)
                        Trace.WriteLine(pair.Key + ": " + pair.Value);
                }
                Trace.Unindent();

                Trace.WriteLine("Efx max. Auxiliary Effect Slots: " + MaxAuxiliaryEffectSlots);
            }
            Trace.Unindent();
        }
    }

    class XRamDiagnostic
    {
        #region Fields
        private XRamExtension.XRamStorage[] storagemodes = new XRamExtension.XRamStorage[]
          {
            XRamExtension.XRamStorage.Hardware,
            XRamExtension.XRamStorage.Accessible,
            XRamExtension.XRamStorage.Automatic,
          };

        public readonly bool XRamFound;
        public readonly int RamTotal;
        public readonly int RamFree;
        public readonly Dictionary<string, bool> BufferModes = new Dictionary<string, bool>();
        #endregion Fields

        public XRamDiagnostic()
        {
            Trace.WriteLine("--- X-RAM related errors ---");

            XRamExtension XRam = new XRamExtension();
            if (XRam.IsInitialized)
            {
                XRamFound = true;

                RamTotal = XRam.GetRamSize;
                RamFree = XRam.GetRamFree;

                uint buffer;
                AL.GenBuffer(out buffer);

                foreach (XRamExtension.XRamStorage m in storagemodes)
                {
                    bool result = XRam.SetBufferMode(1, ref buffer, m);
                    BufferModes.Add(m.ToString(), m == XRam.GetBufferMode(ref buffer));
                }

                AL.DeleteBuffer(ref buffer);
            }
            else
                XRamFound = false;
        }

        public void Print()
        {
            Trace.WriteLine("--- X-RAM related analysis ---");

            if (XRamFound)
            {
                Trace.Indent(); // *
                Trace.WriteLine("X-RAM extension found.");
            }
            else
            {
                Trace.Indent();
                {
                    Trace.WriteLine("X-RAM extension is not available, skipping test.");
                }
                Trace.Unindent();
                return;
            }

            Trace.WriteLine("Ram status (free/total) in bytes: " + RamFree + "/" + RamTotal);

            Trace.WriteLine("Available buffer modes:");
            Trace.Indent();
            {
                foreach (KeyValuePair<string, bool> pair in BufferModes)
                    Trace.WriteLine(pair.Key + ": " + pair.Value);
            }
            Trace.Unindent();

            Trace.Unindent(); // *
        }
    }

    class RecorderDiagnostic
    {
        #region Fields
        bool IsDeviceAvailable;
        bool BufferContentsAllZero;
        short MaxSample = short.MinValue;
        short MinSample = short.MaxValue;

        private AudioCapture r;
        Dictionary<string, AlcError> Errorlist = new Dictionary<string, AlcError>();

        string DeviceName;

        #endregion Fields

        private void CheckRecorderError(string location)
        {
            AlcError err = r.CurrentError;
            if (err != AlcError.NoError)
                Errorlist.Add(location, err);
        }

        public RecorderDiagnostic()
        {
            Trace.WriteLine("--- AudioCapture related errors ---");
            IsDeviceAvailable = false;

            try
            {
                r = new AudioCapture(AudioCapture.DefaultDevice, 16000, ALFormat.Mono16, 4096);
            }
            catch (AudioDeviceException ade)
            {
                Trace.WriteLine("AudioCapture Exception caught: " + ade.Message);
                return;
            }
            IsDeviceAvailable = true;
            DeviceName = r.CurrentDevice;
            CheckRecorderError("Alc.CaptureOpenDevice");

            r.Start();
            CheckRecorderError("Alc.CaptureStart");
            Thread.Sleep(100);
            r.Stop();
            CheckRecorderError("Alc.CaptureStop");

            byte[] Buffer = new byte[8192];

            Thread.Sleep(10);  // Wait for a few samples to become available.
            int SamplesBefore = r.AvailableSamples;

            CheckRecorderError("Alc.GetInteger(...CaptureSamples...)");
            r.ReadSamples(Buffer, (SamplesBefore > 4096 ? 4096 : SamplesBefore));
            CheckRecorderError("Alc.CaptureSamples");

            int SamplesCaptured = SamplesBefore - r.AvailableSamples;

            uint ZeroCounter = 0;
            for (int i = 0; i < SamplesCaptured * 2; i++)
            {
                if (Buffer[i] == 0)
                    ZeroCounter++;
            }

            for (int i = 0; i < SamplesCaptured; i++)
            {
                short sample = BitConverter.ToInt16(Buffer, i * 2);
                if (sample > MaxSample)
                    MaxSample = sample;
                if (sample < MinSample)
                    MinSample = sample;
            }

            if (ZeroCounter < SamplesCaptured * 2 && SamplesCaptured > 0)
                BufferContentsAllZero = false;
            else
                BufferContentsAllZero = true;

            r.Dispose();
            CheckRecorderError("Alc.CaptureCloseDevice");

            // no playback test needed due to Parrot test app.
            /*
            uint buf;
            AL.GenBuffer(out buf);
            AL.BufferData(buf, ALFormat.Mono16, BufferPtr, SamplesCaptured * 2, 16000);
            uint src;
            AL.GenSource(out src);
            AL.BindBufferToSource(src, buf);
            AL.Listener(ALListenerf.Gain, 16.0f);
            AL.SourcePlay(src);
            while (AL.GetSourceState(src) == ALSourceState.Playing)
            {
                Thread.Sleep(0);
            }
            AL.SourceStop(src);

            AL.DeleteSource(ref src);
            AL.DeleteBuffer(ref buf);
            */
        }

        public void Print()
        {
            Trace.WriteLine("--- AudioCapture related analysis ---");

            if (!IsDeviceAvailable)
            {
                Trace.WriteLine("Capture Device could not be initlialized (no microphone plugged into the jack?). Skipping test.");
                return;
            }

            Trace.Indent();
            {
                Trace.WriteLine("Using capture device: " + DeviceName);
                if (Errorlist.Count > 0)
                {
                    Trace.WriteLine("Found Alc Errors:");
                    Trace.Indent();
                    {
                        foreach (KeyValuePair<string, AlcError> pair in Errorlist)
                            Trace.WriteLine(pair.Key + ": " + pair.Value);
                    }
                    Trace.Unindent();


                }
                Trace.WriteLine("Buffer contents after capture was all 0's: " + BufferContentsAllZero);
                Trace.WriteLine("Sample min/max in recorded data: " + MinSample + " / " + MaxSample);
            }
            Trace.Unindent();
        }
    }
}