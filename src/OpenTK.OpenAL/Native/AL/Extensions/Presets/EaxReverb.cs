/* EfxPresets.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

using System;

namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// The DirectSound compatible EAX reverb effect settings.
    /// </summary>
    public struct EaxReverb
    {
        private float _density;
        private float _diffusion;
        private float _gain;
        private float _gainHf;
        private float _decayTime;
        private float _decayHfRatio;
        private float _reflectionsGain;
        private float _reflectionsDelay;
        private float _lateReverbGain;
        private float _lateReverbDelay;
        private float _airAbsorptionGainHf;
        private float _roomRolloffFactor;
        private int _decayHfLimit;

        /// <summary>
        /// Gets or sets Reverb Modal Density which controls the coloration of the late reverb.
        /// Lowering the value adds more coloration to the late reverb.
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbDensity"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.0 - 1.0].</exception>
        public float Density
        {
            get => _density;

            set
            {
                if (value > 1.0f || value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(Density) + " needs to be in the range of [0.0 - 1.0]"
                    );
                }

                _density = value;
            }
        }

        /// <summary>
        /// Gets or sets the Reverb Diffusion property which controls the echo density in the reverberation decay.
        /// It’s set to 1.0 by default, which provides the highest density.
        /// Reducing diffusion gives the reverberation a more “grainy” character that is especially noticeable with percussive sound sources.
        /// If you set a diffusion value of 0.0, the later reverberati on sounds like a succession of distinct echoes.
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbDiffusion"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.0 - 1.0].</exception>
        public float Diffusion
        {
            get => _diffusion;

            set
            {
                if (value > 1.0f || value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(Diffusion) + " needs to be in the range of [0.0 - 1.0]"
                    );
                }

                _diffusion = value;
            }
        }

        /// <summary>
        /// Gets or sets the Reverb Gain property which is the master volume control for the reflected sound (both early reflections and reverberation) that the reverb effect adds to all sound sources.
        /// It sets the maximum amount of reflections and reverberation added to the final sound mix.
        /// The value of the Reverb Gain property ranges from 1.0 (0db) (the maximum amount) to 0.0 (-100db) (no reflected sound at all).
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbGain"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.0 - 1.0].</exception>
        public float Gain
        {
            get => _gain;

            set
            {
                if (value > 1.0f || value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(Gain) + " needs to be in the range of [0.0 - 1.0]"
                    );
                }

                _gain = value;
            }
        }

        /// <summary>
        /// Gets or sets the Reverb Gain HF property which further tweaks reflec ted sound by attenuating it at high frequencies.
        /// It controls a low-pass filter that applies globa lly to the reflected sound of all sound sources feeding the particular instance of the reverb effect.
        /// The value of the Reverb Gain HF property ranges from 1.0 (0db) (no filter) to 0.0 (-100db) (virtually no reflected sound).
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbGainHf"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.0 - 1.0].</exception>
        public float GainHf
        {
            get => _gainHf;

            set
            {
                if (value > 1.0f || value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(GainHf) + " needs to be in the range of [0.0 - 1.0]"
                    );
                }

                _gainHf = value;
            }
        }

        /// <summary>
        /// Gets or sets the Decay Time property which sets the reverberation decay time.
        /// It ranges from 0.1 (typically a small room with very dead surfaces) to 20.0 (typically a large room with very live surfaces).
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbDecayTime"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.1 - 20.0].</exception>
        public float DecayTime
        {
            get => _decayTime;

            set
            {
                if (value > 20.0f || value < 0.1f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(DecayTime) + " needs to be in the range of [0.1 - 29.0]"
                    );
                }

                _decayTime = value;
            }
        }

        /// <summary>
        /// Gets or sets the Decay HF Ratio property which adjusts the spectral quality of the Decay Time parameter.
        /// It is the ratio of high-frequency decay time relative to the time set by Decay Time.
        /// The Decay HF Ratio value 1.0 is neutral: the decay time is equal for all frequencies.
        /// As Decay HF Ratio increases above 1.0, the high-frequency decay time increases so it’s longer than the decay time at mid frequencies.
        /// You hear a more brilliant reverberation with a longer decay at high frequencies.
        /// As the Decay HF Ratio value decreases below 1.0, the high-frequency decay time decreases so it’s shorter than the decay time of the mid frequencies.
        /// You hear a more natural reverberation.
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbDecayHfRatio"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.1 - 20.0].</exception>
        public float DecayHfRatio
        {
            get => _decayHfRatio;

            set
            {
                if (value > 20.0f || value < 0.1f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(DecayHfRatio) + " needs to be in the range of [0.1 - 20.0]"
                    );
                }

                _decayHfRatio = value;
            }
        }

        /// <summary>
        /// Gets or sets the Reflections Gain property which controls the overall amount of initial reflections relative to the Gain property.
        /// (The Gain property sets the overall amount of reflected sound: both initial reflections and later reverberation.)
        /// The value of Reflections Gain ranges from a maximum of 3.16 (+10 dB) to a minimum of 0.0 (-100 dB) (no initial reflections at all), and is corrected by the value of the Gain property.
        /// The Reflections Gain property does not affect the subsequent reverberation decay.
        ///
        /// You can increase the amount of initial reflections to simulate a more narrow space or closer walls, especially effective if you associate the initial reflections increase with a reduction in reflections delays by lowering the value of the Reflection Delay property.
        /// To simulate open or semi-open environments, you can maintain the amount of early reflections while reducing the value of the Late Reverb Gain property, which controls later reflections.
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbReflectionsGain"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.0 - 3.16].</exception>
        public float ReflectionsGain
        {
            get => _reflectionsGain;

            set
            {
                if (value > 3.16f || value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(ReflectionsGain) + " needs to be in the range of [0.0 - 3.16]"
                    );
                }

                _reflectionsGain = value;
            }
        }

        /// <summary>
        /// Gets or sets the Reflections Delay property which is the amount of delay between the arrival time of the direct path from the source to the first reflection from the source.
        /// It ranges from 0 to 300 milliseconds. You can reduce or increase Reflections Delay to simulate closer or more distant reflective surfaces—and therefore control the perceived size of the room.
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbReflectionsDelay"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.0 - 0.3].</exception>
        public float ReflectionsDelay
        {
            get => _reflectionsDelay;

            set
            {
                if (value > 0.3f || value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(ReflectionsDelay) + " needs to be in the range of [0.0 - 0.3]"
                    );
                }

                _reflectionsDelay = value;
            }
        }

        /// <summary>
        /// Gets or sets the Late Reverb Gain property which controls the overall amount of later reverberation relative to the Gain property.
        /// (The Gain property sets the overall amount of both initial reflections and later reverberation.)
        /// The value of Late Reverb Gain ranges from a maximum of 10.0 (+20 dB) to a minimum of 0.0 (-100 dB) (no late reverberation at all).
        ///
        /// Note that Late Reverb Gain and Decay Time are independent properties: If you adjust Decay Time without changing Late Reverb Gain, the total intensity
        /// (the averaged square of the amplitude) of the late reverberation remains constant.
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbLateReverbGain"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.0 - 10.0].</exception>
        public float LateReverbGain
        {
            get => _lateReverbGain;

            set
            {
                if (value > 10.0f || value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(LateReverbGain) + " needs to be in the range of [0.0 - 10.0]"
                    );
                }

                _lateReverbGain = value;
            }
        }

        /// <summary>
        /// Gets or sets the Late Reverb Delay property which defines the begin time of the late reverberation relative to the time of the initial reflection (the first of the early reflections).
        /// It ranges from 0 to 100 milliseconds. Reducing or increasing Late Reverb Delay is useful for simulating a smaller or larger room.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.0 - 0.1].</exception>
        /// <seealso cref="EfxEffectf.ReverbLateReverbDelay"/>
        public float LateReverbDelay
        {
            get => _lateReverbDelay;

            set
            {
                if (value > 0.1f || value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(LateReverbDelay) + " needs to be in the range of [0.0 - 0.1]"
                    );
                }

                _lateReverbDelay = value;
            }
        }

        /// <summary>
        /// Gets or sets the Air Absorption Gain HF property which controls the distance-dependent attenuation at high frequencies caused by the propagation medium.
        /// It applies to reflected sound only. You can use Air Absorption Gain HF to simulate sound transmission through foggy air, dry air, smoky atmosphere, and so on.
        /// The default value is 0.994 (-0.05 dB) per meter, which roughly corresponds to typical condition of atmospheric humidity, temperature, and so on.
        /// Lowering the value simulates a more absorbent medium (more humidity in the air, for example); raising the value simulates a less absorbent medium (dry desert air, for example).
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbAirAbsorptionGainHf"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.892 - 1.0].</exception>
        public float AirAbsorptionGainHf
        {
            get => _airAbsorptionGainHf;

            set
            {
                if (value > 1.0f || value < 0.892f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(AirAbsorptionGainHf) + " needs to be in the range of [0.892 - 1.0]"
                    );
                }

                _airAbsorptionGainHf = value;
            }
        }

        /// <summary>
        /// Gets or sets the Room Rolloff Factor property which is one of two methods available to attenuate the reflected sound (containing both reflections and reverberation) according to source-listener distance.
        /// It’s defined the same way as OpenAL’s Rolloff Factor, but operates on reverb sound instead of direct-path sound.
        /// Setting the Room Rolloff Factor value to 1.0 specifies that the reflected sound will decay by 6 dB every time the distance doubles.
        /// Any value other than 1.0 is equivalent to a scaling factor applied to the quantity specified by ((Source listener distance) - (Reference Distance)).
        /// Reference Distance is an OpenAL source parameter that specifies the inner border for distance rolloff effects:
        /// if the source comes closer to the listener than the reference distance, the direct-path sound isn’t increased as the source comes closer to the listener, and neither is the reflected sound.
        ///
        /// The default value of Room Rolloff Factor is 0.0 because, by default, the Effects Extension reverb effect naturally manages the reflected sound level automatically for each sound source to simulate the natural rolloff of reflected sound vs. distance in typical rooms.
        /// (Note that this isn’t the case if the source property flag <see cref="EfxAuxiliaryi.EffectslotAuxiliarySendAuto"/> is set to false) You can use Room Rolloff Factor as an option to automatic control so you can exaggerate or replace the default automatically-controlled rolloff.
        /// </summary>
        /// <seealso cref="EfxEffectf.ReverbRoomRolloffFactor"/>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if value is not in range of [0.0 - 10.0].</exception>
        public float RoomRolloffFactor
        {
            get => _roomRolloffFactor;

            set
            {
                if (value > 10.0f || value < 0.0f)
                {
                    throw new ArgumentOutOfRangeException
                    (
                        nameof(value), value, nameof(RoomRolloffFactor) + " needs to be in the range of [0.0 - 10.0]"
                    );
                }

                _roomRolloffFactor = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whetHer the high-frequency decay time should automatically stays below a limit value that’s derived from the setting of the property <see cref="AirAbsorptionGainHf"/>.
        /// This limit applies regardless of the setting of the property Decay HF Ratio, and the limit doesn’t affect the value of <see cref="DecayHfRatio"/>
        /// This limit, when on, maintains a natural sounding reverberation decay by allowing you to increase the value of Decay Time without the risk of getting an unnaturally long decay time at high frequencies.
        /// If this flag is set to false, high-frequency decay time isn’t automatically limited.
        /// </summary>
        /// <seealso cref="EfxEffecti.ReverbDecayHFLimit"/>
        public bool DecayHfLimit
        {
            get => _decayHfLimit != 0;
            set => _decayHfLimit = value ? 1 : 0;
        }
    }
}
