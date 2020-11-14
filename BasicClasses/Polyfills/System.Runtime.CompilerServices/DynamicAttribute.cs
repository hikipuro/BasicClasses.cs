#if NET20 || NET35
namespace System.Runtime.CompilerServices {
	using System.Collections.Generic;

	[AttributeUsage(
		AttributeTargets.Class |
		AttributeTargets.Field |
		AttributeTargets.Parameter |
		AttributeTargets.Property |
		AttributeTargets.ReturnValue |
		AttributeTargets.Struct)]
	public sealed class DynamicAttribute : Attribute {
		public IList<bool> TransformFlags { get; }

		public DynamicAttribute() {
		}

		public DynamicAttribute(bool[] transformFlags) {
			TransformFlags = transformFlags;
		}
	}
}
#endif // NET20 || NET35
