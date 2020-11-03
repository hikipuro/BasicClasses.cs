using System;
using System.Collections.Generic;

namespace BasicClasses {

	public class Pool<T> where T : class, new() {
		public readonly int MaxCount;
		protected Queue<T> _unusedQueue;
		protected Func<int, T> _generator;

#if NET20
		public delegate TResult Func<T1, TResult>(T1 arg);
		protected List<T> _list = new List<T>();
#else
		protected HashSet<T> _list = new HashSet<T>();
#endif

		public Pool(int maxCount, Func<int, T> generator = null) {
			if (maxCount <= 0) {
				throw new ArgumentOutOfRangeException("maxCount");
			}
			MaxCount = maxCount;
			_unusedQueue = new Queue<T>();
			_generator = generator;
		}

		public T Get() {
			lock (_unusedQueue) {
				if (_unusedQueue.Count > 0) {
					return _unusedQueue.Dequeue();
				}
			}
			lock (_list) {
				if (_list.Count < MaxCount) {
					T item;
					if (_generator == null) {
						item = new T();
					} else {
						item = _generator(_list.Count);
					}
					_list.Add(item);
					return item;
				}
			}
			/*
			throw new InvalidOperationException(
				"Pool object exceeds max count."
			);
			*/
			return null;
		}

		public void Return(T item) {
			lock (_list) {
				if (_list.Contains(item) == false) {
					return;
				}
			}
			lock (_unusedQueue) {
				_unusedQueue.Enqueue(item);
			}
		}
	}
}
