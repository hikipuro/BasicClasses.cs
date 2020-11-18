namespace BasicClasses {
	public class UnicodeBlock {
		public static readonly UnicodeBlock No_Block = new UnicodeBlock(
			"No_Block", -1, -1
		);

		public static readonly UnicodeBlock BasicLatin = new UnicodeBlock(
			"Basic Latin", 0x0000, 0x007F
		);

		public static readonly UnicodeBlock Latin1Supplement = new UnicodeBlock(
			"Latin-1 Supplement", 0x0080, 0x00FF
		);

		public static readonly UnicodeBlock LatinExtendedA = new UnicodeBlock(
			"Latin Extended-A", 0x0100, 0x017F
		);

		public static readonly UnicodeBlock LatinExtendedB = new UnicodeBlock(
			"Latin Extended-B", 0x0180, 0x024F
		);

		public static readonly UnicodeBlock IPAExtensions = new UnicodeBlock(
			"IPA Extensions", 0x0250, 0x02AF
		);

		public static readonly UnicodeBlock SpacingModifierLetters = new UnicodeBlock(
			"Spacing Modifier Letters", 0x02B0, 0x02FF
		);

		public static readonly UnicodeBlock CombiningDiacriticalMarks = new UnicodeBlock(
			"Combining Diacritical Marks", 0x0300, 0x036F
		);

		public static readonly UnicodeBlock GreekandCoptic = new UnicodeBlock(
			"Greek and Coptic", 0x0370, 0x03FF
		);

		public static readonly UnicodeBlock Cyrillic = new UnicodeBlock(
			"Cyrillic", 0x0400, 0x04FF
		);

		public static readonly UnicodeBlock CyrillicSupplement = new UnicodeBlock(
			"Cyrillic Supplement", 0x0500, 0x052F
		);

		public static readonly UnicodeBlock Armenian = new UnicodeBlock(
			"Armenian", 0x0530, 0x058F
		);

		public static readonly UnicodeBlock Hebrew = new UnicodeBlock(
			"Hebrew", 0x0590, 0x05FF
		);

		public static readonly UnicodeBlock Arabic = new UnicodeBlock(
			"Arabic", 0x0600, 0x06FF
		);

		public static readonly UnicodeBlock Syriac = new UnicodeBlock(
			"Syriac", 0x0700, 0x074F
		);

		public static readonly UnicodeBlock ArabicSupplement = new UnicodeBlock(
			"Arabic Supplement", 0x0750, 0x077F
		);

		public static readonly UnicodeBlock Thaana = new UnicodeBlock(
			"Thaana", 0x0780, 0x07BF
		);

		public static readonly UnicodeBlock NKo = new UnicodeBlock(
			"NKo", 0x07C0, 0x07FF
		);

		public static readonly UnicodeBlock Samaritan = new UnicodeBlock(
			"Samaritan", 0x0800, 0x083F
		);

		public static readonly UnicodeBlock Mandaic = new UnicodeBlock(
			"Mandaic", 0x0840, 0x085F
		);

		public static readonly UnicodeBlock SyriacSupplement = new UnicodeBlock(
			"Syriac Supplement", 0x0860, 0x086F
		);

		public static readonly UnicodeBlock ArabicExtendedA = new UnicodeBlock(
			"Arabic Extended-A", 0x08A0, 0x08FF
		);

		public static readonly UnicodeBlock Devanagari = new UnicodeBlock(
			"Devanagari", 0x0900, 0x097F
		);

		public static readonly UnicodeBlock Bengali = new UnicodeBlock(
			"Bengali", 0x0980, 0x09FF
		);

		public static readonly UnicodeBlock Gurmukhi = new UnicodeBlock(
			"Gurmukhi", 0x0A00, 0x0A7F
		);

		public static readonly UnicodeBlock Gujarati = new UnicodeBlock(
			"Gujarati", 0x0A80, 0x0AFF
		);

		public static readonly UnicodeBlock Oriya = new UnicodeBlock(
			"Oriya", 0x0B00, 0x0B7F
		);

		public static readonly UnicodeBlock Tamil = new UnicodeBlock(
			"Tamil", 0x0B80, 0x0BFF
		);

		public static readonly UnicodeBlock Telugu = new UnicodeBlock(
			"Telugu", 0x0C00, 0x0C7F
		);

		public static readonly UnicodeBlock Kannada = new UnicodeBlock(
			"Kannada", 0x0C80, 0x0CFF
		);

		public static readonly UnicodeBlock Malayalam = new UnicodeBlock(
			"Malayalam", 0x0D00, 0x0D7F
		);

		public static readonly UnicodeBlock Sinhala = new UnicodeBlock(
			"Sinhala", 0x0D80, 0x0DFF
		);

		public static readonly UnicodeBlock Thai = new UnicodeBlock(
			"Thai", 0x0E00, 0x0E7F
		);

		public static readonly UnicodeBlock Lao = new UnicodeBlock(
			"Lao", 0x0E80, 0x0EFF
		);

		public static readonly UnicodeBlock Tibetan = new UnicodeBlock(
			"Tibetan", 0x0F00, 0x0FFF
		);

		public static readonly UnicodeBlock Myanmar = new UnicodeBlock(
			"Myanmar", 0x1000, 0x109F
		);

		public static readonly UnicodeBlock Georgian = new UnicodeBlock(
			"Georgian", 0x10A0, 0x10FF
		);

		public static readonly UnicodeBlock HangulJamo = new UnicodeBlock(
			"Hangul Jamo", 0x1100, 0x11FF
		);

		public static readonly UnicodeBlock Ethiopic = new UnicodeBlock(
			"Ethiopic", 0x1200, 0x137F
		);

		public static readonly UnicodeBlock EthiopicSupplement = new UnicodeBlock(
			"Ethiopic Supplement", 0x1380, 0x139F
		);

		public static readonly UnicodeBlock Cherokee = new UnicodeBlock(
			"Cherokee", 0x13A0, 0x13FF
		);

		public static readonly UnicodeBlock UnifiedCanadianAboriginalSyllabics = new UnicodeBlock(
			"Unified Canadian Aboriginal Syllabics", 0x1400, 0x167F
		);

		public static readonly UnicodeBlock Ogham = new UnicodeBlock(
			"Ogham", 0x1680, 0x169F
		);

		public static readonly UnicodeBlock Runic = new UnicodeBlock(
			"Runic", 0x16A0, 0x16FF
		);

		public static readonly UnicodeBlock Tagalog = new UnicodeBlock(
			"Tagalog", 0x1700, 0x171F
		);

		public static readonly UnicodeBlock Hanunoo = new UnicodeBlock(
			"Hanunoo", 0x1720, 0x173F
		);

		public static readonly UnicodeBlock Buhid = new UnicodeBlock(
			"Buhid", 0x1740, 0x175F
		);

		public static readonly UnicodeBlock Tagbanwa = new UnicodeBlock(
			"Tagbanwa", 0x1760, 0x177F
		);

		public static readonly UnicodeBlock Khmer = new UnicodeBlock(
			"Khmer", 0x1780, 0x17FF
		);

		public static readonly UnicodeBlock Mongolian = new UnicodeBlock(
			"Mongolian", 0x1800, 0x18AF
		);

		public static readonly UnicodeBlock UnifiedCanadianAboriginalSyllabicsExtended = new UnicodeBlock(
			"Unified Canadian Aboriginal Syllabics Extended", 0x18B0, 0x18FF
		);

		public static readonly UnicodeBlock Limbu = new UnicodeBlock(
			"Limbu", 0x1900, 0x194F
		);

		public static readonly UnicodeBlock TaiLe = new UnicodeBlock(
			"Tai Le", 0x1950, 0x197F
		);

		public static readonly UnicodeBlock NewTaiLue = new UnicodeBlock(
			"New Tai Lue", 0x1980, 0x19DF
		);

		public static readonly UnicodeBlock KhmerSymbols = new UnicodeBlock(
			"Khmer Symbols", 0x19E0, 0x19FF
		);

		public static readonly UnicodeBlock Buginese = new UnicodeBlock(
			"Buginese", 0x1A00, 0x1A1F
		);

		public static readonly UnicodeBlock TaiTham = new UnicodeBlock(
			"Tai Tham", 0x1A20, 0x1AAF
		);

		public static readonly UnicodeBlock CombiningDiacriticalMarksExtended = new UnicodeBlock(
			"Combining Diacritical Marks Extended", 0x1AB0, 0x1AFF
		);

		public static readonly UnicodeBlock Balinese = new UnicodeBlock(
			"Balinese", 0x1B00, 0x1B7F
		);

		public static readonly UnicodeBlock Sundanese = new UnicodeBlock(
			"Sundanese", 0x1B80, 0x1BBF
		);

		public static readonly UnicodeBlock Batak = new UnicodeBlock(
			"Batak", 0x1BC0, 0x1BFF
		);

		public static readonly UnicodeBlock Lepcha = new UnicodeBlock(
			"Lepcha", 0x1C00, 0x1C4F
		);

		public static readonly UnicodeBlock OlChiki = new UnicodeBlock(
			"Ol Chiki", 0x1C50, 0x1C7F
		);

		public static readonly UnicodeBlock CyrillicExtendedC = new UnicodeBlock(
			"Cyrillic Extended-C", 0x1C80, 0x1C8F
		);

		public static readonly UnicodeBlock GeorgianExtended = new UnicodeBlock(
			"Georgian Extended", 0x1C90, 0x1CBF
		);

		public static readonly UnicodeBlock SundaneseSupplement = new UnicodeBlock(
			"Sundanese Supplement", 0x1CC0, 0x1CCF
		);

		public static readonly UnicodeBlock VedicExtensions = new UnicodeBlock(
			"Vedic Extensions", 0x1CD0, 0x1CFF
		);

		public static readonly UnicodeBlock PhoneticExtensions = new UnicodeBlock(
			"Phonetic Extensions", 0x1D00, 0x1D7F
		);

		public static readonly UnicodeBlock PhoneticExtensionsSupplement = new UnicodeBlock(
			"Phonetic Extensions Supplement", 0x1D80, 0x1DBF
		);

		public static readonly UnicodeBlock CombiningDiacriticalMarksSupplement = new UnicodeBlock(
			"Combining Diacritical Marks Supplement", 0x1DC0, 0x1DFF
		);

		public static readonly UnicodeBlock LatinExtendedAdditional = new UnicodeBlock(
			"Latin Extended Additional", 0x1E00, 0x1EFF
		);

		public static readonly UnicodeBlock GreekExtended = new UnicodeBlock(
			"Greek Extended", 0x1F00, 0x1FFF
		);

		public static readonly UnicodeBlock GeneralPunctuation = new UnicodeBlock(
			"General Punctuation", 0x2000, 0x206F
		);

		public static readonly UnicodeBlock SuperscriptsandSubscripts = new UnicodeBlock(
			"Superscripts and Subscripts", 0x2070, 0x209F
		);

		public static readonly UnicodeBlock CurrencySymbols = new UnicodeBlock(
			"Currency Symbols", 0x20A0, 0x20CF
		);

		public static readonly UnicodeBlock CombiningDiacriticalMarksforSymbols = new UnicodeBlock(
			"Combining Diacritical Marks for Symbols", 0x20D0, 0x20FF
		);

		public static readonly UnicodeBlock LetterlikeSymbols = new UnicodeBlock(
			"Letterlike Symbols", 0x2100, 0x214F
		);

		public static readonly UnicodeBlock NumberForms = new UnicodeBlock(
			"Number Forms", 0x2150, 0x218F
		);

		public static readonly UnicodeBlock Arrows = new UnicodeBlock(
			"Arrows", 0x2190, 0x21FF
		);

		public static readonly UnicodeBlock MathematicalOperators = new UnicodeBlock(
			"Mathematical Operators", 0x2200, 0x22FF
		);

		public static readonly UnicodeBlock MiscellaneousTechnical = new UnicodeBlock(
			"Miscellaneous Technical", 0x2300, 0x23FF
		);

		public static readonly UnicodeBlock ControlPictures = new UnicodeBlock(
			"Control Pictures", 0x2400, 0x243F
		);

		public static readonly UnicodeBlock OpticalCharacterRecognition = new UnicodeBlock(
			"Optical Character Recognition", 0x2440, 0x245F
		);

		public static readonly UnicodeBlock EnclosedAlphanumerics = new UnicodeBlock(
			"Enclosed Alphanumerics", 0x2460, 0x24FF
		);

		public static readonly UnicodeBlock BoxDrawing = new UnicodeBlock(
			"Box Drawing", 0x2500, 0x257F
		);

		public static readonly UnicodeBlock BlockElements = new UnicodeBlock(
			"Block Elements", 0x2580, 0x259F
		);

		public static readonly UnicodeBlock GeometricShapes = new UnicodeBlock(
			"Geometric Shapes", 0x25A0, 0x25FF
		);

		public static readonly UnicodeBlock MiscellaneousSymbols = new UnicodeBlock(
			"Miscellaneous Symbols", 0x2600, 0x26FF
		);

		public static readonly UnicodeBlock Dingbats = new UnicodeBlock(
			"Dingbats", 0x2700, 0x27BF
		);

		public static readonly UnicodeBlock MiscellaneousMathematicalSymbolsA = new UnicodeBlock(
			"Miscellaneous Mathematical Symbols-A", 0x27C0, 0x27EF
		);

		public static readonly UnicodeBlock SupplementalArrowsA = new UnicodeBlock(
			"Supplemental Arrows-A", 0x27F0, 0x27FF
		);

		public static readonly UnicodeBlock BraillePatterns = new UnicodeBlock(
			"Braille Patterns", 0x2800, 0x28FF
		);

		public static readonly UnicodeBlock SupplementalArrowsB = new UnicodeBlock(
			"Supplemental Arrows-B", 0x2900, 0x297F
		);

		public static readonly UnicodeBlock MiscellaneousMathematicalSymbolsB = new UnicodeBlock(
			"Miscellaneous Mathematical Symbols-B", 0x2980, 0x29FF
		);

		public static readonly UnicodeBlock SupplementalMathematicalOperators = new UnicodeBlock(
			"Supplemental Mathematical Operators", 0x2A00, 0x2AFF
		);

		public static readonly UnicodeBlock MiscellaneousSymbolsandArrows = new UnicodeBlock(
			"Miscellaneous Symbols and Arrows", 0x2B00, 0x2BFF
		);

		public static readonly UnicodeBlock Glagolitic = new UnicodeBlock(
			"Glagolitic", 0x2C00, 0x2C5F
		);

		public static readonly UnicodeBlock LatinExtendedC = new UnicodeBlock(
			"Latin Extended-C", 0x2C60, 0x2C7F
		);

		public static readonly UnicodeBlock Coptic = new UnicodeBlock(
			"Coptic", 0x2C80, 0x2CFF
		);

		public static readonly UnicodeBlock GeorgianSupplement = new UnicodeBlock(
			"Georgian Supplement", 0x2D00, 0x2D2F
		);

		public static readonly UnicodeBlock Tifinagh = new UnicodeBlock(
			"Tifinagh", 0x2D30, 0x2D7F
		);

		public static readonly UnicodeBlock EthiopicExtended = new UnicodeBlock(
			"Ethiopic Extended", 0x2D80, 0x2DDF
		);

		public static readonly UnicodeBlock CyrillicExtendedA = new UnicodeBlock(
			"Cyrillic Extended-A", 0x2DE0, 0x2DFF
		);

		public static readonly UnicodeBlock SupplementalPunctuation = new UnicodeBlock(
			"Supplemental Punctuation", 0x2E00, 0x2E7F
		);

		public static readonly UnicodeBlock CJKRadicalsSupplement = new UnicodeBlock(
			"CJK Radicals Supplement", 0x2E80, 0x2EFF
		);

		public static readonly UnicodeBlock KangxiRadicals = new UnicodeBlock(
			"Kangxi Radicals", 0x2F00, 0x2FDF
		);

		public static readonly UnicodeBlock IdeographicDescriptionCharacters = new UnicodeBlock(
			"Ideographic Description Characters", 0x2FF0, 0x2FFF
		);

		public static readonly UnicodeBlock CJKSymbolsandPunctuation = new UnicodeBlock(
			"CJK Symbols and Punctuation", 0x3000, 0x303F
		);

		public static readonly UnicodeBlock Hiragana = new UnicodeBlock(
			"Hiragana", 0x3040, 0x309F
		);

		public static readonly UnicodeBlock Katakana = new UnicodeBlock(
			"Katakana", 0x30A0, 0x30FF
		);

		public static readonly UnicodeBlock Bopomofo = new UnicodeBlock(
			"Bopomofo", 0x3100, 0x312F
		);

		public static readonly UnicodeBlock HangulCompatibilityJamo = new UnicodeBlock(
			"Hangul Compatibility Jamo", 0x3130, 0x318F
		);

		public static readonly UnicodeBlock Kanbun = new UnicodeBlock(
			"Kanbun", 0x3190, 0x319F
		);

		public static readonly UnicodeBlock BopomofoExtended = new UnicodeBlock(
			"Bopomofo Extended", 0x31A0, 0x31BF
		);

		public static readonly UnicodeBlock CJKStrokes = new UnicodeBlock(
			"CJK Strokes", 0x31C0, 0x31EF
		);

		public static readonly UnicodeBlock KatakanaPhoneticExtensions = new UnicodeBlock(
			"Katakana Phonetic Extensions", 0x31F0, 0x31FF
		);

		public static readonly UnicodeBlock EnclosedCJKLettersandMonths = new UnicodeBlock(
			"Enclosed CJK Letters and Months", 0x3200, 0x32FF
		);

		public static readonly UnicodeBlock CJKCompatibility = new UnicodeBlock(
			"CJK Compatibility", 0x3300, 0x33FF
		);

		public static readonly UnicodeBlock CJKUnifiedIdeographsExtensionA = new UnicodeBlock(
			"CJK Unified Ideographs Extension A", 0x3400, 0x4DBF
		);

		public static readonly UnicodeBlock YijingHexagramSymbols = new UnicodeBlock(
			"Yijing Hexagram Symbols", 0x4DC0, 0x4DFF
		);

		public static readonly UnicodeBlock CJKUnifiedIdeographs = new UnicodeBlock(
			"CJK Unified Ideographs", 0x4E00, 0x9FFF
		);

		public static readonly UnicodeBlock YiSyllables = new UnicodeBlock(
			"Yi Syllables", 0xA000, 0xA48F
		);

		public static readonly UnicodeBlock YiRadicals = new UnicodeBlock(
			"Yi Radicals", 0xA490, 0xA4CF
		);

		public static readonly UnicodeBlock Lisu = new UnicodeBlock(
			"Lisu", 0xA4D0, 0xA4FF
		);

		public static readonly UnicodeBlock Vai = new UnicodeBlock(
			"Vai", 0xA500, 0xA63F
		);

		public static readonly UnicodeBlock CyrillicExtendedB = new UnicodeBlock(
			"Cyrillic Extended-B", 0xA640, 0xA69F
		);

		public static readonly UnicodeBlock Bamum = new UnicodeBlock(
			"Bamum", 0xA6A0, 0xA6FF
		);

		public static readonly UnicodeBlock ModifierToneLetters = new UnicodeBlock(
			"Modifier Tone Letters", 0xA700, 0xA71F
		);

		public static readonly UnicodeBlock LatinExtendedD = new UnicodeBlock(
			"Latin Extended-D", 0xA720, 0xA7FF
		);

		public static readonly UnicodeBlock SylotiNagri = new UnicodeBlock(
			"Syloti Nagri", 0xA800, 0xA82F
		);

		public static readonly UnicodeBlock CommonIndicNumberForms = new UnicodeBlock(
			"Common Indic Number Forms", 0xA830, 0xA83F
		);

		public static readonly UnicodeBlock Phagspa = new UnicodeBlock(
			"Phags-pa", 0xA840, 0xA87F
		);

		public static readonly UnicodeBlock Saurashtra = new UnicodeBlock(
			"Saurashtra", 0xA880, 0xA8DF
		);

		public static readonly UnicodeBlock DevanagariExtended = new UnicodeBlock(
			"Devanagari Extended", 0xA8E0, 0xA8FF
		);

		public static readonly UnicodeBlock KayahLi = new UnicodeBlock(
			"Kayah Li", 0xA900, 0xA92F
		);

		public static readonly UnicodeBlock Rejang = new UnicodeBlock(
			"Rejang", 0xA930, 0xA95F
		);

		public static readonly UnicodeBlock HangulJamoExtendedA = new UnicodeBlock(
			"Hangul Jamo Extended-A", 0xA960, 0xA97F
		);

		public static readonly UnicodeBlock Javanese = new UnicodeBlock(
			"Javanese", 0xA980, 0xA9DF
		);

		public static readonly UnicodeBlock MyanmarExtendedB = new UnicodeBlock(
			"Myanmar Extended-B", 0xA9E0, 0xA9FF
		);

		public static readonly UnicodeBlock Cham = new UnicodeBlock(
			"Cham", 0xAA00, 0xAA5F
		);

		public static readonly UnicodeBlock MyanmarExtendedA = new UnicodeBlock(
			"Myanmar Extended-A", 0xAA60, 0xAA7F
		);

		public static readonly UnicodeBlock TaiViet = new UnicodeBlock(
			"Tai Viet", 0xAA80, 0xAADF
		);

		public static readonly UnicodeBlock MeeteiMayekExtensions = new UnicodeBlock(
			"Meetei Mayek Extensions", 0xAAE0, 0xAAFF
		);

		public static readonly UnicodeBlock EthiopicExtendedA = new UnicodeBlock(
			"Ethiopic Extended-A", 0xAB00, 0xAB2F
		);

		public static readonly UnicodeBlock LatinExtendedE = new UnicodeBlock(
			"Latin Extended-E", 0xAB30, 0xAB6F
		);

		public static readonly UnicodeBlock CherokeeSupplement = new UnicodeBlock(
			"Cherokee Supplement", 0xAB70, 0xABBF
		);

		public static readonly UnicodeBlock MeeteiMayek = new UnicodeBlock(
			"Meetei Mayek", 0xABC0, 0xABFF
		);

		public static readonly UnicodeBlock HangulSyllables = new UnicodeBlock(
			"Hangul Syllables", 0xAC00, 0xD7AF
		);

		public static readonly UnicodeBlock HangulJamoExtendedB = new UnicodeBlock(
			"Hangul Jamo Extended-B", 0xD7B0, 0xD7FF
		);

		public static readonly UnicodeBlock HighSurrogates = new UnicodeBlock(
			"High Surrogates", 0xD800, 0xDB7F
		);

		public static readonly UnicodeBlock HighPrivateUseSurrogates = new UnicodeBlock(
			"High Private Use Surrogates", 0xDB80, 0xDBFF
		);

		public static readonly UnicodeBlock LowSurrogates = new UnicodeBlock(
			"Low Surrogates", 0xDC00, 0xDFFF
		);

		public static readonly UnicodeBlock PrivateUseArea = new UnicodeBlock(
			"Private Use Area", 0xE000, 0xF8FF
		);

		public static readonly UnicodeBlock CJKCompatibilityIdeographs = new UnicodeBlock(
			"CJK Compatibility Ideographs", 0xF900, 0xFAFF
		);

		public static readonly UnicodeBlock AlphabeticPresentationForms = new UnicodeBlock(
			"Alphabetic Presentation Forms", 0xFB00, 0xFB4F
		);

		public static readonly UnicodeBlock ArabicPresentationFormsA = new UnicodeBlock(
			"Arabic Presentation Forms-A", 0xFB50, 0xFDFF
		);

		public static readonly UnicodeBlock VariationSelectors = new UnicodeBlock(
			"Variation Selectors", 0xFE00, 0xFE0F
		);

		public static readonly UnicodeBlock VerticalForms = new UnicodeBlock(
			"Vertical Forms", 0xFE10, 0xFE1F
		);

		public static readonly UnicodeBlock CombiningHalfMarks = new UnicodeBlock(
			"Combining Half Marks", 0xFE20, 0xFE2F
		);

		public static readonly UnicodeBlock CJKCompatibilityForms = new UnicodeBlock(
			"CJK Compatibility Forms", 0xFE30, 0xFE4F
		);

		public static readonly UnicodeBlock SmallFormVariants = new UnicodeBlock(
			"Small Form Variants", 0xFE50, 0xFE6F
		);

		public static readonly UnicodeBlock ArabicPresentationFormsB = new UnicodeBlock(
			"Arabic Presentation Forms-B", 0xFE70, 0xFEFF
		);

		public static readonly UnicodeBlock HalfwidthandFullwidthForms = new UnicodeBlock(
			"Halfwidth and Fullwidth Forms", 0xFF00, 0xFFEF
		);

		public static readonly UnicodeBlock Specials = new UnicodeBlock(
			"Specials", 0xFFF0, 0xFFFF
		);

		public static readonly UnicodeBlock LinearBSyllabary = new UnicodeBlock(
			"Linear B Syllabary", 0x10000, 0x1007F
		);

		public static readonly UnicodeBlock LinearBIdeograms = new UnicodeBlock(
			"Linear B Ideograms", 0x10080, 0x100FF
		);

		public static readonly UnicodeBlock AegeanNumbers = new UnicodeBlock(
			"Aegean Numbers", 0x10100, 0x1013F
		);

		public static readonly UnicodeBlock AncientGreekNumbers = new UnicodeBlock(
			"Ancient Greek Numbers", 0x10140, 0x1018F
		);

		public static readonly UnicodeBlock AncientSymbols = new UnicodeBlock(
			"Ancient Symbols", 0x10190, 0x101CF
		);

		public static readonly UnicodeBlock PhaistosDisc = new UnicodeBlock(
			"Phaistos Disc", 0x101D0, 0x101FF
		);

		public static readonly UnicodeBlock Lycian = new UnicodeBlock(
			"Lycian", 0x10280, 0x1029F
		);

		public static readonly UnicodeBlock Carian = new UnicodeBlock(
			"Carian", 0x102A0, 0x102DF
		);

		public static readonly UnicodeBlock CopticEpactNumbers = new UnicodeBlock(
			"Coptic Epact Numbers", 0x102E0, 0x102FF
		);

		public static readonly UnicodeBlock OldItalic = new UnicodeBlock(
			"Old Italic", 0x10300, 0x1032F
		);

		public static readonly UnicodeBlock Gothic = new UnicodeBlock(
			"Gothic", 0x10330, 0x1034F
		);

		public static readonly UnicodeBlock OldPermic = new UnicodeBlock(
			"Old Permic", 0x10350, 0x1037F
		);

		public static readonly UnicodeBlock Ugaritic = new UnicodeBlock(
			"Ugaritic", 0x10380, 0x1039F
		);

		public static readonly UnicodeBlock OldPersian = new UnicodeBlock(
			"Old Persian", 0x103A0, 0x103DF
		);

		public static readonly UnicodeBlock Deseret = new UnicodeBlock(
			"Deseret", 0x10400, 0x1044F
		);

		public static readonly UnicodeBlock Shavian = new UnicodeBlock(
			"Shavian", 0x10450, 0x1047F
		);

		public static readonly UnicodeBlock Osmanya = new UnicodeBlock(
			"Osmanya", 0x10480, 0x104AF
		);

		public static readonly UnicodeBlock Osage = new UnicodeBlock(
			"Osage", 0x104B0, 0x104FF
		);

		public static readonly UnicodeBlock Elbasan = new UnicodeBlock(
			"Elbasan", 0x10500, 0x1052F
		);

		public static readonly UnicodeBlock CaucasianAlbanian = new UnicodeBlock(
			"Caucasian Albanian", 0x10530, 0x1056F
		);

		public static readonly UnicodeBlock LinearA = new UnicodeBlock(
			"Linear A", 0x10600, 0x1077F
		);

		public static readonly UnicodeBlock CypriotSyllabary = new UnicodeBlock(
			"Cypriot Syllabary", 0x10800, 0x1083F
		);

		public static readonly UnicodeBlock ImperialAramaic = new UnicodeBlock(
			"Imperial Aramaic", 0x10840, 0x1085F
		);

		public static readonly UnicodeBlock Palmyrene = new UnicodeBlock(
			"Palmyrene", 0x10860, 0x1087F
		);

		public static readonly UnicodeBlock Nabataean = new UnicodeBlock(
			"Nabataean", 0x10880, 0x108AF
		);

		public static readonly UnicodeBlock Hatran = new UnicodeBlock(
			"Hatran", 0x108E0, 0x108FF
		);

		public static readonly UnicodeBlock Phoenician = new UnicodeBlock(
			"Phoenician", 0x10900, 0x1091F
		);

		public static readonly UnicodeBlock Lydian = new UnicodeBlock(
			"Lydian", 0x10920, 0x1093F
		);

		public static readonly UnicodeBlock MeroiticHieroglyphs = new UnicodeBlock(
			"Meroitic Hieroglyphs", 0x10980, 0x1099F
		);

		public static readonly UnicodeBlock MeroiticCursive = new UnicodeBlock(
			"Meroitic Cursive", 0x109A0, 0x109FF
		);

		public static readonly UnicodeBlock Kharoshthi = new UnicodeBlock(
			"Kharoshthi", 0x10A00, 0x10A5F
		);

		public static readonly UnicodeBlock OldSouthArabian = new UnicodeBlock(
			"Old South Arabian", 0x10A60, 0x10A7F
		);

		public static readonly UnicodeBlock OldNorthArabian = new UnicodeBlock(
			"Old North Arabian", 0x10A80, 0x10A9F
		);

		public static readonly UnicodeBlock Manichaean = new UnicodeBlock(
			"Manichaean", 0x10AC0, 0x10AFF
		);

		public static readonly UnicodeBlock Avestan = new UnicodeBlock(
			"Avestan", 0x10B00, 0x10B3F
		);

		public static readonly UnicodeBlock InscriptionalParthian = new UnicodeBlock(
			"Inscriptional Parthian", 0x10B40, 0x10B5F
		);

		public static readonly UnicodeBlock InscriptionalPahlavi = new UnicodeBlock(
			"Inscriptional Pahlavi", 0x10B60, 0x10B7F
		);

		public static readonly UnicodeBlock PsalterPahlavi = new UnicodeBlock(
			"Psalter Pahlavi", 0x10B80, 0x10BAF
		);

		public static readonly UnicodeBlock OldTurkic = new UnicodeBlock(
			"Old Turkic", 0x10C00, 0x10C4F
		);

		public static readonly UnicodeBlock OldHungarian = new UnicodeBlock(
			"Old Hungarian", 0x10C80, 0x10CFF
		);

		public static readonly UnicodeBlock HanifiRohingya = new UnicodeBlock(
			"Hanifi Rohingya", 0x10D00, 0x10D3F
		);

		public static readonly UnicodeBlock RumiNumeralSymbols = new UnicodeBlock(
			"Rumi Numeral Symbols", 0x10E60, 0x10E7F
		);

		public static readonly UnicodeBlock Yezidi = new UnicodeBlock(
			"Yezidi", 0x10E80, 0x10EBF
		);

		public static readonly UnicodeBlock OldSogdian = new UnicodeBlock(
			"Old Sogdian", 0x10F00, 0x10F2F
		);

		public static readonly UnicodeBlock Sogdian = new UnicodeBlock(
			"Sogdian", 0x10F30, 0x10F6F
		);

		public static readonly UnicodeBlock Chorasmian = new UnicodeBlock(
			"Chorasmian", 0x10FB0, 0x10FDF
		);

		public static readonly UnicodeBlock Elymaic = new UnicodeBlock(
			"Elymaic", 0x10FE0, 0x10FFF
		);

		public static readonly UnicodeBlock Brahmi = new UnicodeBlock(
			"Brahmi", 0x11000, 0x1107F
		);

		public static readonly UnicodeBlock Kaithi = new UnicodeBlock(
			"Kaithi", 0x11080, 0x110CF
		);

		public static readonly UnicodeBlock SoraSompeng = new UnicodeBlock(
			"Sora Sompeng", 0x110D0, 0x110FF
		);

		public static readonly UnicodeBlock Chakma = new UnicodeBlock(
			"Chakma", 0x11100, 0x1114F
		);

		public static readonly UnicodeBlock Mahajani = new UnicodeBlock(
			"Mahajani", 0x11150, 0x1117F
		);

		public static readonly UnicodeBlock Sharada = new UnicodeBlock(
			"Sharada", 0x11180, 0x111DF
		);

		public static readonly UnicodeBlock SinhalaArchaicNumbers = new UnicodeBlock(
			"Sinhala Archaic Numbers", 0x111E0, 0x111FF
		);

		public static readonly UnicodeBlock Khojki = new UnicodeBlock(
			"Khojki", 0x11200, 0x1124F
		);

		public static readonly UnicodeBlock Multani = new UnicodeBlock(
			"Multani", 0x11280, 0x112AF
		);

		public static readonly UnicodeBlock Khudawadi = new UnicodeBlock(
			"Khudawadi", 0x112B0, 0x112FF
		);

		public static readonly UnicodeBlock Grantha = new UnicodeBlock(
			"Grantha", 0x11300, 0x1137F
		);

		public static readonly UnicodeBlock Newa = new UnicodeBlock(
			"Newa", 0x11400, 0x1147F
		);

		public static readonly UnicodeBlock Tirhuta = new UnicodeBlock(
			"Tirhuta", 0x11480, 0x114DF
		);

		public static readonly UnicodeBlock Siddham = new UnicodeBlock(
			"Siddham", 0x11580, 0x115FF
		);

		public static readonly UnicodeBlock Modi = new UnicodeBlock(
			"Modi", 0x11600, 0x1165F
		);

		public static readonly UnicodeBlock MongolianSupplement = new UnicodeBlock(
			"Mongolian Supplement", 0x11660, 0x1167F
		);

		public static readonly UnicodeBlock Takri = new UnicodeBlock(
			"Takri", 0x11680, 0x116CF
		);

		public static readonly UnicodeBlock Ahom = new UnicodeBlock(
			"Ahom", 0x11700, 0x1173F
		);

		public static readonly UnicodeBlock Dogra = new UnicodeBlock(
			"Dogra", 0x11800, 0x1184F
		);

		public static readonly UnicodeBlock WarangCiti = new UnicodeBlock(
			"Warang Citi", 0x118A0, 0x118FF
		);

		public static readonly UnicodeBlock DivesAkuru = new UnicodeBlock(
			"Dives Akuru", 0x11900, 0x1195F
		);

		public static readonly UnicodeBlock Nandinagari = new UnicodeBlock(
			"Nandinagari", 0x119A0, 0x119FF
		);

		public static readonly UnicodeBlock ZanabazarSquare = new UnicodeBlock(
			"Zanabazar Square", 0x11A00, 0x11A4F
		);

		public static readonly UnicodeBlock Soyombo = new UnicodeBlock(
			"Soyombo", 0x11A50, 0x11AAF
		);

		public static readonly UnicodeBlock PauCinHau = new UnicodeBlock(
			"Pau Cin Hau", 0x11AC0, 0x11AFF
		);

		public static readonly UnicodeBlock Bhaiksuki = new UnicodeBlock(
			"Bhaiksuki", 0x11C00, 0x11C6F
		);

		public static readonly UnicodeBlock Marchen = new UnicodeBlock(
			"Marchen", 0x11C70, 0x11CBF
		);

		public static readonly UnicodeBlock MasaramGondi = new UnicodeBlock(
			"Masaram Gondi", 0x11D00, 0x11D5F
		);

		public static readonly UnicodeBlock GunjalaGondi = new UnicodeBlock(
			"Gunjala Gondi", 0x11D60, 0x11DAF
		);

		public static readonly UnicodeBlock Makasar = new UnicodeBlock(
			"Makasar", 0x11EE0, 0x11EFF
		);

		public static readonly UnicodeBlock LisuSupplement = new UnicodeBlock(
			"Lisu Supplement", 0x11FB0, 0x11FBF
		);

		public static readonly UnicodeBlock TamilSupplement = new UnicodeBlock(
			"Tamil Supplement", 0x11FC0, 0x11FFF
		);

		public static readonly UnicodeBlock Cuneiform = new UnicodeBlock(
			"Cuneiform", 0x12000, 0x123FF
		);

		public static readonly UnicodeBlock CuneiformNumbersandPunctuation = new UnicodeBlock(
			"Cuneiform Numbers and Punctuation", 0x12400, 0x1247F
		);

		public static readonly UnicodeBlock EarlyDynasticCuneiform = new UnicodeBlock(
			"Early Dynastic Cuneiform", 0x12480, 0x1254F
		);

		public static readonly UnicodeBlock EgyptianHieroglyphs = new UnicodeBlock(
			"Egyptian Hieroglyphs", 0x13000, 0x1342F
		);

		public static readonly UnicodeBlock EgyptianHieroglyphFormatControls = new UnicodeBlock(
			"Egyptian Hieroglyph Format Controls", 0x13430, 0x1343F
		);

		public static readonly UnicodeBlock AnatolianHieroglyphs = new UnicodeBlock(
			"Anatolian Hieroglyphs", 0x14400, 0x1467F
		);

		public static readonly UnicodeBlock BamumSupplement = new UnicodeBlock(
			"Bamum Supplement", 0x16800, 0x16A3F
		);

		public static readonly UnicodeBlock Mro = new UnicodeBlock(
			"Mro", 0x16A40, 0x16A6F
		);

		public static readonly UnicodeBlock BassaVah = new UnicodeBlock(
			"Bassa Vah", 0x16AD0, 0x16AFF
		);

		public static readonly UnicodeBlock PahawhHmong = new UnicodeBlock(
			"Pahawh Hmong", 0x16B00, 0x16B8F
		);

		public static readonly UnicodeBlock Medefaidrin = new UnicodeBlock(
			"Medefaidrin", 0x16E40, 0x16E9F
		);

		public static readonly UnicodeBlock Miao = new UnicodeBlock(
			"Miao", 0x16F00, 0x16F9F
		);

		public static readonly UnicodeBlock IdeographicSymbolsandPunctuation = new UnicodeBlock(
			"Ideographic Symbols and Punctuation", 0x16FE0, 0x16FFF
		);

		public static readonly UnicodeBlock Tangut = new UnicodeBlock(
			"Tangut", 0x17000, 0x187FF
		);

		public static readonly UnicodeBlock TangutComponents = new UnicodeBlock(
			"Tangut Components", 0x18800, 0x18AFF
		);

		public static readonly UnicodeBlock KhitanSmallScript = new UnicodeBlock(
			"Khitan Small Script", 0x18B00, 0x18CFF
		);

		public static readonly UnicodeBlock TangutSupplement = new UnicodeBlock(
			"Tangut Supplement", 0x18D00, 0x18D8F
		);

		public static readonly UnicodeBlock KanaSupplement = new UnicodeBlock(
			"Kana Supplement", 0x1B000, 0x1B0FF
		);

		public static readonly UnicodeBlock KanaExtendedA = new UnicodeBlock(
			"Kana Extended-A", 0x1B100, 0x1B12F
		);

		public static readonly UnicodeBlock SmallKanaExtension = new UnicodeBlock(
			"Small Kana Extension", 0x1B130, 0x1B16F
		);

		public static readonly UnicodeBlock Nushu = new UnicodeBlock(
			"Nushu", 0x1B170, 0x1B2FF
		);

		public static readonly UnicodeBlock Duployan = new UnicodeBlock(
			"Duployan", 0x1BC00, 0x1BC9F
		);

		public static readonly UnicodeBlock ShorthandFormatControls = new UnicodeBlock(
			"Shorthand Format Controls", 0x1BCA0, 0x1BCAF
		);

		public static readonly UnicodeBlock ByzantineMusicalSymbols = new UnicodeBlock(
			"Byzantine Musical Symbols", 0x1D000, 0x1D0FF
		);

		public static readonly UnicodeBlock MusicalSymbols = new UnicodeBlock(
			"Musical Symbols", 0x1D100, 0x1D1FF
		);

		public static readonly UnicodeBlock AncientGreekMusicalNotation = new UnicodeBlock(
			"Ancient Greek Musical Notation", 0x1D200, 0x1D24F
		);

		public static readonly UnicodeBlock MayanNumerals = new UnicodeBlock(
			"Mayan Numerals", 0x1D2E0, 0x1D2FF
		);

		public static readonly UnicodeBlock TaiXuanJingSymbols = new UnicodeBlock(
			"Tai Xuan Jing Symbols", 0x1D300, 0x1D35F
		);

		public static readonly UnicodeBlock CountingRodNumerals = new UnicodeBlock(
			"Counting Rod Numerals", 0x1D360, 0x1D37F
		);

		public static readonly UnicodeBlock MathematicalAlphanumericSymbols = new UnicodeBlock(
			"Mathematical Alphanumeric Symbols", 0x1D400, 0x1D7FF
		);

		public static readonly UnicodeBlock SuttonSignWriting = new UnicodeBlock(
			"Sutton SignWriting", 0x1D800, 0x1DAAF
		);

		public static readonly UnicodeBlock GlagoliticSupplement = new UnicodeBlock(
			"Glagolitic Supplement", 0x1E000, 0x1E02F
		);

		public static readonly UnicodeBlock NyiakengPuachueHmong = new UnicodeBlock(
			"Nyiakeng Puachue Hmong", 0x1E100, 0x1E14F
		);

		public static readonly UnicodeBlock Wancho = new UnicodeBlock(
			"Wancho", 0x1E2C0, 0x1E2FF
		);

		public static readonly UnicodeBlock MendeKikakui = new UnicodeBlock(
			"Mende Kikakui", 0x1E800, 0x1E8DF
		);

		public static readonly UnicodeBlock Adlam = new UnicodeBlock(
			"Adlam", 0x1E900, 0x1E95F
		);

		public static readonly UnicodeBlock IndicSiyaqNumbers = new UnicodeBlock(
			"Indic Siyaq Numbers", 0x1EC70, 0x1ECBF
		);

		public static readonly UnicodeBlock OttomanSiyaqNumbers = new UnicodeBlock(
			"Ottoman Siyaq Numbers", 0x1ED00, 0x1ED4F
		);

		public static readonly UnicodeBlock ArabicMathematicalAlphabeticSymbols = new UnicodeBlock(
			"Arabic Mathematical Alphabetic Symbols", 0x1EE00, 0x1EEFF
		);

		public static readonly UnicodeBlock MahjongTiles = new UnicodeBlock(
			"Mahjong Tiles", 0x1F000, 0x1F02F
		);

		public static readonly UnicodeBlock DominoTiles = new UnicodeBlock(
			"Domino Tiles", 0x1F030, 0x1F09F
		);

		public static readonly UnicodeBlock PlayingCards = new UnicodeBlock(
			"Playing Cards", 0x1F0A0, 0x1F0FF
		);

		public static readonly UnicodeBlock EnclosedAlphanumericSupplement = new UnicodeBlock(
			"Enclosed Alphanumeric Supplement", 0x1F100, 0x1F1FF
		);

		public static readonly UnicodeBlock EnclosedIdeographicSupplement = new UnicodeBlock(
			"Enclosed Ideographic Supplement", 0x1F200, 0x1F2FF
		);

		public static readonly UnicodeBlock MiscellaneousSymbolsandPictographs = new UnicodeBlock(
			"Miscellaneous Symbols and Pictographs", 0x1F300, 0x1F5FF
		);

		public static readonly UnicodeBlock Emoticons = new UnicodeBlock(
			"Emoticons", 0x1F600, 0x1F64F
		);

		public static readonly UnicodeBlock OrnamentalDingbats = new UnicodeBlock(
			"Ornamental Dingbats", 0x1F650, 0x1F67F
		);

		public static readonly UnicodeBlock TransportandMapSymbols = new UnicodeBlock(
			"Transport and Map Symbols", 0x1F680, 0x1F6FF
		);

		public static readonly UnicodeBlock AlchemicalSymbols = new UnicodeBlock(
			"Alchemical Symbols", 0x1F700, 0x1F77F
		);

		public static readonly UnicodeBlock GeometricShapesExtended = new UnicodeBlock(
			"Geometric Shapes Extended", 0x1F780, 0x1F7FF
		);

		public static readonly UnicodeBlock SupplementalArrowsC = new UnicodeBlock(
			"Supplemental Arrows-C", 0x1F800, 0x1F8FF
		);

		public static readonly UnicodeBlock SupplementalSymbolsandPictographs = new UnicodeBlock(
			"Supplemental Symbols and Pictographs", 0x1F900, 0x1F9FF
		);

		public static readonly UnicodeBlock ChessSymbols = new UnicodeBlock(
			"Chess Symbols", 0x1FA00, 0x1FA6F
		);

		public static readonly UnicodeBlock SymbolsandPictographsExtendedA = new UnicodeBlock(
			"Symbols and Pictographs Extended-A", 0x1FA70, 0x1FAFF
		);

		public static readonly UnicodeBlock SymbolsforLegacyComputing = new UnicodeBlock(
			"Symbols for Legacy Computing", 0x1FB00, 0x1FBFF
		);

		public static readonly UnicodeBlock CJKUnifiedIdeographsExtensionB = new UnicodeBlock(
			"CJK Unified Ideographs Extension B", 0x20000, 0x2A6DF
		);

		public static readonly UnicodeBlock CJKUnifiedIdeographsExtensionC = new UnicodeBlock(
			"CJK Unified Ideographs Extension C", 0x2A700, 0x2B73F
		);

		public static readonly UnicodeBlock CJKUnifiedIdeographsExtensionD = new UnicodeBlock(
			"CJK Unified Ideographs Extension D", 0x2B740, 0x2B81F
		);

		public static readonly UnicodeBlock CJKUnifiedIdeographsExtensionE = new UnicodeBlock(
			"CJK Unified Ideographs Extension E", 0x2B820, 0x2CEAF
		);

		public static readonly UnicodeBlock CJKUnifiedIdeographsExtensionF = new UnicodeBlock(
			"CJK Unified Ideographs Extension F", 0x2CEB0, 0x2EBEF
		);

		public static readonly UnicodeBlock CJKCompatibilityIdeographsSupplement = new UnicodeBlock(
			"CJK Compatibility Ideographs Supplement", 0x2F800, 0x2FA1F
		);

		public static readonly UnicodeBlock CJKUnifiedIdeographsExtensionG = new UnicodeBlock(
			"CJK Unified Ideographs Extension G", 0x30000, 0x3134F
		);

		public static readonly UnicodeBlock Tags = new UnicodeBlock(
			"Tags", 0xE0000, 0xE007F
		);

		public static readonly UnicodeBlock VariationSelectorsSupplement = new UnicodeBlock(
			"Variation Selectors Supplement", 0xE0100, 0xE01EF
		);

		public static readonly UnicodeBlock SupplementaryPrivateUseAreaA = new UnicodeBlock(
			"Supplementary Private Use Area-A", 0xF0000, 0xFFFFF
		);

		public static readonly UnicodeBlock SupplementaryPrivateUseAreaB = new UnicodeBlock(
			"Supplementary Private Use Area-B", 0x100000, 0x10FFFF
		);

		static readonly UnicodeBlock[] Blocks = new UnicodeBlock[] {
			BasicLatin,
			Latin1Supplement,
			LatinExtendedA,
			LatinExtendedB,
			IPAExtensions,
			SpacingModifierLetters,
			CombiningDiacriticalMarks,
			GreekandCoptic,
			Cyrillic,
			CyrillicSupplement,
			Armenian,
			Hebrew,
			Arabic,
			Syriac,
			ArabicSupplement,
			Thaana,
			NKo,
			Samaritan,
			Mandaic,
			SyriacSupplement,
			ArabicExtendedA,
			Devanagari,
			Bengali,
			Gurmukhi,
			Gujarati,
			Oriya,
			Tamil,
			Telugu,
			Kannada,
			Malayalam,
			Sinhala,
			Thai,
			Lao,
			Tibetan,
			Myanmar,
			Georgian,
			HangulJamo,
			Ethiopic,
			EthiopicSupplement,
			Cherokee,
			UnifiedCanadianAboriginalSyllabics,
			Ogham,
			Runic,
			Tagalog,
			Hanunoo,
			Buhid,
			Tagbanwa,
			Khmer,
			Mongolian,
			UnifiedCanadianAboriginalSyllabicsExtended,
			Limbu,
			TaiLe,
			NewTaiLue,
			KhmerSymbols,
			Buginese,
			TaiTham,
			CombiningDiacriticalMarksExtended,
			Balinese,
			Sundanese,
			Batak,
			Lepcha,
			OlChiki,
			CyrillicExtendedC,
			GeorgianExtended,
			SundaneseSupplement,
			VedicExtensions,
			PhoneticExtensions,
			PhoneticExtensionsSupplement,
			CombiningDiacriticalMarksSupplement,
			LatinExtendedAdditional,
			GreekExtended,
			GeneralPunctuation,
			SuperscriptsandSubscripts,
			CurrencySymbols,
			CombiningDiacriticalMarksforSymbols,
			LetterlikeSymbols,
			NumberForms,
			Arrows,
			MathematicalOperators,
			MiscellaneousTechnical,
			ControlPictures,
			OpticalCharacterRecognition,
			EnclosedAlphanumerics,
			BoxDrawing,
			BlockElements,
			GeometricShapes,
			MiscellaneousSymbols,
			Dingbats,
			MiscellaneousMathematicalSymbolsA,
			SupplementalArrowsA,
			BraillePatterns,
			SupplementalArrowsB,
			MiscellaneousMathematicalSymbolsB,
			SupplementalMathematicalOperators,
			MiscellaneousSymbolsandArrows,
			Glagolitic,
			LatinExtendedC,
			Coptic,
			GeorgianSupplement,
			Tifinagh,
			EthiopicExtended,
			CyrillicExtendedA,
			SupplementalPunctuation,
			CJKRadicalsSupplement,
			KangxiRadicals,
			IdeographicDescriptionCharacters,
			CJKSymbolsandPunctuation,
			Hiragana,
			Katakana,
			Bopomofo,
			HangulCompatibilityJamo,
			Kanbun,
			BopomofoExtended,
			CJKStrokes,
			KatakanaPhoneticExtensions,
			EnclosedCJKLettersandMonths,
			CJKCompatibility,
			CJKUnifiedIdeographsExtensionA,
			YijingHexagramSymbols,
			CJKUnifiedIdeographs,
			YiSyllables,
			YiRadicals,
			Lisu,
			Vai,
			CyrillicExtendedB,
			Bamum,
			ModifierToneLetters,
			LatinExtendedD,
			SylotiNagri,
			CommonIndicNumberForms,
			Phagspa,
			Saurashtra,
			DevanagariExtended,
			KayahLi,
			Rejang,
			HangulJamoExtendedA,
			Javanese,
			MyanmarExtendedB,
			Cham,
			MyanmarExtendedA,
			TaiViet,
			MeeteiMayekExtensions,
			EthiopicExtendedA,
			LatinExtendedE,
			CherokeeSupplement,
			MeeteiMayek,
			HangulSyllables,
			HangulJamoExtendedB,
			HighSurrogates,
			HighPrivateUseSurrogates,
			LowSurrogates,
			PrivateUseArea,
			CJKCompatibilityIdeographs,
			AlphabeticPresentationForms,
			ArabicPresentationFormsA,
			VariationSelectors,
			VerticalForms,
			CombiningHalfMarks,
			CJKCompatibilityForms,
			SmallFormVariants,
			ArabicPresentationFormsB,
			HalfwidthandFullwidthForms,
			Specials,
			LinearBSyllabary,
			LinearBIdeograms,
			AegeanNumbers,
			AncientGreekNumbers,
			AncientSymbols,
			PhaistosDisc,
			Lycian,
			Carian,
			CopticEpactNumbers,
			OldItalic,
			Gothic,
			OldPermic,
			Ugaritic,
			OldPersian,
			Deseret,
			Shavian,
			Osmanya,
			Osage,
			Elbasan,
			CaucasianAlbanian,
			LinearA,
			CypriotSyllabary,
			ImperialAramaic,
			Palmyrene,
			Nabataean,
			Hatran,
			Phoenician,
			Lydian,
			MeroiticHieroglyphs,
			MeroiticCursive,
			Kharoshthi,
			OldSouthArabian,
			OldNorthArabian,
			Manichaean,
			Avestan,
			InscriptionalParthian,
			InscriptionalPahlavi,
			PsalterPahlavi,
			OldTurkic,
			OldHungarian,
			HanifiRohingya,
			RumiNumeralSymbols,
			Yezidi,
			OldSogdian,
			Sogdian,
			Chorasmian,
			Elymaic,
			Brahmi,
			Kaithi,
			SoraSompeng,
			Chakma,
			Mahajani,
			Sharada,
			SinhalaArchaicNumbers,
			Khojki,
			Multani,
			Khudawadi,
			Grantha,
			Newa,
			Tirhuta,
			Siddham,
			Modi,
			MongolianSupplement,
			Takri,
			Ahom,
			Dogra,
			WarangCiti,
			DivesAkuru,
			Nandinagari,
			ZanabazarSquare,
			Soyombo,
			PauCinHau,
			Bhaiksuki,
			Marchen,
			MasaramGondi,
			GunjalaGondi,
			Makasar,
			LisuSupplement,
			TamilSupplement,
			Cuneiform,
			CuneiformNumbersandPunctuation,
			EarlyDynasticCuneiform,
			EgyptianHieroglyphs,
			EgyptianHieroglyphFormatControls,
			AnatolianHieroglyphs,
			BamumSupplement,
			Mro,
			BassaVah,
			PahawhHmong,
			Medefaidrin,
			Miao,
			IdeographicSymbolsandPunctuation,
			Tangut,
			TangutComponents,
			KhitanSmallScript,
			TangutSupplement,
			KanaSupplement,
			KanaExtendedA,
			SmallKanaExtension,
			Nushu,
			Duployan,
			ShorthandFormatControls,
			ByzantineMusicalSymbols,
			MusicalSymbols,
			AncientGreekMusicalNotation,
			MayanNumerals,
			TaiXuanJingSymbols,
			CountingRodNumerals,
			MathematicalAlphanumericSymbols,
			SuttonSignWriting,
			GlagoliticSupplement,
			NyiakengPuachueHmong,
			Wancho,
			MendeKikakui,
			Adlam,
			IndicSiyaqNumbers,
			OttomanSiyaqNumbers,
			ArabicMathematicalAlphabeticSymbols,
			MahjongTiles,
			DominoTiles,
			PlayingCards,
			EnclosedAlphanumericSupplement,
			EnclosedIdeographicSupplement,
			MiscellaneousSymbolsandPictographs,
			Emoticons,
			OrnamentalDingbats,
			TransportandMapSymbols,
			AlchemicalSymbols,
			GeometricShapesExtended,
			SupplementalArrowsC,
			SupplementalSymbolsandPictographs,
			ChessSymbols,
			SymbolsandPictographsExtendedA,
			SymbolsforLegacyComputing,
			CJKUnifiedIdeographsExtensionB,
			CJKUnifiedIdeographsExtensionC,
			CJKUnifiedIdeographsExtensionD,
			CJKUnifiedIdeographsExtensionE,
			CJKUnifiedIdeographsExtensionF,
			CJKCompatibilityIdeographsSupplement,
			CJKUnifiedIdeographsExtensionG,
			Tags,
			VariationSelectorsSupplement,
			SupplementaryPrivateUseAreaA,
			SupplementaryPrivateUseAreaB
		};

		public readonly string Name;
		public readonly int StartCodePoint;
		public readonly int EndCodePoint;

		public UnicodeBlock(string name, int startCodePoint, int endCodePoint) {
			Name = name;
			StartCodePoint = startCodePoint;
			EndCodePoint = endCodePoint;
		}

		public static bool operator ==(UnicodeBlock a, UnicodeBlock b) {
			if (a is null) {
				return b is null;
			}
			return a.Equals(b);
		}

		public static bool operator !=(UnicodeBlock a, UnicodeBlock b) {
			if (a is null) {
				return b is null;
			}
			return !a.Equals(b);
		}

		public static UnicodeBlock FromCodePoint(char codePoint) {
			foreach (UnicodeBlock block in Blocks) {
				if (block.Contains(codePoint)) {
					return block;
				}
			}
			return No_Block;
		}

		public static UnicodeBlock FromCodePoint(int codePoint) {
			if (codePoint < 0 || codePoint > UnicodeCodePoint.Max) {
				return null;
			}
			foreach (UnicodeBlock block in Blocks) {
				if (block.Contains(codePoint)) {
					return block;
				}
			}
			return No_Block;
		}

		public bool Contains(char codePoint) {
			return codePoint >= StartCodePoint && codePoint <= EndCodePoint;
		}

		public bool Contains(int codePoint) {
			if (codePoint < 0 || codePoint > UnicodeCodePoint.Max) {
				return false;
			}
			return codePoint >= StartCodePoint && codePoint <= EndCodePoint;
		}

		public override bool Equals(object obj) {
			if (obj is UnicodeBlock == false) {
				return false;
			}
			UnicodeBlock block = (UnicodeBlock)obj;
			return StartCodePoint == block.StartCodePoint &&
					EndCodePoint == block.EndCodePoint &&
					Name == block.Name;
		}

		public override int GetHashCode() {
			int hash = 17;
			hash = hash * 31 + StartCodePoint.GetHashCode();
			hash = hash * 31 + EndCodePoint.GetHashCode();
			hash = hash * 31 + Name.GetHashCode();
			return hash;
		}

		public override string ToString() {
			return string.Format(
				"{0:X4}..{1:X4}; {2}",
				StartCodePoint,
				EndCodePoint,
				Name
			);
		}
	}
}
