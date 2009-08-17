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
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

using OpenTK;
using OpenTK.Audio;
using OpenTK.Audio.OpenAL;

namespace Examples
{
    [Example("Parrot Audio Capture", ExampleCategory.OpenAL, "1.1", Documentation = "Parrot")]
    public partial class Parrot : Form
    {
        #region Fields

        AudioContext audio_context;
        AudioCapture audio_capture;

        int src;
        short[] buffer = new short[512];
        const byte SampleToByte = 2;

        #endregion

        #region Constructors

        public Parrot()
        {
            InitializeComponent();

            this.Text = "OpenAL Parrot (" + (IntPtr.Size == 4 ? "x86" : "x64") + ")";

            // Add available capture devices to the combo box.
            IList<string> recorders = AudioCapture.AvailableDevices;
            for (int i = 0; i < recorders.Count; i++)
            {
                if (!String.IsNullOrEmpty(recorders[i]))
                    comboBox_RecorderSelection.Items.Add(recorders[i]);
            }
            if (comboBox_RecorderSelection.Items.Count > 0)
                comboBox_RecorderSelection.SelectedIndex = 0;
        }

        #endregion

        #region Events

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (audio_capture == null || !audio_capture.IsRunning)
            {
                button_Start.Text = "Stop Recording";
                groupBox_RecorderParameters.Enabled = false;
                this.StartRecording();
            }
            else
            {
                button_Start.Text = "Start Recording";
                groupBox_RecorderParameters.Enabled = true;
                this.StopRecording();
            }
        }

        private void timer_UpdateSamples_Tick(object sender, EventArgs e)
        {
            this.UpdateSamples();
        }

        private void Parrot_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.StopRecording();
        }

        #endregion

        #region Private Members

        void StartRecording()
        {
            try
            {
                audio_context = new AudioContext();
            }
            catch (AudioException ae)
            {
                MessageBox.Show("Fatal: Cannot continue without a playback device.\nException caught when opening playback device.\n" + ae.Message);
                Application.Exit();
            }

            AL.Listener(ALListenerf.Gain, (float)numericUpDown_PlaybackGain.Value);
            src = AL.GenSource();

            int sampling_rate = (int)numericUpDown_Frequency.Value;
            double buffer_length_ms = (double)numericUpDown_BufferLength.Value;
            int buffer_length_samples = (int)((double)numericUpDown_BufferLength.Value * sampling_rate * 0.001 / BlittableValueType.StrideOf(buffer));

            try
            {
                audio_capture = new AudioCapture((string)comboBox_RecorderSelection.SelectedItem,
                    sampling_rate, ALFormat.Mono16, buffer_length_samples);
            }
            catch (AudioDeviceException ade)
            {
                MessageBox.Show("Exception caught when opening recording device.\n" + ade.Message);
                audio_capture = null;
            }

            if (audio_capture == null)
                return;

            audio_capture.Start();

            timer_GetSamples.Start();
            timer_GetSamples.Interval = (int)(buffer_length_ms / 2 + 0.5);   // Tick when half the buffer is full.
        }

        void StopRecording()
        {
            timer_GetSamples.Stop();

            if (audio_capture != null)
            {
                audio_capture.Stop();
                audio_capture.Dispose();
                audio_capture = null;
            }

            if (audio_context != null)
            {
                int r;
                AL.GetSource(src, ALGetSourcei.BuffersQueued, out r);
                ClearBuffers(r);

                AL.DeleteSource(src);

                audio_context.Dispose();
                audio_context = null;
            }
        }

        void UpdateSamples()
        {
            if (audio_capture == null)
                return;

            int available_samples = audio_capture.AvailableSamples;

            if (available_samples * SampleToByte > buffer.Length * BlittableValueType.StrideOf(buffer))
            {
                buffer = new short[MathHelper.NextPowerOfTwo(
                    (int)(available_samples * SampleToByte / (double)BlittableValueType.StrideOf(buffer) + 0.5))];
            }

            if (available_samples > 0)
            {
                audio_capture.ReadSamples(buffer, available_samples);

                int buf = AL.GenBuffer();
                AL.BufferData(buf, ALFormat.Mono16, buffer, (int)(available_samples * BlittableValueType.StrideOf(buffer)), audio_capture.SampleFrequency);
                AL.SourceQueueBuffer(src, buf);

                label_SamplesConsumed.Text = "Samples consumed: " + available_samples;

                if (AL.GetSourceState(src) != ALSourceState.Playing)
                    AL.SourcePlay(src);
            }
            
            ClearBuffers(0);
        }

        void ClearBuffers(int input)
        {
            if (audio_context == null || audio_context == null)
                return;

            int[] freedbuffers;
            if (input == 0)
            {
                int BuffersProcessed;
                AL.GetSource(src, ALGetSourcei.BuffersProcessed, out BuffersProcessed);
                if (BuffersProcessed == 0)
                    return;
                freedbuffers = AL.SourceUnqueueBuffers(src, BuffersProcessed);
            }
            else
            {
                freedbuffers = AL.SourceUnqueueBuffers(src, input);
            }
            AL.DeleteBuffers(freedbuffers);
        }

        #endregion

        #region Main

        [STAThread]
        static void Main()
        {
            using (Parrot parrot = new Parrot())
            {
                parrot.ShowDialog();
            }
        }

        #endregion
    }
}