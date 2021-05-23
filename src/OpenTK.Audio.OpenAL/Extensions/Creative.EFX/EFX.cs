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
using OpenTK.Mathematics;

namespace OpenTK.Audio.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Exposes the functions of the Effects Extension.
    /// </summary>
    public class EFX : ALBase
    {
        /// <summary>
        /// The EFX extension name.
        /// </summary>
        public const string ExtensionName = "ALC_EXT_EFX";

        static EFX()
        {
            // We need to register the resolver for OpenAL before we can DllImport functions.
            ALBase.RegisterOpenALResolver();
        }

        private EFX()
        {
        }

        /// <summary>
        /// Checks if this extension is present.
        /// </summary>
        /// <param name="device">The device to query.</param>
        /// <returns>Whether the extension was present or not.</returns>
        public static bool IsExtensionPresent(ALDevice device)
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

#pragma warning disable SA1124 // Do not use regions
        #region Generated
#pragma warning restore SA1124 // Do not use regions
#pragma warning disable SA1516 // Elements should be separated by blank line

        /// <summary>
        /// Creates one or more auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <param name="slots">The first element of the array to place the slots into.</param>
        /// <seealso cref="DeleteAuxiliaryEffectSlots(int, int*)"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public static unsafe void GenAuxiliaryEffectSlots(int count, int* slots) => _GenAuxiliaryEffectSlotsPtr(count, slots);

        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GenAuxiliaryEffectSlotsPtrDelegate(int count, int* slots);
        private static readonly GenAuxiliaryEffectSlotsPtrDelegate _GenAuxiliaryEffectSlotsPtr = LoadDelegate<GenAuxiliaryEffectSlotsPtrDelegate>("alGenAuxiliaryEffectSlots");

        /// <summary>
        /// Creates one or more auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <param name="slots">The first element of the array to place the slots into.</param>
        /// <seealso cref="DeleteAuxiliaryEffectSlots(int, ref int)"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public static void GenAuxiliaryEffectSlots(int count, ref int slots) => _GenAuxiliaryEffectSlotsRef(count, ref slots);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GenAuxiliaryEffectSlotsRefDelegate(int count, ref int slots);
        private static readonly GenAuxiliaryEffectSlotsRefDelegate _GenAuxiliaryEffectSlotsRef = LoadDelegate<GenAuxiliaryEffectSlotsRefDelegate>("alGenAuxiliaryEffectSlots");

        /// <summary>
        /// Creates one or more auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <param name="slots">The first element of the array to place the slots into.</param>
        /// <seealso cref="DeleteAuxiliaryEffectSlots(int, int[])"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public static void GenAuxiliaryEffectSlots(int count, int[] slots) => _GenAuxiliaryEffectSlotsArray(count, slots);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GenAuxiliaryEffectSlotsArrayDelegate(int count, int[] slots);
        private static readonly GenAuxiliaryEffectSlotsArrayDelegate _GenAuxiliaryEffectSlotsArray = LoadDelegate<GenAuxiliaryEffectSlotsArrayDelegate>("alGenAuxiliaryEffectSlots");

        /// <summary>
        /// Deletes and frees resources used for a set of auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to delete.</param>
        /// <param name="slots">A pointer to the array of slots to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlots(int, int*)"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public static unsafe void DeleteAuxiliaryEffectSlots(int count, int* slots) => _DeleteAuxiliaryEffectSlotsPtr(count, slots);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void DeleteAuxiliaryEffectSlotsPtrDelegate(int count, int* slots);
        private static readonly DeleteAuxiliaryEffectSlotsPtrDelegate _DeleteAuxiliaryEffectSlotsPtr = LoadDelegate<DeleteAuxiliaryEffectSlotsPtrDelegate>("alDeleteAuxiliaryEffectSlots");

        /// <summary>
        /// Deletes and frees resources used for a set of auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to delete.</param>
        /// <param name="slots">A pointer to the array of slots to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlots(int, ref int)"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public static void DeleteAuxiliaryEffectSlots(int count, ref int slots) => _DeleteAuxiliaryEffectSlotsRef(count, ref slots);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void DeleteAuxiliaryEffectSlotsRefDelegate(int count, ref int slots);
        private static readonly DeleteAuxiliaryEffectSlotsRefDelegate _DeleteAuxiliaryEffectSlotsRef = LoadDelegate<DeleteAuxiliaryEffectSlotsRefDelegate>("alDeleteAuxiliaryEffectSlots");

        /// <summary>
        /// Deletes and frees resources used for a set of auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to delete.</param>
        /// <param name="slots">A pointer to the array of slots to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlots(int, int[])"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public static void DeleteAuxiliaryEffectSlots(int count, int[] slots) => _DeleteAuxiliaryEffectSlotsArray(count, slots);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void DeleteAuxiliaryEffectSlotsArrayDelegate(int count, int[] slots);
        private static readonly DeleteAuxiliaryEffectSlotsArrayDelegate _DeleteAuxiliaryEffectSlotsArray = LoadDelegate<DeleteAuxiliaryEffectSlotsArrayDelegate>("alDeleteAuxiliaryEffectSlots");

        /// <summary>
        /// Determines whether or not the given handle is an auxiliary slot handle.
        /// </summary>
        /// <param name="slot">The handle.</param>
        /// <returns>true if the handle is a slot handle; otherwise, false.</returns>
        public static bool IsAuxiliaryEffectSlot(int slot) => _IsAuxiliaryEffectSlot(slot);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate bool IsAuxiliaryEffectSlotDelegate(int slot);
        private static readonly IsAuxiliaryEffectSlotDelegate _IsAuxiliaryEffectSlot = LoadDelegate<IsAuxiliaryEffectSlotDelegate>("alIsAuxiliaryEffectSlot");

        /// <summary>
        /// Sets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void AuxiliaryEffectSlot(int slot, EffectSlotInteger param, int value) => _AuxiliaryEffectSloti(slot, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void AuxiliaryEffectSlotiDelegate(int slot, EffectSlotInteger param, int value);
        private static readonly AuxiliaryEffectSlotiDelegate _AuxiliaryEffectSloti = LoadDelegate<AuxiliaryEffectSlotiDelegate>("alAuxiliaryEffectSloti");

        /// <summary>
        /// Sets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void AuxiliaryEffectSlot(int slot, EffectSlotFloat param, float value) => _AuxiliaryEffectSlotf(slot, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void AuxiliaryEffectSlotfDelegate(int slot, EffectSlotFloat param, float value);
        private static readonly AuxiliaryEffectSlotfDelegate _AuxiliaryEffectSlotf = LoadDelegate<AuxiliaryEffectSlotfDelegate>("alAuxiliaryEffectSlotf");

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value.</param>
        public static unsafe void GetAuxiliaryEffectSlot(int slot, EffectSlotInteger param, int* value) => _GetAuxiliaryEffectSlotiPtr(slot, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetAuxiliaryEffectSlotiPtrDelegate(int slot, EffectSlotInteger param, int* value);
        private static readonly GetAuxiliaryEffectSlotiPtrDelegate _GetAuxiliaryEffectSlotiPtr = LoadDelegate<GetAuxiliaryEffectSlotiPtrDelegate>("alGetAuxiliaryEffectSloti");

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value.</param>
        public static void GetAuxiliaryEffectSlot(int slot, EffectSlotInteger param, out int value) => _GetAuxiliaryEffectSlotiRef(slot, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetAuxiliaryEffectSlotiRefDelegate(int slot, EffectSlotInteger param, out int value);
        private static readonly GetAuxiliaryEffectSlotiRefDelegate _GetAuxiliaryEffectSlotiRef = LoadDelegate<GetAuxiliaryEffectSlotiRefDelegate>("alGetAuxiliaryEffectSloti");

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value.</param>
        public static unsafe void GetAuxiliaryEffectSlot(int slot, EffectSlotFloat param, float* value) => _GetAuxiliaryEffectSlotfPtr(slot, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetAuxiliaryEffectSlotfPtrDelegate(int slot, EffectSlotFloat param, float* value);
        private static readonly GetAuxiliaryEffectSlotfPtrDelegate _GetAuxiliaryEffectSlotfPtr = LoadDelegate<GetAuxiliaryEffectSlotfPtrDelegate>("alGetAuxiliaryEffectSlotf");

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value.</param>
        public static void GetAuxiliaryEffectSlot(int slot, EffectSlotFloat param, out float value) => _GetAuxiliaryEffectSlotfRef(slot, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetAuxiliaryEffectSlotfRefDelegate(int slot, EffectSlotFloat param, out float value);
        private static readonly GetAuxiliaryEffectSlotfRefDelegate _GetAuxiliaryEffectSlotfRef = LoadDelegate<GetAuxiliaryEffectSlotfRefDelegate>("alGetAuxiliaryEffectSlotf");

        /// <summary>
        /// Creates one or more effect objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteEffects(int, int*)"/>
        /// <seealso cref="IsEffect(int)"/>
        public static unsafe void GenEffects(int count, int* effects) => _GenEffectsPtr(count, effects);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GenEffectsPtrDelegate(int count, int* effects);
        private static readonly GenEffectsPtrDelegate _GenEffectsPtr = LoadDelegate<GenEffectsPtrDelegate>("alGenEffects");

        /// <summary>
        /// Creates one or more effect objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteEffects(int, ref int)"/>
        /// <seealso cref="IsEffect(int)"/>
        public static void GenEffects(int count, ref int effects) => _GenEffectsRef(count, ref effects);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GenEffectsRefDelegate(int count, ref int effects);
        private static readonly GenEffectsRefDelegate _GenEffectsRef = LoadDelegate<GenEffectsRefDelegate>("alGenEffects");

        /// <summary>
        /// Creates one or more effect objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteEffects(int, int[])"/>
        /// <seealso cref="IsEffect(int)"/>
        public static void GenEffects(int count, int[] effects) => _GenEffectsArray(count, effects);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GenEffectsArrayDelegate(int count, int[] effects);
        private static readonly GenEffectsArrayDelegate _GenEffectsArray = LoadDelegate<GenEffectsArrayDelegate>("alGenEffects");

        /// <summary>
        /// Deletes one or more effect objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenEffects(int, int*)"/>
        /// <seealso cref="IsEffect(int)"/>
        public static unsafe void DeleteEffects(int count, int* effects) => _DeleteEffectsPtr(count, effects);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void DeleteEffectsPtrDelegate(int count, int* effects);
        private static readonly DeleteEffectsPtrDelegate _DeleteEffectsPtr = LoadDelegate<DeleteEffectsPtrDelegate>("alDeleteEffects");

        /// <summary>
        /// Deletes one or more effect objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenEffects(int, ref int)"/>
        /// <seealso cref="IsEffect(int)"/>
        public static void DeleteEffects(int count, ref int effects) => _DeleteEffectsRef(count, ref effects);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void DeleteEffectsRefDelegate(int count, ref int effects);
        private static readonly DeleteEffectsRefDelegate _DeleteEffectsRef = LoadDelegate<DeleteEffectsRefDelegate>("alDeleteEffects");

        /// <summary>
        /// Deletes one or more effect objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenEffects(int, int[])"/>
        /// <seealso cref="IsEffect(int)"/>
        public static void DeleteEffects(int count, int[] effects) => _DeleteEffectsArray(count, effects);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void DeleteEffectsArrayDelegate(int count, int[] effects);
        private static readonly DeleteEffectsArrayDelegate _DeleteEffectsArray = LoadDelegate<DeleteEffectsArrayDelegate>("alDeleteEffects");

        /// <summary>
        /// Determines whether or not a given handle is an effect handle.
        /// </summary>
        /// <param name="effect">The handle.</param>
        /// <returns>true if the handle is an effect handle; otherwise, false.</returns>
        /// <seealso cref="GenEffects(int[])"/>
        /// <seealso cref="DeleteEffects(int[])"/>
        public static bool IsEffect(int effect) => _IsEffect(effect);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate bool IsEffectDelegate(int effect);
        private static readonly IsEffectDelegate _IsEffect = LoadDelegate<IsEffectDelegate>("alIsEffect");

        /// <summary>
        /// Sets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Effect(int effect, EffectInteger param, int value) => _Effecti(effect, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void EffectiDelegate(int effect, EffectInteger param, int value);
        private static readonly EffectiDelegate _Effecti = LoadDelegate<EffectiDelegate>("alEffecti");

        /// <summary>
        /// Sets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Effect(int effect, EffectFloat param, float value) => _Effectf(effect, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void EffectfDelegate(int effect, EffectFloat param, float value);
        private static readonly EffectfDelegate _Effectf = LoadDelegate<EffectfDelegate>("alEffectf");

        /// <summary>
        /// Sets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void Effect(int effect, EffectVector3 param, float* value) => _EffectfvPtr(effect, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void EffectfvPtrDelegate(int effect, EffectVector3 param, float* value);
        private static readonly EffectfvPtrDelegate _EffectfvPtr = LoadDelegate<EffectfvPtrDelegate>("alEffectfv");

        /// <summary>
        /// Sets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Effect(int effect, EffectVector3 param, ref float value) => _EffectfvRef(effect, param, ref value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void EffectfvRefDelegate(int effect, EffectVector3 param, ref float value);
        private static readonly EffectfvRefDelegate _EffectfvRef = LoadDelegate<EffectfvRefDelegate>("alEffectfv");

        /// <summary>
        /// Sets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Effect(int effect, EffectVector3 param, float[] value) => _EffectfvArray(effect, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void EffectfvArrayDelegate(int effect, EffectVector3 param, float[] value);
        private static readonly EffectfvArrayDelegate _EffectfvArray = LoadDelegate<EffectfvArrayDelegate>("alEffectfv");

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetEffect(int effect, EffectInteger param, int* value) => _GetEffectiPtr(effect, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetEffectiPtrDelegate(int effect, EffectInteger param, int* value);
        private static readonly GetEffectiPtrDelegate _GetEffectiPtr = LoadDelegate<GetEffectiPtrDelegate>("alGetEffecti");

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void GetEffect(int effect, EffectInteger param, out int value) => _GetEffectiRef(effect, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetEffectiRefDelegate(int effect, EffectInteger param, out int value);
        private static readonly GetEffectiRefDelegate _GetEffectiRef = LoadDelegate<GetEffectiRefDelegate>("alGetEffecti");

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetEffect(int effect, EffectFloat param, float* value) => _GetEffectfPtr(effect, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetEffectfPtrDelegate(int effect, EffectFloat param, float* value);
        private static readonly GetEffectfPtrDelegate _GetEffectfPtr = LoadDelegate<GetEffectfPtrDelegate>("alGetEffectf");

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void GetEffect(int effect, EffectFloat param, out float value) => _GetEffectfRef(effect, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetEffectfRefDelegate(int effect, EffectFloat param, out float value);
        private static readonly GetEffectfRefDelegate _GetEffectfRef = LoadDelegate<GetEffectfRefDelegate>("alGetEffectf");

        /// <summary>
        /// Gets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetEffect(int effect, EffectVector3 param, float* value) => _GetEffectfvPtr(effect, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetEffectfvPtrDelegate(int effect, EffectVector3 param, float* value);
        private static readonly GetEffectfvPtrDelegate _GetEffectfvPtr = LoadDelegate<GetEffectfvPtrDelegate>("alGetEffectfv");

        /// <summary>
        /// Gets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetEffect(int effect, EffectVector3 param, out float value) => _GetEffectfvRef(effect, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetEffectfvRefDelegate(int effect, EffectVector3 param, out float value);
        private static readonly GetEffectfvRefDelegate _GetEffectfvRef = LoadDelegate<GetEffectfvRefDelegate>("alGetEffectfv");

        /// <summary>
        /// Creates one or more filter objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteFilters(int, int*)"/>
        /// <seealso cref="IsFilter(int)"/>
        public static unsafe void GenFilters(int count, int* filters) => _GenFiltersPtr(count, filters);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GenFiltersPtrDelegate(int count, int* filters);
        private static readonly GenFiltersPtrDelegate _GenFiltersPtr = LoadDelegate<GenFiltersPtrDelegate>("alGenFilters");

        /// <summary>
        /// Creates one or more filter objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteFilters(int, ref int)"/>
        /// <seealso cref="IsFilter(int)"/>
        public static void GenFilters(int count, ref int filters) => _GenFiltersRef(count, ref filters);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GenFiltersRefDelegate(int count, ref int filters);
        private static readonly GenFiltersRefDelegate _GenFiltersRef = LoadDelegate<GenFiltersRefDelegate>("alGenFilters");

        /// <summary>
        /// Creates one or more filter objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteFilters(int, int[])"/>
        /// <seealso cref="IsFilter(int)"/>
        public static void GenFilters(int count, int[] filters) => _GenFiltersArray(count, filters);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GenFiltersArrayDelegate(int count, int[] filters);
        private static readonly GenFiltersArrayDelegate _GenFiltersArray = LoadDelegate<GenFiltersArrayDelegate>("alGenFilters");

        /// <summary>
        /// Deletes one or more filter objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenFilters(int, int*)"/>
        /// <seealso cref="IsFilter(int)"/>
        public static unsafe void DeleteFilters(int count, int* filters) => _DeleteFiltersPtr(count, filters);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void DeleteFiltersPtrDelegate(int count, int* filters);
        private static readonly DeleteFiltersPtrDelegate _DeleteFiltersPtr = LoadDelegate<DeleteFiltersPtrDelegate>("alDeleteFilters");

        /// <summary>
        /// Deletes one or more filter objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenFilters(int, ref int)"/>
        /// <seealso cref="IsFilter(int)"/>
        public static void DeleteFilters(int count, ref int filters) => _DeleteFiltersRef(count, ref filters);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void DeleteFiltersRefDelegate(int count, ref int filters);
        private static readonly DeleteFiltersRefDelegate _DeleteFiltersRef = LoadDelegate<DeleteFiltersRefDelegate>("alDeleteFilters");

        /// <summary>
        /// Deletes one or more filter objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenFilters(int, int[])"/>
        /// <seealso cref="IsFilter(int)"/>
        public static void DeleteFilters(int count, int[] filters) => _DeleteFiltersArray(count, filters);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void DeleteFiltersArrayDelegate(int count, int[] filters);
        private static readonly DeleteFiltersArrayDelegate _DeleteFiltersArray = LoadDelegate<DeleteFiltersArrayDelegate>("alDeleteFilters");

        /// <summary>
        /// Determines whether or not a given handle is an filter handle.
        /// </summary>
        /// <param name="filter">The handle.</param>
        /// <returns>true if the handle is an filter handle; otherwise, false.</returns>
        /// <seealso cref="GenFilters(int)"/>
        /// <seealso cref="DeleteFilters(int[])"/>
        public static bool IsFilter(int filter) => _IsFilter(filter);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate bool IsFilterDelegate(int filter);
        private static readonly IsFilterDelegate _IsFilter = LoadDelegate<IsFilterDelegate>("alIsFilter");

        /// <summary>
        /// Sets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Filter(int filter, FilterInteger param, int value) => _Filteri(filter, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void FilteriDelegate(int filter, FilterInteger param, int value);
        private static readonly FilteriDelegate _Filteri = LoadDelegate<FilteriDelegate>("alFilteri");

        /// <summary>
        /// Sets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Filter(int filter, FilterFloat param, float value) => _Filterf(filter, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void FilterfDelegate(int filter, FilterFloat param, float value);
        private static readonly FilterfDelegate _Filterf = LoadDelegate<FilterfDelegate>("alFilterf");

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetFilter(int filter, FilterInteger param, int* value) => _GetFilteriPtr(filter, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetFilteriPtrDelegate(int filter, FilterInteger param, int* value);
        private static readonly GetFilteriPtrDelegate _GetFilteriPtr = LoadDelegate<GetFilteriPtrDelegate>("alGetFilteri");

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void GetFilter(int filter, FilterInteger param, out int value) => _GetFilteriRef(filter, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetFilteriRefDelegate(int filter, FilterInteger param, out int value);
        private static readonly GetFilteriRefDelegate _GetFilteriRef = LoadDelegate<GetFilteriRefDelegate>("alGetFilteri");

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetFilter(int filter, FilterFloat param, float* value) => _GetFilterfPtr(filter, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetFilterfPtrDelegate(int filter, FilterFloat param, float* value);
        private static readonly GetFilterfPtrDelegate _GetFilterfPtr = LoadDelegate<GetFilterfPtrDelegate>("alGetFilterf");

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void GetFilter(int filter, FilterFloat param, out float value) => _GetFilterfRef(filter, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetFilterfRefDelegate(int filter, FilterFloat param, out float value);
        private static readonly GetFilterfRefDelegate _GetFilterfRef = LoadDelegate<GetFilterfRefDelegate>("alGetFilterf");

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Source(int source, EFXSourceInteger param, int value) => _Sourcei(source, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void SourceiDelegate(int source, EFXSourceInteger param, int value);
        private static readonly SourceiDelegate _Sourcei = LoadDelegate<SourceiDelegate>("alSourcei");

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Source(int source, EFXSourceFloat param, float value) => _Source(source, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void SourceDelegate(int source, EFXSourceFloat param, float value);
        private static readonly SourceDelegate _Source = LoadDelegate<SourceDelegate>("alSourcei");

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Source(int source, EFXSourceBoolean param, bool value) => _Sourceb(source, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void SourcebDelegate(int source, EFXSourceBoolean param, bool value);
        private static readonly SourcebDelegate _Sourceb = LoadDelegate<SourcebDelegate>("alSourcei");

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void Source(int source, EFXSourceInteger3 param, int* value) => _SourceivPtr(source, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void SourceivPtrDelegate(int source, EFXSourceInteger3 param, int* value);
        private static readonly SourceivPtrDelegate _SourceivPtr = LoadDelegate<SourceivPtrDelegate>("alSourceiv");

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Source(int source, EFXSourceInteger3 param, ref int value) => _SourceivRef(source, param, ref value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void SourceivRefDelegate(int source, EFXSourceInteger3 param, ref int value);
        private static readonly SourceivRefDelegate _SourceivRef = LoadDelegate<SourceivRefDelegate>("alSourceiv");

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Source(int source, EFXSourceInteger3 param, int[] value) => _SourceivArray(source, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void SourceivArrayDelegate(int source, EFXSourceInteger3 param, int[] value);
        private static readonly SourceivArrayDelegate _SourceivArray = LoadDelegate<SourceivArrayDelegate>("alSourceiv");

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        public static void Source(int source, EFXSourceInteger3 param, int value1, int value2, int value3) => _Source3i(source, param, value1, value2, value3);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void Source3iDelegate(int source, EFXSourceInteger3 param, int value1, int value2, int value3);
        private static readonly Source3iDelegate _Source3i = LoadDelegate<Source3iDelegate>("alSource3i");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetSource(int source, EFXSourceInteger param, int* value) => _GetSourceiPtr(source, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetSourceiPtrDelegate(int source, EFXSourceInteger param, int* value);
        private static readonly GetSourceiPtrDelegate _GetSourceiPtr = LoadDelegate<GetSourceiPtrDelegate>("alGetSourcei");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void GetSource(int source, EFXSourceInteger param, out int value) => _GetSourceiRef(source, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetSourceiRefDelegate(int source, EFXSourceInteger param, out int value);
        private static readonly GetSourceiRefDelegate _GetSourceiRef = LoadDelegate<GetSourceiRefDelegate>("alGetSourcei");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetSource(int source, EFXSourceFloat param, float* value) => _GetSourcefPtr(source, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetSourcefPtrDelegate(int source, EFXSourceFloat param, float* value);
        private static readonly GetSourcefPtrDelegate _GetSourcefPtr = LoadDelegate<GetSourcefPtrDelegate>("alGetSourcef");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void GetSource(int source, EFXSourceFloat param, out float value) => _GetSourcefRef(source, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetSourcefRefDelegate(int source, EFXSourceFloat param, out float value);
        private static readonly GetSourcefRefDelegate _GetSourcefRef = LoadDelegate<GetSourcefRefDelegate>("alGetSourcef");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetSource(int source, EFXSourceBoolean param, bool* value) => _GetSourcebPtr(source, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetSourcebPtrDelegate(int source, EFXSourceBoolean param, bool* value);
        private static readonly GetSourcebPtrDelegate _GetSourcebPtr = LoadDelegate<GetSourcebPtrDelegate>("alGetSourcei");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void GetSource(int source, EFXSourceBoolean param, out bool value) => _GetSourcebRef(source, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetSourcebRefDelegate(int source, EFXSourceBoolean param, out bool value);
        private static readonly GetSourcebRefDelegate _GetSourcebRef = LoadDelegate<GetSourcebRefDelegate>("alGetSourcei");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetSource(int source, EFXSourceInteger3 param, int* value) => _GetSourceivPtr(source, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetSourceivPtrDelegate(int source, EFXSourceInteger3 param, int* value);
        private static readonly GetSourceivPtrDelegate _GetSourceivPtr = LoadDelegate<GetSourceivPtrDelegate>("alGetSourceiv");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void GetSource(int source, EFXSourceInteger3 param, ref int value) => _GetSourceivRef(source, param, ref value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetSourceivRefDelegate(int source, EFXSourceInteger3 param, ref int value);
        private static readonly GetSourceivRefDelegate _GetSourceivRef = LoadDelegate<GetSourceivRefDelegate>("alGetSourceiv");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void GetSource(int source, EFXSourceInteger3 param, int[] value) => _GetSourceivArray(source, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetSourceivArrayDelegate(int source, EFXSourceInteger3 param, int[] value);
        private static readonly GetSourceivArrayDelegate _GetSourceivArray = LoadDelegate<GetSourceivArrayDelegate>("alGetSourceiv");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        public static unsafe void GetSource(int source, EFXSourceInteger3 param, int* value1, int* value2, int* value3) => _GetSource3iPtr(source, param, value1, value2, value3);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetSource3iPtrDelegate(int source, EFXSourceInteger3 param, int* value1, int* value2, int* value3);
        private static readonly GetSource3iPtrDelegate _GetSource3iPtr = LoadDelegate<GetSource3iPtrDelegate>("alGetSource3i");

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        public static void GetSource(int source, EFXSourceInteger3 param, out int value1, out int value2, out int value3) => _GetSource3iRef(source, param, out value1, out value2, out value3);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetSource3iRefDelegate(int source, EFXSourceInteger3 param, out int value1, out int value2, out int value3);
        private static readonly GetSource3iRefDelegate _GetSource3iRef = LoadDelegate<GetSource3iRefDelegate>("alGetSource3i");

        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Listener(int listener, EFXListenerFloat param, float value) => _Listenerf(listener, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void ListenerfDelegate(int listener, EFXListenerFloat param, float value);
        private static readonly ListenerfDelegate _Listenerf = LoadDelegate<ListenerfDelegate>("alListenerf");

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static unsafe void GetListener(int listener, EFXListenerFloat param, float* value) => _GetListenerfPtr(listener, param, value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private unsafe delegate void GetListenerfPtrDelegate(int listener, EFXListenerFloat param, float* value);
        private static readonly GetListenerfPtrDelegate _GetListenerfPtr = LoadDelegate<GetListenerfPtrDelegate>("alGetListenerf");

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void GetListener(int listener, EFXListenerFloat param, out float value) => _GetListenerfRef(listener, param, out value);
        [UnmanagedFunctionPointer(AL.ALCallingConvention)]
        private delegate void GetListenerfRefDelegate(int listener, EFXListenerFloat param, out float value);
        private static readonly GetListenerfRefDelegate _GetListenerfRef = LoadDelegate<GetListenerfRefDelegate>("alGetListenerf");

#pragma warning restore SA1516 // Elements should be separated by blank line
        #endregion

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
        /// <seealso cref="DeleteAuxiliaryEffectSlots(int[])"/>
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
        /// <returns>The value.</returns>
        public static float GetAuxiliaryEffectSlot(int slot, EffectSlotFloat param)
        {
            GetAuxiliaryEffectSlot(slot, param, out var result);
            return result;
        }

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
        /// Sets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void Effect(int effect, EffectVector3 param, ref Vector3 value)
        {
            Effect(effect, param, ref value.X);
        }

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
        public static void GetEffect(int effect, EffectVector3 param, out Vector3 value)
        {
            // This is so the compiler won't complain
            value.Y = 0;
            value.Z = 0;

            // This will fill the whole struct, not just the x field.
            GetEffect(effect, param, out value.X);
        }

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
        /// <seealso cref="GenFilter()"/>
        /// <seealso cref="IsFilter"/>
        public static void DeleteFilter(int filter)
        {
            DeleteFilters(1, ref filter);
        }

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
        /// <returns>The value.</returns>
        public static float GetFilter(int filter, FilterFloat param)
        {
            GetFilter(filter, param, out float result);
            return result;
        }

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
        /// <returns>The value.</returns>
        public static bool GetSource(int source, EFXSourceBoolean param)
        {
            GetSource(source, param, out bool result);
            return result;
        }

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
