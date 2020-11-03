using System;
using System.Collections.Generic;

namespace BasicClasses {
	[Serializable]
	public class Heap<T> where T : IComparable<T> {
		protected List<T> _list;

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
}
