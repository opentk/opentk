using OpenTK.Mathematics;

namespace OpenTK.OpenAL.Native.Extensions.Creative.EFX
{
    public struct EfxEaxReverb
    {
        public float Density;
        public float Diffusion;
        public float Gain;
        public float GainHF;
        public float GainLF;
        public float DecayTime;
        public float DecayHFRatio;
        public float DecayLFRatio;
        public float ReflectionsGain;
        public float ReflectionsDelay;
        public Vector3 ReflectionsPan;
        public float LateReverbGain;
        public float LateReverbDelay;
        public Vector3 LateReverbPan;
        public float EchoTime;
        public float EchoDepth;
        public float ModulationTime;
        public float ModulationDepth;
        public float AirAbsorptionGainHF;
        public float HFReference;
        public float LFReference;
        public float RoomRolloffFactor;
        public int DecayHFLimit;
    }
}