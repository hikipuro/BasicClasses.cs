namespace BasicClasses {
	using System;
	using System.Collections.Generic;

	[Serializable]
	public class Heap<T> where T : IComparable<T> {
		protected readonly List<T> _list;

		public bool IsEmpty {
			get { return _list.Count <= 0; }
		}

		public int Count {
			get { return _list.Count; }
		}

		public T Min {
			get {
				if (_list.Count <= 0) {
					return default(T);
				}
				return _list[0];
			}
		}

		public Heap() {
			_list = new List<T>();
		}

		public Heap(params T[] args) {
			_list = new List<T>();
			if (args == null) {
				return;
			}
			foreach (T item in args) {
				Push(item);
			}
		}

		public Heap(IEnumerable<T> collection) {
			_list = new List<T>();
			if (collection == null) {
				throw new ArgumentNullException("collection");
			}
			foreach (T item in collection) {
				Push(item);
			}
		}

		protected Heap(List<T> list, bool protect) {
			_list = list;
		}

		public Heap<T> Clone() {
			T[] array = new T[_list.Count];
			_list.CopyTo(array, 0);
			Heap<T> heap = new Heap<T>(new List<T>(array), true);
			return heap;
		}

		public Heap<T> Merge(Heap<T> heap) {
			if (heap == null) {
				throw new ArgumentNullException("heap");
			}
			Heap<T> newHeap = Clone();
			foreach (T item in heap._list) {
				newHeap.Push(item);
			}
			return newHeap;
		}

		public Heap<T> Merge(IEnumerable<T> collection) {
			if (collection == null) {
				throw new ArgumentNullException("collection");
			}
			Heap<T> heap = Clone();
			foreach (T item in collection) {
				heap.Push(item);
			}
			return heap;
		}

		public void Traverse(Func<T, bool> callback) {
			if (callback == null) {
				throw new ArgumentNullException("callback");
			}
			foreach (T item in _list) {
				if (callback(item) == false) {
					break;
				}
			}
		}

		public void Push(T key) {
			List<T> a = _list;
			int i = a.Count;
			a.Add(key);
			if (i <= 0) {
				return;
			}
			int pi = (i - 1) >> 1;
			while (true) {
				if (a[i].CompareTo(a[pi]) >= 0) {
					break;
				}
				T temp = a[i];
				a[i] = a[pi];
				a[pi] = temp;
				if (pi <= 0) {
					break;
				}
				i = pi;
				pi = (i - 1) >> 1;
			}
		}

		public T Pop() {
			List<T> a = _list;
			int lastIndex = a.Count - 1;
			if (lastIndex < 0) {
				return default(T);
			}
			T result = a[0];
			a[0] = a[lastIndex];
			a.RemoveAt(lastIndex);
			if (lastIndex == 0) {
				return result;
			}
			int i = 0;
			while (true) {
				int li = (i << 1) + 1;
				int ri = (i << 1) + 2;
				if (ri >= lastIndex) {
					if (li >= lastIndex) {
						break;
					}
					if (a[i].CompareTo(a[li]) > 0) {
						T temp = a[i];
						a[i] = a[li];
						a[li] = temp;
						break;
					}
					break;
				}
				if (a[li].CompareTo(a[ri]) < 0) {
					if (a[i].CompareTo(a[li]) <= 0) {
						return result;
					}
					T temp = a[i];
					a[i] = a[li];
					a[li] = temp;
					i = li;
				} else {
					if (a[i].CompareTo(a[ri]) <= 0) {
						return result;
					}
					T temp = a[i];
					a[i] = a[ri];
					a[ri] = temp;
					i = ri;
				}
			}
			return result;
		}
	}

	[Serializable]
	public class Heap<TKey, TValue> where TKey : IComparable<TKey> {
		protected readonly List<TKey> _keys;
		protected readonly List<TValue> _values;

		public bool IsEmpty {
			get { return _keys.Count <= 0; }
		}

		public int Count {
			get { return _keys.Count; }
		}

		public Node Min {
			get {
				if (_keys.Count <= 0) {
					return null;
				}
				return new Node(_keys[0], _values[0]);
			}
		}

		public Heap() {
			_keys = new List<TKey>();
			_values = new List<TValue>();
		}

		public void Traverse(Func<TKey, TValue, bool> callback) {
			if (callback == null) {
				throw new ArgumentNullException("callback");
			}
			for (int i = 0; i < _keys.Count; i++) {
				if (callback(_keys[i], _values[i]) == false) {
					break;
				}
			}
		}

		public void Push(TKey key, TValue value) {
			List<TKey> k = _keys;
			List<TValue> v = _values;
			int i = k.Count;
			k.Add(key);
			v.Add(value);
			if (i <= 0) {
				return;
			}
			int pi = (i - 1) >> 1;
			while (true) {
				if (k[i].CompareTo(k[pi]) >= 0) {
					break;
				}
				TKey tempKey = k[i];
				k[i] = k[pi];
				k[pi] = tempKey;

				TValue tempValue = v[i];
				v[i] = v[pi];
				v[pi] = tempValue;

				if (pi <= 0) {
					break;
				}
				i = pi;
				pi = (i - 1) >> 1;
			}
		}

		public Node Pop() {
			List<TKey> k = _keys;
			List<TValue> v = _values;
			int lastIndex = k.Count - 1;
			if (lastIndex < 0) {
				return null;
			}
			Node result = new Node(k[0], v[0]);
			k[0] = k[lastIndex];
			k.RemoveAt(lastIndex);
			v[0] = v[lastIndex];
			v.RemoveAt(lastIndex);
			if (lastIndex == 0) {
				return result;
			}
			int i = 0;
			while (true) {
				int li = (i << 1) + 1;
				int ri = (i << 1) + 2;
				if (ri >= lastIndex) {
					if (li >= lastIndex) {
						break;
					}
					if (k[i].CompareTo(k[li]) > 0) {
						TKey tempKey = k[i];
						k[i] = k[li];
						k[li] = tempKey;

						TValue tempValue = v[i];
						v[i] = v[li];
						v[li] = tempValue;
						break;
					}
					break;
				}
				if (k[li].CompareTo(k[ri]) < 0) {
					if (k[i].CompareTo(k[li]) <= 0) {
						return result;
					}
					TKey tempKey = k[i];
					k[i] = k[li];
					k[li] = tempKey;

					TValue tempValue = v[i];
					v[i] = v[li];
					v[li] = tempValue;
					i = li;
				} else {
					if (k[i].CompareTo(k[ri]) <= 0) {
						return result;
					}
					TKey tempKey = k[i];
					k[i] = k[ri];
					k[ri] = tempKey;

					TValue tempValue = v[i];
					v[i] = v[ri];
					v[ri] = tempValue;
					i = ri;
				}
			}
			return result;
		}

		public class Node {
			public TKey Key;
			public TValue Value;

			public Node(TKey key, TValue value) {
				Key = key;
				Value = value;
			}

			public override string ToString() {
				return string.Format("{0}, {1}", Key, Value);
			}
		}
	}
}
