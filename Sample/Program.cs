using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using BasicClasses;

namespace Sample {
	class MainClass {
		public static void Main(string[] args) {
			Console.WriteLine("Hello World!");
			//TestMurmurHash3();
			//TestSiphash();
			//TestHeap();
			//TestXorshift32();
			//TestXorshift128Plus();
			//TestRandomizer();
			//TestBinaryTree();
			TestTrieTree();
		}

		public static double Benchmark(Action action, int count) {
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < count; i++) {
				action();
			}
			stopwatch.Stop();
			return stopwatch.Elapsed.TotalMilliseconds;
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

		public static void TestMurmurHash3() {
			string message = "Short test message";
			byte[] bytes = Encoding.UTF8.GetBytes(message);
			MurmurHash3 hash = new MurmurHash3(0);
			byte[] output = hash.ComputeHash(bytes, 0, bytes.Length);
			uint value = output[0] | (uint)(output[1] << 8) |
				(uint)(output[2] << 16) | (uint)(output[3] << 24);
			Console.WriteLine(value);
		}

		public static void TestSiphash() {
			string key = "This is the key!";
			string message = "aaaShort test message";
			byte[] bytes = Encoding.UTF8.GetBytes(message);
			byte[] k = Encoding.UTF8.GetBytes(key);
			SipHash siphash = new SipHash(8, k);
			byte[] output = siphash.ComputeHash(bytes, 3, bytes.Length - 3);
			for (int i = 0; i < output.Length; i++) {
				Console.WriteLine("{0}: {1:X}", i, output[i]);
			}
			output = siphash.ComputeHash(bytes, 3, bytes.Length - 3);
		}

		public static void TestHeap() {
			Heap<int> heap = new Heap<int>();
			heap.Push(9);
			heap.Push(2);
			heap.Push(6);
			heap.Push(1);
			heap.Push(10);
			heap.Push(3);
			Console.WriteLine("count: {0}", heap.Count);
			heap.Traverse((n) => {
				Console.WriteLine(n);
				return true;
			});

			Console.WriteLine(heap.Pop());
			Console.WriteLine(heap.Pop());
			Console.WriteLine(heap.Pop());
			Console.WriteLine(heap.Pop());
			Console.WriteLine(heap.Pop());
			Console.WriteLine(heap.Pop());
		}

		public static void TestXorshift32() {
			Random random = new Random();
			double time = Benchmark(() => {
				random.Next();
			}, 100000);
			Console.WriteLine("time: {0}", time);

			Xorshift32 xorshift = new Xorshift32();
			time = Benchmark(() => {
				xorshift.Next();
			}, 100000);
			Console.WriteLine("time: {0}", time);
		}

		public static void TestXorshift128Plus() {
			Random random = new Random();
			double time = Benchmark(() => {
				random.Next();
			}, 100000);
			Console.WriteLine("time: {0}", time);

			Xorshift128Plus xorshift = new Xorshift128Plus();
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(xorshift.Next());
			}
			time = Benchmark(() => {
				xorshift.Next();
			}, 100000);
			Console.WriteLine("time: {0}", time);
		}

		public static void TestRandomizer() {
			int[] array = new int[10];
			for (int i = 0; i < array.Length; i++) {
				array[i] = i;
			}
			Randomizer.Shuffle(array);
			for (int i = 0; i < array.Length; i++) {
				Console.WriteLine(array[i]);
			}
			Console.WriteLine();
			List<int> list = new List<int>();
			for (int i = 0; i < 10; i++) {
				list.Add(i);
			}
			Randomizer.Shuffle(list);
			for (int i = 0; i < list.Count; i++) {
				Console.WriteLine(list[i]);
			}
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
			tree["a"] = "test a";
			tree["a"] = "test aa";
			tree.Add("ab", "test ab");
			tree.Add("abc", "test abc");
			tree.Add("bc", "test bc");
			tree.Add("cdef", "test cdef");
			tree.Add("😁", "test 😁");

			tree = TestSerialize(tree);

			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("😁");

			tree.Remove("a");
			tree.Traverse((node) => {
				Console.WriteLine("{0}: {1}", node.GetWord(), node);
				return true;
			});

			Console.WriteLine();

			Console.WriteLine(tree["a"]);
			Console.WriteLine(tree.Search("abc"));
			Console.WriteLine(tree.Search("c"));
			Console.WriteLine(tree.Search("cde"));
			Console.WriteLine(tree.Search("cdef"));
		}
	}
}
