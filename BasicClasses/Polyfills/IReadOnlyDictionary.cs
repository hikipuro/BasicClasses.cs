#if NET20
namespace BasicClasses {
	using System.Collections.Generic;

	public interface IReadOnlyDictionary<TKey, TValue> :
		IEnumerable<KeyValuePair<TKey, TValue>>,
		IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		TValue this[TKey key] { get; }
		IEnumerable<TKey> Keys { get; }
		IEnumerable<TValue> Values { get; }
		bool ContainsKey(TKey key);
		bool TryGetValue(TKey key, out TValue value);
	}
}
#endif // NET20
