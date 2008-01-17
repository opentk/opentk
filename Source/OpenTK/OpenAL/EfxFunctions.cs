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
        //Effect object functions.

        /* Create Effect objects. */
        // typedef void (__cdecl *LPALGENEFFECTS)( ALsizei n, ALuint* effects );
        unsafe private delegate void DelegatealGenEffects(int n, [Out] uint* effects);

        /* Delete Effect objects. */
        // typedef void (__cdecl *LPALDELETEEFFECTS)( ALsizei n, ALuint* effects );
        unsafe private delegate void DelegatealDeleteEffects(int n, [In] uint* effects);

        /* Verify a handle is a valid Effect. */
        // typedef ALboolean (__cdecl *LPALISEFFECT)( ALuint eid );
        private delegate AL.Bool DelegatealIsEffect(uint eid);

        /* Set an integer parameter for an Effect object. */
        // typedef void (__cdecl *LPALEFFECTI)( ALuint eid, ALenum param, ALint value); 
        private delegate void DelegateAlEffecti(uint eid, EfxEffecti param, int value);


        /* Set a floating point parameter for an Effect object. */
        // typedef void (__cdecl *LPALEFFECTF)( ALuint eid, ALenum param, ALfloat value);
        private delegate void DelegateAlEffectf(uint eid, EfxEffectf param, float value);


        /* Get an integer parameter for an Effect object. */
        // typedef void (__cdecl *LPALGETEFFECTI)( ALuint eid, ALenum pname, ALint* value );


        /* Get a floating point parameter for an Effect object. */
        // typedef void (__cdecl *LPALGETEFFECTF)( ALuint eid, ALenum pname, ALfloat* value );

        // Not used: typedef void (__cdecl *LPALEFFECTIV)( ALuint eid, ALenum param, ALint* values ); 
        // Not used: typedef void (__cdecl *LPALEFFECTFV)( ALuint eid, ALenum param, ALfloat* values ); 
        // Not used: typedef void (__cdecl *LPALGETEFFECTIV)( ALuint eid, ALenum pname, ALint* values );
        // Not used: typedef void (__cdecl *LPALGETEFFECTFV)( ALuint eid, ALenum pname, ALfloat* values );


        // Filter object functions


        /* Create Filter objects. */
        // typedef void (__cdecl *LPALGENFILTERS)( ALsizei n, ALuint* filters ); 

        /* Delete Filter objects. */
        // typedef void (__cdecl *LPALDELETEFILTERS)( ALsizei n, ALuint* filters );

        /* Verify a handle is a valid Filter. */
        // typedef ALboolean (__cdecl *LPALISFILTER)( ALuint fid );

        /* Set an integer parameter for a Filter object. */
        // typedef void (__cdecl *LPALFILTERI)( ALuint fid, ALenum param, ALint value ); 
        // typedef void (__cdecl *LPALFILTERIV)( ALuint fid, ALenum param, ALint* values ); 

        /* Set a floating point parameter for an Filter object. */
        // typedef void (__cdecl *LPALFILTERF)( ALuint fid, ALenum param, ALfloat value); 
        // typedef void (__cdecl *LPALFILTERFV)( ALuint fid, ALenum param, ALfloat* values ); 

        /* Get an integer parameter for a Filter object. */
        // typedef void (__cdecl *LPALGETFILTERI)( ALuint fid, ALenum pname, ALint* value );
        // typedef void (__cdecl *LPALGETFILTERIV)( ALuint fid, ALenum pname, ALint* values );

        /* Get a floating point parameter for a Filter object. */
        // typedef void (__cdecl *LPALGETFILTERF)( ALuint fid, ALenum pname, ALfloat* value );
        // typedef void (__cdecl *LPALGETFILTERFV)( ALuint fid, ALenum pname, ALfloat* values );


        // Auxiliary Slot object functions


        /* Create Auxiliary Slot objects. */
        // typedef void (__cdecl *LPALGENAUXILIARYEFFECTSLOTS)( ALsizei n, ALuint* slots ); 

        /* Delete Auxiliary Slot objects. */
        // typedef void (__cdecl *LPALDELETEAUXILIARYEFFECTSLOTS)( ALsizei n, ALuint* slots );

        /* Verify a handle is a valid Auxiliary Slot. */
        // typedef ALboolean (__cdecl *LPALISAUXILIARYEFFECTSLOT)( ALuint slot ); 

        /* Set an integer parameter for a Auxiliary Slot object. */
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTI)( ALuint asid, ALenum param, ALint value ); 
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTIV)( ALuint asid, ALenum param, ALint* values ); 

        /* Set a floating point parameter for an Auxiliary Slot object. */
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTF)( ALuint asid, ALenum param, ALfloat value ); 
        // typedef void (__cdecl *LPALAUXILIARYEFFECTSLOTFV)( ALuint asid, ALenum param, ALfloat* values ); 

        /* Get an integer parameter for a Auxiliary Slot object. */
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTI)( ALuint asid, ALenum pname, ALint* value );
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTIV)( ALuint asid, ALenum pname, ALint* values );

        /* Get a floating point parameter for a Auxiliary Slot object. */
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTF)( ALuint asid, ALenum pname, ALfloat* value );
        // typedef void (__cdecl *LPALGETAUXILIARYEFFECTSLOTFV)( ALuint asid, ALenum pname, ALfloat* values );
    }
}
