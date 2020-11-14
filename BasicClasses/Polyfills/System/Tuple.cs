#if NET20 || NET35
namespace System {
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.CompilerServices;

	public static class Tuple {
		public static Tuple<T1> Create<T1>(T1 item1) {
			return new Tuple<T1>(item1);
		}

		public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) {
			return new Tuple<T1, T2>(item1, item2);
		}

		public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) {
			return new Tuple<T1, T2, T3>(item1, item2, item3);
		}

		public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4) {
			return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
		}

		public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) {
			return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
		}

		public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) {
			return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
		}

		public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) {
			return new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
		}

		public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) {
			return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>(item1, item2, item3, item4, item5, item6, item7, new Tuple<T8>(item8));
		}
	}

	public class Tuple<T1> :
		IComparable, IStructuralComparable, IStructuralEquatable, ITuple
	{
		public T1 Item1 { get; }

		public object this[int index] {
			get {
				if (index == 0) {
					return Item1;
				}
				throw new IndexOutOfRangeException();
			}
		}

		public int Length {
			get { return 1; }
		}

		public Tuple(T1 item1) {
			Item1 = item1;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is Tuple<T1>) == false) {
				return false;
			}
			Tuple<T1> other = obj as Tuple<T1>;
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
			if (obj == null || (obj is Tuple<T1>) == false) {
				throw new ArgumentException("obj is not Tuple");
			}
			Tuple<T1> other = obj as Tuple<T1>;
			return Comparer<T1>.Default.Compare(Item1, other.Item1);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is Tuple<T1>) == false) {
				throw new ArgumentException("obj is not Tuple");
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

	public class Tuple<T1, T2> :
		IComparable, IStructuralComparable, IStructuralEquatable, ITuple
	{
		public T1 Item1 { get; }
		public T2 Item2 { get; }

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

		public Tuple(T1 item1, T2 item2) {
			Item1 = item1;
			Item2 = item2;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is Tuple<T1, T2>) == false) {
				return false;
			}
			Tuple<T1, T2> other = obj as Tuple<T1, T2>;
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
			if (obj == null || (obj is Tuple<T1, T2>) == false) {
				throw new ArgumentException("obj is not Tuple");
			}
			Tuple<T1, T2> other = obj as Tuple<T1, T2>;
			int result = Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (result != 0) {
				return result;
			}
			return Comparer<T2>.Default.Compare(Item2, other.Item2);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is Tuple<T1, T2>) == false) {
				throw new ArgumentException("obj is not Tuple");
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

	public class Tuple<T1, T2, T3> :
		IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
		public T1 Item1 { get; }
		public T2 Item2 { get; }
		public T3 Item3 { get; }

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

		public Tuple(T1 item1, T2 item2, T3 item3) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3>) == false) {
				return false;
			}
			Tuple<T1, T2, T3> other = obj as Tuple<T1, T2, T3>;
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
			return string.Format("({0}, {1}, {2})", Item1, Item2, Item3);
		}

		public int CompareTo(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3>) == false) {
				throw new ArgumentException("obj is not Tuple");
			}
			Tuple<T1, T2, T3> other = obj as Tuple<T1, T2, T3>;
			int result = Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (result != 0) {
				return result;
			}
			result = Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (result != 0) {
				return result;
			}
			return Comparer<T3>.Default.Compare(Item3, other.Item3);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is Tuple<T1, T2, T3>) == false) {
				throw new ArgumentException("obj is not Tuple");
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

	public class Tuple<T1, T2, T3, T4> :
		IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
		public T1 Item1 { get; }
		public T2 Item2 { get; }
		public T3 Item3 { get; }
		public T4 Item4 { get; }

		public object this[int index] {
			get {
				switch (index) {
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					default: throw new IndexOutOfRangeException();
				}
			}
		}

		public int Length {
			get { return 4; }
		}

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3, T4>) == false) {
				return false;
			}
			Tuple<T1, T2, T3, T4> other = obj as Tuple<T1, T2, T3, T4>;
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
			return string.Format(
				"({0}, {1}, {2}, {3})",
				Item1, Item2, Item3, Item4
			);
		}

		public int CompareTo(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3, T4>) == false) {
				throw new ArgumentException("obj is not Tuple");
			}
			Tuple<T1, T2, T3, T4> other = obj as Tuple<T1, T2, T3, T4>;
			int result = Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (result != 0) {
				return result;
			}
			result = Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (result != 0) {
				return result;
			}
			result = Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (result != 0) {
				return result;
			}
			return Comparer<T4>.Default.Compare(Item4, other.Item4);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is Tuple<T1, T2, T3, T4>) == false) {
				throw new ArgumentException("obj is not Tuple");
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

	public class Tuple<T1, T2, T3, T4, T5> :
		IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
		public T1 Item1 { get; }
		public T2 Item2 { get; }
		public T3 Item3 { get; }
		public T4 Item4 { get; }
		public T5 Item5 { get; }

		public object this[int index] {
			get {
				switch (index) {
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					default: throw new IndexOutOfRangeException();
				}
			}
		}

		public int Length {
			get { return 5; }
		}

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3, T4, T5>) == false) {
				return false;
			}
			Tuple<T1, T2, T3, T4, T5> other = obj as Tuple<T1, T2, T3, T4, T5>;
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
			return string.Format(
				"({0}, {1}, {2}, {3}, {4})",
				Item1, Item2, Item3, Item4, Item5
			);
		}

		public int CompareTo(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3, T4, T5>) == false) {
				throw new ArgumentException("obj is not Tuple");
			}
			Tuple<T1, T2, T3, T4, T5> other = obj as Tuple<T1, T2, T3, T4, T5>;
			int result = Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (result != 0) {
				return result;
			}
			result = Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (result != 0) {
				return result;
			}
			result = Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (result != 0) {
				return result;
			}
			result = Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (result != 0) {
				return result;
			}
			return Comparer<T5>.Default.Compare(Item5, other.Item5);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is Tuple<T1, T2, T3, T4, T5>) == false) {
				throw new ArgumentException("obj is not Tuple");
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

	public class Tuple<T1, T2, T3, T4, T5, T6> :
		IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
		public T1 Item1 { get; }
		public T2 Item2 { get; }
		public T3 Item3 { get; }
		public T4 Item4 { get; }
		public T5 Item5 { get; }
		public T6 Item6 { get; }

		public object this[int index] {
			get {
				switch (index) {
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					default: throw new IndexOutOfRangeException();
				}
			}
		}

		public int Length {
			get { return 6; }
		}

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
			Item6 = item6;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3, T4, T5, T6>) == false) {
				return false;
			}
			Tuple<T1, T2, T3, T4, T5, T6> other = obj as Tuple<T1, T2, T3, T4, T5, T6>;
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
			return string.Format(
				"({0}, {1}, {2}, {3}, {4}, {5})",
				Item1, Item2, Item3, Item4, Item5, Item6
			);
		}

		public int CompareTo(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3, T4, T5, T6>) == false) {
				throw new ArgumentException("obj is not Tuple");
			}
			Tuple<T1, T2, T3, T4, T5, T6> other = obj as Tuple<T1, T2, T3, T4, T5, T6>;
			int result = Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (result != 0) {
				return result;
			}
			result = Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (result != 0) {
				return result;
			}
			result = Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (result != 0) {
				return result;
			}
			result = Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (result != 0) {
				return result;
			}
			result = Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (result != 0) {
				return result;
			}
			return Comparer<T6>.Default.Compare(Item6, other.Item6);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is Tuple<T1, T2, T3, T4, T5, T6>) == false) {
				throw new ArgumentException("obj is not Tuple");
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

	public class Tuple<T1, T2, T3, T4, T5, T6, T7> :
		IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
		public T1 Item1 { get; }
		public T2 Item2 { get; }
		public T3 Item3 { get; }
		public T4 Item4 { get; }
		public T5 Item5 { get; }
		public T6 Item6 { get; }
		public T7 Item7 { get; }

		public object this[int index] {
			get {
				switch (index) {
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					case 6: return Item7;
					default: throw new IndexOutOfRangeException();
				}
			}
		}

		public int Length {
			get { return 7; }
		}

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
			Item6 = item6;
			Item7 = item7;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3, T4, T5, T6, T7>) == false) {
				return false;
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7> other = obj as Tuple<T1, T2, T3, T4, T5, T6, T7>;
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
			return string.Format(
				"({0}, {1}, {2}, {3}, {4}, {5}, {6})",
				Item1, Item2, Item3, Item4, Item5, Item6, Item7
			);
		}

		public int CompareTo(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3, T4, T5, T6, T7>) == false) {
				throw new ArgumentException("obj is not Tuple");
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7> other = obj as Tuple<T1, T2, T3, T4, T5, T6, T7>;
			int result = Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (result != 0) {
				return result;
			}
			result = Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (result != 0) {
				return result;
			}
			result = Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (result != 0) {
				return result;
			}
			result = Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (result != 0) {
				return result;
			}
			result = Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (result != 0) {
				return result;
			}
			result = Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (result != 0) {
				return result;
			}
			return Comparer<T7>.Default.Compare(Item7, other.Item7);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is Tuple<T1, T2, T3, T4, T5, T6, T7>) == false) {
				throw new ArgumentException("obj is not Tuple");
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

	public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> :
		IComparable, IStructuralComparable, IStructuralEquatable, ITuple {
		public T1 Item1 { get; }
		public T2 Item2 { get; }
		public T3 Item3 { get; }
		public T4 Item4 { get; }
		public T5 Item5 { get; }
		public T6 Item6 { get; }
		public T7 Item7 { get; }
		public TRest Rest { get; }

		public object this[int index] {
			get {
				if (index < 0) {
					throw new IndexOutOfRangeException();
				}
				switch (index) {
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					case 6: return Item7;
				}
				if (Rest is ITuple) {
					return ((ITuple)Rest)[index - 7];
				}
				return Rest;
			}
		}

		public int Length {
			get {
				if (Rest is ITuple) {
					return 7 + ((ITuple)Rest).Length;
				}
				return 8;
			}
		}

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
			Item6 = item6;
			Item7 = item7;
			Rest = rest;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>) == false) {
				return false;
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> other = obj as Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>;
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
			return string.Format(
				"({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})",
				Item1, Item2, Item3, Item4, Item5, Item6, Item7, Rest
			);
		}

		public int CompareTo(object obj) {
			if (obj == null || (obj is Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>) == false) {
				throw new ArgumentException("obj is not Tuple");
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> other = obj as Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>;
			int result = Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (result != 0) {
				return result;
			}
			result = Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (result != 0) {
				return result;
			}
			result = Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (result != 0) {
				return result;
			}
			result = Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (result != 0) {
				return result;
			}
			result = Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (result != 0) {
				return result;
			}
			result = Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (result != 0) {
				return result;
			}
			result = Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (result != 0) {
				return result;
			}
			return Comparer<TRest>.Default.Compare(Rest, other.Rest);
		}

		public int CompareTo(object other, IComparer comparer) {
			if (other == null || (other is Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>) == false) {
				throw new ArgumentException("obj is not Tuple");
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
#endif // NET20 || NET35
