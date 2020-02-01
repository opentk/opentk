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
# Inc. The Original Code is Copyright (c) 1991-2005 Silicon Graphics, Inc.
# Copyright in any portions created by third parties is as indicated
# elsewhere herein. All Rights Reserved.
#
# Additional Notice Provisions: This software was created using the
# OpenGL(R) version 1.2.1 Sample Implementation published by SGI, but has
# not been independently verified as being compliant with the OpenGL(R)
# version 1.2.1 Specification.
#
# $Date: 2005/01/20 08:44:12 $ $Revision: 1.6 $
# $Header: /oss/CVS/cvs/projects/ogl-sample/main/doc/registry/specs/glxenumext.spec,v 1.6 2005/01/20 08:44:12 ljp Exp $

# List of GLX enumerants for glxext.h header
#
# This is NOT the master GLX enumerant registry (glxenum.spec).
#
# Unlike glxenum.spec, glxenumext.spec is
#   (1) In order by extension number.
#   (2) Includes only GLX extensions and GLX 1.3/1.4 core enumerants,
#	since it's assumed all <glx.h> today support at least GLX 1.2.
#   (3) Has no 'Extensions' section, since enums are always
#	conditionally protected against multiple definition
#	by glextenum.pl.
#   (4) Is processed by glextenum.pl, which has evolved
#	from enum.pl - should merge back into one script.

# glxext.h version number - this should be automatically updated,
#   when changing either enum or template spec files.

passthru:
passthru: /* Header file version number, required by OpenGL ABI for Linux */
passthru: /* glxext.h last updated 2005/01/20 */
passthru: /* Current version at http://oss.sgi.com/projects/ogl-sample/registry/ */
passthru: #define GLX_GLXEXT_VERSION 10

###############################################################################
#
# GLX 1.3 enums
#
###############################################################################

VERSION_1_3 enum:
	WINDOW_BIT					= 0x00000001	# DRAWABLE_TYPE value
	PIXMAP_BIT					= 0x00000002	#   "
	PBUFFER_BIT					= 0x00000004	#   "
	RGBA_BIT					= 0x00000001	# RENDER_TYPE value
	COLOR_INDEX_BIT					= 0x00000002	#   "
	PBUFFER_CLOBBER_MASK				= 0x08000000	# SelectEvent mask
	FRONT_LEFT_BUFFER_BIT				= 0x00000001	# PbufferClobberEvent mask
	FRONT_RIGHT_BUFFER_BIT				= 0x00000002	#   "
	BACK_LEFT_BUFFER_BIT				= 0x00000004	#   "
	BACK_RIGHT_BUFFER_BIT				= 0x00000008	#   "
	AUX_BUFFERS_BIT					= 0x00000010	#   "
	DEPTH_BUFFER_BIT				= 0x00000020	#   "
	STENCIL_BUFFER_BIT				= 0x00000040	#   "
	ACCUM_BUFFER_BIT				= 0x00000080	#   "
	CONFIG_CAVEAT					= 0x20		#   "
	X_VISUAL_TYPE					= 0x22		#   "
	TRANSPARENT_TYPE				= 0x23		#   "
	TRANSPARENT_INDEX_VALUE				= 0x24		#   "
	TRANSPARENT_RED_VALUE				= 0x25		#   "
	TRANSPARENT_GREEN_VALUE				= 0x26		#   "
	TRANSPARENT_BLUE_VALUE				= 0x27		#   "
	TRANSPARENT_ALPHA_VALUE				= 0x28		#   "
	DONT_CARE					= 0xFFFFFFFF	# may be specified for ChooseFBConfig attributes
	NONE						= 0x8000	# several attribute values
	SLOW_CONFIG					= 0x8001	# CONFIG_CAVEAT attribute value
	TRUE_COLOR					= 0x8002	# X_VISUAL_TYPE attribute value
	DIRECT_COLOR					= 0x8003	#   "
	PSEUDO_COLOR					= 0x8004	#   "
	STATIC_COLOR					= 0x8005	#   "
	GRAY_SCALE					= 0x8006	#   "
	STATIC_GRAY					= 0x8007	#   "
	TRANSPARENT_RGB					= 0x8008	# TRANSPARENT_TYPE attribute value
	TRANSPARENT_INDEX				= 0x8009	#   "
	VISUAL_ID					= 0x800B	# Context attribute
	SCREEN						= 0x800C	#   "
	NON_CONFORMANT_CONFIG				= 0x800D	# CONFIG_CAVEAT attribute value
	DRAWABLE_TYPE					= 0x8010	# FBConfig attribute
	RENDER_TYPE					= 0x8011	#   "
	X_RENDERABLE					= 0x8012	#   "
	FBCONFIG_ID					= 0x8013	#   "
	RGBA_TYPE					= 0x8014	# CreateNewContext render_type value
	COLOR_INDEX_TYPE				= 0x8015	#   "
	MAX_PBUFFER_WIDTH				= 0x8016	# FBConfig attribute
	MAX_PBUFFER_HEIGHT				= 0x8017	#   "
	MAX_PBUFFER_PIXELS				= 0x8018	#   "
	PRESERVED_CONTENTS				= 0x801B	# CreateGLXPbuffer attribute
	LARGEST_PBUFFER					= 0x801C	#   "
	WIDTH						= 0x801D	# Drawable attribute
	HEIGHT						= 0x801E	#   "
	EVENT_MASK					= 0x801F	#   "
	DAMAGED						= 0x8020	# PbufferClobber event_type value
	SAVED						= 0x8021	#   "
	WINDOW						= 0x8022	# PbufferClobber draw_type value
	PBUFFER						= 0x8023	#   "
	PBUFFER_HEIGHT					= 0x8040	# CreateGLXPbuffer attribute
	PBUFFER_WIDTH					= 0x8041	#   "

###############################################################################
#
# GLX 1.4 enums
#
###############################################################################

VERSION_1_4 enum:
	SAMPLE_BUFFERS					= 100000
	SAMPLES						= 100001

###############################################################################
#
# ARB GLX extensions, in ARB extension order
#
###############################################################################

###############################################################################

# No new tokens
# ARB Extension #2
ARB_get_proc_address enum:

###############################################################################

# ARB Extension #5
ARB_multisample enum:
	SAMPLE_BUFFERS_ARB				= 100000
	SAMPLES_ARB					= 100001

###############################################################################

# ARB Extension #39
ARB_fbconfig_float enum:
	RGBA_FLOAT_TYPE_ARB				= 0x20B9
	RGBA_FLOAT_BIT_ARB				= 0x00000004


###############################################################################
#
# non-ARB GLX extensions, in registry order
#
###############################################################################

###############################################################################

# Unfortunately, the SGIS_multisample specification and the IRIX
#  implementation are inconsistent; the spec assigns enums as follows.
#  ARB_multisample reuses these enums with ARB suffixes, and it can't
#  be changed at this point. So in the interest of supporting both
#  extensions on non-IRIX platforms, the SGIS enums will be defined
#  here as originally specified.

# Extension #25
SGIS_multisample enum:
	SAMPLE_BUFFERS_SGIS				= 100000
	SAMPLES_SGIS					= 100001

###############################################################################

# Extension #28
EXT_visual_info enum:
	X_VISUAL_TYPE_EXT				= 0x22
	TRANSPARENT_TYPE_EXT				= 0x23
	TRANSPARENT_INDEX_VALUE_EXT			= 0x24
	TRANSPARENT_RED_VALUE_EXT			= 0x25
	TRANSPARENT_GREEN_VALUE_EXT			= 0x26
	TRANSPARENT_BLUE_VALUE_EXT			= 0x27
	TRANSPARENT_ALPHA_VALUE_EXT			= 0x28
	NONE_EXT					= 0x8000
	TRUE_COLOR_EXT					= 0x8002
	DIRECT_COLOR_EXT				= 0x8003
	PSEUDO_COLOR_EXT				= 0x8004
	STATIC_COLOR_EXT				= 0x8005
	GRAY_SCALE_EXT					= 0x8006
	STATIC_GRAY_EXT					= 0x8007
	TRANSPARENT_RGB_EXT				= 0x8008
	TRANSPARENT_INDEX_EXT				= 0x8009

###############################################################################

# No new tokens
# Extension #40
SGI_swap_control enum:

###############################################################################

# No new tokens
# Extension #41
SGI_video_sync enum:

###############################################################################

# No new tokens
# Extension #42
SGI_make_current_read enum:

###############################################################################

# No new tokens
# Extension #43
SGIX_video_source enum:

###############################################################################

# Extension #44
EXT_visual_rating enum:
	VISUAL_CAVEAT_EXT				= 0x20
	SLOW_VISUAL_EXT					= 0x8001
	NON_CONFORMANT_VISUAL_EXT			= 0x800D
	use EXT_visual_info NONE_EXT

###############################################################################

# Extension #47
EXT_import_context enum:
	SHARE_CONTEXT_EXT				= 0x800A
	VISUAL_ID_EXT					= 0x800B
	SCREEN_EXT					= 0x800C

###############################################################################

# Extension #49
SGIX_fbconfig enum:
	WINDOW_BIT_SGIX					= 0x00000001
	PIXMAP_BIT_SGIX					= 0x00000002
	RGBA_BIT_SGIX					= 0x00000001
	COLOR_INDEX_BIT_SGIX				= 0x00000002
	DRAWABLE_TYPE_SGIX				= 0x8010
	RENDER_TYPE_SGIX				= 0x8011
	X_RENDERABLE_SGIX				= 0x8012
	FBCONFIG_ID_SGIX				= 0x8013
	RGBA_TYPE_SGIX					= 0x8014
	COLOR_INDEX_TYPE_SGIX				= 0x8015
	use EXT_import_context SCREEN_EXT

###############################################################################

# Extension #50
SGIX_pbuffer enum:
	PBUFFER_BIT_SGIX				= 0x00000004
	BUFFER_CLOBBER_MASK_SGIX			= 0x08000000
	FRONT_LEFT_BUFFER_BIT_SGIX			= 0x00000001
	FRONT_RIGHT_BUFFER_BIT_SGIX			= 0x00000002
	BACK_LEFT_BUFFER_BIT_SGIX			= 0x00000004
	BACK_RIGHT_BUFFER_BIT_SGIX			= 0x00000008
	AUX_BUFFERS_BIT_SGIX				= 0x00000010
	DEPTH_BUFFER_BIT_SGIX				= 0x00000020
	STENCIL_BUFFER_BIT_SGIX				= 0x00000040
	ACCUM_BUFFER_BIT_SGIX				= 0x00000080
	SAMPLE_BUFFERS_BIT_SGIX				= 0x00000100
	MAX_PBUFFER_WIDTH_SGIX				= 0x8016
	MAX_PBUFFER_HEIGHT_SGIX				= 0x8017
	MAX_PBUFFER_PIXELS_SGIX				= 0x8018
	OPTIMAL_PBUFFER_WIDTH_SGIX			= 0x8019
	OPTIMAL_PBUFFER_HEIGHT_SGIX			= 0x801A
	PRESERVED_CONTENTS_SGIX				= 0x801B
	LARGEST_PBUFFER_SGIX				= 0x801C
	WIDTH_SGIX					= 0x801D
	HEIGHT_SGIX					= 0x801E
	EVENT_MASK_SGIX					= 0x801F
	DAMAGED_SGIX					= 0x8020
	SAVED_SGIX					= 0x8021
	WINDOW_SGIX					= 0x8022
	PBUFFER_SGIX					= 0x8023

###############################################################################

# Extension #62
SGI_cushion enum:
#	 CUSHION_BUFFERS_SGI	 ????

###############################################################################

# Extension #83
SGIX_video_resize enum:
	SYNC_FRAME_SGIX					= 0x00000000
	SYNC_SWAP_SGIX					= 0x00000001

###############################################################################

# Extension #86
SGIX_dmbuffer enum:
	DIGITAL_MEDIA_PBUFFER_SGIX			= 0x8024

###############################################################################

# No new tokens
# Extension #91
SGIX_swap_group enum:

###############################################################################

# No new tokens
# Extension #92
SGIX_swap_barrier enum:

###############################################################################

# Extension #142
SGIS_blended_overlay enum:
	BLENDED_RGBA_SGIS				= 0x8025

###############################################################################

# Extension #143
SGIS_shared_multisample enum:
	MULTISAMPLE_SUB_RECT_WIDTH_SGIS			= 0x8026
	MULTISAMPLE_SUB_RECT_HEIGHT_SGIS		= 0x8027

###############################################################################

# No new tokens
# Extension #183
SUN_get_transparent_index enum:

###############################################################################

# Extension #207
3DFX_multisample enum:
	SAMPLE_BUFFERS_3DFX				= 0x8050
	SAMPLES_3DFX					= 0x8051

###############################################################################

# No new tokens
# Extension #215
MESA_copy_sub_buffer enum:

###############################################################################

# No new tokens
# Extension #216
MESA_pixmap_colormap enum:

###############################################################################

# No new tokens
# Extension #217
MESA_release_buffers enum:

###############################################################################

# Extension #218
MESA_set_3dfx_mode enum:
	3DFX_WINDOW_MODE_MESA				= 0x1
	3DFX_FULLSCREEN_MODE_MESA			= 0x2

###############################################################################

# Extension #234
SGIX_visual_select_group enum:
	VISUAL_SELECT_GROUP_SGIX			= 0x8028

###############################################################################

# Extension #237
OML_swap_method enum:
	SWAP_METHOD_OML					= 0x8060
	SWAP_EXCHANGE_OML				= 0x8061
	SWAP_COPY_OML					= 0x8062
	SWAP_UNDEFINED_OML				= 0x8063

###############################################################################

# No new tokens
# Extension #238
OML_sync_control enum:

###############################################################################

# Extension #281
NV_float_buffer enum:
	FLOAT_COMPONENTS_NV				= 0x20B0

###############################################################################

# Extension #307
SGIX_hyperpipe enum:
	HYPERPIPE_PIPE_NAME_LENGTH_SGIX			= 80
	BAD_HYPERPIPE_CONFIG_SGIX			= 91
	BAD_HYPERPIPE_SGIX				= 92
	HYPERPIPE_DISPLAY_PIPE_SGIX			= 0x00000001
	HYPERPIPE_RENDER_PIPE_SGIX			= 0x00000002
	PIPE_RECT_SGIX					= 0x00000001
	PIPE_RECT_LIMITS_SGIX				= 0x00000002
	HYPERPIPE_STEREO_SGIX				= 0x00000003
	HYPERPIPE_PIXEL_AVERAGE_SGIX			= 0x00000004
	HYPERPIPE_ID_SGIX				= 0x8030

###############################################################################

# No new tokens
# Extension #308
MESA_agp_offset enum:

