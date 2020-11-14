#if NET20 || NET35
namespace System.Threading {
	using System.Collections.Generic;

	public class ThreadLocal<T> : IDisposable {
		public bool IsValueCreated {
			get {
				if (_isDisposed) {
					throw new ObjectDisposedException("this");
				}
				int id = Thread.CurrentThread.ManagedThreadId;
				try {
					Monitor.Enter(_values);
					return _values.ContainsKey(id);
				} finally {
					Monitor.Exit(_values);
				}
			}
		}
		public T Value {
			get {
				if (_isDisposed) {
					throw new ObjectDisposedException("this");
				}
				int id = Thread.CurrentThread.ManagedThreadId;
				try {
					Monitor.Enter(_values);
					if (_values.ContainsKey(id)) {
						return _values[id];
					}
					if (_valueFactory != null) {
						_values.Add(id, _valueFactory());
					} else {
						_values.Add(id, default(T));
					}
					return _values[id];
				} finally {
					Monitor.Exit(_values);
				}
			}
			set {
				if (_isDisposed) {
					throw new ObjectDisposedException("this");
				}
				int id = Thread.CurrentThread.ManagedThreadId;
				try {
					Monitor.Enter(_values);
					if (_values.ContainsKey(id)) {
						_values[id] = value;
					} else {
						_values.Add(id, value);
					}
				} finally {
					Monitor.Exit(_values);
				}
			}
		}
		//public IList<T> Values { get; }

		protected Dictionary<int, T> _values;
		protected Func<T> _valueFactory;
		bool _isDisposed;

		public ThreadLocal() {
			_values = new Dictionary<int, T>();
		}

		//public ThreadLocal(bool trackAllValues) {
		//}

		public ThreadLocal(Func<T> valueFactory) {
			if (valueFactory == null) {
				throw new ArgumentNullException("valueFactory");
			}
			_values = new Dictionary<int, T>();
			_valueFactory = valueFactory;
		}

		//public ThreadLocal(Func<T> valueFactory, bool trackAllValues) {
		//}

		~ThreadLocal() {
			Dispose(false);
		}

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing) {
			if (_isDisposed) {
				return;
			}
			if (disposing) {
				try {
					Monitor.Enter(_values);
					_values.Clear();
				} finally {
					Monitor.Exit(_values);
				}
			}
			_isDisposed = true;
		}

		public override string ToString() {
			if (_isDisposed) {
				throw new ObjectDisposedException("this");
			}
			if (Value == null) {
				throw new NullReferenceException();
			}
			return Value.ToString();
		}
	}
}
#endif // NET20 || NET35
