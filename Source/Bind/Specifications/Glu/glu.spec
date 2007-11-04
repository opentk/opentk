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
###############################################################################
#
# Edited by StApostol. Revision 1
#
###############################################################################
param: retval retained
version: 1.0

BeginCurve(nurb)
	return		void
	param		nurb		NurbsObj in value

BeginPolygon(tess)
	return		void
	param		tess		TesselatorObj in value

BeginSurface(nurb)
	return		void
	param		nurb		NurbsObj in value

BeginTrim(nurb)
	return		void
	param		nurb		NurbsObj in value

Build1DMipmapLevels(target, internalFormat, width, format, type, level, base, max, data);
	return		Int32
	param		target		TextureTarget in value
	param		internalFormat	Int32 in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		level		Int32 in value
	param		base		Int32 in value
	param		max		Int32 in value
	param		data		void in reference

Build1DMipmaps(target, internalFormat, width, format, type, data);
	return		Int32
	param		target		TextureTarget in value
	param		internalFormat	Int32 in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		data		void in reference

Build2DMipmapLevels(target, internalFormat, width, height, format, type, level, base, max, data);
	return		Int32
	param		target		TextureTarget in value
	param		internalFormat	Int32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		level		Int32 in value
	param		base		Int32 in value
	param		max		Int32 in value
	param		data		void in reference

Build2DMipmaps(target, internalFormat, width, height, format, type, data);
	return		Int32
	param		target		TextureTarget in value
	param		internalFormat	Int32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		data		void in reference

Build3DMipmapLevels(target, internalFormat, width, height, depth, format, type, level, base, max, data);
	return		Int32
	param		target		TextureTarget in value
	param		internalFormat	Int32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		level		Int32 in value
	param		base		Int32 in value
	param		max		Int32 in value
	param		data		void in reference

Build3DMipmaps(target, internalFormat, width, height, depth, format, type, data);
	return		Int32
	param		target		TextureTarget in value
	param		internalFormat	Int32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		data		void in reference

CheckExtension(extName, extString)
	return		Boolean
	param		extName		UInt8 in array [COMPSIZE()]
	param		extString	UInt8 in array [COMPSIZE()]

Cylinder(quad, base, top, height, slices, stacks);
	return		void
	param		quad		QuadricObj in value
	param		base		Float64 in value
	param		top		Float64 in value
	param		height		Float64 in value
	param		slices		Int32 in value
	param		stacks		Int32 in value

DeleteNurbsRenderer(nurb)
	return		void
	param		nurb		NurbsObj in value

DeleteQuadric(quad)
	return		void
	param		quad		QuadricObj in value

DeleteTess(tess)
	return		void
	param		tess		TesselatorObj in value

Disk(quad, inner, outer, slices, loops)
	return		void
	param		quad		QuadricObj in value
	param		inner		Float64 in value
	param		outer		Float64 in value
	param		slices		Int32 in value
	param		loops		Int32 in value

EndCurve(nurb)
	return		void
	param		nurb		NurbsObj in value

EndPolygon(tess)
	return		void
	param		tess		TesselatorObj in value

EndSurface(nurb)
	return		void
	param		nurb		NurbsObj in value

EndTrim(nurb)
	return		void
	param		nurb		NurbsObj in value

ErrorString(error)
	return		String
# Revision 1
	param		error		GluErrorCode in value	# ErrorCode (clashes with OpenGL enum)

GetString(name)
	return		String
	param		name		GluStringName in value

GetNurbsProperty(nurb, property, data)
	return		void
	param		nurb		NurbsObj in value
	param		property	NurbsProperty in value
	param		data		Float32Pointer out value

GetTessProperty(tess, which, data)
	return		void
	param		tess		TesselatorObj in value
	param		which		TessProperty in value
	param		data		Float64Pointer out value

LoadSamplingMatrices(nurb, model, perspective, view)
	return		void
	param		nurb		NurbsObj in value
	param		model		Float32 in array [16]
	param		perspective	Float32 in array [16]
	param		view		Int32 in array [4]

LookAt(eyeX, eyeY, eyeZ, centerX, centerY, centerZ, upX, upY, upZ)
	return		void
	param		eyeX		Float64 in value
	param		eyeY		Float64 in value
	param		eyeZ		Float64 in value
	param		centerX		Float64 in value
	param		centerY		Float64 in value
	param		centerZ		Float64 in value
	param		upX		Float64 in value
	param		upY		Float64 in value
	param		upZ		Float64 in value

NewNurbsRenderer()
	return		NurbsObj

NewQuadric()
	return		QuadricObj

NewTess()
	return		TesselatorObj

NextContour(tess, type)
	return		void
	param		tess		TesselatorObj in value
	param		type		TessContour in value

NurbsCallback(nurb, which, CallBackFunc)
	return		void
	param		nurb		NurbsObj in value
	param		which		NurbsCallback in value
	param		CallBackFunc	FunctionPointer in value

NurbsCallbackData(nurb, userData)
	return		void
	param		nurb		NurbsObj in value
	param		userData	VoidPointer in value

NurbsCallbackDataEXT(nurb, userData)
	return		void
	param		nurb		NurbsObj in value
	param		userData	VoidPointer in value

NurbsCurve(nurb, knotCount, knots, stride, control, order, type)
	return		void
	param		nurb		NurbsObj in value
	param		knotCount	Int32 in value
	param		knots		Float32 out reference
	param		stride		Int32 in value
	param		control		Float32 out reference
	param		order		Int32 in value
	param		type		MapTarget in value

NurbsProperty(nurb, property, value)
	return		void
	param		nurb		NurbsObj in value
	param		property	NurbsProperty in value
	param		value		Float32 in value

NurbsSurface(nurb, sKnotCount, sKnots, tKnotCount, tKnots, sStride, tStride, control, sOrder, tOrder, type)
	return		void
	param		nurb		NurbsObj in value
	param		sKnotCount	Int32 in value
	param		sKnots		Float32Pointer in value
	param		tKnotCount	Int32 in value
	param		tKnots		Float32Pointer in value
	param		sStride		Int32 in value
	param		tStride		Int32 in value
	param		control		Float32Pointer in value
	param		sOrder		Int32 in value
	param		tOrder		Int32 in value
	param		type		MapTarget in value

Ortho2D(left, right, bottom, top)
	return		void
	param		left		Float64 in value
	param		right		Float64 in value
	param		bottom		Float64 in value
	param		top		Float64 in value

PartialDisk(quad, inner, outer, slices, loops, start, sweep)
	return		void
	param		quad		QuadricObj in value
	param		inner		Float64 in value
	param		outer		Float64 in value
	param		slices		Int32 in value
	param		loops		Int32 in value
	param		start		Float64 in value
	param		sweep		Float64 in value

Perspective(fovy, aspect, zNear, zFar)
	return		void
	param		fovy		Float64 in value
	param		aspect		Float64 in value
	param		zNear		Float64 in value
	param		zFar		Float64 in value

PickMatrix(x, y, delX, delY, viewport)
	return		void
	param		x		Float64 in value
	param		y		Float64 in value
	param		delX		Float64 in value
	param		delY		Float64 in value
	param		viewport	Int32 out array [4]

Project(objX, objY, objZ, model, proj, view, winX, winY, winZ)
	return		Int32
	param		objX		Float64 in value
	param		objY		Float64 in value
	param		objZ		Float64 in value
	param		model		Float64 in array [16]
	param		proj		Float64 in array [16]
	param		view		Int32 in array [4]
	param		winX		Float64Pointer in value
	param		winY		Float64Pointer in value
	param		winZ		Float64Pointer in value

PwlCurve(nurb, count, data, stride, type)
	return		void
	param		nurb		NurbsObj in value
	param		count		Int32 in value
	param		data		Float32Pointer in value
	param		stride		Int32 in value
	param		type		NurbsTrim in value

QuadricCallback(quad, which, CallBackFunc)
	return		void
	param		quad		QuadricObj in value
	param		which		QuadricCallback in value
	param		CallBackFunc	FunctionPointer in value

QuadricDrawStyle(quad, draw)
	return		void
	param		quad		QuadricObj in value
	param		draw		QuadricDrawStyle in value

QuadricNormals(quad, normal)
	return		void
	param		quad		QuadricObj in value
	param		normal		QuadricNormal in value

QuadricOrientation(quad, orientation)
	return		void
	param		quad		QuadricObj in value
	param		orientation	QuadricOrientation in value

# Revision 1
QuadricTexture(quad, texture)
	return		void
	param		quad		QuadricObj in value
	param		texture		bool in value # Boolean in value

ScaleImage(format, wIn, hIn, typeIn, dataIn, wOut, hOut, typeOut, dataOut)
	return		Int32
	param		format		PixelFormat in value
	param		wIn		SizeI in value
	param		hIn		SizeI in value
	param		typeIn		PixelType in value
	param		dataIn		void in reference
	param		wOut		SizeI in value
	param		hOut		SizeI in value
	param		typeOut		PixelType in value
	param		dataOut		VoidPointer out value

Sphere(quad, radius, slices, stacks)
	return		void
	param		quad		QuadricObj in value
	param		radius		Float64 in value
	param		slices		Int32 in value
	param		stacks		Int32 in value

TessBeginContour(tess)
	return		void
	param		tess		TesselatorObj in value

TessBeginPolygon(tess, data)
	return		void
	param		tess		TesselatorObj in value
	param		data		VoidPointer in value

TessCallback(tess, which, CallBackFunc)
	return		void
	param		tess		TesselatorObj in value
	param		which		TessCallback in value
	param		CallBackFunc	FunctionPointer in value

TessEndContour(tess)
	return		void
	param		tess		TesselatorObj in value

TessEndPolygon(tess)
	return		void
	param		tess		TesselatorObj in value

TessNormal(tess, valueX, valueY, valueZ)
	return		void
	param		tess		TesselatorObj in value
	param		valueX		Float64 in value
	param		valueY		Float64 in value
	param		valueZ		Float64 in value

TessProperty(tess, which, data)
	return		void
	param		tess		TesselatorObj in value
	param		which		TessProperty in value
	param		data		Float64 in value

TessVertex(tess, location, data)
	return		void
	param		tess		TesselatorObj in value
	param		location	Float64 out array [3]
	param		data		VoidPointer in value

TexFilterFuncSGI(target, filtertype, parms, n, weights)
	return		Int32 out value
	param		target		TextureTarget in value
	param		filtertype	Filter4TypeSGIS in value
	param		parms		Float32 in array [2]
	param		n		Int32 in value
	param		weights		Float32Pointer out value

UnProject(winX, winY, winZ, model, proj, view, objX, objY, objZ)
	return		Int32
	param		winX		Float64 in value
	param		winY		Float64 in value
	param		winZ		Float64 in value
	param		model		Float64 in array [16]
	param		proj		Float64 in array [16]
	param		view		Int32 in array [4]
	param		objX		Float64Pointer in value
	param		objY		Float64Pointer in value
	param		objZ		Float64Pointer in value

UnProject4(winX, winY, winZ, clipW, model, proj, view, near, far, objX, objY, objZ, objW)
	return		Int32
	param		winX		Float64 in value
	param		winY		Float64 in value
	param		winZ		Float64 in value
	param		clipW		Float64 in value
	param		model		Float64 in array [16]
	param		proj		Float64 in array [16]
	param		view		Int32 in array [4]
	param		near		Float64 in value
	param		far		Float64 in value
	param		objX		Float64Pointer in value
	param		objY		Float64Pointer in value
	param		objZ		Float64Pointer in value
	param		objW		Float64Pointer in value
