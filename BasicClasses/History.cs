namespace BasicClasses {
	using System;
	using System.Collections.Generic;
	using System.Threading;

	[Serializable]
	public class History<T> where T : class {
		public readonly int MaxCount;
		protected readonly List<T> _list;
		protected int _index;

		public History(int maxCount = 100) {
			if (maxCount <= 0) {
				throw new ArgumentOutOfRangeException("maxCount");
			}
			MaxCount = maxCount;
			_list = new List<T>();
			_index = -1;
		}

		public void Clear() {
			try {
				Monitor.Enter(this);
				_list.Clear();
				_index = -1;
			} finally {
				Monitor.Exit(this);
			}
		}

		public void Add(T value) {
			if (value == null) {
				return;
			}
			try {
				Monitor.Enter(this);
				if (_index < _list.Count - 1) {
					int i = _index + 1;
					_list.RemoveRange(i, _list.Count - i);
				}
				if (_list.Count > MaxCount) {
					_list.RemoveAt(0);
				}
				_list.Add(value);
				_index = _list.Count - 1;
			} finally {
				Monitor.Exit(this);
			}
		}

		public T Undo() {
			try {
				Monitor.Enter(this);
				if (_index <= 0 || _list.Count <= 0) {
					return null;
				}
				_index--;
				return _list[_index];
			} finally {
				Monitor.Exit(this);
			}
		}

		public T Redo() {
			try {
				Monitor.Enter(this);
				if (_index + 1 >= _list.Count) {
					return null;
				}
				_index++;
				return _list[_index];
			} finally {
				Monitor.Exit(this);
			}
		}

		public T Peek() {
			try {
				Monitor.Enter(this);
				if (_index < 0 || _list.Count <= 0) {
					return null;
				}
				return _list[_index];
			} finally {
				Monitor.Exit(this);
			}
		}
	}
}
