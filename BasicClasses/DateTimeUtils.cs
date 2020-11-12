namespace BasicClasses {
	using System;

	public static class DateTimeUtils {
		internal readonly static DateTimeOffset UnixTimeOrigin;

		static DateTimeUtils() {
			UnixTimeOrigin = new DateTimeOffset(
				1970, 1, 1, 0, 0, 0, TimeSpan.Zero
			);
		}

		public static int GetUnixTimeSeconds() {
			return (int)(DateTime.UtcNow - UnixTimeOrigin).TotalSeconds;
		}

		public static int GetUnixTimeSeconds(DateTime dateTime) {
			return (int)(dateTime - UnixTimeOrigin).TotalSeconds;
		}

		public static long GetUnixTimeMilliseconds() {
			return (long)(DateTime.UtcNow - UnixTimeOrigin).TotalMilliseconds;
		}

		public static long GetUnixTimeMilliseconds(DateTime dateTime) {
			return (long)(dateTime - UnixTimeOrigin).TotalMilliseconds;
		}

		public static DateTime GetDateTimeFromUnixTimeSeconds(int seconds) {
			DateTime dateTime = new DateTime(UnixTimeOrigin.Ticks);
			return dateTime.AddSeconds(seconds).ToLocalTime();
		}

		public static DateTime GetDateTimeFromUnixTimeMilliseconds(int milliseconds) {
			DateTime dateTime = new DateTime(UnixTimeOrigin.Ticks);
			return dateTime.AddMilliseconds(milliseconds).ToLocalTime();
		}
	}
}
