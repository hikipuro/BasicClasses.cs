namespace System {
	public static class DateTimeOffsetExtensions {
#if NET20 || NET35 || NET40 || NET45 || NET451 || NET452
		readonly static DateTimeOffset UnixTimeOrigin;
		
		static DateTimeOffsetExtensions() {
			UnixTimeOrigin = new DateTimeOffset(
				1970, 1, 1, 0, 0, 0, TimeSpan.Zero
			);
		}

		public static long ToUnixTimeSeconds(this DateTimeOffset dateTimeOffset) {
			return (dateTimeOffset - UnixTimeOrigin).Ticks / 10000000L;
		}
		
		public static long ToUnixTimeMilliseconds(this DateTimeOffset dateTimeOffset) {
			return (dateTimeOffset - UnixTimeOrigin).Ticks / 10000L;
		}
#endif // NET20 || NET35 || NET40 || NET45 || NET451 || NET452

		public static DateTimeOffset FromUnixTimeSeconds(long seconds) {
			return new DateTimeOffset(
				seconds * 10000000L + UnixTimeOrigin.Ticks,
				TimeSpan.Zero
			);
		}

		public static DateTimeOffset FromUnixTimeMilliseconds(long milliseconds) {
			return new DateTimeOffset(
				milliseconds * 10000L + UnixTimeOrigin.Ticks,
				TimeSpan.Zero
			);
		}
	}
}
