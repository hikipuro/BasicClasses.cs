#if NET20
namespace BasicClasses {
	using System.Collections.Generic;

	public interface IReadOnlyCollection<T> : IEnumerable<T> {
		int Count { get; }
	}
}
#endif // NET20