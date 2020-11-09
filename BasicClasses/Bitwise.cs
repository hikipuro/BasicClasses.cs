namespace BasicClasses {
	using System;

	public static class Bitwise {
		public static float Int32BitsToFloat(int value) {
			return BitConverter.ToSingle(BitConverter.GetBytes(value), 0);
		}

		public static float Int32BitsToFloat(uint value) {
			return BitConverter.ToSingle(BitConverter.GetBytes(value), 0);
		}

		public static double Int64BitsToDouble(long value) {
			return BitConverter.ToDouble(BitConverter.GetBytes(value), 0);
		}

		public static double Int64BitsToDouble(ulong value) {
			return BitConverter.ToDouble(BitConverter.GetBytes(value), 0);
		}

		public static int FloatToInt32Bits(float value) {
			return BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
		}

		public static long DoubleToInt64Bits(double value) {
			return BitConverter.DoubleToInt64Bits(value);
		}

		public static int Set(int value, int position) {
			return value | (1 << position);
		}

		public static int Reset(int value, int position) {
			return value & ~(1 << position);
		}

		public static bool Test(int value, int position) {
			return 0 < (value & (1 << position));
		}

		public static bool All(int value) {
			return value == -1;
		}

		public static bool Any(int value) {
			return value != 0;
		}

		public static bool None(int value) {
			return value == 0;
		}

		public static int Flip(int value) {
			return ~value;
		}

		public static int RotateLeft(int value, int count) {
			return (value << count) | (value >> (32 - count));
		}

		public static int RotateRight(int value, int count) {
			return (value >> count) | (value << (32 - count));
		}

		public static int SetHighBits(int value, int count) {
			return value | ~((1 << (32 - count)) - 1);
		}

		public static int SetLowBits(int value, int count) {
			return value | ((1 << count) - 1);
		}

		public static int ClearHighBits(int value, int count) {
			return value & ((1 << (32 - count)) - 1);
		}

		public static int ClearLowBits(int value, int count) {
			return value & ~((1 << count) - 1);
		}

		public static int PopCount(short value) {
			int n = value;
			n = (n & 0x5555) + (n >> 1 & 0x5555);
			n = (n & 0x3333) + (n >> 2 & 0x3333);
			n = (n & 0x0f0f) + (n >> 4 & 0x0f0f);
			return (n & 0x00ff) + (n >> 8 & 0x00ff);
		}

		/// <summary>
		/// POPCNT
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int PopCount(int value) {
			value = (value & 0x55555555) + (value >> 1 & 0x55555555);
			value = (value & 0x33333333) + (value >> 2 & 0x33333333);
			value = (value & 0x0f0f0f0f) + (value >> 4 & 0x0f0f0f0f);
			value = (value & 0x00ff00ff) + (value >> 8 & 0x00ff00ff);
			return (value & 0x0000ffff) + (value >> 16 & 0x0000ffff);
		}

		public static int PopCount(long value) {
			value = (value & 0x5555555555555555) + ((value >> 1) & 0x5555555555555555);
			value = (value & 0x3333333333333333) + ((value >> 2) & 0x3333333333333333);
			value = (value & 0x0f0f0f0f0f0f0f0f) + ((value >> 4) & 0x0f0f0f0f0f0f0f0f);
			value = (value & 0x00ff00ff00ff00ff) + ((value >> 8) & 0x00ff00ff00ff00ff);
			value = (value & 0x0000ffff0000ffff) + ((value >> 16) & 0x0000ffff0000ffff);
			return (int)((value & 0x00000000ffffffff) + ((value >> 32) & 0x00000000ffffffff));
		}

		/// <summary>
		/// LZCNT
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int CountLeadingZeros(int value) {
			value |= value >> 1;
			value |= value >> 2;
			value |= value >> 4;
			value |= value >> 8;
			value |= value >> 16;
			value -= value >> 1 & 0x55555555;
			value = (value >> 2 & 0x33333333) + (value & 0x33333333);
			value = (value >> 4) + value & 0x0f0f0f0f;
			value += value >> 8;
			value += value >> 16;
			return 32 - (value & 0x0000003f);
		}

		/// <summary>
		/// TZCNT
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int CountTrailingZeros(int value) {
			if (value == 0) { return 32; }
			int n = 1;
			if ((value & 0x0000FFFF) == 0) { n += 16; value >>= 16; }
			if ((value & 0x000000FF) == 0) { n += 8; value >>= 8; }
			if ((value & 0x0000000F) == 0) { n += 4; value >>= 4; }
			if ((value & 0x00000003) == 0) { n += 2; value >>= 2; }
			return n - (value & 1);
		}

		/// <summary>
		/// ANDN
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public static int AndNot(int x, int y) {
			return ~x & y;
		}

		/// <summary>
		/// BEXTR
		/// </summary>
		/// <param name="value"></param>
		/// <param name="start"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		public static int Extract(int value, int start, int length) {
			return (value >> start) & ((1 << length) - 1);
		}

		/// <summary>
		/// BLSI
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int ExtractLowestSetIsolatedBit(int value) {
			return value & -value;
		}

		/// <summary>
		/// BLSMSK
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int GetMaskUpToLowestSetBit(int value) {
			return value ^ (value - 1);
		}

		/// <summary>
		/// BLCFILL
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int FillFromLowestClearBit(int value) {
			return value & (value + 1);
		}

		/// <summary>
		/// BLCI
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int IsolateLowestClearBit(int value) {
			return value | ~(value + 1);
		}

		/// <summary>
		/// BLCIC
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int IsolateLowestClearBitAndComplement(int value) {
			return ~value & (value + 1);
		}

		/// <summary>
		/// BLCMSK
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int MaskFromLowestClearBit(int value) {
			return value ^ (value + 1);
		}

		/// <summary>
		/// BLSR
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int ResetLowestSetBit(int value) {
			return value & (value - 1);
		}

		/// <summary>
		/// BLCS
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int SetLowestClearBit(int value) {
			return value | (value + 1);
		}

		/// <summary>
		/// BLSFILL
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int FillFromLowestSetBit(int value) {
			return value | (value - 1);
		}

		/// <summary>
		/// BLSIC
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int IsolateLowestSetBitAndComplement(int value) {
			return ~value | (value - 1);
		}

		/// <summary>
		/// T1MSKC
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int InverseMaskFromTrailingOnes(int value) {
			return ~value | (value + 1);
		}

		/// <summary>
		/// TZMSK
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int MaskFromTrailingZeros(int value) {
			return ~value & (value - 1);
		}

		public static string ToString(int value) {
			return Convert.ToString(value, 2).PadLeft(32, '0');
		}
	}
}
