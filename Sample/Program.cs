using System;
using BasicClasses;

namespace Sample {
	class MainClass {
		public static void Main(string[] args) {
			Console.WriteLine("Hello World!");

			TrieTree<string> tree = new TrieTree<string>();
			tree.Insert("a", "test a");
			tree.Insert("ab", "test ab");
			tree.Insert("abc", "test abc");
			tree.Insert("bc", "test bc");
			tree.Insert("cdef", "test cdef");

			Console.WriteLine(tree.Search("a"));
			Console.WriteLine(tree.Search("abc"));
			Console.WriteLine(tree.Search("c"));
			Console.WriteLine(tree.Search("cde"));
			Console.WriteLine(tree.Search("cdef"));
		}
	}
}
