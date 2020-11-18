namespace BasicClasses {
	public class UnicodePlane {
		public static readonly UnicodePlane BasicMultilingualPlane = new UnicodePlane(
			"Basic Multilingual Plane", 0x0000, 0xFFFF
		);

		public static readonly UnicodePlane SupplementaryMultilingualPlane = new UnicodePlane(
			"Supplementary Multilingual Plane", 0x10000, 0x1FFFF
		);

		public static readonly UnicodePlane SupplementaryIdeographicPlane = new UnicodePlane(
			"Supplementary Ideographic Plane", 0x20000, 0x2FFFF
		);

		public static readonly UnicodePlane TertiaryIdeographicPlane = new UnicodePlane(
			"Tertiary Ideographic Plane", 0x30000, 0x3FFFF
		);

		public static readonly UnicodePlane Unassigned = new UnicodePlane(
			"unassigned", 0x40000, 0xDFFFF
		);

		public static readonly UnicodePlane SupplementarySpecialPurposePlane = new UnicodePlane(
			"Supplementary Special-purpose Plane", 0xE0000, 0xEFFFF
		);

		public static readonly UnicodePlane SupplementaryPrivateUseAreaPlanes = new UnicodePlane(
			"Supplementary Private Use Area planes", 0xF0000, 0x10FFFF
		);

		/// <summary>
		/// Basic Multilingual Plane
		/// </summary>
		public static readonly UnicodePlane BMP = BasicMultilingualPlane;

		/// <summary>
		/// Supplementary Multilingual Plane
		/// </summary>
		public static readonly UnicodePlane SMP = SupplementaryMultilingualPlane;

		/// <summary>
		/// Supplementary Ideographic Plane
		/// </summary>
		public static readonly UnicodePlane SIP = SupplementaryIdeographicPlane;

		/// <summary>
		/// Tertiary Ideographic Plane
		/// </summary>
		public static readonly UnicodePlane TIP = TertiaryIdeographicPlane;

		/// <summary>
		/// Supplementary Special-purpose Plane
		/// </summary>
		public static readonly UnicodePlane SSP = SupplementarySpecialPurposePlane;

		/// <summary>
		/// Supplementary Private Use Area planes
		/// </summary>
		public static readonly UnicodePlane SPUA = SupplementaryPrivateUseAreaPlanes;

		static readonly UnicodePlane[] Planes = new UnicodePlane[] {
			BasicMultilingualPlane,
			SupplementaryMultilingualPlane,
			SupplementaryIdeographicPlane,
			TertiaryIdeographicPlane,
			Unassigned,
			SupplementarySpecialPurposePlane,
			SupplementaryPrivateUseAreaPlanes
		};

		public readonly string Name;
		public readonly int StartCodePoint;
		public readonly int EndCodePoint;

		public UnicodePlane(string name, int startCodePoint, int endCodePoint) {
			Name = name;
			StartCodePoint = startCodePoint;
			EndCodePoint = endCodePoint;
		}

		public static bool operator ==(UnicodePlane a, UnicodePlane b) {
			if (a is null) {
				return b is null;
			}
			return a.Equals(b);
		}

		public static bool operator !=(UnicodePlane a, UnicodePlane b) {
			if (a is null) {
				return b is null;
			}
			return !a.Equals(b);
		}

		public static UnicodePlane FromCodePoint(char codePoint) {
			return BasicMultilingualPlane;
		}

		public static UnicodePlane FromCodePoint(int codePoint) {
			if (codePoint < 0 || codePoint > UnicodeCodePoint.Max) {
				return null;
			}
			foreach (UnicodePlane plane in Planes) {
				if (plane.Contains(codePoint)) {
					return plane;
				}
			}
			return null;
		}

		public static UnicodePlane FromBlock(UnicodeBlock block) {
			if (block == null) {
				return null;
			}
			foreach (UnicodePlane plane in Planes) {
				if (plane.Contains(block)) {
					return plane;
				}
			}
			return null;
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

		public bool Contains(UnicodeBlock block) {
			if (block == null) {
				return false;
			}
			return block.StartCodePoint >= StartCodePoint &&
				block.EndCodePoint <= EndCodePoint;
		}

		public override bool Equals(object obj) {
			if ((obj is UnicodePlane) == false) {
				return false;
			}
			UnicodePlane plane = (UnicodePlane)obj;
			return StartCodePoint == plane.StartCodePoint &&
					EndCodePoint == plane.EndCodePoint &&
					Name == plane.Name;
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
