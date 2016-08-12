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
# $Date: 2005/01/20 08:44:12 $ $Revision: 1.8 $
# $Header: /oss/CVS/cvs/projects/ogl-sample/main/doc/registry/specs/wglenumext.spec,v 1.8 2005/01/20 08:44:12 ljp Exp $

# List of WGL enumerants for wglext.h header
#
# This is NOT the master WGL enumerant registry. Microsoft used
#   to maintain that, but given their limited interest in OpenGL,
#   SGI now maintains the registry in wglenum.spec.
#
# Unlike wglenum.spec, wglenumext.spec is
#   (1) In order by extension number
#   (2) Includes only WGL extensions.
#   (3) Has no 'Extensions' section, since enums are always
#	conditionally protected against multiple definition
#	by glextenum.pl.
#   (4) Is processed by glextenum.pl, which has evolved
#	from enum.pl - should merge back into one script.

# wglext.h version number - this should be automatically updated,
#   when changing either enum or template spec files.

passthru:
passthru: /* Header file version number */
passthru: /* wglext.h last updated 2005/01/07 */
passthru: /* Current version at http://oss.sgi.com/projects/ogl-sample/registry/ */
passthru: #define WGL_WGLEXT_VERSION 6

###############################################################################
#
# ARB WGL extensions, in ARB extension order
#
###############################################################################

###############################################################################

# ARB Extension #4
WGL_ARB_buffer_region enum:
	WGL_FRONT_COLOR_BUFFER_BIT_ARB			= 0x00000001
	WGL_BACK_COLOR_BUFFER_BIT_ARB			= 0x00000002
	WGL_DEPTH_BUFFER_BIT_ARB			= 0x00000004
	WGL_STENCIL_BUFFER_BIT_ARB			= 0x00000008

###############################################################################

# ARB Extension #5
WGL_ARB_multisample enum:
	WGL_SAMPLE_BUFFERS_ARB				= 0x2041
	WGL_SAMPLES_ARB					= 0x2042

###############################################################################

# No new tokens
# ARB Extension #8
WGL_ARB_extensions_string enum:

###############################################################################

# ARB Extension #9
WGL_ARB_pixel_format enum:
	WGL_NUMBER_PIXEL_FORMATS_ARB			= 0x2000
	WGL_DRAW_TO_WINDOW_ARB				= 0x2001
	WGL_DRAW_TO_BITMAP_ARB				= 0x2002
	WGL_ACCELERATION_ARB				= 0x2003
	WGL_NEED_PALETTE_ARB				= 0x2004
	WGL_NEED_SYSTEM_PALETTE_ARB			= 0x2005
	WGL_SWAP_LAYER_BUFFERS_ARB			= 0x2006
	WGL_SWAP_METHOD_ARB				= 0x2007
	WGL_NUMBER_OVERLAYS_ARB				= 0x2008
	WGL_NUMBER_UNDERLAYS_ARB			= 0x2009
	WGL_TRANSPARENT_ARB				= 0x200A
	WGL_TRANSPARENT_RED_VALUE_ARB			= 0x2037
	WGL_TRANSPARENT_GREEN_VALUE_ARB			= 0x2038
	WGL_TRANSPARENT_BLUE_VALUE_ARB			= 0x2039
	WGL_TRANSPARENT_ALPHA_VALUE_ARB			= 0x203A
	WGL_TRANSPARENT_INDEX_VALUE_ARB			= 0x203B
	WGL_SHARE_DEPTH_ARB				= 0x200C
	WGL_SHARE_STENCIL_ARB				= 0x200D
	WGL_SHARE_ACCUM_ARB				= 0x200E
	WGL_SUPPORT_GDI_ARB				= 0x200F
	WGL_SUPPORT_OPENGL_ARB				= 0x2010
	WGL_DOUBLE_BUFFER_ARB				= 0x2011
	WGL_STEREO_ARB					= 0x2012
	WGL_PIXEL_TYPE_ARB				= 0x2013
	WGL_COLOR_BITS_ARB				= 0x2014
	WGL_RED_BITS_ARB				= 0x2015
	WGL_RED_SHIFT_ARB				= 0x2016
	WGL_GREEN_BITS_ARB				= 0x2017
	WGL_GREEN_SHIFT_ARB				= 0x2018
	WGL_BLUE_BITS_ARB				= 0x2019
	WGL_BLUE_SHIFT_ARB				= 0x201A
	WGL_ALPHA_BITS_ARB				= 0x201B
	WGL_ALPHA_SHIFT_ARB				= 0x201C
	WGL_ACCUM_BITS_ARB				= 0x201D
	WGL_ACCUM_RED_BITS_ARB				= 0x201E
	WGL_ACCUM_GREEN_BITS_ARB			= 0x201F
	WGL_ACCUM_BLUE_BITS_ARB				= 0x2020
	WGL_ACCUM_ALPHA_BITS_ARB			= 0x2021
	WGL_DEPTH_BITS_ARB				= 0x2022
	WGL_STENCIL_BITS_ARB				= 0x2023
	WGL_AUX_BUFFERS_ARB				= 0x2024
	WGL_NO_ACCELERATION_ARB				= 0x2025
	WGL_GENERIC_ACCELERATION_ARB			= 0x2026
	WGL_FULL_ACCELERATION_ARB			= 0x2027
	WGL_SWAP_EXCHANGE_ARB				= 0x2028
	WGL_SWAP_COPY_ARB				= 0x2029
	WGL_SWAP_UNDEFINED_ARB				= 0x202A
	WGL_TYPE_RGBA_ARB				= 0x202B
	WGL_TYPE_COLORINDEX_ARB				= 0x202C

###############################################################################

# ARB Extension #10
WGL_ARB_make_current_read enum:
	ERROR_INVALID_PIXEL_TYPE_ARB			= 0x2043
	ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB		= 0x2054

###############################################################################

# ARB Extension #11
WGL_ARB_pbuffer enum:
	WGL_DRAW_TO_PBUFFER_ARB				= 0x202D
	WGL_MAX_PBUFFER_PIXELS_ARB			= 0x202E
	WGL_MAX_PBUFFER_WIDTH_ARB			= 0x202F
	WGL_MAX_PBUFFER_HEIGHT_ARB			= 0x2030
	WGL_PBUFFER_LARGEST_ARB				= 0x2033
	WGL_PBUFFER_WIDTH_ARB				= 0x2034
	WGL_PBUFFER_HEIGHT_ARB				= 0x2035
	WGL_PBUFFER_LOST_ARB				= 0x2036
	WGL_TRANSPARENT_RED_VALUE_ARB			= 0x2037
	WGL_TRANSPARENT_GREEN_VALUE_ARB			= 0x2038
	WGL_TRANSPARENT_BLUE_VALUE_ARB			= 0x2039
	WGL_TRANSPARENT_ALPHA_VALUE_ARB			= 0x203A
	WGL_TRANSPARENT_INDEX_VALUE_ARB			= 0x203B

###############################################################################

# ARB Extension #20
WGL_ARB_render_texture enum:
	WGL_BIND_TO_TEXTURE_RGB_ARB			= 0x2070
	WGL_BIND_TO_TEXTURE_RGBA_ARB			= 0x2071
	WGL_TEXTURE_FORMAT_ARB				= 0x2072
	WGL_TEXTURE_TARGET_ARB				= 0x2073
	WGL_MIPMAP_TEXTURE_ARB				= 0x2074
	WGL_TEXTURE_RGB_ARB				= 0x2075
	WGL_TEXTURE_RGBA_ARB				= 0x2076
	WGL_NO_TEXTURE_ARB				= 0x2077
	WGL_TEXTURE_CUBE_MAP_ARB			= 0x2078
	WGL_TEXTURE_1D_ARB				= 0x2079
	WGL_TEXTURE_2D_ARB				= 0x207A
	WGL_MIPMAP_LEVEL_ARB				= 0x207B
	WGL_CUBE_MAP_FACE_ARB				= 0x207C
	WGL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB		= 0x207D
	WGL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB		= 0x207E
	WGL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB		= 0x207F
	WGL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB		= 0x2080
	WGL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB		= 0x2081
	WGL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB		= 0x2082
	WGL_FRONT_LEFT_ARB				= 0x2083
	WGL_FRONT_RIGHT_ARB				= 0x2084
	WGL_BACK_LEFT_ARB				= 0x2085
	WGL_BACK_RIGHT_ARB				= 0x2086
	WGL_AUX0_ARB					= 0x2087
	WGL_AUX1_ARB					= 0x2088
	WGL_AUX2_ARB					= 0x2089
	WGL_AUX3_ARB					= 0x208A
	WGL_AUX4_ARB					= 0x208B
	WGL_AUX5_ARB					= 0x208C
	WGL_AUX6_ARB					= 0x208D
	WGL_AUX7_ARB					= 0x208E
	WGL_AUX8_ARB					= 0x208F
	WGL_AUX9_ARB					= 0x2090

###############################################################################

# ARB Extension #39
WGL_ARB_pixel_format_float enum:
	WGL_TYPE_RGBA_FLOAT_ARB				= 0x21A0


###############################################################################
#
# non-ARB extensions follow, in registry order
#
###############################################################################

###############################################################################

# Extension #169
WGL_EXT_make_current_read enum:
	ERROR_INVALID_PIXEL_TYPE_EXT			= 0x2043

###############################################################################

# Extension #170
WGL_EXT_pixel_format enum:
	WGL_NUMBER_PIXEL_FORMATS_EXT			= 0x2000
	WGL_DRAW_TO_WINDOW_EXT				= 0x2001
	WGL_DRAW_TO_BITMAP_EXT				= 0x2002
	WGL_ACCELERATION_EXT				= 0x2003
	WGL_NEED_PALETTE_EXT				= 0x2004
	WGL_NEED_SYSTEM_PALETTE_EXT			= 0x2005
	WGL_SWAP_LAYER_BUFFERS_EXT			= 0x2006
	WGL_SWAP_METHOD_EXT				= 0x2007
	WGL_NUMBER_OVERLAYS_EXT				= 0x2008
	WGL_NUMBER_UNDERLAYS_EXT			= 0x2009
	WGL_TRANSPARENT_EXT				= 0x200A
	WGL_TRANSPARENT_VALUE_EXT			= 0x200B
	WGL_SHARE_DEPTH_EXT				= 0x200C
	WGL_SHARE_STENCIL_EXT				= 0x200D
	WGL_SHARE_ACCUM_EXT				= 0x200E
	WGL_SUPPORT_GDI_EXT				= 0x200F
	WGL_SUPPORT_OPENGL_EXT				= 0x2010
	WGL_DOUBLE_BUFFER_EXT				= 0x2011
	WGL_STEREO_EXT					= 0x2012
	WGL_PIXEL_TYPE_EXT				= 0x2013
	WGL_COLOR_BITS_EXT				= 0x2014
	WGL_RED_BITS_EXT				= 0x2015
	WGL_RED_SHIFT_EXT				= 0x2016
	WGL_GREEN_BITS_EXT				= 0x2017
	WGL_GREEN_SHIFT_EXT				= 0x2018
	WGL_BLUE_BITS_EXT				= 0x2019
	WGL_BLUE_SHIFT_EXT				= 0x201A
	WGL_ALPHA_BITS_EXT				= 0x201B
	WGL_ALPHA_SHIFT_EXT				= 0x201C
	WGL_ACCUM_BITS_EXT				= 0x201D
	WGL_ACCUM_RED_BITS_EXT				= 0x201E
	WGL_ACCUM_GREEN_BITS_EXT			= 0x201F
	WGL_ACCUM_BLUE_BITS_EXT				= 0x2020
	WGL_ACCUM_ALPHA_BITS_EXT			= 0x2021
	WGL_DEPTH_BITS_EXT				= 0x2022
	WGL_STENCIL_BITS_EXT				= 0x2023
	WGL_AUX_BUFFERS_EXT				= 0x2024
	WGL_NO_ACCELERATION_EXT				= 0x2025
	WGL_GENERIC_ACCELERATION_EXT			= 0x2026
	WGL_FULL_ACCELERATION_EXT			= 0x2027
	WGL_SWAP_EXCHANGE_EXT				= 0x2028
	WGL_SWAP_COPY_EXT				= 0x2029
	WGL_SWAP_UNDEFINED_EXT				= 0x202A
	WGL_TYPE_RGBA_EXT				= 0x202B
	WGL_TYPE_COLORINDEX_EXT				= 0x202C

###############################################################################

# Extension #171
WGL_EXT_pbuffer enum:
	WGL_DRAW_TO_PBUFFER_EXT				= 0x202D
	WGL_MAX_PBUFFER_PIXELS_EXT			= 0x202E
	WGL_MAX_PBUFFER_WIDTH_EXT			= 0x202F
	WGL_MAX_PBUFFER_HEIGHT_EXT			= 0x2030
	WGL_OPTIMAL_PBUFFER_WIDTH_EXT			= 0x2031
	WGL_OPTIMAL_PBUFFER_HEIGHT_EXT			= 0x2032
	WGL_PBUFFER_LARGEST_EXT				= 0x2033
	WGL_PBUFFER_WIDTH_EXT				= 0x2034
	WGL_PBUFFER_HEIGHT_EXT				= 0x2035

###############################################################################

# Extension #177
WGL_EXT_depth_float enum:
	WGL_DEPTH_FLOAT_EXT				= 0x2040

###############################################################################

# Extension #207
WGL_3DFX_multisample enum:
	WGL_SAMPLE_BUFFERS_3DFX				= 0x2060
	WGL_SAMPLES_3DFX				= 0x2061

###############################################################################

# Extension #209
WGL_EXT_multisample enum:
	WGL_SAMPLE_BUFFERS_EXT				= 0x2041
	WGL_SAMPLES_EXT					= 0x2042

###############################################################################

# Extension #250
WGL_I3D_digital_video_control enum:
	WGL_DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D	= 0x2050
	WGL_DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D	= 0x2051
	WGL_DIGITAL_VIDEO_CURSOR_INCLUDED_I3D		= 0x2052
	WGL_DIGITAL_VIDEO_GAMMA_CORRECTED_I3D		= 0x2053

###############################################################################

# Extension #251
WGL_I3D_gamma enum:
	WGL_GAMMA_TABLE_SIZE_I3D			= 0x204E
	WGL_GAMMA_EXCLUDE_DESKTOP_I3D			= 0x204F

###############################################################################

# Extension #252
WGL_I3D_genlock enum:
	WGL_GENLOCK_SOURCE_MULTIVIEW_I3D		= 0x2044
	WGL_GENLOCK_SOURCE_EXTENAL_SYNC_I3D		= 0x2045
	WGL_GENLOCK_SOURCE_EXTENAL_FIELD_I3D		= 0x2046
	WGL_GENLOCK_SOURCE_EXTENAL_TTL_I3D		= 0x2047
	WGL_GENLOCK_SOURCE_DIGITAL_SYNC_I3D		= 0x2048
	WGL_GENLOCK_SOURCE_DIGITAL_FIELD_I3D		= 0x2049
	WGL_GENLOCK_SOURCE_EDGE_FALLING_I3D		= 0x204A
	WGL_GENLOCK_SOURCE_EDGE_RISING_I3D		= 0x204B
	WGL_GENLOCK_SOURCE_EDGE_BOTH_I3D		= 0x204C

###############################################################################

# Extension #253
WGL_I3D_image_buffer enum:
	WGL_IMAGE_BUFFER_MIN_ACCESS_I3D			= 0x00000001
	WGL_IMAGE_BUFFER_LOCK_I3D			= 0x00000002

###############################################################################

# No new tokens
# Extension #254
WGL_I3D_swap_frame_lock enum:

###############################################################################

# Extension #263
WGL_NV_render_depth_texture enum:
	WGL_BIND_TO_TEXTURE_DEPTH_NV			= 0x20A3
	WGL_BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV		= 0x20A4
	WGL_DEPTH_TEXTURE_FORMAT_NV			= 0x20A5
	WGL_TEXTURE_DEPTH_COMPONENT_NV			= 0x20A6
	WGL_DEPTH_COMPONENT_NV				= 0x20A7

###############################################################################

# Extension #264
WGL_NV_render_texture_rectangle enum:
	WGL_BIND_TO_TEXTURE_RECTANGLE_RGB_NV		= 0x20A0
	WGL_BIND_TO_TEXTURE_RECTANGLE_RGBA_NV		= 0x20A1
	WGL_TEXTURE_RECTANGLE_NV			= 0x20A2

###############################################################################

# Extension #278
WGL_ATI_pixel_format_float enum:
	WGL_TYPE_RGBA_FLOAT_ATI				= 0x21A0

###############################################################################

# Extension #281
WGL_NV_float_buffer enum:
	WGL_FLOAT_COMPONENTS_NV				= 0x20B0
	WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV	= 0x20B1
	WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV	= 0x20B2
	WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV	= 0x20B3
	WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV	= 0x20B4
	WGL_TEXTURE_FLOAT_R_NV				= 0x20B5
	WGL_TEXTURE_FLOAT_RG_NV				= 0x20B6
	WGL_TEXTURE_FLOAT_RGB_NV			= 0x20B7
	WGL_TEXTURE_FLOAT_RGBA_NV			= 0x20B8
