namespace BasicClasses {
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public struct Range : IEnumerable<int>, IEquatable<Range> {
		public readonly int Min;
		public readonly int Max;
		public readonly bool ExcludeEnd;

		public Range(int min, int max, bool excludeEnd = false) {
			Min = min;
			Max = max;
			ExcludeEnd = excludeEnd;
		}

		public bool Equals(Range other) {
			return Min == other.Min &&
				Max == other.Max &&
				ExcludeEnd == other.ExcludeEnd;
		}

		public bool Include(int value) {
			if (ExcludeEnd) {
				return Min <= value && Max > value;
			}
			return Min <= value && Max >= value;
		}

		public override string ToString() {
			if (ExcludeEnd) {
				return string.Format("{0}...{1}", Min, Max);
			}
			return string.Format("{0}..{1}", Min, Max);
		}

		public IEnumerator<int> GetEnumerator() {
			return new Enumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return new Enumerator(this);
		}

		public struct Enumerator : IEnumerator<int>, IEnumerator {
			readonly Range _range;
			int _current;

			public int Current {
				get { return _current; }
			}
			object IEnumerator.Current {
				get { return Current; }
			}

			internal Enumerator(Range range) {
				_range = range;
				_current = _range.Min - 1;
			}

			public void Dispose() {
			}

			public bool MoveNext() {
				if (_range.Include(_current + 1) == false) {
					return false;
				}
				_current++;
				return true;
			}

			public void Reset() {
				_current = _range.Min - 1;
			}
		}
	}

	public struct Range<T> : IEquatable<Range<T>>
		where T : IEquatable<T>, IComparable<T>
	{
		public readonly T Min;
		public readonly T Max;
		public readonly bool ExcludeEnd;

		public Range(T min, T max, bool excludeEnd = false) {
			Min = min;
			Max = max;
			ExcludeEnd = excludeEnd;
		}

		public bool Equals(Range<T> other) {
			return Min.Equals(other.Min) &&
				Max.Equals(other.Max) &&
				ExcludeEnd == other.ExcludeEnd;
		}

		public bool Include(T value) {
			if (ExcludeEnd) {
				return Min.CompareTo(value) <= 0 && Max.CompareTo(value) > 0;
			}
			return Min.CompareTo(value) <= 0 && Max.CompareTo(value) >= 0;
		}

		public override string ToString() {
			if (ExcludeEnd) {
				return string.Format("{0}...{1}", Min, Max);
			}
			return string.Format("{0}..{1}", Min, Max);
		}
	}
}
