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


		public static byte Set(byte value, int position) {
			return (byte)(value | (byte)(1 << position));
		}

		public static sbyte Set(sbyte value, int position) {
			return (sbyte)(value | (sbyte)(1 << position));
		}

		public static short Set(short value, int position) {
			return (short)(value | (short)(1 << position));
		}

		public static ushort Set(ushort value, int position) {
			return (ushort)(value | (ushort)(1 << position));
		}

		public static int Set(int value, int position) {
			return value | (1 << position);
		}

		public static uint Set(uint value, int position) {
			return value | (1u << position);
		}

		public static long Set(long value, int position) {
			return value | (1L << position);
		}

		public static ulong Set(ulong value, int position) {
			return value | (1ul << position);
		}


		public static byte Reset(byte value, int position) {
			return (byte)(value & (byte)~(1 << position));
		}

		public static sbyte Reset(sbyte value, int position) {
			return (sbyte)(value & (sbyte)~(1 << position));
		}

		public static short Reset(short value, int position) {
			return (short)(value & (short)~(1 << position));
		}

		public static ushort Reset(ushort value, int position) {
			return (ushort)(value & (ushort)~(1 << position));
		}

		public static int Reset(int value, int position) {
			return value & ~(1 << position);
		}

		public static uint Reset(uint value, int position) {
			return value & ~(1u << position);
		}

		public static long Reset(long value, int position) {
			return value & ~(1L << position);
		}

		public static ulong Reset(ulong value, int position) {
			return value & ~(1ul << position);
		}


		public static bool Test(byte value, int position) {
			return 0 < (value & (1 << position));
		}

		public static bool Test(sbyte value, int position) {
			return 0 < (value & (1 << position));
		}

		public static bool Test(short value, int position) {
			return 0 < (value & (1 << position));
		}

		public static bool Test(ushort value, int position) {
			return 0 < (value & (1 << position));
		}

		public static bool Test(int value, int position) {
			return 0 < (value & (1 << position));
		}

		public static bool Test(uint value, int position) {
			return 0 < (value & (1u << position));
		}

		public static bool Test(long value, int position) {
			return 0 < (value & (1L << position));
		}

		public static bool Test(ulong value, int position) {
			return 0 < (value & (1ul << position));
		}


		public static bool All(byte value) {
			return value == 0xFF;
		}

		public static bool All(sbyte value) {
			return value == -1;
		}

		public static bool All(short value) {
			return value == -1;
		}

		public static bool All(ushort value) {
			return value == ushort.MaxValue;
		}

		public static bool All(int value) {
			return value == -1;
		}

		public static bool All(uint value) {
			return value == uint.MaxValue;
		}

		public static bool All(long value) {
			return value == -1L;
		}

		public static bool All(ulong value) {
			return value == ulong.MaxValue;
		}


		public static bool Any(byte value) {
			return value != 0;
		}

		public static bool Any(sbyte value) {
			return value != 0;
		}

		public static bool Any(short value) {
			return value != 0;
		}

		public static bool Any(ushort value) {
			return value != 0;
		}

		public static bool Any(int value) {
			return value != 0;
		}

		public static bool Any(uint value) {
			return value != 0;
		}

		public static bool Any(long value) {
			return value != 0;
		}

		public static bool Any(ulong value) {
			return value != 0;
		}


		public static bool None(byte value) {
			return value == 0;
		}

		public static bool None(sbyte value) {
			return value == 0;
		}

		public static bool None(short value) {
			return value == 0;
		}

		public static bool None(ushort value) {
			return value == 0;
		}

		public static bool None(int value) {
			return value == 0;
		}

		public static bool None(uint value) {
			return value == 0;
		}

		public static bool None(long value) {
			return value == 0;
		}

		public static bool None(ulong value) {
			return value == 0;
		}


		public static byte Flip(byte value) {
			return (byte)~value;
		}

		public static sbyte Flip(sbyte value) {
			return (sbyte)~value;
		}

		public static short Flip(short value) {
			return (short)~value;
		}

		public static ushort Flip(ushort value) {
			return (ushort)~value;
		}

		public static int Flip(int value) {
			return ~value;
		}

		public static uint Flip(uint value) {
			return ~value;
		}

		public static long Flip(long value) {
			return ~value;
		}

		public static ulong Flip(ulong value) {
			return ~value;
		}


		public static byte RotateLeft(byte value, int count) {
			return (byte)((value << count) | (value >> (8 - count)));
		}

		public static sbyte RotateLeft(sbyte value, int count) {
			return (sbyte)((value << count) | (value >> (8 - count)));
		}

		public static short RotateLeft(short value, int count) {
			return (short)((value << count) | (value >> (16 - count)));
		}

		public static ushort RotateLeft(ushort value, int count) {
			return (ushort)((value << count) | (value >> (16 - count)));
		}

		public static int RotateLeft(int value, int count) {
			return (value << count) | (value >> (32 - count));
		}

		public static uint RotateLeft(uint value, int count) {
			return (value << count) | (value >> (32 - count));
		}

		public static long RotateLeft(long value, int count) {
			return (value << count) | (value >> (64 - count));
		}

		public static ulong RotateLeft(ulong value, int count) {
			return (value << count) | (value >> (64 - count));
		}


		public static byte RotateRight(byte value, int count) {
			return (byte)((value >> count) | (value << (8 - count)));
		}

		public static sbyte RotateRight(sbyte value, int count) {
			return (sbyte)((value >> count) | (value << (8 - count)));
		}

		public static short RotateRight(short value, int count) {
			return (short)((value >> count) | (value << (16 - count)));
		}

		public static ushort RotateRight(ushort value, int count) {
			return (ushort)((value >> count) | (value << (16 - count)));
		}

		public static int RotateRight(int value, int count) {
			return (value >> count) | (value << (32 - count));
		}

		public static uint RotateRight(uint value, int count) {
			return (value >> count) | (value << (32 - count));
		}

		public static long RotateRight(long value, int count) {
			return (value >> count) | (value << (64 - count));
		}

		public static ulong RotateRight(ulong value, int count) {
			return (value >> count) | (value << (64 - count));
		}


		public static byte SetHighBits(byte value, int count) {
			return (byte)(value | (byte)~((1 << (8 - count)) - 1));
		}

		public static sbyte SetHighBits(sbyte value, int count) {
			return (sbyte)(value | (sbyte)~((1 << (8 - count)) - 1));
		}

		public static short SetHighBits(short value, int count) {
			return (short)(value | (short)~((1 << (16 - count)) - 1));
		}

		public static ushort SetHighBits(ushort value, int count) {
			return (ushort)(value | (ushort)~((1 << (16 - count)) - 1));
		}

		public static int SetHighBits(int value, int count) {
			return value | ~((1 << (32 - count)) - 1);
		}

		public static uint SetHighBits(uint value, int count) {
			return value | ~((1u << (32 - count)) - 1);
		}

		public static long SetHighBits(long value, int count) {
			return value | ~((1L << (64 - count)) - 1);
		}

		public static ulong SetHighBits(ulong value, int count) {
			return value | ~((1ul << (64 - count)) - 1);
		}


		public static byte SetLowBits(byte value, int count) {
			return (byte)(value | (byte)((1 << count) - 1));
		}

		public static sbyte SetLowBits(sbyte value, int count) {
			return (sbyte)(value | (sbyte)((1 << count) - 1));
		}

		public static short SetLowBits(short value, int count) {
			return (short)(value | (short)((1 << count) - 1));
		}

		public static ushort SetLowBits(ushort value, int count) {
			return (ushort)(value | (ushort)((1 << count) - 1));
		}

		public static int SetLowBits(int value, int count) {
			return value | ((1 << count) - 1);
		}

		public static uint SetLowBits(uint value, int count) {
			return value | ((1u << count) - 1);
		}

		public static long SetLowBits(long value, int count) {
			return value | ((1L << count) - 1);
		}

		public static ulong SetLowBits(ulong value, int count) {
			return value | ((1ul << count) - 1);
		}


		public static byte ClearHighBits(byte value, int count) {
			return (byte)(value & ((1 << (8 - count)) - 1));
		}

		public static sbyte ClearHighBits(sbyte value, int count) {
			return (sbyte)(value & ((1 << (8 - count)) - 1));
		}

		public static short ClearHighBits(short value, int count) {
			return (short)(value & ((1 << (16 - count)) - 1));
		}

		public static ushort ClearHighBits(ushort value, int count) {
			return (ushort)(value & ((1 << (16 - count)) - 1));
		}

		public static int ClearHighBits(int value, int count) {
			return value & ((1 << (32 - count)) - 1);
		}

		public static uint ClearHighBits(uint value, int count) {
			return value & ((1u << (32 - count)) - 1);
		}

		public static long ClearHighBits(long value, int count) {
			return value & ((1L << (64 - count)) - 1);
		}

		public static ulong ClearHighBits(ulong value, int count) {
			return value & ((1ul << (64 - count)) - 1);
		}


		public static byte ClearLowBits(byte value, int count) {
			return (byte)(value & ~((1 << count) - 1));
		}

		public static sbyte ClearLowBits(sbyte value, int count) {
			return (sbyte)(value & ~((1 << count) - 1));
		}

		public static short ClearLowBits(short value, int count) {
			return (short)(value & ~((1 << count) - 1));
		}

		public static ushort ClearLowBits(ushort value, int count) {
			return (ushort)(value & ~((1 << count) - 1));
		}

		public static int ClearLowBits(int value, int count) {
			return value & ~((1 << count) - 1);
		}

		public static uint ClearLowBits(uint value, int count) {
			return value & ~((1u << count) - 1);
		}

		public static long ClearLowBits(long value, int count) {
			return value & ~((1L << count) - 1);
		}

		public static ulong ClearLowBits(ulong value, int count) {
			return value & ~((1ul << count) - 1);
		}


		public static int PopCount(byte value) {
			int n = value;
			n = (n & 0x55) + (n >> 1 & 0x55);
			n = (n & 0x33) + (n >> 2 & 0x33);
			return (n & 0x0f) + (n >> 4 & 0x0f);
		}

		public static int PopCount(sbyte value) {
			int n = value;
			n = (n & 0x55) + (n >> 1 & 0x55);
			n = (n & 0x33) + (n >> 2 & 0x33);
			return (n & 0x0f) + (n >> 4 & 0x0f);
		}

		public static int PopCount(short value) {
			int n = value;
			n = (n & 0x5555) + (n >> 1 & 0x5555);
			n = (n & 0x3333) + (n >> 2 & 0x3333);
			n = (n & 0x0f0f) + (n >> 4 & 0x0f0f);
			return (n & 0x00ff) + (n >> 8 & 0x00ff);
		}

		public static int PopCount(ushort value) {
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

		public static int PopCount(uint value) {
			value = (value & 0x55555555) + (value >> 1 & 0x55555555);
			value = (value & 0x33333333) + (value >> 2 & 0x33333333);
			value = (value & 0x0f0f0f0f) + (value >> 4 & 0x0f0f0f0f);
			value = (value & 0x00ff00ff) + (value >> 8 & 0x00ff00ff);
			return (int)((value & 0x0000ffff) + (value >> 16 & 0x0000ffff));
		}

		public static int PopCount(long value) {
			value = (value & 0x5555555555555555) + ((value >> 1) & 0x5555555555555555);
			value = (value & 0x3333333333333333) + ((value >> 2) & 0x3333333333333333);
			value = (value & 0x0f0f0f0f0f0f0f0f) + ((value >> 4) & 0x0f0f0f0f0f0f0f0f);
			value = (value & 0x00ff00ff00ff00ff) + ((value >> 8) & 0x00ff00ff00ff00ff);
			value = (value & 0x0000ffff0000ffff) + ((value >> 16) & 0x0000ffff0000ffff);
			return (int)((value & 0x00000000ffffffff) + ((value >> 32) & 0x00000000ffffffff));
		}

		public static int PopCount(ulong value) {
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

		public static string ToString(byte value) {
			return Convert.ToString(value, 2).PadLeft(8, '0');
		}

		public static string ToString(sbyte value) {
			return Convert.ToString(value, 2).PadLeft(8, '0');
		}

		public static string ToString(short value) {
			return Convert.ToString(value, 2).PadLeft(16, '0');
		}

		public static string ToString(ushort value) {
			return Convert.ToString(value, 2).PadLeft(16, '0');
		}

		public static string ToString(int value) {
			return Convert.ToString(value, 2).PadLeft(32, '0');
		}

		public static string ToString(uint value) {
			return Convert.ToString(value, 2).PadLeft(32, '0');
		}

		public static string ToString(long value) {
			return Convert.ToString(value, 2).PadLeft(64, '0');
		}

		public static string ToString(ulong value) {
			return Convert.ToString((long)value, 2).PadLeft(64, '0');
		}

		public static string ToString(float value) {
			return Convert.ToString(FloatToInt32Bits(value), 2).PadLeft(32, '0');
		}

		public static string ToString(double value) {
			return Convert.ToString(DoubleToInt64Bits(value), 2).PadLeft(64, '0');
		}
	}
}
