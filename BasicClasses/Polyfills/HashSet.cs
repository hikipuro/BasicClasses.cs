#if NET20
namespace BasicClasses.Polyfills {
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	public class HashSet<T> :
		ICollection<T>,
		IEnumerable<T>,
		IReadOnlyCollection<T>,
		ISet<T>,
		IDeserializationCallback,
		ISerializable
	{
		Dictionary<T, byte> _list;

		public int Count {
			get { return _list.Count; }
		}

		public IEqualityComparer<T> Comparer {
			get {
				throw new NotImplementedException();
			}
		}

		public bool IsReadOnly {
			get { return false; }
		}

		public HashSet() {
			_list = new Dictionary<T, byte>();
		}

		public HashSet(IEnumerable<T> collection) : this() {
			if (collection == null) {
				throw new ArgumentNullException("collection");
			}
			foreach (T item in collection) {
				_list.Add(item, 0);
			}
		}

		public HashSet(IEqualityComparer<T> comparer) {
			throw new NotImplementedException();
		}

		public HashSet(int capacity) {
			_list = new Dictionary<T, byte>(capacity);
		}

		public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer) {
			throw new NotImplementedException();
		}

		public HashSet(int capacity, IEqualityComparer<T> comparer) {
			throw new NotImplementedException();
		}

		protected HashSet(SerializationInfo info, StreamingContext context) {
			throw new NotImplementedException();
		}

		public static IEqualityComparer<HashSet<T>> CreateSetComparer() {
			return new EqualityComparer();
		}

		public bool Add(T item) {
			if (_list.ContainsKey(item)) {
				return false;
			}
			_list.Add(item, 0);
			return true;
		}

		public void Clear() {
			_list.Clear();
		}

		public bool Contains(T item) {
			try {
				return _list.ContainsKey(item);
			} catch (Exception) {
				return false;
			}
		}

		public void CopyTo(T[] array) {
			if (array == null) {
				throw new ArgumentNullException("array");
			}
			int i = 0;
			foreach (T item in _list.Keys) {
				if (i >= array.Length) {
					break;
				}
				array[i++] = item;
			}
		}

		public void CopyTo(T[] array, int arrayIndex) {
			if (array == null) {
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0) {
				throw new ArgumentOutOfRangeException("arrayIndex");
			}
			if (arrayIndex >= array.Length) {
				throw new ArgumentException();
			}
			int i = arrayIndex;
			foreach (T item in _list.Keys) {
				if (i >= array.Length) {
					break;
				}
				array[i++] = item;
			}
		}

		public void CopyTo(T[] array, int arrayIndex, int count) {
			if (array == null) {
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0) {
				throw new ArgumentOutOfRangeException("arrayIndex");
			}
			if (count < 0) {
				throw new ArgumentOutOfRangeException("count");
			}
			if (arrayIndex + count >= array.Length) {
				throw new ArgumentException();
			}
			count += arrayIndex;
			int i = arrayIndex;
			foreach (T item in _list.Keys) {
				if (i >= count) {
					break;
				}
				array[i++] = item;
			}
		}

		public int EnsureCapacity(int capacity) {
			return capacity;
		}

		public void ExceptWith(IEnumerable<T> other) {
			if (other == null) {
				throw new ArgumentNullException("other");
			}
			foreach (T item in other) {
				_list.Remove(item);
			}
		}

		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {
			throw new NotImplementedException();
		}

		public void IntersectWith(IEnumerable<T> other) {
			if (other == null) {
				throw new ArgumentNullException("other");
			}
			List<T> removeList = new List<T>();
			foreach (T item in _list.Keys) {
				bool contains = false;
				foreach (T otherItem in other) {
					if (otherItem.Equals(item)) {
						contains = true;
						break;
					}
				}
				if (contains == false) {
					removeList.Add(item);
				}
			}
			foreach (T item in removeList) {
				_list.Remove(item);
			}
		}

		public bool IsProperSubsetOf(IEnumerable<T> other) {
			if (other == null) {
				throw new ArgumentNullException("other");
			}
			HashSet<T> otherSet = new HashSet<T>(other);
			if (otherSet.Count <= Count) {
				return false;
			}
			foreach (T item in _list.Keys) {
				if (otherSet.Contains(item)) {
					continue;
				}
				return false;
			}
			return true;
		}

		public bool IsProperSupersetOf(IEnumerable<T> other) {
			if (other == null) {
				throw new ArgumentNullException("other");
			}
			int count = 0;
			foreach (T item in other) {
				if (Contains(item)) {
					count++;
					continue;
				}
				return false;
			}
			return count < Count;
		}

		public bool IsSubsetOf(IEnumerable<T> other) {
			if (other == null) {
				throw new ArgumentNullException("other");
			}
			HashSet<T> otherSet = new HashSet<T>(other);
			foreach (T item in _list.Keys) {
				if (otherSet.Contains(item)) {
					continue;
				}
				return false;
			}
			return true;
		}

		public bool IsSupersetOf(IEnumerable<T> other) {
			if (other == null) {
				throw new ArgumentNullException("other");
			}
			foreach (T item in other) {
				if (Contains(item)) {
					continue;
				}
				return false;
			}
			return true;
		}

		public virtual void OnDeserialization(object sender) {
			throw new NotImplementedException();
		}

		public bool Overlaps(IEnumerable<T> other) {
			if (other == null) {
				throw new ArgumentNullException("other");
			}
			foreach (T item in other) {
				if (Contains(item)) {
					return true;
				}
			}
			return false;
		}

		public bool Remove(T item) {
			return _list.Remove(item);
		}

		public int RemoveWhere(Predicate<T> match) {
			if (match == null) {
				throw new ArgumentNullException("match");
			}
			List<T> removeList = new List<T>();
			foreach (T item in _list.Keys) {
				if (match(item)) {
					removeList.Add(item);
				}
			}
			int count = 0;
			foreach (T item in removeList) {
				if (_list.Remove(item)) {
					count++;
				}
			}
			return count;
		}

		public bool SetEquals(IEnumerable<T> other) {
			if (other == null) {
				throw new ArgumentNullException("other");
			}
			int count = 0;
			foreach (T item in other) {
				if (_list.ContainsKey(item)) {
					count++;
					continue;
				}
				return false;
			}
			return Count == count;
		}

		public void SymmetricExceptWith(IEnumerable<T> other) {
			throw new NotImplementedException();
		}

		public void TrimExcess() {
		}

		public bool TryGetValue(T equalValue, out T actualValue) {
			if (_list.ContainsKey(equalValue)) {
				actualValue = equalValue;
				return true;
			}
			actualValue = default(T);
			return false;
		}

		public void UnionWith(IEnumerable<T> other) {
			if (other == null) {
				throw new ArgumentNullException("other");
			}
			foreach (T item in other) {
				Add(item);
			}
		}

		void ICollection<T>.Add(T item) {
			if (_list.ContainsKey(item)) {
				return;
			}
			_list.Add(item, 0);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator() {
			return new Enumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return new Enumerator(this);
		}

		public class EqualityComparer : IEqualityComparer<HashSet<T>> {
			internal EqualityComparer() {
			}

			public bool Equals(HashSet<T> x, HashSet<T> y) {
				if (x == null) {
					if (y == null) {
						return true;
					}
					return false;
				}
				if (y == null) {
					return false;
				}
				if (x.Count != y.Count) {
					return false;
				}
				foreach (T item in x._list.Keys) {
					if (y._list.ContainsKey(item)) {
						continue;
					}
					return false;
				}
				return false;
			}

			public int GetHashCode(HashSet<T> obj) {
				return obj.GetHashCode();
			}
		}

		public struct Enumerator : IEnumerator<T> {
			T[] _keys;
			int _index;
			T _current;

			public T Current {
				get { return _current; }
			}

			object IEnumerator.Current {
				get { return Current; }
			}

			internal Enumerator(HashSet<T> hashSet) {
				var keys = hashSet._list.Keys;
				_keys = new T[keys.Count];
				int i = 0;
				foreach (T item in keys) {
					_keys[i++] = item;
				}
				_index = 0;
				_current = default(T);
			}

			public void Dispose() {
			}

			public bool MoveNext() {
				if (_index >= _keys.Length) {
					return false;
				}
				_current = _keys[_index++];
				return true;
			}

			public void Reset() {
				_index = 0;
				_current = default(T);
			}
		}
	}
}
#endif // NET20
