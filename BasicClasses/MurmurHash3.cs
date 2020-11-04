using System.Security.Cryptography;

namespace BasicClasses {
	public class MurmurHash3 : HashAlgorithm {
        public uint Seed;
        protected uint _out;

		public MurmurHash3(uint seed) {
            Seed = seed;
		}

		public override void Initialize() {
            _out = 0;
        }

		protected override void HashCore(byte[] array, int ibStart, int cbSize) {
            int len = array.Length;
            if (len != cbSize) {
                len = cbSize;
			}
            uint h = Seed;
            uint k = 0;

            int offset = ibStart;
            int end = ibStart + (len - (len & 3));
            while (offset < end) {
                k = array[offset] | (uint)(array[offset + 1] << 8) |
                    (uint)(array[offset + 2] << 16) |
                    (uint)(array[offset + 3] << 24);
                offset += 4;

                k *= 0xcc9e2d51;
                k = (k << 15) | (k >> 17);
                k *= 0x1b873593;
                h ^= k;
                h = (h << 13) | (h >> 19);
                h = h * 5 + 0xe6546b64;
            }

            switch (len & 3) {
                case 3:
                    k = array[offset] |
                        ((uint)array[offset + 1] << 8) |
                        ((uint)array[offset + 2] << 16);
                    break;
                case 2:
                    k = array[offset] |
                        ((uint)array[offset + 1] << 8);
                    break;
                case 1:
                    k = array[offset];
                    break;
                case 0:
                    k = 0;
                    break;
            }

            k *= 0xcc9e2d51;
            k = (k << 15) | (k >> 17);
            k *= 0x1b873593;
            h ^= k;

            h ^= (uint)len;
            h ^= h >> 16;
            h *= 0x85ebca6b;
            h ^= h >> 13;
            h *= 0xc2b2ae35;
            h ^= h >> 16;
            _out = h;
        }

		protected override byte[] HashFinal() {
            return new byte[] {
                (byte)_out,
                (byte)(_out >> 8),
                (byte)(_out >> 16),
                (byte)(_out >> 24)
            };
		}
	}
}
