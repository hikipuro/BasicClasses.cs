namespace System {
	public struct Range : IEquatable<Range> {
		public static Range All { get; }

		public Index Start { get; }
		public Index End { get; }

		public static Range StartAt(Index start) {
			return new Range(start, new Index(0, true));
		}

		public static Range EndAt(Index end) {
			return new Range(new Index(0), end);
		}

		static Range() {
			All = new Range(new Index(0), new Index(0, true));
		}

		public Range(Index start, Index end) {
			Start = start;
			End = end;
		}

		public override bool Equals(object value) {
			if ((value is Range) == false) {
				return false;
			}
			Range other = (Range)value;
			return Start.Equals(other.Start) && End.Equals(other.End);
		}

		public bool Equals(Range other) {
			return Start.Equals(other.Start) && End.Equals(other.End);
		}

		/*
		public override int GetHashCode() {
			return Start.Value + End.Value;
		}
		*/

		public ValueTuple<int, int> GetOffsetAndLength(int length) {
			return new ValueTuple<int, int>(
				Start.GetOffset(length),
				End.GetOffset(length)
			);
		}

		public override string ToString() {
			return string.Format("{0}..{1}", Start, End);
		}
	}
}
