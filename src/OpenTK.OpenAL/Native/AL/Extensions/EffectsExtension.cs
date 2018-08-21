/* <see cref="EfxFunctions.cs"/>
 * C headers: \OpenAL <see cref="1.1"/> SDK\include\ "<see cref="efx.h"/>", "efx-<see cref="creative.h"/>", "Efx-<see cref="Util.h"/>"
 * Spec: Effects Extension <see cref="Guide.pdf"/> (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See <see cref="license.txt"/> for license details
 * http://<see cref="www.OpenTK"/><see cref=".net"/> */

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;

namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// Provides access to the OpenAL effects extension.
    /// </summary>
    public partial class EffectsExtension
    {
        private readonly Delegates.AlAuxiliaryEffectSlotf _alAuxiliaryEffectSlotf;

        private readonly Delegates.AlAuxiliaryEffectSloti _alAuxiliaryEffectSloti;

        private readonly Delegates.AlDeleteAuxiliaryEffectSlots _alDeleteAuxiliaryEffectSlots;

        private readonly Delegates.AlDeleteEffects _alDeleteEffects;

        private readonly Delegates.AlDeleteFilters _alDeleteFilters;

        private readonly Delegates.AlEffectf _alEffectf;

        private readonly Delegates.AlEffectfv _alEffectfv;

        private readonly Delegates.AlEffecti _alEffecti;

        private readonly Delegates.AlFilterf _alFilterf;

        private readonly Delegates.AlFilteri _alFilteri;

        private readonly Delegates.AlGenAuxiliaryEffectSlots _alGenAuxiliaryEffectSlots;

        private readonly Delegates.AlGenEffects _alGenEffects;

        private readonly Delegates.AlGenFilters _alGenFilters;

        private readonly Delegates.AlGetAuxiliaryEffectSlotf _alGetAuxiliaryEffectSlotf;

        private readonly Delegates.AlGetAuxiliaryEffectSloti _alGetAuxiliaryEffectSloti;

        private readonly Delegates.AlGetEffectf _alGetEffectf;

        private readonly Delegates.AlGetEffectfv _alGetEffectfv;

        private readonly Delegates.AlGetEffecti _alGetEffecti;

        private readonly Delegates.AlGetFilterf _alGetFilterf;

        private readonly Delegates.AlGetFilteri _alGetFilteri;

        private readonly Delegates.AlIsAuxiliaryEffectSlot _alIsAuxiliaryEffectSlot;

        private readonly Delegates.AlIsEffect _alIsEffect;

        private readonly Delegates.AlIsFilter _alIsFilter;

        /// <summary>
        /// Converts legacy EAX <see cref="EaxReverb"/> to newer EFX <see cref="EfxEaxReverb"/> object.
        /// </summary>
        /// <param name="input">The EAX compatible <see cref="EaxReverb"/> to convert.</param>
        /// <param name="output">The EFX compatible <see cref="EfxEaxReverb"/> conversion result.</param>
        public static void GetEaxFromEfxEax(ref EaxReverb input, out EfxEaxReverb output)
        {
            output = new EfxEaxReverb()
            {
                AirAbsorptionGainHf = input.AirAbsorptionGainHf,
                RoomRolloffFactor = input.RoomRolloffFactor,

                Density = input.Density,
                Diffusion = input.Diffusion,

                DecayTime = input.DecayTime,
                DecayHfLimit = input.DecayHfLimit,
                DecayHfRatio = input.DecayHfRatio,
                DecayLfRatio = 1.0f, // todo, currently default

                EchoDepth = 0f, // todo, currently default
                EchoTime = 0.25f, // todo, currently default

                Gain = input.Gain,
                GainHf = input.GainHf,
                GainLf = 1f, // todo, currently default

                LfReference = 250f, // todo, currently default
                HfReference = 5000f, // todo, currently default

                LateReverbDelay = 0.011f, // todo, currently default
                LateReverbGain = input.LateReverbGain,
                LateReverbPan = default(Vector3), // todo, currently default

                ModulationDepth = 0f, // todo, currently default
                ModulationTime = 0.25f, // todo, currently default

                ReflectionsDelay = input.ReflectionsDelay,
                ReflectionsGain = input.ReflectionsGain,
                ReflectionsPan = default(Vector3), // todo, currently default
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsExtension"/> class.
        /// </summary>
        public EffectsExtension()
        {
            IsInitialized = false;

            if (AudioContext.CurrentContext == null)
            {
                throw new InvalidOperationException("AL.LoadAll() needs a current AudioContext.");
            }

            if (!AudioContext.CurrentContext.SupportsExtension("ALC_EXT_EFX"))
            {
                Debug.Print
                (
                    "EFX Extension (ALC_EXT_EFX) is not supported(AudioContext: {0}).",
                    AudioContext.CurrentContext
                );

                return;
            }

            try
            {
                _alGenEffects = (Delegates.AlGenEffects)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenEffects"), typeof(Delegates.AlGenEffects));
                _alDeleteEffects = (Delegates.AlDeleteEffects)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteEffects"), typeof(Delegates.AlDeleteEffects));
                _alIsEffect = (Delegates.AlIsEffect)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsEffect"), typeof(Delegates.AlIsEffect));
                _alEffecti = (Delegates.AlEffecti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffecti"), typeof(Delegates.AlEffecti));
                _alEffectf = (Delegates.AlEffectf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffectf"), typeof(Delegates.AlEffectf));
                _alEffectfv = (Delegates.AlEffectfv)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffectfv"), typeof(Delegates.AlEffectfv));
                _alGetEffecti = (Delegates.AlGetEffecti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffecti"), typeof(Delegates.AlGetEffecti));
                _alGetEffectf = (Delegates.AlGetEffectf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffectf"), typeof(Delegates.AlGetEffectf));
                _alGetEffectfv = (Delegates.AlGetEffectfv)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffectfv"), typeof(Delegates.AlGetEffectfv));
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to marshal Effect functions. " + e);
                return;
            }

            try
            {
                _alGenFilters = (Delegates.AlGenFilters)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenFilters"), typeof(Delegates.AlGenFilters));
                _alDeleteFilters = (Delegates.AlDeleteFilters)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteFilters"), typeof(Delegates.AlDeleteFilters));
                _alIsFilter = (Delegates.AlIsFilter)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsFilter"), typeof(Delegates.AlIsFilter));
                _alFilteri = (Delegates.AlFilteri)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilteri"), typeof(Delegates.AlFilteri));
                _alFilterf = (Delegates.AlFilterf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilterf"), typeof(Delegates.AlFilterf));
                _alGetFilteri = (Delegates.AlGetFilteri)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetFilteri"), typeof(Delegates.AlGetFilteri));
                _alGetFilterf = (Delegates.AlGetFilterf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetFilterf"), typeof(Delegates.AlGetFilterf));
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to marshal Filter functions. " + e);
                return;
            }

            try
            {
                _alGenAuxiliaryEffectSlots = (Delegates.AlGenAuxiliaryEffectSlots)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenAuxiliaryEffectSlots"), typeof(Delegates.AlGenAuxiliaryEffectSlots));
                _alDeleteAuxiliaryEffectSlots = (Delegates.AlDeleteAuxiliaryEffectSlots)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteAuxiliaryEffectSlots"), typeof(Delegates.AlDeleteAuxiliaryEffectSlots));
                _alIsAuxiliaryEffectSlot = (Delegates.AlIsAuxiliaryEffectSlot)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsAuxiliaryEffectSlot"), typeof(Delegates.AlIsAuxiliaryEffectSlot));
                _alAuxiliaryEffectSloti = (Delegates.AlAuxiliaryEffectSloti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alAuxiliaryEffectSloti"), typeof(Delegates.AlAuxiliaryEffectSloti));
                _alAuxiliaryEffectSlotf = (Delegates.AlAuxiliaryEffectSlotf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alAuxiliaryEffectSlotf"), typeof(Delegates.AlAuxiliaryEffectSlotf));
                _alGetAuxiliaryEffectSloti = (Delegates.AlGetAuxiliaryEffectSloti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetAuxiliaryEffectSloti"), typeof(Delegates.AlGetAuxiliaryEffectSloti));
                _alGetAuxiliaryEffectSlotf = (Delegates.AlGetAuxiliaryEffectSlotf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetAuxiliaryEffectSlotf"), typeof(Delegates.AlGetAuxiliaryEffectSlotf));
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to marshal AuxiliaryEffectSlot functions. " + e);
                return;
            }

            IsInitialized = true;
        }

        // Not used:
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTIV)( ALuint asid, ALenum param, ALint* values );
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTFV)( ALuint asid, ALenum param, ALfloat* values );
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTIV)( ALuint asid, ALenum pname, ALint* values );
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTFV)( ALuint asid, ALenum pname, ALfloat* values );

        /// <summary>
        /// Gets a value indicating whether the EFX Extension has been found and could be initialized.
        /// </summary>
        public bool IsInitialized { get; }

        /// <summary>
        /// (Helper) Selects the Effect type used by this Effect handle.
        /// </summary>
        /// <param name="eid">Effect id returned from a successful call to GenEffects.</param>
        /// <param name="type">Effect type.</param>
        public void BindEffect(uint eid, EfxEffectType type)
        {
            _alEffecti(eid, EfxEffecti.EffectType, (int)type);
        }

        /// <summary>
        /// (Helper) Selects the Effect type used by this Effect handle.
        /// </summary>
        /// <param name="eid">Effect id returned from a successful call to GenEffects.</param>
        /// <param name="type">Effect type.</param>
        public void BindEffect(int eid, EfxEffectType type)
        {
            _alEffecti((uint)eid, EfxEffecti.EffectType, (int)type);
        }

        /// <summary>
        /// (Helper) reroutes the output of a Source through a Filter.
        /// </summary>
        /// <param name="source">A valid Source handle.</param>
        /// <param name="filter">A valid Filter handle.</param>
        public void BindFilterToSource(uint source, uint filter)
        {
            AL.Source(source, ALSourcei.EfxDirectFilter, (int)filter);
        }

        /// <summary>
        /// (Helper) reroutes the output of a Source through a Filter.
        /// </summary>
        /// <param name="source">A valid Source handle.</param>
        /// <param name="filter">A valid Filter handle.</param>
        public void BindFilterToSource(int source, int filter)
        {
            AL.Source((uint)source, ALSourcei.EfxDirectFilter, filter);
        }

        /// <summary>
        /// (Helper) Attaches an Effect to an Auxiliary Effect Slot.
        /// </summary>
        /// <param name="auxiliaryeffectslot">The slot handle to attach the Effect to.</param>
        /// <param name="effect">The Effect handle that is being attached.</param>
        public void BindEffectToAuxiliarySlot(uint auxiliaryeffectslot, uint effect)
        {
            AuxiliaryEffectSlot(auxiliaryeffectslot, EfxAuxiliaryi.EffectslotEffect, (int)effect);
        }

        /// <summary>
        /// (Helper) Attaches an Effect to an Auxiliary Effect Slot.
        /// </summary>
        /// <param name="auxiliaryeffectslot">The slot handle to attach the Effect to.</param>
        /// <param name="effect">The Effect handle that is being attached.</param>
        public void BindEffectToAuxiliarySlot(int auxiliaryeffectslot, int effect)
        {
            AuxiliaryEffectSlot((uint)auxiliaryeffectslot, EfxAuxiliaryi.EffectslotEffect, effect);
        }

        /// <summary>
        /// (Helper) Reroutes a Source's output into an Auxiliary Effect Slot.
        /// </summary>
        /// <param name="source">The Source handle who's output is forwarded.</param>
        /// <param name="slot">The Auxiliary Effect Slot handle that receives input from the Source.</param>
        /// <param name="slotNumber">
        /// Every Source has only a limited number of slots it can feed buffer to. The number must stay
        /// below <see cref="AlcContextAttributes.EfxMaxAuxiliarySends"/>.
        /// </param>
        /// <param name="filter">
        /// Filter handle to be attached between Source ouput and Auxiliary Slot input. Use 0 or
        /// <see cref="EfxFilterType.Null"/> for no filter.
        /// </param>
        public void BindSourceToAuxiliarySlot(uint source, uint slot, int slotNumber, uint filter)
        {
            AL.Source(source, ALSource3i.EfxAuxiliarySendFilter, (int)slot, slotNumber, (int)filter);
        }

        /// <summary>
        /// (Helper) Reroutes a Source's output into an Auxiliary Effect Slot.
        /// </summary>
        /// <param name="source">The Source handle who's output is forwarded.</param>
        /// <param name="slot">The Auxiliary Effect Slot handle that receives input from the Source.</param>
        /// <param name="slotNumber">
        /// Every Source has only a limited number of slots it can feed buffer to. The number must stay
        /// below <see cref="AlcContextAttributes.EfxMaxAuxiliarySends"/>.
        /// </param>
        /// <param name="filter">
        /// Filter handle to be attached between Source output and Auxiliary Slot input. Use 0 or
        /// <see cref="EfxFilterType.Null"/> for no filter.
        /// </param>
        public void BindSourceToAuxiliarySlot(int source, int slot, int slotNumber, int filter)
        {
            AL.Source((uint)source, ALSource3i.EfxAuxiliarySendFilter, slot, slotNumber, filter);
        }

        /// <summary>
        /// The GenEffects function is used to create one or more Effect objects. An Effect object stores an effect type
        /// and a set of parameter values to control that Effect. In order to use an Effect it must be attached to an Auxiliary
        /// Effect Slot object.
        /// </summary>
        /// <remarks>
        /// After creation an Effect has no type (<see cref="EfxEffectType.Null"/>), so before it can be used to store a set of
        /// parameters, the application must specify what type of effect should be stored in the object, using Effect() with
        /// EfxEffecti.
        /// </remarks>
        /// <param name="n">Number of Effects to be created.</param>
        /// <param name="effects">Pointer addressing sufficient memory to store n Effect object identifiers.</param>
        public void GenEffects(int n, out uint effects)
        {
            unsafe
            {
                fixed (uint* ptr = &effects)
                {
                    _alGenEffects(n, ptr);
                    effects = *ptr;
                }
            }
        }

        /// <summary>
        /// The GenEffects function is used to create one or more Effect objects. An Effect object stores an effect type
        /// and a set of parameter values to control that Effect. In order to use an Effect it must be attached to an Auxiliary
        /// Effect Slot object.
        /// </summary>
        /// <remarks>
        /// After creation an Effect has no type (<see cref="EfxEffectType.Null"/>), so before it can be used to store a set of
        /// parameters, the application must specify what type of effect should be stored in the object, using Effect() with
        /// EfxEffecti.
        /// </remarks>
        /// <param name="n">Number of Effects to be created.</param>
        /// <param name="effects">Pointer addressing sufficient memory to store n Effect object identifiers.</param>
        public void GenEffects(int n, out int effects)
        {
            unsafe
            {
                fixed (int* ptr = &effects)
                {
                    _alGenEffects(n, (uint*)ptr);
                    effects = *ptr;
                }
            }
        }

        /// <summary>
        /// Generates one or more effect objects.
        /// </summary>
        /// <param name="n">Number of Effect object identifiers to generate.</param>
        /// <remarks>
        ///  <para>
        /// The GenEffects function is used to create one or more Effect objects. An Effect object stores an effect type
        /// and a set of parameter values to control that Effect. In order to use an Effect it must be attached to an
        /// Auxiliary Effect Slot object.
        ///  </para>
        ///  <para>
        /// After creation an Effect has no type (<see cref="EfxEffectType.Null"/>), so before it can be used to store a set of
        /// parameters, the application must specify what type of effect should be stored in the object, using Effect()
        /// with EfxEffecti.
        ///  </para>
        /// </remarks>
        /// <returns>The generated effect names.</returns>
        public int[] GenEffects(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Must be higher than 0.");
            }

            var effects = new int[n];
            GenEffects(n, out effects[0]);
            return effects;
        }

        /// <summary>
        /// Generates a single effect object.
        /// </summary>
        /// <returns>A handle to the generated effect object.</returns>
        /// <remarks>
        ///  <para>
        /// The GenEffects function is used to create one or more Effect objects. An Effect object stores an effect type
        /// and a set of parameter values to control that Effect. In order to use an Effect it must be attached to an
        /// Auxiliary Effect Slot object.
        ///  </para>
        ///  <para>
        /// After creation an Effect has no type (<see cref="EfxEffectType.Null"/>), so before it can be used to store a set of
        /// parameters, the application must specify what type of effect should be stored in the object, using Effect()
        /// with EfxEffecti.
        ///  </para>
        /// </remarks>
        public int GenEffect()
        {
            GenEffects(1, out int temp);
            return temp;
        }

        /// <summary>
        /// Generates a single effect object.
        /// </summary>
        /// <param name="effect">A handle to the generated effect object.</param>
        public void GenEffect(out uint effect)
        {
            unsafe
            {
                fixed (uint* ptr = &effect)
                {
                    _alGenEffects(1, ptr);
                    effect = *ptr;
                }
            }
        }

        /// <summary>
        /// The DeleteEffects function is used to delete and free resources for Effect objects previously created with
        /// GenEffects.
        /// </summary>
        /// <param name="n">Number of Effects to be deleted.</param>
        /// <param name="effects">Pointer to n Effect object identifiers.</param>
        public void DeleteEffects(int n, ref uint effects)
        {
            unsafe
            {
                fixed (uint* ptr = &effects)
                {
                    _alDeleteEffects(n, ptr);
                }
            }
        }

        /// <summary>
        /// The DeleteEffects function is used to delete and free resources for Effect objects previously created with
        /// GenEffects.
        /// </summary>
        /// <param name="n">Number of Effects to be deleted.</param>
        /// <param name="effects">Pointer to n Effect object identifiers.</param>
        public void DeleteEffects(int n, ref int effects)
        {
            unsafe
            {
                fixed (int* ptr = &effects)
                {
                    _alDeleteEffects(n, (uint*)ptr);
                }
            }
        }

        /// <summary>
        /// The DeleteEffects function is used to delete and free resources for Effect objects previously created with
        /// GenEffects.
        /// </summary>
        /// <param name="effects">Pointer to n Effect object identifiers.</param>
        public void DeleteEffects(int[] effects)
        {
            if (effects == null)
            {
                throw new ArgumentNullException(nameof(effects));
            }

            DeleteEffects(effects.Length, ref effects[0]);
        }

        /// <summary>
        /// The DeleteEffects function is used to delete and free resources for Effect objects previously created with
        /// GenEffects.
        /// </summary>
        /// <param name="effects">Pointer to n Effect object identifiers.</param>
        public void DeleteEffects(uint[] effects)
        {
            if (effects == null)
            {
                throw new ArgumentNullException(nameof(effects));
            }

            DeleteEffects(effects.Length, ref effects[0]);
        }

        /// <summary>
        /// This function deletes one Effect only.
        /// </summary>
        /// <param name="effect">Pointer to an effect name/handle identifying the Effect Object to be deleted.</param>
        public void DeleteEffect(int effect)
        {
            DeleteEffects(1, ref effect);
        }

        /// <summary>
        /// This function deletes one Effect only.
        /// </summary>
        /// <param name="effect">Pointer to an effect name/handle identifying the Effect Object to be deleted.</param>
        public void DeleteEffect(ref uint effect)
        {
            unsafe
            {
                fixed (uint* ptr = &effect)
                {
                    _alDeleteEffects(1, ptr);
                }
            }
        }

        /// <summary>
        /// The IsEffect function is used to determine if an object identifier is a valid Effect object.
        /// </summary>
        /// <param name="eid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Effect, False otherwise.</returns>
        public bool IsEffect(uint eid)
        {
            return _alIsEffect(eid);
        }

        /// <summary>
        /// The IsEffect function is used to determine if an object identifier is a valid Effect object.
        /// </summary>
        /// <param name="eid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Effect, False otherwise.</returns>
        public bool IsEffect(int eid)
        {
            return _alIsEffect((uint)eid);
        }

        /// <summary>
        /// This function is used to set integer properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        public void Effect(uint eid, EfxEffecti param, int value)
        {
            _alEffecti(eid, param, value);
        }

        /// <summary>
        /// This function is used to set integer properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        public void Effect(int eid, EfxEffecti param, int value)
        {
            _alEffecti((uint)eid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void Effect(uint eid, EfxEffectf param, float value)
        {
            _alEffectf(eid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void Effect(int eid, EfxEffectf param, float value)
        {
            _alEffectf((uint)eid, param, value);
        }

        /// <summary>
        /// This function is used to set 3 floating-point properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="values">Pointer to <see cref="Mathematics.Vector3"/>.</param>
        public void Effect(uint eid, EfxEffect3f param, ref Vector3 values)
        {
            unsafe
            {
                fixed (float* ptr = &values.X)
                {
                    _alEffectfv(eid, param, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to set 3 floating-point properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="values">Pointer to <see cref="Mathematics.Vector3"/>.</param>
        public void Effect(int eid, EfxEffect3f param, ref Vector3 values)
        {
            Effect((uint)eid, param, ref values);
        }

        /// <summary>
        /// This function is used to retrieve integer properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetEffect(uint eid, EfxEffecti pname, out int value)
        {
            unsafe
            {
                fixed (int* ptr = &value)
                {
                    _alGetEffecti(eid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve integer properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetEffect(int eid, EfxEffecti pname, out int value)
        {
            GetEffect((uint)eid, pname, out value);
        }

        /// <summary>
        /// This function is used to retrieve floating-point properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetEffect(uint eid, EfxEffectf pname, out float value)
        {
            unsafe
            {
                fixed (float* ptr = &value)
                {
                    _alGetEffectf(eid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve floating-point properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetEffect(int eid, EfxEffectf pname, out float value)
        {
            GetEffect((uint)eid, pname, out value);
        }

        /// <summary>
        /// This function is used to retrieve 3 floating-point properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to retrieve.</param>
        /// <param name="values">A <see cref="Mathematics.Vector3"/> to hold the values.</param>
        public void GetEffect(uint eid, EfxEffect3f param, out Vector3 values)
        {
            unsafe
            {
                fixed (float* ptr = &values.X)
                {
                    _alGetEffectfv(eid, param, ptr);
                    values.X = ptr[0];
                    values.Y = ptr[1];
                    values.Z = ptr[2];
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve 3 floating-point properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to retrieve.</param>
        /// <param name="values">A <see cref="Mathematics.Vector3"/> to hold the values.</param>
        public void GetEffect(int eid, EfxEffect3f param, out Vector3 values)
        {
            GetEffect((uint)eid, param, out values);
        }

        /// <summary>
        /// The GenFilters function is used to create one or more Filter objects. A Filter object stores a filter type and
        /// a set of parameter values to control that Filter. Filter objects can be attached to Sources as Direct Filters or
        /// Auxiliary Send Filters.
        /// </summary>
        /// <remarks>
        /// After creation a Filter has no type (<see cref="EfxFilterType.Null"/>), so before it can be used to store a set of
        /// parameters, the application must specify what type of filter should be stored in the object, using Filter() with
        /// EfxFilteri.
        /// </remarks>
        /// <param name="n">Number of Filters to be created.</param>
        /// <param name="filters">Pointer addressing sufficient memory to store n Filter object identifiers.</param>
        public void GenFilters(int n, out uint filters)
        {
            unsafe
            {
                fixed (uint* ptr = &filters)
                {
                    _alGenFilters(n, ptr);
                    filters = *ptr;
                }
            }
        }

        /// <summary>
        /// The GenFilters function is used to create one or more Filter objects. A Filter object stores a filter type and
        /// a set of parameter values to control that Filter. Filter objects can be attached to Sources as Direct Filters or
        /// Auxiliary Send Filters.
        /// </summary>
        /// <remarks>
        /// After creation a Filter has no type (<see cref="EfxFilterType.Null"/>), so before it can be used to store a set of
        /// parameters, the application must specify what type of filter should be stored in the object, using Filter() with
        /// EfxFilteri.
        /// </remarks>
        /// <param name="n">Number of Filters to be created.</param>
        /// <param name="filters">Pointer addressing sufficient memory to store n Filter object identifiers.</param>
        public void GenFilters(int n, out int filters)
        {
            unsafe
            {
                fixed (int* ptr = &filters)
                {
                    _alGenFilters(n, (uint*)ptr);
                    filters = *ptr;
                }
            }
        }

        /// <summary>
        /// The GenFilters function is used to create one or more Filter objects. A Filter object stores a filter type and
        /// a set of parameter values to control that Filter. Filter objects can be attached to Sources as Direct Filters or
        /// Auxiliary Send Filters.
        /// </summary>
        /// <remarks>
        /// After creation a Filter has no type (<see cref="EfxFilterType.Null"/>), so before it can be used to store a set of
        /// parameters, the application must specify what type of filter should be stored in the object, using Filter() with
        /// EfxFilteri.
        /// </remarks>
        /// <param name="n">Number of Filters to be created.</param>
        /// <returns>Pointer addressing sufficient memory to store n Filter object identifiers.</returns>
        public int[] GenFilters(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Must be higher than 0.");
            }

            var filters = new int[n];
            GenFilters(filters.Length, out filters[0]);
            return filters;
        }

        /// <summary>
        /// This function generates only one Filter.
        /// </summary>
        /// <returns>Storage Int32 for the new filter name/handle.</returns>
        public int GenFilter()
        {
            GenFilters(1, out int filter);
            return filter;
        }

        /// <summary>
        /// This function generates only one Filter.
        /// </summary>
        /// <param name="filter">Storage UInt32 for the new filter name/handle.</param>
        public unsafe void GenFilter(out uint filter)
        {
            fixed (uint* ptr = &filter)
            {
                _alGenFilters(1, ptr);
                filter = *ptr;
            }
        }

        /// <summary>
        /// The DeleteFilters function is used to delete and free resources for Filter objects previously created with
        /// GenFilters.
        /// </summary>
        /// <param name="n">Number of Filters to be deleted.</param>
        /// <param name="filters">Pointer to n Filter object identifiers.</param>
        public void DeleteFilters(int n, ref uint filters)
        {
            unsafe
            {
                fixed (uint* ptr = &filters)
                {
                    _alDeleteFilters(n, ptr);
                }
            }
        }

        /// <summary>
        /// The DeleteFilters function is used to delete and free resources for Filter objects previously created with
        /// GenFilters.
        /// </summary>
        /// <param name="n">Number of Filters to be deleted.</param>
        /// <param name="filters">Pointer to n Filter object identifiers.</param>
        public void DeleteFilters(int n, ref int filters)
        {
            unsafe
            {
                fixed (int* ptr = &filters)
                {
                    _alDeleteFilters(n, (uint*)ptr);
                }
            }
        }

        /// <summary>
        /// This function deletes one Filter only.
        /// </summary>
        /// <param name="filters">Pointer to an filter name/handle identifying the Filter Object to be deleted.</param>
        public void DeleteFilters(uint[] filters)
        {
            if (filters == null)
            {
                throw new ArgumentNullException(nameof(filters));
            }

            DeleteFilters(filters.Length, ref filters[0]);
        }

        /// <summary>
        /// This function deletes one Filter only.
        /// </summary>
        /// <param name="filters">Pointer to an filter name/handle identifying the Filter Object to be deleted.</param>
        public void DeleteFilters(int[] filters)
        {
            if (filters == null)
            {
                throw new ArgumentNullException(nameof(filters));
            }

            DeleteFilters(filters.Length, ref filters[0]);
        }

        /// <summary>
        /// This function deletes one Filter only.
        /// </summary>
        /// <param name="filter">Pointer to an filter name/handle identifying the Filter Object to be deleted.</param>
        public void DeleteFilter(int filter)
        {
            DeleteFilters(1, ref filter);
        }

        /// <summary>
        /// This function deletes one Filter only.
        /// </summary>
        /// <param name="filter">Pointer to an filter name/handle identifying the Filter Object to be deleted.</param>
        public void DeleteFilter(ref uint filter)
        {
            unsafe
            {
                fixed (uint* ptr = &filter)
                {
                    _alDeleteFilters(1, ptr);
                }
            }
        }

        /// <summary>
        /// The IsFilter function is used to determine if an object identifier is a valid Filter object.
        /// </summary>
        /// <param name="fid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Filter, False otherwise.</returns>
        public bool IsFilter(uint fid)
        {
            return _alIsFilter(fid);
        }

        /// <summary>
        /// The IsFilter function is used to determine if an object identifier is a valid Filter object.
        /// </summary>
        /// <param name="fid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Filter, False otherwise.</returns>
        public bool IsFilter(int fid)
        {
            return _alIsFilter((uint)fid);
        }

        /// <summary>
        /// This function is used to set integer properties on Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        public void Filter(uint fid, EfxFilteri param, int value)
        {
            _alFilteri(fid, param, value);
        }

        /// <summary>
        /// This function is used to set integer properties on Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        public void Filter(int fid, EfxFilteri param, int value)
        {
            _alFilteri((uint)fid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void Filter(uint fid, EfxFilterf param, float value)
        {
            _alFilterf(fid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void Filter(int fid, EfxFilterf param, float value)
        {
            _alFilterf((uint)fid, param, value);
        }

        /// <summary>
        /// This function is used to retrieve integer properties from Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetFilter(uint fid, EfxFilteri pname, out int value)
        {
            unsafe
            {
                fixed (int* ptr = &value)
                {
                    _alGetFilteri(fid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve integer properties from Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetFilter(int fid, EfxFilteri pname, out int value)
        {
            GetFilter((uint)fid, pname, out value);
        }

        /// <summary>
        /// This function is used to retrieve floating-point properties from Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetFilter(uint fid, EfxFilterf pname, out float value)
        {
            unsafe
            {
                fixed (float* ptr = &value)
                {
                    _alGetFilterf(fid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve floating-point properties from Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetFilter(int fid, EfxFilterf pname, out float value)
        {
            GetFilter((uint)fid, pname, out value);
        }

        /// <summary>
        /// The GenAuxiliaryEffectSlots function is used to create one or more Auxiliary Effect Slots. The number of slots
        /// that can be created will be dependant upon the Open AL device used.
        /// </summary>
        /// <remarks>
        /// An application should check the OpenAL error state after making this call to determine if the Effect Slot was
        /// successfully created. If the function call fails then none of the requested Effect Slots are created. A good
        /// strategy for creating any OpenAL object is to use a for-loop and generate one object each loop iteration and then
        /// check for an error condition. If an error is set then the loop can be broken and the application can determine if
        /// sufficient resources are available.
        /// </remarks>
        /// <param name="n">Number of Auxiliary Effect Slots to be created.</param>
        /// <param name="slots">Pointer addressing sufficient memory to store n Effect Slot object identifiers.</param>
        public void GenAuxiliaryEffectSlots(int n, out uint slots)
        {
            unsafe
            {
                fixed (uint* ptr = &slots)
                {
                    _alGenAuxiliaryEffectSlots(n, ptr);
                    slots = *ptr;
                }
            }
        }

        /// <summary>
        /// The GenAuxiliaryEffectSlots function is used to create one or more Auxiliary Effect Slots. The number of slots
        /// that can be created will be dependant upon the Open AL device used.
        /// </summary>
        /// <remarks>
        /// An application should check the OpenAL error state after making this call to determine if the Effect Slot was
        /// successfully created. If the function call fails then none of the requested Effect Slots are created. A good
        /// strategy for creating any OpenAL object is to use a for-loop and generate one object each loop iteration and then
        /// check for an error condition. If an error is set then the loop can be broken and the application can determine if
        /// sufficient resources are available.
        /// </remarks>
        /// <param name="n">Number of Auxiliary Effect Slots to be created.</param>
        /// <param name="slots">Pointer addressing sufficient memory to store n Effect Slot object identifiers.</param>
        public void GenAuxiliaryEffectSlots(int n, out int slots)
        {
            unsafe
            {
                fixed (int* ptr = &slots)
                {
                    _alGenAuxiliaryEffectSlots(n, (uint*)ptr);
                    slots = *ptr;
                }
            }
        }

        /// <summary>
        /// The GenAuxiliaryEffectSlots function is used to create one or more Auxiliary Effect Slots. The number of slots
        /// that can be created will be dependant upon the Open AL device used.
        /// </summary>
        /// <remarks>
        /// An application should check the OpenAL error state after making this call to determine if the Effect Slot was
        /// successfully created. If the function call fails then none of the requested Effect Slots are created. A good
        /// strategy for creating any OpenAL object is to use a for-loop and generate one object each loop iteration and then
        /// check for an error condition. If an error is set then the loop can be broken and the application can determine if
        /// sufficient resources are available.
        /// </remarks>
        /// <param name="n">Number of Auxiliary Effect Slots to be created.</param>
        /// <returns>Pointer addressing sufficient memory to store n Effect Slot object identifiers.</returns>
        public int[] GenAuxiliaryEffectSlots(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Must be higher than 0.");
            }

            var slots = new int[n];
            GenAuxiliaryEffectSlots(slots.Length, out slots[0]);
            return slots;
        }

        /// <summary>
        /// This function generates only one Auxiliary Effect Slot.
        /// </summary>
        /// <returns>Storage Int32 for the new auxiliary effect slot name/handle.</returns>
        public int GenAuxiliaryEffectSlot()
        {
            GenAuxiliaryEffectSlots(1, out int temp);
            return temp;
        }

        /// <summary>
        /// This function generates only one Auxiliary Effect Slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        public void GenAuxiliaryEffectSlot(out uint slot)
        {
            unsafe
            {
                fixed (uint* ptr = &slot)
                {
                    _alGenAuxiliaryEffectSlots(1, ptr);
                    slot = *ptr;
                }
            }
        }

        /// <summary>
        /// The DeleteAuxiliaryEffectSlots function is used to delete and free resources for Auxiliary Effect Slots
        /// previously created with GenAuxiliaryEffectSlots.
        /// </summary>
        /// <param name="n">Number of Auxiliary Effect Slots to be deleted.</param>
        /// <param name="slots">Pointer to n Effect Slot object identifiers.</param>
        public void DeleteAuxiliaryEffectSlots(int n, ref uint slots)
        {
            unsafe
            {
                fixed (uint* ptr = &slots)
                {
                    _alDeleteAuxiliaryEffectSlots(n, ptr);
                }
            }
        }

        /// <summary>
        /// The DeleteAuxiliaryEffectSlots function is used to delete and free resources for Auxiliary Effect Slots
        /// previously created with GenAuxiliaryEffectSlots.
        /// </summary>
        /// <param name="n">Number of Auxiliary Effect Slots to be deleted.</param>
        /// <param name="slots">Pointer to n Effect Slot object identifiers.</param>
        public void DeleteAuxiliaryEffectSlots(int n, ref int slots)
        {
            unsafe
            {
                fixed (int* ptr = &slots)
                {
                    _alDeleteAuxiliaryEffectSlots(n, (uint*)ptr);
                }
            }
        }

        /// <summary>
        /// The DeleteAuxiliaryEffectSlots function is used to delete and free resources for Auxiliary Effect Slots
        /// previously created with GenAuxiliaryEffectSlots.
        /// </summary>
        /// <param name="slots">Pointer to n Effect Slot object identifiers.</param>
        public void DeleteAuxiliaryEffectSlots(int[] slots)
        {
            if (slots == null)
            {
                throw new ArgumentNullException(nameof(slots));
            }

            DeleteAuxiliaryEffectSlots(slots.Length, ref slots[0]);
        }

        /// <summary>
        /// This function deletes one AuxiliaryEffectSlot only.
        /// </summary>
        /// <param name="slots">
        /// Pointer to an auxiliary effect slot name/handle identifying the Auxiliary Effect Slot Object to be
        /// deleted.
        /// </param>
        public void DeleteAuxiliaryEffectSlots(uint[] slots)
        {
            if (slots == null)
            {
                throw new ArgumentNullException(nameof(slots));
            }

            DeleteAuxiliaryEffectSlots(slots.Length, ref slots[0]);
        }

        /// <summary>
        /// This function deletes one AuxiliaryEffectSlot only.
        /// </summary>
        /// <param name="slot">
        /// Pointer to an auxiliary effect slot name/handle identifying the Auxiliary Effect Slot Object to be
        /// deleted.
        /// </param>
        public void DeleteAuxiliaryEffectSlot(int slot)
        {
            DeleteAuxiliaryEffectSlots(1, ref slot);
        }

        /// <summary>
        /// This function deletes one AuxiliaryEffectSlot only.
        /// </summary>
        /// <param name="slot">
        /// Pointer to an auxiliary effect slot name/handle identifying the Auxiliary Effect Slot Object to be
        /// deleted.
        /// </param>
        public void DeleteAuxiliaryEffectSlot(ref uint slot)
        {
            unsafe
            {
                fixed (uint* ptr = &slot)
                {
                    _alDeleteAuxiliaryEffectSlots(1, ptr);
                }
            }
        }

        /// <summary>
        /// The IsAuxiliaryEffectSlot function is used to determine if an object identifier is a valid Auxiliary Effect
        /// Slot object.
        /// </summary>
        /// <param name="slot">Effect Slot object identifier to validate.</param>
        /// <returns>True if the identifier is a valid Auxiliary Effect Slot, False otherwise.</returns>
        public bool IsAuxiliaryEffectSlot(uint slot)
        {
            return _alIsAuxiliaryEffectSlot(slot);
        }

        /// <summary>
        /// The IsAuxiliaryEffectSlot function is used to determine if an object identifier is a valid Auxiliary Effect
        /// Slot object.
        /// </summary>
        /// <param name="slot">Effect Slot object identifier to validate.</param>
        /// <returns>True if the identifier is a valid Auxiliary Effect Slot, False otherwise.</returns>
        public bool IsAuxiliaryEffectSlot(int slot)
        {
            return _alIsAuxiliaryEffectSlot((uint)slot);
        }

        /// <summary>
        /// This function is used to set integer properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Integer value.</param>
        public void AuxiliaryEffectSlot(uint asid, EfxAuxiliaryi param, int value)
        {
            _alAuxiliaryEffectSloti(asid, param, value);
        }

        /// <summary>
        /// This function is used to set integer properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Integer value.</param>
        public void AuxiliaryEffectSlot(int asid, EfxAuxiliaryi param, int value)
        {
            _alAuxiliaryEffectSloti((uint)asid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void AuxiliaryEffectSlot(uint asid, EfxAuxiliaryf param, float value)
        {
            _alAuxiliaryEffectSlotf(asid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void AuxiliaryEffectSlot(int asid, EfxAuxiliaryf param, float value)
        {
            _alAuxiliaryEffectSlotf((uint)asid, param, value);
        }

        /// <summary>
        /// This function is used to retrieve integer properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetAuxiliaryEffectSlot(uint asid, EfxAuxiliaryi pname, out int value)
        {
            unsafe
            {
                fixed (int* ptr = &value)
                {
                    _alGetAuxiliaryEffectSloti(asid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve integer properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetAuxiliaryEffectSlot(int asid, EfxAuxiliaryi pname, out int value)
        {
            GetAuxiliaryEffectSlot((uint)asid, pname, out value);
        }

        /// <summary>
        /// This function is used to retrieve floating properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetAuxiliaryEffectSlot(uint asid, EfxAuxiliaryf pname, out float value)
        {
            unsafe
            {
                fixed (float* ptr = &value)
                {
                    _alGetAuxiliaryEffectSlotf(asid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve floating properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetAuxiliaryEffectSlot(int asid, EfxAuxiliaryf pname, out float value)
        {
            GetAuxiliaryEffectSlot((uint)asid, pname, out value);
        }

        private static class Delegates
        {
            public unsafe delegate void AlGenEffects(int n, [Out] uint* effects);

            public unsafe delegate void AlDeleteEffects(int n, [In] uint* effects);

            public delegate bool AlIsEffect(uint eid);

            public delegate void AlEffecti(uint eid, EfxEffecti param, int value);

            public delegate void AlEffectf(uint eid, EfxEffectf param, float value);

            public unsafe delegate void AlEffectfv(uint eid, EfxEffect3f param, [In] float* values);

            public unsafe delegate void AlGetEffecti(uint eid, EfxEffecti pname, [Out] int* value);

            public unsafe delegate void AlGetEffectf(uint eid, EfxEffectf pname, [Out] float* value);

            public unsafe delegate void AlGetEffectfv(uint eid, EfxEffect3f param, [Out] float* values);

            public unsafe delegate void AlGenFilters(int n, [Out] uint* filters);

            public unsafe delegate void AlDeleteFilters(int n, [In] uint* filters);

            public delegate bool AlIsFilter(uint fid);

            public delegate void AlFilteri(uint fid, EfxFilteri param, int value);

            public delegate void AlFilterf(uint fid, EfxFilterf param, float value);

            public unsafe delegate void AlGetFilteri(uint fid, EfxFilteri pname, [Out] int* value);

            public unsafe delegate void AlGetFilterf(uint fid, EfxFilterf pname, [Out] float* value);

            public unsafe delegate void AlGenAuxiliaryEffectSlots(int n, [Out] uint* slots);

            public unsafe delegate void AlDeleteAuxiliaryEffectSlots(int n, [In] uint* slots);

            public delegate bool AlIsAuxiliaryEffectSlot(uint slot);

            public delegate void AlAuxiliaryEffectSloti(uint asid, EfxAuxiliaryi param, int value);

            public delegate void AlAuxiliaryEffectSlotf(uint asid, EfxAuxiliaryf param, float value);

            public unsafe delegate void AlGetAuxiliaryEffectSloti(uint asid, EfxAuxiliaryi pname, [Out] int* value);

            public unsafe delegate void AlGetAuxiliaryEffectSlotf(uint asid, EfxAuxiliaryf pname, [Out] float* value);
        }
    }
}
