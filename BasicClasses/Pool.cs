namespace BasicClasses {
	using System;
	using System.Collections.Generic;
	using System.Threading;
	using Polyfills;

	[Serializable]
	public class Pool<T> where T : class, new() {
		public readonly int MaxCount;
		protected Queue<T> _unusedQueue;
		protected Func<int, T> _generator;
		protected HashSet<T> _list;

		public Pool(int maxCount, Func<int, T> generator = null) {
			if (maxCount <= 0) {
				throw new ArgumentOutOfRangeException("maxCount");
			}
			MaxCount = maxCount;
			_unusedQueue = new Queue<T>();
			_generator = generator;
			_list = new HashSet<T>();
		}

		public T Get() {
			try {
				Monitor.Enter(this);
				if (_unusedQueue.Count > 0) {
					return _unusedQueue.Dequeue();
				}
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
			} finally {
				Monitor.Exit(this);
			}
			/*
			throw new InvalidOperationException(
				"Pool object exceeds max count."
			);
			*/
			return null;
		}

		public void Return(T item) {
			try {
				Monitor.Enter(this);
				if (_list.Contains(item) == false) {
					return;
				}
				_unusedQueue.Enqueue(item);
			} finally {
				Monitor.Exit(this);
			}
		}
	}
}
