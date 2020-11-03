using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using BasicClasses;

namespace Sample {
	class MainClass {
		public static void Main(string[] args) {
			Console.WriteLine("Hello World!");
			TestBinaryTree();
			//TestTrieTree();
		}

		public static T TestSerialize<T>(T value) {
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new MemoryStream();
			formatter.Serialize(stream, value);
			stream.Position = 0;
			value = (T)formatter.Deserialize(stream);
			stream.Close();
			return value;
		}

		public static void TestBinaryTree() {
			BinaryTree<int, int> tree = new BinaryTree<int, int>();
			tree.Insert(123, 123);
			tree.Insert(21, 21);
			tree.Insert(54, 54);
			tree.Insert(74, 74);
			tree.Insert(32, 32);

			tree = TestSerialize(tree);

			Console.WriteLine(tree.Search(21));
			Console.WriteLine(tree.Search(11));
			Console.WriteLine(tree.Search(74));
			tree.Traverse((node) => {
				Console.WriteLine(node);
				return true;
			});
		}

		public static void TestTrieTree() {
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
