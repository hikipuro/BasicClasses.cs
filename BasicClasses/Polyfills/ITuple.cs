#if NET20 || NET35
namespace BasicClasses.Polyfills {
	public interface ITuple {
		object this[int index] { get; }
		int Length { get; }
	}
}
#endif // NET20 || NET35
