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
###############################################################################
Extensions define:
	EXT_object_space_tess				       = 1
	EXT_nurbs_tessellator				       = 1

###############################################################################
# Revision 1 (exists in GL enums)
#Boolean enum:
#	FALSE							= 0
#	TRUE							= 1

###############################################################################

# Revision 1
GluVersion enum:
	VERSION_1_1						= 1
	VERSION_1_2						= 1
	VERSION_1_3						= 1

###############################################################################

# Revision 1
GluStringName enum:
	VERSION							= 100800
	EXTENSIONS						= 100801

###############################################################################

# Revision 1
GluErrorCode enum:
	INVALID_ENUM						= 100900
	INVALID_VALUE						= 100901
	OUT_OF_MEMORY						= 100902
########INCOMPATIBLE_GL_VERSION					= 100903
	INVALID_OPERATION					= 100904

###############################################################################

Filter4TypeSGIS enum:
	LAGRANGIAN_SGI						= 100300
	MITCHELL_NETRAVALI_SGI					= 100301

###############################################################################

NurbsDisplay enum:
	use QuadricDrawStyle FILL
	OUTLINE_POLYGON						= 100240
	OUTLINE_PATCH						= 100241

NurbsCallback enum:
	NURBS_ERROR						= 100103
	ERROR							= 100103

	NURBS_BEGIN						= 100164
	NURBS_BEGIN_EXT						= 100164
	NURBS_VERTEX						= 100165
	NURBS_VERTEX_EXT					= 100165
	NURBS_NORMAL						= 100166
	NURBS_NORMAL_EXT					= 100166
	NURBS_COLOR						= 100167
	NURBS_COLOR_EXT						= 100167
	NURBS_TEXTURE_COORD					= 100168
	NURBS_TEXTURE_COORD_EXT					= 100168
	NURBS_END						= 100169
	NURBS_END_EXT						= 100169

	NURBS_BEGIN_DATA					= 100170
	NURBS_BEGIN_DATA_EXT					= 100170
	NURBS_VERTEX_DATA					= 100171
	NURBS_VERTEX_DATA_EXT					= 100171
	NURBS_NORMAL_DATA					= 100172
	NURBS_NORMAL_DATA_EXT					= 100172
	NURBS_COLOR_DATA					= 100173
	NURBS_COLOR_DATA_EXT					= 100173
	NURBS_TEXTURE_COORD_DATA				= 100174
	NURBS_TEXTURE_COORD_DATA_EXT				= 100174
	NURBS_END_DATA						= 100175
	NURBS_END_DATA_EXT					= 100175

NurbsError enum:
	NURBS_ERROR1						= 100251
	NURBS_ERROR2						= 100252
	NURBS_ERROR3						= 100253
	NURBS_ERROR4						= 100254
	NURBS_ERROR5						= 100255
	NURBS_ERROR6						= 100256
	NURBS_ERROR7						= 100257
	NURBS_ERROR8						= 100258
	NURBS_ERROR9						= 100259
	NURBS_ERROR10						= 100260
	NURBS_ERROR11						= 100261
	NURBS_ERROR12						= 100262
	NURBS_ERROR13						= 100263
	NURBS_ERROR14						= 100264
	NURBS_ERROR15						= 100265
	NURBS_ERROR16						= 100266
	NURBS_ERROR17						= 100267
	NURBS_ERROR18						= 100268
	NURBS_ERROR19						= 100269
	NURBS_ERROR20						= 100270
	NURBS_ERROR21						= 100271
	NURBS_ERROR22						= 100272
	NURBS_ERROR23						= 100273
	NURBS_ERROR24						= 100274
	NURBS_ERROR25						= 100275
	NURBS_ERROR26						= 100276
	NURBS_ERROR27						= 100277
	NURBS_ERROR28						= 100278
	NURBS_ERROR29						= 100279
	NURBS_ERROR30						= 100280
	NURBS_ERROR31						= 100281
	NURBS_ERROR32						= 100282
	NURBS_ERROR33						= 100283
	NURBS_ERROR34						= 100284
	NURBS_ERROR35						= 100285
	NURBS_ERROR36						= 100286
	NURBS_ERROR37						= 100287

NurbsProperty enum:
	AUTO_LOAD_MATRIX					= 100200
	CULLING							= 100201
	SAMPLING_TOLERANCE					= 100203
	DISPLAY_MODE						= 100204
	PARAMETRIC_TOLERANCE					= 100202
	SAMPLING_METHOD						= 100205
	U_STEP							= 100206
	V_STEP							= 100207

	NURBS_MODE						= 100160
	NURBS_MODE_EXT						= 100160
	NURBS_TESSELLATOR					= 100161
	NURBS_TESSELLATOR_EXT					= 100161
	NURBS_RENDERER						= 100162
	NURBS_RENDERER_EXT					= 100162

NurbsSampling enum:
	OBJECT_PARAMETRIC_ERROR					= 100208
	OBJECT_PARAMETRIC_ERROR_EXT				= 100208
	OBJECT_PATH_LENGTH					= 100209
	OBJECT_PATH_LENGTH_EXT					= 100209

	PATH_LENGTH						= 100215
	PARAMETRIC_ERROR					= 100216
	DOMAIN_DISTANCE						= 100217

NurbsTrim enum:
	MAP1_TRIM_2						= 100210
	MAP1_TRIM_3						= 100211

###############################################################################

QuadricDrawStyle enum:
	POINT							= 100010
	LINE							= 100011
	FILL							= 100012
	SILHOUETTE						= 100013

QuadricCallback enum:
	use NurbsCallback ERROR

QuadricNormal enum:
	SMOOTH							= 100000
	FLAT							= 100001
	NONE							= 100002

QuadricOrientation enum:
	OUTSIDE							= 100020
	INSIDE							= 100021

###############################################################################

TessCallback enum:
	TESS_BEGIN						= 100100
	BEGIN							= 100100
	TESS_VERTEX						= 100101
	VERTEX							= 100101
	TESS_END						= 100102
	END							= 100102
	TESS_ERROR						= 100103
	ERROR							= 100103
	TESS_EDGE_FLAG						= 100104
	EDGE_FLAG						= 100104
	TESS_COMBINE						= 100105
	TESS_BEGIN_DATA						= 100106
	TESS_VERTEX_DATA					= 100107
	TESS_END_DATA						= 100108
	TESS_ERROR_DATA						= 100109
	TESS_EDGE_FLAG_DATA					= 100110
	TESS_COMBINE_DATA					= 100111

TessContour enum:
	CW							= 100120
	CCW							= 100121
	INTERIOR						= 100122
	EXTERIOR						= 100123
	UNKNOWN							= 100124

TessProperty enum:
	TESS_WINDING_RULE					= 100140
	TESS_BOUNDARY_ONLY					= 100141
	TESS_TOLERANCE						= 100142

TessError enum:
	TESS_ERROR1						= 100151
	TESS_ERROR2						= 100152
	TESS_ERROR3						= 100153
	TESS_ERROR4						= 100154
	TESS_ERROR5						= 100155
	TESS_ERROR6						= 100156
	TESS_ERROR7						= 100157
	TESS_ERROR8						= 100158
	TESS_MISSING_BEGIN_POLYGON				= 100151
	TESS_MISSING_BEGIN_CONTOUR				= 100152
	TESS_MISSING_END_POLYGON				= 100153
	TESS_MISSING_END_CONTOUR				= 100154
	TESS_COORD_TOO_LARGE					= 100155
	TESS_NEED_COMBINE_CALLBACK				= 100156

TessWinding enum:
	TESS_WINDING_ODD					= 100130
	TESS_WINDING_NONZERO					= 100131
	TESS_WINDING_POSITIVE					= 100132
	TESS_WINDING_NEGATIVE					= 100133
	TESS_WINDING_ABS_GEQ_TWO				= 100134

###############################################################################

