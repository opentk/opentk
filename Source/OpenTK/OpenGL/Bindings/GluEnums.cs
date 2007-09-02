namespace OpenTK.OpenGL
{
    public static partial class Glu
    {
        public class Enums
        {
            public enum Boolean
            {
                TRUE = ((int)1),
                FALSE = ((int)0),
            }
            
            public enum Version
            {
                VERSION_1_1 = ((int)1),
                VERSION_1_2 = ((int)1),
                VERSION_1_3 = ((int)1),
            }
            
            public enum StringName
            {
                VERSION = ((int)100800),
                EXTENSIONS = ((int)100801),
            }
            
            public enum ErrorCode
            {
                INVALID_ENUM = ((int)100900),
                OUT_OF_MEMORY = ((int)100902),
                INVALID_OPERATION = ((int)100904),
                INVALID_VALUE = ((int)100901),
            }
            
            public enum Filter4TypeSGIS
            {
                LAGRANGIAN_SGI = ((int)100300),
                MITCHELL_NETRAVALI_SGI = ((int)100301),
            }
            
            public enum NurbsDisplay
            {
                FILL = ((int)QuadricDrawStyle.FILL),
                OUTLINE_POLYGON = ((int)100240),
                OUTLINE_PATCH = ((int)100241),
            }
            
            public enum NurbsCallback
            {
                NURBS_END_DATA_EXT = ((int)100175),
                NURBS_TEXTURE_COORD_DATA = ((int)100174),
                NURBS_ERROR = ((int)100103),
                NURBS_END = ((int)100169),
                NURBS_NORMAL_DATA_EXT = ((int)100172),
                NURBS_BEGIN_EXT = ((int)100164),
                NURBS_BEGIN_DATA_EXT = ((int)100170),
                NURBS_NORMAL_DATA = ((int)100172),
                NURBS_BEGIN = ((int)100164),
                NURBS_END_EXT = ((int)100169),
                NURBS_VERTEX_DATA_EXT = ((int)100171),
                NURBS_COLOR_DATA = ((int)100173),
                NURBS_TEXTURE_COORD_DATA_EXT = ((int)100174),
                NURBS_NORMAL_EXT = ((int)100166),
                ERROR = ((int)100103),
                NURBS_TEXTURE_COORD_EXT = ((int)100168),
                NURBS_VERTEX = ((int)100165),
                NURBS_BEGIN_DATA = ((int)100170),
                NURBS_COLOR_DATA_EXT = ((int)100173),
                NURBS_COLOR = ((int)100167),
                NURBS_NORMAL = ((int)100166),
                NURBS_VERTEX_DATA = ((int)100171),
                NURBS_VERTEX_EXT = ((int)100165),
                NURBS_END_DATA = ((int)100175),
                NURBS_TEXTURE_COORD = ((int)100168),
                NURBS_COLOR_EXT = ((int)100167),
            }
            
            public enum NurbsError
            {
                NURBS_ERROR3 = ((int)100253),
                NURBS_ERROR9 = ((int)100259),
                NURBS_ERROR4 = ((int)100254),
                NURBS_ERROR10 = ((int)100260),
                NURBS_ERROR11 = ((int)100261),
                NURBS_ERROR12 = ((int)100262),
                NURBS_ERROR13 = ((int)100263),
                NURBS_ERROR14 = ((int)100264),
                NURBS_ERROR15 = ((int)100265),
                NURBS_ERROR16 = ((int)100266),
                NURBS_ERROR17 = ((int)100267),
                NURBS_ERROR18 = ((int)100268),
                NURBS_ERROR19 = ((int)100269),
                NURBS_ERROR5 = ((int)100255),
                NURBS_ERROR1 = ((int)100251),
                NURBS_ERROR20 = ((int)100270),
                NURBS_ERROR21 = ((int)100271),
                NURBS_ERROR22 = ((int)100272),
                NURBS_ERROR23 = ((int)100273),
                NURBS_ERROR24 = ((int)100274),
                NURBS_ERROR25 = ((int)100275),
                NURBS_ERROR26 = ((int)100276),
                NURBS_ERROR27 = ((int)100277),
                NURBS_ERROR28 = ((int)100278),
                NURBS_ERROR29 = ((int)100279),
                NURBS_ERROR6 = ((int)100256),
                NURBS_ERROR30 = ((int)100280),
                NURBS_ERROR31 = ((int)100281),
                NURBS_ERROR32 = ((int)100282),
                NURBS_ERROR33 = ((int)100283),
                NURBS_ERROR34 = ((int)100284),
                NURBS_ERROR35 = ((int)100285),
                NURBS_ERROR36 = ((int)100286),
                NURBS_ERROR37 = ((int)100287),
                NURBS_ERROR7 = ((int)100257),
                NURBS_ERROR2 = ((int)100252),
                NURBS_ERROR8 = ((int)100258),
            }
            
            public enum NurbsProperty
            {
                CULLING = ((int)100201),
                U_STEP = ((int)100206),
                SAMPLING_METHOD = ((int)100205),
                SAMPLING_TOLERANCE = ((int)100203),
                NURBS_MODE = ((int)100160),
                DISPLAY_MODE = ((int)100204),
                NURBS_TESSELLATOR_EXT = ((int)100161),
                NURBS_TESSELLATOR = ((int)100161),
                V_STEP = ((int)100207),
                PARAMETRIC_TOLERANCE = ((int)100202),
                NURBS_RENDERER_EXT = ((int)100162),
                AUTO_LOAD_MATRIX = ((int)100200),
                NURBS_MODE_EXT = ((int)100160),
                NURBS_RENDERER = ((int)100162),
            }
            
            public enum NurbsSampling
            {
                OBJECT_PATH_LENGTH_EXT = ((int)100209),
                DOMAIN_DISTANCE = ((int)100217),
                OBJECT_PARAMETRIC_ERROR = ((int)100208),
                OBJECT_PATH_LENGTH = ((int)100209),
                PATH_LENGTH = ((int)100215),
                PARAMETRIC_ERROR = ((int)100216),
                OBJECT_PARAMETRIC_ERROR_EXT = ((int)100208),
            }
            
            public enum NurbsTrim
            {
                MAP1_TRIM_3 = ((int)100211),
                MAP1_TRIM_2 = ((int)100210),
            }
            
            public enum QuadricDrawStyle
            {
                FILL = ((int)100012),
                SILHOUETTE = ((int)100013),
                POINT = ((int)100010),
                LINE = ((int)100011),
            }
            
            public enum QuadricCallback
            {
                ERROR = ((int)NurbsCallback.ERROR),
            }
            
            public enum QuadricNormal
            {
                FLAT = ((int)100001),
                NONE = ((int)100002),
                SMOOTH = ((int)100000),
            }
            
            public enum QuadricOrientation
            {
                INSIDE = ((int)100021),
                OUTSIDE = ((int)100020),
            }
            
            public enum TessCallback
            {
                TESS_EDGE_FLAG_DATA = ((int)100110),
                ERROR = ((int)100103),
                TESS_COMBINE = ((int)100105),
                TESS_BEGIN_DATA = ((int)100106),
                TESS_ERROR_DATA = ((int)100109),
                BEGIN = ((int)100100),
                TESS_ERROR = ((int)100103),
                TESS_EDGE_FLAG = ((int)100104),
                TESS_END = ((int)100102),
                TESS_BEGIN = ((int)100100),
                TESS_VERTEX_DATA = ((int)100107),
                TESS_VERTEX = ((int)100101),
                END = ((int)100102),
                VERTEX = ((int)100101),
                EDGE_FLAG = ((int)100104),
                TESS_END_DATA = ((int)100108),
                TESS_COMBINE_DATA = ((int)100111),
            }
            
            public enum TessContour
            {
                CW = ((int)100120),
                INTERIOR = ((int)100122),
                EXTERIOR = ((int)100123),
                UNKNOWN = ((int)100124),
                CCW = ((int)100121),
            }
            
            public enum TessProperty
            {
                TESS_BOUNDARY_ONLY = ((int)100141),
                TESS_TOLERANCE = ((int)100142),
                TESS_WINDING_RULE = ((int)100140),
            }
            
            public enum TessError
            {
                TESS_MISSING_END_CONTOUR = ((int)100154),
                TESS_COORD_TOO_LARGE = ((int)100155),
                TESS_MISSING_BEGIN_POLYGON = ((int)100151),
                TESS_MISSING_END_POLYGON = ((int)100153),
                TESS_ERROR8 = ((int)100158),
                TESS_ERROR7 = ((int)100157),
                TESS_ERROR6 = ((int)100156),
                TESS_ERROR5 = ((int)100155),
                TESS_ERROR4 = ((int)100154),
                TESS_ERROR3 = ((int)100153),
                TESS_ERROR2 = ((int)100152),
                TESS_ERROR1 = ((int)100151),
                TESS_NEED_COMBINE_CALLBACK = ((int)100156),
                TESS_MISSING_BEGIN_CONTOUR = ((int)100152),
            }
            
            public enum TessWinding
            {
                TESS_WINDING_NONZERO = ((int)100131),
                TESS_WINDING_POSITIVE = ((int)100132),
                TESS_WINDING_ODD = ((int)100130),
                TESS_WINDING_ABS_GEQ_TWO = ((int)100134),
                TESS_WINDING_NEGATIVE = ((int)100133),
            }
            
            public enum All
            {
                INTERIOR = ((int)100122),
                NURBS_ERROR3 = ((int)100253),
                TESS_WINDING_RULE = ((int)100140),
                CCW = ((int)100121),
                FALSE = ((int)0),
                NURBS_BEGIN_DATA = ((int)100170),
                UNKNOWN = ((int)100124),
                NURBS_ERROR6 = ((int)100256),
                NURBS_COLOR_DATA_EXT = ((int)100173),
                NONE = ((int)100002),
                NURBS_MODE = ((int)100160),
                AUTO_LOAD_MATRIX = ((int)100200),
                OBJECT_PATH_LENGTH = ((int)100209),
                FILL = ((int)100012),
                TESS_MISSING_BEGIN_POLYGON = ((int)100151),
                V_STEP = ((int)100207),
                NURBS_ERROR10 = ((int)100260),
                NURBS_ERROR11 = ((int)100261),
                NURBS_ERROR12 = ((int)100262),
                NURBS_ERROR13 = ((int)100263),
                NURBS_ERROR14 = ((int)100264),
                NURBS_ERROR15 = ((int)100265),
                NURBS_ERROR16 = ((int)100266),
                NURBS_ERROR17 = ((int)100267),
                NURBS_ERROR18 = ((int)100268),
                NURBS_ERROR19 = ((int)100269),
                OBJECT_PARAMETRIC_ERROR_EXT = ((int)100208),
                NURBS_END_EXT = ((int)100169),
                NURBS_NORMAL_EXT = ((int)100166),
                MAP1_TRIM_3 = ((int)100211),
                NURBS_RENDERER = ((int)100162),
                TESS_BOUNDARY_ONLY = ((int)100141),
                TESS_COORD_TOO_LARGE = ((int)100155),
                NURBS_TEXTURE_COORD_DATA = ((int)100174),
                NURBS_NORMAL = ((int)100166),
                PATH_LENGTH = ((int)100215),
                TESS_ERROR = ((int)100103),
                NURBS_ERROR2 = ((int)100252),
                NURBS_TEXTURE_COORD = ((int)100168),
                TESS_ERROR8 = ((int)100158),
                NURBS_TEXTURE_COORD_DATA_EXT = ((int)100174),
                TESS_ERROR6 = ((int)100156),
                TESS_ERROR5 = ((int)100155),
                TESS_ERROR4 = ((int)100154),
                TESS_ERROR3 = ((int)100153),
                TESS_BEGIN = ((int)100100),
                TESS_ERROR1 = ((int)100151),
                SMOOTH = ((int)100000),
                TESS_MISSING_END_POLYGON = ((int)100153),
                NURBS_ERROR9 = ((int)100259),
                NURBS_COLOR_DATA = ((int)100173),
                BEGIN = ((int)100100),
                OUTSIDE = ((int)100020),
                PARAMETRIC_TOLERANCE = ((int)100202),
                OUT_OF_MEMORY = ((int)100902),
                TESS_WINDING_NEGATIVE = ((int)100133),
                TESS_END = ((int)100102),
                NURBS_ERROR30 = ((int)100280),
                NURBS_ERROR31 = ((int)100281),
                NURBS_ERROR32 = ((int)100282),
                NURBS_ERROR33 = ((int)100283),
                NURBS_ERROR34 = ((int)100284),
                NURBS_ERROR35 = ((int)100285),
                NURBS_ERROR36 = ((int)100286),
                NURBS_ERROR37 = ((int)100287),
                INSIDE = ((int)100021),
                TESS_TOLERANCE = ((int)100142),
                NURBS_ERROR27 = ((int)100277),
                NURBS_END_DATA_EXT = ((int)100175),
                SAMPLING_TOLERANCE = ((int)100203),
                MITCHELL_NETRAVALI_SGI = ((int)100301),
                NURBS_TESSELLATOR_EXT = ((int)100161),
                ERROR = ((int)100103),
                OUTLINE_POLYGON = ((int)100240),
                POINT = ((int)100010),
                TESS_COMBINE_DATA = ((int)100111),
                NURBS_END = ((int)100169),
                NURBS_ERROR5 = ((int)100255),
                TESS_VERTEX = ((int)100101),
                TESS_EDGE_FLAG = ((int)100104),
                NURBS_NORMAL_DATA = ((int)100172),
                INVALID_VALUE = ((int)100901),
                VERSION = ((int)100800),
                MAP1_TRIM_2 = ((int)100210),
                NURBS_ERROR8 = ((int)100258),
                NURBS_VERTEX_DATA = ((int)100171),
                TESS_WINDING_ABS_GEQ_TWO = ((int)100134),
                LINE = ((int)100011),
                TESS_BEGIN_DATA = ((int)100106),
                SAMPLING_METHOD = ((int)100205),
                END = ((int)100102),
                CW = ((int)100120),
                DISPLAY_MODE = ((int)100204),
                EDGE_FLAG = ((int)100104),
                TESS_MISSING_BEGIN_CONTOUR = ((int)100152),
                NURBS_COLOR = ((int)100167),
                NURBS_TEXTURE_COORD_EXT = ((int)100168),
                NURBS_ERROR20 = ((int)100270),
                NURBS_ERROR21 = ((int)100271),
                NURBS_ERROR22 = ((int)100272),
                NURBS_ERROR23 = ((int)100273),
                NURBS_ERROR24 = ((int)100274),
                NURBS_ERROR25 = ((int)100275),
                NURBS_ERROR26 = ((int)100276),
                INVALID_OPERATION = ((int)100904),
                NURBS_ERROR28 = ((int)100278),
                NURBS_ERROR29 = ((int)100279),
                NURBS_TESSELLATOR = ((int)100161),
                OBJECT_PARAMETRIC_ERROR = ((int)100208),
                NURBS_BEGIN_DATA_EXT = ((int)100170),
                TESS_WINDING_NONZERO = ((int)100131),
                OUTLINE_PATCH = ((int)100241),
                VERSION_1_1 = ((int)1),
                VERSION_1_2 = ((int)1),
                VERSION_1_3 = ((int)1),
                LAGRANGIAN_SGI = ((int)100300),
                NURBS_ERROR1 = ((int)100251),
                NURBS_VERTEX = ((int)100165),
                SILHOUETTE = ((int)100013),
                DOMAIN_DISTANCE = ((int)100217),
                VERTEX = ((int)100101),
                NURBS_ERROR4 = ((int)100254),
                TESS_NEED_COMBINE_CALLBACK = ((int)100156),
                NURBS_COLOR_EXT = ((int)100167),
                NURBS_NORMAL_DATA_EXT = ((int)100172),
                CULLING = ((int)100201),
                NURBS_ERROR7 = ((int)100257),
                NURBS_VERTEX_EXT = ((int)100165),
                TESS_EDGE_FLAG_DATA = ((int)100110),
                NURBS_BEGIN_EXT = ((int)100164),
                OBJECT_PATH_LENGTH_EXT = ((int)100209),
                NURBS_MODE_EXT = ((int)100160),
                TESS_MISSING_END_CONTOUR = ((int)100154),
                NURBS_VERTEX_DATA_EXT = ((int)100171),
                NURBS_BEGIN = ((int)100164),
                FLAT = ((int)100001),
                NURBS_END_DATA = ((int)100175),
                TESS_END_DATA = ((int)100108),
                TESS_WINDING_POSITIVE = ((int)100132),
                PARAMETRIC_ERROR = ((int)100216),
                NURBS_RENDERER_EXT = ((int)100162),
                NURBS_ERROR = ((int)100103),
                TRUE = ((int)1),
                EXTENSIONS = ((int)100801),
                TESS_COMBINE = ((int)100105),
                TESS_ERROR_DATA = ((int)100109),
                INVALID_ENUM = ((int)100900),
                U_STEP = ((int)100206),
                TESS_VERTEX_DATA = ((int)100107),
                TESS_ERROR7 = ((int)100157),
                EXTERIOR = ((int)100123),
                TESS_ERROR2 = ((int)100152),
                TESS_WINDING_ODD = ((int)100130),
            }
            
        }
    }
}
