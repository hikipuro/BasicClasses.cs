#if NET20 || NET35
namespace System.Threading {
	public enum LazyThreadSafetyMode {
		None = 0,
		PublicationOnly = 1,
		ExecutionAndPublication = 2
	}
}
#endif // NET20 || NET35
