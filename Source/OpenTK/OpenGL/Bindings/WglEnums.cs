namespace OpenTK.OpenGL
{
    public static partial class Wgl
    {
        public class Enums
        {
            public enum WGL_ARB_buffer_region
            {
                WGL_BACK_COLOR_BUFFER_BIT_ARB = ((int)0x00000002),
                WGL_FRONT_COLOR_BUFFER_BIT_ARB = ((int)0x00000001),
                WGL_STENCIL_BUFFER_BIT_ARB = ((int)0x00000008),
                WGL_DEPTH_BUFFER_BIT_ARB = ((int)0x00000004),
            }
            
            public enum WGL_EXT_pixel_format
            {
                WGL_AUX_BUFFERS_EXT = ((int)0x2024),
                WGL_SHARE_STENCIL_EXT = ((int)0x200D),
                WGL_SWAP_METHOD_EXT = ((int)0x2007),
                WGL_TRANSPARENT_EXT = ((int)0x200A),
                WGL_ACCELERATION_EXT = ((int)0x2003),
                WGL_ACCUM_GREEN_BITS_EXT = ((int)0x201F),
                WGL_SUPPORT_GDI_EXT = ((int)0x200F),
                WGL_TRANSPARENT_VALUE_EXT = ((int)0x200B),
                WGL_DEPTH_BITS_EXT = ((int)0x2022),
                WGL_STEREO_EXT = ((int)0x2012),
                WGL_FULL_ACCELERATION_EXT = ((int)0x2027),
                WGL_SWAP_UNDEFINED_EXT = ((int)0x202A),
                WGL_RED_BITS_EXT = ((int)0x2015),
                WGL_PIXEL_TYPE_EXT = ((int)0x2013),
                WGL_DRAW_TO_BITMAP_EXT = ((int)0x2002),
                WGL_DRAW_TO_WINDOW_EXT = ((int)0x2001),
                WGL_ALPHA_BITS_EXT = ((int)0x201B),
                WGL_RED_SHIFT_EXT = ((int)0x2016),
                WGL_TYPE_RGBA_EXT = ((int)0x202B),
                WGL_ACCUM_BITS_EXT = ((int)0x201D),
                WGL_SWAP_COPY_EXT = ((int)0x2029),
                WGL_NEED_SYSTEM_PALETTE_EXT = ((int)0x2005),
                WGL_TYPE_COLORINDEX_EXT = ((int)0x202C),
                WGL_SHARE_ACCUM_EXT = ((int)0x200E),
                WGL_COLOR_BITS_EXT = ((int)0x2014),
                WGL_SUPPORT_OPENGL_EXT = ((int)0x2010),
                WGL_ACCUM_ALPHA_BITS_EXT = ((int)0x2021),
                WGL_STENCIL_BITS_EXT = ((int)0x2023),
                WGL_SWAP_LAYER_BUFFERS_EXT = ((int)0x2006),
                WGL_ACCUM_BLUE_BITS_EXT = ((int)0x2020),
                WGL_SWAP_EXCHANGE_EXT = ((int)0x2028),
                WGL_ALPHA_SHIFT_EXT = ((int)0x201C),
                WGL_GENERIC_ACCELERATION_EXT = ((int)0x2026),
                WGL_GREEN_SHIFT_EXT = ((int)0x2018),
                WGL_NUMBER_UNDERLAYS_EXT = ((int)0x2009),
                WGL_NUMBER_OVERLAYS_EXT = ((int)0x2008),
                WGL_NEED_PALETTE_EXT = ((int)0x2004),
                WGL_GREEN_BITS_EXT = ((int)0x2017),
                WGL_BLUE_BITS_EXT = ((int)0x2019),
                WGL_DOUBLE_BUFFER_EXT = ((int)0x2011),
                WGL_BLUE_SHIFT_EXT = ((int)0x201A),
                WGL_SHARE_DEPTH_EXT = ((int)0x200C),
                WGL_NUMBER_PIXEL_FORMATS_EXT = ((int)0x2000),
                WGL_NO_ACCELERATION_EXT = ((int)0x2025),
                WGL_ACCUM_RED_BITS_EXT = ((int)0x201E),
            }
            
            public enum WGL_ARB_pixel_format
            {
                WGL_SHARE_STENCIL_ARB = ((int)0x200D),
                WGL_DRAW_TO_BITMAP_ARB = ((int)0x2002),
                WGL_SWAP_COPY_ARB = ((int)0x2029),
                WGL_ACCUM_BLUE_BITS_ARB = ((int)0x2020),
                WGL_MAX_PBUFFER_PIXELS_ARB = ((int)0x202E),
                WGL_PIXEL_TYPE_ARB = ((int)0x2013),
                WGL_FULL_ACCELERATION_ARB = ((int)0x2027),
                WGL_TYPE_COLORINDEX_ARB = ((int)0x202C),
                WGL_NO_ACCELERATION_ARB = ((int)0x2025),
                WGL_TRANSPARENT_INDEX_VALUE_ARB = ((int)0x203B),
                WGL_DRAW_TO_PBUFFER_ARB = ((int)0x202D),
                WGL_BLUE_SHIFT_ARB = ((int)0x201A),
                WGL_MAX_PBUFFER_HEIGHT_ARB = ((int)0x2030),
                WGL_TRANSPARENT_ALPHA_VALUE_ARB = ((int)0x203A),
                WGL_ACCUM_GREEN_BITS_ARB = ((int)0x201F),
                WGL_SWAP_EXCHANGE_ARB = ((int)0x2028),
                WGL_ACCUM_ALPHA_BITS_ARB = ((int)0x2021),
                WGL_NUMBER_UNDERLAYS_ARB = ((int)0x2009),
                WGL_DEPTH_BITS_ARB = ((int)0x2022),
                WGL_STEREO_ARB = ((int)0x2012),
                WGL_SUPPORT_OPENGL_ARB = ((int)0x2010),
                WGL_SHARE_DEPTH_ARB = ((int)0x200C),
                WGL_NUMBER_PIXEL_FORMATS_ARB = ((int)0x2000),
                WGL_PBUFFER_WIDTH_ARB = ((int)0x2034),
                WGL_SHARE_ACCUM_ARB = ((int)0x200E),
                WGL_RED_BITS_ARB = ((int)0x2015),
                WGL_TRANSPARENT_GREEN_VALUE_ARB = ((int)0x2038),
                WGL_SUPPORT_GDI_ARB = ((int)0x200F),
                WGL_DOUBLE_BUFFER_ARB = ((int)0x2011),
                WGL_TRANSPARENT_RED_VALUE_ARB = ((int)0x2037),
                WGL_NEED_SYSTEM_PALETTE_ARB = ((int)0x2005),
                WGL_COLOR_BITS_ARB = ((int)0x2014),
                WGL_ALPHA_BITS_ARB = ((int)0x201B),
                WGL_ACCUM_BITS_ARB = ((int)0x201D),
                WGL_DRAW_TO_WINDOW_ARB = ((int)0x2001),
                WGL_PBUFFER_HEIGHT_ARB = ((int)0x2035),
                WGL_GREEN_BITS_ARB = ((int)0x2017),
                WGL_NEED_PALETTE_ARB = ((int)0x2004),
                WGL_STENCIL_BITS_ARB = ((int)0x2023),
                WGL_TRANSPARENT_BLUE_VALUE_ARB = ((int)0x2039),
                WGL_GENERIC_ACCELERATION_ARB = ((int)0x2026),
                WGL_ACCELERATION_ARB = ((int)0x2003),
                WGL_MAX_PBUFFER_WIDTH_ARB = ((int)0x202F),
                WGL_RED_SHIFT_ARB = ((int)0x2016),
                WGL_TYPE_RGBA_ARB = ((int)0x202B),
                WGL_NUMBER_OVERLAYS_ARB = ((int)0x2008),
                WGL_BLUE_BITS_ARB = ((int)0x2019),
                WGL_SWAP_METHOD_ARB = ((int)0x2007),
                WGL_ACCUM_RED_BITS_ARB = ((int)0x201E),
                WGL_GREEN_SHIFT_ARB = ((int)0x2018),
                WGL_ALPHA_SHIFT_ARB = ((int)0x201C),
                WGL_PBUFFER_LARGEST_ARB = ((int)0x2033),
                WGL_SWAP_UNDEFINED_ARB = ((int)0x202A),
                WGL_SWAP_LAYER_BUFFERS_ARB = ((int)0x2006),
                WGL_AUX_BUFFERS_ARB = ((int)0x2024),
                WGL_TRANSPARENT_ARB = ((int)0x200A),
            }
            
            public enum WGL_EXT_pbuffer
            {
                WGL_PBUFFER_HEIGHT_EXT = ((int)0x2035),
                WGL_MAX_PBUFFER_HEIGHT_EXT = ((int)0x2030),
                WGL_OPTIMAL_PBUFFER_WIDTH_EXT = ((int)0x2031),
                WGL_MAX_PBUFFER_WIDTH_EXT = ((int)0x202F),
                WGL_PBUFFER_WIDTH_EXT = ((int)0x2034),
                WGL_PBUFFER_LARGEST_EXT = ((int)0x2033),
                WGL_OPTIMAL_PBUFFER_HEIGHT_EXT = ((int)0x2032),
                WGL_DRAW_TO_PBUFFER_EXT = ((int)0x202D),
                WGL_MAX_PBUFFER_PIXELS_EXT = ((int)0x202E),
            }
            
            public enum WGL_ARB_pbuffer
            {
                WGL_TRANSPARENT_ALPHA_VALUE_ARB = ((int)0x203A),
                WGL_TRANSPARENT_INDEX_VALUE_ARB = ((int)0x203B),
                WGL_PBUFFER_WIDTH_ARB = ((int)0x2034),
                WGL_TRANSPARENT_BLUE_VALUE_ARB = ((int)0x2039),
                WGL_MAX_PBUFFER_HEIGHT_ARB = ((int)0x2030),
                WGL_PBUFFER_LARGEST_ARB = ((int)0x2033),
                WGL_DRAW_TO_PBUFFER_ARB = ((int)0x202D),
                WGL_MAX_PBUFFER_WIDTH_ARB = ((int)0x202F),
                WGL_PBUFFER_HEIGHT_ARB = ((int)0x2035),
                WGL_PBUFFER_LOST_ARB = ((int)0x2036),
                WGL_TRANSPARENT_RED_VALUE_ARB = ((int)0x2037),
                WGL_MAX_PBUFFER_PIXELS_ARB = ((int)0x202E),
                WGL_TRANSPARENT_GREEN_VALUE_ARB = ((int)0x2038),
            }
            
            public enum WGL_EXT_depth_float
            {
                WGL_DEPTH_FLOAT_EXT = ((int)0x2040),
            }
            
            public enum WGL_EXT_multisample
            {
                WGL_SAMPLES_EXT = ((int)0x2042),
                WGL_SAMPLE_BUFFERS_EXT = ((int)0x2041),
            }
            
            public enum WGL_ARB_multisample
            {
                WGL_SAMPLE_BUFFERS_ARB = ((int)0x2041),
                WGL_SAMPLES_ARB = ((int)0x2042),
            }
            
            public enum WGL_EXT_make_current_read
            {
                ERROR_INVALID_PIXEL_TYPE_EXT = ((int)0x2043),
            }
            
            public enum WGL_ARB_make_current_read
            {
                ERROR_INVALID_PIXEL_TYPE_ARB = ((int)0x2043),
                ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = ((int)0x2054),
            }
            
            public enum WGL_I3D_genlock
            {
                WGL_GENLOCK_SOURCE_EXTENAL_SYNC_I3D = ((int)0x2045),
                WGL_GENLOCK_SOURCE_EXTENAL_TTL_I3D = ((int)0x2047),
                WGL_GENLOCK_SOURCE_EXTENAL_FIELD_I3D = ((int)0x2046),
                WGL_GENLOCK_SOURCE_MULTIVIEW_I3D = ((int)0x2044),
                WGL_GENLOCK_SOURCE_EDGE_RISING_I3D = ((int)0x204B),
                WGL_GENLOCK_SOURCE_EDGE_BOTH_I3D = ((int)0x204C),
                WGL_GENLOCK_SOURCE_EDGE_FALLING_I3D = ((int)0x204A),
                WGL_GENLOCK_SOURCE_DIGITAL_FIELD_I3D = ((int)0x2049),
                WGL_GENLOCK_SOURCE_DIGITAL_SYNC_I3D = ((int)0x2048),
            }
            
            public enum WGL_I3D_gamma
            {
                WGL_GAMMA_EXCLUDE_DESKTOP_I3D = ((int)0x204F),
                WGL_GAMMA_TABLE_SIZE_I3D = ((int)0x204E),
            }
            
            public enum WGL_I3D_digital_video_control
            {
                WGL_DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D = ((int)0x2050),
                WGL_DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = ((int)0x2053),
                WGL_DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = ((int)0x2052),
                WGL_DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = ((int)0x2051),
            }
            
            public enum WGL_3DFX_multisample
            {
                WGL_SAMPLES_3DFX = ((int)0x2061),
                WGL_SAMPLE_BUFFERS_3DFX = ((int)0x2060),
            }
            
            public enum WGL_ARB_render_texture
            {
                WGL_TEXTURE_2D_ARB = ((int)0x207A),
                WGL_TEXTURE_CUBE_MAP_ARB = ((int)0x2078),
                WGL_AUX9_ARB = ((int)0x2090),
                WGL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = ((int)0x2081),
                WGL_AUX3_ARB = ((int)0x208A),
                WGL_FRONT_RIGHT_ARB = ((int)0x2084),
                WGL_TEXTURE_1D_ARB = ((int)0x2079),
                WGL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = ((int)0x2080),
                WGL_AUX4_ARB = ((int)0x208B),
                WGL_CUBE_MAP_FACE_ARB = ((int)0x207C),
                WGL_TEXTURE_RGBA_ARB = ((int)0x2076),
                WGL_AUX8_ARB = ((int)0x208F),
                WGL_BIND_TO_TEXTURE_RGBA_ARB = ((int)0x2071),
                WGL_TEXTURE_TARGET_ARB = ((int)0x2073),
                WGL_BACK_LEFT_ARB = ((int)0x2085),
                WGL_BIND_TO_TEXTURE_RGB_ARB = ((int)0x2070),
                WGL_TEXTURE_RGB_ARB = ((int)0x2075),
                WGL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = ((int)0x207E),
                WGL_NO_TEXTURE_ARB = ((int)0x2077),
                WGL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB = ((int)0x207D),
                WGL_TEXTURE_FORMAT_ARB = ((int)0x2072),
                WGL_AUX1_ARB = ((int)0x2088),
                WGL_AUX2_ARB = ((int)0x2089),
                WGL_AUX0_ARB = ((int)0x2087),
                WGL_BACK_RIGHT_ARB = ((int)0x2086),
                WGL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = ((int)0x207F),
                WGL_MIPMAP_TEXTURE_ARB = ((int)0x2074),
                WGL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = ((int)0x2082),
                WGL_AUX7_ARB = ((int)0x208E),
                WGL_FRONT_LEFT_ARB = ((int)0x2083),
                WGL_MIPMAP_LEVEL_ARB = ((int)0x207B),
                WGL_AUX6_ARB = ((int)0x208D),
                WGL_AUX5_ARB = ((int)0x208C),
            }
            
            public enum WGL_NV_render_texture_rectangle
            {
                WGL_TEXTURE_RECTANGLE_NV = ((int)0x20A2),
                WGL_BIND_TO_TEXTURE_RECTANGLE_RGB_NV = ((int)0x20A0),
                WGL_BIND_TO_TEXTURE_RECTANGLE_RGBA_NV = ((int)0x20A1),
            }
            
            public enum WGL_NV_render_depth_texture
            {
                WGL_DEPTH_TEXTURE_FORMAT_NV = ((int)0x20A5),
                WGL_BIND_TO_TEXTURE_DEPTH_NV = ((int)0x20A3),
                WGL_BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV = ((int)0x20A4),
                WGL_TEXTURE_DEPTH_COMPONENT_NV = ((int)0x20A6),
                WGL_DEPTH_COMPONENT_NV = ((int)0x20A7),
            }
            
            public enum WGL_NV_float_buffer
            {
                WGL_TEXTURE_FLOAT_R_NV = ((int)0x20B5),
                WGL_TEXTURE_FLOAT_RG_NV = ((int)0x20B6),
                WGL_FLOAT_COMPONENTS_NV = ((int)0x20B0),
                WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV = ((int)0x20B4),
                WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV = ((int)0x20B1),
                WGL_TEXTURE_FLOAT_RGB_NV = ((int)0x20B7),
                WGL_TEXTURE_FLOAT_RGBA_NV = ((int)0x20B8),
                WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV = ((int)0x20B2),
                WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV = ((int)0x20B3),
            }
            
            public enum WGL_ARB_pixel_format_float
            {
                WGL_TYPE_RGBA_FLOAT_ARB = ((int)0x21A0),
            }
            
            public enum WGL_ATI_pixel_format_float
            {
                WGL_TYPE_RGBA_FLOAT_ATI = ((int)0x21A0),
            }
            
            public enum All
            {
                WGL_ALPHA_SHIFT_ARB = ((int)0x201C),
                WGL_GENLOCK_SOURCE_EXTENAL_SYNC_I3D = ((int)0x2045),
                WGL_BLUE_BITS_EXT = ((int)0x2019),
                WGL_MIPMAP_TEXTURE_ARB = ((int)0x2074),
                WGL_SWAP_METHOD_EXT = ((int)0x2007),
                WGL_GENLOCK_SOURCE_EXTENAL_FIELD_I3D = ((int)0x2046),
                WGL_DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D = ((int)0x2050),
                WGL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = ((int)0x207F),
                WGL_GENLOCK_SOURCE_EDGE_BOTH_I3D = ((int)0x204C),
                WGL_AUX8_ARB = ((int)0x208F),
                WGL_TEXTURE_TARGET_ARB = ((int)0x2073),
                WGL_AUX0_ARB = ((int)0x2087),
                ERROR_INVALID_PIXEL_TYPE_EXT = ((int)0x2043),
                WGL_AUX_BUFFERS_EXT = ((int)0x2024),
                WGL_GENLOCK_SOURCE_EDGE_FALLING_I3D = ((int)0x204A),
                WGL_MAX_PBUFFER_HEIGHT_EXT = ((int)0x2030),
                WGL_GENLOCK_SOURCE_EDGE_RISING_I3D = ((int)0x204B),
                WGL_BLUE_SHIFT_ARB = ((int)0x201A),
                WGL_SWAP_UNDEFINED_ARB = ((int)0x202A),
                WGL_SWAP_EXCHANGE_ARB = ((int)0x2028),
                WGL_BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV = ((int)0x20A4),
                WGL_AUX6_ARB = ((int)0x208D),
                WGL_TEXTURE_RECTANGLE_NV = ((int)0x20A2),
                WGL_SUPPORT_GDI_EXT = ((int)0x200F),
                WGL_DEPTH_BITS_EXT = ((int)0x2022),
                WGL_AUX2_ARB = ((int)0x2089),
                WGL_DOUBLE_BUFFER_EXT = ((int)0x2011),
                WGL_PBUFFER_WIDTH_EXT = ((int)0x2034),
                WGL_SHARE_DEPTH_EXT = ((int)0x200C),
                WGL_SWAP_UNDEFINED_EXT = ((int)0x202A),
                WGL_AUX9_ARB = ((int)0x2090),
                WGL_TYPE_RGBA_FLOAT_ARB = ((int)0x21A0),
                WGL_SAMPLE_BUFFERS_ARB = ((int)0x2041),
                WGL_NUMBER_OVERLAYS_EXT = ((int)0x2008),
                WGL_PIXEL_TYPE_EXT = ((int)0x2013),
                WGL_BACK_LEFT_ARB = ((int)0x2085),
                WGL_TEXTURE_2D_ARB = ((int)0x207A),
                WGL_CUBE_MAP_FACE_ARB = ((int)0x207C),
                WGL_FRONT_COLOR_BUFFER_BIT_ARB = ((int)0x00000001),
                WGL_MAX_PBUFFER_WIDTH_EXT = ((int)0x202F),
                WGL_RED_BITS_EXT = ((int)0x2015),
                WGL_MAX_PBUFFER_WIDTH_ARB = ((int)0x202F),
                WGL_NO_TEXTURE_ARB = ((int)0x2077),
                WGL_SWAP_METHOD_ARB = ((int)0x2007),
                WGL_STENCIL_BUFFER_BIT_ARB = ((int)0x00000008),
                WGL_GENLOCK_SOURCE_DIGITAL_SYNC_I3D = ((int)0x2048),
                WGL_SAMPLES_ARB = ((int)0x2042),
                WGL_TRANSPARENT_BLUE_VALUE_ARB = ((int)0x2039),
                WGL_BACK_RIGHT_ARB = ((int)0x2086),
                WGL_ALPHA_BITS_ARB = ((int)0x201B),
                WGL_TRANSPARENT_VALUE_EXT = ((int)0x200B),
                WGL_OPTIMAL_PBUFFER_WIDTH_EXT = ((int)0x2031),
                WGL_NUMBER_OVERLAYS_ARB = ((int)0x2008),
                WGL_SUPPORT_OPENGL_EXT = ((int)0x2010),
                WGL_DRAW_TO_BITMAP_EXT = ((int)0x2002),
                WGL_BLUE_SHIFT_EXT = ((int)0x201A),
                WGL_SHARE_STENCIL_EXT = ((int)0x200D),
                WGL_TRANSPARENT_GREEN_VALUE_ARB = ((int)0x2038),
                WGL_PBUFFER_WIDTH_ARB = ((int)0x2034),
                WGL_TEXTURE_DEPTH_COMPONENT_NV = ((int)0x20A6),
                WGL_PBUFFER_LARGEST_EXT = ((int)0x2033),
                WGL_ACCUM_GREEN_BITS_ARB = ((int)0x201F),
                WGL_MIPMAP_LEVEL_ARB = ((int)0x207B),
                WGL_PIXEL_TYPE_ARB = ((int)0x2013),
                WGL_GREEN_SHIFT_ARB = ((int)0x2018),
                WGL_DRAW_TO_WINDOW_EXT = ((int)0x2001),
                WGL_RED_BITS_ARB = ((int)0x2015),
                WGL_ACCUM_RED_BITS_EXT = ((int)0x201E),
                WGL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = ((int)0x2080),
                WGL_DEPTH_COMPONENT_NV = ((int)0x20A7),
                WGL_PBUFFER_LARGEST_ARB = ((int)0x2033),
                WGL_STEREO_EXT = ((int)0x2012),
                WGL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = ((int)0x207E),
                WGL_GREEN_BITS_EXT = ((int)0x2017),
                WGL_NEED_PALETTE_EXT = ((int)0x2004),
                WGL_GREEN_SHIFT_EXT = ((int)0x2018),
                WGL_ACCUM_BITS_ARB = ((int)0x201D),
                WGL_DRAW_TO_WINDOW_ARB = ((int)0x2001),
                WGL_SHARE_DEPTH_ARB = ((int)0x200C),
                WGL_DOUBLE_BUFFER_ARB = ((int)0x2011),
                WGL_DEPTH_FLOAT_EXT = ((int)0x2040),
                WGL_TRANSPARENT_RED_VALUE_ARB = ((int)0x2037),
                WGL_FULL_ACCELERATION_ARB = ((int)0x2027),
                WGL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = ((int)0x2081),
                WGL_RED_SHIFT_ARB = ((int)0x2016),
                WGL_GENLOCK_SOURCE_MULTIVIEW_I3D = ((int)0x2044),
                WGL_FULL_ACCELERATION_EXT = ((int)0x2027),
                WGL_SWAP_COPY_ARB = ((int)0x2029),
                WGL_AUX1_ARB = ((int)0x2088),
                WGL_ACCELERATION_EXT = ((int)0x2003),
                WGL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = ((int)0x2082),
                WGL_IMAGE_BUFFER_LOCK_I3D = ((int)0x00000002),
                WGL_GENERIC_ACCELERATION_EXT = ((int)0x2026),
                WGL_ACCUM_RED_BITS_ARB = ((int)0x201E),
                WGL_GREEN_BITS_ARB = ((int)0x2017),
                WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV = ((int)0x20B4),
                WGL_AUX7_ARB = ((int)0x208E),
                WGL_SHARE_STENCIL_ARB = ((int)0x200D),
                WGL_AUX3_ARB = ((int)0x208A),
                WGL_BLUE_BITS_ARB = ((int)0x2019),
                WGL_DRAW_TO_PBUFFER_ARB = ((int)0x202D),
                WGL_ACCELERATION_ARB = ((int)0x2003),
                WGL_SAMPLES_3DFX = ((int)0x2061),
                WGL_TEXTURE_CUBE_MAP_ARB = ((int)0x2078),
                WGL_TYPE_COLORINDEX_EXT = ((int)0x202C),
                WGL_MAX_PBUFFER_HEIGHT_ARB = ((int)0x2030),
                WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV = ((int)0x20B2),
                WGL_BIND_TO_TEXTURE_RGBA_ARB = ((int)0x2071),
                WGL_TYPE_RGBA_FLOAT_ATI = ((int)0x21A0),
                WGL_SAMPLES_EXT = ((int)0x2042),
                WGL_BIND_TO_TEXTURE_RECTANGLE_RGBA_NV = ((int)0x20A1),
                WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV = ((int)0x20B3),
                WGL_COLOR_BITS_ARB = ((int)0x2014),
                WGL_SUPPORT_GDI_ARB = ((int)0x200F),
                WGL_GENLOCK_SOURCE_DIGITAL_FIELD_I3D = ((int)0x2049),
                WGL_TEXTURE_FLOAT_R_NV = ((int)0x20B5),
                WGL_ACCUM_BLUE_BITS_EXT = ((int)0x2020),
                WGL_SAMPLE_BUFFERS_EXT = ((int)0x2041),
                WGL_DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = ((int)0x2052),
                WGL_TEXTURE_RGB_ARB = ((int)0x2075),
                WGL_ACCUM_GREEN_BITS_EXT = ((int)0x201F),
                WGL_TEXTURE_FLOAT_RG_NV = ((int)0x20B6),
                WGL_GENERIC_ACCELERATION_ARB = ((int)0x2026),
                WGL_TEXTURE_RGBA_ARB = ((int)0x2076),
                WGL_NEED_PALETTE_ARB = ((int)0x2004),
                WGL_OPTIMAL_PBUFFER_HEIGHT_EXT = ((int)0x2032),
                WGL_BACK_COLOR_BUFFER_BIT_ARB = ((int)0x00000002),
                WGL_BIND_TO_TEXTURE_DEPTH_NV = ((int)0x20A3),
                WGL_DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = ((int)0x2053),
                WGL_ACCUM_BITS_EXT = ((int)0x201D),
                ERROR_INVALID_PIXEL_TYPE_ARB = ((int)0x2043),
                WGL_PBUFFER_HEIGHT_EXT = ((int)0x2035),
                WGL_DRAW_TO_BITMAP_ARB = ((int)0x2002),
                WGL_TYPE_RGBA_EXT = ((int)0x202B),
                WGL_TEXTURE_FORMAT_ARB = ((int)0x2072),
                WGL_TRANSPARENT_ARB = ((int)0x200A),
                WGL_COLOR_BITS_EXT = ((int)0x2014),
                WGL_FLOAT_COMPONENTS_NV = ((int)0x20B0),
                WGL_ACCUM_BLUE_BITS_ARB = ((int)0x2020),
                WGL_TYPE_RGBA_ARB = ((int)0x202B),
                WGL_SWAP_LAYER_BUFFERS_EXT = ((int)0x2006),
                WGL_ALPHA_BITS_EXT = ((int)0x201B),
                WGL_SWAP_EXCHANGE_EXT = ((int)0x2028),
                WGL_DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = ((int)0x2051),
                WGL_SHARE_ACCUM_ARB = ((int)0x200E),
                WGL_MAX_PBUFFER_PIXELS_EXT = ((int)0x202E),
                WGL_TEXTURE_FLOAT_RGB_NV = ((int)0x20B7),
                WGL_PBUFFER_HEIGHT_ARB = ((int)0x2035),
                WGL_ACCUM_ALPHA_BITS_ARB = ((int)0x2021),
                WGL_DEPTH_BUFFER_BIT_ARB = ((int)0x00000004),
                WGL_NUMBER_UNDERLAYS_ARB = ((int)0x2009),
                WGL_SWAP_LAYER_BUFFERS_ARB = ((int)0x2006),
                WGL_SHARE_ACCUM_EXT = ((int)0x200E),
                WGL_PBUFFER_LOST_ARB = ((int)0x2036),
                WGL_AUX5_ARB = ((int)0x208C),
                WGL_GAMMA_TABLE_SIZE_I3D = ((int)0x204E),
                WGL_NO_ACCELERATION_ARB = ((int)0x2025),
                WGL_AUX4_ARB = ((int)0x208B),
                WGL_TEXTURE_1D_ARB = ((int)0x2079),
                WGL_NEED_SYSTEM_PALETTE_EXT = ((int)0x2005),
                WGL_NUMBER_PIXEL_FORMATS_EXT = ((int)0x2000),
                WGL_FRONT_LEFT_ARB = ((int)0x2083),
                WGL_DRAW_TO_PBUFFER_EXT = ((int)0x202D),
                WGL_BIND_TO_TEXTURE_RECTANGLE_RGB_NV = ((int)0x20A0),
                WGL_ALPHA_SHIFT_EXT = ((int)0x201C),
                WGL_ACCUM_ALPHA_BITS_EXT = ((int)0x2021),
                WGL_SUPPORT_OPENGL_ARB = ((int)0x2010),
                WGL_STENCIL_BITS_EXT = ((int)0x2023),
                WGL_TYPE_COLORINDEX_ARB = ((int)0x202C),
                WGL_SAMPLE_BUFFERS_3DFX = ((int)0x2060),
                WGL_STEREO_ARB = ((int)0x2012),
                ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = ((int)0x2054),
                WGL_AUX_BUFFERS_ARB = ((int)0x2024),
                WGL_TRANSPARENT_INDEX_VALUE_ARB = ((int)0x203B),
                WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV = ((int)0x20B1),
                WGL_TRANSPARENT_EXT = ((int)0x200A),
                WGL_NEED_SYSTEM_PALETTE_ARB = ((int)0x2005),
                WGL_STENCIL_BITS_ARB = ((int)0x2023),
                WGL_DEPTH_BITS_ARB = ((int)0x2022),
                WGL_NUMBER_PIXEL_FORMATS_ARB = ((int)0x2000),
                WGL_GAMMA_EXCLUDE_DESKTOP_I3D = ((int)0x204F),
                WGL_TRANSPARENT_ALPHA_VALUE_ARB = ((int)0x203A),
                WGL_FRONT_RIGHT_ARB = ((int)0x2084),
                WGL_RED_SHIFT_EXT = ((int)0x2016),
                WGL_MAX_PBUFFER_PIXELS_ARB = ((int)0x202E),
                WGL_NO_ACCELERATION_EXT = ((int)0x2025),
                WGL_NUMBER_UNDERLAYS_EXT = ((int)0x2009),
                WGL_DEPTH_TEXTURE_FORMAT_NV = ((int)0x20A5),
                WGL_GENLOCK_SOURCE_EXTENAL_TTL_I3D = ((int)0x2047),
                WGL_SWAP_COPY_EXT = ((int)0x2029),
                WGL_TEXTURE_FLOAT_RGBA_NV = ((int)0x20B8),
                WGL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB = ((int)0x207D),
                WGL_IMAGE_BUFFER_MIN_ACCESS_I3D = ((int)0x00000001),
                WGL_BIND_TO_TEXTURE_RGB_ARB = ((int)0x2070),
            }
            
            public enum WGL_ARB_extensions_string
            {
            }
            
            public enum WGL_I3D_image_buffer
            {
                WGL_IMAGE_BUFFER_MIN_ACCESS_I3D = ((int)0x00000001),
                WGL_IMAGE_BUFFER_LOCK_I3D = ((int)0x00000002),
            }
            
            public enum WGL_I3D_swap_frame_lock
            {
            }
            
        }
    }
}
