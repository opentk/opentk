//
// EffectExtension.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using OpenToolkit.Core.Extensions;
using OpenToolkit.Core.Loader;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Audio.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Exposes the functions of the Effects Extension.
    /// </summary>
    [Api(ALC.Lib, typeof(OpenALLibraryNameContainer))]
    public class EFX : ApiContainer<EFX>
    {
        /// <summary>
        /// The EFX extension name.
        /// </summary>
        public const string ExtensionName = "ALC_EXT_EFX";

        static EFX()
        {
            _ = ApiContainer<EFX>.StaticConstructorTrigger;
        }

        private EFX()
        {
        }

        /// <summary>
        /// Checks if the EFX extension is present.
        /// </summary>
        /// <param name="device">The device to query.</param>
        /// <returns>Whether the extension was present or not.</returns>
        public static bool IsEFXExtensionPresent(ALDevice device)
        {
            return ALC.IsExtensionPresent(device, ExtensionName);
        }

        /// <summary>
        /// Gets a vector of integer properties from the context.
        /// </summary>
        /// <param name="device">The audio device.</param>
        /// <param name="param">The named property.</param>
        /// <param name="size">The size of the provided buffer.</param>
        /// <param name="data">A pointer to the first element of a provided data buffer.</param>
        [DllImport(ALC.Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetInteger(ALDevice device, EFXContextInteger param, int size, int* data);

        /// <summary>
        /// Gets a vector of integer properties from the context.
        /// </summary>
        /// <param name="device">The audio device.</param>
        /// <param name="param">The named property.</param>
        /// <param name="size">The size of the provided buffer.</param>
        /// <param name="data">A pointer to the first element of a provided data buffer.</param>
        [DllImport(ALC.Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetInteger(ALDevice device, EFXContextInteger param, int size, ref int data);

        /// <summary>
        /// Gets a vector of integer properties from the context.
        /// </summary>
        /// <param name="device">The audio device.</param>
        /// <param name="param">The named property.</param>
        /// <param name="size">The size of the provided buffer.</param>
        /// <param name="data">A pointer to the first element of a provided data buffer.</param>
        [DllImport(ALC.Lib, EntryPoint = "alcGetIntegerv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetInteger(ALDevice device, EFXContextInteger param, int size, int[] data);

        /// <summary>
        /// Gets a vector of integer properties from the context.
        /// </summary>
        /// <param name="device">The audio device.</param>
        /// <param name="param">The named property.</param>
        /// <param name="data">A provided data buffer.</param>
        public static void GetInteger(ALDevice device, EFXContextInteger param, int[] data)
        {
            GetInteger(device, param, data.Length, data);
        }

        /// <summary>
        /// Gets the major version of the Effect Extension.
        /// </summary>
        /// <param name="device">The device that the context is on.</param>
        /// <returns>The major version.</returns>
        public int GetEFXMajorVersion(ALDevice device)
        {
            var result = 0;
            GetInteger(device, EFXContextInteger.EFXMajorVersion, 1, ref result);
            return result;
        }

        /// <summary>
        /// Gets the minor version of the Effect Extension.
        /// </summary>
        /// <param name="device">The device that the context is on.</param>
        /// <returns>The minor version.</returns>
        public int GetEFXMinorVersion(ALDevice device)
        {
            var result = 0;
            GetInteger(device, EFXContextInteger.EFXMinorVersion, 1, ref result);
            return result;
        }

        /// <summary>
        /// Gets the version of the Effect Extension.
        /// </summary>
        /// <param name="device">The device that the context is on.</param>
        /// <returns>The version.</returns>
        public Version GetEFXVersion(ALDevice device)
        {
            return new Version(GetEFXMajorVersion(device), GetEFXMinorVersion(device));
        }

        /// <summary>
        /// Creates one or more auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <param name="slots">The first element of the array to place the slots into.</param>
        /// <seealso cref="DeleteAuxiliaryEffectSlots(int, int*)"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        [DllImport(ALC.Lib, EntryPoint = "alGenAuxiliaryEffectSlots", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GenAuxiliaryEffectSlots(int count, int* slots);

        /// <summary>
        /// Creates one or more auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <param name="slots">The first element of the array to place the slots into.</param>
        /// <seealso cref="DeleteAuxiliaryEffectSlots(int, ref int)"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        [DllImport(ALC.Lib, EntryPoint = "alGenAuxiliaryEffectSlots", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GenAuxiliaryEffectSlots(int count, ref int slots);

        /// <summary>
        /// Creates one or more auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <param name="slots">The first element of the array to place the slots into.</param>
        /// <seealso cref="DeleteAuxiliaryEffectSlots(int, int[])"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        [DllImport(ALC.Lib, EntryPoint = "alGenAuxiliaryEffectSlots", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GenAuxiliaryEffectSlots(int count, int[] slots);

        /// <summary>
        /// Creates one or more auxiliary effect slots.
        /// </summary>
        /// <param name="slots">An array to fill with created slots.</param>
        /// <seealso cref="DeleteAuxiliaryEffectSlots(int[])"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public static void GenAuxiliaryEffectSlots(int[] slots)
        {
            GenAuxiliaryEffectSlots(slots.Length, slots);
        }

        /// <summary>
        /// Creates one or more auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <returns>The slots.</returns>
        /// <seealso cref="DeleteAuxiliaryEffectSlots(uint[])"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public static int[] GenAuxiliaryEffectSlots(int count)
        {
            int[] result = new int[count];
            GenAuxiliaryEffectSlots(count, result);
            return result;
        }

        /// <summary>
        /// Creates an auxiliary effect slot.
        /// </summary>
        /// <returns>The slot.</returns>
        /// <seealso cref="DeleteAuxiliaryEffectSlot"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public static int GenAuxiliaryEffectSlot()
        {
            int result = 0;
            GenAuxiliaryEffectSlots(1, ref result);
            return result;
        }

        /// <summary>
        /// Creates an auxiliary effect slot.
        /// </summary>
        /// <param name="slot">The generated slot.</param>
        /// <seealso cref="DeleteAuxiliaryEffectSlot"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public static void GenAuxiliaryEffectSlot(out int slot)
        {
            int result = 0;
            GenAuxiliaryEffectSlots(1, ref result);
            slot = result;
        }

        /// <summary>
        /// Deletes and frees resources used for a set of auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to delete.</param>
        /// <param name="slots">A pointer to the array of slots to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlots(int, int*)"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        [DllImport(ALC.Lib, EntryPoint = "alDeleteAuxiliaryEffectSlots", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void DeleteAuxiliaryEffectSlots(int count, int* slots);

        /// <summary>
        /// Deletes and frees resources used for a set of auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to delete.</param>
        /// <param name="slots">A pointer to the array of slots to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlots(int, ref int)"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        [DllImport(ALC.Lib, EntryPoint = "alDeleteAuxiliaryEffectSlots", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void DeleteAuxiliaryEffectSlots(int count, ref int slots);

        /// <summary>
        /// Deletes and frees resources used for a set of auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to delete.</param>
        /// <param name="slots">A pointer to the array of slots to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlots(int, int[])"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        [DllImport(ALC.Lib, EntryPoint = "alDeleteAuxiliaryEffectSlots", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void DeleteAuxiliaryEffectSlots(int count, int[] slots);

        /// <summary>
        /// Deletes and frees resources used for a set of auxiliary effect slots.
        /// </summary>
        /// <param name="slots">An array of slots to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlots(int)"/>
        /// <seealso cref="IsAuxiliaryEffectSlot(int)"/>
        public static void DeleteAuxiliaryEffectSlots(int[] slots)
        {
            DeleteAuxiliaryEffectSlots(slots.Length, slots);
        }

        /// <summary>
        /// Deletes and frees resources used an auxiliary effect slot.
        /// </summary>
        /// <param name="slot">The slot to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlot()"/>
        /// <seealso cref="IsAuxiliaryEffectSlot(int)"/>
        public static void DeleteAuxiliaryEffectSlot(int slot)
        {
            DeleteAuxiliaryEffectSlots(1, ref slot);
        }

        /// <summary>
        /// Determines whether or not the given handle is an auxiliary slot handle.
        /// </summary>
        /// <param name="slot">The handle.</param>
        /// <returns>true if the handle is a slot handle; otherwise, false.</returns>
        [DllImport(ALC.Lib, EntryPoint = "alIsAuxiliaryEffectSlot", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern bool IsAuxiliaryEffectSlot(int slot);

        /// <summary>
        /// Sets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alAuxiliaryEffectSloti", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void AuxiliaryEffectSlot(int slot, EffectSlotInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alAuxiliaryEffectSlotf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void AuxiliaryEffectSlot(int slot, EffectSlotFloat param, float value);

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetAuxiliaryEffectSloti", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetAuxiliaryEffectSlot(int slot, EffectSlotInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public static int GetAuxiliaryEffectSlot(int slot, EffectSlotInteger param)
        {
            GetAuxiliaryEffectSlot(slot, param, out var result);
            return result;
        }

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetAuxiliaryEffectSlotf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetAuxiliaryEffectSlot(int slot, EffectSlotFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public static float GetAuxiliaryEffectSlot(int slot, EffectSlotFloat param)
        {
            GetAuxiliaryEffectSlot(slot, param, out var result);
            return result;
        }

        /// <summary>
        /// Creates one or more effect objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteEffects(int, int*)"/>
        /// <seealso cref="IsEffect(int)"/>
        [DllImport(ALC.Lib, EntryPoint = "alGenEffects", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GenEffects(int count, int* effects);

        /// <summary>
        /// Creates one or more effect objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteEffects(int, ref int)"/>
        /// <seealso cref="IsEffect(int)"/>
        [DllImport(ALC.Lib, EntryPoint = "alGenEffects", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GenEffects(int count, ref int effects);

        /// <summary>
        /// Creates one or more effect objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteEffects(int, int[])"/>
        /// <seealso cref="IsEffect(int)"/>
        [DllImport(ALC.Lib, EntryPoint = "alGenEffects", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GenEffects(int count, int[] effects);

        /// <summary>
        /// Creates one or more effects.
        /// </summary>
        /// <param name="effects">An arrays to fill with the generated effects.</param>
        /// <seealso cref="DeleteEffects(int[])"/>
        /// <seealso cref="IsEffect"/>
        public static void GenEffects(int[] effects)
        {
            GenEffects(effects.Length, effects);
        }

        /// <summary>
        /// Creates one or more effects.
        /// </summary>
        /// <param name="count">The number of effects to create.</param>
        /// <returns>The effects.</returns>
        /// <seealso cref="DeleteEffects(int[])"/>
        /// <seealso cref="IsEffect"/>
        public static int[] GenEffects(int count)
        {
            var result = new int[count];
            GenEffects(count, result);
            return result;
        }

        /// <summary>
        /// Creates an effect.
        /// </summary>
        /// <returns>The effect.</returns>
        /// <seealso cref="DeleteEffect"/>
        /// <seealso cref="IsEffect"/>
        public static int GenEffect()
        {
            int result = 0;
            GenEffects(1, ref result);
            return result;
        }

        /// <summary>
        /// Creates an effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <seealso cref="DeleteEffect"/>
        /// <seealso cref="IsEffect"/>
        public static void GenEffect(out int effect)
        {
            int result = 0;
            GenEffects(1, ref result);
            effect = result;
        }

        /// <summary>
        /// Deletes one or more effect objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenEffects(int, int*)"/>
        /// <seealso cref="IsEffect(int)"/>
        [DllImport(ALC.Lib, EntryPoint = "alDeleteEffects", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void DeleteEffects(int count, int* effects);

        /// <summary>
        /// Deletes one or more effect objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenEffects(int, ref int)"/>
        /// <seealso cref="IsEffect(int)"/>
        [DllImport(ALC.Lib, EntryPoint = "alDeleteEffects", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void DeleteEffects(int count, ref int effects);

        /// <summary>
        /// Deletes one or more effect objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenEffects(int, int[])"/>
        /// <seealso cref="IsEffect(int)"/>
        [DllImport(ALC.Lib, EntryPoint = "alDeleteEffects", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void DeleteEffects(int count, int[] effects);

        /// <summary>
        /// Deletes and frees resources used for a set of effects.
        /// </summary>
        /// <param name="effects">An array of effects to delete.</param>
        /// <seealso cref="GenEffects(int)"/>
        /// <seealso cref="IsEffect"/>
        public static void DeleteEffects(int[] effects)
        {
            DeleteEffects(effects.Length, effects);
        }

        /// <summary>
        /// Deletes and frees resources used an effect.
        /// </summary>
        /// <param name="effect">The effect to delete.</param>
        /// <seealso cref="GenEffect()"/>
        /// <seealso cref="IsEffect"/>
        public static void DeleteEffect(int effect)
        {
            DeleteEffects(1, ref effect);
        }

        /// <summary>
        /// Determines whether or not a given handle is an effect handle.
        /// </summary>
        /// <param name="effect">The handle.</param>
        /// <returns>true if the handle is an effect handle; otherwise, false.</returns>
        /// <seealso cref="GenEffects(int[])"/>
        /// <seealso cref="DeleteEffects(int[])"/>
        [DllImport(ALC.Lib, EntryPoint = "alIsEffect", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern bool IsEffect(int effect);

        /// <summary>
        /// Sets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alEffecti", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Effect(int effect, EffectInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alEffectf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Effect(int effect, EffectFloat param, float value);

        /// <summary>
        /// Sets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alEffectfv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void Effect(int effect, EffectVector3 param, float* value);

        /// <summary>
        /// Sets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alEffectfv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Effect(int effect, EffectVector3 param, ref float value);

        /// <summary>
        /// Sets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alEffectfv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Effect(int effect, EffectVector3 param, float[] value);

        /// <summary>
        /// Sets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alEffectfv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Effect(int effect, EffectVector3 param, in Vector3 value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetEffecti", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetEffect(int effect, EffectInteger param, int* value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetEffecti", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetEffect(int effect, EffectInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public static int GetEffect(int effect, EffectInteger param)
        {
            GetEffect(effect, param, out int result);
            return result;
        }

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetEffectf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetEffect(int effect, EffectFloat param, float* value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetEffectf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetEffect(int effect, EffectFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public static float GetEffect(int effect, EffectFloat param)
        {
            GetEffect(effect, param, out float result);
            return result;
        }

        /// <summary>
        /// Gets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetEffectfv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetEffect(int effect, EffectVector3 param, float* value);

        /// <summary>
        /// Gets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetEffectfv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetEffect(int effect, EffectVector3 param, out Vector3 value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public static Vector3 GetEffect(int effect, EffectVector3 param)
        {
            GetEffect(effect, param, out Vector3 result);
            return result;
        }

        /// <summary>
        /// Creates one or more filter objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteFilters"/>
        /// <seealso cref="IsFilter"/>
        [DllImport(ALC.Lib, EntryPoint = "alGenFilters", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GenFilters(int count, int* filters);

        /// <summary>
        /// Creates one or more filter objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteFilters"/>
        /// <seealso cref="IsFilter"/>
        [DllImport(ALC.Lib, EntryPoint = "alGenFilters", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GenFilters(int count, ref int filters);

        /// <summary>
        /// Creates one or more filter objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteFilters"/>
        /// <seealso cref="IsFilter"/>
        [DllImport(ALC.Lib, EntryPoint = "alGenFilters", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GenFilters(int count, int[] filters);

        /// <summary>
        /// Creates one or more filters.
        /// </summary>
        /// <param name="filters">An array to fill with the generated filters.</param>
        /// <seealso cref="DeleteFilters(int[])"/>
        /// <seealso cref="IsFilter"/>
        public static void GenFilters(int[] filters)
        {
            GenFilters(filters.Length, filters);
        }

        /// <summary>
        /// Creates one or more filters.
        /// </summary>
        /// <param name="count">The number of filters to create.</param>
        /// <returns>The filters.</returns>
        /// <seealso cref="DeleteFilters(int[])"/>
        /// <seealso cref="IsFilter"/>
        public static int[] GenFilters(int count)
        {
            int[] result = new int[count];
            GenFilters(count, result);
            return result;
        }

        /// <summary>
        /// Creates an filter.
        /// </summary>
        /// <returns>The filter.</returns>
        /// <seealso cref="DeleteFilter(int)"/>
        /// <seealso cref="IsFilter"/>
        public static int GenFilter()
        {
            int result = 0;
            GenFilters(1, ref result);
            return result;
        }

        /// <summary>
        /// Creates an filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <seealso cref="DeleteFilter(int)"/>
        /// <seealso cref="IsFilter"/>
        public static void GenFilter(out int filter)
        {
            int result = 0;
            GenFilters(1, ref result);
            filter = result;
        }

        /// <summary>
        /// Deletes one or more filter objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenFilters(int, int*)"/>
        /// <seealso cref="IsFilter"/>
        [DllImport(ALC.Lib, EntryPoint = "alDeleteFilters", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void DeleteFilters(int count, int* filters);

        /// <summary>
        /// Deletes one or more filter objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenFilters(int, ref int)"/>
        /// <seealso cref="IsFilter"/>
        [DllImport(ALC.Lib, EntryPoint = "alDeleteFilters", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void DeleteFilters(int count, ref int filters);

        /// <summary>
        /// Deletes one or more filter objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenFilters(int, int[])"/>
        /// <seealso cref="IsFilter"/>
        [DllImport(ALC.Lib, EntryPoint = "alDeleteFilters", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void DeleteFilters(int count, int[] filters);

        /// <summary>
        /// Deletes and frees resources used for a set of filters.
        /// </summary>
        /// <param name="filters">An array of filters to delete.</param>
        /// <seealso cref="GenFilters(int)"/>
        /// <seealso cref="IsFilter"/>
        public static void DeleteFilters(int[] filters)
        {
            DeleteFilters(filters.Length, filters);
        }

        /// <summary>
        /// Deletes and frees resources used an filter.
        /// </summary>
        /// <param name="filter">The filter to delete.</param>
        /// <seealso cref="GenFilter"/>
        /// <seealso cref="IsFilter"/>
        public static void DeleteFilter(int filter)
        {
            DeleteFilters(1, ref filter);
        }

        /// <summary>
        /// Determines whether or not a given handle is an filter handle.
        /// </summary>
        /// <param name="filter">The handle.</param>
        /// <returns>true if the handle is an filter handle; otherwise, false.</returns>
        /// <seealso cref="GenFilters(int)"/>
        /// <seealso cref="DeleteFilters(int[])"/>
        [DllImport(ALC.Lib, EntryPoint = "alIsFilter", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern bool IsFilter(int filter);

        /// <summary>
        /// Sets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alFilteri", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Filter(int filter, FilterInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alFilterf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Filter(int filter, FilterFloat param, float value);

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetFilteri", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetFilter(int filter, FilterInteger param, int* value);

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetFilteri", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetFilter(int filter, FilterInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public static int GetFilter(int filter, FilterInteger param)
        {
            GetFilter(filter, param, out int result);
            return result;
        }

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetFilterf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetFilter(int filter, FilterFloat param, float* value);

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetFilterf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetFilter(int filter, FilterFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public static float GetFilter(int filter, FilterFloat param)
        {
            GetFilter(filter, param, out float result);
            return result;
        }

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alSourcei", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Source(int source, EFXSourceInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alSourcef", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Source(int source, EFXSourceFloat param, float value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alSourcei", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Source(int source, EFXSourceBoolean param, bool value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alSourceiv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void Source(int source, EFXSourceInteger3 param, int* value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alSourceiv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Source(int source, EFXSourceInteger3 param, in Vector3i value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alSource3i", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Source(int source, EFXSourceInteger3 param, int value1, int value2, int value3);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetSourcei", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetSource(int source, EFXSourceInteger param, int* value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetSourcei", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetSource(int source, EFXSourceInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public static int GetSource(int source, EFXSourceInteger param)
        {
            GetSource(source, param, out int result);
            return result;
        }

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetSourcef", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetSource(int source, EFXSourceFloat param, float* value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetSourcef", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetSource(int source, EFXSourceFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public static float GetSource(int source, EFXSourceFloat param)
        {
            GetSource(source, param, out float result);
            return result;
        }

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetSourcei", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetSource(int source, EFXSourceBoolean param, bool* value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetSourcei", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetSource(int source, EFXSourceBoolean param, out bool value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public static bool GetSource(int source, EFXSourceBoolean param)
        {
            GetSource(source, param, out bool result);
            return result;
        }

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alSourceiv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetSource(int source, EFXSourceInteger3 param, int* value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alSourceiv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetSource(int source, EFXSourceInteger3 param, ref int value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alSourceiv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetSource(int source, EFXSourceInteger3 param, int[] value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alSourceiv", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetSource(int source, EFXSourceInteger3 param, out Vector3i value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetSource3i", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetSource(int source, EFXSourceInteger3 param, out int value1, out int value2, out int value3);

        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alListenerf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void Listener(int listener, EFXListenerFloat param, float value);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetListenerf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe void GetListener(int listener, EFXListenerFloat param, float* value);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [DllImport(ALC.Lib, EntryPoint = "alGetListenerf", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern void GetListener(int listener, EFXListenerFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value of the property.</returns>
        public static float GetListener(int listener, EFXListenerFloat param)
        {
            GetListener(listener, param, out float result);
            return result;
        }
    }
}
