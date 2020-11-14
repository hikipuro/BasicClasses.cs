#if NET20 || NET35
namespace System.Threading {
	public static class LazyInitializer {
		public static T EnsureInitialized<T>(ref T target) where T : class {
			if (target != null) {
				return target;
			}
			target = default(T);
			return target;
		}

		public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class {
			if (valueFactory == null) {
				throw new ArgumentNullException("valueFactory");
			}
			if (target != null) {
				return target;
			}
			target = valueFactory();
			if (target == null) {
				throw new InvalidOperationException();
			}
			return target;
		}

		public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock) {
			if (initialized) {
				return target;
			}
			if (syncLock == null) {
				syncLock = new object();
			}
			try {
				Monitor.Enter(syncLock);
				target = default(T);
				initialized = true;
			} finally {
				Monitor.Exit(syncLock);
			}
			return target;
		}

		//public static T EnsureInitialized<T>(ref T? target, ref object? syncLock, Func<T> valueFactory) where T : class;

		public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) {
			if (initialized) {
				return target;
			}
			if (syncLock == null) {
				syncLock = new object();
			}
			try {
				Monitor.Enter(syncLock);
				target = valueFactory();
				initialized = true;
			} finally {
				Monitor.Exit(syncLock);
			}
			return target;
		}
	}
}
#endif // NET20 || NET35
