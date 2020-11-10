#if NET20
namespace BasicClasses {
	using System.Collections.Generic;

	public interface IReadOnlyList<T> : IEnumerable<T>, IReadOnlyCollection<T> {
		T this[int index] { get; }
	}
}
#endif // NET20
