#if NET20 || NET35 || NET40 || NET45 || NET451 || NET452
namespace System {
	using System.Globalization;

	public abstract class FormattableString : IFormattable {
		public abstract int ArgumentCount { get; }
		public abstract string Format { get; }

		public static string Invariant(FormattableString formattable) {
			return string.Format(
				CultureInfo.InstalledUICulture,
				formattable.Format,
				formattable.GetArguments()
			);
		}

		protected FormattableString() {
		}

		public static string CurrentCulture(FormattableString formattable) {
			return string.Format(
				CultureInfo.CurrentCulture,
				formattable.Format,
				formattable.GetArguments()
			);
		}

		public abstract object GetArgument(int index);
		public abstract object[] GetArguments();

		public override string ToString() {
			return ToString(CultureInfo.CurrentCulture);
		}

		public abstract string ToString(IFormatProvider formatProvider);

		public string ToString(string format, IFormatProvider formatProvider) {
			return ToString(formatProvider);
		}
	}

	internal class ConcreteFormattableString : FormattableString {
		public override int ArgumentCount { get; }
		public override string Format { get; }

		object[] _arguments;

		internal ConcreteFormattableString(string format, params object[] arguments) {
			Format = format;
			ArgumentCount = arguments.Length;
			_arguments = arguments;
		}

		public override object GetArgument(int index) {
			return _arguments[index];
		}

		public override object[] GetArguments() {
			return _arguments;
		}

		public override string ToString(IFormatProvider formatProvider) {
			return string.Format(formatProvider, Format, _arguments);
		}
	}
}
#endif // NET20 || NET35 || NET40 || NET45 || NET451 || NET452
