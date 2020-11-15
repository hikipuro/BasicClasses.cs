namespace BasicClasses {
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class SparseArray<T> :
		ICloneable,
		IEnumerable<KeyValuePair<int, T>>
	{
		readonly Dictionary<int, T> _dictionary;

		public T this[int index] {
			get {
				if (_dictionary.TryGetValue(index, out T value)) {
					return value;
				}
				return default(T);
			}
			set {
				if (_dictionary.ContainsKey(index)) {
					_dictionary[index] = value;
					return;
				}
				_dictionary.Add(index, value);
			}
		}

		public int Count {
			get { return _dictionary.Count; }
		}

		public SparseArray() {
			_dictionary = new Dictionary<int, T>();
		}

		public void Clear() {
			_dictionary.Clear();
		}

		public object Clone() {
			SparseArray<T> array = new SparseArray<T>();
			foreach (KeyValuePair<int, T> item in _dictionary) {
				array._dictionary.Add(item.Key, item.Value);
			}
			return array;
		}

		public bool TryGetValue(int index, out T value) {
			return _dictionary.TryGetValue(index, out value);
		}

		public bool HasKey(int index) {
			return _dictionary.ContainsKey(index);
		}

		public bool HasValue(T value) {
			return _dictionary.ContainsValue(value);
		}

		public bool Remove(int index) {
			return _dictionary.Remove(index);
		}

		public void RemoveRange(int start, int count) {
			int end = start + count;
			for (int i = start; i < end; i++) {
				_dictionary.Remove(i);
			}
		}

		public IEnumerator<KeyValuePair<int, T>> GetEnumerator() {
			return new Enumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return new Enumerator(this);
		}

		public struct Enumerator :
			IEnumerator<KeyValuePair<int, T>>, IEnumerator
		{
			readonly SparseArray<T> _array;
			readonly int[] _keys;
			int _index;
			KeyValuePair<int, T> _current;

			public KeyValuePair<int, T> Current {
				get { return _current; }
			}
			object IEnumerator.Current {
				get { return Current; }
			}

			internal Enumerator(SparseArray<T> array) {
				_array = array;
				var keys = _array._dictionary.Keys;
				_keys = new int[keys.Count];
				keys.CopyTo(_keys, 0);
				Array.Sort(_keys);
				_index = 0;
				_current = new KeyValuePair<int, T>();
			}

			public void Dispose() {
			}

			public bool MoveNext() {
				if (_index >= _array.Count) {
					return false;
				}
				int key = _keys[_index++];
				_current = new KeyValuePair<int, T>(
					key, _array._dictionary[key]
				);
				return true;
			}

			public void Reset() {
				_index = 0;
				_current = new KeyValuePair<int, T>();
			}
		}
	}
}
