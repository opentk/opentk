# wglext.spec file
# DON'T REMOVE PREVIOUS LINE!!! libspec depends on it!
#
# License Applicability. Except to the extent portions of this file are
# made subject to an alternative license as permitted in the SGI Free
# Software License B, Version 1.1 (the "License"), the contents of this
# file are subject only to the provisions of the License. You may not use
# this file except in compliance with the License. You may obtain a copy
# of the License at Silicon Graphics, Inc., attn: Legal Services, 1600
# Amphitheatre Parkway, Mountain View, CA 94043-1351, or at:
#
# http://oss.sgi.com/projects/FreeB
#
# Note that, as provided in the License, the Software is distributed on an
# "AS IS" basis, with ALL EXPRESS AND IMPLIED WARRANTIES AND CONDITIONS
# DISCLAIMED, INCLUDING, WITHOUT LIMITATION, ANY IMPLIED WARRANTIES AND
# CONDITIONS OF MERCHANTABILITY, SATISFACTORY QUALITY, FITNESS FOR A
# PARTICULAR PURPOSE, AND NON-INFRINGEMENT.
#
# Original Code. The Original Code is: OpenGL Sample Implementation,
# Version 1.2.1, released January 26, 2000, developed by Silicon Graphics,
# Inc. The Original Code is Copyright (c) 1991-2002 Silicon Graphics, Inc.
# Copyright in any portions created by third parties is as indicated
# elsewhere herein. All Rights Reserved.
#
# Additional Notice Provisions: This software was created using the
# OpenGL(R) version 1.2.1 Sample Implementation published by SGI, but has
# not been independently verified as being compliant with the OpenGL(R)
# version 1.2.1 Specification.

required-props:
param:		retval retained
category:	wgl ARB_buffer_region ARB_extensions_string ARB_pixel_format ARB_make_current_read ARB_pbuffer ARB_render_texture ARB_pixel_format_float EXT_display_color_table EXT_extensions_string EXT_make_current_read EXT_pbuffer EXT_pixel_format EXT_swap_control OML_sync_control I3D_digital_video_control I3D_gamma I3D_genlock I3D_image_buffer I3D_swap_frame_lock I3D_swap_frame_usage NV_vertex_array_range

# required-props in wgl.spec (which is not used for anything):
# dlflags:	  notlistable handcode
# wglflags:	  client-handcode server-handcode non-dispatch

#
# Boilerplate to define types used by some extensions. This is done
#   up front, since it involves some complexities in protecting
#   the declarations whether or not the -protect flag is given to
#   the generator scripts.
#

passthru: #ifndef WGL_ARB_pbuffer
passthru: DECLARE_HANDLE(HPBUFFERARB);
passthru: #endif
passthru: #ifndef WGL_EXT_pbuffer
passthru: DECLARE_HANDLE(HPBUFFEREXT);
passthru: #endif
passthru:

###############################################################################
#
# ARB Extension #4
# ARB_buffer_region commands
#
###############################################################################

CreateBufferRegionARB(hDC, iLayerPlane, uType)
	return		HANDLE
	param		hDC		HDC in value
	param		iLayerPlane	int in value
	param		uType		UINT in value
	category	ARB_buffer_region

DeleteBufferRegionARB(hRegion)
	return		VOID
	param		hRegion		HANDLE in value
	category	ARB_buffer_region

SaveBufferRegionARB(hRegion, x, y, width, height)
	return		BOOL
	param		hRegion		HANDLE in value
	param		x		int in value
	param		y		int in value
	param		width		int in value
	param		height		int in value
	category	ARB_buffer_region

RestoreBufferRegionARB(hRegion, x, y, width, height, xSrc, ySrc)
	return		BOOL
	param		hRegion		HANDLE in value
	param		x		int in value
	param		y		int in value
	param		width		int in value
	param		height		int in value
	param		xSrc		int in value
	param		ySrc		int in value
	category	ARB_buffer_region

###############################################################################
#
# ARB Extension #5
# ARB_multisample commands
#
###############################################################################

# (none)
newcategory: ARB_multisample

###############################################################################
#
# ARB Extension #8
# ARB_extensions_string commands
#
###############################################################################

GetExtensionsStringARB(hdc)
	return		String
	param		hdc		HDC in value
	category	ARB_extensions_string

###############################################################################
#
# ARB Extension #9
# ARB_pixel_format commands
#
###############################################################################

GetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues)
	return		BOOL
	param		hdc		HDC in value
	param		iPixelFormat	int in value
	param		iLayerPlane	int in value
	param		nAttributes	UINT in value
	param		piAttributes	int in array [nAttributes]
	param		piValues	int out array [nAttributes]
	category	ARB_pixel_format

GetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues)
	return		BOOL
	param		hdc		HDC in value
	param		iPixelFormat	int in value
	param		iLayerPlane	int in value
	param		nAttributes	UINT in value
	param		piAttributes	int in array [nAttributes]
	param		pfValues	FLOAT out array [nAttributes]
	category	ARB_pixel_format

ChoosePixelFormatARB(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats)
	return		BOOL
	param		hdc		HDC in value
	param		piAttribIList	int in array [COMPSIZE()]
	param		pfAttribFList	FLOAT in array [COMPSIZE()]
	param		nMaxFormats	UINT in value
	param		piFormats	int out array [COMPSIZE(nNumFormats)]
	param		nNumFormats	UINT out reference
	category	ARB_pixel_format

###############################################################################
#
# ARB Extension #10
# ARB_make_current_read commands
#
###############################################################################

MakeContextCurrentARB(hDrawDC, hReadDC, hglrc)
	return		BOOL
	param		hDrawDC		HDC in value
	param		hReadDC		HDC in value
	param		hglrc		HGLRC in value
	category	ARB_make_current_read

GetCurrentReadDCARB()
	return		HDC
	category	ARB_make_current_read

###############################################################################
#
# ARB Extension #11
# ARB_pbuffer commands
#
###############################################################################

CreatePbufferARB(hDC, iPixelFormat, iWidth, iHeight, piAttribList)
	return		HPBUFFERARB
	param		hDC		HDC in value
	param		iPixelFormat	int in value
	param		iWidth		int in value
	param		iHeight		int in value
	param		piAttribList	int in array [COMPSIZE()]
	category	ARB_pbuffer

GetPbufferDCARB(hPbuffer)
	return		HDC
	param		hPbuffer	HPBUFFERARB in value
	category	ARB_pbuffer

ReleasePbufferDCARB(hPbuffer, hDC)
	return		int
	param		hPbuffer	HPBUFFERARB in value
	param		hDC		HDC in value
	category	ARB_pbuffer

DestroyPbufferARB(hPbuffer)
	return		BOOL
	param		hPbuffer	HPBUFFERARB in value
	category	ARB_pbuffer

QueryPbufferARB(hPbuffer, iAttribute, piValue)
	return		BOOL
	param		hPbuffer	HPBUFFERARB in value
	param		iAttribute	int in value
	param		piValue		int out reference
	category	ARB_pbuffer

###############################################################################
#
# ARB Extension #20
# ARB_render_texture commands
#
###############################################################################

BindTexImageARB(hPbuffer, iBuffer)
	return		BOOL
	param		hPbuffer	HPBUFFERARB in value
	param		iBuffer		int in value
	category	ARB_render_texture

ReleaseTexImageARB(hPbuffer, iBuffer)
	return		BOOL
	param		hPbuffer	HPBUFFERARB in value
	param		iBuffer		int in value
	category	ARB_render_texture

SetPbufferAttribARB(hPbuffer, piAttribList)
	return		BOOL
	param		hPbuffer	HPBUFFERARB in value
	param		piAttribList	int in array [COMPSIZE()]
	category	ARB_render_texture

###############################################################################
#
# ARB Extension #39
# ARB_pixel_format_float commands
#
###############################################################################

# (none)
newcategory: ARB_pixel_format_float

###############################################################################
#
# Extension #167
# EXT_display_color_table commands
#
###############################################################################

CreateDisplayColorTableEXT(id)
	return		GLboolean
	param		id		GLushort in value
	category	EXT_display_color_table

LoadDisplayColorTableEXT(table, length)
	return		GLboolean
	param		table		GLushort in array [length]
	param		length		GLuint in value
	category	EXT_display_color_table

BindDisplayColorTableEXT(id)
	return		GLboolean
	param		id		GLushort in value
	category	EXT_display_color_table

DestroyDisplayColorTableEXT(id)
	return		VOID
	param		id		GLushort in value
	category	EXT_display_color_table

###############################################################################
#
# Extension #168
# EXT_extensions_string commands
#
###############################################################################

GetExtensionsStringEXT()
	return		String
	category	EXT_extensions_string

###############################################################################
#
# Extension #169
# EXT_make_current_read commands
#
###############################################################################

MakeContextCurrentEXT(hDrawDC, hReadDC, hglrc)
	return		BOOL
	param		hDrawDC		HDC in value
	param		hReadDC		HDC in value
	param		hglrc		HGLRC in value
	category	EXT_make_current_read

GetCurrentReadDCEXT()
	return		HDC
	category	EXT_make_current_read

###############################################################################
#
# Extension #171
# EXT_pbuffer commands
#
###############################################################################

CreatePbufferEXT(hDC, iPixelFormat, iWidth, iHeight, piAttribList)
	return		HPBUFFEREXT
	param		hDC		HDC in value
	param		iPixelFormat	int in value
	param		iWidth		int in value
	param		iHeight		int in value
	param		piAttribList	int in array [COMPSIZE()]
	category	EXT_pbuffer

GetPbufferDCEXT(hPbuffer)
	return		HDC
	param		hPbuffer	HPBUFFEREXT in value
	category	EXT_pbuffer

ReleasePbufferDCEXT(hPbuffer, hDC)
	return		int
	param		hPbuffer	HPBUFFEREXT in value
	param		hDC		HDC in value
	category	EXT_pbuffer

DestroyPbufferEXT(hPbuffer)
	return		BOOL
	param		hPbuffer	HPBUFFEREXT in value
	category	EXT_pbuffer

QueryPbufferEXT(hPbuffer, iAttribute, piValue)
	return		BOOL
	param		hPbuffer	HPBUFFEREXT in value
	param		iAttribute	int in value
	param		piValue		int out reference
	category	EXT_pbuffer

###############################################################################
#
# Extension #170
# EXT_pixel_format commands
#
###############################################################################

GetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues)
	return		BOOL
	param		hdc		HDC in value
	param		iPixelFormat	int in value
	param		iLayerPlane	int in value
	param		nAttributes	UINT in value
	param		piAttributes	int out array [nAttributes]
	param		piValues	int out array [nAttributes]
	category	EXT_pixel_format

GetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues)
	return		BOOL
	param		hdc		HDC in value
	param		iPixelFormat	int in value
	param		iLayerPlane	int in value
	param		nAttributes	UINT in value
	param		piAttributes	int out array [nAttributes]
	param		pfValues	FLOAT out array [nAttributes]
	category	EXT_pixel_format

ChoosePixelFormatEXT(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats)
	return		BOOL
	param		hdc		HDC in value
	param		piAttribIList	int in array [COMPSIZE()]
	param		pfAttribFList	FLOAT in array [COMPSIZE()]
	param		nMaxFormats	UINT in value
	param		piFormats	int out array [COMPSIZE(nNumFormats)]
	param		nNumFormats	UINT out reference
	category	EXT_pixel_format

###############################################################################
#
# Extension #172
# EXT_swap_control commands
#
###############################################################################

SwapIntervalEXT(interval)
	return		BOOL
	param		interval	int in value
	category	EXT_swap_control

GetSwapIntervalEXT()
	return		int
	category	EXT_swap_control

###############################################################################
#
# Extension #177
# EXT_depth_float commands
#
###############################################################################

# (none)
newcategory: EXT_depth_float

###############################################################################
#
# Extension #190
# NV_vertex_array_range commands
#
###############################################################################

AllocateMemoryNV(size, readfreq, writefreq, priority)
	return		VoidPointer
	param		size		    GLsizei in value
	param		readfreq	    GLfloat in value
	param		writefreq	    GLfloat in value
	param		priority	    GLfloat in value
	category	NV_vertex_array_range

FreeMemoryNV(pointer)
	return		void
	param		pointer		    void out array [1]
	category	NV_vertex_array_range

###############################################################################
#
# Extension #207
# 3DFX_multisample commands
#
###############################################################################

# (none)
newcategory: 3DFX_multisample

###############################################################################
#
# Extension #209
# EXT_multisample commands
#
###############################################################################

# (none)
newcategory: EXT_multisample

###############################################################################
#
# Extension #242
# OML_sync_control commands
#
###############################################################################

GetSyncValuesOML(hdc, ust, msc, sbc)
	return		BOOL
	param		hdc		HDC in value
	param		ust		INT64 out array [1]
	param		msc		INT64 out array [1]
	param		sbc		INT64 out array [1]
	category	OML_sync_control

GetMscRateOML(hdc, numerator, denominator)
	return		BOOL
	param		hdc		HDC in value
	param		numerator	INT32 out array [1]
	param		denominator	INT32 out array [1]
	category	OML_sync_control

SwapBuffersMscOML(hdc, target_msc, divisor, remainder)
	return		INT64
	param		hdc		HDC in value
	param		target_msc	INT64 in value
	param		divisor		INT64 in value
	param		remainder	INT64 in value
	category	OML_sync_control

SwapLayerBuffersMscOML(hdc, fuPlanes, target_msc, divisor, remainder)
	return		INT64
	param		hdc		HDC in value
	param		fuPlanes	int in value
	param		target_msc	INT64 in value
	param		divisor		INT64 in value
	param		remainder	INT64 in value
	category	OML_sync_control

WaitForMscOML(hdc, target_msc, divisor, remainder , ust, msc, sbc)
	return		BOOL
	param		hdc		HDC in value
	param		target_msc	INT64 in value
	param		divisor		INT64 in value
	param		remainder	INT64 in value
	param		ust		INT64 out array [1]
	param		msc		INT64 out array [1]
	param		sbc		INT64 out array [1]
	category	OML_sync_control

WaitForSbcOML(hdc, target_sbc, ust, msc, sbc)
	return		BOOL
	param		hdc		HDC in value
	param		target_sbc	INT64 in value
	param		ust		INT64 out array [1]
	param		msc		INT64 out array [1]
	param		sbc		INT64 out array [1]
	category	OML_sync_control

###############################################################################
#
# Extension #250
# I3D_digital_video_control commands
#
###############################################################################

GetDigitalVideoParametersI3D(hDC, iAttribute, piValue)
	return		BOOL
	param		hDC		HDC in value
	param		iAttribute	int in value
	param		piValue		int out array [COMPSIZE(iAttribute)]
	category	I3D_digital_video_control

SetDigitalVideoParametersI3D(hDC, iAttribute, piValue)
	return		BOOL
	param		hDC		HDC in value
	param		iAttribute	int in value
	param		piValue		int in array [COMPSIZE(iAttribute)]
	category	I3D_digital_video_control

###############################################################################
#
# Extension #251
# I3D_gamma commands
#
###############################################################################

GetGammaTableParametersI3D(hDC, iAttribute, piValue)
	return		BOOL
	param		hDC		HDC in value
	param		iAttribute	int in value
	param		piValue		int out array [COMPSIZE(iAttribute)]
	category	I3D_gamma

SetGammaTableParametersI3D(hDC, iAttribute, piValue)
	return		BOOL
	param		hDC		HDC in value
	param		iAttribute	int in value
	param		piValue		int in array [COMPSIZE(iAttribute)]
	category	I3D_gamma

GetGammaTableI3D(hDC, iEntries, puRed, puGreen, puBlue)
	return		BOOL
	param		hDC		HDC in value
	param		iEntries	int in value
	param		puRed		USHORT out array [iEntries]
	param		puGreen		USHORT out array [iEntries]
	param		puBlue		USHORT out array [iEntries]
	category	I3D_gamma

SetGammaTableI3D(hDC, iEntries, puRed, puGreen, puBlue)
	return		BOOL
	param		hDC		HDC in value
	param		iEntries	int in value
	param		puRed		USHORT in array [iEntries]
	param		puGreen		USHORT in array [iEntries]
	param		puBlue		USHORT in array [iEntries]
	category	I3D_gamma

###############################################################################
#
# Extension #252
# I3D_genlock commands
#
###############################################################################

EnableGenlockI3D(hDC)
	return		BOOL
	param		hDC		HDC in value
	category	I3D_genlock

DisableGenlockI3D(hDC)
	return		BOOL
	param		hDC		HDC in value
	category	I3D_genlock

IsEnabledGenlockI3D(hDC, pFlag)
	return		BOOL
	param		hDC		HDC in value
	param		pFlag		BOOL out reference
	category	I3D_genlock

GenlockSourceI3D(hDC,  uSource)
	return		BOOL
	param		hDC		HDC in value
	param		uSource		UINT in value
	category	I3D_genlock

GetGenlockSourceI3D(hDC, uSource)
	return		BOOL
	param		hDC		HDC in value
	param		uSource		UINT out reference
	category	I3D_genlock

GenlockSourceEdgeI3D(hDC,  uEdge)
	return		BOOL
	param		hDC		HDC in value
	param		uEdge		UINT in value
	category	I3D_genlock

GetGenlockSourceEdgeI3D(hDC, uEdge)
	return		BOOL
	param		hDC		HDC in value
	param		uEdge		UINT out reference
	category	I3D_genlock

GenlockSampleRateI3D(hDC,  uRate)
	return		BOOL
	param		hDC		HDC in value
	param		uRate		UINT in value
	category	I3D_genlock

GetGenlockSampleRateI3D(hDC, uRate)
	return		BOOL
	param		hDC		HDC in value
	param		uRate		UINT out reference
	category	I3D_genlock

GenlockSourceDelayI3D(hDC,  uDelay)
	return		BOOL
	param		hDC		HDC in value
	param		uDelay		UINT in value
	category	I3D_genlock

GetGenlockSourceDelayI3D(hDC, uDelay)
	return		BOOL
	param		hDC		HDC in value
	param		uDelay		UINT out reference
	category	I3D_genlock

QueryGenlockMaxSourceDelayI3D(hDC, uMaxLineDelay, uMaxPixelDelay)
	return		BOOL
	param		hDC		HDC in value
	param		uMaxLineDelay	UINT out reference
	param		uMaxPixelDelay	UINT out reference
	category	I3D_genlock

###############################################################################
#
# Extension #253
# I3D_image_buffer commands
#
###############################################################################

CreateImageBufferI3D(hDC, dwSize,  uFlags)
	return		LPVOID
	param		hDC		HDC in value
	param		dwSize		DWORD in value
	param		uFlags		UINT in value
	category	I3D_image_buffer

DestroyImageBufferI3D(hDC, pAddress)
	return		BOOL
	param		hDC		HDC in value
	param		pAddress	LPVOID in value
	category	I3D_image_buffer

AssociateImageBufferEventsI3D(hDC,  pEvent, pAddress, pSize,  count)
	return		BOOL
	param		hDC		HDC in value
	param		pEvent		HANDLE in array [count]
	param		pAddress	LPVOID in array [count]
	param		pSize		DWORD in array [count]
	param		count		UINT in value
	category	I3D_image_buffer

ReleaseImageBufferEventsI3D(hDC, pAddress,  count)
	return		BOOL
	param		hDC		HDC in value
	param		pAddress	LPVOID in array [count]
	param		count		UINT in value
	category	I3D_image_buffer

###############################################################################
#
# Extension #254
# I3D_swap_frame_lock commands
#
###############################################################################

EnableFrameLockI3D()
	return		BOOL
	category	I3D_swap_frame_lock

DisableFrameLockI3D()
	return		BOOL
	category	I3D_swap_frame_lock

IsEnabledFrameLockI3D(pFlag)
	return		BOOL
	param		pFlag		BOOL out reference
	category	I3D_swap_frame_lock

QueryFrameLockMasterI3D(pFlag)
	return		BOOL
	param		pFlag		BOOL out reference
	category	I3D_swap_frame_lock

###############################################################################
#
# Extension #255
# I3D_swap_frame_usage commands
#
###############################################################################

GetFrameUsageI3D(pUsage)
	return		BOOL
	param		pUsage		float out reference
	category	I3D_swap_frame_usage

BeginFrameTrackingI3D()
	return		BOOL
	category	I3D_swap_frame_usage

EndFrameTrackingI3D()
	return		BOOL
	category	I3D_swap_frame_usage

QueryFrameTrackingI3D(pFrameCount, pMissedFrames, pLastMissedUsage)
	return		BOOL
	param		pFrameCount	DWORD out reference
	param		pMissedFrames	DWORD out reference
	param		pLastMissedUsage    float out reference
	category	I3D_swap_frame_usage

###############################################################################
#
# Extension #278
# ATI_pixel_format_float commands
#
###############################################################################

# (none)
newcategory: ATI_pixel_format_float

###############################################################################
#
# Extension #281
# NV_float_buffer commands
#
###############################################################################

# (none)
newcategory: NV_float_buffer
