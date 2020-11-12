namespace BasicClasses.Polyfills {
	using System;

	public static class DateTimeOffsetExtensions {
#if NET20 || NET35 || NET40 || NET45 || NET451 || NET452
		public static int ToUnixTimeSeconds(this DateTimeOffset dateTimeOffset) {
			return (int)((dateTimeOffset - DateTimeUtils.UnixTimeOrigin).Ticks / 10000000L);
		}
		
		public static long ToUnixTimeMilliseconds(this DateTimeOffset dateTimeOffset) {
			return (dateTimeOffset - DateTimeUtils.UnixTimeOrigin).Ticks / 10000L;
		}
#endif // NET20 || NET35 || NET40 || NET45 || NET451 || NET452

		public static DateTimeOffset FromUnixTimeSeconds(long seconds) {
			return new DateTimeOffset(
				seconds * 10000000L + DateTimeUtils.UnixTimeOrigin.Ticks,
				TimeSpan.Zero
			);
		}

		public static DateTimeOffset FromUnixTimeMilliseconds(long milliseconds) {
			return new DateTimeOffset(
				milliseconds * 10000L + DateTimeUtils.UnixTimeOrigin.Ticks,
				TimeSpan.Zero
			);
		}
	}
}
