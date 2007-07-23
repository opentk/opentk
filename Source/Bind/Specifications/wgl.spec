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
dlflags:	notlistable handcode nop
wglflags:	client-handcode server-handcode non-dispatch
vectorequiv:	*
category:	wgl

CreateContext( hDc )
	return		HGLRC
	param		hDc		HDC in value
	category	wgl
	dlflags		notlistable handcode
	wglflags	non-dispatch

DeleteContext( oldContext )
	return		BOOL
	param		oldContext	HGLRC in value
	category	wgl
	dlflags		notlistable handcode
	wglflags	non-dispatch

GetCurrentContext( )
	return		HGLRC
	category	wgl
	dlflags		notlistable handcode
	wglflags	non-dispatch

MakeCurrent( hDc, newContext )
	return		BOOL
	param		hDc		HDC in value
	param		newContext	HGLRC in value
	category	wgl
	dlflags		notlistable
	wglflags	non-dispatch

CopyContext( hglrcSrc, hglrcDst, mask )
	return		BOOL
	param		hglrcSrc	HGLRC in value
	param		hglrcDst	HGLRC in value
	param		mask		UINT in value
	category	wgl
	dlflags		notlistable
	wglflags	non-dispatch

ChoosePixelFormat( hDc, pPfd )
	return		int
	param		hDc		HDC in value
	param		pPfd		PIXELFORMATDESCRIPTOR in reference
	category	wgl
	dlflags		notlistable
	wglflags	non-dispatch

DescribePixelFormat( hdc, ipfd, cjpfd, ppfd )
	return		int
	param		hdc		HDC in value
	param		ipfd		int in value
	param		cjpfd		UINT in value
	param		ppfd		PIXELFORMATDESCRIPTOR in reference

GetCurrentDC( )
	return		HDC
	category	wgl

GetDefaultProcAddress( lpszProc)
	return		PROC
	param		lpszProc	LPCSTR in value
	category	wgl

GetProcAddress( lpszProc)
	return		PROC
	param		lpszProc	LPCSTR in value
	category	wgl

GetPixelFormat( hdc )
	return		int
	param		hdc		HDC in value
	category	wgl

SetPixelFormat( hdc, ipfd, ppfd )
	return		BOOL
	param		hdc		HDC in value
	param		ipfd		int in value
	param		ppfd		PIXELFORMATDESCRIPTOR in reference
	category	wgl

SwapBuffers( hdc )
	return		BOOL
	param		hdc		HDC in value
	category	wgl

ShareLists( hrcSrvShare, hrcSrvSource)
	return		BOOL
	param		hrcSrvShare	HGLRC in value
	param		hrcSrvSource	HGLRC in value
	category	wgl

CreateLayerContext( hDc, level )
	return		HGLRC
	param		hDc		HDC in value
	param		level		int in value
	category	wgl

DescribeLayerPlane( hDc, pixelFormat, layerPlane, nBytes, plpd )
	return		BOOL
	param		hDc		HDC in value
	param		pixelFormat	int in value
	param		layerPlane	int in value
	param		nBytes		UINT in value
	param		plpd		LAYERPLANEDESCRIPTOR in reference
	category	wgl

SetLayerPaletteEntries( hdc, iLayerPlane, iStart, cEntries, pcr )
	return		int
	param		hdc		HDC in value
	param		iLayerPlane	int in value
	param		iStart		int in value
	param		cEntries	int in value
	param		pcr		COLORREF in reference
	category	wgl

GetLayerPaletteEntries( hdc, iLayerPlane, iStart, cEntries, pcr )
	return		int
	param		hdc		HDC in value
	param		iLayerPlane	int in value
	param		iStart		int in value
	param		cEntries	int in value
	param		pcr		COLORREF in reference
	category	wgl

RealizeLayerPalette( hdc, iLayerPlane, bRealize )
	return		BOOL
	param		hdc		HDC in value
	param		iLayerPlane	int in value
	param		bRealize	BOOL in value
	category	wgl

SwapLayerBuffers( hdc, fuFlags )
	return		BOOL
	param		hdc		HDC in value
	param		fuFlags		UINT in value
	category	wgl

UseFontBitmapsA( hDC, first, count, listBase )
	return		BOOL
	param		hDC		HDC in value
	param		first		DWORD in value
	param		count		DWORD in value
	param		listBase	DWORD in value
	category	wgl
	dlflags		notlistable

UseFontBitmapsW( hDC, first, count, listBase )
	return		BOOL
	param		hDC		HDC in value
	param		first		DWORD in value
	param		count		DWORD in value
	param		listBase	DWORD in value
	category	wgl
	dlflags		notlistable

