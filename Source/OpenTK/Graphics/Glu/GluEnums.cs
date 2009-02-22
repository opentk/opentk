namespace OpenTK.Graphics
{
    #pragma warning disable 1591

    public enum GluVersion
    {
        Version11 = ((int)1),
        Version13 = ((int)1),
        Version12 = ((int)1),
    }

    public enum GluStringName
    {
        Version = ((int)100800),
        Extensions = ((int)100801),
    }

    public enum GluErrorCode
    {
        OutOfMemory = ((int)100902),
        InvalidEnum = ((int)100900),
        InvalidValue = ((int)100901),
        InvalidOperation = ((int)100904),
    }

    public enum Filter4TypeSGIS
    {
        MitchellNetravaliSgi = ((int)100301),
        LagrangianSgi = ((int)100300),
    }

    public enum NurbsDisplay
    {
        OutlinePolygon = ((int)100240),
        OutlinePatch = ((int)100241),
        Fill = ((int)QuadricDrawStyle.Fill),
    }

    public enum NurbsCallback
    {
        NurbsColorData = ((int)100173),
        NurbsVertexData = ((int)100171),
        NurbsNormal = ((int)100166),
        NurbsError = ((int)100103),
        NurbsTextureCoordExt = ((int)100168),
        Error = ((int)100103),
        NurbsEndDataExt = ((int)100175),
        NurbsEnd = ((int)100169),
        NurbsTextureCoord = ((int)100168),
        NurbsEndExt = ((int)100169),
        NurbsNormalDataExt = ((int)100172),
        NurbsColor = ((int)100167),
        NurbsColorExt = ((int)100167),
        NurbsVertexExt = ((int)100165),
        NurbsBeginExt = ((int)100164),
        NurbsTextureCoordData = ((int)100174),
        NurbsBeginData = ((int)100170),
        NurbsColorDataExt = ((int)100173),
        NurbsBeginDataExt = ((int)100170),
        NurbsVertex = ((int)100165),
        NurbsTextureCoordDataExt = ((int)100174),
        NurbsNormalExt = ((int)100166),
        NurbsVertexDataExt = ((int)100171),
        NurbsBegin = ((int)100164),
        NurbsEndData = ((int)100175),
        NurbsNormalData = ((int)100172),
    }

    public enum NurbsError
    {
        NurbsError37 = ((int)100287),
        NurbsError16 = ((int)100266),
        NurbsError26 = ((int)100276),
        NurbsError36 = ((int)100286),
        NurbsError19 = ((int)100269),
        NurbsError29 = ((int)100279),
        NurbsError8 = ((int)100258),
        NurbsError12 = ((int)100262),
        NurbsError9 = ((int)100259),
        NurbsError1 = ((int)100251),
        NurbsError18 = ((int)100268),
        NurbsError28 = ((int)100278),
        NurbsError4 = ((int)100254),
        NurbsError5 = ((int)100255),
        NurbsError6 = ((int)100256),
        NurbsError7 = ((int)100257),
        NurbsError3 = ((int)100253),
        NurbsError22 = ((int)100272),
        NurbsError32 = ((int)100282),
        NurbsError2 = ((int)100252),
        NurbsError11 = ((int)100261),
        NurbsError21 = ((int)100271),
        NurbsError31 = ((int)100281),
        NurbsError10 = ((int)100260),
        NurbsError20 = ((int)100270),
        NurbsError30 = ((int)100280),
        NurbsError15 = ((int)100265),
        NurbsError25 = ((int)100275),
        NurbsError35 = ((int)100285),
        NurbsError14 = ((int)100264),
        NurbsError24 = ((int)100274),
        NurbsError34 = ((int)100284),
        NurbsError13 = ((int)100263),
        NurbsError23 = ((int)100273),
        NurbsError33 = ((int)100283),
        NurbsError17 = ((int)100267),
        NurbsError27 = ((int)100277),
    }

    public enum NurbsProperty
    {
        DisplayMode = ((int)100204),
        ParametricTolerance = ((int)100202),
        NurbsRenderer = ((int)100162),
        NurbsTessellator = ((int)100161),
        NurbsTessellatorExt = ((int)100161),
        NurbsModeExt = ((int)100160),
        UStep = ((int)100206),
        SamplingMethod = ((int)100205),
        AutoLoadMatrix = ((int)100200),
        VStep = ((int)100207),
        Culling = ((int)100201),
        NurbsRendererExt = ((int)100162),
        NurbsMode = ((int)100160),
        SamplingTolerance = ((int)100203),
    }

    public enum NurbsSampling
    {
        ObjectParametricError = ((int)100208),
        ObjectPathLength = ((int)100209),
        PathLength = ((int)100215),
        DomainDistance = ((int)100217),
        ObjectPathLengthExt = ((int)100209),
        ObjectParametricErrorExt = ((int)100208),
        ParametricError = ((int)100216),
    }

    public enum NurbsTrim
    {
        Map1Trim3 = ((int)100211),
        Map1Trim2 = ((int)100210),
    }

    public enum QuadricDrawStyle
    {
        Line = ((int)100011),
        Silhouette = ((int)100013),
        Point = ((int)100010),
        Fill = ((int)100012),
    }

    public enum QuadricCallback
    {
        Error = ((int)NurbsCallback.Error),
    }

    public enum QuadricNormal
    {
        None = ((int)100002),
        Flat = ((int)100001),
        Smooth = ((int)100000),
    }

    public enum QuadricOrientation
    {
        Outside = ((int)100020),
        Inside = ((int)100021),
    }

    public enum TessCallback
    {
        TessEdgeFlagData = ((int)100110),
        Begin = ((int)100100),
        TessError = ((int)100103),
        EdgeFlag = ((int)100104),
        End = ((int)100102),
        TessCombine = ((int)100105),
        Error = ((int)100103),
        TessEndData = ((int)100108),
        TessBeginData = ((int)100106),
        TessErrorData = ((int)100109),
        Vertex = ((int)100101),
        TessVertexData = ((int)100107),
        TessVertex = ((int)100101),
        TessEdgeFlag = ((int)100104),
        TessEnd = ((int)100102),
        TessBegin = ((int)100100),
        TessCombineData = ((int)100111),
    }

    public enum TessContour
    {
        Exterior = ((int)100123),
        Ccw = ((int)100121),
        Interior = ((int)100122),
        Unknown = ((int)100124),
        Cw = ((int)100120),
    }

    public enum TessParameter
    {
        TessWindingRule = ((int)100140),
        TessBoundaryOnly = ((int)100141),
        TessTolerance = ((int)100142),
    }

    public enum TessError
    {
        TessMissingBeginPolygon = ((int)100151),
        TessMissingEndPolygon = ((int)100153),
        TessError1 = ((int)100151),
        TessMissingBeginContour = ((int)100152),
        TessCoordTooLarge = ((int)100155),
        TessError7 = ((int)100157),
        TessError2 = ((int)100152),
        TessError4 = ((int)100154),
        TessNeedCombineCallback = ((int)100156),
        TessError3 = ((int)100153),
        TessError6 = ((int)100156),
        TessError5 = ((int)100155),
        TessError8 = ((int)100158),
        TessMissingEndContour = ((int)100154),
    }

    public enum TessWinding
    {
        TessWindingNonzero = ((int)100131),
        TessWindingOdd = ((int)100130),
        TessWindingPositive = ((int)100132),
        TessWindingAbsGeqTwo = ((int)100134),
        TessWindingNegative = ((int)100133),
    }

    public enum AllGlu
    {
        None = ((int)100002),
        TessWindingRule = ((int)100140),
        TessWindingPositive = ((int)100132),
        ObjectPathLength = ((int)100209),
        NurbsTextureCoordExt = ((int)100168),
        Vertex = ((int)100101),
        TessCombine = ((int)100105),
        AutoLoadMatrix = ((int)100200),
        TessBoundaryOnly = ((int)100141),
        NurbsEndExt = ((int)100169),
        NurbsError17 = ((int)100267),
        NurbsError27 = ((int)100277),
        NurbsError37 = ((int)100287),
        Interior = ((int)100122),
        TessWindingOdd = ((int)100130),
        InvalidValue = ((int)100901),
        ParametricError = ((int)100216),
        TessError8 = ((int)100158),
        NurbsError14 = ((int)100264),
        NurbsError24 = ((int)100274),
        NurbsError34 = ((int)100284),
        NurbsTextureCoordDataExt = ((int)100174),
        TessMissingBeginContour = ((int)100152),
        Silhouette = ((int)100013),
        TessError7 = ((int)100157),
        NurbsNormalDataExt = ((int)100172),
        NurbsError21 = ((int)100271),
        NurbsError31 = ((int)100281),
        PathLength = ((int)100215),
        OutlinePolygon = ((int)100240),
        TessVertex = ((int)100101),
        TessWindingAbsGeqTwo = ((int)100134),
        Extensions = ((int)100801),
        TessEdgeFlagData = ((int)100110),
        EdgeFlag = ((int)100104),
        TessError1 = ((int)100151),
        Line = ((int)100011),
        NurbsBeginExt = ((int)100164),
        Point = ((int)100010),
        Begin = ((int)100100),
        Inside = ((int)100021),
        Flat = ((int)100001),
        TessBegin = ((int)100100),
        NurbsNormal = ((int)100166),
        NurbsColorData = ((int)100173),
        NurbsBeginDataExt = ((int)100170),
        NurbsRenderer = ((int)100162),
        NurbsBeginData = ((int)100170),
        Outside = ((int)100020),
        DisplayMode = ((int)100204),
        NurbsError15 = ((int)100265),
        NurbsError25 = ((int)100275),
        NurbsError35 = ((int)100285),
        NurbsVertexExt = ((int)100165),
        TessError5 = ((int)100155),
        Unknown = ((int)100124),
        NurbsEndDataExt = ((int)100175),
        NurbsError12 = ((int)100262),
        NurbsError22 = ((int)100272),
        NurbsError32 = ((int)100282),
        ObjectParametricErrorExt = ((int)100208),
        NurbsRendererExt = ((int)100162),
        TessError3 = ((int)100153),
        Fill = ((int)100012),
        TessError = ((int)100103),
        ObjectPathLengthExt = ((int)100209),
        TessWindingNegative = ((int)100133),
        NurbsTessellator = ((int)100161),
        NurbsColor = ((int)100167),
        NurbsModeExt = ((int)100160),
        SamplingTolerance = ((int)100203),
        NurbsColorDataExt = ((int)100173),
        Exterior = ((int)100123),
        Ccw = ((int)100121),
        Cw = ((int)100120),
        NurbsNormalExt = ((int)100166),
        NurbsError18 = ((int)100268),
        NurbsError28 = ((int)100278),
        LagrangianSgi = ((int)100300),
        TessEnd = ((int)100102),
        NurbsTessellatorExt = ((int)100161),
        NurbsEnd = ((int)100169),
        TessWindingNonzero = ((int)100131),
        OutOfMemory = ((int)100902),
        TessBeginData = ((int)100106),
        Error = ((int)100103),
        ObjectParametricError = ((int)100208),
        NurbsBegin = ((int)100164),
        TessCombineData = ((int)100111),
        TessMissingEndPolygon = ((int)100153),
        NurbsTextureCoord = ((int)100168),
        Smooth = ((int)100000),
        TessMissingBeginPolygon = ((int)100151),
        NurbsEndData = ((int)100175),
        NurbsVertexData = ((int)100171),
        TessEndData = ((int)100108),
        NurbsError11 = ((int)100261),
        NurbsVertex = ((int)100165),
        NurbsError30 = ((int)100280),
        Version11 = ((int)1),
        TessError6 = ((int)100156),
        Version13 = ((int)1),
        Version12 = ((int)1),
        TessErrorData = ((int)100109),
        NurbsError36 = ((int)100286),
        End = ((int)100102),
        SamplingMethod = ((int)100205),
        TessNeedCombineCallback = ((int)100156),
        UStep = ((int)100206),
        DomainDistance = ((int)100217),
        TessEdgeFlag = ((int)100104),
        NurbsColorExt = ((int)100167),
        NurbsError19 = ((int)100269),
        NurbsError29 = ((int)100279),
        InvalidOperation = ((int)100904),
        TessCoordTooLarge = ((int)100155),
        TessVertexData = ((int)100107),
        NurbsMode = ((int)100160),
        ParametricTolerance = ((int)100202),
        NurbsError2 = ((int)100252),
        VStep = ((int)100207),
        TessMissingEndContour = ((int)100154),
        Map1Trim2 = ((int)100210),
        Map1Trim3 = ((int)100211),
        Culling = ((int)100201),
        NurbsError16 = ((int)100266),
        NurbsError26 = ((int)100276),
        NurbsVertexDataExt = ((int)100171),
        NurbsNormalData = ((int)100172),
        TessError2 = ((int)100152),
        NurbsError13 = ((int)100263),
        NurbsError23 = ((int)100273),
        NurbsError33 = ((int)100283),
        NurbsError8 = ((int)100258),
        NurbsError9 = ((int)100259),
        TessError4 = ((int)100154),
        NurbsError10 = ((int)100260),
        NurbsError20 = ((int)100270),
        OutlinePatch = ((int)100241),
        NurbsError = ((int)100103),
        NurbsTextureCoordData = ((int)100174),
        NurbsError1 = ((int)100251),
        InvalidEnum = ((int)100900),
        NurbsError3 = ((int)100253),
        NurbsError4 = ((int)100254),
        NurbsError5 = ((int)100255),
        NurbsError6 = ((int)100256),
        NurbsError7 = ((int)100257),
        MitchellNetravaliSgi = ((int)100301),
        Version = ((int)100800),
        TessTolerance = ((int)100142),
    }

}
