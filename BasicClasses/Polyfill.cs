namespace BasicClasses {
#if NET20
	public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
	public delegate TResult Func<TResult>();
	public delegate TResult Func<T, TResult>(T arg);
	public delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);
#endif // NET20
}
