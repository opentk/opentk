# List of GL enumerants for glext.h header
#
# This is NOT the master GL enumerant registry (enum.spec).
#
# Unlike enum.spec, enumext.spec is
#   (1) In order by extension number
#   (2) Includes only extensions and 1.2/1.3 core enumerants, since
#	it's assumed all <gl.h> today support at least OpenGL 1.1
#   (3) Has no 'Extensions' section, since enums are always
#	conditionally protected against multiple definition
#	by glextenum.pl.
#   (4) Is processed by glextenum.pl, which has evolved
#	from enum.pl - should merge back into one script.

# glext.h version number - this should be automatically updated,
#   when changing either enum or template spec files.

# Edited by StApostol: Revision 1

passthru:
passthru: /* Header file version number, required by OpenGL ABI for Linux */
passthru: /* glext.h last updated 2007/02/12 */
passthru: /* Current version at http://www.opengl.org/registry/ */
passthru: #define GL_GLEXT_VERSION 39

###############################################################################
#
# OpenGL 1.2 enums
#
###############################################################################

VERSION_1_2 enum:
	UNSIGNED_BYTE_3_3_2				= 0x8032 # Equivalent to EXT_packed_pixels
	UNSIGNED_SHORT_4_4_4_4				= 0x8033
	UNSIGNED_SHORT_5_5_5_1				= 0x8034
	UNSIGNED_INT_8_8_8_8				= 0x8035
	UNSIGNED_INT_10_10_10_2				= 0x8036
	RESCALE_NORMAL					= 0x803A # 1 I # Equivalent to EXT_rescale_normal
	TEXTURE_BINDING_3D				= 0x806A # 1 I
	PACK_SKIP_IMAGES				= 0x806B # 1 I
	PACK_IMAGE_HEIGHT				= 0x806C # 1 F
	UNPACK_SKIP_IMAGES				= 0x806D # 1 I
	UNPACK_IMAGE_HEIGHT				= 0x806E # 1 F
	TEXTURE_3D					= 0x806F # 1 I
	PROXY_TEXTURE_3D				= 0x8070
	TEXTURE_DEPTH					= 0x8071
	TEXTURE_WRAP_R					= 0x8072
	MAX_3D_TEXTURE_SIZE				= 0x8073 # 1 I
	UNSIGNED_BYTE_2_3_3_REV				= 0x8362 # New for OpenGL 1.2
	UNSIGNED_SHORT_5_6_5				= 0x8363
	UNSIGNED_SHORT_5_6_5_REV			= 0x8364
	UNSIGNED_SHORT_4_4_4_4_REV			= 0x8365
	UNSIGNED_SHORT_1_5_5_5_REV			= 0x8366
	UNSIGNED_INT_8_8_8_8_REV			= 0x8367
	UNSIGNED_INT_2_10_10_10_REV			= 0x8368
	BGR						= 0x80E0
	BGRA						= 0x80E1
	MAX_ELEMENTS_VERTICES				= 0x80E8
	MAX_ELEMENTS_INDICES				= 0x80E9
	CLAMP_TO_EDGE					= 0x812F # Equivalent to SGIS_texture_edge_clamp
	TEXTURE_MIN_LOD					= 0x813A # Equivalent to SGIS_texture_lod
	TEXTURE_MAX_LOD					= 0x813B
	TEXTURE_BASE_LEVEL				= 0x813C
	TEXTURE_MAX_LEVEL				= 0x813D
	LIGHT_MODEL_COLOR_CONTROL			= 0x81F8 # 1 I
	SINGLE_COLOR					= 0x81F9
	SEPARATE_SPECULAR_COLOR				= 0x81FA
	SMOOTH_POINT_SIZE_RANGE				= 0x0B12 # 2 F
	SMOOTH_POINT_SIZE_GRANULARITY			= 0x0B13 # 1 F
	SMOOTH_LINE_WIDTH_RANGE				= 0x0B22 # 2 F
	SMOOTH_LINE_WIDTH_GRANULARITY			= 0x0B23 # 1 F
	ALIASED_POINT_SIZE_RANGE			= 0x846D # 2 F
	ALIASED_LINE_WIDTH_RANGE			= 0x846E # 2 F

ARB_imaging enum:
	CONSTANT_COLOR					= 0x8001 # Equivalent to EXT_blend_color
	ONE_MINUS_CONSTANT_COLOR			= 0x8002
	CONSTANT_ALPHA					= 0x8003
	ONE_MINUS_CONSTANT_ALPHA			= 0x8004
	BLEND_COLOR					= 0x8005 # 4 F
	FUNC_ADD					= 0x8006 # Equivalent to EXT_blend_minmax
	MIN						= 0x8007
	MAX						= 0x8008
	BLEND_EQUATION					= 0x8009 # 1 I
	FUNC_SUBTRACT					= 0x800A # Equivalent to EXT_blend_subtract
	FUNC_REVERSE_SUBTRACT				= 0x800B
	CONVOLUTION_1D					= 0x8010 # 1 I # Equivalent to EXT_convolution
	CONVOLUTION_2D					= 0x8011 # 1 I
	SEPARABLE_2D					= 0x8012 # 1 I
	CONVOLUTION_BORDER_MODE				= 0x8013
	CONVOLUTION_FILTER_SCALE			= 0x8014
	CONVOLUTION_FILTER_BIAS				= 0x8015
	REDUCE						= 0x8016
	CONVOLUTION_FORMAT				= 0x8017
	CONVOLUTION_WIDTH				= 0x8018
	CONVOLUTION_HEIGHT				= 0x8019
	MAX_CONVOLUTION_WIDTH				= 0x801A
	MAX_CONVOLUTION_HEIGHT				= 0x801B
	POST_CONVOLUTION_RED_SCALE			= 0x801C # 1 F
	POST_CONVOLUTION_GREEN_SCALE			= 0x801D # 1 F
	POST_CONVOLUTION_BLUE_SCALE			= 0x801E # 1 F
	POST_CONVOLUTION_ALPHA_SCALE			= 0x801F # 1 F
	POST_CONVOLUTION_RED_BIAS			= 0x8020 # 1 F
	POST_CONVOLUTION_GREEN_BIAS			= 0x8021 # 1 F
	POST_CONVOLUTION_BLUE_BIAS			= 0x8022 # 1 F
	POST_CONVOLUTION_ALPHA_BIAS			= 0x8023 # 1 F
	HISTOGRAM					= 0x8024 # 1 I # Equivalent to EXT_histogram
	PROXY_HISTOGRAM					= 0x8025
	HISTOGRAM_WIDTH					= 0x8026
	HISTOGRAM_FORMAT				= 0x8027
	HISTOGRAM_RED_SIZE				= 0x8028
	HISTOGRAM_GREEN_SIZE				= 0x8029
	HISTOGRAM_BLUE_SIZE				= 0x802A
	HISTOGRAM_ALPHA_SIZE				= 0x802B
	HISTOGRAM_LUMINANCE_SIZE			= 0x802C
	HISTOGRAM_SINK					= 0x802D
	MINMAX						= 0x802E # 1 I
	MINMAX_FORMAT					= 0x802F
	MINMAX_SINK					= 0x8030
	TABLE_TOO_LARGE					= 0x8031
	COLOR_MATRIX					= 0x80B1 # 16 F # Equivalent to SGI_color_matrix
	COLOR_MATRIX_STACK_DEPTH			= 0x80B2 # 1 I
	MAX_COLOR_MATRIX_STACK_DEPTH			= 0x80B3 # 1 I
	POST_COLOR_MATRIX_RED_SCALE			= 0x80B4 # 1 F
	POST_COLOR_MATRIX_GREEN_SCALE			= 0x80B5 # 1 F
	POST_COLOR_MATRIX_BLUE_SCALE			= 0x80B6 # 1 F
	POST_COLOR_MATRIX_ALPHA_SCALE			= 0x80B7 # 1 F
	POST_COLOR_MATRIX_RED_BIAS			= 0x80B8 # 1 F
	POST_COLOR_MATRIX_GREEN_BIAS			= 0x80B9 # 1 F
	POST_COLOR_MATRIX_BLUE_BIAS			= 0x80BA # 1 F
	POST_COLOR_MATRIX_ALPHA_BIAS			= 0x80BB # 1 F
	COLOR_TABLE					= 0x80D0 # 1 I # Equivalent to SGI_color_table
	POST_CONVOLUTION_COLOR_TABLE			= 0x80D1 # 1 I
	POST_COLOR_MATRIX_COLOR_TABLE			= 0x80D2 # 1 I
	PROXY_COLOR_TABLE				= 0x80D3
	PROXY_POST_CONVOLUTION_COLOR_TABLE		= 0x80D4
	PROXY_POST_COLOR_MATRIX_COLOR_TABLE		= 0x80D5
	COLOR_TABLE_SCALE				= 0x80D6
	COLOR_TABLE_BIAS				= 0x80D7
	COLOR_TABLE_FORMAT				= 0x80D8
	COLOR_TABLE_WIDTH				= 0x80D9
	COLOR_TABLE_RED_SIZE				= 0x80DA
	COLOR_TABLE_GREEN_SIZE				= 0x80DB
	COLOR_TABLE_BLUE_SIZE				= 0x80DC
	COLOR_TABLE_ALPHA_SIZE				= 0x80DD
	COLOR_TABLE_LUMINANCE_SIZE			= 0x80DE
	COLOR_TABLE_INTENSITY_SIZE			= 0x80DF
	CONSTANT_BORDER					= 0x8151
	REPLICATE_BORDER				= 0x8153
	CONVOLUTION_BORDER_COLOR			= 0x8154


###############################################################################
#
# OpenGL 1.3 enums
#
###############################################################################

VERSION_1_3 enum:
	TEXTURE0					= 0x84C0	# Promoted from ARB_multitexture
	TEXTURE1					= 0x84C1
	TEXTURE2					= 0x84C2
	TEXTURE3					= 0x84C3
	TEXTURE4					= 0x84C4
	TEXTURE5					= 0x84C5
	TEXTURE6					= 0x84C6
	TEXTURE7					= 0x84C7
	TEXTURE8					= 0x84C8
	TEXTURE9					= 0x84C9
	TEXTURE10					= 0x84CA
	TEXTURE11					= 0x84CB
	TEXTURE12					= 0x84CC
	TEXTURE13					= 0x84CD
	TEXTURE14					= 0x84CE
	TEXTURE15					= 0x84CF
	TEXTURE16					= 0x84D0
	TEXTURE17					= 0x84D1
	TEXTURE18					= 0x84D2
	TEXTURE19					= 0x84D3
	TEXTURE20					= 0x84D4
	TEXTURE21					= 0x84D5
	TEXTURE22					= 0x84D6
	TEXTURE23					= 0x84D7
	TEXTURE24					= 0x84D8
	TEXTURE25					= 0x84D9
	TEXTURE26					= 0x84DA
	TEXTURE27					= 0x84DB
	TEXTURE28					= 0x84DC
	TEXTURE29					= 0x84DD
	TEXTURE30					= 0x84DE
	TEXTURE31					= 0x84DF
	ACTIVE_TEXTURE					= 0x84E0 # 1 I
	CLIENT_ACTIVE_TEXTURE				= 0x84E1 # 1 I
	MAX_TEXTURE_UNITS				= 0x84E2 # 1 I
	TRANSPOSE_MODELVIEW_MATRIX			= 0x84E3 # 16 F # Promoted from ARB_transpose_matrix
	TRANSPOSE_PROJECTION_MATRIX			= 0x84E4 # 16 F
	TRANSPOSE_TEXTURE_MATRIX			= 0x84E5 # 16 F
	TRANSPOSE_COLOR_MATRIX				= 0x84E6 # 16 F
	MULTISAMPLE					= 0x809D	# Promoted from ARB_multisample
	SAMPLE_ALPHA_TO_COVERAGE			= 0x809E
	SAMPLE_ALPHA_TO_ONE				= 0x809F
	SAMPLE_COVERAGE					= 0x80A0
	SAMPLE_BUFFERS					= 0x80A8
	SAMPLES						= 0x80A9
	SAMPLE_COVERAGE_VALUE				= 0x80AA
	SAMPLE_COVERAGE_INVERT				= 0x80AB
	MULTISAMPLE_BIT					= 0x20000000
	NORMAL_MAP					= 0x8511	# Promoted from ARB_texture_cube_map
	REFLECTION_MAP					= 0x8512
	TEXTURE_CUBE_MAP				= 0x8513
	TEXTURE_BINDING_CUBE_MAP			= 0x8514
	TEXTURE_CUBE_MAP_POSITIVE_X			= 0x8515
	TEXTURE_CUBE_MAP_NEGATIVE_X			= 0x8516
	TEXTURE_CUBE_MAP_POSITIVE_Y			= 0x8517
	TEXTURE_CUBE_MAP_NEGATIVE_Y			= 0x8518
	TEXTURE_CUBE_MAP_POSITIVE_Z			= 0x8519
	TEXTURE_CUBE_MAP_NEGATIVE_Z			= 0x851A
	PROXY_TEXTURE_CUBE_MAP				= 0x851B
	MAX_CUBE_MAP_TEXTURE_SIZE			= 0x851C
	COMPRESSED_ALPHA				= 0x84E9	# Promoted from ARB_texture_compression
	COMPRESSED_LUMINANCE				= 0x84EA
	COMPRESSED_LUMINANCE_ALPHA			= 0x84EB
	COMPRESSED_INTENSITY				= 0x84EC
	COMPRESSED_RGB					= 0x84ED
	COMPRESSED_RGBA					= 0x84EE
	TEXTURE_COMPRESSION_HINT			= 0x84EF
	TEXTURE_COMPRESSED_IMAGE_SIZE			= 0x86A0
	TEXTURE_COMPRESSED				= 0x86A1
	NUM_COMPRESSED_TEXTURE_FORMATS			= 0x86A2
	COMPRESSED_TEXTURE_FORMATS			= 0x86A3
	CLAMP_TO_BORDER					= 0x812D	# Promoted from ARB_texture_border_clamp
	COMBINE						= 0x8570	# Promoted from ARB_texture_env_combine
	COMBINE_RGB					= 0x8571
	COMBINE_ALPHA					= 0x8572
	SOURCE0_RGB					= 0x8580
	SOURCE1_RGB					= 0x8581
	SOURCE2_RGB					= 0x8582
	SOURCE0_ALPHA					= 0x8588
	SOURCE1_ALPHA					= 0x8589
	SOURCE2_ALPHA					= 0x858A
	OPERAND0_RGB					= 0x8590
	OPERAND1_RGB					= 0x8591
	OPERAND2_RGB					= 0x8592
	OPERAND0_ALPHA					= 0x8598
	OPERAND1_ALPHA					= 0x8599
	OPERAND2_ALPHA					= 0x859A
	RGB_SCALE					= 0x8573
	ADD_SIGNED					= 0x8574
	INTERPOLATE					= 0x8575
	SUBTRACT					= 0x84E7
	CONSTANT					= 0x8576
	PRIMARY_COLOR					= 0x8577
	PREVIOUS					= 0x8578
	DOT3_RGB					= 0x86AE	# Promoted from ARB_texture_env_dot3
	DOT3_RGBA					= 0x86AF


###############################################################################
#
# OpenGL 1.4 enums
#
###############################################################################

VERSION_1_4 enum:
	BLEND_DST_RGB					= 0x80C8
	BLEND_SRC_RGB					= 0x80C9
	BLEND_DST_ALPHA					= 0x80CA
	BLEND_SRC_ALPHA					= 0x80CB
	POINT_SIZE_MIN					= 0x8126 # 1 F
	POINT_SIZE_MAX					= 0x8127 # 1 F
	POINT_FADE_THRESHOLD_SIZE			= 0x8128 # 1 F
	POINT_DISTANCE_ATTENUATION			= 0x8129 # 3 F
	GENERATE_MIPMAP					= 0x8191
	GENERATE_MIPMAP_HINT				= 0x8192 # 1 I
	DEPTH_COMPONENT16				= 0x81A5
	DEPTH_COMPONENT24				= 0x81A6
	DEPTH_COMPONENT32				= 0x81A7
	MIRRORED_REPEAT					= 0x8370
	FOG_COORDINATE_SOURCE				= 0x8450 # 1 I
	FOG_COORDINATE					= 0x8451
	FRAGMENT_DEPTH					= 0x8452
	CURRENT_FOG_COORDINATE				= 0x8453 # 1 F
	FOG_COORDINATE_ARRAY_TYPE			= 0x8454 # 1 I
	FOG_COORDINATE_ARRAY_STRIDE			= 0x8455 # 1 I
	FOG_COORDINATE_ARRAY_POINTER			= 0x8456
	FOG_COORDINATE_ARRAY				= 0x8457 # 1 I
	COLOR_SUM					= 0x8458 # 1 I
	CURRENT_SECONDARY_COLOR				= 0x8459 # 3 F
	SECONDARY_COLOR_ARRAY_SIZE			= 0x845A # 1 I
	SECONDARY_COLOR_ARRAY_TYPE			= 0x845B # 1 I
	SECONDARY_COLOR_ARRAY_STRIDE			= 0x845C # 1 I
	SECONDARY_COLOR_ARRAY_POINTER			= 0x845D
	SECONDARY_COLOR_ARRAY				= 0x845E # 1 I
	MAX_TEXTURE_LOD_BIAS				= 0x84FD
	TEXTURE_FILTER_CONTROL				= 0x8500
	TEXTURE_LOD_BIAS				= 0x8501
	INCR_WRAP					= 0x8507
	DECR_WRAP					= 0x8508
	TEXTURE_DEPTH_SIZE				= 0x884A
	DEPTH_TEXTURE_MODE				= 0x884B
	TEXTURE_COMPARE_MODE				= 0x884C
	TEXTURE_COMPARE_FUNC				= 0x884D
	COMPARE_R_TO_TEXTURE				= 0x884E


###############################################################################
#
# OpenGL 1.5 enums
#
###############################################################################

VERSION_1_5 enum:
	BUFFER_SIZE					= 0x8764 # ARB_vertex_buffer_object
	BUFFER_USAGE					= 0x8765 # ARB_vertex_buffer_object
	QUERY_COUNTER_BITS				= 0x8864 # ARB_occlusion_query
	CURRENT_QUERY					= 0x8865 # ARB_occlusion_query
	QUERY_RESULT					= 0x8866 # ARB_occlusion_query
	QUERY_RESULT_AVAILABLE				= 0x8867 # ARB_occlusion_query
	ARRAY_BUFFER					= 0x8892 # ARB_vertex_buffer_object
	ELEMENT_ARRAY_BUFFER				= 0x8893 # ARB_vertex_buffer_object
	ARRAY_BUFFER_BINDING				= 0x8894 # ARB_vertex_buffer_object
	ELEMENT_ARRAY_BUFFER_BINDING			= 0x8895 # ARB_vertex_buffer_object
	VERTEX_ARRAY_BUFFER_BINDING			= 0x8896 # ARB_vertex_buffer_object
	NORMAL_ARRAY_BUFFER_BINDING			= 0x8897 # ARB_vertex_buffer_object
	COLOR_ARRAY_BUFFER_BINDING			= 0x8898 # ARB_vertex_buffer_object
	INDEX_ARRAY_BUFFER_BINDING			= 0x8899 # ARB_vertex_buffer_object
	TEXTURE_COORD_ARRAY_BUFFER_BINDING		= 0x889A # ARB_vertex_buffer_object
	EDGE_FLAG_ARRAY_BUFFER_BINDING			= 0x889B # ARB_vertex_buffer_object
	SECONDARY_COLOR_ARRAY_BUFFER_BINDING		= 0x889C # ARB_vertex_buffer_object
	FOG_COORDINATE_ARRAY_BUFFER_BINDING		= 0x889D # ARB_vertex_buffer_object
	WEIGHT_ARRAY_BUFFER_BINDING			= 0x889E # ARB_vertex_buffer_object
	VERTEX_ATTRIB_ARRAY_BUFFER_BINDING		= 0x889F # ARB_vertex_buffer_object
	READ_ONLY					= 0x88B8 # ARB_vertex_buffer_object
	WRITE_ONLY					= 0x88B9 # ARB_vertex_buffer_object
	READ_WRITE					= 0x88BA # ARB_vertex_buffer_object
	BUFFER_ACCESS					= 0x88BB # ARB_vertex_buffer_object
	BUFFER_MAPPED					= 0x88BC # ARB_vertex_buffer_object
	BUFFER_MAP_POINTER				= 0x88BD # ARB_vertex_buffer_object
	STREAM_DRAW					= 0x88E0 # ARB_vertex_buffer_object
	STREAM_READ					= 0x88E1 # ARB_vertex_buffer_object
	STREAM_COPY					= 0x88E2 # ARB_vertex_buffer_object
	STATIC_DRAW					= 0x88E4 # ARB_vertex_buffer_object
	STATIC_READ					= 0x88E5 # ARB_vertex_buffer_object
	STATIC_COPY					= 0x88E6 # ARB_vertex_buffer_object
	DYNAMIC_DRAW					= 0x88E8 # ARB_vertex_buffer_object
	DYNAMIC_READ					= 0x88E9 # ARB_vertex_buffer_object
	DYNAMIC_COPY					= 0x88EA # ARB_vertex_buffer_object
	SAMPLES_PASSED					= 0x8914 # ARB_occlusion_query
# New naming scheme
	FOG_COORD_SRC					= GL_FOG_COORDINATE_SOURCE
	FOG_COORD					= GL_FOG_COORDINATE
	CURRENT_FOG_COORD				= GL_CURRENT_FOG_COORDINATE
	FOG_COORD_ARRAY_TYPE				= GL_FOG_COORDINATE_ARRAY_TYPE
	FOG_COORD_ARRAY_STRIDE				= GL_FOG_COORDINATE_ARRAY_STRIDE
	FOG_COORD_ARRAY_POINTER				= GL_FOG_COORDINATE_ARRAY_POINTER
	FOG_COORD_ARRAY					= GL_FOG_COORDINATE_ARRAY
	FOG_COORD_ARRAY_BUFFER_BINDING			= GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING
	SRC0_RGB					= GL_SOURCE0_RGB
	SRC1_RGB					= GL_SOURCE1_RGB
	SRC2_RGB					= GL_SOURCE2_RGB
	SRC0_ALPHA					= GL_SOURCE0_ALPHA
	SRC1_ALPHA					= GL_SOURCE1_ALPHA
	SRC2_ALPHA					= GL_SOURCE2_ALPHA


###############################################################################
#
# OpenGL 2.0 enums
#
###############################################################################

VERSION_2_0 enum:
	BLEND_EQUATION_RGB				= GL_BLEND_EQUATION # EXT_blend_equation_separate
	VERTEX_ATTRIB_ARRAY_ENABLED			= 0x8622    # ARB_vertex_shader
	VERTEX_ATTRIB_ARRAY_SIZE			= 0x8623    # ARB_vertex_shader
	VERTEX_ATTRIB_ARRAY_STRIDE			= 0x8624    # ARB_vertex_shader
	VERTEX_ATTRIB_ARRAY_TYPE			= 0x8625    # ARB_vertex_shader
	CURRENT_VERTEX_ATTRIB				= 0x8626    # ARB_vertex_shader
	VERTEX_PROGRAM_POINT_SIZE			= 0x8642    # ARB_vertex_shader
	VERTEX_PROGRAM_TWO_SIDE				= 0x8643    # ARB_vertex_shader
	VERTEX_ATTRIB_ARRAY_POINTER			= 0x8645    # ARB_vertex_shader
	STENCIL_BACK_FUNC				= 0x8800    # ARB_stencil_two_side
	STENCIL_BACK_FAIL				= 0x8801    # ARB_stencil_two_side
	STENCIL_BACK_PASS_DEPTH_FAIL			= 0x8802    # ARB_stencil_two_side
	STENCIL_BACK_PASS_DEPTH_PASS			= 0x8803    # ARB_stencil_two_side
	MAX_DRAW_BUFFERS				= 0x8824    # ARB_draw_buffers
	DRAW_BUFFER0					= 0x8825    # ARB_draw_buffers
	DRAW_BUFFER1					= 0x8826    # ARB_draw_buffers
	DRAW_BUFFER2					= 0x8827    # ARB_draw_buffers
	DRAW_BUFFER3					= 0x8828    # ARB_draw_buffers
	DRAW_BUFFER4					= 0x8829    # ARB_draw_buffers
	DRAW_BUFFER5					= 0x882A    # ARB_draw_buffers
	DRAW_BUFFER6					= 0x882B    # ARB_draw_buffers
	DRAW_BUFFER7					= 0x882C    # ARB_draw_buffers
	DRAW_BUFFER8					= 0x882D    # ARB_draw_buffers
	DRAW_BUFFER9					= 0x882E    # ARB_draw_buffers
	DRAW_BUFFER10					= 0x882F    # ARB_draw_buffers
	DRAW_BUFFER11					= 0x8830    # ARB_draw_buffers
	DRAW_BUFFER12					= 0x8831    # ARB_draw_buffers
	DRAW_BUFFER13					= 0x8832    # ARB_draw_buffers
	DRAW_BUFFER14					= 0x8833    # ARB_draw_buffers
	DRAW_BUFFER15					= 0x8834    # ARB_draw_buffers
	BLEND_EQUATION_ALPHA				= 0x883D    # EXT_blend_equation_separate
	POINT_SPRITE					= 0x8861    # ARB_point_sprite
	COORD_REPLACE					= 0x8862    # ARB_point_sprite
	MAX_VERTEX_ATTRIBS				= 0x8869    # ARB_vertex_shader
	VERTEX_ATTRIB_ARRAY_NORMALIZED			= 0x886A    # ARB_vertex_shader
	MAX_TEXTURE_COORDS				= 0x8871    # ARB_vertex_shader, ARB_fragment_shader
	MAX_TEXTURE_IMAGE_UNITS				= 0x8872    # ARB_vertex_shader, ARB_fragment_shader
	FRAGMENT_SHADER					= 0x8B30    # ARB_fragment_shader
	VERTEX_SHADER					= 0x8B31    # ARB_vertex_shader
	MAX_FRAGMENT_UNIFORM_COMPONENTS			= 0x8B49    # ARB_fragment_shader
	MAX_VERTEX_UNIFORM_COMPONENTS			= 0x8B4A    # ARB_vertex_shader
	MAX_VARYING_FLOATS				= 0x8B4B    # ARB_vertex_shader
	MAX_VERTEX_TEXTURE_IMAGE_UNITS			= 0x8B4C    # ARB_vertex_shader
	MAX_COMBINED_TEXTURE_IMAGE_UNITS		= 0x8B4D    # ARB_vertex_shader
	SHADER_TYPE					= 0x8B4F    # ARB_shader_objects
	FLOAT_VEC2					= 0x8B50    # ARB_shader_objects
	FLOAT_VEC3					= 0x8B51    # ARB_shader_objects
	FLOAT_VEC4					= 0x8B52    # ARB_shader_objects
	INT_VEC2					= 0x8B53    # ARB_shader_objects
	INT_VEC3					= 0x8B54    # ARB_shader_objects
	INT_VEC4					= 0x8B55    # ARB_shader_objects
	BOOL						= 0x8B56    # ARB_shader_objects
	BOOL_VEC2					= 0x8B57    # ARB_shader_objects
	BOOL_VEC3					= 0x8B58    # ARB_shader_objects
	BOOL_VEC4					= 0x8B59    # ARB_shader_objects
	FLOAT_MAT2					= 0x8B5A    # ARB_shader_objects
	FLOAT_MAT3					= 0x8B5B    # ARB_shader_objects
	FLOAT_MAT4					= 0x8B5C    # ARB_shader_objects
	SAMPLER_1D					= 0x8B5D    # ARB_shader_objects
	SAMPLER_2D					= 0x8B5E    # ARB_shader_objects
	SAMPLER_3D					= 0x8B5F    # ARB_shader_objects
	SAMPLER_CUBE					= 0x8B60    # ARB_shader_objects
	SAMPLER_1D_SHADOW				= 0x8B61    # ARB_shader_objects
	SAMPLER_2D_SHADOW				= 0x8B62    # ARB_shader_objects
	DELETE_STATUS					= 0x8B80    # ARB_shader_objects
	COMPILE_STATUS					= 0x8B81    # ARB_shader_objects
	LINK_STATUS					= 0x8B82    # ARB_shader_objects
	VALIDATE_STATUS					= 0x8B83    # ARB_shader_objects
	INFO_LOG_LENGTH					= 0x8B84    # ARB_shader_objects
	ATTACHED_SHADERS				= 0x8B85    # ARB_shader_objects
	ACTIVE_UNIFORMS					= 0x8B86    # ARB_shader_objects
	ACTIVE_UNIFORM_MAX_LENGTH			= 0x8B87    # ARB_shader_objects
	SHADER_SOURCE_LENGTH				= 0x8B88    # ARB_shader_objects
	ACTIVE_ATTRIBUTES				= 0x8B89    # ARB_vertex_shader
	ACTIVE_ATTRIBUTE_MAX_LENGTH			= 0x8B8A    # ARB_vertex_shader
	FRAGMENT_SHADER_DERIVATIVE_HINT			= 0x8B8B    # ARB_fragment_shader
	SHADING_LANGUAGE_VERSION			= 0x8B8C    # ARB_shading_language_100
	CURRENT_PROGRAM					= 0x8B8D    # ARB_shader_objects (added for 2.0)
	POINT_SPRITE_COORD_ORIGIN			= 0x8CA0    # ARB_point_sprite (added for 2.0)
	LOWER_LEFT					= 0x8CA1    # ARB_point_sprite (added for 2.0)
	UPPER_LEFT					= 0x8CA2    # ARB_point_sprite (added for 2.0)
	STENCIL_BACK_REF				= 0x8CA3    # ARB_stencil_two_side
	STENCIL_BACK_VALUE_MASK				= 0x8CA4    # ARB_stencil_two_side
	STENCIL_BACK_WRITEMASK				= 0x8CA5    # ARB_stencil_two_side

###############################################################################
#
# OpenGL 2.1 enums
#
###############################################################################

VERSION_2_1 enum:
	CURRENT_RASTER_SECONDARY_COLOR			= 0x845F    # New for 2.1
	PIXEL_PACK_BUFFER				= 0x88EB    # ARB_pixel_buffer_object
	PIXEL_UNPACK_BUFFER				= 0x88EC    # ARB_pixel_buffer_object
	PIXEL_PACK_BUFFER_BINDING			= 0x88ED    # ARB_pixel_buffer_object
	PIXEL_UNPACK_BUFFER_BINDING			= 0x88EF    # ARB_pixel_buffer_object
	FLOAT_MAT2x3					= 0x8B65    # New for 2.1
	FLOAT_MAT2x4					= 0x8B66    # New for 2.1
	FLOAT_MAT3x2					= 0x8B67    # New for 2.1
	FLOAT_MAT3x4					= 0x8B68    # New for 2.1
	FLOAT_MAT4x2					= 0x8B69    # New for 2.1
	FLOAT_MAT4x3					= 0x8B6A    # New for 2.1
	SRGB						= 0x8C40    # EXT_texture_sRGB
	SRGB8						= 0x8C41    # EXT_texture_sRGB
	SRGB_ALPHA					= 0x8C42    # EXT_texture_sRGB
	SRGB8_ALPHA8					= 0x8C43    # EXT_texture_sRGB
	SLUMINANCE_ALPHA				= 0x8C44    # EXT_texture_sRGB
	SLUMINANCE8_ALPHA8				= 0x8C45    # EXT_texture_sRGB
	SLUMINANCE					= 0x8C46    # EXT_texture_sRGB
	SLUMINANCE8					= 0x8C47    # EXT_texture_sRGB
	COMPRESSED_SRGB					= 0x8C48    # EXT_texture_sRGB
	COMPRESSED_SRGB_ALPHA				= 0x8C49    # EXT_texture_sRGB
	COMPRESSED_SLUMINANCE				= 0x8C4A    # EXT_texture_sRGB
	COMPRESSED_SLUMINANCE_ALPHA			= 0x8C4B    # EXT_texture_sRGB


###############################################################################
#
# ARB extensions, in ARB extension order
#
###############################################################################

###############################################################################

# ARB Extension #1
ARB_multitexture enum:
	TEXTURE0_ARB					= 0x84C0
	TEXTURE1_ARB					= 0x84C1
	TEXTURE2_ARB					= 0x84C2
	TEXTURE3_ARB					= 0x84C3
	TEXTURE4_ARB					= 0x84C4
	TEXTURE5_ARB					= 0x84C5
	TEXTURE6_ARB					= 0x84C6
	TEXTURE7_ARB					= 0x84C7
	TEXTURE8_ARB					= 0x84C8
	TEXTURE9_ARB					= 0x84C9
	TEXTURE10_ARB					= 0x84CA
	TEXTURE11_ARB					= 0x84CB
	TEXTURE12_ARB					= 0x84CC
	TEXTURE13_ARB					= 0x84CD
	TEXTURE14_ARB					= 0x84CE
	TEXTURE15_ARB					= 0x84CF
	TEXTURE16_ARB					= 0x84D0
	TEXTURE17_ARB					= 0x84D1
	TEXTURE18_ARB					= 0x84D2
	TEXTURE19_ARB					= 0x84D3
	TEXTURE20_ARB					= 0x84D4
	TEXTURE21_ARB					= 0x84D5
	TEXTURE22_ARB					= 0x84D6
	TEXTURE23_ARB					= 0x84D7
	TEXTURE24_ARB					= 0x84D8
	TEXTURE25_ARB					= 0x84D9
	TEXTURE26_ARB					= 0x84DA
	TEXTURE27_ARB					= 0x84DB
	TEXTURE28_ARB					= 0x84DC
	TEXTURE29_ARB					= 0x84DD
	TEXTURE30_ARB					= 0x84DE
	TEXTURE31_ARB					= 0x84DF
	ACTIVE_TEXTURE_ARB				= 0x84E0 # 1 I
	CLIENT_ACTIVE_TEXTURE_ARB			= 0x84E1 # 1 I
	MAX_TEXTURE_UNITS_ARB				= 0x84E2 # 1 I

###############################################################################

# No new tokens
# ARB Extension #2 - GLX_ARB_get_proc_address

###############################################################################

# ARB Extension #3
ARB_transpose_matrix enum:
	TRANSPOSE_MODELVIEW_MATRIX_ARB			= 0x84E3 # 16 F
	TRANSPOSE_PROJECTION_MATRIX_ARB			= 0x84E4 # 16 F
	TRANSPOSE_TEXTURE_MATRIX_ARB			= 0x84E5 # 16 F
	TRANSPOSE_COLOR_MATRIX_ARB			= 0x84E6 # 16 F

###############################################################################

# No new tokens
# ARB Extension #4 - WGL_ARB_buffer_region

###############################################################################

# ARB Extension #5
ARB_multisample enum:
	MULTISAMPLE_ARB					= 0x809D
	SAMPLE_ALPHA_TO_COVERAGE_ARB			= 0x809E
	SAMPLE_ALPHA_TO_ONE_ARB				= 0x809F
	SAMPLE_COVERAGE_ARB				= 0x80A0
	SAMPLE_BUFFERS_ARB				= 0x80A8
	SAMPLES_ARB					= 0x80A9
	SAMPLE_COVERAGE_VALUE_ARB			= 0x80AA
	SAMPLE_COVERAGE_INVERT_ARB			= 0x80AB
	MULTISAMPLE_BIT_ARB				= 0x20000000

###############################################################################

# No new tokens
# ARB Extension #6
ARB_texture_env_add enum:

###############################################################################

# ARB Extension #7
ARB_texture_cube_map enum:
	NORMAL_MAP_ARB					= 0x8511
	REFLECTION_MAP_ARB				= 0x8512
	TEXTURE_CUBE_MAP_ARB				= 0x8513
	TEXTURE_BINDING_CUBE_MAP_ARB			= 0x8514
	TEXTURE_CUBE_MAP_POSITIVE_X_ARB			= 0x8515
	TEXTURE_CUBE_MAP_NEGATIVE_X_ARB			= 0x8516
	TEXTURE_CUBE_MAP_POSITIVE_Y_ARB			= 0x8517
	TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB			= 0x8518
	TEXTURE_CUBE_MAP_POSITIVE_Z_ARB			= 0x8519
	TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB			= 0x851A
	PROXY_TEXTURE_CUBE_MAP_ARB			= 0x851B
	MAX_CUBE_MAP_TEXTURE_SIZE_ARB			= 0x851C

###############################################################################

# No new tokens
# ARB Extension #8 - WGL_ARB_extensions_string
# ARB Extension #9 - WGL_ARB_pixel_format
# ARB Extension #10 - WGL_ARB_make_current_read
# ARB Extension #11 - WGL_ARB_pbuffer

###############################################################################

# ARB Extension #12
ARB_texture_compression enum:
	COMPRESSED_ALPHA_ARB				= 0x84E9
	COMPRESSED_LUMINANCE_ARB			= 0x84EA
	COMPRESSED_LUMINANCE_ALPHA_ARB			= 0x84EB
	COMPRESSED_INTENSITY_ARB			= 0x84EC
	COMPRESSED_RGB_ARB				= 0x84ED
	COMPRESSED_RGBA_ARB				= 0x84EE
	TEXTURE_COMPRESSION_HINT_ARB			= 0x84EF
	TEXTURE_COMPRESSED_IMAGE_SIZE_ARB		= 0x86A0
	TEXTURE_COMPRESSED_ARB				= 0x86A1
	NUM_COMPRESSED_TEXTURE_FORMATS_ARB		= 0x86A2
	COMPRESSED_TEXTURE_FORMATS_ARB			= 0x86A3

###############################################################################

# ARB Extension #13
# Promoted from #36 SGIS_texture_border_clamp
ARB_texture_border_clamp enum:
	CLAMP_TO_BORDER_ARB				= 0x812D

###############################################################################

# ARB Extension #14 - promoted from #54 EXT_point_parameters
# Promoted from #54 {SGIS,EXT}_point_parameters
ARB_point_parameters enum:
	POINT_SIZE_MIN_ARB				= 0x8126 # 1 F
	POINT_SIZE_MAX_ARB				= 0x8127 # 1 F
	POINT_FADE_THRESHOLD_SIZE_ARB			= 0x8128 # 1 F
	POINT_DISTANCE_ATTENUATION_ARB			= 0x8129 # 3 F

###############################################################################

# ARB Extension #15
ARB_vertex_blend enum:
	MAX_VERTEX_UNITS_ARB				= 0x86A4
	ACTIVE_VERTEX_UNITS_ARB				= 0x86A5
	WEIGHT_SUM_UNITY_ARB				= 0x86A6
	VERTEX_BLEND_ARB				= 0x86A7
	CURRENT_WEIGHT_ARB				= 0x86A8
	WEIGHT_ARRAY_TYPE_ARB				= 0x86A9
	WEIGHT_ARRAY_STRIDE_ARB				= 0x86AA
	WEIGHT_ARRAY_SIZE_ARB				= 0x86AB
	WEIGHT_ARRAY_POINTER_ARB			= 0x86AC
	WEIGHT_ARRAY_ARB				= 0x86AD
	MODELVIEW0_ARB					= 0x1700
	MODELVIEW1_ARB					= 0x850A
	MODELVIEW2_ARB					= 0x8722
	MODELVIEW3_ARB					= 0x8723
	MODELVIEW4_ARB					= 0x8724
	MODELVIEW5_ARB					= 0x8725
	MODELVIEW6_ARB					= 0x8726
	MODELVIEW7_ARB					= 0x8727
	MODELVIEW8_ARB					= 0x8728
	MODELVIEW9_ARB					= 0x8729
	MODELVIEW10_ARB					= 0x872A
	MODELVIEW11_ARB					= 0x872B
	MODELVIEW12_ARB					= 0x872C
	MODELVIEW13_ARB					= 0x872D
	MODELVIEW14_ARB					= 0x872E
	MODELVIEW15_ARB					= 0x872F
	MODELVIEW16_ARB					= 0x8730
	MODELVIEW17_ARB					= 0x8731
	MODELVIEW18_ARB					= 0x8732
	MODELVIEW19_ARB					= 0x8733
	MODELVIEW20_ARB					= 0x8734
	MODELVIEW21_ARB					= 0x8735
	MODELVIEW22_ARB					= 0x8736
	MODELVIEW23_ARB					= 0x8737
	MODELVIEW24_ARB					= 0x8738
	MODELVIEW25_ARB					= 0x8739
	MODELVIEW26_ARB					= 0x873A
	MODELVIEW27_ARB					= 0x873B
	MODELVIEW28_ARB					= 0x873C
	MODELVIEW29_ARB					= 0x873D
	MODELVIEW30_ARB					= 0x873E
	MODELVIEW31_ARB					= 0x873F

###############################################################################

# ARB Extension #16
ARB_matrix_palette enum:
	MATRIX_PALETTE_ARB				= 0x8840
	MAX_MATRIX_PALETTE_STACK_DEPTH_ARB		= 0x8841
	MAX_PALETTE_MATRICES_ARB			= 0x8842
	CURRENT_PALETTE_MATRIX_ARB			= 0x8843
	MATRIX_INDEX_ARRAY_ARB				= 0x8844
	CURRENT_MATRIX_INDEX_ARB			= 0x8845
	MATRIX_INDEX_ARRAY_SIZE_ARB			= 0x8846
	MATRIX_INDEX_ARRAY_TYPE_ARB			= 0x8847
	MATRIX_INDEX_ARRAY_STRIDE_ARB			= 0x8848
	MATRIX_INDEX_ARRAY_POINTER_ARB			= 0x8849

###############################################################################

# ARB Extension #17
# Shares enum values with EXT_texture_env_combine
ARB_texture_env_combine enum:
	COMBINE_ARB					= 0x8570
	COMBINE_RGB_ARB					= 0x8571
	COMBINE_ALPHA_ARB				= 0x8572
	SOURCE0_RGB_ARB					= 0x8580
	SOURCE1_RGB_ARB					= 0x8581
	SOURCE2_RGB_ARB					= 0x8582
	SOURCE0_ALPHA_ARB				= 0x8588
	SOURCE1_ALPHA_ARB				= 0x8589
	SOURCE2_ALPHA_ARB				= 0x858A
	OPERAND0_RGB_ARB				= 0x8590
	OPERAND1_RGB_ARB				= 0x8591
	OPERAND2_RGB_ARB				= 0x8592
	OPERAND0_ALPHA_ARB				= 0x8598
	OPERAND1_ALPHA_ARB				= 0x8599
	OPERAND2_ALPHA_ARB				= 0x859A
	RGB_SCALE_ARB					= 0x8573
	ADD_SIGNED_ARB					= 0x8574
	INTERPOLATE_ARB					= 0x8575
	SUBTRACT_ARB					= 0x84E7
	CONSTANT_ARB					= 0x8576
	PRIMARY_COLOR_ARB				= 0x8577
	PREVIOUS_ARB					= 0x8578

###############################################################################

# No new tokens
# ARB Extension #18
ARB_texture_env_crossbar enum:

###############################################################################

# ARB Extension #19
# Promoted from #220 EXT_texture_env_dot3; enum values changed
ARB_texture_env_dot3 enum:
	DOT3_RGB_ARB					= 0x86AE
	DOT3_RGBA_ARB					= 0x86AF

###############################################################################

# No new tokens
# ARB Extension #20 - WGL_ARB_render_texture

###############################################################################

# ARB Extension #21
ARB_texture_mirrored_repeat enum:
	MIRRORED_REPEAT_ARB				= 0x8370

###############################################################################

# ARB Extension #22
ARB_depth_texture enum:
	DEPTH_COMPONENT16_ARB				= 0x81A5
	DEPTH_COMPONENT24_ARB				= 0x81A6
	DEPTH_COMPONENT32_ARB				= 0x81A7
	TEXTURE_DEPTH_SIZE_ARB				= 0x884A
	DEPTH_TEXTURE_MODE_ARB				= 0x884B

###############################################################################

# ARB Extension #23
ARB_shadow enum:
       TEXTURE_COMPARE_MODE_ARB				= 0x884C
       TEXTURE_COMPARE_FUNC_ARB				= 0x884D
       COMPARE_R_TO_TEXTURE_ARB				= 0x884E

###############################################################################

# ARB Extension #24
ARB_shadow_ambient enum:
	TEXTURE_COMPARE_FAIL_VALUE_ARB			= 0x80BF

###############################################################################

# No new tokens
# ARB Extension #25
ARB_window_pos enum:

###############################################################################

# ARB Extension #26
# ARB_vertex_program enums are shared by ARB_fragment_program are so marked.
# Unfortunately, PROGRAM_BINDING_ARB does accidentally reuse 0x8677 -
#   this was a spec editing typo that's now uncorrectable.
ARB_vertex_program enum:
	COLOR_SUM_ARB					= 0x8458
	VERTEX_PROGRAM_ARB				= 0x8620
	VERTEX_ATTRIB_ARRAY_ENABLED_ARB			= 0x8622
	VERTEX_ATTRIB_ARRAY_SIZE_ARB			= 0x8623
	VERTEX_ATTRIB_ARRAY_STRIDE_ARB			= 0x8624
	VERTEX_ATTRIB_ARRAY_TYPE_ARB			= 0x8625
	CURRENT_VERTEX_ATTRIB_ARB			= 0x8626
	PROGRAM_LENGTH_ARB				= 0x8627    # shared
	PROGRAM_STRING_ARB				= 0x8628    # shared
	MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB		= 0x862E    # shared
	MAX_PROGRAM_MATRICES_ARB			= 0x862F    # shared
	CURRENT_MATRIX_STACK_DEPTH_ARB			= 0x8640    # shared
	CURRENT_MATRIX_ARB				= 0x8641    # shared
	VERTEX_PROGRAM_POINT_SIZE_ARB			= 0x8642
	VERTEX_PROGRAM_TWO_SIDE_ARB			= 0x8643
	VERTEX_ATTRIB_ARRAY_POINTER_ARB			= 0x8645
	PROGRAM_ERROR_POSITION_ARB			= 0x864B    # shared
	PROGRAM_BINDING_ARB				= 0x8677    # shared
	MAX_VERTEX_ATTRIBS_ARB				= 0x8869
	VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB		= 0x886A
	PROGRAM_ERROR_STRING_ARB			= 0x8874    # shared
	PROGRAM_FORMAT_ASCII_ARB			= 0x8875    # shared
	PROGRAM_FORMAT_ARB				= 0x8876    # shared
	PROGRAM_INSTRUCTIONS_ARB			= 0x88A0    # shared
	MAX_PROGRAM_INSTRUCTIONS_ARB			= 0x88A1    # shared
	PROGRAM_NATIVE_INSTRUCTIONS_ARB			= 0x88A2    # shared
	MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB		= 0x88A3    # shared
	PROGRAM_TEMPORARIES_ARB				= 0x88A4    # shared
	MAX_PROGRAM_TEMPORARIES_ARB			= 0x88A5    # shared
	PROGRAM_NATIVE_TEMPORARIES_ARB			= 0x88A6    # shared
	MAX_PROGRAM_NATIVE_TEMPORARIES_ARB		= 0x88A7    # shared
	PROGRAM_PARAMETERS_ARB				= 0x88A8    # shared
	MAX_PROGRAM_PARAMETERS_ARB			= 0x88A9    # shared
	PROGRAM_NATIVE_PARAMETERS_ARB			= 0x88AA    # shared
	MAX_PROGRAM_NATIVE_PARAMETERS_ARB		= 0x88AB    # shared
	PROGRAM_ATTRIBS_ARB				= 0x88AC    # shared
	MAX_PROGRAM_ATTRIBS_ARB				= 0x88AD    # shared
	PROGRAM_NATIVE_ATTRIBS_ARB			= 0x88AE    # shared
	MAX_PROGRAM_NATIVE_ATTRIBS_ARB			= 0x88AF    # shared
	PROGRAM_ADDRESS_REGISTERS_ARB			= 0x88B0    # shared
	MAX_PROGRAM_ADDRESS_REGISTERS_ARB		= 0x88B1    # shared
	PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB		= 0x88B2    # shared
	MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB	= 0x88B3    # shared
	MAX_PROGRAM_LOCAL_PARAMETERS_ARB		= 0x88B4    # shared
	MAX_PROGRAM_ENV_PARAMETERS_ARB			= 0x88B5    # shared
	PROGRAM_UNDER_NATIVE_LIMITS_ARB			= 0x88B6    # shared
	TRANSPOSE_CURRENT_MATRIX_ARB			= 0x88B7    # shared
	MATRIX0_ARB					= 0x88C0    # shared
	MATRIX1_ARB					= 0x88C1    # shared
	MATRIX2_ARB					= 0x88C2    # shared
	MATRIX3_ARB					= 0x88C3    # shared
	MATRIX4_ARB					= 0x88C4    # shared
	MATRIX5_ARB					= 0x88C5    # shared
	MATRIX6_ARB					= 0x88C6    # shared
	MATRIX7_ARB					= 0x88C7    # shared
	MATRIX8_ARB					= 0x88C8    # shared
	MATRIX9_ARB					= 0x88C9    # shared
	MATRIX10_ARB					= 0x88CA    # shared
	MATRIX11_ARB					= 0x88CB    # shared
	MATRIX12_ARB					= 0x88CC    # shared
	MATRIX13_ARB					= 0x88CD    # shared
	MATRIX14_ARB					= 0x88CE    # shared
	MATRIX15_ARB					= 0x88CF    # shared
	MATRIX16_ARB					= 0x88D0    # shared
	MATRIX17_ARB					= 0x88D1    # shared
	MATRIX18_ARB					= 0x88D2    # shared
	MATRIX19_ARB					= 0x88D3    # shared
	MATRIX20_ARB					= 0x88D4    # shared
	MATRIX21_ARB					= 0x88D5    # shared
	MATRIX22_ARB					= 0x88D6    # shared
	MATRIX23_ARB					= 0x88D7    # shared
	MATRIX24_ARB					= 0x88D8    # shared
	MATRIX25_ARB					= 0x88D9    # shared
	MATRIX26_ARB					= 0x88DA    # shared
	MATRIX27_ARB					= 0x88DB    # shared
	MATRIX28_ARB					= 0x88DC    # shared
	MATRIX29_ARB					= 0x88DD    # shared
	MATRIX30_ARB					= 0x88DE    # shared
	MATRIX31_ARB					= 0x88DF    # shared

###############################################################################

# ARB Extension #27
# Some ARB_fragment_program enums are shared with ARB_vertex_program,
#   and are only included in that #define block, for now.
ARB_fragment_program enum:
#	PROGRAM_LENGTH_ARB				= 0x8627    # shared
#	PROGRAM_STRING_ARB				= 0x8628    # shared
#	MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB		= 0x862E    # shared
#	MAX_PROGRAM_MATRICES_ARB			= 0x862F    # shared
#	CURRENT_MATRIX_STACK_DEPTH_ARB			= 0x8640    # shared
#	CURRENT_MATRIX_ARB				= 0x8641    # shared
#	PROGRAM_ERROR_POSITION_ARB			= 0x864B    # shared
#	PROGRAM_BINDING_ARB				= 0x8677    # shared
	FRAGMENT_PROGRAM_ARB				= 0x8804
	PROGRAM_ALU_INSTRUCTIONS_ARB			= 0x8805
	PROGRAM_TEX_INSTRUCTIONS_ARB			= 0x8806
	PROGRAM_TEX_INDIRECTIONS_ARB			= 0x8807
	PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB		= 0x8808
	PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB		= 0x8809
	PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB		= 0x880A
	MAX_PROGRAM_ALU_INSTRUCTIONS_ARB		= 0x880B
	MAX_PROGRAM_TEX_INSTRUCTIONS_ARB		= 0x880C
	MAX_PROGRAM_TEX_INDIRECTIONS_ARB		= 0x880D
	MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB		= 0x880E
	MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB		= 0x880F
	MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB		= 0x8810
	MAX_TEXTURE_COORDS_ARB				= 0x8871
	MAX_TEXTURE_IMAGE_UNITS_ARB			= 0x8872
#	PROGRAM_ERROR_STRING_ARB			= 0x8874    # shared
#	PROGRAM_FORMAT_ASCII_ARB			= 0x8875    # shared
#	PROGRAM_FORMAT_ARB				= 0x8876    # shared
#	PROGRAM_INSTRUCTIONS_ARB			= 0x88A0    # shared
#	MAX_PROGRAM_INSTRUCTIONS_ARB			= 0x88A1    # shared
#	PROGRAM_NATIVE_INSTRUCTIONS_ARB			= 0x88A2    # shared
#	MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB		= 0x88A3    # shared
#	PROGRAM_TEMPORARIES_ARB				= 0x88A4    # shared
#	MAX_PROGRAM_TEMPORARIES_ARB			= 0x88A5    # shared
#	PROGRAM_NATIVE_TEMPORARIES_ARB			= 0x88A6    # shared
#	MAX_PROGRAM_NATIVE_TEMPORARIES_ARB		= 0x88A7    # shared
#	PROGRAM_PARAMETERS_ARB				= 0x88A8    # shared
#	MAX_PROGRAM_PARAMETERS_ARB			= 0x88A9    # shared
#	PROGRAM_NATIVE_PARAMETERS_ARB			= 0x88AA    # shared
#	MAX_PROGRAM_NATIVE_PARAMETERS_ARB		= 0x88AB    # shared
#	PROGRAM_ATTRIBS_ARB				= 0x88AC    # shared
#	MAX_PROGRAM_ATTRIBS_ARB				= 0x88AD    # shared
#	PROGRAM_NATIVE_ATTRIBS_ARB			= 0x88AE    # shared
#	MAX_PROGRAM_NATIVE_ATTRIBS_ARB			= 0x88AF    # shared
#	PROGRAM_ADDRESS_REGISTERS_ARB			= 0x88B0    # shared
#	MAX_PROGRAM_ADDRESS_REGISTERS_ARB		= 0x88B1    # shared
#	PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB		= 0x88B2    # shared
#	MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB	= 0x88B3    # shared
#	MAX_PROGRAM_LOCAL_PARAMETERS_ARB		= 0x88B4    # shared
#	MAX_PROGRAM_ENV_PARAMETERS_ARB			= 0x88B5    # shared
#	PROGRAM_UNDER_NATIVE_LIMITS_ARB			= 0x88B6    # shared
#	TRANSPOSE_CURRENT_MATRIX_ARB			= 0x88B7    # shared
#	MATRIX0_ARB					= 0x88C0    # shared
#	MATRIX1_ARB					= 0x88C1    # shared
#	MATRIX2_ARB					= 0x88C2    # shared
#	MATRIX3_ARB					= 0x88C3    # shared
#	MATRIX4_ARB					= 0x88C4    # shared
#	MATRIX5_ARB					= 0x88C5    # shared
#	MATRIX6_ARB					= 0x88C6    # shared
#	MATRIX7_ARB					= 0x88C7    # shared
#	MATRIX8_ARB					= 0x88C8    # shared
#	MATRIX9_ARB					= 0x88C9    # shared
#	MATRIX10_ARB					= 0x88CA    # shared
#	MATRIX11_ARB					= 0x88CB    # shared
#	MATRIX12_ARB					= 0x88CC    # shared
#	MATRIX13_ARB					= 0x88CD    # shared
#	MATRIX14_ARB					= 0x88CE    # shared
#	MATRIX15_ARB					= 0x88CF    # shared
#	MATRIX16_ARB					= 0x88D0    # shared
#	MATRIX17_ARB					= 0x88D1    # shared
#	MATRIX18_ARB					= 0x88D2    # shared
#	MATRIX19_ARB					= 0x88D3    # shared
#	MATRIX20_ARB					= 0x88D4    # shared
#	MATRIX21_ARB					= 0x88D5    # shared
#	MATRIX22_ARB					= 0x88D6    # shared
#	MATRIX23_ARB					= 0x88D7    # shared
#	MATRIX24_ARB					= 0x88D8    # shared
#	MATRIX25_ARB					= 0x88D9    # shared
#	MATRIX26_ARB					= 0x88DA    # shared
#	MATRIX27_ARB					= 0x88DB    # shared
#	MATRIX28_ARB					= 0x88DC    # shared
#	MATRIX29_ARB					= 0x88DD    # shared
#	MATRIX30_ARB					= 0x88DE    # shared
#	MATRIX31_ARB					= 0x88DF    # shared


###############################################################################

# ARB Extension #28
ARB_vertex_buffer_object enum:
	BUFFER_SIZE_ARB					= 0x8764
	BUFFER_USAGE_ARB				= 0x8765
	ARRAY_BUFFER_ARB				= 0x8892
	ELEMENT_ARRAY_BUFFER_ARB			= 0x8893
	ARRAY_BUFFER_BINDING_ARB			= 0x8894
	ELEMENT_ARRAY_BUFFER_BINDING_ARB		= 0x8895
	VERTEX_ARRAY_BUFFER_BINDING_ARB			= 0x8896
	NORMAL_ARRAY_BUFFER_BINDING_ARB			= 0x8897
	COLOR_ARRAY_BUFFER_BINDING_ARB			= 0x8898
	INDEX_ARRAY_BUFFER_BINDING_ARB			= 0x8899
	TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB		= 0x889A
	EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB		= 0x889B
	SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB	= 0x889C
	FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB		= 0x889D
	WEIGHT_ARRAY_BUFFER_BINDING_ARB			= 0x889E
	VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB		= 0x889F
	READ_ONLY_ARB					= 0x88B8
	WRITE_ONLY_ARB					= 0x88B9
	READ_WRITE_ARB					= 0x88BA
	BUFFER_ACCESS_ARB				= 0x88BB
	BUFFER_MAPPED_ARB				= 0x88BC
	BUFFER_MAP_POINTER_ARB				= 0x88BD
	STREAM_DRAW_ARB					= 0x88E0
	STREAM_READ_ARB					= 0x88E1
	STREAM_COPY_ARB					= 0x88E2
	STATIC_DRAW_ARB					= 0x88E4
	STATIC_READ_ARB					= 0x88E5
	STATIC_COPY_ARB					= 0x88E6
	DYNAMIC_DRAW_ARB				= 0x88E8
	DYNAMIC_READ_ARB				= 0x88E9
	DYNAMIC_COPY_ARB				= 0x88EA

###############################################################################

# ARB Extension #29
ARB_occlusion_query enum:
	QUERY_COUNTER_BITS_ARB				= 0x8864
	CURRENT_QUERY_ARB				= 0x8865
	QUERY_RESULT_ARB				= 0x8866
	QUERY_RESULT_AVAILABLE_ARB			= 0x8867
	SAMPLES_PASSED_ARB				= 0x8914

###############################################################################

# ARB Extension #30
ARB_shader_objects enum:
	PROGRAM_OBJECT_ARB				= 0x8B40
	SHADER_OBJECT_ARB				= 0x8B48
	OBJECT_TYPE_ARB					= 0x8B4E
	OBJECT_SUBTYPE_ARB				= 0x8B4F
	FLOAT_VEC2_ARB					= 0x8B50
	FLOAT_VEC3_ARB					= 0x8B51
	FLOAT_VEC4_ARB					= 0x8B52
	INT_VEC2_ARB					= 0x8B53
	INT_VEC3_ARB					= 0x8B54
	INT_VEC4_ARB					= 0x8B55
	BOOL_ARB					= 0x8B56
	BOOL_VEC2_ARB					= 0x8B57
	BOOL_VEC3_ARB					= 0x8B58
	BOOL_VEC4_ARB					= 0x8B59
	FLOAT_MAT2_ARB					= 0x8B5A
	FLOAT_MAT3_ARB					= 0x8B5B
	FLOAT_MAT4_ARB					= 0x8B5C
	SAMPLER_1D_ARB					= 0x8B5D
	SAMPLER_2D_ARB					= 0x8B5E
	SAMPLER_3D_ARB					= 0x8B5F
	SAMPLER_CUBE_ARB				= 0x8B60
	SAMPLER_1D_SHADOW_ARB				= 0x8B61
	SAMPLER_2D_SHADOW_ARB				= 0x8B62
	SAMPLER_2D_RECT_ARB				= 0x8B63
	SAMPLER_2D_RECT_SHADOW_ARB			= 0x8B64
	OBJECT_DELETE_STATUS_ARB			= 0x8B80
	OBJECT_COMPILE_STATUS_ARB			= 0x8B81
	OBJECT_LINK_STATUS_ARB				= 0x8B82
	OBJECT_VALIDATE_STATUS_ARB			= 0x8B83
	OBJECT_INFO_LOG_LENGTH_ARB			= 0x8B84
	OBJECT_ATTACHED_OBJECTS_ARB			= 0x8B85
	OBJECT_ACTIVE_UNIFORMS_ARB			= 0x8B86
	OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB		= 0x8B87
	OBJECT_SHADER_SOURCE_LENGTH_ARB			= 0x8B88

###############################################################################

# ARB Extension #31
# Additional enums are reused from ARB_vertex/fragment_program and ARB_shader_objects
ARB_vertex_shader enum:
	VERTEX_SHADER_ARB				= 0x8B31
	MAX_VERTEX_UNIFORM_COMPONENTS_ARB		= 0x8B4A
	MAX_VARYING_FLOATS_ARB				= 0x8B4B
	MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB		= 0x8B4C
	MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB		= 0x8B4D
	OBJECT_ACTIVE_ATTRIBUTES_ARB			= 0x8B89
	OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB		= 0x8B8A

###############################################################################

# ARB Extension #32
# Additional enums are reused from ARB_fragment_program and ARB_shader_objects
ARB_fragment_shader enum:
	FRAGMENT_SHADER_ARB				= 0x8B30
	MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB		= 0x8B49
	FRAGMENT_SHADER_DERIVATIVE_HINT_ARB		= 0x8B8B

###############################################################################

# ARB Extension #33
ARB_shading_language_100 enum:
	SHADING_LANGUAGE_VERSION_ARB			= 0x8B8C

###############################################################################

# ARB Extension #34
# No new tokens
ARB_texture_non_power_of_two enum:

###############################################################################

# ARB Extension #35
ARB_point_sprite enum:
	POINT_SPRITE_ARB				= 0x8861
	COORD_REPLACE_ARB				= 0x8862

###############################################################################

# ARB Extension #36
# No new tokens
ARB_fragment_program_shadow enum:

###############################################################################

# ARB Extension #37
ARB_draw_buffers enum:
	MAX_DRAW_BUFFERS_ARB				= 0x8824
	DRAW_BUFFER0_ARB				= 0x8825
	DRAW_BUFFER1_ARB				= 0x8826
	DRAW_BUFFER2_ARB				= 0x8827
	DRAW_BUFFER3_ARB				= 0x8828
	DRAW_BUFFER4_ARB				= 0x8829
	DRAW_BUFFER5_ARB				= 0x882A
	DRAW_BUFFER6_ARB				= 0x882B
	DRAW_BUFFER7_ARB				= 0x882C
	DRAW_BUFFER8_ARB				= 0x882D
	DRAW_BUFFER9_ARB				= 0x882E
	DRAW_BUFFER10_ARB				= 0x882F
	DRAW_BUFFER11_ARB				= 0x8830
	DRAW_BUFFER12_ARB				= 0x8831
	DRAW_BUFFER13_ARB				= 0x8832
	DRAW_BUFFER14_ARB				= 0x8833
	DRAW_BUFFER15_ARB				= 0x8834

###############################################################################

# ARB Extension #38
ARB_texture_rectangle enum:
	TEXTURE_RECTANGLE_ARB				= 0x84F5
	TEXTURE_BINDING_RECTANGLE_ARB			= 0x84F6
	PROXY_TEXTURE_RECTANGLE_ARB			= 0x84F7
	MAX_RECTANGLE_TEXTURE_SIZE_ARB			= 0x84F8

###############################################################################

# ARB Extension #39
ARB_color_buffer_float enum:
	RGBA_FLOAT_MODE_ARB				= 0x8820
	CLAMP_VERTEX_COLOR_ARB				= 0x891A
	CLAMP_FRAGMENT_COLOR_ARB			= 0x891B
	CLAMP_READ_COLOR_ARB				= 0x891C
	FIXED_ONLY_ARB					= 0x891D

###############################################################################

# ARB Extension #40
ARB_half_float_pixel enum:
	HALF_FLOAT_ARB					= 0x140B

###############################################################################

# ARB Extension #41
ARB_texture_float enum:
	TEXTURE_RED_TYPE_ARB				= 0x8C10
	TEXTURE_GREEN_TYPE_ARB				= 0x8C11
	TEXTURE_BLUE_TYPE_ARB				= 0x8C12
	TEXTURE_ALPHA_TYPE_ARB				= 0x8C13
	TEXTURE_LUMINANCE_TYPE_ARB			= 0x8C14
	TEXTURE_INTENSITY_TYPE_ARB			= 0x8C15
	TEXTURE_DEPTH_TYPE_ARB				= 0x8C16
	UNSIGNED_NORMALIZED_ARB				= 0x8C17
	RGBA32F_ARB					= 0x8814
	RGB32F_ARB					= 0x8815
	ALPHA32F_ARB					= 0x8816
	INTENSITY32F_ARB				= 0x8817
	LUMINANCE32F_ARB				= 0x8818
	LUMINANCE_ALPHA32F_ARB				= 0x8819
	RGBA16F_ARB					= 0x881A
	RGB16F_ARB					= 0x881B
	ALPHA16F_ARB					= 0x881C
	INTENSITY16F_ARB				= 0x881D
	LUMINANCE16F_ARB				= 0x881E
	LUMINANCE_ALPHA16F_ARB				= 0x881F

###############################################################################

# ARB Extension #42
ARB_pixel_buffer_object enum:
	PIXEL_PACK_BUFFER_ARB				= 0x88EB
	PIXEL_UNPACK_BUFFER_ARB				= 0x88EC
	PIXEL_PACK_BUFFER_BINDING_ARB			= 0x88ED
	PIXEL_UNPACK_BUFFER_BINDING_ARB			= 0x88EF


###############################################################################
#
# non-ARB extensions follow, in registry order
#
###############################################################################

###############################################################################

# Extension #1
EXT_abgr enum:
	ABGR_EXT					= 0x8000

###############################################################################

# Extension #2
EXT_blend_color enum:
	CONSTANT_COLOR_EXT				= 0x8001
	ONE_MINUS_CONSTANT_COLOR_EXT			= 0x8002
	CONSTANT_ALPHA_EXT				= 0x8003
	ONE_MINUS_CONSTANT_ALPHA_EXT			= 0x8004
	BLEND_COLOR_EXT					= 0x8005 # 4 F

###############################################################################

# Extension #3
EXT_polygon_offset enum:
	POLYGON_OFFSET_EXT				= 0x8037
	POLYGON_OFFSET_FACTOR_EXT			= 0x8038
	POLYGON_OFFSET_BIAS_EXT				= 0x8039 # 1 F

###############################################################################

# Extension #4
EXT_texture enum:
	ALPHA4_EXT					= 0x803B
	ALPHA8_EXT					= 0x803C
	ALPHA12_EXT					= 0x803D
	ALPHA16_EXT					= 0x803E
	LUMINANCE4_EXT					= 0x803F
	LUMINANCE8_EXT					= 0x8040
	LUMINANCE12_EXT					= 0x8041
	LUMINANCE16_EXT					= 0x8042
	LUMINANCE4_ALPHA4_EXT				= 0x8043
	LUMINANCE6_ALPHA2_EXT				= 0x8044
	LUMINANCE8_ALPHA8_EXT				= 0x8045
	LUMINANCE12_ALPHA4_EXT				= 0x8046
	LUMINANCE12_ALPHA12_EXT				= 0x8047
	LUMINANCE16_ALPHA16_EXT				= 0x8048
	INTENSITY_EXT					= 0x8049
	INTENSITY4_EXT					= 0x804A
	INTENSITY8_EXT					= 0x804B
	INTENSITY12_EXT					= 0x804C
	INTENSITY16_EXT					= 0x804D
	RGB2_EXT					= 0x804E
	RGB4_EXT					= 0x804F
	RGB5_EXT					= 0x8050
	RGB8_EXT					= 0x8051
	RGB10_EXT					= 0x8052
	RGB12_EXT					= 0x8053
	RGB16_EXT					= 0x8054
	RGBA2_EXT					= 0x8055
	RGBA4_EXT					= 0x8056
	RGB5_A1_EXT					= 0x8057
	RGBA8_EXT					= 0x8058
	RGB10_A2_EXT					= 0x8059
	RGBA12_EXT					= 0x805A
	RGBA16_EXT					= 0x805B
	TEXTURE_RED_SIZE_EXT				= 0x805C
	TEXTURE_GREEN_SIZE_EXT				= 0x805D
	TEXTURE_BLUE_SIZE_EXT				= 0x805E
	TEXTURE_ALPHA_SIZE_EXT				= 0x805F
	TEXTURE_LUMINANCE_SIZE_EXT			= 0x8060
	TEXTURE_INTENSITY_SIZE_EXT			= 0x8061
	REPLACE_EXT					= 0x8062
	PROXY_TEXTURE_1D_EXT				= 0x8063
	PROXY_TEXTURE_2D_EXT				= 0x8064
	TEXTURE_TOO_LARGE_EXT				= 0x8065

###############################################################################

# Extension #5 - skipped

###############################################################################

# Extension #6
EXT_texture3D enum:
	PACK_SKIP_IMAGES_EXT				= 0x806B # 1 I
	PACK_IMAGE_HEIGHT_EXT				= 0x806C # 1 F
	UNPACK_SKIP_IMAGES_EXT				= 0x806D # 1 I
	UNPACK_IMAGE_HEIGHT_EXT				= 0x806E # 1 F
	TEXTURE_3D_EXT					= 0x806F # 1 I
	PROXY_TEXTURE_3D_EXT				= 0x8070
	TEXTURE_DEPTH_EXT				= 0x8071
	TEXTURE_WRAP_R_EXT				= 0x8072
	MAX_3D_TEXTURE_SIZE_EXT				= 0x8073 # 1 I

###############################################################################

# Extension #7
SGIS_texture_filter4 enum:
	FILTER4_SGIS					= 0x8146
	TEXTURE_FILTER4_SIZE_SGIS			= 0x8147

###############################################################################

# Extension #8 - skipped

###############################################################################

# No new tokens
# Extension #9
EXT_subtexture enum:

###############################################################################

# No new tokens
# Extension #10
EXT_copy_texture enum:

###############################################################################

# Extension #11
EXT_histogram enum:
	HISTOGRAM_EXT					= 0x8024 # 1 I
	PROXY_HISTOGRAM_EXT				= 0x8025
	HISTOGRAM_WIDTH_EXT				= 0x8026
	HISTOGRAM_FORMAT_EXT				= 0x8027
	HISTOGRAM_RED_SIZE_EXT				= 0x8028
	HISTOGRAM_GREEN_SIZE_EXT			= 0x8029
	HISTOGRAM_BLUE_SIZE_EXT				= 0x802A
	HISTOGRAM_ALPHA_SIZE_EXT			= 0x802B
	HISTOGRAM_LUMINANCE_SIZE_EXT			= 0x802C
	HISTOGRAM_SINK_EXT				= 0x802D
	MINMAX_EXT					= 0x802E # 1 I
	MINMAX_FORMAT_EXT				= 0x802F
	MINMAX_SINK_EXT					= 0x8030
	TABLE_TOO_LARGE_EXT				= 0x8031

###############################################################################

# Extension #12
EXT_convolution enum:
	CONVOLUTION_1D_EXT				= 0x8010 # 1 I
	CONVOLUTION_2D_EXT				= 0x8011 # 1 I
	SEPARABLE_2D_EXT				= 0x8012 # 1 I
	CONVOLUTION_BORDER_MODE_EXT			= 0x8013
	CONVOLUTION_FILTER_SCALE_EXT			= 0x8014
	CONVOLUTION_FILTER_BIAS_EXT			= 0x8015
	REDUCE_EXT					= 0x8016
	CONVOLUTION_FORMAT_EXT				= 0x8017
	CONVOLUTION_WIDTH_EXT				= 0x8018
	CONVOLUTION_HEIGHT_EXT				= 0x8019
	MAX_CONVOLUTION_WIDTH_EXT			= 0x801A
	MAX_CONVOLUTION_HEIGHT_EXT			= 0x801B
	POST_CONVOLUTION_RED_SCALE_EXT			= 0x801C # 1 F
	POST_CONVOLUTION_GREEN_SCALE_EXT		= 0x801D # 1 F
	POST_CONVOLUTION_BLUE_SCALE_EXT			= 0x801E # 1 F
	POST_CONVOLUTION_ALPHA_SCALE_EXT		= 0x801F # 1 F
	POST_CONVOLUTION_RED_BIAS_EXT			= 0x8020 # 1 F
	POST_CONVOLUTION_GREEN_BIAS_EXT			= 0x8021 # 1 F
	POST_CONVOLUTION_BLUE_BIAS_EXT			= 0x8022 # 1 F
	POST_CONVOLUTION_ALPHA_BIAS_EXT			= 0x8023 # 1 F

###############################################################################

# Extension #13
SGI_color_matrix enum:
	COLOR_MATRIX_SGI				= 0x80B1 # 16 F
	COLOR_MATRIX_STACK_DEPTH_SGI			= 0x80B2 # 1 I
	MAX_COLOR_MATRIX_STACK_DEPTH_SGI		= 0x80B3 # 1 I
	POST_COLOR_MATRIX_RED_SCALE_SGI			= 0x80B4 # 1 F
	POST_COLOR_MATRIX_GREEN_SCALE_SGI		= 0x80B5 # 1 F
	POST_COLOR_MATRIX_BLUE_SCALE_SGI		= 0x80B6 # 1 F
	POST_COLOR_MATRIX_ALPHA_SCALE_SGI		= 0x80B7 # 1 F
	POST_COLOR_MATRIX_RED_BIAS_SGI			= 0x80B8 # 1 F
	POST_COLOR_MATRIX_GREEN_BIAS_SGI		= 0x80B9 # 1 F
	POST_COLOR_MATRIX_BLUE_BIAS_SGI			= 0x80BA # 1 F
	POST_COLOR_MATRIX_ALPHA_BIAS_SGI		= 0x80BB # 1 F

###############################################################################

# Extension #14
SGI_color_table enum:
	COLOR_TABLE_SGI					= 0x80D0 # 1 I
	POST_CONVOLUTION_COLOR_TABLE_SGI		= 0x80D1 # 1 I
	POST_COLOR_MATRIX_COLOR_TABLE_SGI		= 0x80D2 # 1 I
	PROXY_COLOR_TABLE_SGI				= 0x80D3
	PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI		= 0x80D4
	PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI		= 0x80D5
	COLOR_TABLE_SCALE_SGI				= 0x80D6
	COLOR_TABLE_BIAS_SGI				= 0x80D7
	COLOR_TABLE_FORMAT_SGI				= 0x80D8
	COLOR_TABLE_WIDTH_SGI				= 0x80D9
	COLOR_TABLE_RED_SIZE_SGI			= 0x80DA
	COLOR_TABLE_GREEN_SIZE_SGI			= 0x80DB
	COLOR_TABLE_BLUE_SIZE_SGI			= 0x80DC
	COLOR_TABLE_ALPHA_SIZE_SGI			= 0x80DD
	COLOR_TABLE_LUMINANCE_SIZE_SGI			= 0x80DE
	COLOR_TABLE_INTENSITY_SIZE_SGI			= 0x80DF

###############################################################################

# Extension #15
SGIS_pixel_texture enum:
	PIXEL_TEXTURE_SGIS				= 0x8353 # 1 I
	PIXEL_FRAGMENT_RGB_SOURCE_SGIS			= 0x8354 # 1 I
	PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS		= 0x8355 # 1 I
	PIXEL_GROUP_COLOR_SGIS				= 0x8356 # 1 I

###############################################################################

# Extension #15a
SGIX_pixel_texture enum:
	PIXEL_TEX_GEN_SGIX				= 0x8139 # 1 I
	PIXEL_TEX_GEN_MODE_SGIX				= 0x832B # 1 I

###############################################################################

# Extension #16
SGIS_texture4D enum:
	PACK_SKIP_VOLUMES_SGIS				= 0x8130 # 1 I
	PACK_IMAGE_DEPTH_SGIS				= 0x8131 # 1 I
	UNPACK_SKIP_VOLUMES_SGIS			= 0x8132 # 1 I
	UNPACK_IMAGE_DEPTH_SGIS				= 0x8133 # 1 I
	TEXTURE_4D_SGIS					= 0x8134 # 1 I
	PROXY_TEXTURE_4D_SGIS				= 0x8135
	TEXTURE_4DSIZE_SGIS				= 0x8136
	TEXTURE_WRAP_Q_SGIS				= 0x8137
	MAX_4D_TEXTURE_SIZE_SGIS			= 0x8138 # 1 I
	TEXTURE_4D_BINDING_SGIS				= 0x814F # 1 I

###############################################################################

# Extension #17
SGI_texture_color_table enum:
	TEXTURE_COLOR_TABLE_SGI				= 0x80BC # 1 I
	PROXY_TEXTURE_COLOR_TABLE_SGI			= 0x80BD

###############################################################################

# Extension #18
EXT_cmyka enum:
	CMYK_EXT					= 0x800C
	CMYKA_EXT					= 0x800D
	PACK_CMYK_HINT_EXT				= 0x800E # 1 I
	UNPACK_CMYK_HINT_EXT				= 0x800F # 1 I

###############################################################################

# Extension #19 - skipped

###############################################################################

# Extension #20
EXT_texture_object enum:
	TEXTURE_PRIORITY_EXT				= 0x8066
	TEXTURE_RESIDENT_EXT				= 0x8067
	TEXTURE_1D_BINDING_EXT				= 0x8068
	TEXTURE_2D_BINDING_EXT				= 0x8069
	TEXTURE_3D_BINDING_EXT				= 0x806A # 1 I

###############################################################################

# Extension #21
SGIS_detail_texture enum:
	DETAIL_TEXTURE_2D_SGIS				= 0x8095
	DETAIL_TEXTURE_2D_BINDING_SGIS			= 0x8096 # 1 I
	LINEAR_DETAIL_SGIS				= 0x8097
	LINEAR_DETAIL_ALPHA_SGIS			= 0x8098
	LINEAR_DETAIL_COLOR_SGIS			= 0x8099
	DETAIL_TEXTURE_LEVEL_SGIS			= 0x809A
	DETAIL_TEXTURE_MODE_SGIS			= 0x809B
	DETAIL_TEXTURE_FUNC_POINTS_SGIS			= 0x809C

###############################################################################

# Extension #22
SGIS_sharpen_texture enum:
	LINEAR_SHARPEN_SGIS				= 0x80AD
	LINEAR_SHARPEN_ALPHA_SGIS			= 0x80AE
	LINEAR_SHARPEN_COLOR_SGIS			= 0x80AF
	SHARPEN_TEXTURE_FUNC_POINTS_SGIS		= 0x80B0

###############################################################################

# Extension #23
EXT_packed_pixels enum:
	UNSIGNED_BYTE_3_3_2_EXT				= 0x8032
	UNSIGNED_SHORT_4_4_4_4_EXT			= 0x8033
	UNSIGNED_SHORT_5_5_5_1_EXT			= 0x8034
	UNSIGNED_INT_8_8_8_8_EXT			= 0x8035
	UNSIGNED_INT_10_10_10_2_EXT			= 0x8036

###############################################################################

# Extension #24
SGIS_texture_lod enum:
	TEXTURE_MIN_LOD_SGIS				= 0x813A
	TEXTURE_MAX_LOD_SGIS				= 0x813B
	TEXTURE_BASE_LEVEL_SGIS				= 0x813C
	TEXTURE_MAX_LEVEL_SGIS				= 0x813D

###############################################################################

# Extension #25
SGIS_multisample enum:
	MULTISAMPLE_SGIS				= 0x809D # 1 I
	SAMPLE_ALPHA_TO_MASK_SGIS			= 0x809E # 1 I
	SAMPLE_ALPHA_TO_ONE_SGIS			= 0x809F # 1 I
	SAMPLE_MASK_SGIS				= 0x80A0 # 1 I
	1PASS_SGIS					= 0x80A1
	2PASS_0_SGIS					= 0x80A2
	2PASS_1_SGIS					= 0x80A3
	4PASS_0_SGIS					= 0x80A4
	4PASS_1_SGIS					= 0x80A5
	4PASS_2_SGIS					= 0x80A6
	4PASS_3_SGIS					= 0x80A7
	SAMPLE_BUFFERS_SGIS				= 0x80A8 # 1 I
	SAMPLES_SGIS					= 0x80A9 # 1 I
	SAMPLE_MASK_VALUE_SGIS				= 0x80AA # 1 F
	SAMPLE_MASK_INVERT_SGIS				= 0x80AB # 1 I
	SAMPLE_PATTERN_SGIS				= 0x80AC # 1 I

###############################################################################

# Extension #26 - no specification?
# SGIS_premultiply_blend enum:

##############################################################################

# Extension #27
# Diamond ships an otherwise identical IBM_rescale_normal extension;
#  Dan Brokenshire says this is deprecated and should not be advertised.
EXT_rescale_normal enum:
	RESCALE_NORMAL_EXT				= 0x803A # 1 I

###############################################################################

# Extension #28 - GLX_EXT_visual_info

###############################################################################

# Extension #29 - skipped

###############################################################################

# Extension #30
EXT_vertex_array enum:
	VERTEX_ARRAY_EXT				= 0x8074
	NORMAL_ARRAY_EXT				= 0x8075
	COLOR_ARRAY_EXT					= 0x8076
	INDEX_ARRAY_EXT					= 0x8077
	TEXTURE_COORD_ARRAY_EXT				= 0x8078
	EDGE_FLAG_ARRAY_EXT				= 0x8079
	VERTEX_ARRAY_SIZE_EXT				= 0x807A
	VERTEX_ARRAY_TYPE_EXT				= 0x807B
	VERTEX_ARRAY_STRIDE_EXT				= 0x807C
	VERTEX_ARRAY_COUNT_EXT				= 0x807D # 1 I
	NORMAL_ARRAY_TYPE_EXT				= 0x807E
	NORMAL_ARRAY_STRIDE_EXT				= 0x807F
	NORMAL_ARRAY_COUNT_EXT				= 0x8080 # 1 I
	COLOR_ARRAY_SIZE_EXT				= 0x8081
	COLOR_ARRAY_TYPE_EXT				= 0x8082
	COLOR_ARRAY_STRIDE_EXT				= 0x8083
	COLOR_ARRAY_COUNT_EXT				= 0x8084 # 1 I
	INDEX_ARRAY_TYPE_EXT				= 0x8085
	INDEX_ARRAY_STRIDE_EXT				= 0x8086
	INDEX_ARRAY_COUNT_EXT				= 0x8087 # 1 I
	TEXTURE_COORD_ARRAY_SIZE_EXT			= 0x8088
	TEXTURE_COORD_ARRAY_TYPE_EXT			= 0x8089
	TEXTURE_COORD_ARRAY_STRIDE_EXT			= 0x808A
	TEXTURE_COORD_ARRAY_COUNT_EXT			= 0x808B # 1 I
	EDGE_FLAG_ARRAY_STRIDE_EXT			= 0x808C
	EDGE_FLAG_ARRAY_COUNT_EXT			= 0x808D # 1 I
	VERTEX_ARRAY_POINTER_EXT			= 0x808E
	NORMAL_ARRAY_POINTER_EXT			= 0x808F
	COLOR_ARRAY_POINTER_EXT				= 0x8090
	INDEX_ARRAY_POINTER_EXT				= 0x8091
	TEXTURE_COORD_ARRAY_POINTER_EXT			= 0x8092
	EDGE_FLAG_ARRAY_POINTER_EXT			= 0x8093

###############################################################################

# Extension #31
EXT_misc_attribute enum:
#	 MISC_BIT					 = 0x????

###############################################################################

# Extension #32
SGIS_generate_mipmap enum:
	GENERATE_MIPMAP_SGIS				= 0x8191
	GENERATE_MIPMAP_HINT_SGIS			= 0x8192 # 1 I

###############################################################################

# Extension #33
SGIX_clipmap enum:
	LINEAR_CLIPMAP_LINEAR_SGIX			= 0x8170
	TEXTURE_CLIPMAP_CENTER_SGIX			= 0x8171
	TEXTURE_CLIPMAP_FRAME_SGIX			= 0x8172
	TEXTURE_CLIPMAP_OFFSET_SGIX			= 0x8173
	TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX		= 0x8174
	TEXTURE_CLIPMAP_LOD_OFFSET_SGIX			= 0x8175
	TEXTURE_CLIPMAP_DEPTH_SGIX			= 0x8176
	MAX_CLIPMAP_DEPTH_SGIX				= 0x8177 # 1 I
	MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX			= 0x8178 # 1 I
	NEAREST_CLIPMAP_NEAREST_SGIX			= 0x844D
	NEAREST_CLIPMAP_LINEAR_SGIX			= 0x844E
	LINEAR_CLIPMAP_NEAREST_SGIX			= 0x844F

###############################################################################

# Extension #34
SGIX_shadow enum:
	TEXTURE_COMPARE_SGIX				= 0x819A
	TEXTURE_COMPARE_OPERATOR_SGIX			= 0x819B
	TEXTURE_LEQUAL_R_SGIX				= 0x819C
	TEXTURE_GEQUAL_R_SGIX				= 0x819D

###############################################################################

# Extension #35
SGIS_texture_edge_clamp enum:
	CLAMP_TO_EDGE_SGIS				= 0x812F

###############################################################################

# Extension #36
# Promoted to ARB_texture_border_clamp
SGIS_texture_border_clamp enum:
	CLAMP_TO_BORDER_SGIS				= 0x812D

###############################################################################

# Extension #37
EXT_blend_minmax enum:
	FUNC_ADD_EXT					= 0x8006
	MIN_EXT						= 0x8007
	MAX_EXT						= 0x8008
	BLEND_EQUATION_EXT				= 0x8009 # 1 I

###############################################################################

# Extension #38
EXT_blend_subtract enum:
	FUNC_SUBTRACT_EXT				= 0x800A
	FUNC_REVERSE_SUBTRACT_EXT			= 0x800B

###############################################################################

# No new tokens
# Extension #39
EXT_blend_logic_op enum:

###############################################################################

# Extension #40 - GLX_SGI_swap_control
# Extension #41 - GLX_SGI_video_sync
# Extension #42 - GLX_SGI_make_current_read
# Extension #43 - GLX_SGIX_video_source
# Extension #44 - GLX_EXT_visual_rating

###############################################################################

# Extension #45
SGIX_interlace enum:
	INTERLACE_SGIX					= 0x8094 # 1 I

###############################################################################

# Extension #46
SGIX_pixel_tiles enum:
	PIXEL_TILE_BEST_ALIGNMENT_SGIX			= 0x813E # 1 I
	PIXEL_TILE_CACHE_INCREMENT_SGIX			= 0x813F # 1 I
	PIXEL_TILE_WIDTH_SGIX				= 0x8140 # 1 I
	PIXEL_TILE_HEIGHT_SGIX				= 0x8141 # 1 I
	PIXEL_TILE_GRID_WIDTH_SGIX			= 0x8142 # 1 I
	PIXEL_TILE_GRID_HEIGHT_SGIX			= 0x8143 # 1 I
	PIXEL_TILE_GRID_DEPTH_SGIX			= 0x8144 # 1 I
	PIXEL_TILE_CACHE_SIZE_SGIX			= 0x8145 # 1 I

###############################################################################

# Extension #47 - GLX_EXT_import_context

###############################################################################

# Extension #48 - skipped

###############################################################################

# Extension #49 - GLX_SGIX_fbconfig
# Extension #50 - GLX_SGIX_pbuffer

###############################################################################

# Extension #51
SGIS_texture_select enum:
	DUAL_ALPHA4_SGIS				= 0x8110
	DUAL_ALPHA8_SGIS				= 0x8111
	DUAL_ALPHA12_SGIS				= 0x8112
	DUAL_ALPHA16_SGIS				= 0x8113
	DUAL_LUMINANCE4_SGIS				= 0x8114
	DUAL_LUMINANCE8_SGIS				= 0x8115
	DUAL_LUMINANCE12_SGIS				= 0x8116
	DUAL_LUMINANCE16_SGIS				= 0x8117
	DUAL_INTENSITY4_SGIS				= 0x8118
	DUAL_INTENSITY8_SGIS				= 0x8119
	DUAL_INTENSITY12_SGIS				= 0x811A
	DUAL_INTENSITY16_SGIS				= 0x811B
	DUAL_LUMINANCE_ALPHA4_SGIS			= 0x811C
	DUAL_LUMINANCE_ALPHA8_SGIS			= 0x811D
	QUAD_ALPHA4_SGIS				= 0x811E
	QUAD_ALPHA8_SGIS				= 0x811F
	QUAD_LUMINANCE4_SGIS				= 0x8120
	QUAD_LUMINANCE8_SGIS				= 0x8121
	QUAD_INTENSITY4_SGIS				= 0x8122
	QUAD_INTENSITY8_SGIS				= 0x8123
	DUAL_TEXTURE_SELECT_SGIS			= 0x8124
	QUAD_TEXTURE_SELECT_SGIS			= 0x8125

###############################################################################

# Extension #52
SGIX_sprite enum:
	SPRITE_SGIX					= 0x8148 # 1 I
	SPRITE_MODE_SGIX				= 0x8149 # 1 I
	SPRITE_AXIS_SGIX				= 0x814A # 3 F
	SPRITE_TRANSLATION_SGIX				= 0x814B # 3 F
	SPRITE_AXIAL_SGIX				= 0x814C
	SPRITE_OBJECT_ALIGNED_SGIX			= 0x814D
	SPRITE_EYE_ALIGNED_SGIX				= 0x814E

###############################################################################

# Extension #53
SGIX_texture_multi_buffer enum:
	TEXTURE_MULTI_BUFFER_HINT_SGIX			= 0x812E

###############################################################################

# Extension #54
# EXT form promoted from SGIS form; both are included
EXT_point_parameters enum:
	POINT_SIZE_MIN_EXT				= 0x8126 # 1 F
	POINT_SIZE_MAX_EXT				= 0x8127 # 1 F
	POINT_FADE_THRESHOLD_SIZE_EXT			= 0x8128 # 1 F
	DISTANCE_ATTENUATION_EXT			= 0x8129 # 3 F

SGIS_point_parameters enum:
	POINT_SIZE_MIN_SGIS				= 0x8126 # 1 F
	POINT_SIZE_MAX_SGIS				= 0x8127 # 1 F
	POINT_FADE_THRESHOLD_SIZE_SGIS			= 0x8128 # 1 F
	DISTANCE_ATTENUATION_SGIS			= 0x8129 # 3 F

###############################################################################

# Extension #55
SGIX_instruments enum:
	INSTRUMENT_BUFFER_POINTER_SGIX			= 0x8180
	INSTRUMENT_MEASUREMENTS_SGIX			= 0x8181 # 1 I

###############################################################################

# Extension #56
SGIX_texture_scale_bias enum:
	POST_TEXTURE_FILTER_BIAS_SGIX			= 0x8179
	POST_TEXTURE_FILTER_SCALE_SGIX			= 0x817A
	POST_TEXTURE_FILTER_BIAS_RANGE_SGIX		= 0x817B # 2 F
	POST_TEXTURE_FILTER_SCALE_RANGE_SGIX		= 0x817C # 2 F

###############################################################################

# Extension #57
SGIX_framezoom enum:
	FRAMEZOOM_SGIX					= 0x818B # 1 I
	FRAMEZOOM_FACTOR_SGIX				= 0x818C # 1 I
	MAX_FRAMEZOOM_FACTOR_SGIX			= 0x818D # 1 I

###############################################################################

# No new tokens
# Extension #58
SGIX_tag_sample_buffer enum:

###############################################################################

# Extension #59
FfdMaskSGIX enum:
	TEXTURE_DEFORMATION_BIT_SGIX			= 0x00000001
	GEOMETRY_DEFORMATION_BIT_SGIX			= 0x00000002
SGIX_polynomial_ffd enum:
	GEOMETRY_DEFORMATION_SGIX			= 0x8194
	TEXTURE_DEFORMATION_SGIX			= 0x8195
	DEFORMATIONS_MASK_SGIX				= 0x8196 # 1 I
	MAX_DEFORMATION_ORDER_SGIX			= 0x8197

###############################################################################

# Extension #60
SGIX_reference_plane enum:
	REFERENCE_PLANE_SGIX				= 0x817D # 1 I
	REFERENCE_PLANE_EQUATION_SGIX			= 0x817E # 4 F

###############################################################################

# No new tokens
# Extension #61
SGIX_flush_raster enum:

###############################################################################

# Extension #62 - GLX_SGIX_cushion

###############################################################################

# Extension #63
SGIX_depth_texture enum:
	DEPTH_COMPONENT16_SGIX				= 0x81A5
	DEPTH_COMPONENT24_SGIX				= 0x81A6
	DEPTH_COMPONENT32_SGIX				= 0x81A7

###############################################################################

# Extension #64
SGIS_fog_function enum:
	FOG_FUNC_SGIS					= 0x812A
	FOG_FUNC_POINTS_SGIS				= 0x812B # 1 I
	MAX_FOG_FUNC_POINTS_SGIS			= 0x812C # 1 I

###############################################################################

# Extension #65
SGIX_fog_offset enum:
	FOG_OFFSET_SGIX					= 0x8198 # 1 I
	FOG_OFFSET_VALUE_SGIX				= 0x8199 # 4 F

###############################################################################

# Extension #66
HP_image_transform enum:
	IMAGE_SCALE_X_HP				= 0x8155
	IMAGE_SCALE_Y_HP				= 0x8156
	IMAGE_TRANSLATE_X_HP				= 0x8157
	IMAGE_TRANSLATE_Y_HP				= 0x8158
	IMAGE_ROTATE_ANGLE_HP				= 0x8159
	IMAGE_ROTATE_ORIGIN_X_HP			= 0x815A
	IMAGE_ROTATE_ORIGIN_Y_HP			= 0x815B
	IMAGE_MAG_FILTER_HP				= 0x815C
	IMAGE_MIN_FILTER_HP				= 0x815D
	IMAGE_CUBIC_WEIGHT_HP				= 0x815E
	CUBIC_HP					= 0x815F
	AVERAGE_HP					= 0x8160
	IMAGE_TRANSFORM_2D_HP				= 0x8161
	POST_IMAGE_TRANSFORM_COLOR_TABLE_HP		= 0x8162
	PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP	= 0x8163

###############################################################################

# Extension #67
HP_convolution_border_modes enum:
	IGNORE_BORDER_HP				= 0x8150
	CONSTANT_BORDER_HP				= 0x8151
	REPLICATE_BORDER_HP				= 0x8153
	CONVOLUTION_BORDER_COLOR_HP			= 0x8154

###############################################################################

#@ Unknown tokens
# Extension #68
INGR_palette_buffer enum:

###############################################################################

# Extension #69
SGIX_texture_add_env enum:
	TEXTURE_ENV_BIAS_SGIX				= 0x80BE

###############################################################################

# Extension #70 - skipped
# Extension #71 - skipped
# Extension #72 - skipped
# Extension #73 - skipped

###############################################################################

# No new tokens
# Extension #74
EXT_color_subtable enum:

###############################################################################

# Extension #75 - GLU_EXT_object_space_tess

###############################################################################

# Extension #76
PGI_vertex_hints enum:
	VERTEX_DATA_HINT_PGI				= 0x1A22A
	VERTEX_CONSISTENT_HINT_PGI			= 0x1A22B
	MATERIAL_SIDE_HINT_PGI				= 0x1A22C
	MAX_VERTEX_HINT_PGI				= 0x1A22D
	COLOR3_BIT_PGI					= 0x00010000
	COLOR4_BIT_PGI					= 0x00020000
	EDGEFLAG_BIT_PGI				= 0x00040000
	INDEX_BIT_PGI					= 0x00080000
	MAT_AMBIENT_BIT_PGI				= 0x00100000
	MAT_AMBIENT_AND_DIFFUSE_BIT_PGI			= 0x00200000
	MAT_DIFFUSE_BIT_PGI				= 0x00400000
	MAT_EMISSION_BIT_PGI				= 0x00800000
	MAT_COLOR_INDEXES_BIT_PGI			= 0x01000000
	MAT_SHININESS_BIT_PGI				= 0x02000000
	MAT_SPECULAR_BIT_PGI				= 0x04000000
	NORMAL_BIT_PGI					= 0x08000000
	TEXCOORD1_BIT_PGI				= 0x10000000
	TEXCOORD2_BIT_PGI				= 0x20000000
	TEXCOORD3_BIT_PGI				= 0x40000000
	TEXCOORD4_BIT_PGI				= 0x80000000
	VERTEX23_BIT_PGI				= 0x00000004
	VERTEX4_BIT_PGI					= 0x00000008

###############################################################################

# Extension #77
PGI_misc_hints enum:
	PREFER_DOUBLEBUFFER_HINT_PGI			= 0x1A1F8
	CONSERVE_MEMORY_HINT_PGI			= 0x1A1FD
	RECLAIM_MEMORY_HINT_PGI				= 0x1A1FE
	NATIVE_GRAPHICS_HANDLE_PGI			= 0x1A202
	NATIVE_GRAPHICS_BEGIN_HINT_PGI			= 0x1A203
	NATIVE_GRAPHICS_END_HINT_PGI			= 0x1A204
	ALWAYS_FAST_HINT_PGI				= 0x1A20C
	ALWAYS_SOFT_HINT_PGI				= 0x1A20D
	ALLOW_DRAW_OBJ_HINT_PGI				= 0x1A20E
	ALLOW_DRAW_WIN_HINT_PGI				= 0x1A20F
	ALLOW_DRAW_FRG_HINT_PGI				= 0x1A210
	ALLOW_DRAW_MEM_HINT_PGI				= 0x1A211
	STRICT_DEPTHFUNC_HINT_PGI			= 0x1A216
	STRICT_LIGHTING_HINT_PGI			= 0x1A217
	STRICT_SCISSOR_HINT_PGI				= 0x1A218
	FULL_STIPPLE_HINT_PGI				= 0x1A219
	CLIP_NEAR_HINT_PGI				= 0x1A220
	CLIP_FAR_HINT_PGI				= 0x1A221
	WIDE_LINE_HINT_PGI				= 0x1A222
	BACK_NORMALS_HINT_PGI				= 0x1A223

###############################################################################

# Extension #78
EXT_paletted_texture enum:
	COLOR_INDEX1_EXT				= 0x80E2
	COLOR_INDEX2_EXT				= 0x80E3
	COLOR_INDEX4_EXT				= 0x80E4
	COLOR_INDEX8_EXT				= 0x80E5
	COLOR_INDEX12_EXT				= 0x80E6
	COLOR_INDEX16_EXT				= 0x80E7
	TEXTURE_INDEX_SIZE_EXT				= 0x80ED

###############################################################################

# Extension #79
EXT_clip_volume_hint enum:
	CLIP_VOLUME_CLIPPING_HINT_EXT			= 0x80F0

###############################################################################

# Extension #80
SGIX_list_priority enum:
	LIST_PRIORITY_SGIX				= 0x8182

###############################################################################

# Extension #81
SGIX_ir_instrument1 enum:
	IR_INSTRUMENT1_SGIX				= 0x817F # 1 I

###############################################################################

# Extension #82
SGIX_calligraphic_fragment enum:
	CALLIGRAPHIC_FRAGMENT_SGIX			= 0x8183 # 1 I

###############################################################################

# Extension #83 - GLX_SGIX_video_resize

###############################################################################

# Extension #84
SGIX_texture_lod_bias enum:
	TEXTURE_LOD_BIAS_S_SGIX				= 0x818E
	TEXTURE_LOD_BIAS_T_SGIX				= 0x818F
	TEXTURE_LOD_BIAS_R_SGIX				= 0x8190

###############################################################################

# Extension #85 - skipped

###############################################################################

# Extension #86 - GLX_SGIX_dmbuffer

###############################################################################

# Extension #87 - skipped
# Extension #88 - skipped
# Extension #89 - skipped

###############################################################################

# Extension #90
SGIX_shadow_ambient enum:
	SHADOW_AMBIENT_SGIX				= 0x80BF

###############################################################################

# Extension #91 - GLX_SGIX_swap_group
# Extension #92 - GLX_SGIX_swap_barrier

###############################################################################

# No new tokens
# Extension #93
EXT_index_texture enum:

###############################################################################

# Extension #94
# Promoted from SGI?
EXT_index_material enum:
	INDEX_MATERIAL_EXT				= 0x81B8
	INDEX_MATERIAL_PARAMETER_EXT			= 0x81B9
	INDEX_MATERIAL_FACE_EXT				= 0x81BA

###############################################################################

# Extension #95
# Promoted from SGI?
EXT_index_func enum:
	INDEX_TEST_EXT					= 0x81B5
	INDEX_TEST_FUNC_EXT				= 0x81B6
	INDEX_TEST_REF_EXT				= 0x81B7

###############################################################################

# Extension #96
# Promoted from SGI?
EXT_index_array_formats enum:
	IUI_V2F_EXT					= 0x81AD
	IUI_V3F_EXT					= 0x81AE
	IUI_N3F_V2F_EXT					= 0x81AF
	IUI_N3F_V3F_EXT					= 0x81B0
	T2F_IUI_V2F_EXT					= 0x81B1
	T2F_IUI_V3F_EXT					= 0x81B2
	T2F_IUI_N3F_V2F_EXT				= 0x81B3
	T2F_IUI_N3F_V3F_EXT				= 0x81B4

###############################################################################

# Extension #97
# Promoted from SGI?
EXT_compiled_vertex_array enum:
	ARRAY_ELEMENT_LOCK_FIRST_EXT			= 0x81A8
	ARRAY_ELEMENT_LOCK_COUNT_EXT			= 0x81A9

###############################################################################

# Extension #98
# Promoted from SGI?
EXT_cull_vertex enum:
	CULL_VERTEX_EXT					= 0x81AA
	CULL_VERTEX_EYE_POSITION_EXT			= 0x81AB
	CULL_VERTEX_OBJECT_POSITION_EXT			= 0x81AC

###############################################################################

# Extension #99 - skipped

###############################################################################

# Extension #100 - GLU_EXT_nurbs_tessellator

###############################################################################

# Extension #101
SGIX_ycrcb enum:
	YCRCB_422_SGIX					= 0x81BB
	YCRCB_444_SGIX					= 0x81BC

###############################################################################

# Extension #102
SGIX_fragment_lighting enum:
	FRAGMENT_LIGHTING_SGIX				= 0x8400 # 1 I
	FRAGMENT_COLOR_MATERIAL_SGIX			= 0x8401 # 1 I
	FRAGMENT_COLOR_MATERIAL_FACE_SGIX		= 0x8402 # 1 I
	FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX		= 0x8403 # 1 I
	MAX_FRAGMENT_LIGHTS_SGIX			= 0x8404 # 1 I
	MAX_ACTIVE_LIGHTS_SGIX				= 0x8405 # 1 I
	CURRENT_RASTER_NORMAL_SGIX			= 0x8406 # 1 I
	LIGHT_ENV_MODE_SGIX				= 0x8407 # 1 I
	FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX		= 0x8408 # 1 I
	FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX		= 0x8409 # 1 I
	FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX		= 0x840A # 4 F
	FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX	= 0x840B # 1 I
	FRAGMENT_LIGHT0_SGIX				= 0x840C # 1 I
	FRAGMENT_LIGHT1_SGIX				= 0x840D
	FRAGMENT_LIGHT2_SGIX				= 0x840E
	FRAGMENT_LIGHT3_SGIX				= 0x840F
	FRAGMENT_LIGHT4_SGIX				= 0x8410
	FRAGMENT_LIGHT5_SGIX				= 0x8411
	FRAGMENT_LIGHT6_SGIX				= 0x8412
	FRAGMENT_LIGHT7_SGIX				= 0x8413

# SGIX_fragment_lighting_future_use: 0x8414-0x842B

###############################################################################

# Extension #103 - skipped
# Extension #104 - skipped
# Extension #105 - skipped
# Extension #106 - skipped
# Extension #107 - skipped
# Extension #108 - skipped
# Extension #109 - skipped

###############################################################################

# Extension #110
IBM_rasterpos_clip enum:
	RASTER_POSITION_UNCLIPPED_IBM			= 0x19262

###############################################################################

# Extension #111
HP_texture_lighting enum:
	TEXTURE_LIGHTING_MODE_HP			= 0x8167
	TEXTURE_POST_SPECULAR_HP			= 0x8168
	TEXTURE_PRE_SPECULAR_HP				= 0x8169

###############################################################################

# Extension #112
EXT_draw_range_elements enum:
	MAX_ELEMENTS_VERTICES_EXT			= 0x80E8
	MAX_ELEMENTS_INDICES_EXT			= 0x80E9

###############################################################################

# Extension #113
WIN_phong_shading enum:
	PHONG_WIN					= 0x80EA
	PHONG_HINT_WIN					= 0x80EB

###############################################################################

# Extension #114
WIN_specular_fog enum:
	FOG_SPECULAR_TEXTURE_WIN			= 0x80EC

###############################################################################

# Extension #115 - skipped
# Extension #116 - skipped

###############################################################################

# Extension #117
EXT_light_texture enum:
	FRAGMENT_MATERIAL_EXT				= 0x8349
	FRAGMENT_NORMAL_EXT				= 0x834A
	FRAGMENT_COLOR_EXT				= 0x834C
	ATTENUATION_EXT					= 0x834D
	SHADOW_ATTENUATION_EXT				= 0x834E
	TEXTURE_APPLICATION_MODE_EXT			= 0x834F # 1 I
	TEXTURE_LIGHT_EXT				= 0x8350 # 1 I
	TEXTURE_MATERIAL_FACE_EXT			= 0x8351 # 1 I
	TEXTURE_MATERIAL_PARAMETER_EXT			= 0x8352 # 1 I
	use EXT_fog_coord FRAGMENT_DEPTH_EXT

###############################################################################

# Extension #118 - skipped

###############################################################################

# Extension #119
SGIX_blend_alpha_minmax enum:
	ALPHA_MIN_SGIX					= 0x8320
	ALPHA_MAX_SGIX					= 0x8321

###############################################################################

# Extension #120 - skipped
# Extension #121 - skipped
# Extension #122 - skipped
# Extension #123 - skipped
# Extension #124 - skipped
# Extension #125 - skipped

###############################################################################

# Extension #126
SGIX_impact_pixel_texture enum:
	PIXEL_TEX_GEN_Q_CEILING_SGIX			= 0x8184
	PIXEL_TEX_GEN_Q_ROUND_SGIX			= 0x8185
	PIXEL_TEX_GEN_Q_FLOOR_SGIX			= 0x8186
	PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX		= 0x8187
	PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX		= 0x8188
	PIXEL_TEX_GEN_ALPHA_LS_SGIX			= 0x8189
	PIXEL_TEX_GEN_ALPHA_MS_SGIX			= 0x818A

###############################################################################

# Extension #127 - skipped
# Extension #128 - skipped

###############################################################################

# Extension #129
EXT_bgra enum:
	BGR_EXT						= 0x80E0
	BGRA_EXT					= 0x80E1

###############################################################################

# Extension #130 - skipped
# Extension #131 - skipped

###############################################################################

# Extension #132
SGIX_async enum:
	ASYNC_MARKER_SGIX				= 0x8329

###############################################################################

# Extension #133
SGIX_async_pixel enum:
	ASYNC_TEX_IMAGE_SGIX				= 0x835C
	ASYNC_DRAW_PIXELS_SGIX				= 0x835D
	ASYNC_READ_PIXELS_SGIX				= 0x835E
	MAX_ASYNC_TEX_IMAGE_SGIX			= 0x835F
	MAX_ASYNC_DRAW_PIXELS_SGIX			= 0x8360
	MAX_ASYNC_READ_PIXELS_SGIX			= 0x8361

###############################################################################

# Extension #134
SGIX_async_histogram enum:
	ASYNC_HISTOGRAM_SGIX				= 0x832C
	MAX_ASYNC_HISTOGRAM_SGIX			= 0x832D

###############################################################################

# Intel has not implemented this; enums never assigned
# Extension #135
INTEL_texture_scissor enum:
#	 TEXTURE_SCISSOR_INTEL				 = 0x????
#	 TEXTURE_SCISSOR_INTEL				 = 0x????
#	 TEXTURE_SCISSOR_FUNC_INTEL			 = 0x????
#	 TEXTURE_SCISSOR_S_INTEL			 = 0x????
#	 TEXTURE_SCISSOR_T_INTEL			 = 0x????
#	 TEXTURE_SCISSOR_R_INTEL			 = 0x????

###############################################################################

# Extension #136
INTEL_parallel_arrays enum:
	PARALLEL_ARRAYS_INTEL				= 0x83F4
	VERTEX_ARRAY_PARALLEL_POINTERS_INTEL		= 0x83F5
	NORMAL_ARRAY_PARALLEL_POINTERS_INTEL		= 0x83F6
	COLOR_ARRAY_PARALLEL_POINTERS_INTEL		= 0x83F7
	TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL	= 0x83F8

###############################################################################

# Extension #137
HP_occlusion_test enum:
	OCCLUSION_TEST_HP				= 0x8165
	OCCLUSION_TEST_RESULT_HP			= 0x8166

###############################################################################

# Extension #138
EXT_pixel_transform enum:
	PIXEL_TRANSFORM_2D_EXT				= 0x8330
	PIXEL_MAG_FILTER_EXT				= 0x8331
	PIXEL_MIN_FILTER_EXT				= 0x8332
	PIXEL_CUBIC_WEIGHT_EXT				= 0x8333
	CUBIC_EXT					= 0x8334
	AVERAGE_EXT					= 0x8335
	PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT		= 0x8336
	MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT		= 0x8337
	PIXEL_TRANSFORM_2D_MATRIX_EXT			= 0x8338

###############################################################################

# Unknown enum values
# Extension #139
EXT_pixel_transform_color_table enum:

#	 PIXEL_TRANSFORM_COLOR_TABLE_EXT
#	 PROXY_PIXEL_TRANSFORM_COLOR_TABLE_EXT

###############################################################################

# Extension #140 - skipped

###############################################################################

# Extension #141
EXT_shared_texture_palette enum:
	SHARED_TEXTURE_PALETTE_EXT			= 0x81FB

###############################################################################

# Extension #142 - GLX_SGIS_blended_overlay

###############################################################################

# Extension #143 - SGIS_shared_multisample
#	MULTISAMPLE_SUB_RECT_POSITION_SGIS		= <TBD>
#	MULTISAMPLE_SUB_RECT_DIMS_SGIS			= <TBD>

###############################################################################

# Extension #144
EXT_separate_specular_color enum:
	LIGHT_MODEL_COLOR_CONTROL_EXT			= 0x81F8
	SINGLE_COLOR_EXT				= 0x81F9
	SEPARATE_SPECULAR_COLOR_EXT			= 0x81FA

###############################################################################

# Extension #145
EXT_secondary_color enum:
	COLOR_SUM_EXT					= 0x8458 # 1 I
	CURRENT_SECONDARY_COLOR_EXT			= 0x8459 # 3 F
	SECONDARY_COLOR_ARRAY_SIZE_EXT			= 0x845A # 1 I
	SECONDARY_COLOR_ARRAY_TYPE_EXT			= 0x845B # 1 I
	SECONDARY_COLOR_ARRAY_STRIDE_EXT		= 0x845C # 1 I
	SECONDARY_COLOR_ARRAY_POINTER_EXT		= 0x845D
	SECONDARY_COLOR_ARRAY_EXT			= 0x845E # 1 I

###############################################################################

# Dead extension - EXT_texture_env_combine was finished instead
# Extension #146
#EXT_texture_env enum:

###############################################################################

# Extension #147
EXT_texture_perturb_normal enum:
	PERTURB_EXT					= 0x85AE
	TEXTURE_NORMAL_EXT				= 0x85AF

###############################################################################

# No new tokens
# Extension #148
# Diamond ships an otherwise identical IBM_multi_draw_arrays extension;
#  Dan Brokenshire says this is deprecated and should not be advertised.
EXT_multi_draw_arrays enum:

###############################################################################

# Extension #149
EXT_fog_coord enum:
	FOG_COORDINATE_SOURCE_EXT			= 0x8450 # 1 I
	FOG_COORDINATE_EXT				= 0x8451
	FRAGMENT_DEPTH_EXT				= 0x8452
	CURRENT_FOG_COORDINATE_EXT			= 0x8453 # 1 F
	FOG_COORDINATE_ARRAY_TYPE_EXT			= 0x8454 # 1 I
	FOG_COORDINATE_ARRAY_STRIDE_EXT			= 0x8455 # 1 I
	FOG_COORDINATE_ARRAY_POINTER_EXT		= 0x8456
	FOG_COORDINATE_ARRAY_EXT			= 0x8457 # 1 I

###############################################################################

# Extension #150 - skipped
# Extension #151 - skipped
# Extension #152 - skipped
# Extension #153 - skipped
# Extension #154 - skipped

###############################################################################

# Extension #155
REND_screen_coordinates enum:
	SCREEN_COORDINATES_REND				= 0x8490
	INVERTED_SCREEN_W_REND				= 0x8491

###############################################################################

# Extension #156
EXT_coordinate_frame enum:
	TANGENT_ARRAY_EXT				= 0x8439
	BINORMAL_ARRAY_EXT				= 0x843A
	CURRENT_TANGENT_EXT				= 0x843B
	CURRENT_BINORMAL_EXT				= 0x843C
	TANGENT_ARRAY_TYPE_EXT				= 0x843E
	TANGENT_ARRAY_STRIDE_EXT			= 0x843F
	BINORMAL_ARRAY_TYPE_EXT				= 0x8440
	BINORMAL_ARRAY_STRIDE_EXT			= 0x8441
	TANGENT_ARRAY_POINTER_EXT			= 0x8442
	BINORMAL_ARRAY_POINTER_EXT			= 0x8443
	MAP1_TANGENT_EXT				= 0x8444
	MAP2_TANGENT_EXT				= 0x8445
	MAP1_BINORMAL_EXT				= 0x8446
	MAP2_BINORMAL_EXT				= 0x8447

###############################################################################

# Extension #157 - skipped

###############################################################################

# Extension #158
EXT_texture_env_combine enum:
	COMBINE_EXT					= 0x8570
	COMBINE_RGB_EXT					= 0x8571
	COMBINE_ALPHA_EXT				= 0x8572
	RGB_SCALE_EXT					= 0x8573
	ADD_SIGNED_EXT					= 0x8574
	INTERPOLATE_EXT					= 0x8575
	CONSTANT_EXT					= 0x8576
	PRIMARY_COLOR_EXT				= 0x8577
	PREVIOUS_EXT					= 0x8578
	SOURCE0_RGB_EXT					= 0x8580
	SOURCE1_RGB_EXT					= 0x8581
	SOURCE2_RGB_EXT					= 0x8582
	SOURCE0_ALPHA_EXT				= 0x8588
	SOURCE1_ALPHA_EXT				= 0x8589
	SOURCE2_ALPHA_EXT				= 0x858A
	OPERAND0_RGB_EXT				= 0x8590
	OPERAND1_RGB_EXT				= 0x8591
	OPERAND2_RGB_EXT				= 0x8592
	OPERAND0_ALPHA_EXT				= 0x8598
	OPERAND1_ALPHA_EXT				= 0x8599
	OPERAND2_ALPHA_EXT				= 0x859A

###############################################################################

# Extension #159
APPLE_specular_vector enum:
	LIGHT_MODEL_SPECULAR_VECTOR_APPLE		= 0x85B0

###############################################################################

# Extension #160
APPLE_transform_hint enum:
	TRANSFORM_HINT_APPLE				= 0x85B1

###############################################################################

# Extension #161
SGIX_fog_scale enum:
	FOG_SCALE_SGIX					= 0x81FC
	FOG_SCALE_VALUE_SGIX				= 0x81FD

###############################################################################

# Extension #162 - skipped

###############################################################################

# Extension #163
SUNX_constant_data enum:
	UNPACK_CONSTANT_DATA_SUNX			= 0x81D5
	TEXTURE_CONSTANT_DATA_SUNX			= 0x81D6

###############################################################################

# Extension #164
SUN_global_alpha enum:
	GLOBAL_ALPHA_SUN				= 0x81D9
	GLOBAL_ALPHA_FACTOR_SUN				= 0x81DA

###############################################################################

# Extension #165
SUN_triangle_list enum:
	RESTART_SUN					= 0x0001
	REPLACE_MIDDLE_SUN				= 0x0002
	REPLACE_OLDEST_SUN				= 0x0003
	TRIANGLE_LIST_SUN				= 0x81D7
	REPLACEMENT_CODE_SUN				= 0x81D8
	REPLACEMENT_CODE_ARRAY_SUN			= 0x85C0
	REPLACEMENT_CODE_ARRAY_TYPE_SUN			= 0x85C1
	REPLACEMENT_CODE_ARRAY_STRIDE_SUN		= 0x85C2
	REPLACEMENT_CODE_ARRAY_POINTER_SUN		= 0x85C3
	R1UI_V3F_SUN					= 0x85C4
	R1UI_C4UB_V3F_SUN				= 0x85C5
	R1UI_C3F_V3F_SUN				= 0x85C6
	R1UI_N3F_V3F_SUN				= 0x85C7
	R1UI_C4F_N3F_V3F_SUN				= 0x85C8
	R1UI_T2F_V3F_SUN				= 0x85C9
	R1UI_T2F_N3F_V3F_SUN				= 0x85CA
	R1UI_T2F_C4F_N3F_V3F_SUN			= 0x85CB

###############################################################################

# No new tokens
# Extension #166
SUN_vertex enum:

###############################################################################

# Extension #167 - WGL_EXT_display_color_table
# Extension #168 - WGL_EXT_extensions_string
# Extension #169 - WGL_EXT_make_current_read
# Extension #170 - WGL_EXT_pixel_format
# Extension #171 - WGL_EXT_pbuffer
# Extension #172 - WGL_EXT_swap_control

###############################################################################

# Extension #173
EXT_blend_func_separate enum:
	BLEND_DST_RGB_EXT				= 0x80C8
	BLEND_SRC_RGB_EXT				= 0x80C9
	BLEND_DST_ALPHA_EXT				= 0x80CA
	BLEND_SRC_ALPHA_EXT				= 0x80CB

###############################################################################

# Extension #174
INGR_color_clamp enum:
	RED_MIN_CLAMP_INGR				= 0x8560
	GREEN_MIN_CLAMP_INGR				= 0x8561
	BLUE_MIN_CLAMP_INGR				= 0x8562
	ALPHA_MIN_CLAMP_INGR				= 0x8563
	RED_MAX_CLAMP_INGR				= 0x8564
	GREEN_MAX_CLAMP_INGR				= 0x8565
	BLUE_MAX_CLAMP_INGR				= 0x8566
	ALPHA_MAX_CLAMP_INGR				= 0x8567

###############################################################################

# Extension #175
INGR_interlace_read enum:
	INTERLACE_READ_INGR				= 0x8568

###############################################################################

# Extension #176
EXT_stencil_wrap enum:
	INCR_WRAP_EXT					= 0x8507
	DECR_WRAP_EXT					= 0x8508

###############################################################################

# Extension #177 - skipped

###############################################################################

# Extension #178
EXT_422_pixels enum:
	422_EXT						= 0x80CC
	422_REV_EXT					= 0x80CD
	422_AVERAGE_EXT					= 0x80CE
	422_REV_AVERAGE_EXT				= 0x80CF

###############################################################################

# Extension #179
NV_texgen_reflection enum:
	NORMAL_MAP_NV					= 0x8511
	REFLECTION_MAP_NV				= 0x8512

###############################################################################

# Extension #180 - skipped
# Extension #181 - skipped

###############################################################################

# Is this shipping? No extension number assigned.
# Extension #?
EXT_texture_cube_map enum:
	NORMAL_MAP_EXT					= 0x8511
	REFLECTION_MAP_EXT				= 0x8512
	TEXTURE_CUBE_MAP_EXT				= 0x8513
	TEXTURE_BINDING_CUBE_MAP_EXT			= 0x8514
	TEXTURE_CUBE_MAP_POSITIVE_X_EXT			= 0x8515
	TEXTURE_CUBE_MAP_NEGATIVE_X_EXT			= 0x8516
	TEXTURE_CUBE_MAP_POSITIVE_Y_EXT			= 0x8517
	TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT			= 0x8518
	TEXTURE_CUBE_MAP_POSITIVE_Z_EXT			= 0x8519
	TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT			= 0x851A
	PROXY_TEXTURE_CUBE_MAP_EXT			= 0x851B
	MAX_CUBE_MAP_TEXTURE_SIZE_EXT			= 0x851C

###############################################################################

# Extension #182
SUN_convolution_border_modes enum:
	WRAP_BORDER_SUN					= 0x81D4

###############################################################################

# Extension #183 - GLX_SUN_transparent_index

###############################################################################

# Extension #184 - skipped

###############################################################################

# No new tokens
# Extension #185
EXT_texture_env_add enum:

###############################################################################

# Extension #186
EXT_texture_lod_bias enum:
	MAX_TEXTURE_LOD_BIAS_EXT			= 0x84FD
	TEXTURE_FILTER_CONTROL_EXT			= 0x8500
	TEXTURE_LOD_BIAS_EXT				= 0x8501

###############################################################################

# Extension #187
EXT_texture_filter_anisotropic enum:
	TEXTURE_MAX_ANISOTROPY_EXT			= 0x84FE
	MAX_TEXTURE_MAX_ANISOTROPY_EXT			= 0x84FF

###############################################################################

# Extension #188
EXT_vertex_weighting enum:
	MODELVIEW0_STACK_DEPTH_EXT			= GL_MODELVIEW_STACK_DEPTH
	MODELVIEW1_STACK_DEPTH_EXT			= 0x8502
	MODELVIEW0_MATRIX_EXT				= GL_MODELVIEW_MATRIX
	MODELVIEW1_MATRIX_EXT				= 0x8506
	VERTEX_WEIGHTING_EXT				= 0x8509
	MODELVIEW0_EXT					= GL_MODELVIEW
	MODELVIEW1_EXT					= 0x850A
	CURRENT_VERTEX_WEIGHT_EXT			= 0x850B
	VERTEX_WEIGHT_ARRAY_EXT				= 0x850C
	VERTEX_WEIGHT_ARRAY_SIZE_EXT			= 0x850D
	VERTEX_WEIGHT_ARRAY_TYPE_EXT			= 0x850E
	VERTEX_WEIGHT_ARRAY_STRIDE_EXT			= 0x850F
	VERTEX_WEIGHT_ARRAY_POINTER_EXT			= 0x8510

###############################################################################

# Extension #189
NV_light_max_exponent enum:
	MAX_SHININESS_NV				= 0x8504
	MAX_SPOT_EXPONENT_NV				= 0x8505

###############################################################################

# Extension #190
NV_vertex_array_range enum:
	VERTEX_ARRAY_RANGE_NV				= 0x851D
	VERTEX_ARRAY_RANGE_LENGTH_NV			= 0x851E
	VERTEX_ARRAY_RANGE_VALID_NV			= 0x851F
	MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV		= 0x8520
	VERTEX_ARRAY_RANGE_POINTER_NV			= 0x8521

###############################################################################

# Extension #191
NV_register_combiners enum:
	REGISTER_COMBINERS_NV				= 0x8522
	VARIABLE_A_NV					= 0x8523
	VARIABLE_B_NV					= 0x8524
	VARIABLE_C_NV					= 0x8525
	VARIABLE_D_NV					= 0x8526
	VARIABLE_E_NV					= 0x8527
	VARIABLE_F_NV					= 0x8528
	VARIABLE_G_NV					= 0x8529
	CONSTANT_COLOR0_NV				= 0x852A
	CONSTANT_COLOR1_NV				= 0x852B
	PRIMARY_COLOR_NV				= 0x852C
	SECONDARY_COLOR_NV				= 0x852D
	SPARE0_NV					= 0x852E
	SPARE1_NV					= 0x852F
	DISCARD_NV					= 0x8530
	E_TIMES_F_NV					= 0x8531
	SPARE0_PLUS_SECONDARY_COLOR_NV			= 0x8532
	UNSIGNED_IDENTITY_NV				= 0x8536
	UNSIGNED_INVERT_NV				= 0x8537
	EXPAND_NORMAL_NV				= 0x8538
	EXPAND_NEGATE_NV				= 0x8539
	HALF_BIAS_NORMAL_NV				= 0x853A
	HALF_BIAS_NEGATE_NV				= 0x853B
	SIGNED_IDENTITY_NV				= 0x853C
	SIGNED_NEGATE_NV				= 0x853D
	SCALE_BY_TWO_NV					= 0x853E
	SCALE_BY_FOUR_NV				= 0x853F
	SCALE_BY_ONE_HALF_NV				= 0x8540
	BIAS_BY_NEGATIVE_ONE_HALF_NV			= 0x8541
	COMBINER_INPUT_NV				= 0x8542
	COMBINER_MAPPING_NV				= 0x8543
	COMBINER_COMPONENT_USAGE_NV			= 0x8544
	COMBINER_AB_DOT_PRODUCT_NV			= 0x8545
	COMBINER_CD_DOT_PRODUCT_NV			= 0x8546
	COMBINER_MUX_SUM_NV				= 0x8547
	COMBINER_SCALE_NV				= 0x8548
	COMBINER_BIAS_NV				= 0x8549
	COMBINER_AB_OUTPUT_NV				= 0x854A
	COMBINER_CD_OUTPUT_NV				= 0x854B
	COMBINER_SUM_OUTPUT_NV				= 0x854C
	MAX_GENERAL_COMBINERS_NV			= 0x854D
	NUM_GENERAL_COMBINERS_NV			= 0x854E
	COLOR_SUM_CLAMP_NV				= 0x854F
	COMBINER0_NV					= 0x8550
	COMBINER1_NV					= 0x8551
	COMBINER2_NV					= 0x8552
	COMBINER3_NV					= 0x8553
	COMBINER4_NV					= 0x8554
	COMBINER5_NV					= 0x8555
	COMBINER6_NV					= 0x8556
	COMBINER7_NV					= 0x8557
	use ARB_multitexture TEXTURE0_ARB
	use ARB_multitexture TEXTURE1_ARB
	use BlendingFactorDest ZERO
	use DrawBufferMode NONE
	use GetPName FOG

###############################################################################

# Extension #192
NV_fog_distance enum:
	FOG_DISTANCE_MODE_NV				= 0x855A
	EYE_RADIAL_NV					= 0x855B
	EYE_PLANE_ABSOLUTE_NV				= 0x855C
	use TextureGenParameter EYE_PLANE

###############################################################################

# Extension #193
NV_texgen_emboss enum:
	EMBOSS_LIGHT_NV					= 0x855D
	EMBOSS_CONSTANT_NV				= 0x855E
	EMBOSS_MAP_NV					= 0x855F

###############################################################################

# No new tokens
# Extension #194
NV_blend_square enum:

###############################################################################

# Extension #195
NV_texture_env_combine4 enum:
	COMBINE4_NV					= 0x8503
	SOURCE3_RGB_NV					= 0x8583
	SOURCE3_ALPHA_NV				= 0x858B
	OPERAND3_RGB_NV					= 0x8593
	OPERAND3_ALPHA_NV				= 0x859B

###############################################################################

# No new tokens
# Extension #196
MESA_resize_buffers enum:

###############################################################################

# No new tokens
# Extension #197
MESA_window_pos enum:

###############################################################################

# Extension #198
EXT_texture_compression_s3tc enum:
	COMPRESSED_RGB_S3TC_DXT1_EXT			= 0x83F0
	COMPRESSED_RGBA_S3TC_DXT1_EXT			= 0x83F1
	COMPRESSED_RGBA_S3TC_DXT3_EXT			= 0x83F2
	COMPRESSED_RGBA_S3TC_DXT5_EXT			= 0x83F3

###############################################################################

# Extension #199
IBM_cull_vertex enum:
	CULL_VERTEX_IBM					= 103050

###############################################################################

# No new tokens
# Extension #200
IBM_multimode_draw_arrays enum:

###############################################################################

# Extension #201
IBM_vertex_array_lists enum:
	VERTEX_ARRAY_LIST_IBM				= 103070
	NORMAL_ARRAY_LIST_IBM				= 103071
	COLOR_ARRAY_LIST_IBM				= 103072
	INDEX_ARRAY_LIST_IBM				= 103073
	TEXTURE_COORD_ARRAY_LIST_IBM			= 103074
	EDGE_FLAG_ARRAY_LIST_IBM			= 103075
	FOG_COORDINATE_ARRAY_LIST_IBM			= 103076
	SECONDARY_COLOR_ARRAY_LIST_IBM			= 103077
	VERTEX_ARRAY_LIST_STRIDE_IBM			= 103080
	NORMAL_ARRAY_LIST_STRIDE_IBM			= 103081
	COLOR_ARRAY_LIST_STRIDE_IBM			= 103082
	INDEX_ARRAY_LIST_STRIDE_IBM			= 103083
	TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM		= 103084
	EDGE_FLAG_ARRAY_LIST_STRIDE_IBM			= 103085
	FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM		= 103086
	SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM		= 103087

###############################################################################

# Extension #202
SGIX_subsample enum:
	PACK_SUBSAMPLE_RATE_SGIX			= 0x85A0
	UNPACK_SUBSAMPLE_RATE_SGIX			= 0x85A1
	PIXEL_SUBSAMPLE_4444_SGIX			= 0x85A2
	PIXEL_SUBSAMPLE_2424_SGIX			= 0x85A3
	PIXEL_SUBSAMPLE_4242_SGIX			= 0x85A4

###############################################################################

# Extension #203
SGIX_ycrcb_subsample enum:
	PACK_SUBSAMPLE_RATE_SGIX			= 0x85A0
	UNPACK_SUBSAMPLE_RATE_SGIX			= 0x85A1
	PIXEL_SUBSAMPLE_4444_SGIX			= 0x85A2
	PIXEL_SUBSAMPLE_2424_SGIX			= 0x85A3
	PIXEL_SUBSAMPLE_4242_SGIX			= 0x85A4

###############################################################################

# Extension #204
SGIX_ycrcba enum:
	YCRCB_SGIX					= 0x8318
	YCRCBA_SGIX					= 0x8319

###############################################################################

# Extension #205
SGI_depth_pass_instrument enum:
	DEPTH_PASS_INSTRUMENT_SGIX			= 0x8310
	DEPTH_PASS_INSTRUMENT_COUNTERS_SGIX		= 0x8311
	DEPTH_PASS_INSTRUMENT_MAX_SGIX			= 0x8312

###############################################################################

# Extension #206
3DFX_texture_compression_FXT1 enum:
	COMPRESSED_RGB_FXT1_3DFX			= 0x86B0
	COMPRESSED_RGBA_FXT1_3DFX			= 0x86B1

###############################################################################

# Extension #207
3DFX_multisample enum:
	MULTISAMPLE_3DFX				= 0x86B2
	SAMPLE_BUFFERS_3DFX				= 0x86B3
	SAMPLES_3DFX					= 0x86B4
	MULTISAMPLE_BIT_3DFX				= 0x20000000

###############################################################################

# No new tokens
# Extension #208
3DFX_tbuffer enum:

###############################################################################

# Extension #209
EXT_multisample enum:
	MULTISAMPLE_EXT					= 0x809D
	SAMPLE_ALPHA_TO_MASK_EXT			= 0x809E
	SAMPLE_ALPHA_TO_ONE_EXT				= 0x809F
	SAMPLE_MASK_EXT					= 0x80A0
	1PASS_EXT					= 0x80A1
	2PASS_0_EXT					= 0x80A2
	2PASS_1_EXT					= 0x80A3
	4PASS_0_EXT					= 0x80A4
	4PASS_1_EXT					= 0x80A5
	4PASS_2_EXT					= 0x80A6
	4PASS_3_EXT					= 0x80A7
	SAMPLE_BUFFERS_EXT				= 0x80A8 # 1 I
	SAMPLES_EXT					= 0x80A9 # 1 I
	SAMPLE_MASK_VALUE_EXT				= 0x80AA # 1 F
	SAMPLE_MASK_INVERT_EXT				= 0x80AB # 1 I
	SAMPLE_PATTERN_EXT				= 0x80AC # 1 I
	MULTISAMPLE_BIT_EXT				= 0x20000000

###############################################################################

# Extension #210
SGIX_vertex_preclip enum:
	VERTEX_PRECLIP_SGIX				= 0x83EE
	VERTEX_PRECLIP_HINT_SGIX			= 0x83EF

###############################################################################

# Extension #211
SGIX_convolution_accuracy enum:
	CONVOLUTION_HINT_SGIX				= 0x8316 # 1 I

###############################################################################

# Extension #212
SGIX_resample enum:
	PACK_RESAMPLE_SGIX				= 0x842C
	UNPACK_RESAMPLE_SGIX				= 0x842D
	RESAMPLE_REPLICATE_SGIX				= 0x842E
	RESAMPLE_ZERO_FILL_SGIX				= 0x842F
	RESAMPLE_DECIMATE_SGIX				= 0x8430

###############################################################################

# Extension #213
SGIS_point_line_texgen enum:
	EYE_DISTANCE_TO_POINT_SGIS			= 0x81F0
	OBJECT_DISTANCE_TO_POINT_SGIS			= 0x81F1
	EYE_DISTANCE_TO_LINE_SGIS			= 0x81F2
	OBJECT_DISTANCE_TO_LINE_SGIS			= 0x81F3
	EYE_POINT_SGIS					= 0x81F4
	OBJECT_POINT_SGIS				= 0x81F5
	EYE_LINE_SGIS					= 0x81F6
	OBJECT_LINE_SGIS				= 0x81F7

###############################################################################

# Extension #214
SGIS_texture_color_mask enum:
	TEXTURE_COLOR_WRITEMASK_SGIS			= 0x81EF

###############################################################################

# Extension #220
# Promoted to ARB_texture_env_dot3, enum values changed
EXT_texture_env_dot3 enum:
	DOT3_RGB_EXT					= 0x8740
	DOT3_RGBA_EXT					= 0x8741

###############################################################################

# Extension #221
ATI_texture_mirror_once enum:
	MIRROR_CLAMP_ATI				= 0x8742
	MIRROR_CLAMP_TO_EDGE_ATI			= 0x8743

###############################################################################

# Extension #222
NV_fence enum:
	ALL_COMPLETED_NV				= 0x84F2
	FENCE_STATUS_NV					= 0x84F3
	FENCE_CONDITION_NV				= 0x84F4

###############################################################################

# Extension #224
IBM_texture_mirrored_repeat enum:
	MIRRORED_REPEAT_IBM				= 0x8370

###############################################################################

# Extension #225
NV_evaluators enum:
	EVAL_2D_NV					= 0x86C0
	EVAL_TRIANGULAR_2D_NV				= 0x86C1
	MAP_TESSELLATION_NV				= 0x86C2
	MAP_ATTRIB_U_ORDER_NV				= 0x86C3
	MAP_ATTRIB_V_ORDER_NV				= 0x86C4
	EVAL_FRACTIONAL_TESSELLATION_NV			= 0x86C5
	EVAL_VERTEX_ATTRIB0_NV				= 0x86C6
	EVAL_VERTEX_ATTRIB1_NV				= 0x86C7
	EVAL_VERTEX_ATTRIB2_NV				= 0x86C8
	EVAL_VERTEX_ATTRIB3_NV				= 0x86C9
	EVAL_VERTEX_ATTRIB4_NV				= 0x86CA
	EVAL_VERTEX_ATTRIB5_NV				= 0x86CB
	EVAL_VERTEX_ATTRIB6_NV				= 0x86CC
	EVAL_VERTEX_ATTRIB7_NV				= 0x86CD
	EVAL_VERTEX_ATTRIB8_NV				= 0x86CE
	EVAL_VERTEX_ATTRIB9_NV				= 0x86CF
	EVAL_VERTEX_ATTRIB10_NV				= 0x86D0
	EVAL_VERTEX_ATTRIB11_NV				= 0x86D1
	EVAL_VERTEX_ATTRIB12_NV				= 0x86D2
	EVAL_VERTEX_ATTRIB13_NV				= 0x86D3
	EVAL_VERTEX_ATTRIB14_NV				= 0x86D4
	EVAL_VERTEX_ATTRIB15_NV				= 0x86D5
	MAX_MAP_TESSELLATION_NV				= 0x86D6
	MAX_RATIONAL_EVAL_ORDER_NV			= 0x86D7

###############################################################################

# Extension #226
NV_packed_depth_stencil enum:
	DEPTH_STENCIL_NV				= 0x84F9
	UNSIGNED_INT_24_8_NV				= 0x84FA

###############################################################################

# Extension #227
NV_register_combiners2 enum:
	PER_STAGE_CONSTANTS_NV				= 0x8535

###############################################################################

# No new tokens
# Extension #228
NV_texture_compression_vtc enum:

###############################################################################

# Extension #229
NV_texture_rectangle enum:
	TEXTURE_RECTANGLE_NV				= 0x84F5
	TEXTURE_BINDING_RECTANGLE_NV			= 0x84F6
	PROXY_TEXTURE_RECTANGLE_NV			= 0x84F7
	MAX_RECTANGLE_TEXTURE_SIZE_NV			= 0x84F8

###############################################################################

# Extension #230
NV_texture_shader enum:
	OFFSET_TEXTURE_RECTANGLE_NV			= 0x864C
	OFFSET_TEXTURE_RECTANGLE_SCALE_NV		= 0x864D
	DOT_PRODUCT_TEXTURE_RECTANGLE_NV		= 0x864E
	RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV		= 0x86D9
	UNSIGNED_INT_S8_S8_8_8_NV			= 0x86DA
	UNSIGNED_INT_8_8_S8_S8_REV_NV			= 0x86DB
	DSDT_MAG_INTENSITY_NV				= 0x86DC
	SHADER_CONSISTENT_NV				= 0x86DD
	TEXTURE_SHADER_NV				= 0x86DE
	SHADER_OPERATION_NV				= 0x86DF
	CULL_MODES_NV					= 0x86E0
	OFFSET_TEXTURE_MATRIX_NV			= 0x86E1
	OFFSET_TEXTURE_SCALE_NV				= 0x86E2
	OFFSET_TEXTURE_BIAS_NV				= 0x86E3
	OFFSET_TEXTURE_2D_MATRIX_NV			= GL_OFFSET_TEXTURE_MATRIX_NV
	OFFSET_TEXTURE_2D_SCALE_NV			= GL_OFFSET_TEXTURE_SCALE_NV
	OFFSET_TEXTURE_2D_BIAS_NV			= GL_OFFSET_TEXTURE_BIAS_NV
	PREVIOUS_TEXTURE_INPUT_NV			= 0x86E4
	CONST_EYE_NV					= 0x86E5
	PASS_THROUGH_NV					= 0x86E6
	CULL_FRAGMENT_NV				= 0x86E7
	OFFSET_TEXTURE_2D_NV				= 0x86E8
	DEPENDENT_AR_TEXTURE_2D_NV			= 0x86E9
	DEPENDENT_GB_TEXTURE_2D_NV			= 0x86EA
	DOT_PRODUCT_NV					= 0x86EC
	DOT_PRODUCT_DEPTH_REPLACE_NV			= 0x86ED
	DOT_PRODUCT_TEXTURE_2D_NV			= 0x86EE
	DOT_PRODUCT_TEXTURE_CUBE_MAP_NV			= 0x86F0
	DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV			= 0x86F1
	DOT_PRODUCT_REFLECT_CUBE_MAP_NV			= 0x86F2
	DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV	= 0x86F3
	HILO_NV						= 0x86F4
	DSDT_NV						= 0x86F5
	DSDT_MAG_NV					= 0x86F6
	DSDT_MAG_VIB_NV					= 0x86F7
	HILO16_NV					= 0x86F8
	SIGNED_HILO_NV					= 0x86F9
	SIGNED_HILO16_NV				= 0x86FA
	SIGNED_RGBA_NV					= 0x86FB
	SIGNED_RGBA8_NV					= 0x86FC
	SIGNED_RGB_NV					= 0x86FE
	SIGNED_RGB8_NV					= 0x86FF
	SIGNED_LUMINANCE_NV				= 0x8701
	SIGNED_LUMINANCE8_NV				= 0x8702
	SIGNED_LUMINANCE_ALPHA_NV			= 0x8703
	SIGNED_LUMINANCE8_ALPHA8_NV			= 0x8704
	SIGNED_ALPHA_NV					= 0x8705
	SIGNED_ALPHA8_NV				= 0x8706
	SIGNED_INTENSITY_NV				= 0x8707
	SIGNED_INTENSITY8_NV				= 0x8708
	DSDT8_NV					= 0x8709
	DSDT8_MAG8_NV					= 0x870A
	DSDT8_MAG8_INTENSITY8_NV			= 0x870B
	SIGNED_RGB_UNSIGNED_ALPHA_NV			= 0x870C
	SIGNED_RGB8_UNSIGNED_ALPHA8_NV			= 0x870D
	HI_SCALE_NV					= 0x870E
	LO_SCALE_NV					= 0x870F
	DS_SCALE_NV					= 0x8710
	DT_SCALE_NV					= 0x8711
	MAGNITUDE_SCALE_NV				= 0x8712
	VIBRANCE_SCALE_NV				= 0x8713
	HI_BIAS_NV					= 0x8714
	LO_BIAS_NV					= 0x8715
	DS_BIAS_NV					= 0x8716
	DT_BIAS_NV					= 0x8717
	MAGNITUDE_BIAS_NV				= 0x8718
	VIBRANCE_BIAS_NV				= 0x8719
	TEXTURE_BORDER_VALUES_NV			= 0x871A
	TEXTURE_HI_SIZE_NV				= 0x871B
	TEXTURE_LO_SIZE_NV				= 0x871C
	TEXTURE_DS_SIZE_NV				= 0x871D
	TEXTURE_DT_SIZE_NV				= 0x871E
	TEXTURE_MAG_SIZE_NV				= 0x871F

###############################################################################

# Extension #231
NV_texture_shader2 enum:
	DOT_PRODUCT_TEXTURE_3D_NV			= 0x86EF

###############################################################################

# Extension #232
NV_vertex_array_range2 enum:
	VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV		= 0x8533

###############################################################################

# Extension #233
NV_vertex_program enum:
	VERTEX_PROGRAM_NV				= 0x8620
	VERTEX_STATE_PROGRAM_NV				= 0x8621
	ATTRIB_ARRAY_SIZE_NV				= 0x8623
	ATTRIB_ARRAY_STRIDE_NV				= 0x8624
	ATTRIB_ARRAY_TYPE_NV				= 0x8625
	CURRENT_ATTRIB_NV				= 0x8626
	PROGRAM_LENGTH_NV				= 0x8627
	PROGRAM_STRING_NV				= 0x8628
	MODELVIEW_PROJECTION_NV				= 0x8629
	IDENTITY_NV					= 0x862A
	INVERSE_NV					= 0x862B
	TRANSPOSE_NV					= 0x862C
	INVERSE_TRANSPOSE_NV				= 0x862D
	MAX_TRACK_MATRIX_STACK_DEPTH_NV			= 0x862E
	MAX_TRACK_MATRICES_NV				= 0x862F
	MATRIX0_NV					= 0x8630
	MATRIX1_NV					= 0x8631
	MATRIX2_NV					= 0x8632
	MATRIX3_NV					= 0x8633
	MATRIX4_NV					= 0x8634
	MATRIX5_NV					= 0x8635
	MATRIX6_NV					= 0x8636
	MATRIX7_NV					= 0x8637
##################
#
#	Reserved:
#
#	MATRIX8_NV					= 0x8638
#	MATRIX9_NV					= 0x8639
#	MATRIX10_NV					= 0x863A
#	MATRIX11_NV					= 0x863B
#	MATRIX12_NV					= 0x863C
#	MATRIX13_NV					= 0x863D
#	MATRIX14_NV					= 0x863E
#	MATRIX15_NV					= 0x863F
#
###################
	CURRENT_MATRIX_STACK_DEPTH_NV			= 0x8640
	CURRENT_MATRIX_NV				= 0x8641
	VERTEX_PROGRAM_POINT_SIZE_NV			= 0x8642
	VERTEX_PROGRAM_TWO_SIDE_NV			= 0x8643
	PROGRAM_PARAMETER_NV				= 0x8644
	ATTRIB_ARRAY_POINTER_NV				= 0x8645
	PROGRAM_TARGET_NV				= 0x8646
	PROGRAM_RESIDENT_NV				= 0x8647
	TRACK_MATRIX_NV					= 0x8648
	TRACK_MATRIX_TRANSFORM_NV			= 0x8649
	VERTEX_PROGRAM_BINDING_NV			= 0x864A
	PROGRAM_ERROR_POSITION_NV			= 0x864B
	VERTEX_ATTRIB_ARRAY0_NV				= 0x8650
	VERTEX_ATTRIB_ARRAY1_NV				= 0x8651
	VERTEX_ATTRIB_ARRAY2_NV				= 0x8652
	VERTEX_ATTRIB_ARRAY3_NV				= 0x8653
	VERTEX_ATTRIB_ARRAY4_NV				= 0x8654
	VERTEX_ATTRIB_ARRAY5_NV				= 0x8655
	VERTEX_ATTRIB_ARRAY6_NV				= 0x8656
	VERTEX_ATTRIB_ARRAY7_NV				= 0x8657
	VERTEX_ATTRIB_ARRAY8_NV				= 0x8658
	VERTEX_ATTRIB_ARRAY9_NV				= 0x8659
	VERTEX_ATTRIB_ARRAY10_NV			= 0x865A
	VERTEX_ATTRIB_ARRAY11_NV			= 0x865B
	VERTEX_ATTRIB_ARRAY12_NV			= 0x865C
	VERTEX_ATTRIB_ARRAY13_NV			= 0x865D
	VERTEX_ATTRIB_ARRAY14_NV			= 0x865E
	VERTEX_ATTRIB_ARRAY15_NV			= 0x865F
	MAP1_VERTEX_ATTRIB0_4_NV			= 0x8660
	MAP1_VERTEX_ATTRIB1_4_NV			= 0x8661
	MAP1_VERTEX_ATTRIB2_4_NV			= 0x8662
	MAP1_VERTEX_ATTRIB3_4_NV			= 0x8663
	MAP1_VERTEX_ATTRIB4_4_NV			= 0x8664
	MAP1_VERTEX_ATTRIB5_4_NV			= 0x8665
	MAP1_VERTEX_ATTRIB6_4_NV			= 0x8666
	MAP1_VERTEX_ATTRIB7_4_NV			= 0x8667
	MAP1_VERTEX_ATTRIB8_4_NV			= 0x8668
	MAP1_VERTEX_ATTRIB9_4_NV			= 0x8669
	MAP1_VERTEX_ATTRIB10_4_NV			= 0x866A
	MAP1_VERTEX_ATTRIB11_4_NV			= 0x866B
	MAP1_VERTEX_ATTRIB12_4_NV			= 0x866C
	MAP1_VERTEX_ATTRIB13_4_NV			= 0x866D
	MAP1_VERTEX_ATTRIB14_4_NV			= 0x866E
	MAP1_VERTEX_ATTRIB15_4_NV			= 0x866F
	MAP2_VERTEX_ATTRIB0_4_NV			= 0x8670
	MAP2_VERTEX_ATTRIB1_4_NV			= 0x8671
	MAP2_VERTEX_ATTRIB2_4_NV			= 0x8672
	MAP2_VERTEX_ATTRIB3_4_NV			= 0x8673
	MAP2_VERTEX_ATTRIB4_4_NV			= 0x8674
	MAP2_VERTEX_ATTRIB5_4_NV			= 0x8675
	MAP2_VERTEX_ATTRIB6_4_NV			= 0x8676
	MAP2_VERTEX_ATTRIB7_4_NV			= 0x8677
	MAP2_VERTEX_ATTRIB8_4_NV			= 0x8678
	MAP2_VERTEX_ATTRIB9_4_NV			= 0x8679
	MAP2_VERTEX_ATTRIB10_4_NV			= 0x867A
	MAP2_VERTEX_ATTRIB11_4_NV			= 0x867B
	MAP2_VERTEX_ATTRIB12_4_NV			= 0x867C
	MAP2_VERTEX_ATTRIB13_4_NV			= 0x867D
	MAP2_VERTEX_ATTRIB14_4_NV			= 0x867E
	MAP2_VERTEX_ATTRIB15_4_NV			= 0x867F

###############################################################################

# Extension #235
SGIX_texture_coordinate_clamp enum:
	TEXTURE_MAX_CLAMP_S_SGIX			= 0x8369
	TEXTURE_MAX_CLAMP_T_SGIX			= 0x836A
	TEXTURE_MAX_CLAMP_R_SGIX			= 0x836B

###############################################################################

# Extension #236
SGIX_scalebias_hint enum:
	SCALEBIAS_HINT_SGIX				= 0x8322

###############################################################################

# Extension #237 - GLX_OML_swap_method
# Extension #238 - GLX_OML_sync_control

###############################################################################

# Extension #239
OML_interlace enum:
	INTERLACE_OML					= 0x8980
	INTERLACE_READ_OML				= 0x8981

###############################################################################

# Extension #240
OML_subsample enum:
	FORMAT_SUBSAMPLE_24_24_OML			= 0x8982
	FORMAT_SUBSAMPLE_244_244_OML			= 0x8983

###############################################################################

# Extension #241
OML_resample enum:
	PACK_RESAMPLE_OML				= 0x8984
	UNPACK_RESAMPLE_OML				= 0x8985
	RESAMPLE_REPLICATE_OML				= 0x8986
	RESAMPLE_ZERO_FILL_OML				= 0x8987
	RESAMPLE_AVERAGE_OML				= 0x8988
	RESAMPLE_DECIMATE_OML				= 0x8989

###############################################################################

# Extension #242 - WGL_OML_sync_control

###############################################################################

# Extension #243
NV_copy_depth_to_color enum:
	DEPTH_STENCIL_TO_RGBA_NV			= 0x886E
	DEPTH_STENCIL_TO_BGRA_NV			= 0x886F

###############################################################################

# Extension #244
ATI_envmap_bumpmap enum:
	BUMP_ROT_MATRIX_ATI				= 0x8775
	BUMP_ROT_MATRIX_SIZE_ATI			= 0x8776
	BUMP_NUM_TEX_UNITS_ATI				= 0x8777
	BUMP_TEX_UNITS_ATI				= 0x8778
	DUDV_ATI					= 0x8779
	DU8DV8_ATI					= 0x877A
	BUMP_ENVMAP_ATI					= 0x877B
	BUMP_TARGET_ATI					= 0x877C

###############################################################################

# Extension #245
ATI_fragment_shader enum:
	FRAGMENT_SHADER_ATI				= 0x8920
	REG_0_ATI					= 0x8921
	REG_1_ATI					= 0x8922
	REG_2_ATI					= 0x8923
	REG_3_ATI					= 0x8924
	REG_4_ATI					= 0x8925
	REG_5_ATI					= 0x8926
	REG_6_ATI					= 0x8927
	REG_7_ATI					= 0x8928
	REG_8_ATI					= 0x8929
	REG_9_ATI					= 0x892A
	REG_10_ATI					= 0x892B
	REG_11_ATI					= 0x892C
	REG_12_ATI					= 0x892D
	REG_13_ATI					= 0x892E
	REG_14_ATI					= 0x892F
	REG_15_ATI					= 0x8930
	REG_16_ATI					= 0x8931
	REG_17_ATI					= 0x8932
	REG_18_ATI					= 0x8933
	REG_19_ATI					= 0x8934
	REG_20_ATI					= 0x8935
	REG_21_ATI					= 0x8936
	REG_22_ATI					= 0x8937
	REG_23_ATI					= 0x8938
	REG_24_ATI					= 0x8939
	REG_25_ATI					= 0x893A
	REG_26_ATI					= 0x893B
	REG_27_ATI					= 0x893C
	REG_28_ATI					= 0x893D
	REG_29_ATI					= 0x893E
	REG_30_ATI					= 0x893F
	REG_31_ATI					= 0x8940
	CON_0_ATI					= 0x8941
	CON_1_ATI					= 0x8942
	CON_2_ATI					= 0x8943
	CON_3_ATI					= 0x8944
	CON_4_ATI					= 0x8945
	CON_5_ATI					= 0x8946
	CON_6_ATI					= 0x8947
	CON_7_ATI					= 0x8948
	CON_8_ATI					= 0x8949
	CON_9_ATI					= 0x894A
	CON_10_ATI					= 0x894B
	CON_11_ATI					= 0x894C
	CON_12_ATI					= 0x894D
	CON_13_ATI					= 0x894E
	CON_14_ATI					= 0x894F
	CON_15_ATI					= 0x8950
	CON_16_ATI					= 0x8951
	CON_17_ATI					= 0x8952
	CON_18_ATI					= 0x8953
	CON_19_ATI					= 0x8954
	CON_20_ATI					= 0x8955
	CON_21_ATI					= 0x8956
	CON_22_ATI					= 0x8957
	CON_23_ATI					= 0x8958
	CON_24_ATI					= 0x8959
	CON_25_ATI					= 0x895A
	CON_26_ATI					= 0x895B
	CON_27_ATI					= 0x895C
	CON_28_ATI					= 0x895D
	CON_29_ATI					= 0x895E
	CON_30_ATI					= 0x895F
	CON_31_ATI					= 0x8960
	MOV_ATI						= 0x8961
	ADD_ATI						= 0x8963
	MUL_ATI						= 0x8964
	SUB_ATI						= 0x8965
	DOT3_ATI					= 0x8966
	DOT4_ATI					= 0x8967
	MAD_ATI						= 0x8968
	LERP_ATI					= 0x8969
	CND_ATI						= 0x896A
	CND0_ATI					= 0x896B
	DOT2_ADD_ATI					= 0x896C
	SECONDARY_INTERPOLATOR_ATI			= 0x896D
	NUM_FRAGMENT_REGISTERS_ATI			= 0x896E
	NUM_FRAGMENT_CONSTANTS_ATI			= 0x896F
	NUM_PASSES_ATI					= 0x8970
	NUM_INSTRUCTIONS_PER_PASS_ATI			= 0x8971
	NUM_INSTRUCTIONS_TOTAL_ATI			= 0x8972
	NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI		= 0x8973
	NUM_LOOPBACK_COMPONENTS_ATI			= 0x8974
	COLOR_ALPHA_PAIRING_ATI				= 0x8975
	SWIZZLE_STR_ATI					= 0x8976
	SWIZZLE_STQ_ATI					= 0x8977
	SWIZZLE_STR_DR_ATI				= 0x8978
	SWIZZLE_STQ_DQ_ATI				= 0x8979
	SWIZZLE_STRQ_ATI				= 0x897A
	SWIZZLE_STRQ_DQ_ATI				= 0x897B
	RED_BIT_ATI					= 0x00000001
	GREEN_BIT_ATI					= 0x00000002
	BLUE_BIT_ATI					= 0x00000004
	2X_BIT_ATI					= 0x00000001
	4X_BIT_ATI					= 0x00000002
	8X_BIT_ATI					= 0x00000004
	HALF_BIT_ATI					= 0x00000008
	QUARTER_BIT_ATI					= 0x00000010
	EIGHTH_BIT_ATI					= 0x00000020
	SATURATE_BIT_ATI				= 0x00000040
	COMP_BIT_ATI					= 0x00000002
	NEGATE_BIT_ATI					= 0x00000004
	BIAS_BIT_ATI					= 0x00000008

###############################################################################

# Extension #246
ATI_pn_triangles enum:
	PN_TRIANGLES_ATI				= 0x87F0
	MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI		= 0x87F1
	PN_TRIANGLES_POINT_MODE_ATI			= 0x87F2
	PN_TRIANGLES_NORMAL_MODE_ATI			= 0x87F3
	PN_TRIANGLES_TESSELATION_LEVEL_ATI		= 0x87F4
	PN_TRIANGLES_POINT_MODE_LINEAR_ATI		= 0x87F5
	PN_TRIANGLES_POINT_MODE_CUBIC_ATI		= 0x87F6
	PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI		= 0x87F7
	PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI		= 0x87F8

###############################################################################

# Extension #247
ATI_vertex_array_object enum:
	STATIC_ATI					= 0x8760
	DYNAMIC_ATI					= 0x8761
	PRESERVE_ATI					= 0x8762
	DISCARD_ATI					= 0x8763
	OBJECT_BUFFER_SIZE_ATI				= 0x8764
	OBJECT_BUFFER_USAGE_ATI				= 0x8765
	ARRAY_OBJECT_BUFFER_ATI				= 0x8766
	ARRAY_OBJECT_OFFSET_ATI				= 0x8767

###############################################################################

# Extension #248
EXT_vertex_shader enum:
	VERTEX_SHADER_EXT				= 0x8780
	VERTEX_SHADER_BINDING_EXT			= 0x8781
	OP_INDEX_EXT					= 0x8782
	OP_NEGATE_EXT					= 0x8783
	OP_DOT3_EXT					= 0x8784
	OP_DOT4_EXT					= 0x8785
	OP_MUL_EXT					= 0x8786
	OP_ADD_EXT					= 0x8787
	OP_MADD_EXT					= 0x8788
	OP_FRAC_EXT					= 0x8789
	OP_MAX_EXT					= 0x878A
	OP_MIN_EXT					= 0x878B
	OP_SET_GE_EXT					= 0x878C
	OP_SET_LT_EXT					= 0x878D
	OP_CLAMP_EXT					= 0x878E
	OP_FLOOR_EXT					= 0x878F
	OP_ROUND_EXT					= 0x8790
	OP_EXP_BASE_2_EXT				= 0x8791
	OP_LOG_BASE_2_EXT				= 0x8792
	OP_POWER_EXT					= 0x8793
	OP_RECIP_EXT					= 0x8794
	OP_RECIP_SQRT_EXT				= 0x8795
	OP_SUB_EXT					= 0x8796
	OP_CROSS_PRODUCT_EXT				= 0x8797
	OP_MULTIPLY_MATRIX_EXT				= 0x8798
	OP_MOV_EXT					= 0x8799
	OUTPUT_VERTEX_EXT				= 0x879A
	OUTPUT_COLOR0_EXT				= 0x879B
	OUTPUT_COLOR1_EXT				= 0x879C
	OUTPUT_TEXTURE_COORD0_EXT			= 0x879D
	OUTPUT_TEXTURE_COORD1_EXT			= 0x879E
	OUTPUT_TEXTURE_COORD2_EXT			= 0x879F
	OUTPUT_TEXTURE_COORD3_EXT			= 0x87A0
	OUTPUT_TEXTURE_COORD4_EXT			= 0x87A1
	OUTPUT_TEXTURE_COORD5_EXT			= 0x87A2
	OUTPUT_TEXTURE_COORD6_EXT			= 0x87A3
	OUTPUT_TEXTURE_COORD7_EXT			= 0x87A4
	OUTPUT_TEXTURE_COORD8_EXT			= 0x87A5
	OUTPUT_TEXTURE_COORD9_EXT			= 0x87A6
	OUTPUT_TEXTURE_COORD10_EXT			= 0x87A7
	OUTPUT_TEXTURE_COORD11_EXT			= 0x87A8
	OUTPUT_TEXTURE_COORD12_EXT			= 0x87A9
	OUTPUT_TEXTURE_COORD13_EXT			= 0x87AA
	OUTPUT_TEXTURE_COORD14_EXT			= 0x87AB
	OUTPUT_TEXTURE_COORD15_EXT			= 0x87AC
	OUTPUT_TEXTURE_COORD16_EXT			= 0x87AD
	OUTPUT_TEXTURE_COORD17_EXT			= 0x87AE
	OUTPUT_TEXTURE_COORD18_EXT			= 0x87AF
	OUTPUT_TEXTURE_COORD19_EXT			= 0x87B0
	OUTPUT_TEXTURE_COORD20_EXT			= 0x87B1
	OUTPUT_TEXTURE_COORD21_EXT			= 0x87B2
	OUTPUT_TEXTURE_COORD22_EXT			= 0x87B3
	OUTPUT_TEXTURE_COORD23_EXT			= 0x87B4
	OUTPUT_TEXTURE_COORD24_EXT			= 0x87B5
	OUTPUT_TEXTURE_COORD25_EXT			= 0x87B6
	OUTPUT_TEXTURE_COORD26_EXT			= 0x87B7
	OUTPUT_TEXTURE_COORD27_EXT			= 0x87B8
	OUTPUT_TEXTURE_COORD28_EXT			= 0x87B9
	OUTPUT_TEXTURE_COORD29_EXT			= 0x87BA
	OUTPUT_TEXTURE_COORD30_EXT			= 0x87BB
	OUTPUT_TEXTURE_COORD31_EXT			= 0x87BC
	OUTPUT_FOG_EXT					= 0x87BD
	SCALAR_EXT					= 0x87BE
	VECTOR_EXT					= 0x87BF
	MATRIX_EXT					= 0x87C0
	VARIANT_EXT					= 0x87C1
	INVARIANT_EXT					= 0x87C2
	LOCAL_CONSTANT_EXT				= 0x87C3
	LOCAL_EXT					= 0x87C4
	MAX_VERTEX_SHADER_INSTRUCTIONS_EXT		= 0x87C5
	MAX_VERTEX_SHADER_VARIANTS_EXT			= 0x87C6
	MAX_VERTEX_SHADER_INVARIANTS_EXT		= 0x87C7
	MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT		= 0x87C8
	MAX_VERTEX_SHADER_LOCALS_EXT			= 0x87C9
	MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT	= 0x87CA
	MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT	= 0x87CB
	MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CC
	MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT	= 0x87CD
	MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT		= 0x87CE
	VERTEX_SHADER_INSTRUCTIONS_EXT			= 0x87CF
	VERTEX_SHADER_VARIANTS_EXT			= 0x87D0
	VERTEX_SHADER_INVARIANTS_EXT			= 0x87D1
	VERTEX_SHADER_LOCAL_CONSTANTS_EXT		= 0x87D2
	VERTEX_SHADER_LOCALS_EXT			= 0x87D3
	VERTEX_SHADER_OPTIMIZED_EXT			= 0x87D4
	X_EXT						= 0x87D5
	Y_EXT						= 0x87D6
	Z_EXT						= 0x87D7
	W_EXT						= 0x87D8
	NEGATIVE_X_EXT					= 0x87D9
	NEGATIVE_Y_EXT					= 0x87DA
	NEGATIVE_Z_EXT					= 0x87DB
	NEGATIVE_W_EXT					= 0x87DC
	ZERO_EXT					= 0x87DD
	ONE_EXT						= 0x87DE
	NEGATIVE_ONE_EXT				= 0x87DF
	NORMALIZED_RANGE_EXT				= 0x87E0
	FULL_RANGE_EXT					= 0x87E1
	CURRENT_VERTEX_EXT				= 0x87E2
	MVP_MATRIX_EXT					= 0x87E3
	VARIANT_VALUE_EXT				= 0x87E4
	VARIANT_DATATYPE_EXT				= 0x87E5
	VARIANT_ARRAY_STRIDE_EXT			= 0x87E6
	VARIANT_ARRAY_TYPE_EXT				= 0x87E7
	VARIANT_ARRAY_EXT				= 0x87E8
	VARIANT_ARRAY_POINTER_EXT			= 0x87E9
	INVARIANT_VALUE_EXT				= 0x87EA
	INVARIANT_DATATYPE_EXT				= 0x87EB
	LOCAL_CONSTANT_VALUE_EXT			= 0x87EC
	LOCAL_CONSTANT_DATATYPE_EXT			= 0x87ED

###############################################################################

# Extension #249
ATI_vertex_streams enum:
	MAX_VERTEX_STREAMS_ATI				= 0x876B
	VERTEX_STREAM0_ATI				= 0x876C
	VERTEX_STREAM1_ATI				= 0x876D
	VERTEX_STREAM2_ATI				= 0x876E
	VERTEX_STREAM3_ATI				= 0x876F
	VERTEX_STREAM4_ATI				= 0x8770
	VERTEX_STREAM5_ATI				= 0x8771
	VERTEX_STREAM6_ATI				= 0x8772
	VERTEX_STREAM7_ATI				= 0x8773
	VERTEX_SOURCE_ATI				= 0x8774

###############################################################################

# Extension #250 - WGL_I3D_digital_video_control
# Extension #251 - WGL_I3D_gamma
# Extension #252 - WGL_I3D_genlock
# Extension #253 - WGL_I3D_image_buffer
# Extension #254 - WGL_I3D_swap_frame_lock
# Extension #255 - WGL_I3D_swap_frame_usage

###############################################################################

# Extension #256
ATI_element_array enum:
	ELEMENT_ARRAY_ATI				= 0x8768
	ELEMENT_ARRAY_TYPE_ATI				= 0x8769
	ELEMENT_ARRAY_POINTER_ATI			= 0x876A

###############################################################################

# Extension #257
SUN_mesh_array enum:
	QUAD_MESH_SUN					= 0x8614
	TRIANGLE_MESH_SUN				= 0x8615

###############################################################################

# Extension #258
SUN_slice_accum enum:
	SLICE_ACCUM_SUN					= 0x85CC

###############################################################################

# Extension #259
NV_multisample_filter_hint enum:
	MULTISAMPLE_FILTER_HINT_NV			= 0x8534

###############################################################################

# Extension #260
NV_depth_clamp enum:
	DEPTH_CLAMP_NV					= 0x864F

###############################################################################

# Extension #261
NV_occlusion_query enum:
	PIXEL_COUNTER_BITS_NV				= 0x8864
	CURRENT_OCCLUSION_QUERY_ID_NV			= 0x8865
	PIXEL_COUNT_NV					= 0x8866
	PIXEL_COUNT_AVAILABLE_NV			= 0x8867

###############################################################################

# Extension #262
NV_point_sprite enum:
	POINT_SPRITE_NV					= 0x8861
	COORD_REPLACE_NV				= 0x8862
	POINT_SPRITE_R_MODE_NV				= 0x8863

###############################################################################

# Extension #263 - WGL_NV_render_depth_texture
# Extension #264 - WGL_NV_render_texture_rectangle

###############################################################################

# Extension #265
NV_texture_shader3 enum:
	OFFSET_PROJECTIVE_TEXTURE_2D_NV			= 0x8850
	OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV		= 0x8851
	OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV		= 0x8852
	OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV	= 0x8853
	OFFSET_HILO_TEXTURE_2D_NV			= 0x8854
	OFFSET_HILO_TEXTURE_RECTANGLE_NV		= 0x8855
	OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV		= 0x8856
	OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV	= 0x8857
	DEPENDENT_HILO_TEXTURE_2D_NV			= 0x8858
	DEPENDENT_RGB_TEXTURE_3D_NV			= 0x8859
	DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV		= 0x885A
	DOT_PRODUCT_PASS_THROUGH_NV			= 0x885B
	DOT_PRODUCT_TEXTURE_1D_NV			= 0x885C
	DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV		= 0x885D
	HILO8_NV					= 0x885E
	SIGNED_HILO8_NV					= 0x885F
	FORCE_BLUE_TO_ONE_NV				= 0x8860

###############################################################################

# No new tokens
# Extension #266
NV_vertex_program1_1 enum:

###############################################################################

# No new tokens
# Extension #267
EXT_shadow_funcs enum:

###############################################################################

# Extension #268
EXT_stencil_two_side enum:
	STENCIL_TEST_TWO_SIDE_EXT			= 0x8910
	ACTIVE_STENCIL_FACE_EXT				= 0x8911

###############################################################################

# Extension #269
ATI_text_fragment_shader enum:
	TEXT_FRAGMENT_SHADER_ATI			= 0x8200

###############################################################################

# Extension #270
APPLE_client_storage enum:
	UNPACK_CLIENT_STORAGE_APPLE			= 0x85B2

###############################################################################

# Extension #271
# @@@ (extends ATI_element_array, I think???)
APPLE_element_array enum:
	ELEMENT_ARRAY_APPLE				= 0x8768
	ELEMENT_ARRAY_TYPE_APPLE			= 0x8769
	ELEMENT_ARRAY_POINTER_APPLE			= 0x876A

###############################################################################

# Extension #272
APPLE_fence enum:
	DRAW_PIXELS_APPLE				= 0x8A0A
	FENCE_APPLE					= 0x8A0B

###############################################################################

# Extension #273
APPLE_vertex_array_object enum:
	VERTEX_ARRAY_BINDING_APPLE			= 0x85B5

###############################################################################

# Extension #274
# @@@ How does this interact with NV_vertex_array_range?
APPLE_vertex_array_range enum:
	VERTEX_ARRAY_RANGE_APPLE			= 0x851D
	VERTEX_ARRAY_RANGE_LENGTH_APPLE			= 0x851E
	VERTEX_ARRAY_STORAGE_HINT_APPLE			= 0x851F
	VERTEX_ARRAY_RANGE_POINTER_APPLE		= 0x8521
	STORAGE_CACHED_APPLE				= 0x85BE
	STORAGE_SHARED_APPLE				= 0x85BF

###############################################################################

# Extension #275
APPLE_ycbcr_422 enum:
	YCBCR_422_APPLE					= 0x85B9
	UNSIGNED_SHORT_8_8_APPLE			= 0x85BA
	UNSIGNED_SHORT_8_8_REV_APPLE			= 0x85BB

###############################################################################

# Extension #276
S3_s3tc enum:
	RGB_S3TC					= 0x83A0
	RGB4_S3TC					= 0x83A1
	RGBA_S3TC					= 0x83A2
	RGBA4_S3TC					= 0x83A3

###############################################################################

# Extension #277
ATI_draw_buffers enum:
	MAX_DRAW_BUFFERS_ATI				= 0x8824
	DRAW_BUFFER0_ATI				= 0x8825
	DRAW_BUFFER1_ATI				= 0x8826
	DRAW_BUFFER2_ATI				= 0x8827
	DRAW_BUFFER3_ATI				= 0x8828
	DRAW_BUFFER4_ATI				= 0x8829
	DRAW_BUFFER5_ATI				= 0x882A
	DRAW_BUFFER6_ATI				= 0x882B
	DRAW_BUFFER7_ATI				= 0x882C
	DRAW_BUFFER8_ATI				= 0x882D
	DRAW_BUFFER9_ATI				= 0x882E
	DRAW_BUFFER10_ATI				= 0x882F
	DRAW_BUFFER11_ATI				= 0x8830
	DRAW_BUFFER12_ATI				= 0x8831
	DRAW_BUFFER13_ATI				= 0x8832
	DRAW_BUFFER14_ATI				= 0x8833
	DRAW_BUFFER15_ATI				= 0x8834

###############################################################################

# Extension #278
# This is really a WGL extension, but if defined there are
# some associated GL enumerants.
ATI_pixel_format_float enum:
	TYPE_RGBA_FLOAT_ATI				= 0x8820
	COLOR_CLEAR_UNCLAMPED_VALUE_ATI			= 0x8835

###############################################################################

# Extension #279
ATI_texture_env_combine3 enum:
	MODULATE_ADD_ATI				= 0x8744
	MODULATE_SIGNED_ADD_ATI				= 0x8745
	MODULATE_SUBTRACT_ATI				= 0x8746

###############################################################################

# Extension #280
ATI_texture_float enum:
	RGBA_FLOAT32_ATI				= 0x8814
	RGB_FLOAT32_ATI					= 0x8815
	ALPHA_FLOAT32_ATI				= 0x8816
	INTENSITY_FLOAT32_ATI				= 0x8817
	LUMINANCE_FLOAT32_ATI				= 0x8818
	LUMINANCE_ALPHA_FLOAT32_ATI			= 0x8819
	RGBA_FLOAT16_ATI				= 0x881A
	RGB_FLOAT16_ATI					= 0x881B
	ALPHA_FLOAT16_ATI				= 0x881C
	INTENSITY_FLOAT16_ATI				= 0x881D
	LUMINANCE_FLOAT16_ATI				= 0x881E
	LUMINANCE_ALPHA_FLOAT16_ATI			= 0x881F

###############################################################################

# Extension #281 (also WGL_NV_float_buffer)
NV_float_buffer enum:
	FLOAT_R_NV					= 0x8880
	FLOAT_RG_NV					= 0x8881
	FLOAT_RGB_NV					= 0x8882
	FLOAT_RGBA_NV					= 0x8883
	FLOAT_R16_NV					= 0x8884
	FLOAT_R32_NV					= 0x8885
	FLOAT_RG16_NV					= 0x8886
	FLOAT_RG32_NV					= 0x8887
	FLOAT_RGB16_NV					= 0x8888
	FLOAT_RGB32_NV					= 0x8889
	FLOAT_RGBA16_NV					= 0x888A
	FLOAT_RGBA32_NV					= 0x888B
	TEXTURE_FLOAT_COMPONENTS_NV			= 0x888C
	FLOAT_CLEAR_COLOR_VALUE_NV			= 0x888D
	FLOAT_RGBA_MODE_NV				= 0x888E

###############################################################################

# Extension #282
NV_fragment_program enum:
	MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV	= 0x8868
	FRAGMENT_PROGRAM_NV				= 0x8870
	MAX_TEXTURE_COORDS_NV				= 0x8871
	MAX_TEXTURE_IMAGE_UNITS_NV			= 0x8872
	FRAGMENT_PROGRAM_BINDING_NV			= 0x8873
	PROGRAM_ERROR_STRING_NV				= 0x8874

###############################################################################

# Extension #283
NV_half_float enum:
	HALF_FLOAT_NV					= 0x140B

###############################################################################

# Extension #284
NV_pixel_data_range enum:
	WRITE_PIXEL_DATA_RANGE_NV			= 0x8878
	READ_PIXEL_DATA_RANGE_NV			= 0x8879
	WRITE_PIXEL_DATA_RANGE_LENGTH_NV		= 0x887A
	READ_PIXEL_DATA_RANGE_LENGTH_NV			= 0x887B
	WRITE_PIXEL_DATA_RANGE_POINTER_NV		= 0x887C
	READ_PIXEL_DATA_RANGE_POINTER_NV		= 0x887D

###############################################################################

# Extension #285
NV_primitive_restart enum:
	PRIMITIVE_RESTART_NV				= 0x8558
	PRIMITIVE_RESTART_INDEX_NV			= 0x8559

###############################################################################

# Extension #286
NV_texture_expand_normal enum:
	TEXTURE_UNSIGNED_REMAP_MODE_NV			= 0x888F

###############################################################################

# No new tokens
# Extension #287
NV_vertex_program2 enum:

###############################################################################

# No new tokens
# Extension #288
ATI_map_object_buffer enum:

###############################################################################

# Extension #289
ATI_separate_stencil enum:
	STENCIL_BACK_FUNC_ATI				= 0x8800
	STENCIL_BACK_FAIL_ATI				= 0x8801
	STENCIL_BACK_PASS_DEPTH_FAIL_ATI		= 0x8802
	STENCIL_BACK_PASS_DEPTH_PASS_ATI		= 0x8803

###############################################################################

# No new tokens
# Extension #290
ATI_vertex_attrib_array_object enum:

###############################################################################

# No new tokens
# Extension #291 - OpenGL ES only, not in glext.h
# OES_byte_coordinates enum:

###############################################################################

# Extension #292 - OpenGL ES only, not in glext.h
# OES_fixed_point enum:
#	FIXED_OES					= 0x140C

###############################################################################

# No new tokens
# Extension #293 - OpenGL ES only, not in glext.h
# OES_single_precision enum:

###############################################################################

# Extension #294 - OpenGL ES only, not in glext.h
# OES_compressed_paletted_texture enum:
#	PALETTE4_RGB8_OES				= 0x8B90
#	PALETTE4_RGBA8_OES				= 0x8B91
#	PALETTE4_R5_G6_B5_OES				= 0x8B92
#	PALETTE4_RGBA4_OES				= 0x8B93
#	PALETTE4_RGB5_A1_OES				= 0x8B94
#	PALETTE8_RGB8_OES				= 0x8B95
#	PALETTE8_RGBA8_OES				= 0x8B96
#	PALETTE8_R5_G6_B5_OES				= 0x8B97
#	PALETTE8_RGBA4_OES				= 0x8B98
#	PALETTE8_RGB5_A1_OES				= 0x8B99

###############################################################################

# Extension #295 - This is an OpenGL ES extension, but also implemented in Mesa
OES_read_format enum:
	IMPLEMENTATION_COLOR_READ_TYPE_OES		= 0x8B9A
	IMPLEMENTATION_COLOR_READ_FORMAT_OES		= 0x8B9B

###############################################################################

# No new tokens
# Extension #296 - OpenGL ES only, not in glext.h
# OES_query_matrix enum:

###############################################################################

# Extension #297
EXT_depth_bounds_test enum:
	DEPTH_BOUNDS_TEST_EXT				= 0x8890
	DEPTH_BOUNDS_EXT				= 0x8891

###############################################################################

# Extension #298
EXT_texture_mirror_clamp enum:
	MIRROR_CLAMP_EXT				= 0x8742
	MIRROR_CLAMP_TO_EDGE_EXT			= 0x8743
	MIRROR_CLAMP_TO_BORDER_EXT			= 0x8912

###############################################################################

# Extension #299
EXT_blend_equation_separate enum:
	BLEND_EQUATION_RGB_EXT				= GL_BLEND_EQUATION
	BLEND_EQUATION_ALPHA_EXT			= 0x883D

###############################################################################

# Extension #300
MESA_pack_invert enum:
	PACK_INVERT_MESA				= 0x8758

###############################################################################

# Extension #301
MESA_ycbcr_texture enum:
	UNSIGNED_SHORT_8_8_MESA				= 0x85BA
	UNSIGNED_SHORT_8_8_REV_MESA			= 0x85BB
	YCBCR_MESA					= 0x8757

###############################################################################

# Extension #302
EXT_pixel_buffer_object enum:
	PIXEL_PACK_BUFFER_EXT				= 0x88EB
	PIXEL_UNPACK_BUFFER_EXT				= 0x88EC
	PIXEL_PACK_BUFFER_BINDING_EXT			= 0x88ED
	PIXEL_UNPACK_BUFFER_BINDING_EXT			= 0x88EF

###############################################################################

# No new tokens
# Extension #303
NV_fragment_program_option enum:

###############################################################################

# Extension #304
NV_fragment_program2 enum:
	MAX_PROGRAM_EXEC_INSTRUCTIONS_NV		= 0x88F4
	MAX_PROGRAM_CALL_DEPTH_NV			= 0x88F5
	MAX_PROGRAM_IF_DEPTH_NV				= 0x88F6
	MAX_PROGRAM_LOOP_DEPTH_NV			= 0x88F7
	MAX_PROGRAM_LOOP_COUNT_NV			= 0x88F8

###############################################################################

# Extension #305
NV_vertex_program2_option enum:
	use NV_fragment_program2 MAX_PROGRAM_EXEC_INSTRUCTIONS_NV
	use NV_fragment_program2 MAX_PROGRAM_CALL_DEPTH_NV

###############################################################################

# Extension #306
NV_vertex_program3 enum:
	use ARB_vertex_shader MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB

###############################################################################

# Extension #307 - GLX_SGIX_hyperpipe
# Extension #308 - GLX_MESA_agp_offset
# Extension #309 - GL_EXT_texture_compression_dxt1 (OpenGL ES only, subset of _s3tc version)

###############################################################################

# Extension #310
EXT_framebuffer_object enum:
	INVALID_FRAMEBUFFER_OPERATION_EXT		= 0x0506
	MAX_RENDERBUFFER_SIZE_EXT			= 0x84E8
	FRAMEBUFFER_BINDING_EXT				= 0x8CA6
	RENDERBUFFER_BINDING_EXT			= 0x8CA7
	FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT		= 0x8CD0
	FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT		= 0x8CD1
	FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT	= 0x8CD2
	FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3
	FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT	= 0x8CD4
	FRAMEBUFFER_COMPLETE_EXT			= 0x8CD5
	FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT		= 0x8CD6
	FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT	= 0x8CD7
## Removed 2005/09/26 in revision #117 of the extension:
##	  FRAMEBUFFER_INCOMPLETE_DUPLICATE_ATTACHMENT_EXT = 0x8CD8
	FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT		= 0x8CD9
	FRAMEBUFFER_INCOMPLETE_FORMATS_EXT		= 0x8CDA
	FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT		= 0x8CDB
	FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT		= 0x8CDC
	FRAMEBUFFER_UNSUPPORTED_EXT			= 0x8CDD
## Removed 2005/05/31 in revision #113 of the extension:
##	  FRAMEBUFFER_STATUS_ERROR_EXT			  = 0x8CDE
	MAX_COLOR_ATTACHMENTS_EXT			= 0x8CDF
	COLOR_ATTACHMENT0_EXT				= 0x8CE0
	COLOR_ATTACHMENT1_EXT				= 0x8CE1
	COLOR_ATTACHMENT2_EXT				= 0x8CE2
	COLOR_ATTACHMENT3_EXT				= 0x8CE3
	COLOR_ATTACHMENT4_EXT				= 0x8CE4
	COLOR_ATTACHMENT5_EXT				= 0x8CE5
	COLOR_ATTACHMENT6_EXT				= 0x8CE6
	COLOR_ATTACHMENT7_EXT				= 0x8CE7
	COLOR_ATTACHMENT8_EXT				= 0x8CE8
	COLOR_ATTACHMENT9_EXT				= 0x8CE9
	COLOR_ATTACHMENT10_EXT				= 0x8CEA
	COLOR_ATTACHMENT11_EXT				= 0x8CEB
	COLOR_ATTACHMENT12_EXT				= 0x8CEC
	COLOR_ATTACHMENT13_EXT				= 0x8CED
	COLOR_ATTACHMENT14_EXT				= 0x8CEE
	COLOR_ATTACHMENT15_EXT				= 0x8CEF
	DEPTH_ATTACHMENT_EXT				= 0x8D00
	STENCIL_ATTACHMENT_EXT				= 0x8D20
	FRAMEBUFFER_EXT					= 0x8D40
	RENDERBUFFER_EXT				= 0x8D41
	RENDERBUFFER_WIDTH_EXT				= 0x8D42
	RENDERBUFFER_HEIGHT_EXT				= 0x8D43
	RENDERBUFFER_INTERNAL_FORMAT_EXT		= 0x8D44
# removed STENCIL_INDEX_EXT = 0x8D45 in rev. #114 of the spec
	STENCIL_INDEX1_EXT				= 0x8D46
	STENCIL_INDEX4_EXT				= 0x8D47
	STENCIL_INDEX8_EXT				= 0x8D48
	STENCIL_INDEX16_EXT				= 0x8D49
	RENDERBUFFER_RED_SIZE_EXT			= 0x8D50
	RENDERBUFFER_GREEN_SIZE_EXT			= 0x8D51
	RENDERBUFFER_BLUE_SIZE_EXT			= 0x8D52
	RENDERBUFFER_ALPHA_SIZE_EXT			= 0x8D53
	RENDERBUFFER_DEPTH_SIZE_EXT			= 0x8D54
	RENDERBUFFER_STENCIL_SIZE_EXT			= 0x8D55

###############################################################################

# No new tokens
# Extension #311
GREMEDY_string_marker enum:

###############################################################################

# Extension #312
EXT_packed_depth_stencil enum:
	DEPTH_STENCIL_EXT				= 0x84F9
	UNSIGNED_INT_24_8_EXT				= 0x84FA
	DEPTH24_STENCIL8_EXT				= 0x88F0
	TEXTURE_STENCIL_SIZE_EXT			= 0x88F1

###############################################################################

# Extension #313 - WGL_3DL_stereo_control

###############################################################################

# Extension #314
EXT_stencil_clear_tag enum:
	STENCIL_TAG_BITS_EXT				= 0x88F2
	STENCIL_CLEAR_TAG_VALUE_EXT			= 0x88F3

###############################################################################

# Extension #315
EXT_texture_sRGB enum:
	SRGB_EXT					= 0x8C40
	SRGB8_EXT					= 0x8C41
	SRGB_ALPHA_EXT					= 0x8C42
	SRGB8_ALPHA8_EXT				= 0x8C43
	SLUMINANCE_ALPHA_EXT				= 0x8C44
	SLUMINANCE8_ALPHA8_EXT				= 0x8C45
	SLUMINANCE_EXT					= 0x8C46
	SLUMINANCE8_EXT					= 0x8C47
	COMPRESSED_SRGB_EXT				= 0x8C48
	COMPRESSED_SRGB_ALPHA_EXT			= 0x8C49
	COMPRESSED_SLUMINANCE_EXT			= 0x8C4A
	COMPRESSED_SLUMINANCE_ALPHA_EXT			= 0x8C4B
	COMPRESSED_SRGB_S3TC_DXT1_EXT			= 0x8C4C
	COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT		= 0x8C4D
	COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT		= 0x8C4E
	COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT		= 0x8C4F

###############################################################################

# Extension #316
EXT_framebuffer_blit enum:
	READ_FRAMEBUFFER_EXT				= 0x8CA8
	DRAW_FRAMEBUFFER_EXT				= 0x8CA9
	READ_FRAMEBUFFER_BINDING_EXT			= GL_FRAMEBUFFER_BINDING_EXT
	DRAW_FRAMEBUFFER_BINDING_EXT			= 0x8CAA

###############################################################################

# Extension #317
EXT_framebuffer_multisample enum:
	RENDERBUFFER_SAMPLES_EXT			= 0x8CAB
	FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT		= 0x8D56
	MAX_SAMPLES_EXT					= 0x8D57

###############################################################################

# Extension #318
MESAX_texture_stack enum:
	TEXTURE_1D_STACK_MESAX				= 0x8759
	TEXTURE_2D_STACK_MESAX				= 0x875A
	PROXY_TEXTURE_1D_STACK_MESAX			= 0x875B
	PROXY_TEXTURE_2D_STACK_MESAX			= 0x875C
	TEXTURE_1D_STACK_BINDING_MESAX			= 0x875D
	TEXTURE_2D_STACK_BINDING_MESAX			= 0x875E

###############################################################################

# Extension #319
EXT_timer_query enum:
	TIME_ELAPSED_EXT				= 0x88BF

###############################################################################

# No new tokens
# Extension #320
EXT_gpu_program_parameters enum:

###############################################################################

# Extension #321
APPLE_flush_buffer_range enum:
	BUFFER_SERIALIZED_MODIFY_APPLE			= 0x8A12
	BUFFER_FLUSHING_UNMAP_APPLE			= 0x8A13

###############################################################################

# Extension #322
NV_gpu_program4 enum:
	MIN_PROGRAM_TEXEL_OFFSET_NV			= 0x8904
	MAX_PROGRAM_TEXEL_OFFSET_NV			= 0x8905
	PROGRAM_ATTRIB_COMPONENTS_NV			= 0x8906
	PROGRAM_RESULT_COMPONENTS_NV			= 0x8907
	MAX_PROGRAM_ATTRIB_COMPONENTS_NV		= 0x8908
	MAX_PROGRAM_RESULT_COMPONENTS_NV		= 0x8909
	MAX_PROGRAM_GENERIC_ATTRIBS_NV			= 0x8DA5
	MAX_PROGRAM_GENERIC_RESULTS_NV			= 0x8DA6

###############################################################################

# Extension #323
NV_geometry_program4 enum:
	LINES_ADJACENCY_EXT				= 0x000A
	LINE_STRIP_ADJACENCY_EXT			= 0x000B
	TRIANGLES_ADJACENCY_EXT				= 0x000C
	TRIANGLE_STRIP_ADJACENCY_EXT			= 0x000D
	GEOMETRY_PROGRAM_NV				= 0x8C26
	MAX_PROGRAM_OUTPUT_VERTICES_NV			= 0x8C27
	MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV		= 0x8C28
	GEOMETRY_VERTICES_OUT_EXT			= 0x8DDA
	GEOMETRY_INPUT_TYPE_EXT				= 0x8DDB
	GEOMETRY_OUTPUT_TYPE_EXT			= 0x8DDC
	MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT		= 0x8C29
	FRAMEBUFFER_ATTACHMENT_LAYERED_EXT		= 0x8DA7
	FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT	= 0x8DA8
	FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT		= 0x8DA9
	FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT	= 0x8CD4
	PROGRAM_POINT_SIZE_EXT				= 0x8642

###############################################################################

# Extension #324
EXT_geometry_shader4 enum:
	GEOMETRY_SHADER_EXT				= 0x8DD9
	use NV_geometry_program4 GEOMETRY_VERTICES_OUT_EXT
	use NV_geometry_program4 GEOMETRY_INPUT_TYPE_EXT
	use NV_geometry_program4 GEOMETRY_OUTPUT_TYPE_EXT
	use NV_geometry_program4 MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT
	MAX_GEOMETRY_VARYING_COMPONENTS_EXT		= 0x8DDD
	MAX_VERTEX_VARYING_COMPONENTS_EXT		= 0x8DDE
	MAX_VARYING_COMPONENTS_EXT			= 0x8B4B
	MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT		= 0x8DDF
	MAX_GEOMETRY_OUTPUT_VERTICES_EXT		= 0x8DE0
	MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT	= 0x8DE1
	use NV_geometry_program4 LINES_ADJACENCY_EXT
	use NV_geometry_program4 LINE_STRIP_ADJACENCY_EXT
	use NV_geometry_program4 TRIANGLES_ADJACENCY_EXT
	use NV_geometry_program4 TRIANGLE_STRIP_ADJACENCY_EXT
	use NV_geometry_program4 FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT
	use NV_geometry_program4 FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT
	use NV_geometry_program4 FRAMEBUFFER_ATTACHMENT_LAYERED_EXT
	use NV_geometry_program4 FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT
	use NV_geometry_program4 PROGRAM_POINT_SIZE_EXT

###############################################################################

# Extension #325
NV_vertex_program4 enum:
	VERTEX_ATTRIB_ARRAY_INTEGER_NV			= 0x88FD

###############################################################################

# Extension #326
EXT_gpu_shader4 enum:
	SAMPLER_1D_ARRAY_EXT				= 0x8DC0
	SAMPLER_2D_ARRAY_EXT				= 0x8DC1
	SAMPLER_BUFFER_EXT				= 0x8DC2
	SAMPLER_1D_ARRAY_SHADOW_EXT			= 0x8DC3
	SAMPLER_2D_ARRAY_SHADOW_EXT			= 0x8DC4
	SAMPLER_CUBE_SHADOW_EXT				= 0x8DC5
	UNSIGNED_INT_VEC2_EXT				= 0x8DC6
	UNSIGNED_INT_VEC3_EXT				= 0x8DC7
	UNSIGNED_INT_VEC4_EXT				= 0x8DC8
	INT_SAMPLER_1D_EXT				= 0x8DC9
	INT_SAMPLER_2D_EXT				= 0x8DCA
	INT_SAMPLER_3D_EXT				= 0x8DCB
	INT_SAMPLER_CUBE_EXT				= 0x8DCC
	INT_SAMPLER_2D_RECT_EXT				= 0x8DCD
	INT_SAMPLER_1D_ARRAY_EXT			= 0x8DCE
	INT_SAMPLER_2D_ARRAY_EXT			= 0x8DCF
	INT_SAMPLER_BUFFER_EXT				= 0x8DD0
	UNSIGNED_INT_SAMPLER_1D_EXT			= 0x8DD1
	UNSIGNED_INT_SAMPLER_2D_EXT			= 0x8DD2
	UNSIGNED_INT_SAMPLER_3D_EXT			= 0x8DD3
	UNSIGNED_INT_SAMPLER_CUBE_EXT			= 0x8DD4
	UNSIGNED_INT_SAMPLER_2D_RECT_EXT		= 0x8DD5
	UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT		= 0x8DD6
	UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT		= 0x8DD7
	UNSIGNED_INT_SAMPLER_BUFFER_EXT			= 0x8DD8

###############################################################################

# No new tokens
# Extension #327
EXT_draw_instanced enum:

###############################################################################

# Extension #328
EXT_packed_float enum:
	R11F_G11F_B10F_EXT				= 0x8C3A
	UNSIGNED_INT_10F_11F_11F_REV_EXT		= 0x8C3B
	RGBA_SIGNED_COMPONENTS_EXT			= 0x8C3C

###############################################################################

# Extension #329
EXT_texture_array enum:
	TEXTURE_1D_ARRAY_EXT				= 0x8C18
	PROXY_TEXTURE_1D_ARRAY_EXT			= 0x8C19
	TEXTURE_2D_ARRAY_EXT				= 0x8C1A
	PROXY_TEXTURE_2D_ARRAY_EXT			= 0x8C1B
	TEXTURE_BINDING_1D_ARRAY_EXT			= 0x8C1C
	TEXTURE_BINDING_2D_ARRAY_EXT			= 0x8C1D
	MAX_ARRAY_TEXTURE_LAYERS_EXT			= 0x88FF
	COMPARE_REF_DEPTH_TO_TEXTURE_EXT		= 0x884E
	use NV_geometry_program4 FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT

###############################################################################

# Extension #330
EXT_texture_buffer_object enum:
	TEXTURE_BUFFER_EXT				= 0x8C2A
	MAX_TEXTURE_BUFFER_SIZE_EXT			= 0x8C2B
	TEXTURE_BINDING_BUFFER_EXT			= 0x8C2C
	TEXTURE_BUFFER_DATA_STORE_BINDING_EXT		= 0x8C2D
	TEXTURE_BUFFER_FORMAT_EXT			= 0x8C2E

###############################################################################

# Extension #331
EXT_texture_compression_latc enum:
	COMPRESSED_LUMINANCE_LATC1_EXT			= 0x8C70
	COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT		= 0x8C71
	COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT		= 0x8C72
	COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT	= 0x8C73

###############################################################################

# Extension #332
EXT_texture_compression_rgtc enum:
	COMPRESSED_RED_RGTC1_EXT			= 0x8DBB
	COMPRESSED_SIGNED_RED_RGTC1_EXT			= 0x8DBC
	COMPRESSED_RED_GREEN_RGTC2_EXT			= 0x8DBD
	COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT		= 0x8DBE

###############################################################################

# Extension #333
EXT_texture_shared_exponent enum:
	RGB9_E5_EXT					= 0x8C3D
	UNSIGNED_INT_5_9_9_9_REV_EXT			= 0x8C3E
	TEXTURE_SHARED_SIZE_EXT				= 0x8C3F

###############################################################################

# Extension #334
NV_depth_buffer_float enum:
	DEPTH_COMPONENT32F_NV				= 0x8DAB
	DEPTH32F_STENCIL8_NV				= 0x8DAC
	FLOAT_32_UNSIGNED_INT_24_8_REV_NV		= 0x8DAD
	DEPTH_BUFFER_FLOAT_MODE_NV			= 0x8DAF

###############################################################################

# No new tokens
# Extension #335
NV_fragment_program4 enum:

###############################################################################

# Extension #336
NV_framebuffer_multisample_coverage enum:
	RENDERBUFFER_COVERAGE_SAMPLES_NV		= 0x8CAB
	RENDERBUFFER_COLOR_SAMPLES_NV			= 0x8E10
	MAX_MULTISAMPLE_COVERAGE_MODES_NV		= 0x8E11
	MULTISAMPLE_COVERAGE_MODES_NV			= 0x8E12

###############################################################################

# Extension #337
# ??? Also WGL/GLX extensions ???
EXT_framebuffer_sRGB enum:
	FRAMEBUFFER_SRGB_EXT				= 0x8DB9
	FRAMEBUFFER_SRGB_CAPABLE_EXT			= 0x8DBA

###############################################################################

# No new tokens
# Extension #338
NV_geometry_shader4 enum:

###############################################################################

# Extension #339
NV_parameter_buffer_object enum:
	MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV	= 0x8DA0
	MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV		= 0x8DA1
	VERTEX_PROGRAM_PARAMETER_BUFFER_NV		= 0x8DA2
	GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV		= 0x8DA3
	FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV		= 0x8DA4

###############################################################################

# No new tokens
# Extension #340
EXT_draw_buffers2 enum:

###############################################################################

# Extension #341
NV_transform_feedback enum:
	BACK_PRIMARY_COLOR_NV				= 0x8C77
	BACK_SECONDARY_COLOR_NV				= 0x8C78
	TEXTURE_COORD_NV				= 0x8C79
	CLIP_DISTANCE_NV				= 0x8C7A
	VERTEX_ID_NV					= 0x8C7B
	PRIMITIVE_ID_NV					= 0x8C7C
	GENERIC_ATTRIB_NV				= 0x8C7D
	TRANSFORM_FEEDBACK_ATTRIBS_NV			= 0x8C7E
	TRANSFORM_FEEDBACK_BUFFER_MODE_NV		= 0x8C7F
	MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV	= 0x8C80
	ACTIVE_VARYINGS_NV				= 0x8C81
	ACTIVE_VARYING_MAX_LENGTH_NV			= 0x8C82
	TRANSFORM_FEEDBACK_VARYINGS_NV			= 0x8C83
	TRANSFORM_FEEDBACK_BUFFER_START_NV		= 0x8C84
	TRANSFORM_FEEDBACK_BUFFER_SIZE_NV		= 0x8C85
	TRANSFORM_FEEDBACK_RECORD_NV			= 0x8C86
	PRIMITIVES_GENERATED_NV				= 0x8C87
	TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV	= 0x8C88
	RASTERIZER_DISCARD_NV				= 0x8C89
	MAX_TRANSFORM_FEEDBACK_INTERLEAVED_ATTRIBS_NV	= 0x8C8A
	MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV	= 0x8C8B
	INTERLEAVED_ATTRIBS_NV				= 0x8C8C
	SEPARATE_ATTRIBS_NV				= 0x8C8D
	TRANSFORM_FEEDBACK_BUFFER_NV			= 0x8C8E
	TRANSFORM_FEEDBACK_BUFFER_BINDING_NV		= 0x8C8F

###############################################################################

# Extension #342
EXT_bindable_uniform enum:
	MAX_VERTEX_BINDABLE_UNIFORMS_EXT		= 0x8DE2
	MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT		= 0x8DE3
	MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT		= 0x8DE4
	MAX_BINDABLE_UNIFORM_SIZE_EXT			= 0x8DED
	UNIFORM_BUFFER_EXT				= 0x8DEE
	UNIFORM_BUFFER_BINDING_EXT			= 0x8DEF

###############################################################################

# Extension #343
EXT_texture_integer enum:
	RGBA32UI_EXT					= 0x8D70
	RGB32UI_EXT					= 0x8D71
	ALPHA32UI_EXT					= 0x8D72
	INTENSITY32UI_EXT				= 0x8D73
	LUMINANCE32UI_EXT				= 0x8D74
	LUMINANCE_ALPHA32UI_EXT				= 0x8D75
	RGBA16UI_EXT					= 0x8D76
	RGB16UI_EXT					= 0x8D77
	ALPHA16UI_EXT					= 0x8D78
	INTENSITY16UI_EXT				= 0x8D79
	LUMINANCE16UI_EXT				= 0x8D7A
	LUMINANCE_ALPHA16UI_EXT				= 0x8D7B
	RGBA8UI_EXT					= 0x8D7C
	RGB8UI_EXT					= 0x8D7D
	ALPHA8UI_EXT					= 0x8D7E
	INTENSITY8UI_EXT				= 0x8D7F
	LUMINANCE8UI_EXT				= 0x8D80
	LUMINANCE_ALPHA8UI_EXT				= 0x8D81
	RGBA32I_EXT					= 0x8D82
	RGB32I_EXT					= 0x8D83
	ALPHA32I_EXT					= 0x8D84
	INTENSITY32I_EXT				= 0x8D85
	LUMINANCE32I_EXT				= 0x8D86
	LUMINANCE_ALPHA32I_EXT				= 0x8D87
	RGBA16I_EXT					= 0x8D88
	RGB16I_EXT					= 0x8D89
	ALPHA16I_EXT					= 0x8D8A
	INTENSITY16I_EXT				= 0x8D8B
	LUMINANCE16I_EXT				= 0x8D8C
	LUMINANCE_ALPHA16I_EXT				= 0x8D8D
	RGBA8I_EXT					= 0x8D8E
	RGB8I_EXT					= 0x8D8F
	ALPHA8I_EXT					= 0x8D90
	INTENSITY8I_EXT					= 0x8D91
	LUMINANCE8I_EXT					= 0x8D92
	LUMINANCE_ALPHA8I_EXT				= 0x8D93
	RED_INTEGER_EXT					= 0x8D94
	GREEN_INTEGER_EXT				= 0x8D95
	BLUE_INTEGER_EXT				= 0x8D96
	ALPHA_INTEGER_EXT				= 0x8D97
	RGB_INTEGER_EXT					= 0x8D98
	RGBA_INTEGER_EXT				= 0x8D99
	BGR_INTEGER_EXT					= 0x8D9A
	BGRA_INTEGER_EXT				= 0x8D9B
	LUMINANCE_INTEGER_EXT				= 0x8D9C
	LUMINANCE_ALPHA_INTEGER_EXT			= 0x8D9D
	RGBA_INTEGER_MODE_EXT				= 0x8D9E

###############################################################################

# Extension #344 - GLX_EXT_texture_from_pixmap

