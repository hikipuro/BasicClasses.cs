namespace BasicClasses {
	using System;

	public static class UTF8Utils {
		public const int MaxCodePoint = 0x10FFFF;
		public const char HighSurrogateMin = (char)0xD800;
		public const char HighSurrogateMax = (char)0xDBFF;
		public const char LowSurrogateMin = (char)0xDC00;
		public const char LowSurrogateMax = (char)0xDFFF;

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

		public static string Decode(byte[] bytes) {
			return Decode(bytes, 0, bytes.Length);
		}

		public static string Decode(byte[] bytes, int offset, int length) {
			if (bytes[offset] == 0xEF &&
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
							string.Format("Invalid utf-8 format ({0}, 0x{1:X})", i, c)
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
					buffer[index] = (char)(((code - 0x10000) >> 10) | HighSurrogateMin);
					buffer[index + 1] = (char)((code & 0x3FF) | LowSurrogateMin);
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
					string.Format("Invalid utf-8 format ({0}, 0x{1:X})", i, c)
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
			bool surrogatePair = false;
			for (int i = 0; i < value.Length; i++) {
				char c = value[i];
				if (surrogatePair) {
					if ((c & 0xFC00) != 0xDC00) {
						throw new InvalidOperationException(
							string.Format("Invalid surrogate pair ({0})", i)
						);
					}
					code |= c & 0x3FF;
					surrogatePair = false;
					if (code < 0x80) {
						bytes[index++] = (byte)code;
						continue;
					}
					if (code < 0x800) {
						bytes[index] = (byte)(0xC0 | ((code >> 6) & 0x1F));
						bytes[index + 1] = (byte)(0x80 | (code & 0x3F));
						index += 2;
						continue;
					}
					if (code < 0x10000) {
						bytes[index] = (byte)(0xE0 | ((code >> 12) & 0xF));
						bytes[index + 1] = (byte)(0x80 | ((code >> 6) & 0x3F));
						bytes[index + 2] = (byte)(0x80 | (code & 0x3F));
						index += 3;
						continue;
					}
					if (code <= MaxCodePoint) {
						bytes[index] = (byte)(0xF0 | ((code >> 18) & 0x7));
						bytes[index + 1] = (byte)(0x80 | ((code >> 12) & 0x3F));
						bytes[index + 2] = (byte)(0x80 | ((code >> 6) & 0x3F));
						bytes[index + 3] = (byte)(0x80 | (code & 0x3F));
						index += 4;
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
				if (c < HighSurrogateMin) {
					bytes[index] = (byte)(0xE0 | ((c >> 12) & 0xF));
					bytes[index + 1] = (byte)(0x80 | ((c >> 6) & 0x3F));
					bytes[index + 2] = (byte)(0x80 | (c & 0x3F));
					index += 3;
					continue;
				}
				if (c <= HighSurrogateMax) {
					code = 0x10000 + ((c & 0x3FF) << 10);
					surrogatePair = true;
					continue;
				}
				if (c <= LowSurrogateMax) {
					throw new InvalidOperationException(
						string.Format("Invalid surrogate pair ({0})", i)
					);
				}
				bytes[index] = (byte)(0xE0 | ((c >> 12) & 0xF));
				bytes[index + 1] = (byte)(0x80 | ((c >> 6) & 0x3F));
				bytes[index + 2] = (byte)(0x80 | (c & 0x3F));
				index += 3;
			}
			if (surrogatePair) {
				throw new InvalidOperationException(
					string.Format("Invalid surrogate pair ({0})", value.Length - 1)
				);
			}
			return index - offset;
		}
	}
}
