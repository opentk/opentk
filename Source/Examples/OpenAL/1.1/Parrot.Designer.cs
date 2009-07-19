namespace Examples
{
    partial class Parrot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_RecorderSelection = new System.Windows.Forms.ComboBox();
            this.groupBox_RecorderParameters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_PlaybackGain = new System.Windows.Forms.NumericUpDown();
            this.label_MONO16BIT = new System.Windows.Forms.Label();
            this.label_RINGBUFFER = new System.Windows.Forms.Label();
            this.label_FREQUENCY = new System.Windows.Forms.Label();
            this.numericUpDown_BufferLength = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Frequency = new System.Windows.Forms.NumericUpDown();
            this.groupBox_RecordingControls = new System.Windows.Forms.GroupBox();
            this.label_SamplesConsumed = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.timer_GetSamples = new System.Windows.Forms.Timer(this.components);
            this.groupBox_RecorderParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PlaybackGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BufferLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Frequency)).BeginInit();
            this.groupBox_RecordingControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_RecorderSelection
            // 
            this.comboBox_RecorderSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_RecorderSelection.FormattingEnabled = true;
            this.comboBox_RecorderSelection.Location = new System.Drawing.Point(6, 19);
            this.comboBox_RecorderSelection.Name = "comboBox_RecorderSelection";
            this.comboBox_RecorderSelection.Size = new System.Drawing.Size(216, 21);
            this.comboBox_RecorderSelection.TabIndex = 0;
            // 
            // groupBox_RecorderParameters
            // 
            this.groupBox_RecorderParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_RecorderParameters.Controls.Add(this.label2);
            this.groupBox_RecorderParameters.Controls.Add(this.label1);
            this.groupBox_RecorderParameters.Controls.Add(this.numericUpDown_PlaybackGain);
            this.groupBox_RecorderParameters.Controls.Add(this.label_MONO16BIT);
            this.groupBox_RecorderParameters.Controls.Add(this.label_RINGBUFFER);
            this.groupBox_RecorderParameters.Controls.Add(this.label_FREQUENCY);
            this.groupBox_RecorderParameters.Controls.Add(this.numericUpDown_BufferLength);
            this.groupBox_RecorderParameters.Controls.Add(this.numericUpDown_Frequency);
            this.groupBox_RecorderParameters.Controls.Add(this.comboBox_RecorderSelection);
            this.groupBox_RecorderParameters.Location = new System.Drawing.Point(12, 12);
            this.groupBox_RecorderParameters.Name = "groupBox_RecorderParameters";
            this.groupBox_RecorderParameters.Size = new System.Drawing.Size(228, 168);
            this.groupBox_RecorderParameters.TabIndex = 2;
            this.groupBox_RecorderParameters.TabStop = false;
            this.groupBox_RecorderParameters.Text = "Recording Device Setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Sample format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Playback gain (dB)";
            // 
            // numericUpDown_PlaybackGain
            // 
            this.numericUpDown_PlaybackGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_PlaybackGain.Location = new System.Drawing.Point(145, 100);
            this.numericUpDown_PlaybackGain.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown_PlaybackGain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_PlaybackGain.Name = "numericUpDown_PlaybackGain";
            this.numericUpDown_PlaybackGain.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown_PlaybackGain.TabIndex = 103;
            this.numericUpDown_PlaybackGain.ThousandsSeparator = true;
            this.numericUpDown_PlaybackGain.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label_MONO16BIT
            // 
            this.label_MONO16BIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MONO16BIT.AutoSize = true;
            this.label_MONO16BIT.Location = new System.Drawing.Point(142, 132);
            this.label_MONO16BIT.Name = "label_MONO16BIT";
            this.label_MONO16BIT.Size = new System.Drawing.Size(64, 13);
            this.label_MONO16BIT.TabIndex = 102;
            this.label_MONO16BIT.Text = "Mono 16 Bit";
            // 
            // label_RINGBUFFER
            // 
            this.label_RINGBUFFER.AutoSize = true;
            this.label_RINGBUFFER.Location = new System.Drawing.Point(6, 76);
            this.label_RINGBUFFER.Name = "label_RINGBUFFER";
            this.label_RINGBUFFER.Size = new System.Drawing.Size(89, 13);
            this.label_RINGBUFFER.TabIndex = 101;
            this.label_RINGBUFFER.Text = "Buffer length (ms)";
            // 
            // label_FREQUENCY
            // 
            this.label_FREQUENCY.AutoSize = true;
            this.label_FREQUENCY.Location = new System.Drawing.Point(6, 50);
            this.label_FREQUENCY.Name = "label_FREQUENCY";
            this.label_FREQUENCY.Size = new System.Drawing.Size(85, 13);
            this.label_FREQUENCY.TabIndex = 100;
            this.label_FREQUENCY.Text = "Sample rate (Hz)";
            // 
            // numericUpDown_BufferLength
            // 
            this.numericUpDown_BufferLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_BufferLength.Location = new System.Drawing.Point(145, 74);
            this.numericUpDown_BufferLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_BufferLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_BufferLength.Name = "numericUpDown_BufferLength";
            this.numericUpDown_BufferLength.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown_BufferLength.TabIndex = 2;
            this.numericUpDown_BufferLength.ThousandsSeparator = true;
            this.numericUpDown_BufferLength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown_Frequency
            // 
            this.numericUpDown_Frequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Frequency.Location = new System.Drawing.Point(145, 48);
            this.numericUpDown_Frequency.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Frequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Frequency.Name = "numericUpDown_Frequency";
            this.numericUpDown_Frequency.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown_Frequency.TabIndex = 1;
            this.numericUpDown_Frequency.ThousandsSeparator = true;
            this.numericUpDown_Frequency.Value = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            // 
            // groupBox_RecordingControls
            // 
            this.groupBox_RecordingControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_RecordingControls.Controls.Add(this.label_SamplesConsumed);
            this.groupBox_RecordingControls.Controls.Add(this.button_Start);
            this.groupBox_RecordingControls.Location = new System.Drawing.Point(12, 186);
            this.groupBox_RecordingControls.Name = "groupBox_RecordingControls";
            this.groupBox_RecordingControls.Size = new System.Drawing.Size(228, 78);
            this.groupBox_RecordingControls.TabIndex = 3;
            this.groupBox_RecordingControls.TabStop = false;
            this.groupBox_RecordingControls.Text = "Talk to the parrot";
            // 
            // label_SamplesConsumed
            // 
            this.label_SamplesConsumed.AutoSize = true;
            this.label_SamplesConsumed.Location = new System.Drawing.Point(6, 52);
            this.label_SamplesConsumed.Name = "label_SamplesConsumed";
            this.label_SamplesConsumed.Size = new System.Drawing.Size(108, 13);
            this.label_SamplesConsumed.TabIndex = 103;
            this.label_SamplesConsumed.Text = "Samples consumed: -";
            // 
            // button_Start
            // 
            this.button_Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Start.Location = new System.Drawing.Point(35, 19);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(159, 24);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "Start recording";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // timer_GetSamples
            // 
            this.timer_GetSamples.Tick += new System.EventHandler(this.timer_UpdateSamples_Tick);
            // 
            // Parrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 276);
            this.Controls.Add(this.groupBox_RecordingControls);
            this.Controls.Add(this.groupBox_RecorderParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Parrot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenAL Parrot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parrot_FormClosing);
            this.groupBox_RecorderParameters.ResumeLayout(false);
            this.groupBox_RecorderParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PlaybackGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BufferLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Frequency)).EndInit();
            this.groupBox_RecordingControls.ResumeLayout(false);
            this.groupBox_RecordingControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_RecorderSelection;
        private System.Windows.Forms.GroupBox groupBox_RecorderParameters;
        private System.Windows.Forms.Label label_RINGBUFFER;
        private System.Windows.Forms.Label label_FREQUENCY;
        private System.Windows.Forms.NumericUpDown numericUpDown_BufferLength;
        private System.Windows.Forms.NumericUpDown numericUpDown_Frequency;
        private System.Windows.Forms.GroupBox groupBox_RecordingControls;
        private System.Windows.Forms.Label label_SamplesConsumed;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_MONO16BIT;
        private System.Windows.Forms.Timer timer_GetSamples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_PlaybackGain;
        private System.Windows.Forms.Label label2;

    }
}
