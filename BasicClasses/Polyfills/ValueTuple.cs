#if NET20 || NET35 || NET40 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462
namespace BasicClasses.Polyfills {
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public struct ValueTuple //:
		/*IComparable, IComparable<ValueTuple>, IEquatable<ValueTuple>,
		IStructuralComparable, IStructuralEquatable, ITuple*/
	{
		public static ValueTuple<T1> Create<T1>(T1 item1) {
			return new ValueTuple<T1>(item1);
		}

		public static ValueTuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) {
			return new ValueTuple<T1, T2>(item1, item2);
		}

		public static ValueTuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) {
			return new ValueTuple<T1, T2, T3>(item1, item2, item3);
		}
	}

	public struct ValueTuple<T1> :
		IComparable, IComparable<ValueTuple<T1>>, IEquatable<ValueTuple<T1>>,
		IStructuralComparable,IStructuralEquatable, ITuple
	{
		public T1 Item1;

		public object this[int index] {
			get {
				switch (index) {
					case 0: return Item1;
					default: throw new IndexOutOfRangeException();
				}
			}
		}

		public int Length {
			get { return 1; }
		}

		public ValueTuple(T1 item1) {
			Item1 = item1;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is ValueTuple<T1>) == false) {
				return false;
			}
			ValueTuple<T1> other = (ValueTuple<T1>)obj;
			return Item1.Equals(other.Item1);
		}

		public bool Equals(ValueTuple<T1> other) {
			return Item1.Equals(other.Item1);
		}

		public override int GetHashCode() {
			if (Item1 == null) {
				return 0;
			}
			return Item1.GetHashCode();
		}

		public override string ToString() {
			return string.Format("({0})", Item1);
		}

		public int CompareTo(object obj) {
			if (obj == null || (obj is ValueTuple<T1>) == false) {
				throw new ArgumentException("obj is not ValueTuple");
			}
			ValueTuple<T1> other = (ValueTuple<T1>)obj;
			return Comparer<T1>.Default.Compare(Item1, other.Item1);
		}

		public int CompareTo(ValueTuple<T1> other) {
			return Comparer<T1>.Default.Compare(Item1, other.Item1);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is ValueTuple<T1>) == false) {
				throw new ArgumentException("other is not ValueTuple");
			}
			return comparer.Compare(this, other);
		}

		public bool Equals(object other, IEqualityComparer comparer) {
			return comparer.Equals(this, other);
		}

		public int GetHashCode(IEqualityComparer comparer) {
			return comparer.GetHashCode(this);
		}
	}

	public struct ValueTuple<T1, T2> :
		IComparable, IComparable<ValueTuple<T1, T2>>,
		IEquatable<ValueTuple<T1, T2>>,
		IStructuralComparable, IStructuralEquatable, ITuple
	{
		public T1 Item1;
		public T2 Item2;

		public object this[int index] {
			get {
				switch (index) {
					case 0: return Item1;
					case 1: return Item2;
					default: throw new IndexOutOfRangeException();
				}
			}
		}

		public int Length {
			get { return 2; }
		}

		public ValueTuple(T1 item1, T2 item2) {
			Item1 = item1;
			Item2 = item2;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is ValueTuple<T1, T2>) == false) {
				return false;
			}
			ValueTuple<T1, T2> other = (ValueTuple<T1, T2>)obj;
			for (int i = 0; i < Length; i++) {
				if (this[i].Equals(other[i]) == false) {
					return false;
				}
			}
			return true;
		}

		public bool Equals(ValueTuple<T1, T2> other) {
			for (int i = 0; i < Length; i++) {
				if (this[i].Equals(other[i]) == false) {
					return false;
				}
			}
			return true;
		}

		public override int GetHashCode() {
			int hashCode = 0;
			for (int i = 0; i < Length; i++) {
				object item = this[i];
				if (item == null) {
					continue;
				}
				hashCode += item.GetHashCode();
			}
			return hashCode;
		}

		public override string ToString() {
			return string.Format("({0}, {1})", Item1, Item2);
		}

		public int CompareTo(object obj) {
			if (obj == null || (obj is ValueTuple<T1, T2>) == false) {
				throw new ArgumentException("obj is not ValueTuple");
			}
			return CompareTo((ValueTuple<T1, T2>)obj);
		}

		public int CompareTo(ValueTuple<T1, T2> other) {
			int result = Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (result != 0) {
				return result;
			}
			return Comparer<T2>.Default.Compare(Item2, other.Item2);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is ValueTuple<T1, T2>) == false) {
				throw new ArgumentException("other is not ValueTuple");
			}
			return comparer.Compare(this, other);
		}

		public bool Equals(object other, IEqualityComparer comparer) {
			return comparer.Equals(this, other);
		}

		public int GetHashCode(IEqualityComparer comparer) {
			return comparer.GetHashCode(this);
		}
	}

	public struct ValueTuple<T1, T2, T3> :
		IComparable, IComparable<ValueTuple<T1, T2, T3>>,
		IEquatable<ValueTuple<T1, T2, T3>>,
		IStructuralComparable, IStructuralEquatable, ITuple
	{
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;

		public object this[int index] {
			get {
				switch (index) {
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					default: throw new IndexOutOfRangeException();
				}
			}
		}

		public int Length {
			get { return 3; }
		}

		public ValueTuple(T1 item1, T2 item2, T3 item3) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is ValueTuple<T1, T2, T3>) == false) {
				return false;
			}
			ValueTuple<T1, T2, T3> other = (ValueTuple<T1, T2, T3>)obj;
			for (int i = 0; i < Length; i++) {
				if (this[i].Equals(other[i]) == false) {
					return false;
				}
			}
			return true;
		}

		public bool Equals(ValueTuple<T1, T2, T3> other) {
			for (int i = 0; i < Length; i++) {
				if (this[i].Equals(other[i]) == false) {
					return false;
				}
			}
			return true;
		}

		public override int GetHashCode() {
			int hashCode = 0;
			for (int i = 0; i < Length; i++) {
				object item = this[i];
				if (item == null) {
					continue;
				}
				hashCode += item.GetHashCode();
			}
			return hashCode;
		}

		public override string ToString() {
			return string.Format("({0}, {1})", Item1, Item2);
		}

		public int CompareTo(object obj) {
			if (obj == null || (obj is ValueTuple<T1, T2, T3>) == false) {
				throw new ArgumentException("obj is not ValueTuple");
			}
			return CompareTo((ValueTuple<T1, T2, T3>)obj);
		}

		public int CompareTo(ValueTuple<T1, T2, T3> other) {
			int result = Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (result != 0) {
				return result;
			}
			return Comparer<T2>.Default.Compare(Item2, other.Item2);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is ValueTuple<T1, T2, T3>) == false) {
				throw new ArgumentException("other is not ValueTuple");
			}
			return comparer.Compare(this, other);
		}

		public bool Equals(object other, IEqualityComparer comparer) {
			return comparer.Equals(this, other);
		}

		public int GetHashCode(IEqualityComparer comparer) {
			return comparer.GetHashCode(this);
		}
	}
}
#endif // NET20 || NET35 || NET40 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462
