#if NET20
namespace System.Runtime.CompilerServices {
	using System;

	[AttributeUsage(
		AttributeTargets.Assembly |
		AttributeTargets.Class |
		AttributeTargets.Method
	)]
	public sealed class ExtensionAttribute : Attribute {
	}
}
#endif // NET20
