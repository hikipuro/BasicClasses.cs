namespace BasicClasses {
	using System;

	public static class UTF8Utils {
		public static void WriteBOM(byte[] bytes) {
			WriteBOM(bytes, 0);
		}

		public static void WriteBOM(byte[] bytes, int offset) {
			bytes[offset] = 0xEF;
			bytes[offset + 1] = 0xBB;
			bytes[offset + 2] = 0xBF;
		}

		public static bool HasBOM(byte[] bytes) {
			return HasBOM(bytes, 0);
		}

		public static bool HasBOM(byte[] bytes, int offset) {
			return bytes[offset] == 0xEF &&
				bytes[offset + 1] == 0xBB &&
				bytes[offset + 2] == 0xBF;
		}

		public static int GetLength(string value) {
			if (value == null || value == string.Empty) {
				return 0;
			}
			const int ZeroWidthJoiner = UnicodeCodePoint.ZeroWidthJoiner;
			int length = 0;
			int code = 0;
			int prevCode = 0;
			for (int i = 0; i < value.Length; i++) {
				char c = value[i];
				if (code != 0) {
					if ((c & 0xFC00) != 0xDC00) {
						throw new InvalidOperationException(
							string.Format("Invalid surrogate pair ({0})", i)
						);
					}
					code |= c & 0x3FF;
					switch (code) {
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterA:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterB:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterC:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterD:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterE:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterF:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterG:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterH:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterI:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterJ:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterK:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterL:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterM:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterN:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterO:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterP:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterQ:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterR:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterS:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterT:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterU:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterV:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterW:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterX:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterY:
						case UnicodeCodePoint.RegionalIndicatorSymbolLetterZ:
							if (UnicodeCodePoint.IsRegionalIndicatorSymbolLetter(prevCode) == false) {
								if (prevCode != ZeroWidthJoiner) {
									length++;
								}
							}
							prevCode = code;
							code = 0;
							continue;
						case UnicodeCodePoint.EmojiModifierFitzpatrickType1_2:
						case UnicodeCodePoint.EmojiModifierFitzpatrickType3:
						case UnicodeCodePoint.EmojiModifierFitzpatrickType4:
						case UnicodeCodePoint.EmojiModifierFitzpatrickType5:
						case UnicodeCodePoint.EmojiModifierFitzpatrickType6:
							prevCode = code;
							code = 0;
							continue;
					}
					if (code <= UnicodeCodePoint.Max) {
						if (prevCode != ZeroWidthJoiner) {
							length++;
						}
						prevCode = code;
						code = 0;
						continue;
					}
					throw new InvalidOperationException(
						string.Format(
							"Invalid code point ({0}, 0x{1:X})",
							i - 1, code
						)
					);
				}
				switch ((int)c) {
					case UnicodeCodePoint.ZeroWidthJoiner:
						prevCode = c;
						continue;
					case UnicodeCodePoint.CombiningLeftHarpoonAbove:
					case UnicodeCodePoint.CombiningRightHarpoonAbove:
					case UnicodeCodePoint.CombiningLongVerticalLineOverlay:
					case UnicodeCodePoint.CombiningShortVerticalLineOverlay:
					case UnicodeCodePoint.CombiningAnticlockwiseArrowAbove:
					case UnicodeCodePoint.CombiningClockwiseArrowAbove:
					case UnicodeCodePoint.CombiningLeftArrowAbove:
					case UnicodeCodePoint.CombiningRightArrowAbove:
					case UnicodeCodePoint.CombiningRingOverlay:
					case UnicodeCodePoint.CombiningClockwiseRingOverlay:
					case UnicodeCodePoint.CombiningAnticlockwiseRingOverlay:
					case UnicodeCodePoint.CombiningThreeDotsAbove:
					case UnicodeCodePoint.CombiningFourDotsAbove:
					case UnicodeCodePoint.CombiningEnclosingCircle:
					case UnicodeCodePoint.CombiningEnclosingSquare:
					case UnicodeCodePoint.CombiningEnclosingDiamond:
					case UnicodeCodePoint.CombiningEnclosingCircleBackslash:
					case UnicodeCodePoint.CombiningLeftRightArrowAbove:
					case UnicodeCodePoint.CombiningEnclosingScreen:
					case UnicodeCodePoint.CombiningEnclosingKeycap:
					case UnicodeCodePoint.CombiningEnclosingUpwardPointingTriangle:
					case UnicodeCodePoint.CombiningReverseSolidusOverlay:
					case UnicodeCodePoint.CombiningDoubleVerticalStrokeOverlay:
					case UnicodeCodePoint.CombiningAnnuitySymbol:
					case UnicodeCodePoint.CombiningTripleUnderdot:
					case UnicodeCodePoint.CombiningWideBridgeAbove:
					case UnicodeCodePoint.CombiningLeftwardsArrowOverlay:
					case UnicodeCodePoint.CombiningLongDoubleSolidusOverlay:
					case UnicodeCodePoint.CombiningRightwardsHarpoonWithBarbDownwards:
					case UnicodeCodePoint.CombiningLeftwardsHarpoonWithBarbDownwards:
					case UnicodeCodePoint.CombiningLeftArrowBelow:
					case UnicodeCodePoint.CombiningRightArrowBelow:
					case UnicodeCodePoint.CombiningAsteriskAbove:
						prevCode = c;
						continue;
					case UnicodeCodePoint.VariationSelector1:
					case UnicodeCodePoint.VariationSelector2:
					case UnicodeCodePoint.VariationSelector3:
					case UnicodeCodePoint.VariationSelector4:
					case UnicodeCodePoint.VariationSelector5:
					case UnicodeCodePoint.VariationSelector6:
					case UnicodeCodePoint.VariationSelector7:
					case UnicodeCodePoint.VariationSelector8:
					case UnicodeCodePoint.VariationSelector9:
					case UnicodeCodePoint.VariationSelector10:
					case UnicodeCodePoint.VariationSelector11:
					case UnicodeCodePoint.VariationSelector12:
					case UnicodeCodePoint.VariationSelector13:
					case UnicodeCodePoint.VariationSelector14:
					case UnicodeCodePoint.VariationSelector15:
					case UnicodeCodePoint.VariationSelector16:
						prevCode = c;
						continue;
				}
				if (c < UnicodeCodePoint.HighSurrogateMin) {
					if (prevCode != ZeroWidthJoiner) {
						length++;
					}
					prevCode = c;
					continue;
				}
				if (c <= UnicodeCodePoint.HighSurrogateMax) {
					code = 0x10000 + ((c & 0x3FF) << 10);
					continue;
				}
				if (c <= UnicodeCodePoint.LowSurrogateMax) {
					throw new InvalidOperationException(
						string.Format("Invalid surrogate pair ({0})", i)
					);
				}
				if (prevCode != ZeroWidthJoiner) {
					length++;
				}
				prevCode = c;
			}
			if (code != 0) {
				throw new InvalidOperationException(
					string.Format("Invalid surrogate pair ({0})", value.Length - 1)
				);
			}
			return length;
		}

		public static string Decode(byte[] bytes) {
			return Decode(bytes, 0, bytes.Length);
		}

		public static string Decode(byte[] bytes, int offset, int length) {
			if (length > 2 &&
				bytes[offset] == 0xEF &&
				bytes[offset + 1] == 0xBB &&
				bytes[offset + 2] == 0xBF) {
				offset += 3;
			}
			length += offset;
			if (length > bytes.Length) {
				length = bytes.Length;
			}
			int index = 0;
			int code = 0;
			int trail = 0;
			char[] buffer = new char[length];
			for (int i = offset; i < length; i++) {
				byte c = bytes[i];
				if (trail > 0) {
					if ((c & 0xC0) != 0x80) {
						throw new InvalidOperationException(
							string.Format("Invalid utf-8 byte array ({0}, 0x{1:X})", i, c)
						);
					}
					trail -= 6;
					if (trail > 0) {
						code |= (c & 0x3F) << trail;
						continue;
					}
					code |= c & 0x3F;
					if (code < 0x10000) {
						buffer[index++] = (char)code;
						continue;
					}
					buffer[index] = (char)(((code - 0x10000) >> 10) | UnicodeCodePoint.HighSurrogateMin);
					buffer[index + 1] = (char)((code & 0x3FF) | UnicodeCodePoint.LowSurrogateMin);
					index += 2;
					continue;
				}
				switch (c & 0xF8) {
					case 0x00:
					case 0x08:
					case 0x10:
					case 0x18:
					case 0x20:
					case 0x28:
					case 0x30:
					case 0x38:
					case 0x40:
					case 0x48:
					case 0x50:
					case 0x58:
					case 0x60:
					case 0x68:
					case 0x70:
					case 0x78:
						buffer[index++] = (char)c;
						continue;
					case 0xC0:
					case 0xC8:
					case 0xD0:
					case 0xD8:
						code = (c & 0x1F) << 6;
						trail = 6;
						continue;
					case 0xE0:
					case 0xE8:
						code = (c & 0xF) << 12;
						trail = 12;
						continue;
					case 0xF0:
						code = (c & 0x7) << 18;
						trail = 18;
						continue;
				}
				throw new InvalidOperationException(
					string.Format("Invalid utf-8 byte array ({0}, 0x{1:X})", i, c)
				);
			}
			return new string(buffer, 0, index);
		}

		public static int Encode(string value, byte[] bytes) {
			return Encode(value, bytes, 0);
		}

		public static int Encode(string value, byte[] bytes, bool writeBOM) {
			if (writeBOM == false) {
				return Encode(value, bytes, 0);
			}
			bytes[0] = 0xEF;
			bytes[1] = 0xBB;
			bytes[2] = 0xBF;
			return Encode(value, bytes, 3);
		}

		public static int Encode(string value, byte[] bytes, int offset, bool writeBOM) {
			if (writeBOM == false) {
				return Encode(value, bytes, offset);
			}
			bytes[offset] = 0xEF;
			bytes[offset + 1] = 0xBB;
			bytes[offset + 2] = 0xBF;
			return Encode(value, bytes, offset + 3);
		}

		public static int Encode(string value, byte[] bytes, int offset) {
			if (value == null || value == string.Empty || bytes == null) {
				return 0;
			}
			int index = offset;
			int code = 0;
			for (int i = 0; i < value.Length; i++) {
				char c = value[i];
				if (code != 0) {
					if ((c & 0xFC00) != 0xDC00) {
						throw new InvalidOperationException(
							string.Format("Invalid surrogate pair ({0})", i)
						);
					}
					code |= c & 0x3FF;
					if (code < 0x80) {
						bytes[index++] = (byte)code;
						code = 0;
						continue;
					}
					if (code < 0x800) {
						bytes[index] = (byte)(0xC0 | ((code >> 6) & 0x1F));
						bytes[index + 1] = (byte)(0x80 | (code & 0x3F));
						index += 2;
						code = 0;
						continue;
					}
					if (code < 0x10000) {
						bytes[index] = (byte)(0xE0 | ((code >> 12) & 0xF));
						bytes[index + 1] = (byte)(0x80 | ((code >> 6) & 0x3F));
						bytes[index + 2] = (byte)(0x80 | (code & 0x3F));
						index += 3;
						code = 0;
						continue;
					}
					if (code <= UnicodeCodePoint.Max) {
						bytes[index] = (byte)(0xF0 | ((code >> 18) & 0x7));
						bytes[index + 1] = (byte)(0x80 | ((code >> 12) & 0x3F));
						bytes[index + 2] = (byte)(0x80 | ((code >> 6) & 0x3F));
						bytes[index + 3] = (byte)(0x80 | (code & 0x3F));
						index += 4;
						code = 0;
						continue;
					}
					throw new InvalidOperationException(
						string.Format(
							"Invalid code point ({0}, 0x{1:X})",
							i - 1, code
						)
					);
				}

				if (c < 0x80) {
					bytes[index++] = (byte)c;
					continue;
				}
				if (c < 0x800) {
					bytes[index] = (byte)(0xC0 | ((c >> 6) & 0x1F));
					bytes[index + 1] = (byte)(0x80 | (c & 0x3F));
					index += 2;
					continue;
				}
				if (c < UnicodeCodePoint.HighSurrogateMin) {
					bytes[index] = (byte)(0xE0 | ((c >> 12) & 0xF));
					bytes[index + 1] = (byte)(0x80 | ((c >> 6) & 0x3F));
					bytes[index + 2] = (byte)(0x80 | (c & 0x3F));
					index += 3;
					continue;
				}
				if (c <= UnicodeCodePoint.HighSurrogateMax) {
					code = 0x10000 + ((c & 0x3FF) << 10);
					continue;
				}
				if (c <= UnicodeCodePoint.LowSurrogateMax) {
					throw new InvalidOperationException(
						string.Format("Invalid surrogate pair ({0})", i)
					);
				}
				bytes[index] = (byte)(0xE0 | ((c >> 12) & 0xF));
				bytes[index + 1] = (byte)(0x80 | ((c >> 6) & 0x3F));
				bytes[index + 2] = (byte)(0x80 | (c & 0x3F));
				index += 3;
			}
			if (code != 0) {
				throw new InvalidOperationException(
					string.Format("Invalid surrogate pair ({0})", value.Length - 1)
				);
			}
			return index - offset;
		}
	}
}
