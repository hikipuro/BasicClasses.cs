#if NET20 || NET35
namespace System.Collections {
	public interface IStructuralComparable {
		int CompareTo(object other, IComparer comparer);
	}
}
#endif // NET20 || NET35