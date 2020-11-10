namespace BasicClasses {
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Polyfills;

	[Serializable]
	public class RingBuffer<T> : IEnumerable<T> {
		protected readonly T[] _buffer;
		protected readonly int _mask;

		public int Head {
			get; protected set;
		}

		public int Tail {
			get; protected set;
		}

		public int Count {
			get; protected set;
		}

		public bool IsEmpty {
			get; protected set;
		}

		public bool IsFull {
			get; protected set;
		}

		public T this[int index] {
			get {
				if (index < 0) {
					throw new IndexOutOfRangeException();
				}
				if (_mask != 0) {
					return _buffer[index & _mask];
				}
				return _buffer[index % Count];
			}
			set {
				if (index < 0) {
					throw new IndexOutOfRangeException();
				}
				if (_mask != 0) {
					_buffer[index & _mask] = value;
					return;
				}
				_buffer[index % Count] = value;
			}
		}

		public RingBuffer(int count) {
			if (count < 1) {
				throw new ArgumentOutOfRangeException("count");
			}
			_buffer = new T[count];
			if (IsPowerOfTwo(count)) {
				_mask = count - 1;
			} else {
				_mask = 0;
			}
			Count = count;
			IsEmpty = true;
		}

		public RingBuffer(int count, Func<int, T> initializer) : this(count) {
			if (initializer == null) {
				return;
			}
			for (int i = 0; i < count; i++) {
				_buffer[i] = initializer(i);
			}
		}

		protected static bool IsPowerOfTwo(int value) {
			return (value & (value - 1)) == 0;
		}

		public void Reset() {
			Head = 0;
			Tail = 0;
			IsEmpty = true;
			IsFull = false;
		}

		public T Read() {
			T item = _buffer[Head++];
			if (Head >= Count) {
				Head = 0;
			}
			IsEmpty = Head == Tail;
			IsFull = false;
			return item;
		}

		public int Read(T[] array) {
			return Read(array, 0, array.Length);
		}

		public int Read(T[] array, int offset, int count) {
			if (array == null) {
				throw new ArgumentNullException("array");
			}
			if (offset < 0) {
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0) {
				throw new ArgumentOutOfRangeException("count");
			}
			if (array.Length < offset + count) {
				throw new ArgumentException(
					"The sum of offset and count is greater than the array length."
				);
			}
			if (IsEmpty || count == 0) {
				return 0;
			}
			if (_mask != 0) {
				int loopEnd = offset + count;
				int i = offset;
				while (i < loopEnd) {
					array[i] = _buffer[Head];
					Head = (Head + 1) & _mask;
					if (Head == Tail) {
						break;
					}
					i++;
				}
				IsEmpty = Head == Tail;
				IsFull = false;
				return i - offset + 1;
			} else {
				int loopEnd = offset + count;
				int i = offset;
				while (i < loopEnd) {
					array[i] = _buffer[Head++];
					if (Head >= Count) {
						Head = 0;
					}
					if (Head == Tail) {
						break;
					}
					i++;
				}
				IsEmpty = Head == Tail;
				IsFull = false;
				return i - offset + 1;
			}
		}

		public int Read(IList<T> list) {
			return Read(list, 0, list.Count);
		}

		public int Read(IList<T> list, int offset, int count) {
			if (list == null) {
				throw new ArgumentNullException("array");
			}
			if (offset < 0) {
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0) {
				throw new ArgumentOutOfRangeException("count");
			}
			if (list.Count < offset + count) {
				throw new ArgumentException(
					"The sum of offset and count is greater than the list length."
				);
			}
			if (IsEmpty || count == 0) {
				return 0;
			}
			if (_mask != 0) {
				int loopEnd = offset + count;
				int i = offset;
				while (i < loopEnd) {
					list[i] = _buffer[Head];
					Head = (Head + 1) & _mask;
					if (Head == Tail) {
						break;
					}
					i++;
				}
				IsEmpty = Head == Tail;
				IsFull = false;
				return i - offset + 1;
			} else {
				int loopEnd = offset + count;
				int i = offset;
				while (i < loopEnd) {
					list[i] = _buffer[Head++];
					if (Head >= Count) {
						Head = 0;
					}
					if (Head == Tail) {
						break;
					}
					i++;
				}
				IsEmpty = Head == Tail;
				IsFull = false;
				return i - offset + 1;
			}
		}

		public void Write(T value) {
			_buffer[Tail++] = value;
			if (Tail >= Count) {
				Tail = 0;
			}
			IsEmpty = false;
			IsFull = Head == Tail;
		}

		public void Write(T[] array) {
			Write(array, 0, array.Length);
		}

		public int Write(T[] array, int offset, int count) {
			if (array == null) {
				throw new ArgumentNullException("array");
			}
			if (offset < 0) {
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0) {
				throw new ArgumentOutOfRangeException("count");
			}
			if (array.Length < offset + count) {
				throw new ArgumentException(
					"The sum of offset and count is greater than the array length."
				);
			}
			if (IsFull || count == 0) {
				return 0;
			}
			if (_mask != 0) {
				int loopEnd = offset + count;
				int i = offset;
				while (i < loopEnd) {
					_buffer[Tail] = array[i];
					Tail = (Tail + 1) & _mask;
					if (Head == Tail) {
						break;
					}
					i++;
				}
				IsEmpty = false;
				IsFull = Head == Tail;
				return i - offset + 1;
			} else {
				int loopEnd = offset + count;
				int i = offset;
				while (i < loopEnd) {
					_buffer[Tail++] = array[i];
					if (Tail >= Count) {
						Tail = 0;
					}
					if (Head == Tail) {
						break;
					}
					i++;
				}
				IsEmpty = false;
				IsFull = Head == Tail;
				return i - offset + 1;
			}
		}

		public int Write(IList<T> list) {
			return Write(list, 0, list.Count);
		}

		public int Write(IList<T> list, int offset, int count) {
			if (list == null) {
				throw new ArgumentNullException("list");
			}
			if (offset < 0) {
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0) {
				throw new ArgumentOutOfRangeException("count");
			}
			if (list.Count < offset + count) {
				throw new ArgumentException(
					"The sum of offset and count is greater than the list length."
				);
			}
			if (IsFull || count == 0) {
				return 0;
			}
			if (_mask != 0) {
				int loopEnd = offset + count;
				int i = offset;
				while (i < loopEnd) {
					_buffer[Tail] = list[i];
					Tail = (Tail + 1) & _mask;
					if (Head == Tail) {
						break;
					}
					i++;
				}
				IsEmpty = false;
				IsFull = Head == Tail;
				return i - offset + 1;
			} else {
				int loopEnd = offset + count;
				int i = offset;
				while (i < loopEnd) {
					_buffer[Tail++] = list[i];
					if (Tail >= Count) {
						Tail = 0;
					}
					if (Head == Tail) {
						break;
					}
					i++;
				}
				IsEmpty = false;
				IsFull = Head == Tail;
				return i - offset + 1;
			}
		}

		public IEnumerator<T> GetEnumerator() {
			return new Enumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return new Enumerator(this);
		}

		public struct Enumerator : IEnumerator<T>, IEnumerator {
			readonly RingBuffer<T> _ringBuffer;
			T _current;

			public T Current {
				get { return _current; }
			}
			object IEnumerator.Current {
				get { return Current; }
			}

			internal Enumerator(RingBuffer<T> ringBuffer) {
				_ringBuffer = ringBuffer;
				_current = default(T);
			}

			public void Dispose() {
			}

			public bool MoveNext() {
				if (_ringBuffer.IsEmpty) {
					return false;
				}
				_current = _ringBuffer.Read();
				return true;
			}

			public void Reset() {
				_current = default(T);
			}
		}
	}
}
