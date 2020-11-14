#if NET20
namespace System.Collections.Generic {
	public interface IReadOnlyList<T> : IEnumerable<T>, IReadOnlyCollection<T> {
		T this[int index] { get; }
	}
}
#endif // NET20
