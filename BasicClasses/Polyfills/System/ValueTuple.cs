#if NET20 || NET35 || NET40 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462
namespace System {
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.CompilerServices;

	public struct ValueTuple :
		IComparable, IComparable<ValueTuple>, IEquatable<ValueTuple>,
		IStructuralComparable, IStructuralEquatable, ITuple
	{
		public object this[int index] {
			get { throw new IndexOutOfRangeException(); }
		}

		public int Length {
			get { return 0; }
		}

		public static ValueTuple Create() {
			return new ValueTuple();
		}

		public static ValueTuple<T1> Create<T1>(T1 item1) {
			return new ValueTuple<T1>(item1);
		}

		public static ValueTuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) {
			return new ValueTuple<T1, T2>(item1, item2);
		}

		public static ValueTuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) {
			return new ValueTuple<T1, T2, T3>(item1, item2, item3);
		}

		public static ValueTuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4) {
			return new ValueTuple<T1, T2, T3, T4>(item1, item2, item3, item4);
		}

		public static ValueTuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) {
			return new ValueTuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
		}

		public static ValueTuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) {
			return new ValueTuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
		}

		public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) {
			return new ValueTuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
		}

		public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) {
			return new ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8>>(item1, item2, item3, item4, item5, item6, item7, new ValueTuple<T8>(item8));
		}

		public int CompareTo(ValueTuple other) {
			return 0;
		}

		public bool Equals(ValueTuple other) {
			return true;
		}

		public override bool Equals(object obj) {
			return obj is ValueTuple;
		}

		public override int GetHashCode() {
			return 0;
		}

		public override string ToString() {
			return "()";
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer) {
			if (other == null) {
				return 1;
			}
			if (other is ValueTuple) {
				return 0;
			}
			throw new ArgumentException();
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) {
			return comparer.Equals(this, other);
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			return comparer.GetHashCode(this);
		}

		int IComparable.CompareTo(object other) {
			if (other == null) {
				return 1;
			}
			if (other is ValueTuple) {
				return 0;
			}
			throw new ArgumentException();
		}
	}

	public struct ValueTuple<T1> :
		IComparable, IComparable<ValueTuple<T1>>, IEquatable<ValueTuple<T1>>,
		IStructuralComparable,IStructuralEquatable, ITuple
	{
		public T1 Item1;

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
			return string.Format("({0}, {1}, {2})", Item1, Item2, Item3);
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
			result = Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (result != 0) {
				return result;
			}
			return Comparer<T3>.Default.Compare(Item3, other.Item3);
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

	public struct ValueTuple<T1, T2, T3, T4> :
		IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>,
		IEquatable<ValueTuple<T1, T2, T3, T4>>,
		IStructuralComparable, IStructuralEquatable, ITuple
	{
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;

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

		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is ValueTuple<T1, T2, T3, T4>) == false) {
				return false;
			}
			ValueTuple<T1, T2, T3, T4> other = (ValueTuple<T1, T2, T3, T4>)obj;
			for (int i = 0; i < Length; i++) {
				if (this[i].Equals(other[i]) == false) {
					return false;
				}
			}
			return true;
		}

		public bool Equals(ValueTuple<T1, T2, T3, T4> other) {
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
			if (obj == null || (obj is ValueTuple<T1, T2, T3, T4>) == false) {
				throw new ArgumentException("obj is not ValueTuple");
			}
			return CompareTo((ValueTuple<T1, T2, T3, T4>)obj);
		}

		public int CompareTo(ValueTuple<T1, T2, T3, T4> other) {
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
			if (other == null || (other is ValueTuple<T1, T2, T3, T4>) == false) {
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

	public struct ValueTuple<T1, T2, T3, T4, T5> :
		IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>,
		IEquatable<ValueTuple<T1, T2, T3, T4, T5>>,
		IStructuralComparable, IStructuralEquatable, ITuple
	{
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;

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

		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is ValueTuple<T1, T2, T3, T4, T5>) == false) {
				return false;
			}
			ValueTuple<T1, T2, T3, T4, T5> other = (ValueTuple<T1, T2, T3, T4, T5>)obj;
			for (int i = 0; i < Length; i++) {
				if (this[i].Equals(other[i]) == false) {
					return false;
				}
			}
			return true;
		}

		public bool Equals(ValueTuple<T1, T2, T3, T4, T5> other) {
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
			if (obj == null || (obj is ValueTuple<T1, T2, T3, T4, T5>) == false) {
				throw new ArgumentException("obj is not ValueTuple");
			}
			return CompareTo((ValueTuple<T1, T2, T3, T4, T5>)obj);
		}

		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other) {
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
			if (other == null || (other is ValueTuple<T1, T2, T3, T4, T5>) == false) {
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

	public struct ValueTuple<T1, T2, T3, T4, T5, T6> :
		IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6>>,
		IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6>>,
		IStructuralComparable, IStructuralEquatable, ITuple
	{
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;

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

		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
			Item6 = item6;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is ValueTuple<T1, T2, T3, T4, T5, T6>) == false) {
				return false;
			}
			ValueTuple<T1, T2, T3, T4, T5, T6> other = (ValueTuple<T1, T2, T3, T4, T5, T6>)obj;
			for (int i = 0; i < Length; i++) {
				if (this[i].Equals(other[i]) == false) {
					return false;
				}
			}
			return true;
		}

		public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6> other) {
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
			if (obj == null || (obj is ValueTuple<T1, T2, T3, T4, T5, T6>) == false) {
				throw new ArgumentException("obj is not ValueTuple");
			}
			return CompareTo((ValueTuple<T1, T2, T3, T4, T5, T6>)obj);
		}

		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6> other) {
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
			if (other == null || (other is ValueTuple<T1, T2, T3, T4, T5, T6>) == false) {
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

	public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7> :
		IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>,
		IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>,
		IStructuralComparable, IStructuralEquatable, ITuple
	{
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;

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

		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) {
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
			Item6 = item6;
			Item7 = item7;
		}

		public override bool Equals(object obj) {
			if (obj == null || (obj is ValueTuple<T1, T2, T3, T4, T5, T6, T7>) == false) {
				return false;
			}
			ValueTuple<T1, T2, T3, T4, T5, T6, T7> other = (ValueTuple<T1, T2, T3, T4, T5, T6, T7>)obj;
			for (int i = 0; i < Length; i++) {
				if (this[i].Equals(other[i]) == false) {
					return false;
				}
			}
			return true;
		}

		public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) {
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
			if (obj == null || (obj is ValueTuple<T1, T2, T3, T4, T5, T6, T7>) == false) {
				throw new ArgumentException("obj is not ValueTuple");
			}
			return CompareTo((ValueTuple<T1, T2, T3, T4, T5, T6, T7>)obj);
		}

		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) {
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
			if (other == null || (other is ValueTuple<T1, T2, T3, T4, T5, T6, T7>) == false) {
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

	public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> :
		IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>,
		IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>,
		IStructuralComparable, IStructuralEquatable, ITuple {
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public TRest Rest;

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
			get { return 8; }
		}

		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) {
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
			if (obj == null || (obj is ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>) == false) {
				return false;
			}
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other = (ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>)obj;
			for (int i = 0; i < Length; i++) {
				if (this[i].Equals(other[i]) == false) {
					return false;
				}
			}
			return true;
		}

		public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) {
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
			if (obj == null || (obj is ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>) == false) {
				throw new ArgumentException("obj is not ValueTuple");
			}
			return CompareTo((ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>)obj);
		}

		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) {
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
			if (other == null || (other is ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>) == false) {
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
