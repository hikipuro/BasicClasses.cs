using System;

namespace BasicClasses {
	public static class GrowingArrayUtils {
		public const int MinSize = 4;
		public const int MinAllocationSize = 8;

		public static void Append<T>(ref T[] array, int currentSize, T item) {
			if (currentSize + 1 > array.Length) {
				Grow(ref array, currentSize);
			}
			array[currentSize] = item;
		}

		public static void Insert<T>(ref T[] array, int currentSize, int index, T item) {
			if (currentSize + 1 > array.Length) {
				Grow(ref array, currentSize);
				Array.Copy(
					array, index,
					array, index + 1,
					array.Length - index - 1
				);
			} else {
				Array.Copy(
					array, index,
					array, index + 1,
					currentSize - index - 1
				);
			}
			array[index] = item;
		}

		public static void Remove<T>(ref T[] array, int currentSize, int index) {
			Array.Copy(
				array, index + 1,
				array, index,
				currentSize - index - 1
			);
		}

		public static T[] Grow<T>(ref T[] array, int currentSize) {
			Array.Resize(
				ref array,
				currentSize <= MinSize ? MinAllocationSize : currentSize * 2
			);
			return array;
		}
	}
}
