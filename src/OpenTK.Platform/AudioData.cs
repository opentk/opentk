namespace OpenTK.Platform
{
    public class AudioData
    {
        public int SampleRate { get; set; }

        public bool Stereo { get; set; }

        public short[] Audio { get; set; }
    }
}
