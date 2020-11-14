#if NET20 || NET35
namespace System {
	using System.Threading;

	public class Lazy<T> {
		public bool IsValueCreated {
			get; private set;
		}

		public T Value {
			get {
				switch (_mode) {
					case LazyThreadSafetyMode.None:
						if (IsValueCreated) {
							return _value;
						}
						if (_valueFactory != null) {
							if (_cachedException != null) {
								throw _cachedException;
							}
							try {
								_value = _valueFactory();
							} catch (Exception e) {
								_cachedException = e;
								throw e;
							}
						} else {
							_value = default(T);
						}
						IsValueCreated = true;
						return _value;
					case LazyThreadSafetyMode.PublicationOnly:
						if (IsValueCreated) {
							return _value;
						}
						try {
							Monitor.Enter(_lock);
							T value;
							if (_valueFactory != null) {
								value = _valueFactory();
							} else {
								value = default(T);
							}
							if (IsValueCreated) {
								return _value;
							}
							_value = value;
							IsValueCreated = true;
							return _value;
						} finally {
							Monitor.Exit(_lock);
						}
					case LazyThreadSafetyMode.ExecutionAndPublication:
						try {
							Monitor.Enter(_lock);
							if (IsValueCreated) {
								return _value;
							}
							if (_valueFactory != null) {
								if (_cachedException != null) {
									throw _cachedException;
								}
								try {
									_value = _valueFactory();
								} catch (Exception e) {
									_cachedException = e;
									throw e;
								}
							} else {
								_value = default(T);
							}
							IsValueCreated = true;
							return _value;
						} finally {
							Monitor.Exit(_lock);
						}
				}
				return _value;
			}
		}

		object _lock;
		T _value;
		Func<T> _valueFactory;
		LazyThreadSafetyMode _mode;
		Exception _cachedException;

		public Lazy() {
			_lock = new object();
			_mode = LazyThreadSafetyMode.ExecutionAndPublication;
		}

		public Lazy(bool isThreadSafe) {
			if (isThreadSafe) {
				_lock = new object();
				_mode = LazyThreadSafetyMode.ExecutionAndPublication;
			} else {
				_mode = LazyThreadSafetyMode.None;
			}
		}

		public Lazy(Func<T> valueFactory) {
			if (valueFactory == null) {
				throw new ArgumentNullException("valueFactory");
			}
			_lock = new object();
			_valueFactory = valueFactory;
			_mode = LazyThreadSafetyMode.ExecutionAndPublication;
		}

		public Lazy(LazyThreadSafetyMode mode) {
			if (Enum.IsDefined(typeof(LazyThreadSafetyMode), mode) == false) {
				throw new ArgumentOutOfRangeException("mode");
			}
			if (mode != LazyThreadSafetyMode.None) {
				_lock = new object();
			}
			_mode = mode;
		}

		//public Lazy(T value) {
		//}

		public Lazy(Func<T> valueFactory, bool isThreadSafe) {
			if (valueFactory == null) {
				throw new ArgumentNullException("valueFactory");
			}
			_valueFactory = valueFactory;
			if (isThreadSafe) {
				_lock = new object();
				_mode = LazyThreadSafetyMode.ExecutionAndPublication;
			} else {
				_mode = LazyThreadSafetyMode.None;
			}
		}

		public Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode) {
			if (valueFactory == null) {
				throw new ArgumentNullException("valueFactory");
			}
			if (Enum.IsDefined(typeof(LazyThreadSafetyMode), mode) == false) {
				throw new ArgumentOutOfRangeException("mode");
			}
			_lock = new object();
			_valueFactory = valueFactory;
			_mode = mode;
		}

		public override string ToString() {
			if (Value == null) {
				throw new NullReferenceException();
			}
			return Value.ToString();
		}
	}
}
#endif // NET20 || NET35
