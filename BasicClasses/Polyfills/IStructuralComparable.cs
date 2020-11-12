#if NET20 || NET35
namespace BasicClasses.Polyfills {
	using System.Collections;

	public interface IStructuralComparable {
		int CompareTo(object other, IComparer comparer);
	}
}
#endif // NET20 || NET35
