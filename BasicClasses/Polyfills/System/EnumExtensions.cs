#if NET20 || NET35
namespace System {
	public static class EnumExtensions {
		public static bool HasFlag(this Enum @enum, Enum flag) {
			if (flag == null) {
				throw new ArgumentNullException("flag");
			}
			if (@enum.GetType().Equals(flag.GetType()) == false) {
				throw new ArgumentException();
			}
			long flagValue = GetValue(flag);
			return (GetValue(@enum) & flagValue) == flagValue;
		}

		static long GetValue(Enum @enum) {
			return (long)Convert.ChangeType(@enum, @enum.GetTypeCode());
		}
	}
}
#endif // NET20 || NET35
