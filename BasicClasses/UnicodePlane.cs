namespace BasicClasses {
	public static class UnicodePlane {
		public const string BasicMultilingualPlane = "Basic Multilingual Plane";
		public const string SupplementaryMultilingualPlane = "Supplementary Multilingual Plane";
		public const string SupplementaryIdeographicPlane = "Supplementary Ideographic Plane";
		public const string TertiaryIdeographicPlane = "Tertiary Ideographic Plane";
		public const string SupplementarySpecialPurposePlane = "Supplementary Special-purpose Plane";
		public const string SupplementaryPrivateUseAreaPlanes = "Supplementary Private Use Area planes";
		public const string Unassigned = "unassigned";

		public const string BMP = BasicMultilingualPlane;
		public const string SMP = SupplementaryMultilingualPlane;
		public const string SIP = SupplementaryIdeographicPlane;
		public const string TIP = TertiaryIdeographicPlane;
		public const string SSP = SupplementarySpecialPurposePlane;
		public const string PUA = SupplementaryPrivateUseAreaPlanes;

		public static bool Contains(string planeName) {
			if (string.IsNullOrEmpty(planeName)) {
				return false;
			}
			switch (planeName) {
				case BasicMultilingualPlane:
				case SupplementaryMultilingualPlane:
				case SupplementaryIdeographicPlane:
				case TertiaryIdeographicPlane:
				case SupplementarySpecialPurposePlane:
				case SupplementaryPrivateUseAreaPlanes:
					return true;
			}
			return false;
		}

		public static bool IsIncludedIn(string planeName, int codePoint) {
			if (string.IsNullOrEmpty(planeName)) {
				return false;
			}
			if (codePoint < 0 || codePoint > UnicodeCodePoint.Max) {
				return false;
			}
			switch (planeName) {
				case BasicMultilingualPlane:
					return codePoint < 0x10000;
				case SupplementaryMultilingualPlane:
					return codePoint >= 0x10000 && codePoint < 0x20000;
				case SupplementaryIdeographicPlane:
					return codePoint >= 0x20000 && codePoint < 0x30000;
				case TertiaryIdeographicPlane:
					return codePoint >= 0x30000 && codePoint < 0x40000;
				case Unassigned:
					return codePoint >= 0x40000 && codePoint < 0xE0000;
				case SupplementarySpecialPurposePlane:
					return codePoint >= 0xE0000 && codePoint < 0xF0000;
				case SupplementaryPrivateUseAreaPlanes:
					return codePoint >= 0xF0000;
			}
			return false;
		}

		public static bool IsIncludedIn(string planeName, string blockName) {
			if (string.IsNullOrEmpty(planeName)) {
				return false;
			}
			if (string.IsNullOrEmpty(blockName)) {
				return false;
			}
			switch (planeName) {
				case BasicMultilingualPlane:
					switch (blockName) {
						case UnicodeBlock.BasicLatin:
						case UnicodeBlock.Latin1Supplement:
						case UnicodeBlock.LatinExtendedA:
						case UnicodeBlock.LatinExtendedB:
						case UnicodeBlock.IPAExtensions:
						case UnicodeBlock.SpacingModifierLetters:
						case UnicodeBlock.CombiningDiacriticalMarks:
						case UnicodeBlock.GreekandCoptic:
						case UnicodeBlock.Cyrillic:
						case UnicodeBlock.CyrillicSupplement:
						case UnicodeBlock.Armenian:
						case UnicodeBlock.Hebrew:
						case UnicodeBlock.Arabic:
						case UnicodeBlock.Syriac:
						case UnicodeBlock.ArabicSupplement:
						case UnicodeBlock.Thaana:
						case UnicodeBlock.NKo:
						case UnicodeBlock.Samaritan:
						case UnicodeBlock.Mandaic:
						case UnicodeBlock.SyriacSupplement:
						case UnicodeBlock.ArabicExtendedA:
						case UnicodeBlock.Devanagari:
						case UnicodeBlock.Bengali:
						case UnicodeBlock.Gurmukhi:
						case UnicodeBlock.Gujarati:
						case UnicodeBlock.Oriya:
						case UnicodeBlock.Tamil:
						case UnicodeBlock.Telugu:
						case UnicodeBlock.Kannada:
						case UnicodeBlock.Malayalam:
						case UnicodeBlock.Sinhala:
						case UnicodeBlock.Thai:
						case UnicodeBlock.Lao:
						case UnicodeBlock.Tibetan:
						case UnicodeBlock.Myanmar:
						case UnicodeBlock.Georgian:
						case UnicodeBlock.HangulJamo:
						case UnicodeBlock.Ethiopic:
						case UnicodeBlock.EthiopicSupplement:
						case UnicodeBlock.Cherokee:
						case UnicodeBlock.UnifiedCanadianAboriginalSyllabics:
						case UnicodeBlock.Ogham:
						case UnicodeBlock.Runic:
						case UnicodeBlock.Tagalog:
						case UnicodeBlock.Hanunoo:
						case UnicodeBlock.Buhid:
						case UnicodeBlock.Tagbanwa:
						case UnicodeBlock.Khmer:
						case UnicodeBlock.Mongolian:
						case UnicodeBlock.UnifiedCanadianAboriginalSyllabicsExtended:
						case UnicodeBlock.Limbu:
						case UnicodeBlock.TaiLe:
						case UnicodeBlock.NewTaiLue:
						case UnicodeBlock.KhmerSymbols:
						case UnicodeBlock.Buginese:
						case UnicodeBlock.TaiTham:
						case UnicodeBlock.CombiningDiacriticalMarksExtended:
						case UnicodeBlock.Balinese:
						case UnicodeBlock.Sundanese:
						case UnicodeBlock.Batak:
						case UnicodeBlock.Lepcha:
						case UnicodeBlock.OlChiki:
						case UnicodeBlock.CyrillicExtendedC:
						case UnicodeBlock.GeorgianExtended:
						case UnicodeBlock.SundaneseSupplement:
						case UnicodeBlock.VedicExtensions:
						case UnicodeBlock.PhoneticExtensions:
						case UnicodeBlock.PhoneticExtensionsSupplement:
						case UnicodeBlock.CombiningDiacriticalMarksSupplement:
						case UnicodeBlock.LatinExtendedAdditional:
						case UnicodeBlock.GreekExtended:
						case UnicodeBlock.GeneralPunctuation:
						case UnicodeBlock.SuperscriptsandSubscripts:
						case UnicodeBlock.CurrencySymbols:
						case UnicodeBlock.CombiningDiacriticalMarksforSymbols:
						case UnicodeBlock.LetterlikeSymbols:
						case UnicodeBlock.NumberForms:
						case UnicodeBlock.Arrows:
						case UnicodeBlock.MathematicalOperators:
						case UnicodeBlock.MiscellaneousTechnical:
						case UnicodeBlock.ControlPictures:
						case UnicodeBlock.OpticalCharacterRecognition:
						case UnicodeBlock.EnclosedAlphanumerics:
						case UnicodeBlock.BoxDrawing:
						case UnicodeBlock.BlockElements:
						case UnicodeBlock.GeometricShapes:
						case UnicodeBlock.MiscellaneousSymbols:
						case UnicodeBlock.Dingbats:
						case UnicodeBlock.MiscellaneousMathematicalSymbolsA:
						case UnicodeBlock.SupplementalArrowsA:
						case UnicodeBlock.BraillePatterns:
						case UnicodeBlock.SupplementalArrowsB:
						case UnicodeBlock.MiscellaneousMathematicalSymbolsB:
						case UnicodeBlock.SupplementalMathematicalOperators:
						case UnicodeBlock.MiscellaneousSymbolsandArrows:
						case UnicodeBlock.Glagolitic:
						case UnicodeBlock.LatinExtendedC:
						case UnicodeBlock.Coptic:
						case UnicodeBlock.GeorgianSupplement:
						case UnicodeBlock.Tifinagh:
						case UnicodeBlock.EthiopicExtended:
						case UnicodeBlock.CyrillicExtendedA:
						case UnicodeBlock.SupplementalPunctuation:
						case UnicodeBlock.CJKRadicalsSupplement:
						case UnicodeBlock.KangxiRadicals:
						case UnicodeBlock.IdeographicDescriptionCharacters:
						case UnicodeBlock.CJKSymbolsandPunctuation:
						case UnicodeBlock.Hiragana:
						case UnicodeBlock.Katakana:
						case UnicodeBlock.Bopomofo:
						case UnicodeBlock.HangulCompatibilityJamo:
						case UnicodeBlock.Kanbun:
						case UnicodeBlock.BopomofoExtended:
						case UnicodeBlock.CJKStrokes:
						case UnicodeBlock.KatakanaPhoneticExtensions:
						case UnicodeBlock.EnclosedCJKLettersandMonths:
						case UnicodeBlock.CJKCompatibility:
						case UnicodeBlock.CJKUnifiedIdeographsExtensionA:
						case UnicodeBlock.YijingHexagramSymbols:
						case UnicodeBlock.CJKUnifiedIdeographs:
						case UnicodeBlock.YiSyllables:
						case UnicodeBlock.YiRadicals:
						case UnicodeBlock.Lisu:
						case UnicodeBlock.Vai:
						case UnicodeBlock.CyrillicExtendedB:
						case UnicodeBlock.Bamum:
						case UnicodeBlock.ModifierToneLetters:
						case UnicodeBlock.LatinExtendedD:
						case UnicodeBlock.SylotiNagri:
						case UnicodeBlock.CommonIndicNumberForms:
						case UnicodeBlock.Phagspa:
						case UnicodeBlock.Saurashtra:
						case UnicodeBlock.DevanagariExtended:
						case UnicodeBlock.KayahLi:
						case UnicodeBlock.Rejang:
						case UnicodeBlock.HangulJamoExtendedA:
						case UnicodeBlock.Javanese:
						case UnicodeBlock.MyanmarExtendedB:
						case UnicodeBlock.Cham:
						case UnicodeBlock.MyanmarExtendedA:
						case UnicodeBlock.TaiViet:
						case UnicodeBlock.MeeteiMayekExtensions:
						case UnicodeBlock.EthiopicExtendedA:
						case UnicodeBlock.LatinExtendedE:
						case UnicodeBlock.CherokeeSupplement:
						case UnicodeBlock.MeeteiMayek:
						case UnicodeBlock.HangulSyllables:
						case UnicodeBlock.HangulJamoExtendedB:
						case UnicodeBlock.HighSurrogates:
						case UnicodeBlock.HighPrivateUseSurrogates:
						case UnicodeBlock.LowSurrogates:
						case UnicodeBlock.PrivateUseArea:
						case UnicodeBlock.CJKCompatibilityIdeographs:
						case UnicodeBlock.AlphabeticPresentationForms:
						case UnicodeBlock.ArabicPresentationFormsA:
						case UnicodeBlock.VariationSelectors:
						case UnicodeBlock.VerticalForms:
						case UnicodeBlock.CombiningHalfMarks:
						case UnicodeBlock.CJKCompatibilityForms:
						case UnicodeBlock.SmallFormVariants:
						case UnicodeBlock.ArabicPresentationFormsB:
						case UnicodeBlock.HalfwidthandFullwidthForms:
						case UnicodeBlock.Specials:
							return true;
					}
					break;
				case SupplementaryMultilingualPlane:
					switch (blockName) {
						case UnicodeBlock.LinearBSyllabary:
						case UnicodeBlock.LinearBIdeograms:
						case UnicodeBlock.AegeanNumbers:
						case UnicodeBlock.AncientGreekNumbers:
						case UnicodeBlock.AncientSymbols:
						case UnicodeBlock.PhaistosDisc:
						case UnicodeBlock.Lycian:
						case UnicodeBlock.Carian:
						case UnicodeBlock.CopticEpactNumbers:
						case UnicodeBlock.OldItalic:
						case UnicodeBlock.Gothic:
						case UnicodeBlock.OldPermic:
						case UnicodeBlock.Ugaritic:
						case UnicodeBlock.OldPersian:
						case UnicodeBlock.Deseret:
						case UnicodeBlock.Shavian:
						case UnicodeBlock.Osmanya:
						case UnicodeBlock.Osage:
						case UnicodeBlock.Elbasan:
						case UnicodeBlock.CaucasianAlbanian:
						case UnicodeBlock.LinearA:
						case UnicodeBlock.CypriotSyllabary:
						case UnicodeBlock.ImperialAramaic:
						case UnicodeBlock.Palmyrene:
						case UnicodeBlock.Nabataean:
						case UnicodeBlock.Hatran:
						case UnicodeBlock.Phoenician:
						case UnicodeBlock.Lydian:
						case UnicodeBlock.MeroiticHieroglyphs:
						case UnicodeBlock.MeroiticCursive:
						case UnicodeBlock.Kharoshthi:
						case UnicodeBlock.OldSouthArabian:
						case UnicodeBlock.OldNorthArabian:
						case UnicodeBlock.Manichaean:
						case UnicodeBlock.Avestan:
						case UnicodeBlock.InscriptionalParthian:
						case UnicodeBlock.InscriptionalPahlavi:
						case UnicodeBlock.PsalterPahlavi:
						case UnicodeBlock.OldTurkic:
						case UnicodeBlock.OldHungarian:
						case UnicodeBlock.HanifiRohingya:
						case UnicodeBlock.RumiNumeralSymbols:
						case UnicodeBlock.Yezidi:
						case UnicodeBlock.OldSogdian:
						case UnicodeBlock.Sogdian:
						case UnicodeBlock.Chorasmian:
						case UnicodeBlock.Elymaic:
						case UnicodeBlock.Brahmi:
						case UnicodeBlock.Kaithi:
						case UnicodeBlock.SoraSompeng:
						case UnicodeBlock.Chakma:
						case UnicodeBlock.Mahajani:
						case UnicodeBlock.Sharada:
						case UnicodeBlock.SinhalaArchaicNumbers:
						case UnicodeBlock.Khojki:
						case UnicodeBlock.Multani:
						case UnicodeBlock.Khudawadi:
						case UnicodeBlock.Grantha:
						case UnicodeBlock.Newa:
						case UnicodeBlock.Tirhuta:
						case UnicodeBlock.Siddham:
						case UnicodeBlock.Modi:
						case UnicodeBlock.MongolianSupplement:
						case UnicodeBlock.Takri:
						case UnicodeBlock.Ahom:
						case UnicodeBlock.Dogra:
						case UnicodeBlock.WarangCiti:
						case UnicodeBlock.DivesAkuru:
						case UnicodeBlock.Nandinagari:
						case UnicodeBlock.ZanabazarSquare:
						case UnicodeBlock.Soyombo:
						case UnicodeBlock.PauCinHau:
						case UnicodeBlock.Bhaiksuki:
						case UnicodeBlock.Marchen:
						case UnicodeBlock.MasaramGondi:
						case UnicodeBlock.GunjalaGondi:
						case UnicodeBlock.Makasar:
						case UnicodeBlock.LisuSupplement:
						case UnicodeBlock.TamilSupplement:
						case UnicodeBlock.Cuneiform:
						case UnicodeBlock.CuneiformNumbersandPunctuation:
						case UnicodeBlock.EarlyDynasticCuneiform:
						case UnicodeBlock.EgyptianHieroglyphs:
						case UnicodeBlock.EgyptianHieroglyphFormatControls:
						case UnicodeBlock.AnatolianHieroglyphs:
						case UnicodeBlock.BamumSupplement:
						case UnicodeBlock.Mro:
						case UnicodeBlock.BassaVah:
						case UnicodeBlock.PahawhHmong:
						case UnicodeBlock.Medefaidrin:
						case UnicodeBlock.Miao:
						case UnicodeBlock.IdeographicSymbolsandPunctuation:
						case UnicodeBlock.Tangut:
						case UnicodeBlock.TangutComponents:
						case UnicodeBlock.KhitanSmallScript:
						case UnicodeBlock.TangutSupplement:
						case UnicodeBlock.KanaSupplement:
						case UnicodeBlock.KanaExtendedA:
						case UnicodeBlock.SmallKanaExtension:
						case UnicodeBlock.Nushu:
						case UnicodeBlock.Duployan:
						case UnicodeBlock.ShorthandFormatControls:
						case UnicodeBlock.ByzantineMusicalSymbols:
						case UnicodeBlock.MusicalSymbols:
						case UnicodeBlock.AncientGreekMusicalNotation:
						case UnicodeBlock.MayanNumerals:
						case UnicodeBlock.TaiXuanJingSymbols:
						case UnicodeBlock.CountingRodNumerals:
						case UnicodeBlock.MathematicalAlphanumericSymbols:
						case UnicodeBlock.SuttonSignWriting:
						case UnicodeBlock.GlagoliticSupplement:
						case UnicodeBlock.NyiakengPuachueHmong:
						case UnicodeBlock.Wancho:
						case UnicodeBlock.MendeKikakui:
						case UnicodeBlock.Adlam:
						case UnicodeBlock.IndicSiyaqNumbers:
						case UnicodeBlock.OttomanSiyaqNumbers:
						case UnicodeBlock.ArabicMathematicalAlphabeticSymbols:
						case UnicodeBlock.MahjongTiles:
						case UnicodeBlock.DominoTiles:
						case UnicodeBlock.PlayingCards:
						case UnicodeBlock.EnclosedAlphanumericSupplement:
						case UnicodeBlock.EnclosedIdeographicSupplement:
						case UnicodeBlock.MiscellaneousSymbolsandPictographs:
						case UnicodeBlock.Emoticons:
						case UnicodeBlock.OrnamentalDingbats:
						case UnicodeBlock.TransportandMapSymbols:
						case UnicodeBlock.AlchemicalSymbols:
						case UnicodeBlock.GeometricShapesExtended:
						case UnicodeBlock.SupplementalArrowsC:
						case UnicodeBlock.SupplementalSymbolsandPictographs:
						case UnicodeBlock.ChessSymbols:
						case UnicodeBlock.SymbolsandPictographsExtendedA:
						case UnicodeBlock.SymbolsforLegacyComputing:
							return true;
					}
					break;
				case SupplementaryIdeographicPlane:
					switch (blockName) {
						case UnicodeBlock.CJKUnifiedIdeographsExtensionB:
						case UnicodeBlock.CJKUnifiedIdeographsExtensionC:
						case UnicodeBlock.CJKUnifiedIdeographsExtensionD:
						case UnicodeBlock.CJKUnifiedIdeographsExtensionE:
						case UnicodeBlock.CJKUnifiedIdeographsExtensionF:
						case UnicodeBlock.CJKCompatibilityIdeographsSupplement:
							return true;
					}
					break;
				case TertiaryIdeographicPlane:
					switch (blockName) {
						case UnicodeBlock.CJKUnifiedIdeographsExtensionG:
							return true;
					}
					break;
				case SupplementarySpecialPurposePlane:
					switch (blockName) {
						case UnicodeBlock.Tags:
						case UnicodeBlock.VariationSelectorsSupplement:
							return true;
					}
					break;
				case SupplementaryPrivateUseAreaPlanes:
					switch (blockName) {
						case UnicodeBlock.SupplementaryPrivateUseAreaA:
						case UnicodeBlock.SupplementaryPrivateUseAreaB:
							return true;
					}
					break;
			}
			return false;
		}

		public static string GetName(string blockName) {
			if (string.IsNullOrEmpty(blockName)) {
				return string.Empty;
			}
			switch (blockName) {
				case UnicodeBlock.BasicLatin:
				case UnicodeBlock.Latin1Supplement:
				case UnicodeBlock.LatinExtendedA:
				case UnicodeBlock.LatinExtendedB:
				case UnicodeBlock.IPAExtensions:
				case UnicodeBlock.SpacingModifierLetters:
				case UnicodeBlock.CombiningDiacriticalMarks:
				case UnicodeBlock.GreekandCoptic:
				case UnicodeBlock.Cyrillic:
				case UnicodeBlock.CyrillicSupplement:
				case UnicodeBlock.Armenian:
				case UnicodeBlock.Hebrew:
				case UnicodeBlock.Arabic:
				case UnicodeBlock.Syriac:
				case UnicodeBlock.ArabicSupplement:
				case UnicodeBlock.Thaana:
				case UnicodeBlock.NKo:
				case UnicodeBlock.Samaritan:
				case UnicodeBlock.Mandaic:
				case UnicodeBlock.SyriacSupplement:
				case UnicodeBlock.ArabicExtendedA:
				case UnicodeBlock.Devanagari:
				case UnicodeBlock.Bengali:
				case UnicodeBlock.Gurmukhi:
				case UnicodeBlock.Gujarati:
				case UnicodeBlock.Oriya:
				case UnicodeBlock.Tamil:
				case UnicodeBlock.Telugu:
				case UnicodeBlock.Kannada:
				case UnicodeBlock.Malayalam:
				case UnicodeBlock.Sinhala:
				case UnicodeBlock.Thai:
				case UnicodeBlock.Lao:
				case UnicodeBlock.Tibetan:
				case UnicodeBlock.Myanmar:
				case UnicodeBlock.Georgian:
				case UnicodeBlock.HangulJamo:
				case UnicodeBlock.Ethiopic:
				case UnicodeBlock.EthiopicSupplement:
				case UnicodeBlock.Cherokee:
				case UnicodeBlock.UnifiedCanadianAboriginalSyllabics:
				case UnicodeBlock.Ogham:
				case UnicodeBlock.Runic:
				case UnicodeBlock.Tagalog:
				case UnicodeBlock.Hanunoo:
				case UnicodeBlock.Buhid:
				case UnicodeBlock.Tagbanwa:
				case UnicodeBlock.Khmer:
				case UnicodeBlock.Mongolian:
				case UnicodeBlock.UnifiedCanadianAboriginalSyllabicsExtended:
				case UnicodeBlock.Limbu:
				case UnicodeBlock.TaiLe:
				case UnicodeBlock.NewTaiLue:
				case UnicodeBlock.KhmerSymbols:
				case UnicodeBlock.Buginese:
				case UnicodeBlock.TaiTham:
				case UnicodeBlock.CombiningDiacriticalMarksExtended:
				case UnicodeBlock.Balinese:
				case UnicodeBlock.Sundanese:
				case UnicodeBlock.Batak:
				case UnicodeBlock.Lepcha:
				case UnicodeBlock.OlChiki:
				case UnicodeBlock.CyrillicExtendedC:
				case UnicodeBlock.GeorgianExtended:
				case UnicodeBlock.SundaneseSupplement:
				case UnicodeBlock.VedicExtensions:
				case UnicodeBlock.PhoneticExtensions:
				case UnicodeBlock.PhoneticExtensionsSupplement:
				case UnicodeBlock.CombiningDiacriticalMarksSupplement:
				case UnicodeBlock.LatinExtendedAdditional:
				case UnicodeBlock.GreekExtended:
				case UnicodeBlock.GeneralPunctuation:
				case UnicodeBlock.SuperscriptsandSubscripts:
				case UnicodeBlock.CurrencySymbols:
				case UnicodeBlock.CombiningDiacriticalMarksforSymbols:
				case UnicodeBlock.LetterlikeSymbols:
				case UnicodeBlock.NumberForms:
				case UnicodeBlock.Arrows:
				case UnicodeBlock.MathematicalOperators:
				case UnicodeBlock.MiscellaneousTechnical:
				case UnicodeBlock.ControlPictures:
				case UnicodeBlock.OpticalCharacterRecognition:
				case UnicodeBlock.EnclosedAlphanumerics:
				case UnicodeBlock.BoxDrawing:
				case UnicodeBlock.BlockElements:
				case UnicodeBlock.GeometricShapes:
				case UnicodeBlock.MiscellaneousSymbols:
				case UnicodeBlock.Dingbats:
				case UnicodeBlock.MiscellaneousMathematicalSymbolsA:
				case UnicodeBlock.SupplementalArrowsA:
				case UnicodeBlock.BraillePatterns:
				case UnicodeBlock.SupplementalArrowsB:
				case UnicodeBlock.MiscellaneousMathematicalSymbolsB:
				case UnicodeBlock.SupplementalMathematicalOperators:
				case UnicodeBlock.MiscellaneousSymbolsandArrows:
				case UnicodeBlock.Glagolitic:
				case UnicodeBlock.LatinExtendedC:
				case UnicodeBlock.Coptic:
				case UnicodeBlock.GeorgianSupplement:
				case UnicodeBlock.Tifinagh:
				case UnicodeBlock.EthiopicExtended:
				case UnicodeBlock.CyrillicExtendedA:
				case UnicodeBlock.SupplementalPunctuation:
				case UnicodeBlock.CJKRadicalsSupplement:
				case UnicodeBlock.KangxiRadicals:
				case UnicodeBlock.IdeographicDescriptionCharacters:
				case UnicodeBlock.CJKSymbolsandPunctuation:
				case UnicodeBlock.Hiragana:
				case UnicodeBlock.Katakana:
				case UnicodeBlock.Bopomofo:
				case UnicodeBlock.HangulCompatibilityJamo:
				case UnicodeBlock.Kanbun:
				case UnicodeBlock.BopomofoExtended:
				case UnicodeBlock.CJKStrokes:
				case UnicodeBlock.KatakanaPhoneticExtensions:
				case UnicodeBlock.EnclosedCJKLettersandMonths:
				case UnicodeBlock.CJKCompatibility:
				case UnicodeBlock.CJKUnifiedIdeographsExtensionA:
				case UnicodeBlock.YijingHexagramSymbols:
				case UnicodeBlock.CJKUnifiedIdeographs:
				case UnicodeBlock.YiSyllables:
				case UnicodeBlock.YiRadicals:
				case UnicodeBlock.Lisu:
				case UnicodeBlock.Vai:
				case UnicodeBlock.CyrillicExtendedB:
				case UnicodeBlock.Bamum:
				case UnicodeBlock.ModifierToneLetters:
				case UnicodeBlock.LatinExtendedD:
				case UnicodeBlock.SylotiNagri:
				case UnicodeBlock.CommonIndicNumberForms:
				case UnicodeBlock.Phagspa:
				case UnicodeBlock.Saurashtra:
				case UnicodeBlock.DevanagariExtended:
				case UnicodeBlock.KayahLi:
				case UnicodeBlock.Rejang:
				case UnicodeBlock.HangulJamoExtendedA:
				case UnicodeBlock.Javanese:
				case UnicodeBlock.MyanmarExtendedB:
				case UnicodeBlock.Cham:
				case UnicodeBlock.MyanmarExtendedA:
				case UnicodeBlock.TaiViet:
				case UnicodeBlock.MeeteiMayekExtensions:
				case UnicodeBlock.EthiopicExtendedA:
				case UnicodeBlock.LatinExtendedE:
				case UnicodeBlock.CherokeeSupplement:
				case UnicodeBlock.MeeteiMayek:
				case UnicodeBlock.HangulSyllables:
				case UnicodeBlock.HangulJamoExtendedB:
				case UnicodeBlock.HighSurrogates:
				case UnicodeBlock.HighPrivateUseSurrogates:
				case UnicodeBlock.LowSurrogates:
				case UnicodeBlock.PrivateUseArea:
				case UnicodeBlock.CJKCompatibilityIdeographs:
				case UnicodeBlock.AlphabeticPresentationForms:
				case UnicodeBlock.ArabicPresentationFormsA:
				case UnicodeBlock.VariationSelectors:
				case UnicodeBlock.VerticalForms:
				case UnicodeBlock.CombiningHalfMarks:
				case UnicodeBlock.CJKCompatibilityForms:
				case UnicodeBlock.SmallFormVariants:
				case UnicodeBlock.ArabicPresentationFormsB:
				case UnicodeBlock.HalfwidthandFullwidthForms:
				case UnicodeBlock.Specials:
					return BasicMultilingualPlane;
				case UnicodeBlock.LinearBSyllabary:
				case UnicodeBlock.LinearBIdeograms:
				case UnicodeBlock.AegeanNumbers:
				case UnicodeBlock.AncientGreekNumbers:
				case UnicodeBlock.AncientSymbols:
				case UnicodeBlock.PhaistosDisc:
				case UnicodeBlock.Lycian:
				case UnicodeBlock.Carian:
				case UnicodeBlock.CopticEpactNumbers:
				case UnicodeBlock.OldItalic:
				case UnicodeBlock.Gothic:
				case UnicodeBlock.OldPermic:
				case UnicodeBlock.Ugaritic:
				case UnicodeBlock.OldPersian:
				case UnicodeBlock.Deseret:
				case UnicodeBlock.Shavian:
				case UnicodeBlock.Osmanya:
				case UnicodeBlock.Osage:
				case UnicodeBlock.Elbasan:
				case UnicodeBlock.CaucasianAlbanian:
				case UnicodeBlock.LinearA:
				case UnicodeBlock.CypriotSyllabary:
				case UnicodeBlock.ImperialAramaic:
				case UnicodeBlock.Palmyrene:
				case UnicodeBlock.Nabataean:
				case UnicodeBlock.Hatran:
				case UnicodeBlock.Phoenician:
				case UnicodeBlock.Lydian:
				case UnicodeBlock.MeroiticHieroglyphs:
				case UnicodeBlock.MeroiticCursive:
				case UnicodeBlock.Kharoshthi:
				case UnicodeBlock.OldSouthArabian:
				case UnicodeBlock.OldNorthArabian:
				case UnicodeBlock.Manichaean:
				case UnicodeBlock.Avestan:
				case UnicodeBlock.InscriptionalParthian:
				case UnicodeBlock.InscriptionalPahlavi:
				case UnicodeBlock.PsalterPahlavi:
				case UnicodeBlock.OldTurkic:
				case UnicodeBlock.OldHungarian:
				case UnicodeBlock.HanifiRohingya:
				case UnicodeBlock.RumiNumeralSymbols:
				case UnicodeBlock.Yezidi:
				case UnicodeBlock.OldSogdian:
				case UnicodeBlock.Sogdian:
				case UnicodeBlock.Chorasmian:
				case UnicodeBlock.Elymaic:
				case UnicodeBlock.Brahmi:
				case UnicodeBlock.Kaithi:
				case UnicodeBlock.SoraSompeng:
				case UnicodeBlock.Chakma:
				case UnicodeBlock.Mahajani:
				case UnicodeBlock.Sharada:
				case UnicodeBlock.SinhalaArchaicNumbers:
				case UnicodeBlock.Khojki:
				case UnicodeBlock.Multani:
				case UnicodeBlock.Khudawadi:
				case UnicodeBlock.Grantha:
				case UnicodeBlock.Newa:
				case UnicodeBlock.Tirhuta:
				case UnicodeBlock.Siddham:
				case UnicodeBlock.Modi:
				case UnicodeBlock.MongolianSupplement:
				case UnicodeBlock.Takri:
				case UnicodeBlock.Ahom:
				case UnicodeBlock.Dogra:
				case UnicodeBlock.WarangCiti:
				case UnicodeBlock.DivesAkuru:
				case UnicodeBlock.Nandinagari:
				case UnicodeBlock.ZanabazarSquare:
				case UnicodeBlock.Soyombo:
				case UnicodeBlock.PauCinHau:
				case UnicodeBlock.Bhaiksuki:
				case UnicodeBlock.Marchen:
				case UnicodeBlock.MasaramGondi:
				case UnicodeBlock.GunjalaGondi:
				case UnicodeBlock.Makasar:
				case UnicodeBlock.LisuSupplement:
				case UnicodeBlock.TamilSupplement:
				case UnicodeBlock.Cuneiform:
				case UnicodeBlock.CuneiformNumbersandPunctuation:
				case UnicodeBlock.EarlyDynasticCuneiform:
				case UnicodeBlock.EgyptianHieroglyphs:
				case UnicodeBlock.EgyptianHieroglyphFormatControls:
				case UnicodeBlock.AnatolianHieroglyphs:
				case UnicodeBlock.BamumSupplement:
				case UnicodeBlock.Mro:
				case UnicodeBlock.BassaVah:
				case UnicodeBlock.PahawhHmong:
				case UnicodeBlock.Medefaidrin:
				case UnicodeBlock.Miao:
				case UnicodeBlock.IdeographicSymbolsandPunctuation:
				case UnicodeBlock.Tangut:
				case UnicodeBlock.TangutComponents:
				case UnicodeBlock.KhitanSmallScript:
				case UnicodeBlock.TangutSupplement:
				case UnicodeBlock.KanaSupplement:
				case UnicodeBlock.KanaExtendedA:
				case UnicodeBlock.SmallKanaExtension:
				case UnicodeBlock.Nushu:
				case UnicodeBlock.Duployan:
				case UnicodeBlock.ShorthandFormatControls:
				case UnicodeBlock.ByzantineMusicalSymbols:
				case UnicodeBlock.MusicalSymbols:
				case UnicodeBlock.AncientGreekMusicalNotation:
				case UnicodeBlock.MayanNumerals:
				case UnicodeBlock.TaiXuanJingSymbols:
				case UnicodeBlock.CountingRodNumerals:
				case UnicodeBlock.MathematicalAlphanumericSymbols:
				case UnicodeBlock.SuttonSignWriting:
				case UnicodeBlock.GlagoliticSupplement:
				case UnicodeBlock.NyiakengPuachueHmong:
				case UnicodeBlock.Wancho:
				case UnicodeBlock.MendeKikakui:
				case UnicodeBlock.Adlam:
				case UnicodeBlock.IndicSiyaqNumbers:
				case UnicodeBlock.OttomanSiyaqNumbers:
				case UnicodeBlock.ArabicMathematicalAlphabeticSymbols:
				case UnicodeBlock.MahjongTiles:
				case UnicodeBlock.DominoTiles:
				case UnicodeBlock.PlayingCards:
				case UnicodeBlock.EnclosedAlphanumericSupplement:
				case UnicodeBlock.EnclosedIdeographicSupplement:
				case UnicodeBlock.MiscellaneousSymbolsandPictographs:
				case UnicodeBlock.Emoticons:
				case UnicodeBlock.OrnamentalDingbats:
				case UnicodeBlock.TransportandMapSymbols:
				case UnicodeBlock.AlchemicalSymbols:
				case UnicodeBlock.GeometricShapesExtended:
				case UnicodeBlock.SupplementalArrowsC:
				case UnicodeBlock.SupplementalSymbolsandPictographs:
				case UnicodeBlock.ChessSymbols:
				case UnicodeBlock.SymbolsandPictographsExtendedA:
				case UnicodeBlock.SymbolsforLegacyComputing:
					return SupplementaryMultilingualPlane;
				case UnicodeBlock.CJKUnifiedIdeographsExtensionB:
				case UnicodeBlock.CJKUnifiedIdeographsExtensionC:
				case UnicodeBlock.CJKUnifiedIdeographsExtensionD:
				case UnicodeBlock.CJKUnifiedIdeographsExtensionE:
				case UnicodeBlock.CJKUnifiedIdeographsExtensionF:
				case UnicodeBlock.CJKCompatibilityIdeographsSupplement:
					return SupplementaryIdeographicPlane;
				case UnicodeBlock.CJKUnifiedIdeographsExtensionG:
					return TertiaryIdeographicPlane;
				case UnicodeBlock.Tags:
				case UnicodeBlock.VariationSelectorsSupplement:
					return SupplementarySpecialPurposePlane;
				case UnicodeBlock.SupplementaryPrivateUseAreaA:
				case UnicodeBlock.SupplementaryPrivateUseAreaB:
					return SupplementaryPrivateUseAreaPlanes;
			}
			return string.Empty;
		}

		public static string GetName(int codePoint) {
			if (codePoint < 0 || codePoint > UnicodeCodePoint.Max) {
				return string.Empty;
			}
			if (codePoint < 0x10000) {
				return BasicMultilingualPlane;
			}
			if (codePoint < 0x20000) {
				return SupplementaryMultilingualPlane;
			}
			if (codePoint < 0x30000) {
				return SupplementaryIdeographicPlane;
			}
			if (codePoint < 0x40000) {
				return TertiaryIdeographicPlane;
			}
			if (codePoint < 0xE0000) {
				return Unassigned;
			}
			if (codePoint < 0xF0000) {
				return SupplementarySpecialPurposePlane;
			}
			return SupplementaryPrivateUseAreaPlanes;
		}
	}
}
