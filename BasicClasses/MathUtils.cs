namespace BasicClasses {
	using System;
	using System.Collections.Generic;

	public static class MathUtils {
		public static long Sum(params int[] args) {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			long sum = 0;
			foreach (int i in args) {
				sum += i;
			}
			return sum;
		}

		public static double Sum(params double[] args) {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			double sum = 0;
			foreach (double i in args) {
				sum += i;
			}
			return sum;
		}

		public static long Product(params int[] args) {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Length <= 0) {
				return 0;
			}
			long product = args[0];
			for (int i = 1; i < args.Length; i++) {
				product *= args[i];
			}
			return product;
		}

		public static long Factorial(int value) {
			long n = 1;
			for (int i = 1; i <= value; i++) {
				n *= i;
			}
			return n;
		}

		public static int Min(params int[] args) {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Length <= 0) {
				throw new ArgumentOutOfRangeException("args");
			}
			int min = args[0];
			for (int i = 1; i < args.Length; i++) {
				if (min > args[i]) {
					min = args[i];
				}
			}
			return min;
		}

		public static T Min<T>(params T[] args) where T : IComparable<T> {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Length <= 0) {
				throw new ArgumentOutOfRangeException("args");
			}
			T min = args[0];
			for (int i = 1; i < args.Length; i++) {
				if (min.CompareTo(args[i]) > 0) {
					min = args[i];
				}
			}
			return min;
		}

		public static T Min<T>(IList<T> args) where T : IComparable<T> {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Count <= 0) {
				throw new ArgumentOutOfRangeException("args");
			}
			T min = args[0];
			for (int i = 1; i < args.Count; i++) {
				if (min.CompareTo(args[i]) > 0) {
					min = args[i];
				}
			}
			return min;
		}

		public static int Max(params int[] args) {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Length <= 0) {
				throw new ArgumentOutOfRangeException("args");
			}
			int max = args[0];
			for (int i = 1; i < args.Length; i++) {
				if (max < args[i]) {
					max = args[i];
				}
			}
			return max;
		}

		public static T Max<T>(params T[] args) where T : IComparable<T> {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Length <= 0) {
				throw new ArgumentOutOfRangeException("args");
			}
			T max = args[0];
			for (int i = 1; i < args.Length; i++) {
				if (max.CompareTo(args[i]) < 0) {
					max = args[i];
				}
			}
			return max;
		}

		public static T Max<T>(IList<T> args) where T : IComparable<T> {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Count <= 0) {
				throw new ArgumentOutOfRangeException("args");
			}
			T max = args[0];
			for (int i = 1; i < args.Count; i++) {
				if (max.CompareTo(args[i]) < 0) {
					max = args[i];
				}
			}
			return max;
		}

		public static double Median(params int[] args) {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Length <= 0) {
				throw new ArgumentOutOfRangeException("args");
			}
			if (args.Length == 1) {
				return args[0];
			}
			int length = args.Length;
			List<int> list = new List<int>(args);
			list.Sort();
			if ((length & 1) == 1) {
				return list[length >> 1];
			}
			int i = length >> 1;
			return (double)(list[i - 1] + list[i]) / 2d;
		}

		public static double Median(params double[] args) {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Length <= 0) {
				throw new ArgumentOutOfRangeException("args");
			}
			if (args.Length == 1) {
				return args[0];
			}
			int length = args.Length;
			List<double> list = new List<double>(args);
			list.Sort();
			if ((length & 1) == 1) {
				return list[length >> 1];
			}
			int i = length >> 1;
			return (list[i - 1] + list[i]) / 2d;
		}

		public static double Average(params int[] args) {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Length <= 0) {
				throw new ArgumentOutOfRangeException("args");
			}
			if (args.Length == 1) {
				return args[0];
			}
			long total = 0;
			foreach (int i in args) {
				total += i;
			}
			return total / (double)args.Length;
		}

		public static double Average(params double[] args) {
			if (args == null) {
				throw new ArgumentNullException("args");
			}
			if (args.Length <= 0) {
				throw new ArgumentOutOfRangeException("args");
			}
			if (args.Length == 1) {
				return args[0];
			}
			double total = 0;
			foreach (double i in args) {
				total += i;
			}
			return total / (double)args.Length;
		}

		public static double DegreeToRadian(double degree) {
			return degree * Math.PI / 180d;
		}

		public static double RadianToDegree(double radian) {
			return radian * 180d / Math.PI;
		}

		public static double RadianToTurn(double radian) {
			return radian / (2d * Math.PI);
		}

		public static double TurnToRadian(double turn) {
			return turn * 2d * Math.PI;
		}
	}
}
