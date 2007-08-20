namespace OpenTK.Platform.Windows
{
    public static partial class Wgl
    {
        public class Enums
        {
            public enum WGL_ARB_buffer_region
            {
                STENCIL_BUFFER_BIT_ARB = ((int)0x00000008),
                DEPTH_BUFFER_BIT_ARB = ((int)0x00000004),
                BACK_COLOR_BUFFER_BIT_ARB = ((int)0x00000002),
                FRONT_COLOR_BUFFER_BIT_ARB = ((int)0x00000001),
            }
            
            public enum WGL_EXT_pixel_format
            {
                SWAP_LAYER_BUFFERS_EXT = ((int)0x2006),
                NUMBER_UNDERLAYS_EXT = ((int)0x2009),
                SHARE_STENCIL_EXT = ((int)0x200D),
                ACCELERATION_EXT = ((int)0x2003),
                GREEN_SHIFT_EXT = ((int)0x2018),
                TRANSPARENT_EXT = ((int)0x200A),
                DRAW_TO_WINDOW_EXT = ((int)0x2001),
                TYPE_COLORINDEX_EXT = ((int)0x202C),
                PIXEL_TYPE_EXT = ((int)0x2013),
                ACCUM_ALPHA_BITS_EXT = ((int)0x2021),
                STEREO_EXT = ((int)0x2012),
                BLUE_SHIFT_EXT = ((int)0x201A),
                GENERIC_ACCELERATION_EXT = ((int)0x2026),
                ACCUM_RED_BITS_EXT = ((int)0x201E),
                STENCIL_BITS_EXT = ((int)0x2023),
                FULL_ACCELERATION_EXT = ((int)0x2027),
                NO_ACCELERATION_EXT = ((int)0x2025),
                ALPHA_BITS_EXT = ((int)0x201B),
                DRAW_TO_BITMAP_EXT = ((int)0x2002),
                DEPTH_BITS_EXT = ((int)0x2022),
                SWAP_METHOD_EXT = ((int)0x2007),
                BLUE_BITS_EXT = ((int)0x2019),
                SWAP_UNDEFINED_EXT = ((int)0x202A),
                SUPPORT_OPENGL_EXT = ((int)0x2010),
                NUMBER_OVERLAYS_EXT = ((int)0x2008),
                AUX_BUFFERS_EXT = ((int)0x2024),
                SHARE_DEPTH_EXT = ((int)0x200C),
                TRANSPARENT_VALUE_EXT = ((int)0x200B),
                SUPPORT_GDI_EXT = ((int)0x200F),
                SWAP_COPY_EXT = ((int)0x2029),
                TYPE_RGBA_EXT = ((int)0x202B),
                SWAP_EXCHANGE_EXT = ((int)0x2028),
                NEED_SYSTEM_PALETTE_EXT = ((int)0x2005),
                DOUBLE_BUFFER_EXT = ((int)0x2011),
                ACCUM_GREEN_BITS_EXT = ((int)0x201F),
                RED_SHIFT_EXT = ((int)0x2016),
                COLOR_BITS_EXT = ((int)0x2014),
                ALPHA_SHIFT_EXT = ((int)0x201C),
                SHARE_ACCUM_EXT = ((int)0x200E),
                NUMBER_PIXEL_FORMATS_EXT = ((int)0x2000),
                RED_BITS_EXT = ((int)0x2015),
                GREEN_BITS_EXT = ((int)0x2017),
                ACCUM_BITS_EXT = ((int)0x201D),
                ACCUM_BLUE_BITS_EXT = ((int)0x2020),
                NEED_PALETTE_EXT = ((int)0x2004),
            }
            
            public enum WGL_ARB_pixel_format
            {
                SHARE_DEPTH_ARB = ((int)0x200C),
                RED_BITS_ARB = ((int)0x2015),
                BLUE_BITS_ARB = ((int)0x2019),
                BLUE_SHIFT_ARB = ((int)0x201A),
                GREEN_BITS_ARB = ((int)0x2017),
                MAX_PBUFFER_PIXELS_ARB = ((int)0x202E),
                TYPE_COLORINDEX_ARB = ((int)0x202C),
                NO_ACCELERATION_ARB = ((int)0x2025),
                SWAP_COPY_ARB = ((int)0x2029),
                PBUFFER_LARGEST_ARB = ((int)0x2033),
                ACCUM_BITS_ARB = ((int)0x201D),
                ACCUM_GREEN_BITS_ARB = ((int)0x201F),
                ALPHA_SHIFT_ARB = ((int)0x201C),
                FULL_ACCELERATION_ARB = ((int)0x2027),
                SWAP_METHOD_ARB = ((int)0x2007),
                STENCIL_BITS_ARB = ((int)0x2023),
                STEREO_ARB = ((int)0x2012),
                MAX_PBUFFER_WIDTH_ARB = ((int)0x202F),
                DRAW_TO_PBUFFER_ARB = ((int)0x202D),
                TYPE_RGBA_ARB = ((int)0x202B),
                MAX_PBUFFER_HEIGHT_ARB = ((int)0x2030),
                DRAW_TO_BITMAP_ARB = ((int)0x2002),
                GREEN_SHIFT_ARB = ((int)0x2018),
                SUPPORT_GDI_ARB = ((int)0x200F),
                PBUFFER_WIDTH_ARB = ((int)0x2034),
                DOUBLE_BUFFER_ARB = ((int)0x2011),
                TRANSPARENT_ALPHA_VALUE_ARB = ((int)0x203A),
                ACCUM_ALPHA_BITS_ARB = ((int)0x2021),
                AUX_BUFFERS_ARB = ((int)0x2024),
                ALPHA_BITS_ARB = ((int)0x201B),
                NUMBER_OVERLAYS_ARB = ((int)0x2008),
                SHARE_ACCUM_ARB = ((int)0x200E),
                SWAP_EXCHANGE_ARB = ((int)0x2028),
                ACCELERATION_ARB = ((int)0x2003),
                TRANSPARENT_GREEN_VALUE_ARB = ((int)0x2038),
                ACCUM_RED_BITS_ARB = ((int)0x201E),
                TRANSPARENT_BLUE_VALUE_ARB = ((int)0x2039),
                TRANSPARENT_INDEX_VALUE_ARB = ((int)0x203B),
                GENERIC_ACCELERATION_ARB = ((int)0x2026),
                TRANSPARENT_ARB = ((int)0x200A),
                NUMBER_UNDERLAYS_ARB = ((int)0x2009),
                SWAP_UNDEFINED_ARB = ((int)0x202A),
                DEPTH_BITS_ARB = ((int)0x2022),
                NUMBER_PIXEL_FORMATS_ARB = ((int)0x2000),
                TRANSPARENT_RED_VALUE_ARB = ((int)0x2037),
                SHARE_STENCIL_ARB = ((int)0x200D),
                DRAW_TO_WINDOW_ARB = ((int)0x2001),
                PBUFFER_HEIGHT_ARB = ((int)0x2035),
                PIXEL_TYPE_ARB = ((int)0x2013),
                COLOR_BITS_ARB = ((int)0x2014),
                NEED_PALETTE_ARB = ((int)0x2004),
                NEED_SYSTEM_PALETTE_ARB = ((int)0x2005),
                SWAP_LAYER_BUFFERS_ARB = ((int)0x2006),
                RED_SHIFT_ARB = ((int)0x2016),
                SUPPORT_OPENGL_ARB = ((int)0x2010),
                ACCUM_BLUE_BITS_ARB = ((int)0x2020),
            }
            
            public enum WGL_EXT_pbuffer
            {
                DRAW_TO_PBUFFER_EXT = ((int)0x202D),
                OPTIMAL_PBUFFER_WIDTH_EXT = ((int)0x2031),
                PBUFFER_LARGEST_EXT = ((int)0x2033),
                PBUFFER_WIDTH_EXT = ((int)0x2034),
                OPTIMAL_PBUFFER_HEIGHT_EXT = ((int)0x2032),
                MAX_PBUFFER_HEIGHT_EXT = ((int)0x2030),
                PBUFFER_HEIGHT_EXT = ((int)0x2035),
                MAX_PBUFFER_WIDTH_EXT = ((int)0x202F),
                MAX_PBUFFER_PIXELS_EXT = ((int)0x202E),
            }
            
            public enum WGL_ARB_pbuffer
            {
                MAX_PBUFFER_WIDTH_ARB = ((int)0x202F),
                DRAW_TO_PBUFFER_ARB = ((int)0x202D),
                PBUFFER_WIDTH_ARB = ((int)0x2034),
                MAX_PBUFFER_HEIGHT_ARB = ((int)0x2030),
                PBUFFER_HEIGHT_ARB = ((int)0x2035),
                PBUFFER_LOST_ARB = ((int)0x2036),
                PBUFFER_LARGEST_ARB = ((int)0x2033),
                TRANSPARENT_BLUE_VALUE_ARB = ((int)0x2039),
                TRANSPARENT_INDEX_VALUE_ARB = ((int)0x203B),
                TRANSPARENT_ALPHA_VALUE_ARB = ((int)0x203A),
                MAX_PBUFFER_PIXELS_ARB = ((int)0x202E),
                TRANSPARENT_GREEN_VALUE_ARB = ((int)0x2038),
                TRANSPARENT_RED_VALUE_ARB = ((int)0x2037),
            }
            
            public enum WGL_EXT_depth_float
            {
                DEPTH_FLOAT_EXT = ((int)0x2040),
            }
            
            public enum WGL_EXT_multisample
            {
                SAMPLE_BUFFERS_EXT = ((int)0x2041),
                SAMPLES_EXT = ((int)0x2042),
            }
            
            public enum WGL_ARB_multisample
            {
                SAMPLE_BUFFERS_ARB = ((int)0x2041),
                SAMPLES_ARB = ((int)0x2042),
            }
            
            public enum WGL_EXT_make_current_read
            {
                ERROR_INVALID_PIXEL_TYPE_EXT = ((int)0x2043),
            }
            
            public enum WGL_ARB_make_current_read
            {
                ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = ((int)0x2054),
                ERROR_INVALID_PIXEL_TYPE_ARB = ((int)0x2043),
            }
            
            public enum WGL_I3D_genlock
            {
                GENLOCK_SOURCE_EDGE_BOTH_I3D = ((int)0x204C),
                GENLOCK_SOURCE_EXTENAL_SYNC_I3D = ((int)0x2045),
                GENLOCK_SOURCE_DIGITAL_FIELD_I3D = ((int)0x2049),
                GENLOCK_SOURCE_EDGE_FALLING_I3D = ((int)0x204A),
                GENLOCK_SOURCE_EDGE_RISING_I3D = ((int)0x204B),
                GENLOCK_SOURCE_DIGITAL_SYNC_I3D = ((int)0x2048),
                GENLOCK_SOURCE_EXTENAL_TTL_I3D = ((int)0x2047),
                GENLOCK_SOURCE_MULTIVIEW_I3D = ((int)0x2044),
                GENLOCK_SOURCE_EXTENAL_FIELD_I3D = ((int)0x2046),
            }
            
            public enum WGL_I3D_gamma
            {
                GAMMA_TABLE_SIZE_I3D = ((int)0x204E),
                GAMMA_EXCLUDE_DESKTOP_I3D = ((int)0x204F),
            }
            
            public enum WGL_I3D_digital_video_control
            {
                DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = ((int)0x2053),
                DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D = ((int)0x2050),
                DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = ((int)0x2052),
                DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = ((int)0x2051),
            }
            
            public enum WGL_3DFX_multisample
            {
                SAMPLES_3DFX = ((int)0x2061),
                SAMPLE_BUFFERS_3DFX = ((int)0x2060),
            }
            
            public enum WGL_ARB_render_texture
            {
                CUBE_MAP_FACE_ARB = ((int)0x207C),
                TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = ((int)0x2081),
                AUX0_ARB = ((int)0x2087),
                TEXTURE_CUBE_MAP_ARB = ((int)0x2078),
                TEXTURE_1D_ARB = ((int)0x2079),
                AUX3_ARB = ((int)0x208A),
                TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = ((int)0x207E),
                NO_TEXTURE_ARB = ((int)0x2077),
                TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = ((int)0x207F),
                AUX1_ARB = ((int)0x2088),
                BACK_LEFT_ARB = ((int)0x2085),
                AUX7_ARB = ((int)0x208E),
                FRONT_LEFT_ARB = ((int)0x2083),
                TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = ((int)0x2080),
                BIND_TO_TEXTURE_RGB_ARB = ((int)0x2070),
                AUX8_ARB = ((int)0x208F),
                TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = ((int)0x2082),
                TEXTURE_CUBE_MAP_POSITIVE_X_ARB = ((int)0x207D),
                BIND_TO_TEXTURE_RGBA_ARB = ((int)0x2071),
                AUX6_ARB = ((int)0x208D),
                TEXTURE_TARGET_ARB = ((int)0x2073),
                AUX2_ARB = ((int)0x2089),
                AUX5_ARB = ((int)0x208C),
                TEXTURE_2D_ARB = ((int)0x207A),
                AUX4_ARB = ((int)0x208B),
                FRONT_RIGHT_ARB = ((int)0x2084),
                TEXTURE_RGB_ARB = ((int)0x2075),
                MIPMAP_TEXTURE_ARB = ((int)0x2074),
                MIPMAP_LEVEL_ARB = ((int)0x207B),
                TEXTURE_RGBA_ARB = ((int)0x2076),
                AUX9_ARB = ((int)0x2090),
                BACK_RIGHT_ARB = ((int)0x2086),
                TEXTURE_FORMAT_ARB = ((int)0x2072),
            }
            
            public enum WGL_NV_render_texture_rectangle
            {
                BIND_TO_TEXTURE_RECTANGLE_RGBA_NV = ((int)0x20A1),
                TEXTURE_RECTANGLE_NV = ((int)0x20A2),
                BIND_TO_TEXTURE_RECTANGLE_RGB_NV = ((int)0x20A0),
            }
            
            public enum WGL_NV_render_depth_texture
            {
                BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV = ((int)0x20A4),
                TEXTURE_DEPTH_COMPONENT_NV = ((int)0x20A6),
                DEPTH_COMPONENT_NV = ((int)0x20A7),
                DEPTH_TEXTURE_FORMAT_NV = ((int)0x20A5),
                BIND_TO_TEXTURE_DEPTH_NV = ((int)0x20A3),
            }
            
            public enum WGL_NV_float_buffer
            {
                TEXTURE_FLOAT_RG_NV = ((int)0x20B6),
                BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV = ((int)0x20B4),
                FLOAT_COMPONENTS_NV = ((int)0x20B0),
                BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV = ((int)0x20B2),
                TEXTURE_FLOAT_RGB_NV = ((int)0x20B7),
                BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV = ((int)0x20B3),
                TEXTURE_FLOAT_R_NV = ((int)0x20B5),
                TEXTURE_FLOAT_RGBA_NV = ((int)0x20B8),
                BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV = ((int)0x20B1),
            }
            
            public enum WGL_ARB_pixel_format_float
            {
                TYPE_RGBA_FLOAT_ARB = ((int)0x21A0),
            }
            
            public enum WGL_ATI_pixel_format_float
            {
                TYPE_RGBA_FLOAT_ATI = ((int)0x21A0),
            }
            
            public enum WGL_font_type
            {
                FONT_LINES = ((int)0),
            }
            
            public enum All
            {
                GENLOCK_SOURCE_EXTENAL_SYNC_I3D = ((int)0x2045),
                NUMBER_PIXEL_FORMATS_EXT = ((int)0x2000),
                SAMPLES_EXT = ((int)0x2042),
                TYPE_RGBA_FLOAT_ARB = ((int)0x21A0),
                NEED_SYSTEM_PALETTE_ARB = ((int)0x2005),
                TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = ((int)0x2082),
                TEXTURE_1D_ARB = ((int)0x2079),
                ACCELERATION_ARB = ((int)0x2003),
                STEREO_ARB = ((int)0x2012),
                SHARE_ACCUM_ARB = ((int)0x200E),
                MAX_PBUFFER_PIXELS_ARB = ((int)0x202E),
                BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV = ((int)0x20B3),
                DEPTH_COMPONENT_NV = ((int)0x20A7),
                GAMMA_TABLE_SIZE_I3D = ((int)0x204E),
                GENERIC_ACCELERATION_ARB = ((int)0x2026),
                NEED_SYSTEM_PALETTE_EXT = ((int)0x2005),
                MAX_PBUFFER_WIDTH_EXT = ((int)0x202F),
                TEXTURE_CUBE_MAP_ARB = ((int)0x2078),
                TEXTURE_2D_ARB = ((int)0x207A),
                TEXTURE_DEPTH_COMPONENT_NV = ((int)0x20A6),
                MIPMAP_LEVEL_ARB = ((int)0x207B),
                ALPHA_BITS_ARB = ((int)0x201B),
                TEXTURE_FLOAT_R_NV = ((int)0x20B5),
                PBUFFER_WIDTH_EXT = ((int)0x2034),
                BACK_LEFT_ARB = ((int)0x2085),
                MAX_PBUFFER_HEIGHT_EXT = ((int)0x2030),
                FULL_ACCELERATION_ARB = ((int)0x2027),
                TYPE_RGBA_FLOAT_ATI = ((int)0x21A0),
                SHARE_ACCUM_EXT = ((int)0x200E),
                FRONT_RIGHT_ARB = ((int)0x2084),
                ACCUM_BLUE_BITS_ARB = ((int)0x2020),
                BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV = ((int)0x20B1),
                TRANSPARENT_BLUE_VALUE_ARB = ((int)0x2039),
                SWAP_LAYER_BUFFERS_EXT = ((int)0x2006),
                AUX8_ARB = ((int)0x208F),
                RED_BITS_EXT = ((int)0x2015),
                STENCIL_BITS_ARB = ((int)0x2023),
                NUMBER_OVERLAYS_ARB = ((int)0x2008),
                AUX4_ARB = ((int)0x208B),
                STENCIL_BUFFER_BIT_ARB = ((int)0x00000008),
                GREEN_BITS_ARB = ((int)0x2017),
                ACCUM_GREEN_BITS_ARB = ((int)0x201F),
                FULL_ACCELERATION_EXT = ((int)0x2027),
                TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = ((int)0x2080),
                OPTIMAL_PBUFFER_HEIGHT_EXT = ((int)0x2032),
                AUX_BUFFERS_ARB = ((int)0x2024),
                DRAW_TO_BITMAP_EXT = ((int)0x2002),
                AUX7_ARB = ((int)0x208E),
                SUPPORT_OPENGL_ARB = ((int)0x2010),
                TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = ((int)0x207E),
                PBUFFER_LARGEST_EXT = ((int)0x2033),
                GREEN_SHIFT_EXT = ((int)0x2018),
                BLUE_BITS_EXT = ((int)0x2019),
                ACCUM_BITS_ARB = ((int)0x201D),
                DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D = ((int)0x2050),
                ACCUM_BITS_EXT = ((int)0x201D),
                SHARE_DEPTH_EXT = ((int)0x200C),
                STEREO_EXT = ((int)0x2012),
                GREEN_SHIFT_ARB = ((int)0x2018),
                SWAP_EXCHANGE_ARB = ((int)0x2028),
                GENLOCK_SOURCE_EXTENAL_TTL_I3D = ((int)0x2047),
                SUPPORT_GDI_EXT = ((int)0x200F),
                PBUFFER_HEIGHT_ARB = ((int)0x2035),
                TRANSPARENT_GREEN_VALUE_ARB = ((int)0x2038),
                AUX6_ARB = ((int)0x208D),
                FRONT_LEFT_ARB = ((int)0x2083),
                NUMBER_UNDERLAYS_ARB = ((int)0x2009),
                AUX2_ARB = ((int)0x2089),
                SAMPLE_BUFFERS_ARB = ((int)0x2041),
                RED_SHIFT_ARB = ((int)0x2016),
                MAX_PBUFFER_HEIGHT_ARB = ((int)0x2030),
                DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = ((int)0x2051),
                NUMBER_UNDERLAYS_EXT = ((int)0x2009),
                TRANSPARENT_ALPHA_VALUE_ARB = ((int)0x203A),
                SAMPLE_BUFFERS_3DFX = ((int)0x2060),
                IMAGE_BUFFER_LOCK_I3D = ((int)0x00000002),
                TRANSPARENT_RED_VALUE_ARB = ((int)0x2037),
                ACCUM_ALPHA_BITS_ARB = ((int)0x2021),
                SWAP_EXCHANGE_EXT = ((int)0x2028),
                DEPTH_BUFFER_BIT_ARB = ((int)0x00000004),
                ALPHA_BITS_EXT = ((int)0x201B),
                ACCELERATION_EXT = ((int)0x2003),
                GENLOCK_SOURCE_DIGITAL_SYNC_I3D = ((int)0x2048),
                DOUBLE_BUFFER_EXT = ((int)0x2011),
                BIND_TO_TEXTURE_RGBA_ARB = ((int)0x2071),
                SWAP_COPY_EXT = ((int)0x2029),
                FRONT_COLOR_BUFFER_BIT_ARB = ((int)0x00000001),
                BIND_TO_TEXTURE_RECTANGLE_RGB_NV = ((int)0x20A0),
                TYPE_COLORINDEX_EXT = ((int)0x202C),
                TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = ((int)0x207F),
                SAMPLE_BUFFERS_EXT = ((int)0x2041),
                IMAGE_BUFFER_MIN_ACCESS_I3D = ((int)0x00000001),
                GENLOCK_SOURCE_EDGE_FALLING_I3D = ((int)0x204A),
                BIND_TO_TEXTURE_RGB_ARB = ((int)0x2070),
                DRAW_TO_WINDOW_ARB = ((int)0x2001),
                AUX5_ARB = ((int)0x208C),
                DRAW_TO_PBUFFER_EXT = ((int)0x202D),
                GENLOCK_SOURCE_DIGITAL_FIELD_I3D = ((int)0x2049),
                DRAW_TO_WINDOW_EXT = ((int)0x2001),
                DEPTH_BITS_EXT = ((int)0x2022),
                SHARE_STENCIL_ARB = ((int)0x200D),
                TYPE_RGBA_EXT = ((int)0x202B),
                DEPTH_BITS_ARB = ((int)0x2022),
                TRANSPARENT_EXT = ((int)0x200A),
                MIPMAP_TEXTURE_ARB = ((int)0x2074),
                GENLOCK_SOURCE_EXTENAL_FIELD_I3D = ((int)0x2046),
                SWAP_LAYER_BUFFERS_ARB = ((int)0x2006),
                TEXTURE_TARGET_ARB = ((int)0x2073),
                PBUFFER_HEIGHT_EXT = ((int)0x2035),
                TRANSPARENT_ARB = ((int)0x200A),
                BIND_TO_TEXTURE_DEPTH_NV = ((int)0x20A3),
                SWAP_COPY_ARB = ((int)0x2029),
                NO_ACCELERATION_EXT = ((int)0x2025),
                TEXTURE_RECTANGLE_NV = ((int)0x20A2),
                SAMPLES_ARB = ((int)0x2042),
                BLUE_SHIFT_EXT = ((int)0x201A),
                BLUE_BITS_ARB = ((int)0x2019),
                BIND_TO_TEXTURE_RECTANGLE_RGBA_NV = ((int)0x20A1),
                DRAW_TO_BITMAP_ARB = ((int)0x2002),
                TEXTURE_CUBE_MAP_POSITIVE_X_ARB = ((int)0x207D),
                NO_ACCELERATION_ARB = ((int)0x2025),
                PIXEL_TYPE_ARB = ((int)0x2013),
                ACCUM_ALPHA_BITS_EXT = ((int)0x2021),
                NEED_PALETTE_EXT = ((int)0x2004),
                BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV = ((int)0x20A4),
                BACK_COLOR_BUFFER_BIT_ARB = ((int)0x00000002),
                DOUBLE_BUFFER_ARB = ((int)0x2011),
                NEED_PALETTE_ARB = ((int)0x2004),
                ALPHA_SHIFT_EXT = ((int)0x201C),
                NO_TEXTURE_ARB = ((int)0x2077),
                TEXTURE_FLOAT_RG_NV = ((int)0x20B6),
                SHARE_STENCIL_EXT = ((int)0x200D),
                TEXTURE_FLOAT_RGBA_NV = ((int)0x20B8),
                PBUFFER_LARGEST_ARB = ((int)0x2033),
                DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = ((int)0x2052),
                TYPE_RGBA_ARB = ((int)0x202B),
                ACCUM_RED_BITS_ARB = ((int)0x201E),
                GREEN_BITS_EXT = ((int)0x2017),
                GENLOCK_SOURCE_MULTIVIEW_I3D = ((int)0x2044),
                GENERIC_ACCELERATION_EXT = ((int)0x2026),
                FONT_LINES = ((int)0),
                ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = ((int)0x2054),
                SWAP_METHOD_EXT = ((int)0x2007),
                PIXEL_TYPE_EXT = ((int)0x2013),
                TEXTURE_FLOAT_RGB_NV = ((int)0x20B7),
                NUMBER_OVERLAYS_EXT = ((int)0x2008),
                GAMMA_EXCLUDE_DESKTOP_I3D = ((int)0x204F),
                COLOR_BITS_EXT = ((int)0x2014),
                DEPTH_FLOAT_EXT = ((int)0x2040),
                BACK_RIGHT_ARB = ((int)0x2086),
                MAX_PBUFFER_WIDTH_ARB = ((int)0x202F),
                OPTIMAL_PBUFFER_WIDTH_EXT = ((int)0x2031),
                AUX1_ARB = ((int)0x2088),
                COLOR_BITS_ARB = ((int)0x2014),
                ACCUM_BLUE_BITS_EXT = ((int)0x2020),
                TEXTURE_RGBA_ARB = ((int)0x2076),
                PBUFFER_LOST_ARB = ((int)0x2036),
                GENLOCK_SOURCE_EDGE_RISING_I3D = ((int)0x204B),
                AUX9_ARB = ((int)0x2090),
                NUMBER_PIXEL_FORMATS_ARB = ((int)0x2000),
                SWAP_METHOD_ARB = ((int)0x2007),
                RED_SHIFT_EXT = ((int)0x2016),
                MAX_PBUFFER_PIXELS_EXT = ((int)0x202E),
                AUX0_ARB = ((int)0x2087),
                TRANSPARENT_VALUE_EXT = ((int)0x200B),
                FLOAT_COMPONENTS_NV = ((int)0x20B0),
                BLUE_SHIFT_ARB = ((int)0x201A),
                TEXTURE_RGB_ARB = ((int)0x2075),
                BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV = ((int)0x20B4),
                ACCUM_GREEN_BITS_EXT = ((int)0x201F),
                ERROR_INVALID_PIXEL_TYPE_ARB = ((int)0x2043),
                DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = ((int)0x2053),
                TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = ((int)0x2081),
                AUX_BUFFERS_EXT = ((int)0x2024),
                CUBE_MAP_FACE_ARB = ((int)0x207C),
                TYPE_COLORINDEX_ARB = ((int)0x202C),
                ERROR_INVALID_PIXEL_TYPE_EXT = ((int)0x2043),
                AUX3_ARB = ((int)0x208A),
                SHARE_DEPTH_ARB = ((int)0x200C),
                SAMPLES_3DFX = ((int)0x2061),
                ALPHA_SHIFT_ARB = ((int)0x201C),
                GENLOCK_SOURCE_EDGE_BOTH_I3D = ((int)0x204C),
                SUPPORT_OPENGL_EXT = ((int)0x2010),
                SWAP_UNDEFINED_ARB = ((int)0x202A),
                RED_BITS_ARB = ((int)0x2015),
                STENCIL_BITS_EXT = ((int)0x2023),
                DEPTH_TEXTURE_FORMAT_NV = ((int)0x20A5),
                ACCUM_RED_BITS_EXT = ((int)0x201E),
                PBUFFER_WIDTH_ARB = ((int)0x2034),
                SWAP_UNDEFINED_EXT = ((int)0x202A),
                DRAW_TO_PBUFFER_ARB = ((int)0x202D),
                BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV = ((int)0x20B2),
                TEXTURE_FORMAT_ARB = ((int)0x2072),
                TRANSPARENT_INDEX_VALUE_ARB = ((int)0x203B),
                SUPPORT_GDI_ARB = ((int)0x200F),
            }
            
            public enum WGL_ARB_extensions_string
            {
            }
            
            public enum WGL_I3D_image_buffer
            {
                IMAGE_BUFFER_LOCK_I3D = ((int)0x00000002),
                IMAGE_BUFFER_MIN_ACCESS_I3D = ((int)0x00000001),
            }
            
            public enum WGL_I3D_swap_frame_lock
            {
            }
            
        }
    }
}
