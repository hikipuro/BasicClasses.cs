#if NET20 || NET35 || NET40 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462 || NET47
namespace System.Runtime.CompilerServices {
	public interface ITuple {
		object this[int index] { get; }
		int Length { get; }
	}
}
#endif // NET20 || NET35 || NET40 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462 || NET47
