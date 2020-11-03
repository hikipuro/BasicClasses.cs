namespace BasicClasses {
	public class Xorshift128Plus {
		public ulong Seed0;
		public ulong Seed1;

		public Xorshift128Plus(ulong seed0 = 1, ulong seed1 = 2) {
			Seed0 = seed0;
			Seed1 = seed1;
		}

		public ulong Next() {
			ulong s1 = Seed0;
			ulong s0 = Seed1;
			Seed0 = s0;
			s1 ^= s1 << 23;
			s1 ^= s1 >> 17;
			s1 ^= s0;
			s1 ^= s0 >> 26;
			Seed1 = s1;
			return Seed0 + Seed1;
		}
	}
}
