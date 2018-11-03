namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Lists all defined types for paper size, with <see cref="Letter"/>, <see cref="Legal"/>, <see cref="A3"/> and
    /// <see cref="A4"/> being the most typical. All types not included in this enum are reserved.<para/>
    /// Note that the paper size types cannot be combined with one another.
    /// </summary>
    public enum PrinterPaperSize : short
    {
        /// <summary>
        /// US Letter 8 1/2 x 11 in
        /// </summary>
        Letter = 1,

        /// <summary>
        /// US Letter Small 8 1/2 x 11 in
        /// </summary>
        LetterSmall = 2,

        /// <summary>
        /// US Tabloid 11 x 17 in
        /// </summary>
        Tabloid = 3,

        /// <summary>
        /// US Ledger 17 x 11 in
        /// </summary>
        Ledger = 4,

        /// <summary>
        /// US Legal 8 1/2 x 14 in
        /// </summary>
        Legal = 5,

        /// <summary>
        /// US Statement 5 1/2 x 8 1/2 in
        /// </summary>
        Statement = 6,

        /// <summary>
        /// US Executive 7 1/4 x 10 1/2 in
        /// </summary>
        Executive = 7,

        /// <summary>
        /// A3 297 x 420 mm
        /// </summary>
        A3 = 8,

        /// <summary>
        /// A4 210 x 297 mm
        /// </summary>
        A4 = 9,

        /// <summary>
        /// A4 Small 210 x 297 mm
        /// </summary>
        A4Small = 10,

        /// <summary>
        /// A5 148 x 210 mm
        /// </summary>
        A5 = 11,

        /// <summary>
        /// B4 (JIS) 257 x 364 mm
        /// </summary>
        B4 = 12,

        /// <summary>
        /// B5 (JIS) 182 x 257 mm
        /// </summary>
        B5 = 13,

        /// <summary>
        /// Folio 8 1/2 x 13 in
        /// </summary>
        Folio = 14,

        /// <summary>
        /// Quarto 215 x 275 mm
        /// </summary>
        Quarto = 15,

        /// <summary>
        /// 10 x 14 in
        /// </summary>
        TenByFourteenInches = 16,

        /// <summary>
        /// 11 x 17 in
        /// </summary>
        ElevenBySeventeenInches = 17,

        /// <summary>
        /// US Note 8 1/2 x 11 in
        /// </summary>
        Note = 18,

        /// <summary>
        /// US Envelope #9 3 7/8 x 8 7/8
        /// </summary>
        Envelope9 = 19,

        /// <summary>
        /// US Envelope #10 4 1/8 x 9 1/2
        /// </summary>
        Envelope10 = 20,

        /// <summary>
        /// US Envelope #11 4 1/2 x 10 3/8
        /// </summary>
        Envelope11 = 21,

        /// <summary>
        /// US Envelope #12 4 3/4 x 11 in
        /// </summary>
        Envelope12 = 22,

        /// <summary>
        /// US Envelope #14 5 x 11 1/2
        /// </summary>
        Envelope14 = 23,

        /// <summary>
        /// C size sheet
        /// </summary>
        CSheet = 24,

        /// <summary>
        /// D size sheet
        /// </summary>
        DSheet = 25,

        /// <summary>
        /// E size sheet
        /// </summary>
        ESheet = 26,

        /// <summary>
        /// Envelope DL 110 x 220mm
        /// </summary>
        EnvelopeDL = 27,

        /// <summary>
        /// Envelope C5 162 x 229 mm
        /// </summary>
        EnvelopeC5 = 28,

        /// <summary>
        /// Envelope C3 324 x 458 mm
        /// </summary>
        EnvelopeC3 = 29,

        /// <summary>
        /// Envelope C4 229 x 324 mm
        /// </summary>
        EnvelopeC4 = 30,

        /// <summary>
        /// Envelope C6 114 x 162 mm
        /// </summary>
        EnvelopeC6 = 31,

        /// <summary>
        /// Envelope C65 114 x 229 mm
        /// </summary>
        EnvelopeC65 = 32,

        /// <summary>
        /// Envelope B4 250 x 353 mm
        /// </summary>
        EnvelopeB4 = 33,

        /// <summary>
        /// Envelope B5 176 x 250 mm
        /// </summary>
        EnvelopeB5 = 34,

        /// <summary>
        /// Envelope B6 176 x 125 mm
        /// </summary>
        EnvelopeB6 = 35,

        /// <summary>
        /// Envelope 110 x 230 mm
        /// </summary>
        EnvelopeItaly = 36,

        /// <summary>
        /// US Envelope Monarch 3.875 x 7.5 in
        /// </summary>
        EnvelopeMonarch = 37,

        /// <summary>
        /// 6 3/4 US Envelope 3 5/8 x 6 1/2 in
        /// </summary>
        EnvelopePersonal = 38,

        /// <summary>
        /// US Std Fanfold 14 7/8 x 11 in
        /// </summary>
        FanfoldUS = 39,

        /// <summary>
        /// German Std Fanfold 8 1/2 x 12 in
        /// </summary>
        FanfoldStandardGerman = 40,

        /// <summary>
        /// German Legal Fanfold 8 1/2 x 13 in
        /// </summary>
        FanfoldLegalGerman = 41,

        /// <summary>
        /// B4 (ISO) 250 x 353 mm
        /// </summary>
        IsoB4 = 42,

        /// <summary>
        /// Japanese Postcard 100 x 148 mm
        /// </summary>
        JapanesePostcard = 43,

        /// <summary>
        /// 9 x 11 in
        /// </summary>
        NineByElevenInches = 44,

        /// <summary>
        /// 10 x 11 in
        /// </summary>
        TenByElevenInches = 45,

        /// <summary>
        /// 15 x 11 in
        /// </summary>
        FifteenByElevenInches = 46,

        /// <summary>
        /// Envelope Invite 220 x 220 mm
        /// </summary>
        EnvelopeInvite = 47,

        /// <summary>
        /// RESERVED--DO NOT USE
        /// </summary>
        Reserved48 = 48,

        /// <summary>
        /// RESERVED--DO NOT USE
        /// </summary>
        Reserved49 = 49,

        /// <summary>
        /// US Letter Extra 9 1/2 x 12 in
        /// </summary>
        LetterExtra = 50,

        /// <summary>
        /// US Legal Extra 9 1/2 x 15 in
        /// </summary>
        LegalExtra = 51,

        /// <summary>
        /// US Tabloid Extra 11.69 x 18 in
        /// </summary>
        TabloidExtra = 52,

        /// <summary>
        /// A4 Extra 9.27 x 12.69 in
        /// </summary>
        A4Extra = 53,

        /// <summary>
        /// Letter Transverse 8 1/2 x 11 in
        /// </summary>
        LetterTransverse = 54,

        /// <summary>
        /// A4 Transverse 210 x 297 mm
        /// </summary>
        A4Transverse = 55,

        /// <summary>
        /// Letter Extra Transverse 9 1/2 x 12 in
        /// </summary>
        LetterExtraTransverse = 56,

        /// <summary>
        /// SuperA/SuperA/A4 227 x 356 mm
        /// </summary>
        APlus = 57,

        /// <summary>
        /// SuperB/SuperB/A3 305 x 487 mm
        /// </summary>
        BPlus = 58,

        /// <summary>
        /// US Letter Plus 8.5 x 12.69 in
        /// </summary>
        LetterPlus = 59,

        /// <summary>
        /// A4 Plus 210 x 330 mm
        /// </summary>
        A4Plus = 60,

        /// <summary>
        /// A5 Transverse 148 x 210 mm
        /// </summary>
        A5Transverse = 61,

        /// <summary>
        /// B5 (JIS) Transverse 182 x 257 mm
        /// </summary>
        B5Transverse = 62,

        /// <summary>
        /// A3 Extra 322 x 445 mm
        /// </summary>
        A3Extra = 63,

        /// <summary>
        /// A5 Extra 174 x 235 mm
        /// </summary>
        A5Extra = 64,

        /// <summary>
        /// B5 (ISO) Extra 201 x 276 mm
        /// </summary>
        B5Extra = 65,

        /// <summary>
        /// A2 420 x 594 mm
        /// </summary>
        A2 = 66,

        /// <summary>
        /// A3 Transverse 297 x 420 mm
        /// </summary>
        A3Transverse = 67,

        /// <summary>
        /// A3 Extra Transverse 322 x 445 mm
        /// </summary>
        A3ExtraTransverse = 68,

        /// <summary>
        /// Japanese Double Postcard 200 x 148 mm
        /// </summary>
        DoubleJapanesePostcard = 69,

        /// <summary>
        /// A6 105 x 148 mm
        /// </summary>
        A6 = 70,

        /// <summary>
        /// Japanese Envelope Kaku #2
        /// </summary>
        JapaneseEnvelopeKaku2 = 71,

        /// <summary>
        /// Japanese Envelope Kaku #3
        /// </summary>
        JapaneseEnvelopeKaku3 = 72,

        /// <summary>
        /// Japanese Envelope Chou #3
        /// </summary>
        JapaneseEnvelopeChou3 = 73,

        /// <summary>
        /// Japanese Envelope Chou #4
        /// </summary>
        JapaneseEnvelopeChou4 = 74,

        /// <summary>
        /// Letter Rotated 11 x 8 1/2 11 in
        /// </summary>
        LetterRotated = 75,

        /// <summary>
        /// A3 Rotated 420 x 297 mm
        /// </summary>
        A3Rotated = 76,

        /// <summary>
        /// A4 Rotated 297 x 210 mm
        /// </summary>
        A4Rotated = 77,

        /// <summary>
        /// A5 Rotated 210 x 148 mm
        /// </summary>
        A5Rotated = 78,

        /// <summary>
        /// B4 (JIS) Rotated 364 x 257 mm
        /// </summary>
        B4JisRotated = 79,

        /// <summary>
        /// B5 (JIS) Rotated 257 x 182 mm
        /// </summary>
        B5JisRotated = 80,

        /// <summary>
        /// Japanese Postcard Rotated 148 x 100 mm
        /// </summary>
        JapanesePostcardRotated = 81,

        /// <summary>
        /// Double Japanese Postcard Rotated 148 x 200 mm
        /// </summary>
        DoubleJapanesePostcardRotated = 82,

        /// <summary>
        /// A6 Rotated 148 x 105 mm
        /// </summary>
        A6Rotated = 83,

        /// <summary>
        /// Japanese Envelope Kaku #2 Rotated
        /// </summary>
        JapaneseEnvelopeKaku2Rotated = 84,

        /// <summary>
        /// Japanese Envelope Kaku #3 Rotated
        /// </summary>
        JapaneseEnvelopeKaku3Rotated = 85,

        /// <summary>
        /// Japanese Envelope Chou #3 Rotated
        /// </summary>
        JapaneseEnvelopeChou3Rotated = 86,

        /// <summary>
        /// Japanese Envelope Chou #4 Rotated
        /// </summary>
        JapaneseEnvelopeChou4Rotated = 87,

        /// <summary>
        /// B6 (JIS) 128 x 182 mm
        /// </summary>
        B6Jis = 88,

        /// <summary>
        /// B6 (JIS) Rotated 182 x 128 mm
        /// </summary>
        B6JisRotated = 89,

        /// <summary>
        /// 12 x 11 in
        /// </summary>
        TwelveByElevenInches = 90,

        /// <summary>
        /// Japanese Envelope You #4
        /// </summary>
        JapaneseEnvelopeYou4 = 91,

        /// <summary>
        /// Japanese Envelope You #4 Rotated
        /// </summary>
        JapaneseEnvelopeYou4Rotated = 92,

        /// <summary>
        /// PRC 16K 146 x 215 mm
        /// </summary>
        Prc16K = 93,

        /// <summary>
        /// PRC 32K 97 x 151 mm
        /// </summary>
        Prc32K = 94,

        /// <summary>
        /// PRC 32K(Big) 97 x 151 mm
        /// </summary>
        Prc32KBig = 95,

        /// <summary>
        /// PRC Envelope #1 102 x 165 mm
        /// </summary>
        PrcEnvelope1 = 96,

        /// <summary>
        /// PRC Envelope #2 102 x 176 mm
        /// </summary>
        PrcEnvelope2 = 97,

        /// <summary>
        /// PRC Envelope #3 125 x 176 mm
        /// </summary>
        PrcEnvelope3 = 98,

        /// <summary>
        /// PRC Envelope #4 110 x 208 mm
        /// </summary>
        PrcEnvelope4 = 99,

        /// <summary>
        /// PRC Envelope #5 110 x 220 mm
        /// </summary>
        PrcEnvelope5 = 100,

        /// <summary>
        /// PRC Envelope #6 120 x 230 mm
        /// </summary>
        PrcEnvelope6 = 101,

        /// <summary>
        /// PRC Envelope #7 160 x 230 mm
        /// </summary>
        PrcEnvelope7 = 102,

        /// <summary>
        /// PRC Envelope #8 120 x 309 mm
        /// </summary>
        PrcEnvelope8 = 103,

        /// <summary>
        /// PRC Envelope #9 229 x 324 mm
        /// </summary>
        PrcEnvelope9 = 104,

        /// <summary>
        /// PRC Envelope #10 324 x 458 mm
        /// </summary>
        PrcEnvelope10 = 105,

        /// <summary>
        /// PRC 16K Rotated
        /// </summary>
        P16KRotated = 106,

        /// <summary>
        /// PRC 32K Rotated
        /// </summary>
        P32KRotated = 107,

        /// <summary>
        /// PRC 32K(Big) Rotated
        /// </summary>
        P32KBigRotated = 108,

        /// <summary>
        /// PRC Envelope #1 Rotated 165 x 102 mm
        /// </summary>
        PrcEnvelope1Rotated = 109,

        /// <summary>
        /// PRC Envelope #2 Rotated 176 x 102 mm
        /// </summary>
        PrcEnvelope2Rotated = 110,

        /// <summary>
        /// PRC Envelope #3 Rotated 176 x 125 mm
        /// </summary>
        PrcEnvelope3Rotated = 111,

        /// <summary>
        /// PRC Envelope #4 Rotated 208 x 110 mm
        /// </summary>
        PrcEnvelope4Rotated = 112,

        /// <summary>
        /// PRC Envelope #5 Rotated 220 x 110 mm
        /// </summary>
        PrcEnvelope5Rotated = 113,

        /// <summary>
        /// PRC Envelope #6 Rotated 230 x 120 mm
        /// </summary>
        PrcEnvelope6Rotated = 114,

        /// <summary>
        /// PRC Envelope #7 Rotated 230 x 160 mm
        /// </summary>
        PrcEnvelope7Rotated = 115,

        /// <summary>
        /// PRC Envelope #8 Rotated 309 x 120 mm
        /// </summary>
        PrcEnvelope8Rotated = 116,

        /// <summary>
        /// PRC Envelope #9 Rotated 324 x 229 mm
        /// </summary>
        PrcEnvelope9Rotated = 117,

        /// <summary>
        /// PRC Envelope #10 Rotated 458 x 324 mm
        /// </summary>
        PrcEnvelope10Rotated = 118,
    }
}
