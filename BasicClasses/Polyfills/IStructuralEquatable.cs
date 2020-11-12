#if NET20 || NET35
namespace BasicClasses.Polyfills {
	using System.Collections;

	public interface IStructuralEquatable {
		bool Equals(object other, IEqualityComparer comparer);
		int GetHashCode(IEqualityComparer comparer);
	}
}
#endif // NET20 || NET35
