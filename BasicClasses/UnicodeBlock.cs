namespace BasicClasses {
	using System.Collections.Generic;

	public static class UnicodeBlock {
		public const string No_Block = "No_Block";
		public const string BasicLatin = "Basic Latin";
		public const string Latin1Supplement = "Latin-1 Supplement";
		public const string LatinExtendedA = "Latin Extended-A";
		public const string LatinExtendedB = "Latin Extended-B";
		public const string IPAExtensions = "IPA Extensions";
		public const string SpacingModifierLetters = "Spacing Modifier Letters";
		public const string CombiningDiacriticalMarks = "Combining Diacritical Marks";
		public const string GreekandCoptic = "Greek and Coptic";
		public const string Cyrillic = "Cyrillic";
		public const string CyrillicSupplement = "Cyrillic Supplement";
		public const string Armenian = "Armenian";
		public const string Hebrew = "Hebrew";
		public const string Arabic = "Arabic";
		public const string Syriac = "Syriac";
		public const string ArabicSupplement = "Arabic Supplement";
		public const string Thaana = "Thaana";
		public const string NKo = "NKo";
		public const string Samaritan = "Samaritan";
		public const string Mandaic = "Mandaic";
		public const string SyriacSupplement = "Syriac Supplement";
		public const string ArabicExtendedA = "Arabic Extended-A";
		public const string Devanagari = "Devanagari";
		public const string Bengali = "Bengali";
		public const string Gurmukhi = "Gurmukhi";
		public const string Gujarati = "Gujarati";
		public const string Oriya = "Oriya";
		public const string Tamil = "Tamil";
		public const string Telugu = "Telugu";
		public const string Kannada = "Kannada";
		public const string Malayalam = "Malayalam";
		public const string Sinhala = "Sinhala";
		public const string Thai = "Thai";
		public const string Lao = "Lao";
		public const string Tibetan = "Tibetan";
		public const string Myanmar = "Myanmar";
		public const string Georgian = "Georgian";
		public const string HangulJamo = "Hangul Jamo";
		public const string Ethiopic = "Ethiopic";
		public const string EthiopicSupplement = "Ethiopic Supplement";
		public const string Cherokee = "Cherokee";
		public const string UnifiedCanadianAboriginalSyllabics = "Unified Canadian Aboriginal Syllabics";
		public const string Ogham = "Ogham";
		public const string Runic = "Runic";
		public const string Tagalog = "Tagalog";
		public const string Hanunoo = "Hanunoo";
		public const string Buhid = "Buhid";
		public const string Tagbanwa = "Tagbanwa";
		public const string Khmer = "Khmer";
		public const string Mongolian = "Mongolian";
		public const string UnifiedCanadianAboriginalSyllabicsExtended = "Unified Canadian Aboriginal Syllabics Extended";
		public const string Limbu = "Limbu";
		public const string TaiLe = "Tai Le";
		public const string NewTaiLue = "New Tai Lue";
		public const string KhmerSymbols = "Khmer Symbols";
		public const string Buginese = "Buginese";
		public const string TaiTham = "Tai Tham";
		public const string CombiningDiacriticalMarksExtended = "Combining Diacritical Marks Extended";
		public const string Balinese = "Balinese";
		public const string Sundanese = "Sundanese";
		public const string Batak = "Batak";
		public const string Lepcha = "Lepcha";
		public const string OlChiki = "Ol Chiki";
		public const string CyrillicExtendedC = "Cyrillic Extended-C";
		public const string GeorgianExtended = "Georgian Extended";
		public const string SundaneseSupplement = "Sundanese Supplement";
		public const string VedicExtensions = "Vedic Extensions";
		public const string PhoneticExtensions = "Phonetic Extensions";
		public const string PhoneticExtensionsSupplement = "Phonetic Extensions Supplement";
		public const string CombiningDiacriticalMarksSupplement = "Combining Diacritical Marks Supplement";
		public const string LatinExtendedAdditional = "Latin Extended Additional";
		public const string GreekExtended = "Greek Extended";
		public const string GeneralPunctuation = "General Punctuation";
		public const string SuperscriptsandSubscripts = "Superscripts and Subscripts";
		public const string CurrencySymbols = "Currency Symbols";
		public const string CombiningDiacriticalMarksforSymbols = "Combining Diacritical Marks for Symbols";
		public const string LetterlikeSymbols = "Letterlike Symbols";
		public const string NumberForms = "Number Forms";
		public const string Arrows = "Arrows";
		public const string MathematicalOperators = "Mathematical Operators";
		public const string MiscellaneousTechnical = "Miscellaneous Technical";
		public const string ControlPictures = "Control Pictures";
		public const string OpticalCharacterRecognition = "Optical Character Recognition";
		public const string EnclosedAlphanumerics = "Enclosed Alphanumerics";
		public const string BoxDrawing = "Box Drawing";
		public const string BlockElements = "Block Elements";
		public const string GeometricShapes = "Geometric Shapes";
		public const string MiscellaneousSymbols = "Miscellaneous Symbols";
		public const string Dingbats = "Dingbats";
		public const string MiscellaneousMathematicalSymbolsA = "Miscellaneous Mathematical Symbols-A";
		public const string SupplementalArrowsA = "Supplemental Arrows-A";
		public const string BraillePatterns = "Braille Patterns";
		public const string SupplementalArrowsB = "Supplemental Arrows-B";
		public const string MiscellaneousMathematicalSymbolsB = "Miscellaneous Mathematical Symbols-B";
		public const string SupplementalMathematicalOperators = "Supplemental Mathematical Operators";
		public const string MiscellaneousSymbolsandArrows = "Miscellaneous Symbols and Arrows";
		public const string Glagolitic = "Glagolitic";
		public const string LatinExtendedC = "Latin Extended-C";
		public const string Coptic = "Coptic";
		public const string GeorgianSupplement = "Georgian Supplement";
		public const string Tifinagh = "Tifinagh";
		public const string EthiopicExtended = "Ethiopic Extended";
		public const string CyrillicExtendedA = "Cyrillic Extended-A";
		public const string SupplementalPunctuation = "Supplemental Punctuation";
		public const string CJKRadicalsSupplement = "CJK Radicals Supplement";
		public const string KangxiRadicals = "Kangxi Radicals";
		public const string IdeographicDescriptionCharacters = "Ideographic Description Characters";
		public const string CJKSymbolsandPunctuation = "CJK Symbols and Punctuation";
		public const string Hiragana = "Hiragana";
		public const string Katakana = "Katakana";
		public const string Bopomofo = "Bopomofo";
		public const string HangulCompatibilityJamo = "Hangul Compatibility Jamo";
		public const string Kanbun = "Kanbun";
		public const string BopomofoExtended = "Bopomofo Extended";
		public const string CJKStrokes = "CJK Strokes";
		public const string KatakanaPhoneticExtensions = "Katakana Phonetic Extensions";
		public const string EnclosedCJKLettersandMonths = "Enclosed CJK Letters and Months";
		public const string CJKCompatibility = "CJK Compatibility";
		public const string CJKUnifiedIdeographsExtensionA = "CJK Unified Ideographs Extension A";
		public const string YijingHexagramSymbols = "Yijing Hexagram Symbols";
		public const string CJKUnifiedIdeographs = "CJK Unified Ideographs";
		public const string YiSyllables = "Yi Syllables";
		public const string YiRadicals = "Yi Radicals";
		public const string Lisu = "Lisu";
		public const string Vai = "Vai";
		public const string CyrillicExtendedB = "Cyrillic Extended-B";
		public const string Bamum = "Bamum";
		public const string ModifierToneLetters = "Modifier Tone Letters";
		public const string LatinExtendedD = "Latin Extended-D";
		public const string SylotiNagri = "Syloti Nagri";
		public const string CommonIndicNumberForms = "Common Indic Number Forms";
		public const string Phagspa = "Phags-pa";
		public const string Saurashtra = "Saurashtra";
		public const string DevanagariExtended = "Devanagari Extended";
		public const string KayahLi = "Kayah Li";
		public const string Rejang = "Rejang";
		public const string HangulJamoExtendedA = "Hangul Jamo Extended-A";
		public const string Javanese = "Javanese";
		public const string MyanmarExtendedB = "Myanmar Extended-B";
		public const string Cham = "Cham";
		public const string MyanmarExtendedA = "Myanmar Extended-A";
		public const string TaiViet = "Tai Viet";
		public const string MeeteiMayekExtensions = "Meetei Mayek Extensions";
		public const string EthiopicExtendedA = "Ethiopic Extended-A";
		public const string LatinExtendedE = "Latin Extended-E";
		public const string CherokeeSupplement = "Cherokee Supplement";
		public const string MeeteiMayek = "Meetei Mayek";
		public const string HangulSyllables = "Hangul Syllables";
		public const string HangulJamoExtendedB = "Hangul Jamo Extended-B";
		public const string HighSurrogates = "High Surrogates";
		public const string HighPrivateUseSurrogates = "High Private Use Surrogates";
		public const string LowSurrogates = "Low Surrogates";
		public const string PrivateUseArea = "Private Use Area";
		public const string CJKCompatibilityIdeographs = "CJK Compatibility Ideographs";
		public const string AlphabeticPresentationForms = "Alphabetic Presentation Forms";
		public const string ArabicPresentationFormsA = "Arabic Presentation Forms-A";
		public const string VariationSelectors = "Variation Selectors";
		public const string VerticalForms = "Vertical Forms";
		public const string CombiningHalfMarks = "Combining Half Marks";
		public const string CJKCompatibilityForms = "CJK Compatibility Forms";
		public const string SmallFormVariants = "Small Form Variants";
		public const string ArabicPresentationFormsB = "Arabic Presentation Forms-B";
		public const string HalfwidthandFullwidthForms = "Halfwidth and Fullwidth Forms";
		public const string Specials = "Specials";
		public const string LinearBSyllabary = "Linear B Syllabary";
		public const string LinearBIdeograms = "Linear B Ideograms";
		public const string AegeanNumbers = "Aegean Numbers";
		public const string AncientGreekNumbers = "Ancient Greek Numbers";
		public const string AncientSymbols = "Ancient Symbols";
		public const string PhaistosDisc = "Phaistos Disc";
		public const string Lycian = "Lycian";
		public const string Carian = "Carian";
		public const string CopticEpactNumbers = "Coptic Epact Numbers";
		public const string OldItalic = "Old Italic";
		public const string Gothic = "Gothic";
		public const string OldPermic = "Old Permic";
		public const string Ugaritic = "Ugaritic";
		public const string OldPersian = "Old Persian";
		public const string Deseret = "Deseret";
		public const string Shavian = "Shavian";
		public const string Osmanya = "Osmanya";
		public const string Osage = "Osage";
		public const string Elbasan = "Elbasan";
		public const string CaucasianAlbanian = "Caucasian Albanian";
		public const string LinearA = "Linear A";
		public const string CypriotSyllabary = "Cypriot Syllabary";
		public const string ImperialAramaic = "Imperial Aramaic";
		public const string Palmyrene = "Palmyrene";
		public const string Nabataean = "Nabataean";
		public const string Hatran = "Hatran";
		public const string Phoenician = "Phoenician";
		public const string Lydian = "Lydian";
		public const string MeroiticHieroglyphs = "Meroitic Hieroglyphs";
		public const string MeroiticCursive = "Meroitic Cursive";
		public const string Kharoshthi = "Kharoshthi";
		public const string OldSouthArabian = "Old South Arabian";
		public const string OldNorthArabian = "Old North Arabian";
		public const string Manichaean = "Manichaean";
		public const string Avestan = "Avestan";
		public const string InscriptionalParthian = "Inscriptional Parthian";
		public const string InscriptionalPahlavi = "Inscriptional Pahlavi";
		public const string PsalterPahlavi = "Psalter Pahlavi";
		public const string OldTurkic = "Old Turkic";
		public const string OldHungarian = "Old Hungarian";
		public const string HanifiRohingya = "Hanifi Rohingya";
		public const string RumiNumeralSymbols = "Rumi Numeral Symbols";
		public const string Yezidi = "Yezidi";
		public const string OldSogdian = "Old Sogdian";
		public const string Sogdian = "Sogdian";
		public const string Chorasmian = "Chorasmian";
		public const string Elymaic = "Elymaic";
		public const string Brahmi = "Brahmi";
		public const string Kaithi = "Kaithi";
		public const string SoraSompeng = "Sora Sompeng";
		public const string Chakma = "Chakma";
		public const string Mahajani = "Mahajani";
		public const string Sharada = "Sharada";
		public const string SinhalaArchaicNumbers = "Sinhala Archaic Numbers";
		public const string Khojki = "Khojki";
		public const string Multani = "Multani";
		public const string Khudawadi = "Khudawadi";
		public const string Grantha = "Grantha";
		public const string Newa = "Newa";
		public const string Tirhuta = "Tirhuta";
		public const string Siddham = "Siddham";
		public const string Modi = "Modi";
		public const string MongolianSupplement = "Mongolian Supplement";
		public const string Takri = "Takri";
		public const string Ahom = "Ahom";
		public const string Dogra = "Dogra";
		public const string WarangCiti = "Warang Citi";
		public const string DivesAkuru = "Dives Akuru";
		public const string Nandinagari = "Nandinagari";
		public const string ZanabazarSquare = "Zanabazar Square";
		public const string Soyombo = "Soyombo";
		public const string PauCinHau = "Pau Cin Hau";
		public const string Bhaiksuki = "Bhaiksuki";
		public const string Marchen = "Marchen";
		public const string MasaramGondi = "Masaram Gondi";
		public const string GunjalaGondi = "Gunjala Gondi";
		public const string Makasar = "Makasar";
		public const string LisuSupplement = "Lisu Supplement";
		public const string TamilSupplement = "Tamil Supplement";
		public const string Cuneiform = "Cuneiform";
		public const string CuneiformNumbersandPunctuation = "Cuneiform Numbers and Punctuation";
		public const string EarlyDynasticCuneiform = "Early Dynastic Cuneiform";
		public const string EgyptianHieroglyphs = "Egyptian Hieroglyphs";
		public const string EgyptianHieroglyphFormatControls = "Egyptian Hieroglyph Format Controls";
		public const string AnatolianHieroglyphs = "Anatolian Hieroglyphs";
		public const string BamumSupplement = "Bamum Supplement";
		public const string Mro = "Mro";
		public const string BassaVah = "Bassa Vah";
		public const string PahawhHmong = "Pahawh Hmong";
		public const string Medefaidrin = "Medefaidrin";
		public const string Miao = "Miao";
		public const string IdeographicSymbolsandPunctuation = "Ideographic Symbols and Punctuation";
		public const string Tangut = "Tangut";
		public const string TangutComponents = "Tangut Components";
		public const string KhitanSmallScript = "Khitan Small Script";
		public const string TangutSupplement = "Tangut Supplement";
		public const string KanaSupplement = "Kana Supplement";
		public const string KanaExtendedA = "Kana Extended-A";
		public const string SmallKanaExtension = "Small Kana Extension";
		public const string Nushu = "Nushu";
		public const string Duployan = "Duployan";
		public const string ShorthandFormatControls = "Shorthand Format Controls";
		public const string ByzantineMusicalSymbols = "Byzantine Musical Symbols";
		public const string MusicalSymbols = "Musical Symbols";
		public const string AncientGreekMusicalNotation = "Ancient Greek Musical Notation";
		public const string MayanNumerals = "Mayan Numerals";
		public const string TaiXuanJingSymbols = "Tai Xuan Jing Symbols";
		public const string CountingRodNumerals = "Counting Rod Numerals";
		public const string MathematicalAlphanumericSymbols = "Mathematical Alphanumeric Symbols";
		public const string SuttonSignWriting = "Sutton SignWriting";
		public const string GlagoliticSupplement = "Glagolitic Supplement";
		public const string NyiakengPuachueHmong = "Nyiakeng Puachue Hmong";
		public const string Wancho = "Wancho";
		public const string MendeKikakui = "Mende Kikakui";
		public const string Adlam = "Adlam";
		public const string IndicSiyaqNumbers = "Indic Siyaq Numbers";
		public const string OttomanSiyaqNumbers = "Ottoman Siyaq Numbers";
		public const string ArabicMathematicalAlphabeticSymbols = "Arabic Mathematical Alphabetic Symbols";
		public const string MahjongTiles = "Mahjong Tiles";
		public const string DominoTiles = "Domino Tiles";
		public const string PlayingCards = "Playing Cards";
		public const string EnclosedAlphanumericSupplement = "Enclosed Alphanumeric Supplement";
		public const string EnclosedIdeographicSupplement = "Enclosed Ideographic Supplement";
		public const string MiscellaneousSymbolsandPictographs = "Miscellaneous Symbols and Pictographs";
		public const string Emoticons = "Emoticons";
		public const string OrnamentalDingbats = "Ornamental Dingbats";
		public const string TransportandMapSymbols = "Transport and Map Symbols";
		public const string AlchemicalSymbols = "Alchemical Symbols";
		public const string GeometricShapesExtended = "Geometric Shapes Extended";
		public const string SupplementalArrowsC = "Supplemental Arrows-C";
		public const string SupplementalSymbolsandPictographs = "Supplemental Symbols and Pictographs";
		public const string ChessSymbols = "Chess Symbols";
		public const string SymbolsandPictographsExtendedA = "Symbols and Pictographs Extended-A";
		public const string SymbolsforLegacyComputing = "Symbols for Legacy Computing";
		public const string CJKUnifiedIdeographsExtensionB = "CJK Unified Ideographs Extension B";
		public const string CJKUnifiedIdeographsExtensionC = "CJK Unified Ideographs Extension C";
		public const string CJKUnifiedIdeographsExtensionD = "CJK Unified Ideographs Extension D";
		public const string CJKUnifiedIdeographsExtensionE = "CJK Unified Ideographs Extension E";
		public const string CJKUnifiedIdeographsExtensionF = "CJK Unified Ideographs Extension F";
		public const string CJKCompatibilityIdeographsSupplement = "CJK Compatibility Ideographs Supplement";
		public const string CJKUnifiedIdeographsExtensionG = "CJK Unified Ideographs Extension G";
		public const string Tags = "Tags";
		public const string VariationSelectorsSupplement = "Variation Selectors Supplement";
		public const string SupplementaryPrivateUseAreaA = "Supplementary Private Use Area-A";
		public const string SupplementaryPrivateUseAreaB = "Supplementary Private Use Area-B";

		static Dictionary<string, int[]> Range;

		static void InitRange() {
			Range = new Dictionary<string, int[]> {
				{ BasicLatin, new int[] { 0x0000, 0x007F } },
				{ Latin1Supplement, new int[] { 0x0080, 0x00FF } },
				{ LatinExtendedA, new int[] { 0x0100, 0x017F } },
				{ LatinExtendedB, new int[] { 0x0180, 0x024F } },
				{ IPAExtensions, new int[] { 0x0250, 0x02AF } },
				{ SpacingModifierLetters, new int[] { 0x02B0, 0x02FF } },
				{ CombiningDiacriticalMarks, new int[] { 0x0300, 0x036F } },
				{ GreekandCoptic, new int[] { 0x0370, 0x03FF } },
				{ Cyrillic, new int[] { 0x0400, 0x04FF } },
				{ CyrillicSupplement, new int[] { 0x0500, 0x052F } },
				{ Armenian, new int[] { 0x0530, 0x058F } },
				{ Hebrew, new int[] { 0x0590, 0x05FF } },
				{ Arabic, new int[] { 0x0600, 0x06FF } },
				{ Syriac, new int[] { 0x0700, 0x074F } },
				{ ArabicSupplement, new int[] { 0x0750, 0x077F } },
				{ Thaana, new int[] { 0x0780, 0x07BF } },
				{ NKo, new int[] { 0x07C0, 0x07FF } },
				{ Samaritan, new int[] { 0x0800, 0x083F } },
				{ Mandaic, new int[] { 0x0840, 0x085F } },
				{ SyriacSupplement, new int[] { 0x0860, 0x086F } },
				{ ArabicExtendedA, new int[] { 0x08A0, 0x08FF } },
				{ Devanagari, new int[] { 0x0900, 0x097F } },
				{ Bengali, new int[] { 0x0980, 0x09FF } },
				{ Gurmukhi, new int[] { 0x0A00, 0x0A7F } },
				{ Gujarati, new int[] { 0x0A80, 0x0AFF } },
				{ Oriya, new int[] { 0x0B00, 0x0B7F } },
				{ Tamil, new int[] { 0x0B80, 0x0BFF } },
				{ Telugu, new int[] { 0x0C00, 0x0C7F } },
				{ Kannada, new int[] { 0x0C80, 0x0CFF } },
				{ Malayalam, new int[] { 0x0D00, 0x0D7F } },
				{ Sinhala, new int[] { 0x0D80, 0x0DFF } },
				{ Thai, new int[] { 0x0E00, 0x0E7F } },
				{ Lao, new int[] { 0x0E80, 0x0EFF } },
				{ Tibetan, new int[] { 0x0F00, 0x0FFF } },
				{ Myanmar, new int[] { 0x1000, 0x109F } },
				{ Georgian, new int[] { 0x10A0, 0x10FF } },
				{ HangulJamo, new int[] { 0x1100, 0x11FF } },
				{ Ethiopic, new int[] { 0x1200, 0x137F } },
				{ EthiopicSupplement, new int[] { 0x1380, 0x139F } },
				{ Cherokee, new int[] { 0x13A0, 0x13FF } },
				{ UnifiedCanadianAboriginalSyllabics, new int[] { 0x1400, 0x167F } },
				{ Ogham, new int[] { 0x1680, 0x169F } },
				{ Runic, new int[] { 0x16A0, 0x16FF } },
				{ Tagalog, new int[] { 0x1700, 0x171F } },
				{ Hanunoo, new int[] { 0x1720, 0x173F } },
				{ Buhid, new int[] { 0x1740, 0x175F } },
				{ Tagbanwa, new int[] { 0x1760, 0x177F } },
				{ Khmer, new int[] { 0x1780, 0x17FF } },
				{ Mongolian, new int[] { 0x1800, 0x18AF } },
				{ UnifiedCanadianAboriginalSyllabicsExtended, new int[] { 0x18B0, 0x18FF } },
				{ Limbu, new int[] { 0x1900, 0x194F } },
				{ TaiLe, new int[] { 0x1950, 0x197F } },
				{ NewTaiLue, new int[] { 0x1980, 0x19DF } },
				{ KhmerSymbols, new int[] { 0x19E0, 0x19FF } },
				{ Buginese, new int[] { 0x1A00, 0x1A1F } },
				{ TaiTham, new int[] { 0x1A20, 0x1AAF } },
				{ CombiningDiacriticalMarksExtended, new int[] { 0x1AB0, 0x1AFF } },
				{ Balinese, new int[] { 0x1B00, 0x1B7F } },
				{ Sundanese, new int[] { 0x1B80, 0x1BBF } },
				{ Batak, new int[] { 0x1BC0, 0x1BFF } },
				{ Lepcha, new int[] { 0x1C00, 0x1C4F } },
				{ OlChiki, new int[] { 0x1C50, 0x1C7F } },
				{ CyrillicExtendedC, new int[] { 0x1C80, 0x1C8F } },
				{ GeorgianExtended, new int[] { 0x1C90, 0x1CBF } },
				{ SundaneseSupplement, new int[] { 0x1CC0, 0x1CCF } },
				{ VedicExtensions, new int[] { 0x1CD0, 0x1CFF } },
				{ PhoneticExtensions, new int[] { 0x1D00, 0x1D7F } },
				{ PhoneticExtensionsSupplement, new int[] { 0x1D80, 0x1DBF } },
				{ CombiningDiacriticalMarksSupplement, new int[] { 0x1DC0, 0x1DFF } },
				{ LatinExtendedAdditional, new int[] { 0x1E00, 0x1EFF } },
				{ GreekExtended, new int[] { 0x1F00, 0x1FFF } },
				{ GeneralPunctuation, new int[] { 0x2000, 0x206F } },
				{ SuperscriptsandSubscripts, new int[] { 0x2070, 0x209F } },
				{ CurrencySymbols, new int[] { 0x20A0, 0x20CF } },
				{ CombiningDiacriticalMarksforSymbols, new int[] { 0x20D0, 0x20FF } },
				{ LetterlikeSymbols, new int[] { 0x2100, 0x214F } },
				{ NumberForms, new int[] { 0x2150, 0x218F } },
				{ Arrows, new int[] { 0x2190, 0x21FF } },
				{ MathematicalOperators, new int[] { 0x2200, 0x22FF } },
				{ MiscellaneousTechnical, new int[] { 0x2300, 0x23FF } },
				{ ControlPictures, new int[] { 0x2400, 0x243F } },
				{ OpticalCharacterRecognition, new int[] { 0x2440, 0x245F } },
				{ EnclosedAlphanumerics, new int[] { 0x2460, 0x24FF } },
				{ BoxDrawing, new int[] { 0x2500, 0x257F } },
				{ BlockElements, new int[] { 0x2580, 0x259F } },
				{ GeometricShapes, new int[] { 0x25A0, 0x25FF } },
				{ MiscellaneousSymbols, new int[] { 0x2600, 0x26FF } },
				{ Dingbats, new int[] { 0x2700, 0x27BF } },
				{ MiscellaneousMathematicalSymbolsA, new int[] { 0x27C0, 0x27EF } },
				{ SupplementalArrowsA, new int[] { 0x27F0, 0x27FF } },
				{ BraillePatterns, new int[] { 0x2800, 0x28FF } },
				{ SupplementalArrowsB, new int[] { 0x2900, 0x297F } },
				{ MiscellaneousMathematicalSymbolsB, new int[] { 0x2980, 0x29FF } },
				{ SupplementalMathematicalOperators, new int[] { 0x2A00, 0x2AFF } },
				{ MiscellaneousSymbolsandArrows, new int[] { 0x2B00, 0x2BFF } },
				{ Glagolitic, new int[] { 0x2C00, 0x2C5F } },
				{ LatinExtendedC, new int[] { 0x2C60, 0x2C7F } },
				{ Coptic, new int[] { 0x2C80, 0x2CFF } },
				{ GeorgianSupplement, new int[] { 0x2D00, 0x2D2F } },
				{ Tifinagh, new int[] { 0x2D30, 0x2D7F } },
				{ EthiopicExtended, new int[] { 0x2D80, 0x2DDF } },
				{ CyrillicExtendedA, new int[] { 0x2DE0, 0x2DFF } },
				{ SupplementalPunctuation, new int[] { 0x2E00, 0x2E7F } },
				{ CJKRadicalsSupplement, new int[] { 0x2E80, 0x2EFF } },
				{ KangxiRadicals, new int[] { 0x2F00, 0x2FDF } },
				{ IdeographicDescriptionCharacters, new int[] { 0x2FF0, 0x2FFF } },
				{ CJKSymbolsandPunctuation, new int[] { 0x3000, 0x303F } },
				{ Hiragana, new int[] { 0x3040, 0x309F } },
				{ Katakana, new int[] { 0x30A0, 0x30FF } },
				{ Bopomofo, new int[] { 0x3100, 0x312F } },
				{ HangulCompatibilityJamo, new int[] { 0x3130, 0x318F } },
				{ Kanbun, new int[] { 0x3190, 0x319F } },
				{ BopomofoExtended, new int[] { 0x31A0, 0x31BF } },
				{ CJKStrokes, new int[] { 0x31C0, 0x31EF } },
				{ KatakanaPhoneticExtensions, new int[] { 0x31F0, 0x31FF } },
				{ EnclosedCJKLettersandMonths, new int[] { 0x3200, 0x32FF } },
				{ CJKCompatibility, new int[] { 0x3300, 0x33FF } },
				{ CJKUnifiedIdeographsExtensionA, new int[] { 0x3400, 0x4DBF } },
				{ YijingHexagramSymbols, new int[] { 0x4DC0, 0x4DFF } },
				{ CJKUnifiedIdeographs, new int[] { 0x4E00, 0x9FFF } },
				{ YiSyllables, new int[] { 0xA000, 0xA48F } },
				{ YiRadicals, new int[] { 0xA490, 0xA4CF } },
				{ Lisu, new int[] { 0xA4D0, 0xA4FF } },
				{ Vai, new int[] { 0xA500, 0xA63F } },
				{ CyrillicExtendedB, new int[] { 0xA640, 0xA69F } },
				{ Bamum, new int[] { 0xA6A0, 0xA6FF } },
				{ ModifierToneLetters, new int[] { 0xA700, 0xA71F } },
				{ LatinExtendedD, new int[] { 0xA720, 0xA7FF } },
				{ SylotiNagri, new int[] { 0xA800, 0xA82F } },
				{ CommonIndicNumberForms, new int[] { 0xA830, 0xA83F } },
				{ Phagspa, new int[] { 0xA840, 0xA87F } },
				{ Saurashtra, new int[] { 0xA880, 0xA8DF } },
				{ DevanagariExtended, new int[] { 0xA8E0, 0xA8FF } },
				{ KayahLi, new int[] { 0xA900, 0xA92F } },
				{ Rejang, new int[] { 0xA930, 0xA95F } },
				{ HangulJamoExtendedA, new int[] { 0xA960, 0xA97F } },
				{ Javanese, new int[] { 0xA980, 0xA9DF } },
				{ MyanmarExtendedB, new int[] { 0xA9E0, 0xA9FF } },
				{ Cham, new int[] { 0xAA00, 0xAA5F } },
				{ MyanmarExtendedA, new int[] { 0xAA60, 0xAA7F } },
				{ TaiViet, new int[] { 0xAA80, 0xAADF } },
				{ MeeteiMayekExtensions, new int[] { 0xAAE0, 0xAAFF } },
				{ EthiopicExtendedA, new int[] { 0xAB00, 0xAB2F } },
				{ LatinExtendedE, new int[] { 0xAB30, 0xAB6F } },
				{ CherokeeSupplement, new int[] { 0xAB70, 0xABBF } },
				{ MeeteiMayek, new int[] { 0xABC0, 0xABFF } },
				{ HangulSyllables, new int[] { 0xAC00, 0xD7AF } },
				{ HangulJamoExtendedB, new int[] { 0xD7B0, 0xD7FF } },
				{ HighSurrogates, new int[] { 0xD800, 0xDB7F } },
				{ HighPrivateUseSurrogates, new int[] { 0xDB80, 0xDBFF } },
				{ LowSurrogates, new int[] { 0xDC00, 0xDFFF } },
				{ PrivateUseArea, new int[] { 0xE000, 0xF8FF } },
				{ CJKCompatibilityIdeographs, new int[] { 0xF900, 0xFAFF } },
				{ AlphabeticPresentationForms, new int[] { 0xFB00, 0xFB4F } },
				{ ArabicPresentationFormsA, new int[] { 0xFB50, 0xFDFF } },
				{ VariationSelectors, new int[] { 0xFE00, 0xFE0F } },
				{ VerticalForms, new int[] { 0xFE10, 0xFE1F } },
				{ CombiningHalfMarks, new int[] { 0xFE20, 0xFE2F } },
				{ CJKCompatibilityForms, new int[] { 0xFE30, 0xFE4F } },
				{ SmallFormVariants, new int[] { 0xFE50, 0xFE6F } },
				{ ArabicPresentationFormsB, new int[] { 0xFE70, 0xFEFF } },
				{ HalfwidthandFullwidthForms, new int[] { 0xFF00, 0xFFEF } },
				{ Specials, new int[] { 0xFFF0, 0xFFFF } },
				{ LinearBSyllabary, new int[] { 0x10000, 0x1007F } },
				{ LinearBIdeograms, new int[] { 0x10080, 0x100FF } },
				{ AegeanNumbers, new int[] { 0x10100, 0x1013F } },
				{ AncientGreekNumbers, new int[] { 0x10140, 0x1018F } },
				{ AncientSymbols, new int[] { 0x10190, 0x101CF } },
				{ PhaistosDisc, new int[] { 0x101D0, 0x101FF } },
				{ Lycian, new int[] { 0x10280, 0x1029F } },
				{ Carian, new int[] { 0x102A0, 0x102DF } },
				{ CopticEpactNumbers, new int[] { 0x102E0, 0x102FF } },
				{ OldItalic, new int[] { 0x10300, 0x1032F } },
				{ Gothic, new int[] { 0x10330, 0x1034F } },
				{ OldPermic, new int[] { 0x10350, 0x1037F } },
				{ Ugaritic, new int[] { 0x10380, 0x1039F } },
				{ OldPersian, new int[] { 0x103A0, 0x103DF } },
				{ Deseret, new int[] { 0x10400, 0x1044F } },
				{ Shavian, new int[] { 0x10450, 0x1047F } },
				{ Osmanya, new int[] { 0x10480, 0x104AF } },
				{ Osage, new int[] { 0x104B0, 0x104FF } },
				{ Elbasan, new int[] { 0x10500, 0x1052F } },
				{ CaucasianAlbanian, new int[] { 0x10530, 0x1056F } },
				{ LinearA, new int[] { 0x10600, 0x1077F } },
				{ CypriotSyllabary, new int[] { 0x10800, 0x1083F } },
				{ ImperialAramaic, new int[] { 0x10840, 0x1085F } },
				{ Palmyrene, new int[] { 0x10860, 0x1087F } },
				{ Nabataean, new int[] { 0x10880, 0x108AF } },
				{ Hatran, new int[] { 0x108E0, 0x108FF } },
				{ Phoenician, new int[] { 0x10900, 0x1091F } },
				{ Lydian, new int[] { 0x10920, 0x1093F } },
				{ MeroiticHieroglyphs, new int[] { 0x10980, 0x1099F } },
				{ MeroiticCursive, new int[] { 0x109A0, 0x109FF } },
				{ Kharoshthi, new int[] { 0x10A00, 0x10A5F } },
				{ OldSouthArabian, new int[] { 0x10A60, 0x10A7F } },
				{ OldNorthArabian, new int[] { 0x10A80, 0x10A9F } },
				{ Manichaean, new int[] { 0x10AC0, 0x10AFF } },
				{ Avestan, new int[] { 0x10B00, 0x10B3F } },
				{ InscriptionalParthian, new int[] { 0x10B40, 0x10B5F } },
				{ InscriptionalPahlavi, new int[] { 0x10B60, 0x10B7F } },
				{ PsalterPahlavi, new int[] { 0x10B80, 0x10BAF } },
				{ OldTurkic, new int[] { 0x10C00, 0x10C4F } },
				{ OldHungarian, new int[] { 0x10C80, 0x10CFF } },
				{ HanifiRohingya, new int[] { 0x10D00, 0x10D3F } },
				{ RumiNumeralSymbols, new int[] { 0x10E60, 0x10E7F } },
				{ Yezidi, new int[] { 0x10E80, 0x10EBF } },
				{ OldSogdian, new int[] { 0x10F00, 0x10F2F } },
				{ Sogdian, new int[] { 0x10F30, 0x10F6F } },
				{ Chorasmian, new int[] { 0x10FB0, 0x10FDF } },
				{ Elymaic, new int[] { 0x10FE0, 0x10FFF } },
				{ Brahmi, new int[] { 0x11000, 0x1107F } },
				{ Kaithi, new int[] { 0x11080, 0x110CF } },
				{ SoraSompeng, new int[] { 0x110D0, 0x110FF } },
				{ Chakma, new int[] { 0x11100, 0x1114F } },
				{ Mahajani, new int[] { 0x11150, 0x1117F } },
				{ Sharada, new int[] { 0x11180, 0x111DF } },
				{ SinhalaArchaicNumbers, new int[] { 0x111E0, 0x111FF } },
				{ Khojki, new int[] { 0x11200, 0x1124F } },
				{ Multani, new int[] { 0x11280, 0x112AF } },
				{ Khudawadi, new int[] { 0x112B0, 0x112FF } },
				{ Grantha, new int[] { 0x11300, 0x1137F } },
				{ Newa, new int[] { 0x11400, 0x1147F } },
				{ Tirhuta, new int[] { 0x11480, 0x114DF } },
				{ Siddham, new int[] { 0x11580, 0x115FF } },
				{ Modi, new int[] { 0x11600, 0x1165F } },
				{ MongolianSupplement, new int[] { 0x11660, 0x1167F } },
				{ Takri, new int[] { 0x11680, 0x116CF } },
				{ Ahom, new int[] { 0x11700, 0x1173F } },
				{ Dogra, new int[] { 0x11800, 0x1184F } },
				{ WarangCiti, new int[] { 0x118A0, 0x118FF } },
				{ DivesAkuru, new int[] { 0x11900, 0x1195F } },
				{ Nandinagari, new int[] { 0x119A0, 0x119FF } },
				{ ZanabazarSquare, new int[] { 0x11A00, 0x11A4F } },
				{ Soyombo, new int[] { 0x11A50, 0x11AAF } },
				{ PauCinHau, new int[] { 0x11AC0, 0x11AFF } },
				{ Bhaiksuki, new int[] { 0x11C00, 0x11C6F } },
				{ Marchen, new int[] { 0x11C70, 0x11CBF } },
				{ MasaramGondi, new int[] { 0x11D00, 0x11D5F } },
				{ GunjalaGondi, new int[] { 0x11D60, 0x11DAF } },
				{ Makasar, new int[] { 0x11EE0, 0x11EFF } },
				{ LisuSupplement, new int[] { 0x11FB0, 0x11FBF } },
				{ TamilSupplement, new int[] { 0x11FC0, 0x11FFF } },
				{ Cuneiform, new int[] { 0x12000, 0x123FF } },
				{ CuneiformNumbersandPunctuation, new int[] { 0x12400, 0x1247F } },
				{ EarlyDynasticCuneiform, new int[] { 0x12480, 0x1254F } },
				{ EgyptianHieroglyphs, new int[] { 0x13000, 0x1342F } },
				{ EgyptianHieroglyphFormatControls, new int[] { 0x13430, 0x1343F } },
				{ AnatolianHieroglyphs, new int[] { 0x14400, 0x1467F } },
				{ BamumSupplement, new int[] { 0x16800, 0x16A3F } },
				{ Mro, new int[] { 0x16A40, 0x16A6F } },
				{ BassaVah, new int[] { 0x16AD0, 0x16AFF } },
				{ PahawhHmong, new int[] { 0x16B00, 0x16B8F } },
				{ Medefaidrin, new int[] { 0x16E40, 0x16E9F } },
				{ Miao, new int[] { 0x16F00, 0x16F9F } },
				{ IdeographicSymbolsandPunctuation, new int[] { 0x16FE0, 0x16FFF } },
				{ Tangut, new int[] { 0x17000, 0x187FF } },
				{ TangutComponents, new int[] { 0x18800, 0x18AFF } },
				{ KhitanSmallScript, new int[] { 0x18B00, 0x18CFF } },
				{ TangutSupplement, new int[] { 0x18D00, 0x18D8F } },
				{ KanaSupplement, new int[] { 0x1B000, 0x1B0FF } },
				{ KanaExtendedA, new int[] { 0x1B100, 0x1B12F } },
				{ SmallKanaExtension, new int[] { 0x1B130, 0x1B16F } },
				{ Nushu, new int[] { 0x1B170, 0x1B2FF } },
				{ Duployan, new int[] { 0x1BC00, 0x1BC9F } },
				{ ShorthandFormatControls, new int[] { 0x1BCA0, 0x1BCAF } },
				{ ByzantineMusicalSymbols, new int[] { 0x1D000, 0x1D0FF } },
				{ MusicalSymbols, new int[] { 0x1D100, 0x1D1FF } },
				{ AncientGreekMusicalNotation, new int[] { 0x1D200, 0x1D24F } },
				{ MayanNumerals, new int[] { 0x1D2E0, 0x1D2FF } },
				{ TaiXuanJingSymbols, new int[] { 0x1D300, 0x1D35F } },
				{ CountingRodNumerals, new int[] { 0x1D360, 0x1D37F } },
				{ MathematicalAlphanumericSymbols, new int[] { 0x1D400, 0x1D7FF } },
				{ SuttonSignWriting, new int[] { 0x1D800, 0x1DAAF } },
				{ GlagoliticSupplement, new int[] { 0x1E000, 0x1E02F } },
				{ NyiakengPuachueHmong, new int[] { 0x1E100, 0x1E14F } },
				{ Wancho, new int[] { 0x1E2C0, 0x1E2FF } },
				{ MendeKikakui, new int[] { 0x1E800, 0x1E8DF } },
				{ Adlam, new int[] { 0x1E900, 0x1E95F } },
				{ IndicSiyaqNumbers, new int[] { 0x1EC70, 0x1ECBF } },
				{ OttomanSiyaqNumbers, new int[] { 0x1ED00, 0x1ED4F } },
				{ ArabicMathematicalAlphabeticSymbols, new int[] { 0x1EE00, 0x1EEFF } },
				{ MahjongTiles, new int[] { 0x1F000, 0x1F02F } },
				{ DominoTiles, new int[] { 0x1F030, 0x1F09F } },
				{ PlayingCards, new int[] { 0x1F0A0, 0x1F0FF } },
				{ EnclosedAlphanumericSupplement, new int[] { 0x1F100, 0x1F1FF } },
				{ EnclosedIdeographicSupplement, new int[] { 0x1F200, 0x1F2FF } },
				{ MiscellaneousSymbolsandPictographs, new int[] { 0x1F300, 0x1F5FF } },
				{ Emoticons, new int[] { 0x1F600, 0x1F64F } },
				{ OrnamentalDingbats, new int[] { 0x1F650, 0x1F67F } },
				{ TransportandMapSymbols, new int[] { 0x1F680, 0x1F6FF } },
				{ AlchemicalSymbols, new int[] { 0x1F700, 0x1F77F } },
				{ GeometricShapesExtended, new int[] { 0x1F780, 0x1F7FF } },
				{ SupplementalArrowsC, new int[] { 0x1F800, 0x1F8FF } },
				{ SupplementalSymbolsandPictographs, new int[] { 0x1F900, 0x1F9FF } },
				{ ChessSymbols, new int[] { 0x1FA00, 0x1FA6F } },
				{ SymbolsandPictographsExtendedA, new int[] { 0x1FA70, 0x1FAFF } },
				{ SymbolsforLegacyComputing, new int[] { 0x1FB00, 0x1FBFF } },
				{ CJKUnifiedIdeographsExtensionB, new int[] { 0x20000, 0x2A6DF } },
				{ CJKUnifiedIdeographsExtensionC, new int[] { 0x2A700, 0x2B73F } },
				{ CJKUnifiedIdeographsExtensionD, new int[] { 0x2B740, 0x2B81F } },
				{ CJKUnifiedIdeographsExtensionE, new int[] { 0x2B820, 0x2CEAF } },
				{ CJKUnifiedIdeographsExtensionF, new int[] { 0x2CEB0, 0x2EBEF } },
				{ CJKCompatibilityIdeographsSupplement, new int[] { 0x2F800, 0x2FA1F } },
				{ CJKUnifiedIdeographsExtensionG, new int[] { 0x30000, 0x3134F } },
				{ Tags, new int[] { 0xE0000, 0xE007F } },
				{ VariationSelectorsSupplement, new int[] { 0xE0100, 0xE01EF } },
				{ SupplementaryPrivateUseAreaA, new int[] { 0xF0000, 0xFFFFF } },
				{ SupplementaryPrivateUseAreaB, new int[] { 0x100000, 0x10FFFF } }
			};
		}

		public static bool Contains(string blockName) {
			if (Range == null) {
				InitRange();
			}
			return Range.ContainsKey(blockName);
		}

		public static bool IsIncludedIn(string blockName, int codePoint) {
			if (codePoint < 0 || codePoint > UnicodeCodePoint.Max) {
				return false;
			}
			if (Range == null) {
				InitRange();
			}
			if (Range.TryGetValue(blockName, out int[] range)) {
				return codePoint >= range[0] && codePoint <= range[1];
			}
			return false;
		}

		public static string GetName(int codePoint) {
			if (codePoint < 0 || codePoint > UnicodeCodePoint.Max) {
				return string.Empty;
			}
			if (Range == null) {
				InitRange();
			}
			foreach (KeyValuePair<string, int[]> item in Range) {
				if (codePoint >= item.Value[0] && codePoint <= item.Value[1]) {
					return item.Key;
				}
			}
			return No_Block;
		}
	}
}
