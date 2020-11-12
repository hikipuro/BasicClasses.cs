#if NET20 || NET35 || NET40 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462 || NET47 || NET471 || NET472 || NET48
namespace BasicClasses.Polyfills {
	using System;

	public static class MathF {
		public const float E = 2.71828175f;
		public const float PI = 3.14159274f;
		public const float Tau = 6.28318548f;
		const double LOG2E = 1.4426950408889634;
		const double LN2 = 0.6931471805599453;

		public static float Abs(float x) {
			return Math.Abs(x);
		}

		public static float Acos(float x) {
			return (float)Math.Acos(x);
		}

		public static float Acosh(float x) {
			return Log(x + Sqrt(x * x - 1));
		}

		public static float Asin(float x) {
			return (float)Math.Asin(x);
		}

		public static float Asinh(float x) {
			double absX = Math.Abs(x);
			double w;
			if (absX < 3.725290298461914e-9) {
				return (float)x;
			}
			if (absX > 268435456) {
				w = Math.Log(absX) + LN2;
			} else if (absX > 2) {
				w = Math.Log(2 * absX + 1 / (Math.Sqrt(x * x + 1) + absX));
			} else {
				double t = x * x;
				w = Log1p(absX + t / (1 + Math.Sqrt(1 + t)));
			}
			return x > 0 ? (float)w : (float)-w;
		}

		public static float Atan(float x) {
			return (float)Math.Atan(x);
		}

		public static float Atan2(float y, float x) {
			return (float)Math.Atan2(y, x);
		}

		public static float Atanh(float x) {
			return Log((1f + x) / (1f - x)) / 2f;
		}

		public static float BitDecrement(float x) {
			/*
			if (float.IsNegativeInfinity(x)) {
				return float.NegativeInfinity;
			}
			if (float.IsNaN(x)) {
				return float.NaN;
			}
			*/
			throw new NotImplementedException();
		}

		public static float BitIncrement(float x) {
			/*
			if (float.IsPositiveInfinity(x)) {
				return float.PositiveInfinity;
			}
			if (float.IsNaN(x)) {
				return float.NaN;
			}
			*/
			throw new NotImplementedException();
		}

		public static float Cbrt(float x) {
			return x < 0f ? -Pow(-x, 1f / 3f) : Pow(x, 1f / 3f);
		}

		public static float Ceiling(float x) {
			return (float)Math.Ceiling(x);
		}

		public static float CopySign(float x, float y) {
			return Abs(x) * Sign(y);
		}

		public static float Cos(float x) {
			return (float)Math.Cos(x);
		}

		public static float Cosh(float x) {
			return (float)Math.Cosh(x);
		}

		public static float Exp(float x) {
			return (float)Math.Exp(x);
		}

		public static float Floor(float x) {
			return (float)Math.Floor(x);
		}

		public static float FusedMultiplyAdd(float x, float y, float z) {
			throw new NotImplementedException();
		}

		public static float IEEERemainder(float x, float y) {
			return (float)Math.IEEERemainder(x, y);
		}

		public static int ILogB(float x) {
			if (x == 0) {
				return int.MinValue;
			}
			if (float.IsNaN(x) || float.IsInfinity(x)) {
				return int.MaxValue;
			}
			return (int)Log2(x);
		}

		public static float Log(float x, float y) {
			return (float)Math.Log(x, y);
		}

		public static float Log(float x) {
			return (float)Math.Log(x);
		}

		public static float Log10(float x) {
			return (float)Math.Log10(x);
		}

		public static float Log2(float x) {
			return (float)(Math.Log(x) * LOG2E);
		}

		public static float Max(float x, float y) {
			return Math.Max(x, y);
		}

		public static float MaxMagnitude(float x, float y) {
			if (float.IsNaN(x) || float.IsNaN(y)) {
				return float.NaN;
			}
			return Abs(x) > Abs(y) ? x : y;
		}

		public static float Min(float x, float y) {
			return Math.Min(x, y);
		}

		public static float MinMagnitude(float x, float y) {
			if (float.IsNaN(x) || float.IsNaN(y)) {
				return float.NaN;
			}
			return Abs(x) < Abs(y) ? x : y;
		}

		public static float Pow(float x, float y) {
			return (float)Math.Pow(x, y);
		}

		public static float Round(float x, int digits, MidpointRounding mode) {
			return (float)Math.Round(x, digits, mode);
		}

		public static float Round(float x, MidpointRounding mode) {
			return (float)Math.Round(x, mode);
		}

		public static float Round(float x) {
			return (float)Math.Round(x);
		}

		public static float Round(float x, int digits) {
			return (float)Math.Round(x, digits);
		}

		public static float ScaleB(float x, int n) {
			return x * (1 << n);
		}

		public static int Sign(float x) {
			return Math.Sign(x);
		}

		public static float Sin(float x) {
			return (float)Math.Sin(x);
		}

		public static float Sinh(float x) {
			return (float)Math.Sinh(x);
		}

		public static float Sqrt(float x) {
			return (float)Math.Sqrt(x);
		}

		public static float Tan(float x) {
			return (float)Math.Tan(x);
		}

		public static float Tanh(float x) {
			return (float)Math.Tanh(x);
		}

		public static float Truncate(float x) {
			return (float)Math.Truncate(x);
		}

		static double Log1p(double x) {
			if (x < -1 || x != x) {
				return double.NaN;
			}
			if (x == 0 || double.IsPositiveInfinity(x)) {
				return x;
			}
			double nearX = (x + 1) - 1;
			return nearX == 0 ? x : x * (Math.Log(x + 1) / nearX);
		}
	}
}
#endif // NET20 || NET35 || NET40 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462 || NET47 || NET471 || NET472 || NET48
