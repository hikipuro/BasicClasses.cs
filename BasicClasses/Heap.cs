using System;
using System.Collections.Generic;

namespace BasicClasses {
	[Serializable]
	public class Heap<T> where T : IComparable<T> {
		protected readonly List<T> _list;

		public int Count {
			get { return _list.Count; }
		}

		public Heap() {
			_list = new List<T>();
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

		public int Count {
			get { return _keys.Count; }
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

		public KeyValuePair<TKey, TValue> Pop() {
			List<TKey> k = _keys;
			List<TValue> v = _values;
			int lastIndex = k.Count - 1;
			if (lastIndex < 0) {
				return new KeyValuePair<TKey, TValue>();
			}
			KeyValuePair<TKey, TValue> result =
				new KeyValuePair<TKey, TValue>(k[0], v[0]);
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
	}
}
