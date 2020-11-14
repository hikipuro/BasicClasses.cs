#if NETFRAMEWORK
namespace System {
	public struct Index : IEquatable<Index> {
		public static Index Start {	get; }
		public static Index End { get; }

		public int Value { get; }
		public bool IsFromEnd { get; }

		public static implicit operator Index(int value) {
			return new Index(value);
		}

		static Index() {
			Start = new Index(0);
			End = new Index(0, true);
		}

		public static Index FromStart(int value) {
			return new Index(value);
		}

		public static Index FromEnd(int value) {
			return new Index(value, true);
		}

		public Index(int value, bool fromEnd = false) {
			Value = value;
			IsFromEnd = fromEnd;
		}

		public override bool Equals(object value) {
			if ((value is Index) == false) {
				return false;
			}
			Index other = (Index)value;
			return Value == other.Value && IsFromEnd == other.IsFromEnd;
		}

		public bool Equals(Index other) {
			return Value == other.Value && IsFromEnd == other.IsFromEnd;
		}

		public int GetOffset(int length) {
			if (IsFromEnd == false) {
				return Value;
			}
			return length - Value;
		}

		public override string ToString() {
			return string.Format("{0}", Value);
		}
	}
}
#endif // NETFRAMEWORK
