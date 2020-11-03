namespace BasicClasses {
#if NET20
	public delegate TResult Func<TResult>();
	public delegate TResult Func<T, TResult>(T arg);
#endif // NET20
}
