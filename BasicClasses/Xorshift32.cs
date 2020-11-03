namespace BasicClasses {
	public class Xorshift32 {
		public uint Seed;

		public Xorshift32(uint seed = 2463534242) {
			Seed = seed;
		}

		public uint Next() {
			Seed ^= Seed << 13;
			Seed ^= Seed >> 17;
			return Seed ^= Seed << 5;
		}

		public int NextInt() {
			Seed ^= Seed << 13;
			Seed ^= Seed >> 17;
			return (int)(Seed ^= Seed << 5);
		}
	}
}
