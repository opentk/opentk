#region --- OpenTK.OpenAL License ---
/* EfxFunctions.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
#endregion

using System;
using System.Runtime.InteropServices;

using OpenTK.Math;

namespace OpenTK.OpenAL
{
    public partial class EfxExtension
    {
        #region Effect Object

        #region alGenEffects

        // typedef void (__cdecl *LPALGENEFFECTS)( ALsizei n, ALuint* effects );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGenEffects( int n,[Out] uint* effects );

        //[CLSCompliant(false)]
        private Delegate_alGenEffects Imported_alGenEffects;

        /// <summary>The alGenEffects function is used to create one or more Effect objects. An Effect object stores an effect type and a set of parameter values to control that Effect. In order to use an Effect it must be attached to an Auxiliary Effect Slot object</summary>
        /// <remarks>After creation an Effect has no type (AL_EFFECT_NULL), so before it can be used to store a set of parameters, the application must specify what type of effect should be stored in the object, using alEffecti.</remarks>
        /// <param name="n">Number of Effects to be created.</param>
        /// <param name="effects">Pointer addressing sufficient memory to store n Effect object identifiers.</param>
        [CLSCompliant(false)]
        public void GenEffects( int n,out uint effects )
        {
            unsafe
            {
                fixed ( uint* ptr = &effects )
                {
                    Imported_alGenEffects(n,ptr);
                    effects = *ptr;
                }
            }
        }

        [CLSCompliant(false)]
        /// <summary>This function generates only one Effect.</summary>
        /// <param name="effect">Storage UInt32 for the new effect name/handle.</param>
        public void GenEffects( out uint effect )
        {
            unsafe
            {
                fixed ( uint* ptr = &effect )
                {
                    Imported_alGenEffects(1,ptr);
                }
            }
        }

        #endregion alGenEffects

        #region alDeleteEffects

        // typedef void (__cdecl *LPALDELETEEFFECTS)( ALsizei n, ALuint* effects );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alDeleteEffects( int n,[In] uint* effects );

        //[CLSCompliant(false)]
        private Delegate_alDeleteEffects Imported_alDeleteEffects;

        /// <summary>The alDeleteEffects function is used to delete and free resources for Effect objects previously created with alGenEffects.</summary>
        /// <param name="n">Number of Effects to be deleted.</param>
        /// <param name="effects">Pointer to n Effect object identifiers.</param>
        [CLSCompliant(false)]
        public void DeleteEffects( int n,ref uint[] effects )
        {
            unsafe
            {
                fixed ( uint* ptr = effects )
                {
                    Imported_alDeleteEffects(n,ptr);
                }
            }
        }

        /// <summary>This function deletes one Effect only.</summary>
        /// <param name="effect">Pointer to an effect name/handle identifying the Effect Object to be deleted.</param>
        [CLSCompliant(false)]
        public void DeleteEffects( ref uint effect )
        {
            unsafe
            {
                fixed ( uint* ptr = &effect )
                {
                    Imported_alDeleteEffects(1,ptr);
                }
            }
        }

        #endregion alDeleteEffects

        #region alIsEffect

        // typedef ALboolean (__cdecl *LPALISEFFECT)( ALuint eid );
        //[CLSCompliant(false)]
        private delegate bool Delegate_alIsEffect( uint eid );

        //[CLSCompliant(false)]
        private Delegate_alIsEffect Imported_alIsEffect;

        /// <summary>The alIsEffect function is used to determine if an object identifier is a valid Effect object.</summary>
        /// <param name="eid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Effect, False otherwise.</returns>
        [CLSCompliant(false)]
        public bool IsEffect( uint eid )
        {
            return Imported_alIsEffect(eid);
        }

        #endregion alIsEffect

        #region alEffecti

        // typedef void (__cdecl *LPALEFFECTI)( ALuint eid, ALenum param, ALint value); 
        //[CLSCompliant(false)]
        private delegate void Delegate_alEffecti( uint eid,Enums.EfxEffecti param,int value );

        //[CLSCompliant(false)]
        private Delegate_alEffecti Imported_alEffecti;

        /// <summary>This function is used to set integer properties on Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        [CLSCompliant(false)]
        public void Effect( uint eid,Enums.EfxEffecti param,int value )
        {
            Imported_alEffecti(eid,param,value);
        }

        /// <summary>(Helper) internally calls alEffecti(eid,Enums.EfxEffecti.EffectType,(int) type)</summary>
        /// <param name="eid">Effect id.</param>
        /// <param name="type">Effect type.</param>
        [CLSCompliant(false)]
        public void BindEffect( uint eid,Enums.EfxEffectType type )
        {
            Imported_alEffecti(eid,Enums.EfxEffecti.EffectType,(int) type);
        }

        #endregion alEffecti

        #region alEffectf

        // typedef void (__cdecl *LPALEFFECTF)( ALuint eid, ALenum param, ALfloat value);
        //[CLSCompliant(false)]
        private delegate void Delegate_alEffectf( uint eid,Enums.EfxEffectf param,float value );

        //[CLSCompliant(false)]
        private Delegate_alEffectf Imported_alEffectf;

        /// <summary>This function is used to set floating point properties on Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating point value.</param>
        [CLSCompliant(false)]
        public void Effect( uint eid,Enums.EfxEffectf param,float value )
        {
            Imported_alEffectf(eid,param,value);
        }

        #endregion alEffectf

        #region alEffectfv

        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alEffectfv(uint eid, Enums.EfxEffect3f param, [In] float* values);
 // typedef void (__cdecl *LPALEFFECTFV)( ALuint eid, ALenum param, ALfloat* values ); 

        //[CLSCompliant(false)]
        private Delegate_alEffectfv Imported_alEffectfv;

        [CLSCompliant(false)]
        public void Effect( uint eid,Enums.EfxEffect3f param,ref Vector3 values )
        {
            unsafe
            {
                fixed ( float* ptr = &values.X )
                {
                    Imported_alEffectfv(eid,param,ptr);
                }
            }
        }

        #endregion alEffectfv

        #region alGetEffecti

        // typedef void (__cdecl *LPALGETEFFECTI)( ALuint eid, ALenum pname, ALint* value );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetEffecti( uint eid,Enums.EfxEffecti pname,[Out] int* value );

        //[CLSCompliant(false)]
        private Delegate_alGetEffecti Imported_alGetEffecti;

        /// <summary>This function is used to retrieve integer properties from Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        [CLSCompliant(false)]
        public void GetEffect( uint eid,Enums.EfxEffecti pname,out int value )
        {
            unsafe
            {
                fixed ( int* ptr = &value )
                {
                    Imported_alGetEffecti(eid,pname,ptr);
                }
            }
        }

        #endregion alGetEffecti

        #region alGetEffectf

        // typedef void (__cdecl *LPALGETEFFECTF)( ALuint eid, ALenum pname, ALfloat* value );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetEffectf( uint eid,Enums.EfxEffectf pname,[Out]float* value );

        //[CLSCompliant(false)]
        private Delegate_alGetEffectf Imported_alGetEffectf;

        /// <summary>This function is used to retrieve floating point properties from Effect objects.</summary>
        /// <param name="eid">Effect object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating point value will be stored.</param>
        [CLSCompliant(false)]
        public void GetEffect( uint eid,Enums.EfxEffectf pname,out float value )
        {
            unsafe
            {
                fixed ( float* ptr = &value )
                {
                    Imported_alGetEffectf(eid,pname,ptr);
                }
            }
        }

        #endregion alGetEffectf

        #region alGetEffectfv
       
      
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetEffectfv( uint eid,Enums.EfxEffect3f param,[Out] float* values );
        // typedef void (__cdecl *LPALGETEFFECTFV)( ALuint eid, ALenum pname, ALfloat* values );

        //[CLSCompliant(false)]
        private Delegate_alGetEffectfv Imported_alGetEffectfv;

        [CLSCompliant(false)]
        public void GetEffect( uint eid,Enums.EfxEffect3f param,out Vector3 values )
        {
            unsafe
            {
                fixed ( float* ptr = &values.X )
                {
                    Imported_alGetEffectfv(eid,param,ptr);
                    values.X = ptr[0];
                    values.Y = ptr[1];
                    values.Z = ptr[2];
                }
            }
        }

        #endregion alGetEffectfv

        // Not used:
        // typedef void (__cdecl *LPALEFFECTIV)( ALuint eid, ALenum param, ALint* values ); 
        // typedef void (__cdecl *LPALGETEFFECTIV)( ALuint eid, ALenum pname, ALint* values );

        #endregion Effect Object

        #region Filter Object

        #region alGenFilters

        // typedef void (__cdecl *LPALGENFILTERS)( ALsizei n, ALuint* filters ); 
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGenFilters( int n,[Out] uint* filters );

        //[CLSCompliant(false)]
        private Delegate_alGenFilters Imported_alGenFilters;

        /// <summary>The alGenFilters function is used to create one or more Filter objects. A Filter object stores a filter type and a set of parameter values to control that Filter. Filter objects can be attached to Sources as Direct Filters or Auxiliary Send Filters.</summary>
        /// <remarks>After creation a Filter has no type (AL_FILTER_NULL), so before it can be used to store a set of parameters, the application must specify what type of filter should be stored in the object, using alFilteri.</remarks>
        /// <param name="n">Number of Filters to be created.</param>
        /// <param name="filters">Pointer addressing sufficient memory to store n Filter object identifiers.</param>
        [CLSCompliant(false)]
        public void GenFilters( int n,out uint filters )
        {
            unsafe
            {
                fixed ( uint* ptr = &filters )
                {
                    Imported_alGenFilters(n,ptr);
                    filters = *ptr;
                }
            }
        }

        [CLSCompliant(false)]
        /// <summary>This function generates only one Filter.</summary>
        /// <param name="filter">Storage UInt32 for the new filter name/handle.</param>
        public void GenFilters( out uint filter )
        {
            unsafe
            {
                fixed ( uint* ptr = &filter )
                {
                    Imported_alGenFilters(1,ptr);
                }
            }
        }

        #endregion alGenFilters

        #region alDeleteFilters

        // typedef void (__cdecl *LPALDELETEFILTERS)( ALsizei n, ALuint* filters );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alDeleteFilters( int n,[In] uint* filters );

        //[CLSCompliant(false)]
        private Delegate_alDeleteFilters Imported_alDeleteFilters;

        /// <summary>The alDeleteFilters function is used to delete and free resources for Filter objects previously created with alGenFilters.</summary>
        /// <param name="n">Number of Filters to be deleted.</param>
        /// <param name="filters">Pointer to n Filter object identifiers.</param>
        [CLSCompliant(false)]
        public void DeleteFilters( int n,ref uint[] filters )
        {
            unsafe
            {
                fixed ( uint* ptr = filters )
                {
                    Imported_alDeleteFilters(n,ptr);
                }
            }
        }

        /// <summary>This function deletes one Filter only.</summary>
        /// <param name="filter">Pointer to an filter name/handle identifying the Filter Object to be deleted.</param>
        [CLSCompliant(false)]
        public void DeleteFilters( ref uint filter )
        {
            unsafe
            {
                fixed ( uint* ptr = &filter )
                {
                    Imported_alDeleteFilters(1,ptr);
                }
            }
        }

        #endregion alDeleteFilters

        #region alIsFilter

        // typedef ALboolean (__cdecl *LPALISFILTER)( ALuint fid );
        //[CLSCompliant(false)]
        private delegate bool Delegate_alIsFilter( uint fid );

        //[CLSCompliant(false)]
        private Delegate_alIsFilter Imported_alIsFilter;

        /// <summary>The alIsFilter function is used to determine if an object identifier is a valid Filter object.</summary>
        /// <param name="fid">Effect identifier to validate.</param>
        /// <returns>True if the identifier is a valid Filter, False otherwise.</returns>
        [CLSCompliant(false)]
        public bool IsFilter( uint fid )
        {
            return Imported_alIsFilter(fid);
        }

        #endregion alIsFilter

        #region alFilteri

        // typedef void (__cdecl *LPALFILTERI)( ALuint fid, ALenum param, ALint value );
        //[CLSCompliant(false)]
        private delegate void Delegate_alFilteri( uint fid,Enums.EfxFilteri param,int value );

        //[CLSCompliant(false)]
        private Delegate_alFilteri Imported_alFilteri;

        /// <summary>This function is used to set integer properties on Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Integer value.</param>
        [CLSCompliant(false)]
        public void Filter( uint fid,Enums.EfxFilteri param,int value )
        {
            Imported_alFilteri(fid,param,value);
        }

        #endregion alFilteri( uint fid,Enums.EfxFilteri param,int value )

        #region alFilterf

        // typedef void (__cdecl *LPALFILTERF)( ALuint fid, ALenum param, ALfloat value); 
        //[CLSCompliant(false)]
        private delegate void Delegate_alFilterf( uint fid,Enums.EfxFilterf param,float value );

        //[CLSCompliant(false)]
        private Delegate_alFilterf Imported_alFilterf;

        /// <summary>This function is used to set floating point properties on Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="param">Effect property to set.</param>
        /// <param name="value">Floating point value.</param>
        [CLSCompliant(false)]
        public void Filter( uint fid,Enums.EfxFilterf param,float value )
        {
            Imported_alFilterf(fid,param,value);
        }

        #endregion alFilterf

        #region alGetFilteri

        // typedef void (__cdecl *LPALGETFILTERI)( ALuint fid, ALenum pname, ALint* value );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetFilteri( uint fid,Enums.EfxFilteri pname,[Out] int* value );

        //[CLSCompliant(false)]
        private Delegate_alGetFilteri Imported_alGetFilteri;

        /// <summary>This function is used to retrieve integer properties from Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        [CLSCompliant(false)]
        public void GetFilter( uint fid,Enums.EfxFilteri pname,out int value )
        {
            unsafe
            {
                fixed ( int* ptr = &value )
                {
                    Imported_alGetFilteri(fid,pname,ptr);
                }
            }
        }

        #endregion alGetFilteri

        #region alGetFilterf

        // typedef void (__cdecl *LPALGETFILTERF)( ALuint fid, ALenum pname, ALfloat* value );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetFilterf( uint fid,Enums.EfxFilterf pname,[Out] float* value );

        //[CLSCompliant(false)]
        private Delegate_alGetFilterf Imported_alGetFilterf;

        /// <summary>This function is used to retrieve floating point properties from Filter objects.</summary>
        /// <param name="fid">Filter object identifier.</param>
        /// <param name="pname">Effect property to retrieve.</param>
        /// <param name="value">Address where floating point value will be stored.</param>
        [CLSCompliant(false)]
        public void GetFilter( uint fid,Enums.EfxFilterf pname,out float value )
        {
            unsafe
            {
                fixed ( float* ptr = &value )
                {
                    Imported_alGetFilterf(fid,pname,ptr);
                }
            }
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

        // typedef void (__cdecl *LPALGENAUXILIARYEFFECTSLOTS)( ALsizei n, ALuint* slots );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGenAuxiliaryEffectSlots( int n,[Out] uint* slots );

        //[CLSCompliant(false)]
        private Delegate_alGenAuxiliaryEffectSlots Imported_alGenAuxiliaryEffectSlots;

        /// <summary>The alGenAuxiliaryEffectSlots function is used to create one or more Auxiliary Effect Slots. The number of slots that can be created will be dependant upon the Open AL device used.</summary>
        /// <remarks>An application should check the OpenAL error state after making this call to determine if the Effect Slot was successfully created. If the function call fails then none of the requested Effect Slots are created. A good strategy for creating any OpenAL object is to use a for-loop and generate one object each loop iteration and then check for an error condition. If an error is set then the loop can be broken and the application can determine if sufficient resources are available.</remarks>
        /// <param name="n">Number of Auxiliary Effect Slots to be created.</param>
        /// <param name="slots">Pointer addressing sufficient memory to store n Effect Slot object identifiers.</param>
        [CLSCompliant(false)]
        public void GenAuxiliaryEffectSlots( int n,out uint slots )
        {
            unsafe
            {
                fixed ( uint* ptr = &slots )
                {
                    Imported_alGenAuxiliaryEffectSlots(n,ptr);
                    slots = *ptr;
                }
            }
        }

        [CLSCompliant(false)]
        /// <summary>This function generates only one Auxiliary Effect Slot.</summary>
        /// <param name="slot">Storage UInt32 for the new auxiliary effect slot name/handle.</param>
        public void GenAuxiliaryEffectSlots( out uint slot )
        {
            unsafe
            {
                fixed ( uint* ptr = &slot )
                {
                    Imported_alGenAuxiliaryEffectSlots(1,ptr);
                }
            }
        }

        #endregion alGenAuxiliaryEffectSlots

        #region alDeleteAuxiliaryEffectSlots

        // typedef void (__cdecl *LPALDELETEAUXILIARYEFFECTSLOTS)( ALsizei n, ALuint* slots );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alDeleteAuxiliaryEffectSlots( int n,[In] uint* slots );

        //[CLSCompliant(false)]
        private Delegate_alDeleteAuxiliaryEffectSlots Imported_alDeleteAuxiliaryEffectSlots;

        /// <summary>The alDeleteAuxiliaryEffectSlots function is used to delete and free resources for Auxiliary Effect Slots previously created with alGenAuxiliaryEffectSlots.</summary>
        /// <param name="n">Number of Auxiliary Effect Slots to be deleted.</param>
        /// <param name="slots">Pointer to n Effect Slot object identifiers.</param>
        [CLSCompliant(false)]
        public void DeleteAuxiliaryEffectSlots( int n,ref uint[] slots )
        {
            unsafe
            {
                fixed ( uint* ptr = slots )
                {
                    Imported_alDeleteAuxiliaryEffectSlots(n,ptr);
                }
            }
        }

        /// <summary>This function deletes one AuxiliaryEffectSlot only.</summary>
        /// <param name="slot">Pointer to an auxiliary effect slot name/handle identifying the Auxiliary Effect Slot Object to be deleted.</param>
        [CLSCompliant(false)]
        public void DeleteAuxiliaryEffectSlots( ref uint slot )
        {
            unsafe
            {
                fixed ( uint* ptr = &slot )
                {
                    Imported_alDeleteAuxiliaryEffectSlots(1,ptr);
                }
            }
        }

        #endregion alDeleteAuxiliaryEffectSlots

        #region alIsAuxiliaryEffectSlot

        // typedef ALboolean (__cdecl *LPALISAUXILIARYEFFECTSLOT)( ALuint slot ); 
        //[CLSCompliant(false)]
        private delegate bool Delegate_alIsAuxiliaryEffectSlot( uint slot );

        //[CLSCompliant(false)]
        private Delegate_alIsAuxiliaryEffectSlot Imported_alIsAuxiliaryEffectSlot;

        /// <summary>The alIsAuxiliaryEffectSlot function is used to determine if an object identifier is a valid Auxiliary Effect Slot object.</summary>
        /// <param name="slot">Effect Slot object identifier to validate.</param>
        /// <returns>True if the identifier is a valid Auxiliary Effect Slot, False otherwise.</returns>
        [CLSCompliant(false)]
        public bool IsAuxiliaryEffectSlot( uint slot )
        {
            return Imported_alIsAuxiliaryEffectSlot(slot);
        }

        #endregion alIsAuxiliaryEffectSlot

        #region alAuxiliaryEffectSloti

        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTI)( ALuint asid, ALenum param, ALint value ); 
        //[CLSCompliant(false)]
        private delegate void Delegate_alAuxiliaryEffectSloti( uint asid,Enums.EfxAuxiliaryi param,int value );

        //[CLSCompliant(false)]
        private Delegate_alAuxiliaryEffectSloti Imported_alAuxiliaryEffectSloti;

        /// <summary>This function is used to set integer properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Integer value.</param>
        [CLSCompliant(false)]
        public void AuxiliaryEffectSlot( uint asid,Enums.EfxAuxiliaryi param,int value )
        {
            Imported_alAuxiliaryEffectSloti(asid,param,value);
        }

        #endregion alAuxiliaryEffectSloti

        #region alAuxiliaryEffectSlotf

        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTF)( ALuint asid, ALenum param, ALfloat value ); 
        //[CLSCompliant(false)]
        private delegate void Delegate_alAuxiliaryEffectSlotf( uint asid,Enums.EfxAuxiliaryf param,float value );

        //[CLSCompliant(false)]
        private Delegate_alAuxiliaryEffectSlotf Imported_alAuxiliaryEffectSlotf;

        /// <summary>This function is used to set floating point properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="param">Auxiliary Effect Slot property to set.</param>
        /// <param name="value">Floating point value.</param>
        [CLSCompliant(false)]
        public void AuxiliaryEffectSlot( uint asid,Enums.EfxAuxiliaryf param,float value )
        {
            Imported_alAuxiliaryEffectSlotf(asid,param,value);
        }

        #endregion alAuxiliaryEffectSlotf

        #region alGetAuxiliaryEffectSloti

        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTI)( ALuint asid, ALenum pname, ALint* value );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetAuxiliaryEffectSloti( uint asid,Enums.EfxAuxiliaryi pname,[Out] int* value );

        //[CLSCompliant(false)]
        private Delegate_alGetAuxiliaryEffectSloti Imported_alGetAuxiliaryEffectSloti;

        /// <summary>This function is used to retrieve integer properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where integer value will be stored.</param>
        [CLSCompliant(false)]
        public void GetAuxiliaryEffectSlot( uint asid,Enums.EfxAuxiliaryi pname,out int value )
        {
            unsafe
            {
                fixed ( int* ptr = &value )
                {
                    Imported_alGetAuxiliaryEffectSloti(asid,pname,ptr);
                }
            }
        }

        #endregion alGetAuxiliaryEffectSloti

        #region alGetAuxiliaryEffectSlotf

        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTF)( ALuint asid, ALenum pname, ALfloat* value );
        //[CLSCompliant(false)]
        unsafe private delegate void Delegate_alGetAuxiliaryEffectSlotf( uint asid,Enums.EfxAuxiliaryf pname,[Out] float* value );

        //[CLSCompliant(false)]
        private Delegate_alGetAuxiliaryEffectSlotf Imported_alGetAuxiliaryEffectSlotf;

        /// <summary>This function is used to retrieve floating properties on Auxiliary Effect Slot objects.</summary>
        /// <param name="asid">Auxiliary Effect Slot object identifier.</param>
        /// <param name="pname">Auxiliary Effect Slot property to retrieve.</param>
        /// <param name="value">Address where floating point value will be stored.</param>
        [CLSCompliant(false)]
        public void GetAuxiliaryEffectSlot( uint asid,Enums.EfxAuxiliaryf pname,out float value )
        {
            unsafe
            {
                fixed ( float* ptr = &value )
                {
                    Imported_alGetAuxiliaryEffectSlotf(asid,pname,ptr);
                }
            }
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
        { get { return _valid; } }

        public EfxExtension( )
        {
            _valid = false;

            if ( Alc.IsExtensionPresent(Alc.GetContextsDevice(Alc.GetCurrentContext( )),"ALC_EXT_EFX") == false )
            {
                Console.WriteLine("Extension unknown.");
                return;
            }
            Console.WriteLine("ALC_EXT_EFX found.");

            try
            {
                Imported_alGenEffects = (Delegate_alGenEffects) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenEffects"),typeof(Delegate_alGenEffects));
                Imported_alDeleteEffects = (Delegate_alDeleteEffects) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteEffects"),typeof(Delegate_alDeleteEffects));
                Imported_alIsEffect = (Delegate_alIsEffect) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsEffect"),typeof(Delegate_alIsEffect));
                Imported_alEffecti = (Delegate_alEffecti) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffecti"),typeof(Delegate_alEffecti));
                Imported_alEffectf = (Delegate_alEffectf) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffectf"),typeof(Delegate_alEffectf));
                Imported_alEffectfv = (Delegate_alEffectfv) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alEffectfv"),typeof(Delegate_alEffectfv));
                Imported_alGetEffecti = (Delegate_alGetEffecti) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffecti"),typeof(Delegate_alGetEffecti));
                Imported_alGetEffectf = (Delegate_alGetEffectf) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffectf"),typeof(Delegate_alGetEffectf));
                Imported_alGetEffectfv = (Delegate_alGetEffectfv) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetEffectfv"),typeof(Delegate_alGetEffectfv));
            } catch ( Exception e )
            {
                Console.WriteLine("Failed to marshal Effect functions. " + e.ToString( ));
                return;
            }
            Console.WriteLine("Effect functions appear to be ok.");

            try
            {
                Imported_alGenFilters = (Delegate_alGenFilters) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenFilters"),typeof(Delegate_alGenFilters));
                Imported_alDeleteFilters = (Delegate_alDeleteFilters) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteFilters"),typeof(Delegate_alDeleteFilters));
                Imported_alIsFilter = (Delegate_alIsFilter) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsFilter"),typeof(Delegate_alIsFilter));
                Imported_alFilteri = (Delegate_alFilteri) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilteri"),typeof(Delegate_alFilteri));
                Imported_alFilterf = (Delegate_alFilterf) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alFilterf"),typeof(Delegate_alFilterf));
                Imported_alGetFilteri = (Delegate_alGetFilteri) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetFilteri"),typeof(Delegate_alGetFilteri));
                Imported_alGetFilterf = (Delegate_alGetFilterf) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetFilterf"),typeof(Delegate_alGetFilterf));
            } catch ( Exception e )
            {
                Console.WriteLine("Failed to marshal Filter functions. " + e.ToString( ));
                return;
            }
            Console.WriteLine("Filter functions appear to be ok.");

            try
            {
                Imported_alGenAuxiliaryEffectSlots = (Delegate_alGenAuxiliaryEffectSlots) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGenAuxiliaryEffectSlots"),typeof(Delegate_alGenAuxiliaryEffectSlots));
                Imported_alDeleteAuxiliaryEffectSlots = (Delegate_alDeleteAuxiliaryEffectSlots) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alDeleteAuxiliaryEffectSlots"),typeof(Delegate_alDeleteAuxiliaryEffectSlots));
                Imported_alIsAuxiliaryEffectSlot = (Delegate_alIsAuxiliaryEffectSlot) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alIsAuxiliaryEffectSlot"),typeof(Delegate_alIsAuxiliaryEffectSlot));
                Imported_alAuxiliaryEffectSloti = (Delegate_alAuxiliaryEffectSloti) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alAuxiliaryEffectSloti"),typeof(Delegate_alAuxiliaryEffectSloti));
                Imported_alAuxiliaryEffectSlotf = (Delegate_alAuxiliaryEffectSlotf) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alAuxiliaryEffectSlotf"),typeof(Delegate_alAuxiliaryEffectSlotf));
                Imported_alGetAuxiliaryEffectSloti = (Delegate_alGetAuxiliaryEffectSloti) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetAuxiliaryEffectSloti"),typeof(Delegate_alGetAuxiliaryEffectSloti));
                Imported_alGetAuxiliaryEffectSlotf = (Delegate_alGetAuxiliaryEffectSlotf) Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("alGetAuxiliaryEffectSlotf"),typeof(Delegate_alGetAuxiliaryEffectSlotf));
            } catch ( Exception e )
            {
                Console.WriteLine("Failed to marshal AuxiliaryEffectSlot functions. " + e.ToString( ));
                return;
            }
            Console.WriteLine("Auxiliary Effect Slot functions appear to be ok.");

            // didn't return so far, everything went fine.
            _valid = true;
        }

        #endregion Constructor / Extension Loading
    }

}
