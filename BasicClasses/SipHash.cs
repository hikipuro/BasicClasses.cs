using System;
using System.Security.Cryptography;

namespace BasicClasses {
	public class SipHash : HashAlgorithm {
		public const int cROUNDS = 2;
		public const int dROUNDS = 4;

		protected byte[] _key;
		protected byte[] _out;

		public SipHash(int outSize, byte[] key) {
			if (outSize != 8 && outSize != 16) {
				throw new ArgumentOutOfRangeException(
					"outSize", "outSize must be 8 or 16."
				);
			}
			_key = key;
			if (_key.Length < 16) {
				int length = _key.Length;
				Array.Resize(ref _key, 16);
				for (int i = length; i < 16; i++) {
					_key[i] = 0;
				}
			}
			_out = new byte[outSize];
		}

		public override void Initialize() {
			Array.Clear(_out, 0, _out.Length);
		}

		protected override void HashCore(byte[] array, int ibStart, int cbSize) {
			int inlen = array.Length;
			if (inlen != cbSize) {
				inlen = cbSize;
			}
			int outlen = _out.Length;

			ulong v0 = 0x736f6d6570736575;
			ulong v1 = 0x646f72616e646f6d;
			ulong v2 = 0x6c7967656e657261;
			ulong v3 = 0x7465646279746573;
			ulong k0 = _key[0] | ((ulong)_key[1] << 8) |
				((ulong)_key[2] << 16) | ((ulong)_key[3] << 24) |
				((ulong)_key[4] << 32) | ((ulong)_key[5] << 40) |
				((ulong)_key[6] << 48) | ((ulong)_key[7] << 56);
			ulong k1 = _key[8] | ((ulong)_key[9] << 8) |
				((ulong)_key[10] << 16) | ((ulong)_key[11] << 24) |
				((ulong)_key[12] << 32) | ((ulong)_key[13] << 40) |
				((ulong)_key[14] << 48) | ((ulong)_key[15] << 56);
			ulong m;
			int end = inlen - (inlen % 8);
			int left = inlen & 7;
			ulong b = ((ulong)inlen) << 56;
			v3 ^= k1;
			v2 ^= k0;
			v1 ^= k1;
			v0 ^= k0;

			if (outlen == 16) {
				v1 ^= 0xee;
			}

			int n = ibStart;
			for (; n < ibStart + end; n += 8) {
				m = array[n + 0] | ((ulong)array[n + 1] << 8) |
					((ulong)array[n + 2] << 16) | ((ulong)array[n + 3] << 24) |
					((ulong)array[n + 4] << 32) | ((ulong)array[n + 5] << 40) |
					((ulong)array[n + 6] << 48) | ((ulong)array[n + 7] << 56);
				v3 ^= m;

				for (int i = 0; i < cROUNDS; ++i) {
					v0 += v1;
					v1 = (v1 << 13) | (v1 >> (64 - 13));
					v1 ^= v0;
					v0 = (v0 << 32) | (v0 >> (64 - 32));
					v2 += v3;
					v3 = (v3 << 16) | (v3 >> (64 - 16));
					v3 ^= v2;
					v0 += v3;
					v3 = (v3 << 21) | (v3 >> (64 - 21));
					v3 ^= v0;
					v2 += v1;
					v1 = (v1 << 17) | (v1 >> (64 - 17));
					v1 ^= v2;
					v2 = (v2 << 32) | (v2 >> (64 - 32));
				}
				v0 ^= m;
			}

			switch (left) {
				case 7:
					b |= ((ulong)array[n + 6]) << 48;
					b |= ((ulong)array[n + 5]) << 40;
					b |= ((ulong)array[n + 4]) << 32;
					b |= ((ulong)array[n + 3]) << 24;
					b |= ((ulong)array[n + 2]) << 16;
					b |= ((ulong)array[n + 1]) << 8;
					b |= array[n + 0];
					break;
				case 6:
					b |= ((ulong)array[n + 5]) << 40;
					b |= ((ulong)array[n + 4]) << 32;
					b |= ((ulong)array[n + 3]) << 24;
					b |= ((ulong)array[n + 2]) << 16;
					b |= ((ulong)array[n + 1]) << 8;
					b |= array[n + 0];
					break;
				case 5:
					b |= ((ulong)array[n + 4]) << 32;
					b |= ((ulong)array[n + 3]) << 24;
					b |= ((ulong)array[n + 2]) << 16;
					b |= ((ulong)array[n + 1]) << 8;
					b |= array[n + 0];
					break;
				case 4:
					b |= ((ulong)array[n + 3]) << 24;
					b |= ((ulong)array[n + 2]) << 16;
					b |= ((ulong)array[n + 1]) << 8;
					b |= array[n + 0];
					break;
				case 3:
					b |= ((ulong)array[n + 2]) << 16;
					b |= ((ulong)array[n + 1]) << 8;
					b |= array[n + 0];
					break;
				case 2:
					b |= ((ulong)array[n + 1]) << 8;
					b |= array[n + 0];
					break;
				case 1:
					b |= array[n + 0];
					break;
				case 0:
					break;
			}

			v3 ^= b;

			for (int i = 0; i < cROUNDS; ++i) {
				v0 += v1;
				v1 = (v1 << 13) | (v1 >> (64 - 13));
				v1 ^= v0;
				v0 = (v0 << 32) | (v0 >> (64 - 32));
				v2 += v3;
				v3 = (v3 << 16) | (v3 >> (64 - 16));
				v3 ^= v2;
				v0 += v3;
				v3 = (v3 << 21) | (v3 >> (64 - 21));
				v3 ^= v0;
				v2 += v1;
				v1 = (v1 << 17) | (v1 >> (64 - 17));
				v1 ^= v2;
				v2 = (v2 << 32) | (v2 >> (64 - 32));
			}

			v0 ^= b;

			if (outlen == 16) {
				v2 ^= 0xee;
			} else {
				v2 ^= 0xff;
			}

			for (int i = 0; i < dROUNDS; ++i) {
				v0 += v1;
				v1 = (v1 << 13) | (v1 >> (64 - 13));
				v1 ^= v0;
				v0 = (v0 << 32) | (v0 >> (64 - 32));
				v2 += v3;
				v3 = (v3 << 16) | (v3 >> (64 - 16));
				v3 ^= v2;
				v0 += v3;
				v3 = (v3 << 21) | (v3 >> (64 - 21));
				v3 ^= v0;
				v2 += v1;
				v1 = (v1 << 17) | (v1 >> (64 - 17));
				v1 ^= v2;
				v2 = (v2 << 32) | (v2 >> (64 - 32));
			}

			b = v0 ^ v1 ^ v2 ^ v3;
			_out[0] = (byte)b;
			_out[1] = (byte)(b >> 8);
			_out[2] = (byte)(b >> 16);
			_out[3] = (byte)(b >> 24);
			_out[4] = (byte)(b >> 32);
			_out[5] = (byte)(b >> 40);
			_out[6] = (byte)(b >> 48);
			_out[7] = (byte)(b >> 56);

			if (outlen == 8) {
				return;
			}

			v1 ^= 0xdd;

			for (int i = 0; i < dROUNDS; ++i) {
				v0 += v1;
				v1 = (v1 << 13) | (v1 >> (64 - 13));
				v1 ^= v0;
				v0 = (v0 << 32) | (v0 >> (64 - 32));
				v2 += v3;
				v3 = (v3 << 16) | (v3 >> (64 - 16));
				v3 ^= v2;
				v0 += v3;
				v3 = (v3 << 21) | (v3 >> (64 - 21));
				v3 ^= v0;
				v2 += v1;
				v1 = (v1 << 17) | (v1 >> (64 - 17));
				v1 ^= v2;
				v2 = (v2 << 32) | (v2 >> (64 - 32));
			}

			b = v0 ^ v1 ^ v2 ^ v3;
			_out[8] = (byte)b;
			_out[9] = (byte)(b >> 8);
			_out[10] = (byte)(b >> 16);
			_out[11] = (byte)(b >> 24);
			_out[12] = (byte)(b >> 32);
			_out[13] = (byte)(b >> 40);
			_out[14] = (byte)(b >> 48);
			_out[15] = (byte)(b >> 56);
		}

		protected override byte[] HashFinal() {
			return _out;
		}
	}
}
