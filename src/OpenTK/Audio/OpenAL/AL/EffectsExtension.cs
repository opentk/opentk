#region --- OpenTK.OpenAL License ---
/* EfxFunctions.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
#endregion

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// Provides access to the OpenAL effects extension.
    /// </summary>
    public partial class EffectsExtension
    {
        #region Helpers

        #region BindEffect

        /// <summary>(Helper) Selects the Effect type used by this Effect handle.</summary>
        /// <param name="eid">Effect id returned from a successful call to GenEffects.</param>
        /// <param name="type">Effect type.</param>
        [CLSCompliant(false)]
        public void BindEffect(uint eid, EfxEffectType type)
        {
            Imported_alEffecti(eid, EfxEffecti.EffectType, (int)type);
        }

        /// <summary>(Helper) Selects the Effect type used by this Effect handle.</summary>
        /// <param name="eid">Effect id returned from a successful call to GenEffects.</param>
        /// <param name="type">Effect type.</param>

        public void BindEffect(int eid, EfxEffectType type)
        {
            Imported_alEffecti((uint)eid, EfxEffecti.EffectType, (int)type);
        }

        #endregion BindEffect

        #region BindFilterToSource

        /// <summary>(Helper) reroutes the output of a Source through a Filter.</summary>
        /// <param name="source">A valid Source handle.</param>
        /// <param name="filter">A valid Filter handle.</param>
        [CLSCompliant(false)]
        public void BindFilterToSource(uint source, uint filter)
        {
            AL.Source(source, ALSourcei.EfxDirectFilter, (int)filter);
        }

        /// <summary>(Helper) reroutes the output of a Source through a Filter.</summary>
        /// <param name="source">A valid Source handle.</param>
        /// <param name="filter">A valid Filter handle.</param>

        public void BindFilterToSource(int source, int filter)
        {
            AL.Source((uint)source, ALSourcei.EfxDirectFilter, (int)filter);
        }

        #endregion BindFilterToSource

        #region BindEffectToAuxiliarySlot

        /// <summary>(Helper) Attaches an Effect to an Auxiliary Effect Slot.</summary>
        /// <param name="auxiliaryeffectslot">The slot handle to attach the Effect to.</param>
        /// <param name="effect">The Effect handle that is being attached.</param>
        [CLSCompliant(false)]
        public void BindEffectToAuxiliarySlot(uint auxiliaryeffectslot, uint effect)
        {
            AuxiliaryEffectSlot(auxiliaryeffectslot, EfxAuxiliaryi.EffectslotEffect, (int)effect);
        }

        /// <summary>(Helper) Attaches an Effect to an Auxiliary Effect Slot.</summary>
        /// <param name="auxiliaryeffectslot">The slot handle to attach the Effect to.</param>
        /// <param name="effect">The Effect handle that is being attached.</param>

        public void BindEffectToAuxiliarySlot(int auxiliaryeffectslot, int effect)
        {
            AuxiliaryEffectSlot((uint)auxiliaryeffectslot, EfxAuxiliaryi.EffectslotEffect, (int)effect);
        }

        #endregion BindEffectToAuxiliarySlot

        #region BindSourceToAuxiliarySlot

        /// <summary>(Helper) Reroutes a Source's output into an Auxiliary Effect Slot.</summary>
        /// <param name="source">The Source handle who's output is forwarded.</param>
        /// <param name="slot">The Auxiliary Effect Slot handle that receives input from the Source.</param>
        /// <param name="slotnumber">Every Source has only a limited number of slots it can feed buffer to. The number must stay below AlcContextAttributes.EfxMaxAuxiliarySends</param>
        /// <param name="filter">Filter handle to be attached between Source ouput and Auxiliary Slot input. Use 0 or EfxFilterType.FilterNull for no filter. </param>
        [CLSCompliant(false)]
        public void BindSourceToAuxiliarySlot(uint source, uint slot, int slotnumber, uint filter)
        {
            AL.Source(source, ALSource3i.EfxAuxiliarySendFilter, (int)slot, (int)slotnumber, (int)filter);
        }

        /// <summary>(Helper) Reroutes a Source's output into an Auxiliary Effect Slot.</summary>
        /// <param name="source">The Source handle who's output is forwarded.</param>
        /// <param name="slot">The Auxiliary Effect Slot handle that receives input from the Source.</param>
        /// <param name="slotnumber">Every Source has only a limited number of slots it can feed buffer to. The number must stay below AlcContextAttributes.EfxMaxAuxiliarySends</param>
        /// <param name="filter">Filter handle to be attached between Source ouput and Auxiliary Slot input. Use 0 or EfxFilterType.FilterNull for no filter. </param>

        public void BindSourceToAuxiliarySlot(int source, int slot, int slotnumber, int filter)
        {
            AL.Source((uint)source, ALSource3i.EfxAuxiliarySendFilter, (int)slot, (int)slotnumber, (int)filter);
        }

        #endregion BindSourceToAuxiliarySlot

        #endregion Helpers

        #region Effect Object

        #region alGenEffects

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGenEffects(int n, [Out] uint* effects);
        // typedef void (__cdecl *LPALGENEFFECTS)( ALsizei n, ALuint* effects );

        //[CLSCompliant(false)]
        private Delegate_alGenEffects Imported_alGenEffects;

        /// <summary>The GenEffects function is used to create one or more Effect objects. An Effect object stores an effect type and a set of parameter values to control that Effect. In order to use an Effect it must be attached to an Auxiliary Effect Slot object</summary>
        /// <remarks>After creation an Effect has no type (EfxEffectType.Null), so before it can be used to store a set of parameters, the application must specify what type of effect should be stored in the object, using Effect() with EfxEffecti.</remarks>
        /// <param name="n">Number of Effects to be created.</param>
        /// <param name="effects">Pointer addressing sufficient memory to store n Effect object identifiers.</param>
        [CLSCompliant(false)]
        public void GenEffects(int n, out uint effects)
        {
            unsafe
            {
                fixed (uint* ptr = &effects)
                {
                    Imported_alGenEffects(n, ptr);
                    effects = *ptr;
                }
            }
        }

        /// <summary>The GenEffects function is used to create one or more Effect objects. An Effect object stores an effect type and a set of parameter values to control that Effect. In order to use an Effect it must be attached to an Auxiliary Effect Slot object</summary>
        /// <remarks>After creation an Effect has no type (EfxEffectType.Null), so before it can be used to store a set of parameters, the application must specify what type of effect should be stored in the object, using Effect() with EfxEffecti.</remarks>
        /// <param name="n">Number of Effects to be created.</param>
        /// <param name="effects">Pointer addressing sufficient memory to store n Effect object identifiers.</param>
        public void GenEffects(int n, out int effects)
        {
            unsafe
            {
                fixed (int* ptr = &effects)
                {
                    Imported_alGenEffects(n, (uint*)ptr);
                    effects = *ptr;
                }
            }
        }

        /// <summary>Generates one or more effect objects.</summary>
        /// <param name="n">Number of Effect object identifiers to generate.</param>
        /// <remarks>
        /// <para>The GenEffects function is used to create one or more Effect objects. An Effect object stores an effect type and a set of parameter values to control that Effect. In order to use an Effect it must be attached to an Auxiliary Effect Slot object.</para>
        /// <para>After creation an Effect has no type (EfxEffectType.Null), so before it can be used to store a set of parameters, the application must specify what type of effect should be stored in the object, using Effect() with EfxEffecti.</para>
        /// </remarks>
        public int[] GenEffects(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException("n", "Must be higher than 0.");
            int[] effects = new int[n];
            GenEffects(n, out effects[0]);
            return effects;
        }

        /// <summary>Generates a single effect object.</summary>
        /// <returns>A handle to the generated effect object.</returns>
        /// <remarks>
        /// <para>The GenEffects function is used to create one or more Effect objects. An Effect object stores an effect type and a set of parameter values to control that Effect. In order to use an Effect it must be attached to an Auxiliary Effect Slot object.</para>
        /// <para>After creation an Effect has no type (EfxEffectType.Null), so before it can be used to store a set of parameters, the application must specify what type of effect should be stored in the object, using Effect() with EfxEffecti.</para>
        /// </remarks>
        public int GenEffect()
        {
            int temp;
            GenEffects(1, out temp);
            return temp;
        }

        /// <summary>Generates a single effect object.</summary>
        /// <param name="effect">A handle to the generated effect object.</param>
        [CLSCompliant(false)]
        public void GenEffect(out uint effect)
        {
            unsafe
            {
                fixed (uint* ptr = &effect)
                {
                    Imported_alGenEffects(1, ptr);
                    effect = *ptr;
                }
            }

        }

        #endregion alGenEffects

        #region alDeleteEffects

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alDeleteEffects(int n, [In] uint* effects);
        // typedef void (__cdecl *LPALDELETEEFFECTS)( ALsizei n, ALuint* effects );

        //[CLSCompliant(false)]
        private Delegate_alDeleteEffects Imported_alDeleteEffects;

        /// <summary>The DeleteEffects function is used to delete and free resources for Effect objects previously created with GenEffects.</summary>
        /// <param name="n">Number of Effects to be deleted.</param>
        /// <param name="effects">Pointer to n Effect object identifiers.</param>
        [CLSCompliant(false)]
        public void DeleteEffects(int n, ref uint effects)
        {
            unsafe
            {
                fixed (uint* ptr = &effects)
                {
                    Imported_alDeleteEffects(n, ptr);
                }
            }
        }

        /// <summary>The DeleteEffects function is used to delete and free resources for Effect objects previously created with GenEffects.</summary>
        /// <param name="n">Number of Effects to be deleted.</param>
        /// <param name="effects">Pointer to n Effect object identifiers.</param>
        public void DeleteEffects(int n, ref int effects)
        {
            unsafe
            {
                fixed (int* ptr = &effects)
                {
                    Imported_alDeleteEffects(n, (uint*)ptr);
                }
            }
        }

        /// <summary>The DeleteEffects function is used to delete and free resources for Effect objects previously created with GenEffects.</summary>
        /// <param name="effects">Pointer to n Effect object identifiers.</param>
        public void DeleteEffects(int[] effects)
        {
            if (effects == null) throw new ArgumentNullException("effects");
            DeleteEffects(effects.Length, ref effects[0]);
        }

        /// <summary>The DeleteEffects function is used to delete and free resources for Effect objects previously created with GenEffects.</summary>
        /// <param name="effects">Pointer to n Effect object identifiers.</param>
        [CLSCompliant(false)]
        public void DeleteEffects(uint[] effects)
        {
            if (effects == null) throw new ArgumentNullException("effects");
            DeleteEffects(effects.Length, ref effects[0]);
        }

        /// <summary>This function deletes one Effect only.</summary>
        /// <param name="effect">Pointer to an effect name/handle identifying the Effect Object to be deleted.</param>
        public void DeleteEffect(int effect)
        {
            DeleteEffects(1, ref effect);
        }

        /// <summary>This function deletes one Effect only.</summary>
        /// <param name="effect">Pointer to an effect name/handle identifying the Effect Object to be deleted.</param>
        [CLSCompliant(false)]
        public void DeleteEffect(ref uint effect)
        {
            unsafe
            {
                fixed (uint* ptr = &effect)
                {
                    Imported_alDeleteEffects(1, ptr);
                }
            }
        }

        #endregion alDeleteEffects

        #region alIsEffect

        //[CLSCompliant(false)]
        private delegate bool Delegate_alIsEffect(uint eid);
        // typedef ALboolean (__cdecl *LPALISEFFECT)( ALuint eid );

        //[CLSCompliant(false)]
        private Delegate_alIsEffect Imported_alIsEffect;

        /// <summary>The IsEffect function is used to determine if an object identifier is a valid Effect object.</summary>
        /// <param name="eid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Effect, False otherwise.</returns>
        [CLSCompliant(false)]
        public bool IsEffect(uint eid)
        {
            return Imported_alIsEffect(eid);
        }

        /// <summary>The IsEffect function is used to determine if an object identifier is a valid Effect object.</summary>
        /// <param name="eid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Effect, False otherwise.</returns>

        public bool IsEffect(int eid)
        {
            return Imported_alIsEffect((uint)eid);
        }

        #endregion alIsEffect

        #region alEffecti

        //[CLSCompliant(false)]
        private delegate void Delegate_alEffecti(uint eid, EfxEffecti param, int value);
        // typedef void (__cdecl *LPALEFFECTI)( ALuint eid, ALenum param, ALint value); 

        //[CLSCompliant(false)]
        private Delegate_alEffecti Imported_alEffecti;

        /// <summary>This function is used to set integer properties on Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        [CLSCompliant(false)]
        public void Effect(uint eid, EfxEffecti param, int value)
        {
            Imported_alEffecti(eid, param, value);
        }

        /// <summary>This function is used to set integer properties on Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>

        public void Effect(int eid, EfxEffecti param, int value)
        {
            Imported_alEffecti((uint)eid, param, value);
        }

        #endregion alEffecti

        #region alEffectf

        //[CLSCompliant(false)]
        private delegate void Delegate_alEffectf(uint eid, EfxEffectf param, float value);
        // typedef void (__cdecl *LPALEFFECTF)( ALuint eid, ALenum param, ALfloat value);

        //[CLSCompliant(false)]
        private Delegate_alEffectf Imported_alEffectf;

        /// <summary>This function is used to set floating-point properties on Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>
        [CLSCompliant(false)]
        public void Effect(uint eid, EfxEffectf param, float value)
        {
            Imported_alEffectf(eid, param, value);
        }

        /// <summary>This function is used to set floating-point properties on Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>

        public void Effect(int eid, EfxEffectf param, float value)
        {
            Imported_alEffectf((uint)eid, param, value);
        }

        #endregion alEffectf

        #region alEffectfv

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alEffectfv(uint eid, EfxEffect3f param, [In] float* values);
        // typedef void (__cdecl *LPALEFFECTFV)( ALuint eid, ALenum param, ALfloat* values ); 

        //[CLSCompliant(false)]
        private Delegate_alEffectfv Imported_alEffectfv;

        /// <summary>This function is used to set 3 floating-point properties on Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="values">Pointer to Math.Vector3.</param>
        [CLSCompliant(false)]
        public void Effect(uint eid, EfxEffect3f param, ref Vector3 values)
        {
            unsafe
            {
                fixed (float* ptr = &values.X)
                {
                    Imported_alEffectfv(eid, param, ptr);
                }
            }
        }

        /// <summary>This function is used to set 3 floating-point properties on Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="values">Pointer to Math.Vector3.</param>

        public void Effect(int eid, EfxEffect3f param, ref Vector3 values)
        {
            Effect((uint)eid, param, ref values);
        }

        #endregion alEffectfv

        #region alGetEffecti

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetEffecti(uint eid, EfxEffecti pname, [Out] int* value);
        // typedef void (__cdecl *LPALGETEFFECTI)( ALuint eid, ALenum pname, ALint* value );

        //[CLSCompliant(false)]
        private Delegate_alGetEffecti Imported_alGetEffecti;

        /// <summary>This function is used to retrieve integer properties from Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        [CLSCompliant(false)]
        public void GetEffect(uint eid, EfxEffecti pname, out int value)
        {
            unsafe
            {
                fixed (int* ptr = &value)
                {
                    Imported_alGetEffecti(eid, pname, ptr);
                }
            }
        }

        /// <summary>This function is used to retrieve integer properties from Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>

        public void GetEffect(int eid, EfxEffecti pname, out int value)
        {
            GetEffect((uint)eid, pname, out value);
        }

        #endregion alGetEffecti

        #region alGetEffectf

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetEffectf(uint eid, EfxEffectf pname, [Out]float* value);
        // typedef void (__cdecl *LPALGETEFFECTF)( ALuint eid, ALenum pname, ALfloat* value );

        //[CLSCompliant(false)]
        private Delegate_alGetEffectf Imported_alGetEffectf;

        /// <summary>This function is used to retrieve floating-point properties from Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        [CLSCompliant(false)]
        public void GetEffect(uint eid, EfxEffectf pname, out float value)
        {
            unsafe
            {
                fixed (float* ptr = &value)
                {
                    Imported_alGetEffectf(eid, pname, ptr);
                }
            }
        }

        /// <summary>This function is used to retrieve floating-point properties from Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>

        public void GetEffect(int eid, EfxEffectf pname, out float value)
        {
            GetEffect((uint)eid, pname, out value);
        }

        #endregion alGetEffectf

        #region alGetEffectfv

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetEffectfv(uint eid, EfxEffect3f param, [Out] float* values);
        // typedef void (__cdecl *LPALGETEFFECTFV)( ALuint eid, ALenum pname, ALfloat* values );

        //[CLSCompliant(false)]
        private Delegate_alGetEffectfv Imported_alGetEffectfv;

        /// <summary>This function is used to retrieve 3 floating-point properties from Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to retrieve.</param>
        /// <param name="values">A Math.Vector3 to hold the values.</param>
        [CLSCompliant(false)]
        public void GetEffect(uint eid, EfxEffect3f param, out Vector3 values)
        {
            unsafe
            {
                fixed (float* ptr = &values.X)
                {
                    Imported_alGetEffectfv(eid, param, ptr);
                    values.X = ptr[0];
                    values.Y = ptr[1];
                    values.Z = ptr[2];
                }
            }
        }

        /// <summary>This function is used to retrieve 3 floating-point properties from Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to retrieve.</param>
        /// <param name="values">A Math.Vector3 to hold the values.</param>

        public void GetEffect(int eid, EfxEffect3f param, out Vector3 values)
        {
            GetEffect((uint)eid, param, out values);
        }

        #endregion alGetEffectfv

        // Not used:
        // typedef void (__cdecl *LPALEFFECTIV)( ALuint eid, ALenum param, ALint* values ); 
        // typedef void (__cdecl *LPALGETEFFECTIV)( ALuint eid, ALenum pname, ALint* values );

        #endregion Effect Object

        #region Filter Object

        #region alGenFilters

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGenFilters(int n, [Out] uint* filters);
        // typedef void (__cdecl *LPALGENFILTERS)( ALsizei n, ALuint* filters ); 

        //[CLSCompliant(false)]
        private Delegate_alGenFilters Imported_alGenFilters;

        /// <summary>The GenFilters function is used to create one or more Filter objects. A Filter object stores a filter type and a set of parameter values to control that Filter. Filter objects can be attached to Sources as Direct Filters or Auxiliary Send Filters.</summary>
        /// <remarks>After creation a Filter has no type (EfxFilterType.Null), so before it can be used to store a set of parameters, the application must specify what type of filter should be stored in the object, using Filter() with EfxFilteri.</remarks>
        /// <param name="n">Number of Filters to be created.</param>
        /// <param name="filters">Pointer addressing sufficient memory to store n Filter object identifiers.</param>
        [CLSCompliant(false)]
        public void GenFilters(int n, out uint filters)
        {
            unsafe
            {
                fixed (uint* ptr = &filters)
                {
                    Imported_alGenFilters(n, ptr);
                    filters = *ptr;
                }
            }
        }

        /// <summary>The GenFilters function is used to create one or more Filter objects. A Filter object stores a filter type and a set of parameter values to control that Filter. Filter objects can be attached to Sources as Direct Filters or Auxiliary Send Filters.</summary>
        /// <remarks>After creation a Filter has no type (EfxFilterType.Null), so before it can be used to store a set of parameters, the application must specify what type of filter should be stored in the object, using Filter() with EfxFilteri.</remarks>
        /// <param name="n">Number of Filters to be created.</param>
        /// <param name="filters">Pointer addressing sufficient memory to store n Filter object identifiers.</param>
        public void GenFilters(int n, out int filters)
        {
            unsafe
            {
                fixed (int* ptr = &filters)
                {
                    Imported_alGenFilters(n, (uint*)ptr);
                    filters = *ptr;
                }
            }
        }


        /// <summary>The GenFilters function is used to create one or more Filter objects. A Filter object stores a filter type and a set of parameter values to control that Filter. Filter objects can be attached to Sources as Direct Filters or Auxiliary Send Filters.</summary>
        /// <remarks>After creation a Filter has no type (EfxFilterType.Null), so before it can be used to store a set of parameters, the application must specify what type of filter should be stored in the object, using Filter() with EfxFilteri.</remarks>
        /// <param name="n">Number of Filters to be created.</param>
        /// <returns>Pointer addressing sufficient memory to store n Filter object identifiers.</returns>
        public int[] GenFilters(int n)
        {

            if (n <= 0) throw new ArgumentOutOfRangeException("n", "Must be higher than 0.");
            int[] filters = new int[n];
            GenFilters(filters.Length, out filters[0]);
            return filters;
        }

        /// <summary>This function generates only one Filter.</summary>
        /// <returns>Storage Int32 for the new filter name/handle.</returns>
        public int GenFilter()
        {
            int filter;
            GenFilters(1, out filter);
            return filter;
        }

        /// <summary>This function generates only one Filter.</summary>
        /// <param name="filter">Storage UInt32 for the new filter name/handle.</param>
        [CLSCompliant(false)]
        unsafe public void GenFilter(out uint filter)
        {
            unsafe
            {
                fixed (uint* ptr = &filter)
                {
                    Imported_alGenFilters(1, ptr);
                    filter = *ptr;
                }
            }
        }

        #endregion alGenFilters

        #region alDeleteFilters

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alDeleteFilters(int n, [In] uint* filters);
        // typedef void (__cdecl *LPALDELETEFILTERS)( ALsizei n, ALuint* filters );

        //[CLSCompliant(false)]
        private Delegate_alDeleteFilters Imported_alDeleteFilters;

        /// <summary>The DeleteFilters function is used to delete and free resources for Filter objects previously created with GenFilters.</summary>
        /// <param name="n">Number of Filters to be deleted.</param>
        /// <param name="filters">Pointer to n Filter object identifiers.</param>
        [CLSCompliant(false)]
        public void DeleteFilters(int n, ref uint filters)
        {
            unsafe
            {
                fixed (uint* ptr = &filters)
                {
                    Imported_alDeleteFilters(n, ptr);
                }
            }
        }

        /// <summary>The DeleteFilters function is used to delete and free resources for Filter objects previously created with GenFilters.</summary>
        /// <param name="n">Number of Filters to be deleted.</param>
        /// <param name="filters">Pointer to n Filter object identifiers.</param>
        public void DeleteFilters(int n, ref int filters)
        {
            unsafe
            {
                fixed (int* ptr = &filters)
                {
                    Imported_alDeleteFilters(n, (uint*)ptr);
                }
            }
        }

        /// <summary>This function deletes one Filter only.</summary>
        /// <param name="filters">Pointer to an filter name/handle identifying the Filter Object to be deleted.</param>
        [CLSCompliant(false)]
        public void DeleteFilters(uint[] filters)
        {
            if (filters == null) throw new ArgumentNullException("filters");
            DeleteFilters(filters.Length, ref filters[0]);
        }

        /// <summary>This function deletes one Filter only.</summary>
        /// <param name="filters">Pointer to an filter name/handle identifying the Filter Object to be deleted.</param>
        public void DeleteFilters(int[] filters)
        {
            if (filters == null) throw new ArgumentNullException("filters");
            DeleteFilters(filters.Length, ref filters[0]);
        }

        /// <summary>This function deletes one Filter only.</summary>
        /// <param name="filter">Pointer to an filter name/handle identifying the Filter Object to be deleted.</param>
        public void DeleteFilter(int filter)
        {
            DeleteFilters(1, ref filter);
        }

        /// <summary>This function deletes one Filter only.</summary>
        /// <param name="filter">Pointer to an filter name/handle identifying the Filter Object to be deleted.</param>
        [CLSCompliant(false)]
        public void DeleteFilter(ref uint filter)
        {
            unsafe
            {
                fixed (uint* ptr = &filter)
                {
                    Imported_alDeleteFilters(1, ptr);
                }
            }
        }

        #endregion alDeleteFilters

        #region alIsFilter

        //[CLSCompliant(false)]
        private delegate bool Delegate_alIsFilter(uint fid);
        // typedef ALboolean (__cdecl *LPALISFILTER)( ALuint fid );

        //[CLSCompliant(false)]
        private Delegate_alIsFilter Imported_alIsFilter;

        /// <summary>The IsFilter function is used to determine if an object identifier is a valid Filter object.</summary>
        /// <param name="fid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Filter, False otherwise.</returns>
        [CLSCompliant(false)]
        public bool IsFilter(uint fid)
        {
            return Imported_alIsFilter(fid);
        }

        /// <summary>The IsFilter function is used to determine if an object identifier is a valid Filter object.</summary>
        /// <param name="fid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Filter, False otherwise.</returns>

        public bool IsFilter(int fid)
        {
            return Imported_alIsFilter((uint)fid);
        }

        #endregion alIsFilter

        #region alFilteri

        //[CLSCompliant(false)]
        private delegate void Delegate_alFilteri(uint fid, EfxFilteri param, int value);
        // typedef void (__cdecl *LPALFILTERI)( ALuint fid, ALenum param, ALint value );

        //[CLSCompliant(false)]
        private Delegate_alFilteri Imported_alFilteri;

        /// <summary>This function is used to set integer properties on Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        [CLSCompliant(false)]
        public void Filter(uint fid, EfxFilteri param, int value)
        {
            Imported_alFilteri(fid, param, value);
        }

        /// <summary>This function is used to set integer properties on Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>

        public void Filter(int fid, EfxFilteri param, int value)
        {
            Imported_alFilteri((uint)fid, param, value);
        }

        #endregion alFilteri

        #region alFilterf

        //[CLSCompliant(false)]
        private delegate void Delegate_alFilterf(uint fid, EfxFilterf param, float value);
        // typedef void (__cdecl *LPALFILTERF)( ALuint fid, ALenum param, ALfloat value);

        //[CLSCompliant(false)]
        private Delegate_alFilterf Imported_alFilterf;

        /// <summary>This function is used to set floating-point properties on Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>
        [CLSCompliant(false)]
        public void Filter(uint fid, EfxFilterf param, float value)
        {
            Imported_alFilterf(fid, param, value);
        }

        /// <summary>This function is used to set floating-point properties on Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating-point value.</param>

        public void Filter(int fid, EfxFilterf param, float value)
        {
            Imported_alFilterf((uint)fid, param, value);
        }

        #endregion alFilterf

        #region alGetFilteri

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetFilteri(uint fid, EfxFilteri pname, [Out] int* value);
        // typedef void (__cdecl *LPALGETFILTERI)( ALuint fid, ALenum pname, ALint* value );

        //[CLSCompliant(false)]
        private Delegate_alGetFilteri Imported_alGetFilteri;

        /// <summary>This function is used to retrieve integer properties from Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        [CLSCompliant(false)]
        public void GetFilter(uint fid, EfxFilteri pname, out int value)
        {
            unsafe
            {
                fixed (int* ptr = &value)
                {
                    Imported_alGetFilteri(fid, pname, ptr);
                }
            }
        }

        /// <summary>This function is used to retrieve integer properties from Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>

        public void GetFilter(int fid, EfxFilteri pname, out int value)
        {
            GetFilter((uint)fid, pname, out value);
        }

        #endregion alGetFilteri

        #region alGetFilterf

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetFilterf(uint fid, EfxFilterf pname, [Out] float* value);
        // typedef void (__cdecl *LPALGETFILTERF)( ALuint fid, ALenum pname, ALfloat* value );

        //[CLSCompliant(false)]
        private Delegate_alGetFilterf Imported_alGetFilterf;

        /// <summary>This function is used to retrieve floating-point properties from Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        [CLSCompliant(false)]
        public void GetFilter(uint fid, EfxFilterf pname, out float value)
        {
            unsafe
            {
                fixed (float* ptr = &value)
                {
                    Imported_alGetFilterf(fid, pname, ptr);
                }
            }
        }

        /// <summary>This function is used to retrieve floating-point properties from Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>

        public void GetFilter(int fid, EfxFilterf pname, out float value)
        {
            GetFilter((uint)fid, pname, out value);
        }

        #endregion alGetFilterf

        // Not used:
        // typedef void (__cdecl *LPALFILTERIV)( ALuint fid, ALenum param, ALint* values ); 
        // typedef void (__cdecl *LPALFILTERFV)( ALuint fid, ALenum param, ALfloat* values ); 
        // typedef void (__cdecl *LPALGETFILTERIV)( ALuint fid, ALenum pname, ALint* values );
        // typedef void (__cdecl *LPALGETFILTERFV)( ALuint fid, ALenum pname, ALfloat* values );

        #endregion Filter Object

        #region Auxiliary Effect Slot Object

        #region alGenAuxiliaryEffectSlots

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGenAuxiliaryEffectSlots(int n, [Out] uint* slots);
        // typedef void (__cdecl *LPALGENAUXILIARYEFFECTSLOTS)( ALsizei n, ALuint* slots );

        //[CLSCompliant(false)]
        private Delegate_alGenAuxiliaryEffectSlots Imported_alGenAuxiliaryEffectSlots;

        /// <summary>The GenAuxiliaryEffectSlots function is used to create one or more Auxiliary Effect Slots. The number of slots that can be created will be dependant upon the Open AL device used.</summary>
        /// <remarks>An application should check the OpenAL error state after making this call to determine if the Effect Slot was successfully created. If the function call fails then none of the requested Effect Slots are created. A good strategy for creating any OpenAL object is to use a for-loop and generate one object each loop iteration and then check for an error condition. If an error is set then the loop can be broken and the application can determine if sufficient resources are available.</remarks>
        /// <param name="n">Number of Auxiliary Effect Slots to be created.</param>
        /// <param name="slots">Pointer addressing sufficient memory to store n Effect Slot object identifiers.</param>
        [CLSCompliant(false)]
        public void GenAuxiliaryEffectSlots(int n, out uint slots)
        {
            unsafe
            {
                fixed (uint* ptr = &slots)
                {
                    Imported_alGenAuxiliaryEffectSlots(n, ptr);
                    slots = *ptr;
                }
            }
        }

        /// <summary>The GenAuxiliaryEffectSlots function is used to create one or more Auxiliary Effect Slots. The number of slots that can be created will be dependant upon the Open AL device used.</summary>
        /// <remarks>An application should check the OpenAL error state after making this call to determine if the Effect Slot was successfully created. If the function call fails then none of the requested Effect Slots are created. A good strategy for creating any OpenAL object is to use a for-loop and generate one object each loop iteration and then check for an error condition. If an error is set then the loop can be broken and the application can determine if sufficient resources are available.</remarks>
        /// <param name="n">Number of Auxiliary Effect Slots to be created.</param>
        /// <param name="slots">Pointer addressing sufficient memory to store n Effect Slot object identifiers.</param>
        public void GenAuxiliaryEffectSlots(int n, out int slots)
        {
            unsafe
            {
                fixed (int* ptr = &slots)
                {
                    Imported_alGenAuxiliaryEffectSlots(n, (uint*)ptr);
                    slots = *ptr;
                }
            }
        }

        /// <summary>The GenAuxiliaryEffectSlots function is used to create one or more Auxiliary Effect Slots. The number of slots that can be created will be dependant upon the Open AL device used.</summary>
        /// <remarks>An application should check the OpenAL error state after making this call to determine if the Effect Slot was successfully created. If the function call fails then none of the requested Effect Slots are created. A good strategy for creating any OpenAL object is to use a for-loop and generate one object each loop iteration and then check for an error condition. If an error is set then the loop can be broken and the application can determine if sufficient resources are available.</remarks>
        /// <param name="n">Number of Auxiliary Effect Slots to be created.</param>
        /// <returns>Pointer addressing sufficient memory to store n Effect Slot object identifiers.</returns>
        public int[] GenAuxiliaryEffectSlots(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException("n", "Must be higher than 0.");
            int[] slots = new int[n];
            GenAuxiliaryEffectSlots(slots.Length, out slots[0]);
            return slots;
        }

        /// <summary>This function generates only one Auxiliary Effect Slot.</summary>
        /// <returns>Storage Int32 for the new auxiliary effect slot name/handle.</returns>
        public int GenAuxiliaryEffectSlot()
        {
            int temp;
            GenAuxiliaryEffectSlots(1, out temp);
            return temp;
        }

        /// <summary>This function generates only one Auxiliary Effect Slot.</summary>
        /// <returns>Storage UInt32 for the new auxiliary effect slot name/handle.</returns>
        [CLSCompliant(false)]
        public void GenAuxiliaryEffectSlot(out uint slot)
        {
            unsafe
            {
                fixed (uint* ptr = &slot)
                {
                    Imported_alGenAuxiliaryEffectSlots(1, ptr);
                    slot = *ptr;
                }
            }
        }

        #endregion alGenAuxiliaryEffectSlots

        #region DeleteAuxiliaryEffectSlots

        unsafe private delegate void Delegate_alDeleteAuxiliaryEffectSlots(int n, [In] uint* slots);
        // typedef void (__cdecl *LPALDELETEAUXILIARYEFFECTSLOTS)( ALsizei n, ALuint* slots );

        private Delegate_alDeleteAuxiliaryEffectSlots Imported_alDeleteAuxiliaryEffectSlots;

        /// <summary>The DeleteAuxiliaryEffectSlots function is used to delete and free resources for Auxiliary Effect Slots previously created with GenAuxiliaryEffectSlots.</summary>
        /// <param name="n">Number of Auxiliary Effect Slots to be deleted.</param>
        /// <param name="slots">Pointer to n Effect Slot object identifiers.</param>
        [CLSCompliant(false)]
        public void DeleteAuxiliaryEffectSlots(int n, ref uint slots)
        {
            unsafe
            {
                fixed (uint* ptr = &slots)
                {
                    Imported_alDeleteAuxiliaryEffectSlots(n, ptr);
                }
            }
        }

        /// <summary>The DeleteAuxiliaryEffectSlots function is used to delete and free resources for Auxiliary Effect Slots previously created with GenAuxiliaryEffectSlots.</summary>
        /// <param name="n">Number of Auxiliary Effect Slots to be deleted.</param>
        /// <param name="slots">Pointer to n Effect Slot object identifiers.</param>
        public void DeleteAuxiliaryEffectSlots(int n, ref int slots)
        {
            unsafe
            {
                fixed (int* ptr = &slots)
                {
                    Imported_alDeleteAuxiliaryEffectSlots(n, (uint*)ptr);
                }
            }
        }

        /// <summary>The DeleteAuxiliaryEffectSlots function is used to delete and free resources for Auxiliary Effect Slots previously created with GenAuxiliaryEffectSlots.</summary>
        /// <param name="slots">Pointer to n Effect Slot object identifiers.</param>
        public void DeleteAuxiliaryEffectSlots(int[] slots)
        {
            if (slots == null) throw new ArgumentNullException("slots");
            DeleteAuxiliaryEffectSlots(slots.Length, ref slots[0]);
        }

        /// <summary>This function deletes one AuxiliaryEffectSlot only.</summary>
        /// <param name="slots">Pointer to an auxiliary effect slot name/handle identifying the Auxiliary Effect Slot Object to be deleted.</param>
        [CLSCompliant(false)]
        public void DeleteAuxiliaryEffectSlots(uint[] slots)
        {
            if (slots == null) throw new ArgumentNullException("slots");
            DeleteAuxiliaryEffectSlots(slots.Length, ref slots[0]);
        }

        /// <summary>This function deletes one AuxiliaryEffectSlot only.</summary>
        /// <param name="slot">Pointer to an auxiliary effect slot name/handle identifying the Auxiliary Effect Slot Object to be deleted.</param>
        public void DeleteAuxiliaryEffectSlot(int slot)
        {
            DeleteAuxiliaryEffectSlots(1, ref slot);
        }

        /// <summary>This function deletes one AuxiliaryEffectSlot only.</summary>
        /// <param name="slot">Pointer to an auxiliary effect slot name/handle identifying the Auxiliary Effect Slot Object to be deleted.</param>
        [CLSCompliant(false)]
        public void DeleteAuxiliaryEffectSlot(ref uint slot)
        {
            unsafe
            {
                fixed (uint* ptr = &slot)
                {
                    Imported_alDeleteAuxiliaryEffectSlots(1, ptr);
                }
            }
        }

        #endregion alDeleteAuxiliaryEffectSlots

        #region alIsAuxiliaryEffectSlot

        //[CLSCompliant(false)]
        private delegate bool Delegate_alIsAuxiliaryEffectSlot(uint slot);
        // typedef ALboolean (__cdecl *LPALISAUXILIARYEFFECTSLOT)( ALuint slot );

        //[CLSCompliant(false)]
        private Delegate_alIsAuxiliaryEffectSlot Imported_alIsAuxiliaryEffectSlot;

        /// <summary>The IsAuxiliaryEffectSlot function is used to determine if an object identifier is a valid Auxiliary Effect Slot object.</summary>
        /// <param name="slot">Effect Slot object identifier to validate.</param>
        /// <returns>True if the identifier is a valid Auxiliary Effect Slot, False otherwise.</returns>
        [CLSCompliant(false)]
        public bool IsAuxiliaryEffectSlot(uint slot)
        {
            return Imported_alIsAuxiliaryEffectSlot(slot);
        }

        /// <summary>The IsAuxiliaryEffectSlot function is used to determine if an object identifier is a valid Auxiliary Effect Slot object.</summary>
        /// <param name="slot">Effect Slot object identifier to validate.</param>
        /// <returns>True if the identifier is a valid Auxiliary Effect Slot, False otherwise.</returns>

        public bool IsAuxiliaryEffectSlot(int slot)
        {
            return Imported_alIsAuxiliaryEffectSlot((uint)slot);
        }

        #endregion alIsAuxiliaryEffectSlot

        #region alAuxiliaryEffectSloti

        //[CLSCompliant(false)]
        private delegate void Delegate_alAuxiliaryEffectSloti(uint asid, EfxAuxiliaryi param, int value);
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTI)( ALuint asid, ALenum param, ALint value ); 

        //[CLSCompliant(false)]
        private Delegate_alAuxiliaryEffectSloti Imported_alAuxiliaryEffectSloti;

        /// <summary>This function is used to set integer properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Integer value.</param>
        [CLSCompliant(false)]
        public void AuxiliaryEffectSlot(uint asid, EfxAuxiliaryi param, int value)
        {
            Imported_alAuxiliaryEffectSloti(asid, param, value);
        }

        /// <summary>This function is used to set integer properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Integer value.</param>

        public void AuxiliaryEffectSlot(int asid, EfxAuxiliaryi param, int value)
        {
            Imported_alAuxiliaryEffectSloti((uint)asid, param, value);
        }

        #endregion alAuxiliaryEffectSloti

        #region alAuxiliaryEffectSlotf

        //[CLSCompliant(false)]
        private delegate void Delegate_alAuxiliaryEffectSlotf(uint asid, EfxAuxiliaryf param, float value);
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTF)( ALuint asid, ALenum param, ALfloat value );

        //[CLSCompliant(false)]
        private Delegate_alAuxiliaryEffectSlotf Imported_alAuxiliaryEffectSlotf;

        /// <summary>This function is used to set floating-point properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Floating-point value.</param>
        [CLSCompliant(false)]
        public void AuxiliaryEffectSlot(uint asid, EfxAuxiliaryf param, float value)
        {
            Imported_alAuxiliaryEffectSlotf(asid, param, value);
        }

        /// <summary>This function is used to set floating-point properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Floating-point value.</param>

        public void AuxiliaryEffectSlot(int asid, EfxAuxiliaryf param, float value)
        {
            Imported_alAuxiliaryEffectSlotf((uint)asid, param, value);
        }

        #endregion alAuxiliaryEffectSlotf

        #region alGetAuxiliaryEffectSloti

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetAuxiliaryEffectSloti(uint asid, EfxAuxiliaryi pname, [Out] int* value);
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTI)( ALuint asid, ALenum pname, ALint* value );

        //[CLSCompliant(false)]
        private Delegate_alGetAuxiliaryEffectSloti Imported_alGetAuxiliaryEffectSloti;

        /// <summary>This function is used to retrieve integer properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        [CLSCompliant(false)]
        public void GetAuxiliaryEffectSlot(uint asid, EfxAuxiliaryi pname, out int value)
        {
            unsafe
            {
                fixed (int* ptr = &value)
                {
                    Imported_alGetAuxiliaryEffectSloti(asid, pname, ptr);
                }
            }
        }

        /// <summary>This function is used to retrieve integer properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>

        public void GetAuxiliaryEffectSlot(int asid, EfxAuxiliaryi pname, out int value)
        {
            GetAuxiliaryEffectSlot((uint)asid, pname, out value);
        }

        #endregion alGetAuxiliaryEffectSloti

        #region alGetAuxiliaryEffectSlotf

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetAuxiliaryEffectSlotf(uint asid, EfxAuxiliaryf pname, [Out] float* value);
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTF)( ALuint asid, ALenum pname, ALfloat* value );

        //[CLSCompliant(false)]
        private Delegate_alGetAuxiliaryEffectSlotf Imported_alGetAuxiliaryEffectSlotf;

        /// <summary>This function is used to retrieve floating properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>
        [CLSCompliant(false)]
        public void GetAuxiliaryEffectSlot(uint asid, EfxAuxiliaryf pname, out float value)
        {
            unsafe
            {
                fixed (float* ptr = &value)
                {
                    Imported_alGetAuxiliaryEffectSlotf(asid, pname, ptr);
                }
            }
        }

        /// <summary>This function is used to retrieve floating properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where floating-point value will be stored.</param>

        public void GetAuxiliaryEffectSlot(int asid, EfxAuxiliaryf pname, out float value)
        {
            GetAuxiliaryEffectSlot((uint)asid, pname, out value);
        }

        #endregion alGetAuxiliaryEffectSlotf

        // Not used:
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTIV)( ALuint asid, ALenum param, ALint* values ); 
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTFV)( ALuint asid, ALenum param, ALfloat* values ); 
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTIV)( ALuint asid, ALenum pname, ALint* values );
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTFV)( ALuint asid, ALenum pname, ALfloat* values );

        #endregion Auxiliary Effect Slot Object

        #region Constructor / Extension Loading

        private bool _valid;

        /// <summary>Returns True if the EFX Extension has been found and could be initialized.</summary>
        public bool IsInitialized
        {
            get
            {
                return _valid;
            }
        }

        /// <summary>
        /// Constructs a new EffectsExtension instance.
        /// </summary>
        public EffectsExtension()
        {
            _valid = false;

            if (AudioContext.CurrentContext == null)
                throw new InvalidOperationException("AL.LoadAll() needs a current AudioContext.");

            if (!AudioContext.CurrentContext.SupportsExtension("ALC_EXT_EFX"))
            {
                Debug.Print("EFX Extension (ALC_EXT_EFX) is not supported(AudioContext: {0}).", AudioContext.CurrentContext.ToString());
                return;
            }
            // Console.WriteLine("ALC_EXT_EFX found. Efx can be used.");

            try
            {
                Imported_alGenEffects = (Delegate_alGenEffects)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenEffects"), typeof(Delegate_alGenEffects));
                Imported_alDeleteEffects = (Delegate_alDeleteEffects)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteEffects"), typeof(Delegate_alDeleteEffects));
                Imported_alIsEffect = (Delegate_alIsEffect)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsEffect"), typeof(Delegate_alIsEffect));
                Imported_alEffecti = (Delegate_alEffecti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffecti"), typeof(Delegate_alEffecti));
                Imported_alEffectf = (Delegate_alEffectf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffectf"), typeof(Delegate_alEffectf));
                Imported_alEffectfv = (Delegate_alEffectfv)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffectfv"), typeof(Delegate_alEffectfv));
                Imported_alGetEffecti = (Delegate_alGetEffecti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffecti"), typeof(Delegate_alGetEffecti));
                Imported_alGetEffectf = (Delegate_alGetEffectf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffectf"), typeof(Delegate_alGetEffectf));
                Imported_alGetEffectfv = (Delegate_alGetEffectfv)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffectfv"), typeof(Delegate_alGetEffectfv));
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to marshal Effect functions. " + e.ToString());
                return;
            }
            // Console.WriteLine("Effect functions appear to be ok.");

            try
            {
                Imported_alGenFilters = (Delegate_alGenFilters)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenFilters"), typeof(Delegate_alGenFilters));
                Imported_alDeleteFilters = (Delegate_alDeleteFilters)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteFilters"), typeof(Delegate_alDeleteFilters));
                Imported_alIsFilter = (Delegate_alIsFilter)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsFilter"), typeof(Delegate_alIsFilter));
                Imported_alFilteri = (Delegate_alFilteri)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilteri"), typeof(Delegate_alFilteri));
                Imported_alFilterf = (Delegate_alFilterf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilterf"), typeof(Delegate_alFilterf));
                Imported_alGetFilteri = (Delegate_alGetFilteri)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetFilteri"), typeof(Delegate_alGetFilteri));
                Imported_alGetFilterf = (Delegate_alGetFilterf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetFilterf"), typeof(Delegate_alGetFilterf));
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to marshal Filter functions. " + e.ToString());
                return;
            }
            // Console.WriteLine("Filter functions appear to be ok.");

            try
            {
                Imported_alGenAuxiliaryEffectSlots = (Delegate_alGenAuxiliaryEffectSlots)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenAuxiliaryEffectSlots"), typeof(Delegate_alGenAuxiliaryEffectSlots));
                Imported_alDeleteAuxiliaryEffectSlots = (Delegate_alDeleteAuxiliaryEffectSlots)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteAuxiliaryEffectSlots"), typeof(Delegate_alDeleteAuxiliaryEffectSlots));
                Imported_alIsAuxiliaryEffectSlot = (Delegate_alIsAuxiliaryEffectSlot)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsAuxiliaryEffectSlot"), typeof(Delegate_alIsAuxiliaryEffectSlot));
                Imported_alAuxiliaryEffectSloti = (Delegate_alAuxiliaryEffectSloti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alAuxiliaryEffectSloti"), typeof(Delegate_alAuxiliaryEffectSloti));
                Imported_alAuxiliaryEffectSlotf = (Delegate_alAuxiliaryEffectSlotf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alAuxiliaryEffectSlotf"), typeof(Delegate_alAuxiliaryEffectSlotf));
                Imported_alGetAuxiliaryEffectSloti = (Delegate_alGetAuxiliaryEffectSloti)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetAuxiliaryEffectSloti"), typeof(Delegate_alGetAuxiliaryEffectSloti));
                Imported_alGetAuxiliaryEffectSlotf = (Delegate_alGetAuxiliaryEffectSlotf)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetAuxiliaryEffectSlotf"), typeof(Delegate_alGetAuxiliaryEffectSlotf));
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to marshal AuxiliaryEffectSlot functions. " + e.ToString());
                return;
            }
            // Console.WriteLine("Auxiliary Effect Slot functions appear to be ok.");

            // didn't return so far, everything went fine.
            _valid = true;
        }

        #endregion Constructor / Extension Loading
    }
}