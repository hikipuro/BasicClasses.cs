#if NET20 || NET35 || NET40 || NET45 || NET451 || NET452
namespace System.Runtime.CompilerServices {
	public static class FormattableStringFactory {
		public static FormattableString Create(string format, params object[] arguments) {
			if (format == null) {
				throw new ArgumentNullException("format");
			}
			if (arguments == null) {
				throw new ArgumentNullException("arguments");
			}
			return new ConcreteFormattableString(format, arguments);
		}
	}
}
#endif // NET20 || NET35 || NET40 || NET45 || NET451 || NET452
