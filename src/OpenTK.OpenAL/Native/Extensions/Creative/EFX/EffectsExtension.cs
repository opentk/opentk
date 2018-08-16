/* <see cref="EfxFunctions.cs"/>
 * C headers: \OpenAL <see cref="1.1"/> SDK\include\ "<see cref="efx.h"/>", "efx-<see cref="creative.h"/>", "Efx-<see cref="Util.h"/>"
 * Spec: Effects Extension <see cref="Guide.pdf"/> (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See <see cref="license.txt"/> for license details
 * http://<see cref="www.OpenTK"/><see cref=".net"/> */

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;

namespace OpenTK.OpenAL.Native.Extensions.Creative.EFX
{
    /// <summary>
    /// Provides access to the OpenAL effects extension.
    /// </summary>
    public partial class EffectsExtension
    {
        private readonly ALDelegateAuxiliaryEffectSlotf _delegateALAuxiliaryEffectSlotf;

        private readonly ALDelegateAuxiliaryEffectSloti _delegateALAuxiliaryEffectSloti;

        private readonly ALDelegateDeleteAuxiliaryEffectSlots _delegateALDeleteAuxiliaryEffectSlots;

        private readonly ALDelegateDeleteEffects _delegateALDeleteEffects;

        private readonly ALDelegateDeleteFilters _delegateALDeleteFilters;

        private readonly ALDelegateEffectf _delegateALEffectf;

        private readonly ALDelegateEffectfv _delegateALEffectfv;

        private readonly ALDelegateEffecti _delegateALEffecti;

        private readonly ALDelegateFilterf _delegateALFilterf;

        private readonly ALDelegateFilteri _delegateALFilteri;

        private readonly ALDelegateGenAuxiliaryEffectSlots _delegateALGenAuxiliaryEffectSlots;

        private readonly ALDelegateGenEffects _delegateALGenEffects;

        private readonly ALDelegateGenFilters _delegateALGenFilters;

        private readonly ALDelegateGetAuxiliaryEffectSlotf _delegateALGetAuxiliaryEffectSlotf;

        private readonly ALDelegateGetAuxiliaryEffectSloti _delegateALGetAuxiliaryEffectSloti;

        private readonly ALDelegateGetEffectf _delegateALGetEffectf;

        private readonly ALDelegateGetEffectfv _delegateALGetEffectfv;

        private readonly ALDelegateGetEffecti _delegateALGetEffecti;

        private readonly ALDelegateGetFilterf _delegateALGetFilterf;

        private readonly ALDelegateGetFilteri _delegateALGetFilteri;

        private readonly ALDelegateIsAuxiliaryEffectSlot _delegateALIsAuxiliaryEffectSlot;

        private readonly ALDelegateIsEffect _delegateALIsEffect;

        private readonly ALDelegateIsFilter _delegateALIsFilter;

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
                _delegateALGenEffects = (ALDelegateGenEffects)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alGenEffects"),
                    typeof(ALDelegateGenEffects)
                );

                _delegateALDeleteEffects = (ALDelegateDeleteEffects)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alDeleteEffects"),
                    typeof(ALDelegateDeleteEffects)
                );

                _delegateALIsEffect = (ALDelegateIsEffect)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alIsEffect"),
                    typeof(ALDelegateIsEffect)
                );

                _delegateALEffecti = (ALDelegateEffecti)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alEffecti"),
                    typeof(ALDelegateEffecti)
                );

                _delegateALEffectf = (ALDelegateEffectf)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alEffectf"),
                    typeof(ALDelegateEffectf)
                );

                _delegateALEffectfv = (ALDelegateEffectfv)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alEffectfv"),
                    typeof(ALDelegateEffectfv)
                );

                _delegateALGetEffecti = (ALDelegateGetEffecti)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alGetEffecti"),
                    typeof(ALDelegateGetEffecti)
                );

                _delegateALGetEffectf = (ALDelegateGetEffectf)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alGetEffectf"),
                    typeof(ALDelegateGetEffectf)
                );

                _delegateALGetEffectfv = (ALDelegateGetEffectfv)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alGetEffectfv"),
                    typeof(ALDelegateGetEffectfv)
                );
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to marshal Effect functions. " + e);
                return;
            }

            try
            {
                _delegateALGenFilters = (ALDelegateGenFilters)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alGenFilters"),
                    typeof(ALDelegateGenFilters)
                );

                _delegateALDeleteFilters = (ALDelegateDeleteFilters)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alDeleteFilters"),
                    typeof(ALDelegateDeleteFilters)
                );

                _delegateALIsFilter = (ALDelegateIsFilter)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alIsFilter"),
                    typeof(ALDelegateIsFilter)
                );

                _delegateALFilteri = (ALDelegateFilteri)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alFilteri"),
                    typeof(ALDelegateFilteri)
                );

                _delegateALFilterf = (ALDelegateFilterf)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alFilterf"),
                    typeof(ALDelegateFilterf)
                );

                _delegateALGetFilteri = (ALDelegateGetFilteri)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alGetFilteri"),
                    typeof(ALDelegateGetFilteri)
                );

                _delegateALGetFilterf = (ALDelegateGetFilterf)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alGetFilterf"),
                    typeof(ALDelegateGetFilterf)
                );
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to marshal Filter functions. " + e);
                return;
            }

            try
            {
                _delegateALGenAuxiliaryEffectSlots = (ALDelegateGenAuxiliaryEffectSlots)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alGenAuxiliaryEffectSlots"),
                    typeof(ALDelegateGenAuxiliaryEffectSlots)
                );

                _delegateALDeleteAuxiliaryEffectSlots = (ALDelegateDeleteAuxiliaryEffectSlots)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alDeleteAuxiliaryEffectSlots"),
                    typeof(ALDelegateDeleteAuxiliaryEffectSlots)
                );

                _delegateALIsAuxiliaryEffectSlot = (ALDelegateIsAuxiliaryEffectSlot)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alIsAuxiliaryEffectSlot"),
                    typeof(ALDelegateIsAuxiliaryEffectSlot)
                );

                _delegateALAuxiliaryEffectSloti = (ALDelegateAuxiliaryEffectSloti)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alAuxiliaryEffectSloti"),
                    typeof(ALDelegateAuxiliaryEffectSloti)
                );

                _delegateALAuxiliaryEffectSlotf = (ALDelegateAuxiliaryEffectSlotf)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alAuxiliaryEffectSlotf"),
                    typeof(ALDelegateAuxiliaryEffectSlotf)
                );

                _delegateALGetAuxiliaryEffectSloti = (ALDelegateGetAuxiliaryEffectSloti)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alGetAuxiliaryEffectSloti"),
                    typeof(ALDelegateGetAuxiliaryEffectSloti)
                );

                _delegateALGetAuxiliaryEffectSlotf = (ALDelegateGetAuxiliaryEffectSlotf)Marshal.GetDelegateForFunctionPointer
                (
                    AL.GetProcAddress("alGetAuxiliaryEffectSlotf"),
                    typeof(ALDelegateGetAuxiliaryEffectSlotf)
                );
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to marshal AuxiliaryEffectSlot functions. " + e);
                return;
            }

            IsInitialized = true;
        }

        public static void GetEaxFromEfxEax(ref EaxReverb input, out EfxEaxReverb output)
        {
            output.AirAbsorptionGainHF = 0.995f; // input.AirAbsorptionHF  * somegain?
            output.RoomRolloffFactor = input.RoomRolloffFactor;

            output.Density = 1f; // todo, currently default
            output.Diffusion = 1f; // todo, currently default

            output.DecayTime = input.DecayTime;
            output.DecayHFLimit = 1; // todo, currently default
            output.DecayHFRatio = input.DecayHFRatio;
            output.DecayLFRatio = input.DecayLFRatio;

            output.EchoDepth = input.EchoDepth;
            output.EchoTime = input.EchoTime;

            output.Gain = 0.32f; // todo, currently default
            output.GainHF = 0.89f; // todo, currently default
            output.GainLF = 1f; // todo, currently default

            output.LFReference = input.LFReference;
            output.HFReference = input.HFReference;

            output.LateReverbDelay = input.ReverbDelay;
            output.LateReverbGain = 1.26f; // todo, currently default
            output.LateReverbPan = input.ReverbPan;

            output.ModulationDepth = input.ModulationDepth;
            output.ModulationTime = input.ModulationTime;

            output.ReflectionsDelay = input.ReflectionsDelay;
            output.ReflectionsGain = 0.05f; // todo, currently default
            output.ReflectionsPan = input.ReflectionsPan;
        }


        /// <summary>
        /// Gets a value indicating whether the EFX Extension has been found and could be initialized.
        /// </summary>
        public bool IsInitialized { get; }

        /// <summary>
        /// (Helper) Selects the Effect type used by this Effect handle.
        /// </summary>
        /// <param name="eid">Effect id returned from a successful call to GenEffects.</param>
        /// <param name="type">Effect type.</param>
        public void BindEffect(uint eid, EffectType type)
        {
            _delegateALEffecti(eid, EffectInteger.EffectType, (int)type);
        }

        /// <summary>
        /// (Helper) Selects the Effect type used by this Effect handle.
        /// </summary>
        /// <param name="eid">Effect id returned from a successful call to GenEffects.</param>
        /// <param name="type">Effect type.</param>
        public void BindEffect(int eid, EffectType type)
        {
            _delegateALEffecti((uint)eid, EffectInteger.EffectType, (int)type);
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
            AuxiliaryEffectSlot(auxiliaryeffectslot, EffectSlotInteger.EffectslotEffect, (int)effect);
        }

        /// <summary>
        /// (Helper) Attaches an Effect to an Auxiliary Effect Slot.
        /// </summary>
        /// <param name="auxiliaryeffectslot">The slot handle to attach the Effect to.</param>
        /// <param name="effect">The Effect handle that is being attached.</param>
        public void BindEffectToAuxiliarySlot(int auxiliaryeffectslot, int effect)
        {
            AuxiliaryEffectSlot((uint)auxiliaryeffectslot, EffectSlotInteger.EffectslotEffect, effect);
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
        /// <see cref="FilterType.FilterNull"/> for no filter.
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
        /// <see cref="FilterType.FilterNull"/> for no filter.
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
        /// After creation an Effect has no type (<see cref="EffectType.Null"/>), so before it can be used to store a set of
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
                    _delegateALGenEffects(n, ptr);
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
        /// After creation an Effect has no type (<see cref="EffectType.Null"/>), so before it can be used to store a set of
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
                    _delegateALGenEffects(n, (uint*)ptr);
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
        /// After creation an Effect has no type (<see cref="EffectType.Null"/>), so before it can be used to store a set of
        /// parameters, the application must specify what type of effect should be stored in the object, using Effect()
        /// with EfxEffecti.
        ///  </para>
        /// </remarks>
        /// <returns>The generated effects.</returns>
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
        /// After creation an Effect has no type (<see cref="EffectType.Null"/>), so before it can be used to store a set of
        /// parameters, the application must specify what type of effect should be stored in the object, using Effect()
        /// with EfxEffecti.
        ///  </para>
        /// </remarks>
        /// <returns>The generated effect.</returns>
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
                    _delegateALGenEffects(1, ptr);
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
                    _delegateALDeleteEffects(n, ptr);
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
                    _delegateALDeleteEffects(n, (uint*)ptr);
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
                    _delegateALDeleteEffects(1, ptr);
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
            return _delegateALIsEffect(eid);
        }

        /// <summary>
        /// The IsEffect function is used to determine if an object identifier is a valid Effect object.
        /// </summary>
        /// <param name="eid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Effect, False otherwise.</returns>
        public bool IsEffect(int eid)
        {
            return _delegateALIsEffect((uint)eid);
        }

        /// <summary>
        /// This function is used to set integer properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        public void Effect(uint eid, EffectInteger param, int value)
        {
            _delegateALEffecti(eid, param, value);
        }

        /// <summary>
        /// This function is used to set integer properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        public void Effect(int eid, EffectInteger param, int value)
        {
            _delegateALEffecti((uint)eid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void Effect(uint eid, EffectFloat param, float value)
        {
            _delegateALEffectf(eid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void Effect(int eid, EffectFloat param, float value)
        {
            _delegateALEffectf((uint)eid, param, value);
        }

        /// <summary>
        /// This function is used to set 3 floating-point properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="values">Pointer to <see cref="Math.Vector3"/>.</param>
        public void Effect(uint eid, EffectVector3 param, ref Vector3 values)
        {
            unsafe
            {
                fixed (float* ptr = &values.X)
                {
                    _delegateALEffectfv(eid, param, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to set 3 floating-point properties on Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="values">Pointer to <see cref="Math.Vector3"/>.</param>
        public void Effect(int eid, EffectVector3 param, ref Vector3 values)
        {
            Effect((uint)eid, param, ref values);
        }

        /// <summary>
        /// This function is used to retrieve integer properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetEffect(uint eid, EffectInteger pname, out int value)
        {
            unsafe
            {
                fixed (int* ptr = &value)
                {
                    _delegateALGetEffecti(eid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve integer properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetEffect(int eid, EffectInteger pname, out int value)
        {
            GetEffect((uint)eid, pname, out value);
        }

        /// <summary>
        /// This function is used to retrieve floating-point properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetEffect(uint eid, EffectFloat pname, out float value)
        {
            unsafe
            {
                fixed (float* ptr = &value)
                {
                    _delegateALGetEffectf(eid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve floating-point properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetEffect(int eid, EffectFloat pname, out float value)
        {
            GetEffect((uint)eid, pname, out value);
        }

        /// <summary>
        /// This function is used to retrieve 3 floating-point properties from Effect objects.
        /// </summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to retrieve.</param>
        /// <param name="values">A <see cref="Math.Vector3"/> to hold the values.</param>
        public void GetEffect(uint eid, EffectVector3 param, out Vector3 values)
        {
            unsafe
            {
                fixed (float* ptr = &values.X)
                {
                    _delegateALGetEffectfv(eid, param, ptr);
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
        /// <param name="values">A <see cref="Math.Vector3"/> to hold the values.</param>
        public void GetEffect(int eid, EffectVector3 param, out Vector3 values)
        {
            GetEffect((uint)eid, param, out values);
        }

        /// <summary>
        /// The GenFilters function is used to create one or more Filter objects. A Filter object stores a filter type and
        /// a set of parameter values to control that Filter. Filter objects can be attached to Sources as Direct Filters or
        /// Auxiliary Send Filters.
        /// </summary>
        /// <remarks>
        /// After creation a Filter has no type (<see cref="FilterType.Null"/>), so before it can be used to store a set of
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
                    _delegateALGenFilters(n, ptr);
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
        /// After creation a Filter has no type (<see cref="FilterType.Null"/>), so before it can be used to store a set of
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
                    _delegateALGenFilters(n, (uint*)ptr);
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
        /// After creation a Filter has no type (<see cref="FilterType.Null"/>), so before it can be used to store a set of
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
                _delegateALGenFilters(1, ptr);
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
                    _delegateALDeleteFilters(n, ptr);
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
                    _delegateALDeleteFilters(n, (uint*)ptr);
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
                    _delegateALDeleteFilters(1, ptr);
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
            return _delegateALIsFilter(fid);
        }

        /// <summary>
        /// The IsFilter function is used to determine if an object identifier is a valid Filter object.
        /// </summary>
        /// <param name="fid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Filter, False otherwise.</returns>
        public bool IsFilter(int fid)
        {
            return _delegateALIsFilter((uint)fid);
        }

        /// <summary>
        /// This function is used to set integer properties on Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        public void Filter(uint fid, FilterInteger param, int value)
        {
            _delegateALFilteri(fid, param, value);
        }

        /// <summary>
        /// This function is used to set integer properties on Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        public void Filter(int fid, FilterInteger param, int value)
        {
            _delegateALFilteri((uint)fid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void Filter(uint fid, FilterFloat param, float value)
        {
            _delegateALFilterf(fid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void Filter(int fid, FilterFloat param, float value)
        {
            _delegateALFilterf((uint)fid, param, value);
        }

        /// <summary>
        /// This function is used to retrieve integer properties from Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetFilter(uint fid, FilterInteger pname, out int value)
        {
            unsafe
            {
                fixed (int* ptr = &value)
                {
                    _delegateALGetFilteri(fid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve integer properties from Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetFilter(int fid, FilterInteger pname, out int value)
        {
            GetFilter((uint)fid, pname, out value);
        }

        /// <summary>
        /// This function is used to retrieve floating-point properties from Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetFilter(uint fid, FilterFloat pname, out float value)
        {
            unsafe
            {
                fixed (float* ptr = &value)
                {
                    _delegateALGetFilterf(fid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve floating-point properties from Filter objects.
        /// </summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetFilter(int fid, FilterFloat pname, out float value)
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
                    _delegateALGenAuxiliaryEffectSlots(n, ptr);
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
                    _delegateALGenAuxiliaryEffectSlots(n, (uint*)ptr);
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
                    _delegateALGenAuxiliaryEffectSlots(1, ptr);
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
                    _delegateALDeleteAuxiliaryEffectSlots(n, ptr);
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
                    _delegateALDeleteAuxiliaryEffectSlots(n, (uint*)ptr);
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
                    _delegateALDeleteAuxiliaryEffectSlots(1, ptr);
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
            return _delegateALIsAuxiliaryEffectSlot(slot);
        }

        /// <summary>
        /// The IsAuxiliaryEffectSlot function is used to determine if an object identifier is a valid Auxiliary Effect
        /// Slot object.
        /// </summary>
        /// <param name="slot">Effect Slot object identifier to validate.</param>
        /// <returns>True if the identifier is a valid Auxiliary Effect Slot, False otherwise.</returns>
        public bool IsAuxiliaryEffectSlot(int slot)
        {
            return _delegateALIsAuxiliaryEffectSlot((uint)slot);
        }

        /// <summary>
        /// This function is used to set integer properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Integer value.</param>
        public void AuxiliaryEffectSlot(uint asid, EffectSlotInteger param, int value)
        {
            _delegateALAuxiliaryEffectSloti(asid, param, value);
        }

        /// <summary>
        /// This function is used to set integer properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Integer value.</param>
        public void AuxiliaryEffectSlot(int asid, EffectSlotInteger param, int value)
        {
            _delegateALAuxiliaryEffectSloti((uint)asid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void AuxiliaryEffectSlot(uint asid, EffectSlotFloat param, float value)
        {
            _delegateALAuxiliaryEffectSlotf(asid, param, value);
        }

        /// <summary>
        /// This function is used to set floating-point properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Floating-point value.</param>
        public void AuxiliaryEffectSlot(int asid, EffectSlotFloat param, float value)
        {
            _delegateALAuxiliaryEffectSlotf((uint)asid, param, value);
        }

        /// <summary>
        /// This function is used to retrieve integer properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetAuxiliaryEffectSlot(uint asid, EffectSlotInteger pname, out int value)
        {
            unsafe
            {
                fixed (int* ptr = &value)
                {
                    _delegateALGetAuxiliaryEffectSloti(asid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve integer properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        public void GetAuxiliaryEffectSlot(int asid, EffectSlotInteger pname, out int value)
        {
            GetAuxiliaryEffectSlot((uint)asid, pname, out value);
        }

        /// <summary>
        /// This function is used to retrieve floating properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetAuxiliaryEffectSlot(uint asid, EffectSlotFloat pname, out float value)
        {
            unsafe
            {
                fixed (float* ptr = &value)
                {
                    _delegateALGetAuxiliaryEffectSlotf(asid, pname, ptr);
                }
            }
        }

        /// <summary>
        /// This function is used to retrieve floating properties on Auxiliary Effect Slot objects.
        /// </summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        public void GetAuxiliaryEffectSlot(int asid, EffectSlotFloat pname, out float value)
        {
            GetAuxiliaryEffectSlot((uint)asid, pname, out value);
        }

        private unsafe delegate void ALDelegateGenEffects(int n, [Out] uint* effects);

        private unsafe delegate void ALDelegateDeleteEffects(int n, [In] uint* effects);

        private delegate bool ALDelegateIsEffect(uint eid);

        private delegate void ALDelegateEffecti(uint eid, EffectInteger param, int value);

        private delegate void ALDelegateEffectf(uint eid, EffectFloat param, float value);

        private unsafe delegate void ALDelegateEffectfv(uint eid, EffectVector3 param, [In] float* values);

        private unsafe delegate void ALDelegateGetEffecti(uint eid, EffectInteger pname, [Out] int* value);

        private unsafe delegate void ALDelegateGetEffectf(uint eid, EffectFloat pname, [Out] float* value);

        private unsafe delegate void ALDelegateGetEffectfv(uint eid, EffectVector3 param, [Out] float* values);

        private unsafe delegate void ALDelegateGenFilters(int n, [Out] uint* filters);

        private unsafe delegate void ALDelegateDeleteFilters(int n, [In] uint* filters);

        private delegate bool ALDelegateIsFilter(uint fid);

        private delegate void ALDelegateFilteri(uint fid, FilterInteger param, int value);

        private delegate void ALDelegateFilterf(uint fid, FilterFloat param, float value);

        private unsafe delegate void ALDelegateGetFilteri(uint fid, FilterInteger pname, [Out] int* value);

        private unsafe delegate void ALDelegateGetFilterf(uint fid, FilterFloat pname, [Out] float* value);

        private unsafe delegate void ALDelegateGenAuxiliaryEffectSlots(int n, [Out] uint* slots);

        private unsafe delegate void ALDelegateDeleteAuxiliaryEffectSlots(int n, [In] uint* slots);

        private delegate bool ALDelegateIsAuxiliaryEffectSlot(uint slot);

        private delegate void ALDelegateAuxiliaryEffectSloti(uint asid, EffectSlotInteger param, int value);

        private delegate void ALDelegateAuxiliaryEffectSlotf(uint asid, EffectSlotFloat param, float value);

        private unsafe delegate void ALDelegateGetAuxiliaryEffectSloti(uint asid, EffectSlotInteger pname, [Out] int* value);

        private unsafe delegate void ALDelegateGetAuxiliaryEffectSlotf(uint asid, EffectSlotFloat pname, [Out] float* value);
    }
}
