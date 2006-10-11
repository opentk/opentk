# gl.spec file
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
# Inc. The Original Code is Copyright (c) 1991-2005 Silicon Graphics, Inc.
# Copyright in any portions created by third parties is as indicated
# elsewhere herein. All Rights Reserved.
#
# Additional Notice Provisions: This software was created using the
# OpenGL(R) version 1.2.1 Sample Implementation published by SGI, but has
# not been independently verified as being compliant with the OpenGL(R)
# version 1.2.1 Specification.

# @@ NOTE - need to distinguish extensions via some (new?) flag for glext.pl
# @@ NOTE - 'alias' commands are not yet used in SI generator scripts, but should be
# @@ NOTE - SI should support GLX protocol for at least these extensions:
#    AreTexturesResidentEXT BindTextureEXT DeleteTexturesEXT GenTexturesEXT IsTextureEXT

required-props:
param:		retval retained
dlflags:	notlistable handcode
glxflags:	client-intercept client-handcode server-handcode EXT SGI ignore ARB
vectorequiv:	*
category:	display-list drawing drawing-control feedback framebuf misc modeling pixel-op pixel-rw state-req xform 1_1 VERSION_1_2 VERSION_1_3 VERSION_1_4 VERSION_1_5 VERSION_2_0 VERSION_2_1 ATI_element_array ATI_envmap_bumpmap ATI_fragment_shader ATI_pn_triangles ATI_vertex_array_object ATI_vertex_streams EXT_blend_color EXT_blend_minmax EXT_convolution EXT_copy_texture EXT_histogram EXT_polygon_offset EXT_subtexture EXT_texture3D EXT_texture_object EXT_vertex_array EXT_vertex_shader SGIS_detail_texture SGIS_multisample SGIS_pixel_texture ARB_point_parameters EXT_point_parameters SGIS_point_parameters SGIS_sharpen_texture SGIS_texture4D SGIS_texture_filter4 SGIX_async SGIX_flush_raster SGIX_fragment_lighting SGIX_framezoom SGIX_igloo_interface SGIX_instruments SGIX_list_priority SGIX_pixel_texture SGIX_polynomial_ffd SGIX_reference_plane SGIX_sprite SGIX_tag_sample_buffer SGI_color_table ARB_multitexture ARB_multisample ARB_texture_compression ARB_transpose_matrix ARB_vertex_blend ARB_matrix_palette EXT_compiled_vertex_array EXT_cull_vertex EXT_index_func EXT_index_material EXT_draw_range_elements EXT_vertex_weighting INGR_blend_func_separate NV_evaluators NV_fence NV_occlusion_query NV_point_sprite NV_register_combiners NV_register_combiners2 NV_vertex_array_range NV_vertex_program NV_vertex_program1_1_dcc MESA_resize_buffers MESA_window_pos PGI_misc_hints EXT_fog_coord EXT_blend_func_separate EXT_color_subtable EXT_coordinate_frame EXT_light_texture EXT_multi_draw_arrays EXT_paletted_texture EXT_pixel_transform EXT_secondary_color EXT_texture_perturb_normal HP_image_transform IBM_multimode_draw_arrays IBM_vertex_array_lists INTEL_parallel_arrays SUNX_constant_data SUN_global_alpha SUN_mesh_array SUN_triangle_list SUN_vertex 3DFX_tbuffer EXT_multisample SGIS_fog_function SGIS_texture_color_mask ARB_window_pos EXT_stencil_two_side EXT_depth_bounds_test EXT_blend_equation_separate ARB_vertex_program ARB_fragment_program ARB_vertex_buffer_object ARB_occlusion_query ARB_shader_objects ARB_vertex_shader ARB_fragment_shader S3_s3tc ATI_draw_buffers ATI_texture_env_combine3 ATI_texture_float NV_float_buffer NV_fragment_program NV_half_float NV_pixel_data_range NV_primitive_restart NV_texture_expand_normal NV_texture_expand_normal NV_vertex_program2 APPLE_element_array APPLE_fence APPLE_vertex_array_object APPLE_vertex_array_range ATI_draw_buffers NV_fragment_program NV_half_float NV_pixel_data_range NV_primitive_restart ATI_map_object_buffer ATI_separate_stencil ATI_vertex_attrib_array_object ARB_draw_buffers ARB_texture_rectangle ARB_color_buffer_float EXT_framebuffer_object GREMEDY_string_marker EXT_stencil_clear_tag EXT_framebuffer_blit EXT_framebuffer_multisample MESAX_texture_stack EXT_timer_query EXT_gpu_program_parameters


# categories for extensions with no functions - need not be included now
#   ARB_texture_env_add ARB_texture_cube_map ARB_texture_border_clamp ARB_shading_language_100 ARB_texture_non_power_of_two ARB_point_sprite ARB_half_float_pixel ARB_texture_float ARB_pixel_buffer_object EXT_abgr EXT_texture SGI_color_matrix SGI_texture_color_table EXT_cmyka EXT_packed_pixels SGIS_texture_lod EXT_rescale_normal EXT_misc_attribute SGIS_generate_mipmap SGIX_clipmap SGIX_shadow SGIS_texture_edge_clamp SGIS_texture_border_clamp EXT_blend_subtract EXT_blend_logic_op SGIX_async_histogram SGIX_async_pixel SGIX_interlace SGIX_pixel_tiles SGIX_texture_select SGIX_texture_multi_buffer SGIX_texture_scale_bias SGIX_depth_texture SGIX_fog_offset HP_convolution_border_modes SGIX_texture_add_env PGI_vertex_hints EXT_clip_volume_hint SGIX_ir_instrument1 SGIX_calligraphic_fragment SGIX_texture_lod_bias SGIX_shadow_ambient EXT_index_texture EXT_index_array_formats SGIX_ycrcb IBM_rasterpos_clip HP_texture_lighting WIN_phong_shading WIN_specular_fog SGIX_blend_alpha_minmax EXT_bgra HP_occlusion_test EXT_pixel_transform_color_table EXT_shared_texture_palette EXT_separate_specular_color EXT_texture_env REND_screen_coordinates EXT_texture_env_combine APPLE_specular_vector APPLE_transform_hint SGIX_fog_scale INGR_color_clamp INGR_interlace_read EXT_stencil_wrap EXT_422_pixels NV_texgen_reflection SUN_convolution_border_modes SUN_slice_accum EXT_texture_env_add EXT_texture_lod_bias EXT_texture_filter_anisotropic NV_light_max_exponent NV_fog_distance NV_texgen_emboss NV_blend_square NV_texture_env_combine4 NV_packed_depth_stencil NV_texture_compression_vtc NV_texture_rectangle NV_texture_shader NV_texture_shader2 NV_vertex_array_range2 IBM_cull_vertex SGIX_subsample SGIX_ycrcba SGIX_ycrcb_subsample SGIX_depth_pass_instrument 3DFX_texture_compression_FXT1 3DFX_multisample SGIX_vertex_preclip SGIX_convolution_accuracy SGIX_resample SGIX_scalebias_hint SGIX_texture_coordinate_clamp EXT_shadow_funcs MESA_pack_invert MESA_ycbcr_texture

version:	1.0 1.1 1.2 1.3 1.4 1.5 2.0 2.1
glxsingle:	*
glxropcode:	*
glxvendorpriv:	*
glsflags:	capture-handcode client get gl-enum ignore matrix pixel-null pixel-pack pixel-unpack
glsopcode:	*
glsalias:	*
wglflags:	client-handcode server-handcode small-data batchable
extension:	future not_implemented soft WINSOFT NV10 NV20
alias:		*
offset:		*

###############################################################################
#
# GLX opcodes
#	glxsingle:		101-159     (1.0-1.2 core)
#				160	    (ARB_texture_compression)
#	glxropcode:		1-196	    (1.2 core; ropcode 140 unused?!)
#				197-213     (ARB_multitexture)
#				214-219     (ARB_texture_compression)
#				220-228     (ARB_vertex_blend)
#				229	    (ARB_multisample)
#				230	    (ARB_window_pos)
#				2048-2082   (SGI extensions)
#				4096-4123   (1.2 core and multivendor EXT)
#				4124-4142   (EXT extensions)
# XFree86 dispatch offsets:	0-645
#				578-641     NV_vertex_program
# GLS opcodes:			0x0030-0x0269
#
# New opcodes and offsets must be allocated by SGI in the master registry file;
#    a copy of this is in doc/registry/extensions/extensions.reserved, but only
#    the copy maintained by SGI is the official and current version.
#
###############################################################################

###############################################################################
#
# things to remember when adding an extension command
#
# - append new ARB and non-ARB extensions to the appropriate portion of
#   the spec file, in extension number order.
# - use tabs, not spaces
# - set glsflags to "ignore" until GLS is updated to support the new command
# - set glxflags to "ignore" until GLX is updated to support the new command
# - add new data types to typemaps/spec2wire.map
# - add extension name in alphabetical order to category list
# - add commands within an extension in spec order
# - use existing command entries as a model (where possible)
# - when reserving new glxropcodes, update
#	gfx/lib/opengl/doc/glspec/extensions.reserved to indicate this
#
###############################################################################

# New type declarations

passthru: #include <stddef.h>

passthru: #ifndef GL_VERSION_2_0
passthru: /* GL type for program/shader text */
passthru: typedef char GLchar;			/* native character */
passthru: #endif
passthru:
passthru: #ifndef GL_VERSION_1_5
passthru: /* GL types for handling large vertex buffer objects */
passthru: typedef ptrdiff_t GLintptr;
passthru: typedef ptrdiff_t GLsizeiptr;
passthru: #endif
passthru:
passthru: #ifndef GL_ARB_vertex_buffer_object
passthru: /* GL types for handling large vertex buffer objects */
passthru: typedef ptrdiff_t GLintptrARB;
passthru: typedef ptrdiff_t GLsizeiptrARB;
passthru: #endif
passthru:
passthru: #ifndef GL_ARB_shader_objects
passthru: /* GL types for handling shader object handles and program/shader text */
passthru: typedef char GLcharARB;		/* native character */
passthru: typedef unsigned int GLhandleARB;	/* shader object handle */
passthru: #endif
passthru:
passthru: /* GL types for "half" precision (s10e5) float data in host memory */
passthru: #ifndef GL_ARB_half_float_pixel
passthru: typedef unsigned short GLhalfARB;
passthru: #endif
passthru:
passthru: #ifndef GL_NV_half_float
passthru: typedef unsigned short GLhalfNV;
passthru: #endif
passthru:
passthru: #ifndef GLEXT_64_TYPES_DEFINED
passthru: /* This code block is duplicated in glext.h, so must be protected */
passthru: #define GLEXT_64_TYPES_DEFINED
passthru: /* Define int32_t, int64_t, and uint64_t types for UST/MSC */
passthru: /* (as used in the GLX_OML_sync_control extension). */
passthru: #if defined(__STDC_VERSION__) && __STDC_VERSION__ >= 199901L
passthru: #include <inttypes.h>
passthru: #elif defined(__sun__)
passthru: #include <inttypes.h>
passthru: #if defined(__STDC__)
passthru: #if defined(__arch64__)
passthru: typedef long int int64_t;
passthru: typedef unsigned long int uint64_t;
passthru: #else
passthru: typedef long long int int64_t;
passthru: typedef unsigned long long int uint64_t;
passthru: #endif /* __arch64__ */
passthru: #endif /* __STDC__ */
passthru: #elif defined( __VMS )
passthru: #include <inttypes.h>
passthru: #elif defined(__SCO__) || defined(__USLC__)
passthru: #include <stdint.h>
passthru: #elif defined(__UNIXOS2__) || defined(__SOL64__)
passthru: typedef long int int32_t;
passthru: typedef long long int int64_t;
passthru: typedef unsigned long long int uint64_t;
passthru: #elif defined(WIN32) && defined(__GNUC__)
passthru: #include <stdint.h>
passthru: #else
passthru: #include <inttypes.h>     /* Fallback option */
passthru: #endif
passthru: #endif
passthru:
passthru: #ifndef GL_EXT_timer_query
passthru: typedef int64_t GLint64EXT;
passthru: typedef uint64_t GLuint64EXT;
passthru: #endif
passthru:

###############################################################################
#
# display-list commands
#
###############################################################################

NewList(list, mode)
	return		void
	param		list		List in value
	param		mode		ListMode in value
	dlflags		notlistable
	category	display-list
	version		1.0
	glxsingle	101
	glsopcode	0x0030
	wglflags	batchable
	offset		0

EndList()
	return		void
	dlflags		notlistable
	category	display-list
	version		1.0
	glxsingle	102
	glsopcode	0x0031
	wglflags	batchable
	offset		1

CallList(list)
	return		void
	param		list		List in value
	category	display-list
	version		1.0
	glxropcode	1
	glsopcode	0x0032
	offset		2

CallLists(n, type, lists)
	return		void
	param		n		SizeI in value
	param		type		ListNameType in value
	param		lists		Void in array [COMPSIZE(n/type)]
	category	display-list
	glxflags	client-handcode server-handcode
	version		1.0
	glxropcode	2
	glsopcode	0x0033
	offset		3

DeleteLists(list, range)
	return		void
	param		list		List in value
	param		range		SizeI in value
	dlflags		notlistable
	category	display-list
	version		1.0
	glxsingle	103
	glsopcode	0x0034
	wglflags	batchable
	offset		4

GenLists(range)
	return		List
	param		range		SizeI in value
	dlflags		notlistable
	category	display-list
	version		1.0
	glxsingle	104
	glsopcode	0x0035
	offset		5

ListBase(base)
	return		void
	param		base		List in value
	category	display-list
	version		1.0
	glxropcode	3
	glsopcode	0x0036
	offset		6

###############################################################################
#
# drawing commands
#
###############################################################################

Begin(mode)
	return		void
	param		mode		BeginMode in value
	category	drawing
	version		1.0
	glxropcode	4
	glsopcode	0x0037
	offset		7

Bitmap(width, height, xorig, yorig, xmove, ymove, bitmap)
	return		void
	param		width		SizeI in value
	param		height		SizeI in value
	param		xorig		CoordF in value
	param		yorig		CoordF in value
	param		xmove		CoordF in value
	param		ymove		CoordF in value
	param		bitmap		UInt8 in array [COMPSIZE(width/height)]
	category	drawing
	dlflags		handcode
	glxflags	client-handcode server-handcode
	version		1.0
	glxropcode	5
	glsflags	pixel-unpack
	glsopcode	0x0038
	wglflags	client-handcode server-handcode
	offset		8

Color3b(red, green, blue)
	return		void
	param		red		ColorB in value
	param		green		ColorB in value
	param		blue		ColorB in value
	category	drawing
	vectorequiv	Color3bv
	version		1.0
	offset		9

Color3bv(v)
	return		void
	param		v		ColorB in array [3]
	category	drawing
	version		1.0
	glxropcode	6
	glsopcode	0x0039
	offset		10

Color3d(red, green, blue)
	return		void
	param		red		ColorD in value
	param		green		ColorD in value
	param		blue		ColorD in value
	category	drawing
	vectorequiv	Color3dv
	version		1.0
	offset		11

Color3dv(v)
	return		void
	param		v		ColorD in array [3]
	category	drawing
	version		1.0
	glxropcode	7
	glsopcode	0x003A
	offset		12

Color3f(red, green, blue)
	return		void
	param		red		ColorF in value
	param		green		ColorF in value
	param		blue		ColorF in value
	category	drawing
	vectorequiv	Color3fv
	version		1.0
	offset		13

Color3fv(v)
	return		void
	param		v		ColorF in array [3]
	category	drawing
	version		1.0
	glxropcode	8
	glsopcode	0x003B
	offset		14

Color3i(red, green, blue)
	return		void
	param		red		ColorI in value
	param		green		ColorI in value
	param		blue		ColorI in value
	category	drawing
	vectorequiv	Color3iv
	version		1.0
	offset		15

Color3iv(v)
	return		void
	param		v		ColorI in array [3]
	category	drawing
	version		1.0
	glxropcode	9
	glsopcode	0x003C
	offset		16

Color3s(red, green, blue)
	return		void
	param		red		ColorS in value
	param		green		ColorS in value
	param		blue		ColorS in value
	category	drawing
	vectorequiv	Color3sv
	version		1.0
	offset		17

Color3sv(v)
	return		void
	param		v		ColorS in array [3]
	category	drawing
	version		1.0
	glxropcode	10
	glsopcode	0x003D
	offset		18

Color3ub(red, green, blue)
	return		void
	param		red		ColorUB in value
	param		green		ColorUB in value
	param		blue		ColorUB in value
	category	drawing
	vectorequiv	Color3ubv
	version		1.0
	offset		19

Color3ubv(v)
	return		void
	param		v		ColorUB in array [3]
	category	drawing
	version		1.0
	glxropcode	11
	glsopcode	0x003E
	offset		20

Color3ui(red, green, blue)
	return		void
	param		red		ColorUI in value
	param		green		ColorUI in value
	param		blue		ColorUI in value
	category	drawing
	vectorequiv	Color3uiv
	version		1.0
	offset		21

Color3uiv(v)
	return		void
	param		v		ColorUI in array [3]
	category	drawing
	version		1.0
	glxropcode	12
	glsopcode	0x003F
	offset		22

Color3us(red, green, blue)
	return		void
	param		red		ColorUS in value
	param		green		ColorUS in value
	param		blue		ColorUS in value
	category	drawing
	vectorequiv	Color3usv
	version		1.0
	offset		23

Color3usv(v)
	return		void
	param		v		ColorUS in array [3]
	category	drawing
	version		1.0
	glxropcode	13
	glsopcode	0x0040
	offset		24

Color4b(red, green, blue, alpha)
	return		void
	param		red		ColorB in value
	param		green		ColorB in value
	param		blue		ColorB in value
	param		alpha		ColorB in value
	category	drawing
	vectorequiv	Color4bv
	version		1.0
	offset		25

Color4bv(v)
	return		void
	param		v		ColorB in array [4]
	category	drawing
	version		1.0
	glxropcode	14
	glsopcode	0x0041
	offset		26

Color4d(red, green, blue, alpha)
	return		void
	param		red		ColorD in value
	param		green		ColorD in value
	param		blue		ColorD in value
	param		alpha		ColorD in value
	category	drawing
	vectorequiv	Color4dv
	version		1.0
	offset		27

Color4dv(v)
	return		void
	param		v		ColorD in array [4]
	category	drawing
	version		1.0
	glxropcode	15
	glsopcode	0x0042
	offset		28

Color4f(red, green, blue, alpha)
	return		void
	param		red		ColorF in value
	param		green		ColorF in value
	param		blue		ColorF in value
	param		alpha		ColorF in value
	category	drawing
	vectorequiv	Color4fv
	version		1.0
	offset		29

Color4fv(v)
	return		void
	param		v		ColorF in array [4]
	category	drawing
	version		1.0
	glxropcode	16
	glsopcode	0x0043
	offset		30

Color4i(red, green, blue, alpha)
	return		void
	param		red		ColorI in value
	param		green		ColorI in value
	param		blue		ColorI in value
	param		alpha		ColorI in value
	category	drawing
	vectorequiv	Color4iv
	version		1.0
	offset		31

Color4iv(v)
	return		void
	param		v		ColorI in array [4]
	category	drawing
	version		1.0
	glxropcode	17
	glsopcode	0x0044
	offset		32

Color4s(red, green, blue, alpha)
	return		void
	param		red		ColorS in value
	param		green		ColorS in value
	param		blue		ColorS in value
	param		alpha		ColorS in value
	category	drawing
	vectorequiv	Color4sv
	version		1.0
	offset		33

Color4sv(v)
	return		void
	param		v		ColorS in array [4]
	category	drawing
	version		1.0
	glxropcode	18
	glsopcode	0x0045
	offset		34

Color4ub(red, green, blue, alpha)
	return		void
	param		red		ColorUB in value
	param		green		ColorUB in value
	param		blue		ColorUB in value
	param		alpha		ColorUB in value
	category	drawing
	vectorequiv	Color4ubv
	version		1.0
	offset		35

Color4ubv(v)
	return		void
	param		v		ColorUB in array [4]
	category	drawing
	version		1.0
	glxropcode	19
	glsopcode	0x0046
	offset		36

Color4ui(red, green, blue, alpha)
	return		void
	param		red		ColorUI in value
	param		green		ColorUI in value
	param		blue		ColorUI in value
	param		alpha		ColorUI in value
	category	drawing
	vectorequiv	Color4uiv
	version		1.0
	offset		37

Color4uiv(v)
	return		void
	param		v		ColorUI in array [4]
	category	drawing
	version		1.0
	glxropcode	20
	glsopcode	0x0047
	offset		38

Color4us(red, green, blue, alpha)
	return		void
	param		red		ColorUS in value
	param		green		ColorUS in value
	param		blue		ColorUS in value
	param		alpha		ColorUS in value
	category	drawing
	vectorequiv	Color4usv
	version		1.0
	offset		39

Color4usv(v)
	return		void
	param		v		ColorUS in array [4]
	category	drawing
	version		1.0
	glxropcode	21
	glsopcode	0x0048
	offset		40

EdgeFlag(flag)
	return		void
	param		flag		Boolean in value
	category	drawing
	vectorequiv	EdgeFlagv
	version		1.0
	offset		41

EdgeFlagv(flag)
	return		void
	param		flag		Boolean in array [1]
	category	drawing
	version		1.0
	glxropcode	22
	glsopcode	0x0049
	offset		42

End()
	return		void
	category	drawing
	version		1.0
	glxropcode	23
	glsopcode	0x004A
	offset		43

Indexd(c)
	return		void
	param		c		ColorIndexValueD in value
	category	drawing
	vectorequiv	Indexdv
	version		1.0
	offset		44

Indexdv(c)
	return		void
	param		c		ColorIndexValueD in array [1]
	category	drawing
	version		1.0
	glxropcode	24
	glsopcode	0x004B
	offset		45

Indexf(c)
	return		void
	param		c		ColorIndexValueF in value
	category	drawing
	vectorequiv	Indexfv
	version		1.0
	offset		46

Indexfv(c)
	return		void
	param		c		ColorIndexValueF in array [1]
	category	drawing
	version		1.0
	glxropcode	25
	glsopcode	0x004C
	offset		47

Indexi(c)
	return		void
	param		c		ColorIndexValueI in value
	category	drawing
	vectorequiv	Indexiv
	version		1.0
	offset		48

Indexiv(c)
	return		void
	param		c		ColorIndexValueI in array [1]
	category	drawing
	version		1.0
	glxropcode	26
	glsopcode	0x004D
	offset		49

Indexs(c)
	return		void
	param		c		ColorIndexValueS in value
	category	drawing
	vectorequiv	Indexsv
	version		1.0
	offset		50

Indexsv(c)
	return		void
	param		c		ColorIndexValueS in array [1]
	category	drawing
	version		1.0
	glxropcode	27
	glsopcode	0x004E
	offset		51

Normal3b(nx, ny, nz)
	return		void
	param		nx		Int8 in value
	param		ny		Int8 in value
	param		nz		Int8 in value
	category	drawing
	vectorequiv	Normal3bv
	version		1.0
	offset		52

Normal3bv(v)
	return		void
	param		v		Int8 in array [3]
	category	drawing
	version		1.0
	glxropcode	28
	glsopcode	0x004F
	offset		53

Normal3d(nx, ny, nz)
	return		void
	param		nx		CoordD in value
	param		ny		CoordD in value
	param		nz		CoordD in value
	category	drawing
	vectorequiv	Normal3dv
	version		1.0
	offset		54

Normal3dv(v)
	return		void
	param		v		CoordD in array [3]
	category	drawing
	version		1.0
	glxropcode	29
	glsopcode	0x0050
	offset		55

Normal3f(nx, ny, nz)
	return		void
	param		nx		CoordF in value
	param		ny		CoordF in value
	param		nz		CoordF in value
	category	drawing
	vectorequiv	Normal3fv
	version		1.0
	offset		56

Normal3fv(v)
	return		void
	param		v		CoordF in array [3]
	category	drawing
	version		1.0
	glxropcode	30
	glsopcode	0x0051
	offset		57

Normal3i(nx, ny, nz)
	return		void
	param		nx		Int32 in value
	param		ny		Int32 in value
	param		nz		Int32 in value
	category	drawing
	vectorequiv	Normal3iv
	version		1.0
	offset		58

Normal3iv(v)
	return		void
	param		v		Int32 in array [3]
	category	drawing
	version		1.0
	glxropcode	31
	glsopcode	0x0052
	offset		59

Normal3s(nx, ny, nz)
	return		void
	param		nx		Int16 in value
	param		ny		Int16 in value
	param		nz		Int16 in value
	category	drawing
	vectorequiv	Normal3sv
	version		1.0
	offset		60

Normal3sv(v)
	return		void
	param		v		Int16 in array [3]
	category	drawing
	version		1.0
	glxropcode	32
	glsopcode	0x0053
	offset		61

RasterPos2d(x, y)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	category	drawing
	vectorequiv	RasterPos2dv
	version		1.0
	offset		62

RasterPos2dv(v)
	return		void
	param		v		CoordD in array [2]
	category	drawing
	version		1.0
	glxropcode	33
	glsopcode	0x0054
	offset		63

RasterPos2f(x, y)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	category	drawing
	vectorequiv	RasterPos2fv
	version		1.0
	offset		64

RasterPos2fv(v)
	return		void
	param		v		CoordF in array [2]
	category	drawing
	version		1.0
	glxropcode	34
	glsopcode	0x0055
	offset		65

RasterPos2i(x, y)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	category	drawing
	vectorequiv	RasterPos2iv
	version		1.0
	offset		66

RasterPos2iv(v)
	return		void
	param		v		CoordI in array [2]
	category	drawing
	version		1.0
	glxropcode	35
	glsopcode	0x0056
	offset		67

RasterPos2s(x, y)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	category	drawing
	vectorequiv	RasterPos2sv
	version		1.0
	offset		68

RasterPos2sv(v)
	return		void
	param		v		CoordS in array [2]
	category	drawing
	version		1.0
	glxropcode	36
	glsopcode	0x0057
	offset		69

RasterPos3d(x, y, z)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	param		z		CoordD in value
	vectorequiv	RasterPos3dv
	category	drawing
	version		1.0
	offset		70

RasterPos3dv(v)
	return		void
	param		v		CoordD in array [3]
	category	drawing
	version		1.0
	glxropcode	37
	glsopcode	0x0058
	offset		71

RasterPos3f(x, y, z)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	param		z		CoordF in value
	category	drawing
	vectorequiv	RasterPos3fv
	version		1.0
	offset		72

RasterPos3fv(v)
	return		void
	param		v		CoordF in array [3]
	category	drawing
	version		1.0
	glxropcode	38
	glsopcode	0x0059
	offset		73

RasterPos3i(x, y, z)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	param		z		CoordI in value
	category	drawing
	vectorequiv	RasterPos3iv
	version		1.0
	offset		74

RasterPos3iv(v)
	return		void
	param		v		CoordI in array [3]
	category	drawing
	version		1.0
	glxropcode	39
	glsopcode	0x005A
	offset		75

RasterPos3s(x, y, z)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	param		z		CoordS in value
	category	drawing
	vectorequiv	RasterPos3sv
	version		1.0
	offset		76

RasterPos3sv(v)
	return		void
	param		v		CoordS in array [3]
	category	drawing
	version		1.0
	glxropcode	40
	glsopcode	0x005B
	offset		77

RasterPos4d(x, y, z, w)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	param		z		CoordD in value
	param		w		CoordD in value
	vectorequiv	RasterPos4dv
	category	drawing
	version		1.0
	offset		78

RasterPos4dv(v)
	return		void
	param		v		CoordD in array [4]
	category	drawing
	version		1.0
	glxropcode	41
	glsopcode	0x005C
	offset		79

RasterPos4f(x, y, z, w)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	param		z		CoordF in value
	param		w		CoordF in value
	category	drawing
	vectorequiv	RasterPos4fv
	version		1.0
	offset		80

RasterPos4fv(v)
	return		void
	param		v		CoordF in array [4]
	category	drawing
	version		1.0
	glxropcode	42
	glsopcode	0x005D
	offset		81

RasterPos4i(x, y, z, w)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	param		z		CoordI in value
	param		w		CoordI in value
	category	drawing
	vectorequiv	RasterPos4iv
	version		1.0
	offset		82

RasterPos4iv(v)
	return		void
	param		v		CoordI in array [4]
	category	drawing
	version		1.0
	glxropcode	43
	glsopcode	0x005E
	offset		83

RasterPos4s(x, y, z, w)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	param		z		CoordS in value
	param		w		CoordS in value
	category	drawing
	vectorequiv	RasterPos4sv
	version		1.0
	offset		84

RasterPos4sv(v)
	return		void
	param		v		CoordS in array [4]
	category	drawing
	version		1.0
	glxropcode	44
	glsopcode	0x005F
	offset		85

Rectd(x1, y1, x2, y2)
	return		void
	param		x1		CoordD in value
	param		y1		CoordD in value
	param		x2		CoordD in value
	param		y2		CoordD in value
	category	drawing
	vectorequiv	Rectdv
	version		1.0
	offset		86

Rectdv(v1, v2)
	return		void
	param		v1		CoordD in array [2]
	param		v2		CoordD in array [2]
	category	drawing
	version		1.0
	glxropcode	45
	glsopcode	0x0060
	offset		87

Rectf(x1, y1, x2, y2)
	return		void
	param		x1		CoordF in value
	param		y1		CoordF in value
	param		x2		CoordF in value
	param		y2		CoordF in value
	category	drawing
	vectorequiv	Rectfv
	version		1.0
	offset		88

Rectfv(v1, v2)
	return		void
	param		v1		CoordF in array [2]
	param		v2		CoordF in array [2]
	category	drawing
	version		1.0
	glxropcode	46
	glsopcode	0x0061
	offset		89

Recti(x1, y1, x2, y2)
	return		void
	param		x1		CoordI in value
	param		y1		CoordI in value
	param		x2		CoordI in value
	param		y2		CoordI in value
	category	drawing
	vectorequiv	Rectiv
	version		1.0
	offset		90

Rectiv(v1, v2)
	return		void
	param		v1		CoordI in array [2]
	param		v2		CoordI in array [2]
	category	drawing
	version		1.0
	glxropcode	47
	glsopcode	0x0062
	offset		91

Rects(x1, y1, x2, y2)
	return		void
	param		x1		CoordS in value
	param		y1		CoordS in value
	param		x2		CoordS in value
	param		y2		CoordS in value
	category	drawing
	vectorequiv	Rectsv
	version		1.0
	offset		92

Rectsv(v1, v2)
	return		void
	param		v1		CoordS in array [2]
	param		v2		CoordS in array [2]
	category	drawing
	version		1.0
	glxropcode	48
	glsopcode	0x0063
	offset		93

TexCoord1d(s)
	return		void
	param		s		CoordD in value
	category	drawing
	vectorequiv	TexCoord1dv
	version		1.0
	offset		94

TexCoord1dv(v)
	return		void
	param		v		CoordD in array [1]
	category	drawing
	version		1.0
	glxropcode	49
	glsopcode	0x0064
	offset		95

TexCoord1f(s)
	return		void
	param		s		CoordF in value
	category	drawing
	vectorequiv	TexCoord1fv
	version		1.0
	offset		96

TexCoord1fv(v)
	return		void
	param		v		CoordF in array [1]
	category	drawing
	version		1.0
	glxropcode	50
	glsopcode	0x0065
	offset		97

TexCoord1i(s)
	return		void
	param		s		CoordI in value
	category	drawing
	vectorequiv	TexCoord1iv
	version		1.0
	offset		98

TexCoord1iv(v)
	return		void
	param		v		CoordI in array [1]
	category	drawing
	version		1.0
	glxropcode	51
	glsopcode	0x0066
	offset		99

TexCoord1s(s)
	return		void
	param		s		CoordS in value
	category	drawing
	vectorequiv	TexCoord1sv
	version		1.0
	offset		100

TexCoord1sv(v)
	return		void
	param		v		CoordS in array [1]
	category	drawing
	version		1.0
	glxropcode	52
	glsopcode	0x0067
	offset		101

TexCoord2d(s, t)
	return		void
	param		s		CoordD in value
	param		t		CoordD in value
	category	drawing
	vectorequiv	TexCoord2dv
	version		1.0
	offset		102

TexCoord2dv(v)
	return		void
	param		v		CoordD in array [2]
	category	drawing
	version		1.0
	glxropcode	53
	glsopcode	0x0068
	offset		103

TexCoord2f(s, t)
	return		void
	param		s		CoordF in value
	param		t		CoordF in value
	category	drawing
	vectorequiv	TexCoord2fv
	version		1.0
	offset		104

TexCoord2fv(v)
	return		void
	param		v		CoordF in array [2]
	category	drawing
	version		1.0
	glxropcode	54
	glsopcode	0x0069
	offset		105

TexCoord2i(s, t)
	return		void
	param		s		CoordI in value
	param		t		CoordI in value
	category	drawing
	vectorequiv	TexCoord2iv
	version		1.0
	offset		106

TexCoord2iv(v)
	return		void
	param		v		CoordI in array [2]
	category	drawing
	version		1.0
	glxropcode	55
	glsopcode	0x006A
	offset		107

TexCoord2s(s, t)
	return		void
	param		s		CoordS in value
	param		t		CoordS in value
	category	drawing
	vectorequiv	TexCoord2sv
	version		1.0
	offset		108

TexCoord2sv(v)
	return		void
	param		v		CoordS in array [2]
	category	drawing
	version		1.0
	glxropcode	56
	glsopcode	0x006B
	offset		109

TexCoord3d(s, t, r)
	return		void
	param		s		CoordD in value
	param		t		CoordD in value
	param		r		CoordD in value
	category	drawing
	vectorequiv	TexCoord3dv
	version		1.0
	offset		110

TexCoord3dv(v)
	return		void
	param		v		CoordD in array [3]
	category	drawing
	version		1.0
	glxropcode	57
	glsopcode	0x006C
	offset		111

TexCoord3f(s, t, r)
	return		void
	param		s		CoordF in value
	param		t		CoordF in value
	param		r		CoordF in value
	category	drawing
	vectorequiv	TexCoord3fv
	version		1.0
	offset		112

TexCoord3fv(v)
	return		void
	param		v		CoordF in array [3]
	category	drawing
	version		1.0
	glxropcode	58
	glsopcode	0x006D
	offset		113

TexCoord3i(s, t, r)
	return		void
	param		s		CoordI in value
	param		t		CoordI in value
	param		r		CoordI in value
	category	drawing
	vectorequiv	TexCoord3iv
	version		1.0
	offset		114

TexCoord3iv(v)
	return		void
	param		v		CoordI in array [3]
	category	drawing
	version		1.0
	glxropcode	59
	glsopcode	0x006E
	offset		115

TexCoord3s(s, t, r)
	return		void
	param		s		CoordS in value
	param		t		CoordS in value
	param		r		CoordS in value
	category	drawing
	vectorequiv	TexCoord3sv
	version		1.0
	offset		116

TexCoord3sv(v)
	return		void
	param		v		CoordS in array [3]
	category	drawing
	version		1.0
	glxropcode	60
	glsopcode	0x006F
	offset		117

TexCoord4d(s, t, r, q)
	return		void
	param		s		CoordD in value
	param		t		CoordD in value
	param		r		CoordD in value
	param		q		CoordD in value
	category	drawing
	vectorequiv	TexCoord4dv
	version		1.0
	offset		118

TexCoord4dv(v)
	return		void
	param		v		CoordD in array [4]
	category	drawing
	version		1.0
	glxropcode	61
	glsopcode	0x0070
	offset		119

TexCoord4f(s, t, r, q)
	return		void
	param		s		CoordF in value
	param		t		CoordF in value
	param		r		CoordF in value
	param		q		CoordF in value
	category	drawing
	vectorequiv	TexCoord4fv
	version		1.0
	offset		120

TexCoord4fv(v)
	return		void
	param		v		CoordF in array [4]
	category	drawing
	version		1.0
	glxropcode	62
	glsopcode	0x0071
	offset		121

TexCoord4i(s, t, r, q)
	return		void
	param		s		CoordI in value
	param		t		CoordI in value
	param		r		CoordI in value
	param		q		CoordI in value
	category	drawing
	vectorequiv	TexCoord4iv
	version		1.0
	offset		122

TexCoord4iv(v)
	return		void
	param		v		CoordI in array [4]
	category	drawing
	version		1.0
	glxropcode	63
	glsopcode	0x0072
	offset		123

TexCoord4s(s, t, r, q)
	return		void
	param		s		CoordS in value
	param		t		CoordS in value
	param		r		CoordS in value
	param		q		CoordS in value
	category	drawing
	vectorequiv	TexCoord4sv
	version		1.0
	offset		124

TexCoord4sv(v)
	return		void
	param		v		CoordS in array [4]
	category	drawing
	version		1.0
	glxropcode	64
	glsopcode	0x0073
	offset		125

Vertex2d(x, y)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	category	drawing
	vectorequiv	Vertex2dv
	version		1.0
	offset		126

Vertex2dv(v)
	return		void
	param		v		CoordD in array [2]
	category	drawing
	version		1.0
	glxropcode	65
	glsopcode	0x0074
	offset		127

Vertex2f(x, y)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	category	drawing
	vectorequiv	Vertex2fv
	version		1.0
	offset		128

Vertex2fv(v)
	return		void
	param		v		CoordF in array [2]
	category	drawing
	version		1.0
	glxropcode	66
	glsopcode	0x0075
	offset		129

Vertex2i(x, y)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	category	drawing
	vectorequiv	Vertex2iv
	version		1.0
	offset		130

Vertex2iv(v)
	return		void
	param		v		CoordI in array [2]
	category	drawing
	version		1.0
	glxropcode	67
	glsopcode	0x0076
	offset		131

Vertex2s(x, y)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	category	drawing
	vectorequiv	Vertex2sv
	version		1.0
	offset		132

Vertex2sv(v)
	return		void
	param		v		CoordS in array [2]
	category	drawing
	version		1.0
	glxropcode	68
	glsopcode	0x0077
	offset		133

Vertex3d(x, y, z)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	param		z		CoordD in value
	category	drawing
	vectorequiv	Vertex3dv
	version		1.0
	offset		134

Vertex3dv(v)
	return		void
	param		v		CoordD in array [3]
	category	drawing
	version		1.0
	glxropcode	69
	glsopcode	0x0078
	offset		135

Vertex3f(x, y, z)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	param		z		CoordF in value
	category	drawing
	vectorequiv	Vertex3fv
	version		1.0
	offset		136

Vertex3fv(v)
	return		void
	param		v		CoordF in array [3]
	category	drawing
	version		1.0
	glxropcode	70
	glsopcode	0x0079
	offset		137

Vertex3i(x, y, z)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	param		z		CoordI in value
	category	drawing
	vectorequiv	Vertex3iv
	version		1.0
	offset		138

Vertex3iv(v)
	return		void
	param		v		CoordI in array [3]
	category	drawing
	version		1.0
	glxropcode	71
	glsopcode	0x007A
	offset		139

Vertex3s(x, y, z)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	param		z		CoordS in value
	category	drawing
	vectorequiv	Vertex3sv
	version		1.0
	offset		140

Vertex3sv(v)
	return		void
	param		v		CoordS in array [3]
	category	drawing
	version		1.0
	glxropcode	72
	glsopcode	0x007B
	offset		141

Vertex4d(x, y, z, w)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	param		z		CoordD in value
	param		w		CoordD in value
	category	drawing
	vectorequiv	Vertex4dv
	version		1.0
	offset		142

Vertex4dv(v)
	return		void
	param		v		CoordD in array [4]
	category	drawing
	version		1.0
	glxropcode	73
	glsopcode	0x007C
	offset		143

Vertex4f(x, y, z, w)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	param		z		CoordF in value
	param		w		CoordF in value
	category	drawing
	vectorequiv	Vertex4fv
	version		1.0
	offset		144

Vertex4fv(v)
	return		void
	param		v		CoordF in array [4]
	category	drawing
	version		1.0
	glxropcode	74
	glsopcode	0x007D
	offset		145

Vertex4i(x, y, z, w)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	param		z		CoordI in value
	param		w		CoordI in value
	category	drawing
	vectorequiv	Vertex4iv
	version		1.0
	offset		146

Vertex4iv(v)
	return		void
	param		v		CoordI in array [4]
	category	drawing
	version		1.0
	glxropcode	75
	glsopcode	0x007E
	offset		147

Vertex4s(x, y, z, w)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	param		z		CoordS in value
	param		w		CoordS in value
	category	drawing
	vectorequiv	Vertex4sv
	version		1.0
	offset		148

Vertex4sv(v)
	return		void
	param		v		CoordS in array [4]
	category	drawing
	version		1.0
	glxropcode	76
	glsopcode	0x007F
	offset		149

###############################################################################
#
# drawing-control commands
#
###############################################################################

ClipPlane(plane, equation)
	return		void
	param		plane		ClipPlaneName in value
	param		equation	Float64 in array [4]
	category	drawing-control
	version		1.0
	glxropcode	77
	glsopcode	0x0080
	offset		150

ColorMaterial(face, mode)
	return		void
	param		face		MaterialFace in value
	param		mode		ColorMaterialParameter in value
	category	drawing-control
	version		1.0
	glxropcode	78
	glsopcode	0x0081
	offset		151

CullFace(mode)
	return		void
	param		mode		CullFaceMode in value
	category	drawing-control
	version		1.0
	glxropcode	79
	glsopcode	0x0082
	offset		152

Fogf(pname, param)
	return		void
	param		pname		FogParameter in value
	param		param		CheckedFloat32 in value
	category	drawing-control
	version		1.0
	glxropcode	80
	glsflags	gl-enum
	glsopcode	0x0083
	wglflags	small-data
	offset		153

Fogfv(pname, params)
	return		void
	param		pname		FogParameter in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	81
	glsflags	gl-enum
	glsopcode	0x0084
	wglflags	small-data
	offset		154

Fogi(pname, param)
	return		void
	param		pname		FogParameter in value
	param		param		CheckedInt32 in value
	category	drawing-control
	version		1.0
	glxropcode	82
	glsflags	gl-enum
	glsopcode	0x0085
	wglflags	small-data
	offset		155

Fogiv(pname, params)
	return		void
	param		pname		FogParameter in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	83
	glsflags	gl-enum
	glsopcode	0x0086
	wglflags	small-data
	offset		156

FrontFace(mode)
	return		void
	param		mode		FrontFaceDirection in value
	category	drawing-control
	version		1.0
	glxropcode	84
	glsopcode	0x0087
	offset		157

Hint(target, mode)
	return		void
	param		target		HintTarget in value
	param		mode		HintMode in value
	category	drawing-control
	version		1.0
	glxropcode	85
	glsopcode	0x0088
	offset		158

Lightf(light, pname, param)
	return		void
	param		light		LightName in value
	param		pname		LightParameter in value
	param		param		CheckedFloat32 in value
	category	drawing-control
	version		1.0
	glxropcode	86
	glsopcode	0x0089
	wglflags	small-data
	offset		159

Lightfv(light, pname, params)
	return		void
	param		light		LightName in value
	param		pname		LightParameter in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	87
	glsopcode	0x008A
	wglflags	small-data
	offset		160

Lighti(light, pname, param)
	return		void
	param		light		LightName in value
	param		pname		LightParameter in value
	param		param		CheckedInt32 in value
	category	drawing-control
	version		1.0
	glxropcode	88
	glsopcode	0x008B
	wglflags	small-data
	offset		161

Lightiv(light, pname, params)
	return		void
	param		light		LightName in value
	param		pname		LightParameter in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	89
	glsopcode	0x008C
	wglflags	small-data
	offset		162

LightModelf(pname, param)
	return		void
	param		pname		LightModelParameter in value
	param		param		Float32 in value
	category	drawing-control
	version		1.0
	glxropcode	90
	glsflags	gl-enum
	glsopcode	0x008D
	wglflags	small-data
	offset		163

LightModelfv(pname, params)
	return		void
	param		pname		LightModelParameter in value
	param		params		Float32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	91
	glsflags	gl-enum
	glsopcode	0x008E
	wglflags	small-data
	offset		164

LightModeli(pname, param)
	return		void
	param		pname		LightModelParameter in value
	param		param		Int32 in value
	category	drawing-control
	version		1.0
	glxropcode	92
	glsflags	gl-enum
	glsopcode	0x008F
	wglflags	small-data
	offset		165

LightModeliv(pname, params)
	return		void
	param		pname		LightModelParameter in value
	param		params		Int32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	93
	glsflags	gl-enum
	glsopcode	0x0090
	wglflags	small-data
	offset		166

LineStipple(factor, pattern)
	return		void
	param		factor		CheckedInt32 in value
	param		pattern		LineStipple in value
	category	drawing-control
	version		1.0
	glxropcode	94
	glsopcode	0x0091
	offset		167

LineWidth(width)
	return		void
	param		width		CheckedFloat32 in value
	category	drawing-control
	version		1.0
	glxropcode	95
	glsopcode	0x0092
	offset		168

Materialf(face, pname, param)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		param		CheckedFloat32 in value
	category	drawing-control
	version		1.0
	glxropcode	96
	glsopcode	0x0093
	wglflags	small-data
	offset		169

Materialfv(face, pname, params)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	97
	glsopcode	0x0094
	wglflags	small-data
	offset		170

Materiali(face, pname, param)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		param		CheckedInt32 in value
	category	drawing-control
	version		1.0
	glxropcode	98
	glsopcode	0x0095
	wglflags	small-data
	offset		171

Materialiv(face, pname, params)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	99
	glsopcode	0x0096
	wglflags	small-data
	offset		172

PointSize(size)
	return		void
	param		size		CheckedFloat32 in value
	category	drawing-control
	version		1.0
	glxropcode	100
	glsopcode	0x0097
	offset		173

PolygonMode(face, mode)
	return		void
	param		face		MaterialFace in value
	param		mode		PolygonMode in value
	category	drawing-control
	version		1.0
	glxropcode	101
	glsopcode	0x0098
	offset		174

PolygonStipple(mask)
	return		void
	param		mask		UInt8 in array [COMPSIZE()]
	category	drawing-control
	dlflags		handcode
	glxflags	client-handcode server-handcode
	version		1.0
	glxropcode	102
	glsflags	pixel-unpack
	glsopcode	0x0099
	wglflags	client-handcode server-handcode
	offset		175

Scissor(x, y, width, height)
	return		void
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	category	drawing-control
	version		1.0
	glxropcode	103
	glsopcode	0x009A
	offset		176

ShadeModel(mode)
	return		void
	param		mode		ShadingModel in value
	category	drawing-control
	version		1.0
	glxropcode	104
	glsopcode	0x009B
	offset		177

TexParameterf(target, pname, param)
	return		void
	param		target		TextureTarget in value
	param		pname		TextureParameterName in value
	param		param		CheckedFloat32 in value
	category	drawing-control
	version		1.0
	glxropcode	105
	glsflags	gl-enum
	glsopcode	0x009C
	wglflags	small-data
	offset		178

TexParameterfv(target, pname, params)
	return		void
	param		target		TextureTarget in value
	param		pname		TextureParameterName in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	106
	glsflags	gl-enum
	glsopcode	0x009D
	wglflags	small-data
	offset		179

TexParameteri(target, pname, param)
	return		void
	param		target		TextureTarget in value
	param		pname		TextureParameterName in value
	param		param		CheckedInt32 in value
	category	drawing-control
	version		1.0
	glxropcode	107
	glsflags	gl-enum
	glsopcode	0x009E
	wglflags	small-data
	offset		180

TexParameteriv(target, pname, params)
	return		void
	param		target		TextureTarget in value
	param		pname		TextureParameterName in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	108
	glsflags	gl-enum
	glsopcode	0x009F
	wglflags	small-data
	offset		181

TexImage1D(target, level, internalformat, width, border, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	TextureComponentCount in value
	param		width		SizeI in value
	param		border		CheckedInt32 in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width)]
	category	drawing-control
	dlflags		handcode
	glxflags	client-handcode server-handcode
	version		1.0
	glxropcode	109
	glsflags	pixel-null pixel-unpack
	glsopcode	0x00A0
	wglflags	client-handcode server-handcode
	offset		182

TexImage2D(target, level, internalformat, width, height, border, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	TextureComponentCount in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		border		CheckedInt32 in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width/height)]
	category	drawing-control
	dlflags		handcode
	glxflags	client-handcode server-handcode
	version		1.0
	glxropcode	110
	glsflags	pixel-null pixel-unpack
	glsopcode	0x00A1
	wglflags	client-handcode server-handcode
	offset		183

TexEnvf(target, pname, param)
	return		void
	param		target		TextureEnvTarget in value
	param		pname		TextureEnvParameter in value
	param		param		CheckedFloat32 in value
	category	drawing-control
	version		1.0
	glxropcode	111
	glsflags	gl-enum
	glsopcode	0x00A2
	wglflags	small-data
	offset		184

TexEnvfv(target, pname, params)
	return		void
	param		target		TextureEnvTarget in value
	param		pname		TextureEnvParameter in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	112
	glsflags	gl-enum
	glsopcode	0x00A3
	wglflags	small-data
	offset		185

TexEnvi(target, pname, param)
	return		void
	param		target		TextureEnvTarget in value
	param		pname		TextureEnvParameter in value
	param		param		CheckedInt32 in value
	category	drawing-control
	version		1.0
	glxropcode	113
	glsflags	gl-enum
	glsopcode	0x00A4
	wglflags	small-data
	offset		186

TexEnviv(target, pname, params)
	return		void
	param		target		TextureEnvTarget in value
	param		pname		TextureEnvParameter in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	114
	glsflags	gl-enum
	glsopcode	0x00A5
	wglflags	small-data
	offset		187

TexGend(coord, pname, param)
	return		void
	param		coord		TextureCoordName in value
	param		pname		TextureGenParameter in value
	param		param		Float64 in value
	category	drawing-control
	version		1.0
	glxropcode	115
	glsflags	gl-enum
	glsopcode	0x00A6
	wglflags	small-data
	offset		188

TexGendv(coord, pname, params)
	return		void
	param		coord		TextureCoordName in value
	param		pname		TextureGenParameter in value
	param		params		Float64 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	116
	glsflags	gl-enum
	glsopcode	0x00A7
	wglflags	small-data
	offset		189

TexGenf(coord, pname, param)
	return		void
	param		coord		TextureCoordName in value
	param		pname		TextureGenParameter in value
	param		param		CheckedFloat32 in value
	category	drawing-control
	version		1.0
	glxropcode	117
	glsflags	gl-enum
	glsopcode	0x00A8
	wglflags	small-data
	offset		190

TexGenfv(coord, pname, params)
	return		void
	param		coord		TextureCoordName in value
	param		pname		TextureGenParameter in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	118
	glsflags	gl-enum
	glsopcode	0x00A9
	wglflags	small-data
	offset		191

TexGeni(coord, pname, param)
	return		void
	param		coord		TextureCoordName in value
	param		pname		TextureGenParameter in value
	param		param		CheckedInt32 in value
	category	drawing-control
	version		1.0
	glxropcode	119
	glsflags	gl-enum
	glsopcode	0x00AA
	wglflags	small-data
	offset		192

TexGeniv(coord, pname, params)
	return		void
	param		coord		TextureCoordName in value
	param		pname		TextureGenParameter in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	drawing-control
	version		1.0
	glxropcode	120
	glsflags	gl-enum
	glsopcode	0x00AB
	wglflags	small-data
	offset		193

###############################################################################
#
# feedback commands
#
###############################################################################

FeedbackBuffer(size, type, buffer)
	return		void
	param		size		SizeI in value
	param		type		FeedbackType in value
	param		buffer		FeedbackElement out array [size] retained
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	feedback
	version		1.0
	glxsingle	105
	glsflags	client
	glsopcode	0x00AC
	wglflags	client-handcode server-handcode batchable
	offset		194

SelectBuffer(size, buffer)
	return		void
	param		size		SizeI in value
	param		buffer		SelectName out array [size] retained
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	feedback
	version		1.0
	glxsingle	106
	glsflags	client
	glsopcode	0x00AD
	wglflags	client-handcode server-handcode batchable
	offset		195

RenderMode(mode)
	return		Int32
	param		mode		RenderingMode in value
	category	feedback
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.0
	glxsingle	107
	glsopcode	0x00AE
	wglflags	client-handcode server-handcode
	offset		196

InitNames()
	return		void
	category	feedback
	version		1.0
	glxropcode	121
	glsopcode	0x00AF
	offset		197

LoadName(name)
	return		void
	param		name		SelectName in value
	category	feedback
	version		1.0
	glxropcode	122
	glsopcode	0x00B0
	offset		198

PassThrough(token)
	return		void
	param		token		FeedbackElement in value
	category	feedback
	version		1.0
	glxropcode	123
	glsopcode	0x00B1
	offset		199

PopName()
	return		void
	category	feedback
	version		1.0
	glxropcode	124
	glsopcode	0x00B2
	offset		200

PushName(name)
	return		void
	param		name		SelectName in value
	category	feedback
	version		1.0
	glxropcode	125
	glsopcode	0x00B3
	offset		201

###############################################################################
#
# framebuf commands
#
###############################################################################

DrawBuffer(mode)
	return		void
	param		mode		DrawBufferMode in value
	category	framebuf
	version		1.0
	glxropcode	126
	glsopcode	0x00B4
	offset		202

Clear(mask)
	return		void
	param		mask		ClearBufferMask in value
	category	framebuf
	version		1.0
	glxropcode	127
	glsopcode	0x00B5
	offset		203

ClearAccum(red, green, blue, alpha)
	return		void
	param		red		Float32 in value
	param		green		Float32 in value
	param		blue		Float32 in value
	param		alpha		Float32 in value
	category	framebuf
	version		1.0
	glxropcode	128
	glsopcode	0x00B6
	offset		204

ClearIndex(c)
	return		void
	param		c		MaskedColorIndexValueF in value
	category	framebuf
	version		1.0
	glxropcode	129
	glsopcode	0x00B7
	offset		205

ClearColor(red, green, blue, alpha)
	return		void
	param		red		ClampedColorF in value
	param		green		ClampedColorF in value
	param		blue		ClampedColorF in value
	param		alpha		ClampedColorF in value
	category	framebuf
	version		1.0
	glxropcode	130
	glsopcode	0x00B8
	offset		206

ClearStencil(s)
	return		void
	param		s		StencilValue in value
	category	framebuf
	version		1.0
	glxropcode	131
	glsopcode	0x00B9
	offset		207

ClearDepth(depth)
	return		void
	param		depth		ClampedFloat64 in value
	category	framebuf
	version		1.0
	glxropcode	132
	glsopcode	0x00BA
	offset		208

StencilMask(mask)
	return		void
	param		mask		MaskedStencilValue in value
	category	framebuf
	version		1.0
	glxropcode	133
	glsopcode	0x00BB
	offset		209

ColorMask(red, green, blue, alpha)
	return		void
	param		red		Boolean in value
	param		green		Boolean in value
	param		blue		Boolean in value
	param		alpha		Boolean in value
	category	framebuf
	version		1.0
	glxropcode	134
	glsopcode	0x00BC
	offset		210

DepthMask(flag)
	return		void
	param		flag		Boolean in value
	category	framebuf
	version		1.0
	glxropcode	135
	glsopcode	0x00BD
	offset		211

IndexMask(mask)
	return		void
	param		mask		MaskedColorIndexValueI in value
	category	framebuf
	version		1.0
	glxropcode	136
	glsopcode	0x00BE
	offset		212

###############################################################################
#
# misc commands
#
###############################################################################

Accum(op, value)
	return		void
	param		op		AccumOp in value
	param		value		CoordF in value
	category	misc
	version		1.0
	glxropcode	137
	glsopcode	0x00BF
	offset		213

Disable(cap)
	return		void
	param		cap		EnableCap in value
	category	misc
	version		1.0
	dlflags		handcode
	glxflags	client-handcode client-intercept
	glxropcode	138
	glsflags	client
	glsopcode	0x00C0
	offset		214

Enable(cap)
	return		void
	param		cap		EnableCap in value
	category	misc
	version		1.0
	dlflags		handcode
	glxflags	client-handcode client-intercept
	glxropcode	139
	glsflags	client
	glsopcode	0x00C1
	offset		215

Finish()
	return		void
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	category	misc
	version		1.0
	glxsingle	108
	glsopcode	0x00C2
	offset		216

Flush()
	return		void
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	category	misc
	version		1.0
	glxsingle	142
	glsopcode	0x00C3
	offset		217

PopAttrib()
	return		void
	category	misc
	version		1.0
	glxropcode	141
	glsopcode	0x00C4
	offset		218

PushAttrib(mask)
	return		void
	param		mask		AttribMask in value
	category	misc
	version		1.0
	glxropcode	142
	glsopcode	0x00C5
	offset		219

###############################################################################
#
# modeling commands
#
###############################################################################

Map1d(target, u1, u2, stride, order, points)
	return		void
	param		target		MapTarget in value
	param		u1		CoordD in value
	param		u2		CoordD in value
	param		stride		Int32 in value
	param		order		CheckedInt32 in value
	param		points		CoordD in array [COMPSIZE(target/stride/order)]
	category	modeling
	dlflags		handcode
	glxflags	client-handcode server-handcode
	version		1.0
	glxropcode	143
	glsflags	capture-handcode
	glsopcode	0x00C6
	wglflags	client-handcode server-handcode
	offset		220

Map1f(target, u1, u2, stride, order, points)
	return		void
	param		target		MapTarget in value
	param		u1		CoordF in value
	param		u2		CoordF in value
	param		stride		Int32 in value
	param		order		CheckedInt32 in value
	param		points		CoordF in array [COMPSIZE(target/stride/order)]
	category	modeling
	dlflags		handcode
	glxflags	client-handcode server-handcode
	version		1.0
	glxropcode	144
	glsflags	capture-handcode
	glsopcode	0x00C7
	wglflags	client-handcode server-handcode
	offset		221

Map2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points)
	return		void
	param		target		MapTarget in value
	param		u1		CoordD in value
	param		u2		CoordD in value
	param		ustride		Int32 in value
	param		uorder		CheckedInt32 in value
	param		v1		CoordD in value
	param		v2		CoordD in value
	param		vstride		Int32 in value
	param		vorder		CheckedInt32 in value
	param		points		CoordD in array [COMPSIZE(target/ustride/uorder/vstride/vorder)]
	category	modeling
	dlflags		handcode
	glxflags	client-handcode server-handcode
	version		1.0
	glxropcode	145
	glsflags	capture-handcode
	glsopcode	0x00C8
	wglflags	client-handcode server-handcode
	offset		222

Map2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points)
	return		void
	param		target		MapTarget in value
	param		u1		CoordF in value
	param		u2		CoordF in value
	param		ustride		Int32 in value
	param		uorder		CheckedInt32 in value
	param		v1		CoordF in value
	param		v2		CoordF in value
	param		vstride		Int32 in value
	param		vorder		CheckedInt32 in value
	param		points		CoordF in array [COMPSIZE(target/ustride/uorder/vstride/vorder)]
	category	modeling
	dlflags		handcode
	glxflags	client-handcode server-handcode
	version		1.0
	glxropcode	146
	glsflags	capture-handcode
	glsopcode	0x00C9
	wglflags	client-handcode server-handcode
	offset		223

MapGrid1d(un, u1, u2)
	return		void
	param		un		Int32 in value
	param		u1		CoordD in value
	param		u2		CoordD in value
	category	modeling
	version		1.0
	glxropcode	147
	glsopcode	0x00CA
	offset		224

MapGrid1f(un, u1, u2)
	return		void
	param		un		Int32 in value
	param		u1		CoordF in value
	param		u2		CoordF in value
	category	modeling
	version		1.0
	glxropcode	148
	glsopcode	0x00CB
	offset		225

MapGrid2d(un, u1, u2, vn, v1, v2)
	return		void
	param		un		Int32 in value
	param		u1		CoordD in value
	param		u2		CoordD in value
	param		vn		Int32 in value
	param		v1		CoordD in value
	param		v2		CoordD in value
	category	modeling
	version		1.0
	glxropcode	149
	glsopcode	0x00CC
	offset		226

MapGrid2f(un, u1, u2, vn, v1, v2)
	return		void
	param		un		Int32 in value
	param		u1		CoordF in value
	param		u2		CoordF in value
	param		vn		Int32 in value
	param		v1		CoordF in value
	param		v2		CoordF in value
	category	modeling
	version		1.0
	glxropcode	150
	glsopcode	0x00CD
	offset		227

EvalCoord1d(u)
	return		void
	param		u		CoordD in value
	category	modeling
	vectorequiv	EvalCoord1dv
	version		1.0
	offset		228

EvalCoord1dv(u)
	return		void
	param		u		CoordD in array [1]
	category	modeling
	version		1.0
	glxropcode	151
	glsopcode	0x00CE
	offset		229

EvalCoord1f(u)
	return		void
	param		u		CoordF in value
	category	modeling
	vectorequiv	EvalCoord1fv
	version		1.0
	offset		230

EvalCoord1fv(u)
	return		void
	param		u		CoordF in array [1]
	category	modeling
	version		1.0
	glxropcode	152
	glsopcode	0x00CF
	offset		231

EvalCoord2d(u, v)
	return		void
	param		u		CoordD in value
	param		v		CoordD in value
	category	modeling
	vectorequiv	EvalCoord2dv
	version		1.0
	offset		232

EvalCoord2dv(u)
	return		void
	param		u		CoordD in array [2]
	category	modeling
	version		1.0
	glxropcode	153
	glsopcode	0x00D0
	offset		233

EvalCoord2f(u, v)
	return		void
	param		u		CoordF in value
	param		v		CoordF in value
	category	modeling
	vectorequiv	EvalCoord2fv
	version		1.0
	offset		234

EvalCoord2fv(u)
	return		void
	param		u		CoordF in array [2]
	category	modeling
	version		1.0
	glxropcode	154
	glsopcode	0x00D1
	offset		235

EvalMesh1(mode, i1, i2)
	return		void
	param		mode		MeshMode1 in value
	param		i1		CheckedInt32 in value
	param		i2		CheckedInt32 in value
	category	modeling
	version		1.0
	glxropcode	155
	glsopcode	0x00D2
	offset		236

EvalPoint1(i)
	return		void
	param		i		Int32 in value
	category	modeling
	version		1.0
	glxropcode	156
	glsopcode	0x00D3
	offset		237

EvalMesh2(mode, i1, i2, j1, j2)
	return		void
	param		mode		MeshMode2 in value
	param		i1		CheckedInt32 in value
	param		i2		CheckedInt32 in value
	param		j1		CheckedInt32 in value
	param		j2		CheckedInt32 in value
	category	modeling
	version		1.0
	glxropcode	157
	glsopcode	0x00D4
	offset		238

EvalPoint2(i, j)
	return		void
	param		i		CheckedInt32 in value
	param		j		CheckedInt32 in value
	category	modeling
	version		1.0
	glxropcode	158
	glsopcode	0x00D5
	offset		239

###############################################################################
#
# pixel-op commands
#
###############################################################################

AlphaFunc(func, ref)
	return		void
	param		func		AlphaFunction in value
	param		ref		ClampedFloat32 in value
	category	pixel-op
	version		1.0
	glxropcode	159
	glsopcode	0x00D6
	offset		240

BlendFunc(sfactor, dfactor)
	return		void
	param		sfactor		BlendingFactorSrc in value
	param		dfactor		BlendingFactorDest in value
	category	pixel-op
	version		1.0
	glxropcode	160
	glsopcode	0x00D7
	offset		241

LogicOp(opcode)
	return		void
	param		opcode		LogicOp in value
	category	pixel-op
	version		1.0
	glxropcode	161
	glsopcode	0x00D8
	offset		242

StencilFunc(func, ref, mask)
	return		void
	param		func		StencilFunction in value
	param		ref		ClampedStencilValue in value
	param		mask		MaskedStencilValue in value
	category	pixel-op
	version		1.0
	glxropcode	162
	glsopcode	0x00D9
	offset		243

StencilOp(fail, zfail, zpass)
	return		void
	param		fail		StencilOp in value
	param		zfail		StencilOp in value
	param		zpass		StencilOp in value
	category	pixel-op
	version		1.0
	glxropcode	163
	glsopcode	0x00DA
	offset		244

DepthFunc(func)
	return		void
	param		func		DepthFunction in value
	category	pixel-op
	version		1.0
	glxropcode	164
	glsopcode	0x00DB
	offset		245

###############################################################################
#
# pixel-rw commands
#
###############################################################################

PixelZoom(xfactor, yfactor)
	return		void
	param		xfactor		Float32 in value
	param		yfactor		Float32 in value
	category	pixel-rw
	version		1.0
	glxropcode	165
	glsopcode	0x00DC
	offset		246

PixelTransferf(pname, param)
	return		void
	param		pname		PixelTransferParameter in value
	param		param		CheckedFloat32 in value
	category	pixel-rw
	version		1.0
	glxropcode	166
	glsflags	gl-enum
	glsopcode	0x00DD
	offset		247

PixelTransferi(pname, param)
	return		void
	param		pname		PixelTransferParameter in value
	param		param		CheckedInt32 in value
	category	pixel-rw
	version		1.0
	glxropcode	167
	glsflags	gl-enum
	glsopcode	0x00DE
	offset		248

PixelStoref(pname, param)
	return		void
	param		pname		PixelStoreParameter in value
	param		param		CheckedFloat32 in value
	dlflags		notlistable
	glxflags	client-handcode
	category	pixel-rw
	version		1.0
	glxsingle	109
	glsflags	client gl-enum
	glsopcode	0x00DF
	wglflags	batchable
	offset		249

PixelStorei(pname, param)
	return		void
	param		pname		PixelStoreParameter in value
	param		param		CheckedInt32 in value
	dlflags		notlistable
	glxflags	client-handcode
	category	pixel-rw
	version		1.0
	glxsingle	110
	glsflags	client gl-enum
	glsopcode	0x00E0
	wglflags	batchable
	offset		250

PixelMapfv(map, mapsize, values)
	return		void
	param		map		PixelMap in value
	param		mapsize		CheckedInt32 in value
	param		values		Float32 in array [mapsize]
	category	pixel-rw
	glxflags	client-handcode
	version		1.0
	glxropcode	168
	glsopcode	0x00E1
	offset		251

PixelMapuiv(map, mapsize, values)
	return		void
	param		map		PixelMap in value
	param		mapsize		CheckedInt32 in value
	param		values		UInt32 in array [mapsize]
	category	pixel-rw
	glxflags	client-handcode
	version		1.0
	glxropcode	169
	glsopcode	0x00E2
	offset		252

PixelMapusv(map, mapsize, values)
	return		void
	param		map		PixelMap in value
	param		mapsize		CheckedInt32 in value
	param		values		UInt16 in array [mapsize]
	category	pixel-rw
	glxflags	client-handcode
	version		1.0
	glxropcode	170
	glsopcode	0x00E3
	offset		253

ReadBuffer(mode)
	return		void
	param		mode		ReadBufferMode in value
	category	pixel-rw
	version		1.0
	glxropcode	171
	glsopcode	0x00E4
	offset		254

CopyPixels(x, y, width, height, type)
	return		void
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		type		PixelCopyType in value
	category	pixel-rw
	version		1.0
	glxropcode	172
	glsopcode	0x00E5
	offset		255

ReadPixels(x, y, width, height, format, type, pixels)
	return		void
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void out array [COMPSIZE(format/type/width/height)]
	category	pixel-rw
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.0
	glxsingle	111
	glsflags	get pixel-pack
	glsopcode	0x00E6
	wglflags	client-handcode server-handcode
	offset		256

DrawPixels(width, height, format, type, pixels)
	return		void
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width/height)]
	category	pixel-rw
	dlflags		handcode
	glxflags	client-handcode server-handcode
	version		1.0
	glxropcode	173
	glsflags	pixel-unpack
	glsopcode	0x00E7
	wglflags	client-handcode server-handcode
	offset		257

###############################################################################
#
# state-req commands
#
###############################################################################

GetBooleanv(pname, params)
	return		void
	param		pname		GetPName in value
	param		params		Boolean out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	glxflags	client-handcode
	version		1.0
	glxsingle	112
	glsflags	client get
	glsopcode	0x00E8
	wglflags	small-data
	offset		258

GetClipPlane(plane, equation)
	return		void
	param		plane		ClipPlaneName in value
	param		equation	Float64 out array [4]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	113
	glxflags	client-handcode server-handcode
	glsflags	get
	glsopcode	0x00E9
	offset		259

GetDoublev(pname, params)
	return		void
	param		pname		GetPName in value
	param		params		Float64 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	glxflags	client-handcode
	version		1.0
	glxsingle	114
	glsflags	client get
	glsopcode	0x00EA
	wglflags	small-data
	offset		260

GetError()
	return		ErrorCode
	category	state-req
	dlflags		notlistable
	glxflags	client-handcode
	version		1.0
	glxsingle	115
	glsflags	get
	glsopcode	0x00EB
	offset		261

GetFloatv(pname, params)
	return		void
	param		pname		GetPName in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	glxflags	client-handcode
	version		1.0
	glxsingle	116
	glsflags	client get
	glsopcode	0x00EC
	wglflags	small-data
	offset		262

GetIntegerv(pname, params)
	return		void
	param		pname		GetPName in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	glxflags	client-handcode
	version		1.0
	glxsingle	117
	glsflags	client get
	glsopcode	0x00ED
	wglflags	small-data
	offset		263

GetLightfv(light, pname, params)
	return		void
	param		light		LightName in value
	param		pname		LightParameter in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	118
	glsflags	get
	glsopcode	0x00EE
	wglflags	small-data
	offset		264

GetLightiv(light, pname, params)
	return		void
	param		light		LightName in value
	param		pname		LightParameter in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	119
	glsflags	get
	glsopcode	0x00EF
	wglflags	small-data
	offset		265

GetMapdv(target, query, v)
	return		void
	param		target		MapTarget in value
	param		query		GetMapQuery in value
	param		v		Float64 out array [COMPSIZE(target/query)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	120
	glsflags	get
	glsopcode	0x00F0
	offset		266

GetMapfv(target, query, v)
	return		void
	param		target		MapTarget in value
	param		query		GetMapQuery in value
	param		v		Float32 out array [COMPSIZE(target/query)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	121
	glsflags	get
	glsopcode	0x00F1
	offset		267

GetMapiv(target, query, v)
	return		void
	param		target		MapTarget in value
	param		query		GetMapQuery in value
	param		v		Int32 out array [COMPSIZE(target/query)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	122
	glsflags	get
	glsopcode	0x00F2
	offset		268

GetMaterialfv(face, pname, params)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	123
	glsflags	get
	glsopcode	0x00F3
	wglflags	small-data
	offset		269

GetMaterialiv(face, pname, params)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	124
	glsflags	get
	glsopcode	0x00F4
	wglflags	small-data
	offset		270

GetPixelMapfv(map, values)
	return		void
	param		map		PixelMap in value
	param		values		Float32 out array [COMPSIZE(map)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	125
	glsflags	get
	glsopcode	0x00F5
	offset		271

GetPixelMapuiv(map, values)
	return		void
	param		map		PixelMap in value
	param		values		UInt32 out array [COMPSIZE(map)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	126
	glsflags	get
	glsopcode	0x00F6
	offset		272

GetPixelMapusv(map, values)
	return		void
	param		map		PixelMap in value
	param		values		UInt16 out array [COMPSIZE(map)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	127
	glsflags	get
	glsopcode	0x00F7
	offset		273

GetPolygonStipple(mask)
	return		void
	param		mask		UInt8 out array [COMPSIZE()]
	category	state-req
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.0
	glxsingle	128
	glsflags	get pixel-pack
	glsopcode	0x00F8
	wglflags	client-handcode server-handcode
	offset		274

GetString(name)
	return		String
	param		name		StringName in value
	category	state-req
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.0
	glxsingle	129
	glsflags	get
	glsopcode	0x00F9
	wglflags	client-handcode server-handcode
	offset		275

GetTexEnvfv(target, pname, params)
	return		void
	param		target		TextureEnvTarget in value
	param		pname		TextureEnvParameter in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	130
	glsflags	get
	glsopcode	0x00FA
	wglflags	small-data
	offset		276

GetTexEnviv(target, pname, params)
	return		void
	param		target		TextureEnvTarget in value
	param		pname		TextureEnvParameter in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	131
	glsflags	get
	glsopcode	0x00FB
	wglflags	small-data
	offset		277

GetTexGendv(coord, pname, params)
	return		void
	param		coord		TextureCoordName in value
	param		pname		TextureGenParameter in value
	param		params		Float64 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	132
	glsflags	get
	glsopcode	0x00FC
	wglflags	small-data
	offset		278

GetTexGenfv(coord, pname, params)
	return		void
	param		coord		TextureCoordName in value
	param		pname		TextureGenParameter in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	133
	glsflags	get
	glsopcode	0x00FD
	wglflags	small-data
	offset		279

GetTexGeniv(coord, pname, params)
	return		void
	param		coord		TextureCoordName in value
	param		pname		TextureGenParameter in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	134
	glsflags	get
	glsopcode	0x00FE
	wglflags	small-data
	offset		280

GetTexImage(target, level, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void out array [COMPSIZE(target/level/format/type)]
	category	state-req
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.0
	glxsingle	135
	glsflags	get pixel-pack
	glsopcode	0x00FF
	wglflags	client-handcode server-handcode
	offset		281

GetTexParameterfv(target, pname, params)
	return		void
	param		target		TextureTarget in value
	param		pname		GetTextureParameter in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	136
	glsflags	get
	glsopcode	0x0100
	wglflags	small-data
	offset		282

GetTexParameteriv(target, pname, params)
	return		void
	param		target		TextureTarget in value
	param		pname		GetTextureParameter in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	137
	glsflags	get
	glsopcode	0x0101
	wglflags	small-data
	offset		283

GetTexLevelParameterfv(target, level, pname, params)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		pname		GetTextureParameter in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	138
	glsflags	get
	glsopcode	0x0102
	wglflags	small-data
	offset		284

GetTexLevelParameteriv(target, level, pname, params)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		pname		GetTextureParameter in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	139
	glsflags	get
	glsopcode	0x0103
	wglflags	small-data
	offset		285

IsEnabled(cap)
	return		Boolean
	param		cap		EnableCap in value
	category	state-req
	dlflags		notlistable
	version		1.0
	glxflags	client-handcode client-intercept
	glxsingle	140
	glsflags	client get
	glsopcode	0x0104
	offset		286

IsList(list)
	return		Boolean
	param		list		List in value
	category	state-req
	dlflags		notlistable
	version		1.0
	glxsingle	141
	glsflags	get
	glsopcode	0x0105
	offset		287

###############################################################################
#
# xform commands
#
###############################################################################

DepthRange(near, far)
	return		void
	param		near		ClampedFloat64 in value
	param		far		ClampedFloat64 in value
	category	xform
	version		1.0
	glxropcode	174
	glsopcode	0x0106
	offset		288

Frustum(left, right, bottom, top, zNear, zFar)
	return		void
	param		left		Float64 in value
	param		right		Float64 in value
	param		bottom		Float64 in value
	param		top		Float64 in value
	param		zNear		Float64 in value
	param		zFar		Float64 in value
	category	xform
	version		1.0
	glxropcode	175
	glsopcode	0x0107
	offset		289

LoadIdentity()
	return		void
	category	xform
	version		1.0
	glxropcode	176
	glsopcode	0x0108
	offset		290

LoadMatrixf(m)
	return		void
	param		m		Float32 in array [16]
	category	xform
	version		1.0
	glxropcode	177
	glsflags	matrix
	glsopcode	0x0109
	offset		291

LoadMatrixd(m)
	return		void
	param		m		Float64 in array [16]
	category	xform
	version		1.0
	glxropcode	178
	glsflags	matrix
	glsopcode	0x010A
	offset		292

MatrixMode(mode)
	return		void
	param		mode		MatrixMode in value
	category	xform
	version		1.0
	glxropcode	179
	glsopcode	0x010B
	offset		293

MultMatrixf(m)
	return		void
	param		m		Float32 in array [16]
	category	xform
	version		1.0
	glxropcode	180
	glsflags	matrix
	glsopcode	0x010C
	offset		294

MultMatrixd(m)
	return		void
	param		m		Float64 in array [16]
	category	xform
	version		1.0
	glxropcode	181
	glsflags	matrix
	glsopcode	0x010D
	offset		295

Ortho(left, right, bottom, top, zNear, zFar)
	return		void
	param		left		Float64 in value
	param		right		Float64 in value
	param		bottom		Float64 in value
	param		top		Float64 in value
	param		zNear		Float64 in value
	param		zFar		Float64 in value
	category	xform
	version		1.0
	glxropcode	182
	glsopcode	0x010E
	offset		296

PopMatrix()
	return		void
	category	xform
	version		1.0
	glxropcode	183
	glsopcode	0x010F
	offset		297

PushMatrix()
	return		void
	category	xform
	version		1.0
	glxropcode	184
	glsopcode	0x0110
	offset		298

Rotated(angle, x, y, z)
	return		void
	param		angle		Float64 in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	category	xform
	version		1.0
	glxropcode	185
	glsopcode	0x0111
	offset		299

Rotatef(angle, x, y, z)
	return		void
	param		angle		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	xform
	version		1.0
	glxropcode	186
	glsopcode	0x0112
	offset		300

Scaled(x, y, z)
	return		void
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	category	xform
	version		1.0
	glxropcode	187
	glsopcode	0x0113
	offset		301

Scalef(x, y, z)
	return		void
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	xform
	version		1.0
	glxropcode	188
	glsopcode	0x0114
	offset		302

Translated(x, y, z)
	return		void
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	category	xform
	version		1.0
	glxropcode	189
	glsopcode	0x0115
	offset		303

Translatef(x, y, z)
	return		void
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	xform
	version		1.0
	glxropcode	190
	glsopcode	0x0116
	offset		304

Viewport(x, y, width, height)
	return		void
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	category	xform
	version		1.0
	glxropcode	191
	glsopcode	0x0117
	offset		305

###############################################################################
#
# OpenGL 1.1 commands
#
###############################################################################

ArrayElement(i)
	return		void
	param		i		Int32 in value
	category	1_1
	dlflags		handcode
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsopcode	0x013E
	offset		306

ColorPointer(size, type, stride, pointer)
	return		void
	param		size		Int32 in value
	param		type		ColorPointerType in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(size/type/stride)] retained
	category	1_1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	client
	glsopcode	0x0152
	offset		308

DisableClientState(array)
	return		void
	param		array		EnableCap in value
	category	1_1
	version		1.1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	glsflags	client
	glsopcode	0x0153
	offset		309

DrawArrays(mode, first, count)
	return		void
	param		mode		BeginMode in value
	param		first		Int32 in value
	param		count		SizeI in value
	category	1_1
	dlflags		handcode
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glxropcode	193
	glsopcode	0x0258
	offset		310

DrawElements(mode, count, type, indices)
	return		void
	param		mode		BeginMode in value
	param		count		SizeI in value
	param		type		DrawElementsType in value
	param		indices		Void in array [COMPSIZE(count/type)]
	category	1_1
	dlflags		handcode
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsopcode	0x0154
	offset		311

EdgeFlagPointer(stride, pointer)
	return		void
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(stride)] retained
	category	1_1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	client
	glsopcode	0x0155
	offset		312

EnableClientState(array)
	return		void
	param		array		EnableCap in value
	category	1_1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	client
	glsopcode	0x0156
	offset		313

GetPointerv(pname, params)
	return		void
	param		pname		GetPointervPName in value
	param		params		VoidPointer out array [1]
	category	1_1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	client get
	glsopcode	0x0142
	offset		329

IndexPointer(type, stride, pointer)
	return		void
	param		type		IndexPointerType in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride)] retained
	category	1_1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	client
	glsopcode	0x0157
	offset		314

InterleavedArrays(format, stride, pointer)
	return		void
	param		format		InterleavedArrayFormat in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(format/stride)] retained
	category	1_1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	client
	glsopcode	0x0158
	offset		317

NormalPointer(type, stride, pointer)
	return		void
	param		type		NormalPointerType in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride)] retained
	category	1_1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	client
	glsopcode	0x0159
	offset		318

TexCoordPointer(size, type, stride, pointer)
	return		void
	param		size		Int32 in value
	param		type		TexCoordPointerType in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(size/type/stride)] retained
	category	1_1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	client
	glsopcode	0x015A
	offset		320

VertexPointer(size, type, stride, pointer)
	return		void
	param		size		Int32 in value
	param		type		VertexPointerType in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(size/type/stride)] retained
	category	1_1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	client
	glsopcode	0x015B
	offset		321

PolygonOffset(factor, units)
	return		void
	param		factor		Float32 in value
	param		units		Float32 in value
	category	1_1
	version		1.1
	glxropcode	192
	glsopcode	0x015C
	offset		319

# Arguably TexelInternalFormat, not PixelInternalFormat
CopyTexImage1D(target, level, internalformat, x, y, width, border)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		border		CheckedInt32 in value
	category	1_1
	version		1.1
	glxropcode	4119
	glxflags	EXT
	glsopcode	0x014D
	offset		323

# Arguably TexelInternalFormat, not PixelInternalFormat
CopyTexImage2D(target, level, internalformat, x, y, width, height, border)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		border		CheckedInt32 in value
	category	1_1
	version		1.1
	glxropcode	4120
	glxflags	EXT
	glsopcode	0x014E
	offset		324

CopyTexSubImage1D(target, level, xoffset, x, y, width)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	category	1_1
	version		1.1
	glxropcode	4121
	glxflags	EXT
	glsopcode	0x014F
	offset		325

CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	category	1_1
	version		1.1
	glxropcode	4122
	glxflags	EXT
	glsopcode	0x0150
	offset		326

TexSubImage1D(target, level, xoffset, width, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width)]
	category	1_1
	dlflags		handcode
	glxflags	EXT client-handcode server-handcode
	version		1.1
	glxropcode	4099
	glsflags	pixel-unpack
	glsopcode	0x0123
	offset		332

TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width/height)]
	category	1_1
	dlflags		handcode
	glxflags	EXT client-handcode server-handcode
	version		1.1
	glxropcode	4100
	glsflags	pixel-unpack
	glsopcode	0x0124
	offset		333

AreTexturesResident(n, textures, residences)
	return		Boolean
	param		n		SizeI in value
	param		textures	Texture in array [n]
	param		residences	Boolean out array [n]
	category	1_1
	glxsingle	143
	dlflags		notlistable
	version		1.1
	glsflags	get
	glsopcode	0x0259
	offset		322

BindTexture(target, texture)
	return		void
	param		target		TextureTarget in value
	param		texture		Texture in value
	category	1_1
	version		1.1
	glxropcode	4117
	glxflags	EXT
	glsopcode	0x0148
	offset		307

DeleteTextures(n, textures)
	return		void
	param		n		SizeI in value
	param		textures	Texture in array [n]
	category	1_1
	dlflags		notlistable
	version		1.1
	glxsingle	144
	glsopcode	0x025A
	offset		327

GenTextures(n, textures)
	return		void
	param		n		SizeI in value
	param		textures	Texture out array [n]
	category	1_1
	dlflags		notlistable
	version		1.1
	glxsingle	145
	glsopcode	0x025B
	offset		328

IsTexture(texture)
	return		Boolean
	param		texture		Texture in value
	category	1_1
	dlflags		notlistable
	version		1.1
	glxsingle	146
	glsflags	get
	glsopcode	0x025C
	offset		330

PrioritizeTextures(n, textures, priorities)
	return		void
	param		n		SizeI in value
	param		textures	Texture in array [n]
	param		priorities	ClampedFloat32 in array [n]
	category	1_1
	version		1.1
	glxropcode	4118
	glxflags	EXT
	glsopcode	0x014C
	offset		331

Indexub(c)
	return		void
	param		c		ColorIndexValueUB in value
	category	1_1
	vectorequiv	Indexubv
	version		1.1
	offset		315

Indexubv(c)
	return		void
	param		c		ColorIndexValueUB in array [1]
	category	1_1
	version		1.1
	glxropcode	194
	glsopcode	0x015D
	offset		316

PopClientAttrib()
	return		void
	category	1_1
	version		1.1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	glsflags	client
	glsopcode	0x015E
	offset		334

PushClientAttrib(mask)
	return		void
	param		mask		ClientAttribMask in value
	category	1_1
	version		1.1
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	glsflags	client
	glsopcode	0x015F
	offset		335

###############################################################################
###############################################################################
#
# OpenGL 1.2 commands
#
###############################################################################
###############################################################################

BlendColor(red, green, blue, alpha)
	return		void
	param		red		ClampedColorF in value
	param		green		ClampedColorF in value
	param		blue		ClampedColorF in value
	param		alpha		ClampedColorF in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4096
	glsopcode	0x0120
	offset		336

BlendEquation(mode)
	return		void
	param		mode		BlendEquationMode in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4097
	glsopcode	0x0121
	offset		337

DrawRangeElements(mode, start, end, count, type, indices)
	return		void
	param		mode		BeginMode in value
	param		start		UInt32 in value
	param		end		UInt32 in value
	param		count		SizeI in value
	param		type		DrawElementsType in value
	param		indices		Void in array [COMPSIZE(count/type)]
	category	VERSION_1_2
	dlflags		handcode
	glxflags	client-handcode client-intercept server-handcode
	version		1.2
	glsopcode	0x0190
	offset		338

# OpenGL 1.2 (SGI_color_table) commands

ColorTable(target, internalformat, width, format, type, table)
	return		void
	param		target		ColorTableTarget in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		table		Void in array [COMPSIZE(format/type/width)]
	category	VERSION_1_2
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.2
	glxropcode	2053
	glsflags	pixel-unpack
	glsopcode	0x0167
	offset		339

ColorTableParameterfv(target, pname, params)
	return		void
	param		target		ColorTableTarget in value
	param		pname		ColorTableParameterPName in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	2054
	glsopcode	0x0168
	offset		340

ColorTableParameteriv(target, pname, params)
	return		void
	param		target		ColorTableTarget in value
	param		pname		ColorTableParameterPName in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	2055
	glsopcode	0x0169
	offset		341

CopyColorTable(target, internalformat, x, y, width)
	return		void
	param		target		ColorTableTarget in value
	param		internalformat	PixelInternalFormat in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	2056
	glsopcode	0x016A
	offset		342

GetColorTable(target, format, type, table)
	return		void
	param		target		ColorTableTarget in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		table		Void out array [COMPSIZE(target/format/type)]
	category	VERSION_1_2
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.2
	glxsingle	147
	glsflags	get pixel-pack
	glsopcode	0x025D
	offset		343

GetColorTableParameterfv(target, pname, params)
	return		void
	param		target		ColorTableTarget in value
	param		pname		GetColorTableParameterPName in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	VERSION_1_2
	dlflags		notlistable
	version		1.2
	glxsingle	148
	glsflags	get
	glsopcode	0x025E
	offset		344

GetColorTableParameteriv(target, pname, params)
	return		void
	param		target		ColorTableTarget in value
	param		pname		GetColorTableParameterPName in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	VERSION_1_2
	dlflags		notlistable
	version		1.2
	glxsingle	149
	glsflags	get
	glsopcode	0x025F
	offset		345

# OpenGL 1.2 (EXT_color_subtable) commands

ColorSubTable(target, start, count, format, type, data)
	return		void
	param		target		ColorTableTarget in value
	param		start		SizeI in value
	param		count		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		data		Void in array [COMPSIZE(format/type/count)]
	category	VERSION_1_2
	dlflags		handcode
	glxflags	client-handcode server-handcode
	version		1.2
	glxropcode	195
	glsflags	pixel-unpack
	glsopcode	0x018E
	offset		346

CopyColorSubTable(target, start, x, y, width)
	return		void
	param		target		ColorTableTarget in value
	param		start		SizeI in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	category	VERSION_1_2
	version		1.2
	glxropcode	196
	glsopcode	0x018F
	offset		347

# OpenGL 1.2 (EXT_convolution) commands

ConvolutionFilter1D(target, internalformat, width, format, type, image)
	return		void
	param		target		ConvolutionTarget in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		image		Void in array [COMPSIZE(format/type/width)]
	category	VERSION_1_2
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.2
	glxropcode	4101
	glsflags	pixel-unpack
	glsopcode	0x0125
	offset		348

ConvolutionFilter2D(target, internalformat, width, height, format, type, image)
	return		void
	param		target		ConvolutionTarget in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		image		Void in array [COMPSIZE(format/type/width/height)]
	category	VERSION_1_2
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.2
	glxropcode	4102
	glsflags	pixel-unpack
	glsopcode	0x0126
	offset		349

ConvolutionParameterf(target, pname, params)
	return		void
	param		target		ConvolutionTarget in value
	param		pname		ConvolutionParameter in value
	param		params		CheckedFloat32 in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4103
	glsflags	gl-enum
	glsopcode	0x0127
	offset		350

ConvolutionParameterfv(target, pname, params)
	return		void
	param		target		ConvolutionTarget in value
	param		pname		ConvolutionParameter in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4104
	glsflags	gl-enum
	glsopcode	0x0128
	offset		351

ConvolutionParameteri(target, pname, params)
	return		void
	param		target		ConvolutionTarget in value
	param		pname		ConvolutionParameter in value
	param		params		CheckedInt32 in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4105
	glsflags	gl-enum
	glsopcode	0x0129
	offset		352

ConvolutionParameteriv(target, pname, params)
	return		void
	param		target		ConvolutionTarget in value
	param		pname		ConvolutionParameter in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4106
	glsflags	gl-enum
	glsopcode	0x012A
	offset		353

CopyConvolutionFilter1D(target, internalformat, x, y, width)
	return		void
	param		target		ConvolutionTarget in value
	param		internalformat	PixelInternalFormat in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4107
	glsopcode	0x012B
	offset		354

CopyConvolutionFilter2D(target, internalformat, x, y, width, height)
	return		void
	param		target		ConvolutionTarget in value
	param		internalformat	PixelInternalFormat in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4108
	glsopcode	0x012C
	offset		355

GetConvolutionFilter(target, format, type, image)
	return		void
	param		target		ConvolutionTarget in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		image		Void out array [COMPSIZE(target/format/type)]
	category	VERSION_1_2
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.2
	glxsingle	150
	glsflags	get pixel-pack
	glsopcode	0x0260
	offset		356

GetConvolutionParameterfv(target, pname, params)
	return		void
	param		target		ConvolutionTarget in value
	param		pname		GetConvolutionParameterPName in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	VERSION_1_2
	dlflags		notlistable
	version		1.2
	glxsingle	151
	glsflags	get
	glsopcode	0x0261
	offset		357

GetConvolutionParameteriv(target, pname, params)
	return		void
	param		target		ConvolutionTarget in value
	param		pname		GetConvolutionParameterPName in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	VERSION_1_2
	dlflags		notlistable
	version		1.2
	glxsingle	152
	glsflags	get
	glsopcode	0x0262
	offset		358

GetSeparableFilter(target, format, type, row, column, span)
	return		void
	param		target		SeparableTarget in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		row		Void out array [COMPSIZE(target/format/type)]
	param		column		Void out array [COMPSIZE(target/format/type)]
	param		span		Void out array [COMPSIZE(target/format/type)]
	category	VERSION_1_2
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.2
	glxsingle	153
	glsflags	get pixel-pack
	glsopcode	0x0263
	offset		359

SeparableFilter2D(target, internalformat, width, height, format, type, row, column)
	return		void
	param		target		SeparableTarget in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		row		Void in array [COMPSIZE(target/format/type/width)]
	param		column		Void in array [COMPSIZE(target/format/type/height)]
	category	VERSION_1_2
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.2
	glxropcode	4109
	glsflags	pixel-unpack
	glsopcode	0x0131
	offset		360

# OpenGL 1.2 (EXT_histogram) commands

GetHistogram(target, reset, format, type, values)
	return		void
	param		target		HistogramTarget in value
	param		reset		Boolean in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		values		Void out array [COMPSIZE(target/format/type)]
	category	VERSION_1_2
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.2
	glxsingle	154
	glsflags	get pixel-pack
	glsopcode	0x0264
	offset		361

GetHistogramParameterfv(target, pname, params)
	return		void
	param		target		HistogramTarget in value
	param		pname		GetHistogramParameterPName in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	VERSION_1_2
	dlflags		notlistable
	version		1.2
	glxsingle	155
	glsflags	get
	glsopcode	0x0265
	offset		362

GetHistogramParameteriv(target, pname, params)
	return		void
	param		target		HistogramTarget in value
	param		pname		GetHistogramParameterPName in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	VERSION_1_2
	dlflags		notlistable
	version		1.2
	glxsingle	156
	glsflags	get
	glsopcode	0x0266
	offset		363

GetMinmax(target, reset, format, type, values)
	return		void
	param		target		MinmaxTarget in value
	param		reset		Boolean in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		values		Void out array [COMPSIZE(target/format/type)]
	category	VERSION_1_2
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.2
	glxsingle	157
	glsflags	get pixel-pack
	glsopcode	0x0267
	offset		364

GetMinmaxParameterfv(target, pname, params)
	return		void
	param		target		MinmaxTarget in value
	param		pname		GetMinmaxParameterPName in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	VERSION_1_2
	dlflags		notlistable
	version		1.2
	glxsingle	158
	glsflags	get
	glsopcode	0x0268
	offset		365

GetMinmaxParameteriv(target, pname, params)
	return		void
	param		target		MinmaxTarget in value
	param		pname		GetMinmaxParameterPName in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	VERSION_1_2
	dlflags		notlistable
	version		1.2
	glxsingle	159
	glsflags	get
	glsopcode	0x0269
	offset		366

Histogram(target, width, internalformat, sink)
	return		void
	param		target		HistogramTarget in value
	param		width		SizeI in value
	param		internalformat	PixelInternalFormat in value
	param		sink		Boolean in value
	category	VERSION_1_2
	dlflags		handcode
	glxflags	EXT
	version		1.2
	glxropcode	4110
	glsopcode	0x0138
	offset		367

Minmax(target, internalformat, sink)
	return		void
	param		target		MinmaxTarget in value
	param		internalformat	PixelInternalFormat in value
	param		sink		Boolean in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4111
	glsopcode	0x0139
	offset		368

ResetHistogram(target)
	return		void
	param		target		HistogramTarget in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4112
	glsopcode	0x013A
	offset		369

ResetMinmax(target)
	return		void
	param		target		MinmaxTarget in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4113
	glsopcode	0x013B
	offset		370

# OpenGL 1.2 (EXT_texture3D) commands

# Arguably TexelInternalFormat, not PixelInternalFormat
TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	TextureComponentCount in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		border		CheckedInt32 in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width/height/depth)]
	category	VERSION_1_2
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.2
	glxropcode	4114
	glsflags	pixel-null pixel-unpack
	glsopcode	0x013C
	offset		371

TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		zoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width/height/depth)]
	category	VERSION_1_2
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.2
	glxropcode	4115
	glsflags	pixel-unpack
	glsopcode	0x013D
	offset		372

# OpenGL 1.2 (EXT_copy_texture) commands (specific to texture3D)

CopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		zoffset		CheckedInt32 in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	category	VERSION_1_2
	glxflags	EXT
	version		1.2
	glxropcode	4123
	glsopcode	0x0151
	offset		373

###############################################################################
###############################################################################
#
# OpenGL 1.3 commands
#
###############################################################################
###############################################################################

# OpenGL 1.3 (ARB_multitexture) commands

ActiveTexture(texture)
	return		void
	param		texture		TextureUnit in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	197
	glsopcode	0x01B1
	offset		374

ClientActiveTexture(texture)
	return		void
	param		texture		TextureUnit in value
	category	VERSION_1_3
	dlflags		notlistable
	glxflags	ARB client-handcode client-intercept server-handcode
	version		1.3
	glsflags	client
	glsopcode	0x01B2
	offset		375

MultiTexCoord1d(target, s)
	return		void
	param		target		TextureUnit in value
	param		s		CoordD in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord1dv
	offset		376

MultiTexCoord1dv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordD in array [1]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	198
	glsopcode	0x01B3
	offset		377

MultiTexCoord1f(target, s)
	return		void
	param		target		TextureUnit in value
	param		s		CoordF in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord1fv
	offset		378

MultiTexCoord1fv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordF in array [1]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	199
	glsopcode	0x01B4
	offset		379

MultiTexCoord1i(target, s)
	return		void
	param		target		TextureUnit in value
	param		s		CoordI in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord1iv
	offset		380

MultiTexCoord1iv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordI in array [1]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	200
	glsopcode	0x01B5
	offset		381

MultiTexCoord1s(target, s)
	return		void
	param		target		TextureUnit in value
	param		s		CoordS in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord1sv
	offset		382

MultiTexCoord1sv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordS in array [1]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	201
	glsopcode	0x01B6
	offset		383

MultiTexCoord2d(target, s, t)
	return		void
	param		target		TextureUnit in value
	param		s		CoordD in value
	param		t		CoordD in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord2dv
	offset		384

MultiTexCoord2dv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordD in array [2]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	202
	glsopcode	0x01B7
	offset		385

MultiTexCoord2f(target, s, t)
	return		void
	param		target		TextureUnit in value
	param		s		CoordF in value
	param		t		CoordF in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord2fv
	offset		386

MultiTexCoord2fv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordF in array [2]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	203
	glsopcode	0x01B8
	offset		387

MultiTexCoord2i(target, s, t)
	return		void
	param		target		TextureUnit in value
	param		s		CoordI in value
	param		t		CoordI in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord2iv
	offset		388

MultiTexCoord2iv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordI in array [2]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	204
	glsopcode	0x01B9
	offset		389

MultiTexCoord2s(target, s, t)
	return		void
	param		target		TextureUnit in value
	param		s		CoordS in value
	param		t		CoordS in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord2sv
	offset		390

MultiTexCoord2sv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordS in array [2]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	205
	glsopcode	0x01BA
	offset		391

MultiTexCoord3d(target, s, t, r)
	return		void
	param		target		TextureUnit in value
	param		s		CoordD in value
	param		t		CoordD in value
	param		r		CoordD in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord3dv
	offset		392

MultiTexCoord3dv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordD in array [3]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	206
	glsopcode	0x01BB
	offset		393

MultiTexCoord3f(target, s, t, r)
	return		void
	param		target		TextureUnit in value
	param		s		CoordF in value
	param		t		CoordF in value
	param		r		CoordF in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord3fv
	offset		394

MultiTexCoord3fv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordF in array [3]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	207
	glsopcode	0x01BC
	offset		395

MultiTexCoord3i(target, s, t, r)
	return		void
	param		target		TextureUnit in value
	param		s		CoordI in value
	param		t		CoordI in value
	param		r		CoordI in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord3iv
	offset		396

MultiTexCoord3iv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordI in array [3]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	208
	glsopcode	0x01BD
	offset		397

MultiTexCoord3s(target, s, t, r)
	return		void
	param		target		TextureUnit in value
	param		s		CoordS in value
	param		t		CoordS in value
	param		r		CoordS in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord3sv
	offset		398

MultiTexCoord3sv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordS in array [3]
	category	VERSION_1_3
	version		1.3
	glxflags	ARB
	glxropcode	209
	glsopcode	0x01BE
	offset		399

MultiTexCoord4d(target, s, t, r, q)
	return		void
	param		target		TextureUnit in value
	param		s		CoordD in value
	param		t		CoordD in value
	param		r		CoordD in value
	param		q		CoordD in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord4dv
	offset		400

MultiTexCoord4dv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordD in array [4]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	210
	glsopcode	0x01BF
	offset		401

MultiTexCoord4f(target, s, t, r, q)
	return		void
	param		target		TextureUnit in value
	param		s		CoordF in value
	param		t		CoordF in value
	param		r		CoordF in value
	param		q		CoordF in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord4fv
	offset		402

MultiTexCoord4fv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordF in array [4]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	211
	glsopcode	0x01C0
	offset		403

MultiTexCoord4i(target, s, t, r, q)
	return		void
	param		target		TextureUnit in value
	param		s		CoordI in value
	param		t		CoordI in value
	param		r		CoordI in value
	param		q		CoordI in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord4iv
	offset		404

MultiTexCoord4iv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordI in array [4]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	212
	glsopcode	0x01C1
	offset		405

MultiTexCoord4s(target, s, t, r, q)
	return		void
	param		target		TextureUnit in value
	param		s		CoordS in value
	param		t		CoordS in value
	param		r		CoordS in value
	param		q		CoordS in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	vectorequiv	MultiTexCoord4sv
	offset		406

MultiTexCoord4sv(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordS in array [4]
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	213
	glsopcode	0x01C2
	offset		407

# OpenGL 1.3 (ARB_transpose_matrix) commands

LoadTransposeMatrixf(m)
	return		void
	param		m		Float32 in array [16]
	category	VERSION_1_3
	glxflags	ARB client-handcode client-intercept server-handcode
	version		1.3
	glsflags	matrix
	glsopcode	0x01C3
	offset		408

LoadTransposeMatrixd(m)
	return		void
	param		m		Float64 in array [16]
	category	VERSION_1_3
	glxflags	ARB client-handcode client-intercept server-handcode
	version		1.3
	glsflags	matrix
	glsopcode	0x01C4
	offset		409

MultTransposeMatrixf(m)
	return		void
	param		m		Float32 in array [16]
	category	VERSION_1_3
	glxflags	ARB client-handcode client-intercept server-handcode
	version		1.3
	glsflags	matrix
	glsopcode	0x01C5
	offset		410

MultTransposeMatrixd(m)
	return		void
	param		m		Float64 in array [16]
	category	VERSION_1_3
	glxflags	ARB client-handcode client-intercept server-handcode
	version		1.3
	glsflags	matrix
	glsopcode	0x01C6
	offset		411

# OpenGL 1.3 (ARB_multisample) commands

SampleCoverage(value, invert)
	return		void
	param		value		ClampedFloat32 in value
	param		invert		Boolean in value
	category	VERSION_1_3
	glxflags	ARB
	version		1.3
	glxropcode	229
	glsopcode	0x01C7
	offset		412

# OpenGL 1.3 (ARB_texture_compression) commands

# Arguably TexelInternalFormat, not PixelInternalFormat
CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		border		CheckedInt32 in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	VERSION_1_3
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.3
	glxropcode	216
	glsopcode	0x01C9
	wglflags	client-handcode server-handcode
	offset		554

# Arguably TexelInternalFormat, not PixelInternalFormat
CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		border		CheckedInt32 in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	VERSION_1_3
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.3
	glxropcode	215
	glsopcode	0x01CA
	wglflags	client-handcode server-handcode
	offset		555

# Arguably TexelInternalFormat, not PixelInternalFormat
CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		border		CheckedInt32 in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	VERSION_1_3
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.3
	glxropcode	214
	glsopcode	0x01CB
	wglflags	client-handcode server-handcode
	offset		556

CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		zoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		format		PixelFormat in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	VERSION_1_3
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.3
	glxropcode	219
	glsopcode	0x01CC
	wglflags	client-handcode server-handcode
	offset		557

CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	VERSION_1_3
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.3
	glxropcode	218
	glsopcode	0x01CD
	wglflags	client-handcode server-handcode
	offset		558

CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	VERSION_1_3
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.3
	glxropcode	217
	glsopcode	0x01CE
	wglflags	client-handcode server-handcode
	offset		559

GetCompressedTexImage(target, level, img)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		img		CompressedTextureARB out array [COMPSIZE(target/level)]
	category	VERSION_1_3
	dlflags		notlistable
	glxflags	ARB client-handcode server-handcode
	version		1.3
	glxsingle	160
	glsflags	get
	glsopcode	0x01CF
	wglflags	client-handcode server-handcode
	offset		560


###############################################################################
###############################################################################
#
# OpenGL 1.4 commands
#
###############################################################################
###############################################################################

# OpenGL 1.4 (EXT_blend_func_separate) commands

BlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha)
	return		void
	param		sfactorRGB	BlendFuncSeparateParameterEXT in value
	param		dfactorRGB	BlendFuncSeparateParameterEXT in value
	param		sfactorAlpha	BlendFuncSeparateParameterEXT in value
	param		dfactorAlpha	BlendFuncSeparateParameterEXT in value
	category	VERSION_1_4
	glxropcode	4134
	version		1.4
	extension
	glsopcode	0x01DC
	offset		537

# OpenGL 1.4 (EXT_fog_coord) commands

FogCoordf(coord)
	return		void
	param		coord		CoordF in value
	category	VERSION_1_4
	vectorequiv	FogCoordfv
	version		1.4
	offset		545

FogCoordfv(coord)
	return		void
	param		coord		CoordF in array [1]
	category	VERSION_1_4
	version		1.4
	glxropcode	4124
	glsopcode	0x01D8
	offset		546

FogCoordd(coord)
	return		void
	param		coord		CoordD in value
	category	VERSION_1_4
	vectorequiv	FogCoorddv
	version		1.4
	offset		547

FogCoorddv(coord)
	return		void
	param		coord		CoordD in array [1]
	category	VERSION_1_4
	version		1.4
	glxropcode	4125
	glsopcode	0x01DA
	offset		548

FogCoordPointer(type, stride, pointer)
	return		void
	param		type		FogPointerTypeEXT in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride)] retained
	category	VERSION_1_4
	dlflags		notlistable
	version		1.4
	glxflags	client-handcode server-handcode
	glsflags	client
	glsopcode	0x01DB
	offset		549

# OpenGL 1.4 (EXT_multi_draw_arrays) commands

# first and count are really 'in'
MultiDrawArrays(mode, first, count, primcount)
	return		void
	param		mode		BeginMode in value
	param		first		Int32 out array [COMPSIZE(count)]
	param		count		SizeI out array [COMPSIZE(primcount)]
	param		primcount	SizeI in value
	category	VERSION_1_4
	version		1.4
	glxropcode	?
	glsflags	ignore
	offset		644

MultiDrawElements(mode, count, type, indices, primcount)
	return		void
	param		mode		BeginMode in value
	param		count		SizeI in array [COMPSIZE(primcount)]
	param		type		DrawElementsType in value
	param		indices		VoidPointer in array [COMPSIZE(primcount)]
	param		primcount	SizeI in value
	category	VERSION_1_4
	version		1.4
	glxropcode	?
	glsflags	ignore
	offset		645

# OpenGL 1.4 (ARB_point_parameters, NV_point_sprite) commands

PointParameterf(pname, param)
	return		void
	param		pname		PointParameterNameARB in value
	param		param		CheckedFloat32 in value
	category	VERSION_1_4
	version		1.4
	glxropcode	2065
	extension
	glsopcode	0x0177
	offset		458

PointParameterfv(pname, params)
	return		void
	param		pname		PointParameterNameARB in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	VERSION_1_4
	version		1.4
	glxropcode	2066
	extension
	glsopcode	0x0178
	offset		459

PointParameteri(pname, param)
	return		void
	param		pname		PointParameterNameARB in value
	param		param		Int32 in value
	category	VERSION_1_4
	version		1.4
	extension	soft WINSOFT NV20
	glxropcode	4221
	glsflags	ignore
	offset		642

PointParameteriv(pname, params)
	return		void
	param		pname		PointParameterNameARB in value
	param		params		Int32 in array [COMPSIZE(pname)]
	category	VERSION_1_4
	version		1.4
	extension	soft WINSOFT NV20
	glxropcode	4222re
	glsflags	ignore
	offset		643

# OpenGL 1.4 (EXT_secondary_color) commands

SecondaryColor3b(red, green, blue)
	return		void
	param		red		ColorB in value
	param		green		ColorB in value
	param		blue		ColorB in value
	category	VERSION_1_4
	vectorequiv	SecondaryColor3bv
	version		1.4
	offset		561

SecondaryColor3bv(v)
	return		void
	param		v		ColorB in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	4126
	glsopcode	0x01FD
	offset		562

SecondaryColor3d(red, green, blue)
	return		void
	param		red		ColorD in value
	param		green		ColorD in value
	param		blue		ColorD in value
	category	VERSION_1_4
	vectorequiv	SecondaryColor3dv
	version		1.4
	offset		563

SecondaryColor3dv(v)
	return		void
	param		v		ColorD in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	4130
	glsopcode	0x01FE
	offset		564

SecondaryColor3f(red, green, blue)
	return		void
	param		red		ColorF in value
	param		green		ColorF in value
	param		blue		ColorF in value
	category	VERSION_1_4
	vectorequiv	SecondaryColor3fv
	version		1.4
	offset		565

SecondaryColor3fv(v)
	return		void
	param		v		ColorF in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	4129
	glsopcode	0x01FF
	offset		566

SecondaryColor3i(red, green, blue)
	return		void
	param		red		ColorI in value
	param		green		ColorI in value
	param		blue		ColorI in value
	category	VERSION_1_4
	vectorequiv	SecondaryColor3iv
	version		1.4
	offset		567

SecondaryColor3iv(v)
	return		void
	param		v		ColorI in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	4128
	glsopcode	0x0200
	offset		568

SecondaryColor3s(red, green, blue)
	return		void
	param		red		ColorS in value
	param		green		ColorS in value
	param		blue		ColorS in value
	category	VERSION_1_4
	vectorequiv	SecondaryColor3sv
	version		1.4
	offset		569

SecondaryColor3sv(v)
	return		void
	param		v		ColorS in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	4127
	glsopcode	0x0201
	offset		570

SecondaryColor3ub(red, green, blue)
	return		void
	param		red		ColorUB in value
	param		green		ColorUB in value
	param		blue		ColorUB in value
	category	VERSION_1_4
	vectorequiv	SecondaryColor3ubv
	version		1.4
	offset		571

SecondaryColor3ubv(v)
	return		void
	param		v		ColorUB in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	4131
	glsopcode	0x0202
	offset		572

SecondaryColor3ui(red, green, blue)
	return		void
	param		red		ColorUI in value
	param		green		ColorUI in value
	param		blue		ColorUI in value
	category	VERSION_1_4
	vectorequiv	SecondaryColor3uiv
	version		1.4
	offset		573

SecondaryColor3uiv(v)
	return		void
	param		v		ColorUI in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	4133
	glsopcode	0x0203
	offset		574

SecondaryColor3us(red, green, blue)
	return		void
	param		red		ColorUS in value
	param		green		ColorUS in value
	param		blue		ColorUS in value
	category	VERSION_1_4
	vectorequiv	SecondaryColor3usv
	version		1.4
	offset		575

SecondaryColor3usv(v)
	return		void
	param		v		ColorUS in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	4132
	glsopcode	0x0204
	offset		576

SecondaryColorPointer(size, type, stride, pointer)
	return		void
	param		size		Int32 in value
	param		type		ColorPointerType in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(size/type/stride)] retained
	category	VERSION_1_4
	dlflags		notlistable
	glxflags	client-handcode server-handcode
	version		1.4
	extension
	glsflags	client
	glsopcode	0x0205
	offset		577

# OpenGL 1.4 (ARB_window_pos) commands
# Note: all WindowPos* entry points use glxropcode ropcode 230, with 3 float parameters

WindowPos2d(x, y)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	category	VERSION_1_4
	vectorequiv	WindowPos2dv
	version		1.4
	offset		513

WindowPos2dv(v)
	return		void
	param		v		CoordD in array [2]
	category	VERSION_1_4
	version		1.4
	glxropcode	230
	glxflags	client-handcode server-handcode
	glsopcode	0x01F0
	offset		514

WindowPos2f(x, y)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	category	VERSION_1_4
	vectorequiv	WindowPos2fv
	version		1.4
	offset		515

WindowPos2fv(v)
	return		void
	param		v		CoordF in array [2]
	category	VERSION_1_4
	version		1.4
	glxropcode	230
	glxflags	client-handcode server-handcode
	glsopcode	0x01F1
	offset		516

WindowPos2i(x, y)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	category	VERSION_1_4
	vectorequiv	WindowPos2iv
	version		1.4
	offset		517

WindowPos2iv(v)
	return		void
	param		v		CoordI in array [2]
	category	VERSION_1_4
	version		1.4
	glxropcode	230
	glxflags	client-handcode server-handcode
	glsopcode	0x01F2
	offset		518

WindowPos2s(x, y)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	category	VERSION_1_4
	vectorequiv	WindowPos2sv
	version		1.4
	offset		519

WindowPos2sv(v)
	return		void
	param		v		CoordS in array [2]
	category	VERSION_1_4
	version		1.4
	glxropcode	230
	glxflags	client-handcode server-handcode
	glsopcode	0x01F3
	offset		520

WindowPos3d(x, y, z)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	param		z		CoordD in value
	vectorequiv	WindowPos3dv
	category	VERSION_1_4
	version		1.4
	offset		521

WindowPos3dv(v)
	return		void
	param		v		CoordD in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	230
	glxflags	client-handcode server-handcode
	glsopcode	0x01F4
	offset		522

WindowPos3f(x, y, z)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	param		z		CoordF in value
	category	VERSION_1_4
	vectorequiv	WindowPos3fv
	version		1.4
	offset		523

WindowPos3fv(v)
	return		void
	param		v		CoordF in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	230
	glxflags	client-handcode server-handcode
	glsopcode	0x01F5
	offset		524

WindowPos3i(x, y, z)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	param		z		CoordI in value
	category	VERSION_1_4
	vectorequiv	WindowPos3iv
	version		1.4
	offset		525

WindowPos3iv(v)
	return		void
	param		v		CoordI in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	230
	glxflags	client-handcode server-handcode
	glsopcode	0x01F6
	offset		526

WindowPos3s(x, y, z)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	param		z		CoordS in value
	category	VERSION_1_4
	vectorequiv	WindowPos3sv
	version		1.4
	offset		527

WindowPos3sv(v)
	return		void
	param		v		CoordS in array [3]
	category	VERSION_1_4
	version		1.4
	glxropcode	230
	glxflags	client-handcode server-handcode
	glsopcode	0x01F7
	offset		528


###############################################################################
###############################################################################
#
# OpenGL 1.5 commands
#
###############################################################################
###############################################################################

# OpenGL 1.5 (ARB_occlusion_query) commands

GenQueries(n, ids)
	return		void
	param		n		SizeI in value
	param		ids		UInt32 out array [n]
	category	VERSION_1_5
	version		1.5
	extension
	glxsingle	162
	glxflags	ignore
	glsopcode	?
	offset		700

DeleteQueries(n, ids)
	return		void
	param		n		SizeI in value
	param		ids		UInt32 in array [n]
	category	VERSION_1_5
	version		1.5
	extension
	glxsingle	161
	glxflags	ignore
	glsopcode	?
	offset		701

IsQuery(id)
	return		Boolean
	param		id		UInt32 in value
	category	VERSION_1_5
	version		1.5
	extension
	glxsingle	163
	glxflags	ignore
	glsopcode	?
	offset		702

BeginQuery(target, id)
	return		void
	param		target		GLenum in value
	param		id		UInt32 in value
	category	VERSION_1_5
	version		1.5
	extension
	glxropcode	231
	glxflags	ignore
	glsopcode	?
	offset		703

EndQuery(target)
	return		void
	param		target		GLenum in value
	category	VERSION_1_5
	version		1.5
	extension
	glxropcode	232
	glxflags	ignore
	glsopcode	?
	offset		704

GetQueryiv(target, pname, params)
	return		void
	param		target		GLenum in value
	param		pname		GLenum in value
	param		params		Int32 out array [pname]
	category	VERSION_1_5
	dlflags		notlistable
	version		1.5
	extension
	glxsingle	164
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		705

GetQueryObjectiv(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		GLenum in value
	param		params		Int32 out array [pname]
	category	VERSION_1_5
	dlflags		notlistable
	version		1.5
	extension
	glxsingle	165
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		706

GetQueryObjectuiv(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		GLenum in value
	param		params		UInt32 out array [pname]
	category	VERSION_1_5
	dlflags		notlistable
	version		1.5
	extension
	glxsingle	166
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		707

# OpenGL 1.5 (ARB_vertex_buffer_object) commands

BindBuffer(target, buffer)
	return		void
	param		target		VertexBufferTargetARB in value
	param		buffer		UInt32 in value
	category	VERSION_1_5
	version		1.5
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		688

DeleteBuffers(n, buffers)
	return		void
	param		n		SizeI in value
	param		buffers		ConstUInt32 in array [n]
	category	VERSION_1_5
	version		1.5
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		691

GenBuffers(n, buffers)
	return		void
	param		n		SizeI in value
	param		buffers		UInt32 out array [n]
	category	VERSION_1_5
	version		1.5
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		692

IsBuffer(buffer)
	return		Boolean
	param		buffer		UInt32 in value
	category	VERSION_1_5
	version		1.5
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		696

BufferData(target, size, data, usage)
	return		void
	param		target		VertexBufferTargetARB in value
	param		size		VertexBufferSize in value
	param		data		ConstVoid in array [size]
	param		usage		VertexBufferUsageARB in value
	category	VERSION_1_5
	version		1.5
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		689

BufferSubData(target, offset, size, data)
	return		void
	param		target		VertexBufferTargetARB in value
	param		offset		VertexBufferOffset in value
	param		size		VertexBufferSize in value
	param		data		ConstVoid in array [size]
	category	VERSION_1_5
	version		1.5
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		690

GetBufferSubData(target, offset, size, data)
	return		void
	param		target		VertexBufferTargetARB in value
	param		offset		VertexBufferOffset in value
	param		size		VertexBufferSize in value
	param		data		Void out array [size]
	category	VERSION_1_5
	dlflags		notlistable
	version		1.5
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		695

MapBuffer(target, access)
	return		VoidPointer
	param		target		VertexBufferTargetARB in value
	param		access		VertexBufferAccessARB in value
	category	VERSION_1_5
	version		1.5
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		697

UnmapBuffer(target)
	return		Boolean
	param		target		VertexBufferTargetARB in value
	category	VERSION_1_5
	version		1.5
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		698

GetBufferParameteriv(target, pname, params)
	return		void
	param		target		VertexBufferTargetARB in value
	param		pname		VertexBufferPNameARB in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	VERSION_1_5
	dlflags		notlistable
	version		1.5
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		693

GetBufferPointerv(target, pname, params)
	return		void
	param		target		VertexBufferTargetARB in value
	param		pname		VertexBufferPointerNameARB in value
	param		params		VoidPointer out array [1]
	category	VERSION_1_5
	dlflags		notlistable
	version		1.5
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		694

# OpenGL 1.5 (EXT_shadow_funcs) commands - none


###############################################################################
###############################################################################
#
# OpenGL 2.0 commands
#
###############################################################################
###############################################################################

# OpenGL 2.0 (EXT_blend_equation_separate) commands

BlendEquationSeparate(modeRGB, modeAlpha)
	return		void
	param		modeRGB		BlendEquationModeEXT in value
	param		modeAlpha	BlendEquationModeEXT in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	4228
	glsopcode	?

# OpenGL 2.0 (ARB_draw_buffers) commands

DrawBuffers(n, bufs)
	return		void
	param		n		SizeI in value
	param		bufs		DrawBufferModeATI in array [n]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	233
	glxflags	ignore
	glsopcode	?
	offset		?

# OpenGL 2.0 (ARB_stencil_two_side) commands

StencilOpSeparate(face, sfail, dpfail, dppass)
	return		void
	param		face		StencilFaceDirection in value
	param		sfail		StencilOp in value
	param		dpfail		StencilOp in value
	param		dppass		StencilOp in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

StencilFuncSeparate(frontfunc, backfunc, ref, mask)
	return		void
	param		frontfunc	StencilFunction in value
	param		backfunc	StencilFunction in value
	param		ref		ClampedStencilValue in value
	param		mask		MaskedStencilValue in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

StencilMaskSeparate(face, mask)
	return		void
	param		face		StencilFaceDirection in value
	param		mask		MaskedStencilValue in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

# OpenGL 2.0 (ARB_shader_objects / ARB_vertex_shader / ARB_fragment_shader) commands

AttachShader(program, shader)
	return		void
	param		program		UInt32 in value
	param		shader		UInt32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

BindAttribLocation(program, index, name)
	return		void
	param		program		UInt32 in value
	param		index		UInt32 in value
	param		name		Char in array []
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

CompileShader(shader)
	return		void
	param		shader		UInt32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

CreateProgram()
	return		UInt32
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

CreateShader(type)
	return		UInt32
	param		type		GLenum in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

DeleteProgram(program)
	return		void
	param		program		UInt32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

DeleteShader(shader)
	return		void
	param		shader		UInt32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

DetachShader(program, shader)
	return		void
	param		program		UInt32 in value
	param		shader		UInt32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

DisableVertexAttribArray(index)
	return		void
	param		index		UInt32 in value
	dlflags		notlistable
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		666

EnableVertexAttribArray(index)
	return		void
	param		index		UInt32 in value
	dlflags		notlistable
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		665

GetActiveAttrib(program, index, bufSize, length, size, type, name)
	return		void
	param		program		UInt32 in value
	param		index		UInt32 in value
	param		bufSize		SizeI in value
	param		length		SizeI out array [1]
	param		size		Int32 out array [1]
	param		type		GLenum out array [1]
	param		name		Char out array []
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetActiveUniform(program, index, bufSize, length, size, type, name)
	return		void
	param		program		UInt32 in value
	param		index		UInt32 in value
	param		bufSize		SizeI in value
	param		length		SizeI out array [1]
	param		size		Int32 out array [1]
	param		type		GLenum out array [1]
	param		name		Char out array []
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetAttachedShaders(program, maxCount, count, obj)
	return		void
	param		program		UInt32 in value
	param		maxCount	SizeI in value
	param		count		SizeI out array [1]
	param		obj		UInt32 out array [count]
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetAttribLocation(program, name)
	return		Int32
	param		program		UInt32 in value
	param		name		Char in array []
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetProgramiv(program, pname, params)
	return		void
	param		program		UInt32 in value
	param		pname		GLenum in value
	param		params		Int32 out array [pname]
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetProgramInfoLog(program, bufSize, length, infoLog)
	return		void
	param		program		UInt32 in value
	param		bufSize		SizeI in value
	param		length		SizeI out array [1]
	param		infoLog		Char out array [length]
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetShaderiv(shader, pname, params)
	return		void
	param		shader		UInt32 in value
	param		pname		GLenum in value
	param		params		Int32 out array [pname]
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetShaderInfoLog(shader, bufSize, length, infoLog)
	return		void
	param		shader		UInt32 in value
	param		bufSize		SizeI in value
	param		length		SizeI out array [1]
	param		infoLog		Char out array [length]
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetShaderSource(shader, bufSize, length, source)
	return		void
	param		shader		UInt32 in value
	param		bufSize		SizeI in value
	param		length		SizeI out array [1]
	param		source		Char out array [length]
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetUniformLocation(program, name)
	return		Int32
	param		program		UInt32 in value
	param		name		Char in array []
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetUniformfv(program, location, params)
	return		void
	param		program		UInt32 in value
	param		location	Int32 in value
	param		params		Float32 out array [location]
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetUniformiv(program, location, params)
	return		void
	param		program		UInt32 in value
	param		location	Int32 in value
	param		params		Int32 out array [location]
	category	VERSION_2_0
	dlflags		notlistable
	version		2.0
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetVertexAttribdv(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribPropertyARB in value
	param		params		Float64 out array [4]
	dlflags		notlistable
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxvendorpriv	1301
	glsflags	client get
	glsopcode	0x0232
	offset		588

GetVertexAttribfv(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribPropertyARB in value
	param		params		Float32 out array [4]
	dlflags		notlistable
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxvendorpriv	1302
	glsflags	client get
	glsopcode	0x0233
	offset		589

GetVertexAttribiv(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribPropertyARB in value
	param		params		Int32 out array [4]
	dlflags		notlistable
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxvendorpriv	1303
	glsflags	client get
	glsopcode	0x0234
	offset		590

GetVertexAttribPointerv(index, pname, pointer)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribPointerPropertyARB in value
	param		pointer		VoidPointer out array [1]
	dlflags		notlistable
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	client get
	glsopcode	0x0235
	offset		591

IsProgram(program)
	return		Boolean
	param		program		UInt32 in value
	dlflags		notlistable
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxvendorpriv	1304
	glsflags	get
	glsopcode	0x0236
	offset		592

IsShader(shader)
	return		Boolean
	param		shader		UInt32 in value
	dlflags		notlistable
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxvendorpriv	?
	glsflags	get
	glsopcode	?
	offset		?

LinkProgram(program)
	return		void
	param		program		UInt32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

ShaderSource(shader, count, string, length)
	return		void
	param		shader		UInt32 in value
	param		count		SizeI in value
	param		string		CharPointer in array [count]
	param		length		Int32 in array [1]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

UseProgram(program)
	return		void
	param		program		UInt32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform1f(location, v0)
	return		void
	param		location	Int32 in value
	param		v0		Float32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform2f(location, v0, v1)
	return		void
	param		location	Int32 in value
	param		v0		Float32 in value
	param		v1		Float32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform3f(location, v0, v1, v2)
	return		void
	param		location	Int32 in value
	param		v0		Float32 in value
	param		v1		Float32 in value
	param		v2		Float32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform4f(location, v0, v1, v2, v3)
	return		void
	param		location	Int32 in value
	param		v0		Float32 in value
	param		v1		Float32 in value
	param		v2		Float32 in value
	param		v3		Float32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform1i(location, v0)
	return		void
	param		location	Int32 in value
	param		v0		Int32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform2i(location, v0, v1)
	return		void
	param		location	Int32 in value
	param		v0		Int32 in value
	param		v1		Int32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform3i(location, v0, v1, v2)
	return		void
	param		location	Int32 in value
	param		v0		Int32 in value
	param		v1		Int32 in value
	param		v2		Int32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform4i(location, v0, v1, v2, v3)
	return		void
	param		location	Int32 in value
	param		v0		Int32 in value
	param		v1		Int32 in value
	param		v2		Int32 in value
	param		v3		Int32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform1fv(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Float32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform2fv(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Float32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform3fv(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Float32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform4fv(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Float32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform1iv(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Int32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform2iv(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Int32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform3iv(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Int32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Uniform4iv(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Int32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

UniformMatrix2fv(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

UniformMatrix3fv(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

UniformMatrix4fv(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [count]
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

ValidateProgram(program)
	return		void
	param		program		UInt32 in value
	category	VERSION_2_0
	version		2.0
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttrib1d(index, x)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib1dv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		603

VertexAttrib1dv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [1]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4197
	glsopcode	0x0240
	offset		604

VertexAttrib1f(index, x)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib1fv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		605

VertexAttrib1fv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [1]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4193
	glsopcode	0x023F
	offset		606

VertexAttrib1s(index, x)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib1sv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		607

VertexAttrib1sv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [1]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4189
	glsopcode	0x023E
	offset		608

VertexAttrib2d(index, x, y)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib2dv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		609

VertexAttrib2dv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [2]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4198
	glsopcode	0x0243
	offset		610

VertexAttrib2f(index, x, y)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib2fv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		611

VertexAttrib2fv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [2]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4194
	glsopcode	0x0242
	offset		612

VertexAttrib2s(index, x, y)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	param		y		Int16 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib2sv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		613

VertexAttrib2sv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [2]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4190
	glsopcode	0x0241
	offset		614

VertexAttrib3d(index, x, y, z)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib3dv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		615

VertexAttrib3dv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [3]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4199
	glsopcode	0x0246
	offset		616

VertexAttrib3f(index, x, y, z)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib3fv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		617

VertexAttrib3fv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [3]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4195
	glsopcode	0x0245
	offset		618

VertexAttrib3s(index, x, y, z)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	param		y		Int16 in value
	param		z		Int16 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib3sv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		619

VertexAttrib3sv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [3]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4191
	glsopcode	0x0244
	offset		620

VertexAttrib4Nbv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int8 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		659

VertexAttrib4Niv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int32 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		661

VertexAttrib4Nsv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		660

VertexAttrib4Nub(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		UInt8 in value
	param		y		UInt8 in value
	param		z		UInt8 in value
	param		w		UInt8 in value
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		627

VertexAttrib4Nubv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt8 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	glxropcode	4201
	glsopcode	0x024A
	offset		628

VertexAttrib4Nuiv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt32 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		663

VertexAttrib4Nusv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt16 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		662

VertexAttrib4bv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int8 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		654

VertexAttrib4d(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	param		w		Float64 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib4dv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		621

VertexAttrib4dv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4200
	glsopcode	0x0249
	offset		622

VertexAttrib4f(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	param		w		Float32 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib4fv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		623

VertexAttrib4fv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glxropcode	4196
	glsopcode	0x0248
	offset		624

VertexAttrib4iv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int32 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		655

VertexAttrib4s(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	param		y		Int16 in value
	param		z		Int16 in value
	param		w		Int16 in value
	category	VERSION_2_0
	version		2.0
	vectorequiv	VertexAttrib4sv
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		625

VertexAttrib4sv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	glxropcode	4192
	glsopcode	0x0247
	offset		626

VertexAttrib4ubv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt8 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		656

VertexAttrib4uiv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt32 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		658

VertexAttrib4usv(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt16 in array [4]
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		657

VertexAttribPointer(index, size, type, normalized, stride, pointer)
	return		void
	param		index		UInt32 in value
	param		size		Int32 in value
	param		type		VertexAttribPointerTypeARB in value
	param		normalized	Boolean in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(size/type/stride)] retained
	dlflags		notlistable
	category	VERSION_2_0
	version		2.0
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		664


###############################################################################
###############################################################################
#
# OpenGL 2.1 commands
#
###############################################################################
###############################################################################

# OpenGL 2.1 (ARB_pixel_buffer_object) commands - none

# OpenGL 2.1 (EXT_texture_sRGB) commands - none

# New commands in OpenGL 2.1
UniformMatrix2x3fv(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [6]
	category	VERSION_2_1
	version		2.1
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

UniformMatrix3x2fv(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [6]
	category	VERSION_2_1
	version		2.1
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

UniformMatrix2x4fv(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [8]
	category	VERSION_2_1
	version		2.1
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

UniformMatrix4x2fv(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [8]
	category	VERSION_2_1
	version		2.1
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

UniformMatrix3x4fv(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [12]
	category	VERSION_2_1
	version		2.1
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

UniformMatrix4x3fv(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [12]
	category	VERSION_2_1
	version		2.1
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?



###############################################################################
###############################################################################
#
# ARB extensions, in order by ARB extension number
#
###############################################################################
###############################################################################

###############################################################################
#
# ARB Extension #1
# ARB_multitexture commands
#
###############################################################################

ActiveTextureARB(texture)
	return		void
	param		texture		TextureUnit in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	197
	alias		ActiveTexture
	glsalias	ActiveTexture

ClientActiveTextureARB(texture)
	return		void
	param		texture		TextureUnit in value
	category	ARB_multitexture
	dlflags		notlistable
	glxflags	ARB client-handcode client-intercept server-handcode
	version		1.2
	alias		ClientActiveTexture
	glsalias	ClientActiveTexture

MultiTexCoord1dARB(target, s)
	return		void
	param		target		TextureUnit in value
	param		s		CoordD in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord1dv

MultiTexCoord1dvARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordD in array [1]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	198
	alias		MultiTexCoord1dv
	glsalias	MultiTexCoord1dv

MultiTexCoord1fARB(target, s)
	return		void
	param		target		TextureUnit in value
	param		s		CoordF in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord1fv

MultiTexCoord1fvARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordF in array [1]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	199
	alias		MultiTexCoord1fv
	glsalias	MultiTexCoord1fv

MultiTexCoord1iARB(target, s)
	return		void
	param		target		TextureUnit in value
	param		s		CoordI in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord1iv

MultiTexCoord1ivARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordI in array [1]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	200
	alias		MultiTexCoord1iv
	glsalias	MultiTexCoord1iv

MultiTexCoord1sARB(target, s)
	return		void
	param		target		TextureUnit in value
	param		s		CoordS in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord1sv

MultiTexCoord1svARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordS in array [1]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	201
	alias		MultiTexCoord1sv
	glsalias	MultiTexCoord1sv

MultiTexCoord2dARB(target, s, t)
	return		void
	param		target		TextureUnit in value
	param		s		CoordD in value
	param		t		CoordD in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord2dv

MultiTexCoord2dvARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordD in array [2]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	202
	alias		MultiTexCoord2dv
	glsalias	MultiTexCoord2dv

MultiTexCoord2fARB(target, s, t)
	return		void
	param		target		TextureUnit in value
	param		s		CoordF in value
	param		t		CoordF in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord2fv

MultiTexCoord2fvARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordF in array [2]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	203
	alias		MultiTexCoord2fv
	glsalias	MultiTexCoord2fv

MultiTexCoord2iARB(target, s, t)
	return		void
	param		target		TextureUnit in value
	param		s		CoordI in value
	param		t		CoordI in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord2iv

MultiTexCoord2ivARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordI in array [2]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	204
	alias		MultiTexCoord2iv
	glsalias	MultiTexCoord2iv

MultiTexCoord2sARB(target, s, t)
	return		void
	param		target		TextureUnit in value
	param		s		CoordS in value
	param		t		CoordS in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord2sv

MultiTexCoord2svARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordS in array [2]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	205
	alias		MultiTexCoord2sv
	glsalias	MultiTexCoord2sv

MultiTexCoord3dARB(target, s, t, r)
	return		void
	param		target		TextureUnit in value
	param		s		CoordD in value
	param		t		CoordD in value
	param		r		CoordD in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord3dv

MultiTexCoord3dvARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordD in array [3]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	206
	alias		MultiTexCoord3dv
	glsalias	MultiTexCoord3dv

MultiTexCoord3fARB(target, s, t, r)
	return		void
	param		target		TextureUnit in value
	param		s		CoordF in value
	param		t		CoordF in value
	param		r		CoordF in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord3fv

MultiTexCoord3fvARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordF in array [3]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	207
	alias		MultiTexCoord3fv
	glsalias	MultiTexCoord3fv

MultiTexCoord3iARB(target, s, t, r)
	return		void
	param		target		TextureUnit in value
	param		s		CoordI in value
	param		t		CoordI in value
	param		r		CoordI in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord3iv

MultiTexCoord3ivARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordI in array [3]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	208
	alias		MultiTexCoord3iv
	glsalias	MultiTexCoord3iv

MultiTexCoord3sARB(target, s, t, r)
	return		void
	param		target		TextureUnit in value
	param		s		CoordS in value
	param		t		CoordS in value
	param		r		CoordS in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord3sv

MultiTexCoord3svARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordS in array [3]
	category	ARB_multitexture
	version		1.2
	glxflags	ARB
	glxropcode	209
	alias		MultiTexCoord3sv
	glsalias	MultiTexCoord3sv

MultiTexCoord4dARB(target, s, t, r, q)
	return		void
	param		target		TextureUnit in value
	param		s		CoordD in value
	param		t		CoordD in value
	param		r		CoordD in value
	param		q		CoordD in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord4dv

MultiTexCoord4dvARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordD in array [4]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	210
	alias		MultiTexCoord4dv
	glsalias	MultiTexCoord4dv

MultiTexCoord4fARB(target, s, t, r, q)
	return		void
	param		target		TextureUnit in value
	param		s		CoordF in value
	param		t		CoordF in value
	param		r		CoordF in value
	param		q		CoordF in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord4fv

MultiTexCoord4fvARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordF in array [4]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	211
	alias		MultiTexCoord4fv
	glsalias	MultiTexCoord4fv

MultiTexCoord4iARB(target, s, t, r, q)
	return		void
	param		target		TextureUnit in value
	param		s		CoordI in value
	param		t		CoordI in value
	param		r		CoordI in value
	param		q		CoordI in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord4iv

MultiTexCoord4ivARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordI in array [4]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	212
	alias		MultiTexCoord4iv
	glsalias	MultiTexCoord4iv

MultiTexCoord4sARB(target, s, t, r, q)
	return		void
	param		target		TextureUnit in value
	param		s		CoordS in value
	param		t		CoordS in value
	param		r		CoordS in value
	param		q		CoordS in value
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	vectorequiv	MultiTexCoord4sv

MultiTexCoord4svARB(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		CoordS in array [4]
	category	ARB_multitexture
	glxflags	ARB
	version		1.2
	glxropcode	213
	alias		MultiTexCoord4sv
	glsalias	MultiTexCoord4sv

################################################################################
#
# ARB Extension #2 - GLX_ARB_get_proc_address
#
###############################################################################

################################################################################
#
# ARB Extension #3
# ARB_transpose_matrix commands
#
###############################################################################

LoadTransposeMatrixfARB(m)
	return		void
	param		m		Float32 in array [16]
	category	ARB_transpose_matrix
	glxflags	ARB client-handcode client-intercept server-handcode
	version		1.2
	alias		LoadTransposeMatrixf
	glsalias	LoadTransposeMatrixf

LoadTransposeMatrixdARB(m)
	return		void
	param		m		Float64 in array [16]
	category	ARB_transpose_matrix
	glxflags	ARB client-handcode client-intercept server-handcode
	version		1.2
	alias		LoadTransposeMatrixd
	glsalias	LoadTransposeMatrixd

MultTransposeMatrixfARB(m)
	return		void
	param		m		Float32 in array [16]
	category	ARB_transpose_matrix
	glxflags	ARB client-handcode client-intercept server-handcode
	version		1.2
	alias		MultTransposeMatrixf
	glsalias	MultTransposeMatrixf

MultTransposeMatrixdARB(m)
	return		void
	param		m		Float64 in array [16]
	category	ARB_transpose_matrix
	glxflags	ARB client-handcode client-intercept server-handcode
	version		1.2
	alias		MultTransposeMatrixd
	glsalias	MultTransposeMatrixd

################################################################################
#
# ARB Extension #4 - WGL_ARB_buffer_region
#
###############################################################################

################################################################################
#
# ARB Extension #5
# ARB_multisample commands
#
###############################################################################

SampleCoverageARB(value, invert)
	return		void
	param		value		ClampedFloat32 in value
	param		invert		Boolean in value
	category	ARB_multisample
	glxflags	ARB
	version		1.2
	alias		SampleCoverage
	glsalias	SampleCoverage

################################################################################
#
# ARB Extension #6
# ARB_texture_env_add commands
#
###############################################################################

# (none)
newcategory: ARB_texture_env_add

################################################################################
#
# ARB Extension #7
# ARB_texture_cube_map commands
#
###############################################################################

# (none)
newcategory: ARB_texture_cube_map

################################################################################
#
# ARB Extension #8 - WGL_ARB_extensions_string
# ARB Extension #9 - WGL_ARB_pixel_format commands
# ARB Extension #10 - WGL_ARB_make_current_read commands
# ARB Extension #11 - WGL_ARB_pbuffer
#
###############################################################################

################################################################################
#
# ARB Extension #12
# ARB_texture_compression commands
#
###############################################################################

# Arguably TexelInternalFormat, not PixelInternalFormat
CompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		border		CheckedInt32 in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	ARB_texture_compression
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.2
	glxropcode	216
	alias		CompressedTexImage3D
	glsalias	CompressedTexImage3D
	wglflags	client-handcode server-handcode

# Arguably TexelInternalFormat, not PixelInternalFormat
CompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		border		CheckedInt32 in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	ARB_texture_compression
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.2
	glxropcode	215
	alias		CompressedTexImage2D
	glsalias	CompressedTexImage2D
	wglflags	client-handcode server-handcode

# Arguably TexelInternalFormat, not PixelInternalFormat
CompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		border		CheckedInt32 in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	ARB_texture_compression
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.2
	glxropcode	214
	alias		CompressedTexImage1D
	glsalias	CompressedTexImage1D
	wglflags	client-handcode server-handcode

CompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		zoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		format		PixelFormat in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	ARB_texture_compression
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.2
	glxropcode	219
	alias		CompressedTexSubImage3D
	glsalias	CompressedTexSubImage3D
	wglflags	client-handcode server-handcode

CompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	ARB_texture_compression
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.2
	glxropcode	218
	alias		CompressedTexSubImage2D
	glsalias	CompressedTexSubImage2D
	wglflags	client-handcode server-handcode

CompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		imageSize	SizeI in value
	param		data		CompressedTextureARB in array [imageSize]
	category	ARB_texture_compression
	dlflags		handcode
	glxflags	ARB client-handcode server-handcode
	version		1.2
	glxropcode	217
	alias		CompressedTexSubImage1D
	glsalias	CompressedTexSubImage1D
	wglflags	client-handcode server-handcode

GetCompressedTexImageARB(target, level, img)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		img		CompressedTextureARB out array [COMPSIZE(target/level)]
	category	ARB_texture_compression
	dlflags		notlistable
	glxflags	ARB client-handcode server-handcode
	version		1.2
	glxsingle	160
	alias		GetCompressedTexImage
	glsalias	GetCompressedTexImage
	wglflags	client-handcode server-handcode

################################################################################
#
# ARB Extension #13
# ARB_texture_border_clamp commands
#
###############################################################################

# (none)
newcategory: ARB_texture_border_clamp

###############################################################################
#
# ARB Extension #14
# ARB_point_parameters commands
#
###############################################################################

PointParameterfARB(pname, param)
	return		void
	param		pname		PointParameterNameARB in value
	param		param		CheckedFloat32 in value
	category	ARB_point_parameters
	version		1.0
	glxflags	ARB
	glxropcode	2065
	extension
	alias		PointParameterf
	glsalias	PointParameterf

PointParameterfvARB(pname, params)
	return		void
	param		pname		PointParameterNameARB in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	ARB_point_parameters
	version		1.0
	glxflags	ARB
	glxropcode	2066
	extension
	alias		PointParameterfv
	glsalias	PointParameterfv

################################################################################
#
# ARB Extension #15
# ARB_vertex_blend commands
#
###############################################################################

WeightbvARB(size, weights)
	return		void
	param		size		Int32 in value
	param		weights		Int8 in array [size]
	category	ARB_vertex_blend
	version		1.1
	extension
	glxropcode	220
	glxflags	ignore
	glsopcode	0x0206
	offset		?

WeightsvARB(size, weights)
	return		void
	param		size		Int32 in value
	param		weights		Int16 in array [size]
	category	ARB_vertex_blend
	version		1.1
	extension
	glxropcode	222
	glxflags	ignore
	glsopcode	0x0207
	offset		?

WeightivARB(size, weights)
	return		void
	param		size		Int32 in value
	param		weights		Int32 in array [size]
	category	ARB_vertex_blend
	version		1.1
	extension
	glxropcode	224
	glxflags	ignore
	glsopcode	0x0208
	offset		?

WeightfvARB(size, weights)
	return		void
	param		size		Int32 in value
	param		weights		Float32 in array [size]
	category	ARB_vertex_blend
	version		1.1
	extension
	glxropcode	227
	glxflags	ignore
	glsopcode	0x0209
	offset		?

WeightdvARB(size, weights)
	return		void
	param		size		Int32 in value
	param		weights		Float64 in array [size]
	category	ARB_vertex_blend
	version		1.1
	extension
	glxropcode	228
	glxflags	ignore
	glsopcode	0x020A
	offset		?

WeightubvARB(size, weights)
	return		void
	param		size		Int32 in value
	param		weights		UInt8 in array [size]
	category	ARB_vertex_blend
	version		1.1
	extension
	glxropcode	221
	glxflags	ignore
	glsopcode	0x020B
	offset		?

WeightusvARB(size, weights)
	return		void
	param		size		Int32 in value
	param		weights		UInt16 in array [size]
	category	ARB_vertex_blend
	version		1.1
	extension
	glxropcode	223
	glxflags	ignore
	glsopcode	0x020C
	offset		?

WeightuivARB(size, weights)
	return		void
	param		size		Int32 in value
	param		weights		UInt32 in array [size]
	category	ARB_vertex_blend
	version		1.1
	extension
	glxropcode	225
	glxflags	ignore
	glsopcode	0x020D
	offset		?

WeightPointerARB(size, type, stride, pointer)
	return		void
	param		size		Int32 in value
	param		type		WeightPointerTypeARB in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride)] retained
	category	ARB_vertex_blend
	version		1.1
	extension
	dlflags		notlistable
	glxflags	ignore
	glsflags	client
	glsopcode	0x020E
	offset		?

VertexBlendARB(count)
	return		void
	param		count		Int32 in value
	category	ARB_vertex_blend
	version		1.1
	extension
	glxropcode	226
	glxflags	ignore
	glsopcode	0x020F
	offset		?

################################################################################
#
# ARB Extension #16
# ARB_matrix_palette commands
#
###############################################################################

CurrentPaletteMatrixARB(index)
	return		void
	param		index		Int32 in value
	category	ARB_matrix_palette
	version		1.1
	extension
	glxropcode	4329
	glxflags	ignore
	glsopcode	0x0210
	offset		?

MatrixIndexubvARB(size, indices)
	return		void
	param		size		Int32 in value
	param		indices		UInt8 in array [size]
	category	ARB_matrix_palette
	version		1.1
	extension
	glxropcode	4326
	glxflags	ignore
	glsopcode	0x0211
	offset		?

MatrixIndexusvARB(size, indices)
	return		void
	param		size		Int32 in value
	param		indices		UInt16 in array [size]
	category	ARB_matrix_palette
	version		1.1
	extension
	glxropcode	4327
	glxflags	ignore
	glsopcode	0x0212
	offset		?

MatrixIndexuivARB(size, indices)
	return		void
	param		size		Int32 in value
	param		indices		UInt32 in array [size]
	category	ARB_matrix_palette
	version		1.1
	extension
	glxropcode	4328
	glxflags	ignore
	glsopcode	0x0213
	offset		?

MatrixIndexPointerARB(size, type, stride, pointer)
	return		void
	param		size		Int32 in value
	param		type		MatrixIndexPointerTypeARB in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride)] retained
	category	ARB_matrix_palette
	version		1.1
	extension
	dlflags		notlistable
	glxflags	ignore
	glsflags	client
	glsopcode	0x0214
	offset		?

################################################################################
#
# ARB Extension #17
# ARB_texture_env_combine commands
#
###############################################################################

# (none)
newcategory: ARB_texture_env_combine

################################################################################
#
# ARB Extension #18
# ARB_texture_env_crossbar commands
#
###############################################################################

# (none)
newcategory: ARB_texture_env_crossbar

################################################################################
#
# ARB Extension #19
# ARB_texture_env_dot3 commands
#
###############################################################################

# (none)
newcategory: ARB_texture_env_dot3

###############################################################################
#
# ARB Extension #20 - WGL_ARB_render_texture
#
###############################################################################

###############################################################################
#
# ARB Extension #21
# ARB_texture_mirrored_repeat commands
#
###############################################################################

# (none)
newcategory: ARB_texture_mirrored_repeat

###############################################################################
#
# ARB Extension #22
# ARB_depth_texture commands
#
###############################################################################

# (none)
newcategory: ARB_depth_texture

###############################################################################
#
# ARB Extension #23
# ARB_shadow commands
#
###############################################################################

# (none)
newcategory: ARB_shadow

###############################################################################
#
# ARB Extension #24
# ARB_shadow_ambient commands
#
###############################################################################

# (none)
newcategory: ARB_shadow_ambient

###############################################################################
#
# ARB Extension #25
# ARB_window_pos commands
# Note: all entry points use glxropcode ropcode 230, with 3 float parameters
#
###############################################################################

WindowPos2dARB(x, y)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	category	ARB_window_pos
	vectorequiv	WindowPos2dvARB
	version		1.0
	alias		WindowPos2d
	glsalias	WindowPos2d

WindowPos2dvARB(v)
	return		void
	param		v		CoordD in array [2]
	category	ARB_window_pos
	version		1.0
	glxropcode	230
	glxflags	client-handcode server-handcode
	alias		WindowPos2dv
	glsalias	WindowPos2dv

WindowPos2fARB(x, y)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	category	ARB_window_pos
	vectorequiv	WindowPos2fvARB
	version		1.0
	alias		WindowPos2f
	glsalias	WindowPos2f

WindowPos2fvARB(v)
	return		void
	param		v		CoordF in array [2]
	category	ARB_window_pos
	version		1.0
	glxropcode	230
	glxflags	client-handcode server-handcode
	alias		WindowPos2fv
	glsalias	WindowPos2fv

WindowPos2iARB(x, y)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	category	ARB_window_pos
	vectorequiv	WindowPos2ivARB
	version		1.0
	alias		WindowPos2i
	glsalias	WindowPos2i

WindowPos2ivARB(v)
	return		void
	param		v		CoordI in array [2]
	category	ARB_window_pos
	version		1.0
	glxropcode	230
	glxflags	client-handcode server-handcode
	alias		WindowPos2iv
	glsalias	WindowPos2iv

WindowPos2sARB(x, y)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	category	ARB_window_pos
	vectorequiv	WindowPos2svARB
	version		1.0
	alias		WindowPos2s
	glsalias	WindowPos2s

WindowPos2svARB(v)
	return		void
	param		v		CoordS in array [2]
	category	ARB_window_pos
	version		1.0
	glxropcode	230
	glxflags	client-handcode server-handcode
	alias		WindowPos2sv
	glsalias	WindowPos2sv

WindowPos3dARB(x, y, z)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	param		z		CoordD in value
	vectorequiv	WindowPos3dvARB
	category	ARB_window_pos
	version		1.0
	alias		WindowPos3d
	glsalias	WindowPos3d

WindowPos3dvARB(v)
	return		void
	param		v		CoordD in array [3]
	category	ARB_window_pos
	version		1.0
	glxropcode	230
	glxflags	client-handcode server-handcode
	alias		WindowPos3dv
	glsalias	WindowPos3dv

WindowPos3fARB(x, y, z)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	param		z		CoordF in value
	category	ARB_window_pos
	vectorequiv	WindowPos3fvARB
	version		1.0
	alias		WindowPos3f
	glsalias	WindowPos3f

WindowPos3fvARB(v)
	return		void
	param		v		CoordF in array [3]
	category	ARB_window_pos
	version		1.0
	glxropcode	230
	glxflags	client-handcode server-handcode
	alias		WindowPos3fv
	glsalias	WindowPos3fv

WindowPos3iARB(x, y, z)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	param		z		CoordI in value
	category	ARB_window_pos
	vectorequiv	WindowPos3ivARB
	version		1.0
	alias		WindowPos3i
	glsalias	WindowPos3i

WindowPos3ivARB(v)
	return		void
	param		v		CoordI in array [3]
	category	ARB_window_pos
	version		1.0
	glxropcode	230
	glxflags	client-handcode server-handcode
	alias		WindowPos3iv
	glsalias	WindowPos3iv

WindowPos3sARB(x, y, z)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	param		z		CoordS in value
	category	ARB_window_pos
	vectorequiv	WindowPos3svARB
	version		1.0
	alias		WindowPos3s
	glsalias	WindowPos3s

WindowPos3svARB(v)
	return		void
	param		v		CoordS in array [3]
	category	ARB_window_pos
	version		1.0
	glxropcode	230
	glxflags	client-handcode server-handcode
	alias		WindowPos3sv
	glsalias	WindowPos3sv

###############################################################################
#
# ARB Extension #26
# ARB_vertex_program commands
#
###############################################################################

VertexAttrib1dARB(index, x)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib1dvARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib1d
	glsalias	VertexAttrib1d

VertexAttrib1dvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [1]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4197
	glsopcode	0x0240
	alias		VertexAttrib1dv
	glsalias	VertexAttrib1dv

VertexAttrib1fARB(index, x)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib1fvARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib1f
	glsalias	VertexAttrib1f

VertexAttrib1fvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [1]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4193
	glsopcode	0x023F
	alias		VertexAttrib1fv
	glsalias	VertexAttrib1fv

VertexAttrib1sARB(index, x)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib1svARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib1s
	glsalias	VertexAttrib1s

VertexAttrib1svARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [1]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4189
	glsopcode	0x023E
	alias		VertexAttrib1sv
	glsalias	VertexAttrib1sv

VertexAttrib2dARB(index, x, y)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib2dvARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib2d
	glsalias	VertexAttrib2d

VertexAttrib2dvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [2]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4198
	glsopcode	0x0243
	alias		VertexAttrib2dv
	glsalias	VertexAttrib2dv

VertexAttrib2fARB(index, x, y)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib2fvARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib2f
	glsalias	VertexAttrib2f

VertexAttrib2fvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [2]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4194
	glsopcode	0x0242
	alias		VertexAttrib2fv
	glsalias	VertexAttrib2fv

VertexAttrib2sARB(index, x, y)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	param		y		Int16 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib2svARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib2s
	glsalias	VertexAttrib2s

VertexAttrib2svARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [2]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4190
	glsopcode	0x0241
	alias		VertexAttrib2sv
	glsalias	VertexAttrib2sv

VertexAttrib3dARB(index, x, y, z)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib3dvARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib3d
	glsalias	VertexAttrib3d

VertexAttrib3dvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [3]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4199
	glsopcode	0x0246
	alias		VertexAttrib3dv
	glsalias	VertexAttrib3dv

VertexAttrib3fARB(index, x, y, z)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib3fvARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib3f
	glsalias	VertexAttrib3f

VertexAttrib3fvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [3]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4195
	glsopcode	0x0245
	alias		VertexAttrib3fv
	glsalias	VertexAttrib3fv

VertexAttrib3sARB(index, x, y, z)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	param		y		Int16 in value
	param		z		Int16 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib3svARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib3s
	glsalias	VertexAttrib3s

VertexAttrib3svARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [3]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4191
	glsopcode	0x0244
	alias		VertexAttrib3sv
	glsalias	VertexAttrib3sv

VertexAttrib4NbvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int8 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4Nbv
	glsalias	VertexAttrib4Nbv

VertexAttrib4NivARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int32 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4Niv
	glsalias	VertexAttrib4Niv

VertexAttrib4NsvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4Nsv
	glsalias	VertexAttrib4Nsv

VertexAttrib4NubARB(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		UInt8 in value
	param		y		UInt8 in value
	param		z		UInt8 in value
	param		w		UInt8 in value
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4Nub
	glsalias	VertexAttrib4Nub

VertexAttrib4NubvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt8 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4201
	glsopcode	0x024A
	alias		VertexAttrib4Nubv
	glsalias	VertexAttrib4Nubv

VertexAttrib4NuivARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt32 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4Nuiv
	glsalias	VertexAttrib4Nuiv

VertexAttrib4NusvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt16 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4Nusv
	glsalias	VertexAttrib4Nusv

VertexAttrib4bvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int8 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4bv
	glsalias	VertexAttrib4bv

VertexAttrib4dARB(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	param		w		Float64 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib4dvARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib4d
	glsalias	VertexAttrib4d

VertexAttrib4dvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4200
	glsopcode	0x0249
	alias		VertexAttrib4dv
	glsalias	VertexAttrib4dv

VertexAttrib4fARB(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	param		w		Float32 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib4fvARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib4f
	glsalias	VertexAttrib4f

VertexAttrib4fvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4196
	glsopcode	0x0248
	alias		VertexAttrib4fv
	glsalias	VertexAttrib4fv

VertexAttrib4ivARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int32 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4iv
	glsalias	VertexAttrib4iv

VertexAttrib4sARB(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	param		y		Int16 in value
	param		z		Int16 in value
	param		w		Int16 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	VertexAttrib4svARB
	extension	soft WINSOFT NV10
	alias		VertexAttrib4s
	glsalias	VertexAttrib4s

VertexAttrib4svARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4192
	glsopcode	0x0247
	alias		VertexAttrib4sv
	glsalias	VertexAttrib4sv

VertexAttrib4ubvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt8 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4ubv
	glsalias	VertexAttrib4ubv

VertexAttrib4uivARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt32 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4uiv
	glsalias	VertexAttrib4uiv

VertexAttrib4usvARB(index, v)
	return		void
	param		index		UInt32 in value
	param		v		UInt16 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttrib4usv
	glsalias	VertexAttrib4usv

VertexAttribPointerARB(index, size, type, normalized, stride, pointer)
	return		void
	param		index		UInt32 in value
	param		size		Int32 in value
	param		type		VertexAttribPointerTypeARB in value
	param		normalized	Boolean in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(size/type/stride)] retained
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		VertexAttribPointer
	glsalias	VertexAttribPointer

EnableVertexAttribArrayARB(index)
	return		void
	param		index		UInt32 in value
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		EnableVertexAttribArray
	glsalias	EnableVertexAttribArray

DisableVertexAttribArrayARB(index)
	return		void
	param		index		UInt32 in value
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	alias		DisableVertexAttribArray
	glsalias	DisableVertexAttribArray

ProgramStringARB(target, format, len, string)
	return		void
	param		target		ProgramTargetARB in value
	param		format		ProgramFormatARB in value
	param		len		SizeI in value
	param		string		Void in array [len]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		667

BindProgramARB(target, program)
	return		void
	param		target		ProgramTargetARB in value
	param		program		UInt32 in value
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxropcode	4180
	glsopcode	0x0227
	offset		579

DeleteProgramsARB(n, programs)
	return		void
	param		n		SizeI in value
	param		programs	UInt32 in array [n]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxvendorpriv	1294
	glsopcode	0x0228
	offset		580

GenProgramsARB(n, programs)
	return		void
	param		n		SizeI in value
	param		programs	UInt32 out array [n]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxvendorpriv	1295
	glsopcode	0x022A
	offset		582

ProgramEnvParameter4dARB(target, index, x, y, z, w)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	param		w		Float64 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	ProgramEnvParameter4dvARB
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		668

ProgramEnvParameter4dvARB(target, index, params)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		params		Float64 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		669

ProgramEnvParameter4fARB(target, index, x, y, z, w)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	param		w		Float32 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	ProgramEnvParameter4fvARB
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		670

ProgramEnvParameter4fvARB(target, index, params)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		params		Float32 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		671

ProgramLocalParameter4dARB(target, index, x, y, z, w)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	param		w		Float64 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	ProgramLocalParameter4dvARB
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		672

ProgramLocalParameter4dvARB(target, index, params)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		params		Float64 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		673

ProgramLocalParameter4fARB(target, index, x, y, z, w)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	param		w		Float32 in value
	category	ARB_vertex_program
	version		1.3
	vectorequiv	ProgramLocalParameter4fvARB
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		674

ProgramLocalParameter4fvARB(target, index, params)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		params		Float32 in array [4]
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		675

GetProgramEnvParameterdvARB(target, index, params)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		params		Float64 out array [4]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		676

GetProgramEnvParameterfvARB(target, index, params)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		params		Float32 out array [4]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		677

GetProgramLocalParameterdvARB(target, index, params)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		params		Float64 out array [4]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		678

GetProgramLocalParameterfvARB(target, index, params)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		params		Float32 out array [4]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		679

GetProgramivARB(target, pname, params)
	return		void
	param		target		ProgramTargetARB in value
	param		pname		ProgramPropertyARB in value
	param		params		Int32 out array [1]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		680

GetProgramStringARB(target, pname, string)
	return		void
	param		target		ProgramTargetARB in value
	param		pname		ProgramStringPropertyARB in value
	param		string		Void out array [COMPSIZE(target,pname)]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glsflags	ignore
	glxflags	ignore
	offset		681

GetVertexAttribdvARB(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribPropertyARB in value
	param		params		Float64 out array [4]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxvendorpriv	1301
	glsflags	client get
	glsopcode	0x0232
	alias		GetVertexAttribdv
	glsalias	GetVertexAttribdv

GetVertexAttribfvARB(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribPropertyARB in value
	param		params		Float32 out array [4]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxvendorpriv	1302
	glsflags	client get
	glsopcode	0x0233
	alias		GetVertexAttribfv
	glsalias	GetVertexAttribfv

GetVertexAttribivARB(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribPropertyARB in value
	param		params		Int32 out array [4]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxvendorpriv	1303
	glsflags	client get
	glsopcode	0x0234
	alias		GetVertexAttribiv
	glsalias	GetVertexAttribiv

GetVertexAttribPointervARB(index, pname, pointer)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribPointerPropertyARB in value
	param		pointer		VoidPointer out array [1]
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	client get
	glsopcode	0x0235
	alias		GetVertexAttribPointerv
	glsalias	GetVertexAttribPointerv

IsProgramARB(program)
	return		Boolean
	param		program		UInt32 in value
	dlflags		notlistable
	category	ARB_vertex_program
	version		1.3
	extension	soft WINSOFT NV10
	glxvendorpriv	1304
	glsflags	get
	alias		IsProgram
	glsalias	IsProgram


###############################################################################
#
# ARB Extension #27
# ARB_fragment_program commands
#
###############################################################################

# All ARB_fragment_program entry points are shared with ARB_vertex_program,
#   and are only included in that #define block, for now.
newcategory: ARB_fragment_program
passthru: /* All ARB_fragment_program entry points are shared with ARB_vertex_program. */

###############################################################################
#
# ARB Extension #28
# ARB_vertex_buffer_object commands
#
###############################################################################

BindBufferARB(target, buffer)
	return		void
	param		target		VertexBufferTargetARB in value
	param		buffer		UInt32 in value
	category	ARB_vertex_buffer_object
	version		1.2
	extension
	alias		BindBuffer
	glsalias	BindBuffer

DeleteBuffersARB(n, buffers)
	return		void
	param		n		SizeI in value
	param		buffers		ConstUInt32 in array [n]
	category	ARB_vertex_buffer_object
	version		1.2
	extension
	alias		DeleteBuffers
	glsalias	DeleteBuffers

GenBuffersARB(n, buffers)
	return		void
	param		n		SizeI in value
	param		buffers		UInt32 out array [n]
	category	ARB_vertex_buffer_object
	version		1.2
	extension
	alias		GenBuffers
	glsalias	GenBuffers

IsBufferARB(buffer)
	return		Boolean
	param		buffer		UInt32 in value
	category	ARB_vertex_buffer_object
	version		1.2
	extension
	alias		IsBuffer
	glsalias	IsBuffer

BufferDataARB(target, size, data, usage)
	return		void
	param		target		VertexBufferTargetARB in value
	param		size		VertexBufferSizeARB in value
	param		data		ConstVoid in array [size]
	param		usage		VertexBufferUsageARB in value
	category	ARB_vertex_buffer_object
	version		1.2
	extension
	alias		BufferData
	glsalias	BufferData

BufferSubDataARB(target, offset, size, data)
	return		void
	param		target		VertexBufferTargetARB in value
	param		offset		VertexBufferOffsetARB in value
	param		size		VertexBufferSizeARB in value
	param		data		ConstVoid in array [size]
	category	ARB_vertex_buffer_object
	version		1.2
	extension
	alias		BufferSubData
	glsalias	BufferSubData

GetBufferSubDataARB(target, offset, size, data)
	return		void
	param		target		VertexBufferTargetARB in value
	param		offset		VertexBufferOffsetARB in value
	param		size		VertexBufferSizeARB in value
	param		data		Void out array [size]
	category	ARB_vertex_buffer_object
	dlflags		notlistable
	version		1.2
	extension
	alias		GetBufferSubData
	glsalias	GetBufferSubData

MapBufferARB(target, access)
	return		VoidPointer
	param		target		VertexBufferTargetARB in value
	param		access		VertexBufferAccessARB in value
	category	ARB_vertex_buffer_object
	version		1.2
	extension
	alias		MapBuffer
	glsalias	MapBuffer

UnmapBufferARB(target)
	return		Boolean
	param		target		VertexBufferTargetARB in value
	category	ARB_vertex_buffer_object
	version		1.2
	extension
	alias		UnmapBuffer
	glsalias	UnmapBuffer

GetBufferParameterivARB(target, pname, params)
	return		void
	param		target		VertexBufferTargetARB in value
	param		pname		VertexBufferPNameARB in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	ARB_vertex_buffer_object
	dlflags		notlistable
	version		1.2
	extension
	alias		GetBufferParameteriv
	glsalias	GetBufferParameteriv

GetBufferPointervARB(target, pname, params)
	return		void
	param		target		VertexBufferTargetARB in value
	param		pname		VertexBufferPointerNameARB in value
	param		params		VoidPointer out array [1]
	category	ARB_vertex_buffer_object
	dlflags		notlistable
	version		1.2
	extension
	alias		GetBufferPointerv
	glsalias	GetBufferPointerv

###############################################################################
#
# ARB Extension #29
# ARB_occlusion_query commands
#
###############################################################################

GenQueriesARB(n, ids)
	return		void
	param		n		SizeI in value
	param		ids		UInt32 out array [n]
	category	ARB_occlusion_query
	version		1.5
	extension
	alias		GenQueries
	glsalias	GenQueries

DeleteQueriesARB(n, ids)
	return		void
	param		n		SizeI in value
	param		ids		UInt32 in array [n]
	category	ARB_occlusion_query
	version		1.5
	extension
	alias		DeleteQueries
	glsalias	DeleteQueries

IsQueryARB(id)
	return		Boolean
	param		id		UInt32 in value
	category	ARB_occlusion_query
	version		1.5
	extension
	alias		IsQuery
	glsalias	IsQuery

BeginQueryARB(target, id)
	return		void
	param		target		GLenum in value
	param		id		UInt32 in value
	category	ARB_occlusion_query
	version		1.5
	extension
	alias		BeginQuery
	glsalias	BeginQuery

EndQueryARB(target)
	return		void
	param		target		GLenum in value
	category	ARB_occlusion_query
	version		1.5
	extension
	alias		EndQuery
	glsalias	EndQuery

GetQueryivARB(target, pname, params)
	return		void
	param		target		GLenum in value
	param		pname		GLenum in value
	param		params		Int32 out array [pname]
	category	ARB_occlusion_query
	dlflags		notlistable
	version		1.5
	extension
	alias		GetQueryiv
	glsalias	GetQueryiv

GetQueryObjectivARB(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		GLenum in value
	param		params		Int32 out array [pname]
	category	ARB_occlusion_query
	dlflags		notlistable
	version		1.5
	extension
	alias		GetQueryObjectiv
	glsalias	GetQueryObjectiv

GetQueryObjectuivARB(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		GLenum in value
	param		params		UInt32 out array [pname]
	category	ARB_occlusion_query
	dlflags		notlistable
	version		1.5
	extension
	alias		GetQueryObjectuiv
	glsalias	GetQueryObjectuiv

###############################################################################
#
# ARB Extension #30
# ARB_shader_objects commands
#
###############################################################################

DeleteObjectARB(obj)
	return		void
	param		obj		handleARB in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

GetHandleARB(pname)
	return		handleARB
	param		pname		GLenum in value
	category	ARB_shader_objects
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

DetachObjectARB(containerObj, attachedObj)
	return		void
	param		containerObj	handleARB in value
	param		attachedObj	handleARB in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		DetachShader
	glsalias	DetachShader

CreateShaderObjectARB(shaderType)
	return		handleARB
	param		shaderType	GLenum in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		CreateShader
	glsalias	CreateShader

ShaderSourceARB(shaderObj, count, string, length)
	return		void
	param		shaderObj	handleARB in value
	param		count		SizeI in value
	param		string		charPointerARB in array [count]
	param		length		Int32 in array [1]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		ShaderSource
	glsalias	ShaderSource

CompileShaderARB(shaderObj)
	return		void
	param		shaderObj	handleARB in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		CompileShader
	glsalias	CompileShader

CreateProgramObjectARB()
	return		handleARB
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		CreateProgram
	glsalias	CreateProgram

AttachObjectARB(containerObj, obj)
	return		void
	param		containerObj	handleARB in value
	param		obj		handleARB in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		AttachShader
	glsalias	AttachShader

LinkProgramARB(programObj)
	return		void
	param		programObj	handleARB in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		LinkProgram
	glsalias	LinkProgram

UseProgramObjectARB(programObj)
	return		void
	param		programObj	handleARB in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		UseProgram
	glsalias	UseProgram

ValidateProgramARB(programObj)
	return		void
	param		programObj	handleARB in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		ValidateProgram
	glsalias	ValidateProgram

Uniform1fARB(location, v0)
	return		void
	param		location	Int32 in value
	param		v0		Float32 in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform1f
	glsalias	Uniform1f

Uniform2fARB(location, v0, v1)
	return		void
	param		location	Int32 in value
	param		v0		Float32 in value
	param		v1		Float32 in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform2f
	glsalias	Uniform2f

Uniform3fARB(location, v0, v1, v2)
	return		void
	param		location	Int32 in value
	param		v0		Float32 in value
	param		v1		Float32 in value
	param		v2		Float32 in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform3f
	glsalias	Uniform3f

Uniform4fARB(location, v0, v1, v2, v3)
	return		void
	param		location	Int32 in value
	param		v0		Float32 in value
	param		v1		Float32 in value
	param		v2		Float32 in value
	param		v3		Float32 in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform4f
	glsalias	Uniform4f

Uniform1iARB(location, v0)
	return		void
	param		location	Int32 in value
	param		v0		Int32 in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform1i
	glsalias	Uniform1i

Uniform2iARB(location, v0, v1)
	return		void
	param		location	Int32 in value
	param		v0		Int32 in value
	param		v1		Int32 in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform2i
	glsalias	Uniform2i

Uniform3iARB(location, v0, v1, v2)
	return		void
	param		location	Int32 in value
	param		v0		Int32 in value
	param		v1		Int32 in value
	param		v2		Int32 in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform3i
	glsalias	Uniform3i

Uniform4iARB(location, v0, v1, v2, v3)
	return		void
	param		location	Int32 in value
	param		v0		Int32 in value
	param		v1		Int32 in value
	param		v2		Int32 in value
	param		v3		Int32 in value
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform4i
	glsalias	Uniform4i

Uniform1fvARB(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Float32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform1fv
	glsalias	Uniform1fv

Uniform2fvARB(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Float32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform2fv
	glsalias	Uniform2fv

Uniform3fvARB(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Float32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform3fv
	glsalias	Uniform3fv

Uniform4fvARB(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Float32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform4fv
	glsalias	Uniform4fv

Uniform1ivARB(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Int32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform1iv
	glsalias	Uniform1iv

Uniform2ivARB(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Int32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform2iv
	glsalias	Uniform2iv

Uniform3ivARB(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Int32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform3iv
	glsalias	Uniform3iv

Uniform4ivARB(location, count, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		value		Int32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		Uniform4iv
	glsalias	Uniform4iv

UniformMatrix2fvARB(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		UniformMatrix2fv
	glsalias	UniformMatrix2fv

UniformMatrix3fvARB(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		UniformMatrix3fv
	glsalias	UniformMatrix3fv

UniformMatrix4fvARB(location, count, transpose, value)
	return		void
	param		location	Int32 in value
	param		count		SizeI in value
	param		transpose	Boolean in value
	param		value		Float32 in array [count]
	category	ARB_shader_objects
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		UniformMatrix4fv
	glsalias	UniformMatrix4fv

GetObjectParameterfvARB(obj, pname, params)
	return		void
	param		obj		handleARB in value
	param		pname		GLenum in value
	param		params		Float32 out array [pname]
	category	ARB_shader_objects
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetObjectParameterivARB(obj, pname, params)
	return		void
	param		obj		handleARB in value
	param		pname		GLenum in value
	param		params		Int32 out array [pname]
	category	ARB_shader_objects
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetInfoLogARB(obj, maxLength, length, infoLog)
	return		void
	param		obj		handleARB in value
	param		maxLength	SizeI in value
	param		length		SizeI out array [1]
	param		infoLog		charARB out array [length]
	category	ARB_shader_objects
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetAttachedObjectsARB(containerObj, maxCount, count, obj)
	return		void
	param		containerObj	handleARB in value
	param		maxCount	SizeI in value
	param		count		SizeI out array [1]
	param		obj		handleARB out array [count]
	category	ARB_shader_objects
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	alias		GetAttachedShaders
	glsalias	GetAttachedShaders

GetUniformLocationARB(programObj, name)
	return		Int32
	param		programObj	handleARB in value
	param		name		charARB in array []
	category	ARB_shader_objects
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	alias		GetUniformLocation
	glsalias	GetUniformLocation

GetActiveUniformARB(programObj, index, maxLength, length, size, type, name)
	return		void
	param		programObj	handleARB in value
	param		index		UInt32 in value
	param		maxLength	SizeI in value
	param		length		SizeI out array [1]
	param		size		Int32 out array [1]
	param		type		GLenum out array [1]
	param		name		charARB out array []
	category	ARB_shader_objects
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	alias		GetActiveUniform
	glsalias	GetActiveUniform

GetUniformfvARB(programObj, location, params)
	return		void
	param		programObj	handleARB in value
	param		location	Int32 in value
	param		params		Float32 out array [location]
	category	ARB_shader_objects
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	alias		GetUniformfv
	glsalias	GetUniformfv

GetUniformivARB(programObj, location, params)
	return		void
	param		programObj	handleARB in value
	param		location	Int32 in value
	param		params		Int32 out array [location]
	category	ARB_shader_objects
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	alias		GetUniformiv
	glsalias	GetUniformiv

GetShaderSourceARB(obj, maxLength, length, source)
	return		void
	param		obj		handleARB in value
	param		maxLength	SizeI in value
	param		length		SizeI out array [1]
	param		source		charARB out array [length]
	category	ARB_shader_objects
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	alias		GetShaderSource
	glsalias	GetShaderSource


###############################################################################
#
# ARB Extension #31
# ARB_vertex_shader commands
#
###############################################################################

BindAttribLocationARB(programObj, index, name)
	return		void
	param		programObj	handleARB in value
	param		index		UInt32 in value
	param		name		charARB in array []
	category	ARB_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		BindAttribLocation
	glsalias	BindAttribLocation

GetActiveAttribARB(programObj, index, maxLength, length, size, type, name)
	return		void
	param		programObj	handleARB in value
	param		index		UInt32 in value
	param		maxLength	SizeI in value
	param		length		SizeI out array [1]
	param		size		Int32 out array [1]
	param		type		GLenum out array [1]
	param		name		charARB out array []
	category	ARB_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	alias		GetActiveAttrib
	glsalias	GetActiveAttrib

GetAttribLocationARB(programObj, name)
	return		Int32
	param		programObj	handleARB in value
	param		name		charARB in array []
	category	ARB_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	alias		GetAttribLocation
	glsalias	GetAttribLocation

###############################################################################
#
# ARB Extension #32
# ARB_fragment_shader commands
#
###############################################################################

#  (none)
newcategory: ARB_fragment_shader

###############################################################################
#
# ARB Extension #33
# ARB_shading_language_100 commands
#
###############################################################################

#  (none)
newcategory: ARB_shading_language_100

###############################################################################
#
# ARB Extension #34
# ARB_texture_non_power_of_two commands
#
###############################################################################

# (none)
newcategory: ARB_texture_non_power_of_two

###############################################################################
#
# ARB Extension #35
# ARB_point_sprite commands
#
###############################################################################

# (none)
newcategory: ARB_point_sprite

###############################################################################
#
# ARB Extension #36
# ARB_fragment_program_shadow commands
#
###############################################################################

# (none)
newcategory: ARB_fragment_program_shadow

###############################################################################
#
# ARB Extension #37
# ARB_draw_buffers commands
#
###############################################################################

DrawBuffersARB(n, bufs)
	return		void
	param		n		SizeI in value
	param		bufs		DrawBufferModeATI in array [n]
	category	ARB_draw_buffers
	version		1.5
	extension
	alias		DrawBuffers
	glsalias	DrawBuffers

###############################################################################
#
# ARB Extension #38
# ARB_texture_rectangle commands
#
###############################################################################

# (none)
newcategory: ARB_texture_rectangle

###############################################################################
#
# ARB Extension #39
# ARB_color_buffer_float commands
#
###############################################################################

ClampColorARB(target, clamp)
	return		void
	param		target		ClampColorTargetARB in value
	param		clamp		ClampColorModeARB in value
	category	ARB_color_buffer_float
	version		1.5
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

###############################################################################
#
# ARB Extension #40
# ARB_half_float_pixel commands
#
###############################################################################

# (none)
newcategory: ARB_half_float_pixel

###############################################################################
#
# ARB Extension #41
# ARB_texture_float commands
#
###############################################################################

# (none)
newcategory: ARB_texture_float

###############################################################################
#
# ARB Extension #42
# ARB_pixel_buffer_object commands
#
###############################################################################

# (none)
newcategory: ARB_pixel_buffer_object


###############################################################################
###############################################################################
#
# Non-ARB extensions, in order by registry extension number
#
###############################################################################
###############################################################################

###############################################################################
#
# Extension #1
# EXT_abgr commands
#
###############################################################################

# (none)
newcategory: EXT_abgr

###############################################################################
#
# Extension #2
# EXT_blend_color commands
#
###############################################################################

BlendColorEXT(red, green, blue, alpha)
	return		void
	param		red		ClampedColorF in value
	param		green		ClampedColorF in value
	param		blue		ClampedColorF in value
	param		alpha		ClampedColorF in value
	category	EXT_blend_color
	version		1.0
	glxropcode	4096
	glxflags	EXT
	extension	soft
	alias		BlendColor
	glsalias	BlendColor

###############################################################################
#
# Extension #3
# EXT_polygon_offset commands
#
###############################################################################

PolygonOffsetEXT(factor, bias)
	return		void
	param		factor		Float32 in value
	param		bias		Float32 in value
	category	EXT_polygon_offset
	version		1.0
	glxropcode	4098
	glxflags	EXT
	extension	soft
	glsopcode	0x0122
	offset		414

###############################################################################
#
# Extension #4
# EXT_texture commands
#
###############################################################################

# (none)
newcategory: EXT_texture

###############################################################################
#
# Extension #5 - skipped
#
###############################################################################

###############################################################################
#
# Extension #6
# EXT_texture3D commands
#
###############################################################################

# Arguably TexelInternalFormat, not PixelInternalFormat
TexImage3DEXT(target, level, internalformat, width, height, depth, border, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		border		CheckedInt32 in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width/height/depth)]
	category	EXT_texture3D
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxropcode	4114
	extension
	alias		TexImage3D
	glsalias	TexImage3D

TexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		zoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width/height/depth)]
	category	EXT_texture3D
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxropcode	4115
	extension
	alias		TexSubImage3D
	glsalias	TexSubImage3D

###############################################################################
#
# Extension #7
# SGIS_texture_filter4 commands
#
###############################################################################

GetTexFilterFuncSGIS(target, filter, weights)
	return		void
	param		target		TextureTarget in value
	param		filter		TextureFilterSGIS in value
	param		weights		Float32 out array [COMPSIZE(target/filter)]
	category	SGIS_texture_filter4
	dlflags		notlistable
	version		1.0
	glxflags	SGI
	glxvendorpriv	4101
	extension
	glsflags	get
	glsopcode	0x0175
	offset		415

TexFilterFuncSGIS(target, filter, n, weights)
	return		void
	param		target		TextureTarget in value
	param		filter		TextureFilterSGIS in value
	param		n		SizeI in value
	param		weights		Float32 in array [n]
	category	SGIS_texture_filter4
	glxflags	SGI
	version		1.0
	glxropcode	2064
	extension
	glsopcode	0x0176
	offset		416

###############################################################################
#
# Extension #8 - skipped
#
###############################################################################

###############################################################################
#
# Extension #9
# EXT_subtexture commands
#
###############################################################################

TexSubImage1DEXT(target, level, xoffset, width, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width)]
	category	EXT_subtexture
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxropcode	4099
	extension
	alias		TexSubImage1D
	glsalias	TexSubImage1D

TexSubImage2DEXT(target, level, xoffset, yoffset, width, height, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width/height)]
	category	EXT_subtexture
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxropcode	4100
	extension
	alias		TexSubImage2D
	glsalias	TexSubImage2D

###############################################################################
#
# Extension #10
# EXT_copy_texture commands
#
###############################################################################

# Arguably TexelInternalFormat, not PixelInternalFormat
CopyTexImage1DEXT(target, level, internalformat, x, y, width, border)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		border		CheckedInt32 in value
	category	EXT_copy_texture
	version		1.0
	glxflags	EXT
	glxropcode	4119
	extension
	alias		CopyTexImage1D
	glsalias	CopyTexImage1D

# Arguably TexelInternalFormat, not PixelInternalFormat
CopyTexImage2DEXT(target, level, internalformat, x, y, width, height, border)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		border		CheckedInt32 in value
	category	EXT_copy_texture
	version		1.0
	glxflags	EXT
	glxropcode	4120
	extension
	alias		CopyTexImage2D
	glsalias	CopyTexImage2D

CopyTexSubImage1DEXT(target, level, xoffset, x, y, width)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	category	EXT_copy_texture
	version		1.0
	glxflags	EXT
	glxropcode	4121
	extension
	alias		CopyTexSubImage1D
	glsalias	CopyTexSubImage1D

CopyTexSubImage2DEXT(target, level, xoffset, yoffset, x, y, width, height)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	category	EXT_copy_texture
	version		1.0
	glxflags	EXT
	glxropcode	4122
	extension
	alias		CopyTexSubImage2D
	glsalias	CopyTexSubImage2D

CopyTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, x, y, width, height)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		zoffset		CheckedInt32 in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	category	EXT_copy_texture
	version		1.0
	glxflags	EXT
	glxropcode	4123
	extension
	alias		CopyTexSubImage3D
	glsalias	CopyTexSubImage3D

###############################################################################
#
# Extension #11
# EXT_histogram commands
#
###############################################################################

GetHistogramEXT(target, reset, format, type, values)
	return		void
	param		target		HistogramTargetEXT in value
	param		reset		Boolean in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		values		Void out array [COMPSIZE(target/format/type)]
	category	EXT_histogram
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxvendorpriv	5
	extension
	glsflags	get pixel-pack
	glsopcode	0x0132
	offset		417

GetHistogramParameterfvEXT(target, pname, params)
	return		void
	param		target		HistogramTargetEXT in value
	param		pname		GetHistogramParameterPNameEXT in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	EXT_histogram
	dlflags		notlistable
	version		1.0
	glxvendorpriv	6
	glxflags	EXT
	extension
	glsflags	get
	glsopcode	0x0133
	offset		418

GetHistogramParameterivEXT(target, pname, params)
	return		void
	param		target		HistogramTargetEXT in value
	param		pname		GetHistogramParameterPNameEXT in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	EXT_histogram
	dlflags		notlistable
	version		1.0
	glxvendorpriv	7
	glxflags	EXT
	extension
	glsflags	get
	glsopcode	0x0134
	offset		419

GetMinmaxEXT(target, reset, format, type, values)
	return		void
	param		target		MinmaxTargetEXT in value
	param		reset		Boolean in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		values		Void out array [COMPSIZE(target/format/type)]
	category	EXT_histogram
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxvendorpriv	8
	extension
	glsflags	get pixel-pack
	glsopcode	0x0135
	offset		420

GetMinmaxParameterfvEXT(target, pname, params)
	return		void
	param		target		MinmaxTargetEXT in value
	param		pname		GetMinmaxParameterPNameEXT in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	EXT_histogram
	dlflags		notlistable
	version		1.0
	glxvendorpriv	9
	glxflags	EXT
	extension
	glsflags	get
	glsopcode	0x0136
	offset		421

GetMinmaxParameterivEXT(target, pname, params)
	return		void
	param		target		MinmaxTargetEXT in value
	param		pname		GetMinmaxParameterPNameEXT in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	EXT_histogram
	dlflags		notlistable
	version		1.0
	glxvendorpriv	10
	glxflags	EXT
	extension
	glsflags	get
	glsopcode	0x0137
	offset		422

HistogramEXT(target, width, internalformat, sink)
	return		void
	param		target		HistogramTargetEXT in value
	param		width		SizeI in value
	param		internalformat	PixelInternalFormat in value
	param		sink		Boolean in value
	category	EXT_histogram
	version		1.0
	glxropcode	4110
	glxflags	EXT
	extension
	alias		Histogram
	glsalias	Histogram

MinmaxEXT(target, internalformat, sink)
	return		void
	param		target		MinmaxTargetEXT in value
	param		internalformat	PixelInternalFormat in value
	param		sink		Boolean in value
	category	EXT_histogram
	version		1.0
	glxropcode	4111
	glxflags	EXT
	extension
	alias		Minmax
	glsalias	Minmax

ResetHistogramEXT(target)
	return		void
	param		target		HistogramTargetEXT in value
	category	EXT_histogram
	version		1.0
	glxropcode	4112
	glxflags	EXT
	extension
	alias		ResetHistogram
	glsalias	ResetHistogram

ResetMinmaxEXT(target)
	return		void
	param		target		MinmaxTargetEXT in value
	category	EXT_histogram
	version		1.0
	glxropcode	4113
	glxflags	EXT
	extension
	alias		ResetMinmax
	glsalias	ResetMinmax

###############################################################################
#
# Extension #12
# EXT_convolution commands
#
###############################################################################

ConvolutionFilter1DEXT(target, internalformat, width, format, type, image)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		image		Void in array [COMPSIZE(format/type/width)]
	category	EXT_convolution
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxropcode	4101
	extension
	alias		ConvolutionFilter1D
	glsalias	ConvolutionFilter1D

ConvolutionFilter2DEXT(target, internalformat, width, height, format, type, image)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		image		Void in array [COMPSIZE(format/type/width/height)]
	category	EXT_convolution
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxropcode	4102
	extension
	alias		ConvolutionFilter2D
	glsalias	ConvolutionFilter2D

ConvolutionParameterfEXT(target, pname, params)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		pname		ConvolutionParameterEXT in value
	param		params		CheckedFloat32 in value
	category	EXT_convolution
	version		1.0
	glxropcode	4103
	glxflags	EXT
	extension
	alias		ConvolutionParameterf
	glsalias	ConvolutionParameterf

ConvolutionParameterfvEXT(target, pname, params)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		pname		ConvolutionParameterEXT in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	EXT_convolution
	version		1.0
	glxropcode	4104
	glxflags	EXT
	extension
	alias		ConvolutionParameterfv
	glsalias	ConvolutionParameterfv

ConvolutionParameteriEXT(target, pname, params)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		pname		ConvolutionParameterEXT in value
	param		params		CheckedInt32 in value
	category	EXT_convolution
	version		1.0
	glxropcode	4105
	glxflags	EXT
	extension
	alias		ConvolutionParameteri
	glsalias	ConvolutionParameteri

ConvolutionParameterivEXT(target, pname, params)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		pname		ConvolutionParameterEXT in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	EXT_convolution
	version		1.0
	glxropcode	4106
	glxflags	EXT
	extension
	alias		ConvolutionParameteriv
	glsalias	ConvolutionParameteriv

CopyConvolutionFilter1DEXT(target, internalformat, x, y, width)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		internalformat	PixelInternalFormat in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	category	EXT_convolution
	version		1.0
	glxropcode	4107
	glxflags	EXT
	extension
	alias		CopyConvolutionFilter1D
	glsalias	CopyConvolutionFilter1D

CopyConvolutionFilter2DEXT(target, internalformat, x, y, width, height)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		internalformat	PixelInternalFormat in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	param		height		SizeI in value
	category	EXT_convolution
	version		1.0
	glxropcode	4108
	glxflags	EXT
	extension
	alias		CopyConvolutionFilter2D
	glsalias	CopyConvolutionFilter2D

GetConvolutionFilterEXT(target, format, type, image)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		image		Void out array [COMPSIZE(target/format/type)]
	category	EXT_convolution
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxvendorpriv	1
	extension
	glsflags	get pixel-pack
	glsopcode	0x012D
	offset		423

GetConvolutionParameterfvEXT(target, pname, params)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		pname		ConvolutionParameterEXT in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	EXT_convolution
	dlflags		notlistable
	version		1.0
	glxvendorpriv	2
	glxflags	EXT
	extension
	glsflags	get
	glsopcode	0x012E
	offset		424

GetConvolutionParameterivEXT(target, pname, params)
	return		void
	param		target		ConvolutionTargetEXT in value
	param		pname		ConvolutionParameterEXT in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	EXT_convolution
	dlflags		notlistable
	version		1.0
	glxvendorpriv	3
	glxflags	EXT
	extension
	glsflags	get
	glsopcode	0x012F
	offset		425

GetSeparableFilterEXT(target, format, type, row, column, span)
	return		void
	param		target		SeparableTargetEXT in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		row		Void out array [COMPSIZE(target/format/type)]
	param		column		Void out array [COMPSIZE(target/format/type)]
	param		span		Void out array [COMPSIZE(target/format/type)]
	category	EXT_convolution
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxvendorpriv	4
	extension
	glsflags	get pixel-pack
	glsopcode	0x0130
	offset		426

SeparableFilter2DEXT(target, internalformat, width, height, format, type, row, column)
	return		void
	param		target		SeparableTargetEXT in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		row		Void in array [COMPSIZE(target/format/type/width)]
	param		column		Void in array [COMPSIZE(target/format/type/height)]
	category	EXT_convolution
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxropcode	4109
	extension
	alias		SeparableFilter2D
	glsalias	SeparableFilter2D

###############################################################################
#
# Extension #13
# SGI_color_matrix commands
#
###############################################################################

# (none)
newcategory: SGI_color_matrix

###############################################################################
#
# Extension #14
# SGI_color_table commands
#
###############################################################################

ColorTableSGI(target, internalformat, width, format, type, table)
	return		void
	param		target		ColorTableTargetSGI in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		table		Void in array [COMPSIZE(format/type/width)]
	category	SGI_color_table
	dlflags		handcode
	glxflags	client-handcode server-handcode SGI
	version		1.0
	glxropcode	2053
	extension
	alias		ColorTable
	glsalias	ColorTable

ColorTableParameterfvSGI(target, pname, params)
	return		void
	param		target		ColorTableTargetSGI in value
	param		pname		ColorTableParameterPNameSGI in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	SGI_color_table
	version		1.0
	glxropcode	2054
	glxflags	SGI
	extension
	alias		ColorTableParameterfv
	glsalias	ColorTableParameterfv

ColorTableParameterivSGI(target, pname, params)
	return		void
	param		target		ColorTableTargetSGI in value
	param		pname		ColorTableParameterPNameSGI in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	SGI_color_table
	version		1.0
	glxropcode	2055
	glxflags	SGI
	extension
	alias		ColorTableParameteriv
	glsalias	ColorTableParameteriv

CopyColorTableSGI(target, internalformat, x, y, width)
	return		void
	param		target		ColorTableTargetSGI in value
	param		internalformat	PixelInternalFormat in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	category	SGI_color_table
	version		1.0
	glxropcode	2056
	glxflags	SGI
	extension
	alias		CopyColorTable
	glsalias	CopyColorTable

GetColorTableSGI(target, format, type, table)
	return		void
	param		target		ColorTableTargetSGI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		table		Void out array [COMPSIZE(target/format/type)]
	category	SGI_color_table
	dlflags		notlistable
	glxflags	client-handcode server-handcode SGI
	version		1.0
	glxvendorpriv	4098
	extension
	glsflags	get pixel-pack
	glsopcode	0x016B
	offset		427

GetColorTableParameterfvSGI(target, pname, params)
	return		void
	param		target		ColorTableTargetSGI in value
	param		pname		GetColorTableParameterPNameSGI in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	SGI_color_table
	dlflags		notlistable
	version		1.0
	glxflags	SGI
	glxvendorpriv	4099
	extension
	glsflags	get
	glsopcode	0x016C
	offset		428

GetColorTableParameterivSGI(target, pname, params)
	return		void
	param		target		ColorTableTargetSGI in value
	param		pname		GetColorTableParameterPNameSGI in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	SGI_color_table
	dlflags		notlistable
	version		1.0
	glxflags	SGI
	glxvendorpriv	4100
	extension
	glsflags	get
	glsopcode	0x016D
	offset		429

###############################################################################
#
# Extension #15
# SGIX_pixel_texture commands
#
###############################################################################

PixelTexGenSGIX(mode)
	return		void
	param		mode		PixelTexGenModeSGIX in value
	category	SGIX_pixel_texture
	version		1.0
	glxflags	SGI
	glxropcode	2059
	extension
	glsopcode	0x0170
	offset		430

###############################################################################
#
# Extension #15 (variant)
# SGIS_pixel_texture commands
# Both SGIS and SGIX forms have extension #15!
#
###############################################################################

PixelTexGenParameteriSGIS(pname, param)
	return		void
	param		pname		PixelTexGenParameterNameSGIS in value
	param		param		CheckedInt32 in value
	category	SGIS_pixel_texture
	version		1.0
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	gl-enum
	glsopcode	0x0192
	offset		431

PixelTexGenParameterivSGIS(pname, params)
	return		void
	param		pname		PixelTexGenParameterNameSGIS in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	SGIS_pixel_texture
	version		1.0
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	gl-enum
	glsopcode	0x0193
	offset		432

PixelTexGenParameterfSGIS(pname, param)
	return		void
	param		pname		PixelTexGenParameterNameSGIS in value
	param		param		CheckedFloat32 in value
	category	SGIS_pixel_texture
	version		1.0
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	gl-enum
	glsopcode	0x0194
	offset		433

PixelTexGenParameterfvSGIS(pname, params)
	return		void
	param		pname		PixelTexGenParameterNameSGIS in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	SGIS_pixel_texture
	version		1.0
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	gl-enum
	glsopcode	0x0195
	offset		434

GetPixelTexGenParameterivSGIS(pname, params)
	return		void
	param		pname		PixelTexGenParameterNameSGIS in value
	param		params		CheckedInt32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	SGIS_pixel_texture
	version		1.0
	extension
	glxvendorpriv	?
	glxflags	ignore
	glsflags	get
	glsopcode	0x0196
	offset		435

GetPixelTexGenParameterfvSGIS(pname, params)
	return		void
	param		pname		PixelTexGenParameterNameSGIS in value
	param		params		CheckedFloat32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	SGIS_pixel_texture
	version		1.0
	extension
	glxvendorpriv	?
	glxflags	ignore
	glsflags	get
	glsopcode	0x0197
	offset		436

###############################################################################
#
# Extension #16
# SGIS_texture4D commands
#
###############################################################################

TexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		internalformat	PixelInternalFormat in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		size4d		SizeI in value
	param		border		CheckedInt32 in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width/height/depth/size4d)]
	category	SGIS_texture4D
	dlflags		handcode
	glxflags	client-handcode server-handcode SGI
	version		1.0
	glxropcode	2057
	extension
	glsflags	pixel-null pixel-unpack
	glsopcode	0x016E
	offset		437

TexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels)
	return		void
	param		target		TextureTarget in value
	param		level		CheckedInt32 in value
	param		xoffset		CheckedInt32 in value
	param		yoffset		CheckedInt32 in value
	param		zoffset		CheckedInt32 in value
	param		woffset		CheckedInt32 in value
	param		width		SizeI in value
	param		height		SizeI in value
	param		depth		SizeI in value
	param		size4d		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		pixels		Void in array [COMPSIZE(format/type/width/height/depth/size4d)]
	category	SGIS_texture4D
	dlflags		handcode
	glxflags	client-handcode server-handcode SGI
	version		1.0
	glxropcode	2058
	extension
	glsflags	pixel-unpack
	glsopcode	0x016F
	offset		438

###############################################################################
#
# Extension #17
# SGI_texture_color_table commands
#
###############################################################################

# (none)
newcategory: SGI_texture_color_table

###############################################################################
#
# Extension #18
# EXT_cmyka commands
#
###############################################################################

# (none)
newcategory: EXT_cmyka

###############################################################################
#
# Extension #19 - skipped
#
###############################################################################

###############################################################################
#
# Extension #20
# EXT_texture_object commands
#
###############################################################################

AreTexturesResidentEXT(n, textures, residences)
	return		Boolean
	param		n		SizeI in value
	param		textures	Texture in array [n]
	param		residences	Boolean out array [n]
	category	EXT_texture_object
	glxflags	EXT
	glxvendorpriv	11
	dlflags		notlistable
	version		1.0
	extension
	glsflags	get
	glsopcode	0x0147
	offset		439

BindTextureEXT(target, texture)
	return		void
	param		target	TextureTarget in value
	param		texture Texture in value
	category	EXT_texture_object
	version		1.0
	glxflags	EXT
	glxropcode	4117
	extension
	alias		BindTexture
	glsalias	BindTexture

DeleteTexturesEXT(n, textures)
	return		void
	param		n		SizeI in value
	param		textures	Texture in array [n]
	category	EXT_texture_object
	dlflags		notlistable
	version		1.0
	glxflags	EXT
	glxvendorpriv	12
	extension
	glsopcode	0x0149
	offset		561

GenTexturesEXT(n, textures)
	return		void
	param		n		SizeI in value
	param		textures	Texture out array [n]
	category	EXT_texture_object
	dlflags		notlistable
	version		1.0
	glxflags	EXT
	glxvendorpriv	13
	extension
	glsopcode	0x014A
	offset		440

IsTextureEXT(texture)
	return		Boolean
	param		texture Texture in value
	category	EXT_texture_object
	dlflags		notlistable
	version		1.0
	glxflags	EXT
	glxvendorpriv	14
	extension
	glsflags	get
	glsopcode	0x014B
	offset		441

PrioritizeTexturesEXT(n, textures, priorities)
	return		void
	param		n		SizeI in value
	param		textures	Texture in array [n]
	param		priorities	ClampedFloat32 in array [n]
	category	EXT_texture_object
	glxflags	EXT
	version		1.0
	glxropcode	4118
	extension
	alias		PrioritizeTextures
	glsalias	PrioritizeTextures

###############################################################################
#
# Extension #21
# SGIS_detail_texture commands
#
###############################################################################

DetailTexFuncSGIS(target, n, points)
	return		void
	param		target		TextureTarget in value
	param		n		SizeI in value
	param		points		Float32 in array [n*2]
	category	SGIS_detail_texture
	glxflags	SGI
	version		1.0
	glxropcode	2051
	extension
	glsopcode	0x0163
	offset		442

GetDetailTexFuncSGIS(target, points)
	return		void
	param		target		TextureTarget in value
	param		points		Float32 out array [COMPSIZE(target)]
	category	SGIS_detail_texture
	dlflags		notlistable
	version		1.0
	glxflags	SGI
	glxvendorpriv	4096
	extension
	glsflags	get
	glsopcode	0x0164
	offset		443

###############################################################################
#
# Extension #22
# SGIS_sharpen_texture commands
#
###############################################################################

SharpenTexFuncSGIS(target, n, points)
	return		void
	param		target		TextureTarget in value
	param		n		SizeI in value
	param		points		Float32 in array [n*2]
	category	SGIS_sharpen_texture
	glxflags	SGI
	version		1.0
	glxropcode	2052
	extension
	glsopcode	0x0165
	offset		444

GetSharpenTexFuncSGIS(target, points)
	return		void
	param		target		TextureTarget in value
	param		points		Float32 out array [COMPSIZE(target)]
	category	SGIS_sharpen_texture
	dlflags		notlistable
	version		1.0
	glxflags	SGI
	glxvendorpriv	4097
	extension
	glsflags	get
	glsopcode	0x0166
	offset		445

###############################################################################
#
# EXT_packed_pixels commands
# Extension #23
#
###############################################################################

# (none)
newcategory: EXT_packed_pixels

###############################################################################
#
# Extension #24
# SGIS_texture_lod commands
#
###############################################################################

# (none)
newcategory: SGIS_texture_lod

###############################################################################
#
# Extension #25
# SGIS_multisample commands
#
###############################################################################

SampleMaskSGIS(value, invert)
	return		void
	param		value		ClampedFloat32 in value
	param		invert		Boolean in value
	category	SGIS_multisample
	version		1.1
	glxropcode	2048
	glxflags	SGI
	extension
	alias		SampleMaskEXT
	glsalias	SampleMaskEXT

SamplePatternSGIS(pattern)
	return		void
	param		pattern		SamplePatternSGIS in value
	category	SGIS_multisample
	version		1.0
	glxropcode	2049
	glxflags	SGI
	extension
	alias		SamplePatternEXT
	glsalias	SamplePatternEXT

###############################################################################
#
# Extension #26 - no specification?
#
###############################################################################

###############################################################################
#
# Extension #27
# EXT_rescale_normal commands
#
###############################################################################

# (none)
newcategory: EXT_rescale_normal

###############################################################################
#
# Extension #28 - GLX_EXT_visual_info
# Extension #29 - skipped
#
###############################################################################

###############################################################################
#
# Extension #30
# EXT_vertex_array commands
#
###############################################################################

ArrayElementEXT(i)
	return		void
	param		i		Int32 in value
	category	EXT_vertex_array
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.0
	extension
	alias		ArrayElement
	glsalias	ArrayElement

ColorPointerEXT(size, type, stride, count, pointer)
	return		void
	param		size		Int32 in value
	param		type		ColorPointerType in value
	param		stride		SizeI in value
	param		count		SizeI in value
	param		pointer		Void in array [COMPSIZE(size/type/stride/count)] retained
	category	EXT_vertex_array
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	extension
	glsflags	client
	glsopcode	0x013F
	offset		448

DrawArraysEXT(mode, first, count)
	return		void
	param		mode		BeginMode in value
	param		first		Int32 in value
	param		count		SizeI in value
	category	EXT_vertex_array
	dlflags		handcode
	glxflags	client-handcode server-handcode EXT
	version		1.0
	glxropcode	4116
	extension
	alias		DrawArrays
	glsopcode	0x0140

EdgeFlagPointerEXT(stride, count, pointer)
	return		void
	param		stride		SizeI in value
	param		count		SizeI in value
	param		pointer		Boolean in array [COMPSIZE(stride/count)] retained
	category	EXT_vertex_array
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	extension
	glsflags	client
	glsopcode	0x0141
	offset		449

GetPointervEXT(pname, params)
	return		void
	param		pname		GetPointervPName in value
	param		params		VoidPointer out array [1]
	category	EXT_vertex_array
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	extension
	alias		GetPointerv
	glsalias	GetPointerv

IndexPointerEXT(type, stride, count, pointer)
	return		void
	param		type		IndexPointerType in value
	param		stride		SizeI in value
	param		count		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride/count)] retained
	category	EXT_vertex_array
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	extension
	glsflags	client
	glsopcode	0x0143
	offset		450

NormalPointerEXT(type, stride, count, pointer)
	return		void
	param		type		NormalPointerType in value
	param		stride		SizeI in value
	param		count		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride/count)] retained
	category	EXT_vertex_array
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	extension
	glsflags	client
	glsopcode	0x0144
	offset		451

TexCoordPointerEXT(size, type, stride, count, pointer)
	return		void
	param		size		Int32 in value
	param		type		TexCoordPointerType in value
	param		stride		SizeI in value
	param		count		SizeI in value
	param		pointer		Void in array [COMPSIZE(size/type/stride/count)] retained
	category	EXT_vertex_array
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	extension
	glsflags	client
	glsopcode	0x0145
	offset		452

VertexPointerEXT(size, type, stride, count, pointer)
	return		void
	param		size		Int32 in value
	param		type		VertexPointerType in value
	param		stride		SizeI in value
	param		count		SizeI in value
	param		pointer		Void in array [COMPSIZE(size/type/stride/count)] retained
	category	EXT_vertex_array
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.0
	extension
	glsflags	client
	glsopcode	0x0146
	offset		453

###############################################################################
#
# Extension #31
# EXT_misc_attribute commands
#
###############################################################################

# (none)
newcategory: EXT_misc_attribute

###############################################################################
#
# Extension #32
# SGIS_generate_mipmap commands
#
###############################################################################

# (none)
newcategory: SGIS_generate_mipmap

###############################################################################
#
# Extension #33
# SGIX_clipmap commands
#
###############################################################################

# (none)
newcategory: SGIX_clipmap

###############################################################################
#
# Extension #34
# SGIX_shadow commands
#
###############################################################################

# (none)
newcategory: SGIX_shadow

###############################################################################
#
# Extension #35
# SGIS_texture_edge_clamp commands
#
###############################################################################

# (none)
newcategory: SGIS_texture_edge_clamp

###############################################################################
#
# Extension #36
# SGIS_texture_border_clamp commands
#
###############################################################################

# (none)
newcategory: SGIS_texture_border_clamp

###############################################################################
#
# Extension #37
# EXT_blend_minmax commands
#
###############################################################################

BlendEquationEXT(mode)
	return		void
	param		mode		BlendEquationModeEXT in value
	category	EXT_blend_minmax
	version		1.0
	glxropcode	4097
	glxflags	EXT
	extension	soft
	alias		BlendEquation
	glsalias	BlendEquation

###############################################################################
#
# Extension #38
# EXT_blend_subtract commands
#
###############################################################################

# (none)
newcategory: EXT_blend_subtract

###############################################################################
#
# Extension #39
# EXT_blend_logic_op commands
#
###############################################################################

# (none)
newcategory: EXT_blend_logic_op

###############################################################################
#
# Extension #40 - GLX_SGI_swap_control
# Extension #41 - GLX_SGI_video_sync
# Extension #42 - GLX_SGI_make_current_read
# Extension #43 - GLX_SGIX_video_source
# Extension #44 - GLX_EXT_visual_rating
#
###############################################################################

###############################################################################
#
# Extension #45
# SGIX_interlace commands
#
###############################################################################

# (none)
newcategory: SGIX_interlace

###############################################################################
#
# Extension #46
# SGIX_pixel_tiles commands
#
###############################################################################

# (none)
newcategory: SGIX_pixel_tiles

###############################################################################
#
# Extension #47 - GLX_EXT_import_context
# Extension #48 - skipped
# Extension #49 - GLX_SGIX_fbconfig
# Extension #50 - GLX_SGIX_pbuffer
#
###############################################################################

###############################################################################
#
# Extension #51
# SGIX_texture_select commands
#
###############################################################################

# (none)
newcategory: SGIX_texture_select

###############################################################################
#
# Extension #52
# SGIX_sprite commands
#
###############################################################################

SpriteParameterfSGIX(pname, param)
	return		void
	param		pname		SpriteParameterNameSGIX in value
	param		param		CheckedFloat32 in value
	category	SGIX_sprite
	version		1.0
	glxflags	SGI
	glxropcode	2060
	extension
	glsflags	gl-enum
	glsopcode	0x0171
	offset		454

SpriteParameterfvSGIX(pname, params)
	return		void
	param		pname		SpriteParameterNameSGIX in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	SGIX_sprite
	version		1.0
	glxflags	SGI
	glxropcode	2061
	extension
	glsflags	gl-enum
	glsopcode	0x0172
	offset		455

SpriteParameteriSGIX(pname, param)
	return		void
	param		pname		SpriteParameterNameSGIX in value
	param		param		CheckedInt32 in value
	category	SGIX_sprite
	version		1.0
	glxflags	SGI
	glxropcode	2062
	extension
	glsflags	gl-enum
	glsopcode	0x0173
	offset		456

SpriteParameterivSGIX(pname, params)
	return		void
	param		pname		SpriteParameterNameSGIX in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	SGIX_sprite
	version		1.0
	glxflags	SGI
	glxropcode	2063
	extension
	glsflags	gl-enum
	glsopcode	0x0174
	offset		457

###############################################################################
#
# Extension #53
# SGIX_texture_multi_buffer commands
#
###############################################################################

# (none)
newcategory: SGIX_texture_multi_buffer

###############################################################################
#
# Extension #54
# EXT_point_parameters / SGIS_point_parameters commands
#
###############################################################################

PointParameterfEXT(pname, param)
	return		void
	param		pname		PointParameterNameARB in value
	param		param		CheckedFloat32 in value
	category	EXT_point_parameters
	version		1.0
	glxflags	SGI
	extension
	alias		PointParameterfARB
	glsalias	PointParameterfARB

PointParameterfvEXT(pname, params)
	return		void
	param		pname		PointParameterNameARB in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	EXT_point_parameters
	version		1.0
	glxflags	SGI
	extension
	alias		PointParameterfvARB
	glsalias	PointParameterfvARB

PointParameterfSGIS(pname, param)
	return		void
	param		pname		PointParameterNameARB in value
	param		param		CheckedFloat32 in value
	category	SGIS_point_parameters
	version		1.0
	glxflags	SGI
	extension
	alias		PointParameterfARB
	glsalias	PointParameterfARB

PointParameterfvSGIS(pname, params)
	return		void
	param		pname		PointParameterNameARB in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	SGIS_point_parameters
	version		1.0
	glxflags	SGI
	extension
	alias		PointParameterfvARB
	glsalias	PointParameterfvARB

###############################################################################
#
# Extension #55
# SGIX_instruments commands
#
###############################################################################

GetInstrumentsSGIX()
	return		Int32
	dlflags		notlistable
	category	SGIX_instruments
	version		1.0
	glxflags	SGI
	glxvendorpriv	4102
	extension
	glsflags	get
	glsopcode	0x017A
	offset		460

InstrumentsBufferSGIX(size, buffer)
	return		void
	param		size		SizeI in value
	param		buffer		Int32 out array [size] retained
	dlflags		notlistable
	category	SGIX_instruments
	version		1.0
	glxflags	SGI
	glxvendorpriv	4103
	extension
	glsflags	client
	glsopcode	0x017B
	offset		461

PollInstrumentsSGIX(marker_p)
	return		Int32
	param		marker_p	Int32 out array [1]
	dlflags		notlistable
	category	SGIX_instruments
	version		1.0
	glxflags	SGI
	glxvendorpriv	4104
	extension
	glsflags	get
	glsopcode	0x017C
	offset		462

ReadInstrumentsSGIX(marker)
	return		void
	param		marker		Int32 in value
	category	SGIX_instruments
	version		1.0
	glxflags	SGI
	glxropcode	2077
	extension
	glsopcode	0x017D
	offset		463

StartInstrumentsSGIX()
	return		void
	category	SGIX_instruments
	version		1.0
	glxflags	SGI
	glxropcode	2069
	extension
	glsopcode	0x017E
	offset		464

StopInstrumentsSGIX(marker)
	return		void
	param		marker		Int32 in value
	category	SGIX_instruments
	version		1.0
	glxflags	SGI
	glxropcode	2070
	extension
	glsopcode	0x017F
	offset		465

###############################################################################
#
# Extension #56
# SGIX_texture_scale_bias commands
#
###############################################################################

# (none)
newcategory: SGIX_texture_scale_bias

###############################################################################
#
# Extension #57
# SGIX_framezoom commands
#
###############################################################################

FrameZoomSGIX(factor)
	return		void
	param		factor		CheckedInt32 in value
	category	SGIX_framezoom
	version		1.0
	glxflags	SGI
	glxropcode	2072
	extension
	glsopcode	0x0182
	offset		466

###############################################################################
#
# Extension #58
# SGIX_tag_sample_buffer commands
#
###############################################################################

TagSampleBufferSGIX()
	return		void
	category	SGIX_tag_sample_buffer
	version		1.0
	glxropcode	2050
	glxflags	SGI
	extension
	glsopcode	0x0162
	offset		467

###############################################################################
#
# Extension #59
# SGIX_polynomial_ffd commands
#
###############################################################################

DeformationMap3dSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points)
	return		void
	param		target		FfdTargetSGIX in value
	param		u1		CoordD in value
	param		u2		CoordD in value
	param		ustride		Int32 in value
	param		uorder		CheckedInt32 in value
	param		v1		CoordD in value
	param		v2		CoordD in value
	param		vstride		Int32 in value
	param		vorder		CheckedInt32 in value
	param		w1		CoordD in value
	param		w2		CoordD in value
	param		wstride		Int32 in value
	param		worder		CheckedInt32 in value
	param		points		CoordD in array [COMPSIZE(target/ustride/uorder/vstride/vorder/wstride/worder)]
	dlflags		handcode
	category	SGIX_polynomial_ffd
	version		1.0
	glxflags	SGI ignore
	glxropcode	2073
	extension
	glsflags	capture-handcode
	glsopcode	0x0184
	offset		?

DeformationMap3fSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points)
	return		void
	param		target		FfdTargetSGIX in value
	param		u1		CoordF in value
	param		u2		CoordF in value
	param		ustride		Int32 in value
	param		uorder		CheckedInt32 in value
	param		v1		CoordF in value
	param		v2		CoordF in value
	param		vstride		Int32 in value
	param		vorder		CheckedInt32 in value
	param		w1		CoordF in value
	param		w2		CoordF in value
	param		wstride		Int32 in value
	param		worder		CheckedInt32 in value
	param		points		CoordF in array [COMPSIZE(target/ustride/uorder/vstride/vorder/wstride/worder)]
	category	SGIX_polynomial_ffd
	dlflags		handcode
	version		1.0
	glxflags	SGI ignore
	glxropcode	2074
	extension
	glsflags	capture-handcode
	glsopcode	0x0185
	offset		?

DeformSGIX(mask)
	return		void
	param		mask		FfdMaskSGIX in value
	category	SGIX_polynomial_ffd
	version		1.0
	glxflags	SGI ignore
	glxropcode	2075
	extension
	glsopcode	0x0186
	offset		?

LoadIdentityDeformationMapSGIX(mask)
	return		void
	param		mask		FfdMaskSGIX in value
	category	SGIX_polynomial_ffd
	version		1.0
	glxflags	SGI ignore
	glxropcode	2076
	extension
	glsopcode	0x0187
	offset		?

###############################################################################
#
# Extension #60
# SGIX_reference_plane commands
#
###############################################################################

ReferencePlaneSGIX(equation)
	return		void
	param		equation	Float64 in array [4]
	category	SGIX_reference_plane
	version		1.0
	glxflags	SGI
	glxropcode	2071
	extension
	glsopcode	0x0181
	offset		468

###############################################################################
#
# Extension #61
# SGIX_flush_raster commands
#
###############################################################################

FlushRasterSGIX()
	return		void
	category	SGIX_flush_raster
	version		1.0
	dlflags		notlistable
	glxflags	SGI
	glxvendorpriv	4105
	extension
	glsopcode	0x0180
	offset		469

###############################################################################
#
# Extension #62 - GLX_SGIX_cushion
#
###############################################################################

###############################################################################
#
# Extension #63
# SGIX_depth_texture commands
#
###############################################################################

# (none)
newcategory: SGIX_depth_texture

###############################################################################
#
# Extension #64
# SGIS_fog_function commands
#
###############################################################################

FogFuncSGIS(n, points)
	return		void
	param		n		SizeI in value
	param		points		Float32 in array [n*2]
	category	SGIS_fog_function
	version		1.1
	glxflags	SGI
	glxropcode	2067
	extension
	glsopcode	0x0179
	offset

# Need to insert GLX information
GetFogFuncSGIS(points)
	return		void
	param		points		Float32 out array [COMPSIZE()]
	category	SGIS_fog_function
	version		1.1
	dlflags		notlistable
	glxflags	ignore
	extension
	glsflags	get
	glsopcode	0x0191
	offset

###############################################################################
#
# Extension #65
# SGIX_fog_offset commands
#
###############################################################################

# (none)
newcategory: SGIX_fog_offset

###############################################################################
#
# Extension #66
# HP_image_transform commands
#
###############################################################################

ImageTransformParameteriHP(target, pname, param)
	return		void
	param		target		ImageTransformTargetHP in value
	param		pname		ImageTransformPNameHP in value
	param		param		Int32 in value
	category	HP_image_transform
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ImageTransformParameterfHP(target, pname, param)
	return		void
	param		target		ImageTransformTargetHP in value
	param		pname		ImageTransformPNameHP in value
	param		param		Float32 in value
	category	HP_image_transform
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ImageTransformParameterivHP(target, pname, params)
	return		void
	param		target		ImageTransformTargetHP in value
	param		pname		ImageTransformPNameHP in value
	param		params		Int32 in array [COMPSIZE(pname)]
	category	HP_image_transform
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ImageTransformParameterfvHP(target, pname, params)
	return		void
	param		target		ImageTransformTargetHP in value
	param		pname		ImageTransformPNameHP in value
	param		params		Float32 in array [COMPSIZE(pname)]
	category	HP_image_transform
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

GetImageTransformParameterivHP(target, pname, params)
	return		void
	param		target		ImageTransformTargetHP in value
	param		pname		ImageTransformPNameHP in value
	param		params		Int32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	HP_image_transform
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

GetImageTransformParameterfvHP(target, pname, params)
	return		void
	param		target		ImageTransformTargetHP in value
	param		pname		ImageTransformPNameHP in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	HP_image_transform
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #67
# HP_convolution_border_modes commands
#
###############################################################################

# (none)
newcategory: HP_convolution_border_modes

###############################################################################
#
# Extension #68
# INGR_palette_buffer commands
#
###############################################################################

#@ (Intergraph hasn't provided a spec)

###############################################################################
#
# Extension #69
# SGIX_texture_add_env commands
#
###############################################################################

# (none)
newcategory: SGIX_texture_add_env

###############################################################################
#
# Extension #70 - skipped
# Extension #71 - skipped
# Extension #72 - skipped
# Extension #73 - skipped
#
###############################################################################

###############################################################################
#
# Extension #74
# EXT_color_subtable commands
#
# This was probably never actually shipped as an EXT - just written up as a
# reference for OpenGL 1.2 ARB_imaging.
#
###############################################################################

ColorSubTableEXT(target, start, count, format, type, data)
	return		void
	param		target		ColorTableTarget in value
	param		start		SizeI in value
	param		count		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		data		Void in array [COMPSIZE(format/type/count)]
	category	EXT_color_subtable
	version		1.2
	alias		ColorSubTable
	glsalias	ColorSubTable

CopyColorSubTableEXT(target, start, x, y, width)
	return		void
	param		target		ColorTableTarget in value
	param		start		SizeI in value
	param		x		WinCoord in value
	param		y		WinCoord in value
	param		width		SizeI in value
	category	EXT_color_subtable
	version		1.2
	alias		CopyColorSubTable
	glsalias	CopyColorSubTable

###############################################################################
#
# Extension #75 - GLU_EXT_object_space_tess
#
###############################################################################

###############################################################################
#
# Extension #76
# PGI_vertex_hints commands
#
###############################################################################

# (none)
newcategory: PGI_vertex_hints

###############################################################################
#
# Extension #77
# PGI_misc_hints commands
#
###############################################################################

HintPGI(target, mode)
	return		void
	param		target		HintTargetPGI in value
	param		mode		Int32 in value
	category	PGI_misc_hints
	version		1.1
	offset		544
	glsopcode	0x01D0

###############################################################################
#
# Extension #78
# EXT_paletted_texture commands
#
###############################################################################

ColorTableEXT(target, internalFormat, width, format, type, table)
	return		void
	param		target		ColorTableTarget in value
	param		internalFormat	PixelInternalFormat in value
	param		width		SizeI in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		table		Void in array [COMPSIZE(format/type/width)]
	category	EXT_paletted_texture
	version		1.1
	alias		ColorTable
	glsalias	ColorTable

GetColorTableEXT(target, format, type, data)
	return		void
	param		target		ColorTableTarget in value
	param		format		PixelFormat in value
	param		type		PixelType in value
	param		data		Void out array [COMPSIZE(target/format/type)]
	category	EXT_paletted_texture
	version		1.1
	offset		550
	glsalias	GetColorTable

GetColorTableParameterivEXT(target, pname, params)
	return		void
	param		target		ColorTableTarget in value
	param		pname		GetColorTableParameterPName in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	EXT_paletted_texture
	version		1.1
	offset		551
	glsalias	GetColorTableParameteriv

GetColorTableParameterfvEXT(target, pname, params)
	return		void
	param		target		ColorTableTarget in value
	param		pname		GetColorTableParameterPName in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	EXT_paletted_texture
	version		1.1
	offset		552
	glsalias	GetColorTableParameterfv

###############################################################################
#
# Extension #79
# EXT_clip_volume_hint commands
#
###############################################################################

# (none)
newcategory: EXT_clip_volume_hint

###############################################################################
#
# Extension #80
# SGIX_list_priority commands
#
###############################################################################

# @@@ Needs vendorpriv opcodes assigned
GetListParameterfvSGIX(list, pname, params)
	return		void
	param		list		List in value
	param		pname		ListParameterName in value
	param		params		CheckedFloat32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	glxflags	ignore
	category	SGIX_list_priority
	version		1.0
	glxvendorpriv	?
	extension
	glsopcode	0x0188
	offset		470

# @@@ Needs vendorpriv opcodes assigned
GetListParameterivSGIX(list, pname, params)
	return		void
	param		list		List in value
	param		pname		ListParameterName in value
	param		params		CheckedInt32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	glxflags	ignore
	category	SGIX_list_priority
	version		1.0
	glxvendorpriv	?
	extension
	glsopcode	0x0189
	offset		471

ListParameterfSGIX(list, pname, param)
	return		void
	param		list		List in value
	param		pname		ListParameterName in value
	param		param		CheckedFloat32 in value
	dlflags		notlistable
	glxflags	ignore
	category	SGIX_list_priority
	version		1.0
	glxropcode	2078
	extension
	glsopcode	0x018A
	offset		472

ListParameterfvSGIX(list, pname, params)
	return		void
	param		list		List in value
	param		pname		ListParameterName in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	dlflags		notlistable
	glxflags	ignore
	category	SGIX_list_priority
	version		1.0
	glxropcode	2079
	extension
	glsopcode	0x018B
	offset		473

ListParameteriSGIX(list, pname, param)
	return		void
	param		list		List in value
	param		pname		ListParameterName in value
	param		param		CheckedInt32 in value
	dlflags		notlistable
	glxflags	ignore
	category	SGIX_list_priority
	version		1.0
	glxropcode	2080
	extension
	glsopcode	0x018C
	offset		474

ListParameterivSGIX(list, pname, params)
	return		void
	param		list		List in value
	param		pname		ListParameterName in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	dlflags		notlistable
	glxflags	ignore
	category	SGIX_list_priority
	version		1.0
	glxropcode	2081
	extension
	glsopcode	0x018D
	offset		475

###############################################################################
#
# Extension #81
# SGIX_ir_instrument1 commands
#
###############################################################################

# (none)
newcategory: SGIX_ir_instrument1

###############################################################################
#
# Extension #82
# SGIX_calligraphic_fragment commands
#
###############################################################################

# (none)
newcategory: SGIX_calligraphic_fragment

###############################################################################
#
# Extension #83 - GLX_SGIX_video_resize
#
###############################################################################

###############################################################################
#
# Extension #84
# SGIX_texture_lod_bias commands
#
###############################################################################

# (none)
newcategory: SGIX_texture_lod_bias

###############################################################################
#
# Extension #85 - skipped
# Extension #86 - GLX_SGIX_dmbuffer
# Extension #87 - skipped
# Extension #88 - skipped
# Extension #89 - skipped
#
###############################################################################

###############################################################################
#
# Extension #90
# SGIX_shadow_ambient commands
#
###############################################################################

# (none)
newcategory: SGIX_shadow_ambient

###############################################################################
#
# Extension #91 - GLX_SGIX_swap_group
# Extension #92 - GLX_SGIX_swap_barrier
#
###############################################################################

###############################################################################
#
# Extension #93
# EXT_index_texture commands
#
###############################################################################

# (none)
newcategory: EXT_index_texture

###############################################################################
#
# Extension #94
# EXT_index_material commands
#
###############################################################################

IndexMaterialEXT(face, mode)
	return		void
	param		face		MaterialFace in value
	param		mode		IndexMaterialParameterEXT in value
	category	EXT_index_material
	version		1.1
	extension	soft
	glxflags	ignore
	glsopcode	0x01D1
	offset		538

###############################################################################
#
# Extension #95
# EXT_index_func commands
#
###############################################################################

IndexFuncEXT(func, ref)
	return		void
	param		func		IndexFunctionEXT in value
	param		ref		ClampedFloat32 in value
	category	EXT_index_func
	version		1.1
	extension	soft
	glxflags	ignore
	glsopcode	0x01D2
	offset		539

###############################################################################
#
# Extension #96
# EXT_index_array_formats commands
#
###############################################################################

# (none)
newcategory: EXT_index_array_formats

###############################################################################
#
# Extension #97
# EXT_compiled_vertex_array commands
#
###############################################################################

LockArraysEXT(first, count)
	return		void
	param		first		Int32 in value
	param		count		SizeI in value
	category	EXT_compiled_vertex_array
	version		1.1
	dlflags		notlistable
	extension	soft
	glxflags	ignore
	glsopcode	0x01D3
	offset		540

UnlockArraysEXT()
	return		void
	category	EXT_compiled_vertex_array
	version		1.1
	dlflags		notlistable
	extension	soft
	glxflags	ignore
	glsopcode	0x01D4
	offset		541

###############################################################################
#
# Extension #98
# EXT_cull_vertex commands
#
###############################################################################

CullParameterdvEXT(pname, params)
	return		void
	param		pname		CullParameterEXT in value
	param		params		Float64 out array [4]
	category	EXT_cull_vertex
	version		1.1
	dlflags		notlistable
	extension	soft
	glxflags	ignore
	glsopcode	0x01D5
	offset		542

CullParameterfvEXT(pname, params)
	return		void
	param		pname		CullParameterEXT in value
	param		params		Float32 out array [4]
	category	EXT_cull_vertex
	version		1.1
	dlflags		notlistable
	extension	soft
	glxflags	ignore
	glsopcode	0x01D6
	offset		543

###############################################################################
#
# Extension #99 - skipped
# Extension #100 - GLU_EXT_nurbs_tessellator
#
###############################################################################

###############################################################################
#
# Extension #101
# SGIX_ycrcb commands
#
###############################################################################

# (none)
newcategory: SGIX_ycrcb

###############################################################################
#
# Extension #102
# SGIX_fragment_lighting commands
#
###############################################################################

FragmentColorMaterialSGIX(face, mode)
	return		void
	param		face		MaterialFace in value
	param		mode		MaterialParameter in value
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsopcode	0x019E
	offset		476

FragmentLightfSGIX(light, pname, param)
	return		void
	param		light		FragmentLightNameSGIX in value
	param		pname		FragmentLightParameterSGIX in value
	param		param		CheckedFloat32 in value
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsopcode	0x019F
	offset		477

FragmentLightfvSGIX(light, pname, params)
	return		void
	param		light		FragmentLightNameSGIX in value
	param		pname		FragmentLightParameterSGIX in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsopcode	0x01A0
	offset		478

FragmentLightiSGIX(light, pname, param)
	return		void
	param		light		FragmentLightNameSGIX in value
	param		pname		FragmentLightParameterSGIX in value
	param		param		CheckedInt32 in value
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsopcode	0x01A1
	offset		479

FragmentLightivSGIX(light, pname, params)
	return		void
	param		light		FragmentLightNameSGIX in value
	param		pname		FragmentLightParameterSGIX in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsopcode	0x01A2
	offset		480

FragmentLightModelfSGIX(pname, param)
	return		void
	param		pname		FragmentLightModelParameterSGIX in value
	param		param		CheckedFloat32 in value
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsflags	gl-enum
	glsopcode	0x01A3
	offset		481

FragmentLightModelfvSGIX(pname, params)
	return		void
	param		pname		FragmentLightModelParameterSGIX in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsflags	gl-enum
	glsopcode	0x01A4
	offset		482

FragmentLightModeliSGIX(pname, param)
	return		void
	param		pname		FragmentLightModelParameterSGIX in value
	param		param		CheckedInt32 in value
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsflags	gl-enum
	glsopcode	0x01A5
	offset		483

FragmentLightModelivSGIX(pname, params)
	return		void
	param		pname		FragmentLightModelParameterSGIX in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsflags	gl-enum
	glsopcode	0x01A6
	offset		484

FragmentMaterialfSGIX(face, pname, param)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		param		CheckedFloat32 in value
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsopcode	0x01A7
	offset		485

FragmentMaterialfvSGIX(face, pname, params)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsopcode	0x01A8
	offset		486

FragmentMaterialiSGIX(face, pname, param)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		param		CheckedInt32 in value
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsopcode	0x01A9
	offset		487

FragmentMaterialivSGIX(face, pname, params)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsopcode	0x01AA
	offset		488

GetFragmentLightfvSGIX(light, pname, params)
	return		void
	param		light		FragmentLightNameSGIX in value
	param		pname		FragmentLightParameterSGIX in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	SGIX_fragment_lighting
	dlflags		notlistable
	glxflags	ignore
	version		1.0
	extension
	glsflags	get
	glsopcode	0x01AB
	offset		489

GetFragmentLightivSGIX(light, pname, params)
	return		void
	param		light		FragmentLightNameSGIX in value
	param		pname		FragmentLightParameterSGIX in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	SGIX_fragment_lighting
	dlflags		notlistable
	glxflags	ignore
	version		1.0
	extension
	glsflags	get
	glsopcode	0x01AC
	offset		490

GetFragmentMaterialfvSGIX(face, pname, params)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	SGIX_fragment_lighting
	dlflags		notlistable
	glxflags	ignore
	version		1.0
	extension
	glsflags	get
	glsopcode	0x01AD
	offset		491

GetFragmentMaterialivSGIX(face, pname, params)
	return		void
	param		face		MaterialFace in value
	param		pname		MaterialParameter in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	SGIX_fragment_lighting
	dlflags		notlistable
	glxflags	ignore
	version		1.0
	extension
	glsflags	get
	glsopcode	0x01AE
	offset		492

LightEnviSGIX(pname, param)
	return		void
	param		pname		LightEnvParameterSGIX in value
	param		param		CheckedInt32 in value
	category	SGIX_fragment_lighting
	glxflags	ignore
	version		1.0
	extension
	glsflags	gl-enum
	glsopcode	0x01AF
	offset		493

###############################################################################
#
# Extension #103 - skipped
# Extension #104 - skipped
# Extension #105 - skipped
# Extension #106 - skipped
# Extension #107 - skipped
# Extension #108 - skipped
# Extension #109 - skipped
#
###############################################################################

###############################################################################
#
# Extension #110
# IBM_rasterpos_clip commands
#
###############################################################################

# (none)
newcategory: IBM_rasterpos_clip

###############################################################################
#
# Extension #111
# HP_texture_lighting commands
#
###############################################################################

# (none)
newcategory: HP_texture_lighting

###############################################################################
#
# Extension #112
# EXT_draw_range_elements commands
#
###############################################################################

# Spec entries to be written
DrawRangeElementsEXT(mode, start, end, count, type, indices)
	return		void
	param		mode		BeginMode in value
	param		start		UInt32 in value
	param		end		UInt32 in value
	param		count		SizeI in value
	param		type		DrawElementsType in value
	param		indices		Void in array [COMPSIZE(count/type)]
	category	EXT_draw_range_elements
	dlflags		handcode
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	alias		DrawRangeElements
	glsalias	DrawRangeElements

###############################################################################
#
# Extension #113
# WIN_phong_shading commands
#
###############################################################################

# (none)
newcategory: WIN_phong_shading

###############################################################################
#
# Extension #114
# WIN_specular_fog commands
#
###############################################################################

# (none)
newcategory: WIN_specular_fog

###############################################################################
#
# Extension #115 - skipped
# Extension #116 - skipped
#
###############################################################################

###############################################################################
#
# Extension #117
# EXT_light_texture commands
#
###############################################################################

# Spec entries to be written
ApplyTextureEXT(mode)
	return		void
	param		mode		LightTextureModeEXT in value
	category	EXT_light_texture
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TextureLightEXT(pname)
	return		void
	param		pname		LightTexturePNameEXT in value
	category	EXT_light_texture
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TextureMaterialEXT(face, mode)
	return		void
	param		face		MaterialFace in value
	param		mode		MaterialParameter in value
	category	EXT_light_texture
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #118 - skipped
#
###############################################################################

###############################################################################
#
# Extension #119
# SGIX_blend_alpha_minmax commands
#
###############################################################################

# (none)
newcategory: SGIX_blend_alpha_minmax

###############################################################################
#
# Extension #120 - skipped
# Extension #121 - skipped
# Extension #122 - skipped
# Extension #123 - skipped
# Extension #124 - skipped
# Extension #125 - skipped
# Extension #126 - skipped
# Extension #127 - skipped
# Extension #128 - skipped
#
###############################################################################

###############################################################################
#
# Extension #129
# EXT_bgra commands
#
###############################################################################

# (none)
newcategory: EXT_bgra

###############################################################################
#
# Extension #130 - skipped
# Extension #131 - skipped
#
###############################################################################

###############################################################################
#
# Extension #132
# SGIX_async commands
#
###############################################################################

AsyncMarkerSGIX(marker)
	return		void
	param		marker		UInt32 in value
	category	SGIX_async
	version		1.0
	glxflags	ignore
	extension
	glsopcode	0x0198
	offset		?

FinishAsyncSGIX(markerp)
	return		Int32
	param		markerp		UInt32 out array [1]
	category	SGIX_async
	version		1.0
	dlflags		notlistable
	glxflags	ignore
	extension
	glsopcode	0x0199
	offset		?

PollAsyncSGIX(markerp)
	return		Int32
	param		markerp		UInt32 out array [1]
	category	SGIX_async
	version		1.0
	dlflags		notlistable
	glxflags	ignore
	extension
	glsopcode	0x019A
	offset		?

GenAsyncMarkersSGIX(range)
	return		UInt32
	param		range		SizeI in value
	category	SGIX_async
	version		1.0
	dlflags		notlistable
	glxflags	ignore
	extension
	glsopcode	0x019B
	offset		?

DeleteAsyncMarkersSGIX(marker, range)
	return		void
	param		marker		UInt32 in value
	param		range		SizeI in value
	category	SGIX_async
	version		1.0
	dlflags		notlistable
	glxflags	ignore
	extension
	glsopcode	0x019C
	offset		?

IsAsyncMarkerSGIX(marker)
	return		Boolean
	param		marker		UInt32 in value
	category	SGIX_async
	version		1.0
	dlflags		notlistable
	glxflags	ignore
	extension
	glsopcode	0x019D
	offset		?

###############################################################################
#
# Extension #133
# SGIX_async_pixel commands
#
###############################################################################

# (none)
newcategory: SGIX_async_pixel

###############################################################################
#
# Extension #134
# SGIX_async_histogram commands
#
###############################################################################

# (none)
newcategory: SGIX_async_histogram

###############################################################################
#
# Extension #135 - skipped (INTEL_texture_scissor was never implemented)
#
###############################################################################

###############################################################################
#
# Extension #136
# INTEL_parallel_arrays commands
#
###############################################################################

VertexPointervINTEL(size, type, pointer)
	return		void
	param		size		Int32 in value
	param		type		VertexPointerType in value
	param		pointer		VoidPointer in array [4] retained
	category	INTEL_parallel_arrays
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.1
	glsflags	ignore client
	offset		?

NormalPointervINTEL(type, pointer)
	return		void
	param		type		NormalPointerType in value
	param		pointer		VoidPointer in array [4] retained
	category	INTEL_parallel_arrays
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.1
	glsflags	ignore client
	offset		?

ColorPointervINTEL(size, type, pointer)
	return		void
	param		size		Int32 in value
	param		type		VertexPointerType in value
	param		pointer		VoidPointer in array [4] retained
	category	INTEL_parallel_arrays
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.1
	glsflags	ignore client
	offset		?

TexCoordPointervINTEL(size, type, pointer)
	return		void
	param		size		Int32 in value
	param		type		VertexPointerType in value
	param		pointer		VoidPointer in array [4] retained
	category	INTEL_parallel_arrays
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.1
	glsflags	ignore client
	offset		?


###############################################################################
#
# Extension #137
# HP_occlusion_test commands
#
###############################################################################

# (none)
newcategory: HP_occlusion_test

###############################################################################
#
# Extension #138
# EXT_pixel_transform commands
#
###############################################################################

PixelTransformParameteriEXT(target, pname, param)
	return		void
	param		target		PixelTransformTargetEXT in value
	param		pname		PixelTransformPNameEXT in value
	param		param		Int32 in value
	category	EXT_pixel_transform
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

PixelTransformParameterfEXT(target, pname, param)
	return		void
	param		target		PixelTransformTargetEXT in value
	param		pname		PixelTransformPNameEXT in value
	param		param		Float32 in value
	category	EXT_pixel_transform
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

PixelTransformParameterivEXT(target, pname, params)
	return		void
	param		target		PixelTransformTargetEXT in value
	param		pname		PixelTransformPNameEXT in value
	param		params		Int32 in array [1]
	category	EXT_pixel_transform
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

PixelTransformParameterfvEXT(target, pname, params)
	return		void
	param		target		PixelTransformTargetEXT in value
	param		pname		PixelTransformPNameEXT in value
	param		params		Float32 in array [1]
	category	EXT_pixel_transform
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #139
# EXT_pixel_transform_color_table commands
#
###############################################################################

# (none)
newcategory: EXT_pixel_transform_color_table

###############################################################################
#
# Extension #140 - skipped
#
###############################################################################

###############################################################################
#
# Extension #141
# EXT_shared_texture_palette commands
#
###############################################################################

# (none)
newcategory: EXT_shared_texture_palette

###############################################################################
#
# Extension #142 - GLX_SGIS_blended_overlay
# Extension #143 - GLX_SGIS_shared_multisample
#
###############################################################################

###############################################################################
#
# Extension #144
# EXT_separate_specular_color commands
#
###############################################################################

# (none)
newcategory: EXT_separate_specular_color

###############################################################################
#
# Extension #145
# EXT_secondary_color commands
#
###############################################################################

SecondaryColor3bEXT(red, green, blue)
	return		void
	param		red		ColorB in value
	param		green		ColorB in value
	param		blue		ColorB in value
	category	EXT_secondary_color
	vectorequiv	SecondaryColor3bvEXT
	version		1.1
	alias		SecondaryColor3b
	glsalias	SecondaryColor3b

SecondaryColor3bvEXT(v)
	return		void
	param		v		ColorB in array [3]
	category	EXT_secondary_color
	version		1.1
	glxropcode	4126
	alias		SecondaryColor3bv
	glsalias	SecondaryColor3bv

SecondaryColor3dEXT(red, green, blue)
	return		void
	param		red		ColorD in value
	param		green		ColorD in value
	param		blue		ColorD in value
	category	EXT_secondary_color
	vectorequiv	SecondaryColor3dvEXT
	version		1.1
	alias		SecondaryColor3d
	glsalias	SecondaryColor3d

SecondaryColor3dvEXT(v)
	return		void
	param		v		ColorD in array [3]
	category	EXT_secondary_color
	version		1.1
	glxropcode	4130
	alias		SecondaryColor3dv
	glsalias	SecondaryColor3dv

SecondaryColor3fEXT(red, green, blue)
	return		void
	param		red		ColorF in value
	param		green		ColorF in value
	param		blue		ColorF in value
	category	EXT_secondary_color
	vectorequiv	SecondaryColor3fvEXT
	version		1.1
	alias		SecondaryColor3f
	glsalias	SecondaryColor3f

SecondaryColor3fvEXT(v)
	return		void
	param		v		ColorF in array [3]
	category	EXT_secondary_color
	version		1.1
	glxropcode	4129
	alias		SecondaryColor3fv
	glsalias	SecondaryColor3fv

SecondaryColor3iEXT(red, green, blue)
	return		void
	param		red		ColorI in value
	param		green		ColorI in value
	param		blue		ColorI in value
	category	EXT_secondary_color
	vectorequiv	SecondaryColor3ivEXT
	version		1.1
	alias		SecondaryColor3i
	glsalias	SecondaryColor3i

SecondaryColor3ivEXT(v)
	return		void
	param		v		ColorI in array [3]
	category	EXT_secondary_color
	version		1.1
	glxropcode	4128
	glsopcode	0x0200
	offset		568
	alias		SecondaryColor3iv
	glsalias	SecondaryColor3iv

SecondaryColor3sEXT(red, green, blue)
	return		void
	param		red		ColorS in value
	param		green		ColorS in value
	param		blue		ColorS in value
	category	EXT_secondary_color
	vectorequiv	SecondaryColor3svEXT
	version		1.1
	alias		SecondaryColor3s
	glsalias	SecondaryColor3s

SecondaryColor3svEXT(v)
	return		void
	param		v		ColorS in array [3]
	category	EXT_secondary_color
	version		1.1
	glxropcode	4127
	alias		SecondaryColor3sv
	glsalias	SecondaryColor3sv

SecondaryColor3ubEXT(red, green, blue)
	return		void
	param		red		ColorUB in value
	param		green		ColorUB in value
	param		blue		ColorUB in value
	category	EXT_secondary_color
	vectorequiv	SecondaryColor3ubvEXT
	version		1.1
	alias		SecondaryColor3ub
	glsalias	SecondaryColor3ub

SecondaryColor3ubvEXT(v)
	return		void
	param		v		ColorUB in array [3]
	category	EXT_secondary_color
	version		1.1
	glxropcode	4131
	alias		SecondaryColor3ubv
	glsalias	SecondaryColor3ubv

SecondaryColor3uiEXT(red, green, blue)
	return		void
	param		red		ColorUI in value
	param		green		ColorUI in value
	param		blue		ColorUI in value
	category	EXT_secondary_color
	vectorequiv	SecondaryColor3uivEXT
	version		1.1
	alias		SecondaryColor3ui
	glsalias	SecondaryColor3ui

SecondaryColor3uivEXT(v)
	return		void
	param		v		ColorUI in array [3]
	category	EXT_secondary_color
	version		1.1
	glxropcode	4133
	alias		SecondaryColor3uiv
	glsalias	SecondaryColor3uiv

SecondaryColor3usEXT(red, green, blue)
	return		void
	param		red		ColorUS in value
	param		green		ColorUS in value
	param		blue		ColorUS in value
	category	EXT_secondary_color
	vectorequiv	SecondaryColor3usvEXT
	version		1.1
	alias		SecondaryColor3us
	glsalias	SecondaryColor3us

SecondaryColor3usvEXT(v)
	return		void
	param		v		ColorUS in array [3]
	category	EXT_secondary_color
	version		1.1
	glxropcode	4132
	alias		SecondaryColor3usv
	glsalias	SecondaryColor3usv

SecondaryColorPointerEXT(size, type, stride, pointer)
	return		void
	param		size		Int32 in value
	param		type		ColorPointerType in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(size/type/stride)] retained
	category	EXT_secondary_color
	dlflags		notlistable
	glxflags	client-handcode server-handcode EXT
	version		1.1
	extension
	alias		SecondaryColorPointer
	glsalias	SecondaryColorPointer

###############################################################################
#
# Extension #146
# EXT_texture_env commands
#
###############################################################################

# Dead extension - never implemented (removed from registry!)
# (none)
# newcategory: EXT_texture_env

###############################################################################
#
# Extension #147
# EXT_texture_perturb_normal commands
#
###############################################################################

TextureNormalEXT(mode)
	return		void
	param		mode		TextureNormalModeEXT in value
	category	EXT_texture_perturb_normal
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #148
# EXT_multi_draw_arrays commands
#
###############################################################################

# first and count are really 'in'
MultiDrawArraysEXT(mode, first, count, primcount)
	return		void
	param		mode		BeginMode in value
	param		first		Int32 out array [COMPSIZE(primcount)]
	param		count		SizeI out array [COMPSIZE(primcount)]
	param		primcount	SizeI in value
	category	EXT_multi_draw_arrays
	version		1.1
	glxropcode	?
	alias		MultiDrawArrays
	glsalias	MultiDrawArrays

MultiDrawElementsEXT(mode, count, type, indices, primcount)
	return		void
	param		mode		BeginMode in value
	param		count		SizeI in array [COMPSIZE(primcount)]
	param		type		DrawElementsType in value
	param		indices		VoidPointer in array [COMPSIZE(primcount)]
	param		primcount	SizeI in value
	category	EXT_multi_draw_arrays
	version		1.1
	glxropcode	?
	alias		MultiDrawElements
	glsalias	MultiDrawElements

###############################################################################
#
# Extension #149
# EXT_fog_coord commands
#
###############################################################################

FogCoordfEXT(coord)
	return		void
	param		coord		CoordF in value
	category	EXT_fog_coord
	vectorequiv	FogCoordfvEXT
	version		1.1
	alias		FogCoordf
	glsalias	FogCoordf

FogCoordfvEXT(coord)
	return		void
	param		coord		CoordF in array [1]
	category	EXT_fog_coord
	version		1.1
	glxropcode	4124
	alias		FogCoordfv
	glsalias	FogCoordfv

FogCoorddEXT(coord)
	return		void
	param		coord		CoordD in value
	category	EXT_fog_coord
	vectorequiv	FogCoorddvEXT
	version		1.1
	alias		FogCoordd
	glsalias	FogCoordd

FogCoorddvEXT(coord)
	return		void
	param		coord		CoordD in array [1]
	category	EXT_fog_coord
	version		1.1
	glxropcode	4125
	alias		FogCoorddv
	glsalias	FogCoorddv

FogCoordPointerEXT(type, stride, pointer)
	return		void
	param		type		FogPointerTypeEXT in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride)] retained
	category	EXT_fog_coord
	dlflags		notlistable
	version		1.1
	glxflags	client-handcode server-handcode EXT
	alias		FogCoordPointer
	glsalias	FogCoordPointer

###############################################################################
#
# Extension #150 - skipped
# Extension #151 - skipped
# Extension #152 - skipped
# Extension #153 - skipped
# Extension #154 - skipped
#
###############################################################################

###############################################################################
#
# Extension #155
# REND_screen_coordinates commands
#
###############################################################################

# (none)
newcategory: REND_screen_coordinates

###############################################################################
#
# Extension #156
# EXT_coordinate_frame commands
#
###############################################################################

Tangent3bEXT(tx, ty, tz)
	return		void
	param		tx		Int8 in value
	param		ty		Int8 in value
	param		tz		Int8 in value
	category	EXT_coordinate_frame
	vectorequiv	Tangent3bvEXT
	version		1.1
	glsflags	ignore
	offset		?

Tangent3bvEXT(v)
	return		void
	param		v		Int8 in array [3]
	category	EXT_coordinate_frame
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Tangent3dEXT(tx, ty, tz)
	return		void
	param		tx		CoordD in value
	param		ty		CoordD in value
	param		tz		CoordD in value
	category	EXT_coordinate_frame
	vectorequiv	Tangent3dvEXT
	version		1.1
	glsflags	ignore
	offset		?

Tangent3dvEXT(v)
	return		void
	param		v		CoordD in array [3]
	category	EXT_coordinate_frame
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Tangent3fEXT(tx, ty, tz)
	return		void
	param		tx		CoordF in value
	param		ty		CoordF in value
	param		tz		CoordF in value
	category	EXT_coordinate_frame
	vectorequiv	Tangent3fvEXT
	version		1.1
	glsflags	ignore
	offset		?

Tangent3fvEXT(v)
	return		void
	param		v		CoordF in array [3]
	category	EXT_coordinate_frame
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Tangent3iEXT(tx, ty, tz)
	return		void
	param		tx		Int32 in value
	param		ty		Int32 in value
	param		tz		Int32 in value
	category	EXT_coordinate_frame
	vectorequiv	Tangent3ivEXT
	version		1.1
	glsflags	ignore
	offset		?

Tangent3ivEXT(v)
	return		void
	param		v		Int32 in array [3]
	category	EXT_coordinate_frame
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Tangent3sEXT(tx, ty, tz)
	return		void
	param		tx		Int16 in value
	param		ty		Int16 in value
	param		tz		Int16 in value
	category	EXT_coordinate_frame
	vectorequiv	Tangent3svEXT
	version		1.1
	glsflags	ignore
	offset		?

Tangent3svEXT(v)
	return		void
	param		v		Int16 in array [3]
	category	EXT_coordinate_frame
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Binormal3bEXT(bx, by, bz)
	return		void
	param		bx		Int8 in value
	param		by		Int8 in value
	param		bz		Int8 in value
	category	EXT_coordinate_frame
	vectorequiv	Binormal3bvEXT
	version		1.1
	glsflags	ignore
	offset		?

Binormal3bvEXT(v)
	return		void
	param		v		Int8 in array [3]
	category	EXT_coordinate_frame
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Binormal3dEXT(bx, by, bz)
	return		void
	param		bx		CoordD in value
	param		by		CoordD in value
	param		bz		CoordD in value
	category	EXT_coordinate_frame
	vectorequiv	Binormal3dvEXT
	version		1.1
	glsflags	ignore
	offset		?

Binormal3dvEXT(v)
	return		void
	param		v		CoordD in array [3]
	category	EXT_coordinate_frame
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Binormal3fEXT(bx, by, bz)
	return		void
	param		bx		CoordF in value
	param		by		CoordF in value
	param		bz		CoordF in value
	category	EXT_coordinate_frame
	vectorequiv	Binormal3fvEXT
	version		1.1
	glsflags	ignore
	offset		?

Binormal3fvEXT(v)
	return		void
	param		v		CoordF in array [3]
	category	EXT_coordinate_frame
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Binormal3iEXT(bx, by, bz)
	return		void
	param		bx		Int32 in value
	param		by		Int32 in value
	param		bz		Int32 in value
	category	EXT_coordinate_frame
	vectorequiv	Binormal3ivEXT
	version		1.1
	glsflags	ignore
	offset		?

Binormal3ivEXT(v)
	return		void
	param		v		Int32 in array [3]
	category	EXT_coordinate_frame
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Binormal3sEXT(bx, by, bz)
	return		void
	param		bx		Int16 in value
	param		by		Int16 in value
	param		bz		Int16 in value
	category	EXT_coordinate_frame
	vectorequiv	Binormal3svEXT
	version		1.1
	glsflags	ignore
	offset		?

Binormal3svEXT(v)
	return		void
	param		v		Int16 in array [3]
	category	EXT_coordinate_frame
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TangentPointerEXT(type, stride, pointer)
	return		void
	param		type		TangentPointerTypeEXT in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride)] retained
	category	EXT_coordinate_frame
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	ignore
	offset		?

BinormalPointerEXT(type, stride, pointer)
	return		void
	param		type		BinormalPointerTypeEXT in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride)] retained
	category	EXT_coordinate_frame
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #157 - skipped
#
###############################################################################

###############################################################################
#
# Extension #158
# EXT_texture_env_combine commands
#
###############################################################################

# (none)
newcategory: EXT_texture_env_combine

###############################################################################
#
# Extension #159
# APPLE_specular_vector commands
#
###############################################################################

# (none)
newcategory: APPLE_specular_vector

###############################################################################
#
# Extension #160
# APPLE_transform_hint commands
#
###############################################################################

# (none)
newcategory: APPLE_transform_hint

###############################################################################
#
# Extension #161
# SGIX_fog_scale commands
#
###############################################################################

# (none)
newcategory: SGIX_fog_scale

###############################################################################
#
# Extension #162 - skipped
#
###############################################################################

###############################################################################
#
# Extension #163
# SUNX_constant_data commands
#
###############################################################################

FinishTextureSUNX()
	return		void
	category	SUNX_constant_data
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #164
# SUN_global_alpha commands
#
###############################################################################

GlobalAlphaFactorbSUN(factor)
	return		void
	param		factor		Int8 in value
	category	SUN_global_alpha
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

GlobalAlphaFactorsSUN(factor)
	return		void
	param		factor		Int16 in value
	category	SUN_global_alpha
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

GlobalAlphaFactoriSUN(factor)
	return		void
	param		factor		Int32 in value
	category	SUN_global_alpha
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

GlobalAlphaFactorfSUN(factor)
	return		void
	param		factor		Float32 in value
	category	SUN_global_alpha
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

GlobalAlphaFactordSUN(factor)
	return		void
	param		factor		Float64 in value
	category	SUN_global_alpha
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

GlobalAlphaFactorubSUN(factor)
	return		void
	param		factor		UInt8 in value
	category	SUN_global_alpha
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

GlobalAlphaFactorusSUN(factor)
	return		void
	param		factor		UInt16 in value
	category	SUN_global_alpha
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

GlobalAlphaFactoruiSUN(factor)
	return		void
	param		factor		UInt32 in value
	category	SUN_global_alpha
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #165
# SUN_triangle_list commands
#
###############################################################################

ReplacementCodeuiSUN(code)
	return		void
	param		code		UInt32 in value
	category	SUN_triangle_list
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeusSUN(code)
	return		void
	param		code		UInt16 in value
	category	SUN_triangle_list
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeubSUN(code)
	return		void
	param		code		UInt8 in value
	category	SUN_triangle_list
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuivSUN(code)
	return		void
	param		code		UInt32 in array [COMPSIZE()]
	category	SUN_triangle_list
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeusvSUN(code)
	return		void
	param		code		UInt16 in array [COMPSIZE()]
	category	SUN_triangle_list
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeubvSUN(code)
	return		void
	param		code		UInt8 in array [COMPSIZE()]
	category	SUN_triangle_list
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodePointerSUN(type, stride, pointer)
	return		void
	param		type		ReplacementCodeTypeSUN in value
	param		stride		SizeI in value
	param		pointer		VoidPointer in array [COMPSIZE(type/stride)] retained
	category	SUN_triangle_list
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #166
# SUN_vertex commands
#
###############################################################################

Color4ubVertex2fSUN(r, g, b, a, x, y)
	return		void
	param		r		UInt8 in value
	param		g		UInt8 in value
	param		b		UInt8 in value
	param		a		UInt8 in value
	param		x		Float32 in value
	param		y		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Color4ubVertex2fvSUN(c, v)
	return		void
	param		c		UInt8 in array [4]
	param		v		Float32 in array [2]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Color4ubVertex3fSUN(r, g, b, a, x, y, z)
	return		void
	param		r		UInt8 in value
	param		g		UInt8 in value
	param		b		UInt8 in value
	param		a		UInt8 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Color4ubVertex3fvSUN(c, v)
	return		void
	param		c		UInt8 in array [4]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Color3fVertex3fSUN(r, g, b, x, y, z)
	return		void
	param		r		Float32 in value
	param		g		Float32 in value
	param		b		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Color3fVertex3fvSUN(c, v)
	return		void
	param		c		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Normal3fVertex3fSUN(nx, ny, nz, x, y, z)
	return		void
	param		nx		Float32 in value
	param		ny		Float32 in value
	param		nz		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Normal3fVertex3fvSUN(n, v)
	return		void
	param		n		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Color4fNormal3fVertex3fSUN(r, g, b, a, nx, ny, nz, x, y, z)
	return		void
	param		r		Float32 in value
	param		g		Float32 in value
	param		b		Float32 in value
	param		a		Float32 in value
	param		nx		Float32 in value
	param		ny		Float32 in value
	param		nz		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

Color4fNormal3fVertex3fvSUN(c, n, v)
	return		void
	param		c		Float32 in array [4]
	param		n		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord2fVertex3fSUN(s, t, x, y, z)
	return		void
	param		s		Float32 in value
	param		t		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord2fVertex3fvSUN(tc, v)
	return		void
	param		tc		Float32 in array [2]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord4fVertex4fSUN(s, t, p, q, x, y, z, w)
	return		void
	param		s		Float32 in value
	param		t		Float32 in value
	param		p		Float32 in value
	param		q		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	param		w		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord4fVertex4fvSUN(tc, v)
	return		void
	param		tc		Float32 in array [4]
	param		v		Float32 in array [4]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord2fColor4ubVertex3fSUN(s, t, r, g, b, a, x, y, z)
	return		void
	param		s		Float32 in value
	param		t		Float32 in value
	param		r		UInt8 in value
	param		g		UInt8 in value
	param		b		UInt8 in value
	param		a		UInt8 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord2fColor4ubVertex3fvSUN(tc, c, v)
	return		void
	param		tc		Float32 in array [2]
	param		c		UInt8 in array [4]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord2fColor3fVertex3fSUN(s, t, r, g, b, x, y, z)
	return		void
	param		s		Float32 in value
	param		t		Float32 in value
	param		r		Float32 in value
	param		g		Float32 in value
	param		b		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord2fColor3fVertex3fvSUN(tc, c, v)
	return		void
	param		tc		Float32 in array [2]
	param		c		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord2fNormal3fVertex3fSUN(s, t, nx, ny, nz, x, y, z)
	return		void
	param		s		Float32 in value
	param		t		Float32 in value
	param		nx		Float32 in value
	param		ny		Float32 in value
	param		nz		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord2fNormal3fVertex3fvSUN(tc, n, v)
	return		void
	param		tc		Float32 in array [2]
	param		n		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord2fColor4fNormal3fVertex3fSUN(s, t, r, g, b, a, nx, ny, nz, x, y, z)
	return		void
	param		s		Float32 in value
	param		t		Float32 in value
	param		r		Float32 in value
	param		g		Float32 in value
	param		b		Float32 in value
	param		a		Float32 in value
	param		nx		Float32 in value
	param		ny		Float32 in value
	param		nz		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n, v)
	return		void
	param		tc		Float32 in array [2]
	param		c		Float32 in array [4]
	param		n		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord4fColor4fNormal3fVertex4fSUN(s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w)
	return		void
	param		s		Float32 in value
	param		t		Float32 in value
	param		p		Float32 in value
	param		q		Float32 in value
	param		r		Float32 in value
	param		g		Float32 in value
	param		b		Float32 in value
	param		a		Float32 in value
	param		nx		Float32 in value
	param		ny		Float32 in value
	param		nz		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	param		w		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n, v)
	return		void
	param		tc		Float32 in array [4]
	param		c		Float32 in array [4]
	param		n		Float32 in array [3]
	param		v		Float32 in array [4]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiVertex3fSUN(rc, x, y, z)
	return		void
	param		rc		ReplacementCodeSUN in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiVertex3fvSUN(rc, v)
	return		void
	param		rc		ReplacementCodeSUN in array [1]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiColor4ubVertex3fSUN(rc, r, g, b, a, x, y, z)
	return		void
	param		rc		ReplacementCodeSUN in value
	param		r		UInt8 in value
	param		g		UInt8 in value
	param		b		UInt8 in value
	param		a		UInt8 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiColor4ubVertex3fvSUN(rc, c, v)
	return		void
	param		rc		ReplacementCodeSUN in array [1]
	param		c		UInt8 in array [4]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiColor3fVertex3fSUN(rc, r, g, b, x, y, z)
	return		void
	param		rc		ReplacementCodeSUN in value
	param		r		Float32 in value
	param		g		Float32 in value
	param		b		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiColor3fVertex3fvSUN(rc, c, v)
	return		void
	param		rc		ReplacementCodeSUN in array [1]
	param		c		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiNormal3fVertex3fSUN(rc, nx, ny, nz, x, y, z)
	return		void
	param		rc		ReplacementCodeSUN in value
	param		nx		Float32 in value
	param		ny		Float32 in value
	param		nz		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiNormal3fVertex3fvSUN(rc, n, v)
	return		void
	param		rc		ReplacementCodeSUN in array [1]
	param		n		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiColor4fNormal3fVertex3fSUN(rc, r, g, b, a, nx, ny, nz, x, y, z)
	return		void
	param		rc		ReplacementCodeSUN in value
	param		r		Float32 in value
	param		g		Float32 in value
	param		b		Float32 in value
	param		a		Float32 in value
	param		nx		Float32 in value
	param		ny		Float32 in value
	param		nz		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n, v)
	return		void
	param		rc		ReplacementCodeSUN in array [1]
	param		c		Float32 in array [4]
	param		n		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiTexCoord2fVertex3fSUN(rc, s, t, x, y, z)
	return		void
	param		rc		ReplacementCodeSUN in value
	param		s		Float32 in value
	param		t		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc, v)
	return		void
	param		rc		ReplacementCodeSUN in array [1]
	param		tc		Float32 in array [2]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(rc, s, t, nx, ny, nz, x, y, z)
	return		void
	param		rc		ReplacementCodeSUN in value
	param		s		Float32 in value
	param		t		Float32 in value
	param		nx		Float32 in value
	param		ny		Float32 in value
	param		nz		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n, v)
	return		void
	param		rc		ReplacementCodeSUN in array [1]
	param		tc		Float32 in array [2]
	param		n		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(rc, s, t, r, g, b, a, nx, ny, nz, x, y, z)
	return		void
	param		rc		ReplacementCodeSUN in value
	param		s		Float32 in value
	param		t		Float32 in value
	param		r		Float32 in value
	param		g		Float32 in value
	param		b		Float32 in value
	param		a		Float32 in value
	param		nx		Float32 in value
	param		ny		Float32 in value
	param		nz		Float32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n, v)
	return		void
	param		rc		ReplacementCodeSUN in array [1]
	param		tc		Float32 in array [2]
	param		c		Float32 in array [4]
	param		n		Float32 in array [3]
	param		v		Float32 in array [3]
	category	SUN_vertex
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #167 - WGL_EXT_display_color_table
# Extension #168 - WGL_EXT_extensions_string
# Extension #169 - WGL_EXT_make_current_read
# Extension #170 - WGL_EXT_pixel_format
# Extension #171 - WGL_EXT_pbuffer
# Extension #172 - WGL_EXT_swap_control
#
###############################################################################

###############################################################################
#
# Extension #173
# EXT_blend_func_separate commands (also INGR_blend_func_separate)
#
###############################################################################

BlendFuncSeparateEXT(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha)
	return		void
	param		sfactorRGB	BlendFuncSeparateParameterEXT in value
	param		dfactorRGB	BlendFuncSeparateParameterEXT in value
	param		sfactorAlpha	BlendFuncSeparateParameterEXT in value
	param		dfactorAlpha	BlendFuncSeparateParameterEXT in value
	category	EXT_blend_func_separate
	glxropcode	4134
	version		1.0
	extension
	alias		BlendFuncSeparate
	glsalias	BlendFuncSeparate

BlendFuncSeparateINGR(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha)
	return		void
	param		sfactorRGB	BlendFuncSeparateParameterEXT in value
	param		dfactorRGB	BlendFuncSeparateParameterEXT in value
	param		sfactorAlpha	BlendFuncSeparateParameterEXT in value
	param		dfactorAlpha	BlendFuncSeparateParameterEXT in value
	category	INGR_blend_func_separate
	glxropcode	4134
	version		1.0
	extension
	alias		BlendFuncSeparateEXT
	glsalias	BlendFuncSeparateEXT

###############################################################################
#
# Extension #174
# INGR_color_clamp commands
#
###############################################################################

# (none)
newcategory: INGR_color_clamp

###############################################################################
#
# Extension #175
# INGR_interlace_read commands
#
###############################################################################

# (none)
newcategory: INGR_interlace_read

###############################################################################
#
# Extension #176
# EXT_stencil_wrap commands
#
###############################################################################

# (none)
newcategory: EXT_stencil_wrap

###############################################################################
#
# Extension #177 - skipped
#
###############################################################################

###############################################################################
#
# Extension #178
# EXT_422_pixels commands
#
###############################################################################

# (none)
newcategory: EXT_422_pixels

###############################################################################
#
# Extension #179
# NV_texgen_reflection commands
#
###############################################################################

# (none)
newcategory: NV_texgen_reflection

###############################################################################
#
# Extension #???
# @   EXT_texture_cube_map commands
#
###############################################################################

# (none)

###############################################################################
#
# Extension #180 - skipped
# Extension #181 - skipped
#
###############################################################################

###############################################################################
#
# Extension #182
# SUN_convolution_border_modes commands
#
###############################################################################

# (none)
newcategory: SUN_convolution_border_modes

###############################################################################
#
# Extension #183 - GLX_SUN_get_transparent_index
# Extension #184 - skipped
#
###############################################################################

###############################################################################
#
# Extension #185
# EXT_texture_env_add commands
#
###############################################################################

# (none)
newcategory: EXT_texture_env_add

###############################################################################
#
# Extension #186
# EXT_texture_lod_bias commands
#
###############################################################################

# (none)
newcategory: EXT_texture_lod_bias

###############################################################################
#
# Extension #187
# EXT_texture_filter_anisotropic commands
#
###############################################################################

# (none)
newcategory: EXT_texture_filter_anisotropic

###############################################################################
#
# Extension #188
# EXT_vertex_weighting commands
#
###############################################################################

# GLX stuff to be written
VertexWeightfEXT(weight)
	return		void
	param		weight		Float32 in value
	category	EXT_vertex_weighting
	vectorequiv	VertexWeightfvEXT
	version		1.1
	extension	soft WINSOFT NV10
	glxflags	ignore
	offset		494

VertexWeightfvEXT(weight)
	return		void
	param		weight		Float32 in array [1]
	category	EXT_vertex_weighting
	version		1.1
	extension	soft WINSOFT NV10
	glxropcode	4135
	glxflags	ignore
	glsopcode	0x01DE
	offset		495

VertexWeightPointerEXT(size, type, stride, pointer)
	return		void
	param		size		SizeI in value
	param		type		VertexWeightPointerTypeEXT in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(type/stride)] retained
	category	EXT_vertex_weighting
	version		1.1
	extension	soft WINSOFT NV10
	dlflags		notlistable
	glxflags	ignore
	glsflags	client
	glsopcode	0x01DF
	offset		496

###############################################################################
#
# Extension #189
# NV_light_max_exponent commands
#
###############################################################################

# (none)
newcategory: NV_light_max_exponent

###############################################################################
#
# Extension #190
# NV_vertex_array_range commands
#
###############################################################################

FlushVertexArrayRangeNV()
	return		void
	category	NV_vertex_array_range
	version		1.1
	extension	soft WINSOFT NV10
	dlflags		notlistable
	glxflags	client-handcode server-handcode ignore
	glsflags	client
	glsopcode	0x01E0
	offset		497

VertexArrayRangeNV(length, pointer)
	return		void
	param		length		SizeI in value
	param		pointer		Void in array [COMPSIZE(length)] retained
	category	NV_vertex_array_range
	version		1.1
	extension	soft WINSOFT NV10
	dlflags		notlistable
	glxflags	client-handcode server-handcode ignore
	glsflags	client
	glsopcode	0x01E1
	offset		498

###############################################################################
#
# Extension #191
# NV_register_combiners commands
#
###############################################################################

CombinerParameterfvNV(pname, params)
	return		void
	param		pname		CombinerParameterNV in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxropcode	4137
	glxflags	ignore
	glsflags	gl-enum
	glsopcode	0x01E2
	offset		499

CombinerParameterfNV(pname, param)
	return		void
	param		pname		CombinerParameterNV in value
	param		param		Float32 in value
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxropcode	4136
	glxflags	ignore
	glsflags	gl-enum
	glsopcode	0x01E3
	offset		500

CombinerParameterivNV(pname, params)
	return		void
	param		pname		CombinerParameterNV in value
	param		params		CheckedInt32 in array [COMPSIZE(pname)]
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxropcode	4139
	glxflags	ignore
	glsflags	gl-enum
	glsopcode	0x01E4
	offset		501

CombinerParameteriNV(pname, param)
	return		void
	param		pname		CombinerParameterNV in value
	param		param		Int32 in value
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxropcode	4138
	glxflags	ignore
	glsflags	gl-enum
	glsopcode	0x01E5
	offset		502

CombinerInputNV(stage, portion, variable, input, mapping, componentUsage)
	return		void
	param		stage		CombinerStageNV in value
	param		portion		CombinerPortionNV in value
	param		variable	CombinerVariableNV in value
	param		input		CombinerRegisterNV in value
	param		mapping		CombinerMappingNV in value
	param		componentUsage	CombinerComponentUsageNV in value
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxropcode	4140
	glxflags	ignore
	glsopcode	0x01E6
	offset		503

CombinerOutputNV(stage, portion, abOutput, cdOutput, sumOutput, scale, bias, abDotProduct, cdDotProduct, muxSum)
	return		void
	param		stage		CombinerStageNV in value
	param		portion		CombinerPortionNV in value
	param		abOutput	CombinerRegisterNV in value
	param		cdOutput	CombinerRegisterNV in value
	param		sumOutput	CombinerRegisterNV in value
	param		scale		CombinerScaleNV in value
	param		bias		CombinerBiasNV in value
	param		abDotProduct	Boolean in value
	param		cdDotProduct	Boolean in value
	param		muxSum		Boolean in value
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxropcode	4141
	glxflags	ignore
	glsopcode	0x01E7
	offset		504

FinalCombinerInputNV(variable, input, mapping, componentUsage)
	return		void
	param		variable	CombinerVariableNV in value
	param		input		CombinerRegisterNV in value
	param		mapping		CombinerMappingNV in value
	param		componentUsage	CombinerComponentUsageNV in value
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxropcode	4142
	glxflags	ignore
	glsopcode	0x01E8
	offset		505

GetCombinerInputParameterfvNV(stage, portion, variable, pname, params)
	return		void
	param		stage		CombinerStageNV in value
	param		portion		CombinerPortionNV in value
	param		variable	CombinerVariableNV in value
	param		pname		CombinerParameterNV in value
	param		params		Float32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxvendorpriv	1270
	glxflags	ignore
	glsflags	get
	glsopcode	0x01E9
	offset		506

GetCombinerInputParameterivNV(stage, portion, variable, pname, params)
	return		void
	param		stage		CombinerStageNV in value
	param		portion		CombinerPortionNV in value
	param		variable	CombinerVariableNV in value
	param		pname		CombinerParameterNV in value
	param		params		Int32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxvendorpriv	1271
	glxflags	ignore
	glsflags	get
	glsopcode	0x01EA
	offset		507

GetCombinerOutputParameterfvNV(stage, portion, pname, params)
	return		void
	param		stage		CombinerStageNV in value
	param		portion		CombinerPortionNV in value
	param		pname		CombinerParameterNV in value
	param		params		Float32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxvendorpriv	1272
	glxflags	ignore
	glsflags	get
	glsopcode	0x01EB
	offset		508

GetCombinerOutputParameterivNV(stage, portion, pname, params)
	return		void
	param		stage		CombinerStageNV in value
	param		portion		CombinerPortionNV in value
	param		pname		CombinerParameterNV in value
	param		params		Int32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxvendorpriv	1273
	glxflags	ignore
	glsflags	get
	glsopcode	0x01EC
	offset		509

GetFinalCombinerInputParameterfvNV(variable, pname, params)
	return		void
	param		variable	CombinerVariableNV in value
	param		pname		CombinerParameterNV in value
	param		params		Float32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxvendorpriv	1274
	glxflags	ignore
	glsflags	get
	glsopcode	0x01ED
	offset		510

GetFinalCombinerInputParameterivNV(variable, pname, params)
	return		void
	param		variable	CombinerVariableNV in value
	param		pname		CombinerParameterNV in value
	param		params		Int32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	NV_register_combiners
	version		1.1
	extension	soft WINSOFT NV10
	glxvendorpriv	1275
	glxflags	ignore
	glsflags	get
	glsopcode	0x01EE
	offset		511

###############################################################################
#
# Extension #192
# NV_fog_distance commands
#
###############################################################################

# (none)
newcategory: NV_fog_distance

###############################################################################
#
# Extension #193
# NV_texgen_emboss commands
#
###############################################################################

# (none)
newcategory: NV_texgen_emboss

###############################################################################
#
# Extension #194
# NV_blend_square commands
#
###############################################################################

# (none)
newcategory: NV_blend_square

###############################################################################
#
# Extension #195
# NV_texture_env_combine4 commands
#
###############################################################################

# (none)
newcategory: NV_texture_env_combine4

###############################################################################
#
# Extension #196
# MESA_resize_buffers commands
#
###############################################################################

ResizeBuffersMESA()
	return		void
	category	MESA_resize_buffers
	version		1.0
	glxropcode	?
	glsopcode	0x01EF
	offset		512

###############################################################################
#
# Extension #197
# MESA_window_pos commands
#
# Note that the 2- and 3-component versions are now aliases of ARB
# entry points.
#
###############################################################################

WindowPos2dMESA(x, y)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	category	MESA_window_pos
	vectorequiv	WindowPos2dvMESA
	version		1.0
	alias		WindowPos2dARB

WindowPos2dvMESA(v)
	return		void
	param		v		CoordD in array [2]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01F0
	alias		WindowPos2dvARB

WindowPos2fMESA(x, y)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	category	MESA_window_pos
	vectorequiv	WindowPos2fvMESA
	version		1.0
	alias		WindowPos2fARB

WindowPos2fvMESA(v)
	return		void
	param		v		CoordF in array [2]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01F1
	alias		WindowPos2fvARB

WindowPos2iMESA(x, y)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	category	MESA_window_pos
	vectorequiv	WindowPos2ivMESA
	version		1.0
	alias		WindowPos2iARB

WindowPos2ivMESA(v)
	return		void
	param		v		CoordI in array [2]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01F2
	alias		WindowPos2ivARB

WindowPos2sMESA(x, y)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	category	MESA_window_pos
	vectorequiv	WindowPos2svMESA
	version		1.0
	alias		WindowPos2sARB

WindowPos2svMESA(v)
	return		void
	param		v		CoordS in array [2]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01F3
	alias		WindowPos2svARB

WindowPos3dMESA(x, y, z)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	param		z		CoordD in value
	vectorequiv	WindowPos3dvMESA
	category	MESA_window_pos
	version		1.0
	alias		WindowPos3dARB

WindowPos3dvMESA(v)
	return		void
	param		v		CoordD in array [3]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01F4
	alias		WindowPos3dvARB

WindowPos3fMESA(x, y, z)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	param		z		CoordF in value
	category	MESA_window_pos
	vectorequiv	WindowPos3fvMESA
	version		1.0
	alias		WindowPos3fARB

WindowPos3fvMESA(v)
	return		void
	param		v		CoordF in array [3]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01F5
	alias		WindowPos3fvARB

WindowPos3iMESA(x, y, z)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	param		z		CoordI in value
	category	MESA_window_pos
	vectorequiv	WindowPos3ivMESA
	version		1.0
	alias		WindowPos3iARB

WindowPos3ivMESA(v)
	return		void
	param		v		CoordI in array [3]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01F6
	alias		WindowPos3ivARB

WindowPos3sMESA(x, y, z)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	param		z		CoordS in value
	category	MESA_window_pos
	vectorequiv	WindowPos3svMESA
	version		1.0
	alias		WindowPos3sARB

WindowPos3svMESA(v)
	return		void
	param		v		CoordS in array [3]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01F7
	alias		WindowPos3svARB

WindowPos4dMESA(x, y, z, w)
	return		void
	param		x		CoordD in value
	param		y		CoordD in value
	param		z		CoordD in value
	param		w		CoordD in value
	vectorequiv	WindowPos4dvMESA
	category	MESA_window_pos
	version		1.0
	offset		529

WindowPos4dvMESA(v)
	return		void
	param		v		CoordD in array [4]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01F8
	offset		530

WindowPos4fMESA(x, y, z, w)
	return		void
	param		x		CoordF in value
	param		y		CoordF in value
	param		z		CoordF in value
	param		w		CoordF in value
	category	MESA_window_pos
	vectorequiv	WindowPos4fvMESA
	version		1.0
	offset		531

WindowPos4fvMESA(v)
	return		void
	param		v		CoordF in array [4]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01F9
	offset		532

WindowPos4iMESA(x, y, z, w)
	return		void
	param		x		CoordI in value
	param		y		CoordI in value
	param		z		CoordI in value
	param		w		CoordI in value
	category	MESA_window_pos
	vectorequiv	WindowPos4ivMESA
	version		1.0
	offset		533

WindowPos4ivMESA(v)
	return		void
	param		v		CoordI in array [4]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01FA
	offset		534

WindowPos4sMESA(x, y, z, w)
	return		void
	param		x		CoordS in value
	param		y		CoordS in value
	param		z		CoordS in value
	param		w		CoordS in value
	category	MESA_window_pos
	vectorequiv	WindowPos4svMESA
	version		1.0
	offset		535

WindowPos4svMESA(v)
	return		void
	param		v		CoordS in array [4]
	category	MESA_window_pos
	version		1.0
	glxropcode	?
	glsopcode	0x01FB
	offset		536

###############################################################################
#
# Extension #198
# EXT_texture_compression_s3tc commands
#
###############################################################################

#@@ (none yet)

###############################################################################
#
# Extension #199
# IBM_cull_vertex commands
#
###############################################################################

# (none)
newcategory: IBM_cull_vertex

###############################################################################
#
# Extension #200
# IBM_multimode_draw_arrays commands
#
###############################################################################

MultiModeDrawArraysIBM(mode, first, count, primcount, modestride)
	return		void
	param		mode		BeginMode in array [COMPSIZE(primcount)]
	param		first		Int32 in array [COMPSIZE(primcount)]
	param		count		SizeI in array [COMPSIZE(primcount)]
	param		primcount	SizeI in value
	param		modestride	Int32 in value
	category	IBM_multimode_draw_arrays
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		708


MultiModeDrawElementsIBM(mode, count, type, indices, primcount, modestride)
	return		void
	param		mode		BeginMode in array [COMPSIZE(primcount)]
	param		count		SizeI in array [COMPSIZE(primcount)]
	param		type		DrawElementsType in value
	param		indices		ConstVoidPointer in array [COMPSIZE(primcount)]
	param		primcount	SizeI in value
	param		modestride	Int32 in value
	category	IBM_multimode_draw_arrays
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		709

###############################################################################
#
# Extension #201
# IBM_vertex_array_lists commands
#
###############################################################################

ColorPointerListIBM(size, type, stride, pointer, ptrstride)
	return		void
	param		size		Int32 in value
	param		type		ColorPointerType in value
	param		stride		Int32 in value
	param		pointer		VoidPointer in array [COMPSIZE(size/type/stride)] retained
	param		ptrstride	Int32 in value
	category	IBM_vertex_array_lists
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

SecondaryColorPointerListIBM(size, type, stride, pointer, ptrstride)
	return		void
	param		size		Int32 in value
	param		type		SecondaryColorPointerTypeIBM in value
	param		stride		Int32 in value
	param		pointer		VoidPointer in array [COMPSIZE(size/type/stride)] retained
	param		ptrstride	Int32 in value
	category	IBM_vertex_array_lists
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

EdgeFlagPointerListIBM(stride, pointer, ptrstride)
	return		void
	param		stride		Int32 in value
	param		pointer		BooleanPointer in array [COMPSIZE(stride)] retained
	param		ptrstride	Int32 in value
	category	IBM_vertex_array_lists
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

FogCoordPointerListIBM(type, stride, pointer, ptrstride)
	return		void
	param		type		FogPointerTypeIBM in value
	param		stride		Int32 in value
	param		pointer		VoidPointer in array [COMPSIZE(type/stride)] retained
	param		ptrstride	Int32 in value
	category	IBM_vertex_array_lists
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

IndexPointerListIBM(type, stride, pointer, ptrstride)
	return		void
	param		type		IndexPointerType in value
	param		stride		Int32 in value
	param		pointer		VoidPointer in array [COMPSIZE(type/stride)] retained
	param		ptrstride	Int32 in value
	category	IBM_vertex_array_lists
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

NormalPointerListIBM(type, stride, pointer, ptrstride)
	return		void
	param		type		NormalPointerType in value
	param		stride		Int32 in value
	param		pointer		VoidPointer in array [COMPSIZE(type/stride)] retained
	param		ptrstride	Int32 in value
	category	IBM_vertex_array_lists
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

TexCoordPointerListIBM(size, type, stride, pointer, ptrstride)
	return		void
	param		size		Int32 in value
	param		type		TexCoordPointerType in value
	param		stride		Int32 in value
	param		pointer		VoidPointer in array [COMPSIZE(size/type/stride)] retained
	param		ptrstride	Int32 in value
	category	IBM_vertex_array_lists
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

VertexPointerListIBM(size, type, stride, pointer, ptrstride)
	return		void
	param		size		Int32 in value
	param		type		VertexPointerType in value
	param		stride		Int32 in value
	param		pointer		VoidPointer in array [COMPSIZE(size/type/stride)] retained
	param		ptrstride	Int32 in value
	category	IBM_vertex_array_lists
	version		1.1
	glxropcode	?
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #202
# SGIX_subsample commands
#
###############################################################################

# (none)
newcategory: SGIX_subsample

###############################################################################
#
# Extension #203
# SGIX_ycrcba commands
#
###############################################################################

# (none)
newcategory: SGIX_ycrcba

###############################################################################
#
# Extension #204
# SGIX_ycrcb_subsample commands
#
###############################################################################

# (none)
newcategory: SGIX_ycrcb_subsample

###############################################################################
#
# Extension #205
# SGIX_depth_pass_instrument commands
#
###############################################################################

# (none)
newcategory: SGIX_depth_pass_instrument

###############################################################################
#
# Extension #206
# 3DFX_texture_compression_FXT1 commands
#
###############################################################################

# (none)
newcategory: 3DFX_texture_compression_FXT1

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
# Extension #208
# 3DFX_tbuffer commands
#
###############################################################################

TbufferMask3DFX(mask)
	return		void
	param		mask		UInt32 in value
	category	3DFX_tbuffer
	version		1.2
	glxropcode	?
	glsflags	ignore
	glsopcode	0x01FC
	offset		553

###############################################################################
#
# Extension #209
# EXT_multisample commands
#
###############################################################################

SampleMaskEXT(value, invert)
	return		void
	param		value		ClampedFloat32 in value
	param		invert		Boolean in value
	category	EXT_multisample
	version		1.0
	glxropcode	?
	extension
	glsopcode	0x0160
	offset		446

SamplePatternEXT(pattern)
	return		void
	param		pattern		SamplePatternEXT in value
	category	EXT_multisample
	version		1.0
	glxropcode	?
	glxflags
	extension
	glsopcode	0x0161
	offset		447

###############################################################################
#
# Extension #210
# SGIX_vertex_preclip commands
#
###############################################################################

# (none)
newcategory: SGIX_vertex_preclip

###############################################################################
#
# Extension #211
# SGIX_convolution_accuracy commands
#
###############################################################################

# (none)
newcategory: SGIX_convolution_accuracy

###############################################################################
#
# Extension #212
# SGIX_resample commands
#
###############################################################################

# (none)
newcategory: SGIX_resample

###############################################################################
#
# Extension #213
# SGIS_point_line_texgen commands
#
###############################################################################

# (none)
newcategory: SGIS_point_line_texgen

###############################################################################
#
# Extension #214
# SGIS_texture_color_mask commands
#
###############################################################################

TextureColorMaskSGIS(red, green, blue, alpha)
	return		void
	param		red		Boolean in value
	param		green		Boolean in value
	param		blue		Boolean in value
	param		alpha		Boolean in value
	category	SGIS_texture_color_mask
	version		1.1
	glxropcode	2082
	extension
	glsopcode	0x01B0
	offset		?

###############################################################################
#
# Extension #215 - GLX_MESA_copy_sub_buffer
# Extension #216 - GLX_MESA_pixmap_colormap
# Extension #217 - GLX_MESA_release_buffers
# Extension #218 - GLX_MESA_set_3dfx_mode
#
###############################################################################

###############################################################################
#
# Extension #219
# SGIX_igloo_interface commands
#
###############################################################################

IglooInterfaceSGIX(pname, params)
	return		void
	dlflags		notlistable
	param		pname		IglooFunctionSelectSGIX in value
	param		params		IglooParameterSGIX in array [COMPSIZE(pname)]
	category	SGIX_igloo_interface
	version		1.0
	glxflags	SGI ignore
	extension
	glxropcode	200
	glsopcode	0x0183
	offset		?

###############################################################################
#
# Extension #220
# EXT_texture_env_dot3 commands
#
###############################################################################

# (none)
newcategory: EXT_texture_env_dot3

###############################################################################
#
# Extension #221
# ATI_texture_mirror_once commands
#
###############################################################################
# (none)
newcategory: ATI_texture_mirror_once

###############################################################################
#
# Extension #222
# NV_fence commands
#
###############################################################################

DeleteFencesNV(n, fences)
	return		void
	param		n		SizeI in value
	param		fences		FenceNV in array [n]
	category	NV_fence
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1276
	glxflags	ignore
	glsopcode	0x0216
	offset		647

GenFencesNV(n, fences)
	return		void
	param		n		SizeI in value
	param		fences		FenceNV out array [n]
	category	NV_fence
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1277
	glxflags	ignore
	glsopcode	0x0215
	offset		648

IsFenceNV(fence)
	return		Boolean
	param		fence		FenceNV in value
	category	NV_fence
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1278
	glxflags	ignore
	glsflags	get
	glsopcode	0x021A
	offset		649

TestFenceNV(fence)
	return		Boolean
	param		fence		FenceNV in value
	category	NV_fence
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1279
	glxflags	ignore
	glsflags	get
	glsopcode	0x0218
	offset		650

GetFenceivNV(fence, pname, params)
	return		void
	param		fence		FenceNV in value
	param		pname		FenceParameterNameNV in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	NV_fence
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1280
	glxflags	ignore
	glsflags	get
	glsopcode	0x021B
	offset		651

FinishFenceNV(fence)
	return		void
	param		fence		FenceNV in value
	category	NV_fence
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1312
	glxflags	ignore
	glsflags	get
	glsopcode	0x0219
	offset		652

SetFenceNV(fence, condition)
	return		void
	param		fence		FenceNV in value
	param		condition	FenceConditionNV in value
	category	NV_fence
	version		1.2
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsopcode	0x0217
	offset		653

###############################################################################
#
# Extension #225
# NV_evaluators commands
#
###############################################################################

MapControlPointsNV(target, index, type, ustride, vstride, uorder, vorder, packed, points)
	return		void
	param		target		EvalTargetNV in value
	param		index		UInt32 in value
	param		type		MapTypeNV in value
	param		ustride		SizeI in value
	param		vstride		SizeI in value
	param		uorder		CheckedInt32 in value
	param		vorder		CheckedInt32 in value
	param		packed		Boolean in value
	param		points		Void in array [COMPSIZE(target/uorder/vorder)]
	category	NV_evaluators
	dlflags		handcode
	version		1.1
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	ignore
	glsopcode	0x021C
	offset		?

MapParameterivNV(target, pname, params)
	return		void
	param		target		EvalTargetNV in value
	param		pname		MapParameterNV in value
	param		params		CheckedInt32 in array [COMPSIZE(target/pname)]
	category	NV_evaluators
	version		1.1
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	ignore
	glsopcode	0x021D
	offset		?

MapParameterfvNV(target, pname, params)
	return		void
	param		target		EvalTargetNV in value
	param		pname		MapParameterNV in value
	param		params		CheckedFloat32 in array [COMPSIZE(target/pname)]
	category	NV_evaluators
	version		1.1
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	ignore
	glsopcode	0x021E
	offset		?

GetMapControlPointsNV(target, index, type, ustride, vstride, packed, points)
	return		void
	param		target		EvalTargetNV in value
	param		index		UInt32 in value
	param		type		MapTypeNV in value
	param		ustride		SizeI in value
	param		vstride		SizeI in value
	param		packed		Boolean in value
	param		points		Void out array [COMPSIZE(target)]
	category	NV_evaluators
	dlflags		notlistable
	version		1.1
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	get
	glsopcode	0x021F
	offset		?

GetMapParameterivNV(target, pname, params)
	return		void
	param		target		EvalTargetNV in value
	param		pname		MapParameterNV in value
	param		params		Int32 out array [COMPSIZE(target/pname)]
	category	NV_evaluators
	dlflags		notlistable
	version		1.1
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	get
	glsopcode	0x0220
	offset		?

GetMapParameterfvNV(target, pname, params)
	return		void
	param		target		EvalTargetNV in value
	param		pname		MapParameterNV in value
	param		params		Float32 out array [COMPSIZE(target/pname)]
	category	NV_evaluators
	dlflags		notlistable
	version		1.1
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	get
	glsopcode	0x0221
	offset		?

GetMapAttribParameterivNV(target, index, pname, params)
	return		void
	param		target		EvalTargetNV in value
	param		index		UInt32 in value
	param		pname		MapAttribParameterNV in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	NV_evaluators
	dlflags		notlistable
	version		1.1
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	get
	glsopcode	0x0222
	offset		?

GetMapAttribParameterfvNV(target, index, pname, params)
	return		void
	param		target		EvalTargetNV in value
	param		index		UInt32 in value
	param		pname		MapAttribParameterNV in value
	param		params		Float32 out array [COMPSIZE(pname)]
	category	NV_evaluators
	dlflags		notlistable
	version		1.1
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	get
	glsopcode	0x0223
	offset		?

EvalMapsNV(target, mode)
	return		void
	param		target		EvalTargetNV in value
	param		mode		EvalMapsModeNV in value
	category	NV_evaluators
	version		1.1
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsopcode	0x0224
	offset		?

###############################################################################
#
# Extension #226
# NV_packed_depth_stencil commands
#
###############################################################################

# (none)
newcategory: NV_packed_depth_stencil

###############################################################################
#
# Extension #227
# NV_register_combiners2 commands
#
###############################################################################

CombinerStageParameterfvNV(stage, pname, params)
	return		void
	param		stage		CombinerStageNV in value
	param		pname		CombinerParameterNV in value
	param		params		CheckedFloat32 in array [COMPSIZE(pname)]
	category	NV_register_combiners2
	version		1.1
	extension
	glxflags	ignore
	glsopcode	0x0225
	offset		?

GetCombinerStageParameterfvNV(stage, pname, params)
	return		void
	param		stage		CombinerStageNV in value
	param		pname		CombinerParameterNV in value
	param		params		Float32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	NV_register_combiners2
	version		1.1
	extension
	glxflags	ignore
	glsflags	get
	glsopcode	0x0226
	offset		?

###############################################################################
#
# Extension #228
# NV_texture_compression_vtc commands
#
###############################################################################

# (none)
newcategory: NV_texture_compression_vtc

###############################################################################
#
# Extension #229
# NV_texture_rectangle commands
#
###############################################################################

# (none)
newcategory: NV_texture_rectangle

###############################################################################
#
# Extension #230
# NV_texture_shader commands
#
###############################################################################

# (none)
newcategory: NV_texture_shader

###############################################################################
#
# Extension #231
# NV_texture_shader2 commands
#
###############################################################################

# (none)
newcategory: NV_texture_shader2

###############################################################################
#
# Extension #232
# NV_vertex_array_range2 commands
#
###############################################################################

# (none)
newcategory: NV_vertex_array_range2

###############################################################################
#
# Extension #233
# NV_vertex_program commands
#
###############################################################################

AreProgramsResidentNV(n, programs, residences)
	return		Boolean
	param		n		SizeI in value
	param		programs	UInt32 in array [n]
	param		residences	Boolean out array [n]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxflags	ignore
	glxvendorpriv	1293
	glsflags	get
	glsopcode	0x022B
	offset		578

BindProgramNV(target, id)
	return		void
	param		target		VertexAttribEnumNV in value
	param		id		UInt32 in value
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4180
	glsopcode	0x0227
	alias		BindProgramARB
	glsalias	BindProgramARB

DeleteProgramsNV(n, programs)
	return		void
	param		n		SizeI in value
	param		programs	UInt32 in array [n]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1294
	glsopcode	0x0228
	alias		DeleteProgramsARB
	glsalias	DeleteProgramsARB

ExecuteProgramNV(target, id, params)
	return		void
	param		target		VertexAttribEnumNV in value
	param		id		UInt32 in value
	param		params		Float32 in array [4]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxflags	ignore
	glxropcode	4181
	glsopcode	0x0229
	offset		581

GenProgramsNV(n, programs)
	return		void
	param		n		SizeI in value
	param		programs	UInt32 out array [n]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1295
	glsopcode	0x022A
	alias		GenProgramsARB
	glsalias	GenProgramsARB

GetProgramParameterdvNV(target, index, pname, params)
	return		void
	param		target		VertexAttribEnumNV in value
	param		index		UInt32 in value
	param		pname		VertexAttribEnumNV in value
	param		params		Float64 out array [4]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxflags	ignore
	glxvendorpriv	1297
	glsflags	get
	glsopcode	0x022E
	offset		583

GetProgramParameterfvNV(target, index, pname, params)
	return		void
	param		target		VertexAttribEnumNV in value
	param		index		UInt32 in value
	param		pname		VertexAttribEnumNV in value
	param		params		Float32 out array [4]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxflags	ignore
	glxvendorpriv	1296
	glsflags	get
	glsopcode	0x022D
	offset		584

# GetProgramParameterSigneddvNV(target, index, pname, params)
#	  return	  void
#	  param		  target	  VertexAttribEnumNV in value
#	  param		  index		  Int32 in value
#	  param		  pname		  VertexAttribEnumNV in value
#	  param		  params	  Float64 out array [4]
#	  category	  NV_vertex_program1_1_dcc
#	  dlflags	  notlistable
#	  version	  1.2
#	  extension	  soft WINSOFT NV20
#	  glsflags	  ignore
#	  glxflags	  ignore
#	  offset	  ?
#
# GetProgramParameterSignedfvNV(target, index, pname, params)
#	  return	  void
#	  param		  target	  VertexAttribEnumNV in value
#	  param		  index		  Int32 in value
#	  param		  pname		  VertexAttribEnumNV in value
#	  param		  params	  Float32 out array [4]
#	  category	  NV_vertex_program1_1_dcc
#	  dlflags	  notlistable
#	  version	  1.2
#	  extension	  soft WINSOFT NV20
#	  glsflags	  ignore
#	  glxflags	  ignore
#	  offset	  ?

GetProgramivNV(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		VertexAttribEnumNV in value
	param		params		Int32 out array [4]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxflags	ignore
	glxvendorpriv	1298
	glsflags	get
	glsopcode	0x022F
	offset		585

GetProgramStringNV(id, pname, program)
	return		void
	param		id		UInt32 in value
	param		pname		VertexAttribEnumNV in value
	param		program		ProgramCharacterNV out array [COMPSIZE(id/pname)]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxflags	ignore
	glxvendorpriv	1299
	glsflags	get
	glsopcode	0x0230
	offset		586

GetTrackMatrixivNV(target, address, pname, params)
	return		void
	param		target		VertexAttribEnumNV in value
	param		address		UInt32 in value
	param		pname		VertexAttribEnumNV in value
	param		params		Int32 out array [1]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxflags	ignore
	glxvendorpriv	1300
	glsflags	get
	glsopcode	0x0231
	offset		587

GetVertexAttribdvNV(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribEnumNV in value
	param		params		Float64 out array [1]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1301
	glsflags	client get
	glsopcode	0x0232
	alias		GetVertexAttribdv
	glsalias	GetVertexAttribdv

GetVertexAttribfvNV(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribEnumNV in value
	param		params		Float32 out array [1]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1302
	glsflags	client get
	glsopcode	0x0233
	alias		GetVertexAttribfv
	glsalias	GetVertexAttribfv

GetVertexAttribivNV(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribEnumNV in value
	param		params		Int32 out array [1]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1303
	glsflags	client get
	glsopcode	0x0234
	alias		GetVertexAttribiv
	glsalias	GetVertexAttribiv

GetVertexAttribPointervNV(index, pname, pointer)
	return		void
	param		index		UInt32 in value
	param		pname		VertexAttribEnumNV in value
	param		pointer		VoidPointer out array [1]
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	client get
	glsopcode	0x0235
	alias		GetVertexAttribPointerv
	glsalias	GetVertexAttribPointerv

IsProgramNV(id)
	return		Boolean
	param		id		UInt32 in value
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxvendorpriv	1304
	glsflags	get
	glsopcode	0x0236
	alias		IsProgram
	glsalias	IsProgram

LoadProgramNV(target, id, len, program)
	return		void
	param		target		VertexAttribEnumNV in value
	param		id		UInt32 in value
	param		len		SizeI in value
	param		program		UInt8 in array [len]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4183
	glsopcode	0x0237
	offset		593

ProgramParameter4dNV(target, index, x, y, z, w)
	return		void
	param		target		VertexAttribEnumNV in value
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	param		w		Float64 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	ProgramParameter4dvNV
	extension	soft WINSOFT NV10
	offset		594

ProgramParameter4dvNV(target, index, v)
	return		void
	param		target		VertexAttribEnumNV in value
	param		index		UInt32 in value
	param		v		Float64 in array [4]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4185
	glsopcode	0x0238
	offset		595

ProgramParameter4fNV(target, index, x, y, z, w)
	return		void
	param		target		VertexAttribEnumNV in value
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	param		w		Float32 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	ProgramParameter4fvNV
	extension	soft WINSOFT NV10
	offset		596

ProgramParameter4fvNV(target, index, v)
	return		void
	param		target		VertexAttribEnumNV in value
	param		index		UInt32 in value
	param		v		Float32 in array [4]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4184
	glsopcode	0x0239
	offset		597

#??? 'count' was SizeI in the latest NVIDIA gl.spec, but UInt32 in the
#??? extension specification in the registry.
ProgramParameters4dvNV(target, index, count, v)
	return		void
	param		target		VertexAttribEnumNV in value
	param		index		UInt32 in value
	param		count		UInt32 in value
	param		v		Float64 in array [count*4]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4187
	glsopcode	0x023A
	offset		598

#??? 'count' was SizeI in the latest NVIDIA gl.spec, but UInt32 in the
#??? extension specification in the registry.
ProgramParameters4fvNV(target, index, count, v)
	return		void
	param		target		VertexAttribEnumNV in value
	param		index		UInt32 in value
	param		count		UInt32 in value
	param		v		Float32 in array [count*4]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4186
	glsopcode	0x023B
	offset		599

# ProgramParameterSigned4dNV(target, index, x, y, z, w)
#	  return	  void
#	  param		  target	  VertexAttribEnumNV in value
#	  param		  index		  Int32 in value
#	  param		  x		  Float64 in value
#	  param		  y		  Float64 in value
#	  param		  z		  Float64 in value
#	  param		  w		  Float64 in value
#	  category	  NV_vertex_program1_1_dcc
#	  version	  1.2
#	  vectorequiv	  ProgramParameterSigned4dvNV
#	  extension	  soft WINSOFT NV20
#	  offset	  ?
#
# ProgramParameterSigned4dvNV(target, index, v)
#	  return	  void
#	  param		  target	  VertexAttribEnumNV in value
#	  param		  index		  Int32 in value
#	  param		  v		  Float64 in array [4]
#	  category	  NV_vertex_program1_1_dcc
#	  version	  1.2
#	  extension	  soft WINSOFT NV20
#	  glsflags	  ignore
#	  glxflags	  ignore
#	  offset	  ?
#
# ProgramParameterSigned4fNV(target, index, x, y, z, w)
#	  return	  void
#	  param		  target	  VertexAttribEnumNV in value
#	  param		  index		  Int32 in value
#	  param		  x		  Float32 in value
#	  param		  y		  Float32 in value
#	  param		  z		  Float32 in value
#	  param		  w		  Float32 in value
#	  category	  NV_vertex_program1_1_dcc
#	  version	  1.2
#	  vectorequiv	  ProgramParameterSigned4fvNV
#	  extension	  soft WINSOFT NV20
#	  offset	  ?
#
# ProgramParameterSigned4fvNV(target, index, v)
#	  return	  void
#	  param		  target	  VertexAttribEnumNV in value
#	  param		  index		  Int32 in value
#	  param		  v		  Float32 in array [4]
#	  category	  NV_vertex_program1_1_dcc
#	  version	  1.2
#	  extension	  soft WINSOFT NV20
#	  glsflags	  ignore
#	  glxflags	  ignore
#	  offset	  ?
#
# ProgramParametersSigned4dvNV(target, index, count, v)
#	  return	  void
#	  param		  target	  VertexAttribEnumNV in value
#	  param		  index		  Int32 in value
#	  param		  count		  SizeI in value
#	  param		  v		  Float64 in array [count*4]
#	  category	  NV_vertex_program1_1_dcc
#	  version	  1.2
#	  extension	  soft WINSOFT NV20
#	  glsflags	  ignore
#	  glxflags	  ignore
#	  offset	  ?
#
# ProgramParametersSigned4fvNV(target, index, count, v)
#	  return	  void
#	  param		  target	  VertexAttribEnumNV in value
#	  param		  index		  Int32 in value
#	  param		  count		  SizeI in value
#	  param		  v		  Float32 in array [count*4]
#	  category	  NV_vertex_program1_1_dcc
#	  version	  1.2
#	  extension	  soft WINSOFT NV20
#	  glsflags	  ignore
#	  glxflags	  ignore
#	  offset	  ?

RequestResidentProgramsNV(n, programs)
	return		void
	param		n		SizeI in value
	param		programs	UInt32 in array [n]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4182
	glsopcode	0x022C
	offset		600

TrackMatrixNV(target, address, matrix, transform)
	return		void
	param		target		VertexAttribEnumNV in value
	param		address		UInt32 in value
	param		matrix		VertexAttribEnumNV in value
	param		transform	VertexAttribEnumNV in value
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4188
	glsopcode	0x023C
	offset		601

VertexAttribPointerNV(index, fsize, type, stride, pointer)
	return		void
	param		index		UInt32 in value
	param		fsize		Int32 in value
	param		type		VertexAttribEnumNV in value
	param		stride		SizeI in value
	param		pointer		Void in array [COMPSIZE(fsize/type/stride)] retained
	category	NV_vertex_program
	dlflags		notlistable
	version		1.2
	extension	soft WINSOFT NV10
	glxflags	ignore
	glsflags	client
	glsopcode	0x023D
	offset		602

VertexAttrib1dNV(index, x)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib1dvNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib1d
	glsalias	VertexAttrib1d

VertexAttrib1dvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [1]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4197
	glsopcode	0x0240
	alias		VertexAttrib1dv
	glsalias	VertexAttrib1dv

VertexAttrib1fNV(index, x)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib1fvNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib1f
	glsalias	VertexAttrib1f

VertexAttrib1fvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [1]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4193
	glsopcode	0x023F
	alias		VertexAttrib1fv
	glsalias	VertexAttrib1fv

VertexAttrib1sNV(index, x)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib1svNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib1s
	glsalias	VertexAttrib1s

VertexAttrib1svNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [1]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4189
	glsopcode	0x023E
	alias		VertexAttrib1sv
	glsalias	VertexAttrib1sv

VertexAttrib2dNV(index, x, y)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib2dvNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib2d
	glsalias	VertexAttrib2d

VertexAttrib2dvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [2]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4198
	glsopcode	0x0243
	alias		VertexAttrib2dv
	glsalias	VertexAttrib2dv

VertexAttrib2fNV(index, x, y)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib2fvNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib2f
	glsalias	VertexAttrib2f

VertexAttrib2fvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [2]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4194
	glsopcode	0x0242
	alias		VertexAttrib2fv
	glsalias	VertexAttrib2fv

VertexAttrib2sNV(index, x, y)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	param		y		Int16 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib2svNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib2s
	glsalias	VertexAttrib2s

VertexAttrib2svNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [2]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4190
	glsopcode	0x0241
	alias		VertexAttrib2sv
	glsalias	VertexAttrib2sv

VertexAttrib3dNV(index, x, y, z)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib3dvNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib3d
	glsalias	VertexAttrib3d

VertexAttrib3dvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [3]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4199
	glsopcode	0x0246
	alias		VertexAttrib3dv
	glsalias	VertexAttrib3dv

VertexAttrib3fNV(index, x, y, z)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib3fvNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib3f
	glsalias	VertexAttrib3f

VertexAttrib3fvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [3]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4195
	glsopcode	0x0245
	alias		VertexAttrib3fv
	glsalias	VertexAttrib3fv

VertexAttrib3sNV(index, x, y, z)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	param		y		Int16 in value
	param		z		Int16 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib3svNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib3s
	glsalias	VertexAttrib3s

VertexAttrib3svNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [3]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4191
	glsopcode	0x0244
	alias		VertexAttrib3sv
	glsalias	VertexAttrib3sv

VertexAttrib4dNV(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	param		w		Float64 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib4dvNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib4d
	glsalias	VertexAttrib4d

VertexAttrib4dvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float64 in array [4]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4200
	glsopcode	0x0249
	alias		VertexAttrib4dv
	glsalias	VertexAttrib4dv

VertexAttrib4fNV(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	param		w		Float32 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib4fvNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib4f
	glsalias	VertexAttrib4f

VertexAttrib4fvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Float32 in array [4]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4196
	glsopcode	0x0248
	alias		VertexAttrib4fv
	glsalias	VertexAttrib4fv

VertexAttrib4sNV(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		Int16 in value
	param		y		Int16 in value
	param		z		Int16 in value
	param		w		Int16 in value
	category	NV_vertex_program
	version		1.2
	vectorequiv	VertexAttrib4svNV
	extension	soft WINSOFT NV10
	alias		VertexAttrib4s
	glsalias	VertexAttrib4s

VertexAttrib4svNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Int16 in array [4]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4192
	glsopcode	0x0247
	alias		VertexAttrib4sv
	glsalias	VertexAttrib4sv

VertexAttrib4ubNV(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		ColorUB in value
	param		y		ColorUB in value
	param		z		ColorUB in value
	param		w		ColorUB in value
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	vectorequiv	VertexAttrib4ubvNV
	alias		VertexAttrib4Nub
	glsalias	VertexAttrib4Nub

VertexAttrib4ubvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		ColorUB in array [4]
	category	NV_vertex_program
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4201
	glsopcode	0x024A
	alias		VertexAttrib4Nubv
	glsalias	VertexAttrib4Nubv

VertexAttribs1dvNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Float64 in array [count]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4210
	glsopcode	0x024D
	offset		629

VertexAttribs1fvNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Float32 in array [count]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4206
	glsopcode	0x024C
	offset		630

VertexAttribs1svNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Int16 in array [count]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4202
	glsopcode	0x024B
	offset		631

VertexAttribs2dvNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Float64 in array [count*2]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4211
	glsopcode	0x0250
	offset		632

VertexAttribs2fvNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Float32 in array [count*2]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4207
	glsopcode	0x024F
	offset		633

VertexAttribs2svNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Int16 in array [count*2]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4203
	glsopcode	0x024E
	offset		634

VertexAttribs3dvNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Float64 in array [count*3]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4212
	glsopcode	0x0253
	offset		635

VertexAttribs3fvNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Float32 in array [count*3]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4208
	glsopcode	0x0252
	offset		636

VertexAttribs3svNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Int16 in array [count*3]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4204
	glsopcode	0x0251
	offset		637

VertexAttribs4dvNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Float64 in array [count*4]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4213
	glsopcode	0x0256
	offset		638

VertexAttribs4fvNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Float32 in array [count*4]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4209
	glsopcode	0x0255
	offset		639

VertexAttribs4svNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		Int16 in array [count*4]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4205
	glsopcode	0x0254
	offset		640

VertexAttribs4ubvNV(index, count, v)
	return		void
	param		index		UInt32 in value
	param		count		SizeI in value
	param		v		ColorUB in array [count*4]
	category	NV_vertex_program
	dlflags		handcode
	version		1.2
	extension	soft WINSOFT NV10
	glxropcode	4214
	glsopcode	0x0257
	offset		641


###############################################################################
#
# Extension #234 - GLX_SGIX_visual_select_group
#
###############################################################################

###############################################################################
#
# Extension #235
# SGIX_texture_coordinate_clamp commands
#
###############################################################################

# (none)
newcategory: SGIX_texture_coordinate_clamp

###############################################################################
#
# Extension #236
# SGIX_scalebias_hint commands
#
###############################################################################

# (none)
newcategory: SGIX_scalebias_hint

###############################################################################
#
# Extension #237 - GLX_OML_swap_method commands
# Extension #238 - GLX_OML_sync_control commands
#
###############################################################################

###############################################################################
#
# Extension #239
# OML_interlace commands
#
###############################################################################

# (none)
newcategory: OML_interlace

###############################################################################
#
# Extension #240
# OML_subsample commands
#
###############################################################################

# (none)
newcategory: OML_subsample

###############################################################################
#
# Extension #241
# OML_resample commands
#
###############################################################################

# (none)
newcategory: OML_resample

###############################################################################
#
# Extension #242 - WGL_OML_sync_control commands
#
###############################################################################

###############################################################################
#
# Extension #243
# NV_copy_depth_to_color commands
#
###############################################################################

# (none)
newcategory: NV_copy_depth_to_color

###############################################################################
#
# Extension #244
# ATI_envmap_bumpmap commands
#
###############################################################################

TexBumpParameterivATI(pname, param)
	return		void
	param		pname		TexBumpParameterATI in value
	param		param		Int32 in array [COMPSIZE(pname)]
	category	ATI_envmap_bumpmap
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

TexBumpParameterfvATI(pname, param)
	return		void
	param		pname		TexBumpParameterATI in value
	param		param		Float32 in array [COMPSIZE(pname)]
	category	ATI_envmap_bumpmap
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

GetTexBumpParameterivATI(pname, param)
	return		void
	param		pname		GetTexBumpParameterATI in value
	param		param		Int32 out array [COMPSIZE(pname)]
	category	ATI_envmap_bumpmap
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetTexBumpParameterfvATI(pname, param)
	return		void
	param		pname		GetTexBumpParameterATI in value
	param		param		Float32 out array [COMPSIZE(pname)]
	category	ATI_envmap_bumpmap
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

###############################################################################
#
# Extension #245
# ATI_fragment_shader commands
#
###############################################################################

GenFragmentShadersATI(range)
	return		UInt32
	param		range		UInt32 in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

BindFragmentShaderATI(id)
	return		void
	param		id		UInt32 in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

DeleteFragmentShaderATI(id)
	return		void
	param		id		UInt32 in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

BeginFragmentShaderATI()
	return		void
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

EndFragmentShaderATI()
	return		void
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

PassTexCoordATI(dst, coord, swizzle)
	return		void
	param		dst		UInt32 in value
	param		coord		UInt32 in value
	param		swizzle		SwizzleOpATI in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

SampleMapATI(dst, interp, swizzle)
	return		void
	param		dst		UInt32 in value
	param		interp		UInt32 in value
	param		swizzle		SwizzleOpATI in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

ColorFragmentOp1ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod)
	return		void
	param		op		FragmentOpATI in value
	param		dst		UInt32 in value
	param		dstMask		UInt32 in value
	param		dstMod		UInt32 in value
	param		arg1		UInt32 in value
	param		arg1Rep		UInt32 in value
	param		arg1Mod		UInt32 in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

ColorFragmentOp2ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod)
	return		void
	param		op		FragmentOpATI in value
	param		dst		UInt32 in value
	param		dstMask		UInt32 in value
	param		dstMod		UInt32 in value
	param		arg1		UInt32 in value
	param		arg1Rep		UInt32 in value
	param		arg1Mod		UInt32 in value
	param		arg2		UInt32 in value
	param		arg2Rep		UInt32 in value
	param		arg2Mod		UInt32 in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

ColorFragmentOp3ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod)
	return		void
	param		op		FragmentOpATI in value
	param		dst		UInt32 in value
	param		dstMask		UInt32 in value
	param		dstMod		UInt32 in value
	param		arg1		UInt32 in value
	param		arg1Rep		UInt32 in value
	param		arg1Mod		UInt32 in value
	param		arg2		UInt32 in value
	param		arg2Rep		UInt32 in value
	param		arg2Mod		UInt32 in value
	param		arg3		UInt32 in value
	param		arg3Rep		UInt32 in value
	param		arg3Mod		UInt32 in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

AlphaFragmentOp1ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod)
	return		void
	param		op		FragmentOpATI in value
	param		dst		UInt32 in value
	param		dstMod		UInt32 in value
	param		arg1		UInt32 in value
	param		arg1Rep		UInt32 in value
	param		arg1Mod		UInt32 in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

AlphaFragmentOp2ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod)
	return		void
	param		op		FragmentOpATI in value
	param		dst		UInt32 in value
	param		dstMod		UInt32 in value
	param		arg1		UInt32 in value
	param		arg1Rep		UInt32 in value
	param		arg1Mod		UInt32 in value
	param		arg2		UInt32 in value
	param		arg2Rep		UInt32 in value
	param		arg2Mod		UInt32 in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

AlphaFragmentOp3ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod)
	return		void
	param		op		FragmentOpATI in value
	param		dst		UInt32 in value
	param		dstMod		UInt32 in value
	param		arg1		UInt32 in value
	param		arg1Rep		UInt32 in value
	param		arg1Mod		UInt32 in value
	param		arg2		UInt32 in value
	param		arg2Rep		UInt32 in value
	param		arg2Mod		UInt32 in value
	param		arg3		UInt32 in value
	param		arg3Rep		UInt32 in value
	param		arg3Mod		UInt32 in value
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

SetFragmentShaderConstantATI(dst, value)
	return		void
	param		dst		UInt32 in value
	param		value		ConstFloat32 in array [4]
	category	ATI_fragment_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #246
# ATI_pn_triangles commands
#
###############################################################################

PNTrianglesiATI(pname, param)
	return		void
	param		pname		PNTrianglesPNameATI in value
	param		param		Int32 in value
	category	ATI_pn_triangles
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

PNTrianglesfATI(pname, param)
	return		void
	param		pname		PNTrianglesPNameATI in value
	param		param		Float32 in value
	category	ATI_pn_triangles
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #247
# ATI_vertex_array_object commands
#
###############################################################################

NewObjectBufferATI(size, pointer, usage)
	return		UInt32
	param		size		SizeI in value
	param		pointer		ConstVoid in array [size]
	param		usage		ArrayObjectUsageATI in value
	category	ATI_vertex_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

IsObjectBufferATI(buffer)
	return		Boolean
	param		buffer		UInt32 in value
	category	ATI_vertex_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

UpdateObjectBufferATI(buffer, offset, size, pointer, preserve)
	return		void
	param		buffer		UInt32 in value
	param		offset		UInt32 in value
	param		size		SizeI in value
	param		pointer		ConstVoid in array [size]
	param		preserve	PreserveModeATI in value
	category	ATI_vertex_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

GetObjectBufferfvATI(buffer, pname, params)
	return		void
	param		buffer		UInt32 in value
	param		pname		ArrayObjectPNameATI in value
	param		params		Float32 out array [1]
	category	ATI_vertex_array_object
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetObjectBufferivATI(buffer, pname, params)
	return		void
	param		buffer		UInt32 in value
	param		pname		ArrayObjectPNameATI in value
	param		params		Int32 out array [1]
	category	ATI_vertex_array_object
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

FreeObjectBufferATI(buffer)
	return		void
	param		buffer		UInt32 in value
	category	ATI_vertex_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

ArrayObjectATI(array, size, type, stride, buffer, offset)
	return		void
	param		array		EnableCap in value
	param		size		Int32 in value
	param		type		ScalarType in value
	param		stride		SizeI in value
	param		buffer		UInt32 in value
	param		offset		UInt32 in value
	category	ATI_vertex_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

GetArrayObjectfvATI(array, pname, params)
	return		void
	param		array		EnableCap in value
	param		pname		ArrayObjectPNameATI in value
	param		params		Float32 out array [1]
	category	ATI_vertex_array_object
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetArrayObjectivATI(array, pname, params)
	return		void
	param		array		EnableCap in value
	param		pname		ArrayObjectPNameATI in value
	param		params		Int32 out array [1]
	category	ATI_vertex_array_object
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

VariantArrayObjectATI(id, type, stride, buffer, offset)
	return		void
	param		id		UInt32 in value
	param		type		ScalarType in value
	param		stride		SizeI in value
	param		buffer		UInt32 in value
	param		offset		UInt32 in value
	category	ATI_vertex_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

GetVariantArrayObjectfvATI(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		ArrayObjectPNameATI in value
	param		params		Float32 out array [1]
	category	ATI_vertex_array_object
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetVariantArrayObjectivATI(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		ArrayObjectPNameATI in value
	param		params		Int32 out array [1]
	category	ATI_vertex_array_object
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

###############################################################################
#
# Extension #248
# EXT_vertex_shader commands
#
###############################################################################

BeginVertexShaderEXT()
	return		void
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

EndVertexShaderEXT()
	return		void
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

BindVertexShaderEXT(id)
	return		void
	param		id		UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

GenVertexShadersEXT(range)
	return		UInt32
	param		range		UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

DeleteVertexShaderEXT(id)
	return		void
	param		id		UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

ShaderOp1EXT(op, res, arg1)
	return		void
	param		op		VertexShaderOpEXT in value
	param		res		UInt32 in value
	param		arg1		UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

ShaderOp2EXT(op, res, arg1, arg2)
	return		void
	param		op		VertexShaderOpEXT in value
	param		res		UInt32 in value
	param		arg1		UInt32 in value
	param		arg2		UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

ShaderOp3EXT(op, res, arg1, arg2, arg3)
	return		void
	param		op		VertexShaderOpEXT in value
	param		res		UInt32 in value
	param		arg1		UInt32 in value
	param		arg2		UInt32 in value
	param		arg3		UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

SwizzleEXT(res, in, outX, outY, outZ, outW)
	return		void
	param		res		UInt32 in value
	param		in		UInt32 in value
	param		outX		VertexShaderCoordOutEXT in value
	param		outY		VertexShaderCoordOutEXT in value
	param		outZ		VertexShaderCoordOutEXT in value
	param		outW		VertexShaderCoordOutEXT in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

WriteMaskEXT(res, in, outX, outY, outZ, outW)
	return		void
	param		res		UInt32 in value
	param		in		UInt32 in value
	param		outX		VertexShaderWriteMaskEXT in value
	param		outY		VertexShaderWriteMaskEXT in value
	param		outZ		VertexShaderWriteMaskEXT in value
	param		outW		VertexShaderWriteMaskEXT in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

InsertComponentEXT(res, src, num)
	return		void
	param		res		UInt32 in value
	param		src		UInt32 in value
	param		num		UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

ExtractComponentEXT(res, src, num)
	return		void
	param		res		UInt32 in value
	param		src		UInt32 in value
	param		num		UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

GenSymbolsEXT(datatype, storagetype, range, components)
	return		UInt32
	param		datatype	DataTypeEXT in value
	param		storagetype	VertexShaderStorageTypeEXT in value
	param		range		ParameterRangeEXT in value
	param		components	UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

SetInvariantEXT(id, type, addr)
	return		void
	param		id		UInt32 in value
	param		type		ScalarType in value
	param		addr		Void in array [COMPSIZE(id/type)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

SetLocalConstantEXT(id, type, addr)
	return		void
	param		id		UInt32 in value
	param		type		ScalarType in value
	param		addr		Void in array [COMPSIZE(id/type)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VariantbvEXT(id, addr)
	return		void
	param		id		UInt32 in value
	param		addr		Int8 in array [COMPSIZE(id)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VariantsvEXT(id, addr)
	return		void
	param		id		UInt32 in value
	param		addr		Int16 in array [COMPSIZE(id)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VariantivEXT(id, addr)
	return		void
	param		id		UInt32 in value
	param		addr		Int32 in array [COMPSIZE(id)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VariantfvEXT(id, addr)
	return		void
	param		id		UInt32 in value
	param		addr		Float32 in array [COMPSIZE(id)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VariantdvEXT(id, addr)
	return		void
	param		id		UInt32 in value
	param		addr		Float64 in array [COMPSIZE(id)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VariantubvEXT(id, addr)
	return		void
	param		id		UInt32 in value
	param		addr		UInt8 in array [COMPSIZE(id)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VariantusvEXT(id, addr)
	return		void
	param		id		UInt32 in value
	param		addr		UInt16 in array [COMPSIZE(id)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VariantuivEXT(id, addr)
	return		void
	param		id		UInt32 in value
	param		addr		UInt32 in array [COMPSIZE(id)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VariantPointerEXT(id, type, stride, addr)
	return		void
	param		id		UInt32 in value
	param		type		ScalarType in value
	param		stride		UInt32 in value
	param		addr		Void in array [COMPSIZE(id/type/stride)]
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

EnableVariantClientStateEXT(id)
	return		void
	param		id		UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

DisableVariantClientStateEXT(id)
	return		void
	param		id		UInt32 in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

BindLightParameterEXT(light, value)
	return		UInt32
	param		light		LightName in value
	param		value		LightParameter in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

BindMaterialParameterEXT(face, value)
	return		UInt32
	param		face		MaterialFace in value
	param		value		MaterialParameter in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

BindTexGenParameterEXT(unit, coord, value)
	return		UInt32
	param		unit		TextureUnit in value
	param		coord		TextureCoordName in value
	param		value		TextureGenParameter in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

BindTextureUnitParameterEXT(unit, value)
	return		UInt32
	param		unit		TextureUnit in value
	param		value		VertexShaderTextureUnitParameter in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

BindParameterEXT(value)
	return		UInt32
	param		value		VertexShaderParameterEXT in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

IsVariantEnabledEXT(id, cap)
	return		Boolean
	param		id		UInt32 in value
	param		cap		VariantCapEXT in value
	category	EXT_vertex_shader
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

GetVariantBooleanvEXT(id, value, data)
	return		void
	param		id		UInt32 in value
	param		value		GetVariantValueEXT in value
	param		data		Boolean out array [COMPSIZE(id)]
	category	EXT_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetVariantIntegervEXT(id, value, data)
	return		void
	param		id		UInt32 in value
	param		value		GetVariantValueEXT in value
	param		data		Int32 out array [COMPSIZE(id)]
	category	EXT_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetVariantFloatvEXT(id, value, data)
	return		void
	param		id		UInt32 in value
	param		value		GetVariantValueEXT in value
	param		data		Float32 out array [COMPSIZE(id)]
	category	EXT_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetVariantPointervEXT(id, value, data)
	return		void
	param		id		UInt32 in value
	param		value		GetVariantValueEXT in value
	param		data		VoidPointer out array [COMPSIZE(id)]
	category	EXT_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetInvariantBooleanvEXT(id, value, data)
	return		void
	param		id		UInt32 in value
	param		value		GetVariantValueEXT in value
	param		data		Boolean out array [COMPSIZE(id)]
	category	EXT_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetInvariantIntegervEXT(id, value, data)
	return		void
	param		id		UInt32 in value
	param		value		GetVariantValueEXT in value
	param		data		Int32 out array [COMPSIZE(id)]
	category	EXT_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetInvariantFloatvEXT(id, value, data)
	return		void
	param		id		UInt32 in value
	param		value		GetVariantValueEXT in value
	param		data		Float32 out array [COMPSIZE(id)]
	category	EXT_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetLocalConstantBooleanvEXT(id, value, data)
	return		void
	param		id		UInt32 in value
	param		value		GetVariantValueEXT in value
	param		data		Boolean out array [COMPSIZE(id)]
	category	EXT_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetLocalConstantIntegervEXT(id, value, data)
	return		void
	param		id		UInt32 in value
	param		value		GetVariantValueEXT in value
	param		data		Int32 out array [COMPSIZE(id)]
	category	EXT_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

GetLocalConstantFloatvEXT(id, value, data)
	return		void
	param		id		UInt32 in value
	param		value		GetVariantValueEXT in value
	param		data		Float32 out array [COMPSIZE(id)]
	category	EXT_vertex_shader
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	ignore get
	offset		?

###############################################################################
#
# Extension #249
# ATI_vertex_streams commands
#
###############################################################################

VertexStream1sATI(stream, x)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Int16 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream1svATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int16 in array [1]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream1iATI(stream, x)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Int32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream1ivATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int32 in array [1]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream1fATI(stream, x)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Float32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream1fvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Float32 in array [1]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream1dATI(stream, x)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Float64 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream1dvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Float64 in array [1]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream2sATI(stream, x, y)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Int16 in value
	param		y		Int16 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream2svATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int16 in array [2]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream2iATI(stream, x, y)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Int32 in value
	param		y		Int32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream2ivATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int32 in array [2]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream2fATI(stream, x, y)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Float32 in value
	param		y		Float32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream2fvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Float32 in array [2]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream2dATI(stream, x, y)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Float64 in value
	param		y		Float64 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream2dvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Float64 in array [2]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream3sATI(stream, x, y, z)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Int16 in value
	param		y		Int16 in value
	param		z		Int16 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream3svATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int16 in array [3]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream3iATI(stream, x, y, z)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Int32 in value
	param		y		Int32 in value
	param		z		Int32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream3ivATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int32 in array [3]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream3fATI(stream, x, y, z)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream3fvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Float32 in array [3]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream3dATI(stream, x, y, z)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream3dvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Float64 in array [3]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream4sATI(stream, x, y, z, w)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Int16 in value
	param		y		Int16 in value
	param		z		Int16 in value
	param		w		Int16 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream4svATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int16 in array [4]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream4iATI(stream, x, y, z, w)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Int32 in value
	param		y		Int32 in value
	param		z		Int32 in value
	param		w		Int32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream4ivATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int32 in array [4]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream4fATI(stream, x, y, z, w)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	param		w		Float32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream4fvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Float32 in array [4]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream4dATI(stream, x, y, z, w)
	return		void
	param		stream		VertexStreamATI in value
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	param		w		Float64 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexStream4dvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Float64 in array [4]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

NormalStream3bATI(stream, nx, ny, nz)
	return		void
	param		stream		VertexStreamATI in value
	param		nx		Int8 in value
	param		ny		Int8 in value
	param		nz		Int8 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

NormalStream3bvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int8 in array [3]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

NormalStream3sATI(stream, nx, ny, nz)
	return		void
	param		stream		VertexStreamATI in value
	param		nx		Int16 in value
	param		ny		Int16 in value
	param		nz		Int16 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

NormalStream3svATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int16 in array [3]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

NormalStream3iATI(stream, nx, ny, nz)
	return		void
	param		stream		VertexStreamATI in value
	param		nx		Int32 in value
	param		ny		Int32 in value
	param		nz		Int32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

NormalStream3ivATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Int32 in array [3]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

NormalStream3fATI(stream, nx, ny, nz)
	return		void
	param		stream		VertexStreamATI in value
	param		nx		Float32 in value
	param		ny		Float32 in value
	param		nz		Float32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

NormalStream3fvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Float32 in array [3]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

NormalStream3dATI(stream, nx, ny, nz)
	return		void
	param		stream		VertexStreamATI in value
	param		nx		Float64 in value
	param		ny		Float64 in value
	param		nz		Float64 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

NormalStream3dvATI(stream, coords)
	return		void
	param		stream		VertexStreamATI in value
	param		coords		Float64 in array [3]
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

ClientActiveVertexStreamATI(stream)
	return		void
	param		stream		VertexStreamATI in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexBlendEnviATI(pname, param)
	return		void
	param		pname		VertexStreamATI in value
	param		param		Int32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

VertexBlendEnvfATI(pname, param)
	return		void
	param		pname		VertexStreamATI in value
	param		param		Float32 in value
	category	ATI_vertex_streams
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsflags	ignore
	offset		?

###############################################################################
#
# Extension #250 - WGL_I3D_digital_video_control
# Extension #251 - WGL_I3D_gamma
# Extension #252 - WGL_I3D_genlock
# Extension #253 - WGL_I3D_image_buffer
# Extension #254 - WGL_I3D_swap_frame_lock
# Extension #255 - WGL_I3D_swap_frame_usage
#
###############################################################################

###############################################################################
#
# Extension #256
# ATI_element_array commands
#
###############################################################################

ElementPointerATI(type, pointer)
	return		void
	param		type		ElementPointerTypeATI in value
	param		pointer		Void in array [COMPSIZE(type)] retained
	category	ATI_element_array
	dlflags		notlistable
	glxflags	client-handcode client-intercept server-handcode
	version		1.2
	glsflags	ignore
	offset		?

DrawElementArrayATI(mode, count)
	return		void
	param		mode		BeginMode in value
	param		count		SizeI in value
	category	ATI_element_array
	dlflags		handcode
	glxflags	client-handcode client-intercept server-handcode
	version		1.2
	glsopcode	?
	offset		?

DrawRangeElementArrayATI(mode, start, end, count)
	return		void
	param		mode		BeginMode in value
	param		start		UInt32 in value
	param		end		UInt32 in value
	param		count		SizeI in value
	category	ATI_element_array
	dlflags		handcode
	glxflags	client-handcode client-intercept server-handcode
	version		1.2
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #257
# SUN_mesh_array commands
#
###############################################################################

DrawMeshArraysSUN(mode, first, count, width)
	return		void
	param		mode		BeginMode in value
	param		first		Int32 in value
	param		count		SizeI in value
	param		width		SizeI in value
	category	SUN_mesh_array
	dlflags		handcode
	glxflags	client-handcode client-intercept server-handcode
	version		1.1
	glxropcode	?
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #258
# SUN_slice_accum commands
#
###############################################################################

# (none)
newcategory: SUN_slice_accum

###############################################################################
#
# Extension #259
# NV_multisample_filter_hint commands
#
###############################################################################

# (none)
newcategory: NV_multisample_filter_hint

###############################################################################
#
# Extension #260
# NV_depth_clamp commands
#
###############################################################################

# (none)
newcategory: NV_depth_clamp

###############################################################################
#
# Extension #261
# NV_occlusion_query commands
#
###############################################################################

GenOcclusionQueriesNV(n, ids)
	return		void
	param		n		SizeI in value
	param		ids		UInt32 out array [n]
	dlflags		notlistable
	category	NV_occlusion_query
	version		1.2
	extension	soft WINSOFT NV20
	glsflags	ignore
	glxflags	ignore

DeleteOcclusionQueriesNV(n, ids)
	return		void
	param		n		SizeI in value
	param		ids		UInt32 in array [n]
	dlflags		notlistable
	category	NV_occlusion_query
	version		1.2
	extension	soft WINSOFT NV20
	glsflags	ignore
	glxflags	ignore

IsOcclusionQueryNV(id)
	return		Boolean
	param		id		UInt32 in value
	dlflags		notlistable
	category	NV_occlusion_query
	version		1.2
	extension	soft WINSOFT NV20
	glsflags	ignore
	glxflags	ignore

BeginOcclusionQueryNV(id)
	return		void
	param		id		UInt32 in value
	category	NV_occlusion_query
	version		1.2
	extension	soft WINSOFT NV20
	glsflags	ignore
	glxflags	ignore

EndOcclusionQueryNV()
	return		void
	category	NV_occlusion_query
	version		1.2
	extension	soft WINSOFT NV20
	glsflags	ignore
	glxflags	ignore

GetOcclusionQueryivNV(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		OcclusionQueryParameterNameNV in value
	param		params		Int32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	NV_occlusion_query
	version		1.2
	extension	soft WINSOFT NV20
	glsflags	ignore
	glxflags	ignore

GetOcclusionQueryuivNV(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		OcclusionQueryParameterNameNV in value
	param		params		UInt32 out array [COMPSIZE(pname)]
	dlflags		notlistable
	category	NV_occlusion_query
	version		1.2
	extension	soft WINSOFT NV20
	glsflags	ignore
	glxflags	ignore

###############################################################################
#
# Extension #262
# NV_point_sprite commands
#
###############################################################################

PointParameteriNV(pname, param)
	return		void
	param		pname		PointParameterNameARB in value
	param		param		Int32 in value
	category	NV_point_sprite
	version		1.2
	extension	soft WINSOFT NV20
	glxropcode	4221
	alias		PointParameteri
	glsalias	PointParameteri

PointParameterivNV(pname, params)
	return		void
	param		pname		PointParameterNameARB in value
	param		params		Int32 in array [COMPSIZE(pname)]
	category	NV_point_sprite
	version		1.2
	extension	soft WINSOFT NV20
	glxropcode	4222
	alias		PointParameteriv
	glsalias	PointParameteriv

###############################################################################
#
# Extension #263 - WGL_NV_render_depth_texture
# Extension #264 - WGL_NV_render_texture_rectangle
#
###############################################################################

###############################################################################
#
# Extension #265
# NV_texture_shader3 commands
#
###############################################################################

# (none)
newcategory: NV_texture_shader3

###############################################################################
#
# Extension #266
# NV_vertex_program1_1 commands
#
###############################################################################

# (none)
newcategory: NV_vertex_program1_1

###############################################################################
#
# Extension #267
# EXT_shadow_funcs commands
#
###############################################################################

# (none)
newcategory: EXT_shadow_funcs

###############################################################################
#
# Extension #268
# EXT_stencil_two_side commands
#
###############################################################################

ActiveStencilFaceEXT(face)
	return		void
	param		face		StencilFaceDirection in value
	category	EXT_stencil_two_side
	version		1.3
	glxropcode	4220
	glsopcode	?
	offset		646

###############################################################################
#
# Extension #269
# ATI_text_fragment_shader commands
#
###############################################################################

# Uses ARB_vertex_program entry points
newcategory: ATI_text_fragment_shader

###############################################################################
#
# Extension #270
# APPLE_client_storage commands
#
###############################################################################

# (none)
newcategory: APPLE_client_storage

###############################################################################
#
# Extension #271
# APPLE_element_array commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

# @@@ like #256 ATI_element_array
ElementPointerAPPLE(type, pointer)
	return		void
	param		type		ElementPointerTypeATI in value
	param		pointer		Void in array [type]
	category	APPLE_element_array
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

DrawElementArrayAPPLE(mode, first, count)
	return		void
	param		mode		BeginMode in value
	param		first		Int32 in value
	param		count		SizeI in value
	category	APPLE_element_array
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

DrawRangeElementArrayAPPLE(mode, start, end, first, count)
	return		void
	param		mode		BeginMode in value
	param		start		UInt32 in value
	param		end		UInt32 in value
	param		first		Int32 in value
	param		count		SizeI in value
	category	APPLE_element_array
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

MultiDrawElementArrayAPPLE(mode, first, count, primcount)
	return		void
	param		mode		BeginMode in value
	param		first		Int32 in array [primcount]
	param		count		SizeI in array [primcount]
	param		primcount	SizeI in value
	category	APPLE_element_array
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

MultiDrawRangeElementArrayAPPLE(mode, start, end, first, count, primcount)
	return		void
	param		mode		BeginMode in value
	param		start		UInt32 in value
	param		end		UInt32 in value
	param		first		Int32 in array [primcount]
	param		count		SizeI in array [primcount]
	param		primcount	SizeI in value
	category	APPLE_element_array
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #272
# APPLE_fence commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

# @@@ like #222 NV_fence
GenFencesAPPLE(n, fences)
	return		void
	param		n		SizeI in value
	param		fences		FenceNV out array [n]
	category	APPLE_fence
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

DeleteFencesAPPLE(n, fences)
	return		void
	param		n		SizeI in value
	param		fences		FenceNV in array [n]
	category	APPLE_fence
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

SetFenceAPPLE(fence)
	return		void
	param		fence		FenceNV in value
	category	APPLE_fence
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

IsFenceAPPLE(fence)
	return		Boolean
	param		fence		FenceNV in value
	category	APPLE_fence
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

TestFenceAPPLE(fence)
	return		Boolean
	param		fence		FenceNV in value
	category	APPLE_fence
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

FinishFenceAPPLE(fence)
	return		void
	param		fence		FenceNV in value
	category	APPLE_fence
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

TestObjectAPPLE(object, name)
	return		Boolean
	param		object		ObjectTypeAPPLE in value
	param		name		UInt32 in value
	category	APPLE_fence
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

FinishObjectAPPLE(object, name)
	return		void
	param		object		ObjectTypeAPPLE in value
	param		name		Int32 in value
	category	APPLE_fence
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #273
# APPLE_vertex_array_object commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

# @@@ loosely derived from incomplete SGIX_vertex_array_object
BindVertexArrayAPPLE(array)
	return		void
	param		array		UInt32 in value
	category	APPLE_vertex_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

DeleteVertexArraysAPPLE(n, arrays)
	return		void
	param		n		SizeI in value
	param		arrays		UInt32 in array [n]
	category	APPLE_vertex_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

GenVertexArraysAPPLE(n, arrays)
	return		void
	param		n		SizeI in value
	param		arrays		UInt32 out array [n]
	category	APPLE_vertex_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

IsVertexArrayAPPLE(array)
	return		Boolean
	param		array		UInt32 in value
	category	APPLE_vertex_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #274
# APPLE_vertex_array_range commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

# @@@ like #190 NV_vertex_array_range,
VertexArrayRangeAPPLE(length, pointer)
	return		void
	param		length		SizeI in value
	param		pointer		Void out array [length]
	category	APPLE_vertex_array_range
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

FlushVertexArrayRangeAPPLE(length, pointer)
	return		void
	param		length		SizeI in value
	param		pointer		Void out array [length]
	category	APPLE_vertex_array_range
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexArrayParameteriAPPLE(pname, param)
	return		void
	param		pname		VertexArrayPNameAPPLE in value
	param		param		Int32 in value
	category	APPLE_vertex_array_range
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #275
# APPLE_ycbcr_422 commands
#
###############################################################################

# (none)
newcategory: APPLE_ycbcr_422

###############################################################################
#
# Extension #276
# S3_s3tc commands
#
###############################################################################

# (none)
newcategory: S3_s3tc

###############################################################################
#
# Extension #277
# ATI_draw_buffers commands
#
###############################################################################

DrawBuffersATI(n, bufs)
	return		void
	param		n		SizeI in value
	param		bufs		DrawBufferModeATI in array [n]
	category	ATI_draw_buffers
	version		1.2
	extension
	glxropcode	233
	alias		DrawBuffers
	glsalias	DrawBuffers

###############################################################################
#
# Extension #278 - WGL_ATI_pixel_format_float
#
###############################################################################
newcategory: ATI_pixel_format_float
passthru: /* This is really a WGL extension, but defines some associated GL enums.
passthru:  * ATI does not export "GL_ATI_pixel_format_float" in the GL_EXTENSIONS string.
passthru:  */

###############################################################################
#
# Extension #279
# ATI_texture_env_combine3 commands
#
###############################################################################

# (none)
newcategory: ATI_texture_env_combine3

###############################################################################
#
# Extension #280
# ATI_texture_float commands
#
###############################################################################

# (none)
newcategory: ATI_texture_float

###############################################################################
#
# Extension #281 (also WGL_NV_float_buffer)
# NV_float_buffer commands
#
###############################################################################

# (none)
newcategory: NV_float_buffer

###############################################################################
#
# Extension #282
# NV_fragment_program commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

# Some NV_fragment_program entry points are shared with ARB_vertex_program,
#   and are only included in that #define block, for now.
newcategory: NV_fragment_program
passthru: /* Some NV_fragment_program entry points are shared with ARB_vertex_program. */

ProgramNamedParameter4fNV(id, len, name, x, y, z, w)
	return		void
	param		id		UInt32 in value
	param		len		SizeI in value
	param		name		UInt8 in array [1]
	param		x		Float32 in value
	param		y		Float32 in value
	param		z		Float32 in value
	param		w		Float32 in value
	category	NV_fragment_program
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		682

ProgramNamedParameter4dNV(id, len, name, x, y, z, w)
	return		void
	param		id		UInt32 in value
	param		len		SizeI in value
	param		name		UInt8 in array [1]
	param		x		Float64 in value
	param		y		Float64 in value
	param		z		Float64 in value
	param		w		Float64 in value
	category	NV_fragment_program
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		683

ProgramNamedParameter4fvNV(id, len, name, v)
	return		void
	param		id		UInt32 in value
	param		len		SizeI in value
	param		name		UInt8 in array [1]
	param		v		Float32 in array [4]
	category	NV_fragment_program
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		684

ProgramNamedParameter4dvNV(id, len, name, v)
	return		void
	param		id		UInt32 in value
	param		len		SizeI in value
	param		name		UInt8 in array [1]
	param		v		Float64 in array [4]
	category	NV_fragment_program
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		685

GetProgramNamedParameterfvNV(id, len, name, params)
	return		void
	param		id		UInt32 in value
	param		len		SizeI in value
	param		name		UInt8 in array [1]
	param		params		Float32 out array [4]
	category	NV_fragment_program
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		686

GetProgramNamedParameterdvNV(id, len, name, params)
	return		void
	param		id		UInt32 in value
	param		len		SizeI in value
	param		name		UInt8 in array [1]
	param		params		Float64 out array [4]
	category	NV_fragment_program
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		687

###############################################################################
#
# Extension #283
# NV_half_float commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

Vertex2hNV(x, y)
	return		void
	param		x		Half16NV in value
	param		y		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Vertex2hvNV(v)
	return		void
	param		v		Half16NV in array [2]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Vertex3hNV(x, y, z)
	return		void
	param		x		Half16NV in value
	param		y		Half16NV in value
	param		z		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Vertex3hvNV(v)
	return		void
	param		v		Half16NV in array [3]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Vertex4hNV(x, y, z, w)
	return		void
	param		x		Half16NV in value
	param		y		Half16NV in value
	param		z		Half16NV in value
	param		w		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Vertex4hvNV(v)
	return		void
	param		v		Half16NV in array [4]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Normal3hNV(nx, ny, nz)
	return		void
	param		nx		Half16NV in value
	param		ny		Half16NV in value
	param		nz		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Normal3hvNV(v)
	return		void
	param		v		Half16NV in array [3]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Color3hNV(red, green, blue)
	return		void
	param		red		Half16NV in value
	param		green		Half16NV in value
	param		blue		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Color3hvNV(v)
	return		void
	param		v		Half16NV in array [3]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Color4hNV(red, green, blue, alpha)
	return		void
	param		red		Half16NV in value
	param		green		Half16NV in value
	param		blue		Half16NV in value
	param		alpha		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

Color4hvNV(v)
	return		void
	param		v		Half16NV in array [4]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

TexCoord1hNV(s)
	return		void
	param		s		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

TexCoord1hvNV(v)
	return		void
	param		v		Half16NV in array [1]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

TexCoord2hNV(s, t)
	return		void
	param		s		Half16NV in value
	param		t		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

TexCoord2hvNV(v)
	return		void
	param		v		Half16NV in array [2]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

TexCoord3hNV(s, t, r)
	return		void
	param		s		Half16NV in value
	param		t		Half16NV in value
	param		r		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

TexCoord3hvNV(v)
	return		void
	param		v		Half16NV in array [3]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

TexCoord4hNV(s, t, r, q)
	return		void
	param		s		Half16NV in value
	param		t		Half16NV in value
	param		r		Half16NV in value
	param		q		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

TexCoord4hvNV(v)
	return		void
	param		v		Half16NV in array [4]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

MultiTexCoord1hNV(target, s)
	return		void
	param		target		TextureUnit in value
	param		s		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

MultiTexCoord1hvNV(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		Half16NV in array [1]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

MultiTexCoord2hNV(target, s, t)
	return		void
	param		target		TextureUnit in value
	param		s		Half16NV in value
	param		t		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

MultiTexCoord2hvNV(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		Half16NV in array [2]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

MultiTexCoord3hNV(target, s, t, r)
	return		void
	param		target		TextureUnit in value
	param		s		Half16NV in value
	param		t		Half16NV in value
	param		r		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

MultiTexCoord3hvNV(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		Half16NV in array [3]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

MultiTexCoord4hNV(target, s, t, r, q)
	return		void
	param		target		TextureUnit in value
	param		s		Half16NV in value
	param		t		Half16NV in value
	param		r		Half16NV in value
	param		q		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

MultiTexCoord4hvNV(target, v)
	return		void
	param		target		TextureUnit in value
	param		v		Half16NV in array [4]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

FogCoordhNV(fog)
	return		void
	param		fog		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

FogCoordhvNV(fog)
	return		void
	param		fog		Half16NV in array [1]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

SecondaryColor3hNV(red, green, blue)
	return		void
	param		red		Half16NV in value
	param		green		Half16NV in value
	param		blue		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

SecondaryColor3hvNV(v)
	return		void
	param		v		Half16NV in array [3]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexWeighthNV(weight)
	return		void
	param		weight		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexWeighthvNV(weight)
	return		void
	param		weight		Half16NV in array [1]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttrib1hNV(index, x)
	return		void
	param		index		UInt32 in value
	param		x		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttrib1hvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Half16NV in array [1]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttrib2hNV(index, x, y)
	return		void
	param		index		UInt32 in value
	param		x		Half16NV in value
	param		y		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttrib2hvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Half16NV in array [2]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttrib3hNV(index, x, y, z)
	return		void
	param		index		UInt32 in value
	param		x		Half16NV in value
	param		y		Half16NV in value
	param		z		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttrib3hvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Half16NV in array [3]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttrib4hNV(index, x, y, z, w)
	return		void
	param		index		UInt32 in value
	param		x		Half16NV in value
	param		y		Half16NV in value
	param		z		Half16NV in value
	param		w		Half16NV in value
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttrib4hvNV(index, v)
	return		void
	param		index		UInt32 in value
	param		v		Half16NV in array [4]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttribs1hvNV(index, n, v)
	return		void
	param		index		UInt32 in value
	param		n		SizeI in value
	param		v		Half16NV in array [n]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttribs2hvNV(index, n, v)
	return		void
	param		index		UInt32 in value
	param		n		SizeI in value
	param		v		Half16NV in array [n]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttribs3hvNV(index, n, v)
	return		void
	param		index		UInt32 in value
	param		n		SizeI in value
	param		v		Half16NV in array [n]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

VertexAttribs4hvNV(index, n, v)
	return		void
	param		index		UInt32 in value
	param		n		SizeI in value
	param		v		Half16NV in array [n]
	category	NV_half_float
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #284
# NV_pixel_data_range commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

PixelDataRangeNV(target, length, pointer)
	return		void
	param		target		PixelDataRangeTargetNV in value
	param		length		SizeI in value
	param		pointer		Void out array [length]
	category	NV_pixel_data_range
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

FlushPixelDataRangeNV(target)
	return		void
	param		target		PixelDataRangeTargetNV in value
	category	NV_pixel_data_range
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #285
# NV_primitive_restart commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

PrimitiveRestartNV()
	return		void
	category	NV_primitive_restart
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

PrimitiveRestartIndexNV(index)
	return		void
	param		index		UInt32 in value
	category	NV_primitive_restart
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?


###############################################################################
#
# Extension #286
# NV_texture_expand_normal commands
#
###############################################################################

# (none)
newcategory: NV_texture_expand_normal

###############################################################################
#
# Extension #287
# NV_vertex_program2 commands
#
###############################################################################

# (none)
newcategory: NV_vertex_program2

###############################################################################
#
# Extension #288
# ATI_map_object_buffer commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

MapObjectBufferATI(buffer)
	return		VoidPointer
	param		buffer		UInt32 in value
	category	ATI_map_object_buffer
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

UnmapObjectBufferATI(buffer)
	return		void
	param		buffer		UInt32 in value
	category	ATI_map_object_buffer
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #289
# ATI_separate_stencil commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

StencilOpSeparateATI(face, sfail, dpfail, dppass)
	return		void
	param		face		StencilFaceDirection in value
	param		sfail		StencilOp in value
	param		dpfail		StencilOp in value
	param		dppass		StencilOp in value
	category	ATI_separate_stencil
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		StencilOpSeparate
	glsalias	StencilOpSeparate

StencilFuncSeparateATI(frontfunc, backfunc, ref, mask)
	return		void
	param		frontfunc	StencilFunction in value
	param		backfunc	StencilFunction in value
	param		ref		ClampedStencilValue in value
	param		mask		MaskedStencilValue in value
	category	ATI_separate_stencil
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	alias		StencilFuncSeparate
	glsalias	StencilFuncSeparate

###############################################################################
#
# Extension #290
# ATI_vertex_attrib_array_object commands
#
###############################################################################

# @@ Need to verify/add GLX protocol

VertexAttribArrayObjectATI(index, size, type, normalized, stride, buffer, offset)
	return		void
	param		index		UInt32 in value
	param		size		Int32 in value
	param		type		VertexAttribPointerTypeARB in value
	param		normalized	Boolean in value
	param		stride		SizeI in value
	param		buffer		UInt32 in value
	param		offset		UInt32 in value
	category	ATI_vertex_attrib_array_object
	version		1.2
	extension
	glxropcode	?
	glxflags	ignore
	glsopcode	?
	offset		?

GetVertexAttribArrayObjectfvATI(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		ArrayObjectPNameATI in value
	param		params		Float32 out array [pname]
	category	ATI_vertex_attrib_array_object
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetVertexAttribArrayObjectivATI(index, pname, params)
	return		void
	param		index		UInt32 in value
	param		pname		ArrayObjectPNameATI in value
	param		params		Int32 out array [pname]
	category	ATI_vertex_attrib_array_object
	dlflags		notlistable
	version		1.2
	extension
	glxsingle	?
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #291 - OpenGL ES only, not in glext.h
# OES_byte_coordinates commands
#
###############################################################################

# void Vertex{234}bOES(T coords)
# void Vertex{234}bvOES(T *coords)
# void TexCoord{1234}bOES(T coords)
# void TexCoord{1234}bvOES(T *coords)
# void MultiTexCoord{1234}bOES(enum texture, T coords)
# void MultiTexCoord{1234}bvOES(enum texture, T *coords)
# All are handcode - mapped to non-byte GLX protocol on client side

# newcategory: OES_byte_coordinates

###############################################################################
#
# Extension #292 - OpenGL ES only, not in glext.h
# OES_fixed_point commands
#
###############################################################################

# Too many to list in just a comment - see spec in the extension registry
# All are handcode - mapped to non-byte GLX protocol on client side

# newcategory: OES_fixed_point

###############################################################################
#
# Extension #293 - OpenGL ES only, not in glext.h
# OES_single_precision commands
#
###############################################################################

# void DepthRangefOES(clampf n, clampf f)
# void FrustumfOES(float l, float r, float b, float t, float n, float f)
# void OrthofOES(float l, float r, float b, float t, float n, float f)
# void ClipPlanefOES(enum plane, const float* equation)
# void glClearDepthfOES(clampd depth)
# GLX ropcodes 4308-4312 (not respectively, see extension spec)
# void GetClipPlanefOES(enum plane, float* equation)
# GLX vendor private 1421

# newcategory: OES_single_precision

###############################################################################
#
# Extension #294 - OpenGL ES only, not in glext.h
# OES_compressed_paletted_texture commands
#
###############################################################################

# (none)
# newcategory: OES_compressed_paletted_texture

###############################################################################
#
# Extension #295 - This is an OpenGL ES extension, but also implemented in Mesa
# OES_read_format commands
#
###############################################################################

# (none)
newcategory: OES_read_format

###############################################################################
#
# Extension #296 - OpenGL ES only, not in glext.h
# OES_query_matrix commands
#
###############################################################################

# bitfield queryMatrixxOES(fixed mantissa[16], int exponent[16])
# All are handcode - mapped to non-byte GLX protocol on client side

# newcategory: OES_query_matrix

###############################################################################
#
# Extension #297
# EXT_depth_bounds_test commands
#
###############################################################################

DepthBoundsEXT(zmin, zmax)
	return		void
	param		zmin		ClampedFloat64 in value
	param		zmax		ClampedFloat64 in value
	category	EXT_depth_bounds_test
	version		1.2
	extension
	glxropcode	4229
	glsopcode	?
	offset		699

###############################################################################
#
# Extension #298
# EXT_texture_mirror_clamp commands
#
###############################################################################

# (none)
newcategory: EXT_texture_mirror_clamp

###############################################################################
#
# Extension #299
# EXT_blend_equation_separate commands
#
###############################################################################

BlendEquationSeparateEXT(modeRGB, modeAlpha)
	return		void
	param		modeRGB		BlendEquationModeEXT in value
	param		modeAlpha	BlendEquationModeEXT in value
	category	EXT_blend_equation_separate
	version		1.2
	extension
	glxropcode	4228
	alias		BlendEquationSeparate
	glsalias	BlendEquationSeparate

###############################################################################
#
# Extension #300
# MESA_pack_invert commands
#
###############################################################################

# (none)
newcategory: MESA_pack_invert

###############################################################################
#
# Extension #301
# MESA_ycbcr_texture commands
#
###############################################################################

# (none)
newcategory: MESA_ycbcr_texture

###############################################################################
#
# Extension #301
# MESA_ycbcr_texture commands
#
###############################################################################

# (none)
newcategory: MESA_ycbcr_texture

###############################################################################
#
# Extension #302
# EXT_pixel_buffer_object commands
#
###############################################################################

# (none)
newcategory: EXT_pixel_buffer_object

###############################################################################
#
# Extension #303
# NV_fragment_program_option commands
#
###############################################################################

# (none)
newcategory: NV_fragment_program_option

###############################################################################
#
# Extension #304
# NV_fragment_program2 commands
#
###############################################################################

# (none)
newcategory: NV_fragment_program2

###############################################################################
#
# Extension #305
# NV_vertex_program2_option commands
#
###############################################################################

# (none)
newcategory: NV_vertex_program2_option

###############################################################################
#
# Extension #306
# NV_vertex_program3 commands
#
###############################################################################

# (none)
newcategory: NV_vertex_program3

###############################################################################
#
# Extension #307 - GLX_SGIX_hyperpipe commands
# Extension #308 - GLX_MESA_agp_offset commands
# Extension #309 - GL_EXT_texture_compression_dxt1 (OpenGL ES only, subset of _st3c version)
#
###############################################################################

###############################################################################
#
# Extension #310
# EXT_framebuffer_object commands
#
###############################################################################

IsRenderbufferEXT(renderbuffer)
	return		Boolean
	param		renderbuffer	UInt32 in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxvendorpriv	1422
	glxflags	ignore
	glsopcode	?
	offset		?

BindRenderbufferEXT(target, renderbuffer)
	return		void
	param		target		GLenum in value
	param		renderbuffer	UInt32 in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxropcode	4316
	glxflags	ignore
	glsopcode	?
	offset		?

DeleteRenderbuffersEXT(n, renderbuffers)
	return		void
	param		n		SizeI in value
	param		renderbuffers	UInt32 in array [n]
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxropcode	4317
	glxflags	ignore
	glsopcode	?
	offset		?

GenRenderbuffersEXT(n, renderbuffers)
	return		void
	param		n		SizeI in value
	param		renderbuffers	UInt32 out array [n]
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxvendorpriv	1423
	glxflags	ignore
	glsopcode	?
	offset		?

RenderbufferStorageEXT(target, internalformat, width, height)
	return		void
	param		target		GLenum in value
	param		internalformat	GLenum in value
	param		width		SizeI in value
	param		height		SizeI in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxropcode	4318
	glxflags	ignore
	glsopcode	?
	offset		?

GetRenderbufferParameterivEXT(target, pname, params)
	return		void
	param		target		GLenum in value
	param		pname		GLenum in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	EXT_framebuffer_object
	dlflags		notlistable
	version		1.2
	extension
	glxvendorpriv	1424
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

IsFramebufferEXT(framebuffer)
	return		Boolean
	param		framebuffer	UInt32 in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxvendorpriv	1425
	glxflags	ignore
	glsopcode	?
	offset		?

BindFramebufferEXT(target, framebuffer)
	return		void
	param		target		GLenum in value
	param		framebuffer	UInt32 in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxropcode	4319
	glxflags	ignore
	glsopcode	?
	offset		?

DeleteFramebuffersEXT(n, framebuffers)
	return		void
	param		n		SizeI in value
	param		framebuffers	UInt32 in array [n]
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxropcode	4320
	glxflags	ignore
	glsopcode	?
	offset		?

GenFramebuffersEXT(n, framebuffers)
	return		void
	param		n		SizeI in value
	param		framebuffers	UInt32 out array [n]
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxvendorpriv	1426
	glxflags	ignore
	glsopcode	?
	offset		?

CheckFramebufferStatusEXT(target)
	return		GLenum
	param		target		GLenum in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxvendorpriv	1427
	glxflags	ignore
	glsopcode	?
	offset		?

FramebufferTexture1DEXT(target, attachment, textarget, texture, level)
	return		void
	param		target		GLenum in value
	param		attachment	GLenum in value
	param		textarget	GLenum in value
	param		texture		UInt32 in value
	param		level		Int32 in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxropcode	4321
	glxflags	ignore
	glsopcode	?
	offset		?

FramebufferTexture2DEXT(target, attachment, textarget, texture, level)
	return		void
	param		target		GLenum in value
	param		attachment	GLenum in value
	param		textarget	GLenum in value
	param		texture		UInt32 in value
	param		level		Int32 in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxropcode	4322
	glxflags	ignore
	glsopcode	?
	offset		?

FramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset)
	return		void
	param		target		GLenum in value
	param		attachment	GLenum in value
	param		textarget	GLenum in value
	param		texture		UInt32 in value
	param		level		Int32 in value
	param		zoffset		Int32 in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxropcode	4323
	glxflags	ignore
	glsopcode	?
	offset		?

FramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer)
	return		void
	param		target		GLenum in value
	param		attachment	GLenum in value
	param		renderbuffertarget	GLenum in value
	param		renderbuffer	UInt32 in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxropcode	4324
	glxflags	ignore
	glsopcode	?
	offset		?

GetFramebufferAttachmentParameterivEXT(target, attachment, pname, params)
	return		void
	param		target		GLenum in value
	param		attachment	GLenum in value
	param		pname		GLenum in value
	param		params		Int32 out array [COMPSIZE(pname)]
	category	EXT_framebuffer_object
	dlflags		notlistable
	version		1.2
	extension
	glxvendorpriv	1428
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GenerateMipmapEXT(target)
	return		void
	param		target		GLenum in value
	category	EXT_framebuffer_object
	version		1.2
	extension
	glxropcode	4325
	glxflags	ignore
	glsopcode	?
	offset		?


###############################################################################
#
# Extension #311
# GREMEDY_string_marker commands
#
###############################################################################

StringMarkerGREMEDY(len, string)
	return		void
	param		len		SizeI in value
	param		string		Void in array [len]
	category	GREMEDY_string_marker
	version		1.0
	extension
	glsflags	ignore
	glxflags	ignore
	offset		?

###############################################################################
#
# Extension #312
# EXT_packed_depth_stencil commands
#
###############################################################################

# (none)
newcategory: EXT_packed_depth_stencil

###############################################################################
#
# Extension #313 - WGL_3DL_stereo_control
#
###############################################################################

###############################################################################
#
# Extension #314
# EXT_stencil_clear_tag commands
#
###############################################################################

StencilClearTagEXT(stencilTagBits, stencilClearTag)
	return		void
	param		stencilTagBits	SizeI in value
	param		stencilClearTag UInt32 in value
	category	EXT_stencil_clear_tag
	version		1.5
	extension
	glxropcode	4223
	glxflags	ignore
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #315
# EXT_texture_sRGB commands
#
###############################################################################

# (none)
newcategory: EXT_texture_sRGB

###############################################################################
#
# Extension #316
# EXT_framebuffer_blit commands
#
###############################################################################

BlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter)
	return		void
	param		srcX0		Int32 in value
	param		srcY0		Int32 in value
	param		srcX1		Int32 in value
	param		srcY1		Int32 in value
	param		dstX0		Int32 in value
	param		dstY0		Int32 in value
	param		dstX1		Int32 in value
	param		dstY1		Int32 in value
	param		mask		ClearBufferMask in value
	param		filter		GLenum in value
	category	EXT_framebuffer_blit
	version		1.5
	glxropcode	4330
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #317
# EXT_framebuffer_multisample commands
#
###############################################################################

RenderbufferStorageMultisampleEXT(target, samples, internalformat, width, height)
	return		void
	param		target		GLenum in value
	param		samples		SizeI in value
	param		internalformat	GLenum in value
	param		width		SizeI in value
	param		height		SizeI in value
	category	EXT_framebuffer_multisample
	version		1.5
	glxropcode	4331
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #318
# MESAX_texture_stack commands
#
###############################################################################

# (none)
newcategory: MESAX_texture_stack

###############################################################################
#
# Extension #319
# EXT_timer_query commands
#
###############################################################################

GetQueryObjecti64vEXT(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		GLenum in value
	param		params		Int64EXT out array [pname]
	category	EXT_timer_query
	dlflags		notlistable
	version		1.5
	glxvendorpriv	1328
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

GetQueryObjectui64vEXT(id, pname, params)
	return		void
	param		id		UInt32 in value
	param		pname		GLenum in value
	param		params		UInt64EXT out array [pname]
	category	EXT_timer_query
	dlflags		notlistable
	version		1.5
	glxvendorpriv	1329
	glxflags	ignore
	glsflags	get
	glsopcode	?
	offset		?

###############################################################################
#
# Extension #320
# EXT_gpu_program_parameters commands
#
###############################################################################

ProgramEnvParameters4fvEXT(target, index, count, params)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		count		SizeI in value
	param		params		Float32 in array [count*4]
	category	EXT_gpu_program_parameters
	version		1.2
	glxropcode	4281
	glsopcode	?
	offset		?

ProgramLocalParameters4fvEXT(target, index, count, params)
	return		void
	param		target		ProgramTargetARB in value
	param		index		UInt32 in value
	param		count		SizeI in value
	param		params		Float32 in array [count*4]
	category	EXT_gpu_program_parameters
	version		1.2
	glxropcode	4282
	glsopcode	?
	offset		?
