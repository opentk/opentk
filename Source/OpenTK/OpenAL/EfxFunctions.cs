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

namespace OpenTK.OpenAL
{
    public partial class Efx
    {
        #region Effect object functions.

        // typedef void (__cdecl *LPALGENEFFECTS)( ALsizei n, ALuint* effects );
        unsafe private delegate void Delegateal_GenEffects(int n, [Out] uint* effects);

        // typedef void (__cdecl *LPALDELETEEFFECTS)( ALsizei n, ALuint* effects );
        unsafe private delegate void Delegate_alDeleteEffects(int n, [In] uint* effects);

        // typedef ALboolean (__cdecl *LPALISEFFECT)( ALuint eid );
        private delegate bool Delegate_alIsEffect(uint eid);

        // typedef void (__cdecl *LPALEFFECTI)( ALuint eid, ALenum param, ALint value); 
        private delegate void Delegate_alEffecti(uint eid, EfxEffecti param, int value);

        // typedef void (__cdecl *LPALEFFECTF)( ALuint eid, ALenum param, ALfloat value);
        private delegate void Delegate_alEffectf(uint eid, EfxEffectf param, float value);

        // typedef void (__cdecl *LPALGETEFFECTI)( ALuint eid, ALenum pname, ALint* value );
        unsafe private delegate void Delegate_alGetEffecti(uint eid, EfxEffecti pname, [Out] int* value);

        // typedef void (__cdecl *LPALGETEFFECTF)( ALuint eid, ALenum pname, ALfloat* value );
        unsafe private delegate void Delegate_alGetEffectf(uint eid, EfxEffectf pname, [Out]float* value);

        // Not used:
        // typedef void (__cdecl *LPALEFFECTIV)( ALuint eid, ALenum param, ALint* values ); 
        // typedef void (__cdecl *LPALEFFECTFV)( ALuint eid, ALenum param, ALfloat* values ); 
        // typedef void (__cdecl *LPALGETEFFECTIV)( ALuint eid, ALenum pname, ALint* values );
        // typedef void (__cdecl *LPALGETEFFECTFV)( ALuint eid, ALenum pname, ALfloat* values );

        #endregion Effect object functions.

        #region Filter object functions

        // typedef void (__cdecl *LPALGENFILTERS)( ALsizei n, ALuint* filters ); 
        unsafe private delegate void Delegate_alGenFilters(int n, [Out] uint* filters);

        // typedef void (__cdecl *LPALDELETEFILTERS)( ALsizei n, ALuint* filters );
        unsafe private delegate void Delegate_alDeleteFilters(int n, [In] uint* filters);

        // typedef ALboolean (__cdecl *LPALISFILTER)( ALuint fid );
        private delegate bool Delegate_alIsFilter(uint fid);

        // typedef void (__cdecl *LPALFILTERI)( ALuint fid, ALenum param, ALint value );
        private delegate void Delegate_alFilteri(uint fid, EfxFilteri param, int value);

        // typedef void (__cdecl *LPALFILTERF)( ALuint fid, ALenum param, ALfloat value); 
        private delegate void Delegate_alFilterf(uint fid, EfxFilterf param, float value);

        // typedef void (__cdecl *LPALGETFILTERI)( ALuint fid, ALenum pname, ALint* value );
        unsafe private delegate void Delegate_alGetFilteri(uint fid, EfxFilteri pname, [Out] int* value);

        // typedef void (__cdecl *LPALGETFILTERF)( ALuint fid, ALenum pname, ALfloat* value );
        unsafe private delegate void Delegate_alGetFilterf(uint fid, EfxFilterf pname, [Out] float* value);

        // Not used:
        // typedef void (__cdecl *LPALFILTERIV)( ALuint fid, ALenum param, ALint* values ); 
        // typedef void (__cdecl *LPALFILTERFV)( ALuint fid, ALenum param, ALfloat* values ); 
        // typedef void (__cdecl *LPALGETFILTERIV)( ALuint fid, ALenum pname, ALint* values );
        // typedef void (__cdecl *LPALGETFILTERFV)( ALuint fid, ALenum pname, ALfloat* values );

        #endregion Filter object functions

        #region Auxiliary Slot object functions

        // typedef void (__cdecl *LPALGENAUXILIARYEFFECTSLOTS)( ALsizei n, ALuint* slots );
        unsafe private delegate void Delegate_alGenAuxiliaryEffectSlots(int n, [Out] uint* slots);

        // typedef void (__cdecl *LPALDELETEAUXILIARYEFFECTSLOTS)( ALsizei n, ALuint* slots );
        unsafe private delegate void Delegate_alDeleteAuxiliaryEffectSlots(int n, [In] uint* slots);

        // typedef ALboolean (__cdecl *LPALISAUXILIARYEFFECTSLOT)( ALuint slot ); 
        private delegate bool Delegate_alIsAuxiliaryEffectSlot(uint slot);

        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTI)( ALuint asid, ALenum param, ALint value ); 
        private delegate void Delegate_alAuxiliaryEffectSloti(uint asid, EfxAuxiliaryi param, int value);

        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTF)( ALuint asid, ALenum param, ALfloat value ); 
        private delegate void Delegate_alAuxiliaryEffectSlotf(uint asid, EfxAuxiliaryf param, float value);

        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTI)( ALuint asid, ALenum pname, ALint* value );
        unsafe private delegate void Delegate_alGetAuxiliaryEffectSloti(uint asid, EfxAuxiliaryi pname, [Out] int* value);

        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTF)( ALuint asid, ALenum pname, ALfloat* value );
        unsafe private delegate void Delegate_alGetAuxiliaryEffectSlotf(uint asid, EfxAuxiliaryf pname, [Out] float* value);

        // Not used:
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTIV)( ALuint asid, ALenum param, ALint* values ); 
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTFV)( ALuint asid, ALenum param, ALfloat* values ); 
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTIV)( ALuint asid, ALenum pname, ALint* values );
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTFV)( ALuint asid, ALenum pname, ALfloat* values );

        #endregion Auxiliary Slot object functions
    }
}
