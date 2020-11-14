#if NET20 || NET35 || NET40 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462
namespace System.Runtime.CompilerServices {
	using System.Collections.Generic;

	public sealed class TupleElementNamesAttribute : Attribute {
		public IList<string> TransformNames { get; }

		public TupleElementNamesAttribute(string[] transformNames) {
			TransformNames = transformNames;
		}
	}
}
#endif // NET20 || NET35 || NET40 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462
